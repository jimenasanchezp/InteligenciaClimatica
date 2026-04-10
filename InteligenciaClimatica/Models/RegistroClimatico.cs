using System;

namespace InteligenciaClimatica.Models
{
    public class RegistroClimatico
    {
        public DateOnly Periodo { get; set; }
        public int EstadoId { get; set; }
        public string Estado { get; set; } = string.Empty;
        public double MinC { get; set; }
        public double PromedioC { get; set; }
        public double MaxC { get; set; }
        public double PrecipitacionMM { get; set; }
        public double MinF { get; set; }
        public double PromedioF { get; set; }
        public double MaxF { get; set; }
        public double PrecipitacionIN { get; set; }

        // Nueva propiedad requerida para los filtros
        public string Estacion { get; set; } = string.Empty;
    }
}