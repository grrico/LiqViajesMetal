namespace MetalLiqViajes_Forms
{
    partial class fTerpel
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fTerpel));
            this.btnConsultar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.ListPlacas = new System.Windows.Forms.CheckedListBox();
            this.checkBoxMarcar = new System.Windows.Forms.CheckBox();
            this.comboBoxYear = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxMonth = new System.Windows.Forms.ComboBox();
            this.btnCargaExcel = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridFiles = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCargaDirectorio = new System.Windows.Forms.Button();
            this.btnGuadarExcel = new System.Windows.Forms.Button();
            this.textBoxPath = new System.Windows.Forms.TextBox();
            this.dataGridDataExcel = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel5 = new System.Windows.Forms.Panel();
            this.dataGridViewVentasDetalle = new System.Windows.Forms.DataGridView();
            this.ventasFlotaDetalleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnGetDataVentas = new System.Windows.Forms.Button();
            this.textBoxFactura = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.dlgOpenDir = new System.Windows.Forms.FolderBrowserDialog();
            this.dlgOpenFile = new System.Windows.Forms.OpenFileDialog();
            this.textBoxTotalVentas = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxTotalFactura = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxCantidad = new System.Windows.Forms.TextBox();
            this.utilPlacaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reciboDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.facturaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.placaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipo52vDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numero52vDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.seqDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cuentaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalVentasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalFacturaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridFiles)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDataExcel)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVentasDetalle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ventasFlotaDetalleBindingSource)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.utilPlacaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(160, 11);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(75, 56);
            this.btnConsultar.TabIndex = 4;
            this.btnConsultar.Text = "Cargar Datos de API Terpel";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Placa:";
            // 
            // ListPlacas
            // 
            this.ListPlacas.CheckOnClick = true;
            this.ListPlacas.FormattingEnabled = true;
            this.ListPlacas.Location = new System.Drawing.Point(54, 99);
            this.ListPlacas.Name = "ListPlacas";
            this.ListPlacas.Size = new System.Drawing.Size(101, 259);
            this.ListPlacas.TabIndex = 3;
            // 
            // checkBoxMarcar
            // 
            this.checkBoxMarcar.AutoSize = true;
            this.checkBoxMarcar.Location = new System.Drawing.Point(54, 76);
            this.checkBoxMarcar.Name = "checkBoxMarcar";
            this.checkBoxMarcar.Size = new System.Drawing.Size(92, 17);
            this.checkBoxMarcar.TabIndex = 2;
            this.checkBoxMarcar.Text = "Marcar Todas";
            this.checkBoxMarcar.UseVisualStyleBackColor = true;
            this.checkBoxMarcar.CheckedChanged += new System.EventHandler(this.checkBoxMarcar_CheckedChanged);
            // 
            // comboBoxYear
            // 
            this.comboBoxYear.FormattingEnabled = true;
            this.comboBoxYear.Location = new System.Drawing.Point(54, 11);
            this.comboBoxYear.Name = "comboBoxYear";
            this.comboBoxYear.Size = new System.Drawing.Size(100, 21);
            this.comboBoxYear.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Año:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Mes:";
            // 
            // comboBoxMonth
            // 
            this.comboBoxMonth.FormattingEnabled = true;
            this.comboBoxMonth.Location = new System.Drawing.Point(54, 46);
            this.comboBoxMonth.Name = "comboBoxMonth";
            this.comboBoxMonth.Size = new System.Drawing.Size(100, 21);
            this.comboBoxMonth.TabIndex = 1;
            // 
            // btnCargaExcel
            // 
            this.btnCargaExcel.Image = ((System.Drawing.Image)(resources.GetObject("btnCargaExcel.Image")));
            this.btnCargaExcel.Location = new System.Drawing.Point(207, 5);
            this.btnCargaExcel.Name = "btnCargaExcel";
            this.btnCargaExcel.Size = new System.Drawing.Size(178, 30);
            this.btnCargaExcel.TabIndex = 2;
            this.btnCargaExcel.Text = "Leer Excel";
            this.btnCargaExcel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip1.SetToolTip(this.btnCargaExcel, "Haga clic aquí para recuperar los datos del archivo seleccionado");
            this.btnCargaExcel.UseVisualStyleBackColor = true;
            this.btnCargaExcel.Click += new System.EventHandler(this.btnCargaExcel_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.comboBoxYear);
            this.splitContainer1.Panel1.Controls.Add(this.checkBoxMarcar);
            this.splitContainer1.Panel1.Controls.Add(this.btnConsultar);
            this.splitContainer1.Panel1.Controls.Add(this.comboBoxMonth);
            this.splitContainer1.Panel1.Controls.Add(this.ListPlacas);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.label4);
            this.splitContainer1.Panel1.Controls.Add(this.label5);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tabControl1);
            this.splitContainer1.Size = new System.Drawing.Size(1050, 393);
            this.splitContainer1.SplitterDistance = 208;
            this.splitContainer1.TabIndex = 10;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(836, 391);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.splitContainer2);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(828, 365);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Importa Data Terpel";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // splitContainer2
            // 
            this.splitContainer2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(3, 3);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.panel2);
            this.splitContainer2.Panel1.Controls.Add(this.panel1);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.dataGridDataExcel);
            this.splitContainer2.Size = new System.Drawing.Size(822, 359);
            this.splitContainer2.SplitterDistance = 178;
            this.splitContainer2.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridFiles);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 67);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(820, 109);
            this.panel2.TabIndex = 2;
            // 
            // dataGridFiles
            // 
            this.dataGridFiles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridFiles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridFiles.Location = new System.Drawing.Point(0, 0);
            this.dataGridFiles.Name = "dataGridFiles";
            this.dataGridFiles.Size = new System.Drawing.Size(820, 109);
            this.dataGridFiles.TabIndex = 0;
            this.dataGridFiles.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridFiles_RowEnter);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnCargaDirectorio);
            this.panel1.Controls.Add(this.btnGuadarExcel);
            this.panel1.Controls.Add(this.btnCargaExcel);
            this.panel1.Controls.Add(this.textBoxPath);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(820, 67);
            this.panel1.TabIndex = 1;
            // 
            // btnCargaDirectorio
            // 
            this.btnCargaDirectorio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnCargaDirectorio.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCargaDirectorio.Image = ((System.Drawing.Image)(resources.GetObject("btnCargaDirectorio.Image")));
            this.btnCargaDirectorio.Location = new System.Drawing.Point(2, 5);
            this.btnCargaDirectorio.Name = "btnCargaDirectorio";
            this.btnCargaDirectorio.Size = new System.Drawing.Size(199, 30);
            this.btnCargaDirectorio.TabIndex = 1;
            this.btnCargaDirectorio.Text = "Cargar Arhivos";
            this.btnCargaDirectorio.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCargaDirectorio.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip1.SetToolTip(this.btnCargaDirectorio, "Haga clic aquí para buscar la carpeta donde están los archivos de Terpel");
            this.btnCargaDirectorio.UseVisualStyleBackColor = false;
            this.btnCargaDirectorio.Click += new System.EventHandler(this.btnCargaDirectorio_Click);
            // 
            // btnGuadarExcel
            // 
            this.btnGuadarExcel.Image = ((System.Drawing.Image)(resources.GetObject("btnGuadarExcel.Image")));
            this.btnGuadarExcel.Location = new System.Drawing.Point(391, 5);
            this.btnGuadarExcel.Name = "btnGuadarExcel";
            this.btnGuadarExcel.Size = new System.Drawing.Size(178, 30);
            this.btnGuadarExcel.TabIndex = 2;
            this.btnGuadarExcel.Text = "Guardar Datos";
            this.btnGuadarExcel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGuadarExcel.UseVisualStyleBackColor = true;
            this.btnGuadarExcel.Click += new System.EventHandler(this.btnGuadarExcel_Click);
            // 
            // textBoxPath
            // 
            this.textBoxPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxPath.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.textBoxPath.Enabled = false;
            this.textBoxPath.Location = new System.Drawing.Point(3, 39);
            this.textBoxPath.Multiline = true;
            this.textBoxPath.Name = "textBoxPath";
            this.textBoxPath.Size = new System.Drawing.Size(814, 25);
            this.textBoxPath.TabIndex = 0;
            // 
            // dataGridDataExcel
            // 
            this.dataGridDataExcel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridDataExcel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridDataExcel.Location = new System.Drawing.Point(0, 0);
            this.dataGridDataExcel.Name = "dataGridDataExcel";
            this.dataGridDataExcel.Size = new System.Drawing.Size(820, 175);
            this.dataGridDataExcel.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.panel5);
            this.tabPage2.Controls.Add(this.panel4);
            this.tabPage2.Controls.Add(this.panel3);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(828, 365);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Crea Registro DMS";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.dataGridViewVentasDetalle);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(3, 59);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(822, 244);
            this.panel5.TabIndex = 2;
            // 
            // dataGridViewVentasDetalle
            // 
            this.dataGridViewVentasDetalle.AllowUserToAddRows = false;
            this.dataGridViewVentasDetalle.AllowUserToDeleteRows = false;
            this.dataGridViewVentasDetalle.AutoGenerateColumns = false;
            this.dataGridViewVentasDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewVentasDetalle.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.reciboDataGridViewTextBoxColumn,
            this.facturaDataGridViewTextBoxColumn,
            this.placaDataGridViewTextBoxColumn,
            this.tipoDataGridViewTextBoxColumn,
            this.numeroDataGridViewTextBoxColumn,
            this.tipo52vDataGridViewTextBoxColumn,
            this.numero52vDataGridViewTextBoxColumn,
            this.nitDataGridViewTextBoxColumn,
            this.seqDataGridViewTextBoxColumn,
            this.cuentaDataGridViewTextBoxColumn,
            this.fechaDataGridViewTextBoxColumn,
            this.totalVentasDataGridViewTextBoxColumn,
            this.totalFacturaDataGridViewTextBoxColumn});
            this.dataGridViewVentasDetalle.DataSource = this.ventasFlotaDetalleBindingSource;
            this.dataGridViewVentasDetalle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewVentasDetalle.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewVentasDetalle.Name = "dataGridViewVentasDetalle";
            this.dataGridViewVentasDetalle.ReadOnly = true;
            this.dataGridViewVentasDetalle.Size = new System.Drawing.Size(822, 244);
            this.dataGridViewVentasDetalle.TabIndex = 0;
            // 
            // ventasFlotaDetalleBindingSource
            // 
            this.ventasFlotaDetalleBindingSource.DataSource = typeof(LiqViajes_Bll_Data.VentasFlotaDetalle);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.textBoxTotalVentas);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.textBoxCantidad);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.textBoxTotalFactura);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(3, 303);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(822, 59);
            this.panel4.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.btnGetDataVentas);
            this.panel3.Controls.Add(this.textBoxFactura);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(822, 56);
            this.panel3.TabIndex = 0;
            // 
            // btnGetDataVentas
            // 
            this.btnGetDataVentas.Image = global::MetalLiqViajes_Forms.Properties.Resources.Terpel;
            this.btnGetDataVentas.Location = new System.Drawing.Point(234, 3);
            this.btnGetDataVentas.Name = "btnGetDataVentas";
            this.btnGetDataVentas.Size = new System.Drawing.Size(121, 30);
            this.btnGetDataVentas.TabIndex = 8;
            this.btnGetDataVentas.Text = "Consulta Datos";
            this.btnGetDataVentas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip1.SetToolTip(this.btnGetDataVentas, "Cargar Datos Ventas por Factura");
            this.btnGetDataVentas.UseVisualStyleBackColor = true;
            this.btnGetDataVentas.Click += new System.EventHandler(this.btnGetDataVentas_Click);
            // 
            // textBoxFactura
            // 
            this.textBoxFactura.Location = new System.Drawing.Point(67, 3);
            this.textBoxFactura.Name = "textBoxFactura";
            this.textBoxFactura.Size = new System.Drawing.Size(161, 20);
            this.textBoxFactura.TabIndex = 7;
            // 
            // dlgOpenDir
            // 
            this.dlgOpenDir.RootFolder = System.Environment.SpecialFolder.MyComputer;
            // 
            // dlgOpenFile
            // 
            this.dlgOpenFile.FileName = "openFileDialog";
            // 
            // textBoxTotalVentas
            // 
            this.textBoxTotalVentas.Enabled = false;
            this.textBoxTotalVentas.Location = new System.Drawing.Point(91, 6);
            this.textBoxTotalVentas.Name = "textBoxTotalVentas";
            this.textBoxTotalVentas.Size = new System.Drawing.Size(108, 20);
            this.textBoxTotalVentas.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(4, 6);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Total Ventas:";
            // 
            // textBoxTotalFactura
            // 
            this.textBoxTotalFactura.Enabled = false;
            this.textBoxTotalFactura.Location = new System.Drawing.Point(306, 6);
            this.textBoxTotalFactura.Name = "textBoxTotalFactura";
            this.textBoxTotalFactura.Size = new System.Drawing.Size(97, 20);
            this.textBoxTotalFactura.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(216, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Total Factura:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(420, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Cantidad:";
            // 
            // textBoxCantidad
            // 
            this.textBoxCantidad.Enabled = false;
            this.textBoxCantidad.Location = new System.Drawing.Point(489, 6);
            this.textBoxCantidad.Name = "textBoxCantidad";
            this.textBoxCantidad.Size = new System.Drawing.Size(97, 20);
            this.textBoxCantidad.TabIndex = 20;
            // 
            // utilPlacaBindingSource
            // 
            this.utilPlacaBindingSource.DataSource = typeof(MetalLiqViajes_Forms.UtilPlaca);
            // 
            // reciboDataGridViewTextBoxColumn
            // 
            this.reciboDataGridViewTextBoxColumn.DataPropertyName = "Recibo";
            this.reciboDataGridViewTextBoxColumn.HeaderText = "Recibo";
            this.reciboDataGridViewTextBoxColumn.Name = "reciboDataGridViewTextBoxColumn";
            this.reciboDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // facturaDataGridViewTextBoxColumn
            // 
            this.facturaDataGridViewTextBoxColumn.DataPropertyName = "Factura";
            this.facturaDataGridViewTextBoxColumn.HeaderText = "Factura";
            this.facturaDataGridViewTextBoxColumn.Name = "facturaDataGridViewTextBoxColumn";
            this.facturaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // placaDataGridViewTextBoxColumn
            // 
            this.placaDataGridViewTextBoxColumn.DataPropertyName = "Placa";
            this.placaDataGridViewTextBoxColumn.HeaderText = "Placa";
            this.placaDataGridViewTextBoxColumn.Name = "placaDataGridViewTextBoxColumn";
            this.placaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tipoDataGridViewTextBoxColumn
            // 
            this.tipoDataGridViewTextBoxColumn.DataPropertyName = "Tipo";
            this.tipoDataGridViewTextBoxColumn.HeaderText = "Tipo";
            this.tipoDataGridViewTextBoxColumn.Name = "tipoDataGridViewTextBoxColumn";
            this.tipoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // numeroDataGridViewTextBoxColumn
            // 
            this.numeroDataGridViewTextBoxColumn.DataPropertyName = "Numero";
            this.numeroDataGridViewTextBoxColumn.HeaderText = "Numero";
            this.numeroDataGridViewTextBoxColumn.Name = "numeroDataGridViewTextBoxColumn";
            this.numeroDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tipo52vDataGridViewTextBoxColumn
            // 
            this.tipo52vDataGridViewTextBoxColumn.DataPropertyName = "Tipo52v";
            this.tipo52vDataGridViewTextBoxColumn.HeaderText = "Tipo52v";
            this.tipo52vDataGridViewTextBoxColumn.Name = "tipo52vDataGridViewTextBoxColumn";
            this.tipo52vDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // numero52vDataGridViewTextBoxColumn
            // 
            this.numero52vDataGridViewTextBoxColumn.DataPropertyName = "Numero52v";
            this.numero52vDataGridViewTextBoxColumn.HeaderText = "Numero52v";
            this.numero52vDataGridViewTextBoxColumn.Name = "numero52vDataGridViewTextBoxColumn";
            this.numero52vDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nitDataGridViewTextBoxColumn
            // 
            this.nitDataGridViewTextBoxColumn.DataPropertyName = "Nit";
            this.nitDataGridViewTextBoxColumn.HeaderText = "Nit";
            this.nitDataGridViewTextBoxColumn.Name = "nitDataGridViewTextBoxColumn";
            this.nitDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // seqDataGridViewTextBoxColumn
            // 
            this.seqDataGridViewTextBoxColumn.DataPropertyName = "Seq";
            this.seqDataGridViewTextBoxColumn.HeaderText = "Seq";
            this.seqDataGridViewTextBoxColumn.Name = "seqDataGridViewTextBoxColumn";
            this.seqDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cuentaDataGridViewTextBoxColumn
            // 
            this.cuentaDataGridViewTextBoxColumn.DataPropertyName = "Cuenta";
            this.cuentaDataGridViewTextBoxColumn.HeaderText = "Cuenta";
            this.cuentaDataGridViewTextBoxColumn.Name = "cuentaDataGridViewTextBoxColumn";
            this.cuentaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fechaDataGridViewTextBoxColumn
            // 
            this.fechaDataGridViewTextBoxColumn.DataPropertyName = "Fecha";
            this.fechaDataGridViewTextBoxColumn.HeaderText = "Fecha";
            this.fechaDataGridViewTextBoxColumn.Name = "fechaDataGridViewTextBoxColumn";
            this.fechaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // totalVentasDataGridViewTextBoxColumn
            // 
            this.totalVentasDataGridViewTextBoxColumn.DataPropertyName = "TotalVentas";
            this.totalVentasDataGridViewTextBoxColumn.HeaderText = "TotalVentas";
            this.totalVentasDataGridViewTextBoxColumn.Name = "totalVentasDataGridViewTextBoxColumn";
            this.totalVentasDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // totalFacturaDataGridViewTextBoxColumn
            // 
            this.totalFacturaDataGridViewTextBoxColumn.DataPropertyName = "TotalFactura";
            this.totalFacturaDataGridViewTextBoxColumn.HeaderText = "TotalFactura";
            this.totalFacturaDataGridViewTextBoxColumn.Name = "totalFacturaDataGridViewTextBoxColumn";
            this.totalFacturaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fTerpel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1050, 393);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fTerpel";
            this.Text = "Importar Terpel";
            this.Load += new System.EventHandler(this.fTerpel_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridFiles)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDataExcel)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVentasDetalle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ventasFlotaDetalleBindingSource)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.utilPlacaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.BindingSource utilPlacaBindingSource;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckedListBox ListPlacas;
        private System.Windows.Forms.CheckBox checkBoxMarcar;
        private System.Windows.Forms.ComboBox comboBoxYear;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxMonth;
        private System.Windows.Forms.Button btnCargaExcel;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridFiles;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridDataExcel;
        private System.Windows.Forms.Button btnCargaDirectorio;
        private System.Windows.Forms.TextBox textBoxPath;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.FolderBrowserDialog dlgOpenDir;
        private System.Windows.Forms.OpenFileDialog dlgOpenFile;
        private System.Windows.Forms.Button btnGuadarExcel;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.DataGridView dataGridViewVentasDetalle;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnGetDataVentas;
        private System.Windows.Forms.TextBox textBoxFactura;
        private System.Windows.Forms.BindingSource ventasFlotaDetalleBindingSource;
        private System.Windows.Forms.TextBox textBoxTotalVentas;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxCantidad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxTotalFactura;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn reciboDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn facturaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn placaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipo52vDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numero52vDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn seqDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cuentaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalVentasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalFacturaDataGridViewTextBoxColumn;
    }
}