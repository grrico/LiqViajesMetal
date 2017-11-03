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
	#region Usuarios object

	[DataContract]
	public partial class Usuarios : IDTOObject
	{
		/// <summary>
		/// Default constructor
		/// </summary>
		public Usuarios()
		{
			m_lngIdUsuario = 0;
			m_strLogin = null;
			m_strNombre = null;
			m_strPassword = null;
			m_dtmFechaSistema = null;
			m_Excell = false;
			m_Modifica_gastos = false;
			m_Modifica_cd = false;
			m_changed=false;
		}
		        //Return the table name of object
		        public string TableName()
		        {
		            return "tblUsuarios";
		        }
		#region Undo 
		// Internal class for storing changes
		private Usuarios m_oldUsuarios;
		public void GenerateUndo()
		{
			m_oldUsuarios=new Usuarios();
			m_oldUsuarios.m_lngIdUsuario = m_lngIdUsuario;
			m_oldUsuarios.strLogin = m_strLogin;
			m_oldUsuarios.strNombre = m_strNombre;
			m_oldUsuarios.strPassword = m_strPassword;
			m_oldUsuarios.dtmFechaSistema = m_dtmFechaSistema;
			m_oldUsuarios.Excell = m_Excell;
			m_oldUsuarios.Modifica_gastos = m_Modifica_gastos;
			m_oldUsuarios.Modifica_cd = m_Modifica_cd;
		}

		public Usuarios OldUsuarios
		{
			get { return m_oldUsuarios;}
		}
		// Return the changed fields
		public string[] FieldChanged()
		{
			List<string> fields=new List<string>();
			if (m_oldUsuarios.strLogin != m_strLogin) fields.Add("strLogin");
			if (m_oldUsuarios.strNombre != m_strNombre) fields.Add("strNombre");
			if (m_oldUsuarios.strPassword != m_strPassword) fields.Add("strPassword");
			if (m_oldUsuarios.dtmFechaSistema != m_dtmFechaSistema) fields.Add("dtmFechaSistema");
			if (m_oldUsuarios.Excell != m_Excell) fields.Add("Excell");
			if (m_oldUsuarios.Modifica_gastos != m_Modifica_gastos) fields.Add("Modifica_gastos");
			if (m_oldUsuarios.Modifica_cd != m_Modifica_cd) fields.Add("Modifica_cd");
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


		// Field for storing the Usuarios's strLogin value
		private string m_strLogin;

		// Field for storing the Usuarios's strNombre value
		private string m_strNombre;

		// Field for storing the Usuarios's strPassword value
		private string m_strPassword;

		// Field for storing the Usuarios's dtmFechaSistema value
		private DateTime? m_dtmFechaSistema;

		// Field for storing the Usuarios's Excell value
		private bool? m_Excell;

		// Field for storing the Usuarios's Modifica_gastos value
		private bool? m_Modifica_gastos;

		// Field for storing the Usuarios's Modifica_cd value
		private bool? m_Modifica_cd;

		// Field for storing the Usuarios's lngIdUsuario value
		private int m_lngIdUsuario;

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
		/// Attribute for access the Usuarios's strLogin value (string)
		/// </summary>
		[DataMember]
		public string strLogin
		{
			get { return m_strLogin; }
			set 
			{
				m_changed=true;
				m_strLogin = value;
			}
		}

		/// <summary>
		/// Attribute for access the Usuarios's strNombre value (string)
		/// </summary>
		[DataMember]
		public string strNombre
		{
			get { return m_strNombre; }
			set 
			{
				m_changed=true;
				m_strNombre = value;
			}
		}

		/// <summary>
		/// Attribute for access the Usuarios's strPassword value (string)
		/// </summary>
		[DataMember]
		public string strPassword
		{
			get { return m_strPassword; }
			set 
			{
				m_changed=true;
				m_strPassword = value;
			}
		}

		/// <summary>
		/// Attribute for access the Usuarios's dtmFechaSistema value (DateTime)
		/// </summary>
		[DataMember]
		public DateTime? dtmFechaSistema
		{
			get { return m_dtmFechaSistema; }
			set 
			{
				m_changed=true;
				m_dtmFechaSistema = value;
			}
		}

		/// <summary>
		/// Attribute for access the Usuarios's Excell value (bool)
		/// </summary>
		[DataMember]
		public bool? Excell
		{
			get { return m_Excell; }
			set 
			{
				m_changed=true;
				m_Excell = value;
			}
		}

		/// <summary>
		/// Attribute for access the Usuarios's Modifica_gastos value (bool)
		/// </summary>
		[DataMember]
		public bool? Modifica_gastos
		{
			get { return m_Modifica_gastos; }
			set 
			{
				m_changed=true;
				m_Modifica_gastos = value;
			}
		}

		/// <summary>
		/// Attribute for access the Usuarios's Modifica_cd value (bool)
		/// </summary>
		[DataMember]
		public bool? Modifica_cd
		{
			get { return m_Modifica_cd; }
			set 
			{
				m_changed=true;
				m_Modifica_cd = value;
			}
		}

		/// <summary>
		/// Attribute for access the Usuarios's lngIdUsuario value (int)
		/// </summary>
		[DataMember]
		public int lngIdUsuario
		{
			get { return m_lngIdUsuario; }
			set 
			{
				m_changed=true;
				m_lngIdUsuario = value;
			}
		}

		public object GetAttribute(string pattribute)
		{
			switch (pattribute)
			{
				case "strLogin": return strLogin;
				case "strNombre": return strNombre;
				case "strPassword": return strPassword;
				case "dtmFechaSistema": return dtmFechaSistema;
				case "Excell": return Excell;
				case "Modifica_gastos": return Modifica_gastos;
				case "Modifica_cd": return Modifica_cd;
				case "lngIdUsuario": return lngIdUsuario;
				default: return null;
			}
		}

		public Type GetAttributeType(string pattribute)
		{
			return UsuariosController.Instance.GetMethodType(pattribute, this);
		}

		public string GetSqlKey()
		{
			return "[lngIdUsuario] = " + lngIdUsuario.ToString();
		}
		#endregion

	}

	#endregion

	#region UsuariosList object

	/// <summary>
	/// Class for reading and access a list of Usuarios object
	/// </summary>
	[CollectionDataContract]
	public partial class UsuariosList : List<Usuarios>
	{

		/// <summary>
		/// Default constructor
		/// </summary>
		public UsuariosList()
		{
		}
	}

	#endregion

}
