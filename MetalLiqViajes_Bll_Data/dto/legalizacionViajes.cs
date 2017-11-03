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
	#region legalizacionViajes object

	[DataContract]
	public partial class legalizacionViajes : IDTOObject
	{
		/// <summary>
		/// Default constructor
		/// </summary>
		public legalizacionViajes()
		{
			m_Codigo = 0;
			m_lngIdRegistro = null;
			m_sw = (byte)0;
			m_tipo = null;
			m_numero = null;
			m_seq = null;
			m_Fecha = null;
			m_nit = null;
			m_centro = null;
			m_cuenta = null;
			m_descripcion = null;
			m_valor = null;
			m_notas = null;
			m_changed=false;
		}
		        //Return the table name of object
		        public string TableName()
		        {
		            return "legalizacionViajes";
		        }
		#region Undo 
		// Internal class for storing changes
		private legalizacionViajes m_oldlegalizacionViajes;
		public void GenerateUndo()
		{
			m_oldlegalizacionViajes=new legalizacionViajes();
			m_oldlegalizacionViajes.m_Codigo = m_Codigo;
			m_oldlegalizacionViajes.lngIdRegistro = m_lngIdRegistro;
			m_oldlegalizacionViajes.sw = m_sw;
			m_oldlegalizacionViajes.tipo = m_tipo;
			m_oldlegalizacionViajes.numero = m_numero;
			m_oldlegalizacionViajes.seq = m_seq;
			m_oldlegalizacionViajes.Fecha = m_Fecha;
			m_oldlegalizacionViajes.nit = m_nit;
			m_oldlegalizacionViajes.centro = m_centro;
			m_oldlegalizacionViajes.cuenta = m_cuenta;
			m_oldlegalizacionViajes.descripcion = m_descripcion;
			m_oldlegalizacionViajes.valor = m_valor;
			m_oldlegalizacionViajes.notas = m_notas;
		}

		public legalizacionViajes OldlegalizacionViajes
		{
			get { return m_oldlegalizacionViajes;}
		}
		// Return the changed fields
		public string[] FieldChanged()
		{
			List<string> fields=new List<string>();
			if (m_oldlegalizacionViajes.lngIdRegistro != m_lngIdRegistro) fields.Add("lngIdRegistro");
			if (m_oldlegalizacionViajes.sw != m_sw) fields.Add("sw");
			if (m_oldlegalizacionViajes.tipo != m_tipo) fields.Add("tipo");
			if (m_oldlegalizacionViajes.numero != m_numero) fields.Add("numero");
			if (m_oldlegalizacionViajes.seq != m_seq) fields.Add("seq");
			if (m_oldlegalizacionViajes.Fecha != m_Fecha) fields.Add("Fecha");
			if (m_oldlegalizacionViajes.nit != m_nit) fields.Add("nit");
			if (m_oldlegalizacionViajes.centro != m_centro) fields.Add("centro");
			if (m_oldlegalizacionViajes.cuenta != m_cuenta) fields.Add("cuenta");
			if (m_oldlegalizacionViajes.descripcion != m_descripcion) fields.Add("descripcion");
			if (m_oldlegalizacionViajes.valor != m_valor) fields.Add("valor");
			if (m_oldlegalizacionViajes.notas != m_notas) fields.Add("notas");
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


		// Field for storing the legalizacionViajes's lngIdRegistro value
		private int? m_lngIdRegistro;

		// Field for storing the legalizacionViajes's sw value
		private byte? m_sw;

		// Field for storing the legalizacionViajes's tipo value
		private string m_tipo;

		// Field for storing the legalizacionViajes's numero value
		private long? m_numero;

		// Field for storing the legalizacionViajes's seq value
		private int? m_seq;

		// Field for storing the legalizacionViajes's Fecha value
		private DateTime? m_Fecha;

		// Field for storing the legalizacionViajes's nit value
		private decimal? m_nit;

		// Field for storing the legalizacionViajes's centro value
		private int? m_centro;

		// Field for storing the legalizacionViajes's cuenta value
		private string m_cuenta;

		// Field for storing the legalizacionViajes's descripcion value
		private string m_descripcion;

		// Field for storing the legalizacionViajes's valor value
		private decimal? m_valor;

		// Field for storing the legalizacionViajes's notas value
		private string m_notas;

		// Field for storing the legalizacionViajes's Codigo value
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
		/// Attribute for access the legalizacionViajes's lngIdRegistro value (int)
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
		/// Attribute for access the legalizacionViajes's sw value (byte)
		/// </summary>
		[DataMember]
		public byte? sw
		{
			get { return m_sw; }
			set 
			{
				m_changed=true;
				m_sw = value;
			}
		}

		/// <summary>
		/// Attribute for access the legalizacionViajes's tipo value (string)
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
		/// Attribute for access the legalizacionViajes's numero value (long)
		/// </summary>
		[DataMember]
		public long? numero
		{
			get { return m_numero; }
			set 
			{
				m_changed=true;
				m_numero = value;
			}
		}

		/// <summary>
		/// Attribute for access the legalizacionViajes's seq value (int)
		/// </summary>
		[DataMember]
		public int? seq
		{
			get { return m_seq; }
			set 
			{
				m_changed=true;
				m_seq = value;
			}
		}

		/// <summary>
		/// Attribute for access the legalizacionViajes's Fecha value (DateTime)
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
		/// Attribute for access the legalizacionViajes's nit value (decimal)
		/// </summary>
		[DataMember]
		public decimal? nit
		{
			get { return m_nit; }
			set 
			{
				m_changed=true;
				m_nit = value;
			}
		}

		/// <summary>
		/// Attribute for access the legalizacionViajes's centro value (int)
		/// </summary>
		[DataMember]
		public int? centro
		{
			get { return m_centro; }
			set 
			{
				m_changed=true;
				m_centro = value;
			}
		}

		/// <summary>
		/// Attribute for access the legalizacionViajes's cuenta value (string)
		/// </summary>
		[DataMember]
		public string cuenta
		{
			get { return m_cuenta; }
			set 
			{
				m_changed=true;
				m_cuenta = value;
			}
		}

		/// <summary>
		/// Attribute for access the legalizacionViajes's descripcion value (string)
		/// </summary>
		[DataMember]
		public string descripcion
		{
			get { return m_descripcion; }
			set 
			{
				m_changed=true;
				m_descripcion = value;
			}
		}

		/// <summary>
		/// Attribute for access the legalizacionViajes's valor value (decimal)
		/// </summary>
		[DataMember]
		public decimal? valor
		{
			get { return m_valor; }
			set 
			{
				m_changed=true;
				m_valor = value;
			}
		}

		/// <summary>
		/// Attribute for access the legalizacionViajes's notas value (string)
		/// </summary>
		[DataMember]
		public string notas
		{
			get { return m_notas; }
			set 
			{
				m_changed=true;
				m_notas = value;
			}
		}

		/// <summary>
		/// Attribute for access the legalizacionViajes's Codigo value (long)
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
				case "lngIdRegistro": return lngIdRegistro;
				case "sw": return sw;
				case "tipo": return tipo;
				case "numero": return numero;
				case "seq": return seq;
				case "Fecha": return Fecha;
				case "nit": return nit;
				case "centro": return centro;
				case "cuenta": return cuenta;
				case "descripcion": return descripcion;
				case "valor": return valor;
				case "notas": return notas;
				case "Codigo": return Codigo;
				default: return null;
			}
		}

		public Type GetAttributeType(string pattribute)
		{
			return legalizacionViajesController.Instance.GetMethodType(pattribute, this);
		}

		public string GetSqlKey()
		{
			return "[Codigo] = " + Codigo.ToString();
		}
		#endregion

	}

	#endregion

	#region legalizacionViajesList object

	/// <summary>
	/// Class for reading and access a list of legalizacionViajes object
	/// </summary>
	[CollectionDataContract]
	public partial class legalizacionViajesList : List<legalizacionViajes>
	{

		/// <summary>
		/// Default constructor
		/// </summary>
		public legalizacionViajesList()
		{
		}
	}

	#endregion

}
