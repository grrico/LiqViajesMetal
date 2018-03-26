using System;
using System.Data;
using System.Data.Common;
using Sinapsys.Datos;
using LiqViajes_Bll_Data.Security;
using System.Runtime.Serialization;

namespace LiqViajes_Bll_Data
{
	/// <summary>
	/// Data Access Layer class for VentasFlota object
	/// </summary>
	/// <remarks>
	/// This class is a Singleton
	/// </remarks>
	public partial class VentasFlotaDataProvider
	{
		/// <summary>
		/// Internal member for create this singleton
		/// </summary>
		private static VentasFlotaDataProvider MySingleObj = null;

		/// <summary>
		/// Protected constructor to avoid access this singleton other way than calling the Instance method
		/// </summary>
		public VentasFlotaDataProvider()
		{

		}

		/// <summary>
		/// Instance accessor for this singleton
		/// </summary>
		public static VentasFlotaDataProvider Instance
		{
			get
			{
				if (MySingleObj == null)
				{
					MySingleObj = new VentasFlotaDataProvider();
				}

				return MySingleObj;
			}
		}

		/// <summary>
		/// Creates a new record into VentasFlota by passing all fields
		/// </summary>
		/// <param name="CodEds"></param>
		/// <param name="Fecha"></param>
		/// <param name="Tipo"></param>
		/// <param name="Numero"></param>
		/// <param name="Nit"></param>
		/// <param name="Placa"></param>
		/// <param name="Producto"></param>
		/// <param name="Dinero"></param>
		/// <param name="Descuento"></param>
		/// <param name="PrecioEspecial"></param>
		/// <param name="TotalFactura"></param>
		/// <param name="Volumen"></param>
		/// <param name="Kilometraje"></param>
		/// <param name="Factura"></param>
		public void Create(long Recibo, long? CodEds, DateTime? Fecha, string Tipo, int? Numero, decimal? Nit, string Placa, string Producto, decimal? Dinero, decimal? Descuento, decimal? PrecioEspecial, decimal? TotalFactura, decimal? Volumen, decimal? Kilometraje, long? Factura,string module, Sinapsys.Datos.SQL datosTransaccion=null)
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
				if (CodEds !=null)
				{
					paramlist.AddWithValue("@CodEds",CodEds);
				}
				if (Fecha !=null)
				{
					paramlist.AddWithValue("@Fecha",Fecha);
				}
				if (Tipo !=null)
				{
					paramlist.AddWithValue("@Tipo",Tipo);
				}
				if (Numero !=null)
				{
					paramlist.AddWithValue("@Numero",Numero);
				}
				if (Nit !=null)
				{
					paramlist.AddWithValue("@Nit",Nit);
				}
				if (Placa !=null)
				{
					paramlist.AddWithValue("@Placa",Placa);
				}
				if (Producto !=null)
				{
					paramlist.AddWithValue("@Producto",Producto);
				}
				if (Dinero !=null)
				{
					paramlist.AddWithValue("@Dinero",Dinero);
				}
				if (Descuento !=null)
				{
					paramlist.AddWithValue("@Descuento",Descuento);
				}
				if (PrecioEspecial !=null)
				{
					paramlist.AddWithValue("@PrecioEspecial",PrecioEspecial);
				}
				if (TotalFactura !=null)
				{
					paramlist.AddWithValue("@TotalFactura",TotalFactura);
				}
				if (Volumen !=null)
				{
					paramlist.AddWithValue("@Volumen",Volumen);
				}
				if (Kilometraje !=null)
				{
					paramlist.AddWithValue("@Kilometraje",Kilometraje);
				}
				if (Factura !=null)
				{
					paramlist.AddWithValue("@Factura",Factura);
				}
				LocalDataProvider.EjecutarProcedimiento("dbo.VentasFlotaCreate", paramlist, disconnect, out nullExit, DataProvider.TiempoEspera);
			}
			catch (Exception ex)
			{
				Utilidades.LogErrores(ex.Message + (ex.InnerException != null ? ex.InnerException.Message : ""), DataProvider.AplicacionNombre);
				throw ex;
			}
		}

		/// <summary>
		/// Updates one record into VentasFlota by passing all fields
		/// </summary>
		/// <param name="Recibo"></param>
		/// <param name="CodEds"></param>
		/// <param name="Fecha"></param>
		/// <param name="Tipo"></param>
		/// <param name="Numero"></param>
		/// <param name="Nit"></param>
		/// <param name="Placa"></param>
		/// <param name="Producto"></param>
		/// <param name="Dinero"></param>
		/// <param name="Descuento"></param>
		/// <param name="PrecioEspecial"></param>
		/// <param name="TotalFactura"></param>
		/// <param name="Volumen"></param>
		/// <param name="Kilometraje"></param>
		/// <param name="Factura"></param>
		public void Update(long Recibo, long? CodEds, DateTime? Fecha, string Tipo, int? Numero, decimal? Nit, string Placa, string Producto, decimal? Dinero, decimal? Descuento, decimal? PrecioEspecial, decimal? TotalFactura, decimal? Volumen, decimal? Kilometraje, long? Factura,string module, Sinapsys.Datos.SQL datosTransaccion=null)
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
				if (CodEds !=null)
				{
					paramlist.AddWithValue("@CodEds",CodEds);
				}
				if (Fecha !=null)
				{
					paramlist.AddWithValue("@Fecha",Fecha);
				}
				if (Tipo !=null)
				{
					paramlist.AddWithValue("@Tipo",Tipo);
				}
				if (Numero !=null)
				{
					paramlist.AddWithValue("@Numero",Numero);
				}
				if (Nit !=null)
				{
					paramlist.AddWithValue("@Nit",Nit);
				}
				if (Placa !=null)
				{
					paramlist.AddWithValue("@Placa",Placa);
				}
				if (Producto !=null)
				{
					paramlist.AddWithValue("@Producto",Producto);
				}
				if (Dinero !=null)
				{
					paramlist.AddWithValue("@Dinero",Dinero);
				}
				if (Descuento !=null)
				{
					paramlist.AddWithValue("@Descuento",Descuento);
				}
				if (PrecioEspecial !=null)
				{
					paramlist.AddWithValue("@PrecioEspecial",PrecioEspecial);
				}
				if (TotalFactura !=null)
				{
					paramlist.AddWithValue("@TotalFactura",TotalFactura);
				}
				if (Volumen !=null)
				{
					paramlist.AddWithValue("@Volumen",Volumen);
				}
				if (Kilometraje !=null)
				{
					paramlist.AddWithValue("@Kilometraje",Kilometraje);
				}
				if (Factura !=null)
				{
					paramlist.AddWithValue("@Factura",Factura);
				}
				LocalDataProvider.EjecutarProcedimiento("dbo.VentasFlotaUpdate", paramlist, disconnect, out nullExit, DataProvider.TiempoEspera);
			}
			catch (Exception ex)
			{
				Utilidades.LogErrores(ex.Message + (ex.InnerException != null ? ex.InnerException.Message : ""), DataProvider.AplicacionNombre);
				throw ex;
			}
		}

		/// <summary>
		/// Deletes one record from VentasFlota by passing all key fields
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
				LocalDataProvider.EjecutarProcedimiento("dbo.VentasFlotaDelete", paramlist, disconnect, out nullExit, DataProvider.TiempoEspera);
			}
			catch (Exception ex)
			{
				Utilidades.LogErrores(ex.Message + (ex.InnerException != null ? ex.InnerException.Message : ""), DataProvider.AplicacionNombre);
				throw ex;
			}
		}

		/// <summary>
		/// Gets one record from VentasFlota passing all key fields
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
				return LocalDataProvider.EjecutarProcedimiento("dbo.VentasFlotaGet", paramlist, disconnect, out nullExit, DataProvider.TiempoEspera);

			}
			catch (Exception ex)
			{
				Utilidades.LogErrores(ex.Message + (ex.InnerException != null ? ex.InnerException.Message : ""), DataProvider.AplicacionNombre);
				throw ex;
			}
		}

		/// <summary>
		/// Gets all records from VentasFlota
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
				return LocalDataProvider.EjecutarProcedimiento("dbo.VentasFlotaGetAll", paramlist, disconnect, out nullExit, DataProvider.TiempoEspera);
			}
			catch (Exception ex)
			{
				Utilidades.LogErrores(ex.Message + (ex.InnerException != null ? ex.InnerException.Message : ""), DataProvider.AplicacionNombre);
				throw ex;
			}
		}

		/// <summary>
		/// Gets all records from VentasFlota applying filter and sort criteria
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

				return LocalDataProvider.EjecutarProcedimiento("dbo.VentasFlotaGetFilter", paramlist, disconnect, out nullExit, DataProvider.TiempoEspera);
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
		/// Gets the numbers of records from VentasFlota applying filter and sort criteria
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

				return (int) LocalDataProvider.EjecutarProcedimiento("dbo.VentasFlotaGetFilter", paramlist, disconnect, out nullExit, DataProvider.TiempoEspera).Rows[0][0];
			}
			catch (Exception ex)
			{
				Utilidades.LogErrores(ex.Message + (ex.InnerException != null ? ex.InnerException.Message : ""), DataProvider.AplicacionNombre);
				throw ex;
			}
		}

	}
}
