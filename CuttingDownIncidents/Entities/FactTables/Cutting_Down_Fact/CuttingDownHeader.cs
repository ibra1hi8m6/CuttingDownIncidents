using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppWETask
{
    [Table("Cutting_Down_Header")]
    public class CuttingDownHeader
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Cutting_Down_Key { get; set; }
        public int Cutting_Down_Incident_ID { get; set; }
        public CuttingDownIgnored? CuttingDownIgnored { get; set; }
        public int Channel_Key { get; set; }
        public Channel? Channel { get; set; }
        public int Cutting_Down_Problem_Type_Key { get; set; }
        public ProblemType? ProblemType { get; set; }
        public DateTime ActualCreatetDate { get; set; }
        public DateTime SynchCreateDate { get; set; }
        public DateTime? SynchUpdateDate { get; set; }
        public DateTime? ActualEndDate { get; set; }
       
        public bool IsPaused { get; set; }
        public bool IsGlobal { get; set; }
        public DateTime? PlannedStartDTS { get; set; }
        public DateTime? PlannedEndDTS { get; set; }
        public bool IsActive { get; set; }
        public string? CreatedUser { get; set; }
        public string? UpdatedUser { get; set; }

        public override string ToString()
        {
            return $"[{Cutting_Down_Key}] Channel: {Channel_Key}, Created: {ActualCreatetDate:yyyy-MM-dd}";
        }
    }
}
