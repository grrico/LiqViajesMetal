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
	#region RutasOrigenTipoTrailer object

	[DataContract]
	public partial class RutasOrigenTipoTrailer : IDTOObject
	{
		/// <summary>
		/// Default constructor
		/// </summary>
		public RutasOrigenTipoTrailer()
		{
			m_Codigo = 0;
			m_RutasOrigenCodigo = null;
			m_Origen = null;
			m_TipoTrailerCodigo = null;
			m_DescripcionTrailer = null;
			m_changed=false;
		}
		        //Return the table name of object
		        public string TableName()
		        {
		            return "RutasOrigenTipoTrailer";
		        }
		#region Undo 
		// Internal class for storing changes
		private RutasOrigenTipoTrailer m_oldRutasOrigenTipoTrailer;
		public void GenerateUndo()
		{
			m_oldRutasOrigenTipoTrailer=new RutasOrigenTipoTrailer();
			m_oldRutasOrigenTipoTrailer.m_Codigo = m_Codigo;
			m_oldRutasOrigenTipoTrailer.RutasOrigenCodigo = m_RutasOrigenCodigo;
			m_oldRutasOrigenTipoTrailer.Origen = m_Origen;
			m_oldRutasOrigenTipoTrailer.TipoTrailerCodigo = m_TipoTrailerCodigo;
			m_oldRutasOrigenTipoTrailer.DescripcionTrailer = m_DescripcionTrailer;
		}

		public RutasOrigenTipoTrailer OldRutasOrigenTipoTrailer
		{
			get { return m_oldRutasOrigenTipoTrailer;}
		}
		// Return the changed fields
		public string[] FieldChanged()
		{
			List<string> fields=new List<string>();
			if (m_oldRutasOrigenTipoTrailer.RutasOrigenCodigo != m_RutasOrigenCodigo) fields.Add("RutasOrigenCodigo");
			if (m_oldRutasOrigenTipoTrailer.Origen != m_Origen) fields.Add("Origen");
			if (m_oldRutasOrigenTipoTrailer.TipoTrailerCodigo != m_TipoTrailerCodigo) fields.Add("TipoTrailerCodigo");
			if (m_oldRutasOrigenTipoTrailer.DescripcionTrailer != m_DescripcionTrailer) fields.Add("DescripcionTrailer");
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


		// Field for storing the RutasOrigenTipoTrailer's Codigo value
		private int m_Codigo;

		// Field for storing the RutasOrigenTipoTrailer's RutasOrigenCodigo value
		private int? m_RutasOrigenCodigo;

		// Field for storing the RutasOrigenTipoTrailer's Origen value
		private string m_Origen;

		// Field for storing the RutasOrigenTipoTrailer's TipoTrailerCodigo value
		private int? m_TipoTrailerCodigo;

		// Field for storing the RutasOrigenTipoTrailer's DescripcionTrailer value
		private string m_DescripcionTrailer;

		// Evaluate changed state
		private bool m_changed=false;
		// Field for storing the reference to RutasOrigen accessed by RutasOrigenCodigo
		private RutasOrigen m_RutasOrigen;


		#endregion

		#region Attributes

		// Return if object changed
		public bool Changed
		{
			get { return m_changed;}
			set { m_changed=value;}
		}
		/// <summary>
		/// Attribute for access the RutasOrigenTipoTrailer's Codigo value (int)
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
		/// Attribute for access the RutasOrigenTipoTrailer's RutasOrigenCodigo value (int)
		/// </summary>
		[DataMember]
		public int? RutasOrigenCodigo
		{
			get { return m_RutasOrigenCodigo; }
			set
			{
				m_changed=true;
				m_RutasOrigenCodigo = value;

				if ((m_RutasOrigen != null) && (m_RutasOrigen.Codigo != m_RutasOrigenCodigo))
				{
					// we need to reset the reference because it is now invalid
					m_RutasOrigen = null;
				}
			}
		}

		/// <summary>
		/// Attribute for access the RutasOrigenTipoTrailer's Origen value (string)
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
		/// Attribute for access the RutasOrigenTipoTrailer's TipoTrailerCodigo value (int)
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
		/// Attribute for access the RutasOrigenTipoTrailer's DescripcionTrailer value (string)
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
				case "RutasOrigenCodigo": return RutasOrigenCodigo;
				case "Origen": return Origen;
				case "TipoTrailerCodigo": return TipoTrailerCodigo;
				case "DescripcionTrailer": return DescripcionTrailer;
				default: return null;
			}
		}

		public Type GetAttributeType(string pattribute)
		{
			return RutasOrigenTipoTrailerController.Instance.GetMethodType(pattribute, this);
		}

		public string GetSqlKey()
		{
			return "[Codigo] = " + Codigo.ToString();
		}
		/// <summary>
		/// Gets or sets the reference to RutasOrigen accessed by RutasOrigenCodigo
		/// </summary>
		/// <remarks>
		/// Also updates related field values
		/// </remarks>
		public RutasOrigen RutasOrigen
		{
			get
			{
				if (m_RutasOrigen == null)
				{
					if (m_RutasOrigenCodigo != null)
					{
						m_RutasOrigen = RutasOrigenController.Instance.Get((int)m_RutasOrigenCodigo);
					}
				}

				return m_RutasOrigen;
			}

			set
			{
				m_RutasOrigen = value;

				if (m_RutasOrigen != null)
				{
					this.m_RutasOrigenCodigo = m_RutasOrigen.Codigo;
				}
			}
		}

		#endregion

	}

	#endregion

	#region RutasOrigenTipoTrailerList object

	/// <summary>
	/// Class for reading and access a list of RutasOrigenTipoTrailer object
	/// </summary>
	[CollectionDataContract]
	public partial class RutasOrigenTipoTrailerList : List<RutasOrigenTipoTrailer>
	{

		/// <summary>
		/// Default constructor
		/// </summary>
		public RutasOrigenTipoTrailerList()
		{
		}
	}

	#endregion

}
