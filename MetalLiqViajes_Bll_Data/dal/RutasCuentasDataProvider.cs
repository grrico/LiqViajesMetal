using System;
using System.Data;
using System.Data.Common;
using Sinapsys.Datos;
using LiqViajes_Bll_Data.Security;
using System.Runtime.Serialization;

namespace LiqViajes_Bll_Data
{
	/// <summary>
	/// Data Access Layer class for RutasCuentas object
	/// </summary>
	/// <remarks>
	/// This class is a Singleton
	/// </remarks>
	public partial class RutasCuentasDataProvider
	{
		/// <summary>
		/// Internal member for create this singleton
		/// </summary>
		private static RutasCuentasDataProvider MySingleObj = null;

		/// <summary>
		/// Protected constructor to avoid access this singleton other way than calling the Instance method
		/// </summary>
		public RutasCuentasDataProvider()
		{

		}

		/// <summary>
		/// Instance accessor for this singleton
		/// </summary>
		public static RutasCuentasDataProvider Instance
		{
			get
			{
				if (MySingleObj == null)
				{
					MySingleObj = new RutasCuentasDataProvider();
				}

				return MySingleObj;
			}
		}

		/// <summary>
		/// Creates a new record into tblRutasCuentas by passing all fields
		/// </summary>
		/// <param name="cutCombustible"></param>
		/// <param name="cutPeaje"></param>
		/// <param name="cutVariosLlantas"></param>
		/// <param name="cutVariosCelada"></param>
		/// <param name="cutVariosPropina"></param>
		/// <param name="cutVarios"></param>
		/// <param name="cutVariosLlantasVacio"></param>
		/// <param name="cutVariosCeladaVacio"></param>
		/// <param name="cutVariosPropinaVacio"></param>
		/// <param name="cutVariosVacio"></param>
		/// <param name="cutParticipacion"></param>
		/// <param name="cutParticipacionVacio"></param>
		/// <param name="curHotel"></param>
		/// <param name="curHotelVacio"></param>
		/// <param name="curComida"></param>
		/// <param name="curComidaVacio"></param>
		/// <param name="curDesvareManoRepuestos"></param>
		/// <param name="curDesvareManoObra"></param>
		/// <param name="cutSaldo"></param>
		/// <param name="cutKmts"></param>
		/// <param name="ParqueaderoCarretera"></param>
		/// <param name="ParqueaderoCiudad"></param>
		/// <param name="MontadaLLantaCarretera"></param>
		/// <param name="Papeleria"></param>
		/// <param name="AjusteCarretera"></param>
		/// <param name="Aseo"></param>
		/// <param name="Amarres"></param>
		/// <param name="Engradasa"></param>
		/// <param name="Calibrada"></param>
		/// <param name="Taxi"></param>
		/// <param name="Lavada"></param>
		/// <param name="CombustibleCarretera"></param>
		/// <param name="CurCargue"></param>
		/// <param name="CurDescargue"></param>
		public void Create(int lngIdRegistrRuta, string cutCombustible, string cutPeaje, string cutVariosLlantas, string cutVariosCelada, string cutVariosPropina, string cutVarios, string cutVariosLlantasVacio, string cutVariosCeladaVacio, string cutVariosPropinaVacio, string cutVariosVacio, string cutParticipacion, string cutParticipacionVacio, string curHotel, string curHotelVacio, string curComida, string curComidaVacio, string curDesvareManoRepuestos, string curDesvareManoObra, string cutSaldo, string cutKmts, string ParqueaderoCarretera, string ParqueaderoCiudad, string MontadaLLantaCarretera, string Papeleria, string AjusteCarretera, string Aseo, string Amarres, string Engradasa, string Calibrada, string Taxi, string Lavada, string CombustibleCarretera, string CurCargue, string CurDescargue,string module, Sinapsys.Datos.SQL datosTransaccion=null)
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

