using ClinicaServices.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaServices.Interfaces
{
    public interface ITurnoService : IGenericService<Turno>
    {
        //Task<List<Turno>> GetTurnosPorMedicoYFecha(int medicoId, DateTime fecha);
        public Task<List<Turno>?> GetTurnosAtendidos();
    }
}
