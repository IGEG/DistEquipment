using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DistEquipment.Server.Migrations
{
    public partial class productmodel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProductProductOption");

            migrationBuilder.DropColumn(
                name: "OldPrice",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Price",
                table: "Products");

            migrationBuilder.CreateTable(
                name: "ProductModel",
                columns: table => new
                {
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    ProductOptionId = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<decimal>(type: "Decimal(10,2)", nullable: true),
                    OldPrice = table.Column<decimal>(type: "Decimal(10,2)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductModel", x => new { x.ProductId, x.ProductOptionId });
                    table.ForeignKey(
                        name: "FK_ProductModel_ProductOptions_ProductOptionId",
                        column: x => x.ProductOptionId,
                        principalTable: "ProductOptions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductModel_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "ProductModel",
                columns: new[] { "ProductId", "ProductOptionId", "OldPrice", "Price" },
                values: new object[,]
                {
                    { 1, 1, 490000.00m, 400000.00m },
                    { 1, 2, 690000.00m, 560000.00m },
                    { 1, 3, 570000.00m, 490000.00m }
                });

            migrationBuilder.InsertData(
                table: "ProductOptions",
                columns: new[] { "Id", "Name" },
                values: new object[] { 4, "Упаковка 50 шт." });

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
                column: "DateOfSaller",
                value: new DateTime(2022, 9, 18, 12, 38, 22, 389, DateTimeKind.Local).AddTicks(6310));

            migrationBuilder.InsertData(
                table: "ProductModel",
                columns: new[] { "ProductId", "ProductOptionId", "OldPrice", "Price" },
                values: new object[] { 2, 4, 19000.00m, 15000.00m });

            migrationBuilder.CreateIndex(
                name: "IX_ProductModel_ProductOptionId",
                table: "ProductModel",
                column: "ProductOptionId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProductModel");

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.AddColumn<decimal>(
                name: "OldPrice",
                table: "Products",
                type: "Decimal(10,2)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "Price",
                table: "Products",
                type: "Decimal(10,2)",
                nullable: true);

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

            migrationBuilder.InsertData(
                table: "ProductProductOption",
                columns: new[] { "ProductOptionsId", "ProductsId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 2, 1 },
                    { 3, 1 }
                });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateOfSaller", "OldPrice", "Price" },
                values: new object[] { new DateTime(2022, 9, 17, 19, 41, 14, 457, DateTimeKind.Local).AddTicks(7673), 490000.00m, 400000.00m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateOfSaller", "OldPrice", "Price" },
                values: new object[] { new DateTime(2022, 9, 17, 19, 41, 14, 457, DateTimeKind.Local).AddTicks(7769), 19000.00m, 15000.00m });

            migrationBuilder.CreateIndex(
                name: "IX_ProductProductOption_ProductsId",
                table: "ProductProductOption",
                column: "ProductsId");
        }
    }
}
