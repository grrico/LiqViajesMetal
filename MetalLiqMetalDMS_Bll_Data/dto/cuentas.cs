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

namespace LiqMetalDMS_Bll_Data
{
	#region cuentas object

	[DataContract]
	public partial class cuentas : IDTOObject
	{
		/// <summary>
		/// Default constructor
		/// </summary>
		public cuentas()
		{
			m_id = 0;
			m_cuenta = "";
			m_descripcion = null;
			m_afe = false;
			m_cco = false;
			m_ter = false;
			m_doc = false;
			m_aju = false;
			m_bas = false;
			m_tei = false;
			m_partida = null;
			m_contrapartida = null;
			m_naturaleza = null;
			m_doc_inf = null;
			m_doc_sup = null;
			m_solo_interface = false;
			m_maneja_medios = null;
			m_literal_mm = null;
			m_codigo_mm = null;
			m_subcodigo_mm = null;
			m_porcentaje = null;
			m_ctas_dos_mm = null;
			m_exportado = null;
			m_cta_reversion = null;
			m_centro_me = null;
			m_diferencia_cambio = ' ';
			m_norma = ' ';
			m_inactiva = ' ';
			m_descripcion_niif = null;
			m_cuenta_niif = null;
			m_clasificacion_niif = ' ';
			m_changed=false;
		}
		        //Return the table name of object
		        public string TableName()
		        {
		            return "cuentas";
		        }
		#region Undo 
		// Internal class for storing changes
		private cuentas m_oldcuentas;
		public void GenerateUndo()
		{
			m_oldcuentas=new cuentas();
			m_oldcuentas.m_id = m_id;
			m_oldcuentas.m_cuenta = m_cuenta;
			m_oldcuentas.descripcion = m_descripcion;
			m_oldcuentas.afe = m_afe;
			m_oldcuentas.cco = m_cco;
			m_oldcuentas.ter = m_ter;
			m_oldcuentas.doc = m_doc;
			m_oldcuentas.aju = m_aju;
			m_oldcuentas.bas = m_bas;
			m_oldcuentas.tei = m_tei;
			m_oldcuentas.partida = m_partida;
			m_oldcuentas.contrapartida = m_contrapartida;
			m_oldcuentas.naturaleza = m_naturaleza;
			m_oldcuentas.doc_inf = m_doc_inf;
			m_oldcuentas.doc_sup = m_doc_sup;
			m_oldcuentas.solo_interface = m_solo_interface;
			m_oldcuentas.maneja_medios = m_maneja_medios;
			m_oldcuentas.literal_mm = m_literal_mm;
			m_oldcuentas.codigo_mm = m_codigo_mm;
			m_oldcuentas.subcodigo_mm = m_subcodigo_mm;
			m_oldcuentas.porcentaje = m_porcentaje;
			m_oldcuentas.ctas_dos_mm = m_ctas_dos_mm;
			m_oldcuentas.exportado = m_exportado;
			m_oldcuentas.cta_reversion = m_cta_reversion;
			m_oldcuentas.centro_me = m_centro_me;
			m_oldcuentas.diferencia_cambio = m_diferencia_cambio;
			m_oldcuentas.norma = m_norma;
			m_oldcuentas.inactiva = m_inactiva;
			m_oldcuentas.descripcion_niif = m_descripcion_niif;
			m_oldcuentas.cuenta_niif = m_cuenta_niif;
			m_oldcuentas.clasificacion_niif = m_clasificacion_niif;
		}

