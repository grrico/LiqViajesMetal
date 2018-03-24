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

namespace LiqMetalDMS_Bll_Data
{
	#region documentos_cruce object

	[DataContract]
	public partial class documentos_cruce : IDTOObject
	{
		/// <summary>
		/// Default constructor
		/// </summary>
		public documentos_cruce()
		{
			m_id = 0;
			m_tipo = "";
			m_numero = 0;
			m_tipo_aplica = "";
			m_numero_aplica = 0;
			m_numero_cuota = 0;
			m_sw = (byte)0;
			m_valor = null;
			m_descuento = null;
			m_retencion = null;
			m_ajuste = null;
			m_retencion_iva = null;
			m_retencion_ica = null;
			m_fecha = null;
			m_retencion2 = null;
			m_retencion3 = null;
			m_fecha_cruce = null;
			m_trasporte = ' ';
			m_cree = null;
			m_changed=false;
		}
		        //Return the table name of object
		        public string TableName()
		        {
		            return "documentos_cruce";
		        }
		#region Undo 
		// Internal class for storing changes
		private documentos_cruce m_olddocumentos_cruce;
		public void GenerateUndo()
		{
			m_olddocumentos_cruce=new documentos_cruce();
			m_olddocumentos_cruce.m_id = m_id;
			m_olddocumentos_cruce.m_tipo = m_tipo;
			m_olddocumentos_cruce.m_numero = m_numero;
			m_olddocumentos_cruce.m_tipo_aplica = m_tipo_aplica;
			m_olddocumentos_cruce.m_numero_aplica = m_numero_aplica;
			m_olddocumentos_cruce.m_numero_cuota = m_numero_cuota;
			m_olddocumentos_cruce.sw = m_sw;
			m_olddocumentos_cruce.valor = m_valor;
			m_olddocumentos_cruce.descuento = m_descuento;
			m_olddocumentos_cruce.retencion = m_retencion;
			m_olddocumentos_cruce.ajuste = m_ajuste;
			m_olddocumentos_cruce.retencion_iva = m_retencion_iva;
			m_olddocumentos_cruce.retencion_ica = m_retencion_ica;
			m_olddocumentos_cruce.fecha = m_fecha;
			m_olddocumentos_cruce.retencion2 = m_retencion2;
			m_olddocumentos_cruce.retencion3 = m_retencion3;
			m_olddocumentos_cruce.fecha_cruce = m_fecha_cruce;
			m_olddocumentos_cruce.trasporte = m_trasporte;
			m_olddocumentos_cruce.cree = m_cree;
		}

