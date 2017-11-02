using System;
using System.Data;
using System.Data.Common;
using Sinapsys.Datos;
using LiqViajes_Bll_Data.Security;
using System.Runtime.Serialization;

namespace LiqViajes_Bll_Data
{
	/// <summary>
	/// Data Access Layer class for VehiculosKmMantenimiento object
	/// </summary>
	/// <remarks>
	/// This class is a Singleton
	/// </remarks>
	public partial class VehiculosKmMantenimientoDataProvider
	{
		/// <summary>
		/// Internal member for create this singleton
		/// </summary>
		private static VehiculosKmMantenimientoDataProvider MySingleObj = null;

		/// <summary>
		/// Protected constructor to avoid access this singleton other way than calling the Instance method
		/// </summary>
		public VehiculosKmMantenimientoDataProvider()
		{

		}

		/// <summary>
		/// Instance accessor for this singleton
		/// </summary>
		public static VehiculosKmMantenimientoDataProvider Instance
		{
			get
			{
				if (MySingleObj == null)
				{
					MySingleObj = new VehiculosKmMantenimientoDataProvider();
				}

				return MySingleObj;
			}
		}

		/// <summary>
		/// Creates a new record into tblVehiculosKmMantenimiento by passing all fields
		/// </summary>
		/// <param name="dtmFechaUltimoCambio"></param>
		/// <param name="intKmUltimoCambio"></param>
		/// <param name="intKmSiguiente"></param>
		/// <param name="intKmAcumulado"></param>
		/// <param name="dtmFechaUltimoUltimoAcumu"></param>
		/// <param name="intKmAlarma1"></param>
		/// <param name="intKmAlarma2"></param>
		/// <param name="logAvisa"></param>
		/// <param name="dtmFechaDetener"></param>
		/// <param name="strLugarDetener"></param>
		/// <param name="dtmFechaModif"></param>
		/// <param name="lngIdUsuario"></param>
		public void Create(string strPlaca, int lngIdTipoMantenimiento, DateTime? dtmFechaUltimoCambio, int? intKmUltimoCambio, int? intKmSiguiente, int? intKmAcumulado, DateTime? dtmFechaUltimoUltimoAcumu, int? intKmAlarma1, int? intKmAlarma2, bool? logAvisa, DateTime? dtmFechaDetener, string strLugarDetener, DateTime? dtmFechaModif, int? lngIdUsuario,string module, Sinapsys.Datos.SQL datosTransaccion=null)
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

