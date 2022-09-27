using DistEquipment.Shared;

namespace DistEquipment.Client.Services

{
    public interface IDataCart
    {
        event Action OnChange;
        Task AddToCart(CartRow cart);

        Task<List<CartRow>> GetAllCartRows();

        Task DeleteRow(CartRow cartRow);
        Task RemoveCart();
    }
}
