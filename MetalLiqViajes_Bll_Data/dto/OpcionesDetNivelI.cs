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
	#region OpcionesDetNivelI object

	[DataContract]
	public partial class OpcionesDetNivelI : IDTOObject
	{
		/// <summary>
		/// Default constructor
		/// </summary>
		public OpcionesDetNivelI()
		{
			m_lngIdOpcion = 0;
			m_strDescOpcion = null;
			m_strPrograma = null;
			m_strParametros = null;
			m_lngIdOpcionPadre = null;
			m_strTipoOpcion = null;
			m_intOrden = null;
			m_WebBrowser = false;
			m_logExpandeNode = false;
			m_strString = null;
			m_strColHidden = ' ';
			m_changed=false;
		}
		        //Return the table name of object
		        public string TableName()
		        {
		            return "tblOpcionesDetNivelI";
		        }
		#region Undo 
		// Internal class for storing changes
		private OpcionesDetNivelI m_oldOpcionesDetNivelI;
		public void GenerateUndo()
		{
			m_oldOpcionesDetNivelI=new OpcionesDetNivelI();
			m_oldOpcionesDetNivelI.m_lngIdOpcion = m_lngIdOpcion;
			m_oldOpcionesDetNivelI.strDescOpcion = m_strDescOpcion;
			m_oldOpcionesDetNivelI.strPrograma = m_strPrograma;
			m_oldOpcionesDetNivelI.strParametros = m_strParametros;
			m_oldOpcionesDetNivelI.lngIdOpcionPadre = m_lngIdOpcionPadre;
			m_oldOpcionesDetNivelI.strTipoOpcion = m_strTipoOpcion;
			m_oldOpcionesDetNivelI.intOrden = m_intOrden;
			m_oldOpcionesDetNivelI.WebBrowser = m_WebBrowser;
			m_oldOpcionesDetNivelI.logExpandeNode = m_logExpandeNode;
			m_oldOpcionesDetNivelI.strString = m_strString;
			m_oldOpcionesDetNivelI.strColHidden = m_strColHidden;
		}

		public OpcionesDetNivelI OldOpcionesDetNivelI
		{
			get { return m_oldOpcionesDetNivelI;}
		}
		// Return the changed fields
		public string[] FieldChanged()
		{
			List<string> fields=new List<string>();
			if (m_oldOpcionesDetNivelI.strDescOpcion != m_strDescOpcion) fields.Add("strDescOpcion");
			if (m_oldOpcionesDetNivelI.strPrograma != m_strPrograma) fields.Add("strPrograma");
			if (m_oldOpcionesDetNivelI.strParametros != m_strParametros) fields.Add("strParametros");
			if (m_oldOpcionesDetNivelI.lngIdOpcionPadre != m_lngIdOpcionPadre) fields.Add("lngIdOpcionPadre");
			if (m_oldOpcionesDetNivelI.strTipoOpcion != m_strTipoOpcion) fields.Add("strTipoOpcion");
			if (m_oldOpcionesDetNivelI.intOrden != m_intOrden) fields.Add("intOrden");
			if (m_oldOpcionesDetNivelI.WebBrowser != m_WebBrowser) fields.Add("WebBrowser");
			if (m_oldOpcionesDetNivelI.logExpandeNode != m_logExpandeNode) fields.Add("logExpandeNode");
			if (m_oldOpcionesDetNivelI.strString != m_strString) fields.Add("strString");
			if (m_oldOpcionesDetNivelI.strColHidden != m_strColHidden) fields.Add("strColHidden");
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


		// Field for storing the OpcionesDetNivelI's lngIdOpcion value
		private int m_lngIdOpcion;

		// Field for storing the OpcionesDetNivelI's strDescOpcion value
		private string m_strDescOpcion;

		// Field for storing the OpcionesDetNivelI's strPrograma value
		private string m_strPrograma;

		// Field for storing the OpcionesDetNivelI's strParametros value
		private string m_strParametros;

		// Field for storing the OpcionesDetNivelI's lngIdOpcionPadre value
		private int? m_lngIdOpcionPadre;

		// Field for storing the OpcionesDetNivelI's strTipoOpcion value
		private string m_strTipoOpcion;

		// Field for storing the OpcionesDetNivelI's intOrden value
		private int? m_intOrden;

		// Field for storing the OpcionesDetNivelI's WebBrowser value
		private bool? m_WebBrowser;

		// Field for storing the OpcionesDetNivelI's logExpandeNode value
		private bool? m_logExpandeNode;

		// Field for storing the OpcionesDetNivelI's strString value
		private string m_strString;

		// Field for storing the OpcionesDetNivelI's strColHidden value
		private char? m_strColHidden;

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
		/// Attribute for access the OpcionesDetNivelI's lngIdOpcion value (int)
		/// </summary>
		[DataMember]
		public int lngIdOpcion
		{
			get { return m_lngIdOpcion; }
			set 
			{
				m_changed=true;
				m_lngIdOpcion = value;
			}
		}

		/// <summary>
		/// Attribute for access the OpcionesDetNivelI's strDescOpcion value (string)
		/// </summary>
		[DataMember]
		public string strDescOpcion
		{
			get { return m_strDescOpcion; }
			set 
			{
				m_changed=true;
				m_strDescOpcion = value;
			}
		}

		/// <summary>
		/// Attribute for access the OpcionesDetNivelI's strPrograma value (string)
		/// </summary>
		[DataMember]
		public string strPrograma
		{
			get { return m_strPrograma; }
			set 
			{
				m_changed=true;
				m_strPrograma = value;
			}
		}

		/// <summary>
		/// Attribute for access the OpcionesDetNivelI's strParametros value (string)
		/// </summary>
		[DataMember]
		public string strParametros
		{
			get { return m_strParametros; }
			set 
			{
				m_changed=true;
				m_strParametros = value;
			}
		}

		/// <summary>
		/// Attribute for access the OpcionesDetNivelI's lngIdOpcionPadre value (int)
		/// </summary>
		[DataMember]
		public int? lngIdOpcionPadre
		{
			get { return m_lngIdOpcionPadre; }
			set 
			{
				m_changed=true;
				m_lngIdOpcionPadre = value;
			}
		}

		/// <summary>
		/// Attribute for access the OpcionesDetNivelI's strTipoOpcion value (string)
		/// </summary>
		[DataMember]
		public string strTipoOpcion
		{
			get { return m_strTipoOpcion; }
			set 
			{
				m_changed=true;
				m_strTipoOpcion = value;
			}
		}

		/// <summary>
		/// Attribute for access the OpcionesDetNivelI's intOrden value (int)
		/// </summary>
		[DataMember]
		public int? intOrden
		{
			get { return m_intOrden; }
			set 
			{
				m_changed=true;
				m_intOrden = value;
			}
		}

		/// <summary>
		/// Attribute for access the OpcionesDetNivelI's WebBrowser value (bool)
		/// </summary>
		[DataMember]
		public bool? WebBrowser
		{
			get { return m_WebBrowser; }
			set 
			{
				m_changed=true;
				m_WebBrowser = value;
			}
		}

		/// <summary>
		/// Attribute for access the OpcionesDetNivelI's logExpandeNode value (bool)
		/// </summary>
		[DataMember]
		public bool? logExpandeNode
		{
			get { return m_logExpandeNode; }
			set 
			{
				m_changed=true;
				m_logExpandeNode = value;
			}
		}

		/// <summary>
		/// Attribute for access the OpcionesDetNivelI's strString value (string)
		/// </summary>
		[DataMember]
		public string strString
		{
			get { return m_strString; }
			set 
			{
				m_changed=true;
				m_strString = value;
			}
		}

		/// <summary>
		/// Attribute for access the OpcionesDetNivelI's strColHidden value (char)
		/// </summary>
		[DataMember]
		public char? strColHidden
		{
			get { return m_strColHidden; }
			set 
			{
				m_changed=true;
				m_strColHidden = value;
			}
		}

		public object GetAttribute(string pattribute)
		{
			switch (pattribute)
			{
				case "lngIdOpcion": return lngIdOpcion;
				case "strDescOpcion": return strDescOpcion;
				case "strPrograma": return strPrograma;
				case "strParametros": return strParametros;
				case "lngIdOpcionPadre": return lngIdOpcionPadre;
				case "strTipoOpcion": return strTipoOpcion;
				case "intOrden": return intOrden;
				case "WebBrowser": return WebBrowser;
				case "logExpandeNode": return logExpandeNode;
				case "strString": return strString;
				case "strColHidden": return strColHidden;
				default: return null;
			}
		}

		public Type GetAttributeType(string pattribute)
		{
			return OpcionesDetNivelIController.Instance.GetMethodType(pattribute, this);
		}

		public string GetSqlKey()
		{
			return "[lngIdOpcion] = " + lngIdOpcion.ToString();
		}
		#endregion

	}

	#endregion

	#region OpcionesDetNivelIList object

	/// <summary>
	/// Class for reading and access a list of OpcionesDetNivelI object
	/// </summary>
	[CollectionDataContract]
	public partial class OpcionesDetNivelIList : List<OpcionesDetNivelI>
	{

		/// <summary>
		/// Default constructor
		/// </summary>
		public OpcionesDetNivelIList()
		{
		}
	}

	#endregion

}
