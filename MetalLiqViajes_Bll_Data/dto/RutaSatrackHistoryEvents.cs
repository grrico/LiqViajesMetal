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
	#region RutaSatrackHistoryEvents object

	[DataContract]
	public partial class RutaSatrackHistoryEvents : IDTOObject
	{
		/// <summary>
		/// Default constructor
		/// </summary>
		public RutaSatrackHistoryEvents()
		{
			m_Codigo = 0;
			m_Placa = null;
			m_FechaSistema = null;
			m_FechaHora_GPS = null;
			m_EventoPrioridad = null;
			m_VelocidadSentido = null;
			m_Edad_Posicion = null;
			m_Ubicacion = null;
			m_Latitud = null;
			m_Longitud = null;
			m_changed=false;
		}
		        //Return the table name of object
		        public string TableName()
		        {
		            return "RutaSatrackHistoryEvents";
		        }
		#region Undo 
		// Internal class for storing changes
		private RutaSatrackHistoryEvents m_oldRutaSatrackHistoryEvents;
		public void GenerateUndo()
		{
			m_oldRutaSatrackHistoryEvents=new RutaSatrackHistoryEvents();
			m_oldRutaSatrackHistoryEvents.m_Codigo = m_Codigo;
			m_oldRutaSatrackHistoryEvents.Placa = m_Placa;
			m_oldRutaSatrackHistoryEvents.FechaSistema = m_FechaSistema;
			m_oldRutaSatrackHistoryEvents.FechaHora_GPS = m_FechaHora_GPS;
			m_oldRutaSatrackHistoryEvents.EventoPrioridad = m_EventoPrioridad;
			m_oldRutaSatrackHistoryEvents.VelocidadSentido = m_VelocidadSentido;
			m_oldRutaSatrackHistoryEvents.Edad_Posicion = m_Edad_Posicion;
			m_oldRutaSatrackHistoryEvents.Ubicacion = m_Ubicacion;
			m_oldRutaSatrackHistoryEvents.Latitud = m_Latitud;
			m_oldRutaSatrackHistoryEvents.Longitud = m_Longitud;
		}

		public RutaSatrackHistoryEvents OldRutaSatrackHistoryEvents
		{
			get { return m_oldRutaSatrackHistoryEvents;}
		}
		// Return the changed fields
		public string[] FieldChanged()
		{
			List<string> fields=new List<string>();
			if (m_oldRutaSatrackHistoryEvents.Placa != m_Placa) fields.Add("Placa");
			if (m_oldRutaSatrackHistoryEvents.FechaSistema != m_FechaSistema) fields.Add("FechaSistema");
			if (m_oldRutaSatrackHistoryEvents.FechaHora_GPS != m_FechaHora_GPS) fields.Add("FechaHora_GPS");
			if (m_oldRutaSatrackHistoryEvents.EventoPrioridad != m_EventoPrioridad) fields.Add("EventoPrioridad");
			if (m_oldRutaSatrackHistoryEvents.VelocidadSentido != m_VelocidadSentido) fields.Add("VelocidadSentido");
			if (m_oldRutaSatrackHistoryEvents.Edad_Posicion != m_Edad_Posicion) fields.Add("Edad_Posicion");
			if (m_oldRutaSatrackHistoryEvents.Ubicacion != m_Ubicacion) fields.Add("Ubicacion");
			if (m_oldRutaSatrackHistoryEvents.Latitud != m_Latitud) fields.Add("Latitud");
			if (m_oldRutaSatrackHistoryEvents.Longitud != m_Longitud) fields.Add("Longitud");
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


		// Field for storing the RutaSatrackHistoryEvents's Codigo value
		private long m_Codigo;

		// Field for storing the RutaSatrackHistoryEvents's Placa value
		private string m_Placa;

		// Field for storing the RutaSatrackHistoryEvents's FechaSistema value
		private DateTime? m_FechaSistema;

		// Field for storing the RutaSatrackHistoryEvents's FechaHora_GPS value
		private DateTime? m_FechaHora_GPS;

		// Field for storing the RutaSatrackHistoryEvents's EventoPrioridad value
		private string m_EventoPrioridad;

		// Field for storing the RutaSatrackHistoryEvents's VelocidadSentido value
		private string m_VelocidadSentido;

		// Field for storing the RutaSatrackHistoryEvents's Edad_Posicion value
		private string m_Edad_Posicion;

		// Field for storing the RutaSatrackHistoryEvents's Ubicacion value
		private string m_Ubicacion;

		// Field for storing the RutaSatrackHistoryEvents's Latitud value
		private decimal? m_Latitud;

		// Field for storing the RutaSatrackHistoryEvents's Longitud value
		private decimal? m_Longitud;

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
		/// Attribute for access the RutaSatrackHistoryEvents's Codigo value (long)
		/// </summary>
		[DataMember]
		public long Codigo
		{
			get { return m_Codigo; }
			set 
			{
				m_changed=true;
				m_Codigo = value;
			}
		}

		/// <summary>
		/// Attribute for access the RutaSatrackHistoryEvents's Placa value (string)
		/// </summary>
		[DataMember]
		public string Placa
		{
			get { return m_Placa; }
			set 
			{
				m_changed=true;
				m_Placa = value;
			}
		}

		/// <summary>
		/// Attribute for access the RutaSatrackHistoryEvents's FechaSistema value (DateTime)
		/// </summary>
		[DataMember]
		public DateTime? FechaSistema
		{
			get { return m_FechaSistema; }
			set 
			{
				m_changed=true;
				m_FechaSistema = value;
			}
		}

		/// <summary>
		/// Attribute for access the RutaSatrackHistoryEvents's FechaHora_GPS value (DateTime)
		/// </summary>
		[DataMember]
		public DateTime? FechaHora_GPS
		{
			get { return m_FechaHora_GPS; }
			set 
			{
				m_changed=true;
				m_FechaHora_GPS = value;
			}
		}

		/// <summary>
		/// Attribute for access the RutaSatrackHistoryEvents's EventoPrioridad value (string)
		/// </summary>
		[DataMember]
		public string EventoPrioridad
		{
			get { return m_EventoPrioridad; }
			set 
			{
				m_changed=true;
				m_EventoPrioridad = value;
			}
		}

		/// <summary>
		/// Attribute for access the RutaSatrackHistoryEvents's VelocidadSentido value (string)
		/// </summary>
		[DataMember]
		public string VelocidadSentido
		{
			get { return m_VelocidadSentido; }
			set 
			{
				m_changed=true;
				m_VelocidadSentido = value;
			}
		}

		/// <summary>
		/// Attribute for access the RutaSatrackHistoryEvents's Edad_Posicion value (string)
		/// </summary>
		[DataMember]
		public string Edad_Posicion
		{
			get { return m_Edad_Posicion; }
			set 
			{
				m_changed=true;
				m_Edad_Posicion = value;
			}
		}

		/// <summary>
		/// Attribute for access the RutaSatrackHistoryEvents's Ubicacion value (string)
		/// </summary>
		[DataMember]
		public string Ubicacion
		{
			get { return m_Ubicacion; }
			set 
			{
				m_changed=true;
				m_Ubicacion = value;
			}
		}

		/// <summary>
		/// Attribute for access the RutaSatrackHistoryEvents's Latitud value (decimal)
		/// </summary>
		[DataMember]
		public decimal? Latitud
		{
			get { return m_Latitud; }
			set 
			{
				m_changed=true;
				m_Latitud = value;
			}
		}

		/// <summary>
		/// Attribute for access the RutaSatrackHistoryEvents's Longitud value (decimal)
		/// </summary>
		[DataMember]
		public decimal? Longitud
		{
			get { return m_Longitud; }
			set 
			{
				m_changed=true;
				m_Longitud = value;
			}
		}

		public object GetAttribute(string pattribute)
		{
			switch (pattribute)
			{
				case "Codigo": return Codigo;
				case "Placa": return Placa;
				case "FechaSistema": return FechaSistema;
				case "FechaHora_GPS": return FechaHora_GPS;
				case "EventoPrioridad": return EventoPrioridad;
				case "VelocidadSentido": return VelocidadSentido;
				case "Edad_Posicion": return Edad_Posicion;
				case "Ubicacion": return Ubicacion;
				case "Latitud": return Latitud;
				case "Longitud": return Longitud;
				default: return null;
			}
		}

		public Type GetAttributeType(string pattribute)
		{
			return RutaSatrackHistoryEventsController.Instance.GetMethodType(pattribute, this);
		}

		public string GetSqlKey()
		{
			return "[Codigo] = " + Codigo.ToString();
		}
		#endregion

	}

	#endregion

	#region RutaSatrackHistoryEventsList object

	/// <summary>
	/// Class for reading and access a list of RutaSatrackHistoryEvents object
	/// </summary>
	[CollectionDataContract]
	public partial class RutaSatrackHistoryEventsList : List<RutaSatrackHistoryEvents>
	{

		/// <summary>
		/// Default constructor
		/// </summary>
		public RutaSatrackHistoryEventsList()
		{
		}
	}

	#endregion

}
