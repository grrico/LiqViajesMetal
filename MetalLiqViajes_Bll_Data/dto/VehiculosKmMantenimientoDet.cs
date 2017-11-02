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
	#region VehiculosKmMantenimientoDet object

	[DataContract]
	public partial class VehiculosKmMantenimientoDet : IDTOObject
	{
		/// <summary>
		/// Default constructor
		/// </summary>
		public VehiculosKmMantenimientoDet()
		{
			m_lngIdRegistro = 0;
			m_strPlaca = null;
			m_lngIdTipoMantenimiento = null;
			m_dtmFechaMovimiento = null;
			m_intKmUltimoCambio = null;
			m_intKmSiguiente = null;
			m_intAcumulado = null;
			m_intKmRestantes = null;
			m_strObservaciones = null;
			m_dtmFechaModif = null;
			m_lngIdUsuario = null;
			m_changed=false;
		}
		        //Return the table name of object
		        public string TableName()
		        {
		            return "tblVehiculosKmMantenimientoDet";
		        }
		#region Undo 
		// Internal class for storing changes
		private VehiculosKmMantenimientoDet m_oldVehiculosKmMantenimientoDet;
		public void GenerateUndo()
		{
			m_oldVehiculosKmMantenimientoDet=new VehiculosKmMantenimientoDet();
			m_oldVehiculosKmMantenimientoDet.m_lngIdRegistro = m_lngIdRegistro;
			m_oldVehiculosKmMantenimientoDet.strPlaca = m_strPlaca;
			m_oldVehiculosKmMantenimientoDet.lngIdTipoMantenimiento = m_lngIdTipoMantenimiento;
			m_oldVehiculosKmMantenimientoDet.dtmFechaMovimiento = m_dtmFechaMovimiento;
			m_oldVehiculosKmMantenimientoDet.intKmUltimoCambio = m_intKmUltimoCambio;
			m_oldVehiculosKmMantenimientoDet.intKmSiguiente = m_intKmSiguiente;
			m_oldVehiculosKmMantenimientoDet.intAcumulado = m_intAcumulado;
			m_oldVehiculosKmMantenimientoDet.intKmRestantes = m_intKmRestantes;
			m_oldVehiculosKmMantenimientoDet.strObservaciones = m_strObservaciones;
			m_oldVehiculosKmMantenimientoDet.dtmFechaModif = m_dtmFechaModif;
			m_oldVehiculosKmMantenimientoDet.lngIdUsuario = m_lngIdUsuario;
		}

		public VehiculosKmMantenimientoDet OldVehiculosKmMantenimientoDet
		{
			get { return m_oldVehiculosKmMantenimientoDet;}
		}
		// Return the changed fields
		public string[] FieldChanged()
		{
			List<string> fields=new List<string>();
			if (m_oldVehiculosKmMantenimientoDet.strPlaca != m_strPlaca) fields.Add("strPlaca");
			if (m_oldVehiculosKmMantenimientoDet.lngIdTipoMantenimiento != m_lngIdTipoMantenimiento) fields.Add("lngIdTipoMantenimiento");
			if (m_oldVehiculosKmMantenimientoDet.dtmFechaMovimiento != m_dtmFechaMovimiento) fields.Add("dtmFechaMovimiento");
			if (m_oldVehiculosKmMantenimientoDet.intKmUltimoCambio != m_intKmUltimoCambio) fields.Add("intKmUltimoCambio");
			if (m_oldVehiculosKmMantenimientoDet.intKmSiguiente != m_intKmSiguiente) fields.Add("intKmSiguiente");
			if (m_oldVehiculosKmMantenimientoDet.intAcumulado != m_intAcumulado) fields.Add("intAcumulado");
			if (m_oldVehiculosKmMantenimientoDet.intKmRestantes != m_intKmRestantes) fields.Add("intKmRestantes");
			if (m_oldVehiculosKmMantenimientoDet.strObservaciones != m_strObservaciones) fields.Add("strObservaciones");
			if (m_oldVehiculosKmMantenimientoDet.dtmFechaModif != m_dtmFechaModif) fields.Add("dtmFechaModif");
			if (m_oldVehiculosKmMantenimientoDet.lngIdUsuario != m_lngIdUsuario) fields.Add("lngIdUsuario");
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


		// Field for storing the VehiculosKmMantenimientoDet's lngIdRegistro value
		private int m_lngIdRegistro;

		// Field for storing the VehiculosKmMantenimientoDet's strPlaca value
		private string m_strPlaca;

		// Field for storing the VehiculosKmMantenimientoDet's lngIdTipoMantenimiento value
		private int? m_lngIdTipoMantenimiento;

		// Field for storing the VehiculosKmMantenimientoDet's dtmFechaMovimiento value
		private DateTime? m_dtmFechaMovimiento;

		// Field for storing the VehiculosKmMantenimientoDet's intKmUltimoCambio value
		private int? m_intKmUltimoCambio;

		// Field for storing the VehiculosKmMantenimientoDet's intKmSiguiente value
		private int? m_intKmSiguiente;

		// Field for storing the VehiculosKmMantenimientoDet's intAcumulado value
		private int? m_intAcumulado;

		// Field for storing the VehiculosKmMantenimientoDet's intKmRestantes value
		private int? m_intKmRestantes;

		// Field for storing the VehiculosKmMantenimientoDet's strObservaciones value
		private string m_strObservaciones;

		// Field for storing the VehiculosKmMantenimientoDet's dtmFechaModif value
		private DateTime? m_dtmFechaModif;

		// Field for storing the VehiculosKmMantenimientoDet's lngIdUsuario value
		private int? m_lngIdUsuario;

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
		/// Attribute for access the VehiculosKmMantenimientoDet's lngIdRegistro value (int)
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
		/// Attribute for access the VehiculosKmMantenimientoDet's strPlaca value (string)
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
		/// Attribute for access the VehiculosKmMantenimientoDet's lngIdTipoMantenimiento value (int)
		/// </summary>
		[DataMember]
		public int? lngIdTipoMantenimiento
		{
			get { return m_lngIdTipoMantenimiento; }
			set 
			{
				m_changed=true;
				m_lngIdTipoMantenimiento = value;
			}
		}

		/// <summary>
		/// Attribute for access the VehiculosKmMantenimientoDet's dtmFechaMovimiento value (DateTime)
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
		/// Attribute for access the VehiculosKmMantenimientoDet's intKmUltimoCambio value (int)
		/// </summary>
		[DataMember]
		public int? intKmUltimoCambio
		{
			get { return m_intKmUltimoCambio; }
			set 
			{
				m_changed=true;
				m_intKmUltimoCambio = value;
			}
		}

		/// <summary>
		/// Attribute for access the VehiculosKmMantenimientoDet's intKmSiguiente value (int)
		/// </summary>
		[DataMember]
		public int? intKmSiguiente
		{
			get { return m_intKmSiguiente; }
			set 
			{
				m_changed=true;
				m_intKmSiguiente = value;
			}
		}

		/// <summary>
		/// Attribute for access the VehiculosKmMantenimientoDet's intAcumulado value (int)
		/// </summary>
		[DataMember]
		public int? intAcumulado
		{
			get { return m_intAcumulado; }
			set 
			{
				m_changed=true;
				m_intAcumulado = value;
			}
		}

		/// <summary>
		/// Attribute for access the VehiculosKmMantenimientoDet's intKmRestantes value (int)
		/// </summary>
		[DataMember]
		public int? intKmRestantes
		{
			get { return m_intKmRestantes; }
			set 
			{
				m_changed=true;
				m_intKmRestantes = value;
			}
		}

		/// <summary>
		/// Attribute for access the VehiculosKmMantenimientoDet's strObservaciones value (string)
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
		/// Attribute for access the VehiculosKmMantenimientoDet's dtmFechaModif value (DateTime)
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
		/// Attribute for access the VehiculosKmMantenimientoDet's lngIdUsuario value (int)
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

		public object GetAttribute(string pattribute)
		{
			switch (pattribute)
			{
				case "lngIdRegistro": return lngIdRegistro;
				case "strPlaca": return strPlaca;
				case "lngIdTipoMantenimiento": return lngIdTipoMantenimiento;
				case "dtmFechaMovimiento": return dtmFechaMovimiento;
				case "intKmUltimoCambio": return intKmUltimoCambio;
				case "intKmSiguiente": return intKmSiguiente;
				case "intAcumulado": return intAcumulado;
				case "intKmRestantes": return intKmRestantes;
				case "strObservaciones": return strObservaciones;
				case "dtmFechaModif": return dtmFechaModif;
				case "lngIdUsuario": return lngIdUsuario;
				default: return null;
			}
		}

		public Type GetAttributeType(string pattribute)
		{
			return VehiculosKmMantenimientoDetController.Instance.GetMethodType(pattribute, this);
		}

		public string GetSqlKey()
		{
			return "[lngIdRegistro] = " + lngIdRegistro.ToString();
		}
		#endregion

	}

	#endregion

	#region VehiculosKmMantenimientoDetList object

	/// <summary>
	/// Class for reading and access a list of VehiculosKmMantenimientoDet object
	/// </summary>
	[CollectionDataContract]
	public partial class VehiculosKmMantenimientoDetList : List<VehiculosKmMantenimientoDet>
	{

		/// <summary>
		/// Default constructor
		/// </summary>
		public VehiculosKmMantenimientoDetList()
		{
		}
	}

	#endregion

}
