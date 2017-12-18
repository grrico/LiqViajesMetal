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
			m_RutasOrigenCodigo = null;
			m_RutasDestinoCodigo = null;
			m_Origen = null;
			m_Destino = null;
			m_GrupoOrigen = null;
			m_GrupoDestino = null;
			m_Favorita = false;
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
			m_oldRutasOrigenDestino.RutasOrigenCodigo = m_RutasOrigenCodigo;
			m_oldRutasOrigenDestino.RutasDestinoCodigo = m_RutasDestinoCodigo;
			m_oldRutasOrigenDestino.Origen = m_Origen;
			m_oldRutasOrigenDestino.Destino = m_Destino;
			m_oldRutasOrigenDestino.GrupoOrigen = m_GrupoOrigen;
			m_oldRutasOrigenDestino.GrupoDestino = m_GrupoDestino;
			m_oldRutasOrigenDestino.Favorita = m_Favorita;
		}

		public RutasOrigenDestino OldRutasOrigenDestino
		{
			get { return m_oldRutasOrigenDestino;}
		}
		// Return the changed fields
		public string[] FieldChanged()
		{
			List<string> fields=new List<string>();
			if (m_oldRutasOrigenDestino.RutasOrigenCodigo != m_RutasOrigenCodigo) fields.Add("RutasOrigenCodigo");
			if (m_oldRutasOrigenDestino.RutasDestinoCodigo != m_RutasDestinoCodigo) fields.Add("RutasDestinoCodigo");
			if (m_oldRutasOrigenDestino.Origen != m_Origen) fields.Add("Origen");
			if (m_oldRutasOrigenDestino.Destino != m_Destino) fields.Add("Destino");
			if (m_oldRutasOrigenDestino.GrupoOrigen != m_GrupoOrigen) fields.Add("GrupoOrigen");
			if (m_oldRutasOrigenDestino.GrupoDestino != m_GrupoDestino) fields.Add("GrupoDestino");
			if (m_oldRutasOrigenDestino.Favorita != m_Favorita) fields.Add("Favorita");
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
		private long m_Codigo;

		// Field for storing the RutasOrigenDestino's RutasOrigenCodigo value
		private long? m_RutasOrigenCodigo;

		// Field for storing the RutasOrigenDestino's RutasDestinoCodigo value
		private long? m_RutasDestinoCodigo;

		// Field for storing the RutasOrigenDestino's Origen value
		private string m_Origen;

		// Field for storing the RutasOrigenDestino's Destino value
		private string m_Destino;

		// Field for storing the RutasOrigenDestino's GrupoOrigen value
		private string m_GrupoOrigen;

		// Field for storing the RutasOrigenDestino's GrupoDestino value
		private string m_GrupoDestino;

		// Field for storing the RutasOrigenDestino's Favorita value
		private bool? m_Favorita;

		// Evaluate changed state
		private bool m_changed=false;
		// Field for storing the reference to RutasDestino accessed by RutasDestinoCodigo, RutasOrigenCodigo
		private RutasDestino m_RutasDestino;

		// Field for storing the reference to foreign RutasOrigenDestinoVehTrailerList object accessed by Codigo
		private RutasOrigenDestinoVehTrailerList m_RutasOrigenDestinoVehTrailer;


		#endregion

		#region Attributes

		// Return if object changed
		public bool Changed
		{
			get { return m_changed;}
			set { m_changed=value;}
		}
		/// <summary>
		/// Attribute for access the RutasOrigenDestino's Codigo value (long)
		/// </summary>
		[DataMember]
		public long Codigo
		{
			get { return m_Codigo; }
			set 
			{
				m_changed=true;
				m_Codigo = value;
			}
		}

		/// <summary>
		/// Attribute for access the RutasOrigenDestino's RutasOrigenCodigo value (long)
		/// </summary>
		[DataMember]
		public long? RutasOrigenCodigo
		{
			get { return m_RutasOrigenCodigo; }
			set
			{
				m_changed=true;
				m_RutasOrigenCodigo = value;

				if ((m_RutasDestino != null) && (m_RutasDestino.RutasOrigenCodigo != m_RutasOrigenCodigo))
				{
					// we need to reset the reference because it is now invalid
					m_RutasDestino = null;
				}
			}
		}

		/// <summary>
		/// Attribute for access the RutasOrigenDestino's RutasDestinoCodigo value (long)
		/// </summary>
		[DataMember]
		public long? RutasDestinoCodigo
		{
			get { return m_RutasDestinoCodigo; }
			set
			{
				m_changed=true;
				m_RutasDestinoCodigo = value;

				if ((m_RutasDestino != null) && (m_RutasDestino.Codigo != m_RutasDestinoCodigo))
				{
					// we need to reset the reference because it is now invalid
					m_RutasDestino = null;
				}
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
		/// Attribute for access the RutasOrigenDestino's Favorita value (bool)
		/// </summary>
		[DataMember]
		public bool? Favorita
		{
			get { return m_Favorita; }
			set 
			{
				m_changed=true;
				m_Favorita = value;
			}
		}

		public object GetAttribute(string pattribute)
		{
			switch (pattribute)
			{
				case "Codigo": return Codigo;
				case "RutasOrigenCodigo": return RutasOrigenCodigo;
				case "RutasDestinoCodigo": return RutasDestinoCodigo;
				case "Origen": return Origen;
				case "Destino": return Destino;
				case "GrupoOrigen": return GrupoOrigen;
				case "GrupoDestino": return GrupoDestino;
				case "Favorita": return Favorita;
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
		/// <summary>
		/// Gets or sets the reference to RutasDestino accessed by RutasDestinoCodigo, RutasOrigenCodigo
		/// </summary>
		/// <remarks>
		/// Also updates related field values
		/// </remarks>
		public RutasDestino RutasDestino
		{
			get
			{
				if (m_RutasDestino == null)
				{
					if (m_RutasDestinoCodigo != null)
					{
						if (m_RutasOrigenCodigo != null)
						{
							m_RutasDestino = RutasDestinoController.Instance.Get((long)m_RutasDestinoCodigo,(long)m_RutasOrigenCodigo);
						}
					}
				}

				return m_RutasDestino;
			}

			set
			{
				m_RutasDestino = value;

				if (m_RutasDestino != null)
				{
					this.m_RutasDestinoCodigo = m_RutasDestino.Codigo;
					this.m_RutasOrigenCodigo = m_RutasDestino.RutasOrigenCodigo;
				}
			}
		}

		/// <summary>
		/// Gets or sets the reference to foreign RutasOrigenDestinoVehTrailerList object accessed by Codigo
		/// </summary>
		public RutasOrigenDestinoVehTrailerList RutasOrigenDestinoVehTrailer
		{
			get
			{
				if (m_RutasOrigenDestinoVehTrailer == null)
				{
					m_RutasOrigenDestinoVehTrailer = RutasOrigenDestinoVehTrailerController.Instance.GetBy_RutasOrigenDestinoCodigo(Codigo);
			}

			return m_RutasOrigenDestinoVehTrailer;
		}
		set { m_RutasOrigenDestinoVehTrailer = value; }
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
