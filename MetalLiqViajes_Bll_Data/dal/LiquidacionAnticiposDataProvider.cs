using System;
using System.Data;
using System.Data.Common;
using Sinapsys.Datos;
using LiqViajes_Bll_Data.Security;
using System.Runtime.Serialization;

namespace LiqViajes_Bll_Data
{
	/// <summary>
	/// Data Access Layer class for LiquidacionAnticipos object
	/// </summary>
	/// <remarks>
	/// This class is a Singleton
	/// </remarks>
	public partial class LiquidacionAnticiposDataProvider
	{
		/// <summary>
		/// Internal member for create this singleton
		/// </summary>
		private static LiquidacionAnticiposDataProvider MySingleObj = null;

		/// <summary>
		/// Protected constructor to avoid access this singleton other way than calling the Instance method
		/// </summary>
		public LiquidacionAnticiposDataProvider()
		{

		}

		/// <summary>
		/// Instance accessor for this singleton
		/// </summary>
		public static LiquidacionAnticiposDataProvider Instance
		{
			get
			{
				if (MySingleObj == null)
				{
					MySingleObj = new LiquidacionAnticiposDataProvider();
				}

				return MySingleObj;
			}
		}

		/// <summary>
		/// Creates a new record into tblLiquidacionAnticipos by passing all fields
		/// </summary>
		/// <param name="strConductor"></param>
		/// <param name="dtmFechaMovimiento"></param>
		/// <param name="strdescripcionBanco"></param>
		/// <param name="sw"></param>
		/// <param name="dtmFechaMovDMS"></param>
		/// <param name="strCuenta"></param>
		/// <param name="strCuenta2"></param>
		/// <param name="strdescripcionCuenta"></param>
		/// <param name="strdescripcionCuenta2"></param>
		/// <param name="curValor"></param>
		/// <param name="strdescripcionModelo"></param>
		/// <param name="strNota"></param>
		/// <param name="strdocumento"></param>
		/// <param name="strUsuarioDMS"></param>
		/// <param name="dtmfechahoraSYSDMS"></param>
		/// <param name="intUsuario"></param>
		/// <param name="dtmFechaModif"></param>
		/// <param name="logAnulado"></param>
		/// <param name="logLiquidado"></param>
		/// <returns>int that contents the lngIdRegistroViaje value</returns>
		public int Create(int lngIdRegistroViaje, decimal lngIdRegistroViajeTramo, decimal intNitConductor, string strPlaca, double lngIdBanco, int intDocumento, string strModelo, string strtipo, string strConductor, DateTime? dtmFechaMovimiento, string strdescripcionBanco, byte? sw, DateTime? dtmFechaMovDMS, string strCuenta, string strCuenta2, string strdescripcionCuenta, string strdescripcionCuenta2, decimal? curValor, string strdescripcionModelo, string strNota, string strdocumento, string strUsuarioDMS, DateTime? dtmfechahoraSYSDMS, int? intUsuario, DateTime? dtmFechaModif, bool? logAnulado, bool? logLiquidado,string module, Sinapsys.Datos.SQL datosTransaccion=null)
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