				paramlist.AddWithValue("@lngIdRegistrRuta",lngIdRegistrRuta);
				if (cutCombustible !=null)
				{
					paramlist.AddWithValue("@cutCombustible",cutCombustible);
				}
				if (cutPeaje !=null)
				{
					paramlist.AddWithValue("@cutPeaje",cutPeaje);
				}
				if (cutVariosLlantas !=null)
				{
					paramlist.AddWithValue("@cutVariosLlantas",cutVariosLlantas);
				}
				if (cutVariosCelada !=null)
				{
					paramlist.AddWithValue("@cutVariosCelada",cutVariosCelada);
				}
				if (cutVariosPropina !=null)
				{
					paramlist.AddWithValue("@cutVariosPropina",cutVariosPropina);
				}
				if (cutVarios !=null)
				{
					paramlist.AddWithValue("@cutVarios",cutVarios);
				}
				paramlist.AddWithValue("@cutVariosLlantasVacio",cutVariosLlantasVacio);
				if (cutVariosCeladaVacio !=null)
				{
					paramlist.AddWithValue("@cutVariosCeladaVacio",cutVariosCeladaVacio);
				}
				if (cutVariosPropinaVacio !=null)
				{
					paramlist.AddWithValue("@cutVariosPropinaVacio",cutVariosPropinaVacio);
				}
				if (cutVariosVacio !=null)
				{
					paramlist.AddWithValue("@cutVariosVacio",cutVariosVacio);
				}
				if (cutParticipacion !=null)
				{
					paramlist.AddWithValue("@cutParticipacion",cutParticipacion);
				}
				if (cutParticipacionVacio !=null)
				{
					paramlist.AddWithValue("@cutParticipacionVacio",cutParticipacionVacio);
				}
				if (curHotel !=null)
				{
					paramlist.AddWithValue("@curHotel",curHotel);
				}
				if (curHotelVacio !=null)
				{
					paramlist.AddWithValue("@curHotelVacio",curHotelVacio);
				}
				if (curComida !=null)
				{
					paramlist.AddWithValue("@curComida",curComida);
				}
				if (curComidaVacio !=null)
				{
					paramlist.AddWithValue("@curComidaVacio",curComidaVacio);
				}
				if (curDesvareManoRepuestos !=null)
				{
					paramlist.AddWithValue("@curDesvareManoRepuestos",curDesvareManoRepuestos);
				}
				if (curDesvareManoObra !=null)
				{
					paramlist.AddWithValue("@curDesvareManoObra",curDesvareManoObra);
				}
				if (cutSaldo !=null)
				{
					paramlist.AddWithValue("@cutSaldo",cutSaldo);
				}
				if (cutKmts !=null)
				{
					paramlist.AddWithValue("@cutKmts",cutKmts);
				}
				if (ParqueaderoCarretera !=null)
				{
					paramlist.AddWithValue("@ParqueaderoCarretera",ParqueaderoCarretera);
				}
				if (ParqueaderoCiudad !=null)
				{
					paramlist.AddWithValue("@ParqueaderoCiudad",ParqueaderoCiudad);
				}
				if (MontadaLLantaCarretera !=null)
				{
					paramlist.AddWithValue("@MontadaLLantaCarretera",MontadaLLantaCarretera);
				}
				if (Papeleria !=null)
				{
					paramlist.AddWithValue("@Papeleria",Papeleria);
				}
				if (AjusteCarretera !=null)
				{
					paramlist.AddWithValue("@AjusteCarretera",AjusteCarretera);
				}
				if (Aseo !=null)
				{
					paramlist.AddWithValue("@Aseo",Aseo);
				}
				if (Amarres !=null)
				{
					paramlist.AddWithValue("@Amarres",Amarres);
				}
				if (Engradasa !=null)
				{
					paramlist.AddWithValue("@Engradasa",Engradasa);
				}
				if (Calibrada !=null)
				{
					paramlist.AddWithValue("@Calibrada",Calibrada);
				}
				if (Taxi !=null)
				{
					paramlist.AddWithValue("@Taxi",Taxi);
				}
				if (Lavada !=null)
				{
					paramlist.AddWithValue("@Lavada",Lavada);
				}
				if (CombustibleCarretera !=null)
				{
					paramlist.AddWithValue("@CombustibleCarretera",CombustibleCarretera);
				}
				if (CurCargue !=null)
				{
					paramlist.AddWithValue("@CurCargue",CurCargue);
				}
				if (CurDescargue !=null)
				{
					paramlist.AddWithValue("@CurDescargue",CurDescargue);
				}
				LocalDataProvider.EjecutarProcedimiento("dbo.RutasCuentasCreate", paramlist, disconnect, out nullExit, DataProvider.TiempoEspera);
			}
			catch (Exception ex)
			{
				Utilidades.LogErrores(ex.Message + (ex.InnerException != null ? ex.InnerException.Message : ""), DataProvider.AplicacionNombre);
				throw ex;
			}
		}

		/// <summary>
		/// Updates one record into tblRutasCuentas by passing all fields
		/// </summary>
		/// <param name="lngIdRegistrRuta"></param>
		/// <param name="cutCombustible"></param>
		/// <param name="cutPeaje"></param>
		/// <param name="cutVariosLlantas"></param>
		/// <param name="cutVariosCelada"></param>
		/// <param name="cutVariosPropina"></param>
		/// <param name="cutVarios"></param>
		/// <param name="cutVariosLlantasVacio"></param>
		/// <param name="cutVariosCeladaVacio"></param>
		/// <param name="cutVariosPropinaVacio"></param>
		/// <param name="cutVariosVacio"></param>
		/// <param name="cutParticipacion"></param>
		/// <param name="cutParticipacionVacio"></param>
		/// <param name="curHotel"></param>
		/// <param name="curHotelVacio"></param>
		/// <param name="curComida"></param>
		/// <param name="curComidaVacio"></param>
		/// <param name="curDesvareManoRepuestos"></param>
		/// <param name="curDesvareManoObra"></param>
		/// <param name="cutSaldo"></param>
		/// <param name="cutKmts"></param>
		/// <param name="ParqueaderoCarretera"></param>
		/// <param name="ParqueaderoCiudad"></param>
		/// <param name="MontadaLLantaCarretera"></param>
		/// <param name="Papeleria"></param>
		/// <param name="AjusteCarretera"></param>
		/// <param name="Aseo"></param>
		/// <param name="Amarres"></param>
		/// <param name="Engradasa"></param>
		/// <param name="Calibrada"></param>
		/// <param name="Taxi"></param>
		/// <param name="Lavada"></param>
		/// <param name="CombustibleCarretera"></param>
		/// <param name="CurCargue"></param>
		/// <param name="CurDescargue"></param>
		public void Update(int lngIdRegistrRuta, string cutCombustible, string cutPeaje, string cutVariosLlantas, string cutVariosCelada, string cutVariosPropina, string cutVarios, string cutVariosLlantasVacio, string cutVariosCeladaVacio, string cutVariosPropinaVacio, string cutVariosVacio, string cutParticipacion, string cutParticipacionVacio, string curHotel, string curHotelVacio, string curComida, string curComidaVacio, string curDesvareManoRepuestos, string curDesvareManoObra, string cutSaldo, string cutKmts, string ParqueaderoCarretera, string ParqueaderoCiudad, string MontadaLLantaCarretera, string Papeleria, string AjusteCarretera, string Aseo, string Amarres, string Engradasa, string Calibrada, string Taxi, string Lavada, string CombustibleCarretera, string CurCargue, string CurDescargue,string module, Sinapsys.Datos.SQL datosTransaccion=null)
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
				paramlist.AddWithValue("@lngIdRegistrRuta",lngIdRegistrRuta);
				if (cutCombustible !=null)
				{
					paramlist.AddWithValue("@cutCombustible",cutCombustible);
				}
				if (cutPeaje !=null)
				{
					paramlist.AddWithValue("@cutPeaje",cutPeaje);
				}
				if (cutVariosLlantas !=null)
				{
					paramlist.AddWithValue("@cutVariosLlantas",cutVariosLlantas);
				}
				if (cutVariosCelada !=null)
				{
					paramlist.AddWithValue("@cutVariosCelada",cutVariosCelada);
				}
				if (cutVariosPropina !=null)
				{
					paramlist.AddWithValue("@cutVariosPropina",cutVariosPropina);
				}
				if (cutVarios !=null)
				{
					paramlist.AddWithValue("@cutVarios",cutVarios);
				}
				paramlist.AddWithValue("@cutVariosLlantasVacio",cutVariosLlantasVacio);
				if (cutVariosCeladaVacio !=null)
				{
					paramlist.AddWithValue("@cutVariosCeladaVacio",cutVariosCeladaVacio);
				}
				if (cutVariosPropinaVacio !=null)
				{
					paramlist.AddWithValue("@cutVariosPropinaVacio",cutVariosPropinaVacio);
				}
				if (cutVariosVacio !=null)
				{
					paramlist.AddWithValue("@cutVariosVacio",cutVariosVacio);
				}
				if (cutParticipacion !=null)
				{
					paramlist.AddWithValue("@cutParticipacion",cutParticipacion);
				}
				if (cutParticipacionVacio !=null)
				{
					paramlist.AddWithValue("@cutParticipacionVacio",cutParticipacionVacio);
				}
				if (curHotel !=null)
				{
					paramlist.AddWithValue("@curHotel",curHotel);
				}
				if (curHotelVacio !=null)
				{
					paramlist.AddWithValue("@curHotelVacio",curHotelVacio);
				}
				if (curComida !=null)
				{
					paramlist.AddWithValue("@curComida",curComida);
				}
				if (curComidaVacio !=null)
				{
					paramlist.AddWithValue("@curComidaVacio",curComidaVacio);
				}
				if (curDesvareManoRepuestos !=null)
				{
					paramlist.AddWithValue("@curDesvareManoRepuestos",curDesvareManoRepuestos);
				}
				if (curDesvareManoObra !=null)
				{
					paramlist.AddWithValue("@curDesvareManoObra",curDesvareManoObra);
				}
				if (cutSaldo !=null)
				{
					paramlist.AddWithValue("@cutSaldo",cutSaldo);
				}
				if (cutKmts !=null)
				{
					paramlist.AddWithValue("@cutKmts",cutKmts);
				}
				if (ParqueaderoCarretera !=null)
				{
					paramlist.AddWithValue("@ParqueaderoCarretera",ParqueaderoCarretera);
				}
				if (ParqueaderoCiudad !=null)
				{
					paramlist.AddWithValue("@ParqueaderoCiudad",ParqueaderoCiudad);
				}
				if (MontadaLLantaCarretera !=null)
				{
					paramlist.AddWithValue("@MontadaLLantaCarretera",MontadaLLantaCarretera);
				}
				if (Papeleria !=null)
				{
					paramlist.AddWithValue("@Papeleria",Papeleria);
				}
				if (AjusteCarretera !=null)
				{
					paramlist.AddWithValue("@AjusteCarretera",AjusteCarretera);
				}
				if (Aseo !=null)
				{
					paramlist.AddWithValue("@Aseo",Aseo);
				}
				if (Amarres !=null)
				{
					paramlist.AddWithValue("@Amarres",Amarres);
				}
				if (Engradasa !=null)
				{
					paramlist.AddWithValue("@Engradasa",Engradasa);
				}
				if (Calibrada !=null)
				{
					paramlist.AddWithValue("@Calibrada",Calibrada);
				}
				if (Taxi !=null)
				{
					paramlist.AddWithValue("@Taxi",Taxi);
				}
				if (Lavada !=null)
				{
					paramlist.AddWithValue("@Lavada",Lavada);
				}
				if (CombustibleCarretera !=null)
				{
					paramlist.AddWithValue("@CombustibleCarretera",CombustibleCarretera);
				}
				if (CurCargue !=null)
				{
					paramlist.AddWithValue("@CurCargue",CurCargue);
				}
				if (CurDescargue !=null)
				{
					paramlist.AddWithValue("@CurDescargue",CurDescargue);
				}
				LocalDataProvider.EjecutarProcedimiento("dbo.RutasCuentasUpdate", paramlist, disconnect, out nullExit, DataProvider.TiempoEspera);
			}
			catch (Exception ex)
			{
				Utilidades.LogErrores(ex.Message + (ex.InnerException != null ? ex.InnerException.Message : ""), DataProvider.AplicacionNombre);
				throw ex;
			}
		}

		/// <summary>
		/// Deletes one record from tblRutasCuentas by passing all key fields
		/// </summary>
		/// <param name="lngIdRegistrRuta"></param>
		public void Delete(int lngIdRegistrRuta,string module, Sinapsys.Datos.SQL datosTransaccion=null)
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
				paramlist.AddWithValue("@lngIdRegistrRuta",lngIdRegistrRuta);
				LocalDataProvider.EjecutarProcedimiento("dbo.RutasCuentasDelete", paramlist, disconnect, out nullExit, DataProvider.TiempoEspera);
			}
			catch (Exception ex)
			{
				Utilidades.LogErrores(ex.Message + (ex.InnerException != null ? ex.InnerException.Message : ""), DataProvider.AplicacionNombre);
				throw ex;
			}
		}

		/// <summary>
		/// Gets one record from tblRutasCuentas passing all key fields
		/// </summary>
		/// <param name="lngIdRegistrRuta"></param>
		/// <returns>A DataTable object containing the data</returns>
		public DataTable Get(int lngIdRegistrRuta)
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
				paramlist.AddWithValue("@lngIdRegistrRuta",lngIdRegistrRuta);
				return LocalDataProvider.EjecutarProcedimiento("dbo.RutasCuentasGet", paramlist, disconnect, out nullExit, DataProvider.TiempoEspera);

			}
			catch (Exception ex)
			{
				Utilidades.LogErrores(ex.Message + (ex.InnerException != null ? ex.InnerException.Message : ""), DataProvider.AplicacionNombre);
				throw ex;
			}
		}

		/// <summary>
		/// Gets all records from tblRutasCuentas
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
				return LocalDataProvider.EjecutarProcedimiento("dbo.RutasCuentasGetAll", paramlist, disconnect, out nullExit, DataProvider.TiempoEspera);
			}
			catch (Exception ex)
			{
				Utilidades.LogErrores(ex.Message + (ex.InnerException != null ? ex.InnerException.Message : ""), DataProvider.AplicacionNombre);
				throw ex;
			}
		}

		/// <summary>
		/// Gets all records from tblRutasCuentas applying filter and sort criteria
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

				return LocalDataProvider.EjecutarProcedimiento("dbo.RutasCuentasGetFilter", paramlist, disconnect, out nullExit, DataProvider.TiempoEspera);
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
		/// Gets the numbers of records from tblRutasCuentas applying filter and sort criteria
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

				return (int) LocalDataProvider.EjecutarProcedimiento("dbo.RutasCuentasGetFilter", paramlist, disconnect, out nullExit, DataProvider.TiempoEspera).Rows[0][0];
			}
			catch (Exception ex)
			{
				Utilidades.LogErrores(ex.Message + (ex.InnerException != null ? ex.InnerException.Message : ""), DataProvider.AplicacionNombre);
				throw ex;
			}
		}

	}
}
