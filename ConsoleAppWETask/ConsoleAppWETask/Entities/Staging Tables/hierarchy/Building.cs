using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppWETask
{
    [Table("Building")]
    public class Building
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Building_Key { get; set; }
        public int Block_Key { get; set; }
        public Block? Block { get; set; }
        public string Building_Name { get; set; }

        
    }
}
