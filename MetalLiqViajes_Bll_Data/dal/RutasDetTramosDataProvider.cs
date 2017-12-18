using System;
using System.Data;
using System.Data.Common;
using Sinapsys.Datos;
using LiqViajes_Bll_Data.Security;
using System.Runtime.Serialization;

namespace LiqViajes_Bll_Data
{
	/// <summary>
	/// Data Access Layer class for RutasDetTramos object
	/// </summary>
	/// <remarks>
	/// This class is a Singleton
	/// </remarks>
	public partial class RutasDetTramosDataProvider
	{
		/// <summary>
		/// Internal member for create this singleton
		/// </summary>
		private static RutasDetTramosDataProvider MySingleObj = null;

		/// <summary>
		/// Protected constructor to avoid access this singleton other way than calling the Instance method
		/// </summary>
		public RutasDetTramosDataProvider()
		{

		}

		/// <summary>
		/// Instance accessor for this singleton
		/// </summary>
		public static RutasDetTramosDataProvider Instance
		{
			get
			{
				if (MySingleObj == null)
				{
					MySingleObj = new RutasDetTramosDataProvider();
				}

				return MySingleObj;
			}
		}

		/// <summary>
		/// Creates a new record into RutasDetTramos by passing all fields
		/// </summary>
		/// <param name="logAsigna_Chk_600"></param>
		/// <param name="lngIdRegistrRuta"></param>
		/// <param name="strRutaAnticipoGrupoOrigen"></param>
		/// <param name="strRutaAnticipoGrupoDestino"></param>
		/// <param name="strRutaAnticipo"></param>
		/// <param name="floGalones"></param>
		/// <param name="curValorGalon"></param>
		/// <param name="cutCombustible"></param>
		/// <param name="lngIdNroPeajes"></param>
		/// <param name="cutPeaje"></param>
		/// <param name="cutVariosLlantas"></param>
		/// <param name="cutVariosCelada"></param>
		/// <param name="cutVariosPropina"></param>
		/// <param name="cutVarios"></param>
		/// <param name="cutVariosLlantasVacio"></param>
		/// <param name="cutVariosCeladaVacio"></param>
		/// <param name="cutVariosPropinaVacio"></param>
		/// <param name="cutVariosVacio"></param>
		/// <param name="CurCargue"></param>
		/// <param name="CurDescargue"></param>
		/// <param name="curHotel"></param>
		/// <param name="curHotelCarreteraVacio"></param>
		/// <param name="curHotelCiudadVacio"></param>
		/// <param name="curHotelVacio"></param>
		/// <param name="intTotalTiempo"></param>
		/// <param name="curComida"></param>
		/// <param name="intTotalTiempoVacio"></param>
		/// <param name="curComidaVacio"></param>
		/// <param name="cutParticipacion"></param>
		/// <param name="cutParticipacionVacio"></param>
		/// <param name="curDesvareManoRepuestos"></param>
		/// <param name="curDesvareManoObra"></param>
		/// <param name="cutKmts"></param>
		/// <param name="logVacio"></param>
		/// <param name="ParqueaderoCarretera"></param>
		/// <param name="ParqueaderoCiudad"></param>
		/// <param name="MontadaLLantaCarretera"></param>
		/// <param name="Papeleria"></param>
		/// <param name="AjusteCarretera"></param>
		/// <param name="CombustibleCarretera"></param>
		/// <param name="Amarres_Amarres_1000"></param>
		/// <param name="Engradasa"></param>
		/// <param name="Calibrada"></param>
		/// <param name="TipoVehiculoCodigo"></param>
		/// <param name="TipoVehiculo"></param>
		/// <param name="TipoTrailerCodigo"></param>
		/// <param name="Peso"></param>
		/// <param name="logEstadoRuta"></param>
		/// <param name="Trailer"></param>
		/// <param name="Aseo"></param>
		/// <param name="Contenedor1"></param>
		/// <param name="Contenedor2"></param>
		/// <param name="FactorCalculoDia"></param>
		/// <param name="ValorCalculoFactor"></param>
		/// <param name="Liquidado"></param>
		/// <param name="Taxi"></param>
		/// <param name="logFavorito"></param>
		/// <param name="logAnticipoACPM"></param>
		public void Create(long Codigo, bool logAsigna_Chk_600, long lngIdRegistrRuta, string strRutaAnticipoGrupoOrigen, string strRutaAnticipoGrupoDestino, string strRutaAnticipo, decimal floGalones, decimal curValorGalon, decimal cutCombustible, int lngIdNroPeajes, decimal cutPeaje, decimal cutVariosLlantas, decimal cutVariosCelada, decimal cutVariosPropina, decimal cutVarios, decimal cutVariosLlantasVacio, decimal cutVariosCeladaVacio, decimal cutVariosPropinaVacio, decimal cutVariosVacio, decimal CurCargue, decimal CurDescargue, decimal curHotel, decimal curHotelCarreteraVacio, decimal curHotelCiudadVacio, decimal curHotelVacio, decimal intTotalTiempo, decimal curComida, decimal intTotalTiempoVacio, decimal curComidaVacio, decimal cutParticipacion, decimal cutParticipacionVacio, decimal curDesvareManoRepuestos, decimal curDesvareManoObra, decimal cutKmts, bool logVacio, decimal ParqueaderoCarretera, decimal ParqueaderoCiudad, decimal MontadaLLantaCarretera, decimal Papeleria, decimal AjusteCarretera, decimal CombustibleCarretera, decimal Amarres_Amarres_1000, decimal Engradasa, decimal Calibrada, int TipoVehiculoCodigo, string TipoVehiculo, int TipoTrailerCodigo, int Peso, bool logEstadoRuta, string Trailer, decimal Aseo, string Contenedor1, string Contenedor2, int FactorCalculoDia, int ValorCalculoFactor, bool Liquidado, decimal Taxi, bool logFavorito, bool logAnticipoACPM,string module, Sinapsys.Datos.SQL datosTransaccion=null)
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
				paramlist.AddWithValue("@logAsigna_Chk_600",logAsigna_Chk_600);
				paramlist.AddWithValue("@lngIdRegistrRuta",lngIdRegistrRuta);
				paramlist.AddWithValue("@strRutaAnticipoGrupoOrigen",strRutaAnticipoGrupoOrigen);
				paramlist.AddWithValue("@strRutaAnticipoGrupoDestino",strRutaAnticipoGrupoDestino);
				paramlist.AddWithValue("@strRutaAnticipo",strRutaAnticipo);
				paramlist.AddWithValue("@floGalones",floGalones);
				paramlist.AddWithValue("@curValorGalon",curValorGalon);
				paramlist.AddWithValue("@cutCombustible",cutCombustible);
				paramlist.AddWithValue("@lngIdNroPeajes",lngIdNroPeajes);
				paramlist.AddWithValue("@cutPeaje",cutPeaje);
				paramlist.AddWithValue("@cutVariosLlantas",cutVariosLlantas);
				paramlist.AddWithValue("@cutVariosCelada",cutVariosCelada);
				paramlist.AddWithValue("@cutVariosPropina",cutVariosPropina);
				paramlist.AddWithValue("@cutVarios",cutVarios);
				paramlist.AddWithValue("@cutVariosLlantasVacio",cutVariosLlantasVacio);
				paramlist.AddWithValue("@cutVariosCeladaVacio",cutVariosCeladaVacio);
				paramlist.AddWithValue("@cutVariosPropinaVacio",cutVariosPropinaVacio);
				paramlist.AddWithValue("@cutVariosVacio",cutVariosVacio);
				paramlist.AddWithValue("@CurCargue",CurCargue);
				paramlist.AddWithValue("@CurDescargue",CurDescargue);
				paramlist.AddWithValue("@curHotel",curHotel);
				paramlist.AddWithValue("@curHotelCarreteraVacio",curHotelCarreteraVacio);
				paramlist.AddWithValue("@curHotelCiudadVacio",curHotelCiudadVacio);
				paramlist.AddWithValue("@curHotelVacio",curHotelVacio);
				paramlist.AddWithValue("@intTotalTiempo",intTotalTiempo);
				paramlist.AddWithValue("@curComida",curComida);
				paramlist.AddWithValue("@intTotalTiempoVacio",intTotalTiempoVacio);
				paramlist.AddWithValue("@curComidaVacio",curComidaVacio);
				paramlist.AddWithValue("@cutParticipacion",cutParticipacion);
				paramlist.AddWithValue("@cutParticipacionVacio",cutParticipacionVacio);
				paramlist.AddWithValue("@curDesvareManoRepuestos",curDesvareManoRepuestos);
				paramlist.AddWithValue("@curDesvareManoObra",curDesvareManoObra);
				paramlist.AddWithValue("@cutKmts",cutKmts);
				paramlist.AddWithValue("@logVacio",logVacio);
				paramlist.AddWithValue("@ParqueaderoCarretera",ParqueaderoCarretera);
				paramlist.AddWithValue("@ParqueaderoCiudad",ParqueaderoCiudad);
				paramlist.AddWithValue("@MontadaLLantaCarretera",MontadaLLantaCarretera);
				paramlist.AddWithValue("@Papeleria",Papeleria);
				paramlist.AddWithValue("@AjusteCarretera",AjusteCarretera);
				paramlist.AddWithValue("@CombustibleCarretera",CombustibleCarretera);
				paramlist.AddWithValue("@Amarres_Amarres_1000",Amarres_Amarres_1000);
				paramlist.AddWithValue("@Engradasa",Engradasa);
				paramlist.AddWithValue("@Calibrada",Calibrada);
				paramlist.AddWithValue("@TipoVehiculoCodigo",TipoVehiculoCodigo);
				paramlist.AddWithValue("@TipoVehiculo",TipoVehiculo);
				paramlist.AddWithValue("@TipoTrailerCodigo",TipoTrailerCodigo);
				paramlist.AddWithValue("@Peso",Peso);
				paramlist.AddWithValue("@logEstadoRuta",logEstadoRuta);
				paramlist.AddWithValue("@Trailer",Trailer);
				paramlist.AddWithValue("@Aseo",Aseo);
				paramlist.AddWithValue("@Contenedor1",Contenedor1);
				paramlist.AddWithValue("@Contenedor2",Contenedor2);
				paramlist.AddWithValue("@FactorCalculoDia",FactorCalculoDia);
				paramlist.AddWithValue("@ValorCalculoFactor",ValorCalculoFactor);
				paramlist.AddWithValue("@Liquidado",Liquidado);
				paramlist.AddWithValue("@Taxi",Taxi);
				paramlist.AddWithValue("@logFavorito",logFavorito);
				paramlist.AddWithValue("@logAnticipoACPM",logAnticipoACPM);
				LocalDataProvider.EjecutarProcedimiento("dbo.RutasDetTramosCreate", paramlist, disconnect, out nullExit, DataProvider.TiempoEspera);
			}
			catch (Exception ex)
			{
				Utilidades.LogErrores(ex.Message + (ex.InnerException != null ? ex.InnerException.Message : ""), DataProvider.AplicacionNombre);
				throw ex;
			}
		}

		/// <summary>
		/// Updates one record into RutasDetTramos by passing all fields
		/// </summary>
		/// <param name="Codigo"></param>
		/// <param name="logAsigna_Chk_600"></param>
		/// <param name="lngIdRegistrRuta"></param>
		/// <param name="strRutaAnticipoGrupoOrigen"></param>
		/// <param name="strRutaAnticipoGrupoDestino"></param>
		/// <param name="strRutaAnticipo"></param>
		/// <param name="floGalones"></param>
		/// <param name="curValorGalon"></param>
		/// <param name="cutCombustible"></param>
		/// <param name="lngIdNroPeajes"></param>
		/// <param name="cutPeaje"></param>
		/// <param name="cutVariosLlantas"></param>
		/// <param name="cutVariosCelada"></param>
		/// <param name="cutVariosPropina"></param>
		/// <param name="cutVarios"></param>
		/// <param name="cutVariosLlantasVacio"></param>
		/// <param name="cutVariosCeladaVacio"></param>
		/// <param name="cutVariosPropinaVacio"></param>
		/// <param name="cutVariosVacio"></param>
		/// <param name="CurCargue"></param>
		/// <param name="CurDescargue"></param>
		/// <param name="curHotel"></param>
		/// <param name="curHotelCarreteraVacio"></param>
		/// <param name="curHotelCiudadVacio"></param>
		/// <param name="curHotelVacio"></param>
		/// <param name="intTotalTiempo"></param>
		/// <param name="curComida"></param>
		/// <param name="intTotalTiempoVacio"></param>
		/// <param name="curComidaVacio"></param>
		/// <param name="cutParticipacion"></param>
		/// <param name="cutParticipacionVacio"></param>
		/// <param name="curDesvareManoRepuestos"></param>
		/// <param name="curDesvareManoObra"></param>
		/// <param name="cutKmts"></param>
		/// <param name="logVacio"></param>
		/// <param name="ParqueaderoCarretera"></param>
		/// <param name="ParqueaderoCiudad"></param>
		/// <param name="MontadaLLantaCarretera"></param>
		/// <param name="Papeleria"></param>
		/// <param name="AjusteCarretera"></param>
		/// <param name="CombustibleCarretera"></param>
		/// <param name="Amarres_Amarres_1000"></param>
		/// <param name="Engradasa"></param>
		/// <param name="Calibrada"></param>
		/// <param name="TipoVehiculoCodigo"></param>
		/// <param name="TipoVehiculo"></param>
		/// <param name="TipoTrailerCodigo"></param>
		/// <param name="Peso"></param>
		/// <param name="logEstadoRuta"></param>
		/// <param name="Trailer"></param>
		/// <param name="Aseo"></param>
		/// <param name="Contenedor1"></param>
		/// <param name="Contenedor2"></param>
		/// <param name="FactorCalculoDia"></param>
		/// <param name="ValorCalculoFactor"></param>
		/// <param name="Liquidado"></param>
		/// <param name="Taxi"></param>
		/// <param name="logFavorito"></param>
		/// <param name="logAnticipoACPM"></param>
		public void Update(long Codigo, bool logAsigna_Chk_600, long lngIdRegistrRuta, string strRutaAnticipoGrupoOrigen, string strRutaAnticipoGrupoDestino, string strRutaAnticipo, decimal floGalones, decimal curValorGalon, decimal cutCombustible, int lngIdNroPeajes, decimal cutPeaje, decimal cutVariosLlantas, decimal cutVariosCelada, decimal cutVariosPropina, decimal cutVarios, decimal cutVariosLlantasVacio, decimal cutVariosCeladaVacio, decimal cutVariosPropinaVacio, decimal cutVariosVacio, decimal CurCargue, decimal CurDescargue, decimal curHotel, decimal curHotelCarreteraVacio, decimal curHotelCiudadVacio, decimal curHotelVacio, decimal intTotalTiempo, decimal curComida, decimal intTotalTiempoVacio, decimal curComidaVacio, decimal cutParticipacion, decimal cutParticipacionVacio, decimal curDesvareManoRepuestos, decimal curDesvareManoObra, decimal cutKmts, bool logVacio, decimal ParqueaderoCarretera, decimal ParqueaderoCiudad, decimal MontadaLLantaCarretera, decimal Papeleria, decimal AjusteCarretera, decimal CombustibleCarretera, decimal Amarres_Amarres_1000, decimal Engradasa, decimal Calibrada, int TipoVehiculoCodigo, string TipoVehiculo, int TipoTrailerCodigo, int Peso, bool logEstadoRuta, string Trailer, decimal Aseo, string Contenedor1, string Contenedor2, int FactorCalculoDia, int ValorCalculoFactor, bool Liquidado, decimal Taxi, bool logFavorito, bool logAnticipoACPM,string module, Sinapsys.Datos.SQL datosTransaccion=null)
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
				paramlist.AddWithValue("@logAsigna_Chk_600",logAsigna_Chk_600);
				paramlist.AddWithValue("@lngIdRegistrRuta",lngIdRegistrRuta);
				paramlist.AddWithValue("@strRutaAnticipoGrupoOrigen",strRutaAnticipoGrupoOrigen);
				paramlist.AddWithValue("@strRutaAnticipoGrupoDestino",strRutaAnticipoGrupoDestino);
				paramlist.AddWithValue("@strRutaAnticipo",strRutaAnticipo);
				paramlist.AddWithValue("@floGalones",floGalones);
				paramlist.AddWithValue("@curValorGalon",curValorGalon);
				paramlist.AddWithValue("@cutCombustible",cutCombustible);
				paramlist.AddWithValue("@lngIdNroPeajes",lngIdNroPeajes);
				paramlist.AddWithValue("@cutPeaje",cutPeaje);
				paramlist.AddWithValue("@cutVariosLlantas",cutVariosLlantas);
				paramlist.AddWithValue("@cutVariosCelada",cutVariosCelada);
				paramlist.AddWithValue("@cutVariosPropina",cutVariosPropina);
				paramlist.AddWithValue("@cutVarios",cutVarios);
				paramlist.AddWithValue("@cutVariosLlantasVacio",cutVariosLlantasVacio);
				paramlist.AddWithValue("@cutVariosCeladaVacio",cutVariosCeladaVacio);
				paramlist.AddWithValue("@cutVariosPropinaVacio",cutVariosPropinaVacio);
				paramlist.AddWithValue("@cutVariosVacio",cutVariosVacio);
				paramlist.AddWithValue("@CurCargue",CurCargue);
				paramlist.AddWithValue("@CurDescargue",CurDescargue);
				paramlist.AddWithValue("@curHotel",curHotel);
				paramlist.AddWithValue("@curHotelCarreteraVacio",curHotelCarreteraVacio);
				paramlist.AddWithValue("@curHotelCiudadVacio",curHotelCiudadVacio);
				paramlist.AddWithValue("@curHotelVacio",curHotelVacio);
				paramlist.AddWithValue("@intTotalTiempo",intTotalTiempo);
				paramlist.AddWithValue("@curComida",curComida);
				paramlist.AddWithValue("@intTotalTiempoVacio",intTotalTiempoVacio);
				paramlist.AddWithValue("@curComidaVacio",curComidaVacio);
				paramlist.AddWithValue("@cutParticipacion",cutParticipacion);
				paramlist.AddWithValue("@cutParticipacionVacio",cutParticipacionVacio);
				paramlist.AddWithValue("@curDesvareManoRepuestos",curDesvareManoRepuestos);
				paramlist.AddWithValue("@curDesvareManoObra",curDesvareManoObra);
				paramlist.AddWithValue("@cutKmts",cutKmts);
				paramlist.AddWithValue("@logVacio",logVacio);
				paramlist.AddWithValue("@ParqueaderoCarretera",ParqueaderoCarretera);
				paramlist.AddWithValue("@ParqueaderoCiudad",ParqueaderoCiudad);
				paramlist.AddWithValue("@MontadaLLantaCarretera",MontadaLLantaCarretera);
				paramlist.AddWithValue("@Papeleria",Papeleria);
				paramlist.AddWithValue("@AjusteCarretera",AjusteCarretera);
				paramlist.AddWithValue("@CombustibleCarretera",CombustibleCarretera);
				paramlist.AddWithValue("@Amarres_Amarres_1000",Amarres_Amarres_1000);
				paramlist.AddWithValue("@Engradasa",Engradasa);
				paramlist.AddWithValue("@Calibrada",Calibrada);
				paramlist.AddWithValue("@TipoVehiculoCodigo",TipoVehiculoCodigo);
				paramlist.AddWithValue("@TipoVehiculo",TipoVehiculo);
				paramlist.AddWithValue("@TipoTrailerCodigo",TipoTrailerCodigo);
				paramlist.AddWithValue("@Peso",Peso);
				paramlist.AddWithValue("@logEstadoRuta",logEstadoRuta);
				paramlist.AddWithValue("@Trailer",Trailer);
				paramlist.AddWithValue("@Aseo",Aseo);
				paramlist.AddWithValue("@Contenedor1",Contenedor1);
				paramlist.AddWithValue("@Contenedor2",Contenedor2);
				paramlist.AddWithValue("@FactorCalculoDia",FactorCalculoDia);
				paramlist.AddWithValue("@ValorCalculoFactor",ValorCalculoFactor);
				paramlist.AddWithValue("@Liquidado",Liquidado);
				paramlist.AddWithValue("@Taxi",Taxi);
				paramlist.AddWithValue("@logFavorito",logFavorito);
				paramlist.AddWithValue("@logAnticipoACPM",logAnticipoACPM);
				LocalDataProvider.EjecutarProcedimiento("dbo.RutasDetTramosUpdate", paramlist, disconnect, out nullExit, DataProvider.TiempoEspera);
			}
			catch (Exception ex)
			{
				Utilidades.LogErrores(ex.Message + (ex.InnerException != null ? ex.InnerException.Message : ""), DataProvider.AplicacionNombre);
				throw ex;
			}
		}

		/// <summary>
		/// Deletes one record from RutasDetTramos by passing all key fields
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
				LocalDataProvider.EjecutarProcedimiento("dbo.RutasDetTramosDelete", paramlist, disconnect, out nullExit, DataProvider.TiempoEspera);
			}
			catch (Exception ex)
			{
				Utilidades.LogErrores(ex.Message + (ex.InnerException != null ? ex.InnerException.Message : ""), DataProvider.AplicacionNombre);
				throw ex;
			}
		}

		/// <summary>
		/// Gets one record from RutasDetTramos passing all key fields
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
				return LocalDataProvider.EjecutarProcedimiento("dbo.RutasDetTramosGet", paramlist, disconnect, out nullExit, DataProvider.TiempoEspera);

			}
			catch (Exception ex)
			{
				Utilidades.LogErrores(ex.Message + (ex.InnerException != null ? ex.InnerException.Message : ""), DataProvider.AplicacionNombre);
				throw ex;
			}
		}

		/// <summary>
		/// Gets all records from RutasDetTramos
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
				return LocalDataProvider.EjecutarProcedimiento("dbo.RutasDetTramosGetAll", paramlist, disconnect, out nullExit, DataProvider.TiempoEspera);
			}
			catch (Exception ex)
			{
				Utilidades.LogErrores(ex.Message + (ex.InnerException != null ? ex.InnerException.Message : ""), DataProvider.AplicacionNombre);
				throw ex;
			}
		}

		/// <summary>
		/// Gets all records from RutasDetTramos applying filter and sort criteria
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

				return LocalDataProvider.EjecutarProcedimiento("dbo.RutasDetTramosGetFilter", paramlist, disconnect, out nullExit, DataProvider.TiempoEspera);
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
		/// Gets the numbers of records from RutasDetTramos applying filter and sort criteria
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

				return (int) LocalDataProvider.EjecutarProcedimiento("dbo.RutasDetTramosGetFilter", paramlist, disconnect, out nullExit, DataProvider.TiempoEspera).Rows[0][0];
			}
			catch (Exception ex)
			{
				Utilidades.LogErrores(ex.Message + (ex.InnerException != null ? ex.InnerException.Message : ""), DataProvider.AplicacionNombre);
				throw ex;
			}
		}

	}
}
