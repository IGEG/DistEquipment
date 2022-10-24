using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DistEquipment.Server.Migrations
{
    public partial class calculator : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Volume",
                table: "Products",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Calculators",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Hours = table.Column<int>(type: "int", nullable: false),
                    PriceDistillar = table.Column<double>(type: "float", nullable: false),
                    PriceSolvent = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Calculators", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateOfSaller", "Volume" },
                values: new object[] { new DateTime(2022, 10, 24, 15, 2, 59, 772, DateTimeKind.Local).AddTicks(3715), 20 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateOfSaller",
                value: new DateTime(2022, 10, 24, 15, 2, 59, 772, DateTimeKind.Local).AddTicks(3797));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Calculators");

            migrationBuilder.DropColumn(
                name: "Volume",
                table: "Products");

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
        }
    }
}
