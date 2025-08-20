using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppWETask
{
    [Table  ("Governrate")]
    public class Governrate
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public int Governrate_Key { get; set; }

        public string Governrate_Name { get; set; }

        public override string ToString()
        {
            return $"[{Governrate_Key}] {Governrate_Name}";
        }
    }
}
