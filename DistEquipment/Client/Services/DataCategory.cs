using DistEquipment.Shared;
using System.Net.Http.Json;
using System.Reflection.Metadata.Ecma335;

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

        public async Task<Category> GetCategoryByUrl(string Url)
        {

            return await _httpClient.GetFromJsonAsync<Category>($"api/Category/{Url}");
        }

        public async Task LoadCategory()
        {
          Categories =  await _httpClient.GetFromJsonAsync<List<Category>>("api/Category");
        }
        
    }
}
