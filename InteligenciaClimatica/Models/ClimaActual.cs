using System.Text.Json.Serialization;

namespace InteligenciaClimatica.Models
{
    public class OpenMeteoResponse
    {
        [JsonPropertyName("current")]
        public ClimaActual Current { get; set; } = new ClimaActual();

        [JsonPropertyName("daily")]
        public PronosticoDiario Daily { get; set; } = new PronosticoDiario();
    }

    public class ClimaActual
    {
        [JsonPropertyName("temperature_2m")]
        public double Temperatura { get; set; }

        [JsonPropertyName("apparent_temperature")]
        public double TemperaturaAparente { get; set; }

        [JsonPropertyName("precipitation")]
        public double Precipitacion { get; set; }

        [JsonPropertyName("windspeed_10m")]
        public double VelocidadViento { get; set; }
    }

    public class PronosticoDiario
    {
        [JsonPropertyName("temperature_2m_max")]
        public List<double> Maximas { get; set; } = new();

        [JsonPropertyName("temperature_2m_min")]
        public List<double> Minimas { get; set; } = new();

        public double MaxHoy => Maximas.Count > 0 ? Maximas[0] : 0;
        public double MinHoy => Minimas.Count > 0 ? Minimas[0] : 0;
    }
}