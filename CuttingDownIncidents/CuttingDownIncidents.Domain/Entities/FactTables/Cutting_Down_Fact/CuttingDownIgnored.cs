using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CuttingDownIncidents.Domain.Entities.FactTables.Cutting_Down_Fact
{
    [Table("Cutting_Down_Ignored")]
    public class CuttingDownIgnored
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Cutting_Down_Incident_ID { get; set; }
        public DateTime ActualEndDate { get; set; }
        public DateTime SynchCreateDate { get; set; }
        
        public string? Cable_Name { get; set; } 
        public string? Cabin_Name { get; set; } 
        public int? CreatedUser { get; set; }

    }
}
