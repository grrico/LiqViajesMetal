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
	#region CuentasVarios object

	[DataContract]
	public partial class CuentasVarios : IDTOObject
	{
		/// <summary>
		/// Default constructor
		/// </summary>
		public CuentasVarios()
		{
			m_strCuenta = "";
			m_strDescripcion = null;
			m_nitTercero = null;
			m_changed=false;
		}
		        //Return the table name of object
		        public string TableName()
		        {
		            return "tblCuentasVarios";
		        }
		#region Undo 
		// Internal class for storing changes
		private CuentasVarios m_oldCuentasVarios;
		public void GenerateUndo()
		{
			m_oldCuentasVarios=new CuentasVarios();
			m_oldCuentasVarios.m_strCuenta = m_strCuenta;
			m_oldCuentasVarios.strDescripcion = m_strDescripcion;
			m_oldCuentasVarios.nitTercero = m_nitTercero;
		}

		public CuentasVarios OldCuentasVarios
		{
			get { return m_oldCuentasVarios;}
		}
		// Return the changed fields
		public string[] FieldChanged()
		{
			List<string> fields=new List<string>();
			if (m_oldCuentasVarios.strDescripcion != m_strDescripcion) fields.Add("strDescripcion");
			if (m_oldCuentasVarios.nitTercero != m_nitTercero) fields.Add("nitTercero");
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


		// Field for storing the CuentasVarios's strCuenta value
		private string m_strCuenta;

		// Field for storing the CuentasVarios's strDescripcion value
		private string m_strDescripcion;

		// Field for storing the CuentasVarios's nitTercero value
		private string m_nitTercero;

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
		/// Attribute for access the CuentasVarios's strCuenta value (string)
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
		/// Attribute for access the CuentasVarios's strDescripcion value (string)
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
		/// Attribute for access the CuentasVarios's nitTercero value (string)
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

		public object GetAttribute(string pattribute)
		{
			switch (pattribute)
			{
				case "strCuenta": return strCuenta;
				case "strDescripcion": return strDescripcion;
				case "nitTercero": return nitTercero;
				default: return null;
			}
		}

		public Type GetAttributeType(string pattribute)
		{
			return CuentasVariosController.Instance.GetMethodType(pattribute, this);
		}

		public string GetSqlKey()
		{
			return "[strCuenta] = '" + strCuenta.ToString()+ "'";
		}
		#endregion

	}

	#endregion

	#region CuentasVariosList object

	/// <summary>
	/// Class for reading and access a list of CuentasVarios object
	/// </summary>
	[CollectionDataContract]
	public partial class CuentasVariosList : List<CuentasVarios>
	{

		/// <summary>
		/// Default constructor
		/// </summary>
		public CuentasVariosList()
		{
		}
	}

	#endregion

}
