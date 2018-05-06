using System;
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

        public fMenuPrincipal()
        {
            InitializeComponent();
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
            try
            {
                panelMenu.Visible = false;

                fReportesViajes childForm = new fReportesViajes();
                childForm.MdiParent = this;
                childForm.WindowState = FormWindowState.Maximized;
                childForm.Show();

            }
            catch (Exception ex)
            {
                CargaExection(ex);
            }
        }

        private void terpelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CargarFacturaTerpel();
        }

        private void CargarFacturaTerpel()
        {
            panelMenu.Visible = false;

            fTerpel terpel = new fTerpel();
            terpel.MdiParent = this;
            terpel.WindowState = FormWindowState.Maximized;
            terpel.Show();
        }

        private void terpelDMSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MovimientosDMS();
        }

        private void MovimientosDMS()
        {
            panelMenu.Visible = false;

            fTerpelDMS terpel = new fTerpelDMS();
            terpel.MdiParent = this;
            terpel.WindowState = FormWindowState.Maximized;
            terpel.Show();

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
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
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
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
            this.Close();
        }

        public static void CargaExection(Exception ex)
        {

            DialogResult result3 = MessageBox.Show(ex.Message,
               "Error Cargando Datos",
               MessageBoxButtons.OK,
               MessageBoxIcon.Information,
               MessageBoxDefaultButton.Button1);
        }

        private void btnLiqVaiajes_Click(object sender, EventArgs e)
        {
            MenuReportes();
        }

        private void btnCargaFacturaTerpel_Click(object sender, EventArgs e)
        {
            CargarFacturaTerpel();
        }

        private void btnCargaDMS_Click(object sender, EventArgs e)
        {
            MovimientosDMS();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {

            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
            this.Close();

            panelMenu.Visible = false;
            Application.Exit();
        }
    }
}
