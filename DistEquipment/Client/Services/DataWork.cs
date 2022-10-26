using DistEquipment.Shared;
using System.Net.Http.Json;

namespace DistEquipment.Client.Services
{
    public class DataWork : IDataWork
    {
        private readonly HttpClient _httpClient;

        public DataWork(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<List<Work>> GetWorks()
        {
            return await _httpClient.GetFromJsonAsync<List<Work>>("api/work");
        }
    }
}
