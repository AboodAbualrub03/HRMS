using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace HRMS.Migrations
{
    /// <inheritdoc />
    public partial class seeding_lockups : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Lookups",
                columns: new[] { "Id", "MajorCode", "MinorCode", "Name" },
                values: new object[,]
                {
                    { 1L, 0, 0, "Employee Positions" },
                    { 2L, 0, 2, "Manager" },
                    { 3L, 0, 3, "Developer" },
                    { 4L, 0, 3, "" },
                    { 5L, 0, 0, "Department Types" },
                    { 6L, 0, 2, "Finance" },
                    { 7L, 0, 3, "Adminstrative" },
                    { 8L, 0, 3, "Technical" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Lookups",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "Lookups",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "Lookups",
                keyColumn: "Id",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "Lookups",
                keyColumn: "Id",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                table: "Lookups",
                keyColumn: "Id",
                keyValue: 5L);

            migrationBuilder.DeleteData(
                table: "Lookups",
                keyColumn: "Id",
                keyValue: 6L);

            migrationBuilder.DeleteData(
                table: "Lookups",
                keyColumn: "Id",
                keyValue: 7L);

            migrationBuilder.DeleteData(
                table: "Lookups",
                keyColumn: "Id",
                keyValue: 8L);
        }
    }
}
