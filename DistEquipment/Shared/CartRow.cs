using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistEquipment.Shared
{
    public class CartRow
    {
        public int ProductId { get; set; }
        public int? OptionId { get; set; }
        public string ProductName { get; set; }
        public string? OptionName { get; set; }
        public decimal? Price { get; set; }
        public string? Img { get; set; }
        public int Quantity { get; set; }
    }
}
