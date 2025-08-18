using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppWETask  
{
    [Table("Cable")]
    public class Cable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Cable_Key { get; set; }
        public int Cabin_Key { get; set; }
        public Cabin? Cabin { get; set; }
        public string Cable_Name { get; set; }
        
    }
}
