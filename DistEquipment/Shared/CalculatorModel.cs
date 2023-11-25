using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistEquipment.Shared
{
    public class CalculatorModel
    {
        [Required(ErrorMessage = "Выберете модель дистиллятора")]
        public int Volume { get; set; }
        [Required(ErrorMessage = "Выберете марку растворителя")]
        public decimal PriceSolvent { get; set; }
        [Required(ErrorMessage = "Выберете режим работы")]
        public int Hours { get; set; }
    }
}
