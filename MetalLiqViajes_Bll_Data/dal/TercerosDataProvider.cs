using System;
using System.Data;
using System.Data.Common;
using Sinapsys.Datos;
using LiqViajes_Bll_Data.Security;
using System.Runtime.Serialization;

namespace LiqViajes_Bll_Data
{
	/// <summary>
	/// Data Access Layer class for Terceros object
	/// </summary>
	/// <remarks>
	/// This class is a Singleton
	/// </remarks>
	public partial class TercerosDataProvider
	{
		/// <summary>
		/// Internal member for create this singleton
		/// </summary>
		private static TercerosDataProvider MySingleObj = null;

		/// <summary>
		/// Protected constructor to avoid access this singleton other way than calling the Instance method
		/// </summary>
		public TercerosDataProvider()
		{

		}

		/// <summary>
		/// Instance accessor for this singleton
		/// </summary>
		public static TercerosDataProvider Instance
		{
			get
			{
				if (MySingleObj == null)
				{
					MySingleObj = new TercerosDataProvider();
				}

				return MySingleObj;
			}
		}

		/// <summary>
		/// Creates a new record into Terceros by passing all fields
		/// </summary>
		/// <param name="Identificacion"></param>
		/// <param name="TipoIdentificacion"></param>
		/// <param name="Digito"></param>
		/// <param name="NombreCompleto"></param>
		/// <param name="Concepto_3"></param>
		/// <param name="CentroCosto"></param>
		/// <param name="Direccion"></param>
		/// <param name="NombreCiudad"></param>
		/// <param name="Pais"></param>
		/// <param name="Telefono1"></param>
		/// <param name="Telefono2"></param>
		/// <param name="Telefono3"></param>
		/// <param name="ApartadoAreo"></param>
		public void Create(decimal NitConductor, long? Identificacion, char? TipoIdentificacion, byte? Digito, string NombreCompleto, string Concepto_3, int? CentroCosto, string Direccion, string NombreCiudad, string Pais, string Telefono1, string Telefono2, string Telefono3, string ApartadoAreo,string module, Sinapsys.Datos.SQL datosTransaccion=null)
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

