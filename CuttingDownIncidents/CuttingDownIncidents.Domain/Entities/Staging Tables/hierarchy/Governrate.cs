using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CuttingDownIncidents.Domain.Entities.Staging_Tables.hierarchy
{
    [Table  ("Governrate")]
    public class Governrate
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public int Governrate_Key { get; set; }

        public string Governrate_Name { get; set; }
    }
}
