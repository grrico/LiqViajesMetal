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
	#region VehiculosKmMantenimientoDetAcumController

	/// <summary>
	/// Class for convert data from database into object's data and vice versa
	/// </summary>
	public partial class VehiculosKmMantenimientoDetAcumController//: ILatinodeController
	{
		/// <summary>
		/// Generic Constructor
		/// </summary>
		public VehiculosKmMantenimientoDetAcumController()
		{
		}

		/// <summary>
		/// Instance accessor for this singleton
		/// </summary>
		private static VehiculosKmMantenimientoDetAcumController MySingleObj;
		public static VehiculosKmMantenimientoDetAcumController Instance
		{
			get
			{
				if (MySingleObj == null)
				{
					MySingleObj = new VehiculosKmMantenimientoDetAcumController();
				}
				return MySingleObj;
			}
		}

		// Reads object's data from a DataRow
		private void ReadData(VehiculosKmMantenimientoDetAcum vehiculoskmmantenimientodetacum, DataRow dr,bool generateUndo=false)
		{
			try 
			{
				vehiculoskmmantenimientodetacum.strPlaca = dr.IsNull("strPlaca") ? null :(string) dr["strPlaca"];
				vehiculoskmmantenimientodetacum.strDetalleAcumuado = dr.IsNull("strDetalleAcumuado") ? null :(string) dr["strDetalleAcumuado"];
				vehiculoskmmantenimientodetacum.drmFechaMovimiento = dr.IsNull("drmFechaMovimiento") ? null :(DateTime?) dr["drmFechaMovimiento"];
				vehiculoskmmantenimientodetacum.intKmMovimiento = dr.IsNull("intKmMovimiento") ? null :(int?) dr["intKmMovimiento"];
				vehiculoskmmantenimientodetacum.dtmFechaModif = dr.IsNull("dtmFechaModif") ? null :(DateTime?) dr["dtmFechaModif"];
				vehiculoskmmantenimientodetacum.lngIdUsuario = dr.IsNull("lngIdUsuario") ? null :(int?) dr["lngIdUsuario"];
				vehiculoskmmantenimientodetacum.lngIdRegistro = (int) dr["lngIdRegistro"];
			}
			catch (Exception ex)
			{
				Utilidades.LogErrores(ex.Message + (ex.InnerException != null ? ex.InnerException.Message : ""), DataProvider.AplicacionNombre);
				throw ex;
			}
			if (generateUndo) vehiculoskmmantenimientodetacum.GenerateUndo();
		}

		/// <summary>
		/// Create a new VehiculosKmMantenimientoDetAcum object by passing a object
		/// </summary>
		public VehiculosKmMantenimientoDetAcum Create(VehiculosKmMantenimientoDetAcum vehiculoskmmantenimientodetacum, Sinapsys.Datos.SQL datosTransaccion=null)
		{
			return Create(vehiculoskmmantenimientodetacum.lngIdRegistro,vehiculoskmmantenimientodetacum.strPlaca,vehiculoskmmantenimientodetacum.strDetalleAcumuado,vehiculoskmmantenimientodetacum.drmFechaMovimiento,vehiculoskmmantenimientodetacum.intKmMovimiento,vehiculoskmmantenimientodetacum.dtmFechaModif,vehiculoskmmantenimientodetacum.lngIdUsuario,datosTransaccion);
		}

		/// <summary>
		/// Creates a new VehiculosKmMantenimientoDetAcum object by passing all object's fields
		/// </summary>
		/// <param name="strPlaca">string that contents the strPlaca value for the VehiculosKmMantenimientoDetAcum object</param>
		/// <param name="strDetalleAcumuado">string that contents the strDetalleAcumuado value for the VehiculosKmMantenimientoDetAcum object</param>
		/// <param name="drmFechaMovimiento">DateTime that contents the drmFechaMovimiento value for the VehiculosKmMantenimientoDetAcum object</param>
		/// <param name="intKmMovimiento">int that contents the intKmMovimiento value for the VehiculosKmMantenimientoDetAcum object</param>
		/// <param name="dtmFechaModif">DateTime that contents the dtmFechaModif value for the VehiculosKmMantenimientoDetAcum object</param>
		/// <param name="lngIdUsuario">int that contents the lngIdUsuario value for the VehiculosKmMantenimientoDetAcum object</param>
		/// <returns>One VehiculosKmMantenimientoDetAcum object</returns>
		public VehiculosKmMantenimientoDetAcum Create(int lngIdRegistro, string strPlaca, string strDetalleAcumuado, DateTime? drmFechaMovimiento, int? intKmMovimiento, DateTime? dtmFechaModif, int? lngIdUsuario, Sinapsys.Datos.SQL datosTransaccion=null)
		{
			try 
			{
				VehiculosKmMantenimientoDetAcum vehiculoskmmantenimientodetacum = new VehiculosKmMantenimientoDetAcum();

				vehiculoskmmantenimientodetacum.lngIdRegistro = lngIdRegistro;
				vehiculoskmmantenimientodetacum.lngIdRegistro = lngIdRegistro;
				vehiculoskmmantenimientodetacum.strPlaca = strPlaca;
				vehiculoskmmantenimientodetacum.strDetalleAcumuado = strDetalleAcumuado;
				vehiculoskmmantenimientodetacum.drmFechaMovimiento = drmFechaMovimiento;
				vehiculoskmmantenimientodetacum.intKmMovimiento = intKmMovimiento;
				vehiculoskmmantenimientodetacum.dtmFechaModif = dtmFechaModif;
				vehiculoskmmantenimientodetacum.lngIdUsuario = lngIdUsuario;
				lngIdRegistro = VehiculosKmMantenimientoDetAcumDataProvider.Instance.Create(lngIdRegistro, strPlaca, strDetalleAcumuado, drmFechaMovimiento, intKmMovimiento, dtmFechaModif, lngIdUsuario,"VehiculosKmMantenimientoDetAcum",datosTransaccion);
				if (lngIdRegistro == 0)
					return null;

				vehiculoskmmantenimientodetacum.lngIdRegistro = lngIdRegistro;

				return vehiculoskmmantenimientodetacum;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Updates an VehiculosKmMantenimientoDetAcum object by passing all object's fields
		/// </summary>
		/// <param name="strPlaca">string that contents the strPlaca value for the VehiculosKmMantenimientoDetAcum object</param>
		/// <param name="strDetalleAcumuado">string that contents the strDetalleAcumuado value for the VehiculosKmMantenimientoDetAcum object</param>
		/// <param name="drmFechaMovimiento">DateTime that contents the drmFechaMovimiento value for the VehiculosKmMantenimientoDetAcum object</param>
		/// <param name="intKmMovimiento">int that contents the intKmMovimiento value for the VehiculosKmMantenimientoDetAcum object</param>
		/// <param name="dtmFechaModif">DateTime that contents the dtmFechaModif value for the VehiculosKmMantenimientoDetAcum object</param>
		/// <param name="lngIdUsuario">int that contents the lngIdUsuario value for the VehiculosKmMantenimientoDetAcum object</param>
		/// <param name="lngIdRegistro">int that contents the lngIdRegistro value for the VehiculosKmMantenimientoDetAcum object</param>
		public void Update(string strPlaca, string strDetalleAcumuado, DateTime? drmFechaMovimiento, int? intKmMovimiento, DateTime? dtmFechaModif, int? lngIdUsuario, int lngIdRegistro, Sinapsys.Datos.SQL datosTransaccion=null)
		{
			try 
			{
				VehiculosKmMantenimientoDetAcum new_values = new VehiculosKmMantenimientoDetAcum();
				new_values.strPlaca = strPlaca;
				new_values.strDetalleAcumuado = strDetalleAcumuado;
				new_values.drmFechaMovimiento = drmFechaMovimiento;
				new_values.intKmMovimiento = intKmMovimiento;
				new_values.dtmFechaModif = dtmFechaModif;
				new_values.lngIdUsuario = lngIdUsuario;
				VehiculosKmMantenimientoDetAcumDataProvider.Instance.Update(strPlaca, strDetalleAcumuado, drmFechaMovimiento, intKmMovimiento, dtmFechaModif, lngIdUsuario, lngIdRegistro,"VehiculosKmMantenimientoDetAcum",datosTransaccion);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Updates an VehiculosKmMantenimientoDetAcum object by passing one object's instance as reference
		/// </summary>
		/// <param name="vehiculoskmmantenimientodetacum">An instance of VehiculosKmMantenimientoDetAcum for reference</param>
		public void Update(VehiculosKmMantenimientoDetAcum vehiculoskmmantenimientodetacum,Sinapsys.Datos.SQL datosTransaccion=null)
		{
			Update(vehiculoskmmantenimientodetacum.strPlaca, vehiculoskmmantenimientodetacum.strDetalleAcumuado, vehiculoskmmantenimientodetacum.drmFechaMovimiento, vehiculoskmmantenimientodetacum.intKmMovimiento, vehiculoskmmantenimientodetacum.dtmFechaModif, vehiculoskmmantenimientodetacum.lngIdUsuario, vehiculoskmmantenimientodetacum.lngIdRegistro);
		}

		/// <summary>
		/// Delete  the VehiculosKmMantenimientoDetAcum object by passing a object
		/// </summary>
		public void  Delete(VehiculosKmMantenimientoDetAcum vehiculoskmmantenimientodetacum, Sinapsys.Datos.SQL datosTransaccion=null)
		{
			Delete(vehiculoskmmantenimientodetacum.lngIdRegistro,datosTransaccion);
		}

		/// <summary>
		/// Deletes the VehiculosKmMantenimientoDetAcum object by passing one object's instance as reference
		/// </summary>
		/// <param name="vehiculoskmmantenimientodetacum">An instance of VehiculosKmMantenimientoDetAcum for reference</param>
		public void Delete(int lngIdRegistro, Sinapsys.Datos.SQL datosTransaccion=null)
		{
			try 
			{
				//VehiculosKmMantenimientoDetAcum old_values = VehiculosKmMantenimientoDetAcumController.Instance.Get(lngIdRegistro);
				//if(!Validate.security.CanDeleteSecurityField(VehiculosKmMantenimientoDetAcumController.Instance, (ILatinodeObject)old_values))
				//    throw new Exception("Access denied by security field, you can't delete object");

				VehiculosKmMantenimientoDetAcumDataProvider.Instance.Delete(lngIdRegistro,"VehiculosKmMantenimientoDetAcum");
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Deletes the VehiculosKmMantenimientoDetAcum object by passing CVS parameter as reference
		/// </summary>
		/// <param name="vehiculoskmmantenimientodetacum">An instance of VehiculosKmMantenimientoDetAcum for reference</param>
		public void Delete(string CVSParameter)
		{
			string[] StrCommand=CVSParameter.Split(',');
			try 
			{
				int lngIdRegistro=int.Parse(StrCommand[0]);
				VehiculosKmMantenimientoDetAcumDataProvider.Instance.Delete(lngIdRegistro,"VehiculosKmMantenimientoDetAcum");
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Gets the VehiculosKmMantenimientoDetAcum object by passing the object's key fields
		/// </summary>
		/// <param name="lngIdRegistro">int that contents the lngIdRegistro value for the VehiculosKmMantenimientoDetAcum object</param>
		/// <returns>One VehiculosKmMantenimientoDetAcum object</returns>
		public VehiculosKmMantenimientoDetAcum Get(int lngIdRegistro, bool generateUndo=false)
		{
			try 
			{
				VehiculosKmMantenimientoDetAcum vehiculoskmmantenimientodetacum = null;
				DataTable dt = VehiculosKmMantenimientoDetAcumDataProvider.Instance.Get(lngIdRegistro);
				if ((dt.Rows.Count > 0))
				{
					vehiculoskmmantenimientodetacum = new VehiculosKmMantenimientoDetAcum();
					DataRow dr = dt.Rows[0];
					ReadData(vehiculoskmmantenimientodetacum, dr, generateUndo);
				}


				return vehiculoskmmantenimientodetacum;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Gets all objects of VehiculosKmMantenimientoDetAcum
		/// </summary>
		/// <returns>One VehiculosKmMantenimientoDetAcumList object</returns>
		public VehiculosKmMantenimientoDetAcumList GetAll(bool generateUndo=false)
		{
			try 
			{
				VehiculosKmMantenimientoDetAcumList vehiculoskmmantenimientodetacumlist = new VehiculosKmMantenimientoDetAcumList();
				DataTable dt = VehiculosKmMantenimientoDetAcumDataProvider.Instance.GetAll();
				foreach (DataRow dr in dt.Rows)
				{
					VehiculosKmMantenimientoDetAcum vehiculoskmmantenimientodetacum = new VehiculosKmMantenimientoDetAcum();
					ReadData(vehiculoskmmantenimientodetacum, dr, generateUndo);
					vehiculoskmmantenimientodetacumlist.Add(vehiculoskmmantenimientodetacum);
				}
				return vehiculoskmmantenimientodetacumlist;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Gets all objects of VehiculosKmMantenimientoDetAcum applying filter and sort criteria
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
		/// <returns>One VehiculosKmMantenimientoDetAcumList object</returns>
		public VehiculosKmMantenimientoDetAcumList GetFilter(int pagenum, int pagesize, string filter, string sort, string extablesfilter, string extablesfieldsfilter, string extablesrelationsfilter, string extablessort, string extablesfieldssort, string extablesrelationssort, bool generateUndo=false)
		{
			try 
			{
				VehiculosKmMantenimientoDetAcumList vehiculoskmmantenimientodetacumlist = new VehiculosKmMantenimientoDetAcumList();

				DataTable dt = VehiculosKmMantenimientoDetAcumDataProvider.Instance.GetFilter(pagenum, pagesize, filter, sort, extablesfilter, extablesfieldsfilter, extablesrelationsfilter, extablessort, extablesfieldssort, extablesrelationssort);

				foreach (DataRow dr in dt.Rows)
				{
					VehiculosKmMantenimientoDetAcum vehiculoskmmantenimientodetacum = new VehiculosKmMantenimientoDetAcum();
					ReadData(vehiculoskmmantenimientodetacum, dr, generateUndo);
					vehiculoskmmantenimientodetacumlist.Add(vehiculoskmmantenimientodetacum);
				}
				return vehiculoskmmantenimientodetacumlist;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public VehiculosKmMantenimientoDetAcumList GetFilter( string filter, string sort, bool generateUndo=false)
		{
			return GetFilter(0,0, filter, sort, "","","","","","",generateUndo);
		}

		public VehiculosKmMantenimientoDetAcumList GetFilter(string filter, string sort, string extablesfilter, string extablesfieldsfilter, string extablesrelationsfilter, string extablessort, string extablesfieldssort, string extablesrelationssort, bool generateUndo=false)
		{
			return GetFilter(0,0, filter, sort, extablesfilter, extablesfieldsfilter, extablesrelationsfilter, extablessort, extablesfieldssort, extablesrelationssort,generateUndo);
		}


		/// <summary>
		/// Returns the type for one property
		/// </summary>
		/// <param name="propertyname">Property's name for return its value</param>
		/// <returns>A value for the <paramref name="propertyname"/></returns>
		public Type GetMethodType( string propertyname,VehiculosKmMantenimientoDetAcum vehiculoskmmantenimientodetacum)
		{
			// Perform the search for the property's value
			switch (propertyname)
			{
				case "strPlaca":
					return vehiculoskmmantenimientodetacum.strPlaca.GetType();

				case "strDetalleAcumuado":
					return vehiculoskmmantenimientodetacum.strDetalleAcumuado.GetType();

				case "drmFechaMovimiento":
					return vehiculoskmmantenimientodetacum.drmFechaMovimiento.GetType();

				case "intKmMovimiento":
					return vehiculoskmmantenimientodetacum.intKmMovimiento.GetType();

				case "dtmFechaModif":
					return vehiculoskmmantenimientodetacum.dtmFechaModif.GetType();

				case "lngIdUsuario":
					return vehiculoskmmantenimientodetacum.lngIdUsuario.GetType();

				case "lngIdRegistro":
					return vehiculoskmmantenimientodetacum.lngIdRegistro.GetType();

			}

			return null;
		}
		/// <summary>
		/// update the changes in VehiculosKmMantenimientoDetAcum object by passing the object
		/// </summary>
		public bool UpdateChanges(VehiculosKmMantenimientoDetAcum vehiculoskmmantenimientodetacum, out string error,Sinapsys.Datos.SQL datosTransaccion=null)
		{
			if (vehiculoskmmantenimientodetacum.OldVehiculosKmMantenimientoDetAcum == null)
			{
				    error = "No tiene objeto con el cual comparar";
				    return false;
			}
			string[] Fields = vehiculoskmmantenimientodetacum.FieldChanged();
			error = "";
			return LiqViajes_Bll_Data.DataProvider.UpdateFieldsbyObject(Fields, vehiculoskmmantenimientodetacum, out error,datosTransaccion);
		}
	}

	#endregion

}
