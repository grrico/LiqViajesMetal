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
	#region TramosConsultaAnticipos object

	[DataContract]
	public partial class TramosConsultaAnticipos : IDTOObject
	{
		/// <summary>
		/// Default constructor
		/// </summary>
		public TramosConsultaAnticipos()
		{
			m_Codigo = 0;
			m_IdRegistroViajeTramo = null;
			m_Tipo = null;
			m_Documento = null;
			m_NombreBanco = null;
			m_ValorAnticipo = null;
			m_Fecha = null;
			m_changed=false;
		}
		        //Return the table name of object
		        public string TableName()
		        {
		            return "TramosConsultaAnticipos";
		        }
		#region Undo 
		// Internal class for storing changes
		private TramosConsultaAnticipos m_oldTramosConsultaAnticipos;
		public void GenerateUndo()
		{
			m_oldTramosConsultaAnticipos=new TramosConsultaAnticipos();
			m_oldTramosConsultaAnticipos.m_Codigo = m_Codigo;
			m_oldTramosConsultaAnticipos.IdRegistroViajeTramo = m_IdRegistroViajeTramo;
			m_oldTramosConsultaAnticipos.Tipo = m_Tipo;
			m_oldTramosConsultaAnticipos.Documento = m_Documento;
			m_oldTramosConsultaAnticipos.NombreBanco = m_NombreBanco;
			m_oldTramosConsultaAnticipos.ValorAnticipo = m_ValorAnticipo;
			m_oldTramosConsultaAnticipos.Fecha = m_Fecha;
		}

		public TramosConsultaAnticipos OldTramosConsultaAnticipos
		{
			get { return m_oldTramosConsultaAnticipos;}
		}
		// Return the changed fields
		public string[] FieldChanged()
		{
			List<string> fields=new List<string>();
			if (m_oldTramosConsultaAnticipos.IdRegistroViajeTramo != m_IdRegistroViajeTramo) fields.Add("IdRegistroViajeTramo");
			if (m_oldTramosConsultaAnticipos.Tipo != m_Tipo) fields.Add("Tipo");
			if (m_oldTramosConsultaAnticipos.Documento != m_Documento) fields.Add("Documento");
			if (m_oldTramosConsultaAnticipos.NombreBanco != m_NombreBanco) fields.Add("NombreBanco");
			if (m_oldTramosConsultaAnticipos.ValorAnticipo != m_ValorAnticipo) fields.Add("ValorAnticipo");
			if (m_oldTramosConsultaAnticipos.Fecha != m_Fecha) fields.Add("Fecha");
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


		// Field for storing the TramosConsultaAnticipos's IdRegistroViajeTramo value
		private long? m_IdRegistroViajeTramo;

		// Field for storing the TramosConsultaAnticipos's Tipo value
		private string m_Tipo;

		// Field for storing the TramosConsultaAnticipos's Documento value
		private long? m_Documento;

		// Field for storing the TramosConsultaAnticipos's NombreBanco value
		private string m_NombreBanco;

		// Field for storing the TramosConsultaAnticipos's ValorAnticipo value
		private decimal? m_ValorAnticipo;

		// Field for storing the TramosConsultaAnticipos's Fecha value
		private DateTime? m_Fecha;

		// Field for storing the TramosConsultaAnticipos's Codigo value
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
		/// Attribute for access the TramosConsultaAnticipos's IdRegistroViajeTramo value (long)
		/// </summary>
		[DataMember]
		public long? IdRegistroViajeTramo
		{
			get { return m_IdRegistroViajeTramo; }
			set 
			{
				m_changed=true;
				m_IdRegistroViajeTramo = value;
			}
		}

		/// <summary>
		/// Attribute for access the TramosConsultaAnticipos's Tipo value (string)
		/// </summary>
		[DataMember]
		public string Tipo
		{
			get { return m_Tipo; }
			set 
			{
				m_changed=true;
				m_Tipo = value;
			}
		}

		/// <summary>
		/// Attribute for access the TramosConsultaAnticipos's Documento value (long)
		/// </summary>
		[DataMember]
		public long? Documento
		{
			get { return m_Documento; }
			set 
			{
				m_changed=true;
				m_Documento = value;
			}
		}

		/// <summary>
		/// Attribute for access the TramosConsultaAnticipos's NombreBanco value (string)
		/// </summary>
		[DataMember]
		public string NombreBanco
		{
			get { return m_NombreBanco; }
			set 
			{
				m_changed=true;
				m_NombreBanco = value;
			}
		}

		/// <summary>
		/// Attribute for access the TramosConsultaAnticipos's ValorAnticipo value (decimal)
		/// </summary>
		[DataMember]
		public decimal? ValorAnticipo
		{
			get { return m_ValorAnticipo; }
			set 
			{
				m_changed=true;
				m_ValorAnticipo = value;
			}
		}

		/// <summary>
		/// Attribute for access the TramosConsultaAnticipos's Fecha value (DateTime)
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
		/// Attribute for access the TramosConsultaAnticipos's Codigo value (long)
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
				case "IdRegistroViajeTramo": return IdRegistroViajeTramo;
				case "Tipo": return Tipo;
				case "Documento": return Documento;
				case "NombreBanco": return NombreBanco;
				case "ValorAnticipo": return ValorAnticipo;
				case "Fecha": return Fecha;
				case "Codigo": return Codigo;
				default: return null;
			}
		}

		public Type GetAttributeType(string pattribute)
		{
			return TramosConsultaAnticiposController.Instance.GetMethodType(pattribute, this);
		}

		public string GetSqlKey()
		{
			return "[Codigo] = " + Codigo.ToString();
		}
		#endregion

	}

	#endregion

	#region TramosConsultaAnticiposList object

	/// <summary>
	/// Class for reading and access a list of TramosConsultaAnticipos object
	/// </summary>
	[CollectionDataContract]
	public partial class TramosConsultaAnticiposList : List<TramosConsultaAnticipos>
	{

		/// <summary>
		/// Default constructor
		/// </summary>
		public TramosConsultaAnticiposList()
		{
		}
	}

	#endregion

}
