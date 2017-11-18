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
	#region RutasOrigen object

	[DataContract]
	public partial class RutasOrigen : IDTOObject
	{
		/// <summary>
		/// Default constructor
		/// </summary>
		public RutasOrigen()
		{
			m_Codigo = 0;
			m_Origen = null;
			m_changed=false;
		}
		        //Return the table name of object
		        public string TableName()
		        {
		            return "RutasOrigen";
		        }
		#region Undo 
		// Internal class for storing changes
		private RutasOrigen m_oldRutasOrigen;
		public void GenerateUndo()
		{
			m_oldRutasOrigen=new RutasOrigen();
			m_oldRutasOrigen.m_Codigo = m_Codigo;
			m_oldRutasOrigen.Origen = m_Origen;
		}

		public RutasOrigen OldRutasOrigen
		{
			get { return m_oldRutasOrigen;}
		}
		// Return the changed fields
		public string[] FieldChanged()
		{
			List<string> fields=new List<string>();
			if (m_oldRutasOrigen.Origen != m_Origen) fields.Add("Origen");
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


		// Field for storing the RutasOrigen's Codigo value
		private int m_Codigo;

		// Field for storing the RutasOrigen's Origen value
		private string m_Origen;

		// Evaluate changed state
		private bool m_changed=false;
		// Field for storing the reference to foreign RutasDestinoList object accessed by Codigo
		private RutasDestinoList m_RutasDestino;

		// Field for storing the reference to foreign RutasOrigenTipoTrailerList object accessed by Codigo
		private RutasOrigenTipoTrailerList m_RutasOrigenTipoTrailer;

		// Field for storing the reference to foreign RutasList object accessed by Codigo
		private RutasList m_Rutas;

		// Field for storing the reference to foreign RutasOrigenDestinoList object accessed by Codigo
		private RutasOrigenDestinoList m_RutasOrigenDestino;


		#endregion

		#region Attributes

		// Return if object changed
		public bool Changed
		{
			get { return m_changed;}
			set { m_changed=value;}
		}
		/// <summary>
		/// Attribute for access the RutasOrigen's Codigo value (int)
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
		/// Attribute for access the RutasOrigen's Origen value (string)
		/// </summary>
		[DataMember]
		public string Origen
		{
			get { return m_Origen; }
			set 
			{
				m_changed=true;
				m_Origen = value;
			}
		}

		public object GetAttribute(string pattribute)
		{
			switch (pattribute)
			{
				case "Codigo": return Codigo;
				case "Origen": return Origen;
				default: return null;
			}
		}

		public Type GetAttributeType(string pattribute)
		{
			return RutasOrigenController.Instance.GetMethodType(pattribute, this);
		}

		public string GetSqlKey()
		{
			return "[Codigo] = " + Codigo.ToString();
		}
		/// <summary>
		/// Gets or sets the reference to foreign RutasDestinoList object accessed by Codigo
		/// </summary>
		public RutasDestinoList RutasDestino
		{
			get
			{
				if (m_RutasDestino == null)
				{
					m_RutasDestino = RutasDestinoController.Instance.GetBy_RutasOrigenCodigo(Codigo);
			}

			return m_RutasDestino;
		}
		set { m_RutasDestino = value; }
	}

	/// <summary>
	/// Gets or sets the reference to foreign RutasOrigenTipoTrailerList object accessed by Codigo
	/// </summary>
	public RutasOrigenTipoTrailerList RutasOrigenTipoTrailer
	{
		get
		{
			if (m_RutasOrigenTipoTrailer == null)
			{
				m_RutasOrigenTipoTrailer = RutasOrigenTipoTrailerController.Instance.GetBy_RutasOrigenCodigo(Codigo);
		}

		return m_RutasOrigenTipoTrailer;
	}
	set { m_RutasOrigenTipoTrailer = value; }
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
			m_Rutas = RutasController.Instance.GetBy_RutasOrigenCodigo(Codigo);
	}

	return m_Rutas;
}
set { m_Rutas = value; }
}

/// <summary>
/// Gets or sets the reference to foreign RutasOrigenDestinoList object accessed by Codigo
/// </summary>
public RutasOrigenDestinoList RutasOrigenDestino
{
	get
	{
		if (m_RutasOrigenDestino == null)
		{
			m_RutasOrigenDestino = RutasOrigenDestinoController.Instance.GetBy_RutasOrigenCodigo(Codigo);
	}

	return m_RutasOrigenDestino;
}
set { m_RutasOrigenDestino = value; }
}

#endregion

}

#endregion

#region RutasOrigenList object

/// <summary>
/// Class for reading and access a list of RutasOrigen object
/// </summary>
[CollectionDataContract]
public partial class RutasOrigenList : List<RutasOrigen>
{

	/// <summary>
	/// Default constructor
	/// </summary>
	public RutasOrigenList()
	{
	}
}

#endregion

}
