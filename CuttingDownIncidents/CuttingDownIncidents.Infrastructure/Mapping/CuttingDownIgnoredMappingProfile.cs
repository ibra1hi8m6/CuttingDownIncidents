using AutoMapper;
using CuttingDownIncidents.Domain.Entities.FactTables.Cutting_Down_Fact;
using CuttingDownIncidents.Infrastructure.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CuttingDownIncidents.Infrastructure.Mapping
{
    public class CuttingDownIgnoredMappingProfile : Profile
    {
        public CuttingDownIgnoredMappingProfile()
        {
            CreateMap<CuttingDownIgnored, CuttingDownIgnoredDto>().ReverseMap();
        }
    }
}
