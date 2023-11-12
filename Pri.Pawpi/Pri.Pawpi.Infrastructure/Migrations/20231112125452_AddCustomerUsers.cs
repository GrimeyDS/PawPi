using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Pri.Pawpi.Infrastructure.Migrations
{
    public partial class AddCustomerUsers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "1", "7329779e-593b-46e0-8171-8e59b4a41b4c", "Admin", "ADMIN" },
                    { "2", "96d7e490-bc95-4d83-b766-18ecbe03b349", "Veterinarian", "VETERINARIAN" },
                    { "3", "984515c6-837e-4db2-88eb-2352371f2e41", "Customer", "CUSTOMER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "CustomerId", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName", "VeterinarianId" },
                values: new object[,]
                {
                    { "10", 0, "490ceaec-2eb1-4637-8ede-9a5eedd59315", 9, "hansdissen@telenet.be", false, false, null, "HANSDISSEN@TELENET.BE", "HANSDISSEN@TELENET.BE", "AQAAAAEAACcQAAAAEPUmsYCdjxFhKo0u14rANoxBGei0Y+qUscnf24F92uhzmu1SZQpSCOhPA8E+dmFdhA==", null, false, "76dbc078-1d8e-48b4-a20c-a2a5f048406e", false, "hansdissen@telenet.be", null },
                    { "11", 0, "494bf347-1d94-410e-9148-5373159f1b80", 10, "chaydz@gmail.com", false, false, null, "CHAYDZ@GMAIL.COM", "CHAYDZ@GMAIL.COM", "AQAAAAEAACcQAAAAEK+wL/bG3aUUz9kip2kN3UI7R0ANKyCrZ5f26JioVWhpieESX+JzMy7lDg3KlS0ifw==", null, false, "498c0772-4b0d-4183-9707-706e934f3be5", false, "chaydz@gmail.com", null },
                    { "2", 0, "d916bb95-d881-4f9f-9a8a-90722e3a1eba", 1, "svends@gmail.com", false, false, null, "SVENDS@GMAIL.COM", "SVENDS@GMAIL.COM", "AQAAAAEAACcQAAAAEAK1q9TNqJ3A3aWPP5DXzm76saGCpxyeOR1aus7fdplqecXy2OsSj/CaTp9otygxJg==", null, false, "61463487-5a27-4eb4-b928-9601448d1a4d", false, "svends@gmail.com", null },
                    { "3", 0, "c262cc53-8161-485e-84e4-fe043fbade80", 2, "vb@gmail.com", false, false, null, "VB@GMAIL.COM", "VB@GMAIL.COM", "AQAAAAEAACcQAAAAEFL2wpVDyjqcsc3TwSRF0eb24qRM7IawYOgie0S5Dw09NADny5bdypXlCDIuiqhioA==", null, false, "ac2fe3a3-721d-4bbf-a08f-13d47640286c", false, "vb@gmail.com", null },
                    { "4", 0, "1e8c569d-0658-4636-9e80-6e433a4200ab", 3, "kdv@outlook.com", false, false, null, "KDV@OUTLOOK.COM", "KDV@OUTLOOK.COM", "AQAAAAEAACcQAAAAEPbuizkREL+7jOooWQBYBsBaCWxtM7kDsGwzveyCslvzlY3orz/0R/dQ6DZdrkHcZw==", null, false, "f34aee25-e77d-4a2a-b7ca-d8f78f54ca9f", false, "kdv@outlook.com", null },
                    { "5", 0, "874d4cc6-e4ef-4936-8a03-48e525eaf05b", 4, "makkermaat@telenet.be", false, false, null, "MAKKERMAAT@TELENET.BE", "MAKKERMAAT@TELENET.BE", "AQAAAAEAACcQAAAAECfDeXErwu+O9RW5RIliZdzrqTtt12g1qTcgomHxRiObrppM1kJipzNm9JiuN++Evg==", null, false, "d57db20a-f45b-406c-b9ba-a2a3f8d892b4", false, "makkermaat@telenet.be", null },
                    { "6", 0, "bc0e8da6-b978-4134-a807-68d04c96a5a3", 5, "sarahdv@proximus.be", false, false, null, "SARAHDV@PROXIMUS.BE", "SARAHDV@PROXIMUS.BE", "AQAAAAEAACcQAAAAEOjAwwDlNYBTkus0opJcC0dHKzEf5PQYdzOJQH96MpvRojDizU5XMjvtfMaJAqiNLA==", null, false, "6b52db6b-4f3c-4aa3-afa6-94f702f87b28", false, "sarahdv@proximus.be", null },
                    { "7", 0, "200128a6-b82b-4230-9dc2-fb0c59890d5e", 6, "jdv@yahoo.com", false, false, null, "JDV@YAHOO.COM", "JDV@YAHOO.COM", "AQAAAAEAACcQAAAAEA8swpX3/LsgkJvh6EBtWNT2o3y9RrkEO7pUXN/UDrkEh4grPXK9l/6Xdb7iGpU10w==", null, false, "e15f983c-a9c1-485c-a5ea-3ea58d435d66", false, "jdv@yahoo.com", null },
                    { "8", 0, "78eeb986-eadd-4249-830c-631aec567e56", 7, "mieketjeeeeh@gmail.com", false, false, null, "MIEKETJEEEEH@GMAIL.COM", "MIEKETJEEEEH@GMAIL.COM", "AQAAAAEAACcQAAAAEGUYk05UcsWaBixTC+Yi6ouCmhzOIzpBoNriScE5Hny3lke1kdfbQF72oHbratJWmg==", null, false, "62b06efb-ce7b-4676-905b-8945fa1e53f1", false, "mieketjeeeeh@gmail.com", null },
                    { "9", 0, "645aae43-830c-4720-84e3-0c719a31c807", 8, "jeffkeeuh@gmail.com", false, false, null, "JEFFKEEUH@GMAIL.COM", "JEFFKEEUH@GMAIL.COM", "AQAAAAEAACcQAAAAEKvJVayCkTxr4WNz+kgsoJOT/y6/hc4UN1ePyIsC8px650bh6oPzEEyq708puoL6ZQ==", null, false, "3afa520a-de61-4f32-bbba-a7e809ce3ca5", false, "jeffkeeuh@gmail.com", null }
                });

            migrationBuilder.UpdateData(
                table: "Consultations",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateOfConsultation",
                value: new DateTime(2023, 11, 12, 13, 54, 52, 330, DateTimeKind.Local).AddTicks(2094));

            migrationBuilder.UpdateData(
                table: "Consultations",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateOfConsultation",
                value: new DateTime(2023, 11, 12, 13, 54, 52, 330, DateTimeKind.Local).AddTicks(2178));

            migrationBuilder.UpdateData(
                table: "Consultations",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateOfConsultation",
                value: new DateTime(2023, 11, 12, 13, 54, 52, 330, DateTimeKind.Local).AddTicks(2180));

            migrationBuilder.UpdateData(
                table: "Consultations",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateOfConsultation",
                value: new DateTime(2023, 11, 12, 13, 54, 52, 330, DateTimeKind.Local).AddTicks(2183));

            migrationBuilder.UpdateData(
                table: "Consultations",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateOfConsultation",
                value: new DateTime(2023, 11, 12, 13, 54, 52, 330, DateTimeKind.Local).AddTicks(2185));

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Address", "Birth", "City", "Email", "FirstName", "LastName", "Phone", "Postal", "PracticeId" },
                values: new object[] { 999, "Test", new DateTime(1996, 6, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Test", "Customer@test.com", "Test", "Test", "0032459698738", "9999", 1 });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "3", "10" },
                    { "3", "11" },
                    { "3", "2" },
                    { "3", "3" },
                    { "3", "4" },
                    { "3", "5" },
                    { "3", "6" },
                    { "3", "7" },
                    { "3", "8" },
                    { "3", "9" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "CustomerId", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName", "VeterinarianId" },
                values: new object[] { "12", 0, "fb6e678b-59f8-4619-bc85-9ab2c15e810b", 999, "Customer@test.com", false, false, null, "CUSTOMER@TEST.COM", "CUSTOMER@TEST.COM", "AQAAAAEAACcQAAAAEL46eNB+ab+lXhH4zg7s97JRFber63jO6XTyBYwysOE/IoZ8GeH6fm0Y6MpFvF0AAg==", null, false, "5d90f307-8270-47a6-a461-1d74a81a9ee1", false, "Customer@test.com", null });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "3", "10" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "3", "11" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "3", "2" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "3", "3" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "3", "4" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "3", "5" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "3", "6" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "3", "7" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "3", "8" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "3", "9" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "10");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9");

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 999);

            migrationBuilder.UpdateData(
                table: "Consultations",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateOfConsultation",
                value: new DateTime(2023, 11, 11, 21, 37, 13, 345, DateTimeKind.Local).AddTicks(6146));

            migrationBuilder.UpdateData(
                table: "Consultations",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateOfConsultation",
                value: new DateTime(2023, 11, 11, 21, 37, 13, 345, DateTimeKind.Local).AddTicks(6186));

            migrationBuilder.UpdateData(
                table: "Consultations",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateOfConsultation",
                value: new DateTime(2023, 11, 11, 21, 37, 13, 345, DateTimeKind.Local).AddTicks(6188));

            migrationBuilder.UpdateData(
                table: "Consultations",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateOfConsultation",
                value: new DateTime(2023, 11, 11, 21, 37, 13, 345, DateTimeKind.Local).AddTicks(6190));

            migrationBuilder.UpdateData(
                table: "Consultations",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateOfConsultation",
                value: new DateTime(2023, 11, 11, 21, 37, 13, 345, DateTimeKind.Local).AddTicks(6192));
        }
    }
}
