using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DistEquipment.Server.Migrations
{
    public partial class picture : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "ProductOptions",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateOfSaller",
                value: new DateTime(2022, 9, 20, 22, 24, 41, 453, DateTimeKind.Local).AddTicks(3948));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateOfSaller", "Images" },
                values: new object[] { new DateTime(2022, 9, 20, 22, 24, 41, 453, DateTimeKind.Local).AddTicks(4014), "~/wwwroot/Img/rec-bag30.png" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "ProductOptions",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateOfSaller",
                value: new DateTime(2022, 9, 18, 12, 38, 22, 389, DateTimeKind.Local).AddTicks(6264));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateOfSaller", "Images" },
                values: new object[] { new DateTime(2022, 9, 18, 12, 38, 22, 389, DateTimeKind.Local).AddTicks(6310), "https://developmentbeccaince896.zapwp.com/q:intelligent/retina:false/webp:false/w:1/url:https://www.beccainc.com/wp-content/uploads/2015/07/Recycling-Bag.jpg" });
        }
    }
}
