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
            return await appDBcontext.Products.Include(m=>m.ProductModels).ToListAsync();
        }

        public async Task<Product> GetProductbyId(int Id)
        {
            
            Product product = await appDBcontext.Products.Include(o=>o.ProductModels).ThenInclude(p=>p.ProductOption).FirstOrDefaultAsync(p=>p.Id==Id);
            product.Views++;
            await appDBcontext.SaveChangesAsync();
            return product;
        }

        public async Task<List<Product>> GetProductsByUrl(string Url)
        {
            Category category = await dataCategory.GetCategoryByUrl(Url);
          
            return await appDBcontext.Products.Include(m=>m.ProductModels).Where(p=>p.CategoryId==category.IdCategory).ToListAsync();
      
        }

    }
}
