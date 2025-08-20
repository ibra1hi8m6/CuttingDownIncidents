using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CuttingDownIncidents.Infrastructure.ViewModel
{
    public class CuttingDownIgnoredDto
    {
        public int Cutting_Down_Incident_ID { get; set; }
        public DateTime ActualEndDate { get; set; }
        public DateTime SynchCreateDate { get; set; }
        public string? Cable_Name { get; set; }
        public string? Cabin_Name { get; set; }
        public int? CreatedUser { get; set; }
    }
}
