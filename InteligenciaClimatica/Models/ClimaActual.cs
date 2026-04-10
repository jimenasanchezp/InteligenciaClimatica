using System.Text.Json.Serialization;

namespace InteligenciaClimatica.Models
{
    // Esta clase atrapa la respuesta principal de Open-Meteo
    public class OpenMeteoResponse
    {
        [JsonPropertyName("current_weather")]
        public ClimaActual CurrentWeather { get; set; } = new ClimaActual();
    }

    // Esta clase extrae exactamente lo que nos interesa
    public class ClimaActual
    {
        [JsonPropertyName("temperature")]
        public double Temperatura { get; set; }

        [JsonPropertyName("windspeed")]
        public double VelocidadViento { get; set; }

        [JsonPropertyName("weathercode")]
        public int CodigoClima { get; set; }
    }
}