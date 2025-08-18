using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CuttingDownIncidents.Domain.Entities.Staging_Tables.hierarchy
{
    [Table("Subscription")]
    public class Subscription
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Subscription_Key { get; set; }
        public int? Flat_Key { get; set; }
        public Flat? Flat { get; set; }
        public int Building_Key { get; set; }
        public int? Meter_Key { get; set; }
        public int? Payer_Key { get; set; }

        
       
    }
}
