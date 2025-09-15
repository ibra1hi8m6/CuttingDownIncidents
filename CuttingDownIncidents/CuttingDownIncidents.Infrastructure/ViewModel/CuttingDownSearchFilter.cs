using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CuttingDownIncidents.Infrastructure.ViewModel
{
    public class CuttingDownSearchFilter
    {
        public int? ChannelKey { get; set; }
        public int? ProblemTypeKey { get; set; }
        public string Status { get; set; }
        public int? NetworkElementTypeKey { get; set; }
        public string SearchValue { get; set; }
        public int PageNumber { get; set; } = 1;
        public int PageSize { get; set; } = 20;
       
    }
}
