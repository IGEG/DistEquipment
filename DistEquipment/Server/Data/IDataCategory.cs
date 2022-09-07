using DistEquipment.Shared;

namespace DistEquipment.Server.Data
{
    public interface IDataCategory
    {
        Task<List<Category>> GetAllCategories();
        Task<Category> GetCategoryByUrl(string Url);
       
    }
}
