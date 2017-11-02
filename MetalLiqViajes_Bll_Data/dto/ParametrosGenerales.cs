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
	#region ParametrosGenerales object

	[DataContract]
	public partial class ParametrosGenerales : IDTOObject
	{
		/// <summary>
		/// Default constructor
		/// </summary>
		public ParametrosGenerales()
		{
			m_Codigo = 0;
			m_Descipcion = null;
			m_ValorParametro = null;
			m_changed=false;
		}
		        //Return the table name of object
		        public string TableName()
		        {
		            return "ParametrosGenerales";
		        }
		#region Undo 
		// Internal class for storing changes
		private ParametrosGenerales m_oldParametrosGenerales;
		public void GenerateUndo()
		{
			m_oldParametrosGenerales=new ParametrosGenerales();
			m_oldParametrosGenerales.m_Codigo = m_Codigo;
			m_oldParametrosGenerales.Descipcion = m_Descipcion;
			m_oldParametrosGenerales.ValorParametro = m_ValorParametro;
		}

		public ParametrosGenerales OldParametrosGenerales
		{
			get { return m_oldParametrosGenerales;}
		}
		// Return the changed fields
		public string[] FieldChanged()
		{
			List<string> fields=new List<string>();
			if (m_oldParametrosGenerales.Descipcion != m_Descipcion) fields.Add("Descipcion");
			if (m_oldParametrosGenerales.ValorParametro != m_ValorParametro) fields.Add("ValorParametro");
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


		// Field for storing the ParametrosGenerales's Codigo value
		private int m_Codigo;

		// Field for storing the ParametrosGenerales's Descipcion value
		private string m_Descipcion;

		// Field for storing the ParametrosGenerales's ValorParametro value
		private string m_ValorParametro;

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
		/// Attribute for access the ParametrosGenerales's Codigo value (int)
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
		/// Attribute for access the ParametrosGenerales's Descipcion value (string)
		/// </summary>
		[DataMember]
		public string Descipcion
		{
			get { return m_Descipcion; }
			set 
			{
				m_changed=true;
				m_Descipcion = value;
			}
		}

		/// <summary>
		/// Attribute for access the ParametrosGenerales's ValorParametro value (string)
		/// </summary>
		[DataMember]
		public string ValorParametro
		{
			get { return m_ValorParametro; }
			set 
			{
				m_changed=true;
				m_ValorParametro = value;
			}
		}

		public object GetAttribute(string pattribute)
		{
			switch (pattribute)
			{
				case "Codigo": return Codigo;
				case "Descipcion": return Descipcion;
				case "ValorParametro": return ValorParametro;
				default: return null;
			}
		}

		public Type GetAttributeType(string pattribute)
		{
			return ParametrosGeneralesController.Instance.GetMethodType(pattribute, this);
		}

		public string GetSqlKey()
		{
			return "[Codigo] = " + Codigo.ToString();
		}
		#endregion

	}

	#endregion

	#region ParametrosGeneralesList object

	/// <summary>
	/// Class for reading and access a list of ParametrosGenerales object
	/// </summary>
	[CollectionDataContract]
	public partial class ParametrosGeneralesList : List<ParametrosGenerales>
	{

		/// <summary>
		/// Default constructor
		/// </summary>
		public ParametrosGeneralesList()
		{
		}
	}

	#endregion

}
