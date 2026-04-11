using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.IO;
using System.Drawing;
using InteligenciaClimatica.Services;
using InteligenciaClimatica.Models;

namespace InteligenciaClimatica
{
    public partial class Form1 : Form
    {
        private DataService _dataService;
        private WeatherApiService _weatherService;
        public Form1()
        {
            InitializeComponent();
        }

        // ── Evento Load: Ocurre al abrir el programa ───────────────────────
        private void Form1_Load(object sender, EventArgs e)
        {
            string csvPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data", "data.csv");
            string jsonPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data", "municipios_mx.json");

            if (!File.Exists(csvPath) || !File.Exists(jsonPath))
            {
                MessageBox.Show(
                    $"No se encontraron los archivos.\n\nBuscando en:\n{csvPath}\n{jsonPath}",
                    "Archivos no encontrados",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            _dataService = new DataService(csvPath, jsonPath);
            _weatherService = new WeatherApiService();

            try
            {
                _dataService.CargarDatos();

                // Estados desde el CSV (con acentos y formato correcto)
                var estados = _dataService.ObtenerEstados();
                cmbEstado.Items.Clear();
                cmbEstado.Items.AddRange(estados.ToArray<object>());

                // Años desde el CSV
                var anios = _dataService.RegistrosHistoricos
                    .Select(r => r.Periodo.Year)
                    .Distinct()
                    .OrderByDescending(a => a)
                    .Select(a => a.ToString())
                    .ToArray();
                cmbAnio.Items.AddRange(anios);
                if (anios.Length > 0) cmbAnio.SelectedIndex = 0;

                cmbEstacion.SelectedIndex = 0;

                tssRegistros.Text = $"Registros cargados: {_dataService.RegistrosHistoricos.Count}";
                tssSQLite.Text = "SQLite: pendiente";
                tssAPI.Text = "Open-Meteo: en línea";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar los datos:\n{ex.Message}",
                    "Error de Inicialización", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ── Cuando el usuario selecciona un Municipio ──────────────────────
        private void cmbMunicipio_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (cmbMunicipio.SelectedItem == null || cmbEstado.SelectedItem == null) return;

            string municipio = cmbMunicipio.SelectedItem.ToString()!;
            string estado = cmbEstado.SelectedItem.ToString()!;

            var mun = _dataService.BuscarMunicipio(municipio, estado);
            if (mun != null)
            {
                lblMunicipioVal.Text = mun.Nombre;
                lblEstadoActVal.Text = mun.Estado;
                lblCoordsVal.Text = $"Lat: {mun.Latitud} · Lon: {mun.Longitud}";
            }
        }
        // ── Cuando el usuario selecciona un Estado ──────────────────────

        private void cmbEstado_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (cmbEstado.SelectedItem == null) return;

            string estado = cmbEstado.SelectedItem.ToString()!;

            var municipios = _dataService.ObtenerMunicipiosPorEstado(estado);

            cmbMunicipio.Items.Clear();
            cmbMunicipio.Items.AddRange(municipios.ToArray<object>());
            cmbMunicipio.Enabled = municipios.Count > 0;
            btnConsultar.Enabled = municipios.Count > 0;
            lblHintMunicipio.Visible = municipios.Count == 0;

            if (municipios.Count > 0)
                cmbMunicipio.SelectedIndex = 0;

            // Limpiar resultados anteriores
            LimpiarResultados();
        }


        // ── Cuando el usuario hace clic en "Consultar" ───────────────────── 

        private async void btnConsultar_Click_1(object sender, EventArgs e)
        {
            if (cmbEstado.SelectedItem == null ||
               cmbMunicipio.SelectedItem == null ||
               cmbAnio.SelectedItem == null ||
               cmbEstacion.SelectedItem == null) return;

            string estado = cmbEstado.SelectedItem.ToString()!;
            string municipio = cmbMunicipio.SelectedItem.ToString()!;
            int anio = int.Parse(cmbAnio.SelectedItem.ToString()!);
            string estacion = cmbEstacion.SelectedItem.ToString()!;

            btnConsultar.Enabled = false;
            btnConsultar.Text = "Consultando...";

            // ── 1. Datos históricos del CSV ──────────────────────────────────
            var registros = _dataService.FiltrarHistorico(estado, anio, estacion);

            if (registros.Any())
            {
                double promedio = registros.Average(r => r.PromedioC);
                double min = registros.Min(r => r.MinC);
                double max = registros.Max(r => r.MaxC);

                lblTempHistVal.Text = $"{promedio:F1}°C";
                lblMinHistVal.Text = $"{min:F1}°C";
                lblMaxHistVal.Text = $"{max:F1}°C";
                lblEstadoHistVal.Text = estado;
                lblFiltroVal.Text = $"{estacion} / {anio}";
                lblRegistrosVal.Text = $"Basado en {registros.Count} registros del CSV";
            }
            else
            {
                lblTempHistVal.Text = "N/A";
                lblMinHistVal.Text = "N/A";
                lblMaxHistVal.Text = "N/A";
                lblRegistrosVal.Text = "Sin registros para este filtro.";
            }

            // ── 2. Temperatura actual desde la API ───────────────────────────
            var mun = _dataService.BuscarMunicipio(municipio, estado);
            if (mun != null)
            {
                try
                {
                    var respuesta = await _weatherService.ObtenerClimaAsync(mun.Latitud, mun.Longitud);
                    var clima = respuesta?.Current ?? new ClimaActual();

                    lblTempActualVal.Text = $"{clima.Temperatura:F1}°C";
                    lblMinActVal.Text = $"{clima.TemperaturaAparente:F1}°C";
                    lblMaxActVal.Text = $"{clima.VelocidadViento:F1} km/h";
                    tssAPI.Text = "Open-Meteo: conectado ✓";

                    // ── 3. Calcular anomalía ─────────────────────────────────
                    if (registros.Any())
                    {
                        double promedio = registros.Average(r => r.PromedioC);
                        double desviacion = clima.Temperatura - promedio;
                        double umbral = (double)nudUmbral.Value;

                        lblDesviacionVal.Text = $"{(desviacion >= 0 ? "+" : "")}{desviacion:F1}°C";

                        // Semáforo
                        pnlSemaforoVerde.BackColor = Color.LightGray;
                        pnlSemaforoAmarillo.BackColor = Color.LightGray;
                        pnlSemaforoRojo.BackColor = Color.LightGray;

                        if (Math.Abs(desviacion) < umbral / 2)
                        {
                            pnlSemaforoVerde.BackColor = Color.Green;
                            lblSemaforoTexto.Text = "Normal";
                            lblDescAnomalia.Text = "Dentro del rango esperado";
                            lblDescAnomalia.ForeColor = Color.Green;
                            btnGuardarAlerta.Enabled = false;
                        }
                        else if (Math.Abs(desviacion) < umbral)
                        {
                            pnlSemaforoAmarillo.BackColor = Color.Orange;
                            lblSemaforoTexto.Text = "Moderada";
                            lblDescAnomalia.Text = "Desviación significativa";
                            lblDescAnomalia.ForeColor = Color.DarkOrange;
                            btnGuardarAlerta.Enabled = false;
                        }
                        else
                        {
                            pnlSemaforoRojo.BackColor = Color.Red;
                            lblSemaforoTexto.Text = $"Crítica — supera ±{umbral}°C";
                            lblDescAnomalia.Text = "Anomalía detectada";
                            lblDescAnomalia.ForeColor = Color.Firebrick;
                            btnGuardarAlerta.Enabled = true;
                        }
                    }
                }
                catch (Exception ex)
                {
                    lblTempActualVal.Text = "Error";
                    tssAPI.Text = "Open-Meteo: sin conexión";
                    MessageBox.Show($"No se pudo obtener el clima actual:\n{ex.Message}",
                        "Error de API", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

            btnConsultar.Enabled = true;
            btnConsultar.Text = "Consultar";
        }

        // ── Limpiar ─────────────────────────────────────────────────────────
        private void LimpiarResultados()
        {
            lblTempActualVal.Text = "—";
            lblTempHistVal.Text = "—";
            lblMinActVal.Text = "—";
            lblMaxActVal.Text = "—";
            lblMinHistVal.Text = "—";
            lblMaxHistVal.Text = "—";
            lblEstadoHistVal.Text = "—";
            lblFiltroVal.Text = "—";
            lblRegistrosVal.Text = "Basado en — registros del CSV";
            lblDesviacionVal.Text = "—";
            lblDescAnomalia.Text = "—";
            lblSemaforoTexto.Text = "—";
            lblMunicipioVal.Text = "—";
            lblEstadoActVal.Text = "—";
            lblCoordsVal.Text = "Lat: — · Lon: —";
            pnlSemaforoVerde.BackColor = Color.LightGray;
            pnlSemaforoAmarillo.BackColor = Color.LightGray;
            pnlSemaforoRojo.BackColor = Color.LightGray;
            btnGuardarAlerta.Enabled = false;
        }
    }
}