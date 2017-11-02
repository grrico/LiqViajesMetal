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
	#region Fecha object

	[DataContract]
	public partial class Fecha : IDTOObject
	{
		/// <summary>
		/// Default constructor
		/// </summary>
		public Fecha()
		{
			m_PK_Date = DateTime.Now.Date;
			m_Date_Name = null;
			m_Year = null;
			m_Year_Name = null;
			m_Trimester = null;
			m_Trimester_Name = null;
			m_Month = null;
			m_Month_Name = null;
			m_Week = null;
			m_Week_Name = null;
			m_Day_Of_Year = null;
			m_Day_Of_Year_Name = null;
			m_Day_Of_Trimester = null;
			m_Day_Of_Trimester_Name = null;
			m_Day_Of_Month = null;
			m_Day_Of_Month_Name = null;
			m_Day_Of_Week = null;
			m_Day_Of_Week_Name = null;
			m_Week_Of_Year = null;
			m_Week_Of_Year_Name = null;
			m_Month_Of_Year = null;
			m_Month_Of_Year_Name = null;
			m_Month_Of_Trimester = null;
			m_Month_Of_Trimester_Name = null;
			m_Trimester_Of_Year = null;
			m_Trimester_Of_Year_Name = null;
			m_changed=false;
		}
		        //Return the table name of object
		        public string TableName()
		        {
		            return "Fecha";
		        }
		#region Undo 
		// Internal class for storing changes
		private Fecha m_oldFecha;
		public void GenerateUndo()
		{
			m_oldFecha=new Fecha();
			m_oldFecha.m_PK_Date = m_PK_Date;
			m_oldFecha.Date_Name = m_Date_Name;
			m_oldFecha.Year = m_Year;
			m_oldFecha.Year_Name = m_Year_Name;
			m_oldFecha.Trimester = m_Trimester;
			m_oldFecha.Trimester_Name = m_Trimester_Name;
			m_oldFecha.Month = m_Month;
			m_oldFecha.Month_Name = m_Month_Name;
			m_oldFecha.Week = m_Week;
			m_oldFecha.Week_Name = m_Week_Name;
			m_oldFecha.Day_Of_Year = m_Day_Of_Year;
			m_oldFecha.Day_Of_Year_Name = m_Day_Of_Year_Name;
			m_oldFecha.Day_Of_Trimester = m_Day_Of_Trimester;
			m_oldFecha.Day_Of_Trimester_Name = m_Day_Of_Trimester_Name;
			m_oldFecha.Day_Of_Month = m_Day_Of_Month;
			m_oldFecha.Day_Of_Month_Name = m_Day_Of_Month_Name;
			m_oldFecha.Day_Of_Week = m_Day_Of_Week;
			m_oldFecha.Day_Of_Week_Name = m_Day_Of_Week_Name;
			m_oldFecha.Week_Of_Year = m_Week_Of_Year;
			m_oldFecha.Week_Of_Year_Name = m_Week_Of_Year_Name;
			m_oldFecha.Month_Of_Year = m_Month_Of_Year;
			m_oldFecha.Month_Of_Year_Name = m_Month_Of_Year_Name;
			m_oldFecha.Month_Of_Trimester = m_Month_Of_Trimester;
			m_oldFecha.Month_Of_Trimester_Name = m_Month_Of_Trimester_Name;
			m_oldFecha.Trimester_Of_Year = m_Trimester_Of_Year;
			m_oldFecha.Trimester_Of_Year_Name = m_Trimester_Of_Year_Name;
		}

		public Fecha OldFecha
		{
			get { return m_oldFecha;}
		}
		// Return the changed fields
		public string[] FieldChanged()
		{
			List<string> fields=new List<string>();
			if (m_oldFecha.Date_Name != m_Date_Name) fields.Add("Date_Name");
			if (m_oldFecha.Year != m_Year) fields.Add("Year");
			if (m_oldFecha.Year_Name != m_Year_Name) fields.Add("Year_Name");
			if (m_oldFecha.Trimester != m_Trimester) fields.Add("Trimester");
			if (m_oldFecha.Trimester_Name != m_Trimester_Name) fields.Add("Trimester_Name");
			if (m_oldFecha.Month != m_Month) fields.Add("Month");
			if (m_oldFecha.Month_Name != m_Month_Name) fields.Add("Month_Name");
			if (m_oldFecha.Week != m_Week) fields.Add("Week");
			if (m_oldFecha.Week_Name != m_Week_Name) fields.Add("Week_Name");
			if (m_oldFecha.Day_Of_Year != m_Day_Of_Year) fields.Add("Day_Of_Year");
			if (m_oldFecha.Day_Of_Year_Name != m_Day_Of_Year_Name) fields.Add("Day_Of_Year_Name");
			if (m_oldFecha.Day_Of_Trimester != m_Day_Of_Trimester) fields.Add("Day_Of_Trimester");
			if (m_oldFecha.Day_Of_Trimester_Name != m_Day_Of_Trimester_Name) fields.Add("Day_Of_Trimester_Name");
			if (m_oldFecha.Day_Of_Month != m_Day_Of_Month) fields.Add("Day_Of_Month");
			if (m_oldFecha.Day_Of_Month_Name != m_Day_Of_Month_Name) fields.Add("Day_Of_Month_Name");
			if (m_oldFecha.Day_Of_Week != m_Day_Of_Week) fields.Add("Day_Of_Week");
			if (m_oldFecha.Day_Of_Week_Name != m_Day_Of_Week_Name) fields.Add("Day_Of_Week_Name");
			if (m_oldFecha.Week_Of_Year != m_Week_Of_Year) fields.Add("Week_Of_Year");
			if (m_oldFecha.Week_Of_Year_Name != m_Week_Of_Year_Name) fields.Add("Week_Of_Year_Name");
			if (m_oldFecha.Month_Of_Year != m_Month_Of_Year) fields.Add("Month_Of_Year");
			if (m_oldFecha.Month_Of_Year_Name != m_Month_Of_Year_Name) fields.Add("Month_Of_Year_Name");
			if (m_oldFecha.Month_Of_Trimester != m_Month_Of_Trimester) fields.Add("Month_Of_Trimester");
			if (m_oldFecha.Month_Of_Trimester_Name != m_Month_Of_Trimester_Name) fields.Add("Month_Of_Trimester_Name");
			if (m_oldFecha.Trimester_Of_Year != m_Trimester_Of_Year) fields.Add("Trimester_Of_Year");
			if (m_oldFecha.Trimester_Of_Year_Name != m_Trimester_Of_Year_Name) fields.Add("Trimester_Of_Year_Name");
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


		// Field for storing the Fecha's PK_Date value
		private DateTime m_PK_Date;

		// Field for storing the Fecha's Date_Name value
		private string m_Date_Name;

		// Field for storing the Fecha's Year value
		private DateTime? m_Year;

		// Field for storing the Fecha's Year_Name value
		private string m_Year_Name;

		// Field for storing the Fecha's Trimester value
		private DateTime? m_Trimester;

		// Field for storing the Fecha's Trimester_Name value
		private string m_Trimester_Name;

		// Field for storing the Fecha's Month value
		private DateTime? m_Month;

		// Field for storing the Fecha's Month_Name value
		private string m_Month_Name;

		// Field for storing the Fecha's Week value
		private DateTime? m_Week;

		// Field for storing the Fecha's Week_Name value
		private string m_Week_Name;

		// Field for storing the Fecha's Day_Of_Year value
		private int? m_Day_Of_Year;

		// Field for storing the Fecha's Day_Of_Year_Name value
		private string m_Day_Of_Year_Name;

		// Field for storing the Fecha's Day_Of_Trimester value
		private int? m_Day_Of_Trimester;

		// Field for storing the Fecha's Day_Of_Trimester_Name value
		private string m_Day_Of_Trimester_Name;

		// Field for storing the Fecha's Day_Of_Month value
		private int? m_Day_Of_Month;

		// Field for storing the Fecha's Day_Of_Month_Name value
		private string m_Day_Of_Month_Name;

		// Field for storing the Fecha's Day_Of_Week value
		private int? m_Day_Of_Week;

		// Field for storing the Fecha's Day_Of_Week_Name value
		private string m_Day_Of_Week_Name;

		// Field for storing the Fecha's Week_Of_Year value
		private int? m_Week_Of_Year;

		// Field for storing the Fecha's Week_Of_Year_Name value
		private string m_Week_Of_Year_Name;

		// Field for storing the Fecha's Month_Of_Year value
		private int? m_Month_Of_Year;

		// Field for storing the Fecha's Month_Of_Year_Name value
		private string m_Month_Of_Year_Name;

		// Field for storing the Fecha's Month_Of_Trimester value
		private int? m_Month_Of_Trimester;

		// Field for storing the Fecha's Month_Of_Trimester_Name value
		private string m_Month_Of_Trimester_Name;

		// Field for storing the Fecha's Trimester_Of_Year value
		private int? m_Trimester_Of_Year;

		// Field for storing the Fecha's Trimester_Of_Year_Name value
		private string m_Trimester_Of_Year_Name;

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
		/// Attribute for access the Fecha's PK_Date value (DateTime)
		/// </summary>
		[DataMember]
		public DateTime PK_Date
		{
			get { return m_PK_Date; }
			set 
			{
				m_changed=true;
				m_PK_Date = value;
			}
		}

		/// <summary>
		/// Attribute for access the Fecha's Date_Name value (string)
		/// </summary>
		[DataMember]
		public string Date_Name
		{
			get { return m_Date_Name; }
			set 
			{
				m_changed=true;
				m_Date_Name = value;
			}
		}

		/// <summary>
		/// Attribute for access the Fecha's Year value (DateTime)
		/// </summary>
		[DataMember]
		public DateTime? Year
		{
			get { return m_Year; }
			set 
			{
				m_changed=true;
				m_Year = value;
			}
		}

		/// <summary>
		/// Attribute for access the Fecha's Year_Name value (string)
		/// </summary>
		[DataMember]
		public string Year_Name
		{
			get { return m_Year_Name; }
			set 
			{
				m_changed=true;
				m_Year_Name = value;
			}
		}

		/// <summary>
		/// Attribute for access the Fecha's Trimester value (DateTime)
		/// </summary>
		[DataMember]
		public DateTime? Trimester
		{
			get { return m_Trimester; }
			set 
			{
				m_changed=true;
				m_Trimester = value;
			}
		}

		/// <summary>
		/// Attribute for access the Fecha's Trimester_Name value (string)
		/// </summary>
		[DataMember]
		public string Trimester_Name
		{
			get { return m_Trimester_Name; }
			set 
			{
				m_changed=true;
				m_Trimester_Name = value;
			}
		}

		/// <summary>
		/// Attribute for access the Fecha's Month value (DateTime)
		/// </summary>
		[DataMember]
		public DateTime? Month
		{
			get { return m_Month; }
			set 
			{
				m_changed=true;
				m_Month = value;
			}
		}

		/// <summary>
		/// Attribute for access the Fecha's Month_Name value (string)
		/// </summary>
		[DataMember]
		public string Month_Name
		{
			get { return m_Month_Name; }
			set 
			{
				m_changed=true;
				m_Month_Name = value;
			}
		}

		/// <summary>
		/// Attribute for access the Fecha's Week value (DateTime)
		/// </summary>
		[DataMember]
		public DateTime? Week
		{
			get { return m_Week; }
			set 
			{
				m_changed=true;
				m_Week = value;
			}
		}

		/// <summary>
		/// Attribute for access the Fecha's Week_Name value (string)
		/// </summary>
		[DataMember]
		public string Week_Name
		{
			get { return m_Week_Name; }
			set 
			{
				m_changed=true;
				m_Week_Name = value;
			}
		}

		/// <summary>
		/// Attribute for access the Fecha's Day_Of_Year value (int)
		/// </summary>
		[DataMember]
		public int? Day_Of_Year
		{
			get { return m_Day_Of_Year; }
			set 
			{
				m_changed=true;
				m_Day_Of_Year = value;
			}
		}

		/// <summary>
		/// Attribute for access the Fecha's Day_Of_Year_Name value (string)
		/// </summary>
		[DataMember]
		public string Day_Of_Year_Name
		{
			get { return m_Day_Of_Year_Name; }
			set 
			{
				m_changed=true;
				m_Day_Of_Year_Name = value;
			}
		}

		/// <summary>
		/// Attribute for access the Fecha's Day_Of_Trimester value (int)
		/// </summary>
		[DataMember]
		public int? Day_Of_Trimester
		{
			get { return m_Day_Of_Trimester; }
			set 
			{
				m_changed=true;
				m_Day_Of_Trimester = value;
			}
		}

		/// <summary>
		/// Attribute for access the Fecha's Day_Of_Trimester_Name value (string)
		/// </summary>
		[DataMember]
		public string Day_Of_Trimester_Name
		{
			get { return m_Day_Of_Trimester_Name; }
			set 
			{
				m_changed=true;
				m_Day_Of_Trimester_Name = value;
			}
		}

		/// <summary>
		/// Attribute for access the Fecha's Day_Of_Month value (int)
		/// </summary>
		[DataMember]
		public int? Day_Of_Month
		{
			get { return m_Day_Of_Month; }
			set 
			{
				m_changed=true;
				m_Day_Of_Month = value;
			}
		}

		/// <summary>
		/// Attribute for access the Fecha's Day_Of_Month_Name value (string)
		/// </summary>
		[DataMember]
		public string Day_Of_Month_Name
		{
			get { return m_Day_Of_Month_Name; }
			set 
			{
				m_changed=true;
				m_Day_Of_Month_Name = value;
			}
		}

		/// <summary>
		/// Attribute for access the Fecha's Day_Of_Week value (int)
		/// </summary>
		[DataMember]
		public int? Day_Of_Week
		{
			get { return m_Day_Of_Week; }
			set 
			{
				m_changed=true;
				m_Day_Of_Week = value;
			}
		}

		/// <summary>
		/// Attribute for access the Fecha's Day_Of_Week_Name value (string)
		/// </summary>
		[DataMember]
		public string Day_Of_Week_Name
		{
			get { return m_Day_Of_Week_Name; }
			set 
			{
				m_changed=true;
				m_Day_Of_Week_Name = value;
			}
		}

		/// <summary>
		/// Attribute for access the Fecha's Week_Of_Year value (int)
		/// </summary>
		[DataMember]
		public int? Week_Of_Year
		{
			get { return m_Week_Of_Year; }
			set 
			{
				m_changed=true;
				m_Week_Of_Year = value;
			}
		}

		/// <summary>
		/// Attribute for access the Fecha's Week_Of_Year_Name value (string)
		/// </summary>
		[DataMember]
		public string Week_Of_Year_Name
		{
			get { return m_Week_Of_Year_Name; }
			set 
			{
				m_changed=true;
				m_Week_Of_Year_Name = value;
			}
		}

		/// <summary>
		/// Attribute for access the Fecha's Month_Of_Year value (int)
		/// </summary>
		[DataMember]
		public int? Month_Of_Year
		{
			get { return m_Month_Of_Year; }
			set 
			{
				m_changed=true;
				m_Month_Of_Year = value;
			}
		}

		/// <summary>
		/// Attribute for access the Fecha's Month_Of_Year_Name value (string)
		/// </summary>
		[DataMember]
		public string Month_Of_Year_Name
		{
			get { return m_Month_Of_Year_Name; }
			set 
			{
				m_changed=true;
				m_Month_Of_Year_Name = value;
			}
		}

		/// <summary>
		/// Attribute for access the Fecha's Month_Of_Trimester value (int)
		/// </summary>
		[DataMember]
		public int? Month_Of_Trimester
		{
			get { return m_Month_Of_Trimester; }
			set 
			{
				m_changed=true;
				m_Month_Of_Trimester = value;
			}
		}

		/// <summary>
		/// Attribute for access the Fecha's Month_Of_Trimester_Name value (string)
		/// </summary>
		[DataMember]
		public string Month_Of_Trimester_Name
		{
			get { return m_Month_Of_Trimester_Name; }
			set 
			{
				m_changed=true;
				m_Month_Of_Trimester_Name = value;
			}
		}

		/// <summary>
		/// Attribute for access the Fecha's Trimester_Of_Year value (int)
		/// </summary>
		[DataMember]
		public int? Trimester_Of_Year
		{
			get { return m_Trimester_Of_Year; }
			set 
			{
				m_changed=true;
				m_Trimester_Of_Year = value;
			}
		}

		/// <summary>
		/// Attribute for access the Fecha's Trimester_Of_Year_Name value (string)
		/// </summary>
		[DataMember]
		public string Trimester_Of_Year_Name
		{
			get { return m_Trimester_Of_Year_Name; }
			set 
			{
				m_changed=true;
				m_Trimester_Of_Year_Name = value;
			}
		}

		public object GetAttribute(string pattribute)
		{
			switch (pattribute)
			{
				case "PK_Date": return PK_Date;
				case "Date_Name": return Date_Name;
				case "Year": return Year;
				case "Year_Name": return Year_Name;
				case "Trimester": return Trimester;
				case "Trimester_Name": return Trimester_Name;
				case "Month": return Month;
				case "Month_Name": return Month_Name;
				case "Week": return Week;
				case "Week_Name": return Week_Name;
				case "Day_Of_Year": return Day_Of_Year;
				case "Day_Of_Year_Name": return Day_Of_Year_Name;
				case "Day_Of_Trimester": return Day_Of_Trimester;
				case "Day_Of_Trimester_Name": return Day_Of_Trimester_Name;
				case "Day_Of_Month": return Day_Of_Month;
				case "Day_Of_Month_Name": return Day_Of_Month_Name;
				case "Day_Of_Week": return Day_Of_Week;
				case "Day_Of_Week_Name": return Day_Of_Week_Name;
				case "Week_Of_Year": return Week_Of_Year;
				case "Week_Of_Year_Name": return Week_Of_Year_Name;
				case "Month_Of_Year": return Month_Of_Year;
				case "Month_Of_Year_Name": return Month_Of_Year_Name;
				case "Month_Of_Trimester": return Month_Of_Trimester;
				case "Month_Of_Trimester_Name": return Month_Of_Trimester_Name;
				case "Trimester_Of_Year": return Trimester_Of_Year;
				case "Trimester_Of_Year_Name": return Trimester_Of_Year_Name;
				default: return null;
			}
		}

		public Type GetAttributeType(string pattribute)
		{
			return FechaController.Instance.GetMethodType(pattribute, this);
		}

		public string GetSqlKey()
		{
			return "[PK_Date] = " + PK_Date.ToString();
		}
		#endregion

	}

	#endregion

	#region FechaList object

	/// <summary>
	/// Class for reading and access a list of Fecha object
	/// </summary>
	[CollectionDataContract]
	public partial class FechaList : List<Fecha>
	{

		/// <summary>
		/// Default constructor
		/// </summary>
		public FechaList()
		{
		}
	}

	#endregion

}
