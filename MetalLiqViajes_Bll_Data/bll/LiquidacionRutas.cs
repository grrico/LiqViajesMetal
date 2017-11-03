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
	#region LiquidacionRutasController

	/// <summary>
	/// Class for convert data from database into object's data and vice versa
	/// </summary>
	public partial class LiquidacionRutasController//: ILatinodeController
	{
		/// <summary>
		/// Generic Constructor
		/// </summary>
		public LiquidacionRutasController()
		{
		}

		/// <summary>
		/// Instance accessor for this singleton
		/// </summary>
		private static LiquidacionRutasController MySingleObj;
		public static LiquidacionRutasController Instance
		{
			get
			{
				if (MySingleObj == null)
				{
					MySingleObj = new LiquidacionRutasController();
				}
				return MySingleObj;
			}
		}

		// Reads object's data from a DataRow
		private void ReadData(LiquidacionRutas liquidacionrutas, DataRow dr,bool generateUndo=false)
		{
			try 
			{
				liquidacionrutas.lngIdRegistrRuta = dr.IsNull("lngIdRegistrRuta") ? null :(int?) dr["lngIdRegistrRuta"];
				liquidacionrutas.lngIdRegistro = dr.IsNull("lngIdRegistro") ? null :(int?) dr["lngIdRegistro"];
				liquidacionrutas.lngIdRegistrRutaItemIdAjc = dr.IsNull("lngIdRegistrRutaItemIdAjc") ? null :(int?) dr["lngIdRegistrRutaItemIdAjc"];
				liquidacionrutas.strRutaAnticipoGrupoOrigen = dr.IsNull("strRutaAnticipoGrupoOrigen") ? null :(string) dr["strRutaAnticipoGrupoOrigen"];
				liquidacionrutas.strRutaAnticipoGrupoDestino = dr.IsNull("strRutaAnticipoGrupoDestino") ? null :(string) dr["strRutaAnticipoGrupoDestino"];
				liquidacionrutas.strRutaAnticipoGrupo = dr.IsNull("strRutaAnticipoGrupo") ? null :(string) dr["strRutaAnticipoGrupo"];
				liquidacionrutas.strRutaAnticipo = dr.IsNull("strRutaAnticipo") ? null :(string) dr["strRutaAnticipo"];
				liquidacionrutas.logLiquidado = dr.IsNull("logLiquidado") ? null :(bool?) dr["logLiquidado"];
				liquidacionrutas.PlacaTrayler = dr.IsNull("PlacaTrayler") ? null :(string) dr["PlacaTrayler"];
				liquidacionrutas.Trailer = dr.IsNull("Trailer") ? null :(string) dr["Trailer"];
				liquidacionrutas.floGalones = dr.IsNull("floGalones") ? null :(decimal?) dr["floGalones"];
				liquidacionrutas.floGalonesReales = dr.IsNull("floGalonesReales") ? null :(decimal?) dr["floGalonesReales"];
				liquidacionrutas.floGalonesReserva = dr.IsNull("floGalonesReserva") ? null :(decimal?) dr["floGalonesReserva"];
				liquidacionrutas.curValorGalon = dr.IsNull("curValorGalon") ? null :(decimal?) dr["curValorGalon"];
				liquidacionrutas.CombustibleCarretera = dr.IsNull("CombustibleCarretera") ? null :(decimal?) dr["CombustibleCarretera"];
				liquidacionrutas.cutCombustible = dr.IsNull("cutCombustible") ? null :(decimal?) dr["cutCombustible"];
				liquidacionrutas.LogAnticipoACPM = dr.IsNull("LogAnticipoACPM") ? null :(bool?) dr["LogAnticipoACPM"];
				liquidacionrutas.cutValorAnticipo = dr.IsNull("cutValorAnticipo") ? null :(decimal?) dr["cutValorAnticipo"];
				liquidacionrutas.lngIdNroPeajes = dr.IsNull("lngIdNroPeajes") ? null :(int?) dr["lngIdNroPeajes"];
				liquidacionrutas.cutPeaje = dr.IsNull("cutPeaje") ? null :(decimal?) dr["cutPeaje"];
				liquidacionrutas.strNombrePeajes = dr.IsNull("strNombrePeajes") ? null :(string) dr["strNombrePeajes"];
				liquidacionrutas.cutVariosLlantas = dr.IsNull("cutVariosLlantas") ? null :(decimal?) dr["cutVariosLlantas"];
				liquidacionrutas.cutVariosCelada = dr.IsNull("cutVariosCelada") ? null :(decimal?) dr["cutVariosCelada"];
				liquidacionrutas.cutVariosPropina = dr.IsNull("cutVariosPropina") ? null :(decimal?) dr["cutVariosPropina"];
				liquidacionrutas.cutVarios = dr.IsNull("cutVarios") ? null :(decimal?) dr["cutVarios"];
				liquidacionrutas.cutVariosLlantasVacio = dr.IsNull("cutVariosLlantasVacio") ? null :(decimal?) dr["cutVariosLlantasVacio"];
				liquidacionrutas.cutVariosCeladaVacio = dr.IsNull("cutVariosCeladaVacio") ? null :(decimal?) dr["cutVariosCeladaVacio"];
				liquidacionrutas.cutVariosPropinaVacio = dr.IsNull("cutVariosPropinaVacio") ? null :(decimal?) dr["cutVariosPropinaVacio"];
				liquidacionrutas.cutVariosVacio = dr.IsNull("cutVariosVacio") ? null :(decimal?) dr["cutVariosVacio"];
				liquidacionrutas.cutParticipacion = dr.IsNull("cutParticipacion") ? null :(decimal?) dr["cutParticipacion"];
				liquidacionrutas.cutParticipacionVacio = dr.IsNull("cutParticipacionVacio") ? null :(decimal?) dr["cutParticipacionVacio"];
				liquidacionrutas.curHotelCarretera = dr.IsNull("curHotelCarretera") ? null :(int?) dr["curHotelCarretera"];
				liquidacionrutas.curHotelCiudad = dr.IsNull("curHotelCiudad") ? null :(int?) dr["curHotelCiudad"];
				liquidacionrutas.curHotel = dr.IsNull("curHotel") ? null :(decimal?) dr["curHotel"];
				liquidacionrutas.curHotelCarreteraVacio = dr.IsNull("curHotelCarreteraVacio") ? null :(int?) dr["curHotelCarreteraVacio"];
				liquidacionrutas.curHotelCiudadVacio = dr.IsNull("curHotelCiudadVacio") ? null :(int?) dr["curHotelCiudadVacio"];
				liquidacionrutas.curHotelVacio = dr.IsNull("curHotelVacio") ? null :(decimal?) dr["curHotelVacio"];
				liquidacionrutas.intTiempoCargue = dr.IsNull("intTiempoCargue") ? null :(decimal?) dr["intTiempoCargue"];
				liquidacionrutas.intTiempoDescargue = dr.IsNull("intTiempoDescargue") ? null :(decimal?) dr["intTiempoDescargue"];
				liquidacionrutas.intTiempoAduana = dr.IsNull("intTiempoAduana") ? null :(decimal?) dr["intTiempoAduana"];
				liquidacionrutas.intTotalTrayecto = dr.IsNull("intTotalTrayecto") ? null :(decimal?) dr["intTotalTrayecto"];
				liquidacionrutas.intTotalTiempo = dr.IsNull("intTotalTiempo") ? null :(decimal?) dr["intTotalTiempo"];
				liquidacionrutas.curComida = dr.IsNull("curComida") ? null :(decimal?) dr["curComida"];
				liquidacionrutas.intTiempoCargueVacio = dr.IsNull("intTiempoCargueVacio") ? null :(decimal?) dr["intTiempoCargueVacio"];
				liquidacionrutas.intTiempoDescargueVacio = dr.IsNull("intTiempoDescargueVacio") ? null :(decimal?) dr["intTiempoDescargueVacio"];
				liquidacionrutas.intTiempoAduanaVacio = dr.IsNull("intTiempoAduanaVacio") ? null :(decimal?) dr["intTiempoAduanaVacio"];
				liquidacionrutas.intTotalTrayectoVacio = dr.IsNull("intTotalTrayectoVacio") ? null :(decimal?) dr["intTotalTrayectoVacio"];
				liquidacionrutas.intTotalTiempoVacio = dr.IsNull("intTotalTiempoVacio") ? null :(decimal?) dr["intTotalTiempoVacio"];
				liquidacionrutas.curComidaVacio = dr.IsNull("curComidaVacio") ? null :(decimal?) dr["curComidaVacio"];
				liquidacionrutas.curDesvareManoRepuestos = dr.IsNull("curDesvareManoRepuestos") ? null :(decimal?) dr["curDesvareManoRepuestos"];
				liquidacionrutas.curDesvareManoObra = dr.IsNull("curDesvareManoObra") ? null :(decimal?) dr["curDesvareManoObra"];
				liquidacionrutas.cutSaldo = dr.IsNull("cutSaldo") ? null :(decimal?) dr["cutSaldo"];
				liquidacionrutas.cutKmts = dr.IsNull("cutKmts") ? null :(decimal?) dr["cutKmts"];
				liquidacionrutas.logAjuste = dr.IsNull("logAjuste") ? null :(bool?) dr["logAjuste"];
				liquidacionrutas.dtmFechaModif = dr.IsNull("dtmFechaModif") ? null :(DateTime?) dr["dtmFechaModif"];
				liquidacionrutas.logVacio = dr.IsNull("logVacio") ? null :(bool?) dr["logVacio"];
				liquidacionrutas.TipoVehiculoCodigo = dr.IsNull("TipoVehiculoCodigo") ? null :(int?) dr["TipoVehiculoCodigo"];
				liquidacionrutas.TipoVehiculo = dr.IsNull("TipoVehiculo") ? null :(string) dr["TipoVehiculo"];
				liquidacionrutas.TipoTrailerCodigo = dr.IsNull("TipoTrailerCodigo") ? null :(int?) dr["TipoTrailerCodigo"];
				liquidacionrutas.Peso = dr.IsNull("Peso") ? null :(int?) dr["Peso"];
				liquidacionrutas.Contenedor1 = dr.IsNull("Contenedor1") ? null :(string) dr["Contenedor1"];
				liquidacionrutas.Contenedor2 = dr.IsNull("Contenedor2") ? null :(string) dr["Contenedor2"];
				liquidacionrutas.FactorCalculoDia = dr.IsNull("FactorCalculoDia") ? null :(int?) dr["FactorCalculoDia"];
				liquidacionrutas.ValorCalculoFactor = dr.IsNull("ValorCalculoFactor") ? null :(decimal?) dr["ValorCalculoFactor"];
				liquidacionrutas.ParqueaderoCarretera = dr.IsNull("ParqueaderoCarretera") ? null :(decimal?) dr["ParqueaderoCarretera"];
				liquidacionrutas.ParqueaderoCiudad = dr.IsNull("ParqueaderoCiudad") ? null :(decimal?) dr["ParqueaderoCiudad"];
				liquidacionrutas.MontadaLLantaCarretera = dr.IsNull("MontadaLLantaCarretera") ? null :(decimal?) dr["MontadaLLantaCarretera"];
				liquidacionrutas.MontadaLLantaCiudad = dr.IsNull("MontadaLLantaCiudad") ? null :(decimal?) dr["MontadaLLantaCiudad"];
				liquidacionrutas.AjusteCarretera = dr.IsNull("AjusteCarretera") ? null :(decimal?) dr["AjusteCarretera"];
				liquidacionrutas.Taxi = dr.IsNull("Taxi") ? null :(decimal?) dr["Taxi"];
				liquidacionrutas.Aseo = dr.IsNull("Aseo") ? null :(decimal?) dr["Aseo"];
				liquidacionrutas.Amarres = dr.IsNull("Amarres") ? null :(decimal?) dr["Amarres"];
				liquidacionrutas.Engradasa = dr.IsNull("Engradasa") ? null :(decimal?) dr["Engradasa"];
				liquidacionrutas.Calibrada = dr.IsNull("Calibrada") ? null :(decimal?) dr["Calibrada"];
				liquidacionrutas.Liquidado = dr.IsNull("Liquidado") ? null :(bool?) dr["Liquidado"];
				liquidacionrutas.Lavada = dr.IsNull("Lavada") ? null :(decimal?) dr["Lavada"];
				liquidacionrutas.logEstadoRuta = dr.IsNull("logEstadoRuta") ? null :(bool?) dr["logEstadoRuta"];
				liquidacionrutas.Papeleria = dr.IsNull("Papeleria") ? null :(decimal?) dr["Papeleria"];
				liquidacionrutas.logFavorito = dr.IsNull("logFavorito") ? null :(bool?) dr["logFavorito"];
				liquidacionrutas.CurCargue = dr.IsNull("CurCargue") ? null :(decimal?) dr["CurCargue"];
				liquidacionrutas.CurDescargue = dr.IsNull("CurDescargue") ? null :(decimal?) dr["CurDescargue"];
				liquidacionrutas.logLiquParticipacion = dr.IsNull("logLiquParticipacion") ? null :(bool?) dr["logLiquParticipacion"];
				liquidacionrutas.lngIdRegistrRutaItemId = (int) dr["lngIdRegistrRutaItemId"];
			}
			catch (Exception ex)
			{
				Utilidades.LogErrores(ex.Message + (ex.InnerException != null ? ex.InnerException.Message : ""), DataProvider.AplicacionNombre);
				throw ex;
			}
			if (generateUndo) liquidacionrutas.GenerateUndo();
		}

		/// <summary>
		/// Create a new LiquidacionRutas object by passing a object
		/// </summary>
		public LiquidacionRutas Create(LiquidacionRutas liquidacionrutas, Sinapsys.Datos.SQL datosTransaccion=null)
		{
			return Create(liquidacionrutas.lngIdRegistrRutaItemId,liquidacionrutas.lngIdRegistrRuta,liquidacionrutas.lngIdRegistro,liquidacionrutas.lngIdRegistrRutaItemIdAjc,liquidacionrutas.strRutaAnticipoGrupoOrigen,liquidacionrutas.strRutaAnticipoGrupoDestino,liquidacionrutas.strRutaAnticipoGrupo,liquidacionrutas.strRutaAnticipo,liquidacionrutas.logLiquidado,liquidacionrutas.PlacaTrayler,liquidacionrutas.Trailer,liquidacionrutas.floGalones,liquidacionrutas.floGalonesReales,liquidacionrutas.floGalonesReserva,liquidacionrutas.curValorGalon,liquidacionrutas.CombustibleCarretera,liquidacionrutas.cutCombustible,liquidacionrutas.LogAnticipoACPM,liquidacionrutas.cutValorAnticipo,liquidacionrutas.lngIdNroPeajes,liquidacionrutas.cutPeaje,liquidacionrutas.strNombrePeajes,liquidacionrutas.cutVariosLlantas,liquidacionrutas.cutVariosCelada,liquidacionrutas.cutVariosPropina,liquidacionrutas.cutVarios,liquidacionrutas.cutVariosLlantasVacio,liquidacionrutas.cutVariosCeladaVacio,liquidacionrutas.cutVariosPropinaVacio,liquidacionrutas.cutVariosVacio,liquidacionrutas.cutParticipacion,liquidacionrutas.cutParticipacionVacio,liquidacionrutas.curHotelCarretera,liquidacionrutas.curHotelCiudad,liquidacionrutas.curHotel,liquidacionrutas.curHotelCarreteraVacio,liquidacionrutas.curHotelCiudadVacio,liquidacionrutas.curHotelVacio,liquidacionrutas.intTiempoCargue,liquidacionrutas.intTiempoDescargue,liquidacionrutas.intTiempoAduana,liquidacionrutas.intTotalTrayecto,liquidacionrutas.intTotalTiempo,liquidacionrutas.curComida,liquidacionrutas.intTiempoCargueVacio,liquidacionrutas.intTiempoDescargueVacio,liquidacionrutas.intTiempoAduanaVacio,liquidacionrutas.intTotalTrayectoVacio,liquidacionrutas.intTotalTiempoVacio,liquidacionrutas.curComidaVacio,liquidacionrutas.curDesvareManoRepuestos,liquidacionrutas.curDesvareManoObra,liquidacionrutas.cutSaldo,liquidacionrutas.cutKmts,liquidacionrutas.logAjuste,liquidacionrutas.dtmFechaModif,liquidacionrutas.logVacio,liquidacionrutas.TipoVehiculoCodigo,liquidacionrutas.TipoVehiculo,liquidacionrutas.TipoTrailerCodigo,liquidacionrutas.Peso,liquidacionrutas.Contenedor1,liquidacionrutas.Contenedor2,liquidacionrutas.FactorCalculoDia,liquidacionrutas.ValorCalculoFactor,liquidacionrutas.ParqueaderoCarretera,liquidacionrutas.ParqueaderoCiudad,liquidacionrutas.MontadaLLantaCarretera,liquidacionrutas.MontadaLLantaCiudad,liquidacionrutas.AjusteCarretera,liquidacionrutas.Taxi,liquidacionrutas.Aseo,liquidacionrutas.Amarres,liquidacionrutas.Engradasa,liquidacionrutas.Calibrada,liquidacionrutas.Liquidado,liquidacionrutas.Lavada,liquidacionrutas.logEstadoRuta,liquidacionrutas.Papeleria,liquidacionrutas.logFavorito,liquidacionrutas.CurCargue,liquidacionrutas.CurDescargue,liquidacionrutas.logLiquParticipacion,datosTransaccion);
		}

		/// <summary>
		/// Creates a new LiquidacionRutas object by passing all object's fields
		/// </summary>
		/// <param name="lngIdRegistrRuta">int that contents the lngIdRegistrRuta value for the LiquidacionRutas object</param>
		/// <param name="lngIdRegistro">int that contents the lngIdRegistro value for the LiquidacionRutas object</param>
		/// <param name="lngIdRegistrRutaItemIdAjc">int that contents the lngIdRegistrRutaItemIdAjc value for the LiquidacionRutas object</param>
		/// <param name="strRutaAnticipoGrupoOrigen">string that contents the strRutaAnticipoGrupoOrigen value for the LiquidacionRutas object</param>
		/// <param name="strRutaAnticipoGrupoDestino">string that contents the strRutaAnticipoGrupoDestino value for the LiquidacionRutas object</param>
		/// <param name="strRutaAnticipoGrupo">string that contents the strRutaAnticipoGrupo value for the LiquidacionRutas object</param>
		/// <param name="strRutaAnticipo">string that contents the strRutaAnticipo value for the LiquidacionRutas object</param>
		/// <param name="logLiquidado">bool that contents the logLiquidado value for the LiquidacionRutas object</param>
		/// <param name="PlacaTrayler">string that contents the PlacaTrayler value for the LiquidacionRutas object</param>
		/// <param name="Trailer">string that contents the Trailer value for the LiquidacionRutas object</param>
		/// <param name="floGalones">decimal that contents the floGalones value for the LiquidacionRutas object</param>
		/// <param name="floGalonesReales">decimal that contents the floGalonesReales value for the LiquidacionRutas object</param>
		/// <param name="floGalonesReserva">decimal that contents the floGalonesReserva value for the LiquidacionRutas object</param>
		/// <param name="curValorGalon">decimal that contents the curValorGalon value for the LiquidacionRutas object</param>
		/// <param name="CombustibleCarretera">decimal that contents the CombustibleCarretera value for the LiquidacionRutas object</param>
		/// <param name="cutCombustible">decimal that contents the cutCombustible value for the LiquidacionRutas object</param>
		/// <param name="LogAnticipoACPM">bool that contents the LogAnticipoACPM value for the LiquidacionRutas object</param>
		/// <param name="cutValorAnticipo">decimal that contents the cutValorAnticipo value for the LiquidacionRutas object</param>
		/// <param name="lngIdNroPeajes">int that contents the lngIdNroPeajes value for the LiquidacionRutas object</param>
		/// <param name="cutPeaje">decimal that contents the cutPeaje value for the LiquidacionRutas object</param>
		/// <param name="strNombrePeajes">string that contents the strNombrePeajes value for the LiquidacionRutas object</param>
		/// <param name="cutVariosLlantas">decimal that contents the cutVariosLlantas value for the LiquidacionRutas object</param>
		/// <param name="cutVariosCelada">decimal that contents the cutVariosCelada value for the LiquidacionRutas object</param>
		/// <param name="cutVariosPropina">decimal that contents the cutVariosPropina value for the LiquidacionRutas object</param>
		/// <param name="cutVarios">decimal that contents the cutVarios value for the LiquidacionRutas object</param>
		/// <param name="cutVariosLlantasVacio">decimal that contents the cutVariosLlantasVacio value for the LiquidacionRutas object</param>
		/// <param name="cutVariosCeladaVacio">decimal that contents the cutVariosCeladaVacio value for the LiquidacionRutas object</param>
		/// <param name="cutVariosPropinaVacio">decimal that contents the cutVariosPropinaVacio value for the LiquidacionRutas object</param>
		/// <param name="cutVariosVacio">decimal that contents the cutVariosVacio value for the LiquidacionRutas object</param>
		/// <param name="cutParticipacion">decimal that contents the cutParticipacion value for the LiquidacionRutas object</param>
		/// <param name="cutParticipacionVacio">decimal that contents the cutParticipacionVacio value for the LiquidacionRutas object</param>
		/// <param name="curHotelCarretera">int that contents the curHotelCarretera value for the LiquidacionRutas object</param>
		/// <param name="curHotelCiudad">int that contents the curHotelCiudad value for the LiquidacionRutas object</param>
		/// <param name="curHotel">decimal that contents the curHotel value for the LiquidacionRutas object</param>
		/// <param name="curHotelCarreteraVacio">int that contents the curHotelCarreteraVacio value for the LiquidacionRutas object</param>
		/// <param name="curHotelCiudadVacio">int that contents the curHotelCiudadVacio value for the LiquidacionRutas object</param>
		/// <param name="curHotelVacio">decimal that contents the curHotelVacio value for the LiquidacionRutas object</param>
		/// <param name="intTiempoCargue">decimal that contents the intTiempoCargue value for the LiquidacionRutas object</param>
		/// <param name="intTiempoDescargue">decimal that contents the intTiempoDescargue value for the LiquidacionRutas object</param>
		/// <param name="intTiempoAduana">decimal that contents the intTiempoAduana value for the LiquidacionRutas object</param>
		/// <param name="intTotalTrayecto">decimal that contents the intTotalTrayecto value for the LiquidacionRutas object</param>
		/// <param name="intTotalTiempo">decimal that contents the intTotalTiempo value for the LiquidacionRutas object</param>
		/// <param name="curComida">decimal that contents the curComida value for the LiquidacionRutas object</param>
		/// <param name="intTiempoCargueVacio">decimal that contents the intTiempoCargueVacio value for the LiquidacionRutas object</param>
		/// <param name="intTiempoDescargueVacio">decimal that contents the intTiempoDescargueVacio value for the LiquidacionRutas object</param>
		/// <param name="intTiempoAduanaVacio">decimal that contents the intTiempoAduanaVacio value for the LiquidacionRutas object</param>
		/// <param name="intTotalTrayectoVacio">decimal that contents the intTotalTrayectoVacio value for the LiquidacionRutas object</param>
		/// <param name="intTotalTiempoVacio">decimal that contents the intTotalTiempoVacio value for the LiquidacionRutas object</param>
		/// <param name="curComidaVacio">decimal that contents the curComidaVacio value for the LiquidacionRutas object</param>
		/// <param name="curDesvareManoRepuestos">decimal that contents the curDesvareManoRepuestos value for the LiquidacionRutas object</param>
		/// <param name="curDesvareManoObra">decimal that contents the curDesvareManoObra value for the LiquidacionRutas object</param>
		/// <param name="cutSaldo">decimal that contents the cutSaldo value for the LiquidacionRutas object</param>
		/// <param name="cutKmts">decimal that contents the cutKmts value for the LiquidacionRutas object</param>
		/// <param name="logAjuste">bool that contents the logAjuste value for the LiquidacionRutas object</param>
		/// <param name="dtmFechaModif">DateTime that contents the dtmFechaModif value for the LiquidacionRutas object</param>
		/// <param name="logVacio">bool that contents the logVacio value for the LiquidacionRutas object</param>
		/// <param name="TipoVehiculoCodigo">int that contents the TipoVehiculoCodigo value for the LiquidacionRutas object</param>
		/// <param name="TipoVehiculo">string that contents the TipoVehiculo value for the LiquidacionRutas object</param>
		/// <param name="TipoTrailerCodigo">int that contents the TipoTrailerCodigo value for the LiquidacionRutas object</param>
		/// <param name="Peso">int that contents the Peso value for the LiquidacionRutas object</param>
		/// <param name="Contenedor1">string that contents the Contenedor1 value for the LiquidacionRutas object</param>
		/// <param name="Contenedor2">string that contents the Contenedor2 value for the LiquidacionRutas object</param>
		/// <param name="FactorCalculoDia">int that contents the FactorCalculoDia value for the LiquidacionRutas object</param>
		/// <param name="ValorCalculoFactor">decimal that contents the ValorCalculoFactor value for the LiquidacionRutas object</param>
		/// <param name="ParqueaderoCarretera">decimal that contents the ParqueaderoCarretera value for the LiquidacionRutas object</param>
		/// <param name="ParqueaderoCiudad">decimal that contents the ParqueaderoCiudad value for the LiquidacionRutas object</param>
		/// <param name="MontadaLLantaCarretera">decimal that contents the MontadaLLantaCarretera value for the LiquidacionRutas object</param>
		/// <param name="MontadaLLantaCiudad">decimal that contents the MontadaLLantaCiudad value for the LiquidacionRutas object</param>
		/// <param name="AjusteCarretera">decimal that contents the AjusteCarretera value for the LiquidacionRutas object</param>
		/// <param name="Taxi">decimal that contents the Taxi value for the LiquidacionRutas object</param>
		/// <param name="Aseo">decimal that contents the Aseo value for the LiquidacionRutas object</param>
		/// <param name="Amarres">decimal that contents the Amarres value for the LiquidacionRutas object</param>
		/// <param name="Engradasa">decimal that contents the Engradasa value for the LiquidacionRutas object</param>
		/// <param name="Calibrada">decimal that contents the Calibrada value for the LiquidacionRutas object</param>
		/// <param name="Liquidado">bool that contents the Liquidado value for the LiquidacionRutas object</param>
		/// <param name="Lavada">decimal that contents the Lavada value for the LiquidacionRutas object</param>
		/// <param name="logEstadoRuta">bool that contents the logEstadoRuta value for the LiquidacionRutas object</param>
		/// <param name="Papeleria">decimal that contents the Papeleria value for the LiquidacionRutas object</param>
		/// <param name="logFavorito">bool that contents the logFavorito value for the LiquidacionRutas object</param>
		/// <param name="CurCargue">decimal that contents the CurCargue value for the LiquidacionRutas object</param>
		/// <param name="CurDescargue">decimal that contents the CurDescargue value for the LiquidacionRutas object</param>
		/// <param name="logLiquParticipacion">bool that contents the logLiquParticipacion value for the LiquidacionRutas object</param>
		/// <returns>One LiquidacionRutas object</returns>
		public LiquidacionRutas Create(int lngIdRegistrRutaItemId, int? lngIdRegistrRuta, int? lngIdRegistro, int? lngIdRegistrRutaItemIdAjc, string strRutaAnticipoGrupoOrigen, string strRutaAnticipoGrupoDestino, string strRutaAnticipoGrupo, string strRutaAnticipo, bool? logLiquidado, string PlacaTrayler, string Trailer, decimal? floGalones, decimal? floGalonesReales, decimal? floGalonesReserva, decimal? curValorGalon, decimal? CombustibleCarretera, decimal? cutCombustible, bool? LogAnticipoACPM, decimal? cutValorAnticipo, int? lngIdNroPeajes, decimal? cutPeaje, string strNombrePeajes, decimal? cutVariosLlantas, decimal? cutVariosCelada, decimal? cutVariosPropina, decimal? cutVarios, decimal? cutVariosLlantasVacio, decimal? cutVariosCeladaVacio, decimal? cutVariosPropinaVacio, decimal? cutVariosVacio, decimal? cutParticipacion, decimal? cutParticipacionVacio, int? curHotelCarretera, int? curHotelCiudad, decimal? curHotel, int? curHotelCarreteraVacio, int? curHotelCiudadVacio, decimal? curHotelVacio, decimal? intTiempoCargue, decimal? intTiempoDescargue, decimal? intTiempoAduana, decimal? intTotalTrayecto, decimal? intTotalTiempo, decimal? curComida, decimal? intTiempoCargueVacio, decimal? intTiempoDescargueVacio, decimal? intTiempoAduanaVacio, decimal? intTotalTrayectoVacio, decimal? intTotalTiempoVacio, decimal? curComidaVacio, decimal? curDesvareManoRepuestos, decimal? curDesvareManoObra, decimal? cutSaldo, decimal? cutKmts, bool? logAjuste, DateTime? dtmFechaModif, bool? logVacio, int? TipoVehiculoCodigo, string TipoVehiculo, int? TipoTrailerCodigo, int? Peso, string Contenedor1, string Contenedor2, int? FactorCalculoDia, decimal? ValorCalculoFactor, decimal? ParqueaderoCarretera, decimal? ParqueaderoCiudad, decimal? MontadaLLantaCarretera, decimal? MontadaLLantaCiudad, decimal? AjusteCarretera, decimal? Taxi, decimal? Aseo, decimal? Amarres, decimal? Engradasa, decimal? Calibrada, bool? Liquidado, decimal? Lavada, bool? logEstadoRuta, decimal? Papeleria, bool? logFavorito, decimal? CurCargue, decimal? CurDescargue, bool? logLiquParticipacion, Sinapsys.Datos.SQL datosTransaccion=null)
		{
			try 
			{
				LiquidacionRutas liquidacionrutas = new LiquidacionRutas();

				liquidacionrutas.lngIdRegistrRutaItemId = lngIdRegistrRutaItemId;
				liquidacionrutas.lngIdRegistrRutaItemId = lngIdRegistrRutaItemId;
				liquidacionrutas.lngIdRegistrRuta = lngIdRegistrRuta;
				liquidacionrutas.lngIdRegistro = lngIdRegistro;
				liquidacionrutas.lngIdRegistrRutaItemIdAjc = lngIdRegistrRutaItemIdAjc;
				liquidacionrutas.strRutaAnticipoGrupoOrigen = strRutaAnticipoGrupoOrigen;
				liquidacionrutas.strRutaAnticipoGrupoDestino = strRutaAnticipoGrupoDestino;
				liquidacionrutas.strRutaAnticipoGrupo = strRutaAnticipoGrupo;
				liquidacionrutas.strRutaAnticipo = strRutaAnticipo;
				liquidacionrutas.logLiquidado = logLiquidado;
				liquidacionrutas.PlacaTrayler = PlacaTrayler;
				liquidacionrutas.Trailer = Trailer;
				liquidacionrutas.floGalones = floGalones;
				liquidacionrutas.floGalonesReales = floGalonesReales;
				liquidacionrutas.floGalonesReserva = floGalonesReserva;
				liquidacionrutas.curValorGalon = curValorGalon;
				liquidacionrutas.CombustibleCarretera = CombustibleCarretera;
				liquidacionrutas.cutCombustible = cutCombustible;
				liquidacionrutas.LogAnticipoACPM = LogAnticipoACPM;
				liquidacionrutas.cutValorAnticipo = cutValorAnticipo;
				liquidacionrutas.lngIdNroPeajes = lngIdNroPeajes;
				liquidacionrutas.cutPeaje = cutPeaje;
				liquidacionrutas.strNombrePeajes = strNombrePeajes;
				liquidacionrutas.cutVariosLlantas = cutVariosLlantas;
				liquidacionrutas.cutVariosCelada = cutVariosCelada;
				liquidacionrutas.cutVariosPropina = cutVariosPropina;
				liquidacionrutas.cutVarios = cutVarios;
				liquidacionrutas.cutVariosLlantasVacio = cutVariosLlantasVacio;
				liquidacionrutas.cutVariosCeladaVacio = cutVariosCeladaVacio;
				liquidacionrutas.cutVariosPropinaVacio = cutVariosPropinaVacio;
				liquidacionrutas.cutVariosVacio = cutVariosVacio;
				liquidacionrutas.cutParticipacion = cutParticipacion;
				liquidacionrutas.cutParticipacionVacio = cutParticipacionVacio;
				liquidacionrutas.curHotelCarretera = curHotelCarretera;
				liquidacionrutas.curHotelCiudad = curHotelCiudad;
				liquidacionrutas.curHotel = curHotel;
				liquidacionrutas.curHotelCarreteraVacio = curHotelCarreteraVacio;
				liquidacionrutas.curHotelCiudadVacio = curHotelCiudadVacio;
				liquidacionrutas.curHotelVacio = curHotelVacio;
				liquidacionrutas.intTiempoCargue = intTiempoCargue;
				liquidacionrutas.intTiempoDescargue = intTiempoDescargue;
				liquidacionrutas.intTiempoAduana = intTiempoAduana;
				liquidacionrutas.intTotalTrayecto = intTotalTrayecto;
				liquidacionrutas.intTotalTiempo = intTotalTiempo;
				liquidacionrutas.curComida = curComida;
				liquidacionrutas.intTiempoCargueVacio = intTiempoCargueVacio;
				liquidacionrutas.intTiempoDescargueVacio = intTiempoDescargueVacio;
				liquidacionrutas.intTiempoAduanaVacio = intTiempoAduanaVacio;
				liquidacionrutas.intTotalTrayectoVacio = intTotalTrayectoVacio;
				liquidacionrutas.intTotalTiempoVacio = intTotalTiempoVacio;
				liquidacionrutas.curComidaVacio = curComidaVacio;
				liquidacionrutas.curDesvareManoRepuestos = curDesvareManoRepuestos;
				liquidacionrutas.curDesvareManoObra = curDesvareManoObra;
				liquidacionrutas.cutSaldo = cutSaldo;
				liquidacionrutas.cutKmts = cutKmts;
				liquidacionrutas.logAjuste = logAjuste;
				liquidacionrutas.dtmFechaModif = dtmFechaModif;
				liquidacionrutas.logVacio = logVacio;
				liquidacionrutas.TipoVehiculoCodigo = TipoVehiculoCodigo;
				liquidacionrutas.TipoVehiculo = TipoVehiculo;
				liquidacionrutas.TipoTrailerCodigo = TipoTrailerCodigo;
				liquidacionrutas.Peso = Peso;
				liquidacionrutas.Contenedor1 = Contenedor1;
				liquidacionrutas.Contenedor2 = Contenedor2;
				liquidacionrutas.FactorCalculoDia = FactorCalculoDia;
				liquidacionrutas.ValorCalculoFactor = ValorCalculoFactor;
				liquidacionrutas.ParqueaderoCarretera = ParqueaderoCarretera;
				liquidacionrutas.ParqueaderoCiudad = ParqueaderoCiudad;
				liquidacionrutas.MontadaLLantaCarretera = MontadaLLantaCarretera;
				liquidacionrutas.MontadaLLantaCiudad = MontadaLLantaCiudad;
				liquidacionrutas.AjusteCarretera = AjusteCarretera;
				liquidacionrutas.Taxi = Taxi;
				liquidacionrutas.Aseo = Aseo;
				liquidacionrutas.Amarres = Amarres;
				liquidacionrutas.Engradasa = Engradasa;
				liquidacionrutas.Calibrada = Calibrada;
				liquidacionrutas.Liquidado = Liquidado;
				liquidacionrutas.Lavada = Lavada;
				liquidacionrutas.logEstadoRuta = logEstadoRuta;
				liquidacionrutas.Papeleria = Papeleria;
				liquidacionrutas.logFavorito = logFavorito;
				liquidacionrutas.CurCargue = CurCargue;
				liquidacionrutas.CurDescargue = CurDescargue;
				liquidacionrutas.logLiquParticipacion = logLiquParticipacion;
				lngIdRegistrRutaItemId = LiquidacionRutasDataProvider.Instance.Create(lngIdRegistrRutaItemId, lngIdRegistrRuta, lngIdRegistro, lngIdRegistrRutaItemIdAjc, strRutaAnticipoGrupoOrigen, strRutaAnticipoGrupoDestino, strRutaAnticipoGrupo, strRutaAnticipo, logLiquidado, PlacaTrayler, Trailer, floGalones, floGalonesReales, floGalonesReserva, curValorGalon, CombustibleCarretera, cutCombustible, LogAnticipoACPM, cutValorAnticipo, lngIdNroPeajes, cutPeaje, strNombrePeajes, cutVariosLlantas, cutVariosCelada, cutVariosPropina, cutVarios, cutVariosLlantasVacio, cutVariosCeladaVacio, cutVariosPropinaVacio, cutVariosVacio, cutParticipacion, cutParticipacionVacio, curHotelCarretera, curHotelCiudad, curHotel, curHotelCarreteraVacio, curHotelCiudadVacio, curHotelVacio, intTiempoCargue, intTiempoDescargue, intTiempoAduana, intTotalTrayecto, intTotalTiempo, curComida, intTiempoCargueVacio, intTiempoDescargueVacio, intTiempoAduanaVacio, intTotalTrayectoVacio, intTotalTiempoVacio, curComidaVacio, curDesvareManoRepuestos, curDesvareManoObra, cutSaldo, cutKmts, logAjuste, dtmFechaModif, logVacio, TipoVehiculoCodigo, TipoVehiculo, TipoTrailerCodigo, Peso, Contenedor1, Contenedor2, FactorCalculoDia, ValorCalculoFactor, ParqueaderoCarretera, ParqueaderoCiudad, MontadaLLantaCarretera, MontadaLLantaCiudad, AjusteCarretera, Taxi, Aseo, Amarres, Engradasa, Calibrada, Liquidado, Lavada, logEstadoRuta, Papeleria, logFavorito, CurCargue, CurDescargue, logLiquParticipacion,"LiquidacionRutas",datosTransaccion);
				if (lngIdRegistrRutaItemId == 0)
					return null;

				liquidacionrutas.lngIdRegistrRutaItemId = lngIdRegistrRutaItemId;

				return liquidacionrutas;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Updates an LiquidacionRutas object by passing all object's fields
		/// </summary>
		/// <param name="lngIdRegistrRuta">int that contents the lngIdRegistrRuta value for the LiquidacionRutas object</param>
		/// <param name="lngIdRegistro">int that contents the lngIdRegistro value for the LiquidacionRutas object</param>
		/// <param name="lngIdRegistrRutaItemIdAjc">int that contents the lngIdRegistrRutaItemIdAjc value for the LiquidacionRutas object</param>
		/// <param name="strRutaAnticipoGrupoOrigen">string that contents the strRutaAnticipoGrupoOrigen value for the LiquidacionRutas object</param>
		/// <param name="strRutaAnticipoGrupoDestino">string that contents the strRutaAnticipoGrupoDestino value for the LiquidacionRutas object</param>
		/// <param name="strRutaAnticipoGrupo">string that contents the strRutaAnticipoGrupo value for the LiquidacionRutas object</param>
		/// <param name="strRutaAnticipo">string that contents the strRutaAnticipo value for the LiquidacionRutas object</param>
		/// <param name="logLiquidado">bool that contents the logLiquidado value for the LiquidacionRutas object</param>
		/// <param name="PlacaTrayler">string that contents the PlacaTrayler value for the LiquidacionRutas object</param>
		/// <param name="Trailer">string that contents the Trailer value for the LiquidacionRutas object</param>
		/// <param name="floGalones">decimal that contents the floGalones value for the LiquidacionRutas object</param>
		/// <param name="floGalonesReales">decimal that contents the floGalonesReales value for the LiquidacionRutas object</param>
		/// <param name="floGalonesReserva">decimal that contents the floGalonesReserva value for the LiquidacionRutas object</param>
		/// <param name="curValorGalon">decimal that contents the curValorGalon value for the LiquidacionRutas object</param>
		/// <param name="CombustibleCarretera">decimal that contents the CombustibleCarretera value for the LiquidacionRutas object</param>
		/// <param name="cutCombustible">decimal that contents the cutCombustible value for the LiquidacionRutas object</param>
		/// <param name="LogAnticipoACPM">bool that contents the LogAnticipoACPM value for the LiquidacionRutas object</param>
		/// <param name="cutValorAnticipo">decimal that contents the cutValorAnticipo value for the LiquidacionRutas object</param>
		/// <param name="lngIdNroPeajes">int that contents the lngIdNroPeajes value for the LiquidacionRutas object</param>
		/// <param name="cutPeaje">decimal that contents the cutPeaje value for the LiquidacionRutas object</param>
		/// <param name="strNombrePeajes">string that contents the strNombrePeajes value for the LiquidacionRutas object</param>
		/// <param name="cutVariosLlantas">decimal that contents the cutVariosLlantas value for the LiquidacionRutas object</param>
		/// <param name="cutVariosCelada">decimal that contents the cutVariosCelada value for the LiquidacionRutas object</param>
		/// <param name="cutVariosPropina">decimal that contents the cutVariosPropina value for the LiquidacionRutas object</param>
		/// <param name="cutVarios">decimal that contents the cutVarios value for the LiquidacionRutas object</param>
		/// <param name="cutVariosLlantasVacio">decimal that contents the cutVariosLlantasVacio value for the LiquidacionRutas object</param>
		/// <param name="cutVariosCeladaVacio">decimal that contents the cutVariosCeladaVacio value for the LiquidacionRutas object</param>
		/// <param name="cutVariosPropinaVacio">decimal that contents the cutVariosPropinaVacio value for the LiquidacionRutas object</param>
		/// <param name="cutVariosVacio">decimal that contents the cutVariosVacio value for the LiquidacionRutas object</param>
		/// <param name="cutParticipacion">decimal that contents the cutParticipacion value for the LiquidacionRutas object</param>
		/// <param name="cutParticipacionVacio">decimal that contents the cutParticipacionVacio value for the LiquidacionRutas object</param>
		/// <param name="curHotelCarretera">int that contents the curHotelCarretera value for the LiquidacionRutas object</param>
		/// <param name="curHotelCiudad">int that contents the curHotelCiudad value for the LiquidacionRutas object</param>
		/// <param name="curHotel">decimal that contents the curHotel value for the LiquidacionRutas object</param>
		/// <param name="curHotelCarreteraVacio">int that contents the curHotelCarreteraVacio value for the LiquidacionRutas object</param>
		/// <param name="curHotelCiudadVacio">int that contents the curHotelCiudadVacio value for the LiquidacionRutas object</param>
		/// <param name="curHotelVacio">decimal that contents the curHotelVacio value for the LiquidacionRutas object</param>
		/// <param name="intTiempoCargue">decimal that contents the intTiempoCargue value for the LiquidacionRutas object</param>
		/// <param name="intTiempoDescargue">decimal that contents the intTiempoDescargue value for the LiquidacionRutas object</param>
		/// <param name="intTiempoAduana">decimal that contents the intTiempoAduana value for the LiquidacionRutas object</param>
		/// <param name="intTotalTrayecto">decimal that contents the intTotalTrayecto value for the LiquidacionRutas object</param>
		/// <param name="intTotalTiempo">decimal that contents the intTotalTiempo value for the LiquidacionRutas object</param>
		/// <param name="curComida">decimal that contents the curComida value for the LiquidacionRutas object</param>
		/// <param name="intTiempoCargueVacio">decimal that contents the intTiempoCargueVacio value for the LiquidacionRutas object</param>
		/// <param name="intTiempoDescargueVacio">decimal that contents the intTiempoDescargueVacio value for the LiquidacionRutas object</param>
		/// <param name="intTiempoAduanaVacio">decimal that contents the intTiempoAduanaVacio value for the LiquidacionRutas object</param>
		/// <param name="intTotalTrayectoVacio">decimal that contents the intTotalTrayectoVacio value for the LiquidacionRutas object</param>
		/// <param name="intTotalTiempoVacio">decimal that contents the intTotalTiempoVacio value for the LiquidacionRutas object</param>
		/// <param name="curComidaVacio">decimal that contents the curComidaVacio value for the LiquidacionRutas object</param>
		/// <param name="curDesvareManoRepuestos">decimal that contents the curDesvareManoRepuestos value for the LiquidacionRutas object</param>
		/// <param name="curDesvareManoObra">decimal that contents the curDesvareManoObra value for the LiquidacionRutas object</param>
		/// <param name="cutSaldo">decimal that contents the cutSaldo value for the LiquidacionRutas object</param>
		/// <param name="cutKmts">decimal that contents the cutKmts value for the LiquidacionRutas object</param>
		/// <param name="logAjuste">bool that contents the logAjuste value for the LiquidacionRutas object</param>
		/// <param name="dtmFechaModif">DateTime that contents the dtmFechaModif value for the LiquidacionRutas object</param>
		/// <param name="logVacio">bool that contents the logVacio value for the LiquidacionRutas object</param>
		/// <param name="TipoVehiculoCodigo">int that contents the TipoVehiculoCodigo value for the LiquidacionRutas object</param>
		/// <param name="TipoVehiculo">string that contents the TipoVehiculo value for the LiquidacionRutas object</param>
		/// <param name="TipoTrailerCodigo">int that contents the TipoTrailerCodigo value for the LiquidacionRutas object</param>
		/// <param name="Peso">int that contents the Peso value for the LiquidacionRutas object</param>
		/// <param name="Contenedor1">string that contents the Contenedor1 value for the LiquidacionRutas object</param>
		/// <param name="Contenedor2">string that contents the Contenedor2 value for the LiquidacionRutas object</param>
		/// <param name="FactorCalculoDia">int that contents the FactorCalculoDia value for the LiquidacionRutas object</param>
		/// <param name="ValorCalculoFactor">decimal that contents the ValorCalculoFactor value for the LiquidacionRutas object</param>
		/// <param name="ParqueaderoCarretera">decimal that contents the ParqueaderoCarretera value for the LiquidacionRutas object</param>
		/// <param name="ParqueaderoCiudad">decimal that contents the ParqueaderoCiudad value for the LiquidacionRutas object</param>
		/// <param name="MontadaLLantaCarretera">decimal that contents the MontadaLLantaCarretera value for the LiquidacionRutas object</param>
		/// <param name="MontadaLLantaCiudad">decimal that contents the MontadaLLantaCiudad value for the LiquidacionRutas object</param>
		/// <param name="AjusteCarretera">decimal that contents the AjusteCarretera value for the LiquidacionRutas object</param>
		/// <param name="Taxi">decimal that contents the Taxi value for the LiquidacionRutas object</param>
		/// <param name="Aseo">decimal that contents the Aseo value for the LiquidacionRutas object</param>
		/// <param name="Amarres">decimal that contents the Amarres value for the LiquidacionRutas object</param>
		/// <param name="Engradasa">decimal that contents the Engradasa value for the LiquidacionRutas object</param>
		/// <param name="Calibrada">decimal that contents the Calibrada value for the LiquidacionRutas object</param>
		/// <param name="Liquidado">bool that contents the Liquidado value for the LiquidacionRutas object</param>
		/// <param name="Lavada">decimal that contents the Lavada value for the LiquidacionRutas object</param>
		/// <param name="logEstadoRuta">bool that contents the logEstadoRuta value for the LiquidacionRutas object</param>
		/// <param name="Papeleria">decimal that contents the Papeleria value for the LiquidacionRutas object</param>
		/// <param name="logFavorito">bool that contents the logFavorito value for the LiquidacionRutas object</param>
		/// <param name="CurCargue">decimal that contents the CurCargue value for the LiquidacionRutas object</param>
		/// <param name="CurDescargue">decimal that contents the CurDescargue value for the LiquidacionRutas object</param>
		/// <param name="logLiquParticipacion">bool that contents the logLiquParticipacion value for the LiquidacionRutas object</param>
		/// <param name="lngIdRegistrRutaItemId">int that contents the lngIdRegistrRutaItemId value for the LiquidacionRutas object</param>
		public void Update(int? lngIdRegistrRuta, int? lngIdRegistro, int? lngIdRegistrRutaItemIdAjc, string strRutaAnticipoGrupoOrigen, string strRutaAnticipoGrupoDestino, string strRutaAnticipoGrupo, string strRutaAnticipo, bool? logLiquidado, string PlacaTrayler, string Trailer, decimal? floGalones, decimal? floGalonesReales, decimal? floGalonesReserva, decimal? curValorGalon, decimal? CombustibleCarretera, decimal? cutCombustible, bool? LogAnticipoACPM, decimal? cutValorAnticipo, int? lngIdNroPeajes, decimal? cutPeaje, string strNombrePeajes, decimal? cutVariosLlantas, decimal? cutVariosCelada, decimal? cutVariosPropina, decimal? cutVarios, decimal? cutVariosLlantasVacio, decimal? cutVariosCeladaVacio, decimal? cutVariosPropinaVacio, decimal? cutVariosVacio, decimal? cutParticipacion, decimal? cutParticipacionVacio, int? curHotelCarretera, int? curHotelCiudad, decimal? curHotel, int? curHotelCarreteraVacio, int? curHotelCiudadVacio, decimal? curHotelVacio, decimal? intTiempoCargue, decimal? intTiempoDescargue, decimal? intTiempoAduana, decimal? intTotalTrayecto, decimal? intTotalTiempo, decimal? curComida, decimal? intTiempoCargueVacio, decimal? intTiempoDescargueVacio, decimal? intTiempoAduanaVacio, decimal? intTotalTrayectoVacio, decimal? intTotalTiempoVacio, decimal? curComidaVacio, decimal? curDesvareManoRepuestos, decimal? curDesvareManoObra, decimal? cutSaldo, decimal? cutKmts, bool? logAjuste, DateTime? dtmFechaModif, bool? logVacio, int? TipoVehiculoCodigo, string TipoVehiculo, int? TipoTrailerCodigo, int? Peso, string Contenedor1, string Contenedor2, int? FactorCalculoDia, decimal? ValorCalculoFactor, decimal? ParqueaderoCarretera, decimal? ParqueaderoCiudad, decimal? MontadaLLantaCarretera, decimal? MontadaLLantaCiudad, decimal? AjusteCarretera, decimal? Taxi, decimal? Aseo, decimal? Amarres, decimal? Engradasa, decimal? Calibrada, bool? Liquidado, decimal? Lavada, bool? logEstadoRuta, decimal? Papeleria, bool? logFavorito, decimal? CurCargue, decimal? CurDescargue, bool? logLiquParticipacion, int lngIdRegistrRutaItemId, Sinapsys.Datos.SQL datosTransaccion=null)
		{
			try 
			{
				LiquidacionRutas new_values = new LiquidacionRutas();
				new_values.lngIdRegistrRuta = lngIdRegistrRuta;
				new_values.lngIdRegistro = lngIdRegistro;
				new_values.lngIdRegistrRutaItemIdAjc = lngIdRegistrRutaItemIdAjc;
				new_values.strRutaAnticipoGrupoOrigen = strRutaAnticipoGrupoOrigen;
				new_values.strRutaAnticipoGrupoDestino = strRutaAnticipoGrupoDestino;
				new_values.strRutaAnticipoGrupo = strRutaAnticipoGrupo;
				new_values.strRutaAnticipo = strRutaAnticipo;
				new_values.logLiquidado = logLiquidado;
				new_values.PlacaTrayler = PlacaTrayler;
				new_values.Trailer = Trailer;
				new_values.floGalones = floGalones;
				new_values.floGalonesReales = floGalonesReales;
				new_values.floGalonesReserva = floGalonesReserva;
				new_values.curValorGalon = curValorGalon;
				new_values.CombustibleCarretera = CombustibleCarretera;
				new_values.cutCombustible = cutCombustible;
				new_values.LogAnticipoACPM = LogAnticipoACPM;
				new_values.cutValorAnticipo = cutValorAnticipo;
				new_values.lngIdNroPeajes = lngIdNroPeajes;
				new_values.cutPeaje = cutPeaje;
				new_values.strNombrePeajes = strNombrePeajes;
				new_values.cutVariosLlantas = cutVariosLlantas;
				new_values.cutVariosCelada = cutVariosCelada;
				new_values.cutVariosPropina = cutVariosPropina;
				new_values.cutVarios = cutVarios;
				new_values.cutVariosLlantasVacio = cutVariosLlantasVacio;
				new_values.cutVariosCeladaVacio = cutVariosCeladaVacio;
				new_values.cutVariosPropinaVacio = cutVariosPropinaVacio;
				new_values.cutVariosVacio = cutVariosVacio;
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
				new_values.cutKmts = cutKmts;
				new_values.logAjuste = logAjuste;
				new_values.dtmFechaModif = dtmFechaModif;
				new_values.logVacio = logVacio;
				new_values.TipoVehiculoCodigo = TipoVehiculoCodigo;
				new_values.TipoVehiculo = TipoVehiculo;
				new_values.TipoTrailerCodigo = TipoTrailerCodigo;
				new_values.Peso = Peso;
				new_values.Contenedor1 = Contenedor1;
				new_values.Contenedor2 = Contenedor2;
				new_values.FactorCalculoDia = FactorCalculoDia;
				new_values.ValorCalculoFactor = ValorCalculoFactor;
				new_values.ParqueaderoCarretera = ParqueaderoCarretera;
				new_values.ParqueaderoCiudad = ParqueaderoCiudad;
				new_values.MontadaLLantaCarretera = MontadaLLantaCarretera;
				new_values.MontadaLLantaCiudad = MontadaLLantaCiudad;
				new_values.AjusteCarretera = AjusteCarretera;
				new_values.Taxi = Taxi;
				new_values.Aseo = Aseo;
				new_values.Amarres = Amarres;
				new_values.Engradasa = Engradasa;
				new_values.Calibrada = Calibrada;
				new_values.Liquidado = Liquidado;
				new_values.Lavada = Lavada;
				new_values.logEstadoRuta = logEstadoRuta;
				new_values.Papeleria = Papeleria;
				new_values.logFavorito = logFavorito;
				new_values.CurCargue = CurCargue;
				new_values.CurDescargue = CurDescargue;
				new_values.logLiquParticipacion = logLiquParticipacion;
				LiquidacionRutasDataProvider.Instance.Update(lngIdRegistrRuta, lngIdRegistro, lngIdRegistrRutaItemIdAjc, strRutaAnticipoGrupoOrigen, strRutaAnticipoGrupoDestino, strRutaAnticipoGrupo, strRutaAnticipo, logLiquidado, PlacaTrayler, Trailer, floGalones, floGalonesReales, floGalonesReserva, curValorGalon, CombustibleCarretera, cutCombustible, LogAnticipoACPM, cutValorAnticipo, lngIdNroPeajes, cutPeaje, strNombrePeajes, cutVariosLlantas, cutVariosCelada, cutVariosPropina, cutVarios, cutVariosLlantasVacio, cutVariosCeladaVacio, cutVariosPropinaVacio, cutVariosVacio, cutParticipacion, cutParticipacionVacio, curHotelCarretera, curHotelCiudad, curHotel, curHotelCarreteraVacio, curHotelCiudadVacio, curHotelVacio, intTiempoCargue, intTiempoDescargue, intTiempoAduana, intTotalTrayecto, intTotalTiempo, curComida, intTiempoCargueVacio, intTiempoDescargueVacio, intTiempoAduanaVacio, intTotalTrayectoVacio, intTotalTiempoVacio, curComidaVacio, curDesvareManoRepuestos, curDesvareManoObra, cutSaldo, cutKmts, logAjuste, dtmFechaModif, logVacio, TipoVehiculoCodigo, TipoVehiculo, TipoTrailerCodigo, Peso, Contenedor1, Contenedor2, FactorCalculoDia, ValorCalculoFactor, ParqueaderoCarretera, ParqueaderoCiudad, MontadaLLantaCarretera, MontadaLLantaCiudad, AjusteCarretera, Taxi, Aseo, Amarres, Engradasa, Calibrada, Liquidado, Lavada, logEstadoRuta, Papeleria, logFavorito, CurCargue, CurDescargue, logLiquParticipacion, lngIdRegistrRutaItemId,"LiquidacionRutas",datosTransaccion);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Updates an LiquidacionRutas object by passing one object's instance as reference
		/// </summary>
		/// <param name="liquidacionrutas">An instance of LiquidacionRutas for reference</param>
		public void Update(LiquidacionRutas liquidacionrutas,Sinapsys.Datos.SQL datosTransaccion=null)
		{
			Update(liquidacionrutas.lngIdRegistrRuta, liquidacionrutas.lngIdRegistro, liquidacionrutas.lngIdRegistrRutaItemIdAjc, liquidacionrutas.strRutaAnticipoGrupoOrigen, liquidacionrutas.strRutaAnticipoGrupoDestino, liquidacionrutas.strRutaAnticipoGrupo, liquidacionrutas.strRutaAnticipo, liquidacionrutas.logLiquidado, liquidacionrutas.PlacaTrayler, liquidacionrutas.Trailer, liquidacionrutas.floGalones, liquidacionrutas.floGalonesReales, liquidacionrutas.floGalonesReserva, liquidacionrutas.curValorGalon, liquidacionrutas.CombustibleCarretera, liquidacionrutas.cutCombustible, liquidacionrutas.LogAnticipoACPM, liquidacionrutas.cutValorAnticipo, liquidacionrutas.lngIdNroPeajes, liquidacionrutas.cutPeaje, liquidacionrutas.strNombrePeajes, liquidacionrutas.cutVariosLlantas, liquidacionrutas.cutVariosCelada, liquidacionrutas.cutVariosPropina, liquidacionrutas.cutVarios, liquidacionrutas.cutVariosLlantasVacio, liquidacionrutas.cutVariosCeladaVacio, liquidacionrutas.cutVariosPropinaVacio, liquidacionrutas.cutVariosVacio, liquidacionrutas.cutParticipacion, liquidacionrutas.cutParticipacionVacio, liquidacionrutas.curHotelCarretera, liquidacionrutas.curHotelCiudad, liquidacionrutas.curHotel, liquidacionrutas.curHotelCarreteraVacio, liquidacionrutas.curHotelCiudadVacio, liquidacionrutas.curHotelVacio, liquidacionrutas.intTiempoCargue, liquidacionrutas.intTiempoDescargue, liquidacionrutas.intTiempoAduana, liquidacionrutas.intTotalTrayecto, liquidacionrutas.intTotalTiempo, liquidacionrutas.curComida, liquidacionrutas.intTiempoCargueVacio, liquidacionrutas.intTiempoDescargueVacio, liquidacionrutas.intTiempoAduanaVacio, liquidacionrutas.intTotalTrayectoVacio, liquidacionrutas.intTotalTiempoVacio, liquidacionrutas.curComidaVacio, liquidacionrutas.curDesvareManoRepuestos, liquidacionrutas.curDesvareManoObra, liquidacionrutas.cutSaldo, liquidacionrutas.cutKmts, liquidacionrutas.logAjuste, liquidacionrutas.dtmFechaModif, liquidacionrutas.logVacio, liquidacionrutas.TipoVehiculoCodigo, liquidacionrutas.TipoVehiculo, liquidacionrutas.TipoTrailerCodigo, liquidacionrutas.Peso, liquidacionrutas.Contenedor1, liquidacionrutas.Contenedor2, liquidacionrutas.FactorCalculoDia, liquidacionrutas.ValorCalculoFactor, liquidacionrutas.ParqueaderoCarretera, liquidacionrutas.ParqueaderoCiudad, liquidacionrutas.MontadaLLantaCarretera, liquidacionrutas.MontadaLLantaCiudad, liquidacionrutas.AjusteCarretera, liquidacionrutas.Taxi, liquidacionrutas.Aseo, liquidacionrutas.Amarres, liquidacionrutas.Engradasa, liquidacionrutas.Calibrada, liquidacionrutas.Liquidado, liquidacionrutas.Lavada, liquidacionrutas.logEstadoRuta, liquidacionrutas.Papeleria, liquidacionrutas.logFavorito, liquidacionrutas.CurCargue, liquidacionrutas.CurDescargue, liquidacionrutas.logLiquParticipacion, liquidacionrutas.lngIdRegistrRutaItemId);
		}

		/// <summary>
		/// Delete  the LiquidacionRutas object by passing a object
		/// </summary>
		public void  Delete(LiquidacionRutas liquidacionrutas, Sinapsys.Datos.SQL datosTransaccion=null)
		{
			Delete(liquidacionrutas.lngIdRegistrRutaItemId,datosTransaccion);
		}

		/// <summary>
		/// Deletes the LiquidacionRutas object by passing one object's instance as reference
		/// </summary>
		/// <param name="liquidacionrutas">An instance of LiquidacionRutas for reference</param>
		public void Delete(int lngIdRegistrRutaItemId, Sinapsys.Datos.SQL datosTransaccion=null)
		{
			try 
			{
				//LiquidacionRutas old_values = LiquidacionRutasController.Instance.Get(lngIdRegistrRutaItemId);
				//if(!Validate.security.CanDeleteSecurityField(LiquidacionRutasController.Instance, (ILatinodeObject)old_values))
				//    throw new Exception("Access denied by security field, you can't delete object");

				LiquidacionRutasDataProvider.Instance.Delete(lngIdRegistrRutaItemId,"LiquidacionRutas");
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Deletes the LiquidacionRutas object by passing CVS parameter as reference
		/// </summary>
		/// <param name="liquidacionrutas">An instance of LiquidacionRutas for reference</param>
		public void Delete(string CVSParameter)
		{
			string[] StrCommand=CVSParameter.Split(',');
			try 
			{
				int lngIdRegistrRutaItemId=int.Parse(StrCommand[0]);
				LiquidacionRutasDataProvider.Instance.Delete(lngIdRegistrRutaItemId,"LiquidacionRutas");
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Gets the LiquidacionRutas object by passing the object's key fields
		/// </summary>
		/// <param name="lngIdRegistrRutaItemId">int that contents the lngIdRegistrRutaItemId value for the LiquidacionRutas object</param>
		/// <returns>One LiquidacionRutas object</returns>
		public LiquidacionRutas Get(int lngIdRegistrRutaItemId, bool generateUndo=false)
		{
			try 
			{
				LiquidacionRutas liquidacionrutas = null;
				DataTable dt = LiquidacionRutasDataProvider.Instance.Get(lngIdRegistrRutaItemId);
				if ((dt.Rows.Count > 0))
				{
					liquidacionrutas = new LiquidacionRutas();
					DataRow dr = dt.Rows[0];
					ReadData(liquidacionrutas, dr, generateUndo);
				}


				return liquidacionrutas;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Gets all objects of LiquidacionRutas
		/// </summary>
		/// <returns>One LiquidacionRutasList object</returns>
		public LiquidacionRutasList GetAll(bool generateUndo=false)
		{
			try 
			{
				LiquidacionRutasList liquidacionrutaslist = new LiquidacionRutasList();
				DataTable dt = LiquidacionRutasDataProvider.Instance.GetAll();
				foreach (DataRow dr in dt.Rows)
				{
					LiquidacionRutas liquidacionrutas = new LiquidacionRutas();
					ReadData(liquidacionrutas, dr, generateUndo);
					liquidacionrutaslist.Add(liquidacionrutas);
				}
				return liquidacionrutaslist;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Selects all LiquidacionRutas objects by reference (Foreign Keys)
		/// </summary>
		/// <param name="lngIdRegistro">int that contents the lngIdRegistro value for the LiquidacionRutas object</param>
		/// <returns>One LiquidacionRutasList object</returns>
		public LiquidacionRutasList GetBy_lngIdRegistro(int lngIdRegistro,bool generateUndo=false)
		{
			try 
			{
				LiquidacionRutasList liquidacionrutaslist = new LiquidacionRutasList();

				DataTable dt = LiquidacionRutasDataProvider.Instance.GetBy_lngIdRegistro(lngIdRegistro);
				foreach (DataRow dr in dt.Rows)
				{
					LiquidacionRutas liquidacionrutas = new LiquidacionRutas();
					ReadData(liquidacionrutas, dr, generateUndo);
					liquidacionrutaslist.Add(liquidacionrutas);
				}
				return liquidacionrutaslist;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Gets all objects of LiquidacionRutas applying filter and sort criteria
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
		/// <returns>One LiquidacionRutasList object</returns>
		public LiquidacionRutasList GetFilter(int pagenum, int pagesize, string filter, string sort, string extablesfilter, string extablesfieldsfilter, string extablesrelationsfilter, string extablessort, string extablesfieldssort, string extablesrelationssort, bool generateUndo=false)
		{
			try 
			{
				LiquidacionRutasList liquidacionrutaslist = new LiquidacionRutasList();

				DataTable dt = LiquidacionRutasDataProvider.Instance.GetFilter(pagenum, pagesize, filter, sort, extablesfilter, extablesfieldsfilter, extablesrelationsfilter, extablessort, extablesfieldssort, extablesrelationssort);

				foreach (DataRow dr in dt.Rows)
				{
					LiquidacionRutas liquidacionrutas = new LiquidacionRutas();
					ReadData(liquidacionrutas, dr, generateUndo);
					liquidacionrutaslist.Add(liquidacionrutas);
				}
				return liquidacionrutaslist;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public LiquidacionRutasList GetFilter( string filter, string sort, bool generateUndo=false)
		{
			return GetFilter(0,0, filter, sort, "","","","","","",generateUndo);
		}

		public LiquidacionRutasList GetFilter(string filter, string sort, string extablesfilter, string extablesfieldsfilter, string extablesrelationsfilter, string extablessort, string extablesfieldssort, string extablesrelationssort, bool generateUndo=false)
		{
			return GetFilter(0,0, filter, sort, extablesfilter, extablesfieldsfilter, extablesrelationsfilter, extablessort, extablesfieldssort, extablesrelationssort,generateUndo);
		}


		/// <summary>
		/// Returns the type for one property
		/// </summary>
		/// <param name="propertyname">Property's name for return its value</param>
		/// <returns>A value for the <paramref name="propertyname"/></returns>
		public Type GetMethodType( string propertyname,LiquidacionRutas liquidacionrutas)
		{
			// Perform the search for the property's value
			switch (propertyname)
			{
				case "lngIdRegistrRuta":
					return liquidacionrutas.lngIdRegistrRuta.GetType();

				case "lngIdRegistro":
					return liquidacionrutas.lngIdRegistro.GetType();

				case "lngIdRegistrRutaItemIdAjc":
					return liquidacionrutas.lngIdRegistrRutaItemIdAjc.GetType();

				case "strRutaAnticipoGrupoOrigen":
					return liquidacionrutas.strRutaAnticipoGrupoOrigen.GetType();

				case "strRutaAnticipoGrupoDestino":
					return liquidacionrutas.strRutaAnticipoGrupoDestino.GetType();

				case "strRutaAnticipoGrupo":
					return liquidacionrutas.strRutaAnticipoGrupo.GetType();

				case "strRutaAnticipo":
					return liquidacionrutas.strRutaAnticipo.GetType();

				case "logLiquidado":
					return liquidacionrutas.logLiquidado.GetType();

				case "PlacaTrayler":
					return liquidacionrutas.PlacaTrayler.GetType();

				case "Trailer":
					return liquidacionrutas.Trailer.GetType();

				case "floGalones":
					return liquidacionrutas.floGalones.GetType();

				case "floGalonesReales":
					return liquidacionrutas.floGalonesReales.GetType();

				case "floGalonesReserva":
					return liquidacionrutas.floGalonesReserva.GetType();

				case "curValorGalon":
					return liquidacionrutas.curValorGalon.GetType();

				case "CombustibleCarretera":
					return liquidacionrutas.CombustibleCarretera.GetType();

				case "cutCombustible":
					return liquidacionrutas.cutCombustible.GetType();

				case "LogAnticipoACPM":
					return liquidacionrutas.LogAnticipoACPM.GetType();

				case "cutValorAnticipo":
					return liquidacionrutas.cutValorAnticipo.GetType();

				case "lngIdNroPeajes":
					return liquidacionrutas.lngIdNroPeajes.GetType();

				case "cutPeaje":
					return liquidacionrutas.cutPeaje.GetType();

				case "strNombrePeajes":
					return liquidacionrutas.strNombrePeajes.GetType();

				case "cutVariosLlantas":
					return liquidacionrutas.cutVariosLlantas.GetType();

				case "cutVariosCelada":
					return liquidacionrutas.cutVariosCelada.GetType();

				case "cutVariosPropina":
					return liquidacionrutas.cutVariosPropina.GetType();

				case "cutVarios":
					return liquidacionrutas.cutVarios.GetType();

				case "cutVariosLlantasVacio":
					return liquidacionrutas.cutVariosLlantasVacio.GetType();

				case "cutVariosCeladaVacio":
					return liquidacionrutas.cutVariosCeladaVacio.GetType();

				case "cutVariosPropinaVacio":
					return liquidacionrutas.cutVariosPropinaVacio.GetType();

				case "cutVariosVacio":
					return liquidacionrutas.cutVariosVacio.GetType();

				case "cutParticipacion":
					return liquidacionrutas.cutParticipacion.GetType();

				case "cutParticipacionVacio":
					return liquidacionrutas.cutParticipacionVacio.GetType();

				case "curHotelCarretera":
					return liquidacionrutas.curHotelCarretera.GetType();

				case "curHotelCiudad":
					return liquidacionrutas.curHotelCiudad.GetType();

				case "curHotel":
					return liquidacionrutas.curHotel.GetType();

				case "curHotelCarreteraVacio":
					return liquidacionrutas.curHotelCarreteraVacio.GetType();

				case "curHotelCiudadVacio":
					return liquidacionrutas.curHotelCiudadVacio.GetType();

				case "curHotelVacio":
					return liquidacionrutas.curHotelVacio.GetType();

				case "intTiempoCargue":
					return liquidacionrutas.intTiempoCargue.GetType();

				case "intTiempoDescargue":
					return liquidacionrutas.intTiempoDescargue.GetType();

				case "intTiempoAduana":
					return liquidacionrutas.intTiempoAduana.GetType();

				case "intTotalTrayecto":
					return liquidacionrutas.intTotalTrayecto.GetType();

				case "intTotalTiempo":
					return liquidacionrutas.intTotalTiempo.GetType();

				case "curComida":
					return liquidacionrutas.curComida.GetType();

				case "intTiempoCargueVacio":
					return liquidacionrutas.intTiempoCargueVacio.GetType();

				case "intTiempoDescargueVacio":
					return liquidacionrutas.intTiempoDescargueVacio.GetType();

				case "intTiempoAduanaVacio":
					return liquidacionrutas.intTiempoAduanaVacio.GetType();

				case "intTotalTrayectoVacio":
					return liquidacionrutas.intTotalTrayectoVacio.GetType();

				case "intTotalTiempoVacio":
					return liquidacionrutas.intTotalTiempoVacio.GetType();

				case "curComidaVacio":
					return liquidacionrutas.curComidaVacio.GetType();

				case "curDesvareManoRepuestos":
					return liquidacionrutas.curDesvareManoRepuestos.GetType();

				case "curDesvareManoObra":
					return liquidacionrutas.curDesvareManoObra.GetType();

				case "cutSaldo":
					return liquidacionrutas.cutSaldo.GetType();

				case "cutKmts":
					return liquidacionrutas.cutKmts.GetType();

				case "logAjuste":
					return liquidacionrutas.logAjuste.GetType();

				case "dtmFechaModif":
					return liquidacionrutas.dtmFechaModif.GetType();

				case "logVacio":
					return liquidacionrutas.logVacio.GetType();

				case "TipoVehiculoCodigo":
					return liquidacionrutas.TipoVehiculoCodigo.GetType();

				case "TipoVehiculo":
					return liquidacionrutas.TipoVehiculo.GetType();

				case "TipoTrailerCodigo":
					return liquidacionrutas.TipoTrailerCodigo.GetType();

				case "Peso":
					return liquidacionrutas.Peso.GetType();

				case "Contenedor1":
					return liquidacionrutas.Contenedor1.GetType();

				case "Contenedor2":
					return liquidacionrutas.Contenedor2.GetType();

				case "FactorCalculoDia":
					return liquidacionrutas.FactorCalculoDia.GetType();

				case "ValorCalculoFactor":
					return liquidacionrutas.ValorCalculoFactor.GetType();

				case "ParqueaderoCarretera":
					return liquidacionrutas.ParqueaderoCarretera.GetType();

				case "ParqueaderoCiudad":
					return liquidacionrutas.ParqueaderoCiudad.GetType();

				case "MontadaLLantaCarretera":
					return liquidacionrutas.MontadaLLantaCarretera.GetType();

				case "MontadaLLantaCiudad":
					return liquidacionrutas.MontadaLLantaCiudad.GetType();

				case "AjusteCarretera":
					return liquidacionrutas.AjusteCarretera.GetType();

				case "Taxi":
					return liquidacionrutas.Taxi.GetType();

				case "Aseo":
					return liquidacionrutas.Aseo.GetType();

				case "Amarres":
					return liquidacionrutas.Amarres.GetType();

				case "Engradasa":
					return liquidacionrutas.Engradasa.GetType();

				case "Calibrada":
					return liquidacionrutas.Calibrada.GetType();

				case "Liquidado":
					return liquidacionrutas.Liquidado.GetType();

				case "Lavada":
					return liquidacionrutas.Lavada.GetType();

				case "logEstadoRuta":
					return liquidacionrutas.logEstadoRuta.GetType();

				case "Papeleria":
					return liquidacionrutas.Papeleria.GetType();

				case "logFavorito":
					return liquidacionrutas.logFavorito.GetType();

				case "CurCargue":
					return liquidacionrutas.CurCargue.GetType();

				case "CurDescargue":
					return liquidacionrutas.CurDescargue.GetType();

				case "logLiquParticipacion":
					return liquidacionrutas.logLiquParticipacion.GetType();

				case "lngIdRegistrRutaItemId":
					return liquidacionrutas.lngIdRegistrRutaItemId.GetType();

			}

			return null;
		}
		/// <summary>
		/// update the changes in LiquidacionRutas object by passing the object
		/// </summary>
		public bool UpdateChanges(LiquidacionRutas liquidacionrutas, out string error,Sinapsys.Datos.SQL datosTransaccion=null)
		{
			if (liquidacionrutas.OldLiquidacionRutas == null)
			{
				    error = "No tiene objeto con el cual comparar";
				    return false;
			}
			string[] Fields = liquidacionrutas.FieldChanged();
			error = "";
			return LiqViajes_Bll_Data.DataProvider.UpdateFieldsbyObject(Fields, liquidacionrutas, out error,datosTransaccion);
		}
	}

	#endregion

}
