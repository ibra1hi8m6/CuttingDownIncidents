using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CuttingDownIncidents.Domain.Entities.Staging_Tables.hierarchy
{
    [Table("Station")]
    public class Station
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Station_Key { get; set; }
        public int City_Key { get; set; }
        public City? City { get; set; }
        public string Station_Name { get; set; }
        
    }
}
