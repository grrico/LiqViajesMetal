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
	#region RutasOrigenDestinoVehTrailer object

	[DataContract]
	public partial class RutasOrigenDestinoVehTrailer : IDTOObject
	{
		/// <summary>
		/// Default constructor
		/// </summary>
		public RutasOrigenDestinoVehTrailer()
		{
			m_Codigo = 0;
			m_RutasOrigenDestinoCodigo = null;
			m_Origen = null;
			m_Destino = null;
			m_GrupoOrigen = null;
			m_GrupoDestino = null;
			m_TipoVehiculoCodigo = null;
			m_TipoVehiculo = null;
			m_TipoTrailerCodigo = null;
			m_DescripcionTipoTrailer = null;
			m_Favorita = false;
			m_changed=false;
		}
		        //Return the table name of object
		        public string TableName()
		        {
		            return "RutasOrigenDestinoVehTrailer";
		        }
		#region Undo 
		// Internal class for storing changes
		private RutasOrigenDestinoVehTrailer m_oldRutasOrigenDestinoVehTrailer;
		public void GenerateUndo()
		{
			m_oldRutasOrigenDestinoVehTrailer=new RutasOrigenDestinoVehTrailer();
			m_oldRutasOrigenDestinoVehTrailer.m_Codigo = m_Codigo;
			m_oldRutasOrigenDestinoVehTrailer.RutasOrigenDestinoCodigo = m_RutasOrigenDestinoCodigo;
			m_oldRutasOrigenDestinoVehTrailer.Origen = m_Origen;
			m_oldRutasOrigenDestinoVehTrailer.Destino = m_Destino;
			m_oldRutasOrigenDestinoVehTrailer.GrupoOrigen = m_GrupoOrigen;
			m_oldRutasOrigenDestinoVehTrailer.GrupoDestino = m_GrupoDestino;
			m_oldRutasOrigenDestinoVehTrailer.TipoVehiculoCodigo = m_TipoVehiculoCodigo;
			m_oldRutasOrigenDestinoVehTrailer.TipoVehiculo = m_TipoVehiculo;
			m_oldRutasOrigenDestinoVehTrailer.TipoTrailerCodigo = m_TipoTrailerCodigo;
			m_oldRutasOrigenDestinoVehTrailer.DescripcionTipoTrailer = m_DescripcionTipoTrailer;
			m_oldRutasOrigenDestinoVehTrailer.Favorita = m_Favorita;
		}

		public RutasOrigenDestinoVehTrailer OldRutasOrigenDestinoVehTrailer
		{
			get { return m_oldRutasOrigenDestinoVehTrailer;}
		}
		// Return the changed fields
		public string[] FieldChanged()
		{
			List<string> fields=new List<string>();
			if (m_oldRutasOrigenDestinoVehTrailer.RutasOrigenDestinoCodigo != m_RutasOrigenDestinoCodigo) fields.Add("RutasOrigenDestinoCodigo");
			if (m_oldRutasOrigenDestinoVehTrailer.Origen != m_Origen) fields.Add("Origen");
			if (m_oldRutasOrigenDestinoVehTrailer.Destino != m_Destino) fields.Add("Destino");
			if (m_oldRutasOrigenDestinoVehTrailer.GrupoOrigen != m_GrupoOrigen) fields.Add("GrupoOrigen");
			if (m_oldRutasOrigenDestinoVehTrailer.GrupoDestino != m_GrupoDestino) fields.Add("GrupoDestino");
			if (m_oldRutasOrigenDestinoVehTrailer.TipoVehiculoCodigo != m_TipoVehiculoCodigo) fields.Add("TipoVehiculoCodigo");
			if (m_oldRutasOrigenDestinoVehTrailer.TipoVehiculo != m_TipoVehiculo) fields.Add("TipoVehiculo");
			if (m_oldRutasOrigenDestinoVehTrailer.TipoTrailerCodigo != m_TipoTrailerCodigo) fields.Add("TipoTrailerCodigo");
			if (m_oldRutasOrigenDestinoVehTrailer.DescripcionTipoTrailer != m_DescripcionTipoTrailer) fields.Add("DescripcionTipoTrailer");
			if (m_oldRutasOrigenDestinoVehTrailer.Favorita != m_Favorita) fields.Add("Favorita");
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


		// Field for storing the RutasOrigenDestinoVehTrailer's Codigo value
		private int m_Codigo;

		// Field for storing the RutasOrigenDestinoVehTrailer's RutasOrigenDestinoCodigo value
		private int? m_RutasOrigenDestinoCodigo;

		// Field for storing the RutasOrigenDestinoVehTrailer's Origen value
		private string m_Origen;

		// Field for storing the RutasOrigenDestinoVehTrailer's Destino value
		private string m_Destino;

		// Field for storing the RutasOrigenDestinoVehTrailer's GrupoOrigen value
		private string m_GrupoOrigen;

		// Field for storing the RutasOrigenDestinoVehTrailer's GrupoDestino value
		private string m_GrupoDestino;

		// Field for storing the RutasOrigenDestinoVehTrailer's TipoVehiculoCodigo value
		private int? m_TipoVehiculoCodigo;

		// Field for storing the RutasOrigenDestinoVehTrailer's TipoVehiculo value
		private string m_TipoVehiculo;

		// Field for storing the RutasOrigenDestinoVehTrailer's TipoTrailerCodigo value
		private int? m_TipoTrailerCodigo;

		// Field for storing the RutasOrigenDestinoVehTrailer's DescripcionTipoTrailer value
		private string m_DescripcionTipoTrailer;

		// Field for storing the RutasOrigenDestinoVehTrailer's Favorita value
		private bool? m_Favorita;

		// Evaluate changed state
		private bool m_changed=false;
		// Field for storing the reference to RutasOrigenDestino accessed by RutasOrigenDestinoCodigo
		private RutasOrigenDestino m_RutasOrigenDestino;

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
		/// Attribute for access the RutasOrigenDestinoVehTrailer's Codigo value (int)
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
		/// Attribute for access the RutasOrigenDestinoVehTrailer's RutasOrigenDestinoCodigo value (int)
		/// </summary>
		[DataMember]
		public int? RutasOrigenDestinoCodigo
		{
			get { return m_RutasOrigenDestinoCodigo; }
			set
			{
				m_changed=true;
				m_RutasOrigenDestinoCodigo = value;

				if ((m_RutasOrigenDestino != null) && (m_RutasOrigenDestino.Codigo != m_RutasOrigenDestinoCodigo))
				{
					// we need to reset the reference because it is now invalid
					m_RutasOrigenDestino = null;
				}
			}
		}

		/// <summary>
		/// Attribute for access the RutasOrigenDestinoVehTrailer's Origen value (string)
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
		/// Attribute for access the RutasOrigenDestinoVehTrailer's Destino value (string)
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
		/// Attribute for access the RutasOrigenDestinoVehTrailer's GrupoOrigen value (string)
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
		/// Attribute for access the RutasOrigenDestinoVehTrailer's GrupoDestino value (string)
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
		/// Attribute for access the RutasOrigenDestinoVehTrailer's TipoVehiculoCodigo value (int)
		/// </summary>
		[DataMember]
		public int? TipoVehiculoCodigo
		{
			get { return m_TipoVehiculoCodigo; }
			set 
			{
				m_changed=true;
				m_TipoVehiculoCodigo = value;
			}
		}

		/// <summary>
		/// Attribute for access the RutasOrigenDestinoVehTrailer's TipoVehiculo value (string)
		/// </summary>
		[DataMember]
		public string TipoVehiculo
		{
			get { return m_TipoVehiculo; }
			set 
			{
				m_changed=true;
				m_TipoVehiculo = value;
			}
		}

		/// <summary>
		/// Attribute for access the RutasOrigenDestinoVehTrailer's TipoTrailerCodigo value (int)
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
		/// Attribute for access the RutasOrigenDestinoVehTrailer's DescripcionTipoTrailer value (string)
		/// </summary>
		[DataMember]
		public string DescripcionTipoTrailer
		{
			get { return m_DescripcionTipoTrailer; }
			set 
			{
				m_changed=true;
				m_DescripcionTipoTrailer = value;
			}
		}

		/// <summary>
		/// Attribute for access the RutasOrigenDestinoVehTrailer's Favorita value (bool)
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
				case "RutasOrigenDestinoCodigo": return RutasOrigenDestinoCodigo;
				case "Origen": return Origen;
				case "Destino": return Destino;
				case "GrupoOrigen": return GrupoOrigen;
				case "GrupoDestino": return GrupoDestino;
				case "TipoVehiculoCodigo": return TipoVehiculoCodigo;
				case "TipoVehiculo": return TipoVehiculo;
				case "TipoTrailerCodigo": return TipoTrailerCodigo;
				case "DescripcionTipoTrailer": return DescripcionTipoTrailer;
				case "Favorita": return Favorita;
				default: return null;
			}
		}

		public Type GetAttributeType(string pattribute)
		{
			return RutasOrigenDestinoVehTrailerController.Instance.GetMethodType(pattribute, this);
		}

		public string GetSqlKey()
		{
			return "[Codigo] = " + Codigo.ToString();
		}
		/// <summary>
		/// Gets or sets the reference to RutasOrigenDestino accessed by RutasOrigenDestinoCodigo
		/// </summary>
		/// <remarks>
		/// Also updates related field values
		/// </remarks>
		public RutasOrigenDestino RutasOrigenDestino
		{
			get
			{
				if (m_RutasOrigenDestino == null)
				{
					if (m_RutasOrigenDestinoCodigo != null)
					{
						m_RutasOrigenDestino = RutasOrigenDestinoController.Instance.Get((int)m_RutasOrigenDestinoCodigo);
					}
				}

				return m_RutasOrigenDestino;
			}

			set
			{
				m_RutasOrigenDestino = value;

				if (m_RutasOrigenDestino != null)
				{
					this.m_RutasOrigenDestinoCodigo = m_RutasOrigenDestino.Codigo;
				}
			}
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
					m_Rutas = RutasController.Instance.GetBy_RutasOrigenDestinoVehTrailerCodigo(Codigo);
			}

			return m_Rutas;
		}
		set { m_Rutas = value; }
	}

	#endregion

}

#endregion

#region RutasOrigenDestinoVehTrailerList object

/// <summary>
/// Class for reading and access a list of RutasOrigenDestinoVehTrailer object
/// </summary>
[CollectionDataContract]
public partial class RutasOrigenDestinoVehTrailerList : List<RutasOrigenDestinoVehTrailer>
{

	/// <summary>
	/// Default constructor
	/// </summary>
	public RutasOrigenDestinoVehTrailerList()
	{
	}
}

#endregion

}
