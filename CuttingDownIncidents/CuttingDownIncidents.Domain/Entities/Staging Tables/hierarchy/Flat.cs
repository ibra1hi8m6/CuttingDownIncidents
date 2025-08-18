using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CuttingDownIncidents.Domain.Entities.Staging_Tables.hierarchy
{
    [Table("Flat")]
    public class Flat
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Flat_Key { get; set; }
        public int Building_Key { get; set; }
        public Building? Building { get; set; }
    }
}
