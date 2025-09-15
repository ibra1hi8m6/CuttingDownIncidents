using CuttingDownIncidents.Domain.Entities.FactTables.Cutting_Down_Fact;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CuttingDownIncidents.Infrastructure.ViewModel
{
    public class CuttingDownSearchResult
    {
        public List<CuttingDownHeader> Headers { get; set; } = new List<CuttingDownHeader>();
        public List<CuttingDownDetail> Details { get; set; } = new List<CuttingDownDetail>();
        public int TotalCount { get; set; }
        public int PageNumber { get; set; }
        public int PageSize { get; set; }
        public int TotalPages => (int)Math.Ceiling(TotalCount / (double)PageSize);
    }
}
