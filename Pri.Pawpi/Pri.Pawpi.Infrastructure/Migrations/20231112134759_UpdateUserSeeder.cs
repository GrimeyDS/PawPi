using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Pri.Pawpi.Infrastructure.Migrations
{
    public partial class UpdateUserSeeder : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "f87ebdd1-1893-4dc6-ad3f-452fc3661440");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "80f55f23-ef36-44c9-be0a-b78792fd1e3a");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3",
                column: "ConcurrencyStamp",
                value: "307335ba-7b0b-4d21-b66f-9bf2ef4dfb0c");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5bb3261a-7687-481b-9478-f27109e5cb7c", true, "AQAAAAEAACcQAAAAEOiL8S7jx7S//NAmUVSOt77/Xw6xhKmXrdEV73vAADy8SJHdrV4F20cexM7uI1ktrg==", "4c4990c2-5cfb-4ae8-9099-718cef1f3436" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f98d31f3-4694-49f3-bd20-4274aab2120e", true, "AQAAAAEAACcQAAAAEGfBxgaKKf436J159Ww46gSkr0beLLWo90kd42XfjGCzzyWxqdLMtZ5ah7MgFSGuPg==", "436f4901-9552-449e-b8f8-0db805842ac9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cb6b8e56-dded-48a7-a8c9-6bd1fdee2266", true, "AQAAAAEAACcQAAAAEKtvC0CumVIc0pLbSKaOkpM0B6il3Z/1nfar/qyg4ZhZU45ZVtYlQD2hvCLXNWLj4g==", "0ae942cb-1148-4ed0-9f51-9df2d72ca7cb" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "13",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "PasswordHash", "SecurityStamp" },
                values: new object[] { "79538af3-f2dc-432c-bfa0-70dd271b0dcf", true, "AQAAAAEAACcQAAAAEI+KPuplESclvZDBejBf2QNRR7CF/LHAc2d7NftstmPYZoI9u0pPVFAcorIguE2RoQ==", "703a3c07-6fe8-43cc-a0ab-af288bfe3959" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "14",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9ed37f9a-cbf6-45f0-b3a4-9bf8d3d618ce", true, "AQAAAAEAACcQAAAAEKgmi2jxltsIV8O1yu4KuMFxG3+afgwWtR371lunIQwWaPTb7q5LaEDJwJlMBfohSQ==", "a93beb34-4e50-4cd6-a9f3-16e2a3780034" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "15",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a7c1122a-03dc-4918-b00d-109ebb09ca94", true, "AQAAAAEAACcQAAAAEMVURlfWvQs6ch9DzdZpbFBBrjAQh9j8qDk8039ysQ7UsX2X+RjN2RaNrjL/1Xcbug==", "d4d0a17c-cfa4-4e80-aa67-1e58ccc49a66" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "16",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "PasswordHash", "SecurityStamp" },
                values: new object[] { "160f257c-e863-479f-be5b-c97300235029", true, "AQAAAAEAACcQAAAAEN/fzWjc4xCKvF9v1JOrezg19/2bziKKo0mwu0b0Sz9AhjiF0ASji0jVO94i7A+BAg==", "a82b56e2-7abc-4351-895a-1cebdf1864eb" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "17",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7681ae4e-dd8c-4b44-a108-fbf8e0b38775", true, "AQAAAAEAACcQAAAAECqByLxQ/9IRhj7DQcP4D9zfaAzdi7nLN7+VFEx90rf2qZcjrJ8EKIK/lvT+9sKyYw==", "a7ed9871-2b6a-40a7-8311-5f30aa44e4cc" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "18",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "PasswordHash", "SecurityStamp" },
                values: new object[] { "704e36a0-a896-47fe-8d3b-7588ef451559", true, "AQAAAAEAACcQAAAAEAL06y68sbzuOJdDKktgWVc4MyVmQSDnSLkGFpa6Hoi+2qQKW2hGoXIUfeIN9j+qfA==", "a214c259-806b-428d-aae4-3bc8b19996d9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "PasswordHash", "SecurityStamp" },
                values: new object[] { "00addd95-93b3-474d-bf14-31d3a3db6a5e", true, "AQAAAAEAACcQAAAAEGCY7DfoxbZcnJajiE94D6DVUhxkL3IJs5OuwRIBTWZUVy85AeJUEPxzKCaFY/p0uQ==", "48f8dc69-4639-4716-b626-bee2a23e7c69" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "PasswordHash", "SecurityStamp" },
                values: new object[] { "94c8112d-e3b5-474a-866a-8420b0289490", true, "AQAAAAEAACcQAAAAEDOOb3YsHtNTluH4EpIFLJlCFBTGbTBHPTQb2x2Tqr9r+Q93Fw8jS+tiMjBeBMIIbw==", "85314727-d116-423c-ae96-0d2fab4efc9d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "PasswordHash", "SecurityStamp" },
                values: new object[] { "88e45d2d-2fa2-42e8-bd85-c2fd55d0a76e", true, "AQAAAAEAACcQAAAAEEzYCdI1wIJM9a5Uy9fOR0oOo94bGKeMcqOqoaY739fQSY5mr0DmxuCZICrikBDKEQ==", "a55c24b9-8dc5-41d0-a047-2ac0aef2a147" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "PasswordHash", "SecurityStamp" },
                values: new object[] { "40c5ccd3-bdae-4729-b40d-32cb34ed8527", true, "AQAAAAEAACcQAAAAEHr26LNy2perEXXkulJadqJLhSyp1FRCHxzD3sPhNJBBdAPWiJ8W+vNVXPQZVBzB3Q==", "a14006d6-e469-4cf8-b7d4-eaf1584725b8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3032974e-3a65-4e85-aad3-b6ff7fc0558f", true, "AQAAAAEAACcQAAAAENMD7u8YICXnFe+bPnbDSYcT6rYCVzN33ZJGlwLHd7uWJO2vicm1FUD7AMjmxhRmsg==", "aa665c4e-3cb1-4994-854f-3918252ad31a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "PasswordHash", "SecurityStamp" },
                values: new object[] { "28bd81a6-4eb9-4ee0-a4bc-a59265d69edb", true, "AQAAAAEAACcQAAAAEJoFs9qJKz1kPtM8jPZj93EwkvtpGgi7VlyEDaHhj1y3ItNN5xrrGzfGCSzi4RRkSQ==", "3ce1ddf0-138e-48be-ac2e-c176eea38950" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "PasswordHash", "SecurityStamp" },
                values: new object[] { "603c723d-eebd-4769-b77d-7563e4fd4620", true, "AQAAAAEAACcQAAAAEMpuMlqXf6SpTbEGSzhf2JNhN8HYsaFU1wgEITTLMFehhQSCSFAPsAmJ9sBMNjgr5Q==", "169270cc-9d39-48f9-83d3-b3edf2160b5f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4640a0eb-9daf-4f95-8057-423ba647bb21", true, "AQAAAAEAACcQAAAAEMCi01SpK3/xChYg7SdRVgUAMhj0jYmzfeL7zcHn/TFYdZcimX2EmRESLF/lhFGvfQ==", "050af32d-4939-4413-af16-efb9e192c7d7" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "CustomerId", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName", "VeterinarianId" },
                values: new object[] { "1", 0, "00000000-0000-0000-0000-000000000000", null, "admin@pawpi.com", true, false, null, "ADMIN@PAWPI.COM", "ADMIN@PAWPI.COM", "AQAAAAEAACcQAAAAELmuHmauasVGn6wwo+GPtBYgCIDFVkffcKkomqwmWbMjArrspHm2qYwdS7Kh4SRm6g==", null, false, "00000000-0000-0000-0000-000000000000", false, "admin@pawpi.com", null });

            migrationBuilder.UpdateData(
                table: "Consultations",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateOfConsultation",
                value: new DateTime(2023, 11, 12, 14, 47, 59, 146, DateTimeKind.Local).AddTicks(9934));

            migrationBuilder.UpdateData(
                table: "Consultations",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateOfConsultation",
                value: new DateTime(2023, 11, 12, 14, 47, 59, 146, DateTimeKind.Local).AddTicks(9967));

            migrationBuilder.UpdateData(
                table: "Consultations",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateOfConsultation",
                value: new DateTime(2023, 11, 12, 14, 47, 59, 146, DateTimeKind.Local).AddTicks(9970));

            migrationBuilder.UpdateData(
                table: "Consultations",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateOfConsultation",
                value: new DateTime(2023, 11, 12, 14, 47, 59, 146, DateTimeKind.Local).AddTicks(9972));

            migrationBuilder.UpdateData(
                table: "Consultations",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateOfConsultation",
                value: new DateTime(2023, 11, 12, 14, 47, 59, 146, DateTimeKind.Local).AddTicks(9974));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1");

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
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7fe00ce1-4461-4120-9a45-5f8b01f90ae3", false, "AQAAAAEAACcQAAAAEJ+h6cFLBuSsMQBNKfZp2oO7DpVqds+SrDDvj13OK/zqBuCgNn2LW6OZfWI8pCIJ9Q==", "25372475-e913-434e-85f8-4e6caadcff8f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2e6ff49a-ef1e-45fc-b697-069e1ab17c90", false, "AQAAAAEAACcQAAAAECoTbZKlR0xworQph3kBvKJrH6+YJw9jiT/aaqEhXx32MQVY1TmLj0RX9tATGQRXHA==", "f6be527a-22a1-4e54-bf86-537bf9351e7f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "PasswordHash", "SecurityStamp" },
                values: new object[] { "354bb87c-fee9-4f12-bdb7-e46ffd1d6825", false, "AQAAAAEAACcQAAAAEK+7dQZn9E2bM3wxDL7s+QVksHWVB8HFmCihA70qeSLjul3burnJQcrzmNZi9239fQ==", "35490016-9555-42b1-9c5c-7946dedc2a3e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "13",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "PasswordHash", "SecurityStamp" },
                values: new object[] { "abf36c02-66dc-4fa0-9673-9c4271eda97c", false, "AQAAAAEAACcQAAAAELDUaZmL7u2pz+UTxgEX7X+KMM/gvELHVgfE633ZG73spKu3FmUeQ6mgmUt3gnvcjg==", "d45c8295-e179-4aa1-acb1-130189c34987" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "14",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3ac10070-9fa7-4764-b3be-457184f48beb", false, "AQAAAAEAACcQAAAAEPNYrP18vXsVtYxno86n6aEqt1tosD42Way4FC0gciJn92oC6aPpAPxfzkgDRpWLeQ==", "62d8c2df-e140-472f-96c6-ff092832e0a0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "15",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ad1bb5bb-cb67-448c-82c6-77d900c9651a", false, "AQAAAAEAACcQAAAAEF/TP+3kIuzrhnx/TrYIwM2TJIBr02jitBBEGqB/SAB3mdBfwdrnSXKmGW2s1jGBcg==", "9c411f3f-9aef-432b-a831-21e8ff2b28fe" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "16",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2a3e81ad-1e3c-46ff-8344-d4f6bf64cbbb", false, "AQAAAAEAACcQAAAAEHcPO3RX6RxcdgHes+v0FAfE0DiaqlEhbo+gxmB/v9Ljm2TN3Tf1gXWxKe6ZhQ/i+A==", "d229d3ac-97a1-4b95-acb0-3c4eff482307" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "17",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6b00bf9b-80e5-4bc5-a24d-9535a4812c59", false, "AQAAAAEAACcQAAAAEJj2S1XR748vVw5MI+EYiWzhR7E+g2L2ZXFQiIXniaQjow2zBk5ufDsiFHndmpW2JQ==", "300cb121-c7ab-44a7-bb17-8e38bf446d5b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "18",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f349c861-082a-42c1-9040-a250b8e3f365", false, "AQAAAAEAACcQAAAAEKF1AZFsnD1f65JTp91xVO9eUEbdunJJRKS1HgCgPim8gOC067DQGvJIIap0FdxW5A==", "db63cb60-bcb1-40ab-a216-7c302b0a0985" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "PasswordHash", "SecurityStamp" },
                values: new object[] { "67446fa0-d819-40d7-9a22-28aa8c077b28", false, "AQAAAAEAACcQAAAAEF2uVBxzKsKa89J88QdlVz77P/8zHbOoDa/yQPbFA0zaxRC2l0ugJG4HiBO5MCos1Q==", "8421000e-a02c-40ff-adf4-322516fb1448" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4df7556d-9e7e-43a7-bbd8-33c223cde13f", false, "AQAAAAEAACcQAAAAEMErF7Q20M2BWzmuv6PwS3oigA5ajK4Kesfwaw8cXR62WzgaS2tU0MhwLv290Utbkg==", "358576d4-8280-4416-96a6-9be81e684099" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "PasswordHash", "SecurityStamp" },
                values: new object[] { "29197ead-9bca-411e-9831-9c011e312c6b", false, "AQAAAAEAACcQAAAAEP97mx9GqjQ2G5NfWIin4J6sYFQpM4YXK200KcBDDZFIR/i54EelhomgyuXhusK/gQ==", "cee6ef0a-5bf7-4831-97ac-2fcced11e7cc" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0936ffee-e183-4897-b6c1-692374e07988", false, "AQAAAAEAACcQAAAAEC4OQ46raRPAcn6a8QqCpq+lYDNZTFQfYDrn2rSJ5R9k2mxBwwqjUfINp8UtDgCvXg==", "969d0dc2-1b48-407f-a938-318ebe81cf9b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "PasswordHash", "SecurityStamp" },
                values: new object[] { "14516b88-4aee-4a2e-97cb-9ee06820476d", false, "AQAAAAEAACcQAAAAEE1FiN9yUdndxnlEqBxdGASjooWzbYIw4WotsQZkvUOel9X1Ln2aT8z9/QeEcVSAWg==", "b5eed595-8c2f-4217-8e55-c68805eafe52" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "PasswordHash", "SecurityStamp" },
                values: new object[] { "69dab1d8-f50c-42e5-9bfe-6322a8e72e55", false, "AQAAAAEAACcQAAAAENhMwtuh+1yjpXIYetMsN1DW2FjLAXXb8aAvvpFpREslalR6vB8zUSc1gAkgpCFlVA==", "1b5669a7-d96c-490e-b168-52f078d53559" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8ed2b12a-a194-463b-bd21-1b13180fd9d4", false, "AQAAAAEAACcQAAAAEAW1xInSDK5e0U7i+9OSmHtbXp6R/URqpyfwvRsjSvjoF/p3mpH78IsPSXa1eT6ZDg==", "f8e2c894-920c-4573-a5a4-4b2c2cf488f3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "PasswordHash", "SecurityStamp" },
                values: new object[] { "037967ba-58ab-4539-8c4f-42af2acc1d87", false, "AQAAAAEAACcQAAAAEHzvlK1ejSoUPZetlZ8fNzLaDY+KkaXBv34cEKxZnSBVSbsG5arFZvFnMG1RCWpAUQ==", "01a2a390-f69a-4da6-b871-1ae8fc69fa4f" });

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
        }
    }
}
