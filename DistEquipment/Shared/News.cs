using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistEquipment.Shared

{
    [Table("NewsMenu")]
    public class News
    {
        public int Id { get; set; }
        public string? UrlName { get; set; }
        public string? Image { get; set; }
        public string? Title { get; set; }
        public string? SmallDescription { get; set; }
        public string? BigDescription { get; set; }

    }
}
