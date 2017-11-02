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
	#region VehiculosKmMantenimientoController

	/// <summary>
	/// Class for convert data from database into object's data and vice versa
	/// </summary>
	public partial class VehiculosKmMantenimientoController//: ILatinodeController
	{
		/// <summary>
		/// Generic Constructor
		/// </summary>
		public VehiculosKmMantenimientoController()
		{
		}

		/// <summary>
		/// Instance accessor for this singleton
		/// </summary>
		private static VehiculosKmMantenimientoController MySingleObj;
		public static VehiculosKmMantenimientoController Instance
		{
			get
			{
				if (MySingleObj == null)
				{
					MySingleObj = new VehiculosKmMantenimientoController();
				}
				return MySingleObj;
			}
		}

		// Reads object's data from a DataRow
		private void ReadData(VehiculosKmMantenimiento vehiculoskmmantenimiento, DataRow dr,bool generateUndo=false)
		{
			try 
			{
				vehiculoskmmantenimiento.strPlaca = (string) dr["strPlaca"];
				vehiculoskmmantenimiento.lngIdTipoMantenimiento = (int) dr["lngIdTipoMantenimiento"];
				vehiculoskmmantenimiento.dtmFechaUltimoCambio = dr.IsNull("dtmFechaUltimoCambio") ? null :(DateTime?) dr["dtmFechaUltimoCambio"];
				vehiculoskmmantenimiento.intKmUltimoCambio = dr.IsNull("intKmUltimoCambio") ? null :(int?) dr["intKmUltimoCambio"];
				vehiculoskmmantenimiento.intKmSiguiente = dr.IsNull("intKmSiguiente") ? null :(int?) dr["intKmSiguiente"];
				vehiculoskmmantenimiento.intKmAcumulado = dr.IsNull("intKmAcumulado") ? null :(int?) dr["intKmAcumulado"];
				vehiculoskmmantenimiento.dtmFechaUltimoUltimoAcumu = dr.IsNull("dtmFechaUltimoUltimoAcumu") ? null :(DateTime?) dr["dtmFechaUltimoUltimoAcumu"];
				vehiculoskmmantenimiento.intKmAlarma1 = dr.IsNull("intKmAlarma1") ? null :(int?) dr["intKmAlarma1"];
				vehiculoskmmantenimiento.intKmAlarma2 = dr.IsNull("intKmAlarma2") ? null :(int?) dr["intKmAlarma2"];
				vehiculoskmmantenimiento.logAvisa = dr.IsNull("logAvisa") ? null :(bool?) dr["logAvisa"];
				vehiculoskmmantenimiento.dtmFechaDetener = dr.IsNull("dtmFechaDetener") ? null :(DateTime?) dr["dtmFechaDetener"];
				vehiculoskmmantenimiento.strLugarDetener = dr.IsNull("strLugarDetener") ? null :(string) dr["strLugarDetener"];
				vehiculoskmmantenimiento.dtmFechaModif = dr.IsNull("dtmFechaModif") ? null :(DateTime?) dr["dtmFechaModif"];
				vehiculoskmmantenimiento.lngIdUsuario = dr.IsNull("lngIdUsuario") ? null :(int?) dr["lngIdUsuario"];
			}
			catch (Exception ex)
			{
				Utilidades.LogErrores(ex.Message + (ex.InnerException != null ? ex.InnerException.Message : ""), DataProvider.AplicacionNombre);
				throw ex;
			}
			if (generateUndo) vehiculoskmmantenimiento.GenerateUndo();
		}

		/// <summary>
		/// Create a new VehiculosKmMantenimiento object by passing a object
		/// </summary>
		public VehiculosKmMantenimiento Create(VehiculosKmMantenimiento vehiculoskmmantenimiento, Sinapsys.Datos.SQL datosTransaccion=null)
		{
			return Create(vehiculoskmmantenimiento.strPlaca,vehiculoskmmantenimiento.lngIdTipoMantenimiento,vehiculoskmmantenimiento.dtmFechaUltimoCambio,vehiculoskmmantenimiento.intKmUltimoCambio,vehiculoskmmantenimiento.intKmSiguiente,vehiculoskmmantenimiento.intKmAcumulado,vehiculoskmmantenimiento.dtmFechaUltimoUltimoAcumu,vehiculoskmmantenimiento.intKmAlarma1,vehiculoskmmantenimiento.intKmAlarma2,vehiculoskmmantenimiento.logAvisa,vehiculoskmmantenimiento.dtmFechaDetener,vehiculoskmmantenimiento.strLugarDetener,vehiculoskmmantenimiento.dtmFechaModif,vehiculoskmmantenimiento.lngIdUsuario,datosTransaccion);
		}

		/// <summary>
		/// Creates a new VehiculosKmMantenimiento object by passing all object's fields
		/// </summary>
		/// <param name="dtmFechaUltimoCambio">DateTime that contents the dtmFechaUltimoCambio value for the VehiculosKmMantenimiento object</param>
		/// <param name="intKmUltimoCambio">int that contents the intKmUltimoCambio value for the VehiculosKmMantenimiento object</param>
		/// <param name="intKmSiguiente">int that contents the intKmSiguiente value for the VehiculosKmMantenimiento object</param>
		/// <param name="intKmAcumulado">int that contents the intKmAcumulado value for the VehiculosKmMantenimiento object</param>
		/// <param name="dtmFechaUltimoUltimoAcumu">DateTime that contents the dtmFechaUltimoUltimoAcumu value for the VehiculosKmMantenimiento object</param>
		/// <param name="intKmAlarma1">int that contents the intKmAlarma1 value for the VehiculosKmMantenimiento object</param>
		/// <param name="intKmAlarma2">int that contents the intKmAlarma2 value for the VehiculosKmMantenimiento object</param>
		/// <param name="logAvisa">bool that contents the logAvisa value for the VehiculosKmMantenimiento object</param>
		/// <param name="dtmFechaDetener">DateTime that contents the dtmFechaDetener value for the VehiculosKmMantenimiento object</param>
		/// <param name="strLugarDetener">string that contents the strLugarDetener value for the VehiculosKmMantenimiento object</param>
		/// <param name="dtmFechaModif">DateTime that contents the dtmFechaModif value for the VehiculosKmMantenimiento object</param>
		/// <param name="lngIdUsuario">int that contents the lngIdUsuario value for the VehiculosKmMantenimiento object</param>
		/// <returns>One VehiculosKmMantenimiento object</returns>
		public VehiculosKmMantenimiento Create(string strPlaca, int lngIdTipoMantenimiento, DateTime? dtmFechaUltimoCambio, int? intKmUltimoCambio, int? intKmSiguiente, int? intKmAcumulado, DateTime? dtmFechaUltimoUltimoAcumu, int? intKmAlarma1, int? intKmAlarma2, bool? logAvisa, DateTime? dtmFechaDetener, string strLugarDetener, DateTime? dtmFechaModif, int? lngIdUsuario, Sinapsys.Datos.SQL datosTransaccion=null)
		{
			try 
			{
				VehiculosKmMantenimiento vehiculoskmmantenimiento = new VehiculosKmMantenimiento();

				vehiculoskmmantenimiento.strPlaca = strPlaca;
				vehiculoskmmantenimiento.lngIdTipoMantenimiento = lngIdTipoMantenimiento;
				vehiculoskmmantenimiento.dtmFechaUltimoCambio = dtmFechaUltimoCambio;
				vehiculoskmmantenimiento.intKmUltimoCambio = intKmUltimoCambio;
				vehiculoskmmantenimiento.intKmSiguiente = intKmSiguiente;
				vehiculoskmmantenimiento.intKmAcumulado = intKmAcumulado;
				vehiculoskmmantenimiento.dtmFechaUltimoUltimoAcumu = dtmFechaUltimoUltimoAcumu;
				vehiculoskmmantenimiento.intKmAlarma1 = intKmAlarma1;
				vehiculoskmmantenimiento.intKmAlarma2 = intKmAlarma2;
				vehiculoskmmantenimiento.logAvisa = logAvisa;
				vehiculoskmmantenimiento.dtmFechaDetener = dtmFechaDetener;
				vehiculoskmmantenimiento.strLugarDetener = strLugarDetener;
				vehiculoskmmantenimiento.dtmFechaModif = dtmFechaModif;
				vehiculoskmmantenimiento.lngIdUsuario = lngIdUsuario;
				VehiculosKmMantenimientoDataProvider.Instance.Create(strPlaca, lngIdTipoMantenimiento, dtmFechaUltimoCambio, intKmUltimoCambio, intKmSiguiente, intKmAcumulado, dtmFechaUltimoUltimoAcumu, intKmAlarma1, intKmAlarma2, logAvisa, dtmFechaDetener, strLugarDetener, dtmFechaModif, lngIdUsuario,"VehiculosKmMantenimiento");

				return vehiculoskmmantenimiento;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Updates an VehiculosKmMantenimiento object by passing all object's fields
		/// </summary>
		/// <param name="strPlaca">string that contents the strPlaca value for the VehiculosKmMantenimiento object</param>
		/// <param name="lngIdTipoMantenimiento">int that contents the lngIdTipoMantenimiento value for the VehiculosKmMantenimiento object</param>
		/// <param name="dtmFechaUltimoCambio">DateTime that contents the dtmFechaUltimoCambio value for the VehiculosKmMantenimiento object</param>
		/// <param name="intKmUltimoCambio">int that contents the intKmUltimoCambio value for the VehiculosKmMantenimiento object</param>
		/// <param name="intKmSiguiente">int that contents the intKmSiguiente value for the VehiculosKmMantenimiento object</param>
		/// <param name="intKmAcumulado">int that contents the intKmAcumulado value for the VehiculosKmMantenimiento object</param>
		/// <param name="dtmFechaUltimoUltimoAcumu">DateTime that contents the dtmFechaUltimoUltimoAcumu value for the VehiculosKmMantenimiento object</param>
		/// <param name="intKmAlarma1">int that contents the intKmAlarma1 value for the VehiculosKmMantenimiento object</param>
		/// <param name="intKmAlarma2">int that contents the intKmAlarma2 value for the VehiculosKmMantenimiento object</param>
		/// <param name="logAvisa">bool that contents the logAvisa value for the VehiculosKmMantenimiento object</param>
		/// <param name="dtmFechaDetener">DateTime that contents the dtmFechaDetener value for the VehiculosKmMantenimiento object</param>
		/// <param name="strLugarDetener">string that contents the strLugarDetener value for the VehiculosKmMantenimiento object</param>
		/// <param name="dtmFechaModif">DateTime that contents the dtmFechaModif value for the VehiculosKmMantenimiento object</param>
		/// <param name="lngIdUsuario">int that contents the lngIdUsuario value for the VehiculosKmMantenimiento object</param>
		public void Update(string strPlaca, int lngIdTipoMantenimiento, DateTime? dtmFechaUltimoCambio, int? intKmUltimoCambio, int? intKmSiguiente, int? intKmAcumulado, DateTime? dtmFechaUltimoUltimoAcumu, int? intKmAlarma1, int? intKmAlarma2, bool? logAvisa, DateTime? dtmFechaDetener, string strLugarDetener, DateTime? dtmFechaModif, int? lngIdUsuario, Sinapsys.Datos.SQL datosTransaccion=null)
		{
			try 
			{
				VehiculosKmMantenimiento new_values = new VehiculosKmMantenimiento();
				new_values.dtmFechaUltimoCambio = dtmFechaUltimoCambio;
				new_values.intKmUltimoCambio = intKmUltimoCambio;
				new_values.intKmSiguiente = intKmSiguiente;
				new_values.intKmAcumulado = intKmAcumulado;
				new_values.dtmFechaUltimoUltimoAcumu = dtmFechaUltimoUltimoAcumu;
				new_values.intKmAlarma1 = intKmAlarma1;
				new_values.intKmAlarma2 = intKmAlarma2;
				new_values.logAvisa = logAvisa;
				new_values.dtmFechaDetener = dtmFechaDetener;
				new_values.strLugarDetener = strLugarDetener;
				new_values.dtmFechaModif = dtmFechaModif;
				new_values.lngIdUsuario = lngIdUsuario;
				VehiculosKmMantenimientoDataProvider.Instance.Update(strPlaca, lngIdTipoMantenimiento, dtmFechaUltimoCambio, intKmUltimoCambio, intKmSiguiente, intKmAcumulado, dtmFechaUltimoUltimoAcumu, intKmAlarma1, intKmAlarma2, logAvisa, dtmFechaDetener, strLugarDetener, dtmFechaModif, lngIdUsuario,"VehiculosKmMantenimiento",datosTransaccion);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Updates an VehiculosKmMantenimiento object by passing one object's instance as reference
		/// </summary>
		/// <param name="vehiculoskmmantenimiento">An instance of VehiculosKmMantenimiento for reference</param>
		public void Update(VehiculosKmMantenimiento vehiculoskmmantenimiento,Sinapsys.Datos.SQL datosTransaccion=null)
		{
			Update(vehiculoskmmantenimiento.strPlaca, vehiculoskmmantenimiento.lngIdTipoMantenimiento, vehiculoskmmantenimiento.dtmFechaUltimoCambio, vehiculoskmmantenimiento.intKmUltimoCambio, vehiculoskmmantenimiento.intKmSiguiente, vehiculoskmmantenimiento.intKmAcumulado, vehiculoskmmantenimiento.dtmFechaUltimoUltimoAcumu, vehiculoskmmantenimiento.intKmAlarma1, vehiculoskmmantenimiento.intKmAlarma2, vehiculoskmmantenimiento.logAvisa, vehiculoskmmantenimiento.dtmFechaDetener, vehiculoskmmantenimiento.strLugarDetener, vehiculoskmmantenimiento.dtmFechaModif, vehiculoskmmantenimiento.lngIdUsuario);
		}

		/// <summary>
		/// Delete  the VehiculosKmMantenimiento object by passing a object
		/// </summary>
		public void  Delete(VehiculosKmMantenimiento vehiculoskmmantenimiento, Sinapsys.Datos.SQL datosTransaccion=null)
		{
			Delete(vehiculoskmmantenimiento.strPlaca, vehiculoskmmantenimiento.lngIdTipoMantenimiento,datosTransaccion);
		}

		/// <summary>
		/// Deletes the VehiculosKmMantenimiento object by passing one object's instance as reference
		/// </summary>
		/// <param name="vehiculoskmmantenimiento">An instance of VehiculosKmMantenimiento for reference</param>
		public void Delete(string strPlaca, int lngIdTipoMantenimiento, Sinapsys.Datos.SQL datosTransaccion=null)
		{
			try 
			{
				VehiculosKmMantenimientoDataProvider.Instance.Delete(strPlaca, lngIdTipoMantenimiento,"VehiculosKmMantenimiento");
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Deletes the VehiculosKmMantenimiento object by passing CVS parameter as reference
		/// </summary>
		/// <param name="vehiculoskmmantenimiento">An instance of VehiculosKmMantenimiento for reference</param>
		public void Delete(string CVSParameter)
		{
			string[] StrCommand=CVSParameter.Split(',');
			try 
			{
				string strPlaca=StrCommand[0];
				int lngIdTipoMantenimiento=int.Parse(StrCommand[1]);
				VehiculosKmMantenimientoDataProvider.Instance.Delete(strPlaca, lngIdTipoMantenimiento,"VehiculosKmMantenimiento");
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Gets the VehiculosKmMantenimiento object by passing the object's key fields
		/// </summary>
		/// <param name="strPlaca">string that contents the strPlaca value for the VehiculosKmMantenimiento object</param>
		/// <param name="lngIdTipoMantenimiento">int that contents the lngIdTipoMantenimiento value for the VehiculosKmMantenimiento object</param>
		/// <returns>One VehiculosKmMantenimiento object</returns>
		public VehiculosKmMantenimiento Get(string strPlaca, int lngIdTipoMantenimiento, bool generateUndo=false)
		{
			try 
			{
				VehiculosKmMantenimiento vehiculoskmmantenimiento = null;
				DataTable dt = VehiculosKmMantenimientoDataProvider.Instance.Get(strPlaca, lngIdTipoMantenimiento);
				if ((dt.Rows.Count > 0))
				{
					vehiculoskmmantenimiento = new VehiculosKmMantenimiento();
					DataRow dr = dt.Rows[0];
					ReadData(vehiculoskmmantenimiento, dr, generateUndo);
				}


				return vehiculoskmmantenimiento;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Gets all objects of VehiculosKmMantenimiento
		/// </summary>
		/// <returns>One VehiculosKmMantenimientoList object</returns>
		public VehiculosKmMantenimientoList GetAll(bool generateUndo=false)
		{
			try 
			{
				VehiculosKmMantenimientoList vehiculoskmmantenimientolist = new VehiculosKmMantenimientoList();
				DataTable dt = VehiculosKmMantenimientoDataProvider.Instance.GetAll();
				foreach (DataRow dr in dt.Rows)
				{
					VehiculosKmMantenimiento vehiculoskmmantenimiento = new VehiculosKmMantenimiento();
					ReadData(vehiculoskmmantenimiento, dr, generateUndo);
					vehiculoskmmantenimientolist.Add(vehiculoskmmantenimiento);
				}
				return vehiculoskmmantenimientolist;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Gets all objects of VehiculosKmMantenimiento applying filter and sort criteria
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
		/// <returns>One VehiculosKmMantenimientoList object</returns>
		public VehiculosKmMantenimientoList GetFilter(int pagenum, int pagesize, string filter, string sort, string extablesfilter, string extablesfieldsfilter, string extablesrelationsfilter, string extablessort, string extablesfieldssort, string extablesrelationssort, bool generateUndo=false)
		{
			try 
			{
				VehiculosKmMantenimientoList vehiculoskmmantenimientolist = new VehiculosKmMantenimientoList();

				DataTable dt = VehiculosKmMantenimientoDataProvider.Instance.GetFilter(pagenum, pagesize, filter, sort, extablesfilter, extablesfieldsfilter, extablesrelationsfilter, extablessort, extablesfieldssort, extablesrelationssort);

				foreach (DataRow dr in dt.Rows)
				{
					VehiculosKmMantenimiento vehiculoskmmantenimiento = new VehiculosKmMantenimiento();
					ReadData(vehiculoskmmantenimiento, dr, generateUndo);
					vehiculoskmmantenimientolist.Add(vehiculoskmmantenimiento);
				}
				return vehiculoskmmantenimientolist;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public VehiculosKmMantenimientoList GetFilter( string filter, string sort, bool generateUndo=false)
		{
			return GetFilter(0,0, filter, sort, "","","","","","",generateUndo);
		}

		public VehiculosKmMantenimientoList GetFilter(string filter, string sort, string extablesfilter, string extablesfieldsfilter, string extablesrelationsfilter, string extablessort, string extablesfieldssort, string extablesrelationssort, bool generateUndo=false)
		{
			return GetFilter(0,0, filter, sort, extablesfilter, extablesfieldsfilter, extablesrelationsfilter, extablessort, extablesfieldssort, extablesrelationssort,generateUndo);
		}


		/// <summary>
		/// Returns the type for one property
		/// </summary>
		/// <param name="propertyname">Property's name for return its value</param>
		/// <returns>A value for the <paramref name="propertyname"/></returns>
		public Type GetMethodType( string propertyname,VehiculosKmMantenimiento vehiculoskmmantenimiento)
		{
			// Perform the search for the property's value
			switch (propertyname)
			{
				case "strPlaca":
					return vehiculoskmmantenimiento.strPlaca.GetType();

				case "lngIdTipoMantenimiento":
					return vehiculoskmmantenimiento.lngIdTipoMantenimiento.GetType();

				case "dtmFechaUltimoCambio":
					return vehiculoskmmantenimiento.dtmFechaUltimoCambio.GetType();

				case "intKmUltimoCambio":
					return vehiculoskmmantenimiento.intKmUltimoCambio.GetType();

				case "intKmSiguiente":
					return vehiculoskmmantenimiento.intKmSiguiente.GetType();

				case "intKmAcumulado":
					return vehiculoskmmantenimiento.intKmAcumulado.GetType();

				case "dtmFechaUltimoUltimoAcumu":
					return vehiculoskmmantenimiento.dtmFechaUltimoUltimoAcumu.GetType();

				case "intKmAlarma1":
					return vehiculoskmmantenimiento.intKmAlarma1.GetType();

				case "intKmAlarma2":
					return vehiculoskmmantenimiento.intKmAlarma2.GetType();

				case "logAvisa":
					return vehiculoskmmantenimiento.logAvisa.GetType();

				case "dtmFechaDetener":
					return vehiculoskmmantenimiento.dtmFechaDetener.GetType();

				case "strLugarDetener":
					return vehiculoskmmantenimiento.strLugarDetener.GetType();

				case "dtmFechaModif":
					return vehiculoskmmantenimiento.dtmFechaModif.GetType();

				case "lngIdUsuario":
					return vehiculoskmmantenimiento.lngIdUsuario.GetType();

			}

			return null;
		}
		/// <summary>
		/// update the changes in VehiculosKmMantenimiento object by passing the object
		/// </summary>
		public bool UpdateChanges(VehiculosKmMantenimiento vehiculoskmmantenimiento, out string error,Sinapsys.Datos.SQL datosTransaccion=null)
		{
			if (vehiculoskmmantenimiento.OldVehiculosKmMantenimiento == null)
			{
				    error = "No tiene objeto con el cual comparar";
				    return false;
			}
			string[] Fields = vehiculoskmmantenimiento.FieldChanged();
			error = "";
			return LiqViajes_Bll_Data.DataProvider.UpdateFieldsbyObject(Fields, vehiculoskmmantenimiento, out error,datosTransaccion);
		}
	}

	#endregion

}
