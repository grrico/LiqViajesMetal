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
	#region TipoMantenimiento object

	[DataContract]
	public partial class TipoMantenimiento : IDTOObject
	{
		/// <summary>
		/// Default constructor
		/// </summary>
		public TipoMantenimiento()
		{
			m_lngIdTipoMantenimiento = 0;
			m_strTipoMantenimiento = null;
			m_logActivar = false;
			m_intValorMantenimiento = null;
			m_intValorAviso = null;
			m_intValorAviso2 = null;
			m_changed=false;
		}
		        //Return the table name of object
		        public string TableName()
		        {
		            return "tblTipoMantenimiento";
		        }
		#region Undo 
		// Internal class for storing changes
		private TipoMantenimiento m_oldTipoMantenimiento;
		public void GenerateUndo()
		{
			m_oldTipoMantenimiento=new TipoMantenimiento();
			m_oldTipoMantenimiento.m_lngIdTipoMantenimiento = m_lngIdTipoMantenimiento;
			m_oldTipoMantenimiento.strTipoMantenimiento = m_strTipoMantenimiento;
			m_oldTipoMantenimiento.logActivar = m_logActivar;
			m_oldTipoMantenimiento.intValorMantenimiento = m_intValorMantenimiento;
			m_oldTipoMantenimiento.intValorAviso = m_intValorAviso;
			m_oldTipoMantenimiento.intValorAviso2 = m_intValorAviso2;
		}

		public TipoMantenimiento OldTipoMantenimiento
		{
			get { return m_oldTipoMantenimiento;}
		}
		// Return the changed fields
		public string[] FieldChanged()
		{
			List<string> fields=new List<string>();
			if (m_oldTipoMantenimiento.strTipoMantenimiento != m_strTipoMantenimiento) fields.Add("strTipoMantenimiento");
			if (m_oldTipoMantenimiento.logActivar != m_logActivar) fields.Add("logActivar");
			if (m_oldTipoMantenimiento.intValorMantenimiento != m_intValorMantenimiento) fields.Add("intValorMantenimiento");
			if (m_oldTipoMantenimiento.intValorAviso != m_intValorAviso) fields.Add("intValorAviso");
			if (m_oldTipoMantenimiento.intValorAviso2 != m_intValorAviso2) fields.Add("intValorAviso2");
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


		// Field for storing the TipoMantenimiento's strTipoMantenimiento value
		private string m_strTipoMantenimiento;

		// Field for storing the TipoMantenimiento's logActivar value
		private bool? m_logActivar;

		// Field for storing the TipoMantenimiento's intValorMantenimiento value
		private float? m_intValorMantenimiento;

		// Field for storing the TipoMantenimiento's intValorAviso value
		private float? m_intValorAviso;

		// Field for storing the TipoMantenimiento's intValorAviso2 value
		private float? m_intValorAviso2;

		// Field for storing the TipoMantenimiento's lngIdTipoMantenimiento value
		private int m_lngIdTipoMantenimiento;

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
		/// Attribute for access the TipoMantenimiento's strTipoMantenimiento value (string)
		/// </summary>
		[DataMember]
		public string strTipoMantenimiento
		{
			get { return m_strTipoMantenimiento; }
			set 
			{
				m_changed=true;
				m_strTipoMantenimiento = value;
			}
		}

		/// <summary>
		/// Attribute for access the TipoMantenimiento's logActivar value (bool)
		/// </summary>
		[DataMember]
		public bool? logActivar
		{
			get { return m_logActivar; }
			set 
			{
				m_changed=true;
				m_logActivar = value;
			}
		}

		/// <summary>
		/// Attribute for access the TipoMantenimiento's intValorMantenimiento value (float)
		/// </summary>
		[DataMember]
		public float? intValorMantenimiento
		{
			get { return m_intValorMantenimiento; }
			set 
			{
				m_changed=true;
				m_intValorMantenimiento = value;
			}
		}

		/// <summary>
		/// Attribute for access the TipoMantenimiento's intValorAviso value (float)
		/// </summary>
		[DataMember]
		public float? intValorAviso
		{
			get { return m_intValorAviso; }
			set 
			{
				m_changed=true;
				m_intValorAviso = value;
			}
		}

		/// <summary>
		/// Attribute for access the TipoMantenimiento's intValorAviso2 value (float)
		/// </summary>
		[DataMember]
		public float? intValorAviso2
		{
			get { return m_intValorAviso2; }
			set 
			{
				m_changed=true;
				m_intValorAviso2 = value;
			}
		}

		/// <summary>
		/// Attribute for access the TipoMantenimiento's lngIdTipoMantenimiento value (int)
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

		public object GetAttribute(string pattribute)
		{
			switch (pattribute)
			{
				case "strTipoMantenimiento": return strTipoMantenimiento;
				case "logActivar": return logActivar;
				case "intValorMantenimiento": return intValorMantenimiento;
				case "intValorAviso": return intValorAviso;
				case "intValorAviso2": return intValorAviso2;
				case "lngIdTipoMantenimiento": return lngIdTipoMantenimiento;
				default: return null;
			}
		}

		public Type GetAttributeType(string pattribute)
		{
			return TipoMantenimientoController.Instance.GetMethodType(pattribute, this);
		}

		public string GetSqlKey()
		{
			return "[lngIdTipoMantenimiento] = " + lngIdTipoMantenimiento.ToString();
		}
		#endregion

	}

	#endregion

	#region TipoMantenimientoList object

	/// <summary>
	/// Class for reading and access a list of TipoMantenimiento object
	/// </summary>
	[CollectionDataContract]
	public partial class TipoMantenimientoList : List<TipoMantenimiento>
	{

		/// <summary>
		/// Default constructor
		/// </summary>
		public TipoMantenimientoList()
		{
		}
	}

	#endregion

}
