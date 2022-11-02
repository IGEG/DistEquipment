using DistEquipment.Shared;

namespace DistEquipment.Server.Services
{
    public class ConvertFormBodyToEmail : IConvertFormBodyToEmail
    {
        public string GetString(FeedBackForm feedBackForm)
        {
            return $"ФОРМА ОБРАТНОЙ СВЯЗИ:\t" +
                $" Имя клиента : {feedBackForm.Name} \t " +
                $" Название компании : {feedBackForm.CompanyName} \t " +
                $" Номер телефона : {feedBackForm.TelephoneNumber} \t " +
                $" Почта : {feedBackForm.Email} \t " +
                $" Сообщение : {feedBackForm.Message} \t ";

        }
    }
}
