using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DistEquipment.Server.Migrations
{
    public partial class solvents : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Solvents",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<decimal>(type: "Decimal(10,2)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Solvents", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateOfSaller",
                value: new DateTime(2022, 10, 12, 21, 53, 23, 279, DateTimeKind.Local).AddTicks(6599));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateOfSaller",
                value: new DateTime(2022, 10, 12, 21, 53, 23, 279, DateTimeKind.Local).AddTicks(6674));

            migrationBuilder.InsertData(
                table: "Solvents",
                columns: new[] { "Id", "Name", "Price" },
                values: new object[,]
                {
                    { 1, "Ацетон", 240.00m },
                    { 2, "646", 220.00m },
                    { 3, "650", 340.00m },
                    { 4, "647", 210.00m },
                    { 5, "Универсальный", 290.00m },
                    { 6, "Уайт-Спирит", 210.00m },
                    { 7, "Нефрас 80/120", 220.00m },
                    { 8, "Нефрас 130/150", 230.00m },
                    { 9, "Обезжириватель", 250.00m },
                    { 10, "Сольвент", 190.00m },
                    { 11, "Ксилол", 240.00m },
                    { 12, "Толуол", 240.00m },
                    { 13, "Бутилацетат", 200.00m },
                    { 14, "Этилацетат", 210.00m },
                    { 15, "Смывка флексографии", 200.00m },
                    { 16, "Спирты", 250.00m },
                    { 17, "Р4(Р5)", 220.00m },
                    { 18, "Дихлорметан", 600.00m }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Solvents");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateOfSaller",
                value: new DateTime(2022, 9, 27, 20, 31, 1, 792, DateTimeKind.Local).AddTicks(2060));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateOfSaller",
                value: new DateTime(2022, 9, 27, 20, 31, 1, 792, DateTimeKind.Local).AddTicks(2133));
        }
    }
}
