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
	#region RutaSatrackKilometros object

	[DataContract]
	public partial class RutaSatrackKilometros : IDTOObject
	{
		/// <summary>
		/// Default constructor
		/// </summary>
		public RutaSatrackKilometros()
		{
			m_Placa = "";
			m_Ano = 0;
			m_Mes = 0;
			m_Dia = 0;
			m_Kilometros = null;
			m_changed=false;
		}
		        //Return the table name of object
		        public string TableName()
		        {
		            return "RutaSatrackKilometros";
		        }
		#region Undo 
		// Internal class for storing changes
		private RutaSatrackKilometros m_oldRutaSatrackKilometros;
		public void GenerateUndo()
		{
			m_oldRutaSatrackKilometros=new RutaSatrackKilometros();
			m_oldRutaSatrackKilometros.m_Placa = m_Placa;
			m_oldRutaSatrackKilometros.m_Ano = m_Ano;
			m_oldRutaSatrackKilometros.m_Mes = m_Mes;
			m_oldRutaSatrackKilometros.m_Dia = m_Dia;
			m_oldRutaSatrackKilometros.Kilometros = m_Kilometros;
		}

		public RutaSatrackKilometros OldRutaSatrackKilometros
		{
			get { return m_oldRutaSatrackKilometros;}
		}
		// Return the changed fields
		public string[] FieldChanged()
		{
			List<string> fields=new List<string>();
			if (m_oldRutaSatrackKilometros.Kilometros != m_Kilometros) fields.Add("Kilometros");
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


		// Field for storing the RutaSatrackKilometros's Placa value
		private string m_Placa;

		// Field for storing the RutaSatrackKilometros's Ano value
		private int m_Ano;

		// Field for storing the RutaSatrackKilometros's Mes value
		private int m_Mes;

		// Field for storing the RutaSatrackKilometros's Dia value
		private int m_Dia;

		// Field for storing the RutaSatrackKilometros's Kilometros value
		private double? m_Kilometros;

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
		/// Attribute for access the RutaSatrackKilometros's Placa value (string)
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
		/// Attribute for access the RutaSatrackKilometros's Ano value (int)
		/// </summary>
		[DataMember]
		public int Ano
		{
			get { return m_Ano; }
			set 
			{
				m_changed=true;
				m_Ano = value;
			}
		}

		/// <summary>
		/// Attribute for access the RutaSatrackKilometros's Mes value (int)
		/// </summary>
		[DataMember]
		public int Mes
		{
			get { return m_Mes; }
			set 
			{
				m_changed=true;
				m_Mes = value;
			}
		}

		/// <summary>
		/// Attribute for access the RutaSatrackKilometros's Dia value (int)
		/// </summary>
		[DataMember]
		public int Dia
		{
			get { return m_Dia; }
			set 
			{
				m_changed=true;
				m_Dia = value;
			}
		}

		/// <summary>
		/// Attribute for access the RutaSatrackKilometros's Kilometros value (double)
		/// </summary>
		[DataMember]
		public double? Kilometros
		{
			get { return m_Kilometros; }
			set 
			{
				m_changed=true;
				m_Kilometros = value;
			}
		}

		public object GetAttribute(string pattribute)
		{
			switch (pattribute)
			{
				case "Placa": return Placa;
				case "Ano": return Ano;
				case "Mes": return Mes;
				case "Dia": return Dia;
				case "Kilometros": return Kilometros;
				default: return null;
			}
		}

		public Type GetAttributeType(string pattribute)
		{
			return RutaSatrackKilometrosController.Instance.GetMethodType(pattribute, this);
		}

		public string GetSqlKey()
		{
			return "[Placa] = '" + Placa.ToString()+ "'" + " AND [Ano] = " + Ano.ToString() + " AND [Mes] = " + Mes.ToString() + " AND [Dia] = " + Dia.ToString();
		}
		#endregion

	}

	#endregion

	#region RutaSatrackKilometrosList object

	/// <summary>
	/// Class for reading and access a list of RutaSatrackKilometros object
	/// </summary>
	[CollectionDataContract]
	public partial class RutaSatrackKilometrosList : List<RutaSatrackKilometros>
	{

		/// <summary>
		/// Default constructor
		/// </summary>
		public RutaSatrackKilometrosList()
		{
		}
	}

	#endregion

}
