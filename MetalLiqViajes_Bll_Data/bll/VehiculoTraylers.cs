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
	#region VehiculoTraylersController

	/// <summary>
	/// Class for convert data from database into object's data and vice versa
	/// </summary>
	public partial class VehiculoTraylersController//: ILatinodeController
	{
		/// <summary>
		/// Generic Constructor
		/// </summary>
		public VehiculoTraylersController()
		{
		}

		/// <summary>
		/// Instance accessor for this singleton
		/// </summary>
		private static VehiculoTraylersController MySingleObj;
		public static VehiculoTraylersController Instance
		{
			get
			{
				if (MySingleObj == null)
				{
					MySingleObj = new VehiculoTraylersController();
				}
				return MySingleObj;
			}
		}

		// Reads object's data from a DataRow
		private void ReadData(VehiculoTraylers vehiculotraylers, DataRow dr,bool generateUndo=false)
		{
			try 
			{
				vehiculotraylers.Placa = dr.IsNull("Placa") ? null :(string) dr["Placa"];
				vehiculotraylers.lngIdRegistro = dr.IsNull("lngIdRegistro") ? null :(int?) dr["lngIdRegistro"];
				vehiculotraylers.lngIdRegistrRutaItemId = dr.IsNull("lngIdRegistrRutaItemId") ? null :(int?) dr["lngIdRegistrRutaItemId"];
				vehiculotraylers.lngIdRegistrRuta = dr.IsNull("lngIdRegistrRuta") ? null :(int?) dr["lngIdRegistrRuta"];
				vehiculotraylers.Fecha = dr.IsNull("Fecha") ? null :(DateTime?) dr["Fecha"];
				vehiculotraylers.Liquidado = dr.IsNull("Liquidado") ? null :(bool?) dr["Liquidado"];
				vehiculotraylers.Orden = dr.IsNull("Orden") ? null :(int?) dr["Orden"];
				vehiculotraylers.Trayler = (string) dr["Trayler"];
			}
			catch (Exception ex)
			{
				Utilidades.LogErrores(ex.Message + (ex.InnerException != null ? ex.InnerException.Message : ""), DataProvider.AplicacionNombre);
				throw ex;
			}
			if (generateUndo) vehiculotraylers.GenerateUndo();
		}

		/// <summary>
		/// Create a new VehiculoTraylers object by passing a object
		/// </summary>
		public VehiculoTraylers Create(VehiculoTraylers vehiculotraylers, Sinapsys.Datos.SQL datosTransaccion=null)
		{
			return Create(vehiculotraylers.Trayler,vehiculotraylers.Placa,vehiculotraylers.lngIdRegistro,vehiculotraylers.lngIdRegistrRutaItemId,vehiculotraylers.lngIdRegistrRuta,vehiculotraylers.Fecha,vehiculotraylers.Liquidado,vehiculotraylers.Orden,datosTransaccion);
		}

		/// <summary>
		/// Creates a new VehiculoTraylers object by passing all object's fields
		/// </summary>
		/// <param name="Placa">string that contents the Placa value for the VehiculoTraylers object</param>
		/// <param name="lngIdRegistro">int that contents the lngIdRegistro value for the VehiculoTraylers object</param>
		/// <param name="lngIdRegistrRutaItemId">int that contents the lngIdRegistrRutaItemId value for the VehiculoTraylers object</param>
		/// <param name="lngIdRegistrRuta">int that contents the lngIdRegistrRuta value for the VehiculoTraylers object</param>
		/// <param name="Fecha">DateTime that contents the Fecha value for the VehiculoTraylers object</param>
		/// <param name="Liquidado">bool that contents the Liquidado value for the VehiculoTraylers object</param>
		/// <param name="Orden">int that contents the Orden value for the VehiculoTraylers object</param>
		/// <returns>One VehiculoTraylers object</returns>
		public VehiculoTraylers Create(string Trayler, string Placa, int? lngIdRegistro, int? lngIdRegistrRutaItemId, int? lngIdRegistrRuta, DateTime? Fecha, bool? Liquidado, int? Orden, Sinapsys.Datos.SQL datosTransaccion=null)
		{
			try 
			{
				VehiculoTraylers vehiculotraylers = new VehiculoTraylers();

				vehiculotraylers.Trayler = Trayler;
				vehiculotraylers.Placa = Placa;
				vehiculotraylers.lngIdRegistro = lngIdRegistro;
				vehiculotraylers.lngIdRegistrRutaItemId = lngIdRegistrRutaItemId;
				vehiculotraylers.lngIdRegistrRuta = lngIdRegistrRuta;
				vehiculotraylers.Fecha = Fecha;
				vehiculotraylers.Liquidado = Liquidado;
				vehiculotraylers.Orden = Orden;
				VehiculoTraylersDataProvider.Instance.Create(Trayler, Placa, lngIdRegistro, lngIdRegistrRutaItemId, lngIdRegistrRuta, Fecha, Liquidado, Orden,"VehiculoTraylers");

				return vehiculotraylers;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Updates an VehiculoTraylers object by passing all object's fields
		/// </summary>
		/// <param name="Placa">string that contents the Placa value for the VehiculoTraylers object</param>
		/// <param name="lngIdRegistro">int that contents the lngIdRegistro value for the VehiculoTraylers object</param>
		/// <param name="lngIdRegistrRutaItemId">int that contents the lngIdRegistrRutaItemId value for the VehiculoTraylers object</param>
		/// <param name="lngIdRegistrRuta">int that contents the lngIdRegistrRuta value for the VehiculoTraylers object</param>
		/// <param name="Fecha">DateTime that contents the Fecha value for the VehiculoTraylers object</param>
		/// <param name="Liquidado">bool that contents the Liquidado value for the VehiculoTraylers object</param>
		/// <param name="Orden">int that contents the Orden value for the VehiculoTraylers object</param>
		/// <param name="Trayler">string that contents the Trayler value for the VehiculoTraylers object</param>
		public void Update(string Placa, int? lngIdRegistro, int? lngIdRegistrRutaItemId, int? lngIdRegistrRuta, DateTime? Fecha, bool? Liquidado, int? Orden, string Trayler, Sinapsys.Datos.SQL datosTransaccion=null)
		{
			try 
			{
				VehiculoTraylers new_values = new VehiculoTraylers();
				new_values.Placa = Placa;
				new_values.lngIdRegistro = lngIdRegistro;
				new_values.lngIdRegistrRutaItemId = lngIdRegistrRutaItemId;
				new_values.lngIdRegistrRuta = lngIdRegistrRuta;
				new_values.Fecha = Fecha;
				new_values.Liquidado = Liquidado;
				new_values.Orden = Orden;
				VehiculoTraylersDataProvider.Instance.Update(Placa, lngIdRegistro, lngIdRegistrRutaItemId, lngIdRegistrRuta, Fecha, Liquidado, Orden, Trayler,"VehiculoTraylers",datosTransaccion);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Updates an VehiculoTraylers object by passing one object's instance as reference
		/// </summary>
		/// <param name="vehiculotraylers">An instance of VehiculoTraylers for reference</param>
		public void Update(VehiculoTraylers vehiculotraylers,Sinapsys.Datos.SQL datosTransaccion=null)
		{
			Update(vehiculotraylers.Placa, vehiculotraylers.lngIdRegistro, vehiculotraylers.lngIdRegistrRutaItemId, vehiculotraylers.lngIdRegistrRuta, vehiculotraylers.Fecha, vehiculotraylers.Liquidado, vehiculotraylers.Orden, vehiculotraylers.Trayler);
		}

		/// <summary>
		/// Delete  the VehiculoTraylers object by passing a object
		/// </summary>
		public void  Delete(VehiculoTraylers vehiculotraylers, Sinapsys.Datos.SQL datosTransaccion=null)
		{
			Delete(vehiculotraylers.Trayler,datosTransaccion);
		}

		/// <summary>
		/// Deletes the VehiculoTraylers object by passing one object's instance as reference
		/// </summary>
		/// <param name="vehiculotraylers">An instance of VehiculoTraylers for reference</param>
		public void Delete(string Trayler, Sinapsys.Datos.SQL datosTransaccion=null)
		{
			try 
			{
				VehiculoTraylersDataProvider.Instance.Delete(Trayler,"VehiculoTraylers");
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Gets the VehiculoTraylers object by passing the object's key fields
		/// </summary>
		/// <param name="Trayler">string that contents the Trayler value for the VehiculoTraylers object</param>
		/// <returns>One VehiculoTraylers object</returns>
		public VehiculoTraylers Get(string Trayler, bool generateUndo=false)
		{
			try 
			{
				VehiculoTraylers vehiculotraylers = null;
				DataTable dt = VehiculoTraylersDataProvider.Instance.Get(Trayler);
				if ((dt.Rows.Count > 0))
				{
					vehiculotraylers = new VehiculoTraylers();
					DataRow dr = dt.Rows[0];
					ReadData(vehiculotraylers, dr, generateUndo);
				}


				return vehiculotraylers;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Gets all objects of VehiculoTraylers
		/// </summary>
		/// <returns>One VehiculoTraylersList object</returns>
		public VehiculoTraylersList GetAll(bool generateUndo=false)
		{
			try 
			{
				VehiculoTraylersList vehiculotraylerslist = new VehiculoTraylersList();
				DataTable dt = VehiculoTraylersDataProvider.Instance.GetAll();
				foreach (DataRow dr in dt.Rows)
				{
					VehiculoTraylers vehiculotraylers = new VehiculoTraylers();
					ReadData(vehiculotraylers, dr, generateUndo);
					vehiculotraylerslist.Add(vehiculotraylers);
				}
				return vehiculotraylerslist;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Gets all objects of VehiculoTraylers applying filter and sort criteria
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
		/// <returns>One VehiculoTraylersList object</returns>
		public VehiculoTraylersList GetFilter(int pagenum, int pagesize, string filter, string sort, string extablesfilter, string extablesfieldsfilter, string extablesrelationsfilter, string extablessort, string extablesfieldssort, string extablesrelationssort, bool generateUndo=false)
		{
			try 
			{
				VehiculoTraylersList vehiculotraylerslist = new VehiculoTraylersList();

				DataTable dt = VehiculoTraylersDataProvider.Instance.GetFilter(pagenum, pagesize, filter, sort, extablesfilter, extablesfieldsfilter, extablesrelationsfilter, extablessort, extablesfieldssort, extablesrelationssort);

				foreach (DataRow dr in dt.Rows)
				{
					VehiculoTraylers vehiculotraylers = new VehiculoTraylers();
					ReadData(vehiculotraylers, dr, generateUndo);
					vehiculotraylerslist.Add(vehiculotraylers);
				}
				return vehiculotraylerslist;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public VehiculoTraylersList GetFilter( string filter, string sort, bool generateUndo=false)
		{
			return GetFilter(0,0, filter, sort, "","","","","","",generateUndo);
		}

		public VehiculoTraylersList GetFilter(string filter, string sort, string extablesfilter, string extablesfieldsfilter, string extablesrelationsfilter, string extablessort, string extablesfieldssort, string extablesrelationssort, bool generateUndo=false)
		{
			return GetFilter(0,0, filter, sort, extablesfilter, extablesfieldsfilter, extablesrelationsfilter, extablessort, extablesfieldssort, extablesrelationssort,generateUndo);
		}


		/// <summary>
		/// Returns the type for one property
		/// </summary>
		/// <param name="propertyname">Property's name for return its value</param>
		/// <returns>A value for the <paramref name="propertyname"/></returns>
		public Type GetMethodType( string propertyname,VehiculoTraylers vehiculotraylers)
		{
			// Perform the search for the property's value
			switch (propertyname)
			{
				case "Placa":
					return vehiculotraylers.Placa.GetType();

				case "lngIdRegistro":
					return vehiculotraylers.lngIdRegistro.GetType();

				case "lngIdRegistrRutaItemId":
					return vehiculotraylers.lngIdRegistrRutaItemId.GetType();

				case "lngIdRegistrRuta":
					return vehiculotraylers.lngIdRegistrRuta.GetType();

				case "Fecha":
					return vehiculotraylers.Fecha.GetType();

				case "Liquidado":
					return vehiculotraylers.Liquidado.GetType();

				case "Orden":
					return vehiculotraylers.Orden.GetType();

				case "Trayler":
					return vehiculotraylers.Trayler.GetType();

			}

			return null;
		}
		/// <summary>
		/// update the changes in VehiculoTraylers object by passing the object
		/// </summary>
		public bool UpdateChanges(VehiculoTraylers vehiculotraylers, out string error,Sinapsys.Datos.SQL datosTransaccion=null)
		{
			if (vehiculotraylers.OldVehiculoTraylers == null)
			{
				    error = "No tiene objeto con el cual comparar";
				    return false;
			}
			string[] Fields = vehiculotraylers.FieldChanged();
			error = "";
			return LiqViajes_Bll_Data.DataProvider.UpdateFieldsbyObject(Fields, vehiculotraylers, out error,datosTransaccion);
		}
	}

	#endregion

}
