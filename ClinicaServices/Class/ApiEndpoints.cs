using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaServices.Class
{
    public static class ApiEndpoints
    {
        public static string Medico { get; set; } = "Medicos";
        public static string Mutual { get; set; } = "Mutuales";
        public static string Paciente { get; set; } = "Pacientes";
        public static string Practica { get; set; } = "Practicas";
        public static string Turno { get; set; } = "Turnos";
        public static string Localidad { get; set; } = "Localidades";


        public static string GetEndpoint(string name)
        {
            return name switch
            {
                nameof(Medico) => Medico,
                nameof(Mutual) => Mutual,
                nameof(Paciente) => Paciente,
                nameof(Practica) => Practica,
                nameof(Turno) => Turno,
                nameof(Localidad) => Localidad,

                _ => throw new ArgumentException($"Endpoint '{name}' no está definido.")
            };
        }
    }
}
