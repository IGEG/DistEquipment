using DistEquipment.Shared;

namespace DistEquipment.Client.Services
{
    public interface IDataProduct
    {
        Task<List<Product>> LoadProduct(string Url=null);

        Task<List<Product>> GetAllDistillars();
        Task<Product> GetProductById(int Id);
    }
}
