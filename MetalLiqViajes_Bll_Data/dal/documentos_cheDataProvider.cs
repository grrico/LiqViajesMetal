using System;
using System.Data;
using System.Data.Common;
using Sinapsys.Datos;
using LiqViajes_Bll_Data.Security;
using System.Runtime.Serialization;

namespace LiqViajes_Bll_Data
{
	/// <summary>
	/// Data Access Layer class for documentos_che object
	/// </summary>
	/// <remarks>
	/// This class is a Singleton
	/// </remarks>
	public partial class documentos_cheDataProvider
	{
		/// <summary>
		/// Internal member for create this singleton
		/// </summary>
		private static documentos_cheDataProvider MySingleObj = null;

		/// <summary>
		/// Protected constructor to avoid access this singleton other way than calling the Instance method
		/// </summary>
		public documentos_cheDataProvider()
		{

		}

		/// <summary>
		/// Instance accessor for this singleton
		/// </summary>
		public static documentos_cheDataProvider Instance
		{
			get
			{
				if (MySingleObj == null)
				{
					MySingleObj = new documentos_cheDataProvider();
				}

				return MySingleObj;
			}
		}

		/// <summary>
		/// Creates a new record into documentos_che by passing all fields
		/// </summary>
		/// <param name="sw"></param>
		/// <param name="fecha"></param>
		/// <param name="valor"></param>
		/// <param name="consignar_en"></param>
		/// <param name="devuelto"></param>
		/// <param name="tipo_consignacion"></param>
		/// <param name="numero_consignacion"></param>
		/// <param name="fecha_devolucion"></param>
		/// <param name="cuenta_banco"></param>
		/// <param name="iva_tarjeta"></param>
		public void Create(string tipo, int numero, short banco, string documento, byte forma_pago, byte sw, DateTime fecha, decimal valor, short consignar_en, string devuelto, string tipo_consignacion, int? numero_consignacion, DateTime? fecha_devolucion, string cuenta_banco, decimal? iva_tarjeta,string module, Sinapsys.Datos.SQL datosTransaccion=null)
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

