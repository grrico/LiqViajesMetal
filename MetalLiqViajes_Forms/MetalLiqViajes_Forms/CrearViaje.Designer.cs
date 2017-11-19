namespace MetalLiqViajes_Forms
{
    partial class CrearViaje
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CrearViaje));
            this.dataGridViewTipoVehiculo = new System.Windows.Forms.DataGridView();
            this.descripcionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoVehiculoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewPlaca = new System.Windows.Forms.DataGridView();
            this.tipoVehiculoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vehiculoCCostoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewConductor = new System.Windows.Forms.DataGridView();
            this.strNombresDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tercerosConductoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnCrear = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.rutasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rutasOrigenDestinoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTipoVehiculo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoVehiculoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPlaca)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehiculoCCostoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewConductor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tercerosConductoresBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rutasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rutasOrigenDestinoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewTipoVehiculo
            // 
            this.dataGridViewTipoVehiculo.AllowUserToAddRows = false;
            this.dataGridViewTipoVehiculo.AllowUserToDeleteRows = false;
            this.dataGridViewTipoVehiculo.AutoGenerateColumns = false;
            this.dataGridViewTipoVehiculo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTipoVehiculo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.descripcionDataGridViewTextBoxColumn});
            this.dataGridViewTipoVehiculo.DataSource = this.tipoVehiculoBindingSource;
            this.dataGridViewTipoVehiculo.EnableHeadersVisualStyles = false;
            this.dataGridViewTipoVehiculo.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewTipoVehiculo.Name = "dataGridViewTipoVehiculo";
            this.dataGridViewTipoVehiculo.ReadOnly = true;
            this.dataGridViewTipoVehiculo.RowHeadersWidth = 10;
            this.dataGridViewTipoVehiculo.Size = new System.Drawing.Size(257, 298);
            this.dataGridViewTipoVehiculo.TabIndex = 0;
            this.dataGridViewTipoVehiculo.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewTipoVehiculo_RowEnter);
            // 
            // descripcionDataGridViewTextBoxColumn
            // 
            this.descripcionDataGridViewTextBoxColumn.DataPropertyName = "Descripcion";
            this.descripcionDataGridViewTextBoxColumn.HeaderText = "Descripcion";
            this.descripcionDataGridViewTextBoxColumn.Name = "descripcionDataGridViewTextBoxColumn";
            this.descripcionDataGridViewTextBoxColumn.ReadOnly = true;
            this.descripcionDataGridViewTextBoxColumn.Width = 230;
            // 
            // tipoVehiculoBindingSource
            // 
            this.tipoVehiculoBindingSource.DataSource = typeof(LiqViajes_Bll_Data.TipoVehiculo);
            // 
            // dataGridViewPlaca
            // 
            this.dataGridViewPlaca.AllowUserToAddRows = false;
            this.dataGridViewPlaca.AllowUserToDeleteRows = false;
            this.dataGridViewPlaca.AutoGenerateColumns = false;
            this.dataGridViewPlaca.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPlaca.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tipoVehiculoDataGridViewTextBoxColumn});
            this.dataGridViewPlaca.DataSource = this.vehiculoCCostoBindingSource;
            this.dataGridViewPlaca.EnableHeadersVisualStyles = false;
            this.dataGridViewPlaca.Location = new System.Drawing.Point(275, 12);
            this.dataGridViewPlaca.Name = "dataGridViewPlaca";
            this.dataGridViewPlaca.ReadOnly = true;
            this.dataGridViewPlaca.RowHeadersWidth = 10;
            this.dataGridViewPlaca.Size = new System.Drawing.Size(152, 298);
            this.dataGridViewPlaca.TabIndex = 0;
            this.dataGridViewPlaca.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPlaca_RowEnter);
            // 
            // tipoVehiculoDataGridViewTextBoxColumn
            // 
            this.tipoVehiculoDataGridViewTextBoxColumn.DataPropertyName = "Placa";
            this.tipoVehiculoDataGridViewTextBoxColumn.HeaderText = "Placa";
            this.tipoVehiculoDataGridViewTextBoxColumn.Name = "tipoVehiculoDataGridViewTextBoxColumn";
            this.tipoVehiculoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // vehiculoCCostoBindingSource
            // 
            this.vehiculoCCostoBindingSource.DataSource = typeof(LiqViajes_Bll_Data.VehiculoCCosto);
            // 
            // dataGridViewConductor
            // 
            this.dataGridViewConductor.AllowUserToAddRows = false;
            this.dataGridViewConductor.AllowUserToDeleteRows = false;
            this.dataGridViewConductor.AutoGenerateColumns = false;
            this.dataGridViewConductor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewConductor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.strNombresDataGridViewTextBoxColumn});
            this.dataGridViewConductor.DataSource = this.tercerosConductoresBindingSource;
            this.dataGridViewConductor.EnableHeadersVisualStyles = false;
            this.dataGridViewConductor.Location = new System.Drawing.Point(433, 12);
            this.dataGridViewConductor.Name = "dataGridViewConductor";
            this.dataGridViewConductor.ReadOnly = true;
            this.dataGridViewConductor.RowHeadersWidth = 10;
            this.dataGridViewConductor.Size = new System.Drawing.Size(285, 298);
            this.dataGridViewConductor.TabIndex = 0;
            this.dataGridViewConductor.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewConductor_RowEnter);
            // 
            // strNombresDataGridViewTextBoxColumn
            // 
            this.strNombresDataGridViewTextBoxColumn.DataPropertyName = "strNombres";
            this.strNombresDataGridViewTextBoxColumn.HeaderText = "Conductor";
            this.strNombresDataGridViewTextBoxColumn.Name = "strNombresDataGridViewTextBoxColumn";
            this.strNombresDataGridViewTextBoxColumn.ReadOnly = true;
            this.strNombresDataGridViewTextBoxColumn.Width = 220;
            // 
            // tercerosConductoresBindingSource
            // 
            this.tercerosConductoresBindingSource.DataSource = typeof(LiqViajes_Bll_Data.TercerosConductores);
            // 
            // btnCrear
            // 
            this.btnCrear.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnCrear.Location = new System.Drawing.Point(741, 12);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(75, 40);
            this.btnCrear.TabIndex = 1;
            this.btnCrear.Text = "Crear Viaje";
            this.btnCrear.UseVisualStyleBackColor = true;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Location = new System.Drawing.Point(741, 70);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 40);
            this.btnCancelar.TabIndex = 1;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // rutasBindingSource
            // 
            this.rutasBindingSource.DataSource = typeof(LiqViajes_Bll_Data.Rutas);
            // 
            // rutasOrigenDestinoBindingSource
            // 
            this.rutasOrigenDestinoBindingSource.DataSource = typeof(LiqViajes_Bll_Data.RutasOrigenDestino);
            // 
            // CrearViaje
            // 
            this.AcceptButton = this.btnCrear;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancelar;
            this.ClientSize = new System.Drawing.Size(826, 322);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnCrear);
            this.Controls.Add(this.dataGridViewConductor);
            this.Controls.Add(this.dataGridViewPlaca);
            this.Controls.Add(this.dataGridViewTipoVehiculo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CrearViaje";
            this.Text = "CrearViaje";
            this.Load += new System.EventHandler(this.CrearViaje_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTipoVehiculo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoVehiculoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPlaca)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehiculoCCostoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewConductor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tercerosConductoresBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rutasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rutasOrigenDestinoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewTipoVehiculo;
        private System.Windows.Forms.BindingSource tipoVehiculoBindingSource;
        private System.Windows.Forms.DataGridView dataGridViewPlaca;
        private System.Windows.Forms.DataGridView dataGridViewConductor;
        private System.Windows.Forms.DataGridViewTextBoxColumn strNombresDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource tercerosConductoresBindingSource;
        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoVehiculoDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource vehiculoCCostoBindingSource;
        private System.Windows.Forms.BindingSource rutasOrigenDestinoBindingSource;
        private System.Windows.Forms.BindingSource rutasBindingSource;
    }
}