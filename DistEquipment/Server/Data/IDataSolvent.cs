using DistEquipment.Shared;

namespace DistEquipment.Server.Data
{
    public interface IDataSolvent
    {
        Task<List<Solvent>> GetAllSolvents();
    }
}
