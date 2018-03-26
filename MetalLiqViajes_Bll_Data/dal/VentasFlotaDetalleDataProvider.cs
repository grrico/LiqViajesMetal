using System;
using System.Data;
using System.Data.Common;
using Sinapsys.Datos;
using LiqViajes_Bll_Data.Security;
using System.Runtime.Serialization;

namespace LiqViajes_Bll_Data
{
	/// <summary>
	/// Data Access Layer class for VentasFlotaDetalle object
	/// </summary>
	/// <remarks>
	/// This class is a Singleton
	/// </remarks>
	public partial class VentasFlotaDetalleDataProvider
	{
		/// <summary>
		/// Internal member for create this singleton
		/// </summary>
		private static VentasFlotaDetalleDataProvider MySingleObj = null;

		/// <summary>
		/// Protected constructor to avoid access this singleton other way than calling the Instance method
		/// </summary>
		public VentasFlotaDetalleDataProvider()
		{

		}

		/// <summary>
		/// Instance accessor for this singleton
		/// </summary>
		public static VentasFlotaDetalleDataProvider Instance
		{
			get
			{
				if (MySingleObj == null)
				{
					MySingleObj = new VentasFlotaDetalleDataProvider();
				}

				return MySingleObj;
			}
		}

		/// <summary>
		/// Creates a new record into VentasFlotaDetalle by passing all fields
		/// </summary>
		/// <param name="IdEDS"></param>
		/// <param name="Factura"></param>
		/// <param name="Tipo"></param>
		/// <param name="Numero"></param>
		/// <param name="Tipo52v"></param>
		/// <param name="Numero52v"></param>
		/// <param name="Nit"></param>
		/// <param name="Seq"></param>
		/// <param name="Cuenta"></param>
		/// <param name="Fecha"></param>
		/// <param name="Hora"></param>
		/// <param name="NombreCliente"></param>
		/// <param name="Estacion"></param>
		/// <param name="TipoEstacion"></param>
		/// <param name="Destinatario"></param>
		/// <param name="Ciudad"></param>
		/// <param name="Placa"></param>
		/// <param name="Producto"></param>
		/// <param name="Cantidad"></param>
		/// <param name="Precio"></param>
		/// <param name="TotalVentas"></param>
		/// <param name="PrecioEspecial"></param>
		/// <param name="TotalFactura"></param>
		/// <param name="Descuento"></param>
		/// <param name="Kilometraje"></param>
		/// <param name="UnidadVenta"></param>
		/// <param name="TipoVenta"></param>
		public void Create(long Recibo, long? IdEDS, string Factura, string Tipo, int? Numero, string Tipo52v, int? Numero52v, decimal? Nit, int? Seq, string Cuenta, DateTime? Fecha, string Hora, string NombreCliente, string Estacion, string TipoEstacion, string Destinatario, string Ciudad, string Placa, string Producto, decimal? Cantidad, decimal? Precio, decimal? TotalVentas, decimal? PrecioEspecial, decimal? TotalFactura, decimal? Descuento, decimal? Kilometraje, string UnidadVenta, string TipoVenta,string module, Sinapsys.Datos.SQL datosTransaccion=null)
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

