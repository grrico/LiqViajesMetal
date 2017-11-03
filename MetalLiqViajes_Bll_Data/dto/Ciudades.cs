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
	#region Ciudades object

	[DataContract]
	public partial class Ciudades : IDTOObject
	{
		/// <summary>
		/// Default constructor
		/// </summary>
		public Ciudades()
		{
			m_lngIdCiudad = 0;
			m_lngIdDepartamento = 0;
			m_strNombreCiudad = "";
			m_changed=false;
		}
		        //Return the table name of object
		        public string TableName()
		        {
		            return "tblCiudades";
		        }
		#region Undo 
		// Internal class for storing changes
		private Ciudades m_oldCiudades;
		public void GenerateUndo()
		{
			m_oldCiudades=new Ciudades();
			m_oldCiudades.m_lngIdCiudad = m_lngIdCiudad;
			m_oldCiudades.lngIdDepartamento = m_lngIdDepartamento;
			m_oldCiudades.strNombreCiudad = m_strNombreCiudad;
		}

		public Ciudades OldCiudades
		{
			get { return m_oldCiudades;}
		}
		// Return the changed fields
		public string[] FieldChanged()
		{
			List<string> fields=new List<string>();
			if (m_oldCiudades.lngIdDepartamento != m_lngIdDepartamento) fields.Add("lngIdDepartamento");
			if (m_oldCiudades.strNombreCiudad != m_strNombreCiudad) fields.Add("strNombreCiudad");
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


		// Field for storing the Ciudades's lngIdDepartamento value
		private int m_lngIdDepartamento;

		// Field for storing the Ciudades's strNombreCiudad value
		private string m_strNombreCiudad;

		// Field for storing the Ciudades's lngIdCiudad value
		private int m_lngIdCiudad;

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
		/// Attribute for access the Ciudades's lngIdDepartamento value (int)
		/// </summary>
		[DataMember]
		public int lngIdDepartamento
		{
			get { return m_lngIdDepartamento; }
			set 
			{
				m_changed=true;
				m_lngIdDepartamento = value;
			}
		}

		/// <summary>
		/// Attribute for access the Ciudades's strNombreCiudad value (string)
		/// </summary>
		[DataMember]
		public string strNombreCiudad
		{
			get { return m_strNombreCiudad; }
			set 
			{
				m_changed=true;
				m_strNombreCiudad = value;
			}
		}

		/// <summary>
		/// Attribute for access the Ciudades's lngIdCiudad value (int)
		/// </summary>
		[DataMember]
		public int lngIdCiudad
		{
			get { return m_lngIdCiudad; }
			set 
			{
				m_changed=true;
				m_lngIdCiudad = value;
			}
		}

		public object GetAttribute(string pattribute)
		{
			switch (pattribute)
			{
				case "lngIdDepartamento": return lngIdDepartamento;
				case "strNombreCiudad": return strNombreCiudad;
				case "lngIdCiudad": return lngIdCiudad;
				default: return null;
			}
		}

		public Type GetAttributeType(string pattribute)
		{
			return CiudadesController.Instance.GetMethodType(pattribute, this);
		}

		public string GetSqlKey()
		{
			return "[lngIdCiudad] = " + lngIdCiudad.ToString();
		}
		#endregion

	}

	#endregion

	#region CiudadesList object

	/// <summary>
	/// Class for reading and access a list of Ciudades object
	/// </summary>
	[CollectionDataContract]
	public partial class CiudadesList : List<Ciudades>
	{

		/// <summary>
		/// Default constructor
		/// </summary>
		public CiudadesList()
		{
		}
	}

	#endregion

}
