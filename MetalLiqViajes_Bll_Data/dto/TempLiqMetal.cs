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
	#region TempLiqMetal object

	[DataContract]
	public partial class TempLiqMetal : IDTOObject
	{
		/// <summary>
		/// Default constructor
		/// </summary>
		public TempLiqMetal()
		{
			m_strPlaca = "";
			m_strCuenta = ' ';
			m_strDescripcion = ' ';
			m_intDocumento = null;
			m_lngIdRegistroViaje = null;
			m_dtmFechaAsignacion = null;
			m_curValorDebito = null;
			m_curValorCredito = null;
			m_logLiquidado = false;
			m_nitTercero = ' ';
			m_strObservaciones = null;
			m_lngIdUsuario = null;
			m_dtmFechaModif = null;
			m_LogAnticipo = false;
			m_intNitConductor = null;
			m_strConductor = null;
			m_changed=false;
		}
		        //Return the table name of object
		        public string TableName()
		        {
		            return "tblTempLiqMetal";
		        }
		#region Undo 
		// Internal class for storing changes
		private TempLiqMetal m_oldTempLiqMetal;
		public void GenerateUndo()
		{
			m_oldTempLiqMetal=new TempLiqMetal();
			m_oldTempLiqMetal.strPlaca = m_strPlaca;
			m_oldTempLiqMetal.strCuenta = m_strCuenta;
			m_oldTempLiqMetal.strDescripcion = m_strDescripcion;
			m_oldTempLiqMetal.intDocumento = m_intDocumento;
			m_oldTempLiqMetal.lngIdRegistroViaje = m_lngIdRegistroViaje;
			m_oldTempLiqMetal.dtmFechaAsignacion = m_dtmFechaAsignacion;
			m_oldTempLiqMetal.curValorDebito = m_curValorDebito;
			m_oldTempLiqMetal.curValorCredito = m_curValorCredito;
			m_oldTempLiqMetal.logLiquidado = m_logLiquidado;
			m_oldTempLiqMetal.nitTercero = m_nitTercero;
			m_oldTempLiqMetal.strObservaciones = m_strObservaciones;
			m_oldTempLiqMetal.lngIdUsuario = m_lngIdUsuario;
			m_oldTempLiqMetal.dtmFechaModif = m_dtmFechaModif;
			m_oldTempLiqMetal.LogAnticipo = m_LogAnticipo;
			m_oldTempLiqMetal.intNitConductor = m_intNitConductor;
			m_oldTempLiqMetal.strConductor = m_strConductor;
		}

		public TempLiqMetal OldTempLiqMetal
		{
			get { return m_oldTempLiqMetal;}
		}
		// Return the changed fields
		public string[] FieldChanged()
		{
			List<string> fields=new List<string>();
			if (m_oldTempLiqMetal.strPlaca != m_strPlaca) fields.Add("strPlaca");
			if (m_oldTempLiqMetal.strCuenta != m_strCuenta) fields.Add("strCuenta");
			if (m_oldTempLiqMetal.strDescripcion != m_strDescripcion) fields.Add("strDescripcion");
			if (m_oldTempLiqMetal.intDocumento != m_intDocumento) fields.Add("intDocumento");
			if (m_oldTempLiqMetal.lngIdRegistroViaje != m_lngIdRegistroViaje) fields.Add("lngIdRegistroViaje");
			if (m_oldTempLiqMetal.dtmFechaAsignacion != m_dtmFechaAsignacion) fields.Add("dtmFechaAsignacion");
			if (m_oldTempLiqMetal.curValorDebito != m_curValorDebito) fields.Add("curValorDebito");
			if (m_oldTempLiqMetal.curValorCredito != m_curValorCredito) fields.Add("curValorCredito");
			if (m_oldTempLiqMetal.logLiquidado != m_logLiquidado) fields.Add("logLiquidado");
			if (m_oldTempLiqMetal.nitTercero != m_nitTercero) fields.Add("nitTercero");
			if (m_oldTempLiqMetal.strObservaciones != m_strObservaciones) fields.Add("strObservaciones");
			if (m_oldTempLiqMetal.lngIdUsuario != m_lngIdUsuario) fields.Add("lngIdUsuario");
			if (m_oldTempLiqMetal.dtmFechaModif != m_dtmFechaModif) fields.Add("dtmFechaModif");
			if (m_oldTempLiqMetal.LogAnticipo != m_LogAnticipo) fields.Add("LogAnticipo");
			if (m_oldTempLiqMetal.intNitConductor != m_intNitConductor) fields.Add("intNitConductor");
			if (m_oldTempLiqMetal.strConductor != m_strConductor) fields.Add("strConductor");
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


		// Field for storing the TempLiqMetal's strPlaca value
		private string m_strPlaca;

		// Field for storing the TempLiqMetal's strCuenta value
		private char m_strCuenta;

		// Field for storing the TempLiqMetal's strDescripcion value
		private char? m_strDescripcion;

		// Field for storing the TempLiqMetal's intDocumento value
		private int? m_intDocumento;

		// Field for storing the TempLiqMetal's lngIdRegistroViaje value
		private decimal? m_lngIdRegistroViaje;

		// Field for storing the TempLiqMetal's dtmFechaAsignacion value
		private DateTime? m_dtmFechaAsignacion;

		// Field for storing the TempLiqMetal's curValorDebito value
		private decimal? m_curValorDebito;

		// Field for storing the TempLiqMetal's curValorCredito value
		private decimal? m_curValorCredito;

		// Field for storing the TempLiqMetal's logLiquidado value
		private bool? m_logLiquidado;

		// Field for storing the TempLiqMetal's nitTercero value
		private char? m_nitTercero;

		// Field for storing the TempLiqMetal's strObservaciones value
		private string m_strObservaciones;

		// Field for storing the TempLiqMetal's lngIdUsuario value
		private int? m_lngIdUsuario;

		// Field for storing the TempLiqMetal's dtmFechaModif value
		private DateTime? m_dtmFechaModif;

		// Field for storing the TempLiqMetal's LogAnticipo value
		private bool? m_LogAnticipo;

		// Field for storing the TempLiqMetal's intNitConductor value
		private decimal? m_intNitConductor;

		// Field for storing the TempLiqMetal's strConductor value
		private string m_strConductor;

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
		/// Attribute for access the TempLiqMetal's strPlaca value (string)
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
		/// Attribute for access the TempLiqMetal's strCuenta value (char)
		/// </summary>
		[DataMember]
		public char strCuenta
		{
			get { return m_strCuenta; }
			set 
			{
				m_changed=true;
				m_strCuenta = value;
			}
		}

		/// <summary>
		/// Attribute for access the TempLiqMetal's strDescripcion value (char)
		/// </summary>
		[DataMember]
		public char? strDescripcion
		{
			get { return m_strDescripcion; }
			set 
			{
				m_changed=true;
				m_strDescripcion = value;
			}
		}

		/// <summary>
		/// Attribute for access the TempLiqMetal's intDocumento value (int)
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
		/// Attribute for access the TempLiqMetal's lngIdRegistroViaje value (decimal)
		/// </summary>
		[DataMember]
		public decimal? lngIdRegistroViaje
		{
			get { return m_lngIdRegistroViaje; }
			set 
			{
				m_changed=true;
				m_lngIdRegistroViaje = value;
			}
		}

		/// <summary>
		/// Attribute for access the TempLiqMetal's dtmFechaAsignacion value (DateTime)
		/// </summary>
		[DataMember]
		public DateTime? dtmFechaAsignacion
		{
			get { return m_dtmFechaAsignacion; }
			set 
			{
				m_changed=true;
				m_dtmFechaAsignacion = value;
			}
		}

		/// <summary>
		/// Attribute for access the TempLiqMetal's curValorDebito value (decimal)
		/// </summary>
		[DataMember]
		public decimal? curValorDebito
		{
			get { return m_curValorDebito; }
			set 
			{
				m_changed=true;
				m_curValorDebito = value;
			}
		}

		/// <summary>
		/// Attribute for access the TempLiqMetal's curValorCredito value (decimal)
		/// </summary>
		[DataMember]
		public decimal? curValorCredito
		{
			get { return m_curValorCredito; }
			set 
			{
				m_changed=true;
				m_curValorCredito = value;
			}
		}

		/// <summary>
		/// Attribute for access the TempLiqMetal's logLiquidado value (bool)
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
		/// Attribute for access the TempLiqMetal's nitTercero value (char)
		/// </summary>
		[DataMember]
		public char? nitTercero
		{
			get { return m_nitTercero; }
			set 
			{
				m_changed=true;
				m_nitTercero = value;
			}
		}

		/// <summary>
		/// Attribute for access the TempLiqMetal's strObservaciones value (string)
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
		/// Attribute for access the TempLiqMetal's lngIdUsuario value (int)
		/// </summary>
		[DataMember]
		public int? lngIdUsuario
		{
			get { return m_lngIdUsuario; }
			set 
			{
				m_changed=true;
				m_lngIdUsuario = value;
			}
		}

		/// <summary>
		/// Attribute for access the TempLiqMetal's dtmFechaModif value (DateTime)
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
		/// Attribute for access the TempLiqMetal's LogAnticipo value (bool)
		/// </summary>
		[DataMember]
		public bool? LogAnticipo
		{
			get { return m_LogAnticipo; }
			set 
			{
				m_changed=true;
				m_LogAnticipo = value;
			}
		}

		/// <summary>
		/// Attribute for access the TempLiqMetal's intNitConductor value (decimal)
		/// </summary>
		[DataMember]
		public decimal? intNitConductor
		{
			get { return m_intNitConductor; }
			set 
			{
				m_changed=true;
				m_intNitConductor = value;
			}
		}

		/// <summary>
		/// Attribute for access the TempLiqMetal's strConductor value (string)
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

		public object GetAttribute(string pattribute)
		{
			switch (pattribute)
			{
				case "strPlaca": return strPlaca;
				case "strCuenta": return strCuenta;
				case "strDescripcion": return strDescripcion;
				case "intDocumento": return intDocumento;
				case "lngIdRegistroViaje": return lngIdRegistroViaje;
				case "dtmFechaAsignacion": return dtmFechaAsignacion;
				case "curValorDebito": return curValorDebito;
				case "curValorCredito": return curValorCredito;
				case "logLiquidado": return logLiquidado;
				case "nitTercero": return nitTercero;
				case "strObservaciones": return strObservaciones;
				case "lngIdUsuario": return lngIdUsuario;
				case "dtmFechaModif": return dtmFechaModif;
				case "LogAnticipo": return LogAnticipo;
				case "intNitConductor": return intNitConductor;
				case "strConductor": return strConductor;
				default: return null;
			}
		}

		public Type GetAttributeType(string pattribute)
		{
			return TempLiqMetalController.Instance.GetMethodType(pattribute, this);
		}

		public string GetSqlKey()
		{
			return "";
		}
		#endregion

	}

	#endregion

	#region TempLiqMetalList object

	/// <summary>
	/// Class for reading and access a list of TempLiqMetal object
	/// </summary>
	[CollectionDataContract]
	public partial class TempLiqMetalList : List<TempLiqMetal>
	{

		/// <summary>
		/// Default constructor
		/// </summary>
		public TempLiqMetalList()
		{
		}
	}

	#endregion

}
