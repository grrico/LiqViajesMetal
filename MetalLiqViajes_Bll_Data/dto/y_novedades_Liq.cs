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
	#region y_novedades_Liq object

	[DataContract]
	public partial class y_novedades_Liq : IDTOObject
	{
		/// <summary>
		/// Default constructor
		/// </summary>
		public y_novedades_Liq()
		{
			m_IdNovedad = 0;
			m_nomina = "";
			m_contrato = 0;
			m_nit = 0;
			m_idperiodo = 0;
			m_concepto = 0;
			m_centro = 0;
			m_planta = (byte)0;
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
			m_changed=false;
		}
		        //Return the table name of object
		        public string TableName()
		        {
		            return "y_novedades_Liq";
		        }
		#region Undo 
		// Internal class for storing changes
		private y_novedades_Liq m_oldy_novedades_Liq;
		public void GenerateUndo()
		{
			m_oldy_novedades_Liq=new y_novedades_Liq();
			m_oldy_novedades_Liq.m_IdNovedad = m_IdNovedad;
			m_oldy_novedades_Liq.m_nomina = m_nomina;
			m_oldy_novedades_Liq.m_contrato = m_contrato;
			m_oldy_novedades_Liq.m_nit = m_nit;
			m_oldy_novedades_Liq.m_idperiodo = m_idperiodo;
			m_oldy_novedades_Liq.m_concepto = m_concepto;
			m_oldy_novedades_Liq.m_centro = m_centro;
			m_oldy_novedades_Liq.m_planta = m_planta;
			m_oldy_novedades_Liq.fecha = m_fecha;
			m_oldy_novedades_Liq.mes = m_mes;
			m_oldy_novedades_Liq.ano = m_ano;
			m_oldy_novedades_Liq.periodo = m_periodo;
			m_oldy_novedades_Liq.valor = m_valor;
			m_oldy_novedades_Liq.horas = m_horas;
			m_oldy_novedades_Liq.dias = m_dias;
			m_oldy_novedades_Liq.turno = m_turno;
			m_oldy_novedades_Liq.estado = m_estado;
			m_oldy_novedades_Liq.nro_presta = m_nro_presta;
			m_oldy_novedades_Liq.cpto_interes = m_cpto_interes;
			m_oldy_novedades_Liq.sumar = m_sumar;
			m_oldy_novedades_Liq.oficio = m_oficio;
		}

		public y_novedades_Liq Oldy_novedades_Liq
		{
			get { return m_oldy_novedades_Liq;}
		}
		// Return the changed fields
		public string[] FieldChanged()
		{
			List<string> fields=new List<string>();
			if (m_oldy_novedades_Liq.fecha != m_fecha) fields.Add("fecha");
			if (m_oldy_novedades_Liq.mes != m_mes) fields.Add("mes");
			if (m_oldy_novedades_Liq.ano != m_ano) fields.Add("ano");
			if (m_oldy_novedades_Liq.periodo != m_periodo) fields.Add("periodo");
			if (m_oldy_novedades_Liq.valor != m_valor) fields.Add("valor");
			if (m_oldy_novedades_Liq.horas != m_horas) fields.Add("horas");
			if (m_oldy_novedades_Liq.dias != m_dias) fields.Add("dias");
			if (m_oldy_novedades_Liq.turno != m_turno) fields.Add("turno");
			if (m_oldy_novedades_Liq.estado != m_estado) fields.Add("estado");
			if (m_oldy_novedades_Liq.nro_presta != m_nro_presta) fields.Add("nro_presta");
			if (m_oldy_novedades_Liq.cpto_interes != m_cpto_interes) fields.Add("cpto_interes");
			if (m_oldy_novedades_Liq.sumar != m_sumar) fields.Add("sumar");
			if (m_oldy_novedades_Liq.oficio != m_oficio) fields.Add("oficio");
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


		// Field for storing the y_novedades_Liq's fecha value
		private DateTime m_fecha;

		// Field for storing the y_novedades_Liq's mes value
		private byte? m_mes;

		// Field for storing the y_novedades_Liq's ano value
		private short? m_ano;

		// Field for storing the y_novedades_Liq's periodo value
		private int? m_periodo;

		// Field for storing the y_novedades_Liq's valor value
		private decimal? m_valor;

		// Field for storing the y_novedades_Liq's horas value
		private float? m_horas;

		// Field for storing the y_novedades_Liq's dias value
		private float? m_dias;

		// Field for storing the y_novedades_Liq's turno value
		private byte? m_turno;

		// Field for storing the y_novedades_Liq's estado value
		private char? m_estado;

		// Field for storing the y_novedades_Liq's nro_presta value
		private int? m_nro_presta;

		// Field for storing the y_novedades_Liq's cpto_interes value
		private short? m_cpto_interes;

		// Field for storing the y_novedades_Liq's sumar value
		private bool m_sumar;

		// Field for storing the y_novedades_Liq's oficio value
		private string m_oficio;

		// Field for storing the y_novedades_Liq's IdNovedad value
		private int m_IdNovedad;

		// Field for storing the y_novedades_Liq's nomina value
		private string m_nomina;

		// Field for storing the y_novedades_Liq's contrato value
		private int m_contrato;

		// Field for storing the y_novedades_Liq's nit value
		private decimal m_nit;

		// Field for storing the y_novedades_Liq's idperiodo value
		private int m_idperiodo;

		// Field for storing the y_novedades_Liq's concepto value
		private short m_concepto;

		// Field for storing the y_novedades_Liq's centro value
		private int m_centro;

		// Field for storing the y_novedades_Liq's planta value
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
		/// Attribute for access the y_novedades_Liq's fecha value (DateTime)
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
		/// Attribute for access the y_novedades_Liq's mes value (byte)
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
		/// Attribute for access the y_novedades_Liq's ano value (short)
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
		/// Attribute for access the y_novedades_Liq's periodo value (int)
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
		/// Attribute for access the y_novedades_Liq's valor value (decimal)
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
		/// Attribute for access the y_novedades_Liq's horas value (float)
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
		/// Attribute for access the y_novedades_Liq's dias value (float)
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
		/// Attribute for access the y_novedades_Liq's turno value (byte)
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
		/// Attribute for access the y_novedades_Liq's estado value (char)
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
		/// Attribute for access the y_novedades_Liq's nro_presta value (int)
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
		/// Attribute for access the y_novedades_Liq's cpto_interes value (short)
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
		/// Attribute for access the y_novedades_Liq's sumar value (bool)
		/// </summary>
		[DataMember]
		public bool sumar
		{
			get { return m_sumar; }
			set 
			{
				m_changed=true;
				m_sumar = value;
			}
		}

		/// <summary>
		/// Attribute for access the y_novedades_Liq's oficio value (string)
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
		/// Attribute for access the y_novedades_Liq's IdNovedad value (int)
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
		/// Attribute for access the y_novedades_Liq's nomina value (string)
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
		/// Attribute for access the y_novedades_Liq's contrato value (int)
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
		/// Attribute for access the y_novedades_Liq's nit value (decimal)
		/// </summary>
		[DataMember]
		public decimal nit
		{
			get { return m_nit; }
			set 
			{
				m_changed=true;
				m_nit = value;
			}
		}

		/// <summary>
		/// Attribute for access the y_novedades_Liq's idperiodo value (int)
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
		/// Attribute for access the y_novedades_Liq's concepto value (short)
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
		/// Attribute for access the y_novedades_Liq's centro value (int)
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
		/// Attribute for access the y_novedades_Liq's planta value (byte)
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
				case "IdNovedad": return IdNovedad;
				case "nomina": return nomina;
				case "contrato": return contrato;
				case "nit": return nit;
				case "idperiodo": return idperiodo;
				case "concepto": return concepto;
				case "centro": return centro;
				case "planta": return planta;
				default: return null;
			}
		}

		public Type GetAttributeType(string pattribute)
		{
			return y_novedades_LiqController.Instance.GetMethodType(pattribute, this);
		}

		public string GetSqlKey()
		{
			return "[IdNovedad] = " + IdNovedad.ToString() + " AND [nomina] = '" + nomina.ToString()+ "'" + " AND [contrato] = " + contrato.ToString() + " AND [nit] = " + nit.ToString() + " AND [idperiodo] = " + idperiodo.ToString() + " AND [concepto] = " + concepto.ToString() + " AND [centro] = " + centro.ToString() + " AND [planta] = " + planta.ToString();
		}
		#endregion

	}

	#endregion

	#region y_novedades_LiqList object

	/// <summary>
	/// Class for reading and access a list of y_novedades_Liq object
	/// </summary>
	[CollectionDataContract]
	public partial class y_novedades_LiqList : List<y_novedades_Liq>
	{

		/// <summary>
		/// Default constructor
		/// </summary>
		public y_novedades_LiqList()
		{
		}
	}

	#endregion

}