		public cuentas Oldcuentas
		{
			get { return m_oldcuentas;}
		}
		// Return the changed fields
		public string[] FieldChanged()
		{
			List<string> fields=new List<string>();
			if (m_oldcuentas.descripcion != m_descripcion) fields.Add("descripcion");
			if (m_oldcuentas.afe != m_afe) fields.Add("afe");
			if (m_oldcuentas.cco != m_cco) fields.Add("cco");
			if (m_oldcuentas.ter != m_ter) fields.Add("ter");
			if (m_oldcuentas.doc != m_doc) fields.Add("doc");
			if (m_oldcuentas.aju != m_aju) fields.Add("aju");
			if (m_oldcuentas.bas != m_bas) fields.Add("bas");
			if (m_oldcuentas.tei != m_tei) fields.Add("tei");
			if (m_oldcuentas.partida != m_partida) fields.Add("partida");
			if (m_oldcuentas.contrapartida != m_contrapartida) fields.Add("contrapartida");
			if (m_oldcuentas.naturaleza != m_naturaleza) fields.Add("naturaleza");
			if (m_oldcuentas.doc_inf != m_doc_inf) fields.Add("doc_inf");
			if (m_oldcuentas.doc_sup != m_doc_sup) fields.Add("doc_sup");
			if (m_oldcuentas.solo_interface != m_solo_interface) fields.Add("solo_interface");
			if (m_oldcuentas.maneja_medios != m_maneja_medios) fields.Add("maneja_medios");
			if (m_oldcuentas.literal_mm != m_literal_mm) fields.Add("literal_mm");
			if (m_oldcuentas.codigo_mm != m_codigo_mm) fields.Add("codigo_mm");
			if (m_oldcuentas.subcodigo_mm != m_subcodigo_mm) fields.Add("subcodigo_mm");
			if (m_oldcuentas.porcentaje != m_porcentaje) fields.Add("porcentaje");
			if (m_oldcuentas.ctas_dos_mm != m_ctas_dos_mm) fields.Add("ctas_dos_mm");
			if (m_oldcuentas.exportado != m_exportado) fields.Add("exportado");
			if (m_oldcuentas.cta_reversion != m_cta_reversion) fields.Add("cta_reversion");
			if (m_oldcuentas.centro_me != m_centro_me) fields.Add("centro_me");
			if (m_oldcuentas.diferencia_cambio != m_diferencia_cambio) fields.Add("diferencia_cambio");
			if (m_oldcuentas.norma != m_norma) fields.Add("norma");
			if (m_oldcuentas.inactiva != m_inactiva) fields.Add("inactiva");
			if (m_oldcuentas.descripcion_niif != m_descripcion_niif) fields.Add("descripcion_niif");
			if (m_oldcuentas.cuenta_niif != m_cuenta_niif) fields.Add("cuenta_niif");
			if (m_oldcuentas.clasificacion_niif != m_clasificacion_niif) fields.Add("clasificacion_niif");
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


		// Field for storing the cuentas's id value
		private int m_id;

		// Field for storing the cuentas's cuenta value
		private string m_cuenta;

		// Field for storing the cuentas's descripcion value
		private string m_descripcion;

		// Field for storing the cuentas's afe value
		private bool m_afe;

		// Field for storing the cuentas's cco value
		private bool m_cco;

		// Field for storing the cuentas's ter value
		private bool m_ter;

		// Field for storing the cuentas's doc value
		private bool m_doc;

		// Field for storing the cuentas's aju value
		private bool m_aju;

		// Field for storing the cuentas's bas value
		private bool m_bas;

		// Field for storing the cuentas's tei value
		private bool m_tei;

		// Field for storing the cuentas's partida value
		private string m_partida;

		// Field for storing the cuentas's contrapartida value
		private string m_contrapartida;

		// Field for storing the cuentas's naturaleza value
		private double? m_naturaleza;

		// Field for storing the cuentas's doc_inf value
		private double? m_doc_inf;

		// Field for storing the cuentas's doc_sup value
		private double? m_doc_sup;

		// Field for storing the cuentas's solo_interface value
		private bool m_solo_interface;

		// Field for storing the cuentas's maneja_medios value
		private string m_maneja_medios;

		// Field for storing the cuentas's literal_mm value
		private string m_literal_mm;

		// Field for storing the cuentas's codigo_mm value
		private string m_codigo_mm;

		// Field for storing the cuentas's subcodigo_mm value
		private string m_subcodigo_mm;

		// Field for storing the cuentas's porcentaje value
		private double? m_porcentaje;

		// Field for storing the cuentas's ctas_dos_mm value
		private string m_ctas_dos_mm;

		// Field for storing the cuentas's exportado value
		private string m_exportado;

		// Field for storing the cuentas's cta_reversion value
		private string m_cta_reversion;

		// Field for storing the cuentas's centro_me value
		private int? m_centro_me;

		// Field for storing the cuentas's diferencia_cambio value
		private char? m_diferencia_cambio;

		// Field for storing the cuentas's norma value
		private char m_norma;

		// Field for storing the cuentas's inactiva value
		private char m_inactiva;

		// Field for storing the cuentas's descripcion_niif value
		private string m_descripcion_niif;

		// Field for storing the cuentas's cuenta_niif value
		private string m_cuenta_niif;

		// Field for storing the cuentas's clasificacion_niif value
		private char? m_clasificacion_niif;

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
		/// Attribute for access the cuentas's id value (int)
		/// </summary>
		[DataMember]
		public int id
		{
			get { return m_id; }
			set 
			{
				m_changed=true;
				m_id = value;
			}
		}

		/// <summary>
		/// Attribute for access the cuentas's cuenta value (string)
		/// </summary>
		[DataMember]
		public string cuenta
		{
			get { return m_cuenta; }
			set 
			{
				m_changed=true;
				m_cuenta = value;
			}
		}

		/// <summary>
		/// Attribute for access the cuentas's descripcion value (string)
		/// </summary>
		[DataMember]
		public string descripcion
		{
			get { return m_descripcion; }
			set 
			{
				m_changed=true;
				m_descripcion = value;
			}
		}

		/// <summary>
		/// Attribute for access the cuentas's afe value (bool)
		/// </summary>
		[DataMember]
		public bool afe
		{
			get { return m_afe; }
			set 
			{
				m_changed=true;
				m_afe = value;
			}
		}

		/// <summary>
		/// Attribute for access the cuentas's cco value (bool)
		/// </summary>
		[DataMember]
		public bool cco
		{
			get { return m_cco; }
			set 
			{
				m_changed=true;
				m_cco = value;
			}
		}

		/// <summary>
		/// Attribute for access the cuentas's ter value (bool)
		/// </summary>
		[DataMember]
		public bool ter
		{
			get { return m_ter; }
			set 
			{
				m_changed=true;
				m_ter = value;
			}
		}

		/// <summary>
		/// Attribute for access the cuentas's doc value (bool)
		/// </summary>
		[DataMember]
		public bool doc
		{
			get { return m_doc; }
			set 
			{
				m_changed=true;
				m_doc = value;
			}
		}

		/// <summary>
		/// Attribute for access the cuentas's aju value (bool)
		/// </summary>
		[DataMember]
		public bool aju
		{
			get { return m_aju; }
			set 
			{
				m_changed=true;
				m_aju = value;
			}
		}

		/// <summary>
		/// Attribute for access the cuentas's bas value (bool)
		/// </summary>
		[DataMember]
		public bool bas
		{
			get { return m_bas; }
			set 
			{
				m_changed=true;
				m_bas = value;
			}
		}

		/// <summary>
		/// Attribute for access the cuentas's tei value (bool)
		/// </summary>
		[DataMember]
		public bool tei
		{
			get { return m_tei; }
			set 
			{
				m_changed=true;
				m_tei = value;
			}
		}

		/// <summary>
		/// Attribute for access the cuentas's partida value (string)
		/// </summary>
		[DataMember]
		public string partida
		{
			get { return m_partida; }
			set 
			{
				m_changed=true;
				m_partida = value;
			}
		}

		/// <summary>
		/// Attribute for access the cuentas's contrapartida value (string)
		/// </summary>
		[DataMember]
		public string contrapartida
		{
			get { return m_contrapartida; }
			set 
			{
				m_changed=true;
				m_contrapartida = value;
			}
		}

		/// <summary>
		/// Attribute for access the cuentas's naturaleza value (double)
		/// </summary>
		[DataMember]
		public double? naturaleza
		{
			get { return m_naturaleza; }
			set 
			{
				m_changed=true;
				m_naturaleza = value;
			}
		}

		/// <summary>
		/// Attribute for access the cuentas's doc_inf value (double)
		/// </summary>
		[DataMember]
		public double? doc_inf
		{
			get { return m_doc_inf; }
			set 
			{
				m_changed=true;
				m_doc_inf = value;
			}
		}

		/// <summary>
		/// Attribute for access the cuentas's doc_sup value (double)
		/// </summary>
		[DataMember]
		public double? doc_sup
		{
			get { return m_doc_sup; }
			set 
			{
				m_changed=true;
				m_doc_sup = value;
			}
		}

		/// <summary>
		/// Attribute for access the cuentas's solo_interface value (bool)
		/// </summary>
		[DataMember]
		public bool solo_interface
		{
			get { return m_solo_interface; }
			set 
			{
				m_changed=true;
				m_solo_interface = value;
			}
		}

		/// <summary>
		/// Attribute for access the cuentas's maneja_medios value (string)
		/// </summary>
		[DataMember]
		public string maneja_medios
		{
			get { return m_maneja_medios; }
			set 
			{
				m_changed=true;
				m_maneja_medios = value;
			}
		}

		/// <summary>
		/// Attribute for access the cuentas's literal_mm value (string)
		/// </summary>
		[DataMember]
		public string literal_mm
		{
			get { return m_literal_mm; }
			set 
			{
				m_changed=true;
				m_literal_mm = value;
			}
		}

		/// <summary>
		/// Attribute for access the cuentas's codigo_mm value (string)
		/// </summary>
		[DataMember]
		public string codigo_mm
		{
			get { return m_codigo_mm; }
			set 
			{
				m_changed=true;
				m_codigo_mm = value;
			}
		}

		/// <summary>
		/// Attribute for access the cuentas's subcodigo_mm value (string)
		/// </summary>
		[DataMember]
		public string subcodigo_mm
		{
			get { return m_subcodigo_mm; }
			set 
			{
				m_changed=true;
				m_subcodigo_mm = value;
			}
		}

		/// <summary>
		/// Attribute for access the cuentas's porcentaje value (double)
		/// </summary>
		[DataMember]
		public double? porcentaje
		{
			get { return m_porcentaje; }
			set 
			{
				m_changed=true;
				m_porcentaje = value;
			}
		}

		/// <summary>
		/// Attribute for access the cuentas's ctas_dos_mm value (string)
		/// </summary>
		[DataMember]
		public string ctas_dos_mm
		{
			get { return m_ctas_dos_mm; }
			set 
			{
				m_changed=true;
				m_ctas_dos_mm = value;
			}
		}

		/// <summary>
		/// Attribute for access the cuentas's exportado value (string)
		/// </summary>
		[DataMember]
		public string exportado
		{
			get { return m_exportado; }
			set 
			{
				m_changed=true;
				m_exportado = value;
			}
		}

		/// <summary>
		/// Attribute for access the cuentas's cta_reversion value (string)
		/// </summary>
		[DataMember]
		public string cta_reversion
		{
			get { return m_cta_reversion; }
			set 
			{
				m_changed=true;
				m_cta_reversion = value;
			}
		}

		/// <summary>
		/// Attribute for access the cuentas's centro_me value (int)
		/// </summary>
		[DataMember]
		public int? centro_me
		{
			get { return m_centro_me; }
			set 
			{
				m_changed=true;
				m_centro_me = value;
			}
		}

		/// <summary>
		/// Attribute for access the cuentas's diferencia_cambio value (char)
		/// </summary>
		[DataMember]
		public char? diferencia_cambio
		{
			get { return m_diferencia_cambio; }
			set 
			{
				m_changed=true;
				m_diferencia_cambio = value;
			}
		}

		/// <summary>
		/// Attribute for access the cuentas's norma value (char)
		/// </summary>
		[DataMember]
		public char norma
		{
			get { return m_norma; }
			set 
			{
				m_changed=true;
				m_norma = value;
			}
		}

		/// <summary>
		/// Attribute for access the cuentas's inactiva value (char)
		/// </summary>
		[DataMember]
		public char inactiva
		{
			get { return m_inactiva; }
			set 
			{
				m_changed=true;
				m_inactiva = value;
			}
		}

		/// <summary>
		/// Attribute for access the cuentas's descripcion_niif value (string)
		/// </summary>
		[DataMember]
		public string descripcion_niif
		{
			get { return m_descripcion_niif; }
			set 
			{
				m_changed=true;
				m_descripcion_niif = value;
			}
		}

		/// <summary>
		/// Attribute for access the cuentas's cuenta_niif value (string)
		/// </summary>
		[DataMember]
		public string cuenta_niif
		{
			get { return m_cuenta_niif; }
			set 
			{
				m_changed=true;
				m_cuenta_niif = value;
			}
		}

		/// <summary>
		/// Attribute for access the cuentas's clasificacion_niif value (char)
		/// </summary>
		[DataMember]
		public char? clasificacion_niif
		{
			get { return m_clasificacion_niif; }
			set 
			{
				m_changed=true;
				m_clasificacion_niif = value;
			}
		}

		public object GetAttribute(string pattribute)
		{
			switch (pattribute)
			{
				case "id": return id;
				case "cuenta": return cuenta;
				case "descripcion": return descripcion;
				case "afe": return afe;
				case "cco": return cco;
				case "ter": return ter;
				case "doc": return doc;
				case "aju": return aju;
				case "bas": return bas;
				case "tei": return tei;
				case "partida": return partida;
				case "contrapartida": return contrapartida;
				case "naturaleza": return naturaleza;
				case "doc_inf": return doc_inf;
				case "doc_sup": return doc_sup;
				case "solo_interface": return solo_interface;
				case "maneja_medios": return maneja_medios;
				case "literal_mm": return literal_mm;
				case "codigo_mm": return codigo_mm;
				case "subcodigo_mm": return subcodigo_mm;
				case "porcentaje": return porcentaje;
				case "ctas_dos_mm": return ctas_dos_mm;
				case "exportado": return exportado;
				case "cta_reversion": return cta_reversion;
				case "centro_me": return centro_me;
				case "diferencia_cambio": return diferencia_cambio;
				case "norma": return norma;
				case "inactiva": return inactiva;
				case "descripcion_niif": return descripcion_niif;
				case "cuenta_niif": return cuenta_niif;
				case "clasificacion_niif": return clasificacion_niif;
				default: return null;
			}
		}

		public Type GetAttributeType(string pattribute)
		{
			return cuentasController.Instance.GetMethodType(pattribute, this);
		}

		public string GetSqlKey()
		{
			return "[id] = " + id.ToString() + " AND [cuenta] = '" + cuenta.ToString()+ "'";
		}
		#endregion

	}

	#endregion

	#region cuentasList object

	/// <summary>
	/// Class for reading and access a list of cuentas object
	/// </summary>
	[CollectionDataContract]
	public partial class cuentasList : List<cuentas>
	{

		/// <summary>
		/// Default constructor
		/// </summary>
		public cuentasList()
		{
		}
	}

	#endregion

}
