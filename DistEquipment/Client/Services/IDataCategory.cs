using DistEquipment.Shared;

namespace DistEquipment.Client.Services
{
    public interface IDataCategory
    {
        List<Category> Categories { get; set; }
        void LoadCategory() { }
    }
}
