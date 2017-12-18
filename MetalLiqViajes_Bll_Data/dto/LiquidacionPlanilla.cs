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
	#region LiquidacionPlanilla object

	[DataContract]
	public partial class LiquidacionPlanilla : IDTOObject
	{
		/// <summary>
		/// Default constructor
		/// </summary>
		public LiquidacionPlanilla()
		{
			m_lngIdRegistro = 0;
			m_lngIdRegistrRutaItemId = 0;
			m_lngIdRegistrRuta = 0;
			m_strNoPlanilla = null;
			m_curValorFlete = null;
			m_dtmFechaModif = null;
			m_logDesplazaVacio = false;
			m_logSePuedeLiquidar = false;
			m_changed=false;
		}
		        //Return the table name of object
		        public string TableName()
		        {
		            return "tblLiquidacionPlanilla";
		        }
		#region Undo 
		// Internal class for storing changes
		private LiquidacionPlanilla m_oldLiquidacionPlanilla;
		public void GenerateUndo()
		{
			m_oldLiquidacionPlanilla=new LiquidacionPlanilla();
			m_oldLiquidacionPlanilla.m_lngIdRegistro = m_lngIdRegistro;
			m_oldLiquidacionPlanilla.m_lngIdRegistrRutaItemId = m_lngIdRegistrRutaItemId;
			m_oldLiquidacionPlanilla.m_lngIdRegistrRuta = m_lngIdRegistrRuta;
			m_oldLiquidacionPlanilla.strNoPlanilla = m_strNoPlanilla;
			m_oldLiquidacionPlanilla.curValorFlete = m_curValorFlete;
			m_oldLiquidacionPlanilla.dtmFechaModif = m_dtmFechaModif;
			m_oldLiquidacionPlanilla.logDesplazaVacio = m_logDesplazaVacio;
			m_oldLiquidacionPlanilla.logSePuedeLiquidar = m_logSePuedeLiquidar;
		}

		public LiquidacionPlanilla OldLiquidacionPlanilla
		{
			get { return m_oldLiquidacionPlanilla;}
		}
		// Return the changed fields
		public string[] FieldChanged()
		{
			List<string> fields=new List<string>();
			if (m_oldLiquidacionPlanilla.strNoPlanilla != m_strNoPlanilla) fields.Add("strNoPlanilla");
			if (m_oldLiquidacionPlanilla.curValorFlete != m_curValorFlete) fields.Add("curValorFlete");
			if (m_oldLiquidacionPlanilla.dtmFechaModif != m_dtmFechaModif) fields.Add("dtmFechaModif");
			if (m_oldLiquidacionPlanilla.logDesplazaVacio != m_logDesplazaVacio) fields.Add("logDesplazaVacio");
			if (m_oldLiquidacionPlanilla.logSePuedeLiquidar != m_logSePuedeLiquidar) fields.Add("logSePuedeLiquidar");
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


		// Field for storing the LiquidacionPlanilla's lngIdRegistro value
		private long m_lngIdRegistro;

		// Field for storing the LiquidacionPlanilla's lngIdRegistrRutaItemId value
		private long m_lngIdRegistrRutaItemId;

		// Field for storing the LiquidacionPlanilla's lngIdRegistrRuta value
		private long m_lngIdRegistrRuta;

		// Field for storing the LiquidacionPlanilla's strNoPlanilla value
		private string m_strNoPlanilla;

		// Field for storing the LiquidacionPlanilla's curValorFlete value
		private decimal? m_curValorFlete;

		// Field for storing the LiquidacionPlanilla's dtmFechaModif value
		private DateTime? m_dtmFechaModif;

		// Field for storing the LiquidacionPlanilla's logDesplazaVacio value
		private bool? m_logDesplazaVacio;

		// Field for storing the LiquidacionPlanilla's logSePuedeLiquidar value
		private bool? m_logSePuedeLiquidar;

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
		/// Attribute for access the LiquidacionPlanilla's lngIdRegistro value (long)
		/// </summary>
		[DataMember]
		public long lngIdRegistro
		{
			get { return m_lngIdRegistro; }
			set 
			{
				m_changed=true;
				m_lngIdRegistro = value;
			}
		}

		/// <summary>
		/// Attribute for access the LiquidacionPlanilla's lngIdRegistrRutaItemId value (long)
		/// </summary>
		[DataMember]
		public long lngIdRegistrRutaItemId
		{
			get { return m_lngIdRegistrRutaItemId; }
			set 
			{
				m_changed=true;
				m_lngIdRegistrRutaItemId = value;
			}
		}

		/// <summary>
		/// Attribute for access the LiquidacionPlanilla's lngIdRegistrRuta value (long)
		/// </summary>
		[DataMember]
		public long lngIdRegistrRuta
		{
			get { return m_lngIdRegistrRuta; }
			set 
			{
				m_changed=true;
				m_lngIdRegistrRuta = value;
			}
		}

		/// <summary>
		/// Attribute for access the LiquidacionPlanilla's strNoPlanilla value (string)
		/// </summary>
		[DataMember]
		public string strNoPlanilla
		{
			get { return m_strNoPlanilla; }
			set 
			{
				m_changed=true;
				m_strNoPlanilla = value;
			}
		}

		/// <summary>
		/// Attribute for access the LiquidacionPlanilla's curValorFlete value (decimal)
		/// </summary>
		[DataMember]
		public decimal? curValorFlete
		{
			get { return m_curValorFlete; }
			set 
			{
				m_changed=true;
				m_curValorFlete = value;
			}
		}

		/// <summary>
		/// Attribute for access the LiquidacionPlanilla's dtmFechaModif value (DateTime)
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
		/// Attribute for access the LiquidacionPlanilla's logDesplazaVacio value (bool)
		/// </summary>
		[DataMember]
		public bool? logDesplazaVacio
		{
			get { return m_logDesplazaVacio; }
			set 
			{
				m_changed=true;
				m_logDesplazaVacio = value;
			}
		}

		/// <summary>
		/// Attribute for access the LiquidacionPlanilla's logSePuedeLiquidar value (bool)
		/// </summary>
		[DataMember]
		public bool? logSePuedeLiquidar
		{
			get { return m_logSePuedeLiquidar; }
			set 
			{
				m_changed=true;
				m_logSePuedeLiquidar = value;
			}
		}

		public object GetAttribute(string pattribute)
		{
			switch (pattribute)
			{
				case "lngIdRegistro": return lngIdRegistro;
				case "lngIdRegistrRutaItemId": return lngIdRegistrRutaItemId;
				case "lngIdRegistrRuta": return lngIdRegistrRuta;
				case "strNoPlanilla": return strNoPlanilla;
				case "curValorFlete": return curValorFlete;
				case "dtmFechaModif": return dtmFechaModif;
				case "logDesplazaVacio": return logDesplazaVacio;
				case "logSePuedeLiquidar": return logSePuedeLiquidar;
				default: return null;
			}
		}

		public Type GetAttributeType(string pattribute)
		{
			return LiquidacionPlanillaController.Instance.GetMethodType(pattribute, this);
		}

		public string GetSqlKey()
		{
			return "[lngIdRegistro] = " + lngIdRegistro.ToString() + " AND [lngIdRegistrRutaItemId] = " + lngIdRegistrRutaItemId.ToString() + " AND [lngIdRegistrRuta] = " + lngIdRegistrRuta.ToString();
		}
		#endregion

	}

	#endregion

	#region LiquidacionPlanillaList object

	/// <summary>
	/// Class for reading and access a list of LiquidacionPlanilla object
	/// </summary>
	[CollectionDataContract]
	public partial class LiquidacionPlanillaList : List<LiquidacionPlanilla>
	{

		/// <summary>
		/// Default constructor
		/// </summary>
		public LiquidacionPlanillaList()
		{
		}
	}

	#endregion

}
