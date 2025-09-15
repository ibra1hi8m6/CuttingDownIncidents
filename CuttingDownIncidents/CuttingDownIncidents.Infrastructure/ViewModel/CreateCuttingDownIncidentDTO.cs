using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CuttingDownIncidents.Infrastructure.ViewModel
{
    public class CreateCuttingDownIncidentDTO
    {
        public int Cutting_Down_Problem_Type_Key { get; set; }   
        public DateTime ActualCreatetDate { get; set; }          
        public int Network_Element_Key { get; set; }             
        public int ImpactedCustomers { get; set; }               
        public string CreatedUser { get; set; }                  
    }
}

