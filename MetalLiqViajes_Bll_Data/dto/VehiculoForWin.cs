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
	#region VehiculoForWin object

	[DataContract]
	public partial class VehiculoForWin : IDTOObject
	{
		/// <summary>
		/// Default constructor
		/// </summary>
		public VehiculoForWin()
		{
			m_lngIdRegistro = 0;
			m_lngIdUsuario = 0;
			m_strPlaca = 0;
			m_centro = null;
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
			m_logCamarote = null;
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
			m_logVencimientoFecha = null;
			m_changed=false;
		}
		        //Return the table name of object
		        public string TableName()
		        {
		            return "tblVehiculoForWin";
		        }
		#region Undo 
		// Internal class for storing changes
		private VehiculoForWin m_oldVehiculoForWin;
		public void GenerateUndo()
		{
			m_oldVehiculoForWin=new VehiculoForWin();
			m_oldVehiculoForWin.m_lngIdRegistro = m_lngIdRegistro;
			m_oldVehiculoForWin.m_lngIdUsuario = m_lngIdUsuario;
			m_oldVehiculoForWin.strPlaca = m_strPlaca;
			m_oldVehiculoForWin.centro = m_centro;
			m_oldVehiculoForWin.TipoVehiculoCodigo = m_TipoVehiculoCodigo;
			m_oldVehiculoForWin.Descripcion = m_Descripcion;
			m_oldVehiculoForWin.dtmFechaIngreso = m_dtmFechaIngreso;
			m_oldVehiculoForWin.dtmFechaEgreso = m_dtmFechaEgreso;
			m_oldVehiculoForWin.nitPropietario = m_nitPropietario;
			m_oldVehiculoForWin.strMarca = m_strMarca;
			m_oldVehiculoForWin.lngModelo = m_lngModelo;
			m_oldVehiculoForWin.lngMovil = m_lngMovil;
			m_oldVehiculoForWin.strCelular = m_strCelular;
			m_oldVehiculoForWin.strTipoMotor = m_strTipoMotor;
			m_oldVehiculoForWin.strColor = m_strColor;
			m_oldVehiculoForWin.strMotor = m_strMotor;
			m_oldVehiculoForWin.strChasis = m_strChasis;
			m_oldVehiculoForWin.logCamarote = m_logCamarote;
			m_oldVehiculoForWin.cutPeso = m_cutPeso;
			m_oldVehiculoForWin.cutCapacidad = m_cutCapacidad;
			m_oldVehiculoForWin.lngEjes = m_lngEjes;
			m_oldVehiculoForWin.logActivo = m_logActivo;
			m_oldVehiculoForWin.lngLlantas = m_lngLlantas;
			m_oldVehiculoForWin.strPolizaObligatorio = m_strPolizaObligatorio;
			m_oldVehiculoForWin.nitProvedorOblig = m_nitProvedorOblig;
			m_oldVehiculoForWin.dtmFechaInicioOblig = m_dtmFechaInicioOblig;
			m_oldVehiculoForWin.dtmFechaVenceOblig = m_dtmFechaVenceOblig;
			m_oldVehiculoForWin.strPolizaTodoRiesgo = m_strPolizaTodoRiesgo;
			m_oldVehiculoForWin.nitProvedorTodo = m_nitProvedorTodo;
			m_oldVehiculoForWin.dtmFechaInicioTodo = m_dtmFechaInicioTodo;
			m_oldVehiculoForWin.dtmFechaVenceTodo = m_dtmFechaVenceTodo;
			m_oldVehiculoForWin.strCertifMovilizacion = m_strCertifMovilizacion;
			m_oldVehiculoForWin.dtmFechaInicioMoviliz = m_dtmFechaInicioMoviliz;
			m_oldVehiculoForWin.dtmFechaVenceMoviliz = m_dtmFechaVenceMoviliz;
			m_oldVehiculoForWin.strGases = m_strGases;
			m_oldVehiculoForWin.dtmFechaInicioGases = m_dtmFechaInicioGases;
			m_oldVehiculoForWin.dtmFechaVenceGases = m_dtmFechaVenceGases;
			m_oldVehiculoForWin.strTarjetaOper = m_strTarjetaOper;
			m_oldVehiculoForWin.dtmFechaInicioTarjetaOper = m_dtmFechaInicioTarjetaOper;
			m_oldVehiculoForWin.dtmFechaVenceTarjetaOper = m_dtmFechaVenceTarjetaOper;
			m_oldVehiculoForWin.logVencimientoFecha = m_logVencimientoFecha;
		}

		public VehiculoForWin OldVehiculoForWin
		{
			get { return m_oldVehiculoForWin;}
		}
		// Return the changed fields
		public string[] FieldChanged()
		{
			List<string> fields=new List<string>();
			if (m_oldVehiculoForWin.strPlaca != m_strPlaca) fields.Add("strPlaca");
			if (m_oldVehiculoForWin.centro != m_centro) fields.Add("centro");
			if (m_oldVehiculoForWin.TipoVehiculoCodigo != m_TipoVehiculoCodigo) fields.Add("TipoVehiculoCodigo");
			if (m_oldVehiculoForWin.Descripcion != m_Descripcion) fields.Add("Descripcion");
			if (m_oldVehiculoForWin.dtmFechaIngreso != m_dtmFechaIngreso) fields.Add("dtmFechaIngreso");
			if (m_oldVehiculoForWin.dtmFechaEgreso != m_dtmFechaEgreso) fields.Add("dtmFechaEgreso");
			if (m_oldVehiculoForWin.nitPropietario != m_nitPropietario) fields.Add("nitPropietario");
			if (m_oldVehiculoForWin.strMarca != m_strMarca) fields.Add("strMarca");
			if (m_oldVehiculoForWin.lngModelo != m_lngModelo) fields.Add("lngModelo");
			if (m_oldVehiculoForWin.lngMovil != m_lngMovil) fields.Add("lngMovil");
			if (m_oldVehiculoForWin.strCelular != m_strCelular) fields.Add("strCelular");
			if (m_oldVehiculoForWin.strTipoMotor != m_strTipoMotor) fields.Add("strTipoMotor");
			if (m_oldVehiculoForWin.strColor != m_strColor) fields.Add("strColor");
			if (m_oldVehiculoForWin.strMotor != m_strMotor) fields.Add("strMotor");
			if (m_oldVehiculoForWin.strChasis != m_strChasis) fields.Add("strChasis");
			if (m_oldVehiculoForWin.logCamarote != m_logCamarote) fields.Add("logCamarote");
			if (m_oldVehiculoForWin.cutPeso != m_cutPeso) fields.Add("cutPeso");
			if (m_oldVehiculoForWin.cutCapacidad != m_cutCapacidad) fields.Add("cutCapacidad");
			if (m_oldVehiculoForWin.lngEjes != m_lngEjes) fields.Add("lngEjes");
			if (m_oldVehiculoForWin.logActivo != m_logActivo) fields.Add("logActivo");
			if (m_oldVehiculoForWin.lngLlantas != m_lngLlantas) fields.Add("lngLlantas");
			if (m_oldVehiculoForWin.strPolizaObligatorio != m_strPolizaObligatorio) fields.Add("strPolizaObligatorio");
			if (m_oldVehiculoForWin.nitProvedorOblig != m_nitProvedorOblig) fields.Add("nitProvedorOblig");
			if (m_oldVehiculoForWin.dtmFechaInicioOblig != m_dtmFechaInicioOblig) fields.Add("dtmFechaInicioOblig");
			if (m_oldVehiculoForWin.dtmFechaVenceOblig != m_dtmFechaVenceOblig) fields.Add("dtmFechaVenceOblig");
			if (m_oldVehiculoForWin.strPolizaTodoRiesgo != m_strPolizaTodoRiesgo) fields.Add("strPolizaTodoRiesgo");
			if (m_oldVehiculoForWin.nitProvedorTodo != m_nitProvedorTodo) fields.Add("nitProvedorTodo");
			if (m_oldVehiculoForWin.dtmFechaInicioTodo != m_dtmFechaInicioTodo) fields.Add("dtmFechaInicioTodo");
			if (m_oldVehiculoForWin.dtmFechaVenceTodo != m_dtmFechaVenceTodo) fields.Add("dtmFechaVenceTodo");
			if (m_oldVehiculoForWin.strCertifMovilizacion != m_strCertifMovilizacion) fields.Add("strCertifMovilizacion");
			if (m_oldVehiculoForWin.dtmFechaInicioMoviliz != m_dtmFechaInicioMoviliz) fields.Add("dtmFechaInicioMoviliz");
			if (m_oldVehiculoForWin.dtmFechaVenceMoviliz != m_dtmFechaVenceMoviliz) fields.Add("dtmFechaVenceMoviliz");
			if (m_oldVehiculoForWin.strGases != m_strGases) fields.Add("strGases");
			if (m_oldVehiculoForWin.dtmFechaInicioGases != m_dtmFechaInicioGases) fields.Add("dtmFechaInicioGases");
			if (m_oldVehiculoForWin.dtmFechaVenceGases != m_dtmFechaVenceGases) fields.Add("dtmFechaVenceGases");
			if (m_oldVehiculoForWin.strTarjetaOper != m_strTarjetaOper) fields.Add("strTarjetaOper");
			if (m_oldVehiculoForWin.dtmFechaInicioTarjetaOper != m_dtmFechaInicioTarjetaOper) fields.Add("dtmFechaInicioTarjetaOper");
			if (m_oldVehiculoForWin.dtmFechaVenceTarjetaOper != m_dtmFechaVenceTarjetaOper) fields.Add("dtmFechaVenceTarjetaOper");
			if (m_oldVehiculoForWin.logVencimientoFecha != m_logVencimientoFecha) fields.Add("logVencimientoFecha");
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


		// Field for storing the VehiculoForWin's strPlaca value
		private int m_strPlaca;

		// Field for storing the VehiculoForWin's centro value
		private int? m_centro;

		// Field for storing the VehiculoForWin's TipoVehiculoCodigo value
		private int? m_TipoVehiculoCodigo;

		// Field for storing the VehiculoForWin's Descripcion value
		private string m_Descripcion;

		// Field for storing the VehiculoForWin's dtmFechaIngreso value
		private int? m_dtmFechaIngreso;

		// Field for storing the VehiculoForWin's dtmFechaEgreso value
		private int? m_dtmFechaEgreso;

		// Field for storing the VehiculoForWin's nitPropietario value
		private int? m_nitPropietario;

		// Field for storing the VehiculoForWin's strMarca value
		private int? m_strMarca;

		// Field for storing the VehiculoForWin's lngModelo value
		private int? m_lngModelo;

		// Field for storing the VehiculoForWin's lngMovil value
		private int? m_lngMovil;

		// Field for storing the VehiculoForWin's strCelular value
		private int? m_strCelular;

		// Field for storing the VehiculoForWin's strTipoMotor value
		private int? m_strTipoMotor;

		// Field for storing the VehiculoForWin's strColor value
		private int? m_strColor;

		// Field for storing the VehiculoForWin's strMotor value
		private int? m_strMotor;

		// Field for storing the VehiculoForWin's strChasis value
		private int? m_strChasis;

		// Field for storing the VehiculoForWin's logCamarote value
		private int? m_logCamarote;

		// Field for storing the VehiculoForWin's cutPeso value
		private int? m_cutPeso;

		// Field for storing the VehiculoForWin's cutCapacidad value
		private int? m_cutCapacidad;

		// Field for storing the VehiculoForWin's lngEjes value
		private int? m_lngEjes;

		// Field for storing the VehiculoForWin's logActivo value
		private int? m_logActivo;

		// Field for storing the VehiculoForWin's lngLlantas value
		private int? m_lngLlantas;

		// Field for storing the VehiculoForWin's strPolizaObligatorio value
		private int? m_strPolizaObligatorio;

		// Field for storing the VehiculoForWin's nitProvedorOblig value
		private int? m_nitProvedorOblig;

		// Field for storing the VehiculoForWin's dtmFechaInicioOblig value
		private int? m_dtmFechaInicioOblig;

		// Field for storing the VehiculoForWin's dtmFechaVenceOblig value
		private int? m_dtmFechaVenceOblig;

		// Field for storing the VehiculoForWin's strPolizaTodoRiesgo value
		private int? m_strPolizaTodoRiesgo;

		// Field for storing the VehiculoForWin's nitProvedorTodo value
		private int? m_nitProvedorTodo;

		// Field for storing the VehiculoForWin's dtmFechaInicioTodo value
		private int? m_dtmFechaInicioTodo;

		// Field for storing the VehiculoForWin's dtmFechaVenceTodo value
		private int? m_dtmFechaVenceTodo;

		// Field for storing the VehiculoForWin's strCertifMovilizacion value
		private int? m_strCertifMovilizacion;

		// Field for storing the VehiculoForWin's dtmFechaInicioMoviliz value
		private int? m_dtmFechaInicioMoviliz;

		// Field for storing the VehiculoForWin's dtmFechaVenceMoviliz value
		private int? m_dtmFechaVenceMoviliz;

		// Field for storing the VehiculoForWin's strGases value
		private int? m_strGases;

		// Field for storing the VehiculoForWin's dtmFechaInicioGases value
		private int? m_dtmFechaInicioGases;

		// Field for storing the VehiculoForWin's dtmFechaVenceGases value
		private int? m_dtmFechaVenceGases;

		// Field for storing the VehiculoForWin's strTarjetaOper value
		private int? m_strTarjetaOper;

		// Field for storing the VehiculoForWin's dtmFechaInicioTarjetaOper value
		private int? m_dtmFechaInicioTarjetaOper;

		// Field for storing the VehiculoForWin's dtmFechaVenceTarjetaOper value
		private int? m_dtmFechaVenceTarjetaOper;

		// Field for storing the VehiculoForWin's logVencimientoFecha value
		private int? m_logVencimientoFecha;

		// Field for storing the VehiculoForWin's lngIdRegistro value
		private int m_lngIdRegistro;

		// Field for storing the VehiculoForWin's lngIdUsuario value
		private int m_lngIdUsuario;

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
		/// Attribute for access the VehiculoForWin's strPlaca value (int)
		/// </summary>
		[DataMember]
		public int strPlaca
		{
			get { return m_strPlaca; }
			set 
			{
				m_changed=true;
				m_strPlaca = value;
			}
		}

		/// <summary>
		/// Attribute for access the VehiculoForWin's centro value (int)
		/// </summary>
		[DataMember]
		public int? centro
		{
			get { return m_centro; }
			set 
			{
				m_changed=true;
				m_centro = value;
			}
		}

		/// <summary>
		/// Attribute for access the VehiculoForWin's TipoVehiculoCodigo value (int)
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
		/// Attribute for access the VehiculoForWin's Descripcion value (string)
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
		/// Attribute for access the VehiculoForWin's dtmFechaIngreso value (int)
		/// </summary>
		[DataMember]
		public int? dtmFechaIngreso
		{
			get { return m_dtmFechaIngreso; }
			set 
			{
				m_changed=true;
				m_dtmFechaIngreso = value;
			}
		}

		/// <summary>
		/// Attribute for access the VehiculoForWin's dtmFechaEgreso value (int)
		/// </summary>
		[DataMember]
		public int? dtmFechaEgreso
		{
			get { return m_dtmFechaEgreso; }
			set 
			{
				m_changed=true;
				m_dtmFechaEgreso = value;
			}
		}

		/// <summary>
		/// Attribute for access the VehiculoForWin's nitPropietario value (int)
		/// </summary>
		[DataMember]
		public int? nitPropietario
		{
			get { return m_nitPropietario; }
			set 
			{
				m_changed=true;
				m_nitPropietario = value;
			}
		}

		/// <summary>
		/// Attribute for access the VehiculoForWin's strMarca value (int)
		/// </summary>
		[DataMember]
		public int? strMarca
		{
			get { return m_strMarca; }
			set 
			{
				m_changed=true;
				m_strMarca = value;
			}
		}

		/// <summary>
		/// Attribute for access the VehiculoForWin's lngModelo value (int)
		/// </summary>
		[DataMember]
		public int? lngModelo
		{
			get { return m_lngModelo; }
			set 
			{
				m_changed=true;
				m_lngModelo = value;
			}
		}

		/// <summary>
		/// Attribute for access the VehiculoForWin's lngMovil value (int)
		/// </summary>
		[DataMember]
		public int? lngMovil
		{
			get { return m_lngMovil; }
			set 
			{
				m_changed=true;
				m_lngMovil = value;
			}
		}

		/// <summary>
		/// Attribute for access the VehiculoForWin's strCelular value (int)
		/// </summary>
		[DataMember]
		public int? strCelular
		{
			get { return m_strCelular; }
			set 
			{
				m_changed=true;
				m_strCelular = value;
			}
		}

		/// <summary>
		/// Attribute for access the VehiculoForWin's strTipoMotor value (int)
		/// </summary>
		[DataMember]
		public int? strTipoMotor
		{
			get { return m_strTipoMotor; }
			set 
			{
				m_changed=true;
				m_strTipoMotor = value;
			}
		}

		/// <summary>
		/// Attribute for access the VehiculoForWin's strColor value (int)
		/// </summary>
		[DataMember]
		public int? strColor
		{
			get { return m_strColor; }
			set 
			{
				m_changed=true;
				m_strColor = value;
			}
		}

		/// <summary>
		/// Attribute for access the VehiculoForWin's strMotor value (int)
		/// </summary>
		[DataMember]
		public int? strMotor
		{
			get { return m_strMotor; }
			set 
			{
				m_changed=true;
				m_strMotor = value;
			}
		}

		/// <summary>
		/// Attribute for access the VehiculoForWin's strChasis value (int)
		/// </summary>
		[DataMember]
		public int? strChasis
		{
			get { return m_strChasis; }
			set 
			{
				m_changed=true;
				m_strChasis = value;
			}
		}

		/// <summary>
		/// Attribute for access the VehiculoForWin's logCamarote value (int)
		/// </summary>
		[DataMember]
		public int? logCamarote
		{
			get { return m_logCamarote; }
			set 
			{
				m_changed=true;
				m_logCamarote = value;
			}
		}

		/// <summary>
		/// Attribute for access the VehiculoForWin's cutPeso value (int)
		/// </summary>
		[DataMember]
		public int? cutPeso
		{
			get { return m_cutPeso; }
			set 
			{
				m_changed=true;
				m_cutPeso = value;
			}
		}

		/// <summary>
		/// Attribute for access the VehiculoForWin's cutCapacidad value (int)
		/// </summary>
		[DataMember]
		public int? cutCapacidad
		{
			get { return m_cutCapacidad; }
			set 
			{
				m_changed=true;
				m_cutCapacidad = value;
			}
		}

		/// <summary>
		/// Attribute for access the VehiculoForWin's lngEjes value (int)
		/// </summary>
		[DataMember]
		public int? lngEjes
		{
			get { return m_lngEjes; }
			set 
			{
				m_changed=true;
				m_lngEjes = value;
			}
		}

		/// <summary>
		/// Attribute for access the VehiculoForWin's logActivo value (int)
		/// </summary>
		[DataMember]
		public int? logActivo
		{
			get { return m_logActivo; }
			set 
			{
				m_changed=true;
				m_logActivo = value;
			}
		}

		/// <summary>
		/// Attribute for access the VehiculoForWin's lngLlantas value (int)
		/// </summary>
		[DataMember]
		public int? lngLlantas
		{
			get { return m_lngLlantas; }
			set 
			{
				m_changed=true;
				m_lngLlantas = value;
			}
		}

		/// <summary>
		/// Attribute for access the VehiculoForWin's strPolizaObligatorio value (int)
		/// </summary>
		[DataMember]
		public int? strPolizaObligatorio
		{
			get { return m_strPolizaObligatorio; }
			set 
			{
				m_changed=true;
				m_strPolizaObligatorio = value;
			}
		}

		/// <summary>
		/// Attribute for access the VehiculoForWin's nitProvedorOblig value (int)
		/// </summary>
		[DataMember]
		public int? nitProvedorOblig
		{
			get { return m_nitProvedorOblig; }
			set 
			{
				m_changed=true;
				m_nitProvedorOblig = value;
			}
		}

		/// <summary>
		/// Attribute for access the VehiculoForWin's dtmFechaInicioOblig value (int)
		/// </summary>
		[DataMember]
		public int? dtmFechaInicioOblig
		{
			get { return m_dtmFechaInicioOblig; }
			set 
			{
				m_changed=true;
				m_dtmFechaInicioOblig = value;
			}
		}

		/// <summary>
		/// Attribute for access the VehiculoForWin's dtmFechaVenceOblig value (int)
		/// </summary>
		[DataMember]
		public int? dtmFechaVenceOblig
		{
			get { return m_dtmFechaVenceOblig; }
			set 
			{
				m_changed=true;
				m_dtmFechaVenceOblig = value;
			}
		}

		/// <summary>
		/// Attribute for access the VehiculoForWin's strPolizaTodoRiesgo value (int)
		/// </summary>
		[DataMember]
		public int? strPolizaTodoRiesgo
		{
			get { return m_strPolizaTodoRiesgo; }
			set 
			{
				m_changed=true;
				m_strPolizaTodoRiesgo = value;
			}
		}

		/// <summary>
		/// Attribute for access the VehiculoForWin's nitProvedorTodo value (int)
		/// </summary>
		[DataMember]
		public int? nitProvedorTodo
		{
			get { return m_nitProvedorTodo; }
			set 
			{
				m_changed=true;
				m_nitProvedorTodo = value;
			}
		}

		/// <summary>
		/// Attribute for access the VehiculoForWin's dtmFechaInicioTodo value (int)
		/// </summary>
		[DataMember]
		public int? dtmFechaInicioTodo
		{
			get { return m_dtmFechaInicioTodo; }
			set 
			{
				m_changed=true;
				m_dtmFechaInicioTodo = value;
			}
		}

		/// <summary>
		/// Attribute for access the VehiculoForWin's dtmFechaVenceTodo value (int)
		/// </summary>
		[DataMember]
		public int? dtmFechaVenceTodo
		{
			get { return m_dtmFechaVenceTodo; }
			set 
			{
				m_changed=true;
				m_dtmFechaVenceTodo = value;
			}
		}

		/// <summary>
		/// Attribute for access the VehiculoForWin's strCertifMovilizacion value (int)
		/// </summary>
		[DataMember]
		public int? strCertifMovilizacion
		{
			get { return m_strCertifMovilizacion; }
			set 
			{
				m_changed=true;
				m_strCertifMovilizacion = value;
			}
		}

		/// <summary>
		/// Attribute for access the VehiculoForWin's dtmFechaInicioMoviliz value (int)
		/// </summary>
		[DataMember]
		public int? dtmFechaInicioMoviliz
		{
			get { return m_dtmFechaInicioMoviliz; }
			set 
			{
				m_changed=true;
				m_dtmFechaInicioMoviliz = value;
			}
		}

		/// <summary>
		/// Attribute for access the VehiculoForWin's dtmFechaVenceMoviliz value (int)
		/// </summary>
		[DataMember]
		public int? dtmFechaVenceMoviliz
		{
			get { return m_dtmFechaVenceMoviliz; }
			set 
			{
				m_changed=true;
				m_dtmFechaVenceMoviliz = value;
			}
		}

		/// <summary>
		/// Attribute for access the VehiculoForWin's strGases value (int)
		/// </summary>
		[DataMember]
		public int? strGases
		{
			get { return m_strGases; }
			set 
			{
				m_changed=true;
				m_strGases = value;
			}
		}

		/// <summary>
		/// Attribute for access the VehiculoForWin's dtmFechaInicioGases value (int)
		/// </summary>
		[DataMember]
		public int? dtmFechaInicioGases
		{
			get { return m_dtmFechaInicioGases; }
			set 
			{
				m_changed=true;
				m_dtmFechaInicioGases = value;
			}
		}

		/// <summary>
		/// Attribute for access the VehiculoForWin's dtmFechaVenceGases value (int)
		/// </summary>
		[DataMember]
		public int? dtmFechaVenceGases
		{
			get { return m_dtmFechaVenceGases; }
			set 
			{
				m_changed=true;
				m_dtmFechaVenceGases = value;
			}
		}

		/// <summary>
		/// Attribute for access the VehiculoForWin's strTarjetaOper value (int)
		/// </summary>
		[DataMember]
		public int? strTarjetaOper
		{
			get { return m_strTarjetaOper; }
			set 
			{
				m_changed=true;
				m_strTarjetaOper = value;
			}
		}

		/// <summary>
		/// Attribute for access the VehiculoForWin's dtmFechaInicioTarjetaOper value (int)
		/// </summary>
		[DataMember]
		public int? dtmFechaInicioTarjetaOper
		{
			get { return m_dtmFechaInicioTarjetaOper; }
			set 
			{
				m_changed=true;
				m_dtmFechaInicioTarjetaOper = value;
			}
		}

		/// <summary>
		/// Attribute for access the VehiculoForWin's dtmFechaVenceTarjetaOper value (int)
		/// </summary>
		[DataMember]
		public int? dtmFechaVenceTarjetaOper
		{
			get { return m_dtmFechaVenceTarjetaOper; }
			set 
			{
				m_changed=true;
				m_dtmFechaVenceTarjetaOper = value;
			}
		}

		/// <summary>
		/// Attribute for access the VehiculoForWin's logVencimientoFecha value (int)
		/// </summary>
		[DataMember]
		public int? logVencimientoFecha
		{
			get { return m_logVencimientoFecha; }
			set 
			{
				m_changed=true;
				m_logVencimientoFecha = value;
			}
		}

		/// <summary>
		/// Attribute for access the VehiculoForWin's lngIdRegistro value (int)
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

		/// <summary>
		/// Attribute for access the VehiculoForWin's lngIdUsuario value (int)
		/// </summary>
		[DataMember]
		public int lngIdUsuario
		{
			get { return m_lngIdUsuario; }
			set 
			{
				m_changed=true;
				m_lngIdUsuario = value;
			}
		}

		public object GetAttribute(string pattribute)
		{
			switch (pattribute)
			{
				case "strPlaca": return strPlaca;
				case "centro": return centro;
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
				case "lngIdUsuario": return lngIdUsuario;
				default: return null;
			}
		}

		public Type GetAttributeType(string pattribute)
		{
			return VehiculoForWinController.Instance.GetMethodType(pattribute, this);
		}

		public string GetSqlKey()
		{
			return "[lngIdRegistro] = " + lngIdRegistro.ToString() + " AND [lngIdUsuario] = " + lngIdUsuario.ToString();
		}
		#endregion

	}

	#endregion

	#region VehiculoForWinList object

	/// <summary>
	/// Class for reading and access a list of VehiculoForWin object
	/// </summary>
	[CollectionDataContract]
	public partial class VehiculoForWinList : List<VehiculoForWin>
	{

		/// <summary>
		/// Default constructor
		/// </summary>
		public VehiculoForWinList()
		{
		}
	}

	#endregion

}
