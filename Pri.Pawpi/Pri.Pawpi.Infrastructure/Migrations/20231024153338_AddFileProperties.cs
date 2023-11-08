using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Pri.Pawpi.Infrastructure.Migrations
{
    public partial class AddFileProperties : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ImageFile",
                table: "Veterinarians",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ImageFile",
                table: "Pets",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PedigreeFile",
                table: "Pets",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DocumentFile",
                table: "Consultations",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ImageFile",
                table: "Consultations",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Consultations",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateOfConsultation",
                value: new DateTime(2023, 10, 24, 17, 33, 37, 924, DateTimeKind.Local).AddTicks(4676));

            migrationBuilder.UpdateData(
                table: "Consultations",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateOfConsultation",
                value: new DateTime(2023, 10, 24, 17, 33, 37, 924, DateTimeKind.Local).AddTicks(4772));

            migrationBuilder.UpdateData(
                table: "Consultations",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateOfConsultation",
                value: new DateTime(2023, 10, 24, 17, 33, 37, 924, DateTimeKind.Local).AddTicks(4776));

            migrationBuilder.UpdateData(
                table: "Consultations",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateOfConsultation",
                value: new DateTime(2023, 10, 24, 17, 33, 37, 924, DateTimeKind.Local).AddTicks(4784));

            migrationBuilder.UpdateData(
                table: "Consultations",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateOfConsultation",
                value: new DateTime(2023, 10, 24, 17, 33, 37, 924, DateTimeKind.Local).AddTicks(4787));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImageFile",
                table: "Veterinarians");

            migrationBuilder.DropColumn(
                name: "ImageFile",
                table: "Pets");

            migrationBuilder.DropColumn(
                name: "PedigreeFile",
                table: "Pets");

            migrationBuilder.DropColumn(
                name: "DocumentFile",
                table: "Consultations");

            migrationBuilder.DropColumn(
                name: "ImageFile",
                table: "Consultations");

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
    }
}
