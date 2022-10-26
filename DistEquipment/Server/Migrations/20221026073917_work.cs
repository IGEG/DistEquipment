using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DistEquipment.Server.Migrations
{
    public partial class work : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Works",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Count = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Works", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateOfSaller",
                value: new DateTime(2022, 10, 26, 10, 39, 14, 934, DateTimeKind.Local).AddTicks(5314));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateOfSaller",
                value: new DateTime(2022, 10, 26, 10, 39, 14, 934, DateTimeKind.Local).AddTicks(5384));

            migrationBuilder.InsertData(
                table: "Works",
                columns: new[] { "Id", "Count", "Name" },
                values: new object[,]
                {
                    { 1, 1, "Одна смена 8 часов" },
                    { 2, 2, "Две смены 16 часов" },
                    { 3, 3, "Непрерывная работа 24 часа" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Works");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateOfSaller",
                value: new DateTime(2022, 10, 24, 15, 2, 59, 772, DateTimeKind.Local).AddTicks(3715));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateOfSaller",
                value: new DateTime(2022, 10, 24, 15, 2, 59, 772, DateTimeKind.Local).AddTicks(3797));
        }
    }
}