				paramlist.AddWithValue("@NitConductor",NitConductor);
				if (Identificacion !=null)
				{
					paramlist.AddWithValue("@Identificacion",Identificacion);
				}
				if (TipoIdentificacion !=null)
				{
					paramlist.AddWithValue("@TipoIdentificacion",TipoIdentificacion);
				}
				if (Digito !=null)
				{
					paramlist.AddWithValue("@Digito",Digito);
				}
				if (NombreCompleto !=null)
				{
					paramlist.AddWithValue("@NombreCompleto",NombreCompleto);
				}
				if (Concepto_3 !=null)
				{
					paramlist.AddWithValue("@Concepto_3",Concepto_3);
				}
				if (CentroCosto !=null)
				{
					paramlist.AddWithValue("@CentroCosto",CentroCosto);
				}
				if (Direccion !=null)
				{
					paramlist.AddWithValue("@Direccion",Direccion);
				}
				if (NombreCiudad !=null)
				{
					paramlist.AddWithValue("@NombreCiudad",NombreCiudad);
				}
				if (Pais !=null)
				{
					paramlist.AddWithValue("@Pais",Pais);
				}
				if (Telefono1 !=null)
				{
					paramlist.AddWithValue("@Telefono1",Telefono1);
				}
				if (Telefono2 !=null)
				{
					paramlist.AddWithValue("@Telefono2",Telefono2);
				}
				if (Telefono3 !=null)
				{
					paramlist.AddWithValue("@Telefono3",Telefono3);
				}
				if (ApartadoAreo !=null)
				{
					paramlist.AddWithValue("@ApartadoAreo",ApartadoAreo);
				}
				LocalDataProvider.EjecutarProcedimiento("dbo.TercerosCreate", paramlist, disconnect, out nullExit, DataProvider.TiempoEspera);
			}
			catch (Exception ex)
			{
				Utilidades.LogErrores(ex.Message + (ex.InnerException != null ? ex.InnerException.Message : ""), DataProvider.AplicacionNombre);
				throw ex;
			}
		}

		/// <summary>
		/// Updates one record into Terceros by passing all fields
		/// </summary>
		/// <param name="Identificacion"></param>
		/// <param name="TipoIdentificacion"></param>
		/// <param name="Digito"></param>
		/// <param name="NombreCompleto"></param>
		/// <param name="Concepto_3"></param>
		/// <param name="CentroCosto"></param>
		/// <param name="Direccion"></param>
		/// <param name="NombreCiudad"></param>
		/// <param name="Pais"></param>
		/// <param name="Telefono1"></param>
		/// <param name="Telefono2"></param>
		/// <param name="Telefono3"></param>
		/// <param name="ApartadoAreo"></param>
		/// <param name="NitConductor"></param>
		public void Update(long? Identificacion, char? TipoIdentificacion, byte? Digito, string NombreCompleto, string Concepto_3, int? CentroCosto, string Direccion, string NombreCiudad, string Pais, string Telefono1, string Telefono2, string Telefono3, string ApartadoAreo, decimal NitConductor,string module, Sinapsys.Datos.SQL datosTransaccion=null)
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
				paramlist.AddWithValue("@NitConductor",NitConductor);
				if (Identificacion !=null)
				{
					paramlist.AddWithValue("@Identificacion",Identificacion);
				}
				if (TipoIdentificacion !=null)
				{
					paramlist.AddWithValue("@TipoIdentificacion",TipoIdentificacion);
				}
				if (Digito !=null)
				{
					paramlist.AddWithValue("@Digito",Digito);
				}
				if (NombreCompleto !=null)
				{
					paramlist.AddWithValue("@NombreCompleto",NombreCompleto);
				}
				if (Concepto_3 !=null)
				{
					paramlist.AddWithValue("@Concepto_3",Concepto_3);
				}
				if (CentroCosto !=null)
				{
					paramlist.AddWithValue("@CentroCosto",CentroCosto);
				}
				if (Direccion !=null)
				{
					paramlist.AddWithValue("@Direccion",Direccion);
				}
				if (NombreCiudad !=null)
				{
					paramlist.AddWithValue("@NombreCiudad",NombreCiudad);
				}
				if (Pais !=null)
				{
					paramlist.AddWithValue("@Pais",Pais);
				}
				if (Telefono1 !=null)
				{
					paramlist.AddWithValue("@Telefono1",Telefono1);
				}
				if (Telefono2 !=null)
				{
					paramlist.AddWithValue("@Telefono2",Telefono2);
				}
				if (Telefono3 !=null)
				{
					paramlist.AddWithValue("@Telefono3",Telefono3);
				}
				if (ApartadoAreo !=null)
				{
					paramlist.AddWithValue("@ApartadoAreo",ApartadoAreo);
				}
				LocalDataProvider.EjecutarProcedimiento("dbo.TercerosUpdate", paramlist, disconnect, out nullExit, DataProvider.TiempoEspera);
			}
			catch (Exception ex)
			{
				Utilidades.LogErrores(ex.Message + (ex.InnerException != null ? ex.InnerException.Message : ""), DataProvider.AplicacionNombre);
				throw ex;
			}
		}

		/// <summary>
		/// Deletes one record from Terceros by passing all key fields
		/// </summary>
		/// <param name="NitConductor"></param>
		public void Delete(decimal NitConductor,string module, Sinapsys.Datos.SQL datosTransaccion=null)
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
				paramlist.AddWithValue("@NitConductor",NitConductor);
				LocalDataProvider.EjecutarProcedimiento("dbo.TercerosDelete", paramlist, disconnect, out nullExit, DataProvider.TiempoEspera);
			}
			catch (Exception ex)
			{
				Utilidades.LogErrores(ex.Message + (ex.InnerException != null ? ex.InnerException.Message : ""), DataProvider.AplicacionNombre);
				throw ex;
			}
		}

		/// <summary>
		/// Gets one record from Terceros passing all key fields
		/// </summary>
		/// <param name="NitConductor"></param>
		/// <returns>A DataTable object containing the data</returns>
		public DataTable Get(decimal NitConductor)
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
				paramlist.AddWithValue("@NitConductor",NitConductor);
				return LocalDataProvider.EjecutarProcedimiento("dbo.TercerosGet", paramlist, disconnect, out nullExit, DataProvider.TiempoEspera);

			}
			catch (Exception ex)
			{
				Utilidades.LogErrores(ex.Message + (ex.InnerException != null ? ex.InnerException.Message : ""), DataProvider.AplicacionNombre);
				throw ex;
			}
		}

		/// <summary>
		/// Gets all records from Terceros
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
				return LocalDataProvider.EjecutarProcedimiento("dbo.TercerosGetAll", paramlist, disconnect, out nullExit, DataProvider.TiempoEspera);
			}
			catch (Exception ex)
			{
				Utilidades.LogErrores(ex.Message + (ex.InnerException != null ? ex.InnerException.Message : ""), DataProvider.AplicacionNombre);
				throw ex;
			}
		}

		/// <summary>
		/// Gets all records from Terceros applying filter and sort criteria
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

				return LocalDataProvider.EjecutarProcedimiento("dbo.TercerosGetFilter", paramlist, disconnect, out nullExit, DataProvider.TiempoEspera);
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
		/// Gets the numbers of records from Terceros applying filter and sort criteria
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

				return (int) LocalDataProvider.EjecutarProcedimiento("dbo.TercerosGetFilter", paramlist, disconnect, out nullExit, DataProvider.TiempoEspera).Rows[0][0];
			}
			catch (Exception ex)
			{
				Utilidades.LogErrores(ex.Message + (ex.InnerException != null ? ex.InnerException.Message : ""), DataProvider.AplicacionNombre);
				throw ex;
			}
		}

	}
}
