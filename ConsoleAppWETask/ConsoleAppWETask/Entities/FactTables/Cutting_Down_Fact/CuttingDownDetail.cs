
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppWETask
{
    [Table("Cutting_Down_Detail")]
    public class CuttingDownDetail
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Cutting_Down_Detail_Key { get; set; }
        public int Cutting_Down_Key { get; set; }
        public CuttingDownHeader? Cutting_Down_Header { get; set; }
        public int Network_Element_Key { get; set; }
        public NetworkElement? networkElement { get; set; }
        public DateTime ActualCreatetDate { get; set; }
        public DateTime? ActualEndDate { get; set; }
        public int ImpactedCustomers { get; set; }

        
    }
}
