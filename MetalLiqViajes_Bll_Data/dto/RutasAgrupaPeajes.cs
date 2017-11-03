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
	#region RutasAgrupaPeajes object

	[DataContract]
	public partial class RutasAgrupaPeajes : IDTOObject
	{
		/// <summary>
		/// Default constructor
		/// </summary>
		public RutasAgrupaPeajes()
		{
			m_lngIdGrupo = 0;
			m_strNombreGrupo = null;
			m_changed=false;
		}
		        //Return the table name of object
		        public string TableName()
		        {
		            return "tblRutasAgrupaPeajes";
		        }
		#region Undo 
		// Internal class for storing changes
		private RutasAgrupaPeajes m_oldRutasAgrupaPeajes;
		public void GenerateUndo()
		{
			m_oldRutasAgrupaPeajes=new RutasAgrupaPeajes();
			m_oldRutasAgrupaPeajes.m_lngIdGrupo = m_lngIdGrupo;
			m_oldRutasAgrupaPeajes.strNombreGrupo = m_strNombreGrupo;
		}

		public RutasAgrupaPeajes OldRutasAgrupaPeajes
		{
			get { return m_oldRutasAgrupaPeajes;}
		}
		// Return the changed fields
		public string[] FieldChanged()
		{
			List<string> fields=new List<string>();
			if (m_oldRutasAgrupaPeajes.strNombreGrupo != m_strNombreGrupo) fields.Add("strNombreGrupo");
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


		// Field for storing the RutasAgrupaPeajes's strNombreGrupo value
		private string m_strNombreGrupo;

		// Field for storing the RutasAgrupaPeajes's lngIdGrupo value
		private int m_lngIdGrupo;

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
		/// Attribute for access the RutasAgrupaPeajes's strNombreGrupo value (string)
		/// </summary>
		[DataMember]
		public string strNombreGrupo
		{
			get { return m_strNombreGrupo; }
			set 
			{
				m_changed=true;
				m_strNombreGrupo = value;
			}
		}

		/// <summary>
		/// Attribute for access the RutasAgrupaPeajes's lngIdGrupo value (int)
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

		public object GetAttribute(string pattribute)
		{
			switch (pattribute)
			{
				case "strNombreGrupo": return strNombreGrupo;
				case "lngIdGrupo": return lngIdGrupo;
				default: return null;
			}
		}

		public Type GetAttributeType(string pattribute)
		{
			return RutasAgrupaPeajesController.Instance.GetMethodType(pattribute, this);
		}

		public string GetSqlKey()
		{
			return "[lngIdGrupo] = " + lngIdGrupo.ToString();
		}
		#endregion

	}

	#endregion

	#region RutasAgrupaPeajesList object

	/// <summary>
	/// Class for reading and access a list of RutasAgrupaPeajes object
	/// </summary>
	[CollectionDataContract]
	public partial class RutasAgrupaPeajesList : List<RutasAgrupaPeajes>
	{

		/// <summary>
		/// Default constructor
		/// </summary>
		public RutasAgrupaPeajesList()
		{
		}
	}

	#endregion

}
