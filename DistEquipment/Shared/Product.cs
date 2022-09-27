using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistEquipment.Shared
{
    public class Product
    {
   
        public int Id { get; set; }
        public string Name { get; set; }
        public string? SmallDescription { get; set; }
        public string? BigDescription { get; set; }
        public string? Images { get; set; }
        public string URL { get; set; }

        [Column(TypeName ="Decimal(10,2)")]
        public decimal? SpesialPrice { get; set; }
        public int CategoryId { get; set; }
        public Category? Category { get; set; }
        public bool IsOpen { get; set; }
        public bool IsClose { get; set; }
        public DateTime DateOfSaller { get; set; } = DateTime.Now;

        public DateTime? DateOfUpdate { get; set; }

        public List<ProductModel> ProductModels { get; set; } = new List<ProductModel>();
        public int Views { get; set; }
    }
}
