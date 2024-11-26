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
        public Task<List<Turno>?> GetTurnosAtendidos();
        public Task<List<Turno>?> GetTurnosConFormaPagoDebe();
    }
}
