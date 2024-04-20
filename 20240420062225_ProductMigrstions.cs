using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Project.Net.Migrations
{
    /// <inheritdoc />
    public partial class ProductMigrstions : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Category", "Description", "Name", "Price", "ProductId" },
                values: new object[,]
                {
                    { 1, "Phones", "New Smartphone", "Samsung 100", 900.0, null },
                    { 2, "Phones", "New Smartphone 2024", "Samsung Galaxy", 800.0, null },
                    { 3, "Phones", "New Smartphone 2024", "iphone 15", 1000.0, null },
                    { 4, "Phones", "New Smartphone 2024", "Nokia E5", 600.0, null }
                });
        }

        /// <inheritdoc />
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
                table: "Products",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.InsertData(
                table: "Menus",
                columns: new[] { "Id", "Category", "Name", "ParentId", "Url" },
                values: new object[,]
                {
                    { 1, "Mobil Phones", "Products", 0, "/Products" },
                    { 2, "Mobil Types ", "Types", 0, "/Types" },
                    { 3, "Mobil Brands ", "Brands", 0, "/Brands" }
                });
        }
    }
}
