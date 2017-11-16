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

        public Conductor conductor;
        public VehiculoCCosto vehiculo;
        public TipoVehiculo tipovehiculo;
        public TercerosConductores terceroconductor;
        private List<TipoVehiculo> tipovehiculoList;
        private List<TercerosConductores> conductoresList;
        public CrearViaje()
        {
            InitializeComponent();

            tipovehiculoList = TipoVehiculoController.Instance.GetAll().Where(t => t.Activo.Value == true && t.Codigo >= 1).ToList();
            dataGridViewTipoVehiculo.DataSource = tipovehiculoList;
            dataGridViewTipoVehiculo.Refresh();

            conductoresList = TercerosConductoresController.Instance.GetAll().Where(t => t.logEstado.Value == true).ToList();
            dataGridViewPlaca.DataSource = conductoresList;
            dataGridViewPlaca.Refresh();
        }

        private void CrearViaje_Load(object sender, EventArgs e)
        {
            //conductor

            VehiculoCCosto vehiculo = VehiculoCCostoController.Instance.GetByPlaca(conductor.Placa);

            int index = tipovehiculoList.FindIndex(t => t.Codigo == vehiculo.TipoVehiculoCodigo.Value);
            dataGridViewTipoVehiculo.ClearSelection();
            dataGridViewTipoVehiculo.Rows[index].Selected = true;
            dataGridViewTipoVehiculo.FirstDisplayedScrollingRowIndex = index;
            dataGridViewTipoVehiculo.Focus();

            int index2 = conductoresList.FindIndex(t => t.placa == vehiculo.strPlaca);
            dataGridViewPlaca.ClearSelection();
            dataGridViewPlaca.Rows[index2].Selected = true;
            dataGridViewPlaca.FirstDisplayedScrollingRowIndex = index2;
            dataGridViewPlaca.Focus();

        }

        private void dataGridViewTipoVehiculo_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            tipovehiculo = dataGridViewTipoVehiculo.Rows[e.RowIndex].DataBoundItem as TipoVehiculo;
            List<VehiculoCCosto> vehiculosList = VehiculoCCostoController.Instance.GetAll().Where(t => t.TipoVehiculoCodigo == tipovehiculo.Codigo).ToList();

            dataGridViewPlaca.DataSource = vehiculosList;
            dataGridViewPlaca.Refresh();

        }

        private void dataGridViewConductor_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            terceroconductor = dataGridViewConductor.Rows[e.RowIndex].DataBoundItem as TercerosConductores;

        }

        private void dataGridViewPlaca_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                vehiculo = dataGridViewConductor.Rows[e.RowIndex].DataBoundItem as VehiculoCCosto;
            }
            catch (Exception)
            {
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
