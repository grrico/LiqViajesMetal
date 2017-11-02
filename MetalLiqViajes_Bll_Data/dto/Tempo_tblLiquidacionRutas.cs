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
	#region Tempo_tblLiquidacionRutas object

	[DataContract]
	public partial class Tempo_tblLiquidacionRutas : IDTOObject
	{
		/// <summary>
		/// Default constructor
		/// </summary>
		public Tempo_tblLiquidacionRutas()
		{
			m_lngIdRegistrRutaItemId = 0;
			m_lngIdRegistrRuta = null;
			m_lngIdRegistro = null;
			m_strRutaAnticipoGrupoOrigen = null;
			m_strRutaAnticipoGrupoDestino = null;
			m_strRutaAnticipoGrupo = null;
			m_strRutaAnticipo = null;
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
			m_lngIdRegistrRutaItemIdAjc = null;
			m_lngIdUsuario = null;
			m_changed=false;
		}
		        //Return the table name of object
		        public string TableName()
		        {
		            return "tblTempo_tblLiquidacionRutas";
		        }
		#region Undo 
		// Internal class for storing changes
		private Tempo_tblLiquidacionRutas m_oldTempo_tblLiquidacionRutas;
		public void GenerateUndo()
		{
			m_oldTempo_tblLiquidacionRutas=new Tempo_tblLiquidacionRutas();
			m_oldTempo_tblLiquidacionRutas.lngIdRegistrRutaItemId = m_lngIdRegistrRutaItemId;
			m_oldTempo_tblLiquidacionRutas.lngIdRegistrRuta = m_lngIdRegistrRuta;
			m_oldTempo_tblLiquidacionRutas.lngIdRegistro = m_lngIdRegistro;
			m_oldTempo_tblLiquidacionRutas.strRutaAnticipoGrupoOrigen = m_strRutaAnticipoGrupoOrigen;
			m_oldTempo_tblLiquidacionRutas.strRutaAnticipoGrupoDestino = m_strRutaAnticipoGrupoDestino;
			m_oldTempo_tblLiquidacionRutas.strRutaAnticipoGrupo = m_strRutaAnticipoGrupo;
			m_oldTempo_tblLiquidacionRutas.strRutaAnticipo = m_strRutaAnticipo;
			m_oldTempo_tblLiquidacionRutas.floGalones = m_floGalones;
			m_oldTempo_tblLiquidacionRutas.curValorGalon = m_curValorGalon;
			m_oldTempo_tblLiquidacionRutas.cutCombustible = m_cutCombustible;
			m_oldTempo_tblLiquidacionRutas.lngIdNroPeajes = m_lngIdNroPeajes;
			m_oldTempo_tblLiquidacionRutas.cutPeaje = m_cutPeaje;
			m_oldTempo_tblLiquidacionRutas.strNombrePeajes = m_strNombrePeajes;
			m_oldTempo_tblLiquidacionRutas.cutVariosLlantas = m_cutVariosLlantas;
			m_oldTempo_tblLiquidacionRutas.cutVariosCelada = m_cutVariosCelada;
			m_oldTempo_tblLiquidacionRutas.cutVariosPropina = m_cutVariosPropina;
			m_oldTempo_tblLiquidacionRutas.cutVarios = m_cutVarios;
			m_oldTempo_tblLiquidacionRutas.cutVariosLlantasVacio = m_cutVariosLlantasVacio;
			m_oldTempo_tblLiquidacionRutas.cutVariosCeladaVacio = m_cutVariosCeladaVacio;
			m_oldTempo_tblLiquidacionRutas.cutVariosPropinaVacio = m_cutVariosPropinaVacio;
			m_oldTempo_tblLiquidacionRutas.cutVariosVacio = m_cutVariosVacio;
			m_oldTempo_tblLiquidacionRutas.cutParticipacion = m_cutParticipacion;
			m_oldTempo_tblLiquidacionRutas.cutParticipacionVacio = m_cutParticipacionVacio;
			m_oldTempo_tblLiquidacionRutas.curHotelCarretera = m_curHotelCarretera;
			m_oldTempo_tblLiquidacionRutas.curHotelCiudad = m_curHotelCiudad;
			m_oldTempo_tblLiquidacionRutas.curHotel = m_curHotel;
			m_oldTempo_tblLiquidacionRutas.curHotelCarreteraVacio = m_curHotelCarreteraVacio;
			m_oldTempo_tblLiquidacionRutas.curHotelCiudadVacio = m_curHotelCiudadVacio;
			m_oldTempo_tblLiquidacionRutas.curHotelVacio = m_curHotelVacio;
			m_oldTempo_tblLiquidacionRutas.intTiempoCargue = m_intTiempoCargue;
			m_oldTempo_tblLiquidacionRutas.intTiempoDescargue = m_intTiempoDescargue;
			m_oldTempo_tblLiquidacionRutas.intTiempoAduana = m_intTiempoAduana;
			m_oldTempo_tblLiquidacionRutas.intTotalTrayecto = m_intTotalTrayecto;
			m_oldTempo_tblLiquidacionRutas.intTotalTiempo = m_intTotalTiempo;
			m_oldTempo_tblLiquidacionRutas.curComida = m_curComida;
			m_oldTempo_tblLiquidacionRutas.intTiempoCargueVacio = m_intTiempoCargueVacio;
			m_oldTempo_tblLiquidacionRutas.intTiempoDescargueVacio = m_intTiempoDescargueVacio;
			m_oldTempo_tblLiquidacionRutas.intTiempoAduanaVacio = m_intTiempoAduanaVacio;
			m_oldTempo_tblLiquidacionRutas.intTotalTrayectoVacio = m_intTotalTrayectoVacio;
			m_oldTempo_tblLiquidacionRutas.intTotalTiempoVacio = m_intTotalTiempoVacio;
			m_oldTempo_tblLiquidacionRutas.curComidaVacio = m_curComidaVacio;
			m_oldTempo_tblLiquidacionRutas.curDesvareManoRepuestos = m_curDesvareManoRepuestos;
			m_oldTempo_tblLiquidacionRutas.curDesvareManoObra = m_curDesvareManoObra;
			m_oldTempo_tblLiquidacionRutas.cutSaldo = m_cutSaldo;
			m_oldTempo_tblLiquidacionRutas.cutKmts = m_cutKmts;
			m_oldTempo_tblLiquidacionRutas.logAjuste = m_logAjuste;
			m_oldTempo_tblLiquidacionRutas.lngIdRegistrRutaItemIdAjc = m_lngIdRegistrRutaItemIdAjc;
			m_oldTempo_tblLiquidacionRutas.lngIdUsuario = m_lngIdUsuario;
		}

		public Tempo_tblLiquidacionRutas OldTempo_tblLiquidacionRutas
		{
			get { return m_oldTempo_tblLiquidacionRutas;}
		}
		// Return the changed fields
		public string[] FieldChanged()
		{
			List<string> fields=new List<string>();
			if (m_oldTempo_tblLiquidacionRutas.lngIdRegistrRutaItemId != m_lngIdRegistrRutaItemId) fields.Add("lngIdRegistrRutaItemId");
			if (m_oldTempo_tblLiquidacionRutas.lngIdRegistrRuta != m_lngIdRegistrRuta) fields.Add("lngIdRegistrRuta");
			if (m_oldTempo_tblLiquidacionRutas.lngIdRegistro != m_lngIdRegistro) fields.Add("lngIdRegistro");
			if (m_oldTempo_tblLiquidacionRutas.strRutaAnticipoGrupoOrigen != m_strRutaAnticipoGrupoOrigen) fields.Add("strRutaAnticipoGrupoOrigen");
			if (m_oldTempo_tblLiquidacionRutas.strRutaAnticipoGrupoDestino != m_strRutaAnticipoGrupoDestino) fields.Add("strRutaAnticipoGrupoDestino");
			if (m_oldTempo_tblLiquidacionRutas.strRutaAnticipoGrupo != m_strRutaAnticipoGrupo) fields.Add("strRutaAnticipoGrupo");
			if (m_oldTempo_tblLiquidacionRutas.strRutaAnticipo != m_strRutaAnticipo) fields.Add("strRutaAnticipo");
			if (m_oldTempo_tblLiquidacionRutas.floGalones != m_floGalones) fields.Add("floGalones");
			if (m_oldTempo_tblLiquidacionRutas.curValorGalon != m_curValorGalon) fields.Add("curValorGalon");
			if (m_oldTempo_tblLiquidacionRutas.cutCombustible != m_cutCombustible) fields.Add("cutCombustible");
			if (m_oldTempo_tblLiquidacionRutas.lngIdNroPeajes != m_lngIdNroPeajes) fields.Add("lngIdNroPeajes");
			if (m_oldTempo_tblLiquidacionRutas.cutPeaje != m_cutPeaje) fields.Add("cutPeaje");
			if (m_oldTempo_tblLiquidacionRutas.strNombrePeajes != m_strNombrePeajes) fields.Add("strNombrePeajes");
			if (m_oldTempo_tblLiquidacionRutas.cutVariosLlantas != m_cutVariosLlantas) fields.Add("cutVariosLlantas");
			if (m_oldTempo_tblLiquidacionRutas.cutVariosCelada != m_cutVariosCelada) fields.Add("cutVariosCelada");
			if (m_oldTempo_tblLiquidacionRutas.cutVariosPropina != m_cutVariosPropina) fields.Add("cutVariosPropina");
			if (m_oldTempo_tblLiquidacionRutas.cutVarios != m_cutVarios) fields.Add("cutVarios");
			if (m_oldTempo_tblLiquidacionRutas.cutVariosLlantasVacio != m_cutVariosLlantasVacio) fields.Add("cutVariosLlantasVacio");
			if (m_oldTempo_tblLiquidacionRutas.cutVariosCeladaVacio != m_cutVariosCeladaVacio) fields.Add("cutVariosCeladaVacio");
			if (m_oldTempo_tblLiquidacionRutas.cutVariosPropinaVacio != m_cutVariosPropinaVacio) fields.Add("cutVariosPropinaVacio");
			if (m_oldTempo_tblLiquidacionRutas.cutVariosVacio != m_cutVariosVacio) fields.Add("cutVariosVacio");
			if (m_oldTempo_tblLiquidacionRutas.cutParticipacion != m_cutParticipacion) fields.Add("cutParticipacion");
			if (m_oldTempo_tblLiquidacionRutas.cutParticipacionVacio != m_cutParticipacionVacio) fields.Add("cutParticipacionVacio");
			if (m_oldTempo_tblLiquidacionRutas.curHotelCarretera != m_curHotelCarretera) fields.Add("curHotelCarretera");
			if (m_oldTempo_tblLiquidacionRutas.curHotelCiudad != m_curHotelCiudad) fields.Add("curHotelCiudad");
			if (m_oldTempo_tblLiquidacionRutas.curHotel != m_curHotel) fields.Add("curHotel");
			if (m_oldTempo_tblLiquidacionRutas.curHotelCarreteraVacio != m_curHotelCarreteraVacio) fields.Add("curHotelCarreteraVacio");
			if (m_oldTempo_tblLiquidacionRutas.curHotelCiudadVacio != m_curHotelCiudadVacio) fields.Add("curHotelCiudadVacio");
			if (m_oldTempo_tblLiquidacionRutas.curHotelVacio != m_curHotelVacio) fields.Add("curHotelVacio");
			if (m_oldTempo_tblLiquidacionRutas.intTiempoCargue != m_intTiempoCargue) fields.Add("intTiempoCargue");
			if (m_oldTempo_tblLiquidacionRutas.intTiempoDescargue != m_intTiempoDescargue) fields.Add("intTiempoDescargue");
			if (m_oldTempo_tblLiquidacionRutas.intTiempoAduana != m_intTiempoAduana) fields.Add("intTiempoAduana");
			if (m_oldTempo_tblLiquidacionRutas.intTotalTrayecto != m_intTotalTrayecto) fields.Add("intTotalTrayecto");
			if (m_oldTempo_tblLiquidacionRutas.intTotalTiempo != m_intTotalTiempo) fields.Add("intTotalTiempo");
			if (m_oldTempo_tblLiquidacionRutas.curComida != m_curComida) fields.Add("curComida");
			if (m_oldTempo_tblLiquidacionRutas.intTiempoCargueVacio != m_intTiempoCargueVacio) fields.Add("intTiempoCargueVacio");
			if (m_oldTempo_tblLiquidacionRutas.intTiempoDescargueVacio != m_intTiempoDescargueVacio) fields.Add("intTiempoDescargueVacio");
			if (m_oldTempo_tblLiquidacionRutas.intTiempoAduanaVacio != m_intTiempoAduanaVacio) fields.Add("intTiempoAduanaVacio");
			if (m_oldTempo_tblLiquidacionRutas.intTotalTrayectoVacio != m_intTotalTrayectoVacio) fields.Add("intTotalTrayectoVacio");
			if (m_oldTempo_tblLiquidacionRutas.intTotalTiempoVacio != m_intTotalTiempoVacio) fields.Add("intTotalTiempoVacio");
			if (m_oldTempo_tblLiquidacionRutas.curComidaVacio != m_curComidaVacio) fields.Add("curComidaVacio");
			if (m_oldTempo_tblLiquidacionRutas.curDesvareManoRepuestos != m_curDesvareManoRepuestos) fields.Add("curDesvareManoRepuestos");
			if (m_oldTempo_tblLiquidacionRutas.curDesvareManoObra != m_curDesvareManoObra) fields.Add("curDesvareManoObra");
			if (m_oldTempo_tblLiquidacionRutas.cutSaldo != m_cutSaldo) fields.Add("cutSaldo");
			if (m_oldTempo_tblLiquidacionRutas.cutKmts != m_cutKmts) fields.Add("cutKmts");
			if (m_oldTempo_tblLiquidacionRutas.logAjuste != m_logAjuste) fields.Add("logAjuste");
			if (m_oldTempo_tblLiquidacionRutas.lngIdRegistrRutaItemIdAjc != m_lngIdRegistrRutaItemIdAjc) fields.Add("lngIdRegistrRutaItemIdAjc");
			if (m_oldTempo_tblLiquidacionRutas.lngIdUsuario != m_lngIdUsuario) fields.Add("lngIdUsuario");
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


		// Field for storing the Tempo_tblLiquidacionRutas's lngIdRegistrRutaItemId value
		private int m_lngIdRegistrRutaItemId;

		// Field for storing the Tempo_tblLiquidacionRutas's lngIdRegistrRuta value
		private int? m_lngIdRegistrRuta;

		// Field for storing the Tempo_tblLiquidacionRutas's lngIdRegistro value
		private int? m_lngIdRegistro;

		// Field for storing the Tempo_tblLiquidacionRutas's strRutaAnticipoGrupoOrigen value
		private string m_strRutaAnticipoGrupoOrigen;

		// Field for storing the Tempo_tblLiquidacionRutas's strRutaAnticipoGrupoDestino value
		private string m_strRutaAnticipoGrupoDestino;

		// Field for storing the Tempo_tblLiquidacionRutas's strRutaAnticipoGrupo value
		private string m_strRutaAnticipoGrupo;

		// Field for storing the Tempo_tblLiquidacionRutas's strRutaAnticipo value
		private string m_strRutaAnticipo;

		// Field for storing the Tempo_tblLiquidacionRutas's floGalones value
		private decimal? m_floGalones;

		// Field for storing the Tempo_tblLiquidacionRutas's curValorGalon value
		private decimal? m_curValorGalon;

		// Field for storing the Tempo_tblLiquidacionRutas's cutCombustible value
		private decimal? m_cutCombustible;

		// Field for storing the Tempo_tblLiquidacionRutas's lngIdNroPeajes value
		private int? m_lngIdNroPeajes;

		// Field for storing the Tempo_tblLiquidacionRutas's cutPeaje value
		private decimal? m_cutPeaje;

		// Field for storing the Tempo_tblLiquidacionRutas's strNombrePeajes value
		private string m_strNombrePeajes;

		// Field for storing the Tempo_tblLiquidacionRutas's cutVariosLlantas value
		private decimal? m_cutVariosLlantas;

		// Field for storing the Tempo_tblLiquidacionRutas's cutVariosCelada value
		private decimal? m_cutVariosCelada;

		// Field for storing the Tempo_tblLiquidacionRutas's cutVariosPropina value
		private decimal? m_cutVariosPropina;

		// Field for storing the Tempo_tblLiquidacionRutas's cutVarios value
		private decimal? m_cutVarios;

		// Field for storing the Tempo_tblLiquidacionRutas's cutVariosLlantasVacio value
		private decimal? m_cutVariosLlantasVacio;

		// Field for storing the Tempo_tblLiquidacionRutas's cutVariosCeladaVacio value
		private decimal? m_cutVariosCeladaVacio;

		// Field for storing the Tempo_tblLiquidacionRutas's cutVariosPropinaVacio value
		private decimal? m_cutVariosPropinaVacio;

		// Field for storing the Tempo_tblLiquidacionRutas's cutVariosVacio value
		private decimal? m_cutVariosVacio;

		// Field for storing the Tempo_tblLiquidacionRutas's cutParticipacion value
		private decimal? m_cutParticipacion;

		// Field for storing the Tempo_tblLiquidacionRutas's cutParticipacionVacio value
		private decimal? m_cutParticipacionVacio;

		// Field for storing the Tempo_tblLiquidacionRutas's curHotelCarretera value
		private int? m_curHotelCarretera;

		// Field for storing the Tempo_tblLiquidacionRutas's curHotelCiudad value
		private int? m_curHotelCiudad;

		// Field for storing the Tempo_tblLiquidacionRutas's curHotel value
		private decimal? m_curHotel;

		// Field for storing the Tempo_tblLiquidacionRutas's curHotelCarreteraVacio value
		private int? m_curHotelCarreteraVacio;

		// Field for storing the Tempo_tblLiquidacionRutas's curHotelCiudadVacio value
		private int? m_curHotelCiudadVacio;

		// Field for storing the Tempo_tblLiquidacionRutas's curHotelVacio value
		private decimal? m_curHotelVacio;

		// Field for storing the Tempo_tblLiquidacionRutas's intTiempoCargue value
		private decimal? m_intTiempoCargue;

		// Field for storing the Tempo_tblLiquidacionRutas's intTiempoDescargue value
		private decimal? m_intTiempoDescargue;

		// Field for storing the Tempo_tblLiquidacionRutas's intTiempoAduana value
		private decimal? m_intTiempoAduana;

		// Field for storing the Tempo_tblLiquidacionRutas's intTotalTrayecto value
		private decimal? m_intTotalTrayecto;

		// Field for storing the Tempo_tblLiquidacionRutas's intTotalTiempo value
		private decimal? m_intTotalTiempo;

		// Field for storing the Tempo_tblLiquidacionRutas's curComida value
		private decimal? m_curComida;

		// Field for storing the Tempo_tblLiquidacionRutas's intTiempoCargueVacio value
		private decimal? m_intTiempoCargueVacio;

		// Field for storing the Tempo_tblLiquidacionRutas's intTiempoDescargueVacio value
		private decimal? m_intTiempoDescargueVacio;

		// Field for storing the Tempo_tblLiquidacionRutas's intTiempoAduanaVacio value
		private decimal? m_intTiempoAduanaVacio;

		// Field for storing the Tempo_tblLiquidacionRutas's intTotalTrayectoVacio value
		private decimal? m_intTotalTrayectoVacio;

		// Field for storing the Tempo_tblLiquidacionRutas's intTotalTiempoVacio value
		private decimal? m_intTotalTiempoVacio;

		// Field for storing the Tempo_tblLiquidacionRutas's curComidaVacio value
		private decimal? m_curComidaVacio;

		// Field for storing the Tempo_tblLiquidacionRutas's curDesvareManoRepuestos value
		private decimal? m_curDesvareManoRepuestos;

		// Field for storing the Tempo_tblLiquidacionRutas's curDesvareManoObra value
		private decimal? m_curDesvareManoObra;

		// Field for storing the Tempo_tblLiquidacionRutas's cutSaldo value
		private decimal? m_cutSaldo;

		// Field for storing the Tempo_tblLiquidacionRutas's cutKmts value
		private decimal? m_cutKmts;

		// Field for storing the Tempo_tblLiquidacionRutas's logAjuste value
		private bool? m_logAjuste;

		// Field for storing the Tempo_tblLiquidacionRutas's lngIdRegistrRutaItemIdAjc value
		private int? m_lngIdRegistrRutaItemIdAjc;

		// Field for storing the Tempo_tblLiquidacionRutas's lngIdUsuario value
		private int? m_lngIdUsuario;

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
		/// Attribute for access the Tempo_tblLiquidacionRutas's lngIdRegistrRutaItemId value (int)
		/// </summary>
		[DataMember]
		public int lngIdRegistrRutaItemId
		{
			get { return m_lngIdRegistrRutaItemId; }
			set 
			{
				m_changed=true;
				m_lngIdRegistrRutaItemId = value;
			}
		}

		/// <summary>
		/// Attribute for access the Tempo_tblLiquidacionRutas's lngIdRegistrRuta value (int)
		/// </summary>
		[DataMember]
		public int? lngIdRegistrRuta
		{
			get { return m_lngIdRegistrRuta; }
			set 
			{
				m_changed=true;
				m_lngIdRegistrRuta = value;
			}
		}

		/// <summary>
		/// Attribute for access the Tempo_tblLiquidacionRutas's lngIdRegistro value (int)
		/// </summary>
		[DataMember]
		public int? lngIdRegistro
		{
			get { return m_lngIdRegistro; }
			set 
			{
				m_changed=true;
				m_lngIdRegistro = value;
			}
		}

		/// <summary>
		/// Attribute for access the Tempo_tblLiquidacionRutas's strRutaAnticipoGrupoOrigen value (string)
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
		/// Attribute for access the Tempo_tblLiquidacionRutas's strRutaAnticipoGrupoDestino value (string)
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
		/// Attribute for access the Tempo_tblLiquidacionRutas's strRutaAnticipoGrupo value (string)
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
		/// Attribute for access the Tempo_tblLiquidacionRutas's strRutaAnticipo value (string)
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
		/// Attribute for access the Tempo_tblLiquidacionRutas's floGalones value (decimal)
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
		/// Attribute for access the Tempo_tblLiquidacionRutas's curValorGalon value (decimal)
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
		/// Attribute for access the Tempo_tblLiquidacionRutas's cutCombustible value (decimal)
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
		/// Attribute for access the Tempo_tblLiquidacionRutas's lngIdNroPeajes value (int)
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
		/// Attribute for access the Tempo_tblLiquidacionRutas's cutPeaje value (decimal)
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
		/// Attribute for access the Tempo_tblLiquidacionRutas's strNombrePeajes value (string)
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
		/// Attribute for access the Tempo_tblLiquidacionRutas's cutVariosLlantas value (decimal)
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
		/// Attribute for access the Tempo_tblLiquidacionRutas's cutVariosCelada value (decimal)
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
		/// Attribute for access the Tempo_tblLiquidacionRutas's cutVariosPropina value (decimal)
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
		/// Attribute for access the Tempo_tblLiquidacionRutas's cutVarios value (decimal)
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
		/// Attribute for access the Tempo_tblLiquidacionRutas's cutVariosLlantasVacio value (decimal)
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
		/// Attribute for access the Tempo_tblLiquidacionRutas's cutVariosCeladaVacio value (decimal)
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
		/// Attribute for access the Tempo_tblLiquidacionRutas's cutVariosPropinaVacio value (decimal)
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
		/// Attribute for access the Tempo_tblLiquidacionRutas's cutVariosVacio value (decimal)
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
		/// Attribute for access the Tempo_tblLiquidacionRutas's cutParticipacion value (decimal)
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
		/// Attribute for access the Tempo_tblLiquidacionRutas's cutParticipacionVacio value (decimal)
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
		/// Attribute for access the Tempo_tblLiquidacionRutas's curHotelCarretera value (int)
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
		/// Attribute for access the Tempo_tblLiquidacionRutas's curHotelCiudad value (int)
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
		/// Attribute for access the Tempo_tblLiquidacionRutas's curHotel value (decimal)
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
		/// Attribute for access the Tempo_tblLiquidacionRutas's curHotelCarreteraVacio value (int)
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
		/// Attribute for access the Tempo_tblLiquidacionRutas's curHotelCiudadVacio value (int)
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
		/// Attribute for access the Tempo_tblLiquidacionRutas's curHotelVacio value (decimal)
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
		/// Attribute for access the Tempo_tblLiquidacionRutas's intTiempoCargue value (decimal)
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
		/// Attribute for access the Tempo_tblLiquidacionRutas's intTiempoDescargue value (decimal)
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
		/// Attribute for access the Tempo_tblLiquidacionRutas's intTiempoAduana value (decimal)
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
		/// Attribute for access the Tempo_tblLiquidacionRutas's intTotalTrayecto value (decimal)
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
		/// Attribute for access the Tempo_tblLiquidacionRutas's intTotalTiempo value (decimal)
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
		/// Attribute for access the Tempo_tblLiquidacionRutas's curComida value (decimal)
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
		/// Attribute for access the Tempo_tblLiquidacionRutas's intTiempoCargueVacio value (decimal)
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
		/// Attribute for access the Tempo_tblLiquidacionRutas's intTiempoDescargueVacio value (decimal)
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
		/// Attribute for access the Tempo_tblLiquidacionRutas's intTiempoAduanaVacio value (decimal)
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
		/// Attribute for access the Tempo_tblLiquidacionRutas's intTotalTrayectoVacio value (decimal)
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
		/// Attribute for access the Tempo_tblLiquidacionRutas's intTotalTiempoVacio value (decimal)
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
		/// Attribute for access the Tempo_tblLiquidacionRutas's curComidaVacio value (decimal)
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
		/// Attribute for access the Tempo_tblLiquidacionRutas's curDesvareManoRepuestos value (decimal)
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
		/// Attribute for access the Tempo_tblLiquidacionRutas's curDesvareManoObra value (decimal)
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
		/// Attribute for access the Tempo_tblLiquidacionRutas's cutSaldo value (decimal)
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
		/// Attribute for access the Tempo_tblLiquidacionRutas's cutKmts value (decimal)
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
		/// Attribute for access the Tempo_tblLiquidacionRutas's logAjuste value (bool)
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
		/// Attribute for access the Tempo_tblLiquidacionRutas's lngIdRegistrRutaItemIdAjc value (int)
		/// </summary>
		[DataMember]
		public int? lngIdRegistrRutaItemIdAjc
		{
			get { return m_lngIdRegistrRutaItemIdAjc; }
			set 
			{
				m_changed=true;
				m_lngIdRegistrRutaItemIdAjc = value;
			}
		}

		/// <summary>
		/// Attribute for access the Tempo_tblLiquidacionRutas's lngIdUsuario value (int)
		/// </summary>
		[DataMember]
		public int? lngIdUsuario
		{
			get { return m_lngIdUsuario; }
			set 
			{
				m_changed=true;
				m_lngIdUsuario = value;
			}
		}

		public object GetAttribute(string pattribute)
		{
			switch (pattribute)
			{
				case "lngIdRegistrRutaItemId": return lngIdRegistrRutaItemId;
				case "lngIdRegistrRuta": return lngIdRegistrRuta;
				case "lngIdRegistro": return lngIdRegistro;
				case "strRutaAnticipoGrupoOrigen": return strRutaAnticipoGrupoOrigen;
				case "strRutaAnticipoGrupoDestino": return strRutaAnticipoGrupoDestino;
				case "strRutaAnticipoGrupo": return strRutaAnticipoGrupo;
				case "strRutaAnticipo": return strRutaAnticipo;
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
				case "lngIdRegistrRutaItemIdAjc": return lngIdRegistrRutaItemIdAjc;
				case "lngIdUsuario": return lngIdUsuario;
				default: return null;
			}
		}

		public Type GetAttributeType(string pattribute)
		{
			return Tempo_tblLiquidacionRutasController.Instance.GetMethodType(pattribute, this);
		}

		public string GetSqlKey()
		{
			return "";
		}
		#endregion

	}

	#endregion

	#region Tempo_tblLiquidacionRutasList object

	/// <summary>
	/// Class for reading and access a list of Tempo_tblLiquidacionRutas object
	/// </summary>
	[CollectionDataContract]
	public partial class Tempo_tblLiquidacionRutasList : List<Tempo_tblLiquidacionRutas>
	{

		/// <summary>
		/// Default constructor
		/// </summary>
		public Tempo_tblLiquidacionRutasList()
		{
		}
	}

	#endregion

}
