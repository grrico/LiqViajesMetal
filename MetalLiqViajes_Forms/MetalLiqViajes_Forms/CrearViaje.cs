using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LiqViajes_Bll_Data;

namespace MetalLiqViajes_Forms
{
    public partial class CrearViaje : Form
    {
        public CrearViaje()
        {
            InitializeComponent();

            List<TipoVehiculo> tipovehiculoList = TipoVehiculoController.Instance.GetAll().Where(t => t.Activo.Value==true).ToList();
            dataGridViewTipoVehiculo.DataSource = tipovehiculoList;
            dataGridViewTipoVehiculo.Refresh();

            List<TercerosConductores> conductoresList = TercerosConductoresController.Instance.GetAll().Where(t => t.logEstado.Value == true).ToList();
            dataGridViewPlaca.DataSource = conductoresList;
            dataGridViewPlaca.Refresh();
        }

        private void dataGridViewTipoVehiculo_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            TipoVehiculo tipovehiculo = dataGridViewTipoVehiculo.Rows[e.RowIndex].DataBoundItem as TipoVehiculo;
            List<VehiculoCCosto> vehiculosList = VehiculoCCostoController.Instance.GetAll().Where(t => t.TipoVehiculoCodigo == tipovehiculo.Codigo).ToList();

            dataGridViewPlaca.DataSource = vehiculosList;
            dataGridViewPlaca.Refresh();

        }

        private void dataGridViewConductor_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            VehiculoCCosto tipovehiculo = dataGridViewConductor.Rows[e.RowIndex].DataBoundItem as VehiculoCCosto;
            
        }

        private void dataGridViewPlaca_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            TipoVehiculo tipovehiculo = dataGridViewTipoVehiculo.Rows[e.RowIndex].DataBoundItem as TipoVehiculo;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            LiquidacionVehiculo liqVehiculo = new LiquidacionVehiculo();
            
        }
    }
}