				paramlist.AddWithValue("@strPlaca",strPlaca);
				paramlist.AddWithValue("@lngIdTipoMantenimiento",lngIdTipoMantenimiento);
				if (dtmFechaUltimoCambio !=null)
				{
					paramlist.AddWithValue("@dtmFechaUltimoCambio",dtmFechaUltimoCambio);
				}
				if (intKmUltimoCambio !=null)
				{
					paramlist.AddWithValue("@intKmUltimoCambio",intKmUltimoCambio);
				}
				if (intKmSiguiente !=null)
				{
					paramlist.AddWithValue("@intKmSiguiente",intKmSiguiente);
				}
				if (intKmAcumulado !=null)
				{
					paramlist.AddWithValue("@intKmAcumulado",intKmAcumulado);
				}
				if (dtmFechaUltimoUltimoAcumu !=null)
				{
					paramlist.AddWithValue("@dtmFechaUltimoUltimoAcumu",dtmFechaUltimoUltimoAcumu);
				}
				if (intKmAlarma1 !=null)
				{
					paramlist.AddWithValue("@intKmAlarma1",intKmAlarma1);
				}
				if (intKmAlarma2 !=null)
				{
					paramlist.AddWithValue("@intKmAlarma2",intKmAlarma2);
				}
				if (logAvisa !=null)
				{
					paramlist.AddWithValue("@logAvisa",logAvisa);
				}
				if (dtmFechaDetener !=null)
				{
					paramlist.AddWithValue("@dtmFechaDetener",dtmFechaDetener);
				}
				if (strLugarDetener !=null)
				{
					paramlist.AddWithValue("@strLugarDetener",strLugarDetener);
				}
				if (dtmFechaModif !=null)
				{
					paramlist.AddWithValue("@dtmFechaModif",dtmFechaModif);
				}
				if (lngIdUsuario !=null)
				{
					paramlist.AddWithValue("@lngIdUsuario",lngIdUsuario);
				}
				LocalDataProvider.EjecutarProcedimiento("dbo.VehiculosKmMantenimientoCreate", paramlist, disconnect, out nullExit, DataProvider.TiempoEspera);
			}
			catch (Exception ex)
			{
				Utilidades.LogErrores(ex.Message + (ex.InnerException != null ? ex.InnerException.Message : ""), DataProvider.AplicacionNombre);
				throw ex;
			}
		}

		/// <summary>
		/// Updates one record into tblVehiculosKmMantenimiento by passing all fields
		/// </summary>
		/// <param name="strPlaca"></param>
		/// <param name="lngIdTipoMantenimiento"></param>
		/// <param name="dtmFechaUltimoCambio"></param>
		/// <param name="intKmUltimoCambio"></param>
		/// <param name="intKmSiguiente"></param>
		/// <param name="intKmAcumulado"></param>
		/// <param name="dtmFechaUltimoUltimoAcumu"></param>
		/// <param name="intKmAlarma1"></param>
		/// <param name="intKmAlarma2"></param>
		/// <param name="logAvisa"></param>
		/// <param name="dtmFechaDetener"></param>
		/// <param name="strLugarDetener"></param>
		/// <param name="dtmFechaModif"></param>
		/// <param name="lngIdUsuario"></param>
		public void Update(string strPlaca, int lngIdTipoMantenimiento, DateTime? dtmFechaUltimoCambio, int? intKmUltimoCambio, int? intKmSiguiente, int? intKmAcumulado, DateTime? dtmFechaUltimoUltimoAcumu, int? intKmAlarma1, int? intKmAlarma2, bool? logAvisa, DateTime? dtmFechaDetener, string strLugarDetener, DateTime? dtmFechaModif, int? lngIdUsuario,string module, Sinapsys.Datos.SQL datosTransaccion=null)
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
				paramlist.AddWithValue("@strPlaca",strPlaca);
				paramlist.AddWithValue("@lngIdTipoMantenimiento",lngIdTipoMantenimiento);
				if (dtmFechaUltimoCambio !=null)
				{
					paramlist.AddWithValue("@dtmFechaUltimoCambio",dtmFechaUltimoCambio);
				}
				if (intKmUltimoCambio !=null)
				{
					paramlist.AddWithValue("@intKmUltimoCambio",intKmUltimoCambio);
				}
				if (intKmSiguiente !=null)
				{
					paramlist.AddWithValue("@intKmSiguiente",intKmSiguiente);
				}
				if (intKmAcumulado !=null)
				{
					paramlist.AddWithValue("@intKmAcumulado",intKmAcumulado);
				}
				if (dtmFechaUltimoUltimoAcumu !=null)
				{
					paramlist.AddWithValue("@dtmFechaUltimoUltimoAcumu",dtmFechaUltimoUltimoAcumu);
				}
				if (intKmAlarma1 !=null)
				{
					paramlist.AddWithValue("@intKmAlarma1",intKmAlarma1);
				}
				if (intKmAlarma2 !=null)
				{
					paramlist.AddWithValue("@intKmAlarma2",intKmAlarma2);
				}
				if (logAvisa !=null)
				{
					paramlist.AddWithValue("@logAvisa",logAvisa);
				}
				if (dtmFechaDetener !=null)
				{
					paramlist.AddWithValue("@dtmFechaDetener",dtmFechaDetener);
				}
				if (strLugarDetener !=null)
				{
					paramlist.AddWithValue("@strLugarDetener",strLugarDetener);
				}
				if (dtmFechaModif !=null)
				{
					paramlist.AddWithValue("@dtmFechaModif",dtmFechaModif);
				}
				if (lngIdUsuario !=null)
				{
					paramlist.AddWithValue("@lngIdUsuario",lngIdUsuario);
				}
				LocalDataProvider.EjecutarProcedimiento("dbo.VehiculosKmMantenimientoUpdate", paramlist, disconnect, out nullExit, DataProvider.TiempoEspera);
			}
			catch (Exception ex)
			{
				Utilidades.LogErrores(ex.Message + (ex.InnerException != null ? ex.InnerException.Message : ""), DataProvider.AplicacionNombre);
				throw ex;
			}
		}

		/// <summary>
		/// Deletes one record from tblVehiculosKmMantenimiento by passing all key fields
		/// </summary>
		/// <param name="strPlaca"></param>
		/// <param name="lngIdTipoMantenimiento"></param>
		public void Delete(string strPlaca, int lngIdTipoMantenimiento,string module, Sinapsys.Datos.SQL datosTransaccion=null)
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
				paramlist.AddWithValue("@strPlaca",strPlaca);
				paramlist.AddWithValue("@lngIdTipoMantenimiento",lngIdTipoMantenimiento);
				LocalDataProvider.EjecutarProcedimiento("dbo.VehiculosKmMantenimientoDelete", paramlist, disconnect, out nullExit, DataProvider.TiempoEspera);
			}
			catch (Exception ex)
			{
				Utilidades.LogErrores(ex.Message + (ex.InnerException != null ? ex.InnerException.Message : ""), DataProvider.AplicacionNombre);
				throw ex;
			}
		}

		/// <summary>
		/// Gets one record from tblVehiculosKmMantenimiento passing all key fields
		/// </summary>
		/// <param name="strPlaca"></param>
		/// <param name="lngIdTipoMantenimiento"></param>
		/// <returns>A DataTable object containing the data</returns>
		public DataTable Get(string strPlaca, int lngIdTipoMantenimiento)
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
				paramlist.AddWithValue("@strPlaca",strPlaca);
				paramlist.AddWithValue("@lngIdTipoMantenimiento",lngIdTipoMantenimiento);
				return LocalDataProvider.EjecutarProcedimiento("dbo.VehiculosKmMantenimientoGet", paramlist, disconnect, out nullExit, DataProvider.TiempoEspera);

			}
			catch (Exception ex)
			{
				Utilidades.LogErrores(ex.Message + (ex.InnerException != null ? ex.InnerException.Message : ""), DataProvider.AplicacionNombre);
				throw ex;
			}
		}

		/// <summary>
		/// Gets all records from tblVehiculosKmMantenimiento
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
				return LocalDataProvider.EjecutarProcedimiento("dbo.VehiculosKmMantenimientoGetAll", paramlist, disconnect, out nullExit, DataProvider.TiempoEspera);
			}
			catch (Exception ex)
			{
				Utilidades.LogErrores(ex.Message + (ex.InnerException != null ? ex.InnerException.Message : ""), DataProvider.AplicacionNombre);
				throw ex;
			}
		}

		/// <summary>
		/// Gets all records from tblVehiculosKmMantenimiento applying filter and sort criteria
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

				return LocalDataProvider.EjecutarProcedimiento("dbo.VehiculosKmMantenimientoGetFilter", paramlist, disconnect, out nullExit, DataProvider.TiempoEspera);
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
		/// Gets the numbers of records from tblVehiculosKmMantenimiento applying filter and sort criteria
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

				return (int) LocalDataProvider.EjecutarProcedimiento("dbo.VehiculosKmMantenimientoGetFilter", paramlist, disconnect, out nullExit, DataProvider.TiempoEspera).Rows[0][0];
			}
			catch (Exception ex)
			{
				Utilidades.LogErrores(ex.Message + (ex.InnerException != null ? ex.InnerException.Message : ""), DataProvider.AplicacionNombre);
				throw ex;
			}
		}

	}
}
