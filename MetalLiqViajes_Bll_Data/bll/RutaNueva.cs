using System;
using System.Data;
using System.Data.Common;
using System.Xml;
using System.Xml.Serialization;
using System.Xml.Schema;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.IO;
using Sinapsys.Datos;
using Microsoft.Practices.EnterpriseLibrary.Security.Cryptography;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Runtime.Serialization;

namespace LiqViajes_Bll_Data
{
	#region RutaNuevaController

	/// <summary>
	/// Class for convert data from database into object's data and vice versa
	/// </summary>
	public partial class RutaNuevaController//: ILatinodeController
	{
		/// <summary>
		/// Generic Constructor
		/// </summary>
		public RutaNuevaController()
		{
		}

		/// <summary>
		/// Instance accessor for this singleton
		/// </summary>
		private static RutaNuevaController MySingleObj;
		public static RutaNuevaController Instance
		{
			get
			{
				if (MySingleObj == null)
				{
					MySingleObj = new RutaNuevaController();
				}
				return MySingleObj;
			}
		}

		// Reads object's data from a DataRow
		private void ReadData(RutaNueva rutanueva, DataRow dr,bool generateUndo=false)
		{
			try 
			{
				rutanueva.lngIdRegistrRuta = (int) dr["lngIdRegistrRuta"];
				rutanueva.strRutaAnticipoGrupoOrigen = dr.IsNull("strRutaAnticipoGrupoOrigen") ? null :(string) dr["strRutaAnticipoGrupoOrigen"];
				rutanueva.strRutaAnticipoGrupoDestino = dr.IsNull("strRutaAnticipoGrupoDestino") ? null :(string) dr["strRutaAnticipoGrupoDestino"];
				rutanueva.strRutaAnticipoGrupo = dr.IsNull("strRutaAnticipoGrupo") ? null :(string) dr["strRutaAnticipoGrupo"];
				rutanueva.strRutaAnticipo = dr.IsNull("strRutaAnticipo") ? null :(string) dr["strRutaAnticipo"];
				rutanueva.TipoVehiculoCodigo = dr.IsNull("TipoVehiculoCodigo") ? null :(double?) dr["TipoVehiculoCodigo"];
				rutanueva.TipoVehiculo = dr.IsNull("TipoVehiculo") ? null :(string) dr["TipoVehiculo"];
				rutanueva.TipoTrailerCodigo = dr.IsNull("TipoTrailerCodigo") ? null :(double?) dr["TipoTrailerCodigo"];
				rutanueva.Peso = dr.IsNull("Peso") ? null :(double?) dr["Peso"];
				rutanueva.Programa = dr.IsNull("Programa") ? null :(string) dr["Programa"];
				rutanueva.logViajeVacio = dr.IsNull("logViajeVacio") ? null :(double?) dr["logViajeVacio"];
				rutanueva.floGalones = dr.IsNull("floGalones") ? null :(double?) dr["floGalones"];
				rutanueva.curValorGalon = dr.IsNull("curValorGalon") ? null :(double?) dr["curValorGalon"];
				rutanueva.cutCombustible = dr.IsNull("cutCombustible") ? null :(double?) dr["cutCombustible"];
				rutanueva.lngIdNroPeajes = dr.IsNull("lngIdNroPeajes") ? null :(double?) dr["lngIdNroPeajes"];
				rutanueva.cutPeaje = dr.IsNull("cutPeaje") ? null :(double?) dr["cutPeaje"];
				rutanueva.strNombrePeajes = dr.IsNull("strNombrePeajes") ? null :(string) dr["strNombrePeajes"];
				rutanueva.cutVariosLlantas = dr.IsNull("cutVariosLlantas") ? null :(double?) dr["cutVariosLlantas"];
				rutanueva.cutVariosCelada = dr.IsNull("cutVariosCelada") ? null :(double?) dr["cutVariosCelada"];
				rutanueva.cutVariosPropina = dr.IsNull("cutVariosPropina") ? null :(double?) dr["cutVariosPropina"];
				rutanueva.cutVarios = dr.IsNull("cutVarios") ? null :(double?) dr["cutVarios"];
				rutanueva.Llamadas = dr.IsNull("Llamadas") ? null :(double?) dr["Llamadas"];
				rutanueva.Taxis = dr.IsNull("Taxis") ? null :(double?) dr["Taxis"];
				rutanueva.Aseo = dr.IsNull("Aseo") ? null :(double?) dr["Aseo"];
				rutanueva.cutVariosLlantasVacio = dr.IsNull("cutVariosLlantasVacio") ? null :(double?) dr["cutVariosLlantasVacio"];
				rutanueva.cutVariosCeladaVacio = dr.IsNull("cutVariosCeladaVacio") ? null :(double?) dr["cutVariosCeladaVacio"];
				rutanueva.cutVariosPropinaVacio = dr.IsNull("cutVariosPropinaVacio") ? null :(double?) dr["cutVariosPropinaVacio"];
				rutanueva.cutVariosVacio = dr.IsNull("cutVariosVacio") ? null :(double?) dr["cutVariosVacio"];
				rutanueva.Viaticos = dr.IsNull("Viaticos") ? null :(double?) dr["Viaticos"];
				rutanueva.cutParticipacion = dr.IsNull("cutParticipacion") ? null :(double?) dr["cutParticipacion"];
				rutanueva.cutParticipacionVacio = dr.IsNull("cutParticipacionVacio") ? null :(double?) dr["cutParticipacionVacio"];
				rutanueva.curHotelCarretera = dr.IsNull("curHotelCarretera") ? null :(double?) dr["curHotelCarretera"];
				rutanueva.curHotelCiudad = dr.IsNull("curHotelCiudad") ? null :(double?) dr["curHotelCiudad"];
				rutanueva.curHotel = dr.IsNull("curHotel") ? null :(double?) dr["curHotel"];
				rutanueva.curHotelCarreteraVacio = dr.IsNull("curHotelCarreteraVacio") ? null :(double?) dr["curHotelCarreteraVacio"];
				rutanueva.curHotelCiudadVacio = dr.IsNull("curHotelCiudadVacio") ? null :(double?) dr["curHotelCiudadVacio"];
				rutanueva.curHotelVacio = dr.IsNull("curHotelVacio") ? null :(double?) dr["curHotelVacio"];
				rutanueva.intTiempoCargue = dr.IsNull("intTiempoCargue") ? null :(double?) dr["intTiempoCargue"];
				rutanueva.intTiempoDescargue = dr.IsNull("intTiempoDescargue") ? null :(double?) dr["intTiempoDescargue"];
				rutanueva.intTiempoAduana = dr.IsNull("intTiempoAduana") ? null :(double?) dr["intTiempoAduana"];
				rutanueva.intTotalTrayecto = dr.IsNull("intTotalTrayecto") ? null :(double?) dr["intTotalTrayecto"];
				rutanueva.intTotalTiempo = dr.IsNull("intTotalTiempo") ? null :(double?) dr["intTotalTiempo"];
				rutanueva.curComida = dr.IsNull("curComida") ? null :(double?) dr["curComida"];
				rutanueva.intTiempoCargueVacio = dr.IsNull("intTiempoCargueVacio") ? null :(double?) dr["intTiempoCargueVacio"];
				rutanueva.intTiempoDescargueVacio = dr.IsNull("intTiempoDescargueVacio") ? null :(double?) dr["intTiempoDescargueVacio"];
				rutanueva.intTiempoAduanaVacio = dr.IsNull("intTiempoAduanaVacio") ? null :(double?) dr["intTiempoAduanaVacio"];
				rutanueva.intTotalTrayectoVacio = dr.IsNull("intTotalTrayectoVacio") ? null :(double?) dr["intTotalTrayectoVacio"];
				rutanueva.intTotalTiempoVacio = dr.IsNull("intTotalTiempoVacio") ? null :(double?) dr["intTotalTiempoVacio"];
				rutanueva.curComidaVacio = dr.IsNull("curComidaVacio") ? null :(double?) dr["curComidaVacio"];
				rutanueva.curDesvareManoRepuestos = dr.IsNull("curDesvareManoRepuestos") ? null :(double?) dr["curDesvareManoRepuestos"];
				rutanueva.curDesvareManoObra = dr.IsNull("curDesvareManoObra") ? null :(double?) dr["curDesvareManoObra"];
				rutanueva.cutSaldo = dr.IsNull("cutSaldo") ? null :(double?) dr["cutSaldo"];
				rutanueva.cutSaldoVacio = dr.IsNull("cutSaldoVacio") ? null :(double?) dr["cutSaldoVacio"];
				rutanueva.cutKmts = dr.IsNull("cutKmts") ? null :(double?) dr["cutKmts"];
				rutanueva.logActualizaPeajes = dr.IsNull("logActualizaPeajes") ? null :(double?) dr["logActualizaPeajes"];
				rutanueva.intFactorKmPorGalon = dr.IsNull("intFactorKmPorGalon") ? null :(double?) dr["intFactorKmPorGalon"];
				rutanueva.logEstadoRuta = dr.IsNull("logEstadoRuta") ? null :(double?) dr["logEstadoRuta"];
			}
			catch (Exception ex)
			{
				Utilidades.LogErrores(ex.Message + (ex.InnerException != null ? ex.InnerException.Message : ""), DataProvider.AplicacionNombre);
				throw ex;
			}
			if (generateUndo) rutanueva.GenerateUndo();
		}

