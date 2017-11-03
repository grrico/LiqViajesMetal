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
	#region Tareas object

	[DataContract]
	public partial class Tareas : IDTOObject
	{
		/// <summary>
		/// Default constructor
		/// </summary>
		public Tareas()
		{
			m_lngIdTarea = 0;
			m_strAsunto = null;
			m_dtmFechaInicio = null;
			m_strFechavencimiento = null;
			m_logAvisa = false;
			m_FechaAviso = null;
			m_Fechadefinalización = null;
			m_logFinalizada = false;
			m_Notas = null;
			m_lngIdStatus = null;
			m_changed=false;
		}
		        //Return the table name of object
		        public string TableName()
		        {
		            return "tblTareas";
		        }
		#region Undo 
		// Internal class for storing changes
		private Tareas m_oldTareas;
		public void GenerateUndo()
		{
			m_oldTareas=new Tareas();
			m_oldTareas.m_lngIdTarea = m_lngIdTarea;
			m_oldTareas.strAsunto = m_strAsunto;
			m_oldTareas.dtmFechaInicio = m_dtmFechaInicio;
			m_oldTareas.strFechavencimiento = m_strFechavencimiento;
			m_oldTareas.logAvisa = m_logAvisa;
			m_oldTareas.FechaAviso = m_FechaAviso;
			m_oldTareas.Fechadefinalización = m_Fechadefinalización;
			m_oldTareas.logFinalizada = m_logFinalizada;
			m_oldTareas.Notas = m_Notas;
			m_oldTareas.lngIdStatus = m_lngIdStatus;
		}

		public Tareas OldTareas
		{
			get { return m_oldTareas;}
		}
		// Return the changed fields
		public string[] FieldChanged()
		{
			List<string> fields=new List<string>();
			if (m_oldTareas.strAsunto != m_strAsunto) fields.Add("strAsunto");
			if (m_oldTareas.dtmFechaInicio != m_dtmFechaInicio) fields.Add("dtmFechaInicio");
			if (m_oldTareas.strFechavencimiento != m_strFechavencimiento) fields.Add("strFechavencimiento");
			if (m_oldTareas.logAvisa != m_logAvisa) fields.Add("logAvisa");
			if (m_oldTareas.FechaAviso != m_FechaAviso) fields.Add("FechaAviso");
			if (m_oldTareas.Fechadefinalización != m_Fechadefinalización) fields.Add("Fechadefinalización");
			if (m_oldTareas.logFinalizada != m_logFinalizada) fields.Add("logFinalizada");
			if (m_oldTareas.Notas != m_Notas) fields.Add("Notas");
			if (m_oldTareas.lngIdStatus != m_lngIdStatus) fields.Add("lngIdStatus");
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


		// Field for storing the Tareas's strAsunto value
		private string m_strAsunto;

		// Field for storing the Tareas's dtmFechaInicio value
		private DateTime? m_dtmFechaInicio;

		// Field for storing the Tareas's strFechavencimiento value
		private DateTime? m_strFechavencimiento;

		// Field for storing the Tareas's logAvisa value
		private bool? m_logAvisa;

		// Field for storing the Tareas's FechaAviso value
		private DateTime? m_FechaAviso;

		// Field for storing the Tareas's Fechadefinalización value
		private DateTime? m_Fechadefinalización;

		// Field for storing the Tareas's logFinalizada value
		private bool? m_logFinalizada;

		// Field for storing the Tareas's Notas value
		private string m_Notas;

		// Field for storing the Tareas's lngIdStatus value
		private int? m_lngIdStatus;

		// Field for storing the Tareas's lngIdTarea value
		private int m_lngIdTarea;

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
		/// Attribute for access the Tareas's strAsunto value (string)
		/// </summary>
		[DataMember]
		public string strAsunto
		{
			get { return m_strAsunto; }
			set 
			{
				m_changed=true;
				m_strAsunto = value;
			}
		}

		/// <summary>
		/// Attribute for access the Tareas's dtmFechaInicio value (DateTime)
		/// </summary>
		[DataMember]
		public DateTime? dtmFechaInicio
		{
			get { return m_dtmFechaInicio; }
			set 
			{
				m_changed=true;
				m_dtmFechaInicio = value;
			}
		}

		/// <summary>
		/// Attribute for access the Tareas's strFechavencimiento value (DateTime)
		/// </summary>
		[DataMember]
		public DateTime? strFechavencimiento
		{
			get { return m_strFechavencimiento; }
			set 
			{
				m_changed=true;
				m_strFechavencimiento = value;
			}
		}

		/// <summary>
		/// Attribute for access the Tareas's logAvisa value (bool)
		/// </summary>
		[DataMember]
		public bool? logAvisa
		{
			get { return m_logAvisa; }
			set 
			{
				m_changed=true;
				m_logAvisa = value;
			}
		}

		/// <summary>
		/// Attribute for access the Tareas's FechaAviso value (DateTime)
		/// </summary>
		[DataMember]
		public DateTime? FechaAviso
		{
			get { return m_FechaAviso; }
			set 
			{
				m_changed=true;
				m_FechaAviso = value;
			}
		}

		/// <summary>
		/// Attribute for access the Tareas's Fechadefinalización value (DateTime)
		/// </summary>
		[DataMember]
		public DateTime? Fechadefinalización
		{
			get { return m_Fechadefinalización; }
			set 
			{
				m_changed=true;
				m_Fechadefinalización = value;
			}
		}

		/// <summary>
		/// Attribute for access the Tareas's logFinalizada value (bool)
		/// </summary>
		[DataMember]
		public bool? logFinalizada
		{
			get { return m_logFinalizada; }
			set 
			{
				m_changed=true;
				m_logFinalizada = value;
			}
		}

		/// <summary>
		/// Attribute for access the Tareas's Notas value (string)
		/// </summary>
		[DataMember]
		public string Notas
		{
			get { return m_Notas; }
			set 
			{
				m_changed=true;
				m_Notas = value;
			}
		}

		/// <summary>
		/// Attribute for access the Tareas's lngIdStatus value (int)
		/// </summary>
		[DataMember]
		public int? lngIdStatus
		{
			get { return m_lngIdStatus; }
			set 
			{
				m_changed=true;
				m_lngIdStatus = value;
			}
		}

		/// <summary>
		/// Attribute for access the Tareas's lngIdTarea value (int)
		/// </summary>
		[DataMember]
		public int lngIdTarea
		{
			get { return m_lngIdTarea; }
			set 
			{
				m_changed=true;
				m_lngIdTarea = value;
			}
		}

		public object GetAttribute(string pattribute)
		{
			switch (pattribute)
			{
				case "strAsunto": return strAsunto;
				case "dtmFechaInicio": return dtmFechaInicio;
				case "strFechavencimiento": return strFechavencimiento;
				case "logAvisa": return logAvisa;
				case "FechaAviso": return FechaAviso;
				case "Fechadefinalización": return Fechadefinalización;
				case "logFinalizada": return logFinalizada;
				case "Notas": return Notas;
				case "lngIdStatus": return lngIdStatus;
				case "lngIdTarea": return lngIdTarea;
				default: return null;
			}
		}

		public Type GetAttributeType(string pattribute)
		{
			return TareasController.Instance.GetMethodType(pattribute, this);
		}

		public string GetSqlKey()
		{
			return "[lngIdTarea] = " + lngIdTarea.ToString();
		}
		#endregion

	}

	#endregion

	#region TareasList object

	/// <summary>
	/// Class for reading and access a list of Tareas object
	/// </summary>
	[CollectionDataContract]
	public partial class TareasList : List<Tareas>
	{

		/// <summary>
		/// Default constructor
		/// </summary>
		public TareasList()
		{
		}
	}

	#endregion

}
