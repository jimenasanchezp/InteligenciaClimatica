
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
            // ── Instancias ─────────────────────────────────────────────────
            pnlSidebar = new Panel();
            pnlSidebarBrand = new Panel();
            lblSidebarTitle = new Label();
            pnlSidebarFooter = new Panel();
            lblSidebarStatusAPI = new Label();
            lblSidebarStatusSQLite = new Label();
            lblSidebarStatusRegs = new Label();
            lblNavLabelPrincipal = new Label();
            btnNavConsulta = new Button();
            btnNavAnalisis = new Button();
            btnNavFavoritos = new Button();
            lblNavLabelSistema = new Label();
            btnNavConfig = new Button();
            pnlMainContent = new Panel();
            pnlTopBar = new Panel();
            lblTopBarTitle = new Label();
            lblTopBarCrumb = new Label();
            tabControl = new TabControl();
            tabConsulta = new TabPage();
            tabAnalisis = new TabPage();
            tabFavoritos = new TabPage();
            tabConfig = new TabPage();

            // Tab Consulta
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

            // Tab Análisis
            grpFiltrosGlobal = new GroupBox();
            lblFiltroAnio = new Label();
            cmbFiltroAnio = new ComboBox();
            lblFiltroEstacion = new Label();
            cmbFiltroEstacion = new ComboBox();
            lblBuscarEstado = new Label();
            txtBuscarEstado = new TextBox();
            btnFiltrar = new Button();
            btnLimpiarFiltro = new Button();
            //dgvHistorico = new DataGridView();
            formsPlotCalientes = new ScottPlot.WinForms.FormsPlot();
            formsPlotFrios = new ScottPlot.WinForms.FormsPlot();
            pnlCharts = new Panel();
            grpRanking = new GroupBox();
            lblRankingCaliente = new Label();
            lstCalientes = new ListBox();
            lblRankingFrio = new Label();
            lstFrios = new ListBox();
            btnExportarRanking = new Button();

            // Tab Favoritos
            dgvFavoritos = new DataGridView();
            grpAgregarFav = new GroupBox();
            lblNuevoFavEstado = new Label();
            cmbNuevoFavEstado = new ComboBox();
            lblNuevoFavMun = new Label();
            cmbNuevoFavMun = new ComboBox();
            btnAgregarFav = new Button();
            btnEliminarFav = new Button();
            btnMigrar = new Button();

            // Configuración visual del botón (ubicado en X=956 para que quede al lado de Eliminar)
            btnMigrar.Text = "Migrar";
            btnMigrar.Location = new Point(956, 30);
            btnMigrar.Size = new Size(70, 34);
            btnMigrar.BackColor = Color.FromArgb(45, 100, 163); // Azul profesional
            btnMigrar.ForeColor = Color.White;
            btnMigrar.FlatStyle = FlatStyle.Flat;
            btnMigrar.FlatAppearance.BorderSize = 0;
            btnMigrar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnMigrar.Cursor = Cursors.Hand;

            // Agregarlo al contenedor
            grpAgregarFav.Controls.Add(btnMigrar);

            // Tab Configuración
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
            grpArchivos = new GroupBox();
            lblRutaCSV = new Label();
            txtRutaCSV = new TextBox();
            btnExplorarCSV = new Button();
            lblRutaJSON = new Label();
            txtRutaJSON = new TextBox();
            btnExplorarJSON = new Button();
            grpPreferencias = new GroupBox();
            lblUmbral = new Label();
            nudUmbral = new NumericUpDown();
            lblUmbralSufijo = new Label();
            lblUnidades = new Label();
            rbCelsius = new RadioButton();
            rbFahrenheit = new RadioButton();
            btnGuardarConfig = new Button();
            statusStrip = new StatusStrip();
            tssSQLite = new ToolStripStatusLabel();
            tssMariaDB = new ToolStripStatusLabel();
            tssAPI = new ToolStripStatusLabel();
            tssRegistros = new ToolStripStatusLabel();

            // Suspender layout
            SuspendLayout();
            pnlSidebar.SuspendLayout();
            pnlSidebarBrand.SuspendLayout();
            pnlSidebarFooter.SuspendLayout();
            pnlMainContent.SuspendLayout();
            pnlTopBar.SuspendLayout();
            tabControl.SuspendLayout();
            tabConsulta.SuspendLayout();
            tblTarjetas.SuspendLayout();
            grpDatosActuales.SuspendLayout();
            grpHistorico.SuspendLayout();
            grpAnomalia.SuspendLayout();
            grpBusqueda.SuspendLayout();
            tabAnalisis.SuspendLayout();
            //((System.ComponentModel.ISupportInitialize)dgvHistorico).BeginInit();
            grpRanking.SuspendLayout();
            grpFiltrosGlobal.SuspendLayout();
            tabFavoritos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvFavoritos).BeginInit();
            grpAgregarFav.SuspendLayout();
            tabConfig.SuspendLayout();
            grpBaseDatos.SuspendLayout();
            grpArchivos.SuspendLayout();
            grpPreferencias.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudUmbral).BeginInit();
            statusStrip.SuspendLayout();


            // ══════════════════════════════════════════════════════════════
            // SIDEBAR
            // ══════════════════════════════════════════════════════════════

            // ── Marca (brand) ──────────────────────────────────────────────
            lblSidebarTitle.Text = "Inteligencia\nClimática MX";
            lblSidebarTitle.Font = new Font("Segoe UI", 11.5F, FontStyle.Bold);
            lblSidebarTitle.ForeColor = Color.White;
            lblSidebarTitle.Location = new Point(18, 18);
            lblSidebarTitle.Size = new Size(174, 46);
            lblSidebarTitle.AutoSize = false;

            pnlSidebarBrand.BackColor = Color.FromArgb(15, 27, 45);
            pnlSidebarBrand.Location = new Point(0, 0);
            pnlSidebarBrand.Size = new Size(210, 78);
            pnlSidebarBrand.Controls.Add(lblSidebarTitle);

            // ── Footer de estado ───────────────────────────────────────────
            lblSidebarStatusAPI.Text = "● Open-Meteo: —";
            lblSidebarStatusAPI.Font = new Font("Segoe UI", 8.5F);
            lblSidebarStatusAPI.ForeColor = Color.FromArgb(99, 153, 34);
            lblSidebarStatusAPI.Location = new Point(18, 12);
            lblSidebarStatusAPI.AutoSize = true;

            lblSidebarStatusSQLite.Text = "● SQLite: pendiente";
            lblSidebarStatusSQLite.Font = new Font("Segoe UI", 8.5F);
            lblSidebarStatusSQLite.ForeColor = Color.FromArgb(186, 117, 23);
            lblSidebarStatusSQLite.Location = new Point(18, 32);
            lblSidebarStatusSQLite.AutoSize = true;

            lblSidebarStatusRegs.Text = "— registros cargados";
            lblSidebarStatusRegs.Font = new Font("Segoe UI", 8F);
            lblSidebarStatusRegs.ForeColor = Color.FromArgb(70, 95, 130);
            lblSidebarStatusRegs.Location = new Point(18, 56);
            lblSidebarStatusRegs.AutoSize = true;

            pnlSidebarFooter.BackColor = Color.FromArgb(10, 20, 35);
            pnlSidebarFooter.Dock = DockStyle.Bottom;
            pnlSidebarFooter.Height = 80;
            pnlSidebarFooter.Controls.Add(lblSidebarStatusAPI);
            pnlSidebarFooter.Controls.Add(lblSidebarStatusSQLite);
            pnlSidebarFooter.Controls.Add(lblSidebarStatusRegs);

            // ── Etiqueta sección "PRINCIPAL" ───────────────────────────────
            lblNavLabelPrincipal.Text = "PRINCIPAL";
            lblNavLabelPrincipal.Font = new Font("Segoe UI", 7.5F, FontStyle.Bold);
            lblNavLabelPrincipal.ForeColor = Color.FromArgb(65, 90, 125);
            lblNavLabelPrincipal.Location = new Point(18, 90);
            lblNavLabelPrincipal.Size = new Size(174, 18);
            lblNavLabelPrincipal.AutoSize = false;

            // ── Botones de navegación ──────────────────────────────────────
            EstiloNavBtn(btnNavConsulta, "    Consulta", 112, activo: true);
            EstiloNavBtn(btnNavAnalisis, "    Análisis general", 152, activo: false);
            EstiloNavBtn(btnNavFavoritos, "    Favoritos", 192, activo: false);

            btnNavConsulta.Click += btnNavConsulta_Click;
            btnNavAnalisis.Click += btnNavAnalisis_Click;
            btnNavFavoritos.Click += btnNavFavoritos_Click;

            // ── Separador + sección "SISTEMA" ─────────────────────────────
            lblNavLabelSistema.Text = "SISTEMA";
            lblNavLabelSistema.Font = new Font("Segoe UI", 7.5F, FontStyle.Bold);
            lblNavLabelSistema.ForeColor = Color.FromArgb(65, 90, 125);
            lblNavLabelSistema.Location = new Point(18, 244);
            lblNavLabelSistema.Size = new Size(174, 18);
            lblNavLabelSistema.AutoSize = false;

            EstiloNavBtn(btnNavConfig, "    Configuración", 264, activo: false);
            btnNavConfig.Click += btnNavConfig_Click;

            // ── Panel sidebar ──────────────────────────────────────────────
            pnlSidebar.BackColor = Color.FromArgb(15, 27, 45);
            pnlSidebar.Dock = DockStyle.Left;
            pnlSidebar.Width = 210;
            pnlSidebar.Controls.Add(pnlSidebarBrand);
            pnlSidebar.Controls.Add(lblNavLabelPrincipal);
            pnlSidebar.Controls.Add(btnNavConsulta);
            pnlSidebar.Controls.Add(btnNavAnalisis);
            pnlSidebar.Controls.Add(btnNavFavoritos);
            pnlSidebar.Controls.Add(lblNavLabelSistema);
            pnlSidebar.Controls.Add(btnNavConfig);
            pnlSidebar.Controls.Add(pnlSidebarFooter);

            // ══════════════════════════════════════════════════════════════
            // TOP BAR
            // ══════════════════════════════════════════════════════════════
            lblTopBarTitle.Text = "Consulta climática";
            lblTopBarTitle.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            lblTopBarTitle.ForeColor = Color.FromArgb(30, 40, 55);
            lblTopBarTitle.AutoSize = true;
            lblTopBarTitle.Location = new Point(20, 10);

            lblTopBarCrumb.Text = "Compara temperatura actual vs. promedio histórico por municipio";
            lblTopBarCrumb.Font = new Font("Segoe UI", 9F);
            lblTopBarCrumb.ForeColor = Color.FromArgb(120, 135, 155);
            lblTopBarCrumb.AutoSize = true;
            lblTopBarCrumb.Location = new Point(22, 36);

            pnlTopBar.BackColor = Color.White;
            pnlTopBar.Dock = DockStyle.Top;
            pnlTopBar.Height = 60;
            pnlTopBar.Controls.Add(lblTopBarTitle);
            pnlTopBar.Controls.Add(lblTopBarCrumb);


            // ══════════════════════════════════════════════════════════════
            // TABCONTROL (pestañas ocultas)
            // ══════════════════════════════════════════════════════════════
            tabControl.Appearance = TabAppearance.FlatButtons;
            tabControl.ItemSize = new Size(0, 1);
            tabControl.SizeMode = TabSizeMode.Fixed;
            tabControl.Dock = DockStyle.Fill;
            tabControl.Padding = new Point(0, 0);
            tabControl.Margin = new Padding(0);
            tabControl.Controls.Add(tabConsulta);
            tabControl.Controls.Add(tabAnalisis);
            tabControl.Controls.Add(tabFavoritos);
            tabControl.Controls.Add(tabConfig);

            // ══════════════════════════════════════════════════════════════
            // TAB: CONSULTA
            // ══════════════════════════════════════════════════════════════
            tabConsulta.BackColor = Color.FromArgb(244, 247, 250);
            tabConsulta.Padding = new Padding(16);
            tabConsulta.Text = "Consulta";

            // ── Barra de búsqueda ──────────────────────────────────────────
            EstiloLabel(lblEstado, "Estado", new Point(16, 28));
            EstiloLabel(lblMunicipio, "Municipio", new Point(228, 28));
            EstiloLabel(lblAnio, "Año", new Point(476, 28));
            EstiloLabel(lblEstacion, "Estación", new Point(584, 28));

            EstiloCombo(cmbEstado, new Point(16, 50), 200);
            EstiloCombo(cmbMunicipio, new Point(228, 50), 230);
            EstiloCombo(cmbAnio, new Point(476, 50), 95);
            EstiloCombo(cmbEstacion, new Point(584, 50), 140);
            cmbEstacion.Items.AddRange(new object[] { "Primavera", "Verano", "Otoño", "Invierno" });

            cmbEstado.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbMunicipio.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbAnio.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbEstacion.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbMunicipio.Enabled = false;

            cmbEstado.SelectedIndexChanged += cmbEstado_SelectedIndexChanged_1;
            cmbMunicipio.SelectedIndexChanged += cmbMunicipio_SelectedIndexChanged_1;

            // Botón Consultar
            btnConsultar.Text = "Consultar";
            btnConsultar.Location = new Point(740, 48);
            btnConsultar.Size = new Size(120, 34);
            btnConsultar.BackColor = Color.FromArgb(24, 95, 165);
            btnConsultar.ForeColor = Color.White;
            btnConsultar.FlatStyle = FlatStyle.Flat;
            btnConsultar.FlatAppearance.BorderSize = 0;
            btnConsultar.FlatAppearance.MouseOverBackColor = Color.FromArgb(18, 77, 138);
            btnConsultar.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnConsultar.Cursor = Cursors.Hand;
            btnConsultar.Enabled = false;
            btnConsultar.Click += btnConsultar_Click_1;

            // Botón Limpiar
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.Location = new Point(872, 48);
            btnLimpiar.Size = new Size(100, 34);
            btnLimpiar.BackColor = Color.FromArgb(244, 247, 250);
            btnLimpiar.ForeColor = Color.FromArgb(90, 105, 125);
            btnLimpiar.FlatStyle = FlatStyle.Flat;
            btnLimpiar.FlatAppearance.BorderColor = Color.FromArgb(210, 218, 230);
            btnLimpiar.Font = new Font("Segoe UI", 9.5F);
            btnLimpiar.Cursor = Cursors.Hand;

            grpBusqueda.Text = "Parámetros de consulta";
            grpBusqueda.BackColor = Color.White;
            grpBusqueda.ForeColor = Color.FromArgb(90, 105, 125);
            grpBusqueda.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            grpBusqueda.Dock = DockStyle.Top;
            grpBusqueda.Height = 100;
            grpBusqueda.Padding = new Padding(8);
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

            // ── Tarjetas (3 columnas) ──────────────────────────────────────
            tblTarjetas.ColumnCount = 3;
            tblTarjetas.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33F));
            tblTarjetas.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33F));
            tblTarjetas.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.34F));
            tblTarjetas.RowCount = 1;
            tblTarjetas.RowStyles.Add(new RowStyle(SizeType.Absolute, 305F));
            tblTarjetas.Dock = DockStyle.Top;
            tblTarjetas.Height = 310;
            tblTarjetas.Padding = new Padding(0, 14, 0, 0);
            tblTarjetas.Controls.Add(grpDatosActuales, 0, 0);
            tblTarjetas.Controls.Add(grpHistorico, 1, 0);
            tblTarjetas.Controls.Add(grpAnomalia, 2, 0);

            // ── Tarjeta: Datos actuales (azul) ─────────────────────────────
            lblFuenteAPI.Text = "Fuente: Open-Meteo";
            lblFuenteAPI.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            lblFuenteAPI.ForeColor = Color.FromArgb(24, 95, 165);
            lblFuenteAPI.BackColor = Color.FromArgb(230, 241, 251);
            lblFuenteAPI.AutoSize = true;
            lblFuenteAPI.Location = new Point(16, 30);
            lblFuenteAPI.Padding = new Padding(6, 2, 6, 2);

            lblTempActualVal.Text = "—";
            lblTempActualVal.Font = new Font("Segoe UI", 32F, FontStyle.Bold);
            lblTempActualVal.ForeColor = Color.FromArgb(24, 95, 165);
            lblTempActualVal.AutoSize = true;
            lblTempActualVal.Location = new Point(16, 58);

            lblTempActualSub.Text = "Temperatura actual";
            lblTempActualSub.Font = new Font("Segoe UI", 8.5F);
            lblTempActualSub.ForeColor = Color.FromArgb(140, 155, 175);
            lblTempActualSub.AutoSize = true;
            lblTempActualSub.Location = new Point(20, 118);

            EstiloInfoRow(lblMunicipioKey, "Municipio:", new Point(20, 152));
            EstiloInfoRow(lblEstadoActKey, "Estado:", new Point(20, 176));
            EstiloInfoRow(lblMinActKey, "Sensación:", new Point(20, 200));
            EstiloInfoRow(lblMaxActKey, "Viento:", new Point(20, 224));

            EstiloInfoVal(lblMunicipioVal, "—", new Point(130, 152));
            EstiloInfoVal(lblEstadoActVal, "—", new Point(130, 176));
            EstiloInfoVal(lblMinActVal, "—", new Point(130, 200));
            EstiloInfoVal(lblMaxActVal, "—", new Point(130, 224));

            lblCoordsVal.Text = "Lat: — · Lon: —";
            lblCoordsVal.Font = new Font("Segoe UI", 8F);
            lblCoordsVal.ForeColor = Color.FromArgb(160, 175, 195);
            lblCoordsVal.AutoSize = true;
            lblCoordsVal.Location = new Point(20, 252);

            grpDatosActuales.Text = "Temperatura actual";
            grpDatosActuales.BackColor = Color.White;
            grpDatosActuales.ForeColor = Color.FromArgb(24, 95, 165);
            grpDatosActuales.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            grpDatosActuales.Dock = DockStyle.Fill;
            grpDatosActuales.Margin = new Padding(0, 0, 8, 0);
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

            // ── Tarjeta: Histórico (verde) ─────────────────────────────────
            lblFuenteCSV.Text = "Fuente: data.csv";
            lblFuenteCSV.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            lblFuenteCSV.ForeColor = Color.FromArgb(59, 109, 17);
            lblFuenteCSV.BackColor = Color.FromArgb(234, 243, 222);
            lblFuenteCSV.AutoSize = true;
            lblFuenteCSV.Location = new Point(16, 30);
            lblFuenteCSV.Padding = new Padding(6, 2, 6, 2);

            lblTempHistVal.Text = "—";
            lblTempHistVal.Font = new Font("Segoe UI", 32F, FontStyle.Bold);
            lblTempHistVal.ForeColor = Color.FromArgb(59, 109, 17);
            lblTempHistVal.AutoSize = true;
            lblTempHistVal.Location = new Point(16, 58);

            lblTempHistSub.Text = "Promedio histórico";
            lblTempHistSub.Font = new Font("Segoe UI", 8.5F);
            lblTempHistSub.ForeColor = Color.FromArgb(140, 155, 175);
            lblTempHistSub.AutoSize = true;
            lblTempHistSub.Location = new Point(20, 118);

            EstiloInfoRow(lblEstadoHistKey, "Estado:", new Point(20, 152));
            EstiloInfoRow(lblFiltroKey, "Filtro:", new Point(20, 176));
            EstiloInfoRow(lblMinHistKey, "Mínima:", new Point(20, 200));
            EstiloInfoRow(lblMaxHistKey, "Máxima:", new Point(20, 224));

            EstiloInfoVal(lblEstadoHistVal, "—", new Point(130, 152));
            EstiloInfoVal(lblFiltroVal, "—", new Point(130, 176));
            EstiloInfoVal(lblMinHistVal, "—", new Point(130, 200));
            EstiloInfoVal(lblMaxHistVal, "—", new Point(130, 224));

            lblRegistrosVal.Text = "Basado en — registros del CSV";
            lblRegistrosVal.Font = new Font("Segoe UI", 8F);
            lblRegistrosVal.ForeColor = Color.FromArgb(160, 175, 195);
            lblRegistrosVal.AutoSize = true;
            lblRegistrosVal.Location = new Point(20, 252);

            grpHistorico.Text = "Promedio histórico";
            grpHistorico.BackColor = Color.White;
            grpHistorico.ForeColor = Color.FromArgb(59, 109, 17);
            grpHistorico.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            grpHistorico.Dock = DockStyle.Fill;
            grpHistorico.Margin = new Padding(4, 0, 4, 0);
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

            // ── Tarjeta: Anomalía (ámbar) ──────────────────────────────────
            lblDesviacionKey.Text = "Desviación detectada";
            lblDesviacionKey.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            lblDesviacionKey.ForeColor = Color.FromArgb(186, 117, 23);
            lblDesviacionKey.BackColor = Color.FromArgb(250, 238, 218);
            lblDesviacionKey.AutoSize = true;
            lblDesviacionKey.Location = new Point(16, 30);
            lblDesviacionKey.Padding = new Padding(6, 2, 6, 2);

            lblDesviacionVal.Text = "—";
            lblDesviacionVal.Font = new Font("Segoe UI", 32F, FontStyle.Bold);
            lblDesviacionVal.ForeColor = Color.FromArgb(186, 117, 23);
            lblDesviacionVal.AutoSize = true;
            lblDesviacionVal.Location = new Point(16, 58);

            lblDescAnomalia.Text = "Realiza una consulta para evaluar el riesgo climático.";
            lblDescAnomalia.Font = new Font("Segoe UI", 8.5F);
            lblDescAnomalia.ForeColor = Color.FromArgb(140, 155, 175);
            lblDescAnomalia.Location = new Point(20, 118);
            lblDescAnomalia.Size = new Size(320, 38);

            lblNivelKey.Text = "Nivel de alerta";
            lblNivelKey.Font = new Font("Segoe UI", 8.5F);
            lblNivelKey.ForeColor = Color.FromArgb(90, 105, 125);
            lblNivelKey.AutoSize = true;
            lblNivelKey.Location = new Point(20, 168);

            // Semáforo rediseñado: barras horizontales más modernas
            pnlSemaforoVerde.BackColor = Color.FromArgb(210, 220, 215);
            pnlSemaforoVerde.Location = new Point(20, 192);
            pnlSemaforoVerde.Size = new Size(42, 12);

            pnlSemaforoAmarillo.BackColor = Color.FromArgb(210, 220, 215);
            pnlSemaforoAmarillo.Location = new Point(68, 192);
            pnlSemaforoAmarillo.Size = new Size(42, 12);

            pnlSemaforoRojo.BackColor = Color.FromArgb(210, 220, 215);
            pnlSemaforoRojo.Location = new Point(116, 192);
            pnlSemaforoRojo.Size = new Size(42, 12);

            lblSemaforoTexto.Text = "—";
            lblSemaforoTexto.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblSemaforoTexto.ForeColor = Color.FromArgb(90, 105, 125);
            lblSemaforoTexto.AutoSize = true;
            lblSemaforoTexto.Location = new Point(168, 188);

            btnGuardarAlerta.Text = "Guardar alerta";
            btnGuardarAlerta.Location = new Point(20, 224);
            btnGuardarAlerta.Size = new Size(155, 34);
            btnGuardarAlerta.BackColor = Color.FromArgb(163, 45, 45);
            btnGuardarAlerta.ForeColor = Color.White;
            btnGuardarAlerta.FlatStyle = FlatStyle.Flat;
            btnGuardarAlerta.FlatAppearance.BorderSize = 0;
            btnGuardarAlerta.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnGuardarAlerta.Cursor = Cursors.Hand;
            btnGuardarAlerta.Enabled = false;

            grpAnomalia.Text = "Anomalía detectada";
            grpAnomalia.BackColor = Color.White;
            grpAnomalia.ForeColor = Color.FromArgb(186, 117, 23);
            grpAnomalia.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            grpAnomalia.Dock = DockStyle.Fill;
            grpAnomalia.Margin = new Padding(8, 0, 0, 0);
            grpAnomalia.Controls.Add(lblDesviacionKey);
            grpAnomalia.Controls.Add(lblDesviacionVal);
            grpAnomalia.Controls.Add(lblDescAnomalia);
            grpAnomalia.Controls.Add(lblNivelKey);
            grpAnomalia.Controls.Add(pnlSemaforoVerde);
            grpAnomalia.Controls.Add(pnlSemaforoAmarillo);
            grpAnomalia.Controls.Add(pnlSemaforoRojo);
            grpAnomalia.Controls.Add(lblSemaforoTexto);
            grpAnomalia.Controls.Add(btnGuardarAlerta);

            tabConsulta.Controls.Add(tblTarjetas);
            tabConsulta.Controls.Add(grpBusqueda);

            // ══════════════════════════════════════════════════════════════
            // TAB: ANÁLISIS
            // ══════════════════════════════════════════════════════════════
            tabAnalisis.BackColor = Color.FromArgb(244, 247, 250);
            tabAnalisis.Padding = new Padding(16);
            tabAnalisis.Text = "Análisis global";

            // Filtros
            EstiloLabel(lblFiltroAnio, "Año:", new Point(16, 36));
            EstiloLabel(lblFiltroEstacion, "Estación:", new Point(178, 36));
            EstiloLabel(lblBuscarEstado, "Estado:", new Point(408, 36));

            EstiloCombo(cmbFiltroAnio, new Point(56, 30), 108);
            EstiloCombo(cmbFiltroEstacion, new Point(248, 30), 148);
            cmbFiltroEstacion.Items.AddRange(new object[] { "Todas", "Primavera", "Verano", "Otoño", "Invierno" });
            cmbFiltroAnio.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbFiltroEstacion.DropDownStyle = ComboBoxStyle.DropDownList;

            txtBuscarEstado.Location = new Point(468, 30);
            txtBuscarEstado.Size = new Size(210, 28);
            txtBuscarEstado.Font = new Font("Segoe UI", 9.5F);

            EstiloBotonSecundario(btnFiltrar, "Filtrar", new Point(696, 28), new Size(90, 34));
            EstiloBotonSecundario(btnLimpiarFiltro, "Limpiar", new Point(798, 28), new Size(90, 34));

            grpFiltrosGlobal.Text = "Filtros";
            grpFiltrosGlobal.BackColor = Color.White;
            grpFiltrosGlobal.ForeColor = Color.FromArgb(90, 105, 125);
            grpFiltrosGlobal.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            grpFiltrosGlobal.Dock = DockStyle.Top;
            grpFiltrosGlobal.Height = 76;
            grpFiltrosGlobal.Controls.Add(lblFiltroAnio);
            grpFiltrosGlobal.Controls.Add(cmbFiltroAnio);
            grpFiltrosGlobal.Controls.Add(lblFiltroEstacion);
            grpFiltrosGlobal.Controls.Add(cmbFiltroEstacion);
            grpFiltrosGlobal.Controls.Add(lblBuscarEstado);
            grpFiltrosGlobal.Controls.Add(txtBuscarEstado);
            grpFiltrosGlobal.Controls.Add(btnFiltrar);
            grpFiltrosGlobal.Controls.Add(btnLimpiarFiltro);

            //// DataGrid histórico
            //EstiloDataGrid(dgvHistorico);
            //dgvHistorico.Dock = DockStyle.Fill;
            // AGREGAR:
            formsPlotCalientes.Dock = DockStyle.Fill;
            formsPlotFrios.Dock = DockStyle.Fill;

            pnlCharts.Dock = DockStyle.Fill;
            pnlCharts.Padding = new Padding(0);

            // Panel izquierdo (calientes)
            pnlIzq = new Panel();
            pnlIzq.Dock = DockStyle.Left;
            pnlIzq.Width = 0; // se ajusta por porcentaje abajo
            pnlIzq.Controls.Add(formsPlotCalientes);

            // Panel derecho (fríos)
            pnlDer = new Panel();
            pnlDer.Dock = DockStyle.Fill;
            pnlDer.Controls.Add(formsPlotFrios);

            pnlCharts.Controls.Add(pnlDer);
            pnlCharts.Controls.Add(pnlIzq);

            // Ranking
            lblRankingCaliente.Text = "Top 5 más calientes";
            lblRankingCaliente.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblRankingCaliente.ForeColor = Color.FromArgb(163, 45, 45);
            lblRankingCaliente.AutoSize = true;
            lblRankingCaliente.Location = new Point(16, 26);

            lstCalientes.Location = new Point(16, 52);
            lstCalientes.Size = new Size(490, 88);
            lstCalientes.Font = new Font("Segoe UI", 9F);
            lstCalientes.BorderStyle = BorderStyle.FixedSingle;

            lblRankingFrio.Text = "Top 5 más fríos";
            lblRankingFrio.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblRankingFrio.ForeColor = Color.FromArgb(24, 95, 165);
            lblRankingFrio.AutoSize = true;
            lblRankingFrio.Location = new Point(550, 26);

            lstFrios.Location = new Point(550, 52);
            lstFrios.Size = new Size(490, 88);
            lstFrios.Font = new Font("Segoe UI", 9F);
            lstFrios.BorderStyle = BorderStyle.FixedSingle;

            grpRanking.Text = "Ranking climático";
            grpRanking.BackColor = Color.White;
            grpRanking.ForeColor = Color.FromArgb(90, 105, 125);
            grpRanking.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            grpRanking.Dock = DockStyle.Bottom;
            grpRanking.Height = 152;
            grpRanking.Controls.Add(lblRankingCaliente);
            grpRanking.Controls.Add(lstCalientes);
            grpRanking.Controls.Add(lblRankingFrio);
            grpRanking.Controls.Add(lstFrios);

            // 
            // btnExportarRanking
            // 
            btnExportarRanking.Text = "Exportar Ranking ";
            btnExportarRanking.Location = new Point(900, 30); // A la derecha del botón Limpiar
            btnExportarRanking.Size = new Size(130, 34);
            btnExportarRanking.BackColor = Color.FromArgb(45, 100, 163); // Azul profesional
            btnExportarRanking.ForeColor = Color.White;
            btnExportarRanking.FlatStyle = FlatStyle.Flat;
            btnExportarRanking.FlatAppearance.BorderSize = 0;
            btnExportarRanking.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnExportarRanking.Cursor = Cursors.Hand;

            // Agregar el botón al contenedor grpRanking
            grpRanking.Controls.Add(btnExportarRanking);

            //tabAnalisis.Controls.Add(dgvHistorico);
            tabAnalisis.Controls.Add(pnlCharts);
            tabAnalisis.Controls.Add(grpRanking);
            tabAnalisis.Controls.Add(grpFiltrosGlobal);

            // ══════════════════════════════════════════════════════════════
            // TAB: FAVORITOS
            // ══════════════════════════════════════════════════════════════
            tabFavoritos.BackColor = Color.FromArgb(244, 247, 250);
            tabFavoritos.Padding = new Padding(16);
            tabFavoritos.Text = "Favoritos";

            EstiloDataGrid(dgvFavoritos);
            dgvFavoritos.Dock = DockStyle.Fill;

            EstiloLabel(lblNuevoFavEstado, "Estado:", new Point(16, 38));
            EstiloLabel(lblNuevoFavMun, "Municipio:", new Point(316, 38));

            EstiloCombo(cmbNuevoFavEstado, new Point(78, 32), 225);
            EstiloCombo(cmbNuevoFavMun, new Point(400, 32), 245);
            cmbNuevoFavEstado.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbNuevoFavMun.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbNuevoFavMun.Enabled = false;

            btnAgregarFav.Text = "Agregar";
            btnAgregarFav.Location = new Point(660, 30);
            btnAgregarFav.Size = new Size(100, 34);
            btnAgregarFav.BackColor = Color.FromArgb(24, 95, 165);
            btnAgregarFav.ForeColor = Color.White;
            btnAgregarFav.FlatStyle = FlatStyle.Flat;
            btnAgregarFav.FlatAppearance.BorderSize = 0;
            btnAgregarFav.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnAgregarFav.Cursor = Cursors.Hand;

            EstiloBotonSecundario(btnEliminarFav, "Eliminar seleccionado", new Point(776, 30), new Size(170, 34));

            grpAgregarFav.Text = "Agregar municipio favorito";
            grpAgregarFav.BackColor = Color.White;
            grpAgregarFav.ForeColor = Color.FromArgb(90, 105, 125);
            grpAgregarFav.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            grpAgregarFav.Dock = DockStyle.Bottom;
            grpAgregarFav.Height = 80;
            grpAgregarFav.Controls.Add(lblNuevoFavEstado);
            grpAgregarFav.Controls.Add(cmbNuevoFavEstado);
            grpAgregarFav.Controls.Add(lblNuevoFavMun);
            grpAgregarFav.Controls.Add(cmbNuevoFavMun);
            grpAgregarFav.Controls.Add(btnAgregarFav);
            grpAgregarFav.Controls.Add(btnEliminarFav);

            tabFavoritos.Controls.Add(dgvFavoritos);
            tabFavoritos.Controls.Add(grpAgregarFav);

            // ══════════════════════════════════════════════════════════════
            // TAB: CONFIGURACIÓN
            // ══════════════════════════════════════════════════════════════
            tabConfig.BackColor = Color.FromArgb(244, 247, 250);
            tabConfig.Padding = new Padding(16);
            tabConfig.Text = "Configuración";

            // Base de datos
            EstiloLabel(lblMotorBD, "Motor:", new Point(16, 32));
            EstiloLabel(lblSQLitePath, "Archivo SQLite:", new Point(16, 72));
            EstiloLabel(lblMariaServidor, "Servidor:", new Point(16, 118));
            EstiloLabel(lblMariaPuerto, "Puerto:", new Point(288, 118));
            EstiloLabel(lblMariaBD, "Base:", new Point(446, 118));
            EstiloLabel(lblMariaUsuario, "Usuario:", new Point(16, 158));
            EstiloLabel(lblMariaPassword, "Contraseña:", new Point(288, 158));

            cmbMotorBD.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbMotorBD.Items.AddRange(new object[] { "SQLite", "MariaDB" });
            EstiloCombo(cmbMotorBD, new Point(88, 28), 165);

            txtSQLitePath.Text = "Data\\inteligencia_climatica.db";
            txtSQLitePath.Location = new Point(138, 68);
            txtSQLitePath.Size = new Size(650, 28);
            txtSQLitePath.Font = new Font("Segoe UI", 9.5F);

            EstiloBotonSecundario(btnExplorarSQLite, "Explorar", new Point(800, 66), new Size(100, 32));

            txtMariaServidor.Text = "localhost";
            txtMariaServidor.Location = new Point(88, 114);
            txtMariaServidor.Size = new Size(180, 28);
            txtMariaServidor.Font = new Font("Segoe UI", 9.5F);

            txtMariaPuerto.Text = "3306";
            txtMariaPuerto.Location = new Point(344, 114);
            txtMariaPuerto.Size = new Size(80, 28);
            txtMariaPuerto.Font = new Font("Segoe UI", 9.5F);

            txtMariaBD.Text = "inteligencia_climatica";
            txtMariaBD.Location = new Point(494, 114);
            txtMariaBD.Size = new Size(220, 28);
            txtMariaBD.Font = new Font("Segoe UI", 9.5F);

            txtMariaUsuario.Location = new Point(88, 154);
            txtMariaUsuario.Size = new Size(180, 28);
            txtMariaUsuario.Font = new Font("Segoe UI", 9.5F);

            txtMariaPassword.Location = new Point(386, 154);
            txtMariaPassword.Size = new Size(180, 28);
            txtMariaPassword.Font = new Font("Segoe UI", 9.5F);
            txtMariaPassword.UseSystemPasswordChar = true;

            btnProbarConexion.Text = "Probar conexión";
            btnProbarConexion.Location = new Point(586, 152);
            btnProbarConexion.Size = new Size(140, 34);
            btnProbarConexion.BackColor = Color.FromArgb(24, 95, 165);
            btnProbarConexion.ForeColor = Color.White;
            btnProbarConexion.FlatStyle = FlatStyle.Flat;
            btnProbarConexion.FlatAppearance.BorderSize = 0;
            btnProbarConexion.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnProbarConexion.Cursor = Cursors.Hand;

            lblEstadoConexion.Text = "Estado: sin probar";
            lblEstadoConexion.Font = new Font("Segoe UI", 8.5F);
            lblEstadoConexion.ForeColor = Color.FromArgb(140, 155, 175);
            lblEstadoConexion.AutoSize = true;
            lblEstadoConexion.Location = new Point(742, 160);

            grpBaseDatos.Text = "Base de datos";
            grpBaseDatos.BackColor = Color.White;
            grpBaseDatos.ForeColor = Color.FromArgb(90, 105, 125);
            grpBaseDatos.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            grpBaseDatos.Dock = DockStyle.Top;
            grpBaseDatos.Height = 200;
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

            // Archivos
            EstiloLabel(lblRutaCSV, "CSV:", new Point(16, 36));
            EstiloLabel(lblRutaJSON, "JSON:", new Point(16, 76));

            txtRutaCSV.Text = "Data\\data.csv";
            txtRutaCSV.Location = new Point(88, 32);
            txtRutaCSV.Size = new Size(700, 28);
            txtRutaCSV.Font = new Font("Segoe UI", 9.5F);

            txtRutaJSON.Text = "Data\\municipios_mx.json";
            txtRutaJSON.Location = new Point(88, 72);
            txtRutaJSON.Size = new Size(700, 28);
            txtRutaJSON.Font = new Font("Segoe UI", 9.5F);

            EstiloBotonSecundario(btnExplorarCSV, "Explorar", new Point(800, 30), new Size(100, 32));
            EstiloBotonSecundario(btnExplorarJSON, "Explorar", new Point(800, 70), new Size(100, 32));

            grpArchivos.Text = "Archivos de datos";
            grpArchivos.BackColor = Color.White;
            grpArchivos.ForeColor = Color.FromArgb(90, 105, 125);
            grpArchivos.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            grpArchivos.Dock = DockStyle.Top;
            grpArchivos.Height = 116;
            grpArchivos.Padding = new Padding(4);
            grpArchivos.Controls.Add(lblRutaCSV);
            grpArchivos.Controls.Add(txtRutaCSV);
            grpArchivos.Controls.Add(btnExplorarCSV);
            grpArchivos.Controls.Add(lblRutaJSON);
            grpArchivos.Controls.Add(txtRutaJSON);
            grpArchivos.Controls.Add(btnExplorarJSON);

            // Preferencias
            EstiloLabel(lblUmbral, "Umbral de alerta:", new Point(16, 38));
            EstiloLabel(lblUnidades, "Unidades:", new Point(308, 38));

            nudUmbral.Location = new Point(142, 34);
            nudUmbral.Size = new Size(80, 28);
            nudUmbral.Font = new Font("Segoe UI", 9.5F);
            nudUmbral.DecimalPlaces = 1;
            nudUmbral.Increment = new decimal(new int[] { 5, 0, 0, 65536 });
            nudUmbral.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudUmbral.Maximum = new decimal(new int[] { 20, 0, 0, 0 });
            nudUmbral.Value = new decimal(new int[] { 3, 0, 0, 0 });

            lblUmbralSufijo.Text = "°C";
            lblUmbralSufijo.AutoSize = true;
            lblUmbralSufijo.Location = new Point(232, 38);
            lblUmbralSufijo.Font = new Font("Segoe UI", 9.5F);
            lblUmbralSufijo.ForeColor = Color.FromArgb(90, 105, 125);

            rbCelsius.Text = "Celsius";
            rbCelsius.Checked = true;
            rbCelsius.Location = new Point(386, 35);
            rbCelsius.AutoSize = true;
            rbCelsius.Font = new Font("Segoe UI", 9.5F);
            rbCelsius.ForeColor = Color.FromArgb(30, 40, 55);

            rbFahrenheit.Text = "Fahrenheit";
            rbFahrenheit.Location = new Point(472, 35);
            rbFahrenheit.AutoSize = true;
            rbFahrenheit.Font = new Font("Segoe UI", 9.5F);
            rbFahrenheit.ForeColor = Color.FromArgb(30, 40, 55);

            grpPreferencias.Text = "Preferencias";
            grpPreferencias.BackColor = Color.White;
            grpPreferencias.ForeColor = Color.FromArgb(90, 105, 125);
            grpPreferencias.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            grpPreferencias.Dock = DockStyle.Top;
            grpPreferencias.Height = 78;
            grpPreferencias.Controls.Add(lblUmbral);
            grpPreferencias.Controls.Add(nudUmbral);
            grpPreferencias.Controls.Add(lblUmbralSufijo);
            grpPreferencias.Controls.Add(lblUnidades);
            grpPreferencias.Controls.Add(rbCelsius);
            grpPreferencias.Controls.Add(rbFahrenheit);

            btnGuardarConfig.Text = "Guardar configuración";
            btnGuardarConfig.Dock = DockStyle.Top;
            btnGuardarConfig.Height = 44;
            btnGuardarConfig.BackColor = Color.FromArgb(24, 95, 165);
            btnGuardarConfig.ForeColor = Color.White;
            btnGuardarConfig.FlatStyle = FlatStyle.Flat;
            btnGuardarConfig.FlatAppearance.BorderSize = 0;
            btnGuardarConfig.FlatAppearance.MouseOverBackColor = Color.FromArgb(18, 77, 138);
            btnGuardarConfig.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnGuardarConfig.Cursor = Cursors.Hand;

            tabConfig.Controls.Add(btnGuardarConfig);
            tabConfig.Controls.Add(grpPreferencias);
            tabConfig.Controls.Add(grpArchivos);
            tabConfig.Controls.Add(grpBaseDatos);

            // ══════════════════════════════════════════════════════════════
            // ÁREA PRINCIPAL
            // ══════════════════════════════════════════════════════════════
            pnlMainContent.Dock = DockStyle.Fill;
            pnlMainContent.Controls.Add(tabControl);
            pnlMainContent.Controls.Add(pnlTopBar);

            // ══════════════════════════════════════════════════════════════
            // STATUS STRIP
            // ══════════════════════════════════════════════════════════════
            tssSQLite.Text = "SQLite: —";
            tssMariaDB.Text = "MariaDB: —";
            tssAPI.Text = "Open-Meteo: —";
            tssRegistros.Text = "Registros cargados: —";
            tssRegistros.Spring = true;
            tssRegistros.TextAlign = ContentAlignment.MiddleRight;

            statusStrip.Font = new Font("Segoe UI", 8.5F);
            statusStrip.BackColor = Color.FromArgb(235, 238, 244);
            statusStrip.Items.AddRange(new ToolStripItem[] { tssSQLite, tssMariaDB, tssAPI, tssRegistros });

            // ══════════════════════════════════════════════════════════════
            // FORM
            // ══════════════════════════════════════════════════════════════
            BackColor = Color.FromArgb(244, 247, 250);
            ClientSize = new Size(1280, 800);
            Font = new Font("Segoe UI", 9.5F);
            MinimumSize = new Size(1100, 760);
            Text = "Sistema de Inteligencia Climática — México";
            StartPosition = FormStartPosition.CenterScreen;
            Name = "Form1";
            Load += Form1_Load;

            Controls.Add(pnlMainContent);
            Controls.Add(pnlSidebar);
            Controls.Add(statusStrip);

            // ══════════════════════════════════════════════════════════════
            // RESUME LAYOUT
            // ══════════════════════════════════════════════════════════════
            pnlSidebarBrand.ResumeLayout(false);
            pnlSidebarFooter.ResumeLayout(false);
            pnlSidebar.ResumeLayout(false);
            pnlTopBar.ResumeLayout(false);
            pnlTopBar.PerformLayout();
            grpBusqueda.ResumeLayout(false);
            grpBusqueda.PerformLayout();
            tblTarjetas.ResumeLayout(false);
            grpDatosActuales.ResumeLayout(false);
            grpDatosActuales.PerformLayout();
            grpHistorico.ResumeLayout(false);
            grpHistorico.PerformLayout();
            grpAnomalia.ResumeLayout(false);
            grpAnomalia.PerformLayout();
            tabConsulta.ResumeLayout(false);
            grpFiltrosGlobal.ResumeLayout(false);
            grpFiltrosGlobal.PerformLayout();
            //((System.ComponentModel.ISupportInitialize)dgvHistorico).EndInit();
            grpRanking.ResumeLayout(false);
            grpRanking.PerformLayout();
            tabAnalisis.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvFavoritos).EndInit();
            grpAgregarFav.ResumeLayout(false);
            grpAgregarFav.PerformLayout();
            tabFavoritos.ResumeLayout(false);
            grpBaseDatos.ResumeLayout(false);
            grpBaseDatos.PerformLayout();
            grpArchivos.ResumeLayout(false);
            grpArchivos.PerformLayout();
            grpPreferencias.ResumeLayout(false);
            grpPreferencias.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudUmbral).EndInit();
            tabConfig.ResumeLayout(false);
            tabControl.ResumeLayout(false);
            pnlMainContent.ResumeLayout(false);
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
