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
	#region TipoMantenimientoController

	/// <summary>
	/// Class for convert data from database into object's data and vice versa
	/// </summary>
	public partial class TipoMantenimientoController//: ILatinodeController
	{
		/// <summary>
		/// Generic Constructor
		/// </summary>
		public TipoMantenimientoController()
		{
		}

		/// <summary>
		/// Instance accessor for this singleton
		/// </summary>
		private static TipoMantenimientoController MySingleObj;
		public static TipoMantenimientoController Instance
		{
			get
			{
				if (MySingleObj == null)
				{
					MySingleObj = new TipoMantenimientoController();
				}
				return MySingleObj;
			}
		}

		// Reads object's data from a DataRow
		private void ReadData(TipoMantenimiento tipomantenimiento, DataRow dr,bool generateUndo=false)
		{
			try 
			{
				tipomantenimiento.strTipoMantenimiento = dr.IsNull("strTipoMantenimiento") ? null :(string) dr["strTipoMantenimiento"];
				tipomantenimiento.logActivar = dr.IsNull("logActivar") ? null :(bool?) dr["logActivar"];
				tipomantenimiento.intValorMantenimiento = dr.IsNull("intValorMantenimiento") ? null :(float?) dr["intValorMantenimiento"];
				tipomantenimiento.intValorAviso = dr.IsNull("intValorAviso") ? null :(float?) dr["intValorAviso"];
				tipomantenimiento.intValorAviso2 = dr.IsNull("intValorAviso2") ? null :(float?) dr["intValorAviso2"];
				tipomantenimiento.lngIdTipoMantenimiento = (int) dr["lngIdTipoMantenimiento"];
			}
			catch (Exception ex)
			{
				Utilidades.LogErrores(ex.Message + (ex.InnerException != null ? ex.InnerException.Message : ""), DataProvider.AplicacionNombre);
				throw ex;
			}
			if (generateUndo) tipomantenimiento.GenerateUndo();
		}

		/// <summary>
		/// Create a new TipoMantenimiento object by passing a object
		/// </summary>
		public TipoMantenimiento Create(TipoMantenimiento tipomantenimiento, Sinapsys.Datos.SQL datosTransaccion=null)
		{
			return Create(tipomantenimiento.lngIdTipoMantenimiento,tipomantenimiento.strTipoMantenimiento,tipomantenimiento.logActivar,tipomantenimiento.intValorMantenimiento,tipomantenimiento.intValorAviso,tipomantenimiento.intValorAviso2,datosTransaccion);
		}

		/// <summary>
		/// Creates a new TipoMantenimiento object by passing all object's fields
		/// </summary>
		/// <param name="strTipoMantenimiento">string that contents the strTipoMantenimiento value for the TipoMantenimiento object</param>
		/// <param name="logActivar">bool that contents the logActivar value for the TipoMantenimiento object</param>
		/// <param name="intValorMantenimiento">float that contents the intValorMantenimiento value for the TipoMantenimiento object</param>
		/// <param name="intValorAviso">float that contents the intValorAviso value for the TipoMantenimiento object</param>
		/// <param name="intValorAviso2">float that contents the intValorAviso2 value for the TipoMantenimiento object</param>
		/// <returns>One TipoMantenimiento object</returns>
		public TipoMantenimiento Create(int lngIdTipoMantenimiento, string strTipoMantenimiento, bool? logActivar, float? intValorMantenimiento, float? intValorAviso, float? intValorAviso2, Sinapsys.Datos.SQL datosTransaccion=null)
		{
			try 
			{
				TipoMantenimiento tipomantenimiento = new TipoMantenimiento();

				tipomantenimiento.lngIdTipoMantenimiento = lngIdTipoMantenimiento;
				tipomantenimiento.lngIdTipoMantenimiento = lngIdTipoMantenimiento;
				tipomantenimiento.strTipoMantenimiento = strTipoMantenimiento;
				tipomantenimiento.logActivar = logActivar;
				tipomantenimiento.intValorMantenimiento = intValorMantenimiento;
				tipomantenimiento.intValorAviso = intValorAviso;
				tipomantenimiento.intValorAviso2 = intValorAviso2;
				lngIdTipoMantenimiento = TipoMantenimientoDataProvider.Instance.Create(lngIdTipoMantenimiento, strTipoMantenimiento, logActivar, intValorMantenimiento, intValorAviso, intValorAviso2,"TipoMantenimiento",datosTransaccion);
				if (lngIdTipoMantenimiento == 0)
					return null;

				tipomantenimiento.lngIdTipoMantenimiento = lngIdTipoMantenimiento;

				return tipomantenimiento;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Updates an TipoMantenimiento object by passing all object's fields
		/// </summary>
		/// <param name="strTipoMantenimiento">string that contents the strTipoMantenimiento value for the TipoMantenimiento object</param>
		/// <param name="logActivar">bool that contents the logActivar value for the TipoMantenimiento object</param>
		/// <param name="intValorMantenimiento">float that contents the intValorMantenimiento value for the TipoMantenimiento object</param>
		/// <param name="intValorAviso">float that contents the intValorAviso value for the TipoMantenimiento object</param>
		/// <param name="intValorAviso2">float that contents the intValorAviso2 value for the TipoMantenimiento object</param>
		/// <param name="lngIdTipoMantenimiento">int that contents the lngIdTipoMantenimiento value for the TipoMantenimiento object</param>
		public void Update(string strTipoMantenimiento, bool? logActivar, float? intValorMantenimiento, float? intValorAviso, float? intValorAviso2, int lngIdTipoMantenimiento, Sinapsys.Datos.SQL datosTransaccion=null)
		{
			try 
			{
				TipoMantenimiento new_values = new TipoMantenimiento();
				new_values.strTipoMantenimiento = strTipoMantenimiento;
				new_values.logActivar = logActivar;
				new_values.intValorMantenimiento = intValorMantenimiento;
				new_values.intValorAviso = intValorAviso;
				new_values.intValorAviso2 = intValorAviso2;
				TipoMantenimientoDataProvider.Instance.Update(strTipoMantenimiento, logActivar, intValorMantenimiento, intValorAviso, intValorAviso2, lngIdTipoMantenimiento,"TipoMantenimiento",datosTransaccion);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Updates an TipoMantenimiento object by passing one object's instance as reference
		/// </summary>
		/// <param name="tipomantenimiento">An instance of TipoMantenimiento for reference</param>
		public void Update(TipoMantenimiento tipomantenimiento,Sinapsys.Datos.SQL datosTransaccion=null)
		{
			Update(tipomantenimiento.strTipoMantenimiento, tipomantenimiento.logActivar, tipomantenimiento.intValorMantenimiento, tipomantenimiento.intValorAviso, tipomantenimiento.intValorAviso2, tipomantenimiento.lngIdTipoMantenimiento);
		}

		/// <summary>
		/// Delete  the TipoMantenimiento object by passing a object
		/// </summary>
		public void  Delete(TipoMantenimiento tipomantenimiento, Sinapsys.Datos.SQL datosTransaccion=null)
		{
			Delete(tipomantenimiento.lngIdTipoMantenimiento,datosTransaccion);
		}

		/// <summary>
		/// Deletes the TipoMantenimiento object by passing one object's instance as reference
		/// </summary>
		/// <param name="tipomantenimiento">An instance of TipoMantenimiento for reference</param>
		public void Delete(int lngIdTipoMantenimiento, Sinapsys.Datos.SQL datosTransaccion=null)
		{
			try 
			{
				//TipoMantenimiento old_values = TipoMantenimientoController.Instance.Get(lngIdTipoMantenimiento);
				//if(!Validate.security.CanDeleteSecurityField(TipoMantenimientoController.Instance, (ILatinodeObject)old_values))
				//    throw new Exception("Access denied by security field, you can't delete object");

				TipoMantenimientoDataProvider.Instance.Delete(lngIdTipoMantenimiento,"TipoMantenimiento");
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Deletes the TipoMantenimiento object by passing CVS parameter as reference
		/// </summary>
		/// <param name="tipomantenimiento">An instance of TipoMantenimiento for reference</param>
		public void Delete(string CVSParameter)
		{
			string[] StrCommand=CVSParameter.Split(',');
			try 
			{
				int lngIdTipoMantenimiento=int.Parse(StrCommand[0]);
				TipoMantenimientoDataProvider.Instance.Delete(lngIdTipoMantenimiento,"TipoMantenimiento");
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Gets the TipoMantenimiento object by passing the object's key fields
		/// </summary>
		/// <param name="lngIdTipoMantenimiento">int that contents the lngIdTipoMantenimiento value for the TipoMantenimiento object</param>
		/// <returns>One TipoMantenimiento object</returns>
		public TipoMantenimiento Get(int lngIdTipoMantenimiento, bool generateUndo=false)
		{
			try 
			{
				TipoMantenimiento tipomantenimiento = null;
				DataTable dt = TipoMantenimientoDataProvider.Instance.Get(lngIdTipoMantenimiento);
				if ((dt.Rows.Count > 0))
				{
					tipomantenimiento = new TipoMantenimiento();
					DataRow dr = dt.Rows[0];
					ReadData(tipomantenimiento, dr, generateUndo);
				}


				return tipomantenimiento;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Gets all objects of TipoMantenimiento
		/// </summary>
		/// <returns>One TipoMantenimientoList object</returns>
		public TipoMantenimientoList GetAll(bool generateUndo=false)
		{
			try 
			{
				TipoMantenimientoList tipomantenimientolist = new TipoMantenimientoList();
				DataTable dt = TipoMantenimientoDataProvider.Instance.GetAll();
				foreach (DataRow dr in dt.Rows)
				{
					TipoMantenimiento tipomantenimiento = new TipoMantenimiento();
					ReadData(tipomantenimiento, dr, generateUndo);
					tipomantenimientolist.Add(tipomantenimiento);
				}
				return tipomantenimientolist;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Gets all objects of TipoMantenimiento applying filter and sort criteria
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
		/// <returns>One TipoMantenimientoList object</returns>
		public TipoMantenimientoList GetFilter(int pagenum, int pagesize, string filter, string sort, string extablesfilter, string extablesfieldsfilter, string extablesrelationsfilter, string extablessort, string extablesfieldssort, string extablesrelationssort, bool generateUndo=false)
		{
			try 
			{
				TipoMantenimientoList tipomantenimientolist = new TipoMantenimientoList();

				DataTable dt = TipoMantenimientoDataProvider.Instance.GetFilter(pagenum, pagesize, filter, sort, extablesfilter, extablesfieldsfilter, extablesrelationsfilter, extablessort, extablesfieldssort, extablesrelationssort);

				foreach (DataRow dr in dt.Rows)
				{
					TipoMantenimiento tipomantenimiento = new TipoMantenimiento();
					ReadData(tipomantenimiento, dr, generateUndo);
					tipomantenimientolist.Add(tipomantenimiento);
				}
				return tipomantenimientolist;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public TipoMantenimientoList GetFilter( string filter, string sort, bool generateUndo=false)
		{
			return GetFilter(0,0, filter, sort, "","","","","","",generateUndo);
		}

		public TipoMantenimientoList GetFilter(string filter, string sort, string extablesfilter, string extablesfieldsfilter, string extablesrelationsfilter, string extablessort, string extablesfieldssort, string extablesrelationssort, bool generateUndo=false)
		{
			return GetFilter(0,0, filter, sort, extablesfilter, extablesfieldsfilter, extablesrelationsfilter, extablessort, extablesfieldssort, extablesrelationssort,generateUndo);
		}


		/// <summary>
		/// Returns the type for one property
		/// </summary>
		/// <param name="propertyname">Property's name for return its value</param>
		/// <returns>A value for the <paramref name="propertyname"/></returns>
		public Type GetMethodType( string propertyname,TipoMantenimiento tipomantenimiento)
		{
			// Perform the search for the property's value
			switch (propertyname)
			{
				case "strTipoMantenimiento":
					return tipomantenimiento.strTipoMantenimiento.GetType();

				case "logActivar":
					return tipomantenimiento.logActivar.GetType();

				case "intValorMantenimiento":
					return tipomantenimiento.intValorMantenimiento.GetType();

				case "intValorAviso":
					return tipomantenimiento.intValorAviso.GetType();

				case "intValorAviso2":
					return tipomantenimiento.intValorAviso2.GetType();

				case "lngIdTipoMantenimiento":
					return tipomantenimiento.lngIdTipoMantenimiento.GetType();

			}

			return null;
		}
		/// <summary>
		/// update the changes in TipoMantenimiento object by passing the object
		/// </summary>
		public bool UpdateChanges(TipoMantenimiento tipomantenimiento, out string error,Sinapsys.Datos.SQL datosTransaccion=null)
		{
			if (tipomantenimiento.OldTipoMantenimiento == null)
			{
				    error = "No tiene objeto con el cual comparar";
				    return false;
			}
			string[] Fields = tipomantenimiento.FieldChanged();
			error = "";
			return LiqViajes_Bll_Data.DataProvider.UpdateFieldsbyObject(Fields, tipomantenimiento, out error,datosTransaccion);
		}
	}

	#endregion

}
