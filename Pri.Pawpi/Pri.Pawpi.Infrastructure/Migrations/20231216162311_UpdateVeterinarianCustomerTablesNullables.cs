using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Pri.Pawpi.Infrastructure.Migrations
{
    public partial class UpdateVeterinarianCustomerTablesNullables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Postal",
                table: "Veterinarians",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "Phone",
                table: "Veterinarians",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "City",
                table: "Veterinarians",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "Address",
                table: "Veterinarians",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "Postal",
                table: "Customers",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "Phone",
                table: "Customers",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "City",
                table: "Customers",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "Address",
                table: "Customers",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEJXZXxrojrtBg53DPMhdsj4UemIVizCJY9HY4ACi8fVP6PU4f4kOfweNS0YYmGCn+g==");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b9c55251-5c62-4eec-ba72-13672ecf6adb", "AQAAAAEAACcQAAAAELwRFduIi5sGDGmGNMwX3KLki26zqNKNZTPX7dyvR0Syk6gDWy6lYNC1AbeXc6vW5g==", "1232e4cb-a5d5-4d03-999d-0675678db93a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5aa41505-a4cf-4172-9e1e-e446fbc8ae74", "AQAAAAEAACcQAAAAEATQicdDWP6ui0mmgAeLcN5TbSrPo3KAPr+9jpg8bMYMg05JUCCifxpn6Kx6pUVY/g==", "78c302b5-8fa0-4492-80b6-7da03a112957" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8f8a44a0-0160-44d8-996a-c3053ff1ccb6", "AQAAAAEAACcQAAAAEIqtiyfGkOo6BgWqJtV0sAMflXXNDSiiXeU0naNiLxxYyRwpxVmnM38iGHfKqEm92w==", "45d38a81-f70d-463d-9427-a4e4377ec52c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "13",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a47b7c85-593b-4d1c-9e26-9535f3d13192", "AQAAAAEAACcQAAAAEFlBhEBZxvz9XfuiAUmSE0StZ0RVMBhdoAgJtWBxN/D5XeLVtQ+mQ8UftUK1G3ezUQ==", "0e44e833-c2db-4764-bd65-9a62c7020468" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "14",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "678e048d-7453-497b-b034-7e6c8d63a96b", "AQAAAAEAACcQAAAAEEEU9DZZvgyz/c3u60IvrmxaNukzitKNZaohnHK39yZwGS0zfaOz/jqls1aAF4ideA==", "615d2ca3-450d-4161-813c-51993b4d6c26" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "15",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4044ceb3-8c96-4d5e-b87f-283a350d17f5", "AQAAAAEAACcQAAAAEBAY7FAqV/pqKUreFcZkKfq6cDGpO4JEURt+zaACNqXb726ZXH5kuWHn6FBuZcPRSw==", "6235dbf6-d23f-412d-bca2-df7fd30928d5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "16",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4fb8c572-9aa2-42f0-ab47-911800e82be6", "AQAAAAEAACcQAAAAEGLtgmQZ+cEtEMqTgEx5ZOSEETmD8S8M6oTmWSHiZ50XMSiM7I49e/UtahqXFfmtdQ==", "a5c591cc-a55b-4501-a7da-88aaa1cd686e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "17",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "330b72a7-4f04-4b72-89a0-66d5b3240103", "AQAAAAEAACcQAAAAEA8bBnEIYQ2aNrLjIeJFphR3H0W7GQqix1LSrAFLGbSk4GSPDp1hy60vExtC98aqCg==", "081e3d50-722b-4a49-b836-e7c8fb00f9c0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "18",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b04f353c-3429-4e6a-b4b4-efa88a001689", "AQAAAAEAACcQAAAAEGgEmWEajo74rbx5M8gR7MnlVoHPFv53f+/yUFXXkuxkfHEHDMPnNnQSxN52pWA8Xw==", "ad71ca0f-8bd0-4524-b090-323ec2cb5d78" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "19",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3ec3e1a3-9772-4fac-bc25-bbfae58ad588", "AQAAAAEAACcQAAAAEPLxSSJ9VQCv3qJCfrqKYbY8mWFoK3+3Y1ktOhm6FLR7E42OJRZvwih/McqpZ3ZQBw==", "c3be3b19-29e0-4676-9351-0200b6c1c815" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "dec15c9e-ca4d-43e3-b6cf-6d43321eb184", "AQAAAAEAACcQAAAAEKuoL8iFIxW1VqWYmjPwzGnBGYTCXq4cqPPoel/Y5jVUWG1ySHRlTzyGYHICjFSmiA==", "659c19d6-4285-4de1-8127-f612cafde3e7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "20",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "25be0740-9de2-4794-b1b7-64b6de27e391", "AQAAAAEAACcQAAAAEOochwnhs3LNJbp0q34+MGZ2u1QoG6+G+8z0MkEEHOFj/Gz78NfuS/b9XiejsTgrsg==", "170d087a-6a61-4f6f-a5d4-e9b506e5362e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "21",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "86b189a3-20d4-4d6e-ae9f-84bb0e8cd6c6", "AQAAAAEAACcQAAAAEKVvwo3979O/IRRM77D+e47yKaLN9PlibvlOQAVxRdILoV42R0U5ggRQYTVfFAIUQQ==", "f5e84d92-3c97-4a41-afc6-d2501b92f4e2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "22",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d9efb0d7-9163-419d-8061-a2906333e36c", "AQAAAAEAACcQAAAAEL10hOFxT7a1DTbqi5l3tp0uzddHpeYjB2D/W78WhDlk0BgLICFoxIbE9INQnNiN1g==", "7baebd9c-94df-4167-a85b-d7deccd9378d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bfc4ff82-af3f-409c-9a2e-fbaf08c62c87", "AQAAAAEAACcQAAAAEBVBUPLM1A7VAhF6twSZ9qt5wtP00C/3955lPSg3gGja/q42Y4VGYj1EL7SJ83zkrA==", "f2a5c689-7907-412d-a4b8-168ecb0fd4d2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7f4da621-71f6-4bcf-a3cc-db4685711a64", "AQAAAAEAACcQAAAAEEOWPoMJm8FSaU6vG13onoBu82b6WXMWcTpAm12suri5ABeuYsTFN+fGb+5Z/zHv+w==", "26688887-41f0-47f0-afa1-8973ba5b07f3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3f2428ad-eaf7-402a-a4c1-581ba81c5fc6", "AQAAAAEAACcQAAAAEHPJ+GD2aI/z2m5s9Bqh4AyS3h22c+jvh+aevJQSY3x0P5BeWH8WoNM7TLojcKKpqA==", "bb65fea3-9e54-4dd3-9a9b-bb133c5c80f4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "54e592e6-fc68-4136-89bf-811e7d3e2389", "AQAAAAEAACcQAAAAEPrGiyuXv3KhEjmgNwpeHZyUEuDyGOssGxIuWvDuWJ5ref6VY1e8ikKQZsg+/XVmlQ==", "2c57fa67-9760-4418-ab0d-a72256fa00a6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0d5f6a6c-03c3-4d79-bec3-d82ddd0cba9f", "AQAAAAEAACcQAAAAEOYUa58dGkrZssLyAeUT1hT5WkQganxOYGmrUBdS3+xElwZcRQAKkGYnihQF2xHKNQ==", "46577f5d-73df-4099-89a3-3e04808d78e5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0399d7d4-8f58-486b-b081-29acc95c6a7c", "AQAAAAEAACcQAAAAELWXCIq0JoAj5zyl3pfb0wuKGLPQ1wnqRt1kCw34G/7lu3OaMUkJLjzEtiMv2cwBKA==", "05a41cee-f882-46a4-a78f-8ced7b086a53" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cb553658-d484-4b5c-9e40-5a8959935ccf", "AQAAAAEAACcQAAAAECQC0WKdC8wfpRCMSyI/5XpUUxoeCfQ89fJk03CRBCTS5171kt986/KlAHTUn5M6gg==", "07003070-d6af-43b2-9221-63f992f7914e" });

            migrationBuilder.UpdateData(
                table: "Consultations",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateOfConsultation",
                value: new DateTime(2023, 12, 16, 17, 23, 10, 714, DateTimeKind.Local).AddTicks(4570));

            migrationBuilder.UpdateData(
                table: "Consultations",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateOfConsultation",
                value: new DateTime(2023, 12, 16, 17, 23, 10, 714, DateTimeKind.Local).AddTicks(4601));

            migrationBuilder.UpdateData(
                table: "Consultations",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateOfConsultation",
                value: new DateTime(2023, 12, 16, 17, 23, 10, 714, DateTimeKind.Local).AddTicks(4604));

            migrationBuilder.UpdateData(
                table: "Consultations",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateOfConsultation",
                value: new DateTime(2023, 12, 16, 17, 23, 10, 714, DateTimeKind.Local).AddTicks(4606));

            migrationBuilder.UpdateData(
                table: "Consultations",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateOfConsultation",
                value: new DateTime(2023, 12, 16, 17, 23, 10, 714, DateTimeKind.Local).AddTicks(4608));

            migrationBuilder.UpdateData(
                table: "Consultations",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateOfConsultation",
                value: new DateTime(2023, 12, 16, 17, 23, 10, 714, DateTimeKind.Local).AddTicks(4609));

            migrationBuilder.UpdateData(
                table: "Consultations",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateOfConsultation",
                value: new DateTime(2023, 12, 16, 17, 23, 10, 714, DateTimeKind.Local).AddTicks(4647));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Postal",
                table: "Veterinarians",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Phone",
                table: "Veterinarians",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "City",
                table: "Veterinarians",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Address",
                table: "Veterinarians",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Postal",
                table: "Customers",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Phone",
                table: "Customers",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "City",
                table: "Customers",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Address",
                table: "Customers",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100,
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEDupmpRB9Frrs/eLbtXx85EtombQ97nPxhWJj0qjZ9v+xNcyhhglrX5wCxvQq8kC2Q==");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6ff7aaa4-02fb-410d-a591-0c0264419826", "AQAAAAEAACcQAAAAEAGu7ttTyk6Lpe9Uy/m04Cx0LDWDYLZUxQDCqi9FaNHlOOf8bibWLeKfz7H0fnghgA==", "c1fb7f0e-5b4a-4ad5-b18a-f5c2ecb0e905" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "43ad360a-1ecc-4d34-9b81-7e2fd44fc2bb", "AQAAAAEAACcQAAAAENmuw3AjKcThw43NBdqdgU8RxuHfSbBa90Ca0oLxrISOde0NPhMhN7lnKL+iAnfrSw==", "db00867a-47bf-4a7a-9218-3f89dda9cd43" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e0710864-9d0a-4a10-85e0-0d20b935f250", "AQAAAAEAACcQAAAAEJaKwmXfe0iXGmrPpo2RE/BaQxJw66EElW046AHlo3HUoymWu5+SysNzbxv3DoOFxg==", "738120eb-ac5d-476f-983a-598e4391b51a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "13",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9b8f1b51-eda0-45fa-a763-0d5487bfae0a", "AQAAAAEAACcQAAAAEItTTLX+OHeqJtLQzxyUEwKQSDnKNIlTYPd9zxyPDN+qoIfMXkC8Jc7uEZzpCQMzCA==", "fbc1d4a6-1e28-45fe-bfd8-93dc2c8558ab" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "14",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1c152115-82aa-4d9e-a46e-120e50679a1e", "AQAAAAEAACcQAAAAEN+QXQDjMSjHCAx9pbZ+FyZggY7NG/sxBRLO9FntiSLCIZnniYcBs7UMNFN1mO/Jhg==", "42de60ce-f8bd-4e64-b375-92e1094dad44" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "15",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "38cda3e6-6870-451f-ae4f-fee4da11b4a9", "AQAAAAEAACcQAAAAEO0h0sgN4Kz200SvwKHNnbKNP7cJNStAiiqBZGHQxujHEF+CP+dxHoKmpNaq8h94SQ==", "cb7132d8-3167-4eb2-acf0-a2add373d0ee" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "16",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "23a1cef1-abde-4394-baf8-279ae448840b", "AQAAAAEAACcQAAAAEPMvL1k744cWrJZGiP2ICJKNohCB+ugou9K1ZnPb9uxBgoKcVYdBUKi7DPDm4bmVQQ==", "6683f75d-f4ac-4f98-be30-a15c9a8af159" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "17",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0fcc8846-f458-4b5e-a844-04f96d9d09cd", "AQAAAAEAACcQAAAAELhKfvPubvILXj3DOv9DvqOmbQy5WQycVzCWfIz9ZImzlOkeYSE4GRfngLaIyJBK6w==", "1f2f478a-e7f7-4157-9e86-fb7eadecebd4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "18",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4d8ace6d-43ed-4dc2-8d58-c82bb3d59303", "AQAAAAEAACcQAAAAEM6Af5HgsE2T+T3tfw8MZzJ6fU9Eb03XT66tDfLzfJnIRsydj9+K/K3r8LSF1/e2OQ==", "3d505beb-c199-4cd8-bb3f-c67ef30eec97" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "19",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9ebf6579-3c1b-40a2-8a57-111cbc4107dc", "AQAAAAEAACcQAAAAEMyMGhTDE8AsqDXzjlJ53BgwSMdpv1IjI9m+OapeHX9EEi/OZkfogl2OwFAt3FSTAQ==", "1bbf6bb6-fea0-4289-968b-19b38e759894" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9a998510-19c8-4fad-9df8-82de31807f07", "AQAAAAEAACcQAAAAEKUD6lDoCqW3sESbve6ia2jLxb9PNNcnkE22uW5G5mATIRPvfGpUNEeuFMHCdmfMUQ==", "fd1f7ad7-3538-4130-9da4-1d23c840c483" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "20",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7e847f82-1238-4aae-83d1-8ce4e23b0328", "AQAAAAEAACcQAAAAEHD5RAyxPRiLYuiYvqUWhZfK3CUHi3Ft8+/2vEZj31u97FlD9Jf3LlFejIlFOUaDQw==", "2a5ca34f-ed7b-4748-9fbc-d362a5503d1d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "21",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "39e31687-d321-4b77-afd3-2b559699a9ea", "AQAAAAEAACcQAAAAEEab8TTQU6uZhCbmkZPJoqR/HZGNx1W5wNFpDWtm3kZ9Pu864iANW+gkzFuFat0B5g==", "ab2cc624-8d9a-466c-8136-6724c4739aba" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "22",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0d762747-a847-4a34-b675-73477c220c97", "AQAAAAEAACcQAAAAEMZYN6ZoMPPnOn+fgX+2RSEw5QsirkwCfqKoycgw8XM5nQTq5/ksBWOf0gaEdG4d3A==", "1584f937-f94a-4558-8dc6-558897e45e2a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a6c31375-553c-4ab6-bedc-0a7927a47077", "AQAAAAEAACcQAAAAEIsHVYqHKwoTVo6L6vChVpzBmsCRMKlv+xQjHswFqJn+NEKtj34YckrmCkbtwY8CQQ==", "bb801377-862e-4c6c-8e6c-e8e47a4ea1a5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0b4ea63c-e1d8-4a93-9b6a-3fe049b61bc3", "AQAAAAEAACcQAAAAEEa8bh8Yi7/khnmNRKyoS1yG258PdGjaCML99EQQtrCic7L6tiOwsnHIhEX39SXxvA==", "b3eaa209-8b81-42d8-9fbf-899a75f0eed5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "057c1c86-e36f-458a-a4a9-3b71b1e7a097", "AQAAAAEAACcQAAAAEOAaemRsshjdHLZy6OPXXx2i5Vu9TU06VfJYigZjUOBL47VM7Q9oPYW0JH7aY0wWyw==", "4c343582-24af-4b61-ae4c-b4e746b8ca80" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b6217902-87c6-459a-86fc-b8821e4014f5", "AQAAAAEAACcQAAAAEDeWVpPmsMfix6C0kyNIWz0cebo76PbqkBJcmcb5p4lsW64c3XsNhhphGnCYuRBhzw==", "de364f40-881c-4a22-8899-72c05f432351" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3a9aac5a-fcff-46a2-8442-4619e676754b", "AQAAAAEAACcQAAAAEEHugV/RqXcZEF5uhxXZpb+qw7irH4agfebE2uH9uKKU5uDtEGS3G9/SL2PXTsFTOg==", "eb11c719-bce9-4168-92e4-bd60ac34044b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8cbb993a-cf52-4b0c-9fd9-dc16ece5dda8", "AQAAAAEAACcQAAAAEFm2EUbu0Ru0gVp9Hax0VfyTAb92EOkvIi4J8MJtG3eEQwUTyFi8OLTXcgjuAp9maA==", "5c881de9-adf4-44f2-a4a0-d95b253a7bcc" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0c01eaf1-a223-4599-b471-22f5067ab696", "AQAAAAEAACcQAAAAEFQrCPzanqeQo7wK6C6jXuile4PxcbBNJzNQZGeMNCJ5XrWqTm3NMi1omvDamE0/ZQ==", "84114b1a-7c80-4908-a132-4e6a7e1c808b" });

            migrationBuilder.UpdateData(
                table: "Consultations",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateOfConsultation",
                value: new DateTime(2023, 12, 8, 17, 37, 20, 326, DateTimeKind.Local).AddTicks(7482));

            migrationBuilder.UpdateData(
                table: "Consultations",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateOfConsultation",
                value: new DateTime(2023, 12, 8, 17, 37, 20, 326, DateTimeKind.Local).AddTicks(7518));

            migrationBuilder.UpdateData(
                table: "Consultations",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateOfConsultation",
                value: new DateTime(2023, 12, 8, 17, 37, 20, 326, DateTimeKind.Local).AddTicks(7520));

            migrationBuilder.UpdateData(
                table: "Consultations",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateOfConsultation",
                value: new DateTime(2023, 12, 8, 17, 37, 20, 326, DateTimeKind.Local).AddTicks(7522));

            migrationBuilder.UpdateData(
                table: "Consultations",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateOfConsultation",
                value: new DateTime(2023, 12, 8, 17, 37, 20, 326, DateTimeKind.Local).AddTicks(7524));

            migrationBuilder.UpdateData(
                table: "Consultations",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateOfConsultation",
                value: new DateTime(2023, 12, 8, 17, 37, 20, 326, DateTimeKind.Local).AddTicks(7526));

            migrationBuilder.UpdateData(
                table: "Consultations",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateOfConsultation",
                value: new DateTime(2023, 12, 8, 17, 37, 20, 326, DateTimeKind.Local).AddTicks(7528));
        }
    }
}
