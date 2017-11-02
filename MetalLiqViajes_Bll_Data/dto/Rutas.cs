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
using Microsoft.Practices.EnterpriseLibrary.Security.Cryptography;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Runtime.Serialization;

namespace LiqViajes_Bll_Data
{
	#region Rutas object

	[DataContract]
	public partial class Rutas : IDTOObject
	{
		/// <summary>
		/// Default constructor
		/// </summary>
		public Rutas()
		{
			m_lngIdRegistrRuta = 0;
			m_strRutaAnticipoGrupoOrigen = null;
			m_strRutaAnticipoGrupoDestino = null;
			m_strRutaAnticipoGrupo = null;
			m_strRutaAnticipo = null;
			m_TipoVehiculoCodigo = null;
			m_TipoVehiculo = null;
			m_TipoTrailerCodigo = null;
			m_Peso = null;
			m_Programa = null;
			m_logViajeVacio = false;
			m_floGalones = null;
			m_curValorGalon = null;
			m_cutCombustible = null;
			m_CombustibleCarretera = null;
			m_lngIdNroPeajes = null;
			m_cutPeaje = null;
			m_strNombrePeajes = null;
			m_cutVariosLlantas = null;
			m_cutVariosCelada = null;
			m_cutVariosPropina = null;
			m_cutVarios = null;
			m_Llamadas = null;
			m_Taxi = null;
			m_Aseo = null;
			m_cutVariosLlantasVacio = null;
			m_cutVariosCeladaVacio = null;
			m_cutVariosPropinaVacio = null;
			m_cutVariosVacio = null;
			m_Viaticos = null;
			m_cutParticipacion = null;
			m_cutParticipacionVacio = null;
			m_curHotelCarretera = null;
			m_curHotelCiudad = null;
			m_curHotel = null;
			m_curHotelCarreteraVacio = null;
			m_curHotelCiudadVacio = null;
			m_curHotelVacio = null;
			m_intTiempoCargue = null;
			m_intTiempoDescargue = null;
			m_intTiempoAduana = null;
			m_intTotalTrayecto = null;
			m_intTotalTiempo = null;
			m_curComida = null;
			m_intTiempoCargueVacio = null;
			m_intTiempoDescargueVacio = null;
			m_intTiempoAduanaVacio = null;
			m_intTotalTrayectoVacio = null;
			m_intTotalTiempoVacio = null;
			m_curComidaVacio = null;
			m_curDesvareManoRepuestos = null;
			m_curDesvareManoObra = null;
			m_cutSaldo = null;
			m_cutSaldoVacio = null;
			m_cutKmts = null;
			m_logActualizaPeajes = null;
			m_intFactorKmPorGalon = null;
			m_logEstadoRuta = false;
			m_ParqueaderoCarretera = null;
			m_ParqueaderoCiudad = null;
			m_MontadaLLantaCarretera = null;
			m_MontadaLLantaCiudad = null;
			m_AjusteCarretera = null;
			m_Lavada = null;
			m_Amarres = null;
			m_Engradasa = null;
			m_Calibrada = null;
			m_Liquidado = false;
			m_logVacio = false;
			m_Papeleria = null;
			m_logFavorito = false;
			m_CurCargue = null;
			m_CurDescargue = null;
			m_LogAnticipoACPM = false;
			m_changed=false;
		}
		        //Return the table name of object
		        public string TableName()
		        {
		            return "tblRutas";
		        }
		#region Undo 
		// Internal class for storing changes
		private Rutas m_oldRutas;
		public void GenerateUndo()
		{
			m_oldRutas=new Rutas();
			m_oldRutas.m_lngIdRegistrRuta = m_lngIdRegistrRuta;
			m_oldRutas.strRutaAnticipoGrupoOrigen = m_strRutaAnticipoGrupoOrigen;
			m_oldRutas.strRutaAnticipoGrupoDestino = m_strRutaAnticipoGrupoDestino;
			m_oldRutas.strRutaAnticipoGrupo = m_strRutaAnticipoGrupo;
			m_oldRutas.strRutaAnticipo = m_strRutaAnticipo;
			m_oldRutas.TipoVehiculoCodigo = m_TipoVehiculoCodigo;
			m_oldRutas.TipoVehiculo = m_TipoVehiculo;
			m_oldRutas.TipoTrailerCodigo = m_TipoTrailerCodigo;
			m_oldRutas.Peso = m_Peso;
			m_oldRutas.Programa = m_Programa;
			m_oldRutas.logViajeVacio = m_logViajeVacio;
			m_oldRutas.floGalones = m_floGalones;
			m_oldRutas.curValorGalon = m_curValorGalon;
			m_oldRutas.cutCombustible = m_cutCombustible;
			m_oldRutas.CombustibleCarretera = m_CombustibleCarretera;
			m_oldRutas.lngIdNroPeajes = m_lngIdNroPeajes;
			m_oldRutas.cutPeaje = m_cutPeaje;
			m_oldRutas.strNombrePeajes = m_strNombrePeajes;
			m_oldRutas.cutVariosLlantas = m_cutVariosLlantas;
			m_oldRutas.cutVariosCelada = m_cutVariosCelada;
			m_oldRutas.cutVariosPropina = m_cutVariosPropina;
			m_oldRutas.cutVarios = m_cutVarios;
			m_oldRutas.Llamadas = m_Llamadas;
			m_oldRutas.Taxi = m_Taxi;
			m_oldRutas.Aseo = m_Aseo;
			m_oldRutas.cutVariosLlantasVacio = m_cutVariosLlantasVacio;
			m_oldRutas.cutVariosCeladaVacio = m_cutVariosCeladaVacio;
			m_oldRutas.cutVariosPropinaVacio = m_cutVariosPropinaVacio;
			m_oldRutas.cutVariosVacio = m_cutVariosVacio;
			m_oldRutas.Viaticos = m_Viaticos;
			m_oldRutas.cutParticipacion = m_cutParticipacion;
			m_oldRutas.cutParticipacionVacio = m_cutParticipacionVacio;
			m_oldRutas.curHotelCarretera = m_curHotelCarretera;
			m_oldRutas.curHotelCiudad = m_curHotelCiudad;
			m_oldRutas.curHotel = m_curHotel;
			m_oldRutas.curHotelCarreteraVacio = m_curHotelCarreteraVacio;
			m_oldRutas.curHotelCiudadVacio = m_curHotelCiudadVacio;
			m_oldRutas.curHotelVacio = m_curHotelVacio;
			m_oldRutas.intTiempoCargue = m_intTiempoCargue;
			m_oldRutas.intTiempoDescargue = m_intTiempoDescargue;
			m_oldRutas.intTiempoAduana = m_intTiempoAduana;
			m_oldRutas.intTotalTrayecto = m_intTotalTrayecto;
			m_oldRutas.intTotalTiempo = m_intTotalTiempo;
			m_oldRutas.curComida = m_curComida;
			m_oldRutas.intTiempoCargueVacio = m_intTiempoCargueVacio;
			m_oldRutas.intTiempoDescargueVacio = m_intTiempoDescargueVacio;
			m_oldRutas.intTiempoAduanaVacio = m_intTiempoAduanaVacio;
			m_oldRutas.intTotalTrayectoVacio = m_intTotalTrayectoVacio;
			m_oldRutas.intTotalTiempoVacio = m_intTotalTiempoVacio;
			m_oldRutas.curComidaVacio = m_curComidaVacio;
			m_oldRutas.curDesvareManoRepuestos = m_curDesvareManoRepuestos;
			m_oldRutas.curDesvareManoObra = m_curDesvareManoObra;
			m_oldRutas.cutSaldo = m_cutSaldo;
			m_oldRutas.cutSaldoVacio = m_cutSaldoVacio;
			m_oldRutas.cutKmts = m_cutKmts;
			m_oldRutas.logActualizaPeajes = m_logActualizaPeajes;
			m_oldRutas.intFactorKmPorGalon = m_intFactorKmPorGalon;
			m_oldRutas.logEstadoRuta = m_logEstadoRuta;
			m_oldRutas.ParqueaderoCarretera = m_ParqueaderoCarretera;
			m_oldRutas.ParqueaderoCiudad = m_ParqueaderoCiudad;
			m_oldRutas.MontadaLLantaCarretera = m_MontadaLLantaCarretera;
			m_oldRutas.MontadaLLantaCiudad = m_MontadaLLantaCiudad;
			m_oldRutas.AjusteCarretera = m_AjusteCarretera;
			m_oldRutas.Lavada = m_Lavada;
			m_oldRutas.Amarres = m_Amarres;
			m_oldRutas.Engradasa = m_Engradasa;
			m_oldRutas.Calibrada = m_Calibrada;
			m_oldRutas.Liquidado = m_Liquidado;
			m_oldRutas.logVacio = m_logVacio;
			m_oldRutas.Papeleria = m_Papeleria;
			m_oldRutas.logFavorito = m_logFavorito;
			m_oldRutas.CurCargue = m_CurCargue;
			m_oldRutas.CurDescargue = m_CurDescargue;
			m_oldRutas.LogAnticipoACPM = m_LogAnticipoACPM;
		}

