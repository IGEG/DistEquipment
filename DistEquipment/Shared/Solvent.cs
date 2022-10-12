using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistEquipment.Shared
{
    public class Solvent
    {
        public int Id { get; set; }

        public string  Name { get; set; }

        [Column(TypeName = "Decimal(10,2)")]
        public decimal? Price { get; set; }
    }
}
