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
	#region LiquidacionGastos object

	[DataContract]
	public partial class LiquidacionGastos : IDTOObject
	{
		/// <summary>
		/// Default constructor
		/// </summary>
		public LiquidacionGastos()
		{
			m_Codigo = 0;
			m_lngIdRegistrRutaItemId = 0;
			m_lngIdRegistroViaje = 0;
			m_lngIdRegistrRuta = 0;
			m_strCuenta = "";
			m_intRowRegistro = 0;
			m_strDescripcionCuenta = null;
			m_strDescripcion = null;
			m_dtmFechaAsignacion = null;
			m_curValorTramo = null;
			m_curValorAdicional = null;
			m_curValorTotal = null;
			m_strObservaciones = null;
			m_nitTercero = null;
			m_strPlaca = null;
			m_lngIdUsuario = null;
			m_logLiquidado = false;
			m_dtmFechaSalida = null;
			m_dtmFechaLlegada = null;
			m_dtmFechaModif = null;
			m_LogExcluido = false;
			m_floGalones = null;
			m_floGalonesAdicional = null;
			m_floGalonesReales = null;
			m_curValorGalon = null;
			m_CombustibleCarretera = null;
			m_cutCombustible = null;
			m_LogAnticipoACPM = false;
			m_AntipoConductor = false;
			m_NombreTercero = null;
			m_Detalle = false;
			m_changed=false;
		}
		        //Return the table name of object
		        public string TableName()
		        {
		            return "tblLiquidacionGastos";
		        }
		#region Undo 
		// Internal class for storing changes
		private LiquidacionGastos m_oldLiquidacionGastos;
		public void GenerateUndo()
		{
			m_oldLiquidacionGastos=new LiquidacionGastos();
			m_oldLiquidacionGastos.m_Codigo = m_Codigo;
			m_oldLiquidacionGastos.m_lngIdRegistrRutaItemId = m_lngIdRegistrRutaItemId;
			m_oldLiquidacionGastos.m_lngIdRegistroViaje = m_lngIdRegistroViaje;
			m_oldLiquidacionGastos.m_lngIdRegistrRuta = m_lngIdRegistrRuta;
			m_oldLiquidacionGastos.m_strCuenta = m_strCuenta;
			m_oldLiquidacionGastos.m_intRowRegistro = m_intRowRegistro;
			m_oldLiquidacionGastos.strDescripcionCuenta = m_strDescripcionCuenta;
			m_oldLiquidacionGastos.strDescripcion = m_strDescripcion;
			m_oldLiquidacionGastos.dtmFechaAsignacion = m_dtmFechaAsignacion;
			m_oldLiquidacionGastos.curValorTramo = m_curValorTramo;
			m_oldLiquidacionGastos.curValorAdicional = m_curValorAdicional;
			m_oldLiquidacionGastos.curValorTotal = m_curValorTotal;
			m_oldLiquidacionGastos.strObservaciones = m_strObservaciones;
			m_oldLiquidacionGastos.nitTercero = m_nitTercero;
			m_oldLiquidacionGastos.strPlaca = m_strPlaca;
			m_oldLiquidacionGastos.lngIdUsuario = m_lngIdUsuario;
			m_oldLiquidacionGastos.logLiquidado = m_logLiquidado;
			m_oldLiquidacionGastos.dtmFechaSalida = m_dtmFechaSalida;
			m_oldLiquidacionGastos.dtmFechaLlegada = m_dtmFechaLlegada;
			m_oldLiquidacionGastos.dtmFechaModif = m_dtmFechaModif;
			m_oldLiquidacionGastos.LogExcluido = m_LogExcluido;
			m_oldLiquidacionGastos.floGalones = m_floGalones;
			m_oldLiquidacionGastos.floGalonesAdicional = m_floGalonesAdicional;
			m_oldLiquidacionGastos.floGalonesReales = m_floGalonesReales;
			m_oldLiquidacionGastos.curValorGalon = m_curValorGalon;
			m_oldLiquidacionGastos.CombustibleCarretera = m_CombustibleCarretera;
			m_oldLiquidacionGastos.cutCombustible = m_cutCombustible;
			m_oldLiquidacionGastos.LogAnticipoACPM = m_LogAnticipoACPM;
			m_oldLiquidacionGastos.AntipoConductor = m_AntipoConductor;
			m_oldLiquidacionGastos.NombreTercero = m_NombreTercero;
			m_oldLiquidacionGastos.Detalle = m_Detalle;
		}

		public LiquidacionGastos OldLiquidacionGastos
		{
			get { return m_oldLiquidacionGastos;}
		}
		// Return the changed fields
		public string[] FieldChanged()
		{
			List<string> fields=new List<string>();
			if (m_oldLiquidacionGastos.strDescripcionCuenta != m_strDescripcionCuenta) fields.Add("strDescripcionCuenta");
			if (m_oldLiquidacionGastos.strDescripcion != m_strDescripcion) fields.Add("strDescripcion");
			if (m_oldLiquidacionGastos.dtmFechaAsignacion != m_dtmFechaAsignacion) fields.Add("dtmFechaAsignacion");
			if (m_oldLiquidacionGastos.curValorTramo != m_curValorTramo) fields.Add("curValorTramo");
			if (m_oldLiquidacionGastos.curValorAdicional != m_curValorAdicional) fields.Add("curValorAdicional");
			if (m_oldLiquidacionGastos.curValorTotal != m_curValorTotal) fields.Add("curValorTotal");
			if (m_oldLiquidacionGastos.strObservaciones != m_strObservaciones) fields.Add("strObservaciones");
			if (m_oldLiquidacionGastos.nitTercero != m_nitTercero) fields.Add("nitTercero");
			if (m_oldLiquidacionGastos.strPlaca != m_strPlaca) fields.Add("strPlaca");
			if (m_oldLiquidacionGastos.lngIdUsuario != m_lngIdUsuario) fields.Add("lngIdUsuario");
			if (m_oldLiquidacionGastos.logLiquidado != m_logLiquidado) fields.Add("logLiquidado");
			if (m_oldLiquidacionGastos.dtmFechaSalida != m_dtmFechaSalida) fields.Add("dtmFechaSalida");
			if (m_oldLiquidacionGastos.dtmFechaLlegada != m_dtmFechaLlegada) fields.Add("dtmFechaLlegada");
			if (m_oldLiquidacionGastos.dtmFechaModif != m_dtmFechaModif) fields.Add("dtmFechaModif");
			if (m_oldLiquidacionGastos.LogExcluido != m_LogExcluido) fields.Add("LogExcluido");
			if (m_oldLiquidacionGastos.floGalones != m_floGalones) fields.Add("floGalones");
			if (m_oldLiquidacionGastos.floGalonesAdicional != m_floGalonesAdicional) fields.Add("floGalonesAdicional");
			if (m_oldLiquidacionGastos.floGalonesReales != m_floGalonesReales) fields.Add("floGalonesReales");
			if (m_oldLiquidacionGastos.curValorGalon != m_curValorGalon) fields.Add("curValorGalon");
			if (m_oldLiquidacionGastos.CombustibleCarretera != m_CombustibleCarretera) fields.Add("CombustibleCarretera");
			if (m_oldLiquidacionGastos.cutCombustible != m_cutCombustible) fields.Add("cutCombustible");
			if (m_oldLiquidacionGastos.LogAnticipoACPM != m_LogAnticipoACPM) fields.Add("LogAnticipoACPM");
			if (m_oldLiquidacionGastos.AntipoConductor != m_AntipoConductor) fields.Add("AntipoConductor");
			if (m_oldLiquidacionGastos.NombreTercero != m_NombreTercero) fields.Add("NombreTercero");
			if (m_oldLiquidacionGastos.Detalle != m_Detalle) fields.Add("Detalle");
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


		// Field for storing the LiquidacionGastos's Codigo value
		private long m_Codigo;

		// Field for storing the LiquidacionGastos's lngIdRegistrRutaItemId value
		private long m_lngIdRegistrRutaItemId;

		// Field for storing the LiquidacionGastos's lngIdRegistroViaje value
		private long m_lngIdRegistroViaje;

		// Field for storing the LiquidacionGastos's lngIdRegistrRuta value
		private long m_lngIdRegistrRuta;

		// Field for storing the LiquidacionGastos's strCuenta value
		private string m_strCuenta;

		// Field for storing the LiquidacionGastos's intRowRegistro value
		private int m_intRowRegistro;

		// Field for storing the LiquidacionGastos's strDescripcionCuenta value
		private string m_strDescripcionCuenta;

		// Field for storing the LiquidacionGastos's strDescripcion value
		private string m_strDescripcion;

		// Field for storing the LiquidacionGastos's dtmFechaAsignacion value
		private DateTime? m_dtmFechaAsignacion;

		// Field for storing the LiquidacionGastos's curValorTramo value
		private decimal? m_curValorTramo;

		// Field for storing the LiquidacionGastos's curValorAdicional value
		private decimal? m_curValorAdicional;

		// Field for storing the LiquidacionGastos's curValorTotal value
		private decimal? m_curValorTotal;

		// Field for storing the LiquidacionGastos's strObservaciones value
		private string m_strObservaciones;

		// Field for storing the LiquidacionGastos's nitTercero value
		private string m_nitTercero;

		// Field for storing the LiquidacionGastos's strPlaca value
		private string m_strPlaca;

		// Field for storing the LiquidacionGastos's lngIdUsuario value
		private int? m_lngIdUsuario;

		// Field for storing the LiquidacionGastos's logLiquidado value
		private bool? m_logLiquidado;

		// Field for storing the LiquidacionGastos's dtmFechaSalida value
		private DateTime? m_dtmFechaSalida;

		// Field for storing the LiquidacionGastos's dtmFechaLlegada value
		private DateTime? m_dtmFechaLlegada;

		// Field for storing the LiquidacionGastos's dtmFechaModif value
		private DateTime? m_dtmFechaModif;

		// Field for storing the LiquidacionGastos's LogExcluido value
		private bool? m_LogExcluido;

		// Field for storing the LiquidacionGastos's floGalones value
		private decimal? m_floGalones;

		// Field for storing the LiquidacionGastos's floGalonesAdicional value
		private decimal? m_floGalonesAdicional;

		// Field for storing the LiquidacionGastos's floGalonesReales value
		private decimal? m_floGalonesReales;

		// Field for storing the LiquidacionGastos's curValorGalon value
		private decimal? m_curValorGalon;

		// Field for storing the LiquidacionGastos's CombustibleCarretera value
		private decimal? m_CombustibleCarretera;

		// Field for storing the LiquidacionGastos's cutCombustible value
		private decimal? m_cutCombustible;

		// Field for storing the LiquidacionGastos's LogAnticipoACPM value
		private bool? m_LogAnticipoACPM;

		// Field for storing the LiquidacionGastos's AntipoConductor value
		private bool? m_AntipoConductor;

		// Field for storing the LiquidacionGastos's NombreTercero value
		private string m_NombreTercero;

		// Field for storing the LiquidacionGastos's Detalle value
		private bool? m_Detalle;

		// Evaluate changed state
		private bool m_changed=false;
		// Field for storing the reference to LiquidacionRutas accessed by lngIdRegistrRutaItemId
		private LiquidacionRutas m_LiquidacionRutas;


		#endregion

		#region Attributes

		// Return if object changed
		public bool Changed
		{
			get { return m_changed;}
			set { m_changed=value;}
		}
		/// <summary>
		/// Attribute for access the LiquidacionGastos's Codigo value (long)
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
		/// Attribute for access the LiquidacionGastos's lngIdRegistrRutaItemId value (long)
		/// </summary>
		[DataMember]
		public long lngIdRegistrRutaItemId
		{
			get { return m_lngIdRegistrRutaItemId; }
			set
			{
				m_changed=true;
				m_lngIdRegistrRutaItemId = value;

				if ((m_LiquidacionRutas != null) && (m_LiquidacionRutas.lngIdRegistrRutaItemId != m_lngIdRegistrRutaItemId))
				{
					// we need to reset the reference because it is now invalid
					m_LiquidacionRutas = null;
				}
			}
		}

		/// <summary>
		/// Attribute for access the LiquidacionGastos's lngIdRegistroViaje value (long)
		/// </summary>
		[DataMember]
		public long lngIdRegistroViaje
		{
			get { return m_lngIdRegistroViaje; }
			set 
			{
				m_changed=true;
				m_lngIdRegistroViaje = value;
			}
		}

		/// <summary>
		/// Attribute for access the LiquidacionGastos's lngIdRegistrRuta value (long)
		/// </summary>
		[DataMember]
		public long lngIdRegistrRuta
		{
			get { return m_lngIdRegistrRuta; }
			set 
			{
				m_changed=true;
				m_lngIdRegistrRuta = value;
			}
		}

		/// <summary>
		/// Attribute for access the LiquidacionGastos's strCuenta value (string)
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
		/// Attribute for access the LiquidacionGastos's intRowRegistro value (int)
		/// </summary>
		[DataMember]
		public int intRowRegistro
		{
			get { return m_intRowRegistro; }
			set 
			{
				m_changed=true;
				m_intRowRegistro = value;
			}
		}

		/// <summary>
		/// Attribute for access the LiquidacionGastos's strDescripcionCuenta value (string)
		/// </summary>
		[DataMember]
		public string strDescripcionCuenta
		{
			get { return m_strDescripcionCuenta; }
			set 
			{
				m_changed=true;
				m_strDescripcionCuenta = value;
			}
		}

		/// <summary>
		/// Attribute for access the LiquidacionGastos's strDescripcion value (string)
		/// </summary>
		[DataMember]
		public string strDescripcion
		{
			get { return m_strDescripcion; }
			set 
			{
				m_changed=true;
				m_strDescripcion = value;
			}
		}

		/// <summary>
		/// Attribute for access the LiquidacionGastos's dtmFechaAsignacion value (DateTime)
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
		/// Attribute for access the LiquidacionGastos's curValorTramo value (decimal)
		/// </summary>
		[DataMember]
		public decimal? curValorTramo
		{
			get { return m_curValorTramo; }
			set 
			{
				m_changed=true;
				m_curValorTramo = value;
			}
		}

		/// <summary>
		/// Attribute for access the LiquidacionGastos's curValorAdicional value (decimal)
		/// </summary>
		[DataMember]
		public decimal? curValorAdicional
		{
			get { return m_curValorAdicional; }
			set 
			{
				m_changed=true;
				m_curValorAdicional = value;
			}
		}

		/// <summary>
		/// Attribute for access the LiquidacionGastos's curValorTotal value (decimal)
		/// </summary>
		[DataMember]
		public decimal? curValorTotal
		{
			get { return m_curValorTotal; }
			set 
			{
				m_changed=true;
				m_curValorTotal = value;
			}
		}

		/// <summary>
		/// Attribute for access the LiquidacionGastos's strObservaciones value (string)
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
		/// Attribute for access the LiquidacionGastos's nitTercero value (string)
		/// </summary>
		[DataMember]
		public string nitTercero
		{
			get { return m_nitTercero; }
			set 
			{
				m_changed=true;
				m_nitTercero = value;
			}
		}

		/// <summary>
		/// Attribute for access the LiquidacionGastos's strPlaca value (string)
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
		/// Attribute for access the LiquidacionGastos's lngIdUsuario value (int)
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
		/// Attribute for access the LiquidacionGastos's logLiquidado value (bool)
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
		/// Attribute for access the LiquidacionGastos's dtmFechaSalida value (DateTime)
		/// </summary>
		[DataMember]
		public DateTime? dtmFechaSalida
		{
			get { return m_dtmFechaSalida; }
			set 
			{
				m_changed=true;
				m_dtmFechaSalida = value;
			}
		}

		/// <summary>
		/// Attribute for access the LiquidacionGastos's dtmFechaLlegada value (DateTime)
		/// </summary>
		[DataMember]
		public DateTime? dtmFechaLlegada
		{
			get { return m_dtmFechaLlegada; }
			set 
			{
				m_changed=true;
				m_dtmFechaLlegada = value;
			}
		}

		/// <summary>
		/// Attribute for access the LiquidacionGastos's dtmFechaModif value (DateTime)
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
		/// Attribute for access the LiquidacionGastos's LogExcluido value (bool)
		/// </summary>
		[DataMember]
		public bool? LogExcluido
		{
			get { return m_LogExcluido; }
			set 
			{
				m_changed=true;
				m_LogExcluido = value;
			}
		}

		/// <summary>
		/// Attribute for access the LiquidacionGastos's floGalones value (decimal)
		/// </summary>
		[DataMember]
		public decimal? floGalones
		{
			get { return m_floGalones; }
			set 
			{
				m_changed=true;
				m_floGalones = value;
			}
		}

		/// <summary>
		/// Attribute for access the LiquidacionGastos's floGalonesAdicional value (decimal)
		/// </summary>
		[DataMember]
		public decimal? floGalonesAdicional
		{
			get { return m_floGalonesAdicional; }
			set 
			{
				m_changed=true;
				m_floGalonesAdicional = value;
			}
		}

		/// <summary>
		/// Attribute for access the LiquidacionGastos's floGalonesReales value (decimal)
		/// </summary>
		[DataMember]
		public decimal? floGalonesReales
		{
			get { return m_floGalonesReales; }
			set 
			{
				m_changed=true;
				m_floGalonesReales = value;
			}
		}

		/// <summary>
		/// Attribute for access the LiquidacionGastos's curValorGalon value (decimal)
		/// </summary>
		[DataMember]
		public decimal? curValorGalon
		{
			get { return m_curValorGalon; }
			set 
			{
				m_changed=true;
				m_curValorGalon = value;
			}
		}

		/// <summary>
		/// Attribute for access the LiquidacionGastos's CombustibleCarretera value (decimal)
		/// </summary>
		[DataMember]
		public decimal? CombustibleCarretera
		{
			get { return m_CombustibleCarretera; }
			set 
			{
				m_changed=true;
				m_CombustibleCarretera = value;
			}
		}

		/// <summary>
		/// Attribute for access the LiquidacionGastos's cutCombustible value (decimal)
		/// </summary>
		[DataMember]
		public decimal? cutCombustible
		{
			get { return m_cutCombustible; }
			set 
			{
				m_changed=true;
				m_cutCombustible = value;
			}
		}

		/// <summary>
		/// Attribute for access the LiquidacionGastos's LogAnticipoACPM value (bool)
		/// </summary>
		[DataMember]
		public bool? LogAnticipoACPM
		{
			get { return m_LogAnticipoACPM; }
			set 
			{
				m_changed=true;
				m_LogAnticipoACPM = value;
			}
		}

		/// <summary>
		/// Attribute for access the LiquidacionGastos's AntipoConductor value (bool)
		/// </summary>
		[DataMember]
		public bool? AntipoConductor
		{
			get { return m_AntipoConductor; }
			set 
			{
				m_changed=true;
				m_AntipoConductor = value;
			}
		}

		/// <summary>
		/// Attribute for access the LiquidacionGastos's NombreTercero value (string)
		/// </summary>
		[DataMember]
		public string NombreTercero
		{
			get { return m_NombreTercero; }
			set 
			{
				m_changed=true;
				m_NombreTercero = value;
			}
		}

		/// <summary>
		/// Attribute for access the LiquidacionGastos's Detalle value (bool)
		/// </summary>
		[DataMember]
		public bool? Detalle
		{
			get { return m_Detalle; }
			set 
			{
				m_changed=true;
				m_Detalle = value;
			}
		}

		public object GetAttribute(string pattribute)
		{
			switch (pattribute)
			{
				case "Codigo": return Codigo;
				case "lngIdRegistrRutaItemId": return lngIdRegistrRutaItemId;
				case "lngIdRegistroViaje": return lngIdRegistroViaje;
				case "lngIdRegistrRuta": return lngIdRegistrRuta;
				case "strCuenta": return strCuenta;
				case "intRowRegistro": return intRowRegistro;
				case "strDescripcionCuenta": return strDescripcionCuenta;
				case "strDescripcion": return strDescripcion;
				case "dtmFechaAsignacion": return dtmFechaAsignacion;
				case "curValorTramo": return curValorTramo;
				case "curValorAdicional": return curValorAdicional;
				case "curValorTotal": return curValorTotal;
				case "strObservaciones": return strObservaciones;
				case "nitTercero": return nitTercero;
				case "strPlaca": return strPlaca;
				case "lngIdUsuario": return lngIdUsuario;
				case "logLiquidado": return logLiquidado;
				case "dtmFechaSalida": return dtmFechaSalida;
				case "dtmFechaLlegada": return dtmFechaLlegada;
				case "dtmFechaModif": return dtmFechaModif;
				case "LogExcluido": return LogExcluido;
				case "floGalones": return floGalones;
				case "floGalonesAdicional": return floGalonesAdicional;
				case "floGalonesReales": return floGalonesReales;
				case "curValorGalon": return curValorGalon;
				case "CombustibleCarretera": return CombustibleCarretera;
				case "cutCombustible": return cutCombustible;
				case "LogAnticipoACPM": return LogAnticipoACPM;
				case "AntipoConductor": return AntipoConductor;
				case "NombreTercero": return NombreTercero;
				case "Detalle": return Detalle;
				default: return null;
			}
		}

		public Type GetAttributeType(string pattribute)
		{
			return LiquidacionGastosController.Instance.GetMethodType(pattribute, this);
		}

		public string GetSqlKey()
		{
			return "[Codigo] = " + Codigo.ToString() + " AND [lngIdRegistrRutaItemId] = " + lngIdRegistrRutaItemId.ToString() + " AND [lngIdRegistroViaje] = " + lngIdRegistroViaje.ToString() + " AND [lngIdRegistrRuta] = " + lngIdRegistrRuta.ToString() + " AND [strCuenta] = '" + strCuenta.ToString()+ "'" + " AND [intRowRegistro] = " + intRowRegistro.ToString();
		}
		/// <summary>
		/// Gets or sets the reference to LiquidacionRutas accessed by lngIdRegistrRutaItemId
		/// </summary>
		/// <remarks>
		/// Also updates related field values
		/// </remarks>
		public LiquidacionRutas LiquidacionRutas
		{
			get
			{
				if (m_LiquidacionRutas == null)
				{
					m_LiquidacionRutas = LiquidacionRutasController.Instance.Get(m_lngIdRegistrRutaItemId);
				}

				return m_LiquidacionRutas;
			}

			set
			{
				m_LiquidacionRutas = value;

				if (m_LiquidacionRutas != null)
				{
					this.m_lngIdRegistrRutaItemId = m_LiquidacionRutas.lngIdRegistrRutaItemId;
				}
			}
		}

		#endregion

	}

	#endregion

	#region LiquidacionGastosList object

	/// <summary>
	/// Class for reading and access a list of LiquidacionGastos object
	/// </summary>
	[CollectionDataContract]
	public partial class LiquidacionGastosList : List<LiquidacionGastos>
	{

		/// <summary>
		/// Default constructor
		/// </summary>
		public LiquidacionGastosList()
		{
		}
	}

	#endregion

}
