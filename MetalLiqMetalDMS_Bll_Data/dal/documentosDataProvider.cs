using System;
using System.Data;
using System.Data.Common;
using Sinapsys.Datos;
using LiqMetalDMS_Bll_Data.Security;
using System.Runtime.Serialization;

namespace LiqMetalDMS_Bll_Data
{
	/// <summary>
	/// Data Access Layer class for documentos object
	/// </summary>
	/// <remarks>
	/// This class is a Singleton
	/// </remarks>
	public partial class documentosDataProvider
	{
		/// <summary>
		/// Internal member for create this singleton
		/// </summary>
		private static documentosDataProvider MySingleObj = null;

		/// <summary>
		/// Protected constructor to avoid access this singleton other way than calling the Instance method
		/// </summary>
		public documentosDataProvider()
		{

		}

		/// <summary>
		/// Instance accessor for this singleton
		/// </summary>
		public static documentosDataProvider Instance
		{
			get
			{
				if (MySingleObj == null)
				{
					MySingleObj = new documentosDataProvider();
				}

				return MySingleObj;
			}
		}

		/// <summary>
		/// Creates a new record into documentos by passing all fields
		/// </summary>
		/// <param name="sw"></param>
		/// <param name="nit"></param>
		/// <param name="fecha"></param>
		/// <param name="condicion"></param>
		/// <param name="vencimiento"></param>
		/// <param name="valor_total"></param>
		/// <param name="iva"></param>
		/// <param name="retencion"></param>
		/// <param name="retencion_causada"></param>
		/// <param name="retencion_iva"></param>
		/// <param name="retencion_ica"></param>
		/// <param name="descuento_pie"></param>
		/// <param name="fletes"></param>
		/// <param name="iva_fletes"></param>
		/// <param name="costo"></param>
		/// <param name="vendedor"></param>
		/// <param name="valor_aplicado"></param>
		/// <param name="anulado"></param>
		/// <param name="modelo"></param>
		/// <param name="documento"></param>
		/// <param name="notas"></param>
		/// <param name="usuario"></param>
		/// <param name="pc"></param>
		/// <param name="fecha_hora"></param>
		/// <param name="retencion2"></param>
		/// <param name="retencion3"></param>
		/// <param name="bodega"></param>
		/// <param name="impoconsumo"></param>
		/// <param name="descuento2"></param>
		/// <param name="duracion"></param>
		/// <param name="concepto"></param>
		/// <param name="vencimiento_presup"></param>
		/// <param name="exportado"></param>
		/// <param name="impuesto_deporte"></param>
		/// <param name="prefijo"></param>
		/// <param name="moneda"></param>
		/// <param name="tasa"></param>
		/// <param name="centro_doc"></param>
		/// <param name="valor_mercancia"></param>
		/// <param name="numero_cuotas"></param>
		/// <param name="codigo_direccion"></param>
		/// <param name="descuento_1"></param>
		/// <param name="descuento_2"></param>
		/// <param name="descuento_3"></param>
		/// <param name="abono"></param>
		/// <param name="fecha_consignacion"></param>
		/// <param name="Iva_Costo"></param>
		/// <param name="concepto_Retencion"></param>
		/// <param name="porc_RteFuente"></param>
		/// <param name="porc_RteIva"></param>
		/// <param name="porc_RteIvaSimpl"></param>
		/// <param name="porc_RteIca"></param>
		/// <param name="porc_RteA"></param>
		/// <param name="porc_RteB"></param>
		/// <param name="bodega_ot"></param>
		/// <param name="numero_ot"></param>
		/// <param name="provision"></param>
		/// <param name="ajuste"></param>
		/// <param name="porc_RteCree"></param>
		/// <param name="retencion_cree"></param>
		/// <param name="codigo_retencion_cree"></param>
		/// <param name="cree_causado"></param>
		/// <param name="ObligacionFinanciera"></param>
		/// <param name="Base_dcto_RC"></param>
		/// <param name="numincapacidad"></param>
		/// <param name="idincapacidad"></param>
		/// <returns>int that contents the id value</returns>
		public int Create(int id, string tipo, int numero, byte sw, decimal nit, DateTime fecha, string condicion, DateTime? vencimiento, decimal? valor_total, decimal? iva, decimal? retencion, decimal? retencion_causada, decimal? retencion_iva, decimal? retencion_ica, decimal? descuento_pie, decimal? fletes, decimal? iva_fletes, decimal? costo, decimal? vendedor, decimal? valor_aplicado, bool anulado, string modelo, string documento, string notas, string usuario, string pc, DateTime fecha_hora, decimal? retencion2, decimal? retencion3, short bodega, decimal? impoconsumo, decimal? descuento2, short? duracion, short? concepto, DateTime? vencimiento_presup, char? exportado, decimal? impuesto_deporte, string prefijo, string moneda, float? tasa, int? centro_doc, decimal? valor_mercancia, short? numero_cuotas, short? codigo_direccion, float? descuento_1, float? descuento_2, float? descuento_3, decimal? abono, DateTime? fecha_consignacion, char? Iva_Costo, short? concepto_Retencion, decimal? porc_RteFuente, decimal? porc_RteIva, decimal? porc_RteIvaSimpl, decimal? porc_RteIca, decimal? porc_RteA, decimal? porc_RteB, short? bodega_ot, int? numero_ot, decimal? provision, decimal? ajuste, decimal? porc_RteCree, decimal? retencion_cree, string codigo_retencion_cree, decimal? cree_causado, string ObligacionFinanciera, decimal? Base_dcto_RC, string numincapacidad, int? idincapacidad,string module, Sinapsys.Datos.SQL datosTransaccion=null)
		{
			try 
			{
				Sinapsys.Datos.SQL LocalDataProvider;
				bool disconnect = false;
				if (datosTransaccion != null) LocalDataProvider = datosTransaccion;
				else
				{
					if (DataProvider.Concurrente)
					{
						LocalDataProvider = new Sinapsys.Datos.SQL();
						LocalDataProvider.Conectar(DataProvider.Alias, false);
					}
					else
					{
						LocalDataProvider = DataProvider.Datos;
					}
					disconnect = DataProvider.ValidateConnection();
				}
				System.Data.SqlClient.SqlCommand Comando = new System.Data.SqlClient.SqlCommand();
				System.Data.SqlClient.SqlParameterCollection paramlist = Comando.Parameters;
				System.Collections.Hashtable nullExit = null;

				paramlist.AddWithValue("@id",id);
				paramlist.AddWithValue("@tipo",tipo);
				paramlist.AddWithValue("@numero",numero);
				paramlist.AddWithValue("@sw",sw);
				paramlist.AddWithValue("@nit",nit);
				paramlist.AddWithValue("@fecha",fecha);
				if (condicion !=null)
				{
					paramlist.AddWithValue("@condicion",condicion);
				}
				if (vencimiento !=null)
				{
					paramlist.AddWithValue("@vencimiento",vencimiento);
				}
				if (valor_total !=null)
				{
					paramlist.AddWithValue("@valor_total",valor_total);
				}
				if (iva !=null)
				{
					paramlist.AddWithValue("@iva",iva);
				}
				if (retencion !=null)
				{
					paramlist.AddWithValue("@retencion",retencion);
				}
				if (retencion_causada !=null)
				{
					paramlist.AddWithValue("@retencion_causada",retencion_causada);
				}
				if (retencion_iva !=null)
				{
					paramlist.AddWithValue("@retencion_iva",retencion_iva);
				}
				if (retencion_ica !=null)
				{
					paramlist.AddWithValue("@retencion_ica",retencion_ica);
				}
				if (descuento_pie !=null)
				{
					paramlist.AddWithValue("@descuento_pie",descuento_pie);
				}
				if (fletes !=null)
				{
					paramlist.AddWithValue("@fletes",fletes);
				}
				if (iva_fletes !=null)
				{
					paramlist.AddWithValue("@iva_fletes",iva_fletes);
				}
				if (costo !=null)
				{
					paramlist.AddWithValue("@costo",costo);
				}
				if (vendedor !=null)
				{
					paramlist.AddWithValue("@vendedor",vendedor);
				}
				if (valor_aplicado !=null)
				{
					paramlist.AddWithValue("@valor_aplicado",valor_aplicado);
				}
				paramlist.AddWithValue("@anulado",anulado);
				if (modelo !=null)
				{
					paramlist.AddWithValue("@modelo",modelo);
				}
				if (documento !=null)
				{
					paramlist.AddWithValue("@documento",documento);
				}
				if (notas !=null)
				{
					paramlist.AddWithValue("@notas",notas);
				}
				paramlist.AddWithValue("@usuario",usuario);
				paramlist.AddWithValue("@pc",pc);
				paramlist.AddWithValue("@fecha_hora",fecha_hora);
				if (retencion2 !=null)
				{
					paramlist.AddWithValue("@retencion2",retencion2);
				}
				if (retencion3 !=null)
				{
					paramlist.AddWithValue("@retencion3",retencion3);
				}
				paramlist.AddWithValue("@bodega",bodega);
				if (impoconsumo !=null)
				{
					paramlist.AddWithValue("@impoconsumo",impoconsumo);
				}
				if (descuento2 !=null)
				{
					paramlist.AddWithValue("@descuento2",descuento2);
				}
				if (duracion !=null)
				{
					paramlist.AddWithValue("@duracion",duracion);
				}
				if (concepto !=null)
				{
					paramlist.AddWithValue("@concepto",concepto);
				}
				if (vencimiento_presup !=null)
				{
					paramlist.AddWithValue("@vencimiento_presup",vencimiento_presup);
				}
				if (exportado !=null)
				{
					paramlist.AddWithValue("@exportado",exportado);
				}
				if (impuesto_deporte !=null)
				{
					paramlist.AddWithValue("@impuesto_deporte",impuesto_deporte);
				}
				if (prefijo !=null)
				{
					paramlist.AddWithValue("@prefijo",prefijo);
				}
				if (moneda !=null)
				{
					paramlist.AddWithValue("@moneda",moneda);
				}
				if (tasa !=null)
				{
					paramlist.AddWithValue("@tasa",tasa);
				}
				if (centro_doc !=null)
				{
					paramlist.AddWithValue("@centro_doc",centro_doc);
				}
				if (valor_mercancia !=null)
				{
					paramlist.AddWithValue("@valor_mercancia",valor_mercancia);
				}
				if (numero_cuotas !=null)
				{
					paramlist.AddWithValue("@numero_cuotas",numero_cuotas);
				}
				if (codigo_direccion !=null)
				{
					paramlist.AddWithValue("@codigo_direccion",codigo_direccion);
				}
				if (descuento_1 !=null)
				{
					paramlist.AddWithValue("@descuento_1",descuento_1);
				}
				if (descuento_2 !=null)
				{
					paramlist.AddWithValue("@descuento_2",descuento_2);
				}
				if (descuento_3 !=null)
				{
					paramlist.AddWithValue("@descuento_3",descuento_3);
				}
				if (abono !=null)
				{
					paramlist.AddWithValue("@abono",abono);
				}
				if (fecha_consignacion !=null)
				{
					paramlist.AddWithValue("@fecha_consignacion",fecha_consignacion);
				}
				if (Iva_Costo !=null)
				{
					paramlist.AddWithValue("@Iva_Costo",Iva_Costo);
				}
				if (concepto_Retencion !=null)
				{
					paramlist.AddWithValue("@concepto_Retencion",concepto_Retencion);
				}
				if (porc_RteFuente !=null)
				{
					paramlist.AddWithValue("@porc_RteFuente",porc_RteFuente);
				}
				if (porc_RteIva !=null)
				{
					paramlist.AddWithValue("@porc_RteIva",porc_RteIva);
				}
				if (porc_RteIvaSimpl !=null)
				{
					paramlist.AddWithValue("@porc_RteIvaSimpl",porc_RteIvaSimpl);
				}
				if (porc_RteIca !=null)
				{
					paramlist.AddWithValue("@porc_RteIca",porc_RteIca);
				}
				if (porc_RteA !=null)
				{
					paramlist.AddWithValue("@porc_RteA",porc_RteA);
				}
				if (porc_RteB !=null)
				{
					paramlist.AddWithValue("@porc_RteB",porc_RteB);
				}
				if (bodega_ot !=null)
				{
					paramlist.AddWithValue("@bodega_ot",bodega_ot);
				}
				if (numero_ot !=null)
				{
					paramlist.AddWithValue("@numero_ot",numero_ot);
				}
				if (provision !=null)
				{
					paramlist.AddWithValue("@provision",provision);
				}
				if (ajuste !=null)
				{
					paramlist.AddWithValue("@ajuste",ajuste);
				}
				if (porc_RteCree !=null)
				{
					paramlist.AddWithValue("@porc_RteCree",porc_RteCree);
				}
				if (retencion_cree !=null)
				{
					paramlist.AddWithValue("@retencion_cree",retencion_cree);
				}
				if (codigo_retencion_cree !=null)
				{
					paramlist.AddWithValue("@codigo_retencion_cree",codigo_retencion_cree);
				}
				if (cree_causado !=null)
				{
					paramlist.AddWithValue("@cree_causado",cree_causado);
				}
				if (ObligacionFinanciera !=null)
				{
					paramlist.AddWithValue("@ObligacionFinanciera",ObligacionFinanciera);
				}
				if (Base_dcto_RC !=null)
				{
					paramlist.AddWithValue("@Base_dcto_RC",Base_dcto_RC);
				}
				if (numincapacidad !=null)
				{
					paramlist.AddWithValue("@numincapacidad",numincapacidad);
				}
				if (idincapacidad !=null)
				{
					paramlist.AddWithValue("@idincapacidad",idincapacidad);
				}
				// Execute the query and return the new identity value
				int returnValue = Convert.ToInt32(LocalDataProvider.EjecutarProcedimiento("dbo.documentosCreate", paramlist, disconnect, out nullExit, DataProvider.TiempoEspera).Rows[0][0]);

				return returnValue;
			}
			catch (Exception ex)
			{
				Utilidades.LogErrores(ex.Message + (ex.InnerException != null ? ex.InnerException.Message : ""), DataProvider.AplicacionNombre);
				throw ex;
			}
		}

