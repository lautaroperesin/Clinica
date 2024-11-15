using ClinicaServices.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaServices.Models
{
    public class Turno
    {
        [Key]
        public int Id { get; set; }
        public int? PacienteId { get; set; } = null;
        public Paciente? Paciente { get; set; }
        public int? MedicoDerivanteId { get; set; }
        public virtual Medico? MedicoDerivante { get; set; }
        public int? MedicoEfectorId { get; set; }
        public virtual Medico? MedicoEfector { get; set; }
        public int? PracticaId { get; set; }
        public virtual Practica? Practica { get; set; }
        public TecnicaEnum? Tecnica { get; set; }

        [DataType(DataType.Date)]
        public DateTime? FechaConsulta { get; set; } = DateTime.Now;
        [DisplayFormat(DataFormatString = "{0:F2}", ApplyFormatInEditMode = true)]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? Coseguro { get; set; }
        public FormaPagoEnum? FormaPago { get; set; }
        public bool Atendido { get; set; } = false;
        public bool Eliminado { get; set; } = false;

        //public string NombreObraSocial => Paciente?.ObraSocial?.Nombre ?? "Sin Obra Social";
    }
}
