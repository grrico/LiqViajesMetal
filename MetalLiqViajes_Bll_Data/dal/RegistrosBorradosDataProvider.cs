using System;
using System.Data;
using System.Data.Common;
using Sinapsys.Datos;
using LiqViajes_Bll_Data.Security;
using System.Runtime.Serialization;

namespace LiqViajes_Bll_Data
{
	/// <summary>
	/// Data Access Layer class for RegistrosBorrados object
	/// </summary>
	/// <remarks>
	/// This class is a Singleton
	/// </remarks>
	public partial class RegistrosBorradosDataProvider
	{
		/// <summary>
		/// Internal member for create this singleton
		/// </summary>
		private static RegistrosBorradosDataProvider MySingleObj = null;

		/// <summary>
		/// Protected constructor to avoid access this singleton other way than calling the Instance method
		/// </summary>
		public RegistrosBorradosDataProvider()
		{

		}

		/// <summary>
		/// Instance accessor for this singleton
		/// </summary>
		public static RegistrosBorradosDataProvider Instance
		{
			get
			{
				if (MySingleObj == null)
				{
					MySingleObj = new RegistrosBorradosDataProvider();
				}

				return MySingleObj;
			}
		}

		/// <summary>
		/// Creates a new record into tblRegistrosBorrados by passing all fields
		/// </summary>
		/// <param name="lngIdRegistroViajeTramo"></param>
		/// <param name="lngIdRegistrRuta"></param>
		/// <param name="strRutaAnticipo"></param>
		/// <param name="intNitConductor"></param>
		/// <param name="strConductor"></param>
		/// <param name="strPlaca"></param>
		/// <param name="lngIdBanco"></param>
		/// <param name="intDocumento"></param>
		/// <param name="strCuenta"></param>
		/// <param name="curDebito"></param>
		/// <param name="curCredito"></param>
		/// <param name="curSaldo"></param>
		/// <param name="dtmFechaModif"></param>
		/// <param name="strObservaciones"></param>
		/// <param name="intCantidad"></param>
		/// <param name="logAnulado"></param>
		/// <returns>int that contents the lngIdRegistroViaje value</returns>
		public int Create(int lngIdRegistroViaje, int? lngIdRegistroViajeTramo, int? lngIdRegistrRuta, string strRutaAnticipo, double? intNitConductor, string strConductor, string strPlaca, int? lngIdBanco, int? intDocumento, string strCuenta, decimal? curDebito, decimal? curCredito, decimal? curSaldo, DateTime? dtmFechaModif, string strObservaciones, int? intCantidad, bool? logAnulado,string module, Sinapsys.Datos.SQL datosTransaccion=null)
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
				if (lngIdRegistroViajeTramo !=null)
				{
					paramlist.AddWithValue("@lngIdRegistroViajeTramo",lngIdRegistroViajeTramo);
				}
				if (lngIdRegistrRuta !=null)
				{
					paramlist.AddWithValue("@lngIdRegistrRuta",lngIdRegistrRuta);
				}
				paramlist.AddWithValue("@strRutaAnticipo",strRutaAnticipo);
				if (intNitConductor !=null)
				{
					paramlist.AddWithValue("@intNitConductor",intNitConductor);
				}
				if (strConductor !=null)
				{
					paramlist.AddWithValue("@strConductor",strConductor);
				}
				paramlist.AddWithValue("@strPlaca",strPlaca);
				if (lngIdBanco !=null)
				{
					paramlist.AddWithValue("@lngIdBanco",lngIdBanco);
				}
				if (intDocumento !=null)
				{
					paramlist.AddWithValue("@intDocumento",intDocumento);
				}
				if (strCuenta !=null)
				{
					paramlist.AddWithValue("@strCuenta",strCuenta);
				}
				if (curDebito !=null)
				{
					paramlist.AddWithValue("@curDebito",curDebito);
				}
				if (curCredito !=null)
				{
					paramlist.AddWithValue("@curCredito",curCredito);
				}
				if (curSaldo !=null)
				{
					paramlist.AddWithValue("@curSaldo",curSaldo);
				}
				if (dtmFechaModif !=null)
				{
					paramlist.AddWithValue("@dtmFechaModif",dtmFechaModif);
				}
				if (strObservaciones !=null)
				{
					paramlist.AddWithValue("@strObservaciones",strObservaciones);
				}
				if (intCantidad !=null)
				{
					paramlist.AddWithValue("@intCantidad",intCantidad);
				}
				if (logAnulado !=null)
				{
					paramlist.AddWithValue("@logAnulado",logAnulado);
				}
				// Execute the query and return the new identity value
				int returnValue = Convert.ToInt32(LocalDataProvider.EjecutarProcedimiento("dbo.RegistrosBorradosCreate", paramlist, disconnect, out nullExit, DataProvider.TiempoEspera).Rows[0][0]);

