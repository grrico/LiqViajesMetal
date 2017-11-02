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
	#region OpcionesDetNivelIIIController

	/// <summary>
	/// Class for convert data from database into object's data and vice versa
	/// </summary>
	public partial class OpcionesDetNivelIIIController//: ILatinodeController
	{
		/// <summary>
		/// Generic Constructor
		/// </summary>
		public OpcionesDetNivelIIIController()
		{
		}

		/// <summary>
		/// Instance accessor for this singleton
		/// </summary>
		private static OpcionesDetNivelIIIController MySingleObj;
		public static OpcionesDetNivelIIIController Instance
		{
			get
			{
				if (MySingleObj == null)
				{
					MySingleObj = new OpcionesDetNivelIIIController();
				}
				return MySingleObj;
			}
		}

		// Reads object's data from a DataRow
		private void ReadData(OpcionesDetNivelIII opcionesdetniveliii, DataRow dr,bool generateUndo=false)
		{
			try 
			{
				opcionesdetniveliii.lngIdOpcion = (int) dr["lngIdOpcion"];
				opcionesdetniveliii.strDescOpcion = dr.IsNull("strDescOpcion") ? null :(string) dr["strDescOpcion"];
				opcionesdetniveliii.strPrograma = dr.IsNull("strPrograma") ? null :(string) dr["strPrograma"];
				opcionesdetniveliii.strParametros = dr.IsNull("strParametros") ? null :(string) dr["strParametros"];
				opcionesdetniveliii.lngIdOpcionPadre = dr.IsNull("lngIdOpcionPadre") ? null :(int?) dr["lngIdOpcionPadre"];
				opcionesdetniveliii.strTipoOpcion = dr.IsNull("strTipoOpcion") ? null :(string) dr["strTipoOpcion"];
				opcionesdetniveliii.intOrden = dr.IsNull("intOrden") ? null :(int?) dr["intOrden"];
				opcionesdetniveliii.WebBrowser = dr.IsNull("WebBrowser") ? null :(bool?) dr["WebBrowser"];
			}
			catch (Exception ex)
			{
				Utilidades.LogErrores(ex.Message + (ex.InnerException != null ? ex.InnerException.Message : ""), DataProvider.AplicacionNombre);
				throw ex;
			}
			if (generateUndo) opcionesdetniveliii.GenerateUndo();
		}

		/// <summary>
		/// Create a new OpcionesDetNivelIII object by passing a object
		/// </summary>
		public OpcionesDetNivelIII Create(OpcionesDetNivelIII opcionesdetniveliii, Sinapsys.Datos.SQL datosTransaccion=null)
		{
			return Create(opcionesdetniveliii.lngIdOpcion,opcionesdetniveliii.strDescOpcion,opcionesdetniveliii.strPrograma,opcionesdetniveliii.strParametros,opcionesdetniveliii.lngIdOpcionPadre,opcionesdetniveliii.strTipoOpcion,opcionesdetniveliii.intOrden,opcionesdetniveliii.WebBrowser,datosTransaccion);
		}

		/// <summary>
		/// Creates a new OpcionesDetNivelIII object by passing all object's fields
		/// </summary>
		/// <param name="strDescOpcion">string that contents the strDescOpcion value for the OpcionesDetNivelIII object</param>
		/// <param name="strPrograma">string that contents the strPrograma value for the OpcionesDetNivelIII object</param>
		/// <param name="strParametros">string that contents the strParametros value for the OpcionesDetNivelIII object</param>
		/// <param name="lngIdOpcionPadre">int that contents the lngIdOpcionPadre value for the OpcionesDetNivelIII object</param>
		/// <param name="strTipoOpcion">string that contents the strTipoOpcion value for the OpcionesDetNivelIII object</param>
		/// <param name="intOrden">int that contents the intOrden value for the OpcionesDetNivelIII object</param>
		/// <param name="WebBrowser">bool that contents the WebBrowser value for the OpcionesDetNivelIII object</param>
		/// <returns>One OpcionesDetNivelIII object</returns>
		public OpcionesDetNivelIII Create(int lngIdOpcion, string strDescOpcion, string strPrograma, string strParametros, int? lngIdOpcionPadre, string strTipoOpcion, int? intOrden, bool? WebBrowser, Sinapsys.Datos.SQL datosTransaccion=null)
		{
			try 
			{
				OpcionesDetNivelIII opcionesdetniveliii = new OpcionesDetNivelIII();

				opcionesdetniveliii.lngIdOpcion = lngIdOpcion;
				opcionesdetniveliii.strDescOpcion = strDescOpcion;
				opcionesdetniveliii.strPrograma = strPrograma;
				opcionesdetniveliii.strParametros = strParametros;
				opcionesdetniveliii.lngIdOpcionPadre = lngIdOpcionPadre;
				opcionesdetniveliii.strTipoOpcion = strTipoOpcion;
				opcionesdetniveliii.intOrden = intOrden;
				opcionesdetniveliii.WebBrowser = WebBrowser;
				OpcionesDetNivelIIIDataProvider.Instance.Create(lngIdOpcion, strDescOpcion, strPrograma, strParametros, lngIdOpcionPadre, strTipoOpcion, intOrden, WebBrowser,"OpcionesDetNivelIII");

				return opcionesdetniveliii;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Updates an OpcionesDetNivelIII object by passing all object's fields
		/// </summary>
		/// <param name="lngIdOpcion">int that contents the lngIdOpcion value for the OpcionesDetNivelIII object</param>
		/// <param name="strDescOpcion">string that contents the strDescOpcion value for the OpcionesDetNivelIII object</param>
		/// <param name="strPrograma">string that contents the strPrograma value for the OpcionesDetNivelIII object</param>
		/// <param name="strParametros">string that contents the strParametros value for the OpcionesDetNivelIII object</param>
		/// <param name="lngIdOpcionPadre">int that contents the lngIdOpcionPadre value for the OpcionesDetNivelIII object</param>
		/// <param name="strTipoOpcion">string that contents the strTipoOpcion value for the OpcionesDetNivelIII object</param>
		/// <param name="intOrden">int that contents the intOrden value for the OpcionesDetNivelIII object</param>
		/// <param name="WebBrowser">bool that contents the WebBrowser value for the OpcionesDetNivelIII object</param>
		public void Update(int lngIdOpcion, string strDescOpcion, string strPrograma, string strParametros, int? lngIdOpcionPadre, string strTipoOpcion, int? intOrden, bool? WebBrowser, Sinapsys.Datos.SQL datosTransaccion=null)
		{
			try 
			{
				OpcionesDetNivelIII new_values = new OpcionesDetNivelIII();
				new_values.strDescOpcion = strDescOpcion;
				new_values.strPrograma = strPrograma;
				new_values.strParametros = strParametros;
				new_values.lngIdOpcionPadre = lngIdOpcionPadre;
				new_values.strTipoOpcion = strTipoOpcion;
				new_values.intOrden = intOrden;
				new_values.WebBrowser = WebBrowser;
				OpcionesDetNivelIIIDataProvider.Instance.Update(lngIdOpcion, strDescOpcion, strPrograma, strParametros, lngIdOpcionPadre, strTipoOpcion, intOrden, WebBrowser,"OpcionesDetNivelIII",datosTransaccion);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Updates an OpcionesDetNivelIII object by passing one object's instance as reference
		/// </summary>
		/// <param name="opcionesdetniveliii">An instance of OpcionesDetNivelIII for reference</param>
		public void Update(OpcionesDetNivelIII opcionesdetniveliii,Sinapsys.Datos.SQL datosTransaccion=null)
		{
			Update(opcionesdetniveliii.lngIdOpcion, opcionesdetniveliii.strDescOpcion, opcionesdetniveliii.strPrograma, opcionesdetniveliii.strParametros, opcionesdetniveliii.lngIdOpcionPadre, opcionesdetniveliii.strTipoOpcion, opcionesdetniveliii.intOrden, opcionesdetniveliii.WebBrowser);
		}

		/// <summary>
		/// Delete  the OpcionesDetNivelIII object by passing a object
		/// </summary>
		public void  Delete(OpcionesDetNivelIII opcionesdetniveliii, Sinapsys.Datos.SQL datosTransaccion=null)
		{
			Delete(opcionesdetniveliii.lngIdOpcion,datosTransaccion);
		}

		/// <summary>
		/// Deletes the OpcionesDetNivelIII object by passing one object's instance as reference
		/// </summary>
		/// <param name="opcionesdetniveliii">An instance of OpcionesDetNivelIII for reference</param>
		public void Delete(int lngIdOpcion, Sinapsys.Datos.SQL datosTransaccion=null)
		{
			try 
			{
				OpcionesDetNivelIIIDataProvider.Instance.Delete(lngIdOpcion,"OpcionesDetNivelIII");
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Deletes the OpcionesDetNivelIII object by passing CVS parameter as reference
		/// </summary>
		/// <param name="opcionesdetniveliii">An instance of OpcionesDetNivelIII for reference</param>
		public void Delete(string CVSParameter)
		{
			string[] StrCommand=CVSParameter.Split(',');
			try 
			{
				int lngIdOpcion=int.Parse(StrCommand[0]);
				OpcionesDetNivelIIIDataProvider.Instance.Delete(lngIdOpcion,"OpcionesDetNivelIII");
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Gets the OpcionesDetNivelIII object by passing the object's key fields
		/// </summary>
		/// <param name="lngIdOpcion">int that contents the lngIdOpcion value for the OpcionesDetNivelIII object</param>
		/// <returns>One OpcionesDetNivelIII object</returns>
		public OpcionesDetNivelIII Get(int lngIdOpcion, bool generateUndo=false)
		{
			try 
			{
				OpcionesDetNivelIII opcionesdetniveliii = null;
				DataTable dt = OpcionesDetNivelIIIDataProvider.Instance.Get(lngIdOpcion);
				if ((dt.Rows.Count > 0))
				{
					opcionesdetniveliii = new OpcionesDetNivelIII();
					DataRow dr = dt.Rows[0];
					ReadData(opcionesdetniveliii, dr, generateUndo);
				}


				return opcionesdetniveliii;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Gets all objects of OpcionesDetNivelIII
		/// </summary>
		/// <returns>One OpcionesDetNivelIIIList object</returns>
		public OpcionesDetNivelIIIList GetAll(bool generateUndo=false)
		{
			try 
			{
				OpcionesDetNivelIIIList opcionesdetniveliiilist = new OpcionesDetNivelIIIList();
				DataTable dt = OpcionesDetNivelIIIDataProvider.Instance.GetAll();
				foreach (DataRow dr in dt.Rows)
				{
					OpcionesDetNivelIII opcionesdetniveliii = new OpcionesDetNivelIII();
					ReadData(opcionesdetniveliii, dr, generateUndo);
					opcionesdetniveliiilist.Add(opcionesdetniveliii);
				}
				return opcionesdetniveliiilist;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Gets all objects of OpcionesDetNivelIII applying filter and sort criteria
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
		/// <returns>One OpcionesDetNivelIIIList object</returns>
		public OpcionesDetNivelIIIList GetFilter(int pagenum, int pagesize, string filter, string sort, string extablesfilter, string extablesfieldsfilter, string extablesrelationsfilter, string extablessort, string extablesfieldssort, string extablesrelationssort, bool generateUndo=false)
		{
			try 
			{
				OpcionesDetNivelIIIList opcionesdetniveliiilist = new OpcionesDetNivelIIIList();

				DataTable dt = OpcionesDetNivelIIIDataProvider.Instance.GetFilter(pagenum, pagesize, filter, sort, extablesfilter, extablesfieldsfilter, extablesrelationsfilter, extablessort, extablesfieldssort, extablesrelationssort);

				foreach (DataRow dr in dt.Rows)
				{
					OpcionesDetNivelIII opcionesdetniveliii = new OpcionesDetNivelIII();
					ReadData(opcionesdetniveliii, dr, generateUndo);
					opcionesdetniveliiilist.Add(opcionesdetniveliii);
				}
				return opcionesdetniveliiilist;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public OpcionesDetNivelIIIList GetFilter( string filter, string sort, bool generateUndo=false)
		{
			return GetFilter(0,0, filter, sort, "","","","","","",generateUndo);
		}

		public OpcionesDetNivelIIIList GetFilter(string filter, string sort, string extablesfilter, string extablesfieldsfilter, string extablesrelationsfilter, string extablessort, string extablesfieldssort, string extablesrelationssort, bool generateUndo=false)
		{
			return GetFilter(0,0, filter, sort, extablesfilter, extablesfieldsfilter, extablesrelationsfilter, extablessort, extablesfieldssort, extablesrelationssort,generateUndo);
		}


		/// <summary>
		/// Returns the type for one property
		/// </summary>
		/// <param name="propertyname">Property's name for return its value</param>
		/// <returns>A value for the <paramref name="propertyname"/></returns>
		public Type GetMethodType( string propertyname,OpcionesDetNivelIII opcionesdetniveliii)
		{
			// Perform the search for the property's value
			switch (propertyname)
			{
				case "lngIdOpcion":
					return opcionesdetniveliii.lngIdOpcion.GetType();

				case "strDescOpcion":
					return opcionesdetniveliii.strDescOpcion.GetType();

				case "strPrograma":
					return opcionesdetniveliii.strPrograma.GetType();

				case "strParametros":
					return opcionesdetniveliii.strParametros.GetType();

				case "lngIdOpcionPadre":
					return opcionesdetniveliii.lngIdOpcionPadre.GetType();

				case "strTipoOpcion":
					return opcionesdetniveliii.strTipoOpcion.GetType();

				case "intOrden":
					return opcionesdetniveliii.intOrden.GetType();

				case "WebBrowser":
					return opcionesdetniveliii.WebBrowser.GetType();

			}

			return null;
		}
		/// <summary>
		/// update the changes in OpcionesDetNivelIII object by passing the object
		/// </summary>
		public bool UpdateChanges(OpcionesDetNivelIII opcionesdetniveliii, out string error,Sinapsys.Datos.SQL datosTransaccion=null)
		{
			if (opcionesdetniveliii.OldOpcionesDetNivelIII == null)
			{
				    error = "No tiene objeto con el cual comparar";
				    return false;
			}
			string[] Fields = opcionesdetniveliii.FieldChanged();
			error = "";
			return LiqViajes_Bll_Data.DataProvider.UpdateFieldsbyObject(Fields, opcionesdetniveliii, out error,datosTransaccion);
		}
	}

	#endregion

}