		public Rutas OldRutas
		{
			get { return m_oldRutas;}
		}
		// Return the changed fields
		public string[] FieldChanged()
		{
			List<string> fields=new List<string>();
			if (m_oldRutas.strRutaAnticipoGrupoOrigen != m_strRutaAnticipoGrupoOrigen) fields.Add("strRutaAnticipoGrupoOrigen");
			if (m_oldRutas.strRutaAnticipoGrupoDestino != m_strRutaAnticipoGrupoDestino) fields.Add("strRutaAnticipoGrupoDestino");
			if (m_oldRutas.strRutaAnticipoGrupo != m_strRutaAnticipoGrupo) fields.Add("strRutaAnticipoGrupo");
			if (m_oldRutas.strRutaAnticipo != m_strRutaAnticipo) fields.Add("strRutaAnticipo");
			if (m_oldRutas.TipoVehiculoCodigo != m_TipoVehiculoCodigo) fields.Add("TipoVehiculoCodigo");
			if (m_oldRutas.TipoVehiculo != m_TipoVehiculo) fields.Add("TipoVehiculo");
			if (m_oldRutas.TipoTrailerCodigo != m_TipoTrailerCodigo) fields.Add("TipoTrailerCodigo");
			if (m_oldRutas.Peso != m_Peso) fields.Add("Peso");
			if (m_oldRutas.Programa != m_Programa) fields.Add("Programa");
			if (m_oldRutas.logViajeVacio != m_logViajeVacio) fields.Add("logViajeVacio");
			if (m_oldRutas.floGalones != m_floGalones) fields.Add("floGalones");
			if (m_oldRutas.curValorGalon != m_curValorGalon) fields.Add("curValorGalon");
			if (m_oldRutas.cutCombustible != m_cutCombustible) fields.Add("cutCombustible");
			if (m_oldRutas.CombustibleCarretera != m_CombustibleCarretera) fields.Add("CombustibleCarretera");
			if (m_oldRutas.lngIdNroPeajes != m_lngIdNroPeajes) fields.Add("lngIdNroPeajes");
			if (m_oldRutas.cutPeaje != m_cutPeaje) fields.Add("cutPeaje");
			if (m_oldRutas.strNombrePeajes != m_strNombrePeajes) fields.Add("strNombrePeajes");
			if (m_oldRutas.cutVariosLlantas != m_cutVariosLlantas) fields.Add("cutVariosLlantas");
			if (m_oldRutas.cutVariosCelada != m_cutVariosCelada) fields.Add("cutVariosCelada");
			if (m_oldRutas.cutVariosPropina != m_cutVariosPropina) fields.Add("cutVariosPropina");
			if (m_oldRutas.cutVarios != m_cutVarios) fields.Add("cutVarios");
			if (m_oldRutas.Llamadas != m_Llamadas) fields.Add("Llamadas");
			if (m_oldRutas.Taxi != m_Taxi) fields.Add("Taxi");
			if (m_oldRutas.Aseo != m_Aseo) fields.Add("Aseo");
			if (m_oldRutas.cutVariosLlantasVacio != m_cutVariosLlantasVacio) fields.Add("cutVariosLlantasVacio");
			if (m_oldRutas.cutVariosCeladaVacio != m_cutVariosCeladaVacio) fields.Add("cutVariosCeladaVacio");
			if (m_oldRutas.cutVariosPropinaVacio != m_cutVariosPropinaVacio) fields.Add("cutVariosPropinaVacio");
			if (m_oldRutas.cutVariosVacio != m_cutVariosVacio) fields.Add("cutVariosVacio");
			if (m_oldRutas.Viaticos != m_Viaticos) fields.Add("Viaticos");
			if (m_oldRutas.cutParticipacion != m_cutParticipacion) fields.Add("cutParticipacion");
			if (m_oldRutas.cutParticipacionVacio != m_cutParticipacionVacio) fields.Add("cutParticipacionVacio");
			if (m_oldRutas.curHotelCarretera != m_curHotelCarretera) fields.Add("curHotelCarretera");
			if (m_oldRutas.curHotelCiudad != m_curHotelCiudad) fields.Add("curHotelCiudad");
			if (m_oldRutas.curHotel != m_curHotel) fields.Add("curHotel");
			if (m_oldRutas.curHotelCarreteraVacio != m_curHotelCarreteraVacio) fields.Add("curHotelCarreteraVacio");
			if (m_oldRutas.curHotelCiudadVacio != m_curHotelCiudadVacio) fields.Add("curHotelCiudadVacio");
			if (m_oldRutas.curHotelVacio != m_curHotelVacio) fields.Add("curHotelVacio");
			if (m_oldRutas.intTiempoCargue != m_intTiempoCargue) fields.Add("intTiempoCargue");
			if (m_oldRutas.intTiempoDescargue != m_intTiempoDescargue) fields.Add("intTiempoDescargue");
			if (m_oldRutas.intTiempoAduana != m_intTiempoAduana) fields.Add("intTiempoAduana");
			if (m_oldRutas.intTotalTrayecto != m_intTotalTrayecto) fields.Add("intTotalTrayecto");
			if (m_oldRutas.intTotalTiempo != m_intTotalTiempo) fields.Add("intTotalTiempo");
			if (m_oldRutas.curComida != m_curComida) fields.Add("curComida");
			if (m_oldRutas.intTiempoCargueVacio != m_intTiempoCargueVacio) fields.Add("intTiempoCargueVacio");
			if (m_oldRutas.intTiempoDescargueVacio != m_intTiempoDescargueVacio) fields.Add("intTiempoDescargueVacio");
			if (m_oldRutas.intTiempoAduanaVacio != m_intTiempoAduanaVacio) fields.Add("intTiempoAduanaVacio");
			if (m_oldRutas.intTotalTrayectoVacio != m_intTotalTrayectoVacio) fields.Add("intTotalTrayectoVacio");
			if (m_oldRutas.intTotalTiempoVacio != m_intTotalTiempoVacio) fields.Add("intTotalTiempoVacio");
			if (m_oldRutas.curComidaVacio != m_curComidaVacio) fields.Add("curComidaVacio");
			if (m_oldRutas.curDesvareManoRepuestos != m_curDesvareManoRepuestos) fields.Add("curDesvareManoRepuestos");
			if (m_oldRutas.curDesvareManoObra != m_curDesvareManoObra) fields.Add("curDesvareManoObra");
			if (m_oldRutas.cutSaldo != m_cutSaldo) fields.Add("cutSaldo");
			if (m_oldRutas.cutSaldoVacio != m_cutSaldoVacio) fields.Add("cutSaldoVacio");
			if (m_oldRutas.cutKmts != m_cutKmts) fields.Add("cutKmts");
			if (m_oldRutas.logActualizaPeajes != m_logActualizaPeajes) fields.Add("logActualizaPeajes");
			if (m_oldRutas.intFactorKmPorGalon != m_intFactorKmPorGalon) fields.Add("intFactorKmPorGalon");
			if (m_oldRutas.logEstadoRuta != m_logEstadoRuta) fields.Add("logEstadoRuta");
			if (m_oldRutas.ParqueaderoCarretera != m_ParqueaderoCarretera) fields.Add("ParqueaderoCarretera");
			if (m_oldRutas.ParqueaderoCiudad != m_ParqueaderoCiudad) fields.Add("ParqueaderoCiudad");
			if (m_oldRutas.MontadaLLantaCarretera != m_MontadaLLantaCarretera) fields.Add("MontadaLLantaCarretera");
			if (m_oldRutas.MontadaLLantaCiudad != m_MontadaLLantaCiudad) fields.Add("MontadaLLantaCiudad");
			if (m_oldRutas.AjusteCarretera != m_AjusteCarretera) fields.Add("AjusteCarretera");
			if (m_oldRutas.Lavada != m_Lavada) fields.Add("Lavada");
			if (m_oldRutas.Amarres != m_Amarres) fields.Add("Amarres");
			if (m_oldRutas.Engradasa != m_Engradasa) fields.Add("Engradasa");
			if (m_oldRutas.Calibrada != m_Calibrada) fields.Add("Calibrada");
			if (m_oldRutas.Liquidado != m_Liquidado) fields.Add("Liquidado");
			if (m_oldRutas.logVacio != m_logVacio) fields.Add("logVacio");
			if (m_oldRutas.Papeleria != m_Papeleria) fields.Add("Papeleria");
			if (m_oldRutas.logFavorito != m_logFavorito) fields.Add("logFavorito");
			if (m_oldRutas.CurCargue != m_CurCargue) fields.Add("CurCargue");
			if (m_oldRutas.CurDescargue != m_CurDescargue) fields.Add("CurDescargue");
			if (m_oldRutas.LogAnticipoACPM != m_LogAnticipoACPM) fields.Add("LogAnticipoACPM");
			string[] fieldst = new string[fields.Count];
			int i = 0;
			foreach(string st in fields)
			{
				fieldst[i]=st;
				i++;
			}
			return fieldst;
		}
		#endregion
		#region Fields


