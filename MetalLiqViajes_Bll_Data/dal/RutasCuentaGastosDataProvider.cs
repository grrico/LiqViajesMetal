using System;
using System.Data;
using System.Data.Common;
using Sinapsys.Datos;
using LiqViajes_Bll_Data.Security;
using System.Runtime.Serialization;

namespace LiqViajes_Bll_Data
{
	/// <summary>
	/// Data Access Layer class for RutasCuentaGastos object
	/// </summary>
	/// <remarks>
	/// This class is a Singleton
	/// </remarks>
	public partial class RutasCuentaGastosDataProvider
	{
		/// <summary>
		/// Internal member for create this singleton
		/// </summary>
		private static RutasCuentaGastosDataProvider MySingleObj = null;

		/// <summary>
		/// Protected constructor to avoid access this singleton other way than calling the Instance method
		/// </summary>
		public RutasCuentaGastosDataProvider()
		{

		}

		/// <summary>
		/// Instance accessor for this singleton
		/// </summary>
		public static RutasCuentaGastosDataProvider Instance
		{
			get
			{
				if (MySingleObj == null)
				{
					MySingleObj = new RutasCuentaGastosDataProvider();
				}

				return MySingleObj;
			}
		}

		/// <summary>
		/// Creates a new record into RutasCuentaGastos by passing all fields
		/// </summary>
		/// <param name="Campo"></param>
		/// <param name="Cuenta1"></param>
		/// <param name="NombreCuenta1"></param>
		/// <param name="Nit2"></param>
		/// <param name="NombreTercero2"></param>
		/// <param name="Valor3"></param>
		/// <param name="Cuenta4"></param>
		/// <param name="NombreCuenta4"></param>
		/// <param name="Cuenta5"></param>
		/// <param name="NombreCuenta5"></param>
		/// <param name="Nit6"></param>
		/// <param name="NombreTercero6"></param>
		/// <param name="Valor7"></param>
		/// <param name="Cuenta8"></param>
		/// <param name="NombreCuenta8"></param>
		/// <param name="FechaCrea"></param>
		/// <param name="Activo"></param>
		/// <param name="Total"></param>
		/// <param name="PadreCodigo"></param>
		public void Create(long Codigo, string Campo, string Cuenta1, string NombreCuenta1, string Nit2, string NombreTercero2, decimal? Valor3, string Cuenta4, string NombreCuenta4, string Cuenta5, string NombreCuenta5, string Nit6, string NombreTercero6, decimal? Valor7, string Cuenta8, string NombreCuenta8, DateTime? FechaCrea, bool? Activo, bool? Total, long? PadreCodigo,string module, Sinapsys.Datos.SQL datosTransaccion=null)
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

