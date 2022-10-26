using System.ComponentModel.DataAnnotations;

namespace DistEquipment.Client.Models
{
    public class ModelFormCalculator
    {
        [Required(ErrorMessage ="Выберете модель дистиллятора")]
        public int Volume { get; set; }
        [Required(ErrorMessage ="Выберете марку растворителя")]
        public decimal PriceSolvent { get; set; }
        [Required(ErrorMessage ="Выберете режим работы")]
        public int Hours { get; set; }
    }

 
}
