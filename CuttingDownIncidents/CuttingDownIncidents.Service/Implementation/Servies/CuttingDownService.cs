using CuttingDownIncidents.Data;
using CuttingDownIncidents.Domain.Entities;
using CuttingDownIncidents.Domain.Entities.FactTables;
using CuttingDownIncidents.Domain.Entities.FactTables.Cutting_Down_Fact;
using CuttingDownIncidents.Domain.Entities.FactTables.Network;
using CuttingDownIncidents.Infrastructure.ViewModel;
using CuttingDownIncidents.Service.Implementation.IServices;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CuttingDownIncidents.Service.Implementation.Servies
{
    public class CuttingDownService : ICuttingDownService
    {
        private readonly IRepository<CuttingDownHeader> _headerRepository;
        private readonly IRepository<CuttingDownDetail> _detailRepository;
        private readonly IRepository<Channel> _channelRepository;
        private readonly IRepository<ProblemType> _problemTypeRepository;
        private readonly IRepository<NetworkElement> _networkElementRepository;

        public CuttingDownService(
            IRepository<CuttingDownHeader> headerRepository,
            IRepository<CuttingDownDetail> detailRepository,
            IRepository<Channel> channelRepository,
            IRepository<ProblemType> problemTypeRepository,
            IRepository<NetworkElement> networkElementRepository)
        {
            _headerRepository = headerRepository;
            _detailRepository = detailRepository;
            _channelRepository = channelRepository;
            _problemTypeRepository = problemTypeRepository;
            _networkElementRepository = networkElementRepository;
        }

        public async Task<CuttingDownSearchResult> SearchIncidentsAsync(CuttingDownSearchFilter filter)
        {
            IQueryable<CuttingDownHeader> headerQuery = _headerRepository.GetQueryable()
                .Include(h => h.Channel)
                .Include(h => h.ProblemType);

            // ---- Apply simple filters ----
            if (filter.ChannelKey.HasValue)
                headerQuery = headerQuery.Where(h => h.Channel_Key == filter.ChannelKey.Value);

            if (filter.ProblemTypeKey.HasValue)
                headerQuery = headerQuery.Where(h => h.Cutting_Down_Problem_Type_Key == filter.ProblemTypeKey.Value);

            if (!string.IsNullOrEmpty(filter.Status))
            {
                headerQuery = filter.Status.ToLower() switch
                {
                    "open" => headerQuery.Where(h => h.IsActive && h.ActualEndDate == null),
                    "closed" => headerQuery.Where(h => !h.IsActive || h.ActualEndDate != null),
                    _ => headerQuery
                };
            }

            // ---- Pagination ----
            var totalCount = await headerQuery.CountAsync();
            var headers = await headerQuery
                .OrderByDescending(h => h.ActualCreatetDate)
                .Skip((filter.PageNumber - 1) * filter.PageSize)
                .Take(filter.PageSize)
                .ToListAsync();

            // ---- Only fetch details for returned headers ----
            var headerKeys = headers.Select(h => h.Cutting_Down_Key).ToList();
            var details = await _detailRepository.GetQueryable()
                .Include(d => d.networkElement)
                .Where(d => headerKeys.Contains(d.Cutting_Down_Key))
                .ToListAsync();

            return new CuttingDownSearchResult
            {
                Headers = headers,
                Details = details,
                TotalCount = totalCount,
                PageNumber = filter.PageNumber,
                PageSize = filter.PageSize
            };
        }

        public async Task<int> CreateIncidentAsync(CreateCuttingDownIncidentDTO dto)
        {
            // 1. Create Header
            var header = new CuttingDownHeader
            {
                Cutting_Down_Problem_Type_Key = dto.Cutting_Down_Problem_Type_Key,
                ActualCreatetDate = dto.ActualCreatetDate,
                SynchCreateDate = DateTime.UtcNow,
                CreatedUser = dto.CreatedUser,
                IsActive = true,
                IsGlobal = false,
                IsPaused = false
            };

            await _headerRepository.AddAsync(header);
            await _headerRepository.SaveAsync();

            // 2. Create Detail linked to header
            var detail = new CuttingDownDetail
            {
                Cutting_Down_Key = header.Cutting_Down_Key, // FK from saved header
                Network_Element_Key = dto.Network_Element_Key,
                ActualCreatetDate = dto.ActualCreatetDate,
                ImpactedCustomers = dto.ImpactedCustomers
            };

            await _detailRepository.AddAsync(detail);
            await _detailRepository.SaveAsync();

            return header.Cutting_Down_Key;
        }

    }
}
