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
	#region RutasCuentaGastos object

	[DataContract]
	public partial class RutasCuentaGastos : IDTOObject
	{
		/// <summary>
		/// Default constructor
		/// </summary>
		public RutasCuentaGastos()
		{
			m_Codigo = 0;
			m_Campo = null;
			m_Cuenta1 = null;
			m_NombreCuenta1 = null;
			m_Nit2 = null;
			m_NombreTercero2 = null;
			m_Valor3 = null;
			m_Cuenta4 = null;
			m_NombreCuenta4 = null;
			m_Cuenta5 = null;
			m_NombreCuenta5 = null;
			m_Nit6 = null;
			m_NombreTercero6 = null;
			m_Valor7 = null;
			m_Cuenta8 = null;
			m_NombreCuenta8 = null;
			m_FechaCrea = null;
			m_Activo = false;
			m_Total = false;
			m_PadreCodigo = null;
			m_changed=false;
		}
		        //Return the table name of object
		        public string TableName()
		        {
		            return "RutasCuentaGastos";
		        }
		#region Undo 
		// Internal class for storing changes
		private RutasCuentaGastos m_oldRutasCuentaGastos;
		public void GenerateUndo()
		{
			m_oldRutasCuentaGastos=new RutasCuentaGastos();
			m_oldRutasCuentaGastos.m_Codigo = m_Codigo;
			m_oldRutasCuentaGastos.Campo = m_Campo;
			m_oldRutasCuentaGastos.Cuenta1 = m_Cuenta1;
			m_oldRutasCuentaGastos.NombreCuenta1 = m_NombreCuenta1;
			m_oldRutasCuentaGastos.Nit2 = m_Nit2;
			m_oldRutasCuentaGastos.NombreTercero2 = m_NombreTercero2;
			m_oldRutasCuentaGastos.Valor3 = m_Valor3;
			m_oldRutasCuentaGastos.Cuenta4 = m_Cuenta4;
			m_oldRutasCuentaGastos.NombreCuenta4 = m_NombreCuenta4;
			m_oldRutasCuentaGastos.Cuenta5 = m_Cuenta5;
			m_oldRutasCuentaGastos.NombreCuenta5 = m_NombreCuenta5;
			m_oldRutasCuentaGastos.Nit6 = m_Nit6;
			m_oldRutasCuentaGastos.NombreTercero6 = m_NombreTercero6;
			m_oldRutasCuentaGastos.Valor7 = m_Valor7;
			m_oldRutasCuentaGastos.Cuenta8 = m_Cuenta8;
			m_oldRutasCuentaGastos.NombreCuenta8 = m_NombreCuenta8;
			m_oldRutasCuentaGastos.FechaCrea = m_FechaCrea;
			m_oldRutasCuentaGastos.Activo = m_Activo;
			m_oldRutasCuentaGastos.Total = m_Total;
			m_oldRutasCuentaGastos.PadreCodigo = m_PadreCodigo;
		}

		public RutasCuentaGastos OldRutasCuentaGastos
		{
			get { return m_oldRutasCuentaGastos;}
		}
		// Return the changed fields
		public string[] FieldChanged()
		{
			List<string> fields=new List<string>();
			if (m_oldRutasCuentaGastos.Campo != m_Campo) fields.Add("Campo");
			if (m_oldRutasCuentaGastos.Cuenta1 != m_Cuenta1) fields.Add("Cuenta1");
			if (m_oldRutasCuentaGastos.NombreCuenta1 != m_NombreCuenta1) fields.Add("NombreCuenta1");
			if (m_oldRutasCuentaGastos.Nit2 != m_Nit2) fields.Add("Nit2");
			if (m_oldRutasCuentaGastos.NombreTercero2 != m_NombreTercero2) fields.Add("NombreTercero2");
			if (m_oldRutasCuentaGastos.Valor3 != m_Valor3) fields.Add("Valor3");
			if (m_oldRutasCuentaGastos.Cuenta4 != m_Cuenta4) fields.Add("Cuenta4");
			if (m_oldRutasCuentaGastos.NombreCuenta4 != m_NombreCuenta4) fields.Add("NombreCuenta4");
			if (m_oldRutasCuentaGastos.Cuenta5 != m_Cuenta5) fields.Add("Cuenta5");
			if (m_oldRutasCuentaGastos.NombreCuenta5 != m_NombreCuenta5) fields.Add("NombreCuenta5");
			if (m_oldRutasCuentaGastos.Nit6 != m_Nit6) fields.Add("Nit6");
			if (m_oldRutasCuentaGastos.NombreTercero6 != m_NombreTercero6) fields.Add("NombreTercero6");
			if (m_oldRutasCuentaGastos.Valor7 != m_Valor7) fields.Add("Valor7");
			if (m_oldRutasCuentaGastos.Cuenta8 != m_Cuenta8) fields.Add("Cuenta8");
			if (m_oldRutasCuentaGastos.NombreCuenta8 != m_NombreCuenta8) fields.Add("NombreCuenta8");
			if (m_oldRutasCuentaGastos.FechaCrea != m_FechaCrea) fields.Add("FechaCrea");
			if (m_oldRutasCuentaGastos.Activo != m_Activo) fields.Add("Activo");
			if (m_oldRutasCuentaGastos.Total != m_Total) fields.Add("Total");
			if (m_oldRutasCuentaGastos.PadreCodigo != m_PadreCodigo) fields.Add("PadreCodigo");
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


		// Field for storing the RutasCuentaGastos's Codigo value
		private long m_Codigo;

		// Field for storing the RutasCuentaGastos's Campo value
		private string m_Campo;

		// Field for storing the RutasCuentaGastos's Cuenta1 value
		private string m_Cuenta1;

		// Field for storing the RutasCuentaGastos's NombreCuenta1 value
		private string m_NombreCuenta1;

		// Field for storing the RutasCuentaGastos's Nit2 value
		private string m_Nit2;

		// Field for storing the RutasCuentaGastos's NombreTercero2 value
		private string m_NombreTercero2;

		// Field for storing the RutasCuentaGastos's Valor3 value
		private decimal? m_Valor3;

		// Field for storing the RutasCuentaGastos's Cuenta4 value
		private string m_Cuenta4;

		// Field for storing the RutasCuentaGastos's NombreCuenta4 value
		private string m_NombreCuenta4;

		// Field for storing the RutasCuentaGastos's Cuenta5 value
		private string m_Cuenta5;

		// Field for storing the RutasCuentaGastos's NombreCuenta5 value
		private string m_NombreCuenta5;

		// Field for storing the RutasCuentaGastos's Nit6 value
		private string m_Nit6;

		// Field for storing the RutasCuentaGastos's NombreTercero6 value
		private string m_NombreTercero6;

		// Field for storing the RutasCuentaGastos's Valor7 value
		private decimal? m_Valor7;

		// Field for storing the RutasCuentaGastos's Cuenta8 value
		private string m_Cuenta8;

		// Field for storing the RutasCuentaGastos's NombreCuenta8 value
		private string m_NombreCuenta8;

		// Field for storing the RutasCuentaGastos's FechaCrea value
		private DateTime? m_FechaCrea;

		// Field for storing the RutasCuentaGastos's Activo value
		private bool? m_Activo;

		// Field for storing the RutasCuentaGastos's Total value
		private bool? m_Total;

		// Field for storing the RutasCuentaGastos's PadreCodigo value
		private long? m_PadreCodigo;

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
		/// Attribute for access the RutasCuentaGastos's Codigo value (long)
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
		/// Attribute for access the RutasCuentaGastos's Campo value (string)
		/// </summary>
		[DataMember]
		public string Campo
		{
			get { return m_Campo; }
			set 
			{
				m_changed=true;
				m_Campo = value;
			}
		}

		/// <summary>
		/// Attribute for access the RutasCuentaGastos's Cuenta1 value (string)
		/// </summary>
		[DataMember]
		public string Cuenta1
		{
			get { return m_Cuenta1; }
			set 
			{
				m_changed=true;
				m_Cuenta1 = value;
			}
		}

		/// <summary>
		/// Attribute for access the RutasCuentaGastos's NombreCuenta1 value (string)
		/// </summary>
		[DataMember]
		public string NombreCuenta1
		{
			get { return m_NombreCuenta1; }
			set 
			{
				m_changed=true;
				m_NombreCuenta1 = value;
			}
		}

		/// <summary>
		/// Attribute for access the RutasCuentaGastos's Nit2 value (string)
		/// </summary>
		[DataMember]
		public string Nit2
		{
			get { return m_Nit2; }
			set 
			{
				m_changed=true;
				m_Nit2 = value;
			}
		}

		/// <summary>
		/// Attribute for access the RutasCuentaGastos's NombreTercero2 value (string)
		/// </summary>
		[DataMember]
		public string NombreTercero2
		{
			get { return m_NombreTercero2; }
			set 
			{
				m_changed=true;
				m_NombreTercero2 = value;
			}
		}

		/// <summary>
		/// Attribute for access the RutasCuentaGastos's Valor3 value (decimal)
		/// </summary>
		[DataMember]
		public decimal? Valor3
		{
			get { return m_Valor3; }
			set 
			{
				m_changed=true;
				m_Valor3 = value;
			}
		}

		/// <summary>
		/// Attribute for access the RutasCuentaGastos's Cuenta4 value (string)
		/// </summary>
		[DataMember]
		public string Cuenta4
		{
			get { return m_Cuenta4; }
			set 
			{
				m_changed=true;
				m_Cuenta4 = value;
			}
		}

		/// <summary>
		/// Attribute for access the RutasCuentaGastos's NombreCuenta4 value (string)
		/// </summary>
		[DataMember]
		public string NombreCuenta4
		{
			get { return m_NombreCuenta4; }
			set 
			{
				m_changed=true;
				m_NombreCuenta4 = value;
			}
		}

		/// <summary>
		/// Attribute for access the RutasCuentaGastos's Cuenta5 value (string)
		/// </summary>
		[DataMember]
		public string Cuenta5
		{
			get { return m_Cuenta5; }
			set 
			{
				m_changed=true;
				m_Cuenta5 = value;
			}
		}

		/// <summary>
		/// Attribute for access the RutasCuentaGastos's NombreCuenta5 value (string)
		/// </summary>
		[DataMember]
		public string NombreCuenta5
		{
			get { return m_NombreCuenta5; }
			set 
			{
				m_changed=true;
				m_NombreCuenta5 = value;
			}
		}

		/// <summary>
		/// Attribute for access the RutasCuentaGastos's Nit6 value (string)
		/// </summary>
		[DataMember]
		public string Nit6
		{
			get { return m_Nit6; }
			set 
			{
				m_changed=true;
				m_Nit6 = value;
			}
		}

		/// <summary>
		/// Attribute for access the RutasCuentaGastos's NombreTercero6 value (string)
		/// </summary>
		[DataMember]
		public string NombreTercero6
		{
			get { return m_NombreTercero6; }
			set 
			{
				m_changed=true;
				m_NombreTercero6 = value;
			}
		}

		/// <summary>
		/// Attribute for access the RutasCuentaGastos's Valor7 value (decimal)
		/// </summary>
		[DataMember]
		public decimal? Valor7
		{
			get { return m_Valor7; }
			set 
			{
				m_changed=true;
				m_Valor7 = value;
			}
		}

		/// <summary>
		/// Attribute for access the RutasCuentaGastos's Cuenta8 value (string)
		/// </summary>
		[DataMember]
		public string Cuenta8
		{
			get { return m_Cuenta8; }
			set 
			{
				m_changed=true;
				m_Cuenta8 = value;
			}
		}

		/// <summary>
		/// Attribute for access the RutasCuentaGastos's NombreCuenta8 value (string)
		/// </summary>
		[DataMember]
		public string NombreCuenta8
		{
			get { return m_NombreCuenta8; }
			set 
			{
				m_changed=true;
				m_NombreCuenta8 = value;
			}
		}

		/// <summary>
		/// Attribute for access the RutasCuentaGastos's FechaCrea value (DateTime)
		/// </summary>
		[DataMember]
		public DateTime? FechaCrea
		{
			get { return m_FechaCrea; }
			set 
			{
				m_changed=true;
				m_FechaCrea = value;
			}
		}

		/// <summary>
		/// Attribute for access the RutasCuentaGastos's Activo value (bool)
		/// </summary>
		[DataMember]
		public bool? Activo
		{
			get { return m_Activo; }
			set 
			{
				m_changed=true;
				m_Activo = value;
			}
		}

		/// <summary>
		/// Attribute for access the RutasCuentaGastos's Total value (bool)
		/// </summary>
		[DataMember]
		public bool? Total
		{
			get { return m_Total; }
			set 
			{
				m_changed=true;
				m_Total = value;
			}
		}

		/// <summary>
		/// Attribute for access the RutasCuentaGastos's PadreCodigo value (long)
		/// </summary>
		[DataMember]
		public long? PadreCodigo
		{
			get { return m_PadreCodigo; }
			set 
			{
				m_changed=true;
				m_PadreCodigo = value;
			}
		}

		public object GetAttribute(string pattribute)
		{
			switch (pattribute)
			{
				case "Codigo": return Codigo;
				case "Campo": return Campo;
				case "Cuenta1": return Cuenta1;
				case "NombreCuenta1": return NombreCuenta1;
				case "Nit2": return Nit2;
				case "NombreTercero2": return NombreTercero2;
				case "Valor3": return Valor3;
				case "Cuenta4": return Cuenta4;
				case "NombreCuenta4": return NombreCuenta4;
				case "Cuenta5": return Cuenta5;
				case "NombreCuenta5": return NombreCuenta5;
				case "Nit6": return Nit6;
				case "NombreTercero6": return NombreTercero6;
				case "Valor7": return Valor7;
				case "Cuenta8": return Cuenta8;
				case "NombreCuenta8": return NombreCuenta8;
				case "FechaCrea": return FechaCrea;
				case "Activo": return Activo;
				case "Total": return Total;
				case "PadreCodigo": return PadreCodigo;
				default: return null;
			}
		}

		public Type GetAttributeType(string pattribute)
		{
			return RutasCuentaGastosController.Instance.GetMethodType(pattribute, this);
		}

		public string GetSqlKey()
		{
			return "[Codigo] = " + Codigo.ToString();
		}
		#endregion

	}

	#endregion

	#region RutasCuentaGastosList object

	/// <summary>
	/// Class for reading and access a list of RutasCuentaGastos object
	/// </summary>
	[CollectionDataContract]
	public partial class RutasCuentaGastosList : List<RutasCuentaGastos>
	{

		/// <summary>
		/// Default constructor
		/// </summary>
		public RutasCuentaGastosList()
		{
		}
	}

	#endregion

}
