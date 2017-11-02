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
	#region Cuentas object

	[DataContract]
	public partial class Cuentas : IDTOObject
	{
		/// <summary>
		/// Default constructor
		/// </summary>
		public Cuentas()
		{
			m_Codigo = 0;
			m_strCuenta = "";
			m_strDescripcion = null;
			m_logAnticipo = false;
			m_nitTercero = null;
			m_intNoColReferencia = null;
			m_sngPorcenrajeAplica = null;
			m_strCuentaAplica = null;
			m_strCuentaNiif = null;
			m_Norma = null;
			m_changed=false;
		}
		        //Return the table name of object
		        public string TableName()
		        {
		            return "tblCuentas";
		        }
		#region Undo 
		// Internal class for storing changes
		private Cuentas m_oldCuentas;
		public void GenerateUndo()
		{
			m_oldCuentas=new Cuentas();
			m_oldCuentas.m_Codigo = m_Codigo;
			m_oldCuentas.strCuenta = m_strCuenta;
			m_oldCuentas.strDescripcion = m_strDescripcion;
			m_oldCuentas.logAnticipo = m_logAnticipo;
			m_oldCuentas.nitTercero = m_nitTercero;
			m_oldCuentas.intNoColReferencia = m_intNoColReferencia;
			m_oldCuentas.sngPorcenrajeAplica = m_sngPorcenrajeAplica;
			m_oldCuentas.strCuentaAplica = m_strCuentaAplica;
			m_oldCuentas.strCuentaNiif = m_strCuentaNiif;
			m_oldCuentas.Norma = m_Norma;
		}

		public Cuentas OldCuentas
		{
			get { return m_oldCuentas;}
		}
		// Return the changed fields
		public string[] FieldChanged()
		{
			List<string> fields=new List<string>();
			if (m_oldCuentas.strCuenta != m_strCuenta) fields.Add("strCuenta");
			if (m_oldCuentas.strDescripcion != m_strDescripcion) fields.Add("strDescripcion");
			if (m_oldCuentas.logAnticipo != m_logAnticipo) fields.Add("logAnticipo");
			if (m_oldCuentas.nitTercero != m_nitTercero) fields.Add("nitTercero");
			if (m_oldCuentas.intNoColReferencia != m_intNoColReferencia) fields.Add("intNoColReferencia");
			if (m_oldCuentas.sngPorcenrajeAplica != m_sngPorcenrajeAplica) fields.Add("sngPorcenrajeAplica");
			if (m_oldCuentas.strCuentaAplica != m_strCuentaAplica) fields.Add("strCuentaAplica");
			if (m_oldCuentas.strCuentaNiif != m_strCuentaNiif) fields.Add("strCuentaNiif");
			if (m_oldCuentas.Norma != m_Norma) fields.Add("Norma");
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


		// Field for storing the Cuentas's Codigo value
		private int m_Codigo;

		// Field for storing the Cuentas's strCuenta value
		private string m_strCuenta;

		// Field for storing the Cuentas's strDescripcion value
		private string m_strDescripcion;

		// Field for storing the Cuentas's logAnticipo value
		private bool? m_logAnticipo;

		// Field for storing the Cuentas's nitTercero value
		private string m_nitTercero;

		// Field for storing the Cuentas's intNoColReferencia value
		private int? m_intNoColReferencia;

		// Field for storing the Cuentas's sngPorcenrajeAplica value
		private double? m_sngPorcenrajeAplica;

		// Field for storing the Cuentas's strCuentaAplica value
		private string m_strCuentaAplica;

		// Field for storing the Cuentas's strCuentaNiif value
		private string m_strCuentaNiif;

		// Field for storing the Cuentas's Norma value
		private string m_Norma;

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
		/// Attribute for access the Cuentas's Codigo value (int)
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
		/// Attribute for access the Cuentas's strCuenta value (string)
		/// </summary>
		[DataMember]
		public string strCuenta
		{
			get { return m_strCuenta; }
			set 
			{
				m_changed=true;
				m_strCuenta = value;
			}
		}

		/// <summary>
		/// Attribute for access the Cuentas's strDescripcion value (string)
		/// </summary>
		[DataMember]
		public string strDescripcion
		{
			get { return m_strDescripcion; }
			set 
			{
				m_changed=true;
				m_strDescripcion = value;
			}
		}

		/// <summary>
		/// Attribute for access the Cuentas's logAnticipo value (bool)
		/// </summary>
		[DataMember]
		public bool? logAnticipo
		{
			get { return m_logAnticipo; }
			set 
			{
				m_changed=true;
				m_logAnticipo = value;
			}
		}

		/// <summary>
		/// Attribute for access the Cuentas's nitTercero value (string)
		/// </summary>
		[DataMember]
		public string nitTercero
		{
			get { return m_nitTercero; }
			set 
			{
				m_changed=true;
				m_nitTercero = value;
			}
		}

		/// <summary>
		/// Attribute for access the Cuentas's intNoColReferencia value (int)
		/// </summary>
		[DataMember]
		public int? intNoColReferencia
		{
			get { return m_intNoColReferencia; }
			set 
			{
				m_changed=true;
				m_intNoColReferencia = value;
			}
		}

		/// <summary>
		/// Attribute for access the Cuentas's sngPorcenrajeAplica value (double)
		/// </summary>
		[DataMember]
		public double? sngPorcenrajeAplica
		{
			get { return m_sngPorcenrajeAplica; }
			set 
			{
				m_changed=true;
				m_sngPorcenrajeAplica = value;
			}
		}

		/// <summary>
		/// Attribute for access the Cuentas's strCuentaAplica value (string)
		/// </summary>
		[DataMember]
		public string strCuentaAplica
		{
			get { return m_strCuentaAplica; }
			set 
			{
				m_changed=true;
				m_strCuentaAplica = value;
			}
		}

		/// <summary>
		/// Attribute for access the Cuentas's strCuentaNiif value (string)
		/// </summary>
		[DataMember]
		public string strCuentaNiif
		{
			get { return m_strCuentaNiif; }
			set 
			{
				m_changed=true;
				m_strCuentaNiif = value;
			}
		}

		/// <summary>
		/// Attribute for access the Cuentas's Norma value (string)
		/// </summary>
		[DataMember]
		public string Norma
		{
			get { return m_Norma; }
			set 
			{
				m_changed=true;
				m_Norma = value;
			}
		}

		public object GetAttribute(string pattribute)
		{
			switch (pattribute)
			{
				case "Codigo": return Codigo;
				case "strCuenta": return strCuenta;
				case "strDescripcion": return strDescripcion;
				case "logAnticipo": return logAnticipo;
				case "nitTercero": return nitTercero;
				case "intNoColReferencia": return intNoColReferencia;
				case "sngPorcenrajeAplica": return sngPorcenrajeAplica;
				case "strCuentaAplica": return strCuentaAplica;
				case "strCuentaNiif": return strCuentaNiif;
				case "Norma": return Norma;
				default: return null;
			}
		}

		public Type GetAttributeType(string pattribute)
		{
			return CuentasController.Instance.GetMethodType(pattribute, this);
		}

		public string GetSqlKey()
		{
			return "[Codigo] = " + Codigo.ToString();
		}
		#endregion

	}

	#endregion

	#region CuentasList object

	/// <summary>
	/// Class for reading and access a list of Cuentas object
	/// </summary>
	[CollectionDataContract]
	public partial class CuentasList : List<Cuentas>
	{

		/// <summary>
		/// Default constructor
		/// </summary>
		public CuentasList()
		{
		}
	}

	#endregion

}
