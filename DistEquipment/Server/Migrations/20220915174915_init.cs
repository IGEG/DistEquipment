using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DistEquipment.Server.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "IdCategory", "Description", "Img", "Name", "Url" },
                values: new object[] { 1, "Оборудование для регенерации растворителей", "oi oi-cog", "Дистилляторы", "distillars" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "IdCategory", "Description", "Img", "Name", "Url" },
                values: new object[] { 2, "Термопакеты для сбора отработанного остатка дистилляции", "oi oi-droplet", "Пакеты Rec-Bag", "Rec-Bag" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BigDescription", "CategoryId", "DateOfSaller", "DateOfUpdate", "Images", "IsClose", "IsOpen", "Name", "OldPrice", "Price", "SmallDescription", "SpesialPrice", "URL" },
                values: new object[] { 1, "Дистиллятор растворителей ULtraCliean 20EX на 20 литров обладает компактным размером и эргономичным дизайном.На панели приборов удобно расположены тумблер для выбора температурного режима и таймер дистилляции. LED дисплей позволяет отображать оставшееся врем перегонки,общее врем работы дистиллятора. Специальный индикатор показывает в какой промежуток времени идет нагрев масла.", 1, new DateTime(2022, 9, 15, 20, 49, 12, 762, DateTimeKind.Local).AddTicks(8140), null, "https://www.solventrecyclingmachine.com/wp-content/uploads/2021/11/standard-solvent-recycling-unit.png", false, false, "Дистиллятор ULtraCliean 20EX", 490000.00m, 400000.00m, "Установка для дистилляции загрязненных растворителей ULtraCliean 20EX с объемом загрузки 20 литров", null, "UltraClean20Ex" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BigDescription", "CategoryId", "DateOfSaller", "DateOfUpdate", "Images", "IsClose", "IsOpen", "Name", "OldPrice", "Price", "SmallDescription", "SpesialPrice", "URL" },
                values: new object[] { 2, "Пакеты Rec-Bag для дистиллятора ULtraCliean 20EX имеют плотную структуру, что позволяет их использовать при аккуратной работе более одного раза. Данные термопакеты обладают высокой термостойкостью, до 200 градусов Цельсия. Пакеты рек бэг изготовлены из специальных термостойких пластиков с гомогенной структурой.Термопакеты \"Rec Bag\" поставляются упаковкой по 50 штук. Использование термопакетов rec-bag актуально при дистилляции растворителей загрязненных красками, лаками, любыми твердыми частицами.", 2, new DateTime(2022, 9, 15, 20, 49, 12, 762, DateTimeKind.Local).AddTicks(8314), null, "https://developmentbeccaince896.zapwp.com/q:intelligent/retina:false/webp:false/w:1/url:https://www.beccainc.com/wp-content/uploads/2015/07/Recycling-Bag.jpg", false, false, "Пакеты Rec-Bag 20 литров", 19000.00m, 15000.00m, "Пакеты Rec-Bag для дистиллятора ULtraCliean 20EX", null, "RecBag20Ex" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "IdCategory",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "IdCategory",
                keyValue: 2);
        }
    }
}
