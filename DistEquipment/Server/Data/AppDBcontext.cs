using DistEquipment.Shared;
using Microsoft.EntityFrameworkCore;

namespace DistEquipment.Server.Data
{
    public class AppDBcontext:DbContext
    {
        public AppDBcontext(DbContextOptions<AppDBcontext> options):base(options)
        {

        }
       public DbSet<Category> Categories { get; set; }
       public  DbSet<Product> Products { get; set; }
       public DbSet<ProductOption> ProductOptions { get; set; }
       public DbSet<State> States { get; set; }
       public DbSet<Solvent> Solvents { get; set; }
        public DbSet<Calculator> Calculators { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ProductModel>().HasKey(p => new { p.ProductId, p.ProductOptionId });

            modelBuilder.Entity<Solvent>().HasData(
                new Solvent { Id = 1, Name = "Ацетон", Price = 240.00m },
                new Solvent { Id = 2, Name = "646", Price = 220.00m },
                new Solvent { Id = 3, Name = "650", Price = 340.00m },
                new Solvent { Id = 4, Name = "647", Price = 210.00m },
                new Solvent { Id = 5, Name = "Универсальный", Price = 290.00m },
                new Solvent { Id = 6, Name = "Уайт-Спирит", Price = 210.00m },
                new Solvent { Id = 7, Name = "Нефрас 80/120", Price = 220.00m },
                new Solvent { Id = 8, Name = "Нефрас 130/150", Price = 230.00m },
                new Solvent { Id = 9, Name = "Обезжириватель", Price = 250.00m },
                new Solvent { Id = 10, Name = "Сольвент", Price = 190.00m },
                new Solvent { Id = 11, Name = "Ксилол", Price = 240.00m },
                new Solvent { Id = 12, Name = "Толуол", Price = 240.00m },
                new Solvent { Id = 13, Name = "Бутилацетат", Price = 200.00m },
                new Solvent { Id = 14, Name = "Этилацетат", Price = 210.00m },
                new Solvent { Id = 15, Name = "Смывка флексографии", Price = 200.00m },
                new Solvent { Id = 16, Name = "Спирты", Price = 250.00m },
                new Solvent { Id = 17, Name = "Р4(Р5)", Price = 220.00m },
                new Solvent { Id = 18, Name = "Дихлорметан", Price = 600.00m }
                );

            modelBuilder.Entity<Category>().HasData(
                 new Category { IdCategory = 1, Name = "Дистилляторы", Img = "oi oi-cog", Url = "distillars", Description = "Оборудование для регенерации растворителей" },
            new Category { IdCategory = 2, Name = "Пакеты Rec-Bag", Img = "oi oi-droplet", Url = "Rec-Bag", Description = "Термопакеты для сбора отработанного остатка дистилляции" }

                );
            modelBuilder.Entity<Product>().HasData(
                 new Product
                 {
                     Id = 1,
                     Name = "Дистиллятор ULtraCliean 20EX",
                     SmallDescription = "Установка для дистилляции загрязненных растворителей ULtraCliean 20EX с объемом загрузки 20 литров",
                     BigDescription = "Дистиллятор растворителей ULtraCliean 20EX на 20 литров обладает компактным размером и эргономичным дизайном.На панели приборов удобно расположены тумблер для выбора температурного режима и таймер дистилляции. LED дисплей позволяет отображать оставшееся врем перегонки,общее врем работы дистиллятора. Специальный индикатор показывает в какой промежуток времени идет нагрев масла.",
                     Images = "https://www.solventrecyclingmachine.com/wp-content/uploads/2021/11/standard-solvent-recycling-unit.png",
                     URL = "UltraClean20Ex",
                     Volume = 20,
                     CategoryId = 1
                 },
                  new Product
                  {
                      Id = 2,
                      Name = "Пакеты Rec-Bag 20 литров",
                      SmallDescription = "Пакеты Rec-Bag для дистиллятора ULtraCliean 20EX",
                      BigDescription = "Пакеты Rec-Bag для дистиллятора ULtraCliean 20EX имеют плотную структуру, что позволяет их использовать при аккуратной работе более одного раза. Данные термопакеты обладают высокой термостойкостью, до 200 градусов Цельсия. Пакеты рек бэг изготовлены из специальных термостойких пластиков с гомогенной структурой.Термопакеты \"Rec Bag\" поставляются упаковкой по 50 штук. Использование термопакетов rec-bag актуально при дистилляции растворителей загрязненных красками, лаками, любыми твердыми частицами.",                    
                      Images = "Img/rec-bag30.png",
                      URL = "RecBag20Ex",
                      CategoryId = 2
                  }
                );
            modelBuilder.Entity<ProductOption>().HasData(
                new ProductOption { Id = 1, Name="Без опций"},
                new ProductOption { Id = 2, Name = "С генератором вакуума" },
                new ProductOption { Id = 3, Name = "С автоматической загрузкой" },
                new ProductOption { Id = 4, Name = "Упаковка 50 шт." }
                );

            modelBuilder.Entity<ProductModel>().HasData(
                new ProductModel { ProductId = 1, ProductOptionId = 1, Price = 400000.00m, OldPrice = 490000.00m },
                new ProductModel { ProductId = 1, ProductOptionId = 2, Price = 560000.00m, OldPrice = 690000.00m },
                new ProductModel { ProductId = 1, ProductOptionId = 3, Price = 490000.00m, OldPrice = 570000.00m },
                new ProductModel { ProductId = 2, ProductOptionId = 4, Price = 15000.00m, OldPrice = 19000.00m }

                );
        }
        

    }
}
