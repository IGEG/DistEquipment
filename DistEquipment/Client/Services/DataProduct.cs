using DistEquipment.Client.Shared;
using DistEquipment.Shared;
using System.Net.Http.Json;


namespace DistEquipment.Client.Services
{
    public class DataProduct: IDataProduct
    {
        private readonly HttpClient httpClient;

        public event Action OnChange;

        public List<Product> Products { get; set; } = new List<Product>();

        public DataProduct(HttpClient _httpClient)
        {
            httpClient = _httpClient;
        
        }
        public  async Task LoadProduct(string Url=null)
        {
            if (Url == null)
            {
                Products = await httpClient.GetFromJsonAsync<List<Product>>("api/Product");
            }
            else
            {
                Products = await httpClient.GetFromJsonAsync<List<Product>>($"api/Product/category/{Url}");
            }
            OnChange.Invoke();
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
