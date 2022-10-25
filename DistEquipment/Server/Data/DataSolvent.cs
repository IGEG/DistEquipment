using DistEquipment.Shared;
using Microsoft.EntityFrameworkCore;

namespace DistEquipment.Server.Data
{
    public class DataSolvent : IDataSolvent
    {
        private readonly AppDBcontext _appDBcontext;

        public DataSolvent(AppDBcontext appDBcontext)
        {
            _appDBcontext = appDBcontext;
        }
        public async Task<List<Solvent>> GetAllSolvents()
        {
            return await _appDBcontext.Solvents.ToListAsync();
        }
    }
}
