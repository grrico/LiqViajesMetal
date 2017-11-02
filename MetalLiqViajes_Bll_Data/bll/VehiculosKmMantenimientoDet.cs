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
	#region VehiculosKmMantenimientoDetController

	/// <summary>
	/// Class for convert data from database into object's data and vice versa
	/// </summary>
	public partial class VehiculosKmMantenimientoDetController//: ILatinodeController
	{
		/// <summary>
		/// Generic Constructor
		/// </summary>
		public VehiculosKmMantenimientoDetController()
		{
		}

		/// <summary>
		/// Instance accessor for this singleton
		/// </summary>
		private static VehiculosKmMantenimientoDetController MySingleObj;
		public static VehiculosKmMantenimientoDetController Instance
		{
			get
			{
				if (MySingleObj == null)
				{
					MySingleObj = new VehiculosKmMantenimientoDetController();
				}
				return MySingleObj;
			}
		}

		// Reads object's data from a DataRow
		private void ReadData(VehiculosKmMantenimientoDet vehiculoskmmantenimientodet, DataRow dr,bool generateUndo=false)
		{
			try 
			{
				vehiculoskmmantenimientodet.lngIdRegistro = (int) dr["lngIdRegistro"];
				vehiculoskmmantenimientodet.strPlaca = dr.IsNull("strPlaca") ? null :(string) dr["strPlaca"];
				vehiculoskmmantenimientodet.lngIdTipoMantenimiento = dr.IsNull("lngIdTipoMantenimiento") ? null :(int?) dr["lngIdTipoMantenimiento"];
				vehiculoskmmantenimientodet.dtmFechaMovimiento = dr.IsNull("dtmFechaMovimiento") ? null :(DateTime?) dr["dtmFechaMovimiento"];
				vehiculoskmmantenimientodet.intKmUltimoCambio = dr.IsNull("intKmUltimoCambio") ? null :(int?) dr["intKmUltimoCambio"];
				vehiculoskmmantenimientodet.intKmSiguiente = dr.IsNull("intKmSiguiente") ? null :(int?) dr["intKmSiguiente"];
				vehiculoskmmantenimientodet.intAcumulado = dr.IsNull("intAcumulado") ? null :(int?) dr["intAcumulado"];
				vehiculoskmmantenimientodet.intKmRestantes = dr.IsNull("intKmRestantes") ? null :(int?) dr["intKmRestantes"];
				vehiculoskmmantenimientodet.strObservaciones = dr.IsNull("strObservaciones") ? null :(string) dr["strObservaciones"];
				vehiculoskmmantenimientodet.dtmFechaModif = dr.IsNull("dtmFechaModif") ? null :(DateTime?) dr["dtmFechaModif"];
				vehiculoskmmantenimientodet.lngIdUsuario = dr.IsNull("lngIdUsuario") ? null :(int?) dr["lngIdUsuario"];
			}
			catch (Exception ex)
			{
				Utilidades.LogErrores(ex.Message + (ex.InnerException != null ? ex.InnerException.Message : ""), DataProvider.AplicacionNombre);
				throw ex;
			}
			if (generateUndo) vehiculoskmmantenimientodet.GenerateUndo();
		}

		/// <summary>
		/// Create a new VehiculosKmMantenimientoDet object by passing a object
		/// </summary>
		public VehiculosKmMantenimientoDet Create(VehiculosKmMantenimientoDet vehiculoskmmantenimientodet, Sinapsys.Datos.SQL datosTransaccion=null)
		{
			return Create(vehiculoskmmantenimientodet.lngIdRegistro,vehiculoskmmantenimientodet.strPlaca,vehiculoskmmantenimientodet.lngIdTipoMantenimiento,vehiculoskmmantenimientodet.dtmFechaMovimiento,vehiculoskmmantenimientodet.intKmUltimoCambio,vehiculoskmmantenimientodet.intKmSiguiente,vehiculoskmmantenimientodet.intAcumulado,vehiculoskmmantenimientodet.intKmRestantes,vehiculoskmmantenimientodet.strObservaciones,vehiculoskmmantenimientodet.dtmFechaModif,vehiculoskmmantenimientodet.lngIdUsuario,datosTransaccion);
		}

		/// <summary>
		/// Creates a new VehiculosKmMantenimientoDet object by passing all object's fields
		/// </summary>
		/// <param name="strPlaca">string that contents the strPlaca value for the VehiculosKmMantenimientoDet object</param>
		/// <param name="lngIdTipoMantenimiento">int that contents the lngIdTipoMantenimiento value for the VehiculosKmMantenimientoDet object</param>
		/// <param name="dtmFechaMovimiento">DateTime that contents the dtmFechaMovimiento value for the VehiculosKmMantenimientoDet object</param>
		/// <param name="intKmUltimoCambio">int that contents the intKmUltimoCambio value for the VehiculosKmMantenimientoDet object</param>
		/// <param name="intKmSiguiente">int that contents the intKmSiguiente value for the VehiculosKmMantenimientoDet object</param>
		/// <param name="intAcumulado">int that contents the intAcumulado value for the VehiculosKmMantenimientoDet object</param>
		/// <param name="intKmRestantes">int that contents the intKmRestantes value for the VehiculosKmMantenimientoDet object</param>
		/// <param name="strObservaciones">string that contents the strObservaciones value for the VehiculosKmMantenimientoDet object</param>
		/// <param name="dtmFechaModif">DateTime that contents the dtmFechaModif value for the VehiculosKmMantenimientoDet object</param>
		/// <param name="lngIdUsuario">int that contents the lngIdUsuario value for the VehiculosKmMantenimientoDet object</param>
		/// <returns>One VehiculosKmMantenimientoDet object</returns>
		public VehiculosKmMantenimientoDet Create(int lngIdRegistro, string strPlaca, int? lngIdTipoMantenimiento, DateTime? dtmFechaMovimiento, int? intKmUltimoCambio, int? intKmSiguiente, int? intAcumulado, int? intKmRestantes, string strObservaciones, DateTime? dtmFechaModif, int? lngIdUsuario, Sinapsys.Datos.SQL datosTransaccion=null)
		{
			try 
			{
				VehiculosKmMantenimientoDet vehiculoskmmantenimientodet = new VehiculosKmMantenimientoDet();

				vehiculoskmmantenimientodet.lngIdRegistro = lngIdRegistro;
				vehiculoskmmantenimientodet.lngIdRegistro = lngIdRegistro;
				vehiculoskmmantenimientodet.strPlaca = strPlaca;
				vehiculoskmmantenimientodet.lngIdTipoMantenimiento = lngIdTipoMantenimiento;
				vehiculoskmmantenimientodet.dtmFechaMovimiento = dtmFechaMovimiento;
				vehiculoskmmantenimientodet.intKmUltimoCambio = intKmUltimoCambio;
				vehiculoskmmantenimientodet.intKmSiguiente = intKmSiguiente;
				vehiculoskmmantenimientodet.intAcumulado = intAcumulado;
				vehiculoskmmantenimientodet.intKmRestantes = intKmRestantes;
				vehiculoskmmantenimientodet.strObservaciones = strObservaciones;
				vehiculoskmmantenimientodet.dtmFechaModif = dtmFechaModif;
				vehiculoskmmantenimientodet.lngIdUsuario = lngIdUsuario;
				lngIdRegistro = VehiculosKmMantenimientoDetDataProvider.Instance.Create(lngIdRegistro, strPlaca, lngIdTipoMantenimiento, dtmFechaMovimiento, intKmUltimoCambio, intKmSiguiente, intAcumulado, intKmRestantes, strObservaciones, dtmFechaModif, lngIdUsuario,"VehiculosKmMantenimientoDet",datosTransaccion);
				if (lngIdRegistro == 0)
					return null;

				vehiculoskmmantenimientodet.lngIdRegistro = lngIdRegistro;

				return vehiculoskmmantenimientodet;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Updates an VehiculosKmMantenimientoDet object by passing all object's fields
		/// </summary>
		/// <param name="lngIdRegistro">int that contents the lngIdRegistro value for the VehiculosKmMantenimientoDet object</param>
		/// <param name="strPlaca">string that contents the strPlaca value for the VehiculosKmMantenimientoDet object</param>
		/// <param name="lngIdTipoMantenimiento">int that contents the lngIdTipoMantenimiento value for the VehiculosKmMantenimientoDet object</param>
		/// <param name="dtmFechaMovimiento">DateTime that contents the dtmFechaMovimiento value for the VehiculosKmMantenimientoDet object</param>
		/// <param name="intKmUltimoCambio">int that contents the intKmUltimoCambio value for the VehiculosKmMantenimientoDet object</param>
		/// <param name="intKmSiguiente">int that contents the intKmSiguiente value for the VehiculosKmMantenimientoDet object</param>
		/// <param name="intAcumulado">int that contents the intAcumulado value for the VehiculosKmMantenimientoDet object</param>
		/// <param name="intKmRestantes">int that contents the intKmRestantes value for the VehiculosKmMantenimientoDet object</param>
		/// <param name="strObservaciones">string that contents the strObservaciones value for the VehiculosKmMantenimientoDet object</param>
		/// <param name="dtmFechaModif">DateTime that contents the dtmFechaModif value for the VehiculosKmMantenimientoDet object</param>
		/// <param name="lngIdUsuario">int that contents the lngIdUsuario value for the VehiculosKmMantenimientoDet object</param>
		public void Update(int lngIdRegistro, string strPlaca, int? lngIdTipoMantenimiento, DateTime? dtmFechaMovimiento, int? intKmUltimoCambio, int? intKmSiguiente, int? intAcumulado, int? intKmRestantes, string strObservaciones, DateTime? dtmFechaModif, int? lngIdUsuario, Sinapsys.Datos.SQL datosTransaccion=null)
		{
			try 
			{
				VehiculosKmMantenimientoDet new_values = new VehiculosKmMantenimientoDet();
				new_values.strPlaca = strPlaca;
				new_values.lngIdTipoMantenimiento = lngIdTipoMantenimiento;
				new_values.dtmFechaMovimiento = dtmFechaMovimiento;
				new_values.intKmUltimoCambio = intKmUltimoCambio;
				new_values.intKmSiguiente = intKmSiguiente;
				new_values.intAcumulado = intAcumulado;
				new_values.intKmRestantes = intKmRestantes;
				new_values.strObservaciones = strObservaciones;
				new_values.dtmFechaModif = dtmFechaModif;
				new_values.lngIdUsuario = lngIdUsuario;
				VehiculosKmMantenimientoDetDataProvider.Instance.Update(lngIdRegistro, strPlaca, lngIdTipoMantenimiento, dtmFechaMovimiento, intKmUltimoCambio, intKmSiguiente, intAcumulado, intKmRestantes, strObservaciones, dtmFechaModif, lngIdUsuario,"VehiculosKmMantenimientoDet",datosTransaccion);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Updates an VehiculosKmMantenimientoDet object by passing one object's instance as reference
		/// </summary>
		/// <param name="vehiculoskmmantenimientodet">An instance of VehiculosKmMantenimientoDet for reference</param>
		public void Update(VehiculosKmMantenimientoDet vehiculoskmmantenimientodet,Sinapsys.Datos.SQL datosTransaccion=null)
		{
			Update(vehiculoskmmantenimientodet.lngIdRegistro, vehiculoskmmantenimientodet.strPlaca, vehiculoskmmantenimientodet.lngIdTipoMantenimiento, vehiculoskmmantenimientodet.dtmFechaMovimiento, vehiculoskmmantenimientodet.intKmUltimoCambio, vehiculoskmmantenimientodet.intKmSiguiente, vehiculoskmmantenimientodet.intAcumulado, vehiculoskmmantenimientodet.intKmRestantes, vehiculoskmmantenimientodet.strObservaciones, vehiculoskmmantenimientodet.dtmFechaModif, vehiculoskmmantenimientodet.lngIdUsuario);
		}

		/// <summary>
		/// Delete  the VehiculosKmMantenimientoDet object by passing a object
		/// </summary>
		public void  Delete(VehiculosKmMantenimientoDet vehiculoskmmantenimientodet, Sinapsys.Datos.SQL datosTransaccion=null)
		{
			Delete(vehiculoskmmantenimientodet.lngIdRegistro,datosTransaccion);
		}

		/// <summary>
		/// Deletes the VehiculosKmMantenimientoDet object by passing one object's instance as reference
		/// </summary>
		/// <param name="vehiculoskmmantenimientodet">An instance of VehiculosKmMantenimientoDet for reference</param>
		public void Delete(int lngIdRegistro, Sinapsys.Datos.SQL datosTransaccion=null)
		{
			try 
			{
				//VehiculosKmMantenimientoDet old_values = VehiculosKmMantenimientoDetController.Instance.Get(lngIdRegistro);
				//if(!Validate.security.CanDeleteSecurityField(VehiculosKmMantenimientoDetController.Instance, (ILatinodeObject)old_values))
				//    throw new Exception("Access denied by security field, you can't delete object");

				VehiculosKmMantenimientoDetDataProvider.Instance.Delete(lngIdRegistro,"VehiculosKmMantenimientoDet");
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Deletes the VehiculosKmMantenimientoDet object by passing CVS parameter as reference
		/// </summary>
		/// <param name="vehiculoskmmantenimientodet">An instance of VehiculosKmMantenimientoDet for reference</param>
		public void Delete(string CVSParameter)
		{
			string[] StrCommand=CVSParameter.Split(',');
			try 
			{
				int lngIdRegistro=int.Parse(StrCommand[0]);
				VehiculosKmMantenimientoDetDataProvider.Instance.Delete(lngIdRegistro,"VehiculosKmMantenimientoDet");
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Gets the VehiculosKmMantenimientoDet object by passing the object's key fields
		/// </summary>
		/// <param name="lngIdRegistro">int that contents the lngIdRegistro value for the VehiculosKmMantenimientoDet object</param>
		/// <returns>One VehiculosKmMantenimientoDet object</returns>
		public VehiculosKmMantenimientoDet Get(int lngIdRegistro, bool generateUndo=false)
		{
			try 
			{
				VehiculosKmMantenimientoDet vehiculoskmmantenimientodet = null;
				DataTable dt = VehiculosKmMantenimientoDetDataProvider.Instance.Get(lngIdRegistro);
				if ((dt.Rows.Count > 0))
				{
					vehiculoskmmantenimientodet = new VehiculosKmMantenimientoDet();
					DataRow dr = dt.Rows[0];
					ReadData(vehiculoskmmantenimientodet, dr, generateUndo);
				}


				return vehiculoskmmantenimientodet;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Gets all objects of VehiculosKmMantenimientoDet
		/// </summary>
		/// <returns>One VehiculosKmMantenimientoDetList object</returns>
		public VehiculosKmMantenimientoDetList GetAll(bool generateUndo=false)
		{
			try 
			{
				VehiculosKmMantenimientoDetList vehiculoskmmantenimientodetlist = new VehiculosKmMantenimientoDetList();
				DataTable dt = VehiculosKmMantenimientoDetDataProvider.Instance.GetAll();
				foreach (DataRow dr in dt.Rows)
				{
					VehiculosKmMantenimientoDet vehiculoskmmantenimientodet = new VehiculosKmMantenimientoDet();
					ReadData(vehiculoskmmantenimientodet, dr, generateUndo);
					vehiculoskmmantenimientodetlist.Add(vehiculoskmmantenimientodet);
				}
				return vehiculoskmmantenimientodetlist;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Gets all objects of VehiculosKmMantenimientoDet applying filter and sort criteria
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
		/// <returns>One VehiculosKmMantenimientoDetList object</returns>
		public VehiculosKmMantenimientoDetList GetFilter(int pagenum, int pagesize, string filter, string sort, string extablesfilter, string extablesfieldsfilter, string extablesrelationsfilter, string extablessort, string extablesfieldssort, string extablesrelationssort, bool generateUndo=false)
		{
			try 
			{
				VehiculosKmMantenimientoDetList vehiculoskmmantenimientodetlist = new VehiculosKmMantenimientoDetList();

				DataTable dt = VehiculosKmMantenimientoDetDataProvider.Instance.GetFilter(pagenum, pagesize, filter, sort, extablesfilter, extablesfieldsfilter, extablesrelationsfilter, extablessort, extablesfieldssort, extablesrelationssort);

				foreach (DataRow dr in dt.Rows)
				{
					VehiculosKmMantenimientoDet vehiculoskmmantenimientodet = new VehiculosKmMantenimientoDet();
					ReadData(vehiculoskmmantenimientodet, dr, generateUndo);
					vehiculoskmmantenimientodetlist.Add(vehiculoskmmantenimientodet);
				}
				return vehiculoskmmantenimientodetlist;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public VehiculosKmMantenimientoDetList GetFilter( string filter, string sort, bool generateUndo=false)
		{
			return GetFilter(0,0, filter, sort, "","","","","","",generateUndo);
		}

		public VehiculosKmMantenimientoDetList GetFilter(string filter, string sort, string extablesfilter, string extablesfieldsfilter, string extablesrelationsfilter, string extablessort, string extablesfieldssort, string extablesrelationssort, bool generateUndo=false)
		{
			return GetFilter(0,0, filter, sort, extablesfilter, extablesfieldsfilter, extablesrelationsfilter, extablessort, extablesfieldssort, extablesrelationssort,generateUndo);
		}


		/// <summary>
		/// Returns the type for one property
		/// </summary>
		/// <param name="propertyname">Property's name for return its value</param>
		/// <returns>A value for the <paramref name="propertyname"/></returns>
		public Type GetMethodType( string propertyname,VehiculosKmMantenimientoDet vehiculoskmmantenimientodet)
		{
			// Perform the search for the property's value
			switch (propertyname)
			{
				case "lngIdRegistro":
					return vehiculoskmmantenimientodet.lngIdRegistro.GetType();

				case "strPlaca":
					return vehiculoskmmantenimientodet.strPlaca.GetType();

				case "lngIdTipoMantenimiento":
					return vehiculoskmmantenimientodet.lngIdTipoMantenimiento.GetType();

				case "dtmFechaMovimiento":
					return vehiculoskmmantenimientodet.dtmFechaMovimiento.GetType();

				case "intKmUltimoCambio":
					return vehiculoskmmantenimientodet.intKmUltimoCambio.GetType();

				case "intKmSiguiente":
					return vehiculoskmmantenimientodet.intKmSiguiente.GetType();

				case "intAcumulado":
					return vehiculoskmmantenimientodet.intAcumulado.GetType();

				case "intKmRestantes":
					return vehiculoskmmantenimientodet.intKmRestantes.GetType();

				case "strObservaciones":
					return vehiculoskmmantenimientodet.strObservaciones.GetType();

				case "dtmFechaModif":
					return vehiculoskmmantenimientodet.dtmFechaModif.GetType();

				case "lngIdUsuario":
					return vehiculoskmmantenimientodet.lngIdUsuario.GetType();

			}

			return null;
		}
		/// <summary>
		/// update the changes in VehiculosKmMantenimientoDet object by passing the object
		/// </summary>
		public bool UpdateChanges(VehiculosKmMantenimientoDet vehiculoskmmantenimientodet, out string error,Sinapsys.Datos.SQL datosTransaccion=null)
		{
			if (vehiculoskmmantenimientodet.OldVehiculosKmMantenimientoDet == null)
			{
				    error = "No tiene objeto con el cual comparar";
				    return false;
			}
			string[] Fields = vehiculoskmmantenimientodet.FieldChanged();
			error = "";
			return LiqViajes_Bll_Data.DataProvider.UpdateFieldsbyObject(Fields, vehiculoskmmantenimientodet, out error,datosTransaccion);
		}
	}

	#endregion

}
