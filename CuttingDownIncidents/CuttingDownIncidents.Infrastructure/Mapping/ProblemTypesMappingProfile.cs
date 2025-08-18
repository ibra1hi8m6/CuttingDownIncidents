using AutoMapper;
using CuttingDownIncidents.Domain.Entities;
using CuttingDownIncidents.Infrastructure.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CuttingDownIncidents.Infrastructure.Mapping
{
    public class ProblemTypesMappingProfile : Profile
    {
        public ProblemTypesMappingProfile()
        {
            CreateMap<ProblemType, ProblemTypesDTO>().ReverseMap();
            
          
          
        }
    }
}
