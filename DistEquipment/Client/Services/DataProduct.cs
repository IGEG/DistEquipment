using DistEquipment.Shared;
using System.Net.Http.Json;

namespace DistEquipment.Client.Services
{
    public class DataProduct: IDataProduct
    {
        private readonly HttpClient httpClient;
        private readonly IConfiguration configuration;

        public List<Product> Products { get; set; } = new List<Product>();

        public DataProduct(HttpClient _httpClient,IConfiguration _configuration)
        {
            httpClient = _httpClient;
            configuration = _configuration;
        }
        public  async Task LoadProduct()
        {
         ///  string connectionAdress = configuration.GetSection("GetAllProduct").Value;
         
            
                Products = await httpClient.GetFromJsonAsync<List<Product>>("api/Product");
            

        }
       
    }
}
