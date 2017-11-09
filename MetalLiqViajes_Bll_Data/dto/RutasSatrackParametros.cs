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
	#region RutasSatrackParametros object

	[DataContract]
	public partial class RutasSatrackParametros : IDTOObject
	{
		/// <summary>
		/// Default constructor
		/// </summary>
		public RutasSatrackParametros()
		{
			m_Codigo = 0;
			m_NombreEvento = null;
			m_ACtivoWS = false;
			m_ACtivoWinForm = false;
			m_TipoEvento = null;
			m_changed=false;
		}
		        //Return the table name of object
		        public string TableName()
		        {
		            return "RutasSatrackParametros";
		        }
		#region Undo 
		// Internal class for storing changes
		private RutasSatrackParametros m_oldRutasSatrackParametros;
		public void GenerateUndo()
		{
			m_oldRutasSatrackParametros=new RutasSatrackParametros();
			m_oldRutasSatrackParametros.m_Codigo = m_Codigo;
			m_oldRutasSatrackParametros.NombreEvento = m_NombreEvento;
			m_oldRutasSatrackParametros.ACtivoWS = m_ACtivoWS;
			m_oldRutasSatrackParametros.ACtivoWinForm = m_ACtivoWinForm;
			m_oldRutasSatrackParametros.TipoEvento = m_TipoEvento;
		}

		public RutasSatrackParametros OldRutasSatrackParametros
		{
			get { return m_oldRutasSatrackParametros;}
		}
		// Return the changed fields
		public string[] FieldChanged()
		{
			List<string> fields=new List<string>();
			if (m_oldRutasSatrackParametros.NombreEvento != m_NombreEvento) fields.Add("NombreEvento");
			if (m_oldRutasSatrackParametros.ACtivoWS != m_ACtivoWS) fields.Add("ACtivoWS");
			if (m_oldRutasSatrackParametros.ACtivoWinForm != m_ACtivoWinForm) fields.Add("ACtivoWinForm");
			if (m_oldRutasSatrackParametros.TipoEvento != m_TipoEvento) fields.Add("TipoEvento");
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


		// Field for storing the RutasSatrackParametros's Codigo value
		private int m_Codigo;

		// Field for storing the RutasSatrackParametros's NombreEvento value
		private string m_NombreEvento;

		// Field for storing the RutasSatrackParametros's ACtivoWS value
		private bool? m_ACtivoWS;

		// Field for storing the RutasSatrackParametros's ACtivoWinForm value
		private bool? m_ACtivoWinForm;

		// Field for storing the RutasSatrackParametros's TipoEvento value
		private int? m_TipoEvento;

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
		/// Attribute for access the RutasSatrackParametros's Codigo value (int)
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
		/// Attribute for access the RutasSatrackParametros's NombreEvento value (string)
		/// </summary>
		[DataMember]
		public string NombreEvento
		{
			get { return m_NombreEvento; }
			set 
			{
				m_changed=true;
				m_NombreEvento = value;
			}
		}

		/// <summary>
		/// Attribute for access the RutasSatrackParametros's ACtivoWS value (bool)
		/// </summary>
		[DataMember]
		public bool? ACtivoWS
		{
			get { return m_ACtivoWS; }
			set 
			{
				m_changed=true;
				m_ACtivoWS = value;
			}
		}

		/// <summary>
		/// Attribute for access the RutasSatrackParametros's ACtivoWinForm value (bool)
		/// </summary>
		[DataMember]
		public bool? ACtivoWinForm
		{
			get { return m_ACtivoWinForm; }
			set 
			{
				m_changed=true;
				m_ACtivoWinForm = value;
			}
		}

		/// <summary>
		/// Attribute for access the RutasSatrackParametros's TipoEvento value (int)
		/// </summary>
		[DataMember]
		public int? TipoEvento
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
				case "NombreEvento": return NombreEvento;
				case "ACtivoWS": return ACtivoWS;
				case "ACtivoWinForm": return ACtivoWinForm;
				case "TipoEvento": return TipoEvento;
				default: return null;
			}
		}

		public Type GetAttributeType(string pattribute)
		{
			return RutasSatrackParametrosController.Instance.GetMethodType(pattribute, this);
		}

		public string GetSqlKey()
		{
			return "[Codigo] = " + Codigo.ToString();
		}
		#endregion

	}

	#endregion

	#region RutasSatrackParametrosList object

	/// <summary>
	/// Class for reading and access a list of RutasSatrackParametros object
	/// </summary>
	[CollectionDataContract]
	public partial class RutasSatrackParametrosList : List<RutasSatrackParametros>
	{

		/// <summary>
		/// Default constructor
		/// </summary>
		public RutasSatrackParametrosList()
		{
		}
	}

	#endregion

}
