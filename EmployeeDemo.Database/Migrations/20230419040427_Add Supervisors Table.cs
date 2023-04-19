using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EmployeeDemo.Database.Migrations
{
    /// <inheritdoc />
    public partial class AddSupervisorsTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Supervisors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MiddleName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Supervisors", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateOfBirth",
                value: new DateTime(2023, 4, 18, 23, 4, 27, 40, DateTimeKind.Local).AddTicks(4061));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateOfBirth",
                value: new DateTime(2023, 4, 18, 23, 4, 27, 40, DateTimeKind.Local).AddTicks(4116));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateOfBirth",
                value: new DateTime(2023, 4, 18, 23, 4, 27, 40, DateTimeKind.Local).AddTicks(4119));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateOfBirth",
                value: new DateTime(2023, 4, 18, 23, 4, 27, 40, DateTimeKind.Local).AddTicks(4121));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateOfBirth",
                value: new DateTime(2023, 4, 18, 23, 4, 27, 40, DateTimeKind.Local).AddTicks(4124));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateOfBirth",
                value: new DateTime(2023, 4, 18, 23, 4, 27, 40, DateTimeKind.Local).AddTicks(4127));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateOfBirth",
                value: new DateTime(2023, 4, 18, 23, 4, 27, 40, DateTimeKind.Local).AddTicks(4129));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateOfBirth",
                value: new DateTime(2023, 4, 18, 23, 4, 27, 40, DateTimeKind.Local).AddTicks(4132));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateOfBirth",
                value: new DateTime(2023, 4, 18, 23, 4, 27, 40, DateTimeKind.Local).AddTicks(4135));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateOfBirth",
                value: new DateTime(2023, 4, 18, 23, 4, 27, 40, DateTimeKind.Local).AddTicks(4138));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateOfBirth",
                value: new DateTime(2023, 4, 18, 23, 4, 27, 40, DateTimeKind.Local).AddTicks(4140));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateOfBirth",
                value: new DateTime(2023, 4, 18, 23, 4, 27, 40, DateTimeKind.Local).AddTicks(4143));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateOfBirth",
                value: new DateTime(2023, 4, 18, 23, 4, 27, 40, DateTimeKind.Local).AddTicks(4145));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 14,
                column: "DateOfBirth",
                value: new DateTime(2023, 4, 18, 23, 4, 27, 40, DateTimeKind.Local).AddTicks(4148));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 15,
                column: "DateOfBirth",
                value: new DateTime(2023, 4, 18, 23, 4, 27, 40, DateTimeKind.Local).AddTicks(4151));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 16,
                column: "DateOfBirth",
                value: new DateTime(2023, 4, 18, 23, 4, 27, 40, DateTimeKind.Local).AddTicks(4153));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 17,
                column: "DateOfBirth",
                value: new DateTime(2023, 4, 18, 23, 4, 27, 40, DateTimeKind.Local).AddTicks(4156));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 18,
                column: "DateOfBirth",
                value: new DateTime(2023, 4, 18, 23, 4, 27, 40, DateTimeKind.Local).AddTicks(4158));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 19,
                column: "DateOfBirth",
                value: new DateTime(2023, 4, 18, 23, 4, 27, 40, DateTimeKind.Local).AddTicks(4161));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 20,
                column: "DateOfBirth",
                value: new DateTime(2023, 4, 18, 23, 4, 27, 40, DateTimeKind.Local).AddTicks(4164));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 21,
                column: "DateOfBirth",
                value: new DateTime(2023, 4, 18, 23, 4, 27, 40, DateTimeKind.Local).AddTicks(4167));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Supervisors");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateOfBirth",
                value: new DateTime(2023, 4, 18, 23, 3, 4, 601, DateTimeKind.Local).AddTicks(5184));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateOfBirth",
                value: new DateTime(2023, 4, 18, 23, 3, 4, 601, DateTimeKind.Local).AddTicks(5240));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateOfBirth",
                value: new DateTime(2023, 4, 18, 23, 3, 4, 601, DateTimeKind.Local).AddTicks(5243));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateOfBirth",
                value: new DateTime(2023, 4, 18, 23, 3, 4, 601, DateTimeKind.Local).AddTicks(5246));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateOfBirth",
                value: new DateTime(2023, 4, 18, 23, 3, 4, 601, DateTimeKind.Local).AddTicks(5249));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateOfBirth",
                value: new DateTime(2023, 4, 18, 23, 3, 4, 601, DateTimeKind.Local).AddTicks(5252));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateOfBirth",
                value: new DateTime(2023, 4, 18, 23, 3, 4, 601, DateTimeKind.Local).AddTicks(5254));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateOfBirth",
                value: new DateTime(2023, 4, 18, 23, 3, 4, 601, DateTimeKind.Local).AddTicks(5366));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateOfBirth",
                value: new DateTime(2023, 4, 18, 23, 3, 4, 601, DateTimeKind.Local).AddTicks(5372));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateOfBirth",
                value: new DateTime(2023, 4, 18, 23, 3, 4, 601, DateTimeKind.Local).AddTicks(5375));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateOfBirth",
                value: new DateTime(2023, 4, 18, 23, 3, 4, 601, DateTimeKind.Local).AddTicks(5377));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateOfBirth",
                value: new DateTime(2023, 4, 18, 23, 3, 4, 601, DateTimeKind.Local).AddTicks(5380));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateOfBirth",
                value: new DateTime(2023, 4, 18, 23, 3, 4, 601, DateTimeKind.Local).AddTicks(5383));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 14,
                column: "DateOfBirth",
                value: new DateTime(2023, 4, 18, 23, 3, 4, 601, DateTimeKind.Local).AddTicks(5385));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 15,
                column: "DateOfBirth",
                value: new DateTime(2023, 4, 18, 23, 3, 4, 601, DateTimeKind.Local).AddTicks(5388));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 16,
                column: "DateOfBirth",
                value: new DateTime(2023, 4, 18, 23, 3, 4, 601, DateTimeKind.Local).AddTicks(5391));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 17,
                column: "DateOfBirth",
                value: new DateTime(2023, 4, 18, 23, 3, 4, 601, DateTimeKind.Local).AddTicks(5393));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 18,
                column: "DateOfBirth",
                value: new DateTime(2023, 4, 18, 23, 3, 4, 601, DateTimeKind.Local).AddTicks(5396));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 19,
                column: "DateOfBirth",
                value: new DateTime(2023, 4, 18, 23, 3, 4, 601, DateTimeKind.Local).AddTicks(5399));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 20,
                column: "DateOfBirth",
                value: new DateTime(2023, 4, 18, 23, 3, 4, 601, DateTimeKind.Local).AddTicks(5401));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 21,
                column: "DateOfBirth",
                value: new DateTime(2023, 4, 18, 23, 3, 4, 601, DateTimeKind.Local).AddTicks(5404));
        }
    }
}
