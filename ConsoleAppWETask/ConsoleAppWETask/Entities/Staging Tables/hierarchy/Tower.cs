using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppWETask
{
    [Table("Tower")]
    public class Tower
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Tower_Key { get; set; }
        public int Station_Key { get; set; }
        public Station? Station { get; set; }
        public string Tower_Name { get; set; }
        
    }
}
