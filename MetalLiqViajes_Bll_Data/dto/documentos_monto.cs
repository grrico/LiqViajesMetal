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
	#region documentos_monto object

	[DataContract]
	public partial class documentos_monto : IDTOObject
	{
		/// <summary>
		/// Default constructor
		/// </summary>
		public documentos_monto()
		{
			m_tipo = "";
			m_numero = 0;
			m_monto = null;
			m_changed=false;
		}
		        //Return the table name of object
		        public string TableName()
		        {
		            return "documentos_monto";
		        }
		#region Undo 
		// Internal class for storing changes
		private documentos_monto m_olddocumentos_monto;
		public void GenerateUndo()
		{
			m_olddocumentos_monto=new documentos_monto();
			m_olddocumentos_monto.m_tipo = m_tipo;
			m_olddocumentos_monto.m_numero = m_numero;
			m_olddocumentos_monto.monto = m_monto;
		}

		public documentos_monto Olddocumentos_monto
		{
			get { return m_olddocumentos_monto;}
		}
		// Return the changed fields
		public string[] FieldChanged()
		{
			List<string> fields=new List<string>();
			if (m_olddocumentos_monto.monto != m_monto) fields.Add("monto");
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


		// Field for storing the documentos_monto's tipo value
		private string m_tipo;

		// Field for storing the documentos_monto's numero value
		private int m_numero;

		// Field for storing the documentos_monto's monto value
		private string m_monto;

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
		/// Attribute for access the documentos_monto's tipo value (string)
		/// </summary>
		[DataMember]
		public string tipo
		{
			get { return m_tipo; }
			set 
			{
				m_changed=true;
				m_tipo = value;
			}
		}

		/// <summary>
		/// Attribute for access the documentos_monto's numero value (int)
		/// </summary>
		[DataMember]
		public int numero
		{
			get { return m_numero; }
			set 
			{
				m_changed=true;
				m_numero = value;
			}
		}

		/// <summary>
		/// Attribute for access the documentos_monto's monto value (string)
		/// </summary>
		[DataMember]
		public string monto
		{
			get { return m_monto; }
			set 
			{
				m_changed=true;
				m_monto = value;
			}
		}

		public object GetAttribute(string pattribute)
		{
			switch (pattribute)
			{
				case "tipo": return tipo;
				case "numero": return numero;
				case "monto": return monto;
				default: return null;
			}
		}

		public Type GetAttributeType(string pattribute)
		{
			return documentos_montoController.Instance.GetMethodType(pattribute, this);
		}

		public string GetSqlKey()
		{
			return "[tipo] = '" + tipo.ToString()+ "'" + " AND [numero] = " + numero.ToString();
		}
		#endregion

	}

	#endregion

	#region documentos_montoList object

	/// <summary>
	/// Class for reading and access a list of documentos_monto object
	/// </summary>
	[CollectionDataContract]
	public partial class documentos_montoList : List<documentos_monto>
	{

		/// <summary>
		/// Default constructor
		/// </summary>
		public documentos_montoList()
		{
		}
	}

	#endregion

}