		/// <summary>
		/// Updates one record into documentos by passing all fields
		/// </summary>
		/// <param name="id"></param>
		/// <param name="sw"></param>
		/// <param name="tipo"></param>
		/// <param name="numero"></param>
		/// <param name="nit"></param>
		/// <param name="fecha"></param>
		/// <param name="condicion"></param>
		/// <param name="vencimiento"></param>
		/// <param name="valor_total"></param>
		/// <param name="iva"></param>
		/// <param name="retencion"></param>
		/// <param name="retencion_causada"></param>
		/// <param name="retencion_iva"></param>
		/// <param name="retencion_ica"></param>
		/// <param name="descuento_pie"></param>
		/// <param name="fletes"></param>
		/// <param name="iva_fletes"></param>
		/// <param name="costo"></param>
		/// <param name="vendedor"></param>
		/// <param name="valor_aplicado"></param>
		/// <param name="anulado"></param>
		/// <param name="modelo"></param>
		/// <param name="documento"></param>
		/// <param name="notas"></param>
		/// <param name="usuario"></param>
		/// <param name="pc"></param>
		/// <param name="fecha_hora"></param>
		/// <param name="retencion2"></param>
		/// <param name="retencion3"></param>
		/// <param name="bodega"></param>
		/// <param name="impoconsumo"></param>
		/// <param name="descuento2"></param>
		/// <param name="duracion"></param>
		/// <param name="concepto"></param>
		/// <param name="vencimiento_presup"></param>
		/// <param name="exportado"></param>
		/// <param name="impuesto_deporte"></param>
		/// <param name="prefijo"></param>
		/// <param name="moneda"></param>
		/// <param name="tasa"></param>
		/// <param name="centro_doc"></param>
		/// <param name="valor_mercancia"></param>
		/// <param name="numero_cuotas"></param>
		/// <param name="codigo_direccion"></param>
		/// <param name="descuento_1"></param>
		/// <param name="descuento_2"></param>
		/// <param name="descuento_3"></param>
		/// <param name="abono"></param>
		/// <param name="fecha_consignacion"></param>
		/// <param name="Iva_Costo"></param>
		/// <param name="concepto_Retencion"></param>
		/// <param name="porc_RteFuente"></param>
		/// <param name="porc_RteIva"></param>
		/// <param name="porc_RteIvaSimpl"></param>
		/// <param name="porc_RteIca"></param>
		/// <param name="porc_RteA"></param>
		/// <param name="porc_RteB"></param>
		/// <param name="bodega_ot"></param>
		/// <param name="numero_ot"></param>
		/// <param name="provision"></param>
		/// <param name="ajuste"></param>
		/// <param name="porc_RteCree"></param>
		/// <param name="retencion_cree"></param>
		/// <param name="codigo_retencion_cree"></param>
		/// <param name="cree_causado"></param>
		/// <param name="ObligacionFinanciera"></param>
		/// <param name="Base_dcto_RC"></param>
		/// <param name="numincapacidad"></param>
		/// <param name="idincapacidad"></param>
		public void Update(int id, byte sw, string tipo, int numero, decimal nit, DateTime fecha, string condicion, DateTime? vencimiento, decimal? valor_total, decimal? iva, decimal? retencion, decimal? retencion_causada, decimal? retencion_iva, decimal? retencion_ica, decimal? descuento_pie, decimal? fletes, decimal? iva_fletes, decimal? costo, decimal? vendedor, decimal? valor_aplicado, bool anulado, string modelo, string documento, string notas, string usuario, string pc, DateTime fecha_hora, decimal? retencion2, decimal? retencion3, short bodega, decimal? impoconsumo, decimal? descuento2, short? duracion, short? concepto, DateTime? vencimiento_presup, char? exportado, decimal? impuesto_deporte, string prefijo, string moneda, float? tasa, int? centro_doc, decimal? valor_mercancia, short? numero_cuotas, short? codigo_direccion, float? descuento_1, float? descuento_2, float? descuento_3, decimal? abono, DateTime? fecha_consignacion, char? Iva_Costo, short? concepto_Retencion, decimal? porc_RteFuente, decimal? porc_RteIva, decimal? porc_RteIvaSimpl, decimal? porc_RteIca, decimal? porc_RteA, decimal? porc_RteB, short? bodega_ot, int? numero_ot, decimal? provision, decimal? ajuste, decimal? porc_RteCree, decimal? retencion_cree, string codigo_retencion_cree, decimal? cree_causado, string ObligacionFinanciera, decimal? Base_dcto_RC, string numincapacidad, int? idincapacidad,string module, Sinapsys.Datos.SQL datosTransaccion=null)
		{
			try 
			{
				Sinapsys.Datos.SQL LocalDataProvider;
				bool disconnect = false;
				if (datosTransaccion != null) LocalDataProvider = datosTransaccion;
				else
				{
					if (DataProvider.Concurrente)
					{
						LocalDataProvider = new Sinapsys.Datos.SQL();
						LocalDataProvider.Conectar(DataProvider.Alias, false);
					}
					else
					{
						LocalDataProvider = DataProvider.Datos;
					}
					disconnect = DataProvider.ValidateConnection();
				}
				System.Data.SqlClient.SqlCommand Comando = new System.Data.SqlClient.SqlCommand();
				System.Data.SqlClient.SqlParameterCollection paramlist = Comando.Parameters;
				System.Collections.Hashtable nullExit = null;
				paramlist.AddWithValue("@id",id);
				paramlist.AddWithValue("@tipo",tipo);
				paramlist.AddWithValue("@numero",numero);
				paramlist.AddWithValue("@sw",sw);
				paramlist.AddWithValue("@nit",nit);
				paramlist.AddWithValue("@fecha",fecha);
				if (condicion !=null)
				{
					paramlist.AddWithValue("@condicion",condicion);
				}
				if (vencimiento !=null)
				{
					paramlist.AddWithValue("@vencimiento",vencimiento);
				}
				if (valor_total !=null)
				{
					paramlist.AddWithValue("@valor_total",valor_total);
				}
				if (iva !=null)
				{
					paramlist.AddWithValue("@iva",iva);
				}
				if (retencion !=null)
				{
					paramlist.AddWithValue("@retencion",retencion);
				}
				if (retencion_causada !=null)
				{
					paramlist.AddWithValue("@retencion_causada",retencion_causada);
				}
				if (retencion_iva !=null)
				{
					paramlist.AddWithValue("@retencion_iva",retencion_iva);
				}
				if (retencion_ica !=null)
				{
					paramlist.AddWithValue("@retencion_ica",retencion_ica);
				}
				if (descuento_pie !=null)
				{
					paramlist.AddWithValue("@descuento_pie",descuento_pie);
				}
				if (fletes !=null)
				{
					paramlist.AddWithValue("@fletes",fletes);
				}
				if (iva_fletes !=null)
				{
					paramlist.AddWithValue("@iva_fletes",iva_fletes);
				}
				if (costo !=null)
				{
					paramlist.AddWithValue("@costo",costo);
				}
				if (vendedor !=null)
				{
					paramlist.AddWithValue("@vendedor",vendedor);
				}
				if (valor_aplicado !=null)
				{
					paramlist.AddWithValue("@valor_aplicado",valor_aplicado);
				}
				paramlist.AddWithValue("@anulado",anulado);
				if (modelo !=null)
				{
					paramlist.AddWithValue("@modelo",modelo);
				}
				if (documento !=null)
				{
					paramlist.AddWithValue("@documento",documento);
				}
				if (notas !=null)
				{
					paramlist.AddWithValue("@notas",notas);
				}
				paramlist.AddWithValue("@usuario",usuario);
				paramlist.AddWithValue("@pc",pc);
				paramlist.AddWithValue("@fecha_hora",fecha_hora);
				if (retencion2 !=null)
				{
					paramlist.AddWithValue("@retencion2",retencion2);
				}
				if (retencion3 !=null)
				{
					paramlist.AddWithValue("@retencion3",retencion3);
				}
				paramlist.AddWithValue("@bodega",bodega);
				if (impoconsumo !=null)
				{
					paramlist.AddWithValue("@impoconsumo",impoconsumo);
				}
				if (descuento2 !=null)
				{
					paramlist.AddWithValue("@descuento2",descuento2);
				}
				if (duracion !=null)
				{
					paramlist.AddWithValue("@duracion",duracion);
				}
				if (concepto !=null)
				{
					paramlist.AddWithValue("@concepto",concepto);
				}
				if (vencimiento_presup !=null)
				{
					paramlist.AddWithValue("@vencimiento_presup",vencimiento_presup);
				}
				if (exportado !=null)
				{
					paramlist.AddWithValue("@exportado",exportado);
				}
				if (impuesto_deporte !=null)
				{
					paramlist.AddWithValue("@impuesto_deporte",impuesto_deporte);
				}
				if (prefijo !=null)
				{
					paramlist.AddWithValue("@prefijo",prefijo);
				}
				if (moneda !=null)
				{
					paramlist.AddWithValue("@moneda",moneda);
				}
				if (tasa !=null)
				{
					paramlist.AddWithValue("@tasa",tasa);
				}
				if (centro_doc !=null)
				{
					paramlist.AddWithValue("@centro_doc",centro_doc);
				}
				if (valor_mercancia !=null)
				{
					paramlist.AddWithValue("@valor_mercancia",valor_mercancia);
				}
				if (numero_cuotas !=null)
				{
					paramlist.AddWithValue("@numero_cuotas",numero_cuotas);
				}
				if (codigo_direccion !=null)
				{
					paramlist.AddWithValue("@codigo_direccion",codigo_direccion);
				}
				if (descuento_1 !=null)
				{
					paramlist.AddWithValue("@descuento_1",descuento_1);
				}
				if (descuento_2 !=null)
				{
					paramlist.AddWithValue("@descuento_2",descuento_2);
				}
				if (descuento_3 !=null)
				{
					paramlist.AddWithValue("@descuento_3",descuento_3);
				}
				if (abono !=null)
				{
					paramlist.AddWithValue("@abono",abono);
				}
				if (fecha_consignacion !=null)
				{
					paramlist.AddWithValue("@fecha_consignacion",fecha_consignacion);
				}
				if (Iva_Costo !=null)
				{
					paramlist.AddWithValue("@Iva_Costo",Iva_Costo);
				}
				if (concepto_Retencion !=null)
				{
					paramlist.AddWithValue("@concepto_Retencion",concepto_Retencion);
				}
				if (porc_RteFuente !=null)
				{
					paramlist.AddWithValue("@porc_RteFuente",porc_RteFuente);
				}
				if (porc_RteIva !=null)
				{
					paramlist.AddWithValue("@porc_RteIva",porc_RteIva);
				}
				if (porc_RteIvaSimpl !=null)
				{
					paramlist.AddWithValue("@porc_RteIvaSimpl",porc_RteIvaSimpl);
				}
				if (porc_RteIca !=null)
				{
					paramlist.AddWithValue("@porc_RteIca",porc_RteIca);
				}
				if (porc_RteA !=null)
				{
					paramlist.AddWithValue("@porc_RteA",porc_RteA);
				}
				if (porc_RteB !=null)
				{
					paramlist.AddWithValue("@porc_RteB",porc_RteB);
				}
				if (bodega_ot !=null)
				{
					paramlist.AddWithValue("@bodega_ot",bodega_ot);
				}
				if (numero_ot !=null)
				{
					paramlist.AddWithValue("@numero_ot",numero_ot);
				}
				if (provision !=null)
				{
					paramlist.AddWithValue("@provision",provision);
				}
				if (ajuste !=null)
				{
					paramlist.AddWithValue("@ajuste",ajuste);
				}
				if (porc_RteCree !=null)
				{
					paramlist.AddWithValue("@porc_RteCree",porc_RteCree);
				}
				if (retencion_cree !=null)
				{
					paramlist.AddWithValue("@retencion_cree",retencion_cree);
				}
				if (codigo_retencion_cree !=null)
				{
					paramlist.AddWithValue("@codigo_retencion_cree",codigo_retencion_cree);
				}
				if (cree_causado !=null)
				{
					paramlist.AddWithValue("@cree_causado",cree_causado);
				}
				if (ObligacionFinanciera !=null)
				{
					paramlist.AddWithValue("@ObligacionFinanciera",ObligacionFinanciera);
				}
				if (Base_dcto_RC !=null)
				{
					paramlist.AddWithValue("@Base_dcto_RC",Base_dcto_RC);
				}
				if (numincapacidad !=null)
				{
					paramlist.AddWithValue("@numincapacidad",numincapacidad);
				}
				if (idincapacidad !=null)
				{
					paramlist.AddWithValue("@idincapacidad",idincapacidad);
				}
				LocalDataProvider.EjecutarProcedimiento("dbo.documentosUpdate", paramlist, disconnect, out nullExit, DataProvider.TiempoEspera);
			}
			catch (Exception ex)
			{
				Utilidades.LogErrores(ex.Message + (ex.InnerException != null ? ex.InnerException.Message : ""), DataProvider.AplicacionNombre);
				throw ex;
			}
		}

