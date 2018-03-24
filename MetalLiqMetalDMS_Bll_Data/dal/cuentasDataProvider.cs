using System;
using System.Data;
using System.Data.Common;
using Sinapsys.Datos;
using LiqMetalDMS_Bll_Data.Security;
using System.Runtime.Serialization;

namespace LiqMetalDMS_Bll_Data
{
	/// <summary>
	/// Data Access Layer class for cuentas object
	/// </summary>
	/// <remarks>
	/// This class is a Singleton
	/// </remarks>
	public partial class cuentasDataProvider
	{
		/// <summary>
		/// Internal member for create this singleton
		/// </summary>
		private static cuentasDataProvider MySingleObj = null;

		/// <summary>
		/// Protected constructor to avoid access this singleton other way than calling the Instance method
		/// </summary>
		public cuentasDataProvider()
		{

		}

		/// <summary>
		/// Instance accessor for this singleton
		/// </summary>
		public static cuentasDataProvider Instance
		{
			get
			{
				if (MySingleObj == null)
				{
					MySingleObj = new cuentasDataProvider();
				}

				return MySingleObj;
			}
		}

		/// <summary>
		/// Creates a new record into cuentas by passing all fields
		/// </summary>
		/// <param name="descripcion"></param>
		/// <param name="afe"></param>
		/// <param name="cco"></param>
		/// <param name="ter"></param>
		/// <param name="doc"></param>
		/// <param name="aju"></param>
		/// <param name="bas"></param>
		/// <param name="tei"></param>
		/// <param name="partida"></param>
		/// <param name="contrapartida"></param>
		/// <param name="naturaleza"></param>
		/// <param name="doc_inf"></param>
		/// <param name="doc_sup"></param>
		/// <param name="solo_interface"></param>
		/// <param name="maneja_medios"></param>
		/// <param name="literal_mm"></param>
		/// <param name="codigo_mm"></param>
		/// <param name="subcodigo_mm"></param>
		/// <param name="porcentaje"></param>
		/// <param name="ctas_dos_mm"></param>
		/// <param name="exportado"></param>
		/// <param name="cta_reversion"></param>
		/// <param name="centro_me"></param>
		/// <param name="diferencia_cambio"></param>
		/// <param name="norma"></param>
		/// <param name="inactiva"></param>
		/// <param name="descripcion_niif"></param>
		/// <param name="cuenta_niif"></param>
		/// <param name="clasificacion_niif"></param>
		/// <returns>int that contents the id value</returns>
		public int Create(int id, string cuenta, string descripcion, bool afe, bool cco, bool ter, bool doc, bool aju, bool bas, bool tei, string partida, string contrapartida, double? naturaleza, double? doc_inf, double? doc_sup, bool solo_interface, string maneja_medios, string literal_mm, string codigo_mm, string subcodigo_mm, double? porcentaje, string ctas_dos_mm, string exportado, string cta_reversion, int? centro_me, char? diferencia_cambio, char norma, char inactiva, string descripcion_niif, string cuenta_niif, char? clasificacion_niif,string module, Sinapsys.Datos.SQL datosTransaccion=null)
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

				paramlist.AddWithValue("@id",id);
				paramlist.AddWithValue("@cuenta",cuenta);
				if (descripcion !=null)
				{
					paramlist.AddWithValue("@descripcion",descripcion);
				}
				paramlist.AddWithValue("@afe",afe);
				paramlist.AddWithValue("@cco",cco);
				paramlist.AddWithValue("@ter",ter);
				paramlist.AddWithValue("@doc",doc);
				paramlist.AddWithValue("@aju",aju);
				paramlist.AddWithValue("@bas",bas);
				paramlist.AddWithValue("@tei",tei);
				if (partida !=null)
				{
					paramlist.AddWithValue("@partida",partida);
				}
				if (contrapartida !=null)
				{
					paramlist.AddWithValue("@contrapartida",contrapartida);
				}
				if (naturaleza !=null)
				{
					paramlist.AddWithValue("@naturaleza",naturaleza);
				}
				if (doc_inf !=null)
				{
					paramlist.AddWithValue("@doc_inf",doc_inf);
				}
				if (doc_sup !=null)
				{
					paramlist.AddWithValue("@doc_sup",doc_sup);
				}
				paramlist.AddWithValue("@solo_interface",solo_interface);
				if (maneja_medios !=null)
				{
					paramlist.AddWithValue("@maneja_medios",maneja_medios);
				}
				if (literal_mm !=null)
				{
					paramlist.AddWithValue("@literal_mm",literal_mm);
				}
				if (codigo_mm !=null)
				{
					paramlist.AddWithValue("@codigo_mm",codigo_mm);
				}
				if (subcodigo_mm !=null)
				{
					paramlist.AddWithValue("@subcodigo_mm",subcodigo_mm);
				}
				if (porcentaje !=null)
				{
					paramlist.AddWithValue("@porcentaje",porcentaje);
				}
				if (ctas_dos_mm !=null)
				{
					paramlist.AddWithValue("@ctas_dos_mm",ctas_dos_mm);
				}
				if (exportado !=null)
				{
					paramlist.AddWithValue("@exportado",exportado);
				}
				if (cta_reversion !=null)
				{
					paramlist.AddWithValue("@cta_reversion",cta_reversion);
				}
				if (centro_me !=null)
				{
					paramlist.AddWithValue("@centro_me",centro_me);
				}
				if (diferencia_cambio !=null)
				{
					paramlist.AddWithValue("@diferencia_cambio",diferencia_cambio);
				}
				paramlist.AddWithValue("@norma",norma);
				paramlist.AddWithValue("@inactiva",inactiva);
				if (descripcion_niif !=null)
				{
					paramlist.AddWithValue("@descripcion_niif",descripcion_niif);
				}
				if (cuenta_niif !=null)
				{
					paramlist.AddWithValue("@cuenta_niif",cuenta_niif);
				}
				if (clasificacion_niif !=null)
				{
					paramlist.AddWithValue("@clasificacion_niif",clasificacion_niif);
				}
				// Execute the query and return the new identity value
				int returnValue = Convert.ToInt32(LocalDataProvider.EjecutarProcedimiento("dbo.cuentasCreate", paramlist, disconnect, out nullExit, DataProvider.TiempoEspera).Rows[0][0]);

