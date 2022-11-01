using DistEquipment.Shared;
using System.Net.Http.Json;

namespace DistEquipment.Client.Services
{
    public class EmailService : IEmailService
    {
        private readonly HttpClient _httpClient;

        public EmailService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task PostFeedBackForm(FeedBackForm feedBackForm)
        {
            await _httpClient.PostAsJsonAsync<FeedBackForm>("api/email", feedBackForm);
        }
    }
}
