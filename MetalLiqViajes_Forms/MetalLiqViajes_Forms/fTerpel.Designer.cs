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
            this.utilPlacaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.FechaInicial = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.FechaFinal = new System.Windows.Forms.DateTimePicker();
            this.ListPlacas = new System.Windows.Forms.CheckedListBox();
            this.checkBoxMarcar = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.utilPlacaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(200, 85);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(75, 23);
            this.btnConsultar.TabIndex = 0;
            this.btnConsultar.Text = "Consultar Placa";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // utilPlacaBindingSource
            // 
            this.utilPlacaBindingSource.DataSource = typeof(MetalLiqViajes_Forms.UtilPlaca);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Placa:";
            // 
            // FechaInicial
            // 
            this.FechaInicial.Location = new System.Drawing.Point(93, 12);
            this.FechaInicial.Name = "FechaInicial";
            this.FechaInicial.Size = new System.Drawing.Size(200, 20);
            this.FechaInicial.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Fecha Inicial:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Fecha Final:";
            // 
            // FechaFinal
            // 
            this.FechaFinal.Location = new System.Drawing.Point(93, 38);
            this.FechaFinal.Name = "FechaFinal";
            this.FechaFinal.Size = new System.Drawing.Size(200, 20);
            this.FechaFinal.TabIndex = 3;
            // 
            // ListPlacas
            // 
            this.ListPlacas.CheckOnClick = true;
            this.ListPlacas.FormattingEnabled = true;
            this.ListPlacas.Location = new System.Drawing.Point(93, 85);
            this.ListPlacas.Name = "ListPlacas";
            this.ListPlacas.Size = new System.Drawing.Size(101, 184);
            this.ListPlacas.TabIndex = 4;
            // 
            // checkBoxMarcar
            // 
            this.checkBoxMarcar.AutoSize = true;
            this.checkBoxMarcar.Location = new System.Drawing.Point(93, 62);
            this.checkBoxMarcar.Name = "checkBoxMarcar";
            this.checkBoxMarcar.Size = new System.Drawing.Size(92, 17);
            this.checkBoxMarcar.TabIndex = 5;
            this.checkBoxMarcar.Text = "Marcar Todas";
            this.checkBoxMarcar.UseVisualStyleBackColor = true;
            this.checkBoxMarcar.CheckedChanged += new System.EventHandler(this.checkBoxMarcar_CheckedChanged);
            // 
            // fTerpel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(717, 281);
            this.Controls.Add(this.checkBoxMarcar);
            this.Controls.Add(this.ListPlacas);
            this.Controls.Add(this.FechaFinal);
            this.Controls.Add(this.FechaInicial);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
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
        private System.Windows.Forms.DateTimePicker FechaInicial;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker FechaFinal;
        private System.Windows.Forms.CheckedListBox ListPlacas;
        private System.Windows.Forms.CheckBox checkBoxMarcar;
    }
}