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
	#region Paises object

	[DataContract]
	public partial class Paises : IDTOObject
	{
		/// <summary>
		/// Default constructor
		/// </summary>
		public Paises()
		{
			m_lngIdPais = 0;
			m_strNombrePais = "";
			m_changed=false;
		}
		        //Return the table name of object
		        public string TableName()
		        {
		            return "tblPaises";
		        }
		#region Undo 
		// Internal class for storing changes
		private Paises m_oldPaises;
		public void GenerateUndo()
		{
			m_oldPaises=new Paises();
			m_oldPaises.m_lngIdPais = m_lngIdPais;
			m_oldPaises.strNombrePais = m_strNombrePais;
		}

		public Paises OldPaises
		{
			get { return m_oldPaises;}
		}
		// Return the changed fields
		public string[] FieldChanged()
		{
			List<string> fields=new List<string>();
			if (m_oldPaises.strNombrePais != m_strNombrePais) fields.Add("strNombrePais");
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


		// Field for storing the Paises's strNombrePais value
		private string m_strNombrePais;

		// Field for storing the Paises's lngIdPais value
		private int m_lngIdPais;

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
		/// Attribute for access the Paises's strNombrePais value (string)
		/// </summary>
		[DataMember]
		public string strNombrePais
		{
			get { return m_strNombrePais; }
			set 
			{
				m_changed=true;
				m_strNombrePais = value;
			}
		}

		/// <summary>
		/// Attribute for access the Paises's lngIdPais value (int)
		/// </summary>
		[DataMember]
		public int lngIdPais
		{
			get { return m_lngIdPais; }
			set 
			{
				m_changed=true;
				m_lngIdPais = value;
			}
		}

		public object GetAttribute(string pattribute)
		{
			switch (pattribute)
			{
				case "strNombrePais": return strNombrePais;
				case "lngIdPais": return lngIdPais;
				default: return null;
			}
		}

		public Type GetAttributeType(string pattribute)
		{
			return PaisesController.Instance.GetMethodType(pattribute, this);
		}

		public string GetSqlKey()
		{
			return "[lngIdPais] = " + lngIdPais.ToString();
		}
		#endregion

	}

	#endregion

	#region PaisesList object

	/// <summary>
	/// Class for reading and access a list of Paises object
	/// </summary>
	[CollectionDataContract]
	public partial class PaisesList : List<Paises>
	{

		/// <summary>
		/// Default constructor
		/// </summary>
		public PaisesList()
		{
		}
	}

	#endregion

}
