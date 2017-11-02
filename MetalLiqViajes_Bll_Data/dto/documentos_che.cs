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
	#region documentos_che object

	[DataContract]
	public partial class documentos_che : IDTOObject
	{
		/// <summary>
		/// Default constructor
		/// </summary>
		public documentos_che()
		{
			m_tipo = "";
			m_numero = 0;
			m_banco = 0;
			m_documento = "";
			m_forma_pago = (byte)0;
			m_sw = (byte)0;
			m_fecha = DateTime.Now.Date;
			m_valor = 0;
			m_consignar_en = 0;
			m_devuelto = null;
			m_tipo_consignacion = null;
			m_numero_consignacion = null;
			m_fecha_devolucion = null;
			m_cuenta_banco = null;
			m_iva_tarjeta = null;
			m_changed=false;
		}
		        //Return the table name of object
		        public string TableName()
		        {
		            return "documentos_che";
		        }
		#region Undo 
		// Internal class for storing changes
		private documentos_che m_olddocumentos_che;
		public void GenerateUndo()
		{
			m_olddocumentos_che=new documentos_che();
			m_olddocumentos_che.m_tipo = m_tipo;
			m_olddocumentos_che.m_numero = m_numero;
			m_olddocumentos_che.m_banco = m_banco;
			m_olddocumentos_che.m_documento = m_documento;
			m_olddocumentos_che.m_forma_pago = m_forma_pago;
			m_olddocumentos_che.sw = m_sw;
			m_olddocumentos_che.fecha = m_fecha;
			m_olddocumentos_che.valor = m_valor;
			m_olddocumentos_che.consignar_en = m_consignar_en;
			m_olddocumentos_che.devuelto = m_devuelto;
			m_olddocumentos_che.tipo_consignacion = m_tipo_consignacion;
			m_olddocumentos_che.numero_consignacion = m_numero_consignacion;
			m_olddocumentos_che.fecha_devolucion = m_fecha_devolucion;
			m_olddocumentos_che.cuenta_banco = m_cuenta_banco;
			m_olddocumentos_che.iva_tarjeta = m_iva_tarjeta;
		}

		public documentos_che Olddocumentos_che
		{
			get { return m_olddocumentos_che;}
		}
		// Return the changed fields
		public string[] FieldChanged()
		{
			List<string> fields=new List<string>();
			if (m_olddocumentos_che.sw != m_sw) fields.Add("sw");
			if (m_olddocumentos_che.fecha != m_fecha) fields.Add("fecha");
			if (m_olddocumentos_che.valor != m_valor) fields.Add("valor");
			if (m_olddocumentos_che.consignar_en != m_consignar_en) fields.Add("consignar_en");
			if (m_olddocumentos_che.devuelto != m_devuelto) fields.Add("devuelto");
			if (m_olddocumentos_che.tipo_consignacion != m_tipo_consignacion) fields.Add("tipo_consignacion");
			if (m_olddocumentos_che.numero_consignacion != m_numero_consignacion) fields.Add("numero_consignacion");
			if (m_olddocumentos_che.fecha_devolucion != m_fecha_devolucion) fields.Add("fecha_devolucion");
			if (m_olddocumentos_che.cuenta_banco != m_cuenta_banco) fields.Add("cuenta_banco");
			if (m_olddocumentos_che.iva_tarjeta != m_iva_tarjeta) fields.Add("iva_tarjeta");
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


		// Field for storing the documentos_che's sw value
		private byte m_sw;

		// Field for storing the documentos_che's tipo value
		private string m_tipo;

		// Field for storing the documentos_che's numero value
		private int m_numero;

		// Field for storing the documentos_che's banco value
		private short m_banco;

		// Field for storing the documentos_che's documento value
		private string m_documento;

		// Field for storing the documentos_che's forma_pago value
		private byte m_forma_pago;

		// Field for storing the documentos_che's fecha value
		private DateTime m_fecha;

		// Field for storing the documentos_che's valor value
		private decimal m_valor;

		// Field for storing the documentos_che's consignar_en value
		private short m_consignar_en;

		// Field for storing the documentos_che's devuelto value
		private string m_devuelto;

		// Field for storing the documentos_che's tipo_consignacion value
		private string m_tipo_consignacion;

		// Field for storing the documentos_che's numero_consignacion value
		private int? m_numero_consignacion;

		// Field for storing the documentos_che's fecha_devolucion value
		private DateTime? m_fecha_devolucion;

		// Field for storing the documentos_che's cuenta_banco value
		private string m_cuenta_banco;

		// Field for storing the documentos_che's iva_tarjeta value
		private decimal? m_iva_tarjeta;

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
		/// Attribute for access the documentos_che's sw value (byte)
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
		/// Attribute for access the documentos_che's tipo value (string)
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
		/// Attribute for access the documentos_che's numero value (int)
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

		/// <summary>
		/// Attribute for access the documentos_che's banco value (short)
		/// </summary>
		[DataMember]
		public short banco
		{
			get { return m_banco; }
			set 
			{
				m_changed=true;
				m_banco = value;
			}
		}

		/// <summary>
		/// Attribute for access the documentos_che's documento value (string)
		/// </summary>
		[DataMember]
		public string documento
		{
			get { return m_documento; }
			set 
			{
				m_changed=true;
				m_documento = value;
			}
		}

		/// <summary>
		/// Attribute for access the documentos_che's forma_pago value (byte)
		/// </summary>
		[DataMember]
		public byte forma_pago
		{
			get { return m_forma_pago; }
			set 
			{
				m_changed=true;
				m_forma_pago = value;
			}
		}

		/// <summary>
		/// Attribute for access the documentos_che's fecha value (DateTime)
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
		/// Attribute for access the documentos_che's valor value (decimal)
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
		/// Attribute for access the documentos_che's consignar_en value (short)
		/// </summary>
		[DataMember]
		public short consignar_en
		{
			get { return m_consignar_en; }
			set 
			{
				m_changed=true;
				m_consignar_en = value;
			}
		}

		/// <summary>
		/// Attribute for access the documentos_che's devuelto value (string)
		/// </summary>
		[DataMember]
		public string devuelto
		{
			get { return m_devuelto; }
			set 
			{
				m_changed=true;
				m_devuelto = value;
			}
		}

		/// <summary>
		/// Attribute for access the documentos_che's tipo_consignacion value (string)
		/// </summary>
		[DataMember]
		public string tipo_consignacion
		{
			get { return m_tipo_consignacion; }
			set 
			{
				m_changed=true;
				m_tipo_consignacion = value;
			}
		}

		/// <summary>
		/// Attribute for access the documentos_che's numero_consignacion value (int)
		/// </summary>
		[DataMember]
		public int? numero_consignacion
		{
			get { return m_numero_consignacion; }
			set 
			{
				m_changed=true;
				m_numero_consignacion = value;
			}
		}

		/// <summary>
		/// Attribute for access the documentos_che's fecha_devolucion value (DateTime)
		/// </summary>
		[DataMember]
		public DateTime? fecha_devolucion
		{
			get { return m_fecha_devolucion; }
			set 
			{
				m_changed=true;
				m_fecha_devolucion = value;
			}
		}

		/// <summary>
		/// Attribute for access the documentos_che's cuenta_banco value (string)
		/// </summary>
		[DataMember]
		public string cuenta_banco
		{
			get { return m_cuenta_banco; }
			set 
			{
				m_changed=true;
				m_cuenta_banco = value;
			}
		}

		/// <summary>
		/// Attribute for access the documentos_che's iva_tarjeta value (decimal)
		/// </summary>
		[DataMember]
		public decimal? iva_tarjeta
		{
			get { return m_iva_tarjeta; }
			set 
			{
				m_changed=true;
				m_iva_tarjeta = value;
			}
		}

		public object GetAttribute(string pattribute)
		{
			switch (pattribute)
			{
				case "sw": return sw;
				case "tipo": return tipo;
				case "numero": return numero;
				case "banco": return banco;
				case "documento": return documento;
				case "forma_pago": return forma_pago;
				case "fecha": return fecha;
				case "valor": return valor;
				case "consignar_en": return consignar_en;
				case "devuelto": return devuelto;
				case "tipo_consignacion": return tipo_consignacion;
				case "numero_consignacion": return numero_consignacion;
				case "fecha_devolucion": return fecha_devolucion;
				case "cuenta_banco": return cuenta_banco;
				case "iva_tarjeta": return iva_tarjeta;
				default: return null;
			}
		}

		public Type GetAttributeType(string pattribute)
		{
			return documentos_cheController.Instance.GetMethodType(pattribute, this);
		}

		public string GetSqlKey()
		{
			return "[tipo] = '" + tipo.ToString()+ "'" + " AND [numero] = " + numero.ToString() + " AND [banco] = " + banco.ToString() + " AND [documento] = '" + documento.ToString()+ "'" + " AND [forma_pago] = " + forma_pago.ToString();
		}
		#endregion

	}

	#endregion

	#region documentos_cheList object

	/// <summary>
	/// Class for reading and access a list of documentos_che object
	/// </summary>
	[CollectionDataContract]
	public partial class documentos_cheList : List<documentos_che>
	{

		/// <summary>
		/// Default constructor
		/// </summary>
		public documentos_cheList()
		{
		}
	}

	#endregion

}
