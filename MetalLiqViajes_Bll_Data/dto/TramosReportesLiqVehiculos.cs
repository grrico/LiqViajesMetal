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
	#region TramosReportesLiqVehiculos object

	[DataContract]
	public partial class TramosReportesLiqVehiculos : IDTOObject
	{
		/// <summary>
		/// Default constructor
		/// </summary>
		public TramosReportesLiqVehiculos()
		{
			m_Registro = 0;
			m_Fecha = null;
			m_Centro = null;
			m_Marca = null;
			m_Placa = null;
			m_Modelo = null;
			m_CedulaConductor = null;
			m_NombreConductor = null;
			m_TotalGatos = null;
			m_TotalAnticipos = null;
			m_TotalGeneral = null;
			m_changed=false;
		}
		        //Return the table name of object
		        public string TableName()
		        {
		            return "TramosReportesLiqVehiculos";
		        }
		#region Undo 
		// Internal class for storing changes
		private TramosReportesLiqVehiculos m_oldTramosReportesLiqVehiculos;
		public void GenerateUndo()
		{
			m_oldTramosReportesLiqVehiculos=new TramosReportesLiqVehiculos();
			m_oldTramosReportesLiqVehiculos.m_Registro = m_Registro;
			m_oldTramosReportesLiqVehiculos.Fecha = m_Fecha;
			m_oldTramosReportesLiqVehiculos.Centro = m_Centro;
			m_oldTramosReportesLiqVehiculos.Marca = m_Marca;
			m_oldTramosReportesLiqVehiculos.Placa = m_Placa;
			m_oldTramosReportesLiqVehiculos.Modelo = m_Modelo;
			m_oldTramosReportesLiqVehiculos.CedulaConductor = m_CedulaConductor;
			m_oldTramosReportesLiqVehiculos.NombreConductor = m_NombreConductor;
			m_oldTramosReportesLiqVehiculos.TotalGatos = m_TotalGatos;
			m_oldTramosReportesLiqVehiculos.TotalAnticipos = m_TotalAnticipos;
			m_oldTramosReportesLiqVehiculos.TotalGeneral = m_TotalGeneral;
		}

		public TramosReportesLiqVehiculos OldTramosReportesLiqVehiculos
		{
			get { return m_oldTramosReportesLiqVehiculos;}
		}
		// Return the changed fields
		public string[] FieldChanged()
		{
			List<string> fields=new List<string>();
			if (m_oldTramosReportesLiqVehiculos.Fecha != m_Fecha) fields.Add("Fecha");
			if (m_oldTramosReportesLiqVehiculos.Centro != m_Centro) fields.Add("Centro");
			if (m_oldTramosReportesLiqVehiculos.Marca != m_Marca) fields.Add("Marca");
			if (m_oldTramosReportesLiqVehiculos.Placa != m_Placa) fields.Add("Placa");
			if (m_oldTramosReportesLiqVehiculos.Modelo != m_Modelo) fields.Add("Modelo");
			if (m_oldTramosReportesLiqVehiculos.CedulaConductor != m_CedulaConductor) fields.Add("CedulaConductor");
			if (m_oldTramosReportesLiqVehiculos.NombreConductor != m_NombreConductor) fields.Add("NombreConductor");
			if (m_oldTramosReportesLiqVehiculos.TotalGatos != m_TotalGatos) fields.Add("TotalGatos");
			if (m_oldTramosReportesLiqVehiculos.TotalAnticipos != m_TotalAnticipos) fields.Add("TotalAnticipos");
			if (m_oldTramosReportesLiqVehiculos.TotalGeneral != m_TotalGeneral) fields.Add("TotalGeneral");
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


		// Field for storing the TramosReportesLiqVehiculos's Fecha value
		private DateTime? m_Fecha;

		// Field for storing the TramosReportesLiqVehiculos's Centro value
		private double? m_Centro;

		// Field for storing the TramosReportesLiqVehiculos's Marca value
		private string m_Marca;

		// Field for storing the TramosReportesLiqVehiculos's Placa value
		private string m_Placa;

		// Field for storing the TramosReportesLiqVehiculos's Modelo value
		private double? m_Modelo;

		// Field for storing the TramosReportesLiqVehiculos's CedulaConductor value
		private string m_CedulaConductor;

		// Field for storing the TramosReportesLiqVehiculos's NombreConductor value
		private string m_NombreConductor;

		// Field for storing the TramosReportesLiqVehiculos's TotalGatos value
		private decimal? m_TotalGatos;

		// Field for storing the TramosReportesLiqVehiculos's TotalAnticipos value
		private decimal? m_TotalAnticipos;

		// Field for storing the TramosReportesLiqVehiculos's TotalGeneral value
		private decimal? m_TotalGeneral;

		// Field for storing the TramosReportesLiqVehiculos's Registro value
		private long m_Registro;

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
		/// Attribute for access the TramosReportesLiqVehiculos's Fecha value (DateTime)
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
		/// Attribute for access the TramosReportesLiqVehiculos's Centro value (double)
		/// </summary>
		[DataMember]
		public double? Centro
		{
			get { return m_Centro; }
			set 
			{
				m_changed=true;
				m_Centro = value;
			}
		}

		/// <summary>
		/// Attribute for access the TramosReportesLiqVehiculos's Marca value (string)
		/// </summary>
		[DataMember]
		public string Marca
		{
			get { return m_Marca; }
			set 
			{
				m_changed=true;
				m_Marca = value;
			}
		}

		/// <summary>
		/// Attribute for access the TramosReportesLiqVehiculos's Placa value (string)
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
		/// Attribute for access the TramosReportesLiqVehiculos's Modelo value (double)
		/// </summary>
		[DataMember]
		public double? Modelo
		{
			get { return m_Modelo; }
			set 
			{
				m_changed=true;
				m_Modelo = value;
			}
		}

		/// <summary>
		/// Attribute for access the TramosReportesLiqVehiculos's CedulaConductor value (string)
		/// </summary>
		[DataMember]
		public string CedulaConductor
		{
			get { return m_CedulaConductor; }
			set 
			{
				m_changed=true;
				m_CedulaConductor = value;
			}
		}

		/// <summary>
		/// Attribute for access the TramosReportesLiqVehiculos's NombreConductor value (string)
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
		/// Attribute for access the TramosReportesLiqVehiculos's TotalGatos value (decimal)
		/// </summary>
		[DataMember]
		public decimal? TotalGatos
		{
			get { return m_TotalGatos; }
			set 
			{
				m_changed=true;
				m_TotalGatos = value;
			}
		}

		/// <summary>
		/// Attribute for access the TramosReportesLiqVehiculos's TotalAnticipos value (decimal)
		/// </summary>
		[DataMember]
		public decimal? TotalAnticipos
		{
			get { return m_TotalAnticipos; }
			set 
			{
				m_changed=true;
				m_TotalAnticipos = value;
			}
		}

		/// <summary>
		/// Attribute for access the TramosReportesLiqVehiculos's TotalGeneral value (decimal)
		/// </summary>
		[DataMember]
		public decimal? TotalGeneral
		{
			get { return m_TotalGeneral; }
			set 
			{
				m_changed=true;
				m_TotalGeneral = value;
			}
		}

		/// <summary>
		/// Attribute for access the TramosReportesLiqVehiculos's Registro value (long)
		/// </summary>
		[DataMember]
		public long Registro
		{
			get { return m_Registro; }
			set 
			{
				m_changed=true;
				m_Registro = value;
			}
		}

		public object GetAttribute(string pattribute)
		{
			switch (pattribute)
			{
				case "Fecha": return Fecha;
				case "Centro": return Centro;
				case "Marca": return Marca;
				case "Placa": return Placa;
				case "Modelo": return Modelo;
				case "CedulaConductor": return CedulaConductor;
				case "NombreConductor": return NombreConductor;
				case "TotalGatos": return TotalGatos;
				case "TotalAnticipos": return TotalAnticipos;
				case "TotalGeneral": return TotalGeneral;
				case "Registro": return Registro;
				default: return null;
			}
		}

		public Type GetAttributeType(string pattribute)
		{
			return TramosReportesLiqVehiculosController.Instance.GetMethodType(pattribute, this);
		}

		public string GetSqlKey()
		{
			return "[Registro] = " + Registro.ToString();
		}
		#endregion

	}

	#endregion

	#region TramosReportesLiqVehiculosList object

	/// <summary>
	/// Class for reading and access a list of TramosReportesLiqVehiculos object
	/// </summary>
	[CollectionDataContract]
	public partial class TramosReportesLiqVehiculosList : List<TramosReportesLiqVehiculos>
	{

		/// <summary>
		/// Default constructor
		/// </summary>
		public TramosReportesLiqVehiculosList()
		{
		}
	}

	#endregion

}
