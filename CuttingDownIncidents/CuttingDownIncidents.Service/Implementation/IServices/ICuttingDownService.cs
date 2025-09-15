using CuttingDownIncidents.Infrastructure.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CuttingDownIncidents.Service.Implementation.IServices
{
    public interface ICuttingDownService
    {
        Task<CuttingDownSearchResult> SearchIncidentsAsync(CuttingDownSearchFilter filter);
        Task<int> CreateIncidentAsync(CreateCuttingDownIncidentDTO dto);
    }
}
