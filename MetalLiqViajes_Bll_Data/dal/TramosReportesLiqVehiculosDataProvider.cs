using System;
using System.Data;
using System.Data.Common;
using Sinapsys.Datos;
using LiqViajes_Bll_Data.Security;
using System.Runtime.Serialization;

namespace LiqViajes_Bll_Data
{
	/// <summary>
	/// Data Access Layer class for TramosReportesLiqVehiculos object
	/// </summary>
	/// <remarks>
	/// This class is a Singleton
	/// </remarks>
	public partial class TramosReportesLiqVehiculosDataProvider
	{
		/// <summary>
		/// Internal member for create this singleton
		/// </summary>
		private static TramosReportesLiqVehiculosDataProvider MySingleObj = null;

		/// <summary>
		/// Protected constructor to avoid access this singleton other way than calling the Instance method
		/// </summary>
		public TramosReportesLiqVehiculosDataProvider()
		{

		}

		/// <summary>
		/// Instance accessor for this singleton
		/// </summary>
		public static TramosReportesLiqVehiculosDataProvider Instance
		{
			get
			{
				if (MySingleObj == null)
				{
					MySingleObj = new TramosReportesLiqVehiculosDataProvider();
				}

				return MySingleObj;
			}
		}

		/// <summary>
		/// Creates a new record into TramosReportesLiqVehiculos by passing all fields
		/// </summary>
		/// <param name="Fecha"></param>
		/// <param name="Centro"></param>
		/// <param name="Marca"></param>
		/// <param name="Placa"></param>
		/// <param name="Modelo"></param>
		/// <param name="CedulaConductor"></param>
		/// <param name="NombreConductor"></param>
		/// <param name="TotalGatos"></param>
		/// <param name="TotalAnticipos"></param>
		/// <param name="TotalGeneral"></param>
		public void Create(long Registro, DateTime? Fecha, double? Centro, string Marca, string Placa, double? Modelo, string CedulaConductor, string NombreConductor, decimal? TotalGatos, decimal? TotalAnticipos, decimal? TotalGeneral,string module, Sinapsys.Datos.SQL datosTransaccion=null)
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

