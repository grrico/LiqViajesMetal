using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MetalLiqViajesReporte
{
    public partial class ReporteViajes01 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {

                long lngIdRegistro = 12357;

                LabelTitulo.Text = LabelTitulo.Text.Replace("@NUMEROVIAJE", "12357");
                LabelFecha.Text = LabelFecha.Text.Replace("@FECHA", DateTime.Now.ToShortDateString());
                LabelPlaca.Text = LabelPlaca.Text.Replace("@PLACA", "tdz-583");
                LabelCCosto.Text = LabelCCosto.Text.Replace("@CCOSTO", "3016");
                LabelMarca.Text = LabelMarca.Text.Replace("@MARCA", "INTERNACIONAL");
                LabelModelo.Text = LabelModelo.Text.Replace("@MODELO", "2013");

                //  valores encabezado

                List<LiqViajes_Bll_Data.TramosReportesLiqVehiculos> tramosReporteLiqVehiculosList = LiqViajes_Bll_Data.TramosReportesLiqVehiculosController.Instance.GetBy_Registro(lngIdRegistro);

                LabelCedula.Text = "";
                LabelNombreConductor.Text = "";
                decimal anticipo = 0;
                decimal gastos = 0;
                decimal total = 0;
                decimal ValorFlete = 0;
                decimal ValorAnticipo = 0;
                decimal ValorTramos = 0;
                decimal ValorTotalTramos = 0;

                if (tramosReporteLiqVehiculosList.Count >= 1)
                {
                    LiqViajes_Bll_Data.TramosReportesLiqVehiculos tramosReporteLiqVehiculos = tramosReporteLiqVehiculosList.FirstOrDefault();
                    LabelCedula.Text = tramosReporteLiqVehiculos.CedulaConductor;
                    LabelNombreConductor.Text = tramosReporteLiqVehiculos.NombreConductor.ToUpper();

                    anticipo = tramosReporteLiqVehiculos.TotalAnticipos.Value;
                    gastos = tramosReporteLiqVehiculos.TotalGatos.Value;
                    total = tramosReporteLiqVehiculos.TotalGeneral.Value;

                }

                LabelAnticipo.Text = anticipo.ToString("n0");
                LabelGasto.Text = gastos.ToString("n0");
                LabelTotal.Text = total.ToString("n0");

                //  lista los tramos

                // fila 01
                System.Web.UI.HtmlControls.HtmlGenericControl createDiv01 = new System.Web.UI.HtmlControls.HtmlGenericControl("DIV");
                createDiv01.Attributes.Add("class", "row marco");

                System.Web.UI.HtmlControls.HtmlGenericControl createDiv02 = new System.Web.UI.HtmlControls.HtmlGenericControl("DIV");
                createDiv02.Attributes.Add("class", "col-md-4 text-uppercase");
                createDiv02.InnerHtml = "Tramos Liquidados";
                createDiv01.Controls.Add(createDiv02);

                createDiv02 = new System.Web.UI.HtmlControls.HtmlGenericControl("DIV");
                createDiv02.Attributes.Add("class", "col-md-4 text-uppercase");
                createDiv02.InnerHtml = "Planilla";
                createDiv01.Controls.Add(createDiv02);

                createDiv02 = new System.Web.UI.HtmlControls.HtmlGenericControl("DIV");
                createDiv02.Attributes.Add("class", "col-md-4 text-uppercase text-right");
                createDiv02.InnerHtml = "Valor Flete";
                createDiv01.Controls.Add(createDiv02);

                TramosLiquidados2.Controls.Add(createDiv01);

                List<LiqViajes_Bll_Data.LiquidacionPlanilla> liqplanillalist = LiqViajes_Bll_Data.LiquidacionPlanillaController.Instance.GetBy_RegistroViaje(lngIdRegistro);
                //  fila 02
                string TramoLiquidado = "";
                foreach (var item in liqplanillalist)
                {

                    if (TramoLiquidado != item.TramoLiquidado)
                    {

                        if (TramoLiquidado != "")
                            TramosLiquidados2.Controls.Add(createDiv01);


                        createDiv01 = new System.Web.UI.HtmlControls.HtmlGenericControl("DIV");
                        createDiv01.Attributes.Add("class", "row");
                    }

                    TramoLiquidado = item.TramoLiquidado;

                    createDiv02 = new System.Web.UI.HtmlControls.HtmlGenericControl("DIV");
                    createDiv02.Attributes.Add("class", "col-md-4 text-uppercase");
                    createDiv02.InnerHtml = item.TramoLiquidado;
                    createDiv01.Controls.Add(createDiv02);

                    createDiv02 = new System.Web.UI.HtmlControls.HtmlGenericControl("DIV");
                    createDiv02.Attributes.Add("class", "col-md-4 text-uppercase");
                    createDiv02.InnerHtml = item.strNoPlanilla.ToString();
                    createDiv01.Controls.Add(createDiv02);

                    createDiv02 = new System.Web.UI.HtmlControls.HtmlGenericControl("DIV");
                    createDiv02.Attributes.Add("class", "col-md-4 text-uppercase text-right");
                    createDiv02.InnerHtml = item.curValorFlete.Value.ToString("n0");
                    createDiv01.Controls.Add(createDiv02);
                    ValorFlete += item.curValorFlete.Value;
                }

                TramosLiquidados2.Controls.Add(createDiv01);

                //  fila totales
                createDiv01 = new System.Web.UI.HtmlControls.HtmlGenericControl("DIV");
                createDiv01.Attributes.Add("class", "row");

                createDiv02 = new System.Web.UI.HtmlControls.HtmlGenericControl("DIV");
                createDiv02.Attributes.Add("class", "col-md-12 text-right");
                createDiv02.InnerHtml = "----------------------------";
                createDiv01.Controls.Add(createDiv02);

                TramosLiquidados2.Controls.Add(createDiv01);

                //  fila totales
                createDiv01 = new System.Web.UI.HtmlControls.HtmlGenericControl("DIV");
                createDiv01.Attributes.Add("class", "row");

                createDiv02 = new System.Web.UI.HtmlControls.HtmlGenericControl("DIV");
                createDiv02.Attributes.Add("class", "col-md-10 text-uppercase text-right");
                createDiv02.InnerHtml = "Total fletes planilla";
                createDiv01.Controls.Add(createDiv02);

                createDiv02 = new System.Web.UI.HtmlControls.HtmlGenericControl("DIV");
                createDiv02.Attributes.Add("class", "col-md-2 text-right");
                createDiv02.InnerHtml = ValorFlete.ToString("n0");
                createDiv01.Controls.Add(createDiv02);

                TramosLiquidados2.Controls.Add(createDiv01);


                // lista los anticipos

                List<LiqViajes_Bll_Data.TramosConsultaAnticipos> tramosconsultaanticipoList = LiqViajes_Bll_Data.TramosConsultaAnticiposController.Instance.GetBy_RegistroViaje(lngIdRegistro);

                //  Tramos1

                System.Web.UI.HtmlControls.HtmlGenericControl Tramos01 = new System.Web.UI.HtmlControls.HtmlGenericControl("DIV");
                Tramos01.Attributes.Add("class", "row marco");

                System.Web.UI.HtmlControls.HtmlGenericControl Tramos02 = new System.Web.UI.HtmlControls.HtmlGenericControl("DIV");
                Tramos02.Attributes.Add("class", "col-md-2 text-uppercase");
                Tramos02.InnerHtml = "Tipo";
                Tramos01.Controls.Add(Tramos02);

                Tramos02 = new System.Web.UI.HtmlControls.HtmlGenericControl("DIV");
                Tramos02.Attributes.Add("class", "col-md-2 text-uppercase");
                Tramos02.InnerHtml = "Documento";
                Tramos01.Controls.Add(Tramos02);

                Tramos02 = new System.Web.UI.HtmlControls.HtmlGenericControl("DIV");
                Tramos02.Attributes.Add("class", "col-md-4 text-uppercase");
                Tramos02.InnerHtml = "Banco";
                Tramos01.Controls.Add(Tramos02);

                Tramos02 = new System.Web.UI.HtmlControls.HtmlGenericControl("DIV");
                Tramos02.Attributes.Add("class", "col-md-2");
                Tramos02.InnerHtml = "Fecha";
                Tramos01.Controls.Add(Tramos02);

                Tramos02 = new System.Web.UI.HtmlControls.HtmlGenericControl("DIV");
                Tramos02.Attributes.Add("class", "col-md-2 text-right");
                Tramos02.InnerHtml = "Valor Anticipo";
                Tramos01.Controls.Add(Tramos02);

                TramosAnticipo2.Controls.Add(Tramos01);

                foreach (var item in tramosconsultaanticipoList)
                {

                    Tramos01 = new System.Web.UI.HtmlControls.HtmlGenericControl("DIV");
                    Tramos01.Attributes.Add("class", "row");

                    Tramos02 = new System.Web.UI.HtmlControls.HtmlGenericControl("DIV");
                    Tramos02.Attributes.Add("class", "col-md-2 text-uppercase");
                    Tramos02.InnerHtml = item.Tipo;
                    Tramos01.Controls.Add(Tramos02);

                    Tramos02 = new System.Web.UI.HtmlControls.HtmlGenericControl("DIV");
                    Tramos02.Attributes.Add("class", "col-md-2 text-uppercase");
                    Tramos02.InnerHtml = item.Documento.Value.ToString();
                    Tramos01.Controls.Add(Tramos02);

                    Tramos02 = new System.Web.UI.HtmlControls.HtmlGenericControl("DIV");
                    Tramos02.Attributes.Add("class", "col-md-4 text-uppercase");
                    Tramos02.InnerHtml = item.NombreBanco;
                    Tramos01.Controls.Add(Tramos02);

                    Tramos02 = new System.Web.UI.HtmlControls.HtmlGenericControl("DIV");
                    Tramos02.Attributes.Add("class", "col-md-2");
                    Tramos02.InnerHtml = item.Fecha.Value.ToString("dd/MMM/yyyy");
                    Tramos01.Controls.Add(Tramos02);

                    Tramos02 = new System.Web.UI.HtmlControls.HtmlGenericControl("DIV");
                    Tramos02.Attributes.Add("class", "col-md-2 text-right");
                    Tramos02.InnerHtml = item.ValorAnticipo.Value.ToString("n0");
                    Tramos01.Controls.Add(Tramos02);

                    TramosAnticipo2.Controls.Add(Tramos01);

                    ValorAnticipo += item.ValorAnticipo.Value;

                }


                //  fila totales
                Tramos01 = new System.Web.UI.HtmlControls.HtmlGenericControl("DIV");
                Tramos01.Attributes.Add("class", "row");

                Tramos02 = new System.Web.UI.HtmlControls.HtmlGenericControl("DIV");
                Tramos02.Attributes.Add("class", "col-md-12 text-right");
                Tramos02.InnerHtml = "----------------------------";
                Tramos01.Controls.Add(Tramos02);

                TramosAnticipo2.Controls.Add(Tramos01);


                Tramos01 = new System.Web.UI.HtmlControls.HtmlGenericControl("DIV");
                Tramos01.Attributes.Add("class", "row");

                Tramos02 = new System.Web.UI.HtmlControls.HtmlGenericControl("DIV");
                Tramos02.Attributes.Add("class", "col-md-10 text-uppercase text-right");
                Tramos02.InnerHtml = "Total Anticipos";
                Tramos01.Controls.Add(Tramos02);

                Tramos02 = new System.Web.UI.HtmlControls.HtmlGenericControl("DIV");
                Tramos02.Attributes.Add("class", "col-md-2 text-right");
                Tramos02.InnerHtml = ValorAnticipo.ToString("n0");
                Tramos01.Controls.Add(Tramos02);

                TramosAnticipo2.Controls.Add(Tramos01);


                //  TramosMovimiento

                List<LiqViajes_Bll_Data.TramosMovViajes> tramosviajesList = LiqViajes_Bll_Data.TramosMovViajesController.Instance.GetBy_RegistroViaje(lngIdRegistro);

                string nomberuta = "";
                string[] DescripcionCuenta;

                foreach (var item in tramosviajesList)
                {
                    if (nomberuta != item.DescripcionPeaje)
                    {

                        if (nomberuta != "")
                        {

                            //  fila totales
                            Tramos01 = new System.Web.UI.HtmlControls.HtmlGenericControl("DIV");
                            Tramos01.Attributes.Add("class", "row");

                            Tramos02 = new System.Web.UI.HtmlControls.HtmlGenericControl("DIV");
                            Tramos02.Attributes.Add("class", "col-md-12 text-right");
                            Tramos02.InnerHtml = "----------------------------";
                            Tramos01.Controls.Add(Tramos02);

                            TramosMovimiento.Controls.Add(Tramos01);

                            // imprime encabezado
                            Tramos01 = new System.Web.UI.HtmlControls.HtmlGenericControl("DIV");
                            Tramos01.Attributes.Add("class", "container-fluid row");

                            Tramos02 = new System.Web.UI.HtmlControls.HtmlGenericControl("DIV");
                            Tramos02.Attributes.Add("class", "col-md-10 text-uppercase text-right");
                            Tramos02.InnerHtml = "Total Tramos";
                            Tramos01.Controls.Add(Tramos02);

                            Tramos02 = new System.Web.UI.HtmlControls.HtmlGenericControl("DIV");
                            Tramos02.Attributes.Add("class", "col-md-2 text-right");
                            Tramos02.InnerHtml = ValorTramos.ToString("n0");
                            Tramos01.Controls.Add(Tramos02);

                            TramosMovimiento.Controls.Add(Tramos01);

                            ValorTramos = 0;
                        }

                        #region Encabezado viaje
                        nomberuta = item.DescripcionPeaje;
                        // imprime encabezado
                        Tramos01 = new System.Web.UI.HtmlControls.HtmlGenericControl("DIV");
                        Tramos01.Attributes.Add("class", "container-fluid row marcoBottom");

                        Tramos02 = new System.Web.UI.HtmlControls.HtmlGenericControl("DIV");
                        Tramos01.Attributes.Add("class", "container-fluid text-uppercase row Encabezadoh3");
                        Tramos02.InnerHtml = "Tramo: " + item.DescripcionPeaje;
                        Tramos01.Controls.Add(Tramos02);

                        TramosMovimiento.Controls.Add(Tramos01);

                        #endregion

                        //

                        #region detalle encabezado viaje

                        Tramos01 = new System.Web.UI.HtmlControls.HtmlGenericControl("DIV");
                        Tramos01.Attributes.Add("class", "row marco");

                        Tramos02 = new System.Web.UI.HtmlControls.HtmlGenericControl("DIV");
                        Tramos02.Attributes.Add("class", "col-md-1 text-uppercase");
                        Tramos02.InnerHtml = "Tercero";
                        Tramos01.Controls.Add(Tramos02);

                        Tramos02 = new System.Web.UI.HtmlControls.HtmlGenericControl("DIV");
                        Tramos02.Attributes.Add("class", "col-md-4 text-uppercase");
                        Tramos02.InnerHtml = "Nombre Tercero";
                        Tramos01.Controls.Add(Tramos02);

                        Tramos02 = new System.Web.UI.HtmlControls.HtmlGenericControl("DIV");
                        Tramos02.Attributes.Add("class", "col-md-1 text-uppercase");
                        Tramos02.InnerHtml = "Cuenta";
                        Tramos01.Controls.Add(Tramos02);

                        Tramos02 = new System.Web.UI.HtmlControls.HtmlGenericControl("DIV");
                        Tramos02.Attributes.Add("class", "col-md-4 text-uppercase");
                        Tramos02.InnerHtml = "Detalle Cuenta";
                        Tramos01.Controls.Add(Tramos02);

                        Tramos02 = new System.Web.UI.HtmlControls.HtmlGenericControl("DIV");
                        Tramos02.Attributes.Add("class", "col-md-1 text-uppercase");
                        Tramos02.InnerHtml = "Fecha";
                        Tramos01.Controls.Add(Tramos02);

                        Tramos02 = new System.Web.UI.HtmlControls.HtmlGenericControl("DIV");
                        Tramos02.Attributes.Add("class", "col-md-1 text-uppercase");
                        Tramos02.InnerHtml = "Valor";
                        Tramos01.Controls.Add(Tramos02);

                        TramosMovimiento.Controls.Add(Tramos01);

                        #endregion
                    }
                    //

                    #region detalle data

                    Tramos01 = new System.Web.UI.HtmlControls.HtmlGenericControl("DIV");
                    Tramos01.Attributes.Add("class", "container-fluid row");

                    Tramos02 = new System.Web.UI.HtmlControls.HtmlGenericControl("DIV");
                    Tramos02.Attributes.Add("class", "col-md-1 text-uppercase");
                    Tramos02.InnerHtml = item.Cedula;
                    Tramos01.Controls.Add(Tramos02);

                    Tramos02 = new System.Web.UI.HtmlControls.HtmlGenericControl("DIV");
                    Tramos02.Attributes.Add("class", "col-md-4 text-uppercase");
                    Tramos02.InnerHtml = item.NombreConductor;
                    Tramos01.Controls.Add(Tramos02);

                    Tramos02 = new System.Web.UI.HtmlControls.HtmlGenericControl("DIV");
                    Tramos02.Attributes.Add("class", "col-md-1 text-uppercase");
                    Tramos02.InnerHtml = item.Cuenta;
                    Tramos01.Controls.Add(Tramos02);

                    DescripcionCuenta = item.DescripcionCuenta.Split('_');

                    Tramos02 = new System.Web.UI.HtmlControls.HtmlGenericControl("DIV");
                    Tramos02.Attributes.Add("class", "col-md-4 text-uppercase");
                    Tramos02.InnerHtml = DescripcionCuenta[1];
                    Tramos01.Controls.Add(Tramos02);

                    Tramos02 = new System.Web.UI.HtmlControls.HtmlGenericControl("DIV");
                    Tramos02.Attributes.Add("class", "col-md-1");
                    Tramos02.InnerHtml = item.Fecha.Value.ToString("dd/MMM/yyyy");
                    Tramos01.Controls.Add(Tramos02);

                    Tramos02 = new System.Web.UI.HtmlControls.HtmlGenericControl("DIV");
                    Tramos02.Attributes.Add("class", "col-md-1 text-right");
                    Tramos02.InnerHtml = item.ValorTotal.Value.ToString("n0");
                    Tramos01.Controls.Add(Tramos02);

                    TramosMovimiento.Controls.Add(Tramos01);

                    ValorTramos += item.ValorTotal.Value;
                    ValorTotalTramos += item.ValorTotal.Value;

                    #endregion
                }

                //  fila totales
                Tramos01 = new System.Web.UI.HtmlControls.HtmlGenericControl("DIV");
                Tramos01.Attributes.Add("class", "row");


                Tramos02 = new System.Web.UI.HtmlControls.HtmlGenericControl("DIV");
                Tramos02.Attributes.Add("class", "col-md-12 text-right");
                Tramos02.InnerHtml = "----------------------------";
                Tramos01.Controls.Add(Tramos02);

                TramosMovimiento.Controls.Add(Tramos01);

                // imprime encabezado
                Tramos01 = new System.Web.UI.HtmlControls.HtmlGenericControl("DIV");
                Tramos01.Attributes.Add("class", "container-fluid row");

                Tramos02 = new System.Web.UI.HtmlControls.HtmlGenericControl("DIV");
                Tramos02.Attributes.Add("class", "col-md-10 text-uppercase text-right");
                Tramos02.InnerHtml = "Total Tramo";
                Tramos01.Controls.Add(Tramos02);

                Tramos02 = new System.Web.UI.HtmlControls.HtmlGenericControl("DIV");
                Tramos02.Attributes.Add("class", "col-md-2 text-right");
                Tramos02.InnerHtml = ValorTramos.ToString("n0");
                Tramos01.Controls.Add(Tramos02);

                TramosMovimiento.Controls.Add(Tramos01);

                //  fila totales
                Tramos01 = new System.Web.UI.HtmlControls.HtmlGenericControl("DIV");
                Tramos01.Attributes.Add("class", "row");


                Tramos02 = new System.Web.UI.HtmlControls.HtmlGenericControl("DIV");
                Tramos02.Attributes.Add("class", "col-md-12 text-right");
                Tramos02.InnerHtml = "============================";
                Tramos01.Controls.Add(Tramos02);

                TramosMovimiento.Controls.Add(Tramos01);

                // imprime encabezado
                Tramos01 = new System.Web.UI.HtmlControls.HtmlGenericControl("DIV");
                Tramos01.Attributes.Add("class", "container-fluid row");

                Tramos02 = new System.Web.UI.HtmlControls.HtmlGenericControl("DIV");
                Tramos02.Attributes.Add("class", "col-md-10 text-uppercase text-right");
                Tramos02.InnerHtml = "Total General Tramo";
                Tramos01.Controls.Add(Tramos02);

                Tramos02 = new System.Web.UI.HtmlControls.HtmlGenericControl("DIV");
                Tramos02.Attributes.Add("class", "col-md-2 text-right");
                Tramos02.InnerHtml = ValorTotalTramos.ToString("n0");
                Tramos01.Controls.Add(Tramos02);

                TramosMovimiento.Controls.Add(Tramos01);
            }
        }
    }
}