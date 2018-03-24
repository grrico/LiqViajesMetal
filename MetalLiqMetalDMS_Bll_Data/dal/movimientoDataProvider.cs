using System;
using System.Data;
using System.Data.Common;
using Sinapsys.Datos;
using LiqMetalDMS_Bll_Data.Security;
using System.Runtime.Serialization;

namespace LiqMetalDMS_Bll_Data
{
	/// <summary>
	/// Data Access Layer class for movimiento object
	/// </summary>
	/// <remarks>
	/// This class is a Singleton
	/// </remarks>
	public partial class movimientoDataProvider
	{
		/// <summary>
		/// Internal member for create this singleton
		/// </summary>
		private static movimientoDataProvider MySingleObj = null;

		/// <summary>
		/// Protected constructor to avoid access this singleton other way than calling the Instance method
		/// </summary>
		public movimientoDataProvider()
		{

		}

		/// <summary>
		/// Instance accessor for this singleton
		/// </summary>
		public static movimientoDataProvider Instance
		{
			get
			{
				if (MySingleObj == null)
				{
					MySingleObj = new movimientoDataProvider();
				}

				return MySingleObj;
			}
		}

		/// <summary>
		/// Creates a new record into movimiento by passing all fields
		/// </summary>
		/// <param name="cuenta"></param>
		/// <param name="centro"></param>
		/// <param name="nit"></param>
		/// <param name="fec"></param>
		/// <param name="valor"></param>
		/// <param name="base"></param>
		/// <param name="documento"></param>
		/// <param name="explicacion"></param>
		/// <param name="concilio"></param>
		/// <param name="concepto_mov"></param>
		/// <param name="concilio_ano"></param>
		/// <param name="secuencia_extracto"></param>
		/// <param name="ano_concilia"></param>
		/// <param name="mes_concilia"></param>
		/// <param name="ID_CRUCE"></param>
		/// <param name="TIPO_CRUCE"></param>
		/// <param name="valor_niif"></param>
		public void Create(string tipo, int numero, int seq, string cuenta, int centro, decimal nit, DateTime fec, decimal valor, int? documento, string explicacion, string concilio, short? concepto_mov, short? concilio_ano, int? secuencia_extracto, int? ano_concilia, int? mes_concilia, int? ID_CRUCE, string TIPO_CRUCE, decimal valor_niif,string module, Sinapsys.Datos.SQL datosTransaccion=null)
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
				paramlist.AddWithValue("@seq",seq);
				paramlist.AddWithValue("@cuenta",cuenta);
				paramlist.AddWithValue("@centro",centro);
				paramlist.AddWithValue("@nit",nit);
				paramlist.AddWithValue("@fec",fec);
				paramlist.AddWithValue("@valor",valor);
				//if (base !=null)
				//{
				//	paramlist.AddWithValue("@base",base);
				//}
				if (documento !=null)
				{
					paramlist.AddWithValue("@documento",documento);
				}
				if (explicacion !=null)
				{
					paramlist.AddWithValue("@explicacion",explicacion);
				}
				if (concilio !=null)
				{
					paramlist.AddWithValue("@concilio",concilio);
				}
				if (concepto_mov !=null)
				{
					paramlist.AddWithValue("@concepto_mov",concepto_mov);
				}
				if (concilio_ano !=null)
				{
					paramlist.AddWithValue("@concilio_ano",concilio_ano);
				}
				if (secuencia_extracto !=null)
				{
					paramlist.AddWithValue("@secuencia_extracto",secuencia_extracto);
				}
				if (ano_concilia !=null)
				{
					paramlist.AddWithValue("@ano_concilia",ano_concilia);
				}
				if (mes_concilia !=null)
				{
					paramlist.AddWithValue("@mes_concilia",mes_concilia);
				}
				if (ID_CRUCE !=null)
				{
					paramlist.AddWithValue("@ID_CRUCE",ID_CRUCE);
				}
				if (TIPO_CRUCE !=null)
				{
					paramlist.AddWithValue("@TIPO_CRUCE",TIPO_CRUCE);
				}
				paramlist.AddWithValue("@valor_niif",valor_niif);
				LocalDataProvider.EjecutarProcedimiento("dbo.movimientoCreate", paramlist, disconnect, out nullExit, DataProvider.TiempoEspera);
			}
			catch (Exception ex)
			{
				Utilidades.LogErrores(ex.Message + (ex.InnerException != null ? ex.InnerException.Message : ""), DataProvider.AplicacionNombre);
				throw ex;
			}
		}

		/// <summary>
		/// Updates one record into movimiento by passing all fields
		/// </summary>
		/// <param name="tipo"></param>
		/// <param name="numero"></param>
		/// <param name="seq"></param>
		/// <param name="cuenta"></param>
		/// <param name="centro"></param>
		/// <param name="nit"></param>
		/// <param name="fec"></param>
		/// <param name="valor"></param>
		/// <param name="base"></param>
		/// <param name="documento"></param>
		/// <param name="explicacion"></param>
		/// <param name="concilio"></param>
		/// <param name="concepto_mov"></param>
		/// <param name="concilio_ano"></param>
		/// <param name="secuencia_extracto"></param>
		/// <param name="ano_concilia"></param>
		/// <param name="mes_concilia"></param>
		/// <param name="ID_CRUCE"></param>
		/// <param name="TIPO_CRUCE"></param>
		/// <param name="valor_niif"></param>
		public void Update(string tipo, int numero, int seq, string cuenta, int centro, decimal nit, DateTime fec, decimal valor, int? documento, string explicacion, string concilio, short? concepto_mov, short? concilio_ano, int? secuencia_extracto, int? ano_concilia, int? mes_concilia, int? ID_CRUCE, string TIPO_CRUCE, decimal valor_niif,string module, Sinapsys.Datos.SQL datosTransaccion=null)
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
				paramlist.AddWithValue("@seq",seq);
				paramlist.AddWithValue("@cuenta",cuenta);
				paramlist.AddWithValue("@centro",centro);
				paramlist.AddWithValue("@nit",nit);
				paramlist.AddWithValue("@fec",fec);
				paramlist.AddWithValue("@valor",valor);
				//if (base !=null)
				//{
				//	paramlist.AddWithValue("@base",base);
				//}
				if (documento !=null)
				{
					paramlist.AddWithValue("@documento",documento);
				}
				if (explicacion !=null)
				{
					paramlist.AddWithValue("@explicacion",explicacion);
				}
				if (concilio !=null)
				{
					paramlist.AddWithValue("@concilio",concilio);
				}
				if (concepto_mov !=null)
				{
					paramlist.AddWithValue("@concepto_mov",concepto_mov);
				}
				if (concilio_ano !=null)
				{
					paramlist.AddWithValue("@concilio_ano",concilio_ano);
				}
				if (secuencia_extracto !=null)
				{
					paramlist.AddWithValue("@secuencia_extracto",secuencia_extracto);
				}
				if (ano_concilia !=null)
				{
					paramlist.AddWithValue("@ano_concilia",ano_concilia);
				}
				if (mes_concilia !=null)
				{
					paramlist.AddWithValue("@mes_concilia",mes_concilia);
				}
				if (ID_CRUCE !=null)
				{
					paramlist.AddWithValue("@ID_CRUCE",ID_CRUCE);
				}
				if (TIPO_CRUCE !=null)
				{
					paramlist.AddWithValue("@TIPO_CRUCE",TIPO_CRUCE);
				}
				paramlist.AddWithValue("@valor_niif",valor_niif);
				LocalDataProvider.EjecutarProcedimiento("dbo.movimientoUpdate", paramlist, disconnect, out nullExit, DataProvider.TiempoEspera);
			}
			catch (Exception ex)
			{
				Utilidades.LogErrores(ex.Message + (ex.InnerException != null ? ex.InnerException.Message : ""), DataProvider.AplicacionNombre);
				throw ex;
			}
		}

		/// <summary>
		/// Deletes one record from movimiento by passing all key fields
		/// </summary>
		/// <param name="tipo"></param>
		/// <param name="numero"></param>
		/// <param name="seq"></param>
		public void Delete(string tipo, int numero, int seq,string module, Sinapsys.Datos.SQL datosTransaccion=null)
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
				paramlist.AddWithValue("@seq",seq);
				LocalDataProvider.EjecutarProcedimiento("dbo.movimientoDelete", paramlist, disconnect, out nullExit, DataProvider.TiempoEspera);
			}
			catch (Exception ex)
			{
				Utilidades.LogErrores(ex.Message + (ex.InnerException != null ? ex.InnerException.Message : ""), DataProvider.AplicacionNombre);
				throw ex;
			}
		}

		/// <summary>
		/// Gets one record from movimiento passing all key fields
		/// </summary>
		/// <param name="tipo"></param>
		/// <param name="numero"></param>
		/// <param name="seq"></param>
		/// <returns>A DataTable object containing the data</returns>
		public DataTable Get(string tipo, int numero, int seq)
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
				paramlist.AddWithValue("@seq",seq);
				return LocalDataProvider.EjecutarProcedimiento("dbo.movimientoGet", paramlist, disconnect, out nullExit, DataProvider.TiempoEspera);

			}
			catch (Exception ex)
			{
				Utilidades.LogErrores(ex.Message + (ex.InnerException != null ? ex.InnerException.Message : ""), DataProvider.AplicacionNombre);
				throw ex;
			}
		}

		/// <summary>
		/// Gets all records from movimiento
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
				return LocalDataProvider.EjecutarProcedimiento("dbo.movimientoGetAll", paramlist, disconnect, out nullExit, DataProvider.TiempoEspera);
			}
			catch (Exception ex)
			{
				Utilidades.LogErrores(ex.Message + (ex.InnerException != null ? ex.InnerException.Message : ""), DataProvider.AplicacionNombre);
				throw ex;
			}
		}

		/// <summary>
		/// Gets all records from movimiento that are related to cruce_conciliacion
		/// </summary>
		/// <param name="ID_CRUCE"></param>
		/// <returns>A DataTable object containing all records data</returns>
		public DataTable GetBy_ID_CRUCE(int ID_CRUCE)
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

				paramlist.AddWithValue("@ID_CRUCE",ID_CRUCE);
				return LocalDataProvider.EjecutarProcedimiento("dbo.movimientoGetBy_ID_CRUCE", paramlist, disconnect, out nullExit, DataProvider.TiempoEspera);
			}
			catch (Exception ex)
			{
				Utilidades.LogErrores(ex.Message + (ex.InnerException != null ? ex.InnerException.Message : ""), DataProvider.AplicacionNombre);
				throw ex;
			}
		}

		/// <summary>
		/// Gets all records from movimiento applying filter and sort criteria
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

				return LocalDataProvider.EjecutarProcedimiento("dbo.movimientoGetFilter", paramlist, disconnect, out nullExit, DataProvider.TiempoEspera);
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
		/// Gets the numbers of records from movimiento applying filter and sort criteria
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

				return (int) LocalDataProvider.EjecutarProcedimiento("dbo.movimientoGetFilter", paramlist, disconnect, out nullExit, DataProvider.TiempoEspera).Rows[0][0];
			}
			catch (Exception ex)
			{
				Utilidades.LogErrores(ex.Message + (ex.InnerException != null ? ex.InnerException.Message : ""), DataProvider.AplicacionNombre);
				throw ex;
			}
		}

	}
}