		// Field for storing the Rutas's lngIdRegistrRuta value
		private int m_lngIdRegistrRuta;

		// Field for storing the Rutas's strRutaAnticipoGrupoOrigen value
		private string m_strRutaAnticipoGrupoOrigen;

		// Field for storing the Rutas's strRutaAnticipoGrupoDestino value
		private string m_strRutaAnticipoGrupoDestino;

		// Field for storing the Rutas's strRutaAnticipoGrupo value
		private string m_strRutaAnticipoGrupo;

		// Field for storing the Rutas's strRutaAnticipo value
		private string m_strRutaAnticipo;

		// Field for storing the Rutas's TipoVehiculoCodigo value
		private int? m_TipoVehiculoCodigo;

		// Field for storing the Rutas's TipoVehiculo value
		private string m_TipoVehiculo;

		// Field for storing the Rutas's TipoTrailerCodigo value
		private int? m_TipoTrailerCodigo;

		// Field for storing the Rutas's Peso value
		private int? m_Peso;

		// Field for storing the Rutas's Programa value
		private string m_Programa;

		// Field for storing the Rutas's logViajeVacio value
		private bool? m_logViajeVacio;

		// Field for storing the Rutas's floGalones value
		private decimal? m_floGalones;

		// Field for storing the Rutas's curValorGalon value
		private decimal? m_curValorGalon;

		// Field for storing the Rutas's cutCombustible value
		private decimal? m_cutCombustible;

		// Field for storing the Rutas's CombustibleCarretera value
		private decimal? m_CombustibleCarretera;

		// Field for storing the Rutas's lngIdNroPeajes value
		private int? m_lngIdNroPeajes;

		// Field for storing the Rutas's cutPeaje value
		private decimal? m_cutPeaje;

		// Field for storing the Rutas's strNombrePeajes value
		private string m_strNombrePeajes;

		// Field for storing the Rutas's cutVariosLlantas value
		private decimal? m_cutVariosLlantas;

		// Field for storing the Rutas's cutVariosCelada value
		private decimal? m_cutVariosCelada;

		// Field for storing the Rutas's cutVariosPropina value
		private decimal? m_cutVariosPropina;

		// Field for storing the Rutas's cutVarios value
		private decimal? m_cutVarios;

		// Field for storing the Rutas's Llamadas value
		private decimal? m_Llamadas;

		// Field for storing the Rutas's Taxi value
		private decimal? m_Taxi;

		// Field for storing the Rutas's Aseo value
		private decimal? m_Aseo;

		// Field for storing the Rutas's cutVariosLlantasVacio value
		private decimal? m_cutVariosLlantasVacio;

		// Field for storing the Rutas's cutVariosCeladaVacio value
		private decimal? m_cutVariosCeladaVacio;

		// Field for storing the Rutas's cutVariosPropinaVacio value
		private decimal? m_cutVariosPropinaVacio;

		// Field for storing the Rutas's cutVariosVacio value
		private decimal? m_cutVariosVacio;

