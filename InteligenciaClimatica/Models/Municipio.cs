using System.Text.Json.Serialization;

namespace InteligenciaClimatica.Models
{
    public class Municipio
    {
        [JsonPropertyName("Municipio")]
        public string Nombre { get; set; } = string.Empty;

        [JsonPropertyName("Estado")]
        public string Estado { get; set; } = string.Empty;

        [JsonPropertyName("Lat")]
        public double Latitud { get; set; }

        [JsonPropertyName("Lon")]
        public double Longitud { get; set; }
    }
}