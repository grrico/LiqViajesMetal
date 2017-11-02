using System;
using System.Data;
using System.Data.Common;
using Sinapsys.Datos;
using LiqViajes_Bll_Data.Security;
using System.Runtime.Serialization;

namespace LiqViajes_Bll_Data
{
	/// <summary>
	/// Data Access Layer class for LiquidacionVehiculo object
	/// </summary>
	/// <remarks>
	/// This class is a Singleton
	/// </remarks>
	public partial class LiquidacionVehiculoDataProvider
	{
		/// <summary>
		/// Internal member for create this singleton
		/// </summary>
		private static LiquidacionVehiculoDataProvider MySingleObj = null;

		/// <summary>
		/// Protected constructor to avoid access this singleton other way than calling the Instance method
		/// </summary>
		public LiquidacionVehiculoDataProvider()
		{

		}

		/// <summary>
		/// Instance accessor for this singleton
		/// </summary>
		public static LiquidacionVehiculoDataProvider Instance
		{
			get
			{
				if (MySingleObj == null)
				{
					MySingleObj = new LiquidacionVehiculoDataProvider();
				}

				return MySingleObj;
			}
		}

		/// <summary>
		/// Creates a new record into tblLiquidacionVehiculo by passing all fields
		/// </summary>
		/// <param name="strPlaca"></param>
		/// <param name="intNitConductor"></param>
		/// <param name="curGastos"></param>
		/// <param name="curAnticipos"></param>
		/// <param name="curTotal"></param>
		/// <param name="dtmFechaModif"></param>
		/// <param name="logLiquidado"></param>
		/// <param name="sngRentabilidad"></param>
		/// <param name="curValorFleteAcum"></param>
		/// <param name="logDesplazaVacio"></param>
		/// <param name="logSePuedeLiquidar"></param>
		/// <param name="curValorFlete"></param>
		/// <param name="curvalorUtilidad"></param>
		/// <param name="curValorRentabilidad"></param>
		/// <param name="TotalGalones"></param>
		/// <param name="cutCombustible"></param>
		/// <param name="cutParticipacion"></param>
		/// <param name="cutParticipacionVacio"></param>
		/// <param name="logLiquParticipacion"></param>
		/// <param name="logLiquKilometros"></param>
		/// <param name="curValorKilometros"></param>
		/// <param name="Kilometros"></param>
		/// <returns>int that contents the lngIdRegistro value</returns>
		public int Create(int lngIdRegistro, string strPlaca, decimal? intNitConductor, decimal? curGastos, decimal? curAnticipos, decimal? curTotal, DateTime? dtmFechaModif, bool? logLiquidado, float? sngRentabilidad, decimal? curValorFleteAcum, bool? logDesplazaVacio, bool? logSePuedeLiquidar, decimal? curValorFlete, decimal? curvalorUtilidad, decimal? curValorRentabilidad, decimal? TotalGalones, decimal? cutCombustible, decimal? cutParticipacion, decimal? cutParticipacionVacio, bool? logLiquParticipacion, bool? logLiquKilometros, decimal? curValorKilometros, int? Kilometros,string module, Sinapsys.Datos.SQL datosTransaccion=null)
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