				paramlist.AddWithValue("@lngIdRegistroViaje",lngIdRegistroViaje);
				paramlist.AddWithValue("@lngIdRegistroViajeTramo",lngIdRegistroViajeTramo);
				paramlist.AddWithValue("@intNitConductor",intNitConductor);
				paramlist.AddWithValue("@strPlaca",strPlaca);
				paramlist.AddWithValue("@lngIdBanco",lngIdBanco);
				paramlist.AddWithValue("@intDocumento",intDocumento);
				paramlist.AddWithValue("@strModelo",strModelo);
				paramlist.AddWithValue("@strtipo",strtipo);
				if (strConductor !=null)
				{
					paramlist.AddWithValue("@strConductor",strConductor);
				}
				if (dtmFechaMovimiento !=null)
				{
					paramlist.AddWithValue("@dtmFechaMovimiento",dtmFechaMovimiento);
				}
				if (strdescripcionBanco !=null)
				{
					paramlist.AddWithValue("@strdescripcionBanco",strdescripcionBanco);
				}
				if (sw !=null)
				{
					paramlist.AddWithValue("@sw",sw);
				}
				if (dtmFechaMovDMS !=null)
				{
					paramlist.AddWithValue("@dtmFechaMovDMS",dtmFechaMovDMS);
				}
				if (strCuenta !=null)
				{
					paramlist.AddWithValue("@strCuenta",strCuenta);
				}
				if (strCuenta2 !=null)
				{
					paramlist.AddWithValue("@strCuenta2",strCuenta2);
				}
				if (strdescripcionCuenta !=null)
				{
					paramlist.AddWithValue("@strdescripcionCuenta",strdescripcionCuenta);
				}
				if (strdescripcionCuenta2 !=null)
				{
					paramlist.AddWithValue("@strdescripcionCuenta2",strdescripcionCuenta2);
				}
				if (curValor !=null)
				{
					paramlist.AddWithValue("@curValor",curValor);
				}
				if (strdescripcionModelo !=null)
				{
					paramlist.AddWithValue("@strdescripcionModelo",strdescripcionModelo);
				}
				if (strNota !=null)
				{
					paramlist.AddWithValue("@strNota",strNota);
				}
				if (strdocumento !=null)
				{
					paramlist.AddWithValue("@strdocumento",strdocumento);
				}
				if (strUsuarioDMS !=null)
				{
					paramlist.AddWithValue("@strUsuarioDMS",strUsuarioDMS);
				}
				if (dtmfechahoraSYSDMS !=null)
				{
					paramlist.AddWithValue("@dtmfechahoraSYSDMS",dtmfechahoraSYSDMS);
				}
				if (intUsuario !=null)
				{
					paramlist.AddWithValue("@intUsuario",intUsuario);
				}
				if (dtmFechaModif !=null)
				{
					paramlist.AddWithValue("@dtmFechaModif",dtmFechaModif);
				}
				if (logAnulado !=null)
				{
					paramlist.AddWithValue("@logAnulado",logAnulado);
				}
				if (logLiquidado !=null)
				{
					paramlist.AddWithValue("@logLiquidado",logLiquidado);
				}
				// Execute the query and return the new identity value
				int returnValue = Convert.ToInt32(LocalDataProvider.EjecutarProcedimiento("dbo.LiquidacionAnticiposCreate", paramlist, disconnect, out nullExit, DataProvider.TiempoEspera).Rows[0][0]);

