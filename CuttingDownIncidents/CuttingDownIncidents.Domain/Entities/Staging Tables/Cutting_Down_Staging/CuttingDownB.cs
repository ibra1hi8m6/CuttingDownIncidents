using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CuttingDownIncidents.Domain.Entities.Staging_Tables
{
    [Table("Cutting_Down_B")]
    public class CuttingDownB
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Cutting_Down_B_Incident_ID { get; set; }
        public string Cutting_Down_Cable_Name { get; set; }
        public int Problem_Type_Key { get; set; }
        public ProblemType? Problem_Type { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime? EndDate { get; set; }
        public bool IsPlanned { get; set; }
        public bool IsGlobal { get; set; }
        public DateTime? PlannedStartDTS { get; set; }
        public DateTime? PlannedEndDTS { get; set; }
        public bool IsActive { get; set; }
        public string? CreatedUser { get; set; }
        public string? UpdatedUser { get; set; }

        
    }
}
