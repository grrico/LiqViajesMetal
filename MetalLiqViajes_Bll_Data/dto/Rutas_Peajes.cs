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
	#region Rutas_Peajes object

	[DataContract]
	public partial class Rutas_Peajes : IDTOObject
	{
		/// <summary>
		/// Default constructor
		/// </summary>
		public Rutas_Peajes()
		{
			m_Codigo = 0;
			m_strRutaAnticipoGrupoOrigen = null;
			m_strRutaAnticipoGrupoDestino = null;
			m_strRutaAnticipo = null;
			m_logActualizado = false;
			m_FechaActualizacion = null;
			m_changed=false;
		}
		        //Return the table name of object
		        public string TableName()
		        {
		            return "tblRutas_Peajes";
		        }
		#region Undo 
		// Internal class for storing changes
		private Rutas_Peajes m_oldRutas_Peajes;
		public void GenerateUndo()
		{
			m_oldRutas_Peajes=new Rutas_Peajes();
			m_oldRutas_Peajes.m_Codigo = m_Codigo;
			m_oldRutas_Peajes.strRutaAnticipoGrupoOrigen = m_strRutaAnticipoGrupoOrigen;
			m_oldRutas_Peajes.strRutaAnticipoGrupoDestino = m_strRutaAnticipoGrupoDestino;
			m_oldRutas_Peajes.strRutaAnticipo = m_strRutaAnticipo;
			m_oldRutas_Peajes.logActualizado = m_logActualizado;
			m_oldRutas_Peajes.FechaActualizacion = m_FechaActualizacion;
		}

		public Rutas_Peajes OldRutas_Peajes
		{
			get { return m_oldRutas_Peajes;}
		}
		// Return the changed fields
		public string[] FieldChanged()
		{
			List<string> fields=new List<string>();
			if (m_oldRutas_Peajes.strRutaAnticipoGrupoOrigen != m_strRutaAnticipoGrupoOrigen) fields.Add("strRutaAnticipoGrupoOrigen");
			if (m_oldRutas_Peajes.strRutaAnticipoGrupoDestino != m_strRutaAnticipoGrupoDestino) fields.Add("strRutaAnticipoGrupoDestino");
			if (m_oldRutas_Peajes.strRutaAnticipo != m_strRutaAnticipo) fields.Add("strRutaAnticipo");
			if (m_oldRutas_Peajes.logActualizado != m_logActualizado) fields.Add("logActualizado");
			if (m_oldRutas_Peajes.FechaActualizacion != m_FechaActualizacion) fields.Add("FechaActualizacion");
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


		// Field for storing the Rutas_Peajes's Codigo value
		private int m_Codigo;

		// Field for storing the Rutas_Peajes's strRutaAnticipoGrupoOrigen value
		private string m_strRutaAnticipoGrupoOrigen;

		// Field for storing the Rutas_Peajes's strRutaAnticipoGrupoDestino value
		private string m_strRutaAnticipoGrupoDestino;

		// Field for storing the Rutas_Peajes's strRutaAnticipo value
		private string m_strRutaAnticipo;

		// Field for storing the Rutas_Peajes's logActualizado value
		private bool? m_logActualizado;

		// Field for storing the Rutas_Peajes's FechaActualizacion value
		private DateTime? m_FechaActualizacion;

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
		/// Attribute for access the Rutas_Peajes's Codigo value (int)
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
		/// Attribute for access the Rutas_Peajes's strRutaAnticipoGrupoOrigen value (string)
		/// </summary>
		[DataMember]
		public string strRutaAnticipoGrupoOrigen
		{
			get { return m_strRutaAnticipoGrupoOrigen; }
			set 
			{
				m_changed=true;
				m_strRutaAnticipoGrupoOrigen = value;
			}
		}

		/// <summary>
		/// Attribute for access the Rutas_Peajes's strRutaAnticipoGrupoDestino value (string)
		/// </summary>
		[DataMember]
		public string strRutaAnticipoGrupoDestino
		{
			get { return m_strRutaAnticipoGrupoDestino; }
			set 
			{
				m_changed=true;
				m_strRutaAnticipoGrupoDestino = value;
			}
		}

		/// <summary>
		/// Attribute for access the Rutas_Peajes's strRutaAnticipo value (string)
		/// </summary>
		[DataMember]
		public string strRutaAnticipo
		{
			get { return m_strRutaAnticipo; }
			set 
			{
				m_changed=true;
				m_strRutaAnticipo = value;
			}
		}

		/// <summary>
		/// Attribute for access the Rutas_Peajes's logActualizado value (bool)
		/// </summary>
		[DataMember]
		public bool? logActualizado
		{
			get { return m_logActualizado; }
			set 
			{
				m_changed=true;
				m_logActualizado = value;
			}
		}

		/// <summary>
		/// Attribute for access the Rutas_Peajes's FechaActualizacion value (DateTime)
		/// </summary>
		[DataMember]
		public DateTime? FechaActualizacion
		{
			get { return m_FechaActualizacion; }
			set 
			{
				m_changed=true;
				m_FechaActualizacion = value;
			}
		}

		public object GetAttribute(string pattribute)
		{
			switch (pattribute)
			{
				case "Codigo": return Codigo;
				case "strRutaAnticipoGrupoOrigen": return strRutaAnticipoGrupoOrigen;
				case "strRutaAnticipoGrupoDestino": return strRutaAnticipoGrupoDestino;
				case "strRutaAnticipo": return strRutaAnticipo;
				case "logActualizado": return logActualizado;
				case "FechaActualizacion": return FechaActualizacion;
				default: return null;
			}
		}

		public Type GetAttributeType(string pattribute)
		{
			return Rutas_PeajesController.Instance.GetMethodType(pattribute, this);
		}

		public string GetSqlKey()
		{
			return "[Codigo] = " + Codigo.ToString();
		}
		#endregion

	}

	#endregion

	#region Rutas_PeajesList object

	/// <summary>
	/// Class for reading and access a list of Rutas_Peajes object
	/// </summary>
	[CollectionDataContract]
	public partial class Rutas_PeajesList : List<Rutas_Peajes>
	{

		/// <summary>
		/// Default constructor
		/// </summary>
		public Rutas_PeajesList()
		{
		}
	}

	#endregion

}
