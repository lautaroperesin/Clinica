using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ClinicaBackend.Migrations
{
    /// <inheritdoc />
    public partial class InicioProyecto : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Localidades",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nombre = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Eliminado = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Localidades", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Medicos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nombre = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Apellido = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Telefono = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Tecnica = table.Column<int>(type: "int", nullable: true),
                    Eliminado = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Medicos", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Mutuales",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nombre = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Eliminado = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mutuales", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Practicas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nombre = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Tecnica = table.Column<int>(type: "int", nullable: true),
                    Precio = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Eliminado = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Practicas", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Pacientes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nombre = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Apellido = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Direccion = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Telefono = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Documento = table.Column<string>(type: "varchar(15)", maxLength: 15, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    FechaNacimiento = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    MutualId = table.Column<int>(type: "int", nullable: false),
                    LocalidadId = table.Column<int>(type: "int", nullable: true),
                    Eliminado = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pacientes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Pacientes_Localidades_LocalidadId",
                        column: x => x.LocalidadId,
                        principalTable: "Localidades",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Pacientes_Mutuales_MutualId",
                        column: x => x.MutualId,
                        principalTable: "Mutuales",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Turnos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    PacienteId = table.Column<int>(type: "int", nullable: true),
                    MedicoEfectorId = table.Column<int>(type: "int", nullable: true),
                    PracticaId = table.Column<int>(type: "int", nullable: true),
                    Tecnica = table.Column<int>(type: "int", nullable: true),
                    FechaTurno = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    Coseguro = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    FormaPago = table.Column<int>(type: "int", nullable: true),
                    Atendido = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    Eliminado = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Turnos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Turnos_Medicos_MedicoEfectorId",
                        column: x => x.MedicoEfectorId,
                        principalTable: "Medicos",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Turnos_Pacientes_PacienteId",
                        column: x => x.PacienteId,
                        principalTable: "Pacientes",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Turnos_Practicas_PracticaId",
                        column: x => x.PracticaId,
                        principalTable: "Practicas",
                        principalColumn: "Id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "Localidades",
                columns: new[] { "Id", "Eliminado", "Nombre" },
                values: new object[,]
                {
                    { 1, false, "San Justo" },
                    { 2, false, "Videla" },
                    { 3, false, "Reconquista" },
                    { 4, false, "Avellaneda" },
                    { 5, false, "Vera" },
                    { 6, false, "Romang" }
                });

            migrationBuilder.InsertData(
                table: "Medicos",
                columns: new[] { "Id", "Apellido", "Eliminado", "Nombre", "Tecnica", "Telefono" },
                values: new object[,]
                {
                    { 1, "Perez", false, "Juan", 2, "3498123465" },
                    { 2, "Gomez", false, "Maria", 1, "3498456754" },
                    { 3, "Gonzalez", false, "Carlos", 3, "3498564532" }
                });

            migrationBuilder.InsertData(
                table: "Mutuales",
                columns: new[] { "Id", "Eliminado", "Nombre" },
                values: new object[,]
                {
                    { 1, false, "OSDE" },
                    { 2, false, "IAPOS" },
                    { 3, false, "OSPIL" },
                    { 4, false, "SANCOR" },
                    { 5, false, "JERARQUICOS SALUD" },
                    { 6, false, "OSDOP" }
                });

            migrationBuilder.InsertData(
                table: "Practicas",
                columns: new[] { "Id", "Eliminado", "Nombre", "Precio", "Tecnica" },
                values: new object[,]
                {
                    { 1, false, "Abdominal", 0m, 2 },
                    { 2, false, "Hepatobiliopancreatica", 0m, 2 },
                    { 3, false, "Ginecologicas", 0m, 2 },
                    { 4, false, "Partes blandas - Pie", 0m, 2 },
                    { 5, false, "Partes blandas - Mano", 0m, 2 },
                    { 6, false, "Partes blandas - Rodilla", 0m, 2 },
                    { 7, false, "Partes blandas - Codo", 0m, 2 },
                    { 8, false, "Craneo frente", 0m, 1 },
                    { 9, false, "Craneo perfil", 0m, 1 },
                    { 10, false, "Cavum", 0m, 1 },
                    { 11, false, "Columna cervical frente", 0m, 1 },
                    { 12, false, "Columna dorsal frente", 0m, 1 },
                    { 13, false, "Columna lumbar frente", 0m, 1 },
                    { 14, false, "Columna cervical perfil", 0m, 1 },
                    { 57, false, "Oftalmologica", 0m, 3 },
                    { 58, false, "Tiroidea", 0m, 3 },
                    { 59, false, "Mamaria", 0m, 3 },
                    { 60, false, "Ginecologica", 0m, 3 },
                    { 61, false, "Abdominal", 0m, 3 },
                    { 62, false, "Hepatobiliar", 0m, 3 }
                });

            migrationBuilder.InsertData(
                table: "Pacientes",
                columns: new[] { "Id", "Apellido", "Direccion", "Documento", "Eliminado", "FechaNacimiento", "LocalidadId", "MutualId", "Nombre", "Telefono" },
                values: new object[,]
                {
                    { 1, "Peresin", "San Roque 1932", "46041117", false, new DateTime(2004, 7, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1, "Lautaro", "3498404954" },
                    { 2, "Perez", "Independencia", "12345678", false, new DateTime(1999, 7, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 2, "Juan", "3498459821" },
                    { 3, "Gomez", "Belgrano 123", "87654321", false, new DateTime(1987, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 1, "Maria", "3512367890" },
                    { 4, "Lopez", "Mitre 456", "45678912", false, new DateTime(1975, 11, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 3, "Carlos", "3517896543" },
                    { 5, "Martinez", "Rivadavia 789", "11223344", false, new DateTime(1990, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 2, "Ana", "3541556789" },
                    { 6, "Fernandez", "San Martin 101", "33445566", false, new DateTime(1982, 9, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 1, "Luis", "3519987654" },
                    { 7, "Diaz", "Sarmiento 234", "55667788", false, new DateTime(1995, 12, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 4, "Sofia", "3511122334" },
                    { 8, "Sanchez", "Lavalle 432", "22334455", false, new DateTime(1979, 4, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 3, "Jorge", "3516677889" },
                    { 9, "Mendez", "Alsina 567", "99887766", false, new DateTime(1988, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1, "Laura", "3513344556" },
                    { 10, "Ruiz", "Peron 890", "44556677", false, new DateTime(1992, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 4, "Miguel", "3517766554" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Pacientes_LocalidadId",
                table: "Pacientes",
                column: "LocalidadId");

            migrationBuilder.CreateIndex(
                name: "IX_Pacientes_MutualId",
                table: "Pacientes",
                column: "MutualId");

            migrationBuilder.CreateIndex(
                name: "IX_Turnos_MedicoEfectorId",
                table: "Turnos",
                column: "MedicoEfectorId");

            migrationBuilder.CreateIndex(
                name: "IX_Turnos_PacienteId",
                table: "Turnos",
                column: "PacienteId");

            migrationBuilder.CreateIndex(
                name: "IX_Turnos_PracticaId",
                table: "Turnos",
                column: "PracticaId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Turnos");

            migrationBuilder.DropTable(
                name: "Medicos");

            migrationBuilder.DropTable(
                name: "Pacientes");

            migrationBuilder.DropTable(
                name: "Practicas");

            migrationBuilder.DropTable(
                name: "Localidades");

            migrationBuilder.DropTable(
                name: "Mutuales");
        }
    }
}
