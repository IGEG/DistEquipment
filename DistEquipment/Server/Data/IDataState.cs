namespace DistEquipment.Server.Data
{
    public interface IDataState
    {
        ValueTask<int> GetVisits();
        Task AddVisit();
    }
}
