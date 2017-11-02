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
	#region tablagLocal object

	[DataContract]
	public partial class tablagLocal : IDTOObject
	{
		/// <summary>
		/// Default constructor
		/// </summary>
		public tablagLocal()
		{
			m_Codigo = 0;
			m_ano = null;
			m_periodo = null;
			m_fecha = null;
			m_changed=false;
		}
		        //Return the table name of object
		        public string TableName()
		        {
		            return "tablagLocal";
		        }
		#region Undo 
		// Internal class for storing changes
		private tablagLocal m_oldtablagLocal;
		public void GenerateUndo()
		{
			m_oldtablagLocal=new tablagLocal();
			m_oldtablagLocal.m_Codigo = m_Codigo;
			m_oldtablagLocal.ano = m_ano;
			m_oldtablagLocal.periodo = m_periodo;
			m_oldtablagLocal.fecha = m_fecha;
		}

		public tablagLocal OldtablagLocal
		{
			get { return m_oldtablagLocal;}
		}
		// Return the changed fields
		public string[] FieldChanged()
		{
			List<string> fields=new List<string>();
			if (m_oldtablagLocal.ano != m_ano) fields.Add("ano");
			if (m_oldtablagLocal.periodo != m_periodo) fields.Add("periodo");
			if (m_oldtablagLocal.fecha != m_fecha) fields.Add("fecha");
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


		// Field for storing the tablagLocal's Codigo value
		private int m_Codigo;

		// Field for storing the tablagLocal's ano value
		private int? m_ano;

		// Field for storing the tablagLocal's periodo value
		private int? m_periodo;

		// Field for storing the tablagLocal's fecha value
		private DateTime? m_fecha;

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
		/// Attribute for access the tablagLocal's Codigo value (int)
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
		/// Attribute for access the tablagLocal's ano value (int)
		/// </summary>
		[DataMember]
		public int? ano
		{
			get { return m_ano; }
			set 
			{
				m_changed=true;
				m_ano = value;
			}
		}

		/// <summary>
		/// Attribute for access the tablagLocal's periodo value (int)
		/// </summary>
		[DataMember]
		public int? periodo
		{
			get { return m_periodo; }
			set 
			{
				m_changed=true;
				m_periodo = value;
			}
		}

		/// <summary>
		/// Attribute for access the tablagLocal's fecha value (DateTime)
		/// </summary>
		[DataMember]
		public DateTime? fecha
		{
			get { return m_fecha; }
			set 
			{
				m_changed=true;
				m_fecha = value;
			}
		}

		public object GetAttribute(string pattribute)
		{
			switch (pattribute)
			{
				case "Codigo": return Codigo;
				case "ano": return ano;
				case "periodo": return periodo;
				case "fecha": return fecha;
				default: return null;
			}
		}

		public Type GetAttributeType(string pattribute)
		{
			return tablagLocalController.Instance.GetMethodType(pattribute, this);
		}

		public string GetSqlKey()
		{
			return "[Codigo] = " + Codigo.ToString();
		}
		#endregion

	}

	#endregion

	#region tablagLocalList object

	/// <summary>
	/// Class for reading and access a list of tablagLocal object
	/// </summary>
	[CollectionDataContract]
	public partial class tablagLocalList : List<tablagLocal>
	{

		/// <summary>
		/// Default constructor
		/// </summary>
		public tablagLocalList()
		{
		}
	}

	#endregion

}
