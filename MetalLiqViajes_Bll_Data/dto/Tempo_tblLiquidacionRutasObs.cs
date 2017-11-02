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
	#region Tempo_tblLiquidacionRutasObs object

	[DataContract]
	public partial class Tempo_tblLiquidacionRutasObs : IDTOObject
	{
		/// <summary>
		/// Default constructor
		/// </summary>
		public Tempo_tblLiquidacionRutasObs()
		{
			m_lngIdRegistrRutaItemId = 0;
			m_lngIdRegistrRuta = null;
			m_lngIdRegistro = null;
			m_strCampo = ' ';
			m_strObservacion = ' ';
			m_strMotivo = ' ';
			m_lngIdUsuario = null;
			m_changed=false;
		}
		        //Return the table name of object
		        public string TableName()
		        {
		            return "tblTempo_tblLiquidacionRutasObs";
		        }
		#region Undo 
		// Internal class for storing changes
		private Tempo_tblLiquidacionRutasObs m_oldTempo_tblLiquidacionRutasObs;
		public void GenerateUndo()
		{
			m_oldTempo_tblLiquidacionRutasObs=new Tempo_tblLiquidacionRutasObs();
			m_oldTempo_tblLiquidacionRutasObs.lngIdRegistrRutaItemId = m_lngIdRegistrRutaItemId;
			m_oldTempo_tblLiquidacionRutasObs.lngIdRegistrRuta = m_lngIdRegistrRuta;
			m_oldTempo_tblLiquidacionRutasObs.lngIdRegistro = m_lngIdRegistro;
			m_oldTempo_tblLiquidacionRutasObs.strCampo = m_strCampo;
			m_oldTempo_tblLiquidacionRutasObs.strObservacion = m_strObservacion;
			m_oldTempo_tblLiquidacionRutasObs.strMotivo = m_strMotivo;
			m_oldTempo_tblLiquidacionRutasObs.lngIdUsuario = m_lngIdUsuario;
		}

		public Tempo_tblLiquidacionRutasObs OldTempo_tblLiquidacionRutasObs
		{
			get { return m_oldTempo_tblLiquidacionRutasObs;}
		}
		// Return the changed fields
		public string[] FieldChanged()
		{
			List<string> fields=new List<string>();
			if (m_oldTempo_tblLiquidacionRutasObs.lngIdRegistrRutaItemId != m_lngIdRegistrRutaItemId) fields.Add("lngIdRegistrRutaItemId");
			if (m_oldTempo_tblLiquidacionRutasObs.lngIdRegistrRuta != m_lngIdRegistrRuta) fields.Add("lngIdRegistrRuta");
			if (m_oldTempo_tblLiquidacionRutasObs.lngIdRegistro != m_lngIdRegistro) fields.Add("lngIdRegistro");
			if (m_oldTempo_tblLiquidacionRutasObs.strCampo != m_strCampo) fields.Add("strCampo");
			if (m_oldTempo_tblLiquidacionRutasObs.strObservacion != m_strObservacion) fields.Add("strObservacion");
			if (m_oldTempo_tblLiquidacionRutasObs.strMotivo != m_strMotivo) fields.Add("strMotivo");
			if (m_oldTempo_tblLiquidacionRutasObs.lngIdUsuario != m_lngIdUsuario) fields.Add("lngIdUsuario");
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


		// Field for storing the Tempo_tblLiquidacionRutasObs's lngIdRegistrRutaItemId value
		private int m_lngIdRegistrRutaItemId;

		// Field for storing the Tempo_tblLiquidacionRutasObs's lngIdRegistrRuta value
		private int? m_lngIdRegistrRuta;

		// Field for storing the Tempo_tblLiquidacionRutasObs's lngIdRegistro value
		private int? m_lngIdRegistro;

		// Field for storing the Tempo_tblLiquidacionRutasObs's strCampo value
		private char? m_strCampo;

		// Field for storing the Tempo_tblLiquidacionRutasObs's strObservacion value
		private char? m_strObservacion;

		// Field for storing the Tempo_tblLiquidacionRutasObs's strMotivo value
		private char? m_strMotivo;

		// Field for storing the Tempo_tblLiquidacionRutasObs's lngIdUsuario value
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
		/// Attribute for access the Tempo_tblLiquidacionRutasObs's lngIdRegistrRutaItemId value (int)
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
		/// Attribute for access the Tempo_tblLiquidacionRutasObs's lngIdRegistrRuta value (int)
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
		/// Attribute for access the Tempo_tblLiquidacionRutasObs's lngIdRegistro value (int)
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
		/// Attribute for access the Tempo_tblLiquidacionRutasObs's strCampo value (char)
		/// </summary>
		[DataMember]
		public char? strCampo
		{
			get { return m_strCampo; }
			set 
			{
				m_changed=true;
				m_strCampo = value;
			}
		}

		/// <summary>
		/// Attribute for access the Tempo_tblLiquidacionRutasObs's strObservacion value (char)
		/// </summary>
		[DataMember]
		public char? strObservacion
		{
			get { return m_strObservacion; }
			set 
			{
				m_changed=true;
				m_strObservacion = value;
			}
		}

		/// <summary>
		/// Attribute for access the Tempo_tblLiquidacionRutasObs's strMotivo value (char)
		/// </summary>
		[DataMember]
		public char? strMotivo
		{
			get { return m_strMotivo; }
			set 
			{
				m_changed=true;
				m_strMotivo = value;
			}
		}

		/// <summary>
		/// Attribute for access the Tempo_tblLiquidacionRutasObs's lngIdUsuario value (int)
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
				case "strCampo": return strCampo;
				case "strObservacion": return strObservacion;
				case "strMotivo": return strMotivo;
				case "lngIdUsuario": return lngIdUsuario;
				default: return null;
			}
		}

		public Type GetAttributeType(string pattribute)
		{
			return Tempo_tblLiquidacionRutasObsController.Instance.GetMethodType(pattribute, this);
		}

		public string GetSqlKey()
		{
			return "";
		}
		#endregion

	}

	#endregion

	#region Tempo_tblLiquidacionRutasObsList object

	/// <summary>
	/// Class for reading and access a list of Tempo_tblLiquidacionRutasObs object
	/// </summary>
	[CollectionDataContract]
	public partial class Tempo_tblLiquidacionRutasObsList : List<Tempo_tblLiquidacionRutasObs>
	{

		/// <summary>
		/// Default constructor
		/// </summary>
		public Tempo_tblLiquidacionRutasObsList()
		{
		}
	}

	#endregion

}
