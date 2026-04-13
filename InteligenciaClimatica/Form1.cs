using InteligenciaClimatica.Models;
using InteligenciaClimatica.Services;
using MySqlConnector;
using System.Data;

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
            // Configuraciones iniciales de la interfaz
            this.AutoScaleMode = AutoScaleMode.None;
            btnProbarConexion.Click += btnProbarConexion_Click;
            btnGuardarConfig.Click += btnGuardarConfig_Click;
            btnGuardarAlerta.Click += btnGuardarAlerta_Click;
            btnLimpiar.Click += btnLimpiar_Click;

            //  Pestaña Análisis Global
            btnFiltrar.Click += btnFiltrar_Click;
            btnLimpiarFiltro.Click += btnLimpiarFiltro_Click;
            btnExportarRanking.Click += btnExportarRanking_Click;

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
                CargarDatosAnalisis();
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

            // 1. PRIMERO limpiamos la pantalla de cualquier consulta anterior
            LimpiarResultados();

            // 2. Obtenemos la lista del nuevo estado
            string estado = cmbEstado.SelectedItem.ToString()!;
            var municipios = _dataService.ObtenerMunicipiosPorEstado(estado);

            // 3. Llenamos el ComboBox secundario
            cmbMunicipio.Items.Clear();
            cmbMunicipio.Items.AddRange(municipios.ToArray<object>());
            cmbMunicipio.Enabled = municipios.Count > 0;
            btnConsultar.Enabled = municipios.Count > 0;

            // 4. Al seleccionar el primero, sus datos se escribirán en las etiquetas limpias (y ya no se borrarán)
            if (municipios.Count > 0)
            {
                cmbMunicipio.SelectedIndex = 0;
            }
        }

        private void cmbMunicipio_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            
            if (cmbMunicipio.SelectedItem == null || cmbEstado.SelectedItem == null) return;

            // 1. PRIMERO limpiamos cualquier cálculo, semáforo o temperatura de la consulta anterior
            LimpiarResultados();

            // 2. DESPUÉS obtenemos el nuevo municipio
            string municipio = cmbMunicipio.SelectedItem.ToString()!;
            string estado = cmbEstado.SelectedItem.ToString()!;
            var mun = _dataService.BuscarMunicipio(municipio, estado);

            // 3. Finalmente, reescribimos SÓLO los datos geográficos. 
            // Las temperaturas se quedarán en "—" obligando al usuario a presionar "Consultar"
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

                btnGuardarAlerta.Enabled = true;
                btnGuardarAlerta.Text = "Guardar alerta";
                btnGuardarAlerta.BackColor = Color.FromArgb(163, 45, 45);
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
            btnGuardarAlerta.Text = "Guardar alerta";
            btnGuardarAlerta.BackColor = Color.FromArgb(163, 45, 45);
        }
        // ══════════════════════════════════════════════════════════════════
        // PRUEBA DE CONEXIÓN A BASE DE DATOS
        // ══════════════════════════════════════════════════════════════════

        private void btnProbarConexion_Click(object? sender, EventArgs e)
        {
            // 1. Cambiamos el estado visual a "procesando"
            lblEstadoConexion.Text = "Estado: Probando conexión...";
            lblEstadoConexion.ForeColor = Color.FromArgb(186, 117, 23); // Amarillo/Naranja
            Application.DoEvents(); // Fuerza a la interfaz a dibujar el texto de inmediato

            // 2. Instanciamos nuestra capa de servicios
            var dbService = new DatabaseService();
            string resultado = "";

            // 3. Verificamos qué motor seleccionó el usuario en el ComboBox
            if (cmbMotorBD.SelectedItem != null && cmbMotorBD.SelectedItem.ToString() == "SQLite")
            {
                resultado = dbService.ProbarConexionSQLite(txtSQLitePath.Text);
            }
            else
            {
                resultado = dbService.ProbarConexionMariaDB(
                    txtMariaServidor.Text,
                    txtMariaPuerto.Text,
                    txtMariaBD.Text,
                    txtMariaUsuario.Text,
                    txtMariaPassword.Text
                );
            }

            // 4. Evaluamos el resultado y actualizamos la interfaz
            if (resultado == "OK")
            {
                lblEstadoConexion.Text = "Estado: Conectado ✓";
                lblEstadoConexion.ForeColor = Color.FromArgb(99, 153, 34); // Verde éxito

                MessageBox.Show("¡La conexión a la base de datos fue exitosa!",
                    "Prueba superada", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                lblEstadoConexion.Text = "Estado: Error de conexión ✗";
                lblEstadoConexion.ForeColor = Color.FromArgb(163, 45, 45); // Rojo error

                MessageBox.Show($"No se pudo establecer la conexión. Detalles del error:\n\n{resultado}",
                    "Fallo de Conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnGuardarConfig_Click(object? sender, EventArgs e)
        {
            try
            {
                // 1. Recolectar datos de la interfaz
                var configuracion = new
                {
                    Motor = cmbMotorBD.SelectedItem?.ToString() ?? "SQLite",
                    Umbral = (double)nudUmbral.Value,
                    RutaCSV = txtRutaCSV.Text,
                    RutaJSON = txtRutaJSON.Text
                };

                // 2. Aquí llamarías a tu DatabaseService para hacer el UPDATE en SQLite
               
                ActualizarEstadoSQLite("SQLite: OK (Configurada)");

                MessageBox.Show("Configuración guardada correctamente en el entorno local.",
                    "Sistema Actualizado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private async void btnGuardarAlerta_Click(object? sender, EventArgs e)
        {
            try
            {
                // 1. Limpiamos los textos de la interfaz (quitamos el "°C" y el símbolo "+") 
                // para poder convertirlos en números puros
                double actual = double.Parse(lblTempActualVal.Text.Replace("°C", ""));
                double hist = double.Parse(lblTempHistVal.Text.Replace("°C", ""));
                double anom = double.Parse(lblDesviacionVal.Text.Replace("°C", "").Replace("+", ""));

                // 2. Llamamos a nuestro servicio
                var dbService = new DatabaseService();

                dbService.GuardarAlertaMariaDB(
                    txtMariaServidor.Text,
                    txtMariaPuerto.Text,
                    txtMariaBD.Text,
                    txtMariaUsuario.Text,
                    txtMariaPassword.Text,
                    lblMunicipioVal.Text,
                    lblEstadoActVal.Text,
                    actual,
                    hist,
                    anom
                );

                MessageBox.Show("La alerta crítica ha sido registrada exitosamente en el servidor de auditoría.",
                    "Alerta Guardada", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // 2. ESTADO DE ÉXITO: Lo ponemos verde y cambiamos el texto
                btnGuardarAlerta.Enabled = false;
                btnGuardarAlerta.Text = "Alerta enviada ✓";
                btnGuardarAlerta.BackColor = Color.FromArgb(99, 153, 34); // Verde

                // 3. ESPERA: Aguardamos 2 segundos para que alcances a ver el mensaje
                await Task.Delay(2000);

                // 4. RESET AUTOMÁTICO: Vuelve a su estado original
                btnGuardarAlerta.Text = "Guardar alerta";
                btnGuardarAlerta.BackColor = Color.FromArgb(163, 45, 45); // Rojo original
                btnGuardarAlerta.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar la alerta en MariaDB:\n\n{ex.Message}\n\nVerifica que la tabla exista y la conexión esté activa.",
                    "Error de Servidor", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnLimpiar_Click(object? sender, EventArgs e)
        {

            // 1. "Soltar" la selección de Estado y Municipio (SIN borrar las listas)
            cmbEstado.SelectedIndex = -1;
            cmbMunicipio.SelectedIndex = -1;
            cmbMunicipio.Enabled = false; // Lo bloqueamos visualmente hasta que elijan otro estado

            // 2. Resetear filtros temporales
            if (cmbAnio.Items.Count > 0) cmbAnio.SelectedIndex = 0;
            if (cmbEstacion.Items.Count > 0) cmbEstacion.SelectedIndex = 0;

            // 3. Resetear el botón de Alerta a su estado original (Rojo y Deshabilitado)
            btnGuardarAlerta.Enabled = false;
            btnGuardarAlerta.Text = "Guardar alerta";
            btnGuardarAlerta.BackColor = Color.FromArgb(163, 45, 45); // El rojo original de tu diseño

            // 4. Bloquear consulta y ejecutar limpieza de etiquetas
            btnConsultar.Enabled = false;
            LimpiarResultados(); // Este es el método que ya tienes que pone los guiones "—"
        }
        // ══════════════════════════════════════════════════════════════════
        // PESTAÑA: ANÁLISIS GLOBAL
        // ══════════════════════════════════════════════════════════════════

        private void CargarDatosAnalisis()
        {
            // Verificamos que el CSV/JSON ya se haya cargado en memoria
            if (_dataService == null || !_dataService.RegistrosHistoricos.Any()) return;

            // Tomamos la sábana completa de datos
            var query = _dataService.RegistrosHistoricos.AsEnumerable();

            // 1. Filtro por Año
            if (cmbFiltroAnio.SelectedItem != null && cmbFiltroAnio.SelectedItem.ToString() != "Todos")
            {
                int anioSel = int.Parse(cmbFiltroAnio.SelectedItem.ToString()!);
                query = query.Where(r => r.Periodo.Year == anioSel);
            }

            // 2. Filtro por Estación
            if (cmbFiltroEstacion.SelectedItem != null && cmbFiltroEstacion.SelectedItem.ToString() != "Todas")
            {
                string estacionSel = cmbFiltroEstacion.SelectedItem.ToString()!;
                query = query.Where(r => r.Estacion.Equals(estacionSel, StringComparison.OrdinalIgnoreCase));
            }

            // 3. Filtro por Estado (Texto libre)
            if (!string.IsNullOrWhiteSpace(txtBuscarEstado.Text))
            {
                string busqueda = txtBuscarEstado.Text.Trim().ToLower();
                query = query.Where(r => r.Estado.ToLower().Contains(busqueda));
            }

            // Ejecutamos la consulta y la convertimos en lista
            var datosFiltrados = query.ToList();

            // Generamos gráficos en lugar de DataGridView
            GenerarGraficos(datosFiltrados);

            // Llamamos a la función que calcula los Top 5
            ActualizarRankings(datosFiltrados);
        }

        private void GenerarGraficos(List<RegistroClimatico> datos)
        {
            if (!datos.Any()) return;

            // Agrupar datos por Estado para obtener promedios
            var datosPorEstado = datos
                .GroupBy(r => r.Estado)
                .Select(g => new
                {
                    Estado = g.Key,
                    PromedioMax = g.Average(r => r.MaxC),
                    PromedioMin = g.Average(r => r.MinC),
                    PromedioTemp = g.Average(r => r.PromedioC)
                })
                .OrderByDescending(d => d.PromedioMax)
                .Take(10) // Top 10 Estados
                .ToList();

            // Limpiar controles anteriores
            dgvHistorico.DataSource = null;

            // Crear tabla con los datos agrupados para mostrar
            var tablaresumen = datosPorEstado.Select(d => new
            {
                Estado = d.Estado,
                Máxima = $"{d.PromedioMax:F1}°C",
                Mínima = $"{d.PromedioMin:F1}°C",
                Promedio = $"{d.PromedioTemp:F1}°C"
            }).ToList();

            dgvHistorico.DataSource = tablaresumen;
        }

        private void ActualizarRankings(List<RegistroClimatico> datos)
        {
            // Limpiamos las listas visuales
            lstCalientes.Items.Clear();
            lstFrios.Items.Clear();

            if (!datos.Any()) return;

            // Top 5 más Calientes (Ordenamos por Temp Máxima de mayor a menor)
            var topCalientes = datos.OrderByDescending(r => r.MaxC).Take(5).ToList();
            foreach (var r in topCalientes)
            {
                lstCalientes.Items.Add($"{r.Estado} - {r.MaxC:F1}°C [{r.Periodo:yyyy-MM-dd}]");
            }

            // Top 5 más Fríos (Ordenamos por Temp Mínima de menor a mayor)
            var topFrios = datos.OrderBy(r => r.MinC).Take(5).ToList();
            foreach (var r in topFrios)
            {
                lstFrios.Items.Add($"{r.Estado} - {r.MinC:F1}°C [{r.Periodo:yyyy-MM-dd}]");
            }
        }
        private void btnFiltrar_Click(object? sender, EventArgs e)
        {
            // Ejecuta el motor con los filtros actuales
            CargarDatosAnalisis();
        }

        private void btnLimpiarFiltro_Click(object? sender, EventArgs e)
        {
            // 1. Regresamos los controles a su estado neutral
            if (cmbFiltroAnio.Items.Count > 0) cmbFiltroAnio.SelectedIndex = 0;
            if (cmbFiltroEstacion.Items.Count > 0) cmbFiltroEstacion.SelectedIndex = 0;
            txtBuscarEstado.Clear();

            // 2. Volvemos a cargar la tabla completa sin filtros
            CargarDatosAnalisis();
        }
        private async void btnExportarRanking_Click(object? sender, EventArgs e)
        {
            try
            {
                // Obtenemos los datos actuales que ya están filtrados en la pantalla
                var datosActuales = dgvHistorico.DataSource as List<RegistroClimatico>;
                if (datosActuales == null || !datosActuales.Any())
                {
                    MessageBox.Show("No hay datos filtrados para exportar.");
                    return;
                }

                var topCalientes = datosActuales.OrderByDescending(r => r.MaxC).Take(5).ToList();
                var topFrios = datosActuales.OrderBy(r => r.MinC).Take(5).ToList();

                var dbService = new DatabaseService();
                dbService.GuardarRankingMariaDB(
                    txtMariaServidor.Text, txtMariaPuerto.Text, txtMariaBD.Text,
                    txtMariaUsuario.Text, txtMariaPassword.Text,
                    topFrios, topCalientes
                );

                btnExportarRanking.Text = "¡Ranking Enviado!";
                btnExportarRanking.BackColor = Color.Green;
                await Task.Delay(2000);
                btnExportarRanking.Text = "Exportar Ranking a MariaDB";
                btnExportarRanking.BackColor = Color.FromArgb(45, 100, 163); // Tu azul original
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al exportar: " + ex.Message);
            }
        }
    }
    
}