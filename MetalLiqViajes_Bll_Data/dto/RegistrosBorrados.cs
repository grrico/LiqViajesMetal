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
	#region RegistrosBorrados object

	[DataContract]
	public partial class RegistrosBorrados : IDTOObject
	{
		/// <summary>
		/// Default constructor
		/// </summary>
		public RegistrosBorrados()
		{
			m_lngIdRegistroViaje = 0;
			m_lngIdRegistroViajeTramo = null;
			m_lngIdRegistrRuta = null;
			m_strRutaAnticipo = "";
			m_intNitConductor = null;
			m_strConductor = null;
			m_strPlaca = "";
			m_lngIdBanco = null;
			m_intDocumento = null;
			m_strCuenta = null;
			m_curDebito = null;
			m_curCredito = null;
			m_curSaldo = null;
			m_dtmFechaModif = null;
			m_strObservaciones = null;
			m_intCantidad = null;
			m_logAnulado = false;
			m_changed=false;
		}
		        //Return the table name of object
		        public string TableName()
		        {
		            return "tblRegistrosBorrados";
		        }
		#region Undo 
		// Internal class for storing changes
		private RegistrosBorrados m_oldRegistrosBorrados;
		public void GenerateUndo()
		{
			m_oldRegistrosBorrados=new RegistrosBorrados();
			m_oldRegistrosBorrados.m_lngIdRegistroViaje = m_lngIdRegistroViaje;
			m_oldRegistrosBorrados.lngIdRegistroViajeTramo = m_lngIdRegistroViajeTramo;
			m_oldRegistrosBorrados.lngIdRegistrRuta = m_lngIdRegistrRuta;
			m_oldRegistrosBorrados.strRutaAnticipo = m_strRutaAnticipo;
			m_oldRegistrosBorrados.intNitConductor = m_intNitConductor;
			m_oldRegistrosBorrados.strConductor = m_strConductor;
			m_oldRegistrosBorrados.strPlaca = m_strPlaca;
			m_oldRegistrosBorrados.lngIdBanco = m_lngIdBanco;
			m_oldRegistrosBorrados.intDocumento = m_intDocumento;
			m_oldRegistrosBorrados.strCuenta = m_strCuenta;
			m_oldRegistrosBorrados.curDebito = m_curDebito;
			m_oldRegistrosBorrados.curCredito = m_curCredito;
			m_oldRegistrosBorrados.curSaldo = m_curSaldo;
			m_oldRegistrosBorrados.dtmFechaModif = m_dtmFechaModif;
			m_oldRegistrosBorrados.strObservaciones = m_strObservaciones;
			m_oldRegistrosBorrados.intCantidad = m_intCantidad;
			m_oldRegistrosBorrados.logAnulado = m_logAnulado;
		}

		public RegistrosBorrados OldRegistrosBorrados
		{
			get { return m_oldRegistrosBorrados;}
		}
		// Return the changed fields
		public string[] FieldChanged()
		{
			List<string> fields=new List<string>();
			if (m_oldRegistrosBorrados.lngIdRegistroViajeTramo != m_lngIdRegistroViajeTramo) fields.Add("lngIdRegistroViajeTramo");
			if (m_oldRegistrosBorrados.lngIdRegistrRuta != m_lngIdRegistrRuta) fields.Add("lngIdRegistrRuta");
			if (m_oldRegistrosBorrados.strRutaAnticipo != m_strRutaAnticipo) fields.Add("strRutaAnticipo");
			if (m_oldRegistrosBorrados.intNitConductor != m_intNitConductor) fields.Add("intNitConductor");
			if (m_oldRegistrosBorrados.strConductor != m_strConductor) fields.Add("strConductor");
			if (m_oldRegistrosBorrados.strPlaca != m_strPlaca) fields.Add("strPlaca");
			if (m_oldRegistrosBorrados.lngIdBanco != m_lngIdBanco) fields.Add("lngIdBanco");
			if (m_oldRegistrosBorrados.intDocumento != m_intDocumento) fields.Add("intDocumento");
			if (m_oldRegistrosBorrados.strCuenta != m_strCuenta) fields.Add("strCuenta");
			if (m_oldRegistrosBorrados.curDebito != m_curDebito) fields.Add("curDebito");
			if (m_oldRegistrosBorrados.curCredito != m_curCredito) fields.Add("curCredito");
			if (m_oldRegistrosBorrados.curSaldo != m_curSaldo) fields.Add("curSaldo");
			if (m_oldRegistrosBorrados.dtmFechaModif != m_dtmFechaModif) fields.Add("dtmFechaModif");
			if (m_oldRegistrosBorrados.strObservaciones != m_strObservaciones) fields.Add("strObservaciones");
			if (m_oldRegistrosBorrados.intCantidad != m_intCantidad) fields.Add("intCantidad");
			if (m_oldRegistrosBorrados.logAnulado != m_logAnulado) fields.Add("logAnulado");
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


		// Field for storing the RegistrosBorrados's lngIdRegistroViajeTramo value
		private int? m_lngIdRegistroViajeTramo;

		// Field for storing the RegistrosBorrados's lngIdRegistrRuta value
		private int? m_lngIdRegistrRuta;

		// Field for storing the RegistrosBorrados's strRutaAnticipo value
		private string m_strRutaAnticipo;

		// Field for storing the RegistrosBorrados's intNitConductor value
		private double? m_intNitConductor;

		// Field for storing the RegistrosBorrados's strConductor value
		private string m_strConductor;

		// Field for storing the RegistrosBorrados's strPlaca value
		private string m_strPlaca;

		// Field for storing the RegistrosBorrados's lngIdBanco value
		private int? m_lngIdBanco;

		// Field for storing the RegistrosBorrados's intDocumento value
		private int? m_intDocumento;

		// Field for storing the RegistrosBorrados's strCuenta value
		private string m_strCuenta;

		// Field for storing the RegistrosBorrados's curDebito value
		private decimal? m_curDebito;

		// Field for storing the RegistrosBorrados's curCredito value
		private decimal? m_curCredito;

		// Field for storing the RegistrosBorrados's curSaldo value
		private decimal? m_curSaldo;

		// Field for storing the RegistrosBorrados's dtmFechaModif value
		private DateTime? m_dtmFechaModif;

		// Field for storing the RegistrosBorrados's strObservaciones value
		private string m_strObservaciones;

		// Field for storing the RegistrosBorrados's intCantidad value
		private int? m_intCantidad;

		// Field for storing the RegistrosBorrados's logAnulado value
		private bool? m_logAnulado;

		// Field for storing the RegistrosBorrados's lngIdRegistroViaje value
		private int m_lngIdRegistroViaje;

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
		/// Attribute for access the RegistrosBorrados's lngIdRegistroViajeTramo value (int)
		/// </summary>
		[DataMember]
		public int? lngIdRegistroViajeTramo
		{
			get { return m_lngIdRegistroViajeTramo; }
			set 
			{
				m_changed=true;
				m_lngIdRegistroViajeTramo = value;
			}
		}

		/// <summary>
		/// Attribute for access the RegistrosBorrados's lngIdRegistrRuta value (int)
		/// </summary>
		[DataMember]
		public int? lngIdRegistrRuta
		{
			get { return m_lngIdRegistrRuta; }
			set 
			{
				m_changed=true;
				m_lngIdRegistrRuta = value;
			}
		}

		/// <summary>
		/// Attribute for access the RegistrosBorrados's strRutaAnticipo value (string)
		/// </summary>
		[DataMember]
		public string strRutaAnticipo
		{
			get { return m_strRutaAnticipo; }
			set 
			{
				m_changed=true;
				m_strRutaAnticipo = value;
			}
		}

		/// <summary>
		/// Attribute for access the RegistrosBorrados's intNitConductor value (double)
		/// </summary>
		[DataMember]
		public double? intNitConductor
		{
			get { return m_intNitConductor; }
			set 
			{
				m_changed=true;
				m_intNitConductor = value;
			}
		}

		/// <summary>
		/// Attribute for access the RegistrosBorrados's strConductor value (string)
		/// </summary>
		[DataMember]
		public string strConductor
		{
			get { return m_strConductor; }
			set 
			{
				m_changed=true;
				m_strConductor = value;
			}
		}

		/// <summary>
		/// Attribute for access the RegistrosBorrados's strPlaca value (string)
		/// </summary>
		[DataMember]
		public string strPlaca
		{
			get { return m_strPlaca; }
			set 
			{
				m_changed=true;
				m_strPlaca = value;
			}
		}

		/// <summary>
		/// Attribute for access the RegistrosBorrados's lngIdBanco value (int)
		/// </summary>
		[DataMember]
		public int? lngIdBanco
		{
			get { return m_lngIdBanco; }
			set 
			{
				m_changed=true;
				m_lngIdBanco = value;
			}
		}

		/// <summary>
		/// Attribute for access the RegistrosBorrados's intDocumento value (int)
		/// </summary>
		[DataMember]
		public int? intDocumento
		{
			get { return m_intDocumento; }
			set 
			{
				m_changed=true;
				m_intDocumento = value;
			}
		}

		/// <summary>
		/// Attribute for access the RegistrosBorrados's strCuenta value (string)
		/// </summary>
		[DataMember]
		public string strCuenta
		{
			get { return m_strCuenta; }
			set 
			{
				m_changed=true;
				m_strCuenta = value;
			}
		}

		/// <summary>
		/// Attribute for access the RegistrosBorrados's curDebito value (decimal)
		/// </summary>
		[DataMember]
		public decimal? curDebito
		{
			get { return m_curDebito; }
			set 
			{
				m_changed=true;
				m_curDebito = value;
			}
		}

		/// <summary>
		/// Attribute for access the RegistrosBorrados's curCredito value (decimal)
		/// </summary>
		[DataMember]
		public decimal? curCredito
		{
			get { return m_curCredito; }
			set 
			{
				m_changed=true;
				m_curCredito = value;
			}
		}

		/// <summary>
		/// Attribute for access the RegistrosBorrados's curSaldo value (decimal)
		/// </summary>
		[DataMember]
		public decimal? curSaldo
		{
			get { return m_curSaldo; }
			set 
			{
				m_changed=true;
				m_curSaldo = value;
			}
		}

		/// <summary>
		/// Attribute for access the RegistrosBorrados's dtmFechaModif value (DateTime)
		/// </summary>
		[DataMember]
		public DateTime? dtmFechaModif
		{
			get { return m_dtmFechaModif; }
			set 
			{
				m_changed=true;
				m_dtmFechaModif = value;
			}
		}

		/// <summary>
		/// Attribute for access the RegistrosBorrados's strObservaciones value (string)
		/// </summary>
		[DataMember]
		public string strObservaciones
		{
			get { return m_strObservaciones; }
			set 
			{
				m_changed=true;
				m_strObservaciones = value;
			}
		}

		/// <summary>
		/// Attribute for access the RegistrosBorrados's intCantidad value (int)
		/// </summary>
		[DataMember]
		public int? intCantidad
		{
			get { return m_intCantidad; }
			set 
			{
				m_changed=true;
				m_intCantidad = value;
			}
		}

		/// <summary>
		/// Attribute for access the RegistrosBorrados's logAnulado value (bool)
		/// </summary>
		[DataMember]
		public bool? logAnulado
		{
			get { return m_logAnulado; }
			set 
			{
				m_changed=true;
				m_logAnulado = value;
			}
		}

		/// <summary>
		/// Attribute for access the RegistrosBorrados's lngIdRegistroViaje value (int)
		/// </summary>
		[DataMember]
		public int lngIdRegistroViaje
		{
			get { return m_lngIdRegistroViaje; }
			set 
			{
				m_changed=true;
				m_lngIdRegistroViaje = value;
			}
		}

		public object GetAttribute(string pattribute)
		{
			switch (pattribute)
			{
				case "lngIdRegistroViajeTramo": return lngIdRegistroViajeTramo;
				case "lngIdRegistrRuta": return lngIdRegistrRuta;
				case "strRutaAnticipo": return strRutaAnticipo;
				case "intNitConductor": return intNitConductor;
				case "strConductor": return strConductor;
				case "strPlaca": return strPlaca;
				case "lngIdBanco": return lngIdBanco;
				case "intDocumento": return intDocumento;
				case "strCuenta": return strCuenta;
				case "curDebito": return curDebito;
				case "curCredito": return curCredito;
				case "curSaldo": return curSaldo;
				case "dtmFechaModif": return dtmFechaModif;
				case "strObservaciones": return strObservaciones;
				case "intCantidad": return intCantidad;
				case "logAnulado": return logAnulado;
				case "lngIdRegistroViaje": return lngIdRegistroViaje;
				default: return null;
			}
		}

		public Type GetAttributeType(string pattribute)
		{
			return RegistrosBorradosController.Instance.GetMethodType(pattribute, this);
		}

		public string GetSqlKey()
		{
			return "[lngIdRegistroViaje] = " + lngIdRegistroViaje.ToString();
		}
		#endregion

	}

	#endregion

	#region RegistrosBorradosList object

	/// <summary>
	/// Class for reading and access a list of RegistrosBorrados object
	/// </summary>
	[CollectionDataContract]
	public partial class RegistrosBorradosList : List<RegistrosBorrados>
	{

		/// <summary>
		/// Default constructor
		/// </summary>
		public RegistrosBorradosList()
		{
		}
	}

	#endregion

}
