using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppWETask
{
    [Table("Problem_Type")]
    public class ProblemType
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Problem_Type_Key { get; set; }
        public string Problem_Type_Name { get; set; }

        public override string ToString()
        {
            return $"[{Problem_Type_Key}] {Problem_Type_Name}";
        }
    }
}
