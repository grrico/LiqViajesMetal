using System;
using System.Data;
using System.Data.Common;
using Sinapsys.Datos;
using LiqViajes_Bll_Data.Security;
using System.Runtime.Serialization;

namespace LiqViajes_Bll_Data
{
	/// <summary>
	/// Data Access Layer class for TercerosConductores object
	/// </summary>
	/// <remarks>
	/// This class is a Singleton
	/// </remarks>
	public partial class TercerosConductoresDataProvider
	{
		/// <summary>
		/// Internal member for create this singleton
		/// </summary>
		private static TercerosConductoresDataProvider MySingleObj = null;

		/// <summary>
		/// Protected constructor to avoid access this singleton other way than calling the Instance method
		/// </summary>
		public TercerosConductoresDataProvider()
		{

		}

		/// <summary>
		/// Instance accessor for this singleton
		/// </summary>
		public static TercerosConductoresDataProvider Instance
		{
			get
			{
				if (MySingleObj == null)
				{
					MySingleObj = new TercerosConductoresDataProvider();
				}

				return MySingleObj;
			}
		}

		/// <summary>
		/// Creates a new record into tblTercerosConductores by passing all fields
		/// </summary>
		/// <param name="intDigito"></param>
		/// <param name="strNombres"></param>
		/// <param name="strDireccion"></param>
		/// <param name="logEstado"></param>
		/// <param name="logConductor"></param>
		/// <param name="strPlaca"></param>
		/// <param name="lngIdCiudad"></param>
		/// <param name="strTelefono"></param>
		/// <param name="strTelefonoAux"></param>
		/// <param name="strTelCelular"></param>
		/// <param name="strTelCelularAux"></param>
		/// <param name="strFax"></param>
		/// <param name="IntAAereo"></param>
		/// <param name="StrPais"></param>
		/// <param name="nitProvedor"></param>
		/// <param name="intNoLicenciaConduc"></param>
		/// <param name="intCategoria"></param>
		/// <param name="strTarjetaTripulante"></param>
		/// <param name="dtmFechaVenceLicencia"></param>
		/// <param name="dtmVenceTarjetaTripulante"></param>
		/// <param name="strCarnetEmpresa"></param>
		/// <param name="strCarnetComunicaciones"></param>
		/// <param name="dtmFechaModif"></param>
		/// <param name="logActualizado"></param>
		/// <param name="lngIdUsuario"></param>
		public void Create(string strTipoIdentificacion, double IntNit, int? intDigito, string strNombres, string strDireccion, bool? logEstado, bool? logConductor, string strPlaca, string lngIdCiudad, string strTelefono, string strTelefonoAux, string strTelCelular, string strTelCelularAux, string strFax, string IntAAereo, string StrPais, double? nitProvedor, double? intNoLicenciaConduc, int? intCategoria, string strTarjetaTripulante, DateTime? dtmFechaVenceLicencia, DateTime? dtmVenceTarjetaTripulante, string strCarnetEmpresa, string strCarnetComunicaciones, DateTime? dtmFechaModif, bool? logActualizado, int? lngIdUsuario,string module, Sinapsys.Datos.SQL datosTransaccion=null)
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

