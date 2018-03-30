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
	#region consecutivos object

	[DataContract]
	public partial class consecutivos : IDTOObject
	{
		/// <summary>
		/// Default constructor
		/// </summary>
		public consecutivos()
		{
			m_tipo = "";
			m_siguiente = null;
			m_changed=false;
		}
		        //Return the table name of object
		        public string TableName()
		        {
		            return "consecutivos";
		        }
		#region Undo 
		// Internal class for storing changes
		private consecutivos m_oldconsecutivos;
		public void GenerateUndo()
		{
			m_oldconsecutivos=new consecutivos();
			m_oldconsecutivos.m_tipo = m_tipo;
			m_oldconsecutivos.siguiente = m_siguiente;
		}

		public consecutivos Oldconsecutivos
		{
			get { return m_oldconsecutivos;}
		}
		// Return the changed fields
		public string[] FieldChanged()
		{
			List<string> fields=new List<string>();
			if (m_oldconsecutivos.siguiente != m_siguiente) fields.Add("siguiente");
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


		// Field for storing the consecutivos's tipo value
		private string m_tipo;

		// Field for storing the consecutivos's siguiente value
		private int? m_siguiente;

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
		/// Attribute for access the consecutivos's tipo value (string)
		/// </summary>
		[DataMember]
		public string tipo
		{
			get { return m_tipo; }
			set 
			{
				m_changed=true;
				m_tipo = value;
			}
		}

		/// <summary>
		/// Attribute for access the consecutivos's siguiente value (int)
		/// </summary>
		[DataMember]
		public int? siguiente
		{
			get { return m_siguiente; }
			set 
			{
				m_changed=true;
				m_siguiente = value;
			}
		}

		public object GetAttribute(string pattribute)
		{
			switch (pattribute)
			{
				case "tipo": return tipo;
				case "siguiente": return siguiente;
				default: return null;
			}
		}

		public Type GetAttributeType(string pattribute)
		{
			return consecutivosController.Instance.GetMethodType(pattribute, this);
		}

		public string GetSqlKey()
		{
			return "[tipo] = '" + tipo.ToString()+ "'";
		}
		#endregion

	}

	#endregion

	#region consecutivosList object

	/// <summary>
	/// Class for reading and access a list of consecutivos object
	/// </summary>
	[CollectionDataContract]
	public partial class consecutivosList : List<consecutivos>
	{

		/// <summary>
		/// Default constructor
		/// </summary>
		public consecutivosList()
		{
		}
	}

	#endregion

}