		/// <summary>
		/// Deletes one record from documentos by passing all key fields
		/// </summary>
		/// <param name="id"></param>
		/// <param name="tipo"></param>
		/// <param name="numero"></param>
		public void Delete(int id, string tipo, int numero,string module, Sinapsys.Datos.SQL datosTransaccion=null)
		{
			try 
			{
				Sinapsys.Datos.SQL LocalDataProvider;
				bool disconnect = false;
				if (datosTransaccion != null) LocalDataProvider = datosTransaccion;
				else
				{
					if (DataProvider.Concurrente)
					{
						LocalDataProvider = new Sinapsys.Datos.SQL();
						LocalDataProvider.Conectar(DataProvider.Alias, false);
					}
					else
					{
						LocalDataProvider = DataProvider.Datos;
					}
					disconnect = DataProvider.ValidateConnection();
				}
				System.Data.SqlClient.SqlCommand Comando = new System.Data.SqlClient.SqlCommand();
				System.Data.SqlClient.SqlParameterCollection paramlist = Comando.Parameters;
				System.Collections.Hashtable nullExit = null;
				paramlist.AddWithValue("@id",id);
				paramlist.AddWithValue("@tipo",tipo);
				paramlist.AddWithValue("@numero",numero);
				LocalDataProvider.EjecutarProcedimiento("dbo.documentosDelete", paramlist, disconnect, out nullExit, DataProvider.TiempoEspera);
			}
			catch (Exception ex)
			{
				Utilidades.LogErrores(ex.Message + (ex.InnerException != null ? ex.InnerException.Message : ""), DataProvider.AplicacionNombre);
				throw ex;
			}
		}

