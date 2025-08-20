using AutoMapper;
using CuttingDownIncidents.Domain.Entities.FactTables;
using CuttingDownIncidents.Infrastructure.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CuttingDownIncidents.Infrastructure.Mapping
{
    public class ChannelMappingProfile : Profile
    {
        public ChannelMappingProfile()
        {
            CreateMap<Channel, ChannelDTO>().ReverseMap();
        }
    }
}
