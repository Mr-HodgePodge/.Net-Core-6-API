using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace HotelListing.API.Migrations
{
    /// <inheritdoc />
    public partial class AddedDefaultRoles : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "0f6cdc14-c795-4fdd-af24-1e803ee817b5", "43bf0787-c393-4f96-bd76-41aaf68223e7", "Administrator", "ADMINISTRATOR" },
                    { "94e5965c-5afb-460a-8393-0fe589fafcd7", "14e1acfb-f5e5-4734-b397-24f71d9a0f1e", "User", "USER" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0f6cdc14-c795-4fdd-af24-1e803ee817b5");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "94e5965c-5afb-460a-8393-0fe589fafcd7");
        }
    }
}
