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
	#region Documento_Referencia object

	[DataContract]
	public partial class Documento_Referencia : IDTOObject
	{
		/// <summary>
		/// Default constructor
		/// </summary>
		public Documento_Referencia()
		{
			m_sw = (byte)0;
			m_tipo = "";
			m_numero = 0;
			m_lngIdRegistro = null;
			m_fecha = DateTime.Now.Date;
			m_valor = 0;
			m_ValorCruce = null;
			m_changed=false;
		}
		        //Return the table name of object
		        public string TableName()
		        {
		            return "tblDocumento_Referencia";
		        }
		#region Undo 
		// Internal class for storing changes
		private Documento_Referencia m_oldDocumento_Referencia;
		public void GenerateUndo()
		{
			m_oldDocumento_Referencia=new Documento_Referencia();
			m_oldDocumento_Referencia.m_sw = m_sw;
			m_oldDocumento_Referencia.m_tipo = m_tipo;
			m_oldDocumento_Referencia.m_numero = m_numero;
			m_oldDocumento_Referencia.lngIdRegistro = m_lngIdRegistro;
			m_oldDocumento_Referencia.fecha = m_fecha;
			m_oldDocumento_Referencia.valor = m_valor;
			m_oldDocumento_Referencia.ValorCruce = m_ValorCruce;
		}

		public Documento_Referencia OldDocumento_Referencia
		{
			get { return m_oldDocumento_Referencia;}
		}
		// Return the changed fields
		public string[] FieldChanged()
		{
			List<string> fields=new List<string>();
			if (m_oldDocumento_Referencia.lngIdRegistro != m_lngIdRegistro) fields.Add("lngIdRegistro");
			if (m_oldDocumento_Referencia.fecha != m_fecha) fields.Add("fecha");
			if (m_oldDocumento_Referencia.valor != m_valor) fields.Add("valor");
			if (m_oldDocumento_Referencia.ValorCruce != m_ValorCruce) fields.Add("ValorCruce");
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


		// Field for storing the Documento_Referencia's lngIdRegistro value
		private int? m_lngIdRegistro;

		// Field for storing the Documento_Referencia's fecha value
		private DateTime m_fecha;

		// Field for storing the Documento_Referencia's valor value
		private decimal m_valor;

		// Field for storing the Documento_Referencia's ValorCruce value
		private decimal? m_ValorCruce;

		// Field for storing the Documento_Referencia's sw value
		private byte m_sw;

		// Field for storing the Documento_Referencia's tipo value
		private string m_tipo;

		// Field for storing the Documento_Referencia's numero value
		private int m_numero;

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
		/// Attribute for access the Documento_Referencia's lngIdRegistro value (int)
		/// </summary>
		[DataMember]
		public int? lngIdRegistro
		{
			get { return m_lngIdRegistro; }
			set 
			{
				m_changed=true;
				m_lngIdRegistro = value;
			}
		}

		/// <summary>
		/// Attribute for access the Documento_Referencia's fecha value (DateTime)
		/// </summary>
		[DataMember]
		public DateTime fecha
		{
			get { return m_fecha; }
			set 
			{
				m_changed=true;
				m_fecha = value;
			}
		}

		/// <summary>
		/// Attribute for access the Documento_Referencia's valor value (decimal)
		/// </summary>
		[DataMember]
		public decimal valor
		{
			get { return m_valor; }
			set 
			{
				m_changed=true;
				m_valor = value;
			}
		}

		/// <summary>
		/// Attribute for access the Documento_Referencia's ValorCruce value (decimal)
		/// </summary>
		[DataMember]
		public decimal? ValorCruce
		{
			get { return m_ValorCruce; }
			set 
			{
				m_changed=true;
				m_ValorCruce = value;
			}
		}

		/// <summary>
		/// Attribute for access the Documento_Referencia's sw value (byte)
		/// </summary>
		[DataMember]
		public byte sw
		{
			get { return m_sw; }
			set 
			{
				m_changed=true;
				m_sw = value;
			}
		}

		/// <summary>
		/// Attribute for access the Documento_Referencia's tipo value (string)
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
		/// Attribute for access the Documento_Referencia's numero value (int)
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

		public object GetAttribute(string pattribute)
		{
			switch (pattribute)
			{
				case "lngIdRegistro": return lngIdRegistro;
				case "fecha": return fecha;
				case "valor": return valor;
				case "ValorCruce": return ValorCruce;
				case "sw": return sw;
				case "tipo": return tipo;
				case "numero": return numero;
				default: return null;
			}
		}

		public Type GetAttributeType(string pattribute)
		{
			return Documento_ReferenciaController.Instance.GetMethodType(pattribute, this);
		}

		public string GetSqlKey()
		{
			return "[sw] = " + sw.ToString() + " AND [tipo] = '" + tipo.ToString()+ "'" + " AND [numero] = " + numero.ToString();
		}
		#endregion

	}

	#endregion

	#region Documento_ReferenciaList object

	/// <summary>
	/// Class for reading and access a list of Documento_Referencia object
	/// </summary>
	[CollectionDataContract]
	public partial class Documento_ReferenciaList : List<Documento_Referencia>
	{

		/// <summary>
		/// Default constructor
		/// </summary>
		public Documento_ReferenciaList()
		{
		}
	}

	#endregion

}
