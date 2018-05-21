using LiqViajes_Bll_Data;
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
    public partial class fDmdCambioNit : Form
    {
        public documentos documentoDms;
        public List<movimientos> movimientosList;
        public movimientos movimientos;
        public TercerosConductores terceroconductor;
        private List<TercerosConductores> conductoresList;
        private List<LiquidacionAnticipos> LiquidacionAnticiposList;
        private LiquidacionAnticipos LiquidacionAnticipos;

        public fDmdCambioNit()
        {
            InitializeComponent();
        }

        private void fDmdCambioNit_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }
        private void CargarDatos()
        {
            conductoresList = TercerosConductoresController.Instance.GetAll().Where(t => t.logEstado.Value == true).ToList();

            comboBoxNit.DataSource = conductoresList;
            comboBoxNit.Refresh();
            comboBoxNit.SelectedItem = conductoresList.FirstOrDefault(t => t.IntNit.ToString() == documentoDms.nit.ToString());

            List<movimientos> movimientoslist = movimientosController.Instance.GetByTipoNumero(documentoDms.tipo, documentoDms.numero);
            textBoxValorTotal.Text = movimientoslist.Where(c => c.cuenta == "13301504").Sum(t => t.valor).ToString("n0");
            textBoxValorTotalNiff.Text = movimientoslist.Sum(t => t.valor_niif).ToString("n0");
            checkBoxAplicado.Enabled = false;
            checkBoxAplicado.Checked = false;
            if (documentoDms.valor_aplicado.Value > 0)
                checkBoxAplicado.Checked = true;

            textBoxNit.Text = documentoDms.nit.ToString();
            textBoxValor.Text = documentoDms.valor_total.Value.ToString("n0");

            List<LiquidacionAnticipos> LiquidacionAnticiposList = LiquidacionAnticiposController.Instance.GetFilter("(intDocumento = " + documentoDms.numero + ") AND (strtipo = '" + documentoDms.tipo + "')", "lngIdRegistroViaje");
            LiquidacionAnticipos LiquidacionAnticipos = LiquidacionAnticiposList.FirstOrDefault();

            textBoxViaje.Text = "";
            if (LiquidacionAnticipos != null)
                textBoxViaje.Text = LiquidacionAnticipos.lngIdRegistroViajeTramo.ToString("n0");
        }

        private void btnAplicarCambio_Click(object sender, EventArgs e)
        {
            CambiarCedula();
        }


        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string error = "";
            string sql = "";

            sql = "UPDATE movimientos SET nit = '" + textBoxNit.Text + "' WHERE (tipo = '" + documentoDms.tipo + "') AND (numero = " + documentoDms.numero + ")";
            LiqViajes_Bll_Data.DataProvider.EjecutarSQL(sql, out error);

            sql = "UPDATE documentos SET nit = " + textBoxNit.Text + " WHERE (tipo = '" + documentoDms.tipo + "') AND (numero = " + documentoDms.numero + ")";
            LiqViajes_Bll_Data.DataProvider.EjecutarSQL(sql, out error);

            sql = "DELETE FROM tblLiquidacionAnticipos WHERE (intDocumento = " + documentoDms.numero + ") AND (strtipo = '" + documentoDms.tipo + "')";
            LiqViajes_Bll_Data.DataProvider.EjecutarSQL(sql, out error);

            
        }

        private void comboBoxNit_KeyDown(object sender, KeyEventArgs e)
        {
            CambiarCedula();
        }

        private void comboBoxNit_KeyUp(object sender, KeyEventArgs e)
        {
            CambiarCedula();
        }

        private void comboBoxNit_KeyPress(object sender, KeyPressEventArgs e)
        {
            CambiarCedula();
        }
        private void CambiarCedula()
        {
            if (comboBoxNit.SelectedValue != null)
                textBoxNit.Text = comboBoxNit.SelectedValue.ToString();
        }
    }
}