				paramlist.AddWithValue("@Codigo",Codigo);
				if (Campo !=null)
				{
					paramlist.AddWithValue("@Campo",Campo);
				}
				if (Cuenta1 !=null)
				{
					paramlist.AddWithValue("@Cuenta1",Cuenta1);
				}
				if (NombreCuenta1 !=null)
				{
					paramlist.AddWithValue("@NombreCuenta1",NombreCuenta1);
				}
				if (Nit2 !=null)
				{
					paramlist.AddWithValue("@Nit2",Nit2);
				}
				if (NombreTercero2 !=null)
				{
					paramlist.AddWithValue("@NombreTercero2",NombreTercero2);
				}
				if (Valor3 !=null)
				{
					paramlist.AddWithValue("@Valor3",Valor3);
				}
				if (Cuenta4 !=null)
				{
					paramlist.AddWithValue("@Cuenta4",Cuenta4);
				}
				if (NombreCuenta4 !=null)
				{
					paramlist.AddWithValue("@NombreCuenta4",NombreCuenta4);
				}
				if (Cuenta5 !=null)
				{
					paramlist.AddWithValue("@Cuenta5",Cuenta5);
				}
				if (NombreCuenta5 !=null)
				{
					paramlist.AddWithValue("@NombreCuenta5",NombreCuenta5);
				}
				if (Nit6 !=null)
				{
					paramlist.AddWithValue("@Nit6",Nit6);
				}
				if (NombreTercero6 !=null)
				{
					paramlist.AddWithValue("@NombreTercero6",NombreTercero6);
				}
				if (Valor7 !=null)
				{
					paramlist.AddWithValue("@Valor7",Valor7);
				}
				if (Cuenta8 !=null)
				{
					paramlist.AddWithValue("@Cuenta8",Cuenta8);
				}
				if (NombreCuenta8 !=null)
				{
					paramlist.AddWithValue("@NombreCuenta8",NombreCuenta8);
				}
				if (FechaCrea !=null)
				{
					paramlist.AddWithValue("@FechaCrea",FechaCrea);
				}
				if (Activo !=null)
				{
					paramlist.AddWithValue("@Activo",Activo);
				}
				if (Total !=null)
				{
					paramlist.AddWithValue("@Total",Total);
				}
				if (PadreCodigo !=null)
				{
					paramlist.AddWithValue("@PadreCodigo",PadreCodigo);
				}
				LocalDataProvider.EjecutarProcedimiento("dbo.RutasCuentaGastosCreate", paramlist, disconnect, out nullExit, DataProvider.TiempoEspera);
			}
			catch (Exception ex)
			{
				Utilidades.LogErrores(ex.Message + (ex.InnerException != null ? ex.InnerException.Message : ""), DataProvider.AplicacionNombre);
				throw ex;
			}
		}

		/// <summary>
		/// Updates one record into RutasCuentaGastos by passing all fields
		/// </summary>
		/// <param name="Codigo"></param>
		/// <param name="Campo"></param>
		/// <param name="Cuenta1"></param>
		/// <param name="NombreCuenta1"></param>
		/// <param name="Nit2"></param>
		/// <param name="NombreTercero2"></param>
		/// <param name="Valor3"></param>
		/// <param name="Cuenta4"></param>
		/// <param name="NombreCuenta4"></param>
		/// <param name="Cuenta5"></param>
		/// <param name="NombreCuenta5"></param>
		/// <param name="Nit6"></param>
		/// <param name="NombreTercero6"></param>
		/// <param name="Valor7"></param>
		/// <param name="Cuenta8"></param>
		/// <param name="NombreCuenta8"></param>
		/// <param name="FechaCrea"></param>
		/// <param name="Activo"></param>
		/// <param name="Total"></param>
		/// <param name="PadreCodigo"></param>
		public void Update(long Codigo, string Campo, string Cuenta1, string NombreCuenta1, string Nit2, string NombreTercero2, decimal? Valor3, string Cuenta4, string NombreCuenta4, string Cuenta5, string NombreCuenta5, string Nit6, string NombreTercero6, decimal? Valor7, string Cuenta8, string NombreCuenta8, DateTime? FechaCrea, bool? Activo, bool? Total, long? PadreCodigo,string module, Sinapsys.Datos.SQL datosTransaccion=null)
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
				paramlist.AddWithValue("@Codigo",Codigo);
				if (Campo !=null)
				{
					paramlist.AddWithValue("@Campo",Campo);
				}
				if (Cuenta1 !=null)
				{
					paramlist.AddWithValue("@Cuenta1",Cuenta1);
				}
				if (NombreCuenta1 !=null)
				{
					paramlist.AddWithValue("@NombreCuenta1",NombreCuenta1);
				}
				if (Nit2 !=null)
				{
					paramlist.AddWithValue("@Nit2",Nit2);
				}
				if (NombreTercero2 !=null)
				{
					paramlist.AddWithValue("@NombreTercero2",NombreTercero2);
				}
				if (Valor3 !=null)
				{
					paramlist.AddWithValue("@Valor3",Valor3);
				}
				if (Cuenta4 !=null)
				{
					paramlist.AddWithValue("@Cuenta4",Cuenta4);
				}
				if (NombreCuenta4 !=null)
				{
					paramlist.AddWithValue("@NombreCuenta4",NombreCuenta4);
				}
				if (Cuenta5 !=null)
				{
					paramlist.AddWithValue("@Cuenta5",Cuenta5);
				}
				if (NombreCuenta5 !=null)
				{
					paramlist.AddWithValue("@NombreCuenta5",NombreCuenta5);
				}
				if (Nit6 !=null)
				{
					paramlist.AddWithValue("@Nit6",Nit6);
				}
				if (NombreTercero6 !=null)
				{
					paramlist.AddWithValue("@NombreTercero6",NombreTercero6);
				}
				if (Valor7 !=null)
				{
					paramlist.AddWithValue("@Valor7",Valor7);
				}
				if (Cuenta8 !=null)
				{
					paramlist.AddWithValue("@Cuenta8",Cuenta8);
				}
				if (NombreCuenta8 !=null)
				{
					paramlist.AddWithValue("@NombreCuenta8",NombreCuenta8);
				}
				if (FechaCrea !=null)
				{
					paramlist.AddWithValue("@FechaCrea",FechaCrea);
				}
				if (Activo !=null)
				{
					paramlist.AddWithValue("@Activo",Activo);
				}
				if (Total !=null)
				{
					paramlist.AddWithValue("@Total",Total);
				}
				if (PadreCodigo !=null)
				{
					paramlist.AddWithValue("@PadreCodigo",PadreCodigo);
				}
				LocalDataProvider.EjecutarProcedimiento("dbo.RutasCuentaGastosUpdate", paramlist, disconnect, out nullExit, DataProvider.TiempoEspera);
			}
			catch (Exception ex)
			{
				Utilidades.LogErrores(ex.Message + (ex.InnerException != null ? ex.InnerException.Message : ""), DataProvider.AplicacionNombre);
				throw ex;
			}
		}

		/// <summary>
		/// Deletes one record from RutasCuentaGastos by passing all key fields
		/// </summary>
		/// <param name="Codigo"></param>
		public void Delete(long Codigo,string module, Sinapsys.Datos.SQL datosTransaccion=null)
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
				paramlist.AddWithValue("@Codigo",Codigo);
				LocalDataProvider.EjecutarProcedimiento("dbo.RutasCuentaGastosDelete", paramlist, disconnect, out nullExit, DataProvider.TiempoEspera);
			}
			catch (Exception ex)
			{
				Utilidades.LogErrores(ex.Message + (ex.InnerException != null ? ex.InnerException.Message : ""), DataProvider.AplicacionNombre);
				throw ex;
			}
		}

		/// <summary>
		/// Gets one record from RutasCuentaGastos passing all key fields
		/// </summary>
		/// <param name="Codigo"></param>
		/// <returns>A DataTable object containing the data</returns>
		public DataTable Get(long Codigo)
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
				paramlist.AddWithValue("@Codigo",Codigo);
				return LocalDataProvider.EjecutarProcedimiento("dbo.RutasCuentaGastosGet", paramlist, disconnect, out nullExit, DataProvider.TiempoEspera);

			}
			catch (Exception ex)
			{
				Utilidades.LogErrores(ex.Message + (ex.InnerException != null ? ex.InnerException.Message : ""), DataProvider.AplicacionNombre);
				throw ex;
			}
		}

		/// <summary>
		/// Gets all records from RutasCuentaGastos
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
				return LocalDataProvider.EjecutarProcedimiento("dbo.RutasCuentaGastosGetAll", paramlist, disconnect, out nullExit, DataProvider.TiempoEspera);
			}
			catch (Exception ex)
			{
				Utilidades.LogErrores(ex.Message + (ex.InnerException != null ? ex.InnerException.Message : ""), DataProvider.AplicacionNombre);
				throw ex;
			}
		}

		/// <summary>
		/// Gets all records from RutasCuentaGastos applying filter and sort criteria
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

				return LocalDataProvider.EjecutarProcedimiento("dbo.RutasCuentaGastosGetFilter", paramlist, disconnect, out nullExit, DataProvider.TiempoEspera);
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
		/// Gets the numbers of records from RutasCuentaGastos applying filter and sort criteria
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

				return (int) LocalDataProvider.EjecutarProcedimiento("dbo.RutasCuentaGastosGetFilter", paramlist, disconnect, out nullExit, DataProvider.TiempoEspera).Rows[0][0];
			}
			catch (Exception ex)
			{
				Utilidades.LogErrores(ex.Message + (ex.InnerException != null ? ex.InnerException.Message : ""), DataProvider.AplicacionNombre);
				throw ex;
			}
		}

	}
}
