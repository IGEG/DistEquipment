namespace DistEquipment.Client.Services
{
    public interface ICalculator
    {
        Task<int> Calculate(int volume, decimal price, int hour);
    }
}
