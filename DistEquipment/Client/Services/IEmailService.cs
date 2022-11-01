using DistEquipment.Shared;

namespace DistEquipment.Client.Services
{
    public interface IEmailService
    {
        Task PostFeedBackForm(FeedBackForm feedBackForm);
    }
}
