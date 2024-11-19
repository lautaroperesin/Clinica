using ClinicaServices.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaServices.Models
{
    public class Medico
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "El nombre es obligatorio")]
        [MaxLength(100, ErrorMessage = "El nombre debe tener menos de 100 caracteres")]
        public string Nombre { get; set; } = string.Empty;
        [Required(ErrorMessage = "El apellido es obligatorio")]
        [MaxLength(100, ErrorMessage = "El apellido debe tener menos de 100 caracteres")]
        public string Apellido { get; set; } = string.Empty;
        [MaxLength(20)]
        public string? Telefono { get; set; } = string.Empty;
        public TecnicaEnum? Tecnica { get; set; } = null;
        public bool Eliminado { get; set; } = false;
        [NotMapped]
        public virtual ICollection<Turno>? TurnosAtendidos { get; set; }

        public string NombreCompleto
        {
            get
            {
                return $"{Apellido}, {Nombre}";
            }
        }
        public override string ToString() => NombreCompleto;
    }
}
