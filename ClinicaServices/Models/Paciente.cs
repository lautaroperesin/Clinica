    using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaServices.Models
{
    public class Paciente
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "El nombre es obligatorio")]
        [MaxLength(100, ErrorMessage = "El nombre debe tener menos de 100 caracteres")]
        public string Nombre { get; set; } = string.Empty;
        [Required(ErrorMessage = "El apellido es obligatorio")]
        [MaxLength(100, ErrorMessage = "El nombre debe tener menos de 100 caracteres")]
        public string Apellido { get; set; } = string.Empty;
        [MaxLength(100)]
        public string? Direccion { get; set; } = string.Empty;
        [MaxLength(20)]
        public string? Telefono { get; set; } = string.Empty;
        [Required(ErrorMessage = "El DNI es obligatorio")]
        [MaxLength(15)]
        [RegularExpression(@"\d{7,8}", ErrorMessage = "El DNI debe contener entre 7 y 8 dígitos.")]
        public string Documento { get; set; } = string.Empty;
        [DataType(DataType.Date)]
        public DateTime? FechaNacimiento { get; set; }
        [Required(ErrorMessage = "Debes asignarle una obra social al paciente")]
        public int MutualId { get; set; }
        public Mutual? Mutual { get; set; }
        public int? LocalidadId { get; set; }
        public Localidad? Localidad { get; set; }
        public bool Eliminado { get; set; } = false;
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