				paramlist.AddWithValue("@lngIdRegistro",lngIdRegistro);
				if (strPlaca !=null)
				{
					paramlist.AddWithValue("@strPlaca",strPlaca);
				}
				if (intNitConductor !=null)
				{
					paramlist.AddWithValue("@intNitConductor",intNitConductor);
				}
				if (curGastos !=null)
				{
					paramlist.AddWithValue("@curGastos",curGastos);
				}
				if (curAnticipos !=null)
				{
					paramlist.AddWithValue("@curAnticipos",curAnticipos);
				}
				if (curTotal !=null)
				{
					paramlist.AddWithValue("@curTotal",curTotal);
				}
				if (dtmFechaModif !=null)
				{
					paramlist.AddWithValue("@dtmFechaModif",dtmFechaModif);
				}
				if (logLiquidado !=null)
				{
					paramlist.AddWithValue("@logLiquidado",logLiquidado);
				}
				if (sngRentabilidad !=null)
				{
					paramlist.AddWithValue("@sngRentabilidad",sngRentabilidad);
				}
				if (curValorFleteAcum !=null)
				{
					paramlist.AddWithValue("@curValorFleteAcum",curValorFleteAcum);
				}
				if (logDesplazaVacio !=null)
				{
					paramlist.AddWithValue("@logDesplazaVacio",logDesplazaVacio);
				}
				if (logSePuedeLiquidar !=null)
				{
					paramlist.AddWithValue("@logSePuedeLiquidar",logSePuedeLiquidar);
				}
				if (curValorFlete !=null)
				{
					paramlist.AddWithValue("@curValorFlete",curValorFlete);
				}
				if (curvalorUtilidad !=null)
				{
					paramlist.AddWithValue("@curvalorUtilidad",curvalorUtilidad);
				}
				if (curValorRentabilidad !=null)
				{
					paramlist.AddWithValue("@curValorRentabilidad",curValorRentabilidad);
				}
				if (TotalGalones !=null)
				{
					paramlist.AddWithValue("@TotalGalones",TotalGalones);
				}
				if (cutCombustible !=null)
				{
					paramlist.AddWithValue("@cutCombustible",cutCombustible);
				}
				if (cutParticipacion !=null)
				{
					paramlist.AddWithValue("@cutParticipacion",cutParticipacion);
				}
				if (cutParticipacionVacio !=null)
				{
					paramlist.AddWithValue("@cutParticipacionVacio",cutParticipacionVacio);
				}
				if (logLiquParticipacion !=null)
				{
					paramlist.AddWithValue("@logLiquParticipacion",logLiquParticipacion);
				}
				if (logLiquKilometros !=null)
				{
					paramlist.AddWithValue("@logLiquKilometros",logLiquKilometros);
				}
				if (curValorKilometros !=null)
				{
					paramlist.AddWithValue("@curValorKilometros",curValorKilometros);
				}
				if (Kilometros !=null)
				{
					paramlist.AddWithValue("@Kilometros",Kilometros);
				}
				// Execute the query and return the new identity value
				int returnValue = Convert.ToInt32(LocalDataProvider.EjecutarProcedimiento("dbo.LiquidacionVehiculoCreate", paramlist, disconnect, out nullExit, DataProvider.TiempoEspera).Rows[0][0]);