				paramlist.AddWithValue("@strTipoIdentificacion",strTipoIdentificacion);
				paramlist.AddWithValue("@IntNit",IntNit);
				if (intDigito !=null)
				{
					paramlist.AddWithValue("@intDigito",intDigito);
				}
				if (strNombres !=null)
				{
					paramlist.AddWithValue("@strNombres",strNombres);
				}
				if (strDireccion !=null)
				{
					paramlist.AddWithValue("@strDireccion",strDireccion);
				}
				if (logEstado !=null)
				{
					paramlist.AddWithValue("@logEstado",logEstado);
				}
				if (logConductor !=null)
				{
					paramlist.AddWithValue("@logConductor",logConductor);
				}
				if (strPlaca !=null)
				{
					paramlist.AddWithValue("@strPlaca",strPlaca);
				}
				if (lngIdCiudad !=null)
				{
					paramlist.AddWithValue("@lngIdCiudad",lngIdCiudad);
				}
				if (strTelefono !=null)
				{
					paramlist.AddWithValue("@strTelefono",strTelefono);
				}
				if (strTelefonoAux !=null)
				{
					paramlist.AddWithValue("@strTelefonoAux",strTelefonoAux);
				}
				if (strTelCelular !=null)
				{
					paramlist.AddWithValue("@strTelCelular",strTelCelular);
				}
				if (strTelCelularAux !=null)
				{
					paramlist.AddWithValue("@strTelCelularAux",strTelCelularAux);
				}
				if (strFax !=null)
				{
					paramlist.AddWithValue("@strFax",strFax);
				}
				if (IntAAereo !=null)
				{
					paramlist.AddWithValue("@IntAAereo",IntAAereo);
				}
				if (StrPais !=null)
				{
					paramlist.AddWithValue("@StrPais",StrPais);
				}
				if (nitProvedor !=null)
				{
					paramlist.AddWithValue("@nitProvedor",nitProvedor);
				}
				if (intNoLicenciaConduc !=null)
				{
					paramlist.AddWithValue("@intNoLicenciaConduc",intNoLicenciaConduc);
				}
				if (intCategoria !=null)
				{
					paramlist.AddWithValue("@intCategoria",intCategoria);
				}
				if (strTarjetaTripulante !=null)
				{
					paramlist.AddWithValue("@strTarjetaTripulante",strTarjetaTripulante);
				}
				if (dtmFechaVenceLicencia !=null)
				{
					paramlist.AddWithValue("@dtmFechaVenceLicencia",dtmFechaVenceLicencia);
				}
				if (dtmVenceTarjetaTripulante !=null)
				{
					paramlist.AddWithValue("@dtmVenceTarjetaTripulante",dtmVenceTarjetaTripulante);
				}
				if (strCarnetEmpresa !=null)
				{
					paramlist.AddWithValue("@strCarnetEmpresa",strCarnetEmpresa);
				}
				if (strCarnetComunicaciones !=null)
				{
					paramlist.AddWithValue("@strCarnetComunicaciones",strCarnetComunicaciones);
				}
				if (dtmFechaModif !=null)
				{
					paramlist.AddWithValue("@dtmFechaModif",dtmFechaModif);
				}
				if (logActualizado !=null)
				{
					paramlist.AddWithValue("@logActualizado",logActualizado);
				}
				if (lngIdUsuario !=null)
				{
					paramlist.AddWithValue("@lngIdUsuario",lngIdUsuario);
				}
				LocalDataProvider.EjecutarProcedimiento("dbo.TercerosConductoresCreate", paramlist, disconnect, out nullExit, DataProvider.TiempoEspera);
			}
			catch (Exception ex)
			{
				Utilidades.LogErrores(ex.Message + (ex.InnerException != null ? ex.InnerException.Message : ""), DataProvider.AplicacionNombre);
				throw ex;
			}
		}

		/// <summary>
		/// Updates one record into tblTercerosConductores by passing all fields
		/// </summary>
		/// <param name="intDigito"></param>
		/// <param name="strNombres"></param>
		/// <param name="strDireccion"></param>
		/// <param name="logEstado"></param>
		/// <param name="logConductor"></param>
		/// <param name="strPlaca"></param>
		/// <param name="lngIdCiudad"></param>
		/// <param name="strTelefono"></param>
		/// <param name="strTelefonoAux"></param>
		/// <param name="strTelCelular"></param>
		/// <param name="strTelCelularAux"></param>
		/// <param name="strFax"></param>
		/// <param name="IntAAereo"></param>
		/// <param name="StrPais"></param>
		/// <param name="nitProvedor"></param>
		/// <param name="intNoLicenciaConduc"></param>
		/// <param name="intCategoria"></param>
		/// <param name="strTarjetaTripulante"></param>
		/// <param name="dtmFechaVenceLicencia"></param>
		/// <param name="dtmVenceTarjetaTripulante"></param>
		/// <param name="strCarnetEmpresa"></param>
		/// <param name="strCarnetComunicaciones"></param>
		/// <param name="dtmFechaModif"></param>
		/// <param name="logActualizado"></param>
		/// <param name="lngIdUsuario"></param>
		/// <param name="strTipoIdentificacion"></param>
		/// <param name="IntNit"></param>
		public void Update(int? intDigito, string strNombres, string strDireccion, bool? logEstado, bool? logConductor, string strPlaca, string lngIdCiudad, string strTelefono, string strTelefonoAux, string strTelCelular, string strTelCelularAux, string strFax, string IntAAereo, string StrPais, double? nitProvedor, double? intNoLicenciaConduc, int? intCategoria, string strTarjetaTripulante, DateTime? dtmFechaVenceLicencia, DateTime? dtmVenceTarjetaTripulante, string strCarnetEmpresa, string strCarnetComunicaciones, DateTime? dtmFechaModif, bool? logActualizado, int? lngIdUsuario, string strTipoIdentificacion, double IntNit,string module, Sinapsys.Datos.SQL datosTransaccion=null)
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
				paramlist.AddWithValue("@strTipoIdentificacion",strTipoIdentificacion);
				paramlist.AddWithValue("@IntNit",IntNit);
				if (intDigito !=null)
				{
					paramlist.AddWithValue("@intDigito",intDigito);
				}
				if (strNombres !=null)
				{
					paramlist.AddWithValue("@strNombres",strNombres);
				}
				if (strDireccion !=null)
				{
					paramlist.AddWithValue("@strDireccion",strDireccion);
				}
				if (logEstado !=null)
				{
					paramlist.AddWithValue("@logEstado",logEstado);
				}
				if (logConductor !=null)
				{
					paramlist.AddWithValue("@logConductor",logConductor);
				}
				if (strPlaca !=null)
				{
					paramlist.AddWithValue("@strPlaca",strPlaca);
				}
				if (lngIdCiudad !=null)
				{
					paramlist.AddWithValue("@lngIdCiudad",lngIdCiudad);
				}
				if (strTelefono !=null)
				{
					paramlist.AddWithValue("@strTelefono",strTelefono);
				}
				if (strTelefonoAux !=null)
				{
					paramlist.AddWithValue("@strTelefonoAux",strTelefonoAux);
				}
				if (strTelCelular !=null)
				{
					paramlist.AddWithValue("@strTelCelular",strTelCelular);
				}
				if (strTelCelularAux !=null)
				{
					paramlist.AddWithValue("@strTelCelularAux",strTelCelularAux);
				}
				if (strFax !=null)
				{
					paramlist.AddWithValue("@strFax",strFax);
				}
				if (IntAAereo !=null)
				{
					paramlist.AddWithValue("@IntAAereo",IntAAereo);
				}
				if (StrPais !=null)
				{
					paramlist.AddWithValue("@StrPais",StrPais);
				}
				if (nitProvedor !=null)
				{
					paramlist.AddWithValue("@nitProvedor",nitProvedor);
				}
				if (intNoLicenciaConduc !=null)
				{
					paramlist.AddWithValue("@intNoLicenciaConduc",intNoLicenciaConduc);
				}
				if (intCategoria !=null)
				{
					paramlist.AddWithValue("@intCategoria",intCategoria);
				}
				if (strTarjetaTripulante !=null)
				{
					paramlist.AddWithValue("@strTarjetaTripulante",strTarjetaTripulante);
				}
				if (dtmFechaVenceLicencia !=null)
				{
					paramlist.AddWithValue("@dtmFechaVenceLicencia",dtmFechaVenceLicencia);
				}
				if (dtmVenceTarjetaTripulante !=null)
				{
					paramlist.AddWithValue("@dtmVenceTarjetaTripulante",dtmVenceTarjetaTripulante);
				}
				if (strCarnetEmpresa !=null)
				{
					paramlist.AddWithValue("@strCarnetEmpresa",strCarnetEmpresa);
				}
				if (strCarnetComunicaciones !=null)
				{
					paramlist.AddWithValue("@strCarnetComunicaciones",strCarnetComunicaciones);
				}
				if (dtmFechaModif !=null)
				{
					paramlist.AddWithValue("@dtmFechaModif",dtmFechaModif);
				}
				if (logActualizado !=null)
				{
					paramlist.AddWithValue("@logActualizado",logActualizado);
				}
				if (lngIdUsuario !=null)
				{
					paramlist.AddWithValue("@lngIdUsuario",lngIdUsuario);
				}
				LocalDataProvider.EjecutarProcedimiento("dbo.TercerosConductoresUpdate", paramlist, disconnect, out nullExit, DataProvider.TiempoEspera);
			}
			catch (Exception ex)
			{
				Utilidades.LogErrores(ex.Message + (ex.InnerException != null ? ex.InnerException.Message : ""), DataProvider.AplicacionNombre);
				throw ex;
			}
		}

		/// <summary>
		/// Deletes one record from tblTercerosConductores by passing all key fields
		/// </summary>
		/// <param name="strTipoIdentificacion"></param>
		/// <param name="IntNit"></param>
		public void Delete(string strTipoIdentificacion, double IntNit,string module, Sinapsys.Datos.SQL datosTransaccion=null)
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
				paramlist.AddWithValue("@strTipoIdentificacion",strTipoIdentificacion);
				paramlist.AddWithValue("@IntNit",IntNit);
				LocalDataProvider.EjecutarProcedimiento("dbo.TercerosConductoresDelete", paramlist, disconnect, out nullExit, DataProvider.TiempoEspera);
			}
			catch (Exception ex)
			{
				Utilidades.LogErrores(ex.Message + (ex.InnerException != null ? ex.InnerException.Message : ""), DataProvider.AplicacionNombre);
				throw ex;
			}
		}

		/// <summary>
		/// Gets one record from tblTercerosConductores passing all key fields
		/// </summary>
		/// <param name="strTipoIdentificacion"></param>
		/// <param name="IntNit"></param>
		/// <returns>A DataTable object containing the data</returns>
		public DataTable Get(string strTipoIdentificacion, double IntNit)
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
				paramlist.AddWithValue("@strTipoIdentificacion",strTipoIdentificacion);
				paramlist.AddWithValue("@IntNit",IntNit);
				return LocalDataProvider.EjecutarProcedimiento("dbo.TercerosConductoresGet", paramlist, disconnect, out nullExit, DataProvider.TiempoEspera);

			}
			catch (Exception ex)
			{
				Utilidades.LogErrores(ex.Message + (ex.InnerException != null ? ex.InnerException.Message : ""), DataProvider.AplicacionNombre);
				throw ex;
			}
		}

		/// <summary>
		/// Gets all records from tblTercerosConductores
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
				return LocalDataProvider.EjecutarProcedimiento("dbo.TercerosConductoresGetAll", paramlist, disconnect, out nullExit, DataProvider.TiempoEspera);
			}
			catch (Exception ex)
			{
				Utilidades.LogErrores(ex.Message + (ex.InnerException != null ? ex.InnerException.Message : ""), DataProvider.AplicacionNombre);
				throw ex;
			}
		}

		/// <summary>
		/// Gets all records from tblTercerosConductores applying filter and sort criteria
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

				return LocalDataProvider.EjecutarProcedimiento("dbo.TercerosConductoresGetFilter", paramlist, disconnect, out nullExit, DataProvider.TiempoEspera);
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
		/// Gets the numbers of records from tblTercerosConductores applying filter and sort criteria
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

				return (int) LocalDataProvider.EjecutarProcedimiento("dbo.TercerosConductoresGetFilter", paramlist, disconnect, out nullExit, DataProvider.TiempoEspera).Rows[0][0];
			}
			catch (Exception ex)
			{
				Utilidades.LogErrores(ex.Message + (ex.InnerException != null ? ex.InnerException.Message : ""), DataProvider.AplicacionNombre);
				throw ex;
			}
		}

	}
}
