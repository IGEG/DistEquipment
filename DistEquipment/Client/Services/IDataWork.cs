using DistEquipment.Shared;

namespace DistEquipment.Client.Services
{
    public interface IDataWork
    {
        Task<List<Work>> GetWorks();
    }
}
