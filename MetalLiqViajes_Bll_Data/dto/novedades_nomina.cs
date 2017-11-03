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
	#region novedades_nomina object

	[DataContract]
	public partial class novedades_nomina : IDTOObject
	{
		/// <summary>
		/// Default constructor
		/// </summary>
		public novedades_nomina()
		{
			m_IdNovedad = 0;
			m_nomina = "";
			m_contrato = 0;
			m_nit = "";
			m_idperiodo = 0;
			m_centro = 0;
			m_planta = (byte)0;
			m_concepto = 0;
			m_fecha = DateTime.Now;
			m_mes = (byte)0;
			m_ano = null;
			m_periodo = null;
			m_valor = null;
			m_horas = null;
			m_dias = null;
			m_turno = (byte)0;
			m_estado = ' ';
			m_nro_presta = null;
			m_cpto_interes = null;
			m_sumar = false;
			m_oficio = null;
			m_tipo_doc = null;
			m_numero_doc = null;
			m_cuota = null;
			m_changed=false;
		}
		        //Return the table name of object
		        public string TableName()
		        {
		            return "novedades_nomina";
		        }
		#region Undo 
		// Internal class for storing changes
		private novedades_nomina m_oldnovedades_nomina;
		public void GenerateUndo()
		{
			m_oldnovedades_nomina=new novedades_nomina();
			m_oldnovedades_nomina.m_IdNovedad = m_IdNovedad;
			m_oldnovedades_nomina.m_nomina = m_nomina;
			m_oldnovedades_nomina.m_contrato = m_contrato;
			m_oldnovedades_nomina.m_nit = m_nit;
			m_oldnovedades_nomina.m_idperiodo = m_idperiodo;
			m_oldnovedades_nomina.m_centro = m_centro;
			m_oldnovedades_nomina.m_planta = m_planta;
			m_oldnovedades_nomina.concepto = m_concepto;
			m_oldnovedades_nomina.fecha = m_fecha;
			m_oldnovedades_nomina.mes = m_mes;
			m_oldnovedades_nomina.ano = m_ano;
			m_oldnovedades_nomina.periodo = m_periodo;
			m_oldnovedades_nomina.valor = m_valor;
			m_oldnovedades_nomina.horas = m_horas;
			m_oldnovedades_nomina.dias = m_dias;
			m_oldnovedades_nomina.turno = m_turno;
			m_oldnovedades_nomina.estado = m_estado;
			m_oldnovedades_nomina.nro_presta = m_nro_presta;
			m_oldnovedades_nomina.cpto_interes = m_cpto_interes;
			m_oldnovedades_nomina.sumar = m_sumar;
			m_oldnovedades_nomina.oficio = m_oficio;
			m_oldnovedades_nomina.tipo_doc = m_tipo_doc;
			m_oldnovedades_nomina.numero_doc = m_numero_doc;
			m_oldnovedades_nomina.cuota = m_cuota;
		}

		public novedades_nomina Oldnovedades_nomina
		{
			get { return m_oldnovedades_nomina;}
		}
		// Return the changed fields
		public string[] FieldChanged()
		{
			List<string> fields=new List<string>();
			if (m_oldnovedades_nomina.concepto != m_concepto) fields.Add("concepto");
			if (m_oldnovedades_nomina.fecha != m_fecha) fields.Add("fecha");
			if (m_oldnovedades_nomina.mes != m_mes) fields.Add("mes");
			if (m_oldnovedades_nomina.ano != m_ano) fields.Add("ano");
			if (m_oldnovedades_nomina.periodo != m_periodo) fields.Add("periodo");
			if (m_oldnovedades_nomina.valor != m_valor) fields.Add("valor");
			if (m_oldnovedades_nomina.horas != m_horas) fields.Add("horas");
			if (m_oldnovedades_nomina.dias != m_dias) fields.Add("dias");
			if (m_oldnovedades_nomina.turno != m_turno) fields.Add("turno");
			if (m_oldnovedades_nomina.estado != m_estado) fields.Add("estado");
			if (m_oldnovedades_nomina.nro_presta != m_nro_presta) fields.Add("nro_presta");
			if (m_oldnovedades_nomina.cpto_interes != m_cpto_interes) fields.Add("cpto_interes");
			if (m_oldnovedades_nomina.sumar != m_sumar) fields.Add("sumar");
			if (m_oldnovedades_nomina.oficio != m_oficio) fields.Add("oficio");
			if (m_oldnovedades_nomina.tipo_doc != m_tipo_doc) fields.Add("tipo_doc");
			if (m_oldnovedades_nomina.numero_doc != m_numero_doc) fields.Add("numero_doc");
			if (m_oldnovedades_nomina.cuota != m_cuota) fields.Add("cuota");
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


		// Field for storing the novedades_nomina's concepto value
		private short m_concepto;

		// Field for storing the novedades_nomina's fecha value
		private DateTime m_fecha;

		// Field for storing the novedades_nomina's mes value
		private byte? m_mes;

		// Field for storing the novedades_nomina's ano value
		private short? m_ano;

		// Field for storing the novedades_nomina's periodo value
		private int? m_periodo;

		// Field for storing the novedades_nomina's valor value
		private decimal? m_valor;

		// Field for storing the novedades_nomina's horas value
		private float? m_horas;

		// Field for storing the novedades_nomina's dias value
		private float? m_dias;

		// Field for storing the novedades_nomina's turno value
		private byte? m_turno;

		// Field for storing the novedades_nomina's estado value
		private char? m_estado;

		// Field for storing the novedades_nomina's nro_presta value
		private int? m_nro_presta;

		// Field for storing the novedades_nomina's cpto_interes value
		private short? m_cpto_interes;

		// Field for storing the novedades_nomina's sumar value
		private bool? m_sumar;

		// Field for storing the novedades_nomina's oficio value
		private string m_oficio;

		// Field for storing the novedades_nomina's tipo_doc value
		private string m_tipo_doc;

		// Field for storing the novedades_nomina's numero_doc value
		private int? m_numero_doc;

		// Field for storing the novedades_nomina's cuota value
		private int? m_cuota;

		// Field for storing the novedades_nomina's IdNovedad value
		private int m_IdNovedad;

		// Field for storing the novedades_nomina's nomina value
		private string m_nomina;

		// Field for storing the novedades_nomina's contrato value
		private int m_contrato;

		// Field for storing the novedades_nomina's nit value
		private string m_nit;

		// Field for storing the novedades_nomina's idperiodo value
		private int m_idperiodo;

		// Field for storing the novedades_nomina's centro value
		private int m_centro;

		// Field for storing the novedades_nomina's planta value
		private byte m_planta;

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
		/// Attribute for access the novedades_nomina's concepto value (short)
		/// </summary>
		[DataMember]
		public short concepto
		{
			get { return m_concepto; }
			set 
			{
				m_changed=true;
				m_concepto = value;
			}
		}

		/// <summary>
		/// Attribute for access the novedades_nomina's fecha value (DateTime)
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
		/// Attribute for access the novedades_nomina's mes value (byte)
		/// </summary>
		[DataMember]
		public byte? mes
		{
			get { return m_mes; }
			set 
			{
				m_changed=true;
				m_mes = value;
			}
		}

		/// <summary>
		/// Attribute for access the novedades_nomina's ano value (short)
		/// </summary>
		[DataMember]
		public short? ano
		{
			get { return m_ano; }
			set 
			{
				m_changed=true;
				m_ano = value;
			}
		}

		/// <summary>
		/// Attribute for access the novedades_nomina's periodo value (int)
		/// </summary>
		[DataMember]
		public int? periodo
		{
			get { return m_periodo; }
			set 
			{
				m_changed=true;
				m_periodo = value;
			}
		}

		/// <summary>
		/// Attribute for access the novedades_nomina's valor value (decimal)
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
		/// Attribute for access the novedades_nomina's horas value (float)
		/// </summary>
		[DataMember]
		public float? horas
		{
			get { return m_horas; }
			set 
			{
				m_changed=true;
				m_horas = value;
			}
		}

		/// <summary>
		/// Attribute for access the novedades_nomina's dias value (float)
		/// </summary>
		[DataMember]
		public float? dias
		{
			get { return m_dias; }
			set 
			{
				m_changed=true;
				m_dias = value;
			}
		}

		/// <summary>
		/// Attribute for access the novedades_nomina's turno value (byte)
		/// </summary>
		[DataMember]
		public byte? turno
		{
			get { return m_turno; }
			set 
			{
				m_changed=true;
				m_turno = value;
			}
		}

		/// <summary>
		/// Attribute for access the novedades_nomina's estado value (char)
		/// </summary>
		[DataMember]
		public char? estado
		{
			get { return m_estado; }
			set 
			{
				m_changed=true;
				m_estado = value;
			}
		}

		/// <summary>
		/// Attribute for access the novedades_nomina's nro_presta value (int)
		/// </summary>
		[DataMember]
		public int? nro_presta
		{
			get { return m_nro_presta; }
			set 
			{
				m_changed=true;
				m_nro_presta = value;
			}
		}

		/// <summary>
		/// Attribute for access the novedades_nomina's cpto_interes value (short)
		/// </summary>
		[DataMember]
		public short? cpto_interes
		{
			get { return m_cpto_interes; }
			set 
			{
				m_changed=true;
				m_cpto_interes = value;
			}
		}

		/// <summary>
		/// Attribute for access the novedades_nomina's sumar value (bool)
		/// </summary>
		[DataMember]
		public bool? sumar
		{
			get { return m_sumar; }
			set 
			{
				m_changed=true;
				m_sumar = value;
			}
		}

		/// <summary>
		/// Attribute for access the novedades_nomina's oficio value (string)
		/// </summary>
		[DataMember]
		public string oficio
		{
			get { return m_oficio; }
			set 
			{
				m_changed=true;
				m_oficio = value;
			}
		}

		/// <summary>
		/// Attribute for access the novedades_nomina's tipo_doc value (string)
		/// </summary>
		[DataMember]
		public string tipo_doc
		{
			get { return m_tipo_doc; }
			set 
			{
				m_changed=true;
				m_tipo_doc = value;
			}
		}

		/// <summary>
		/// Attribute for access the novedades_nomina's numero_doc value (int)
		/// </summary>
		[DataMember]
		public int? numero_doc
		{
			get { return m_numero_doc; }
			set 
			{
				m_changed=true;
				m_numero_doc = value;
			}
		}

		/// <summary>
		/// Attribute for access the novedades_nomina's cuota value (int)
		/// </summary>
		[DataMember]
		public int? cuota
		{
			get { return m_cuota; }
			set 
			{
				m_changed=true;
				m_cuota = value;
			}
		}

		/// <summary>
		/// Attribute for access the novedades_nomina's IdNovedad value (int)
		/// </summary>
		[DataMember]
		public int IdNovedad
		{
			get { return m_IdNovedad; }
			set 
			{
				m_changed=true;
				m_IdNovedad = value;
			}
		}

		/// <summary>
		/// Attribute for access the novedades_nomina's nomina value (string)
		/// </summary>
		[DataMember]
		public string nomina
		{
			get { return m_nomina; }
			set 
			{
				m_changed=true;
				m_nomina = value;
			}
		}

		/// <summary>
		/// Attribute for access the novedades_nomina's contrato value (int)
		/// </summary>
		[DataMember]
		public int contrato
		{
			get { return m_contrato; }
			set 
			{
				m_changed=true;
				m_contrato = value;
			}
		}

		/// <summary>
		/// Attribute for access the novedades_nomina's nit value (string)
		/// </summary>
		[DataMember]
		public string nit
		{
			get { return m_nit; }
			set 
			{
				m_changed=true;
				m_nit = value;
			}
		}

		/// <summary>
		/// Attribute for access the novedades_nomina's idperiodo value (int)
		/// </summary>
		[DataMember]
		public int idperiodo
		{
			get { return m_idperiodo; }
			set 
			{
				m_changed=true;
				m_idperiodo = value;
			}
		}

		/// <summary>
		/// Attribute for access the novedades_nomina's centro value (int)
		/// </summary>
		[DataMember]
		public int centro
		{
			get { return m_centro; }
			set 
			{
				m_changed=true;
				m_centro = value;
			}
		}

		/// <summary>
		/// Attribute for access the novedades_nomina's planta value (byte)
		/// </summary>
		[DataMember]
		public byte planta
		{
			get { return m_planta; }
			set 
			{
				m_changed=true;
				m_planta = value;
			}
		}

		public object GetAttribute(string pattribute)
		{
			switch (pattribute)
			{
				case "concepto": return concepto;
				case "fecha": return fecha;
				case "mes": return mes;
				case "ano": return ano;
				case "periodo": return periodo;
				case "valor": return valor;
				case "horas": return horas;
				case "dias": return dias;
				case "turno": return turno;
				case "estado": return estado;
				case "nro_presta": return nro_presta;
				case "cpto_interes": return cpto_interes;
				case "sumar": return sumar;
				case "oficio": return oficio;
				case "tipo_doc": return tipo_doc;
				case "numero_doc": return numero_doc;
				case "cuota": return cuota;
				case "IdNovedad": return IdNovedad;
				case "nomina": return nomina;
				case "contrato": return contrato;
				case "nit": return nit;
				case "idperiodo": return idperiodo;
				case "centro": return centro;
				case "planta": return planta;
				default: return null;
			}
		}

		public Type GetAttributeType(string pattribute)
		{
			return novedades_nominaController.Instance.GetMethodType(pattribute, this);
		}

		public string GetSqlKey()
		{
			return "[IdNovedad] = " + IdNovedad.ToString() + " AND [nomina] = '" + nomina.ToString()+ "'" + " AND [contrato] = " + contrato.ToString() + " AND [nit] = '" + nit.ToString()+ "'" + " AND [idperiodo] = " + idperiodo.ToString() + " AND [centro] = " + centro.ToString() + " AND [planta] = " + planta.ToString();
		}
		#endregion

	}

	#endregion

	#region novedades_nominaList object

	/// <summary>
	/// Class for reading and access a list of novedades_nomina object
	/// </summary>
	[CollectionDataContract]
	public partial class novedades_nominaList : List<novedades_nomina>
	{

		/// <summary>
		/// Default constructor
		/// </summary>
		public novedades_nominaList()
		{
		}
	}

	#endregion

}
