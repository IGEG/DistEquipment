using DistEquipment.Shared;
using System.Net.Http.Json;

namespace DistEquipment.Client.Services
{
    public class DataProduct: IDataProduct
    {
        private readonly HttpClient httpClient;
    

        public List<Product> Products { get; set; } = new List<Product>();

        public DataProduct(HttpClient _httpClient)
        {
            httpClient = _httpClient;
        
        }
        public  async Task LoadProduct()
        {
   
                Products = await httpClient.GetFromJsonAsync<List<Product>>("api/Product");

        }
        public async Task<Product> GetProductById(int Id)
        {
            return await httpClient.GetFromJsonAsync<Product>($"api/Product/{Id}");
        }

        public async Task<Product> GetProductById(int Id)
        {
            return await httpClient.GetFromJsonAsync<Product>($"api/Product/{Id}");
        }

    }
}
