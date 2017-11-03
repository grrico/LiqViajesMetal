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
	#region RutasAbreviaturas object

	[DataContract]
	public partial class RutasAbreviaturas : IDTOObject
	{
		/// <summary>
		/// Default constructor
		/// </summary>
		public RutasAbreviaturas()
		{
			m_lngIdAbreviatura = 0;
			m_strAbreviatura = null;
			m_strNombreAbreviatura = null;
			m_changed=false;
		}
		        //Return the table name of object
		        public string TableName()
		        {
		            return "tblRutasAbreviaturas";
		        }
		#region Undo 
		// Internal class for storing changes
		private RutasAbreviaturas m_oldRutasAbreviaturas;
		public void GenerateUndo()
		{
			m_oldRutasAbreviaturas=new RutasAbreviaturas();
			m_oldRutasAbreviaturas.m_lngIdAbreviatura = m_lngIdAbreviatura;
			m_oldRutasAbreviaturas.strAbreviatura = m_strAbreviatura;
			m_oldRutasAbreviaturas.strNombreAbreviatura = m_strNombreAbreviatura;
		}

		public RutasAbreviaturas OldRutasAbreviaturas
		{
			get { return m_oldRutasAbreviaturas;}
		}
		// Return the changed fields
		public string[] FieldChanged()
		{
			List<string> fields=new List<string>();
			if (m_oldRutasAbreviaturas.strAbreviatura != m_strAbreviatura) fields.Add("strAbreviatura");
			if (m_oldRutasAbreviaturas.strNombreAbreviatura != m_strNombreAbreviatura) fields.Add("strNombreAbreviatura");
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


		// Field for storing the RutasAbreviaturas's strAbreviatura value
		private string m_strAbreviatura;

		// Field for storing the RutasAbreviaturas's strNombreAbreviatura value
		private string m_strNombreAbreviatura;

		// Field for storing the RutasAbreviaturas's lngIdAbreviatura value
		private int m_lngIdAbreviatura;

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
		/// Attribute for access the RutasAbreviaturas's strAbreviatura value (string)
		/// </summary>
		[DataMember]
		public string strAbreviatura
		{
			get { return m_strAbreviatura; }
			set 
			{
				m_changed=true;
				m_strAbreviatura = value;
			}
		}

		/// <summary>
		/// Attribute for access the RutasAbreviaturas's strNombreAbreviatura value (string)
		/// </summary>
		[DataMember]
		public string strNombreAbreviatura
		{
			get { return m_strNombreAbreviatura; }
			set 
			{
				m_changed=true;
				m_strNombreAbreviatura = value;
			}
		}

		/// <summary>
		/// Attribute for access the RutasAbreviaturas's lngIdAbreviatura value (int)
		/// </summary>
		[DataMember]
		public int lngIdAbreviatura
		{
			get { return m_lngIdAbreviatura; }
			set 
			{
				m_changed=true;
				m_lngIdAbreviatura = value;
			}
		}

		public object GetAttribute(string pattribute)
		{
			switch (pattribute)
			{
				case "strAbreviatura": return strAbreviatura;
				case "strNombreAbreviatura": return strNombreAbreviatura;
				case "lngIdAbreviatura": return lngIdAbreviatura;
				default: return null;
			}
		}

		public Type GetAttributeType(string pattribute)
		{
			return RutasAbreviaturasController.Instance.GetMethodType(pattribute, this);
		}

		public string GetSqlKey()
		{
			return "[lngIdAbreviatura] = " + lngIdAbreviatura.ToString();
		}
		#endregion

	}

	#endregion

	#region RutasAbreviaturasList object

	/// <summary>
	/// Class for reading and access a list of RutasAbreviaturas object
	/// </summary>
	[CollectionDataContract]
	public partial class RutasAbreviaturasList : List<RutasAbreviaturas>
	{

		/// <summary>
		/// Default constructor
		/// </summary>
		public RutasAbreviaturasList()
		{
		}
	}

	#endregion

}
