using LiqViajes_Bll_Data;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using WhatsAppApi;

using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using System.IO;
using System.Drawing.Drawing2D;
using System.Drawing.Text;

namespace MetalLiqViajes_Forms
{
    public partial class fReportesViajes : Form
    {

        GMarkerGoogle marker;
        GMapOverlay markerOverlay;

        //Latitud	Longitud
        //9.530720	-75.418800
        double LatIncial = 9.530720;
        double lngInicial = -75.418800;
        private Providedor proveedor;
        private List<Conductor> ConductorList;
        private List<RutaSatrackHistoryEvents> historicoList;
        private RutaSatrackLastEvents SatracEvent;
        private List<RutaSatrackLastEvents> eventosList;
        private List<LiqViajes_Bll_Data.AnticiposDms> anticiposdmslist;
        private LiqViajes_Bll_Data.AnticiposDms anticiposdms;
        private List<LiqViajes_Bll_Data.RegistroViajeDTO> registroviajelist;
        private List<LiqViajes_Bll_Data.RegistroViajeDTO> registroviajelistFiltro;
        private LiqViajes_Bll_Data.RegistroViajeDTO iRegistroViajeDTO;
        private Conductor conductor;
        private List<LiqViajes_Bll_Data.TramosGastos> tramosGastosList;
        private List<TramosAsignadosRuta> tramosAsignadosList;
        private TramosAsignadosRuta tramosAsignados;
        private List<LiqViajes_Bll_Data.TercerosDTO> tercerosDTOList;
        private List<LiquidacionRutas> liquidacionrutaslist;
        private LiquidacionRutas liquidacionrutas;
        private LiquidacionGastos liquidacionGastos;
        private List<LiqViajes_Bll_Data.LiquidacionGastos> liquidacionGastosList { get; set; }
        private UtiliDRegistro utilidregistro;
        private UtilYear utilyear;
        private UtilMonth ultilmonth;
        private UtilPlaca ultilplaca;
        private ArrayList listplacas;
        private bool swtWsEnProceso;
        private string Nit { get; set; }
        private bool iCargaCompleta { get; set; }
        private int RowDataGridGasto { get; set; }
        private int RowGridConductor { get; set; }
        private int RowGridLiqViaje { get; set; }

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
            tablagLocal tablalocal = tablagLocalController.Instance.Get(1);
            int imes = 0;
            foreach (var item in MesesAño)
            {
                ultilmonth = new UtilMonth();
                ultilmonth.MonthName = MesesAño[imes].ToString();
                imes++;
                ultilmonth.MonthId = imes;
                ultilmonthlist.Add(ultilmonth);
            }

            comboBoxYear.DataSource = utilyearlist.OrderByDescending(o => o.YearId).ToList();
            comboBoxYear.SelectedValue = tablalocal.ano;
            comboBoxMonth.DataSource = ultilmonthlist.ToList();
            comboBoxMonth.SelectedIndex = (DateTime.Now.Month) - 1;
            comboBoxMonth.SelectedValue = tablalocal.periodo.Value;

            this.Cursor = Cursors.Default;

            btnQuitarFintro.Visible = false;

            iCargaCompleta = true;

            ultilmonth = comboBoxMonth.SelectedItem as UtilMonth;

