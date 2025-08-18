using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppWETask
{
    [Table ("Sector")]
    public class Sector
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Sector_Key {  get; set; }
        public int Governrate_Key { get; set; }
        public Governrate? Governrate { get; set; }
        public string Sector_Name { get; set; }
       

    }
}
