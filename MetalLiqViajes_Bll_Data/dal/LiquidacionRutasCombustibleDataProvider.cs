using System;
using System.Data;
using System.Data.Common;
using Sinapsys.Datos;
using LiqViajes_Bll_Data.Security;
using System.Runtime.Serialization;

namespace LiqViajes_Bll_Data
{
	/// <summary>
	/// Data Access Layer class for LiquidacionRutasCombustible object
	/// </summary>
	/// <remarks>
	/// This class is a Singleton
	/// </remarks>
	public partial class LiquidacionRutasCombustibleDataProvider
	{
		/// <summary>
		/// Internal member for create this singleton
		/// </summary>
		private static LiquidacionRutasCombustibleDataProvider MySingleObj = null;

		/// <summary>
		/// Protected constructor to avoid access this singleton other way than calling the Instance method
		/// </summary>
		public LiquidacionRutasCombustibleDataProvider()
		{

		}

		/// <summary>
		/// Instance accessor for this singleton
		/// </summary>
		public static LiquidacionRutasCombustibleDataProvider Instance
		{
			get
			{
				if (MySingleObj == null)
				{
					MySingleObj = new LiquidacionRutasCombustibleDataProvider();
				}

				return MySingleObj;
			}
		}

		/// <summary>
		/// Creates a new record into tblLiquidacionRutasCombustible by passing all fields
		/// </summary>
		/// <param name="lngIdRegistrRutaItemId"></param>
		/// <param name="lngIdRegistro"></param>
		/// <param name="lngIdRegistrRuta"></param>
		/// <param name="intRowRegistro"></param>
		/// <param name="strRutaAnticipoGrupoOrigen"></param>
		/// <param name="strRutaAnticipoGrupoDestino"></param>
		/// <param name="nitTercero"></param>
		/// <param name="NombreTercero"></param>
		/// <param name="floGalones"></param>
		/// <param name="curValorGalon"></param>
		/// <param name="cutCombustible"></param>
		/// <param name="nitTerceroComplentario"></param>
		/// <param name="NombreTerceroComplementario"></param>
		/// <param name="floGalonesComplementario"></param>
		/// <param name="curValorGalonComplentario"></param>
		/// <param name="cutCombustibleComplementario"></param>
		/// <param name="strObservaciones"></param>
		/// <returns>long that contents the Codigo value</returns>
		public long Create(long Codigo, int? lngIdRegistrRutaItemId, int? lngIdRegistro, int? lngIdRegistrRuta, int? intRowRegistro, string strRutaAnticipoGrupoOrigen, string strRutaAnticipoGrupoDestino, string nitTercero, string NombreTercero, decimal? floGalones, decimal? curValorGalon, decimal? cutCombustible, string nitTerceroComplentario, string NombreTerceroComplementario, decimal? floGalonesComplementario, decimal? curValorGalonComplentario, decimal? cutCombustibleComplementario, string strObservaciones,string module, Sinapsys.Datos.SQL datosTransaccion=null)
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
				if (lngIdRegistrRutaItemId !=null)
				{
					paramlist.AddWithValue("@lngIdRegistrRutaItemId",lngIdRegistrRutaItemId);
				}
				if (lngIdRegistro !=null)
				{
					paramlist.AddWithValue("@lngIdRegistro",lngIdRegistro);
				}
				if (lngIdRegistrRuta !=null)
				{
					paramlist.AddWithValue("@lngIdRegistrRuta",lngIdRegistrRuta);
				}
				if (intRowRegistro !=null)
				{
					paramlist.AddWithValue("@intRowRegistro",intRowRegistro);
				}
				if (strRutaAnticipoGrupoOrigen !=null)
				{
					paramlist.AddWithValue("@strRutaAnticipoGrupoOrigen",strRutaAnticipoGrupoOrigen);
				}
				if (strRutaAnticipoGrupoDestino !=null)
				{
					paramlist.AddWithValue("@strRutaAnticipoGrupoDestino",strRutaAnticipoGrupoDestino);
				}
				if (nitTercero !=null)
				{
					paramlist.AddWithValue("@nitTercero",nitTercero);
				}
				if (NombreTercero !=null)
				{
					paramlist.AddWithValue("@NombreTercero",NombreTercero);
				}
				if (floGalones !=null)
				{
					paramlist.AddWithValue("@floGalones",floGalones);
				}
				if (curValorGalon !=null)
				{
					paramlist.AddWithValue("@curValorGalon",curValorGalon);
				}
				if (cutCombustible !=null)
				{
					paramlist.AddWithValue("@cutCombustible",cutCombustible);
				}
				if (nitTerceroComplentario !=null)
				{
					paramlist.AddWithValue("@nitTerceroComplentario",nitTerceroComplentario);
				}
				if (NombreTerceroComplementario !=null)
				{
					paramlist.AddWithValue("@NombreTerceroComplementario",NombreTerceroComplementario);
				}
				if (floGalonesComplementario !=null)
				{
					paramlist.AddWithValue("@floGalonesComplementario",floGalonesComplementario);
				}
				if (curValorGalonComplentario !=null)
				{
					paramlist.AddWithValue("@curValorGalonComplentario",curValorGalonComplentario);
				}
				if (cutCombustibleComplementario !=null)
				{
					paramlist.AddWithValue("@cutCombustibleComplementario",cutCombustibleComplementario);
				}
				if (strObservaciones !=null)
				{
					paramlist.AddWithValue("@strObservaciones",strObservaciones);
				}
				// Execute the query and return the new identity value
				long returnValue = Convert.ToInt32(LocalDataProvider.EjecutarProcedimiento("dbo.LiquidacionRutasCombustibleCreate", paramlist, disconnect, out nullExit, DataProvider.TiempoEspera).Rows[0][0]);

