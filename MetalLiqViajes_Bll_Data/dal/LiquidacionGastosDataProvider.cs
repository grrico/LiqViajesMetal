using System;
using System.Data;
using System.Data.Common;
using Sinapsys.Datos;
using LiqViajes_Bll_Data.Security;
using System.Runtime.Serialization;

namespace LiqViajes_Bll_Data
{
	/// <summary>
	/// Data Access Layer class for LiquidacionGastos object
	/// </summary>
	/// <remarks>
	/// This class is a Singleton
	/// </remarks>
	public partial class LiquidacionGastosDataProvider
	{
		/// <summary>
		/// Internal member for create this singleton
		/// </summary>
		private static LiquidacionGastosDataProvider MySingleObj = null;

		/// <summary>
		/// Protected constructor to avoid access this singleton other way than calling the Instance method
		/// </summary>
		public LiquidacionGastosDataProvider()
		{

		}

		/// <summary>
		/// Instance accessor for this singleton
		/// </summary>
		public static LiquidacionGastosDataProvider Instance
		{
			get
			{
				if (MySingleObj == null)
				{
					MySingleObj = new LiquidacionGastosDataProvider();
				}

				return MySingleObj;
			}
		}

		/// <summary>
		/// Creates a new record into tblLiquidacionGastos by passing all fields
		/// </summary>
		/// <param name="strDescripcionCuenta"></param>
		/// <param name="strDescripcion"></param>
		/// <param name="dtmFechaAsignacion"></param>
		/// <param name="curValorTramo"></param>
		/// <param name="curValorAdicional"></param>
		/// <param name="curValorTotal"></param>
		/// <param name="strObservaciones"></param>
		/// <param name="nitTercero"></param>
		/// <param name="strPlaca"></param>
		/// <param name="lngIdUsuario"></param>
		/// <param name="logLiquidado"></param>
		/// <param name="dtmFechaSalida"></param>
		/// <param name="dtmFechaLlegada"></param>
		/// <param name="dtmFechaModif"></param>
		/// <param name="LogExcluido"></param>
		/// <param name="floGalones"></param>
		/// <param name="floGalonesAdicional"></param>
		/// <param name="floGalonesReales"></param>
		/// <param name="curValorGalon"></param>
		/// <param name="CombustibleCarretera"></param>
		/// <param name="cutCombustible"></param>
		/// <param name="LogAnticipoACPM"></param>
		/// <param name="AntipoConductor"></param>
		public void Create(int lngIdRegistrRutaItemId, decimal lngIdRegistroViaje, int lngIdRegistrRuta, string strCuenta, int intRowRegistro, string strDescripcionCuenta, string strDescripcion, DateTime? dtmFechaAsignacion, decimal? curValorTramo, decimal? curValorAdicional, decimal? curValorTotal, string strObservaciones, string nitTercero, string strPlaca, int? lngIdUsuario, bool? logLiquidado, DateTime? dtmFechaSalida, DateTime? dtmFechaLlegada, DateTime? dtmFechaModif, bool? LogExcluido, decimal? floGalones, decimal? floGalonesAdicional, decimal? floGalonesReales, decimal? curValorGalon, decimal? CombustibleCarretera, decimal? cutCombustible, bool? LogAnticipoACPM, bool? AntipoConductor,string module, Sinapsys.Datos.SQL datosTransaccion=null)
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

