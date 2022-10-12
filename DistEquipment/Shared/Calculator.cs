using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistEquipment.Shared
{
    public class Calculator
    {
        public int Id { get; set; }
        public int Hours { get; set; }
        public  ProductModel ProductModel { get; set; }
        public Solvent Solvent { get; set; }

    }
}
