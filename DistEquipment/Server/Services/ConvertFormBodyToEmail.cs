using DistEquipment.Shared;

namespace DistEquipment.Server.Services
{
    public static class ConvertFormBodyToEmail 
    {
        public static string GetString( this FeedBackForm feedBackForm)
        {
            return  $"<div> <h1>ФОРМА ОБРАТНОЙ СВЯЗИ:</h1> </div>" +
                $" <div> <h3>Имя клиента :{feedBackForm.Name} </h3></div>" +
                  $"<h3>Название компании :{feedBackForm.CompanyName} </h3>" +
                    $"<h3>Номер телефона :{feedBackForm.TelephoneNumber} </h3>" +
                      $"<h3>Почта :{feedBackForm.Email} </h3>" +
                        $"<h3>Сообщение :{feedBackForm.Message} </h3>"; 

        }
    }
}
