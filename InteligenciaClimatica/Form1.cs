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

        // Rastrea el botón de navegación activo
        private Button _activeNavBtn;

        public Form1()
        {
            InitializeComponent();

            // Línea separadora inferior del top bar
            pnlTopBar.Paint += (s, e) =>
            {
                using var pen = new Pen(Color.FromArgb(220, 225, 235));
                e.Graphics.DrawLine(pen, 0, pnlTopBar.Height - 1, pnlTopBar.Width, pnlTopBar.Height - 1);
            };
        }

        // ══════════════════════════════════════════════════════════════════
        // CARGA INICIAL
        // ══════════════════════════════════════════════════════════════════

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

                // Poblar estados desde el CSV
                var estados = _dataService.ObtenerEstados();
                cmbEstado.Items.Clear();
                cmbEstado.Items.AddRange(estados.ToArray<object>());

                // También poblar el combo de favoritos
                cmbNuevoFavEstado.Items.Clear();
                cmbNuevoFavEstado.Items.AddRange(estados.ToArray<object>());

                // Años desde el CSV
                var anios = _dataService.RegistrosHistoricos
                    .Select(r => r.Periodo.Year)
                    .Distinct()
                    .OrderByDescending(a => a)
                    .Select(a => a.ToString())
                    .ToArray();

                cmbAnio.Items.AddRange(anios);
                cmbFiltroAnio.Items.Add("Todos");
                cmbFiltroAnio.Items.AddRange(anios);

                if (anios.Length > 0) cmbAnio.SelectedIndex = 0;
                cmbEstacion.SelectedIndex = 0;
                cmbFiltroAnio.SelectedIndex = 0;
                cmbFiltroEstacion.SelectedIndex = 0;

                // Estado inicial de la barra lateral
                _activeNavBtn = btnNavConsulta;
                AplicarEstadoActivo(btnNavConsulta);

                // Status strip + barra lateral
                ActualizarEstadoAPI("Open-Meteo: en línea");
                ActualizarEstadoSQLite("SQLite: pendiente");
                ActualizarRegistros(_dataService.RegistrosHistoricos.Count);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar los datos:\n{ex.Message}",
                    "Error de Inicialización", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ══════════════════════════════════════════════════════════════════
        // NAVEGACIÓN LATERAL
        // ══════════════════════════════════════════════════════════════════

        private void btnNavConsulta_Click(object sender, EventArgs e)
            => NavHacia(btnNavConsulta, tabConsulta,
                "Consulta climática",
                "Compara temperatura actual vs. promedio histórico por municipio");

        private void btnNavAnalisis_Click(object sender, EventArgs e)
            => NavHacia(btnNavAnalisis, tabAnalisis,
                "Análisis global",
                "Explora el histórico completo con filtros de año y estación");

        private void btnNavFavoritos_Click(object sender, EventArgs e)
            => NavHacia(btnNavFavoritos, tabFavoritos,
                "Municipios favoritos",
                "Accede rápidamente a tus ubicaciones guardadas");

        private void btnNavConfig_Click(object sender, EventArgs e)
            => NavHacia(btnNavConfig, tabConfig,
                "Configuración",
                "Base de datos, archivos de datos y preferencias del sistema");

        /// Cambia la pestaña activa y actualiza el estado visual del sidebar.
        private void NavHacia(Button btnDestino, TabPage tabDestino,
                              string titulo, string descripcion)
        {
            tabControl.SelectedTab = tabDestino;

            // Desactivar botón anterior
            if (_activeNavBtn != null)
                AplicarEstadoInactivo(_activeNavBtn);

            // Activar nuevo botón
            AplicarEstadoActivo(btnDestino);
            _activeNavBtn = btnDestino;

            // Actualizar topbar
            lblTopBarTitle.Text = titulo;
            lblTopBarCrumb.Text = descripcion;
        }

        private static void AplicarEstadoActivo(Button btn)
        {
            btn.BackColor = Color.FromArgb(20, 55, 100);
            btn.ForeColor = Color.FromArgb(133, 183, 235);
        }

        private static void AplicarEstadoInactivo(Button btn)
        {
            btn.BackColor = Color.FromArgb(15, 27, 45);
            btn.ForeColor = Color.FromArgb(140, 160, 185);
        }

        // ══════════════════════════════════════════════════════════════════
        // HELPERS DE ESTADO (StatusStrip + sidebar sincronizados)
        // ══════════════════════════════════════════════════════════════════

        private void ActualizarEstadoAPI(string texto)
        {
            tssAPI.Text = texto;
            bool activo = texto.Contains("línea") || texto.Contains("conectado");
            lblSidebarStatusAPI.Text = $"● {texto}";
            lblSidebarStatusAPI.ForeColor = activo
                ? Color.FromArgb(99, 153, 34)
                : Color.FromArgb(163, 45, 45);
        }

        private void ActualizarEstadoSQLite(string texto)
        {
            tssSQLite.Text = texto;
            lblSidebarStatusSQLite.Text = $"● {texto}";
            lblSidebarStatusSQLite.ForeColor = texto.Contains("OK") || texto.Contains("activo")
                ? Color.FromArgb(99, 153, 34)
                : Color.FromArgb(186, 117, 23);
        }

        private void ActualizarRegistros(int cantidad)
        {
            tssRegistros.Text = $"Registros cargados: {cantidad:N0}";
            lblSidebarStatusRegs.Text = $"{cantidad:N0} registros cargados";
        }

        // ══════════════════════════════════════════════════════════════════
        // EVENTOS DE COMBOS
        // ══════════════════════════════════════════════════════════════════

        private void cmbEstado_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (cmbEstado.SelectedItem == null) return;

            string estado = cmbEstado.SelectedItem.ToString()!;
            var municipios = _dataService.ObtenerMunicipiosPorEstado(estado);

            cmbMunicipio.Items.Clear();
            cmbMunicipio.Items.AddRange(municipios.ToArray<object>());
            cmbMunicipio.Enabled = municipios.Count > 0;
            btnConsultar.Enabled = municipios.Count > 0;

            if (municipios.Count > 0)
                cmbMunicipio.SelectedIndex = 0;

            LimpiarResultados();
        }

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
                lblCoordsVal.Text = $"Lat: {mun.Latitud:F4} · Lon: {mun.Longitud:F4}";
            }
        }

        // ══════════════════════════════════════════════════════════════════
        // CONSULTA PRINCIPAL
        // ══════════════════════════════════════════════════════════════════

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

            // ── 1. Datos históricos del CSV ──────────────────────────────
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

            // ── 2. Temperatura actual desde la API ───────────────────────
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

                    ActualizarEstadoAPI("Open-Meteo: conectado ✓");

                    // ── 3. Calcular anomalía ─────────────────────────────
                    if (registros.Any())
                    {
                        double promedio = registros.Average(r => r.PromedioC);
                        double desviacion = clima.Temperatura - promedio;
                        double umbral = (double)nudUmbral.Value;

                        lblDesviacionVal.Text = $"{(desviacion >= 0 ? "+" : "")}{desviacion:F1}°C";

                        // Resetear semáforo
                        var colorApagado = Color.FromArgb(210, 220, 215);
                        pnlSemaforoVerde.BackColor = colorApagado;
                        pnlSemaforoAmarillo.BackColor = colorApagado;
                        pnlSemaforoRojo.BackColor = colorApagado;

                        if (Math.Abs(desviacion) < umbral / 2)
                        {
                            pnlSemaforoVerde.BackColor = Color.FromArgb(99, 153, 34);
                            lblSemaforoTexto.Text = "Normal";
                            lblSemaforoTexto.ForeColor = Color.FromArgb(59, 109, 17);
                            lblDescAnomalia.Text = "Dentro del rango esperado para la estación";
                            lblDescAnomalia.ForeColor = Color.FromArgb(59, 109, 17);
                            btnGuardarAlerta.Enabled = false;
                        }
                        else if (Math.Abs(desviacion) < umbral)
                        {
                            pnlSemaforoAmarillo.BackColor = Color.FromArgb(186, 117, 23);
                            lblSemaforoTexto.Text = "Moderada";
                            lblSemaforoTexto.ForeColor = Color.FromArgb(154, 88, 8);
                            lblDescAnomalia.Text = "Desviación significativa respecto al histórico";
                            lblDescAnomalia.ForeColor = Color.FromArgb(154, 88, 8);
                            btnGuardarAlerta.Enabled = false;
                        }
                        else
                        {
                            pnlSemaforoRojo.BackColor = Color.FromArgb(163, 45, 45);
                            lblSemaforoTexto.Text = $"Crítica  ±{umbral}°C";
                            lblSemaforoTexto.ForeColor = Color.FromArgb(130, 30, 30);
                            lblDescAnomalia.Text = "Anomalía detectada — supera el umbral definido";
                            lblDescAnomalia.ForeColor = Color.FromArgb(130, 30, 30);
                            btnGuardarAlerta.Enabled = true;
                        }
                    }
                }
                catch (Exception ex)
                {
                    lblTempActualVal.Text = "Error";
                    ActualizarEstadoAPI("Open-Meteo: sin conexión");
                    MessageBox.Show($"No se pudo obtener el clima actual:\n{ex.Message}",
                        "Error de API", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

            btnConsultar.Enabled = true;
            btnConsultar.Text = "Consultar";
        }

        // ══════════════════════════════════════════════════════════════════
        // LIMPIAR RESULTADOS
        // ══════════════════════════════════════════════════════════════════

        private void LimpiarResultados()
        {
            var apagado = Color.FromArgb(210, 220, 215);

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
            lblDescAnomalia.Text = "Realiza una consulta para evaluar el riesgo climático.";
            lblDescAnomalia.ForeColor = Color.FromArgb(140, 155, 175);
            lblSemaforoTexto.Text = "—";
            lblSemaforoTexto.ForeColor = Color.FromArgb(90, 105, 125);
            lblMunicipioVal.Text = "—";
            lblEstadoActVal.Text = "—";
            lblCoordsVal.Text = "Lat: — · Lon: —";

            pnlSemaforoVerde.BackColor = apagado;
            pnlSemaforoAmarillo.BackColor = apagado;
            pnlSemaforoRojo.BackColor = apagado;

            btnGuardarAlerta.Enabled = false;
        }
    }
}