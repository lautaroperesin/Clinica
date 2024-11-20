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
        //public async Task<List<Turno>> GetTurnosPorMedicoYFecha(int medicoId, DateTime fecha)
        //{
        //    if (medicoId <= 0)
        //        throw new ArgumentException("El ID del médico debe ser válido.", nameof(medicoId));

        //    try
        //    {
        //        string fechaString = fecha.ToString("yyyy-MM-dd");
        //        var response = await client.GetAsync($"{_endpoint}/{medicoId}/{fechaString}");

        //        if (!response.IsSuccessStatusCode)
        //        {
        //            // Intentar deserializar el error del servidor, si es posible
        //            var errorContent = await response.Content.ReadAsStringAsync();
        //            throw new ApplicationException($"Error al obtener turnos: {errorContent}");
        //        }

        //        var content = await response.Content.ReadAsStringAsync();
        //        return JsonSerializer.Deserialize<List<Turno>>(content, options);
        //    }
        //    catch (Exception ex)
        //    {
        //        throw new ApplicationException($"Error al obtener turnos: {ex.Message}");
        //    }

        //    //var content = await response.Content.ReadAsStringAsync();
        //    //if (!response.IsSuccessStatusCode)
        //    //{
        //    //    throw new ApplicationException(content?.ToString());
        //    //}
        //    //return JsonSerializer.Deserialize<List<Turno>>(content, options);
        //}

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
    }
}
