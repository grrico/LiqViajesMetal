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
	#region TramosMovViajes object

	[DataContract]
	public partial class TramosMovViajes : IDTOObject
	{
		/// <summary>
		/// Default constructor
		/// </summary>
		public TramosMovViajes()
		{
			m_Codigo = 0;
			m_IdRegistro = null;
			m_Cedula = null;
			m_NombreConductor = null;
			m_Cuenta = null;
			m_DescripcionCuenta = null;
			m_ValorTotal = null;
			m_Fecha = null;
			m_DescripcionPeaje = null;
			m_changed=false;
		}
		        //Return the table name of object
		        public string TableName()
		        {
		            return "TramosMovViajes";
		        }
		#region Undo 
		// Internal class for storing changes
		private TramosMovViajes m_oldTramosMovViajes;
		public void GenerateUndo()
		{
			m_oldTramosMovViajes=new TramosMovViajes();
			m_oldTramosMovViajes.m_Codigo = m_Codigo;
			m_oldTramosMovViajes.IdRegistro = m_IdRegistro;
			m_oldTramosMovViajes.Cedula = m_Cedula;
			m_oldTramosMovViajes.NombreConductor = m_NombreConductor;
			m_oldTramosMovViajes.Cuenta = m_Cuenta;
			m_oldTramosMovViajes.DescripcionCuenta = m_DescripcionCuenta;
			m_oldTramosMovViajes.ValorTotal = m_ValorTotal;
			m_oldTramosMovViajes.Fecha = m_Fecha;
			m_oldTramosMovViajes.DescripcionPeaje = m_DescripcionPeaje;
		}

		public TramosMovViajes OldTramosMovViajes
		{
			get { return m_oldTramosMovViajes;}
		}
		// Return the changed fields
		public string[] FieldChanged()
		{
			List<string> fields=new List<string>();
			if (m_oldTramosMovViajes.IdRegistro != m_IdRegistro) fields.Add("IdRegistro");
			if (m_oldTramosMovViajes.Cedula != m_Cedula) fields.Add("Cedula");
			if (m_oldTramosMovViajes.NombreConductor != m_NombreConductor) fields.Add("NombreConductor");
			if (m_oldTramosMovViajes.Cuenta != m_Cuenta) fields.Add("Cuenta");
			if (m_oldTramosMovViajes.DescripcionCuenta != m_DescripcionCuenta) fields.Add("DescripcionCuenta");
			if (m_oldTramosMovViajes.ValorTotal != m_ValorTotal) fields.Add("ValorTotal");
			if (m_oldTramosMovViajes.Fecha != m_Fecha) fields.Add("Fecha");
			if (m_oldTramosMovViajes.DescripcionPeaje != m_DescripcionPeaje) fields.Add("DescripcionPeaje");
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


		// Field for storing the TramosMovViajes's IdRegistro value
		private long? m_IdRegistro;

		// Field for storing the TramosMovViajes's Cedula value
		private string m_Cedula;

		// Field for storing the TramosMovViajes's NombreConductor value
		private string m_NombreConductor;

		// Field for storing the TramosMovViajes's Cuenta value
		private string m_Cuenta;

		// Field for storing the TramosMovViajes's DescripcionCuenta value
		private string m_DescripcionCuenta;

		// Field for storing the TramosMovViajes's ValorTotal value
		private decimal? m_ValorTotal;

		// Field for storing the TramosMovViajes's Fecha value
		private DateTime? m_Fecha;

		// Field for storing the TramosMovViajes's DescripcionPeaje value
		private string m_DescripcionPeaje;

		// Field for storing the TramosMovViajes's Codigo value
		private long m_Codigo;

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
		/// Attribute for access the TramosMovViajes's IdRegistro value (long)
		/// </summary>
		[DataMember]
		public long? IdRegistro
		{
			get { return m_IdRegistro; }
			set 
			{
				m_changed=true;
				m_IdRegistro = value;
			}
		}

		/// <summary>
		/// Attribute for access the TramosMovViajes's Cedula value (string)
		/// </summary>
		[DataMember]
		public string Cedula
		{
			get { return m_Cedula; }
			set 
			{
				m_changed=true;
				m_Cedula = value;
			}
		}

		/// <summary>
		/// Attribute for access the TramosMovViajes's NombreConductor value (string)
		/// </summary>
		[DataMember]
		public string NombreConductor
		{
			get { return m_NombreConductor; }
			set 
			{
				m_changed=true;
				m_NombreConductor = value;
			}
		}

		/// <summary>
		/// Attribute for access the TramosMovViajes's Cuenta value (string)
		/// </summary>
		[DataMember]
		public string Cuenta
		{
			get { return m_Cuenta; }
			set 
			{
				m_changed=true;
				m_Cuenta = value;
			}
		}

		/// <summary>
		/// Attribute for access the TramosMovViajes's DescripcionCuenta value (string)
		/// </summary>
		[DataMember]
		public string DescripcionCuenta
		{
			get { return m_DescripcionCuenta; }
			set 
			{
				m_changed=true;
				m_DescripcionCuenta = value;
			}
		}

		/// <summary>
		/// Attribute for access the TramosMovViajes's ValorTotal value (decimal)
		/// </summary>
		[DataMember]
		public decimal? ValorTotal
		{
			get { return m_ValorTotal; }
			set 
			{
				m_changed=true;
				m_ValorTotal = value;
			}
		}

		/// <summary>
		/// Attribute for access the TramosMovViajes's Fecha value (DateTime)
		/// </summary>
		[DataMember]
		public DateTime? Fecha
		{
			get { return m_Fecha; }
			set 
			{
				m_changed=true;
				m_Fecha = value;
			}
		}

		/// <summary>
		/// Attribute for access the TramosMovViajes's DescripcionPeaje value (string)
		/// </summary>
		[DataMember]
		public string DescripcionPeaje
		{
			get { return m_DescripcionPeaje; }
			set 
			{
				m_changed=true;
				m_DescripcionPeaje = value;
			}
		}

		/// <summary>
		/// Attribute for access the TramosMovViajes's Codigo value (long)
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

		public object GetAttribute(string pattribute)
		{
			switch (pattribute)
			{
				case "IdRegistro": return IdRegistro;
				case "Cedula": return Cedula;
				case "NombreConductor": return NombreConductor;
				case "Cuenta": return Cuenta;
				case "DescripcionCuenta": return DescripcionCuenta;
				case "ValorTotal": return ValorTotal;
				case "Fecha": return Fecha;
				case "DescripcionPeaje": return DescripcionPeaje;
				case "Codigo": return Codigo;
				default: return null;
			}
		}

		public Type GetAttributeType(string pattribute)
		{
			return TramosMovViajesController.Instance.GetMethodType(pattribute, this);
		}

		public string GetSqlKey()
		{
			return "[Codigo] = " + Codigo.ToString();
		}
		#endregion

	}

	#endregion

	#region TramosMovViajesList object

	/// <summary>
	/// Class for reading and access a list of TramosMovViajes object
	/// </summary>
	[CollectionDataContract]
	public partial class TramosMovViajesList : List<TramosMovViajes>
	{

		/// <summary>
		/// Default constructor
		/// </summary>
		public TramosMovViajesList()
		{
		}
	}

	#endregion

}