		public documentos_cruce Olddocumentos_cruce
		{
			get { return m_olddocumentos_cruce;}
		}
		// Return the changed fields
		public string[] FieldChanged()
		{
			List<string> fields=new List<string>();
			if (m_olddocumentos_cruce.sw != m_sw) fields.Add("sw");
			if (m_olddocumentos_cruce.valor != m_valor) fields.Add("valor");
			if (m_olddocumentos_cruce.descuento != m_descuento) fields.Add("descuento");
			if (m_olddocumentos_cruce.retencion != m_retencion) fields.Add("retencion");
			if (m_olddocumentos_cruce.ajuste != m_ajuste) fields.Add("ajuste");
			if (m_olddocumentos_cruce.retencion_iva != m_retencion_iva) fields.Add("retencion_iva");
			if (m_olddocumentos_cruce.retencion_ica != m_retencion_ica) fields.Add("retencion_ica");
			if (m_olddocumentos_cruce.fecha != m_fecha) fields.Add("fecha");
			if (m_olddocumentos_cruce.retencion2 != m_retencion2) fields.Add("retencion2");
			if (m_olddocumentos_cruce.retencion3 != m_retencion3) fields.Add("retencion3");
			if (m_olddocumentos_cruce.fecha_cruce != m_fecha_cruce) fields.Add("fecha_cruce");
			if (m_olddocumentos_cruce.trasporte != m_trasporte) fields.Add("trasporte");
			if (m_olddocumentos_cruce.cree != m_cree) fields.Add("cree");
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


		// Field for storing the documentos_cruce's id value
		private int m_id;

		// Field for storing the documentos_cruce's tipo value
		private string m_tipo;

		// Field for storing the documentos_cruce's numero value
		private int m_numero;

		// Field for storing the documentos_cruce's sw value
		private byte m_sw;

		// Field for storing the documentos_cruce's tipo_aplica value
		private string m_tipo_aplica;

		// Field for storing the documentos_cruce's numero_aplica value
		private int m_numero_aplica;

		// Field for storing the documentos_cruce's numero_cuota value
		private short m_numero_cuota;

		// Field for storing the documentos_cruce's valor value
		private decimal? m_valor;

		// Field for storing the documentos_cruce's descuento value
		private decimal? m_descuento;

		// Field for storing the documentos_cruce's retencion value
		private decimal? m_retencion;

		// Field for storing the documentos_cruce's ajuste value
		private decimal? m_ajuste;

		// Field for storing the documentos_cruce's retencion_iva value
		private decimal? m_retencion_iva;

		// Field for storing the documentos_cruce's retencion_ica value
		private decimal? m_retencion_ica;

		// Field for storing the documentos_cruce's fecha value
		private DateTime? m_fecha;

		// Field for storing the documentos_cruce's retencion2 value
		private decimal? m_retencion2;

		// Field for storing the documentos_cruce's retencion3 value
		private decimal? m_retencion3;

		// Field for storing the documentos_cruce's fecha_cruce value
		private DateTime? m_fecha_cruce;

		// Field for storing the documentos_cruce's trasporte value
		private char? m_trasporte;

		// Field for storing the documentos_cruce's cree value
		private decimal? m_cree;

		// Evaluate changed state
		private bool m_changed=false;
		// Field for storing the reference to documentos accessed by tipo, numero
		private documentos m_documentos;


		#endregion

		#region Attributes

		// Return if object changed
		public bool Changed
		{
			get { return m_changed;}
			set { m_changed=value;}
		}
		/// <summary>
		/// Attribute for access the documentos_cruce's id value (int)
		/// </summary>
		[DataMember]
		public int id
		{
			get { return m_id; }
			set 
			{
				m_changed=true;
				m_id = value;
			}
		}

		/// <summary>
		/// Attribute for access the documentos_cruce's tipo value (string)
		/// </summary>
		[DataMember]
		public string tipo
		{
			get { return m_tipo; }
			set
			{
				m_changed=true;
				m_tipo = value;

				if ((m_documentos != null) && (m_documentos.tipo != m_tipo))
				{
					// we need to reset the reference because it is now invalid
					m_documentos = null;
				}
			}
		}

		/// <summary>
		/// Attribute for access the documentos_cruce's numero value (int)
		/// </summary>
		[DataMember]
		public int numero
		{
			get { return m_numero; }
			set
			{
				m_changed=true;
				m_numero = value;

				if ((m_documentos != null) && (m_documentos.numero != m_numero))
				{
					// we need to reset the reference because it is now invalid
					m_documentos = null;
				}
			}
		}

		/// <summary>
		/// Attribute for access the documentos_cruce's sw value (byte)
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
		/// Attribute for access the documentos_cruce's tipo_aplica value (string)
		/// </summary>
		[DataMember]
		public string tipo_aplica
		{
			get { return m_tipo_aplica; }
			set 
			{
				m_changed=true;
				m_tipo_aplica = value;
			}
		}

		/// <summary>
		/// Attribute for access the documentos_cruce's numero_aplica value (int)
		/// </summary>
		[DataMember]
		public int numero_aplica
		{
			get { return m_numero_aplica; }
			set 
			{
				m_changed=true;
				m_numero_aplica = value;
			}
		}

		/// <summary>
		/// Attribute for access the documentos_cruce's numero_cuota value (short)
		/// </summary>
		[DataMember]
		public short numero_cuota
		{
			get { return m_numero_cuota; }
			set 
			{
				m_changed=true;
				m_numero_cuota = value;
			}
		}

		/// <summary>
		/// Attribute for access the documentos_cruce's valor value (decimal)
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
		/// Attribute for access the documentos_cruce's descuento value (decimal)
		/// </summary>
		[DataMember]
		public decimal? descuento
		{
			get { return m_descuento; }
			set 
			{
				m_changed=true;
				m_descuento = value;
			}
		}

		/// <summary>
		/// Attribute for access the documentos_cruce's retencion value (decimal)
		/// </summary>
		[DataMember]
		public decimal? retencion
		{
			get { return m_retencion; }
			set 
			{
				m_changed=true;
				m_retencion = value;
			}
		}

		/// <summary>
		/// Attribute for access the documentos_cruce's ajuste value (decimal)
		/// </summary>
		[DataMember]
		public decimal? ajuste
		{
			get { return m_ajuste; }
			set 
			{
				m_changed=true;
				m_ajuste = value;
			}
		}

		/// <summary>
		/// Attribute for access the documentos_cruce's retencion_iva value (decimal)
		/// </summary>
		[DataMember]
		public decimal? retencion_iva
		{
			get { return m_retencion_iva; }
			set 
			{
				m_changed=true;
				m_retencion_iva = value;
			}
		}

		/// <summary>
		/// Attribute for access the documentos_cruce's retencion_ica value (decimal)
		/// </summary>
		[DataMember]
		public decimal? retencion_ica
		{
			get { return m_retencion_ica; }
			set 
			{
				m_changed=true;
				m_retencion_ica = value;
			}
		}

		/// <summary>
		/// Attribute for access the documentos_cruce's fecha value (DateTime)
		/// </summary>
		[DataMember]
		public DateTime? fecha
		{
			get { return m_fecha; }
			set 
			{
				m_changed=true;
				m_fecha = value;
			}
		}

		/// <summary>
		/// Attribute for access the documentos_cruce's retencion2 value (decimal)
		/// </summary>
		[DataMember]
		public decimal? retencion2
		{
			get { return m_retencion2; }
			set 
			{
				m_changed=true;
				m_retencion2 = value;
			}
		}

		/// <summary>
		/// Attribute for access the documentos_cruce's retencion3 value (decimal)
		/// </summary>
		[DataMember]
		public decimal? retencion3
		{
			get { return m_retencion3; }
			set 
			{
				m_changed=true;
				m_retencion3 = value;
			}
		}

		/// <summary>
		/// Attribute for access the documentos_cruce's fecha_cruce value (DateTime)
		/// </summary>
		[DataMember]
		public DateTime? fecha_cruce
		{
			get { return m_fecha_cruce; }
			set 
			{
				m_changed=true;
				m_fecha_cruce = value;
			}
		}

		/// <summary>
		/// Attribute for access the documentos_cruce's trasporte value (char)
		/// </summary>
		[DataMember]
		public char? trasporte
		{
			get { return m_trasporte; }
			set 
			{
				m_changed=true;
				m_trasporte = value;
			}
		}

		/// <summary>
		/// Attribute for access the documentos_cruce's cree value (decimal)
		/// </summary>
		[DataMember]
		public decimal? cree
		{
			get { return m_cree; }
			set 
			{
				m_changed=true;
				m_cree = value;
			}
		}

		public object GetAttribute(string pattribute)
		{
			switch (pattribute)
			{
				case "id": return id;
				case "tipo": return tipo;
				case "numero": return numero;
				case "sw": return sw;
				case "tipo_aplica": return tipo_aplica;
				case "numero_aplica": return numero_aplica;
				case "numero_cuota": return numero_cuota;
				case "valor": return valor;
				case "descuento": return descuento;
				case "retencion": return retencion;
				case "ajuste": return ajuste;
				case "retencion_iva": return retencion_iva;
				case "retencion_ica": return retencion_ica;
				case "fecha": return fecha;
				case "retencion2": return retencion2;
				case "retencion3": return retencion3;
				case "fecha_cruce": return fecha_cruce;
				case "trasporte": return trasporte;
				case "cree": return cree;
				default: return null;
			}
		}

		public Type GetAttributeType(string pattribute)
		{
			return documentos_cruceController.Instance.GetMethodType(pattribute, this);
		}

		public string GetSqlKey()
		{
			return "[id] = " + id.ToString() + " AND [tipo] = '" + tipo.ToString()+ "'" + " AND [numero] = " + numero.ToString() + " AND [tipo_aplica] = '" + tipo_aplica.ToString()+ "'" + " AND [numero_aplica] = " + numero_aplica.ToString() + " AND [numero_cuota] = " + numero_cuota.ToString();
		}
		/// <summary>
		/// Gets or sets the reference to documentos accessed by tipo, numero
		/// </summary>
		/// <remarks>
		/// Also updates related field values
		/// </remarks>
		public documentos documentos
		{
			get
			{
				if (m_documentos == null)
				{
					m_documentos = documentosController.Instance.Get(m_tipo,m_numero);
				}

				return m_documentos;
			}

			set
			{
				m_documentos = value;

				if (m_documentos != null)
				{
					this.m_tipo = m_documentos.tipo;
					this.m_numero = m_documentos.numero;
				}
			}
		}

		#endregion

	}

	#endregion

	#region documentos_cruceList object

	/// <summary>
	/// Class for reading and access a list of documentos_cruce object
	/// </summary>
	[CollectionDataContract]
	public partial class documentos_cruceList : List<documentos_cruce>
	{

		/// <summary>
		/// Default constructor
		/// </summary>
		public documentos_cruceList()
		{
		}
	}

	#endregion

}
