using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Pri.Pawpi.Infrastructure.Migrations
{
    public partial class AddPracticeUserSeeder : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 1019);

            migrationBuilder.DeleteData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 1040);

            migrationBuilder.DeleteData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 1059);

            migrationBuilder.DeleteData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 1080);

            migrationBuilder.AddColumn<int>(
                name: "PracticeId",
                table: "AspNetUsers",
                type: "int",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetUserClaims",
                columns: new[] { "Id", "ClaimType", "ClaimValue", "UserId" },
                values: new object[,]
                {
                    { 101, "http://schemas.microsoft.com/ws/2008/06/identity/claims/role", "Customer", "2" },
                    { 102, "http://schemas.microsoft.com/ws/2008/06/identity/claims/role", "Customer", "3" },
                    { 103, "http://schemas.microsoft.com/ws/2008/06/identity/claims/role", "Customer", "4" },
                    { 104, "http://schemas.microsoft.com/ws/2008/06/identity/claims/role", "Customer", "5" },
                    { 105, "http://schemas.microsoft.com/ws/2008/06/identity/claims/role", "Customer", "6" },
                    { 106, "http://schemas.microsoft.com/ws/2008/06/identity/claims/role", "Customer", "7" },
                    { 107, "http://schemas.microsoft.com/ws/2008/06/identity/claims/role", "Customer", "8" },
                    { 108, "http://schemas.microsoft.com/ws/2008/06/identity/claims/role", "Customer", "9" },
                    { 109, "http://schemas.microsoft.com/ws/2008/06/identity/claims/role", "Customer", "10" },
                    { 110, "http://schemas.microsoft.com/ws/2008/06/identity/claims/role", "Customer", "11" },
                    { 151, "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/nameidentifier", "2", "2" },
                    { 152, "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/nameidentifier", "3", "3" },
                    { 153, "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/nameidentifier", "4", "4" },
                    { 154, "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/nameidentifier", "5", "5" },
                    { 155, "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/nameidentifier", "6", "6" },
                    { 156, "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/nameidentifier", "7", "7" },
                    { 157, "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/nameidentifier", "8", "8" },
                    { 158, "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/nameidentifier", "9", "9" },
                    { 159, "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/nameidentifier", "10", "10" },
                    { 160, "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/nameidentifier", "11", "11" },
                    { 201, "http://schemas.microsoft.com/ws/2008/06/identity/claims/role", "Veterinarian", "13" },
                    { 202, "http://schemas.microsoft.com/ws/2008/06/identity/claims/role", "Veterinarian", "14" },
                    { 203, "http://schemas.microsoft.com/ws/2008/06/identity/claims/role", "Veterinarian", "15" },
                    { 204, "http://schemas.microsoft.com/ws/2008/06/identity/claims/role", "Veterinarian", "16" },
                    { 205, "http://schemas.microsoft.com/ws/2008/06/identity/claims/role", "Veterinarian", "17" },
                    { 251, "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/nameidentifier", "13", "13" },
                    { 252, "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/nameidentifier", "14", "14" },
                    { 253, "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/nameidentifier", "15", "15" },
                    { 254, "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/nameidentifier", "16", "16" },
                    { 255, "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/nameidentifier", "17", "17" },
                    { 1099, "http://schemas.microsoft.com/ws/2008/06/identity/claims/role", "Customer", "12" },
                    { 1149, "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/nameidentifier", "12", "12" },
                    { 1199, "http://schemas.microsoft.com/ws/2008/06/identity/claims/role", "Veterinarian", "18" },
                    { 1249, "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/nameidentifier", "18", "18" }
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEIZIRrTX7W05XH1cxdWoXJ82pAW27O0SBLlX2mANPwPbYfu21gPjNpRyDJwi6Yh/mw==");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ad6789a2-9a42-49e3-be3c-e089579eb055", "AQAAAAEAACcQAAAAEBmcfDo3C78VeTWKo/ha7fOYsDiP4/OQD+exMdT16LvDAh+SYlJB66KqTufrkLfnJA==", "1d5334c6-ca03-4902-84df-83906e8b07dc" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d5f45698-c67a-4554-87ea-30a7fe9337e0", "AQAAAAEAACcQAAAAEAqvOW6673eUJ9lJYbRfZDjO7R4QWordvRX60mpJsp3nhs864RkImWysQyhJq5dt8w==", "435e2e61-f9c8-4e76-bbe9-bd70515f6474" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f82e4579-2515-473a-8fad-84de28790068", "AQAAAAEAACcQAAAAEMeWDDsGIZo8hxlxtjXS1uCjSjVsZaABpucO0BWlLS9Jd+HYdOTuCmlSM8mx7qXDVw==", "fa04d3ac-60e1-482a-a4f5-ac3e36fae6df" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "13",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1859dafb-c7c6-4739-b86f-f9d531136a72", "AQAAAAEAACcQAAAAEJrzKwTt8bAp8HU5FztX57Qn+tBwqF62eqRJ1TnkknBUQQNNBwr8RjNmcrICs7ODnw==", "be6408b8-e7d9-48f8-9a72-7646cd8b1811" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "14",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8dc5e01c-2cc1-4de6-af49-13e73ef5b517", "AQAAAAEAACcQAAAAEFG1+oj02IX8x57GMTBGPyiaZahM6VPUa8iHZI9AtZMrfyL3ayHzAAcmfZV5MMm7JA==", "9b60e01f-70da-471f-8aa1-7c4ac202fd06" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "15",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fcea1662-2d06-454b-b2cf-fa9b7969f4b3", "AQAAAAEAACcQAAAAELW+0K8XHyYqjxZusBvDq0w6SojGlhtNmibdwuqlnlqipYS1pz8nnexwzhqER4Dz7A==", "caaa0539-d490-4f41-9c9f-82fe3a4c85fa" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "16",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "dcaf625d-8552-44ff-8fae-d0b8c4eb4373", "AQAAAAEAACcQAAAAEDZhxGfBLyGUTGAhzmUTzriNg8Q96T8AwnuZyPQxVAAveyHMflk6xwS2J2kWsLWjOQ==", "2cf0e732-5424-4edb-a802-8dce2afee94f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "17",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b99b5152-a6e6-49d7-bbfb-26075730b43b", "AQAAAAEAACcQAAAAEJ4eGuzjHpPumMeJWu7n7+mu2jPSJRmj9LwTEyNm0THpgKs+mdVtIoaLocJ7wSxXKQ==", "302deeae-a6e0-42b5-ac61-bf5bd544a3c3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "18",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d0f1e919-8d89-4499-95ca-517135df3b7d", "AQAAAAEAACcQAAAAEPldz6QjIPruQBXhf9p1RumhIuZmZTKVNbwk3RZa0QzGHWHyOLD4Tq6lOz0yrYUQRA==", "533becc8-368a-4da0-af48-65d2af3067f3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6dde3a50-aa5f-4e45-b769-3b41dcf17ab5", "AQAAAAEAACcQAAAAEK5/y0UoleHfeDZtbkXHXgtZ5UgrtAS4tE2akXDGlKg4PMw0f1rvrtf0BoXvLKOnBQ==", "85e3582f-a2da-4c3e-86ae-102c525ef3d5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a926d5a1-4538-4039-b031-efbf24b4c01b", "AQAAAAEAACcQAAAAENyiK0i0LcEsfmwMcTFVbwFApVtYl0EmJLrbSd5DmDRIPfrjjvY+/zZY6JDZGIbO8A==", "5de36193-6bb2-461b-be1c-665011311343" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "96382b74-669e-4ef7-a051-87000190208f", "AQAAAAEAACcQAAAAEOHjwq2MvkSAGBAnHAN5bHxy7YRxzcT2EjA6H/dq60P5BVSG4GUPjlr4ty3gOaRm+Q==", "696e7aa1-00c7-410d-a806-359012dd08ed" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ccdbf5d5-bc2f-48e2-b090-cd77d15b70e1", "AQAAAAEAACcQAAAAELrke077FsjB3WZlHH6FjMyY1iGTwViKal4opOzz+I1ZnP9bM9ogKXyVEFIywqLbnQ==", "5a2c697d-aecc-4094-9ca0-d4fc4caf4d53" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1a76a8d9-df9c-4bef-b8ef-65f37cfc9e0e", "AQAAAAEAACcQAAAAEAm9sOnaNZw6CVLsafpNfxeSCoEq1Lk0j1w5FlEVg4WbcCV2RulzkMVnsCvb5gYyBA==", "3314c9b9-4f11-48f7-a0db-9317fa64af61" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cef16885-ff4c-4bdd-a927-61a28ab78206", "AQAAAAEAACcQAAAAEOsBww6yqyzMTL/TCxb/32dyvhFf/VMtzgi3+9med4jzT2bhnRKtOzJ6VaOkua81uw==", "f88fb9b2-9af6-4f96-a8d1-5dd866020462" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b15a28b2-27c9-4073-b2b5-506bfbbe552a", "AQAAAAEAACcQAAAAELedGN6qcNnT/vm08YtIrsZgZm3FWXO1CLSgwo79+G2DoLp+hE8j1yUeKt+6Ta+4Og==", "3304dc70-56fe-42df-a389-2e5aad16a17d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "81e099fc-62a8-4d66-bcac-2ffa8fa72321", "AQAAAAEAACcQAAAAEE4KF3OWIWOuvGG4jMdNF4++q9zJfHYdpE0oWMbwWXWYpGMgPjjrO+1Xs6+GD+XLhQ==", "1b6b5b3d-2cd1-4b85-81f2-1efd2c11ed11" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "CustomerId", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "PracticeId", "SecurityStamp", "TwoFactorEnabled", "UserName", "VeterinarianId" },
                values: new object[,]
                {
                    { "19", 0, "b397e91e-ac0d-4ee9-8b25-c5c2d35d017e", null, "deberenakker@proximus.be", true, false, null, "DEBERENAKKER@PROXIMUS.BE", "DEBERENAKKER@PROXIMUS.BE", "AQAAAAEAACcQAAAAEMq9fiS/ahaK/gej1D7nM9XmCfnRulUfo8Uu/YdAvIOrf007dWFa13sIz7w9D4QBtQ==", null, false, 1, "7dafd2d6-59f2-4c3c-bc90-b414e4aac661", false, "deberenakker@proximus.be", null },
                    { "20", 0, "32af05c0-45c8-4f0d-bb4a-f02d4a175860", null, "Dedierenvriend@proximus.be", true, false, null, "DEDIERENVRIEND@PROXIMUS.BE", "DEDIERENVRIEND@PROXIMUS.BE", "AQAAAAEAACcQAAAAEPtenT0g4SipP6HCq4+i19lnXW9xMS+x/jZoNhJdVijX2hKf03EFzX3+vVTTTEFFfA==", null, false, 2, "80769d96-2329-41c8-a50e-801f843936ee", false, "Dedierenvriend@proximus.be", null },
                    { "21", 0, "30a3db67-a1ce-4aeb-83aa-33e88bf63bbe", null, "hetplatteland@proximus.be", true, false, null, "HETPLATTELAND@PROXIMUS.BE", "HETPLATTELAND@PROXIMUS.BE", "AQAAAAEAACcQAAAAEDn30kmxaGGs3XHlioTtvdgbClkRjZ7Uk/3bW99zDftvRoSE/9j6OiRrgkmf1Z3HTw==", null, false, 3, "43db4501-125a-4566-8434-d96dfc527645", false, "hetplatteland@proximus.be", null }
                });

            migrationBuilder.UpdateData(
                table: "Consultations",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateOfConsultation",
                value: new DateTime(2023, 11, 16, 20, 10, 12, 90, DateTimeKind.Local).AddTicks(2988));

            migrationBuilder.UpdateData(
                table: "Consultations",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateOfConsultation",
                value: new DateTime(2023, 11, 16, 20, 10, 12, 90, DateTimeKind.Local).AddTicks(3069));

            migrationBuilder.UpdateData(
                table: "Consultations",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateOfConsultation",
                value: new DateTime(2023, 11, 16, 20, 10, 12, 90, DateTimeKind.Local).AddTicks(3074));

            migrationBuilder.UpdateData(
                table: "Consultations",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateOfConsultation",
                value: new DateTime(2023, 11, 16, 20, 10, 12, 90, DateTimeKind.Local).AddTicks(3077));

            migrationBuilder.UpdateData(
                table: "Consultations",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateOfConsultation",
                value: new DateTime(2023, 11, 16, 20, 10, 12, 90, DateTimeKind.Local).AddTicks(3080));

            migrationBuilder.InsertData(
                table: "Practices",
                columns: new[] { "Id", "Address", "City", "CloseTime", "Email", "Logo", "Name", "OpenTime", "Phone", "Postal" },
                values: new object[] { 999, "Test", "Test", new DateTime(2021, 1, 1, 19, 0, 0, 0, DateTimeKind.Unspecified), "Practice@test.com", null, "Test", new DateTime(2021, 1, 1, 8, 0, 0, 0, DateTimeKind.Unspecified), "Test", "Test" });

            migrationBuilder.InsertData(
                table: "AspNetUserClaims",
                columns: new[] { "Id", "ClaimType", "ClaimValue", "UserId" },
                values: new object[,]
                {
                    { 301, "http://schemas.microsoft.com/ws/2008/06/identity/claims/role", "Practice", "19" },
                    { 302, "http://schemas.microsoft.com/ws/2008/06/identity/claims/role", "Practice", "20" },
                    { 303, "http://schemas.microsoft.com/ws/2008/06/identity/claims/role", "Practice", "21" },
                    { 351, "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/nameidentifier", "19", "19" },
                    { 352, "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/nameidentifier", "20", "20" },
                    { 353, "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/nameidentifier", "21", "21" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "CustomerId", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "PracticeId", "SecurityStamp", "TwoFactorEnabled", "UserName", "VeterinarianId" },
                values: new object[] { "22", 0, "9f4e9677-31dc-4a25-92dd-29d3f3e466a5", null, "Practice@test.com", true, false, null, "PRACTICE@TEST.COM", "PRACTICE@TEST.COM", "AQAAAAEAACcQAAAAEJdmSf/SSDaYFzQGnhWF9qdjBbwyT1GkKTe58RJ2BCt+6sNguAGxDeK1hhX3/C0skQ==", null, false, 999, "d0ef0022-e852-4c9a-b8bb-0a593eda24d6", false, "Practice@test.com", null });

            migrationBuilder.InsertData(
                table: "AspNetUserClaims",
                columns: new[] { "Id", "ClaimType", "ClaimValue", "UserId" },
                values: new object[] { 1299, "http://schemas.microsoft.com/ws/2008/06/identity/claims/role", "Practice", "22" });

            migrationBuilder.InsertData(
                table: "AspNetUserClaims",
                columns: new[] { "Id", "ClaimType", "ClaimValue", "UserId" },
                values: new object[] { 1349, "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/nameidentifier", "22", "22" });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_PracticeId",
                table: "AspNetUsers",
                column: "PracticeId",
                unique: true,
                filter: "[PracticeId] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Practices_PracticeId",
                table: "AspNetUsers",
                column: "PracticeId",
                principalTable: "Practices",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Practices_PracticeId",
                table: "AspNetUsers");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_PracticeId",
                table: "AspNetUsers");

            migrationBuilder.DeleteData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 110);

            migrationBuilder.DeleteData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 151);

            migrationBuilder.DeleteData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 152);

            migrationBuilder.DeleteData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 153);

            migrationBuilder.DeleteData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 154);

            migrationBuilder.DeleteData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 155);

            migrationBuilder.DeleteData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 156);

            migrationBuilder.DeleteData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 157);

            migrationBuilder.DeleteData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 158);

            migrationBuilder.DeleteData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 159);

            migrationBuilder.DeleteData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 160);

            migrationBuilder.DeleteData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 201);

            migrationBuilder.DeleteData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 202);

            migrationBuilder.DeleteData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 203);

            migrationBuilder.DeleteData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 204);

            migrationBuilder.DeleteData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 205);

            migrationBuilder.DeleteData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 251);

            migrationBuilder.DeleteData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 252);

            migrationBuilder.DeleteData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 253);

            migrationBuilder.DeleteData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 254);

            migrationBuilder.DeleteData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 255);

            migrationBuilder.DeleteData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 301);

            migrationBuilder.DeleteData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 302);

            migrationBuilder.DeleteData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 303);

            migrationBuilder.DeleteData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 351);

            migrationBuilder.DeleteData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 352);

            migrationBuilder.DeleteData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 353);

            migrationBuilder.DeleteData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 1099);

            migrationBuilder.DeleteData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 1149);

            migrationBuilder.DeleteData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 1199);

            migrationBuilder.DeleteData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 1249);

            migrationBuilder.DeleteData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 1299);

            migrationBuilder.DeleteData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 1349);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "19");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "20");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "21");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "22");

            migrationBuilder.DeleteData(
                table: "Practices",
                keyColumn: "Id",
                keyValue: 999);

            migrationBuilder.DropColumn(
                name: "PracticeId",
                table: "AspNetUsers");

            migrationBuilder.InsertData(
                table: "AspNetUserClaims",
                columns: new[] { "Id", "ClaimType", "ClaimValue", "UserId" },
                values: new object[,]
                {
                    { 21, "http://schemas.microsoft.com/ws/2008/06/identity/claims/role", "Customer", "2" },
                    { 22, "http://schemas.microsoft.com/ws/2008/06/identity/claims/role", "Customer", "3" },
                    { 23, "http://schemas.microsoft.com/ws/2008/06/identity/claims/role", "Customer", "4" },
                    { 24, "http://schemas.microsoft.com/ws/2008/06/identity/claims/role", "Customer", "5" },
                    { 25, "http://schemas.microsoft.com/ws/2008/06/identity/claims/role", "Customer", "6" },
                    { 26, "http://schemas.microsoft.com/ws/2008/06/identity/claims/role", "Customer", "7" },
                    { 27, "http://schemas.microsoft.com/ws/2008/06/identity/claims/role", "Customer", "8" },
                    { 28, "http://schemas.microsoft.com/ws/2008/06/identity/claims/role", "Customer", "9" },
                    { 29, "http://schemas.microsoft.com/ws/2008/06/identity/claims/role", "Customer", "10" },
                    { 30, "http://schemas.microsoft.com/ws/2008/06/identity/claims/role", "Customer", "11" },
                    { 42, "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/nameidentifier", "2", "2" },
                    { 43, "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/nameidentifier", "3", "3" },
                    { 44, "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/nameidentifier", "4", "4" },
                    { 45, "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/nameidentifier", "5", "5" },
                    { 46, "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/nameidentifier", "6", "6" },
                    { 47, "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/nameidentifier", "7", "7" },
                    { 48, "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/nameidentifier", "8", "8" },
                    { 49, "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/nameidentifier", "9", "9" },
                    { 50, "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/nameidentifier", "10", "10" },
                    { 51, "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/nameidentifier", "11", "11" },
                    { 61, "http://schemas.microsoft.com/ws/2008/06/identity/claims/role", "Veterinarian", "13" },
                    { 62, "http://schemas.microsoft.com/ws/2008/06/identity/claims/role", "Veterinarian", "14" },
                    { 63, "http://schemas.microsoft.com/ws/2008/06/identity/claims/role", "Veterinarian", "15" },
                    { 64, "http://schemas.microsoft.com/ws/2008/06/identity/claims/role", "Veterinarian", "16" },
                    { 65, "http://schemas.microsoft.com/ws/2008/06/identity/claims/role", "Veterinarian", "17" },
                    { 82, "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/nameidentifier", "13", "13" },
                    { 83, "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/nameidentifier", "14", "14" },
                    { 84, "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/nameidentifier", "15", "15" },
                    { 85, "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/nameidentifier", "16", "16" },
                    { 86, "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/nameidentifier", "17", "17" },
                    { 1019, "http://schemas.microsoft.com/ws/2008/06/identity/claims/role", "Customer", "12" },
                    { 1040, "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/nameidentifier", "12", "12" },
                    { 1059, "http://schemas.microsoft.com/ws/2008/06/identity/claims/role", "Veterinarian", "18" },
                    { 1080, "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/nameidentifier", "18", "18" }
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAECIVSX5aFKZyaY0Rj8QeNehpjV25TfDGI43ku1LdQQxjjAta3Xr0bOJTsNByIU60qA==");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9bd7c7fb-cc8b-4ba1-97cb-764b4bf214ea", "AQAAAAEAACcQAAAAEIPiApatJPqHKjdG4ooOYMVGNbqgjJhwpYb1nsTb/UzPmFcnjECPpB3hkCA7g6dOpw==", "f7a5c6b9-b8ac-4a27-8f14-f52361e73bce" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a78b24d5-0d04-4337-932a-23a242cfb145", "AQAAAAEAACcQAAAAEJ02zgXhFUU5gLgnOQJayHv2+NA8pU2cynv3kRfD+pQ6hcj6a2CxXA+VHvc+hCsAVQ==", "6ff730eb-3921-4a1e-a46b-ff727e786eb4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d5b70083-00bc-4b98-9db5-377cb46b1b84", "AQAAAAEAACcQAAAAEKRKVDfCtNvLrov7Ic1V1tPWt4rXFSv+6B+Sbrf6tjxeMtFrMnFqb1kbnL81rbp25Q==", "fb3defd2-7207-4741-8091-f57b41d702e5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "13",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "58d27d04-060f-4344-82bb-c08a8d9b0264", "AQAAAAEAACcQAAAAEFRbAaTiJ5Bg/DP9nxfYScWZksUyN/rLeKiCDPnC3ePXwoO1lq5YycykDfu7EXD/pg==", "83f1c08b-5faf-4ecc-b04b-81b808ec1bf4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "14",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "02ebd082-56c5-443b-b7cd-cfbe73076fd0", "AQAAAAEAACcQAAAAECeC4sNdvxdGQNaMrtdEyIiG0MmCpfOil5UJ9Zy4SGo5uR6DXyohY53Yx4cctsHSwg==", "48c1815e-3e62-4c49-8058-e0edc98b2ed1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "15",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bb60c8f9-5559-404b-a18e-7461470ff4bc", "AQAAAAEAACcQAAAAECHUSTP/3ULma5Dw9WxLFDxbrkOUeF1lLmLHBIvn2igacdmY0Sqz5oxduzF67gTh9g==", "c9c3b174-414f-4b69-a755-e11232a2b01d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "16",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "889681f1-0f8f-4da1-9e36-9731de9ccb70", "AQAAAAEAACcQAAAAEDy651t24xpPD579NEMVRlsRgj30B3BVoSme28/WpSx7/BvJAQleIOxy/hiw17vkWw==", "a51b9dc1-b5c1-455a-882c-ab735c4dfecb" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "17",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "85497d90-2204-4501-b6a5-9a263212c106", "AQAAAAEAACcQAAAAEBWZx3u2pqj0+l19GYKFo79QaLU6dTDIF07DlbSW9LN2KeyrWd49eafYIfXZ1Qy5Nw==", "8f7b6b51-c9b2-46d9-afcf-56f10c02c194" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "18",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "60733a9d-bac2-4444-8329-933e1e6da3ec", "AQAAAAEAACcQAAAAENu5rVBBw9eNgHMewmMhatsmhhNzu6V+H2CS+x+PizFYHuPin8NIeiefEyJIE0HSuw==", "10c398af-043a-4652-b7ef-2b2a180f7c79" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "05390851-63af-43fa-b53c-973c06342041", "AQAAAAEAACcQAAAAEBdjMub3LmK+XMUaptfGmy2PjxALRrT0dFJchZqPPq7cGwKSYAEZqmEkYU69+6LmnA==", "ed2bfd1d-1a0b-4593-9a80-2622a95523de" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "463a6126-29b2-45e1-b478-389851692c3b", "AQAAAAEAACcQAAAAEK5CCXKFazdiHXUyUUsE+6n8/5ialvfKixBz9L4ZTzuH2cFb8TVHvMSLliNHhbNHig==", "b7cd24be-5f9d-45d0-ab7d-326ee94ed063" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7900e06b-9e3a-4ebe-9cd4-98b1a864a4bc", "AQAAAAEAACcQAAAAEBklOiKDDRq9p8aOK6EXOtXELzZ+4g8MkzbQrroyh8wbFWuSp4eN4hEnXkOv9YXTMw==", "d1d48540-5a41-45d0-ac0e-67857f844aa5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b837ee6c-b325-4d2a-8a4d-b2f7cc613a86", "AQAAAAEAACcQAAAAEClZt1rtzTzADmhaZI+XJB2UhuaEOVOBDcAaGGeVwbrgYcVGueueP+Uqv21quJov2g==", "c50ce241-bd71-4300-82b3-89b1ae77359f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "381ee07d-9515-4650-9c33-ff1081394fbf", "AQAAAAEAACcQAAAAENwO5x+S/A7MnMUyex2HN/R6/Z8smlIVXpf69RCX6Cy74c7a1qR83ndkQCZm3ikaHw==", "84c0992d-577d-4393-a9ce-38c064fcf164" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bfb224fb-ec6d-4e11-9891-beac11a5b95a", "AQAAAAEAACcQAAAAEJPbNsFDtTVM/4pJjHoIQAbMrv9hTcg/5RbNLP8yZa1EhCNSBNRvM8b3/I2bHUc8Rw==", "aa0ebb9b-efea-4e12-b95a-e3042c8b6a7b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9e05af40-958c-4844-a742-0c0c2dd8370b", "AQAAAAEAACcQAAAAEAW5u17qZ/gEg8ONK9VMm2718YSkwdIDOwzBfKoHpkNy4IkMd0TG5zTbh363TWIboA==", "aad2add0-e5a7-4dcc-993a-654937daa324" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b89911d5-5739-463d-bd7d-5986b3fb93f5", "AQAAAAEAACcQAAAAEFx8y56NY9tRqVtbw61d6AEzO1Mh0ZO2NCYq37a6k/54bnoxtNCKn/34AgbY9Mf/ZQ==", "a20deaa7-2cb4-41ee-9be1-33296e952d65" });

            migrationBuilder.UpdateData(
                table: "Consultations",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateOfConsultation",
                value: new DateTime(2023, 11, 16, 19, 22, 49, 964, DateTimeKind.Local).AddTicks(8983));

            migrationBuilder.UpdateData(
                table: "Consultations",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateOfConsultation",
                value: new DateTime(2023, 11, 16, 19, 22, 49, 964, DateTimeKind.Local).AddTicks(9026));

            migrationBuilder.UpdateData(
                table: "Consultations",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateOfConsultation",
                value: new DateTime(2023, 11, 16, 19, 22, 49, 964, DateTimeKind.Local).AddTicks(9030));

            migrationBuilder.UpdateData(
                table: "Consultations",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateOfConsultation",
                value: new DateTime(2023, 11, 16, 19, 22, 49, 964, DateTimeKind.Local).AddTicks(9033));

            migrationBuilder.UpdateData(
                table: "Consultations",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateOfConsultation",
                value: new DateTime(2023, 11, 16, 19, 22, 49, 964, DateTimeKind.Local).AddTicks(9036));
        }
    }
}
