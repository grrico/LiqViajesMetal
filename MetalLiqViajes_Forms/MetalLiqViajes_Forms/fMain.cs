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
    public partial class fMain : Form
    {
        private fReportesViajes childForm;

        public fMain()
        {
            InitializeComponent();
        }

        private void btnCargaFacturaTerpel_Click(object sender, EventArgs e)
        {

        }

        private void btnLiqVaiajes_Click(object sender, EventArgs e)
        {
            try
            {
                

            }
            catch (Exception ex)
            {
                CargaExection(ex);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();            
        }

        private void btnCargaDMS_Click(object sender, EventArgs e)
        {

        }

        public static void CargaExection(Exception ex)
        {
            DialogResult result3 = MessageBox.Show(ex.Message,
               "Error Cargando Datos",
               MessageBoxButtons.OK,
               MessageBoxIcon.Information,
               MessageBoxDefaultButton.Button1);
        }

        private void fMain_Load(object sender, EventArgs e)
        {

        }
    }
}
