using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Project.Net.Migrations
{
    /// <inheritdoc />
    public partial class MyTypeMigrations : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                table: "Types",
                columns: new[] { "Id", "Category", "MyTypeId", "Name" },
                values: new object[,]
                {
                    { 1, "Consumer Electronics", null, "Electronics" },
                    { 2, "Apparel", null, "Clothing" },
                    { 3, "Home Furnishings", null, "Furniture" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Types",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Types",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Types",
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
    }
}
