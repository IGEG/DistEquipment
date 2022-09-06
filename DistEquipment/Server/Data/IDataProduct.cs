using DistEquipment.Shared;

namespace DistEquipment.Server.Data
{
    public interface IDataProduct
    {
         Task<List<Product>> GetAllProducts();
         Task<Product> GetProductbyId(int Id);
         Task<List<Product>> GetProductsByUrl(string Url);
    }
}
