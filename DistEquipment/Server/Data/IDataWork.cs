using DistEquipment.Shared;

namespace DistEquipment.Server.Data
{
    public interface IDataWork
    {
        Task<List<Work>> GetAllWork();
    }
}
