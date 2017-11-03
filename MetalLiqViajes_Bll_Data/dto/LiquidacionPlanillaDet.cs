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
	#region LiquidacionPlanillaDet object

	[DataContract]
	public partial class LiquidacionPlanillaDet : IDTOObject
	{
		/// <summary>
		/// Default constructor
		/// </summary>
		public LiquidacionPlanillaDet()
		{
			m_lngIdItemd = 0;
			m_lngIdRegistro = null;
			m_lngIdRegistrRuta = null;
			m_lngIdRegistrRutaItemId = null;
			m_strNoPlanilla = null;
			m_dtmFechaModif = null;
			m_changed=false;
		}
		        //Return the table name of object
		        public string TableName()
		        {
		            return "tblLiquidacionPlanillaDet";
		        }
		#region Undo 
		// Internal class for storing changes
		private LiquidacionPlanillaDet m_oldLiquidacionPlanillaDet;
		public void GenerateUndo()
		{
			m_oldLiquidacionPlanillaDet=new LiquidacionPlanillaDet();
			m_oldLiquidacionPlanillaDet.m_lngIdItemd = m_lngIdItemd;
			m_oldLiquidacionPlanillaDet.lngIdRegistro = m_lngIdRegistro;
			m_oldLiquidacionPlanillaDet.lngIdRegistrRuta = m_lngIdRegistrRuta;
			m_oldLiquidacionPlanillaDet.lngIdRegistrRutaItemId = m_lngIdRegistrRutaItemId;
			m_oldLiquidacionPlanillaDet.strNoPlanilla = m_strNoPlanilla;
			m_oldLiquidacionPlanillaDet.dtmFechaModif = m_dtmFechaModif;
		}

		public LiquidacionPlanillaDet OldLiquidacionPlanillaDet
		{
			get { return m_oldLiquidacionPlanillaDet;}
		}
		// Return the changed fields
		public string[] FieldChanged()
		{
			List<string> fields=new List<string>();
			if (m_oldLiquidacionPlanillaDet.lngIdRegistro != m_lngIdRegistro) fields.Add("lngIdRegistro");
			if (m_oldLiquidacionPlanillaDet.lngIdRegistrRuta != m_lngIdRegistrRuta) fields.Add("lngIdRegistrRuta");
			if (m_oldLiquidacionPlanillaDet.lngIdRegistrRutaItemId != m_lngIdRegistrRutaItemId) fields.Add("lngIdRegistrRutaItemId");
			if (m_oldLiquidacionPlanillaDet.strNoPlanilla != m_strNoPlanilla) fields.Add("strNoPlanilla");
			if (m_oldLiquidacionPlanillaDet.dtmFechaModif != m_dtmFechaModif) fields.Add("dtmFechaModif");
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


		// Field for storing the LiquidacionPlanillaDet's lngIdRegistro value
		private int? m_lngIdRegistro;

		// Field for storing the LiquidacionPlanillaDet's lngIdRegistrRuta value
		private int? m_lngIdRegistrRuta;

		// Field for storing the LiquidacionPlanillaDet's lngIdRegistrRutaItemId value
		private int? m_lngIdRegistrRutaItemId;

		// Field for storing the LiquidacionPlanillaDet's strNoPlanilla value
		private string m_strNoPlanilla;

		// Field for storing the LiquidacionPlanillaDet's dtmFechaModif value
		private DateTime? m_dtmFechaModif;

		// Field for storing the LiquidacionPlanillaDet's lngIdItemd value
		private int m_lngIdItemd;

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
		/// Attribute for access the LiquidacionPlanillaDet's lngIdRegistro value (int)
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
		/// Attribute for access the LiquidacionPlanillaDet's lngIdRegistrRuta value (int)
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
		/// Attribute for access the LiquidacionPlanillaDet's lngIdRegistrRutaItemId value (int)
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
		/// Attribute for access the LiquidacionPlanillaDet's strNoPlanilla value (string)
		/// </summary>
		[DataMember]
		public string strNoPlanilla
		{
			get { return m_strNoPlanilla; }
			set 
			{
				m_changed=true;
				m_strNoPlanilla = value;
			}
		}

		/// <summary>
		/// Attribute for access the LiquidacionPlanillaDet's dtmFechaModif value (DateTime)
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
		/// Attribute for access the LiquidacionPlanillaDet's lngIdItemd value (int)
		/// </summary>
		[DataMember]
		public int lngIdItemd
		{
			get { return m_lngIdItemd; }
			set 
			{
				m_changed=true;
				m_lngIdItemd = value;
			}
		}

		public object GetAttribute(string pattribute)
		{
			switch (pattribute)
			{
				case "lngIdRegistro": return lngIdRegistro;
				case "lngIdRegistrRuta": return lngIdRegistrRuta;
				case "lngIdRegistrRutaItemId": return lngIdRegistrRutaItemId;
				case "strNoPlanilla": return strNoPlanilla;
				case "dtmFechaModif": return dtmFechaModif;
				case "lngIdItemd": return lngIdItemd;
				default: return null;
			}
		}

		public Type GetAttributeType(string pattribute)
		{
			return LiquidacionPlanillaDetController.Instance.GetMethodType(pattribute, this);
		}

		public string GetSqlKey()
		{
			return "[lngIdItemd] = " + lngIdItemd.ToString();
		}
		#endregion

	}

	#endregion

	#region LiquidacionPlanillaDetList object

	/// <summary>
	/// Class for reading and access a list of LiquidacionPlanillaDet object
	/// </summary>
	[CollectionDataContract]
	public partial class LiquidacionPlanillaDetList : List<LiquidacionPlanillaDet>
	{

		/// <summary>
		/// Default constructor
		/// </summary>
		public LiquidacionPlanillaDetList()
		{
		}
	}

	#endregion

}