		// Field for storing the Rutas's Viaticos value
		private decimal? m_Viaticos;

		// Field for storing the Rutas's cutParticipacion value
		private decimal? m_cutParticipacion;

		// Field for storing the Rutas's cutParticipacionVacio value
		private decimal? m_cutParticipacionVacio;

		// Field for storing the Rutas's curHotelCarretera value
		private int? m_curHotelCarretera;

		// Field for storing the Rutas's curHotelCiudad value
		private int? m_curHotelCiudad;

		// Field for storing the Rutas's curHotel value
		private decimal? m_curHotel;

		// Field for storing the Rutas's curHotelCarreteraVacio value
		private int? m_curHotelCarreteraVacio;

		// Field for storing the Rutas's curHotelCiudadVacio value
		private int? m_curHotelCiudadVacio;

		// Field for storing the Rutas's curHotelVacio value
		private decimal? m_curHotelVacio;

		// Field for storing the Rutas's intTiempoCargue value
		private decimal? m_intTiempoCargue;

		// Field for storing the Rutas's intTiempoDescargue value
		private decimal? m_intTiempoDescargue;

		// Field for storing the Rutas's intTiempoAduana value
		private decimal? m_intTiempoAduana;

		// Field for storing the Rutas's intTotalTrayecto value
		private decimal? m_intTotalTrayecto;

		// Field for storing the Rutas's intTotalTiempo value
		private decimal? m_intTotalTiempo;

		// Field for storing the Rutas's curComida value
		private decimal? m_curComida;

		// Field for storing the Rutas's intTiempoCargueVacio value
		private decimal? m_intTiempoCargueVacio;

		// Field for storing the Rutas's intTiempoDescargueVacio value
		private decimal? m_intTiempoDescargueVacio;

		// Field for storing the Rutas's intTiempoAduanaVacio value
		private decimal? m_intTiempoAduanaVacio;

		// Field for storing the Rutas's intTotalTrayectoVacio value
		private decimal? m_intTotalTrayectoVacio;

		// Field for storing the Rutas's intTotalTiempoVacio value
		private decimal? m_intTotalTiempoVacio;

		// Field for storing the Rutas's curComidaVacio value
		private decimal? m_curComidaVacio;

		// Field for storing the Rutas's curDesvareManoRepuestos value
		private decimal? m_curDesvareManoRepuestos;

		// Field for storing the Rutas's curDesvareManoObra value
		private decimal? m_curDesvareManoObra;

		// Field for storing the Rutas's cutSaldo value
		private decimal? m_cutSaldo;

		// Field for storing the Rutas's cutSaldoVacio value
		private decimal? m_cutSaldoVacio;

		// Field for storing the Rutas's cutKmts value
		private decimal? m_cutKmts;

		// Field for storing the Rutas's logActualizaPeajes value
		private decimal? m_logActualizaPeajes;

		// Field for storing the Rutas's intFactorKmPorGalon value
		private decimal? m_intFactorKmPorGalon;

		// Field for storing the Rutas's logEstadoRuta value
		private bool? m_logEstadoRuta;

		// Field for storing the Rutas's ParqueaderoCarretera value
		private decimal? m_ParqueaderoCarretera;

		// Field for storing the Rutas's ParqueaderoCiudad value
		private decimal? m_ParqueaderoCiudad;

		// Field for storing the Rutas's MontadaLLantaCarretera value
		private decimal? m_MontadaLLantaCarretera;

		// Field for storing the Rutas's MontadaLLantaCiudad value
		private decimal? m_MontadaLLantaCiudad;

		// Field for storing the Rutas's AjusteCarretera value
		private decimal? m_AjusteCarretera;

		// Field for storing the Rutas's Lavada value
		private decimal? m_Lavada;

		// Field for storing the Rutas's Amarres value
		private decimal? m_Amarres;

		// Field for storing the Rutas's Engradasa value
		private decimal? m_Engradasa;

		// Field for storing the Rutas's Calibrada value
		private decimal? m_Calibrada;

		// Field for storing the Rutas's Liquidado value
		private bool? m_Liquidado;

		// Field for storing the Rutas's logVacio value
		private bool? m_logVacio;

		// Field for storing the Rutas's Papeleria value
		private decimal? m_Papeleria;

		// Field for storing the Rutas's logFavorito value
		private bool? m_logFavorito;

		// Field for storing the Rutas's CurCargue value
		private decimal? m_CurCargue;

		// Field for storing the Rutas's CurDescargue value
		private decimal? m_CurDescargue;

		// Field for storing the Rutas's LogAnticipoACPM value
		private bool? m_LogAnticipoACPM;

		// Evaluate changed state
		private bool m_changed=false;
		// Field for storing the reference to TipoTrailer accessed by TipoTrailerCodigo
		private TipoTrailer m_TiposTrailers;

		// Field for storing the reference to TipoVehiculo accessed by TipoVehiculoCodigo
		private TipoVehiculo m_TiposVehiculos;


		#endregion

		#region Attributes

		// Return if object changed
		public bool Changed
		{
			get { return m_changed;}
			set { m_changed=value;}
		}
		/// <summary>
		/// Attribute for access the Rutas's lngIdRegistrRuta value (int)
		/// </summary>
		[DataMember]
		public int lngIdRegistrRuta
		{
			get { return m_lngIdRegistrRuta; }
			set 
			{
				m_changed=true;
				m_lngIdRegistrRuta = value;
			}
		}

		/// <summary>
		/// Attribute for access the Rutas's strRutaAnticipoGrupoOrigen value (string)
		/// </summary>
		[DataMember]
		public string strRutaAnticipoGrupoOrigen
		{
			get { return m_strRutaAnticipoGrupoOrigen; }
			set 
			{
				m_changed=true;
				m_strRutaAnticipoGrupoOrigen = value;
			}
		}

		/// <summary>
		/// Attribute for access the Rutas's strRutaAnticipoGrupoDestino value (string)
		/// </summary>
		[DataMember]
		public string strRutaAnticipoGrupoDestino
		{
			get { return m_strRutaAnticipoGrupoDestino; }
			set 
			{
				m_changed=true;
				m_strRutaAnticipoGrupoDestino = value;
			}
		}

		/// <summary>
		/// Attribute for access the Rutas's strRutaAnticipoGrupo value (string)
		/// </summary>
		[DataMember]
		public string strRutaAnticipoGrupo
		{
			get { return m_strRutaAnticipoGrupo; }
			set 
			{
				m_changed=true;
				m_strRutaAnticipoGrupo = value;
			}
		}

		/// <summary>
		/// Attribute for access the Rutas's strRutaAnticipo value (string)
		/// </summary>
		[DataMember]
		public string strRutaAnticipo
		{
			get { return m_strRutaAnticipo; }
			set 
			{
				m_changed=true;
				m_strRutaAnticipo = value;
			}
		}

