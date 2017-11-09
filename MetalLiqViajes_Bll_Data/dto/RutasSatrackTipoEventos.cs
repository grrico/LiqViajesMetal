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
	#region RutasSatrackTipoEventos object

	[DataContract]
	public partial class RutasSatrackTipoEventos : IDTOObject
	{
		/// <summary>
		/// Default constructor
		/// </summary>
		public RutasSatrackTipoEventos()
		{
			m_Codigo = 0;
			m_TipoEvento = null;
			m_changed=false;
		}
		        //Return the table name of object
		        public string TableName()
		        {
		            return "RutasSatrackTipoEventos";
		        }
		#region Undo 
		// Internal class for storing changes
		private RutasSatrackTipoEventos m_oldRutasSatrackTipoEventos;
		public void GenerateUndo()
		{
			m_oldRutasSatrackTipoEventos=new RutasSatrackTipoEventos();
			m_oldRutasSatrackTipoEventos.m_Codigo = m_Codigo;
			m_oldRutasSatrackTipoEventos.TipoEvento = m_TipoEvento;
		}

		public RutasSatrackTipoEventos OldRutasSatrackTipoEventos
		{
			get { return m_oldRutasSatrackTipoEventos;}
		}
		// Return the changed fields
		public string[] FieldChanged()
		{
			List<string> fields=new List<string>();
			if (m_oldRutasSatrackTipoEventos.TipoEvento != m_TipoEvento) fields.Add("TipoEvento");
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


		// Field for storing the RutasSatrackTipoEventos's Codigo value
		private int m_Codigo;

		// Field for storing the RutasSatrackTipoEventos's TipoEvento value
		private string m_TipoEvento;

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
		/// Attribute for access the RutasSatrackTipoEventos's Codigo value (int)
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
		/// Attribute for access the RutasSatrackTipoEventos's TipoEvento value (string)
		/// </summary>
		[DataMember]
		public string TipoEvento
		{
			get { return m_TipoEvento; }
			set 
			{
				m_changed=true;
				m_TipoEvento = value;
			}
		}

		public object GetAttribute(string pattribute)
		{
			switch (pattribute)
			{
				case "Codigo": return Codigo;
				case "TipoEvento": return TipoEvento;
				default: return null;
			}
		}

		public Type GetAttributeType(string pattribute)
		{
			return RutasSatrackTipoEventosController.Instance.GetMethodType(pattribute, this);
		}

		public string GetSqlKey()
		{
			return "[Codigo] = " + Codigo.ToString();
		}
		#endregion

	}

	#endregion

	#region RutasSatrackTipoEventosList object

	/// <summary>
	/// Class for reading and access a list of RutasSatrackTipoEventos object
	/// </summary>
	[CollectionDataContract]
	public partial class RutasSatrackTipoEventosList : List<RutasSatrackTipoEventos>
	{

		/// <summary>
		/// Default constructor
		/// </summary>
		public RutasSatrackTipoEventosList()
		{
		}
	}

	#endregion

}
