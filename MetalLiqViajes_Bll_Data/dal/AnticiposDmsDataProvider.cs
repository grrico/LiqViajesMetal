using System;
using System.Data;
using System.Data.Common;
using Sinapsys.Datos;
using LiqViajes_Bll_Data.Security;
using System.Runtime.Serialization;

namespace LiqViajes_Bll_Data
{
	/// <summary>
	/// Data Access Layer class for AnticiposDms object
	/// </summary>
	/// <remarks>
	/// This class is a Singleton
	/// </remarks>
	public partial class AnticiposDmsDataProvider
	{
		/// <summary>
		/// Internal member for create this singleton
		/// </summary>
		private static AnticiposDmsDataProvider MySingleObj = null;

		/// <summary>
		/// Protected constructor to avoid access this singleton other way than calling the Instance method
		/// </summary>
		public AnticiposDmsDataProvider()
		{

		}

		/// <summary>
		/// Instance accessor for this singleton
		/// </summary>
		public static AnticiposDmsDataProvider Instance
		{
			get
			{
				if (MySingleObj == null)
				{
					MySingleObj = new AnticiposDmsDataProvider();
				}

				return MySingleObj;
			}
		}

		/// <summary>
		/// Creates a new record into AnticiposDms by passing all fields
		/// </summary>
		/// <param name="Dms_Tipo"></param>
		/// <param name="Dms_Numero"></param>
		/// <param name="Dms_Modelo"></param>
		/// <param name="Dms_Sw"></param>
		/// <param name="Dms_Placa"></param>
		/// <param name="Dms_lngIdRegistroViaje"></param>
		/// <param name="Dms_lngIdRegistroViajeTramo"></param>
		/// <param name="Dms_Nit"></param>
		/// <param name="Dms_Fecha"></param>
		/// <param name="Dms_ValorTotal"></param>
		/// <param name="Dms_ValorAplicado"></param>
		/// <param name="Dms_ValorAnticipo"></param>
		/// <param name="Dms_Chk"></param>
		/// <param name="Dms_Nota"></param>
		/// <param name="Dms_Documento"></param>
		/// <param name="Dms_CodBanco"></param>
		/// <param name="Dms_NombreBanco"></param>
		/// <param name="Dms_DescripcionModelo"></param>
		/// <param name="Dms_Cuenta1"></param>
		/// <param name="Dms_Cuenta2"></param>
		/// <param name="Dms_DescripcionCta1"></param>
		/// <param name="Dms_DescripcionCta2"></param>
		/// <param name="Dms_Usuario"></param>
		/// <param name="Dms_FechaReal"></param>
		/// <param name="Dms_NombreTercero"></param>
		public void Create(int Dms_Codigo, string Dms_Tipo, int? Dms_Numero, string Dms_Modelo, byte? Dms_Sw, string Dms_Placa, int? Dms_lngIdRegistroViaje, decimal? Dms_lngIdRegistroViajeTramo, decimal? Dms_Nit, DateTime? Dms_Fecha, decimal? Dms_ValorTotal, decimal? Dms_ValorAplicado, decimal? Dms_ValorAnticipo, int? Dms_Chk, string Dms_Nota, string Dms_Documento, double? Dms_CodBanco, string Dms_NombreBanco, string Dms_DescripcionModelo, string Dms_Cuenta1, string Dms_Cuenta2, string Dms_DescripcionCta1, string Dms_DescripcionCta2, string Dms_Usuario, DateTime? Dms_FechaReal, string Dms_NombreTercero,string module, Sinapsys.Datos.SQL datosTransaccion=null)
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

