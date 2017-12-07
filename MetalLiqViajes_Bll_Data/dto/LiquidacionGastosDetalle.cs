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
	#region LiquidacionGastosDetalle object

	[DataContract]
	public partial class LiquidacionGastosDetalle : IDTOObject
	{
		/// <summary>
		/// Default constructor
		/// </summary>
		public LiquidacionGastosDetalle()
		{
			m_Codigo = 0;
			m_RegistrRutaItemId = null;
			m_RegistroViaje = null;
			m_RegistroRuta = null;
			m_RowRegistro = null;
			m_Cuenta = null;
			m_NitTercero = null;
			m_FechaCrea = null;
			m_ValorAdicional = null;
			m_Observacion = null;
			m_changed=false;
		}
		        //Return the table name of object
		        public string TableName()
		        {
		            return "tblLiquidacionGastosDetalle";
		        }
		#region Undo 
		// Internal class for storing changes
		private LiquidacionGastosDetalle m_oldLiquidacionGastosDetalle;
		public void GenerateUndo()
		{
			m_oldLiquidacionGastosDetalle=new LiquidacionGastosDetalle();
			m_oldLiquidacionGastosDetalle.m_Codigo = m_Codigo;
			m_oldLiquidacionGastosDetalle.RegistrRutaItemId = m_RegistrRutaItemId;
			m_oldLiquidacionGastosDetalle.RegistroViaje = m_RegistroViaje;
			m_oldLiquidacionGastosDetalle.RegistroRuta = m_RegistroRuta;
			m_oldLiquidacionGastosDetalle.RowRegistro = m_RowRegistro;
			m_oldLiquidacionGastosDetalle.Cuenta = m_Cuenta;
			m_oldLiquidacionGastosDetalle.NitTercero = m_NitTercero;
			m_oldLiquidacionGastosDetalle.FechaCrea = m_FechaCrea;
			m_oldLiquidacionGastosDetalle.ValorAdicional = m_ValorAdicional;
			m_oldLiquidacionGastosDetalle.Observacion = m_Observacion;
		}

		public LiquidacionGastosDetalle OldLiquidacionGastosDetalle
		{
			get { return m_oldLiquidacionGastosDetalle;}
		}
		// Return the changed fields
		public string[] FieldChanged()
		{
			List<string> fields=new List<string>();
			if (m_oldLiquidacionGastosDetalle.RegistrRutaItemId != m_RegistrRutaItemId) fields.Add("RegistrRutaItemId");
			if (m_oldLiquidacionGastosDetalle.RegistroViaje != m_RegistroViaje) fields.Add("RegistroViaje");
			if (m_oldLiquidacionGastosDetalle.RegistroRuta != m_RegistroRuta) fields.Add("RegistroRuta");
			if (m_oldLiquidacionGastosDetalle.RowRegistro != m_RowRegistro) fields.Add("RowRegistro");
			if (m_oldLiquidacionGastosDetalle.Cuenta != m_Cuenta) fields.Add("Cuenta");
			if (m_oldLiquidacionGastosDetalle.NitTercero != m_NitTercero) fields.Add("NitTercero");
			if (m_oldLiquidacionGastosDetalle.FechaCrea != m_FechaCrea) fields.Add("FechaCrea");
			if (m_oldLiquidacionGastosDetalle.ValorAdicional != m_ValorAdicional) fields.Add("ValorAdicional");
			if (m_oldLiquidacionGastosDetalle.Observacion != m_Observacion) fields.Add("Observacion");
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


		// Field for storing the LiquidacionGastosDetalle's Codigo value
		private long m_Codigo;

		// Field for storing the LiquidacionGastosDetalle's RegistrRutaItemId value
		private long? m_RegistrRutaItemId;

		// Field for storing the LiquidacionGastosDetalle's RegistroViaje value
		private long? m_RegistroViaje;

		// Field for storing the LiquidacionGastosDetalle's RegistroRuta value
		private long? m_RegistroRuta;

		// Field for storing the LiquidacionGastosDetalle's RowRegistro value
		private int? m_RowRegistro;

		// Field for storing the LiquidacionGastosDetalle's Cuenta value
		private string m_Cuenta;

		// Field for storing the LiquidacionGastosDetalle's NitTercero value
		private string m_NitTercero;

		// Field for storing the LiquidacionGastosDetalle's FechaCrea value
		private DateTime? m_FechaCrea;

		// Field for storing the LiquidacionGastosDetalle's ValorAdicional value
		private decimal? m_ValorAdicional;

		// Field for storing the LiquidacionGastosDetalle's Observacion value
		private string m_Observacion;

		// Evaluate changed state
		private bool m_changed=false;
		// Field for storing the reference to LiquidacionGastos accessed by RegistrRutaItemId, RegistroViaje, RegistroRuta, Cuenta, RowRegistro
		private LiquidacionGastos m_LiquidacionGastos;


		#endregion

		#region Attributes

		// Return if object changed
		public bool Changed
		{
			get { return m_changed;}
			set { m_changed=value;}
		}
		/// <summary>
		/// Attribute for access the LiquidacionGastosDetalle's Codigo value (long)
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

		/// <summary>
		/// Attribute for access the LiquidacionGastosDetalle's RegistrRutaItemId value (long)
		/// </summary>
		[DataMember]
		public long? RegistrRutaItemId
		{
			get { return m_RegistrRutaItemId; }
			set
			{
				m_changed=true;
				m_RegistrRutaItemId = value;

				if ((m_LiquidacionGastos != null) && (m_LiquidacionGastos.lngIdRegistrRutaItemId != m_RegistrRutaItemId))
				{
					// we need to reset the reference because it is now invalid
					m_LiquidacionGastos = null;
				}
			}
		}

		/// <summary>
		/// Attribute for access the LiquidacionGastosDetalle's RegistroViaje value (long)
		/// </summary>
		[DataMember]
		public long? RegistroViaje
		{
			get { return m_RegistroViaje; }
			set
			{
				m_changed=true;
				m_RegistroViaje = value;

				if ((m_LiquidacionGastos != null) && (m_LiquidacionGastos.lngIdRegistroViaje != m_RegistroViaje))
				{
					// we need to reset the reference because it is now invalid
					m_LiquidacionGastos = null;
				}
			}
		}

		/// <summary>
		/// Attribute for access the LiquidacionGastosDetalle's RegistroRuta value (long)
		/// </summary>
		[DataMember]
		public long? RegistroRuta
		{
			get { return m_RegistroRuta; }
			set
			{
				m_changed=true;
				m_RegistroRuta = value;

				if ((m_LiquidacionGastos != null) && (m_LiquidacionGastos.lngIdRegistrRuta != m_RegistroRuta))
				{
					// we need to reset the reference because it is now invalid
					m_LiquidacionGastos = null;
				}
			}
		}

		/// <summary>
		/// Attribute for access the LiquidacionGastosDetalle's RowRegistro value (int)
		/// </summary>
		[DataMember]
		public int? RowRegistro
		{
			get { return m_RowRegistro; }
			set
			{
				m_changed=true;
				m_RowRegistro = value;

				if ((m_LiquidacionGastos != null) && (m_LiquidacionGastos.intRowRegistro != m_RowRegistro))
				{
					// we need to reset the reference because it is now invalid
					m_LiquidacionGastos = null;
				}
			}
		}

		/// <summary>
		/// Attribute for access the LiquidacionGastosDetalle's Cuenta value (string)
		/// </summary>
		[DataMember]
		public string Cuenta
		{
			get { return m_Cuenta; }
			set
			{
				m_changed=true;
				m_Cuenta = value;

				if ((m_LiquidacionGastos != null) && (m_LiquidacionGastos.strCuenta != m_Cuenta))
				{
					// we need to reset the reference because it is now invalid
					m_LiquidacionGastos = null;
				}
			}
		}

		/// <summary>
		/// Attribute for access the LiquidacionGastosDetalle's NitTercero value (string)
		/// </summary>
		[DataMember]
		public string NitTercero
		{
			get { return m_NitTercero; }
			set 
			{
				m_changed=true;
				m_NitTercero = value;
			}
		}

		/// <summary>
		/// Attribute for access the LiquidacionGastosDetalle's FechaCrea value (DateTime)
		/// </summary>
		[DataMember]
		public DateTime? FechaCrea
		{
			get { return m_FechaCrea; }
			set 
			{
				m_changed=true;
				m_FechaCrea = value;
			}
		}

		/// <summary>
		/// Attribute for access the LiquidacionGastosDetalle's ValorAdicional value (decimal)
		/// </summary>
		[DataMember]
		public decimal? ValorAdicional
		{
			get { return m_ValorAdicional; }
			set 
			{
				m_changed=true;
				m_ValorAdicional = value;
			}
		}

		/// <summary>
		/// Attribute for access the LiquidacionGastosDetalle's Observacion value (string)
		/// </summary>
		[DataMember]
		public string Observacion
		{
			get { return m_Observacion; }
			set 
			{
				m_changed=true;
				m_Observacion = value;
			}
		}

		public object GetAttribute(string pattribute)
		{
			switch (pattribute)
			{
				case "Codigo": return Codigo;
				case "RegistrRutaItemId": return RegistrRutaItemId;
				case "RegistroViaje": return RegistroViaje;
				case "RegistroRuta": return RegistroRuta;
				case "RowRegistro": return RowRegistro;
				case "Cuenta": return Cuenta;
				case "NitTercero": return NitTercero;
				case "FechaCrea": return FechaCrea;
				case "ValorAdicional": return ValorAdicional;
				case "Observacion": return Observacion;
				default: return null;
			}
		}

		public Type GetAttributeType(string pattribute)
		{
			return LiquidacionGastosDetalleController.Instance.GetMethodType(pattribute, this);
		}

		public string GetSqlKey()
		{
			return "[Codigo] = " + Codigo.ToString();
		}
		/// <summary>
		/// Gets or sets the reference to LiquidacionGastos accessed by RegistrRutaItemId, RegistroViaje, RegistroRuta, Cuenta, RowRegistro
		/// </summary>
		/// <remarks>
		/// Also updates related field values
		/// </remarks>
		public LiquidacionGastos LiquidacionGastos
		{
			get
			{
				if (m_LiquidacionGastos == null)
				{
					if (m_RegistrRutaItemId != null)
					{
						if (m_RegistroViaje != null)
						{
							if (m_RegistroRuta != null)
							{
								if (m_Cuenta != null)
								{
									if (m_RowRegistro != null)
									{
										m_LiquidacionGastos = LiquidacionGastosController.Instance.Get((long)m_RegistrRutaItemId,(long)m_RegistroViaje,(long)m_RegistroRuta,(string)m_Cuenta,(int)m_RowRegistro);
									}
								}
							}
						}
					}
				}

				return m_LiquidacionGastos;
			}

			set
			{
				m_LiquidacionGastos = value;

				if (m_LiquidacionGastos != null)
				{
					this.m_RegistrRutaItemId = m_LiquidacionGastos.lngIdRegistrRutaItemId;
					this.m_RegistroViaje = m_LiquidacionGastos.lngIdRegistroViaje;
					this.m_RegistroRuta = m_LiquidacionGastos.lngIdRegistrRuta;
					this.m_Cuenta = m_LiquidacionGastos.strCuenta;
					this.m_RowRegistro = m_LiquidacionGastos.intRowRegistro;
				}
			}
		}

		#endregion

	}

	#endregion

	#region LiquidacionGastosDetalleList object

	/// <summary>
	/// Class for reading and access a list of LiquidacionGastosDetalle object
	/// </summary>
	[CollectionDataContract]
	public partial class LiquidacionGastosDetalleList : List<LiquidacionGastosDetalle>
	{

		/// <summary>
		/// Default constructor
		/// </summary>
		public LiquidacionGastosDetalleList()
		{
		}
	}

	#endregion

}
