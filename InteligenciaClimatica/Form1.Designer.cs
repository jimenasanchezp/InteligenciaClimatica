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
            tabControl = new TabControl();
            tabConsulta = new TabPage();
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
            lblHintMunicipio = new Label();
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
            tabAnalisis = new TabPage();
            grpFiltrosGlobal = new GroupBox();
            lblFiltroAnio = new Label();
            cmbFiltroAnio = new ComboBox();
            lblFiltroEstacion = new Label();
            cmbFiltroEstacion = new ComboBox();
            lblBuscarEstado = new Label();
            txtBuscarEstado = new TextBox();
            btnFiltrar = new Button();
            btnLimpiarFiltro = new Button();
            dgvHistorico = new DataGridView();
            grpRanking = new GroupBox();
            lblRankingCaliente = new Label();
            lstCalientes = new ListBox();
            lblRankingFrio = new Label();
            lstFrios = new ListBox();
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
            grpConexion = new GroupBox();
            lblCadenaConexion = new Label();
            txtCadenaConexion = new TextBox();
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
            tssSQLServer = new ToolStripStatusLabel();
            tssAPI = new ToolStripStatusLabel();
            tssRegistros = new ToolStripStatusLabel();
            tabControl.SuspendLayout();
            tabConsulta.SuspendLayout();
            grpBusqueda.SuspendLayout();
            grpDatosActuales.SuspendLayout();
            grpHistorico.SuspendLayout();
            grpAnomalia.SuspendLayout();
            tabAnalisis.SuspendLayout();
            grpFiltrosGlobal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHistorico).BeginInit();
            grpRanking.SuspendLayout();
            tabFavoritos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvFavoritos).BeginInit();
            grpAgregarFav.SuspendLayout();
            tabConfig.SuspendLayout();
            grpConexion.SuspendLayout();
            grpArchivos.SuspendLayout();
            grpPreferencias.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudUmbral).BeginInit();
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
            tabControl.Location = new Point(0, 0);
            tabControl.Margin = new Padding(3, 4, 3, 4);
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(1029, 867);
            tabControl.TabIndex = 0;
            // 
            // tabConsulta
            // 
            tabConsulta.Controls.Add(grpBusqueda);
            tabConsulta.Controls.Add(grpDatosActuales);
            tabConsulta.Controls.Add(grpHistorico);
            tabConsulta.Controls.Add(grpAnomalia);
            tabConsulta.Location = new Point(4, 29);
            tabConsulta.Margin = new Padding(3, 4, 3, 4);
            tabConsulta.Name = "tabConsulta";
            tabConsulta.Padding = new Padding(9, 11, 9, 11);
            tabConsulta.Size = new Size(1021, 834);
            tabConsulta.TabIndex = 0;
            tabConsulta.Text = "Consulta Individual";
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
            grpBusqueda.Controls.Add(lblHintMunicipio);
            grpBusqueda.Location = new Point(9, 11);
            grpBusqueda.Margin = new Padding(3, 4, 3, 4);
            grpBusqueda.Name = "grpBusqueda";
            grpBusqueda.Padding = new Padding(3, 4, 3, 4);
            grpBusqueda.Size = new Size(1001, 107);
            grpBusqueda.TabIndex = 0;
            grpBusqueda.TabStop = false;
            grpBusqueda.Text = "Parámetros de consulta";
            // 
            // lblEstado
            // 
            lblEstado.AutoSize = true;
            lblEstado.Location = new Point(11, 32);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(72, 20);
            lblEstado.TabIndex = 0;
            lblEstado.Text = "1. Estado:";
            // 
            // cmbEstado
            // 
            cmbEstado.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbEstado.Location = new Point(11, 56);
            cmbEstado.Margin = new Padding(3, 4, 3, 4);
            cmbEstado.Name = "cmbEstado";
            cmbEstado.Size = new Size(182, 28);
            cmbEstado.TabIndex = 0;
            cmbEstado.SelectedIndexChanged += cmbEstado_SelectedIndexChanged_1;
            // 
            // lblMunicipio
            // 
            lblMunicipio.AutoSize = true;
            lblMunicipio.Location = new Point(208, 32);
            lblMunicipio.Name = "lblMunicipio";
            lblMunicipio.Size = new Size(93, 20);
            lblMunicipio.TabIndex = 1;
            lblMunicipio.Text = "2. Municipio:";
            // 
            // cmbMunicipio
            // 
            cmbMunicipio.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbMunicipio.Enabled = false;
            cmbMunicipio.Location = new Point(208, 56);
            cmbMunicipio.Margin = new Padding(3, 4, 3, 4);
            cmbMunicipio.Name = "cmbMunicipio";
            cmbMunicipio.Size = new Size(205, 28);
            cmbMunicipio.TabIndex = 1;
            cmbMunicipio.SelectedIndexChanged += cmbMunicipio_SelectedIndexChanged_1;
            // 
            // lblAnio
            // 
            lblAnio.AutoSize = true;
            lblAnio.Location = new Point(446, 32);
            lblAnio.Name = "lblAnio";
            lblAnio.Size = new Size(39, 20);
            lblAnio.TabIndex = 2;
            lblAnio.Text = "Año:";
            // 
            // cmbAnio
            // 
            cmbAnio.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbAnio.Location = new Point(446, 56);
            cmbAnio.Margin = new Padding(3, 4, 3, 4);
            cmbAnio.Name = "cmbAnio";
            cmbAnio.Size = new Size(91, 28);
            cmbAnio.TabIndex = 2;
            // 
            // lblEstacion
            // 
            lblEstacion.AutoSize = true;
            lblEstacion.Location = new Point(551, 32);
            lblEstacion.Name = "lblEstacion";
            lblEstacion.Size = new Size(67, 20);
            lblEstacion.TabIndex = 3;
            lblEstacion.Text = "Estación:";
            // 
            // cmbEstacion
            // 
            cmbEstacion.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbEstacion.Items.AddRange(new object[] { "Verano", "Invierno", "Primavera", "Otoño" });
            cmbEstacion.Location = new Point(551, 56);
            cmbEstacion.Margin = new Padding(3, 4, 3, 4);
            cmbEstacion.Name = "cmbEstacion";
            cmbEstacion.Size = new Size(125, 28);
            cmbEstacion.TabIndex = 3;
            // 
            // btnConsultar
            // 
            btnConsultar.Enabled = false;
            btnConsultar.Location = new Point(697, 53);
            btnConsultar.Margin = new Padding(3, 4, 3, 4);
            btnConsultar.Name = "btnConsultar";
            btnConsultar.Size = new Size(103, 35);
            btnConsultar.TabIndex = 4;
            btnConsultar.Text = "Consultar";
            btnConsultar.UseVisualStyleBackColor = true;
            btnConsultar.Click += btnConsultar_Click_1;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(807, 53);
            btnLimpiar.Margin = new Padding(3, 4, 3, 4);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(91, 35);
            btnLimpiar.TabIndex = 5;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // lblHintMunicipio
            // 
            lblHintMunicipio.AutoSize = true;
            lblHintMunicipio.Font = new Font("Segoe UI", 8F, FontStyle.Italic);
            lblHintMunicipio.ForeColor = Color.Gray;
            lblHintMunicipio.Location = new Point(208, 91);
            lblHintMunicipio.Name = "lblHintMunicipio";
            lblHintMunicipio.Size = new Size(208, 19);
            lblHintMunicipio.TabIndex = 6;
            lblHintMunicipio.Text = "← Primero selecciona un estado";
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
            grpDatosActuales.Location = new Point(9, 131);
            grpDatosActuales.Margin = new Padding(3, 4, 3, 4);
            grpDatosActuales.Name = "grpDatosActuales";
            grpDatosActuales.Padding = new Padding(3, 4, 3, 4);
            grpDatosActuales.Size = new Size(491, 293);
            grpDatosActuales.TabIndex = 1;
            grpDatosActuales.TabStop = false;
            grpDatosActuales.Text = "Datos actuales";
            // 
            // lblFuenteAPI
            // 
            lblFuenteAPI.AutoSize = true;
            lblFuenteAPI.Font = new Font("Segoe UI", 8F);
            lblFuenteAPI.ForeColor = Color.SteelBlue;
            lblFuenteAPI.Location = new Point(183, 27);
            lblFuenteAPI.Name = "lblFuenteAPI";
            lblFuenteAPI.Size = new Size(163, 19);
            lblFuenteAPI.TabIndex = 0;
            lblFuenteAPI.Text = "Fuente: Open-Meteo API";
            // 
            // lblTempActualVal
            // 
            lblTempActualVal.AutoSize = true;
            lblTempActualVal.Font = new Font("Segoe UI", 28F);
            lblTempActualVal.ForeColor = Color.Firebrick;
            lblTempActualVal.Location = new Point(171, 51);
            lblTempActualVal.Name = "lblTempActualVal";
            lblTempActualVal.Size = new Size(74, 62);
            lblTempActualVal.TabIndex = 1;
            lblTempActualVal.Text = "—";
            // 
            // lblTempActualSub
            // 
            lblTempActualSub.AutoSize = true;
            lblTempActualSub.Font = new Font("Segoe UI", 8F);
            lblTempActualSub.ForeColor = Color.Gray;
            lblTempActualSub.Location = new Point(177, 109);
            lblTempActualSub.Name = "lblTempActualSub";
            lblTempActualSub.Size = new Size(170, 19);
            lblTempActualSub.TabIndex = 2;
            lblTempActualSub.Text = "Temperatura actual del día";
            // 
            // lblMunicipioKey
            // 
            lblMunicipioKey.AutoSize = true;
            lblMunicipioKey.Location = new Point(11, 144);
            lblMunicipioKey.Name = "lblMunicipioKey";
            lblMunicipioKey.Size = new Size(78, 20);
            lblMunicipioKey.TabIndex = 3;
            lblMunicipioKey.Text = "Municipio:";
            // 
            // lblMunicipioVal
            // 
            lblMunicipioVal.AutoSize = true;
            lblMunicipioVal.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblMunicipioVal.Location = new Point(251, 144);
            lblMunicipioVal.Name = "lblMunicipioVal";
            lblMunicipioVal.Size = new Size(24, 20);
            lblMunicipioVal.TabIndex = 4;
            lblMunicipioVal.Text = "—";
            // 
            // lblEstadoActKey
            // 
            lblEstadoActKey.AutoSize = true;
            lblEstadoActKey.Location = new Point(11, 176);
            lblEstadoActKey.Name = "lblEstadoActKey";
            lblEstadoActKey.Size = new Size(57, 20);
            lblEstadoActKey.TabIndex = 5;
            lblEstadoActKey.Text = "Estado:";
            // 
            // lblEstadoActVal
            // 
            lblEstadoActVal.AutoSize = true;
            lblEstadoActVal.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblEstadoActVal.Location = new Point(251, 176);
            lblEstadoActVal.Name = "lblEstadoActVal";
            lblEstadoActVal.Size = new Size(24, 20);
            lblEstadoActVal.TabIndex = 6;
            lblEstadoActVal.Text = "—";
            // 
            // lblMinActKey
            // 
            lblMinActKey.AutoSize = true;
            lblMinActKey.Location = new Point(11, 208);
            lblMinActKey.Name = "lblMinActKey";
            lblMinActKey.Size = new Size(112, 20);
            lblMinActKey.TabIndex = 7;
            lblMinActKey.Text = "Mínima del día:";
            // 
            // lblMinActVal
            // 
            lblMinActVal.AutoSize = true;
            lblMinActVal.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblMinActVal.Location = new Point(251, 208);
            lblMinActVal.Name = "lblMinActVal";
            lblMinActVal.Size = new Size(24, 20);
            lblMinActVal.TabIndex = 8;
            lblMinActVal.Text = "—";
            // 
            // lblMaxActKey
            // 
            lblMaxActKey.AutoSize = true;
            lblMaxActKey.Location = new Point(11, 240);
            lblMaxActKey.Name = "lblMaxActKey";
            lblMaxActKey.Size = new Size(115, 20);
            lblMaxActKey.TabIndex = 9;
            lblMaxActKey.Text = "Máxima del día:";
            // 
            // lblMaxActVal
            // 
            lblMaxActVal.AutoSize = true;
            lblMaxActVal.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblMaxActVal.Location = new Point(251, 240);
            lblMaxActVal.Name = "lblMaxActVal";
            lblMaxActVal.Size = new Size(24, 20);
            lblMaxActVal.TabIndex = 10;
            lblMaxActVal.Text = "—";
            // 
            // lblCoordsVal
            // 
            lblCoordsVal.AutoSize = true;
            lblCoordsVal.Font = new Font("Segoe UI", 7.5F);
            lblCoordsVal.ForeColor = Color.Gray;
            lblCoordsVal.Location = new Point(11, 267);
            lblCoordsVal.Name = "lblCoordsVal";
            lblCoordsVal.Size = new Size(97, 17);
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
            grpHistorico.Location = new Point(510, 131);
            grpHistorico.Margin = new Padding(3, 4, 3, 4);
            grpHistorico.Name = "grpHistorico";
            grpHistorico.Padding = new Padding(3, 4, 3, 4);
            grpHistorico.Size = new Size(501, 293);
            grpHistorico.TabIndex = 2;
            grpHistorico.TabStop = false;
            grpHistorico.Text = "Promedio histórico";
            // 
            // lblFuenteCSV
            // 
            lblFuenteCSV.AutoSize = true;
            lblFuenteCSV.Font = new Font("Segoe UI", 8F);
            lblFuenteCSV.ForeColor = Color.SeaGreen;
            lblFuenteCSV.Location = new Point(197, 27);
            lblFuenteCSV.Name = "lblFuenteCSV";
            lblFuenteCSV.Size = new Size(107, 19);
            lblFuenteCSV.TabIndex = 0;
            lblFuenteCSV.Text = "Fuente: data.csv";
            // 
            // lblTempHistVal
            // 
            lblTempHistVal.AutoSize = true;
            lblTempHistVal.Font = new Font("Segoe UI", 28F);
            lblTempHistVal.ForeColor = Color.SteelBlue;
            lblTempHistVal.Location = new Point(181, 51);
            lblTempHistVal.Name = "lblTempHistVal";
            lblTempHistVal.Size = new Size(74, 62);
            lblTempHistVal.TabIndex = 1;
            lblTempHistVal.Text = "—";
            // 
            // lblTempHistSub
            // 
            lblTempHistSub.AutoSize = true;
            lblTempHistSub.Font = new Font("Segoe UI", 8F);
            lblTempHistSub.ForeColor = Color.Gray;
            lblTempHistSub.Location = new Point(169, 109);
            lblTempHistSub.Name = "lblTempHistSub";
            lblTempHistSub.Size = new Size(191, 19);
            lblTempHistSub.TabIndex = 2;
            lblTempHistSub.Text = "Promedio histórico del estado";
            // 
            // lblEstadoHistKey
            // 
            lblEstadoHistKey.AutoSize = true;
            lblEstadoHistKey.Location = new Point(11, 144);
            lblEstadoHistKey.Name = "lblEstadoHistKey";
            lblEstadoHistKey.Size = new Size(126, 20);
            lblEstadoHistKey.TabIndex = 3;
            lblEstadoHistKey.Text = "Estado analizado:";
            // 
            // lblEstadoHistVal
            // 
            lblEstadoHistVal.AutoSize = true;
            lblEstadoHistVal.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblEstadoHistVal.Location = new Point(251, 144);
            lblEstadoHistVal.Name = "lblEstadoHistVal";
            lblEstadoHistVal.Size = new Size(24, 20);
            lblEstadoHistVal.TabIndex = 4;
            lblEstadoHistVal.Text = "—";
            // 
            // lblFiltroKey
            // 
            lblFiltroKey.AutoSize = true;
            lblFiltroKey.Location = new Point(11, 176);
            lblFiltroKey.Name = "lblFiltroKey";
            lblFiltroKey.Size = new Size(108, 20);
            lblFiltroKey.TabIndex = 5;
            lblFiltroKey.Text = "Estación / Año:";
            // 
            // lblFiltroVal
            // 
            lblFiltroVal.AutoSize = true;
            lblFiltroVal.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblFiltroVal.Location = new Point(251, 176);
            lblFiltroVal.Name = "lblFiltroVal";
            lblFiltroVal.Size = new Size(24, 20);
            lblFiltroVal.TabIndex = 6;
            lblFiltroVal.Text = "—";
            // 
            // lblMinHistKey
            // 
            lblMinHistKey.AutoSize = true;
            lblMinHistKey.Location = new Point(11, 208);
            lblMinHistKey.Name = "lblMinHistKey";
            lblMinHistKey.Size = new Size(122, 20);
            lblMinHistKey.TabIndex = 7;
            lblMinHistKey.Text = "Mínima histórica:";
            // 
            // lblMinHistVal
            // 
            lblMinHistVal.AutoSize = true;
            lblMinHistVal.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblMinHistVal.Location = new Point(251, 208);
            lblMinHistVal.Name = "lblMinHistVal";
            lblMinHistVal.Size = new Size(24, 20);
            lblMinHistVal.TabIndex = 8;
            lblMinHistVal.Text = "—";
            // 
            // lblMaxHistKey
            // 
            lblMaxHistKey.AutoSize = true;
            lblMaxHistKey.Location = new Point(11, 240);
            lblMaxHistKey.Name = "lblMaxHistKey";
            lblMaxHistKey.Size = new Size(125, 20);
            lblMaxHistKey.TabIndex = 9;
            lblMaxHistKey.Text = "Máxima histórica:";
            // 
            // lblMaxHistVal
            // 
            lblMaxHistVal.AutoSize = true;
            lblMaxHistVal.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblMaxHistVal.Location = new Point(251, 240);
            lblMaxHistVal.Name = "lblMaxHistVal";
            lblMaxHistVal.Size = new Size(24, 20);
            lblMaxHistVal.TabIndex = 10;
            lblMaxHistVal.Text = "—";
            // 
            // lblRegistrosVal
            // 
            lblRegistrosVal.AutoSize = true;
            lblRegistrosVal.Font = new Font("Segoe UI", 7.5F);
            lblRegistrosVal.ForeColor = Color.Gray;
            lblRegistrosVal.Location = new Point(11, 267);
            lblRegistrosVal.Name = "lblRegistrosVal";
            lblRegistrosVal.Size = new Size(191, 17);
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
            grpAnomalia.Location = new Point(9, 437);
            grpAnomalia.Margin = new Padding(3, 4, 3, 4);
            grpAnomalia.Name = "grpAnomalia";
            grpAnomalia.Padding = new Padding(3, 4, 3, 4);
            grpAnomalia.Size = new Size(1001, 120);
            grpAnomalia.TabIndex = 3;
            grpAnomalia.TabStop = false;
            grpAnomalia.Text = "Detección de anomalía";
            // 
            // lblDesviacionKey
            // 
            lblDesviacionKey.AutoSize = true;
            lblDesviacionKey.Location = new Point(11, 37);
            lblDesviacionKey.Name = "lblDesviacionKey";
            lblDesviacionKey.Size = new Size(155, 20);
            lblDesviacionKey.TabIndex = 0;
            lblDesviacionKey.Text = "Desviación detectada:";
            // 
            // lblDesviacionVal
            // 
            lblDesviacionVal.AutoSize = true;
            lblDesviacionVal.Font = new Font("Segoe UI", 22F);
            lblDesviacionVal.Location = new Point(11, 59);
            lblDesviacionVal.Name = "lblDesviacionVal";
            lblDesviacionVal.Size = new Size(59, 50);
            lblDesviacionVal.TabIndex = 1;
            lblDesviacionVal.Text = "—";
            // 
            // lblDescAnomalia
            // 
            lblDescAnomalia.AutoSize = true;
            lblDescAnomalia.Font = new Font("Segoe UI", 8F, FontStyle.Italic);
            lblDescAnomalia.ForeColor = Color.Gray;
            lblDescAnomalia.Location = new Point(171, 75);
            lblDescAnomalia.Name = "lblDescAnomalia";
            lblDescAnomalia.Size = new Size(23, 19);
            lblDescAnomalia.TabIndex = 2;
            lblDescAnomalia.Text = "—";
            // 
            // lblNivelKey
            // 
            lblNivelKey.AutoSize = true;
            lblNivelKey.Location = new Point(503, 37);
            lblNivelKey.Name = "lblNivelKey";
            lblNivelKey.Size = new Size(109, 20);
            lblNivelKey.TabIndex = 3;
            lblNivelKey.Text = "Nivel de alerta:";
            // 
            // pnlSemaforoVerde
            // 
            pnlSemaforoVerde.BackColor = Color.LightGray;
            pnlSemaforoVerde.Location = new Point(503, 67);
            pnlSemaforoVerde.Margin = new Padding(3, 4, 3, 4);
            pnlSemaforoVerde.Name = "pnlSemaforoVerde";
            pnlSemaforoVerde.Size = new Size(21, 24);
            pnlSemaforoVerde.TabIndex = 4;
            // 
            // pnlSemaforoAmarillo
            // 
            pnlSemaforoAmarillo.BackColor = Color.LightGray;
            pnlSemaforoAmarillo.Location = new Point(530, 67);
            pnlSemaforoAmarillo.Margin = new Padding(3, 4, 3, 4);
            pnlSemaforoAmarillo.Name = "pnlSemaforoAmarillo";
            pnlSemaforoAmarillo.Size = new Size(21, 24);
            pnlSemaforoAmarillo.TabIndex = 5;
            // 
            // pnlSemaforoRojo
            // 
            pnlSemaforoRojo.BackColor = Color.LightGray;
            pnlSemaforoRojo.Location = new Point(558, 67);
            pnlSemaforoRojo.Margin = new Padding(3, 4, 3, 4);
            pnlSemaforoRojo.Name = "pnlSemaforoRojo";
            pnlSemaforoRojo.Size = new Size(21, 24);
            pnlSemaforoRojo.TabIndex = 6;
            // 
            // lblSemaforoTexto
            // 
            lblSemaforoTexto.AutoSize = true;
            lblSemaforoTexto.Location = new Point(587, 71);
            lblSemaforoTexto.Name = "lblSemaforoTexto";
            lblSemaforoTexto.Size = new Size(24, 20);
            lblSemaforoTexto.TabIndex = 7;
            lblSemaforoTexto.Text = "—";
            // 
            // btnGuardarAlerta
            // 
            btnGuardarAlerta.Enabled = false;
            btnGuardarAlerta.Location = new Point(846, 64);
            btnGuardarAlerta.Margin = new Padding(3, 4, 3, 4);
            btnGuardarAlerta.Name = "btnGuardarAlerta";
            btnGuardarAlerta.Size = new Size(144, 35);
            btnGuardarAlerta.TabIndex = 8;
            btnGuardarAlerta.Text = "Guardar alerta en BD";
            btnGuardarAlerta.UseVisualStyleBackColor = true;
            // 
            // tabAnalisis
            // 
            tabAnalisis.Controls.Add(grpFiltrosGlobal);
            tabAnalisis.Controls.Add(dgvHistorico);
            tabAnalisis.Controls.Add(grpRanking);
            tabAnalisis.Location = new Point(4, 29);
            tabAnalisis.Margin = new Padding(3, 4, 3, 4);
            tabAnalisis.Name = "tabAnalisis";
            tabAnalisis.Padding = new Padding(9, 11, 9, 11);
            tabAnalisis.Size = new Size(1021, 834);
            tabAnalisis.TabIndex = 1;
            tabAnalisis.Text = "Análisis Global";
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
            grpFiltrosGlobal.Location = new Point(9, 11);
            grpFiltrosGlobal.Margin = new Padding(3, 4, 3, 4);
            grpFiltrosGlobal.Name = "grpFiltrosGlobal";
            grpFiltrosGlobal.Padding = new Padding(3, 4, 3, 4);
            grpFiltrosGlobal.Size = new Size(1001, 80);
            grpFiltrosGlobal.TabIndex = 0;
            grpFiltrosGlobal.TabStop = false;
            grpFiltrosGlobal.Text = "Filtros";
            // 
            // lblFiltroAnio
            // 
            lblFiltroAnio.AutoSize = true;
            lblFiltroAnio.Location = new Point(11, 32);
            lblFiltroAnio.Name = "lblFiltroAnio";
            lblFiltroAnio.Size = new Size(39, 20);
            lblFiltroAnio.TabIndex = 0;
            lblFiltroAnio.Text = "Año:";
            // 
            // cmbFiltroAnio
            // 
            cmbFiltroAnio.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbFiltroAnio.Location = new Point(46, 27);
            cmbFiltroAnio.Margin = new Padding(3, 4, 3, 4);
            cmbFiltroAnio.Name = "cmbFiltroAnio";
            cmbFiltroAnio.Size = new Size(91, 28);
            cmbFiltroAnio.TabIndex = 1;
            // 
            // lblFiltroEstacion
            // 
            lblFiltroEstacion.AutoSize = true;
            lblFiltroEstacion.Location = new Point(151, 32);
            lblFiltroEstacion.Name = "lblFiltroEstacion";
            lblFiltroEstacion.Size = new Size(67, 20);
            lblFiltroEstacion.TabIndex = 2;
            lblFiltroEstacion.Text = "Estación:";
            // 
            // cmbFiltroEstacion
            // 
            cmbFiltroEstacion.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbFiltroEstacion.Items.AddRange(new object[] { "Todas", "Verano", "Invierno", "Primavera", "Otoño" });
            cmbFiltroEstacion.Location = new Point(213, 27);
            cmbFiltroEstacion.Margin = new Padding(3, 4, 3, 4);
            cmbFiltroEstacion.Name = "cmbFiltroEstacion";
            cmbFiltroEstacion.Size = new Size(125, 28);
            cmbFiltroEstacion.TabIndex = 3;
            // 
            // lblBuscarEstado
            // 
            lblBuscarEstado.AutoSize = true;
            lblBuscarEstado.Location = new Point(354, 32);
            lblBuscarEstado.Name = "lblBuscarEstado";
            lblBuscarEstado.Size = new Size(104, 20);
            lblBuscarEstado.TabIndex = 4;
            lblBuscarEstado.Text = "Buscar estado:";
            // 
            // txtBuscarEstado
            // 
            txtBuscarEstado.Location = new Point(455, 27);
            txtBuscarEstado.Margin = new Padding(3, 4, 3, 4);
            txtBuscarEstado.Name = "txtBuscarEstado";
            txtBuscarEstado.Size = new Size(182, 27);
            txtBuscarEstado.TabIndex = 5;
            // 
            // btnFiltrar
            // 
            btnFiltrar.Location = new Point(651, 25);
            btnFiltrar.Margin = new Padding(3, 4, 3, 4);
            btnFiltrar.Name = "btnFiltrar";
            btnFiltrar.Size = new Size(91, 35);
            btnFiltrar.TabIndex = 6;
            btnFiltrar.Text = "Filtrar";
            btnFiltrar.UseVisualStyleBackColor = true;
            // 
            // btnLimpiarFiltro
            // 
            btnLimpiarFiltro.Location = new Point(750, 25);
            btnLimpiarFiltro.Margin = new Padding(3, 4, 3, 4);
            btnLimpiarFiltro.Name = "btnLimpiarFiltro";
            btnLimpiarFiltro.Size = new Size(91, 35);
            btnLimpiarFiltro.TabIndex = 7;
            btnLimpiarFiltro.Text = "Limpiar";
            btnLimpiarFiltro.UseVisualStyleBackColor = true;
            // 
            // dgvHistorico
            // 
            dgvHistorico.AllowUserToAddRows = false;
            dgvHistorico.AllowUserToDeleteRows = false;
            dgvHistorico.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvHistorico.ColumnHeadersHeight = 29;
            dgvHistorico.Location = new Point(9, 101);
            dgvHistorico.Margin = new Padding(3, 4, 3, 4);
            dgvHistorico.Name = "dgvHistorico";
            dgvHistorico.ReadOnly = true;
            dgvHistorico.RowHeadersWidth = 51;
            dgvHistorico.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvHistorico.Size = new Size(1001, 453);
            dgvHistorico.TabIndex = 1;
            // 
            // grpRanking
            // 
            grpRanking.Controls.Add(lblRankingCaliente);
            grpRanking.Controls.Add(lstCalientes);
            grpRanking.Controls.Add(lblRankingFrio);
            grpRanking.Controls.Add(lstFrios);
            grpRanking.Location = new Point(9, 565);
            grpRanking.Margin = new Padding(3, 4, 3, 4);
            grpRanking.Name = "grpRanking";
            grpRanking.Padding = new Padding(3, 4, 3, 4);
            grpRanking.Size = new Size(1001, 208);
            grpRanking.TabIndex = 2;
            grpRanking.TabStop = false;
            grpRanking.Text = "Ranking (derivado del filtro activo)";
            // 
            // lblRankingCaliente
            // 
            lblRankingCaliente.AutoSize = true;
            lblRankingCaliente.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblRankingCaliente.ForeColor = Color.Firebrick;
            lblRankingCaliente.Location = new Point(11, 29);
            lblRankingCaliente.Name = "lblRankingCaliente";
            lblRankingCaliente.Size = new Size(165, 20);
            lblRankingCaliente.TabIndex = 0;
            lblRankingCaliente.Text = "Top 5 — más calientes";
            // 
            // lstCalientes
            // 
            lstCalientes.Location = new Point(11, 56);
            lstCalientes.Margin = new Padding(3, 4, 3, 4);
            lstCalientes.Name = "lstCalientes";
            lstCalientes.Size = new Size(477, 124);
            lstCalientes.TabIndex = 1;
            // 
            // lblRankingFrio
            // 
            lblRankingFrio.AutoSize = true;
            lblRankingFrio.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblRankingFrio.ForeColor = Color.SteelBlue;
            lblRankingFrio.Location = new Point(512, 29);
            lblRankingFrio.Name = "lblRankingFrio";
            lblRankingFrio.Size = new Size(136, 20);
            lblRankingFrio.TabIndex = 2;
            lblRankingFrio.Text = "Top 5 — más fríos";
            // 
            // lstFrios
            // 
            lstFrios.Location = new Point(512, 56);
            lstFrios.Margin = new Padding(3, 4, 3, 4);
            lstFrios.Name = "lstFrios";
            lstFrios.Size = new Size(477, 124);
            lstFrios.TabIndex = 3;
            // 
            // tabFavoritos
            // 
            tabFavoritos.Controls.Add(dgvFavoritos);
            tabFavoritos.Controls.Add(grpAgregarFav);
            tabFavoritos.Controls.Add(btnEliminarFav);
            tabFavoritos.Location = new Point(4, 29);
            tabFavoritos.Margin = new Padding(3, 4, 3, 4);
            tabFavoritos.Name = "tabFavoritos";
            tabFavoritos.Padding = new Padding(9, 11, 9, 11);
            tabFavoritos.Size = new Size(1021, 834);
            tabFavoritos.TabIndex = 2;
            tabFavoritos.Text = "Favoritos";
            // 
            // dgvFavoritos
            // 
            dgvFavoritos.AllowUserToAddRows = false;
            dgvFavoritos.AllowUserToDeleteRows = false;
            dgvFavoritos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvFavoritos.ColumnHeadersHeight = 29;
            dgvFavoritos.Location = new Point(9, 11);
            dgvFavoritos.Margin = new Padding(3, 4, 3, 4);
            dgvFavoritos.Name = "dgvFavoritos";
            dgvFavoritos.ReadOnly = true;
            dgvFavoritos.RowHeadersWidth = 51;
            dgvFavoritos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvFavoritos.Size = new Size(1001, 613);
            dgvFavoritos.TabIndex = 0;
            // 
            // grpAgregarFav
            // 
            grpAgregarFav.Controls.Add(lblNuevoFavEstado);
            grpAgregarFav.Controls.Add(cmbNuevoFavEstado);
            grpAgregarFav.Controls.Add(lblNuevoFavMun);
            grpAgregarFav.Controls.Add(cmbNuevoFavMun);
            grpAgregarFav.Controls.Add(btnAgregarFav);
            grpAgregarFav.Location = new Point(9, 680);
            grpAgregarFav.Margin = new Padding(3, 4, 3, 4);
            grpAgregarFav.Name = "grpAgregarFav";
            grpAgregarFav.Padding = new Padding(3, 4, 3, 4);
            grpAgregarFav.Size = new Size(1001, 80);
            grpAgregarFav.TabIndex = 1;
            grpAgregarFav.TabStop = false;
            grpAgregarFav.Text = "Agregar municipio a favoritos";
            // 
            // lblNuevoFavEstado
            // 
            lblNuevoFavEstado.AutoSize = true;
            lblNuevoFavEstado.Location = new Point(11, 35);
            lblNuevoFavEstado.Name = "lblNuevoFavEstado";
            lblNuevoFavEstado.Size = new Size(57, 20);
            lblNuevoFavEstado.TabIndex = 0;
            lblNuevoFavEstado.Text = "Estado:";
            // 
            // cmbNuevoFavEstado
            // 
            cmbNuevoFavEstado.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbNuevoFavEstado.Location = new Point(69, 29);
            cmbNuevoFavEstado.Margin = new Padding(3, 4, 3, 4);
            cmbNuevoFavEstado.Name = "cmbNuevoFavEstado";
            cmbNuevoFavEstado.Size = new Size(182, 28);
            cmbNuevoFavEstado.TabIndex = 1;
            // 
            // lblNuevoFavMun
            // 
            lblNuevoFavMun.AutoSize = true;
            lblNuevoFavMun.Location = new Point(267, 35);
            lblNuevoFavMun.Name = "lblNuevoFavMun";
            lblNuevoFavMun.Size = new Size(78, 20);
            lblNuevoFavMun.TabIndex = 2;
            lblNuevoFavMun.Text = "Municipio:";
            // 
            // cmbNuevoFavMun
            // 
            cmbNuevoFavMun.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbNuevoFavMun.Enabled = false;
            cmbNuevoFavMun.Location = new Point(341, 29);
            cmbNuevoFavMun.Margin = new Padding(3, 4, 3, 4);
            cmbNuevoFavMun.Name = "cmbNuevoFavMun";
            cmbNuevoFavMun.Size = new Size(205, 28);
            cmbNuevoFavMun.TabIndex = 3;
            // 
            // btnAgregarFav
            // 
            btnAgregarFav.Location = new Point(562, 28);
            btnAgregarFav.Margin = new Padding(3, 4, 3, 4);
            btnAgregarFav.Name = "btnAgregarFav";
            btnAgregarFav.Size = new Size(114, 35);
            btnAgregarFav.TabIndex = 4;
            btnAgregarFav.Text = "Agregar";
            btnAgregarFav.UseVisualStyleBackColor = true;
            // 
            // btnEliminarFav
            // 
            btnEliminarFav.Location = new Point(9, 635);
            btnEliminarFav.Margin = new Padding(3, 4, 3, 4);
            btnEliminarFav.Name = "btnEliminarFav";
            btnEliminarFav.Size = new Size(137, 35);
            btnEliminarFav.TabIndex = 2;
            btnEliminarFav.Text = "Eliminar seleccionado";
            btnEliminarFav.UseVisualStyleBackColor = true;
            // 
            // tabConfig
            // 
            tabConfig.Controls.Add(grpConexion);
            tabConfig.Controls.Add(grpArchivos);
            tabConfig.Controls.Add(grpPreferencias);
            tabConfig.Controls.Add(btnGuardarConfig);
            tabConfig.Location = new Point(4, 29);
            tabConfig.Margin = new Padding(3, 4, 3, 4);
            tabConfig.Name = "tabConfig";
            tabConfig.Padding = new Padding(9, 11, 9, 11);
            tabConfig.Size = new Size(1021, 834);
            tabConfig.TabIndex = 3;
            tabConfig.Text = "Configuración";
            // 
            // grpConexion
            // 
            grpConexion.Controls.Add(lblCadenaConexion);
            grpConexion.Controls.Add(txtCadenaConexion);
            grpConexion.Controls.Add(btnProbarConexion);
            grpConexion.Controls.Add(lblEstadoConexion);
            grpConexion.Location = new Point(9, 11);
            grpConexion.Margin = new Padding(3, 4, 3, 4);
            grpConexion.Name = "grpConexion";
            grpConexion.Padding = new Padding(3, 4, 3, 4);
            grpConexion.Size = new Size(1001, 107);
            grpConexion.TabIndex = 0;
            grpConexion.TabStop = false;
            grpConexion.Text = "Base de datos — SQL Server / MariaDB";
            // 
            // lblCadenaConexion
            // 
            lblCadenaConexion.AutoSize = true;
            lblCadenaConexion.Location = new Point(11, 32);
            lblCadenaConexion.Name = "lblCadenaConexion";
            lblCadenaConexion.Size = new Size(147, 20);
            lblCadenaConexion.TabIndex = 0;
            lblCadenaConexion.Text = "Cadena de conexión:";
            // 
            // txtCadenaConexion
            // 
            txtCadenaConexion.Location = new Point(11, 56);
            txtCadenaConexion.Margin = new Padding(3, 4, 3, 4);
            txtCadenaConexion.Name = "txtCadenaConexion";
            txtCadenaConexion.Size = new Size(731, 27);
            txtCadenaConexion.TabIndex = 1;
            // 
            // btnProbarConexion
            // 
            btnProbarConexion.Location = new Point(754, 55);
            btnProbarConexion.Margin = new Padding(3, 4, 3, 4);
            btnProbarConexion.Name = "btnProbarConexion";
            btnProbarConexion.Size = new Size(126, 35);
            btnProbarConexion.TabIndex = 2;
            btnProbarConexion.Text = "Probar conexión";
            btnProbarConexion.UseVisualStyleBackColor = true;
            // 
            // lblEstadoConexion
            // 
            lblEstadoConexion.AutoSize = true;
            lblEstadoConexion.Font = new Font("Segoe UI", 8F, FontStyle.Italic);
            lblEstadoConexion.ForeColor = Color.Gray;
            lblEstadoConexion.Location = new Point(891, 61);
            lblEstadoConexion.Name = "lblEstadoConexion";
            lblEstadoConexion.Size = new Size(23, 19);
            lblEstadoConexion.TabIndex = 3;
            lblEstadoConexion.Text = "—";
            // 
            // grpArchivos
            // 
            grpArchivos.Controls.Add(lblRutaCSV);
            grpArchivos.Controls.Add(txtRutaCSV);
            grpArchivos.Controls.Add(btnExplorarCSV);
            grpArchivos.Controls.Add(lblRutaJSON);
            grpArchivos.Controls.Add(txtRutaJSON);
            grpArchivos.Controls.Add(btnExplorarJSON);
            grpArchivos.Location = new Point(9, 133);
            grpArchivos.Margin = new Padding(3, 4, 3, 4);
            grpArchivos.Name = "grpArchivos";
            grpArchivos.Padding = new Padding(3, 4, 3, 4);
            grpArchivos.Size = new Size(1001, 133);
            grpArchivos.TabIndex = 1;
            grpArchivos.TabStop = false;
            grpArchivos.Text = "Archivos de datos";
            // 
            // lblRutaCSV
            // 
            lblRutaCSV.AutoSize = true;
            lblRutaCSV.Location = new Point(11, 32);
            lblRutaCSV.Name = "lblRutaCSV";
            lblRutaCSV.Size = new Size(72, 20);
            lblRutaCSV.TabIndex = 0;
            lblRutaCSV.Text = "Ruta CSV:";
            // 
            // txtRutaCSV
            // 
            txtRutaCSV.Location = new Point(11, 53);
            txtRutaCSV.Margin = new Padding(3, 4, 3, 4);
            txtRutaCSV.Name = "txtRutaCSV";
            txtRutaCSV.Size = new Size(845, 27);
            txtRutaCSV.TabIndex = 1;
            txtRutaCSV.Text = "Data\\data.csv";
            // 
            // btnExplorarCSV
            // 
            btnExplorarCSV.Location = new Point(866, 52);
            btnExplorarCSV.Margin = new Padding(3, 4, 3, 4);
            btnExplorarCSV.Name = "btnExplorarCSV";
            btnExplorarCSV.Size = new Size(114, 35);
            btnExplorarCSV.TabIndex = 2;
            btnExplorarCSV.Text = "Explorar...";
            btnExplorarCSV.UseVisualStyleBackColor = true;
            // 
            // lblRutaJSON
            // 
            lblRutaJSON.AutoSize = true;
            lblRutaJSON.Location = new Point(11, 93);
            lblRutaJSON.Name = "lblRutaJSON";
            lblRutaJSON.Size = new Size(81, 20);
            lblRutaJSON.TabIndex = 3;
            lblRutaJSON.Text = "Ruta JSON:";
            // 
            // txtRutaJSON
            // 
            txtRutaJSON.Location = new Point(11, 91);
            txtRutaJSON.Margin = new Padding(3, 4, 3, 4);
            txtRutaJSON.Name = "txtRutaJSON";
            txtRutaJSON.Size = new Size(845, 27);
            txtRutaJSON.TabIndex = 4;
            txtRutaJSON.Text = "Data\\municipios_mx.json";
            // 
            // btnExplorarJSON
            // 
            btnExplorarJSON.Location = new Point(866, 89);
            btnExplorarJSON.Margin = new Padding(3, 4, 3, 4);
            btnExplorarJSON.Name = "btnExplorarJSON";
            btnExplorarJSON.Size = new Size(114, 35);
            btnExplorarJSON.TabIndex = 5;
            btnExplorarJSON.Text = "Explorar...";
            btnExplorarJSON.UseVisualStyleBackColor = true;
            // 
            // grpPreferencias
            // 
            grpPreferencias.Controls.Add(lblUmbral);
            grpPreferencias.Controls.Add(nudUmbral);
            grpPreferencias.Controls.Add(lblUmbralSufijo);
            grpPreferencias.Controls.Add(lblUnidades);
            grpPreferencias.Controls.Add(rbCelsius);
            grpPreferencias.Controls.Add(rbFahrenheit);
            grpPreferencias.Location = new Point(9, 283);
            grpPreferencias.Margin = new Padding(3, 4, 3, 4);
            grpPreferencias.Name = "grpPreferencias";
            grpPreferencias.Padding = new Padding(3, 4, 3, 4);
            grpPreferencias.Size = new Size(1001, 107);
            grpPreferencias.TabIndex = 2;
            grpPreferencias.TabStop = false;
            grpPreferencias.Text = "Preferencias";
            // 
            // lblUmbral
            // 
            lblUmbral.AutoSize = true;
            lblUmbral.Location = new Point(11, 43);
            lblUmbral.Name = "lblUmbral";
            lblUmbral.Size = new Size(124, 20);
            lblUmbral.TabIndex = 0;
            lblUmbral.Text = "Umbral de alerta:";
            // 
            // nudUmbral
            // 
            nudUmbral.DecimalPlaces = 1;
            nudUmbral.Increment = new decimal(new int[] { 5, 0, 0, 65536 });
            nudUmbral.Location = new Point(139, 37);
            nudUmbral.Margin = new Padding(3, 4, 3, 4);
            nudUmbral.Maximum = new decimal(new int[] { 20, 0, 0, 0 });
            nudUmbral.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudUmbral.Name = "nudUmbral";
            nudUmbral.Size = new Size(69, 27);
            nudUmbral.TabIndex = 1;
            nudUmbral.Value = new decimal(new int[] { 10, 0, 0, 0 });
            // 
            // lblUmbralSufijo
            // 
            lblUmbralSufijo.AutoSize = true;
            lblUmbralSufijo.Location = new Point(215, 43);
            lblUmbralSufijo.Name = "lblUmbralSufijo";
            lblUmbralSufijo.Size = new Size(24, 20);
            lblUmbralSufijo.TabIndex = 2;
            lblUmbralSufijo.Text = "°C";
            // 
            // lblUnidades
            // 
            lblUnidades.AutoSize = true;
            lblUnidades.Location = new Point(320, 43);
            lblUnidades.Name = "lblUnidades";
            lblUnidades.Size = new Size(74, 20);
            lblUnidades.TabIndex = 3;
            lblUnidades.Text = "Unidades:";
            // 
            // rbCelsius
            // 
            rbCelsius.AutoSize = true;
            rbCelsius.Checked = true;
            rbCelsius.Location = new Point(400, 40);
            rbCelsius.Margin = new Padding(3, 4, 3, 4);
            rbCelsius.Name = "rbCelsius";
            rbCelsius.Size = new Size(75, 24);
            rbCelsius.TabIndex = 4;
            rbCelsius.TabStop = true;
            rbCelsius.Text = "Celsius";
            // 
            // rbFahrenheit
            // 
            rbFahrenheit.AutoSize = true;
            rbFahrenheit.Location = new Point(482, 40);
            rbFahrenheit.Margin = new Padding(3, 4, 3, 4);
            rbFahrenheit.Name = "rbFahrenheit";
            rbFahrenheit.Size = new Size(98, 24);
            rbFahrenheit.TabIndex = 5;
            rbFahrenheit.Text = "Fahrenheit";
            // 
            // btnGuardarConfig
            // 
            btnGuardarConfig.Location = new Point(9, 405);
            btnGuardarConfig.Margin = new Padding(3, 4, 3, 4);
            btnGuardarConfig.Name = "btnGuardarConfig";
            btnGuardarConfig.Size = new Size(149, 37);
            btnGuardarConfig.TabIndex = 3;
            btnGuardarConfig.Text = "Guardar configuración";
            btnGuardarConfig.UseVisualStyleBackColor = true;
            // 
            // statusStrip
            // 
            statusStrip.ImageScalingSize = new Size(20, 20);
            statusStrip.Items.AddRange(new ToolStripItem[] { tssSQLite, tssSQLServer, tssAPI, tssRegistros });
            statusStrip.Location = new Point(0, 867);
            statusStrip.Name = "statusStrip";
            statusStrip.Padding = new Padding(1, 0, 16, 0);
            statusStrip.Size = new Size(1029, 26);
            statusStrip.TabIndex = 1;
            // 
            // tssSQLite
            // 
            tssSQLite.Name = "tssSQLite";
            tssSQLite.Size = new Size(74, 20);
            tssSQLite.Text = "SQLite: —";
            // 
            // tssSQLServer
            // 
            tssSQLServer.Name = "tssSQLServer";
            tssSQLServer.Size = new Size(102, 20);
            tssSQLServer.Text = "SQL Server: —";
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
            tssRegistros.Size = new Size(720, 20);
            tssRegistros.Spring = true;
            tssRegistros.Text = "Registros cargados: —";
            tssRegistros.TextAlign = ContentAlignment.MiddleRight;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1029, 893);
            Controls.Add(tabControl);
            Controls.Add(statusStrip);
            Font = new Font("Segoe UI", 9F);
            Margin = new Padding(3, 4, 3, 4);
            MinimumSize = new Size(1044, 930);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sistema de Inteligencia Climática — México";
            Load += Form1_Load;
            tabControl.ResumeLayout(false);
            tabConsulta.ResumeLayout(false);
            grpBusqueda.ResumeLayout(false);
            grpBusqueda.PerformLayout();
            grpDatosActuales.ResumeLayout(false);
            grpDatosActuales.PerformLayout();
            grpHistorico.ResumeLayout(false);
            grpHistorico.PerformLayout();
            grpAnomalia.ResumeLayout(false);
            grpAnomalia.PerformLayout();
            tabAnalisis.ResumeLayout(false);
            grpFiltrosGlobal.ResumeLayout(false);
            grpFiltrosGlobal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHistorico).EndInit();
            grpRanking.ResumeLayout(false);
            grpRanking.PerformLayout();
            tabFavoritos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvFavoritos).EndInit();
            grpAgregarFav.ResumeLayout(false);
            grpAgregarFav.PerformLayout();
            tabConfig.ResumeLayout(false);
            grpConexion.ResumeLayout(false);
            grpConexion.PerformLayout();
            grpArchivos.ResumeLayout(false);
            grpArchivos.PerformLayout();
            grpPreferencias.ResumeLayout(false);
            grpPreferencias.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudUmbral).EndInit();
            statusStrip.ResumeLayout(false);
            statusStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
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