				return returnValue;
			}
			catch (Exception ex)
			{
				Utilidades.LogErrores(ex.Message + (ex.InnerException != null ? ex.InnerException.Message : ""), DataProvider.AplicacionNombre);
				throw ex;
			}
		}

		/// <summary>
		/// Updates one record into tblLiquidacionVehiculo by passing all fields
		/// </summary>
		/// <param name="lngIdRegistro"></param>
		/// <param name="strPlaca"></param>
		/// <param name="intNitConductor"></param>
		/// <param name="curGastos"></param>
		/// <param name="curAnticipos"></param>
		/// <param name="curTotal"></param>
		/// <param name="dtmFechaModif"></param>
		/// <param name="logLiquidado"></param>
		/// <param name="sngRentabilidad"></param>
		/// <param name="curValorFleteAcum"></param>
		/// <param name="logDesplazaVacio"></param>
		/// <param name="logSePuedeLiquidar"></param>
		/// <param name="curValorFlete"></param>
		/// <param name="curvalorUtilidad"></param>
		/// <param name="curValorRentabilidad"></param>
		/// <param name="TotalGalones"></param>
		/// <param name="cutCombustible"></param>
		/// <param name="cutParticipacion"></param>
		/// <param name="cutParticipacionVacio"></param>
		/// <param name="logLiquParticipacion"></param>
		/// <param name="logLiquKilometros"></param>
		/// <param name="curValorKilometros"></param>
		/// <param name="Kilometros"></param>
		public void Update(int lngIdRegistro, string strPlaca, decimal? intNitConductor, decimal? curGastos, decimal? curAnticipos, decimal? curTotal, DateTime? dtmFechaModif, bool? logLiquidado, float? sngRentabilidad, decimal? curValorFleteAcum, bool? logDesplazaVacio, bool? logSePuedeLiquidar, decimal? curValorFlete, decimal? curvalorUtilidad, decimal? curValorRentabilidad, decimal? TotalGalones, decimal? cutCombustible, decimal? cutParticipacion, decimal? cutParticipacionVacio, bool? logLiquParticipacion, bool? logLiquKilometros, decimal? curValorKilometros, int? Kilometros,string module, Sinapsys.Datos.SQL datosTransaccion=null)
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
				paramlist.AddWithValue("@lngIdRegistro",lngIdRegistro);
				if (strPlaca !=null)
				{
					paramlist.AddWithValue("@strPlaca",strPlaca);
				}
				if (intNitConductor !=null)
				{
					paramlist.AddWithValue("@intNitConductor",intNitConductor);
				}
				if (curGastos !=null)
				{
					paramlist.AddWithValue("@curGastos",curGastos);
				}
				if (curAnticipos !=null)
				{
					paramlist.AddWithValue("@curAnticipos",curAnticipos);
				}
				if (curTotal !=null)
				{
					paramlist.AddWithValue("@curTotal",curTotal);
				}
				if (dtmFechaModif !=null)
				{
					paramlist.AddWithValue("@dtmFechaModif",dtmFechaModif);
				}
				if (logLiquidado !=null)
				{
					paramlist.AddWithValue("@logLiquidado",logLiquidado);
				}
				if (sngRentabilidad !=null)
				{
					paramlist.AddWithValue("@sngRentabilidad",sngRentabilidad);
				}
				if (curValorFleteAcum !=null)
				{
					paramlist.AddWithValue("@curValorFleteAcum",curValorFleteAcum);
				}
				if (logDesplazaVacio !=null)
				{
					paramlist.AddWithValue("@logDesplazaVacio",logDesplazaVacio);
				}
				if (logSePuedeLiquidar !=null)
				{
					paramlist.AddWithValue("@logSePuedeLiquidar",logSePuedeLiquidar);
				}
				if (curValorFlete !=null)
				{
					paramlist.AddWithValue("@curValorFlete",curValorFlete);
				}
				if (curvalorUtilidad !=null)
				{
					paramlist.AddWithValue("@curvalorUtilidad",curvalorUtilidad);
				}
				if (curValorRentabilidad !=null)
				{
					paramlist.AddWithValue("@curValorRentabilidad",curValorRentabilidad);
				}
				if (TotalGalones !=null)
				{
					paramlist.AddWithValue("@TotalGalones",TotalGalones);
				}
				if (cutCombustible !=null)
				{
					paramlist.AddWithValue("@cutCombustible",cutCombustible);
				}
				if (cutParticipacion !=null)
				{
					paramlist.AddWithValue("@cutParticipacion",cutParticipacion);
				}
				if (cutParticipacionVacio !=null)
				{
					paramlist.AddWithValue("@cutParticipacionVacio",cutParticipacionVacio);
				}
				if (logLiquParticipacion !=null)
				{
					paramlist.AddWithValue("@logLiquParticipacion",logLiquParticipacion);
				}
				if (logLiquKilometros !=null)
				{
					paramlist.AddWithValue("@logLiquKilometros",logLiquKilometros);
				}
				if (curValorKilometros !=null)
				{
					paramlist.AddWithValue("@curValorKilometros",curValorKilometros);
				}
				if (Kilometros !=null)
				{
					paramlist.AddWithValue("@Kilometros",Kilometros);
				}
				LocalDataProvider.EjecutarProcedimiento("dbo.LiquidacionVehiculoUpdate", paramlist, disconnect, out nullExit, DataProvider.TiempoEspera);
			}
			catch (Exception ex)
			{
				Utilidades.LogErrores(ex.Message + (ex.InnerException != null ? ex.InnerException.Message : ""), DataProvider.AplicacionNombre);
				throw ex;
			}
		}

		/// <summary>
		/// Deletes one record from tblLiquidacionVehiculo by passing all key fields
		/// </summary>
		/// <param name="lngIdRegistro"></param>
		public void Delete(int lngIdRegistro,string module, Sinapsys.Datos.SQL datosTransaccion=null)
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
				paramlist.AddWithValue("@lngIdRegistro",lngIdRegistro);
				LocalDataProvider.EjecutarProcedimiento("dbo.LiquidacionVehiculoDelete", paramlist, disconnect, out nullExit, DataProvider.TiempoEspera);
			}
			catch (Exception ex)
			{
				Utilidades.LogErrores(ex.Message + (ex.InnerException != null ? ex.InnerException.Message : ""), DataProvider.AplicacionNombre);
				throw ex;
			}
		}

		/// <summary>
		/// Gets one record from tblLiquidacionVehiculo passing all key fields
		/// </summary>
		/// <param name="lngIdRegistro"></param>
		/// <returns>A DataTable object containing the data</returns>
		public DataTable Get(int lngIdRegistro)
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
				paramlist.AddWithValue("@lngIdRegistro",lngIdRegistro);
				return LocalDataProvider.EjecutarProcedimiento("dbo.LiquidacionVehiculoGet", paramlist, disconnect, out nullExit, DataProvider.TiempoEspera);

			}
			catch (Exception ex)
			{
				Utilidades.LogErrores(ex.Message + (ex.InnerException != null ? ex.InnerException.Message : ""), DataProvider.AplicacionNombre);
				throw ex;
			}
		}

		/// <summary>
		/// Gets all records from tblLiquidacionVehiculo
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
				return LocalDataProvider.EjecutarProcedimiento("dbo.LiquidacionVehiculoGetAll", paramlist, disconnect, out nullExit, DataProvider.TiempoEspera);
			}
			catch (Exception ex)
			{
				Utilidades.LogErrores(ex.Message + (ex.InnerException != null ? ex.InnerException.Message : ""), DataProvider.AplicacionNombre);
				throw ex;
			}
		}

		/// <summary>
		/// Gets all records from tblLiquidacionVehiculo that are related to Terceros
		/// </summary>
		/// <param name="intNitConductor"></param>
		/// <returns>A DataTable object containing all records data</returns>
		public DataTable GetBy_intNitConductor(decimal intNitConductor)
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

				paramlist.AddWithValue("@intNitConductor",intNitConductor);
				return LocalDataProvider.EjecutarProcedimiento("dbo.LiquidacionVehiculoGetBy_intNitConductor", paramlist, disconnect, out nullExit, DataProvider.TiempoEspera);
			}
			catch (Exception ex)
			{
				Utilidades.LogErrores(ex.Message + (ex.InnerException != null ? ex.InnerException.Message : ""), DataProvider.AplicacionNombre);
				throw ex;
			}
		}

		/// <summary>
		/// Gets all records from tblLiquidacionVehiculo applying filter and sort criteria
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

				return LocalDataProvider.EjecutarProcedimiento("dbo.LiquidacionVehiculoGetFilter", paramlist, disconnect, out nullExit, DataProvider.TiempoEspera);
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
		/// Gets the numbers of records from tblLiquidacionVehiculo applying filter and sort criteria
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

				return (int) LocalDataProvider.EjecutarProcedimiento("dbo.LiquidacionVehiculoGetFilter", paramlist, disconnect, out nullExit, DataProvider.TiempoEspera).Rows[0][0];
			}
			catch (Exception ex)
			{
				Utilidades.LogErrores(ex.Message + (ex.InnerException != null ? ex.InnerException.Message : ""), DataProvider.AplicacionNombre);
				throw ex;
			}
		}

	}
}
