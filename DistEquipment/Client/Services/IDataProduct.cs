using DistEquipment.Shared;

namespace DistEquipment.Client.Services
{
    public interface IDataProduct
    {
        event Action OnChange; 
        List<Product> Products { get; set; }
        Task LoadProduct(string Url=null);

        Task<List<Product>> GetAllProductWithOutOptions();
        Task<Product> GetProductById(int Id);
    }
}