		/// <summary>
		/// Create a new RutaNueva object by passing a object
		/// </summary>
		public RutaNueva Create(RutaNueva rutanueva, Sinapsys.Datos.SQL datosTransaccion=null)
		{
			return Create(rutanueva.lngIdRegistrRuta,rutanueva.strRutaAnticipoGrupoOrigen,rutanueva.strRutaAnticipoGrupoDestino,rutanueva.strRutaAnticipoGrupo,rutanueva.strRutaAnticipo,rutanueva.TipoVehiculoCodigo,rutanueva.TipoVehiculo,rutanueva.TipoTrailerCodigo,rutanueva.Peso,rutanueva.Programa,rutanueva.logViajeVacio,rutanueva.floGalones,rutanueva.curValorGalon,rutanueva.cutCombustible,rutanueva.lngIdNroPeajes,rutanueva.cutPeaje,rutanueva.strNombrePeajes,rutanueva.cutVariosLlantas,rutanueva.cutVariosCelada,rutanueva.cutVariosPropina,rutanueva.cutVarios,rutanueva.Llamadas,rutanueva.Taxis,rutanueva.Aseo,rutanueva.cutVariosLlantasVacio,rutanueva.cutVariosCeladaVacio,rutanueva.cutVariosPropinaVacio,rutanueva.cutVariosVacio,rutanueva.Viaticos,rutanueva.cutParticipacion,rutanueva.cutParticipacionVacio,rutanueva.curHotelCarretera,rutanueva.curHotelCiudad,rutanueva.curHotel,rutanueva.curHotelCarreteraVacio,rutanueva.curHotelCiudadVacio,rutanueva.curHotelVacio,rutanueva.intTiempoCargue,rutanueva.intTiempoDescargue,rutanueva.intTiempoAduana,rutanueva.intTotalTrayecto,rutanueva.intTotalTiempo,rutanueva.curComida,rutanueva.intTiempoCargueVacio,rutanueva.intTiempoDescargueVacio,rutanueva.intTiempoAduanaVacio,rutanueva.intTotalTrayectoVacio,rutanueva.intTotalTiempoVacio,rutanueva.curComidaVacio,rutanueva.curDesvareManoRepuestos,rutanueva.curDesvareManoObra,rutanueva.cutSaldo,rutanueva.cutSaldoVacio,rutanueva.cutKmts,rutanueva.logActualizaPeajes,rutanueva.intFactorKmPorGalon,rutanueva.logEstadoRuta,datosTransaccion);
		}

