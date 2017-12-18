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
	#region LiquidacionRutas object

	[DataContract]
	public partial class LiquidacionRutas : IDTOObject
	{
		/// <summary>
		/// Default constructor
		/// </summary>
		public LiquidacionRutas()
		{
			m_lngIdRegistrRutaItemId = 0;
			m_lngIdRegistrRuta = null;
			m_lngIdRegistro = null;
			m_lngIdRegistrRutaItemIdAjc = null;
			m_strRutaAnticipoGrupoOrigen = null;
			m_strRutaAnticipoGrupoDestino = null;
			m_strRutaAnticipoGrupo = null;
			m_strRutaAnticipo = null;
			m_logLiquidado = false;
			m_PlacaTrayler = null;
			m_Trailer = null;
			m_floGalones = null;
			m_floGalonesReales = null;
			m_floGalonesReserva = null;
			m_curValorGalon = null;
			m_CombustibleCarretera = null;
			m_cutCombustible = null;
			m_LogAnticipoACPM = false;
			m_cutValorAnticipo = null;
			m_lngIdNroPeajes = null;
			m_cutPeaje = null;
			m_strNombrePeajes = null;
			m_cutVariosLlantas = null;
			m_cutVariosCelada = null;
			m_cutVariosPropina = null;
			m_cutVarios = null;
			m_cutVariosLlantasVacio = null;
			m_cutVariosCeladaVacio = null;
			m_cutVariosPropinaVacio = null;
			m_cutVariosVacio = null;
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
			m_cutKmts = null;
			m_logAjuste = false;
			m_dtmFechaModif = null;
			m_logVacio = false;
			m_TipoVehiculoCodigo = null;
			m_TipoVehiculo = null;
			m_TipoTrailerCodigo = null;
			m_Peso = null;
			m_Contenedor1 = null;
			m_Contenedor2 = null;
			m_FactorCalculoDia = null;
			m_ValorCalculoFactor = null;
			m_ParqueaderoCarretera = null;
			m_ParqueaderoCiudad = null;
			m_MontadaLLantaCarretera = null;
			m_MontadaLLantaCiudad = null;
			m_AjusteCarretera = null;
			m_Taxi = null;
			m_Aseo = null;
			m_Amarres = null;
			m_Engradasa = null;
			m_Calibrada = null;
			m_Liquidado = false;
			m_Lavada = null;
			m_logEstadoRuta = false;
			m_Papeleria = null;
			m_logFavorito = false;
			m_CurCargue = null;
			m_CurDescargue = null;
			m_logLiquParticipacion = false;
			m_changed=false;
		}
		        //Return the table name of object
		        public string TableName()
		        {
		            return "tblLiquidacionRutas";
		        }
		#region Undo 
		// Internal class for storing changes
		private LiquidacionRutas m_oldLiquidacionRutas;
		public void GenerateUndo()
		{
			m_oldLiquidacionRutas=new LiquidacionRutas();
			m_oldLiquidacionRutas.m_lngIdRegistrRutaItemId = m_lngIdRegistrRutaItemId;
			m_oldLiquidacionRutas.lngIdRegistrRuta = m_lngIdRegistrRuta;
			m_oldLiquidacionRutas.lngIdRegistro = m_lngIdRegistro;
			m_oldLiquidacionRutas.lngIdRegistrRutaItemIdAjc = m_lngIdRegistrRutaItemIdAjc;
			m_oldLiquidacionRutas.strRutaAnticipoGrupoOrigen = m_strRutaAnticipoGrupoOrigen;
			m_oldLiquidacionRutas.strRutaAnticipoGrupoDestino = m_strRutaAnticipoGrupoDestino;
			m_oldLiquidacionRutas.strRutaAnticipoGrupo = m_strRutaAnticipoGrupo;
			m_oldLiquidacionRutas.strRutaAnticipo = m_strRutaAnticipo;
			m_oldLiquidacionRutas.logLiquidado = m_logLiquidado;
			m_oldLiquidacionRutas.PlacaTrayler = m_PlacaTrayler;
			m_oldLiquidacionRutas.Trailer = m_Trailer;
			m_oldLiquidacionRutas.floGalones = m_floGalones;
			m_oldLiquidacionRutas.floGalonesReales = m_floGalonesReales;
			m_oldLiquidacionRutas.floGalonesReserva = m_floGalonesReserva;
			m_oldLiquidacionRutas.curValorGalon = m_curValorGalon;
			m_oldLiquidacionRutas.CombustibleCarretera = m_CombustibleCarretera;
			m_oldLiquidacionRutas.cutCombustible = m_cutCombustible;
			m_oldLiquidacionRutas.LogAnticipoACPM = m_LogAnticipoACPM;
			m_oldLiquidacionRutas.cutValorAnticipo = m_cutValorAnticipo;
			m_oldLiquidacionRutas.lngIdNroPeajes = m_lngIdNroPeajes;
			m_oldLiquidacionRutas.cutPeaje = m_cutPeaje;
			m_oldLiquidacionRutas.strNombrePeajes = m_strNombrePeajes;
			m_oldLiquidacionRutas.cutVariosLlantas = m_cutVariosLlantas;
			m_oldLiquidacionRutas.cutVariosCelada = m_cutVariosCelada;
			m_oldLiquidacionRutas.cutVariosPropina = m_cutVariosPropina;
			m_oldLiquidacionRutas.cutVarios = m_cutVarios;
			m_oldLiquidacionRutas.cutVariosLlantasVacio = m_cutVariosLlantasVacio;
			m_oldLiquidacionRutas.cutVariosCeladaVacio = m_cutVariosCeladaVacio;
			m_oldLiquidacionRutas.cutVariosPropinaVacio = m_cutVariosPropinaVacio;
			m_oldLiquidacionRutas.cutVariosVacio = m_cutVariosVacio;
			m_oldLiquidacionRutas.cutParticipacion = m_cutParticipacion;
			m_oldLiquidacionRutas.cutParticipacionVacio = m_cutParticipacionVacio;
			m_oldLiquidacionRutas.curHotelCarretera = m_curHotelCarretera;
			m_oldLiquidacionRutas.curHotelCiudad = m_curHotelCiudad;
			m_oldLiquidacionRutas.curHotel = m_curHotel;
			m_oldLiquidacionRutas.curHotelCarreteraVacio = m_curHotelCarreteraVacio;
			m_oldLiquidacionRutas.curHotelCiudadVacio = m_curHotelCiudadVacio;
			m_oldLiquidacionRutas.curHotelVacio = m_curHotelVacio;
			m_oldLiquidacionRutas.intTiempoCargue = m_intTiempoCargue;
			m_oldLiquidacionRutas.intTiempoDescargue = m_intTiempoDescargue;
			m_oldLiquidacionRutas.intTiempoAduana = m_intTiempoAduana;
			m_oldLiquidacionRutas.intTotalTrayecto = m_intTotalTrayecto;
			m_oldLiquidacionRutas.intTotalTiempo = m_intTotalTiempo;
			m_oldLiquidacionRutas.curComida = m_curComida;
			m_oldLiquidacionRutas.intTiempoCargueVacio = m_intTiempoCargueVacio;
			m_oldLiquidacionRutas.intTiempoDescargueVacio = m_intTiempoDescargueVacio;
			m_oldLiquidacionRutas.intTiempoAduanaVacio = m_intTiempoAduanaVacio;
			m_oldLiquidacionRutas.intTotalTrayectoVacio = m_intTotalTrayectoVacio;
			m_oldLiquidacionRutas.intTotalTiempoVacio = m_intTotalTiempoVacio;
			m_oldLiquidacionRutas.curComidaVacio = m_curComidaVacio;
			m_oldLiquidacionRutas.curDesvareManoRepuestos = m_curDesvareManoRepuestos;
			m_oldLiquidacionRutas.curDesvareManoObra = m_curDesvareManoObra;
			m_oldLiquidacionRutas.cutSaldo = m_cutSaldo;
			m_oldLiquidacionRutas.cutKmts = m_cutKmts;
			m_oldLiquidacionRutas.logAjuste = m_logAjuste;
			m_oldLiquidacionRutas.dtmFechaModif = m_dtmFechaModif;
			m_oldLiquidacionRutas.logVacio = m_logVacio;
			m_oldLiquidacionRutas.TipoVehiculoCodigo = m_TipoVehiculoCodigo;
			m_oldLiquidacionRutas.TipoVehiculo = m_TipoVehiculo;
			m_oldLiquidacionRutas.TipoTrailerCodigo = m_TipoTrailerCodigo;
			m_oldLiquidacionRutas.Peso = m_Peso;
			m_oldLiquidacionRutas.Contenedor1 = m_Contenedor1;
			m_oldLiquidacionRutas.Contenedor2 = m_Contenedor2;
			m_oldLiquidacionRutas.FactorCalculoDia = m_FactorCalculoDia;
			m_oldLiquidacionRutas.ValorCalculoFactor = m_ValorCalculoFactor;
			m_oldLiquidacionRutas.ParqueaderoCarretera = m_ParqueaderoCarretera;
			m_oldLiquidacionRutas.ParqueaderoCiudad = m_ParqueaderoCiudad;
			m_oldLiquidacionRutas.MontadaLLantaCarretera = m_MontadaLLantaCarretera;
			m_oldLiquidacionRutas.MontadaLLantaCiudad = m_MontadaLLantaCiudad;
			m_oldLiquidacionRutas.AjusteCarretera = m_AjusteCarretera;
			m_oldLiquidacionRutas.Taxi = m_Taxi;
			m_oldLiquidacionRutas.Aseo = m_Aseo;
			m_oldLiquidacionRutas.Amarres = m_Amarres;
			m_oldLiquidacionRutas.Engradasa = m_Engradasa;
			m_oldLiquidacionRutas.Calibrada = m_Calibrada;
			m_oldLiquidacionRutas.Liquidado = m_Liquidado;
			m_oldLiquidacionRutas.Lavada = m_Lavada;
			m_oldLiquidacionRutas.logEstadoRuta = m_logEstadoRuta;
			m_oldLiquidacionRutas.Papeleria = m_Papeleria;
			m_oldLiquidacionRutas.logFavorito = m_logFavorito;
			m_oldLiquidacionRutas.CurCargue = m_CurCargue;
			m_oldLiquidacionRutas.CurDescargue = m_CurDescargue;
			m_oldLiquidacionRutas.logLiquParticipacion = m_logLiquParticipacion;
		}

		public LiquidacionRutas OldLiquidacionRutas
		{
			get { return m_oldLiquidacionRutas;}
		}
		// Return the changed fields
		public string[] FieldChanged()
		{
			List<string> fields=new List<string>();
			if (m_oldLiquidacionRutas.lngIdRegistrRuta != m_lngIdRegistrRuta) fields.Add("lngIdRegistrRuta");
			if (m_oldLiquidacionRutas.lngIdRegistro != m_lngIdRegistro) fields.Add("lngIdRegistro");
			if (m_oldLiquidacionRutas.lngIdRegistrRutaItemIdAjc != m_lngIdRegistrRutaItemIdAjc) fields.Add("lngIdRegistrRutaItemIdAjc");
			if (m_oldLiquidacionRutas.strRutaAnticipoGrupoOrigen != m_strRutaAnticipoGrupoOrigen) fields.Add("strRutaAnticipoGrupoOrigen");
			if (m_oldLiquidacionRutas.strRutaAnticipoGrupoDestino != m_strRutaAnticipoGrupoDestino) fields.Add("strRutaAnticipoGrupoDestino");
			if (m_oldLiquidacionRutas.strRutaAnticipoGrupo != m_strRutaAnticipoGrupo) fields.Add("strRutaAnticipoGrupo");
			if (m_oldLiquidacionRutas.strRutaAnticipo != m_strRutaAnticipo) fields.Add("strRutaAnticipo");
			if (m_oldLiquidacionRutas.logLiquidado != m_logLiquidado) fields.Add("logLiquidado");
			if (m_oldLiquidacionRutas.PlacaTrayler != m_PlacaTrayler) fields.Add("PlacaTrayler");
			if (m_oldLiquidacionRutas.Trailer != m_Trailer) fields.Add("Trailer");
			if (m_oldLiquidacionRutas.floGalones != m_floGalones) fields.Add("floGalones");
			if (m_oldLiquidacionRutas.floGalonesReales != m_floGalonesReales) fields.Add("floGalonesReales");
			if (m_oldLiquidacionRutas.floGalonesReserva != m_floGalonesReserva) fields.Add("floGalonesReserva");
			if (m_oldLiquidacionRutas.curValorGalon != m_curValorGalon) fields.Add("curValorGalon");
			if (m_oldLiquidacionRutas.CombustibleCarretera != m_CombustibleCarretera) fields.Add("CombustibleCarretera");
			if (m_oldLiquidacionRutas.cutCombustible != m_cutCombustible) fields.Add("cutCombustible");
			if (m_oldLiquidacionRutas.LogAnticipoACPM != m_LogAnticipoACPM) fields.Add("LogAnticipoACPM");
			if (m_oldLiquidacionRutas.cutValorAnticipo != m_cutValorAnticipo) fields.Add("cutValorAnticipo");
			if (m_oldLiquidacionRutas.lngIdNroPeajes != m_lngIdNroPeajes) fields.Add("lngIdNroPeajes");
			if (m_oldLiquidacionRutas.cutPeaje != m_cutPeaje) fields.Add("cutPeaje");
			if (m_oldLiquidacionRutas.strNombrePeajes != m_strNombrePeajes) fields.Add("strNombrePeajes");
			if (m_oldLiquidacionRutas.cutVariosLlantas != m_cutVariosLlantas) fields.Add("cutVariosLlantas");
			if (m_oldLiquidacionRutas.cutVariosCelada != m_cutVariosCelada) fields.Add("cutVariosCelada");
			if (m_oldLiquidacionRutas.cutVariosPropina != m_cutVariosPropina) fields.Add("cutVariosPropina");
			if (m_oldLiquidacionRutas.cutVarios != m_cutVarios) fields.Add("cutVarios");
			if (m_oldLiquidacionRutas.cutVariosLlantasVacio != m_cutVariosLlantasVacio) fields.Add("cutVariosLlantasVacio");
			if (m_oldLiquidacionRutas.cutVariosCeladaVacio != m_cutVariosCeladaVacio) fields.Add("cutVariosCeladaVacio");
			if (m_oldLiquidacionRutas.cutVariosPropinaVacio != m_cutVariosPropinaVacio) fields.Add("cutVariosPropinaVacio");
			if (m_oldLiquidacionRutas.cutVariosVacio != m_cutVariosVacio) fields.Add("cutVariosVacio");
			if (m_oldLiquidacionRutas.cutParticipacion != m_cutParticipacion) fields.Add("cutParticipacion");
			if (m_oldLiquidacionRutas.cutParticipacionVacio != m_cutParticipacionVacio) fields.Add("cutParticipacionVacio");
			if (m_oldLiquidacionRutas.curHotelCarretera != m_curHotelCarretera) fields.Add("curHotelCarretera");
			if (m_oldLiquidacionRutas.curHotelCiudad != m_curHotelCiudad) fields.Add("curHotelCiudad");
			if (m_oldLiquidacionRutas.curHotel != m_curHotel) fields.Add("curHotel");
			if (m_oldLiquidacionRutas.curHotelCarreteraVacio != m_curHotelCarreteraVacio) fields.Add("curHotelCarreteraVacio");
			if (m_oldLiquidacionRutas.curHotelCiudadVacio != m_curHotelCiudadVacio) fields.Add("curHotelCiudadVacio");
			if (m_oldLiquidacionRutas.curHotelVacio != m_curHotelVacio) fields.Add("curHotelVacio");
			if (m_oldLiquidacionRutas.intTiempoCargue != m_intTiempoCargue) fields.Add("intTiempoCargue");
			if (m_oldLiquidacionRutas.intTiempoDescargue != m_intTiempoDescargue) fields.Add("intTiempoDescargue");
			if (m_oldLiquidacionRutas.intTiempoAduana != m_intTiempoAduana) fields.Add("intTiempoAduana");
			if (m_oldLiquidacionRutas.intTotalTrayecto != m_intTotalTrayecto) fields.Add("intTotalTrayecto");
			if (m_oldLiquidacionRutas.intTotalTiempo != m_intTotalTiempo) fields.Add("intTotalTiempo");
			if (m_oldLiquidacionRutas.curComida != m_curComida) fields.Add("curComida");
			if (m_oldLiquidacionRutas.intTiempoCargueVacio != m_intTiempoCargueVacio) fields.Add("intTiempoCargueVacio");
			if (m_oldLiquidacionRutas.intTiempoDescargueVacio != m_intTiempoDescargueVacio) fields.Add("intTiempoDescargueVacio");
			if (m_oldLiquidacionRutas.intTiempoAduanaVacio != m_intTiempoAduanaVacio) fields.Add("intTiempoAduanaVacio");
			if (m_oldLiquidacionRutas.intTotalTrayectoVacio != m_intTotalTrayectoVacio) fields.Add("intTotalTrayectoVacio");
			if (m_oldLiquidacionRutas.intTotalTiempoVacio != m_intTotalTiempoVacio) fields.Add("intTotalTiempoVacio");
			if (m_oldLiquidacionRutas.curComidaVacio != m_curComidaVacio) fields.Add("curComidaVacio");
			if (m_oldLiquidacionRutas.curDesvareManoRepuestos != m_curDesvareManoRepuestos) fields.Add("curDesvareManoRepuestos");
			if (m_oldLiquidacionRutas.curDesvareManoObra != m_curDesvareManoObra) fields.Add("curDesvareManoObra");
			if (m_oldLiquidacionRutas.cutSaldo != m_cutSaldo) fields.Add("cutSaldo");
			if (m_oldLiquidacionRutas.cutKmts != m_cutKmts) fields.Add("cutKmts");
			if (m_oldLiquidacionRutas.logAjuste != m_logAjuste) fields.Add("logAjuste");
			if (m_oldLiquidacionRutas.dtmFechaModif != m_dtmFechaModif) fields.Add("dtmFechaModif");
			if (m_oldLiquidacionRutas.logVacio != m_logVacio) fields.Add("logVacio");
			if (m_oldLiquidacionRutas.TipoVehiculoCodigo != m_TipoVehiculoCodigo) fields.Add("TipoVehiculoCodigo");
			if (m_oldLiquidacionRutas.TipoVehiculo != m_TipoVehiculo) fields.Add("TipoVehiculo");
			if (m_oldLiquidacionRutas.TipoTrailerCodigo != m_TipoTrailerCodigo) fields.Add("TipoTrailerCodigo");
			if (m_oldLiquidacionRutas.Peso != m_Peso) fields.Add("Peso");
			if (m_oldLiquidacionRutas.Contenedor1 != m_Contenedor1) fields.Add("Contenedor1");
			if (m_oldLiquidacionRutas.Contenedor2 != m_Contenedor2) fields.Add("Contenedor2");
			if (m_oldLiquidacionRutas.FactorCalculoDia != m_FactorCalculoDia) fields.Add("FactorCalculoDia");
			if (m_oldLiquidacionRutas.ValorCalculoFactor != m_ValorCalculoFactor) fields.Add("ValorCalculoFactor");
			if (m_oldLiquidacionRutas.ParqueaderoCarretera != m_ParqueaderoCarretera) fields.Add("ParqueaderoCarretera");
			if (m_oldLiquidacionRutas.ParqueaderoCiudad != m_ParqueaderoCiudad) fields.Add("ParqueaderoCiudad");
			if (m_oldLiquidacionRutas.MontadaLLantaCarretera != m_MontadaLLantaCarretera) fields.Add("MontadaLLantaCarretera");
			if (m_oldLiquidacionRutas.MontadaLLantaCiudad != m_MontadaLLantaCiudad) fields.Add("MontadaLLantaCiudad");
			if (m_oldLiquidacionRutas.AjusteCarretera != m_AjusteCarretera) fields.Add("AjusteCarretera");
			if (m_oldLiquidacionRutas.Taxi != m_Taxi) fields.Add("Taxi");
			if (m_oldLiquidacionRutas.Aseo != m_Aseo) fields.Add("Aseo");
			if (m_oldLiquidacionRutas.Amarres != m_Amarres) fields.Add("Amarres");
			if (m_oldLiquidacionRutas.Engradasa != m_Engradasa) fields.Add("Engradasa");
			if (m_oldLiquidacionRutas.Calibrada != m_Calibrada) fields.Add("Calibrada");
			if (m_oldLiquidacionRutas.Liquidado != m_Liquidado) fields.Add("Liquidado");
			if (m_oldLiquidacionRutas.Lavada != m_Lavada) fields.Add("Lavada");
			if (m_oldLiquidacionRutas.logEstadoRuta != m_logEstadoRuta) fields.Add("logEstadoRuta");
			if (m_oldLiquidacionRutas.Papeleria != m_Papeleria) fields.Add("Papeleria");
			if (m_oldLiquidacionRutas.logFavorito != m_logFavorito) fields.Add("logFavorito");
			if (m_oldLiquidacionRutas.CurCargue != m_CurCargue) fields.Add("CurCargue");
			if (m_oldLiquidacionRutas.CurDescargue != m_CurDescargue) fields.Add("CurDescargue");
			if (m_oldLiquidacionRutas.logLiquParticipacion != m_logLiquParticipacion) fields.Add("logLiquParticipacion");
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


		// Field for storing the LiquidacionRutas's lngIdRegistrRutaItemId value
		private long m_lngIdRegistrRutaItemId;

		// Field for storing the LiquidacionRutas's lngIdRegistrRuta value
		private long? m_lngIdRegistrRuta;

		// Field for storing the LiquidacionRutas's lngIdRegistro value
		private long? m_lngIdRegistro;

		// Field for storing the LiquidacionRutas's lngIdRegistrRutaItemIdAjc value
		private long? m_lngIdRegistrRutaItemIdAjc;

		// Field for storing the LiquidacionRutas's strRutaAnticipoGrupoOrigen value
		private string m_strRutaAnticipoGrupoOrigen;

		// Field for storing the LiquidacionRutas's strRutaAnticipoGrupoDestino value
		private string m_strRutaAnticipoGrupoDestino;

		// Field for storing the LiquidacionRutas's strRutaAnticipoGrupo value
		private string m_strRutaAnticipoGrupo;

		// Field for storing the LiquidacionRutas's strRutaAnticipo value
		private string m_strRutaAnticipo;

		// Field for storing the LiquidacionRutas's logLiquidado value
		private bool? m_logLiquidado;

		// Field for storing the LiquidacionRutas's PlacaTrayler value
		private string m_PlacaTrayler;

		// Field for storing the LiquidacionRutas's Trailer value
		private string m_Trailer;

		// Field for storing the LiquidacionRutas's floGalones value
		private decimal? m_floGalones;

		// Field for storing the LiquidacionRutas's floGalonesReales value
		private decimal? m_floGalonesReales;

		// Field for storing the LiquidacionRutas's floGalonesReserva value
		private decimal? m_floGalonesReserva;

		// Field for storing the LiquidacionRutas's curValorGalon value
		private decimal? m_curValorGalon;

		// Field for storing the LiquidacionRutas's CombustibleCarretera value
		private decimal? m_CombustibleCarretera;

		// Field for storing the LiquidacionRutas's cutCombustible value
		private decimal? m_cutCombustible;

		// Field for storing the LiquidacionRutas's LogAnticipoACPM value
		private bool? m_LogAnticipoACPM;

		// Field for storing the LiquidacionRutas's cutValorAnticipo value
		private decimal? m_cutValorAnticipo;

		// Field for storing the LiquidacionRutas's lngIdNroPeajes value
		private int? m_lngIdNroPeajes;

		// Field for storing the LiquidacionRutas's cutPeaje value
		private decimal? m_cutPeaje;

		// Field for storing the LiquidacionRutas's strNombrePeajes value
		private string m_strNombrePeajes;

		// Field for storing the LiquidacionRutas's cutVariosLlantas value
		private decimal? m_cutVariosLlantas;

		// Field for storing the LiquidacionRutas's cutVariosCelada value
		private decimal? m_cutVariosCelada;

		// Field for storing the LiquidacionRutas's cutVariosPropina value
		private decimal? m_cutVariosPropina;

		// Field for storing the LiquidacionRutas's cutVarios value
		private decimal? m_cutVarios;

		// Field for storing the LiquidacionRutas's cutVariosLlantasVacio value
		private decimal? m_cutVariosLlantasVacio;

		// Field for storing the LiquidacionRutas's cutVariosCeladaVacio value
		private decimal? m_cutVariosCeladaVacio;

		// Field for storing the LiquidacionRutas's cutVariosPropinaVacio value
		private decimal? m_cutVariosPropinaVacio;

		// Field for storing the LiquidacionRutas's cutVariosVacio value
		private decimal? m_cutVariosVacio;

		// Field for storing the LiquidacionRutas's cutParticipacion value
		private decimal? m_cutParticipacion;

		// Field for storing the LiquidacionRutas's cutParticipacionVacio value
		private decimal? m_cutParticipacionVacio;

		// Field for storing the LiquidacionRutas's curHotelCarretera value
		private int? m_curHotelCarretera;

		// Field for storing the LiquidacionRutas's curHotelCiudad value
		private int? m_curHotelCiudad;

		// Field for storing the LiquidacionRutas's curHotel value
		private decimal? m_curHotel;

		// Field for storing the LiquidacionRutas's curHotelCarreteraVacio value
		private int? m_curHotelCarreteraVacio;

		// Field for storing the LiquidacionRutas's curHotelCiudadVacio value
		private int? m_curHotelCiudadVacio;

		// Field for storing the LiquidacionRutas's curHotelVacio value
		private decimal? m_curHotelVacio;

		// Field for storing the LiquidacionRutas's intTiempoCargue value
		private decimal? m_intTiempoCargue;

		// Field for storing the LiquidacionRutas's intTiempoDescargue value
		private decimal? m_intTiempoDescargue;

		// Field for storing the LiquidacionRutas's intTiempoAduana value
		private decimal? m_intTiempoAduana;

		// Field for storing the LiquidacionRutas's intTotalTrayecto value
		private decimal? m_intTotalTrayecto;

		// Field for storing the LiquidacionRutas's intTotalTiempo value
		private decimal? m_intTotalTiempo;

		// Field for storing the LiquidacionRutas's curComida value
		private decimal? m_curComida;

		// Field for storing the LiquidacionRutas's intTiempoCargueVacio value
		private decimal? m_intTiempoCargueVacio;

		// Field for storing the LiquidacionRutas's intTiempoDescargueVacio value
		private decimal? m_intTiempoDescargueVacio;

		// Field for storing the LiquidacionRutas's intTiempoAduanaVacio value
		private decimal? m_intTiempoAduanaVacio;

		// Field for storing the LiquidacionRutas's intTotalTrayectoVacio value
		private decimal? m_intTotalTrayectoVacio;

		// Field for storing the LiquidacionRutas's intTotalTiempoVacio value
		private decimal? m_intTotalTiempoVacio;

		// Field for storing the LiquidacionRutas's curComidaVacio value
		private decimal? m_curComidaVacio;

		// Field for storing the LiquidacionRutas's curDesvareManoRepuestos value
		private decimal? m_curDesvareManoRepuestos;

		// Field for storing the LiquidacionRutas's curDesvareManoObra value
		private decimal? m_curDesvareManoObra;

		// Field for storing the LiquidacionRutas's cutSaldo value
		private decimal? m_cutSaldo;

		// Field for storing the LiquidacionRutas's cutKmts value
		private decimal? m_cutKmts;

		// Field for storing the LiquidacionRutas's logAjuste value
		private bool? m_logAjuste;

		// Field for storing the LiquidacionRutas's dtmFechaModif value
		private DateTime? m_dtmFechaModif;

		// Field for storing the LiquidacionRutas's logVacio value
		private bool? m_logVacio;

		// Field for storing the LiquidacionRutas's TipoVehiculoCodigo value
		private int? m_TipoVehiculoCodigo;

		// Field for storing the LiquidacionRutas's TipoVehiculo value
		private string m_TipoVehiculo;

		// Field for storing the LiquidacionRutas's TipoTrailerCodigo value
		private int? m_TipoTrailerCodigo;

		// Field for storing the LiquidacionRutas's Peso value
		private int? m_Peso;

		// Field for storing the LiquidacionRutas's Contenedor1 value
		private string m_Contenedor1;

		// Field for storing the LiquidacionRutas's Contenedor2 value
		private string m_Contenedor2;

		// Field for storing the LiquidacionRutas's FactorCalculoDia value
		private int? m_FactorCalculoDia;

		// Field for storing the LiquidacionRutas's ValorCalculoFactor value
		private decimal? m_ValorCalculoFactor;

		// Field for storing the LiquidacionRutas's ParqueaderoCarretera value
		private decimal? m_ParqueaderoCarretera;

		// Field for storing the LiquidacionRutas's ParqueaderoCiudad value
		private decimal? m_ParqueaderoCiudad;

		// Field for storing the LiquidacionRutas's MontadaLLantaCarretera value
		private decimal? m_MontadaLLantaCarretera;

		// Field for storing the LiquidacionRutas's MontadaLLantaCiudad value
		private decimal? m_MontadaLLantaCiudad;

		// Field for storing the LiquidacionRutas's AjusteCarretera value
		private decimal? m_AjusteCarretera;

		// Field for storing the LiquidacionRutas's Taxi value
		private decimal? m_Taxi;

		// Field for storing the LiquidacionRutas's Aseo value
		private decimal? m_Aseo;

		// Field for storing the LiquidacionRutas's Amarres value
		private decimal? m_Amarres;

		// Field for storing the LiquidacionRutas's Engradasa value
		private decimal? m_Engradasa;

		// Field for storing the LiquidacionRutas's Calibrada value
		private decimal? m_Calibrada;

		// Field for storing the LiquidacionRutas's Liquidado value
		private bool? m_Liquidado;

		// Field for storing the LiquidacionRutas's Lavada value
		private decimal? m_Lavada;

		// Field for storing the LiquidacionRutas's logEstadoRuta value
		private bool? m_logEstadoRuta;

		// Field for storing the LiquidacionRutas's Papeleria value
		private decimal? m_Papeleria;

		// Field for storing the LiquidacionRutas's logFavorito value
		private bool? m_logFavorito;

		// Field for storing the LiquidacionRutas's CurCargue value
		private decimal? m_CurCargue;

		// Field for storing the LiquidacionRutas's CurDescargue value
		private decimal? m_CurDescargue;

		// Field for storing the LiquidacionRutas's logLiquParticipacion value
		private bool? m_logLiquParticipacion;

		// Evaluate changed state
		private bool m_changed=false;
		// Field for storing the reference to LiquidacionVehiculo accessed by lngIdRegistro
		private LiquidacionVehiculo m_LiquidacionVehiculo;

		// Field for storing the reference to foreign LiquidacionGastosList object accessed by lngIdRegistrRutaItemId
		private LiquidacionGastosList m_LiquidacionGastos;


		#endregion

		#region Attributes

		// Return if object changed
		public bool Changed
		{
			get { return m_changed;}
			set { m_changed=value;}
		}
		/// <summary>
		/// Attribute for access the LiquidacionRutas's lngIdRegistrRutaItemId value (long)
		/// </summary>
		[DataMember]
		public long lngIdRegistrRutaItemId
		{
			get { return m_lngIdRegistrRutaItemId; }
			set 
			{
				m_changed=true;
				m_lngIdRegistrRutaItemId = value;
			}
		}

		/// <summary>
		/// Attribute for access the LiquidacionRutas's lngIdRegistrRuta value (long)
		/// </summary>
		[DataMember]
		public long? lngIdRegistrRuta
		{
			get { return m_lngIdRegistrRuta; }
			set 
			{
				m_changed=true;
				m_lngIdRegistrRuta = value;
			}
		}

		/// <summary>
		/// Attribute for access the LiquidacionRutas's lngIdRegistro value (long)
		/// </summary>
		[DataMember]
		public long? lngIdRegistro
		{
			get { return m_lngIdRegistro; }
			set
			{
				m_changed=true;
				m_lngIdRegistro = value;

				if ((m_LiquidacionVehiculo != null) && (m_LiquidacionVehiculo.lngIdRegistro != m_lngIdRegistro))
				{
					// we need to reset the reference because it is now invalid
					m_LiquidacionVehiculo = null;
				}
			}
		}

		/// <summary>
		/// Attribute for access the LiquidacionRutas's lngIdRegistrRutaItemIdAjc value (long)
		/// </summary>
		[DataMember]
		public long? lngIdRegistrRutaItemIdAjc
		{
			get { return m_lngIdRegistrRutaItemIdAjc; }
			set 
			{
				m_changed=true;
				m_lngIdRegistrRutaItemIdAjc = value;
			}
		}

		/// <summary>
		/// Attribute for access the LiquidacionRutas's strRutaAnticipoGrupoOrigen value (string)
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
		/// Attribute for access the LiquidacionRutas's strRutaAnticipoGrupoDestino value (string)
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
		/// Attribute for access the LiquidacionRutas's strRutaAnticipoGrupo value (string)
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
		/// Attribute for access the LiquidacionRutas's strRutaAnticipo value (string)
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
		/// Attribute for access the LiquidacionRutas's logLiquidado value (bool)
		/// </summary>
		[DataMember]
		public bool? logLiquidado
		{
			get { return m_logLiquidado; }
			set 
			{
				m_changed=true;
				m_logLiquidado = value;
			}
		}

		/// <summary>
		/// Attribute for access the LiquidacionRutas's PlacaTrayler value (string)
		/// </summary>
		[DataMember]
		public string PlacaTrayler
		{
			get { return m_PlacaTrayler; }
			set 
			{
				m_changed=true;
				m_PlacaTrayler = value;
			}
		}

		/// <summary>
		/// Attribute for access the LiquidacionRutas's Trailer value (string)
		/// </summary>
		[DataMember]
		public string Trailer
		{
			get { return m_Trailer; }
			set 
			{
				m_changed=true;
				m_Trailer = value;
			}
		}

		/// <summary>
		/// Attribute for access the LiquidacionRutas's floGalones value (decimal)
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
		/// Attribute for access the LiquidacionRutas's floGalonesReales value (decimal)
		/// </summary>
		[DataMember]
		public decimal? floGalonesReales
		{
			get { return m_floGalonesReales; }
			set 
			{
				m_changed=true;
				m_floGalonesReales = value;
			}
		}

		/// <summary>
		/// Attribute for access the LiquidacionRutas's floGalonesReserva value (decimal)
		/// </summary>
		[DataMember]
		public decimal? floGalonesReserva
		{
			get { return m_floGalonesReserva; }
			set 
			{
				m_changed=true;
				m_floGalonesReserva = value;
			}
		}

		/// <summary>
		/// Attribute for access the LiquidacionRutas's curValorGalon value (decimal)
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
		/// Attribute for access the LiquidacionRutas's CombustibleCarretera value (decimal)
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
		/// Attribute for access the LiquidacionRutas's cutCombustible value (decimal)
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
		/// Attribute for access the LiquidacionRutas's LogAnticipoACPM value (bool)
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

		/// <summary>
		/// Attribute for access the LiquidacionRutas's cutValorAnticipo value (decimal)
		/// </summary>
		[DataMember]
		public decimal? cutValorAnticipo
		{
			get { return m_cutValorAnticipo; }
			set 
			{
				m_changed=true;
				m_cutValorAnticipo = value;
			}
		}

		/// <summary>
		/// Attribute for access the LiquidacionRutas's lngIdNroPeajes value (int)
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
		/// Attribute for access the LiquidacionRutas's cutPeaje value (decimal)
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
		/// Attribute for access the LiquidacionRutas's strNombrePeajes value (string)
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
		/// Attribute for access the LiquidacionRutas's cutVariosLlantas value (decimal)
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
		/// Attribute for access the LiquidacionRutas's cutVariosCelada value (decimal)
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
		/// Attribute for access the LiquidacionRutas's cutVariosPropina value (decimal)
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
		/// Attribute for access the LiquidacionRutas's cutVarios value (decimal)
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
		/// Attribute for access the LiquidacionRutas's cutVariosLlantasVacio value (decimal)
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
		/// Attribute for access the LiquidacionRutas's cutVariosCeladaVacio value (decimal)
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
		/// Attribute for access the LiquidacionRutas's cutVariosPropinaVacio value (decimal)
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
		/// Attribute for access the LiquidacionRutas's cutVariosVacio value (decimal)
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
		/// Attribute for access the LiquidacionRutas's cutParticipacion value (decimal)
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
		/// Attribute for access the LiquidacionRutas's cutParticipacionVacio value (decimal)
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
		/// Attribute for access the LiquidacionRutas's curHotelCarretera value (int)
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
		/// Attribute for access the LiquidacionRutas's curHotelCiudad value (int)
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
		/// Attribute for access the LiquidacionRutas's curHotel value (decimal)
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
		/// Attribute for access the LiquidacionRutas's curHotelCarreteraVacio value (int)
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
		/// Attribute for access the LiquidacionRutas's curHotelCiudadVacio value (int)
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
		/// Attribute for access the LiquidacionRutas's curHotelVacio value (decimal)
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
		/// Attribute for access the LiquidacionRutas's intTiempoCargue value (decimal)
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
		/// Attribute for access the LiquidacionRutas's intTiempoDescargue value (decimal)
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
		/// Attribute for access the LiquidacionRutas's intTiempoAduana value (decimal)
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
		/// Attribute for access the LiquidacionRutas's intTotalTrayecto value (decimal)
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
		/// Attribute for access the LiquidacionRutas's intTotalTiempo value (decimal)
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
		/// Attribute for access the LiquidacionRutas's curComida value (decimal)
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
		/// Attribute for access the LiquidacionRutas's intTiempoCargueVacio value (decimal)
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
		/// Attribute for access the LiquidacionRutas's intTiempoDescargueVacio value (decimal)
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
		/// Attribute for access the LiquidacionRutas's intTiempoAduanaVacio value (decimal)
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
		/// Attribute for access the LiquidacionRutas's intTotalTrayectoVacio value (decimal)
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
		/// Attribute for access the LiquidacionRutas's intTotalTiempoVacio value (decimal)
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
		/// Attribute for access the LiquidacionRutas's curComidaVacio value (decimal)
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
		/// Attribute for access the LiquidacionRutas's curDesvareManoRepuestos value (decimal)
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
		/// Attribute for access the LiquidacionRutas's curDesvareManoObra value (decimal)
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
		/// Attribute for access the LiquidacionRutas's cutSaldo value (decimal)
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
		/// Attribute for access the LiquidacionRutas's cutKmts value (decimal)
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
		/// Attribute for access the LiquidacionRutas's logAjuste value (bool)
		/// </summary>
		[DataMember]
		public bool? logAjuste
		{
			get { return m_logAjuste; }
			set 
			{
				m_changed=true;
				m_logAjuste = value;
			}
		}

		/// <summary>
		/// Attribute for access the LiquidacionRutas's dtmFechaModif value (DateTime)
		/// </summary>
		[DataMember]
		public DateTime? dtmFechaModif
		{
			get { return m_dtmFechaModif; }
			set 
			{
				m_changed=true;
				m_dtmFechaModif = value;
			}
		}

		/// <summary>
		/// Attribute for access the LiquidacionRutas's logVacio value (bool)
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
		/// Attribute for access the LiquidacionRutas's TipoVehiculoCodigo value (int)
		/// </summary>
		[DataMember]
		public int? TipoVehiculoCodigo
		{
			get { return m_TipoVehiculoCodigo; }
			set 
			{
				m_changed=true;
				m_TipoVehiculoCodigo = value;
			}
		}

		/// <summary>
		/// Attribute for access the LiquidacionRutas's TipoVehiculo value (string)
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
		/// Attribute for access the LiquidacionRutas's TipoTrailerCodigo value (int)
		/// </summary>
		[DataMember]
		public int? TipoTrailerCodigo
		{
			get { return m_TipoTrailerCodigo; }
			set 
			{
				m_changed=true;
				m_TipoTrailerCodigo = value;
			}
		}

		/// <summary>
		/// Attribute for access the LiquidacionRutas's Peso value (int)
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
		/// Attribute for access the LiquidacionRutas's Contenedor1 value (string)
		/// </summary>
		[DataMember]
		public string Contenedor1
		{
			get { return m_Contenedor1; }
			set 
			{
				m_changed=true;
				m_Contenedor1 = value;
			}
		}

		/// <summary>
		/// Attribute for access the LiquidacionRutas's Contenedor2 value (string)
		/// </summary>
		[DataMember]
		public string Contenedor2
		{
			get { return m_Contenedor2; }
			set 
			{
				m_changed=true;
				m_Contenedor2 = value;
			}
		}

		/// <summary>
		/// Attribute for access the LiquidacionRutas's FactorCalculoDia value (int)
		/// </summary>
		[DataMember]
		public int? FactorCalculoDia
		{
			get { return m_FactorCalculoDia; }
			set 
			{
				m_changed=true;
				m_FactorCalculoDia = value;
			}
		}

		/// <summary>
		/// Attribute for access the LiquidacionRutas's ValorCalculoFactor value (decimal)
		/// </summary>
		[DataMember]
		public decimal? ValorCalculoFactor
		{
			get { return m_ValorCalculoFactor; }
			set 
			{
				m_changed=true;
				m_ValorCalculoFactor = value;
			}
		}

		/// <summary>
		/// Attribute for access the LiquidacionRutas's ParqueaderoCarretera value (decimal)
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
		/// Attribute for access the LiquidacionRutas's ParqueaderoCiudad value (decimal)
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
		/// Attribute for access the LiquidacionRutas's MontadaLLantaCarretera value (decimal)
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
		/// Attribute for access the LiquidacionRutas's MontadaLLantaCiudad value (decimal)
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
		/// Attribute for access the LiquidacionRutas's AjusteCarretera value (decimal)
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
		/// Attribute for access the LiquidacionRutas's Taxi value (decimal)
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
		/// Attribute for access the LiquidacionRutas's Aseo value (decimal)
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
		/// Attribute for access the LiquidacionRutas's Amarres value (decimal)
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
		/// Attribute for access the LiquidacionRutas's Engradasa value (decimal)
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
		/// Attribute for access the LiquidacionRutas's Calibrada value (decimal)
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
		/// Attribute for access the LiquidacionRutas's Liquidado value (bool)
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
		/// Attribute for access the LiquidacionRutas's Lavada value (decimal)
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
		/// Attribute for access the LiquidacionRutas's logEstadoRuta value (bool)
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
		/// Attribute for access the LiquidacionRutas's Papeleria value (decimal)
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
		/// Attribute for access the LiquidacionRutas's logFavorito value (bool)
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
		/// Attribute for access the LiquidacionRutas's CurCargue value (decimal)
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
		/// Attribute for access the LiquidacionRutas's CurDescargue value (decimal)
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
		/// Attribute for access the LiquidacionRutas's logLiquParticipacion value (bool)
		/// </summary>
		[DataMember]
		public bool? logLiquParticipacion
		{
			get { return m_logLiquParticipacion; }
			set 
			{
				m_changed=true;
				m_logLiquParticipacion = value;
			}
		}

		public object GetAttribute(string pattribute)
		{
			switch (pattribute)
			{
				case "lngIdRegistrRutaItemId": return lngIdRegistrRutaItemId;
				case "lngIdRegistrRuta": return lngIdRegistrRuta;
				case "lngIdRegistro": return lngIdRegistro;
				case "lngIdRegistrRutaItemIdAjc": return lngIdRegistrRutaItemIdAjc;
				case "strRutaAnticipoGrupoOrigen": return strRutaAnticipoGrupoOrigen;
				case "strRutaAnticipoGrupoDestino": return strRutaAnticipoGrupoDestino;
				case "strRutaAnticipoGrupo": return strRutaAnticipoGrupo;
				case "strRutaAnticipo": return strRutaAnticipo;
				case "logLiquidado": return logLiquidado;
				case "PlacaTrayler": return PlacaTrayler;
				case "Trailer": return Trailer;
				case "floGalones": return floGalones;
				case "floGalonesReales": return floGalonesReales;
				case "floGalonesReserva": return floGalonesReserva;
				case "curValorGalon": return curValorGalon;
				case "CombustibleCarretera": return CombustibleCarretera;
				case "cutCombustible": return cutCombustible;
				case "LogAnticipoACPM": return LogAnticipoACPM;
				case "cutValorAnticipo": return cutValorAnticipo;
				case "lngIdNroPeajes": return lngIdNroPeajes;
				case "cutPeaje": return cutPeaje;
				case "strNombrePeajes": return strNombrePeajes;
				case "cutVariosLlantas": return cutVariosLlantas;
				case "cutVariosCelada": return cutVariosCelada;
				case "cutVariosPropina": return cutVariosPropina;
				case "cutVarios": return cutVarios;
				case "cutVariosLlantasVacio": return cutVariosLlantasVacio;
				case "cutVariosCeladaVacio": return cutVariosCeladaVacio;
				case "cutVariosPropinaVacio": return cutVariosPropinaVacio;
				case "cutVariosVacio": return cutVariosVacio;
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
				case "cutKmts": return cutKmts;
				case "logAjuste": return logAjuste;
				case "dtmFechaModif": return dtmFechaModif;
				case "logVacio": return logVacio;
				case "TipoVehiculoCodigo": return TipoVehiculoCodigo;
				case "TipoVehiculo": return TipoVehiculo;
				case "TipoTrailerCodigo": return TipoTrailerCodigo;
				case "Peso": return Peso;
				case "Contenedor1": return Contenedor1;
				case "Contenedor2": return Contenedor2;
				case "FactorCalculoDia": return FactorCalculoDia;
				case "ValorCalculoFactor": return ValorCalculoFactor;
				case "ParqueaderoCarretera": return ParqueaderoCarretera;
				case "ParqueaderoCiudad": return ParqueaderoCiudad;
				case "MontadaLLantaCarretera": return MontadaLLantaCarretera;
				case "MontadaLLantaCiudad": return MontadaLLantaCiudad;
				case "AjusteCarretera": return AjusteCarretera;
				case "Taxi": return Taxi;
				case "Aseo": return Aseo;
				case "Amarres": return Amarres;
				case "Engradasa": return Engradasa;
				case "Calibrada": return Calibrada;
				case "Liquidado": return Liquidado;
				case "Lavada": return Lavada;
				case "logEstadoRuta": return logEstadoRuta;
				case "Papeleria": return Papeleria;
				case "logFavorito": return logFavorito;
				case "CurCargue": return CurCargue;
				case "CurDescargue": return CurDescargue;
				case "logLiquParticipacion": return logLiquParticipacion;
				default: return null;
			}
		}

		public Type GetAttributeType(string pattribute)
		{
			return LiquidacionRutasController.Instance.GetMethodType(pattribute, this);
		}

		public string GetSqlKey()
		{
			return "[lngIdRegistrRutaItemId] = " + lngIdRegistrRutaItemId.ToString();
		}
		/// <summary>
		/// Gets or sets the reference to LiquidacionVehiculo accessed by lngIdRegistro
		/// </summary>
		/// <remarks>
		/// Also updates related field values
		/// </remarks>
		public LiquidacionVehiculo LiquidacionVehiculo
		{
			get
			{
				if (m_LiquidacionVehiculo == null)
				{
					if (m_lngIdRegistro != null)
					{
						m_LiquidacionVehiculo = LiquidacionVehiculoController.Instance.Get((long)m_lngIdRegistro);
					}
				}

				return m_LiquidacionVehiculo;
			}

			set
			{
				m_LiquidacionVehiculo = value;

				if (m_LiquidacionVehiculo != null)
				{
					this.m_lngIdRegistro = m_LiquidacionVehiculo.lngIdRegistro;
				}
			}
		}

		/// <summary>
		/// Gets or sets the reference to foreign LiquidacionGastosList object accessed by lngIdRegistrRutaItemId
		/// </summary>
		public LiquidacionGastosList LiquidacionGastos
		{
			get
			{
				if (m_LiquidacionGastos == null)
				{
					m_LiquidacionGastos = LiquidacionGastosController.Instance.GetBy_lngIdRegistrRutaItemId(lngIdRegistrRutaItemId);
			}

			return m_LiquidacionGastos;
		}
		set { m_LiquidacionGastos = value; }
	}

	#endregion

}

#endregion

#region LiquidacionRutasList object

/// <summary>
/// Class for reading and access a list of LiquidacionRutas object
/// </summary>
[CollectionDataContract]
public partial class LiquidacionRutasList : List<LiquidacionRutas>
{

	/// <summary>
	/// Default constructor
	/// </summary>
	public LiquidacionRutasList()
	{
	}
}

#endregion

}
