using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppWETask.Entities.Forms
{
    public class CuttingDownForm
    {
        public string SourceType { get; set; } = "A";
        public string CabinName { get; set; }
        public string CableName { get; set; }
        public int ProblemTypeKey { get; set; }
        public DateTime CreateDate { get; set; } = DateTime.Now;
        public DateTime? EndDate { get; set; }
        public bool IsPlanned { get; set; }
        public bool IsGlobal { get; set; }
        public DateTime? PlannedStartDTS { get; set; }
        public DateTime? PlannedEndDTS { get; set; }
        public bool IsActive { get; set; } = true;
        public string CreatedUser { get; set; }
        public string UpdatedUser { get; set; }
        public int? NetworkElementKey { get; set; }
        public int ImpactedCustomers { get; set; }
    }
}
