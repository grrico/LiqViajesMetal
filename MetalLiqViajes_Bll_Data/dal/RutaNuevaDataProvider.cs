using System;
using System.Data;
using System.Data.Common;
using Sinapsys.Datos;
using LiqViajes_Bll_Data.Security;
using System.Runtime.Serialization;

namespace LiqViajes_Bll_Data
{
	/// <summary>
	/// Data Access Layer class for RutaNueva object
	/// </summary>
	/// <remarks>
	/// This class is a Singleton
	/// </remarks>
	public partial class RutaNuevaDataProvider
	{
		/// <summary>
		/// Internal member for create this singleton
		/// </summary>
		private static RutaNuevaDataProvider MySingleObj = null;

		/// <summary>
		/// Protected constructor to avoid access this singleton other way than calling the Instance method
		/// </summary>
		public RutaNuevaDataProvider()
		{

		}

		/// <summary>
		/// Instance accessor for this singleton
		/// </summary>
		public static RutaNuevaDataProvider Instance
		{
			get
			{
				if (MySingleObj == null)
				{
					MySingleObj = new RutaNuevaDataProvider();
				}

				return MySingleObj;
			}
		}

		/// <summary>
		/// Creates a new record into RutaNueva by passing all fields
		/// </summary>
		/// <param name="strRutaAnticipoGrupoOrigen"></param>
		/// <param name="strRutaAnticipoGrupoDestino"></param>
		/// <param name="strRutaAnticipoGrupo"></param>
		/// <param name="strRutaAnticipo"></param>
		/// <param name="TipoVehiculoCodigo"></param>
		/// <param name="TipoVehiculo"></param>
		/// <param name="TipoTrailerCodigo"></param>
		/// <param name="Peso"></param>
		/// <param name="Programa"></param>
		/// <param name="logViajeVacio"></param>
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
		/// <param name="Llamadas"></param>
		/// <param name="Taxis"></param>
		/// <param name="Aseo"></param>
		/// <param name="cutVariosLlantasVacio"></param>
		/// <param name="cutVariosCeladaVacio"></param>
		/// <param name="cutVariosPropinaVacio"></param>
		/// <param name="cutVariosVacio"></param>
		/// <param name="Viaticos"></param>
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
		/// <param name="cutSaldoVacio"></param>
		/// <param name="cutKmts"></param>
		/// <param name="logActualizaPeajes"></param>
		/// <param name="intFactorKmPorGalon"></param>
		/// <param name="logEstadoRuta"></param>
		public void Create(int lngIdRegistrRuta, string strRutaAnticipoGrupoOrigen, string strRutaAnticipoGrupoDestino, string strRutaAnticipoGrupo, string strRutaAnticipo, double? TipoVehiculoCodigo, string TipoVehiculo, double? TipoTrailerCodigo, double? Peso, string Programa, double? logViajeVacio, double? floGalones, double? curValorGalon, double? cutCombustible, double? lngIdNroPeajes, double? cutPeaje, string strNombrePeajes, double? cutVariosLlantas, double? cutVariosCelada, double? cutVariosPropina, double? cutVarios, double? Llamadas, double? Taxis, double? Aseo, double? cutVariosLlantasVacio, double? cutVariosCeladaVacio, double? cutVariosPropinaVacio, double? cutVariosVacio, double? Viaticos, double? cutParticipacion, double? cutParticipacionVacio, double? curHotelCarretera, double? curHotelCiudad, double? curHotel, double? curHotelCarreteraVacio, double? curHotelCiudadVacio, double? curHotelVacio, double? intTiempoCargue, double? intTiempoDescargue, double? intTiempoAduana, double? intTotalTrayecto, double? intTotalTiempo, double? curComida, double? intTiempoCargueVacio, double? intTiempoDescargueVacio, double? intTiempoAduanaVacio, double? intTotalTrayectoVacio, double? intTotalTiempoVacio, double? curComidaVacio, double? curDesvareManoRepuestos, double? curDesvareManoObra, double? cutSaldo, double? cutSaldoVacio, double? cutKmts, double? logActualizaPeajes, double? intFactorKmPorGalon, double? logEstadoRuta,string module, Sinapsys.Datos.SQL datosTransaccion=null)
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
				if (TipoVehiculoCodigo !=null)
				{
					paramlist.AddWithValue("@TipoVehiculoCodigo",TipoVehiculoCodigo);
				}
				if (TipoVehiculo !=null)
				{
					paramlist.AddWithValue("@TipoVehiculo",TipoVehiculo);
				}
				if (TipoTrailerCodigo !=null)
				{
					paramlist.AddWithValue("@TipoTrailerCodigo",TipoTrailerCodigo);
				}
				if (Peso !=null)
				{
					paramlist.AddWithValue("@Peso",Peso);
				}
				if (Programa !=null)
				{
					paramlist.AddWithValue("@Programa",Programa);
				}
				if (logViajeVacio !=null)
				{
					paramlist.AddWithValue("@logViajeVacio",logViajeVacio);
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
				if (Llamadas !=null)
				{
					paramlist.AddWithValue("@Llamadas",Llamadas);
				}
				if (Taxis !=null)
				{
					paramlist.AddWithValue("@Taxis",Taxis);
				}
				if (Aseo !=null)
				{
					paramlist.AddWithValue("@Aseo",Aseo);
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
				if (Viaticos !=null)
				{
					paramlist.AddWithValue("@Viaticos",Viaticos);
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
				if (cutSaldoVacio !=null)
				{
					paramlist.AddWithValue("@cutSaldoVacio",cutSaldoVacio);
				}
				if (cutKmts !=null)
				{
					paramlist.AddWithValue("@cutKmts",cutKmts);
				}
				if (logActualizaPeajes !=null)
				{
					paramlist.AddWithValue("@logActualizaPeajes",logActualizaPeajes);
				}
				if (intFactorKmPorGalon !=null)
				{
					paramlist.AddWithValue("@intFactorKmPorGalon",intFactorKmPorGalon);
				}
				if (logEstadoRuta !=null)
				{
					paramlist.AddWithValue("@logEstadoRuta",logEstadoRuta);
				}
				LocalDataProvider.EjecutarProcedimiento("dbo.RutaNuevaCreate", paramlist, disconnect, out nullExit, DataProvider.TiempoEspera);
			}
			catch (Exception ex)
			{
				Utilidades.LogErrores(ex.Message + (ex.InnerException != null ? ex.InnerException.Message : ""), DataProvider.AplicacionNombre);
				throw ex;
			}
		}

		/// <summary>
		/// Updates one record into RutaNueva by passing all fields
		/// </summary>
		/// <param name="strRutaAnticipoGrupoOrigen"></param>
		/// <param name="strRutaAnticipoGrupoDestino"></param>
		/// <param name="strRutaAnticipoGrupo"></param>
		/// <param name="strRutaAnticipo"></param>
		/// <param name="TipoVehiculoCodigo"></param>
		/// <param name="TipoVehiculo"></param>
		/// <param name="TipoTrailerCodigo"></param>
		/// <param name="Peso"></param>
		/// <param name="Programa"></param>
		/// <param name="logViajeVacio"></param>
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
		/// <param name="Llamadas"></param>
		/// <param name="Taxis"></param>
		/// <param name="Aseo"></param>
		/// <param name="cutVariosLlantasVacio"></param>
		/// <param name="cutVariosCeladaVacio"></param>
		/// <param name="cutVariosPropinaVacio"></param>
		/// <param name="cutVariosVacio"></param>
		/// <param name="Viaticos"></param>
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
		/// <param name="cutSaldoVacio"></param>
		/// <param name="cutKmts"></param>
		/// <param name="logActualizaPeajes"></param>
		/// <param name="intFactorKmPorGalon"></param>
		/// <param name="logEstadoRuta"></param>
		/// <param name="lngIdRegistrRuta"></param>
		public void Update(string strRutaAnticipoGrupoOrigen, string strRutaAnticipoGrupoDestino, string strRutaAnticipoGrupo, string strRutaAnticipo, double? TipoVehiculoCodigo, string TipoVehiculo, double? TipoTrailerCodigo, double? Peso, string Programa, double? logViajeVacio, double? floGalones, double? curValorGalon, double? cutCombustible, double? lngIdNroPeajes, double? cutPeaje, string strNombrePeajes, double? cutVariosLlantas, double? cutVariosCelada, double? cutVariosPropina, double? cutVarios, double? Llamadas, double? Taxis, double? Aseo, double? cutVariosLlantasVacio, double? cutVariosCeladaVacio, double? cutVariosPropinaVacio, double? cutVariosVacio, double? Viaticos, double? cutParticipacion, double? cutParticipacionVacio, double? curHotelCarretera, double? curHotelCiudad, double? curHotel, double? curHotelCarreteraVacio, double? curHotelCiudadVacio, double? curHotelVacio, double? intTiempoCargue, double? intTiempoDescargue, double? intTiempoAduana, double? intTotalTrayecto, double? intTotalTiempo, double? curComida, double? intTiempoCargueVacio, double? intTiempoDescargueVacio, double? intTiempoAduanaVacio, double? intTotalTrayectoVacio, double? intTotalTiempoVacio, double? curComidaVacio, double? curDesvareManoRepuestos, double? curDesvareManoObra, double? cutSaldo, double? cutSaldoVacio, double? cutKmts, double? logActualizaPeajes, double? intFactorKmPorGalon, double? logEstadoRuta, int lngIdRegistrRuta,string module, Sinapsys.Datos.SQL datosTransaccion=null)
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
				if (TipoVehiculoCodigo !=null)
				{
					paramlist.AddWithValue("@TipoVehiculoCodigo",TipoVehiculoCodigo);
				}
				if (TipoVehiculo !=null)
				{
					paramlist.AddWithValue("@TipoVehiculo",TipoVehiculo);
				}
				if (TipoTrailerCodigo !=null)
				{
					paramlist.AddWithValue("@TipoTrailerCodigo",TipoTrailerCodigo);
				}
				if (Peso !=null)
				{
					paramlist.AddWithValue("@Peso",Peso);
				}
				if (Programa !=null)
				{
					paramlist.AddWithValue("@Programa",Programa);
				}
				if (logViajeVacio !=null)
				{
					paramlist.AddWithValue("@logViajeVacio",logViajeVacio);
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
				if (Llamadas !=null)
				{
					paramlist.AddWithValue("@Llamadas",Llamadas);
				}
				if (Taxis !=null)
				{
					paramlist.AddWithValue("@Taxis",Taxis);
				}
				if (Aseo !=null)
				{
					paramlist.AddWithValue("@Aseo",Aseo);
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
				if (Viaticos !=null)
				{
					paramlist.AddWithValue("@Viaticos",Viaticos);
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
				if (cutSaldoVacio !=null)
				{
					paramlist.AddWithValue("@cutSaldoVacio",cutSaldoVacio);
				}
				if (cutKmts !=null)
				{
					paramlist.AddWithValue("@cutKmts",cutKmts);
				}
				if (logActualizaPeajes !=null)
				{
					paramlist.AddWithValue("@logActualizaPeajes",logActualizaPeajes);
				}
				if (intFactorKmPorGalon !=null)
				{
					paramlist.AddWithValue("@intFactorKmPorGalon",intFactorKmPorGalon);
				}
				if (logEstadoRuta !=null)
				{
					paramlist.AddWithValue("@logEstadoRuta",logEstadoRuta);
				}
				LocalDataProvider.EjecutarProcedimiento("dbo.RutaNuevaUpdate", paramlist, disconnect, out nullExit, DataProvider.TiempoEspera);
			}
			catch (Exception ex)
			{
				Utilidades.LogErrores(ex.Message + (ex.InnerException != null ? ex.InnerException.Message : ""), DataProvider.AplicacionNombre);
				throw ex;
			}
		}

		/// <summary>
		/// Deletes one record from RutaNueva by passing all key fields
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
				LocalDataProvider.EjecutarProcedimiento("dbo.RutaNuevaDelete", paramlist, disconnect, out nullExit, DataProvider.TiempoEspera);
			}
			catch (Exception ex)
			{
				Utilidades.LogErrores(ex.Message + (ex.InnerException != null ? ex.InnerException.Message : ""), DataProvider.AplicacionNombre);
				throw ex;
			}
		}

