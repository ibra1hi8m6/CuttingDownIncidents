using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CuttingDownIncidents.Infrastructure.ViewModel
{
    public class NetworkElementTypeDTO
    {
        public int Network_Element_Type_Key { get; set; }
        public string Network_Element_Type_Name { get; set; }
        public int? Parent_Network_Element_Type_Key { get; set; }
        public int Network_Element_Hierarchy_Path_Key { get; set; }
    }
}
