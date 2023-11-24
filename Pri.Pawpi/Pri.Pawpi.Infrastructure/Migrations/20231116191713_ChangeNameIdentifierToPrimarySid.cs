using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Pri.Pawpi.Infrastructure.Migrations
{
    public partial class ChangeNameIdentifierToPrimarySid : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 2,
                column: "ClaimType",
                value: "http://schemas.microsoft.com/ws/2008/06/identity/claims/primarysid");

            migrationBuilder.UpdateData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 151,
                column: "ClaimType",
                value: "http://schemas.microsoft.com/ws/2008/06/identity/claims/primarysid");

            migrationBuilder.UpdateData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 152,
                column: "ClaimType",
                value: "http://schemas.microsoft.com/ws/2008/06/identity/claims/primarysid");

            migrationBuilder.UpdateData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 153,
                column: "ClaimType",
                value: "http://schemas.microsoft.com/ws/2008/06/identity/claims/primarysid");

            migrationBuilder.UpdateData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 154,
                column: "ClaimType",
                value: "http://schemas.microsoft.com/ws/2008/06/identity/claims/primarysid");

            migrationBuilder.UpdateData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 155,
                column: "ClaimType",
                value: "http://schemas.microsoft.com/ws/2008/06/identity/claims/primarysid");

            migrationBuilder.UpdateData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 156,
                column: "ClaimType",
                value: "http://schemas.microsoft.com/ws/2008/06/identity/claims/primarysid");

            migrationBuilder.UpdateData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 157,
                column: "ClaimType",
                value: "http://schemas.microsoft.com/ws/2008/06/identity/claims/primarysid");

            migrationBuilder.UpdateData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 158,
                column: "ClaimType",
                value: "http://schemas.microsoft.com/ws/2008/06/identity/claims/primarysid");

            migrationBuilder.UpdateData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 159,
                column: "ClaimType",
                value: "http://schemas.microsoft.com/ws/2008/06/identity/claims/primarysid");

            migrationBuilder.UpdateData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 160,
                column: "ClaimType",
                value: "http://schemas.microsoft.com/ws/2008/06/identity/claims/primarysid");

            migrationBuilder.UpdateData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 251,
                column: "ClaimType",
                value: "http://schemas.microsoft.com/ws/2008/06/identity/claims/primarysid");

            migrationBuilder.UpdateData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 252,
                column: "ClaimType",
                value: "http://schemas.microsoft.com/ws/2008/06/identity/claims/primarysid");

            migrationBuilder.UpdateData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 253,
                column: "ClaimType",
                value: "http://schemas.microsoft.com/ws/2008/06/identity/claims/primarysid");

            migrationBuilder.UpdateData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 254,
                column: "ClaimType",
                value: "http://schemas.microsoft.com/ws/2008/06/identity/claims/primarysid");

            migrationBuilder.UpdateData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 255,
                column: "ClaimType",
                value: "http://schemas.microsoft.com/ws/2008/06/identity/claims/primarysid");

            migrationBuilder.UpdateData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 351,
                column: "ClaimType",
                value: "http://schemas.microsoft.com/ws/2008/06/identity/claims/primarysid");

            migrationBuilder.UpdateData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 352,
                column: "ClaimType",
                value: "http://schemas.microsoft.com/ws/2008/06/identity/claims/primarysid");

            migrationBuilder.UpdateData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 353,
                column: "ClaimType",
                value: "http://schemas.microsoft.com/ws/2008/06/identity/claims/primarysid");

            migrationBuilder.UpdateData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 1149,
                column: "ClaimType",
                value: "http://schemas.microsoft.com/ws/2008/06/identity/claims/primarysid");

            migrationBuilder.UpdateData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 1249,
                column: "ClaimType",
                value: "http://schemas.microsoft.com/ws/2008/06/identity/claims/primarysid");

            migrationBuilder.UpdateData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 1349,
                column: "ClaimType",
                value: "http://schemas.microsoft.com/ws/2008/06/identity/claims/primarysid");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEHy93hIcrHPWEQL229/wzzwQIefDsL7KuIaZxqXnUce03tcXy3sV+QvUl96CZ1yW6A==");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "136dc170-c1c6-4129-a990-cb2ed55135fb", "AQAAAAEAACcQAAAAEERaNggtEEl3OFa62Atv/2p9vGHSdG4WuneOx7B19o8hBV0Fn222PJsIYNWiaAunbQ==", "95cddb27-c7cc-4a7f-9292-b6a758890ff9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c0e0fe2e-9636-440c-b365-5dd90666f678", "AQAAAAEAACcQAAAAEOo6ydeDsrRI3w0AFF0yDASCSyUYy6uH6oBMLwFM06YvuA8Zdzs2cDnlDGcLRekQOg==", "337a2c93-da3e-4c34-a0d0-b75d3a0dd79c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b47c9407-f968-4914-a094-36422682d0d3", "AQAAAAEAACcQAAAAEBRmAcGfBDLL+i/wBWUrujvVNa4ElNcsTiM9fIxj+7S2YvuuU3odgYqXOgH5tVg4pA==", "867d0811-0fe9-4cf6-8b76-e963a4341c05" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "13",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3f83d6ae-56f5-4daa-9707-0fd61107fd38", "AQAAAAEAACcQAAAAEHxNSz6TSAhEPzmi7QGkx5PxE+i5x6RvL9f8C+tyxBqogTFzIy7cnY1nXN4V3AfN1A==", "cc63e17a-0f1f-4282-aa8e-87f39517952e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "14",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "02e5ef2a-9a67-4cc9-9e3b-c0ef31899f7b", "AQAAAAEAACcQAAAAEIaIUjmUu3n19kSDAk5CEEz1Y6d0TmX8omUAKHskdyU19q7cDacN0DtWlAsq/uZroQ==", "84a3e232-0857-4e87-8c6f-177db5431e0e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "15",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4cb3094e-e06c-4348-b553-1adc630d6d0d", "AQAAAAEAACcQAAAAED+Lt4T2aVeHktiog2WU6EhtoavgwsYA8HEywR7A/3M2FWMQSL5O3JB8mvrstEdySA==", "0473462b-7021-44a0-a82f-020fddbd0985" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "16",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b07a7a43-8835-44c3-b18c-47bd7f8d04d0", "AQAAAAEAACcQAAAAEHsc5hqlhuWfjtujwwA+DnsWt1yrzbZp3qTvfYWhUyvykDj2ufh/K/Il2ZkIGOqyZA==", "461dce19-a30f-4f8b-ae95-68608570e421" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "17",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9c568623-eab7-4eec-808c-9a825cee72e5", "AQAAAAEAACcQAAAAEOATQkjhXANT/WYXWgK91J6P7tHEnCL3Vanj6KPsWppU/wUDZWv7vScG2tkEVzADoQ==", "33c4bab4-8896-4809-a218-013989cf37be" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "18",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "faa20a4c-86ea-45a9-9d5f-f2604ca54593", "AQAAAAEAACcQAAAAEOHfmnjqq36ZnMXNGm8suIYbcIa792Vn5boCyjQpPO5xri2bvKKqEujQBoKGmKkrJA==", "43cdfa1d-3e51-4754-8e0a-84fa8cde6c61" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "19",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3a7eb633-7bd2-4804-a53d-40f4ae24933f", "AQAAAAEAACcQAAAAEEjTRWmsBPusk12rXE4ObNtAU6M/dUXt+RcmaEVwHZk2lPqR8Q9QlqGR1bpy2P1SUw==", "c074070b-5681-4553-947a-f067023d4a95" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "721cc70d-ddc4-4735-900e-5d04a7de329b", "AQAAAAEAACcQAAAAEEQ0sRFMaBjReLWm27w+KDJGPZZvnkaGv1kzcHytKnFVNHjZgG2tK931Us+LB3PyBQ==", "5ed0e923-1088-469a-a644-a1fd4584a4c2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "20",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d599cef8-96c3-4ca7-83fb-c9f697eb6b47", "AQAAAAEAACcQAAAAEGlWiyFFu1gy2CaAtoOd1Y6i1IaAZL/R4WtAE8DEhB6joV/knO0aDTjI+o5wDIshhw==", "094bea9d-3852-475c-9f31-80bde49f9784" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "21",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ee8c4c45-3a8b-41ff-8cc6-0c9934274e05", "AQAAAAEAACcQAAAAENrA0inyzzaO+lY38w/fIK+d1FY8/yWXIqrANbgedCbueUhCF5uLtHwHtVPNrJO4fw==", "36014694-84b3-4bff-99de-2d6d818584e6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "22",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d23c577b-2a60-424e-ac77-0decd04531dd", "AQAAAAEAACcQAAAAECBcIzPsBl7QvvTpd9Ah0I99QQovRX3nJAgSit8naTPNg38PDbyMpzeeCeldmkIKtA==", "30d0a5e3-7732-4fcd-ab3e-7f29e2ca49af" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "02f39325-6e6d-4651-8188-e10bdba458ad", "AQAAAAEAACcQAAAAEGyufzQRgldKY1rjjwpPbY1uH9jSP57Zt9tQeRMPxhqwqnWlDW2NCVWSK/Jjn89JMA==", "95aef76d-ee99-4d14-aab5-184f3a2f7953" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3ab157ae-3586-49fe-96b0-79e5e7b40e36", "AQAAAAEAACcQAAAAEAkZyjmJC6NKYn1K5Yj6JDY9xYK26+QmEjgo/yHnfn2LmAlPSQnSiWsQlfuycnKBoA==", "9cace100-d1ee-492b-9cf7-c1bcb661fe5c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "16823e15-b6ce-45ee-ae2b-28d694944cef", "AQAAAAEAACcQAAAAEHM2EOkuz/J5ZL0Y3sB52zx4h/XJDr5LqyoPACisDKys8VLBzm/QgaEz3Omg86dcRA==", "d13f3c16-286e-4faa-90e2-d0ad59ed064b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "919360c4-9967-4ca6-8709-11e83b2692f9", "AQAAAAEAACcQAAAAEJWCtDXldvaKXcveEaG5DQ4di4Rene6OPYb/uzF6fZCTXBHJHxfrSzU19V1mePDYzA==", "807e33f4-2b90-4179-9fff-700e334ee9ab" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bd400646-864c-4dd8-b70b-bb4c7ccd8d22", "AQAAAAEAACcQAAAAEFeNLHJDygzNeUgx66Es57zQeZP1dqrQLXOS7UKP/dALmB+qDEZnIGklASD/WMp/tA==", "dc2a89d3-c9ac-4d58-96cf-88bef80de1e4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0b77cad3-1770-4f8a-844e-1c562135351b", "AQAAAAEAACcQAAAAEM8s8QexhYYqwzyOKKGZIRcwAMxH00pvYnguhTYDsNVM1+NNXsC4zeJMCOEjCerc8g==", "94ae8bf2-c090-48b2-bb83-88ba519c77f5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6302d8f8-b7ca-4484-84ff-ebab93408e5b", "AQAAAAEAACcQAAAAEKKaF3p4vT5SVekqIWBufLdDMwg+thulGy3D5yUZgj2KtKYnjfDTSwjHb03V7U9juQ==", "996e8f9a-cf8f-485c-9238-424ee8e3d43f" });

            migrationBuilder.UpdateData(
                table: "Consultations",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateOfConsultation",
                value: new DateTime(2023, 11, 16, 20, 17, 12, 775, DateTimeKind.Local).AddTicks(776));

            migrationBuilder.UpdateData(
                table: "Consultations",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateOfConsultation",
                value: new DateTime(2023, 11, 16, 20, 17, 12, 775, DateTimeKind.Local).AddTicks(818));

            migrationBuilder.UpdateData(
                table: "Consultations",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateOfConsultation",
                value: new DateTime(2023, 11, 16, 20, 17, 12, 775, DateTimeKind.Local).AddTicks(822));

            migrationBuilder.UpdateData(
                table: "Consultations",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateOfConsultation",
                value: new DateTime(2023, 11, 16, 20, 17, 12, 775, DateTimeKind.Local).AddTicks(825));

            migrationBuilder.UpdateData(
                table: "Consultations",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateOfConsultation",
                value: new DateTime(2023, 11, 16, 20, 17, 12, 775, DateTimeKind.Local).AddTicks(829));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 2,
                column: "ClaimType",
                value: "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/nameidentifier");

            migrationBuilder.UpdateData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 151,
                column: "ClaimType",
                value: "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/nameidentifier");

            migrationBuilder.UpdateData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 152,
                column: "ClaimType",
                value: "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/nameidentifier");

            migrationBuilder.UpdateData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 153,
                column: "ClaimType",
                value: "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/nameidentifier");

            migrationBuilder.UpdateData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 154,
                column: "ClaimType",
                value: "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/nameidentifier");

            migrationBuilder.UpdateData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 155,
                column: "ClaimType",
                value: "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/nameidentifier");

            migrationBuilder.UpdateData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 156,
                column: "ClaimType",
                value: "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/nameidentifier");

            migrationBuilder.UpdateData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 157,
                column: "ClaimType",
                value: "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/nameidentifier");

            migrationBuilder.UpdateData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 158,
                column: "ClaimType",
                value: "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/nameidentifier");

            migrationBuilder.UpdateData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 159,
                column: "ClaimType",
                value: "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/nameidentifier");

            migrationBuilder.UpdateData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 160,
                column: "ClaimType",
                value: "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/nameidentifier");

            migrationBuilder.UpdateData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 251,
                column: "ClaimType",
                value: "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/nameidentifier");

            migrationBuilder.UpdateData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 252,
                column: "ClaimType",
                value: "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/nameidentifier");

            migrationBuilder.UpdateData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 253,
                column: "ClaimType",
                value: "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/nameidentifier");

            migrationBuilder.UpdateData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 254,
                column: "ClaimType",
                value: "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/nameidentifier");

            migrationBuilder.UpdateData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 255,
                column: "ClaimType",
                value: "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/nameidentifier");

            migrationBuilder.UpdateData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 351,
                column: "ClaimType",
                value: "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/nameidentifier");

            migrationBuilder.UpdateData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 352,
                column: "ClaimType",
                value: "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/nameidentifier");

            migrationBuilder.UpdateData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 353,
                column: "ClaimType",
                value: "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/nameidentifier");

            migrationBuilder.UpdateData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 1149,
                column: "ClaimType",
                value: "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/nameidentifier");

            migrationBuilder.UpdateData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 1249,
                column: "ClaimType",
                value: "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/nameidentifier");

            migrationBuilder.UpdateData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 1349,
                column: "ClaimType",
                value: "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/nameidentifier");

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
                keyValue: "19",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b397e91e-ac0d-4ee9-8b25-c5c2d35d017e", "AQAAAAEAACcQAAAAEMq9fiS/ahaK/gej1D7nM9XmCfnRulUfo8Uu/YdAvIOrf007dWFa13sIz7w9D4QBtQ==", "7dafd2d6-59f2-4c3c-bc90-b414e4aac661" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6dde3a50-aa5f-4e45-b769-3b41dcf17ab5", "AQAAAAEAACcQAAAAEK5/y0UoleHfeDZtbkXHXgtZ5UgrtAS4tE2akXDGlKg4PMw0f1rvrtf0BoXvLKOnBQ==", "85e3582f-a2da-4c3e-86ae-102c525ef3d5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "20",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "32af05c0-45c8-4f0d-bb4a-f02d4a175860", "AQAAAAEAACcQAAAAEPtenT0g4SipP6HCq4+i19lnXW9xMS+x/jZoNhJdVijX2hKf03EFzX3+vVTTTEFFfA==", "80769d96-2329-41c8-a50e-801f843936ee" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "21",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "30a3db67-a1ce-4aeb-83aa-33e88bf63bbe", "AQAAAAEAACcQAAAAEDn30kmxaGGs3XHlioTtvdgbClkRjZ7Uk/3bW99zDftvRoSE/9j6OiRrgkmf1Z3HTw==", "43db4501-125a-4566-8434-d96dfc527645" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "22",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9f4e9677-31dc-4a25-92dd-29d3f3e466a5", "AQAAAAEAACcQAAAAEJdmSf/SSDaYFzQGnhWF9qdjBbwyT1GkKTe58RJ2BCt+6sNguAGxDeK1hhX3/C0skQ==", "d0ef0022-e852-4c9a-b8bb-0a593eda24d6" });

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
        }
    }
}
