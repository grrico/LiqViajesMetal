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
	#region LiquidacionRutasObs object

	[DataContract]
	public partial class LiquidacionRutasObs : IDTOObject
	{
		/// <summary>
		/// Default constructor
		/// </summary>
		public LiquidacionRutasObs()
		{
			m_lngItemsId = 0;
			m_lngIdRegistrRutaItemId = null;
			m_lngIdRegistrRuta = null;
			m_lngIdRegistro = null;
			m_strCampo = null;
			m_strObservacion = null;
			m_nitTercero = null;
			m_dtmFechaModif = null;
			m_changed=false;
		}
		        //Return the table name of object
		        public string TableName()
		        {
		            return "tblLiquidacionRutasObs";
		        }
		#region Undo 
		// Internal class for storing changes
		private LiquidacionRutasObs m_oldLiquidacionRutasObs;
		public void GenerateUndo()
		{
			m_oldLiquidacionRutasObs=new LiquidacionRutasObs();
			m_oldLiquidacionRutasObs.m_lngItemsId = m_lngItemsId;
			m_oldLiquidacionRutasObs.lngIdRegistrRutaItemId = m_lngIdRegistrRutaItemId;
			m_oldLiquidacionRutasObs.lngIdRegistrRuta = m_lngIdRegistrRuta;
			m_oldLiquidacionRutasObs.lngIdRegistro = m_lngIdRegistro;
			m_oldLiquidacionRutasObs.strCampo = m_strCampo;
			m_oldLiquidacionRutasObs.strObservacion = m_strObservacion;
			m_oldLiquidacionRutasObs.nitTercero = m_nitTercero;
			m_oldLiquidacionRutasObs.dtmFechaModif = m_dtmFechaModif;
		}

		public LiquidacionRutasObs OldLiquidacionRutasObs
		{
			get { return m_oldLiquidacionRutasObs;}
		}
		// Return the changed fields
		public string[] FieldChanged()
		{
			List<string> fields=new List<string>();
			if (m_oldLiquidacionRutasObs.lngIdRegistrRutaItemId != m_lngIdRegistrRutaItemId) fields.Add("lngIdRegistrRutaItemId");
			if (m_oldLiquidacionRutasObs.lngIdRegistrRuta != m_lngIdRegistrRuta) fields.Add("lngIdRegistrRuta");
			if (m_oldLiquidacionRutasObs.lngIdRegistro != m_lngIdRegistro) fields.Add("lngIdRegistro");
			if (m_oldLiquidacionRutasObs.strCampo != m_strCampo) fields.Add("strCampo");
			if (m_oldLiquidacionRutasObs.strObservacion != m_strObservacion) fields.Add("strObservacion");
			if (m_oldLiquidacionRutasObs.nitTercero != m_nitTercero) fields.Add("nitTercero");
			if (m_oldLiquidacionRutasObs.dtmFechaModif != m_dtmFechaModif) fields.Add("dtmFechaModif");
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


		// Field for storing the LiquidacionRutasObs's lngItemsId value
		private int m_lngItemsId;

		// Field for storing the LiquidacionRutasObs's lngIdRegistrRutaItemId value
		private int? m_lngIdRegistrRutaItemId;

		// Field for storing the LiquidacionRutasObs's lngIdRegistrRuta value
		private int? m_lngIdRegistrRuta;

		// Field for storing the LiquidacionRutasObs's lngIdRegistro value
		private int? m_lngIdRegistro;

		// Field for storing the LiquidacionRutasObs's strCampo value
		private string m_strCampo;

		// Field for storing the LiquidacionRutasObs's strObservacion value
		private string m_strObservacion;

		// Field for storing the LiquidacionRutasObs's nitTercero value
		private string m_nitTercero;

		// Field for storing the LiquidacionRutasObs's dtmFechaModif value
		private DateTime? m_dtmFechaModif;

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
		/// Attribute for access the LiquidacionRutasObs's lngItemsId value (int)
		/// </summary>
		[DataMember]
		public int lngItemsId
		{
			get { return m_lngItemsId; }
			set 
			{
				m_changed=true;
				m_lngItemsId = value;
			}
		}

		/// <summary>
		/// Attribute for access the LiquidacionRutasObs's lngIdRegistrRutaItemId value (int)
		/// </summary>
		[DataMember]
		public int? lngIdRegistrRutaItemId
		{
			get { return m_lngIdRegistrRutaItemId; }
			set 
			{
				m_changed=true;
				m_lngIdRegistrRutaItemId = value;
			}
		}

		/// <summary>
		/// Attribute for access the LiquidacionRutasObs's lngIdRegistrRuta value (int)
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
		/// Attribute for access the LiquidacionRutasObs's lngIdRegistro value (int)
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
		/// Attribute for access the LiquidacionRutasObs's strCampo value (string)
		/// </summary>
		[DataMember]
		public string strCampo
		{
			get { return m_strCampo; }
			set 
			{
				m_changed=true;
				m_strCampo = value;
			}
		}

		/// <summary>
		/// Attribute for access the LiquidacionRutasObs's strObservacion value (string)
		/// </summary>
		[DataMember]
		public string strObservacion
		{
			get { return m_strObservacion; }
			set 
			{
				m_changed=true;
				m_strObservacion = value;
			}
		}

		/// <summary>
		/// Attribute for access the LiquidacionRutasObs's nitTercero value (string)
		/// </summary>
		[DataMember]
		public string nitTercero
		{
			get { return m_nitTercero; }
			set 
			{
				m_changed=true;
				m_nitTercero = value;
			}
		}

		/// <summary>
		/// Attribute for access the LiquidacionRutasObs's dtmFechaModif value (DateTime)
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

		public object GetAttribute(string pattribute)
		{
			switch (pattribute)
			{
				case "lngItemsId": return lngItemsId;
				case "lngIdRegistrRutaItemId": return lngIdRegistrRutaItemId;
				case "lngIdRegistrRuta": return lngIdRegistrRuta;
				case "lngIdRegistro": return lngIdRegistro;
				case "strCampo": return strCampo;
				case "strObservacion": return strObservacion;
				case "nitTercero": return nitTercero;
				case "dtmFechaModif": return dtmFechaModif;
				default: return null;
			}
		}

		public Type GetAttributeType(string pattribute)
		{
			return LiquidacionRutasObsController.Instance.GetMethodType(pattribute, this);
		}

		public string GetSqlKey()
		{
			return "[lngItemsId] = " + lngItemsId.ToString();
		}
		#endregion

	}

	#endregion

	#region LiquidacionRutasObsList object

	/// <summary>
	/// Class for reading and access a list of LiquidacionRutasObs object
	/// </summary>
	[CollectionDataContract]
	public partial class LiquidacionRutasObsList : List<LiquidacionRutasObs>
	{

		/// <summary>
		/// Default constructor
		/// </summary>
		public LiquidacionRutasObsList()
		{
		}
	}

	#endregion

}
