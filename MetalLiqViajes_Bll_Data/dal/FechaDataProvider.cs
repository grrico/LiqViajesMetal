using System;
using System.Data;
using System.Data.Common;
using Sinapsys.Datos;
using LiqViajes_Bll_Data.Security;
using System.Runtime.Serialization;

namespace LiqViajes_Bll_Data
{
	/// <summary>
	/// Data Access Layer class for Fecha object
	/// </summary>
	/// <remarks>
	/// This class is a Singleton
	/// </remarks>
	public partial class FechaDataProvider
	{
		/// <summary>
		/// Internal member for create this singleton
		/// </summary>
		private static FechaDataProvider MySingleObj = null;

		/// <summary>
		/// Protected constructor to avoid access this singleton other way than calling the Instance method
		/// </summary>
		public FechaDataProvider()
		{

		}

		/// <summary>
		/// Instance accessor for this singleton
		/// </summary>
		public static FechaDataProvider Instance
		{
			get
			{
				if (MySingleObj == null)
				{
					MySingleObj = new FechaDataProvider();
				}

				return MySingleObj;
			}
		}

		/// <summary>
		/// Creates a new record into Fecha by passing all fields
		/// </summary>
		/// <param name="Date_Name"></param>
		/// <param name="Year"></param>
		/// <param name="Year_Name"></param>
		/// <param name="Trimester"></param>
		/// <param name="Trimester_Name"></param>
		/// <param name="Month"></param>
		/// <param name="Month_Name"></param>
		/// <param name="Week"></param>
		/// <param name="Week_Name"></param>
		/// <param name="Day_Of_Year"></param>
		/// <param name="Day_Of_Year_Name"></param>
		/// <param name="Day_Of_Trimester"></param>
		/// <param name="Day_Of_Trimester_Name"></param>
		/// <param name="Day_Of_Month"></param>
		/// <param name="Day_Of_Month_Name"></param>
		/// <param name="Day_Of_Week"></param>
		/// <param name="Day_Of_Week_Name"></param>
		/// <param name="Week_Of_Year"></param>
		/// <param name="Week_Of_Year_Name"></param>
		/// <param name="Month_Of_Year"></param>
		/// <param name="Month_Of_Year_Name"></param>
		/// <param name="Month_Of_Trimester"></param>
		/// <param name="Month_Of_Trimester_Name"></param>
		/// <param name="Trimester_Of_Year"></param>
		/// <param name="Trimester_Of_Year_Name"></param>
		public void Create(DateTime PK_Date, string Date_Name, DateTime? Year, string Year_Name, DateTime? Trimester, string Trimester_Name, DateTime? Month, string Month_Name, DateTime? Week, string Week_Name, int? Day_Of_Year, string Day_Of_Year_Name, int? Day_Of_Trimester, string Day_Of_Trimester_Name, int? Day_Of_Month, string Day_Of_Month_Name, int? Day_Of_Week, string Day_Of_Week_Name, int? Week_Of_Year, string Week_Of_Year_Name, int? Month_Of_Year, string Month_Of_Year_Name, int? Month_Of_Trimester, string Month_Of_Trimester_Name, int? Trimester_Of_Year, string Trimester_Of_Year_Name,string module, Sinapsys.Datos.SQL datosTransaccion=null)
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

