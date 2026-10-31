using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HRMS.Migrations
{
    /// <inheritdoc />
    public partial class employees_lookups_relation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Position",
                table: "Employees");

            migrationBuilder.AddColumn<long>(
                name: "PositionId",
                table: "Employees",
                type: "bigint",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Lookups",
                keyColumn: "Id",
                keyValue: 2L,
                column: "MinorCode",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Lookups",
                keyColumn: "Id",
                keyValue: 3L,
                column: "MinorCode",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Lookups",
                keyColumn: "Id",
                keyValue: 5L,
                column: "MajorCode",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Lookups",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "MajorCode", "MinorCode" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Lookups",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "MajorCode", "MinorCode" },
                values: new object[] { 1, 2 });

            migrationBuilder.UpdateData(
                table: "Lookups",
                keyColumn: "Id",
                keyValue: 8L,
                column: "MajorCode",
                value: 1);

            migrationBuilder.CreateIndex(
                name: "IX_Employees_PositionId",
                table: "Employees",
                column: "PositionId");

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_Lookups_PositionId",
                table: "Employees",
                column: "PositionId",
                principalTable: "Lookups",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employees_Lookups_PositionId",
                table: "Employees");

            migrationBuilder.DropIndex(
                name: "IX_Employees_PositionId",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "PositionId",
                table: "Employees");

            migrationBuilder.AddColumn<string>(
                name: "Position",
                table: "Employees",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Lookups",
                keyColumn: "Id",
                keyValue: 2L,
                column: "MinorCode",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Lookups",
                keyColumn: "Id",
                keyValue: 3L,
                column: "MinorCode",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Lookups",
                keyColumn: "Id",
                keyValue: 5L,
                column: "MajorCode",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Lookups",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "MajorCode", "MinorCode" },
                values: new object[] { 0, 2 });

            migrationBuilder.UpdateData(
                table: "Lookups",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "MajorCode", "MinorCode" },
                values: new object[] { 0, 3 });

            migrationBuilder.UpdateData(
                table: "Lookups",
                keyColumn: "Id",
                keyValue: 8L,
                column: "MajorCode",
                value: 0);
        }
    }
}
