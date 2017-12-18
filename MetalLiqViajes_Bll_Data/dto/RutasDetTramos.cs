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
	#region RutasDetTramos object

	[DataContract]
	public partial class RutasDetTramos : IDTOObject
	{
		/// <summary>
		/// Default constructor
		/// </summary>
		public RutasDetTramos()
		{
			m_Codigo = 0;
			m_logAsigna_Chk_600 = false;
			m_lngIdRegistrRuta = 0;
			m_strRutaAnticipoGrupoOrigen = "";
			m_strRutaAnticipoGrupoDestino = "";
			m_strRutaAnticipo = "";
			m_floGalones = 0;
			m_curValorGalon = 0;
			m_cutCombustible = 0;
			m_lngIdNroPeajes = 0;
			m_cutPeaje = 0;
			m_cutVariosLlantas = 0;
			m_cutVariosCelada = 0;
			m_cutVariosPropina = 0;
			m_cutVarios = 0;
			m_cutVariosLlantasVacio = 0;
			m_cutVariosCeladaVacio = 0;
			m_cutVariosPropinaVacio = 0;
			m_cutVariosVacio = 0;
			m_CurCargue = 0;
			m_CurDescargue = 0;
			m_curHotel = 0;
			m_curHotelCarreteraVacio = 0;
			m_curHotelCiudadVacio = 0;
			m_curHotelVacio = 0;
			m_intTotalTiempo = 0;
			m_curComida = 0;
			m_intTotalTiempoVacio = 0;
			m_curComidaVacio = 0;
			m_cutParticipacion = 0;
			m_cutParticipacionVacio = 0;
			m_curDesvareManoRepuestos = 0;
			m_curDesvareManoObra = 0;
			m_cutKmts = 0;
			m_logVacio = false;
			m_ParqueaderoCarretera = 0;
			m_ParqueaderoCiudad = 0;
			m_MontadaLLantaCarretera = 0;
			m_Papeleria = 0;
			m_AjusteCarretera = 0;
			m_CombustibleCarretera = 0;
			m_Amarres_Amarres_1000 = 0;
			m_Engradasa = 0;
			m_Calibrada = 0;
			m_TipoVehiculoCodigo = 0;
			m_TipoVehiculo = "";
			m_TipoTrailerCodigo = 0;
			m_Peso = 0;
			m_logEstadoRuta = false;
			m_Trailer = "";
			m_Aseo = 0;
			m_Contenedor1 = "";
			m_Contenedor2 = "";
			m_FactorCalculoDia = 0;
			m_ValorCalculoFactor = 0;
			m_Liquidado = false;
			m_Taxi = 0;
			m_logFavorito = false;
			m_logAnticipoACPM = false;
			m_changed=false;
		}
		        //Return the table name of object
		        public string TableName()
		        {
		            return "RutasDetTramos";
		        }
		#region Undo 
		// Internal class for storing changes
		private RutasDetTramos m_oldRutasDetTramos;
		public void GenerateUndo()
		{
			m_oldRutasDetTramos=new RutasDetTramos();
			m_oldRutasDetTramos.m_Codigo = m_Codigo;
			m_oldRutasDetTramos.logAsigna_Chk_600 = m_logAsigna_Chk_600;
			m_oldRutasDetTramos.lngIdRegistrRuta = m_lngIdRegistrRuta;
			m_oldRutasDetTramos.strRutaAnticipoGrupoOrigen = m_strRutaAnticipoGrupoOrigen;
			m_oldRutasDetTramos.strRutaAnticipoGrupoDestino = m_strRutaAnticipoGrupoDestino;
			m_oldRutasDetTramos.strRutaAnticipo = m_strRutaAnticipo;
			m_oldRutasDetTramos.floGalones = m_floGalones;
			m_oldRutasDetTramos.curValorGalon = m_curValorGalon;
			m_oldRutasDetTramos.cutCombustible = m_cutCombustible;
			m_oldRutasDetTramos.lngIdNroPeajes = m_lngIdNroPeajes;
			m_oldRutasDetTramos.cutPeaje = m_cutPeaje;
			m_oldRutasDetTramos.cutVariosLlantas = m_cutVariosLlantas;
			m_oldRutasDetTramos.cutVariosCelada = m_cutVariosCelada;
			m_oldRutasDetTramos.cutVariosPropina = m_cutVariosPropina;
			m_oldRutasDetTramos.cutVarios = m_cutVarios;
			m_oldRutasDetTramos.cutVariosLlantasVacio = m_cutVariosLlantasVacio;
			m_oldRutasDetTramos.cutVariosCeladaVacio = m_cutVariosCeladaVacio;
			m_oldRutasDetTramos.cutVariosPropinaVacio = m_cutVariosPropinaVacio;
			m_oldRutasDetTramos.cutVariosVacio = m_cutVariosVacio;
			m_oldRutasDetTramos.CurCargue = m_CurCargue;
			m_oldRutasDetTramos.CurDescargue = m_CurDescargue;
			m_oldRutasDetTramos.curHotel = m_curHotel;
			m_oldRutasDetTramos.curHotelCarreteraVacio = m_curHotelCarreteraVacio;
			m_oldRutasDetTramos.curHotelCiudadVacio = m_curHotelCiudadVacio;
			m_oldRutasDetTramos.curHotelVacio = m_curHotelVacio;
			m_oldRutasDetTramos.intTotalTiempo = m_intTotalTiempo;
			m_oldRutasDetTramos.curComida = m_curComida;
			m_oldRutasDetTramos.intTotalTiempoVacio = m_intTotalTiempoVacio;
			m_oldRutasDetTramos.curComidaVacio = m_curComidaVacio;
			m_oldRutasDetTramos.cutParticipacion = m_cutParticipacion;
			m_oldRutasDetTramos.cutParticipacionVacio = m_cutParticipacionVacio;
			m_oldRutasDetTramos.curDesvareManoRepuestos = m_curDesvareManoRepuestos;
			m_oldRutasDetTramos.curDesvareManoObra = m_curDesvareManoObra;
			m_oldRutasDetTramos.cutKmts = m_cutKmts;
			m_oldRutasDetTramos.logVacio = m_logVacio;
			m_oldRutasDetTramos.ParqueaderoCarretera = m_ParqueaderoCarretera;
			m_oldRutasDetTramos.ParqueaderoCiudad = m_ParqueaderoCiudad;
			m_oldRutasDetTramos.MontadaLLantaCarretera = m_MontadaLLantaCarretera;
			m_oldRutasDetTramos.Papeleria = m_Papeleria;
			m_oldRutasDetTramos.AjusteCarretera = m_AjusteCarretera;
			m_oldRutasDetTramos.CombustibleCarretera = m_CombustibleCarretera;
			m_oldRutasDetTramos.Amarres_Amarres_1000 = m_Amarres_Amarres_1000;
			m_oldRutasDetTramos.Engradasa = m_Engradasa;
			m_oldRutasDetTramos.Calibrada = m_Calibrada;
			m_oldRutasDetTramos.TipoVehiculoCodigo = m_TipoVehiculoCodigo;
			m_oldRutasDetTramos.TipoVehiculo = m_TipoVehiculo;
			m_oldRutasDetTramos.TipoTrailerCodigo = m_TipoTrailerCodigo;
			m_oldRutasDetTramos.Peso = m_Peso;
			m_oldRutasDetTramos.logEstadoRuta = m_logEstadoRuta;
			m_oldRutasDetTramos.Trailer = m_Trailer;
			m_oldRutasDetTramos.Aseo = m_Aseo;
			m_oldRutasDetTramos.Contenedor1 = m_Contenedor1;
			m_oldRutasDetTramos.Contenedor2 = m_Contenedor2;
			m_oldRutasDetTramos.FactorCalculoDia = m_FactorCalculoDia;
			m_oldRutasDetTramos.ValorCalculoFactor = m_ValorCalculoFactor;
			m_oldRutasDetTramos.Liquidado = m_Liquidado;
			m_oldRutasDetTramos.Taxi = m_Taxi;
			m_oldRutasDetTramos.logFavorito = m_logFavorito;
			m_oldRutasDetTramos.logAnticipoACPM = m_logAnticipoACPM;
		}

		public RutasDetTramos OldRutasDetTramos
		{
			get { return m_oldRutasDetTramos;}
		}
		// Return the changed fields
		public string[] FieldChanged()
		{
			List<string> fields=new List<string>();
			if (m_oldRutasDetTramos.logAsigna_Chk_600 != m_logAsigna_Chk_600) fields.Add("logAsigna_Chk_600");
			if (m_oldRutasDetTramos.lngIdRegistrRuta != m_lngIdRegistrRuta) fields.Add("lngIdRegistrRuta");
			if (m_oldRutasDetTramos.strRutaAnticipoGrupoOrigen != m_strRutaAnticipoGrupoOrigen) fields.Add("strRutaAnticipoGrupoOrigen");
			if (m_oldRutasDetTramos.strRutaAnticipoGrupoDestino != m_strRutaAnticipoGrupoDestino) fields.Add("strRutaAnticipoGrupoDestino");
			if (m_oldRutasDetTramos.strRutaAnticipo != m_strRutaAnticipo) fields.Add("strRutaAnticipo");
			if (m_oldRutasDetTramos.floGalones != m_floGalones) fields.Add("floGalones");
			if (m_oldRutasDetTramos.curValorGalon != m_curValorGalon) fields.Add("curValorGalon");
			if (m_oldRutasDetTramos.cutCombustible != m_cutCombustible) fields.Add("cutCombustible");
			if (m_oldRutasDetTramos.lngIdNroPeajes != m_lngIdNroPeajes) fields.Add("lngIdNroPeajes");
			if (m_oldRutasDetTramos.cutPeaje != m_cutPeaje) fields.Add("cutPeaje");
			if (m_oldRutasDetTramos.cutVariosLlantas != m_cutVariosLlantas) fields.Add("cutVariosLlantas");
			if (m_oldRutasDetTramos.cutVariosCelada != m_cutVariosCelada) fields.Add("cutVariosCelada");
			if (m_oldRutasDetTramos.cutVariosPropina != m_cutVariosPropina) fields.Add("cutVariosPropina");
			if (m_oldRutasDetTramos.cutVarios != m_cutVarios) fields.Add("cutVarios");
			if (m_oldRutasDetTramos.cutVariosLlantasVacio != m_cutVariosLlantasVacio) fields.Add("cutVariosLlantasVacio");
			if (m_oldRutasDetTramos.cutVariosCeladaVacio != m_cutVariosCeladaVacio) fields.Add("cutVariosCeladaVacio");
			if (m_oldRutasDetTramos.cutVariosPropinaVacio != m_cutVariosPropinaVacio) fields.Add("cutVariosPropinaVacio");
			if (m_oldRutasDetTramos.cutVariosVacio != m_cutVariosVacio) fields.Add("cutVariosVacio");
			if (m_oldRutasDetTramos.CurCargue != m_CurCargue) fields.Add("CurCargue");
			if (m_oldRutasDetTramos.CurDescargue != m_CurDescargue) fields.Add("CurDescargue");
			if (m_oldRutasDetTramos.curHotel != m_curHotel) fields.Add("curHotel");
			if (m_oldRutasDetTramos.curHotelCarreteraVacio != m_curHotelCarreteraVacio) fields.Add("curHotelCarreteraVacio");
			if (m_oldRutasDetTramos.curHotelCiudadVacio != m_curHotelCiudadVacio) fields.Add("curHotelCiudadVacio");
			if (m_oldRutasDetTramos.curHotelVacio != m_curHotelVacio) fields.Add("curHotelVacio");
			if (m_oldRutasDetTramos.intTotalTiempo != m_intTotalTiempo) fields.Add("intTotalTiempo");
			if (m_oldRutasDetTramos.curComida != m_curComida) fields.Add("curComida");
			if (m_oldRutasDetTramos.intTotalTiempoVacio != m_intTotalTiempoVacio) fields.Add("intTotalTiempoVacio");
			if (m_oldRutasDetTramos.curComidaVacio != m_curComidaVacio) fields.Add("curComidaVacio");
			if (m_oldRutasDetTramos.cutParticipacion != m_cutParticipacion) fields.Add("cutParticipacion");
			if (m_oldRutasDetTramos.cutParticipacionVacio != m_cutParticipacionVacio) fields.Add("cutParticipacionVacio");
			if (m_oldRutasDetTramos.curDesvareManoRepuestos != m_curDesvareManoRepuestos) fields.Add("curDesvareManoRepuestos");
			if (m_oldRutasDetTramos.curDesvareManoObra != m_curDesvareManoObra) fields.Add("curDesvareManoObra");
			if (m_oldRutasDetTramos.cutKmts != m_cutKmts) fields.Add("cutKmts");
			if (m_oldRutasDetTramos.logVacio != m_logVacio) fields.Add("logVacio");
			if (m_oldRutasDetTramos.ParqueaderoCarretera != m_ParqueaderoCarretera) fields.Add("ParqueaderoCarretera");
			if (m_oldRutasDetTramos.ParqueaderoCiudad != m_ParqueaderoCiudad) fields.Add("ParqueaderoCiudad");
			if (m_oldRutasDetTramos.MontadaLLantaCarretera != m_MontadaLLantaCarretera) fields.Add("MontadaLLantaCarretera");
			if (m_oldRutasDetTramos.Papeleria != m_Papeleria) fields.Add("Papeleria");
			if (m_oldRutasDetTramos.AjusteCarretera != m_AjusteCarretera) fields.Add("AjusteCarretera");
			if (m_oldRutasDetTramos.CombustibleCarretera != m_CombustibleCarretera) fields.Add("CombustibleCarretera");
			if (m_oldRutasDetTramos.Amarres_Amarres_1000 != m_Amarres_Amarres_1000) fields.Add("Amarres_Amarres_1000");
			if (m_oldRutasDetTramos.Engradasa != m_Engradasa) fields.Add("Engradasa");
			if (m_oldRutasDetTramos.Calibrada != m_Calibrada) fields.Add("Calibrada");
			if (m_oldRutasDetTramos.TipoVehiculoCodigo != m_TipoVehiculoCodigo) fields.Add("TipoVehiculoCodigo");
			if (m_oldRutasDetTramos.TipoVehiculo != m_TipoVehiculo) fields.Add("TipoVehiculo");
			if (m_oldRutasDetTramos.TipoTrailerCodigo != m_TipoTrailerCodigo) fields.Add("TipoTrailerCodigo");
			if (m_oldRutasDetTramos.Peso != m_Peso) fields.Add("Peso");
			if (m_oldRutasDetTramos.logEstadoRuta != m_logEstadoRuta) fields.Add("logEstadoRuta");
			if (m_oldRutasDetTramos.Trailer != m_Trailer) fields.Add("Trailer");
			if (m_oldRutasDetTramos.Aseo != m_Aseo) fields.Add("Aseo");
			if (m_oldRutasDetTramos.Contenedor1 != m_Contenedor1) fields.Add("Contenedor1");
			if (m_oldRutasDetTramos.Contenedor2 != m_Contenedor2) fields.Add("Contenedor2");
			if (m_oldRutasDetTramos.FactorCalculoDia != m_FactorCalculoDia) fields.Add("FactorCalculoDia");
			if (m_oldRutasDetTramos.ValorCalculoFactor != m_ValorCalculoFactor) fields.Add("ValorCalculoFactor");
			if (m_oldRutasDetTramos.Liquidado != m_Liquidado) fields.Add("Liquidado");
			if (m_oldRutasDetTramos.Taxi != m_Taxi) fields.Add("Taxi");
			if (m_oldRutasDetTramos.logFavorito != m_logFavorito) fields.Add("logFavorito");
			if (m_oldRutasDetTramos.logAnticipoACPM != m_logAnticipoACPM) fields.Add("logAnticipoACPM");
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


		// Field for storing the RutasDetTramos's Codigo value
		private long m_Codigo;

		// Field for storing the RutasDetTramos's logAsigna_Chk_600 value
		private bool m_logAsigna_Chk_600;

		// Field for storing the RutasDetTramos's lngIdRegistrRuta value
		private long m_lngIdRegistrRuta;

		// Field for storing the RutasDetTramos's strRutaAnticipoGrupoOrigen value
		private string m_strRutaAnticipoGrupoOrigen;

		// Field for storing the RutasDetTramos's strRutaAnticipoGrupoDestino value
		private string m_strRutaAnticipoGrupoDestino;

		// Field for storing the RutasDetTramos's strRutaAnticipo value
		private string m_strRutaAnticipo;

		// Field for storing the RutasDetTramos's floGalones value
		private decimal m_floGalones;

		// Field for storing the RutasDetTramos's curValorGalon value
		private decimal m_curValorGalon;

		// Field for storing the RutasDetTramos's cutCombustible value
		private decimal m_cutCombustible;

		// Field for storing the RutasDetTramos's lngIdNroPeajes value
		private int m_lngIdNroPeajes;

		// Field for storing the RutasDetTramos's cutPeaje value
		private decimal m_cutPeaje;

		// Field for storing the RutasDetTramos's cutVariosLlantas value
		private decimal m_cutVariosLlantas;

		// Field for storing the RutasDetTramos's cutVariosCelada value
		private decimal m_cutVariosCelada;

		// Field for storing the RutasDetTramos's cutVariosPropina value
		private decimal m_cutVariosPropina;

		// Field for storing the RutasDetTramos's cutVarios value
		private decimal m_cutVarios;

		// Field for storing the RutasDetTramos's cutVariosLlantasVacio value
		private decimal m_cutVariosLlantasVacio;

		// Field for storing the RutasDetTramos's cutVariosCeladaVacio value
		private decimal m_cutVariosCeladaVacio;

		// Field for storing the RutasDetTramos's cutVariosPropinaVacio value
		private decimal m_cutVariosPropinaVacio;

		// Field for storing the RutasDetTramos's cutVariosVacio value
		private decimal m_cutVariosVacio;

		// Field for storing the RutasDetTramos's CurCargue value
		private decimal m_CurCargue;

		// Field for storing the RutasDetTramos's CurDescargue value
		private decimal m_CurDescargue;

		// Field for storing the RutasDetTramos's curHotel value
		private decimal m_curHotel;

		// Field for storing the RutasDetTramos's curHotelCarreteraVacio value
		private decimal m_curHotelCarreteraVacio;

		// Field for storing the RutasDetTramos's curHotelCiudadVacio value
		private decimal m_curHotelCiudadVacio;

		// Field for storing the RutasDetTramos's curHotelVacio value
		private decimal m_curHotelVacio;

		// Field for storing the RutasDetTramos's intTotalTiempo value
		private decimal m_intTotalTiempo;

		// Field for storing the RutasDetTramos's curComida value
		private decimal m_curComida;

		// Field for storing the RutasDetTramos's intTotalTiempoVacio value
		private decimal m_intTotalTiempoVacio;

		// Field for storing the RutasDetTramos's curComidaVacio value
		private decimal m_curComidaVacio;

		// Field for storing the RutasDetTramos's cutParticipacion value
		private decimal m_cutParticipacion;

		// Field for storing the RutasDetTramos's cutParticipacionVacio value
		private decimal m_cutParticipacionVacio;

		// Field for storing the RutasDetTramos's curDesvareManoRepuestos value
		private decimal m_curDesvareManoRepuestos;

		// Field for storing the RutasDetTramos's curDesvareManoObra value
		private decimal m_curDesvareManoObra;

		// Field for storing the RutasDetTramos's cutKmts value
		private decimal m_cutKmts;

		// Field for storing the RutasDetTramos's logVacio value
		private bool m_logVacio;

		// Field for storing the RutasDetTramos's ParqueaderoCarretera value
		private decimal m_ParqueaderoCarretera;

		// Field for storing the RutasDetTramos's ParqueaderoCiudad value
		private decimal m_ParqueaderoCiudad;

		// Field for storing the RutasDetTramos's MontadaLLantaCarretera value
		private decimal m_MontadaLLantaCarretera;

		// Field for storing the RutasDetTramos's Papeleria value
		private decimal m_Papeleria;

		// Field for storing the RutasDetTramos's AjusteCarretera value
		private decimal m_AjusteCarretera;

		// Field for storing the RutasDetTramos's CombustibleCarretera value
		private decimal m_CombustibleCarretera;

		// Field for storing the RutasDetTramos's Amarres_Amarres_1000 value
		private decimal m_Amarres_Amarres_1000;

		// Field for storing the RutasDetTramos's Engradasa value
		private decimal m_Engradasa;

		// Field for storing the RutasDetTramos's Calibrada value
		private decimal m_Calibrada;

		// Field for storing the RutasDetTramos's TipoVehiculoCodigo value
		private int m_TipoVehiculoCodigo;

		// Field for storing the RutasDetTramos's TipoVehiculo value
		private string m_TipoVehiculo;

		// Field for storing the RutasDetTramos's TipoTrailerCodigo value
		private int m_TipoTrailerCodigo;

		// Field for storing the RutasDetTramos's Peso value
		private int m_Peso;

		// Field for storing the RutasDetTramos's logEstadoRuta value
		private bool m_logEstadoRuta;

		// Field for storing the RutasDetTramos's Trailer value
		private string m_Trailer;

		// Field for storing the RutasDetTramos's Aseo value
		private decimal m_Aseo;

		// Field for storing the RutasDetTramos's Contenedor1 value
		private string m_Contenedor1;

		// Field for storing the RutasDetTramos's Contenedor2 value
		private string m_Contenedor2;

		// Field for storing the RutasDetTramos's FactorCalculoDia value
		private int m_FactorCalculoDia;

		// Field for storing the RutasDetTramos's ValorCalculoFactor value
		private int m_ValorCalculoFactor;

		// Field for storing the RutasDetTramos's Liquidado value
		private bool m_Liquidado;

		// Field for storing the RutasDetTramos's Taxi value
		private decimal m_Taxi;

		// Field for storing the RutasDetTramos's logFavorito value
		private bool m_logFavorito;

		// Field for storing the RutasDetTramos's logAnticipoACPM value
		private bool m_logAnticipoACPM;

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
		/// Attribute for access the RutasDetTramos's Codigo value (long)
		/// </summary>
		[DataMember]
		public long Codigo
		{
			get { return m_Codigo; }
			set 
			{
				m_changed=true;
				m_Codigo = value;
			}
		}

		/// <summary>
		/// Attribute for access the RutasDetTramos's logAsigna_Chk_600 value (bool)
		/// </summary>
		[DataMember]
		public bool logAsigna_Chk_600
		{
			get { return m_logAsigna_Chk_600; }
			set 
			{
				m_changed=true;
				m_logAsigna_Chk_600 = value;
			}
		}

		/// <summary>
		/// Attribute for access the RutasDetTramos's lngIdRegistrRuta value (long)
		/// </summary>
		[DataMember]
		public long lngIdRegistrRuta
		{
			get { return m_lngIdRegistrRuta; }
			set 
			{
				m_changed=true;
				m_lngIdRegistrRuta = value;
			}
		}

		/// <summary>
		/// Attribute for access the RutasDetTramos's strRutaAnticipoGrupoOrigen value (string)
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
		/// Attribute for access the RutasDetTramos's strRutaAnticipoGrupoDestino value (string)
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
		/// Attribute for access the RutasDetTramos's strRutaAnticipo value (string)
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
		/// Attribute for access the RutasDetTramos's floGalones value (decimal)
		/// </summary>
		[DataMember]
		public decimal floGalones
		{
			get { return m_floGalones; }
			set 
			{
				m_changed=true;
				m_floGalones = value;
			}
		}

		/// <summary>
		/// Attribute for access the RutasDetTramos's curValorGalon value (decimal)
		/// </summary>
		[DataMember]
		public decimal curValorGalon
		{
			get { return m_curValorGalon; }
			set 
			{
				m_changed=true;
				m_curValorGalon = value;
			}
		}

		/// <summary>
		/// Attribute for access the RutasDetTramos's cutCombustible value (decimal)
		/// </summary>
		[DataMember]
		public decimal cutCombustible
		{
			get { return m_cutCombustible; }
			set 
			{
				m_changed=true;
				m_cutCombustible = value;
			}
		}

		/// <summary>
		/// Attribute for access the RutasDetTramos's lngIdNroPeajes value (int)
		/// </summary>
		[DataMember]
		public int lngIdNroPeajes
		{
			get { return m_lngIdNroPeajes; }
			set 
			{
				m_changed=true;
				m_lngIdNroPeajes = value;
			}
		}

		/// <summary>
		/// Attribute for access the RutasDetTramos's cutPeaje value (decimal)
		/// </summary>
		[DataMember]
		public decimal cutPeaje
		{
			get { return m_cutPeaje; }
			set 
			{
				m_changed=true;
				m_cutPeaje = value;
			}
		}

		/// <summary>
		/// Attribute for access the RutasDetTramos's cutVariosLlantas value (decimal)
		/// </summary>
		[DataMember]
		public decimal cutVariosLlantas
		{
			get { return m_cutVariosLlantas; }
			set 
			{
				m_changed=true;
				m_cutVariosLlantas = value;
			}
		}

		/// <summary>
		/// Attribute for access the RutasDetTramos's cutVariosCelada value (decimal)
		/// </summary>
		[DataMember]
		public decimal cutVariosCelada
		{
			get { return m_cutVariosCelada; }
			set 
			{
				m_changed=true;
				m_cutVariosCelada = value;
			}
		}

		/// <summary>
		/// Attribute for access the RutasDetTramos's cutVariosPropina value (decimal)
		/// </summary>
		[DataMember]
		public decimal cutVariosPropina
		{
			get { return m_cutVariosPropina; }
			set 
			{
				m_changed=true;
				m_cutVariosPropina = value;
			}
		}

		/// <summary>
		/// Attribute for access the RutasDetTramos's cutVarios value (decimal)
		/// </summary>
		[DataMember]
		public decimal cutVarios
		{
			get { return m_cutVarios; }
			set 
			{
				m_changed=true;
				m_cutVarios = value;
			}
		}

		/// <summary>
		/// Attribute for access the RutasDetTramos's cutVariosLlantasVacio value (decimal)
		/// </summary>
		[DataMember]
		public decimal cutVariosLlantasVacio
		{
			get { return m_cutVariosLlantasVacio; }
			set 
			{
				m_changed=true;
				m_cutVariosLlantasVacio = value;
			}
		}

		/// <summary>
		/// Attribute for access the RutasDetTramos's cutVariosCeladaVacio value (decimal)
		/// </summary>
		[DataMember]
		public decimal cutVariosCeladaVacio
		{
			get { return m_cutVariosCeladaVacio; }
			set 
			{
				m_changed=true;
				m_cutVariosCeladaVacio = value;
			}
		}

		/// <summary>
		/// Attribute for access the RutasDetTramos's cutVariosPropinaVacio value (decimal)
		/// </summary>
		[DataMember]
		public decimal cutVariosPropinaVacio
		{
			get { return m_cutVariosPropinaVacio; }
			set 
			{
				m_changed=true;
				m_cutVariosPropinaVacio = value;
			}
		}

		/// <summary>
		/// Attribute for access the RutasDetTramos's cutVariosVacio value (decimal)
		/// </summary>
		[DataMember]
		public decimal cutVariosVacio
		{
			get { return m_cutVariosVacio; }
			set 
			{
				m_changed=true;
				m_cutVariosVacio = value;
			}
		}

		/// <summary>
		/// Attribute for access the RutasDetTramos's CurCargue value (decimal)
		/// </summary>
		[DataMember]
		public decimal CurCargue
		{
			get { return m_CurCargue; }
			set 
			{
				m_changed=true;
				m_CurCargue = value;
			}
		}

		/// <summary>
		/// Attribute for access the RutasDetTramos's CurDescargue value (decimal)
		/// </summary>
		[DataMember]
		public decimal CurDescargue
		{
			get { return m_CurDescargue; }
			set 
			{
				m_changed=true;
				m_CurDescargue = value;
			}
		}

		/// <summary>
		/// Attribute for access the RutasDetTramos's curHotel value (decimal)
		/// </summary>
		[DataMember]
		public decimal curHotel
		{
			get { return m_curHotel; }
			set 
			{
				m_changed=true;
				m_curHotel = value;
			}
		}

		/// <summary>
		/// Attribute for access the RutasDetTramos's curHotelCarreteraVacio value (decimal)
		/// </summary>
		[DataMember]
		public decimal curHotelCarreteraVacio
		{
			get { return m_curHotelCarreteraVacio; }
			set 
			{
				m_changed=true;
				m_curHotelCarreteraVacio = value;
			}
		}

		/// <summary>
		/// Attribute for access the RutasDetTramos's curHotelCiudadVacio value (decimal)
		/// </summary>
		[DataMember]
		public decimal curHotelCiudadVacio
		{
			get { return m_curHotelCiudadVacio; }
			set 
			{
				m_changed=true;
				m_curHotelCiudadVacio = value;
			}
		}

		/// <summary>
		/// Attribute for access the RutasDetTramos's curHotelVacio value (decimal)
		/// </summary>
		[DataMember]
		public decimal curHotelVacio
		{
			get { return m_curHotelVacio; }
			set 
			{
				m_changed=true;
				m_curHotelVacio = value;
			}
		}

		/// <summary>
		/// Attribute for access the RutasDetTramos's intTotalTiempo value (decimal)
		/// </summary>
		[DataMember]
		public decimal intTotalTiempo
		{
			get { return m_intTotalTiempo; }
			set 
			{
				m_changed=true;
				m_intTotalTiempo = value;
			}
		}

		/// <summary>
		/// Attribute for access the RutasDetTramos's curComida value (decimal)
		/// </summary>
		[DataMember]
		public decimal curComida
		{
			get { return m_curComida; }
			set 
			{
				m_changed=true;
				m_curComida = value;
			}
		}

		/// <summary>
		/// Attribute for access the RutasDetTramos's intTotalTiempoVacio value (decimal)
		/// </summary>
		[DataMember]
		public decimal intTotalTiempoVacio
		{
			get { return m_intTotalTiempoVacio; }
			set 
			{
				m_changed=true;
				m_intTotalTiempoVacio = value;
			}
		}

		/// <summary>
		/// Attribute for access the RutasDetTramos's curComidaVacio value (decimal)
		/// </summary>
		[DataMember]
		public decimal curComidaVacio
		{
			get { return m_curComidaVacio; }
			set 
			{
				m_changed=true;
				m_curComidaVacio = value;
			}
		}

		/// <summary>
		/// Attribute for access the RutasDetTramos's cutParticipacion value (decimal)
		/// </summary>
		[DataMember]
		public decimal cutParticipacion
		{
			get { return m_cutParticipacion; }
			set 
			{
				m_changed=true;
				m_cutParticipacion = value;
			}
		}

		/// <summary>
		/// Attribute for access the RutasDetTramos's cutParticipacionVacio value (decimal)
		/// </summary>
		[DataMember]
		public decimal cutParticipacionVacio
		{
			get { return m_cutParticipacionVacio; }
			set 
			{
				m_changed=true;
				m_cutParticipacionVacio = value;
			}
		}

		/// <summary>
		/// Attribute for access the RutasDetTramos's curDesvareManoRepuestos value (decimal)
		/// </summary>
		[DataMember]
		public decimal curDesvareManoRepuestos
		{
			get { return m_curDesvareManoRepuestos; }
			set 
			{
				m_changed=true;
				m_curDesvareManoRepuestos = value;
			}
		}

		/// <summary>
		/// Attribute for access the RutasDetTramos's curDesvareManoObra value (decimal)
		/// </summary>
		[DataMember]
		public decimal curDesvareManoObra
		{
			get { return m_curDesvareManoObra; }
			set 
			{
				m_changed=true;
				m_curDesvareManoObra = value;
			}
		}

		/// <summary>
		/// Attribute for access the RutasDetTramos's cutKmts value (decimal)
		/// </summary>
		[DataMember]
		public decimal cutKmts
		{
			get { return m_cutKmts; }
			set 
			{
				m_changed=true;
				m_cutKmts = value;
			}
		}

		/// <summary>
		/// Attribute for access the RutasDetTramos's logVacio value (bool)
		/// </summary>
		[DataMember]
		public bool logVacio
		{
			get { return m_logVacio; }
			set 
			{
				m_changed=true;
				m_logVacio = value;
			}
		}

		/// <summary>
		/// Attribute for access the RutasDetTramos's ParqueaderoCarretera value (decimal)
		/// </summary>
		[DataMember]
		public decimal ParqueaderoCarretera
		{
			get { return m_ParqueaderoCarretera; }
			set 
			{
				m_changed=true;
				m_ParqueaderoCarretera = value;
			}
		}

		/// <summary>
		/// Attribute for access the RutasDetTramos's ParqueaderoCiudad value (decimal)
		/// </summary>
		[DataMember]
		public decimal ParqueaderoCiudad
		{
			get { return m_ParqueaderoCiudad; }
			set 
			{
				m_changed=true;
				m_ParqueaderoCiudad = value;
			}
		}

		/// <summary>
		/// Attribute for access the RutasDetTramos's MontadaLLantaCarretera value (decimal)
		/// </summary>
		[DataMember]
		public decimal MontadaLLantaCarretera
		{
			get { return m_MontadaLLantaCarretera; }
			set 
			{
				m_changed=true;
				m_MontadaLLantaCarretera = value;
			}
		}

		/// <summary>
		/// Attribute for access the RutasDetTramos's Papeleria value (decimal)
		/// </summary>
		[DataMember]
		public decimal Papeleria
		{
			get { return m_Papeleria; }
			set 
			{
				m_changed=true;
				m_Papeleria = value;
			}
		}

		/// <summary>
		/// Attribute for access the RutasDetTramos's AjusteCarretera value (decimal)
		/// </summary>
		[DataMember]
		public decimal AjusteCarretera
		{
			get { return m_AjusteCarretera; }
			set 
			{
				m_changed=true;
				m_AjusteCarretera = value;
			}
		}

		/// <summary>
		/// Attribute for access the RutasDetTramos's CombustibleCarretera value (decimal)
		/// </summary>
		[DataMember]
		public decimal CombustibleCarretera
		{
			get { return m_CombustibleCarretera; }
			set 
			{
				m_changed=true;
				m_CombustibleCarretera = value;
			}
		}

		/// <summary>
		/// Attribute for access the RutasDetTramos's Amarres_Amarres_1000 value (decimal)
		/// </summary>
		[DataMember]
		public decimal Amarres_Amarres_1000
		{
			get { return m_Amarres_Amarres_1000; }
			set 
			{
				m_changed=true;
				m_Amarres_Amarres_1000 = value;
			}
		}

		/// <summary>
		/// Attribute for access the RutasDetTramos's Engradasa value (decimal)
		/// </summary>
		[DataMember]
		public decimal Engradasa
		{
			get { return m_Engradasa; }
			set 
			{
				m_changed=true;
				m_Engradasa = value;
			}
		}

		/// <summary>
		/// Attribute for access the RutasDetTramos's Calibrada value (decimal)
		/// </summary>
		[DataMember]
		public decimal Calibrada
		{
			get { return m_Calibrada; }
			set 
			{
				m_changed=true;
				m_Calibrada = value;
			}
		}

		/// <summary>
		/// Attribute for access the RutasDetTramos's TipoVehiculoCodigo value (int)
		/// </summary>
		[DataMember]
		public int TipoVehiculoCodigo
		{
			get { return m_TipoVehiculoCodigo; }
			set 
			{
				m_changed=true;
				m_TipoVehiculoCodigo = value;
			}
		}

		/// <summary>
		/// Attribute for access the RutasDetTramos's TipoVehiculo value (string)
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
		/// Attribute for access the RutasDetTramos's TipoTrailerCodigo value (int)
		/// </summary>
		[DataMember]
		public int TipoTrailerCodigo
		{
			get { return m_TipoTrailerCodigo; }
			set 
			{
				m_changed=true;
				m_TipoTrailerCodigo = value;
			}
		}

		/// <summary>
		/// Attribute for access the RutasDetTramos's Peso value (int)
		/// </summary>
		[DataMember]
		public int Peso
		{
			get { return m_Peso; }
			set 
			{
				m_changed=true;
				m_Peso = value;
			}
		}

		/// <summary>
		/// Attribute for access the RutasDetTramos's logEstadoRuta value (bool)
		/// </summary>
		[DataMember]
		public bool logEstadoRuta
		{
			get { return m_logEstadoRuta; }
			set 
			{
				m_changed=true;
				m_logEstadoRuta = value;
			}
		}

		/// <summary>
		/// Attribute for access the RutasDetTramos's Trailer value (string)
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
		/// Attribute for access the RutasDetTramos's Aseo value (decimal)
		/// </summary>
		[DataMember]
		public decimal Aseo
		{
			get { return m_Aseo; }
			set 
			{
				m_changed=true;
				m_Aseo = value;
			}
		}

		/// <summary>
		/// Attribute for access the RutasDetTramos's Contenedor1 value (string)
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
		/// Attribute for access the RutasDetTramos's Contenedor2 value (string)
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
		/// Attribute for access the RutasDetTramos's FactorCalculoDia value (int)
		/// </summary>
		[DataMember]
		public int FactorCalculoDia
		{
			get { return m_FactorCalculoDia; }
			set 
			{
				m_changed=true;
				m_FactorCalculoDia = value;
			}
		}

		/// <summary>
		/// Attribute for access the RutasDetTramos's ValorCalculoFactor value (int)
		/// </summary>
		[DataMember]
		public int ValorCalculoFactor
		{
			get { return m_ValorCalculoFactor; }
			set 
			{
				m_changed=true;
				m_ValorCalculoFactor = value;
			}
		}

		/// <summary>
		/// Attribute for access the RutasDetTramos's Liquidado value (bool)
		/// </summary>
		[DataMember]
		public bool Liquidado
		{
			get { return m_Liquidado; }
			set 
			{
				m_changed=true;
				m_Liquidado = value;
			}
		}

		/// <summary>
		/// Attribute for access the RutasDetTramos's Taxi value (decimal)
		/// </summary>
		[DataMember]
		public decimal Taxi
		{
			get { return m_Taxi; }
			set 
			{
				m_changed=true;
				m_Taxi = value;
			}
		}

		/// <summary>
		/// Attribute for access the RutasDetTramos's logFavorito value (bool)
		/// </summary>
		[DataMember]
		public bool logFavorito
		{
			get { return m_logFavorito; }
			set 
			{
				m_changed=true;
				m_logFavorito = value;
			}
		}

		/// <summary>
		/// Attribute for access the RutasDetTramos's logAnticipoACPM value (bool)
		/// </summary>
		[DataMember]
		public bool logAnticipoACPM
		{
			get { return m_logAnticipoACPM; }
			set 
			{
				m_changed=true;
				m_logAnticipoACPM = value;
			}
		}

		public object GetAttribute(string pattribute)
		{
			switch (pattribute)
			{
				case "Codigo": return Codigo;
				case "logAsigna_Chk_600": return logAsigna_Chk_600;
				case "lngIdRegistrRuta": return lngIdRegistrRuta;
				case "strRutaAnticipoGrupoOrigen": return strRutaAnticipoGrupoOrigen;
				case "strRutaAnticipoGrupoDestino": return strRutaAnticipoGrupoDestino;
				case "strRutaAnticipo": return strRutaAnticipo;
				case "floGalones": return floGalones;
				case "curValorGalon": return curValorGalon;
				case "cutCombustible": return cutCombustible;
				case "lngIdNroPeajes": return lngIdNroPeajes;
				case "cutPeaje": return cutPeaje;
				case "cutVariosLlantas": return cutVariosLlantas;
				case "cutVariosCelada": return cutVariosCelada;
				case "cutVariosPropina": return cutVariosPropina;
				case "cutVarios": return cutVarios;
				case "cutVariosLlantasVacio": return cutVariosLlantasVacio;
				case "cutVariosCeladaVacio": return cutVariosCeladaVacio;
				case "cutVariosPropinaVacio": return cutVariosPropinaVacio;
				case "cutVariosVacio": return cutVariosVacio;
				case "CurCargue": return CurCargue;
				case "CurDescargue": return CurDescargue;
				case "curHotel": return curHotel;
				case "curHotelCarreteraVacio": return curHotelCarreteraVacio;
				case "curHotelCiudadVacio": return curHotelCiudadVacio;
				case "curHotelVacio": return curHotelVacio;
				case "intTotalTiempo": return intTotalTiempo;
				case "curComida": return curComida;
				case "intTotalTiempoVacio": return intTotalTiempoVacio;
				case "curComidaVacio": return curComidaVacio;
				case "cutParticipacion": return cutParticipacion;
				case "cutParticipacionVacio": return cutParticipacionVacio;
				case "curDesvareManoRepuestos": return curDesvareManoRepuestos;
				case "curDesvareManoObra": return curDesvareManoObra;
				case "cutKmts": return cutKmts;
				case "logVacio": return logVacio;
				case "ParqueaderoCarretera": return ParqueaderoCarretera;
				case "ParqueaderoCiudad": return ParqueaderoCiudad;
				case "MontadaLLantaCarretera": return MontadaLLantaCarretera;
				case "Papeleria": return Papeleria;
				case "AjusteCarretera": return AjusteCarretera;
				case "CombustibleCarretera": return CombustibleCarretera;
				case "Amarres_Amarres_1000": return Amarres_Amarres_1000;
				case "Engradasa": return Engradasa;
				case "Calibrada": return Calibrada;
				case "TipoVehiculoCodigo": return TipoVehiculoCodigo;
				case "TipoVehiculo": return TipoVehiculo;
				case "TipoTrailerCodigo": return TipoTrailerCodigo;
				case "Peso": return Peso;
				case "logEstadoRuta": return logEstadoRuta;
				case "Trailer": return Trailer;
				case "Aseo": return Aseo;
				case "Contenedor1": return Contenedor1;
				case "Contenedor2": return Contenedor2;
				case "FactorCalculoDia": return FactorCalculoDia;
				case "ValorCalculoFactor": return ValorCalculoFactor;
				case "Liquidado": return Liquidado;
				case "Taxi": return Taxi;
				case "logFavorito": return logFavorito;
				case "logAnticipoACPM": return logAnticipoACPM;
				default: return null;
			}
		}

		public Type GetAttributeType(string pattribute)
		{
			return RutasDetTramosController.Instance.GetMethodType(pattribute, this);
		}

		public string GetSqlKey()
		{
			return "[Codigo] = " + Codigo.ToString();
		}
		#endregion

	}

	#endregion

	#region RutasDetTramosList object

	/// <summary>
	/// Class for reading and access a list of RutasDetTramos object
	/// </summary>
	[CollectionDataContract]
	public partial class RutasDetTramosList : List<RutasDetTramos>
	{

		/// <summary>
		/// Default constructor
		/// </summary>
		public RutasDetTramosList()
		{
		}
	}

	#endregion

}
