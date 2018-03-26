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
	#region VentasFlotaDetalle object

	[DataContract]
	public partial class VentasFlotaDetalle : IDTOObject
	{
		/// <summary>
		/// Default constructor
		/// </summary>
		public VentasFlotaDetalle()
		{
			m_Recibo = 0;
			m_IdEDS = null;
			m_Factura = null;
			m_Tipo = null;
			m_Numero = null;
			m_Tipo52v = null;
			m_Numero52v = null;
			m_Nit = null;
			m_Seq = null;
			m_Cuenta = null;
			m_Fecha = null;
			m_Hora = null;
			m_NombreCliente = null;
			m_Estacion = null;
			m_TipoEstacion = null;
			m_Destinatario = null;
			m_Ciudad = null;
			m_Placa = null;
			m_Producto = null;
			m_Cantidad = null;
			m_Precio = null;
			m_TotalVentas = null;
			m_PrecioEspecial = null;
			m_TotalFactura = null;
			m_Descuento = null;
			m_Kilometraje = null;
			m_UnidadVenta = null;
			m_TipoVenta = null;
			m_changed=false;
		}
		        //Return the table name of object
		        public string TableName()
		        {
		            return "VentasFlotaDetalle";
		        }
		#region Undo 
		// Internal class for storing changes
		private VentasFlotaDetalle m_oldVentasFlotaDetalle;
		public void GenerateUndo()
		{
			m_oldVentasFlotaDetalle=new VentasFlotaDetalle();
			m_oldVentasFlotaDetalle.m_Recibo = m_Recibo;
			m_oldVentasFlotaDetalle.IdEDS = m_IdEDS;
			m_oldVentasFlotaDetalle.Factura = m_Factura;
			m_oldVentasFlotaDetalle.Tipo = m_Tipo;
			m_oldVentasFlotaDetalle.Numero = m_Numero;
			m_oldVentasFlotaDetalle.Tipo52v = m_Tipo52v;
			m_oldVentasFlotaDetalle.Numero52v = m_Numero52v;
			m_oldVentasFlotaDetalle.Nit = m_Nit;
			m_oldVentasFlotaDetalle.Seq = m_Seq;
			m_oldVentasFlotaDetalle.Cuenta = m_Cuenta;
			m_oldVentasFlotaDetalle.Fecha = m_Fecha;
			m_oldVentasFlotaDetalle.Hora = m_Hora;
			m_oldVentasFlotaDetalle.NombreCliente = m_NombreCliente;
			m_oldVentasFlotaDetalle.Estacion = m_Estacion;
			m_oldVentasFlotaDetalle.TipoEstacion = m_TipoEstacion;
			m_oldVentasFlotaDetalle.Destinatario = m_Destinatario;
			m_oldVentasFlotaDetalle.Ciudad = m_Ciudad;
			m_oldVentasFlotaDetalle.Placa = m_Placa;
			m_oldVentasFlotaDetalle.Producto = m_Producto;
			m_oldVentasFlotaDetalle.Cantidad = m_Cantidad;
			m_oldVentasFlotaDetalle.Precio = m_Precio;
			m_oldVentasFlotaDetalle.TotalVentas = m_TotalVentas;
			m_oldVentasFlotaDetalle.PrecioEspecial = m_PrecioEspecial;
			m_oldVentasFlotaDetalle.TotalFactura = m_TotalFactura;
			m_oldVentasFlotaDetalle.Descuento = m_Descuento;
			m_oldVentasFlotaDetalle.Kilometraje = m_Kilometraje;
			m_oldVentasFlotaDetalle.UnidadVenta = m_UnidadVenta;
			m_oldVentasFlotaDetalle.TipoVenta = m_TipoVenta;
		}

		public VentasFlotaDetalle OldVentasFlotaDetalle
		{
			get { return m_oldVentasFlotaDetalle;}
		}
		// Return the changed fields
		public string[] FieldChanged()
		{
			List<string> fields=new List<string>();
			if (m_oldVentasFlotaDetalle.IdEDS != m_IdEDS) fields.Add("IdEDS");
			if (m_oldVentasFlotaDetalle.Factura != m_Factura) fields.Add("Factura");
			if (m_oldVentasFlotaDetalle.Tipo != m_Tipo) fields.Add("Tipo");
			if (m_oldVentasFlotaDetalle.Numero != m_Numero) fields.Add("Numero");
			if (m_oldVentasFlotaDetalle.Tipo52v != m_Tipo52v) fields.Add("Tipo52v");
			if (m_oldVentasFlotaDetalle.Numero52v != m_Numero52v) fields.Add("Numero52v");
			if (m_oldVentasFlotaDetalle.Nit != m_Nit) fields.Add("Nit");
			if (m_oldVentasFlotaDetalle.Seq != m_Seq) fields.Add("Seq");
			if (m_oldVentasFlotaDetalle.Cuenta != m_Cuenta) fields.Add("Cuenta");
			if (m_oldVentasFlotaDetalle.Fecha != m_Fecha) fields.Add("Fecha");
			if (m_oldVentasFlotaDetalle.Hora != m_Hora) fields.Add("Hora");
			if (m_oldVentasFlotaDetalle.NombreCliente != m_NombreCliente) fields.Add("NombreCliente");
			if (m_oldVentasFlotaDetalle.Estacion != m_Estacion) fields.Add("Estacion");
			if (m_oldVentasFlotaDetalle.TipoEstacion != m_TipoEstacion) fields.Add("TipoEstacion");
			if (m_oldVentasFlotaDetalle.Destinatario != m_Destinatario) fields.Add("Destinatario");
			if (m_oldVentasFlotaDetalle.Ciudad != m_Ciudad) fields.Add("Ciudad");
			if (m_oldVentasFlotaDetalle.Placa != m_Placa) fields.Add("Placa");
			if (m_oldVentasFlotaDetalle.Producto != m_Producto) fields.Add("Producto");
			if (m_oldVentasFlotaDetalle.Cantidad != m_Cantidad) fields.Add("Cantidad");
			if (m_oldVentasFlotaDetalle.Precio != m_Precio) fields.Add("Precio");
			if (m_oldVentasFlotaDetalle.TotalVentas != m_TotalVentas) fields.Add("TotalVentas");
			if (m_oldVentasFlotaDetalle.PrecioEspecial != m_PrecioEspecial) fields.Add("PrecioEspecial");
			if (m_oldVentasFlotaDetalle.TotalFactura != m_TotalFactura) fields.Add("TotalFactura");
			if (m_oldVentasFlotaDetalle.Descuento != m_Descuento) fields.Add("Descuento");
			if (m_oldVentasFlotaDetalle.Kilometraje != m_Kilometraje) fields.Add("Kilometraje");
			if (m_oldVentasFlotaDetalle.UnidadVenta != m_UnidadVenta) fields.Add("UnidadVenta");
			if (m_oldVentasFlotaDetalle.TipoVenta != m_TipoVenta) fields.Add("TipoVenta");
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


		// Field for storing the VentasFlotaDetalle's Recibo value
		private long m_Recibo;

		// Field for storing the VentasFlotaDetalle's IdEDS value
		private long? m_IdEDS;

		// Field for storing the VentasFlotaDetalle's Factura value
		private string m_Factura;

		// Field for storing the VentasFlotaDetalle's Tipo value
		private string m_Tipo;

		// Field for storing the VentasFlotaDetalle's Numero value
		private int? m_Numero;

		// Field for storing the VentasFlotaDetalle's Tipo52v value
		private string m_Tipo52v;

		// Field for storing the VentasFlotaDetalle's Numero52v value
		private int? m_Numero52v;

		// Field for storing the VentasFlotaDetalle's Nit value
		private decimal? m_Nit;

		// Field for storing the VentasFlotaDetalle's Seq value
		private int? m_Seq;

		// Field for storing the VentasFlotaDetalle's Cuenta value
		private string m_Cuenta;

		// Field for storing the VentasFlotaDetalle's Fecha value
		private DateTime? m_Fecha;

		// Field for storing the VentasFlotaDetalle's Hora value
		private string m_Hora;

		// Field for storing the VentasFlotaDetalle's NombreCliente value
		private string m_NombreCliente;

		// Field for storing the VentasFlotaDetalle's Estacion value
		private string m_Estacion;

		// Field for storing the VentasFlotaDetalle's TipoEstacion value
		private string m_TipoEstacion;

		// Field for storing the VentasFlotaDetalle's Destinatario value
		private string m_Destinatario;

		// Field for storing the VentasFlotaDetalle's Ciudad value
		private string m_Ciudad;

		// Field for storing the VentasFlotaDetalle's Placa value
		private string m_Placa;

		// Field for storing the VentasFlotaDetalle's Producto value
		private string m_Producto;

		// Field for storing the VentasFlotaDetalle's Cantidad value
		private decimal? m_Cantidad;

		// Field for storing the VentasFlotaDetalle's Precio value
		private decimal? m_Precio;

		// Field for storing the VentasFlotaDetalle's TotalVentas value
		private decimal? m_TotalVentas;

		// Field for storing the VentasFlotaDetalle's PrecioEspecial value
		private decimal? m_PrecioEspecial;

		// Field for storing the VentasFlotaDetalle's TotalFactura value
		private decimal? m_TotalFactura;

		// Field for storing the VentasFlotaDetalle's Descuento value
		private decimal? m_Descuento;

		// Field for storing the VentasFlotaDetalle's Kilometraje value
		private decimal? m_Kilometraje;

		// Field for storing the VentasFlotaDetalle's UnidadVenta value
		private string m_UnidadVenta;

		// Field for storing the VentasFlotaDetalle's TipoVenta value
		private string m_TipoVenta;

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
		/// Attribute for access the VentasFlotaDetalle's Recibo value (long)
		/// </summary>
		[DataMember]
		public long Recibo
		{
			get { return m_Recibo; }
			set 
			{
				m_changed=true;
				m_Recibo = value;
			}
		}

		/// <summary>
		/// Attribute for access the VentasFlotaDetalle's IdEDS value (long)
		/// </summary>
		[DataMember]
		public long? IdEDS
		{
			get { return m_IdEDS; }
			set 
			{
				m_changed=true;
				m_IdEDS = value;
			}
		}

		/// <summary>
		/// Attribute for access the VentasFlotaDetalle's Factura value (string)
		/// </summary>
		[DataMember]
		public string Factura
		{
			get { return m_Factura; }
			set 
			{
				m_changed=true;
				m_Factura = value;
			}
		}

		/// <summary>
		/// Attribute for access the VentasFlotaDetalle's Tipo value (string)
		/// </summary>
		[DataMember]
		public string Tipo
		{
			get { return m_Tipo; }
			set 
			{
				m_changed=true;
				m_Tipo = value;
			}
		}

		/// <summary>
		/// Attribute for access the VentasFlotaDetalle's Numero value (int)
		/// </summary>
		[DataMember]
		public int? Numero
		{
			get { return m_Numero; }
			set 
			{
				m_changed=true;
				m_Numero = value;
			}
		}

		/// <summary>
		/// Attribute for access the VentasFlotaDetalle's Tipo52v value (string)
		/// </summary>
		[DataMember]
		public string Tipo52v
		{
			get { return m_Tipo52v; }
			set 
			{
				m_changed=true;
				m_Tipo52v = value;
			}
		}

		/// <summary>
		/// Attribute for access the VentasFlotaDetalle's Numero52v value (int)
		/// </summary>
		[DataMember]
		public int? Numero52v
		{
			get { return m_Numero52v; }
			set 
			{
				m_changed=true;
				m_Numero52v = value;
			}
		}

		/// <summary>
		/// Attribute for access the VentasFlotaDetalle's Nit value (decimal)
		/// </summary>
		[DataMember]
		public decimal? Nit
		{
			get { return m_Nit; }
			set 
			{
				m_changed=true;
				m_Nit = value;
			}
		}

		/// <summary>
		/// Attribute for access the VentasFlotaDetalle's Seq value (int)
		/// </summary>
		[DataMember]
		public int? Seq
		{
			get { return m_Seq; }
			set 
			{
				m_changed=true;
				m_Seq = value;
			}
		}

		/// <summary>
		/// Attribute for access the VentasFlotaDetalle's Cuenta value (string)
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
		/// Attribute for access the VentasFlotaDetalle's Fecha value (DateTime)
		/// </summary>
		[DataMember]
		public DateTime? Fecha
		{
			get { return m_Fecha; }
			set 
			{
				m_changed=true;
				m_Fecha = value;
			}
		}

		/// <summary>
		/// Attribute for access the VentasFlotaDetalle's Hora value (string)
		/// </summary>
		[DataMember]
		public string Hora
		{
			get { return m_Hora; }
			set 
			{
				m_changed=true;
				m_Hora = value;
			}
		}

		/// <summary>
		/// Attribute for access the VentasFlotaDetalle's NombreCliente value (string)
		/// </summary>
		[DataMember]
		public string NombreCliente
		{
			get { return m_NombreCliente; }
			set 
			{
				m_changed=true;
				m_NombreCliente = value;
			}
		}

		/// <summary>
		/// Attribute for access the VentasFlotaDetalle's Estacion value (string)
		/// </summary>
		[DataMember]
		public string Estacion
		{
			get { return m_Estacion; }
			set 
			{
				m_changed=true;
				m_Estacion = value;
			}
		}

		/// <summary>
		/// Attribute for access the VentasFlotaDetalle's TipoEstacion value (string)
		/// </summary>
		[DataMember]
		public string TipoEstacion
		{
			get { return m_TipoEstacion; }
			set 
			{
				m_changed=true;
				m_TipoEstacion = value;
			}
		}

		/// <summary>
		/// Attribute for access the VentasFlotaDetalle's Destinatario value (string)
		/// </summary>
		[DataMember]
		public string Destinatario
		{
			get { return m_Destinatario; }
			set 
			{
				m_changed=true;
				m_Destinatario = value;
			}
		}

		/// <summary>
		/// Attribute for access the VentasFlotaDetalle's Ciudad value (string)
		/// </summary>
		[DataMember]
		public string Ciudad
		{
			get { return m_Ciudad; }
			set 
			{
				m_changed=true;
				m_Ciudad = value;
			}
		}

		/// <summary>
		/// Attribute for access the VentasFlotaDetalle's Placa value (string)
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
		/// Attribute for access the VentasFlotaDetalle's Producto value (string)
		/// </summary>
		[DataMember]
		public string Producto
		{
			get { return m_Producto; }
			set 
			{
				m_changed=true;
				m_Producto = value;
			}
		}

		/// <summary>
		/// Attribute for access the VentasFlotaDetalle's Cantidad value (decimal)
		/// </summary>
		[DataMember]
		public decimal? Cantidad
		{
			get { return m_Cantidad; }
			set 
			{
				m_changed=true;
				m_Cantidad = value;
			}
		}

		/// <summary>
		/// Attribute for access the VentasFlotaDetalle's Precio value (decimal)
		/// </summary>
		[DataMember]
		public decimal? Precio
		{
			get { return m_Precio; }
			set 
			{
				m_changed=true;
				m_Precio = value;
			}
		}

		/// <summary>
		/// Attribute for access the VentasFlotaDetalle's TotalVentas value (decimal)
		/// </summary>
		[DataMember]
		public decimal? TotalVentas
		{
			get { return m_TotalVentas; }
			set 
			{
				m_changed=true;
				m_TotalVentas = value;
			}
		}

		/// <summary>
		/// Attribute for access the VentasFlotaDetalle's PrecioEspecial value (decimal)
		/// </summary>
		[DataMember]
		public decimal? PrecioEspecial
		{
			get { return m_PrecioEspecial; }
			set 
			{
				m_changed=true;
				m_PrecioEspecial = value;
			}
		}

		/// <summary>
		/// Attribute for access the VentasFlotaDetalle's TotalFactura value (decimal)
		/// </summary>
		[DataMember]
		public decimal? TotalFactura
		{
			get { return m_TotalFactura; }
			set 
			{
				m_changed=true;
				m_TotalFactura = value;
			}
		}

		/// <summary>
		/// Attribute for access the VentasFlotaDetalle's Descuento value (decimal)
		/// </summary>
		[DataMember]
		public decimal? Descuento
		{
			get { return m_Descuento; }
			set 
			{
				m_changed=true;
				m_Descuento = value;
			}
		}

		/// <summary>
		/// Attribute for access the VentasFlotaDetalle's Kilometraje value (decimal)
		/// </summary>
		[DataMember]
		public decimal? Kilometraje
		{
			get { return m_Kilometraje; }
			set 
			{
				m_changed=true;
				m_Kilometraje = value;
			}
		}

		/// <summary>
		/// Attribute for access the VentasFlotaDetalle's UnidadVenta value (string)
		/// </summary>
		[DataMember]
		public string UnidadVenta
		{
			get { return m_UnidadVenta; }
			set 
			{
				m_changed=true;
				m_UnidadVenta = value;
			}
		}

		/// <summary>
		/// Attribute for access the VentasFlotaDetalle's TipoVenta value (string)
		/// </summary>
		[DataMember]
		public string TipoVenta
		{
			get { return m_TipoVenta; }
			set 
			{
				m_changed=true;
				m_TipoVenta = value;
			}
		}

		public object GetAttribute(string pattribute)
		{
			switch (pattribute)
			{
				case "Recibo": return Recibo;
				case "IdEDS": return IdEDS;
				case "Factura": return Factura;
				case "Tipo": return Tipo;
				case "Numero": return Numero;
				case "Tipo52v": return Tipo52v;
				case "Numero52v": return Numero52v;
				case "Nit": return Nit;
				case "Seq": return Seq;
				case "Cuenta": return Cuenta;
				case "Fecha": return Fecha;
				case "Hora": return Hora;
				case "NombreCliente": return NombreCliente;
				case "Estacion": return Estacion;
				case "TipoEstacion": return TipoEstacion;
				case "Destinatario": return Destinatario;
				case "Ciudad": return Ciudad;
				case "Placa": return Placa;
				case "Producto": return Producto;
				case "Cantidad": return Cantidad;
				case "Precio": return Precio;
				case "TotalVentas": return TotalVentas;
				case "PrecioEspecial": return PrecioEspecial;
				case "TotalFactura": return TotalFactura;
				case "Descuento": return Descuento;
				case "Kilometraje": return Kilometraje;
				case "UnidadVenta": return UnidadVenta;
				case "TipoVenta": return TipoVenta;
				default: return null;
			}
		}

		public Type GetAttributeType(string pattribute)
		{
			return VentasFlotaDetalleController.Instance.GetMethodType(pattribute, this);
		}

		public string GetSqlKey()
		{
			return "[Recibo] = " + Recibo.ToString();
		}
		#endregion

	}

	#endregion

	#region VentasFlotaDetalleList object

	/// <summary>
	/// Class for reading and access a list of VentasFlotaDetalle object
	/// </summary>
	[CollectionDataContract]
	public partial class VentasFlotaDetalleList : List<VentasFlotaDetalle>
	{

		/// <summary>
		/// Default constructor
		/// </summary>
		public VentasFlotaDetalleList()
		{
		}
	}

	#endregion

}
