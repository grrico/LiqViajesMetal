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
	#region TercerosConductores object

	[DataContract]
	public partial class TercerosConductores : IDTOObject
	{
		/// <summary>
		/// Default constructor
		/// </summary>
		public TercerosConductores()
		{
			m_strTipoIdentificacion = "";
			m_IntNit = 0;
			m_intDigito = null;
			m_strNombres = null;
			m_strDireccion = null;
			m_logEstado = false;
			m_logConductor = false;
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
			m_dtmFechaModif = null;
			m_logActualizado = false;
			m_lngIdUsuario = null;
			m_changed=false;
		}
		        //Return the table name of object
		        public string TableName()
		        {
		            return "tblTercerosConductores";
		        }
		#region Undo 
		// Internal class for storing changes
		private TercerosConductores m_oldTercerosConductores;
		public void GenerateUndo()
		{
			m_oldTercerosConductores=new TercerosConductores();
			m_oldTercerosConductores.m_strTipoIdentificacion = m_strTipoIdentificacion;
			m_oldTercerosConductores.m_IntNit = m_IntNit;
			m_oldTercerosConductores.intDigito = m_intDigito;
			m_oldTercerosConductores.strNombres = m_strNombres;
			m_oldTercerosConductores.strDireccion = m_strDireccion;
			m_oldTercerosConductores.logEstado = m_logEstado;
			m_oldTercerosConductores.logConductor = m_logConductor;
			m_oldTercerosConductores.strPlaca = m_strPlaca;
			m_oldTercerosConductores.lngIdCiudad = m_lngIdCiudad;
			m_oldTercerosConductores.strTelefono = m_strTelefono;
			m_oldTercerosConductores.strTelefonoAux = m_strTelefonoAux;
			m_oldTercerosConductores.strTelCelular = m_strTelCelular;
			m_oldTercerosConductores.strTelCelularAux = m_strTelCelularAux;
			m_oldTercerosConductores.strFax = m_strFax;
			m_oldTercerosConductores.IntAAereo = m_IntAAereo;
			m_oldTercerosConductores.StrPais = m_StrPais;
			m_oldTercerosConductores.nitProvedor = m_nitProvedor;
			m_oldTercerosConductores.intNoLicenciaConduc = m_intNoLicenciaConduc;
			m_oldTercerosConductores.intCategoria = m_intCategoria;
			m_oldTercerosConductores.strTarjetaTripulante = m_strTarjetaTripulante;
			m_oldTercerosConductores.dtmFechaVenceLicencia = m_dtmFechaVenceLicencia;
			m_oldTercerosConductores.dtmVenceTarjetaTripulante = m_dtmVenceTarjetaTripulante;
			m_oldTercerosConductores.strCarnetEmpresa = m_strCarnetEmpresa;
			m_oldTercerosConductores.strCarnetComunicaciones = m_strCarnetComunicaciones;
			m_oldTercerosConductores.dtmFechaModif = m_dtmFechaModif;
			m_oldTercerosConductores.logActualizado = m_logActualizado;
			m_oldTercerosConductores.lngIdUsuario = m_lngIdUsuario;
		}

		public TercerosConductores OldTercerosConductores
		{
			get { return m_oldTercerosConductores;}
		}
		// Return the changed fields
		public string[] FieldChanged()
		{
			List<string> fields=new List<string>();
			if (m_oldTercerosConductores.intDigito != m_intDigito) fields.Add("intDigito");
			if (m_oldTercerosConductores.strNombres != m_strNombres) fields.Add("strNombres");
			if (m_oldTercerosConductores.strDireccion != m_strDireccion) fields.Add("strDireccion");
			if (m_oldTercerosConductores.logEstado != m_logEstado) fields.Add("logEstado");
			if (m_oldTercerosConductores.logConductor != m_logConductor) fields.Add("logConductor");
			if (m_oldTercerosConductores.strPlaca != m_strPlaca) fields.Add("strPlaca");
			if (m_oldTercerosConductores.lngIdCiudad != m_lngIdCiudad) fields.Add("lngIdCiudad");
			if (m_oldTercerosConductores.strTelefono != m_strTelefono) fields.Add("strTelefono");
			if (m_oldTercerosConductores.strTelefonoAux != m_strTelefonoAux) fields.Add("strTelefonoAux");
			if (m_oldTercerosConductores.strTelCelular != m_strTelCelular) fields.Add("strTelCelular");
			if (m_oldTercerosConductores.strTelCelularAux != m_strTelCelularAux) fields.Add("strTelCelularAux");
			if (m_oldTercerosConductores.strFax != m_strFax) fields.Add("strFax");
			if (m_oldTercerosConductores.IntAAereo != m_IntAAereo) fields.Add("IntAAereo");
			if (m_oldTercerosConductores.StrPais != m_StrPais) fields.Add("StrPais");
			if (m_oldTercerosConductores.nitProvedor != m_nitProvedor) fields.Add("nitProvedor");
			if (m_oldTercerosConductores.intNoLicenciaConduc != m_intNoLicenciaConduc) fields.Add("intNoLicenciaConduc");
			if (m_oldTercerosConductores.intCategoria != m_intCategoria) fields.Add("intCategoria");
			if (m_oldTercerosConductores.strTarjetaTripulante != m_strTarjetaTripulante) fields.Add("strTarjetaTripulante");
			if (m_oldTercerosConductores.dtmFechaVenceLicencia != m_dtmFechaVenceLicencia) fields.Add("dtmFechaVenceLicencia");
			if (m_oldTercerosConductores.dtmVenceTarjetaTripulante != m_dtmVenceTarjetaTripulante) fields.Add("dtmVenceTarjetaTripulante");
			if (m_oldTercerosConductores.strCarnetEmpresa != m_strCarnetEmpresa) fields.Add("strCarnetEmpresa");
			if (m_oldTercerosConductores.strCarnetComunicaciones != m_strCarnetComunicaciones) fields.Add("strCarnetComunicaciones");
			if (m_oldTercerosConductores.dtmFechaModif != m_dtmFechaModif) fields.Add("dtmFechaModif");
			if (m_oldTercerosConductores.logActualizado != m_logActualizado) fields.Add("logActualizado");
			if (m_oldTercerosConductores.lngIdUsuario != m_lngIdUsuario) fields.Add("lngIdUsuario");
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


		// Field for storing the TercerosConductores's intDigito value
		private int? m_intDigito;

		// Field for storing the TercerosConductores's strNombres value
		private string m_strNombres;

		// Field for storing the TercerosConductores's strDireccion value
		private string m_strDireccion;

		// Field for storing the TercerosConductores's logEstado value
		private bool? m_logEstado;

		// Field for storing the TercerosConductores's logConductor value
		private bool? m_logConductor;

		// Field for storing the TercerosConductores's strPlaca value
		private string m_strPlaca;

		// Field for storing the TercerosConductores's lngIdCiudad value
		private string m_lngIdCiudad;

		// Field for storing the TercerosConductores's strTelefono value
		private string m_strTelefono;

		// Field for storing the TercerosConductores's strTelefonoAux value
		private string m_strTelefonoAux;

		// Field for storing the TercerosConductores's strTelCelular value
		private string m_strTelCelular;

		// Field for storing the TercerosConductores's strTelCelularAux value
		private string m_strTelCelularAux;

		// Field for storing the TercerosConductores's strFax value
		private string m_strFax;

		// Field for storing the TercerosConductores's IntAAereo value
		private string m_IntAAereo;

		// Field for storing the TercerosConductores's StrPais value
		private string m_StrPais;

		// Field for storing the TercerosConductores's nitProvedor value
		private double? m_nitProvedor;

		// Field for storing the TercerosConductores's intNoLicenciaConduc value
		private double? m_intNoLicenciaConduc;

		// Field for storing the TercerosConductores's intCategoria value
		private int? m_intCategoria;

		// Field for storing the TercerosConductores's strTarjetaTripulante value
		private string m_strTarjetaTripulante;

		// Field for storing the TercerosConductores's dtmFechaVenceLicencia value
		private DateTime? m_dtmFechaVenceLicencia;

		// Field for storing the TercerosConductores's dtmVenceTarjetaTripulante value
		private DateTime? m_dtmVenceTarjetaTripulante;

		// Field for storing the TercerosConductores's strCarnetEmpresa value
		private string m_strCarnetEmpresa;

		// Field for storing the TercerosConductores's strCarnetComunicaciones value
		private string m_strCarnetComunicaciones;

		// Field for storing the TercerosConductores's dtmFechaModif value
		private DateTime? m_dtmFechaModif;

		// Field for storing the TercerosConductores's logActualizado value
		private bool? m_logActualizado;

		// Field for storing the TercerosConductores's lngIdUsuario value
		private int? m_lngIdUsuario;

		// Field for storing the TercerosConductores's strTipoIdentificacion value
		private string m_strTipoIdentificacion;

		// Field for storing the TercerosConductores's IntNit value
		private double m_IntNit;

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
		/// Attribute for access the TercerosConductores's intDigito value (int)
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
		/// Attribute for access the TercerosConductores's strNombres value (string)
		/// </summary>
		[DataMember]
		public string strNombres
		{
			get { return m_strNombres; }
			set 
			{
				m_changed=true;
				m_strNombres = value;
			}
		}

		/// <summary>
		/// Attribute for access the TercerosConductores's strDireccion value (string)
		/// </summary>
		[DataMember]
		public string strDireccion
		{
			get { return m_strDireccion; }
			set 
			{
				m_changed=true;
				m_strDireccion = value;
			}
		}

		/// <summary>
		/// Attribute for access the TercerosConductores's logEstado value (bool)
		/// </summary>
		[DataMember]
		public bool? logEstado
		{
			get { return m_logEstado; }
			set 
			{
				m_changed=true;
				m_logEstado = value;
			}
		}

		/// <summary>
		/// Attribute for access the TercerosConductores's logConductor value (bool)
		/// </summary>
		[DataMember]
		public bool? logConductor
		{
			get { return m_logConductor; }
			set 
			{
				m_changed=true;
				m_logConductor = value;
			}
		}

		/// <summary>
		/// Attribute for access the TercerosConductores's strPlaca value (string)
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
		/// Attribute for access the TercerosConductores's lngIdCiudad value (string)
		/// </summary>
		[DataMember]
		public string lngIdCiudad
		{
			get { return m_lngIdCiudad; }
			set 
			{
				m_changed=true;
				m_lngIdCiudad = value;
			}
		}

		/// <summary>
		/// Attribute for access the TercerosConductores's strTelefono value (string)
		/// </summary>
		[DataMember]
		public string strTelefono
		{
			get { return m_strTelefono; }
			set 
			{
				m_changed=true;
				m_strTelefono = value;
			}
		}

		/// <summary>
		/// Attribute for access the TercerosConductores's strTelefonoAux value (string)
		/// </summary>
		[DataMember]
		public string strTelefonoAux
		{
			get { return m_strTelefonoAux; }
			set 
			{
				m_changed=true;
				m_strTelefonoAux = value;
			}
		}

		/// <summary>
		/// Attribute for access the TercerosConductores's strTelCelular value (string)
		/// </summary>
		[DataMember]
		public string strTelCelular
		{
			get { return m_strTelCelular; }
			set 
			{
				m_changed=true;
				m_strTelCelular = value;
			}
		}

		/// <summary>
		/// Attribute for access the TercerosConductores's strTelCelularAux value (string)
		/// </summary>
		[DataMember]
		public string strTelCelularAux
		{
			get { return m_strTelCelularAux; }
			set 
			{
				m_changed=true;
				m_strTelCelularAux = value;
			}
		}

		/// <summary>
		/// Attribute for access the TercerosConductores's strFax value (string)
		/// </summary>
		[DataMember]
		public string strFax
		{
			get { return m_strFax; }
			set 
			{
				m_changed=true;
				m_strFax = value;
			}
		}

		/// <summary>
		/// Attribute for access the TercerosConductores's IntAAereo value (string)
		/// </summary>
		[DataMember]
		public string IntAAereo
		{
			get { return m_IntAAereo; }
			set 
			{
				m_changed=true;
				m_IntAAereo = value;
			}
		}

		/// <summary>
		/// Attribute for access the TercerosConductores's StrPais value (string)
		/// </summary>
		[DataMember]
		public string StrPais
		{
			get { return m_StrPais; }
			set 
			{
				m_changed=true;
				m_StrPais = value;
			}
		}

		/// <summary>
		/// Attribute for access the TercerosConductores's nitProvedor value (double)
		/// </summary>
		[DataMember]
		public double? nitProvedor
		{
			get { return m_nitProvedor; }
			set 
			{
				m_changed=true;
				m_nitProvedor = value;
			}
		}

		/// <summary>
		/// Attribute for access the TercerosConductores's intNoLicenciaConduc value (double)
		/// </summary>
		[DataMember]
		public double? intNoLicenciaConduc
		{
			get { return m_intNoLicenciaConduc; }
			set 
			{
				m_changed=true;
				m_intNoLicenciaConduc = value;
			}
		}

		/// <summary>
		/// Attribute for access the TercerosConductores's intCategoria value (int)
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
		/// Attribute for access the TercerosConductores's strTarjetaTripulante value (string)
		/// </summary>
		[DataMember]
		public string strTarjetaTripulante
		{
			get { return m_strTarjetaTripulante; }
			set 
			{
				m_changed=true;
				m_strTarjetaTripulante = value;
			}
		}

		/// <summary>
		/// Attribute for access the TercerosConductores's dtmFechaVenceLicencia value (DateTime)
		/// </summary>
		[DataMember]
		public DateTime? dtmFechaVenceLicencia
		{
			get { return m_dtmFechaVenceLicencia; }
			set 
			{
				m_changed=true;
				m_dtmFechaVenceLicencia = value;
			}
		}

		/// <summary>
		/// Attribute for access the TercerosConductores's dtmVenceTarjetaTripulante value (DateTime)
		/// </summary>
		[DataMember]
		public DateTime? dtmVenceTarjetaTripulante
		{
			get { return m_dtmVenceTarjetaTripulante; }
			set 
			{
				m_changed=true;
				m_dtmVenceTarjetaTripulante = value;
			}
		}

		/// <summary>
		/// Attribute for access the TercerosConductores's strCarnetEmpresa value (string)
		/// </summary>
		[DataMember]
		public string strCarnetEmpresa
		{
			get { return m_strCarnetEmpresa; }
			set 
			{
				m_changed=true;
				m_strCarnetEmpresa = value;
			}
		}

		/// <summary>
		/// Attribute for access the TercerosConductores's strCarnetComunicaciones value (string)
		/// </summary>
		[DataMember]
		public string strCarnetComunicaciones
		{
			get { return m_strCarnetComunicaciones; }
			set 
			{
				m_changed=true;
				m_strCarnetComunicaciones = value;
			}
		}

		/// <summary>
		/// Attribute for access the TercerosConductores's dtmFechaModif value (DateTime)
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
		/// Attribute for access the TercerosConductores's logActualizado value (bool)
		/// </summary>
		[DataMember]
		public bool? logActualizado
		{
			get { return m_logActualizado; }
			set 
			{
				m_changed=true;
				m_logActualizado = value;
			}
		}

		/// <summary>
		/// Attribute for access the TercerosConductores's lngIdUsuario value (int)
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
		/// Attribute for access the TercerosConductores's strTipoIdentificacion value (string)
		/// </summary>
		[DataMember]
		public string strTipoIdentificacion
		{
			get { return m_strTipoIdentificacion; }
			set 
			{
				m_changed=true;
				m_strTipoIdentificacion = value;
			}
		}

		/// <summary>
		/// Attribute for access the TercerosConductores's IntNit value (double)
		/// </summary>
		[DataMember]
		public double IntNit
		{
			get { return m_IntNit; }
			set 
			{
				m_changed=true;
				m_IntNit = value;
			}
		}

		public object GetAttribute(string pattribute)
		{
			switch (pattribute)
			{
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
				case "dtmFechaModif": return dtmFechaModif;
				case "logActualizado": return logActualizado;
				case "lngIdUsuario": return lngIdUsuario;
				case "strTipoIdentificacion": return strTipoIdentificacion;
				case "IntNit": return IntNit;
				default: return null;
			}
		}

		public Type GetAttributeType(string pattribute)
		{
			return TercerosConductoresController.Instance.GetMethodType(pattribute, this);
		}

		public string GetSqlKey()
		{
			return "[strTipoIdentificacion] = '" + strTipoIdentificacion.ToString()+ "'" + " AND [IntNit] = " + IntNit.ToString();
		}
		#endregion

	}

	#endregion

	#region TercerosConductoresList object

	/// <summary>
	/// Class for reading and access a list of TercerosConductores object
	/// </summary>
	[CollectionDataContract]
	public partial class TercerosConductoresList : List<TercerosConductores>
	{

		/// <summary>
		/// Default constructor
		/// </summary>
		public TercerosConductoresList()
		{
		}
	}

	#endregion

}
