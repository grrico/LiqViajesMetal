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
	#region Catalogo object

	[DataContract]
	public partial class Catalogo : IDTOObject
	{
		/// <summary>
		/// Default constructor
		/// </summary>
		public Catalogo()
		{
			m_nombre_empresa = "";
			m_fecha_actual = DateTime.Now.Date;
			m_sigla = "";
			m_nit = 0;
			m_version = 0;
			m_direccion = "";
			m_telefono = "";
			m_changed=false;
		}
		        //Return the table name of object
		        public string TableName()
		        {
		            return "tblCatalogo";
		        }
		#region Undo 
		// Internal class for storing changes
		private Catalogo m_oldCatalogo;
		public void GenerateUndo()
		{
			m_oldCatalogo=new Catalogo();
			m_oldCatalogo.m_nombre_empresa = m_nombre_empresa;
			m_oldCatalogo.fecha_actual = m_fecha_actual;
			m_oldCatalogo.sigla = m_sigla;
			m_oldCatalogo.nit = m_nit;
			m_oldCatalogo.version = m_version;
			m_oldCatalogo.direccion = m_direccion;
			m_oldCatalogo.telefono = m_telefono;
		}

		public Catalogo OldCatalogo
		{
			get { return m_oldCatalogo;}
		}
		// Return the changed fields
		public string[] FieldChanged()
		{
			List<string> fields=new List<string>();
			if (m_oldCatalogo.fecha_actual != m_fecha_actual) fields.Add("fecha_actual");
			if (m_oldCatalogo.sigla != m_sigla) fields.Add("sigla");
			if (m_oldCatalogo.nit != m_nit) fields.Add("nit");
			if (m_oldCatalogo.version != m_version) fields.Add("version");
			if (m_oldCatalogo.direccion != m_direccion) fields.Add("direccion");
			if (m_oldCatalogo.telefono != m_telefono) fields.Add("telefono");
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


		// Field for storing the Catalogo's nombre_empresa value
		private string m_nombre_empresa;

		// Field for storing the Catalogo's fecha_actual value
		private DateTime m_fecha_actual;

		// Field for storing the Catalogo's sigla value
		private string m_sigla;

		// Field for storing the Catalogo's nit value
		private int m_nit;

		// Field for storing the Catalogo's version value
		private int m_version;

		// Field for storing the Catalogo's direccion value
		private string m_direccion;

		// Field for storing the Catalogo's telefono value
		private string m_telefono;

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
		/// Attribute for access the Catalogo's nombre_empresa value (string)
		/// </summary>
		[DataMember]
		public string nombre_empresa
		{
			get { return m_nombre_empresa; }
			set 
			{
				m_changed=true;
				m_nombre_empresa = value;
			}
		}

		/// <summary>
		/// Attribute for access the Catalogo's fecha_actual value (DateTime)
		/// </summary>
		[DataMember]
		public DateTime fecha_actual
		{
			get { return m_fecha_actual; }
			set 
			{
				m_changed=true;
				m_fecha_actual = value;
			}
		}

		/// <summary>
		/// Attribute for access the Catalogo's sigla value (string)
		/// </summary>
		[DataMember]
		public string sigla
		{
			get { return m_sigla; }
			set 
			{
				m_changed=true;
				m_sigla = value;
			}
		}

		/// <summary>
		/// Attribute for access the Catalogo's nit value (int)
		/// </summary>
		[DataMember]
		public int nit
		{
			get { return m_nit; }
			set 
			{
				m_changed=true;
				m_nit = value;
			}
		}

		/// <summary>
		/// Attribute for access the Catalogo's version value (int)
		/// </summary>
		[DataMember]
		public int version
		{
			get { return m_version; }
			set 
			{
				m_changed=true;
				m_version = value;
			}
		}

		/// <summary>
		/// Attribute for access the Catalogo's direccion value (string)
		/// </summary>
		[DataMember]
		public string direccion
		{
			get { return m_direccion; }
			set 
			{
				m_changed=true;
				m_direccion = value;
			}
		}

		/// <summary>
		/// Attribute for access the Catalogo's telefono value (string)
		/// </summary>
		[DataMember]
		public string telefono
		{
			get { return m_telefono; }
			set 
			{
				m_changed=true;
				m_telefono = value;
			}
		}

		public object GetAttribute(string pattribute)
		{
			switch (pattribute)
			{
				case "nombre_empresa": return nombre_empresa;
				case "fecha_actual": return fecha_actual;
				case "sigla": return sigla;
				case "nit": return nit;
				case "version": return version;
				case "direccion": return direccion;
				case "telefono": return telefono;
				default: return null;
			}
		}

		public Type GetAttributeType(string pattribute)
		{
			return CatalogoController.Instance.GetMethodType(pattribute, this);
		}

		public string GetSqlKey()
		{
			return "[nombre_empresa] = '" + nombre_empresa.ToString()+ "'";
		}
		#endregion

	}

	#endregion

	#region CatalogoList object

	/// <summary>
	/// Class for reading and access a list of Catalogo object
	/// </summary>
	[CollectionDataContract]
	public partial class CatalogoList : List<Catalogo>
	{

		/// <summary>
		/// Default constructor
		/// </summary>
		public CatalogoList()
		{
		}
	}

	#endregion

}
