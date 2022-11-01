using System.ComponentModel.DataAnnotations;

namespace DistEquipment.Shared
{
    public class FeedBackForm
    {

        public string PageName { get; set; } = string.Empty;
        [Required(ErrorMessage = "Укажите Ваше Имя")]
        public string Name { get; set; } = string.Empty;
        [Required(ErrorMessage = "Укажите название компании")]
        public string CompanyName { get; set; } = string.Empty;
        [Required(ErrorMessage = "Укажите телефон для связи")]
        [Phone]
        public string TelephoneNumber { get; set; } = string.Empty;
        [Required(ErrorMessage = "Укажите адрес электронной почты")]
        [RegularExpression(@"[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,4}", ErrorMessage = "Некорректный адрес")]
        public string Email { get; set; } = string.Empty;
        [Required(ErrorMessage = "Задайте свой вопрос")]
        public string Message { get; set; } = string.Empty;
   
    }
}
