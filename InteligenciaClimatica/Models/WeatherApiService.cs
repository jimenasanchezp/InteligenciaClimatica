using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using InteligenciaClimatica.Models;

namespace InteligenciaClimatica.Services
{
    public class WeatherApiService
    {
        private readonly HttpClient _httpClient;

        public WeatherApiService()
        {
            _httpClient = new HttpClient();
        }

        public async Task<double> ObtenerTemperaturaActualAsync(double latitud, double longitud)
        {
            // Construimos la URL dinámica con las coordenadas del JSON
            string url = $"https://api.open-meteo.com/v1/forecast?latitude={latitud}&longitude={longitud}&current_weather=true";

            try
            {
                // Hacemos la petición a la Nube
                HttpResponseMessage response = await _httpClient.GetAsync(url);
                response.EnsureSuccessStatusCode(); // Verifica que el servidor respondió 200 OK

                string jsonResponse = await response.Content.ReadAsStringAsync();

                // Convertimos el JSON de internet a nuestras clases de C#
                var datosClima = JsonSerializer.Deserialize<OpenMeteoResponse>(jsonResponse);

                // Retornamos solo la temperatura
                return datosClima?.CurrentWeather.Temperatura ?? 0;
            }
            catch (Exception ex)
            {
                throw new Exception($"Error de conexión con la API: {ex.Message}");
            }
        }
    }
}