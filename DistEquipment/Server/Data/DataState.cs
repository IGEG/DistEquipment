using DistEquipment.Shared;
using Microsoft.EntityFrameworkCore;

namespace DistEquipment.Server.Data
{
    public class DataState : IDataState
    {
        private readonly AppDBcontext _appDBcontext;

        public DataState(AppDBcontext appDBcontext)
        {
            _appDBcontext = appDBcontext;
        }
        public async Task AddVisit()
        {
            var visit = await _appDBcontext.States.FirstOrDefaultAsync();
            if (visit == null)
            {
                await _appDBcontext.States.AddAsync(new State { Views = 1, DateOfView = DateTime.Now }); ;
            }
            else
            {
                visit.Views++;
                visit.DateOfView = DateTime.Now;
            }
            _appDBcontext.SaveChanges();

        }

        public async ValueTask<int> GetVisits()
        {
            var visit = await _appDBcontext.States.FirstOrDefaultAsync();
            if (visit == null)
            {
                return 0;
            }
            return visit.Views;
        }
    }
}
