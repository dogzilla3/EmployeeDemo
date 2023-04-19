using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EmployeeDemo.Database.Migrations
{
    /// <inheritdoc />
    public partial class AddEmployeeseeddata : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "DateOfBirth", "FirstName", "LastName", "MiddleName" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 4, 18, 11, 18, 30, 12, DateTimeKind.Local).AddTicks(8898), "William", "Shakespeare", "Bob" },
                    { 2, new DateTime(2023, 4, 18, 11, 18, 30, 12, DateTimeKind.Local).AddTicks(8959), "John", "Doe", "Ron" },
                    { 3, new DateTime(2023, 4, 18, 11, 18, 30, 12, DateTimeKind.Local).AddTicks(8963), "Larry", "Bird", "Bill" },
                    { 4, new DateTime(2023, 4, 18, 11, 18, 30, 12, DateTimeKind.Local).AddTicks(8967), "Matt", "Geer", "Linus" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}
