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
	#region LiquidacionRutasCombustible object

	[DataContract]
	public partial class LiquidacionRutasCombustible : IDTOObject
	{
		/// <summary>
		/// Default constructor
		/// </summary>
		public LiquidacionRutasCombustible()
		{
			m_Codigo = 0;
			m_lngIdRegistrRutaItemId = null;
			m_lngIdRegistro = null;
			m_lngIdRegistrRuta = null;
			m_intRowRegistro = null;
			m_strRutaAnticipoGrupoOrigen = null;
			m_strRutaAnticipoGrupoDestino = null;
			m_nitTercero = null;
			m_NombreTercero = null;
			m_floGalones = null;
			m_curValorGalon = null;
			m_cutCombustible = null;
			m_nitTerceroComplentario = null;
			m_NombreTerceroComplementario = null;
			m_floGalonesComplementario = null;
			m_curValorGalonComplentario = null;
			m_cutCombustibleComplementario = null;
			m_strObservaciones = null;
			m_changed=false;
		}
		        //Return the table name of object
		        public string TableName()
		        {
		            return "tblLiquidacionRutasCombustible";
		        }
		#region Undo 
		// Internal class for storing changes
		private LiquidacionRutasCombustible m_oldLiquidacionRutasCombustible;
		public void GenerateUndo()
		{
			m_oldLiquidacionRutasCombustible=new LiquidacionRutasCombustible();
			m_oldLiquidacionRutasCombustible.m_Codigo = m_Codigo;
			m_oldLiquidacionRutasCombustible.lngIdRegistrRutaItemId = m_lngIdRegistrRutaItemId;
			m_oldLiquidacionRutasCombustible.lngIdRegistro = m_lngIdRegistro;
			m_oldLiquidacionRutasCombustible.lngIdRegistrRuta = m_lngIdRegistrRuta;
			m_oldLiquidacionRutasCombustible.intRowRegistro = m_intRowRegistro;
			m_oldLiquidacionRutasCombustible.strRutaAnticipoGrupoOrigen = m_strRutaAnticipoGrupoOrigen;
			m_oldLiquidacionRutasCombustible.strRutaAnticipoGrupoDestino = m_strRutaAnticipoGrupoDestino;
			m_oldLiquidacionRutasCombustible.nitTercero = m_nitTercero;
			m_oldLiquidacionRutasCombustible.NombreTercero = m_NombreTercero;
			m_oldLiquidacionRutasCombustible.floGalones = m_floGalones;
			m_oldLiquidacionRutasCombustible.curValorGalon = m_curValorGalon;
			m_oldLiquidacionRutasCombustible.cutCombustible = m_cutCombustible;
			m_oldLiquidacionRutasCombustible.nitTerceroComplentario = m_nitTerceroComplentario;
			m_oldLiquidacionRutasCombustible.NombreTerceroComplementario = m_NombreTerceroComplementario;
			m_oldLiquidacionRutasCombustible.floGalonesComplementario = m_floGalonesComplementario;
			m_oldLiquidacionRutasCombustible.curValorGalonComplentario = m_curValorGalonComplentario;
			m_oldLiquidacionRutasCombustible.cutCombustibleComplementario = m_cutCombustibleComplementario;
			m_oldLiquidacionRutasCombustible.strObservaciones = m_strObservaciones;
		}

		public LiquidacionRutasCombustible OldLiquidacionRutasCombustible
		{
			get { return m_oldLiquidacionRutasCombustible;}
		}
		// Return the changed fields
		public string[] FieldChanged()
		{
			List<string> fields=new List<string>();
			if (m_oldLiquidacionRutasCombustible.lngIdRegistrRutaItemId != m_lngIdRegistrRutaItemId) fields.Add("lngIdRegistrRutaItemId");
			if (m_oldLiquidacionRutasCombustible.lngIdRegistro != m_lngIdRegistro) fields.Add("lngIdRegistro");
			if (m_oldLiquidacionRutasCombustible.lngIdRegistrRuta != m_lngIdRegistrRuta) fields.Add("lngIdRegistrRuta");
			if (m_oldLiquidacionRutasCombustible.intRowRegistro != m_intRowRegistro) fields.Add("intRowRegistro");
			if (m_oldLiquidacionRutasCombustible.strRutaAnticipoGrupoOrigen != m_strRutaAnticipoGrupoOrigen) fields.Add("strRutaAnticipoGrupoOrigen");
			if (m_oldLiquidacionRutasCombustible.strRutaAnticipoGrupoDestino != m_strRutaAnticipoGrupoDestino) fields.Add("strRutaAnticipoGrupoDestino");
			if (m_oldLiquidacionRutasCombustible.nitTercero != m_nitTercero) fields.Add("nitTercero");
			if (m_oldLiquidacionRutasCombustible.NombreTercero != m_NombreTercero) fields.Add("NombreTercero");
			if (m_oldLiquidacionRutasCombustible.floGalones != m_floGalones) fields.Add("floGalones");
			if (m_oldLiquidacionRutasCombustible.curValorGalon != m_curValorGalon) fields.Add("curValorGalon");
			if (m_oldLiquidacionRutasCombustible.cutCombustible != m_cutCombustible) fields.Add("cutCombustible");
			if (m_oldLiquidacionRutasCombustible.nitTerceroComplentario != m_nitTerceroComplentario) fields.Add("nitTerceroComplentario");
			if (m_oldLiquidacionRutasCombustible.NombreTerceroComplementario != m_NombreTerceroComplementario) fields.Add("NombreTerceroComplementario");
			if (m_oldLiquidacionRutasCombustible.floGalonesComplementario != m_floGalonesComplementario) fields.Add("floGalonesComplementario");
			if (m_oldLiquidacionRutasCombustible.curValorGalonComplentario != m_curValorGalonComplentario) fields.Add("curValorGalonComplentario");
			if (m_oldLiquidacionRutasCombustible.cutCombustibleComplementario != m_cutCombustibleComplementario) fields.Add("cutCombustibleComplementario");
			if (m_oldLiquidacionRutasCombustible.strObservaciones != m_strObservaciones) fields.Add("strObservaciones");
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


		// Field for storing the LiquidacionRutasCombustible's lngIdRegistrRutaItemId value
		private int? m_lngIdRegistrRutaItemId;

		// Field for storing the LiquidacionRutasCombustible's lngIdRegistro value
		private int? m_lngIdRegistro;

		// Field for storing the LiquidacionRutasCombustible's lngIdRegistrRuta value
		private int? m_lngIdRegistrRuta;

		// Field for storing the LiquidacionRutasCombustible's intRowRegistro value
		private int? m_intRowRegistro;

		// Field for storing the LiquidacionRutasCombustible's strRutaAnticipoGrupoOrigen value
		private string m_strRutaAnticipoGrupoOrigen;

		// Field for storing the LiquidacionRutasCombustible's strRutaAnticipoGrupoDestino value
		private string m_strRutaAnticipoGrupoDestino;

		// Field for storing the LiquidacionRutasCombustible's nitTercero value
		private string m_nitTercero;

		// Field for storing the LiquidacionRutasCombustible's NombreTercero value
		private string m_NombreTercero;

		// Field for storing the LiquidacionRutasCombustible's floGalones value
		private decimal? m_floGalones;

		// Field for storing the LiquidacionRutasCombustible's curValorGalon value
		private decimal? m_curValorGalon;

		// Field for storing the LiquidacionRutasCombustible's cutCombustible value
		private decimal? m_cutCombustible;

		// Field for storing the LiquidacionRutasCombustible's nitTerceroComplentario value
		private string m_nitTerceroComplentario;

		// Field for storing the LiquidacionRutasCombustible's NombreTerceroComplementario value
		private string m_NombreTerceroComplementario;

		// Field for storing the LiquidacionRutasCombustible's floGalonesComplementario value
		private decimal? m_floGalonesComplementario;

		// Field for storing the LiquidacionRutasCombustible's curValorGalonComplentario value
		private decimal? m_curValorGalonComplentario;

		// Field for storing the LiquidacionRutasCombustible's cutCombustibleComplementario value
		private decimal? m_cutCombustibleComplementario;

		// Field for storing the LiquidacionRutasCombustible's strObservaciones value
		private string m_strObservaciones;

		// Field for storing the LiquidacionRutasCombustible's Codigo value
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
		/// Attribute for access the LiquidacionRutasCombustible's lngIdRegistrRutaItemId value (int)
		/// </summary>
		[DataMember]
		public int? lngIdRegistrRutaItemId
		{
			get { return m_lngIdRegistrRutaItemId; }
			set 
			{
				m_changed=true;
				m_lngIdRegistrRutaItemId = value;
			}
		}

		/// <summary>
		/// Attribute for access the LiquidacionRutasCombustible's lngIdRegistro value (int)
		/// </summary>
		[DataMember]
		public int? lngIdRegistro
		{
			get { return m_lngIdRegistro; }
			set 
			{
				m_changed=true;
				m_lngIdRegistro = value;
			}
		}

		/// <summary>
		/// Attribute for access the LiquidacionRutasCombustible's lngIdRegistrRuta value (int)
		/// </summary>
		[DataMember]
		public int? lngIdRegistrRuta
		{
			get { return m_lngIdRegistrRuta; }
			set 
			{
				m_changed=true;
				m_lngIdRegistrRuta = value;
			}
		}

		/// <summary>
		/// Attribute for access the LiquidacionRutasCombustible's intRowRegistro value (int)
		/// </summary>
		[DataMember]
		public int? intRowRegistro
		{
			get { return m_intRowRegistro; }
			set 
			{
				m_changed=true;
				m_intRowRegistro = value;
			}
		}

		/// <summary>
		/// Attribute for access the LiquidacionRutasCombustible's strRutaAnticipoGrupoOrigen value (string)
		/// </summary>
		[DataMember]
		public string strRutaAnticipoGrupoOrigen
		{
			get { return m_strRutaAnticipoGrupoOrigen; }
			set 
			{
				m_changed=true;
				m_strRutaAnticipoGrupoOrigen = value;
			}
		}

		/// <summary>
		/// Attribute for access the LiquidacionRutasCombustible's strRutaAnticipoGrupoDestino value (string)
		/// </summary>
		[DataMember]
		public string strRutaAnticipoGrupoDestino
		{
			get { return m_strRutaAnticipoGrupoDestino; }
			set 
			{
				m_changed=true;
				m_strRutaAnticipoGrupoDestino = value;
			}
		}

		/// <summary>
		/// Attribute for access the LiquidacionRutasCombustible's nitTercero value (string)
		/// </summary>
		[DataMember]
		public string nitTercero
		{
			get { return m_nitTercero; }
			set 
			{
				m_changed=true;
				m_nitTercero = value;
			}
		}

		/// <summary>
		/// Attribute for access the LiquidacionRutasCombustible's NombreTercero value (string)
		/// </summary>
		[DataMember]
		public string NombreTercero
		{
			get { return m_NombreTercero; }
			set 
			{
				m_changed=true;
				m_NombreTercero = value;
			}
		}

		/// <summary>
		/// Attribute for access the LiquidacionRutasCombustible's floGalones value (decimal)
		/// </summary>
		[DataMember]
		public decimal? floGalones
		{
			get { return m_floGalones; }
			set 
			{
				m_changed=true;
				m_floGalones = value;
			}
		}

		/// <summary>
		/// Attribute for access the LiquidacionRutasCombustible's curValorGalon value (decimal)
		/// </summary>
		[DataMember]
		public decimal? curValorGalon
		{
			get { return m_curValorGalon; }
			set 
			{
				m_changed=true;
				m_curValorGalon = value;
			}
		}

		/// <summary>
		/// Attribute for access the LiquidacionRutasCombustible's cutCombustible value (decimal)
		/// </summary>
		[DataMember]
		public decimal? cutCombustible
		{
			get { return m_cutCombustible; }
			set 
			{
				m_changed=true;
				m_cutCombustible = value;
			}
		}

		/// <summary>
		/// Attribute for access the LiquidacionRutasCombustible's nitTerceroComplentario value (string)
		/// </summary>
		[DataMember]
		public string nitTerceroComplentario
		{
			get { return m_nitTerceroComplentario; }
			set 
			{
				m_changed=true;
				m_nitTerceroComplentario = value;
			}
		}

		/// <summary>
		/// Attribute for access the LiquidacionRutasCombustible's NombreTerceroComplementario value (string)
		/// </summary>
		[DataMember]
		public string NombreTerceroComplementario
		{
			get { return m_NombreTerceroComplementario; }
			set 
			{
				m_changed=true;
				m_NombreTerceroComplementario = value;
			}
		}

		/// <summary>
		/// Attribute for access the LiquidacionRutasCombustible's floGalonesComplementario value (decimal)
		/// </summary>
		[DataMember]
		public decimal? floGalonesComplementario
		{
			get { return m_floGalonesComplementario; }
			set 
			{
				m_changed=true;
				m_floGalonesComplementario = value;
			}
		}

		/// <summary>
		/// Attribute for access the LiquidacionRutasCombustible's curValorGalonComplentario value (decimal)
		/// </summary>
		[DataMember]
		public decimal? curValorGalonComplentario
		{
			get { return m_curValorGalonComplentario; }
			set 
			{
				m_changed=true;
				m_curValorGalonComplentario = value;
			}
		}

		/// <summary>
		/// Attribute for access the LiquidacionRutasCombustible's cutCombustibleComplementario value (decimal)
		/// </summary>
		[DataMember]
		public decimal? cutCombustibleComplementario
		{
			get { return m_cutCombustibleComplementario; }
			set 
			{
				m_changed=true;
				m_cutCombustibleComplementario = value;
			}
		}

		/// <summary>
		/// Attribute for access the LiquidacionRutasCombustible's strObservaciones value (string)
		/// </summary>
		[DataMember]
		public string strObservaciones
		{
			get { return m_strObservaciones; }
			set 
			{
				m_changed=true;
				m_strObservaciones = value;
			}
		}

		/// <summary>
		/// Attribute for access the LiquidacionRutasCombustible's Codigo value (long)
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
				case "lngIdRegistrRutaItemId": return lngIdRegistrRutaItemId;
				case "lngIdRegistro": return lngIdRegistro;
				case "lngIdRegistrRuta": return lngIdRegistrRuta;
				case "intRowRegistro": return intRowRegistro;
				case "strRutaAnticipoGrupoOrigen": return strRutaAnticipoGrupoOrigen;
				case "strRutaAnticipoGrupoDestino": return strRutaAnticipoGrupoDestino;
				case "nitTercero": return nitTercero;
				case "NombreTercero": return NombreTercero;
				case "floGalones": return floGalones;
				case "curValorGalon": return curValorGalon;
				case "cutCombustible": return cutCombustible;
				case "nitTerceroComplentario": return nitTerceroComplentario;
				case "NombreTerceroComplementario": return NombreTerceroComplementario;
				case "floGalonesComplementario": return floGalonesComplementario;
				case "curValorGalonComplentario": return curValorGalonComplentario;
				case "cutCombustibleComplementario": return cutCombustibleComplementario;
				case "strObservaciones": return strObservaciones;
				case "Codigo": return Codigo;
				default: return null;
			}
		}

		public Type GetAttributeType(string pattribute)
		{
			return LiquidacionRutasCombustibleController.Instance.GetMethodType(pattribute, this);
		}

		public string GetSqlKey()
		{
			return "[Codigo] = " + Codigo.ToString();
		}
		#endregion

	}

	#endregion

	#region LiquidacionRutasCombustibleList object

	/// <summary>
	/// Class for reading and access a list of LiquidacionRutasCombustible object
	/// </summary>
	[CollectionDataContract]
	public partial class LiquidacionRutasCombustibleList : List<LiquidacionRutasCombustible>
	{

		/// <summary>
		/// Default constructor
		/// </summary>
		public LiquidacionRutasCombustibleList()
		{
		}
	}

	#endregion

}
