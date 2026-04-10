using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using InteligenciaClimatica.Services;
using InteligenciaClimatica.Models;

namespace InteligenciaClimatica
{
    public partial class Form1 : Form
    {
        // 1. Instancia global de nuestro motor de datos
        private DataService _dataService;

        public Form1()
        {
            InitializeComponent();
        }

        // ── Evento Load: Ocurre al abrir el programa ───────────────────────
        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("¡El evento Load sí se está ejecutando!");
            string csvPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data", "data.csv");
            string jsonPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data", "municipios_mx.json");

            // Revisamos si existen antes de intentar cargar
            if (!File.Exists(csvPath) || !File.Exists(jsonPath))
            {
                MessageBox.Show($"No se encontraron los archivos.\n\nBuscando en:\n{csvPath}\n{jsonPath}", "Archivos no encontrados", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            _dataService = new DataService(csvPath, jsonPath);

            try
            {
                _dataService.CargarDatos();
                tssRegistros.Text = $"Registros cargados: {_dataService.RegistrosHistoricos.Count}";

                // Llenar ComboBox de Estados
                var estados = _dataService.Municipios.Values
                                          .Select(m => m.Estado)
                                          .Distinct()
                                          .OrderBy(estado => estado)
                                          .ToArray();
                cmbEstado.Items.AddRange(estados);

                // Llenar ComboBox de Años obteniéndolos del CSV
                var anios = _dataService.RegistrosHistoricos
                                        .Select(r => r.Periodo.Year)
                                        .Distinct()
                                        .OrderByDescending(anio => anio)
                                        .Select(anio => anio.ToString())
                                        .ToArray();
                cmbAnio.Items.AddRange(anios);

                if (anios.Length > 0) cmbAnio.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar los datos: {ex.Message}\n\nVerifica las rutas en la pestaña Configuración.", "Error de Inicialización", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ── Cuando el usuario selecciona un Municipio ──────────────────────
        private void cmbMunicipio_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            // Asegurarnos de que haya un municipio y un estado seleccionados
            if (cmbMunicipio.SelectedItem == null || cmbEstado.SelectedItem == null) return;

            string municipioSeleccionado = cmbMunicipio.SelectedItem.ToString();
            string estadoSeleccionado = cmbEstado.SelectedItem.ToString();

            // Ahora le pasamos ambos parámetros para que encuentre el correcto
            var municipio = _dataService.BuscarMunicipio(municipioSeleccionado, estadoSeleccionado);

            if (municipio != null)
            {
                // Actualizar las etiquetas de Datos Actuales preparándolas para la API
                lblCoordsVal.Text = $"Lat: {municipio.Latitud} · Lon: {municipio.Longitud}";
                lblMunicipioVal.Text = municipio.Nombre;
                lblEstadoActVal.Text = municipio.Estado;
            }
        }
        // ── Cuando el usuario selecciona un Estado ──────────────────────

        private void cmbEstado_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (cmbEstado.SelectedItem == null) return;

            string estadoSeleccionado = cmbEstado.SelectedItem.ToString();

            // Filtrar municipios que pertenecen al estado seleccionado
            var municipiosDelEstado = _dataService.Municipios.Values
                                               .Where(m => m.Estado.Equals(estadoSeleccionado, StringComparison.OrdinalIgnoreCase))
                                               .Select(m => m.Nombre)
                                               .OrderBy(nombre => nombre)
                                               .ToArray();

            // Llenar y habilitar el ComboBox de Municipios
            cmbMunicipio.Items.Clear();
            cmbMunicipio.Items.AddRange(municipiosDelEstado);
            cmbMunicipio.Enabled = true;
            btnConsultar.Enabled = true;

            if (municipiosDelEstado.Length > 0)
                cmbMunicipio.SelectedIndex = 0;
        }


        // ── Cuando el usuario hace clic en "Consultar" ─────────────────────

        private void btnConsultar_Click_1(object sender, EventArgs e)
        {
            if (cmbEstado.SelectedItem == null || cmbAnio.SelectedItem == null || cmbEstacion.SelectedItem == null)
                return;

            string estado = cmbEstado.SelectedItem.ToString();
            int anio = int.Parse(cmbAnio.SelectedItem.ToString());
            string estacion = cmbEstacion.SelectedItem.ToString();

            // 1. Mostrar datos Históricos (Paso 3)
            var registrosFiltrados = _dataService.FiltrarPorEstadoYEstacion(estado, estacion)
                                                 .Where(r => r.Periodo.Year == anio)
                                                 .ToList();

            if (registrosFiltrados.Any())
            {
                double promedio = registrosFiltrados.Average(r => r.PromedioC);
                double min = registrosFiltrados.Min(r => r.MinC);
                double max = registrosFiltrados.Max(r => r.MaxC);

                lblTempHistVal.Text = $"{promedio:F1}°C";
                lblMinHistVal.Text = $"{min:F1}°C";
                lblMaxHistVal.Text = $"{max:F1}°C";
                lblEstadoHistVal.Text = estado;
                lblFiltroVal.Text = $"{estacion} / {anio}";
                lblRegistrosVal.Text = $"Basado en {registrosFiltrados.Count} registros del CSV";
            }
            else
            {
                lblTempHistVal.Text = "N/A";
                lblMinHistVal.Text = "N/A";
                lblMaxHistVal.Text = "N/A";
                lblRegistrosVal.Text = "Sin registros para este filtro.";
            }
        }
    }
}