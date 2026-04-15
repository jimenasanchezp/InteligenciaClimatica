

namespace InteligenciaClimatica
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        // ── Sidebar ────────────────────────────────────────────────────────
        private Panel pnlSidebar;
        private Panel pnlSidebarBrand;
        private Label lblSidebarTitle;
        private Panel pnlSidebarFooter;
        private Label lblSidebarStatusAPI;
        private Label lblSidebarStatusSQLite;
        private Label lblSidebarStatusRegs;
        private Label lblNavLabelPrincipal;
        private Button btnNavConsulta;
        private Button btnNavAnalisis;
        private Button btnNavFavoritos;
        private Label lblNavLabelSistema;
        private Button btnNavConfig;

        // ── Área principal ─────────────────────────────────────────────────
        private Panel pnlMainContent;
        private Panel pnlTopBar;
        private Label lblTopBarTitle;
        private Label lblTopBarCrumb;


        // ── TabControl (pestañas ocultas — controladas por sidebar) ────────
        private TabControl tabControl;
        private TabPage tabConsulta;
        private TabPage tabAnalisis;
        private TabPage tabFavoritos;
        private TabPage tabConfig;

        // ── Tab: Consulta ──────────────────────────────────────────────────
        private GroupBox grpBusqueda;
        private Label lblEstado;
        private ComboBox cmbEstado;
        private Label lblMunicipio;
        private ComboBox cmbMunicipio;
        private Label lblAnio;
        private ComboBox cmbAnio;
        private Label lblEstacion;
        private ComboBox cmbEstacion;
        private Button btnConsultar;
        private Button btnLimpiar;
        private TableLayoutPanel tblTarjetas;
        private GroupBox grpDatosActuales;
        private Label lblFuenteAPI;
        private Label lblTempActualVal;
        private Label lblTempActualSub;
        private Label lblMunicipioKey;
        private Label lblMunicipioVal;
        private Label lblEstadoActKey;
        private Label lblEstadoActVal;
        private Label lblMinActKey;
        private Label lblMinActVal;
        private Label lblMaxActKey;
        private Label lblMaxActVal;
        private Label lblCoordsVal;
        private GroupBox grpHistorico;
        private Label lblFuenteCSV;
        private Label lblTempHistVal;
        private Label lblTempHistSub;
        private Label lblEstadoHistKey;
        private Label lblEstadoHistVal;
        private Label lblFiltroKey;
        private Label lblFiltroVal;
        private Label lblMinHistKey;
        private Label lblMinHistVal;
        private Label lblMaxHistKey;
        private Label lblMaxHistVal;
        private Label lblRegistrosVal;
        private GroupBox grpAnomalia;
        private Label lblDesviacionKey;
        private Label lblDesviacionVal;
        private Label lblDescAnomalia;
        private Label lblNivelKey;
        private Panel pnlSemaforoVerde;
        private Panel pnlSemaforoAmarillo;
        private Panel pnlSemaforoRojo;
        private Label lblSemaforoTexto;
        private Button btnGuardarAlerta;

        // ── Tab: Análisis ──────────────────────────────────────────────────
        private GroupBox grpFiltrosGlobal;
        private Label lblFiltroAnio;
        private ComboBox cmbFiltroAnio;
        private Label lblFiltroEstacion;
        private ComboBox cmbFiltroEstacion;
        private Label lblBuscarEstado;
        private TextBox txtBuscarEstado;
        private Button btnFiltrar;
        private Button btnLimpiarFiltro;
        //private DataGridView dgvHistorico;
        private ScottPlot.WinForms.FormsPlot formsPlotCalientes;
        private ScottPlot.WinForms.FormsPlot formsPlotFrios;
        private Panel pnlCharts;
        private Panel pnlIzq;  
        private Panel pnlDer;
        private GroupBox grpRanking;
        private Label lblRankingCaliente;
        private ListBox lstCalientes;
        private Label lblRankingFrio;
        private ListBox lstFrios;
        private Button btnExportarRanking;


        // ── Tab: Favoritos ─────────────────────────────────────────────────
        private DataGridView dgvFavoritos;
        private GroupBox grpAgregarFav;
        private Label lblNuevoFavEstado;
        private ComboBox cmbNuevoFavEstado;
        private Label lblNuevoFavMun;
        private ComboBox cmbNuevoFavMun;
        private Button btnAgregarFav;
        private Button btnEliminarFav;
        private Button btnMigrar;

        // ── Tab: Configuración ─────────────────────────────────────────────
        private GroupBox grpBaseDatos;
        private Label lblMotorBD;
        private ComboBox cmbMotorBD;
        private Label lblSQLitePath;
        private TextBox txtSQLitePath;
        private Button btnExplorarSQLite;
        private Label lblMariaServidor;
        private TextBox txtMariaServidor;
        private Label lblMariaPuerto;
        private TextBox txtMariaPuerto;
        private Label lblMariaBD;
        private TextBox txtMariaBD;
        private Label lblMariaUsuario;
        private TextBox txtMariaUsuario;
        private Label lblMariaPassword;
        private TextBox txtMariaPassword;
        private Button btnProbarConexion;
        private Label lblEstadoConexion;
        private GroupBox grpArchivos;
        private Label lblRutaCSV;
        private TextBox txtRutaCSV;
        private Button btnExplorarCSV;
        private Label lblRutaJSON;
        private TextBox txtRutaJSON;
        private Button btnExplorarJSON;
        private GroupBox grpPreferencias;
        private Label lblUmbral;
        private NumericUpDown nudUmbral;
        private Label lblUmbralSufijo;
        private Label lblUnidades;
        private RadioButton rbCelsius;
        private RadioButton rbFahrenheit;
        private Button btnGuardarConfig;

        // ── Status strip ───────────────────────────────────────────────────
        private StatusStrip statusStrip;
        private ToolStripStatusLabel tssSQLite;
        private ToolStripStatusLabel tssMariaDB;
        private ToolStripStatusLabel tssAPI;
        private ToolStripStatusLabel tssRegistros;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            pnlSidebar = new Panel();
            pnlSidebarBrand = new Panel();
            lblSidebarTitle = new Label();
            lblNavLabelPrincipal = new Label();
            btnNavConsulta = new Button();
            btnNavAnalisis = new Button();
            btnNavFavoritos = new Button();
            lblNavLabelSistema = new Label();
            btnNavConfig = new Button();
            pnlSidebarFooter = new Panel();
            lblSidebarStatusAPI = new Label();
            lblSidebarStatusSQLite = new Label();
            lblSidebarStatusRegs = new Label();
            pnlMainContent = new Panel();
            tabControl = new TabControl();
            tabConsulta = new TabPage();
            tblTarjetas = new TableLayoutPanel();
            grpDatosActuales = new GroupBox();
            lblFuenteAPI = new Label();
            lblTempActualVal = new Label();
            lblTempActualSub = new Label();
            lblMunicipioKey = new Label();
            lblMunicipioVal = new Label();
            lblEstadoActKey = new Label();
            lblEstadoActVal = new Label();
            lblMinActKey = new Label();
            lblMinActVal = new Label();
            lblMaxActKey = new Label();
            lblMaxActVal = new Label();
            lblCoordsVal = new Label();
            grpHistorico = new GroupBox();
            lblFuenteCSV = new Label();
            lblTempHistVal = new Label();
            lblTempHistSub = new Label();
            lblEstadoHistKey = new Label();
            lblEstadoHistVal = new Label();
            lblFiltroKey = new Label();
            lblFiltroVal = new Label();
            lblMinHistKey = new Label();
            lblMinHistVal = new Label();
            lblMaxHistKey = new Label();
            lblMaxHistVal = new Label();
            lblRegistrosVal = new Label();
            grpAnomalia = new GroupBox();
            lblDesviacionKey = new Label();
            lblDesviacionVal = new Label();
            lblDescAnomalia = new Label();
            lblNivelKey = new Label();
            pnlSemaforoVerde = new Panel();
            pnlSemaforoAmarillo = new Panel();
            pnlSemaforoRojo = new Panel();
            lblSemaforoTexto = new Label();
            btnGuardarAlerta = new Button();
            grpBusqueda = new GroupBox();
            lblEstado = new Label();
            cmbEstado = new ComboBox();
            lblMunicipio = new Label();
            cmbMunicipio = new ComboBox();
            lblAnio = new Label();
            cmbAnio = new ComboBox();
            lblEstacion = new Label();
            cmbEstacion = new ComboBox();
            btnConsultar = new Button();
            btnLimpiar = new Button();
            tabAnalisis = new TabPage();
            pnlCharts = new Panel();
            pnlDer = new Panel();
            formsPlotFrios = new ScottPlot.WinForms.FormsPlot();
            pnlIzq = new Panel();
            formsPlotCalientes = new ScottPlot.WinForms.FormsPlot();
            grpRanking = new GroupBox();
            lblRankingCaliente = new Label();
            lstCalientes = new ListBox();
            lblRankingFrio = new Label();
            lstFrios = new ListBox();
            btnExportarRanking = new Button();
            grpFiltrosGlobal = new GroupBox();
            lblFiltroAnio = new Label();
            cmbFiltroAnio = new ComboBox();
            lblFiltroEstacion = new Label();
            cmbFiltroEstacion = new ComboBox();
            lblBuscarEstado = new Label();
            txtBuscarEstado = new TextBox();
            btnFiltrar = new Button();
            btnLimpiarFiltro = new Button();
            tabFavoritos = new TabPage();
            dgvFavoritos = new DataGridView();
            grpAgregarFav = new GroupBox();
            lblNuevoFavEstado = new Label();
            cmbNuevoFavEstado = new ComboBox();
            lblNuevoFavMun = new Label();
            cmbNuevoFavMun = new ComboBox();
            btnAgregarFav = new Button();
            btnEliminarFav = new Button();
            btnMigrar = new Button();
            tabConfig = new TabPage();
            btnGuardarConfig = new Button();
            grpPreferencias = new GroupBox();
            lblUmbral = new Label();
            nudUmbral = new NumericUpDown();
            lblUmbralSufijo = new Label();
            lblUnidades = new Label();
            rbCelsius = new RadioButton();
            rbFahrenheit = new RadioButton();
            grpArchivos = new GroupBox();
            lblRutaCSV = new Label();
            txtRutaCSV = new TextBox();
            btnExplorarCSV = new Button();
            lblRutaJSON = new Label();
            txtRutaJSON = new TextBox();
            btnExplorarJSON = new Button();
            grpBaseDatos = new GroupBox();
            lblMotorBD = new Label();
            cmbMotorBD = new ComboBox();
            lblSQLitePath = new Label();
            txtSQLitePath = new TextBox();
            btnExplorarSQLite = new Button();
            lblMariaServidor = new Label();
            txtMariaServidor = new TextBox();
            lblMariaPuerto = new Label();
            txtMariaPuerto = new TextBox();
            lblMariaBD = new Label();
            txtMariaBD = new TextBox();
            lblMariaUsuario = new Label();
            txtMariaUsuario = new TextBox();
            lblMariaPassword = new Label();
            txtMariaPassword = new TextBox();
            btnProbarConexion = new Button();
            lblEstadoConexion = new Label();
            pnlTopBar = new Panel();
            lblTopBarTitle = new Label();
            lblTopBarCrumb = new Label();
            statusStrip = new StatusStrip();
            tssSQLite = new ToolStripStatusLabel();
            tssMariaDB = new ToolStripStatusLabel();
            tssAPI = new ToolStripStatusLabel();
            tssRegistros = new ToolStripStatusLabel();
            pnlSidebar.SuspendLayout();
            pnlSidebarBrand.SuspendLayout();
            pnlSidebarFooter.SuspendLayout();
            pnlMainContent.SuspendLayout();
            tabControl.SuspendLayout();
            tabConsulta.SuspendLayout();
            tblTarjetas.SuspendLayout();
            grpDatosActuales.SuspendLayout();
            grpHistorico.SuspendLayout();
            grpAnomalia.SuspendLayout();
            grpBusqueda.SuspendLayout();
            tabAnalisis.SuspendLayout();
            pnlCharts.SuspendLayout();
            pnlDer.SuspendLayout();
            pnlIzq.SuspendLayout();
            grpRanking.SuspendLayout();
            grpFiltrosGlobal.SuspendLayout();
            tabFavoritos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvFavoritos).BeginInit();
            grpAgregarFav.SuspendLayout();
            tabConfig.SuspendLayout();
            grpPreferencias.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudUmbral).BeginInit();
            grpArchivos.SuspendLayout();
            grpBaseDatos.SuspendLayout();
            pnlTopBar.SuspendLayout();
            statusStrip.SuspendLayout();
            SuspendLayout();
            // 
            // pnlSidebar
            // 
            pnlSidebar.BackColor = Color.FromArgb(15, 27, 45);
            pnlSidebar.Controls.Add(pnlSidebarBrand);
            pnlSidebar.Controls.Add(lblNavLabelPrincipal);
            pnlSidebar.Controls.Add(btnNavConsulta);
            pnlSidebar.Controls.Add(btnNavAnalisis);
            pnlSidebar.Controls.Add(btnNavFavoritos);
            pnlSidebar.Controls.Add(lblNavLabelSistema);
            pnlSidebar.Controls.Add(btnNavConfig);
            pnlSidebar.Controls.Add(pnlSidebarFooter);
            pnlSidebar.Dock = DockStyle.Left;
            pnlSidebar.Location = new Point(0, 0);
            pnlSidebar.Name = "pnlSidebar";
            pnlSidebar.Size = new Size(210, 774);
            pnlSidebar.TabIndex = 1;
            // 
            // pnlSidebarBrand
            // 
            pnlSidebarBrand.BackColor = Color.FromArgb(15, 27, 45);
            pnlSidebarBrand.Controls.Add(lblSidebarTitle);
            pnlSidebarBrand.Location = new Point(0, 0);
            pnlSidebarBrand.Name = "pnlSidebarBrand";
            pnlSidebarBrand.Size = new Size(210, 78);
            pnlSidebarBrand.TabIndex = 0;
            // 
            // lblSidebarTitle
            // 
            lblSidebarTitle.Font = new Font("Segoe UI", 11.5F, FontStyle.Bold);
            lblSidebarTitle.ForeColor = Color.White;
            lblSidebarTitle.Location = new Point(18, 18);
            lblSidebarTitle.Name = "lblSidebarTitle";
            lblSidebarTitle.Size = new Size(174, 46);
            lblSidebarTitle.TabIndex = 0;
            lblSidebarTitle.Text = "Inteligencia\nClimática MX";
            // 
            // lblNavLabelPrincipal
            // 
            lblNavLabelPrincipal.Font = new Font("Segoe UI", 7.5F, FontStyle.Bold);
            lblNavLabelPrincipal.ForeColor = Color.FromArgb(65, 90, 125);
            lblNavLabelPrincipal.Location = new Point(18, 90);
            lblNavLabelPrincipal.Name = "lblNavLabelPrincipal";
            lblNavLabelPrincipal.Size = new Size(174, 18);
            lblNavLabelPrincipal.TabIndex = 1;
            lblNavLabelPrincipal.Text = "PRINCIPAL";
            // 
            // btnNavConsulta
            // 
            btnNavConsulta.Location = new Point(0, 0);
            btnNavConsulta.Name = "btnNavConsulta";
            btnNavConsulta.Size = new Size(75, 23);
            btnNavConsulta.TabIndex = 2;
            btnNavConsulta.Click += btnNavConsulta_Click;
            // 
            // btnNavAnalisis
            // 
            btnNavAnalisis.Location = new Point(0, 0);
            btnNavAnalisis.Name = "btnNavAnalisis";
            btnNavAnalisis.Size = new Size(75, 23);
            btnNavAnalisis.TabIndex = 3;
            btnNavAnalisis.Click += btnNavAnalisis_Click;
            // 
            // btnNavFavoritos
            // 
            btnNavFavoritos.Location = new Point(0, 0);
            btnNavFavoritos.Name = "btnNavFavoritos";
            btnNavFavoritos.Size = new Size(75, 23);
            btnNavFavoritos.TabIndex = 4;
            btnNavFavoritos.Click += btnNavFavoritos_Click;
            // 
            // lblNavLabelSistema
            // 
            lblNavLabelSistema.Font = new Font("Segoe UI", 7.5F, FontStyle.Bold);
            lblNavLabelSistema.ForeColor = Color.FromArgb(65, 90, 125);
            lblNavLabelSistema.Location = new Point(18, 244);
            lblNavLabelSistema.Name = "lblNavLabelSistema";
            lblNavLabelSistema.Size = new Size(174, 18);
            lblNavLabelSistema.TabIndex = 5;
            lblNavLabelSistema.Text = "SISTEMA";
            // 
            // btnNavConfig
            // 
            btnNavConfig.Location = new Point(0, 0);
            btnNavConfig.Name = "btnNavConfig";
            btnNavConfig.Size = new Size(75, 23);
            btnNavConfig.TabIndex = 6;
            btnNavConfig.Click += btnNavConfig_Click;
            // 
            // pnlSidebarFooter
            // 
            pnlSidebarFooter.BackColor = Color.FromArgb(10, 20, 35);
            pnlSidebarFooter.Controls.Add(lblSidebarStatusAPI);
            pnlSidebarFooter.Controls.Add(lblSidebarStatusSQLite);
            pnlSidebarFooter.Controls.Add(lblSidebarStatusRegs);
            pnlSidebarFooter.Dock = DockStyle.Bottom;
            pnlSidebarFooter.Location = new Point(0, 694);
            pnlSidebarFooter.Name = "pnlSidebarFooter";
            pnlSidebarFooter.Size = new Size(210, 80);
            pnlSidebarFooter.TabIndex = 7;
            // 
            // lblSidebarStatusAPI
            // 
            lblSidebarStatusAPI.AutoSize = true;
            lblSidebarStatusAPI.Font = new Font("Segoe UI", 8.5F);
            lblSidebarStatusAPI.ForeColor = Color.FromArgb(99, 153, 34);
            lblSidebarStatusAPI.Location = new Point(18, 12);
            lblSidebarStatusAPI.Name = "lblSidebarStatusAPI";
            lblSidebarStatusAPI.Size = new Size(129, 20);
            lblSidebarStatusAPI.TabIndex = 0;
            lblSidebarStatusAPI.Text = "● Open-Meteo: —";
            // 
            // lblSidebarStatusSQLite
            // 
            lblSidebarStatusSQLite.AutoSize = true;
            lblSidebarStatusSQLite.Font = new Font("Segoe UI", 8.5F);
            lblSidebarStatusSQLite.ForeColor = Color.FromArgb(186, 117, 23);
            lblSidebarStatusSQLite.Location = new Point(18, 32);
            lblSidebarStatusSQLite.Name = "lblSidebarStatusSQLite";
            lblSidebarStatusSQLite.Size = new Size(139, 20);
            lblSidebarStatusSQLite.TabIndex = 1;
            lblSidebarStatusSQLite.Text = "● SQLite: pendiente";
            // 
            // lblSidebarStatusRegs
            // 
            lblSidebarStatusRegs.AutoSize = true;
            lblSidebarStatusRegs.Font = new Font("Segoe UI", 8F);
            lblSidebarStatusRegs.ForeColor = Color.FromArgb(70, 95, 130);
            lblSidebarStatusRegs.Location = new Point(18, 56);
            lblSidebarStatusRegs.Name = "lblSidebarStatusRegs";
            lblSidebarStatusRegs.Size = new Size(139, 19);
            lblSidebarStatusRegs.TabIndex = 2;
            lblSidebarStatusRegs.Text = "— registros cargados";
            // 
            // pnlMainContent
            // 
            pnlMainContent.Controls.Add(tabControl);
            pnlMainContent.Controls.Add(pnlTopBar);
            pnlMainContent.Dock = DockStyle.Fill;
            pnlMainContent.Location = new Point(210, 0);
            pnlMainContent.Name = "pnlMainContent";
            pnlMainContent.Size = new Size(1070, 774);
            pnlMainContent.TabIndex = 0;
            // 
            // tabControl
            // 
            tabControl.Appearance = TabAppearance.FlatButtons;
            tabControl.Controls.Add(tabConsulta);
            tabControl.Controls.Add(tabAnalisis);
            tabControl.Controls.Add(tabFavoritos);
            tabControl.Controls.Add(tabConfig);
            tabControl.Dock = DockStyle.Fill;
            tabControl.ItemSize = new Size(0, 1);
            tabControl.Location = new Point(0, 60);
            tabControl.Margin = new Padding(0);
            tabControl.Name = "tabControl";
            tabControl.Padding = new Point(0, 0);
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(1070, 714);
            tabControl.SizeMode = TabSizeMode.Fixed;
            tabControl.TabIndex = 0;
            // 
            // tabConsulta
            // 
            tabConsulta.BackColor = Color.FromArgb(244, 247, 250);
            tabConsulta.Controls.Add(tblTarjetas);
            tabConsulta.Controls.Add(grpBusqueda);
            tabConsulta.Location = new Point(4, 5);
            tabConsulta.Name = "tabConsulta";
            tabConsulta.Padding = new Padding(16);
            tabConsulta.Size = new Size(1062, 705);
            tabConsulta.TabIndex = 0;
            tabConsulta.Text = "Consulta";
            // 
            // tblTarjetas
            // 
            tblTarjetas.ColumnCount = 3;
            tblTarjetas.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33F));
            tblTarjetas.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33F));
            tblTarjetas.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.34F));
            tblTarjetas.Controls.Add(grpDatosActuales, 0, 0);
            tblTarjetas.Controls.Add(grpHistorico, 1, 0);
            tblTarjetas.Controls.Add(grpAnomalia, 2, 0);
            tblTarjetas.Dock = DockStyle.Top;
            tblTarjetas.Location = new Point(16, 116);
            tblTarjetas.Name = "tblTarjetas";
            tblTarjetas.Padding = new Padding(0, 14, 0, 0);
            tblTarjetas.RowCount = 1;
            tblTarjetas.RowStyles.Add(new RowStyle(SizeType.Absolute, 305F));
            tblTarjetas.Size = new Size(1030, 310);
            tblTarjetas.TabIndex = 0;
            // 
            // grpDatosActuales
            // 
            grpDatosActuales.BackColor = Color.White;
            grpDatosActuales.Controls.Add(lblFuenteAPI);
            grpDatosActuales.Controls.Add(lblTempActualVal);
            grpDatosActuales.Controls.Add(lblTempActualSub);
            grpDatosActuales.Controls.Add(lblMunicipioKey);
            grpDatosActuales.Controls.Add(lblMunicipioVal);
            grpDatosActuales.Controls.Add(lblEstadoActKey);
            grpDatosActuales.Controls.Add(lblEstadoActVal);
            grpDatosActuales.Controls.Add(lblMinActKey);
            grpDatosActuales.Controls.Add(lblMinActVal);
            grpDatosActuales.Controls.Add(lblMaxActKey);
            grpDatosActuales.Controls.Add(lblMaxActVal);
            grpDatosActuales.Controls.Add(lblCoordsVal);
            grpDatosActuales.Dock = DockStyle.Fill;
            grpDatosActuales.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            grpDatosActuales.ForeColor = Color.FromArgb(24, 95, 165);
            grpDatosActuales.Location = new Point(0, 14);
            grpDatosActuales.Margin = new Padding(0, 0, 8, 0);
            grpDatosActuales.Name = "grpDatosActuales";
            grpDatosActuales.Size = new Size(335, 305);
            grpDatosActuales.TabIndex = 0;
            grpDatosActuales.TabStop = false;
            grpDatosActuales.Text = "Temperatura actual";
            // 
            // lblFuenteAPI
            // 
            lblFuenteAPI.AutoSize = true;
            lblFuenteAPI.BackColor = Color.FromArgb(230, 241, 251);
            lblFuenteAPI.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            lblFuenteAPI.ForeColor = Color.FromArgb(24, 95, 165);
            lblFuenteAPI.Location = new Point(16, 30);
            lblFuenteAPI.Name = "lblFuenteAPI";
            lblFuenteAPI.Padding = new Padding(6, 2, 6, 2);
            lblFuenteAPI.Size = new Size(165, 24);
            lblFuenteAPI.TabIndex = 0;
            lblFuenteAPI.Text = "Fuente: Open-Meteo";
            // 
            // lblTempActualVal
            // 
            lblTempActualVal.AutoSize = true;
            lblTempActualVal.Font = new Font("Segoe UI", 32F, FontStyle.Bold);
            lblTempActualVal.ForeColor = Color.FromArgb(24, 95, 165);
            lblTempActualVal.Location = new Point(16, 58);
            lblTempActualVal.Name = "lblTempActualVal";
            lblTempActualVal.Size = new Size(84, 72);
            lblTempActualVal.TabIndex = 1;
            lblTempActualVal.Text = "—";
            // 
            // lblTempActualSub
            // 
            lblTempActualSub.AutoSize = true;
            lblTempActualSub.Font = new Font("Segoe UI", 8.5F);
            lblTempActualSub.ForeColor = Color.FromArgb(140, 155, 175);
            lblTempActualSub.Location = new Point(20, 118);
            lblTempActualSub.Name = "lblTempActualSub";
            lblTempActualSub.Size = new Size(137, 20);
            lblTempActualSub.TabIndex = 2;
            lblTempActualSub.Text = "Temperatura actual";
            // 
            // lblMunicipioKey
            // 
            lblMunicipioKey.Location = new Point(0, 0);
            lblMunicipioKey.Name = "lblMunicipioKey";
            lblMunicipioKey.Size = new Size(100, 23);
            lblMunicipioKey.TabIndex = 3;
            // 
            // lblMunicipioVal
            // 
            lblMunicipioVal.Location = new Point(0, 0);
            lblMunicipioVal.Name = "lblMunicipioVal";
            lblMunicipioVal.Size = new Size(100, 23);
            lblMunicipioVal.TabIndex = 4;
            // 
            // lblEstadoActKey
            // 
            lblEstadoActKey.Location = new Point(0, 0);
            lblEstadoActKey.Name = "lblEstadoActKey";
            lblEstadoActKey.Size = new Size(100, 23);
            lblEstadoActKey.TabIndex = 5;
            // 
            // lblEstadoActVal
            // 
            lblEstadoActVal.Location = new Point(0, 0);
            lblEstadoActVal.Name = "lblEstadoActVal";
            lblEstadoActVal.Size = new Size(100, 23);
            lblEstadoActVal.TabIndex = 6;
            // 
            // lblMinActKey
            // 
            lblMinActKey.Location = new Point(0, 0);
            lblMinActKey.Name = "lblMinActKey";
            lblMinActKey.Size = new Size(100, 23);
            lblMinActKey.TabIndex = 7;
            // 
            // lblMinActVal
            // 
            lblMinActVal.Location = new Point(0, 0);
            lblMinActVal.Name = "lblMinActVal";
            lblMinActVal.Size = new Size(100, 23);
            lblMinActVal.TabIndex = 8;
            // 
            // lblMaxActKey
            // 
            lblMaxActKey.Location = new Point(0, 0);
            lblMaxActKey.Name = "lblMaxActKey";
            lblMaxActKey.Size = new Size(100, 23);
            lblMaxActKey.TabIndex = 9;
            // 
            // lblMaxActVal
            // 
            lblMaxActVal.Location = new Point(0, 0);
            lblMaxActVal.Name = "lblMaxActVal";
            lblMaxActVal.Size = new Size(100, 23);
            lblMaxActVal.TabIndex = 10;
            // 
            // lblCoordsVal
            // 
            lblCoordsVal.AutoSize = true;
            lblCoordsVal.Font = new Font("Segoe UI", 8F);
            lblCoordsVal.ForeColor = Color.FromArgb(160, 175, 195);
            lblCoordsVal.Location = new Point(20, 252);
            lblCoordsVal.Name = "lblCoordsVal";
            lblCoordsVal.Size = new Size(104, 19);
            lblCoordsVal.TabIndex = 11;
            lblCoordsVal.Text = "Lat: — · Lon: —";
            // 
            // grpHistorico
            // 
            grpHistorico.BackColor = Color.White;
            grpHistorico.Controls.Add(lblFuenteCSV);
            grpHistorico.Controls.Add(lblTempHistVal);
            grpHistorico.Controls.Add(lblTempHistSub);
            grpHistorico.Controls.Add(lblEstadoHistKey);
            grpHistorico.Controls.Add(lblEstadoHistVal);
            grpHistorico.Controls.Add(lblFiltroKey);
            grpHistorico.Controls.Add(lblFiltroVal);
            grpHistorico.Controls.Add(lblMinHistKey);
            grpHistorico.Controls.Add(lblMinHistVal);
            grpHistorico.Controls.Add(lblMaxHistKey);
            grpHistorico.Controls.Add(lblMaxHistVal);
            grpHistorico.Controls.Add(lblRegistrosVal);
            grpHistorico.Dock = DockStyle.Fill;
            grpHistorico.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            grpHistorico.ForeColor = Color.FromArgb(59, 109, 17);
            grpHistorico.Location = new Point(347, 14);
            grpHistorico.Margin = new Padding(4, 0, 4, 0);
            grpHistorico.Name = "grpHistorico";
            grpHistorico.Size = new Size(335, 305);
            grpHistorico.TabIndex = 1;
            grpHistorico.TabStop = false;
            grpHistorico.Text = "Promedio histórico";
            // 
            // lblFuenteCSV
            // 
            lblFuenteCSV.AutoSize = true;
            lblFuenteCSV.BackColor = Color.FromArgb(234, 243, 222);
            lblFuenteCSV.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            lblFuenteCSV.ForeColor = Color.FromArgb(59, 109, 17);
            lblFuenteCSV.Location = new Point(16, 30);
            lblFuenteCSV.Name = "lblFuenteCSV";
            lblFuenteCSV.Padding = new Padding(6, 2, 6, 2);
            lblFuenteCSV.Size = new Size(134, 24);
            lblFuenteCSV.TabIndex = 0;
            lblFuenteCSV.Text = "Fuente: data.csv";
            // 
            // lblTempHistVal
            // 
            lblTempHistVal.AutoSize = true;
            lblTempHistVal.Font = new Font("Segoe UI", 32F, FontStyle.Bold);
            lblTempHistVal.ForeColor = Color.FromArgb(59, 109, 17);
            lblTempHistVal.Location = new Point(16, 58);
            lblTempHistVal.Name = "lblTempHistVal";
            lblTempHistVal.Size = new Size(84, 72);
            lblTempHistVal.TabIndex = 1;
            lblTempHistVal.Text = "—";
            // 
            // lblTempHistSub
            // 
            lblTempHistSub.AutoSize = true;
            lblTempHistSub.Font = new Font("Segoe UI", 8.5F);
            lblTempHistSub.ForeColor = Color.FromArgb(140, 155, 175);
            lblTempHistSub.Location = new Point(20, 118);
            lblTempHistSub.Name = "lblTempHistSub";
            lblTempHistSub.Size = new Size(135, 20);
            lblTempHistSub.TabIndex = 2;
            lblTempHistSub.Text = "Promedio histórico";
            // 
            // lblEstadoHistKey
            // 
            lblEstadoHistKey.Location = new Point(0, 0);
            lblEstadoHistKey.Name = "lblEstadoHistKey";
            lblEstadoHistKey.Size = new Size(100, 23);
            lblEstadoHistKey.TabIndex = 3;
            // 
            // lblEstadoHistVal
            // 
            lblEstadoHistVal.Location = new Point(0, 0);
            lblEstadoHistVal.Name = "lblEstadoHistVal";
            lblEstadoHistVal.Size = new Size(100, 23);
            lblEstadoHistVal.TabIndex = 4;
            // 
            // lblFiltroKey
            // 
            lblFiltroKey.Location = new Point(0, 0);
            lblFiltroKey.Name = "lblFiltroKey";
            lblFiltroKey.Size = new Size(100, 23);
            lblFiltroKey.TabIndex = 5;
            // 
            // lblFiltroVal
            // 
            lblFiltroVal.Location = new Point(0, 0);
            lblFiltroVal.Name = "lblFiltroVal";
            lblFiltroVal.Size = new Size(100, 23);
            lblFiltroVal.TabIndex = 6;
            // 
            // lblMinHistKey
            // 
            lblMinHistKey.Location = new Point(0, 0);
            lblMinHistKey.Name = "lblMinHistKey";
            lblMinHistKey.Size = new Size(100, 23);
            lblMinHistKey.TabIndex = 7;
            // 
            // lblMinHistVal
            // 
            lblMinHistVal.Location = new Point(0, 0);
            lblMinHistVal.Name = "lblMinHistVal";
            lblMinHistVal.Size = new Size(100, 23);
            lblMinHistVal.TabIndex = 8;
            // 
            // lblMaxHistKey
            // 
            lblMaxHistKey.Location = new Point(0, 0);
            lblMaxHistKey.Name = "lblMaxHistKey";
            lblMaxHistKey.Size = new Size(100, 23);
            lblMaxHistKey.TabIndex = 9;
            // 
            // lblMaxHistVal
            // 
            lblMaxHistVal.Location = new Point(0, 0);
            lblMaxHistVal.Name = "lblMaxHistVal";
            lblMaxHistVal.Size = new Size(100, 23);
            lblMaxHistVal.TabIndex = 10;
            // 
            // lblRegistrosVal
            // 
            lblRegistrosVal.AutoSize = true;
            lblRegistrosVal.Font = new Font("Segoe UI", 8F);
            lblRegistrosVal.ForeColor = Color.FromArgb(160, 175, 195);
            lblRegistrosVal.Location = new Point(20, 252);
            lblRegistrosVal.Name = "lblRegistrosVal";
            lblRegistrosVal.Size = new Size(198, 19);
            lblRegistrosVal.TabIndex = 11;
            lblRegistrosVal.Text = "Basado en — registros del CSV";
            // 
            // grpAnomalia
            // 
            grpAnomalia.BackColor = Color.White;
            grpAnomalia.Controls.Add(lblDesviacionKey);
            grpAnomalia.Controls.Add(lblDesviacionVal);
            grpAnomalia.Controls.Add(lblDescAnomalia);
            grpAnomalia.Controls.Add(lblNivelKey);
            grpAnomalia.Controls.Add(pnlSemaforoVerde);
            grpAnomalia.Controls.Add(pnlSemaforoAmarillo);
            grpAnomalia.Controls.Add(pnlSemaforoRojo);
            grpAnomalia.Controls.Add(lblSemaforoTexto);
            grpAnomalia.Controls.Add(btnGuardarAlerta);
            grpAnomalia.Dock = DockStyle.Fill;
            grpAnomalia.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            grpAnomalia.ForeColor = Color.FromArgb(186, 117, 23);
            grpAnomalia.Location = new Point(694, 14);
            grpAnomalia.Margin = new Padding(8, 0, 0, 0);
            grpAnomalia.Name = "grpAnomalia";
            grpAnomalia.Size = new Size(336, 305);
            grpAnomalia.TabIndex = 2;
            grpAnomalia.TabStop = false;
            grpAnomalia.Text = "Anomalía detectada";
            // 
            // lblDesviacionKey
            // 
            lblDesviacionKey.AutoSize = true;
            lblDesviacionKey.BackColor = Color.FromArgb(250, 238, 218);
            lblDesviacionKey.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            lblDesviacionKey.ForeColor = Color.FromArgb(186, 117, 23);
            lblDesviacionKey.Location = new Point(16, 30);
            lblDesviacionKey.Name = "lblDesviacionKey";
            lblDesviacionKey.Padding = new Padding(6, 2, 6, 2);
            lblDesviacionKey.Size = new Size(169, 24);
            lblDesviacionKey.TabIndex = 0;
            lblDesviacionKey.Text = "Desviación detectada";
            // 
            // lblDesviacionVal
            // 
            lblDesviacionVal.AutoSize = true;
            lblDesviacionVal.Font = new Font("Segoe UI", 32F, FontStyle.Bold);
            lblDesviacionVal.ForeColor = Color.FromArgb(186, 117, 23);
            lblDesviacionVal.Location = new Point(16, 58);
            lblDesviacionVal.Name = "lblDesviacionVal";
            lblDesviacionVal.Size = new Size(84, 72);
            lblDesviacionVal.TabIndex = 1;
            lblDesviacionVal.Text = "—";
            // 
            // lblDescAnomalia
            // 
            lblDescAnomalia.Font = new Font("Segoe UI", 8.5F);
            lblDescAnomalia.ForeColor = Color.FromArgb(140, 155, 175);
            lblDescAnomalia.Location = new Point(20, 118);
            lblDescAnomalia.Name = "lblDescAnomalia";
            lblDescAnomalia.Size = new Size(320, 38);
            lblDescAnomalia.TabIndex = 2;
            lblDescAnomalia.Text = "Realiza una consulta para evaluar el riesgo climático.";
            // 
            // lblNivelKey
            // 
            lblNivelKey.AutoSize = true;
            lblNivelKey.Font = new Font("Segoe UI", 8.5F);
            lblNivelKey.ForeColor = Color.FromArgb(90, 105, 125);
            lblNivelKey.Location = new Point(20, 168);
            lblNivelKey.Name = "lblNivelKey";
            lblNivelKey.Size = new Size(106, 20);
            lblNivelKey.TabIndex = 3;
            lblNivelKey.Text = "Nivel de alerta";
            // 
            // pnlSemaforoVerde
            // 
            pnlSemaforoVerde.BackColor = Color.FromArgb(210, 220, 215);
            pnlSemaforoVerde.Location = new Point(20, 192);
            pnlSemaforoVerde.Name = "pnlSemaforoVerde";
            pnlSemaforoVerde.Size = new Size(42, 12);
            pnlSemaforoVerde.TabIndex = 4;
            // 
            // pnlSemaforoAmarillo
            // 
            pnlSemaforoAmarillo.BackColor = Color.FromArgb(210, 220, 215);
            pnlSemaforoAmarillo.Location = new Point(68, 192);
            pnlSemaforoAmarillo.Name = "pnlSemaforoAmarillo";
            pnlSemaforoAmarillo.Size = new Size(42, 12);
            pnlSemaforoAmarillo.TabIndex = 5;
            // 
            // pnlSemaforoRojo
            // 
            pnlSemaforoRojo.BackColor = Color.FromArgb(210, 220, 215);
            pnlSemaforoRojo.Location = new Point(116, 192);
            pnlSemaforoRojo.Name = "pnlSemaforoRojo";
            pnlSemaforoRojo.Size = new Size(42, 12);
            pnlSemaforoRojo.TabIndex = 6;
            // 
            // lblSemaforoTexto
            // 
            lblSemaforoTexto.AutoSize = true;
            lblSemaforoTexto.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblSemaforoTexto.ForeColor = Color.FromArgb(90, 105, 125);
            lblSemaforoTexto.Location = new Point(168, 188);
            lblSemaforoTexto.Name = "lblSemaforoTexto";
            lblSemaforoTexto.Size = new Size(24, 20);
            lblSemaforoTexto.TabIndex = 7;
            lblSemaforoTexto.Text = "—";
            // 
            // btnGuardarAlerta
            // 
            btnGuardarAlerta.BackColor = Color.FromArgb(163, 45, 45);
            btnGuardarAlerta.Cursor = Cursors.Hand;
            btnGuardarAlerta.Enabled = false;
            btnGuardarAlerta.FlatAppearance.BorderSize = 0;
            btnGuardarAlerta.FlatStyle = FlatStyle.Flat;
            btnGuardarAlerta.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnGuardarAlerta.ForeColor = Color.White;
            btnGuardarAlerta.Location = new Point(20, 224);
            btnGuardarAlerta.Name = "btnGuardarAlerta";
            btnGuardarAlerta.Size = new Size(155, 34);
            btnGuardarAlerta.TabIndex = 8;
            btnGuardarAlerta.Text = "Guardar alerta";
            btnGuardarAlerta.UseVisualStyleBackColor = false;
            // 
            // grpBusqueda
            // 
            grpBusqueda.BackColor = Color.White;
            grpBusqueda.Controls.Add(lblEstado);
            grpBusqueda.Controls.Add(cmbEstado);
            grpBusqueda.Controls.Add(lblMunicipio);
            grpBusqueda.Controls.Add(cmbMunicipio);
            grpBusqueda.Controls.Add(lblAnio);
            grpBusqueda.Controls.Add(cmbAnio);
            grpBusqueda.Controls.Add(lblEstacion);
            grpBusqueda.Controls.Add(cmbEstacion);
            grpBusqueda.Controls.Add(btnConsultar);
            grpBusqueda.Controls.Add(btnLimpiar);
            grpBusqueda.Dock = DockStyle.Top;
            grpBusqueda.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            grpBusqueda.ForeColor = Color.FromArgb(90, 105, 125);
            grpBusqueda.Location = new Point(16, 16);
            grpBusqueda.Name = "grpBusqueda";
            grpBusqueda.Padding = new Padding(8);
            grpBusqueda.Size = new Size(1030, 100);
            grpBusqueda.TabIndex = 1;
            grpBusqueda.TabStop = false;
            grpBusqueda.Text = "Parámetros de consulta";
            // 
            // lblEstado
            // 
            lblEstado.Location = new Point(0, 0);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(100, 23);
            lblEstado.TabIndex = 0;
            // 
            // cmbEstado
            // 
            cmbEstado.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbEstado.Location = new Point(0, 0);
            cmbEstado.Name = "cmbEstado";
            cmbEstado.Size = new Size(121, 28);
            cmbEstado.TabIndex = 1;
            cmbEstado.SelectedIndexChanged += cmbEstado_SelectedIndexChanged_1;
            // 
            // lblMunicipio
            // 
            lblMunicipio.Location = new Point(0, 0);
            lblMunicipio.Name = "lblMunicipio";
            lblMunicipio.Size = new Size(100, 23);
            lblMunicipio.TabIndex = 2;
            // 
            // cmbMunicipio
            // 
            cmbMunicipio.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbMunicipio.Enabled = false;
            cmbMunicipio.Location = new Point(0, 0);
            cmbMunicipio.Name = "cmbMunicipio";
            cmbMunicipio.Size = new Size(121, 28);
            cmbMunicipio.TabIndex = 3;
            cmbMunicipio.SelectedIndexChanged += cmbMunicipio_SelectedIndexChanged_1;
            // 
            // lblAnio
            // 
            lblAnio.Location = new Point(0, 0);
            lblAnio.Name = "lblAnio";
            lblAnio.Size = new Size(100, 23);
            lblAnio.TabIndex = 4;
            // 
            // cmbAnio
            // 
            cmbAnio.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbAnio.Location = new Point(0, 0);
            cmbAnio.Name = "cmbAnio";
            cmbAnio.Size = new Size(121, 28);
            cmbAnio.TabIndex = 5;
            // 
            // lblEstacion
            // 
            lblEstacion.Location = new Point(0, 0);
            lblEstacion.Name = "lblEstacion";
            lblEstacion.Size = new Size(100, 23);
            lblEstacion.TabIndex = 6;
            // 
            // cmbEstacion
            // 
            cmbEstacion.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbEstacion.Items.AddRange(new object[] { "Primavera", "Verano", "Otoño", "Invierno" });
            cmbEstacion.Location = new Point(0, 0);
            cmbEstacion.Name = "cmbEstacion";
            cmbEstacion.Size = new Size(121, 28);
            cmbEstacion.TabIndex = 7;
            // 
            // btnConsultar
            // 
            btnConsultar.BackColor = Color.FromArgb(24, 95, 165);
            btnConsultar.Cursor = Cursors.Hand;
            btnConsultar.Enabled = false;
            btnConsultar.FlatAppearance.BorderSize = 0;
            btnConsultar.FlatAppearance.MouseOverBackColor = Color.FromArgb(18, 77, 138);
            btnConsultar.FlatStyle = FlatStyle.Flat;
            btnConsultar.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnConsultar.ForeColor = Color.White;
            btnConsultar.Location = new Point(740, 48);
            btnConsultar.Name = "btnConsultar";
            btnConsultar.Size = new Size(120, 34);
            btnConsultar.TabIndex = 8;
            btnConsultar.Text = "Consultar";
            btnConsultar.UseVisualStyleBackColor = false;
            btnConsultar.Click += btnConsultar_Click_1;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = Color.FromArgb(244, 247, 250);
            btnLimpiar.Cursor = Cursors.Hand;
            btnLimpiar.FlatAppearance.BorderColor = Color.FromArgb(210, 218, 230);
            btnLimpiar.FlatStyle = FlatStyle.Flat;
            btnLimpiar.Font = new Font("Segoe UI", 9.5F);
            btnLimpiar.ForeColor = Color.FromArgb(90, 105, 125);
            btnLimpiar.Location = new Point(872, 48);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(100, 34);
            btnLimpiar.TabIndex = 9;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = false;
            // 
            // tabAnalisis
            // 
            tabAnalisis.BackColor = Color.FromArgb(244, 247, 250);
            tabAnalisis.Controls.Add(pnlCharts);
            tabAnalisis.Controls.Add(grpRanking);
            tabAnalisis.Controls.Add(grpFiltrosGlobal);
            tabAnalisis.Location = new Point(4, 5);
            tabAnalisis.Name = "tabAnalisis";
            tabAnalisis.Padding = new Padding(16);
            tabAnalisis.Size = new Size(192, 31);
            tabAnalisis.TabIndex = 1;
            tabAnalisis.Text = "Análisis global";
            // 
            // pnlCharts
            // 
            pnlCharts.Controls.Add(pnlDer);
            pnlCharts.Controls.Add(pnlIzq);
            pnlCharts.Dock = DockStyle.Fill;
            pnlCharts.Location = new Point(16, 92);
            pnlCharts.Name = "pnlCharts";
            pnlCharts.Size = new Size(160, 0);
            pnlCharts.TabIndex = 0;
            // 
            // pnlDer
            // 
            pnlDer.Controls.Add(formsPlotFrios);
            pnlDer.Dock = DockStyle.Fill;
            pnlDer.Location = new Point(0, 0);
            pnlDer.Name = "pnlDer";
            pnlDer.Size = new Size(160, 0);
            pnlDer.TabIndex = 0;
            // 
            // formsPlotFrios
            // 
            formsPlotFrios.Dock = DockStyle.Fill;
            formsPlotFrios.Location = new Point(0, 0);
            formsPlotFrios.Name = "formsPlotFrios";
            formsPlotFrios.Size = new Size(160, 0);
            formsPlotFrios.TabIndex = 0;
            // 
            // pnlIzq
            // 
            pnlIzq.Controls.Add(formsPlotCalientes);
            pnlIzq.Dock = DockStyle.Left;
            pnlIzq.Location = new Point(0, 0);
            pnlIzq.Name = "pnlIzq";
            pnlIzq.Size = new Size(0, 0);
            pnlIzq.TabIndex = 1;
            // 
            // formsPlotCalientes
            // 
            formsPlotCalientes.Dock = DockStyle.Fill;
            formsPlotCalientes.Location = new Point(0, 0);
            formsPlotCalientes.Name = "formsPlotCalientes";
            formsPlotCalientes.Size = new Size(0, 0);
            formsPlotCalientes.TabIndex = 0;
            // 
            // grpRanking
            // 
            grpRanking.BackColor = Color.White;
            grpRanking.Controls.Add(lblRankingCaliente);
            grpRanking.Controls.Add(lstCalientes);
            grpRanking.Controls.Add(lblRankingFrio);
            grpRanking.Controls.Add(lstFrios);
            grpRanking.Controls.Add(btnExportarRanking);
            grpRanking.Dock = DockStyle.Bottom;
            grpRanking.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            grpRanking.ForeColor = Color.FromArgb(90, 105, 125);
            grpRanking.Location = new Point(16, -137);
            grpRanking.Name = "grpRanking";
            grpRanking.Size = new Size(160, 152);
            grpRanking.TabIndex = 1;
            grpRanking.TabStop = false;
            grpRanking.Text = "Ranking climático";
            // 
            // lblRankingCaliente
            // 
            lblRankingCaliente.AutoSize = true;
            lblRankingCaliente.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblRankingCaliente.ForeColor = Color.FromArgb(163, 45, 45);
            lblRankingCaliente.Location = new Point(16, 26);
            lblRankingCaliente.Name = "lblRankingCaliente";
            lblRankingCaliente.Size = new Size(158, 21);
            lblRankingCaliente.TabIndex = 0;
            lblRankingCaliente.Text = "Top 5 más calientes";
            // 
            // lstCalientes
            // 
            lstCalientes.BorderStyle = BorderStyle.FixedSingle;
            lstCalientes.Font = new Font("Segoe UI", 9F);
            lstCalientes.Location = new Point(16, 52);
            lstCalientes.Name = "lstCalientes";
            lstCalientes.Size = new Size(490, 82);
            lstCalientes.TabIndex = 1;
            // 
            // lblRankingFrio
            // 
            lblRankingFrio.AutoSize = true;
            lblRankingFrio.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblRankingFrio.ForeColor = Color.FromArgb(24, 95, 165);
            lblRankingFrio.Location = new Point(550, 26);
            lblRankingFrio.Name = "lblRankingFrio";
            lblRankingFrio.Size = new Size(124, 21);
            lblRankingFrio.TabIndex = 2;
            lblRankingFrio.Text = "Top 5 más fríos";
            // 
            // lstFrios
            // 
            lstFrios.BorderStyle = BorderStyle.FixedSingle;
            lstFrios.Font = new Font("Segoe UI", 9F);
            lstFrios.Location = new Point(550, 52);
            lstFrios.Name = "lstFrios";
            lstFrios.Size = new Size(490, 82);
            lstFrios.TabIndex = 3;
            // 
            // btnExportarRanking
            // 
            btnExportarRanking.BackColor = Color.FromArgb(45, 100, 163);
            btnExportarRanking.Cursor = Cursors.Hand;
            btnExportarRanking.FlatAppearance.BorderSize = 0;
            btnExportarRanking.FlatStyle = FlatStyle.Flat;
            btnExportarRanking.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnExportarRanking.ForeColor = Color.White;
            btnExportarRanking.Location = new Point(900, 30);
            btnExportarRanking.Name = "btnExportarRanking";
            btnExportarRanking.Size = new Size(130, 34);
            btnExportarRanking.TabIndex = 4;
            btnExportarRanking.Text = "Exportar Ranking ";
            btnExportarRanking.UseVisualStyleBackColor = false;
            // 
            // grpFiltrosGlobal
            // 
            grpFiltrosGlobal.BackColor = Color.White;
            grpFiltrosGlobal.Controls.Add(lblFiltroAnio);
            grpFiltrosGlobal.Controls.Add(cmbFiltroAnio);
            grpFiltrosGlobal.Controls.Add(lblFiltroEstacion);
            grpFiltrosGlobal.Controls.Add(cmbFiltroEstacion);
            grpFiltrosGlobal.Controls.Add(lblBuscarEstado);
            grpFiltrosGlobal.Controls.Add(txtBuscarEstado);
            grpFiltrosGlobal.Controls.Add(btnFiltrar);
            grpFiltrosGlobal.Controls.Add(btnLimpiarFiltro);
            grpFiltrosGlobal.Dock = DockStyle.Top;
            grpFiltrosGlobal.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            grpFiltrosGlobal.ForeColor = Color.FromArgb(90, 105, 125);
            grpFiltrosGlobal.Location = new Point(16, 16);
            grpFiltrosGlobal.Name = "grpFiltrosGlobal";
            grpFiltrosGlobal.Size = new Size(160, 76);
            grpFiltrosGlobal.TabIndex = 2;
            grpFiltrosGlobal.TabStop = false;
            grpFiltrosGlobal.Text = "Filtros";
            // 
            // lblFiltroAnio
            // 
            lblFiltroAnio.Location = new Point(0, 0);
            lblFiltroAnio.Name = "lblFiltroAnio";
            lblFiltroAnio.Size = new Size(100, 23);
            lblFiltroAnio.TabIndex = 0;
            // 
            // cmbFiltroAnio
            // 
            cmbFiltroAnio.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbFiltroAnio.Location = new Point(0, 0);
            cmbFiltroAnio.Name = "cmbFiltroAnio";
            cmbFiltroAnio.Size = new Size(121, 28);
            cmbFiltroAnio.TabIndex = 1;
            // 
            // lblFiltroEstacion
            // 
            lblFiltroEstacion.Location = new Point(0, 0);
            lblFiltroEstacion.Name = "lblFiltroEstacion";
            lblFiltroEstacion.Size = new Size(100, 23);
            lblFiltroEstacion.TabIndex = 2;
            // 
            // cmbFiltroEstacion
            // 
            cmbFiltroEstacion.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbFiltroEstacion.Items.AddRange(new object[] { "Todas", "Primavera", "Verano", "Otoño", "Invierno" });
            cmbFiltroEstacion.Location = new Point(0, 0);
            cmbFiltroEstacion.Name = "cmbFiltroEstacion";
            cmbFiltroEstacion.Size = new Size(121, 28);
            cmbFiltroEstacion.TabIndex = 3;
            // 
            // lblBuscarEstado
            // 
            lblBuscarEstado.Location = new Point(0, 0);
            lblBuscarEstado.Name = "lblBuscarEstado";
            lblBuscarEstado.Size = new Size(100, 23);
            lblBuscarEstado.TabIndex = 4;
            // 
            // txtBuscarEstado
            // 
            txtBuscarEstado.Font = new Font("Segoe UI", 9.5F);
            txtBuscarEstado.Location = new Point(468, 30);
            txtBuscarEstado.Name = "txtBuscarEstado";
            txtBuscarEstado.Size = new Size(210, 29);
            txtBuscarEstado.TabIndex = 5;
            // 
            // btnFiltrar
            // 
            btnFiltrar.Location = new Point(0, 0);
            btnFiltrar.Name = "btnFiltrar";
            btnFiltrar.Size = new Size(75, 23);
            btnFiltrar.TabIndex = 6;
            // 
            // btnLimpiarFiltro
            // 
            btnLimpiarFiltro.Location = new Point(0, 0);
            btnLimpiarFiltro.Name = "btnLimpiarFiltro";
            btnLimpiarFiltro.Size = new Size(75, 23);
            btnLimpiarFiltro.TabIndex = 7;
            // 
            // tabFavoritos
            // 
            tabFavoritos.BackColor = Color.FromArgb(244, 247, 250);
            tabFavoritos.Controls.Add(dgvFavoritos);
            tabFavoritos.Controls.Add(grpAgregarFav);
            tabFavoritos.Location = new Point(4, 5);
            tabFavoritos.Name = "tabFavoritos";
            tabFavoritos.Padding = new Padding(16);
            tabFavoritos.Size = new Size(1062, 705);
            tabFavoritos.TabIndex = 2;
            tabFavoritos.Text = "Favoritos";
            // 
            // dgvFavoritos
            // 
            dgvFavoritos.ColumnHeadersHeight = 29;
            dgvFavoritos.Dock = DockStyle.Fill;
            dgvFavoritos.Location = new Point(16, 16);
            dgvFavoritos.Name = "dgvFavoritos";
            dgvFavoritos.RowHeadersWidth = 51;
            dgvFavoritos.Size = new Size(1030, 593);
            dgvFavoritos.TabIndex = 0;
            // 
            // grpAgregarFav
            // 
            grpAgregarFav.BackColor = Color.White;
            grpAgregarFav.Controls.Add(lblNuevoFavEstado);
            grpAgregarFav.Controls.Add(cmbNuevoFavEstado);
            grpAgregarFav.Controls.Add(lblNuevoFavMun);
            grpAgregarFav.Controls.Add(cmbNuevoFavMun);
            grpAgregarFav.Controls.Add(btnAgregarFav);
            grpAgregarFav.Controls.Add(btnEliminarFav);
            grpAgregarFav.Controls.Add(btnMigrar);
            grpAgregarFav.Dock = DockStyle.Bottom;
            grpAgregarFav.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            grpAgregarFav.ForeColor = Color.FromArgb(90, 105, 125);
            grpAgregarFav.Location = new Point(16, 609);
            grpAgregarFav.Name = "grpAgregarFav";
            grpAgregarFav.Size = new Size(1030, 80);
            grpAgregarFav.TabIndex = 1;
            grpAgregarFav.TabStop = false;
            grpAgregarFav.Text = "Agregar municipio favorito";
            // 
            // lblNuevoFavEstado
            // 
            lblNuevoFavEstado.Location = new Point(0, 0);
            lblNuevoFavEstado.Name = "lblNuevoFavEstado";
            lblNuevoFavEstado.Size = new Size(100, 23);
            lblNuevoFavEstado.TabIndex = 0;
            // 
            // cmbNuevoFavEstado
            // 
            cmbNuevoFavEstado.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbNuevoFavEstado.Location = new Point(0, 0);
            cmbNuevoFavEstado.Name = "cmbNuevoFavEstado";
            cmbNuevoFavEstado.Size = new Size(121, 28);
            cmbNuevoFavEstado.TabIndex = 1;
            // 
            // lblNuevoFavMun
            // 
            lblNuevoFavMun.Location = new Point(0, 0);
            lblNuevoFavMun.Name = "lblNuevoFavMun";
            lblNuevoFavMun.Size = new Size(100, 23);
            lblNuevoFavMun.TabIndex = 2;
            // 
            // cmbNuevoFavMun
            // 
            cmbNuevoFavMun.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbNuevoFavMun.Enabled = false;
            cmbNuevoFavMun.Location = new Point(0, 0);
            cmbNuevoFavMun.Name = "cmbNuevoFavMun";
            cmbNuevoFavMun.Size = new Size(121, 28);
            cmbNuevoFavMun.TabIndex = 3;
            // 
            // btnAgregarFav
            // 
            btnAgregarFav.BackColor = Color.FromArgb(24, 95, 165);
            btnAgregarFav.Cursor = Cursors.Hand;
            btnAgregarFav.FlatAppearance.BorderSize = 0;
            btnAgregarFav.FlatStyle = FlatStyle.Flat;
            btnAgregarFav.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnAgregarFav.ForeColor = Color.White;
            btnAgregarFav.Location = new Point(660, 30);
            btnAgregarFav.Name = "btnAgregarFav";
            btnAgregarFav.Size = new Size(100, 34);
            btnAgregarFav.TabIndex = 4;
            btnAgregarFav.Text = "Agregar";
            btnAgregarFav.UseVisualStyleBackColor = false;
            // 
            // btnEliminarFav
            // 
            btnEliminarFav.Location = new Point(0, 0);
            btnEliminarFav.Name = "btnEliminarFav";
            btnEliminarFav.Size = new Size(75, 23);
            btnEliminarFav.TabIndex = 5;
            // 
            // btnMigrar
            // 
            btnMigrar.BackColor = Color.FromArgb(186, 117, 23);
            btnMigrar.Cursor = Cursors.Hand;
            btnMigrar.FlatAppearance.BorderSize = 0;
            btnMigrar.FlatStyle = FlatStyle.Flat;
            btnMigrar.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnMigrar.ForeColor = Color.White;
            btnMigrar.Location = new Point(960, 30);
            btnMigrar.Name = "btnMigrar";
            btnMigrar.Size = new Size(160, 34);
            btnMigrar.TabIndex = 6;
            btnMigrar.Text = "Migrar Favoritos";
            btnMigrar.UseVisualStyleBackColor = false;
            btnMigrar.Visible = false;
            // 
            // tabConfig
            // 
            tabConfig.BackColor = Color.FromArgb(244, 247, 250);
            tabConfig.Controls.Add(btnGuardarConfig);
            tabConfig.Controls.Add(grpPreferencias);
            tabConfig.Controls.Add(grpArchivos);
            tabConfig.Controls.Add(grpBaseDatos);
            tabConfig.Location = new Point(4, 5);
            tabConfig.Name = "tabConfig";
            tabConfig.Padding = new Padding(16);
            tabConfig.Size = new Size(192, 31);
            tabConfig.TabIndex = 3;
            tabConfig.Text = "Configuración";
            // 
            // btnGuardarConfig
            // 
            btnGuardarConfig.BackColor = Color.FromArgb(24, 95, 165);
            btnGuardarConfig.Cursor = Cursors.Hand;
            btnGuardarConfig.Dock = DockStyle.Top;
            btnGuardarConfig.FlatAppearance.BorderSize = 0;
            btnGuardarConfig.FlatAppearance.MouseOverBackColor = Color.FromArgb(18, 77, 138);
            btnGuardarConfig.FlatStyle = FlatStyle.Flat;
            btnGuardarConfig.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnGuardarConfig.ForeColor = Color.White;
            btnGuardarConfig.Location = new Point(16, 410);
            btnGuardarConfig.Name = "btnGuardarConfig";
            btnGuardarConfig.Size = new Size(160, 44);
            btnGuardarConfig.TabIndex = 0;
            btnGuardarConfig.Text = "Guardar configuración";
            btnGuardarConfig.UseVisualStyleBackColor = false;
            // 
            // grpPreferencias
            // 
            grpPreferencias.BackColor = Color.White;
            grpPreferencias.Controls.Add(lblUmbral);
            grpPreferencias.Controls.Add(nudUmbral);
            grpPreferencias.Controls.Add(lblUmbralSufijo);
            grpPreferencias.Controls.Add(lblUnidades);
            grpPreferencias.Controls.Add(rbCelsius);
            grpPreferencias.Controls.Add(rbFahrenheit);
            grpPreferencias.Dock = DockStyle.Top;
            grpPreferencias.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            grpPreferencias.ForeColor = Color.FromArgb(90, 105, 125);
            grpPreferencias.Location = new Point(16, 332);
            grpPreferencias.Name = "grpPreferencias";
            grpPreferencias.Size = new Size(160, 78);
            grpPreferencias.TabIndex = 1;
            grpPreferencias.TabStop = false;
            grpPreferencias.Text = "Preferencias";
            // 
            // lblUmbral
            // 
            lblUmbral.Location = new Point(0, 0);
            lblUmbral.Name = "lblUmbral";
            lblUmbral.Size = new Size(100, 23);
            lblUmbral.TabIndex = 0;
            // 
            // nudUmbral
            // 
            nudUmbral.DecimalPlaces = 1;
            nudUmbral.Font = new Font("Segoe UI", 9.5F);
            nudUmbral.Increment = new decimal(new int[] { 5, 0, 0, 65536 });
            nudUmbral.Location = new Point(142, 34);
            nudUmbral.Maximum = new decimal(new int[] { 20, 0, 0, 0 });
            nudUmbral.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudUmbral.Name = "nudUmbral";
            nudUmbral.Size = new Size(80, 29);
            nudUmbral.TabIndex = 1;
            nudUmbral.Value = new decimal(new int[] { 3, 0, 0, 0 });
            // 
            // lblUmbralSufijo
            // 
            lblUmbralSufijo.AutoSize = true;
            lblUmbralSufijo.Font = new Font("Segoe UI", 9.5F);
            lblUmbralSufijo.ForeColor = Color.FromArgb(90, 105, 125);
            lblUmbralSufijo.Location = new Point(232, 38);
            lblUmbralSufijo.Name = "lblUmbralSufijo";
            lblUmbralSufijo.Size = new Size(26, 21);
            lblUmbralSufijo.TabIndex = 2;
            lblUmbralSufijo.Text = "°C";
            // 
            // lblUnidades
            // 
            lblUnidades.Location = new Point(0, 0);
            lblUnidades.Name = "lblUnidades";
            lblUnidades.Size = new Size(100, 23);
            lblUnidades.TabIndex = 3;
            // 
            // rbCelsius
            // 
            rbCelsius.AutoSize = true;
            rbCelsius.Checked = true;
            rbCelsius.Font = new Font("Segoe UI", 9.5F);
            rbCelsius.ForeColor = Color.FromArgb(30, 40, 55);
            rbCelsius.Location = new Point(386, 35);
            rbCelsius.Name = "rbCelsius";
            rbCelsius.Size = new Size(80, 25);
            rbCelsius.TabIndex = 4;
            rbCelsius.TabStop = true;
            rbCelsius.Text = "Celsius";
            // 
            // rbFahrenheit
            // 
            rbFahrenheit.AutoSize = true;
            rbFahrenheit.Font = new Font("Segoe UI", 9.5F);
            rbFahrenheit.ForeColor = Color.FromArgb(30, 40, 55);
            rbFahrenheit.Location = new Point(472, 35);
            rbFahrenheit.Name = "rbFahrenheit";
            rbFahrenheit.Size = new Size(104, 25);
            rbFahrenheit.TabIndex = 5;
            rbFahrenheit.Text = "Fahrenheit";
            // 
            // grpArchivos
            // 
            grpArchivos.BackColor = Color.White;
            grpArchivos.Controls.Add(lblRutaCSV);
            grpArchivos.Controls.Add(txtRutaCSV);
            grpArchivos.Controls.Add(btnExplorarCSV);
            grpArchivos.Controls.Add(lblRutaJSON);
            grpArchivos.Controls.Add(txtRutaJSON);
            grpArchivos.Controls.Add(btnExplorarJSON);
            grpArchivos.Dock = DockStyle.Top;
            grpArchivos.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            grpArchivos.ForeColor = Color.FromArgb(90, 105, 125);
            grpArchivos.Location = new Point(16, 216);
            grpArchivos.Name = "grpArchivos";
            grpArchivos.Padding = new Padding(4);
            grpArchivos.Size = new Size(160, 116);
            grpArchivos.TabIndex = 2;
            grpArchivos.TabStop = false;
            grpArchivos.Text = "Archivos de datos";
            // 
            // lblRutaCSV
            // 
            lblRutaCSV.Location = new Point(0, 0);
            lblRutaCSV.Name = "lblRutaCSV";
            lblRutaCSV.Size = new Size(100, 23);
            lblRutaCSV.TabIndex = 0;
            // 
            // txtRutaCSV
            // 
            txtRutaCSV.Font = new Font("Segoe UI", 9.5F);
            txtRutaCSV.Location = new Point(88, 32);
            txtRutaCSV.Name = "txtRutaCSV";
            txtRutaCSV.Size = new Size(700, 29);
            txtRutaCSV.TabIndex = 1;
            txtRutaCSV.Text = "Data\\data.csv";
            // 
            // btnExplorarCSV
            // 
            btnExplorarCSV.Location = new Point(0, 0);
            btnExplorarCSV.Name = "btnExplorarCSV";
            btnExplorarCSV.Size = new Size(75, 23);
            btnExplorarCSV.TabIndex = 2;
            // 
            // lblRutaJSON
            // 
            lblRutaJSON.Location = new Point(0, 0);
            lblRutaJSON.Name = "lblRutaJSON";
            lblRutaJSON.Size = new Size(100, 23);
            lblRutaJSON.TabIndex = 3;
            // 
            // txtRutaJSON
            // 
            txtRutaJSON.Font = new Font("Segoe UI", 9.5F);
            txtRutaJSON.Location = new Point(88, 72);
            txtRutaJSON.Name = "txtRutaJSON";
            txtRutaJSON.Size = new Size(700, 29);
            txtRutaJSON.TabIndex = 4;
            txtRutaJSON.Text = "Data\\municipios_mx.json";
            // 
            // btnExplorarJSON
            // 
            btnExplorarJSON.Location = new Point(0, 0);
            btnExplorarJSON.Name = "btnExplorarJSON";
            btnExplorarJSON.Size = new Size(75, 23);
            btnExplorarJSON.TabIndex = 5;
            // 
            // grpBaseDatos
            // 
            grpBaseDatos.BackColor = Color.White;
            grpBaseDatos.Controls.Add(lblMotorBD);
            grpBaseDatos.Controls.Add(cmbMotorBD);
            grpBaseDatos.Controls.Add(lblSQLitePath);
            grpBaseDatos.Controls.Add(txtSQLitePath);
            grpBaseDatos.Controls.Add(btnExplorarSQLite);
            grpBaseDatos.Controls.Add(lblMariaServidor);
            grpBaseDatos.Controls.Add(txtMariaServidor);
            grpBaseDatos.Controls.Add(lblMariaPuerto);
            grpBaseDatos.Controls.Add(txtMariaPuerto);
            grpBaseDatos.Controls.Add(lblMariaBD);
            grpBaseDatos.Controls.Add(txtMariaBD);
            grpBaseDatos.Controls.Add(lblMariaUsuario);
            grpBaseDatos.Controls.Add(txtMariaUsuario);
            grpBaseDatos.Controls.Add(lblMariaPassword);
            grpBaseDatos.Controls.Add(txtMariaPassword);
            grpBaseDatos.Controls.Add(btnProbarConexion);
            grpBaseDatos.Controls.Add(lblEstadoConexion);
            grpBaseDatos.Dock = DockStyle.Top;
            grpBaseDatos.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            grpBaseDatos.ForeColor = Color.FromArgb(90, 105, 125);
            grpBaseDatos.Location = new Point(16, 16);
            grpBaseDatos.Name = "grpBaseDatos";
            grpBaseDatos.Size = new Size(160, 200);
            grpBaseDatos.TabIndex = 3;
            grpBaseDatos.TabStop = false;
            grpBaseDatos.Text = "Base de datos";
            // 
            // lblMotorBD
            // 
            lblMotorBD.Location = new Point(0, 0);
            lblMotorBD.Name = "lblMotorBD";
            lblMotorBD.Size = new Size(100, 23);
            lblMotorBD.TabIndex = 0;
            // 
            // cmbMotorBD
            // 
            cmbMotorBD.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbMotorBD.Items.AddRange(new object[] { "SQLite", "MariaDB" });
            cmbMotorBD.Location = new Point(0, 0);
            cmbMotorBD.Name = "cmbMotorBD";
            cmbMotorBD.Size = new Size(121, 28);
            cmbMotorBD.TabIndex = 1;
            // 
            // lblSQLitePath
            // 
            lblSQLitePath.Location = new Point(0, 0);
            lblSQLitePath.Name = "lblSQLitePath";
            lblSQLitePath.Size = new Size(100, 23);
            lblSQLitePath.TabIndex = 2;
            // 
            // txtSQLitePath
            // 
            txtSQLitePath.Font = new Font("Segoe UI", 9.5F);
            txtSQLitePath.Location = new Point(138, 68);
            txtSQLitePath.Name = "txtSQLitePath";
            txtSQLitePath.Size = new Size(650, 29);
            txtSQLitePath.TabIndex = 3;
            txtSQLitePath.Text = "Data\\inteligencia_climatica.db";
            // 
            // btnExplorarSQLite
            // 
            btnExplorarSQLite.Location = new Point(0, 0);
            btnExplorarSQLite.Name = "btnExplorarSQLite";
            btnExplorarSQLite.Size = new Size(75, 23);
            btnExplorarSQLite.TabIndex = 4;
            // 
            // lblMariaServidor
            // 
            lblMariaServidor.Location = new Point(0, 0);
            lblMariaServidor.Name = "lblMariaServidor";
            lblMariaServidor.Size = new Size(100, 23);
            lblMariaServidor.TabIndex = 5;
            // 
            // txtMariaServidor
            // 
            txtMariaServidor.Font = new Font("Segoe UI", 9.5F);
            txtMariaServidor.Location = new Point(88, 114);
            txtMariaServidor.Name = "txtMariaServidor";
            txtMariaServidor.Size = new Size(180, 29);
            txtMariaServidor.TabIndex = 6;
            txtMariaServidor.Text = "localhost";
            // 
            // lblMariaPuerto
            // 
            lblMariaPuerto.Location = new Point(0, 0);
            lblMariaPuerto.Name = "lblMariaPuerto";
            lblMariaPuerto.Size = new Size(100, 23);
            lblMariaPuerto.TabIndex = 7;
            // 
            // txtMariaPuerto
            // 
            txtMariaPuerto.Font = new Font("Segoe UI", 9.5F);
            txtMariaPuerto.Location = new Point(344, 114);
            txtMariaPuerto.Name = "txtMariaPuerto";
            txtMariaPuerto.Size = new Size(80, 29);
            txtMariaPuerto.TabIndex = 8;
            txtMariaPuerto.Text = "3306";
            // 
            // lblMariaBD
            // 
            lblMariaBD.Location = new Point(0, 0);
            lblMariaBD.Name = "lblMariaBD";
            lblMariaBD.Size = new Size(100, 23);
            lblMariaBD.TabIndex = 9;
            // 
            // txtMariaBD
            // 
            txtMariaBD.Font = new Font("Segoe UI", 9.5F);
            txtMariaBD.Location = new Point(494, 114);
            txtMariaBD.Name = "txtMariaBD";
            txtMariaBD.Size = new Size(220, 29);
            txtMariaBD.TabIndex = 10;
            txtMariaBD.Text = "inteligencia_climatica";
            // 
            // lblMariaUsuario
            // 
            lblMariaUsuario.Location = new Point(0, 0);
            lblMariaUsuario.Name = "lblMariaUsuario";
            lblMariaUsuario.Size = new Size(100, 23);
            lblMariaUsuario.TabIndex = 11;
            // 
            // txtMariaUsuario
            // 
            txtMariaUsuario.Font = new Font("Segoe UI", 9.5F);
            txtMariaUsuario.Location = new Point(88, 154);
            txtMariaUsuario.Name = "txtMariaUsuario";
            txtMariaUsuario.Size = new Size(180, 29);
            txtMariaUsuario.TabIndex = 12;
            // 
            // lblMariaPassword
            // 
            lblMariaPassword.Location = new Point(0, 0);
            lblMariaPassword.Name = "lblMariaPassword";
            lblMariaPassword.Size = new Size(100, 23);
            lblMariaPassword.TabIndex = 13;
            // 
            // txtMariaPassword
            // 
            txtMariaPassword.Font = new Font("Segoe UI", 9.5F);
            txtMariaPassword.Location = new Point(386, 154);
            txtMariaPassword.Name = "txtMariaPassword";
            txtMariaPassword.Size = new Size(180, 29);
            txtMariaPassword.TabIndex = 14;
            txtMariaPassword.UseSystemPasswordChar = true;
            // 
            // btnProbarConexion
            // 
            btnProbarConexion.BackColor = Color.FromArgb(24, 95, 165);
            btnProbarConexion.Cursor = Cursors.Hand;
            btnProbarConexion.FlatAppearance.BorderSize = 0;
            btnProbarConexion.FlatStyle = FlatStyle.Flat;
            btnProbarConexion.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnProbarConexion.ForeColor = Color.White;
            btnProbarConexion.Location = new Point(586, 152);
            btnProbarConexion.Name = "btnProbarConexion";
            btnProbarConexion.Size = new Size(140, 34);
            btnProbarConexion.TabIndex = 15;
            btnProbarConexion.Text = "Probar conexión";
            btnProbarConexion.UseVisualStyleBackColor = false;
            // 
            // lblEstadoConexion
            // 
            lblEstadoConexion.AutoSize = true;
            lblEstadoConexion.Font = new Font("Segoe UI", 8.5F);
            lblEstadoConexion.ForeColor = Color.FromArgb(140, 155, 175);
            lblEstadoConexion.Location = new Point(742, 160);
            lblEstadoConexion.Name = "lblEstadoConexion";
            lblEstadoConexion.Size = new Size(128, 20);
            lblEstadoConexion.TabIndex = 16;
            lblEstadoConexion.Text = "Estado: sin probar";
            // 
            // pnlTopBar
            // 
            pnlTopBar.BackColor = Color.White;
            pnlTopBar.Controls.Add(lblTopBarTitle);
            pnlTopBar.Controls.Add(lblTopBarCrumb);
            pnlTopBar.Dock = DockStyle.Top;
            pnlTopBar.Location = new Point(0, 0);
            pnlTopBar.Name = "pnlTopBar";
            pnlTopBar.Size = new Size(1070, 60);
            pnlTopBar.TabIndex = 1;
            // 
            // lblTopBarTitle
            // 
            lblTopBarTitle.AutoSize = true;
            lblTopBarTitle.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            lblTopBarTitle.ForeColor = Color.FromArgb(30, 40, 55);
            lblTopBarTitle.Location = new Point(20, 10);
            lblTopBarTitle.Name = "lblTopBarTitle";
            lblTopBarTitle.Size = new Size(202, 30);
            lblTopBarTitle.TabIndex = 0;
            lblTopBarTitle.Text = "Consulta climática";
            // 
            // lblTopBarCrumb
            // 
            lblTopBarCrumb.AutoSize = true;
            lblTopBarCrumb.Font = new Font("Segoe UI", 9F);
            lblTopBarCrumb.ForeColor = Color.FromArgb(120, 135, 155);
            lblTopBarCrumb.Location = new Point(22, 36);
            lblTopBarCrumb.Name = "lblTopBarCrumb";
            lblTopBarCrumb.Size = new Size(448, 20);
            lblTopBarCrumb.TabIndex = 1;
            lblTopBarCrumb.Text = "Compara temperatura actual vs. promedio histórico por municipio";
            // 
            // statusStrip
            // 
            statusStrip.BackColor = Color.FromArgb(235, 238, 244);
            statusStrip.Font = new Font("Segoe UI", 8.5F);
            statusStrip.ImageScalingSize = new Size(20, 20);
            statusStrip.Items.AddRange(new ToolStripItem[] { tssSQLite, tssMariaDB, tssAPI, tssRegistros });
            statusStrip.Location = new Point(0, 774);
            statusStrip.Name = "statusStrip";
            statusStrip.Size = new Size(1280, 26);
            statusStrip.TabIndex = 2;
            // 
            // tssSQLite
            // 
            tssSQLite.Name = "tssSQLite";
            tssSQLite.Size = new Size(74, 20);
            tssSQLite.Text = "SQLite: —";
            // 
            // tssMariaDB
            // 
            tssMariaDB.Name = "tssMariaDB";
            tssMariaDB.Size = new Size(89, 20);
            tssMariaDB.Text = "MariaDB: —";
            // 
            // tssAPI
            // 
            tssAPI.Name = "tssAPI";
            tssAPI.Size = new Size(116, 20);
            tssAPI.Text = "Open-Meteo: —";
            // 
            // tssRegistros
            // 
            tssRegistros.Name = "tssRegistros";
            tssRegistros.Size = new Size(986, 20);
            tssRegistros.Spring = true;
            tssRegistros.Text = "Registros cargados: —";
            tssRegistros.TextAlign = ContentAlignment.MiddleRight;
            // 
            // Form1
            // 
            BackColor = Color.FromArgb(244, 247, 250);
            ClientSize = new Size(1280, 800);
            Controls.Add(pnlMainContent);
            Controls.Add(pnlSidebar);
            Controls.Add(statusStrip);
            Font = new Font("Segoe UI", 9.5F);
            MinimumSize = new Size(1100, 760);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sistema de Inteligencia Climática — México";
            Load += Form1_Load;
            pnlSidebar.ResumeLayout(false);
            pnlSidebarBrand.ResumeLayout(false);
            pnlSidebarFooter.ResumeLayout(false);
            pnlSidebarFooter.PerformLayout();
            pnlMainContent.ResumeLayout(false);
            tabControl.ResumeLayout(false);
            tabConsulta.ResumeLayout(false);
            tblTarjetas.ResumeLayout(false);
            grpDatosActuales.ResumeLayout(false);
            grpDatosActuales.PerformLayout();
            grpHistorico.ResumeLayout(false);
            grpHistorico.PerformLayout();
            grpAnomalia.ResumeLayout(false);
            grpAnomalia.PerformLayout();
            grpBusqueda.ResumeLayout(false);
            tabAnalisis.ResumeLayout(false);
            pnlCharts.ResumeLayout(false);
            pnlDer.ResumeLayout(false);
            pnlIzq.ResumeLayout(false);
            grpRanking.ResumeLayout(false);
            grpRanking.PerformLayout();
            grpFiltrosGlobal.ResumeLayout(false);
            grpFiltrosGlobal.PerformLayout();
            tabFavoritos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvFavoritos).EndInit();
            grpAgregarFav.ResumeLayout(false);
            tabConfig.ResumeLayout(false);
            grpPreferencias.ResumeLayout(false);
            grpPreferencias.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudUmbral).EndInit();
            grpArchivos.ResumeLayout(false);
            grpArchivos.PerformLayout();
            grpBaseDatos.ResumeLayout(false);
            grpBaseDatos.PerformLayout();
            pnlTopBar.ResumeLayout(false);
            pnlTopBar.PerformLayout();
            statusStrip.ResumeLayout(false);
            statusStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        // ── Helpers de estilo (dentro del Designer para mantenerlo ordenado) ─

        private static void EstiloNavBtn(Button btn, string texto, int y, bool activo)
        {
            btn.Text = texto;
            btn.Location = new Point(0, y);
            btn.Size = new Size(210, 40);
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
            btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(18, 48, 90);
            btn.TextAlign = ContentAlignment.MiddleLeft;
            btn.Font = new Font("Segoe UI", 10F);
            btn.Cursor = Cursors.Hand;
            btn.AutoSize = false;

            if (activo)
            {
                btn.BackColor = Color.FromArgb(20, 55, 100);
                btn.ForeColor = Color.FromArgb(133, 183, 235);
            }
            else
            {
                btn.BackColor = Color.FromArgb(15, 27, 45);
                btn.ForeColor = Color.FromArgb(140, 160, 185);
            }
        }

        private static void EstiloLabel(Label lbl, string texto, Point loc)
        {
            lbl.Text = texto;
            lbl.AutoSize = true;
            lbl.Location = loc;
            lbl.Font = new Font("Segoe UI", 9F);
            lbl.ForeColor = Color.FromArgb(90, 105, 125);
        }

        private static void EstiloCombo(ComboBox cmb, Point loc, int ancho)
        {
            cmb.Location = loc;
            cmb.Size = new Size(ancho, 28);
            cmb.Font = new Font("Segoe UI", 9.5F);
        }

        private static void EstiloInfoRow(Label lbl, string texto, Point loc)
        {
            lbl.Text = texto;
            lbl.AutoSize = true;
            lbl.Location = loc;
            lbl.Font = new Font("Segoe UI", 9F);
            lbl.ForeColor = Color.FromArgb(120, 135, 155);
        }

        private static void EstiloInfoVal(Label lbl, string texto, Point loc)
        {
            lbl.Text = texto;
            lbl.AutoSize = true;
            lbl.Location = loc;
            lbl.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lbl.ForeColor = Color.FromArgb(30, 40, 55);
        }

        private static void EstiloBotonSecundario(Button btn, string texto, Point loc, Size size)
        {
            btn.Text = texto;
            btn.Location = loc;
            btn.Size = size;
            btn.BackColor = Color.White;
            btn.ForeColor = Color.FromArgb(90, 105, 125);
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderColor = Color.FromArgb(210, 218, 230);
            btn.Font = new Font("Segoe UI", 9.5F);
            btn.Cursor = Cursors.Hand;
        }

        private static void EstiloDataGrid(DataGridView dgv)
        {
            dgv.AllowUserToAddRows = false;
            dgv.AllowUserToDeleteRows = false;
            dgv.ReadOnly = true;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv.BackgroundColor = Color.White;
            dgv.BorderStyle = BorderStyle.None;
            dgv.GridColor = Color.FromArgb(230, 234, 240);
            dgv.Font = new Font("Segoe UI", 9.5F);
            dgv.RowHeadersWidth = 32;
            dgv.RowHeadersVisible = false;
            dgv.ColumnHeadersHeight = 34;
            dgv.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;

            dgv.ColumnHeadersDefaultCellStyle = new DataGridViewCellStyle
            {
                BackColor = Color.FromArgb(244, 247, 250),
                ForeColor = Color.FromArgb(90, 105, 125),
                Font = new Font("Segoe UI", 9F, FontStyle.Bold),
                Padding = new Padding(8, 6, 8, 6),
                SelectionBackColor = Color.FromArgb(244, 247, 250),
                SelectionForeColor = Color.FromArgb(90, 105, 125)
            };

            dgv.DefaultCellStyle = new DataGridViewCellStyle
            {
                BackColor = Color.White,
                ForeColor = Color.FromArgb(30, 40, 55),
                SelectionBackColor = Color.FromArgb(230, 241, 251),
                SelectionForeColor = Color.FromArgb(24, 95, 165),
                Padding = new Padding(6, 4, 6, 4)
            };

            dgv.AlternatingRowsDefaultCellStyle = new DataGridViewCellStyle
            {
                BackColor = Color.FromArgb(248, 250, 252),
                ForeColor = Color.FromArgb(30, 40, 55),
                SelectionBackColor = Color.FromArgb(230, 241, 251),
                SelectionForeColor = Color.FromArgb(24, 95, 165)
            };
        }
    }
}