				paramlist.AddWithValue("@Dms_Codigo",Dms_Codigo);
				if (Dms_Tipo !=null)
				{
					paramlist.AddWithValue("@Dms_Tipo",Dms_Tipo);
				}
				if (Dms_Numero !=null)
				{
					paramlist.AddWithValue("@Dms_Numero",Dms_Numero);
				}
				if (Dms_Modelo !=null)
				{
					paramlist.AddWithValue("@Dms_Modelo",Dms_Modelo);
				}
				if (Dms_Sw !=null)
				{
					paramlist.AddWithValue("@Dms_Sw",Dms_Sw);
				}
				if (Dms_Placa !=null)
				{
					paramlist.AddWithValue("@Dms_Placa",Dms_Placa);
				}
				if (Dms_lngIdRegistroViaje !=null)
				{
					paramlist.AddWithValue("@Dms_lngIdRegistroViaje",Dms_lngIdRegistroViaje);
				}
				if (Dms_lngIdRegistroViajeTramo !=null)
				{
					paramlist.AddWithValue("@Dms_lngIdRegistroViajeTramo",Dms_lngIdRegistroViajeTramo);
				}
				if (Dms_Nit !=null)
				{
					paramlist.AddWithValue("@Dms_Nit",Dms_Nit);
				}
				if (Dms_Fecha !=null)
				{
					paramlist.AddWithValue("@Dms_Fecha",Dms_Fecha);
				}
				if (Dms_ValorTotal !=null)
				{
					paramlist.AddWithValue("@Dms_ValorTotal",Dms_ValorTotal);
				}
				if (Dms_ValorAplicado !=null)
				{
					paramlist.AddWithValue("@Dms_ValorAplicado",Dms_ValorAplicado);
				}
				if (Dms_ValorAnticipo !=null)
				{
					paramlist.AddWithValue("@Dms_ValorAnticipo",Dms_ValorAnticipo);
				}
				if (Dms_Chk !=null)
				{
					paramlist.AddWithValue("@Dms_Chk",Dms_Chk);
				}
				if (Dms_Nota !=null)
				{
					paramlist.AddWithValue("@Dms_Nota",Dms_Nota);
				}
				if (Dms_Documento !=null)
				{
					paramlist.AddWithValue("@Dms_Documento",Dms_Documento);
				}
				if (Dms_CodBanco !=null)
				{
					paramlist.AddWithValue("@Dms_CodBanco",Dms_CodBanco);
				}
				if (Dms_NombreBanco !=null)
				{
					paramlist.AddWithValue("@Dms_NombreBanco",Dms_NombreBanco);
				}
				if (Dms_DescripcionModelo !=null)
				{
					paramlist.AddWithValue("@Dms_DescripcionModelo",Dms_DescripcionModelo);
				}
				if (Dms_Cuenta1 !=null)
				{
					paramlist.AddWithValue("@Dms_Cuenta1",Dms_Cuenta1);
				}
				if (Dms_Cuenta2 !=null)
				{
					paramlist.AddWithValue("@Dms_Cuenta2",Dms_Cuenta2);
				}
				if (Dms_DescripcionCta1 !=null)
				{
					paramlist.AddWithValue("@Dms_DescripcionCta1",Dms_DescripcionCta1);
				}
				if (Dms_DescripcionCta2 !=null)
				{
					paramlist.AddWithValue("@Dms_DescripcionCta2",Dms_DescripcionCta2);
				}
				if (Dms_Usuario !=null)
				{
					paramlist.AddWithValue("@Dms_Usuario",Dms_Usuario);
				}
				if (Dms_FechaReal !=null)
				{
					paramlist.AddWithValue("@Dms_FechaReal",Dms_FechaReal);
				}
				if (Dms_NombreTercero !=null)
				{
					paramlist.AddWithValue("@Dms_NombreTercero",Dms_NombreTercero);
				}
				LocalDataProvider.EjecutarProcedimiento("dbo.AnticiposDmsCreate", paramlist, disconnect, out nullExit, DataProvider.TiempoEspera);
			}
			catch (Exception ex)
			{
				Utilidades.LogErrores(ex.Message + (ex.InnerException != null ? ex.InnerException.Message : ""), DataProvider.AplicacionNombre);
				throw ex;
			}
		}

		/// <summary>
		/// Updates one record into AnticiposDms by passing all fields
		/// </summary>
		/// <param name="Dms_Codigo"></param>
		/// <param name="Dms_Tipo"></param>
		/// <param name="Dms_Numero"></param>
		/// <param name="Dms_Modelo"></param>
		/// <param name="Dms_Sw"></param>
		/// <param name="Dms_Placa"></param>
		/// <param name="Dms_lngIdRegistroViaje"></param>
		/// <param name="Dms_lngIdRegistroViajeTramo"></param>
		/// <param name="Dms_Nit"></param>
		/// <param name="Dms_Fecha"></param>
		/// <param name="Dms_ValorTotal"></param>
		/// <param name="Dms_ValorAplicado"></param>
		/// <param name="Dms_ValorAnticipo"></param>
		/// <param name="Dms_Chk"></param>
		/// <param name="Dms_Nota"></param>
		/// <param name="Dms_Documento"></param>
		/// <param name="Dms_CodBanco"></param>
		/// <param name="Dms_NombreBanco"></param>
		/// <param name="Dms_DescripcionModelo"></param>
		/// <param name="Dms_Cuenta1"></param>
		/// <param name="Dms_Cuenta2"></param>
		/// <param name="Dms_DescripcionCta1"></param>
		/// <param name="Dms_DescripcionCta2"></param>
		/// <param name="Dms_Usuario"></param>
		/// <param name="Dms_FechaReal"></param>
		/// <param name="Dms_NombreTercero"></param>
		public void Update(int Dms_Codigo, string Dms_Tipo, int? Dms_Numero, string Dms_Modelo, byte? Dms_Sw, string Dms_Placa, int? Dms_lngIdRegistroViaje, decimal? Dms_lngIdRegistroViajeTramo, decimal? Dms_Nit, DateTime? Dms_Fecha, decimal? Dms_ValorTotal, decimal? Dms_ValorAplicado, decimal? Dms_ValorAnticipo, int? Dms_Chk, string Dms_Nota, string Dms_Documento, double? Dms_CodBanco, string Dms_NombreBanco, string Dms_DescripcionModelo, string Dms_Cuenta1, string Dms_Cuenta2, string Dms_DescripcionCta1, string Dms_DescripcionCta2, string Dms_Usuario, DateTime? Dms_FechaReal, string Dms_NombreTercero,string module, Sinapsys.Datos.SQL datosTransaccion=null)
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
				paramlist.AddWithValue("@Dms_Codigo",Dms_Codigo);
				if (Dms_Tipo !=null)
				{
					paramlist.AddWithValue("@Dms_Tipo",Dms_Tipo);
				}
				if (Dms_Numero !=null)
				{
					paramlist.AddWithValue("@Dms_Numero",Dms_Numero);
				}
				if (Dms_Modelo !=null)
				{
					paramlist.AddWithValue("@Dms_Modelo",Dms_Modelo);
				}
				if (Dms_Sw !=null)
				{
					paramlist.AddWithValue("@Dms_Sw",Dms_Sw);
				}
				if (Dms_Placa !=null)
				{
					paramlist.AddWithValue("@Dms_Placa",Dms_Placa);
				}
				if (Dms_lngIdRegistroViaje !=null)
				{
					paramlist.AddWithValue("@Dms_lngIdRegistroViaje",Dms_lngIdRegistroViaje);
				}
				if (Dms_lngIdRegistroViajeTramo !=null)
				{
					paramlist.AddWithValue("@Dms_lngIdRegistroViajeTramo",Dms_lngIdRegistroViajeTramo);
				}
				if (Dms_Nit !=null)
				{
					paramlist.AddWithValue("@Dms_Nit",Dms_Nit);
				}
				if (Dms_Fecha !=null)
				{
					paramlist.AddWithValue("@Dms_Fecha",Dms_Fecha);
				}
				if (Dms_ValorTotal !=null)
				{
					paramlist.AddWithValue("@Dms_ValorTotal",Dms_ValorTotal);
				}
				if (Dms_ValorAplicado !=null)
				{
					paramlist.AddWithValue("@Dms_ValorAplicado",Dms_ValorAplicado);
				}
				if (Dms_ValorAnticipo !=null)
				{
					paramlist.AddWithValue("@Dms_ValorAnticipo",Dms_ValorAnticipo);
				}
				if (Dms_Chk !=null)
				{
					paramlist.AddWithValue("@Dms_Chk",Dms_Chk);
				}
				if (Dms_Nota !=null)
				{
					paramlist.AddWithValue("@Dms_Nota",Dms_Nota);
				}
				if (Dms_Documento !=null)
				{
					paramlist.AddWithValue("@Dms_Documento",Dms_Documento);
				}
				if (Dms_CodBanco !=null)
				{
					paramlist.AddWithValue("@Dms_CodBanco",Dms_CodBanco);
				}
				if (Dms_NombreBanco !=null)
				{
					paramlist.AddWithValue("@Dms_NombreBanco",Dms_NombreBanco);
				}
				if (Dms_DescripcionModelo !=null)
				{
					paramlist.AddWithValue("@Dms_DescripcionModelo",Dms_DescripcionModelo);
				}
				if (Dms_Cuenta1 !=null)
				{
					paramlist.AddWithValue("@Dms_Cuenta1",Dms_Cuenta1);
				}
				if (Dms_Cuenta2 !=null)
				{
					paramlist.AddWithValue("@Dms_Cuenta2",Dms_Cuenta2);
				}
				if (Dms_DescripcionCta1 !=null)
				{
					paramlist.AddWithValue("@Dms_DescripcionCta1",Dms_DescripcionCta1);
				}
				if (Dms_DescripcionCta2 !=null)
				{
					paramlist.AddWithValue("@Dms_DescripcionCta2",Dms_DescripcionCta2);
				}
				if (Dms_Usuario !=null)
				{
					paramlist.AddWithValue("@Dms_Usuario",Dms_Usuario);
				}
				if (Dms_FechaReal !=null)
				{
					paramlist.AddWithValue("@Dms_FechaReal",Dms_FechaReal);
				}
				if (Dms_NombreTercero !=null)
				{
					paramlist.AddWithValue("@Dms_NombreTercero",Dms_NombreTercero);
				}
				LocalDataProvider.EjecutarProcedimiento("dbo.AnticiposDmsUpdate", paramlist, disconnect, out nullExit, DataProvider.TiempoEspera);
			}
			catch (Exception ex)
			{
				Utilidades.LogErrores(ex.Message + (ex.InnerException != null ? ex.InnerException.Message : ""), DataProvider.AplicacionNombre);
				throw ex;
			}
		}

		/// <summary>
		/// Deletes one record from AnticiposDms by passing all key fields
		/// </summary>
		/// <param name="Dms_Codigo"></param>
		public void Delete(int Dms_Codigo,string module, Sinapsys.Datos.SQL datosTransaccion=null)
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
				paramlist.AddWithValue("@Dms_Codigo",Dms_Codigo);
				LocalDataProvider.EjecutarProcedimiento("dbo.AnticiposDmsDelete", paramlist, disconnect, out nullExit, DataProvider.TiempoEspera);
			}
			catch (Exception ex)
			{
				Utilidades.LogErrores(ex.Message + (ex.InnerException != null ? ex.InnerException.Message : ""), DataProvider.AplicacionNombre);
				throw ex;
			}
		}

		/// <summary>
		/// Gets one record from AnticiposDms passing all key fields
		/// </summary>
		/// <param name="Dms_Codigo"></param>
		/// <returns>A DataTable object containing the data</returns>
		public DataTable Get(int Dms_Codigo)
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
				paramlist.AddWithValue("@Dms_Codigo",Dms_Codigo);
				return LocalDataProvider.EjecutarProcedimiento("dbo.AnticiposDmsGet", paramlist, disconnect, out nullExit, DataProvider.TiempoEspera);

			}
			catch (Exception ex)
			{
				Utilidades.LogErrores(ex.Message + (ex.InnerException != null ? ex.InnerException.Message : ""), DataProvider.AplicacionNombre);
				throw ex;
			}
		}

		/// <summary>
		/// Gets all records from AnticiposDms
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
				return LocalDataProvider.EjecutarProcedimiento("dbo.AnticiposDmsGetAll", paramlist, disconnect, out nullExit, DataProvider.TiempoEspera);
			}
			catch (Exception ex)
			{
				Utilidades.LogErrores(ex.Message + (ex.InnerException != null ? ex.InnerException.Message : ""), DataProvider.AplicacionNombre);
				throw ex;
			}
		}

		/// <summary>
		/// Gets all records from AnticiposDms applying filter and sort criteria
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

				return LocalDataProvider.EjecutarProcedimiento("dbo.AnticiposDmsGetFilter", paramlist, disconnect, out nullExit, DataProvider.TiempoEspera);
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
		/// Gets the numbers of records from AnticiposDms applying filter and sort criteria
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

				return (int) LocalDataProvider.EjecutarProcedimiento("dbo.AnticiposDmsGetFilter", paramlist, disconnect, out nullExit, DataProvider.TiempoEspera).Rows[0][0];
			}
			catch (Exception ex)
			{
				Utilidades.LogErrores(ex.Message + (ex.InnerException != null ? ex.InnerException.Message : ""), DataProvider.AplicacionNombre);
				throw ex;
			}
		}

	}
}
