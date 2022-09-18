using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace DistEquipment.Shared
{
    public class ProductModel
    {
        public int ProductId { get; set; }
        [JsonIgnore]
        public Product Product { get; set; }
        public int ProductOptionId { get; set; }
        public ProductOption ProductOption { get; set; }

        [Column(TypeName = "Decimal(10,2)")]
        public decimal? Price { get; set; }

        [Column(TypeName = "Decimal(10,2)")]
        public decimal? OldPrice { get; set; }
    }
}
