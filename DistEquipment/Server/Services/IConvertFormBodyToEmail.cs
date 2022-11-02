using DistEquipment.Shared;

namespace DistEquipment.Server.Services
{
    public interface IConvertFormBodyToEmail
    {
        string GetString(FeedBackForm feedBackForm);
    }
}
