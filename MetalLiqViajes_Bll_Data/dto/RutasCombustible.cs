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
	#region RutasCombustible object

	[DataContract]
	public partial class RutasCombustible : IDTOObject
	{
		/// <summary>
		/// Default constructor
		/// </summary>
		public RutasCombustible()
		{
			m_lngIdRegistro = 0;
			m_strNombreGrupo = null;
			m_cutCombustible = null;
			m_TipoVehiculo = null;
			m_DescripcionVehiculo = null;
			m_changed=false;
		}
		        //Return the table name of object
		        public string TableName()
		        {
		            return "tblRutasCombustible";
		        }
		#region Undo 
		// Internal class for storing changes
		private RutasCombustible m_oldRutasCombustible;
		public void GenerateUndo()
		{
			m_oldRutasCombustible=new RutasCombustible();
			m_oldRutasCombustible.m_lngIdRegistro = m_lngIdRegistro;
			m_oldRutasCombustible.strNombreGrupo = m_strNombreGrupo;
			m_oldRutasCombustible.cutCombustible = m_cutCombustible;
			m_oldRutasCombustible.TipoVehiculo = m_TipoVehiculo;
			m_oldRutasCombustible.DescripcionVehiculo = m_DescripcionVehiculo;
		}

		public RutasCombustible OldRutasCombustible
		{
			get { return m_oldRutasCombustible;}
		}
		// Return the changed fields
		public string[] FieldChanged()
		{
			List<string> fields=new List<string>();
			if (m_oldRutasCombustible.strNombreGrupo != m_strNombreGrupo) fields.Add("strNombreGrupo");
			if (m_oldRutasCombustible.cutCombustible != m_cutCombustible) fields.Add("cutCombustible");
			if (m_oldRutasCombustible.TipoVehiculo != m_TipoVehiculo) fields.Add("TipoVehiculo");
			if (m_oldRutasCombustible.DescripcionVehiculo != m_DescripcionVehiculo) fields.Add("DescripcionVehiculo");
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


		// Field for storing the RutasCombustible's strNombreGrupo value
		private string m_strNombreGrupo;

		// Field for storing the RutasCombustible's cutCombustible value
		private decimal? m_cutCombustible;

		// Field for storing the RutasCombustible's TipoVehiculo value
		private string m_TipoVehiculo;

		// Field for storing the RutasCombustible's DescripcionVehiculo value
		private string m_DescripcionVehiculo;

		// Field for storing the RutasCombustible's lngIdRegistro value
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
		/// Attribute for access the RutasCombustible's strNombreGrupo value (string)
		/// </summary>
		[DataMember]
		public string strNombreGrupo
		{
			get { return m_strNombreGrupo; }
			set 
			{
				m_changed=true;
				m_strNombreGrupo = value;
			}
		}

		/// <summary>
		/// Attribute for access the RutasCombustible's cutCombustible value (decimal)
		/// </summary>
		[DataMember]
		public decimal? cutCombustible
		{
			get { return m_cutCombustible; }
			set 
			{
				m_changed=true;
				m_cutCombustible = value;
			}
		}

		/// <summary>
		/// Attribute for access the RutasCombustible's TipoVehiculo value (string)
		/// </summary>
		[DataMember]
		public string TipoVehiculo
		{
			get { return m_TipoVehiculo; }
			set 
			{
				m_changed=true;
				m_TipoVehiculo = value;
			}
		}

		/// <summary>
		/// Attribute for access the RutasCombustible's DescripcionVehiculo value (string)
		/// </summary>
		[DataMember]
		public string DescripcionVehiculo
		{
			get { return m_DescripcionVehiculo; }
			set 
			{
				m_changed=true;
				m_DescripcionVehiculo = value;
			}
		}

		/// <summary>
		/// Attribute for access the RutasCombustible's lngIdRegistro value (int)
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
				case "strNombreGrupo": return strNombreGrupo;
				case "cutCombustible": return cutCombustible;
				case "TipoVehiculo": return TipoVehiculo;
				case "DescripcionVehiculo": return DescripcionVehiculo;
				case "lngIdRegistro": return lngIdRegistro;
				default: return null;
			}
		}

		public Type GetAttributeType(string pattribute)
		{
			return RutasCombustibleController.Instance.GetMethodType(pattribute, this);
		}

		public string GetSqlKey()
		{
			return "[lngIdRegistro] = " + lngIdRegistro.ToString();
		}
		#endregion

	}

	#endregion

	#region RutasCombustibleList object

	/// <summary>
	/// Class for reading and access a list of RutasCombustible object
	/// </summary>
	[CollectionDataContract]
	public partial class RutasCombustibleList : List<RutasCombustible>
	{

		/// <summary>
		/// Default constructor
		/// </summary>
		public RutasCombustibleList()
		{
		}
	}

	#endregion

}
