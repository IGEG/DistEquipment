using DistEquipment.Shared;

namespace DistEquipment.Client.Services

{
    public interface IDataCart
    {
        event Action OnChange;
        Task AddToCart(ProductModel productModl);

        Task<List<CartRow>> GetAllCartRows();
    }
}
