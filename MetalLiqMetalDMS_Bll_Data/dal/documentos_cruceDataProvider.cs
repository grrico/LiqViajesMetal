using System;
using System.Data;
using System.Data.Common;
using Sinapsys.Datos;
using LiqMetalDMS_Bll_Data.Security;
using System.Runtime.Serialization;

namespace LiqMetalDMS_Bll_Data
{
	/// <summary>
	/// Data Access Layer class for documentos_cruce object
	/// </summary>
	/// <remarks>
	/// This class is a Singleton
	/// </remarks>
	public partial class documentos_cruceDataProvider
	{
		/// <summary>
		/// Internal member for create this singleton
		/// </summary>
		private static documentos_cruceDataProvider MySingleObj = null;

		/// <summary>
		/// Protected constructor to avoid access this singleton other way than calling the Instance method
		/// </summary>
		public documentos_cruceDataProvider()
		{

		}

		/// <summary>
		/// Instance accessor for this singleton
		/// </summary>
		public static documentos_cruceDataProvider Instance
		{
			get
			{
				if (MySingleObj == null)
				{
					MySingleObj = new documentos_cruceDataProvider();
				}

				return MySingleObj;
			}
		}

		/// <summary>
		/// Creates a new record into documentos_cruce by passing all fields
		/// </summary>
		/// <param name="sw"></param>
		/// <param name="valor"></param>
		/// <param name="descuento"></param>
		/// <param name="retencion"></param>
		/// <param name="ajuste"></param>
		/// <param name="retencion_iva"></param>
		/// <param name="retencion_ica"></param>
		/// <param name="fecha"></param>
		/// <param name="retencion2"></param>
		/// <param name="retencion3"></param>
		/// <param name="fecha_cruce"></param>
		/// <param name="trasporte"></param>
		/// <param name="cree"></param>
		/// <returns>int that contents the id value</returns>
		public int Create(int id, string tipo, int numero, string tipo_aplica, int numero_aplica, short numero_cuota, byte sw, decimal? valor, decimal? descuento, decimal? retencion, decimal? ajuste, decimal? retencion_iva, decimal? retencion_ica, DateTime? fecha, decimal? retencion2, decimal? retencion3, DateTime? fecha_cruce, char? trasporte, decimal? cree,string module, Sinapsys.Datos.SQL datosTransaccion=null)
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
				paramlist.AddWithValue("@tipo_aplica",tipo_aplica);
				paramlist.AddWithValue("@numero_aplica",numero_aplica);
				paramlist.AddWithValue("@numero_cuota",numero_cuota);
				paramlist.AddWithValue("@sw",sw);
				if (valor !=null)
				{
					paramlist.AddWithValue("@valor",valor);
				}
				if (descuento !=null)
				{
					paramlist.AddWithValue("@descuento",descuento);
				}
				if (retencion !=null)
				{
					paramlist.AddWithValue("@retencion",retencion);
				}
				if (ajuste !=null)
				{
					paramlist.AddWithValue("@ajuste",ajuste);
				}
				if (retencion_iva !=null)
				{
					paramlist.AddWithValue("@retencion_iva",retencion_iva);
				}
				if (retencion_ica !=null)
				{
					paramlist.AddWithValue("@retencion_ica",retencion_ica);
				}
				if (fecha !=null)
				{
					paramlist.AddWithValue("@fecha",fecha);
				}
				if (retencion2 !=null)
				{
					paramlist.AddWithValue("@retencion2",retencion2);
				}
				if (retencion3 !=null)
				{
					paramlist.AddWithValue("@retencion3",retencion3);
				}
				if (fecha_cruce !=null)
				{
					paramlist.AddWithValue("@fecha_cruce",fecha_cruce);
				}
				if (trasporte !=null)
				{
					paramlist.AddWithValue("@trasporte",trasporte);
				}
				if (cree !=null)
				{
					paramlist.AddWithValue("@cree",cree);
				}
				// Execute the query and return the new identity value
				int returnValue = Convert.ToInt32(LocalDataProvider.EjecutarProcedimiento("dbo.documentos_cruceCreate", paramlist, disconnect, out nullExit, DataProvider.TiempoEspera).Rows[0][0]);

