using DistEquipment.Shared;
using System.Net.Http.Json;

namespace DistEquipment.Client.Services
{
    public class DataNews : IDataNews
    {
        private readonly HttpClient _httpCLient;

        public DataNews(HttpClient httpClient)
        {
            _httpCLient = httpClient;
        }
        public async Task<List<News>> GetNews()
        {
            return await _httpCLient.GetFromJsonAsync<List<News>>("api/news");
        }

        public async Task<News> GetNewsByUrl(string Url)
        {
            return await _httpCLient.GetFromJsonAsync<News>($"api/news/{Url}");
        }
    }
}
