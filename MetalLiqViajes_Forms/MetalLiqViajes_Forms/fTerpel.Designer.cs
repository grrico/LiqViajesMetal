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
            this.utilPlacaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnCargaExcel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.utilPlacaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(338, 14);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(75, 23);
            this.btnConsultar.TabIndex = 0;
            this.btnConsultar.Text = "Leer API";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(176, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Placa:";
            // 
            // ListPlacas
            // 
            this.ListPlacas.CheckOnClick = true;
            this.ListPlacas.FormattingEnabled = true;
            this.ListPlacas.Location = new System.Drawing.Point(219, 47);
            this.ListPlacas.Name = "ListPlacas";
            this.ListPlacas.Size = new System.Drawing.Size(101, 184);
            this.ListPlacas.TabIndex = 4;
            // 
            // checkBoxMarcar
            // 
            this.checkBoxMarcar.AutoSize = true;
            this.checkBoxMarcar.Location = new System.Drawing.Point(219, 14);
            this.checkBoxMarcar.Name = "checkBoxMarcar";
            this.checkBoxMarcar.Size = new System.Drawing.Size(92, 17);
            this.checkBoxMarcar.TabIndex = 5;
            this.checkBoxMarcar.Text = "Marcar Todas";
            this.checkBoxMarcar.UseVisualStyleBackColor = true;
            this.checkBoxMarcar.CheckedChanged += new System.EventHandler(this.checkBoxMarcar_CheckedChanged);
            // 
            // comboBoxYear
            // 
            this.comboBoxYear.FormattingEnabled = true;
            this.comboBoxYear.Location = new System.Drawing.Point(60, 12);
            this.comboBoxYear.Name = "comboBoxYear";
            this.comboBoxYear.Size = new System.Drawing.Size(100, 21);
            this.comboBoxYear.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Año:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Mes:";
            // 
            // comboBoxMonth
            // 
            this.comboBoxMonth.FormattingEnabled = true;
            this.comboBoxMonth.Location = new System.Drawing.Point(60, 47);
            this.comboBoxMonth.Name = "comboBoxMonth";
            this.comboBoxMonth.Size = new System.Drawing.Size(100, 21);
            this.comboBoxMonth.TabIndex = 9;
            // 
            // utilPlacaBindingSource
            // 
            this.utilPlacaBindingSource.DataSource = typeof(MetalLiqViajes_Forms.UtilPlaca);
            // 
            // btnCargaExcel
            // 
            this.btnCargaExcel.Location = new System.Drawing.Point(434, 14);
            this.btnCargaExcel.Name = "btnCargaExcel";
            this.btnCargaExcel.Size = new System.Drawing.Size(75, 23);
            this.btnCargaExcel.TabIndex = 0;
            this.btnCargaExcel.Text = "Leer Excel";
            this.btnCargaExcel.UseVisualStyleBackColor = true;
            this.btnCargaExcel.Click += new System.EventHandler(this.btnCargaExcel_Click);
            // 
            // fTerpel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 371);
            this.Controls.Add(this.comboBoxYear);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBoxMonth);
            this.Controls.Add(this.checkBoxMarcar);
            this.Controls.Add(this.ListPlacas);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnCargaExcel);
            this.Controls.Add(this.btnConsultar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fTerpel";
            this.Text = "fTerpel";
            this.Load += new System.EventHandler(this.fTerpel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.utilPlacaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
    }
}