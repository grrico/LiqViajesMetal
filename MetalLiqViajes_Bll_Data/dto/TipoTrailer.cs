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
	#region TipoTrailer object

	[DataContract]
	public partial class TipoTrailer : IDTOObject
	{
		/// <summary>
		/// Default constructor
		/// </summary>
		public TipoTrailer()
		{
			m_Codigo = 0;
			m_Trailer = null;
			m_Descripcion = null;
			m_changed=false;
		}
		        //Return the table name of object
		        public string TableName()
		        {
		            return "TipoTrailer";
		        }
		#region Undo 
		// Internal class for storing changes
		private TipoTrailer m_oldTipoTrailer;
		public void GenerateUndo()
		{
			m_oldTipoTrailer=new TipoTrailer();
			m_oldTipoTrailer.m_Codigo = m_Codigo;
			m_oldTipoTrailer.Trailer = m_Trailer;
			m_oldTipoTrailer.Descripcion = m_Descripcion;
		}

		public TipoTrailer OldTipoTrailer
		{
			get { return m_oldTipoTrailer;}
		}
		// Return the changed fields
		public string[] FieldChanged()
		{
			List<string> fields=new List<string>();
			if (m_oldTipoTrailer.Trailer != m_Trailer) fields.Add("Trailer");
			if (m_oldTipoTrailer.Descripcion != m_Descripcion) fields.Add("Descripcion");
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


		// Field for storing the TipoTrailer's Trailer value
		private string m_Trailer;

		// Field for storing the TipoTrailer's Descripcion value
		private string m_Descripcion;

		// Field for storing the TipoTrailer's Codigo value
		private int m_Codigo;

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
		/// Attribute for access the TipoTrailer's Trailer value (string)
		/// </summary>
		[DataMember]
		public string Trailer
		{
			get { return m_Trailer; }
			set 
			{
				m_changed=true;
				m_Trailer = value;
			}
		}

		/// <summary>
		/// Attribute for access the TipoTrailer's Descripcion value (string)
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
		/// Attribute for access the TipoTrailer's Codigo value (int)
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

		public object GetAttribute(string pattribute)
		{
			switch (pattribute)
			{
				case "Trailer": return Trailer;
				case "Descripcion": return Descripcion;
				case "Codigo": return Codigo;
				default: return null;
			}
		}

		public Type GetAttributeType(string pattribute)
		{
			return TipoTrailerController.Instance.GetMethodType(pattribute, this);
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
					m_Rutas = RutasController.Instance.GetBy_TipoTrailerCodigo(Codigo);
			}

			return m_Rutas;
		}
		set { m_Rutas = value; }
	}

	#endregion

}

#endregion

#region TipoTrailerList object

/// <summary>
/// Class for reading and access a list of TipoTrailer object
/// </summary>
[CollectionDataContract]
public partial class TipoTrailerList : List<TipoTrailer>
{

	/// <summary>
	/// Default constructor
	/// </summary>
	public TipoTrailerList()
	{
	}
}

#endregion

}
