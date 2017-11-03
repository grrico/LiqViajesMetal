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
	#region RangoKilometros object

	[DataContract]
	public partial class RangoKilometros : IDTOObject
	{
		/// <summary>
		/// Default constructor
		/// </summary>
		public RangoKilometros()
		{
			m_Codigo = 0;
			m_RangoInicial = 0;
			m_RangoFinal = 0;
			m_Kilometros = 0;
			m_Valor = 0;
			m_changed=false;
		}
		        //Return the table name of object
		        public string TableName()
		        {
		            return "tblRangoKilometros";
		        }
		#region Undo 
		// Internal class for storing changes
		private RangoKilometros m_oldRangoKilometros;
		public void GenerateUndo()
		{
			m_oldRangoKilometros=new RangoKilometros();
			m_oldRangoKilometros.m_Codigo = m_Codigo;
			m_oldRangoKilometros.RangoInicial = m_RangoInicial;
			m_oldRangoKilometros.RangoFinal = m_RangoFinal;
			m_oldRangoKilometros.Kilometros = m_Kilometros;
			m_oldRangoKilometros.Valor = m_Valor;
		}

		public RangoKilometros OldRangoKilometros
		{
			get { return m_oldRangoKilometros;}
		}
		// Return the changed fields
		public string[] FieldChanged()
		{
			List<string> fields=new List<string>();
			if (m_oldRangoKilometros.RangoInicial != m_RangoInicial) fields.Add("RangoInicial");
			if (m_oldRangoKilometros.RangoFinal != m_RangoFinal) fields.Add("RangoFinal");
			if (m_oldRangoKilometros.Kilometros != m_Kilometros) fields.Add("Kilometros");
			if (m_oldRangoKilometros.Valor != m_Valor) fields.Add("Valor");
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


		// Field for storing the RangoKilometros's RangoInicial value
		private float m_RangoInicial;

		// Field for storing the RangoKilometros's RangoFinal value
		private float m_RangoFinal;

		// Field for storing the RangoKilometros's Kilometros value
		private float m_Kilometros;

		// Field for storing the RangoKilometros's Valor value
		private decimal m_Valor;

		// Field for storing the RangoKilometros's Codigo value
		private int m_Codigo;

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
		/// Attribute for access the RangoKilometros's RangoInicial value (float)
		/// </summary>
		[DataMember]
		public float RangoInicial
		{
			get { return m_RangoInicial; }
			set 
			{
				m_changed=true;
				m_RangoInicial = value;
			}
		}

		/// <summary>
		/// Attribute for access the RangoKilometros's RangoFinal value (float)
		/// </summary>
		[DataMember]
		public float RangoFinal
		{
			get { return m_RangoFinal; }
			set 
			{
				m_changed=true;
				m_RangoFinal = value;
			}
		}

		/// <summary>
		/// Attribute for access the RangoKilometros's Kilometros value (float)
		/// </summary>
		[DataMember]
		public float Kilometros
		{
			get { return m_Kilometros; }
			set 
			{
				m_changed=true;
				m_Kilometros = value;
			}
		}

		/// <summary>
		/// Attribute for access the RangoKilometros's Valor value (decimal)
		/// </summary>
		[DataMember]
		public decimal Valor
		{
			get { return m_Valor; }
			set 
			{
				m_changed=true;
				m_Valor = value;
			}
		}

		/// <summary>
		/// Attribute for access the RangoKilometros's Codigo value (int)
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

		public object GetAttribute(string pattribute)
		{
			switch (pattribute)
			{
				case "RangoInicial": return RangoInicial;
				case "RangoFinal": return RangoFinal;
				case "Kilometros": return Kilometros;
				case "Valor": return Valor;
				case "Codigo": return Codigo;
				default: return null;
			}
		}

		public Type GetAttributeType(string pattribute)
		{
			return RangoKilometrosController.Instance.GetMethodType(pattribute, this);
		}

		public string GetSqlKey()
		{
			return "[Codigo] = " + Codigo.ToString();
		}
		#endregion

	}

	#endregion

	#region RangoKilometrosList object

	/// <summary>
	/// Class for reading and access a list of RangoKilometros object
	/// </summary>
	[CollectionDataContract]
	public partial class RangoKilometrosList : List<RangoKilometros>
	{

		/// <summary>
		/// Default constructor
		/// </summary>
		public RangoKilometrosList()
		{
		}
	}

	#endregion

}
