using System;
using System.Data;
using System.Data.Common;
using Sinapsys.Datos;
using LiqViajes_Bll_Data.Security;
using System.Runtime.Serialization;

namespace LiqViajes_Bll_Data
{
	/// <summary>
	/// Data Access Layer class for Tempo_tblLiquidacionRutas object
	/// </summary>
	/// <remarks>
	/// This class is a Singleton
	/// </remarks>
	public partial class Tempo_tblLiquidacionRutasDataProvider
	{
		/// <summary>
		/// Internal member for create this singleton
		/// </summary>
		private static Tempo_tblLiquidacionRutasDataProvider MySingleObj = null;

		/// <summary>
		/// Protected constructor to avoid access this singleton other way than calling the Instance method
		/// </summary>
		public Tempo_tblLiquidacionRutasDataProvider()
		{

		}

		/// <summary>
		/// Instance accessor for this singleton
		/// </summary>
		public static Tempo_tblLiquidacionRutasDataProvider Instance
		{
			get
			{
				if (MySingleObj == null)
				{
					MySingleObj = new Tempo_tblLiquidacionRutasDataProvider();
				}

				return MySingleObj;
			}
		}

		/// <summary>
		/// Creates a new record into tblTempo_tblLiquidacionRutas by passing all fields
		/// </summary>
		/// <param name="lngIdRegistrRutaItemId"></param>
		/// <param name="lngIdRegistrRuta"></param>
		/// <param name="lngIdRegistro"></param>
		/// <param name="strRutaAnticipoGrupoOrigen"></param>
		/// <param name="strRutaAnticipoGrupoDestino"></param>
		/// <param name="strRutaAnticipoGrupo"></param>
		/// <param name="strRutaAnticipo"></param>
		/// <param name="floGalones"></param>
		/// <param name="curValorGalon"></param>
		/// <param name="cutCombustible"></param>
		/// <param name="lngIdNroPeajes"></param>
		/// <param name="cutPeaje"></param>
		/// <param name="strNombrePeajes"></param>
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
		/// <param name="curHotelCarretera"></param>
		/// <param name="curHotelCiudad"></param>
		/// <param name="curHotel"></param>
		/// <param name="curHotelCarreteraVacio"></param>
		/// <param name="curHotelCiudadVacio"></param>
		/// <param name="curHotelVacio"></param>
		/// <param name="intTiempoCargue"></param>
		/// <param name="intTiempoDescargue"></param>
		/// <param name="intTiempoAduana"></param>
		/// <param name="intTotalTrayecto"></param>
		/// <param name="intTotalTiempo"></param>
		/// <param name="curComida"></param>
		/// <param name="intTiempoCargueVacio"></param>
		/// <param name="intTiempoDescargueVacio"></param>
		/// <param name="intTiempoAduanaVacio"></param>
		/// <param name="intTotalTrayectoVacio"></param>
		/// <param name="intTotalTiempoVacio"></param>
		/// <param name="curComidaVacio"></param>
		/// <param name="curDesvareManoRepuestos"></param>
		/// <param name="curDesvareManoObra"></param>
		/// <param name="cutSaldo"></param>
		/// <param name="cutKmts"></param>
		/// <param name="logAjuste"></param>
		/// <param name="lngIdRegistrRutaItemIdAjc"></param>
		/// <param name="lngIdUsuario"></param>
		public void Create(int lngIdRegistrRutaItemId, int? lngIdRegistrRuta, int? lngIdRegistro, string strRutaAnticipoGrupoOrigen, string strRutaAnticipoGrupoDestino, string strRutaAnticipoGrupo, string strRutaAnticipo, decimal? floGalones, decimal? curValorGalon, decimal? cutCombustible, int? lngIdNroPeajes, decimal? cutPeaje, string strNombrePeajes, decimal? cutVariosLlantas, decimal? cutVariosCelada, decimal? cutVariosPropina, decimal? cutVarios, decimal? cutVariosLlantasVacio, decimal? cutVariosCeladaVacio, decimal? cutVariosPropinaVacio, decimal? cutVariosVacio, decimal? cutParticipacion, decimal? cutParticipacionVacio, int? curHotelCarretera, int? curHotelCiudad, decimal? curHotel, int? curHotelCarreteraVacio, int? curHotelCiudadVacio, decimal? curHotelVacio, decimal? intTiempoCargue, decimal? intTiempoDescargue, decimal? intTiempoAduana, decimal? intTotalTrayecto, decimal? intTotalTiempo, decimal? curComida, decimal? intTiempoCargueVacio, decimal? intTiempoDescargueVacio, decimal? intTiempoAduanaVacio, decimal? intTotalTrayectoVacio, decimal? intTotalTiempoVacio, decimal? curComidaVacio, decimal? curDesvareManoRepuestos, decimal? curDesvareManoObra, decimal? cutSaldo, decimal? cutKmts, bool? logAjuste, int? lngIdRegistrRutaItemIdAjc, int? lngIdUsuario,string module, Sinapsys.Datos.SQL datosTransaccion=null)
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

