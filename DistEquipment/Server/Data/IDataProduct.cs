using DistEquipment.Shared;

namespace DistEquipment.Server.Data
{
    public interface IDataProduct
    {
         Task<List<Product>> GetAllProducts();
    }
}
