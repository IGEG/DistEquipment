using DistEquipment.Server.ModelDto;

namespace DistEquipment.Server.Services
{
    public interface IEmailService
    {
        Task SendMessage(Email email);
    }
}
