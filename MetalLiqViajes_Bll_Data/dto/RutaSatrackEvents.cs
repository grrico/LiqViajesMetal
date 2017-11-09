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
	#region RutaSatrackEvents object

	[DataContract]
	public partial class RutaSatrackEvents : IDTOObject
	{
		/// <summary>
		/// Default constructor
		/// </summary>
		public RutaSatrackEvents()
		{
			m_Clave_Respuesta = 0;
			m_Placa = null;
			m_Descripcion = null;
			m_FechaHora_GPS = null;
			m_Velocidad = null;
			m_Direccion = null;
			m_Direccion2 = null;
			m_DivPol1 = null;
			m_DivPol2 = null;
			m_DivPol3 = null;
			m_DivPol4 = null;
			m_SentidoLetras = null;
			m_Latitud = null;
			m_Longitud = null;
			m_TipoEventoUnificado = null;
			m_CodigoNombre = null;
			m_changed=false;
		}
		        //Return the table name of object
		        public string TableName()
		        {
		            return "RutaSatrackEvents";
		        }
		#region Undo 
		// Internal class for storing changes
		private RutaSatrackEvents m_oldRutaSatrackEvents;
		public void GenerateUndo()
		{
			m_oldRutaSatrackEvents=new RutaSatrackEvents();
			m_oldRutaSatrackEvents.m_Clave_Respuesta = m_Clave_Respuesta;
			m_oldRutaSatrackEvents.Placa = m_Placa;
			m_oldRutaSatrackEvents.Descripcion = m_Descripcion;
			m_oldRutaSatrackEvents.FechaHora_GPS = m_FechaHora_GPS;
			m_oldRutaSatrackEvents.Velocidad = m_Velocidad;
			m_oldRutaSatrackEvents.Direccion = m_Direccion;
			m_oldRutaSatrackEvents.Direccion2 = m_Direccion2;
			m_oldRutaSatrackEvents.DivPol1 = m_DivPol1;
			m_oldRutaSatrackEvents.DivPol2 = m_DivPol2;
			m_oldRutaSatrackEvents.DivPol3 = m_DivPol3;
			m_oldRutaSatrackEvents.DivPol4 = m_DivPol4;
			m_oldRutaSatrackEvents.SentidoLetras = m_SentidoLetras;
			m_oldRutaSatrackEvents.Latitud = m_Latitud;
			m_oldRutaSatrackEvents.Longitud = m_Longitud;
			m_oldRutaSatrackEvents.TipoEventoUnificado = m_TipoEventoUnificado;
			m_oldRutaSatrackEvents.CodigoNombre = m_CodigoNombre;
		}

		public RutaSatrackEvents OldRutaSatrackEvents
		{
			get { return m_oldRutaSatrackEvents;}
		}
		// Return the changed fields
		public string[] FieldChanged()
		{
			List<string> fields=new List<string>();
			if (m_oldRutaSatrackEvents.Placa != m_Placa) fields.Add("Placa");
			if (m_oldRutaSatrackEvents.Descripcion != m_Descripcion) fields.Add("Descripcion");
			if (m_oldRutaSatrackEvents.FechaHora_GPS != m_FechaHora_GPS) fields.Add("FechaHora_GPS");
			if (m_oldRutaSatrackEvents.Velocidad != m_Velocidad) fields.Add("Velocidad");
			if (m_oldRutaSatrackEvents.Direccion != m_Direccion) fields.Add("Direccion");
			if (m_oldRutaSatrackEvents.Direccion2 != m_Direccion2) fields.Add("Direccion2");
			if (m_oldRutaSatrackEvents.DivPol1 != m_DivPol1) fields.Add("DivPol1");
			if (m_oldRutaSatrackEvents.DivPol2 != m_DivPol2) fields.Add("DivPol2");
			if (m_oldRutaSatrackEvents.DivPol3 != m_DivPol3) fields.Add("DivPol3");
			if (m_oldRutaSatrackEvents.DivPol4 != m_DivPol4) fields.Add("DivPol4");
			if (m_oldRutaSatrackEvents.SentidoLetras != m_SentidoLetras) fields.Add("SentidoLetras");
			if (m_oldRutaSatrackEvents.Latitud != m_Latitud) fields.Add("Latitud");
			if (m_oldRutaSatrackEvents.Longitud != m_Longitud) fields.Add("Longitud");
			if (m_oldRutaSatrackEvents.TipoEventoUnificado != m_TipoEventoUnificado) fields.Add("TipoEventoUnificado");
			if (m_oldRutaSatrackEvents.CodigoNombre != m_CodigoNombre) fields.Add("CodigoNombre");
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


		// Field for storing the RutaSatrackEvents's Clave_Respuesta value
		private long m_Clave_Respuesta;

		// Field for storing the RutaSatrackEvents's Placa value
		private string m_Placa;

		// Field for storing the RutaSatrackEvents's Descripcion value
		private string m_Descripcion;

		// Field for storing the RutaSatrackEvents's FechaHora_GPS value
		private DateTime? m_FechaHora_GPS;

		// Field for storing the RutaSatrackEvents's Velocidad value
		private int? m_Velocidad;

		// Field for storing the RutaSatrackEvents's Direccion value
		private string m_Direccion;

		// Field for storing the RutaSatrackEvents's Direccion2 value
		private string m_Direccion2;

		// Field for storing the RutaSatrackEvents's DivPol1 value
		private string m_DivPol1;

		// Field for storing the RutaSatrackEvents's DivPol2 value
		private string m_DivPol2;

		// Field for storing the RutaSatrackEvents's DivPol3 value
		private string m_DivPol3;

		// Field for storing the RutaSatrackEvents's DivPol4 value
		private string m_DivPol4;

		// Field for storing the RutaSatrackEvents's SentidoLetras value
		private string m_SentidoLetras;

		// Field for storing the RutaSatrackEvents's Latitud value
		private decimal? m_Latitud;

		// Field for storing the RutaSatrackEvents's Longitud value
		private decimal? m_Longitud;

		// Field for storing the RutaSatrackEvents's TipoEventoUnificado value
		private int? m_TipoEventoUnificado;

		// Field for storing the RutaSatrackEvents's CodigoNombre value
		private string m_CodigoNombre;

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
		/// Attribute for access the RutaSatrackEvents's Clave_Respuesta value (long)
		/// </summary>
		[DataMember]
		public long Clave_Respuesta
		{
			get { return m_Clave_Respuesta; }
			set 
			{
				m_changed=true;
				m_Clave_Respuesta = value;
			}
		}

		/// <summary>
		/// Attribute for access the RutaSatrackEvents's Placa value (string)
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
		/// Attribute for access the RutaSatrackEvents's Descripcion value (string)
		/// </summary>
		[DataMember]
		public string Descripcion
		{
			get { return m_Descripcion; }
			set 
			{
				m_changed=true;
				m_Descripcion = value;
			}
		}

		/// <summary>
		/// Attribute for access the RutaSatrackEvents's FechaHora_GPS value (DateTime)
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
		/// Attribute for access the RutaSatrackEvents's Velocidad value (int)
		/// </summary>
		[DataMember]
		public int? Velocidad
		{
			get { return m_Velocidad; }
			set 
			{
				m_changed=true;
				m_Velocidad = value;
			}
		}

		/// <summary>
		/// Attribute for access the RutaSatrackEvents's Direccion value (string)
		/// </summary>
		[DataMember]
		public string Direccion
		{
			get { return m_Direccion; }
			set 
			{
				m_changed=true;
				m_Direccion = value;
			}
		}

		/// <summary>
		/// Attribute for access the RutaSatrackEvents's Direccion2 value (string)
		/// </summary>
		[DataMember]
		public string Direccion2
		{
			get { return m_Direccion2; }
			set 
			{
				m_changed=true;
				m_Direccion2 = value;
			}
		}

		/// <summary>
		/// Attribute for access the RutaSatrackEvents's DivPol1 value (string)
		/// </summary>
		[DataMember]
		public string DivPol1
		{
			get { return m_DivPol1; }
			set 
			{
				m_changed=true;
				m_DivPol1 = value;
			}
		}

		/// <summary>
		/// Attribute for access the RutaSatrackEvents's DivPol2 value (string)
		/// </summary>
		[DataMember]
		public string DivPol2
		{
			get { return m_DivPol2; }
			set 
			{
				m_changed=true;
				m_DivPol2 = value;
			}
		}

		/// <summary>
		/// Attribute for access the RutaSatrackEvents's DivPol3 value (string)
		/// </summary>
		[DataMember]
		public string DivPol3
		{
			get { return m_DivPol3; }
			set 
			{
				m_changed=true;
				m_DivPol3 = value;
			}
		}

		/// <summary>
		/// Attribute for access the RutaSatrackEvents's DivPol4 value (string)
		/// </summary>
		[DataMember]
		public string DivPol4
		{
			get { return m_DivPol4; }
			set 
			{
				m_changed=true;
				m_DivPol4 = value;
			}
		}

		/// <summary>
		/// Attribute for access the RutaSatrackEvents's SentidoLetras value (string)
		/// </summary>
		[DataMember]
		public string SentidoLetras
		{
			get { return m_SentidoLetras; }
			set 
			{
				m_changed=true;
				m_SentidoLetras = value;
			}
		}

		/// <summary>
		/// Attribute for access the RutaSatrackEvents's Latitud value (decimal)
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
		/// Attribute for access the RutaSatrackEvents's Longitud value (decimal)
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

		/// <summary>
		/// Attribute for access the RutaSatrackEvents's TipoEventoUnificado value (int)
		/// </summary>
		[DataMember]
		public int? TipoEventoUnificado
		{
			get { return m_TipoEventoUnificado; }
			set 
			{
				m_changed=true;
				m_TipoEventoUnificado = value;
			}
		}

		/// <summary>
		/// Attribute for access the RutaSatrackEvents's CodigoNombre value (string)
		/// </summary>
		[DataMember]
		public string CodigoNombre
		{
			get { return m_CodigoNombre; }
			set 
			{
				m_changed=true;
				m_CodigoNombre = value;
			}
		}

		public object GetAttribute(string pattribute)
		{
			switch (pattribute)
			{
				case "Clave_Respuesta": return Clave_Respuesta;
				case "Placa": return Placa;
				case "Descripcion": return Descripcion;
				case "FechaHora_GPS": return FechaHora_GPS;
				case "Velocidad": return Velocidad;
				case "Direccion": return Direccion;
				case "Direccion2": return Direccion2;
				case "DivPol1": return DivPol1;
				case "DivPol2": return DivPol2;
				case "DivPol3": return DivPol3;
				case "DivPol4": return DivPol4;
				case "SentidoLetras": return SentidoLetras;
				case "Latitud": return Latitud;
				case "Longitud": return Longitud;
				case "TipoEventoUnificado": return TipoEventoUnificado;
				case "CodigoNombre": return CodigoNombre;
				default: return null;
			}
		}

		public Type GetAttributeType(string pattribute)
		{
			return RutaSatrackEventsController.Instance.GetMethodType(pattribute, this);
		}

		public string GetSqlKey()
		{
			return "[Clave_Respuesta] = " + Clave_Respuesta.ToString();
		}
		#endregion

	}

	#endregion

	#region RutaSatrackEventsList object

	/// <summary>
	/// Class for reading and access a list of RutaSatrackEvents object
	/// </summary>
	[CollectionDataContract]
	public partial class RutaSatrackEventsList : List<RutaSatrackEvents>
	{

		/// <summary>
		/// Default constructor
		/// </summary>
		public RutaSatrackEventsList()
		{
		}
	}

	#endregion

}
