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
	#region RutasDetTramosController

	/// <summary>
	/// Class for convert data from database into object's data and vice versa
	/// </summary>
	public partial class RutasDetTramosController//: ILatinodeController
	{
		/// <summary>
		/// Generic Constructor
		/// </summary>
		public RutasDetTramosController()
		{
		}

		/// <summary>
		/// Instance accessor for this singleton
		/// </summary>
		private static RutasDetTramosController MySingleObj;
		public static RutasDetTramosController Instance
		{
			get
			{
				if (MySingleObj == null)
				{
					MySingleObj = new RutasDetTramosController();
				}
				return MySingleObj;
			}
		}

		// Reads object's data from a DataRow
		private void ReadData(RutasDetTramos rutasdettramos, DataRow dr,bool generateUndo=false)
		{
			try 
			{
				rutasdettramos.Codigo = (long) dr["Codigo"];
				rutasdettramos.logAsigna_Chk_600 = (bool) dr["logAsigna_Chk_600"];
				rutasdettramos.lngIdRegistrRuta = (long) dr["lngIdRegistrRuta"];
				rutasdettramos.strRutaAnticipoGrupoOrigen = (string) dr["strRutaAnticipoGrupoOrigen"];
				rutasdettramos.strRutaAnticipoGrupoDestino = (string) dr["strRutaAnticipoGrupoDestino"];
				rutasdettramos.strRutaAnticipo = (string) dr["strRutaAnticipo"];
				rutasdettramos.floGalones = (decimal) dr["floGalones"];
				rutasdettramos.curValorGalon = (decimal) dr["curValorGalon"];
				rutasdettramos.cutCombustible = (decimal) dr["cutCombustible"];
				rutasdettramos.lngIdNroPeajes = (int) dr["lngIdNroPeajes"];
				rutasdettramos.cutPeaje = (decimal) dr["cutPeaje"];
				rutasdettramos.cutVariosLlantas = (decimal) dr["cutVariosLlantas"];
				rutasdettramos.cutVariosCelada = (decimal) dr["cutVariosCelada"];
				rutasdettramos.cutVariosPropina = (decimal) dr["cutVariosPropina"];
				rutasdettramos.cutVarios = (decimal) dr["cutVarios"];
				rutasdettramos.cutVariosLlantasVacio = (decimal) dr["cutVariosLlantasVacio"];
				rutasdettramos.cutVariosCeladaVacio = (decimal) dr["cutVariosCeladaVacio"];
				rutasdettramos.cutVariosPropinaVacio = (decimal) dr["cutVariosPropinaVacio"];
				rutasdettramos.cutVariosVacio = (decimal) dr["cutVariosVacio"];
				rutasdettramos.CurCargue = (decimal) dr["CurCargue"];
				rutasdettramos.CurDescargue = (decimal) dr["CurDescargue"];
				rutasdettramos.curHotel = (decimal) dr["curHotel"];
				rutasdettramos.curHotelCarreteraVacio = (decimal) dr["curHotelCarreteraVacio"];
				rutasdettramos.curHotelCiudadVacio = (decimal) dr["curHotelCiudadVacio"];
				rutasdettramos.curHotelVacio = (decimal) dr["curHotelVacio"];
				rutasdettramos.intTotalTiempo = (decimal) dr["intTotalTiempo"];
				rutasdettramos.curComida = (decimal) dr["curComida"];
				rutasdettramos.intTotalTiempoVacio = (decimal) dr["intTotalTiempoVacio"];
				rutasdettramos.curComidaVacio = (decimal) dr["curComidaVacio"];
				rutasdettramos.cutParticipacion = (decimal) dr["cutParticipacion"];
				rutasdettramos.cutParticipacionVacio = (decimal) dr["cutParticipacionVacio"];
				rutasdettramos.curDesvareManoRepuestos = (decimal) dr["curDesvareManoRepuestos"];
				rutasdettramos.curDesvareManoObra = (decimal) dr["curDesvareManoObra"];
				rutasdettramos.cutKmts = (decimal) dr["cutKmts"];
				rutasdettramos.logVacio = (bool) dr["logVacio"];
				rutasdettramos.ParqueaderoCarretera = (decimal) dr["ParqueaderoCarretera"];
				rutasdettramos.ParqueaderoCiudad = (decimal) dr["ParqueaderoCiudad"];
				rutasdettramos.MontadaLLantaCarretera = (decimal) dr["MontadaLLantaCarretera"];
				rutasdettramos.Papeleria = (decimal) dr["Papeleria"];
				rutasdettramos.AjusteCarretera = (decimal) dr["AjusteCarretera"];
				rutasdettramos.CombustibleCarretera = (decimal) dr["CombustibleCarretera"];
				rutasdettramos.Amarres_Amarres_1000 = (decimal) dr["Amarres_Amarres_1000"];
				rutasdettramos.Engradasa = (decimal) dr["Engradasa"];
				rutasdettramos.Calibrada = (decimal) dr["Calibrada"];
				rutasdettramos.TipoVehiculoCodigo = (int) dr["TipoVehiculoCodigo"];
				rutasdettramos.TipoVehiculo = (string) dr["TipoVehiculo"];
				rutasdettramos.TipoTrailerCodigo = (int) dr["TipoTrailerCodigo"];
				rutasdettramos.Peso = (int) dr["Peso"];
				rutasdettramos.logEstadoRuta = (bool) dr["logEstadoRuta"];
				rutasdettramos.Trailer = (string) dr["Trailer"];
				rutasdettramos.Aseo = (decimal) dr["Aseo"];
				rutasdettramos.Contenedor1 = (string) dr["Contenedor1"];
				rutasdettramos.Contenedor2 = (string) dr["Contenedor2"];
				rutasdettramos.FactorCalculoDia = (int) dr["FactorCalculoDia"];
				rutasdettramos.ValorCalculoFactor = (int) dr["ValorCalculoFactor"];
				rutasdettramos.Liquidado = (bool) dr["Liquidado"];
				rutasdettramos.Taxi = (decimal) dr["Taxi"];
				rutasdettramos.logFavorito = (bool) dr["logFavorito"];
				rutasdettramos.logAnticipoACPM = (bool) dr["logAnticipoACPM"];
			}
			catch (Exception ex)
			{
				Utilidades.LogErrores(ex.Message + (ex.InnerException != null ? ex.InnerException.Message : ""), DataProvider.AplicacionNombre);
				throw ex;
			}
			if (generateUndo) rutasdettramos.GenerateUndo();
		}

		/// <summary>
		/// Create a new RutasDetTramos object by passing a object
		/// </summary>
		public RutasDetTramos Create(RutasDetTramos rutasdettramos, Sinapsys.Datos.SQL datosTransaccion=null)
		{
			return Create(rutasdettramos.Codigo,rutasdettramos.logAsigna_Chk_600,rutasdettramos.lngIdRegistrRuta,rutasdettramos.strRutaAnticipoGrupoOrigen,rutasdettramos.strRutaAnticipoGrupoDestino,rutasdettramos.strRutaAnticipo,rutasdettramos.floGalones,rutasdettramos.curValorGalon,rutasdettramos.cutCombustible,rutasdettramos.lngIdNroPeajes,rutasdettramos.cutPeaje,rutasdettramos.cutVariosLlantas,rutasdettramos.cutVariosCelada,rutasdettramos.cutVariosPropina,rutasdettramos.cutVarios,rutasdettramos.cutVariosLlantasVacio,rutasdettramos.cutVariosCeladaVacio,rutasdettramos.cutVariosPropinaVacio,rutasdettramos.cutVariosVacio,rutasdettramos.CurCargue,rutasdettramos.CurDescargue,rutasdettramos.curHotel,rutasdettramos.curHotelCarreteraVacio,rutasdettramos.curHotelCiudadVacio,rutasdettramos.curHotelVacio,rutasdettramos.intTotalTiempo,rutasdettramos.curComida,rutasdettramos.intTotalTiempoVacio,rutasdettramos.curComidaVacio,rutasdettramos.cutParticipacion,rutasdettramos.cutParticipacionVacio,rutasdettramos.curDesvareManoRepuestos,rutasdettramos.curDesvareManoObra,rutasdettramos.cutKmts,rutasdettramos.logVacio,rutasdettramos.ParqueaderoCarretera,rutasdettramos.ParqueaderoCiudad,rutasdettramos.MontadaLLantaCarretera,rutasdettramos.Papeleria,rutasdettramos.AjusteCarretera,rutasdettramos.CombustibleCarretera,rutasdettramos.Amarres_Amarres_1000,rutasdettramos.Engradasa,rutasdettramos.Calibrada,rutasdettramos.TipoVehiculoCodigo,rutasdettramos.TipoVehiculo,rutasdettramos.TipoTrailerCodigo,rutasdettramos.Peso,rutasdettramos.logEstadoRuta,rutasdettramos.Trailer,rutasdettramos.Aseo,rutasdettramos.Contenedor1,rutasdettramos.Contenedor2,rutasdettramos.FactorCalculoDia,rutasdettramos.ValorCalculoFactor,rutasdettramos.Liquidado,rutasdettramos.Taxi,rutasdettramos.logFavorito,rutasdettramos.logAnticipoACPM,datosTransaccion);
		}

		/// <summary>
		/// Creates a new RutasDetTramos object by passing all object's fields
		/// </summary>
		/// <param name="logAsigna_Chk_600">bool that contents the logAsigna_Chk_600 value for the RutasDetTramos object</param>
		/// <param name="lngIdRegistrRuta">long that contents the lngIdRegistrRuta value for the RutasDetTramos object</param>
		/// <param name="strRutaAnticipoGrupoOrigen">string that contents the strRutaAnticipoGrupoOrigen value for the RutasDetTramos object</param>
		/// <param name="strRutaAnticipoGrupoDestino">string that contents the strRutaAnticipoGrupoDestino value for the RutasDetTramos object</param>
		/// <param name="strRutaAnticipo">string that contents the strRutaAnticipo value for the RutasDetTramos object</param>
		/// <param name="floGalones">decimal that contents the floGalones value for the RutasDetTramos object</param>
		/// <param name="curValorGalon">decimal that contents the curValorGalon value for the RutasDetTramos object</param>
		/// <param name="cutCombustible">decimal that contents the cutCombustible value for the RutasDetTramos object</param>
		/// <param name="lngIdNroPeajes">int that contents the lngIdNroPeajes value for the RutasDetTramos object</param>
		/// <param name="cutPeaje">decimal that contents the cutPeaje value for the RutasDetTramos object</param>
		/// <param name="cutVariosLlantas">decimal that contents the cutVariosLlantas value for the RutasDetTramos object</param>
		/// <param name="cutVariosCelada">decimal that contents the cutVariosCelada value for the RutasDetTramos object</param>
		/// <param name="cutVariosPropina">decimal that contents the cutVariosPropina value for the RutasDetTramos object</param>
		/// <param name="cutVarios">decimal that contents the cutVarios value for the RutasDetTramos object</param>
		/// <param name="cutVariosLlantasVacio">decimal that contents the cutVariosLlantasVacio value for the RutasDetTramos object</param>
		/// <param name="cutVariosCeladaVacio">decimal that contents the cutVariosCeladaVacio value for the RutasDetTramos object</param>
		/// <param name="cutVariosPropinaVacio">decimal that contents the cutVariosPropinaVacio value for the RutasDetTramos object</param>
		/// <param name="cutVariosVacio">decimal that contents the cutVariosVacio value for the RutasDetTramos object</param>
		/// <param name="CurCargue">decimal that contents the CurCargue value for the RutasDetTramos object</param>
		/// <param name="CurDescargue">decimal that contents the CurDescargue value for the RutasDetTramos object</param>
		/// <param name="curHotel">decimal that contents the curHotel value for the RutasDetTramos object</param>
		/// <param name="curHotelCarreteraVacio">decimal that contents the curHotelCarreteraVacio value for the RutasDetTramos object</param>
		/// <param name="curHotelCiudadVacio">decimal that contents the curHotelCiudadVacio value for the RutasDetTramos object</param>
		/// <param name="curHotelVacio">decimal that contents the curHotelVacio value for the RutasDetTramos object</param>
		/// <param name="intTotalTiempo">decimal that contents the intTotalTiempo value for the RutasDetTramos object</param>
		/// <param name="curComida">decimal that contents the curComida value for the RutasDetTramos object</param>
		/// <param name="intTotalTiempoVacio">decimal that contents the intTotalTiempoVacio value for the RutasDetTramos object</param>
		/// <param name="curComidaVacio">decimal that contents the curComidaVacio value for the RutasDetTramos object</param>
		/// <param name="cutParticipacion">decimal that contents the cutParticipacion value for the RutasDetTramos object</param>
		/// <param name="cutParticipacionVacio">decimal that contents the cutParticipacionVacio value for the RutasDetTramos object</param>
		/// <param name="curDesvareManoRepuestos">decimal that contents the curDesvareManoRepuestos value for the RutasDetTramos object</param>
		/// <param name="curDesvareManoObra">decimal that contents the curDesvareManoObra value for the RutasDetTramos object</param>
		/// <param name="cutKmts">decimal that contents the cutKmts value for the RutasDetTramos object</param>
		/// <param name="logVacio">bool that contents the logVacio value for the RutasDetTramos object</param>
		/// <param name="ParqueaderoCarretera">decimal that contents the ParqueaderoCarretera value for the RutasDetTramos object</param>
		/// <param name="ParqueaderoCiudad">decimal that contents the ParqueaderoCiudad value for the RutasDetTramos object</param>
		/// <param name="MontadaLLantaCarretera">decimal that contents the MontadaLLantaCarretera value for the RutasDetTramos object</param>
		/// <param name="Papeleria">decimal that contents the Papeleria value for the RutasDetTramos object</param>
		/// <param name="AjusteCarretera">decimal that contents the AjusteCarretera value for the RutasDetTramos object</param>
		/// <param name="CombustibleCarretera">decimal that contents the CombustibleCarretera value for the RutasDetTramos object</param>
		/// <param name="Amarres_Amarres_1000">decimal that contents the Amarres_Amarres_1000 value for the RutasDetTramos object</param>
		/// <param name="Engradasa">decimal that contents the Engradasa value for the RutasDetTramos object</param>
		/// <param name="Calibrada">decimal that contents the Calibrada value for the RutasDetTramos object</param>
		/// <param name="TipoVehiculoCodigo">int that contents the TipoVehiculoCodigo value for the RutasDetTramos object</param>
		/// <param name="TipoVehiculo">string that contents the TipoVehiculo value for the RutasDetTramos object</param>
		/// <param name="TipoTrailerCodigo">int that contents the TipoTrailerCodigo value for the RutasDetTramos object</param>
		/// <param name="Peso">int that contents the Peso value for the RutasDetTramos object</param>
		/// <param name="logEstadoRuta">bool that contents the logEstadoRuta value for the RutasDetTramos object</param>
		/// <param name="Trailer">string that contents the Trailer value for the RutasDetTramos object</param>
		/// <param name="Aseo">decimal that contents the Aseo value for the RutasDetTramos object</param>
		/// <param name="Contenedor1">string that contents the Contenedor1 value for the RutasDetTramos object</param>
		/// <param name="Contenedor2">string that contents the Contenedor2 value for the RutasDetTramos object</param>
		/// <param name="FactorCalculoDia">int that contents the FactorCalculoDia value for the RutasDetTramos object</param>
		/// <param name="ValorCalculoFactor">int that contents the ValorCalculoFactor value for the RutasDetTramos object</param>
		/// <param name="Liquidado">bool that contents the Liquidado value for the RutasDetTramos object</param>
		/// <param name="Taxi">decimal that contents the Taxi value for the RutasDetTramos object</param>
		/// <param name="logFavorito">bool that contents the logFavorito value for the RutasDetTramos object</param>
		/// <param name="logAnticipoACPM">bool that contents the logAnticipoACPM value for the RutasDetTramos object</param>
		/// <returns>One RutasDetTramos object</returns>
		public RutasDetTramos Create(long Codigo, bool logAsigna_Chk_600, long lngIdRegistrRuta, string strRutaAnticipoGrupoOrigen, string strRutaAnticipoGrupoDestino, string strRutaAnticipo, decimal floGalones, decimal curValorGalon, decimal cutCombustible, int lngIdNroPeajes, decimal cutPeaje, decimal cutVariosLlantas, decimal cutVariosCelada, decimal cutVariosPropina, decimal cutVarios, decimal cutVariosLlantasVacio, decimal cutVariosCeladaVacio, decimal cutVariosPropinaVacio, decimal cutVariosVacio, decimal CurCargue, decimal CurDescargue, decimal curHotel, decimal curHotelCarreteraVacio, decimal curHotelCiudadVacio, decimal curHotelVacio, decimal intTotalTiempo, decimal curComida, decimal intTotalTiempoVacio, decimal curComidaVacio, decimal cutParticipacion, decimal cutParticipacionVacio, decimal curDesvareManoRepuestos, decimal curDesvareManoObra, decimal cutKmts, bool logVacio, decimal ParqueaderoCarretera, decimal ParqueaderoCiudad, decimal MontadaLLantaCarretera, decimal Papeleria, decimal AjusteCarretera, decimal CombustibleCarretera, decimal Amarres_Amarres_1000, decimal Engradasa, decimal Calibrada, int TipoVehiculoCodigo, string TipoVehiculo, int TipoTrailerCodigo, int Peso, bool logEstadoRuta, string Trailer, decimal Aseo, string Contenedor1, string Contenedor2, int FactorCalculoDia, int ValorCalculoFactor, bool Liquidado, decimal Taxi, bool logFavorito, bool logAnticipoACPM, Sinapsys.Datos.SQL datosTransaccion=null)
		{
			try 
			{
				RutasDetTramos rutasdettramos = new RutasDetTramos();

				rutasdettramos.Codigo = Codigo;
				rutasdettramos.logAsigna_Chk_600 = logAsigna_Chk_600;
				rutasdettramos.lngIdRegistrRuta = lngIdRegistrRuta;
				rutasdettramos.strRutaAnticipoGrupoOrigen = strRutaAnticipoGrupoOrigen;
				rutasdettramos.strRutaAnticipoGrupoDestino = strRutaAnticipoGrupoDestino;
				rutasdettramos.strRutaAnticipo = strRutaAnticipo;
				rutasdettramos.floGalones = floGalones;
				rutasdettramos.curValorGalon = curValorGalon;
				rutasdettramos.cutCombustible = cutCombustible;
				rutasdettramos.lngIdNroPeajes = lngIdNroPeajes;
				rutasdettramos.cutPeaje = cutPeaje;
				rutasdettramos.cutVariosLlantas = cutVariosLlantas;
				rutasdettramos.cutVariosCelada = cutVariosCelada;
				rutasdettramos.cutVariosPropina = cutVariosPropina;
				rutasdettramos.cutVarios = cutVarios;
				rutasdettramos.cutVariosLlantasVacio = cutVariosLlantasVacio;
				rutasdettramos.cutVariosCeladaVacio = cutVariosCeladaVacio;
				rutasdettramos.cutVariosPropinaVacio = cutVariosPropinaVacio;
				rutasdettramos.cutVariosVacio = cutVariosVacio;
				rutasdettramos.CurCargue = CurCargue;
				rutasdettramos.CurDescargue = CurDescargue;
				rutasdettramos.curHotel = curHotel;
				rutasdettramos.curHotelCarreteraVacio = curHotelCarreteraVacio;
				rutasdettramos.curHotelCiudadVacio = curHotelCiudadVacio;
				rutasdettramos.curHotelVacio = curHotelVacio;
				rutasdettramos.intTotalTiempo = intTotalTiempo;
				rutasdettramos.curComida = curComida;
				rutasdettramos.intTotalTiempoVacio = intTotalTiempoVacio;
				rutasdettramos.curComidaVacio = curComidaVacio;
				rutasdettramos.cutParticipacion = cutParticipacion;
				rutasdettramos.cutParticipacionVacio = cutParticipacionVacio;
				rutasdettramos.curDesvareManoRepuestos = curDesvareManoRepuestos;
				rutasdettramos.curDesvareManoObra = curDesvareManoObra;
				rutasdettramos.cutKmts = cutKmts;
				rutasdettramos.logVacio = logVacio;
				rutasdettramos.ParqueaderoCarretera = ParqueaderoCarretera;
				rutasdettramos.ParqueaderoCiudad = ParqueaderoCiudad;
				rutasdettramos.MontadaLLantaCarretera = MontadaLLantaCarretera;
				rutasdettramos.Papeleria = Papeleria;
				rutasdettramos.AjusteCarretera = AjusteCarretera;
				rutasdettramos.CombustibleCarretera = CombustibleCarretera;
				rutasdettramos.Amarres_Amarres_1000 = Amarres_Amarres_1000;
				rutasdettramos.Engradasa = Engradasa;
				rutasdettramos.Calibrada = Calibrada;
				rutasdettramos.TipoVehiculoCodigo = TipoVehiculoCodigo;
				rutasdettramos.TipoVehiculo = TipoVehiculo;
				rutasdettramos.TipoTrailerCodigo = TipoTrailerCodigo;
				rutasdettramos.Peso = Peso;
				rutasdettramos.logEstadoRuta = logEstadoRuta;
				rutasdettramos.Trailer = Trailer;
				rutasdettramos.Aseo = Aseo;
				rutasdettramos.Contenedor1 = Contenedor1;
				rutasdettramos.Contenedor2 = Contenedor2;
				rutasdettramos.FactorCalculoDia = FactorCalculoDia;
				rutasdettramos.ValorCalculoFactor = ValorCalculoFactor;
				rutasdettramos.Liquidado = Liquidado;
				rutasdettramos.Taxi = Taxi;
				rutasdettramos.logFavorito = logFavorito;
				rutasdettramos.logAnticipoACPM = logAnticipoACPM;
				RutasDetTramosDataProvider.Instance.Create(Codigo, logAsigna_Chk_600, lngIdRegistrRuta, strRutaAnticipoGrupoOrigen, strRutaAnticipoGrupoDestino, strRutaAnticipo, floGalones, curValorGalon, cutCombustible, lngIdNroPeajes, cutPeaje, cutVariosLlantas, cutVariosCelada, cutVariosPropina, cutVarios, cutVariosLlantasVacio, cutVariosCeladaVacio, cutVariosPropinaVacio, cutVariosVacio, CurCargue, CurDescargue, curHotel, curHotelCarreteraVacio, curHotelCiudadVacio, curHotelVacio, intTotalTiempo, curComida, intTotalTiempoVacio, curComidaVacio, cutParticipacion, cutParticipacionVacio, curDesvareManoRepuestos, curDesvareManoObra, cutKmts, logVacio, ParqueaderoCarretera, ParqueaderoCiudad, MontadaLLantaCarretera, Papeleria, AjusteCarretera, CombustibleCarretera, Amarres_Amarres_1000, Engradasa, Calibrada, TipoVehiculoCodigo, TipoVehiculo, TipoTrailerCodigo, Peso, logEstadoRuta, Trailer, Aseo, Contenedor1, Contenedor2, FactorCalculoDia, ValorCalculoFactor, Liquidado, Taxi, logFavorito, logAnticipoACPM,"RutasDetTramos");

				return rutasdettramos;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Updates an RutasDetTramos object by passing all object's fields
		/// </summary>
		/// <param name="Codigo">long that contents the Codigo value for the RutasDetTramos object</param>
		/// <param name="logAsigna_Chk_600">bool that contents the logAsigna_Chk_600 value for the RutasDetTramos object</param>
		/// <param name="lngIdRegistrRuta">long that contents the lngIdRegistrRuta value for the RutasDetTramos object</param>
		/// <param name="strRutaAnticipoGrupoOrigen">string that contents the strRutaAnticipoGrupoOrigen value for the RutasDetTramos object</param>
		/// <param name="strRutaAnticipoGrupoDestino">string that contents the strRutaAnticipoGrupoDestino value for the RutasDetTramos object</param>
		/// <param name="strRutaAnticipo">string that contents the strRutaAnticipo value for the RutasDetTramos object</param>
		/// <param name="floGalones">decimal that contents the floGalones value for the RutasDetTramos object</param>
		/// <param name="curValorGalon">decimal that contents the curValorGalon value for the RutasDetTramos object</param>
		/// <param name="cutCombustible">decimal that contents the cutCombustible value for the RutasDetTramos object</param>
		/// <param name="lngIdNroPeajes">int that contents the lngIdNroPeajes value for the RutasDetTramos object</param>
		/// <param name="cutPeaje">decimal that contents the cutPeaje value for the RutasDetTramos object</param>
		/// <param name="cutVariosLlantas">decimal that contents the cutVariosLlantas value for the RutasDetTramos object</param>
		/// <param name="cutVariosCelada">decimal that contents the cutVariosCelada value for the RutasDetTramos object</param>
		/// <param name="cutVariosPropina">decimal that contents the cutVariosPropina value for the RutasDetTramos object</param>
		/// <param name="cutVarios">decimal that contents the cutVarios value for the RutasDetTramos object</param>
		/// <param name="cutVariosLlantasVacio">decimal that contents the cutVariosLlantasVacio value for the RutasDetTramos object</param>
		/// <param name="cutVariosCeladaVacio">decimal that contents the cutVariosCeladaVacio value for the RutasDetTramos object</param>
		/// <param name="cutVariosPropinaVacio">decimal that contents the cutVariosPropinaVacio value for the RutasDetTramos object</param>
		/// <param name="cutVariosVacio">decimal that contents the cutVariosVacio value for the RutasDetTramos object</param>
		/// <param name="CurCargue">decimal that contents the CurCargue value for the RutasDetTramos object</param>
		/// <param name="CurDescargue">decimal that contents the CurDescargue value for the RutasDetTramos object</param>
		/// <param name="curHotel">decimal that contents the curHotel value for the RutasDetTramos object</param>
		/// <param name="curHotelCarreteraVacio">decimal that contents the curHotelCarreteraVacio value for the RutasDetTramos object</param>
		/// <param name="curHotelCiudadVacio">decimal that contents the curHotelCiudadVacio value for the RutasDetTramos object</param>
		/// <param name="curHotelVacio">decimal that contents the curHotelVacio value for the RutasDetTramos object</param>
		/// <param name="intTotalTiempo">decimal that contents the intTotalTiempo value for the RutasDetTramos object</param>
		/// <param name="curComida">decimal that contents the curComida value for the RutasDetTramos object</param>
		/// <param name="intTotalTiempoVacio">decimal that contents the intTotalTiempoVacio value for the RutasDetTramos object</param>
		/// <param name="curComidaVacio">decimal that contents the curComidaVacio value for the RutasDetTramos object</param>
		/// <param name="cutParticipacion">decimal that contents the cutParticipacion value for the RutasDetTramos object</param>
		/// <param name="cutParticipacionVacio">decimal that contents the cutParticipacionVacio value for the RutasDetTramos object</param>
		/// <param name="curDesvareManoRepuestos">decimal that contents the curDesvareManoRepuestos value for the RutasDetTramos object</param>
		/// <param name="curDesvareManoObra">decimal that contents the curDesvareManoObra value for the RutasDetTramos object</param>
		/// <param name="cutKmts">decimal that contents the cutKmts value for the RutasDetTramos object</param>
		/// <param name="logVacio">bool that contents the logVacio value for the RutasDetTramos object</param>
		/// <param name="ParqueaderoCarretera">decimal that contents the ParqueaderoCarretera value for the RutasDetTramos object</param>
		/// <param name="ParqueaderoCiudad">decimal that contents the ParqueaderoCiudad value for the RutasDetTramos object</param>
		/// <param name="MontadaLLantaCarretera">decimal that contents the MontadaLLantaCarretera value for the RutasDetTramos object</param>
		/// <param name="Papeleria">decimal that contents the Papeleria value for the RutasDetTramos object</param>
		/// <param name="AjusteCarretera">decimal that contents the AjusteCarretera value for the RutasDetTramos object</param>
		/// <param name="CombustibleCarretera">decimal that contents the CombustibleCarretera value for the RutasDetTramos object</param>
		/// <param name="Amarres_Amarres_1000">decimal that contents the Amarres_Amarres_1000 value for the RutasDetTramos object</param>
		/// <param name="Engradasa">decimal that contents the Engradasa value for the RutasDetTramos object</param>
		/// <param name="Calibrada">decimal that contents the Calibrada value for the RutasDetTramos object</param>
		/// <param name="TipoVehiculoCodigo">int that contents the TipoVehiculoCodigo value for the RutasDetTramos object</param>
		/// <param name="TipoVehiculo">string that contents the TipoVehiculo value for the RutasDetTramos object</param>
		/// <param name="TipoTrailerCodigo">int that contents the TipoTrailerCodigo value for the RutasDetTramos object</param>
		/// <param name="Peso">int that contents the Peso value for the RutasDetTramos object</param>
		/// <param name="logEstadoRuta">bool that contents the logEstadoRuta value for the RutasDetTramos object</param>
		/// <param name="Trailer">string that contents the Trailer value for the RutasDetTramos object</param>
		/// <param name="Aseo">decimal that contents the Aseo value for the RutasDetTramos object</param>
		/// <param name="Contenedor1">string that contents the Contenedor1 value for the RutasDetTramos object</param>
		/// <param name="Contenedor2">string that contents the Contenedor2 value for the RutasDetTramos object</param>
		/// <param name="FactorCalculoDia">int that contents the FactorCalculoDia value for the RutasDetTramos object</param>
		/// <param name="ValorCalculoFactor">int that contents the ValorCalculoFactor value for the RutasDetTramos object</param>
		/// <param name="Liquidado">bool that contents the Liquidado value for the RutasDetTramos object</param>
		/// <param name="Taxi">decimal that contents the Taxi value for the RutasDetTramos object</param>
		/// <param name="logFavorito">bool that contents the logFavorito value for the RutasDetTramos object</param>
		/// <param name="logAnticipoACPM">bool that contents the logAnticipoACPM value for the RutasDetTramos object</param>
		public void Update(long Codigo, bool logAsigna_Chk_600, long lngIdRegistrRuta, string strRutaAnticipoGrupoOrigen, string strRutaAnticipoGrupoDestino, string strRutaAnticipo, decimal floGalones, decimal curValorGalon, decimal cutCombustible, int lngIdNroPeajes, decimal cutPeaje, decimal cutVariosLlantas, decimal cutVariosCelada, decimal cutVariosPropina, decimal cutVarios, decimal cutVariosLlantasVacio, decimal cutVariosCeladaVacio, decimal cutVariosPropinaVacio, decimal cutVariosVacio, decimal CurCargue, decimal CurDescargue, decimal curHotel, decimal curHotelCarreteraVacio, decimal curHotelCiudadVacio, decimal curHotelVacio, decimal intTotalTiempo, decimal curComida, decimal intTotalTiempoVacio, decimal curComidaVacio, decimal cutParticipacion, decimal cutParticipacionVacio, decimal curDesvareManoRepuestos, decimal curDesvareManoObra, decimal cutKmts, bool logVacio, decimal ParqueaderoCarretera, decimal ParqueaderoCiudad, decimal MontadaLLantaCarretera, decimal Papeleria, decimal AjusteCarretera, decimal CombustibleCarretera, decimal Amarres_Amarres_1000, decimal Engradasa, decimal Calibrada, int TipoVehiculoCodigo, string TipoVehiculo, int TipoTrailerCodigo, int Peso, bool logEstadoRuta, string Trailer, decimal Aseo, string Contenedor1, string Contenedor2, int FactorCalculoDia, int ValorCalculoFactor, bool Liquidado, decimal Taxi, bool logFavorito, bool logAnticipoACPM, Sinapsys.Datos.SQL datosTransaccion=null)
		{
			try 
			{
				RutasDetTramos new_values = new RutasDetTramos();
				new_values.logAsigna_Chk_600 = logAsigna_Chk_600;
				new_values.lngIdRegistrRuta = lngIdRegistrRuta;
				new_values.strRutaAnticipoGrupoOrigen = strRutaAnticipoGrupoOrigen;
				new_values.strRutaAnticipoGrupoDestino = strRutaAnticipoGrupoDestino;
				new_values.strRutaAnticipo = strRutaAnticipo;
				new_values.floGalones = floGalones;
				new_values.curValorGalon = curValorGalon;
				new_values.cutCombustible = cutCombustible;
				new_values.lngIdNroPeajes = lngIdNroPeajes;
				new_values.cutPeaje = cutPeaje;
				new_values.cutVariosLlantas = cutVariosLlantas;
				new_values.cutVariosCelada = cutVariosCelada;
				new_values.cutVariosPropina = cutVariosPropina;
				new_values.cutVarios = cutVarios;
				new_values.cutVariosLlantasVacio = cutVariosLlantasVacio;
				new_values.cutVariosCeladaVacio = cutVariosCeladaVacio;
				new_values.cutVariosPropinaVacio = cutVariosPropinaVacio;
				new_values.cutVariosVacio = cutVariosVacio;
				new_values.CurCargue = CurCargue;
				new_values.CurDescargue = CurDescargue;
				new_values.curHotel = curHotel;
				new_values.curHotelCarreteraVacio = curHotelCarreteraVacio;
				new_values.curHotelCiudadVacio = curHotelCiudadVacio;
				new_values.curHotelVacio = curHotelVacio;
				new_values.intTotalTiempo = intTotalTiempo;
				new_values.curComida = curComida;
				new_values.intTotalTiempoVacio = intTotalTiempoVacio;
				new_values.curComidaVacio = curComidaVacio;
				new_values.cutParticipacion = cutParticipacion;
				new_values.cutParticipacionVacio = cutParticipacionVacio;
				new_values.curDesvareManoRepuestos = curDesvareManoRepuestos;
				new_values.curDesvareManoObra = curDesvareManoObra;
				new_values.cutKmts = cutKmts;
				new_values.logVacio = logVacio;
				new_values.ParqueaderoCarretera = ParqueaderoCarretera;
				new_values.ParqueaderoCiudad = ParqueaderoCiudad;
				new_values.MontadaLLantaCarretera = MontadaLLantaCarretera;
				new_values.Papeleria = Papeleria;
				new_values.AjusteCarretera = AjusteCarretera;
				new_values.CombustibleCarretera = CombustibleCarretera;
				new_values.Amarres_Amarres_1000 = Amarres_Amarres_1000;
				new_values.Engradasa = Engradasa;
				new_values.Calibrada = Calibrada;
				new_values.TipoVehiculoCodigo = TipoVehiculoCodigo;
				new_values.TipoVehiculo = TipoVehiculo;
				new_values.TipoTrailerCodigo = TipoTrailerCodigo;
				new_values.Peso = Peso;
				new_values.logEstadoRuta = logEstadoRuta;
				new_values.Trailer = Trailer;
				new_values.Aseo = Aseo;
				new_values.Contenedor1 = Contenedor1;
				new_values.Contenedor2 = Contenedor2;
				new_values.FactorCalculoDia = FactorCalculoDia;
				new_values.ValorCalculoFactor = ValorCalculoFactor;
				new_values.Liquidado = Liquidado;
				new_values.Taxi = Taxi;
				new_values.logFavorito = logFavorito;
				new_values.logAnticipoACPM = logAnticipoACPM;
				RutasDetTramosDataProvider.Instance.Update(Codigo, logAsigna_Chk_600, lngIdRegistrRuta, strRutaAnticipoGrupoOrigen, strRutaAnticipoGrupoDestino, strRutaAnticipo, floGalones, curValorGalon, cutCombustible, lngIdNroPeajes, cutPeaje, cutVariosLlantas, cutVariosCelada, cutVariosPropina, cutVarios, cutVariosLlantasVacio, cutVariosCeladaVacio, cutVariosPropinaVacio, cutVariosVacio, CurCargue, CurDescargue, curHotel, curHotelCarreteraVacio, curHotelCiudadVacio, curHotelVacio, intTotalTiempo, curComida, intTotalTiempoVacio, curComidaVacio, cutParticipacion, cutParticipacionVacio, curDesvareManoRepuestos, curDesvareManoObra, cutKmts, logVacio, ParqueaderoCarretera, ParqueaderoCiudad, MontadaLLantaCarretera, Papeleria, AjusteCarretera, CombustibleCarretera, Amarres_Amarres_1000, Engradasa, Calibrada, TipoVehiculoCodigo, TipoVehiculo, TipoTrailerCodigo, Peso, logEstadoRuta, Trailer, Aseo, Contenedor1, Contenedor2, FactorCalculoDia, ValorCalculoFactor, Liquidado, Taxi, logFavorito, logAnticipoACPM,"RutasDetTramos",datosTransaccion);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Updates an RutasDetTramos object by passing one object's instance as reference
		/// </summary>
		/// <param name="rutasdettramos">An instance of RutasDetTramos for reference</param>
		public void Update(RutasDetTramos rutasdettramos,Sinapsys.Datos.SQL datosTransaccion=null)
		{
			Update(rutasdettramos.Codigo, rutasdettramos.logAsigna_Chk_600, rutasdettramos.lngIdRegistrRuta, rutasdettramos.strRutaAnticipoGrupoOrigen, rutasdettramos.strRutaAnticipoGrupoDestino, rutasdettramos.strRutaAnticipo, rutasdettramos.floGalones, rutasdettramos.curValorGalon, rutasdettramos.cutCombustible, rutasdettramos.lngIdNroPeajes, rutasdettramos.cutPeaje, rutasdettramos.cutVariosLlantas, rutasdettramos.cutVariosCelada, rutasdettramos.cutVariosPropina, rutasdettramos.cutVarios, rutasdettramos.cutVariosLlantasVacio, rutasdettramos.cutVariosCeladaVacio, rutasdettramos.cutVariosPropinaVacio, rutasdettramos.cutVariosVacio, rutasdettramos.CurCargue, rutasdettramos.CurDescargue, rutasdettramos.curHotel, rutasdettramos.curHotelCarreteraVacio, rutasdettramos.curHotelCiudadVacio, rutasdettramos.curHotelVacio, rutasdettramos.intTotalTiempo, rutasdettramos.curComida, rutasdettramos.intTotalTiempoVacio, rutasdettramos.curComidaVacio, rutasdettramos.cutParticipacion, rutasdettramos.cutParticipacionVacio, rutasdettramos.curDesvareManoRepuestos, rutasdettramos.curDesvareManoObra, rutasdettramos.cutKmts, rutasdettramos.logVacio, rutasdettramos.ParqueaderoCarretera, rutasdettramos.ParqueaderoCiudad, rutasdettramos.MontadaLLantaCarretera, rutasdettramos.Papeleria, rutasdettramos.AjusteCarretera, rutasdettramos.CombustibleCarretera, rutasdettramos.Amarres_Amarres_1000, rutasdettramos.Engradasa, rutasdettramos.Calibrada, rutasdettramos.TipoVehiculoCodigo, rutasdettramos.TipoVehiculo, rutasdettramos.TipoTrailerCodigo, rutasdettramos.Peso, rutasdettramos.logEstadoRuta, rutasdettramos.Trailer, rutasdettramos.Aseo, rutasdettramos.Contenedor1, rutasdettramos.Contenedor2, rutasdettramos.FactorCalculoDia, rutasdettramos.ValorCalculoFactor, rutasdettramos.Liquidado, rutasdettramos.Taxi, rutasdettramos.logFavorito, rutasdettramos.logAnticipoACPM);
		}

		/// <summary>
		/// Delete  the RutasDetTramos object by passing a object
		/// </summary>
		public void  Delete(RutasDetTramos rutasdettramos, Sinapsys.Datos.SQL datosTransaccion=null)
		{
			Delete(rutasdettramos.Codigo,datosTransaccion);
		}

		/// <summary>
		/// Deletes the RutasDetTramos object by passing one object's instance as reference
		/// </summary>
		/// <param name="rutasdettramos">An instance of RutasDetTramos for reference</param>
		public void Delete(long Codigo, Sinapsys.Datos.SQL datosTransaccion=null)
		{
			try 
			{
				RutasDetTramosDataProvider.Instance.Delete(Codigo,"RutasDetTramos");
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Deletes the RutasDetTramos object by passing CVS parameter as reference
		/// </summary>
		/// <param name="rutasdettramos">An instance of RutasDetTramos for reference</param>
		public void Delete(string CVSParameter)
		{
			string[] StrCommand=CVSParameter.Split(',');
			try 
			{
				long Codigo=long.Parse(StrCommand[0]);
				RutasDetTramosDataProvider.Instance.Delete(Codigo,"RutasDetTramos");
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Gets the RutasDetTramos object by passing the object's key fields
		/// </summary>
		/// <param name="Codigo">long that contents the Codigo value for the RutasDetTramos object</param>
		/// <returns>One RutasDetTramos object</returns>
		public RutasDetTramos Get(long Codigo, bool generateUndo=false)
		{
			try 
			{
				RutasDetTramos rutasdettramos = null;
				DataTable dt = RutasDetTramosDataProvider.Instance.Get(Codigo);
				if ((dt.Rows.Count > 0))
				{
					rutasdettramos = new RutasDetTramos();
					DataRow dr = dt.Rows[0];
					ReadData(rutasdettramos, dr, generateUndo);
				}


				return rutasdettramos;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Gets all objects of RutasDetTramos
		/// </summary>
		/// <returns>One RutasDetTramosList object</returns>
		public RutasDetTramosList GetAll(bool generateUndo=false)
		{
			try 
			{
				RutasDetTramosList rutasdettramoslist = new RutasDetTramosList();
				DataTable dt = RutasDetTramosDataProvider.Instance.GetAll();
				foreach (DataRow dr in dt.Rows)
				{
					RutasDetTramos rutasdettramos = new RutasDetTramos();
					ReadData(rutasdettramos, dr, generateUndo);
					rutasdettramoslist.Add(rutasdettramos);
				}
				return rutasdettramoslist;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Gets all objects of RutasDetTramos applying filter and sort criteria
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
		/// <returns>One RutasDetTramosList object</returns>
		public RutasDetTramosList GetFilter(int pagenum, int pagesize, string filter, string sort, string extablesfilter, string extablesfieldsfilter, string extablesrelationsfilter, string extablessort, string extablesfieldssort, string extablesrelationssort, bool generateUndo=false)
		{
			try 
			{
				RutasDetTramosList rutasdettramoslist = new RutasDetTramosList();

				DataTable dt = RutasDetTramosDataProvider.Instance.GetFilter(pagenum, pagesize, filter, sort, extablesfilter, extablesfieldsfilter, extablesrelationsfilter, extablessort, extablesfieldssort, extablesrelationssort);

				foreach (DataRow dr in dt.Rows)
				{
					RutasDetTramos rutasdettramos = new RutasDetTramos();
					ReadData(rutasdettramos, dr, generateUndo);
					rutasdettramoslist.Add(rutasdettramos);
				}
				return rutasdettramoslist;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public RutasDetTramosList GetFilter( string filter, string sort, bool generateUndo=false)
		{
			return GetFilter(0,0, filter, sort, "","","","","","",generateUndo);
		}

		public RutasDetTramosList GetFilter(string filter, string sort, string extablesfilter, string extablesfieldsfilter, string extablesrelationsfilter, string extablessort, string extablesfieldssort, string extablesrelationssort, bool generateUndo=false)
		{
			return GetFilter(0,0, filter, sort, extablesfilter, extablesfieldsfilter, extablesrelationsfilter, extablessort, extablesfieldssort, extablesrelationssort,generateUndo);
		}


		/// <summary>
		/// Returns the type for one property
		/// </summary>
		/// <param name="propertyname">Property's name for return its value</param>
		/// <returns>A value for the <paramref name="propertyname"/></returns>
		public Type GetMethodType( string propertyname,RutasDetTramos rutasdettramos)
		{
			// Perform the search for the property's value
			switch (propertyname)
			{
				case "Codigo":
					return rutasdettramos.Codigo.GetType();

				case "logAsigna_Chk_600":
					return rutasdettramos.logAsigna_Chk_600.GetType();

				case "lngIdRegistrRuta":
					return rutasdettramos.lngIdRegistrRuta.GetType();

				case "strRutaAnticipoGrupoOrigen":
					return rutasdettramos.strRutaAnticipoGrupoOrigen.GetType();

				case "strRutaAnticipoGrupoDestino":
					return rutasdettramos.strRutaAnticipoGrupoDestino.GetType();

				case "strRutaAnticipo":
					return rutasdettramos.strRutaAnticipo.GetType();

				case "floGalones":
					return rutasdettramos.floGalones.GetType();

				case "curValorGalon":
					return rutasdettramos.curValorGalon.GetType();

				case "cutCombustible":
					return rutasdettramos.cutCombustible.GetType();

				case "lngIdNroPeajes":
					return rutasdettramos.lngIdNroPeajes.GetType();

				case "cutPeaje":
					return rutasdettramos.cutPeaje.GetType();

				case "cutVariosLlantas":
					return rutasdettramos.cutVariosLlantas.GetType();

				case "cutVariosCelada":
					return rutasdettramos.cutVariosCelada.GetType();

				case "cutVariosPropina":
					return rutasdettramos.cutVariosPropina.GetType();

				case "cutVarios":
					return rutasdettramos.cutVarios.GetType();

				case "cutVariosLlantasVacio":
					return rutasdettramos.cutVariosLlantasVacio.GetType();

				case "cutVariosCeladaVacio":
					return rutasdettramos.cutVariosCeladaVacio.GetType();

				case "cutVariosPropinaVacio":
					return rutasdettramos.cutVariosPropinaVacio.GetType();

				case "cutVariosVacio":
					return rutasdettramos.cutVariosVacio.GetType();

				case "CurCargue":
					return rutasdettramos.CurCargue.GetType();

				case "CurDescargue":
					return rutasdettramos.CurDescargue.GetType();

				case "curHotel":
					return rutasdettramos.curHotel.GetType();

				case "curHotelCarreteraVacio":
					return rutasdettramos.curHotelCarreteraVacio.GetType();

				case "curHotelCiudadVacio":
					return rutasdettramos.curHotelCiudadVacio.GetType();

				case "curHotelVacio":
					return rutasdettramos.curHotelVacio.GetType();

				case "intTotalTiempo":
					return rutasdettramos.intTotalTiempo.GetType();

				case "curComida":
					return rutasdettramos.curComida.GetType();

				case "intTotalTiempoVacio":
					return rutasdettramos.intTotalTiempoVacio.GetType();

				case "curComidaVacio":
					return rutasdettramos.curComidaVacio.GetType();

				case "cutParticipacion":
					return rutasdettramos.cutParticipacion.GetType();

				case "cutParticipacionVacio":
					return rutasdettramos.cutParticipacionVacio.GetType();

				case "curDesvareManoRepuestos":
					return rutasdettramos.curDesvareManoRepuestos.GetType();

				case "curDesvareManoObra":
					return rutasdettramos.curDesvareManoObra.GetType();

				case "cutKmts":
					return rutasdettramos.cutKmts.GetType();

				case "logVacio":
					return rutasdettramos.logVacio.GetType();

				case "ParqueaderoCarretera":
					return rutasdettramos.ParqueaderoCarretera.GetType();

				case "ParqueaderoCiudad":
					return rutasdettramos.ParqueaderoCiudad.GetType();

				case "MontadaLLantaCarretera":
					return rutasdettramos.MontadaLLantaCarretera.GetType();

				case "Papeleria":
					return rutasdettramos.Papeleria.GetType();

				case "AjusteCarretera":
					return rutasdettramos.AjusteCarretera.GetType();

				case "CombustibleCarretera":
					return rutasdettramos.CombustibleCarretera.GetType();

				case "Amarres_Amarres_1000":
					return rutasdettramos.Amarres_Amarres_1000.GetType();

				case "Engradasa":
					return rutasdettramos.Engradasa.GetType();

				case "Calibrada":
					return rutasdettramos.Calibrada.GetType();

				case "TipoVehiculoCodigo":
					return rutasdettramos.TipoVehiculoCodigo.GetType();

				case "TipoVehiculo":
					return rutasdettramos.TipoVehiculo.GetType();

				case "TipoTrailerCodigo":
					return rutasdettramos.TipoTrailerCodigo.GetType();

				case "Peso":
					return rutasdettramos.Peso.GetType();

				case "logEstadoRuta":
					return rutasdettramos.logEstadoRuta.GetType();

				case "Trailer":
					return rutasdettramos.Trailer.GetType();

				case "Aseo":
					return rutasdettramos.Aseo.GetType();

				case "Contenedor1":
					return rutasdettramos.Contenedor1.GetType();

				case "Contenedor2":
					return rutasdettramos.Contenedor2.GetType();

				case "FactorCalculoDia":
					return rutasdettramos.FactorCalculoDia.GetType();

				case "ValorCalculoFactor":
					return rutasdettramos.ValorCalculoFactor.GetType();

				case "Liquidado":
					return rutasdettramos.Liquidado.GetType();

				case "Taxi":
					return rutasdettramos.Taxi.GetType();

				case "logFavorito":
					return rutasdettramos.logFavorito.GetType();

				case "logAnticipoACPM":
					return rutasdettramos.logAnticipoACPM.GetType();

			}

			return null;
		}
		/// <summary>
		/// update the changes in RutasDetTramos object by passing the object
		/// </summary>
		public bool UpdateChanges(RutasDetTramos rutasdettramos, out string error,Sinapsys.Datos.SQL datosTransaccion=null)
		{
			if (rutasdettramos.OldRutasDetTramos == null)
			{
				    error = "No tiene objeto con el cual comparar";
				    return false;
			}
			string[] Fields = rutasdettramos.FieldChanged();
			error = "";
			return LiqViajes_Bll_Data.DataProvider.UpdateFieldsbyObject(Fields, rutasdettramos, out error,datosTransaccion);
		}
	}

	#endregion

}
