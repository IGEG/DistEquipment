﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistEquipment.Shared
{
    public class Category
    {
        [Key]
        public int IdCategory { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }

        public string? Img { get; set; }
        public string Url { get; set; }
     

    }
}
