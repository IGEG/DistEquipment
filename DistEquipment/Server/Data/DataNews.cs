using DistEquipment.Shared;
using Microsoft.EntityFrameworkCore;

namespace DistEquipment.Server.Data
{
    public class DataNews : IDataNews
    {
        private AppDBcontext _context;

        public DataNews(AppDBcontext context)
        {
            _context = context;
        }
        public async Task<List<News>> GetNews()
        {
            return await _context.News.ToListAsync();
            
        }

        public async Task<News> GetNewsByURL(string Url)
        {
            return await _context.News.FirstOrDefaultAsync(n => n.UrlName == Url);
           
        }
    }
}
