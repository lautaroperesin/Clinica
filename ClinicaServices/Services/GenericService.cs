using ClinicaServices.Class;
using ClinicaServices.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ClinicaServices.Services
{
    public class GenericService<T> : IGenericService<T> where T : class
    {
        protected readonly HttpClient client;
        protected readonly JsonSerializerOptions options;
        protected readonly string _endpoint;

        public GenericService()
        {
            this.client = new HttpClient();
            this.options = new JsonSerializerOptions() { PropertyNameCaseInsensitive = true, Converters = { new JsonStringEnumConverter() } };
            var remoto = Properties.Resources.Remoto;
            string urlApi = Properties.Resources.UrlApi;
            if (remoto == "false")
            {
                urlApi = Properties.Resources.UrlApiLocal; 
            }

            this._endpoint = urlApi + ApiEndpoints.GetEndpoint(typeof(T).Name);
        }

        public async Task<List<T>?> GetAllAsync()
        {
            try
            {
                var response = await client.GetAsync(_endpoint);
                var content = await response.Content.ReadAsStringAsync();

                if (!response.IsSuccessStatusCode)
                {
                    throw new ApplicationException($"Error: {response.StatusCode}, Contenido: {content}");
                }

                return JsonSerializer.Deserialize<List<T>>(content, options);
            }
            catch (Exception ex)
            {
                throw new ApplicationException($"Excepción al obtener datos: {ex.Message}");
            }
        }

        public async Task<T?> GetByIdAsync(int id)
        {
            var response = await client.GetAsync($"{_endpoint}/{id}");
            var content = await response.Content.ReadAsStreamAsync();
            if (!response.IsSuccessStatusCode)
            {
                throw new ApplicationException(content?.ToString());
            }
            return JsonSerializer.Deserialize<T>(content, options);
        }

        public async Task<T?> AddAsync(T? entity)
        {
            var response = await client.PostAsJsonAsync(_endpoint, entity);
            var content = await response.Content.ReadAsStreamAsync();

            if (!response.IsSuccessStatusCode)
            {
                throw new ApplicationException($"Error: {response.StatusCode}, Detalle: {content}");
            }

            try
            {
                return JsonSerializer.Deserialize<T>(content, options);
            }
            catch (JsonException ex)
            {
                throw new ApplicationException($"Error al deserializar la respuesta: {content}", ex);
            }
        }

        public async Task UpdateAsync(T? entity)
        {
            var idValue = entity.GetType().GetProperty("Id").GetValue(entity);

            var response = await client.PutAsJsonAsync($"{_endpoint}/{idValue}", entity);
            if (!response.IsSuccessStatusCode)
            {
                throw new ApplicationException(response?.ToString());
            }
        }

        public async Task DeleteAsync(int id)
        {
            var response = await client.DeleteAsync($"{_endpoint}/{id}");
            if (!response.IsSuccessStatusCode)
            {
                throw new ApplicationException(response.ToString());
            }
        }
    }
}
