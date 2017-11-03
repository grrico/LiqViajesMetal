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
	#region VehiculoTraylers object

	[DataContract]
	public partial class VehiculoTraylers : IDTOObject
	{
		/// <summary>
		/// Default constructor
		/// </summary>
		public VehiculoTraylers()
		{
			m_Trayler = "";
			m_Placa = null;
			m_lngIdRegistro = null;
			m_lngIdRegistrRutaItemId = null;
			m_lngIdRegistrRuta = null;
			m_Fecha = null;
			m_Liquidado = false;
			m_Orden = null;
			m_changed=false;
		}
		        //Return the table name of object
		        public string TableName()
		        {
		            return "tblVehiculoTraylers";
		        }
		#region Undo 
		// Internal class for storing changes
		private VehiculoTraylers m_oldVehiculoTraylers;
		public void GenerateUndo()
		{
			m_oldVehiculoTraylers=new VehiculoTraylers();
			m_oldVehiculoTraylers.m_Trayler = m_Trayler;
			m_oldVehiculoTraylers.Placa = m_Placa;
			m_oldVehiculoTraylers.lngIdRegistro = m_lngIdRegistro;
			m_oldVehiculoTraylers.lngIdRegistrRutaItemId = m_lngIdRegistrRutaItemId;
			m_oldVehiculoTraylers.lngIdRegistrRuta = m_lngIdRegistrRuta;
			m_oldVehiculoTraylers.Fecha = m_Fecha;
			m_oldVehiculoTraylers.Liquidado = m_Liquidado;
			m_oldVehiculoTraylers.Orden = m_Orden;
		}

		public VehiculoTraylers OldVehiculoTraylers
		{
			get { return m_oldVehiculoTraylers;}
		}
		// Return the changed fields
		public string[] FieldChanged()
		{
			List<string> fields=new List<string>();
			if (m_oldVehiculoTraylers.Placa != m_Placa) fields.Add("Placa");
			if (m_oldVehiculoTraylers.lngIdRegistro != m_lngIdRegistro) fields.Add("lngIdRegistro");
			if (m_oldVehiculoTraylers.lngIdRegistrRutaItemId != m_lngIdRegistrRutaItemId) fields.Add("lngIdRegistrRutaItemId");
			if (m_oldVehiculoTraylers.lngIdRegistrRuta != m_lngIdRegistrRuta) fields.Add("lngIdRegistrRuta");
			if (m_oldVehiculoTraylers.Fecha != m_Fecha) fields.Add("Fecha");
			if (m_oldVehiculoTraylers.Liquidado != m_Liquidado) fields.Add("Liquidado");
			if (m_oldVehiculoTraylers.Orden != m_Orden) fields.Add("Orden");
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


		// Field for storing the VehiculoTraylers's Placa value
		private string m_Placa;

		// Field for storing the VehiculoTraylers's lngIdRegistro value
		private int? m_lngIdRegistro;

		// Field for storing the VehiculoTraylers's lngIdRegistrRutaItemId value
		private int? m_lngIdRegistrRutaItemId;

		// Field for storing the VehiculoTraylers's lngIdRegistrRuta value
		private int? m_lngIdRegistrRuta;

		// Field for storing the VehiculoTraylers's Fecha value
		private DateTime? m_Fecha;

		// Field for storing the VehiculoTraylers's Liquidado value
		private bool? m_Liquidado;

		// Field for storing the VehiculoTraylers's Orden value
		private int? m_Orden;

		// Field for storing the VehiculoTraylers's Trayler value
		private string m_Trayler;

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
		/// Attribute for access the VehiculoTraylers's Placa value (string)
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
		/// Attribute for access the VehiculoTraylers's lngIdRegistro value (int)
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
		/// Attribute for access the VehiculoTraylers's lngIdRegistrRutaItemId value (int)
		/// </summary>
		[DataMember]
		public int? lngIdRegistrRutaItemId
		{
			get { return m_lngIdRegistrRutaItemId; }
			set 
			{
				m_changed=true;
				m_lngIdRegistrRutaItemId = value;
			}
		}

		/// <summary>
		/// Attribute for access the VehiculoTraylers's lngIdRegistrRuta value (int)
		/// </summary>
		[DataMember]
		public int? lngIdRegistrRuta
		{
			get { return m_lngIdRegistrRuta; }
			set 
			{
				m_changed=true;
				m_lngIdRegistrRuta = value;
			}
		}

		/// <summary>
		/// Attribute for access the VehiculoTraylers's Fecha value (DateTime)
		/// </summary>
		[DataMember]
		public DateTime? Fecha
		{
			get { return m_Fecha; }
			set 
			{
				m_changed=true;
				m_Fecha = value;
			}
		}

		/// <summary>
		/// Attribute for access the VehiculoTraylers's Liquidado value (bool)
		/// </summary>
		[DataMember]
		public bool? Liquidado
		{
			get { return m_Liquidado; }
			set 
			{
				m_changed=true;
				m_Liquidado = value;
			}
		}

		/// <summary>
		/// Attribute for access the VehiculoTraylers's Orden value (int)
		/// </summary>
		[DataMember]
		public int? Orden
		{
			get { return m_Orden; }
			set 
			{
				m_changed=true;
				m_Orden = value;
			}
		}

		/// <summary>
		/// Attribute for access the VehiculoTraylers's Trayler value (string)
		/// </summary>
		[DataMember]
		public string Trayler
		{
			get { return m_Trayler; }
			set 
			{
				m_changed=true;
				m_Trayler = value;
			}
		}

		public object GetAttribute(string pattribute)
		{
			switch (pattribute)
			{
				case "Placa": return Placa;
				case "lngIdRegistro": return lngIdRegistro;
				case "lngIdRegistrRutaItemId": return lngIdRegistrRutaItemId;
				case "lngIdRegistrRuta": return lngIdRegistrRuta;
				case "Fecha": return Fecha;
				case "Liquidado": return Liquidado;
				case "Orden": return Orden;
				case "Trayler": return Trayler;
				default: return null;
			}
		}

		public Type GetAttributeType(string pattribute)
		{
			return VehiculoTraylersController.Instance.GetMethodType(pattribute, this);
		}

		public string GetSqlKey()
		{
			return "[Trayler] = '" + Trayler.ToString()+ "'";
		}
		#endregion

	}

	#endregion

	#region VehiculoTraylersList object

	/// <summary>
	/// Class for reading and access a list of VehiculoTraylers object
	/// </summary>
	[CollectionDataContract]
	public partial class VehiculoTraylersList : List<VehiculoTraylers>
	{

		/// <summary>
		/// Default constructor
		/// </summary>
		public VehiculoTraylersList()
		{
		}
	}

	#endregion

}