		/// <summary>
		/// Gets one record from documentos passing all key fields
		/// </summary>
		/// <param name="id"></param>
		/// <param name="tipo"></param>
		/// <param name="numero"></param>
		/// <returns>A DataTable object containing the data</returns>
		public DataTable Get(int id, string tipo, int numero)
		{
			try 
			{
				Sinapsys.Datos.SQL LocalDataProvider;
				bool disconnect = false;
				if (DataProvider.Concurrente)
				{
					LocalDataProvider = new Sinapsys.Datos.SQL();
					LocalDataProvider.Conectar(DataProvider.Alias, false);
				}
				else
				{
					LocalDataProvider = DataProvider.Datos;
				}
				disconnect = DataProvider.ValidateConnection();
				System.Data.SqlClient.SqlCommand Comando = new System.Data.SqlClient.SqlCommand();
				System.Data.SqlClient.SqlParameterCollection paramlist = Comando.Parameters;
				System.Collections.Hashtable nullExit = null;
				paramlist.AddWithValue("@id",id);
				paramlist.AddWithValue("@tipo",tipo);
				paramlist.AddWithValue("@numero",numero);
				return LocalDataProvider.EjecutarProcedimiento("dbo.documentosGet", paramlist, disconnect, out nullExit, DataProvider.TiempoEspera);

			}
			catch (Exception ex)
			{
				Utilidades.LogErrores(ex.Message + (ex.InnerException != null ? ex.InnerException.Message : ""), DataProvider.AplicacionNombre);
				throw ex;
			}
		}

