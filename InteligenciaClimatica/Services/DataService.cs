using InteligenciaClimatica.Models;
using System.Globalization;
using System.Text.Json;

namespace InteligenciaClimatica.Services
{
    public class DataService
    {
        private readonly string _csvPath;
        private readonly string _jsonPath;

        public List<RegistroClimatico> RegistrosHistoricos { get; private set; } = new();
        public Dictionary<string, Municipio> Municipios { get; private set; } = new();

        public DataService(string csvPath, string jsonPath)
        {
            _csvPath = csvPath;
            _jsonPath = jsonPath;
        }

        // ── Carga ambos archivos al iniciar el programa ──────────────────────
        public void CargarDatos()
        {
            CargarCSV();
            CargarJSON();
        }

        // ── CSV → List<RegistroClimatico> ────────────────────────────────────
        private void CargarCSV()
        {
            if (!File.Exists(_csvPath))
                throw new FileNotFoundException($"No se encontró el archivo CSV: {_csvPath}");

            var lineas = File.ReadAllLines(_csvPath);

            // La primera línea es el encabezado; se omite
            foreach (var linea in lineas.Skip(1))
            {
                if (string.IsNullOrWhiteSpace(linea)) continue;

                var cols = linea.Split(',');
                if (cols.Length < 11) continue;

                try
                {
                    var registro = new RegistroClimatico
                    {
                        // PERIOD  → "1985-01-01"
                        Periodo = DateOnly.ParseExact(cols[0].Trim(), "yyyy-MM-dd",
                                              CultureInfo.InvariantCulture),
                        EstadoId = int.Parse(cols[1].Trim()),
                        Estado = cols[2].Trim(),
                        MinC = double.Parse(cols[3].Trim(), CultureInfo.InvariantCulture),
                        PromedioC = double.Parse(cols[4].Trim(), CultureInfo.InvariantCulture),
                        MaxC = double.Parse(cols[5].Trim(), CultureInfo.InvariantCulture),
                        PrecipitacionMM = double.Parse(cols[6].Trim(), CultureInfo.InvariantCulture),
                        MinF = double.Parse(cols[7].Trim(), CultureInfo.InvariantCulture),
                        PromedioF = double.Parse(cols[8].Trim(), CultureInfo.InvariantCulture),
                        MaxF = double.Parse(cols[9].Trim(), CultureInfo.InvariantCulture),
                        PrecipitacionIN = double.Parse(cols[10].Trim(), CultureInfo.InvariantCulture)
                    };

                    RegistrosHistoricos.Add(registro);
                }
                catch (FormatException ex)
                {
                    Console.WriteLine($"[CSV] Línea omitida por error de formato: {ex.Message}");
                }
            }

            Console.WriteLine($"[CSV] {RegistrosHistoricos.Count} registros cargados.");
        }

        // ── JSON → Dictionary<string, Municipio> ────────────────────────────
        private void CargarJSON()
        {
            if (!File.Exists(_jsonPath))
                throw new FileNotFoundException($"No se encontró el archivo JSON: {_jsonPath}");

            var json = File.ReadAllText(_jsonPath);

            var lista = JsonSerializer.Deserialize<List<Municipio>>(json)
                        ?? throw new InvalidDataException("El JSON no contiene una lista válida.");

            // Clave = nombre del municipio en minúsculas para búsqueda sin distinción de mayúsculas
            Municipios = lista.ToDictionary(
                m => m.Nombre.ToLowerInvariant(),
                m => m
            );

            Console.WriteLine($"[JSON] {Municipios.Count} municipios cargados.");
        }

        // ── Helpers de consulta ──────────────────────────────────────────────

        /// Busca un municipio por nombre (sin distinción de mayúsculas/minúsculas).
        public Municipio? BuscarMunicipio(string nombre) =>
            Municipios.TryGetValue(nombre.ToLowerInvariant(), out var m) ? m : null;

        /// Filtra el histórico por estado y año.
        public List<RegistroClimatico> FiltrarPorEstadoYAnio(string estado, int anio) =>
            RegistrosHistoricos
                .Where(r => r.Estado.Equals(estado, StringComparison.OrdinalIgnoreCase)
                         && r.Periodo.Year == anio)
                .ToList();

        /// Filtra el histórico por estado y estación del año.
        public List<RegistroClimatico> FiltrarPorEstadoYEstacion(string estado, string estacion) =>
            RegistrosHistoricos
                .Where(r => r.Estado.Equals(estado, StringComparison.OrdinalIgnoreCase)
                         && r.Estacion.Equals(estacion, StringComparison.OrdinalIgnoreCase))
                .ToList();

        /// Calcula el promedio histórico de temperatura para un estado.
        public double PromedioHistoricoEstado(string estado) =>
            RegistrosHistoricos
                .Where(r => r.Estado.Equals(estado, StringComparison.OrdinalIgnoreCase))
                .Select(r => r.PromedioC)
                .DefaultIfEmpty(0)
                .Average();
    }
}