using DistEquipment.Shared;
using System.Net.Http.Json;

namespace DistEquipment.Client.Services
{
    public class DataCategory : IDataCategory
    {
        private readonly HttpClient _httpClient;

        public DataCategory(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public List<Category> Categories { get; set ; }
        public void LoadCategory()
        {
            _httpClient.GetFromJsonAsync<List<Category>>("api/Category");
        }
        
    }
}
