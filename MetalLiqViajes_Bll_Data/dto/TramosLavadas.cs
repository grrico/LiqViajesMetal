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
	#region TramosLavadas object

	[DataContract]
	public partial class TramosLavadas : IDTOObject
	{
		/// <summary>
		/// Default constructor
		/// </summary>
		public TramosLavadas()
		{
			m_lngIdRegistroViaje = 0;
			m_Origen = null;
			m_Destino = null;
			m_Liquidado = false;
			m_Fecha = null;
			m_Placa = null;
			m_Valor = null;
			m_changed=false;
		}
		        //Return the table name of object
		        public string TableName()
		        {
		            return "TramosLavadas";
		        }
		#region Undo 
		// Internal class for storing changes
		private TramosLavadas m_oldTramosLavadas;
		public void GenerateUndo()
		{
			m_oldTramosLavadas=new TramosLavadas();
			m_oldTramosLavadas.m_lngIdRegistroViaje = m_lngIdRegistroViaje;
			m_oldTramosLavadas.Origen = m_Origen;
			m_oldTramosLavadas.Destino = m_Destino;
			m_oldTramosLavadas.Liquidado = m_Liquidado;
			m_oldTramosLavadas.Fecha = m_Fecha;
			m_oldTramosLavadas.Placa = m_Placa;
			m_oldTramosLavadas.Valor = m_Valor;
		}

		public TramosLavadas OldTramosLavadas
		{
			get { return m_oldTramosLavadas;}
		}
		// Return the changed fields
		public string[] FieldChanged()
		{
			List<string> fields=new List<string>();
			if (m_oldTramosLavadas.Origen != m_Origen) fields.Add("Origen");
			if (m_oldTramosLavadas.Destino != m_Destino) fields.Add("Destino");
			if (m_oldTramosLavadas.Liquidado != m_Liquidado) fields.Add("Liquidado");
			if (m_oldTramosLavadas.Fecha != m_Fecha) fields.Add("Fecha");
			if (m_oldTramosLavadas.Placa != m_Placa) fields.Add("Placa");
			if (m_oldTramosLavadas.Valor != m_Valor) fields.Add("Valor");
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


		// Field for storing the TramosLavadas's lngIdRegistroViaje value
		private long m_lngIdRegistroViaje;

		// Field for storing the TramosLavadas's Origen value
		private string m_Origen;

		// Field for storing the TramosLavadas's Destino value
		private string m_Destino;

		// Field for storing the TramosLavadas's Liquidado value
		private bool? m_Liquidado;

		// Field for storing the TramosLavadas's Fecha value
		private DateTime? m_Fecha;

		// Field for storing the TramosLavadas's Placa value
		private string m_Placa;

		// Field for storing the TramosLavadas's Valor value
		private decimal? m_Valor;

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
		/// Attribute for access the TramosLavadas's lngIdRegistroViaje value (long)
		/// </summary>
		[DataMember]
		public long lngIdRegistroViaje
		{
			get { return m_lngIdRegistroViaje; }
			set 
			{
				m_changed=true;
				m_lngIdRegistroViaje = value;
			}
		}

		/// <summary>
		/// Attribute for access the TramosLavadas's Origen value (string)
		/// </summary>
		[DataMember]
		public string Origen
		{
			get { return m_Origen; }
			set 
			{
				m_changed=true;
				m_Origen = value;
			}
		}

		/// <summary>
		/// Attribute for access the TramosLavadas's Destino value (string)
		/// </summary>
		[DataMember]
		public string Destino
		{
			get { return m_Destino; }
			set 
			{
				m_changed=true;
				m_Destino = value;
			}
		}

		/// <summary>
		/// Attribute for access the TramosLavadas's Liquidado value (bool)
		/// </summary>
		[DataMember]
		public bool? Liquidado
		{
			get { return m_Liquidado; }
			set 
			{
				m_changed=true;
				m_Liquidado = value;
			}
		}

		/// <summary>
		/// Attribute for access the TramosLavadas's Fecha value (DateTime)
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
		/// Attribute for access the TramosLavadas's Placa value (string)
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
		/// Attribute for access the TramosLavadas's Valor value (decimal)
		/// </summary>
		[DataMember]
		public decimal? Valor
		{
			get { return m_Valor; }
			set 
			{
				m_changed=true;
				m_Valor = value;
			}
		}

		public object GetAttribute(string pattribute)
		{
			switch (pattribute)
			{
				case "lngIdRegistroViaje": return lngIdRegistroViaje;
				case "Origen": return Origen;
				case "Destino": return Destino;
				case "Liquidado": return Liquidado;
				case "Fecha": return Fecha;
				case "Placa": return Placa;
				case "Valor": return Valor;
				default: return null;
			}
		}

		public Type GetAttributeType(string pattribute)
		{
			return TramosLavadasController.Instance.GetMethodType(pattribute, this);
		}

		public string GetSqlKey()
		{
			return "[lngIdRegistroViaje] = " + lngIdRegistroViaje.ToString();
		}
		#endregion

	}

	#endregion

	#region TramosLavadasList object

	/// <summary>
	/// Class for reading and access a list of TramosLavadas object
	/// </summary>
	[CollectionDataContract]
	public partial class TramosLavadasList : List<TramosLavadas>
	{

		/// <summary>
		/// Default constructor
		/// </summary>
		public TramosLavadasList()
		{
		}
	}

	#endregion

}
