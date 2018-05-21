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
            try
            {

                btnGuardar.Enabled = true;

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
                {
                    btnGuardar.Enabled = false;
                    checkBoxAplicado.Checked = true;
                }

                TercerosConductores conductores = conductoresList.Where(t => t.IntNit.ToString() == documentoDms.nit.ToString()).FirstOrDefault();
                this.Text = "Tipo: " + documentoDms.tipo + ", Documento DMS: " + documentoDms.numero + ", Nit: " + documentoDms.nit +  " Conductor: "+ conductores.strNombres.ToUpper();

                textBoxNota.Text = "";
                textBoxNit.Text = documentoDms.nit.ToString();
                textBoxValor.Text = documentoDms.valor_total.Value.ToString("n0");

                List<LiquidacionAnticipos> LiquidacionAnticiposList = LiquidacionAnticiposController.Instance.GetFilter("(intDocumento = " + documentoDms.numero + ") AND (strtipo = '" + documentoDms.tipo + "')", "lngIdRegistroViaje");
                LiquidacionAnticipos LiquidacionAnticipos = LiquidacionAnticiposList.FirstOrDefault();
                if (LiquidacionAnticipos != null)
                {
                    textBoxViaje.Text = LiquidacionAnticipos.lngIdRegistroViajeTramo.ToString("n0");
                    LiquidacionVehiculo liquidacionvehiculo = LiquidacionVehiculoController.Instance.Get(long.Parse(LiquidacionAnticipos.lngIdRegistroViajeTramo.ToString()));
                    if (liquidacionvehiculo != null)
                    {
                        conductores = conductoresList.Where(t => t.IntNit.ToString() == liquidacionvehiculo.intNitConductor.Value.ToString()).FirstOrDefault();
                        textBoxNota.Text = "El documento esta aplicado en el viaje " + liquidacionvehiculo.lngIdRegistro.ToString();
                        textBoxNota.Text += "\tFecha de Asignación: " + liquidacionvehiculo.dtmFechaModif.Value.ToString("dd/MMM/yyyy");
                        textBoxNota.Text += "\tConductor: " + liquidacionvehiculo.intNitConductor.Value + " -  Conductores: " + conductores.strNombres.ToUpper(); ;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex.Message, "Metal - Cambia de Nit", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
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

            try
            {
                sql = "UPDATE movimientos SET nit = '" + textBoxNit.Text + "' WHERE (tipo = '" + documentoDms.tipo + "') AND (numero = " + documentoDms.numero + ")";
                LiqViajes_Bll_Data.DataProvider.EjecutarSQL(sql, out error);
                this.Close();
            }
            catch (Exception ex)
            {
            }

            try
            {
                sql = "UPDATE documentos SET nit = " + textBoxNit.Text + " WHERE (tipo = '" + documentoDms.tipo + "') AND (numero = " + documentoDms.numero + ")";
                LiqViajes_Bll_Data.DataProvider.EjecutarSQL(sql, out error);
            }
            catch (Exception ex)
            {
            }
            try
            {
                sql = "DELETE FROM tblLiquidacionAnticipos WHERE (intDocumento = " + documentoDms.numero + ") AND (strtipo = '" + documentoDms.tipo + "')";
                LiqViajes_Bll_Data.DataProvider.EjecutarSQL(sql, out error);
            }
            catch (Exception ex)
            {
            }
            MetalLiqViajes_Forms.fTerpelDMS c = (MetalLiqViajes_Forms.fTerpelDMS)this.ParentForm;
            c.RefrescarData();
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
