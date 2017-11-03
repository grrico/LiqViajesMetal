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
	#region Parametros object

	[DataContract]
	public partial class Parametros : IDTOObject
	{
		/// <summary>
		/// Default constructor
		/// </summary>
		public Parametros()
		{
			m_lngIdParaMetro = 0;
			m_intBanco = null;
			m_LogAvisarConductores = false;
			m_changed=false;
		}
		        //Return the table name of object
		        public string TableName()
		        {
		            return "tblParametros";
		        }
		#region Undo 
		// Internal class for storing changes
		private Parametros m_oldParametros;
		public void GenerateUndo()
		{
			m_oldParametros=new Parametros();
			m_oldParametros.m_lngIdParaMetro = m_lngIdParaMetro;
			m_oldParametros.intBanco = m_intBanco;
			m_oldParametros.LogAvisarConductores = m_LogAvisarConductores;
		}

		public Parametros OldParametros
		{
			get { return m_oldParametros;}
		}
		// Return the changed fields
		public string[] FieldChanged()
		{
			List<string> fields=new List<string>();
			if (m_oldParametros.intBanco != m_intBanco) fields.Add("intBanco");
			if (m_oldParametros.LogAvisarConductores != m_LogAvisarConductores) fields.Add("LogAvisarConductores");
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


		// Field for storing the Parametros's intBanco value
		private int? m_intBanco;

		// Field for storing the Parametros's LogAvisarConductores value
		private bool? m_LogAvisarConductores;

		// Field for storing the Parametros's lngIdParaMetro value
		private int m_lngIdParaMetro;

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
		/// Attribute for access the Parametros's intBanco value (int)
		/// </summary>
		[DataMember]
		public int? intBanco
		{
			get { return m_intBanco; }
			set 
			{
				m_changed=true;
				m_intBanco = value;
			}
		}

		/// <summary>
		/// Attribute for access the Parametros's LogAvisarConductores value (bool)
		/// </summary>
		[DataMember]
		public bool? LogAvisarConductores
		{
			get { return m_LogAvisarConductores; }
			set 
			{
				m_changed=true;
				m_LogAvisarConductores = value;
			}
		}

		/// <summary>
		/// Attribute for access the Parametros's lngIdParaMetro value (int)
		/// </summary>
		[DataMember]
		public int lngIdParaMetro
		{
			get { return m_lngIdParaMetro; }
			set 
			{
				m_changed=true;
				m_lngIdParaMetro = value;
			}
		}

		public object GetAttribute(string pattribute)
		{
			switch (pattribute)
			{
				case "intBanco": return intBanco;
				case "LogAvisarConductores": return LogAvisarConductores;
				case "lngIdParaMetro": return lngIdParaMetro;
				default: return null;
			}
		}

		public Type GetAttributeType(string pattribute)
		{
			return ParametrosController.Instance.GetMethodType(pattribute, this);
		}

		public string GetSqlKey()
		{
			return "[lngIdParaMetro] = " + lngIdParaMetro.ToString();
		}
		#endregion

	}

	#endregion

	#region ParametrosList object

	/// <summary>
	/// Class for reading and access a list of Parametros object
	/// </summary>
	[CollectionDataContract]
	public partial class ParametrosList : List<Parametros>
	{

		/// <summary>
		/// Default constructor
		/// </summary>
		public ParametrosList()
		{
		}
	}

	#endregion

}
