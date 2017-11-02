using System;
using System.Data;
using System.Data.Common;
using Sinapsys.Datos;
using LiqViajes_Bll_Data.Security;
using System.Runtime.Serialization;

namespace LiqViajes_Bll_Data
{
	/// <summary>
	/// Data Access Layer class for novedades_nomina object
	/// </summary>
	/// <remarks>
	/// This class is a Singleton
	/// </remarks>
	public partial class novedades_nominaDataProvider
	{
		/// <summary>
		/// Internal member for create this singleton
		/// </summary>
		private static novedades_nominaDataProvider MySingleObj = null;

		/// <summary>
		/// Protected constructor to avoid access this singleton other way than calling the Instance method
		/// </summary>
		public novedades_nominaDataProvider()
		{

		}

		/// <summary>
		/// Instance accessor for this singleton
		/// </summary>
		public static novedades_nominaDataProvider Instance
		{
			get
			{
				if (MySingleObj == null)
				{
					MySingleObj = new novedades_nominaDataProvider();
				}

				return MySingleObj;
			}
		}

		/// <summary>
		/// Creates a new record into novedades_nomina by passing all fields
		/// </summary>
		/// <param name="concepto"></param>
		/// <param name="fecha"></param>
		/// <param name="mes"></param>
		/// <param name="ano"></param>
		/// <param name="periodo"></param>
		/// <param name="valor"></param>
		/// <param name="horas"></param>
		/// <param name="dias"></param>
		/// <param name="turno"></param>
		/// <param name="estado"></param>
		/// <param name="nro_presta"></param>
		/// <param name="cpto_interes"></param>
		/// <param name="sumar"></param>
		/// <param name="oficio"></param>
		/// <param name="tipo_doc"></param>
		/// <param name="numero_doc"></param>
		/// <param name="cuota"></param>
		public void Create(int IdNovedad, string nomina, int contrato, string nit, int idperiodo, int centro, byte planta, short concepto, DateTime fecha, byte? mes, short? ano, int? periodo, decimal? valor, float? horas, float? dias, byte? turno, char? estado, int? nro_presta, short? cpto_interes, bool? sumar, string oficio, string tipo_doc, int? numero_doc, int? cuota,string module, Sinapsys.Datos.SQL datosTransaccion=null)
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

