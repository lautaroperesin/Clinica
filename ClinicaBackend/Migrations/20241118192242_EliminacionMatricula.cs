using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ClinicaBackend.Migrations
{
    /// <inheritdoc />
    public partial class EliminacionMatricula : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Matricula",
                table: "Medicos");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Matricula",
                table: "Medicos",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "Medicos",
                keyColumn: "Id",
                keyValue: 1,
                column: "Matricula",
                value: "1234");

            migrationBuilder.UpdateData(
                table: "Medicos",
                keyColumn: "Id",
                keyValue: 2,
                column: "Matricula",
                value: "5678");

            migrationBuilder.UpdateData(
                table: "Medicos",
                keyColumn: "Id",
                keyValue: 3,
                column: "Matricula",
                value: "9876");
        }
    }
}