		/// <summary>
		/// Attribute for access the Rutas's TipoVehiculoCodigo value (int)
		/// </summary>
		[DataMember]
		public int? TipoVehiculoCodigo
		{
			get { return m_TipoVehiculoCodigo; }
			set
			{
				m_changed=true;
				m_TipoVehiculoCodigo = value;

				if ((m_TiposVehiculos != null) && (m_TiposVehiculos.Codigo != m_TipoVehiculoCodigo))
				{
					// we need to reset the reference because it is now invalid
					m_TiposVehiculos = null;
				}
			}
		}

		/// <summary>
		/// Attribute for access the Rutas's TipoVehiculo value (string)
		/// </summary>
		[DataMember]
		public string TipoVehiculo
		{
			get { return m_TipoVehiculo; }
			set 
			{
				m_changed=true;
				m_TipoVehiculo = value;
			}
		}

		/// <summary>
		/// Attribute for access the Rutas's TipoTrailerCodigo value (int)
		/// </summary>
		[DataMember]
		public int? TipoTrailerCodigo
		{
			get { return m_TipoTrailerCodigo; }
			set
			{
				m_changed=true;
				m_TipoTrailerCodigo = value;

				if ((m_TiposTrailers != null) && (m_TiposTrailers.Codigo != m_TipoTrailerCodigo))
				{
					// we need to reset the reference because it is now invalid
					m_TiposTrailers = null;
				}
			}
		}

		/// <summary>
		/// Attribute for access the Rutas's Peso value (int)
		/// </summary>
		[DataMember]
		public int? Peso
		{
			get { return m_Peso; }
			set 
			{
				m_changed=true;
				m_Peso = value;
			}
		}

		/// <summary>
		/// Attribute for access the Rutas's Programa value (string)
		/// </summary>
		[DataMember]
		public string Programa
		{
			get { return m_Programa; }
			set 
			{
				m_changed=true;
				m_Programa = value;
			}
		}

		/// <summary>
		/// Attribute for access the Rutas's logViajeVacio value (bool)
		/// </summary>
		[DataMember]
		public bool? logViajeVacio
		{
			get { return m_logViajeVacio; }
			set 
			{
				m_changed=true;
				m_logViajeVacio = value;
			}
		}

		/// <summary>
		/// Attribute for access the Rutas's floGalones value (decimal)
		/// </summary>
		[DataMember]
		public decimal? floGalones
		{
			get { return m_floGalones; }
			set 
			{
				m_changed=true;
				m_floGalones = value;
			}
		}

		/// <summary>
		/// Attribute for access the Rutas's curValorGalon value (decimal)
		/// </summary>
		[DataMember]
		public decimal? curValorGalon
		{
			get { return m_curValorGalon; }
			set 
			{
				m_changed=true;
				m_curValorGalon = value;
			}
		}

		/// <summary>
		/// Attribute for access the Rutas's cutCombustible value (decimal)
		/// </summary>
		[DataMember]
		public decimal? cutCombustible
		{
			get { return m_cutCombustible; }
			set 
			{
				m_changed=true;
				m_cutCombustible = value;
			}
		}

		/// <summary>
		/// Attribute for access the Rutas's CombustibleCarretera value (decimal)
		/// </summary>
		[DataMember]
		public decimal? CombustibleCarretera
		{
			get { return m_CombustibleCarretera; }
			set 
			{
				m_changed=true;
				m_CombustibleCarretera = value;
			}
		}

		/// <summary>
		/// Attribute for access the Rutas's lngIdNroPeajes value (int)
		/// </summary>
		[DataMember]
		public int? lngIdNroPeajes
		{
			get { return m_lngIdNroPeajes; }
			set 
			{
				m_changed=true;
				m_lngIdNroPeajes = value;
			}
		}

		/// <summary>
		/// Attribute for access the Rutas's cutPeaje value (decimal)
		/// </summary>
		[DataMember]
		public decimal? cutPeaje
		{
			get { return m_cutPeaje; }
			set 
			{
				m_changed=true;
				m_cutPeaje = value;
			}
		}

		/// <summary>
		/// Attribute for access the Rutas's strNombrePeajes value (string)
		/// </summary>
		[DataMember]
		public string strNombrePeajes
		{
			get { return m_strNombrePeajes; }
			set 
			{
				m_changed=true;
				m_strNombrePeajes = value;
			}
		}

		/// <summary>
		/// Attribute for access the Rutas's cutVariosLlantas value (decimal)
		/// </summary>
		[DataMember]
		public decimal? cutVariosLlantas
		{
			get { return m_cutVariosLlantas; }
			set 
			{
				m_changed=true;
				m_cutVariosLlantas = value;
			}
		}

		/// <summary>
		/// Attribute for access the Rutas's cutVariosCelada value (decimal)
		/// </summary>
		[DataMember]
		public decimal? cutVariosCelada
		{
			get { return m_cutVariosCelada; }
			set 
			{
				m_changed=true;
				m_cutVariosCelada = value;
			}
		}

		/// <summary>
		/// Attribute for access the Rutas's cutVariosPropina value (decimal)
		/// </summary>
		[DataMember]
		public decimal? cutVariosPropina
		{
			get { return m_cutVariosPropina; }
			set 
			{
				m_changed=true;
				m_cutVariosPropina = value;
			}
		}

		/// <summary>
		/// Attribute for access the Rutas's cutVarios value (decimal)
		/// </summary>
		[DataMember]
		public decimal? cutVarios
		{
			get { return m_cutVarios; }
			set 
			{
				m_changed=true;
				m_cutVarios = value;
			}
		}

		/// <summary>
		/// Attribute for access the Rutas's Llamadas value (decimal)
		/// </summary>
		[DataMember]
		public decimal? Llamadas
		{
			get { return m_Llamadas; }
			set 
			{
				m_changed=true;
				m_Llamadas = value;
			}
		}

		/// <summary>
		/// Attribute for access the Rutas's Taxi value (decimal)
		/// </summary>
		[DataMember]
		public decimal? Taxi
		{
			get { return m_Taxi; }
			set 
			{
				m_changed=true;
				m_Taxi = value;
			}
		}

		/// <summary>
		/// Attribute for access the Rutas's Aseo value (decimal)
		/// </summary>
		[DataMember]
		public decimal? Aseo
		{
			get { return m_Aseo; }
			set 
			{
				m_changed=true;
				m_Aseo = value;
			}
		}

		/// <summary>
		/// Attribute for access the Rutas's cutVariosLlantasVacio value (decimal)
		/// </summary>
		[DataMember]
		public decimal? cutVariosLlantasVacio
		{
			get { return m_cutVariosLlantasVacio; }
			set 
			{
				m_changed=true;
				m_cutVariosLlantasVacio = value;
			}
		}

		/// <summary>
		/// Attribute for access the Rutas's cutVariosCeladaVacio value (decimal)
		/// </summary>
		[DataMember]
		public decimal? cutVariosCeladaVacio
		{
			get { return m_cutVariosCeladaVacio; }
			set 
			{
				m_changed=true;
				m_cutVariosCeladaVacio = value;
			}
		}

