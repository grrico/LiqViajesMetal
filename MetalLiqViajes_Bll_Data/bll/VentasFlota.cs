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
				ventasflota.Codigo = (long) dr["Codigo"];
				ventasflota.CodEds = dr.IsNull("CodEds") ? null :(long?) dr["CodEds"];
				ventasflota.Recibo = dr.IsNull("Recibo") ? null :(long?) dr["Recibo"];
				ventasflota.Fecha = dr.IsNull("Fecha") ? null :(DateTime?) dr["Fecha"];
				ventasflota.Placa = dr.IsNull("Placa") ? null :(string) dr["Placa"];
				ventasflota.Producto = dr.IsNull("Producto") ? null :(string) dr["Producto"];
				ventasflota.Dinero = dr.IsNull("Dinero") ? null :(decimal?) dr["Dinero"];
				ventasflota.Volumen = dr.IsNull("Volumen") ? null :(decimal?) dr["Volumen"];
				ventasflota.Kilometraje = dr.IsNull("Kilometraje") ? null :(decimal?) dr["Kilometraje"];
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
			return Create(ventasflota.Codigo,ventasflota.CodEds,ventasflota.Recibo,ventasflota.Fecha,ventasflota.Placa,ventasflota.Producto,ventasflota.Dinero,ventasflota.Volumen,ventasflota.Kilometraje,datosTransaccion);
		}

		/// <summary>
		/// Creates a new VentasFlota object by passing all object's fields
		/// </summary>
		/// <param name="CodEds">long that contents the CodEds value for the VentasFlota object</param>
		/// <param name="Recibo">long that contents the Recibo value for the VentasFlota object</param>
		/// <param name="Fecha">DateTime that contents the Fecha value for the VentasFlota object</param>
		/// <param name="Placa">string that contents the Placa value for the VentasFlota object</param>
		/// <param name="Producto">string that contents the Producto value for the VentasFlota object</param>
		/// <param name="Dinero">decimal that contents the Dinero value for the VentasFlota object</param>
		/// <param name="Volumen">decimal that contents the Volumen value for the VentasFlota object</param>
		/// <param name="Kilometraje">decimal that contents the Kilometraje value for the VentasFlota object</param>
		/// <returns>One VentasFlota object</returns>
		public VentasFlota Create(long Codigo, long? CodEds, long? Recibo, DateTime? Fecha, string Placa, string Producto, decimal? Dinero, decimal? Volumen, decimal? Kilometraje, Sinapsys.Datos.SQL datosTransaccion=null)
		{
			try 
			{
				VentasFlota ventasflota = new VentasFlota();

				ventasflota.Codigo = Codigo;
				ventasflota.Codigo = Codigo;
				ventasflota.CodEds = CodEds;
				ventasflota.Recibo = Recibo;
				ventasflota.Fecha = Fecha;
				ventasflota.Placa = Placa;
				ventasflota.Producto = Producto;
				ventasflota.Dinero = Dinero;
				ventasflota.Volumen = Volumen;
				ventasflota.Kilometraje = Kilometraje;
				Codigo = VentasFlotaDataProvider.Instance.Create(Codigo, CodEds, Recibo, Fecha, Placa, Producto, Dinero, Volumen, Kilometraje,"VentasFlota",datosTransaccion);
				if (Codigo == 0)
					return null;

				ventasflota.Codigo = Codigo;

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
		/// <param name="Codigo">long that contents the Codigo value for the VentasFlota object</param>
		/// <param name="CodEds">long that contents the CodEds value for the VentasFlota object</param>
		/// <param name="Recibo">long that contents the Recibo value for the VentasFlota object</param>
		/// <param name="Fecha">DateTime that contents the Fecha value for the VentasFlota object</param>
		/// <param name="Placa">string that contents the Placa value for the VentasFlota object</param>
		/// <param name="Producto">string that contents the Producto value for the VentasFlota object</param>
		/// <param name="Dinero">decimal that contents the Dinero value for the VentasFlota object</param>
		/// <param name="Volumen">decimal that contents the Volumen value for the VentasFlota object</param>
		/// <param name="Kilometraje">decimal that contents the Kilometraje value for the VentasFlota object</param>
		public void Update(long Codigo, long? CodEds, long? Recibo, DateTime? Fecha, string Placa, string Producto, decimal? Dinero, decimal? Volumen, decimal? Kilometraje, Sinapsys.Datos.SQL datosTransaccion=null)
		{
			try 
			{
				VentasFlota new_values = new VentasFlota();
				new_values.CodEds = CodEds;
				new_values.Recibo = Recibo;
				new_values.Fecha = Fecha;
				new_values.Placa = Placa;
				new_values.Producto = Producto;
				new_values.Dinero = Dinero;
				new_values.Volumen = Volumen;
				new_values.Kilometraje = Kilometraje;
				VentasFlotaDataProvider.Instance.Update(Codigo, CodEds, Recibo, Fecha, Placa, Producto, Dinero, Volumen, Kilometraje,"VentasFlota",datosTransaccion);
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
			Update(ventasflota.Codigo, ventasflota.CodEds, ventasflota.Recibo, ventasflota.Fecha, ventasflota.Placa, ventasflota.Producto, ventasflota.Dinero, ventasflota.Volumen, ventasflota.Kilometraje);
		}

		/// <summary>
		/// Delete  the VentasFlota object by passing a object
		/// </summary>
		public void  Delete(VentasFlota ventasflota, Sinapsys.Datos.SQL datosTransaccion=null)
		{
			Delete(ventasflota.Codigo,datosTransaccion);
		}

		/// <summary>
		/// Deletes the VentasFlota object by passing one object's instance as reference
		/// </summary>
		/// <param name="ventasflota">An instance of VentasFlota for reference</param>
		public void Delete(long Codigo, Sinapsys.Datos.SQL datosTransaccion=null)
		{
			try 
			{
				//VentasFlota old_values = VentasFlotaController.Instance.Get(Codigo);
				//if(!Validate.security.CanDeleteSecurityField(VentasFlotaController.Instance, (ILatinodeObject)old_values))
				//    throw new Exception("Access denied by security field, you can't delete object");

				VentasFlotaDataProvider.Instance.Delete(Codigo,"VentasFlota");
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
				long Codigo=long.Parse(StrCommand[0]);
				VentasFlotaDataProvider.Instance.Delete(Codigo,"VentasFlota");
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Gets the VentasFlota object by passing the object's key fields
		/// </summary>
		/// <param name="Codigo">long that contents the Codigo value for the VentasFlota object</param>
		/// <returns>One VentasFlota object</returns>
		public VentasFlota Get(long Codigo, bool generateUndo=false)
		{
			try 
			{
				VentasFlota ventasflota = null;
				DataTable dt = VentasFlotaDataProvider.Instance.Get(Codigo);
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
				case "Codigo":
					return ventasflota.Codigo.GetType();

				case "CodEds":
					return ventasflota.CodEds.GetType();

				case "Recibo":
					return ventasflota.Recibo.GetType();

				case "Fecha":
					return ventasflota.Fecha.GetType();

				case "Placa":
					return ventasflota.Placa.GetType();

				case "Producto":
					return ventasflota.Producto.GetType();

				case "Dinero":
					return ventasflota.Dinero.GetType();

				case "Volumen":
					return ventasflota.Volumen.GetType();

				case "Kilometraje":
					return ventasflota.Kilometraje.GetType();

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
