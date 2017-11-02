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
	#region TipoVehiculo object

	[DataContract]
	public partial class TipoVehiculo : IDTOObject
	{
		/// <summary>
		/// Default constructor
		/// </summary>
		public TipoVehiculo()
		{
			m_Codigo = 0;
			m_Descripcion = null;
			m_Activo = false;
			m_changed=false;
		}
		        //Return the table name of object
		        public string TableName()
		        {
		            return "TipoVehiculo";
		        }
		#region Undo 
		// Internal class for storing changes
		private TipoVehiculo m_oldTipoVehiculo;
		public void GenerateUndo()
		{
			m_oldTipoVehiculo=new TipoVehiculo();
			m_oldTipoVehiculo.m_Codigo = m_Codigo;
			m_oldTipoVehiculo.Descripcion = m_Descripcion;
			m_oldTipoVehiculo.Activo = m_Activo;
		}

		public TipoVehiculo OldTipoVehiculo
		{
			get { return m_oldTipoVehiculo;}
		}
		// Return the changed fields
		public string[] FieldChanged()
		{
			List<string> fields=new List<string>();
			if (m_oldTipoVehiculo.Descripcion != m_Descripcion) fields.Add("Descripcion");
			if (m_oldTipoVehiculo.Activo != m_Activo) fields.Add("Activo");
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


		// Field for storing the TipoVehiculo's Codigo value
		private int m_Codigo;

		// Field for storing the TipoVehiculo's Descripcion value
		private string m_Descripcion;

		// Field for storing the TipoVehiculo's Activo value
		private bool? m_Activo;

		// Evaluate changed state
		private bool m_changed=false;
		// Field for storing the reference to foreign RutasList object accessed by Codigo
		private RutasList m_Rutas;


		#endregion

		#region Attributes

		// Return if object changed
		public bool Changed
		{
			get { return m_changed;}
			set { m_changed=value;}
		}
		/// <summary>
		/// Attribute for access the TipoVehiculo's Codigo value (int)
		/// </summary>
		[DataMember]
		public int Codigo
		{
			get { return m_Codigo; }
			set 
			{
				m_changed=true;
				m_Codigo = value;
			}
		}

		/// <summary>
		/// Attribute for access the TipoVehiculo's Descripcion value (string)
		/// </summary>
		[DataMember]
		public string Descripcion
		{
			get { return m_Descripcion; }
			set 
			{
				m_changed=true;
				m_Descripcion = value;
			}
		}

		/// <summary>
		/// Attribute for access the TipoVehiculo's Activo value (bool)
		/// </summary>
		[DataMember]
		public bool? Activo
		{
			get { return m_Activo; }
			set 
			{
				m_changed=true;
				m_Activo = value;
			}
		}

		public object GetAttribute(string pattribute)
		{
			switch (pattribute)
			{
				case "Codigo": return Codigo;
				case "Descripcion": return Descripcion;
				case "Activo": return Activo;
				default: return null;
			}
		}

		public Type GetAttributeType(string pattribute)
		{
			return TipoVehiculoController.Instance.GetMethodType(pattribute, this);
		}

		public string GetSqlKey()
		{
			return "[Codigo] = " + Codigo.ToString();
		}
		/// <summary>
		/// Gets or sets the reference to foreign RutasList object accessed by Codigo
		/// </summary>
		public RutasList Rutas
		{
			get
			{
				if (m_Rutas == null)
				{
					m_Rutas = RutasController.Instance.GetBy_TipoVehiculoCodigo(Codigo);
			}

			return m_Rutas;
		}
		set { m_Rutas = value; }
	}

	#endregion

}

#endregion

#region TipoVehiculoList object

/// <summary>
/// Class for reading and access a list of TipoVehiculo object
/// </summary>
[CollectionDataContract]
public partial class TipoVehiculoList : List<TipoVehiculo>
{

	/// <summary>
	/// Default constructor
	/// </summary>
	public TipoVehiculoList()
	{
	}
}

#endregion

}
