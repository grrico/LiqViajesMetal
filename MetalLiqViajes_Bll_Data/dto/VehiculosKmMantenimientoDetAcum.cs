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
	#region VehiculosKmMantenimientoDetAcum object

	[DataContract]
	public partial class VehiculosKmMantenimientoDetAcum : IDTOObject
	{
		/// <summary>
		/// Default constructor
		/// </summary>
		public VehiculosKmMantenimientoDetAcum()
		{
			m_lngIdRegistro = 0;
			m_strPlaca = null;
			m_strDetalleAcumuado = null;
			m_drmFechaMovimiento = null;
			m_intKmMovimiento = null;
			m_dtmFechaModif = null;
			m_lngIdUsuario = null;
			m_changed=false;
		}
		        //Return the table name of object
		        public string TableName()
		        {
		            return "tblVehiculosKmMantenimientoDetAcum";
		        }
		#region Undo 
		// Internal class for storing changes
		private VehiculosKmMantenimientoDetAcum m_oldVehiculosKmMantenimientoDetAcum;
		public void GenerateUndo()
		{
			m_oldVehiculosKmMantenimientoDetAcum=new VehiculosKmMantenimientoDetAcum();
			m_oldVehiculosKmMantenimientoDetAcum.m_lngIdRegistro = m_lngIdRegistro;
			m_oldVehiculosKmMantenimientoDetAcum.strPlaca = m_strPlaca;
			m_oldVehiculosKmMantenimientoDetAcum.strDetalleAcumuado = m_strDetalleAcumuado;
			m_oldVehiculosKmMantenimientoDetAcum.drmFechaMovimiento = m_drmFechaMovimiento;
			m_oldVehiculosKmMantenimientoDetAcum.intKmMovimiento = m_intKmMovimiento;
			m_oldVehiculosKmMantenimientoDetAcum.dtmFechaModif = m_dtmFechaModif;
			m_oldVehiculosKmMantenimientoDetAcum.lngIdUsuario = m_lngIdUsuario;
		}

		public VehiculosKmMantenimientoDetAcum OldVehiculosKmMantenimientoDetAcum
		{
			get { return m_oldVehiculosKmMantenimientoDetAcum;}
		}
		// Return the changed fields
		public string[] FieldChanged()
		{
			List<string> fields=new List<string>();
			if (m_oldVehiculosKmMantenimientoDetAcum.strPlaca != m_strPlaca) fields.Add("strPlaca");
			if (m_oldVehiculosKmMantenimientoDetAcum.strDetalleAcumuado != m_strDetalleAcumuado) fields.Add("strDetalleAcumuado");
			if (m_oldVehiculosKmMantenimientoDetAcum.drmFechaMovimiento != m_drmFechaMovimiento) fields.Add("drmFechaMovimiento");
			if (m_oldVehiculosKmMantenimientoDetAcum.intKmMovimiento != m_intKmMovimiento) fields.Add("intKmMovimiento");
			if (m_oldVehiculosKmMantenimientoDetAcum.dtmFechaModif != m_dtmFechaModif) fields.Add("dtmFechaModif");
			if (m_oldVehiculosKmMantenimientoDetAcum.lngIdUsuario != m_lngIdUsuario) fields.Add("lngIdUsuario");
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


		// Field for storing the VehiculosKmMantenimientoDetAcum's lngIdRegistro value
		private int m_lngIdRegistro;

		// Field for storing the VehiculosKmMantenimientoDetAcum's strPlaca value
		private string m_strPlaca;

		// Field for storing the VehiculosKmMantenimientoDetAcum's strDetalleAcumuado value
		private string m_strDetalleAcumuado;

		// Field for storing the VehiculosKmMantenimientoDetAcum's drmFechaMovimiento value
		private DateTime? m_drmFechaMovimiento;

		// Field for storing the VehiculosKmMantenimientoDetAcum's intKmMovimiento value
		private int? m_intKmMovimiento;

		// Field for storing the VehiculosKmMantenimientoDetAcum's dtmFechaModif value
		private DateTime? m_dtmFechaModif;

		// Field for storing the VehiculosKmMantenimientoDetAcum's lngIdUsuario value
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
		/// Attribute for access the VehiculosKmMantenimientoDetAcum's lngIdRegistro value (int)
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
		/// Attribute for access the VehiculosKmMantenimientoDetAcum's strPlaca value (string)
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
		/// Attribute for access the VehiculosKmMantenimientoDetAcum's strDetalleAcumuado value (string)
		/// </summary>
		[DataMember]
		public string strDetalleAcumuado
		{
			get { return m_strDetalleAcumuado; }
			set 
			{
				m_changed=true;
				m_strDetalleAcumuado = value;
			}
		}

		/// <summary>
		/// Attribute for access the VehiculosKmMantenimientoDetAcum's drmFechaMovimiento value (DateTime)
		/// </summary>
		[DataMember]
		public DateTime? drmFechaMovimiento
		{
			get { return m_drmFechaMovimiento; }
			set 
			{
				m_changed=true;
				m_drmFechaMovimiento = value;
			}
		}

		/// <summary>
		/// Attribute for access the VehiculosKmMantenimientoDetAcum's intKmMovimiento value (int)
		/// </summary>
		[DataMember]
		public int? intKmMovimiento
		{
			get { return m_intKmMovimiento; }
			set 
			{
				m_changed=true;
				m_intKmMovimiento = value;
			}
		}

		/// <summary>
		/// Attribute for access the VehiculosKmMantenimientoDetAcum's dtmFechaModif value (DateTime)
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
		/// Attribute for access the VehiculosKmMantenimientoDetAcum's lngIdUsuario value (int)
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
				case "strDetalleAcumuado": return strDetalleAcumuado;
				case "drmFechaMovimiento": return drmFechaMovimiento;
				case "intKmMovimiento": return intKmMovimiento;
				case "dtmFechaModif": return dtmFechaModif;
				case "lngIdUsuario": return lngIdUsuario;
				default: return null;
			}
		}

		public Type GetAttributeType(string pattribute)
		{
			return VehiculosKmMantenimientoDetAcumController.Instance.GetMethodType(pattribute, this);
		}

		public string GetSqlKey()
		{
			return "[lngIdRegistro] = " + lngIdRegistro.ToString();
		}
		#endregion

	}

	#endregion

	#region VehiculosKmMantenimientoDetAcumList object

	/// <summary>
	/// Class for reading and access a list of VehiculosKmMantenimientoDetAcum object
	/// </summary>
	[CollectionDataContract]
	public partial class VehiculosKmMantenimientoDetAcumList : List<VehiculosKmMantenimientoDetAcum>
	{

		/// <summary>
		/// Default constructor
		/// </summary>
		public VehiculosKmMantenimientoDetAcumList()
		{
		}
	}

	#endregion

}