				paramlist.AddWithValue("@Recibo",Recibo);
				if (IdEDS !=null)
				{
					paramlist.AddWithValue("@IdEDS",IdEDS);
				}
				if (Factura !=null)
				{
					paramlist.AddWithValue("@Factura",Factura);
				}
				if (Tipo !=null)
				{
					paramlist.AddWithValue("@Tipo",Tipo);
				}
				if (Numero !=null)
				{
					paramlist.AddWithValue("@Numero",Numero);
				}
				if (Tipo52v !=null)
				{
					paramlist.AddWithValue("@Tipo52v",Tipo52v);
				}
				if (Numero52v !=null)
				{
					paramlist.AddWithValue("@Numero52v",Numero52v);
				}
				if (Nit !=null)
				{
					paramlist.AddWithValue("@Nit",Nit);
				}
				if (Seq !=null)
				{
					paramlist.AddWithValue("@Seq",Seq);
				}
				if (Cuenta !=null)
				{
					paramlist.AddWithValue("@Cuenta",Cuenta);
				}
				if (Fecha !=null)
				{
					paramlist.AddWithValue("@Fecha",Fecha);
				}
				if (Hora !=null)
				{
					paramlist.AddWithValue("@Hora",Hora);
				}
				if (NombreCliente !=null)
				{
					paramlist.AddWithValue("@NombreCliente",NombreCliente);
				}
				if (Estacion !=null)
				{
					paramlist.AddWithValue("@Estacion",Estacion);
				}
				if (TipoEstacion !=null)
				{
					paramlist.AddWithValue("@TipoEstacion",TipoEstacion);
				}
				if (Destinatario !=null)
				{
					paramlist.AddWithValue("@Destinatario",Destinatario);
				}
				if (Ciudad !=null)
				{
					paramlist.AddWithValue("@Ciudad",Ciudad);
				}
				if (Placa !=null)
				{
					paramlist.AddWithValue("@Placa",Placa);
				}
				if (Producto !=null)
				{
					paramlist.AddWithValue("@Producto",Producto);
				}
				if (Cantidad !=null)
				{
					paramlist.AddWithValue("@Cantidad",Cantidad);
				}
				if (Precio !=null)
				{
					paramlist.AddWithValue("@Precio",Precio);
				}
				if (TotalVentas !=null)
				{
					paramlist.AddWithValue("@TotalVentas",TotalVentas);
				}
				if (PrecioEspecial !=null)
				{
					paramlist.AddWithValue("@PrecioEspecial",PrecioEspecial);
				}
				if (TotalFactura !=null)
				{
					paramlist.AddWithValue("@TotalFactura",TotalFactura);
				}
				if (Descuento !=null)
				{
					paramlist.AddWithValue("@Descuento",Descuento);
				}
				if (Kilometraje !=null)
				{
					paramlist.AddWithValue("@Kilometraje",Kilometraje);
				}
				if (UnidadVenta !=null)
				{
					paramlist.AddWithValue("@UnidadVenta",UnidadVenta);
				}
				if (TipoVenta !=null)
				{
					paramlist.AddWithValue("@TipoVenta",TipoVenta);
				}
				LocalDataProvider.EjecutarProcedimiento("dbo.VentasFlotaDetalleCreate", paramlist, disconnect, out nullExit, DataProvider.TiempoEspera);
			}
			catch (Exception ex)
			{
				Utilidades.LogErrores(ex.Message + (ex.InnerException != null ? ex.InnerException.Message : ""), DataProvider.AplicacionNombre);
				throw ex;
			}
		}

		/// <summary>
		/// Updates one record into VentasFlotaDetalle by passing all fields
		/// </summary>
		/// <param name="Recibo"></param>
		/// <param name="IdEDS"></param>
		/// <param name="Factura"></param>
		/// <param name="Tipo"></param>
		/// <param name="Numero"></param>
		/// <param name="Tipo52v"></param>
		/// <param name="Numero52v"></param>
		/// <param name="Nit"></param>
		/// <param name="Seq"></param>
		/// <param name="Cuenta"></param>
		/// <param name="Fecha"></param>
		/// <param name="Hora"></param>
		/// <param name="NombreCliente"></param>
		/// <param name="Estacion"></param>
		/// <param name="TipoEstacion"></param>
		/// <param name="Destinatario"></param>
		/// <param name="Ciudad"></param>
		/// <param name="Placa"></param>
		/// <param name="Producto"></param>
		/// <param name="Cantidad"></param>
		/// <param name="Precio"></param>
		/// <param name="TotalVentas"></param>
		/// <param name="PrecioEspecial"></param>
		/// <param name="TotalFactura"></param>
		/// <param name="Descuento"></param>
		/// <param name="Kilometraje"></param>
		/// <param name="UnidadVenta"></param>
		/// <param name="TipoVenta"></param>
		public void Update(long Recibo, long? IdEDS, string Factura, string Tipo, int? Numero, string Tipo52v, int? Numero52v, decimal? Nit, int? Seq, string Cuenta, DateTime? Fecha, string Hora, string NombreCliente, string Estacion, string TipoEstacion, string Destinatario, string Ciudad, string Placa, string Producto, decimal? Cantidad, decimal? Precio, decimal? TotalVentas, decimal? PrecioEspecial, decimal? TotalFactura, decimal? Descuento, decimal? Kilometraje, string UnidadVenta, string TipoVenta,string module, Sinapsys.Datos.SQL datosTransaccion=null)
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
				paramlist.AddWithValue("@Recibo",Recibo);
				if (IdEDS !=null)
				{
					paramlist.AddWithValue("@IdEDS",IdEDS);
				}
				if (Factura !=null)
				{
					paramlist.AddWithValue("@Factura",Factura);
				}
				if (Tipo !=null)
				{
					paramlist.AddWithValue("@Tipo",Tipo);
				}
				if (Numero !=null)
				{
					paramlist.AddWithValue("@Numero",Numero);
				}
				if (Tipo52v !=null)
				{
					paramlist.AddWithValue("@Tipo52v",Tipo52v);
				}
				if (Numero52v !=null)
				{
					paramlist.AddWithValue("@Numero52v",Numero52v);
				}
				if (Nit !=null)
				{
					paramlist.AddWithValue("@Nit",Nit);
				}
				if (Seq !=null)
				{
					paramlist.AddWithValue("@Seq",Seq);
				}
				if (Cuenta !=null)
				{
					paramlist.AddWithValue("@Cuenta",Cuenta);
				}
				if (Fecha !=null)
				{
					paramlist.AddWithValue("@Fecha",Fecha);
				}
				if (Hora !=null)
				{
					paramlist.AddWithValue("@Hora",Hora);
				}
				if (NombreCliente !=null)
				{
					paramlist.AddWithValue("@NombreCliente",NombreCliente);
				}
				if (Estacion !=null)
				{
					paramlist.AddWithValue("@Estacion",Estacion);
				}
				if (TipoEstacion !=null)
				{
					paramlist.AddWithValue("@TipoEstacion",TipoEstacion);
				}
				if (Destinatario !=null)
				{
					paramlist.AddWithValue("@Destinatario",Destinatario);
				}
				if (Ciudad !=null)
				{
					paramlist.AddWithValue("@Ciudad",Ciudad);
				}
				if (Placa !=null)
				{
					paramlist.AddWithValue("@Placa",Placa);
				}
				if (Producto !=null)
				{
					paramlist.AddWithValue("@Producto",Producto);
				}
				if (Cantidad !=null)
				{
					paramlist.AddWithValue("@Cantidad",Cantidad);
				}
				if (Precio !=null)
				{
					paramlist.AddWithValue("@Precio",Precio);
				}
				if (TotalVentas !=null)
				{
					paramlist.AddWithValue("@TotalVentas",TotalVentas);
				}
				if (PrecioEspecial !=null)
				{
					paramlist.AddWithValue("@PrecioEspecial",PrecioEspecial);
				}
				if (TotalFactura !=null)
				{
					paramlist.AddWithValue("@TotalFactura",TotalFactura);
				}
				if (Descuento !=null)
				{
					paramlist.AddWithValue("@Descuento",Descuento);
				}
				if (Kilometraje !=null)
				{
					paramlist.AddWithValue("@Kilometraje",Kilometraje);
				}
				if (UnidadVenta !=null)
				{
					paramlist.AddWithValue("@UnidadVenta",UnidadVenta);
				}
				if (TipoVenta !=null)
				{
					paramlist.AddWithValue("@TipoVenta",TipoVenta);
				}
				LocalDataProvider.EjecutarProcedimiento("dbo.VentasFlotaDetalleUpdate", paramlist, disconnect, out nullExit, DataProvider.TiempoEspera);
			}
			catch (Exception ex)
			{
				Utilidades.LogErrores(ex.Message + (ex.InnerException != null ? ex.InnerException.Message : ""), DataProvider.AplicacionNombre);
				throw ex;
			}
		}

		/// <summary>
		/// Deletes one record from VentasFlotaDetalle by passing all key fields
		/// </summary>
		/// <param name="Recibo"></param>
		public void Delete(long Recibo,string module, Sinapsys.Datos.SQL datosTransaccion=null)
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
				paramlist.AddWithValue("@Recibo",Recibo);
				LocalDataProvider.EjecutarProcedimiento("dbo.VentasFlotaDetalleDelete", paramlist, disconnect, out nullExit, DataProvider.TiempoEspera);
			}
			catch (Exception ex)
			{
				Utilidades.LogErrores(ex.Message + (ex.InnerException != null ? ex.InnerException.Message : ""), DataProvider.AplicacionNombre);
				throw ex;
			}
		}

		/// <summary>
		/// Gets one record from VentasFlotaDetalle passing all key fields
		/// </summary>
		/// <param name="Recibo"></param>
		/// <returns>A DataTable object containing the data</returns>
		public DataTable Get(long Recibo)
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
				paramlist.AddWithValue("@Recibo",Recibo);
				return LocalDataProvider.EjecutarProcedimiento("dbo.VentasFlotaDetalleGet", paramlist, disconnect, out nullExit, DataProvider.TiempoEspera);

			}
			catch (Exception ex)
			{
				Utilidades.LogErrores(ex.Message + (ex.InnerException != null ? ex.InnerException.Message : ""), DataProvider.AplicacionNombre);
				throw ex;
			}
		}

		/// <summary>
		/// Gets all records from VentasFlotaDetalle
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
				return LocalDataProvider.EjecutarProcedimiento("dbo.VentasFlotaDetalleGetAll", paramlist, disconnect, out nullExit, DataProvider.TiempoEspera);
			}
			catch (Exception ex)
			{
				Utilidades.LogErrores(ex.Message + (ex.InnerException != null ? ex.InnerException.Message : ""), DataProvider.AplicacionNombre);
				throw ex;
			}
		}

		/// <summary>
		/// Gets all records from VentasFlotaDetalle applying filter and sort criteria
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

				return LocalDataProvider.EjecutarProcedimiento("dbo.VentasFlotaDetalleGetFilter", paramlist, disconnect, out nullExit, DataProvider.TiempoEspera);
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
		/// Gets the numbers of records from VentasFlotaDetalle applying filter and sort criteria
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

				return (int) LocalDataProvider.EjecutarProcedimiento("dbo.VentasFlotaDetalleGetFilter", paramlist, disconnect, out nullExit, DataProvider.TiempoEspera).Rows[0][0];
			}
			catch (Exception ex)
			{
				Utilidades.LogErrores(ex.Message + (ex.InnerException != null ? ex.InnerException.Message : ""), DataProvider.AplicacionNombre);
				throw ex;
			}
		}

	}
}
