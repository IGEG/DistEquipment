using DistEquipment.Shared;

namespace DistEquipment.Client.Services
{
    public interface IDataCategory
    {
        List<Category> Categories { get; set; }

        Task<List<Category>> LoadCategory();

        Task<Category> GetCategoryByUrl(string Url);
    }
}
