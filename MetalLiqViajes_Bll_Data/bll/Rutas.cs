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
	#region RutasController

	/// <summary>
	/// Class for convert data from database into object's data and vice versa
	/// </summary>
	public partial class RutasController//: ILatinodeController
	{
		/// <summary>
		/// Generic Constructor
		/// </summary>
		public RutasController()
		{
		}

		/// <summary>
		/// Instance accessor for this singleton
		/// </summary>
		private static RutasController MySingleObj;
		public static RutasController Instance
		{
			get
			{
				if (MySingleObj == null)
				{
					MySingleObj = new RutasController();
				}
				return MySingleObj;
			}
		}

		// Reads object's data from a DataRow
		private void ReadData(Rutas rutas, DataRow dr,bool generateUndo=false)
		{
			try 
			{
				rutas.lngIdRegistrRuta = (int) dr["lngIdRegistrRuta"];
				rutas.RutasOrigenCodigo = dr.IsNull("RutasOrigenCodigo") ? null :(int?) dr["RutasOrigenCodigo"];
				rutas.strRutaAnticipoGrupoOrigen = dr.IsNull("strRutaAnticipoGrupoOrigen") ? null :(string) dr["strRutaAnticipoGrupoOrigen"];
				rutas.strRutaAnticipoGrupoDestino = dr.IsNull("strRutaAnticipoGrupoDestino") ? null :(string) dr["strRutaAnticipoGrupoDestino"];
				rutas.strRutaAnticipoGrupo = dr.IsNull("strRutaAnticipoGrupo") ? null :(string) dr["strRutaAnticipoGrupo"];
				rutas.strRutaAnticipo = dr.IsNull("strRutaAnticipo") ? null :(string) dr["strRutaAnticipo"];
				rutas.TipoVehiculoCodigo = dr.IsNull("TipoVehiculoCodigo") ? null :(int?) dr["TipoVehiculoCodigo"];
				rutas.TipoVehiculo = dr.IsNull("TipoVehiculo") ? null :(string) dr["TipoVehiculo"];
				rutas.TipoTrailerCodigo = dr.IsNull("TipoTrailerCodigo") ? null :(int?) dr["TipoTrailerCodigo"];
				rutas.Peso = dr.IsNull("Peso") ? null :(int?) dr["Peso"];
				rutas.Programa = dr.IsNull("Programa") ? null :(string) dr["Programa"];
				rutas.logViajeVacio = dr.IsNull("logViajeVacio") ? null :(bool?) dr["logViajeVacio"];
				rutas.floGalones = dr.IsNull("floGalones") ? null :(decimal?) dr["floGalones"];
				rutas.curValorGalon = dr.IsNull("curValorGalon") ? null :(decimal?) dr["curValorGalon"];
				rutas.cutCombustible = dr.IsNull("cutCombustible") ? null :(decimal?) dr["cutCombustible"];
				rutas.CombustibleCarretera = dr.IsNull("CombustibleCarretera") ? null :(decimal?) dr["CombustibleCarretera"];
				rutas.lngIdNroPeajes = dr.IsNull("lngIdNroPeajes") ? null :(int?) dr["lngIdNroPeajes"];
				rutas.cutPeaje = dr.IsNull("cutPeaje") ? null :(decimal?) dr["cutPeaje"];
				rutas.strNombrePeajes = dr.IsNull("strNombrePeajes") ? null :(string) dr["strNombrePeajes"];
				rutas.cutVariosLlantas = dr.IsNull("cutVariosLlantas") ? null :(decimal?) dr["cutVariosLlantas"];
				rutas.cutVariosCelada = dr.IsNull("cutVariosCelada") ? null :(decimal?) dr["cutVariosCelada"];
				rutas.cutVariosPropina = dr.IsNull("cutVariosPropina") ? null :(decimal?) dr["cutVariosPropina"];
				rutas.cutVarios = dr.IsNull("cutVarios") ? null :(decimal?) dr["cutVarios"];
				rutas.Llamadas = dr.IsNull("Llamadas") ? null :(decimal?) dr["Llamadas"];
				rutas.Taxi = dr.IsNull("Taxi") ? null :(decimal?) dr["Taxi"];
				rutas.Aseo = dr.IsNull("Aseo") ? null :(decimal?) dr["Aseo"];
				rutas.cutVariosLlantasVacio = dr.IsNull("cutVariosLlantasVacio") ? null :(decimal?) dr["cutVariosLlantasVacio"];
				rutas.cutVariosCeladaVacio = dr.IsNull("cutVariosCeladaVacio") ? null :(decimal?) dr["cutVariosCeladaVacio"];
				rutas.cutVariosPropinaVacio = dr.IsNull("cutVariosPropinaVacio") ? null :(decimal?) dr["cutVariosPropinaVacio"];
				rutas.cutVariosVacio = dr.IsNull("cutVariosVacio") ? null :(decimal?) dr["cutVariosVacio"];
				rutas.Viaticos = dr.IsNull("Viaticos") ? null :(decimal?) dr["Viaticos"];
				rutas.cutParticipacion = dr.IsNull("cutParticipacion") ? null :(decimal?) dr["cutParticipacion"];
				rutas.cutParticipacionVacio = dr.IsNull("cutParticipacionVacio") ? null :(decimal?) dr["cutParticipacionVacio"];
				rutas.curHotelCarretera = dr.IsNull("curHotelCarretera") ? null :(int?) dr["curHotelCarretera"];
				rutas.curHotelCiudad = dr.IsNull("curHotelCiudad") ? null :(int?) dr["curHotelCiudad"];
				rutas.curHotel = dr.IsNull("curHotel") ? null :(decimal?) dr["curHotel"];
				rutas.curHotelCarreteraVacio = dr.IsNull("curHotelCarreteraVacio") ? null :(int?) dr["curHotelCarreteraVacio"];
				rutas.curHotelCiudadVacio = dr.IsNull("curHotelCiudadVacio") ? null :(int?) dr["curHotelCiudadVacio"];
				rutas.curHotelVacio = dr.IsNull("curHotelVacio") ? null :(decimal?) dr["curHotelVacio"];
				rutas.intTiempoCargue = dr.IsNull("intTiempoCargue") ? null :(decimal?) dr["intTiempoCargue"];
				rutas.intTiempoDescargue = dr.IsNull("intTiempoDescargue") ? null :(decimal?) dr["intTiempoDescargue"];
				rutas.intTiempoAduana = dr.IsNull("intTiempoAduana") ? null :(decimal?) dr["intTiempoAduana"];
				rutas.intTotalTrayecto = dr.IsNull("intTotalTrayecto") ? null :(decimal?) dr["intTotalTrayecto"];
				rutas.intTotalTiempo = dr.IsNull("intTotalTiempo") ? null :(decimal?) dr["intTotalTiempo"];
				rutas.curComida = dr.IsNull("curComida") ? null :(decimal?) dr["curComida"];
				rutas.intTiempoCargueVacio = dr.IsNull("intTiempoCargueVacio") ? null :(decimal?) dr["intTiempoCargueVacio"];
				rutas.intTiempoDescargueVacio = dr.IsNull("intTiempoDescargueVacio") ? null :(decimal?) dr["intTiempoDescargueVacio"];
				rutas.intTiempoAduanaVacio = dr.IsNull("intTiempoAduanaVacio") ? null :(decimal?) dr["intTiempoAduanaVacio"];
				rutas.intTotalTrayectoVacio = dr.IsNull("intTotalTrayectoVacio") ? null :(decimal?) dr["intTotalTrayectoVacio"];
				rutas.intTotalTiempoVacio = dr.IsNull("intTotalTiempoVacio") ? null :(decimal?) dr["intTotalTiempoVacio"];
				rutas.curComidaVacio = dr.IsNull("curComidaVacio") ? null :(decimal?) dr["curComidaVacio"];
				rutas.curDesvareManoRepuestos = dr.IsNull("curDesvareManoRepuestos") ? null :(decimal?) dr["curDesvareManoRepuestos"];
				rutas.curDesvareManoObra = dr.IsNull("curDesvareManoObra") ? null :(decimal?) dr["curDesvareManoObra"];
				rutas.cutSaldo = dr.IsNull("cutSaldo") ? null :(decimal?) dr["cutSaldo"];
				rutas.cutSaldoVacio = dr.IsNull("cutSaldoVacio") ? null :(decimal?) dr["cutSaldoVacio"];
				rutas.cutKmts = dr.IsNull("cutKmts") ? null :(decimal?) dr["cutKmts"];
				rutas.logActualizaPeajes = dr.IsNull("logActualizaPeajes") ? null :(decimal?) dr["logActualizaPeajes"];
				rutas.intFactorKmPorGalon = dr.IsNull("intFactorKmPorGalon") ? null :(decimal?) dr["intFactorKmPorGalon"];
				rutas.logEstadoRuta = dr.IsNull("logEstadoRuta") ? null :(bool?) dr["logEstadoRuta"];
				rutas.ParqueaderoCarretera = dr.IsNull("ParqueaderoCarretera") ? null :(decimal?) dr["ParqueaderoCarretera"];
				rutas.ParqueaderoCiudad = dr.IsNull("ParqueaderoCiudad") ? null :(decimal?) dr["ParqueaderoCiudad"];
				rutas.MontadaLLantaCarretera = dr.IsNull("MontadaLLantaCarretera") ? null :(decimal?) dr["MontadaLLantaCarretera"];
				rutas.MontadaLLantaCiudad = dr.IsNull("MontadaLLantaCiudad") ? null :(decimal?) dr["MontadaLLantaCiudad"];
				rutas.AjusteCarretera = dr.IsNull("AjusteCarretera") ? null :(decimal?) dr["AjusteCarretera"];
				rutas.Lavada = dr.IsNull("Lavada") ? null :(decimal?) dr["Lavada"];
				rutas.Amarres = dr.IsNull("Amarres") ? null :(decimal?) dr["Amarres"];
				rutas.Engradasa = dr.IsNull("Engradasa") ? null :(decimal?) dr["Engradasa"];
				rutas.Calibrada = dr.IsNull("Calibrada") ? null :(decimal?) dr["Calibrada"];
				rutas.Liquidado = dr.IsNull("Liquidado") ? null :(bool?) dr["Liquidado"];
				rutas.logVacio = dr.IsNull("logVacio") ? null :(bool?) dr["logVacio"];
				rutas.Papeleria = dr.IsNull("Papeleria") ? null :(decimal?) dr["Papeleria"];
				rutas.logFavorito = dr.IsNull("logFavorito") ? null :(bool?) dr["logFavorito"];
				rutas.CurCargue = dr.IsNull("CurCargue") ? null :(decimal?) dr["CurCargue"];
				rutas.CurDescargue = dr.IsNull("CurDescargue") ? null :(decimal?) dr["CurDescargue"];
				rutas.LogAnticipoACPM = dr.IsNull("LogAnticipoACPM") ? null :(bool?) dr["LogAnticipoACPM"];
			}
			catch (Exception ex)
			{
				Utilidades.LogErrores(ex.Message + (ex.InnerException != null ? ex.InnerException.Message : ""), DataProvider.AplicacionNombre);
				throw ex;
			}
			if (generateUndo) rutas.GenerateUndo();
		}

		/// <summary>
		/// Create a new Rutas object by passing a object
		/// </summary>
		public Rutas Create(Rutas rutas, Sinapsys.Datos.SQL datosTransaccion=null)
		{
			return Create(rutas.lngIdRegistrRuta,rutas.RutasOrigenCodigo,rutas.strRutaAnticipoGrupoOrigen,rutas.strRutaAnticipoGrupoDestino,rutas.strRutaAnticipoGrupo,rutas.strRutaAnticipo,rutas.TipoVehiculoCodigo,rutas.TipoVehiculo,rutas.TipoTrailerCodigo,rutas.Peso,rutas.Programa,rutas.logViajeVacio,rutas.floGalones,rutas.curValorGalon,rutas.cutCombustible,rutas.CombustibleCarretera,rutas.lngIdNroPeajes,rutas.cutPeaje,rutas.strNombrePeajes,rutas.cutVariosLlantas,rutas.cutVariosCelada,rutas.cutVariosPropina,rutas.cutVarios,rutas.Llamadas,rutas.Taxi,rutas.Aseo,rutas.cutVariosLlantasVacio,rutas.cutVariosCeladaVacio,rutas.cutVariosPropinaVacio,rutas.cutVariosVacio,rutas.Viaticos,rutas.cutParticipacion,rutas.cutParticipacionVacio,rutas.curHotelCarretera,rutas.curHotelCiudad,rutas.curHotel,rutas.curHotelCarreteraVacio,rutas.curHotelCiudadVacio,rutas.curHotelVacio,rutas.intTiempoCargue,rutas.intTiempoDescargue,rutas.intTiempoAduana,rutas.intTotalTrayecto,rutas.intTotalTiempo,rutas.curComida,rutas.intTiempoCargueVacio,rutas.intTiempoDescargueVacio,rutas.intTiempoAduanaVacio,rutas.intTotalTrayectoVacio,rutas.intTotalTiempoVacio,rutas.curComidaVacio,rutas.curDesvareManoRepuestos,rutas.curDesvareManoObra,rutas.cutSaldo,rutas.cutSaldoVacio,rutas.cutKmts,rutas.logActualizaPeajes,rutas.intFactorKmPorGalon,rutas.logEstadoRuta,rutas.ParqueaderoCarretera,rutas.ParqueaderoCiudad,rutas.MontadaLLantaCarretera,rutas.MontadaLLantaCiudad,rutas.AjusteCarretera,rutas.Lavada,rutas.Amarres,rutas.Engradasa,rutas.Calibrada,rutas.Liquidado,rutas.logVacio,rutas.Papeleria,rutas.logFavorito,rutas.CurCargue,rutas.CurDescargue,rutas.LogAnticipoACPM,datosTransaccion);
		}

		/// <summary>
		/// Creates a new Rutas object by passing all object's fields
		/// </summary>
		/// <param name="RutasOrigenCodigo">int that contents the RutasOrigenCodigo value for the Rutas object</param>
		/// <param name="strRutaAnticipoGrupoOrigen">string that contents the strRutaAnticipoGrupoOrigen value for the Rutas object</param>
		/// <param name="strRutaAnticipoGrupoDestino">string that contents the strRutaAnticipoGrupoDestino value for the Rutas object</param>
		/// <param name="strRutaAnticipoGrupo">string that contents the strRutaAnticipoGrupo value for the Rutas object</param>
		/// <param name="strRutaAnticipo">string that contents the strRutaAnticipo value for the Rutas object</param>
		/// <param name="TipoVehiculoCodigo">int that contents the TipoVehiculoCodigo value for the Rutas object</param>
		/// <param name="TipoVehiculo">string that contents the TipoVehiculo value for the Rutas object</param>
		/// <param name="TipoTrailerCodigo">int that contents the TipoTrailerCodigo value for the Rutas object</param>
		/// <param name="Peso">int that contents the Peso value for the Rutas object</param>
		/// <param name="Programa">string that contents the Programa value for the Rutas object</param>
		/// <param name="logViajeVacio">bool that contents the logViajeVacio value for the Rutas object</param>
		/// <param name="floGalones">decimal that contents the floGalones value for the Rutas object</param>
		/// <param name="curValorGalon">decimal that contents the curValorGalon value for the Rutas object</param>
		/// <param name="cutCombustible">decimal that contents the cutCombustible value for the Rutas object</param>
		/// <param name="CombustibleCarretera">decimal that contents the CombustibleCarretera value for the Rutas object</param>
		/// <param name="lngIdNroPeajes">int that contents the lngIdNroPeajes value for the Rutas object</param>
		/// <param name="cutPeaje">decimal that contents the cutPeaje value for the Rutas object</param>
		/// <param name="strNombrePeajes">string that contents the strNombrePeajes value for the Rutas object</param>
		/// <param name="cutVariosLlantas">decimal that contents the cutVariosLlantas value for the Rutas object</param>
		/// <param name="cutVariosCelada">decimal that contents the cutVariosCelada value for the Rutas object</param>
		/// <param name="cutVariosPropina">decimal that contents the cutVariosPropina value for the Rutas object</param>
		/// <param name="cutVarios">decimal that contents the cutVarios value for the Rutas object</param>
		/// <param name="Llamadas">decimal that contents the Llamadas value for the Rutas object</param>
		/// <param name="Taxi">decimal that contents the Taxi value for the Rutas object</param>
		/// <param name="Aseo">decimal that contents the Aseo value for the Rutas object</param>
		/// <param name="cutVariosLlantasVacio">decimal that contents the cutVariosLlantasVacio value for the Rutas object</param>
		/// <param name="cutVariosCeladaVacio">decimal that contents the cutVariosCeladaVacio value for the Rutas object</param>
		/// <param name="cutVariosPropinaVacio">decimal that contents the cutVariosPropinaVacio value for the Rutas object</param>
		/// <param name="cutVariosVacio">decimal that contents the cutVariosVacio value for the Rutas object</param>
		/// <param name="Viaticos">decimal that contents the Viaticos value for the Rutas object</param>
		/// <param name="cutParticipacion">decimal that contents the cutParticipacion value for the Rutas object</param>
		/// <param name="cutParticipacionVacio">decimal that contents the cutParticipacionVacio value for the Rutas object</param>
		/// <param name="curHotelCarretera">int that contents the curHotelCarretera value for the Rutas object</param>
		/// <param name="curHotelCiudad">int that contents the curHotelCiudad value for the Rutas object</param>
		/// <param name="curHotel">decimal that contents the curHotel value for the Rutas object</param>
		/// <param name="curHotelCarreteraVacio">int that contents the curHotelCarreteraVacio value for the Rutas object</param>
		/// <param name="curHotelCiudadVacio">int that contents the curHotelCiudadVacio value for the Rutas object</param>
		/// <param name="curHotelVacio">decimal that contents the curHotelVacio value for the Rutas object</param>
		/// <param name="intTiempoCargue">decimal that contents the intTiempoCargue value for the Rutas object</param>
		/// <param name="intTiempoDescargue">decimal that contents the intTiempoDescargue value for the Rutas object</param>
		/// <param name="intTiempoAduana">decimal that contents the intTiempoAduana value for the Rutas object</param>
		/// <param name="intTotalTrayecto">decimal that contents the intTotalTrayecto value for the Rutas object</param>
		/// <param name="intTotalTiempo">decimal that contents the intTotalTiempo value for the Rutas object</param>
		/// <param name="curComida">decimal that contents the curComida value for the Rutas object</param>
		/// <param name="intTiempoCargueVacio">decimal that contents the intTiempoCargueVacio value for the Rutas object</param>
		/// <param name="intTiempoDescargueVacio">decimal that contents the intTiempoDescargueVacio value for the Rutas object</param>
		/// <param name="intTiempoAduanaVacio">decimal that contents the intTiempoAduanaVacio value for the Rutas object</param>
		/// <param name="intTotalTrayectoVacio">decimal that contents the intTotalTrayectoVacio value for the Rutas object</param>
		/// <param name="intTotalTiempoVacio">decimal that contents the intTotalTiempoVacio value for the Rutas object</param>
		/// <param name="curComidaVacio">decimal that contents the curComidaVacio value for the Rutas object</param>
		/// <param name="curDesvareManoRepuestos">decimal that contents the curDesvareManoRepuestos value for the Rutas object</param>
		/// <param name="curDesvareManoObra">decimal that contents the curDesvareManoObra value for the Rutas object</param>
		/// <param name="cutSaldo">decimal that contents the cutSaldo value for the Rutas object</param>
		/// <param name="cutSaldoVacio">decimal that contents the cutSaldoVacio value for the Rutas object</param>
		/// <param name="cutKmts">decimal that contents the cutKmts value for the Rutas object</param>
		/// <param name="logActualizaPeajes">decimal that contents the logActualizaPeajes value for the Rutas object</param>
		/// <param name="intFactorKmPorGalon">decimal that contents the intFactorKmPorGalon value for the Rutas object</param>
		/// <param name="logEstadoRuta">bool that contents the logEstadoRuta value for the Rutas object</param>
		/// <param name="ParqueaderoCarretera">decimal that contents the ParqueaderoCarretera value for the Rutas object</param>
		/// <param name="ParqueaderoCiudad">decimal that contents the ParqueaderoCiudad value for the Rutas object</param>
		/// <param name="MontadaLLantaCarretera">decimal that contents the MontadaLLantaCarretera value for the Rutas object</param>
		/// <param name="MontadaLLantaCiudad">decimal that contents the MontadaLLantaCiudad value for the Rutas object</param>
		/// <param name="AjusteCarretera">decimal that contents the AjusteCarretera value for the Rutas object</param>
		/// <param name="Lavada">decimal that contents the Lavada value for the Rutas object</param>
		/// <param name="Amarres">decimal that contents the Amarres value for the Rutas object</param>
		/// <param name="Engradasa">decimal that contents the Engradasa value for the Rutas object</param>
		/// <param name="Calibrada">decimal that contents the Calibrada value for the Rutas object</param>
		/// <param name="Liquidado">bool that contents the Liquidado value for the Rutas object</param>
		/// <param name="logVacio">bool that contents the logVacio value for the Rutas object</param>
		/// <param name="Papeleria">decimal that contents the Papeleria value for the Rutas object</param>
		/// <param name="logFavorito">bool that contents the logFavorito value for the Rutas object</param>
		/// <param name="CurCargue">decimal that contents the CurCargue value for the Rutas object</param>
		/// <param name="CurDescargue">decimal that contents the CurDescargue value for the Rutas object</param>
		/// <param name="LogAnticipoACPM">bool that contents the LogAnticipoACPM value for the Rutas object</param>
		/// <returns>One Rutas object</returns>
		public Rutas Create(int lngIdRegistrRuta, int? RutasOrigenCodigo, string strRutaAnticipoGrupoOrigen, string strRutaAnticipoGrupoDestino, string strRutaAnticipoGrupo, string strRutaAnticipo, int? TipoVehiculoCodigo, string TipoVehiculo, int? TipoTrailerCodigo, int? Peso, string Programa, bool? logViajeVacio, decimal? floGalones, decimal? curValorGalon, decimal? cutCombustible, decimal? CombustibleCarretera, int? lngIdNroPeajes, decimal? cutPeaje, string strNombrePeajes, decimal? cutVariosLlantas, decimal? cutVariosCelada, decimal? cutVariosPropina, decimal? cutVarios, decimal? Llamadas, decimal? Taxi, decimal? Aseo, decimal? cutVariosLlantasVacio, decimal? cutVariosCeladaVacio, decimal? cutVariosPropinaVacio, decimal? cutVariosVacio, decimal? Viaticos, decimal? cutParticipacion, decimal? cutParticipacionVacio, int? curHotelCarretera, int? curHotelCiudad, decimal? curHotel, int? curHotelCarreteraVacio, int? curHotelCiudadVacio, decimal? curHotelVacio, decimal? intTiempoCargue, decimal? intTiempoDescargue, decimal? intTiempoAduana, decimal? intTotalTrayecto, decimal? intTotalTiempo, decimal? curComida, decimal? intTiempoCargueVacio, decimal? intTiempoDescargueVacio, decimal? intTiempoAduanaVacio, decimal? intTotalTrayectoVacio, decimal? intTotalTiempoVacio, decimal? curComidaVacio, decimal? curDesvareManoRepuestos, decimal? curDesvareManoObra, decimal? cutSaldo, decimal? cutSaldoVacio, decimal? cutKmts, decimal? logActualizaPeajes, decimal? intFactorKmPorGalon, bool? logEstadoRuta, decimal? ParqueaderoCarretera, decimal? ParqueaderoCiudad, decimal? MontadaLLantaCarretera, decimal? MontadaLLantaCiudad, decimal? AjusteCarretera, decimal? Lavada, decimal? Amarres, decimal? Engradasa, decimal? Calibrada, bool? Liquidado, bool? logVacio, decimal? Papeleria, bool? logFavorito, decimal? CurCargue, decimal? CurDescargue, bool? LogAnticipoACPM, Sinapsys.Datos.SQL datosTransaccion=null)
		{
			try 
			{
				Rutas rutas = new Rutas();

				rutas.lngIdRegistrRuta = lngIdRegistrRuta;
				rutas.lngIdRegistrRuta = lngIdRegistrRuta;
				rutas.RutasOrigenCodigo = RutasOrigenCodigo;
				rutas.strRutaAnticipoGrupoOrigen = strRutaAnticipoGrupoOrigen;
				rutas.strRutaAnticipoGrupoDestino = strRutaAnticipoGrupoDestino;
				rutas.strRutaAnticipoGrupo = strRutaAnticipoGrupo;
				rutas.strRutaAnticipo = strRutaAnticipo;
				rutas.TipoVehiculoCodigo = TipoVehiculoCodigo;
				rutas.TipoVehiculo = TipoVehiculo;
				rutas.TipoTrailerCodigo = TipoTrailerCodigo;
				rutas.Peso = Peso;
				rutas.Programa = Programa;
				rutas.logViajeVacio = logViajeVacio;
				rutas.floGalones = floGalones;
				rutas.curValorGalon = curValorGalon;
				rutas.cutCombustible = cutCombustible;
				rutas.CombustibleCarretera = CombustibleCarretera;
				rutas.lngIdNroPeajes = lngIdNroPeajes;
				rutas.cutPeaje = cutPeaje;
				rutas.strNombrePeajes = strNombrePeajes;
				rutas.cutVariosLlantas = cutVariosLlantas;
				rutas.cutVariosCelada = cutVariosCelada;
				rutas.cutVariosPropina = cutVariosPropina;
				rutas.cutVarios = cutVarios;
				rutas.Llamadas = Llamadas;
				rutas.Taxi = Taxi;
				rutas.Aseo = Aseo;
				rutas.cutVariosLlantasVacio = cutVariosLlantasVacio;
				rutas.cutVariosCeladaVacio = cutVariosCeladaVacio;
				rutas.cutVariosPropinaVacio = cutVariosPropinaVacio;
				rutas.cutVariosVacio = cutVariosVacio;
				rutas.Viaticos = Viaticos;
				rutas.cutParticipacion = cutParticipacion;
				rutas.cutParticipacionVacio = cutParticipacionVacio;
				rutas.curHotelCarretera = curHotelCarretera;
				rutas.curHotelCiudad = curHotelCiudad;
				rutas.curHotel = curHotel;
				rutas.curHotelCarreteraVacio = curHotelCarreteraVacio;
				rutas.curHotelCiudadVacio = curHotelCiudadVacio;
				rutas.curHotelVacio = curHotelVacio;
				rutas.intTiempoCargue = intTiempoCargue;
				rutas.intTiempoDescargue = intTiempoDescargue;
				rutas.intTiempoAduana = intTiempoAduana;
				rutas.intTotalTrayecto = intTotalTrayecto;
				rutas.intTotalTiempo = intTotalTiempo;
				rutas.curComida = curComida;
				rutas.intTiempoCargueVacio = intTiempoCargueVacio;
				rutas.intTiempoDescargueVacio = intTiempoDescargueVacio;
				rutas.intTiempoAduanaVacio = intTiempoAduanaVacio;
				rutas.intTotalTrayectoVacio = intTotalTrayectoVacio;
				rutas.intTotalTiempoVacio = intTotalTiempoVacio;
				rutas.curComidaVacio = curComidaVacio;
				rutas.curDesvareManoRepuestos = curDesvareManoRepuestos;
				rutas.curDesvareManoObra = curDesvareManoObra;
				rutas.cutSaldo = cutSaldo;
				rutas.cutSaldoVacio = cutSaldoVacio;
				rutas.cutKmts = cutKmts;
				rutas.logActualizaPeajes = logActualizaPeajes;
				rutas.intFactorKmPorGalon = intFactorKmPorGalon;
				rutas.logEstadoRuta = logEstadoRuta;
				rutas.ParqueaderoCarretera = ParqueaderoCarretera;
				rutas.ParqueaderoCiudad = ParqueaderoCiudad;
				rutas.MontadaLLantaCarretera = MontadaLLantaCarretera;
				rutas.MontadaLLantaCiudad = MontadaLLantaCiudad;
				rutas.AjusteCarretera = AjusteCarretera;
				rutas.Lavada = Lavada;
				rutas.Amarres = Amarres;
				rutas.Engradasa = Engradasa;
				rutas.Calibrada = Calibrada;
				rutas.Liquidado = Liquidado;
				rutas.logVacio = logVacio;
				rutas.Papeleria = Papeleria;
				rutas.logFavorito = logFavorito;
				rutas.CurCargue = CurCargue;
				rutas.CurDescargue = CurDescargue;
				rutas.LogAnticipoACPM = LogAnticipoACPM;
				lngIdRegistrRuta = RutasDataProvider.Instance.Create(lngIdRegistrRuta, RutasOrigenCodigo, strRutaAnticipoGrupoOrigen, strRutaAnticipoGrupoDestino, strRutaAnticipoGrupo, strRutaAnticipo, TipoVehiculoCodigo, TipoVehiculo, TipoTrailerCodigo, Peso, Programa, logViajeVacio, floGalones, curValorGalon, cutCombustible, CombustibleCarretera, lngIdNroPeajes, cutPeaje, strNombrePeajes, cutVariosLlantas, cutVariosCelada, cutVariosPropina, cutVarios, Llamadas, Taxi, Aseo, cutVariosLlantasVacio, cutVariosCeladaVacio, cutVariosPropinaVacio, cutVariosVacio, Viaticos, cutParticipacion, cutParticipacionVacio, curHotelCarretera, curHotelCiudad, curHotel, curHotelCarreteraVacio, curHotelCiudadVacio, curHotelVacio, intTiempoCargue, intTiempoDescargue, intTiempoAduana, intTotalTrayecto, intTotalTiempo, curComida, intTiempoCargueVacio, intTiempoDescargueVacio, intTiempoAduanaVacio, intTotalTrayectoVacio, intTotalTiempoVacio, curComidaVacio, curDesvareManoRepuestos, curDesvareManoObra, cutSaldo, cutSaldoVacio, cutKmts, logActualizaPeajes, intFactorKmPorGalon, logEstadoRuta, ParqueaderoCarretera, ParqueaderoCiudad, MontadaLLantaCarretera, MontadaLLantaCiudad, AjusteCarretera, Lavada, Amarres, Engradasa, Calibrada, Liquidado, logVacio, Papeleria, logFavorito, CurCargue, CurDescargue, LogAnticipoACPM,"Rutas",datosTransaccion);
				if (lngIdRegistrRuta == 0)
					return null;

				rutas.lngIdRegistrRuta = lngIdRegistrRuta;

				return rutas;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Updates an Rutas object by passing all object's fields
		/// </summary>
		/// <param name="lngIdRegistrRuta">int that contents the lngIdRegistrRuta value for the Rutas object</param>
		/// <param name="RutasOrigenCodigo">int that contents the RutasOrigenCodigo value for the Rutas object</param>
		/// <param name="strRutaAnticipoGrupoOrigen">string that contents the strRutaAnticipoGrupoOrigen value for the Rutas object</param>
		/// <param name="strRutaAnticipoGrupoDestino">string that contents the strRutaAnticipoGrupoDestino value for the Rutas object</param>
		/// <param name="strRutaAnticipoGrupo">string that contents the strRutaAnticipoGrupo value for the Rutas object</param>
		/// <param name="strRutaAnticipo">string that contents the strRutaAnticipo value for the Rutas object</param>
		/// <param name="TipoVehiculoCodigo">int that contents the TipoVehiculoCodigo value for the Rutas object</param>
		/// <param name="TipoVehiculo">string that contents the TipoVehiculo value for the Rutas object</param>
		/// <param name="TipoTrailerCodigo">int that contents the TipoTrailerCodigo value for the Rutas object</param>
		/// <param name="Peso">int that contents the Peso value for the Rutas object</param>
		/// <param name="Programa">string that contents the Programa value for the Rutas object</param>
		/// <param name="logViajeVacio">bool that contents the logViajeVacio value for the Rutas object</param>
		/// <param name="floGalones">decimal that contents the floGalones value for the Rutas object</param>
		/// <param name="curValorGalon">decimal that contents the curValorGalon value for the Rutas object</param>
		/// <param name="cutCombustible">decimal that contents the cutCombustible value for the Rutas object</param>
		/// <param name="CombustibleCarretera">decimal that contents the CombustibleCarretera value for the Rutas object</param>
		/// <param name="lngIdNroPeajes">int that contents the lngIdNroPeajes value for the Rutas object</param>
		/// <param name="cutPeaje">decimal that contents the cutPeaje value for the Rutas object</param>
		/// <param name="strNombrePeajes">string that contents the strNombrePeajes value for the Rutas object</param>
		/// <param name="cutVariosLlantas">decimal that contents the cutVariosLlantas value for the Rutas object</param>
		/// <param name="cutVariosCelada">decimal that contents the cutVariosCelada value for the Rutas object</param>
		/// <param name="cutVariosPropina">decimal that contents the cutVariosPropina value for the Rutas object</param>
		/// <param name="cutVarios">decimal that contents the cutVarios value for the Rutas object</param>
		/// <param name="Llamadas">decimal that contents the Llamadas value for the Rutas object</param>
		/// <param name="Taxi">decimal that contents the Taxi value for the Rutas object</param>
		/// <param name="Aseo">decimal that contents the Aseo value for the Rutas object</param>
		/// <param name="cutVariosLlantasVacio">decimal that contents the cutVariosLlantasVacio value for the Rutas object</param>
		/// <param name="cutVariosCeladaVacio">decimal that contents the cutVariosCeladaVacio value for the Rutas object</param>
		/// <param name="cutVariosPropinaVacio">decimal that contents the cutVariosPropinaVacio value for the Rutas object</param>
		/// <param name="cutVariosVacio">decimal that contents the cutVariosVacio value for the Rutas object</param>
		/// <param name="Viaticos">decimal that contents the Viaticos value for the Rutas object</param>
		/// <param name="cutParticipacion">decimal that contents the cutParticipacion value for the Rutas object</param>
		/// <param name="cutParticipacionVacio">decimal that contents the cutParticipacionVacio value for the Rutas object</param>
		/// <param name="curHotelCarretera">int that contents the curHotelCarretera value for the Rutas object</param>
		/// <param name="curHotelCiudad">int that contents the curHotelCiudad value for the Rutas object</param>
		/// <param name="curHotel">decimal that contents the curHotel value for the Rutas object</param>
		/// <param name="curHotelCarreteraVacio">int that contents the curHotelCarreteraVacio value for the Rutas object</param>
		/// <param name="curHotelCiudadVacio">int that contents the curHotelCiudadVacio value for the Rutas object</param>
		/// <param name="curHotelVacio">decimal that contents the curHotelVacio value for the Rutas object</param>
		/// <param name="intTiempoCargue">decimal that contents the intTiempoCargue value for the Rutas object</param>
		/// <param name="intTiempoDescargue">decimal that contents the intTiempoDescargue value for the Rutas object</param>
		/// <param name="intTiempoAduana">decimal that contents the intTiempoAduana value for the Rutas object</param>
		/// <param name="intTotalTrayecto">decimal that contents the intTotalTrayecto value for the Rutas object</param>
		/// <param name="intTotalTiempo">decimal that contents the intTotalTiempo value for the Rutas object</param>
		/// <param name="curComida">decimal that contents the curComida value for the Rutas object</param>
		/// <param name="intTiempoCargueVacio">decimal that contents the intTiempoCargueVacio value for the Rutas object</param>
		/// <param name="intTiempoDescargueVacio">decimal that contents the intTiempoDescargueVacio value for the Rutas object</param>
		/// <param name="intTiempoAduanaVacio">decimal that contents the intTiempoAduanaVacio value for the Rutas object</param>
		/// <param name="intTotalTrayectoVacio">decimal that contents the intTotalTrayectoVacio value for the Rutas object</param>
		/// <param name="intTotalTiempoVacio">decimal that contents the intTotalTiempoVacio value for the Rutas object</param>
		/// <param name="curComidaVacio">decimal that contents the curComidaVacio value for the Rutas object</param>
		/// <param name="curDesvareManoRepuestos">decimal that contents the curDesvareManoRepuestos value for the Rutas object</param>
		/// <param name="curDesvareManoObra">decimal that contents the curDesvareManoObra value for the Rutas object</param>
		/// <param name="cutSaldo">decimal that contents the cutSaldo value for the Rutas object</param>
		/// <param name="cutSaldoVacio">decimal that contents the cutSaldoVacio value for the Rutas object</param>
		/// <param name="cutKmts">decimal that contents the cutKmts value for the Rutas object</param>
		/// <param name="logActualizaPeajes">decimal that contents the logActualizaPeajes value for the Rutas object</param>
		/// <param name="intFactorKmPorGalon">decimal that contents the intFactorKmPorGalon value for the Rutas object</param>
		/// <param name="logEstadoRuta">bool that contents the logEstadoRuta value for the Rutas object</param>
		/// <param name="ParqueaderoCarretera">decimal that contents the ParqueaderoCarretera value for the Rutas object</param>
		/// <param name="ParqueaderoCiudad">decimal that contents the ParqueaderoCiudad value for the Rutas object</param>
		/// <param name="MontadaLLantaCarretera">decimal that contents the MontadaLLantaCarretera value for the Rutas object</param>
		/// <param name="MontadaLLantaCiudad">decimal that contents the MontadaLLantaCiudad value for the Rutas object</param>
		/// <param name="AjusteCarretera">decimal that contents the AjusteCarretera value for the Rutas object</param>
		/// <param name="Lavada">decimal that contents the Lavada value for the Rutas object</param>
		/// <param name="Amarres">decimal that contents the Amarres value for the Rutas object</param>
		/// <param name="Engradasa">decimal that contents the Engradasa value for the Rutas object</param>
		/// <param name="Calibrada">decimal that contents the Calibrada value for the Rutas object</param>
		/// <param name="Liquidado">bool that contents the Liquidado value for the Rutas object</param>
		/// <param name="logVacio">bool that contents the logVacio value for the Rutas object</param>
		/// <param name="Papeleria">decimal that contents the Papeleria value for the Rutas object</param>
		/// <param name="logFavorito">bool that contents the logFavorito value for the Rutas object</param>
		/// <param name="CurCargue">decimal that contents the CurCargue value for the Rutas object</param>
		/// <param name="CurDescargue">decimal that contents the CurDescargue value for the Rutas object</param>
		/// <param name="LogAnticipoACPM">bool that contents the LogAnticipoACPM value for the Rutas object</param>
		public void Update(int lngIdRegistrRuta, int? RutasOrigenCodigo, string strRutaAnticipoGrupoOrigen, string strRutaAnticipoGrupoDestino, string strRutaAnticipoGrupo, string strRutaAnticipo, int? TipoVehiculoCodigo, string TipoVehiculo, int? TipoTrailerCodigo, int? Peso, string Programa, bool? logViajeVacio, decimal? floGalones, decimal? curValorGalon, decimal? cutCombustible, decimal? CombustibleCarretera, int? lngIdNroPeajes, decimal? cutPeaje, string strNombrePeajes, decimal? cutVariosLlantas, decimal? cutVariosCelada, decimal? cutVariosPropina, decimal? cutVarios, decimal? Llamadas, decimal? Taxi, decimal? Aseo, decimal? cutVariosLlantasVacio, decimal? cutVariosCeladaVacio, decimal? cutVariosPropinaVacio, decimal? cutVariosVacio, decimal? Viaticos, decimal? cutParticipacion, decimal? cutParticipacionVacio, int? curHotelCarretera, int? curHotelCiudad, decimal? curHotel, int? curHotelCarreteraVacio, int? curHotelCiudadVacio, decimal? curHotelVacio, decimal? intTiempoCargue, decimal? intTiempoDescargue, decimal? intTiempoAduana, decimal? intTotalTrayecto, decimal? intTotalTiempo, decimal? curComida, decimal? intTiempoCargueVacio, decimal? intTiempoDescargueVacio, decimal? intTiempoAduanaVacio, decimal? intTotalTrayectoVacio, decimal? intTotalTiempoVacio, decimal? curComidaVacio, decimal? curDesvareManoRepuestos, decimal? curDesvareManoObra, decimal? cutSaldo, decimal? cutSaldoVacio, decimal? cutKmts, decimal? logActualizaPeajes, decimal? intFactorKmPorGalon, bool? logEstadoRuta, decimal? ParqueaderoCarretera, decimal? ParqueaderoCiudad, decimal? MontadaLLantaCarretera, decimal? MontadaLLantaCiudad, decimal? AjusteCarretera, decimal? Lavada, decimal? Amarres, decimal? Engradasa, decimal? Calibrada, bool? Liquidado, bool? logVacio, decimal? Papeleria, bool? logFavorito, decimal? CurCargue, decimal? CurDescargue, bool? LogAnticipoACPM, Sinapsys.Datos.SQL datosTransaccion=null)
		{
			try 
			{
				Rutas new_values = new Rutas();
				new_values.RutasOrigenCodigo = RutasOrigenCodigo;
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
				new_values.CombustibleCarretera = CombustibleCarretera;
				new_values.lngIdNroPeajes = lngIdNroPeajes;
				new_values.cutPeaje = cutPeaje;
				new_values.strNombrePeajes = strNombrePeajes;
				new_values.cutVariosLlantas = cutVariosLlantas;
				new_values.cutVariosCelada = cutVariosCelada;
				new_values.cutVariosPropina = cutVariosPropina;
				new_values.cutVarios = cutVarios;
				new_values.Llamadas = Llamadas;
				new_values.Taxi = Taxi;
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
				new_values.ParqueaderoCarretera = ParqueaderoCarretera;
				new_values.ParqueaderoCiudad = ParqueaderoCiudad;
				new_values.MontadaLLantaCarretera = MontadaLLantaCarretera;
				new_values.MontadaLLantaCiudad = MontadaLLantaCiudad;
				new_values.AjusteCarretera = AjusteCarretera;
				new_values.Lavada = Lavada;
				new_values.Amarres = Amarres;
				new_values.Engradasa = Engradasa;
				new_values.Calibrada = Calibrada;
				new_values.Liquidado = Liquidado;
				new_values.logVacio = logVacio;
				new_values.Papeleria = Papeleria;
				new_values.logFavorito = logFavorito;
				new_values.CurCargue = CurCargue;
				new_values.CurDescargue = CurDescargue;
				new_values.LogAnticipoACPM = LogAnticipoACPM;
				RutasDataProvider.Instance.Update(lngIdRegistrRuta, RutasOrigenCodigo, strRutaAnticipoGrupoOrigen, strRutaAnticipoGrupoDestino, strRutaAnticipoGrupo, strRutaAnticipo, TipoVehiculoCodigo, TipoVehiculo, TipoTrailerCodigo, Peso, Programa, logViajeVacio, floGalones, curValorGalon, cutCombustible, CombustibleCarretera, lngIdNroPeajes, cutPeaje, strNombrePeajes, cutVariosLlantas, cutVariosCelada, cutVariosPropina, cutVarios, Llamadas, Taxi, Aseo, cutVariosLlantasVacio, cutVariosCeladaVacio, cutVariosPropinaVacio, cutVariosVacio, Viaticos, cutParticipacion, cutParticipacionVacio, curHotelCarretera, curHotelCiudad, curHotel, curHotelCarreteraVacio, curHotelCiudadVacio, curHotelVacio, intTiempoCargue, intTiempoDescargue, intTiempoAduana, intTotalTrayecto, intTotalTiempo, curComida, intTiempoCargueVacio, intTiempoDescargueVacio, intTiempoAduanaVacio, intTotalTrayectoVacio, intTotalTiempoVacio, curComidaVacio, curDesvareManoRepuestos, curDesvareManoObra, cutSaldo, cutSaldoVacio, cutKmts, logActualizaPeajes, intFactorKmPorGalon, logEstadoRuta, ParqueaderoCarretera, ParqueaderoCiudad, MontadaLLantaCarretera, MontadaLLantaCiudad, AjusteCarretera, Lavada, Amarres, Engradasa, Calibrada, Liquidado, logVacio, Papeleria, logFavorito, CurCargue, CurDescargue, LogAnticipoACPM,"Rutas",datosTransaccion);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Updates an Rutas object by passing one object's instance as reference
		/// </summary>
		/// <param name="rutas">An instance of Rutas for reference</param>
		public void Update(Rutas rutas,Sinapsys.Datos.SQL datosTransaccion=null)
		{
			Update(rutas.lngIdRegistrRuta, rutas.RutasOrigenCodigo, rutas.strRutaAnticipoGrupoOrigen, rutas.strRutaAnticipoGrupoDestino, rutas.strRutaAnticipoGrupo, rutas.strRutaAnticipo, rutas.TipoVehiculoCodigo, rutas.TipoVehiculo, rutas.TipoTrailerCodigo, rutas.Peso, rutas.Programa, rutas.logViajeVacio, rutas.floGalones, rutas.curValorGalon, rutas.cutCombustible, rutas.CombustibleCarretera, rutas.lngIdNroPeajes, rutas.cutPeaje, rutas.strNombrePeajes, rutas.cutVariosLlantas, rutas.cutVariosCelada, rutas.cutVariosPropina, rutas.cutVarios, rutas.Llamadas, rutas.Taxi, rutas.Aseo, rutas.cutVariosLlantasVacio, rutas.cutVariosCeladaVacio, rutas.cutVariosPropinaVacio, rutas.cutVariosVacio, rutas.Viaticos, rutas.cutParticipacion, rutas.cutParticipacionVacio, rutas.curHotelCarretera, rutas.curHotelCiudad, rutas.curHotel, rutas.curHotelCarreteraVacio, rutas.curHotelCiudadVacio, rutas.curHotelVacio, rutas.intTiempoCargue, rutas.intTiempoDescargue, rutas.intTiempoAduana, rutas.intTotalTrayecto, rutas.intTotalTiempo, rutas.curComida, rutas.intTiempoCargueVacio, rutas.intTiempoDescargueVacio, rutas.intTiempoAduanaVacio, rutas.intTotalTrayectoVacio, rutas.intTotalTiempoVacio, rutas.curComidaVacio, rutas.curDesvareManoRepuestos, rutas.curDesvareManoObra, rutas.cutSaldo, rutas.cutSaldoVacio, rutas.cutKmts, rutas.logActualizaPeajes, rutas.intFactorKmPorGalon, rutas.logEstadoRuta, rutas.ParqueaderoCarretera, rutas.ParqueaderoCiudad, rutas.MontadaLLantaCarretera, rutas.MontadaLLantaCiudad, rutas.AjusteCarretera, rutas.Lavada, rutas.Amarres, rutas.Engradasa, rutas.Calibrada, rutas.Liquidado, rutas.logVacio, rutas.Papeleria, rutas.logFavorito, rutas.CurCargue, rutas.CurDescargue, rutas.LogAnticipoACPM);
		}

		/// <summary>
		/// Delete  the Rutas object by passing a object
		/// </summary>
		public void  Delete(Rutas rutas, Sinapsys.Datos.SQL datosTransaccion=null)
		{
			Delete(rutas.lngIdRegistrRuta,datosTransaccion);
		}

		/// <summary>
		/// Deletes the Rutas object by passing one object's instance as reference
		/// </summary>
		/// <param name="rutas">An instance of Rutas for reference</param>
		public void Delete(int lngIdRegistrRuta, Sinapsys.Datos.SQL datosTransaccion=null)
		{
			try 
			{
				//Rutas old_values = RutasController.Instance.Get(lngIdRegistrRuta);
				//if(!Validate.security.CanDeleteSecurityField(RutasController.Instance, (ILatinodeObject)old_values))
				//    throw new Exception("Access denied by security field, you can't delete object");

				RutasDataProvider.Instance.Delete(lngIdRegistrRuta,"Rutas");
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Deletes the Rutas object by passing CVS parameter as reference
		/// </summary>
		/// <param name="rutas">An instance of Rutas for reference</param>
		public void Delete(string CVSParameter)
		{
			string[] StrCommand=CVSParameter.Split(',');
			try 
			{
				int lngIdRegistrRuta=int.Parse(StrCommand[0]);
				RutasDataProvider.Instance.Delete(lngIdRegistrRuta,"Rutas");
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Gets the Rutas object by passing the object's key fields
		/// </summary>
		/// <param name="lngIdRegistrRuta">int that contents the lngIdRegistrRuta value for the Rutas object</param>
		/// <returns>One Rutas object</returns>
		public Rutas Get(int lngIdRegistrRuta, bool generateUndo=false)
		{
			try 
			{
				Rutas rutas = null;
				rutas= MasterTables.Rutas.Where(r => r.lngIdRegistrRuta== lngIdRegistrRuta).FirstOrDefault();
				if (rutas== null)
				{
					MasterTables.Reset("Rutas");
					rutas= MasterTables.Rutas.Where(r => r.lngIdRegistrRuta== lngIdRegistrRuta).FirstOrDefault();
				}
				if (generateUndo) rutas.GenerateUndo();

				return rutas;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Gets all objects of Rutas
		/// </summary>
		/// <returns>One RutasList object</returns>
		public RutasList GetAll(bool generateUndo=false)
		{
			try 
			{
				RutasList rutaslist = new RutasList();
				DataTable dt = RutasDataProvider.Instance.GetAll();
				foreach (DataRow dr in dt.Rows)
				{
					Rutas rutas = new Rutas();
					ReadData(rutas, dr, generateUndo);
					rutaslist.Add(rutas);
				}
				return rutaslist;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Selects all Rutas objects by reference (Foreign Keys)
		/// </summary>
		/// <param name="RutasOrigenCodigo">int that contents the RutasOrigenCodigo value for the Rutas object</param>
		/// <returns>One RutasList object</returns>
		public RutasList GetBy_RutasOrigenCodigo(int RutasOrigenCodigo,bool generateUndo=false)
		{
			try 
			{
				RutasList rutaslist = new RutasList();

				DataTable dt = RutasDataProvider.Instance.GetBy_RutasOrigenCodigo(RutasOrigenCodigo);
				foreach (DataRow dr in dt.Rows)
				{
					Rutas rutas = new Rutas();
					ReadData(rutas, dr, generateUndo);
					rutaslist.Add(rutas);
				}
				return rutaslist;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Selects all Rutas objects by reference (Foreign Keys)
		/// </summary>
		/// <param name="TipoTrailerCodigo">int that contents the TipoTrailerCodigo value for the Rutas object</param>
		/// <returns>One RutasList object</returns>
		public RutasList GetBy_TipoTrailerCodigo(int TipoTrailerCodigo,bool generateUndo=false)
		{
			try 
			{
				RutasList rutaslist = new RutasList();

				DataTable dt = RutasDataProvider.Instance.GetBy_TipoTrailerCodigo(TipoTrailerCodigo);
				foreach (DataRow dr in dt.Rows)
				{
					Rutas rutas = new Rutas();
					ReadData(rutas, dr, generateUndo);
					rutaslist.Add(rutas);
				}
				return rutaslist;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Selects all Rutas objects by reference (Foreign Keys)
		/// </summary>
		/// <param name="TipoVehiculoCodigo">int that contents the TipoVehiculoCodigo value for the Rutas object</param>
		/// <returns>One RutasList object</returns>
		public RutasList GetBy_TipoVehiculoCodigo(int TipoVehiculoCodigo,bool generateUndo=false)
		{
			try 
			{
				RutasList rutaslist = new RutasList();

				DataTable dt = RutasDataProvider.Instance.GetBy_TipoVehiculoCodigo(TipoVehiculoCodigo);
				foreach (DataRow dr in dt.Rows)
				{
					Rutas rutas = new Rutas();
					ReadData(rutas, dr, generateUndo);
					rutaslist.Add(rutas);
				}
				return rutaslist;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Gets all objects of Rutas applying filter and sort criteria
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
		/// <returns>One RutasList object</returns>
		public RutasList GetFilter(int pagenum, int pagesize, string filter, string sort, string extablesfilter, string extablesfieldsfilter, string extablesrelationsfilter, string extablessort, string extablesfieldssort, string extablesrelationssort, bool generateUndo=false)
		{
			try 
			{
				RutasList rutaslist = new RutasList();

				DataTable dt = RutasDataProvider.Instance.GetFilter(pagenum, pagesize, filter, sort, extablesfilter, extablesfieldsfilter, extablesrelationsfilter, extablessort, extablesfieldssort, extablesrelationssort);

				foreach (DataRow dr in dt.Rows)
				{
					Rutas rutas = new Rutas();
					ReadData(rutas, dr, generateUndo);
					rutaslist.Add(rutas);
				}
				return rutaslist;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public RutasList GetFilter( string filter, string sort, bool generateUndo=false)
		{
			return GetFilter(0,0, filter, sort, "","","","","","",generateUndo);
		}

		public RutasList GetFilter(string filter, string sort, string extablesfilter, string extablesfieldsfilter, string extablesrelationsfilter, string extablessort, string extablesfieldssort, string extablesrelationssort, bool generateUndo=false)
		{
			return GetFilter(0,0, filter, sort, extablesfilter, extablesfieldsfilter, extablesrelationsfilter, extablessort, extablesfieldssort, extablesrelationssort,generateUndo);
		}


		/// <summary>
		/// Returns the type for one property
		/// </summary>
		/// <param name="propertyname">Property's name for return its value</param>
		/// <returns>A value for the <paramref name="propertyname"/></returns>
		public Type GetMethodType( string propertyname,Rutas rutas)
		{
			// Perform the search for the property's value
			switch (propertyname)
			{
				case "lngIdRegistrRuta":
					return rutas.lngIdRegistrRuta.GetType();

				case "RutasOrigenCodigo":
					return rutas.RutasOrigenCodigo.GetType();

				case "strRutaAnticipoGrupoOrigen":
					return rutas.strRutaAnticipoGrupoOrigen.GetType();

				case "strRutaAnticipoGrupoDestino":
					return rutas.strRutaAnticipoGrupoDestino.GetType();

				case "strRutaAnticipoGrupo":
					return rutas.strRutaAnticipoGrupo.GetType();

				case "strRutaAnticipo":
					return rutas.strRutaAnticipo.GetType();

				case "TipoVehiculoCodigo":
					return rutas.TipoVehiculoCodigo.GetType();

				case "TipoVehiculo":
					return rutas.TipoVehiculo.GetType();

				case "TipoTrailerCodigo":
					return rutas.TipoTrailerCodigo.GetType();

				case "Peso":
					return rutas.Peso.GetType();

				case "Programa":
					return rutas.Programa.GetType();

				case "logViajeVacio":
					return rutas.logViajeVacio.GetType();

				case "floGalones":
					return rutas.floGalones.GetType();

				case "curValorGalon":
					return rutas.curValorGalon.GetType();

				case "cutCombustible":
					return rutas.cutCombustible.GetType();

				case "CombustibleCarretera":
					return rutas.CombustibleCarretera.GetType();

				case "lngIdNroPeajes":
					return rutas.lngIdNroPeajes.GetType();

				case "cutPeaje":
					return rutas.cutPeaje.GetType();

				case "strNombrePeajes":
					return rutas.strNombrePeajes.GetType();

				case "cutVariosLlantas":
					return rutas.cutVariosLlantas.GetType();

				case "cutVariosCelada":
					return rutas.cutVariosCelada.GetType();

				case "cutVariosPropina":
					return rutas.cutVariosPropina.GetType();

				case "cutVarios":
					return rutas.cutVarios.GetType();

				case "Llamadas":
					return rutas.Llamadas.GetType();

				case "Taxi":
					return rutas.Taxi.GetType();

				case "Aseo":
					return rutas.Aseo.GetType();

				case "cutVariosLlantasVacio":
					return rutas.cutVariosLlantasVacio.GetType();

				case "cutVariosCeladaVacio":
					return rutas.cutVariosCeladaVacio.GetType();

				case "cutVariosPropinaVacio":
					return rutas.cutVariosPropinaVacio.GetType();

				case "cutVariosVacio":
					return rutas.cutVariosVacio.GetType();

				case "Viaticos":
					return rutas.Viaticos.GetType();

				case "cutParticipacion":
					return rutas.cutParticipacion.GetType();

				case "cutParticipacionVacio":
					return rutas.cutParticipacionVacio.GetType();

				case "curHotelCarretera":
					return rutas.curHotelCarretera.GetType();

				case "curHotelCiudad":
					return rutas.curHotelCiudad.GetType();

				case "curHotel":
					return rutas.curHotel.GetType();

				case "curHotelCarreteraVacio":
					return rutas.curHotelCarreteraVacio.GetType();

				case "curHotelCiudadVacio":
					return rutas.curHotelCiudadVacio.GetType();

				case "curHotelVacio":
					return rutas.curHotelVacio.GetType();

				case "intTiempoCargue":
					return rutas.intTiempoCargue.GetType();

				case "intTiempoDescargue":
					return rutas.intTiempoDescargue.GetType();

				case "intTiempoAduana":
					return rutas.intTiempoAduana.GetType();

				case "intTotalTrayecto":
					return rutas.intTotalTrayecto.GetType();

				case "intTotalTiempo":
					return rutas.intTotalTiempo.GetType();

				case "curComida":
					return rutas.curComida.GetType();

				case "intTiempoCargueVacio":
					return rutas.intTiempoCargueVacio.GetType();

				case "intTiempoDescargueVacio":
					return rutas.intTiempoDescargueVacio.GetType();

				case "intTiempoAduanaVacio":
					return rutas.intTiempoAduanaVacio.GetType();

				case "intTotalTrayectoVacio":
					return rutas.intTotalTrayectoVacio.GetType();

				case "intTotalTiempoVacio":
					return rutas.intTotalTiempoVacio.GetType();

				case "curComidaVacio":
					return rutas.curComidaVacio.GetType();

				case "curDesvareManoRepuestos":
					return rutas.curDesvareManoRepuestos.GetType();

				case "curDesvareManoObra":
					return rutas.curDesvareManoObra.GetType();

				case "cutSaldo":
					return rutas.cutSaldo.GetType();

				case "cutSaldoVacio":
					return rutas.cutSaldoVacio.GetType();

				case "cutKmts":
					return rutas.cutKmts.GetType();

				case "logActualizaPeajes":
					return rutas.logActualizaPeajes.GetType();

				case "intFactorKmPorGalon":
					return rutas.intFactorKmPorGalon.GetType();

				case "logEstadoRuta":
					return rutas.logEstadoRuta.GetType();

				case "ParqueaderoCarretera":
					return rutas.ParqueaderoCarretera.GetType();

				case "ParqueaderoCiudad":
					return rutas.ParqueaderoCiudad.GetType();

				case "MontadaLLantaCarretera":
					return rutas.MontadaLLantaCarretera.GetType();

				case "MontadaLLantaCiudad":
					return rutas.MontadaLLantaCiudad.GetType();

				case "AjusteCarretera":
					return rutas.AjusteCarretera.GetType();

				case "Lavada":
					return rutas.Lavada.GetType();

				case "Amarres":
					return rutas.Amarres.GetType();

				case "Engradasa":
					return rutas.Engradasa.GetType();

				case "Calibrada":
					return rutas.Calibrada.GetType();

				case "Liquidado":
					return rutas.Liquidado.GetType();

				case "logVacio":
					return rutas.logVacio.GetType();

				case "Papeleria":
					return rutas.Papeleria.GetType();

				case "logFavorito":
					return rutas.logFavorito.GetType();

				case "CurCargue":
					return rutas.CurCargue.GetType();

				case "CurDescargue":
					return rutas.CurDescargue.GetType();

				case "LogAnticipoACPM":
					return rutas.LogAnticipoACPM.GetType();

			}

			return null;
		}
		/// <summary>
		/// update the changes in Rutas object by passing the object
		/// </summary>
		public bool UpdateChanges(Rutas rutas, out string error,Sinapsys.Datos.SQL datosTransaccion=null)
		{
			if (rutas.OldRutas == null)
			{
				    error = "No tiene objeto con el cual comparar";
				    return false;
			}
			string[] Fields = rutas.FieldChanged();
			error = "";
			return LiqViajes_Bll_Data.DataProvider.UpdateFieldsbyObject(Fields, rutas, out error,datosTransaccion);
		}
	}

	#endregion

}
