using DistEquipment.Shared;
using Microsoft.EntityFrameworkCore;

namespace DistEquipment.Server.Data
{
    public class DataProduct:IDataProduct
    {
        private readonly AppDBcontext appDBcontext;
        private readonly IDataCategory dataCategory;

        public DataProduct(AppDBcontext _appDBcontex, IDataCategory _dataCategory)
        {
            appDBcontext = _appDBcontex;
            dataCategory = _dataCategory;
        }
       public async Task<List<Product>> GetAllProducts()
        {
            return await appDBcontext.Products.ToListAsync();
        }

        public async Task<Product> GetProductbyId(int Id)
        {
            
            Product product = await appDBcontext.Products.FirstOrDefaultAsync(p=>p.Id==Id);
            return product;
        }

        public async Task<List<Product>> GetProductsByUrl(string Url)
        {
            Category category = await dataCategory.GetCategoryByUrl(Url);
          
            return await appDBcontext.Products.Where(p=>p.CategoryId==category.IdCategory).ToListAsync();
      
        }

    }
}
