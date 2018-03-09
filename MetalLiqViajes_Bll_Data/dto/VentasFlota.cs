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
	#region VentasFlota object

	[DataContract]
	public partial class VentasFlota : IDTOObject
	{
		/// <summary>
		/// Default constructor
		/// </summary>
		public VentasFlota()
		{
			m_Codigo = 0;
			m_CodEds = null;
			m_Recibo = null;
			m_Fecha = null;
			m_Placa = null;
			m_Producto = null;
			m_Dinero = null;
			m_Volumen = null;
			m_Kilometraje = null;
			m_changed=false;
		}
		        //Return the table name of object
		        public string TableName()
		        {
		            return "VentasFlota";
		        }
		#region Undo 
		// Internal class for storing changes
		private VentasFlota m_oldVentasFlota;
		public void GenerateUndo()
		{
			m_oldVentasFlota=new VentasFlota();
			m_oldVentasFlota.m_Codigo = m_Codigo;
			m_oldVentasFlota.CodEds = m_CodEds;
			m_oldVentasFlota.Recibo = m_Recibo;
			m_oldVentasFlota.Fecha = m_Fecha;
			m_oldVentasFlota.Placa = m_Placa;
			m_oldVentasFlota.Producto = m_Producto;
			m_oldVentasFlota.Dinero = m_Dinero;
			m_oldVentasFlota.Volumen = m_Volumen;
			m_oldVentasFlota.Kilometraje = m_Kilometraje;
		}

		public VentasFlota OldVentasFlota
		{
			get { return m_oldVentasFlota;}
		}
		// Return the changed fields
		public string[] FieldChanged()
		{
			List<string> fields=new List<string>();
			if (m_oldVentasFlota.CodEds != m_CodEds) fields.Add("CodEds");
			if (m_oldVentasFlota.Recibo != m_Recibo) fields.Add("Recibo");
			if (m_oldVentasFlota.Fecha != m_Fecha) fields.Add("Fecha");
			if (m_oldVentasFlota.Placa != m_Placa) fields.Add("Placa");
			if (m_oldVentasFlota.Producto != m_Producto) fields.Add("Producto");
			if (m_oldVentasFlota.Dinero != m_Dinero) fields.Add("Dinero");
			if (m_oldVentasFlota.Volumen != m_Volumen) fields.Add("Volumen");
			if (m_oldVentasFlota.Kilometraje != m_Kilometraje) fields.Add("Kilometraje");
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


		// Field for storing the VentasFlota's Codigo value
		private long m_Codigo;

		// Field for storing the VentasFlota's CodEds value
		private long? m_CodEds;

		// Field for storing the VentasFlota's Recibo value
		private long? m_Recibo;

		// Field for storing the VentasFlota's Fecha value
		private DateTime? m_Fecha;

		// Field for storing the VentasFlota's Placa value
		private string m_Placa;

		// Field for storing the VentasFlota's Producto value
		private string m_Producto;

		// Field for storing the VentasFlota's Dinero value
		private decimal? m_Dinero;

		// Field for storing the VentasFlota's Volumen value
		private decimal? m_Volumen;

		// Field for storing the VentasFlota's Kilometraje value
		private decimal? m_Kilometraje;

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
		/// Attribute for access the VentasFlota's Codigo value (long)
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

		/// <summary>
		/// Attribute for access the VentasFlota's CodEds value (long)
		/// </summary>
		[DataMember]
		public long? CodEds
		{
			get { return m_CodEds; }
			set 
			{
				m_changed=true;
				m_CodEds = value;
			}
		}

		/// <summary>
		/// Attribute for access the VentasFlota's Recibo value (long)
		/// </summary>
		[DataMember]
		public long? Recibo
		{
			get { return m_Recibo; }
			set 
			{
				m_changed=true;
				m_Recibo = value;
			}
		}

		/// <summary>
		/// Attribute for access the VentasFlota's Fecha value (DateTime)
		/// </summary>
		[DataMember]
		public DateTime? Fecha
		{
			get { return m_Fecha; }
			set 
			{
				m_changed=true;
				m_Fecha = value;
			}
		}

		/// <summary>
		/// Attribute for access the VentasFlota's Placa value (string)
		/// </summary>
		[DataMember]
		public string Placa
		{
			get { return m_Placa; }
			set 
			{
				m_changed=true;
				m_Placa = value;
			}
		}

		/// <summary>
		/// Attribute for access the VentasFlota's Producto value (string)
		/// </summary>
		[DataMember]
		public string Producto
		{
			get { return m_Producto; }
			set 
			{
				m_changed=true;
				m_Producto = value;
			}
		}

		/// <summary>
		/// Attribute for access the VentasFlota's Dinero value (decimal)
		/// </summary>
		[DataMember]
		public decimal? Dinero
		{
			get { return m_Dinero; }
			set 
			{
				m_changed=true;
				m_Dinero = value;
			}
		}

		/// <summary>
		/// Attribute for access the VentasFlota's Volumen value (decimal)
		/// </summary>
		[DataMember]
		public decimal? Volumen
		{
			get { return m_Volumen; }
			set 
			{
				m_changed=true;
				m_Volumen = value;
			}
		}

		/// <summary>
		/// Attribute for access the VentasFlota's Kilometraje value (decimal)
		/// </summary>
		[DataMember]
		public decimal? Kilometraje
		{
			get { return m_Kilometraje; }
			set 
			{
				m_changed=true;
				m_Kilometraje = value;
			}
		}

		public object GetAttribute(string pattribute)
		{
			switch (pattribute)
			{
				case "Codigo": return Codigo;
				case "CodEds": return CodEds;
				case "Recibo": return Recibo;
				case "Fecha": return Fecha;
				case "Placa": return Placa;
				case "Producto": return Producto;
				case "Dinero": return Dinero;
				case "Volumen": return Volumen;
				case "Kilometraje": return Kilometraje;
				default: return null;
			}
		}

		public Type GetAttributeType(string pattribute)
		{
			return VentasFlotaController.Instance.GetMethodType(pattribute, this);
		}

		public string GetSqlKey()
		{
			return "[Codigo] = " + Codigo.ToString();
		}
		#endregion

	}

	#endregion

	#region VentasFlotaList object

	/// <summary>
	/// Class for reading and access a list of VentasFlota object
	/// </summary>
	[CollectionDataContract]
	public partial class VentasFlotaList : List<VentasFlota>
	{

		/// <summary>
		/// Default constructor
		/// </summary>
		public VentasFlotaList()
		{
		}
	}

	#endregion

}
