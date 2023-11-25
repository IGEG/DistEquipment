using DistEquipment.Client.Models;
using DistEquipment.Shared;

namespace DistEquipment.Client.Services
{
    public interface ICalculator
    {
        Task<int> Calculate(CalculatorModel modelFormCalculator);
    }
}