				paramlist.AddWithValue("@tipo",tipo);
				paramlist.AddWithValue("@numero",numero);
				paramlist.AddWithValue("@banco",banco);
				paramlist.AddWithValue("@documento",documento);
				paramlist.AddWithValue("@forma_pago",forma_pago);
				paramlist.AddWithValue("@sw",sw);
				paramlist.AddWithValue("@fecha",fecha);
				paramlist.AddWithValue("@valor",valor);
				paramlist.AddWithValue("@consignar_en",consignar_en);
				if (devuelto !=null)
				{
					paramlist.AddWithValue("@devuelto",devuelto);
				}
				if (tipo_consignacion !=null)
				{
					paramlist.AddWithValue("@tipo_consignacion",tipo_consignacion);
				}
				if (numero_consignacion !=null)
				{
					paramlist.AddWithValue("@numero_consignacion",numero_consignacion);
				}
				if (fecha_devolucion !=null)
				{
					paramlist.AddWithValue("@fecha_devolucion",fecha_devolucion);
				}
				if (cuenta_banco !=null)
				{
					paramlist.AddWithValue("@cuenta_banco",cuenta_banco);
				}
				if (iva_tarjeta !=null)
				{
					paramlist.AddWithValue("@iva_tarjeta",iva_tarjeta);
				}
				LocalDataProvider.EjecutarProcedimiento("dbo.documentos_cheCreate", paramlist, disconnect, out nullExit, DataProvider.TiempoEspera);
			}
			catch (Exception ex)
			{
				Utilidades.LogErrores(ex.Message + (ex.InnerException != null ? ex.InnerException.Message : ""), DataProvider.AplicacionNombre);
				throw ex;
			}
		}

		/// <summary>
		/// Updates one record into documentos_che by passing all fields
		/// </summary>
		/// <param name="sw"></param>
		/// <param name="tipo"></param>
		/// <param name="numero"></param>
		/// <param name="banco"></param>
		/// <param name="documento"></param>
		/// <param name="forma_pago"></param>
		/// <param name="fecha"></param>
		/// <param name="valor"></param>
		/// <param name="consignar_en"></param>
		/// <param name="devuelto"></param>
		/// <param name="tipo_consignacion"></param>
		/// <param name="numero_consignacion"></param>
		/// <param name="fecha_devolucion"></param>
		/// <param name="cuenta_banco"></param>
		/// <param name="iva_tarjeta"></param>
		public void Update(byte sw, string tipo, int numero, short banco, string documento, byte forma_pago, DateTime fecha, decimal valor, short consignar_en, string devuelto, string tipo_consignacion, int? numero_consignacion, DateTime? fecha_devolucion, string cuenta_banco, decimal? iva_tarjeta,string module, Sinapsys.Datos.SQL datosTransaccion=null)
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
				paramlist.AddWithValue("@tipo",tipo);
				paramlist.AddWithValue("@numero",numero);
				paramlist.AddWithValue("@banco",banco);
				paramlist.AddWithValue("@documento",documento);
				paramlist.AddWithValue("@forma_pago",forma_pago);
				paramlist.AddWithValue("@sw",sw);
				paramlist.AddWithValue("@fecha",fecha);
				paramlist.AddWithValue("@valor",valor);
				paramlist.AddWithValue("@consignar_en",consignar_en);
				if (devuelto !=null)
				{
					paramlist.AddWithValue("@devuelto",devuelto);
				}
				if (tipo_consignacion !=null)
				{
					paramlist.AddWithValue("@tipo_consignacion",tipo_consignacion);
				}
				if (numero_consignacion !=null)
				{
					paramlist.AddWithValue("@numero_consignacion",numero_consignacion);
				}
				if (fecha_devolucion !=null)
				{
					paramlist.AddWithValue("@fecha_devolucion",fecha_devolucion);
				}
				if (cuenta_banco !=null)
				{
					paramlist.AddWithValue("@cuenta_banco",cuenta_banco);
				}
				if (iva_tarjeta !=null)
				{
					paramlist.AddWithValue("@iva_tarjeta",iva_tarjeta);
				}
				LocalDataProvider.EjecutarProcedimiento("dbo.documentos_cheUpdate", paramlist, disconnect, out nullExit, DataProvider.TiempoEspera);
			}
			catch (Exception ex)
			{
				Utilidades.LogErrores(ex.Message + (ex.InnerException != null ? ex.InnerException.Message : ""), DataProvider.AplicacionNombre);
				throw ex;
			}
		}

		/// <summary>
		/// Deletes one record from documentos_che by passing all key fields
		/// </summary>
		/// <param name="tipo"></param>
		/// <param name="numero"></param>
		/// <param name="banco"></param>
		/// <param name="documento"></param>
		/// <param name="forma_pago"></param>
		public void Delete(string tipo, int numero, short banco, string documento, byte forma_pago,string module, Sinapsys.Datos.SQL datosTransaccion=null)
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
				paramlist.AddWithValue("@tipo",tipo);
				paramlist.AddWithValue("@numero",numero);
				paramlist.AddWithValue("@banco",banco);
				paramlist.AddWithValue("@documento",documento);
				paramlist.AddWithValue("@forma_pago",forma_pago);
				LocalDataProvider.EjecutarProcedimiento("dbo.documentos_cheDelete", paramlist, disconnect, out nullExit, DataProvider.TiempoEspera);
			}
			catch (Exception ex)
			{
				Utilidades.LogErrores(ex.Message + (ex.InnerException != null ? ex.InnerException.Message : ""), DataProvider.AplicacionNombre);
				throw ex;
			}
		}

		/// <summary>
		/// Gets one record from documentos_che passing all key fields
		/// </summary>
		/// <param name="tipo"></param>
		/// <param name="numero"></param>
		/// <param name="banco"></param>
		/// <param name="documento"></param>
		/// <param name="forma_pago"></param>
		/// <returns>A DataTable object containing the data</returns>
		public DataTable Get(string tipo, int numero, short banco, string documento, byte forma_pago)
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
				paramlist.AddWithValue("@tipo",tipo);
				paramlist.AddWithValue("@numero",numero);
				paramlist.AddWithValue("@banco",banco);
				paramlist.AddWithValue("@documento",documento);
				paramlist.AddWithValue("@forma_pago",forma_pago);
				return LocalDataProvider.EjecutarProcedimiento("dbo.documentos_cheGet", paramlist, disconnect, out nullExit, DataProvider.TiempoEspera);

			}
			catch (Exception ex)
			{
				Utilidades.LogErrores(ex.Message + (ex.InnerException != null ? ex.InnerException.Message : ""), DataProvider.AplicacionNombre);
				throw ex;
			}
		}

		/// <summary>
		/// Gets all records from documentos_che
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
				return LocalDataProvider.EjecutarProcedimiento("dbo.documentos_cheGetAll", paramlist, disconnect, out nullExit, DataProvider.TiempoEspera);
			}
			catch (Exception ex)
			{
				Utilidades.LogErrores(ex.Message + (ex.InnerException != null ? ex.InnerException.Message : ""), DataProvider.AplicacionNombre);
				throw ex;
			}
		}

		/// <summary>
		/// Gets all records from documentos_che applying filter and sort criteria
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

				return LocalDataProvider.EjecutarProcedimiento("dbo.documentos_cheGetFilter", paramlist, disconnect, out nullExit, DataProvider.TiempoEspera);
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
		/// Gets the numbers of records from documentos_che applying filter and sort criteria
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

				return (int) LocalDataProvider.EjecutarProcedimiento("dbo.documentos_cheGetFilter", paramlist, disconnect, out nullExit, DataProvider.TiempoEspera).Rows[0][0];
			}
			catch (Exception ex)
			{
				Utilidades.LogErrores(ex.Message + (ex.InnerException != null ? ex.InnerException.Message : ""), DataProvider.AplicacionNombre);
				throw ex;
			}
		}

	}
}
