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

        public async Task AddToCart(ProductModel productModel)
        {
            var cart = await localStorage.GetItemAsync<List<ProductModel>>("cart");
            if (cart == null)
            {
                cart = new List<ProductModel>();
            }
            cart.Add(productModel);
            await localStorage.SetItemAsync("cart", cart);
            var product = await dataProduct.GetProductById(productModel.ProductId);
            toastService.ShowSuccess(product.Name, "Добавлено в корзину:");
            OnChange.Invoke();

        }

        public async Task<List<CartRow>> GetAllCartRows()
        {
            var result = new List<CartRow>();
            var cart = await localStorage.GetItemAsync<List<ProductModel>>("cart");
            if (cart == null)
            {
                return result;
            }
            foreach (var cartRow in cart)
            {
                var product = await dataProduct.GetProductById(cartRow.ProductId);
                var row = new CartRow
                {
                    ProductId = product.Id,
                    ProductName = product.Name,
                    Img = product.Images,
                    OptionId = cartRow.ProductOptionId,
                };
                var model = product.ProductModels.Find(m => m.ProductOptionId == cartRow.ProductOptionId);
                if (model != null)
                {
                    row.OptionName = model.ProductOption?.Name;
                    row.Price = model.Price;
                }
                result.Add(row);
            }
            return result;
         
        }
    }
}
