using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClinicaServices.Enums;

namespace ClinicaServices.Models
{
    public class Practica
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "El nombre de la practica es obligatorio")]
        [MaxLength(100, ErrorMessage = "El nombre debe tener menos de 100 caracteres")]
        public string Nombre { get; set; } = string.Empty;
        [DisplayFormat(DataFormatString = "{0:F2}", ApplyFormatInEditMode = true)]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? Precio { get; set; } = decimal.Zero;
        public TecnicaEnum? Tecnica { get; set; } = null;
        public bool Eliminado { get; set; } = false;

        public override string ToString() => Nombre;
    }
}
