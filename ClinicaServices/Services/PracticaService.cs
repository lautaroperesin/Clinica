using ClinicaServices.Enums;
using ClinicaServices.Interfaces;
using ClinicaServices.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace ClinicaServices.Services
{
    public class PracticaService : GenericService<Practica>, IPracticaService
    {
        public async Task<List<Practica>> GetPracticasPorTecnicaAsync(TecnicaEnum tecnica)
        {
            var response = await client.GetAsync($"{_endpoint}/practicas/{tecnica}");
            var content = await response.Content.ReadAsStringAsync();
            if (!response.IsSuccessStatusCode)
            {
                throw new ApplicationException(content?.ToString());
            }
            return JsonSerializer.Deserialize<List<Practica>>(content, options);
        }
    }
}
