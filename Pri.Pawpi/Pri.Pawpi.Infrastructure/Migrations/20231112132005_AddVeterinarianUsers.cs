
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Pri.Pawpi.Infrastructure.Migrations
{
    public partial class AddVeterinarianUsers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "feb2a6e1-fb58-4358-94bb-b965bb6ac010");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "89b85ee3-e7e6-48b9-b5e7-c25098d9ec6b");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3",
                column: "ConcurrencyStamp",
                value: "f048650c-ee1d-42dd-9200-69d80f930f74");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7fe00ce1-4461-4120-9a45-5f8b01f90ae3", "AQAAAAEAACcQAAAAEJ+h6cFLBuSsMQBNKfZp2oO7DpVqds+SrDDvj13OK/zqBuCgNn2LW6OZfWI8pCIJ9Q==", "25372475-e913-434e-85f8-4e6caadcff8f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2e6ff49a-ef1e-45fc-b697-069e1ab17c90", "AQAAAAEAACcQAAAAECoTbZKlR0xworQph3kBvKJrH6+YJw9jiT/aaqEhXx32MQVY1TmLj0RX9tATGQRXHA==", "f6be527a-22a1-4e54-bf86-537bf9351e7f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "354bb87c-fee9-4f12-bdb7-e46ffd1d6825", "AQAAAAEAACcQAAAAEK+7dQZn9E2bM3wxDL7s+QVksHWVB8HFmCihA70qeSLjul3burnJQcrzmNZi9239fQ==", "35490016-9555-42b1-9c5c-7946dedc2a3e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "67446fa0-d819-40d7-9a22-28aa8c077b28", "AQAAAAEAACcQAAAAEF2uVBxzKsKa89J88QdlVz77P/8zHbOoDa/yQPbFA0zaxRC2l0ugJG4HiBO5MCos1Q==", "8421000e-a02c-40ff-adf4-322516fb1448" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4df7556d-9e7e-43a7-bbd8-33c223cde13f", "AQAAAAEAACcQAAAAEMErF7Q20M2BWzmuv6PwS3oigA5ajK4Kesfwaw8cXR62WzgaS2tU0MhwLv290Utbkg==", "358576d4-8280-4416-96a6-9be81e684099" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "29197ead-9bca-411e-9831-9c011e312c6b", "AQAAAAEAACcQAAAAEP97mx9GqjQ2G5NfWIin4J6sYFQpM4YXK200KcBDDZFIR/i54EelhomgyuXhusK/gQ==", "cee6ef0a-5bf7-4831-97ac-2fcced11e7cc" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0936ffee-e183-4897-b6c1-692374e07988", "AQAAAAEAACcQAAAAEC4OQ46raRPAcn6a8QqCpq+lYDNZTFQfYDrn2rSJ5R9k2mxBwwqjUfINp8UtDgCvXg==", "969d0dc2-1b48-407f-a938-318ebe81cf9b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "14516b88-4aee-4a2e-97cb-9ee06820476d", "AQAAAAEAACcQAAAAEE1FiN9yUdndxnlEqBxdGASjooWzbYIw4WotsQZkvUOel9X1Ln2aT8z9/QeEcVSAWg==", "b5eed595-8c2f-4217-8e55-c68805eafe52" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "69dab1d8-f50c-42e5-9bfe-6322a8e72e55", "AQAAAAEAACcQAAAAENhMwtuh+1yjpXIYetMsN1DW2FjLAXXb8aAvvpFpREslalR6vB8zUSc1gAkgpCFlVA==", "1b5669a7-d96c-490e-b168-52f078d53559" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8ed2b12a-a194-463b-bd21-1b13180fd9d4", "AQAAAAEAACcQAAAAEAW1xInSDK5e0U7i+9OSmHtbXp6R/URqpyfwvRsjSvjoF/p3mpH78IsPSXa1eT6ZDg==", "f8e2c894-920c-4573-a5a4-4b2c2cf488f3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "037967ba-58ab-4539-8c4f-42af2acc1d87", "AQAAAAEAACcQAAAAEHzvlK1ejSoUPZetlZ8fNzLaDY+KkaXBv34cEKxZnSBVSbsG5arFZvFnMG1RCWpAUQ==", "01a2a390-f69a-4da6-b871-1ae8fc69fa4f" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "CustomerId", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName", "VeterinarianId" },
                values: new object[,]
                {
                    { "13", 0, "abf36c02-66dc-4fa0-9673-9c4271eda97c", null, "vl@deberenakker.be", false, false, null, "VL@DEBERENAKKER.BE", "VL@DEBERENAKKER.BE", "AQAAAAEAACcQAAAAELDUaZmL7u2pz+UTxgEX7X+KMM/gvELHVgfE633ZG73spKu3FmUeQ6mgmUt3gnvcjg==", null, false, "d45c8295-e179-4aa1-acb1-130189c34987", false, "vl@deberenakker.be", 1 },
                    { "14", 0, "3ac10070-9fa7-4764-b3be-457184f48beb", null, "wb@gmail.com", false, false, null, "WB@GMAIL.COM", "WB@GMAIL.COM", "AQAAAAEAACcQAAAAEPNYrP18vXsVtYxno86n6aEqt1tosD42Way4FC0gciJn92oC6aPpAPxfzkgDRpWLeQ==", null, false, "62d8c2df-e140-472f-96c6-ff092832e0a0", false, "wb@gmail.com", 2 },
                    { "15", 0, "ad1bb5bb-cb67-448c-82c6-77d900c9651a", null, "kdv@gmail.com", false, false, null, "KDV@GMAIL.COM", "KDV@GMAIL.COM", "AQAAAAEAACcQAAAAEF/TP+3kIuzrhnx/TrYIwM2TJIBr02jitBBEGqB/SAB3mdBfwdrnSXKmGW2s1jGBcg==", null, false, "9c411f3f-9aef-432b-a831-21e8ff2b28fe", false, "kdv@gmail.com", 3 },
                    { "16", 0, "2a3e81ad-1e3c-46ff-8344-d4f6bf64cbbb", null, "SanneDZ@telenet.be", false, false, null, "SANNEDZ@TELENET.BE", "SANNEDZ@TELENET.BE", "AQAAAAEAACcQAAAAEHcPO3RX6RxcdgHes+v0FAfE0DiaqlEhbo+gxmB/v9Ljm2TN3Tf1gXWxKe6ZhQ/i+A==", null, false, "d229d3ac-97a1-4b95-acb0-3c4eff482307", false, "SanneDZ@telenet.be", 4 },
                    { "17", 0, "6b00bf9b-80e5-4bc5-a24d-9535a4812c59", null, "Lottevanputte@proximus.be", false, false, null, "LOTTEVANPUTTE@PROXIMUS.BE", "LOTTEVANPUTTE@PROXIMUS.BE", "AQAAAAEAACcQAAAAEJj2S1XR748vVw5MI+EYiWzhR7E+g2L2ZXFQiIXniaQjow2zBk5ufDsiFHndmpW2JQ==", null, false, "300cb121-c7ab-44a7-bb17-8e38bf446d5b", false, "Lottevanputte@proximus.be", 5 }
                });

            migrationBuilder.UpdateData(
                table: "Consultations",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateOfConsultation",
                value: new DateTime(2023, 11, 12, 14, 20, 4, 516, DateTimeKind.Local).AddTicks(880));

            migrationBuilder.UpdateData(
                table: "Consultations",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateOfConsultation",
                value: new DateTime(2023, 11, 12, 14, 20, 4, 516, DateTimeKind.Local).AddTicks(918));

            migrationBuilder.UpdateData(
                table: "Consultations",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateOfConsultation",
                value: new DateTime(2023, 11, 12, 14, 20, 4, 516, DateTimeKind.Local).AddTicks(921));

            migrationBuilder.UpdateData(
                table: "Consultations",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateOfConsultation",
                value: new DateTime(2023, 11, 12, 14, 20, 4, 516, DateTimeKind.Local).AddTicks(923));

            migrationBuilder.UpdateData(
                table: "Consultations",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateOfConsultation",
                value: new DateTime(2023, 11, 12, 14, 20, 4, 516, DateTimeKind.Local).AddTicks(925));

            migrationBuilder.InsertData(
                table: "Veterinarians",
                columns: new[] { "Id", "Address", "Birth", "City", "Email", "FirstName", "ImageFile", "LastName", "Phone", "Postal" },
                values: new object[] { 999, "Test", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Test", "Veterinarian@test.com", "Test", null, "Test", "0032459698738", "9999" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "2", "13" },
                    { "2", "14" },
                    { "2", "15" },
                    { "2", "16" },
                    { "2", "17" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "CustomerId", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName", "VeterinarianId" },
                values: new object[] { "18", 0, "f349c861-082a-42c1-9040-a250b8e3f365", null, "Veterinarian@test.com", false, false, null, "VETERINARIAN@TEST.COM", "VETERINARIAN@TEST.COM", "AQAAAAEAACcQAAAAEKF1AZFsnD1f65JTp91xVO9eUEbdunJJRKS1HgCgPim8gOC067DQGvJIIap0FdxW5A==", null, false, "db63cb60-bcb1-40ab-a216-7c302b0a0985", false, "Veterinarian@test.com", 999 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2", "13" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2", "14" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2", "15" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2", "16" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2", "17" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "18");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "13");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "14");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "15");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "16");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "17");

            migrationBuilder.DeleteData(
                table: "Veterinarians",
                keyColumn: "Id",
                keyValue: 999);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "7329779e-593b-46e0-8171-8e59b4a41b4c");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "96d7e490-bc95-4d83-b766-18ecbe03b349");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3",
                column: "ConcurrencyStamp",
                value: "984515c6-837e-4db2-88eb-2352371f2e41");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "490ceaec-2eb1-4637-8ede-9a5eedd59315", "AQAAAAEAACcQAAAAEPUmsYCdjxFhKo0u14rANoxBGei0Y+qUscnf24F92uhzmu1SZQpSCOhPA8E+dmFdhA==", "76dbc078-1d8e-48b4-a20c-a2a5f048406e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "494bf347-1d94-410e-9148-5373159f1b80", "AQAAAAEAACcQAAAAEK+wL/bG3aUUz9kip2kN3UI7R0ANKyCrZ5f26JioVWhpieESX+JzMy7lDg3KlS0ifw==", "498c0772-4b0d-4183-9707-706e934f3be5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fb6e678b-59f8-4619-bc85-9ab2c15e810b", "AQAAAAEAACcQAAAAEL46eNB+ab+lXhH4zg7s97JRFber63jO6XTyBYwysOE/IoZ8GeH6fm0Y6MpFvF0AAg==", "5d90f307-8270-47a6-a461-1d74a81a9ee1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d916bb95-d881-4f9f-9a8a-90722e3a1eba", "AQAAAAEAACcQAAAAEAK1q9TNqJ3A3aWPP5DXzm76saGCpxyeOR1aus7fdplqecXy2OsSj/CaTp9otygxJg==", "61463487-5a27-4eb4-b928-9601448d1a4d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c262cc53-8161-485e-84e4-fe043fbade80", "AQAAAAEAACcQAAAAEFL2wpVDyjqcsc3TwSRF0eb24qRM7IawYOgie0S5Dw09NADny5bdypXlCDIuiqhioA==", "ac2fe3a3-721d-4bbf-a08f-13d47640286c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1e8c569d-0658-4636-9e80-6e433a4200ab", "AQAAAAEAACcQAAAAEPbuizkREL+7jOooWQBYBsBaCWxtM7kDsGwzveyCslvzlY3orz/0R/dQ6DZdrkHcZw==", "f34aee25-e77d-4a2a-b7ca-d8f78f54ca9f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "874d4cc6-e4ef-4936-8a03-48e525eaf05b", "AQAAAAEAACcQAAAAECfDeXErwu+O9RW5RIliZdzrqTtt12g1qTcgomHxRiObrppM1kJipzNm9JiuN++Evg==", "d57db20a-f45b-406c-b9ba-a2a3f8d892b4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bc0e8da6-b978-4134-a807-68d04c96a5a3", "AQAAAAEAACcQAAAAEOjAwwDlNYBTkus0opJcC0dHKzEf5PQYdzOJQH96MpvRojDizU5XMjvtfMaJAqiNLA==", "6b52db6b-4f3c-4aa3-afa6-94f702f87b28" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "200128a6-b82b-4230-9dc2-fb0c59890d5e", "AQAAAAEAACcQAAAAEA8swpX3/LsgkJvh6EBtWNT2o3y9RrkEO7pUXN/UDrkEh4grPXK9l/6Xdb7iGpU10w==", "e15f983c-a9c1-485c-a5ea-3ea58d435d66" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "78eeb986-eadd-4249-830c-631aec567e56", "AQAAAAEAACcQAAAAEGUYk05UcsWaBixTC+Yi6ouCmhzOIzpBoNriScE5Hny3lke1kdfbQF72oHbratJWmg==", "62b06efb-ce7b-4676-905b-8945fa1e53f1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "645aae43-830c-4720-84e3-0c719a31c807", "AQAAAAEAACcQAAAAEKvJVayCkTxr4WNz+kgsoJOT/y6/hc4UN1ePyIsC8px650bh6oPzEEyq708puoL6ZQ==", "3afa520a-de61-4f32-bbba-a7e809ce3ca5" });

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
        }
    }
}
