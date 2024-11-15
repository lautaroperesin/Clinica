using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaServices.Models
{
    public class Localidad
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "El campo nombre es obligatorio")]
        public string Nombre { get; set; } = null!;
        public bool Eliminado { get; set; } = false;
        public override string ToString() => Nombre;
    }
}
