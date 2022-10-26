using DistEquipment.Shared;
using Microsoft.EntityFrameworkCore;

namespace DistEquipment.Server.Data
{
    public class DataWork : IDataWork
    {
        private readonly AppDBcontext _appDBContext;

        public DataWork(AppDBcontext appDBcontext)
        {
            _appDBContext = appDBcontext;
        }
        public async Task<List<Work>> GetAllWork()
        {
            return await _appDBContext.Works.ToListAsync();
        }
    }
}