		/// <summary>
		/// Attribute for access the Rutas's cutVariosPropinaVacio value (decimal)
		/// </summary>
		[DataMember]
		public decimal? cutVariosPropinaVacio
		{
			get { return m_cutVariosPropinaVacio; }
			set 
			{
				m_changed=true;
				m_cutVariosPropinaVacio = value;
			}
		}

		/// <summary>
		/// Attribute for access the Rutas's cutVariosVacio value (decimal)
		/// </summary>
		[DataMember]
		public decimal? cutVariosVacio
		{
			get { return m_cutVariosVacio; }
			set 
			{
				m_changed=true;
				m_cutVariosVacio = value;
			}
		}

		/// <summary>
		/// Attribute for access the Rutas's Viaticos value (decimal)
		/// </summary>
		[DataMember]
		public decimal? Viaticos
		{
			get { return m_Viaticos; }
			set 
			{
				m_changed=true;
				m_Viaticos = value;
			}
		}

		/// <summary>
		/// Attribute for access the Rutas's cutParticipacion value (decimal)
		/// </summary>
		[DataMember]
		public decimal? cutParticipacion
		{
			get { return m_cutParticipacion; }
			set 
			{
				m_changed=true;
				m_cutParticipacion = value;
			}
		}

		/// <summary>
		/// Attribute for access the Rutas's cutParticipacionVacio value (decimal)
		/// </summary>
		[DataMember]
		public decimal? cutParticipacionVacio
		{
			get { return m_cutParticipacionVacio; }
			set 
			{
				m_changed=true;
				m_cutParticipacionVacio = value;
			}
		}

		/// <summary>
		/// Attribute for access the Rutas's curHotelCarretera value (int)
		/// </summary>
		[DataMember]
		public int? curHotelCarretera
		{
			get { return m_curHotelCarretera; }
			set 
			{
				m_changed=true;
				m_curHotelCarretera = value;
			}
		}

		/// <summary>
		/// Attribute for access the Rutas's curHotelCiudad value (int)
		/// </summary>
		[DataMember]
		public int? curHotelCiudad
		{
			get { return m_curHotelCiudad; }
			set 
			{
				m_changed=true;
				m_curHotelCiudad = value;
			}
		}

		/// <summary>
		/// Attribute for access the Rutas's curHotel value (decimal)
		/// </summary>
		[DataMember]
		public decimal? curHotel
		{
			get { return m_curHotel; }
			set 
			{
				m_changed=true;
				m_curHotel = value;
			}
		}

		/// <summary>
		/// Attribute for access the Rutas's curHotelCarreteraVacio value (int)
		/// </summary>
		[DataMember]
		public int? curHotelCarreteraVacio
		{
			get { return m_curHotelCarreteraVacio; }
			set 
			{
				m_changed=true;
				m_curHotelCarreteraVacio = value;
			}
		}

		/// <summary>
		/// Attribute for access the Rutas's curHotelCiudadVacio value (int)
		/// </summary>
		[DataMember]
		public int? curHotelCiudadVacio
		{
			get { return m_curHotelCiudadVacio; }
			set 
			{
				m_changed=true;
				m_curHotelCiudadVacio = value;
			}
		}

		/// <summary>
		/// Attribute for access the Rutas's curHotelVacio value (decimal)
		/// </summary>
		[DataMember]
		public decimal? curHotelVacio
		{
			get { return m_curHotelVacio; }
			set 
			{
				m_changed=true;
				m_curHotelVacio = value;
			}
		}

		/// <summary>
		/// Attribute for access the Rutas's intTiempoCargue value (decimal)
		/// </summary>
		[DataMember]
		public decimal? intTiempoCargue
		{
			get { return m_intTiempoCargue; }
			set 
			{
				m_changed=true;
				m_intTiempoCargue = value;
			}
		}

		/// <summary>
		/// Attribute for access the Rutas's intTiempoDescargue value (decimal)
		/// </summary>
		[DataMember]
		public decimal? intTiempoDescargue
		{
			get { return m_intTiempoDescargue; }
			set 
			{
				m_changed=true;
				m_intTiempoDescargue = value;
			}
		}

		/// <summary>
		/// Attribute for access the Rutas's intTiempoAduana value (decimal)
		/// </summary>
		[DataMember]
		public decimal? intTiempoAduana
		{
			get { return m_intTiempoAduana; }
			set 
			{
				m_changed=true;
				m_intTiempoAduana = value;
			}
		}

		/// <summary>
		/// Attribute for access the Rutas's intTotalTrayecto value (decimal)
		/// </summary>
		[DataMember]
		public decimal? intTotalTrayecto
		{
			get { return m_intTotalTrayecto; }
			set 
			{
				m_changed=true;
				m_intTotalTrayecto = value;
			}
		}

		/// <summary>
		/// Attribute for access the Rutas's intTotalTiempo value (decimal)
		/// </summary>
		[DataMember]
		public decimal? intTotalTiempo
		{
			get { return m_intTotalTiempo; }
			set 
			{
				m_changed=true;
				m_intTotalTiempo = value;
			}
		}

		/// <summary>
		/// Attribute for access the Rutas's curComida value (decimal)
		/// </summary>
		[DataMember]
		public decimal? curComida
		{
			get { return m_curComida; }
			set 
			{
				m_changed=true;
				m_curComida = value;
			}
		}

		/// <summary>
		/// Attribute for access the Rutas's intTiempoCargueVacio value (decimal)
		/// </summary>
		[DataMember]
		public decimal? intTiempoCargueVacio
		{
			get { return m_intTiempoCargueVacio; }
			set 
			{
				m_changed=true;
				m_intTiempoCargueVacio = value;
			}
		}

		/// <summary>
		/// Attribute for access the Rutas's intTiempoDescargueVacio value (decimal)
		/// </summary>
		[DataMember]
		public decimal? intTiempoDescargueVacio
		{
			get { return m_intTiempoDescargueVacio; }
			set 
			{
				m_changed=true;
				m_intTiempoDescargueVacio = value;
			}
		}

		/// <summary>
		/// Attribute for access the Rutas's intTiempoAduanaVacio value (decimal)
		/// </summary>
		[DataMember]
		public decimal? intTiempoAduanaVacio
		{
			get { return m_intTiempoAduanaVacio; }
			set 
			{
				m_changed=true;
				m_intTiempoAduanaVacio = value;
			}
		}

		/// <summary>
		/// Attribute for access the Rutas's intTotalTrayectoVacio value (decimal)
		/// </summary>
		[DataMember]
		public decimal? intTotalTrayectoVacio
		{
			get { return m_intTotalTrayectoVacio; }
			set 
			{
				m_changed=true;
				m_intTotalTrayectoVacio = value;
			}
		}

		/// <summary>
		/// Attribute for access the Rutas's intTotalTiempoVacio value (decimal)
		/// </summary>
		[DataMember]
		public decimal? intTotalTiempoVacio
		{
			get { return m_intTotalTiempoVacio; }
			set 
			{
				m_changed=true;
				m_intTotalTiempoVacio = value;
			}
		}

		/// <summary>
		/// Attribute for access the Rutas's curComidaVacio value (decimal)
		/// </summary>
		[DataMember]
		public decimal? curComidaVacio
		{
			get { return m_curComidaVacio; }
			set 
			{
				m_changed=true;
				m_curComidaVacio = value;
			}
		}

