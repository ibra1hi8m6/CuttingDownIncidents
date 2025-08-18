using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CuttingDownIncidents.Domain.Entities.FactTables.Network
{
    [Table("Network_Element")]
    public class NetworkElement
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Network_Element_Key { get; set; }
        public string Network_Element_Name { get; set; }
        public int Network_Element_Type_Key { get; set; }
        public NetworkElementType? NetworkElementType { get; set; }
        public int? Parent_Network_Element_Key { get; set; }
    }
}
