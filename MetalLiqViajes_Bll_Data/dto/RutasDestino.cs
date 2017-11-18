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
	#region RutasDestino object

	[DataContract]
	public partial class RutasDestino : IDTOObject
	{
		/// <summary>
		/// Default constructor
		/// </summary>
		public RutasDestino()
		{
			m_Codigo = 0;
			m_RutasOrigenCodigo = null;
			m_Origen = null;
			m_Destino = null;
			m_changed=false;
		}
		        //Return the table name of object
		        public string TableName()
		        {
		            return "RutasDestino";
		        }
		#region Undo 
		// Internal class for storing changes
		private RutasDestino m_oldRutasDestino;
		public void GenerateUndo()
		{
			m_oldRutasDestino=new RutasDestino();
			m_oldRutasDestino.m_Codigo = m_Codigo;
			m_oldRutasDestino.RutasOrigenCodigo = m_RutasOrigenCodigo;
			m_oldRutasDestino.Origen = m_Origen;
			m_oldRutasDestino.Destino = m_Destino;
		}

		public RutasDestino OldRutasDestino
		{
			get { return m_oldRutasDestino;}
		}
		// Return the changed fields
		public string[] FieldChanged()
		{
			List<string> fields=new List<string>();
			if (m_oldRutasDestino.RutasOrigenCodigo != m_RutasOrigenCodigo) fields.Add("RutasOrigenCodigo");
			if (m_oldRutasDestino.Origen != m_Origen) fields.Add("Origen");
			if (m_oldRutasDestino.Destino != m_Destino) fields.Add("Destino");
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


		// Field for storing the RutasDestino's Codigo value
		private int m_Codigo;

		// Field for storing the RutasDestino's RutasOrigenCodigo value
		private int? m_RutasOrigenCodigo;

		// Field for storing the RutasDestino's Origen value
		private string m_Origen;

		// Field for storing the RutasDestino's Destino value
		private string m_Destino;

		// Evaluate changed state
		private bool m_changed=false;
		// Field for storing the reference to RutasOrigen accessed by RutasOrigenCodigo
		private RutasOrigen m_RutasOrigen;


		#endregion

		#region Attributes

		// Return if object changed
		public bool Changed
		{
			get { return m_changed;}
			set { m_changed=value;}
		}
		/// <summary>
		/// Attribute for access the RutasDestino's Codigo value (int)
		/// </summary>
		[DataMember]
		public int Codigo
		{
			get { return m_Codigo; }
			set 
			{
				m_changed=true;
				m_Codigo = value;
			}
		}

		/// <summary>
		/// Attribute for access the RutasDestino's RutasOrigenCodigo value (int)
		/// </summary>
		[DataMember]
		public int? RutasOrigenCodigo
		{
			get { return m_RutasOrigenCodigo; }
			set
			{
				m_changed=true;
				m_RutasOrigenCodigo = value;

				if ((m_RutasOrigen != null) && (m_RutasOrigen.Codigo != m_RutasOrigenCodigo))
				{
					// we need to reset the reference because it is now invalid
					m_RutasOrigen = null;
				}
			}
		}

		/// <summary>
		/// Attribute for access the RutasDestino's Origen value (string)
		/// </summary>
		[DataMember]
		public string Origen
		{
			get { return m_Origen; }
			set 
			{
				m_changed=true;
				m_Origen = value;
			}
		}

		/// <summary>
		/// Attribute for access the RutasDestino's Destino value (string)
		/// </summary>
		[DataMember]
		public string Destino
		{
			get { return m_Destino; }
			set 
			{
				m_changed=true;
				m_Destino = value;
			}
		}

		public object GetAttribute(string pattribute)
		{
			switch (pattribute)
			{
				case "Codigo": return Codigo;
				case "RutasOrigenCodigo": return RutasOrigenCodigo;
				case "Origen": return Origen;
				case "Destino": return Destino;
				default: return null;
			}
		}

		public Type GetAttributeType(string pattribute)
		{
			return RutasDestinoController.Instance.GetMethodType(pattribute, this);
		}

		public string GetSqlKey()
		{
			return "[Codigo] = " + Codigo.ToString();
		}
		/// <summary>
		/// Gets or sets the reference to RutasOrigen accessed by RutasOrigenCodigo
		/// </summary>
		/// <remarks>
		/// Also updates related field values
		/// </remarks>
		public RutasOrigen RutasOrigen
		{
			get
			{
				if (m_RutasOrigen == null)
				{
					if (m_RutasOrigenCodigo != null)
					{
						m_RutasOrigen = RutasOrigenController.Instance.Get((int)m_RutasOrigenCodigo);
					}
				}

				return m_RutasOrigen;
			}

			set
			{
				m_RutasOrigen = value;

				if (m_RutasOrigen != null)
				{
					this.m_RutasOrigenCodigo = m_RutasOrigen.Codigo;
				}
			}
		}

		#endregion

	}

	#endregion

	#region RutasDestinoList object

	/// <summary>
	/// Class for reading and access a list of RutasDestino object
	/// </summary>
	[CollectionDataContract]
	public partial class RutasDestinoList : List<RutasDestino>
	{

		/// <summary>
		/// Default constructor
		/// </summary>
		public RutasDestinoList()
		{
		}
	}

	#endregion

}
