using System.Text.Json;
using InteligenciaClimatica.Models;

namespace InteligenciaClimatica.Services
{
    public class WeatherApiService
    {
        private readonly HttpClient _httpClient;

        private const string UrlBase =
            "https://api.open-meteo.com/v1/forecast" +
            "?latitude={0}&longitude={1}" +
            "&current=temperature_2m,apparent_temperature,precipitation,windspeed_10m" +
            "&daily=temperature_2m_max,temperature_2m_min" +
            "&timezone=auto";

        public WeatherApiService()
        {
            _httpClient = new HttpClient();
        }

        public async Task<OpenMeteoResponse> ObtenerClimaAsync(double latitud, double longitud)
        {
            string url = string.Format(UrlBase,
                latitud.ToString(System.Globalization.CultureInfo.InvariantCulture),
                longitud.ToString(System.Globalization.CultureInfo.InvariantCulture));

            try
            {
                HttpResponseMessage response = await _httpClient.GetAsync(url);
                response.EnsureSuccessStatusCode();

                string jsonResponse = await response.Content.ReadAsStringAsync();

                var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
                var datos = JsonSerializer.Deserialize<OpenMeteoResponse>(jsonResponse, options);

                return datos ?? new OpenMeteoResponse();
            }
            catch (HttpRequestException ex)
            {
                throw new Exception($"Sin conexión con Open-Meteo: {ex.Message}");
            }
            catch (JsonException ex)
            {
                throw new Exception($"Error al leer respuesta de la API: {ex.Message}");
            }
        }
    }
}