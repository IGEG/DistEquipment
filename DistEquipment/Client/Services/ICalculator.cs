using DistEquipment.Client.Models;

namespace DistEquipment.Client.Services
{
    public interface ICalculator
    {
        Task<int> Calculate(ModelFormCalculator modelFormCalculator);
    }
}
