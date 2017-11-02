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
	#region A2MontoEscrito object

	[DataContract]
	public partial class A2MontoEscrito : IDTOObject
	{
		/// <summary>
		/// Default constructor
		/// </summary>
		public A2MontoEscrito()
		{
			m_bytTipoCifra = (byte)0;
			m_bytPosicionCifra = (byte)0;
			m_strCifra = null;
			m_changed=false;
		}
		        //Return the table name of object
		        public string TableName()
		        {
		            return "tblA2MontoEscrito";
		        }
		#region Undo 
		// Internal class for storing changes
		private A2MontoEscrito m_oldA2MontoEscrito;
		public void GenerateUndo()
		{
			m_oldA2MontoEscrito=new A2MontoEscrito();
			m_oldA2MontoEscrito.bytTipoCifra = m_bytTipoCifra;
			m_oldA2MontoEscrito.bytPosicionCifra = m_bytPosicionCifra;
			m_oldA2MontoEscrito.strCifra = m_strCifra;
		}

		public A2MontoEscrito OldA2MontoEscrito
		{
			get { return m_oldA2MontoEscrito;}
		}
		// Return the changed fields
		public string[] FieldChanged()
		{
			List<string> fields=new List<string>();
			if (m_oldA2MontoEscrito.bytTipoCifra != m_bytTipoCifra) fields.Add("bytTipoCifra");
			if (m_oldA2MontoEscrito.bytPosicionCifra != m_bytPosicionCifra) fields.Add("bytPosicionCifra");
			if (m_oldA2MontoEscrito.strCifra != m_strCifra) fields.Add("strCifra");
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


		// Field for storing the A2MontoEscrito's bytTipoCifra value
		private byte m_bytTipoCifra;

		// Field for storing the A2MontoEscrito's bytPosicionCifra value
		private byte m_bytPosicionCifra;

		// Field for storing the A2MontoEscrito's strCifra value
		private string m_strCifra;

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
		/// Attribute for access the A2MontoEscrito's bytTipoCifra value (byte)
		/// </summary>
		[DataMember]
		public byte bytTipoCifra
		{
			get { return m_bytTipoCifra; }
			set 
			{
				m_changed=true;
				m_bytTipoCifra = value;
			}
		}

		/// <summary>
		/// Attribute for access the A2MontoEscrito's bytPosicionCifra value (byte)
		/// </summary>
		[DataMember]
		public byte bytPosicionCifra
		{
			get { return m_bytPosicionCifra; }
			set 
			{
				m_changed=true;
				m_bytPosicionCifra = value;
			}
		}

		/// <summary>
		/// Attribute for access the A2MontoEscrito's strCifra value (string)
		/// </summary>
		[DataMember]
		public string strCifra
		{
			get { return m_strCifra; }
			set 
			{
				m_changed=true;
				m_strCifra = value;
			}
		}

		public object GetAttribute(string pattribute)
		{
			switch (pattribute)
			{
				case "bytTipoCifra": return bytTipoCifra;
				case "bytPosicionCifra": return bytPosicionCifra;
				case "strCifra": return strCifra;
				default: return null;
			}
		}

		public Type GetAttributeType(string pattribute)
		{
			return A2MontoEscritoController.Instance.GetMethodType(pattribute, this);
		}

		public string GetSqlKey()
		{
			return "";
		}
		#endregion

	}

	#endregion

	#region A2MontoEscritoList object

	/// <summary>
	/// Class for reading and access a list of A2MontoEscrito object
	/// </summary>
	[CollectionDataContract]
	public partial class A2MontoEscritoList : List<A2MontoEscrito>
	{

		/// <summary>
		/// Default constructor
		/// </summary>
		public A2MontoEscritoList()
		{
		}
	}

	#endregion

}
