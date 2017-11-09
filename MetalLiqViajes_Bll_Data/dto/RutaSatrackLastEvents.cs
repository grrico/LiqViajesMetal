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
	#region RutaSatrackLastEvents object

	[DataContract]
	public partial class RutaSatrackLastEvents : IDTOObject
	{
		/// <summary>
		/// Default constructor
		/// </summary>
		public RutaSatrackLastEvents()
		{
			m_Placa = "";
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
		            return "RutaSatrackLastEvents";
		        }
		#region Undo 
		// Internal class for storing changes
		private RutaSatrackLastEvents m_oldRutaSatrackLastEvents;
		public void GenerateUndo()
		{
			m_oldRutaSatrackLastEvents=new RutaSatrackLastEvents();
			m_oldRutaSatrackLastEvents.m_Placa = m_Placa;
			m_oldRutaSatrackLastEvents.FechaSistema = m_FechaSistema;
			m_oldRutaSatrackLastEvents.FechaHora_GPS = m_FechaHora_GPS;
			m_oldRutaSatrackLastEvents.EventoPrioridad = m_EventoPrioridad;
			m_oldRutaSatrackLastEvents.VelocidadSentido = m_VelocidadSentido;
			m_oldRutaSatrackLastEvents.Edad_Posicion = m_Edad_Posicion;
			m_oldRutaSatrackLastEvents.Ubicacion = m_Ubicacion;
			m_oldRutaSatrackLastEvents.Latitud = m_Latitud;
			m_oldRutaSatrackLastEvents.Longitud = m_Longitud;
		}

		public RutaSatrackLastEvents OldRutaSatrackLastEvents
		{
			get { return m_oldRutaSatrackLastEvents;}
		}
		// Return the changed fields
		public string[] FieldChanged()
		{
			List<string> fields=new List<string>();
			if (m_oldRutaSatrackLastEvents.FechaSistema != m_FechaSistema) fields.Add("FechaSistema");
			if (m_oldRutaSatrackLastEvents.FechaHora_GPS != m_FechaHora_GPS) fields.Add("FechaHora_GPS");
			if (m_oldRutaSatrackLastEvents.EventoPrioridad != m_EventoPrioridad) fields.Add("EventoPrioridad");
			if (m_oldRutaSatrackLastEvents.VelocidadSentido != m_VelocidadSentido) fields.Add("VelocidadSentido");
			if (m_oldRutaSatrackLastEvents.Edad_Posicion != m_Edad_Posicion) fields.Add("Edad_Posicion");
			if (m_oldRutaSatrackLastEvents.Ubicacion != m_Ubicacion) fields.Add("Ubicacion");
			if (m_oldRutaSatrackLastEvents.Latitud != m_Latitud) fields.Add("Latitud");
			if (m_oldRutaSatrackLastEvents.Longitud != m_Longitud) fields.Add("Longitud");
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


		// Field for storing the RutaSatrackLastEvents's Placa value
		private string m_Placa;

		// Field for storing the RutaSatrackLastEvents's FechaSistema value
		private DateTime? m_FechaSistema;

		// Field for storing the RutaSatrackLastEvents's FechaHora_GPS value
		private DateTime? m_FechaHora_GPS;

		// Field for storing the RutaSatrackLastEvents's EventoPrioridad value
		private string m_EventoPrioridad;

		// Field for storing the RutaSatrackLastEvents's VelocidadSentido value
		private string m_VelocidadSentido;

		// Field for storing the RutaSatrackLastEvents's Edad_Posicion value
		private string m_Edad_Posicion;

		// Field for storing the RutaSatrackLastEvents's Ubicacion value
		private string m_Ubicacion;

		// Field for storing the RutaSatrackLastEvents's Latitud value
		private decimal? m_Latitud;

		// Field for storing the RutaSatrackLastEvents's Longitud value
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
		/// Attribute for access the RutaSatrackLastEvents's Placa value (string)
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
		/// Attribute for access the RutaSatrackLastEvents's FechaSistema value (DateTime)
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
		/// Attribute for access the RutaSatrackLastEvents's FechaHora_GPS value (DateTime)
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
		/// Attribute for access the RutaSatrackLastEvents's EventoPrioridad value (string)
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
		/// Attribute for access the RutaSatrackLastEvents's VelocidadSentido value (string)
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
		/// Attribute for access the RutaSatrackLastEvents's Edad_Posicion value (string)
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
		/// Attribute for access the RutaSatrackLastEvents's Ubicacion value (string)
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
		/// Attribute for access the RutaSatrackLastEvents's Latitud value (decimal)
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
		/// Attribute for access the RutaSatrackLastEvents's Longitud value (decimal)
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
			return RutaSatrackLastEventsController.Instance.GetMethodType(pattribute, this);
		}

		public string GetSqlKey()
		{
			return "[Placa] = '" + Placa.ToString()+ "'";
		}
		#endregion

	}

	#endregion

	#region RutaSatrackLastEventsList object

	/// <summary>
	/// Class for reading and access a list of RutaSatrackLastEvents object
	/// </summary>
	[CollectionDataContract]
	public partial class RutaSatrackLastEventsList : List<RutaSatrackLastEvents>
	{

		/// <summary>
		/// Default constructor
		/// </summary>
		public RutaSatrackLastEventsList()
		{
		}
	}

	#endregion

}
