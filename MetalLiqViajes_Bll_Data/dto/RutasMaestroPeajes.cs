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
	#region RutasMaestroPeajes object

	[DataContract]
	public partial class RutasMaestroPeajes : IDTOObject
	{
		/// <summary>
		/// Default constructor
		/// </summary>
		public RutasMaestroPeajes()
		{
			m_lngIdPeaje = 0;
			m_strNombrePeaje = null;
			m_Activo = false;
			m_curValorTipo1 = null;
			m_curValorTipo2 = null;
			m_curValorTipo3 = null;
			m_curValorTipo4 = null;
			m_curValorTipo5 = null;
			m_curValorTipo6 = null;
			m_curValorTipo7 = null;
			m_changed=false;
		}
		        //Return the table name of object
		        public string TableName()
		        {
		            return "tblRutasMaestroPeajes";
		        }
		#region Undo 
		// Internal class for storing changes
		private RutasMaestroPeajes m_oldRutasMaestroPeajes;
		public void GenerateUndo()
		{
			m_oldRutasMaestroPeajes=new RutasMaestroPeajes();
			m_oldRutasMaestroPeajes.m_lngIdPeaje = m_lngIdPeaje;
			m_oldRutasMaestroPeajes.strNombrePeaje = m_strNombrePeaje;
			m_oldRutasMaestroPeajes.Activo = m_Activo;
			m_oldRutasMaestroPeajes.curValorTipo1 = m_curValorTipo1;
			m_oldRutasMaestroPeajes.curValorTipo2 = m_curValorTipo2;
			m_oldRutasMaestroPeajes.curValorTipo3 = m_curValorTipo3;
			m_oldRutasMaestroPeajes.curValorTipo4 = m_curValorTipo4;
			m_oldRutasMaestroPeajes.curValorTipo5 = m_curValorTipo5;
			m_oldRutasMaestroPeajes.curValorTipo6 = m_curValorTipo6;
			m_oldRutasMaestroPeajes.curValorTipo7 = m_curValorTipo7;
		}

		public RutasMaestroPeajes OldRutasMaestroPeajes
		{
			get { return m_oldRutasMaestroPeajes;}
		}
		// Return the changed fields
		public string[] FieldChanged()
		{
			List<string> fields=new List<string>();
			if (m_oldRutasMaestroPeajes.strNombrePeaje != m_strNombrePeaje) fields.Add("strNombrePeaje");
			if (m_oldRutasMaestroPeajes.Activo != m_Activo) fields.Add("Activo");
			if (m_oldRutasMaestroPeajes.curValorTipo1 != m_curValorTipo1) fields.Add("curValorTipo1");
			if (m_oldRutasMaestroPeajes.curValorTipo2 != m_curValorTipo2) fields.Add("curValorTipo2");
			if (m_oldRutasMaestroPeajes.curValorTipo3 != m_curValorTipo3) fields.Add("curValorTipo3");
			if (m_oldRutasMaestroPeajes.curValorTipo4 != m_curValorTipo4) fields.Add("curValorTipo4");
			if (m_oldRutasMaestroPeajes.curValorTipo5 != m_curValorTipo5) fields.Add("curValorTipo5");
			if (m_oldRutasMaestroPeajes.curValorTipo6 != m_curValorTipo6) fields.Add("curValorTipo6");
			if (m_oldRutasMaestroPeajes.curValorTipo7 != m_curValorTipo7) fields.Add("curValorTipo7");
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


		// Field for storing the RutasMaestroPeajes's lngIdPeaje value
		private int m_lngIdPeaje;

		// Field for storing the RutasMaestroPeajes's strNombrePeaje value
		private string m_strNombrePeaje;

		// Field for storing the RutasMaestroPeajes's Activo value
		private bool m_Activo;

		// Field for storing the RutasMaestroPeajes's curValorTipo1 value
		private decimal? m_curValorTipo1;

		// Field for storing the RutasMaestroPeajes's curValorTipo2 value
		private decimal? m_curValorTipo2;

		// Field for storing the RutasMaestroPeajes's curValorTipo3 value
		private decimal? m_curValorTipo3;

		// Field for storing the RutasMaestroPeajes's curValorTipo4 value
		private decimal? m_curValorTipo4;

		// Field for storing the RutasMaestroPeajes's curValorTipo5 value
		private decimal? m_curValorTipo5;

		// Field for storing the RutasMaestroPeajes's curValorTipo6 value
		private decimal? m_curValorTipo6;

		// Field for storing the RutasMaestroPeajes's curValorTipo7 value
		private decimal? m_curValorTipo7;

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
		/// Attribute for access the RutasMaestroPeajes's lngIdPeaje value (int)
		/// </summary>
		[DataMember]
		public int lngIdPeaje
		{
			get { return m_lngIdPeaje; }
			set 
			{
				m_changed=true;
				m_lngIdPeaje = value;
			}
		}

		/// <summary>
		/// Attribute for access the RutasMaestroPeajes's strNombrePeaje value (string)
		/// </summary>
		[DataMember]
		public string strNombrePeaje
		{
			get { return m_strNombrePeaje; }
			set 
			{
				m_changed=true;
				m_strNombrePeaje = value;
			}
		}

		/// <summary>
		/// Attribute for access the RutasMaestroPeajes's Activo value (bool)
		/// </summary>
		[DataMember]
		public bool Activo
		{
			get { return m_Activo; }
			set 
			{
				m_changed=true;
				m_Activo = value;
			}
		}

		/// <summary>
		/// Attribute for access the RutasMaestroPeajes's curValorTipo1 value (decimal)
		/// </summary>
		[DataMember]
		public decimal? curValorTipo1
		{
			get { return m_curValorTipo1; }
			set 
			{
				m_changed=true;
				m_curValorTipo1 = value;
			}
		}

		/// <summary>
		/// Attribute for access the RutasMaestroPeajes's curValorTipo2 value (decimal)
		/// </summary>
		[DataMember]
		public decimal? curValorTipo2
		{
			get { return m_curValorTipo2; }
			set 
			{
				m_changed=true;
				m_curValorTipo2 = value;
			}
		}

		/// <summary>
		/// Attribute for access the RutasMaestroPeajes's curValorTipo3 value (decimal)
		/// </summary>
		[DataMember]
		public decimal? curValorTipo3
		{
			get { return m_curValorTipo3; }
			set 
			{
				m_changed=true;
				m_curValorTipo3 = value;
			}
		}

		/// <summary>
		/// Attribute for access the RutasMaestroPeajes's curValorTipo4 value (decimal)
		/// </summary>
		[DataMember]
		public decimal? curValorTipo4
		{
			get { return m_curValorTipo4; }
			set 
			{
				m_changed=true;
				m_curValorTipo4 = value;
			}
		}

		/// <summary>
		/// Attribute for access the RutasMaestroPeajes's curValorTipo5 value (decimal)
		/// </summary>
		[DataMember]
		public decimal? curValorTipo5
		{
			get { return m_curValorTipo5; }
			set 
			{
				m_changed=true;
				m_curValorTipo5 = value;
			}
		}

		/// <summary>
		/// Attribute for access the RutasMaestroPeajes's curValorTipo6 value (decimal)
		/// </summary>
		[DataMember]
		public decimal? curValorTipo6
		{
			get { return m_curValorTipo6; }
			set 
			{
				m_changed=true;
				m_curValorTipo6 = value;
			}
		}

		/// <summary>
		/// Attribute for access the RutasMaestroPeajes's curValorTipo7 value (decimal)
		/// </summary>
		[DataMember]
		public decimal? curValorTipo7
		{
			get { return m_curValorTipo7; }
			set 
			{
				m_changed=true;
				m_curValorTipo7 = value;
			}
		}

		public object GetAttribute(string pattribute)
		{
			switch (pattribute)
			{
				case "lngIdPeaje": return lngIdPeaje;
				case "strNombrePeaje": return strNombrePeaje;
				case "Activo": return Activo;
				case "curValorTipo1": return curValorTipo1;
				case "curValorTipo2": return curValorTipo2;
				case "curValorTipo3": return curValorTipo3;
				case "curValorTipo4": return curValorTipo4;
				case "curValorTipo5": return curValorTipo5;
				case "curValorTipo6": return curValorTipo6;
				case "curValorTipo7": return curValorTipo7;
				default: return null;
			}
		}

		public Type GetAttributeType(string pattribute)
		{
			return RutasMaestroPeajesController.Instance.GetMethodType(pattribute, this);
		}

		public string GetSqlKey()
		{
			return "[lngIdPeaje] = " + lngIdPeaje.ToString();
		}
		#endregion

	}

	#endregion

	#region RutasMaestroPeajesList object

	/// <summary>
	/// Class for reading and access a list of RutasMaestroPeajes object
	/// </summary>
	[CollectionDataContract]
	public partial class RutasMaestroPeajesList : List<RutasMaestroPeajes>
	{

		/// <summary>
		/// Default constructor
		/// </summary>
		public RutasMaestroPeajesList()
		{
		}
	}

	#endregion

}
