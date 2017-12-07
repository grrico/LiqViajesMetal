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
	#region RutasCuentas object

	[DataContract]
	public partial class RutasCuentas : IDTOObject
	{
		/// <summary>
		/// Default constructor
		/// </summary>
		public RutasCuentas()
		{
			m_lngIdRegistrRuta = 0;
			m_cutCombustible = null;
			m_cutPeaje = null;
			m_cutVariosLlantas = null;
			m_cutVariosCelada = null;
			m_cutVariosPropina = null;
			m_cutVarios = null;
			m_cutVariosLlantasVacio = "";
			m_cutVariosCeladaVacio = null;
			m_cutVariosPropinaVacio = null;
			m_cutVariosVacio = null;
			m_cutParticipacion = null;
			m_cutParticipacionVacio = null;
			m_curHotel = null;
			m_curHotelVacio = null;
			m_curComida = null;
			m_curComidaVacio = null;
			m_curDesvareManoRepuestos = null;
			m_curDesvareManoObra = null;
			m_cutSaldo = null;
			m_cutKmts = null;
			m_ParqueaderoCarretera = null;
			m_ParqueaderoCiudad = null;
			m_MontadaLLantaCarretera = null;
			m_Papeleria = null;
			m_AjusteCarretera = null;
			m_Aseo = null;
			m_Amarres = null;
			m_Engradasa = null;
			m_Calibrada = null;
			m_Taxi = null;
			m_Lavada = null;
			m_CombustibleCarretera = null;
			m_CurCargue = null;
			m_CurDescargue = null;
			m_changed=false;
		}
		        //Return the table name of object
		        public string TableName()
		        {
		            return "tblRutasCuentas";
		        }
		#region Undo 
		// Internal class for storing changes
		private RutasCuentas m_oldRutasCuentas;
		public void GenerateUndo()
		{
			m_oldRutasCuentas=new RutasCuentas();
			m_oldRutasCuentas.m_lngIdRegistrRuta = m_lngIdRegistrRuta;
			m_oldRutasCuentas.cutCombustible = m_cutCombustible;
			m_oldRutasCuentas.cutPeaje = m_cutPeaje;
			m_oldRutasCuentas.cutVariosLlantas = m_cutVariosLlantas;
			m_oldRutasCuentas.cutVariosCelada = m_cutVariosCelada;
			m_oldRutasCuentas.cutVariosPropina = m_cutVariosPropina;
			m_oldRutasCuentas.cutVarios = m_cutVarios;
			m_oldRutasCuentas.cutVariosLlantasVacio = m_cutVariosLlantasVacio;
			m_oldRutasCuentas.cutVariosCeladaVacio = m_cutVariosCeladaVacio;
			m_oldRutasCuentas.cutVariosPropinaVacio = m_cutVariosPropinaVacio;
			m_oldRutasCuentas.cutVariosVacio = m_cutVariosVacio;
			m_oldRutasCuentas.cutParticipacion = m_cutParticipacion;
			m_oldRutasCuentas.cutParticipacionVacio = m_cutParticipacionVacio;
			m_oldRutasCuentas.curHotel = m_curHotel;
			m_oldRutasCuentas.curHotelVacio = m_curHotelVacio;
			m_oldRutasCuentas.curComida = m_curComida;
			m_oldRutasCuentas.curComidaVacio = m_curComidaVacio;
			m_oldRutasCuentas.curDesvareManoRepuestos = m_curDesvareManoRepuestos;
			m_oldRutasCuentas.curDesvareManoObra = m_curDesvareManoObra;
			m_oldRutasCuentas.cutSaldo = m_cutSaldo;
			m_oldRutasCuentas.cutKmts = m_cutKmts;
			m_oldRutasCuentas.ParqueaderoCarretera = m_ParqueaderoCarretera;
			m_oldRutasCuentas.ParqueaderoCiudad = m_ParqueaderoCiudad;
			m_oldRutasCuentas.MontadaLLantaCarretera = m_MontadaLLantaCarretera;
			m_oldRutasCuentas.Papeleria = m_Papeleria;
			m_oldRutasCuentas.AjusteCarretera = m_AjusteCarretera;
			m_oldRutasCuentas.Aseo = m_Aseo;
			m_oldRutasCuentas.Amarres = m_Amarres;
			m_oldRutasCuentas.Engradasa = m_Engradasa;
			m_oldRutasCuentas.Calibrada = m_Calibrada;
			m_oldRutasCuentas.Taxi = m_Taxi;
			m_oldRutasCuentas.Lavada = m_Lavada;
			m_oldRutasCuentas.CombustibleCarretera = m_CombustibleCarretera;
			m_oldRutasCuentas.CurCargue = m_CurCargue;
			m_oldRutasCuentas.CurDescargue = m_CurDescargue;
		}

		public RutasCuentas OldRutasCuentas
		{
			get { return m_oldRutasCuentas;}
		}
		// Return the changed fields
		public string[] FieldChanged()
		{
			List<string> fields=new List<string>();
			if (m_oldRutasCuentas.cutCombustible != m_cutCombustible) fields.Add("cutCombustible");
			if (m_oldRutasCuentas.cutPeaje != m_cutPeaje) fields.Add("cutPeaje");
			if (m_oldRutasCuentas.cutVariosLlantas != m_cutVariosLlantas) fields.Add("cutVariosLlantas");
			if (m_oldRutasCuentas.cutVariosCelada != m_cutVariosCelada) fields.Add("cutVariosCelada");
			if (m_oldRutasCuentas.cutVariosPropina != m_cutVariosPropina) fields.Add("cutVariosPropina");
			if (m_oldRutasCuentas.cutVarios != m_cutVarios) fields.Add("cutVarios");
			if (m_oldRutasCuentas.cutVariosLlantasVacio != m_cutVariosLlantasVacio) fields.Add("cutVariosLlantasVacio");
			if (m_oldRutasCuentas.cutVariosCeladaVacio != m_cutVariosCeladaVacio) fields.Add("cutVariosCeladaVacio");
			if (m_oldRutasCuentas.cutVariosPropinaVacio != m_cutVariosPropinaVacio) fields.Add("cutVariosPropinaVacio");
			if (m_oldRutasCuentas.cutVariosVacio != m_cutVariosVacio) fields.Add("cutVariosVacio");
			if (m_oldRutasCuentas.cutParticipacion != m_cutParticipacion) fields.Add("cutParticipacion");
			if (m_oldRutasCuentas.cutParticipacionVacio != m_cutParticipacionVacio) fields.Add("cutParticipacionVacio");
			if (m_oldRutasCuentas.curHotel != m_curHotel) fields.Add("curHotel");
			if (m_oldRutasCuentas.curHotelVacio != m_curHotelVacio) fields.Add("curHotelVacio");
			if (m_oldRutasCuentas.curComida != m_curComida) fields.Add("curComida");
			if (m_oldRutasCuentas.curComidaVacio != m_curComidaVacio) fields.Add("curComidaVacio");
			if (m_oldRutasCuentas.curDesvareManoRepuestos != m_curDesvareManoRepuestos) fields.Add("curDesvareManoRepuestos");
			if (m_oldRutasCuentas.curDesvareManoObra != m_curDesvareManoObra) fields.Add("curDesvareManoObra");
			if (m_oldRutasCuentas.cutSaldo != m_cutSaldo) fields.Add("cutSaldo");
			if (m_oldRutasCuentas.cutKmts != m_cutKmts) fields.Add("cutKmts");
			if (m_oldRutasCuentas.ParqueaderoCarretera != m_ParqueaderoCarretera) fields.Add("ParqueaderoCarretera");
			if (m_oldRutasCuentas.ParqueaderoCiudad != m_ParqueaderoCiudad) fields.Add("ParqueaderoCiudad");
			if (m_oldRutasCuentas.MontadaLLantaCarretera != m_MontadaLLantaCarretera) fields.Add("MontadaLLantaCarretera");
			if (m_oldRutasCuentas.Papeleria != m_Papeleria) fields.Add("Papeleria");
			if (m_oldRutasCuentas.AjusteCarretera != m_AjusteCarretera) fields.Add("AjusteCarretera");
			if (m_oldRutasCuentas.Aseo != m_Aseo) fields.Add("Aseo");
			if (m_oldRutasCuentas.Amarres != m_Amarres) fields.Add("Amarres");
			if (m_oldRutasCuentas.Engradasa != m_Engradasa) fields.Add("Engradasa");
			if (m_oldRutasCuentas.Calibrada != m_Calibrada) fields.Add("Calibrada");
			if (m_oldRutasCuentas.Taxi != m_Taxi) fields.Add("Taxi");
			if (m_oldRutasCuentas.Lavada != m_Lavada) fields.Add("Lavada");
			if (m_oldRutasCuentas.CombustibleCarretera != m_CombustibleCarretera) fields.Add("CombustibleCarretera");
			if (m_oldRutasCuentas.CurCargue != m_CurCargue) fields.Add("CurCargue");
			if (m_oldRutasCuentas.CurDescargue != m_CurDescargue) fields.Add("CurDescargue");
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


		// Field for storing the RutasCuentas's lngIdRegistrRuta value
		private int m_lngIdRegistrRuta;

		// Field for storing the RutasCuentas's cutCombustible value
		private string m_cutCombustible;

		// Field for storing the RutasCuentas's cutPeaje value
		private string m_cutPeaje;

		// Field for storing the RutasCuentas's cutVariosLlantas value
		private string m_cutVariosLlantas;

		// Field for storing the RutasCuentas's cutVariosCelada value
		private string m_cutVariosCelada;

		// Field for storing the RutasCuentas's cutVariosPropina value
		private string m_cutVariosPropina;

		// Field for storing the RutasCuentas's cutVarios value
		private string m_cutVarios;

		// Field for storing the RutasCuentas's cutVariosLlantasVacio value
		private string m_cutVariosLlantasVacio;

		// Field for storing the RutasCuentas's cutVariosCeladaVacio value
		private string m_cutVariosCeladaVacio;

		// Field for storing the RutasCuentas's cutVariosPropinaVacio value
		private string m_cutVariosPropinaVacio;

		// Field for storing the RutasCuentas's cutVariosVacio value
		private string m_cutVariosVacio;

		// Field for storing the RutasCuentas's cutParticipacion value
		private string m_cutParticipacion;

		// Field for storing the RutasCuentas's cutParticipacionVacio value
		private string m_cutParticipacionVacio;

		// Field for storing the RutasCuentas's curHotel value
		private string m_curHotel;

		// Field for storing the RutasCuentas's curHotelVacio value
		private string m_curHotelVacio;

		// Field for storing the RutasCuentas's curComida value
		private string m_curComida;

		// Field for storing the RutasCuentas's curComidaVacio value
		private string m_curComidaVacio;

		// Field for storing the RutasCuentas's curDesvareManoRepuestos value
		private string m_curDesvareManoRepuestos;

		// Field for storing the RutasCuentas's curDesvareManoObra value
		private string m_curDesvareManoObra;

		// Field for storing the RutasCuentas's cutSaldo value
		private string m_cutSaldo;

		// Field for storing the RutasCuentas's cutKmts value
		private string m_cutKmts;

		// Field for storing the RutasCuentas's ParqueaderoCarretera value
		private string m_ParqueaderoCarretera;

		// Field for storing the RutasCuentas's ParqueaderoCiudad value
		private string m_ParqueaderoCiudad;

		// Field for storing the RutasCuentas's MontadaLLantaCarretera value
		private string m_MontadaLLantaCarretera;

		// Field for storing the RutasCuentas's Papeleria value
		private string m_Papeleria;

		// Field for storing the RutasCuentas's AjusteCarretera value
		private string m_AjusteCarretera;

		// Field for storing the RutasCuentas's Aseo value
		private string m_Aseo;

		// Field for storing the RutasCuentas's Amarres value
		private string m_Amarres;

		// Field for storing the RutasCuentas's Engradasa value
		private string m_Engradasa;

		// Field for storing the RutasCuentas's Calibrada value
		private string m_Calibrada;

		// Field for storing the RutasCuentas's Taxi value
		private string m_Taxi;

		// Field for storing the RutasCuentas's Lavada value
		private string m_Lavada;

		// Field for storing the RutasCuentas's CombustibleCarretera value
		private string m_CombustibleCarretera;

		// Field for storing the RutasCuentas's CurCargue value
		private string m_CurCargue;

		// Field for storing the RutasCuentas's CurDescargue value
		private string m_CurDescargue;

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
		/// Attribute for access the RutasCuentas's lngIdRegistrRuta value (int)
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
		/// Attribute for access the RutasCuentas's cutCombustible value (string)
		/// </summary>
		[DataMember]
		public string cutCombustible
		{
			get { return m_cutCombustible; }
			set 
			{
				m_changed=true;
				m_cutCombustible = value;
			}
		}

		/// <summary>
		/// Attribute for access the RutasCuentas's cutPeaje value (string)
		/// </summary>
		[DataMember]
		public string cutPeaje
		{
			get { return m_cutPeaje; }
			set 
			{
				m_changed=true;
				m_cutPeaje = value;
			}
		}

		/// <summary>
		/// Attribute for access the RutasCuentas's cutVariosLlantas value (string)
		/// </summary>
		[DataMember]
		public string cutVariosLlantas
		{
			get { return m_cutVariosLlantas; }
			set 
			{
				m_changed=true;
				m_cutVariosLlantas = value;
			}
		}

		/// <summary>
		/// Attribute for access the RutasCuentas's cutVariosCelada value (string)
		/// </summary>
		[DataMember]
		public string cutVariosCelada
		{
			get { return m_cutVariosCelada; }
			set 
			{
				m_changed=true;
				m_cutVariosCelada = value;
			}
		}

		/// <summary>
		/// Attribute for access the RutasCuentas's cutVariosPropina value (string)
		/// </summary>
		[DataMember]
		public string cutVariosPropina
		{
			get { return m_cutVariosPropina; }
			set 
			{
				m_changed=true;
				m_cutVariosPropina = value;
			}
		}

		/// <summary>
		/// Attribute for access the RutasCuentas's cutVarios value (string)
		/// </summary>
		[DataMember]
		public string cutVarios
		{
			get { return m_cutVarios; }
			set 
			{
				m_changed=true;
				m_cutVarios = value;
			}
		}

		/// <summary>
		/// Attribute for access the RutasCuentas's cutVariosLlantasVacio value (string)
		/// </summary>
		[DataMember]
		public string cutVariosLlantasVacio
		{
			get { return m_cutVariosLlantasVacio; }
			set 
			{
				m_changed=true;
				m_cutVariosLlantasVacio = value;
			}
		}

		/// <summary>
		/// Attribute for access the RutasCuentas's cutVariosCeladaVacio value (string)
		/// </summary>
		[DataMember]
		public string cutVariosCeladaVacio
		{
			get { return m_cutVariosCeladaVacio; }
			set 
			{
				m_changed=true;
				m_cutVariosCeladaVacio = value;
			}
		}

		/// <summary>
		/// Attribute for access the RutasCuentas's cutVariosPropinaVacio value (string)
		/// </summary>
		[DataMember]
		public string cutVariosPropinaVacio
		{
			get { return m_cutVariosPropinaVacio; }
			set 
			{
				m_changed=true;
				m_cutVariosPropinaVacio = value;
			}
		}

		/// <summary>
		/// Attribute for access the RutasCuentas's cutVariosVacio value (string)
		/// </summary>
		[DataMember]
		public string cutVariosVacio
		{
			get { return m_cutVariosVacio; }
			set 
			{
				m_changed=true;
				m_cutVariosVacio = value;
			}
		}

		/// <summary>
		/// Attribute for access the RutasCuentas's cutParticipacion value (string)
		/// </summary>
		[DataMember]
		public string cutParticipacion
		{
			get { return m_cutParticipacion; }
			set 
			{
				m_changed=true;
				m_cutParticipacion = value;
			}
		}

		/// <summary>
		/// Attribute for access the RutasCuentas's cutParticipacionVacio value (string)
		/// </summary>
		[DataMember]
		public string cutParticipacionVacio
		{
			get { return m_cutParticipacionVacio; }
			set 
			{
				m_changed=true;
				m_cutParticipacionVacio = value;
			}
		}

		/// <summary>
		/// Attribute for access the RutasCuentas's curHotel value (string)
		/// </summary>
		[DataMember]
		public string curHotel
		{
			get { return m_curHotel; }
			set 
			{
				m_changed=true;
				m_curHotel = value;
			}
		}

		/// <summary>
		/// Attribute for access the RutasCuentas's curHotelVacio value (string)
		/// </summary>
		[DataMember]
		public string curHotelVacio
		{
			get { return m_curHotelVacio; }
			set 
			{
				m_changed=true;
				m_curHotelVacio = value;
			}
		}

		/// <summary>
		/// Attribute for access the RutasCuentas's curComida value (string)
		/// </summary>
		[DataMember]
		public string curComida
		{
			get { return m_curComida; }
			set 
			{
				m_changed=true;
				m_curComida = value;
			}
		}

		/// <summary>
		/// Attribute for access the RutasCuentas's curComidaVacio value (string)
		/// </summary>
		[DataMember]
		public string curComidaVacio
		{
			get { return m_curComidaVacio; }
			set 
			{
				m_changed=true;
				m_curComidaVacio = value;
			}
		}

		/// <summary>
		/// Attribute for access the RutasCuentas's curDesvareManoRepuestos value (string)
		/// </summary>
		[DataMember]
		public string curDesvareManoRepuestos
		{
			get { return m_curDesvareManoRepuestos; }
			set 
			{
				m_changed=true;
				m_curDesvareManoRepuestos = value;
			}
		}

		/// <summary>
		/// Attribute for access the RutasCuentas's curDesvareManoObra value (string)
		/// </summary>
		[DataMember]
		public string curDesvareManoObra
		{
			get { return m_curDesvareManoObra; }
			set 
			{
				m_changed=true;
				m_curDesvareManoObra = value;
			}
		}

		/// <summary>
		/// Attribute for access the RutasCuentas's cutSaldo value (string)
		/// </summary>
		[DataMember]
		public string cutSaldo
		{
			get { return m_cutSaldo; }
			set 
			{
				m_changed=true;
				m_cutSaldo = value;
			}
		}

		/// <summary>
		/// Attribute for access the RutasCuentas's cutKmts value (string)
		/// </summary>
		[DataMember]
		public string cutKmts
		{
			get { return m_cutKmts; }
			set 
			{
				m_changed=true;
				m_cutKmts = value;
			}
		}

		/// <summary>
		/// Attribute for access the RutasCuentas's ParqueaderoCarretera value (string)
		/// </summary>
		[DataMember]
		public string ParqueaderoCarretera
		{
			get { return m_ParqueaderoCarretera; }
			set 
			{
				m_changed=true;
				m_ParqueaderoCarretera = value;
			}
		}

		/// <summary>
		/// Attribute for access the RutasCuentas's ParqueaderoCiudad value (string)
		/// </summary>
		[DataMember]
		public string ParqueaderoCiudad
		{
			get { return m_ParqueaderoCiudad; }
			set 
			{
				m_changed=true;
				m_ParqueaderoCiudad = value;
			}
		}

		/// <summary>
		/// Attribute for access the RutasCuentas's MontadaLLantaCarretera value (string)
		/// </summary>
		[DataMember]
		public string MontadaLLantaCarretera
		{
			get { return m_MontadaLLantaCarretera; }
			set 
			{
				m_changed=true;
				m_MontadaLLantaCarretera = value;
			}
		}

		/// <summary>
		/// Attribute for access the RutasCuentas's Papeleria value (string)
		/// </summary>
		[DataMember]
		public string Papeleria
		{
			get { return m_Papeleria; }
			set 
			{
				m_changed=true;
				m_Papeleria = value;
			}
		}

		/// <summary>
		/// Attribute for access the RutasCuentas's AjusteCarretera value (string)
		/// </summary>
		[DataMember]
		public string AjusteCarretera
		{
			get { return m_AjusteCarretera; }
			set 
			{
				m_changed=true;
				m_AjusteCarretera = value;
			}
		}

		/// <summary>
		/// Attribute for access the RutasCuentas's Aseo value (string)
		/// </summary>
		[DataMember]
		public string Aseo
		{
			get { return m_Aseo; }
			set 
			{
				m_changed=true;
				m_Aseo = value;
			}
		}

		/// <summary>
		/// Attribute for access the RutasCuentas's Amarres value (string)
		/// </summary>
		[DataMember]
		public string Amarres
		{
			get { return m_Amarres; }
			set 
			{
				m_changed=true;
				m_Amarres = value;
			}
		}

		/// <summary>
		/// Attribute for access the RutasCuentas's Engradasa value (string)
		/// </summary>
		[DataMember]
		public string Engradasa
		{
			get { return m_Engradasa; }
			set 
			{
				m_changed=true;
				m_Engradasa = value;
			}
		}

		/// <summary>
		/// Attribute for access the RutasCuentas's Calibrada value (string)
		/// </summary>
		[DataMember]
		public string Calibrada
		{
			get { return m_Calibrada; }
			set 
			{
				m_changed=true;
				m_Calibrada = value;
			}
		}

		/// <summary>
		/// Attribute for access the RutasCuentas's Taxi value (string)
		/// </summary>
		[DataMember]
		public string Taxi
		{
			get { return m_Taxi; }
			set 
			{
				m_changed=true;
				m_Taxi = value;
			}
		}

		/// <summary>
		/// Attribute for access the RutasCuentas's Lavada value (string)
		/// </summary>
		[DataMember]
		public string Lavada
		{
			get { return m_Lavada; }
			set 
			{
				m_changed=true;
				m_Lavada = value;
			}
		}

		/// <summary>
		/// Attribute for access the RutasCuentas's CombustibleCarretera value (string)
		/// </summary>
		[DataMember]
		public string CombustibleCarretera
		{
			get { return m_CombustibleCarretera; }
			set 
			{
				m_changed=true;
				m_CombustibleCarretera = value;
			}
		}

		/// <summary>
		/// Attribute for access the RutasCuentas's CurCargue value (string)
		/// </summary>
		[DataMember]
		public string CurCargue
		{
			get { return m_CurCargue; }
			set 
			{
				m_changed=true;
				m_CurCargue = value;
			}
		}

		/// <summary>
		/// Attribute for access the RutasCuentas's CurDescargue value (string)
		/// </summary>
		[DataMember]
		public string CurDescargue
		{
			get { return m_CurDescargue; }
			set 
			{
				m_changed=true;
				m_CurDescargue = value;
			}
		}

		public object GetAttribute(string pattribute)
		{
			switch (pattribute)
			{
				case "lngIdRegistrRuta": return lngIdRegistrRuta;
				case "cutCombustible": return cutCombustible;
				case "cutPeaje": return cutPeaje;
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
				case "curHotel": return curHotel;
				case "curHotelVacio": return curHotelVacio;
				case "curComida": return curComida;
				case "curComidaVacio": return curComidaVacio;
				case "curDesvareManoRepuestos": return curDesvareManoRepuestos;
				case "curDesvareManoObra": return curDesvareManoObra;
				case "cutSaldo": return cutSaldo;
				case "cutKmts": return cutKmts;
				case "ParqueaderoCarretera": return ParqueaderoCarretera;
				case "ParqueaderoCiudad": return ParqueaderoCiudad;
				case "MontadaLLantaCarretera": return MontadaLLantaCarretera;
				case "Papeleria": return Papeleria;
				case "AjusteCarretera": return AjusteCarretera;
				case "Aseo": return Aseo;
				case "Amarres": return Amarres;
				case "Engradasa": return Engradasa;
				case "Calibrada": return Calibrada;
				case "Taxi": return Taxi;
				case "Lavada": return Lavada;
				case "CombustibleCarretera": return CombustibleCarretera;
				case "CurCargue": return CurCargue;
				case "CurDescargue": return CurDescargue;
				default: return null;
			}
		}

		public Type GetAttributeType(string pattribute)
		{
			return RutasCuentasController.Instance.GetMethodType(pattribute, this);
		}

		public string GetSqlKey()
		{
			return "[lngIdRegistrRuta] = " + lngIdRegistrRuta.ToString();
		}
		#endregion

	}

	#endregion

	#region RutasCuentasList object

	/// <summary>
	/// Class for reading and access a list of RutasCuentas object
	/// </summary>
	[CollectionDataContract]
	public partial class RutasCuentasList : List<RutasCuentas>
	{

		/// <summary>
		/// Default constructor
		/// </summary>
		public RutasCuentasList()
		{
		}
	}

	#endregion

}
