using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppWETask
{
    [Table("Block")]
    public class Block
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Block_Key { get; set; }
        public int Cable_Key { get; set; }
        public Cable? Cable { get; set; }
        public string Block_Name { get; set; }

        
    }
}
