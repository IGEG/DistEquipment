using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DistEquipment.Server.Migrations
{
    public partial class productwithoptions : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "ProductOptions",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Без опций" },
                    { 2, "С генератором вакуума" },
                    { 3, "С автоматической загрузкой" }
                });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateOfSaller",
                value: new DateTime(2022, 9, 17, 19, 10, 34, 382, DateTimeKind.Local).AddTicks(8441));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateOfSaller",
                value: new DateTime(2022, 9, 17, 19, 10, 34, 382, DateTimeKind.Local).AddTicks(8520));

            migrationBuilder.InsertData(
                table: "ProductProductOption",
                columns: new[] { "ProductOptionsId", "ProductsId" },
                values: new object[] { 1, 1 });

            migrationBuilder.InsertData(
                table: "ProductProductOption",
                columns: new[] { "ProductOptionsId", "ProductsId" },
                values: new object[] { 2, 1 });

            migrationBuilder.InsertData(
                table: "ProductProductOption",
                columns: new[] { "ProductOptionsId", "ProductsId" },
                values: new object[] { 3, 1 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ProductProductOption",
                keyColumns: new[] { "ProductOptionsId", "ProductsId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "ProductProductOption",
                keyColumns: new[] { "ProductOptionsId", "ProductsId" },
                keyValues: new object[] { 2, 1 });

            migrationBuilder.DeleteData(
                table: "ProductProductOption",
                keyColumns: new[] { "ProductOptionsId", "ProductsId" },
                keyValues: new object[] { 3, 1 });

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateOfSaller",
                value: new DateTime(2022, 9, 17, 18, 40, 18, 26, DateTimeKind.Local).AddTicks(4515));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateOfSaller",
                value: new DateTime(2022, 9, 17, 18, 40, 18, 26, DateTimeKind.Local).AddTicks(4591));
        }
    }
}