				return returnValue;
			}
			catch (Exception ex)
			{
				Utilidades.LogErrores(ex.Message + (ex.InnerException != null ? ex.InnerException.Message : ""), DataProvider.AplicacionNombre);
				throw ex;
			}
		}

		/// <summary>
		/// Updates one record into tblLiquidacionRutasCombustible by passing all fields
		/// </summary>
		/// <param name="Codigo"></param>
		/// <param name="lngIdRegistrRutaItemId"></param>
		/// <param name="lngIdRegistro"></param>
		/// <param name="lngIdRegistrRuta"></param>
		/// <param name="intRowRegistro"></param>
		/// <param name="strRutaAnticipoGrupoOrigen"></param>
		/// <param name="strRutaAnticipoGrupoDestino"></param>
		/// <param name="nitTercero"></param>
		/// <param name="NombreTercero"></param>
		/// <param name="floGalones"></param>
		/// <param name="curValorGalon"></param>
		/// <param name="cutCombustible"></param>
		/// <param name="nitTerceroComplentario"></param>
		/// <param name="NombreTerceroComplementario"></param>
		/// <param name="floGalonesComplementario"></param>
		/// <param name="curValorGalonComplentario"></param>
		/// <param name="cutCombustibleComplementario"></param>
		/// <param name="strObservaciones"></param>
		public void Update(long Codigo, int? lngIdRegistrRutaItemId, int? lngIdRegistro, int? lngIdRegistrRuta, int? intRowRegistro, string strRutaAnticipoGrupoOrigen, string strRutaAnticipoGrupoDestino, string nitTercero, string NombreTercero, decimal? floGalones, decimal? curValorGalon, decimal? cutCombustible, string nitTerceroComplentario, string NombreTerceroComplementario, decimal? floGalonesComplementario, decimal? curValorGalonComplentario, decimal? cutCombustibleComplementario, string strObservaciones,string module, Sinapsys.Datos.SQL datosTransaccion=null)
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
				if (lngIdRegistrRutaItemId !=null)
				{
					paramlist.AddWithValue("@lngIdRegistrRutaItemId",lngIdRegistrRutaItemId);
				}
				if (lngIdRegistro !=null)
				{
					paramlist.AddWithValue("@lngIdRegistro",lngIdRegistro);
				}
				if (lngIdRegistrRuta !=null)
				{
					paramlist.AddWithValue("@lngIdRegistrRuta",lngIdRegistrRuta);
				}
				if (intRowRegistro !=null)
				{
					paramlist.AddWithValue("@intRowRegistro",intRowRegistro);
				}
				if (strRutaAnticipoGrupoOrigen !=null)
				{
					paramlist.AddWithValue("@strRutaAnticipoGrupoOrigen",strRutaAnticipoGrupoOrigen);
				}
				if (strRutaAnticipoGrupoDestino !=null)
				{
					paramlist.AddWithValue("@strRutaAnticipoGrupoDestino",strRutaAnticipoGrupoDestino);
				}
				if (nitTercero !=null)
				{
					paramlist.AddWithValue("@nitTercero",nitTercero);
				}
				if (NombreTercero !=null)
				{
					paramlist.AddWithValue("@NombreTercero",NombreTercero);
				}
				if (floGalones !=null)
				{
					paramlist.AddWithValue("@floGalones",floGalones);
				}
				if (curValorGalon !=null)
				{
					paramlist.AddWithValue("@curValorGalon",curValorGalon);
				}
				if (cutCombustible !=null)
				{
					paramlist.AddWithValue("@cutCombustible",cutCombustible);
				}
				if (nitTerceroComplentario !=null)
				{
					paramlist.AddWithValue("@nitTerceroComplentario",nitTerceroComplentario);
				}
				if (NombreTerceroComplementario !=null)
				{
					paramlist.AddWithValue("@NombreTerceroComplementario",NombreTerceroComplementario);
				}
				if (floGalonesComplementario !=null)
				{
					paramlist.AddWithValue("@floGalonesComplementario",floGalonesComplementario);
				}
				if (curValorGalonComplentario !=null)
				{
					paramlist.AddWithValue("@curValorGalonComplentario",curValorGalonComplentario);
				}
				if (cutCombustibleComplementario !=null)
				{
					paramlist.AddWithValue("@cutCombustibleComplementario",cutCombustibleComplementario);
				}
				if (strObservaciones !=null)
				{
					paramlist.AddWithValue("@strObservaciones",strObservaciones);
				}
				LocalDataProvider.EjecutarProcedimiento("dbo.LiquidacionRutasCombustibleUpdate", paramlist, disconnect, out nullExit, DataProvider.TiempoEspera);
			}
			catch (Exception ex)
			{
				Utilidades.LogErrores(ex.Message + (ex.InnerException != null ? ex.InnerException.Message : ""), DataProvider.AplicacionNombre);
				throw ex;
			}
		}

		/// <summary>
		/// Deletes one record from tblLiquidacionRutasCombustible by passing all key fields
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
				LocalDataProvider.EjecutarProcedimiento("dbo.LiquidacionRutasCombustibleDelete", paramlist, disconnect, out nullExit, DataProvider.TiempoEspera);
			}
			catch (Exception ex)
			{
				Utilidades.LogErrores(ex.Message + (ex.InnerException != null ? ex.InnerException.Message : ""), DataProvider.AplicacionNombre);
				throw ex;
			}
		}

		/// <summary>
		/// Gets one record from tblLiquidacionRutasCombustible passing all key fields
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
				return LocalDataProvider.EjecutarProcedimiento("dbo.LiquidacionRutasCombustibleGet", paramlist, disconnect, out nullExit, DataProvider.TiempoEspera);

			}
			catch (Exception ex)
			{
				Utilidades.LogErrores(ex.Message + (ex.InnerException != null ? ex.InnerException.Message : ""), DataProvider.AplicacionNombre);
				throw ex;
			}
		}

		/// <summary>
		/// Gets all records from tblLiquidacionRutasCombustible
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
				return LocalDataProvider.EjecutarProcedimiento("dbo.LiquidacionRutasCombustibleGetAll", paramlist, disconnect, out nullExit, DataProvider.TiempoEspera);
			}
			catch (Exception ex)
			{
				Utilidades.LogErrores(ex.Message + (ex.InnerException != null ? ex.InnerException.Message : ""), DataProvider.AplicacionNombre);
				throw ex;
			}
		}

		/// <summary>
		/// Gets all records from tblLiquidacionRutasCombustible applying filter and sort criteria
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

				return LocalDataProvider.EjecutarProcedimiento("dbo.LiquidacionRutasCombustibleGetFilter", paramlist, disconnect, out nullExit, DataProvider.TiempoEspera);
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
		/// Gets the numbers of records from tblLiquidacionRutasCombustible applying filter and sort criteria
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

				return (int) LocalDataProvider.EjecutarProcedimiento("dbo.LiquidacionRutasCombustibleGetFilter", paramlist, disconnect, out nullExit, DataProvider.TiempoEspera).Rows[0][0];
			}
			catch (Exception ex)
			{
				Utilidades.LogErrores(ex.Message + (ex.InnerException != null ? ex.InnerException.Message : ""), DataProvider.AplicacionNombre);
				throw ex;
			}
		}

	}
}
