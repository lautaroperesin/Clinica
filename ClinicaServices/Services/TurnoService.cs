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
    public class TurnoService : GenericService<Turno>, ITurnoService
    {
        public async Task<List<Turno>?> GetTurnosAtendidos()
        {
            var response = await client.GetAsync($"{_endpoint}/turnosAtendidos");
            var content = await response.Content.ReadAsStringAsync();
            if (!response.IsSuccessStatusCode)
            {
                throw new ApplicationException(content?.ToString());
            }
            return JsonSerializer.Deserialize<List<Turno>>(content, options);
        }

        public async Task<List<DateTime>> GetHorariosDisponibles(Medico medico, DateTime fecha)
        {
            var response = await client.GetAsync($"{_endpoint}/horariosDisponibles?medicoId={medico.Id}&fecha={fecha:yyyy-MM-dd}");
            var content = await response.Content.ReadAsStringAsync();
            if (!response.IsSuccessStatusCode)
            {
                throw new ApplicationException(content?.ToString());
            }
            return JsonSerializer.Deserialize<List<DateTime>>(content, options);
        }

        public async Task<List<Turno>?> GetTurnosConFormaPagoDebe()
        {
            var response = await client.GetAsync($"{_endpoint}/pagosPendientes");
            var content = await response.Content.ReadAsStringAsync();
            if (!response.IsSuccessStatusCode)
            {
                throw new ApplicationException(content?.ToString());
            }
            return JsonSerializer.Deserialize<List<Turno>>(content, options);
        }
    }
}
