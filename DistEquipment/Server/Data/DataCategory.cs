using DistEquipment.Shared;

namespace DistEquipment.Server.Data
{
    public class DataCategory : IDataCategory
    {
        public List<Category> Categories = new List<Category>()
        {
         new Category{ IdCategory=1,Name="Дистилляторы",Img="oi oi-cog",Url="distillars",Description="Оборудование для регенерации растворителей"},
        new Category{ IdCategory=2,Name="Пакеты Rec-Bag",Img="oi oi-droplet",Url="Rec-Bag",Description="Термопакеты для сбора отработанного остатка дистилляции"}
        };

        public async Task<Category> GetCategoryByUrl(string Url)
        {
            return Categories.FirstOrDefault(c => c.Url.ToLower().Equals(Url.ToLower()));
        }

        public async Task<List<Category>> GetAllCategories()
        {
            return Categories;
        }
    }
}
