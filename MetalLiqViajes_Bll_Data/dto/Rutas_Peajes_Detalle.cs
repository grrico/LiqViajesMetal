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
	#region Rutas_Peajes_Detalle object

	[DataContract]
	public partial class Rutas_Peajes_Detalle : IDTOObject
	{
		/// <summary>
		/// Default constructor
		/// </summary>
		public Rutas_Peajes_Detalle()
		{
			m_codigo = 0;
			m_Rutas_PeajesCodigo = 0;
			m_lngIdPeaje = 0;
			m_Secuencia = null;
			m_Excluido = false;
			m_fechaModificacion = null;
			m_changed=false;
		}
		        //Return the table name of object
		        public string TableName()
		        {
		            return "tblRutas_Peajes_Detalle";
		        }
		#region Undo 
		// Internal class for storing changes
		private Rutas_Peajes_Detalle m_oldRutas_Peajes_Detalle;
		public void GenerateUndo()
		{
			m_oldRutas_Peajes_Detalle=new Rutas_Peajes_Detalle();
			m_oldRutas_Peajes_Detalle.m_codigo = m_codigo;
			m_oldRutas_Peajes_Detalle.m_Rutas_PeajesCodigo = m_Rutas_PeajesCodigo;
			m_oldRutas_Peajes_Detalle.m_lngIdPeaje = m_lngIdPeaje;
			m_oldRutas_Peajes_Detalle.Secuencia = m_Secuencia;
			m_oldRutas_Peajes_Detalle.Excluido = m_Excluido;
			m_oldRutas_Peajes_Detalle.fechaModificacion = m_fechaModificacion;
		}

		public Rutas_Peajes_Detalle OldRutas_Peajes_Detalle
		{
			get { return m_oldRutas_Peajes_Detalle;}
		}
		// Return the changed fields
		public string[] FieldChanged()
		{
			List<string> fields=new List<string>();
			if (m_oldRutas_Peajes_Detalle.Secuencia != m_Secuencia) fields.Add("Secuencia");
			if (m_oldRutas_Peajes_Detalle.Excluido != m_Excluido) fields.Add("Excluido");
			if (m_oldRutas_Peajes_Detalle.fechaModificacion != m_fechaModificacion) fields.Add("fechaModificacion");
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


		// Field for storing the Rutas_Peajes_Detalle's Secuencia value
		private int? m_Secuencia;

		// Field for storing the Rutas_Peajes_Detalle's Excluido value
		private bool? m_Excluido;

		// Field for storing the Rutas_Peajes_Detalle's fechaModificacion value
		private DateTime? m_fechaModificacion;

		// Field for storing the Rutas_Peajes_Detalle's codigo value
		private long m_codigo;

		// Field for storing the Rutas_Peajes_Detalle's Rutas_PeajesCodigo value
		private long m_Rutas_PeajesCodigo;

		// Field for storing the Rutas_Peajes_Detalle's lngIdPeaje value
		private int m_lngIdPeaje;

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
		/// Attribute for access the Rutas_Peajes_Detalle's Secuencia value (int)
		/// </summary>
		[DataMember]
		public int? Secuencia
		{
			get { return m_Secuencia; }
			set 
			{
				m_changed=true;
				m_Secuencia = value;
			}
		}

		/// <summary>
		/// Attribute for access the Rutas_Peajes_Detalle's Excluido value (bool)
		/// </summary>
		[DataMember]
		public bool? Excluido
		{
			get { return m_Excluido; }
			set 
			{
				m_changed=true;
				m_Excluido = value;
			}
		}

		/// <summary>
		/// Attribute for access the Rutas_Peajes_Detalle's fechaModificacion value (DateTime)
		/// </summary>
		[DataMember]
		public DateTime? fechaModificacion
		{
			get { return m_fechaModificacion; }
			set 
			{
				m_changed=true;
				m_fechaModificacion = value;
			}
		}

		/// <summary>
		/// Attribute for access the Rutas_Peajes_Detalle's codigo value (long)
		/// </summary>
		[DataMember]
		public long codigo
		{
			get { return m_codigo; }
			set 
			{
				m_changed=true;
				m_codigo = value;
			}
		}

		/// <summary>
		/// Attribute for access the Rutas_Peajes_Detalle's Rutas_PeajesCodigo value (long)
		/// </summary>
		[DataMember]
		public long Rutas_PeajesCodigo
		{
			get { return m_Rutas_PeajesCodigo; }
			set 
			{
				m_changed=true;
				m_Rutas_PeajesCodigo = value;
			}
		}

		/// <summary>
		/// Attribute for access the Rutas_Peajes_Detalle's lngIdPeaje value (int)
		/// </summary>
		[DataMember]
		public int lngIdPeaje
		{
			get { return m_lngIdPeaje; }
			set 
			{
				m_changed=true;
				m_lngIdPeaje = value;
			}
		}

		public object GetAttribute(string pattribute)
		{
			switch (pattribute)
			{
				case "Secuencia": return Secuencia;
				case "Excluido": return Excluido;
				case "fechaModificacion": return fechaModificacion;
				case "codigo": return codigo;
				case "Rutas_PeajesCodigo": return Rutas_PeajesCodigo;
				case "lngIdPeaje": return lngIdPeaje;
				default: return null;
			}
		}

		public Type GetAttributeType(string pattribute)
		{
			return Rutas_Peajes_DetalleController.Instance.GetMethodType(pattribute, this);
		}

		public string GetSqlKey()
		{
			return "[codigo] = " + codigo.ToString() + " AND [Rutas_PeajesCodigo] = " + Rutas_PeajesCodigo.ToString() + " AND [lngIdPeaje] = " + lngIdPeaje.ToString();
		}
		#endregion

	}

	#endregion

	#region Rutas_Peajes_DetalleList object

	/// <summary>
	/// Class for reading and access a list of Rutas_Peajes_Detalle object
	/// </summary>
	[CollectionDataContract]
	public partial class Rutas_Peajes_DetalleList : List<Rutas_Peajes_Detalle>
	{

		/// <summary>
		/// Default constructor
		/// </summary>
		public Rutas_Peajes_DetalleList()
		{
		}
	}

	#endregion

}
