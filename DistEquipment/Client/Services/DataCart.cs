using Blazored.LocalStorage;
using Blazored.Toast.Services;
using DistEquipment.Client.Pages;
using DistEquipment.Shared;

namespace DistEquipment.Client.Services
{
    public class DataCart : IDataCart
    {
        private readonly ILocalStorageService localStorage;
        private readonly IDataProduct dataProduct;
        private readonly IToastService toastService;

        public event Action OnChange;
        public DataCart(ILocalStorageService _localStorage, IDataProduct _dataProduct, IToastService _toastService)
        {
            localStorage = _localStorage;
            dataProduct = _dataProduct;
            toastService = _toastService;
        }

        public async Task AddToCart(CartRow cartRow)
        {
            var cart = await localStorage.GetItemAsync<List<CartRow>>("cart");
            if (cart == null)
            {
                cart = new List<CartRow>();
            }
            var sameRow = cart.First(x => x.ProductId == cartRow.ProductId && x.OptionId == cartRow.OptionId);
            if (sameRow == null)
            {
                cart.Add(cartRow);
            }
            else
            {
                sameRow.Quantity += cartRow.Quantity;
            }

            await localStorage.SetItemAsync("cart", cart);
            var product = await dataProduct.GetProductById(cartRow.ProductId);
            toastService.ShowSuccess(product.Name, "Добавлено в корзину:");
            OnChange.Invoke();

        }

        public async Task<List<CartRow>> GetAllCartRows()
        {
            var result = new List<CartRow>();
            var cart = await localStorage.GetItemAsync<List<CartRow>>("cart");
            if (cart == null)
            {
                return result;
            }
            
            return cart;
         
        }

        public async Task DeleteRow(CartRow cartRow)
        {
            var cart = await localStorage.GetItemAsync<List<CartRow>>("cart");
            if (cart == null)
            {
                return;
            }
            var row = cart.FirstOrDefault(r => r.ProductId == cartRow.ProductId && r.OptionId == cartRow.OptionId);
            if (row == null)
            {
                return;
            }
            cart.Remove(row);
            await localStorage.SetItemAsync("cart", cart);
            OnChange.Invoke();

        }

        public async Task RemoveCart()
        {
           await localStorage.RemoveItemAsync("cart");
            OnChange.Invoke();
        }
    }
}
