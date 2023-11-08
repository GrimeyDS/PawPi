using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Pri.Pawpi.Infrastructure.Migrations
{
    public partial class AddLogoToPractice : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Logo",
                table: "Practices",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Consultations",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateOfConsultation",
                value: new DateTime(2023, 10, 23, 18, 29, 30, 88, DateTimeKind.Local).AddTicks(1339));

            migrationBuilder.UpdateData(
                table: "Consultations",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateOfConsultation",
                value: new DateTime(2023, 10, 23, 18, 29, 30, 88, DateTimeKind.Local).AddTicks(1382));

            migrationBuilder.UpdateData(
                table: "Consultations",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateOfConsultation",
                value: new DateTime(2023, 10, 23, 18, 29, 30, 88, DateTimeKind.Local).AddTicks(1385));

            migrationBuilder.UpdateData(
                table: "Consultations",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateOfConsultation",
                value: new DateTime(2023, 10, 23, 18, 29, 30, 88, DateTimeKind.Local).AddTicks(1387));

            migrationBuilder.UpdateData(
                table: "Consultations",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateOfConsultation",
                value: new DateTime(2023, 10, 23, 18, 29, 30, 88, DateTimeKind.Local).AddTicks(1389));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Logo",
                table: "Practices");

            migrationBuilder.UpdateData(
                table: "Consultations",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateOfConsultation",
                value: new DateTime(2023, 10, 7, 16, 5, 0, 720, DateTimeKind.Local).AddTicks(1356));

            migrationBuilder.UpdateData(
                table: "Consultations",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateOfConsultation",
                value: new DateTime(2023, 10, 7, 16, 5, 0, 720, DateTimeKind.Local).AddTicks(1398));

            migrationBuilder.UpdateData(
                table: "Consultations",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateOfConsultation",
                value: new DateTime(2023, 10, 7, 16, 5, 0, 720, DateTimeKind.Local).AddTicks(1401));

            migrationBuilder.UpdateData(
                table: "Consultations",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateOfConsultation",
                value: new DateTime(2023, 10, 7, 16, 5, 0, 720, DateTimeKind.Local).AddTicks(1403));

            migrationBuilder.UpdateData(
                table: "Consultations",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateOfConsultation",
                value: new DateTime(2023, 10, 7, 16, 5, 0, 720, DateTimeKind.Local).AddTicks(1406));
        }
    }
}
