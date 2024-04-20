using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Project.Net.Migrations
{
    /// <inheritdoc />
    public partial class MenuItem1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                table: "Menus",
                columns: new[] { "Id", "Category", "Name", "ParentId", "Url" },
                values: new object[,]
                {
                    { 1, "Mobil Phones", "Products", 0, "/Products" },
                    { 2, "Mobil Types ", "Types", 0, "/Types" },
                    { 3, "Mobil Brands ", "Brands", 0, "/Brands" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                table: "Types",
                columns: new[] { "Id", "Category", "MyTypeId", "Name" },
                values: new object[,]
                {
                    { 1, "Consumer Electronics", null, "Electronics" },
                    { 2, "Apparel", null, "Clothing" },
                    { 3, "Home Furnishings", null, "Furniture" }
                });
        }
    }
}
