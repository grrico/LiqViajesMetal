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
	#region LiquidacionSaldoConductor object

	[DataContract]
	public partial class LiquidacionSaldoConductor : IDTOObject
	{
		/// <summary>
		/// Default constructor
		/// </summary>
		public LiquidacionSaldoConductor()
		{
			m_lngIdRegistro = 0;
			m_intNitConductor = 0;
			m_curValorSaldo = null;
			m_dtmFechaModif = null;
			m_sw = (byte)0;
			m_strTipo = null;
			m_numero = null;
			m_lngIdRegistroLiq = null;
			m_changed=false;
		}
		        //Return the table name of object
		        public string TableName()
		        {
		            return "tblLiquidacionSaldoConductor";
		        }
		#region Undo 
		// Internal class for storing changes
		private LiquidacionSaldoConductor m_oldLiquidacionSaldoConductor;
		public void GenerateUndo()
		{
			m_oldLiquidacionSaldoConductor=new LiquidacionSaldoConductor();
			m_oldLiquidacionSaldoConductor.m_lngIdRegistro = m_lngIdRegistro;
			m_oldLiquidacionSaldoConductor.m_intNitConductor = m_intNitConductor;
			m_oldLiquidacionSaldoConductor.curValorSaldo = m_curValorSaldo;
			m_oldLiquidacionSaldoConductor.dtmFechaModif = m_dtmFechaModif;
			m_oldLiquidacionSaldoConductor.sw = m_sw;
			m_oldLiquidacionSaldoConductor.strTipo = m_strTipo;
			m_oldLiquidacionSaldoConductor.numero = m_numero;
			m_oldLiquidacionSaldoConductor.lngIdRegistroLiq = m_lngIdRegistroLiq;
		}

		public LiquidacionSaldoConductor OldLiquidacionSaldoConductor
		{
			get { return m_oldLiquidacionSaldoConductor;}
		}
		// Return the changed fields
		public string[] FieldChanged()
		{
			List<string> fields=new List<string>();
			if (m_oldLiquidacionSaldoConductor.curValorSaldo != m_curValorSaldo) fields.Add("curValorSaldo");
			if (m_oldLiquidacionSaldoConductor.dtmFechaModif != m_dtmFechaModif) fields.Add("dtmFechaModif");
			if (m_oldLiquidacionSaldoConductor.sw != m_sw) fields.Add("sw");
			if (m_oldLiquidacionSaldoConductor.strTipo != m_strTipo) fields.Add("strTipo");
			if (m_oldLiquidacionSaldoConductor.numero != m_numero) fields.Add("numero");
			if (m_oldLiquidacionSaldoConductor.lngIdRegistroLiq != m_lngIdRegistroLiq) fields.Add("lngIdRegistroLiq");
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


		// Field for storing the LiquidacionSaldoConductor's curValorSaldo value
		private decimal? m_curValorSaldo;

		// Field for storing the LiquidacionSaldoConductor's dtmFechaModif value
		private DateTime? m_dtmFechaModif;

		// Field for storing the LiquidacionSaldoConductor's sw value
		private byte? m_sw;

		// Field for storing the LiquidacionSaldoConductor's strTipo value
		private string m_strTipo;

		// Field for storing the LiquidacionSaldoConductor's numero value
		private int? m_numero;

		// Field for storing the LiquidacionSaldoConductor's lngIdRegistroLiq value
		private int? m_lngIdRegistroLiq;

		// Field for storing the LiquidacionSaldoConductor's lngIdRegistro value
		private int m_lngIdRegistro;

		// Field for storing the LiquidacionSaldoConductor's intNitConductor value
		private decimal m_intNitConductor;

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
		/// Attribute for access the LiquidacionSaldoConductor's curValorSaldo value (decimal)
		/// </summary>
		[DataMember]
		public decimal? curValorSaldo
		{
			get { return m_curValorSaldo; }
			set 
			{
				m_changed=true;
				m_curValorSaldo = value;
			}
		}

		/// <summary>
		/// Attribute for access the LiquidacionSaldoConductor's dtmFechaModif value (DateTime)
		/// </summary>
		[DataMember]
		public DateTime? dtmFechaModif
		{
			get { return m_dtmFechaModif; }
			set 
			{
				m_changed=true;
				m_dtmFechaModif = value;
			}
		}

		/// <summary>
		/// Attribute for access the LiquidacionSaldoConductor's sw value (byte)
		/// </summary>
		[DataMember]
		public byte? sw
		{
			get { return m_sw; }
			set 
			{
				m_changed=true;
				m_sw = value;
			}
		}

		/// <summary>
		/// Attribute for access the LiquidacionSaldoConductor's strTipo value (string)
		/// </summary>
		[DataMember]
		public string strTipo
		{
			get { return m_strTipo; }
			set 
			{
				m_changed=true;
				m_strTipo = value;
			}
		}

		/// <summary>
		/// Attribute for access the LiquidacionSaldoConductor's numero value (int)
		/// </summary>
		[DataMember]
		public int? numero
		{
			get { return m_numero; }
			set 
			{
				m_changed=true;
				m_numero = value;
			}
		}

		/// <summary>
		/// Attribute for access the LiquidacionSaldoConductor's lngIdRegistroLiq value (int)
		/// </summary>
		[DataMember]
		public int? lngIdRegistroLiq
		{
			get { return m_lngIdRegistroLiq; }
			set 
			{
				m_changed=true;
				m_lngIdRegistroLiq = value;
			}
		}

		/// <summary>
		/// Attribute for access the LiquidacionSaldoConductor's lngIdRegistro value (int)
		/// </summary>
		[DataMember]
		public int lngIdRegistro
		{
			get { return m_lngIdRegistro; }
			set 
			{
				m_changed=true;
				m_lngIdRegistro = value;
			}
		}

		/// <summary>
		/// Attribute for access the LiquidacionSaldoConductor's intNitConductor value (decimal)
		/// </summary>
		[DataMember]
		public decimal intNitConductor
		{
			get { return m_intNitConductor; }
			set 
			{
				m_changed=true;
				m_intNitConductor = value;
			}
		}

		public object GetAttribute(string pattribute)
		{
			switch (pattribute)
			{
				case "curValorSaldo": return curValorSaldo;
				case "dtmFechaModif": return dtmFechaModif;
				case "sw": return sw;
				case "strTipo": return strTipo;
				case "numero": return numero;
				case "lngIdRegistroLiq": return lngIdRegistroLiq;
				case "lngIdRegistro": return lngIdRegistro;
				case "intNitConductor": return intNitConductor;
				default: return null;
			}
		}

		public Type GetAttributeType(string pattribute)
		{
			return LiquidacionSaldoConductorController.Instance.GetMethodType(pattribute, this);
		}

		public string GetSqlKey()
		{
			return "[lngIdRegistro] = " + lngIdRegistro.ToString() + " AND [intNitConductor] = " + intNitConductor.ToString();
		}
		#endregion

	}

	#endregion

	#region LiquidacionSaldoConductorList object

	/// <summary>
	/// Class for reading and access a list of LiquidacionSaldoConductor object
	/// </summary>
	[CollectionDataContract]
	public partial class LiquidacionSaldoConductorList : List<LiquidacionSaldoConductor>
	{

		/// <summary>
		/// Default constructor
		/// </summary>
		public LiquidacionSaldoConductorList()
		{
		}
	}

	#endregion

}