		/// <summary>
		/// Attribute for access the Rutas's curDesvareManoRepuestos value (decimal)
		/// </summary>
		[DataMember]
		public decimal? curDesvareManoRepuestos
		{
			get { return m_curDesvareManoRepuestos; }
			set 
			{
				m_changed=true;
				m_curDesvareManoRepuestos = value;
			}
		}

		/// <summary>
		/// Attribute for access the Rutas's curDesvareManoObra value (decimal)
		/// </summary>
		[DataMember]
		public decimal? curDesvareManoObra
		{
			get { return m_curDesvareManoObra; }
			set 
			{
				m_changed=true;
				m_curDesvareManoObra = value;
			}
		}

		/// <summary>
		/// Attribute for access the Rutas's cutSaldo value (decimal)
		/// </summary>
		[DataMember]
		public decimal? cutSaldo
		{
			get { return m_cutSaldo; }
			set 
			{
				m_changed=true;
				m_cutSaldo = value;
			}
		}

		/// <summary>
		/// Attribute for access the Rutas's cutSaldoVacio value (decimal)
		/// </summary>
		[DataMember]
		public decimal? cutSaldoVacio
		{
			get { return m_cutSaldoVacio; }
			set 
			{
				m_changed=true;
				m_cutSaldoVacio = value;
			}
		}

		/// <summary>
		/// Attribute for access the Rutas's cutKmts value (decimal)
		/// </summary>
		[DataMember]
		public decimal? cutKmts
		{
			get { return m_cutKmts; }
			set 
			{
				m_changed=true;
				m_cutKmts = value;
			}
		}

		/// <summary>
		/// Attribute for access the Rutas's logActualizaPeajes value (decimal)
		/// </summary>
		[DataMember]
		public decimal? logActualizaPeajes
		{
			get { return m_logActualizaPeajes; }
			set 
			{
				m_changed=true;
				m_logActualizaPeajes = value;
			}
		}

		/// <summary>
		/// Attribute for access the Rutas's intFactorKmPorGalon value (decimal)
		/// </summary>
		[DataMember]
		public decimal? intFactorKmPorGalon
		{
			get { return m_intFactorKmPorGalon; }
			set 
			{
				m_changed=true;
				m_intFactorKmPorGalon = value;
			}
		}

		/// <summary>
		/// Attribute for access the Rutas's logEstadoRuta value (bool)
		/// </summary>
		[DataMember]
		public bool? logEstadoRuta
		{
			get { return m_logEstadoRuta; }
			set 
			{
				m_changed=true;
				m_logEstadoRuta = value;
			}
		}

		/// <summary>
		/// Attribute for access the Rutas's ParqueaderoCarretera value (decimal)
		/// </summary>
		[DataMember]
		public decimal? ParqueaderoCarretera
		{
			get { return m_ParqueaderoCarretera; }
			set 
			{
				m_changed=true;
				m_ParqueaderoCarretera = value;
			}
		}

		/// <summary>
		/// Attribute for access the Rutas's ParqueaderoCiudad value (decimal)
		/// </summary>
		[DataMember]
		public decimal? ParqueaderoCiudad
		{
			get { return m_ParqueaderoCiudad; }
			set 
			{
				m_changed=true;
				m_ParqueaderoCiudad = value;
			}
		}

		/// <summary>
		/// Attribute for access the Rutas's MontadaLLantaCarretera value (decimal)
		/// </summary>
		[DataMember]
		public decimal? MontadaLLantaCarretera
		{
			get { return m_MontadaLLantaCarretera; }
			set 
			{
				m_changed=true;
				m_MontadaLLantaCarretera = value;
			}
		}

		/// <summary>
		/// Attribute for access the Rutas's MontadaLLantaCiudad value (decimal)
		/// </summary>
		[DataMember]
		public decimal? MontadaLLantaCiudad
		{
			get { return m_MontadaLLantaCiudad; }
			set 
			{
				m_changed=true;
				m_MontadaLLantaCiudad = value;
			}
		}

		/// <summary>
		/// Attribute for access the Rutas's AjusteCarretera value (decimal)
		/// </summary>
		[DataMember]
		public decimal? AjusteCarretera
		{
			get { return m_AjusteCarretera; }
			set 
			{
				m_changed=true;
				m_AjusteCarretera = value;
			}
		}

		/// <summary>
		/// Attribute for access the Rutas's Lavada value (decimal)
		/// </summary>
		[DataMember]
		public decimal? Lavada
		{
			get { return m_Lavada; }
			set 
			{
				m_changed=true;
				m_Lavada = value;
			}
		}

		/// <summary>
		/// Attribute for access the Rutas's Amarres value (decimal)
		/// </summary>
		[DataMember]
		public decimal? Amarres
		{
			get { return m_Amarres; }
			set 
			{
				m_changed=true;
				m_Amarres = value;
			}
		}

		/// <summary>
		/// Attribute for access the Rutas's Engradasa value (decimal)
		/// </summary>
		[DataMember]
		public decimal? Engradasa
		{
			get { return m_Engradasa; }
			set 
			{
				m_changed=true;
				m_Engradasa = value;
			}
		}

		/// <summary>
		/// Attribute for access the Rutas's Calibrada value (decimal)
		/// </summary>
		[DataMember]
		public decimal? Calibrada
		{
			get { return m_Calibrada; }
			set 
			{
				m_changed=true;
				m_Calibrada = value;
			}
		}

		/// <summary>
		/// Attribute for access the Rutas's Liquidado value (bool)
		/// </summary>
		[DataMember]
		public bool? Liquidado
		{
			get { return m_Liquidado; }
			set 
			{
				m_changed=true;
				m_Liquidado = value;
			}
		}

		/// <summary>
		/// Attribute for access the Rutas's logVacio value (bool)
		/// </summary>
		[DataMember]
		public bool? logVacio
		{
			get { return m_logVacio; }
			set 
			{
				m_changed=true;
				m_logVacio = value;
			}
		}

		/// <summary>
		/// Attribute for access the Rutas's Papeleria value (decimal)
		/// </summary>
		[DataMember]
		public decimal? Papeleria
		{
			get { return m_Papeleria; }
			set 
			{
				m_changed=true;
				m_Papeleria = value;
			}
		}

		/// <summary>
		/// Attribute for access the Rutas's logFavorito value (bool)
		/// </summary>
		[DataMember]
		public bool? logFavorito
		{
			get { return m_logFavorito; }
			set 
			{
				m_changed=true;
				m_logFavorito = value;
			}
		}

		/// <summary>
		/// Attribute for access the Rutas's CurCargue value (decimal)
		/// </summary>
		[DataMember]
		public decimal? CurCargue
		{
			get { return m_CurCargue; }
			set 
			{
				m_changed=true;
				m_CurCargue = value;
			}
		}