				paramlist.AddWithValue("@lngIdRegistrRutaItemId",lngIdRegistrRutaItemId);
				if (lngIdRegistrRuta !=null)
				{
					paramlist.AddWithValue("@lngIdRegistrRuta",lngIdRegistrRuta);
				}
				if (lngIdRegistro !=null)
				{
					paramlist.AddWithValue("@lngIdRegistro",lngIdRegistro);
				}
				if (strRutaAnticipoGrupoOrigen !=null)
				{
					paramlist.AddWithValue("@strRutaAnticipoGrupoOrigen",strRutaAnticipoGrupoOrigen);
				}
				if (strRutaAnticipoGrupoDestino !=null)
				{
					paramlist.AddWithValue("@strRutaAnticipoGrupoDestino",strRutaAnticipoGrupoDestino);
				}
				if (strRutaAnticipoGrupo !=null)
				{
					paramlist.AddWithValue("@strRutaAnticipoGrupo",strRutaAnticipoGrupo);
				}
				if (strRutaAnticipo !=null)
				{
					paramlist.AddWithValue("@strRutaAnticipo",strRutaAnticipo);
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
				if (lngIdNroPeajes !=null)
				{
					paramlist.AddWithValue("@lngIdNroPeajes",lngIdNroPeajes);
				}
				if (cutPeaje !=null)
				{
					paramlist.AddWithValue("@cutPeaje",cutPeaje);
				}
				if (strNombrePeajes !=null)
				{
					paramlist.AddWithValue("@strNombrePeajes",strNombrePeajes);
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
				if (cutVariosLlantasVacio !=null)
				{
					paramlist.AddWithValue("@cutVariosLlantasVacio",cutVariosLlantasVacio);
				}
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
				if (curHotelCarretera !=null)
				{
					paramlist.AddWithValue("@curHotelCarretera",curHotelCarretera);
				}
				if (curHotelCiudad !=null)
				{
					paramlist.AddWithValue("@curHotelCiudad",curHotelCiudad);
				}
				if (curHotel !=null)
				{
					paramlist.AddWithValue("@curHotel",curHotel);
				}
				if (curHotelCarreteraVacio !=null)
				{
					paramlist.AddWithValue("@curHotelCarreteraVacio",curHotelCarreteraVacio);
				}
				if (curHotelCiudadVacio !=null)
				{
					paramlist.AddWithValue("@curHotelCiudadVacio",curHotelCiudadVacio);
				}
				if (curHotelVacio !=null)
				{
					paramlist.AddWithValue("@curHotelVacio",curHotelVacio);
				}
				if (intTiempoCargue !=null)
				{
					paramlist.AddWithValue("@intTiempoCargue",intTiempoCargue);
				}
				if (intTiempoDescargue !=null)
				{
					paramlist.AddWithValue("@intTiempoDescargue",intTiempoDescargue);
				}
				if (intTiempoAduana !=null)
				{
					paramlist.AddWithValue("@intTiempoAduana",intTiempoAduana);
				}
				if (intTotalTrayecto !=null)
				{
					paramlist.AddWithValue("@intTotalTrayecto",intTotalTrayecto);
				}
				if (intTotalTiempo !=null)
				{
					paramlist.AddWithValue("@intTotalTiempo",intTotalTiempo);
				}
				if (curComida !=null)
				{
					paramlist.AddWithValue("@curComida",curComida);
				}
				if (intTiempoCargueVacio !=null)
				{
					paramlist.AddWithValue("@intTiempoCargueVacio",intTiempoCargueVacio);
				}
				if (intTiempoDescargueVacio !=null)
				{
					paramlist.AddWithValue("@intTiempoDescargueVacio",intTiempoDescargueVacio);
				}
				if (intTiempoAduanaVacio !=null)
				{
					paramlist.AddWithValue("@intTiempoAduanaVacio",intTiempoAduanaVacio);
				}
				if (intTotalTrayectoVacio !=null)
				{
					paramlist.AddWithValue("@intTotalTrayectoVacio",intTotalTrayectoVacio);
				}
				if (intTotalTiempoVacio !=null)
				{
					paramlist.AddWithValue("@intTotalTiempoVacio",intTotalTiempoVacio);
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
				if (logAjuste !=null)
				{
					paramlist.AddWithValue("@logAjuste",logAjuste);
				}
				if (lngIdRegistrRutaItemIdAjc !=null)
				{
					paramlist.AddWithValue("@lngIdRegistrRutaItemIdAjc",lngIdRegistrRutaItemIdAjc);
				}
				if (lngIdUsuario !=null)
				{
					paramlist.AddWithValue("@lngIdUsuario",lngIdUsuario);
				}
				LocalDataProvider.EjecutarProcedimiento("dbo.Tempo_tblLiquidacionRutasCreate", paramlist, disconnect, out nullExit, DataProvider.TiempoEspera);
			}
			catch (Exception ex)
			{
				Utilidades.LogErrores(ex.Message + (ex.InnerException != null ? ex.InnerException.Message : ""), DataProvider.AplicacionNombre);
				throw ex;
			}
		}

		/// <summary>
		/// Gets all records from tblTempo_tblLiquidacionRutas
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
				return LocalDataProvider.EjecutarProcedimiento("dbo.Tempo_tblLiquidacionRutasGetAll", paramlist, disconnect, out nullExit, DataProvider.TiempoEspera);
			}
			catch (Exception ex)
			{
				Utilidades.LogErrores(ex.Message + (ex.InnerException != null ? ex.InnerException.Message : ""), DataProvider.AplicacionNombre);
				throw ex;
			}
		}

		/// <summary>
		/// Gets all records from tblTempo_tblLiquidacionRutas applying filter and sort criteria
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

				return LocalDataProvider.EjecutarProcedimiento("dbo.Tempo_tblLiquidacionRutasGetFilter", paramlist, disconnect, out nullExit, DataProvider.TiempoEspera);
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
		/// Gets the numbers of records from tblTempo_tblLiquidacionRutas applying filter and sort criteria
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

				return (int) LocalDataProvider.EjecutarProcedimiento("dbo.Tempo_tblLiquidacionRutasGetFilter", paramlist, disconnect, out nullExit, DataProvider.TiempoEspera).Rows[0][0];
			}
			catch (Exception ex)
			{
				Utilidades.LogErrores(ex.Message + (ex.InnerException != null ? ex.InnerException.Message : ""), DataProvider.AplicacionNombre);
				throw ex;
			}
		}

	}
}
