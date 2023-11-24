using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Pri.Pawpi.Infrastructure.Migrations
{
    public partial class AddRolesToTestUsers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "b3436c15-8469-4032-a622-adaf76bfb5ef");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "97b7b8d4-fbfc-4ef7-aa13-afc468c06c51");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3",
                column: "ConcurrencyStamp",
                value: "91f8a34f-bc2f-4b0f-865b-0724c15c2750");

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "3", "12" },
                    { "2", "18" }
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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "3", "12" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2", "18" });

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
                keyValue: "1",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAELmuHmauasVGn6wwo+GPtBYgCIDFVkffcKkomqwmWbMjArrspHm2qYwdS7Kh4SRm6g==");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5bb3261a-7687-481b-9478-f27109e5cb7c", "AQAAAAEAACcQAAAAEOiL8S7jx7S//NAmUVSOt77/Xw6xhKmXrdEV73vAADy8SJHdrV4F20cexM7uI1ktrg==", "4c4990c2-5cfb-4ae8-9099-718cef1f3436" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f98d31f3-4694-49f3-bd20-4274aab2120e", "AQAAAAEAACcQAAAAEGfBxgaKKf436J159Ww46gSkr0beLLWo90kd42XfjGCzzyWxqdLMtZ5ah7MgFSGuPg==", "436f4901-9552-449e-b8f8-0db805842ac9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cb6b8e56-dded-48a7-a8c9-6bd1fdee2266", "AQAAAAEAACcQAAAAEKtvC0CumVIc0pLbSKaOkpM0B6il3Z/1nfar/qyg4ZhZU45ZVtYlQD2hvCLXNWLj4g==", "0ae942cb-1148-4ed0-9f51-9df2d72ca7cb" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "13",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "79538af3-f2dc-432c-bfa0-70dd271b0dcf", "AQAAAAEAACcQAAAAEI+KPuplESclvZDBejBf2QNRR7CF/LHAc2d7NftstmPYZoI9u0pPVFAcorIguE2RoQ==", "703a3c07-6fe8-43cc-a0ab-af288bfe3959" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "14",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9ed37f9a-cbf6-45f0-b3a4-9bf8d3d618ce", "AQAAAAEAACcQAAAAEKgmi2jxltsIV8O1yu4KuMFxG3+afgwWtR371lunIQwWaPTb7q5LaEDJwJlMBfohSQ==", "a93beb34-4e50-4cd6-a9f3-16e2a3780034" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "15",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a7c1122a-03dc-4918-b00d-109ebb09ca94", "AQAAAAEAACcQAAAAEMVURlfWvQs6ch9DzdZpbFBBrjAQh9j8qDk8039ysQ7UsX2X+RjN2RaNrjL/1Xcbug==", "d4d0a17c-cfa4-4e80-aa67-1e58ccc49a66" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "16",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "160f257c-e863-479f-be5b-c97300235029", "AQAAAAEAACcQAAAAEN/fzWjc4xCKvF9v1JOrezg19/2bziKKo0mwu0b0Sz9AhjiF0ASji0jVO94i7A+BAg==", "a82b56e2-7abc-4351-895a-1cebdf1864eb" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "17",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7681ae4e-dd8c-4b44-a108-fbf8e0b38775", "AQAAAAEAACcQAAAAECqByLxQ/9IRhj7DQcP4D9zfaAzdi7nLN7+VFEx90rf2qZcjrJ8EKIK/lvT+9sKyYw==", "a7ed9871-2b6a-40a7-8311-5f30aa44e4cc" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "18",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "704e36a0-a896-47fe-8d3b-7588ef451559", "AQAAAAEAACcQAAAAEAL06y68sbzuOJdDKktgWVc4MyVmQSDnSLkGFpa6Hoi+2qQKW2hGoXIUfeIN9j+qfA==", "a214c259-806b-428d-aae4-3bc8b19996d9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "00addd95-93b3-474d-bf14-31d3a3db6a5e", "AQAAAAEAACcQAAAAEGCY7DfoxbZcnJajiE94D6DVUhxkL3IJs5OuwRIBTWZUVy85AeJUEPxzKCaFY/p0uQ==", "48f8dc69-4639-4716-b626-bee2a23e7c69" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "94c8112d-e3b5-474a-866a-8420b0289490", "AQAAAAEAACcQAAAAEDOOb3YsHtNTluH4EpIFLJlCFBTGbTBHPTQb2x2Tqr9r+Q93Fw8jS+tiMjBeBMIIbw==", "85314727-d116-423c-ae96-0d2fab4efc9d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "88e45d2d-2fa2-42e8-bd85-c2fd55d0a76e", "AQAAAAEAACcQAAAAEEzYCdI1wIJM9a5Uy9fOR0oOo94bGKeMcqOqoaY739fQSY5mr0DmxuCZICrikBDKEQ==", "a55c24b9-8dc5-41d0-a047-2ac0aef2a147" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "40c5ccd3-bdae-4729-b40d-32cb34ed8527", "AQAAAAEAACcQAAAAEHr26LNy2perEXXkulJadqJLhSyp1FRCHxzD3sPhNJBBdAPWiJ8W+vNVXPQZVBzB3Q==", "a14006d6-e469-4cf8-b7d4-eaf1584725b8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3032974e-3a65-4e85-aad3-b6ff7fc0558f", "AQAAAAEAACcQAAAAENMD7u8YICXnFe+bPnbDSYcT6rYCVzN33ZJGlwLHd7uWJO2vicm1FUD7AMjmxhRmsg==", "aa665c4e-3cb1-4994-854f-3918252ad31a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "28bd81a6-4eb9-4ee0-a4bc-a59265d69edb", "AQAAAAEAACcQAAAAEJoFs9qJKz1kPtM8jPZj93EwkvtpGgi7VlyEDaHhj1y3ItNN5xrrGzfGCSzi4RRkSQ==", "3ce1ddf0-138e-48be-ac2e-c176eea38950" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "603c723d-eebd-4769-b77d-7563e4fd4620", "AQAAAAEAACcQAAAAEMpuMlqXf6SpTbEGSzhf2JNhN8HYsaFU1wgEITTLMFehhQSCSFAPsAmJ9sBMNjgr5Q==", "169270cc-9d39-48f9-83d3-b3edf2160b5f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4640a0eb-9daf-4f95-8057-423ba647bb21", "AQAAAAEAACcQAAAAEMCi01SpK3/xChYg7SdRVgUAMhj0jYmzfeL7zcHn/TFYdZcimX2EmRESLF/lhFGvfQ==", "050af32d-4939-4413-af16-efb9e192c7d7" });

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
    }
}