				paramlist.AddWithValue("@IdNovedad",IdNovedad);
				paramlist.AddWithValue("@nomina",nomina);
				paramlist.AddWithValue("@contrato",contrato);
				paramlist.AddWithValue("@nit",nit);
				paramlist.AddWithValue("@idperiodo",idperiodo);
				paramlist.AddWithValue("@centro",centro);
				paramlist.AddWithValue("@planta",planta);
				paramlist.AddWithValue("@concepto",concepto);
				paramlist.AddWithValue("@fecha",fecha);
				if (mes !=null)
				{
					paramlist.AddWithValue("@mes",mes);
				}
				if (ano !=null)
				{
					paramlist.AddWithValue("@ano",ano);
				}
				if (periodo !=null)
				{
					paramlist.AddWithValue("@periodo",periodo);
				}
				if (valor !=null)
				{
					paramlist.AddWithValue("@valor",valor);
				}
				if (horas !=null)
				{
					paramlist.AddWithValue("@horas",horas);
				}
				if (dias !=null)
				{
					paramlist.AddWithValue("@dias",dias);
				}
				if (turno !=null)
				{
					paramlist.AddWithValue("@turno",turno);
				}
				if (estado !=null)
				{
					paramlist.AddWithValue("@estado",estado);
				}
				if (nro_presta !=null)
				{
					paramlist.AddWithValue("@nro_presta",nro_presta);
				}
				if (cpto_interes !=null)
				{
					paramlist.AddWithValue("@cpto_interes",cpto_interes);
				}
				if (sumar !=null)
				{
					paramlist.AddWithValue("@sumar",sumar);
				}
				if (oficio !=null)
				{
					paramlist.AddWithValue("@oficio",oficio);
				}
				if (tipo_doc !=null)
				{
					paramlist.AddWithValue("@tipo_doc",tipo_doc);
				}
				if (numero_doc !=null)
				{
					paramlist.AddWithValue("@numero_doc",numero_doc);
				}
				if (cuota !=null)
				{
					paramlist.AddWithValue("@cuota",cuota);
				}
				LocalDataProvider.EjecutarProcedimiento("dbo.novedades_nominaCreate", paramlist, disconnect, out nullExit, DataProvider.TiempoEspera);
			}
			catch (Exception ex)
			{
				Utilidades.LogErrores(ex.Message + (ex.InnerException != null ? ex.InnerException.Message : ""), DataProvider.AplicacionNombre);
				throw ex;
			}
		}

		/// <summary>
		/// Updates one record into novedades_nomina by passing all fields
		/// </summary>
		/// <param name="IdNovedad"></param>
		/// <param name="nomina"></param>
		/// <param name="contrato"></param>
		/// <param name="nit"></param>
		/// <param name="idperiodo"></param>
		/// <param name="concepto"></param>
		/// <param name="fecha"></param>
		/// <param name="mes"></param>
		/// <param name="ano"></param>
		/// <param name="periodo"></param>
		/// <param name="valor"></param>
		/// <param name="horas"></param>
		/// <param name="dias"></param>
		/// <param name="centro"></param>
		/// <param name="planta"></param>
		/// <param name="turno"></param>
		/// <param name="estado"></param>
		/// <param name="nro_presta"></param>
		/// <param name="cpto_interes"></param>
		/// <param name="sumar"></param>
		/// <param name="oficio"></param>
		/// <param name="tipo_doc"></param>
		/// <param name="numero_doc"></param>
		/// <param name="cuota"></param>
		public void Update(int IdNovedad, string nomina, int contrato, string nit, int idperiodo, short concepto, DateTime fecha, byte? mes, short? ano, int? periodo, decimal? valor, float? horas, float? dias, int centro, byte planta, byte? turno, char? estado, int? nro_presta, short? cpto_interes, bool? sumar, string oficio, string tipo_doc, int? numero_doc, int? cuota,string module, Sinapsys.Datos.SQL datosTransaccion=null)
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
				paramlist.AddWithValue("@IdNovedad",IdNovedad);
				paramlist.AddWithValue("@nomina",nomina);
				paramlist.AddWithValue("@contrato",contrato);
				paramlist.AddWithValue("@nit",nit);
				paramlist.AddWithValue("@idperiodo",idperiodo);
				paramlist.AddWithValue("@centro",centro);
				paramlist.AddWithValue("@planta",planta);
				paramlist.AddWithValue("@concepto",concepto);
				paramlist.AddWithValue("@fecha",fecha);
				if (mes !=null)
				{
					paramlist.AddWithValue("@mes",mes);
				}
				if (ano !=null)
				{
					paramlist.AddWithValue("@ano",ano);
				}
				if (periodo !=null)
				{
					paramlist.AddWithValue("@periodo",periodo);
				}
				if (valor !=null)
				{
					paramlist.AddWithValue("@valor",valor);
				}
				if (horas !=null)
				{
					paramlist.AddWithValue("@horas",horas);
				}
				if (dias !=null)
				{
					paramlist.AddWithValue("@dias",dias);
				}
				if (turno !=null)
				{
					paramlist.AddWithValue("@turno",turno);
				}
				if (estado !=null)
				{
					paramlist.AddWithValue("@estado",estado);
				}
				if (nro_presta !=null)
				{
					paramlist.AddWithValue("@nro_presta",nro_presta);
				}
				if (cpto_interes !=null)
				{
					paramlist.AddWithValue("@cpto_interes",cpto_interes);
				}
				if (sumar !=null)
				{
					paramlist.AddWithValue("@sumar",sumar);
				}
				if (oficio !=null)
				{
					paramlist.AddWithValue("@oficio",oficio);
				}
				if (tipo_doc !=null)
				{
					paramlist.AddWithValue("@tipo_doc",tipo_doc);
				}
				if (numero_doc !=null)
				{
					paramlist.AddWithValue("@numero_doc",numero_doc);
				}
				if (cuota !=null)
				{
					paramlist.AddWithValue("@cuota",cuota);
				}
				LocalDataProvider.EjecutarProcedimiento("dbo.novedades_nominaUpdate", paramlist, disconnect, out nullExit, DataProvider.TiempoEspera);
			}
			catch (Exception ex)
			{
				Utilidades.LogErrores(ex.Message + (ex.InnerException != null ? ex.InnerException.Message : ""), DataProvider.AplicacionNombre);
				throw ex;
			}
		}

		/// <summary>
		/// Deletes one record from novedades_nomina by passing all key fields
		/// </summary>
		/// <param name="IdNovedad"></param>
		/// <param name="nomina"></param>
		/// <param name="contrato"></param>
		/// <param name="nit"></param>
		/// <param name="idperiodo"></param>
		/// <param name="centro"></param>
		/// <param name="planta"></param>
		public void Delete(int IdNovedad, string nomina, int contrato, string nit, int idperiodo, int centro, byte planta,string module, Sinapsys.Datos.SQL datosTransaccion=null)
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
				paramlist.AddWithValue("@IdNovedad",IdNovedad);
				paramlist.AddWithValue("@nomina",nomina);
				paramlist.AddWithValue("@contrato",contrato);
				paramlist.AddWithValue("@nit",nit);
				paramlist.AddWithValue("@idperiodo",idperiodo);
				paramlist.AddWithValue("@centro",centro);
				paramlist.AddWithValue("@planta",planta);
				LocalDataProvider.EjecutarProcedimiento("dbo.novedades_nominaDelete", paramlist, disconnect, out nullExit, DataProvider.TiempoEspera);
			}
			catch (Exception ex)
			{
				Utilidades.LogErrores(ex.Message + (ex.InnerException != null ? ex.InnerException.Message : ""), DataProvider.AplicacionNombre);
				throw ex;
			}
		}

		/// <summary>
		/// Gets one record from novedades_nomina passing all key fields
		/// </summary>
		/// <param name="IdNovedad"></param>
		/// <param name="nomina"></param>
		/// <param name="contrato"></param>
		/// <param name="nit"></param>
		/// <param name="idperiodo"></param>
		/// <param name="centro"></param>
		/// <param name="planta"></param>
		/// <returns>A DataTable object containing the data</returns>
		public DataTable Get(int IdNovedad, string nomina, int contrato, string nit, int idperiodo, int centro, byte planta)
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
				paramlist.AddWithValue("@IdNovedad",IdNovedad);
				paramlist.AddWithValue("@nomina",nomina);
				paramlist.AddWithValue("@contrato",contrato);
				paramlist.AddWithValue("@nit",nit);
				paramlist.AddWithValue("@idperiodo",idperiodo);
				paramlist.AddWithValue("@centro",centro);
				paramlist.AddWithValue("@planta",planta);
				return LocalDataProvider.EjecutarProcedimiento("dbo.novedades_nominaGet", paramlist, disconnect, out nullExit, DataProvider.TiempoEspera);

			}
			catch (Exception ex)
			{
				Utilidades.LogErrores(ex.Message + (ex.InnerException != null ? ex.InnerException.Message : ""), DataProvider.AplicacionNombre);
				throw ex;
			}
		}

		/// <summary>
		/// Gets all records from novedades_nomina
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
				return LocalDataProvider.EjecutarProcedimiento("dbo.novedades_nominaGetAll", paramlist, disconnect, out nullExit, DataProvider.TiempoEspera);
			}
			catch (Exception ex)
			{
				Utilidades.LogErrores(ex.Message + (ex.InnerException != null ? ex.InnerException.Message : ""), DataProvider.AplicacionNombre);
				throw ex;
			}
		}

		/// <summary>
		/// Gets all records from novedades_nomina applying filter and sort criteria
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

				return LocalDataProvider.EjecutarProcedimiento("dbo.novedades_nominaGetFilter", paramlist, disconnect, out nullExit, DataProvider.TiempoEspera);
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
		/// Gets the numbers of records from novedades_nomina applying filter and sort criteria
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

				return (int) LocalDataProvider.EjecutarProcedimiento("dbo.novedades_nominaGetFilter", paramlist, disconnect, out nullExit, DataProvider.TiempoEspera).Rows[0][0];
			}
			catch (Exception ex)
			{
				Utilidades.LogErrores(ex.Message + (ex.InnerException != null ? ex.InnerException.Message : ""), DataProvider.AplicacionNombre);
				throw ex;
			}
		}

	}
}
