using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ClinicaBackend.Migrations
{
    /// <inheritdoc />
    public partial class EliminacionEmail : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Email",
                table: "Pacientes");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Pacientes",
                type: "varchar(100)",
                maxLength: 100,
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "Pacientes",
                keyColumn: "Id",
                keyValue: 1,
                column: "Email",
                value: "lautaro@gmail.com");

            migrationBuilder.UpdateData(
                table: "Pacientes",
                keyColumn: "Id",
                keyValue: 2,
                column: "Email",
                value: "juan@gmail.com");

            migrationBuilder.UpdateData(
                table: "Pacientes",
                keyColumn: "Id",
                keyValue: 3,
                column: "Email",
                value: "maria.gomez@gmail.com");

            migrationBuilder.UpdateData(
                table: "Pacientes",
                keyColumn: "Id",
                keyValue: 4,
                column: "Email",
                value: "carlos.lopez@hotmail.com");

            migrationBuilder.UpdateData(
                table: "Pacientes",
                keyColumn: "Id",
                keyValue: 5,
                column: "Email",
                value: "ana.martinez@yahoo.com");

            migrationBuilder.UpdateData(
                table: "Pacientes",
                keyColumn: "Id",
                keyValue: 6,
                column: "Email",
                value: "luis.fernandez@gmail.com");

            migrationBuilder.UpdateData(
                table: "Pacientes",
                keyColumn: "Id",
                keyValue: 7,
                column: "Email",
                value: "sofia.diaz@gmail.com");

            migrationBuilder.UpdateData(
                table: "Pacientes",
                keyColumn: "Id",
                keyValue: 8,
                column: "Email",
                value: "jorge.sanchez@hotmail.com");

            migrationBuilder.UpdateData(
                table: "Pacientes",
                keyColumn: "Id",
                keyValue: 9,
                column: "Email",
                value: "laura.mendez@gmail.com");

            migrationBuilder.UpdateData(
                table: "Pacientes",
                keyColumn: "Id",
                keyValue: 10,
                column: "Email",
                value: "miguel.ruiz@gmail.com");
        }
    }
}
