using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaServices.Models
{
    public class Mutual
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "El nombre de la mutual es obligatorio")]
        public string Nombre { get; set; } = string.Empty;
        public bool Eliminado { get; set; } = false;
        //public virtual ICollection<Paciente>? Pacientes { get; set; }
        public override string ToString() => Nombre;
    }
}
