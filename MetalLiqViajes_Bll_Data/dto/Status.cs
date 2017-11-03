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
	#region Status object

	[DataContract]
	public partial class Status : IDTOObject
	{
		/// <summary>
		/// Default constructor
		/// </summary>
		public Status()
		{
			m_lngIdStatus = 0;
			m_strStatus = null;
			m_changed=false;
		}
		        //Return the table name of object
		        public string TableName()
		        {
		            return "tblStatus";
		        }
		#region Undo 
		// Internal class for storing changes
		private Status m_oldStatus;
		public void GenerateUndo()
		{
			m_oldStatus=new Status();
			m_oldStatus.m_lngIdStatus = m_lngIdStatus;
			m_oldStatus.strStatus = m_strStatus;
		}

		public Status OldStatus
		{
			get { return m_oldStatus;}
		}
		// Return the changed fields
		public string[] FieldChanged()
		{
			List<string> fields=new List<string>();
			if (m_oldStatus.strStatus != m_strStatus) fields.Add("strStatus");
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


		// Field for storing the Status's strStatus value
		private string m_strStatus;

		// Field for storing the Status's lngIdStatus value
		private int m_lngIdStatus;

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
		/// Attribute for access the Status's strStatus value (string)
		/// </summary>
		[DataMember]
		public string strStatus
		{
			get { return m_strStatus; }
			set 
			{
				m_changed=true;
				m_strStatus = value;
			}
		}

		/// <summary>
		/// Attribute for access the Status's lngIdStatus value (int)
		/// </summary>
		[DataMember]
		public int lngIdStatus
		{
			get { return m_lngIdStatus; }
			set 
			{
				m_changed=true;
				m_lngIdStatus = value;
			}
		}

		public object GetAttribute(string pattribute)
		{
			switch (pattribute)
			{
				case "strStatus": return strStatus;
				case "lngIdStatus": return lngIdStatus;
				default: return null;
			}
		}

		public Type GetAttributeType(string pattribute)
		{
			return StatusController.Instance.GetMethodType(pattribute, this);
		}

		public string GetSqlKey()
		{
			return "[lngIdStatus] = " + lngIdStatus.ToString();
		}
		#endregion

	}

	#endregion

	#region StatusList object

	/// <summary>
	/// Class for reading and access a list of Status object
	/// </summary>
	[CollectionDataContract]
	public partial class StatusList : List<Status>
	{

		/// <summary>
		/// Default constructor
		/// </summary>
		public StatusList()
		{
		}
	}

	#endregion

}
