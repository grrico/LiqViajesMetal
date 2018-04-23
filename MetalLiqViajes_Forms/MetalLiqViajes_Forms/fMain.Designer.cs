namespace MetalLiqViajes_Forms
{
    partial class fMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fMain));
            this.btnCargaFacturaTerpel = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnCargaDMS = new System.Windows.Forms.Button();
            this.btnLiqVaiajes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCargaFacturaTerpel
            // 
            this.btnCargaFacturaTerpel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnCargaFacturaTerpel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCargaFacturaTerpel.Image = ((System.Drawing.Image)(resources.GetObject("btnCargaFacturaTerpel.Image")));
            this.btnCargaFacturaTerpel.Location = new System.Drawing.Point(100, 23);
            this.btnCargaFacturaTerpel.Name = "btnCargaFacturaTerpel";
            this.btnCargaFacturaTerpel.Size = new System.Drawing.Size(171, 104);
            this.btnCargaFacturaTerpel.TabIndex = 3;
            this.btnCargaFacturaTerpel.Text = "Facturación Terpel";
            this.btnCargaFacturaTerpel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCargaFacturaTerpel.UseVisualStyleBackColor = false;
            this.btnCargaFacturaTerpel.Click += new System.EventHandler(this.btnCargaFacturaTerpel_Click);
            // 
            // btnClose
            // 
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(277, 134);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(171, 104);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "Salir";
            this.btnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnCargaDMS
            // 
            this.btnCargaDMS.Image = ((System.Drawing.Image)(resources.GetObject("btnCargaDMS.Image")));
            this.btnCargaDMS.Location = new System.Drawing.Point(100, 134);
            this.btnCargaDMS.Name = "btnCargaDMS";
            this.btnCargaDMS.Size = new System.Drawing.Size(171, 104);
            this.btnCargaDMS.TabIndex = 5;
            this.btnCargaDMS.Text = "Consulta DMS";
            this.btnCargaDMS.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCargaDMS.UseVisualStyleBackColor = true;
            this.btnCargaDMS.Click += new System.EventHandler(this.btnCargaDMS_Click);
            // 
            // btnLiqVaiajes
            // 
            this.btnLiqVaiajes.Image = global::MetalLiqViajes_Forms.Properties.Resources.Truck;
            this.btnLiqVaiajes.Location = new System.Drawing.Point(277, 24);
            this.btnLiqVaiajes.Name = "btnLiqVaiajes";
            this.btnLiqVaiajes.Size = new System.Drawing.Size(171, 104);
            this.btnLiqVaiajes.TabIndex = 4;
            this.btnLiqVaiajes.Text = "Liquidación Viajes";
            this.btnLiqVaiajes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLiqVaiajes.UseVisualStyleBackColor = true;
            this.btnLiqVaiajes.Click += new System.EventHandler(this.btnLiqVaiajes_Click);
            // 
            // fMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 285);
            this.Controls.Add(this.btnCargaFacturaTerpel);
            this.Controls.Add(this.btnLiqVaiajes);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnCargaDMS);
            this.Name = "fMain";
            this.Text = "fMain";
            this.Load += new System.EventHandler(this.fMain_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCargaFacturaTerpel;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnCargaDMS;
        private System.Windows.Forms.Button btnLiqVaiajes;
    }
}