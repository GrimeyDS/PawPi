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
                value: "310c6210-e78e-4298-9bc2-2eeda8eecc7f");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "1213db75-aaeb-46e4-bb6b-1c05f149cfd8");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3",
                column: "ConcurrencyStamp",
                value: "ce186cc5-6768-4bad-9afb-9222d28645a5");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5e764158-65ef-4fc2-a979-4ce2c9af3e50", true, "AQAAAAEAACcQAAAAEBCgahMmir5IZoNu0yELKxOxOVzlbutwLzqGPUeVVuy0bZnYjeAwZfeKquBf3SySag==", "ee715df3-3184-4a90-8887-3ab75b786c9d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "PasswordHash", "SecurityStamp" },
                values: new object[] { "675e105d-868c-40d9-aca7-9ce66160e435", true, "AQAAAAEAACcQAAAAEC0SODlSodwGFwU69TMwsS+mdaunZsH7GuEmg+t2iqujmf5oyWUyGsKa5iyOn5l7nQ==", "965d97e4-df37-4722-ac97-159a1e991b01" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f58a6116-f685-469a-b10d-b0c2ba21949b", true, "AQAAAAEAACcQAAAAEM4Rt/W2KwiVhat/VdKWtqoywqs17VIMwI3Fn29Wbdj+dJZiVv6Tb2yl1zE2pb0WHQ==", "2e1aac0b-783a-47e1-ab43-0de78e58ffb8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "13",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "PasswordHash", "SecurityStamp" },
                values: new object[] { "69a6e5f9-c7bb-452a-90f7-07a9f888297e", true, "AQAAAAEAACcQAAAAEI53oAaBGkEqwJxNF4DSzkEL1iqinyyaJNTAmgbcsHSL2VY2DmBHXfBG9v+iHTRVIQ==", "a223c01f-edac-43e5-a5a4-9fa4cdbac106" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "14",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7b5c136c-a9bb-4165-96f4-2638ac910dcc", true, "AQAAAAEAACcQAAAAEDeHmpIrfH2vHIgSc3DNyC9LslepDW/O0/4aJso2l02SaYQOPBZbmAJZuJmB+QCC+g==", "6a95f2dd-eecd-4a22-89c1-b64ec7294d84" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "15",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2cb55483-47cb-486d-bdf2-0e63681d77c7", true, "AQAAAAEAACcQAAAAEGVVoSmropNcq8Vd9eU8cugnxU7WFY5XnpXiZKtFfOJbwjmIChKbeIZ2gTqjC7UPfg==", "d322f2b2-3a46-4dee-b980-97c005fc4b85" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "16",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ceea30b1-1d46-4f29-87f6-c534f7711bf7", true, "AQAAAAEAACcQAAAAEPISjFOojyBIsFh28/M3UUBlAmSSdFmz6ZYZjGKVihbv7XER3U6B5hcLkdYn3xSmqQ==", "3c0e5649-9989-4631-9beb-9f123b730efb" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "17",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "PasswordHash", "SecurityStamp" },
                values: new object[] { "11c94a9e-7cd7-4a73-ad2c-46c176a8119c", true, "AQAAAAEAACcQAAAAEEwBBAE0lqJQfyuSe5m0tEVXERvQ+BPEhjN6dda8aJQHBjOYJHxbLPaTK29T6sVwVA==", "816e1945-8389-40fe-a49b-3247a068e1a2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "18",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8804bbba-041f-4cab-8473-27f89c946178", true, "AQAAAAEAACcQAAAAELj2t/eZHk8TBYwkttYN4vJmNb7AZnJdY7Tz5Q4fV5NP6iQrYwa32oZOSOiaqb+bnQ==", "71cddbd5-3210-4d0e-b7d5-da392caab5c0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "PasswordHash", "SecurityStamp" },
                values: new object[] { "18aa3b73-6361-453f-8be0-eb3ee7b4f52f", true, "AQAAAAEAACcQAAAAEMkrY0pjoVrM9gRRPDkXLD9PVmfVS+yS7uYnAMYaub2ehSKvYC+2nDlnuwxeX7kf1Q==", "8196ab42-9be0-4ce4-ae6f-d5ab8be02326" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1fc5cbc6-94e9-4649-baf4-4a31cecc8319", true, "AQAAAAEAACcQAAAAEHMljicxTOywpYYw8fGxL1hYy6UY8UtvNSfIYnS5uMWRN4hm3b8xN3S+lS3lFZ7D7Q==", "b2a2c691-dbf3-477b-9933-c9f75ec4a000" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2597a56c-7354-476c-83dd-972d40287989", true, "AQAAAAEAACcQAAAAEKZOtxXlajIvKtabBso9UOcx6s2+X+XDPyI265O16JIy402i/p1CulJpJbT5319smA==", "35055645-53cb-4b49-b494-9c8dc5b34de4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "PasswordHash", "SecurityStamp" },
                values: new object[] { "94448a47-7731-4c09-bb20-82332903ca56", true, "AQAAAAEAACcQAAAAEMApDlb/9zOmRx4k8aNrl56rpzciGU1DS0bR+g1ssLqm9DViFoA0/M9Efx7WPGBFqg==", "2f9eac45-c2c9-4e5a-82b4-5ecd4c6bf59b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a1c6f025-1407-43e1-8617-ac66bd00646a", true, "AQAAAAEAACcQAAAAED4Jv1s2e7wJNj0Q9hSpjW9Ai53uMdO5tIqJumpaOJ9LUbTdj2pk6MahsCdBgHlEzw==", "98ce17a0-91d6-4571-a9de-726759484b09" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5799fcf9-73d4-4984-91d4-55d334c8723e", true, "AQAAAAEAACcQAAAAEGekDwAYjcG18xpq931vxStwBx/XIer8qp6j7BauW410vQBx10mjiVEUSjfUcY6OIA==", "249e798b-ee33-4621-a027-90c5a3a5c562" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b32212d1-596d-4b01-9c74-dee975551168", true, "AQAAAAEAACcQAAAAEH699RGIaSIYNnLCviExxSD8XBrHsQ7Yku5GqLtBtAaISQtIIpSbbJLMjV8B9KHk8w==", "182960d0-0f81-4f6b-b410-d36f3530739e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "PasswordHash", "SecurityStamp" },
                values: new object[] { "866ee216-b523-4c11-90fd-de81d6fe6e08", true, "AQAAAAEAACcQAAAAEBErgoWvxIXQQfeNbknHJpDSLLhyvz+3tMF2AUOH9K+ZbLMR7RLUd+uskkd3X1iuyg==", "c6485c20-67ef-452e-80ff-ed71d0fac10b" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "CustomerId", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName", "VeterinarianId" },
                values: new object[] { "1", 0, "00000000-0000-0000-0000-000000000000", null, "admin@pawpi.com", true, false, null, "ADMIN@PAWPI.COM", "ADMIN@PAWPI.COM", "AQAAAAEAACcQAAAAEM68iFeSOCZgtA24ecbGFpZQUnRnGc78+MiqY8+Yidv1ybAgmGd8H1J4R9nCrYvouw==", null, false, "00000000-0000-0000-0000-000000000000", false, "admin@pawpi.com", null });

            migrationBuilder.UpdateData(
                table: "Consultations",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateOfConsultation",
                value: new DateTime(2023, 11, 12, 14, 43, 50, 763, DateTimeKind.Local).AddTicks(2910));

            migrationBuilder.UpdateData(
                table: "Consultations",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateOfConsultation",
                value: new DateTime(2023, 11, 12, 14, 43, 50, 763, DateTimeKind.Local).AddTicks(2943));

            migrationBuilder.UpdateData(
                table: "Consultations",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateOfConsultation",
                value: new DateTime(2023, 11, 12, 14, 43, 50, 763, DateTimeKind.Local).AddTicks(2946));

            migrationBuilder.UpdateData(
                table: "Consultations",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateOfConsultation",
                value: new DateTime(2023, 11, 12, 14, 43, 50, 763, DateTimeKind.Local).AddTicks(2949));

            migrationBuilder.UpdateData(
                table: "Consultations",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateOfConsultation",
                value: new DateTime(2023, 11, 12, 14, 43, 50, 763, DateTimeKind.Local).AddTicks(2951));
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
