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
	#region AnticiposDms object

	[DataContract]
	public partial class AnticiposDms : IDTOObject
	{
		/// <summary>
		/// Default constructor
		/// </summary>
		public AnticiposDms()
		{
			m_Dms_Codigo = 0;
			m_Dms_Tipo = null;
			m_Dms_Numero = null;
			m_Dms_Modelo = null;
			m_Dms_Sw = (byte)0;
			m_Dms_Placa = null;
			m_Dms_lngIdRegistroViaje = null;
			m_Dms_lngIdRegistroViajeTramo = null;
			m_Dms_Nit = null;
			m_Dms_Fecha = null;
			m_Dms_ValorTotal = null;
			m_Dms_ValorAplicado = null;
			m_Dms_ValorAnticipo = null;
			m_Dms_Chk = null;
			m_Dms_Nota = null;
			m_Dms_Documento = null;
			m_Dms_CodBanco = null;
			m_Dms_NombreBanco = null;
			m_Dms_DescripcionModelo = null;
			m_Dms_Cuenta1 = null;
			m_Dms_Cuenta2 = null;
			m_Dms_DescripcionCta1 = null;
			m_Dms_DescripcionCta2 = null;
			m_Dms_Usuario = null;
			m_Dms_FechaReal = null;
			m_Dms_NombreTercero = null;
			m_changed=false;
		}
		        //Return the table name of object
		        public string TableName()
		        {
		            return "AnticiposDms";
		        }
		#region Undo 
		// Internal class for storing changes
		private AnticiposDms m_oldAnticiposDms;
		public void GenerateUndo()
		{
			m_oldAnticiposDms=new AnticiposDms();
			m_oldAnticiposDms.m_Dms_Codigo = m_Dms_Codigo;
			m_oldAnticiposDms.Dms_Tipo = m_Dms_Tipo;
			m_oldAnticiposDms.Dms_Numero = m_Dms_Numero;
			m_oldAnticiposDms.Dms_Modelo = m_Dms_Modelo;
			m_oldAnticiposDms.Dms_Sw = m_Dms_Sw;
			m_oldAnticiposDms.Dms_Placa = m_Dms_Placa;
			m_oldAnticiposDms.Dms_lngIdRegistroViaje = m_Dms_lngIdRegistroViaje;
			m_oldAnticiposDms.Dms_lngIdRegistroViajeTramo = m_Dms_lngIdRegistroViajeTramo;
			m_oldAnticiposDms.Dms_Nit = m_Dms_Nit;
			m_oldAnticiposDms.Dms_Fecha = m_Dms_Fecha;
			m_oldAnticiposDms.Dms_ValorTotal = m_Dms_ValorTotal;
			m_oldAnticiposDms.Dms_ValorAplicado = m_Dms_ValorAplicado;
			m_oldAnticiposDms.Dms_ValorAnticipo = m_Dms_ValorAnticipo;
			m_oldAnticiposDms.Dms_Chk = m_Dms_Chk;
			m_oldAnticiposDms.Dms_Nota = m_Dms_Nota;
			m_oldAnticiposDms.Dms_Documento = m_Dms_Documento;
			m_oldAnticiposDms.Dms_CodBanco = m_Dms_CodBanco;
			m_oldAnticiposDms.Dms_NombreBanco = m_Dms_NombreBanco;
			m_oldAnticiposDms.Dms_DescripcionModelo = m_Dms_DescripcionModelo;
			m_oldAnticiposDms.Dms_Cuenta1 = m_Dms_Cuenta1;
			m_oldAnticiposDms.Dms_Cuenta2 = m_Dms_Cuenta2;
			m_oldAnticiposDms.Dms_DescripcionCta1 = m_Dms_DescripcionCta1;
			m_oldAnticiposDms.Dms_DescripcionCta2 = m_Dms_DescripcionCta2;
			m_oldAnticiposDms.Dms_Usuario = m_Dms_Usuario;
			m_oldAnticiposDms.Dms_FechaReal = m_Dms_FechaReal;
			m_oldAnticiposDms.Dms_NombreTercero = m_Dms_NombreTercero;
		}

		public AnticiposDms OldAnticiposDms
		{
			get { return m_oldAnticiposDms;}
		}
		// Return the changed fields
		public string[] FieldChanged()
		{
			List<string> fields=new List<string>();
			if (m_oldAnticiposDms.Dms_Tipo != m_Dms_Tipo) fields.Add("Dms_Tipo");
			if (m_oldAnticiposDms.Dms_Numero != m_Dms_Numero) fields.Add("Dms_Numero");
			if (m_oldAnticiposDms.Dms_Modelo != m_Dms_Modelo) fields.Add("Dms_Modelo");
			if (m_oldAnticiposDms.Dms_Sw != m_Dms_Sw) fields.Add("Dms_Sw");
			if (m_oldAnticiposDms.Dms_Placa != m_Dms_Placa) fields.Add("Dms_Placa");
			if (m_oldAnticiposDms.Dms_lngIdRegistroViaje != m_Dms_lngIdRegistroViaje) fields.Add("Dms_lngIdRegistroViaje");
			if (m_oldAnticiposDms.Dms_lngIdRegistroViajeTramo != m_Dms_lngIdRegistroViajeTramo) fields.Add("Dms_lngIdRegistroViajeTramo");
			if (m_oldAnticiposDms.Dms_Nit != m_Dms_Nit) fields.Add("Dms_Nit");
			if (m_oldAnticiposDms.Dms_Fecha != m_Dms_Fecha) fields.Add("Dms_Fecha");
			if (m_oldAnticiposDms.Dms_ValorTotal != m_Dms_ValorTotal) fields.Add("Dms_ValorTotal");
			if (m_oldAnticiposDms.Dms_ValorAplicado != m_Dms_ValorAplicado) fields.Add("Dms_ValorAplicado");
			if (m_oldAnticiposDms.Dms_ValorAnticipo != m_Dms_ValorAnticipo) fields.Add("Dms_ValorAnticipo");
			if (m_oldAnticiposDms.Dms_Chk != m_Dms_Chk) fields.Add("Dms_Chk");
			if (m_oldAnticiposDms.Dms_Nota != m_Dms_Nota) fields.Add("Dms_Nota");
			if (m_oldAnticiposDms.Dms_Documento != m_Dms_Documento) fields.Add("Dms_Documento");
			if (m_oldAnticiposDms.Dms_CodBanco != m_Dms_CodBanco) fields.Add("Dms_CodBanco");
			if (m_oldAnticiposDms.Dms_NombreBanco != m_Dms_NombreBanco) fields.Add("Dms_NombreBanco");
			if (m_oldAnticiposDms.Dms_DescripcionModelo != m_Dms_DescripcionModelo) fields.Add("Dms_DescripcionModelo");
			if (m_oldAnticiposDms.Dms_Cuenta1 != m_Dms_Cuenta1) fields.Add("Dms_Cuenta1");
			if (m_oldAnticiposDms.Dms_Cuenta2 != m_Dms_Cuenta2) fields.Add("Dms_Cuenta2");
			if (m_oldAnticiposDms.Dms_DescripcionCta1 != m_Dms_DescripcionCta1) fields.Add("Dms_DescripcionCta1");
			if (m_oldAnticiposDms.Dms_DescripcionCta2 != m_Dms_DescripcionCta2) fields.Add("Dms_DescripcionCta2");
			if (m_oldAnticiposDms.Dms_Usuario != m_Dms_Usuario) fields.Add("Dms_Usuario");
			if (m_oldAnticiposDms.Dms_FechaReal != m_Dms_FechaReal) fields.Add("Dms_FechaReal");
			if (m_oldAnticiposDms.Dms_NombreTercero != m_Dms_NombreTercero) fields.Add("Dms_NombreTercero");
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


		// Field for storing the AnticiposDms's Dms_Codigo value
		private int m_Dms_Codigo;

		// Field for storing the AnticiposDms's Dms_Tipo value
		private string m_Dms_Tipo;

		// Field for storing the AnticiposDms's Dms_Numero value
		private int? m_Dms_Numero;

		// Field for storing the AnticiposDms's Dms_Modelo value
		private string m_Dms_Modelo;

		// Field for storing the AnticiposDms's Dms_Sw value
		private byte? m_Dms_Sw;

		// Field for storing the AnticiposDms's Dms_Placa value
		private string m_Dms_Placa;

		// Field for storing the AnticiposDms's Dms_lngIdRegistroViaje value
		private int? m_Dms_lngIdRegistroViaje;

		// Field for storing the AnticiposDms's Dms_lngIdRegistroViajeTramo value
		private decimal? m_Dms_lngIdRegistroViajeTramo;

		// Field for storing the AnticiposDms's Dms_Nit value
		private decimal? m_Dms_Nit;

		// Field for storing the AnticiposDms's Dms_Fecha value
		private DateTime? m_Dms_Fecha;

		// Field for storing the AnticiposDms's Dms_ValorTotal value
		private decimal? m_Dms_ValorTotal;

		// Field for storing the AnticiposDms's Dms_ValorAplicado value
		private decimal? m_Dms_ValorAplicado;

		// Field for storing the AnticiposDms's Dms_ValorAnticipo value
		private decimal? m_Dms_ValorAnticipo;

		// Field for storing the AnticiposDms's Dms_Chk value
		private int? m_Dms_Chk;

		// Field for storing the AnticiposDms's Dms_Nota value
		private string m_Dms_Nota;

		// Field for storing the AnticiposDms's Dms_Documento value
		private string m_Dms_Documento;

		// Field for storing the AnticiposDms's Dms_CodBanco value
		private double? m_Dms_CodBanco;

		// Field for storing the AnticiposDms's Dms_NombreBanco value
		private string m_Dms_NombreBanco;

		// Field for storing the AnticiposDms's Dms_DescripcionModelo value
		private string m_Dms_DescripcionModelo;

		// Field for storing the AnticiposDms's Dms_Cuenta1 value
		private string m_Dms_Cuenta1;

		// Field for storing the AnticiposDms's Dms_Cuenta2 value
		private string m_Dms_Cuenta2;

		// Field for storing the AnticiposDms's Dms_DescripcionCta1 value
		private string m_Dms_DescripcionCta1;

		// Field for storing the AnticiposDms's Dms_DescripcionCta2 value
		private string m_Dms_DescripcionCta2;

		// Field for storing the AnticiposDms's Dms_Usuario value
		private string m_Dms_Usuario;

		// Field for storing the AnticiposDms's Dms_FechaReal value
		private DateTime? m_Dms_FechaReal;

		// Field for storing the AnticiposDms's Dms_NombreTercero value
		private string m_Dms_NombreTercero;

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
		/// Attribute for access the AnticiposDms's Dms_Codigo value (int)
		/// </summary>
		[DataMember]
		public int Dms_Codigo
		{
			get { return m_Dms_Codigo; }
			set 
			{
				m_changed=true;
				m_Dms_Codigo = value;
			}
		}

		/// <summary>
		/// Attribute for access the AnticiposDms's Dms_Tipo value (string)
		/// </summary>
		[DataMember]
		public string Dms_Tipo
		{
			get { return m_Dms_Tipo; }
			set 
			{
				m_changed=true;
				m_Dms_Tipo = value;
			}
		}

		/// <summary>
		/// Attribute for access the AnticiposDms's Dms_Numero value (int)
		/// </summary>
		[DataMember]
		public int? Dms_Numero
		{
			get { return m_Dms_Numero; }
			set 
			{
				m_changed=true;
				m_Dms_Numero = value;
			}
		}

		/// <summary>
		/// Attribute for access the AnticiposDms's Dms_Modelo value (string)
		/// </summary>
		[DataMember]
		public string Dms_Modelo
		{
			get { return m_Dms_Modelo; }
			set 
			{
				m_changed=true;
				m_Dms_Modelo = value;
			}
		}

		/// <summary>
		/// Attribute for access the AnticiposDms's Dms_Sw value (byte)
		/// </summary>
		[DataMember]
		public byte? Dms_Sw
		{
			get { return m_Dms_Sw; }
			set 
			{
				m_changed=true;
				m_Dms_Sw = value;
			}
		}

		/// <summary>
		/// Attribute for access the AnticiposDms's Dms_Placa value (string)
		/// </summary>
		[DataMember]
		public string Dms_Placa
		{
			get { return m_Dms_Placa; }
			set 
			{
				m_changed=true;
				m_Dms_Placa = value;
			}
		}

		/// <summary>
		/// Attribute for access the AnticiposDms's Dms_lngIdRegistroViaje value (int)
		/// </summary>
		[DataMember]
		public int? Dms_lngIdRegistroViaje
		{
			get { return m_Dms_lngIdRegistroViaje; }
			set 
			{
				m_changed=true;
				m_Dms_lngIdRegistroViaje = value;
			}
		}

		/// <summary>
		/// Attribute for access the AnticiposDms's Dms_lngIdRegistroViajeTramo value (decimal)
		/// </summary>
		[DataMember]
		public decimal? Dms_lngIdRegistroViajeTramo
		{
			get { return m_Dms_lngIdRegistroViajeTramo; }
			set 
			{
				m_changed=true;
				m_Dms_lngIdRegistroViajeTramo = value;
			}
		}

		/// <summary>
		/// Attribute for access the AnticiposDms's Dms_Nit value (decimal)
		/// </summary>
		[DataMember]
		public decimal? Dms_Nit
		{
			get { return m_Dms_Nit; }
			set 
			{
				m_changed=true;
				m_Dms_Nit = value;
			}
		}

		/// <summary>
		/// Attribute for access the AnticiposDms's Dms_Fecha value (DateTime)
		/// </summary>
		[DataMember]
		public DateTime? Dms_Fecha
		{
			get { return m_Dms_Fecha; }
			set 
			{
				m_changed=true;
				m_Dms_Fecha = value;
			}
		}

		/// <summary>
		/// Attribute for access the AnticiposDms's Dms_ValorTotal value (decimal)
		/// </summary>
		[DataMember]
		public decimal? Dms_ValorTotal
		{
			get { return m_Dms_ValorTotal; }
			set 
			{
				m_changed=true;
				m_Dms_ValorTotal = value;
			}
		}

		/// <summary>
		/// Attribute for access the AnticiposDms's Dms_ValorAplicado value (decimal)
		/// </summary>
		[DataMember]
		public decimal? Dms_ValorAplicado
		{
			get { return m_Dms_ValorAplicado; }
			set 
			{
				m_changed=true;
				m_Dms_ValorAplicado = value;
			}
		}

		/// <summary>
		/// Attribute for access the AnticiposDms's Dms_ValorAnticipo value (decimal)
		/// </summary>
		[DataMember]
		public decimal? Dms_ValorAnticipo
		{
			get { return m_Dms_ValorAnticipo; }
			set 
			{
				m_changed=true;
				m_Dms_ValorAnticipo = value;
			}
		}

		/// <summary>
		/// Attribute for access the AnticiposDms's Dms_Chk value (int)
		/// </summary>
		[DataMember]
		public int? Dms_Chk
		{
			get { return m_Dms_Chk; }
			set 
			{
				m_changed=true;
				m_Dms_Chk = value;
			}
		}

		/// <summary>
		/// Attribute for access the AnticiposDms's Dms_Nota value (string)
		/// </summary>
		[DataMember]
		public string Dms_Nota
		{
			get { return m_Dms_Nota; }
			set 
			{
				m_changed=true;
				m_Dms_Nota = value;
			}
		}

		/// <summary>
		/// Attribute for access the AnticiposDms's Dms_Documento value (string)
		/// </summary>
		[DataMember]
		public string Dms_Documento
		{
			get { return m_Dms_Documento; }
			set 
			{
				m_changed=true;
				m_Dms_Documento = value;
			}
		}

		/// <summary>
		/// Attribute for access the AnticiposDms's Dms_CodBanco value (double)
		/// </summary>
		[DataMember]
		public double? Dms_CodBanco
		{
			get { return m_Dms_CodBanco; }
			set 
			{
				m_changed=true;
				m_Dms_CodBanco = value;
			}
		}

		/// <summary>
		/// Attribute for access the AnticiposDms's Dms_NombreBanco value (string)
		/// </summary>
		[DataMember]
		public string Dms_NombreBanco
		{
			get { return m_Dms_NombreBanco; }
			set 
			{
				m_changed=true;
				m_Dms_NombreBanco = value;
			}
		}

		/// <summary>
		/// Attribute for access the AnticiposDms's Dms_DescripcionModelo value (string)
		/// </summary>
		[DataMember]
		public string Dms_DescripcionModelo
		{
			get { return m_Dms_DescripcionModelo; }
			set 
			{
				m_changed=true;
				m_Dms_DescripcionModelo = value;
			}
		}

		/// <summary>
		/// Attribute for access the AnticiposDms's Dms_Cuenta1 value (string)
		/// </summary>
		[DataMember]
		public string Dms_Cuenta1
		{
			get { return m_Dms_Cuenta1; }
			set 
			{
				m_changed=true;
				m_Dms_Cuenta1 = value;
			}
		}

		/// <summary>
		/// Attribute for access the AnticiposDms's Dms_Cuenta2 value (string)
		/// </summary>
		[DataMember]
		public string Dms_Cuenta2
		{
			get { return m_Dms_Cuenta2; }
			set 
			{
				m_changed=true;
				m_Dms_Cuenta2 = value;
			}
		}

		/// <summary>
		/// Attribute for access the AnticiposDms's Dms_DescripcionCta1 value (string)
		/// </summary>
		[DataMember]
		public string Dms_DescripcionCta1
		{
			get { return m_Dms_DescripcionCta1; }
			set 
			{
				m_changed=true;
				m_Dms_DescripcionCta1 = value;
			}
		}

		/// <summary>
		/// Attribute for access the AnticiposDms's Dms_DescripcionCta2 value (string)
		/// </summary>
		[DataMember]
		public string Dms_DescripcionCta2
		{
			get { return m_Dms_DescripcionCta2; }
			set 
			{
				m_changed=true;
				m_Dms_DescripcionCta2 = value;
			}
		}

		/// <summary>
		/// Attribute for access the AnticiposDms's Dms_Usuario value (string)
		/// </summary>
		[DataMember]
		public string Dms_Usuario
		{
			get { return m_Dms_Usuario; }
			set 
			{
				m_changed=true;
				m_Dms_Usuario = value;
			}
		}

		/// <summary>
		/// Attribute for access the AnticiposDms's Dms_FechaReal value (DateTime)
		/// </summary>
		[DataMember]
		public DateTime? Dms_FechaReal
		{
			get { return m_Dms_FechaReal; }
			set 
			{
				m_changed=true;
				m_Dms_FechaReal = value;
			}
		}

		/// <summary>
		/// Attribute for access the AnticiposDms's Dms_NombreTercero value (string)
		/// </summary>
		[DataMember]
		public string Dms_NombreTercero
		{
			get { return m_Dms_NombreTercero; }
			set 
			{
				m_changed=true;
				m_Dms_NombreTercero = value;
			}
		}

		public object GetAttribute(string pattribute)
		{
			switch (pattribute)
			{
				case "Dms_Codigo": return Dms_Codigo;
				case "Dms_Tipo": return Dms_Tipo;
				case "Dms_Numero": return Dms_Numero;
				case "Dms_Modelo": return Dms_Modelo;
				case "Dms_Sw": return Dms_Sw;
				case "Dms_Placa": return Dms_Placa;
				case "Dms_lngIdRegistroViaje": return Dms_lngIdRegistroViaje;
				case "Dms_lngIdRegistroViajeTramo": return Dms_lngIdRegistroViajeTramo;
				case "Dms_Nit": return Dms_Nit;
				case "Dms_Fecha": return Dms_Fecha;
				case "Dms_ValorTotal": return Dms_ValorTotal;
				case "Dms_ValorAplicado": return Dms_ValorAplicado;
				case "Dms_ValorAnticipo": return Dms_ValorAnticipo;
				case "Dms_Chk": return Dms_Chk;
				case "Dms_Nota": return Dms_Nota;
				case "Dms_Documento": return Dms_Documento;
				case "Dms_CodBanco": return Dms_CodBanco;
				case "Dms_NombreBanco": return Dms_NombreBanco;
				case "Dms_DescripcionModelo": return Dms_DescripcionModelo;
				case "Dms_Cuenta1": return Dms_Cuenta1;
				case "Dms_Cuenta2": return Dms_Cuenta2;
				case "Dms_DescripcionCta1": return Dms_DescripcionCta1;
				case "Dms_DescripcionCta2": return Dms_DescripcionCta2;
				case "Dms_Usuario": return Dms_Usuario;
				case "Dms_FechaReal": return Dms_FechaReal;
				case "Dms_NombreTercero": return Dms_NombreTercero;
				default: return null;
			}
		}

		public Type GetAttributeType(string pattribute)
		{
			return AnticiposDmsController.Instance.GetMethodType(pattribute, this);
		}

		public string GetSqlKey()
		{
			return "[Dms_Codigo] = " + Dms_Codigo.ToString();
		}
		#endregion

	}

	#endregion

	#region AnticiposDmsList object

	/// <summary>
	/// Class for reading and access a list of AnticiposDms object
	/// </summary>
	[CollectionDataContract]
	public partial class AnticiposDmsList : List<AnticiposDms>
	{

		/// <summary>
		/// Default constructor
		/// </summary>
		public AnticiposDmsList()
		{
		}
	}

	#endregion

}
