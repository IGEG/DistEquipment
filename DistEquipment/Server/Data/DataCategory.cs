using DistEquipment.Shared;
using Microsoft.EntityFrameworkCore;

namespace DistEquipment.Server.Data
{
    public class DataCategory : IDataCategory
    {
        private readonly AppDBcontext appDBcontext;

        public DataCategory(AppDBcontext _appDBcontext)
        {
            appDBcontext = _appDBcontext;
        }

        public async Task<Category> GetCategoryByUrl(string Url)
        {

            return await appDBcontext.Categories.FirstOrDefaultAsync(c => c.Url.ToLower().Equals(Url.ToLower()));
        }

        public async Task<List<Category>> GetAllCategories()
        {
            return await appDBcontext.Categories.ToListAsync();
        }
    }
}
