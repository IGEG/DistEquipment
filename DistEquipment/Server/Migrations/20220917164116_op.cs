using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DistEquipment.Server.Migrations
{
    public partial class op : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateOfSaller",
                value: new DateTime(2022, 9, 17, 19, 41, 14, 457, DateTimeKind.Local).AddTicks(7673));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateOfSaller",
                value: new DateTime(2022, 9, 17, 19, 41, 14, 457, DateTimeKind.Local).AddTicks(7769));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
        }
    }
}
