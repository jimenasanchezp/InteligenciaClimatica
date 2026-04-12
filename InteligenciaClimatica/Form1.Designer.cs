namespace InteligenciaClimatica
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        private TabControl tabControl;
        private TabPage tabConsulta;
        private TabPage tabAnalisis;
        private TabPage tabFavoritos;
        private TabPage tabConfig;

        private Panel pnlHeader;
        private Label lblTitulo;
        private Label lblSubtitulo;

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

        private GroupBox grpFiltrosGlobal;
        private Label lblFiltroAnio;
        private ComboBox cmbFiltroAnio;
        private Label lblFiltroEstacion;
        private ComboBox cmbFiltroEstacion;
        private Label lblBuscarEstado;
        private TextBox txtBuscarEstado;
        private Button btnFiltrar;
        private Button btnLimpiarFiltro;
        private DataGridView dgvHistorico;
        private GroupBox grpRanking;
        private Label lblRankingCaliente;
        private ListBox lstCalientes;
        private Label lblRankingFrio;
        private ListBox lstFrios;

        private DataGridView dgvFavoritos;
        private GroupBox grpAgregarFav;
        private Label lblNuevoFavEstado;
        private ComboBox cmbNuevoFavEstado;
        private Label lblNuevoFavMun;
        private ComboBox cmbNuevoFavMun;
        private Button btnAgregarFav;
        private Button btnEliminarFav;

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

        private StatusStrip statusStrip;
        private ToolStripStatusLabel tssSQLite;
        private ToolStripStatusLabel tssMariaDB;
        private ToolStripStatusLabel tssAPI;
        private ToolStripStatusLabel tssRegistros;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
                components.Dispose();

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
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
            dgvHistorico = new DataGridView();
            grpRanking = new GroupBox();
            lblRankingCaliente = new Label();
            lstCalientes = new ListBox();
            lblRankingFrio = new Label();
            lstFrios = new ListBox();
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
            pnlHeader = new Panel();
            lblTitulo = new Label();
            lblSubtitulo = new Label();
            statusStrip = new StatusStrip();
            tssSQLite = new ToolStripStatusLabel();
            tssMariaDB = new ToolStripStatusLabel();
            tssAPI = new ToolStripStatusLabel();
            tssRegistros = new ToolStripStatusLabel();
            tabControl.SuspendLayout();
            tabConsulta.SuspendLayout();
            tblTarjetas.SuspendLayout();
            grpDatosActuales.SuspendLayout();
            grpHistorico.SuspendLayout();
            grpAnomalia.SuspendLayout();
            grpBusqueda.SuspendLayout();
            tabAnalisis.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHistorico).BeginInit();
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
            pnlHeader.SuspendLayout();
            statusStrip.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl
            // 
            tabControl.Controls.Add(tabConsulta);
            tabControl.Controls.Add(tabAnalisis);
            tabControl.Controls.Add(tabFavoritos);
            tabControl.Controls.Add(tabConfig);
            tabControl.Dock = DockStyle.Fill;
            tabControl.Location = new Point(0, 92);
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(1180, 662);
            tabControl.TabIndex = 0;
            // 
            // tabConsulta
            // 
            tabConsulta.BackColor = Color.FromArgb(244, 247, 250);
            tabConsulta.Controls.Add(tblTarjetas);
            tabConsulta.Controls.Add(grpBusqueda);
            tabConsulta.Location = new Point(4, 29);
            tabConsulta.Name = "tabConsulta";
            tabConsulta.Padding = new Padding(18);
            tabConsulta.Size = new Size(1172, 629);
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
            tblTarjetas.Location = new Point(18, 123);
            tblTarjetas.Name = "tblTarjetas";
            tblTarjetas.Padding = new Padding(0, 16, 0, 0);
            tblTarjetas.RowCount = 1;
            tblTarjetas.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tblTarjetas.Size = new Size(1136, 295);
            tblTarjetas.TabIndex = 0;
            // 
            // grpDatosActuales
            // 
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
            grpDatosActuales.Location = new Point(3, 19);
            grpDatosActuales.Name = "grpDatosActuales";
            grpDatosActuales.Size = new Size(200, 100);
            grpDatosActuales.TabIndex = 0;
            grpDatosActuales.TabStop = false;
            // 
            // lblFuenteAPI
            // 
            lblFuenteAPI.AutoSize = true;
            lblFuenteAPI.ForeColor = Color.SteelBlue;
            lblFuenteAPI.Location = new Point(20, 32);
            lblFuenteAPI.Name = "lblFuenteAPI";
            lblFuenteAPI.Size = new Size(145, 20);
            lblFuenteAPI.TabIndex = 0;
            lblFuenteAPI.Text = "Fuente: Open-Meteo";
            // 
            // lblTempActualVal
            // 
            lblTempActualVal.AutoSize = true;
            lblTempActualVal.Font = new Font("Segoe UI", 30F, FontStyle.Bold);
            lblTempActualVal.ForeColor = Color.Firebrick;
            lblTempActualVal.Location = new Point(20, 58);
            lblTempActualVal.Name = "lblTempActualVal";
            lblTempActualVal.Size = new Size(79, 67);
            lblTempActualVal.TabIndex = 1;
            lblTempActualVal.Text = "—";
            // 
            // lblTempActualSub
            // 
            lblTempActualSub.AutoSize = true;
            lblTempActualSub.ForeColor = Color.Gray;
            lblTempActualSub.Location = new Point(24, 120);
            lblTempActualSub.Name = "lblTempActualSub";
            lblTempActualSub.Size = new Size(137, 20);
            lblTempActualSub.TabIndex = 2;
            lblTempActualSub.Text = "Temperatura actual";
            // 
            // lblMunicipioKey
            // 
            lblMunicipioKey.AutoSize = true;
            lblMunicipioKey.Location = new Point(24, 160);
            lblMunicipioKey.Name = "lblMunicipioKey";
            lblMunicipioKey.Size = new Size(78, 20);
            lblMunicipioKey.TabIndex = 3;
            lblMunicipioKey.Text = "Municipio:";
            // 
            // lblMunicipioVal
            // 
            lblMunicipioVal.AutoSize = true;
            lblMunicipioVal.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblMunicipioVal.Location = new Point(130, 160);
            lblMunicipioVal.Name = "lblMunicipioVal";
            lblMunicipioVal.Size = new Size(24, 20);
            lblMunicipioVal.TabIndex = 4;
            lblMunicipioVal.Text = "—";
            // 
            // lblEstadoActKey
            // 
            lblEstadoActKey.AutoSize = true;
            lblEstadoActKey.Location = new Point(24, 188);
            lblEstadoActKey.Name = "lblEstadoActKey";
            lblEstadoActKey.Size = new Size(57, 20);
            lblEstadoActKey.TabIndex = 5;
            lblEstadoActKey.Text = "Estado:";
            // 
            // lblEstadoActVal
            // 
            lblEstadoActVal.AutoSize = true;
            lblEstadoActVal.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblEstadoActVal.Location = new Point(130, 188);
            lblEstadoActVal.Name = "lblEstadoActVal";
            lblEstadoActVal.Size = new Size(24, 20);
            lblEstadoActVal.TabIndex = 6;
            lblEstadoActVal.Text = "—";
            // 
            // lblMinActKey
            // 
            lblMinActKey.AutoSize = true;
            lblMinActKey.Location = new Point(24, 216);
            lblMinActKey.Name = "lblMinActKey";
            lblMinActKey.Size = new Size(62, 20);
            lblMinActKey.TabIndex = 7;
            lblMinActKey.Text = "Mínima:";
            // 
            // lblMinActVal
            // 
            lblMinActVal.AutoSize = true;
            lblMinActVal.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblMinActVal.Location = new Point(130, 216);
            lblMinActVal.Name = "lblMinActVal";
            lblMinActVal.Size = new Size(24, 20);
            lblMinActVal.TabIndex = 8;
            lblMinActVal.Text = "—";
            // 
            // lblMaxActKey
            // 
            lblMaxActKey.AutoSize = true;
            lblMaxActKey.Location = new Point(210, 216);
            lblMaxActKey.Name = "lblMaxActKey";
            lblMaxActKey.Size = new Size(65, 20);
            lblMaxActKey.TabIndex = 9;
            lblMaxActKey.Text = "Máxima:";
            // 
            // lblMaxActVal
            // 
            lblMaxActVal.AutoSize = true;
            lblMaxActVal.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblMaxActVal.Location = new Point(285, 216);
            lblMaxActVal.Name = "lblMaxActVal";
            lblMaxActVal.Size = new Size(24, 20);
            lblMaxActVal.TabIndex = 10;
            lblMaxActVal.Text = "—";
            // 
            // lblCoordsVal
            // 
            lblCoordsVal.AutoSize = true;
            lblCoordsVal.ForeColor = Color.Gray;
            lblCoordsVal.Location = new Point(24, 244);
            lblCoordsVal.Name = "lblCoordsVal";
            lblCoordsVal.Size = new Size(108, 20);
            lblCoordsVal.TabIndex = 11;
            lblCoordsVal.Text = "Lat: — · Lon: —";
            // 
            // grpHistorico
            // 
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
            grpHistorico.Location = new Point(381, 19);
            grpHistorico.Name = "grpHistorico";
            grpHistorico.Size = new Size(200, 100);
            grpHistorico.TabIndex = 1;
            grpHistorico.TabStop = false;
            // 
            // lblFuenteCSV
            // 
            lblFuenteCSV.AutoSize = true;
            lblFuenteCSV.ForeColor = Color.SeaGreen;
            lblFuenteCSV.Location = new Point(20, 32);
            lblFuenteCSV.Name = "lblFuenteCSV";
            lblFuenteCSV.Size = new Size(113, 20);
            lblFuenteCSV.TabIndex = 0;
            lblFuenteCSV.Text = "Fuente: data.csv";
            // 
            // lblTempHistVal
            // 
            lblTempHistVal.AutoSize = true;
            lblTempHistVal.Font = new Font("Segoe UI", 30F, FontStyle.Bold);
            lblTempHistVal.ForeColor = Color.FromArgb(31, 78, 121);
            lblTempHistVal.Location = new Point(20, 58);
            lblTempHistVal.Name = "lblTempHistVal";
            lblTempHistVal.Size = new Size(79, 67);
            lblTempHistVal.TabIndex = 1;
            lblTempHistVal.Text = "—";
            // 
            // lblTempHistSub
            // 
            lblTempHistSub.AutoSize = true;
            lblTempHistSub.ForeColor = Color.Gray;
            lblTempHistSub.Location = new Point(24, 120);
            lblTempHistSub.Name = "lblTempHistSub";
            lblTempHistSub.Size = new Size(135, 20);
            lblTempHistSub.TabIndex = 2;
            lblTempHistSub.Text = "Promedio histórico";
            // 
            // lblEstadoHistKey
            // 
            lblEstadoHistKey.AutoSize = true;
            lblEstadoHistKey.Location = new Point(24, 160);
            lblEstadoHistKey.Name = "lblEstadoHistKey";
            lblEstadoHistKey.Size = new Size(57, 20);
            lblEstadoHistKey.TabIndex = 3;
            lblEstadoHistKey.Text = "Estado:";
            // 
            // lblEstadoHistVal
            // 
            lblEstadoHistVal.AutoSize = true;
            lblEstadoHistVal.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblEstadoHistVal.Location = new Point(130, 160);
            lblEstadoHistVal.Name = "lblEstadoHistVal";
            lblEstadoHistVal.Size = new Size(24, 20);
            lblEstadoHistVal.TabIndex = 4;
            lblEstadoHistVal.Text = "—";
            // 
            // lblFiltroKey
            // 
            lblFiltroKey.AutoSize = true;
            lblFiltroKey.Location = new Point(24, 188);
            lblFiltroKey.Name = "lblFiltroKey";
            lblFiltroKey.Size = new Size(46, 20);
            lblFiltroKey.TabIndex = 5;
            lblFiltroKey.Text = "Filtro:";
            // 
            // lblFiltroVal
            // 
            lblFiltroVal.AutoSize = true;
            lblFiltroVal.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblFiltroVal.Location = new Point(130, 188);
            lblFiltroVal.Name = "lblFiltroVal";
            lblFiltroVal.Size = new Size(24, 20);
            lblFiltroVal.TabIndex = 6;
            lblFiltroVal.Text = "—";
            // 
            // lblMinHistKey
            // 
            lblMinHistKey.AutoSize = true;
            lblMinHistKey.Location = new Point(24, 216);
            lblMinHistKey.Name = "lblMinHistKey";
            lblMinHistKey.Size = new Size(62, 20);
            lblMinHistKey.TabIndex = 7;
            lblMinHistKey.Text = "Mínima:";
            // 
            // lblMinHistVal
            // 
            lblMinHistVal.AutoSize = true;
            lblMinHistVal.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblMinHistVal.Location = new Point(130, 216);
            lblMinHistVal.Name = "lblMinHistVal";
            lblMinHistVal.Size = new Size(24, 20);
            lblMinHistVal.TabIndex = 8;
            lblMinHistVal.Text = "—";
            // 
            // lblMaxHistKey
            // 
            lblMaxHistKey.AutoSize = true;
            lblMaxHistKey.Location = new Point(210, 216);
            lblMaxHistKey.Name = "lblMaxHistKey";
            lblMaxHistKey.Size = new Size(65, 20);
            lblMaxHistKey.TabIndex = 9;
            lblMaxHistKey.Text = "Máxima:";
            // 
            // lblMaxHistVal
            // 
            lblMaxHistVal.AutoSize = true;
            lblMaxHistVal.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblMaxHistVal.Location = new Point(285, 216);
            lblMaxHistVal.Name = "lblMaxHistVal";
            lblMaxHistVal.Size = new Size(24, 20);
            lblMaxHistVal.TabIndex = 10;
            lblMaxHistVal.Text = "—";
            // 
            // lblRegistrosVal
            // 
            lblRegistrosVal.AutoSize = true;
            lblRegistrosVal.ForeColor = Color.Gray;
            lblRegistrosVal.Location = new Point(24, 244);
            lblRegistrosVal.Name = "lblRegistrosVal";
            lblRegistrosVal.Size = new Size(213, 20);
            lblRegistrosVal.TabIndex = 11;
            lblRegistrosVal.Text = "Basado en — registros del CSV";
            // 
            // grpAnomalia
            // 
            grpAnomalia.Controls.Add(lblDesviacionKey);
            grpAnomalia.Controls.Add(lblDesviacionVal);
            grpAnomalia.Controls.Add(lblDescAnomalia);
            grpAnomalia.Controls.Add(lblNivelKey);
            grpAnomalia.Controls.Add(pnlSemaforoVerde);
            grpAnomalia.Controls.Add(pnlSemaforoAmarillo);
            grpAnomalia.Controls.Add(pnlSemaforoRojo);
            grpAnomalia.Controls.Add(lblSemaforoTexto);
            grpAnomalia.Controls.Add(btnGuardarAlerta);
            grpAnomalia.Location = new Point(759, 19);
            grpAnomalia.Name = "grpAnomalia";
            grpAnomalia.Size = new Size(200, 100);
            grpAnomalia.TabIndex = 2;
            grpAnomalia.TabStop = false;
            // 
            // lblDesviacionKey
            // 
            lblDesviacionKey.AutoSize = true;
            lblDesviacionKey.Location = new Point(20, 32);
            lblDesviacionKey.Name = "lblDesviacionKey";
            lblDesviacionKey.Size = new Size(152, 20);
            lblDesviacionKey.TabIndex = 0;
            lblDesviacionKey.Text = "Desviación detectada";
            // 
            // lblDesviacionVal
            // 
            lblDesviacionVal.AutoSize = true;
            lblDesviacionVal.Font = new Font("Segoe UI", 30F, FontStyle.Bold);
            lblDesviacionVal.Location = new Point(20, 58);
            lblDesviacionVal.Name = "lblDesviacionVal";
            lblDesviacionVal.Size = new Size(79, 67);
            lblDesviacionVal.TabIndex = 1;
            lblDesviacionVal.Text = "—";
            // 
            // lblDescAnomalia
            // 
            lblDescAnomalia.ForeColor = Color.Gray;
            lblDescAnomalia.Location = new Point(24, 120);
            lblDescAnomalia.Name = "lblDescAnomalia";
            lblDescAnomalia.Size = new Size(320, 40);
            lblDescAnomalia.TabIndex = 2;
            lblDescAnomalia.Text = "Realiza una consulta para evaluar el riesgo climático.";
            // 
            // lblNivelKey
            // 
            lblNivelKey.AutoSize = true;
            lblNivelKey.Location = new Point(24, 175);
            lblNivelKey.Name = "lblNivelKey";
            lblNivelKey.Size = new Size(106, 20);
            lblNivelKey.TabIndex = 3;
            lblNivelKey.Text = "Nivel de alerta";
            // 
            // pnlSemaforoVerde
            // 
            pnlSemaforoVerde.BackColor = Color.LightGray;
            pnlSemaforoVerde.Location = new Point(24, 205);
            pnlSemaforoVerde.Name = "pnlSemaforoVerde";
            pnlSemaforoVerde.Size = new Size(35, 18);
            pnlSemaforoVerde.TabIndex = 4;
            // 
            // pnlSemaforoAmarillo
            // 
            pnlSemaforoAmarillo.BackColor = Color.LightGray;
            pnlSemaforoAmarillo.Location = new Point(65, 205);
            pnlSemaforoAmarillo.Name = "pnlSemaforoAmarillo";
            pnlSemaforoAmarillo.Size = new Size(35, 18);
            pnlSemaforoAmarillo.TabIndex = 5;
            // 
            // pnlSemaforoRojo
            // 
            pnlSemaforoRojo.BackColor = Color.LightGray;
            pnlSemaforoRojo.Location = new Point(106, 205);
            pnlSemaforoRojo.Name = "pnlSemaforoRojo";
            pnlSemaforoRojo.Size = new Size(35, 18);
            pnlSemaforoRojo.TabIndex = 6;
            // 
            // lblSemaforoTexto
            // 
            lblSemaforoTexto.AutoSize = true;
            lblSemaforoTexto.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblSemaforoTexto.Location = new Point(155, 201);
            lblSemaforoTexto.Name = "lblSemaforoTexto";
            lblSemaforoTexto.Size = new Size(24, 20);
            lblSemaforoTexto.TabIndex = 7;
            lblSemaforoTexto.Text = "—";
            // 
            // btnGuardarAlerta
            // 
            btnGuardarAlerta.Enabled = false;
            btnGuardarAlerta.Location = new Point(24, 238);
            btnGuardarAlerta.Name = "btnGuardarAlerta";
            btnGuardarAlerta.Size = new Size(135, 32);
            btnGuardarAlerta.TabIndex = 8;
            btnGuardarAlerta.Text = "Guardar alerta";
            // 
            // grpBusqueda
            // 
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
            grpBusqueda.Location = new Point(18, 18);
            grpBusqueda.Name = "grpBusqueda";
            grpBusqueda.Padding = new Padding(16);
            grpBusqueda.Size = new Size(1136, 105);
            grpBusqueda.TabIndex = 1;
            grpBusqueda.TabStop = false;
            grpBusqueda.Text = "Parámetros de consulta";
            // 
            // lblEstado
            // 
            lblEstado.AutoSize = true;
            lblEstado.Location = new Point(20, 30);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(54, 20);
            lblEstado.TabIndex = 0;
            lblEstado.Text = "Estado";
            // 
            // cmbEstado
            // 
            cmbEstado.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbEstado.Location = new Point(20, 55);
            cmbEstado.Name = "cmbEstado";
            cmbEstado.Size = new Size(200, 28);
            cmbEstado.TabIndex = 1;
            cmbEstado.SelectedIndexChanged += cmbEstado_SelectedIndexChanged_1;
            // 
            // lblMunicipio
            // 
            lblMunicipio.AutoSize = true;
            lblMunicipio.Location = new Point(235, 30);
            lblMunicipio.Name = "lblMunicipio";
            lblMunicipio.Size = new Size(75, 20);
            lblMunicipio.TabIndex = 2;
            lblMunicipio.Text = "Municipio";
            // 
            // cmbMunicipio
            // 
            cmbMunicipio.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbMunicipio.Enabled = false;
            cmbMunicipio.Location = new Point(235, 55);
            cmbMunicipio.Name = "cmbMunicipio";
            cmbMunicipio.Size = new Size(230, 28);
            cmbMunicipio.TabIndex = 3;
            cmbMunicipio.SelectedIndexChanged += cmbMunicipio_SelectedIndexChanged_1;
            // 
            // lblAnio
            // 
            lblAnio.AutoSize = true;
            lblAnio.Location = new Point(480, 30);
            lblAnio.Name = "lblAnio";
            lblAnio.Size = new Size(36, 20);
            lblAnio.TabIndex = 4;
            lblAnio.Text = "Año";
            // 
            // cmbAnio
            // 
            cmbAnio.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbAnio.Location = new Point(480, 55);
            cmbAnio.Name = "cmbAnio";
            cmbAnio.Size = new Size(95, 28);
            cmbAnio.TabIndex = 5;
            // 
            // lblEstacion
            // 
            lblEstacion.AutoSize = true;
            lblEstacion.Location = new Point(590, 30);
            lblEstacion.Name = "lblEstacion";
            lblEstacion.Size = new Size(64, 20);
            lblEstacion.TabIndex = 6;
            lblEstacion.Text = "Estación";
            // 
            // cmbEstacion
            // 
            cmbEstacion.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbEstacion.Items.AddRange(new object[] { "Primavera", "Verano", "Otoño", "Invierno" });
            cmbEstacion.Location = new Point(590, 55);
            cmbEstacion.Name = "cmbEstacion";
            cmbEstacion.Size = new Size(135, 28);
            cmbEstacion.TabIndex = 7;
            // 
            // btnConsultar
            // 
            btnConsultar.BackColor = Color.FromArgb(31, 78, 121);
            btnConsultar.Enabled = false;
            btnConsultar.FlatStyle = FlatStyle.Flat;
            btnConsultar.ForeColor = Color.White;
            btnConsultar.Location = new Point(745, 53);
            btnConsultar.Name = "btnConsultar";
            btnConsultar.Size = new Size(120, 32);
            btnConsultar.TabIndex = 8;
            btnConsultar.Text = "Consultar";
            btnConsultar.UseVisualStyleBackColor = false;
            btnConsultar.Click += btnConsultar_Click_1;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(875, 53);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(100, 32);
            btnLimpiar.TabIndex = 9;
            btnLimpiar.Text = "Limpiar";
            // 
            // tabAnalisis
            // 
            tabAnalisis.BackColor = Color.FromArgb(244, 247, 250);
            tabAnalisis.Controls.Add(dgvHistorico);
            tabAnalisis.Controls.Add(grpRanking);
            tabAnalisis.Controls.Add(grpFiltrosGlobal);
            tabAnalisis.Location = new Point(4, 29);
            tabAnalisis.Name = "tabAnalisis";
            tabAnalisis.Padding = new Padding(18);
            tabAnalisis.Size = new Size(192, 67);
            tabAnalisis.TabIndex = 1;
            tabAnalisis.Text = "Análisis global";
            // 
            // dgvHistorico
            // 
            dgvHistorico.AllowUserToAddRows = false;
            dgvHistorico.AllowUserToDeleteRows = false;
            dgvHistorico.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvHistorico.BackgroundColor = Color.White;
            dgvHistorico.ColumnHeadersHeight = 29;
            dgvHistorico.Dock = DockStyle.Fill;
            dgvHistorico.Location = new Point(18, 108);
            dgvHistorico.Name = "dgvHistorico";
            dgvHistorico.ReadOnly = true;
            dgvHistorico.RowHeadersWidth = 51;
            dgvHistorico.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvHistorico.Size = new Size(156, 0);
            dgvHistorico.TabIndex = 0;
            // 
            // grpRanking
            // 
            grpRanking.Controls.Add(lblRankingCaliente);
            grpRanking.Controls.Add(lstCalientes);
            grpRanking.Controls.Add(lblRankingFrio);
            grpRanking.Controls.Add(lstFrios);
            grpRanking.Dock = DockStyle.Bottom;
            grpRanking.Location = new Point(18, -111);
            grpRanking.Name = "grpRanking";
            grpRanking.Size = new Size(156, 160);
            grpRanking.TabIndex = 1;
            grpRanking.TabStop = false;
            grpRanking.Text = "Ranking climático";
            // 
            // lblRankingCaliente
            // 
            lblRankingCaliente.AutoSize = true;
            lblRankingCaliente.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblRankingCaliente.ForeColor = Color.Firebrick;
            lblRankingCaliente.Location = new Point(18, 28);
            lblRankingCaliente.Name = "lblRankingCaliente";
            lblRankingCaliente.Size = new Size(146, 20);
            lblRankingCaliente.TabIndex = 0;
            lblRankingCaliente.Text = "Top 5 más calientes";
            // 
            // lstCalientes
            // 
            lstCalientes.Location = new Point(18, 55);
            lstCalientes.Name = "lstCalientes";
            lstCalientes.Size = new Size(500, 84);
            lstCalientes.TabIndex = 1;
            // 
            // lblRankingFrio
            // 
            lblRankingFrio.AutoSize = true;
            lblRankingFrio.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblRankingFrio.ForeColor = Color.SteelBlue;
            lblRankingFrio.Location = new Point(560, 28);
            lblRankingFrio.Name = "lblRankingFrio";
            lblRankingFrio.Size = new Size(117, 20);
            lblRankingFrio.TabIndex = 2;
            lblRankingFrio.Text = "Top 5 más fríos";
            // 
            // lstFrios
            // 
            lstFrios.Location = new Point(560, 55);
            lstFrios.Name = "lstFrios";
            lstFrios.Size = new Size(500, 84);
            lstFrios.TabIndex = 3;
            // 
            // grpFiltrosGlobal
            // 
            grpFiltrosGlobal.Controls.Add(lblFiltroAnio);
            grpFiltrosGlobal.Controls.Add(cmbFiltroAnio);
            grpFiltrosGlobal.Controls.Add(lblFiltroEstacion);
            grpFiltrosGlobal.Controls.Add(cmbFiltroEstacion);
            grpFiltrosGlobal.Controls.Add(lblBuscarEstado);
            grpFiltrosGlobal.Controls.Add(txtBuscarEstado);
            grpFiltrosGlobal.Controls.Add(btnFiltrar);
            grpFiltrosGlobal.Controls.Add(btnLimpiarFiltro);
            grpFiltrosGlobal.Dock = DockStyle.Top;
            grpFiltrosGlobal.Location = new Point(18, 18);
            grpFiltrosGlobal.Name = "grpFiltrosGlobal";
            grpFiltrosGlobal.Size = new Size(156, 90);
            grpFiltrosGlobal.TabIndex = 2;
            grpFiltrosGlobal.TabStop = false;
            grpFiltrosGlobal.Text = "Filtros";
            // 
            // lblFiltroAnio
            // 
            lblFiltroAnio.AutoSize = true;
            lblFiltroAnio.Location = new Point(18, 38);
            lblFiltroAnio.Name = "lblFiltroAnio";
            lblFiltroAnio.Size = new Size(39, 20);
            lblFiltroAnio.TabIndex = 0;
            lblFiltroAnio.Text = "Año:";
            // 
            // cmbFiltroAnio
            // 
            cmbFiltroAnio.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbFiltroAnio.Location = new Point(60, 34);
            cmbFiltroAnio.Name = "cmbFiltroAnio";
            cmbFiltroAnio.Size = new Size(100, 28);
            cmbFiltroAnio.TabIndex = 1;
            // 
            // lblFiltroEstacion
            // 
            lblFiltroEstacion.AutoSize = true;
            lblFiltroEstacion.Location = new Point(180, 38);
            lblFiltroEstacion.Name = "lblFiltroEstacion";
            lblFiltroEstacion.Size = new Size(67, 20);
            lblFiltroEstacion.TabIndex = 2;
            lblFiltroEstacion.Text = "Estación:";
            // 
            // cmbFiltroEstacion
            // 
            cmbFiltroEstacion.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbFiltroEstacion.Items.AddRange(new object[] { "Todas", "Primavera", "Verano", "Otoño", "Invierno" });
            cmbFiltroEstacion.Location = new Point(250, 34);
            cmbFiltroEstacion.Name = "cmbFiltroEstacion";
            cmbFiltroEstacion.Size = new Size(140, 28);
            cmbFiltroEstacion.TabIndex = 3;
            // 
            // lblBuscarEstado
            // 
            lblBuscarEstado.AutoSize = true;
            lblBuscarEstado.Location = new Point(410, 38);
            lblBuscarEstado.Name = "lblBuscarEstado";
            lblBuscarEstado.Size = new Size(57, 20);
            lblBuscarEstado.TabIndex = 4;
            lblBuscarEstado.Text = "Estado:";
            // 
            // txtBuscarEstado
            // 
            txtBuscarEstado.Location = new Point(470, 34);
            txtBuscarEstado.Name = "txtBuscarEstado";
            txtBuscarEstado.Size = new Size(210, 27);
            txtBuscarEstado.TabIndex = 5;
            // 
            // btnFiltrar
            // 
            btnFiltrar.Location = new Point(700, 32);
            btnFiltrar.Name = "btnFiltrar";
            btnFiltrar.Size = new Size(90, 32);
            btnFiltrar.TabIndex = 6;
            btnFiltrar.Text = "Filtrar";
            // 
            // btnLimpiarFiltro
            // 
            btnLimpiarFiltro.Location = new Point(800, 32);
            btnLimpiarFiltro.Name = "btnLimpiarFiltro";
            btnLimpiarFiltro.Size = new Size(90, 32);
            btnLimpiarFiltro.TabIndex = 7;
            btnLimpiarFiltro.Text = "Limpiar";
            // 
            // tabFavoritos
            // 
            tabFavoritos.BackColor = Color.FromArgb(244, 247, 250);
            tabFavoritos.Controls.Add(dgvFavoritos);
            tabFavoritos.Controls.Add(grpAgregarFav);
            tabFavoritos.Location = new Point(4, 29);
            tabFavoritos.Name = "tabFavoritos";
            tabFavoritos.Padding = new Padding(18);
            tabFavoritos.Size = new Size(192, 67);
            tabFavoritos.TabIndex = 2;
            tabFavoritos.Text = "Favoritos";
            // 
            // dgvFavoritos
            // 
            dgvFavoritos.AllowUserToAddRows = false;
            dgvFavoritos.AllowUserToDeleteRows = false;
            dgvFavoritos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvFavoritos.BackgroundColor = Color.White;
            dgvFavoritos.ColumnHeadersHeight = 29;
            dgvFavoritos.Dock = DockStyle.Fill;
            dgvFavoritos.Location = new Point(18, 18);
            dgvFavoritos.Name = "dgvFavoritos";
            dgvFavoritos.ReadOnly = true;
            dgvFavoritos.RowHeadersWidth = 51;
            dgvFavoritos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvFavoritos.Size = new Size(156, 0);
            dgvFavoritos.TabIndex = 0;
            // 
            // grpAgregarFav
            // 
            grpAgregarFav.Controls.Add(lblNuevoFavEstado);
            grpAgregarFav.Controls.Add(cmbNuevoFavEstado);
            grpAgregarFav.Controls.Add(lblNuevoFavMun);
            grpAgregarFav.Controls.Add(cmbNuevoFavMun);
            grpAgregarFav.Controls.Add(btnAgregarFav);
            grpAgregarFav.Controls.Add(btnEliminarFav);
            grpAgregarFav.Dock = DockStyle.Bottom;
            grpAgregarFav.Location = new Point(18, -46);
            grpAgregarFav.Name = "grpAgregarFav";
            grpAgregarFav.Size = new Size(156, 95);
            grpAgregarFav.TabIndex = 1;
            grpAgregarFav.TabStop = false;
            grpAgregarFav.Text = "Agregar municipio favorito";
            // 
            // lblNuevoFavEstado
            // 
            lblNuevoFavEstado.AutoSize = true;
            lblNuevoFavEstado.Location = new Point(18, 40);
            lblNuevoFavEstado.Name = "lblNuevoFavEstado";
            lblNuevoFavEstado.Size = new Size(57, 20);
            lblNuevoFavEstado.TabIndex = 0;
            lblNuevoFavEstado.Text = "Estado:";
            // 
            // cmbNuevoFavEstado
            // 
            cmbNuevoFavEstado.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbNuevoFavEstado.Location = new Point(80, 36);
            cmbNuevoFavEstado.Name = "cmbNuevoFavEstado";
            cmbNuevoFavEstado.Size = new Size(220, 28);
            cmbNuevoFavEstado.TabIndex = 1;
            // 
            // lblNuevoFavMun
            // 
            lblNuevoFavMun.AutoSize = true;
            lblNuevoFavMun.Location = new Point(320, 40);
            lblNuevoFavMun.Name = "lblNuevoFavMun";
            lblNuevoFavMun.Size = new Size(78, 20);
            lblNuevoFavMun.TabIndex = 2;
            lblNuevoFavMun.Text = "Municipio:";
            // 
            // cmbNuevoFavMun
            // 
            cmbNuevoFavMun.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbNuevoFavMun.Enabled = false;
            cmbNuevoFavMun.Location = new Point(405, 36);
            cmbNuevoFavMun.Name = "cmbNuevoFavMun";
            cmbNuevoFavMun.Size = new Size(240, 28);
            cmbNuevoFavMun.TabIndex = 3;
            // 
            // btnAgregarFav
            // 
            btnAgregarFav.Location = new Point(665, 34);
            btnAgregarFav.Name = "btnAgregarFav";
            btnAgregarFav.Size = new Size(100, 32);
            btnAgregarFav.TabIndex = 4;
            btnAgregarFav.Text = "Agregar";
            // 
            // btnEliminarFav
            // 
            btnEliminarFav.Location = new Point(785, 34);
            btnEliminarFav.Name = "btnEliminarFav";
            btnEliminarFav.Size = new Size(160, 32);
            btnEliminarFav.TabIndex = 5;
            btnEliminarFav.Text = "Eliminar seleccionado";
            // 
            // tabConfig
            // 
            tabConfig.BackColor = Color.FromArgb(244, 247, 250);
            tabConfig.Controls.Add(btnGuardarConfig);
            tabConfig.Controls.Add(grpPreferencias);
            tabConfig.Controls.Add(grpArchivos);
            tabConfig.Controls.Add(grpBaseDatos);
            tabConfig.Location = new Point(4, 29);
            tabConfig.Name = "tabConfig";
            tabConfig.Padding = new Padding(18);
            tabConfig.Size = new Size(192, 67);
            tabConfig.TabIndex = 3;
            tabConfig.Text = "Configuración";
            // 
            // btnGuardarConfig
            // 
            btnGuardarConfig.BackColor = Color.FromArgb(31, 78, 121);
            btnGuardarConfig.Dock = DockStyle.Top;
            btnGuardarConfig.FlatStyle = FlatStyle.Flat;
            btnGuardarConfig.ForeColor = Color.White;
            btnGuardarConfig.Location = new Point(18, 478);
            btnGuardarConfig.Name = "btnGuardarConfig";
            btnGuardarConfig.Size = new Size(156, 42);
            btnGuardarConfig.TabIndex = 0;
            btnGuardarConfig.Text = "Guardar configuración";
            btnGuardarConfig.UseVisualStyleBackColor = false;
            // 
            // grpPreferencias
            // 
            grpPreferencias.Controls.Add(lblUmbral);
            grpPreferencias.Controls.Add(nudUmbral);
            grpPreferencias.Controls.Add(lblUmbralSufijo);
            grpPreferencias.Controls.Add(lblUnidades);
            grpPreferencias.Controls.Add(rbCelsius);
            grpPreferencias.Controls.Add(rbFahrenheit);
            grpPreferencias.Dock = DockStyle.Top;
            grpPreferencias.Location = new Point(18, 383);
            grpPreferencias.Name = "grpPreferencias";
            grpPreferencias.Size = new Size(156, 95);
            grpPreferencias.TabIndex = 1;
            grpPreferencias.TabStop = false;
            grpPreferencias.Text = "Preferencias";
            // 
            // lblUmbral
            // 
            lblUmbral.AutoSize = true;
            lblUmbral.Location = new Point(18, 40);
            lblUmbral.Name = "lblUmbral";
            lblUmbral.Size = new Size(124, 20);
            lblUmbral.TabIndex = 0;
            lblUmbral.Text = "Umbral de alerta:";
            // 
            // nudUmbral
            // 
            nudUmbral.DecimalPlaces = 1;
            nudUmbral.Increment = new decimal(new int[] { 5, 0, 0, 65536 });
            nudUmbral.Location = new Point(145, 36);
            nudUmbral.Maximum = new decimal(new int[] { 20, 0, 0, 0 });
            nudUmbral.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudUmbral.Name = "nudUmbral";
            nudUmbral.Size = new Size(80, 27);
            nudUmbral.TabIndex = 1;
            nudUmbral.Value = new decimal(new int[] { 3, 0, 0, 0 });
            // 
            // lblUmbralSufijo
            // 
            lblUmbralSufijo.AutoSize = true;
            lblUmbralSufijo.Location = new Point(235, 40);
            lblUmbralSufijo.Name = "lblUmbralSufijo";
            lblUmbralSufijo.Size = new Size(24, 20);
            lblUmbralSufijo.TabIndex = 2;
            lblUmbralSufijo.Text = "°C";
            // 
            // lblUnidades
            // 
            lblUnidades.AutoSize = true;
            lblUnidades.Location = new Point(310, 40);
            lblUnidades.Name = "lblUnidades";
            lblUnidades.Size = new Size(74, 20);
            lblUnidades.TabIndex = 3;
            lblUnidades.Text = "Unidades:";
            // 
            // rbCelsius
            // 
            rbCelsius.AutoSize = true;
            rbCelsius.Checked = true;
            rbCelsius.Location = new Point(390, 37);
            rbCelsius.Name = "rbCelsius";
            rbCelsius.Size = new Size(75, 24);
            rbCelsius.TabIndex = 4;
            rbCelsius.TabStop = true;
            rbCelsius.Text = "Celsius";
            // 
            // rbFahrenheit
            // 
            rbFahrenheit.AutoSize = true;
            rbFahrenheit.Location = new Point(475, 37);
            rbFahrenheit.Name = "rbFahrenheit";
            rbFahrenheit.Size = new Size(98, 24);
            rbFahrenheit.TabIndex = 5;
            rbFahrenheit.Text = "Fahrenheit";
            // 
            // grpArchivos
            // 
            grpArchivos.Controls.Add(lblRutaCSV);
            grpArchivos.Controls.Add(txtRutaCSV);
            grpArchivos.Controls.Add(btnExplorarCSV);
            grpArchivos.Controls.Add(lblRutaJSON);
            grpArchivos.Controls.Add(txtRutaJSON);
            grpArchivos.Controls.Add(btnExplorarJSON);
            grpArchivos.Dock = DockStyle.Top;
            grpArchivos.Location = new Point(18, 248);
            grpArchivos.Name = "grpArchivos";
            grpArchivos.Size = new Size(156, 135);
            grpArchivos.TabIndex = 2;
            grpArchivos.TabStop = false;
            grpArchivos.Text = "Archivos de datos";
            // 
            // lblRutaCSV
            // 
            lblRutaCSV.AutoSize = true;
            lblRutaCSV.Location = new Point(18, 38);
            lblRutaCSV.Name = "lblRutaCSV";
            lblRutaCSV.Size = new Size(38, 20);
            lblRutaCSV.TabIndex = 0;
            lblRutaCSV.Text = "CSV:";
            // 
            // txtRutaCSV
            // 
            txtRutaCSV.Location = new Point(90, 34);
            txtRutaCSV.Name = "txtRutaCSV";
            txtRutaCSV.Size = new Size(700, 27);
            txtRutaCSV.TabIndex = 1;
            txtRutaCSV.Text = "Data\\data.csv";
            // 
            // btnExplorarCSV
            // 
            btnExplorarCSV.Location = new Point(805, 32);
            btnExplorarCSV.Name = "btnExplorarCSV";
            btnExplorarCSV.Size = new Size(100, 32);
            btnExplorarCSV.TabIndex = 2;
            btnExplorarCSV.Text = "Explorar";
            // 
            // lblRutaJSON
            // 
            lblRutaJSON.AutoSize = true;
            lblRutaJSON.Location = new Point(18, 82);
            lblRutaJSON.Name = "lblRutaJSON";
            lblRutaJSON.Size = new Size(47, 20);
            lblRutaJSON.TabIndex = 3;
            lblRutaJSON.Text = "JSON:";
            // 
            // txtRutaJSON
            // 
            txtRutaJSON.Location = new Point(90, 78);
            txtRutaJSON.Name = "txtRutaJSON";
            txtRutaJSON.Size = new Size(700, 27);
            txtRutaJSON.TabIndex = 4;
            txtRutaJSON.Text = "Data\\municipios_mx.json";
            // 
            // btnExplorarJSON
            // 
            btnExplorarJSON.Location = new Point(805, 76);
            btnExplorarJSON.Name = "btnExplorarJSON";
            btnExplorarJSON.Size = new Size(100, 32);
            btnExplorarJSON.TabIndex = 5;
            btnExplorarJSON.Text = "Explorar";
            // 
            // grpBaseDatos
            // 
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
            grpBaseDatos.Location = new Point(18, 18);
            grpBaseDatos.Name = "grpBaseDatos";
            grpBaseDatos.Size = new Size(156, 230);
            grpBaseDatos.TabIndex = 3;
            grpBaseDatos.TabStop = false;
            grpBaseDatos.Text = "Base de datos";
            // 
            // lblMotorBD
            // 
            lblMotorBD.AutoSize = true;
            lblMotorBD.Location = new Point(18, 35);
            lblMotorBD.Name = "lblMotorBD";
            lblMotorBD.Size = new Size(53, 20);
            lblMotorBD.TabIndex = 0;
            lblMotorBD.Text = "Motor:";
            // 
            // cmbMotorBD
            // 
            cmbMotorBD.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbMotorBD.Items.AddRange(new object[] { "SQLite", "MariaDB" });
            cmbMotorBD.Location = new Point(90, 31);
            cmbMotorBD.Name = "cmbMotorBD";
            cmbMotorBD.Size = new Size(160, 28);
            cmbMotorBD.TabIndex = 1;
            // 
            // lblSQLitePath
            // 
            lblSQLitePath.AutoSize = true;
            lblSQLitePath.Location = new Point(18, 78);
            lblSQLitePath.Name = "lblSQLitePath";
            lblSQLitePath.Size = new Size(109, 20);
            lblSQLitePath.TabIndex = 2;
            lblSQLitePath.Text = "Archivo SQLite:";
            // 
            // txtSQLitePath
            // 
            txtSQLitePath.Location = new Point(140, 74);
            txtSQLitePath.Name = "txtSQLitePath";
            txtSQLitePath.Size = new Size(650, 27);
            txtSQLitePath.TabIndex = 3;
            txtSQLitePath.Text = "Data\\inteligencia_climatica.db";
            // 
            // btnExplorarSQLite
            // 
            btnExplorarSQLite.Location = new Point(805, 72);
            btnExplorarSQLite.Name = "btnExplorarSQLite";
            btnExplorarSQLite.Size = new Size(100, 32);
            btnExplorarSQLite.TabIndex = 4;
            btnExplorarSQLite.Text = "Explorar";
            // 
            // lblMariaServidor
            // 
            lblMariaServidor.AutoSize = true;
            lblMariaServidor.Location = new Point(18, 122);
            lblMariaServidor.Name = "lblMariaServidor";
            lblMariaServidor.Size = new Size(67, 20);
            lblMariaServidor.TabIndex = 5;
            lblMariaServidor.Text = "Servidor:";
            // 
            // txtMariaServidor
            // 
            txtMariaServidor.Location = new Point(90, 118);
            txtMariaServidor.Name = "txtMariaServidor";
            txtMariaServidor.Size = new Size(180, 27);
            txtMariaServidor.TabIndex = 6;
            txtMariaServidor.Text = "localhost";
            // 
            // lblMariaPuerto
            // 
            lblMariaPuerto.AutoSize = true;
            lblMariaPuerto.Location = new Point(290, 122);
            lblMariaPuerto.Name = "lblMariaPuerto";
            lblMariaPuerto.Size = new Size(55, 20);
            lblMariaPuerto.TabIndex = 7;
            lblMariaPuerto.Text = "Puerto:";
            // 
            // txtMariaPuerto
            // 
            txtMariaPuerto.Location = new Point(350, 118);
            txtMariaPuerto.Name = "txtMariaPuerto";
            txtMariaPuerto.Size = new Size(80, 27);
            txtMariaPuerto.TabIndex = 8;
            txtMariaPuerto.Text = "3306";
            // 
            // lblMariaBD
            // 
            lblMariaBD.AutoSize = true;
            lblMariaBD.Location = new Point(450, 122);
            lblMariaBD.Name = "lblMariaBD";
            lblMariaBD.Size = new Size(43, 20);
            lblMariaBD.TabIndex = 9;
            lblMariaBD.Text = "Base:";
            // 
            // txtMariaBD
            // 
            txtMariaBD.Location = new Point(500, 118);
            txtMariaBD.Name = "txtMariaBD";
            txtMariaBD.Size = new Size(220, 27);
            txtMariaBD.TabIndex = 10;
            txtMariaBD.Text = "inteligencia_climatica";
            // 
            // lblMariaUsuario
            // 
            lblMariaUsuario.AutoSize = true;
            lblMariaUsuario.Location = new Point(18, 164);
            lblMariaUsuario.Name = "lblMariaUsuario";
            lblMariaUsuario.Size = new Size(62, 20);
            lblMariaUsuario.TabIndex = 11;
            lblMariaUsuario.Text = "Usuario:";
            // 
            // txtMariaUsuario
            // 
            txtMariaUsuario.Location = new Point(90, 160);
            txtMariaUsuario.Name = "txtMariaUsuario";
            txtMariaUsuario.Size = new Size(180, 27);
            txtMariaUsuario.TabIndex = 12;
            // 
            // lblMariaPassword
            // 
            lblMariaPassword.AutoSize = true;
            lblMariaPassword.Location = new Point(290, 164);
            lblMariaPassword.Name = "lblMariaPassword";
            lblMariaPassword.Size = new Size(86, 20);
            lblMariaPassword.TabIndex = 13;
            lblMariaPassword.Text = "Contraseña:";
            // 
            // txtMariaPassword
            // 
            txtMariaPassword.Location = new Point(390, 160);
            txtMariaPassword.Name = "txtMariaPassword";
            txtMariaPassword.Size = new Size(180, 27);
            txtMariaPassword.TabIndex = 14;
            txtMariaPassword.UseSystemPasswordChar = true;
            // 
            // btnProbarConexion
            // 
            btnProbarConexion.Location = new Point(590, 158);
            btnProbarConexion.Name = "btnProbarConexion";
            btnProbarConexion.Size = new Size(140, 32);
            btnProbarConexion.TabIndex = 15;
            btnProbarConexion.Text = "Probar conexión";
            // 
            // lblEstadoConexion
            // 
            lblEstadoConexion.AutoSize = true;
            lblEstadoConexion.ForeColor = Color.Gray;
            lblEstadoConexion.Location = new Point(750, 164);
            lblEstadoConexion.Name = "lblEstadoConexion";
            lblEstadoConexion.Size = new Size(128, 20);
            lblEstadoConexion.TabIndex = 16;
            lblEstadoConexion.Text = "Estado: sin probar";
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.FromArgb(31, 78, 121);
            pnlHeader.Controls.Add(lblTitulo);
            pnlHeader.Controls.Add(lblSubtitulo);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(1180, 92);
            pnlHeader.TabIndex = 1;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.White;
            lblTitulo.Location = new Point(24, 16);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(713, 46);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Sistema de Inteligencia Climática — México";
            // 
            // lblSubtitulo
            // 
            lblSubtitulo.AutoSize = true;
            lblSubtitulo.Font = new Font("Segoe UI", 10F);
            lblSubtitulo.ForeColor = Color.FromArgb(220, 238, 255);
            lblSubtitulo.Location = new Point(27, 57);
            lblSubtitulo.Name = "lblSubtitulo";
            lblSubtitulo.Size = new Size(635, 23);
            lblSubtitulo.TabIndex = 1;
            lblSubtitulo.Text = "Consulta climática, comparación histórica y detección de anomalías por municipio";
            // 
            // statusStrip
            // 
            statusStrip.ImageScalingSize = new Size(20, 20);
            statusStrip.Items.AddRange(new ToolStripItem[] { tssSQLite, tssMariaDB, tssAPI, tssRegistros });
            statusStrip.Location = new Point(0, 754);
            statusStrip.Name = "statusStrip";
            statusStrip.Size = new Size(1180, 26);
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
            tssRegistros.Size = new Size(886, 20);
            tssRegistros.Spring = true;
            tssRegistros.Text = "Registros cargados: —";
            tssRegistros.TextAlign = ContentAlignment.MiddleRight;
            // 
            // Form1
            // 
            BackColor = Color.FromArgb(244, 247, 250);
            ClientSize = new Size(1180, 780);
            Controls.Add(tabControl);
            Controls.Add(pnlHeader);
            Controls.Add(statusStrip);
            Font = new Font("Segoe UI", 9F);
            MinimumSize = new Size(1100, 760);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sistema de Inteligencia Climática — México";
            Load += Form1_Load;
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
            grpBusqueda.PerformLayout();
            tabAnalisis.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvHistorico).EndInit();
            grpRanking.ResumeLayout(false);
            grpRanking.PerformLayout();
            grpFiltrosGlobal.ResumeLayout(false);
            grpFiltrosGlobal.PerformLayout();
            tabFavoritos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvFavoritos).EndInit();
            grpAgregarFav.ResumeLayout(false);
            grpAgregarFav.PerformLayout();
            tabConfig.ResumeLayout(false);
            grpPreferencias.ResumeLayout(false);
            grpPreferencias.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudUmbral).EndInit();
            grpArchivos.ResumeLayout(false);
            grpArchivos.PerformLayout();
            grpBaseDatos.ResumeLayout(false);
            grpBaseDatos.PerformLayout();
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            statusStrip.ResumeLayout(false);
            statusStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        private void ConfigurarTarjeta(GroupBox groupBox, string titulo)
        {
            groupBox.Text = titulo;
            groupBox.Dock = DockStyle.Fill;
            groupBox.Margin = new Padding(8);
            groupBox.Padding = new Padding(12);
            groupBox.BackColor = Color.White;
        }
    }
}