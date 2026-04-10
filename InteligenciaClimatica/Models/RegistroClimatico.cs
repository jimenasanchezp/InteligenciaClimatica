namespace InteligenciaClimatica.Models
{
    public class RegistroClimatico
    {
        public DateOnly Periodo { get; set; }
        public int EstadoId { get; set; }
        public string Estado { get; set; } = string.Empty;

        // Celsius
        public double MinC { get; set; }
        public double PromedioC { get; set; }
        public double MaxC { get; set; }

        // Fahrenheit
        public double MinF { get; set; }
        public double PromedioF { get; set; }
        public double MaxF { get; set; }

        public double PrecipitacionMM { get; set; }
        public double PrecipitacionIN { get; set; }

        // Utilitario: estación del año basada en el mes del periodo
        public string Estacion => Periodo.Month switch
        {
            12 or 1 or 2 => "Invierno",
            3 or 4 or 5 => "Primavera",
            6 or 7 or 8 => "Verano",
            _ => "Otoño"
        };

        public override string ToString() =>
            $"[{Periodo:yyyy-MM}] {Estado} | " +
            $"Prom: {PromedioC}°C | Min: {MinC}°C | Max: {MaxC}°C | " +
            $"Precip: {PrecipitacionMM}mm | Estación: {Estacion}";
    }
}