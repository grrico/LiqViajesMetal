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
using Sinapsys.Datos;
using Microsoft.Practices.EnterpriseLibrary.Security.Cryptography;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Runtime.Serialization;

namespace LiqViajes_Bll_Data
{
	#region VentasFlotaDetalleController

	/// <summary>
	/// Class for convert data from database into object's data and vice versa
	/// </summary>
	public partial class VentasFlotaDetalleController//: ILatinodeController
	{
		/// <summary>
		/// Generic Constructor
		/// </summary>
		public VentasFlotaDetalleController()
		{
		}

		/// <summary>
		/// Instance accessor for this singleton
		/// </summary>
		private static VentasFlotaDetalleController MySingleObj;
		public static VentasFlotaDetalleController Instance
		{
			get
			{
				if (MySingleObj == null)
				{
					MySingleObj = new VentasFlotaDetalleController();
				}
				return MySingleObj;
			}
		}

		// Reads object's data from a DataRow
		private void ReadData(VentasFlotaDetalle ventasflotadetalle, DataRow dr,bool generateUndo=false)
		{
			try 
			{
				ventasflotadetalle.Recibo = (long) dr["Recibo"];
				ventasflotadetalle.IdEDS = dr.IsNull("IdEDS") ? null :(long?) dr["IdEDS"];
				ventasflotadetalle.Factura = dr.IsNull("Factura") ? null :(string) dr["Factura"];
				ventasflotadetalle.Tipo = dr.IsNull("Tipo") ? null :(string) dr["Tipo"];
				ventasflotadetalle.Numero = dr.IsNull("Numero") ? null :(int?) dr["Numero"];
				ventasflotadetalle.Tipo52v = dr.IsNull("Tipo52v") ? null :(string) dr["Tipo52v"];
				ventasflotadetalle.Numero52v = dr.IsNull("Numero52v") ? null :(int?) dr["Numero52v"];
				ventasflotadetalle.Nit = dr.IsNull("Nit") ? null :(decimal?) dr["Nit"];
				ventasflotadetalle.Seq = dr.IsNull("Seq") ? null :(int?) dr["Seq"];
				ventasflotadetalle.Cuenta = dr.IsNull("Cuenta") ? null :(string) dr["Cuenta"];
				ventasflotadetalle.Fecha = dr.IsNull("Fecha") ? null :(DateTime?) dr["Fecha"];
				ventasflotadetalle.Hora = dr.IsNull("Hora") ? null :(string) dr["Hora"];
				ventasflotadetalle.NombreCliente = dr.IsNull("NombreCliente") ? null :(string) dr["NombreCliente"];
				ventasflotadetalle.Estacion = dr.IsNull("Estacion") ? null :(string) dr["Estacion"];
				ventasflotadetalle.TipoEstacion = dr.IsNull("TipoEstacion") ? null :(string) dr["TipoEstacion"];
				ventasflotadetalle.Destinatario = dr.IsNull("Destinatario") ? null :(string) dr["Destinatario"];
				ventasflotadetalle.Ciudad = dr.IsNull("Ciudad") ? null :(string) dr["Ciudad"];
				ventasflotadetalle.Placa = dr.IsNull("Placa") ? null :(string) dr["Placa"];
				ventasflotadetalle.Producto = dr.IsNull("Producto") ? null :(string) dr["Producto"];
				ventasflotadetalle.Cantidad = dr.IsNull("Cantidad") ? null :(decimal?) dr["Cantidad"];
				ventasflotadetalle.Precio = dr.IsNull("Precio") ? null :(decimal?) dr["Precio"];
				ventasflotadetalle.TotalVentas = dr.IsNull("TotalVentas") ? null :(decimal?) dr["TotalVentas"];
				ventasflotadetalle.PrecioEspecial = dr.IsNull("PrecioEspecial") ? null :(decimal?) dr["PrecioEspecial"];
				ventasflotadetalle.TotalFactura = dr.IsNull("TotalFactura") ? null :(decimal?) dr["TotalFactura"];
				ventasflotadetalle.Descuento = dr.IsNull("Descuento") ? null :(decimal?) dr["Descuento"];
				ventasflotadetalle.Kilometraje = dr.IsNull("Kilometraje") ? null :(decimal?) dr["Kilometraje"];
				ventasflotadetalle.UnidadVenta = dr.IsNull("UnidadVenta") ? null :(string) dr["UnidadVenta"];
				ventasflotadetalle.TipoVenta = dr.IsNull("TipoVenta") ? null :(string) dr["TipoVenta"];
			}
			catch (Exception ex)
			{
				Utilidades.LogErrores(ex.Message + (ex.InnerException != null ? ex.InnerException.Message : ""), DataProvider.AplicacionNombre);
				throw ex;
			}
			if (generateUndo) ventasflotadetalle.GenerateUndo();
		}

