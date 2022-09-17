using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DistEquipment.Server.Migrations
{
    public partial class productoptions : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ProductOptions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductOptions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProductProductOption",
                columns: table => new
                {
                    ProductOptionsId = table.Column<int>(type: "int", nullable: false),
                    ProductsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductProductOption", x => new { x.ProductOptionsId, x.ProductsId });
                    table.ForeignKey(
                        name: "FK_ProductProductOption_ProductOptions_ProductOptionsId",
                        column: x => x.ProductOptionsId,
                        principalTable: "ProductOptions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductProductOption_Products_ProductsId",
                        column: x => x.ProductsId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_ProductProductOption_ProductsId",
                table: "ProductProductOption",
                column: "ProductsId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProductProductOption");

            migrationBuilder.DropTable(
                name: "ProductOptions");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateOfSaller",
                value: new DateTime(2022, 9, 17, 18, 27, 19, 571, DateTimeKind.Local).AddTicks(9208));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateOfSaller",
                value: new DateTime(2022, 9, 17, 18, 27, 19, 571, DateTimeKind.Local).AddTicks(9276));
        }
    }
}
