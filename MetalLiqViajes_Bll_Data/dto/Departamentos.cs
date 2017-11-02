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
	#region Departamentos object

	[DataContract]
	public partial class Departamentos : IDTOObject
	{
		/// <summary>
		/// Default constructor
		/// </summary>
		public Departamentos()
		{
			m_lngIdDepartamento = 0;
			m_lngIdPais = 0;
			m_strNombre = "";
			m_changed=false;
		}
		        //Return the table name of object
		        public string TableName()
		        {
		            return "tblDepartamentos";
		        }
		#region Undo 
		// Internal class for storing changes
		private Departamentos m_oldDepartamentos;
		public void GenerateUndo()
		{
			m_oldDepartamentos=new Departamentos();
			m_oldDepartamentos.m_lngIdDepartamento = m_lngIdDepartamento;
			m_oldDepartamentos.lngIdPais = m_lngIdPais;
			m_oldDepartamentos.strNombre = m_strNombre;
		}

		public Departamentos OldDepartamentos
		{
			get { return m_oldDepartamentos;}
		}
		// Return the changed fields
		public string[] FieldChanged()
		{
			List<string> fields=new List<string>();
			if (m_oldDepartamentos.lngIdPais != m_lngIdPais) fields.Add("lngIdPais");
			if (m_oldDepartamentos.strNombre != m_strNombre) fields.Add("strNombre");
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


		// Field for storing the Departamentos's lngIdDepartamento value
		private int m_lngIdDepartamento;

		// Field for storing the Departamentos's lngIdPais value
		private int m_lngIdPais;

		// Field for storing the Departamentos's strNombre value
		private string m_strNombre;

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
		/// Attribute for access the Departamentos's lngIdDepartamento value (int)
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
		/// Attribute for access the Departamentos's lngIdPais value (int)
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

		/// <summary>
		/// Attribute for access the Departamentos's strNombre value (string)
		/// </summary>
		[DataMember]
		public string strNombre
		{
			get { return m_strNombre; }
			set 
			{
				m_changed=true;
				m_strNombre = value;
			}
		}

		public object GetAttribute(string pattribute)
		{
			switch (pattribute)
			{
				case "lngIdDepartamento": return lngIdDepartamento;
				case "lngIdPais": return lngIdPais;
				case "strNombre": return strNombre;
				default: return null;
			}
		}

		public Type GetAttributeType(string pattribute)
		{
			return DepartamentosController.Instance.GetMethodType(pattribute, this);
		}

		public string GetSqlKey()
		{
			return "[lngIdDepartamento] = " + lngIdDepartamento.ToString();
		}
		#endregion

	}

	#endregion

	#region DepartamentosList object

	/// <summary>
	/// Class for reading and access a list of Departamentos object
	/// </summary>
	[CollectionDataContract]
	public partial class DepartamentosList : List<Departamentos>
	{

		/// <summary>
		/// Default constructor
		/// </summary>
		public DepartamentosList()
		{
		}
	}

	#endregion

}
