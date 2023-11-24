using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Pri.Pawpi.Infrastructure.Migrations
{
    public partial class ChangeRoleToClaims : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1");

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
                keyValues: new object[] { "3", "12" });

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
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2", "18" });

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
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3");

            migrationBuilder.InsertData(
                table: "AspNetUserClaims",
                columns: new[] { "Id", "ClaimType", "ClaimValue", "UserId" },
                values: new object[,]
                {
                    { 1, "http://schemas.microsoft.com/ws/2008/06/identity/claims/role", "Admin", "1" },
                    { 2, "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/nameidentifier", "1", "1" },
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 2);

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

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "1", "b3436c15-8469-4032-a622-adaf76bfb5ef", "Admin", "ADMIN" },
                    { "2", "97b7b8d4-fbfc-4ef7-aa13-afc468c06c51", "Veterinarian", "VETERINARIAN" },
                    { "3", "91f8a34f-bc2f-4b0f-865b-0724c15c2750", "Customer", "CUSTOMER" }
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAECtL0u2Mp/170Z646xLizSmAAfCI83jr54dK8jLqMNBIpAZ2yJJ/L9bDSCYqSYApBg==");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6a9b2dfb-af8a-4130-9455-15b77df3f57e", "AQAAAAEAACcQAAAAEDus0kyXVwUOIxeFGq27YKmsBRIBVC0P4pYareKtR4RmCkCS+2S7Tc8r3PWNS11dng==", "f2cc0ad8-b2b1-40e7-ab81-4df95a70d13c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9fc31268-e984-4fec-bf95-e95606e4cdb0", "AQAAAAEAACcQAAAAEDHrfOTOUCFE5ZFB3J4/kbMIPTdoNxwfNHhJui3c7Bc5YGl1Nx7V1KhG1D/59wfjEQ==", "ef47dfdc-2bd3-4793-9729-45dd5aa603ae" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8aa5b031-0890-4e18-8a12-8ef7607968d5", "AQAAAAEAACcQAAAAEGxiwA60HEBdh5aCPc6/Q/rwQi5YUU4QA4rMwPzLazVOwm9osZva4AtiXRbdwZILLQ==", "0b786764-df84-4282-9741-8796b9c338f3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "13",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bc77d6ad-4cd6-4a82-8045-4adaf5cd8fda", "AQAAAAEAACcQAAAAEGhs2iuA8NOBLjvg8rQj/6F9oCo0i6ETzcNouhMwDLN6uuuUHoH0oZUqIU5hZWWiyw==", "964e85db-8e31-4d62-93b9-aa9b27bbe6e4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "14",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "855ab99b-9a16-4b30-89fc-fc6bca86b02c", "AQAAAAEAACcQAAAAEB6jdSF5qQGEGU6zFX/Hvq+ZQe6+O0lK7gp+bVNmbhPqeAn6lLdzSa14ffnpRokjrA==", "b9b459ac-7e15-4ef1-8bf3-458fcc11df4c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "15",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6dae1b8b-6d1a-4db6-808c-4acaf7f32c69", "AQAAAAEAACcQAAAAEHJEYqqBFEoYzMdm2JDwcPvOZYfz60a5K27jE4VZaXJrhuMdPqsmIw8HqywTHgAhlg==", "bf7ea8de-8591-4b6c-95c9-b9e8b82ad8a4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "16",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9d25fbdc-2a8d-4049-ac2a-89a498918931", "AQAAAAEAACcQAAAAEMNbigSBiWODCWJMzc50f31TKHDfZ1GAhwhAgIC0RbbU69Eujt2NZoMXaNHElhCpsw==", "0aee2410-b734-456f-89f8-ee4ac6e40094" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "17",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f90938c4-f067-488c-8dcf-dac2361f3beb", "AQAAAAEAACcQAAAAEP8i+md8sp9uUznGcNg7I48d+8jxbwzUj46w9DOdZcWQViDFCQ42sCnZ+ZngTUfM6w==", "21d5f6f7-147f-4981-b652-0ceef28c8fcd" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "18",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a93daa7e-8191-477c-87a3-699718202823", "AQAAAAEAACcQAAAAEKnWpmiJKTQTnPXP3QPMpBFLcLi6ItlWGjEE0q424lDAL2l078udzwsN1DOZLAggoA==", "56e49493-5719-4626-8bae-ecd7bd560eb6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "965bbca8-1cca-4296-9327-a7e15e6cd518", "AQAAAAEAACcQAAAAEARPYkWp4U8yfyL5bVrtiVIugVWIbLXcLsjWwjM+iC+LaBEIiiXPSjhO623592guWw==", "3d511a13-7d9d-49d0-bef1-7c1be7f0f3f9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "dc5a4ef8-9d1f-44bd-9426-4bda7212ecf1", "AQAAAAEAACcQAAAAEEvGj5Ydl7OuMf5wxonv4DiGj9to1icXG3Pa27nJocVAF+YyLVCzVRTWKd5nETkI6w==", "12b6afb3-f5a0-473b-887e-c3632394fbf0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ff154098-c5a7-4559-b749-4750a3356458", "AQAAAAEAACcQAAAAEG0lym9DkqLwtQtKK5TRRYt8z2UR3jvWCnsfUyfq7ssUaDif2wBozNtrnmqUG/MaPQ==", "924b739c-7228-46d6-90ae-5632590e874f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9409b4c0-7c42-4a1d-9fbe-b9f0460c4291", "AQAAAAEAACcQAAAAEMp4QcCozBtjrDjTahZwKQYyWSGXJuWI2sXqIxFFrCAKH4ZatbrOQ96PJd96mIz10A==", "b25339cd-2e3c-49a4-9db8-7ac5b65bcabb" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "84066505-7732-4a39-b884-fa580995ac1e", "AQAAAAEAACcQAAAAELW0eA8t+3F4Z0B6IxMerk8/0mfobqB2o4JJGrJOk8KhKxjvRqJm2Q4L9HBVpNTsrg==", "31fcb321-f27e-43c9-8989-be31bb3b353a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4f359ced-4784-45f5-9ff5-5b8fa30f3a9b", "AQAAAAEAACcQAAAAEMCBy3vp/GfGrx1Cs7Zdg6x3pkfNsIbg5YKaClg+hdqtS8PdMuIcTtwBRzghNmeMRw==", "2f080e4a-7989-4df2-8d97-ba3020a5f0c3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "410bb21d-4325-4f68-8a23-763140ec73c7", "AQAAAAEAACcQAAAAEIXNtRSKmHa8mHj6pXwe46aEL4+W0YMO7KZI5Kpp40VQD281n3OAoX+UbritqGJ0KA==", "37726e42-a948-4c45-a7fd-f54c02d51fae" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "062240e0-f6ff-4588-b26b-e22beb69aae2", "AQAAAAEAACcQAAAAEBt5Vb8qqsVqHGUXERLRjiVeNoJPWSetI5nFUyejtgTclrKD3u9YGk8bkExCLUi7hw==", "48391630-94d7-4d82-b4c6-2ca43fe175b4" });

            migrationBuilder.UpdateData(
                table: "Consultations",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateOfConsultation",
                value: new DateTime(2023, 11, 16, 18, 42, 7, 381, DateTimeKind.Local).AddTicks(32));

            migrationBuilder.UpdateData(
                table: "Consultations",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateOfConsultation",
                value: new DateTime(2023, 11, 16, 18, 42, 7, 381, DateTimeKind.Local).AddTicks(79));

            migrationBuilder.UpdateData(
                table: "Consultations",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateOfConsultation",
                value: new DateTime(2023, 11, 16, 18, 42, 7, 381, DateTimeKind.Local).AddTicks(84));

            migrationBuilder.UpdateData(
                table: "Consultations",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateOfConsultation",
                value: new DateTime(2023, 11, 16, 18, 42, 7, 381, DateTimeKind.Local).AddTicks(87));

            migrationBuilder.UpdateData(
                table: "Consultations",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateOfConsultation",
                value: new DateTime(2023, 11, 16, 18, 42, 7, 381, DateTimeKind.Local).AddTicks(90));

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "3", "10" },
                    { "3", "11" },
                    { "3", "12" },
                    { "2", "13" },
                    { "2", "14" },
                    { "2", "15" },
                    { "2", "16" },
                    { "2", "17" },
                    { "2", "18" },
                    { "3", "2" },
                    { "3", "3" },
                    { "3", "4" },
                    { "3", "5" },
                    { "3", "6" },
                    { "3", "7" },
                    { "3", "8" },
                    { "3", "9" }
                });
        }
    }
}
