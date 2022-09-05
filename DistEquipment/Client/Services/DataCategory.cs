using DistEquipment.Shared;

namespace DistEquipment.Client.Services
{
    public class DataCategory : IDataCategory
    {
        public List<Category> Categories { get; set ; }
        public void LoadCategory()
        {
            Categories = new List<Category> {
        new Category{ IdCategory=1,Name="Дистилляторы",Img="oi oi-cog",Url="distillars",Description="Оборудование для регенерации растворителей"},
        new Category{ IdCategory=2,Name="Пакеты Rec-Bag",Img="oi oi-droplet",Url="Rec-Bag",Description="Термопакеты для сбора отработанного остатка дистилляции"}
        };
        }
    }
}
