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
	#region OpcionesDetNivelIII object

	[DataContract]
	public partial class OpcionesDetNivelIII : IDTOObject
	{
		/// <summary>
		/// Default constructor
		/// </summary>
		public OpcionesDetNivelIII()
		{
			m_lngIdOpcion = 0;
			m_strDescOpcion = null;
			m_strPrograma = null;
			m_strParametros = null;
			m_lngIdOpcionPadre = null;
			m_strTipoOpcion = null;
			m_intOrden = null;
			m_WebBrowser = false;
			m_changed=false;
		}
		        //Return the table name of object
		        public string TableName()
		        {
		            return "tblOpcionesDetNivelIII";
		        }
		#region Undo 
		// Internal class for storing changes
		private OpcionesDetNivelIII m_oldOpcionesDetNivelIII;
		public void GenerateUndo()
		{
			m_oldOpcionesDetNivelIII=new OpcionesDetNivelIII();
			m_oldOpcionesDetNivelIII.m_lngIdOpcion = m_lngIdOpcion;
			m_oldOpcionesDetNivelIII.strDescOpcion = m_strDescOpcion;
			m_oldOpcionesDetNivelIII.strPrograma = m_strPrograma;
			m_oldOpcionesDetNivelIII.strParametros = m_strParametros;
			m_oldOpcionesDetNivelIII.lngIdOpcionPadre = m_lngIdOpcionPadre;
			m_oldOpcionesDetNivelIII.strTipoOpcion = m_strTipoOpcion;
			m_oldOpcionesDetNivelIII.intOrden = m_intOrden;
			m_oldOpcionesDetNivelIII.WebBrowser = m_WebBrowser;
		}

		public OpcionesDetNivelIII OldOpcionesDetNivelIII
		{
			get { return m_oldOpcionesDetNivelIII;}
		}
		// Return the changed fields
		public string[] FieldChanged()
		{
			List<string> fields=new List<string>();
			if (m_oldOpcionesDetNivelIII.strDescOpcion != m_strDescOpcion) fields.Add("strDescOpcion");
			if (m_oldOpcionesDetNivelIII.strPrograma != m_strPrograma) fields.Add("strPrograma");
			if (m_oldOpcionesDetNivelIII.strParametros != m_strParametros) fields.Add("strParametros");
			if (m_oldOpcionesDetNivelIII.lngIdOpcionPadre != m_lngIdOpcionPadre) fields.Add("lngIdOpcionPadre");
			if (m_oldOpcionesDetNivelIII.strTipoOpcion != m_strTipoOpcion) fields.Add("strTipoOpcion");
			if (m_oldOpcionesDetNivelIII.intOrden != m_intOrden) fields.Add("intOrden");
			if (m_oldOpcionesDetNivelIII.WebBrowser != m_WebBrowser) fields.Add("WebBrowser");
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


		// Field for storing the OpcionesDetNivelIII's strDescOpcion value
		private string m_strDescOpcion;

		// Field for storing the OpcionesDetNivelIII's strPrograma value
		private string m_strPrograma;

		// Field for storing the OpcionesDetNivelIII's strParametros value
		private string m_strParametros;

		// Field for storing the OpcionesDetNivelIII's lngIdOpcionPadre value
		private int? m_lngIdOpcionPadre;

		// Field for storing the OpcionesDetNivelIII's strTipoOpcion value
		private string m_strTipoOpcion;

		// Field for storing the OpcionesDetNivelIII's intOrden value
		private int? m_intOrden;

		// Field for storing the OpcionesDetNivelIII's WebBrowser value
		private bool? m_WebBrowser;

		// Field for storing the OpcionesDetNivelIII's lngIdOpcion value
		private int m_lngIdOpcion;

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
		/// Attribute for access the OpcionesDetNivelIII's strDescOpcion value (string)
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
		/// Attribute for access the OpcionesDetNivelIII's strPrograma value (string)
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
		/// Attribute for access the OpcionesDetNivelIII's strParametros value (string)
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
		/// Attribute for access the OpcionesDetNivelIII's lngIdOpcionPadre value (int)
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
		/// Attribute for access the OpcionesDetNivelIII's strTipoOpcion value (string)
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
		/// Attribute for access the OpcionesDetNivelIII's intOrden value (int)
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
		/// Attribute for access the OpcionesDetNivelIII's WebBrowser value (bool)
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
		/// Attribute for access the OpcionesDetNivelIII's lngIdOpcion value (int)
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

		public object GetAttribute(string pattribute)
		{
			switch (pattribute)
			{
				case "strDescOpcion": return strDescOpcion;
				case "strPrograma": return strPrograma;
				case "strParametros": return strParametros;
				case "lngIdOpcionPadre": return lngIdOpcionPadre;
				case "strTipoOpcion": return strTipoOpcion;
				case "intOrden": return intOrden;
				case "WebBrowser": return WebBrowser;
				case "lngIdOpcion": return lngIdOpcion;
				default: return null;
			}
		}

		public Type GetAttributeType(string pattribute)
		{
			return OpcionesDetNivelIIIController.Instance.GetMethodType(pattribute, this);
		}

		public string GetSqlKey()
		{
			return "[lngIdOpcion] = " + lngIdOpcion.ToString();
		}
		#endregion

	}

	#endregion

	#region OpcionesDetNivelIIIList object

	/// <summary>
	/// Class for reading and access a list of OpcionesDetNivelIII object
	/// </summary>
	[CollectionDataContract]
	public partial class OpcionesDetNivelIIIList : List<OpcionesDetNivelIII>
	{

		/// <summary>
		/// Default constructor
		/// </summary>
		public OpcionesDetNivelIIIList()
		{
		}
	}

	#endregion

}