		/// <summary>
		/// Create a new VentasFlotaDetalle object by passing a object
		/// </summary>
		public VentasFlotaDetalle Create(VentasFlotaDetalle ventasflotadetalle, Sinapsys.Datos.SQL datosTransaccion=null)
		{
			return Create(ventasflotadetalle.Recibo,ventasflotadetalle.IdEDS,ventasflotadetalle.Factura,ventasflotadetalle.Tipo,ventasflotadetalle.Numero,ventasflotadetalle.Tipo52v,ventasflotadetalle.Numero52v,ventasflotadetalle.Nit,ventasflotadetalle.Seq,ventasflotadetalle.Cuenta,ventasflotadetalle.Fecha,ventasflotadetalle.Hora,ventasflotadetalle.NombreCliente,ventasflotadetalle.Estacion,ventasflotadetalle.TipoEstacion,ventasflotadetalle.Destinatario,ventasflotadetalle.Ciudad,ventasflotadetalle.Placa,ventasflotadetalle.Producto,ventasflotadetalle.Cantidad,ventasflotadetalle.Precio,ventasflotadetalle.TotalVentas,ventasflotadetalle.PrecioEspecial,ventasflotadetalle.TotalFactura,ventasflotadetalle.Descuento,ventasflotadetalle.Kilometraje,ventasflotadetalle.UnidadVenta,ventasflotadetalle.TipoVenta,datosTransaccion);
		}

