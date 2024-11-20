using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ClinicaBackend.Migrations
{
    /// <inheritdoc />
    public partial class AjusteTurnos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Turnos_Medicos_MedicoDerivanteId",
                table: "Turnos");

            migrationBuilder.DropIndex(
                name: "IX_Turnos_MedicoDerivanteId",
                table: "Turnos");

            migrationBuilder.DropColumn(
                name: "MedicoDerivanteId",
                table: "Turnos");

            migrationBuilder.RenameColumn(
                name: "FechaConsulta",
                table: "Turnos",
                newName: "FechaTurno");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "FechaTurno",
                table: "Turnos",
                newName: "FechaConsulta");

            migrationBuilder.AddColumn<int>(
                name: "MedicoDerivanteId",
                table: "Turnos",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Turnos_MedicoDerivanteId",
                table: "Turnos",
                column: "MedicoDerivanteId");

            migrationBuilder.AddForeignKey(
                name: "FK_Turnos_Medicos_MedicoDerivanteId",
                table: "Turnos",
                column: "MedicoDerivanteId",
                principalTable: "Medicos",
                principalColumn: "Id");
        }
    }
}
