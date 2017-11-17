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
	#region RutasOrigenDestino object

	[DataContract]
	public partial class RutasOrigenDestino : IDTOObject
	{
		/// <summary>
		/// Default constructor
		/// </summary>
		public RutasOrigenDestino()
		{
			m_Codigo = 0;
			m_Origen = null;
			m_Destino = null;
			m_GrupoOrigen = null;
			m_GrupoDestino = null;
			m_TipoTrailerCodigo = null;
			m_DescripcionTrailer = null;
			m_changed=false;
		}
		        //Return the table name of object
		        public string TableName()
		        {
		            return "RutasOrigenDestino";
		        }
		#region Undo 
		// Internal class for storing changes
		private RutasOrigenDestino m_oldRutasOrigenDestino;
		public void GenerateUndo()
		{
			m_oldRutasOrigenDestino=new RutasOrigenDestino();
			m_oldRutasOrigenDestino.m_Codigo = m_Codigo;
			m_oldRutasOrigenDestino.Origen = m_Origen;
			m_oldRutasOrigenDestino.Destino = m_Destino;
			m_oldRutasOrigenDestino.GrupoOrigen = m_GrupoOrigen;
			m_oldRutasOrigenDestino.GrupoDestino = m_GrupoDestino;
			m_oldRutasOrigenDestino.TipoTrailerCodigo = m_TipoTrailerCodigo;
			m_oldRutasOrigenDestino.DescripcionTrailer = m_DescripcionTrailer;
		}

		public RutasOrigenDestino OldRutasOrigenDestino
		{
			get { return m_oldRutasOrigenDestino;}
		}
		// Return the changed fields
		public string[] FieldChanged()
		{
			List<string> fields=new List<string>();
			if (m_oldRutasOrigenDestino.Origen != m_Origen) fields.Add("Origen");
			if (m_oldRutasOrigenDestino.Destino != m_Destino) fields.Add("Destino");
			if (m_oldRutasOrigenDestino.GrupoOrigen != m_GrupoOrigen) fields.Add("GrupoOrigen");
			if (m_oldRutasOrigenDestino.GrupoDestino != m_GrupoDestino) fields.Add("GrupoDestino");
			if (m_oldRutasOrigenDestino.TipoTrailerCodigo != m_TipoTrailerCodigo) fields.Add("TipoTrailerCodigo");
			if (m_oldRutasOrigenDestino.DescripcionTrailer != m_DescripcionTrailer) fields.Add("DescripcionTrailer");
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


		// Field for storing the RutasOrigenDestino's Codigo value
		private int m_Codigo;

		// Field for storing the RutasOrigenDestino's Origen value
		private string m_Origen;

		// Field for storing the RutasOrigenDestino's Destino value
		private string m_Destino;

		// Field for storing the RutasOrigenDestino's GrupoOrigen value
		private string m_GrupoOrigen;

		// Field for storing the RutasOrigenDestino's GrupoDestino value
		private string m_GrupoDestino;

		// Field for storing the RutasOrigenDestino's TipoTrailerCodigo value
		private int? m_TipoTrailerCodigo;

		// Field for storing the RutasOrigenDestino's DescripcionTrailer value
		private string m_DescripcionTrailer;

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
		/// Attribute for access the RutasOrigenDestino's Codigo value (int)
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
		/// Attribute for access the RutasOrigenDestino's Origen value (string)
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

		/// <summary>
		/// Attribute for access the RutasOrigenDestino's Destino value (string)
		/// </summary>
		[DataMember]
		public string Destino
		{
			get { return m_Destino; }
			set 
			{
				m_changed=true;
				m_Destino = value;
			}
		}

		/// <summary>
		/// Attribute for access the RutasOrigenDestino's GrupoOrigen value (string)
		/// </summary>
		[DataMember]
		public string GrupoOrigen
		{
			get { return m_GrupoOrigen; }
			set 
			{
				m_changed=true;
				m_GrupoOrigen = value;
			}
		}

		/// <summary>
		/// Attribute for access the RutasOrigenDestino's GrupoDestino value (string)
		/// </summary>
		[DataMember]
		public string GrupoDestino
		{
			get { return m_GrupoDestino; }
			set 
			{
				m_changed=true;
				m_GrupoDestino = value;
			}
		}

		/// <summary>
		/// Attribute for access the RutasOrigenDestino's TipoTrailerCodigo value (int)
		/// </summary>
		[DataMember]
		public int? TipoTrailerCodigo
		{
			get { return m_TipoTrailerCodigo; }
			set 
			{
				m_changed=true;
				m_TipoTrailerCodigo = value;
			}
		}

		/// <summary>
		/// Attribute for access the RutasOrigenDestino's DescripcionTrailer value (string)
		/// </summary>
		[DataMember]
		public string DescripcionTrailer
		{
			get { return m_DescripcionTrailer; }
			set 
			{
				m_changed=true;
				m_DescripcionTrailer = value;
			}
		}

		public object GetAttribute(string pattribute)
		{
			switch (pattribute)
			{
				case "Codigo": return Codigo;
				case "Origen": return Origen;
				case "Destino": return Destino;
				case "GrupoOrigen": return GrupoOrigen;
				case "GrupoDestino": return GrupoDestino;
				case "TipoTrailerCodigo": return TipoTrailerCodigo;
				case "DescripcionTrailer": return DescripcionTrailer;
				default: return null;
			}
		}

		public Type GetAttributeType(string pattribute)
		{
			return RutasOrigenDestinoController.Instance.GetMethodType(pattribute, this);
		}

		public string GetSqlKey()
		{
			return "[Codigo] = " + Codigo.ToString();
		}
		#endregion

	}

	#endregion

	#region RutasOrigenDestinoList object

	/// <summary>
	/// Class for reading and access a list of RutasOrigenDestino object
	/// </summary>
	[CollectionDataContract]
	public partial class RutasOrigenDestinoList : List<RutasOrigenDestino>
	{

		/// <summary>
		/// Default constructor
		/// </summary>
		public RutasOrigenDestinoList()
		{
		}
	}

	#endregion

}
