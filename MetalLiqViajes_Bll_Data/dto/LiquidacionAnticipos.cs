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
	#region LiquidacionAnticipos object

	[DataContract]
	public partial class LiquidacionAnticipos : IDTOObject
	{
		/// <summary>
		/// Default constructor
		/// </summary>
		public LiquidacionAnticipos()
		{
			m_lngIdRegistroViaje = 0;
			m_lngIdRegistroViajeTramo = 0;
			m_intNitConductor = 0;
			m_strPlaca = "";
			m_lngIdBanco = 0;
			m_intDocumento = 0;
			m_strModelo = "";
			m_strtipo = "";
			m_strConductor = null;
			m_dtmFechaMovimiento = null;
			m_strdescripcionBanco = null;
			m_sw = (byte)0;
			m_dtmFechaMovDMS = null;
			m_strCuenta = null;
			m_strCuenta2 = null;
			m_strdescripcionCuenta = null;
			m_strdescripcionCuenta2 = null;
			m_curValor = null;
			m_strdescripcionModelo = null;
			m_strNota = null;
			m_strdocumento = null;
			m_strUsuarioDMS = null;
			m_dtmfechahoraSYSDMS = null;
			m_intUsuario = null;
			m_dtmFechaModif = null;
			m_logAnulado = false;
			m_logLiquidado = false;
			m_changed=false;
		}
		        //Return the table name of object
		        public string TableName()
		        {
		            return "tblLiquidacionAnticipos";
		        }
		#region Undo 
		// Internal class for storing changes
		private LiquidacionAnticipos m_oldLiquidacionAnticipos;
		public void GenerateUndo()
		{
			m_oldLiquidacionAnticipos=new LiquidacionAnticipos();
			m_oldLiquidacionAnticipos.m_lngIdRegistroViaje = m_lngIdRegistroViaje;
			m_oldLiquidacionAnticipos.m_lngIdRegistroViajeTramo = m_lngIdRegistroViajeTramo;
			m_oldLiquidacionAnticipos.m_intNitConductor = m_intNitConductor;
			m_oldLiquidacionAnticipos.m_strPlaca = m_strPlaca;
			m_oldLiquidacionAnticipos.m_lngIdBanco = m_lngIdBanco;
			m_oldLiquidacionAnticipos.m_intDocumento = m_intDocumento;
			m_oldLiquidacionAnticipos.m_strModelo = m_strModelo;
			m_oldLiquidacionAnticipos.m_strtipo = m_strtipo;
			m_oldLiquidacionAnticipos.strConductor = m_strConductor;
			m_oldLiquidacionAnticipos.dtmFechaMovimiento = m_dtmFechaMovimiento;
			m_oldLiquidacionAnticipos.strdescripcionBanco = m_strdescripcionBanco;
			m_oldLiquidacionAnticipos.sw = m_sw;
			m_oldLiquidacionAnticipos.dtmFechaMovDMS = m_dtmFechaMovDMS;
			m_oldLiquidacionAnticipos.strCuenta = m_strCuenta;
			m_oldLiquidacionAnticipos.strCuenta2 = m_strCuenta2;
			m_oldLiquidacionAnticipos.strdescripcionCuenta = m_strdescripcionCuenta;
			m_oldLiquidacionAnticipos.strdescripcionCuenta2 = m_strdescripcionCuenta2;
			m_oldLiquidacionAnticipos.curValor = m_curValor;
			m_oldLiquidacionAnticipos.strdescripcionModelo = m_strdescripcionModelo;
			m_oldLiquidacionAnticipos.strNota = m_strNota;
			m_oldLiquidacionAnticipos.strdocumento = m_strdocumento;
			m_oldLiquidacionAnticipos.strUsuarioDMS = m_strUsuarioDMS;
			m_oldLiquidacionAnticipos.dtmfechahoraSYSDMS = m_dtmfechahoraSYSDMS;
			m_oldLiquidacionAnticipos.intUsuario = m_intUsuario;
			m_oldLiquidacionAnticipos.dtmFechaModif = m_dtmFechaModif;
			m_oldLiquidacionAnticipos.logAnulado = m_logAnulado;
			m_oldLiquidacionAnticipos.logLiquidado = m_logLiquidado;
		}

		public LiquidacionAnticipos OldLiquidacionAnticipos
		{
			get { return m_oldLiquidacionAnticipos;}
		}
		// Return the changed fields
		public string[] FieldChanged()
		{
			List<string> fields=new List<string>();
			if (m_oldLiquidacionAnticipos.strConductor != m_strConductor) fields.Add("strConductor");
			if (m_oldLiquidacionAnticipos.dtmFechaMovimiento != m_dtmFechaMovimiento) fields.Add("dtmFechaMovimiento");
			if (m_oldLiquidacionAnticipos.strdescripcionBanco != m_strdescripcionBanco) fields.Add("strdescripcionBanco");
			if (m_oldLiquidacionAnticipos.sw != m_sw) fields.Add("sw");
			if (m_oldLiquidacionAnticipos.dtmFechaMovDMS != m_dtmFechaMovDMS) fields.Add("dtmFechaMovDMS");
			if (m_oldLiquidacionAnticipos.strCuenta != m_strCuenta) fields.Add("strCuenta");
			if (m_oldLiquidacionAnticipos.strCuenta2 != m_strCuenta2) fields.Add("strCuenta2");
			if (m_oldLiquidacionAnticipos.strdescripcionCuenta != m_strdescripcionCuenta) fields.Add("strdescripcionCuenta");
			if (m_oldLiquidacionAnticipos.strdescripcionCuenta2 != m_strdescripcionCuenta2) fields.Add("strdescripcionCuenta2");
			if (m_oldLiquidacionAnticipos.curValor != m_curValor) fields.Add("curValor");
			if (m_oldLiquidacionAnticipos.strdescripcionModelo != m_strdescripcionModelo) fields.Add("strdescripcionModelo");
			if (m_oldLiquidacionAnticipos.strNota != m_strNota) fields.Add("strNota");
			if (m_oldLiquidacionAnticipos.strdocumento != m_strdocumento) fields.Add("strdocumento");
			if (m_oldLiquidacionAnticipos.strUsuarioDMS != m_strUsuarioDMS) fields.Add("strUsuarioDMS");
			if (m_oldLiquidacionAnticipos.dtmfechahoraSYSDMS != m_dtmfechahoraSYSDMS) fields.Add("dtmfechahoraSYSDMS");
			if (m_oldLiquidacionAnticipos.intUsuario != m_intUsuario) fields.Add("intUsuario");
			if (m_oldLiquidacionAnticipos.dtmFechaModif != m_dtmFechaModif) fields.Add("dtmFechaModif");
			if (m_oldLiquidacionAnticipos.logAnulado != m_logAnulado) fields.Add("logAnulado");
			if (m_oldLiquidacionAnticipos.logLiquidado != m_logLiquidado) fields.Add("logLiquidado");
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


		// Field for storing the LiquidacionAnticipos's strConductor value
		private string m_strConductor;

		// Field for storing the LiquidacionAnticipos's dtmFechaMovimiento value
		private DateTime? m_dtmFechaMovimiento;

		// Field for storing the LiquidacionAnticipos's strdescripcionBanco value
		private string m_strdescripcionBanco;

		// Field for storing the LiquidacionAnticipos's sw value
		private byte? m_sw;

		// Field for storing the LiquidacionAnticipos's dtmFechaMovDMS value
		private DateTime? m_dtmFechaMovDMS;

		// Field for storing the LiquidacionAnticipos's strCuenta value
		private string m_strCuenta;

		// Field for storing the LiquidacionAnticipos's strCuenta2 value
		private string m_strCuenta2;

		// Field for storing the LiquidacionAnticipos's strdescripcionCuenta value
		private string m_strdescripcionCuenta;

		// Field for storing the LiquidacionAnticipos's strdescripcionCuenta2 value
		private string m_strdescripcionCuenta2;

		// Field for storing the LiquidacionAnticipos's curValor value
		private decimal? m_curValor;

		// Field for storing the LiquidacionAnticipos's strdescripcionModelo value
		private string m_strdescripcionModelo;

		// Field for storing the LiquidacionAnticipos's strNota value
		private string m_strNota;

		// Field for storing the LiquidacionAnticipos's strdocumento value
		private string m_strdocumento;

		// Field for storing the LiquidacionAnticipos's strUsuarioDMS value
		private string m_strUsuarioDMS;

		// Field for storing the LiquidacionAnticipos's dtmfechahoraSYSDMS value
		private DateTime? m_dtmfechahoraSYSDMS;

		// Field for storing the LiquidacionAnticipos's intUsuario value
		private int? m_intUsuario;

		// Field for storing the LiquidacionAnticipos's dtmFechaModif value
		private DateTime? m_dtmFechaModif;

		// Field for storing the LiquidacionAnticipos's logAnulado value
		private bool? m_logAnulado;

		// Field for storing the LiquidacionAnticipos's logLiquidado value
		private bool? m_logLiquidado;

		// Field for storing the LiquidacionAnticipos's lngIdRegistroViaje value
		private int m_lngIdRegistroViaje;

		// Field for storing the LiquidacionAnticipos's lngIdRegistroViajeTramo value
		private decimal m_lngIdRegistroViajeTramo;

		// Field for storing the LiquidacionAnticipos's intNitConductor value
		private decimal m_intNitConductor;

		// Field for storing the LiquidacionAnticipos's strPlaca value
		private string m_strPlaca;

		// Field for storing the LiquidacionAnticipos's lngIdBanco value
		private double m_lngIdBanco;

		// Field for storing the LiquidacionAnticipos's intDocumento value
		private int m_intDocumento;

		// Field for storing the LiquidacionAnticipos's strModelo value
		private string m_strModelo;

		// Field for storing the LiquidacionAnticipos's strtipo value
		private string m_strtipo;

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
		/// Attribute for access the LiquidacionAnticipos's strConductor value (string)
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
		/// Attribute for access the LiquidacionAnticipos's dtmFechaMovimiento value (DateTime)
		/// </summary>
		[DataMember]
		public DateTime? dtmFechaMovimiento
		{
			get { return m_dtmFechaMovimiento; }
			set 
			{
				m_changed=true;
				m_dtmFechaMovimiento = value;
			}
		}

		/// <summary>
		/// Attribute for access the LiquidacionAnticipos's strdescripcionBanco value (string)
		/// </summary>
		[DataMember]
		public string strdescripcionBanco
		{
			get { return m_strdescripcionBanco; }
			set 
			{
				m_changed=true;
				m_strdescripcionBanco = value;
			}
		}

		/// <summary>
		/// Attribute for access the LiquidacionAnticipos's sw value (byte)
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
		/// Attribute for access the LiquidacionAnticipos's dtmFechaMovDMS value (DateTime)
		/// </summary>
		[DataMember]
		public DateTime? dtmFechaMovDMS
		{
			get { return m_dtmFechaMovDMS; }
			set 
			{
				m_changed=true;
				m_dtmFechaMovDMS = value;
			}
		}

		/// <summary>
		/// Attribute for access the LiquidacionAnticipos's strCuenta value (string)
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
		/// Attribute for access the LiquidacionAnticipos's strCuenta2 value (string)
		/// </summary>
		[DataMember]
		public string strCuenta2
		{
			get { return m_strCuenta2; }
			set 
			{
				m_changed=true;
				m_strCuenta2 = value;
			}
		}

		/// <summary>
		/// Attribute for access the LiquidacionAnticipos's strdescripcionCuenta value (string)
		/// </summary>
		[DataMember]
		public string strdescripcionCuenta
		{
			get { return m_strdescripcionCuenta; }
			set 
			{
				m_changed=true;
				m_strdescripcionCuenta = value;
			}
		}

		/// <summary>
		/// Attribute for access the LiquidacionAnticipos's strdescripcionCuenta2 value (string)
		/// </summary>
		[DataMember]
		public string strdescripcionCuenta2
		{
			get { return m_strdescripcionCuenta2; }
			set 
			{
				m_changed=true;
				m_strdescripcionCuenta2 = value;
			}
		}

		/// <summary>
		/// Attribute for access the LiquidacionAnticipos's curValor value (decimal)
		/// </summary>
		[DataMember]
		public decimal? curValor
		{
			get { return m_curValor; }
			set 
			{
				m_changed=true;
				m_curValor = value;
			}
		}

		/// <summary>
		/// Attribute for access the LiquidacionAnticipos's strdescripcionModelo value (string)
		/// </summary>
		[DataMember]
		public string strdescripcionModelo
		{
			get { return m_strdescripcionModelo; }
			set 
			{
				m_changed=true;
				m_strdescripcionModelo = value;
			}
		}

		/// <summary>
		/// Attribute for access the LiquidacionAnticipos's strNota value (string)
		/// </summary>
		[DataMember]
		public string strNota
		{
			get { return m_strNota; }
			set 
			{
				m_changed=true;
				m_strNota = value;
			}
		}

		/// <summary>
		/// Attribute for access the LiquidacionAnticipos's strdocumento value (string)
		/// </summary>
		[DataMember]
		public string strdocumento
		{
			get { return m_strdocumento; }
			set 
			{
				m_changed=true;
				m_strdocumento = value;
			}
		}

		/// <summary>
		/// Attribute for access the LiquidacionAnticipos's strUsuarioDMS value (string)
		/// </summary>
		[DataMember]
		public string strUsuarioDMS
		{
			get { return m_strUsuarioDMS; }
			set 
			{
				m_changed=true;
				m_strUsuarioDMS = value;
			}
		}

		/// <summary>
		/// Attribute for access the LiquidacionAnticipos's dtmfechahoraSYSDMS value (DateTime)
		/// </summary>
		[DataMember]
		public DateTime? dtmfechahoraSYSDMS
		{
			get { return m_dtmfechahoraSYSDMS; }
			set 
			{
				m_changed=true;
				m_dtmfechahoraSYSDMS = value;
			}
		}

		/// <summary>
		/// Attribute for access the LiquidacionAnticipos's intUsuario value (int)
		/// </summary>
		[DataMember]
		public int? intUsuario
		{
			get { return m_intUsuario; }
			set 
			{
				m_changed=true;
				m_intUsuario = value;
			}
		}

		/// <summary>
		/// Attribute for access the LiquidacionAnticipos's dtmFechaModif value (DateTime)
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
		/// Attribute for access the LiquidacionAnticipos's logAnulado value (bool)
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
		/// Attribute for access the LiquidacionAnticipos's logLiquidado value (bool)
		/// </summary>
		[DataMember]
		public bool? logLiquidado
		{
			get { return m_logLiquidado; }
			set 
			{
				m_changed=true;
				m_logLiquidado = value;
			}
		}

		/// <summary>
		/// Attribute for access the LiquidacionAnticipos's lngIdRegistroViaje value (int)
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

		/// <summary>
		/// Attribute for access the LiquidacionAnticipos's lngIdRegistroViajeTramo value (decimal)
		/// </summary>
		[DataMember]
		public decimal lngIdRegistroViajeTramo
		{
			get { return m_lngIdRegistroViajeTramo; }
			set 
			{
				m_changed=true;
				m_lngIdRegistroViajeTramo = value;
			}
		}

		/// <summary>
		/// Attribute for access the LiquidacionAnticipos's intNitConductor value (decimal)
		/// </summary>
		[DataMember]
		public decimal intNitConductor
		{
			get { return m_intNitConductor; }
			set 
			{
				m_changed=true;
				m_intNitConductor = value;
			}
		}

		/// <summary>
		/// Attribute for access the LiquidacionAnticipos's strPlaca value (string)
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
		/// Attribute for access the LiquidacionAnticipos's lngIdBanco value (double)
		/// </summary>
		[DataMember]
		public double lngIdBanco
		{
			get { return m_lngIdBanco; }
			set 
			{
				m_changed=true;
				m_lngIdBanco = value;
			}
		}

		/// <summary>
		/// Attribute for access the LiquidacionAnticipos's intDocumento value (int)
		/// </summary>
		[DataMember]
		public int intDocumento
		{
			get { return m_intDocumento; }
			set 
			{
				m_changed=true;
				m_intDocumento = value;
			}
		}

		/// <summary>
		/// Attribute for access the LiquidacionAnticipos's strModelo value (string)
		/// </summary>
		[DataMember]
		public string strModelo
		{
			get { return m_strModelo; }
			set 
			{
				m_changed=true;
				m_strModelo = value;
			}
		}

		/// <summary>
		/// Attribute for access the LiquidacionAnticipos's strtipo value (string)
		/// </summary>
		[DataMember]
		public string strtipo
		{
			get { return m_strtipo; }
			set 
			{
				m_changed=true;
				m_strtipo = value;
			}
		}

		public object GetAttribute(string pattribute)
		{
			switch (pattribute)
			{
				case "strConductor": return strConductor;
				case "dtmFechaMovimiento": return dtmFechaMovimiento;
				case "strdescripcionBanco": return strdescripcionBanco;
				case "sw": return sw;
				case "dtmFechaMovDMS": return dtmFechaMovDMS;
				case "strCuenta": return strCuenta;
				case "strCuenta2": return strCuenta2;
				case "strdescripcionCuenta": return strdescripcionCuenta;
				case "strdescripcionCuenta2": return strdescripcionCuenta2;
				case "curValor": return curValor;
				case "strdescripcionModelo": return strdescripcionModelo;
				case "strNota": return strNota;
				case "strdocumento": return strdocumento;
				case "strUsuarioDMS": return strUsuarioDMS;
				case "dtmfechahoraSYSDMS": return dtmfechahoraSYSDMS;
				case "intUsuario": return intUsuario;
				case "dtmFechaModif": return dtmFechaModif;
				case "logAnulado": return logAnulado;
				case "logLiquidado": return logLiquidado;
				case "lngIdRegistroViaje": return lngIdRegistroViaje;
				case "lngIdRegistroViajeTramo": return lngIdRegistroViajeTramo;
				case "intNitConductor": return intNitConductor;
				case "strPlaca": return strPlaca;
				case "lngIdBanco": return lngIdBanco;
				case "intDocumento": return intDocumento;
				case "strModelo": return strModelo;
				case "strtipo": return strtipo;
				default: return null;
			}
		}

		public Type GetAttributeType(string pattribute)
		{
			return LiquidacionAnticiposController.Instance.GetMethodType(pattribute, this);
		}

		public string GetSqlKey()
		{
			return "[lngIdRegistroViaje] = " + lngIdRegistroViaje.ToString() + " AND [lngIdRegistroViajeTramo] = " + lngIdRegistroViajeTramo.ToString() + " AND [intNitConductor] = " + intNitConductor.ToString() + " AND [strPlaca] = '" + strPlaca.ToString()+ "'" + " AND [lngIdBanco] = " + lngIdBanco.ToString() + " AND [intDocumento] = " + intDocumento.ToString() + " AND [strModelo] = '" + strModelo.ToString()+ "'" + " AND [strtipo] = '" + strtipo.ToString()+ "'";
		}
		#endregion

	}

	#endregion

	#region LiquidacionAnticiposList object

	/// <summary>
	/// Class for reading and access a list of LiquidacionAnticipos object
	/// </summary>
	[CollectionDataContract]
	public partial class LiquidacionAnticiposList : List<LiquidacionAnticipos>
	{

		/// <summary>
		/// Default constructor
		/// </summary>
		public LiquidacionAnticiposList()
		{
		}
	}

	#endregion

}
