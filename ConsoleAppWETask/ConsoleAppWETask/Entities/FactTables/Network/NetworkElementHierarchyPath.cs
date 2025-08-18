using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppWETask
{
    [Table("Network_Element_Hierarchy_Path")]
    public class NetworkElementHierarchyPath
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Network_Element_Hierarchy_Path_Key { get; set; }
        public string Network_Element_Hierarchy_Path_Name { get; set; }
        public string Abbreviation { get; set; }
    }
}