				return returnValue;
			}
			catch (Exception ex)
			{
				Utilidades.LogErrores(ex.Message + (ex.InnerException != null ? ex.InnerException.Message : ""), DataProvider.AplicacionNombre);
				throw ex;
			}
		}

		/// <summary>
		/// Updates one record into tblLiquidacionAnticipos by passing all fields
		/// </summary>
		/// <param name="lngIdRegistroViaje"></param>
		/// <param name="lngIdRegistroViajeTramo"></param>
		/// <param name="intNitConductor"></param>
		/// <param name="strConductor"></param>
		/// <param name="strPlaca"></param>
		/// <param name="dtmFechaMovimiento"></param>
		/// <param name="lngIdBanco"></param>
		/// <param name="strdescripcionBanco"></param>
		/// <param name="intDocumento"></param>
		/// <param name="strModelo"></param>
		/// <param name="strtipo"></param>
		/// <param name="sw"></param>
		/// <param name="dtmFechaMovDMS"></param>
		/// <param name="strCuenta"></param>
		/// <param name="strCuenta2"></param>
		/// <param name="strdescripcionCuenta"></param>
		/// <param name="strdescripcionCuenta2"></param>
		/// <param name="curValor"></param>
		/// <param name="strdescripcionModelo"></param>
		/// <param name="strNota"></param>
		/// <param name="strdocumento"></param>
		/// <param name="strUsuarioDMS"></param>
		/// <param name="dtmfechahoraSYSDMS"></param>
		/// <param name="intUsuario"></param>
		/// <param name="dtmFechaModif"></param>
		/// <param name="logAnulado"></param>
		/// <param name="logLiquidado"></param>
		public void Update(int lngIdRegistroViaje, decimal lngIdRegistroViajeTramo, decimal intNitConductor, string strConductor, string strPlaca, DateTime? dtmFechaMovimiento, double lngIdBanco, string strdescripcionBanco, int intDocumento, string strModelo, string strtipo, byte? sw, DateTime? dtmFechaMovDMS, string strCuenta, string strCuenta2, string strdescripcionCuenta, string strdescripcionCuenta2, decimal? curValor, string strdescripcionModelo, string strNota, string strdocumento, string strUsuarioDMS, DateTime? dtmfechahoraSYSDMS, int? intUsuario, DateTime? dtmFechaModif, bool? logAnulado, bool? logLiquidado,string module, Sinapsys.Datos.SQL datosTransaccion=null)
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
				paramlist.AddWithValue("@lngIdRegistroViaje",lngIdRegistroViaje);
				paramlist.AddWithValue("@lngIdRegistroViajeTramo",lngIdRegistroViajeTramo);
				paramlist.AddWithValue("@intNitConductor",intNitConductor);
				paramlist.AddWithValue("@strPlaca",strPlaca);
				paramlist.AddWithValue("@lngIdBanco",lngIdBanco);
				paramlist.AddWithValue("@intDocumento",intDocumento);
				paramlist.AddWithValue("@strModelo",strModelo);
				paramlist.AddWithValue("@strtipo",strtipo);
				if (strConductor !=null)
				{
					paramlist.AddWithValue("@strConductor",strConductor);
				}
				if (dtmFechaMovimiento !=null)
				{
					paramlist.AddWithValue("@dtmFechaMovimiento",dtmFechaMovimiento);
				}
				if (strdescripcionBanco !=null)
				{
					paramlist.AddWithValue("@strdescripcionBanco",strdescripcionBanco);
				}
				if (sw !=null)
				{
					paramlist.AddWithValue("@sw",sw);
				}
				if (dtmFechaMovDMS !=null)
				{
					paramlist.AddWithValue("@dtmFechaMovDMS",dtmFechaMovDMS);
				}
				if (strCuenta !=null)
				{
					paramlist.AddWithValue("@strCuenta",strCuenta);
				}
				if (strCuenta2 !=null)
				{
					paramlist.AddWithValue("@strCuenta2",strCuenta2);
				}
				if (strdescripcionCuenta !=null)
				{
					paramlist.AddWithValue("@strdescripcionCuenta",strdescripcionCuenta);
				}
				if (strdescripcionCuenta2 !=null)
				{
					paramlist.AddWithValue("@strdescripcionCuenta2",strdescripcionCuenta2);
				}
				if (curValor !=null)
				{
					paramlist.AddWithValue("@curValor",curValor);
				}
				if (strdescripcionModelo !=null)
				{
					paramlist.AddWithValue("@strdescripcionModelo",strdescripcionModelo);
				}
				if (strNota !=null)
				{
					paramlist.AddWithValue("@strNota",strNota);
				}
				if (strdocumento !=null)
				{
					paramlist.AddWithValue("@strdocumento",strdocumento);
				}
				if (strUsuarioDMS !=null)
				{
					paramlist.AddWithValue("@strUsuarioDMS",strUsuarioDMS);
				}
				if (dtmfechahoraSYSDMS !=null)
				{
					paramlist.AddWithValue("@dtmfechahoraSYSDMS",dtmfechahoraSYSDMS);
				}
				if (intUsuario !=null)
				{
					paramlist.AddWithValue("@intUsuario",intUsuario);
				}
				if (dtmFechaModif !=null)
				{
					paramlist.AddWithValue("@dtmFechaModif",dtmFechaModif);
				}
				if (logAnulado !=null)
				{
					paramlist.AddWithValue("@logAnulado",logAnulado);
				}
				if (logLiquidado !=null)
				{
					paramlist.AddWithValue("@logLiquidado",logLiquidado);
				}
				LocalDataProvider.EjecutarProcedimiento("dbo.LiquidacionAnticiposUpdate", paramlist, disconnect, out nullExit, DataProvider.TiempoEspera);
			}
			catch (Exception ex)
			{
				Utilidades.LogErrores(ex.Message + (ex.InnerException != null ? ex.InnerException.Message : ""), DataProvider.AplicacionNombre);
				throw ex;
			}
		}

		/// <summary>
		/// Deletes one record from tblLiquidacionAnticipos by passing all key fields
		/// </summary>
		/// <param name="lngIdRegistroViaje"></param>
		/// <param name="lngIdRegistroViajeTramo"></param>
		/// <param name="intNitConductor"></param>
		/// <param name="strPlaca"></param>
		/// <param name="lngIdBanco"></param>
		/// <param name="intDocumento"></param>
		/// <param name="strModelo"></param>
		/// <param name="strtipo"></param>
		public void Delete(int lngIdRegistroViaje, decimal lngIdRegistroViajeTramo, decimal intNitConductor, string strPlaca, double lngIdBanco, int intDocumento, string strModelo, string strtipo,string module, Sinapsys.Datos.SQL datosTransaccion=null)
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
				paramlist.AddWithValue("@lngIdRegistroViaje",lngIdRegistroViaje);
				paramlist.AddWithValue("@lngIdRegistroViajeTramo",lngIdRegistroViajeTramo);
				paramlist.AddWithValue("@intNitConductor",intNitConductor);
				paramlist.AddWithValue("@strPlaca",strPlaca);
				paramlist.AddWithValue("@lngIdBanco",lngIdBanco);
				paramlist.AddWithValue("@intDocumento",intDocumento);
				paramlist.AddWithValue("@strModelo",strModelo);
				paramlist.AddWithValue("@strtipo",strtipo);
				LocalDataProvider.EjecutarProcedimiento("dbo.LiquidacionAnticiposDelete", paramlist, disconnect, out nullExit, DataProvider.TiempoEspera);
			}
			catch (Exception ex)
			{
				Utilidades.LogErrores(ex.Message + (ex.InnerException != null ? ex.InnerException.Message : ""), DataProvider.AplicacionNombre);
				throw ex;
			}
		}

		/// <summary>
		/// Gets one record from tblLiquidacionAnticipos passing all key fields
		/// </summary>
		/// <param name="lngIdRegistroViaje"></param>
		/// <param name="lngIdRegistroViajeTramo"></param>
		/// <param name="intNitConductor"></param>
		/// <param name="strPlaca"></param>
		/// <param name="lngIdBanco"></param>
		/// <param name="intDocumento"></param>
		/// <param name="strModelo"></param>
		/// <param name="strtipo"></param>
		/// <returns>A DataTable object containing the data</returns>
		public DataTable Get(int lngIdRegistroViaje, decimal lngIdRegistroViajeTramo, decimal intNitConductor, string strPlaca, double lngIdBanco, int intDocumento, string strModelo, string strtipo)
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
				paramlist.AddWithValue("@lngIdRegistroViaje",lngIdRegistroViaje);
				paramlist.AddWithValue("@lngIdRegistroViajeTramo",lngIdRegistroViajeTramo);
				paramlist.AddWithValue("@intNitConductor",intNitConductor);
				paramlist.AddWithValue("@strPlaca",strPlaca);
				paramlist.AddWithValue("@lngIdBanco",lngIdBanco);
				paramlist.AddWithValue("@intDocumento",intDocumento);
				paramlist.AddWithValue("@strModelo",strModelo);
				paramlist.AddWithValue("@strtipo",strtipo);
				return LocalDataProvider.EjecutarProcedimiento("dbo.LiquidacionAnticiposGet", paramlist, disconnect, out nullExit, DataProvider.TiempoEspera);

			}
			catch (Exception ex)
			{
				Utilidades.LogErrores(ex.Message + (ex.InnerException != null ? ex.InnerException.Message : ""), DataProvider.AplicacionNombre);
				throw ex;
			}
		}

		/// <summary>
		/// Gets all records from tblLiquidacionAnticipos
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
				return LocalDataProvider.EjecutarProcedimiento("dbo.LiquidacionAnticiposGetAll", paramlist, disconnect, out nullExit, DataProvider.TiempoEspera);
			}
			catch (Exception ex)
			{
				Utilidades.LogErrores(ex.Message + (ex.InnerException != null ? ex.InnerException.Message : ""), DataProvider.AplicacionNombre);
				throw ex;
			}
		}

		/// <summary>
		/// Gets all records from tblLiquidacionAnticipos applying filter and sort criteria
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

				return LocalDataProvider.EjecutarProcedimiento("dbo.LiquidacionAnticiposGetFilter", paramlist, disconnect, out nullExit, DataProvider.TiempoEspera);
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
		/// Gets the numbers of records from tblLiquidacionAnticipos applying filter and sort criteria
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

				return (int) LocalDataProvider.EjecutarProcedimiento("dbo.LiquidacionAnticiposGetFilter", paramlist, disconnect, out nullExit, DataProvider.TiempoEspera).Rows[0][0];
			}
			catch (Exception ex)
			{
				Utilidades.LogErrores(ex.Message + (ex.InnerException != null ? ex.InnerException.Message : ""), DataProvider.AplicacionNombre);
				throw ex;
			}
		}

	}
}
