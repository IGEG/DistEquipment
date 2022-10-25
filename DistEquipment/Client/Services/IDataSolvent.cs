using DistEquipment.Shared;

namespace DistEquipment.Client.Services
{
    public interface IDataSolvent
    {
        Task<List<Solvent>> GetAllSolvents();
    }
}