				return returnValue;
			}
			catch (Exception ex)
			{
				Utilidades.LogErrores(ex.Message + (ex.InnerException != null ? ex.InnerException.Message : ""), DataProvider.AplicacionNombre);
				throw ex;
			}
		}

		/// <summary>
		/// Updates one record into tblRegistrosBorrados by passing all fields
		/// </summary>
		/// <param name="lngIdRegistroViaje"></param>
		/// <param name="lngIdRegistroViajeTramo"></param>
		/// <param name="lngIdRegistrRuta"></param>
		/// <param name="strRutaAnticipo"></param>
		/// <param name="intNitConductor"></param>
		/// <param name="strConductor"></param>
		/// <param name="strPlaca"></param>
		/// <param name="lngIdBanco"></param>
		/// <param name="intDocumento"></param>
		/// <param name="strCuenta"></param>
		/// <param name="curDebito"></param>
		/// <param name="curCredito"></param>
		/// <param name="curSaldo"></param>
		/// <param name="dtmFechaModif"></param>
		/// <param name="strObservaciones"></param>
		/// <param name="intCantidad"></param>
		/// <param name="logAnulado"></param>
		public void Update(int lngIdRegistroViaje, int? lngIdRegistroViajeTramo, int? lngIdRegistrRuta, string strRutaAnticipo, double? intNitConductor, string strConductor, string strPlaca, int? lngIdBanco, int? intDocumento, string strCuenta, decimal? curDebito, decimal? curCredito, decimal? curSaldo, DateTime? dtmFechaModif, string strObservaciones, int? intCantidad, bool? logAnulado,string module, Sinapsys.Datos.SQL datosTransaccion=null)
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
				if (lngIdRegistroViajeTramo !=null)
				{
					paramlist.AddWithValue("@lngIdRegistroViajeTramo",lngIdRegistroViajeTramo);
				}
				if (lngIdRegistrRuta !=null)
				{
					paramlist.AddWithValue("@lngIdRegistrRuta",lngIdRegistrRuta);
				}
				paramlist.AddWithValue("@strRutaAnticipo",strRutaAnticipo);
				if (intNitConductor !=null)
				{
					paramlist.AddWithValue("@intNitConductor",intNitConductor);
				}
				if (strConductor !=null)
				{
					paramlist.AddWithValue("@strConductor",strConductor);
				}
				paramlist.AddWithValue("@strPlaca",strPlaca);
				if (lngIdBanco !=null)
				{
					paramlist.AddWithValue("@lngIdBanco",lngIdBanco);
				}
				if (intDocumento !=null)
				{
					paramlist.AddWithValue("@intDocumento",intDocumento);
				}
				if (strCuenta !=null)
				{
					paramlist.AddWithValue("@strCuenta",strCuenta);
				}
				if (curDebito !=null)
				{
					paramlist.AddWithValue("@curDebito",curDebito);
				}
				if (curCredito !=null)
				{
					paramlist.AddWithValue("@curCredito",curCredito);
				}
				if (curSaldo !=null)
				{
					paramlist.AddWithValue("@curSaldo",curSaldo);
				}
				if (dtmFechaModif !=null)
				{
					paramlist.AddWithValue("@dtmFechaModif",dtmFechaModif);
				}
				if (strObservaciones !=null)
				{
					paramlist.AddWithValue("@strObservaciones",strObservaciones);
				}
				if (intCantidad !=null)
				{
					paramlist.AddWithValue("@intCantidad",intCantidad);
				}
				if (logAnulado !=null)
				{
					paramlist.AddWithValue("@logAnulado",logAnulado);
				}
				LocalDataProvider.EjecutarProcedimiento("dbo.RegistrosBorradosUpdate", paramlist, disconnect, out nullExit, DataProvider.TiempoEspera);
			}
			catch (Exception ex)
			{
				Utilidades.LogErrores(ex.Message + (ex.InnerException != null ? ex.InnerException.Message : ""), DataProvider.AplicacionNombre);
				throw ex;
			}
		}

		/// <summary>
		/// Deletes one record from tblRegistrosBorrados by passing all key fields
		/// </summary>
		/// <param name="lngIdRegistroViaje"></param>
		public void Delete(int lngIdRegistroViaje,string module, Sinapsys.Datos.SQL datosTransaccion=null)
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
				LocalDataProvider.EjecutarProcedimiento("dbo.RegistrosBorradosDelete", paramlist, disconnect, out nullExit, DataProvider.TiempoEspera);
			}
			catch (Exception ex)
			{
				Utilidades.LogErrores(ex.Message + (ex.InnerException != null ? ex.InnerException.Message : ""), DataProvider.AplicacionNombre);
				throw ex;
			}
		}

		/// <summary>
		/// Gets one record from tblRegistrosBorrados passing all key fields
		/// </summary>
		/// <param name="lngIdRegistroViaje"></param>
		/// <returns>A DataTable object containing the data</returns>
		public DataTable Get(int lngIdRegistroViaje)
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
				return LocalDataProvider.EjecutarProcedimiento("dbo.RegistrosBorradosGet", paramlist, disconnect, out nullExit, DataProvider.TiempoEspera);

			}
			catch (Exception ex)
			{
				Utilidades.LogErrores(ex.Message + (ex.InnerException != null ? ex.InnerException.Message : ""), DataProvider.AplicacionNombre);
				throw ex;
			}
		}

		/// <summary>
		/// Gets all records from tblRegistrosBorrados
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
				return LocalDataProvider.EjecutarProcedimiento("dbo.RegistrosBorradosGetAll", paramlist, disconnect, out nullExit, DataProvider.TiempoEspera);
			}
			catch (Exception ex)
			{
				Utilidades.LogErrores(ex.Message + (ex.InnerException != null ? ex.InnerException.Message : ""), DataProvider.AplicacionNombre);
				throw ex;
			}
		}

		/// <summary>
		/// Gets all records from tblRegistrosBorrados applying filter and sort criteria
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

				return LocalDataProvider.EjecutarProcedimiento("dbo.RegistrosBorradosGetFilter", paramlist, disconnect, out nullExit, DataProvider.TiempoEspera);
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
		/// Gets the numbers of records from tblRegistrosBorrados applying filter and sort criteria
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

				return (int) LocalDataProvider.EjecutarProcedimiento("dbo.RegistrosBorradosGetFilter", paramlist, disconnect, out nullExit, DataProvider.TiempoEspera).Rows[0][0];
			}
			catch (Exception ex)
			{
				Utilidades.LogErrores(ex.Message + (ex.InnerException != null ? ex.InnerException.Message : ""), DataProvider.AplicacionNombre);
				throw ex;
			}
		}

	}
}
