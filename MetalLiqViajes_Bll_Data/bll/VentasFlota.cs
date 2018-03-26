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
	#region VentasFlotaController

	/// <summary>
	/// Class for convert data from database into object's data and vice versa
	/// </summary>
	public partial class VentasFlotaController//: ILatinodeController
	{
		/// <summary>
		/// Generic Constructor
		/// </summary>
		public VentasFlotaController()
		{
		}

		/// <summary>
		/// Instance accessor for this singleton
		/// </summary>
		private static VentasFlotaController MySingleObj;
		public static VentasFlotaController Instance
		{
			get
			{
				if (MySingleObj == null)
				{
					MySingleObj = new VentasFlotaController();
				}
				return MySingleObj;
			}
		}

		// Reads object's data from a DataRow
		private void ReadData(VentasFlota ventasflota, DataRow dr,bool generateUndo=false)
		{
			try 
			{
				ventasflota.Recibo = (long) dr["Recibo"];
				ventasflota.CodEds = dr.IsNull("CodEds") ? null :(long?) dr["CodEds"];
				ventasflota.Fecha = dr.IsNull("Fecha") ? null :(DateTime?) dr["Fecha"];
				ventasflota.Tipo = dr.IsNull("Tipo") ? null :(string) dr["Tipo"];
				ventasflota.Numero = dr.IsNull("Numero") ? null :(int?) dr["Numero"];
				ventasflota.Nit = dr.IsNull("Nit") ? null :(decimal?) dr["Nit"];
				ventasflota.Placa = dr.IsNull("Placa") ? null :(string) dr["Placa"];
				ventasflota.Producto = dr.IsNull("Producto") ? null :(string) dr["Producto"];
				ventasflota.Dinero = dr.IsNull("Dinero") ? null :(decimal?) dr["Dinero"];
				ventasflota.Descuento = dr.IsNull("Descuento") ? null :(decimal?) dr["Descuento"];
				ventasflota.PrecioEspecial = dr.IsNull("PrecioEspecial") ? null :(decimal?) dr["PrecioEspecial"];
				ventasflota.TotalFactura = dr.IsNull("TotalFactura") ? null :(decimal?) dr["TotalFactura"];
				ventasflota.Volumen = dr.IsNull("Volumen") ? null :(decimal?) dr["Volumen"];
				ventasflota.Kilometraje = dr.IsNull("Kilometraje") ? null :(decimal?) dr["Kilometraje"];
				ventasflota.Factura = dr.IsNull("Factura") ? null :(long?) dr["Factura"];
			}
			catch (Exception ex)
			{
				Utilidades.LogErrores(ex.Message + (ex.InnerException != null ? ex.InnerException.Message : ""), DataProvider.AplicacionNombre);
				throw ex;
			}
			if (generateUndo) ventasflota.GenerateUndo();
		}

		/// <summary>
		/// Create a new VentasFlota object by passing a object
		/// </summary>
		public VentasFlota Create(VentasFlota ventasflota, Sinapsys.Datos.SQL datosTransaccion=null)
		{
			return Create(ventasflota.Recibo,ventasflota.CodEds,ventasflota.Fecha,ventasflota.Tipo,ventasflota.Numero,ventasflota.Nit,ventasflota.Placa,ventasflota.Producto,ventasflota.Dinero,ventasflota.Descuento,ventasflota.PrecioEspecial,ventasflota.TotalFactura,ventasflota.Volumen,ventasflota.Kilometraje,ventasflota.Factura,datosTransaccion);
		}

		/// <summary>
		/// Creates a new VentasFlota object by passing all object's fields
		/// </summary>
		/// <param name="CodEds">long that contents the CodEds value for the VentasFlota object</param>
		/// <param name="Fecha">DateTime that contents the Fecha value for the VentasFlota object</param>
		/// <param name="Tipo">string that contents the Tipo value for the VentasFlota object</param>
		/// <param name="Numero">int that contents the Numero value for the VentasFlota object</param>
		/// <param name="Nit">decimal that contents the Nit value for the VentasFlota object</param>
		/// <param name="Placa">string that contents the Placa value for the VentasFlota object</param>
		/// <param name="Producto">string that contents the Producto value for the VentasFlota object</param>
		/// <param name="Dinero">decimal that contents the Dinero value for the VentasFlota object</param>
		/// <param name="Descuento">decimal that contents the Descuento value for the VentasFlota object</param>
		/// <param name="PrecioEspecial">decimal that contents the PrecioEspecial value for the VentasFlota object</param>
		/// <param name="TotalFactura">decimal that contents the TotalFactura value for the VentasFlota object</param>
		/// <param name="Volumen">decimal that contents the Volumen value for the VentasFlota object</param>
		/// <param name="Kilometraje">decimal that contents the Kilometraje value for the VentasFlota object</param>
		/// <param name="Factura">long that contents the Factura value for the VentasFlota object</param>
		/// <returns>One VentasFlota object</returns>
		public VentasFlota Create(long Recibo, long? CodEds, DateTime? Fecha, string Tipo, int? Numero, decimal? Nit, string Placa, string Producto, decimal? Dinero, decimal? Descuento, decimal? PrecioEspecial, decimal? TotalFactura, decimal? Volumen, decimal? Kilometraje, long? Factura, Sinapsys.Datos.SQL datosTransaccion=null)
		{
			try 
			{
				VentasFlota ventasflota = new VentasFlota();

				ventasflota.Recibo = Recibo;
				ventasflota.CodEds = CodEds;
				ventasflota.Fecha = Fecha;
				ventasflota.Tipo = Tipo;
				ventasflota.Numero = Numero;
				ventasflota.Nit = Nit;
				ventasflota.Placa = Placa;
				ventasflota.Producto = Producto;
				ventasflota.Dinero = Dinero;
				ventasflota.Descuento = Descuento;
				ventasflota.PrecioEspecial = PrecioEspecial;
				ventasflota.TotalFactura = TotalFactura;
				ventasflota.Volumen = Volumen;
				ventasflota.Kilometraje = Kilometraje;
				ventasflota.Factura = Factura;
				VentasFlotaDataProvider.Instance.Create(Recibo, CodEds, Fecha, Tipo, Numero, Nit, Placa, Producto, Dinero, Descuento, PrecioEspecial, TotalFactura, Volumen, Kilometraje, Factura,"VentasFlota");

				return ventasflota;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Updates an VentasFlota object by passing all object's fields
		/// </summary>
		/// <param name="Recibo">long that contents the Recibo value for the VentasFlota object</param>
		/// <param name="CodEds">long that contents the CodEds value for the VentasFlota object</param>
		/// <param name="Fecha">DateTime that contents the Fecha value for the VentasFlota object</param>
		/// <param name="Tipo">string that contents the Tipo value for the VentasFlota object</param>
		/// <param name="Numero">int that contents the Numero value for the VentasFlota object</param>
		/// <param name="Nit">decimal that contents the Nit value for the VentasFlota object</param>
		/// <param name="Placa">string that contents the Placa value for the VentasFlota object</param>
		/// <param name="Producto">string that contents the Producto value for the VentasFlota object</param>
		/// <param name="Dinero">decimal that contents the Dinero value for the VentasFlota object</param>
		/// <param name="Descuento">decimal that contents the Descuento value for the VentasFlota object</param>
		/// <param name="PrecioEspecial">decimal that contents the PrecioEspecial value for the VentasFlota object</param>
		/// <param name="TotalFactura">decimal that contents the TotalFactura value for the VentasFlota object</param>
		/// <param name="Volumen">decimal that contents the Volumen value for the VentasFlota object</param>
		/// <param name="Kilometraje">decimal that contents the Kilometraje value for the VentasFlota object</param>
		/// <param name="Factura">long that contents the Factura value for the VentasFlota object</param>
		public void Update(long Recibo, long? CodEds, DateTime? Fecha, string Tipo, int? Numero, decimal? Nit, string Placa, string Producto, decimal? Dinero, decimal? Descuento, decimal? PrecioEspecial, decimal? TotalFactura, decimal? Volumen, decimal? Kilometraje, long? Factura, Sinapsys.Datos.SQL datosTransaccion=null)
		{
			try 
			{
				VentasFlota new_values = new VentasFlota();
				new_values.CodEds = CodEds;
				new_values.Fecha = Fecha;
				new_values.Tipo = Tipo;
				new_values.Numero = Numero;
				new_values.Nit = Nit;
				new_values.Placa = Placa;
				new_values.Producto = Producto;
				new_values.Dinero = Dinero;
				new_values.Descuento = Descuento;
				new_values.PrecioEspecial = PrecioEspecial;
				new_values.TotalFactura = TotalFactura;
				new_values.Volumen = Volumen;
				new_values.Kilometraje = Kilometraje;
				new_values.Factura = Factura;
				VentasFlotaDataProvider.Instance.Update(Recibo, CodEds, Fecha, Tipo, Numero, Nit, Placa, Producto, Dinero, Descuento, PrecioEspecial, TotalFactura, Volumen, Kilometraje, Factura,"VentasFlota",datosTransaccion);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Updates an VentasFlota object by passing one object's instance as reference
		/// </summary>
		/// <param name="ventasflota">An instance of VentasFlota for reference</param>
		public void Update(VentasFlota ventasflota,Sinapsys.Datos.SQL datosTransaccion=null)
		{
			Update(ventasflota.Recibo, ventasflota.CodEds, ventasflota.Fecha, ventasflota.Tipo, ventasflota.Numero, ventasflota.Nit, ventasflota.Placa, ventasflota.Producto, ventasflota.Dinero, ventasflota.Descuento, ventasflota.PrecioEspecial, ventasflota.TotalFactura, ventasflota.Volumen, ventasflota.Kilometraje, ventasflota.Factura);
		}

		/// <summary>
		/// Delete  the VentasFlota object by passing a object
		/// </summary>
		public void  Delete(VentasFlota ventasflota, Sinapsys.Datos.SQL datosTransaccion=null)
		{
			Delete(ventasflota.Recibo,datosTransaccion);
		}

		/// <summary>
		/// Deletes the VentasFlota object by passing one object's instance as reference
		/// </summary>
		/// <param name="ventasflota">An instance of VentasFlota for reference</param>
		public void Delete(long Recibo, Sinapsys.Datos.SQL datosTransaccion=null)
		{
			try 
			{
				VentasFlotaDataProvider.Instance.Delete(Recibo,"VentasFlota");
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Deletes the VentasFlota object by passing CVS parameter as reference
		/// </summary>
		/// <param name="ventasflota">An instance of VentasFlota for reference</param>
		public void Delete(string CVSParameter)
		{
			string[] StrCommand=CVSParameter.Split(',');
			try 
			{
				long Recibo=long.Parse(StrCommand[0]);
				VentasFlotaDataProvider.Instance.Delete(Recibo,"VentasFlota");
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Gets the VentasFlota object by passing the object's key fields
		/// </summary>
		/// <param name="Recibo">long that contents the Recibo value for the VentasFlota object</param>
		/// <returns>One VentasFlota object</returns>
		public VentasFlota Get(long Recibo, bool generateUndo=false)
		{
			try 
			{
				VentasFlota ventasflota = null;
				DataTable dt = VentasFlotaDataProvider.Instance.Get(Recibo);
				if ((dt.Rows.Count > 0))
				{
					ventasflota = new VentasFlota();
					DataRow dr = dt.Rows[0];
					ReadData(ventasflota, dr, generateUndo);
				}


				return ventasflota;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Gets all objects of VentasFlota
		/// </summary>
		/// <returns>One VentasFlotaList object</returns>
		public VentasFlotaList GetAll(bool generateUndo=false)
		{
			try 
			{
				VentasFlotaList ventasflotalist = new VentasFlotaList();
				DataTable dt = VentasFlotaDataProvider.Instance.GetAll();
				foreach (DataRow dr in dt.Rows)
				{
					VentasFlota ventasflota = new VentasFlota();
					ReadData(ventasflota, dr, generateUndo);
					ventasflotalist.Add(ventasflota);
				}
				return ventasflotalist;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Gets all objects of VentasFlota applying filter and sort criteria
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
		/// <returns>One VentasFlotaList object</returns>
		public VentasFlotaList GetFilter(int pagenum, int pagesize, string filter, string sort, string extablesfilter, string extablesfieldsfilter, string extablesrelationsfilter, string extablessort, string extablesfieldssort, string extablesrelationssort, bool generateUndo=false)
		{
			try 
			{
				VentasFlotaList ventasflotalist = new VentasFlotaList();

				DataTable dt = VentasFlotaDataProvider.Instance.GetFilter(pagenum, pagesize, filter, sort, extablesfilter, extablesfieldsfilter, extablesrelationsfilter, extablessort, extablesfieldssort, extablesrelationssort);

				foreach (DataRow dr in dt.Rows)
				{
					VentasFlota ventasflota = new VentasFlota();
					ReadData(ventasflota, dr, generateUndo);
					ventasflotalist.Add(ventasflota);
				}
				return ventasflotalist;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public VentasFlotaList GetFilter( string filter, string sort, bool generateUndo=false)
		{
			return GetFilter(0,0, filter, sort, "","","","","","",generateUndo);
		}

		public VentasFlotaList GetFilter(string filter, string sort, string extablesfilter, string extablesfieldsfilter, string extablesrelationsfilter, string extablessort, string extablesfieldssort, string extablesrelationssort, bool generateUndo=false)
		{
			return GetFilter(0,0, filter, sort, extablesfilter, extablesfieldsfilter, extablesrelationsfilter, extablessort, extablesfieldssort, extablesrelationssort,generateUndo);
		}


		/// <summary>
		/// Returns the type for one property
		/// </summary>
		/// <param name="propertyname">Property's name for return its value</param>
		/// <returns>A value for the <paramref name="propertyname"/></returns>
		public Type GetMethodType( string propertyname,VentasFlota ventasflota)
		{
			// Perform the search for the property's value
			switch (propertyname)
			{
				case "Recibo":
					return ventasflota.Recibo.GetType();

				case "CodEds":
					return ventasflota.CodEds.GetType();

				case "Fecha":
					return ventasflota.Fecha.GetType();

				case "Tipo":
					return ventasflota.Tipo.GetType();

				case "Numero":
					return ventasflota.Numero.GetType();

				case "Nit":
					return ventasflota.Nit.GetType();

				case "Placa":
					return ventasflota.Placa.GetType();

				case "Producto":
					return ventasflota.Producto.GetType();

				case "Dinero":
					return ventasflota.Dinero.GetType();

				case "Descuento":
					return ventasflota.Descuento.GetType();

				case "PrecioEspecial":
					return ventasflota.PrecioEspecial.GetType();

				case "TotalFactura":
					return ventasflota.TotalFactura.GetType();

				case "Volumen":
					return ventasflota.Volumen.GetType();

				case "Kilometraje":
					return ventasflota.Kilometraje.GetType();

				case "Factura":
					return ventasflota.Factura.GetType();

			}

			return null;
		}
		/// <summary>
		/// update the changes in VentasFlota object by passing the object
		/// </summary>
		public bool UpdateChanges(VentasFlota ventasflota, out string error,Sinapsys.Datos.SQL datosTransaccion=null)
		{
			if (ventasflota.OldVentasFlota == null)
			{
				    error = "No tiene objeto con el cual comparar";
				    return false;
			}
			string[] Fields = ventasflota.FieldChanged();
			error = "";
			return LiqViajes_Bll_Data.DataProvider.UpdateFieldsbyObject(Fields, ventasflota, out error,datosTransaccion);
		}
	}

	#endregion

}