				paramlist.AddWithValue("@lngIdRegistrRutaItemId",lngIdRegistrRutaItemId);
				paramlist.AddWithValue("@lngIdRegistroViaje",lngIdRegistroViaje);
				paramlist.AddWithValue("@lngIdRegistrRuta",lngIdRegistrRuta);
				paramlist.AddWithValue("@strCuenta",strCuenta);
				paramlist.AddWithValue("@intRowRegistro",intRowRegistro);
				if (strDescripcionCuenta !=null)
				{
					paramlist.AddWithValue("@strDescripcionCuenta",strDescripcionCuenta);
				}
				if (strDescripcion !=null)
				{
					paramlist.AddWithValue("@strDescripcion",strDescripcion);
				}
				if (dtmFechaAsignacion !=null)
				{
					paramlist.AddWithValue("@dtmFechaAsignacion",dtmFechaAsignacion);
				}
				if (curValorTramo !=null)
				{
					paramlist.AddWithValue("@curValorTramo",curValorTramo);
				}
				if (curValorAdicional !=null)
				{
					paramlist.AddWithValue("@curValorAdicional",curValorAdicional);
				}
				if (curValorTotal !=null)
				{
					paramlist.AddWithValue("@curValorTotal",curValorTotal);
				}
				if (strObservaciones !=null)
				{
					paramlist.AddWithValue("@strObservaciones",strObservaciones);
				}
				if (nitTercero !=null)
				{
					paramlist.AddWithValue("@nitTercero",nitTercero);
				}
				if (strPlaca !=null)
				{
					paramlist.AddWithValue("@strPlaca",strPlaca);
				}
				if (lngIdUsuario !=null)
				{
					paramlist.AddWithValue("@lngIdUsuario",lngIdUsuario);
				}
				if (logLiquidado !=null)
				{
					paramlist.AddWithValue("@logLiquidado",logLiquidado);
				}
				if (dtmFechaSalida !=null)
				{
					paramlist.AddWithValue("@dtmFechaSalida",dtmFechaSalida);
				}
				if (dtmFechaLlegada !=null)
				{
					paramlist.AddWithValue("@dtmFechaLlegada",dtmFechaLlegada);
				}
				if (dtmFechaModif !=null)
				{
					paramlist.AddWithValue("@dtmFechaModif",dtmFechaModif);
				}
				if (LogExcluido !=null)
				{
					paramlist.AddWithValue("@LogExcluido",LogExcluido);
				}
				if (floGalones !=null)
				{
					paramlist.AddWithValue("@floGalones",floGalones);
				}
				if (floGalonesAdicional !=null)
				{
					paramlist.AddWithValue("@floGalonesAdicional",floGalonesAdicional);
				}
				if (floGalonesReales !=null)
				{
					paramlist.AddWithValue("@floGalonesReales",floGalonesReales);
				}
				if (curValorGalon !=null)
				{
					paramlist.AddWithValue("@curValorGalon",curValorGalon);
				}
				if (CombustibleCarretera !=null)
				{
					paramlist.AddWithValue("@CombustibleCarretera",CombustibleCarretera);
				}
				if (cutCombustible !=null)
				{
					paramlist.AddWithValue("@cutCombustible",cutCombustible);
				}
				if (LogAnticipoACPM !=null)
				{
					paramlist.AddWithValue("@LogAnticipoACPM",LogAnticipoACPM);
				}
				if (AntipoConductor !=null)
				{
					paramlist.AddWithValue("@AntipoConductor",AntipoConductor);
				}
				LocalDataProvider.EjecutarProcedimiento("dbo.LiquidacionGastosCreate", paramlist, disconnect, out nullExit, DataProvider.TiempoEspera);
			}
			catch (Exception ex)
			{
				Utilidades.LogErrores(ex.Message + (ex.InnerException != null ? ex.InnerException.Message : ""), DataProvider.AplicacionNombre);
				throw ex;
			}
		}

		/// <summary>
		/// Updates one record into tblLiquidacionGastos by passing all fields
		/// </summary>
		/// <param name="lngIdRegistrRutaItemId"></param>
		/// <param name="lngIdRegistroViaje"></param>
		/// <param name="lngIdRegistrRuta"></param>
		/// <param name="strCuenta"></param>
		/// <param name="intRowRegistro"></param>
		/// <param name="strDescripcionCuenta"></param>
		/// <param name="strDescripcion"></param>
		/// <param name="dtmFechaAsignacion"></param>
		/// <param name="curValorTramo"></param>
		/// <param name="curValorAdicional"></param>
		/// <param name="curValorTotal"></param>
		/// <param name="strObservaciones"></param>
		/// <param name="nitTercero"></param>
		/// <param name="strPlaca"></param>
		/// <param name="lngIdUsuario"></param>
		/// <param name="logLiquidado"></param>
		/// <param name="dtmFechaSalida"></param>
		/// <param name="dtmFechaLlegada"></param>
		/// <param name="dtmFechaModif"></param>
		/// <param name="LogExcluido"></param>
		/// <param name="floGalones"></param>
		/// <param name="floGalonesAdicional"></param>
		/// <param name="floGalonesReales"></param>
		/// <param name="curValorGalon"></param>
		/// <param name="CombustibleCarretera"></param>
		/// <param name="cutCombustible"></param>
		/// <param name="LogAnticipoACPM"></param>
		/// <param name="AntipoConductor"></param>
		public void Update(int lngIdRegistrRutaItemId, decimal lngIdRegistroViaje, int lngIdRegistrRuta, string strCuenta, int intRowRegistro, string strDescripcionCuenta, string strDescripcion, DateTime? dtmFechaAsignacion, decimal? curValorTramo, decimal? curValorAdicional, decimal? curValorTotal, string strObservaciones, string nitTercero, string strPlaca, int? lngIdUsuario, bool? logLiquidado, DateTime? dtmFechaSalida, DateTime? dtmFechaLlegada, DateTime? dtmFechaModif, bool? LogExcluido, decimal? floGalones, decimal? floGalonesAdicional, decimal? floGalonesReales, decimal? curValorGalon, decimal? CombustibleCarretera, decimal? cutCombustible, bool? LogAnticipoACPM, bool? AntipoConductor,string module, Sinapsys.Datos.SQL datosTransaccion=null)
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
				paramlist.AddWithValue("@lngIdRegistrRutaItemId",lngIdRegistrRutaItemId);
				paramlist.AddWithValue("@lngIdRegistroViaje",lngIdRegistroViaje);
				paramlist.AddWithValue("@lngIdRegistrRuta",lngIdRegistrRuta);
				paramlist.AddWithValue("@strCuenta",strCuenta);
				paramlist.AddWithValue("@intRowRegistro",intRowRegistro);
				if (strDescripcionCuenta !=null)
				{
					paramlist.AddWithValue("@strDescripcionCuenta",strDescripcionCuenta);
				}
				if (strDescripcion !=null)
				{
					paramlist.AddWithValue("@strDescripcion",strDescripcion);
				}
				if (dtmFechaAsignacion !=null)
				{
					paramlist.AddWithValue("@dtmFechaAsignacion",dtmFechaAsignacion);
				}
				if (curValorTramo !=null)
				{
					paramlist.AddWithValue("@curValorTramo",curValorTramo);
				}
				if (curValorAdicional !=null)
				{
					paramlist.AddWithValue("@curValorAdicional",curValorAdicional);
				}
				if (curValorTotal !=null)
				{
					paramlist.AddWithValue("@curValorTotal",curValorTotal);
				}
				if (strObservaciones !=null)
				{
					paramlist.AddWithValue("@strObservaciones",strObservaciones);
				}
				if (nitTercero !=null)
				{
					paramlist.AddWithValue("@nitTercero",nitTercero);
				}
				if (strPlaca !=null)
				{
					paramlist.AddWithValue("@strPlaca",strPlaca);
				}
				if (lngIdUsuario !=null)
				{
					paramlist.AddWithValue("@lngIdUsuario",lngIdUsuario);
				}
				if (logLiquidado !=null)
				{
					paramlist.AddWithValue("@logLiquidado",logLiquidado);
				}
				if (dtmFechaSalida !=null)
				{
					paramlist.AddWithValue("@dtmFechaSalida",dtmFechaSalida);
				}
				if (dtmFechaLlegada !=null)
				{
					paramlist.AddWithValue("@dtmFechaLlegada",dtmFechaLlegada);
				}
				if (dtmFechaModif !=null)
				{
					paramlist.AddWithValue("@dtmFechaModif",dtmFechaModif);
				}
				if (LogExcluido !=null)
				{
					paramlist.AddWithValue("@LogExcluido",LogExcluido);
				}
				if (floGalones !=null)
				{
					paramlist.AddWithValue("@floGalones",floGalones);
				}
				if (floGalonesAdicional !=null)
				{
					paramlist.AddWithValue("@floGalonesAdicional",floGalonesAdicional);
				}
				if (floGalonesReales !=null)
				{
					paramlist.AddWithValue("@floGalonesReales",floGalonesReales);
				}
				if (curValorGalon !=null)
				{
					paramlist.AddWithValue("@curValorGalon",curValorGalon);
				}
				if (CombustibleCarretera !=null)
				{
					paramlist.AddWithValue("@CombustibleCarretera",CombustibleCarretera);
				}
				if (cutCombustible !=null)
				{
					paramlist.AddWithValue("@cutCombustible",cutCombustible);
				}
				if (LogAnticipoACPM !=null)
				{
					paramlist.AddWithValue("@LogAnticipoACPM",LogAnticipoACPM);
				}
				if (AntipoConductor !=null)
				{
					paramlist.AddWithValue("@AntipoConductor",AntipoConductor);
				}
				LocalDataProvider.EjecutarProcedimiento("dbo.LiquidacionGastosUpdate", paramlist, disconnect, out nullExit, DataProvider.TiempoEspera);
			}
			catch (Exception ex)
			{
				Utilidades.LogErrores(ex.Message + (ex.InnerException != null ? ex.InnerException.Message : ""), DataProvider.AplicacionNombre);
				throw ex;
			}
		}

		/// <summary>
		/// Deletes one record from tblLiquidacionGastos by passing all key fields
		/// </summary>
		/// <param name="lngIdRegistrRutaItemId"></param>
		/// <param name="lngIdRegistroViaje"></param>
		/// <param name="lngIdRegistrRuta"></param>
		/// <param name="strCuenta"></param>
		/// <param name="intRowRegistro"></param>
		public void Delete(int lngIdRegistrRutaItemId, decimal lngIdRegistroViaje, int lngIdRegistrRuta, string strCuenta, int intRowRegistro,string module, Sinapsys.Datos.SQL datosTransaccion=null)
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
				paramlist.AddWithValue("@lngIdRegistrRutaItemId",lngIdRegistrRutaItemId);
				paramlist.AddWithValue("@lngIdRegistroViaje",lngIdRegistroViaje);
				paramlist.AddWithValue("@lngIdRegistrRuta",lngIdRegistrRuta);
				paramlist.AddWithValue("@strCuenta",strCuenta);
				paramlist.AddWithValue("@intRowRegistro",intRowRegistro);
				LocalDataProvider.EjecutarProcedimiento("dbo.LiquidacionGastosDelete", paramlist, disconnect, out nullExit, DataProvider.TiempoEspera);
			}
			catch (Exception ex)
			{
				Utilidades.LogErrores(ex.Message + (ex.InnerException != null ? ex.InnerException.Message : ""), DataProvider.AplicacionNombre);
				throw ex;
			}
		}

		/// <summary>
		/// Gets one record from tblLiquidacionGastos passing all key fields
		/// </summary>
		/// <param name="lngIdRegistrRutaItemId"></param>
		/// <param name="lngIdRegistroViaje"></param>
		/// <param name="lngIdRegistrRuta"></param>
		/// <param name="strCuenta"></param>
		/// <param name="intRowRegistro"></param>
		/// <returns>A DataTable object containing the data</returns>
		public DataTable Get(int lngIdRegistrRutaItemId, decimal lngIdRegistroViaje, int lngIdRegistrRuta, string strCuenta, int intRowRegistro)
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
				paramlist.AddWithValue("@lngIdRegistrRutaItemId",lngIdRegistrRutaItemId);
				paramlist.AddWithValue("@lngIdRegistroViaje",lngIdRegistroViaje);
				paramlist.AddWithValue("@lngIdRegistrRuta",lngIdRegistrRuta);
				paramlist.AddWithValue("@strCuenta",strCuenta);
				paramlist.AddWithValue("@intRowRegistro",intRowRegistro);
				return LocalDataProvider.EjecutarProcedimiento("dbo.LiquidacionGastosGet", paramlist, disconnect, out nullExit, DataProvider.TiempoEspera);

			}
			catch (Exception ex)
			{
				Utilidades.LogErrores(ex.Message + (ex.InnerException != null ? ex.InnerException.Message : ""), DataProvider.AplicacionNombre);
				throw ex;
			}
		}

		/// <summary>
		/// Gets all records from tblLiquidacionGastos
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
				return LocalDataProvider.EjecutarProcedimiento("dbo.LiquidacionGastosGetAll", paramlist, disconnect, out nullExit, DataProvider.TiempoEspera);
			}
			catch (Exception ex)
			{
				Utilidades.LogErrores(ex.Message + (ex.InnerException != null ? ex.InnerException.Message : ""), DataProvider.AplicacionNombre);
				throw ex;
			}
		}

		/// <summary>
		/// Gets all records from tblLiquidacionGastos that are related to tblLiquidacionRutas
		/// </summary>
		/// <param name="lngIdRegistrRutaItemId"></param>
		/// <returns>A DataTable object containing all records data</returns>
		public DataTable GetBy_lngIdRegistrRutaItemId(int lngIdRegistrRutaItemId)
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

				paramlist.AddWithValue("@lngIdRegistrRutaItemId",lngIdRegistrRutaItemId);
				return LocalDataProvider.EjecutarProcedimiento("dbo.LiquidacionGastosGetBy_lngIdRegistrRutaItemId", paramlist, disconnect, out nullExit, DataProvider.TiempoEspera);
			}
			catch (Exception ex)
			{
				Utilidades.LogErrores(ex.Message + (ex.InnerException != null ? ex.InnerException.Message : ""), DataProvider.AplicacionNombre);
				throw ex;
			}
		}

		/// <summary>
		/// Gets all records from tblLiquidacionGastos applying filter and sort criteria
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

				return LocalDataProvider.EjecutarProcedimiento("dbo.LiquidacionGastosGetFilter", paramlist, disconnect, out nullExit, DataProvider.TiempoEspera);
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
		/// Gets the numbers of records from tblLiquidacionGastos applying filter and sort criteria
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

				return (int) LocalDataProvider.EjecutarProcedimiento("dbo.LiquidacionGastosGetFilter", paramlist, disconnect, out nullExit, DataProvider.TiempoEspera).Rows[0][0];
			}
			catch (Exception ex)
			{
				Utilidades.LogErrores(ex.Message + (ex.InnerException != null ? ex.InnerException.Message : ""), DataProvider.AplicacionNombre);
				throw ex;
			}
		}

	}
}
