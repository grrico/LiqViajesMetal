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
	#region VehiculoCCosto object

	[DataContract]
	public partial class VehiculoCCosto : IDTOObject
	{
		/// <summary>
		/// Default constructor
		/// </summary>
		public VehiculoCCosto()
		{
			m_lngIdRegistro = 0;
			m_lngIdUsuario = null;
			m_strPlaca = null;
			m_centro = null;
			m_TipoTrailerCodigo = null;
			m_TipoVehiculoCodigo = null;
			m_Descripcion = null;
			m_dtmFechaIngreso = null;
			m_dtmFechaEgreso = null;
			m_nitPropietario = null;
			m_strMarca = null;
			m_lngModelo = null;
			m_lngMovil = null;
			m_strCelular = null;
			m_strTipoMotor = null;
			m_strColor = null;
			m_strMotor = null;
			m_strChasis = null;
			m_logCamarote = false;
			m_CapacidadGalores = null;
			m_floGalonesReserva = null;
			m_floCantGalonesReserva = null;
			m_floTolerancia = null;
			m_cutPeso = null;
			m_cutCapacidad = null;
			m_lngEjes = null;
			m_logActivo = null;
			m_lngLlantas = null;
			m_strPolizaObligatorio = null;
			m_nitProvedorOblig = null;
			m_dtmFechaInicioOblig = null;
			m_dtmFechaVenceOblig = null;
			m_strPolizaTodoRiesgo = null;
			m_nitProvedorTodo = null;
			m_dtmFechaInicioTodo = null;
			m_dtmFechaVenceTodo = null;
			m_strCertifMovilizacion = null;
			m_dtmFechaInicioMoviliz = null;
			m_dtmFechaVenceMoviliz = null;
			m_strGases = null;
			m_dtmFechaInicioGases = null;
			m_dtmFechaVenceGases = null;
			m_strTarjetaOper = null;
			m_dtmFechaInicioTarjetaOper = null;
			m_dtmFechaVenceTarjetaOper = null;
			m_logVencimientoFecha = false;
			m_changed=false;
		}
		        //Return the table name of object
		        public string TableName()
		        {
		            return "tblVehiculoCCosto";
		        }
		#region Undo 
		// Internal class for storing changes
		private VehiculoCCosto m_oldVehiculoCCosto;
		public void GenerateUndo()
		{
			m_oldVehiculoCCosto=new VehiculoCCosto();
			m_oldVehiculoCCosto.m_lngIdRegistro = m_lngIdRegistro;
			m_oldVehiculoCCosto.lngIdUsuario = m_lngIdUsuario;
			m_oldVehiculoCCosto.strPlaca = m_strPlaca;
			m_oldVehiculoCCosto.centro = m_centro;
			m_oldVehiculoCCosto.TipoTrailerCodigo = m_TipoTrailerCodigo;
			m_oldVehiculoCCosto.TipoVehiculoCodigo = m_TipoVehiculoCodigo;
			m_oldVehiculoCCosto.Descripcion = m_Descripcion;
			m_oldVehiculoCCosto.dtmFechaIngreso = m_dtmFechaIngreso;
			m_oldVehiculoCCosto.dtmFechaEgreso = m_dtmFechaEgreso;
			m_oldVehiculoCCosto.nitPropietario = m_nitPropietario;
			m_oldVehiculoCCosto.strMarca = m_strMarca;
			m_oldVehiculoCCosto.lngModelo = m_lngModelo;
			m_oldVehiculoCCosto.lngMovil = m_lngMovil;
			m_oldVehiculoCCosto.strCelular = m_strCelular;
			m_oldVehiculoCCosto.strTipoMotor = m_strTipoMotor;
			m_oldVehiculoCCosto.strColor = m_strColor;
			m_oldVehiculoCCosto.strMotor = m_strMotor;
			m_oldVehiculoCCosto.strChasis = m_strChasis;
			m_oldVehiculoCCosto.logCamarote = m_logCamarote;
			m_oldVehiculoCCosto.CapacidadGalores = m_CapacidadGalores;
			m_oldVehiculoCCosto.floGalonesReserva = m_floGalonesReserva;
			m_oldVehiculoCCosto.floCantGalonesReserva = m_floCantGalonesReserva;
			m_oldVehiculoCCosto.floTolerancia = m_floTolerancia;
			m_oldVehiculoCCosto.cutPeso = m_cutPeso;
			m_oldVehiculoCCosto.cutCapacidad = m_cutCapacidad;
			m_oldVehiculoCCosto.lngEjes = m_lngEjes;
			m_oldVehiculoCCosto.logActivo = m_logActivo;
			m_oldVehiculoCCosto.lngLlantas = m_lngLlantas;
			m_oldVehiculoCCosto.strPolizaObligatorio = m_strPolizaObligatorio;
			m_oldVehiculoCCosto.nitProvedorOblig = m_nitProvedorOblig;
			m_oldVehiculoCCosto.dtmFechaInicioOblig = m_dtmFechaInicioOblig;
			m_oldVehiculoCCosto.dtmFechaVenceOblig = m_dtmFechaVenceOblig;
			m_oldVehiculoCCosto.strPolizaTodoRiesgo = m_strPolizaTodoRiesgo;
			m_oldVehiculoCCosto.nitProvedorTodo = m_nitProvedorTodo;
			m_oldVehiculoCCosto.dtmFechaInicioTodo = m_dtmFechaInicioTodo;
			m_oldVehiculoCCosto.dtmFechaVenceTodo = m_dtmFechaVenceTodo;
			m_oldVehiculoCCosto.strCertifMovilizacion = m_strCertifMovilizacion;
			m_oldVehiculoCCosto.dtmFechaInicioMoviliz = m_dtmFechaInicioMoviliz;
			m_oldVehiculoCCosto.dtmFechaVenceMoviliz = m_dtmFechaVenceMoviliz;
			m_oldVehiculoCCosto.strGases = m_strGases;
			m_oldVehiculoCCosto.dtmFechaInicioGases = m_dtmFechaInicioGases;
			m_oldVehiculoCCosto.dtmFechaVenceGases = m_dtmFechaVenceGases;
			m_oldVehiculoCCosto.strTarjetaOper = m_strTarjetaOper;
			m_oldVehiculoCCosto.dtmFechaInicioTarjetaOper = m_dtmFechaInicioTarjetaOper;
			m_oldVehiculoCCosto.dtmFechaVenceTarjetaOper = m_dtmFechaVenceTarjetaOper;
			m_oldVehiculoCCosto.logVencimientoFecha = m_logVencimientoFecha;
		}

		public VehiculoCCosto OldVehiculoCCosto
		{
			get { return m_oldVehiculoCCosto;}
		}
		// Return the changed fields
		public string[] FieldChanged()
		{
			List<string> fields=new List<string>();
			if (m_oldVehiculoCCosto.lngIdUsuario != m_lngIdUsuario) fields.Add("lngIdUsuario");
			if (m_oldVehiculoCCosto.strPlaca != m_strPlaca) fields.Add("strPlaca");
			if (m_oldVehiculoCCosto.centro != m_centro) fields.Add("centro");
			if (m_oldVehiculoCCosto.TipoTrailerCodigo != m_TipoTrailerCodigo) fields.Add("TipoTrailerCodigo");
			if (m_oldVehiculoCCosto.TipoVehiculoCodigo != m_TipoVehiculoCodigo) fields.Add("TipoVehiculoCodigo");
			if (m_oldVehiculoCCosto.Descripcion != m_Descripcion) fields.Add("Descripcion");
			if (m_oldVehiculoCCosto.dtmFechaIngreso != m_dtmFechaIngreso) fields.Add("dtmFechaIngreso");
			if (m_oldVehiculoCCosto.dtmFechaEgreso != m_dtmFechaEgreso) fields.Add("dtmFechaEgreso");
			if (m_oldVehiculoCCosto.nitPropietario != m_nitPropietario) fields.Add("nitPropietario");
			if (m_oldVehiculoCCosto.strMarca != m_strMarca) fields.Add("strMarca");
			if (m_oldVehiculoCCosto.lngModelo != m_lngModelo) fields.Add("lngModelo");
			if (m_oldVehiculoCCosto.lngMovil != m_lngMovil) fields.Add("lngMovil");
			if (m_oldVehiculoCCosto.strCelular != m_strCelular) fields.Add("strCelular");
			if (m_oldVehiculoCCosto.strTipoMotor != m_strTipoMotor) fields.Add("strTipoMotor");
			if (m_oldVehiculoCCosto.strColor != m_strColor) fields.Add("strColor");
			if (m_oldVehiculoCCosto.strMotor != m_strMotor) fields.Add("strMotor");
			if (m_oldVehiculoCCosto.strChasis != m_strChasis) fields.Add("strChasis");
			if (m_oldVehiculoCCosto.logCamarote != m_logCamarote) fields.Add("logCamarote");
			if (m_oldVehiculoCCosto.CapacidadGalores != m_CapacidadGalores) fields.Add("CapacidadGalores");
			if (m_oldVehiculoCCosto.floGalonesReserva != m_floGalonesReserva) fields.Add("floGalonesReserva");
			if (m_oldVehiculoCCosto.floCantGalonesReserva != m_floCantGalonesReserva) fields.Add("floCantGalonesReserva");
			if (m_oldVehiculoCCosto.floTolerancia != m_floTolerancia) fields.Add("floTolerancia");
			if (m_oldVehiculoCCosto.cutPeso != m_cutPeso) fields.Add("cutPeso");
			if (m_oldVehiculoCCosto.cutCapacidad != m_cutCapacidad) fields.Add("cutCapacidad");
			if (m_oldVehiculoCCosto.lngEjes != m_lngEjes) fields.Add("lngEjes");
			if (m_oldVehiculoCCosto.logActivo != m_logActivo) fields.Add("logActivo");
			if (m_oldVehiculoCCosto.lngLlantas != m_lngLlantas) fields.Add("lngLlantas");
			if (m_oldVehiculoCCosto.strPolizaObligatorio != m_strPolizaObligatorio) fields.Add("strPolizaObligatorio");
			if (m_oldVehiculoCCosto.nitProvedorOblig != m_nitProvedorOblig) fields.Add("nitProvedorOblig");
			if (m_oldVehiculoCCosto.dtmFechaInicioOblig != m_dtmFechaInicioOblig) fields.Add("dtmFechaInicioOblig");
			if (m_oldVehiculoCCosto.dtmFechaVenceOblig != m_dtmFechaVenceOblig) fields.Add("dtmFechaVenceOblig");
			if (m_oldVehiculoCCosto.strPolizaTodoRiesgo != m_strPolizaTodoRiesgo) fields.Add("strPolizaTodoRiesgo");
			if (m_oldVehiculoCCosto.nitProvedorTodo != m_nitProvedorTodo) fields.Add("nitProvedorTodo");
			if (m_oldVehiculoCCosto.dtmFechaInicioTodo != m_dtmFechaInicioTodo) fields.Add("dtmFechaInicioTodo");
			if (m_oldVehiculoCCosto.dtmFechaVenceTodo != m_dtmFechaVenceTodo) fields.Add("dtmFechaVenceTodo");
			if (m_oldVehiculoCCosto.strCertifMovilizacion != m_strCertifMovilizacion) fields.Add("strCertifMovilizacion");
			if (m_oldVehiculoCCosto.dtmFechaInicioMoviliz != m_dtmFechaInicioMoviliz) fields.Add("dtmFechaInicioMoviliz");
			if (m_oldVehiculoCCosto.dtmFechaVenceMoviliz != m_dtmFechaVenceMoviliz) fields.Add("dtmFechaVenceMoviliz");
			if (m_oldVehiculoCCosto.strGases != m_strGases) fields.Add("strGases");
			if (m_oldVehiculoCCosto.dtmFechaInicioGases != m_dtmFechaInicioGases) fields.Add("dtmFechaInicioGases");
			if (m_oldVehiculoCCosto.dtmFechaVenceGases != m_dtmFechaVenceGases) fields.Add("dtmFechaVenceGases");
			if (m_oldVehiculoCCosto.strTarjetaOper != m_strTarjetaOper) fields.Add("strTarjetaOper");
			if (m_oldVehiculoCCosto.dtmFechaInicioTarjetaOper != m_dtmFechaInicioTarjetaOper) fields.Add("dtmFechaInicioTarjetaOper");
			if (m_oldVehiculoCCosto.dtmFechaVenceTarjetaOper != m_dtmFechaVenceTarjetaOper) fields.Add("dtmFechaVenceTarjetaOper");
			if (m_oldVehiculoCCosto.logVencimientoFecha != m_logVencimientoFecha) fields.Add("logVencimientoFecha");
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


		// Field for storing the VehiculoCCosto's lngIdUsuario value
		private double? m_lngIdUsuario;

		// Field for storing the VehiculoCCosto's strPlaca value
		private string m_strPlaca;

		// Field for storing the VehiculoCCosto's centro value
		private double? m_centro;

		// Field for storing the VehiculoCCosto's TipoTrailerCodigo value
		private int? m_TipoTrailerCodigo;

		// Field for storing the VehiculoCCosto's TipoVehiculoCodigo value
		private int? m_TipoVehiculoCodigo;

		// Field for storing the VehiculoCCosto's Descripcion value
		private string m_Descripcion;

		// Field for storing the VehiculoCCosto's dtmFechaIngreso value
		private DateTime? m_dtmFechaIngreso;

		// Field for storing the VehiculoCCosto's dtmFechaEgreso value
		private DateTime? m_dtmFechaEgreso;

		// Field for storing the VehiculoCCosto's nitPropietario value
		private double? m_nitPropietario;

		// Field for storing the VehiculoCCosto's strMarca value
		private string m_strMarca;

		// Field for storing the VehiculoCCosto's lngModelo value
		private double? m_lngModelo;

		// Field for storing the VehiculoCCosto's lngMovil value
		private double? m_lngMovil;

		// Field for storing the VehiculoCCosto's strCelular value
		private double? m_strCelular;

		// Field for storing the VehiculoCCosto's strTipoMotor value
		private double? m_strTipoMotor;

		// Field for storing the VehiculoCCosto's strColor value
		private string m_strColor;

		// Field for storing the VehiculoCCosto's strMotor value
		private string m_strMotor;

		// Field for storing the VehiculoCCosto's strChasis value
		private string m_strChasis;

		// Field for storing the VehiculoCCosto's logCamarote value
		private bool? m_logCamarote;

		// Field for storing the VehiculoCCosto's CapacidadGalores value
		private decimal? m_CapacidadGalores;

		// Field for storing the VehiculoCCosto's floGalonesReserva value
		private decimal? m_floGalonesReserva;

		// Field for storing the VehiculoCCosto's floCantGalonesReserva value
		private decimal? m_floCantGalonesReserva;

		// Field for storing the VehiculoCCosto's floTolerancia value
		private decimal? m_floTolerancia;

		// Field for storing the VehiculoCCosto's cutPeso value
		private double? m_cutPeso;

		// Field for storing the VehiculoCCosto's cutCapacidad value
		private double? m_cutCapacidad;

		// Field for storing the VehiculoCCosto's lngEjes value
		private double? m_lngEjes;

		// Field for storing the VehiculoCCosto's logActivo value
		private double? m_logActivo;

		// Field for storing the VehiculoCCosto's lngLlantas value
		private double? m_lngLlantas;

		// Field for storing the VehiculoCCosto's strPolizaObligatorio value
		private string m_strPolizaObligatorio;

		// Field for storing the VehiculoCCosto's nitProvedorOblig value
		private double? m_nitProvedorOblig;

		// Field for storing the VehiculoCCosto's dtmFechaInicioOblig value
		private DateTime? m_dtmFechaInicioOblig;

		// Field for storing the VehiculoCCosto's dtmFechaVenceOblig value
		private DateTime? m_dtmFechaVenceOblig;

		// Field for storing the VehiculoCCosto's strPolizaTodoRiesgo value
		private string m_strPolizaTodoRiesgo;

		// Field for storing the VehiculoCCosto's nitProvedorTodo value
		private double? m_nitProvedorTodo;

		// Field for storing the VehiculoCCosto's dtmFechaInicioTodo value
		private DateTime? m_dtmFechaInicioTodo;

		// Field for storing the VehiculoCCosto's dtmFechaVenceTodo value
		private DateTime? m_dtmFechaVenceTodo;

		// Field for storing the VehiculoCCosto's strCertifMovilizacion value
		private string m_strCertifMovilizacion;

		// Field for storing the VehiculoCCosto's dtmFechaInicioMoviliz value
		private DateTime? m_dtmFechaInicioMoviliz;

		// Field for storing the VehiculoCCosto's dtmFechaVenceMoviliz value
		private DateTime? m_dtmFechaVenceMoviliz;

		// Field for storing the VehiculoCCosto's strGases value
		private string m_strGases;

		// Field for storing the VehiculoCCosto's dtmFechaInicioGases value
		private DateTime? m_dtmFechaInicioGases;

		// Field for storing the VehiculoCCosto's dtmFechaVenceGases value
		private DateTime? m_dtmFechaVenceGases;

		// Field for storing the VehiculoCCosto's strTarjetaOper value
		private string m_strTarjetaOper;

		// Field for storing the VehiculoCCosto's dtmFechaInicioTarjetaOper value
		private DateTime? m_dtmFechaInicioTarjetaOper;

		// Field for storing the VehiculoCCosto's dtmFechaVenceTarjetaOper value
		private DateTime? m_dtmFechaVenceTarjetaOper;

		// Field for storing the VehiculoCCosto's logVencimientoFecha value
		private bool? m_logVencimientoFecha;

		// Field for storing the VehiculoCCosto's lngIdRegistro value
		private int m_lngIdRegistro;

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
		/// Attribute for access the VehiculoCCosto's lngIdUsuario value (double)
		/// </summary>
		[DataMember]
		public double? lngIdUsuario
		{
			get { return m_lngIdUsuario; }
			set 
			{
				m_changed=true;
				m_lngIdUsuario = value;
			}
		}

		/// <summary>
		/// Attribute for access the VehiculoCCosto's strPlaca value (string)
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
		/// Attribute for access the VehiculoCCosto's centro value (double)
		/// </summary>
		[DataMember]
		public double? centro
		{
			get { return m_centro; }
			set 
			{
				m_changed=true;
				m_centro = value;
			}
		}

		/// <summary>
		/// Attribute for access the VehiculoCCosto's TipoTrailerCodigo value (int)
		/// </summary>
		[DataMember]
		public int? TipoTrailerCodigo
		{
			get { return m_TipoTrailerCodigo; }
			set 
			{
				m_changed=true;
				m_TipoTrailerCodigo = value;
			}
		}

		/// <summary>
		/// Attribute for access the VehiculoCCosto's TipoVehiculoCodigo value (int)
		/// </summary>
		[DataMember]
		public int? TipoVehiculoCodigo
		{
			get { return m_TipoVehiculoCodigo; }
			set 
			{
				m_changed=true;
				m_TipoVehiculoCodigo = value;
			}
		}

		/// <summary>
		/// Attribute for access the VehiculoCCosto's Descripcion value (string)
		/// </summary>
		[DataMember]
		public string Descripcion
		{
			get { return m_Descripcion; }
			set 
			{
				m_changed=true;
				m_Descripcion = value;
			}
		}

		/// <summary>
		/// Attribute for access the VehiculoCCosto's dtmFechaIngreso value (DateTime)
		/// </summary>
		[DataMember]
		public DateTime? dtmFechaIngreso
		{
			get { return m_dtmFechaIngreso; }
			set 
			{
				m_changed=true;
				m_dtmFechaIngreso = value;
			}
		}

		/// <summary>
		/// Attribute for access the VehiculoCCosto's dtmFechaEgreso value (DateTime)
		/// </summary>
		[DataMember]
		public DateTime? dtmFechaEgreso
		{
			get { return m_dtmFechaEgreso; }
			set 
			{
				m_changed=true;
				m_dtmFechaEgreso = value;
			}
		}

		/// <summary>
		/// Attribute for access the VehiculoCCosto's nitPropietario value (double)
		/// </summary>
		[DataMember]
		public double? nitPropietario
		{
			get { return m_nitPropietario; }
			set 
			{
				m_changed=true;
				m_nitPropietario = value;
			}
		}

		/// <summary>
		/// Attribute for access the VehiculoCCosto's strMarca value (string)
		/// </summary>
		[DataMember]
		public string strMarca
		{
			get { return m_strMarca; }
			set 
			{
				m_changed=true;
				m_strMarca = value;
			}
		}

		/// <summary>
		/// Attribute for access the VehiculoCCosto's lngModelo value (double)
		/// </summary>
		[DataMember]
		public double? lngModelo
		{
			get { return m_lngModelo; }
			set 
			{
				m_changed=true;
				m_lngModelo = value;
			}
		}

		/// <summary>
		/// Attribute for access the VehiculoCCosto's lngMovil value (double)
		/// </summary>
		[DataMember]
		public double? lngMovil
		{
			get { return m_lngMovil; }
			set 
			{
				m_changed=true;
				m_lngMovil = value;
			}
		}

		/// <summary>
		/// Attribute for access the VehiculoCCosto's strCelular value (double)
		/// </summary>
		[DataMember]
		public double? strCelular
		{
			get { return m_strCelular; }
			set 
			{
				m_changed=true;
				m_strCelular = value;
			}
		}

		/// <summary>
		/// Attribute for access the VehiculoCCosto's strTipoMotor value (double)
		/// </summary>
		[DataMember]
		public double? strTipoMotor
		{
			get { return m_strTipoMotor; }
			set 
			{
				m_changed=true;
				m_strTipoMotor = value;
			}
		}

		/// <summary>
		/// Attribute for access the VehiculoCCosto's strColor value (string)
		/// </summary>
		[DataMember]
		public string strColor
		{
			get { return m_strColor; }
			set 
			{
				m_changed=true;
				m_strColor = value;
			}
		}

		/// <summary>
		/// Attribute for access the VehiculoCCosto's strMotor value (string)
		/// </summary>
		[DataMember]
		public string strMotor
		{
			get { return m_strMotor; }
			set 
			{
				m_changed=true;
				m_strMotor = value;
			}
		}

		/// <summary>
		/// Attribute for access the VehiculoCCosto's strChasis value (string)
		/// </summary>
		[DataMember]
		public string strChasis
		{
			get { return m_strChasis; }
			set 
			{
				m_changed=true;
				m_strChasis = value;
			}
		}

		/// <summary>
		/// Attribute for access the VehiculoCCosto's logCamarote value (bool)
		/// </summary>
		[DataMember]
		public bool? logCamarote
		{
			get { return m_logCamarote; }
			set 
			{
				m_changed=true;
				m_logCamarote = value;
			}
		}

		/// <summary>
		/// Attribute for access the VehiculoCCosto's CapacidadGalores value (decimal)
		/// </summary>
		[DataMember]
		public decimal? CapacidadGalores
		{
			get { return m_CapacidadGalores; }
			set 
			{
				m_changed=true;
				m_CapacidadGalores = value;
			}
		}

		/// <summary>
		/// Attribute for access the VehiculoCCosto's floGalonesReserva value (decimal)
		/// </summary>
		[DataMember]
		public decimal? floGalonesReserva
		{
			get { return m_floGalonesReserva; }
			set 
			{
				m_changed=true;
				m_floGalonesReserva = value;
			}
		}

		/// <summary>
		/// Attribute for access the VehiculoCCosto's floCantGalonesReserva value (decimal)
		/// </summary>
		[DataMember]
		public decimal? floCantGalonesReserva
		{
			get { return m_floCantGalonesReserva; }
			set 
			{
				m_changed=true;
				m_floCantGalonesReserva = value;
			}
		}

		/// <summary>
		/// Attribute for access the VehiculoCCosto's floTolerancia value (decimal)
		/// </summary>
		[DataMember]
		public decimal? floTolerancia
		{
			get { return m_floTolerancia; }
			set 
			{
				m_changed=true;
				m_floTolerancia = value;
			}
		}

		/// <summary>
		/// Attribute for access the VehiculoCCosto's cutPeso value (double)
		/// </summary>
		[DataMember]
		public double? cutPeso
		{
			get { return m_cutPeso; }
			set 
			{
				m_changed=true;
				m_cutPeso = value;
			}
		}

		/// <summary>
		/// Attribute for access the VehiculoCCosto's cutCapacidad value (double)
		/// </summary>
		[DataMember]
		public double? cutCapacidad
		{
			get { return m_cutCapacidad; }
			set 
			{
				m_changed=true;
				m_cutCapacidad = value;
			}
		}

		/// <summary>
		/// Attribute for access the VehiculoCCosto's lngEjes value (double)
		/// </summary>
		[DataMember]
		public double? lngEjes
		{
			get { return m_lngEjes; }
			set 
			{
				m_changed=true;
				m_lngEjes = value;
			}
		}

		/// <summary>
		/// Attribute for access the VehiculoCCosto's logActivo value (double)
		/// </summary>
		[DataMember]
		public double? logActivo
		{
			get { return m_logActivo; }
			set 
			{
				m_changed=true;
				m_logActivo = value;
			}
		}

		/// <summary>
		/// Attribute for access the VehiculoCCosto's lngLlantas value (double)
		/// </summary>
		[DataMember]
		public double? lngLlantas
		{
			get { return m_lngLlantas; }
			set 
			{
				m_changed=true;
				m_lngLlantas = value;
			}
		}

		/// <summary>
		/// Attribute for access the VehiculoCCosto's strPolizaObligatorio value (string)
		/// </summary>
		[DataMember]
		public string strPolizaObligatorio
		{
			get { return m_strPolizaObligatorio; }
			set 
			{
				m_changed=true;
				m_strPolizaObligatorio = value;
			}
		}

		/// <summary>
		/// Attribute for access the VehiculoCCosto's nitProvedorOblig value (double)
		/// </summary>
		[DataMember]
		public double? nitProvedorOblig
		{
			get { return m_nitProvedorOblig; }
			set 
			{
				m_changed=true;
				m_nitProvedorOblig = value;
			}
		}

		/// <summary>
		/// Attribute for access the VehiculoCCosto's dtmFechaInicioOblig value (DateTime)
		/// </summary>
		[DataMember]
		public DateTime? dtmFechaInicioOblig
		{
			get { return m_dtmFechaInicioOblig; }
			set 
			{
				m_changed=true;
				m_dtmFechaInicioOblig = value;
			}
		}

		/// <summary>
		/// Attribute for access the VehiculoCCosto's dtmFechaVenceOblig value (DateTime)
		/// </summary>
		[DataMember]
		public DateTime? dtmFechaVenceOblig
		{
			get { return m_dtmFechaVenceOblig; }
			set 
			{
				m_changed=true;
				m_dtmFechaVenceOblig = value;
			}
		}

		/// <summary>
		/// Attribute for access the VehiculoCCosto's strPolizaTodoRiesgo value (string)
		/// </summary>
		[DataMember]
		public string strPolizaTodoRiesgo
		{
			get { return m_strPolizaTodoRiesgo; }
			set 
			{
				m_changed=true;
				m_strPolizaTodoRiesgo = value;
			}
		}

		/// <summary>
		/// Attribute for access the VehiculoCCosto's nitProvedorTodo value (double)
		/// </summary>
		[DataMember]
		public double? nitProvedorTodo
		{
			get { return m_nitProvedorTodo; }
			set 
			{
				m_changed=true;
				m_nitProvedorTodo = value;
			}
		}

		/// <summary>
		/// Attribute for access the VehiculoCCosto's dtmFechaInicioTodo value (DateTime)
		/// </summary>
		[DataMember]
		public DateTime? dtmFechaInicioTodo
		{
			get { return m_dtmFechaInicioTodo; }
			set 
			{
				m_changed=true;
				m_dtmFechaInicioTodo = value;
			}
		}

		/// <summary>
		/// Attribute for access the VehiculoCCosto's dtmFechaVenceTodo value (DateTime)
		/// </summary>
		[DataMember]
		public DateTime? dtmFechaVenceTodo
		{
			get { return m_dtmFechaVenceTodo; }
			set 
			{
				m_changed=true;
				m_dtmFechaVenceTodo = value;
			}
		}

		/// <summary>
		/// Attribute for access the VehiculoCCosto's strCertifMovilizacion value (string)
		/// </summary>
		[DataMember]
		public string strCertifMovilizacion
		{
			get { return m_strCertifMovilizacion; }
			set 
			{
				m_changed=true;
				m_strCertifMovilizacion = value;
			}
		}

		/// <summary>
		/// Attribute for access the VehiculoCCosto's dtmFechaInicioMoviliz value (DateTime)
		/// </summary>
		[DataMember]
		public DateTime? dtmFechaInicioMoviliz
		{
			get { return m_dtmFechaInicioMoviliz; }
			set 
			{
				m_changed=true;
				m_dtmFechaInicioMoviliz = value;
			}
		}

		/// <summary>
		/// Attribute for access the VehiculoCCosto's dtmFechaVenceMoviliz value (DateTime)
		/// </summary>
		[DataMember]
		public DateTime? dtmFechaVenceMoviliz
		{
			get { return m_dtmFechaVenceMoviliz; }
			set 
			{
				m_changed=true;
				m_dtmFechaVenceMoviliz = value;
			}
		}

		/// <summary>
		/// Attribute for access the VehiculoCCosto's strGases value (string)
		/// </summary>
		[DataMember]
		public string strGases
		{
			get { return m_strGases; }
			set 
			{
				m_changed=true;
				m_strGases = value;
			}
		}

		/// <summary>
		/// Attribute for access the VehiculoCCosto's dtmFechaInicioGases value (DateTime)
		/// </summary>
		[DataMember]
		public DateTime? dtmFechaInicioGases
		{
			get { return m_dtmFechaInicioGases; }
			set 
			{
				m_changed=true;
				m_dtmFechaInicioGases = value;
			}
		}

		/// <summary>
		/// Attribute for access the VehiculoCCosto's dtmFechaVenceGases value (DateTime)
		/// </summary>
		[DataMember]
		public DateTime? dtmFechaVenceGases
		{
			get { return m_dtmFechaVenceGases; }
			set 
			{
				m_changed=true;
				m_dtmFechaVenceGases = value;
			}
		}

		/// <summary>
		/// Attribute for access the VehiculoCCosto's strTarjetaOper value (string)
		/// </summary>
		[DataMember]
		public string strTarjetaOper
		{
			get { return m_strTarjetaOper; }
			set 
			{
				m_changed=true;
				m_strTarjetaOper = value;
			}
		}

		/// <summary>
		/// Attribute for access the VehiculoCCosto's dtmFechaInicioTarjetaOper value (DateTime)
		/// </summary>
		[DataMember]
		public DateTime? dtmFechaInicioTarjetaOper
		{
			get { return m_dtmFechaInicioTarjetaOper; }
			set 
			{
				m_changed=true;
				m_dtmFechaInicioTarjetaOper = value;
			}
		}

		/// <summary>
		/// Attribute for access the VehiculoCCosto's dtmFechaVenceTarjetaOper value (DateTime)
		/// </summary>
		[DataMember]
		public DateTime? dtmFechaVenceTarjetaOper
		{
			get { return m_dtmFechaVenceTarjetaOper; }
			set 
			{
				m_changed=true;
				m_dtmFechaVenceTarjetaOper = value;
			}
		}

		/// <summary>
		/// Attribute for access the VehiculoCCosto's logVencimientoFecha value (bool)
		/// </summary>
		[DataMember]
		public bool? logVencimientoFecha
		{
			get { return m_logVencimientoFecha; }
			set 
			{
				m_changed=true;
				m_logVencimientoFecha = value;
			}
		}

		/// <summary>
		/// Attribute for access the VehiculoCCosto's lngIdRegistro value (int)
		/// </summary>
		[DataMember]
		public int lngIdRegistro
		{
			get { return m_lngIdRegistro; }
			set 
			{
				m_changed=true;
				m_lngIdRegistro = value;
			}
		}

		public object GetAttribute(string pattribute)
		{
			switch (pattribute)
			{
				case "lngIdUsuario": return lngIdUsuario;
				case "strPlaca": return strPlaca;
				case "centro": return centro;
				case "TipoTrailerCodigo": return TipoTrailerCodigo;
				case "TipoVehiculoCodigo": return TipoVehiculoCodigo;
				case "Descripcion": return Descripcion;
				case "dtmFechaIngreso": return dtmFechaIngreso;
				case "dtmFechaEgreso": return dtmFechaEgreso;
				case "nitPropietario": return nitPropietario;
				case "strMarca": return strMarca;
				case "lngModelo": return lngModelo;
				case "lngMovil": return lngMovil;
				case "strCelular": return strCelular;
				case "strTipoMotor": return strTipoMotor;
				case "strColor": return strColor;
				case "strMotor": return strMotor;
				case "strChasis": return strChasis;
				case "logCamarote": return logCamarote;
				case "CapacidadGalores": return CapacidadGalores;
				case "floGalonesReserva": return floGalonesReserva;
				case "floCantGalonesReserva": return floCantGalonesReserva;
				case "floTolerancia": return floTolerancia;
				case "cutPeso": return cutPeso;
				case "cutCapacidad": return cutCapacidad;
				case "lngEjes": return lngEjes;
				case "logActivo": return logActivo;
				case "lngLlantas": return lngLlantas;
				case "strPolizaObligatorio": return strPolizaObligatorio;
				case "nitProvedorOblig": return nitProvedorOblig;
				case "dtmFechaInicioOblig": return dtmFechaInicioOblig;
				case "dtmFechaVenceOblig": return dtmFechaVenceOblig;
				case "strPolizaTodoRiesgo": return strPolizaTodoRiesgo;
				case "nitProvedorTodo": return nitProvedorTodo;
				case "dtmFechaInicioTodo": return dtmFechaInicioTodo;
				case "dtmFechaVenceTodo": return dtmFechaVenceTodo;
				case "strCertifMovilizacion": return strCertifMovilizacion;
				case "dtmFechaInicioMoviliz": return dtmFechaInicioMoviliz;
				case "dtmFechaVenceMoviliz": return dtmFechaVenceMoviliz;
				case "strGases": return strGases;
				case "dtmFechaInicioGases": return dtmFechaInicioGases;
				case "dtmFechaVenceGases": return dtmFechaVenceGases;
				case "strTarjetaOper": return strTarjetaOper;
				case "dtmFechaInicioTarjetaOper": return dtmFechaInicioTarjetaOper;
				case "dtmFechaVenceTarjetaOper": return dtmFechaVenceTarjetaOper;
				case "logVencimientoFecha": return logVencimientoFecha;
				case "lngIdRegistro": return lngIdRegistro;
				default: return null;
			}
		}

		public Type GetAttributeType(string pattribute)
		{
			return VehiculoCCostoController.Instance.GetMethodType(pattribute, this);
		}

		public string GetSqlKey()
		{
			return "[lngIdRegistro] = " + lngIdRegistro.ToString();
		}
		#endregion

	}

	#endregion

	#region VehiculoCCostoList object

	/// <summary>
	/// Class for reading and access a list of VehiculoCCosto object
	/// </summary>
	[CollectionDataContract]
	public partial class VehiculoCCostoList : List<VehiculoCCosto>
	{

		/// <summary>
		/// Default constructor
		/// </summary>
		public VehiculoCCostoList()
		{
		}
	}

	#endregion

}
