using DistEquipment.Shared;

namespace DistEquipment.Client.Services
{
    public interface IDataProduct
    {
        List<Product> Products { get; set; }
        public Task LoadProduct();
    }
}
