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
	#region RutasAgrupaPeajesDet object

	[DataContract]
	public partial class RutasAgrupaPeajesDet : IDTOObject
	{
		/// <summary>
		/// Default constructor
		/// </summary>
		public RutasAgrupaPeajesDet()
		{
			m_lngIdGrupo = 0;
			m_lngIdPeaje = 0;
			m_intSecuencia = null;
			m_changed=false;
		}
		        //Return the table name of object
		        public string TableName()
		        {
		            return "tblRutasAgrupaPeajesDet";
		        }
		#region Undo 
		// Internal class for storing changes
		private RutasAgrupaPeajesDet m_oldRutasAgrupaPeajesDet;
		public void GenerateUndo()
		{
			m_oldRutasAgrupaPeajesDet=new RutasAgrupaPeajesDet();
			m_oldRutasAgrupaPeajesDet.m_lngIdGrupo = m_lngIdGrupo;
			m_oldRutasAgrupaPeajesDet.m_lngIdPeaje = m_lngIdPeaje;
			m_oldRutasAgrupaPeajesDet.intSecuencia = m_intSecuencia;
		}

		public RutasAgrupaPeajesDet OldRutasAgrupaPeajesDet
		{
			get { return m_oldRutasAgrupaPeajesDet;}
		}
		// Return the changed fields
		public string[] FieldChanged()
		{
			List<string> fields=new List<string>();
			if (m_oldRutasAgrupaPeajesDet.intSecuencia != m_intSecuencia) fields.Add("intSecuencia");
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


		// Field for storing the RutasAgrupaPeajesDet's intSecuencia value
		private int? m_intSecuencia;

		// Field for storing the RutasAgrupaPeajesDet's lngIdGrupo value
		private int m_lngIdGrupo;

		// Field for storing the RutasAgrupaPeajesDet's lngIdPeaje value
		private int m_lngIdPeaje;

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
		/// Attribute for access the RutasAgrupaPeajesDet's intSecuencia value (int)
		/// </summary>
		[DataMember]
		public int? intSecuencia
		{
			get { return m_intSecuencia; }
			set 
			{
				m_changed=true;
				m_intSecuencia = value;
			}
		}

		/// <summary>
		/// Attribute for access the RutasAgrupaPeajesDet's lngIdGrupo value (int)
		/// </summary>
		[DataMember]
		public int lngIdGrupo
		{
			get { return m_lngIdGrupo; }
			set 
			{
				m_changed=true;
				m_lngIdGrupo = value;
			}
		}

		/// <summary>
		/// Attribute for access the RutasAgrupaPeajesDet's lngIdPeaje value (int)
		/// </summary>
		[DataMember]
		public int lngIdPeaje
		{
			get { return m_lngIdPeaje; }
			set 
			{
				m_changed=true;
				m_lngIdPeaje = value;
			}
		}

		public object GetAttribute(string pattribute)
		{
			switch (pattribute)
			{
				case "intSecuencia": return intSecuencia;
				case "lngIdGrupo": return lngIdGrupo;
				case "lngIdPeaje": return lngIdPeaje;
				default: return null;
			}
		}

		public Type GetAttributeType(string pattribute)
		{
			return RutasAgrupaPeajesDetController.Instance.GetMethodType(pattribute, this);
		}

		public string GetSqlKey()
		{
			return "[lngIdGrupo] = " + lngIdGrupo.ToString() + " AND [lngIdPeaje] = " + lngIdPeaje.ToString();
		}
		#endregion

	}

	#endregion

	#region RutasAgrupaPeajesDetList object

	/// <summary>
	/// Class for reading and access a list of RutasAgrupaPeajesDet object
	/// </summary>
	[CollectionDataContract]
	public partial class RutasAgrupaPeajesDetList : List<RutasAgrupaPeajesDet>
	{

		/// <summary>
		/// Default constructor
		/// </summary>
		public RutasAgrupaPeajesDetList()
		{
		}
	}

	#endregion

}