				return returnValue;
			}
			catch (Exception ex)
			{
				Utilidades.LogErrores(ex.Message + (ex.InnerException != null ? ex.InnerException.Message : ""), DataProvider.AplicacionNombre);
				throw ex;
			}
		}

		/// <summary>
		/// Updates one record into cuentas by passing all fields
		/// </summary>
		/// <param name="id"></param>
		/// <param name="cuenta"></param>
		/// <param name="descripcion"></param>
		/// <param name="afe"></param>
		/// <param name="cco"></param>
		/// <param name="ter"></param>
		/// <param name="doc"></param>
		/// <param name="aju"></param>
		/// <param name="bas"></param>
		/// <param name="tei"></param>
		/// <param name="partida"></param>
		/// <param name="contrapartida"></param>
		/// <param name="naturaleza"></param>
		/// <param name="doc_inf"></param>
		/// <param name="doc_sup"></param>
		/// <param name="solo_interface"></param>
		/// <param name="maneja_medios"></param>
		/// <param name="literal_mm"></param>
		/// <param name="codigo_mm"></param>
		/// <param name="subcodigo_mm"></param>
		/// <param name="porcentaje"></param>
		/// <param name="ctas_dos_mm"></param>
		/// <param name="exportado"></param>
		/// <param name="cta_reversion"></param>
		/// <param name="centro_me"></param>
		/// <param name="diferencia_cambio"></param>
		/// <param name="norma"></param>
		/// <param name="inactiva"></param>
		/// <param name="descripcion_niif"></param>
		/// <param name="cuenta_niif"></param>
		/// <param name="clasificacion_niif"></param>
		public void Update(int id, string cuenta, string descripcion, bool afe, bool cco, bool ter, bool doc, bool aju, bool bas, bool tei, string partida, string contrapartida, double? naturaleza, double? doc_inf, double? doc_sup, bool solo_interface, string maneja_medios, string literal_mm, string codigo_mm, string subcodigo_mm, double? porcentaje, string ctas_dos_mm, string exportado, string cta_reversion, int? centro_me, char? diferencia_cambio, char norma, char inactiva, string descripcion_niif, string cuenta_niif, char? clasificacion_niif,string module, Sinapsys.Datos.SQL datosTransaccion=null)
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
				paramlist.AddWithValue("@id",id);
				paramlist.AddWithValue("@cuenta",cuenta);
				if (descripcion !=null)
				{
					paramlist.AddWithValue("@descripcion",descripcion);
				}
				paramlist.AddWithValue("@afe",afe);
				paramlist.AddWithValue("@cco",cco);
				paramlist.AddWithValue("@ter",ter);
				paramlist.AddWithValue("@doc",doc);
				paramlist.AddWithValue("@aju",aju);
				paramlist.AddWithValue("@bas",bas);
				paramlist.AddWithValue("@tei",tei);
				if (partida !=null)
				{
					paramlist.AddWithValue("@partida",partida);
				}
				if (contrapartida !=null)
				{
					paramlist.AddWithValue("@contrapartida",contrapartida);
				}
				if (naturaleza !=null)
				{
					paramlist.AddWithValue("@naturaleza",naturaleza);
				}
				if (doc_inf !=null)
				{
					paramlist.AddWithValue("@doc_inf",doc_inf);
				}
				if (doc_sup !=null)
				{
					paramlist.AddWithValue("@doc_sup",doc_sup);
				}
				paramlist.AddWithValue("@solo_interface",solo_interface);
				if (maneja_medios !=null)
				{
					paramlist.AddWithValue("@maneja_medios",maneja_medios);
				}
				if (literal_mm !=null)
				{
					paramlist.AddWithValue("@literal_mm",literal_mm);
				}
				if (codigo_mm !=null)
				{
					paramlist.AddWithValue("@codigo_mm",codigo_mm);
				}
				if (subcodigo_mm !=null)
				{
					paramlist.AddWithValue("@subcodigo_mm",subcodigo_mm);
				}
				if (porcentaje !=null)
				{
					paramlist.AddWithValue("@porcentaje",porcentaje);
				}
				if (ctas_dos_mm !=null)
				{
					paramlist.AddWithValue("@ctas_dos_mm",ctas_dos_mm);
				}
				if (exportado !=null)
				{
					paramlist.AddWithValue("@exportado",exportado);
				}
				if (cta_reversion !=null)
				{
					paramlist.AddWithValue("@cta_reversion",cta_reversion);
				}
				if (centro_me !=null)
				{
					paramlist.AddWithValue("@centro_me",centro_me);
				}
				if (diferencia_cambio !=null)
				{
					paramlist.AddWithValue("@diferencia_cambio",diferencia_cambio);
				}
				paramlist.AddWithValue("@norma",norma);
				paramlist.AddWithValue("@inactiva",inactiva);
				if (descripcion_niif !=null)
				{
					paramlist.AddWithValue("@descripcion_niif",descripcion_niif);
				}
				if (cuenta_niif !=null)
				{
					paramlist.AddWithValue("@cuenta_niif",cuenta_niif);
				}
				if (clasificacion_niif !=null)
				{
					paramlist.AddWithValue("@clasificacion_niif",clasificacion_niif);
				}
				LocalDataProvider.EjecutarProcedimiento("dbo.cuentasUpdate", paramlist, disconnect, out nullExit, DataProvider.TiempoEspera);
			}
			catch (Exception ex)
			{
				Utilidades.LogErrores(ex.Message + (ex.InnerException != null ? ex.InnerException.Message : ""), DataProvider.AplicacionNombre);
				throw ex;
			}
		}

		/// <summary>
		/// Deletes one record from cuentas by passing all key fields
		/// </summary>
		/// <param name="id"></param>
		/// <param name="cuenta"></param>
		public void Delete(int id, string cuenta,string module, Sinapsys.Datos.SQL datosTransaccion=null)
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
				paramlist.AddWithValue("@id",id);
				paramlist.AddWithValue("@cuenta",cuenta);
				LocalDataProvider.EjecutarProcedimiento("dbo.cuentasDelete", paramlist, disconnect, out nullExit, DataProvider.TiempoEspera);
			}
			catch (Exception ex)
			{
				Utilidades.LogErrores(ex.Message + (ex.InnerException != null ? ex.InnerException.Message : ""), DataProvider.AplicacionNombre);
				throw ex;
			}
		}

		/// <summary>
		/// Gets one record from cuentas passing all key fields
		/// </summary>
		/// <param name="id"></param>
		/// <param name="cuenta"></param>
		/// <returns>A DataTable object containing the data</returns>
		public DataTable Get(int id, string cuenta)
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
				paramlist.AddWithValue("@id",id);
				paramlist.AddWithValue("@cuenta",cuenta);
				return LocalDataProvider.EjecutarProcedimiento("dbo.cuentasGet", paramlist, disconnect, out nullExit, DataProvider.TiempoEspera);

			}
			catch (Exception ex)
			{
				Utilidades.LogErrores(ex.Message + (ex.InnerException != null ? ex.InnerException.Message : ""), DataProvider.AplicacionNombre);
				throw ex;
			}
		}

		/// <summary>
		/// Gets all records from cuentas
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
				return LocalDataProvider.EjecutarProcedimiento("dbo.cuentasGetAll", paramlist, disconnect, out nullExit, DataProvider.TiempoEspera);
			}
			catch (Exception ex)
			{
				Utilidades.LogErrores(ex.Message + (ex.InnerException != null ? ex.InnerException.Message : ""), DataProvider.AplicacionNombre);
				throw ex;
			}
		}

		/// <summary>
		/// Gets all records from cuentas applying filter and sort criteria
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

				return LocalDataProvider.EjecutarProcedimiento("dbo.cuentasGetFilter", paramlist, disconnect, out nullExit, DataProvider.TiempoEspera);
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
		/// Gets the numbers of records from cuentas applying filter and sort criteria
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

				return (int) LocalDataProvider.EjecutarProcedimiento("dbo.cuentasGetFilter", paramlist, disconnect, out nullExit, DataProvider.TiempoEspera).Rows[0][0];
			}
			catch (Exception ex)
			{
				Utilidades.LogErrores(ex.Message + (ex.InnerException != null ? ex.InnerException.Message : ""), DataProvider.AplicacionNombre);
				throw ex;
			}
		}

	}
}