				paramlist.AddWithValue("@Registro",Registro);
				if (Fecha !=null)
				{
					paramlist.AddWithValue("@Fecha",Fecha);
				}
				if (Centro !=null)
				{
					paramlist.AddWithValue("@Centro",Centro);
				}
				if (Marca !=null)
				{
					paramlist.AddWithValue("@Marca",Marca);
				}
				if (Placa !=null)
				{
					paramlist.AddWithValue("@Placa",Placa);
				}
				if (Modelo !=null)
				{
					paramlist.AddWithValue("@Modelo",Modelo);
				}
				if (CedulaConductor !=null)
				{
					paramlist.AddWithValue("@CedulaConductor",CedulaConductor);
				}
				if (NombreConductor !=null)
				{
					paramlist.AddWithValue("@NombreConductor",NombreConductor);
				}
				if (TotalGatos !=null)
				{
					paramlist.AddWithValue("@TotalGatos",TotalGatos);
				}
				if (TotalAnticipos !=null)
				{
					paramlist.AddWithValue("@TotalAnticipos",TotalAnticipos);
				}
				if (TotalGeneral !=null)
				{
					paramlist.AddWithValue("@TotalGeneral",TotalGeneral);
				}
				LocalDataProvider.EjecutarProcedimiento("dbo.TramosReportesLiqVehiculosCreate", paramlist, disconnect, out nullExit, DataProvider.TiempoEspera);
			}
			catch (Exception ex)
			{
				Utilidades.LogErrores(ex.Message + (ex.InnerException != null ? ex.InnerException.Message : ""), DataProvider.AplicacionNombre);
				throw ex;
			}
		}

		/// <summary>
		/// Updates one record into TramosReportesLiqVehiculos by passing all fields
		/// </summary>
		/// <param name="Fecha"></param>
		/// <param name="Centro"></param>
		/// <param name="Marca"></param>
		/// <param name="Placa"></param>
		/// <param name="Modelo"></param>
		/// <param name="CedulaConductor"></param>
		/// <param name="NombreConductor"></param>
		/// <param name="TotalGatos"></param>
		/// <param name="TotalAnticipos"></param>
		/// <param name="TotalGeneral"></param>
		/// <param name="Registro"></param>
		public void Update(DateTime? Fecha, double? Centro, string Marca, string Placa, double? Modelo, string CedulaConductor, string NombreConductor, decimal? TotalGatos, decimal? TotalAnticipos, decimal? TotalGeneral, long Registro,string module, Sinapsys.Datos.SQL datosTransaccion=null)
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
				paramlist.AddWithValue("@Registro",Registro);
				if (Fecha !=null)
				{
					paramlist.AddWithValue("@Fecha",Fecha);
				}
				if (Centro !=null)
				{
					paramlist.AddWithValue("@Centro",Centro);
				}
				if (Marca !=null)
				{
					paramlist.AddWithValue("@Marca",Marca);
				}
				if (Placa !=null)
				{
					paramlist.AddWithValue("@Placa",Placa);
				}
				if (Modelo !=null)
				{
					paramlist.AddWithValue("@Modelo",Modelo);
				}
				if (CedulaConductor !=null)
				{
					paramlist.AddWithValue("@CedulaConductor",CedulaConductor);
				}
				if (NombreConductor !=null)
				{
					paramlist.AddWithValue("@NombreConductor",NombreConductor);
				}
				if (TotalGatos !=null)
				{
					paramlist.AddWithValue("@TotalGatos",TotalGatos);
				}
				if (TotalAnticipos !=null)
				{
					paramlist.AddWithValue("@TotalAnticipos",TotalAnticipos);
				}
				if (TotalGeneral !=null)
				{
					paramlist.AddWithValue("@TotalGeneral",TotalGeneral);
				}
				LocalDataProvider.EjecutarProcedimiento("dbo.TramosReportesLiqVehiculosUpdate", paramlist, disconnect, out nullExit, DataProvider.TiempoEspera);
			}
			catch (Exception ex)
			{
				Utilidades.LogErrores(ex.Message + (ex.InnerException != null ? ex.InnerException.Message : ""), DataProvider.AplicacionNombre);
				throw ex;
			}
		}

		/// <summary>
		/// Deletes one record from TramosReportesLiqVehiculos by passing all key fields
		/// </summary>
		/// <param name="Registro"></param>
		public void Delete(long Registro,string module, Sinapsys.Datos.SQL datosTransaccion=null)
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
				paramlist.AddWithValue("@Registro",Registro);
				LocalDataProvider.EjecutarProcedimiento("dbo.TramosReportesLiqVehiculosDelete", paramlist, disconnect, out nullExit, DataProvider.TiempoEspera);
			}
			catch (Exception ex)
			{
				Utilidades.LogErrores(ex.Message + (ex.InnerException != null ? ex.InnerException.Message : ""), DataProvider.AplicacionNombre);
				throw ex;
			}
		}

		/// <summary>
		/// Gets one record from TramosReportesLiqVehiculos passing all key fields
		/// </summary>
		/// <param name="Registro"></param>
		/// <returns>A DataTable object containing the data</returns>
		public DataTable Get(long Registro)
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
				paramlist.AddWithValue("@Registro",Registro);
				return LocalDataProvider.EjecutarProcedimiento("dbo.TramosReportesLiqVehiculosGet", paramlist, disconnect, out nullExit, DataProvider.TiempoEspera);

			}
			catch (Exception ex)
			{
				Utilidades.LogErrores(ex.Message + (ex.InnerException != null ? ex.InnerException.Message : ""), DataProvider.AplicacionNombre);
				throw ex;
			}
		}

		/// <summary>
		/// Gets all records from TramosReportesLiqVehiculos
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
				return LocalDataProvider.EjecutarProcedimiento("dbo.TramosReportesLiqVehiculosGetAll", paramlist, disconnect, out nullExit, DataProvider.TiempoEspera);
			}
			catch (Exception ex)
			{
				Utilidades.LogErrores(ex.Message + (ex.InnerException != null ? ex.InnerException.Message : ""), DataProvider.AplicacionNombre);
				throw ex;
			}
		}

		/// <summary>
		/// Gets all records from TramosReportesLiqVehiculos applying filter and sort criteria
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

				return LocalDataProvider.EjecutarProcedimiento("dbo.TramosReportesLiqVehiculosGetFilter", paramlist, disconnect, out nullExit, DataProvider.TiempoEspera);
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
		/// Gets the numbers of records from TramosReportesLiqVehiculos applying filter and sort criteria
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

				return (int) LocalDataProvider.EjecutarProcedimiento("dbo.TramosReportesLiqVehiculosGetFilter", paramlist, disconnect, out nullExit, DataProvider.TiempoEspera).Rows[0][0];
			}
			catch (Exception ex)
			{
				Utilidades.LogErrores(ex.Message + (ex.InnerException != null ? ex.InnerException.Message : ""), DataProvider.AplicacionNombre);
				throw ex;
			}
		}

	}
}