		/// <summary>
		/// Attribute for access the Rutas's CurDescargue value (decimal)
		/// </summary>
		[DataMember]
		public decimal? CurDescargue
		{
			get { return m_CurDescargue; }
			set 
			{
				m_changed=true;
				m_CurDescargue = value;
			}
		}

		/// <summary>
		/// Attribute for access the Rutas's LogAnticipoACPM value (bool)
		/// </summary>
		[DataMember]
		public bool? LogAnticipoACPM
		{
			get { return m_LogAnticipoACPM; }
			set 
			{
				m_changed=true;
				m_LogAnticipoACPM = value;
			}
		}

		public object GetAttribute(string pattribute)
		{
			switch (pattribute)
			{
				case "lngIdRegistrRuta": return lngIdRegistrRuta;
				case "strRutaAnticipoGrupoOrigen": return strRutaAnticipoGrupoOrigen;
				case "strRutaAnticipoGrupoDestino": return strRutaAnticipoGrupoDestino;
				case "strRutaAnticipoGrupo": return strRutaAnticipoGrupo;
				case "strRutaAnticipo": return strRutaAnticipo;
				case "TipoVehiculoCodigo": return TipoVehiculoCodigo;
				case "TipoVehiculo": return TipoVehiculo;
				case "TipoTrailerCodigo": return TipoTrailerCodigo;
				case "Peso": return Peso;
				case "Programa": return Programa;
				case "logViajeVacio": return logViajeVacio;
				case "floGalones": return floGalones;
				case "curValorGalon": return curValorGalon;
				case "cutCombustible": return cutCombustible;
				case "CombustibleCarretera": return CombustibleCarretera;
				case "lngIdNroPeajes": return lngIdNroPeajes;
				case "cutPeaje": return cutPeaje;
				case "strNombrePeajes": return strNombrePeajes;
				case "cutVariosLlantas": return cutVariosLlantas;
				case "cutVariosCelada": return cutVariosCelada;
				case "cutVariosPropina": return cutVariosPropina;
				case "cutVarios": return cutVarios;
				case "Llamadas": return Llamadas;
				case "Taxi": return Taxi;
				case "Aseo": return Aseo;
				case "cutVariosLlantasVacio": return cutVariosLlantasVacio;
				case "cutVariosCeladaVacio": return cutVariosCeladaVacio;
				case "cutVariosPropinaVacio": return cutVariosPropinaVacio;
				case "cutVariosVacio": return cutVariosVacio;
				case "Viaticos": return Viaticos;
				case "cutParticipacion": return cutParticipacion;
				case "cutParticipacionVacio": return cutParticipacionVacio;
				case "curHotelCarretera": return curHotelCarretera;
				case "curHotelCiudad": return curHotelCiudad;
				case "curHotel": return curHotel;
				case "curHotelCarreteraVacio": return curHotelCarreteraVacio;
				case "curHotelCiudadVacio": return curHotelCiudadVacio;
				case "curHotelVacio": return curHotelVacio;
				case "intTiempoCargue": return intTiempoCargue;
				case "intTiempoDescargue": return intTiempoDescargue;
				case "intTiempoAduana": return intTiempoAduana;
				case "intTotalTrayecto": return intTotalTrayecto;
				case "intTotalTiempo": return intTotalTiempo;
				case "curComida": return curComida;
				case "intTiempoCargueVacio": return intTiempoCargueVacio;
				case "intTiempoDescargueVacio": return intTiempoDescargueVacio;
				case "intTiempoAduanaVacio": return intTiempoAduanaVacio;
				case "intTotalTrayectoVacio": return intTotalTrayectoVacio;
				case "intTotalTiempoVacio": return intTotalTiempoVacio;
				case "curComidaVacio": return curComidaVacio;
				case "curDesvareManoRepuestos": return curDesvareManoRepuestos;
				case "curDesvareManoObra": return curDesvareManoObra;
				case "cutSaldo": return cutSaldo;
				case "cutSaldoVacio": return cutSaldoVacio;
				case "cutKmts": return cutKmts;
				case "logActualizaPeajes": return logActualizaPeajes;
				case "intFactorKmPorGalon": return intFactorKmPorGalon;
				case "logEstadoRuta": return logEstadoRuta;
				case "ParqueaderoCarretera": return ParqueaderoCarretera;
				case "ParqueaderoCiudad": return ParqueaderoCiudad;
				case "MontadaLLantaCarretera": return MontadaLLantaCarretera;
				case "MontadaLLantaCiudad": return MontadaLLantaCiudad;
				case "AjusteCarretera": return AjusteCarretera;
				case "Lavada": return Lavada;
				case "Amarres": return Amarres;
				case "Engradasa": return Engradasa;
				case "Calibrada": return Calibrada;
				case "Liquidado": return Liquidado;
				case "logVacio": return logVacio;
				case "Papeleria": return Papeleria;
				case "logFavorito": return logFavorito;
				case "CurCargue": return CurCargue;
				case "CurDescargue": return CurDescargue;
				case "LogAnticipoACPM": return LogAnticipoACPM;
				default: return null;
			}
		}

		public Type GetAttributeType(string pattribute)
		{
			return RutasController.Instance.GetMethodType(pattribute, this);
		}

		public string GetSqlKey()
		{
			return "[lngIdRegistrRuta] = " + lngIdRegistrRuta.ToString();
		}
		/// <summary>
		/// Gets or sets the reference to TipoTrailer accessed by TipoTrailerCodigo
		/// </summary>
		/// <remarks>
		/// Also updates related field values
		/// </remarks>
		public TipoTrailer TiposTrailers
		{
			get
			{
				if (m_TiposTrailers == null)
				{
					if (m_TipoTrailerCodigo != null)
					{
						m_TiposTrailers = TipoTrailerController.Instance.Get((int)m_TipoTrailerCodigo);
					}
				}

				return m_TiposTrailers;
			}

			set
			{
				m_TiposTrailers = value;

				if (m_TiposTrailers != null)
				{
					this.m_TipoTrailerCodigo = m_TiposTrailers.Codigo;
				}
			}
		}

		/// <summary>
		/// Gets or sets the reference to TipoVehiculo accessed by TipoVehiculoCodigo
		/// </summary>
		/// <remarks>
		/// Also updates related field values
		/// </remarks>
		public TipoVehiculo TiposVehiculos
		{
			get
			{
				if (m_TiposVehiculos == null)
				{
					if (m_TipoVehiculoCodigo != null)
					{
						m_TiposVehiculos = TipoVehiculoController.Instance.Get((int)m_TipoVehiculoCodigo);
					}
				}

				return m_TiposVehiculos;
			}

			set
			{
				m_TiposVehiculos = value;

				if (m_TiposVehiculos != null)
				{
					this.m_TipoVehiculoCodigo = m_TiposVehiculos.Codigo;
				}
			}
		}

		#endregion

	}

	#endregion

	#region RutasList object

	/// <summary>
	/// Class for reading and access a list of Rutas object
	/// </summary>
	[CollectionDataContract]
	public partial class RutasList : List<Rutas>
	{

		/// <summary>
		/// Default constructor
		/// </summary>
		public RutasList()
		{
		}
	}

	#endregion

}
