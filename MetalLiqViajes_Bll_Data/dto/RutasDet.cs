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
	#region RutasDet object

	[DataContract]
	public partial class RutasDet : IDTOObject
	{
		/// <summary>
		/// Default constructor
		/// </summary>
		public RutasDet()
		{
			m_lngIdItemdReg = 0;
			m_lngIdRegistrRuta = 0;
			m_lngIdPeaje = 0;
			m_strNombrePeaje = null;
			m_curValorPeaje = null;
			m_changed=false;
		}
		        //Return the table name of object
		        public string TableName()
		        {
		            return "tblRutasDet";
		        }
		#region Undo 
		// Internal class for storing changes
		private RutasDet m_oldRutasDet;
		public void GenerateUndo()
		{
			m_oldRutasDet=new RutasDet();
			m_oldRutasDet.m_lngIdItemdReg = m_lngIdItemdReg;
			m_oldRutasDet.m_lngIdRegistrRuta = m_lngIdRegistrRuta;
			m_oldRutasDet.m_lngIdPeaje = m_lngIdPeaje;
			m_oldRutasDet.strNombrePeaje = m_strNombrePeaje;
			m_oldRutasDet.curValorPeaje = m_curValorPeaje;
		}

		public RutasDet OldRutasDet
		{
			get { return m_oldRutasDet;}
		}
		// Return the changed fields
		public string[] FieldChanged()
		{
			List<string> fields=new List<string>();
			if (m_oldRutasDet.strNombrePeaje != m_strNombrePeaje) fields.Add("strNombrePeaje");
			if (m_oldRutasDet.curValorPeaje != m_curValorPeaje) fields.Add("curValorPeaje");
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


		// Field for storing the RutasDet's strNombrePeaje value
		private string m_strNombrePeaje;

		// Field for storing the RutasDet's curValorPeaje value
		private decimal? m_curValorPeaje;

		// Field for storing the RutasDet's lngIdItemdReg value
		private int m_lngIdItemdReg;

		// Field for storing the RutasDet's lngIdRegistrRuta value
		private int m_lngIdRegistrRuta;

		// Field for storing the RutasDet's lngIdPeaje value
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
		/// Attribute for access the RutasDet's strNombrePeaje value (string)
		/// </summary>
		[DataMember]
		public string strNombrePeaje
		{
			get { return m_strNombrePeaje; }
			set 
			{
				m_changed=true;
				m_strNombrePeaje = value;
			}
		}

		/// <summary>
		/// Attribute for access the RutasDet's curValorPeaje value (decimal)
		/// </summary>
		[DataMember]
		public decimal? curValorPeaje
		{
			get { return m_curValorPeaje; }
			set 
			{
				m_changed=true;
				m_curValorPeaje = value;
			}
		}

		/// <summary>
		/// Attribute for access the RutasDet's lngIdItemdReg value (int)
		/// </summary>
		[DataMember]
		public int lngIdItemdReg
		{
			get { return m_lngIdItemdReg; }
			set 
			{
				m_changed=true;
				m_lngIdItemdReg = value;
			}
		}

		/// <summary>
		/// Attribute for access the RutasDet's lngIdRegistrRuta value (int)
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
		/// Attribute for access the RutasDet's lngIdPeaje value (int)
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
				case "strNombrePeaje": return strNombrePeaje;
				case "curValorPeaje": return curValorPeaje;
				case "lngIdItemdReg": return lngIdItemdReg;
				case "lngIdRegistrRuta": return lngIdRegistrRuta;
				case "lngIdPeaje": return lngIdPeaje;
				default: return null;
			}
		}

		public Type GetAttributeType(string pattribute)
		{
			return RutasDetController.Instance.GetMethodType(pattribute, this);
		}

		public string GetSqlKey()
		{
			return "[lngIdItemdReg] = " + lngIdItemdReg.ToString() + " AND [lngIdRegistrRuta] = " + lngIdRegistrRuta.ToString() + " AND [lngIdPeaje] = " + lngIdPeaje.ToString();
		}
		#endregion

	}

	#endregion

	#region RutasDetList object

	/// <summary>
	/// Class for reading and access a list of RutasDet object
	/// </summary>
	[CollectionDataContract]
	public partial class RutasDetList : List<RutasDet>
	{

		/// <summary>
		/// Default constructor
		/// </summary>
		public RutasDetList()
		{
		}
	}

	#endregion

}