				paramlist.AddWithValue("@PK_Date",PK_Date);
				if (Date_Name !=null)
				{
					paramlist.AddWithValue("@Date_Name",Date_Name);
				}
				if (Year !=null)
				{
					paramlist.AddWithValue("@Year",Year);
				}
				if (Year_Name !=null)
				{
					paramlist.AddWithValue("@Year_Name",Year_Name);
				}
				if (Trimester !=null)
				{
					paramlist.AddWithValue("@Trimester",Trimester);
				}
				if (Trimester_Name !=null)
				{
					paramlist.AddWithValue("@Trimester_Name",Trimester_Name);
				}
				if (Month !=null)
				{
					paramlist.AddWithValue("@Month",Month);
				}
				if (Month_Name !=null)
				{
					paramlist.AddWithValue("@Month_Name",Month_Name);
				}
				if (Week !=null)
				{
					paramlist.AddWithValue("@Week",Week);
				}
				if (Week_Name !=null)
				{
					paramlist.AddWithValue("@Week_Name",Week_Name);
				}
				if (Day_Of_Year !=null)
				{
					paramlist.AddWithValue("@Day_Of_Year",Day_Of_Year);
				}
				if (Day_Of_Year_Name !=null)
				{
					paramlist.AddWithValue("@Day_Of_Year_Name",Day_Of_Year_Name);
				}
				if (Day_Of_Trimester !=null)
				{
					paramlist.AddWithValue("@Day_Of_Trimester",Day_Of_Trimester);
				}
				if (Day_Of_Trimester_Name !=null)
				{
					paramlist.AddWithValue("@Day_Of_Trimester_Name",Day_Of_Trimester_Name);
				}
				if (Day_Of_Month !=null)
				{
					paramlist.AddWithValue("@Day_Of_Month",Day_Of_Month);
				}
				if (Day_Of_Month_Name !=null)
				{
					paramlist.AddWithValue("@Day_Of_Month_Name",Day_Of_Month_Name);
				}
				if (Day_Of_Week !=null)
				{
					paramlist.AddWithValue("@Day_Of_Week",Day_Of_Week);
				}
				if (Day_Of_Week_Name !=null)
				{
					paramlist.AddWithValue("@Day_Of_Week_Name",Day_Of_Week_Name);
				}
				if (Week_Of_Year !=null)
				{
					paramlist.AddWithValue("@Week_Of_Year",Week_Of_Year);
				}
				if (Week_Of_Year_Name !=null)
				{
					paramlist.AddWithValue("@Week_Of_Year_Name",Week_Of_Year_Name);
				}
				if (Month_Of_Year !=null)
				{
					paramlist.AddWithValue("@Month_Of_Year",Month_Of_Year);
				}
				if (Month_Of_Year_Name !=null)
				{
					paramlist.AddWithValue("@Month_Of_Year_Name",Month_Of_Year_Name);
				}
				if (Month_Of_Trimester !=null)
				{
					paramlist.AddWithValue("@Month_Of_Trimester",Month_Of_Trimester);
				}
				if (Month_Of_Trimester_Name !=null)
				{
					paramlist.AddWithValue("@Month_Of_Trimester_Name",Month_Of_Trimester_Name);
				}
				if (Trimester_Of_Year !=null)
				{
					paramlist.AddWithValue("@Trimester_Of_Year",Trimester_Of_Year);
				}
				if (Trimester_Of_Year_Name !=null)
				{
					paramlist.AddWithValue("@Trimester_Of_Year_Name",Trimester_Of_Year_Name);
				}
				LocalDataProvider.EjecutarProcedimiento("dbo.FechaCreate", paramlist, disconnect, out nullExit, DataProvider.TiempoEspera);
			}
			catch (Exception ex)
			{
				Utilidades.LogErrores(ex.Message + (ex.InnerException != null ? ex.InnerException.Message : ""), DataProvider.AplicacionNombre);
				throw ex;
			}
		}

		/// <summary>
		/// Updates one record into Fecha by passing all fields
		/// </summary>
		/// <param name="Date_Name"></param>
		/// <param name="Year"></param>
		/// <param name="Year_Name"></param>
		/// <param name="Trimester"></param>
		/// <param name="Trimester_Name"></param>
		/// <param name="Month"></param>
		/// <param name="Month_Name"></param>
		/// <param name="Week"></param>
		/// <param name="Week_Name"></param>
		/// <param name="Day_Of_Year"></param>
		/// <param name="Day_Of_Year_Name"></param>
		/// <param name="Day_Of_Trimester"></param>
		/// <param name="Day_Of_Trimester_Name"></param>
		/// <param name="Day_Of_Month"></param>
		/// <param name="Day_Of_Month_Name"></param>
		/// <param name="Day_Of_Week"></param>
		/// <param name="Day_Of_Week_Name"></param>
		/// <param name="Week_Of_Year"></param>
		/// <param name="Week_Of_Year_Name"></param>
		/// <param name="Month_Of_Year"></param>
		/// <param name="Month_Of_Year_Name"></param>
		/// <param name="Month_Of_Trimester"></param>
		/// <param name="Month_Of_Trimester_Name"></param>
		/// <param name="Trimester_Of_Year"></param>
		/// <param name="Trimester_Of_Year_Name"></param>
		/// <param name="PK_Date"></param>
		public void Update(string Date_Name, DateTime? Year, string Year_Name, DateTime? Trimester, string Trimester_Name, DateTime? Month, string Month_Name, DateTime? Week, string Week_Name, int? Day_Of_Year, string Day_Of_Year_Name, int? Day_Of_Trimester, string Day_Of_Trimester_Name, int? Day_Of_Month, string Day_Of_Month_Name, int? Day_Of_Week, string Day_Of_Week_Name, int? Week_Of_Year, string Week_Of_Year_Name, int? Month_Of_Year, string Month_Of_Year_Name, int? Month_Of_Trimester, string Month_Of_Trimester_Name, int? Trimester_Of_Year, string Trimester_Of_Year_Name, DateTime PK_Date,string module, Sinapsys.Datos.SQL datosTransaccion=null)
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
				paramlist.AddWithValue("@PK_Date",PK_Date);
				if (Date_Name !=null)
				{
					paramlist.AddWithValue("@Date_Name",Date_Name);
				}
				if (Year !=null)
				{
					paramlist.AddWithValue("@Year",Year);
				}
				if (Year_Name !=null)
				{
					paramlist.AddWithValue("@Year_Name",Year_Name);
				}
				if (Trimester !=null)
				{
					paramlist.AddWithValue("@Trimester",Trimester);
				}
				if (Trimester_Name !=null)
				{
					paramlist.AddWithValue("@Trimester_Name",Trimester_Name);
				}
				if (Month !=null)
				{
					paramlist.AddWithValue("@Month",Month);
				}
				if (Month_Name !=null)
				{
					paramlist.AddWithValue("@Month_Name",Month_Name);
				}
				if (Week !=null)
				{
					paramlist.AddWithValue("@Week",Week);
				}
				if (Week_Name !=null)
				{
					paramlist.AddWithValue("@Week_Name",Week_Name);
				}
				if (Day_Of_Year !=null)
				{
					paramlist.AddWithValue("@Day_Of_Year",Day_Of_Year);
				}
				if (Day_Of_Year_Name !=null)
				{
					paramlist.AddWithValue("@Day_Of_Year_Name",Day_Of_Year_Name);
				}
				if (Day_Of_Trimester !=null)
				{
					paramlist.AddWithValue("@Day_Of_Trimester",Day_Of_Trimester);
				}
				if (Day_Of_Trimester_Name !=null)
				{
					paramlist.AddWithValue("@Day_Of_Trimester_Name",Day_Of_Trimester_Name);
				}
				if (Day_Of_Month !=null)
				{
					paramlist.AddWithValue("@Day_Of_Month",Day_Of_Month);
				}
				if (Day_Of_Month_Name !=null)
				{
					paramlist.AddWithValue("@Day_Of_Month_Name",Day_Of_Month_Name);
				}
				if (Day_Of_Week !=null)
				{
					paramlist.AddWithValue("@Day_Of_Week",Day_Of_Week);
				}
				if (Day_Of_Week_Name !=null)
				{
					paramlist.AddWithValue("@Day_Of_Week_Name",Day_Of_Week_Name);
				}
				if (Week_Of_Year !=null)
				{
					paramlist.AddWithValue("@Week_Of_Year",Week_Of_Year);
				}
				if (Week_Of_Year_Name !=null)
				{
					paramlist.AddWithValue("@Week_Of_Year_Name",Week_Of_Year_Name);
				}
				if (Month_Of_Year !=null)
				{
					paramlist.AddWithValue("@Month_Of_Year",Month_Of_Year);
				}
				if (Month_Of_Year_Name !=null)
				{
					paramlist.AddWithValue("@Month_Of_Year_Name",Month_Of_Year_Name);
				}
				if (Month_Of_Trimester !=null)
				{
					paramlist.AddWithValue("@Month_Of_Trimester",Month_Of_Trimester);
				}
				if (Month_Of_Trimester_Name !=null)
				{
					paramlist.AddWithValue("@Month_Of_Trimester_Name",Month_Of_Trimester_Name);
				}
				if (Trimester_Of_Year !=null)
				{
					paramlist.AddWithValue("@Trimester_Of_Year",Trimester_Of_Year);
				}
				if (Trimester_Of_Year_Name !=null)
				{
					paramlist.AddWithValue("@Trimester_Of_Year_Name",Trimester_Of_Year_Name);
				}
				LocalDataProvider.EjecutarProcedimiento("dbo.FechaUpdate", paramlist, disconnect, out nullExit, DataProvider.TiempoEspera);
			}
			catch (Exception ex)
			{
				Utilidades.LogErrores(ex.Message + (ex.InnerException != null ? ex.InnerException.Message : ""), DataProvider.AplicacionNombre);
				throw ex;
			}
		}

		/// <summary>
		/// Deletes one record from Fecha by passing all key fields
		/// </summary>
		/// <param name="PK_Date"></param>
		public void Delete(DateTime PK_Date,string module, Sinapsys.Datos.SQL datosTransaccion=null)
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
				paramlist.AddWithValue("@PK_Date",PK_Date);
				LocalDataProvider.EjecutarProcedimiento("dbo.FechaDelete", paramlist, disconnect, out nullExit, DataProvider.TiempoEspera);
			}
			catch (Exception ex)
			{
				Utilidades.LogErrores(ex.Message + (ex.InnerException != null ? ex.InnerException.Message : ""), DataProvider.AplicacionNombre);
				throw ex;
			}
		}

		/// <summary>
		/// Gets one record from Fecha passing all key fields
		/// </summary>
		/// <param name="PK_Date"></param>
		/// <returns>A DataTable object containing the data</returns>
		public DataTable Get(DateTime PK_Date)
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
				paramlist.AddWithValue("@PK_Date",PK_Date);
				return LocalDataProvider.EjecutarProcedimiento("dbo.FechaGet", paramlist, disconnect, out nullExit, DataProvider.TiempoEspera);

			}
			catch (Exception ex)
			{
				Utilidades.LogErrores(ex.Message + (ex.InnerException != null ? ex.InnerException.Message : ""), DataProvider.AplicacionNombre);
				throw ex;
			}
		}

		/// <summary>
		/// Gets all records from Fecha
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
				return LocalDataProvider.EjecutarProcedimiento("dbo.FechaGetAll", paramlist, disconnect, out nullExit, DataProvider.TiempoEspera);
			}
			catch (Exception ex)
			{
				Utilidades.LogErrores(ex.Message + (ex.InnerException != null ? ex.InnerException.Message : ""), DataProvider.AplicacionNombre);
				throw ex;
			}
		}

		/// <summary>
		/// Gets all records from Fecha applying filter and sort criteria
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

				return LocalDataProvider.EjecutarProcedimiento("dbo.FechaGetFilter", paramlist, disconnect, out nullExit, DataProvider.TiempoEspera);
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
		/// Gets the numbers of records from Fecha applying filter and sort criteria
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

				return (int) LocalDataProvider.EjecutarProcedimiento("dbo.FechaGetFilter", paramlist, disconnect, out nullExit, DataProvider.TiempoEspera).Rows[0][0];
			}
			catch (Exception ex)
			{
				Utilidades.LogErrores(ex.Message + (ex.InnerException != null ? ex.InnerException.Message : ""), DataProvider.AplicacionNombre);
				throw ex;
			}
		}

	}
}