		/// <summary>
		/// Creates a new RutaNueva object by passing all object's fields
		/// </summary>
		/// <param name="strRutaAnticipoGrupoOrigen">string that contents the strRutaAnticipoGrupoOrigen value for the RutaNueva object</param>
		/// <param name="strRutaAnticipoGrupoDestino">string that contents the strRutaAnticipoGrupoDestino value for the RutaNueva object</param>
		/// <param name="strRutaAnticipoGrupo">string that contents the strRutaAnticipoGrupo value for the RutaNueva object</param>
		/// <param name="strRutaAnticipo">string that contents the strRutaAnticipo value for the RutaNueva object</param>
		/// <param name="TipoVehiculoCodigo">double that contents the TipoVehiculoCodigo value for the RutaNueva object</param>
		/// <param name="TipoVehiculo">string that contents the TipoVehiculo value for the RutaNueva object</param>
		/// <param name="TipoTrailerCodigo">double that contents the TipoTrailerCodigo value for the RutaNueva object</param>
		/// <param name="Peso">double that contents the Peso value for the RutaNueva object</param>
		/// <param name="Programa">string that contents the Programa value for the RutaNueva object</param>
		/// <param name="logViajeVacio">double that contents the logViajeVacio value for the RutaNueva object</param>
		/// <param name="floGalones">double that contents the floGalones value for the RutaNueva object</param>
		/// <param name="curValorGalon">double that contents the curValorGalon value for the RutaNueva object</param>
		/// <param name="cutCombustible">double that contents the cutCombustible value for the RutaNueva object</param>
		/// <param name="lngIdNroPeajes">double that contents the lngIdNroPeajes value for the RutaNueva object</param>
		/// <param name="cutPeaje">double that contents the cutPeaje value for the RutaNueva object</param>
		/// <param name="strNombrePeajes">string that contents the strNombrePeajes value for the RutaNueva object</param>
		/// <param name="cutVariosLlantas">double that contents the cutVariosLlantas value for the RutaNueva object</param>
		/// <param name="cutVariosCelada">double that contents the cutVariosCelada value for the RutaNueva object</param>
		/// <param name="cutVariosPropina">double that contents the cutVariosPropina value for the RutaNueva object</param>
		/// <param name="cutVarios">double that contents the cutVarios value for the RutaNueva object</param>
		/// <param name="Llamadas">double that contents the Llamadas value for the RutaNueva object</param>
		/// <param name="Taxis">double that contents the Taxis value for the RutaNueva object</param>
		/// <param name="Aseo">double that contents the Aseo value for the RutaNueva object</param>
		/// <param name="cutVariosLlantasVacio">double that contents the cutVariosLlantasVacio value for the RutaNueva object</param>
		/// <param name="cutVariosCeladaVacio">double that contents the cutVariosCeladaVacio value for the RutaNueva object</param>
		/// <param name="cutVariosPropinaVacio">double that contents the cutVariosPropinaVacio value for the RutaNueva object</param>
		/// <param name="cutVariosVacio">double that contents the cutVariosVacio value for the RutaNueva object</param>
		/// <param name="Viaticos">double that contents the Viaticos value for the RutaNueva object</param>
		/// <param name="cutParticipacion">double that contents the cutParticipacion value for the RutaNueva object</param>
		/// <param name="cutParticipacionVacio">double that contents the cutParticipacionVacio value for the RutaNueva object</param>
		/// <param name="curHotelCarretera">double that contents the curHotelCarretera value for the RutaNueva object</param>
		/// <param name="curHotelCiudad">double that contents the curHotelCiudad value for the RutaNueva object</param>
		/// <param name="curHotel">double that contents the curHotel value for the RutaNueva object</param>
		/// <param name="curHotelCarreteraVacio">double that contents the curHotelCarreteraVacio value for the RutaNueva object</param>
		/// <param name="curHotelCiudadVacio">double that contents the curHotelCiudadVacio value for the RutaNueva object</param>
		/// <param name="curHotelVacio">double that contents the curHotelVacio value for the RutaNueva object</param>
		/// <param name="intTiempoCargue">double that contents the intTiempoCargue value for the RutaNueva object</param>
		/// <param name="intTiempoDescargue">double that contents the intTiempoDescargue value for the RutaNueva object</param>
		/// <param name="intTiempoAduana">double that contents the intTiempoAduana value for the RutaNueva object</param>
		/// <param name="intTotalTrayecto">double that contents the intTotalTrayecto value for the RutaNueva object</param>
		/// <param name="intTotalTiempo">double that contents the intTotalTiempo value for the RutaNueva object</param>
		/// <param name="curComida">double that contents the curComida value for the RutaNueva object</param>
		/// <param name="intTiempoCargueVacio">double that contents the intTiempoCargueVacio value for the RutaNueva object</param>
		/// <param name="intTiempoDescargueVacio">double that contents the intTiempoDescargueVacio value for the RutaNueva object</param>
		/// <param name="intTiempoAduanaVacio">double that contents the intTiempoAduanaVacio value for the RutaNueva object</param>
		/// <param name="intTotalTrayectoVacio">double that contents the intTotalTrayectoVacio value for the RutaNueva object</param>
		/// <param name="intTotalTiempoVacio">double that contents the intTotalTiempoVacio value for the RutaNueva object</param>
		/// <param name="curComidaVacio">double that contents the curComidaVacio value for the RutaNueva object</param>
		/// <param name="curDesvareManoRepuestos">double that contents the curDesvareManoRepuestos value for the RutaNueva object</param>
		/// <param name="curDesvareManoObra">double that contents the curDesvareManoObra value for the RutaNueva object</param>
		/// <param name="cutSaldo">double that contents the cutSaldo value for the RutaNueva object</param>
		/// <param name="cutSaldoVacio">double that contents the cutSaldoVacio value for the RutaNueva object</param>
		/// <param name="cutKmts">double that contents the cutKmts value for the RutaNueva object</param>
		/// <param name="logActualizaPeajes">double that contents the logActualizaPeajes value for the RutaNueva object</param>
		/// <param name="intFactorKmPorGalon">double that contents the intFactorKmPorGalon value for the RutaNueva object</param>
		/// <param name="logEstadoRuta">double that contents the logEstadoRuta value for the RutaNueva object</param>
		/// <returns>One RutaNueva object</returns>
		public RutaNueva Create(int lngIdRegistrRuta, string strRutaAnticipoGrupoOrigen, string strRutaAnticipoGrupoDestino, string strRutaAnticipoGrupo, string strRutaAnticipo, double? TipoVehiculoCodigo, string TipoVehiculo, double? TipoTrailerCodigo, double? Peso, string Programa, double? logViajeVacio, double? floGalones, double? curValorGalon, double? cutCombustible, double? lngIdNroPeajes, double? cutPeaje, string strNombrePeajes, double? cutVariosLlantas, double? cutVariosCelada, double? cutVariosPropina, double? cutVarios, double? Llamadas, double? Taxis, double? Aseo, double? cutVariosLlantasVacio, double? cutVariosCeladaVacio, double? cutVariosPropinaVacio, double? cutVariosVacio, double? Viaticos, double? cutParticipacion, double? cutParticipacionVacio, double? curHotelCarretera, double? curHotelCiudad, double? curHotel, double? curHotelCarreteraVacio, double? curHotelCiudadVacio, double? curHotelVacio, double? intTiempoCargue, double? intTiempoDescargue, double? intTiempoAduana, double? intTotalTrayecto, double? intTotalTiempo, double? curComida, double? intTiempoCargueVacio, double? intTiempoDescargueVacio, double? intTiempoAduanaVacio, double? intTotalTrayectoVacio, double? intTotalTiempoVacio, double? curComidaVacio, double? curDesvareManoRepuestos, double? curDesvareManoObra, double? cutSaldo, double? cutSaldoVacio, double? cutKmts, double? logActualizaPeajes, double? intFactorKmPorGalon, double? logEstadoRuta, Sinapsys.Datos.SQL datosTransaccion=null)
		{
			try 
			{
				RutaNueva rutanueva = new RutaNueva();

				rutanueva.lngIdRegistrRuta = lngIdRegistrRuta;
				rutanueva.strRutaAnticipoGrupoOrigen = strRutaAnticipoGrupoOrigen;
				rutanueva.strRutaAnticipoGrupoDestino = strRutaAnticipoGrupoDestino;
				rutanueva.strRutaAnticipoGrupo = strRutaAnticipoGrupo;
				rutanueva.strRutaAnticipo = strRutaAnticipo;
				rutanueva.TipoVehiculoCodigo = TipoVehiculoCodigo;
				rutanueva.TipoVehiculo = TipoVehiculo;
				rutanueva.TipoTrailerCodigo = TipoTrailerCodigo;
				rutanueva.Peso = Peso;
				rutanueva.Programa = Programa;
				rutanueva.logViajeVacio = logViajeVacio;
				rutanueva.floGalones = floGalones;
				rutanueva.curValorGalon = curValorGalon;
				rutanueva.cutCombustible = cutCombustible;
				rutanueva.lngIdNroPeajes = lngIdNroPeajes;
				rutanueva.cutPeaje = cutPeaje;
				rutanueva.strNombrePeajes = strNombrePeajes;
				rutanueva.cutVariosLlantas = cutVariosLlantas;
				rutanueva.cutVariosCelada = cutVariosCelada;
				rutanueva.cutVariosPropina = cutVariosPropina;
				rutanueva.cutVarios = cutVarios;
				rutanueva.Llamadas = Llamadas;
				rutanueva.Taxis = Taxis;
				rutanueva.Aseo = Aseo;
				rutanueva.cutVariosLlantasVacio = cutVariosLlantasVacio;
				rutanueva.cutVariosCeladaVacio = cutVariosCeladaVacio;
				rutanueva.cutVariosPropinaVacio = cutVariosPropinaVacio;
				rutanueva.cutVariosVacio = cutVariosVacio;
				rutanueva.Viaticos = Viaticos;
				rutanueva.cutParticipacion = cutParticipacion;
				rutanueva.cutParticipacionVacio = cutParticipacionVacio;
				rutanueva.curHotelCarretera = curHotelCarretera;
				rutanueva.curHotelCiudad = curHotelCiudad;
				rutanueva.curHotel = curHotel;
				rutanueva.curHotelCarreteraVacio = curHotelCarreteraVacio;
				rutanueva.curHotelCiudadVacio = curHotelCiudadVacio;
				rutanueva.curHotelVacio = curHotelVacio;
				rutanueva.intTiempoCargue = intTiempoCargue;
				rutanueva.intTiempoDescargue = intTiempoDescargue;
				rutanueva.intTiempoAduana = intTiempoAduana;
				rutanueva.intTotalTrayecto = intTotalTrayecto;
				rutanueva.intTotalTiempo = intTotalTiempo;
				rutanueva.curComida = curComida;
				rutanueva.intTiempoCargueVacio = intTiempoCargueVacio;
				rutanueva.intTiempoDescargueVacio = intTiempoDescargueVacio;
				rutanueva.intTiempoAduanaVacio = intTiempoAduanaVacio;
				rutanueva.intTotalTrayectoVacio = intTotalTrayectoVacio;
				rutanueva.intTotalTiempoVacio = intTotalTiempoVacio;
				rutanueva.curComidaVacio = curComidaVacio;
				rutanueva.curDesvareManoRepuestos = curDesvareManoRepuestos;
				rutanueva.curDesvareManoObra = curDesvareManoObra;
				rutanueva.cutSaldo = cutSaldo;
				rutanueva.cutSaldoVacio = cutSaldoVacio;
				rutanueva.cutKmts = cutKmts;
				rutanueva.logActualizaPeajes = logActualizaPeajes;
				rutanueva.intFactorKmPorGalon = intFactorKmPorGalon;
				rutanueva.logEstadoRuta = logEstadoRuta;
				RutaNuevaDataProvider.Instance.Create(lngIdRegistrRuta, strRutaAnticipoGrupoOrigen, strRutaAnticipoGrupoDestino, strRutaAnticipoGrupo, strRutaAnticipo, TipoVehiculoCodigo, TipoVehiculo, TipoTrailerCodigo, Peso, Programa, logViajeVacio, floGalones, curValorGalon, cutCombustible, lngIdNroPeajes, cutPeaje, strNombrePeajes, cutVariosLlantas, cutVariosCelada, cutVariosPropina, cutVarios, Llamadas, Taxis, Aseo, cutVariosLlantasVacio, cutVariosCeladaVacio, cutVariosPropinaVacio, cutVariosVacio, Viaticos, cutParticipacion, cutParticipacionVacio, curHotelCarretera, curHotelCiudad, curHotel, curHotelCarreteraVacio, curHotelCiudadVacio, curHotelVacio, intTiempoCargue, intTiempoDescargue, intTiempoAduana, intTotalTrayecto, intTotalTiempo, curComida, intTiempoCargueVacio, intTiempoDescargueVacio, intTiempoAduanaVacio, intTotalTrayectoVacio, intTotalTiempoVacio, curComidaVacio, curDesvareManoRepuestos, curDesvareManoObra, cutSaldo, cutSaldoVacio, cutKmts, logActualizaPeajes, intFactorKmPorGalon, logEstadoRuta,"RutaNueva");

				return rutanueva;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Updates an RutaNueva object by passing all object's fields
		/// </summary>
		/// <param name="lngIdRegistrRuta">int that contents the lngIdRegistrRuta value for the RutaNueva object</param>
		/// <param name="strRutaAnticipoGrupoOrigen">string that contents the strRutaAnticipoGrupoOrigen value for the RutaNueva object</param>
		/// <param name="strRutaAnticipoGrupoDestino">string that contents the strRutaAnticipoGrupoDestino value for the RutaNueva object</param>
		/// <param name="strRutaAnticipoGrupo">string that contents the strRutaAnticipoGrupo value for the RutaNueva object</param>
		/// <param name="strRutaAnticipo">string that contents the strRutaAnticipo value for the RutaNueva object</param>
		/// <param name="TipoVehiculoCodigo">double that contents the TipoVehiculoCodigo value for the RutaNueva object</param>
		/// <param name="TipoVehiculo">string that contents the TipoVehiculo value for the RutaNueva object</param>
		/// <param name="TipoTrailerCodigo">double that contents the TipoTrailerCodigo value for the RutaNueva object</param>
		/// <param name="Peso">double that contents the Peso value for the RutaNueva object</param>
		/// <param name="Programa">string that contents the Programa value for the RutaNueva object</param>
		/// <param name="logViajeVacio">double that contents the logViajeVacio value for the RutaNueva object</param>
		/// <param name="floGalones">double that contents the floGalones value for the RutaNueva object</param>
		/// <param name="curValorGalon">double that contents the curValorGalon value for the RutaNueva object</param>
		/// <param name="cutCombustible">double that contents the cutCombustible value for the RutaNueva object</param>
		/// <param name="lngIdNroPeajes">double that contents the lngIdNroPeajes value for the RutaNueva object</param>
		/// <param name="cutPeaje">double that contents the cutPeaje value for the RutaNueva object</param>
		/// <param name="strNombrePeajes">string that contents the strNombrePeajes value for the RutaNueva object</param>
		/// <param name="cutVariosLlantas">double that contents the cutVariosLlantas value for the RutaNueva object</param>
		/// <param name="cutVariosCelada">double that contents the cutVariosCelada value for the RutaNueva object</param>
		/// <param name="cutVariosPropina">double that contents the cutVariosPropina value for the RutaNueva object</param>
		/// <param name="cutVarios">double that contents the cutVarios value for the RutaNueva object</param>
		/// <param name="Llamadas">double that contents the Llamadas value for the RutaNueva object</param>
		/// <param name="Taxis">double that contents the Taxis value for the RutaNueva object</param>
		/// <param name="Aseo">double that contents the Aseo value for the RutaNueva object</param>
		/// <param name="cutVariosLlantasVacio">double that contents the cutVariosLlantasVacio value for the RutaNueva object</param>
		/// <param name="cutVariosCeladaVacio">double that contents the cutVariosCeladaVacio value for the RutaNueva object</param>
		/// <param name="cutVariosPropinaVacio">double that contents the cutVariosPropinaVacio value for the RutaNueva object</param>
		/// <param name="cutVariosVacio">double that contents the cutVariosVacio value for the RutaNueva object</param>
		/// <param name="Viaticos">double that contents the Viaticos value for the RutaNueva object</param>
		/// <param name="cutParticipacion">double that contents the cutParticipacion value for the RutaNueva object</param>
		/// <param name="cutParticipacionVacio">double that contents the cutParticipacionVacio value for the RutaNueva object</param>
		/// <param name="curHotelCarretera">double that contents the curHotelCarretera value for the RutaNueva object</param>
		/// <param name="curHotelCiudad">double that contents the curHotelCiudad value for the RutaNueva object</param>
		/// <param name="curHotel">double that contents the curHotel value for the RutaNueva object</param>
		/// <param name="curHotelCarreteraVacio">double that contents the curHotelCarreteraVacio value for the RutaNueva object</param>
		/// <param name="curHotelCiudadVacio">double that contents the curHotelCiudadVacio value for the RutaNueva object</param>
		/// <param name="curHotelVacio">double that contents the curHotelVacio value for the RutaNueva object</param>
		/// <param name="intTiempoCargue">double that contents the intTiempoCargue value for the RutaNueva object</param>
		/// <param name="intTiempoDescargue">double that contents the intTiempoDescargue value for the RutaNueva object</param>
		/// <param name="intTiempoAduana">double that contents the intTiempoAduana value for the RutaNueva object</param>
		/// <param name="intTotalTrayecto">double that contents the intTotalTrayecto value for the RutaNueva object</param>
		/// <param name="intTotalTiempo">double that contents the intTotalTiempo value for the RutaNueva object</param>
		/// <param name="curComida">double that contents the curComida value for the RutaNueva object</param>
		/// <param name="intTiempoCargueVacio">double that contents the intTiempoCargueVacio value for the RutaNueva object</param>
		/// <param name="intTiempoDescargueVacio">double that contents the intTiempoDescargueVacio value for the RutaNueva object</param>
		/// <param name="intTiempoAduanaVacio">double that contents the intTiempoAduanaVacio value for the RutaNueva object</param>
		/// <param name="intTotalTrayectoVacio">double that contents the intTotalTrayectoVacio value for the RutaNueva object</param>
		/// <param name="intTotalTiempoVacio">double that contents the intTotalTiempoVacio value for the RutaNueva object</param>
		/// <param name="curComidaVacio">double that contents the curComidaVacio value for the RutaNueva object</param>
		/// <param name="curDesvareManoRepuestos">double that contents the curDesvareManoRepuestos value for the RutaNueva object</param>
		/// <param name="curDesvareManoObra">double that contents the curDesvareManoObra value for the RutaNueva object</param>
		/// <param name="cutSaldo">double that contents the cutSaldo value for the RutaNueva object</param>
		/// <param name="cutSaldoVacio">double that contents the cutSaldoVacio value for the RutaNueva object</param>
		/// <param name="cutKmts">double that contents the cutKmts value for the RutaNueva object</param>
		/// <param name="logActualizaPeajes">double that contents the logActualizaPeajes value for the RutaNueva object</param>
		/// <param name="intFactorKmPorGalon">double that contents the intFactorKmPorGalon value for the RutaNueva object</param>
		/// <param name="logEstadoRuta">double that contents the logEstadoRuta value for the RutaNueva object</param>
		public void Update(int lngIdRegistrRuta, string strRutaAnticipoGrupoOrigen, string strRutaAnticipoGrupoDestino, string strRutaAnticipoGrupo, string strRutaAnticipo, double? TipoVehiculoCodigo, string TipoVehiculo, double? TipoTrailerCodigo, double? Peso, string Programa, double? logViajeVacio, double? floGalones, double? curValorGalon, double? cutCombustible, double? lngIdNroPeajes, double? cutPeaje, string strNombrePeajes, double? cutVariosLlantas, double? cutVariosCelada, double? cutVariosPropina, double? cutVarios, double? Llamadas, double? Taxis, double? Aseo, double? cutVariosLlantasVacio, double? cutVariosCeladaVacio, double? cutVariosPropinaVacio, double? cutVariosVacio, double? Viaticos, double? cutParticipacion, double? cutParticipacionVacio, double? curHotelCarretera, double? curHotelCiudad, double? curHotel, double? curHotelCarreteraVacio, double? curHotelCiudadVacio, double? curHotelVacio, double? intTiempoCargue, double? intTiempoDescargue, double? intTiempoAduana, double? intTotalTrayecto, double? intTotalTiempo, double? curComida, double? intTiempoCargueVacio, double? intTiempoDescargueVacio, double? intTiempoAduanaVacio, double? intTotalTrayectoVacio, double? intTotalTiempoVacio, double? curComidaVacio, double? curDesvareManoRepuestos, double? curDesvareManoObra, double? cutSaldo, double? cutSaldoVacio, double? cutKmts, double? logActualizaPeajes, double? intFactorKmPorGalon, double? logEstadoRuta, Sinapsys.Datos.SQL datosTransaccion=null)
		{
			try 
			{
				RutaNueva new_values = new RutaNueva();
				new_values.strRutaAnticipoGrupoOrigen = strRutaAnticipoGrupoOrigen;
				new_values.strRutaAnticipoGrupoDestino = strRutaAnticipoGrupoDestino;
				new_values.strRutaAnticipoGrupo = strRutaAnticipoGrupo;
				new_values.strRutaAnticipo = strRutaAnticipo;
				new_values.TipoVehiculoCodigo = TipoVehiculoCodigo;
				new_values.TipoVehiculo = TipoVehiculo;
				new_values.TipoTrailerCodigo = TipoTrailerCodigo;
				new_values.Peso = Peso;
				new_values.Programa = Programa;
				new_values.logViajeVacio = logViajeVacio;
				new_values.floGalones = floGalones;
				new_values.curValorGalon = curValorGalon;
				new_values.cutCombustible = cutCombustible;
				new_values.lngIdNroPeajes = lngIdNroPeajes;
				new_values.cutPeaje = cutPeaje;
				new_values.strNombrePeajes = strNombrePeajes;
				new_values.cutVariosLlantas = cutVariosLlantas;
				new_values.cutVariosCelada = cutVariosCelada;
				new_values.cutVariosPropina = cutVariosPropina;
				new_values.cutVarios = cutVarios;
				new_values.Llamadas = Llamadas;
				new_values.Taxis = Taxis;
				new_values.Aseo = Aseo;
				new_values.cutVariosLlantasVacio = cutVariosLlantasVacio;
				new_values.cutVariosCeladaVacio = cutVariosCeladaVacio;
				new_values.cutVariosPropinaVacio = cutVariosPropinaVacio;
				new_values.cutVariosVacio = cutVariosVacio;
				new_values.Viaticos = Viaticos;
				new_values.cutParticipacion = cutParticipacion;
				new_values.cutParticipacionVacio = cutParticipacionVacio;
				new_values.curHotelCarretera = curHotelCarretera;
				new_values.curHotelCiudad = curHotelCiudad;
				new_values.curHotel = curHotel;
				new_values.curHotelCarreteraVacio = curHotelCarreteraVacio;
				new_values.curHotelCiudadVacio = curHotelCiudadVacio;
				new_values.curHotelVacio = curHotelVacio;
				new_values.intTiempoCargue = intTiempoCargue;
				new_values.intTiempoDescargue = intTiempoDescargue;
				new_values.intTiempoAduana = intTiempoAduana;
				new_values.intTotalTrayecto = intTotalTrayecto;
				new_values.intTotalTiempo = intTotalTiempo;
				new_values.curComida = curComida;
				new_values.intTiempoCargueVacio = intTiempoCargueVacio;
				new_values.intTiempoDescargueVacio = intTiempoDescargueVacio;
				new_values.intTiempoAduanaVacio = intTiempoAduanaVacio;
				new_values.intTotalTrayectoVacio = intTotalTrayectoVacio;
				new_values.intTotalTiempoVacio = intTotalTiempoVacio;
				new_values.curComidaVacio = curComidaVacio;
				new_values.curDesvareManoRepuestos = curDesvareManoRepuestos;
				new_values.curDesvareManoObra = curDesvareManoObra;
				new_values.cutSaldo = cutSaldo;
				new_values.cutSaldoVacio = cutSaldoVacio;
				new_values.cutKmts = cutKmts;
				new_values.logActualizaPeajes = logActualizaPeajes;
				new_values.intFactorKmPorGalon = intFactorKmPorGalon;
				new_values.logEstadoRuta = logEstadoRuta;
				RutaNuevaDataProvider.Instance.Update(lngIdRegistrRuta, strRutaAnticipoGrupoOrigen, strRutaAnticipoGrupoDestino, strRutaAnticipoGrupo, strRutaAnticipo, TipoVehiculoCodigo, TipoVehiculo, TipoTrailerCodigo, Peso, Programa, logViajeVacio, floGalones, curValorGalon, cutCombustible, lngIdNroPeajes, cutPeaje, strNombrePeajes, cutVariosLlantas, cutVariosCelada, cutVariosPropina, cutVarios, Llamadas, Taxis, Aseo, cutVariosLlantasVacio, cutVariosCeladaVacio, cutVariosPropinaVacio, cutVariosVacio, Viaticos, cutParticipacion, cutParticipacionVacio, curHotelCarretera, curHotelCiudad, curHotel, curHotelCarreteraVacio, curHotelCiudadVacio, curHotelVacio, intTiempoCargue, intTiempoDescargue, intTiempoAduana, intTotalTrayecto, intTotalTiempo, curComida, intTiempoCargueVacio, intTiempoDescargueVacio, intTiempoAduanaVacio, intTotalTrayectoVacio, intTotalTiempoVacio, curComidaVacio, curDesvareManoRepuestos, curDesvareManoObra, cutSaldo, cutSaldoVacio, cutKmts, logActualizaPeajes, intFactorKmPorGalon, logEstadoRuta,"RutaNueva",datosTransaccion);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Updates an RutaNueva object by passing one object's instance as reference
		/// </summary>
		/// <param name="rutanueva">An instance of RutaNueva for reference</param>
		public void Update(RutaNueva rutanueva,Sinapsys.Datos.SQL datosTransaccion=null)
		{
			Update(rutanueva.lngIdRegistrRuta, rutanueva.strRutaAnticipoGrupoOrigen, rutanueva.strRutaAnticipoGrupoDestino, rutanueva.strRutaAnticipoGrupo, rutanueva.strRutaAnticipo, rutanueva.TipoVehiculoCodigo, rutanueva.TipoVehiculo, rutanueva.TipoTrailerCodigo, rutanueva.Peso, rutanueva.Programa, rutanueva.logViajeVacio, rutanueva.floGalones, rutanueva.curValorGalon, rutanueva.cutCombustible, rutanueva.lngIdNroPeajes, rutanueva.cutPeaje, rutanueva.strNombrePeajes, rutanueva.cutVariosLlantas, rutanueva.cutVariosCelada, rutanueva.cutVariosPropina, rutanueva.cutVarios, rutanueva.Llamadas, rutanueva.Taxis, rutanueva.Aseo, rutanueva.cutVariosLlantasVacio, rutanueva.cutVariosCeladaVacio, rutanueva.cutVariosPropinaVacio, rutanueva.cutVariosVacio, rutanueva.Viaticos, rutanueva.cutParticipacion, rutanueva.cutParticipacionVacio, rutanueva.curHotelCarretera, rutanueva.curHotelCiudad, rutanueva.curHotel, rutanueva.curHotelCarreteraVacio, rutanueva.curHotelCiudadVacio, rutanueva.curHotelVacio, rutanueva.intTiempoCargue, rutanueva.intTiempoDescargue, rutanueva.intTiempoAduana, rutanueva.intTotalTrayecto, rutanueva.intTotalTiempo, rutanueva.curComida, rutanueva.intTiempoCargueVacio, rutanueva.intTiempoDescargueVacio, rutanueva.intTiempoAduanaVacio, rutanueva.intTotalTrayectoVacio, rutanueva.intTotalTiempoVacio, rutanueva.curComidaVacio, rutanueva.curDesvareManoRepuestos, rutanueva.curDesvareManoObra, rutanueva.cutSaldo, rutanueva.cutSaldoVacio, rutanueva.cutKmts, rutanueva.logActualizaPeajes, rutanueva.intFactorKmPorGalon, rutanueva.logEstadoRuta);
		}

		/// <summary>
		/// Delete  the RutaNueva object by passing a object
		/// </summary>
		public void  Delete(RutaNueva rutanueva, Sinapsys.Datos.SQL datosTransaccion=null)
		{
			Delete(rutanueva.lngIdRegistrRuta,datosTransaccion);
		}

		/// <summary>
		/// Deletes the RutaNueva object by passing one object's instance as reference
		/// </summary>
		/// <param name="rutanueva">An instance of RutaNueva for reference</param>
		public void Delete(int lngIdRegistrRuta, Sinapsys.Datos.SQL datosTransaccion=null)
		{
			try 
			{
				RutaNuevaDataProvider.Instance.Delete(lngIdRegistrRuta,"RutaNueva");
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Deletes the RutaNueva object by passing CVS parameter as reference
		/// </summary>
		/// <param name="rutanueva">An instance of RutaNueva for reference</param>
		public void Delete(string CVSParameter)
		{
			string[] StrCommand=CVSParameter.Split(',');
			try 
			{
				int lngIdRegistrRuta=int.Parse(StrCommand[0]);
				RutaNuevaDataProvider.Instance.Delete(lngIdRegistrRuta,"RutaNueva");
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Gets the RutaNueva object by passing the object's key fields
		/// </summary>
		/// <param name="lngIdRegistrRuta">int that contents the lngIdRegistrRuta value for the RutaNueva object</param>
		/// <returns>One RutaNueva object</returns>
		public RutaNueva Get(int lngIdRegistrRuta, bool generateUndo=false)
		{
			try 
			{
				RutaNueva rutanueva = null;
				DataTable dt = RutaNuevaDataProvider.Instance.Get(lngIdRegistrRuta);
				if ((dt.Rows.Count > 0))
				{
					rutanueva = new RutaNueva();
					DataRow dr = dt.Rows[0];
					ReadData(rutanueva, dr, generateUndo);
				}


				return rutanueva;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Gets all objects of RutaNueva
		/// </summary>
		/// <returns>One RutaNuevaList object</returns>
		public RutaNuevaList GetAll(bool generateUndo=false)
		{
			try 
			{
				RutaNuevaList rutanuevalist = new RutaNuevaList();
				DataTable dt = RutaNuevaDataProvider.Instance.GetAll();
				foreach (DataRow dr in dt.Rows)
				{
					RutaNueva rutanueva = new RutaNueva();
					ReadData(rutanueva, dr, generateUndo);
					rutanuevalist.Add(rutanueva);
				}
				return rutanuevalist;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Gets all objects of RutaNueva applying filter and sort criteria
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
		/// <returns>One RutaNuevaList object</returns>
		public RutaNuevaList GetFilter(int pagenum, int pagesize, string filter, string sort, string extablesfilter, string extablesfieldsfilter, string extablesrelationsfilter, string extablessort, string extablesfieldssort, string extablesrelationssort, bool generateUndo=false)
		{
			try 
			{
				RutaNuevaList rutanuevalist = new RutaNuevaList();

				DataTable dt = RutaNuevaDataProvider.Instance.GetFilter(pagenum, pagesize, filter, sort, extablesfilter, extablesfieldsfilter, extablesrelationsfilter, extablessort, extablesfieldssort, extablesrelationssort);

				foreach (DataRow dr in dt.Rows)
				{
					RutaNueva rutanueva = new RutaNueva();
					ReadData(rutanueva, dr, generateUndo);
					rutanuevalist.Add(rutanueva);
				}
				return rutanuevalist;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public RutaNuevaList GetFilter( string filter, string sort, bool generateUndo=false)
		{
			return GetFilter(0,0, filter, sort, "","","","","","",generateUndo);
		}

		public RutaNuevaList GetFilter(string filter, string sort, string extablesfilter, string extablesfieldsfilter, string extablesrelationsfilter, string extablessort, string extablesfieldssort, string extablesrelationssort, bool generateUndo=false)
		{
			return GetFilter(0,0, filter, sort, extablesfilter, extablesfieldsfilter, extablesrelationsfilter, extablessort, extablesfieldssort, extablesrelationssort,generateUndo);
		}


		/// <summary>
		/// Returns the type for one property
		/// </summary>
		/// <param name="propertyname">Property's name for return its value</param>
		/// <returns>A value for the <paramref name="propertyname"/></returns>
		public Type GetMethodType( string propertyname,RutaNueva rutanueva)
		{
			// Perform the search for the property's value
			switch (propertyname)
			{
				case "lngIdRegistrRuta":
					return rutanueva.lngIdRegistrRuta.GetType();

				case "strRutaAnticipoGrupoOrigen":
					return rutanueva.strRutaAnticipoGrupoOrigen.GetType();

				case "strRutaAnticipoGrupoDestino":
					return rutanueva.strRutaAnticipoGrupoDestino.GetType();

				case "strRutaAnticipoGrupo":
					return rutanueva.strRutaAnticipoGrupo.GetType();

				case "strRutaAnticipo":
					return rutanueva.strRutaAnticipo.GetType();

				case "TipoVehiculoCodigo":
					return rutanueva.TipoVehiculoCodigo.GetType();

				case "TipoVehiculo":
					return rutanueva.TipoVehiculo.GetType();

				case "TipoTrailerCodigo":
					return rutanueva.TipoTrailerCodigo.GetType();

				case "Peso":
					return rutanueva.Peso.GetType();

				case "Programa":
					return rutanueva.Programa.GetType();

				case "logViajeVacio":
					return rutanueva.logViajeVacio.GetType();

				case "floGalones":
					return rutanueva.floGalones.GetType();

				case "curValorGalon":
					return rutanueva.curValorGalon.GetType();

				case "cutCombustible":
					return rutanueva.cutCombustible.GetType();

				case "lngIdNroPeajes":
					return rutanueva.lngIdNroPeajes.GetType();

				case "cutPeaje":
					return rutanueva.cutPeaje.GetType();

				case "strNombrePeajes":
					return rutanueva.strNombrePeajes.GetType();

				case "cutVariosLlantas":
					return rutanueva.cutVariosLlantas.GetType();

				case "cutVariosCelada":
					return rutanueva.cutVariosCelada.GetType();

				case "cutVariosPropina":
					return rutanueva.cutVariosPropina.GetType();

				case "cutVarios":
					return rutanueva.cutVarios.GetType();

				case "Llamadas":
					return rutanueva.Llamadas.GetType();

				case "Taxis":
					return rutanueva.Taxis.GetType();

				case "Aseo":
					return rutanueva.Aseo.GetType();

				case "cutVariosLlantasVacio":
					return rutanueva.cutVariosLlantasVacio.GetType();

				case "cutVariosCeladaVacio":
					return rutanueva.cutVariosCeladaVacio.GetType();

				case "cutVariosPropinaVacio":
					return rutanueva.cutVariosPropinaVacio.GetType();

				case "cutVariosVacio":
					return rutanueva.cutVariosVacio.GetType();

				case "Viaticos":
					return rutanueva.Viaticos.GetType();

				case "cutParticipacion":
					return rutanueva.cutParticipacion.GetType();

				case "cutParticipacionVacio":
					return rutanueva.cutParticipacionVacio.GetType();

				case "curHotelCarretera":
					return rutanueva.curHotelCarretera.GetType();

				case "curHotelCiudad":
					return rutanueva.curHotelCiudad.GetType();

				case "curHotel":
					return rutanueva.curHotel.GetType();

				case "curHotelCarreteraVacio":
					return rutanueva.curHotelCarreteraVacio.GetType();

				case "curHotelCiudadVacio":
					return rutanueva.curHotelCiudadVacio.GetType();

				case "curHotelVacio":
					return rutanueva.curHotelVacio.GetType();

				case "intTiempoCargue":
					return rutanueva.intTiempoCargue.GetType();

				case "intTiempoDescargue":
					return rutanueva.intTiempoDescargue.GetType();

				case "intTiempoAduana":
					return rutanueva.intTiempoAduana.GetType();

				case "intTotalTrayecto":
					return rutanueva.intTotalTrayecto.GetType();

				case "intTotalTiempo":
					return rutanueva.intTotalTiempo.GetType();

				case "curComida":
					return rutanueva.curComida.GetType();

				case "intTiempoCargueVacio":
					return rutanueva.intTiempoCargueVacio.GetType();

				case "intTiempoDescargueVacio":
					return rutanueva.intTiempoDescargueVacio.GetType();

				case "intTiempoAduanaVacio":
					return rutanueva.intTiempoAduanaVacio.GetType();

				case "intTotalTrayectoVacio":
					return rutanueva.intTotalTrayectoVacio.GetType();

				case "intTotalTiempoVacio":
					return rutanueva.intTotalTiempoVacio.GetType();

				case "curComidaVacio":
					return rutanueva.curComidaVacio.GetType();

				case "curDesvareManoRepuestos":
					return rutanueva.curDesvareManoRepuestos.GetType();

				case "curDesvareManoObra":
					return rutanueva.curDesvareManoObra.GetType();

				case "cutSaldo":
					return rutanueva.cutSaldo.GetType();

				case "cutSaldoVacio":
					return rutanueva.cutSaldoVacio.GetType();

				case "cutKmts":
					return rutanueva.cutKmts.GetType();

				case "logActualizaPeajes":
					return rutanueva.logActualizaPeajes.GetType();

				case "intFactorKmPorGalon":
					return rutanueva.intFactorKmPorGalon.GetType();

				case "logEstadoRuta":
					return rutanueva.logEstadoRuta.GetType();

			}

			return null;
		}
		/// <summary>
		/// update the changes in RutaNueva object by passing the object
		/// </summary>
		public bool UpdateChanges(RutaNueva rutanueva, out string error,Sinapsys.Datos.SQL datosTransaccion=null)
		{
			if (rutanueva.OldRutaNueva == null)
			{
				    error = "No tiene objeto con el cual comparar";
				    return false;
			}
			string[] Fields = rutanueva.FieldChanged();
			error = "";
			return LiqViajes_Bll_Data.DataProvider.UpdateFieldsbyObject(Fields, rutanueva, out error,datosTransaccion);
		}
	}

	#endregion

}
