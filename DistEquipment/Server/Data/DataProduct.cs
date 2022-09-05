using DistEquipment.Shared;

namespace DistEquipment.Server.Data
{
    public class DataProduct:IDataProduct
    {
       public async Task<List<Product>> GetAllProducts()
        {
            return  Products;
        }

        public List<Product> Products = new List<Product>
    {
    new Product{Id=1,Name="Дистиллятор ULtraCliean 20EX",
    SmallDescription="Установка для дистилляции загрязненных растворителей ULtraCliean 20EX с объемом загрузки 20 литров",
    BigDescription="Дистиллятор растворителей ULtraCliean 20EX на 20 литров обладает компактным размером и эргономичным дизайном.На панели приборов удобно расположены тумблер для выбора температурного режима и таймер дистилляции. LED дисплей позволяет отображать оставшееся врем перегонки,общее врем работы дистиллятора. Специальный индикатор показывает в какой промежуток времени идет нагрев масла.",
    Images="https://www.solventrecyclingmachine.com/wp-content/uploads/2021/11/standard-solvent-recycling-unit.png",
    URL="UltraClean20Ex",
    Price=400000.00m,
    OldPrice=490000.00m,
    CategoryId=1},
    new Product{Id=2,Name="Пакеты Rec-Bag 20 литров",
    SmallDescription="Пакеты Rec-Bag для дистиллятора ULtraCliean 20EX",
    BigDescription="Пакеты Rec-Bag для дистиллятора ULtraCliean 20EX имеют плотную структуру, что позволяет их использовать при аккуратной работе более одного раза. Данные термопакеты обладают высокой термостойкостью, до 200 градусов Цельсия. Пакеты рек бэг изготовлены из специальных термостойких пластиков с гомогенной структурой.Термопакеты \"Rec Bag\" поставляются упаковкой по 50 штук. Использование термопакетов rec-bag актуально при дистилляции растворителей загрязненных красками, лаками, любыми твердыми частицами.",
    Images="https://developmentbeccaince896.zapwp.com/q:intelligent/retina:false/webp:false/w:1/url:https://www.beccainc.com/wp-content/uploads/2015/07/Recycling-Bag.jpg",
    URL="RecBag20Ex",
    OldPrice=19000.00m,
    Price=15000.00m,
    CategoryId=2}
    };


    }
}
