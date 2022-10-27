using DistEquipment.Client.Shared;
using DistEquipment.Shared;
using System.Net.Http.Json;


namespace DistEquipment.Client.Services
{
    public class DataProduct: IDataProduct
    {
        private readonly HttpClient httpClient;


        public DataProduct(HttpClient _httpClient)
        {
            httpClient = _httpClient;
        
        }
        public  async Task<List<Product>> LoadProduct(string Url=null)
        {
            if (Url == null)
            {
                return await httpClient.GetFromJsonAsync<List<Product>>("api/Product");
            }
            else
            {
                return  await httpClient.GetFromJsonAsync<List<Product>>($"api/Product/category/{Url}");
            }
          
        }
        public async Task<Product> GetProductById(int Id)
        {
            return await httpClient.GetFromJsonAsync<Product>($"api/Product/{Id}");
        }

        public async Task<List<Product>> GetAllDistillars()
        {
           List<Product> Products =  await httpClient.GetFromJsonAsync<List<Product>>("api/Product");
            if (Products != null)
                return Products.FindAll(p => p.CategoryId == 1);
            else throw new Exception("нет данных по продукту");
          
         
        }
    }
}
