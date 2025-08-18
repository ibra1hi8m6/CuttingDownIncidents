using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CuttingDownIncidents.Domain.Entities.Staging_Tables.hierarchy
{
    [Table("Zone")]
    public class Zone
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Zone_Key { get; set; }
        public int Sector_Key { get; set; }
        public Sector? Sector { get; set; }
        public string Zone_Name { get; set; }
        
    }
}