		/// <summary>
		/// Creates a new VentasFlotaDetalle object by passing all object's fields
		/// </summary>
		/// <param name="IdEDS">long that contents the IdEDS value for the VentasFlotaDetalle object</param>
		/// <param name="Factura">string that contents the Factura value for the VentasFlotaDetalle object</param>
		/// <param name="Tipo">string that contents the Tipo value for the VentasFlotaDetalle object</param>
		/// <param name="Numero">int that contents the Numero value for the VentasFlotaDetalle object</param>
		/// <param name="Tipo52v">string that contents the Tipo52v value for the VentasFlotaDetalle object</param>
		/// <param name="Numero52v">int that contents the Numero52v value for the VentasFlotaDetalle object</param>
		/// <param name="Nit">decimal that contents the Nit value for the VentasFlotaDetalle object</param>
		/// <param name="Seq">int that contents the Seq value for the VentasFlotaDetalle object</param>
		/// <param name="Cuenta">string that contents the Cuenta value for the VentasFlotaDetalle object</param>
		/// <param name="Fecha">DateTime that contents the Fecha value for the VentasFlotaDetalle object</param>
		/// <param name="Hora">string that contents the Hora value for the VentasFlotaDetalle object</param>
		/// <param name="NombreCliente">string that contents the NombreCliente value for the VentasFlotaDetalle object</param>
		/// <param name="Estacion">string that contents the Estacion value for the VentasFlotaDetalle object</param>
		/// <param name="TipoEstacion">string that contents the TipoEstacion value for the VentasFlotaDetalle object</param>
		/// <param name="Destinatario">string that contents the Destinatario value for the VentasFlotaDetalle object</param>
		/// <param name="Ciudad">string that contents the Ciudad value for the VentasFlotaDetalle object</param>
		/// <param name="Placa">string that contents the Placa value for the VentasFlotaDetalle object</param>
		/// <param name="Producto">string that contents the Producto value for the VentasFlotaDetalle object</param>
		/// <param name="Cantidad">decimal that contents the Cantidad value for the VentasFlotaDetalle object</param>
		/// <param name="Precio">decimal that contents the Precio value for the VentasFlotaDetalle object</param>
		/// <param name="TotalVentas">decimal that contents the TotalVentas value for the VentasFlotaDetalle object</param>
		/// <param name="PrecioEspecial">decimal that contents the PrecioEspecial value for the VentasFlotaDetalle object</param>
		/// <param name="TotalFactura">decimal that contents the TotalFactura value for the VentasFlotaDetalle object</param>
		/// <param name="Descuento">decimal that contents the Descuento value for the VentasFlotaDetalle object</param>
		/// <param name="Kilometraje">decimal that contents the Kilometraje value for the VentasFlotaDetalle object</param>
		/// <param name="UnidadVenta">string that contents the UnidadVenta value for the VentasFlotaDetalle object</param>
		/// <param name="TipoVenta">string that contents the TipoVenta value for the VentasFlotaDetalle object</param>
		/// <returns>One VentasFlotaDetalle object</returns>
		public VentasFlotaDetalle Create(long Recibo, long? IdEDS, string Factura, string Tipo, int? Numero, string Tipo52v, int? Numero52v, decimal? Nit, int? Seq, string Cuenta, DateTime? Fecha, string Hora, string NombreCliente, string Estacion, string TipoEstacion, string Destinatario, string Ciudad, string Placa, string Producto, decimal? Cantidad, decimal? Precio, decimal? TotalVentas, decimal? PrecioEspecial, decimal? TotalFactura, decimal? Descuento, decimal? Kilometraje, string UnidadVenta, string TipoVenta, Sinapsys.Datos.SQL datosTransaccion=null)
		{
			try 
			{
				VentasFlotaDetalle ventasflotadetalle = new VentasFlotaDetalle();

				ventasflotadetalle.Recibo = Recibo;
				ventasflotadetalle.IdEDS = IdEDS;
				ventasflotadetalle.Factura = Factura;
				ventasflotadetalle.Tipo = Tipo;
				ventasflotadetalle.Numero = Numero;
				ventasflotadetalle.Tipo52v = Tipo52v;
				ventasflotadetalle.Numero52v = Numero52v;
				ventasflotadetalle.Nit = Nit;
				ventasflotadetalle.Seq = Seq;
				ventasflotadetalle.Cuenta = Cuenta;
				ventasflotadetalle.Fecha = Fecha;
				ventasflotadetalle.Hora = Hora;
				ventasflotadetalle.NombreCliente = NombreCliente;
				ventasflotadetalle.Estacion = Estacion;
				ventasflotadetalle.TipoEstacion = TipoEstacion;
				ventasflotadetalle.Destinatario = Destinatario;
				ventasflotadetalle.Ciudad = Ciudad;
				ventasflotadetalle.Placa = Placa;
				ventasflotadetalle.Producto = Producto;
				ventasflotadetalle.Cantidad = Cantidad;
				ventasflotadetalle.Precio = Precio;
				ventasflotadetalle.TotalVentas = TotalVentas;
				ventasflotadetalle.PrecioEspecial = PrecioEspecial;
				ventasflotadetalle.TotalFactura = TotalFactura;
				ventasflotadetalle.Descuento = Descuento;
				ventasflotadetalle.Kilometraje = Kilometraje;
				ventasflotadetalle.UnidadVenta = UnidadVenta;
				ventasflotadetalle.TipoVenta = TipoVenta;
				VentasFlotaDetalleDataProvider.Instance.Create(Recibo, IdEDS, Factura, Tipo, Numero, Tipo52v, Numero52v, Nit, Seq, Cuenta, Fecha, Hora, NombreCliente, Estacion, TipoEstacion, Destinatario, Ciudad, Placa, Producto, Cantidad, Precio, TotalVentas, PrecioEspecial, TotalFactura, Descuento, Kilometraje, UnidadVenta, TipoVenta,"VentasFlotaDetalle");

				return ventasflotadetalle;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Updates an VentasFlotaDetalle object by passing all object's fields
		/// </summary>
		/// <param name="Recibo">long that contents the Recibo value for the VentasFlotaDetalle object</param>
		/// <param name="IdEDS">long that contents the IdEDS value for the VentasFlotaDetalle object</param>
		/// <param name="Factura">string that contents the Factura value for the VentasFlotaDetalle object</param>
		/// <param name="Tipo">string that contents the Tipo value for the VentasFlotaDetalle object</param>
		/// <param name="Numero">int that contents the Numero value for the VentasFlotaDetalle object</param>
		/// <param name="Tipo52v">string that contents the Tipo52v value for the VentasFlotaDetalle object</param>
		/// <param name="Numero52v">int that contents the Numero52v value for the VentasFlotaDetalle object</param>
		/// <param name="Nit">decimal that contents the Nit value for the VentasFlotaDetalle object</param>
		/// <param name="Seq">int that contents the Seq value for the VentasFlotaDetalle object</param>
		/// <param name="Cuenta">string that contents the Cuenta value for the VentasFlotaDetalle object</param>
		/// <param name="Fecha">DateTime that contents the Fecha value for the VentasFlotaDetalle object</param>
		/// <param name="Hora">string that contents the Hora value for the VentasFlotaDetalle object</param>
		/// <param name="NombreCliente">string that contents the NombreCliente value for the VentasFlotaDetalle object</param>
		/// <param name="Estacion">string that contents the Estacion value for the VentasFlotaDetalle object</param>
		/// <param name="TipoEstacion">string that contents the TipoEstacion value for the VentasFlotaDetalle object</param>
		/// <param name="Destinatario">string that contents the Destinatario value for the VentasFlotaDetalle object</param>
		/// <param name="Ciudad">string that contents the Ciudad value for the VentasFlotaDetalle object</param>
		/// <param name="Placa">string that contents the Placa value for the VentasFlotaDetalle object</param>
		/// <param name="Producto">string that contents the Producto value for the VentasFlotaDetalle object</param>
		/// <param name="Cantidad">decimal that contents the Cantidad value for the VentasFlotaDetalle object</param>
		/// <param name="Precio">decimal that contents the Precio value for the VentasFlotaDetalle object</param>
		/// <param name="TotalVentas">decimal that contents the TotalVentas value for the VentasFlotaDetalle object</param>
		/// <param name="PrecioEspecial">decimal that contents the PrecioEspecial value for the VentasFlotaDetalle object</param>
		/// <param name="TotalFactura">decimal that contents the TotalFactura value for the VentasFlotaDetalle object</param>
		/// <param name="Descuento">decimal that contents the Descuento value for the VentasFlotaDetalle object</param>
		/// <param name="Kilometraje">decimal that contents the Kilometraje value for the VentasFlotaDetalle object</param>
		/// <param name="UnidadVenta">string that contents the UnidadVenta value for the VentasFlotaDetalle object</param>
		/// <param name="TipoVenta">string that contents the TipoVenta value for the VentasFlotaDetalle object</param>
		public void Update(long Recibo, long? IdEDS, string Factura, string Tipo, int? Numero, string Tipo52v, int? Numero52v, decimal? Nit, int? Seq, string Cuenta, DateTime? Fecha, string Hora, string NombreCliente, string Estacion, string TipoEstacion, string Destinatario, string Ciudad, string Placa, string Producto, decimal? Cantidad, decimal? Precio, decimal? TotalVentas, decimal? PrecioEspecial, decimal? TotalFactura, decimal? Descuento, decimal? Kilometraje, string UnidadVenta, string TipoVenta, Sinapsys.Datos.SQL datosTransaccion=null)
		{
			try 
			{
				VentasFlotaDetalle new_values = new VentasFlotaDetalle();
				new_values.IdEDS = IdEDS;
				new_values.Factura = Factura;
				new_values.Tipo = Tipo;
				new_values.Numero = Numero;
				new_values.Tipo52v = Tipo52v;
				new_values.Numero52v = Numero52v;
				new_values.Nit = Nit;
				new_values.Seq = Seq;
				new_values.Cuenta = Cuenta;
				new_values.Fecha = Fecha;
				new_values.Hora = Hora;
				new_values.NombreCliente = NombreCliente;
				new_values.Estacion = Estacion;
				new_values.TipoEstacion = TipoEstacion;
				new_values.Destinatario = Destinatario;
				new_values.Ciudad = Ciudad;
				new_values.Placa = Placa;
				new_values.Producto = Producto;
				new_values.Cantidad = Cantidad;
				new_values.Precio = Precio;
				new_values.TotalVentas = TotalVentas;
				new_values.PrecioEspecial = PrecioEspecial;
				new_values.TotalFactura = TotalFactura;
				new_values.Descuento = Descuento;
				new_values.Kilometraje = Kilometraje;
				new_values.UnidadVenta = UnidadVenta;
				new_values.TipoVenta = TipoVenta;
				VentasFlotaDetalleDataProvider.Instance.Update(Recibo, IdEDS, Factura, Tipo, Numero, Tipo52v, Numero52v, Nit, Seq, Cuenta, Fecha, Hora, NombreCliente, Estacion, TipoEstacion, Destinatario, Ciudad, Placa, Producto, Cantidad, Precio, TotalVentas, PrecioEspecial, TotalFactura, Descuento, Kilometraje, UnidadVenta, TipoVenta,"VentasFlotaDetalle",datosTransaccion);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Updates an VentasFlotaDetalle object by passing one object's instance as reference
		/// </summary>
		/// <param name="ventasflotadetalle">An instance of VentasFlotaDetalle for reference</param>
		public void Update(VentasFlotaDetalle ventasflotadetalle,Sinapsys.Datos.SQL datosTransaccion=null)
		{
			Update(ventasflotadetalle.Recibo, ventasflotadetalle.IdEDS, ventasflotadetalle.Factura, ventasflotadetalle.Tipo, ventasflotadetalle.Numero, ventasflotadetalle.Tipo52v, ventasflotadetalle.Numero52v, ventasflotadetalle.Nit, ventasflotadetalle.Seq, ventasflotadetalle.Cuenta, ventasflotadetalle.Fecha, ventasflotadetalle.Hora, ventasflotadetalle.NombreCliente, ventasflotadetalle.Estacion, ventasflotadetalle.TipoEstacion, ventasflotadetalle.Destinatario, ventasflotadetalle.Ciudad, ventasflotadetalle.Placa, ventasflotadetalle.Producto, ventasflotadetalle.Cantidad, ventasflotadetalle.Precio, ventasflotadetalle.TotalVentas, ventasflotadetalle.PrecioEspecial, ventasflotadetalle.TotalFactura, ventasflotadetalle.Descuento, ventasflotadetalle.Kilometraje, ventasflotadetalle.UnidadVenta, ventasflotadetalle.TipoVenta);
		}

		/// <summary>
		/// Delete  the VentasFlotaDetalle object by passing a object
		/// </summary>
		public void  Delete(VentasFlotaDetalle ventasflotadetalle, Sinapsys.Datos.SQL datosTransaccion=null)
		{
			Delete(ventasflotadetalle.Recibo,datosTransaccion);
		}

		/// <summary>
		/// Deletes the VentasFlotaDetalle object by passing one object's instance as reference
		/// </summary>
		/// <param name="ventasflotadetalle">An instance of VentasFlotaDetalle for reference</param>
		public void Delete(long Recibo, Sinapsys.Datos.SQL datosTransaccion=null)
		{
			try 
			{
				VentasFlotaDetalleDataProvider.Instance.Delete(Recibo,"VentasFlotaDetalle");
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Deletes the VentasFlotaDetalle object by passing CVS parameter as reference
		/// </summary>
		/// <param name="ventasflotadetalle">An instance of VentasFlotaDetalle for reference</param>
		public void Delete(string CVSParameter)
		{
			string[] StrCommand=CVSParameter.Split(',');
			try 
			{
				long Recibo=long.Parse(StrCommand[0]);
				VentasFlotaDetalleDataProvider.Instance.Delete(Recibo,"VentasFlotaDetalle");
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Gets the VentasFlotaDetalle object by passing the object's key fields
		/// </summary>
		/// <param name="Recibo">long that contents the Recibo value for the VentasFlotaDetalle object</param>
		/// <returns>One VentasFlotaDetalle object</returns>
		public VentasFlotaDetalle Get(long Recibo, bool generateUndo=false)
		{
			try 
			{
				VentasFlotaDetalle ventasflotadetalle = null;
				DataTable dt = VentasFlotaDetalleDataProvider.Instance.Get(Recibo);
				if ((dt.Rows.Count > 0))
				{
					ventasflotadetalle = new VentasFlotaDetalle();
					DataRow dr = dt.Rows[0];
					ReadData(ventasflotadetalle, dr, generateUndo);
				}


				return ventasflotadetalle;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Gets all objects of VentasFlotaDetalle
		/// </summary>
		/// <returns>One VentasFlotaDetalleList object</returns>
		public VentasFlotaDetalleList GetAll(bool generateUndo=false)
		{
			try 
			{
				VentasFlotaDetalleList ventasflotadetallelist = new VentasFlotaDetalleList();
				DataTable dt = VentasFlotaDetalleDataProvider.Instance.GetAll();
				foreach (DataRow dr in dt.Rows)
				{
					VentasFlotaDetalle ventasflotadetalle = new VentasFlotaDetalle();
					ReadData(ventasflotadetalle, dr, generateUndo);
					ventasflotadetallelist.Add(ventasflotadetalle);
				}
				return ventasflotadetallelist;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Gets all objects of VentasFlotaDetalle applying filter and sort criteria
		/// </summary>
		/// <param name="pagenum">Contents the page number (z-ordered) of records to return.</param>
		/// <param name="pagesize">Contents the number of records per page (0 for returns all records).</param>
		/// <param name="filter">Contents the criteria (as SQL sentence) for filter records (ex. Qty > 0).</param>
		/// <param name="sort">Contents the criteria (as SQL sentence) for filter records (ex. Name ASC).</param>
		/// <param name="extablesfilter">Contents extra tables for make relations in filter operations (ex. extratable).</param>
		/// <param name="extablesfieldsfilter">Contents extra tables's fields for make relations in filter operations  (ex. extratable.field)</param>
		/// <param name="extablesrelationsfilter">Contents the relations with extra tables in filter operations (ex. table.id=extratable.id).</param>
		/// <param name="extablessort">Contents extra tables for make relations in sort operations (ex. extratable).</param>
		/// <param name="extablesfieldssort">Contents extra tables's fields for make relations in sort operations  (ex. extratable.field)</param>
		/// <param name="extablesrelationssort">Contents the relations with extra tables in sort operations (ex. table.id=extratable.id).</param>
		/// <returns>One VentasFlotaDetalleList object</returns>
		public VentasFlotaDetalleList GetFilter(int pagenum, int pagesize, string filter, string sort, string extablesfilter, string extablesfieldsfilter, string extablesrelationsfilter, string extablessort, string extablesfieldssort, string extablesrelationssort, bool generateUndo=false)
		{
			try 
			{
				VentasFlotaDetalleList ventasflotadetallelist = new VentasFlotaDetalleList();

				DataTable dt = VentasFlotaDetalleDataProvider.Instance.GetFilter(pagenum, pagesize, filter, sort, extablesfilter, extablesfieldsfilter, extablesrelationsfilter, extablessort, extablesfieldssort, extablesrelationssort);

				foreach (DataRow dr in dt.Rows)
				{
					VentasFlotaDetalle ventasflotadetalle = new VentasFlotaDetalle();
					ReadData(ventasflotadetalle, dr, generateUndo);
					ventasflotadetallelist.Add(ventasflotadetalle);
				}
				return ventasflotadetallelist;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public VentasFlotaDetalleList GetFilter( string filter, string sort, bool generateUndo=false)
		{
			return GetFilter(0,0, filter, sort, "","","","","","",generateUndo);
		}

		public VentasFlotaDetalleList GetFilter(string filter, string sort, string extablesfilter, string extablesfieldsfilter, string extablesrelationsfilter, string extablessort, string extablesfieldssort, string extablesrelationssort, bool generateUndo=false)
		{
			return GetFilter(0,0, filter, sort, extablesfilter, extablesfieldsfilter, extablesrelationsfilter, extablessort, extablesfieldssort, extablesrelationssort,generateUndo);
		}


		/// <summary>
		/// Returns the type for one property
		/// </summary>
		/// <param name="propertyname">Property's name for return its value</param>
		/// <returns>A value for the <paramref name="propertyname"/></returns>
		public Type GetMethodType( string propertyname,VentasFlotaDetalle ventasflotadetalle)
		{
			// Perform the search for the property's value
			switch (propertyname)
			{
				case "Recibo":
					return ventasflotadetalle.Recibo.GetType();

				case "IdEDS":
					return ventasflotadetalle.IdEDS.GetType();

				case "Factura":
					return ventasflotadetalle.Factura.GetType();

				case "Tipo":
					return ventasflotadetalle.Tipo.GetType();

				case "Numero":
					return ventasflotadetalle.Numero.GetType();

				case "Tipo52v":
					return ventasflotadetalle.Tipo52v.GetType();

				case "Numero52v":
					return ventasflotadetalle.Numero52v.GetType();

				case "Nit":
					return ventasflotadetalle.Nit.GetType();

				case "Seq":
					return ventasflotadetalle.Seq.GetType();

				case "Cuenta":
					return ventasflotadetalle.Cuenta.GetType();

				case "Fecha":
					return ventasflotadetalle.Fecha.GetType();

				case "Hora":
					return ventasflotadetalle.Hora.GetType();

				case "NombreCliente":
					return ventasflotadetalle.NombreCliente.GetType();

				case "Estacion":
					return ventasflotadetalle.Estacion.GetType();

				case "TipoEstacion":
					return ventasflotadetalle.TipoEstacion.GetType();

				case "Destinatario":
					return ventasflotadetalle.Destinatario.GetType();

				case "Ciudad":
					return ventasflotadetalle.Ciudad.GetType();

				case "Placa":
					return ventasflotadetalle.Placa.GetType();

				case "Producto":
					return ventasflotadetalle.Producto.GetType();

				case "Cantidad":
					return ventasflotadetalle.Cantidad.GetType();

				case "Precio":
					return ventasflotadetalle.Precio.GetType();

				case "TotalVentas":
					return ventasflotadetalle.TotalVentas.GetType();

				case "PrecioEspecial":
					return ventasflotadetalle.PrecioEspecial.GetType();

				case "TotalFactura":
					return ventasflotadetalle.TotalFactura.GetType();

				case "Descuento":
					return ventasflotadetalle.Descuento.GetType();

				case "Kilometraje":
					return ventasflotadetalle.Kilometraje.GetType();

				case "UnidadVenta":
					return ventasflotadetalle.UnidadVenta.GetType();

				case "TipoVenta":
					return ventasflotadetalle.TipoVenta.GetType();

			}

			return null;
		}
		/// <summary>
		/// update the changes in VentasFlotaDetalle object by passing the object
		/// </summary>
		public bool UpdateChanges(VentasFlotaDetalle ventasflotadetalle, out string error,Sinapsys.Datos.SQL datosTransaccion=null)
		{
			if (ventasflotadetalle.OldVentasFlotaDetalle == null)
			{
				    error = "No tiene objeto con el cual comparar";
				    return false;
			}
			string[] Fields = ventasflotadetalle.FieldChanged();
			error = "";
			return LiqViajes_Bll_Data.DataProvider.UpdateFieldsbyObject(Fields, ventasflotadetalle, out error,datosTransaccion);
		}
	}

	#endregion

}
