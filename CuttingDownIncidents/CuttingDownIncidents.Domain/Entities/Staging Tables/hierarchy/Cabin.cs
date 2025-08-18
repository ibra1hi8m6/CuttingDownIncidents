using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CuttingDownIncidents.Domain.Entities.Staging_Tables.hierarchy
{
    [Table("Cabin")]
    public class Cabin
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Cabin_Key { get; set; }
        public int Tower_Key { get; set; }
        public Tower? Tower { get; set; }
        public string Cabin_Name { get; set; }

       
    }
}
