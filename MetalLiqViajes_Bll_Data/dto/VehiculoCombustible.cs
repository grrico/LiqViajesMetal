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
	#region VehiculoCombustible object

	[DataContract]
	public partial class VehiculoCombustible : IDTOObject
	{
		/// <summary>
		/// Default constructor
		/// </summary>
		public VehiculoCombustible()
		{
			m_Codigo = 0;
			m_lngIdRegistro = null;
			m_tblLiquidacionRutasCombustibleCodigo = null;
			m_Placa = null;
			m_FechaTanqueo = null;
			m_GalonesReserva = null;
			m_GalonesTanqueo = null;
			m_ValorGalon = null;
			m_ValorCombustible = null;
			m_nitTerceroComplentario = null;
			m_NombreTerceroComplementario = null;
			m_sw = (byte)0;
			m_tipo = "";
			m_numero = 0;
			m_strObservaciones = null;
			m_changed=false;
		}
		        //Return the table name of object
		        public string TableName()
		        {
		            return "tblVehiculoCombustible";
		        }
		#region Undo 
		// Internal class for storing changes
		private VehiculoCombustible m_oldVehiculoCombustible;
		public void GenerateUndo()
		{
			m_oldVehiculoCombustible=new VehiculoCombustible();
			m_oldVehiculoCombustible.m_Codigo = m_Codigo;
			m_oldVehiculoCombustible.lngIdRegistro = m_lngIdRegistro;
			m_oldVehiculoCombustible.tblLiquidacionRutasCombustibleCodigo = m_tblLiquidacionRutasCombustibleCodigo;
			m_oldVehiculoCombustible.Placa = m_Placa;
			m_oldVehiculoCombustible.FechaTanqueo = m_FechaTanqueo;
			m_oldVehiculoCombustible.GalonesReserva = m_GalonesReserva;
			m_oldVehiculoCombustible.GalonesTanqueo = m_GalonesTanqueo;
			m_oldVehiculoCombustible.ValorGalon = m_ValorGalon;
			m_oldVehiculoCombustible.ValorCombustible = m_ValorCombustible;
			m_oldVehiculoCombustible.nitTerceroComplentario = m_nitTerceroComplentario;
			m_oldVehiculoCombustible.NombreTerceroComplementario = m_NombreTerceroComplementario;
			m_oldVehiculoCombustible.sw = m_sw;
			m_oldVehiculoCombustible.tipo = m_tipo;
			m_oldVehiculoCombustible.numero = m_numero;
			m_oldVehiculoCombustible.strObservaciones = m_strObservaciones;
		}

		public VehiculoCombustible OldVehiculoCombustible
		{
			get { return m_oldVehiculoCombustible;}
		}
		// Return the changed fields
		public string[] FieldChanged()
		{
			List<string> fields=new List<string>();
			if (m_oldVehiculoCombustible.lngIdRegistro != m_lngIdRegistro) fields.Add("lngIdRegistro");
			if (m_oldVehiculoCombustible.tblLiquidacionRutasCombustibleCodigo != m_tblLiquidacionRutasCombustibleCodigo) fields.Add("tblLiquidacionRutasCombustibleCodigo");
			if (m_oldVehiculoCombustible.Placa != m_Placa) fields.Add("Placa");
			if (m_oldVehiculoCombustible.FechaTanqueo != m_FechaTanqueo) fields.Add("FechaTanqueo");
			if (m_oldVehiculoCombustible.GalonesReserva != m_GalonesReserva) fields.Add("GalonesReserva");
			if (m_oldVehiculoCombustible.GalonesTanqueo != m_GalonesTanqueo) fields.Add("GalonesTanqueo");
			if (m_oldVehiculoCombustible.ValorGalon != m_ValorGalon) fields.Add("ValorGalon");
			if (m_oldVehiculoCombustible.ValorCombustible != m_ValorCombustible) fields.Add("ValorCombustible");
			if (m_oldVehiculoCombustible.nitTerceroComplentario != m_nitTerceroComplentario) fields.Add("nitTerceroComplentario");
			if (m_oldVehiculoCombustible.NombreTerceroComplementario != m_NombreTerceroComplementario) fields.Add("NombreTerceroComplementario");
			if (m_oldVehiculoCombustible.sw != m_sw) fields.Add("sw");
			if (m_oldVehiculoCombustible.tipo != m_tipo) fields.Add("tipo");
			if (m_oldVehiculoCombustible.numero != m_numero) fields.Add("numero");
			if (m_oldVehiculoCombustible.strObservaciones != m_strObservaciones) fields.Add("strObservaciones");
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


		// Field for storing the VehiculoCombustible's Codigo value
		private long m_Codigo;

		// Field for storing the VehiculoCombustible's lngIdRegistro value
		private int? m_lngIdRegistro;

		// Field for storing the VehiculoCombustible's tblLiquidacionRutasCombustibleCodigo value
		private long? m_tblLiquidacionRutasCombustibleCodigo;

		// Field for storing the VehiculoCombustible's Placa value
		private string m_Placa;

		// Field for storing the VehiculoCombustible's FechaTanqueo value
		private DateTime? m_FechaTanqueo;

		// Field for storing the VehiculoCombustible's GalonesReserva value
		private decimal? m_GalonesReserva;

		// Field for storing the VehiculoCombustible's GalonesTanqueo value
		private decimal? m_GalonesTanqueo;

		// Field for storing the VehiculoCombustible's ValorGalon value
		private decimal? m_ValorGalon;

		// Field for storing the VehiculoCombustible's ValorCombustible value
		private decimal? m_ValorCombustible;

		// Field for storing the VehiculoCombustible's nitTerceroComplentario value
		private string m_nitTerceroComplentario;

		// Field for storing the VehiculoCombustible's NombreTerceroComplementario value
		private string m_NombreTerceroComplementario;

		// Field for storing the VehiculoCombustible's sw value
		private byte m_sw;

		// Field for storing the VehiculoCombustible's tipo value
		private string m_tipo;

		// Field for storing the VehiculoCombustible's numero value
		private int m_numero;

		// Field for storing the VehiculoCombustible's strObservaciones value
		private string m_strObservaciones;

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
		/// Attribute for access the VehiculoCombustible's Codigo value (long)
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
		/// Attribute for access the VehiculoCombustible's lngIdRegistro value (int)
		/// </summary>
		[DataMember]
		public int? lngIdRegistro
		{
			get { return m_lngIdRegistro; }
			set 
			{
				m_changed=true;
				m_lngIdRegistro = value;
			}
		}

		/// <summary>
		/// Attribute for access the VehiculoCombustible's tblLiquidacionRutasCombustibleCodigo value (long)
		/// </summary>
		[DataMember]
		public long? tblLiquidacionRutasCombustibleCodigo
		{
			get { return m_tblLiquidacionRutasCombustibleCodigo; }
			set 
			{
				m_changed=true;
				m_tblLiquidacionRutasCombustibleCodigo = value;
			}
		}

		/// <summary>
		/// Attribute for access the VehiculoCombustible's Placa value (string)
		/// </summary>
		[DataMember]
		public string Placa
		{
			get { return m_Placa; }
			set 
			{
				m_changed=true;
				m_Placa = value;
			}
		}

		/// <summary>
		/// Attribute for access the VehiculoCombustible's FechaTanqueo value (DateTime)
		/// </summary>
		[DataMember]
		public DateTime? FechaTanqueo
		{
			get { return m_FechaTanqueo; }
			set 
			{
				m_changed=true;
				m_FechaTanqueo = value;
			}
		}

		/// <summary>
		/// Attribute for access the VehiculoCombustible's GalonesReserva value (decimal)
		/// </summary>
		[DataMember]
		public decimal? GalonesReserva
		{
			get { return m_GalonesReserva; }
			set 
			{
				m_changed=true;
				m_GalonesReserva = value;
			}
		}

		/// <summary>
		/// Attribute for access the VehiculoCombustible's GalonesTanqueo value (decimal)
		/// </summary>
		[DataMember]
		public decimal? GalonesTanqueo
		{
			get { return m_GalonesTanqueo; }
			set 
			{
				m_changed=true;
				m_GalonesTanqueo = value;
			}
		}

		/// <summary>
		/// Attribute for access the VehiculoCombustible's ValorGalon value (decimal)
		/// </summary>
		[DataMember]
		public decimal? ValorGalon
		{
			get { return m_ValorGalon; }
			set 
			{
				m_changed=true;
				m_ValorGalon = value;
			}
		}

		/// <summary>
		/// Attribute for access the VehiculoCombustible's ValorCombustible value (decimal)
		/// </summary>
		[DataMember]
		public decimal? ValorCombustible
		{
			get { return m_ValorCombustible; }
			set 
			{
				m_changed=true;
				m_ValorCombustible = value;
			}
		}

		/// <summary>
		/// Attribute for access the VehiculoCombustible's nitTerceroComplentario value (string)
		/// </summary>
		[DataMember]
		public string nitTerceroComplentario
		{
			get { return m_nitTerceroComplentario; }
			set 
			{
				m_changed=true;
				m_nitTerceroComplentario = value;
			}
		}

		/// <summary>
		/// Attribute for access the VehiculoCombustible's NombreTerceroComplementario value (string)
		/// </summary>
		[DataMember]
		public string NombreTerceroComplementario
		{
			get { return m_NombreTerceroComplementario; }
			set 
			{
				m_changed=true;
				m_NombreTerceroComplementario = value;
			}
		}

		/// <summary>
		/// Attribute for access the VehiculoCombustible's sw value (byte)
		/// </summary>
		[DataMember]
		public byte sw
		{
			get { return m_sw; }
			set 
			{
				m_changed=true;
				m_sw = value;
			}
		}

		/// <summary>
		/// Attribute for access the VehiculoCombustible's tipo value (string)
		/// </summary>
		[DataMember]
		public string tipo
		{
			get { return m_tipo; }
			set 
			{
				m_changed=true;
				m_tipo = value;
			}
		}

		/// <summary>
		/// Attribute for access the VehiculoCombustible's numero value (int)
		/// </summary>
		[DataMember]
		public int numero
		{
			get { return m_numero; }
			set 
			{
				m_changed=true;
				m_numero = value;
			}
		}

		/// <summary>
		/// Attribute for access the VehiculoCombustible's strObservaciones value (string)
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

		public object GetAttribute(string pattribute)
		{
			switch (pattribute)
			{
				case "Codigo": return Codigo;
				case "lngIdRegistro": return lngIdRegistro;
				case "tblLiquidacionRutasCombustibleCodigo": return tblLiquidacionRutasCombustibleCodigo;
				case "Placa": return Placa;
				case "FechaTanqueo": return FechaTanqueo;
				case "GalonesReserva": return GalonesReserva;
				case "GalonesTanqueo": return GalonesTanqueo;
				case "ValorGalon": return ValorGalon;
				case "ValorCombustible": return ValorCombustible;
				case "nitTerceroComplentario": return nitTerceroComplentario;
				case "NombreTerceroComplementario": return NombreTerceroComplementario;
				case "sw": return sw;
				case "tipo": return tipo;
				case "numero": return numero;
				case "strObservaciones": return strObservaciones;
				default: return null;
			}
		}

		public Type GetAttributeType(string pattribute)
		{
			return VehiculoCombustibleController.Instance.GetMethodType(pattribute, this);
		}

		public string GetSqlKey()
		{
			return "[Codigo] = " + Codigo.ToString();
		}
		#endregion

	}

	#endregion

	#region VehiculoCombustibleList object

	/// <summary>
	/// Class for reading and access a list of VehiculoCombustible object
	/// </summary>
	[CollectionDataContract]
	public partial class VehiculoCombustibleList : List<VehiculoCombustible>
	{

		/// <summary>
		/// Default constructor
		/// </summary>
		public VehiculoCombustibleList()
		{
		}
	}

	#endregion

}
