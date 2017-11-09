using System;
using System.Data;
using System.Data.Common;
using Sinapsys.Datos;
using LiqViajes_Bll_Data.Security;
using System.Runtime.Serialization;

namespace LiqViajes_Bll_Data
{
	/// <summary>
	/// Data Access Layer class for RutaSatrackEvents object
	/// </summary>
	/// <remarks>
	/// This class is a Singleton
	/// </remarks>
	public partial class RutaSatrackEventsDataProvider
	{
		/// <summary>
		/// Internal member for create this singleton
		/// </summary>
		private static RutaSatrackEventsDataProvider MySingleObj = null;

		/// <summary>
		/// Protected constructor to avoid access this singleton other way than calling the Instance method
		/// </summary>
		public RutaSatrackEventsDataProvider()
		{

		}

		/// <summary>
		/// Instance accessor for this singleton
		/// </summary>
		public static RutaSatrackEventsDataProvider Instance
		{
			get
			{
				if (MySingleObj == null)
				{
					MySingleObj = new RutaSatrackEventsDataProvider();
				}

				return MySingleObj;
			}
		}

		/// <summary>
		/// Creates a new record into RutaSatrackEvents by passing all fields
		/// </summary>
		/// <param name="Placa"></param>
		/// <param name="Descripcion"></param>
		/// <param name="FechaHora_GPS"></param>
		/// <param name="Velocidad"></param>
		/// <param name="Direccion"></param>
		/// <param name="Direccion2"></param>
		/// <param name="DivPol1"></param>
		/// <param name="DivPol2"></param>
		/// <param name="DivPol3"></param>
		/// <param name="DivPol4"></param>
		/// <param name="SentidoLetras"></param>
		/// <param name="Latitud"></param>
		/// <param name="Longitud"></param>
		/// <param name="TipoEventoUnificado"></param>
		/// <param name="CodigoNombre"></param>
		public void Create(long Clave_Respuesta, string Placa, string Descripcion, DateTime? FechaHora_GPS, int? Velocidad, string Direccion, string Direccion2, string DivPol1, string DivPol2, string DivPol3, string DivPol4, string SentidoLetras, decimal? Latitud, decimal? Longitud, int? TipoEventoUnificado, string CodigoNombre,string module, Sinapsys.Datos.SQL datosTransaccion=null)
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

