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
	#region ObservacioneComplementarias object

	[DataContract]
	public partial class ObservacioneComplementarias : IDTOObject
	{
		/// <summary>
		/// Default constructor
		/// </summary>
		public ObservacioneComplementarias()
		{
			m_Codigo = 0;
			m_Origen = null;
			m_Destino = null;
			m_Cuenta = null;
			m_Fila = null;
			m_DetalleObservacion = null;
			m_changed=false;
		}
		        //Return the table name of object
		        public string TableName()
		        {
		            return "ObservacioneComplementarias";
		        }
		#region Undo 
		// Internal class for storing changes
		private ObservacioneComplementarias m_oldObservacioneComplementarias;
		public void GenerateUndo()
		{
			m_oldObservacioneComplementarias=new ObservacioneComplementarias();
			m_oldObservacioneComplementarias.m_Codigo = m_Codigo;
			m_oldObservacioneComplementarias.Origen = m_Origen;
			m_oldObservacioneComplementarias.Destino = m_Destino;
			m_oldObservacioneComplementarias.Cuenta = m_Cuenta;
			m_oldObservacioneComplementarias.Fila = m_Fila;
			m_oldObservacioneComplementarias.DetalleObservacion = m_DetalleObservacion;
		}

		public ObservacioneComplementarias OldObservacioneComplementarias
		{
			get { return m_oldObservacioneComplementarias;}
		}
		// Return the changed fields
		public string[] FieldChanged()
		{
			List<string> fields=new List<string>();
			if (m_oldObservacioneComplementarias.Origen != m_Origen) fields.Add("Origen");
			if (m_oldObservacioneComplementarias.Destino != m_Destino) fields.Add("Destino");
			if (m_oldObservacioneComplementarias.Cuenta != m_Cuenta) fields.Add("Cuenta");
			if (m_oldObservacioneComplementarias.Fila != m_Fila) fields.Add("Fila");
			if (m_oldObservacioneComplementarias.DetalleObservacion != m_DetalleObservacion) fields.Add("DetalleObservacion");
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


		// Field for storing the ObservacioneComplementarias's Origen value
		private string m_Origen;

		// Field for storing the ObservacioneComplementarias's Destino value
		private string m_Destino;

		// Field for storing the ObservacioneComplementarias's Cuenta value
		private string m_Cuenta;

		// Field for storing the ObservacioneComplementarias's Fila value
		private int? m_Fila;

		// Field for storing the ObservacioneComplementarias's DetalleObservacion value
		private string m_DetalleObservacion;

		// Field for storing the ObservacioneComplementarias's Codigo value
		private int m_Codigo;

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
		/// Attribute for access the ObservacioneComplementarias's Origen value (string)
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
		/// Attribute for access the ObservacioneComplementarias's Destino value (string)
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

		/// <summary>
		/// Attribute for access the ObservacioneComplementarias's Cuenta value (string)
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
		/// Attribute for access the ObservacioneComplementarias's Fila value (int)
		/// </summary>
		[DataMember]
		public int? Fila
		{
			get { return m_Fila; }
			set 
			{
				m_changed=true;
				m_Fila = value;
			}
		}

		/// <summary>
		/// Attribute for access the ObservacioneComplementarias's DetalleObservacion value (string)
		/// </summary>
		[DataMember]
		public string DetalleObservacion
		{
			get { return m_DetalleObservacion; }
			set 
			{
				m_changed=true;
				m_DetalleObservacion = value;
			}
		}

		/// <summary>
		/// Attribute for access the ObservacioneComplementarias's Codigo value (int)
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

		public object GetAttribute(string pattribute)
		{
			switch (pattribute)
			{
				case "Origen": return Origen;
				case "Destino": return Destino;
				case "Cuenta": return Cuenta;
				case "Fila": return Fila;
				case "DetalleObservacion": return DetalleObservacion;
				case "Codigo": return Codigo;
				default: return null;
			}
		}

		public Type GetAttributeType(string pattribute)
		{
			return ObservacioneComplementariasController.Instance.GetMethodType(pattribute, this);
		}

		public string GetSqlKey()
		{
			return "[Codigo] = " + Codigo.ToString();
		}
		#endregion

	}

	#endregion

	#region ObservacioneComplementariasList object

	/// <summary>
	/// Class for reading and access a list of ObservacioneComplementarias object
	/// </summary>
	[CollectionDataContract]
	public partial class ObservacioneComplementariasList : List<ObservacioneComplementarias>
	{

		/// <summary>
		/// Default constructor
		/// </summary>
		public ObservacioneComplementariasList()
		{
		}
	}

	#endregion

}
