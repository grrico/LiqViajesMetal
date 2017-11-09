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
	#region RutaNueva object

	[DataContract]
	public partial class RutaNueva : IDTOObject
	{
		/// <summary>
		/// Default constructor
		/// </summary>
		public RutaNueva()
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
			m_logViajeVacio = null;
			m_floGalones = null;
			m_curValorGalon = null;
			m_cutCombustible = null;
			m_lngIdNroPeajes = null;
			m_cutPeaje = null;
			m_strNombrePeajes = null;
			m_cutVariosLlantas = null;
			m_cutVariosCelada = null;
			m_cutVariosPropina = null;
			m_cutVarios = null;
			m_Llamadas = null;
			m_Taxis = null;
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
			m_logEstadoRuta = null;
			m_changed=false;
		}
		        //Return the table name of object
		        public string TableName()
		        {
		            return "RutaNueva";
		        }
		#region Undo 
		// Internal class for storing changes
		private RutaNueva m_oldRutaNueva;
		public void GenerateUndo()
		{
			m_oldRutaNueva=new RutaNueva();
			m_oldRutaNueva.m_lngIdRegistrRuta = m_lngIdRegistrRuta;
			m_oldRutaNueva.strRutaAnticipoGrupoOrigen = m_strRutaAnticipoGrupoOrigen;
			m_oldRutaNueva.strRutaAnticipoGrupoDestino = m_strRutaAnticipoGrupoDestino;
			m_oldRutaNueva.strRutaAnticipoGrupo = m_strRutaAnticipoGrupo;
			m_oldRutaNueva.strRutaAnticipo = m_strRutaAnticipo;
			m_oldRutaNueva.TipoVehiculoCodigo = m_TipoVehiculoCodigo;
			m_oldRutaNueva.TipoVehiculo = m_TipoVehiculo;
			m_oldRutaNueva.TipoTrailerCodigo = m_TipoTrailerCodigo;
			m_oldRutaNueva.Peso = m_Peso;
			m_oldRutaNueva.Programa = m_Programa;
			m_oldRutaNueva.logViajeVacio = m_logViajeVacio;
			m_oldRutaNueva.floGalones = m_floGalones;
			m_oldRutaNueva.curValorGalon = m_curValorGalon;
			m_oldRutaNueva.cutCombustible = m_cutCombustible;
			m_oldRutaNueva.lngIdNroPeajes = m_lngIdNroPeajes;
			m_oldRutaNueva.cutPeaje = m_cutPeaje;
			m_oldRutaNueva.strNombrePeajes = m_strNombrePeajes;
			m_oldRutaNueva.cutVariosLlantas = m_cutVariosLlantas;
			m_oldRutaNueva.cutVariosCelada = m_cutVariosCelada;
			m_oldRutaNueva.cutVariosPropina = m_cutVariosPropina;
			m_oldRutaNueva.cutVarios = m_cutVarios;
			m_oldRutaNueva.Llamadas = m_Llamadas;
			m_oldRutaNueva.Taxis = m_Taxis;
			m_oldRutaNueva.Aseo = m_Aseo;
			m_oldRutaNueva.cutVariosLlantasVacio = m_cutVariosLlantasVacio;
			m_oldRutaNueva.cutVariosCeladaVacio = m_cutVariosCeladaVacio;
			m_oldRutaNueva.cutVariosPropinaVacio = m_cutVariosPropinaVacio;
			m_oldRutaNueva.cutVariosVacio = m_cutVariosVacio;
			m_oldRutaNueva.Viaticos = m_Viaticos;
			m_oldRutaNueva.cutParticipacion = m_cutParticipacion;
			m_oldRutaNueva.cutParticipacionVacio = m_cutParticipacionVacio;
			m_oldRutaNueva.curHotelCarretera = m_curHotelCarretera;
			m_oldRutaNueva.curHotelCiudad = m_curHotelCiudad;
			m_oldRutaNueva.curHotel = m_curHotel;
			m_oldRutaNueva.curHotelCarreteraVacio = m_curHotelCarreteraVacio;
			m_oldRutaNueva.curHotelCiudadVacio = m_curHotelCiudadVacio;
			m_oldRutaNueva.curHotelVacio = m_curHotelVacio;
			m_oldRutaNueva.intTiempoCargue = m_intTiempoCargue;
			m_oldRutaNueva.intTiempoDescargue = m_intTiempoDescargue;
			m_oldRutaNueva.intTiempoAduana = m_intTiempoAduana;
			m_oldRutaNueva.intTotalTrayecto = m_intTotalTrayecto;
			m_oldRutaNueva.intTotalTiempo = m_intTotalTiempo;
			m_oldRutaNueva.curComida = m_curComida;
			m_oldRutaNueva.intTiempoCargueVacio = m_intTiempoCargueVacio;
			m_oldRutaNueva.intTiempoDescargueVacio = m_intTiempoDescargueVacio;
			m_oldRutaNueva.intTiempoAduanaVacio = m_intTiempoAduanaVacio;
			m_oldRutaNueva.intTotalTrayectoVacio = m_intTotalTrayectoVacio;
			m_oldRutaNueva.intTotalTiempoVacio = m_intTotalTiempoVacio;
			m_oldRutaNueva.curComidaVacio = m_curComidaVacio;
			m_oldRutaNueva.curDesvareManoRepuestos = m_curDesvareManoRepuestos;
			m_oldRutaNueva.curDesvareManoObra = m_curDesvareManoObra;
			m_oldRutaNueva.cutSaldo = m_cutSaldo;
			m_oldRutaNueva.cutSaldoVacio = m_cutSaldoVacio;
			m_oldRutaNueva.cutKmts = m_cutKmts;
			m_oldRutaNueva.logActualizaPeajes = m_logActualizaPeajes;
			m_oldRutaNueva.intFactorKmPorGalon = m_intFactorKmPorGalon;
			m_oldRutaNueva.logEstadoRuta = m_logEstadoRuta;
		}

		public RutaNueva OldRutaNueva
		{
			get { return m_oldRutaNueva;}
		}
		// Return the changed fields
		public string[] FieldChanged()
		{
			List<string> fields=new List<string>();
			if (m_oldRutaNueva.strRutaAnticipoGrupoOrigen != m_strRutaAnticipoGrupoOrigen) fields.Add("strRutaAnticipoGrupoOrigen");
			if (m_oldRutaNueva.strRutaAnticipoGrupoDestino != m_strRutaAnticipoGrupoDestino) fields.Add("strRutaAnticipoGrupoDestino");
			if (m_oldRutaNueva.strRutaAnticipoGrupo != m_strRutaAnticipoGrupo) fields.Add("strRutaAnticipoGrupo");
			if (m_oldRutaNueva.strRutaAnticipo != m_strRutaAnticipo) fields.Add("strRutaAnticipo");
			if (m_oldRutaNueva.TipoVehiculoCodigo != m_TipoVehiculoCodigo) fields.Add("TipoVehiculoCodigo");
			if (m_oldRutaNueva.TipoVehiculo != m_TipoVehiculo) fields.Add("TipoVehiculo");
			if (m_oldRutaNueva.TipoTrailerCodigo != m_TipoTrailerCodigo) fields.Add("TipoTrailerCodigo");
			if (m_oldRutaNueva.Peso != m_Peso) fields.Add("Peso");
			if (m_oldRutaNueva.Programa != m_Programa) fields.Add("Programa");
			if (m_oldRutaNueva.logViajeVacio != m_logViajeVacio) fields.Add("logViajeVacio");
			if (m_oldRutaNueva.floGalones != m_floGalones) fields.Add("floGalones");
			if (m_oldRutaNueva.curValorGalon != m_curValorGalon) fields.Add("curValorGalon");
			if (m_oldRutaNueva.cutCombustible != m_cutCombustible) fields.Add("cutCombustible");
			if (m_oldRutaNueva.lngIdNroPeajes != m_lngIdNroPeajes) fields.Add("lngIdNroPeajes");
			if (m_oldRutaNueva.cutPeaje != m_cutPeaje) fields.Add("cutPeaje");
			if (m_oldRutaNueva.strNombrePeajes != m_strNombrePeajes) fields.Add("strNombrePeajes");
			if (m_oldRutaNueva.cutVariosLlantas != m_cutVariosLlantas) fields.Add("cutVariosLlantas");
			if (m_oldRutaNueva.cutVariosCelada != m_cutVariosCelada) fields.Add("cutVariosCelada");
			if (m_oldRutaNueva.cutVariosPropina != m_cutVariosPropina) fields.Add("cutVariosPropina");
			if (m_oldRutaNueva.cutVarios != m_cutVarios) fields.Add("cutVarios");
			if (m_oldRutaNueva.Llamadas != m_Llamadas) fields.Add("Llamadas");
			if (m_oldRutaNueva.Taxis != m_Taxis) fields.Add("Taxis");
			if (m_oldRutaNueva.Aseo != m_Aseo) fields.Add("Aseo");
			if (m_oldRutaNueva.cutVariosLlantasVacio != m_cutVariosLlantasVacio) fields.Add("cutVariosLlantasVacio");
			if (m_oldRutaNueva.cutVariosCeladaVacio != m_cutVariosCeladaVacio) fields.Add("cutVariosCeladaVacio");
			if (m_oldRutaNueva.cutVariosPropinaVacio != m_cutVariosPropinaVacio) fields.Add("cutVariosPropinaVacio");
			if (m_oldRutaNueva.cutVariosVacio != m_cutVariosVacio) fields.Add("cutVariosVacio");
			if (m_oldRutaNueva.Viaticos != m_Viaticos) fields.Add("Viaticos");
			if (m_oldRutaNueva.cutParticipacion != m_cutParticipacion) fields.Add("cutParticipacion");
			if (m_oldRutaNueva.cutParticipacionVacio != m_cutParticipacionVacio) fields.Add("cutParticipacionVacio");
			if (m_oldRutaNueva.curHotelCarretera != m_curHotelCarretera) fields.Add("curHotelCarretera");
			if (m_oldRutaNueva.curHotelCiudad != m_curHotelCiudad) fields.Add("curHotelCiudad");
			if (m_oldRutaNueva.curHotel != m_curHotel) fields.Add("curHotel");
			if (m_oldRutaNueva.curHotelCarreteraVacio != m_curHotelCarreteraVacio) fields.Add("curHotelCarreteraVacio");
			if (m_oldRutaNueva.curHotelCiudadVacio != m_curHotelCiudadVacio) fields.Add("curHotelCiudadVacio");
			if (m_oldRutaNueva.curHotelVacio != m_curHotelVacio) fields.Add("curHotelVacio");
			if (m_oldRutaNueva.intTiempoCargue != m_intTiempoCargue) fields.Add("intTiempoCargue");
			if (m_oldRutaNueva.intTiempoDescargue != m_intTiempoDescargue) fields.Add("intTiempoDescargue");
			if (m_oldRutaNueva.intTiempoAduana != m_intTiempoAduana) fields.Add("intTiempoAduana");
			if (m_oldRutaNueva.intTotalTrayecto != m_intTotalTrayecto) fields.Add("intTotalTrayecto");
			if (m_oldRutaNueva.intTotalTiempo != m_intTotalTiempo) fields.Add("intTotalTiempo");
			if (m_oldRutaNueva.curComida != m_curComida) fields.Add("curComida");
			if (m_oldRutaNueva.intTiempoCargueVacio != m_intTiempoCargueVacio) fields.Add("intTiempoCargueVacio");
			if (m_oldRutaNueva.intTiempoDescargueVacio != m_intTiempoDescargueVacio) fields.Add("intTiempoDescargueVacio");
			if (m_oldRutaNueva.intTiempoAduanaVacio != m_intTiempoAduanaVacio) fields.Add("intTiempoAduanaVacio");
			if (m_oldRutaNueva.intTotalTrayectoVacio != m_intTotalTrayectoVacio) fields.Add("intTotalTrayectoVacio");
			if (m_oldRutaNueva.intTotalTiempoVacio != m_intTotalTiempoVacio) fields.Add("intTotalTiempoVacio");
			if (m_oldRutaNueva.curComidaVacio != m_curComidaVacio) fields.Add("curComidaVacio");
			if (m_oldRutaNueva.curDesvareManoRepuestos != m_curDesvareManoRepuestos) fields.Add("curDesvareManoRepuestos");
			if (m_oldRutaNueva.curDesvareManoObra != m_curDesvareManoObra) fields.Add("curDesvareManoObra");
			if (m_oldRutaNueva.cutSaldo != m_cutSaldo) fields.Add("cutSaldo");
			if (m_oldRutaNueva.cutSaldoVacio != m_cutSaldoVacio) fields.Add("cutSaldoVacio");
			if (m_oldRutaNueva.cutKmts != m_cutKmts) fields.Add("cutKmts");
			if (m_oldRutaNueva.logActualizaPeajes != m_logActualizaPeajes) fields.Add("logActualizaPeajes");
			if (m_oldRutaNueva.intFactorKmPorGalon != m_intFactorKmPorGalon) fields.Add("intFactorKmPorGalon");
			if (m_oldRutaNueva.logEstadoRuta != m_logEstadoRuta) fields.Add("logEstadoRuta");
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


		// Field for storing the RutaNueva's lngIdRegistrRuta value
		private int m_lngIdRegistrRuta;

		// Field for storing the RutaNueva's strRutaAnticipoGrupoOrigen value
		private string m_strRutaAnticipoGrupoOrigen;

		// Field for storing the RutaNueva's strRutaAnticipoGrupoDestino value
		private string m_strRutaAnticipoGrupoDestino;

		// Field for storing the RutaNueva's strRutaAnticipoGrupo value
		private string m_strRutaAnticipoGrupo;

		// Field for storing the RutaNueva's strRutaAnticipo value
		private string m_strRutaAnticipo;

		// Field for storing the RutaNueva's TipoVehiculoCodigo value
		private double? m_TipoVehiculoCodigo;

		// Field for storing the RutaNueva's TipoVehiculo value
		private string m_TipoVehiculo;

		// Field for storing the RutaNueva's TipoTrailerCodigo value
		private double? m_TipoTrailerCodigo;

		// Field for storing the RutaNueva's Peso value
		private double? m_Peso;

		// Field for storing the RutaNueva's Programa value
		private string m_Programa;

		// Field for storing the RutaNueva's logViajeVacio value
		private double? m_logViajeVacio;

		// Field for storing the RutaNueva's floGalones value
		private double? m_floGalones;

		// Field for storing the RutaNueva's curValorGalon value
		private double? m_curValorGalon;

		// Field for storing the RutaNueva's cutCombustible value
		private double? m_cutCombustible;

		// Field for storing the RutaNueva's lngIdNroPeajes value
		private double? m_lngIdNroPeajes;

		// Field for storing the RutaNueva's cutPeaje value
		private double? m_cutPeaje;

		// Field for storing the RutaNueva's strNombrePeajes value
		private string m_strNombrePeajes;

		// Field for storing the RutaNueva's cutVariosLlantas value
		private double? m_cutVariosLlantas;

		// Field for storing the RutaNueva's cutVariosCelada value
		private double? m_cutVariosCelada;

		// Field for storing the RutaNueva's cutVariosPropina value
		private double? m_cutVariosPropina;

		// Field for storing the RutaNueva's cutVarios value
		private double? m_cutVarios;

		// Field for storing the RutaNueva's Llamadas value
		private double? m_Llamadas;

		// Field for storing the RutaNueva's Taxis value
		private double? m_Taxis;

		// Field for storing the RutaNueva's Aseo value
		private double? m_Aseo;

		// Field for storing the RutaNueva's cutVariosLlantasVacio value
		private double? m_cutVariosLlantasVacio;

		// Field for storing the RutaNueva's cutVariosCeladaVacio value
		private double? m_cutVariosCeladaVacio;

		// Field for storing the RutaNueva's cutVariosPropinaVacio value
		private double? m_cutVariosPropinaVacio;

		// Field for storing the RutaNueva's cutVariosVacio value
		private double? m_cutVariosVacio;

		// Field for storing the RutaNueva's Viaticos value
		private double? m_Viaticos;

		// Field for storing the RutaNueva's cutParticipacion value
		private double? m_cutParticipacion;

		// Field for storing the RutaNueva's cutParticipacionVacio value
		private double? m_cutParticipacionVacio;

		// Field for storing the RutaNueva's curHotelCarretera value
		private double? m_curHotelCarretera;

		// Field for storing the RutaNueva's curHotelCiudad value
		private double? m_curHotelCiudad;

		// Field for storing the RutaNueva's curHotel value
		private double? m_curHotel;

		// Field for storing the RutaNueva's curHotelCarreteraVacio value
		private double? m_curHotelCarreteraVacio;

		// Field for storing the RutaNueva's curHotelCiudadVacio value
		private double? m_curHotelCiudadVacio;

		// Field for storing the RutaNueva's curHotelVacio value
		private double? m_curHotelVacio;

		// Field for storing the RutaNueva's intTiempoCargue value
		private double? m_intTiempoCargue;

		// Field for storing the RutaNueva's intTiempoDescargue value
		private double? m_intTiempoDescargue;

		// Field for storing the RutaNueva's intTiempoAduana value
		private double? m_intTiempoAduana;

		// Field for storing the RutaNueva's intTotalTrayecto value
		private double? m_intTotalTrayecto;

		// Field for storing the RutaNueva's intTotalTiempo value
		private double? m_intTotalTiempo;

		// Field for storing the RutaNueva's curComida value
		private double? m_curComida;

		// Field for storing the RutaNueva's intTiempoCargueVacio value
		private double? m_intTiempoCargueVacio;

		// Field for storing the RutaNueva's intTiempoDescargueVacio value
		private double? m_intTiempoDescargueVacio;

		// Field for storing the RutaNueva's intTiempoAduanaVacio value
		private double? m_intTiempoAduanaVacio;

		// Field for storing the RutaNueva's intTotalTrayectoVacio value
		private double? m_intTotalTrayectoVacio;

		// Field for storing the RutaNueva's intTotalTiempoVacio value
		private double? m_intTotalTiempoVacio;

		// Field for storing the RutaNueva's curComidaVacio value
		private double? m_curComidaVacio;

		// Field for storing the RutaNueva's curDesvareManoRepuestos value
		private double? m_curDesvareManoRepuestos;

		// Field for storing the RutaNueva's curDesvareManoObra value
		private double? m_curDesvareManoObra;

		// Field for storing the RutaNueva's cutSaldo value
		private double? m_cutSaldo;

		// Field for storing the RutaNueva's cutSaldoVacio value
		private double? m_cutSaldoVacio;

		// Field for storing the RutaNueva's cutKmts value
		private double? m_cutKmts;

		// Field for storing the RutaNueva's logActualizaPeajes value
		private double? m_logActualizaPeajes;

		// Field for storing the RutaNueva's intFactorKmPorGalon value
		private double? m_intFactorKmPorGalon;

		// Field for storing the RutaNueva's logEstadoRuta value
		private double? m_logEstadoRuta;

		// Evaluate changed state
		private bool m_changed=false;

		#endregion

		#region Attributes

		// Return if object changed
		public bool Changed
		{
			get { return m_changed;}
			set { m_changed=value;}
		}
		/// <summary>
		/// Attribute for access the RutaNueva's lngIdRegistrRuta value (int)
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
		/// Attribute for access the RutaNueva's strRutaAnticipoGrupoOrigen value (string)
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
		/// Attribute for access the RutaNueva's strRutaAnticipoGrupoDestino value (string)
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
		/// Attribute for access the RutaNueva's strRutaAnticipoGrupo value (string)
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
		/// Attribute for access the RutaNueva's strRutaAnticipo value (string)
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
		/// Attribute for access the RutaNueva's TipoVehiculoCodigo value (double)
		/// </summary>
		[DataMember]
		public double? TipoVehiculoCodigo
		{
			get { return m_TipoVehiculoCodigo; }
			set 
			{
				m_changed=true;
				m_TipoVehiculoCodigo = value;
			}
		}

		/// <summary>
		/// Attribute for access the RutaNueva's TipoVehiculo value (string)
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
		/// Attribute for access the RutaNueva's TipoTrailerCodigo value (double)
		/// </summary>
		[DataMember]
		public double? TipoTrailerCodigo
		{
			get { return m_TipoTrailerCodigo; }
			set 
			{
				m_changed=true;
				m_TipoTrailerCodigo = value;
			}
		}

		/// <summary>
		/// Attribute for access the RutaNueva's Peso value (double)
		/// </summary>
		[DataMember]
		public double? Peso
		{
			get { return m_Peso; }
			set 
			{
				m_changed=true;
				m_Peso = value;
			}
		}

		/// <summary>
		/// Attribute for access the RutaNueva's Programa value (string)
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
		/// Attribute for access the RutaNueva's logViajeVacio value (double)
		/// </summary>
		[DataMember]
		public double? logViajeVacio
		{
			get { return m_logViajeVacio; }
			set 
			{
				m_changed=true;
				m_logViajeVacio = value;
			}
		}

		/// <summary>
		/// Attribute for access the RutaNueva's floGalones value (double)
		/// </summary>
		[DataMember]
		public double? floGalones
		{
			get { return m_floGalones; }
			set 
			{
				m_changed=true;
				m_floGalones = value;
			}
		}

		/// <summary>
		/// Attribute for access the RutaNueva's curValorGalon value (double)
		/// </summary>
		[DataMember]
		public double? curValorGalon
		{
			get { return m_curValorGalon; }
			set 
			{
				m_changed=true;
				m_curValorGalon = value;
			}
		}

		/// <summary>
		/// Attribute for access the RutaNueva's cutCombustible value (double)
		/// </summary>
		[DataMember]
		public double? cutCombustible
		{
			get { return m_cutCombustible; }
			set 
			{
				m_changed=true;
				m_cutCombustible = value;
			}
		}

		/// <summary>
		/// Attribute for access the RutaNueva's lngIdNroPeajes value (double)
		/// </summary>
		[DataMember]
		public double? lngIdNroPeajes
		{
			get { return m_lngIdNroPeajes; }
			set 
			{
				m_changed=true;
				m_lngIdNroPeajes = value;
			}
		}

		/// <summary>
		/// Attribute for access the RutaNueva's cutPeaje value (double)
		/// </summary>
		[DataMember]
		public double? cutPeaje
		{
			get { return m_cutPeaje; }
			set 
			{
				m_changed=true;
				m_cutPeaje = value;
			}
		}

		/// <summary>
		/// Attribute for access the RutaNueva's strNombrePeajes value (string)
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
		/// Attribute for access the RutaNueva's cutVariosLlantas value (double)
		/// </summary>
		[DataMember]
		public double? cutVariosLlantas
		{
			get { return m_cutVariosLlantas; }
			set 
			{
				m_changed=true;
				m_cutVariosLlantas = value;
			}
		}

		/// <summary>
		/// Attribute for access the RutaNueva's cutVariosCelada value (double)
		/// </summary>
		[DataMember]
		public double? cutVariosCelada
		{
			get { return m_cutVariosCelada; }
			set 
			{
				m_changed=true;
				m_cutVariosCelada = value;
			}
		}

		/// <summary>
		/// Attribute for access the RutaNueva's cutVariosPropina value (double)
		/// </summary>
		[DataMember]
		public double? cutVariosPropina
		{
			get { return m_cutVariosPropina; }
			set 
			{
				m_changed=true;
				m_cutVariosPropina = value;
			}
		}

		/// <summary>
		/// Attribute for access the RutaNueva's cutVarios value (double)
		/// </summary>
		[DataMember]
		public double? cutVarios
		{
			get { return m_cutVarios; }
			set 
			{
				m_changed=true;
				m_cutVarios = value;
			}
		}

		/// <summary>
		/// Attribute for access the RutaNueva's Llamadas value (double)
		/// </summary>
		[DataMember]
		public double? Llamadas
		{
			get { return m_Llamadas; }
			set 
			{
				m_changed=true;
				m_Llamadas = value;
			}
		}

		/// <summary>
		/// Attribute for access the RutaNueva's Taxis value (double)
		/// </summary>
		[DataMember]
		public double? Taxis
		{
			get { return m_Taxis; }
			set 
			{
				m_changed=true;
				m_Taxis = value;
			}
		}

		/// <summary>
		/// Attribute for access the RutaNueva's Aseo value (double)
		/// </summary>
		[DataMember]
		public double? Aseo
		{
			get { return m_Aseo; }
			set 
			{
				m_changed=true;
				m_Aseo = value;
			}
		}

		/// <summary>
		/// Attribute for access the RutaNueva's cutVariosLlantasVacio value (double)
		/// </summary>
		[DataMember]
		public double? cutVariosLlantasVacio
		{
			get { return m_cutVariosLlantasVacio; }
			set 
			{
				m_changed=true;
				m_cutVariosLlantasVacio = value;
			}
		}

		/// <summary>
		/// Attribute for access the RutaNueva's cutVariosCeladaVacio value (double)
		/// </summary>
		[DataMember]
		public double? cutVariosCeladaVacio
		{
			get { return m_cutVariosCeladaVacio; }
			set 
			{
				m_changed=true;
				m_cutVariosCeladaVacio = value;
			}
		}

		/// <summary>
		/// Attribute for access the RutaNueva's cutVariosPropinaVacio value (double)
		/// </summary>
		[DataMember]
		public double? cutVariosPropinaVacio
		{
			get { return m_cutVariosPropinaVacio; }
			set 
			{
				m_changed=true;
				m_cutVariosPropinaVacio = value;
			}
		}

		/// <summary>
		/// Attribute for access the RutaNueva's cutVariosVacio value (double)
		/// </summary>
		[DataMember]
		public double? cutVariosVacio
		{
			get { return m_cutVariosVacio; }
			set 
			{
				m_changed=true;
				m_cutVariosVacio = value;
			}
		}

		/// <summary>
		/// Attribute for access the RutaNueva's Viaticos value (double)
		/// </summary>
		[DataMember]
		public double? Viaticos
		{
			get { return m_Viaticos; }
			set 
			{
				m_changed=true;
				m_Viaticos = value;
			}
		}

		/// <summary>
		/// Attribute for access the RutaNueva's cutParticipacion value (double)
		/// </summary>
		[DataMember]
		public double? cutParticipacion
		{
			get { return m_cutParticipacion; }
			set 
			{
				m_changed=true;
				m_cutParticipacion = value;
			}
		}

		/// <summary>
		/// Attribute for access the RutaNueva's cutParticipacionVacio value (double)
		/// </summary>
		[DataMember]
		public double? cutParticipacionVacio
		{
			get { return m_cutParticipacionVacio; }
			set 
			{
				m_changed=true;
				m_cutParticipacionVacio = value;
			}
		}

		/// <summary>
		/// Attribute for access the RutaNueva's curHotelCarretera value (double)
		/// </summary>
		[DataMember]
		public double? curHotelCarretera
		{
			get { return m_curHotelCarretera; }
			set 
			{
				m_changed=true;
				m_curHotelCarretera = value;
			}
		}

		/// <summary>
		/// Attribute for access the RutaNueva's curHotelCiudad value (double)
		/// </summary>
		[DataMember]
		public double? curHotelCiudad
		{
			get { return m_curHotelCiudad; }
			set 
			{
				m_changed=true;
				m_curHotelCiudad = value;
			}
		}

		/// <summary>
		/// Attribute for access the RutaNueva's curHotel value (double)
		/// </summary>
		[DataMember]
		public double? curHotel
		{
			get { return m_curHotel; }
			set 
			{
				m_changed=true;
				m_curHotel = value;
			}
		}

		/// <summary>
		/// Attribute for access the RutaNueva's curHotelCarreteraVacio value (double)
		/// </summary>
		[DataMember]
		public double? curHotelCarreteraVacio
		{
			get { return m_curHotelCarreteraVacio; }
			set 
			{
				m_changed=true;
				m_curHotelCarreteraVacio = value;
			}
		}

		/// <summary>
		/// Attribute for access the RutaNueva's curHotelCiudadVacio value (double)
		/// </summary>
		[DataMember]
		public double? curHotelCiudadVacio
		{
			get { return m_curHotelCiudadVacio; }
			set 
			{
				m_changed=true;
				m_curHotelCiudadVacio = value;
			}
		}

		/// <summary>
		/// Attribute for access the RutaNueva's curHotelVacio value (double)
		/// </summary>
		[DataMember]
		public double? curHotelVacio
		{
			get { return m_curHotelVacio; }
			set 
			{
				m_changed=true;
				m_curHotelVacio = value;
			}
		}

		/// <summary>
		/// Attribute for access the RutaNueva's intTiempoCargue value (double)
		/// </summary>
		[DataMember]
		public double? intTiempoCargue
		{
			get { return m_intTiempoCargue; }
			set 
			{
				m_changed=true;
				m_intTiempoCargue = value;
			}
		}

		/// <summary>
		/// Attribute for access the RutaNueva's intTiempoDescargue value (double)
		/// </summary>
		[DataMember]
		public double? intTiempoDescargue
		{
			get { return m_intTiempoDescargue; }
			set 
			{
				m_changed=true;
				m_intTiempoDescargue = value;
			}
		}

		/// <summary>
		/// Attribute for access the RutaNueva's intTiempoAduana value (double)
		/// </summary>
		[DataMember]
		public double? intTiempoAduana
		{
			get { return m_intTiempoAduana; }
			set 
			{
				m_changed=true;
				m_intTiempoAduana = value;
			}
		}

		/// <summary>
		/// Attribute for access the RutaNueva's intTotalTrayecto value (double)
		/// </summary>
		[DataMember]
		public double? intTotalTrayecto
		{
			get { return m_intTotalTrayecto; }
			set 
			{
				m_changed=true;
				m_intTotalTrayecto = value;
			}
		}

		/// <summary>
		/// Attribute for access the RutaNueva's intTotalTiempo value (double)
		/// </summary>
		[DataMember]
		public double? intTotalTiempo
		{
			get { return m_intTotalTiempo; }
			set 
			{
				m_changed=true;
				m_intTotalTiempo = value;
			}
		}

		/// <summary>
		/// Attribute for access the RutaNueva's curComida value (double)
		/// </summary>
		[DataMember]
		public double? curComida
		{
			get { return m_curComida; }
			set 
			{
				m_changed=true;
				m_curComida = value;
			}
		}

		/// <summary>
		/// Attribute for access the RutaNueva's intTiempoCargueVacio value (double)
		/// </summary>
		[DataMember]
		public double? intTiempoCargueVacio
		{
			get { return m_intTiempoCargueVacio; }
			set 
			{
				m_changed=true;
				m_intTiempoCargueVacio = value;
			}
		}

		/// <summary>
		/// Attribute for access the RutaNueva's intTiempoDescargueVacio value (double)
		/// </summary>
		[DataMember]
		public double? intTiempoDescargueVacio
		{
			get { return m_intTiempoDescargueVacio; }
			set 
			{
				m_changed=true;
				m_intTiempoDescargueVacio = value;
			}
		}

		/// <summary>
		/// Attribute for access the RutaNueva's intTiempoAduanaVacio value (double)
		/// </summary>
		[DataMember]
		public double? intTiempoAduanaVacio
		{
			get { return m_intTiempoAduanaVacio; }
			set 
			{
				m_changed=true;
				m_intTiempoAduanaVacio = value;
			}
		}

		/// <summary>
		/// Attribute for access the RutaNueva's intTotalTrayectoVacio value (double)
		/// </summary>
		[DataMember]
		public double? intTotalTrayectoVacio
		{
			get { return m_intTotalTrayectoVacio; }
			set 
			{
				m_changed=true;
				m_intTotalTrayectoVacio = value;
			}
		}

		/// <summary>
		/// Attribute for access the RutaNueva's intTotalTiempoVacio value (double)
		/// </summary>
		[DataMember]
		public double? intTotalTiempoVacio
		{
			get { return m_intTotalTiempoVacio; }
			set 
			{
				m_changed=true;
				m_intTotalTiempoVacio = value;
			}
		}

		/// <summary>
		/// Attribute for access the RutaNueva's curComidaVacio value (double)
		/// </summary>
		[DataMember]
		public double? curComidaVacio
		{
			get { return m_curComidaVacio; }
			set 
			{
				m_changed=true;
				m_curComidaVacio = value;
			}
		}

		/// <summary>
		/// Attribute for access the RutaNueva's curDesvareManoRepuestos value (double)
		/// </summary>
		[DataMember]
		public double? curDesvareManoRepuestos
		{
			get { return m_curDesvareManoRepuestos; }
			set 
			{
				m_changed=true;
				m_curDesvareManoRepuestos = value;
			}
		}

		/// <summary>
		/// Attribute for access the RutaNueva's curDesvareManoObra value (double)
		/// </summary>
		[DataMember]
		public double? curDesvareManoObra
		{
			get { return m_curDesvareManoObra; }
			set 
			{
				m_changed=true;
				m_curDesvareManoObra = value;
			}
		}

		/// <summary>
		/// Attribute for access the RutaNueva's cutSaldo value (double)
		/// </summary>
		[DataMember]
		public double? cutSaldo
		{
			get { return m_cutSaldo; }
			set 
			{
				m_changed=true;
				m_cutSaldo = value;
			}
		}

		/// <summary>
		/// Attribute for access the RutaNueva's cutSaldoVacio value (double)
		/// </summary>
		[DataMember]
		public double? cutSaldoVacio
		{
			get { return m_cutSaldoVacio; }
			set 
			{
				m_changed=true;
				m_cutSaldoVacio = value;
			}
		}

		/// <summary>
		/// Attribute for access the RutaNueva's cutKmts value (double)
		/// </summary>
		[DataMember]
		public double? cutKmts
		{
			get { return m_cutKmts; }
			set 
			{
				m_changed=true;
				m_cutKmts = value;
			}
		}

		/// <summary>
		/// Attribute for access the RutaNueva's logActualizaPeajes value (double)
		/// </summary>
		[DataMember]
		public double? logActualizaPeajes
		{
			get { return m_logActualizaPeajes; }
			set 
			{
				m_changed=true;
				m_logActualizaPeajes = value;
			}
		}

		/// <summary>
		/// Attribute for access the RutaNueva's intFactorKmPorGalon value (double)
		/// </summary>
		[DataMember]
		public double? intFactorKmPorGalon
		{
			get { return m_intFactorKmPorGalon; }
			set 
			{
				m_changed=true;
				m_intFactorKmPorGalon = value;
			}
		}

		/// <summary>
		/// Attribute for access the RutaNueva's logEstadoRuta value (double)
		/// </summary>
		[DataMember]
		public double? logEstadoRuta
		{
			get { return m_logEstadoRuta; }
			set 
			{
				m_changed=true;
				m_logEstadoRuta = value;
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
				case "lngIdNroPeajes": return lngIdNroPeajes;
				case "cutPeaje": return cutPeaje;
				case "strNombrePeajes": return strNombrePeajes;
				case "cutVariosLlantas": return cutVariosLlantas;
				case "cutVariosCelada": return cutVariosCelada;
				case "cutVariosPropina": return cutVariosPropina;
				case "cutVarios": return cutVarios;
				case "Llamadas": return Llamadas;
				case "Taxis": return Taxis;
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
				default: return null;
			}
		}

		public Type GetAttributeType(string pattribute)
		{
			return RutaNuevaController.Instance.GetMethodType(pattribute, this);
		}

		public string GetSqlKey()
		{
			return "[lngIdRegistrRuta] = " + lngIdRegistrRuta.ToString();
		}
		#endregion

	}

	#endregion

	#region RutaNuevaList object

	/// <summary>
	/// Class for reading and access a list of RutaNueva object
	/// </summary>
	[CollectionDataContract]
	public partial class RutaNuevaList : List<RutaNueva>
	{

		/// <summary>
		/// Default constructor
		/// </summary>
		public RutaNuevaList()
		{
		}
	}

	#endregion

}
