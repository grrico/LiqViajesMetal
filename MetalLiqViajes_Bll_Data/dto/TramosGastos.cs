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
	#region TramosGastos object

	[DataContract]
	public partial class TramosGastos : IDTOObject
	{
		/// <summary>
		/// Default constructor
		/// </summary>
		public TramosGastos()
		{
			m_Codigo = 0;
			m_IdRegistroViaje = 0;
			m_Cuenta = null;
			m_DescripcionCuenta = null;
			m_ValorTotal = null;
			m_DescripcionTercero = null;
			m_changed=false;
		}
		        //Return the table name of object
		        public string TableName()
		        {
		            return "TramosGastos";
		        }
		#region Undo 
		// Internal class for storing changes
		private TramosGastos m_oldTramosGastos;
		public void GenerateUndo()
		{
			m_oldTramosGastos=new TramosGastos();
			m_oldTramosGastos.m_Codigo = m_Codigo;
			m_oldTramosGastos.IdRegistroViaje = m_IdRegistroViaje;
			m_oldTramosGastos.Cuenta = m_Cuenta;
			m_oldTramosGastos.DescripcionCuenta = m_DescripcionCuenta;
			m_oldTramosGastos.ValorTotal = m_ValorTotal;
			m_oldTramosGastos.DescripcionTercero = m_DescripcionTercero;
		}

		public TramosGastos OldTramosGastos
		{
			get { return m_oldTramosGastos;}
		}
		// Return the changed fields
		public string[] FieldChanged()
		{
			List<string> fields=new List<string>();
			if (m_oldTramosGastos.IdRegistroViaje != m_IdRegistroViaje) fields.Add("IdRegistroViaje");
			if (m_oldTramosGastos.Cuenta != m_Cuenta) fields.Add("Cuenta");
			if (m_oldTramosGastos.DescripcionCuenta != m_DescripcionCuenta) fields.Add("DescripcionCuenta");
			if (m_oldTramosGastos.ValorTotal != m_ValorTotal) fields.Add("ValorTotal");
			if (m_oldTramosGastos.DescripcionTercero != m_DescripcionTercero) fields.Add("DescripcionTercero");
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


		// Field for storing the TramosGastos's IdRegistroViaje value
		private long m_IdRegistroViaje;

		// Field for storing the TramosGastos's Cuenta value
		private string m_Cuenta;

		// Field for storing the TramosGastos's DescripcionCuenta value
		private string m_DescripcionCuenta;

		// Field for storing the TramosGastos's ValorTotal value
		private decimal? m_ValorTotal;

		// Field for storing the TramosGastos's DescripcionTercero value
		private string m_DescripcionTercero;

		// Field for storing the TramosGastos's Codigo value
		private long m_Codigo;

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
		/// Attribute for access the TramosGastos's IdRegistroViaje value (long)
		/// </summary>
		[DataMember]
		public long IdRegistroViaje
		{
			get { return m_IdRegistroViaje; }
			set 
			{
				m_changed=true;
				m_IdRegistroViaje = value;
			}
		}

		/// <summary>
		/// Attribute for access the TramosGastos's Cuenta value (string)
		/// </summary>
		[DataMember]
		public string Cuenta
		{
			get { return m_Cuenta; }
			set 
			{
				m_changed=true;
				m_Cuenta = value;
			}
		}

		/// <summary>
		/// Attribute for access the TramosGastos's DescripcionCuenta value (string)
		/// </summary>
		[DataMember]
		public string DescripcionCuenta
		{
			get { return m_DescripcionCuenta; }
			set 
			{
				m_changed=true;
				m_DescripcionCuenta = value;
			}
		}

		/// <summary>
		/// Attribute for access the TramosGastos's ValorTotal value (decimal)
		/// </summary>
		[DataMember]
		public decimal? ValorTotal
		{
			get { return m_ValorTotal; }
			set 
			{
				m_changed=true;
				m_ValorTotal = value;
			}
		}

		/// <summary>
		/// Attribute for access the TramosGastos's DescripcionTercero value (string)
		/// </summary>
		[DataMember]
		public string DescripcionTercero
		{
			get { return m_DescripcionTercero; }
			set 
			{
				m_changed=true;
				m_DescripcionTercero = value;
			}
		}

		/// <summary>
		/// Attribute for access the TramosGastos's Codigo value (long)
		/// </summary>
		[DataMember]
		public long Codigo
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
				case "IdRegistroViaje": return IdRegistroViaje;
				case "Cuenta": return Cuenta;
				case "DescripcionCuenta": return DescripcionCuenta;
				case "ValorTotal": return ValorTotal;
				case "DescripcionTercero": return DescripcionTercero;
				case "Codigo": return Codigo;
				default: return null;
			}
		}

		public Type GetAttributeType(string pattribute)
		{
			return TramosGastosController.Instance.GetMethodType(pattribute, this);
		}

		public string GetSqlKey()
		{
			return "[Codigo] = " + Codigo.ToString();
		}
		#endregion

	}

	#endregion

	#region TramosGastosList object

	/// <summary>
	/// Class for reading and access a list of TramosGastos object
	/// </summary>
	[CollectionDataContract]
	public partial class TramosGastosList : List<TramosGastos>
	{

		/// <summary>
		/// Default constructor
		/// </summary>
		public TramosGastosList()
		{
		}
	}

	#endregion

}
