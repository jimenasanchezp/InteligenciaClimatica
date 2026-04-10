namespace InteligenciaClimatica
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            // ── Controles principales ────────────────────────────────────────────
            this.tabControl = new System.Windows.Forms.TabControl();

            // ── Tab: Consulta Individual ─────────────────────────────────────────
            this.tabConsulta = new System.Windows.Forms.TabPage();
            this.grpBusqueda = new System.Windows.Forms.GroupBox();
            this.lblEstado = new System.Windows.Forms.Label();
            this.cmbEstado = new System.Windows.Forms.ComboBox();
            this.lblMunicipio = new System.Windows.Forms.Label();
            this.cmbMunicipio = new System.Windows.Forms.ComboBox();
            this.lblAnio = new System.Windows.Forms.Label();
            this.cmbAnio = new System.Windows.Forms.ComboBox();
            this.lblEstacion = new System.Windows.Forms.Label();
            this.cmbEstacion = new System.Windows.Forms.ComboBox();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.lblHintMunicipio = new System.Windows.Forms.Label();

            this.grpDatosActuales = new System.Windows.Forms.GroupBox();
            this.lblFuenteAPI = new System.Windows.Forms.Label();
            this.lblTempActualVal = new System.Windows.Forms.Label();
            this.lblTempActualSub = new System.Windows.Forms.Label();
            this.lblMunicipioKey = new System.Windows.Forms.Label();
            this.lblMunicipioVal = new System.Windows.Forms.Label();
            this.lblEstadoActKey = new System.Windows.Forms.Label();
            this.lblEstadoActVal = new System.Windows.Forms.Label();
            this.lblMinActKey = new System.Windows.Forms.Label();
            this.lblMinActVal = new System.Windows.Forms.Label();
            this.lblMaxActKey = new System.Windows.Forms.Label();
            this.lblMaxActVal = new System.Windows.Forms.Label();
            this.lblCoordsVal = new System.Windows.Forms.Label();

            this.grpHistorico = new System.Windows.Forms.GroupBox();
            this.lblFuenteCSV = new System.Windows.Forms.Label();
            this.lblTempHistVal = new System.Windows.Forms.Label();
            this.lblTempHistSub = new System.Windows.Forms.Label();
            this.lblEstadoHistKey = new System.Windows.Forms.Label();
            this.lblEstadoHistVal = new System.Windows.Forms.Label();
            this.lblFiltroKey = new System.Windows.Forms.Label();
            this.lblFiltroVal = new System.Windows.Forms.Label();
            this.lblMinHistKey = new System.Windows.Forms.Label();
            this.lblMinHistVal = new System.Windows.Forms.Label();
            this.lblMaxHistKey = new System.Windows.Forms.Label();
            this.lblMaxHistVal = new System.Windows.Forms.Label();
            this.lblRegistrosVal = new System.Windows.Forms.Label();

            this.grpAnomalia = new System.Windows.Forms.GroupBox();
            this.lblDesviacionKey = new System.Windows.Forms.Label();
            this.lblDesviacionVal = new System.Windows.Forms.Label();
            this.lblDescAnomalia = new System.Windows.Forms.Label();
            this.lblNivelKey = new System.Windows.Forms.Label();
            this.pnlSemaforoVerde = new System.Windows.Forms.Panel();
            this.pnlSemaforoAmarillo = new System.Windows.Forms.Panel();
            this.pnlSemaforoRojo = new System.Windows.Forms.Panel();
            this.lblSemaforoTexto = new System.Windows.Forms.Label();
            this.btnGuardarAlerta = new System.Windows.Forms.Button();

            // ── Tab: Análisis Global ─────────────────────────────────────────────
            this.tabAnalisis = new System.Windows.Forms.TabPage();
            this.grpFiltrosGlobal = new System.Windows.Forms.GroupBox();
            this.lblFiltroAnio = new System.Windows.Forms.Label();
            this.cmbFiltroAnio = new System.Windows.Forms.ComboBox();
            this.lblFiltroEstacion = new System.Windows.Forms.Label();
            this.cmbFiltroEstacion = new System.Windows.Forms.ComboBox();
            this.lblBuscarEstado = new System.Windows.Forms.Label();
            this.txtBuscarEstado = new System.Windows.Forms.TextBox();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.btnLimpiarFiltro = new System.Windows.Forms.Button();
            this.dgvHistorico = new System.Windows.Forms.DataGridView();
            this.grpRanking = new System.Windows.Forms.GroupBox();
            this.lblRankingCaliente = new System.Windows.Forms.Label();
            this.lstCalientes = new System.Windows.Forms.ListBox();
            this.lblRankingFrio = new System.Windows.Forms.Label();
            this.lstFrios = new System.Windows.Forms.ListBox();

            // ── Tab: Favoritos ───────────────────────────────────────────────────
            this.tabFavoritos = new System.Windows.Forms.TabPage();
            this.dgvFavoritos = new System.Windows.Forms.DataGridView();
            this.grpAgregarFav = new System.Windows.Forms.GroupBox();
            this.lblNuevoFavEstado = new System.Windows.Forms.Label();
            this.cmbNuevoFavEstado = new System.Windows.Forms.ComboBox();
            this.lblNuevoFavMun = new System.Windows.Forms.Label();
            this.cmbNuevoFavMun = new System.Windows.Forms.ComboBox();
            this.btnAgregarFav = new System.Windows.Forms.Button();
            this.btnEliminarFav = new System.Windows.Forms.Button();

            // ── Tab: Configuración ───────────────────────────────────────────────
            this.tabConfig = new System.Windows.Forms.TabPage();
            this.grpConexion = new System.Windows.Forms.GroupBox();
            this.lblCadenaConexion = new System.Windows.Forms.Label();
            this.txtCadenaConexion = new System.Windows.Forms.TextBox();
            this.btnProbarConexion = new System.Windows.Forms.Button();
            this.lblEstadoConexion = new System.Windows.Forms.Label();
            this.grpArchivos = new System.Windows.Forms.GroupBox();
            this.lblRutaCSV = new System.Windows.Forms.Label();
            this.txtRutaCSV = new System.Windows.Forms.TextBox();
            this.btnExplorarCSV = new System.Windows.Forms.Button();
            this.lblRutaJSON = new System.Windows.Forms.Label();
            this.txtRutaJSON = new System.Windows.Forms.TextBox();
            this.btnExplorarJSON = new System.Windows.Forms.Button();
            this.grpPreferencias = new System.Windows.Forms.GroupBox();
            this.lblUmbral = new System.Windows.Forms.Label();
            this.nudUmbral = new System.Windows.Forms.NumericUpDown();
            this.lblUmbralSufijo = new System.Windows.Forms.Label();
            this.lblUnidades = new System.Windows.Forms.Label();
            this.rbCelsius = new System.Windows.Forms.RadioButton();
            this.rbFahrenheit = new System.Windows.Forms.RadioButton();
            this.btnGuardarConfig = new System.Windows.Forms.Button();

            // ── StatusStrip ─────────────────────────────────────────────────────
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.tssSQLite = new System.Windows.Forms.ToolStripStatusLabel();
            this.tssSQLServer = new System.Windows.Forms.ToolStripStatusLabel();
            this.tssAPI = new System.Windows.Forms.ToolStripStatusLabel();
            this.tssRegistros = new System.Windows.Forms.ToolStripStatusLabel();

            // ════════════════════════════════════════════════════════════════════
            this.tabControl.SuspendLayout();
            this.tabConsulta.SuspendLayout();
            this.tabAnalisis.SuspendLayout();
            this.tabFavoritos.SuspendLayout();
            this.tabConfig.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)this.dgvHistorico).BeginInit();
            ((System.ComponentModel.ISupportInitialize)this.dgvFavoritos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)this.nudUmbral).BeginInit();
            this.SuspendLayout();

            // ════════════════════════════════════════════════════════════════════
            // TAB CONTROL
            // ════════════════════════════════════════════════════════════════════
            this.tabControl.Controls.Add(this.tabConsulta);
            this.tabControl.Controls.Add(this.tabAnalisis);
            this.tabControl.Controls.Add(this.tabFavoritos);
            this.tabControl.Controls.Add(this.tabConfig);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.Size = new System.Drawing.Size(900, 620);
            this.tabControl.TabIndex = 0;

            // ════════════════════════════════════════════════════════════════════
            // TAB 1 — CONSULTA INDIVIDUAL
            // ════════════════════════════════════════════════════════════════════
            this.tabConsulta.Controls.Add(this.grpBusqueda);
            this.tabConsulta.Controls.Add(this.grpDatosActuales);
            this.tabConsulta.Controls.Add(this.grpHistorico);
            this.tabConsulta.Controls.Add(this.grpAnomalia);
            this.tabConsulta.Location = new System.Drawing.Point(4, 24);
            this.tabConsulta.Name = "tabConsulta";
            this.tabConsulta.Padding = new System.Windows.Forms.Padding(8);
            this.tabConsulta.Size = new System.Drawing.Size(892, 592);
            this.tabConsulta.Text = "Consulta Individual";

            // ── GroupBox Búsqueda ────────────────────────────────────────────────
            this.grpBusqueda.Controls.Add(this.lblEstado);
            this.grpBusqueda.Controls.Add(this.cmbEstado);
            this.grpBusqueda.Controls.Add(this.lblMunicipio);
            this.grpBusqueda.Controls.Add(this.cmbMunicipio);
            this.grpBusqueda.Controls.Add(this.lblAnio);
            this.grpBusqueda.Controls.Add(this.cmbAnio);
            this.grpBusqueda.Controls.Add(this.lblEstacion);
            this.grpBusqueda.Controls.Add(this.cmbEstacion);
            this.grpBusqueda.Controls.Add(this.btnConsultar);
            this.grpBusqueda.Controls.Add(this.btnLimpiar);
            this.grpBusqueda.Controls.Add(this.lblHintMunicipio);
            this.grpBusqueda.Location = new System.Drawing.Point(8, 8);
            this.grpBusqueda.Name = "grpBusqueda";
            this.grpBusqueda.Size = new System.Drawing.Size(876, 80);
            this.grpBusqueda.Text = "Parámetros de consulta";

            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(10, 24);
            this.lblEstado.Text = "1. Estado:";

            this.cmbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEstado.Location = new System.Drawing.Point(10, 42);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Size = new System.Drawing.Size(160, 23);
            this.cmbEstado.TabIndex = 0;

            this.lblMunicipio.AutoSize = true;
            this.lblMunicipio.Location = new System.Drawing.Point(182, 24);
            this.lblMunicipio.Text = "2. Municipio:";

            this.cmbMunicipio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMunicipio.Enabled = false;
            this.cmbMunicipio.Location = new System.Drawing.Point(182, 42);
            this.cmbMunicipio.Name = "cmbMunicipio";
            this.cmbMunicipio.Size = new System.Drawing.Size(180, 23);
            this.cmbMunicipio.TabIndex = 1;

            this.lblAnio.AutoSize = true;
            this.lblAnio.Location = new System.Drawing.Point(390, 24);
            this.lblAnio.Text = "Año:";

            this.cmbAnio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAnio.Location = new System.Drawing.Point(390, 42);
            this.cmbAnio.Name = "cmbAnio";
            this.cmbAnio.Size = new System.Drawing.Size(80, 23);
            this.cmbAnio.TabIndex = 2;

            this.lblEstacion.AutoSize = true;
            this.lblEstacion.Location = new System.Drawing.Point(482, 24);
            this.lblEstacion.Text = "Estación:";

            this.cmbEstacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEstacion.Location = new System.Drawing.Point(482, 42);
            this.cmbEstacion.Name = "cmbEstacion";
            this.cmbEstacion.Size = new System.Drawing.Size(110, 23);
            this.cmbEstacion.TabIndex = 3;
            this.cmbEstacion.Items.AddRange(new object[] { "Verano", "Invierno", "Primavera", "Otoño" });
            this.cmbEstacion.SelectedIndex = 0;

            this.btnConsultar.Enabled = false;
            this.btnConsultar.Location = new System.Drawing.Point(610, 40);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(90, 26);
            this.btnConsultar.TabIndex = 4;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;

            this.btnLimpiar.Location = new System.Drawing.Point(706, 40);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(80, 26);
            this.btnLimpiar.TabIndex = 5;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;

            this.lblHintMunicipio.AutoSize = true;
            this.lblHintMunicipio.ForeColor = System.Drawing.Color.Gray;
            this.lblHintMunicipio.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Italic);
            this.lblHintMunicipio.Location = new System.Drawing.Point(182, 68);
            this.lblHintMunicipio.Text = "← Primero selecciona un estado";

            // ── GroupBox Datos Actuales ──────────────────────────────────────────
            this.grpDatosActuales.Controls.Add(this.lblFuenteAPI);
            this.grpDatosActuales.Controls.Add(this.lblTempActualVal);
            this.grpDatosActuales.Controls.Add(this.lblTempActualSub);
            this.grpDatosActuales.Controls.Add(this.lblMunicipioKey);
            this.grpDatosActuales.Controls.Add(this.lblMunicipioVal);
            this.grpDatosActuales.Controls.Add(this.lblEstadoActKey);
            this.grpDatosActuales.Controls.Add(this.lblEstadoActVal);
            this.grpDatosActuales.Controls.Add(this.lblMinActKey);
            this.grpDatosActuales.Controls.Add(this.lblMinActVal);
            this.grpDatosActuales.Controls.Add(this.lblMaxActKey);
            this.grpDatosActuales.Controls.Add(this.lblMaxActVal);
            this.grpDatosActuales.Controls.Add(this.lblCoordsVal);
            this.grpDatosActuales.Location = new System.Drawing.Point(8, 98);
            this.grpDatosActuales.Name = "grpDatosActuales";
            this.grpDatosActuales.Size = new System.Drawing.Size(430, 220);
            this.grpDatosActuales.Text = "Datos actuales";

            this.lblFuenteAPI.AutoSize = true;
            this.lblFuenteAPI.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblFuenteAPI.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblFuenteAPI.Location = new System.Drawing.Point(160, 20);
            this.lblFuenteAPI.Text = "Fuente: Open-Meteo API";

            this.lblTempActualVal.AutoSize = true;
            this.lblTempActualVal.ForeColor = System.Drawing.Color.Firebrick;
            this.lblTempActualVal.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Regular);
            this.lblTempActualVal.Location = new System.Drawing.Point(150, 38);
            this.lblTempActualVal.Text = "—";

            this.lblTempActualSub.AutoSize = true;
            this.lblTempActualSub.ForeColor = System.Drawing.Color.Gray;
            this.lblTempActualSub.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblTempActualSub.Location = new System.Drawing.Point(155, 82);
            this.lblTempActualSub.Text = "Temperatura actual del día";

            this.lblMunicipioKey.AutoSize = true;
            this.lblMunicipioKey.Location = new System.Drawing.Point(10, 108);
            this.lblMunicipioKey.Text = "Municipio:";

            this.lblMunicipioVal.AutoSize = true;
            this.lblMunicipioVal.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblMunicipioVal.Location = new System.Drawing.Point(220, 108);
            this.lblMunicipioVal.Text = "—";

            this.lblEstadoActKey.AutoSize = true;
            this.lblEstadoActKey.Location = new System.Drawing.Point(10, 132);
            this.lblEstadoActKey.Text = "Estado:";

            this.lblEstadoActVal.AutoSize = true;
            this.lblEstadoActVal.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblEstadoActVal.Location = new System.Drawing.Point(220, 132);
            this.lblEstadoActVal.Text = "—";

            this.lblMinActKey.AutoSize = true;
            this.lblMinActKey.Location = new System.Drawing.Point(10, 156);
            this.lblMinActKey.Text = "Mínima del día:";

            this.lblMinActVal.AutoSize = true;
            this.lblMinActVal.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblMinActVal.Location = new System.Drawing.Point(220, 156);
            this.lblMinActVal.Text = "—";

            this.lblMaxActKey.AutoSize = true;
            this.lblMaxActKey.Location = new System.Drawing.Point(10, 180);
            this.lblMaxActKey.Text = "Máxima del día:";

            this.lblMaxActVal.AutoSize = true;
            this.lblMaxActVal.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblMaxActVal.Location = new System.Drawing.Point(220, 180);
            this.lblMaxActVal.Text = "—";

            this.lblCoordsVal.AutoSize = true;
            this.lblCoordsVal.ForeColor = System.Drawing.Color.Gray;
            this.lblCoordsVal.Font = new System.Drawing.Font("Segoe UI", 7.5F);
            this.lblCoordsVal.Location = new System.Drawing.Point(10, 200);
            this.lblCoordsVal.Text = "Lat: — · Lon: —";

            // ── GroupBox Histórico ───────────────────────────────────────────────
            this.grpHistorico.Controls.Add(this.lblFuenteCSV);
            this.grpHistorico.Controls.Add(this.lblTempHistVal);
            this.grpHistorico.Controls.Add(this.lblTempHistSub);
            this.grpHistorico.Controls.Add(this.lblEstadoHistKey);
            this.grpHistorico.Controls.Add(this.lblEstadoHistVal);
            this.grpHistorico.Controls.Add(this.lblFiltroKey);
            this.grpHistorico.Controls.Add(this.lblFiltroVal);
            this.grpHistorico.Controls.Add(this.lblMinHistKey);
            this.grpHistorico.Controls.Add(this.lblMinHistVal);
            this.grpHistorico.Controls.Add(this.lblMaxHistKey);
            this.grpHistorico.Controls.Add(this.lblMaxHistVal);
            this.grpHistorico.Controls.Add(this.lblRegistrosVal);
            this.grpHistorico.Location = new System.Drawing.Point(446, 98);
            this.grpHistorico.Name = "grpHistorico";
            this.grpHistorico.Size = new System.Drawing.Size(438, 220);
            this.grpHistorico.Text = "Promedio histórico";

            this.lblFuenteCSV.AutoSize = true;
            this.lblFuenteCSV.ForeColor = System.Drawing.Color.SeaGreen;
            this.lblFuenteCSV.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblFuenteCSV.Location = new System.Drawing.Point(172, 20);
            this.lblFuenteCSV.Text = "Fuente: data.csv";

            this.lblTempHistVal.AutoSize = true;
            this.lblTempHistVal.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblTempHistVal.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Regular);
            this.lblTempHistVal.Location = new System.Drawing.Point(158, 38);
            this.lblTempHistVal.Text = "—";

            this.lblTempHistSub.AutoSize = true;
            this.lblTempHistSub.ForeColor = System.Drawing.Color.Gray;
            this.lblTempHistSub.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblTempHistSub.Location = new System.Drawing.Point(148, 82);
            this.lblTempHistSub.Text = "Promedio histórico del estado";

            this.lblEstadoHistKey.AutoSize = true;
            this.lblEstadoHistKey.Location = new System.Drawing.Point(10, 108);
            this.lblEstadoHistKey.Text = "Estado analizado:";

            this.lblEstadoHistVal.AutoSize = true;
            this.lblEstadoHistVal.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblEstadoHistVal.Location = new System.Drawing.Point(220, 108);
            this.lblEstadoHistVal.Text = "—";

            this.lblFiltroKey.AutoSize = true;
            this.lblFiltroKey.Location = new System.Drawing.Point(10, 132);
            this.lblFiltroKey.Text = "Estación / Año:";

            this.lblFiltroVal.AutoSize = true;
            this.lblFiltroVal.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblFiltroVal.Location = new System.Drawing.Point(220, 132);
            this.lblFiltroVal.Text = "—";

            this.lblMinHistKey.AutoSize = true;
            this.lblMinHistKey.Location = new System.Drawing.Point(10, 156);
            this.lblMinHistKey.Text = "Mínima histórica:";

            this.lblMinHistVal.AutoSize = true;
            this.lblMinHistVal.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblMinHistVal.Location = new System.Drawing.Point(220, 156);
            this.lblMinHistVal.Text = "—";

            this.lblMaxHistKey.AutoSize = true;
            this.lblMaxHistKey.Location = new System.Drawing.Point(10, 180);
            this.lblMaxHistKey.Text = "Máxima histórica:";

            this.lblMaxHistVal.AutoSize = true;
            this.lblMaxHistVal.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblMaxHistVal.Location = new System.Drawing.Point(220, 180);
            this.lblMaxHistVal.Text = "—";

            this.lblRegistrosVal.AutoSize = true;
            this.lblRegistrosVal.ForeColor = System.Drawing.Color.Gray;
            this.lblRegistrosVal.Font = new System.Drawing.Font("Segoe UI", 7.5F);
            this.lblRegistrosVal.Location = new System.Drawing.Point(10, 200);
            this.lblRegistrosVal.Text = "Basado en — registros del CSV";

            // ── GroupBox Anomalía ────────────────────────────────────────────────
            this.grpAnomalia.Controls.Add(this.lblDesviacionKey);
            this.grpAnomalia.Controls.Add(this.lblDesviacionVal);
            this.grpAnomalia.Controls.Add(this.lblDescAnomalia);
            this.grpAnomalia.Controls.Add(this.lblNivelKey);
            this.grpAnomalia.Controls.Add(this.pnlSemaforoVerde);
            this.grpAnomalia.Controls.Add(this.pnlSemaforoAmarillo);
            this.grpAnomalia.Controls.Add(this.pnlSemaforoRojo);
            this.grpAnomalia.Controls.Add(this.lblSemaforoTexto);
            this.grpAnomalia.Controls.Add(this.btnGuardarAlerta);
            this.grpAnomalia.Location = new System.Drawing.Point(8, 328);
            this.grpAnomalia.Name = "grpAnomalia";
            this.grpAnomalia.Size = new System.Drawing.Size(876, 90);
            this.grpAnomalia.Text = "Detección de anomalía";

            this.lblDesviacionKey.AutoSize = true;
            this.lblDesviacionKey.Location = new System.Drawing.Point(10, 28);
            this.lblDesviacionKey.Text = "Desviación detectada:";

            this.lblDesviacionVal.AutoSize = true;
            this.lblDesviacionVal.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Regular);
            this.lblDesviacionVal.Location = new System.Drawing.Point(10, 44);
            this.lblDesviacionVal.Text = "—";

            this.lblDescAnomalia.AutoSize = true;
            this.lblDescAnomalia.ForeColor = System.Drawing.Color.Gray;
            this.lblDescAnomalia.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Italic);
            this.lblDescAnomalia.Location = new System.Drawing.Point(150, 56);
            this.lblDescAnomalia.Text = "—";

            this.lblNivelKey.AutoSize = true;
            this.lblNivelKey.Location = new System.Drawing.Point(440, 28);
            this.lblNivelKey.Text = "Nivel de alerta:";

            this.pnlSemaforoVerde.BackColor = System.Drawing.Color.LightGray;
            this.pnlSemaforoVerde.Location = new System.Drawing.Point(440, 50);
            this.pnlSemaforoVerde.Name = "pnlSemaforoVerde";
            this.pnlSemaforoVerde.Size = new System.Drawing.Size(18, 18);

            this.pnlSemaforoAmarillo.BackColor = System.Drawing.Color.LightGray;
            this.pnlSemaforoAmarillo.Location = new System.Drawing.Point(464, 50);
            this.pnlSemaforoAmarillo.Name = "pnlSemaforoAmarillo";
            this.pnlSemaforoAmarillo.Size = new System.Drawing.Size(18, 18);

            this.pnlSemaforoRojo.BackColor = System.Drawing.Color.LightGray;
            this.pnlSemaforoRojo.Location = new System.Drawing.Point(488, 50);
            this.pnlSemaforoRojo.Name = "pnlSemaforoRojo";
            this.pnlSemaforoRojo.Size = new System.Drawing.Size(18, 18);

            this.lblSemaforoTexto.AutoSize = true;
            this.lblSemaforoTexto.Location = new System.Drawing.Point(514, 53);
            this.lblSemaforoTexto.Text = "—";

            this.btnGuardarAlerta.Enabled = false;
            this.btnGuardarAlerta.Location = new System.Drawing.Point(740, 48);
            this.btnGuardarAlerta.Name = "btnGuardarAlerta";
            this.btnGuardarAlerta.Size = new System.Drawing.Size(126, 26);
            this.btnGuardarAlerta.Text = "Guardar alerta en BD";
            this.btnGuardarAlerta.UseVisualStyleBackColor = true;

            // ════════════════════════════════════════════════════════════════════
            // TAB 2 — ANÁLISIS GLOBAL
            // ════════════════════════════════════════════════════════════════════
            this.tabAnalisis.Controls.Add(this.grpFiltrosGlobal);
            this.tabAnalisis.Controls.Add(this.dgvHistorico);
            this.tabAnalisis.Controls.Add(this.grpRanking);
            this.tabAnalisis.Location = new System.Drawing.Point(4, 24);
            this.tabAnalisis.Name = "tabAnalisis";
            this.tabAnalisis.Padding = new System.Windows.Forms.Padding(8);
            this.tabAnalisis.Size = new System.Drawing.Size(892, 592);
            this.tabAnalisis.Text = "Análisis Global";

            this.grpFiltrosGlobal.Controls.Add(this.lblFiltroAnio);
            this.grpFiltrosGlobal.Controls.Add(this.cmbFiltroAnio);
            this.grpFiltrosGlobal.Controls.Add(this.lblFiltroEstacion);
            this.grpFiltrosGlobal.Controls.Add(this.cmbFiltroEstacion);
            this.grpFiltrosGlobal.Controls.Add(this.lblBuscarEstado);
            this.grpFiltrosGlobal.Controls.Add(this.txtBuscarEstado);
            this.grpFiltrosGlobal.Controls.Add(this.btnFiltrar);
            this.grpFiltrosGlobal.Controls.Add(this.btnLimpiarFiltro);
            this.grpFiltrosGlobal.Location = new System.Drawing.Point(8, 8);
            this.grpFiltrosGlobal.Name = "grpFiltrosGlobal";
            this.grpFiltrosGlobal.Size = new System.Drawing.Size(876, 60);
            this.grpFiltrosGlobal.Text = "Filtros";

            this.lblFiltroAnio.AutoSize = true;
            this.lblFiltroAnio.Location = new System.Drawing.Point(10, 24);
            this.lblFiltroAnio.Text = "Año:";

            this.cmbFiltroAnio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFiltroAnio.Location = new System.Drawing.Point(40, 20);
            this.cmbFiltroAnio.Name = "cmbFiltroAnio";
            this.cmbFiltroAnio.Size = new System.Drawing.Size(80, 23);

            this.lblFiltroEstacion.AutoSize = true;
            this.lblFiltroEstacion.Location = new System.Drawing.Point(132, 24);
            this.lblFiltroEstacion.Text = "Estación:";

            this.cmbFiltroEstacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFiltroEstacion.Location = new System.Drawing.Point(186, 20);
            this.cmbFiltroEstacion.Name = "cmbFiltroEstacion";
            this.cmbFiltroEstacion.Size = new System.Drawing.Size(110, 23);
            this.cmbFiltroEstacion.Items.AddRange(new object[] { "Todas", "Verano", "Invierno", "Primavera", "Otoño" });
            this.cmbFiltroEstacion.SelectedIndex = 0;

            this.lblBuscarEstado.AutoSize = true;
            this.lblBuscarEstado.Location = new System.Drawing.Point(310, 24);
            this.lblBuscarEstado.Text = "Buscar estado:";

            this.txtBuscarEstado.Location = new System.Drawing.Point(398, 20);
            this.txtBuscarEstado.Name = "txtBuscarEstado";
            this.txtBuscarEstado.Size = new System.Drawing.Size(160, 23);

            this.btnFiltrar.Location = new System.Drawing.Point(570, 19);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(80, 26);
            this.btnFiltrar.Text = "Filtrar";
            this.btnFiltrar.UseVisualStyleBackColor = true;

            this.btnLimpiarFiltro.Location = new System.Drawing.Point(656, 19);
            this.btnLimpiarFiltro.Name = "btnLimpiarFiltro";
            this.btnLimpiarFiltro.Size = new System.Drawing.Size(80, 26);
            this.btnLimpiarFiltro.Text = "Limpiar";
            this.btnLimpiarFiltro.UseVisualStyleBackColor = true;

            this.dgvHistorico.AllowUserToAddRows = false;
            this.dgvHistorico.AllowUserToDeleteRows = false;
            this.dgvHistorico.ReadOnly = true;
            this.dgvHistorico.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHistorico.Location = new System.Drawing.Point(8, 76);
            this.dgvHistorico.Name = "dgvHistorico";
            this.dgvHistorico.Size = new System.Drawing.Size(876, 340);
            this.dgvHistorico.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;

            this.grpRanking.Controls.Add(this.lblRankingCaliente);
            this.grpRanking.Controls.Add(this.lstCalientes);
            this.grpRanking.Controls.Add(this.lblRankingFrio);
            this.grpRanking.Controls.Add(this.lstFrios);
            this.grpRanking.Location = new System.Drawing.Point(8, 424);
            this.grpRanking.Name = "grpRanking";
            this.grpRanking.Size = new System.Drawing.Size(876, 156);
            this.grpRanking.Text = "Ranking (derivado del filtro activo)";

            this.lblRankingCaliente.AutoSize = true;
            this.lblRankingCaliente.ForeColor = System.Drawing.Color.Firebrick;
            this.lblRankingCaliente.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblRankingCaliente.Location = new System.Drawing.Point(10, 22);
            this.lblRankingCaliente.Text = "Top 5 — más calientes";

            this.lstCalientes.Location = new System.Drawing.Point(10, 42);
            this.lstCalientes.Name = "lstCalientes";
            this.lstCalientes.Size = new System.Drawing.Size(418, 100);

            this.lblRankingFrio.AutoSize = true;
            this.lblRankingFrio.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblRankingFrio.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblRankingFrio.Location = new System.Drawing.Point(448, 22);
            this.lblRankingFrio.Text = "Top 5 — más fríos";

            this.lstFrios.Location = new System.Drawing.Point(448, 42);
            this.lstFrios.Name = "lstFrios";
            this.lstFrios.Size = new System.Drawing.Size(418, 100);

            // ════════════════════════════════════════════════════════════════════
            // TAB 3 — FAVORITOS
            // ════════════════════════════════════════════════════════════════════
            this.tabFavoritos.Controls.Add(this.dgvFavoritos);
            this.tabFavoritos.Controls.Add(this.grpAgregarFav);
            this.tabFavoritos.Controls.Add(this.btnEliminarFav);
            this.tabFavoritos.Location = new System.Drawing.Point(4, 24);
            this.tabFavoritos.Name = "tabFavoritos";
            this.tabFavoritos.Padding = new System.Windows.Forms.Padding(8);
            this.tabFavoritos.Size = new System.Drawing.Size(892, 592);
            this.tabFavoritos.Text = "Favoritos";

            this.dgvFavoritos.AllowUserToAddRows = false;
            this.dgvFavoritos.AllowUserToDeleteRows = false;
            this.dgvFavoritos.ReadOnly = true;
            this.dgvFavoritos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvFavoritos.Location = new System.Drawing.Point(8, 8);
            this.dgvFavoritos.Name = "dgvFavoritos";
            this.dgvFavoritos.Size = new System.Drawing.Size(876, 460);
            this.dgvFavoritos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;

            this.btnEliminarFav.Location = new System.Drawing.Point(8, 476);
            this.btnEliminarFav.Name = "btnEliminarFav";
            this.btnEliminarFav.Size = new System.Drawing.Size(120, 26);
            this.btnEliminarFav.Text = "Eliminar seleccionado";
            this.btnEliminarFav.UseVisualStyleBackColor = true;

            this.grpAgregarFav.Controls.Add(this.lblNuevoFavEstado);
            this.grpAgregarFav.Controls.Add(this.cmbNuevoFavEstado);
            this.grpAgregarFav.Controls.Add(this.lblNuevoFavMun);
            this.grpAgregarFav.Controls.Add(this.cmbNuevoFavMun);
            this.grpAgregarFav.Controls.Add(this.btnAgregarFav);
            this.grpAgregarFav.Location = new System.Drawing.Point(8, 510);
            this.grpAgregarFav.Name = "grpAgregarFav";
            this.grpAgregarFav.Size = new System.Drawing.Size(876, 60);
            this.grpAgregarFav.Text = "Agregar municipio a favoritos";

            this.lblNuevoFavEstado.AutoSize = true;
            this.lblNuevoFavEstado.Location = new System.Drawing.Point(10, 26);
            this.lblNuevoFavEstado.Text = "Estado:";

            this.cmbNuevoFavEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNuevoFavEstado.Location = new System.Drawing.Point(60, 22);
            this.cmbNuevoFavEstado.Name = "cmbNuevoFavEstado";
            this.cmbNuevoFavEstado.Size = new System.Drawing.Size(160, 23);

            this.lblNuevoFavMun.AutoSize = true;
            this.lblNuevoFavMun.Location = new System.Drawing.Point(234, 26);
            this.lblNuevoFavMun.Text = "Municipio:";

            this.cmbNuevoFavMun.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNuevoFavMun.Enabled = false;
            this.cmbNuevoFavMun.Location = new System.Drawing.Point(298, 22);
            this.cmbNuevoFavMun.Name = "cmbNuevoFavMun";
            this.cmbNuevoFavMun.Size = new System.Drawing.Size(180, 23);

            this.btnAgregarFav.Location = new System.Drawing.Point(492, 21);
            this.btnAgregarFav.Name = "btnAgregarFav";
            this.btnAgregarFav.Size = new System.Drawing.Size(100, 26);
            this.btnAgregarFav.Text = "Agregar";
            this.btnAgregarFav.UseVisualStyleBackColor = true;

            // ════════════════════════════════════════════════════════════════════
            // TAB 4 — CONFIGURACIÓN
            // ════════════════════════════════════════════════════════════════════
            this.tabConfig.Controls.Add(this.grpConexion);
            this.tabConfig.Controls.Add(this.grpArchivos);
            this.tabConfig.Controls.Add(this.grpPreferencias);
            this.tabConfig.Controls.Add(this.btnGuardarConfig);
            this.tabConfig.Location = new System.Drawing.Point(4, 24);
            this.tabConfig.Name = "tabConfig";
            this.tabConfig.Padding = new System.Windows.Forms.Padding(8);
            this.tabConfig.Size = new System.Drawing.Size(892, 592);
            this.tabConfig.Text = "Configuración";

            this.grpConexion.Controls.Add(this.lblCadenaConexion);
            this.grpConexion.Controls.Add(this.txtCadenaConexion);
            this.grpConexion.Controls.Add(this.btnProbarConexion);
            this.grpConexion.Controls.Add(this.lblEstadoConexion);
            this.grpConexion.Location = new System.Drawing.Point(8, 8);
            this.grpConexion.Name = "grpConexion";
            this.grpConexion.Size = new System.Drawing.Size(876, 80);
            this.grpConexion.Text = "Base de datos — SQL Server / MariaDB";

            this.lblCadenaConexion.AutoSize = true;
            this.lblCadenaConexion.Location = new System.Drawing.Point(10, 24);
            this.lblCadenaConexion.Text = "Cadena de conexión:";

            this.txtCadenaConexion.Location = new System.Drawing.Point(10, 42);
            this.txtCadenaConexion.Name = "txtCadenaConexion";
            this.txtCadenaConexion.Size = new System.Drawing.Size(640, 23);

            this.btnProbarConexion.Location = new System.Drawing.Point(660, 41);
            this.btnProbarConexion.Name = "btnProbarConexion";
            this.btnProbarConexion.Size = new System.Drawing.Size(110, 26);
            this.btnProbarConexion.Text = "Probar conexión";
            this.btnProbarConexion.UseVisualStyleBackColor = true;

            this.lblEstadoConexion.AutoSize = true;
            this.lblEstadoConexion.ForeColor = System.Drawing.Color.Gray;
            this.lblEstadoConexion.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Italic);
            this.lblEstadoConexion.Location = new System.Drawing.Point(780, 46);
            this.lblEstadoConexion.Text = "—";

            this.grpArchivos.Controls.Add(this.lblRutaCSV);
            this.grpArchivos.Controls.Add(this.txtRutaCSV);
            this.grpArchivos.Controls.Add(this.btnExplorarCSV);
            this.grpArchivos.Controls.Add(this.lblRutaJSON);
            this.grpArchivos.Controls.Add(this.txtRutaJSON);
            this.grpArchivos.Controls.Add(this.btnExplorarJSON);
            this.grpArchivos.Location = new System.Drawing.Point(8, 100);
            this.grpArchivos.Name = "grpArchivos";
            this.grpArchivos.Size = new System.Drawing.Size(876, 100);
            this.grpArchivos.Text = "Archivos de datos";

            this.lblRutaCSV.AutoSize = true;
            this.lblRutaCSV.Location = new System.Drawing.Point(10, 24);
            this.lblRutaCSV.Text = "Ruta CSV:";

            this.txtRutaCSV.Location = new System.Drawing.Point(10, 40);
            this.txtRutaCSV.Name = "txtRutaCSV";
            this.txtRutaCSV.Size = new System.Drawing.Size(740, 23);
            this.txtRutaCSV.Text = "Data\\data.csv";

            this.btnExplorarCSV.Location = new System.Drawing.Point(758, 39);
            this.btnExplorarCSV.Name = "btnExplorarCSV";
            this.btnExplorarCSV.Size = new System.Drawing.Size(100, 26);
            this.btnExplorarCSV.Text = "Explorar...";
            this.btnExplorarCSV.UseVisualStyleBackColor = true;

            this.lblRutaJSON.AutoSize = true;
            this.lblRutaJSON.Location = new System.Drawing.Point(10, 70);
            this.lblRutaJSON.Text = "Ruta JSON:";

            this.txtRutaJSON.Location = new System.Drawing.Point(10, 68);
            this.txtRutaJSON.Name = "txtRutaJSON";
            this.txtRutaJSON.Size = new System.Drawing.Size(740, 23);
            this.txtRutaJSON.Text = "Data\\municipios_mx.json";

            this.btnExplorarJSON.Location = new System.Drawing.Point(758, 67);
            this.btnExplorarJSON.Name = "btnExplorarJSON";
            this.btnExplorarJSON.Size = new System.Drawing.Size(100, 26);
            this.btnExplorarJSON.Text = "Explorar...";
            this.btnExplorarJSON.UseVisualStyleBackColor = true;

            this.grpPreferencias.Controls.Add(this.lblUmbral);
            this.grpPreferencias.Controls.Add(this.nudUmbral);
            this.grpPreferencias.Controls.Add(this.lblUmbralSufijo);
            this.grpPreferencias.Controls.Add(this.lblUnidades);
            this.grpPreferencias.Controls.Add(this.rbCelsius);
            this.grpPreferencias.Controls.Add(this.rbFahrenheit);
            this.grpPreferencias.Location = new System.Drawing.Point(8, 212);
            this.grpPreferencias.Name = "grpPreferencias";
            this.grpPreferencias.Size = new System.Drawing.Size(876, 80);
            this.grpPreferencias.Text = "Preferencias";

            this.lblUmbral.AutoSize = true;
            this.lblUmbral.Location = new System.Drawing.Point(10, 32);
            this.lblUmbral.Text = "Umbral de alerta:";

            this.nudUmbral.DecimalPlaces = 1;
            this.nudUmbral.Increment = new decimal(new int[] { 5, 0, 0, 65536 });
            this.nudUmbral.Maximum = new decimal(new int[] { 20, 0, 0, 0 });
            this.nudUmbral.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            this.nudUmbral.Value = new decimal(new int[] { 10, 0, 0, 0 });
            this.nudUmbral.Location = new System.Drawing.Point(122, 28);
            this.nudUmbral.Name = "nudUmbral";
            this.nudUmbral.Size = new System.Drawing.Size(60, 23);

            this.lblUmbralSufijo.AutoSize = true;
            this.lblUmbralSufijo.Location = new System.Drawing.Point(188, 32);
            this.lblUmbralSufijo.Text = "°C";

            this.lblUnidades.AutoSize = true;
            this.lblUnidades.Location = new System.Drawing.Point(280, 32);
            this.lblUnidades.Text = "Unidades:";

            this.rbCelsius.AutoSize = true;
            this.rbCelsius.Checked = true;
            this.rbCelsius.Location = new System.Drawing.Point(350, 30);
            this.rbCelsius.Name = "rbCelsius";
            this.rbCelsius.Size = new System.Drawing.Size(66, 19);
            this.rbCelsius.TabStop = true;
            this.rbCelsius.Text = "Celsius";

            this.rbFahrenheit.AutoSize = true;
            this.rbFahrenheit.Location = new System.Drawing.Point(422, 30);
            this.rbFahrenheit.Name = "rbFahrenheit";
            this.rbFahrenheit.Size = new System.Drawing.Size(82, 19);
            this.rbFahrenheit.Text = "Fahrenheit";

            this.btnGuardarConfig.Location = new System.Drawing.Point(8, 304);
            this.btnGuardarConfig.Name = "btnGuardarConfig";
            this.btnGuardarConfig.Size = new System.Drawing.Size(130, 28);
            this.btnGuardarConfig.Text = "Guardar configuración";
            this.btnGuardarConfig.UseVisualStyleBackColor = true;

            // ════════════════════════════════════════════════════════════════════
            // STATUS STRIP
            // ════════════════════════════════════════════════════════════════════
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[]{
            this.tssSQLite, this.tssSQLServer, this.tssAPI, this.tssRegistros
        });
            this.statusStrip.Location = new System.Drawing.Point(0, 648);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(900, 22);

            this.tssSQLite.Name = "tssSQLite";
            this.tssSQLite.Text = "SQLite: —";

            this.tssSQLServer.Name = "tssSQLServer";
            this.tssSQLServer.Text = "SQL Server: —";

            this.tssAPI.Name = "tssAPI";
            this.tssAPI.Text = "Open-Meteo: —";

            this.tssRegistros.Name = "tssRegistros";
            this.tssRegistros.Spring = true;
            this.tssRegistros.Text = "Registros cargados: —";
            this.tssRegistros.TextAlign = System.Drawing.ContentAlignment.MiddleRight;

            // ════════════════════════════════════════════════════════════════════
            // FORM
            // ════════════════════════════════════════════════════════════════════
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 670);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.statusStrip);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.MinimumSize = new System.Drawing.Size(916, 709);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema de Inteligencia Climática — México";

            this.tabControl.ResumeLayout(false);
            this.tabConsulta.ResumeLayout(false);
            this.tabAnalisis.ResumeLayout(false);
            this.tabFavoritos.ResumeLayout(false);
            this.tabConfig.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)this.dgvHistorico).EndInit();
            ((System.ComponentModel.ISupportInitialize)this.dgvFavoritos).EndInit();
            ((System.ComponentModel.ISupportInitialize)this.nudUmbral).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        // ── Declaraciones ────────────────────────────────────────────────────────
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabConsulta, tabAnalisis, tabFavoritos, tabConfig;
        private System.Windows.Forms.GroupBox grpBusqueda, grpDatosActuales, grpHistorico, grpAnomalia;
        private System.Windows.Forms.GroupBox grpFiltrosGlobal, grpRanking;
        private System.Windows.Forms.GroupBox grpAgregarFav;
        private System.Windows.Forms.GroupBox grpConexion, grpArchivos, grpPreferencias;
        private System.Windows.Forms.Label lblEstado, lblMunicipio, lblAnio, lblEstacion, lblHintMunicipio;
        private System.Windows.Forms.ComboBox cmbEstado, cmbMunicipio, cmbAnio, cmbEstacion;
        private System.Windows.Forms.Button btnConsultar, btnLimpiar;
        private System.Windows.Forms.Label lblFuenteAPI, lblTempActualVal, lblTempActualSub;
        private System.Windows.Forms.Label lblMunicipioKey, lblMunicipioVal;
        private System.Windows.Forms.Label lblEstadoActKey, lblEstadoActVal;
        private System.Windows.Forms.Label lblMinActKey, lblMinActVal;
        private System.Windows.Forms.Label lblMaxActKey, lblMaxActVal;
        private System.Windows.Forms.Label lblCoordsVal;
        private System.Windows.Forms.Label lblFuenteCSV, lblTempHistVal, lblTempHistSub;
        private System.Windows.Forms.Label lblEstadoHistKey, lblEstadoHistVal;
        private System.Windows.Forms.Label lblFiltroKey, lblFiltroVal;
        private System.Windows.Forms.Label lblMinHistKey, lblMinHistVal;
        private System.Windows.Forms.Label lblMaxHistKey, lblMaxHistVal;
        private System.Windows.Forms.Label lblRegistrosVal;
        private System.Windows.Forms.Label lblDesviacionKey, lblDesviacionVal, lblDescAnomalia;
        private System.Windows.Forms.Label lblNivelKey, lblSemaforoTexto;
        private System.Windows.Forms.Panel pnlSemaforoVerde, pnlSemaforoAmarillo, pnlSemaforoRojo;
        private System.Windows.Forms.Button btnGuardarAlerta;
        private System.Windows.Forms.Label lblFiltroAnio, lblFiltroEstacion, lblBuscarEstado;
        private System.Windows.Forms.ComboBox cmbFiltroAnio, cmbFiltroEstacion;
        private System.Windows.Forms.TextBox txtBuscarEstado;
        private System.Windows.Forms.Button btnFiltrar, btnLimpiarFiltro;
        private System.Windows.Forms.DataGridView dgvHistorico;
        private System.Windows.Forms.Label lblRankingCaliente, lblRankingFrio;
        private System.Windows.Forms.ListBox lstCalientes, lstFrios;
        private System.Windows.Forms.DataGridView dgvFavoritos;
        private System.Windows.Forms.Button btnEliminarFav;
        private System.Windows.Forms.Label lblNuevoFavEstado, lblNuevoFavMun;
        private System.Windows.Forms.ComboBox cmbNuevoFavEstado, cmbNuevoFavMun;
        private System.Windows.Forms.Button btnAgregarFav;
        private System.Windows.Forms.Label lblCadenaConexion, lblEstadoConexion;
        private System.Windows.Forms.TextBox txtCadenaConexion;
        private System.Windows.Forms.Button btnProbarConexion;
        private System.Windows.Forms.Label lblRutaCSV, lblRutaJSON;
        private System.Windows.Forms.TextBox txtRutaCSV, txtRutaJSON;
        private System.Windows.Forms.Button btnExplorarCSV, btnExplorarJSON;
        private System.Windows.Forms.Label lblUmbral, lblUmbralSufijo, lblUnidades;
        private System.Windows.Forms.NumericUpDown nudUmbral;
        private System.Windows.Forms.RadioButton rbCelsius, rbFahrenheit;
        private System.Windows.Forms.Button btnGuardarConfig;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel tssSQLite, tssSQLServer, tssAPI, tssRegistros;
    }
}