				return returnValue;
			}
			catch (Exception ex)
			{
				Utilidades.LogErrores(ex.Message + (ex.InnerException != null ? ex.InnerException.Message : ""), DataProvider.AplicacionNombre);
				throw ex;
			}
		}

		/// <summary>
		/// Updates one record into documentos_cruce by passing all fields
		/// </summary>
		/// <param name="id"></param>
		/// <param name="tipo"></param>
		/// <param name="numero"></param>
		/// <param name="sw"></param>
		/// <param name="tipo_aplica"></param>
		/// <param name="numero_aplica"></param>
		/// <param name="numero_cuota"></param>
		/// <param name="valor"></param>
		/// <param name="descuento"></param>
		/// <param name="retencion"></param>
		/// <param name="ajuste"></param>
		/// <param name="retencion_iva"></param>
		/// <param name="retencion_ica"></param>
		/// <param name="fecha"></param>
		/// <param name="retencion2"></param>
		/// <param name="retencion3"></param>
		/// <param name="fecha_cruce"></param>
		/// <param name="trasporte"></param>
		/// <param name="cree"></param>
		public void Update(int id, string tipo, int numero, byte sw, string tipo_aplica, int numero_aplica, short numero_cuota, decimal? valor, decimal? descuento, decimal? retencion, decimal? ajuste, decimal? retencion_iva, decimal? retencion_ica, DateTime? fecha, decimal? retencion2, decimal? retencion3, DateTime? fecha_cruce, char? trasporte, decimal? cree,string module, Sinapsys.Datos.SQL datosTransaccion=null)
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
				paramlist.AddWithValue("@tipo_aplica",tipo_aplica);
				paramlist.AddWithValue("@numero_aplica",numero_aplica);
				paramlist.AddWithValue("@numero_cuota",numero_cuota);
				paramlist.AddWithValue("@sw",sw);
				if (valor !=null)
				{
					paramlist.AddWithValue("@valor",valor);
				}
				if (descuento !=null)
				{
					paramlist.AddWithValue("@descuento",descuento);
				}
				if (retencion !=null)
				{
					paramlist.AddWithValue("@retencion",retencion);
				}
				if (ajuste !=null)
				{
					paramlist.AddWithValue("@ajuste",ajuste);
				}
				if (retencion_iva !=null)
				{
					paramlist.AddWithValue("@retencion_iva",retencion_iva);
				}
				if (retencion_ica !=null)
				{
					paramlist.AddWithValue("@retencion_ica",retencion_ica);
				}
				if (fecha !=null)
				{
					paramlist.AddWithValue("@fecha",fecha);
				}
				if (retencion2 !=null)
				{
					paramlist.AddWithValue("@retencion2",retencion2);
				}
				if (retencion3 !=null)
				{
					paramlist.AddWithValue("@retencion3",retencion3);
				}
				if (fecha_cruce !=null)
				{
					paramlist.AddWithValue("@fecha_cruce",fecha_cruce);
				}
				if (trasporte !=null)
				{
					paramlist.AddWithValue("@trasporte",trasporte);
				}
				if (cree !=null)
				{
					paramlist.AddWithValue("@cree",cree);
				}
				LocalDataProvider.EjecutarProcedimiento("dbo.documentos_cruceUpdate", paramlist, disconnect, out nullExit, DataProvider.TiempoEspera);
			}
			catch (Exception ex)
			{
				Utilidades.LogErrores(ex.Message + (ex.InnerException != null ? ex.InnerException.Message : ""), DataProvider.AplicacionNombre);
				throw ex;
			}
		}

		/// <summary>
		/// Deletes one record from documentos_cruce by passing all key fields
		/// </summary>
		/// <param name="id"></param>
		/// <param name="tipo"></param>
		/// <param name="numero"></param>
		/// <param name="tipo_aplica"></param>
		/// <param name="numero_aplica"></param>
		/// <param name="numero_cuota"></param>
		public void Delete(int id, string tipo, int numero, string tipo_aplica, int numero_aplica, short numero_cuota,string module, Sinapsys.Datos.SQL datosTransaccion=null)
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
				paramlist.AddWithValue("@tipo_aplica",tipo_aplica);
				paramlist.AddWithValue("@numero_aplica",numero_aplica);
				paramlist.AddWithValue("@numero_cuota",numero_cuota);
				LocalDataProvider.EjecutarProcedimiento("dbo.documentos_cruceDelete", paramlist, disconnect, out nullExit, DataProvider.TiempoEspera);
			}
			catch (Exception ex)
			{
				Utilidades.LogErrores(ex.Message + (ex.InnerException != null ? ex.InnerException.Message : ""), DataProvider.AplicacionNombre);
				throw ex;
			}
		}

		/// <summary>
		/// Gets one record from documentos_cruce passing all key fields
		/// </summary>
		/// <param name="id"></param>
		/// <param name="tipo"></param>
		/// <param name="numero"></param>
		/// <param name="tipo_aplica"></param>
		/// <param name="numero_aplica"></param>
		/// <param name="numero_cuota"></param>
		/// <returns>A DataTable object containing the data</returns>
		public DataTable Get(int id, string tipo, int numero, string tipo_aplica, int numero_aplica, short numero_cuota)
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
				paramlist.AddWithValue("@tipo_aplica",tipo_aplica);
				paramlist.AddWithValue("@numero_aplica",numero_aplica);
				paramlist.AddWithValue("@numero_cuota",numero_cuota);
				return LocalDataProvider.EjecutarProcedimiento("dbo.documentos_cruceGet", paramlist, disconnect, out nullExit, DataProvider.TiempoEspera);

			}
			catch (Exception ex)
			{
				Utilidades.LogErrores(ex.Message + (ex.InnerException != null ? ex.InnerException.Message : ""), DataProvider.AplicacionNombre);
				throw ex;
			}
		}

		/// <summary>
		/// Gets all records from documentos_cruce
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
				return LocalDataProvider.EjecutarProcedimiento("dbo.documentos_cruceGetAll", paramlist, disconnect, out nullExit, DataProvider.TiempoEspera);
			}
			catch (Exception ex)
			{
				Utilidades.LogErrores(ex.Message + (ex.InnerException != null ? ex.InnerException.Message : ""), DataProvider.AplicacionNombre);
				throw ex;
			}
		}

		/// <summary>
		/// Gets all records from documentos_cruce that are related to documentos
		/// </summary>
		/// <param name="tipo"></param>
		/// <param name="numero"></param>
		/// <returns>A DataTable object containing all records data</returns>
		public DataTable GetBy_tipo_numero(string tipo, int numero)
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
				return LocalDataProvider.EjecutarProcedimiento("dbo.documentos_cruceGetBy_tipo_numero", paramlist, disconnect, out nullExit, DataProvider.TiempoEspera);
			}
			catch (Exception ex)
			{
				Utilidades.LogErrores(ex.Message + (ex.InnerException != null ? ex.InnerException.Message : ""), DataProvider.AplicacionNombre);
				throw ex;
			}
		}

		/// <summary>
		/// Gets all records from documentos_cruce applying filter and sort criteria
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

				return LocalDataProvider.EjecutarProcedimiento("dbo.documentos_cruceGetFilter", paramlist, disconnect, out nullExit, DataProvider.TiempoEspera);
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
		/// Gets the numbers of records from documentos_cruce applying filter and sort criteria
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

				return (int) LocalDataProvider.EjecutarProcedimiento("dbo.documentos_cruceGetFilter", paramlist, disconnect, out nullExit, DataProvider.TiempoEspera).Rows[0][0];
			}
			catch (Exception ex)
			{
				Utilidades.LogErrores(ex.Message + (ex.InnerException != null ? ex.InnerException.Message : ""), DataProvider.AplicacionNombre);
				throw ex;
			}
		}

	}
}
