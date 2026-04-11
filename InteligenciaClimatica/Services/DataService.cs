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
                    // Se extrae la fecha primero para poder calcular la estación
                    var periodo = DateOnly.ParseExact(cols[0].Trim(), "yyyy-MM-dd", CultureInfo.InvariantCulture);

                    var registro = new RegistroClimatico
                    {
                        Periodo = periodo,
                        EstadoId = int.Parse(cols[1].Trim()),
                        Estado = cols[2].Trim(),
                        MinC = double.Parse(cols[3].Trim(), CultureInfo.InvariantCulture),
                        PromedioC = double.Parse(cols[4].Trim(), CultureInfo.InvariantCulture),
                        MaxC = double.Parse(cols[5].Trim(), CultureInfo.InvariantCulture),
                        PrecipitacionMM = double.Parse(cols[6].Trim(), CultureInfo.InvariantCulture),
                        MinF = double.Parse(cols[7].Trim(), CultureInfo.InvariantCulture),
                        PromedioF = double.Parse(cols[8].Trim(), CultureInfo.InvariantCulture),
                        MaxF = double.Parse(cols[9].Trim(), CultureInfo.InvariantCulture),
                        PrecipitacionIN = double.Parse(cols[10].Trim(), CultureInfo.InvariantCulture),

                        // Aquí se asigna la estación dinámicamente
                        Estacion = DeterminarEstacion(periodo.Month)
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

            Municipios = new Dictionary<string, Municipio>();

            foreach (var m in lista)
            {
                // Creamos una llave única combinando municipio y estado
                string llaveUnica = $"{m.Nombre.ToLowerInvariant()}|{m.Estado.ToLowerInvariant()}";

                // TryAdd evita que el programa colapse si hay datos duplicados en el JSON
                Municipios.TryAdd(llaveUnica, m);
            }

            Console.WriteLine($"[JSON] {Municipios.Count} municipios cargados.");
        }

        /// Busca un municipio por nombre y estado (llave única).
        public Municipio? BuscarMunicipio(string nombre, string estado)
        {
            return Municipios.Values
                .FirstOrDefault(m =>
                    NormalizarTexto(m.Nombre).Equals(NormalizarTexto(nombre),
                        StringComparison.OrdinalIgnoreCase) &&
                    NormalizarTexto(m.Estado).Equals(NormalizarTexto(estado),
                        StringComparison.OrdinalIgnoreCase));
        }

        /// Devuelve la lista de estados únicos tal como están en el CSV
        public List<string> ObtenerEstados() =>
            RegistrosHistoricos
                .Select(r => r.Estado)
                .Distinct()
                .OrderBy(e => e)
                .ToList();

        /// Devuelve los municipios que pertenecen a un estado (desde el JSON)
        public List<string> ObtenerMunicipiosPorEstado(string estado) =>
            Municipios.Values
                .Where(m => NormalizarTexto(m.Estado).Equals(NormalizarTexto(estado),
                            StringComparison.OrdinalIgnoreCase))
                .Select(m => m.Nombre)
                .OrderBy(n => n)
                .ToList();

        /// Filtra el histórico por estado, año y estación
        public List<RegistroClimatico> FiltrarHistorico(string estado, int anio, string estacion) =>
            RegistrosHistoricos
                .Where(r => NormalizarTexto(r.Estado).Equals(NormalizarTexto(estado),
                                StringComparison.OrdinalIgnoreCase)
                         && r.Periodo.Year == anio
                         && r.Estacion.Equals(estacion, StringComparison.OrdinalIgnoreCase))
                .ToList();

        /// Normaliza texto eliminando acentos para comparaciones robustas
        private static string NormalizarTexto(string texto)
        {
            var normalizado = texto.Normalize(System.Text.NormalizationForm.FormD);
            return new string(normalizado
                .Where(c => System.Globalization.CharUnicodeInfo.GetUnicodeCategory(c)
                            != System.Globalization.UnicodeCategory.NonSpacingMark)
                .ToArray())
                .ToUpperInvariant();
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

        // ── Lógica interna para estaciones ──────────────────────────────────

        /// Determina la estación del año basándose en el mes
        private string DeterminarEstacion(int mes)
        {
            return mes switch
            {
                12 or 1 or 2 => "Invierno",
                >= 3 and <= 5 => "Primavera",
                >= 6 and <= 8 => "Verano",
                >= 9 and <= 11 => "Otoño",
                _ => "Desconocida"
            };
        }
    }
}