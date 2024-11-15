using ClinicaServices.Enums;
using ClinicaServices.Models;
using Microsoft.EntityFrameworkCore;

namespace ClinicaBackend.DataContext
{
    public class ClinicaContext : DbContext
    {
        public ClinicaContext(DbContextOptions<ClinicaContext> options) : base(options)
        {
        }

        public DbSet<Paciente> Pacientes { get; set; }
        public DbSet<Medico> Medicos { get; set; }
        public DbSet<Turno> Turnos { get; set; }
        public DbSet<Mutual> Mutuales { get; set; }
        public DbSet<Localidad> Localidades { get; set; }
        public DbSet<Practica> Practicas { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var configuration = new ConfigurationBuilder()
                    .AddJsonFile("appsettings.json")
                    .Build();
            string? cadenaConexion = configuration.GetConnectionString("mysqlRemoto");

            optionsBuilder.UseMySql(cadenaConexion, ServerVersion.AutoDetect(cadenaConexion));
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            #region  Datos semilla
            // Localidades
            modelBuilder.Entity<Localidad>().HasData(
                new Localidad() { Id = 1, Nombre = "San Justo" },
                new Localidad() { Id = 2, Nombre = "Videla" },
                new Localidad() { Id = 3, Nombre = "Reconquista" },
                new Localidad() { Id = 4, Nombre = "Avellaneda" },
                new Localidad() { Id = 5, Nombre = "Vera" },
                new Localidad() { Id = 6, Nombre = "Romang" }
                );

            // Mutuales
            modelBuilder.Entity<Mutual>().HasData(
                new Mutual() { Id = 1, Nombre = "OSDE" },
                new Mutual() { Id = 2, Nombre = "IAPOS" },
                new Mutual() { Id = 3, Nombre = "OSPIL" },
                new Mutual() { Id = 4, Nombre = "SANCOR" },
                new Mutual() { Id = 5, Nombre = "JERARQUICOS SALUD" },
                new Mutual() { Id = 6, Nombre = "OSDOP" }
                );

            // Practicas
            modelBuilder.Entity<Practica>().HasData(
                new Practica
                {
                    Id = 1,
                    Nombre = "Abdominal",
                    Tecnica = TecnicaEnum.Ecografia
                },
                new Practica
                {
                    Id = 2,
                    Nombre = "Hepatobiliopancreatica",
                    Tecnica = TecnicaEnum.Ecografia
                },
                new Practica
                {
                    Id = 3,
                    Nombre = "Ginecologicas",
                    Tecnica = TecnicaEnum.Ecografia
                },
                new Practica
                {
                    Id = 4,
                    Nombre = "Partes blandas - Pie",
                    Tecnica = TecnicaEnum.Ecografia
                },
                new Practica
                {
                    Id = 5,
                    Nombre = "Partes blandas - Mano",
                    Tecnica = TecnicaEnum.Ecografia
                },
                new Practica
                {
                    Id = 6,
                    Nombre = "Partes blandas - Rodilla",
                    Tecnica = TecnicaEnum.Ecografia
                },
                new Practica
                {
                    Id = 7,
                    Nombre = "Partes blandas - Codo",
                    Tecnica = TecnicaEnum.Ecografia
                },
                new Practica
                {
                     Id = 8,
                     Nombre = "Craneo frente",
                     Tecnica = TecnicaEnum.Radiografia
                },
                new Practica
                {
                    Id = 9,
                    Nombre = "Craneo perfil",
                    Tecnica = TecnicaEnum.Radiografia
                },
                new Practica
                {
                    Id = 10,
                    Nombre = "Cavum",
                    Tecnica = TecnicaEnum.Radiografia
                },
                new Practica
                {
                    Id = 11,
                    Nombre = "Columna cervical frente",
                    Tecnica = TecnicaEnum.Radiografia
                },
                new Practica
                {
                    Id = 12,
                    Nombre = "Columna dorsal frente",
                    Tecnica = TecnicaEnum.Radiografia
                },
                new Practica
                {
                    Id = 13,
                    Nombre = "Columna lumbar frente",
                    Tecnica = TecnicaEnum.Radiografia
                },
                new Practica
                {
                    Id = 14,
                    Nombre = "Columna cervical perfil",
                    Tecnica = TecnicaEnum.Radiografia
                },
                new Practica
                {
                    Id = 57,
                    Nombre = "Oftalmologica",
                    Tecnica = TecnicaEnum.Tomografia
                },
                new Practica
                {
                    Id = 58,
                    Nombre = "Tiroidea",
                    Tecnica = TecnicaEnum.Tomografia
                },
                new Practica
                {
                    Id = 59,
                    Nombre = "Mamaria",
                    Tecnica = TecnicaEnum.Tomografia
                },
                new Practica
                {
                    Id = 60,
                    Nombre = "Ginecologica",
                    Tecnica = TecnicaEnum.Tomografia
                },
                new Practica
                {
                    Id = 61,
                    Nombre = "Abdominal",
                    Tecnica = TecnicaEnum.Tomografia
                },
                new Practica
                {
                    Id = 62,
                    Nombre = "Hepatobiliar",
                    Tecnica = TecnicaEnum.Tomografia
                }
            );

            // Medicos
            modelBuilder.Entity<Medico>().HasData(
                new Medico
                {
                    Id = 1,
                    Matricula = "1234",
                    Nombre = "Juan",
                    Apellido = "Perez",
                    Telefono = "3498123465",
                    Tecnica = TecnicaEnum.Ecografia
                },
                new Medico
                {
                    Id = 2,
                    Matricula = "5678",
                    Nombre = "Maria",
                    Apellido = "Gomez",
                    Telefono = "3498456754",
                    Tecnica = TecnicaEnum.Radiografia
                },
                new Medico
                {
                    Id = 3,
                    Matricula = "9876",
                    Nombre = "Carlos",
                    Apellido = "Gonzalez",
                    Telefono = "3498564532",
                    Tecnica = TecnicaEnum.Tomografia
                }
            );

            // Pacientes
            modelBuilder.Entity<Paciente>().HasData(
                new Paciente
                {
                    Id = 1,
                    Nombre = "Lautaro",
                    Apellido = "Peresin",
                    Direccion = "San Roque 1932",
                    Email = "lautaro@gmail.com",
                    Telefono = "3498404954",
                    Documento = "46041117",
                    FechaNacimiento = new DateTime(2004, 7, 25),
                    MutualId = 1,
                    LocalidadId = 1
                },
                new Paciente
                {
                    Id = 2,
                    Nombre = "Juan",
                    Apellido = "Perez",
                    Direccion = "Independencia",
                    Email = "juan@gmail.com",
                    Telefono = "3498459821",
                    Documento = "12345678",
                    FechaNacimiento = new DateTime(1999, 7, 10),
                    MutualId = 2,
                    LocalidadId = 1
                },
                new Paciente
                {
                    Id = 3,
                    Nombre = "Maria",
                    Apellido = "Gomez",
                    Direccion = "Belgrano 123",
                    Email = "maria.gomez@gmail.com",
                    Telefono = "3512367890",
                    Documento = "87654321",
                    FechaNacimiento = new DateTime(1987, 3, 15),
                    MutualId = 1,
                    LocalidadId = 2
                },
                new Paciente
                {
                    Id = 4,
                    Nombre = "Carlos",
                    Apellido = "Lopez",
                    Direccion = "Mitre 456",
                    Email = "carlos.lopez@hotmail.com",
                    Telefono = "3517896543",
                    Documento = "45678912",
                    FechaNacimiento = new DateTime(1975, 11, 5),
                    MutualId = 3,
                    LocalidadId = 1
                },
                new Paciente
                {
                    Id = 5,
                    Nombre = "Ana",
                    Apellido = "Martinez",
                    Direccion = "Rivadavia 789",
                    Email = "ana.martinez@yahoo.com",
                    Telefono = "3541556789",
                    Documento = "11223344",
                    FechaNacimiento = new DateTime(1990, 5, 20),
                    MutualId = 2,
                    LocalidadId = 1
                },
                new Paciente
                {
                    Id = 6,
                    Nombre = "Luis",
                    Apellido = "Fernandez",
                    Direccion = "San Martin 101",
                    Email = "luis.fernandez@gmail.com",
                    Telefono = "3519987654",
                    Documento = "33445566",
                    FechaNacimiento = new DateTime(1982, 9, 25),
                    MutualId = 1,
                    LocalidadId = 2
                },
                new Paciente
                {
                    Id = 7,
                    Nombre = "Sofia",
                    Apellido = "Diaz",
                    Direccion = "Sarmiento 234",
                    Email = "sofia.diaz@gmail.com",
                    Telefono = "3511122334",
                    Documento = "55667788",
                    FechaNacimiento = new DateTime(1995, 12, 2),
                    MutualId = 4,
                    LocalidadId = 3
                },
                new Paciente
                {
                    Id = 8,
                    Nombre = "Jorge",
                    Apellido = "Sanchez",
                    Direccion = "Lavalle 432",
                    Email = "jorge.sanchez@hotmail.com",
                    Telefono = "3516677889",
                    Documento = "22334455",
                    FechaNacimiento = new DateTime(1979, 4, 18),
                    MutualId = 3,
                    LocalidadId = 1
                },
                new Paciente
                {
                    Id = 9,
                    Nombre = "Laura",
                    Apellido = "Mendez",
                    Direccion = "Alsina 567",
                    Email = "laura.mendez@gmail.com",
                    Telefono = "3513344556",
                    Documento = "99887766",
                    FechaNacimiento = new DateTime(1988, 6, 10),
                    MutualId = 1,
                    LocalidadId = 1
                },
                new Paciente
                {
                    Id = 10,
                    Nombre = "Miguel",
                    Apellido = "Ruiz",
                    Direccion = "Peron 890",
                    Email = "miguel.ruiz@gmail.com",
                    Telefono = "3517766554",
                    Documento = "44556677",
                    FechaNacimiento = new DateTime(1992, 1, 30),
                    MutualId = 4,
                    LocalidadId = 2
                }
                );
            #endregion

            #region Definición de filtros de eliminación
            modelBuilder.Entity<Turno>().HasQueryFilter(m => !m.Eliminado);
            modelBuilder.Entity<Medico>().HasQueryFilter(m => !m.Eliminado);
            modelBuilder.Entity<Mutual>().HasQueryFilter(m => !m.Eliminado);
            modelBuilder.Entity<Paciente>().HasQueryFilter(m => !m.Eliminado);
            modelBuilder.Entity<Practica>().HasQueryFilter(m => !m.Eliminado);
            modelBuilder.Entity<Localidad>().HasQueryFilter(m => !m.Eliminado);
            #endregion
        }
    }
}