		/// <summary>
		/// Gets one record from RutaNueva passing all key fields
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
				return LocalDataProvider.EjecutarProcedimiento("dbo.RutaNuevaGet", paramlist, disconnect, out nullExit, DataProvider.TiempoEspera);

			}
			catch (Exception ex)
			{
				Utilidades.LogErrores(ex.Message + (ex.InnerException != null ? ex.InnerException.Message : ""), DataProvider.AplicacionNombre);
				throw ex;
			}
		}

		/// <summary>
		/// Gets all records from RutaNueva
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
				return LocalDataProvider.EjecutarProcedimiento("dbo.RutaNuevaGetAll", paramlist, disconnect, out nullExit, DataProvider.TiempoEspera);
			}
			catch (Exception ex)
			{
				Utilidades.LogErrores(ex.Message + (ex.InnerException != null ? ex.InnerException.Message : ""), DataProvider.AplicacionNombre);
				throw ex;
			}
		}

		/// <summary>
		/// Gets all records from RutaNueva applying filter and sort criteria
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

				return LocalDataProvider.EjecutarProcedimiento("dbo.RutaNuevaGetFilter", paramlist, disconnect, out nullExit, DataProvider.TiempoEspera);
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
		/// Gets the numbers of records from RutaNueva applying filter and sort criteria
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

				return (int) LocalDataProvider.EjecutarProcedimiento("dbo.RutaNuevaGetFilter", paramlist, disconnect, out nullExit, DataProvider.TiempoEspera).Rows[0][0];
			}
			catch (Exception ex)
			{
				Utilidades.LogErrores(ex.Message + (ex.InnerException != null ? ex.InnerException.Message : ""), DataProvider.AplicacionNombre);
				throw ex;
			}
		}

	}
}
