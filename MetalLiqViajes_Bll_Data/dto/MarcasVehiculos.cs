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
	#region MarcasVehiculos object

	[DataContract]
	public partial class MarcasVehiculos : IDTOObject
	{
		/// <summary>
		/// Default constructor
		/// </summary>
		public MarcasVehiculos()
		{
			m_lngIdRegistro = 0;
			m_strMarca = null;
			m_changed=false;
		}
		        //Return the table name of object
		        public string TableName()
		        {
		            return "tblMarcasVehiculos";
		        }
		#region Undo 
		// Internal class for storing changes
		private MarcasVehiculos m_oldMarcasVehiculos;
		public void GenerateUndo()
		{
			m_oldMarcasVehiculos=new MarcasVehiculos();
			m_oldMarcasVehiculos.m_lngIdRegistro = m_lngIdRegistro;
			m_oldMarcasVehiculos.strMarca = m_strMarca;
		}

		public MarcasVehiculos OldMarcasVehiculos
		{
			get { return m_oldMarcasVehiculos;}
		}
		// Return the changed fields
		public string[] FieldChanged()
		{
			List<string> fields=new List<string>();
			if (m_oldMarcasVehiculos.strMarca != m_strMarca) fields.Add("strMarca");
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


		// Field for storing the MarcasVehiculos's strMarca value
		private string m_strMarca;

		// Field for storing the MarcasVehiculos's lngIdRegistro value
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
		/// Attribute for access the MarcasVehiculos's strMarca value (string)
		/// </summary>
		[DataMember]
		public string strMarca
		{
			get { return m_strMarca; }
			set 
			{
				m_changed=true;
				m_strMarca = value;
			}
		}

		/// <summary>
		/// Attribute for access the MarcasVehiculos's lngIdRegistro value (int)
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
				case "strMarca": return strMarca;
				case "lngIdRegistro": return lngIdRegistro;
				default: return null;
			}
		}

		public Type GetAttributeType(string pattribute)
		{
			return MarcasVehiculosController.Instance.GetMethodType(pattribute, this);
		}

		public string GetSqlKey()
		{
			return "[lngIdRegistro] = " + lngIdRegistro.ToString();
		}
		#endregion

	}

	#endregion

	#region MarcasVehiculosList object

	/// <summary>
	/// Class for reading and access a list of MarcasVehiculos object
	/// </summary>
	[CollectionDataContract]
	public partial class MarcasVehiculosList : List<MarcasVehiculos>
	{

		/// <summary>
		/// Default constructor
		/// </summary>
		public MarcasVehiculosList()
		{
		}
	}

	#endregion

}