		/// <summary>
		/// Gets all records from documentos
		/// </summary>
		/// <returns>A DataTable object containing all records data</returns>
		public DataTable GetAll()
		{
			try 
			{
				Sinapsys.Datos.SQL LocalDataProvider;
				bool disconnect = false;
				if (DataProvider.Concurrente)
				{
					LocalDataProvider = new Sinapsys.Datos.SQL();
					LocalDataProvider.Conectar(DataProvider.Alias, false);
				}
				else
				{
					LocalDataProvider = DataProvider.Datos;
				}
				disconnect = DataProvider.ValidateConnection();
				System.Data.SqlClient.SqlCommand Comando = new System.Data.SqlClient.SqlCommand();
				System.Data.SqlClient.SqlParameterCollection paramlist = Comando.Parameters;
				System.Collections.Hashtable nullExit = null;
				return LocalDataProvider.EjecutarProcedimiento("dbo.documentosGetAll", paramlist, disconnect, out nullExit, DataProvider.TiempoEspera);
			}
			catch (Exception ex)
			{
				Utilidades.LogErrores(ex.Message + (ex.InnerException != null ? ex.InnerException.Message : ""), DataProvider.AplicacionNombre);
				throw ex;
			}
		}

		/// <summary>
		/// Gets all records from documentos applying filter and sort criteria
		/// </summary>
		/// <param name="pagenum">Contents the page number (z-ordered) of records to return.</param>
		/// <param name="pagesize">Contents the number of records per page (0 for returns all records).</param>
		/// <param name="filter">Contents the criteria (as SQL sentence) for filter records (ex. Qty > 0).</param>
		/// <param name="sort">Contents the criteria (as SQL sentence) for filter records (ex. Name ASC).</param>
		/// <param name="extablesfilter">Contents extra tables for make relations in filter operations (ex. extratable).</param>
		/// <param name="extablesfieldsfilter">Contents extra tables's fields for make relations in filter operations  (ex. extratable.field)</param>
		/// <param name="extablesrelationsfilter">Contents the relations with extra tables in filter operations (ex. table.id=extratable.id).</param>
		/// <param name="extablessort">Contents extra tables for make relations in sort operations (ex. extratable).</param>
		/// <param name="extablesfieldssort">Contents extra tables's fields for make relations in sort operations  (ex. extratable.field)</param>
		/// <param name="extablesrelationssort">Contents the relations with extra tables in sort operations (ex. table.id=extratable.id).</param>
		/// <returns>A DataTable object containing all records data</returns>
		public DataTable GetFilter(int pagenum, int pagesize, string filter, string sort, string extablesfilter, string extablesfieldsfilter, string extablesrelationsfilter, string extablessort, string extablesfieldssort, string extablesrelationssort)
		{
			try 
			{

				Sinapsys.Datos.SQL LocalDataProvider;
				bool disconnect = false;
				if (DataProvider.Concurrente)
				{
					LocalDataProvider = new Sinapsys.Datos.SQL();
					LocalDataProvider.Conectar(DataProvider.Alias, false);
				}
				else
				{
					LocalDataProvider = DataProvider.Datos;
				}
				disconnect = DataProvider.ValidateConnection();
				System.Data.SqlClient.SqlCommand Comando = new System.Data.SqlClient.SqlCommand();
				System.Data.SqlClient.SqlParameterCollection paramlist = Comando.Parameters;
				System.Collections.Hashtable nullExit = null;
				paramlist.AddWithValue("@cctReturnType","S");
				paramlist.AddWithValue("@intPageNo", pagenum);
				paramlist.AddWithValue("@intPageSize", pagesize);
				paramlist.AddWithValue("@strFilter", filter);
				paramlist.AddWithValue("@strSort", sort);
				paramlist.AddWithValue("@strExtraTablesFilter",extablesfilter);
				paramlist.AddWithValue("@strExtraTablesFieldsFilter",  extablesfieldsfilter);
				paramlist.AddWithValue("@strExtraTablesRelationsFilter", extablesrelationsfilter);
				paramlist.AddWithValue("@strExtraTablesSort", extablessort);
				paramlist.AddWithValue("@strExtraTablesFieldsSort", extablesfieldssort);
				paramlist.AddWithValue("@strExtraTablesRelationsSort",extablesrelationssort);

				return LocalDataProvider.EjecutarProcedimiento("dbo.documentosGetFilter", paramlist, disconnect, out nullExit, DataProvider.TiempoEspera);
			}
			catch (Exception ex)
			{
				Utilidades.LogErrores(ex.Message + (ex.InnerException != null ? ex.InnerException.Message : ""), DataProvider.AplicacionNombre);
				throw ex;
			}
		}

