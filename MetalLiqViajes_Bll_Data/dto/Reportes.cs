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
	#region Reportes object

	[DataContract]
	public partial class Reportes : IDTOObject
	{
		/// <summary>
		/// Default constructor
		/// </summary>
		public Reportes()
		{
			m_Codigo = 0;
			m_Descripcion = null;
			m_Activo = false;
			m_strSQql = null;
			m_changed=false;
		}
		        //Return the table name of object
		        public string TableName()
		        {
		            return "Reportes";
		        }
		#region Undo 
		// Internal class for storing changes
		private Reportes m_oldReportes;
		public void GenerateUndo()
		{
			m_oldReportes=new Reportes();
			m_oldReportes.m_Codigo = m_Codigo;
			m_oldReportes.Descripcion = m_Descripcion;
			m_oldReportes.Activo = m_Activo;
			m_oldReportes.strSQql = m_strSQql;
		}

		public Reportes OldReportes
		{
			get { return m_oldReportes;}
		}
		// Return the changed fields
		public string[] FieldChanged()
		{
			List<string> fields=new List<string>();
			if (m_oldReportes.Descripcion != m_Descripcion) fields.Add("Descripcion");
			if (m_oldReportes.Activo != m_Activo) fields.Add("Activo");
			if (m_oldReportes.strSQql != m_strSQql) fields.Add("strSQql");
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


		// Field for storing the Reportes's Codigo value
		private int m_Codigo;

		// Field for storing the Reportes's Descripcion value
		private string m_Descripcion;

		// Field for storing the Reportes's Activo value
		private bool? m_Activo;

		// Field for storing the Reportes's strSQql value
		private string m_strSQql;

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
		/// Attribute for access the Reportes's Codigo value (int)
		/// </summary>
		[DataMember]
		public int Codigo
		{
			get { return m_Codigo; }
			set 
			{
				m_changed=true;
				m_Codigo = value;
			}
		}

		/// <summary>
		/// Attribute for access the Reportes's Descripcion value (string)
		/// </summary>
		[DataMember]
		public string Descripcion
		{
			get { return m_Descripcion; }
			set 
			{
				m_changed=true;
				m_Descripcion = value;
			}
		}

		/// <summary>
		/// Attribute for access the Reportes's Activo value (bool)
		/// </summary>
		[DataMember]
		public bool? Activo
		{
			get { return m_Activo; }
			set 
			{
				m_changed=true;
				m_Activo = value;
			}
		}

		/// <summary>
		/// Attribute for access the Reportes's strSQql value (string)
		/// </summary>
		[DataMember]
		public string strSQql
		{
			get { return m_strSQql; }
			set 
			{
				m_changed=true;
				m_strSQql = value;
			}
		}

		public object GetAttribute(string pattribute)
		{
			switch (pattribute)
			{
				case "Codigo": return Codigo;
				case "Descripcion": return Descripcion;
				case "Activo": return Activo;
				case "strSQql": return strSQql;
				default: return null;
			}
		}

		public Type GetAttributeType(string pattribute)
		{
			return ReportesController.Instance.GetMethodType(pattribute, this);
		}

		public string GetSqlKey()
		{
			return "[Codigo] = " + Codigo.ToString();
		}
		#endregion

	}

	#endregion

	#region ReportesList object

	/// <summary>
	/// Class for reading and access a list of Reportes object
	/// </summary>
	[CollectionDataContract]
	public partial class ReportesList : List<Reportes>
	{

		/// <summary>
		/// Default constructor
		/// </summary>
		public ReportesList()
		{
		}
	}

	#endregion

}
