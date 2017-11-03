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
	#region Terceros object

	[DataContract]
	public partial class Terceros : IDTOObject
	{
		/// <summary>
		/// Default constructor
		/// </summary>
		public Terceros()
		{
			m_NitConductor = 0;
			m_Identificacion = null;
			m_TipoIdentificacion = ' ';
			m_Digito = (byte)0;
			m_NombreCompleto = null;
			m_Concepto_3 = null;
			m_CentroCosto = null;
			m_Direccion = null;
			m_NombreCiudad = null;
			m_Pais = null;
			m_Telefono1 = null;
			m_Telefono2 = null;
			m_Telefono3 = null;
			m_ApartadoAreo = null;
			m_changed=false;
		}
		        //Return the table name of object
		        public string TableName()
		        {
		            return "Terceros";
		        }
		#region Undo 
		// Internal class for storing changes
		private Terceros m_oldTerceros;
		public void GenerateUndo()
		{
			m_oldTerceros=new Terceros();
			m_oldTerceros.m_NitConductor = m_NitConductor;
			m_oldTerceros.Identificacion = m_Identificacion;
			m_oldTerceros.TipoIdentificacion = m_TipoIdentificacion;
			m_oldTerceros.Digito = m_Digito;
			m_oldTerceros.NombreCompleto = m_NombreCompleto;
			m_oldTerceros.Concepto_3 = m_Concepto_3;
			m_oldTerceros.CentroCosto = m_CentroCosto;
			m_oldTerceros.Direccion = m_Direccion;
			m_oldTerceros.NombreCiudad = m_NombreCiudad;
			m_oldTerceros.Pais = m_Pais;
			m_oldTerceros.Telefono1 = m_Telefono1;
			m_oldTerceros.Telefono2 = m_Telefono2;
			m_oldTerceros.Telefono3 = m_Telefono3;
			m_oldTerceros.ApartadoAreo = m_ApartadoAreo;
		}

		public Terceros OldTerceros
		{
			get { return m_oldTerceros;}
		}
		// Return the changed fields
		public string[] FieldChanged()
		{
			List<string> fields=new List<string>();
			if (m_oldTerceros.Identificacion != m_Identificacion) fields.Add("Identificacion");
			if (m_oldTerceros.TipoIdentificacion != m_TipoIdentificacion) fields.Add("TipoIdentificacion");
			if (m_oldTerceros.Digito != m_Digito) fields.Add("Digito");
			if (m_oldTerceros.NombreCompleto != m_NombreCompleto) fields.Add("NombreCompleto");
			if (m_oldTerceros.Concepto_3 != m_Concepto_3) fields.Add("Concepto_3");
			if (m_oldTerceros.CentroCosto != m_CentroCosto) fields.Add("CentroCosto");
			if (m_oldTerceros.Direccion != m_Direccion) fields.Add("Direccion");
			if (m_oldTerceros.NombreCiudad != m_NombreCiudad) fields.Add("NombreCiudad");
			if (m_oldTerceros.Pais != m_Pais) fields.Add("Pais");
			if (m_oldTerceros.Telefono1 != m_Telefono1) fields.Add("Telefono1");
			if (m_oldTerceros.Telefono2 != m_Telefono2) fields.Add("Telefono2");
			if (m_oldTerceros.Telefono3 != m_Telefono3) fields.Add("Telefono3");
			if (m_oldTerceros.ApartadoAreo != m_ApartadoAreo) fields.Add("ApartadoAreo");
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


		// Field for storing the Terceros's Identificacion value
		private long? m_Identificacion;

		// Field for storing the Terceros's TipoIdentificacion value
		private char? m_TipoIdentificacion;

		// Field for storing the Terceros's Digito value
		private byte? m_Digito;

		// Field for storing the Terceros's NombreCompleto value
		private string m_NombreCompleto;

		// Field for storing the Terceros's Concepto_3 value
		private string m_Concepto_3;

		// Field for storing the Terceros's CentroCosto value
		private int? m_CentroCosto;

		// Field for storing the Terceros's Direccion value
		private string m_Direccion;

		// Field for storing the Terceros's NombreCiudad value
		private string m_NombreCiudad;

		// Field for storing the Terceros's Pais value
		private string m_Pais;

		// Field for storing the Terceros's Telefono1 value
		private string m_Telefono1;

		// Field for storing the Terceros's Telefono2 value
		private string m_Telefono2;

		// Field for storing the Terceros's Telefono3 value
		private string m_Telefono3;

		// Field for storing the Terceros's ApartadoAreo value
		private string m_ApartadoAreo;

		// Field for storing the Terceros's NitConductor value
		private decimal m_NitConductor;

		// Evaluate changed state
		private bool m_changed=false;
		// Field for storing the reference to foreign LiquidacionVehiculoList object accessed by NitConductor
		private LiquidacionVehiculoList m_LiquidacionVehiculo;


		#endregion

		#region Attributes

		// Return if object changed
		public bool Changed
		{
			get { return m_changed;}
			set { m_changed=value;}
		}
		/// <summary>
		/// Attribute for access the Terceros's Identificacion value (long)
		/// </summary>
		[DataMember]
		public long? Identificacion
		{
			get { return m_Identificacion; }
			set 
			{
				m_changed=true;
				m_Identificacion = value;
			}
		}

		/// <summary>
		/// Attribute for access the Terceros's TipoIdentificacion value (char)
		/// </summary>
		[DataMember]
		public char? TipoIdentificacion
		{
			get { return m_TipoIdentificacion; }
			set 
			{
				m_changed=true;
				m_TipoIdentificacion = value;
			}
		}

		/// <summary>
		/// Attribute for access the Terceros's Digito value (byte)
		/// </summary>
		[DataMember]
		public byte? Digito
		{
			get { return m_Digito; }
			set 
			{
				m_changed=true;
				m_Digito = value;
			}
		}

		/// <summary>
		/// Attribute for access the Terceros's NombreCompleto value (string)
		/// </summary>
		[DataMember]
		public string NombreCompleto
		{
			get { return m_NombreCompleto; }
			set 
			{
				m_changed=true;
				m_NombreCompleto = value;
			}
		}

		/// <summary>
		/// Attribute for access the Terceros's Concepto_3 value (string)
		/// </summary>
		[DataMember]
		public string Concepto_3
		{
			get { return m_Concepto_3; }
			set 
			{
				m_changed=true;
				m_Concepto_3 = value;
			}
		}

		/// <summary>
		/// Attribute for access the Terceros's CentroCosto value (int)
		/// </summary>
		[DataMember]
		public int? CentroCosto
		{
			get { return m_CentroCosto; }
			set 
			{
				m_changed=true;
				m_CentroCosto = value;
			}
		}

		/// <summary>
		/// Attribute for access the Terceros's Direccion value (string)
		/// </summary>
		[DataMember]
		public string Direccion
		{
			get { return m_Direccion; }
			set 
			{
				m_changed=true;
				m_Direccion = value;
			}
		}

		/// <summary>
		/// Attribute for access the Terceros's NombreCiudad value (string)
		/// </summary>
		[DataMember]
		public string NombreCiudad
		{
			get { return m_NombreCiudad; }
			set 
			{
				m_changed=true;
				m_NombreCiudad = value;
			}
		}

		/// <summary>
		/// Attribute for access the Terceros's Pais value (string)
		/// </summary>
		[DataMember]
		public string Pais
		{
			get { return m_Pais; }
			set 
			{
				m_changed=true;
				m_Pais = value;
			}
		}

		/// <summary>
		/// Attribute for access the Terceros's Telefono1 value (string)
		/// </summary>
		[DataMember]
		public string Telefono1
		{
			get { return m_Telefono1; }
			set 
			{
				m_changed=true;
				m_Telefono1 = value;
			}
		}

		/// <summary>
		/// Attribute for access the Terceros's Telefono2 value (string)
		/// </summary>
		[DataMember]
		public string Telefono2
		{
			get { return m_Telefono2; }
			set 
			{
				m_changed=true;
				m_Telefono2 = value;
			}
		}

		/// <summary>
		/// Attribute for access the Terceros's Telefono3 value (string)
		/// </summary>
		[DataMember]
		public string Telefono3
		{
			get { return m_Telefono3; }
			set 
			{
				m_changed=true;
				m_Telefono3 = value;
			}
		}

		/// <summary>
		/// Attribute for access the Terceros's ApartadoAreo value (string)
		/// </summary>
		[DataMember]
		public string ApartadoAreo
		{
			get { return m_ApartadoAreo; }
			set 
			{
				m_changed=true;
				m_ApartadoAreo = value;
			}
		}

		/// <summary>
		/// Attribute for access the Terceros's NitConductor value (decimal)
		/// </summary>
		[DataMember]
		public decimal NitConductor
		{
			get { return m_NitConductor; }
			set 
			{
				m_changed=true;
				m_NitConductor = value;
			}
		}

		public object GetAttribute(string pattribute)
		{
			switch (pattribute)
			{
				case "Identificacion": return Identificacion;
				case "TipoIdentificacion": return TipoIdentificacion;
				case "Digito": return Digito;
				case "NombreCompleto": return NombreCompleto;
				case "Concepto_3": return Concepto_3;
				case "CentroCosto": return CentroCosto;
				case "Direccion": return Direccion;
				case "NombreCiudad": return NombreCiudad;
				case "Pais": return Pais;
				case "Telefono1": return Telefono1;
				case "Telefono2": return Telefono2;
				case "Telefono3": return Telefono3;
				case "ApartadoAreo": return ApartadoAreo;
				case "NitConductor": return NitConductor;
				default: return null;
			}
		}

		public Type GetAttributeType(string pattribute)
		{
			return TercerosController.Instance.GetMethodType(pattribute, this);
		}

		public string GetSqlKey()
		{
			return "[NitConductor] = " + NitConductor.ToString();
		}
		/// <summary>
		/// Gets or sets the reference to foreign LiquidacionVehiculoList object accessed by NitConductor
		/// </summary>
		public LiquidacionVehiculoList LiquidacionVehiculo
		{
			get
			{
				if (m_LiquidacionVehiculo == null)
				{
					m_LiquidacionVehiculo = LiquidacionVehiculoController.Instance.GetBy_intNitConductor(NitConductor);
			}

			return m_LiquidacionVehiculo;
		}
		set { m_LiquidacionVehiculo = value; }
	}

	#endregion

}

#endregion

#region TercerosList object

/// <summary>
/// Class for reading and access a list of Terceros object
/// </summary>
[CollectionDataContract]
public partial class TercerosList : List<Terceros>
{

	/// <summary>
	/// Default constructor
	/// </summary>
	public TercerosList()
	{
	}
}

#endregion

}
