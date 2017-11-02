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
	#region VehiculosKmMantenimiento object

	[DataContract]
	public partial class VehiculosKmMantenimiento : IDTOObject
	{
		/// <summary>
		/// Default constructor
		/// </summary>
		public VehiculosKmMantenimiento()
		{
			m_strPlaca = "";
			m_lngIdTipoMantenimiento = 0;
			m_dtmFechaUltimoCambio = null;
			m_intKmUltimoCambio = null;
			m_intKmSiguiente = null;
			m_intKmAcumulado = null;
			m_dtmFechaUltimoUltimoAcumu = null;
			m_intKmAlarma1 = null;
			m_intKmAlarma2 = null;
			m_logAvisa = false;
			m_dtmFechaDetener = null;
			m_strLugarDetener = null;
			m_dtmFechaModif = null;
			m_lngIdUsuario = null;
			m_changed=false;
		}
		        //Return the table name of object
		        public string TableName()
		        {
		            return "tblVehiculosKmMantenimiento";
		        }
		#region Undo 
		// Internal class for storing changes
		private VehiculosKmMantenimiento m_oldVehiculosKmMantenimiento;
		public void GenerateUndo()
		{
			m_oldVehiculosKmMantenimiento=new VehiculosKmMantenimiento();
			m_oldVehiculosKmMantenimiento.m_strPlaca = m_strPlaca;
			m_oldVehiculosKmMantenimiento.m_lngIdTipoMantenimiento = m_lngIdTipoMantenimiento;
			m_oldVehiculosKmMantenimiento.dtmFechaUltimoCambio = m_dtmFechaUltimoCambio;
			m_oldVehiculosKmMantenimiento.intKmUltimoCambio = m_intKmUltimoCambio;
			m_oldVehiculosKmMantenimiento.intKmSiguiente = m_intKmSiguiente;
			m_oldVehiculosKmMantenimiento.intKmAcumulado = m_intKmAcumulado;
			m_oldVehiculosKmMantenimiento.dtmFechaUltimoUltimoAcumu = m_dtmFechaUltimoUltimoAcumu;
			m_oldVehiculosKmMantenimiento.intKmAlarma1 = m_intKmAlarma1;
			m_oldVehiculosKmMantenimiento.intKmAlarma2 = m_intKmAlarma2;
			m_oldVehiculosKmMantenimiento.logAvisa = m_logAvisa;
			m_oldVehiculosKmMantenimiento.dtmFechaDetener = m_dtmFechaDetener;
			m_oldVehiculosKmMantenimiento.strLugarDetener = m_strLugarDetener;
			m_oldVehiculosKmMantenimiento.dtmFechaModif = m_dtmFechaModif;
			m_oldVehiculosKmMantenimiento.lngIdUsuario = m_lngIdUsuario;
		}

		public VehiculosKmMantenimiento OldVehiculosKmMantenimiento
		{
			get { return m_oldVehiculosKmMantenimiento;}
		}
		// Return the changed fields
		public string[] FieldChanged()
		{
			List<string> fields=new List<string>();
			if (m_oldVehiculosKmMantenimiento.dtmFechaUltimoCambio != m_dtmFechaUltimoCambio) fields.Add("dtmFechaUltimoCambio");
			if (m_oldVehiculosKmMantenimiento.intKmUltimoCambio != m_intKmUltimoCambio) fields.Add("intKmUltimoCambio");
			if (m_oldVehiculosKmMantenimiento.intKmSiguiente != m_intKmSiguiente) fields.Add("intKmSiguiente");
			if (m_oldVehiculosKmMantenimiento.intKmAcumulado != m_intKmAcumulado) fields.Add("intKmAcumulado");
			if (m_oldVehiculosKmMantenimiento.dtmFechaUltimoUltimoAcumu != m_dtmFechaUltimoUltimoAcumu) fields.Add("dtmFechaUltimoUltimoAcumu");
			if (m_oldVehiculosKmMantenimiento.intKmAlarma1 != m_intKmAlarma1) fields.Add("intKmAlarma1");
			if (m_oldVehiculosKmMantenimiento.intKmAlarma2 != m_intKmAlarma2) fields.Add("intKmAlarma2");
			if (m_oldVehiculosKmMantenimiento.logAvisa != m_logAvisa) fields.Add("logAvisa");
			if (m_oldVehiculosKmMantenimiento.dtmFechaDetener != m_dtmFechaDetener) fields.Add("dtmFechaDetener");
			if (m_oldVehiculosKmMantenimiento.strLugarDetener != m_strLugarDetener) fields.Add("strLugarDetener");
			if (m_oldVehiculosKmMantenimiento.dtmFechaModif != m_dtmFechaModif) fields.Add("dtmFechaModif");
			if (m_oldVehiculosKmMantenimiento.lngIdUsuario != m_lngIdUsuario) fields.Add("lngIdUsuario");
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


		// Field for storing the VehiculosKmMantenimiento's strPlaca value
		private string m_strPlaca;

		// Field for storing the VehiculosKmMantenimiento's lngIdTipoMantenimiento value
		private int m_lngIdTipoMantenimiento;

		// Field for storing the VehiculosKmMantenimiento's dtmFechaUltimoCambio value
		private DateTime? m_dtmFechaUltimoCambio;

		// Field for storing the VehiculosKmMantenimiento's intKmUltimoCambio value
		private int? m_intKmUltimoCambio;

		// Field for storing the VehiculosKmMantenimiento's intKmSiguiente value
		private int? m_intKmSiguiente;

		// Field for storing the VehiculosKmMantenimiento's intKmAcumulado value
		private int? m_intKmAcumulado;

		// Field for storing the VehiculosKmMantenimiento's dtmFechaUltimoUltimoAcumu value
		private DateTime? m_dtmFechaUltimoUltimoAcumu;

		// Field for storing the VehiculosKmMantenimiento's intKmAlarma1 value
		private int? m_intKmAlarma1;

		// Field for storing the VehiculosKmMantenimiento's intKmAlarma2 value
		private int? m_intKmAlarma2;

		// Field for storing the VehiculosKmMantenimiento's logAvisa value
		private bool? m_logAvisa;

		// Field for storing the VehiculosKmMantenimiento's dtmFechaDetener value
		private DateTime? m_dtmFechaDetener;

		// Field for storing the VehiculosKmMantenimiento's strLugarDetener value
		private string m_strLugarDetener;

		// Field for storing the VehiculosKmMantenimiento's dtmFechaModif value
		private DateTime? m_dtmFechaModif;

		// Field for storing the VehiculosKmMantenimiento's lngIdUsuario value
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
		/// Attribute for access the VehiculosKmMantenimiento's strPlaca value (string)
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
		/// Attribute for access the VehiculosKmMantenimiento's lngIdTipoMantenimiento value (int)
		/// </summary>
		[DataMember]
		public int lngIdTipoMantenimiento
		{
			get { return m_lngIdTipoMantenimiento; }
			set 
			{
				m_changed=true;
				m_lngIdTipoMantenimiento = value;
			}
		}

		/// <summary>
		/// Attribute for access the VehiculosKmMantenimiento's dtmFechaUltimoCambio value (DateTime)
		/// </summary>
		[DataMember]
		public DateTime? dtmFechaUltimoCambio
		{
			get { return m_dtmFechaUltimoCambio; }
			set 
			{
				m_changed=true;
				m_dtmFechaUltimoCambio = value;
			}
		}

		/// <summary>
		/// Attribute for access the VehiculosKmMantenimiento's intKmUltimoCambio value (int)
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
		/// Attribute for access the VehiculosKmMantenimiento's intKmSiguiente value (int)
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
		/// Attribute for access the VehiculosKmMantenimiento's intKmAcumulado value (int)
		/// </summary>
		[DataMember]
		public int? intKmAcumulado
		{
			get { return m_intKmAcumulado; }
			set 
			{
				m_changed=true;
				m_intKmAcumulado = value;
			}
		}

		/// <summary>
		/// Attribute for access the VehiculosKmMantenimiento's dtmFechaUltimoUltimoAcumu value (DateTime)
		/// </summary>
		[DataMember]
		public DateTime? dtmFechaUltimoUltimoAcumu
		{
			get { return m_dtmFechaUltimoUltimoAcumu; }
			set 
			{
				m_changed=true;
				m_dtmFechaUltimoUltimoAcumu = value;
			}
		}

		/// <summary>
		/// Attribute for access the VehiculosKmMantenimiento's intKmAlarma1 value (int)
		/// </summary>
		[DataMember]
		public int? intKmAlarma1
		{
			get { return m_intKmAlarma1; }
			set 
			{
				m_changed=true;
				m_intKmAlarma1 = value;
			}
		}

		/// <summary>
		/// Attribute for access the VehiculosKmMantenimiento's intKmAlarma2 value (int)
		/// </summary>
		[DataMember]
		public int? intKmAlarma2
		{
			get { return m_intKmAlarma2; }
			set 
			{
				m_changed=true;
				m_intKmAlarma2 = value;
			}
		}

		/// <summary>
		/// Attribute for access the VehiculosKmMantenimiento's logAvisa value (bool)
		/// </summary>
		[DataMember]
		public bool? logAvisa
		{
			get { return m_logAvisa; }
			set 
			{
				m_changed=true;
				m_logAvisa = value;
			}
		}

		/// <summary>
		/// Attribute for access the VehiculosKmMantenimiento's dtmFechaDetener value (DateTime)
		/// </summary>
		[DataMember]
		public DateTime? dtmFechaDetener
		{
			get { return m_dtmFechaDetener; }
			set 
			{
				m_changed=true;
				m_dtmFechaDetener = value;
			}
		}

		/// <summary>
		/// Attribute for access the VehiculosKmMantenimiento's strLugarDetener value (string)
		/// </summary>
		[DataMember]
		public string strLugarDetener
		{
			get { return m_strLugarDetener; }
			set 
			{
				m_changed=true;
				m_strLugarDetener = value;
			}
		}

		/// <summary>
		/// Attribute for access the VehiculosKmMantenimiento's dtmFechaModif value (DateTime)
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
		/// Attribute for access the VehiculosKmMantenimiento's lngIdUsuario value (int)
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
				case "strPlaca": return strPlaca;
				case "lngIdTipoMantenimiento": return lngIdTipoMantenimiento;
				case "dtmFechaUltimoCambio": return dtmFechaUltimoCambio;
				case "intKmUltimoCambio": return intKmUltimoCambio;
				case "intKmSiguiente": return intKmSiguiente;
				case "intKmAcumulado": return intKmAcumulado;
				case "dtmFechaUltimoUltimoAcumu": return dtmFechaUltimoUltimoAcumu;
				case "intKmAlarma1": return intKmAlarma1;
				case "intKmAlarma2": return intKmAlarma2;
				case "logAvisa": return logAvisa;
				case "dtmFechaDetener": return dtmFechaDetener;
				case "strLugarDetener": return strLugarDetener;
				case "dtmFechaModif": return dtmFechaModif;
				case "lngIdUsuario": return lngIdUsuario;
				default: return null;
			}
		}

		public Type GetAttributeType(string pattribute)
		{
			return VehiculosKmMantenimientoController.Instance.GetMethodType(pattribute, this);
		}

		public string GetSqlKey()
		{
			return "[strPlaca] = '" + strPlaca.ToString()+ "'" + " AND [lngIdTipoMantenimiento] = " + lngIdTipoMantenimiento.ToString();
		}
		#endregion

	}

	#endregion

	#region VehiculosKmMantenimientoList object

	/// <summary>
	/// Class for reading and access a list of VehiculosKmMantenimiento object
	/// </summary>
	[CollectionDataContract]
	public partial class VehiculosKmMantenimientoList : List<VehiculosKmMantenimiento>
	{

		/// <summary>
		/// Default constructor
		/// </summary>
		public VehiculosKmMantenimientoList()
		{
		}
	}

	#endregion

}