		public DataTable GetFilter( string filter, string sort)
		{
			return GetFilter(0,0, filter, sort, "","","","","","");
		}

		public DataTable GetFilter(string filter, string sort, string extablesfilter, string extablesfieldsfilter, string extablesrelationsfilter, string extablessort, string extablesfieldssort, string extablesrelationssort)
		{
			return GetFilter(0,0, filter, sort, extablesfilter, extablesfieldsfilter, extablesrelationsfilter, extablessort, extablesfieldssort, extablesrelationssort);
		}

		/// <summary>
		/// Gets the numbers of records from documentos applying filter and sort criteria
		/// </summary>
		/// <param name="pagenum">Contents the page number (z-ordered) of records to return.</param>
		/// <param name="pagesize">Contents the number of records per page (0 for returns all records).</param>
		/// <param name="filter">Contents the criteria (as SQL sentence) for filter records (ex. Qty > 0).</param>
		/// <param name="sort">Contents the criteria (as SQL sentence) for filter records (ex. Name ASC).</param>
		/// <param name="extablesfilter">Contents extra tables for make relations in filter operations (ex. extratable).</param>
		/// <param name="extablesfieldsfilter">Contents extra tables's fields for make relations in filter operations  (ex. extratable.field)</param>
		/// <param name="extablesrelationsfilter">Contents the relations with extra tables in filter operations (ex. table.id=extratable.id).</param>
		/// <param name="extablessort">Contents extra tables for make relations in sort operations (ex. extratable).</param>
		/// <param name="extablesfieldssort">Contents extra tables's fields for make relations in sort operations  (ex. extratable.field)</param>
		/// <param name="extablesrelationssort">Contents the relations with extra tables in sort operations (ex. table.id=extratable.id).</param>
		/// <returns>A int value containing the numbers of records</returns>
		public int GetFilterCount(int pagenum, int pagesize, string filter, string sort, string extablesfilter, string extablesfieldsfilter, string extablesrelationsfilter, string extablessort, string extablesfieldssort, string extablesrelationssort)
		{
			try 
			{
				Sinapsys.Datos.SQL LocalDataProvider;
				bool disconnect = false;
				if (DataProvider.Concurrente)
				{
					LocalDataProvider = new Sinapsys.Datos.SQL();
					LocalDataProvider.Conectar(DataProvider.Alias, false);
				}
				else
				{
					LocalDataProvider = DataProvider.Datos;
				}
				disconnect = DataProvider.ValidateConnection();
				System.Data.SqlClient.SqlCommand Comando = new System.Data.SqlClient.SqlCommand();
				System.Data.SqlClient.SqlParameterCollection paramlist = Comando.Parameters;
				System.Collections.Hashtable nullExit = null;
				paramlist.AddWithValue("@cctReturnType","C");
				paramlist.AddWithValue("@intPageNo", pagenum);
				paramlist.AddWithValue("@intPageSize", pagesize);
				paramlist.AddWithValue("@strFilter", filter);
				paramlist.AddWithValue("@strSort", sort);
				paramlist.AddWithValue("@strExtraTablesFilter",extablesfilter);
				paramlist.AddWithValue("@strExtraTablesFieldsFilter",  extablesfieldsfilter);
				paramlist.AddWithValue("@strExtraTablesRelationsFilter", extablesrelationsfilter);
				paramlist.AddWithValue("@strExtraTablesSort", extablessort);
				paramlist.AddWithValue("@strExtraTablesFieldsSort", extablesfieldssort);
				paramlist.AddWithValue("@strExtraTablesRelationsSort",extablesrelationssort);

				return (int) LocalDataProvider.EjecutarProcedimiento("dbo.documentosGetFilter", paramlist, disconnect, out nullExit, DataProvider.TiempoEspera).Rows[0][0];
			}
			catch (Exception ex)
			{
				Utilidades.LogErrores(ex.Message + (ex.InnerException != null ? ex.InnerException.Message : ""), DataProvider.AplicacionNombre);
				throw ex;
			}
		}

	}
}
