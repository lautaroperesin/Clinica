using ClinicaServices.Enums;
using ClinicaServices.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaServices.Interfaces
{
    public interface IPracticaService : IGenericService<Practica>
    {
        Task<List<Practica>> GetPracticasPorTecnicaAsync(TecnicaEnum tecnica);
    }
}
