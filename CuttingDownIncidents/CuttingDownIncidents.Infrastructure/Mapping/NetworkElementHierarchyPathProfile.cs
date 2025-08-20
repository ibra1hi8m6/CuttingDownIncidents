using AutoMapper;
using CuttingDownIncidents.Domain.Entities;
using CuttingDownIncidents.Domain.Entities.FactTables.Network;
using CuttingDownIncidents.Infrastructure.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CuttingDownIncidents.Infrastructure.Mapping
{
    public class NetworkElementHierarchyPathMappingProfile : Profile
    {
        public NetworkElementHierarchyPathMappingProfile()
        {
            CreateMap<NetworkElementHierarchyPath, NetworkElementHierarchyPathDTO>().ReverseMap();

        }

    }
}
