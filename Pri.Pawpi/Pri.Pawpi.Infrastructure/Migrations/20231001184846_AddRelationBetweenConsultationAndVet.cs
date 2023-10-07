using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Pri.Pawpi.Infrastructure.Migrations
{
    public partial class AddRelationBetweenConsultationAndVet : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "VeterinarianId",
                table: "Consultations",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Consultations_VeterinarianId",
                table: "Consultations",
                column: "VeterinarianId");

            migrationBuilder.AddForeignKey(
                name: "FK_Consultations_Veterinarians_VeterinarianId",
                table: "Consultations",
                column: "VeterinarianId",
                principalTable: "Veterinarians",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Consultations_Veterinarians_VeterinarianId",
                table: "Consultations");

            migrationBuilder.DropIndex(
                name: "IX_Consultations_VeterinarianId",
                table: "Consultations");

            migrationBuilder.DropColumn(
                name: "VeterinarianId",
                table: "Consultations");
        }
    }
}
