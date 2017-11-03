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
	#region CuentasVariosController

	/// <summary>
	/// Class for convert data from database into object's data and vice versa
	/// </summary>
	public partial class CuentasVariosController//: ILatinodeController
	{
		/// <summary>
		/// Generic Constructor
		/// </summary>
		public CuentasVariosController()
		{
		}

		/// <summary>
		/// Instance accessor for this singleton
		/// </summary>
		private static CuentasVariosController MySingleObj;
		public static CuentasVariosController Instance
		{
			get
			{
				if (MySingleObj == null)
				{
					MySingleObj = new CuentasVariosController();
				}
				return MySingleObj;
			}
		}

		// Reads object's data from a DataRow
		private void ReadData(CuentasVarios cuentasvarios, DataRow dr,bool generateUndo=false)
		{
			try 
			{
				cuentasvarios.strDescripcion = dr.IsNull("strDescripcion") ? null :(string) dr["strDescripcion"];
				cuentasvarios.nitTercero = dr.IsNull("nitTercero") ? null :(string) dr["nitTercero"];
				cuentasvarios.strCuenta = (string) dr["strCuenta"];
			}
			catch (Exception ex)
			{
				Utilidades.LogErrores(ex.Message + (ex.InnerException != null ? ex.InnerException.Message : ""), DataProvider.AplicacionNombre);
				throw ex;
			}
			if (generateUndo) cuentasvarios.GenerateUndo();
		}

		/// <summary>
		/// Create a new CuentasVarios object by passing a object
		/// </summary>
		public CuentasVarios Create(CuentasVarios cuentasvarios, Sinapsys.Datos.SQL datosTransaccion=null)
		{
			return Create(cuentasvarios.strCuenta,cuentasvarios.strDescripcion,cuentasvarios.nitTercero,datosTransaccion);
		}

		/// <summary>
		/// Creates a new CuentasVarios object by passing all object's fields
		/// </summary>
		/// <param name="strDescripcion">string that contents the strDescripcion value for the CuentasVarios object</param>
		/// <param name="nitTercero">string that contents the nitTercero value for the CuentasVarios object</param>
		/// <returns>One CuentasVarios object</returns>
		public CuentasVarios Create(string strCuenta, string strDescripcion, string nitTercero, Sinapsys.Datos.SQL datosTransaccion=null)
		{
			try 
			{
				CuentasVarios cuentasvarios = new CuentasVarios();

				cuentasvarios.strCuenta = strCuenta;
				cuentasvarios.strDescripcion = strDescripcion;
				cuentasvarios.nitTercero = nitTercero;
				CuentasVariosDataProvider.Instance.Create(strCuenta, strDescripcion, nitTercero,"CuentasVarios");

				return cuentasvarios;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Updates an CuentasVarios object by passing all object's fields
		/// </summary>
		/// <param name="strDescripcion">string that contents the strDescripcion value for the CuentasVarios object</param>
		/// <param name="nitTercero">string that contents the nitTercero value for the CuentasVarios object</param>
		/// <param name="strCuenta">string that contents the strCuenta value for the CuentasVarios object</param>
		public void Update(string strDescripcion, string nitTercero, string strCuenta, Sinapsys.Datos.SQL datosTransaccion=null)
		{
			try 
			{
				CuentasVarios new_values = new CuentasVarios();
				new_values.strDescripcion = strDescripcion;
				new_values.nitTercero = nitTercero;
				CuentasVariosDataProvider.Instance.Update(strDescripcion, nitTercero, strCuenta,"CuentasVarios",datosTransaccion);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Updates an CuentasVarios object by passing one object's instance as reference
		/// </summary>
		/// <param name="cuentasvarios">An instance of CuentasVarios for reference</param>
		public void Update(CuentasVarios cuentasvarios,Sinapsys.Datos.SQL datosTransaccion=null)
		{
			Update(cuentasvarios.strDescripcion, cuentasvarios.nitTercero, cuentasvarios.strCuenta);
		}

		/// <summary>
		/// Delete  the CuentasVarios object by passing a object
		/// </summary>
		public void  Delete(CuentasVarios cuentasvarios, Sinapsys.Datos.SQL datosTransaccion=null)
		{
			Delete(cuentasvarios.strCuenta,datosTransaccion);
		}

		/// <summary>
		/// Deletes the CuentasVarios object by passing one object's instance as reference
		/// </summary>
		/// <param name="cuentasvarios">An instance of CuentasVarios for reference</param>
		public void Delete(string strCuenta, Sinapsys.Datos.SQL datosTransaccion=null)
		{
			try 
			{
				CuentasVariosDataProvider.Instance.Delete(strCuenta,"CuentasVarios");
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Gets the CuentasVarios object by passing the object's key fields
		/// </summary>
		/// <param name="strCuenta">string that contents the strCuenta value for the CuentasVarios object</param>
		/// <returns>One CuentasVarios object</returns>
		public CuentasVarios Get(string strCuenta, bool generateUndo=false)
		{
			try 
			{
				CuentasVarios cuentasvarios = null;
				cuentasvarios= MasterTables.CuentasVarios.Where(r => r.strCuenta== strCuenta).FirstOrDefault();
				if (cuentasvarios== null)
				{
					MasterTables.Reset("CuentasVarios");
					cuentasvarios= MasterTables.CuentasVarios.Where(r => r.strCuenta== strCuenta).FirstOrDefault();
				}
				if (generateUndo) cuentasvarios.GenerateUndo();

				return cuentasvarios;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Gets all objects of CuentasVarios
		/// </summary>
		/// <returns>One CuentasVariosList object</returns>
		public CuentasVariosList GetAll(bool generateUndo=false)
		{
			try 
			{
				CuentasVariosList cuentasvarioslist = new CuentasVariosList();
				DataTable dt = CuentasVariosDataProvider.Instance.GetAll();
				foreach (DataRow dr in dt.Rows)
				{
					CuentasVarios cuentasvarios = new CuentasVarios();
					ReadData(cuentasvarios, dr, generateUndo);
					cuentasvarioslist.Add(cuentasvarios);
				}
				return cuentasvarioslist;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Gets all objects of CuentasVarios applying filter and sort criteria
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
		/// <returns>One CuentasVariosList object</returns>
		public CuentasVariosList GetFilter(int pagenum, int pagesize, string filter, string sort, string extablesfilter, string extablesfieldsfilter, string extablesrelationsfilter, string extablessort, string extablesfieldssort, string extablesrelationssort, bool generateUndo=false)
		{
			try 
			{
				CuentasVariosList cuentasvarioslist = new CuentasVariosList();

				DataTable dt = CuentasVariosDataProvider.Instance.GetFilter(pagenum, pagesize, filter, sort, extablesfilter, extablesfieldsfilter, extablesrelationsfilter, extablessort, extablesfieldssort, extablesrelationssort);

				foreach (DataRow dr in dt.Rows)
				{
					CuentasVarios cuentasvarios = new CuentasVarios();
					ReadData(cuentasvarios, dr, generateUndo);
					cuentasvarioslist.Add(cuentasvarios);
				}
				return cuentasvarioslist;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public CuentasVariosList GetFilter( string filter, string sort, bool generateUndo=false)
		{
			return GetFilter(0,0, filter, sort, "","","","","","",generateUndo);
		}

		public CuentasVariosList GetFilter(string filter, string sort, string extablesfilter, string extablesfieldsfilter, string extablesrelationsfilter, string extablessort, string extablesfieldssort, string extablesrelationssort, bool generateUndo=false)
		{
			return GetFilter(0,0, filter, sort, extablesfilter, extablesfieldsfilter, extablesrelationsfilter, extablessort, extablesfieldssort, extablesrelationssort,generateUndo);
		}


		/// <summary>
		/// Returns the type for one property
		/// </summary>
		/// <param name="propertyname">Property's name for return its value</param>
		/// <returns>A value for the <paramref name="propertyname"/></returns>
		public Type GetMethodType( string propertyname,CuentasVarios cuentasvarios)
		{
			// Perform the search for the property's value
			switch (propertyname)
			{
				case "strDescripcion":
					return cuentasvarios.strDescripcion.GetType();

				case "nitTercero":
					return cuentasvarios.nitTercero.GetType();

				case "strCuenta":
					return cuentasvarios.strCuenta.GetType();

			}

			return null;
		}
		/// <summary>
		/// update the changes in CuentasVarios object by passing the object
		/// </summary>
		public bool UpdateChanges(CuentasVarios cuentasvarios, out string error,Sinapsys.Datos.SQL datosTransaccion=null)
		{
			if (cuentasvarios.OldCuentasVarios == null)
			{
				    error = "No tiene objeto con el cual comparar";
				    return false;
			}
			string[] Fields = cuentasvarios.FieldChanged();
			error = "";
			return LiqViajes_Bll_Data.DataProvider.UpdateFieldsbyObject(Fields, cuentasvarios, out error,datosTransaccion);
		}
	}

	#endregion

}
