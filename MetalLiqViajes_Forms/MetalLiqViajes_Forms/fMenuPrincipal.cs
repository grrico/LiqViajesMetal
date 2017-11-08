﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MetalLiqViajes_Forms
{
    public partial class fMenuPrincipal : Form
    {
        private int childFormNumber = 0;

        public fMenuPrincipal()
        {
            InitializeComponent();
        }

        private void fMenuPrincipal_Load(object sender, EventArgs e)
        {
            MenuReportes();

            if (!System.Diagnostics.EventLog.SourceExists("MetalOlapEvent"))
                System.Diagnostics.EventLog.CreateEventSource("MetalOlapEvent", "MetalOlapLop");

            MetalOlapEventLog.Source = "MetalOlapEvent";
            MetalOlapEventLog.Log = "MetalOlapLop";


        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MenuReportes();
        }

        private void printToolStripButton_Click(object sender, EventArgs e)
        {
            MenuReportes();
        }

        private void MenuReportes()
        {
            fReportesViajes childForm = new fReportesViajes();
            childForm.MdiParent = this;
            childForm.WindowState = FormWindowState.Maximized;
            childForm.Show();
        }

        private void OpenReporte(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