            CargaRegistroViaje(utilyear.YearId);
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
                CargaExection(ex);
            }
        }

        private void btnAplicarCambio_Click(object sender, EventArgs e)
        {
            #region Valor Adicional Gasto

            if (liquidacionGastos.curValorAdicional != decimal.Parse(textBoxAdicional.Text.ToString()))
            {

                DataGridViewCell cellValue = dataGridViewLiqGastos.CurrentCell;
                if (!LiqViajes_Bll_Data.Helps.IsNumeric(textBoxAdicional.Text.ToString()))
                {
                    DialogResult result3 = MessageBox.Show("En registro debe ser numerico",
                        "Buscar un viaje en la base de datos",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information,
                        MessageBoxDefaultButton.Button1);
                    return;
                }

                // busca la fila que va a actualizar en la lista

                int index = liquidacionGastosList.FindIndex(t => t.intRowRegistro == liquidacionGastos.intRowRegistro);
                liquidacionGastos.GenerateUndo();

                liquidacionGastos.curValorAdicional = decimal.Parse(textBoxAdicional.Text.ToString());
                liquidacionGastosList[index].curValorAdicional = liquidacionGastos.curValorAdicional;

                string error = "";
                if (!LiquidacionGastosController.Instance.UpdateChanges(liquidacionGastos, out error))
                {
                    MessageBox.Show("Error Actualizado " + error, "Error actualizando la tabla  LiquidacionGastos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }


                index = liquidacionGastosList.FindIndex(t => t.intRowRegistro == 13);

                liquidacionGastosList[index].curValorTramo = liquidacionGastosList.Where(t => t.intRowRegistro == 10 || t.intRowRegistro == 11 || t.intRowRegistro == 12).Sum(s => s.curValorTramo.Value);
                liquidacionGastosList[index].curValorAdicional = liquidacionGastosList.Where(t => t.intRowRegistro == 10 || t.intRowRegistro == 11 || t.intRowRegistro == 12).Sum(s => s.curValorAdicional.Value);
                liquidacionGastosList[index].curValorTotal = liquidacionGastosList.Where(t => t.intRowRegistro == 10 || t.intRowRegistro == 11 || t.intRowRegistro == 12).Sum(s => s.curValorTotal.Value);

                // gridview1.row(0).cell(0).text = textbox1.text;
                dataGridViewLiqGastos.Refresh();// //. .rows[RowDataGridGasto].

            }
            #endregion

            #region observaciones
            if (liquidacionGastos.strObservaciones != textBoxAdicional.Text)
            {
                int index = liquidacionGastosList.FindIndex(t => t.intRowRegistro == liquidacionGastos.intRowRegistro);

                liquidacionGastos.GenerateUndo();
                liquidacionGastos.strObservaciones = "";
                liquidacionGastosList[index].strObservaciones = "";
                string error = "";
                if (!LiquidacionGastosController.Instance.UpdateChanges(liquidacionGastos, out error))
                    MessageBox.Show("Error Actualizado " + error, "Error actualizando la tabla  LiquidacionGastos", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            #endregion

        }

        private void btnQuitarFintro_Click(object sender, EventArgs e)
        {
            dataGridViewViajes.DataSource = registroviajelist;
            dataGridViewViajes.Refresh();

            btnQuitarFintro.Visible = false;
            dataGridViewConductor.Enabled = true;

        }

        private void btnSatrac_Click(object sender, EventArgs e)
        {
            CargarUltimaUbicacion();
        }

        private void gMapControl_DoubleClick(object sender, EventArgs e)
        {
            gMapControl.Zoom++;
            PointLatLng point;
            point = new PointLatLng(Convert.ToDouble(SatracEvent.Latitud), Convert.ToDouble(SatracEvent.Longitud));
            gMapControl.Position = new PointLatLng(Convert.ToDouble(SatracEvent.Latitud), Convert.ToDouble(SatracEvent.Longitud));

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
            RowGridLiqViaje = e.RowIndex;
            iRegistroViajeDTO = dataGridViewViajes.Rows[e.RowIndex].DataBoundItem as LiqViajes_Bll_Data.RegistroViajeDTO;

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

            TituloRegistro();
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
            RowGridConductor = e.RowIndex;
            conductor = dataGridViewConductor.Rows[e.RowIndex].DataBoundItem as Conductor;
            registroviajelistFiltro = registroviajelist.Where(p => p.NitConductor == conductor.Cedula.ToString()).ToList();
            dataGridViewViajes.DataSource = registroviajelistFiltro;
            dataGridViewViajes.Refresh();
        }

        private void dataGridViewLiqGastos_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            RowDataGridGasto = e.RowIndex;

            liquidacionGastos = dataGridViewLiqGastos.Rows[e.RowIndex].DataBoundItem as LiquidacionGastos;

            decimal numero = decimal.Parse(liquidacionGastos.curValorTramo.ToString());
            textBoxValor.Text = numero.ToString("N0");

            numero = decimal.Parse(liquidacionGastos.curValorAdicional.ToString());
            textBoxAdicional.Text = numero.ToString("N0");

            numero = decimal.Parse(liquidacionGastos.curValorTotal.ToString());
            textBoxTotal.Text = numero.ToString("N0");

            textBoxObservacion.Text = liquidacionGastos.strObservaciones.ToUpper();

            labelTituloRegistroGasto.Text = liquidacionGastos.strDescripcion.ToUpper();
            if (liquidacionGastos.nitTercero != null)
            {
                #region comboBoxTerceros

                long INit = long.Parse(liquidacionGastos.nitTercero);
                LiqViajes_Bll_Data.TercerosDTO terceroDto = tercerosDTOList.Where(t => t.Nit == INit).FirstOrDefault();
                if (terceroDto != null)
                {
                    comboBoxTerceros.SelectedItem = terceroDto;
                }
                else
                {
                    comboBoxTerceros.SelectedIndex = 0;

                }
                switch (liquidacionGastos.intRowRegistro)
                {
                    case 1:
                    case 2:
                    case 3:
                    case 4:
                    case 5:
                    case 6:
                    case 13:
                    case 14:
                    case 16:
                    case 17:
                    case 23:
                    case 27:
                    case 28:
                    case 29:
                    case 990:
                        btnAplicarCambio.Visible = false;
                        break;
                    default:
                        btnAplicarCambio.Visible = true;
                        break;
                }
                #endregion
            }
            else
            {
                comboBoxTerceros.Visible = false;
                btnAplicarCambio.Visible = false;
            }


        }

        private void fReportesViajes_Load(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < dataGridViewLiqGastos.ColumnCount; i++)
                {
                    string name = dataGridViewLiqGastos.Columns[i].DataPropertyName;
                    if (name == "curValorAdicional")
                    {
                        dataGridViewLiqGastos.Columns[i].ReadOnly = false;
                    }
                    else
                    {
                        dataGridViewLiqGastos.Columns[i].ReadOnly = true;
                    }
                }

                tercerosDTOList = LiqViajes_Bll_Data.TercerosController.Instance.GetByTercerosDms();
                comboBoxTerceros.DataSource = tercerosDTOList;
                comboBoxTerceros.SelectedIndex = 0;
                comboBoxTerceros.Refresh();

                comboBoxProveedor.Items.Clear();
                List<Providedor> ProvedorList = new List<Providedor>();
                proveedor = new Providedor();
                proveedor.Nombre = "Normal";
                ProvedorList.Add(proveedor);

                proveedor = new Providedor();
                proveedor.Nombre = "Satelitar";
                ProvedorList.Add(proveedor);

                proveedor = new Providedor();
                proveedor.Nombre = "Releve";
                ProvedorList.Add(proveedor);

                proveedor = new Providedor();
                proveedor.Nombre = "Calle";
                ProvedorList.Add(proveedor);



                comboBoxProveedor.DataSource = ProvedorList;
                comboBoxProveedor.DisplayMember = "Nombre";
                comboBoxProveedor.ValueMember = "Nombre";
                comboBoxProveedor.Refresh();

                numericUpDownMarcadores.Value = Properties.Settings.Default.CantidadMarcadores;
                numericUpDownDias.Value = Properties.Settings.Default.DiasHistorico;
            }
            catch (Exception ex)
            {
                CargaExection(ex);
            }
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
                    if (tramosAsignadosList == null)
                    {
                        CargarDatosDetalle();
                    }
                    else
                    {
                        if (tramosAsignadosList.FirstOrDefault().Registro != iRegistroViajeDTO.IdRegistro)
                        {
                            CargarDatosDetalle();
                        }
                    }
                }
                catch (Exception ex)
                {
                    CargaExection(ex);
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

                    liquidacionGastosList = LiqViajes_Bll_Data.LiquidacionGastosController.Instance.GetBy_lngIdRegistrRuta(tramosAsignados.RegistroId);

                    LiqViajes_Bll_Data.LiquidacionGastos liqgastos = new LiquidacionGastos();
                    liqgastos.intRowRegistro = 990;
                    liqgastos.strCuenta = "";
                    liqgastos.strDescripcion = "";
                    liqgastos.strDescripcionCuenta = "000_Total General";
                    liqgastos.strObservaciones = "";
                    liqgastos.curValorTramo = 0;// liquidacionGastosList.Sum(t => t.curValorTramo);
                    liqgastos.curValorAdicional = 0;//liquidacionGastosList.Sum(t => t.curValorAdicional);
                    liqgastos.curValorTotal = 0;//liquidacionGastosList.Sum(t => t.curValorTotal);

                    foreach (var item in liquidacionGastosList)
                    {

                        switch (item.intRowRegistro)
                        {
                            case 1:
                            case 2:
                            case 3:
                            case 4:
                            case 5:
                            case 6:
                            case 13:
                            case 14:
                            case 16:
                            case 17:
                            case 23:
                            case 27:
                            case 28:
                            case 29:
                                break;
                            default:
                                liqgastos.curValorTramo += item.curValorTramo.Value;
                                liqgastos.curValorAdicional += item.curValorAdicional.Value;
                                liqgastos.curValorTotal += item.curValorTotal.Value;
                                break;
                        }
                    }

                    int index = liquidacionGastosList.FindIndex(t => t.intRowRegistro == 13);

                    liquidacionGastosList[index].curValorTramo = liquidacionGastosList.Where(t => t.intRowRegistro == 10 || t.intRowRegistro == 11 || t.intRowRegistro == 12).Sum(s => s.curValorTramo.Value);
                    liquidacionGastosList[index].curValorAdicional = liquidacionGastosList.Where(t => t.intRowRegistro == 10 || t.intRowRegistro == 11 || t.intRowRegistro == 12).Sum(s => s.curValorAdicional.Value);
                    liquidacionGastosList[index].curValorTotal = liquidacionGastosList.Where(t => t.intRowRegistro == 10 || t.intRowRegistro == 11 || t.intRowRegistro == 12).Sum(s => s.curValorTotal.Value);


                    liquidacionGastosList.Add(liqgastos);

                    dataGridViewLiqGastos.DataSource = liquidacionGastosList.ToList();

                    // Resize the master DataGridView columns to fit the newly loaded data.
                    dataGridViewLiqGastos.AutoResizeColumns();

                    // Configure the details DataGridView so that its columns automatically
                    // adjust their widths when the data changes.
                    dataGridViewLiqGastos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;


                }
                catch (Exception ex)
                {
                    CargaExection(ex);
                }

            }

            if (tabControl.SelectedIndex == 3)
            {
                try
                {
                    CargarReporte();
                }
                catch (Exception ex)
                {
                    CargaExection(ex);
                }

            }
            if (tabControl.SelectedIndex == 4)
            {
                CargarMapa();
                timer1.Enabled = true;
            }


        }

        private void textBoxValor_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string valorTexto = textBoxValor.Text.Replace(",", "");
                if (valorTexto != "")
                {
                    decimal valor = decimal.Parse(valorTexto);
                    string st = textBoxValor.Text.Replace(",", "");
                    if (st != "")
                    {
                        try
                        {
                            bool final = false;
                            int pos = textBoxValor.SelectionStart;
                            final = (pos == textBoxValor.Text.Length);
                            double numero = Convert.ToDouble(textBoxValor.Text);
                            textBoxValor.Text = numero.ToString("N0");
                            if (final) pos++;
                            textBoxValor.SelectionStart = pos;
                        }
                        catch
                        {
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: Debe ingresar un valor numérico", "Jurídico", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBoxValor.Text = "";
                textBoxValor.Refresh();
            }
        }

        private void dataGridViewLiqGastos_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            for (int i = 0; i < dataGridViewLiqGastos.RowCount; i++)
            {
                LiquidacionGastos liqgastos = dataGridViewLiqGastos.Rows[i].DataBoundItem as LiquidacionGastos;
                switch (liqgastos.intRowRegistro)
                {

                    case 10:
                    case 11:
                    case 12:

                        System.Windows.Forms.DataGridViewCellStyle norStyle = new System.Windows.Forms.DataGridViewCellStyle();
                        norStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
                        dataGridViewLiqGastos.Rows[i].DefaultCellStyle = norStyle;

                        dataGridViewLiqGastos.Rows[i].DefaultCellStyle.BackColor = Color.MintCream;
                        break;
                    case 13:
                        dataGridViewLiqGastos.Rows[i].DefaultCellStyle.BackColor = Color.Orange;
                        break;
                    case 14:
                    case 16:
                    case 17:
                    case 23:
                    case 27:
                    case 28:
                    case 29:
                        dataGridViewLiqGastos.Rows[i].DefaultCellStyle.BackColor = Color.Moccasin;
                        dataGridViewLiqGastos.Rows[i].Visible = false;
                        break;
                    case 990:
                        dataGridViewLiqGastos.Rows[i].DefaultCellStyle.BackColor = Color.SlateBlue;
                        break;
                    default:
                        break;
                }
            }
        }

        private void CargaRegistroViaje(int Ano, bool iRefrescar = true)
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
            ConductorList = new List<Conductor>();

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
            if (!iRefrescar)
            {
                dataGridViewConductor.Refresh();
            }

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

        private void TituloRegistro()
        {
            this.Text = "Viaje: " + iRegistroViajeDTO.IdRegistro + " - Conductor : " + iRegistroViajeDTO.NombreConductor;
        }

        private void CargarDatosDetalle()
        {
            tramosAsignadosList = TramosAsignadosRutaController.Instance.GetBy_lngIdRegistro(int.Parse(iRegistroViajeDTO.IdRegistro.ToString()));
            tramosAsignadosList = tramosAsignadosList.Where(t => t.logAjuste.Value == false).OrderBy(o => o.RegistroId).ToList();
            dataGridViewLiqRutas.DataSource = tramosAsignadosList.ToList();
            dataGridViewLiqRutas.Refresh();

            //Nit = iRegistroViajeDTO.NitConductor;
            //anticiposdmslist = LiqViajes_Bll_Data.AnticiposDmsController.Instance.GetBy_DocumentoNit(long.Parse(iRegistroViajeDTO.NitConductor), iRegistroViajeDTO.IdRegistro).ToList();

            //anticiposdms = new AnticiposDms();
            //anticiposdms.Dms_Chk = 0;
            //anticiposdms.Dms_ValorAnticipo = anticiposdmslist.Sum(s => s.Dms_ValorAnticipo.Value);
            //anticiposdms.Dms_ValorAplicado = anticiposdmslist.Sum(s => s.Dms_ValorAplicado.Value);
            //anticiposdms.Dms_ValorTotal = anticiposdmslist.Sum(s => s.Dms_ValorTotal.Value);
            //anticiposdmslist.Add(anticiposdms);

            //dataGridViewAnticipo.DataSource = anticiposdmslist.ToList();
            //dataGridViewAnticipo.Refresh();
        }

        private void CargarReporte()
        {
            this.reportViewer.RefreshReport();

            long lngIdRegistro = iRegistroViajeDTO.IdRegistro;
            LiqViajes_Bll_Data.LiquidacionVehiculo LiquidacionVehiculo = LiqViajes_Bll_Data.LiquidacionVehiculoController.Instance.Get(int.Parse(lngIdRegistro.ToString()));

            LiqViajes_Bll_Data.VehiculoCCosto vehiculos = LiqViajes_Bll_Data.VehiculoCCostoController.Instance.GetByPlaca(LiquidacionVehiculo.strPlaca);

            List<LiqViajes_Bll_Data.TramosReportesLiqVehiculos> tramosReporteLiqVehiculosList = LiqViajes_Bll_Data.TramosReportesLiqVehiculosController.Instance.GetBy_Registro(lngIdRegistro);

            List<LiqViajes_Bll_Data.TramosConsultaAnticipos> tramosconsultaanticipoList = LiqViajes_Bll_Data.TramosConsultaAnticiposController.Instance.GetBy_RegistroViaje(lngIdRegistro);
            tramosconsultaanticipoList = tramosconsultaanticipoList.OrderBy(o => o.Fecha).ToList();

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

        public static void CargaExection(Exception ex)
        {
            DialogResult result3 = MessageBox.Show(ex.Message,
               "Error Cargando Datos",
               MessageBoxButtons.OK,
               MessageBoxIcon.Information,
               MessageBoxDefaultButton.Button1);
        }

        private void btnGetMaps_Click(object sender, EventArgs e)
        {
            CargarMapa();
        }

        private void CargarMapa(string placa = "")
        {
            try
            {

                if (tabControl.SelectedIndex != 4) return;

                gMapControl.DragButton = MouseButtons.Left;
                gMapControl.Overlays.Clear();
                gMapControl.CanDragMap = true;
                DefinaProveedor();
                gMapControl.Position = new PointLatLng(LatIncial, lngInicial);
                gMapControl.MinZoom = 0;
                gMapControl.MaxZoom = 24;
                gMapControl.Zoom = 12;

                gMapControl.AutoScroll = true;

                // marcadores

                markerOverlay = new GMapOverlay("Marcador");
                if (placa == "")
                {
                    eventosList = RutaSatrackLastEventsController.Instance.GetAll().ToList();
                }
                else
                {
                    RutaSatrackLastEvents evento = RutaSatrackLastEventsController.Instance.Get(placa);
                    eventosList = new List<RutaSatrackLastEvents>();
                    eventosList.Add(evento);
                }

                // llena el grid con los datos de cada mula

                dataGridViewEvents.DataSource = eventosList;
                dataGridViewEvents.Refresh();

                // Resize the master DataGridView columns to fit the newly loaded data.
                dataGridViewEvents.AutoResizeColumns();

                // Configure the details DataGridView so that its columns automatically
                // adjust their widths when the data changes.
                dataGridViewEvents.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

                foreach (var item in eventosList)
                {

                    LatIncial = Convert.ToDouble(item.Latitud);
                    lngInicial = Convert.ToDouble(item.Longitud);

                    //Image placaImag = stringToImage(item.Placa);
                    Bitmap BitmapImage = CreateBitmapImage(item.Placa);

                    marker = new GMarkerGoogle(new PointLatLng(LatIncial, lngInicial), BitmapImage);
                    //marker = new GMarkerGoogle(new PointLatLng(LatIncial, lngInicial), new Bitmap(Properties.Resources._1));
                    //marker = new GMarkerGoogle(new PointLatLng(LatIncial, lngInicial), new Bitmap(placaImag));
                    //marker = new GMarkerGoogle(new PointLatLng(LatIncial, lngInicial),GMarkerGoogleType.green);
                    //marker = new GMarkerGoogle(new PointLatLng(LatIncial, lngInicial), new Bitmap(@"D:\Genaro\Metal\MetalMod\GoogleMapControl\icons\FireTruck.png"));//GMarkerGoogleType.green);


                    markerOverlay.Markers.Add(marker); // agregamos al mapa
                    marker.ToolTipMode = MarkerTooltipMode.OnMouseOver; // para que se muestre todo el tiempo {Always}
                    marker.ToolTipText = string.Format("Placa: {0} \nUbicación: {1}, \nVelocidad: {2}", item.Placa, item.Ubicacion, item.VelocidadSentido);

                    // ahora agregamos el mapa y el marcador al map control.
                    gMapControl.Overlays.Add(markerOverlay);

                }
            }
            catch (Exception ex)
            {
                CargaExection(ex);
            }
        }

        public Image stringToImage(string inputString)
        {
            byte[] imageBytes = Encoding.Unicode.GetBytes(inputString);
            MemoryStream ms = new MemoryStream(imageBytes, 0, imageBytes.Length);

            ms.Write(imageBytes, 0, imageBytes.Length);
            Image image = Image.FromStream(ms, true, true);

            return image;
        }

        private Bitmap CreateBitmapImage(string sImageText)
        {

            sImageText = "   " + sImageText;

            Bitmap objBmpImage = new Bitmap(1, 1);

            int intWidth = 0;
            int intHeight = 0;

            // Create the Font object for the image text drawing.
            Font objFont = new Font("Arial", 11, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);

            // Create a graphics object to measure the text's width and height.
            Graphics objGraphics = Graphics.FromImage(objBmpImage);

            // This is where the bitmap size is determined.
            intWidth = (int)objGraphics.MeasureString(sImageText, objFont).Width;
            intHeight = (int)objGraphics.MeasureString(sImageText, objFont).Height;

            // Create the bmpImage again with the correct size for the text and font.
            objBmpImage = new Bitmap(objBmpImage, new Size(intWidth, intHeight));


            // Add the colors to the new bitmap.
            objGraphics = Graphics.FromImage(objBmpImage);


            // Create image.
            //Image imageFile = Image.FromFile("SampImag.jpg");
            //Image imageFile = Image.FromFile(@"C:\Metal\images\1.png");

            Image imageFile = (Image)(Properties.Resources._11);

            // Create graphics object for alteration.
            Graphics newGraphics = Graphics.FromImage(imageFile);

            // Alter image.
            newGraphics.FillRectangle(new SolidBrush(Color.Black), 100, 50, 0, 0);


            // Set Background color
            objGraphics.Clear(Color.Yellow);
            objGraphics.SmoothingMode = SmoothingMode.AntiAlias;
            objGraphics.TextRenderingHint = TextRenderingHint.AntiAlias;
            objGraphics.DrawString(sImageText, objFont, new SolidBrush(Color.FromArgb(102, 102, 102)), 0, 0);
            // Draw image to screen.
            objGraphics.DrawImage(imageFile, new PointF(0.0F, 0.0F));
            objGraphics.Flush();

            return (objBmpImage);
        }

        private void GeneraRuta(string placa = "")
        {
            GMapOverlay Ruta = new GMapOverlay("Ruta");

            List<PointLatLng> Puntos = new List<PointLatLng>();
            List<RutaSatrackLastEvents> eventosList;
            double lat, lng;
            double latAnt = 0, lngAnt = 0;
            if (placa == "")
            {
                eventosList = RutaSatrackLastEventsController.Instance.GetAll().ToList();
            }
            else
            {
                RutaSatrackLastEvents evento = RutaSatrackLastEventsController.Instance.Get(placa);
                eventosList = new List<RutaSatrackLastEvents>();
                eventosList.Add(evento);
            }

            foreach (var item in eventosList)
            {
                lat = double.Parse(item.Latitud.ToString());
                lng = double.Parse(item.Longitud.ToString());

                if (latAnt == 0)
                {
                    latAnt = double.Parse(item.Latitud.ToString());
                    lngAnt = double.Parse(item.Longitud.ToString());
                }
                if (lat != latAnt)
                {
                    Puntos.Add(new PointLatLng(double.Parse(item.Latitud.ToString()), double.Parse(item.Longitud.ToString())));
                    latAnt = double.Parse(item.Latitud.ToString());
                    lngAnt = double.Parse(item.Longitud.ToString());
                }

            }

            GMapRoute PuntoRutas = new GMapRoute(Puntos, "Ruta");
            Ruta.Routes.Add(PuntoRutas);
            gMapControl.Overlays.Add(Ruta);

            // actualiza el mapa
            gMapControl.Zoom = gMapControl.Zoom + 1;
            gMapControl.Zoom = gMapControl.Zoom - 1;

        }

        private void comboBoxProveedor_SelectedIndexChanged(object sender, EventArgs e)
        {
            proveedor = comboBoxProveedor.SelectedItem as Providedor;
            DefinaProveedor();

        }

        private void DefinaProveedor()
        {
            if (proveedor.Nombre == "Normal")
            {
                gMapControl.MapProvider = GMapProviders.GoogleMap;
            }
            if (proveedor.Nombre == "Satelitar")
            {
                gMapControl.MapProvider = GMapProviders.GoogleChinaSatelliteMap;
            }
            if (proveedor.Nombre == "Releve")
            {
                gMapControl.MapProvider = GMapProviders.GoogleTerrainMap;
            }
            if (proveedor.Nombre == "Calle")
            {
                gMapControl.MapProvider = GMapProviders.OpenStreetMap;
            }


        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            trackBarZoom.Value = Convert.ToInt32(gMapControl.Zoom);
        }

        private void btnInterrogar_Click(object sender, EventArgs e)
        {
            CargarUltimaUbicacion();
            CargarMapa();
        }

        private void btnRuta_Click(object sender, EventArgs e)
        {

            CargarMapa(SatracEvent.Placa);
            PointLatLng point;
            point = new PointLatLng(Convert.ToDouble(SatracEvent.Latitud), Convert.ToDouble(SatracEvent.Longitud));
            gMapControl.Position = new PointLatLng(Convert.ToDouble(SatracEvent.Latitud), Convert.ToDouble(SatracEvent.Longitud));

            int Tope = 0;
            GMapOverlay routes = new GMapOverlay("routes");
            List<PointLatLng> points = new List<PointLatLng>();
            foreach (var item in historicoList)
            {
                if (Tope > 12) break;
                if (points.Count == 0)
                {
                    point = new PointLatLng(Convert.ToDouble(item.Latitud), Convert.ToDouble(item.Longitud));
                    points.Add(point);
                    marker = new GMarkerGoogle(new PointLatLng(Convert.ToDouble(item.Latitud), Convert.ToDouble(item.Longitud)), GMarkerGoogleType.blue);
                    markerOverlay.Markers.Add(marker); // agregamos al mapa
                    marker.ToolTipMode = MarkerTooltipMode.OnMouseOver; // para que se muestre todo el tiempo {Always}
                    marker.ToolTipText = string.Format("Placa: {0} \nUbicación: {1}, \nVelocidad: {2}", item.Placa, item.Ubicacion, item.VelocidadSentido);
                    Tope++;
                    continue;
                }

                point = new PointLatLng(Convert.ToDouble(item.Latitud), Convert.ToDouble(item.Longitud));
                if (!points.Contains(point))
                {
                    points.Add(point);
                    marker = new GMarkerGoogle(new PointLatLng(Convert.ToDouble(item.Latitud), Convert.ToDouble(item.Longitud)), GMarkerGoogleType.blue);
                    markerOverlay.Markers.Add(marker); // agregamos al mapa
                    marker.ToolTipMode = MarkerTooltipMode.OnMouseOver; // para que se muestre todo el tiempo {Always}
                    marker.ToolTipText = string.Format("Placa: {0} \nUbicación: {1}, \nVelocidad: {2}", item.Placa, item.Ubicacion, item.VelocidadSentido);
                    Tope++;
                }
                else
                {

                }
            }

            // ahora agregamos el mapa y el marcador al map control.
            gMapControl.Overlays.Add(markerOverlay);


            GMapRoute route = new GMapRoute(points, SatracEvent.Placa);
            route.Stroke = new Pen(Color.Red, 3);
            routes.Routes.Add(route);
            gMapControl.Overlays.Add(routes);
            gMapControl.Zoom = gMapControl.Zoom + 1;
            gMapControl.Zoom = gMapControl.Zoom - 1;

        }

        private void trackBarZoom_ValueChanged(object sender, EventArgs e)
        {
            gMapControl.Zoom = trackBarZoom.Value;
        }

        private void gMapControl_MouseClick(object sender, MouseEventArgs e)
        {

            //double lat = gMapControl.FromLocalToLatLng(e.X, e.Y).Lat;
            //double lng = gMapControl.FromLocalToLatLng(e.X, e.Y).Lng;
            //txtLatituda.Text = lat.ToString();
            //txtLongitud.Text = lng.ToString();
            //marker.Position = new PointLatLng(lat, lng);
            //marker.ToolTipText = string.Format("Koordinate: \n Latituda {0} \n Longituda {1}", lat, lng);

        }


        private void CargarUltimaUbicacion()
        {
            try
            {
                if (swtWsEnProceso) return;

                swtWsEnProceso = true;
                string Placa = "";
                listplacas = new ArrayList();
                List<VehiculoCCosto> vehiculosCentroCostoList = VehiculoCCostoController.Instance.GetAll().Where(t => (t.TipoVehiculoCodigo.Value == 1 || t.TipoVehiculoCodigo.Value == 3) && (t.logActivo.Value == 1)).ToList();
                foreach (var item in vehiculosCentroCostoList)
                {
                    Placa = item.strPlaca.Replace("-", "");
                    listplacas.Add(Placa);
                }
                EventsSatrac.getEvents servicio = new EventsSatrac.getEvents();
                DataTable dt;
                string UserName = Properties.Settings.Default.UserName;
                string Password = Properties.Settings.Default.Password;
                string PhysicalID = "*";
                decimal Latutud = 0;
                decimal Longitud = 0;
                string error = "";

                #region getLastEvent
                RutaSatrackLastEvents m_RutaSatrackLastEvents;
                RutaSatrackHistoryEvents m_RutaSatrackHistoryEvents;
                System.Data.DataSet datosPlaca = servicio.getLastEvent(UserName, Password, PhysicalID);
                if (datosPlaca.Tables.Count > 0)
                {
                    dt = datosPlaca.Tables[0];
                    if (dt != null)
                    {
                        foreach (DataRow dr in dt.Rows)
                        {
                            Placa = (string)dr["Placa"];

                            if (listplacas.Contains((string)dr["Placa"]))
                            {
                                Longitud = (decimal)dr["Longitud"];
                                Latutud = (decimal)dr["Latitud"];

                                m_RutaSatrackLastEvents = RutaSatrackLastEventsController.Instance.Get(Placa);
                                if (m_RutaSatrackLastEvents != null)
                                {
                                    if ((m_RutaSatrackLastEvents.Latitud.Value != Latutud) && (m_RutaSatrackLastEvents.Longitud.Value != Longitud))
                                    {
                                        m_RutaSatrackHistoryEvents = new RutaSatrackHistoryEvents();
                                        m_RutaSatrackHistoryEvents.Placa = m_RutaSatrackLastEvents.Placa;
                                        m_RutaSatrackHistoryEvents.FechaSistema = m_RutaSatrackLastEvents.FechaSistema;
                                        m_RutaSatrackHistoryEvents.FechaHora_GPS = m_RutaSatrackLastEvents.FechaHora_GPS;
                                        m_RutaSatrackHistoryEvents.EventoPrioridad = m_RutaSatrackLastEvents.EventoPrioridad;
                                        m_RutaSatrackHistoryEvents.VelocidadSentido = m_RutaSatrackLastEvents.VelocidadSentido;
                                        m_RutaSatrackHistoryEvents.Edad_Posicion = m_RutaSatrackLastEvents.Edad_Posicion;
                                        m_RutaSatrackHistoryEvents.Ubicacion = m_RutaSatrackLastEvents.Ubicacion;
                                        m_RutaSatrackHistoryEvents.Longitud = m_RutaSatrackLastEvents.Longitud;
                                        m_RutaSatrackHistoryEvents.Latitud = m_RutaSatrackLastEvents.Latitud;
                                        RutaSatrackHistoryEventsController.Instance.Create(m_RutaSatrackHistoryEvents);

                                        //------------------------------------
                                        // actualiza una placa y genera el historico
                                        m_RutaSatrackLastEvents.GenerateUndo();
                                        m_RutaSatrackLastEvents.FechaSistema = (DateTime)dr["Fecha Sistema"];
                                        m_RutaSatrackLastEvents.FechaHora_GPS = (DateTime)dr["Fecha GPS"];
                                        m_RutaSatrackLastEvents.EventoPrioridad = (string)dr["Evento / Prioridad"];
                                        m_RutaSatrackLastEvents.VelocidadSentido = (string)dr["Velocidad y sentido"];
                                        m_RutaSatrackLastEvents.Edad_Posicion = (string)dr["Edad posición"];
                                        m_RutaSatrackLastEvents.Ubicacion = (string)dr["Ubicación"];
                                        m_RutaSatrackLastEvents.Longitud = (decimal)dr["Longitud"];
                                        m_RutaSatrackLastEvents.Latitud = (decimal)dr["Latitud"];
                                        error = "";
                                        if (!RutaSatrackLastEventsController.Instance.UpdateChanges(m_RutaSatrackLastEvents, out error))
                                        {
                                            //
                                        }
                                    }
                                    else
                                    {

                                    }
                                }
                                else
                                {
                                    // llegan las placas nuevas
                                    RutaSatrackLastEvents iRutaSatrackLastEvents = new RutaSatrackLastEvents();
                                    iRutaSatrackLastEvents.Placa = (string)dr["Placa"];
                                    iRutaSatrackLastEvents.FechaSistema = (DateTime)dr["Fecha Sistema"];
                                    iRutaSatrackLastEvents.FechaHora_GPS = (DateTime)dr["Fecha GPS"];
                                    iRutaSatrackLastEvents.EventoPrioridad = (string)dr["Evento / Prioridad"];
                                    iRutaSatrackLastEvents.VelocidadSentido = (string)dr["Velocidad y sentido"];
                                    iRutaSatrackLastEvents.Edad_Posicion = (string)dr["Edad posición"];
                                    iRutaSatrackLastEvents.Ubicacion = (string)dr["Ubicación"];
                                    iRutaSatrackLastEvents.Longitud = (decimal)dr["Longitud"];
                                    iRutaSatrackLastEvents.Latitud = (decimal)dr["Latitud"];
                                    RutaSatrackLastEventsController.Instance.Create(iRutaSatrackLastEvents);
                                }
                            }
                        }
                    }
                }
                swtWsEnProceso = false;
                return;
                #endregion

            }
            catch (Exception ex)
            {
                swtWsEnProceso = false;
            }
        }

        private void dataGridViewEvents_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            DateTime fechainicial = DateTime.Now.AddDays(-Convert.ToDouble(numericUpDownDias.Value));
            SatracEvent = dataGridViewEvents.Rows[e.RowIndex].DataBoundItem as RutaSatrackLastEvents;

            DateTime fecha1 = DateTime.Parse(fechainicial.ToLongDateString() + " 00:00:00");
            DateTime fecha2 = DateTime.Parse(DateTime.Now.ToLongDateString() + " 23:59:00");

            List<RutaSatrackHistoryEvents> historicoEventsoList = RutaSatrackHistoryEventsController.Instance.GetByPlacaFecha(SatracEvent.Placa, fecha1, fecha2).ToList();
            historicoList = new List<RutaSatrackHistoryEvents>();
            bool cargainicial = false;
            DateTime fecha = DateTime.Now;
            decimal latitud = 0, longitud = 0;
            foreach (var item in historicoEventsoList)
            {
                if (!cargainicial)
                {
                    fecha = item.FechaHora_GPS.Value;
                    latitud = item.Latitud.Value;
                    longitud = item.Longitud.Value;
                    cargainicial = true;
                    historicoList.Add(item);
                    continue;
                }

                bool x = (item.Placa == SatracEvent.Placa
                            && item.FechaHora_GPS.Value == fecha
                            && item.Latitud.Value == latitud
                            && item.Longitud.Value == longitud);
                if (!x)
                {
                    fecha = item.FechaHora_GPS.Value;
                    latitud = item.Latitud.Value;
                    longitud = item.Longitud.Value;
                    cargainicial = true;
                    historicoList.Add(item);
                }

            }

            dataGridViewHistoryEvents.DataSource = historicoList;
            dataGridViewHistoryEvents.Refresh();


            // Resize the master DataGridView columns to fit the newly loaded data.
            dataGridViewHistoryEvents.AutoResizeColumns();

            // Configure the details DataGridView so that its columns automatically
            // adjust their widths when the data changes.
            dataGridViewHistoryEvents.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;


            //MarcarRuta(SatracEvent, historicoList);

            PointLatLng point;
            point = new PointLatLng(Convert.ToDouble(SatracEvent.Latitud), Convert.ToDouble(SatracEvent.Longitud));
            gMapControl.Position = new PointLatLng(Convert.ToDouble(SatracEvent.Latitud), Convert.ToDouble(SatracEvent.Longitud));

        }

        private void MarcarRuta(RutaSatrackLastEvents SatracEvent, List<RutaSatrackHistoryEvents> historicoList)
        {
            GMapOverlay Ruta = new GMapOverlay("Ruta");

            gMapControl.Zoom = 8;
            gMapControl.Overlays.Clear();

            markerOverlay = new GMapOverlay("Marcador");

            List<PointLatLng> Puntos = new List<PointLatLng>();

            Puntos.Add(new PointLatLng(double.Parse(SatracEvent.Latitud.ToString()), double.Parse(SatracEvent.Longitud.ToString())));
            GMapRoute PuntoRutas = new GMapRoute(Puntos, "Ruta");
            Ruta.Routes.Add(PuntoRutas);
            gMapControl.Overlays.Add(Ruta);

            //-----------------------------------------------

            GMapOverlay routes = new GMapOverlay("routes");
            List<PointLatLng> points = new List<PointLatLng>();
            foreach (var item in historicoList)
            {
                points.Add(new PointLatLng(Convert.ToDouble(item.Latitud), Convert.ToDouble(item.Longitud)));
            }

            GMapPolygon polygon = new GMapPolygon(points, "Jardin des Tuileries");
            routes.Polygons.Add(polygon);
            gMapControl.Overlays.Add(markerOverlay);
            gMapControl.Overlays.Add(routes);

            gMapControl.Zoom = gMapControl.Zoom + 1;
            gMapControl.Zoom = gMapControl.Zoom - 1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string from = "573017696263";
            string to = "";
            string msg = "";
            string txtPassword = "926-086";
            string txtName = "Genaro Rico Romero";

            string txtPhoneNumber = "573136023499";
            string txtMessage = "Prueba mensajeria WhatApps";
            WhatsAppApi.WhatsApp wa = new WhatsAppApi.WhatsApp(from, txtPassword, txtName, false, false);

            wa.OnConnectSuccess += () =>
            {
                //textBox1.Text += "\nConnected...!\n";
                wa.OnLoginSuccess += (phoneNumber, data) =>
                {
                    wa.SendMessage(txtPhoneNumber, txtMessage);
                    //textBox1.Text += "\nMessage Sent...!\n";
                };

                wa.OnLoginFailed += (data) =>
                {
                    //textBox1.Text += "\nLogin failed..." + data + " \n";
                };
                wa.Login();
            };
            wa.OnConnectFailed += (ex) =>
            {
                //textBox1.Text += "\nConnection failed...!\n";
            };
            wa.Connect();

        }

        private void btnCreaViaje_Click(object sender, EventArgs e)
        {

            this.Cursor = Cursors.WaitCursor;
            MetalLiqViajes_Forms.fMenuPrincipal c = (MetalLiqViajes_Forms.fMenuPrincipal)this.ParentForm;
            CrearViaje creaviaje = new CrearViaje();
            //creaviaje.MdiParent = this;
            creaviaje.conductor = conductor;
            if (creaviaje.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    DialogResult resultado = MessageBox.Show("Confirma crear el registro ahora?", "Validar Crear Registro", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
                    if (resultado == DialogResult.Yes)
                    {
                        //LiquidacionVehiculo liqVehiculo = new LiquidacionVehiculo();
                        //liqVehiculo.strPlaca = creaviaje.vehiculo.strPlaca;
                        //liqVehiculo.intNitConductor = Convert.ToDecimal(creaviaje.terceroconductor.IntNit);
                        //liqVehiculo.curGastos = 0;
                        //liqVehiculo.curAnticipos = 0;
                        //liqVehiculo.curTotal = 0;
                        //liqVehiculo.dtmFechaModif = DateTime.Now;
                        //liqVehiculo.logLiquidado = false;
                        //LiquidacionVehiculoController.Instance.Create(liqVehiculo);

                        //RowGridConductor
                        int m_index = RowGridConductor;
                        string cedula = conductor.Cedula.ToString();
                        // obtiene el año
                        ultilmonth = comboBoxMonth.SelectedItem as UtilMonth;

                        // carga de nuevo la lista de viajes toda
                        CargaRegistroViaje(utilyear.YearId, false);

                        //  ubica el conductor en el grid
                        dataGridViewConductor.ClearSelection();
                        dataGridViewConductor.Rows[m_index].Selected = true;
                        dataGridViewConductor.FirstDisplayedScrollingRowIndex = m_index;
                        dataGridViewConductor.Focus();

                        RowGridConductor = m_index;
                        conductor = dataGridViewConductor.Rows[m_index].DataBoundItem as Conductor;
                        registroviajelistFiltro = registroviajelist.Where(p => p.NitConductor == conductor.Cedula.ToString()).ToList();
                        dataGridViewViajes.DataSource = registroviajelistFiltro;
                        dataGridViewViajes.Refresh();

                    }
                }
                catch (Exception ex)
                {
                    CargaExection(ex);
                }
                this.Cursor = Cursors.Default;
            }
        }

        private void btnPruebaWhasaaps_Click(object sender, EventArgs e)
        {

            //SendMessage

        }

        public void SendMessage(string sendTo, string message)
        {
            var response = false;
            string from = "573136023499"; //(Enter Your Mobile Number)
            String password;
            var res = WhatsAppApi.Register.WhatsRegisterV2.RequestCode(from, out password);
            WhatsApp wa = new WhatsApp(from, password, "abc.com", false, false);
            wa.OnConnectSuccess += () =>
            {
                wa.OnLoginSuccess += (phonenumber, data) =>
                {
                    wa.SendMessage(sendTo, message);
                    response = true;
                };
                wa.OnLoginFailed += (data) =>
                {
                    response = false;
                };

                wa.Login();
            };
            wa.OnConnectFailed += (Exception) =>
            {
                response = false;
            };
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //RowGridConductor
            int m_index = Convert.ToInt32(textBox1.Text);

            //ConductorList.r .Select(t => t.Placa== conductor.Placa)


            string cedula = conductor.Cedula.ToString();


            // obtiene el año
            ultilmonth = comboBoxMonth.SelectedItem as UtilMonth;

            // carga de nuevo la lista de viajes toda
            CargaRegistroViaje(utilyear.YearId, false);

            //  ubica el conductor en el grid
            dataGridViewConductor.ClearSelection();
            dataGridViewConductor.Rows[m_index].Selected = true;
            dataGridViewConductor.FirstDisplayedScrollingRowIndex = m_index;
            dataGridViewConductor.Focus();

            RowGridConductor = m_index;
            conductor = dataGridViewConductor.Rows[m_index].DataBoundItem as Conductor;
            registroviajelistFiltro = registroviajelist.Where(p => p.NitConductor == conductor.Cedula.ToString()).ToList();
            dataGridViewViajes.DataSource = registroviajelistFiltro;
            dataGridViewViajes.Refresh();

        }
    }
}
