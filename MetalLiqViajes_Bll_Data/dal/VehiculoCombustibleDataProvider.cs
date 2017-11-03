using System;
using System.Data;
using System.Data.Common;
using Sinapsys.Datos;
using LiqViajes_Bll_Data.Security;
using System.Runtime.Serialization;

namespace LiqViajes_Bll_Data
{
	/// <summary>
	/// Data Access Layer class for VehiculoCombustible object
	/// </summary>
	/// <remarks>
	/// This class is a Singleton
	/// </remarks>
	public partial class VehiculoCombustibleDataProvider
	{
		/// <summary>
		/// Internal member for create this singleton
		/// </summary>
		private static VehiculoCombustibleDataProvider MySingleObj = null;

		/// <summary>
		/// Protected constructor to avoid access this singleton other way than calling the Instance method
		/// </summary>
		public VehiculoCombustibleDataProvider()
		{

		}

		/// <summary>
		/// Instance accessor for this singleton
		/// </summary>
		public static VehiculoCombustibleDataProvider Instance
		{
			get
			{
				if (MySingleObj == null)
				{
					MySingleObj = new VehiculoCombustibleDataProvider();
				}

				return MySingleObj;
			}
		}

		/// <summary>
		/// Creates a new record into tblVehiculoCombustible by passing all fields
		/// </summary>
		/// <param name="lngIdRegistro"></param>
		/// <param name="tblLiquidacionRutasCombustibleCodigo"></param>
		/// <param name="Placa"></param>
		/// <param name="FechaTanqueo"></param>
		/// <param name="GalonesReserva"></param>
		/// <param name="GalonesTanqueo"></param>
		/// <param name="ValorGalon"></param>
		/// <param name="ValorCombustible"></param>
		/// <param name="nitTerceroComplentario"></param>
		/// <param name="NombreTerceroComplementario"></param>
		/// <param name="sw"></param>
		/// <param name="tipo"></param>
		/// <param name="numero"></param>
		/// <param name="strObservaciones"></param>
		/// <returns>long that contents the Codigo value</returns>
		public long Create(long Codigo, int? lngIdRegistro, long? tblLiquidacionRutasCombustibleCodigo, string Placa, DateTime? FechaTanqueo, decimal? GalonesReserva, decimal? GalonesTanqueo, decimal? ValorGalon, decimal? ValorCombustible, string nitTerceroComplentario, string NombreTerceroComplementario, byte sw, string tipo, int numero, string strObservaciones,string module, Sinapsys.Datos.SQL datosTransaccion=null)
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
				if (lngIdRegistro !=null)
				{
					paramlist.AddWithValue("@lngIdRegistro",lngIdRegistro);
				}
				if (tblLiquidacionRutasCombustibleCodigo !=null)
				{
					paramlist.AddWithValue("@tblLiquidacionRutasCombustibleCodigo",tblLiquidacionRutasCombustibleCodigo);
				}
				if (Placa !=null)
				{
					paramlist.AddWithValue("@Placa",Placa);
				}
				if (FechaTanqueo !=null)
				{
					paramlist.AddWithValue("@FechaTanqueo",FechaTanqueo);
				}
				if (GalonesReserva !=null)
				{
					paramlist.AddWithValue("@GalonesReserva",GalonesReserva);
				}
				if (GalonesTanqueo !=null)
				{
					paramlist.AddWithValue("@GalonesTanqueo",GalonesTanqueo);
				}
				if (ValorGalon !=null)
				{
					paramlist.AddWithValue("@ValorGalon",ValorGalon);
				}
				if (ValorCombustible !=null)
				{
					paramlist.AddWithValue("@ValorCombustible",ValorCombustible);
				}
				if (nitTerceroComplentario !=null)
				{
					paramlist.AddWithValue("@nitTerceroComplentario",nitTerceroComplentario);
				}
				if (NombreTerceroComplementario !=null)
				{
					paramlist.AddWithValue("@NombreTerceroComplementario",NombreTerceroComplementario);
				}
				paramlist.AddWithValue("@sw",sw);
				paramlist.AddWithValue("@tipo",tipo);
				paramlist.AddWithValue("@numero",numero);
				if (strObservaciones !=null)
				{
					paramlist.AddWithValue("@strObservaciones",strObservaciones);
				}
				// Execute the query and return the new identity value
				long returnValue = Convert.ToInt32(LocalDataProvider.EjecutarProcedimiento("dbo.VehiculoCombustibleCreate", paramlist, disconnect, out nullExit, DataProvider.TiempoEspera).Rows[0][0]);

