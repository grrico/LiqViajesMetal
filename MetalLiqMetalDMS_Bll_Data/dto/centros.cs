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

namespace LiqMetalDMS_Bll_Data
{
	#region centros object

	[DataContract]
	public partial class centros : IDTOObject
	{
		/// <summary>
		/// Default constructor
		/// </summary>
		public centros()
		{
			m_id = 0;
			m_centro = 0;
			m_descripcion = "";
			m_grupo = "";
			m_subgrupo = "";
			m_nomina = null;
			m_exportado = ' ';
			m_centro_alfa = null;
			m_inactivo = false;
			m_changed=false;
		}
		        //Return the table name of object
		        public string TableName()
		        {
		            return "centros";
		        }
		#region Undo 
		// Internal class for storing changes
		private centros m_oldcentros;
		public void GenerateUndo()
		{
			m_oldcentros=new centros();
			m_oldcentros.m_id = m_id;
			m_oldcentros.m_centro = m_centro;
			m_oldcentros.descripcion = m_descripcion;
			m_oldcentros.grupo = m_grupo;
			m_oldcentros.subgrupo = m_subgrupo;
			m_oldcentros.nomina = m_nomina;
			m_oldcentros.exportado = m_exportado;
			m_oldcentros.centro_alfa = m_centro_alfa;
			m_oldcentros.inactivo = m_inactivo;
		}

		public centros Oldcentros
		{
			get { return m_oldcentros;}
		}
		// Return the changed fields
		public string[] FieldChanged()
		{
			List<string> fields=new List<string>();
			if (m_oldcentros.descripcion != m_descripcion) fields.Add("descripcion");
			if (m_oldcentros.grupo != m_grupo) fields.Add("grupo");
			if (m_oldcentros.subgrupo != m_subgrupo) fields.Add("subgrupo");
			if (m_oldcentros.nomina != m_nomina) fields.Add("nomina");
			if (m_oldcentros.exportado != m_exportado) fields.Add("exportado");
			if (m_oldcentros.centro_alfa != m_centro_alfa) fields.Add("centro_alfa");
			if (m_oldcentros.inactivo != m_inactivo) fields.Add("inactivo");
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


		// Field for storing the centros's id value
		private int m_id;

		// Field for storing the centros's centro value
		private int m_centro;

		// Field for storing the centros's descripcion value
		private string m_descripcion;

		// Field for storing the centros's grupo value
		private string m_grupo;

		// Field for storing the centros's subgrupo value
		private string m_subgrupo;

		// Field for storing the centros's nomina value
		private string m_nomina;

		// Field for storing the centros's exportado value
		private char? m_exportado;

		// Field for storing the centros's centro_alfa value
		private string m_centro_alfa;

		// Field for storing the centros's inactivo value
		private bool m_inactivo;

		// Evaluate changed state
		private bool m_changed=false;
		// Field for storing the reference to foreign activosList object accessed by centro
		private activosList m_activos;


		#endregion

		#region Attributes

		// Return if object changed
		public bool Changed
		{
			get { return m_changed;}
			set { m_changed=value;}
		}
		/// <summary>
		/// Attribute for access the centros's id value (int)
		/// </summary>
		[DataMember]
		public int id
		{
			get { return m_id; }
			set 
			{
				m_changed=true;
				m_id = value;
			}
		}

		/// <summary>
		/// Attribute for access the centros's centro value (int)
		/// </summary>
		[DataMember]
		public int centro
		{
			get { return m_centro; }
			set 
			{
				m_changed=true;
				m_centro = value;
			}
		}

		/// <summary>
		/// Attribute for access the centros's descripcion value (string)
		/// </summary>
		[DataMember]
		public string descripcion
		{
			get { return m_descripcion; }
			set 
			{
				m_changed=true;
				m_descripcion = value;
			}
		}

		/// <summary>
		/// Attribute for access the centros's grupo value (string)
		/// </summary>
		[DataMember]
		public string grupo
		{
			get { return m_grupo; }
			set 
			{
				m_changed=true;
				m_grupo = value;
			}
		}

		/// <summary>
		/// Attribute for access the centros's subgrupo value (string)
		/// </summary>
		[DataMember]
		public string subgrupo
		{
			get { return m_subgrupo; }
			set 
			{
				m_changed=true;
				m_subgrupo = value;
			}
		}

		/// <summary>
		/// Attribute for access the centros's nomina value (string)
		/// </summary>
		[DataMember]
		public string nomina
		{
			get { return m_nomina; }
			set 
			{
				m_changed=true;
				m_nomina = value;
			}
		}

		/// <summary>
		/// Attribute for access the centros's exportado value (char)
		/// </summary>
		[DataMember]
		public char? exportado
		{
			get { return m_exportado; }
			set 
			{
				m_changed=true;
				m_exportado = value;
			}
		}

		/// <summary>
		/// Attribute for access the centros's centro_alfa value (string)
		/// </summary>
		[DataMember]
		public string centro_alfa
		{
			get { return m_centro_alfa; }
			set 
			{
				m_changed=true;
				m_centro_alfa = value;
			}
		}

		/// <summary>
		/// Attribute for access the centros's inactivo value (bool)
		/// </summary>
		[DataMember]
		public bool inactivo
		{
			get { return m_inactivo; }
			set 
			{
				m_changed=true;
				m_inactivo = value;
			}
		}

		public object GetAttribute(string pattribute)
		{
			switch (pattribute)
			{
				case "id": return id;
				case "centro": return centro;
				case "descripcion": return descripcion;
				case "grupo": return grupo;
				case "subgrupo": return subgrupo;
				case "nomina": return nomina;
				case "exportado": return exportado;
				case "centro_alfa": return centro_alfa;
				case "inactivo": return inactivo;
				default: return null;
			}
		}

		public Type GetAttributeType(string pattribute)
		{
			return centrosController.Instance.GetMethodType(pattribute, this);
		}

		public string GetSqlKey()
		{
			return "[id] = " + id.ToString() + " AND [centro] = " + centro.ToString();
		}
		/// <summary>
		/// Gets or sets the reference to foreign activosList object accessed by centro
		/// </summary>
		public activosList activos
		{
			get
			{
				if (m_activos == null)
				{
					m_activos = activosController.Instance.GetBy_centro(centro);
			}

			return m_activos;
		}
		set { m_activos = value; }
	}

	#endregion

}

#endregion

#region centrosList object

/// <summary>
/// Class for reading and access a list of centros object
/// </summary>
[CollectionDataContract]
public partial class centrosList : List<centros>
{

	/// <summary>
	/// Default constructor
	/// </summary>
	public centrosList()
	{
	}
}

#endregion

}
