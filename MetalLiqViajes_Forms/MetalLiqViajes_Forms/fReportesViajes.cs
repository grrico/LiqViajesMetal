﻿using LiqViajes_Bll_Data;
using Microsoft.Reporting.WinForms;
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
    public partial class fReportesViajes : Form
    {
        private List<LiqViajes_Bll_Data.AnticiposDms> anticiposdmslist;
        private LiqViajes_Bll_Data.AnticiposDms anticiposdms;

        private List<LiqViajes_Bll_Data.RegistroViajeDTO> registroviajelist;
        private List<LiqViajes_Bll_Data.RegistroViajeDTO> registroviajelistFiltro;
        private LiqViajes_Bll_Data.RegistroViajeDTO iRegistroViajeDTO;
        private Conductor conductor;

        private List<LiqViajes_Bll_Data.TramosGastos> tramosGastosList;

        private List<TramosAsignadosRuta> tramosAsignadosList;
        private TramosAsignadosRuta tramosAsignados;

        private List<LiquidacionRutas> liquidacionrutaslist;
        private LiquidacionRutas liquidacionrutas;

        private UtiliDRegistro utilidregistro;
        private UtilYear utilyear;
        private UtilMonth ultilmonth;
        private UtilPlaca ultilplaca;
        private string Nit { get; set; }

        private bool iCargaCompleta { get; set; }

        public fReportesViajes()
        {
            InitializeComponent();

            this.Cursor = Cursors.WaitCursor;

            iCargaCompleta = false;
            Nit = "";

            this.comboBoxYear.DisplayMember = "YearName";
            this.comboBoxYear.ValueMember = "YearId";

            this.comboBoxMonth.DisplayMember = "MonthName";
            this.comboBoxMonth.ValueMember = "MonthId";

            List<UtilYear> utilyearlist = new List<UtilYear>();
            for (int i = 2004; i <= DateTime.Now.Year; i++)
            {
                utilyear = new UtilYear();
                utilyear.YearId = i;
                utilyear.YearName = i.ToString();
                utilyearlist.Add(utilyear);
            }
            string[] MesesAño = new string[12];
            MesesAño[0] = "Enero";
            MesesAño[1] = "Febrero";
            MesesAño[2] = "Marzo";
            MesesAño[3] = "Abril";
            MesesAño[4] = "Mayo";
            MesesAño[5] = "Junio";
            MesesAño[6] = "Julio";
            MesesAño[7] = "Agosto";
            MesesAño[8] = "Septiembre";
            MesesAño[9] = "Octubre";
            MesesAño[10] = "Noviembre";
            MesesAño[11] = "Diciembre";

            List<UtilMonth> ultilmonthlist = new List<UtilMonth>();

            int imes = 0;
            foreach (var item in MesesAño)
            {
                ultilmonth = new UtilMonth();
                ultilmonth.MonthName = MesesAño[imes].ToString();
                imes++;
                ultilmonth.MonthId = imes;
                ultilmonthlist.Add(ultilmonth);
            }

            comboBoxMonth.DataSource = ultilmonthlist.ToList();
            comboBoxYear.DataSource = utilyearlist.OrderByDescending(o => o.YearId).ToList();


            comboBoxMonth.SelectedIndex = (DateTime.Now.Month) - 1;

            this.Cursor = Cursors.Default;

            btnQuitarFintro.Visible = false;

            iCargaCompleta = true;
        }

        private void comboBoxYear_SelectedIndexChanged(object sender, EventArgs e)
        {

            utilyear = comboBoxYear.SelectedItem as UtilYear;

        }

        private void comboBoxMonth_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!iCargaCompleta) return;

            ultilmonth = comboBoxMonth.SelectedItem as UtilMonth;
            CargaRegistroViaje(utilyear.YearId);
        }

        private void btnRefrescar_Click(object sender, EventArgs e)
        {

            ultilmonth = comboBoxMonth.SelectedItem as UtilMonth;
            CargaRegistroViaje(utilyear.YearId);
        }

        private void btnBuscaViajes_Click(object sender, EventArgs e)
        {

            try
            {
                if (textBoxiRegistroViaje.Text == "")
                {
                    DialogResult result3 = MessageBox.Show("Debe ingresar el registro del viajes?",
                        "Buscar un viaje en la base de datos",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information,
                        MessageBoxDefaultButton.Button1);

                    return;
                }

                if (!LiqViajes_Bll_Data.Helps.IsNumeric(textBoxiRegistroViaje.Text))
                {
                    DialogResult result3 = MessageBox.Show("En registro debe ser numerico",
                        "Buscar un viaje en la base de datos",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information,
                        MessageBoxDefaultButton.Button1);

                    return;

                }

                long idRegistro = long.Parse(textBoxiRegistroViaje.Text);

                //  busca primero en la lista
                registroviajelistFiltro = new List<RegistroViajeDTO>();

                if (registroviajelist != null && registroviajelist.Count > 0)
                {
                    registroviajelistFiltro = registroviajelist.Where(p => p.IdRegistro == idRegistro).ToList();
                    // la lista tiene registros 
                }


                if (registroviajelistFiltro.Count == 0)
                {

                    registroviajelistFiltro = LiqViajes_Bll_Data.LiquidacionVehiculoController.Instance.GetBy_RegistroViajes(idRegistro);
                }
                if (registroviajelistFiltro.Count == 0)
                {
                    DialogResult result3 = MessageBox.Show("No hey Registro",
                               "Carga de Datos",
                               MessageBoxButtons.OK,
                               MessageBoxIcon.Information,
                               MessageBoxDefaultButton.Button1);
                    return;
                }
                utilidregistro = comboBoxRegViaje.SelectedItem as UtiliDRegistro;
                dataGridViewViajes.DataSource = registroviajelistFiltro;
                dataGridViewViajes.Refresh();

                btnQuitarFintro.Visible = true;

                dataGridViewConductor.Enabled = false;


            }
            catch (Exception ex)
            {
                carlaExection(ex);
            }
        }

        private static void carlaExection(Exception ex)
        {
            DialogResult result3 = MessageBox.Show(ex.Message,
               "Error Cargando Datos",
               MessageBoxButtons.OK,
               MessageBoxIcon.Information,
               MessageBoxDefaultButton.Button1);
        }

        private void btnQuitarFintro_Click(object sender, EventArgs e)
        {
            dataGridViewViajes.DataSource = registroviajelist;
            dataGridViewViajes.Refresh();

            btnQuitarFintro.Visible = false;
            dataGridViewConductor.Enabled = true;

        }

        private void CargaRegistroViaje(int Ano)
        {

            registroviajelist = LiqViajes_Bll_Data.LiquidacionVehiculoController.Instance.GetBy_RegistroViajesAnoDTO(Ano, ultilmonth.MonthId);
            if (registroviajelist.Count == 0)
            {
                if (iCargaCompleta)
                {
                    DialogResult result3 = MessageBox.Show("No hey Registro",
                               "Carga de Datos",
                               MessageBoxButtons.OK,
                               MessageBoxIcon.Information,
                               MessageBoxDefaultButton.Button1);
                    return;
                }
            }

            var distinctconductor = registroviajelist.AsEnumerable()
            .Select(row => new
            {
                Cedula = row.NitConductor,
                NombreConductor = row.NombreConductor,
                Placa = row.Placa,
                Anticipo = decimal.Parse("0"),
                Gastos = decimal.Parse("0"),
                Total = decimal.Parse("0"),
            })
            .Distinct();

            decimal anticipo = 0;
            List<Conductor> ConductorList = new List<Conductor>();

            foreach (var item in distinctconductor.ToList())
            {
                anticipo = registroviajelist
                .Where(t => t.NitConductor == item.Cedula)
                .Sum(t => t.ValorAnticipos);

                conductor = new Conductor();
                conductor.Cedula = decimal.Parse(item.Cedula);
                conductor.NombreConductor = item.NombreConductor;
                conductor.Placa = item.Placa;
                conductor.ValorAnticipo = registroviajelist
                                          .Where(t => t.NitConductor == item.Cedula)
                                          .Sum(t => t.ValorAnticipos);
                conductor.ValorGastos = registroviajelist
                                          .Where(t => t.NitConductor == item.Cedula)
                                          .Sum(t => t.ValorGastos);
                conductor.ValorTotal = registroviajelist
                                          .Where(t => t.NitConductor == item.Cedula)
                                          .Sum(t => t.ValorSaldo);

                ConductorList.Add(conductor);
            }

            dataGridViewConductor.DataSource = ConductorList.OrderBy(o => o.NombreConductor).ToList();
            dataGridViewConductor.Refresh();

            var distinctregistro = registroviajelist.AsEnumerable()
            .Select(row => new
            {
                idRegistro = row.IdRegistro,
            })
            .Distinct();

            List<UtiliDRegistro> utilidregistrolist = new List<UtiliDRegistro>();
            utilidregistro = new UtiliDRegistro();
            utilidregistro.idRegistro = 0;
            utilidregistrolist.Add(utilidregistro);

            foreach (var item in distinctregistro.ToList())
            {
                utilidregistro = new UtiliDRegistro();
                utilidregistro.idRegistro = item.idRegistro;
                utilidregistrolist.Add(utilidregistro);
            }

            comboBoxRegViaje.Text = "";
            comboBoxRegViaje.DataSource = utilidregistrolist.ToList();

            var distinctplaca = registroviajelist.AsEnumerable()
                        .Select(row => new
                        {
                            Placa = row.Placa,
                        })
                        .Distinct();
            comboBoxPlaca.Text = "";

            List<UtilPlaca> ultilplacalist = new List<UtilPlaca>();
            ultilplaca = new UtilPlaca();
            ultilplaca.Placa = "_Seleccionar";
            ultilplacalist.Add(ultilplaca);

            foreach (var item in distinctplaca.ToList())
            {
                ultilplaca = new UtilPlaca();
                ultilplaca.Placa = item.Placa;
                ultilplacalist.Add(ultilplaca);
            }
            comboBoxPlaca.DataSource = ultilplacalist;

        }

        private void comboBoxPlaca_SelectedIndexChanged(object sender, EventArgs e)
        {
            ultilplaca = comboBoxPlaca.SelectedItem as UtilPlaca;
            if (ultilplaca.Placa == "_Seleccionar")
            {
                dataGridViewViajes.DataSource = registroviajelist;
                dataGridViewViajes.Refresh();
            }
            else
            {
                registroviajelistFiltro = registroviajelist.Where(p => p.Placa == ultilplaca.Placa).ToList();
                dataGridViewViajes.DataSource = registroviajelistFiltro;
                dataGridViewViajes.Refresh();
            }
        }

        private void comboBoxRegViaje_SelectedIndexChanged(object sender, EventArgs e)
        {
            utilidregistro = comboBoxRegViaje.SelectedItem as UtiliDRegistro;
            if (utilidregistro.idRegistro == 0)
            {

                dataGridViewViajes.DataSource = registroviajelist;
                dataGridViewViajes.Refresh();

            }
            else
            {
                registroviajelistFiltro = registroviajelist.Where(p => p.IdRegistro == utilidregistro.idRegistro).ToList();
                dataGridViewViajes.DataSource = registroviajelistFiltro;
                dataGridViewViajes.Refresh();

            }
        }

        private void dataGridViewViajes_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            iRegistroViajeDTO = dataGridViewViajes.Rows[e.RowIndex].DataBoundItem as LiqViajes_Bll_Data.RegistroViajeDTO;

        }

        private void dataGridViewLiqRutas_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            tramosAsignados = dataGridViewLiqRutas.Rows[e.RowIndex].DataBoundItem as TramosAsignadosRuta;

            tramosGastosList = LiqViajes_Bll_Data.TramosGastosController.Instance.GetBy_RegistroViaje(tramosAsignados.Registro);

            TramosGastos tramosgastos = new TramosGastos();

            tramosgastos.Codigo = 0;
            tramosgastos.DescripcionCuenta = "Gran total_Gran total";
            tramosgastos.ValorTotal = tramosGastosList.Sum(t => t.ValorTotal);

            tramosGastosList.Add(tramosgastos);

            dataGridViewCuentasGastos.DataSource = tramosGastosList.ToList();
            dataGridViewCuentasGastos.Refresh();

            dataGridViewLavadas.DataSource = LiqViajes_Bll_Data.TramosLavadasController.Instance.GetBy_RegistroViaje(decimal.Parse(iRegistroViajeDTO.NitConductor));
            dataGridViewLavadas.Refresh();
        }

        private void dataGridViewConductor_RowEnter(object sender, DataGridViewCellEventArgs e)
        {

            conductor = dataGridViewConductor.Rows[e.RowIndex].DataBoundItem as Conductor;

            registroviajelistFiltro = registroviajelist.Where(p => p.NitConductor == conductor.Cedula.ToString()).ToList();
            dataGridViewViajes.DataSource = registroviajelistFiltro;
            dataGridViewViajes.Refresh();
        }

        private void fReportesViajes_Load(object sender, EventArgs e)
        {

        }

        private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl.SelectedIndex == 1)
            {

                // carga los tramos
                try
                {
                    if (iRegistroViajeDTO == null)
                    {
                        tabControl.SelectedIndex = 0;
                        return;
                    }

                    if (tramosAsignadosList != null && tramosAsignadosList.Count > 0 && tramosAsignadosList.FirstOrDefault().RegistroId == iRegistroViajeDTO.IdRegistro)
                    {
                        tramosAsignadosList = TramosAsignadosRutaController.Instance.GetBy_lngIdRegistro(int.Parse(iRegistroViajeDTO.IdRegistro.ToString()));
                        dataGridViewLiqRutas.DataSource = tramosAsignadosList.ToList();
                        dataGridViewLiqRutas.Refresh();

                        Nit = iRegistroViajeDTO.NitConductor;
                        anticiposdmslist = LiqViajes_Bll_Data.AnticiposDmsController.Instance.GetBy_DocumentoNit(long.Parse(iRegistroViajeDTO.NitConductor), iRegistroViajeDTO.IdRegistro).ToList();

                        anticiposdms = new AnticiposDms();
                        anticiposdms.Dms_Chk = 0;
                        anticiposdms.Dms_ValorAnticipo = anticiposdmslist.Sum(s => s.Dms_ValorAnticipo.Value);
                        anticiposdms.Dms_ValorAplicado = anticiposdmslist.Sum(s => s.Dms_ValorAplicado.Value);
                        anticiposdms.Dms_ValorTotal = anticiposdmslist.Sum(s => s.Dms_ValorTotal.Value);
                        anticiposdmslist.Add(anticiposdms);

                        dataGridViewAnticipo.DataSource = anticiposdmslist.ToList();
                        dataGridViewAnticipo.Refresh();
                    }
                }
                catch (Exception ex)
                {
                    carlaExection(ex);
                }
            }
            if (tabControl.SelectedIndex == 2)
            {
                try
                {
                    if (tramosAsignados == null)
                    {
                        tabControl.SelectedIndex = 1;
                        return;
                    }

                    List<LiqViajes_Bll_Data.LiquidacionGastos> liquidacionGastosList = LiqViajes_Bll_Data.LiquidacionGastosController.Instance.GetBy_lngIdRegistrRuta(tramosAsignados.RegistroId);
                    dataGridViewLiqGastos.DataSource = liquidacionGastosList.ToList();
                }
                catch (Exception ex)
                {
                    carlaExection(ex);
                }

            }

            if (tabControl.SelectedIndex == 3)
            {
                try
                {
                    tabControl.SelectedIndex = 0;
                    CargarReporte();
                }
                catch (Exception ex)
                {
                    carlaExection(ex);
                }

            }


        }


        private void CargarReporte()
        {
            this.reportViewer.RefreshReport();

            long lngIdRegistro = iRegistroViajeDTO.IdRegistro;
            LiqViajes_Bll_Data.LiquidacionVehiculo LiquidacionVehiculo = LiqViajes_Bll_Data.LiquidacionVehiculoController.Instance.Get(int.Parse(lngIdRegistro.ToString()));

            LiqViajes_Bll_Data.VehiculoCCosto vehiculos = LiqViajes_Bll_Data.VehiculoCCostoController.Instance.GetByPlaca(LiquidacionVehiculo.strPlaca);

            List<LiqViajes_Bll_Data.TramosReportesLiqVehiculos> tramosReporteLiqVehiculosList = LiqViajes_Bll_Data.TramosReportesLiqVehiculosController.Instance.GetBy_Registro(lngIdRegistro);

            List<LiqViajes_Bll_Data.TramosConsultaAnticipos> tramosconsultaanticipoList = LiqViajes_Bll_Data.TramosConsultaAnticiposController.Instance.GetBy_RegistroViaje(lngIdRegistro);

            List<LiqViajes_Bll_Data.LiquidacionPlanilla> liqplanillalist = LiqViajes_Bll_Data.LiquidacionPlanillaController.Instance.GetBy_RegistroViaje(lngIdRegistro);

            List<LiqViajes_Bll_Data.TramosMovViajes> tramosviajesList = LiqViajes_Bll_Data.TramosMovViajesController.Instance.GetBy_RegistroViaje(lngIdRegistro);

            ReportDataSource rptdataLiqViaje = new ReportDataSource("DataSetLiqVehiculo");
            ReportDataSource rptdataTramosLiqVehiculos = new ReportDataSource("DataSetTramosReportesLiqVehiculos");
            ReportDataSource rptdataLiqPlamilla = new ReportDataSource("DataSetLiquidacionPlanilla");
            ReportDataSource rptdataConsultaAnticipo = new ReportDataSource("DataSetTramosConsultaAnticipos");
            ReportDataSource rptdataMovViajes = new ReportDataSource("DataSetTramosMovViajes");


            List<LiqViajes_Bll_Data.LiquidacionVehiculo> LiquidacionVehiculoList = new List<LiqViajes_Bll_Data.LiquidacionVehiculo>();
            LiquidacionVehiculoList.Add(LiquidacionVehiculo);

            rptdataLiqViaje.Value = LiquidacionVehiculoList;
            rptdataTramosLiqVehiculos.Value = tramosReporteLiqVehiculosList;
            rptdataLiqPlamilla.Value = liqplanillalist;
            rptdataConsultaAnticipo.Value = tramosconsultaanticipoList;
            rptdataMovViajes.Value = tramosviajesList;

            reportViewer.LocalReport.DataSources.Clear();
            reportViewer.LocalReport.DataSources.Add(rptdataLiqViaje);
            reportViewer.LocalReport.DataSources.Add(rptdataLiqPlamilla);
            reportViewer.LocalReport.DataSources.Add(rptdataTramosLiqVehiculos);
            reportViewer.LocalReport.DataSources.Add(rptdataConsultaAnticipo);
            reportViewer.LocalReport.DataSources.Add(rptdataMovViajes);
            reportViewer.LocalReport.Refresh();
            reportViewer.RefreshReport();
        }

    }
}
