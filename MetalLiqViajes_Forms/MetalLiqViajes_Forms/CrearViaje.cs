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

        private List<RutasOrigenDestino> rutasDestinoList;

        public CrearViaje()
        {
            InitializeComponent();

            tipovehiculoList = TipoVehiculoController.Instance.GetAll().Where(t => t.Activo.Value == true && t.Codigo >= 1).ToList();
            dataGridViewTipoVehiculo.DataSource = tipovehiculoList;
            dataGridViewTipoVehiculo.Refresh();

            conductoresList = TercerosConductoresController.Instance.GetAll().Where(t => t.logEstado.Value == true).ToList();

            dataGridViewConductor.DataSource = conductoresList;
            dataGridViewConductor.Refresh();

            #region apunte
            //var distinctDestino = rutasorigenDestinoList.AsEnumerable()
            //.Select(row => new
            //{
            //    Destino = row.Destino
            //})
            //.Distinct();

            //var distinctTrailer = rutasorigenDestinoList.AsEnumerable()
            //.Select(row => new
            //{
            //    TipoTrailerCodigo=row.TipoTrailerCodigo,
            //    DescripcionTrailer = row.DescripcionTrailer
            //})
            //.Distinct();
            #endregion

        }

        private void CrearViaje_Load(object sender, EventArgs e)
        {
            // lee el vehículo
            vehiculo = VehiculoCCostoController.Instance.GetByPlaca(conductor.Placa);

            // busca el tipo de vehículo
            conductor.TipoVehiculoCodigo = vehiculo.TipoVehiculoCodigo.Value;

            // ubica el tipo de vehículo en la lista y mueve el foco al registro
            int index = tipovehiculoList.FindIndex(t => t.Codigo == conductor.TipoVehiculoCodigo);
            dataGridViewTipoVehiculo.ClearSelection();
            dataGridViewTipoVehiculo.Rows[index].Selected = true;
            dataGridViewTipoVehiculo.FirstDisplayedScrollingRowIndex = index;
            dataGridViewTipoVehiculo.Focus();

            // casa la lista de vehículos segun el tipo de vehiculos
            tipovehiculo = dataGridViewTipoVehiculo.Rows[index].DataBoundItem as TipoVehiculo;
            List<VehiculoCCosto> vehiculosList = tipovehiculo.VehiculoCCosto.ToList();

            // asigna la lista de vehículos al grid de placas
            dataGridViewPlaca.DataSource = vehiculosList;
            dataGridViewPlaca.Refresh();

            int index2 = vehiculosList.FindIndex(t => t.strPlaca == conductor.Placa);
            if (index2 >= 0)
            {
                dataGridViewPlaca.ClearSelection();
                dataGridViewPlaca.Rows[index2].Selected = true;
                dataGridViewPlaca.FirstDisplayedScrollingRowIndex = index2;
                dataGridViewPlaca.Focus();

                vehiculo = dataGridViewPlaca.Rows[index2].DataBoundItem as VehiculoCCosto;

            }

            int index3 = conductoresList.FindIndex(t => t.IntNit == Convert.ToDouble(conductor.Cedula));
            if (index3 >= 0)
            {
                dataGridViewConductor.ClearSelection();
                dataGridViewConductor.Rows[index3].Selected = true;
                dataGridViewConductor.FirstDisplayedScrollingRowIndex = index3;
                dataGridViewConductor.Focus();

                terceroconductor = dataGridViewConductor.Rows[index3].DataBoundItem as TercerosConductores;
            }

        }

        private void dataGridViewTipoVehiculo_RowEnter(object sender, DataGridViewCellEventArgs e)
        {

            tipovehiculo = dataGridViewTipoVehiculo.Rows[e.RowIndex].DataBoundItem as TipoVehiculo;
            List<VehiculoCCosto> vehiculosList = tipovehiculo.VehiculoCCosto.ToList();

            dataGridViewPlaca.DataSource = vehiculosList;
            dataGridViewPlaca.Refresh();

        }

        private void dataGridViewConductor_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            terceroconductor = dataGridViewConductor.Rows[e.RowIndex].DataBoundItem as TercerosConductores;
        }

        private void dataGridViewPlaca_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            vehiculo = dataGridViewPlaca.Rows[e.RowIndex].DataBoundItem as VehiculoCCosto;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    DialogResult resultado = MessageBox.Show("Confirma crear el registro ahora?", "Validar Crear Registro", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
            //    if (resultado == DialogResult.Yes)
            //    {
            //        //LiquidacionVehiculo liqVehiculo = new LiquidacionVehiculo();
            //        //liqVehiculo.strPlaca = vehiculo.strPlaca;
            //        //liqVehiculo.intNitConductor = Convert.ToDecimal(terceroconductor.IntNit);
            //        //liqVehiculo.curGastos = 0;
            //        //liqVehiculo.curAnticipos = 0;
            //        //liqVehiculo.curTotal = 0;
            //        //liqVehiculo.dtmFechaModif = DateTime.Now;
            //        //liqVehiculo.logLiquidado = false;
            //        //LiquidacionVehiculoController.Instance.Create(liqVehiculo);


            //    }
            //}
            //catch (Exception ex)
            //{
            //    CargaExection(ex);
            //}
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
    }
}