				paramlist.AddWithValue("@Clave_Respuesta",Clave_Respuesta);
				if (Placa !=null)
				{
					paramlist.AddWithValue("@Placa",Placa);
				}
				if (Descripcion !=null)
				{
					paramlist.AddWithValue("@Descripcion",Descripcion);
				}
				if (FechaHora_GPS !=null)
				{
					paramlist.AddWithValue("@FechaHora_GPS",FechaHora_GPS);
				}
				if (Velocidad !=null)
				{
					paramlist.AddWithValue("@Velocidad",Velocidad);
				}
				if (Direccion !=null)
				{
					paramlist.AddWithValue("@Direccion",Direccion);
				}
				if (Direccion2 !=null)
				{
					paramlist.AddWithValue("@Direccion2",Direccion2);
				}
				if (DivPol1 !=null)
				{
					paramlist.AddWithValue("@DivPol1",DivPol1);
				}
				if (DivPol2 !=null)
				{
					paramlist.AddWithValue("@DivPol2",DivPol2);
				}
				if (DivPol3 !=null)
				{
					paramlist.AddWithValue("@DivPol3",DivPol3);
				}
				if (DivPol4 !=null)
				{
					paramlist.AddWithValue("@DivPol4",DivPol4);
				}
				if (SentidoLetras !=null)
				{
					paramlist.AddWithValue("@SentidoLetras",SentidoLetras);
				}
				if (Latitud !=null)
				{
					paramlist.AddWithValue("@Latitud",Latitud);
				}
				if (Longitud !=null)
				{
					paramlist.AddWithValue("@Longitud",Longitud);
				}
				if (TipoEventoUnificado !=null)
				{
					paramlist.AddWithValue("@TipoEventoUnificado",TipoEventoUnificado);
				}
				if (CodigoNombre !=null)
				{
					paramlist.AddWithValue("@CodigoNombre",CodigoNombre);
				}
				LocalDataProvider.EjecutarProcedimiento("dbo.RutaSatrackEventsCreate", paramlist, disconnect, out nullExit, DataProvider.TiempoEspera);
			}
			catch (Exception ex)
			{
				Utilidades.LogErrores(ex.Message + (ex.InnerException != null ? ex.InnerException.Message : ""), DataProvider.AplicacionNombre);
				throw ex;
			}
		}

		/// <summary>
		/// Updates one record into RutaSatrackEvents by passing all fields
		/// </summary>
		/// <param name="Clave_Respuesta"></param>
		/// <param name="Placa"></param>
		/// <param name="Descripcion"></param>
		/// <param name="FechaHora_GPS"></param>
		/// <param name="Velocidad"></param>
		/// <param name="Direccion"></param>
		/// <param name="Direccion2"></param>
		/// <param name="DivPol1"></param>
		/// <param name="DivPol2"></param>
		/// <param name="DivPol3"></param>
		/// <param name="DivPol4"></param>
		/// <param name="SentidoLetras"></param>
		/// <param name="Latitud"></param>
		/// <param name="Longitud"></param>
		/// <param name="TipoEventoUnificado"></param>
		/// <param name="CodigoNombre"></param>
		public void Update(long Clave_Respuesta, string Placa, string Descripcion, DateTime? FechaHora_GPS, int? Velocidad, string Direccion, string Direccion2, string DivPol1, string DivPol2, string DivPol3, string DivPol4, string SentidoLetras, decimal? Latitud, decimal? Longitud, int? TipoEventoUnificado, string CodigoNombre,string module, Sinapsys.Datos.SQL datosTransaccion=null)
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
				paramlist.AddWithValue("@Clave_Respuesta",Clave_Respuesta);
				if (Placa !=null)
				{
					paramlist.AddWithValue("@Placa",Placa);
				}
				if (Descripcion !=null)
				{
					paramlist.AddWithValue("@Descripcion",Descripcion);
				}
				if (FechaHora_GPS !=null)
				{
					paramlist.AddWithValue("@FechaHora_GPS",FechaHora_GPS);
				}
				if (Velocidad !=null)
				{
					paramlist.AddWithValue("@Velocidad",Velocidad);
				}
				if (Direccion !=null)
				{
					paramlist.AddWithValue("@Direccion",Direccion);
				}
				if (Direccion2 !=null)
				{
					paramlist.AddWithValue("@Direccion2",Direccion2);
				}
				if (DivPol1 !=null)
				{
					paramlist.AddWithValue("@DivPol1",DivPol1);
				}
				if (DivPol2 !=null)
				{
					paramlist.AddWithValue("@DivPol2",DivPol2);
				}
				if (DivPol3 !=null)
				{
					paramlist.AddWithValue("@DivPol3",DivPol3);
				}
				if (DivPol4 !=null)
				{
					paramlist.AddWithValue("@DivPol4",DivPol4);
				}
				if (SentidoLetras !=null)
				{
					paramlist.AddWithValue("@SentidoLetras",SentidoLetras);
				}
				if (Latitud !=null)
				{
					paramlist.AddWithValue("@Latitud",Latitud);
				}
				if (Longitud !=null)
				{
					paramlist.AddWithValue("@Longitud",Longitud);
				}
				if (TipoEventoUnificado !=null)
				{
					paramlist.AddWithValue("@TipoEventoUnificado",TipoEventoUnificado);
				}
				if (CodigoNombre !=null)
				{
					paramlist.AddWithValue("@CodigoNombre",CodigoNombre);
				}
				LocalDataProvider.EjecutarProcedimiento("dbo.RutaSatrackEventsUpdate", paramlist, disconnect, out nullExit, DataProvider.TiempoEspera);
			}
			catch (Exception ex)
			{
				Utilidades.LogErrores(ex.Message + (ex.InnerException != null ? ex.InnerException.Message : ""), DataProvider.AplicacionNombre);
				throw ex;
			}
		}

		/// <summary>
		/// Deletes one record from RutaSatrackEvents by passing all key fields
		/// </summary>
		/// <param name="Clave_Respuesta"></param>
		public void Delete(long Clave_Respuesta,string module, Sinapsys.Datos.SQL datosTransaccion=null)
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
				paramlist.AddWithValue("@Clave_Respuesta",Clave_Respuesta);
				LocalDataProvider.EjecutarProcedimiento("dbo.RutaSatrackEventsDelete", paramlist, disconnect, out nullExit, DataProvider.TiempoEspera);
			}
			catch (Exception ex)
			{
				Utilidades.LogErrores(ex.Message + (ex.InnerException != null ? ex.InnerException.Message : ""), DataProvider.AplicacionNombre);
				throw ex;
			}
		}

		/// <summary>
		/// Gets one record from RutaSatrackEvents passing all key fields
		/// </summary>
		/// <param name="Clave_Respuesta"></param>
		/// <returns>A DataTable object containing the data</returns>
		public DataTable Get(long Clave_Respuesta)
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
				paramlist.AddWithValue("@Clave_Respuesta",Clave_Respuesta);
				return LocalDataProvider.EjecutarProcedimiento("dbo.RutaSatrackEventsGet", paramlist, disconnect, out nullExit, DataProvider.TiempoEspera);

			}
			catch (Exception ex)
			{
				Utilidades.LogErrores(ex.Message + (ex.InnerException != null ? ex.InnerException.Message : ""), DataProvider.AplicacionNombre);
				throw ex;
			}
		}

		/// <summary>
		/// Gets all records from RutaSatrackEvents
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
				return LocalDataProvider.EjecutarProcedimiento("dbo.RutaSatrackEventsGetAll", paramlist, disconnect, out nullExit, DataProvider.TiempoEspera);
			}
			catch (Exception ex)
			{
				Utilidades.LogErrores(ex.Message + (ex.InnerException != null ? ex.InnerException.Message : ""), DataProvider.AplicacionNombre);
				throw ex;
			}
		}

		/// <summary>
		/// Gets all records from RutaSatrackEvents applying filter and sort criteria
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

				return LocalDataProvider.EjecutarProcedimiento("dbo.RutaSatrackEventsGetFilter", paramlist, disconnect, out nullExit, DataProvider.TiempoEspera);
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
		/// Gets the numbers of records from RutaSatrackEvents applying filter and sort criteria
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

				return (int) LocalDataProvider.EjecutarProcedimiento("dbo.RutaSatrackEventsGetFilter", paramlist, disconnect, out nullExit, DataProvider.TiempoEspera).Rows[0][0];
			}
			catch (Exception ex)
			{
				Utilidades.LogErrores(ex.Message + (ex.InnerException != null ? ex.InnerException.Message : ""), DataProvider.AplicacionNombre);
				throw ex;
			}
		}

	}
}