				return returnValue;
			}
			catch (Exception ex)
			{
				Utilidades.LogErrores(ex.Message + (ex.InnerException != null ? ex.InnerException.Message : ""), DataProvider.AplicacionNombre);
				throw ex;
			}
		}

		/// <summary>
		/// Updates one record into tblVehiculoCombustible by passing all fields
		/// </summary>
		/// <param name="lngIdRegistro"></param>
		/// <param name="tblLiquidacionRutasCombustibleCodigo"></param>
		/// <param name="Placa"></param>
		/// <param name="FechaTanqueo"></param>
		/// <param name="GalonesReserva"></param>
		/// <param name="GalonesTanqueo"></param>
		/// <param name="ValorGalon"></param>
		/// <param name="ValorCombustible"></param>
		/// <param name="nitTerceroComplentario"></param>
		/// <param name="NombreTerceroComplementario"></param>
		/// <param name="sw"></param>
		/// <param name="tipo"></param>
		/// <param name="numero"></param>
		/// <param name="strObservaciones"></param>
		/// <param name="Codigo"></param>
		public void Update(int? lngIdRegistro, long? tblLiquidacionRutasCombustibleCodigo, string Placa, DateTime? FechaTanqueo, decimal? GalonesReserva, decimal? GalonesTanqueo, decimal? ValorGalon, decimal? ValorCombustible, string nitTerceroComplentario, string NombreTerceroComplementario, byte sw, string tipo, int numero, string strObservaciones, long Codigo,string module, Sinapsys.Datos.SQL datosTransaccion=null)
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
				if (lngIdRegistro !=null)
				{
					paramlist.AddWithValue("@lngIdRegistro",lngIdRegistro);
				}
				if (tblLiquidacionRutasCombustibleCodigo !=null)
				{
					paramlist.AddWithValue("@tblLiquidacionRutasCombustibleCodigo",tblLiquidacionRutasCombustibleCodigo);
				}
				if (Placa !=null)
				{
					paramlist.AddWithValue("@Placa",Placa);
				}
				if (FechaTanqueo !=null)
				{
					paramlist.AddWithValue("@FechaTanqueo",FechaTanqueo);
				}
				if (GalonesReserva !=null)
				{
					paramlist.AddWithValue("@GalonesReserva",GalonesReserva);
				}
				if (GalonesTanqueo !=null)
				{
					paramlist.AddWithValue("@GalonesTanqueo",GalonesTanqueo);
				}
				if (ValorGalon !=null)
				{
					paramlist.AddWithValue("@ValorGalon",ValorGalon);
				}
				if (ValorCombustible !=null)
				{
					paramlist.AddWithValue("@ValorCombustible",ValorCombustible);
				}
				if (nitTerceroComplentario !=null)
				{
					paramlist.AddWithValue("@nitTerceroComplentario",nitTerceroComplentario);
				}
				if (NombreTerceroComplementario !=null)
				{
					paramlist.AddWithValue("@NombreTerceroComplementario",NombreTerceroComplementario);
				}
				paramlist.AddWithValue("@sw",sw);
				paramlist.AddWithValue("@tipo",tipo);
				paramlist.AddWithValue("@numero",numero);
				if (strObservaciones !=null)
				{
					paramlist.AddWithValue("@strObservaciones",strObservaciones);
				}
				LocalDataProvider.EjecutarProcedimiento("dbo.VehiculoCombustibleUpdate", paramlist, disconnect, out nullExit, DataProvider.TiempoEspera);
			}
			catch (Exception ex)
			{
				Utilidades.LogErrores(ex.Message + (ex.InnerException != null ? ex.InnerException.Message : ""), DataProvider.AplicacionNombre);
				throw ex;
			}
		}

		/// <summary>
		/// Deletes one record from tblVehiculoCombustible by passing all key fields
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
				LocalDataProvider.EjecutarProcedimiento("dbo.VehiculoCombustibleDelete", paramlist, disconnect, out nullExit, DataProvider.TiempoEspera);
			}
			catch (Exception ex)
			{
				Utilidades.LogErrores(ex.Message + (ex.InnerException != null ? ex.InnerException.Message : ""), DataProvider.AplicacionNombre);
				throw ex;
			}
		}

		/// <summary>
		/// Gets one record from tblVehiculoCombustible passing all key fields
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
				return LocalDataProvider.EjecutarProcedimiento("dbo.VehiculoCombustibleGet", paramlist, disconnect, out nullExit, DataProvider.TiempoEspera);

			}
			catch (Exception ex)
			{
				Utilidades.LogErrores(ex.Message + (ex.InnerException != null ? ex.InnerException.Message : ""), DataProvider.AplicacionNombre);
				throw ex;
			}
		}

		/// <summary>
		/// Gets all records from tblVehiculoCombustible
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
				return LocalDataProvider.EjecutarProcedimiento("dbo.VehiculoCombustibleGetAll", paramlist, disconnect, out nullExit, DataProvider.TiempoEspera);
			}
			catch (Exception ex)
			{
				Utilidades.LogErrores(ex.Message + (ex.InnerException != null ? ex.InnerException.Message : ""), DataProvider.AplicacionNombre);
				throw ex;
			}
		}

		/// <summary>
		/// Gets all records from tblVehiculoCombustible applying filter and sort criteria
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

				return LocalDataProvider.EjecutarProcedimiento("dbo.VehiculoCombustibleGetFilter", paramlist, disconnect, out nullExit, DataProvider.TiempoEspera);
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
		/// Gets the numbers of records from tblVehiculoCombustible applying filter and sort criteria
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

				return (int) LocalDataProvider.EjecutarProcedimiento("dbo.VehiculoCombustibleGetFilter", paramlist, disconnect, out nullExit, DataProvider.TiempoEspera).Rows[0][0];
			}
			catch (Exception ex)
			{
				Utilidades.LogErrores(ex.Message + (ex.InnerException != null ? ex.InnerException.Message : ""), DataProvider.AplicacionNombre);
				throw ex;
			}
		}

	}
}
