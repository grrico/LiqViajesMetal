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
	#region Tempo_tblLiquidacionRutasController

	/// <summary>
	/// Class for convert data from database into object's data and vice versa
	/// </summary>
	public partial class Tempo_tblLiquidacionRutasController//: ILatinodeController
	{
		/// <summary>
		/// Generic Constructor
		/// </summary>
		public Tempo_tblLiquidacionRutasController()
		{
		}

		/// <summary>
		/// Instance accessor for this singleton
		/// </summary>
		private static Tempo_tblLiquidacionRutasController MySingleObj;
		public static Tempo_tblLiquidacionRutasController Instance
		{
			get
			{
				if (MySingleObj == null)
				{
					MySingleObj = new Tempo_tblLiquidacionRutasController();
				}
				return MySingleObj;
			}
		}

		// Reads object's data from a DataRow
		private void ReadData(Tempo_tblLiquidacionRutas tempo_tblliquidacionrutas, DataRow dr,bool generateUndo=false)
		{
			try 
			{
				tempo_tblliquidacionrutas.lngIdRegistrRutaItemId = (int) dr["lngIdRegistrRutaItemId"];
				tempo_tblliquidacionrutas.lngIdRegistrRuta = dr.IsNull("lngIdRegistrRuta") ? null :(int?) dr["lngIdRegistrRuta"];
				tempo_tblliquidacionrutas.lngIdRegistro = dr.IsNull("lngIdRegistro") ? null :(int?) dr["lngIdRegistro"];
				tempo_tblliquidacionrutas.strRutaAnticipoGrupoOrigen = dr.IsNull("strRutaAnticipoGrupoOrigen") ? null :(string) dr["strRutaAnticipoGrupoOrigen"];
				tempo_tblliquidacionrutas.strRutaAnticipoGrupoDestino = dr.IsNull("strRutaAnticipoGrupoDestino") ? null :(string) dr["strRutaAnticipoGrupoDestino"];
				tempo_tblliquidacionrutas.strRutaAnticipoGrupo = dr.IsNull("strRutaAnticipoGrupo") ? null :(string) dr["strRutaAnticipoGrupo"];
				tempo_tblliquidacionrutas.strRutaAnticipo = dr.IsNull("strRutaAnticipo") ? null :(string) dr["strRutaAnticipo"];
				tempo_tblliquidacionrutas.floGalones = dr.IsNull("floGalones") ? null :(decimal?) dr["floGalones"];
				tempo_tblliquidacionrutas.curValorGalon = dr.IsNull("curValorGalon") ? null :(decimal?) dr["curValorGalon"];
				tempo_tblliquidacionrutas.cutCombustible = dr.IsNull("cutCombustible") ? null :(decimal?) dr["cutCombustible"];
				tempo_tblliquidacionrutas.lngIdNroPeajes = dr.IsNull("lngIdNroPeajes") ? null :(int?) dr["lngIdNroPeajes"];
				tempo_tblliquidacionrutas.cutPeaje = dr.IsNull("cutPeaje") ? null :(decimal?) dr["cutPeaje"];
				tempo_tblliquidacionrutas.strNombrePeajes = dr.IsNull("strNombrePeajes") ? null :(string) dr["strNombrePeajes"];
				tempo_tblliquidacionrutas.cutVariosLlantas = dr.IsNull("cutVariosLlantas") ? null :(decimal?) dr["cutVariosLlantas"];
				tempo_tblliquidacionrutas.cutVariosCelada = dr.IsNull("cutVariosCelada") ? null :(decimal?) dr["cutVariosCelada"];
				tempo_tblliquidacionrutas.cutVariosPropina = dr.IsNull("cutVariosPropina") ? null :(decimal?) dr["cutVariosPropina"];
				tempo_tblliquidacionrutas.cutVarios = dr.IsNull("cutVarios") ? null :(decimal?) dr["cutVarios"];
				tempo_tblliquidacionrutas.cutVariosLlantasVacio = dr.IsNull("cutVariosLlantasVacio") ? null :(decimal?) dr["cutVariosLlantasVacio"];
				tempo_tblliquidacionrutas.cutVariosCeladaVacio = dr.IsNull("cutVariosCeladaVacio") ? null :(decimal?) dr["cutVariosCeladaVacio"];
				tempo_tblliquidacionrutas.cutVariosPropinaVacio = dr.IsNull("cutVariosPropinaVacio") ? null :(decimal?) dr["cutVariosPropinaVacio"];
				tempo_tblliquidacionrutas.cutVariosVacio = dr.IsNull("cutVariosVacio") ? null :(decimal?) dr["cutVariosVacio"];
				tempo_tblliquidacionrutas.cutParticipacion = dr.IsNull("cutParticipacion") ? null :(decimal?) dr["cutParticipacion"];
				tempo_tblliquidacionrutas.cutParticipacionVacio = dr.IsNull("cutParticipacionVacio") ? null :(decimal?) dr["cutParticipacionVacio"];
				tempo_tblliquidacionrutas.curHotelCarretera = dr.IsNull("curHotelCarretera") ? null :(int?) dr["curHotelCarretera"];
				tempo_tblliquidacionrutas.curHotelCiudad = dr.IsNull("curHotelCiudad") ? null :(int?) dr["curHotelCiudad"];
				tempo_tblliquidacionrutas.curHotel = dr.IsNull("curHotel") ? null :(decimal?) dr["curHotel"];
				tempo_tblliquidacionrutas.curHotelCarreteraVacio = dr.IsNull("curHotelCarreteraVacio") ? null :(int?) dr["curHotelCarreteraVacio"];
				tempo_tblliquidacionrutas.curHotelCiudadVacio = dr.IsNull("curHotelCiudadVacio") ? null :(int?) dr["curHotelCiudadVacio"];
				tempo_tblliquidacionrutas.curHotelVacio = dr.IsNull("curHotelVacio") ? null :(decimal?) dr["curHotelVacio"];
				tempo_tblliquidacionrutas.intTiempoCargue = dr.IsNull("intTiempoCargue") ? null :(decimal?) dr["intTiempoCargue"];
				tempo_tblliquidacionrutas.intTiempoDescargue = dr.IsNull("intTiempoDescargue") ? null :(decimal?) dr["intTiempoDescargue"];
				tempo_tblliquidacionrutas.intTiempoAduana = dr.IsNull("intTiempoAduana") ? null :(decimal?) dr["intTiempoAduana"];
				tempo_tblliquidacionrutas.intTotalTrayecto = dr.IsNull("intTotalTrayecto") ? null :(decimal?) dr["intTotalTrayecto"];
				tempo_tblliquidacionrutas.intTotalTiempo = dr.IsNull("intTotalTiempo") ? null :(decimal?) dr["intTotalTiempo"];
				tempo_tblliquidacionrutas.curComida = dr.IsNull("curComida") ? null :(decimal?) dr["curComida"];
				tempo_tblliquidacionrutas.intTiempoCargueVacio = dr.IsNull("intTiempoCargueVacio") ? null :(decimal?) dr["intTiempoCargueVacio"];
				tempo_tblliquidacionrutas.intTiempoDescargueVacio = dr.IsNull("intTiempoDescargueVacio") ? null :(decimal?) dr["intTiempoDescargueVacio"];
				tempo_tblliquidacionrutas.intTiempoAduanaVacio = dr.IsNull("intTiempoAduanaVacio") ? null :(decimal?) dr["intTiempoAduanaVacio"];
				tempo_tblliquidacionrutas.intTotalTrayectoVacio = dr.IsNull("intTotalTrayectoVacio") ? null :(decimal?) dr["intTotalTrayectoVacio"];
				tempo_tblliquidacionrutas.intTotalTiempoVacio = dr.IsNull("intTotalTiempoVacio") ? null :(decimal?) dr["intTotalTiempoVacio"];
				tempo_tblliquidacionrutas.curComidaVacio = dr.IsNull("curComidaVacio") ? null :(decimal?) dr["curComidaVacio"];
				tempo_tblliquidacionrutas.curDesvareManoRepuestos = dr.IsNull("curDesvareManoRepuestos") ? null :(decimal?) dr["curDesvareManoRepuestos"];
				tempo_tblliquidacionrutas.curDesvareManoObra = dr.IsNull("curDesvareManoObra") ? null :(decimal?) dr["curDesvareManoObra"];
				tempo_tblliquidacionrutas.cutSaldo = dr.IsNull("cutSaldo") ? null :(decimal?) dr["cutSaldo"];
				tempo_tblliquidacionrutas.cutKmts = dr.IsNull("cutKmts") ? null :(decimal?) dr["cutKmts"];
				tempo_tblliquidacionrutas.logAjuste = dr.IsNull("logAjuste") ? null :(bool?) dr["logAjuste"];
				tempo_tblliquidacionrutas.lngIdRegistrRutaItemIdAjc = dr.IsNull("lngIdRegistrRutaItemIdAjc") ? null :(int?) dr["lngIdRegistrRutaItemIdAjc"];
				tempo_tblliquidacionrutas.lngIdUsuario = dr.IsNull("lngIdUsuario") ? null :(int?) dr["lngIdUsuario"];
			}
			catch (Exception ex)
			{
				Utilidades.LogErrores(ex.Message + (ex.InnerException != null ? ex.InnerException.Message : ""), DataProvider.AplicacionNombre);
				throw ex;
			}
			if (generateUndo) tempo_tblliquidacionrutas.GenerateUndo();
		}

		/// <summary>
		/// Create a new Tempo_tblLiquidacionRutas object by passing a object
		/// </summary>
		public Tempo_tblLiquidacionRutas Create(Tempo_tblLiquidacionRutas tempo_tblliquidacionrutas, Sinapsys.Datos.SQL datosTransaccion=null)
		{
			return Create(tempo_tblliquidacionrutas.lngIdRegistrRutaItemId,tempo_tblliquidacionrutas.lngIdRegistrRuta,tempo_tblliquidacionrutas.lngIdRegistro,tempo_tblliquidacionrutas.strRutaAnticipoGrupoOrigen,tempo_tblliquidacionrutas.strRutaAnticipoGrupoDestino,tempo_tblliquidacionrutas.strRutaAnticipoGrupo,tempo_tblliquidacionrutas.strRutaAnticipo,tempo_tblliquidacionrutas.floGalones,tempo_tblliquidacionrutas.curValorGalon,tempo_tblliquidacionrutas.cutCombustible,tempo_tblliquidacionrutas.lngIdNroPeajes,tempo_tblliquidacionrutas.cutPeaje,tempo_tblliquidacionrutas.strNombrePeajes,tempo_tblliquidacionrutas.cutVariosLlantas,tempo_tblliquidacionrutas.cutVariosCelada,tempo_tblliquidacionrutas.cutVariosPropina,tempo_tblliquidacionrutas.cutVarios,tempo_tblliquidacionrutas.cutVariosLlantasVacio,tempo_tblliquidacionrutas.cutVariosCeladaVacio,tempo_tblliquidacionrutas.cutVariosPropinaVacio,tempo_tblliquidacionrutas.cutVariosVacio,tempo_tblliquidacionrutas.cutParticipacion,tempo_tblliquidacionrutas.cutParticipacionVacio,tempo_tblliquidacionrutas.curHotelCarretera,tempo_tblliquidacionrutas.curHotelCiudad,tempo_tblliquidacionrutas.curHotel,tempo_tblliquidacionrutas.curHotelCarreteraVacio,tempo_tblliquidacionrutas.curHotelCiudadVacio,tempo_tblliquidacionrutas.curHotelVacio,tempo_tblliquidacionrutas.intTiempoCargue,tempo_tblliquidacionrutas.intTiempoDescargue,tempo_tblliquidacionrutas.intTiempoAduana,tempo_tblliquidacionrutas.intTotalTrayecto,tempo_tblliquidacionrutas.intTotalTiempo,tempo_tblliquidacionrutas.curComida,tempo_tblliquidacionrutas.intTiempoCargueVacio,tempo_tblliquidacionrutas.intTiempoDescargueVacio,tempo_tblliquidacionrutas.intTiempoAduanaVacio,tempo_tblliquidacionrutas.intTotalTrayectoVacio,tempo_tblliquidacionrutas.intTotalTiempoVacio,tempo_tblliquidacionrutas.curComidaVacio,tempo_tblliquidacionrutas.curDesvareManoRepuestos,tempo_tblliquidacionrutas.curDesvareManoObra,tempo_tblliquidacionrutas.cutSaldo,tempo_tblliquidacionrutas.cutKmts,tempo_tblliquidacionrutas.logAjuste,tempo_tblliquidacionrutas.lngIdRegistrRutaItemIdAjc,tempo_tblliquidacionrutas.lngIdUsuario,datosTransaccion);
		}

		/// <summary>
		/// Creates a new Tempo_tblLiquidacionRutas object by passing all object's fields
		/// </summary>
		/// <param name="lngIdRegistrRutaItemId">int that contents the lngIdRegistrRutaItemId value for the Tempo_tblLiquidacionRutas object</param>
		/// <param name="lngIdRegistrRuta">int that contents the lngIdRegistrRuta value for the Tempo_tblLiquidacionRutas object</param>
		/// <param name="lngIdRegistro">int that contents the lngIdRegistro value for the Tempo_tblLiquidacionRutas object</param>
		/// <param name="strRutaAnticipoGrupoOrigen">string that contents the strRutaAnticipoGrupoOrigen value for the Tempo_tblLiquidacionRutas object</param>
		/// <param name="strRutaAnticipoGrupoDestino">string that contents the strRutaAnticipoGrupoDestino value for the Tempo_tblLiquidacionRutas object</param>
		/// <param name="strRutaAnticipoGrupo">string that contents the strRutaAnticipoGrupo value for the Tempo_tblLiquidacionRutas object</param>
		/// <param name="strRutaAnticipo">string that contents the strRutaAnticipo value for the Tempo_tblLiquidacionRutas object</param>
		/// <param name="floGalones">decimal that contents the floGalones value for the Tempo_tblLiquidacionRutas object</param>
		/// <param name="curValorGalon">decimal that contents the curValorGalon value for the Tempo_tblLiquidacionRutas object</param>
		/// <param name="cutCombustible">decimal that contents the cutCombustible value for the Tempo_tblLiquidacionRutas object</param>
		/// <param name="lngIdNroPeajes">int that contents the lngIdNroPeajes value for the Tempo_tblLiquidacionRutas object</param>
		/// <param name="cutPeaje">decimal that contents the cutPeaje value for the Tempo_tblLiquidacionRutas object</param>
		/// <param name="strNombrePeajes">string that contents the strNombrePeajes value for the Tempo_tblLiquidacionRutas object</param>
		/// <param name="cutVariosLlantas">decimal that contents the cutVariosLlantas value for the Tempo_tblLiquidacionRutas object</param>
		/// <param name="cutVariosCelada">decimal that contents the cutVariosCelada value for the Tempo_tblLiquidacionRutas object</param>
		/// <param name="cutVariosPropina">decimal that contents the cutVariosPropina value for the Tempo_tblLiquidacionRutas object</param>
		/// <param name="cutVarios">decimal that contents the cutVarios value for the Tempo_tblLiquidacionRutas object</param>
		/// <param name="cutVariosLlantasVacio">decimal that contents the cutVariosLlantasVacio value for the Tempo_tblLiquidacionRutas object</param>
		/// <param name="cutVariosCeladaVacio">decimal that contents the cutVariosCeladaVacio value for the Tempo_tblLiquidacionRutas object</param>
		/// <param name="cutVariosPropinaVacio">decimal that contents the cutVariosPropinaVacio value for the Tempo_tblLiquidacionRutas object</param>
		/// <param name="cutVariosVacio">decimal that contents the cutVariosVacio value for the Tempo_tblLiquidacionRutas object</param>
		/// <param name="cutParticipacion">decimal that contents the cutParticipacion value for the Tempo_tblLiquidacionRutas object</param>
		/// <param name="cutParticipacionVacio">decimal that contents the cutParticipacionVacio value for the Tempo_tblLiquidacionRutas object</param>
		/// <param name="curHotelCarretera">int that contents the curHotelCarretera value for the Tempo_tblLiquidacionRutas object</param>
		/// <param name="curHotelCiudad">int that contents the curHotelCiudad value for the Tempo_tblLiquidacionRutas object</param>
		/// <param name="curHotel">decimal that contents the curHotel value for the Tempo_tblLiquidacionRutas object</param>
		/// <param name="curHotelCarreteraVacio">int that contents the curHotelCarreteraVacio value for the Tempo_tblLiquidacionRutas object</param>
		/// <param name="curHotelCiudadVacio">int that contents the curHotelCiudadVacio value for the Tempo_tblLiquidacionRutas object</param>
		/// <param name="curHotelVacio">decimal that contents the curHotelVacio value for the Tempo_tblLiquidacionRutas object</param>
		/// <param name="intTiempoCargue">decimal that contents the intTiempoCargue value for the Tempo_tblLiquidacionRutas object</param>
		/// <param name="intTiempoDescargue">decimal that contents the intTiempoDescargue value for the Tempo_tblLiquidacionRutas object</param>
		/// <param name="intTiempoAduana">decimal that contents the intTiempoAduana value for the Tempo_tblLiquidacionRutas object</param>
		/// <param name="intTotalTrayecto">decimal that contents the intTotalTrayecto value for the Tempo_tblLiquidacionRutas object</param>
		/// <param name="intTotalTiempo">decimal that contents the intTotalTiempo value for the Tempo_tblLiquidacionRutas object</param>
		/// <param name="curComida">decimal that contents the curComida value for the Tempo_tblLiquidacionRutas object</param>
		/// <param name="intTiempoCargueVacio">decimal that contents the intTiempoCargueVacio value for the Tempo_tblLiquidacionRutas object</param>
		/// <param name="intTiempoDescargueVacio">decimal that contents the intTiempoDescargueVacio value for the Tempo_tblLiquidacionRutas object</param>
		/// <param name="intTiempoAduanaVacio">decimal that contents the intTiempoAduanaVacio value for the Tempo_tblLiquidacionRutas object</param>
		/// <param name="intTotalTrayectoVacio">decimal that contents the intTotalTrayectoVacio value for the Tempo_tblLiquidacionRutas object</param>
		/// <param name="intTotalTiempoVacio">decimal that contents the intTotalTiempoVacio value for the Tempo_tblLiquidacionRutas object</param>
		/// <param name="curComidaVacio">decimal that contents the curComidaVacio value for the Tempo_tblLiquidacionRutas object</param>
		/// <param name="curDesvareManoRepuestos">decimal that contents the curDesvareManoRepuestos value for the Tempo_tblLiquidacionRutas object</param>
		/// <param name="curDesvareManoObra">decimal that contents the curDesvareManoObra value for the Tempo_tblLiquidacionRutas object</param>
		/// <param name="cutSaldo">decimal that contents the cutSaldo value for the Tempo_tblLiquidacionRutas object</param>
		/// <param name="cutKmts">decimal that contents the cutKmts value for the Tempo_tblLiquidacionRutas object</param>
		/// <param name="logAjuste">bool that contents the logAjuste value for the Tempo_tblLiquidacionRutas object</param>
		/// <param name="lngIdRegistrRutaItemIdAjc">int that contents the lngIdRegistrRutaItemIdAjc value for the Tempo_tblLiquidacionRutas object</param>
		/// <param name="lngIdUsuario">int that contents the lngIdUsuario value for the Tempo_tblLiquidacionRutas object</param>
		/// <returns>One Tempo_tblLiquidacionRutas object</returns>
		public Tempo_tblLiquidacionRutas Create(int lngIdRegistrRutaItemId, int? lngIdRegistrRuta, int? lngIdRegistro, string strRutaAnticipoGrupoOrigen, string strRutaAnticipoGrupoDestino, string strRutaAnticipoGrupo, string strRutaAnticipo, decimal? floGalones, decimal? curValorGalon, decimal? cutCombustible, int? lngIdNroPeajes, decimal? cutPeaje, string strNombrePeajes, decimal? cutVariosLlantas, decimal? cutVariosCelada, decimal? cutVariosPropina, decimal? cutVarios, decimal? cutVariosLlantasVacio, decimal? cutVariosCeladaVacio, decimal? cutVariosPropinaVacio, decimal? cutVariosVacio, decimal? cutParticipacion, decimal? cutParticipacionVacio, int? curHotelCarretera, int? curHotelCiudad, decimal? curHotel, int? curHotelCarreteraVacio, int? curHotelCiudadVacio, decimal? curHotelVacio, decimal? intTiempoCargue, decimal? intTiempoDescargue, decimal? intTiempoAduana, decimal? intTotalTrayecto, decimal? intTotalTiempo, decimal? curComida, decimal? intTiempoCargueVacio, decimal? intTiempoDescargueVacio, decimal? intTiempoAduanaVacio, decimal? intTotalTrayectoVacio, decimal? intTotalTiempoVacio, decimal? curComidaVacio, decimal? curDesvareManoRepuestos, decimal? curDesvareManoObra, decimal? cutSaldo, decimal? cutKmts, bool? logAjuste, int? lngIdRegistrRutaItemIdAjc, int? lngIdUsuario, Sinapsys.Datos.SQL datosTransaccion=null)
		{
			try 
			{
				Tempo_tblLiquidacionRutas tempo_tblliquidacionrutas = new Tempo_tblLiquidacionRutas();

				tempo_tblliquidacionrutas.lngIdRegistrRutaItemId = lngIdRegistrRutaItemId;
				tempo_tblliquidacionrutas.lngIdRegistrRuta = lngIdRegistrRuta;
				tempo_tblliquidacionrutas.lngIdRegistro = lngIdRegistro;
				tempo_tblliquidacionrutas.strRutaAnticipoGrupoOrigen = strRutaAnticipoGrupoOrigen;
				tempo_tblliquidacionrutas.strRutaAnticipoGrupoDestino = strRutaAnticipoGrupoDestino;
				tempo_tblliquidacionrutas.strRutaAnticipoGrupo = strRutaAnticipoGrupo;
				tempo_tblliquidacionrutas.strRutaAnticipo = strRutaAnticipo;
				tempo_tblliquidacionrutas.floGalones = floGalones;
				tempo_tblliquidacionrutas.curValorGalon = curValorGalon;
				tempo_tblliquidacionrutas.cutCombustible = cutCombustible;
				tempo_tblliquidacionrutas.lngIdNroPeajes = lngIdNroPeajes;
				tempo_tblliquidacionrutas.cutPeaje = cutPeaje;
				tempo_tblliquidacionrutas.strNombrePeajes = strNombrePeajes;
				tempo_tblliquidacionrutas.cutVariosLlantas = cutVariosLlantas;
				tempo_tblliquidacionrutas.cutVariosCelada = cutVariosCelada;
				tempo_tblliquidacionrutas.cutVariosPropina = cutVariosPropina;
				tempo_tblliquidacionrutas.cutVarios = cutVarios;
				tempo_tblliquidacionrutas.cutVariosLlantasVacio = cutVariosLlantasVacio;
				tempo_tblliquidacionrutas.cutVariosCeladaVacio = cutVariosCeladaVacio;
				tempo_tblliquidacionrutas.cutVariosPropinaVacio = cutVariosPropinaVacio;
				tempo_tblliquidacionrutas.cutVariosVacio = cutVariosVacio;
				tempo_tblliquidacionrutas.cutParticipacion = cutParticipacion;
				tempo_tblliquidacionrutas.cutParticipacionVacio = cutParticipacionVacio;
				tempo_tblliquidacionrutas.curHotelCarretera = curHotelCarretera;
				tempo_tblliquidacionrutas.curHotelCiudad = curHotelCiudad;
				tempo_tblliquidacionrutas.curHotel = curHotel;
				tempo_tblliquidacionrutas.curHotelCarreteraVacio = curHotelCarreteraVacio;
				tempo_tblliquidacionrutas.curHotelCiudadVacio = curHotelCiudadVacio;
				tempo_tblliquidacionrutas.curHotelVacio = curHotelVacio;
				tempo_tblliquidacionrutas.intTiempoCargue = intTiempoCargue;
				tempo_tblliquidacionrutas.intTiempoDescargue = intTiempoDescargue;
				tempo_tblliquidacionrutas.intTiempoAduana = intTiempoAduana;
				tempo_tblliquidacionrutas.intTotalTrayecto = intTotalTrayecto;
				tempo_tblliquidacionrutas.intTotalTiempo = intTotalTiempo;
				tempo_tblliquidacionrutas.curComida = curComida;
				tempo_tblliquidacionrutas.intTiempoCargueVacio = intTiempoCargueVacio;
				tempo_tblliquidacionrutas.intTiempoDescargueVacio = intTiempoDescargueVacio;
				tempo_tblliquidacionrutas.intTiempoAduanaVacio = intTiempoAduanaVacio;
				tempo_tblliquidacionrutas.intTotalTrayectoVacio = intTotalTrayectoVacio;
				tempo_tblliquidacionrutas.intTotalTiempoVacio = intTotalTiempoVacio;
				tempo_tblliquidacionrutas.curComidaVacio = curComidaVacio;
				tempo_tblliquidacionrutas.curDesvareManoRepuestos = curDesvareManoRepuestos;
				tempo_tblliquidacionrutas.curDesvareManoObra = curDesvareManoObra;
				tempo_tblliquidacionrutas.cutSaldo = cutSaldo;
				tempo_tblliquidacionrutas.cutKmts = cutKmts;
				tempo_tblliquidacionrutas.logAjuste = logAjuste;
				tempo_tblliquidacionrutas.lngIdRegistrRutaItemIdAjc = lngIdRegistrRutaItemIdAjc;
				tempo_tblliquidacionrutas.lngIdUsuario = lngIdUsuario;
				Tempo_tblLiquidacionRutasDataProvider.Instance.Create(lngIdRegistrRutaItemId, lngIdRegistrRuta, lngIdRegistro, strRutaAnticipoGrupoOrigen, strRutaAnticipoGrupoDestino, strRutaAnticipoGrupo, strRutaAnticipo, floGalones, curValorGalon, cutCombustible, lngIdNroPeajes, cutPeaje, strNombrePeajes, cutVariosLlantas, cutVariosCelada, cutVariosPropina, cutVarios, cutVariosLlantasVacio, cutVariosCeladaVacio, cutVariosPropinaVacio, cutVariosVacio, cutParticipacion, cutParticipacionVacio, curHotelCarretera, curHotelCiudad, curHotel, curHotelCarreteraVacio, curHotelCiudadVacio, curHotelVacio, intTiempoCargue, intTiempoDescargue, intTiempoAduana, intTotalTrayecto, intTotalTiempo, curComida, intTiempoCargueVacio, intTiempoDescargueVacio, intTiempoAduanaVacio, intTotalTrayectoVacio, intTotalTiempoVacio, curComidaVacio, curDesvareManoRepuestos, curDesvareManoObra, cutSaldo, cutKmts, logAjuste, lngIdRegistrRutaItemIdAjc, lngIdUsuario,"Tempo_tblLiquidacionRutas");

				return tempo_tblliquidacionrutas;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Gets all objects of Tempo_tblLiquidacionRutas
		/// </summary>
		/// <returns>One Tempo_tblLiquidacionRutasList object</returns>
		public Tempo_tblLiquidacionRutasList GetAll(bool generateUndo=false)
		{
			try 
			{
				Tempo_tblLiquidacionRutasList tempo_tblliquidacionrutaslist = new Tempo_tblLiquidacionRutasList();
				DataTable dt = Tempo_tblLiquidacionRutasDataProvider.Instance.GetAll();
				foreach (DataRow dr in dt.Rows)
				{
					Tempo_tblLiquidacionRutas tempo_tblliquidacionrutas = new Tempo_tblLiquidacionRutas();
					ReadData(tempo_tblliquidacionrutas, dr, generateUndo);
					tempo_tblliquidacionrutaslist.Add(tempo_tblliquidacionrutas);
				}
				return tempo_tblliquidacionrutaslist;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Gets all objects of Tempo_tblLiquidacionRutas applying filter and sort criteria
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
		/// <returns>One Tempo_tblLiquidacionRutasList object</returns>
		public Tempo_tblLiquidacionRutasList GetFilter(int pagenum, int pagesize, string filter, string sort, string extablesfilter, string extablesfieldsfilter, string extablesrelationsfilter, string extablessort, string extablesfieldssort, string extablesrelationssort, bool generateUndo=false)
		{
			try 
			{
				Tempo_tblLiquidacionRutasList tempo_tblliquidacionrutaslist = new Tempo_tblLiquidacionRutasList();

				DataTable dt = Tempo_tblLiquidacionRutasDataProvider.Instance.GetFilter(pagenum, pagesize, filter, sort, extablesfilter, extablesfieldsfilter, extablesrelationsfilter, extablessort, extablesfieldssort, extablesrelationssort);

				foreach (DataRow dr in dt.Rows)
				{
					Tempo_tblLiquidacionRutas tempo_tblliquidacionrutas = new Tempo_tblLiquidacionRutas();
					ReadData(tempo_tblliquidacionrutas, dr, generateUndo);
					tempo_tblliquidacionrutaslist.Add(tempo_tblliquidacionrutas);
				}
				return tempo_tblliquidacionrutaslist;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public Tempo_tblLiquidacionRutasList GetFilter( string filter, string sort, bool generateUndo=false)
		{
			return GetFilter(0,0, filter, sort, "","","","","","",generateUndo);
		}

		public Tempo_tblLiquidacionRutasList GetFilter(string filter, string sort, string extablesfilter, string extablesfieldsfilter, string extablesrelationsfilter, string extablessort, string extablesfieldssort, string extablesrelationssort, bool generateUndo=false)
		{
			return GetFilter(0,0, filter, sort, extablesfilter, extablesfieldsfilter, extablesrelationsfilter, extablessort, extablesfieldssort, extablesrelationssort,generateUndo);
		}


		/// <summary>
		/// Returns the type for one property
		/// </summary>
		/// <param name="propertyname">Property's name for return its value</param>
		/// <returns>A value for the <paramref name="propertyname"/></returns>
		public Type GetMethodType( string propertyname,Tempo_tblLiquidacionRutas tempo_tblliquidacionrutas)
		{
			// Perform the search for the property's value
			switch (propertyname)
			{
				case "lngIdRegistrRutaItemId":
					return tempo_tblliquidacionrutas.lngIdRegistrRutaItemId.GetType();

				case "lngIdRegistrRuta":
					return tempo_tblliquidacionrutas.lngIdRegistrRuta.GetType();

				case "lngIdRegistro":
					return tempo_tblliquidacionrutas.lngIdRegistro.GetType();

				case "strRutaAnticipoGrupoOrigen":
					return tempo_tblliquidacionrutas.strRutaAnticipoGrupoOrigen.GetType();

				case "strRutaAnticipoGrupoDestino":
					return tempo_tblliquidacionrutas.strRutaAnticipoGrupoDestino.GetType();

				case "strRutaAnticipoGrupo":
					return tempo_tblliquidacionrutas.strRutaAnticipoGrupo.GetType();

				case "strRutaAnticipo":
					return tempo_tblliquidacionrutas.strRutaAnticipo.GetType();

				case "floGalones":
					return tempo_tblliquidacionrutas.floGalones.GetType();

				case "curValorGalon":
					return tempo_tblliquidacionrutas.curValorGalon.GetType();

				case "cutCombustible":
					return tempo_tblliquidacionrutas.cutCombustible.GetType();

				case "lngIdNroPeajes":
					return tempo_tblliquidacionrutas.lngIdNroPeajes.GetType();

				case "cutPeaje":
					return tempo_tblliquidacionrutas.cutPeaje.GetType();

				case "strNombrePeajes":
					return tempo_tblliquidacionrutas.strNombrePeajes.GetType();

				case "cutVariosLlantas":
					return tempo_tblliquidacionrutas.cutVariosLlantas.GetType();

				case "cutVariosCelada":
					return tempo_tblliquidacionrutas.cutVariosCelada.GetType();

				case "cutVariosPropina":
					return tempo_tblliquidacionrutas.cutVariosPropina.GetType();

				case "cutVarios":
					return tempo_tblliquidacionrutas.cutVarios.GetType();

				case "cutVariosLlantasVacio":
					return tempo_tblliquidacionrutas.cutVariosLlantasVacio.GetType();

				case "cutVariosCeladaVacio":
					return tempo_tblliquidacionrutas.cutVariosCeladaVacio.GetType();

				case "cutVariosPropinaVacio":
					return tempo_tblliquidacionrutas.cutVariosPropinaVacio.GetType();

				case "cutVariosVacio":
					return tempo_tblliquidacionrutas.cutVariosVacio.GetType();

				case "cutParticipacion":
					return tempo_tblliquidacionrutas.cutParticipacion.GetType();

				case "cutParticipacionVacio":
					return tempo_tblliquidacionrutas.cutParticipacionVacio.GetType();

				case "curHotelCarretera":
					return tempo_tblliquidacionrutas.curHotelCarretera.GetType();

				case "curHotelCiudad":
					return tempo_tblliquidacionrutas.curHotelCiudad.GetType();

				case "curHotel":
					return tempo_tblliquidacionrutas.curHotel.GetType();

				case "curHotelCarreteraVacio":
					return tempo_tblliquidacionrutas.curHotelCarreteraVacio.GetType();

				case "curHotelCiudadVacio":
					return tempo_tblliquidacionrutas.curHotelCiudadVacio.GetType();

				case "curHotelVacio":
					return tempo_tblliquidacionrutas.curHotelVacio.GetType();

				case "intTiempoCargue":
					return tempo_tblliquidacionrutas.intTiempoCargue.GetType();

				case "intTiempoDescargue":
					return tempo_tblliquidacionrutas.intTiempoDescargue.GetType();

				case "intTiempoAduana":
					return tempo_tblliquidacionrutas.intTiempoAduana.GetType();

				case "intTotalTrayecto":
					return tempo_tblliquidacionrutas.intTotalTrayecto.GetType();

				case "intTotalTiempo":
					return tempo_tblliquidacionrutas.intTotalTiempo.GetType();

				case "curComida":
					return tempo_tblliquidacionrutas.curComida.GetType();

				case "intTiempoCargueVacio":
					return tempo_tblliquidacionrutas.intTiempoCargueVacio.GetType();

				case "intTiempoDescargueVacio":
					return tempo_tblliquidacionrutas.intTiempoDescargueVacio.GetType();

				case "intTiempoAduanaVacio":
					return tempo_tblliquidacionrutas.intTiempoAduanaVacio.GetType();

				case "intTotalTrayectoVacio":
					return tempo_tblliquidacionrutas.intTotalTrayectoVacio.GetType();

				case "intTotalTiempoVacio":
					return tempo_tblliquidacionrutas.intTotalTiempoVacio.GetType();

				case "curComidaVacio":
					return tempo_tblliquidacionrutas.curComidaVacio.GetType();

				case "curDesvareManoRepuestos":
					return tempo_tblliquidacionrutas.curDesvareManoRepuestos.GetType();

				case "curDesvareManoObra":
					return tempo_tblliquidacionrutas.curDesvareManoObra.GetType();

				case "cutSaldo":
					return tempo_tblliquidacionrutas.cutSaldo.GetType();

				case "cutKmts":
					return tempo_tblliquidacionrutas.cutKmts.GetType();

				case "logAjuste":
					return tempo_tblliquidacionrutas.logAjuste.GetType();

				case "lngIdRegistrRutaItemIdAjc":
					return tempo_tblliquidacionrutas.lngIdRegistrRutaItemIdAjc.GetType();

				case "lngIdUsuario":
					return tempo_tblliquidacionrutas.lngIdUsuario.GetType();

			}

			return null;
		}
		/// <summary>
		/// update the changes in Tempo_tblLiquidacionRutas object by passing the object
		/// </summary>
		public bool UpdateChanges(Tempo_tblLiquidacionRutas tempo_tblliquidacionrutas, out string error,Sinapsys.Datos.SQL datosTransaccion=null)
		{
			if (tempo_tblliquidacionrutas.OldTempo_tblLiquidacionRutas == null)
			{
				    error = "No tiene objeto con el cual comparar";
				    return false;
			}
			string[] Fields = tempo_tblliquidacionrutas.FieldChanged();
			error = "";
			return LiqViajes_Bll_Data.DataProvider.UpdateFieldsbyObject(Fields, tempo_tblliquidacionrutas, out error,datosTransaccion);
		}
	}

	#endregion

}
