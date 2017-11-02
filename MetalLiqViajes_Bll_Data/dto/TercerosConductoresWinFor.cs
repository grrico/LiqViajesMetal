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
	#region TercerosConductoresWinFor object

	[DataContract]
	public partial class TercerosConductoresWinFor : IDTOObject
	{
		/// <summary>
		/// Default constructor
		/// </summary>
		public TercerosConductoresWinFor()
		{
			m_lngIdRegistro = 0;
			m_lngIdUsuario = 0;
			m_strTipoIdentificacion = null;
			m_IntNit = null;
			m_intDigito = null;
			m_strNombres = null;
			m_strDireccion = null;
			m_logEstado = null;
			m_logConductor = null;
			m_strPlaca = null;
			m_lngIdCiudad = null;
			m_strTelefono = null;
			m_strTelefonoAux = null;
			m_strTelCelular = null;
			m_strTelCelularAux = null;
			m_strFax = null;
			m_IntAAereo = null;
			m_StrPais = null;
			m_nitProvedor = null;
			m_intNoLicenciaConduc = null;
			m_intCategoria = null;
			m_strTarjetaTripulante = null;
			m_dtmFechaVenceLicencia = null;
			m_dtmVenceTarjetaTripulante = null;
			m_strCarnetEmpresa = null;
			m_strCarnetComunicaciones = null;
			m_changed=false;
		}
		        //Return the table name of object
		        public string TableName()
		        {
		            return "tblTercerosConductoresWinFor";
		        }
		#region Undo 
		// Internal class for storing changes
		private TercerosConductoresWinFor m_oldTercerosConductoresWinFor;
		public void GenerateUndo()
		{
			m_oldTercerosConductoresWinFor=new TercerosConductoresWinFor();
			m_oldTercerosConductoresWinFor.m_lngIdRegistro = m_lngIdRegistro;
			m_oldTercerosConductoresWinFor.m_lngIdUsuario = m_lngIdUsuario;
			m_oldTercerosConductoresWinFor.strTipoIdentificacion = m_strTipoIdentificacion;
			m_oldTercerosConductoresWinFor.IntNit = m_IntNit;
			m_oldTercerosConductoresWinFor.intDigito = m_intDigito;
			m_oldTercerosConductoresWinFor.strNombres = m_strNombres;
			m_oldTercerosConductoresWinFor.strDireccion = m_strDireccion;
			m_oldTercerosConductoresWinFor.logEstado = m_logEstado;
			m_oldTercerosConductoresWinFor.logConductor = m_logConductor;
			m_oldTercerosConductoresWinFor.strPlaca = m_strPlaca;
			m_oldTercerosConductoresWinFor.lngIdCiudad = m_lngIdCiudad;
			m_oldTercerosConductoresWinFor.strTelefono = m_strTelefono;
			m_oldTercerosConductoresWinFor.strTelefonoAux = m_strTelefonoAux;
			m_oldTercerosConductoresWinFor.strTelCelular = m_strTelCelular;
			m_oldTercerosConductoresWinFor.strTelCelularAux = m_strTelCelularAux;
			m_oldTercerosConductoresWinFor.strFax = m_strFax;
			m_oldTercerosConductoresWinFor.IntAAereo = m_IntAAereo;
			m_oldTercerosConductoresWinFor.StrPais = m_StrPais;
			m_oldTercerosConductoresWinFor.nitProvedor = m_nitProvedor;
			m_oldTercerosConductoresWinFor.intNoLicenciaConduc = m_intNoLicenciaConduc;
			m_oldTercerosConductoresWinFor.intCategoria = m_intCategoria;
			m_oldTercerosConductoresWinFor.strTarjetaTripulante = m_strTarjetaTripulante;
			m_oldTercerosConductoresWinFor.dtmFechaVenceLicencia = m_dtmFechaVenceLicencia;
			m_oldTercerosConductoresWinFor.dtmVenceTarjetaTripulante = m_dtmVenceTarjetaTripulante;
			m_oldTercerosConductoresWinFor.strCarnetEmpresa = m_strCarnetEmpresa;
			m_oldTercerosConductoresWinFor.strCarnetComunicaciones = m_strCarnetComunicaciones;
		}

		public TercerosConductoresWinFor OldTercerosConductoresWinFor
		{
			get { return m_oldTercerosConductoresWinFor;}
		}
		// Return the changed fields
		public string[] FieldChanged()
		{
			List<string> fields=new List<string>();
			if (m_oldTercerosConductoresWinFor.strTipoIdentificacion != m_strTipoIdentificacion) fields.Add("strTipoIdentificacion");
			if (m_oldTercerosConductoresWinFor.IntNit != m_IntNit) fields.Add("IntNit");
			if (m_oldTercerosConductoresWinFor.intDigito != m_intDigito) fields.Add("intDigito");
			if (m_oldTercerosConductoresWinFor.strNombres != m_strNombres) fields.Add("strNombres");
			if (m_oldTercerosConductoresWinFor.strDireccion != m_strDireccion) fields.Add("strDireccion");
			if (m_oldTercerosConductoresWinFor.logEstado != m_logEstado) fields.Add("logEstado");
			if (m_oldTercerosConductoresWinFor.logConductor != m_logConductor) fields.Add("logConductor");
			if (m_oldTercerosConductoresWinFor.strPlaca != m_strPlaca) fields.Add("strPlaca");
			if (m_oldTercerosConductoresWinFor.lngIdCiudad != m_lngIdCiudad) fields.Add("lngIdCiudad");
			if (m_oldTercerosConductoresWinFor.strTelefono != m_strTelefono) fields.Add("strTelefono");
			if (m_oldTercerosConductoresWinFor.strTelefonoAux != m_strTelefonoAux) fields.Add("strTelefonoAux");
			if (m_oldTercerosConductoresWinFor.strTelCelular != m_strTelCelular) fields.Add("strTelCelular");
			if (m_oldTercerosConductoresWinFor.strTelCelularAux != m_strTelCelularAux) fields.Add("strTelCelularAux");
			if (m_oldTercerosConductoresWinFor.strFax != m_strFax) fields.Add("strFax");
			if (m_oldTercerosConductoresWinFor.IntAAereo != m_IntAAereo) fields.Add("IntAAereo");
			if (m_oldTercerosConductoresWinFor.StrPais != m_StrPais) fields.Add("StrPais");
			if (m_oldTercerosConductoresWinFor.nitProvedor != m_nitProvedor) fields.Add("nitProvedor");
			if (m_oldTercerosConductoresWinFor.intNoLicenciaConduc != m_intNoLicenciaConduc) fields.Add("intNoLicenciaConduc");
			if (m_oldTercerosConductoresWinFor.intCategoria != m_intCategoria) fields.Add("intCategoria");
			if (m_oldTercerosConductoresWinFor.strTarjetaTripulante != m_strTarjetaTripulante) fields.Add("strTarjetaTripulante");
			if (m_oldTercerosConductoresWinFor.dtmFechaVenceLicencia != m_dtmFechaVenceLicencia) fields.Add("dtmFechaVenceLicencia");
			if (m_oldTercerosConductoresWinFor.dtmVenceTarjetaTripulante != m_dtmVenceTarjetaTripulante) fields.Add("dtmVenceTarjetaTripulante");
			if (m_oldTercerosConductoresWinFor.strCarnetEmpresa != m_strCarnetEmpresa) fields.Add("strCarnetEmpresa");
			if (m_oldTercerosConductoresWinFor.strCarnetComunicaciones != m_strCarnetComunicaciones) fields.Add("strCarnetComunicaciones");
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


		// Field for storing the TercerosConductoresWinFor's lngIdRegistro value
		private int m_lngIdRegistro;

		// Field for storing the TercerosConductoresWinFor's lngIdUsuario value
		private int m_lngIdUsuario;

		// Field for storing the TercerosConductoresWinFor's strTipoIdentificacion value
		private int? m_strTipoIdentificacion;

		// Field for storing the TercerosConductoresWinFor's IntNit value
		private int? m_IntNit;

		// Field for storing the TercerosConductoresWinFor's intDigito value
		private int? m_intDigito;

		// Field for storing the TercerosConductoresWinFor's strNombres value
		private int? m_strNombres;

		// Field for storing the TercerosConductoresWinFor's strDireccion value
		private int? m_strDireccion;

		// Field for storing the TercerosConductoresWinFor's logEstado value
		private int? m_logEstado;

		// Field for storing the TercerosConductoresWinFor's logConductor value
		private int? m_logConductor;

		// Field for storing the TercerosConductoresWinFor's strPlaca value
		private int? m_strPlaca;

		// Field for storing the TercerosConductoresWinFor's lngIdCiudad value
		private int? m_lngIdCiudad;

		// Field for storing the TercerosConductoresWinFor's strTelefono value
		private int? m_strTelefono;

		// Field for storing the TercerosConductoresWinFor's strTelefonoAux value
		private int? m_strTelefonoAux;

		// Field for storing the TercerosConductoresWinFor's strTelCelular value
		private int? m_strTelCelular;

		// Field for storing the TercerosConductoresWinFor's strTelCelularAux value
		private int? m_strTelCelularAux;

		// Field for storing the TercerosConductoresWinFor's strFax value
		private int? m_strFax;

		// Field for storing the TercerosConductoresWinFor's IntAAereo value
		private int? m_IntAAereo;

		// Field for storing the TercerosConductoresWinFor's StrPais value
		private int? m_StrPais;

		// Field for storing the TercerosConductoresWinFor's nitProvedor value
		private int? m_nitProvedor;

		// Field for storing the TercerosConductoresWinFor's intNoLicenciaConduc value
		private int? m_intNoLicenciaConduc;

		// Field for storing the TercerosConductoresWinFor's intCategoria value
		private int? m_intCategoria;

		// Field for storing the TercerosConductoresWinFor's strTarjetaTripulante value
		private int? m_strTarjetaTripulante;

		// Field for storing the TercerosConductoresWinFor's dtmFechaVenceLicencia value
		private int? m_dtmFechaVenceLicencia;

		// Field for storing the TercerosConductoresWinFor's dtmVenceTarjetaTripulante value
		private int? m_dtmVenceTarjetaTripulante;

		// Field for storing the TercerosConductoresWinFor's strCarnetEmpresa value
		private int? m_strCarnetEmpresa;

		// Field for storing the TercerosConductoresWinFor's strCarnetComunicaciones value
		private int? m_strCarnetComunicaciones;

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
		/// Attribute for access the TercerosConductoresWinFor's lngIdRegistro value (int)
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
		/// Attribute for access the TercerosConductoresWinFor's lngIdUsuario value (int)
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

		/// <summary>
		/// Attribute for access the TercerosConductoresWinFor's strTipoIdentificacion value (int)
		/// </summary>
		[DataMember]
		public int? strTipoIdentificacion
		{
			get { return m_strTipoIdentificacion; }
			set 
			{
				m_changed=true;
				m_strTipoIdentificacion = value;
			}
		}

		/// <summary>
		/// Attribute for access the TercerosConductoresWinFor's IntNit value (int)
		/// </summary>
		[DataMember]
		public int? IntNit
		{
			get { return m_IntNit; }
			set 
			{
				m_changed=true;
				m_IntNit = value;
			}
		}

		/// <summary>
		/// Attribute for access the TercerosConductoresWinFor's intDigito value (int)
		/// </summary>
		[DataMember]
		public int? intDigito
		{
			get { return m_intDigito; }
			set 
			{
				m_changed=true;
				m_intDigito = value;
			}
		}

		/// <summary>
		/// Attribute for access the TercerosConductoresWinFor's strNombres value (int)
		/// </summary>
		[DataMember]
		public int? strNombres
		{
			get { return m_strNombres; }
			set 
			{
				m_changed=true;
				m_strNombres = value;
			}
		}

		/// <summary>
		/// Attribute for access the TercerosConductoresWinFor's strDireccion value (int)
		/// </summary>
		[DataMember]
		public int? strDireccion
		{
			get { return m_strDireccion; }
			set 
			{
				m_changed=true;
				m_strDireccion = value;
			}
		}

		/// <summary>
		/// Attribute for access the TercerosConductoresWinFor's logEstado value (int)
		/// </summary>
		[DataMember]
		public int? logEstado
		{
			get { return m_logEstado; }
			set 
			{
				m_changed=true;
				m_logEstado = value;
			}
		}

		/// <summary>
		/// Attribute for access the TercerosConductoresWinFor's logConductor value (int)
		/// </summary>
		[DataMember]
		public int? logConductor
		{
			get { return m_logConductor; }
			set 
			{
				m_changed=true;
				m_logConductor = value;
			}
		}

		/// <summary>
		/// Attribute for access the TercerosConductoresWinFor's strPlaca value (int)
		/// </summary>
		[DataMember]
		public int? strPlaca
		{
			get { return m_strPlaca; }
			set 
			{
				m_changed=true;
				m_strPlaca = value;
			}
		}

		/// <summary>
		/// Attribute for access the TercerosConductoresWinFor's lngIdCiudad value (int)
		/// </summary>
		[DataMember]
		public int? lngIdCiudad
		{
			get { return m_lngIdCiudad; }
			set 
			{
				m_changed=true;
				m_lngIdCiudad = value;
			}
		}

		/// <summary>
		/// Attribute for access the TercerosConductoresWinFor's strTelefono value (int)
		/// </summary>
		[DataMember]
		public int? strTelefono
		{
			get { return m_strTelefono; }
			set 
			{
				m_changed=true;
				m_strTelefono = value;
			}
		}

		/// <summary>
		/// Attribute for access the TercerosConductoresWinFor's strTelefonoAux value (int)
		/// </summary>
		[DataMember]
		public int? strTelefonoAux
		{
			get { return m_strTelefonoAux; }
			set 
			{
				m_changed=true;
				m_strTelefonoAux = value;
			}
		}

		/// <summary>
		/// Attribute for access the TercerosConductoresWinFor's strTelCelular value (int)
		/// </summary>
		[DataMember]
		public int? strTelCelular
		{
			get { return m_strTelCelular; }
			set 
			{
				m_changed=true;
				m_strTelCelular = value;
			}
		}

		/// <summary>
		/// Attribute for access the TercerosConductoresWinFor's strTelCelularAux value (int)
		/// </summary>
		[DataMember]
		public int? strTelCelularAux
		{
			get { return m_strTelCelularAux; }
			set 
			{
				m_changed=true;
				m_strTelCelularAux = value;
			}
		}

		/// <summary>
		/// Attribute for access the TercerosConductoresWinFor's strFax value (int)
		/// </summary>
		[DataMember]
		public int? strFax
		{
			get { return m_strFax; }
			set 
			{
				m_changed=true;
				m_strFax = value;
			}
		}

		/// <summary>
		/// Attribute for access the TercerosConductoresWinFor's IntAAereo value (int)
		/// </summary>
		[DataMember]
		public int? IntAAereo
		{
			get { return m_IntAAereo; }
			set 
			{
				m_changed=true;
				m_IntAAereo = value;
			}
		}

		/// <summary>
		/// Attribute for access the TercerosConductoresWinFor's StrPais value (int)
		/// </summary>
		[DataMember]
		public int? StrPais
		{
			get { return m_StrPais; }
			set 
			{
				m_changed=true;
				m_StrPais = value;
			}
		}

		/// <summary>
		/// Attribute for access the TercerosConductoresWinFor's nitProvedor value (int)
		/// </summary>
		[DataMember]
		public int? nitProvedor
		{
			get { return m_nitProvedor; }
			set 
			{
				m_changed=true;
				m_nitProvedor = value;
			}
		}

		/// <summary>
		/// Attribute for access the TercerosConductoresWinFor's intNoLicenciaConduc value (int)
		/// </summary>
		[DataMember]
		public int? intNoLicenciaConduc
		{
			get { return m_intNoLicenciaConduc; }
			set 
			{
				m_changed=true;
				m_intNoLicenciaConduc = value;
			}
		}

		/// <summary>
		/// Attribute for access the TercerosConductoresWinFor's intCategoria value (int)
		/// </summary>
		[DataMember]
		public int? intCategoria
		{
			get { return m_intCategoria; }
			set 
			{
				m_changed=true;
				m_intCategoria = value;
			}
		}

		/// <summary>
		/// Attribute for access the TercerosConductoresWinFor's strTarjetaTripulante value (int)
		/// </summary>
		[DataMember]
		public int? strTarjetaTripulante
		{
			get { return m_strTarjetaTripulante; }
			set 
			{
				m_changed=true;
				m_strTarjetaTripulante = value;
			}
		}

		/// <summary>
		/// Attribute for access the TercerosConductoresWinFor's dtmFechaVenceLicencia value (int)
		/// </summary>
		[DataMember]
		public int? dtmFechaVenceLicencia
		{
			get { return m_dtmFechaVenceLicencia; }
			set 
			{
				m_changed=true;
				m_dtmFechaVenceLicencia = value;
			}
		}

		/// <summary>
		/// Attribute for access the TercerosConductoresWinFor's dtmVenceTarjetaTripulante value (int)
		/// </summary>
		[DataMember]
		public int? dtmVenceTarjetaTripulante
		{
			get { return m_dtmVenceTarjetaTripulante; }
			set 
			{
				m_changed=true;
				m_dtmVenceTarjetaTripulante = value;
			}
		}

		/// <summary>
		/// Attribute for access the TercerosConductoresWinFor's strCarnetEmpresa value (int)
		/// </summary>
		[DataMember]
		public int? strCarnetEmpresa
		{
			get { return m_strCarnetEmpresa; }
			set 
			{
				m_changed=true;
				m_strCarnetEmpresa = value;
			}
		}

		/// <summary>
		/// Attribute for access the TercerosConductoresWinFor's strCarnetComunicaciones value (int)
		/// </summary>
		[DataMember]
		public int? strCarnetComunicaciones
		{
			get { return m_strCarnetComunicaciones; }
			set 
			{
				m_changed=true;
				m_strCarnetComunicaciones = value;
			}
		}

		public object GetAttribute(string pattribute)
		{
			switch (pattribute)
			{
				case "lngIdRegistro": return lngIdRegistro;
				case "lngIdUsuario": return lngIdUsuario;
				case "strTipoIdentificacion": return strTipoIdentificacion;
				case "IntNit": return IntNit;
				case "intDigito": return intDigito;
				case "strNombres": return strNombres;
				case "strDireccion": return strDireccion;
				case "logEstado": return logEstado;
				case "logConductor": return logConductor;
				case "strPlaca": return strPlaca;
				case "lngIdCiudad": return lngIdCiudad;
				case "strTelefono": return strTelefono;
				case "strTelefonoAux": return strTelefonoAux;
				case "strTelCelular": return strTelCelular;
				case "strTelCelularAux": return strTelCelularAux;
				case "strFax": return strFax;
				case "IntAAereo": return IntAAereo;
				case "StrPais": return StrPais;
				case "nitProvedor": return nitProvedor;
				case "intNoLicenciaConduc": return intNoLicenciaConduc;
				case "intCategoria": return intCategoria;
				case "strTarjetaTripulante": return strTarjetaTripulante;
				case "dtmFechaVenceLicencia": return dtmFechaVenceLicencia;
				case "dtmVenceTarjetaTripulante": return dtmVenceTarjetaTripulante;
				case "strCarnetEmpresa": return strCarnetEmpresa;
				case "strCarnetComunicaciones": return strCarnetComunicaciones;
				default: return null;
			}
		}

		public Type GetAttributeType(string pattribute)
		{
			return TercerosConductoresWinForController.Instance.GetMethodType(pattribute, this);
		}

		public string GetSqlKey()
		{
			return "[lngIdRegistro] = " + lngIdRegistro.ToString() + " AND [lngIdUsuario] = " + lngIdUsuario.ToString();
		}
		#endregion

	}

	#endregion

	#region TercerosConductoresWinForList object

	/// <summary>
	/// Class for reading and access a list of TercerosConductoresWinFor object
	/// </summary>
	[CollectionDataContract]
	public partial class TercerosConductoresWinForList : List<TercerosConductoresWinFor>
	{

		/// <summary>
		/// Default constructor
		/// </summary>
		public TercerosConductoresWinForList()
		{
		}
	}

	#endregion

}
