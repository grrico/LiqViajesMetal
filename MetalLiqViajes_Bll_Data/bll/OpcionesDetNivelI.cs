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
	#region OpcionesDetNivelIController

	/// <summary>
	/// Class for convert data from database into object's data and vice versa
	/// </summary>
	public partial class OpcionesDetNivelIController//: ILatinodeController
	{
		/// <summary>
		/// Generic Constructor
		/// </summary>
		public OpcionesDetNivelIController()
		{
		}

		/// <summary>
		/// Instance accessor for this singleton
		/// </summary>
		private static OpcionesDetNivelIController MySingleObj;
		public static OpcionesDetNivelIController Instance
		{
			get
			{
				if (MySingleObj == null)
				{
					MySingleObj = new OpcionesDetNivelIController();
				}
				return MySingleObj;
			}
		}

		// Reads object's data from a DataRow
		private void ReadData(OpcionesDetNivelI opcionesdetniveli, DataRow dr,bool generateUndo=false)
		{
			try 
			{
				opcionesdetniveli.strDescOpcion = dr.IsNull("strDescOpcion") ? null :(string) dr["strDescOpcion"];
				opcionesdetniveli.strPrograma = dr.IsNull("strPrograma") ? null :(string) dr["strPrograma"];
				opcionesdetniveli.strParametros = dr.IsNull("strParametros") ? null :(string) dr["strParametros"];
				opcionesdetniveli.lngIdOpcionPadre = dr.IsNull("lngIdOpcionPadre") ? null :(int?) dr["lngIdOpcionPadre"];
				opcionesdetniveli.strTipoOpcion = dr.IsNull("strTipoOpcion") ? null :(string) dr["strTipoOpcion"];
				opcionesdetniveli.intOrden = dr.IsNull("intOrden") ? null :(int?) dr["intOrden"];
				opcionesdetniveli.WebBrowser = dr.IsNull("WebBrowser") ? null :(bool?) dr["WebBrowser"];
				opcionesdetniveli.logExpandeNode = dr.IsNull("logExpandeNode") ? null :(bool?) dr["logExpandeNode"];
				opcionesdetniveli.strString = dr.IsNull("strString") ? null :(string) dr["strString"];
				opcionesdetniveli.strColHidden = dr.IsNull("strColHidden") ? null :(char?) ((string) dr["strColHidden"])[0];
				opcionesdetniveli.lngIdOpcion = (int) dr["lngIdOpcion"];
			}
			catch (Exception ex)
			{
				Utilidades.LogErrores(ex.Message + (ex.InnerException != null ? ex.InnerException.Message : ""), DataProvider.AplicacionNombre);
				throw ex;
			}
			if (generateUndo) opcionesdetniveli.GenerateUndo();
		}

		/// <summary>
		/// Create a new OpcionesDetNivelI object by passing a object
		/// </summary>
		public OpcionesDetNivelI Create(OpcionesDetNivelI opcionesdetniveli, Sinapsys.Datos.SQL datosTransaccion=null)
		{
			return Create(opcionesdetniveli.lngIdOpcion,opcionesdetniveli.strDescOpcion,opcionesdetniveli.strPrograma,opcionesdetniveli.strParametros,opcionesdetniveli.lngIdOpcionPadre,opcionesdetniveli.strTipoOpcion,opcionesdetniveli.intOrden,opcionesdetniveli.WebBrowser,opcionesdetniveli.logExpandeNode,opcionesdetniveli.strString,opcionesdetniveli.strColHidden,datosTransaccion);
		}

		/// <summary>
		/// Creates a new OpcionesDetNivelI object by passing all object's fields
		/// </summary>
		/// <param name="strDescOpcion">string that contents the strDescOpcion value for the OpcionesDetNivelI object</param>
		/// <param name="strPrograma">string that contents the strPrograma value for the OpcionesDetNivelI object</param>
		/// <param name="strParametros">string that contents the strParametros value for the OpcionesDetNivelI object</param>
		/// <param name="lngIdOpcionPadre">int that contents the lngIdOpcionPadre value for the OpcionesDetNivelI object</param>
		/// <param name="strTipoOpcion">string that contents the strTipoOpcion value for the OpcionesDetNivelI object</param>
		/// <param name="intOrden">int that contents the intOrden value for the OpcionesDetNivelI object</param>
		/// <param name="WebBrowser">bool that contents the WebBrowser value for the OpcionesDetNivelI object</param>
		/// <param name="logExpandeNode">bool that contents the logExpandeNode value for the OpcionesDetNivelI object</param>
		/// <param name="strString">string that contents the strString value for the OpcionesDetNivelI object</param>
		/// <param name="strColHidden">char that contents the strColHidden value for the OpcionesDetNivelI object</param>
		/// <returns>One OpcionesDetNivelI object</returns>
		public OpcionesDetNivelI Create(int lngIdOpcion, string strDescOpcion, string strPrograma, string strParametros, int? lngIdOpcionPadre, string strTipoOpcion, int? intOrden, bool? WebBrowser, bool? logExpandeNode, string strString, char? strColHidden, Sinapsys.Datos.SQL datosTransaccion=null)
		{
			try 
			{
				OpcionesDetNivelI opcionesdetniveli = new OpcionesDetNivelI();

				opcionesdetniveli.lngIdOpcion = lngIdOpcion;
				opcionesdetniveli.strDescOpcion = strDescOpcion;
				opcionesdetniveli.strPrograma = strPrograma;
				opcionesdetniveli.strParametros = strParametros;
				opcionesdetniveli.lngIdOpcionPadre = lngIdOpcionPadre;
				opcionesdetniveli.strTipoOpcion = strTipoOpcion;
				opcionesdetniveli.intOrden = intOrden;
				opcionesdetniveli.WebBrowser = WebBrowser;
				opcionesdetniveli.logExpandeNode = logExpandeNode;
				opcionesdetniveli.strString = strString;
				opcionesdetniveli.strColHidden = strColHidden;
				OpcionesDetNivelIDataProvider.Instance.Create(lngIdOpcion, strDescOpcion, strPrograma, strParametros, lngIdOpcionPadre, strTipoOpcion, intOrden, WebBrowser, logExpandeNode, strString, strColHidden,"OpcionesDetNivelI");

				return opcionesdetniveli;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Updates an OpcionesDetNivelI object by passing all object's fields
		/// </summary>
		/// <param name="strDescOpcion">string that contents the strDescOpcion value for the OpcionesDetNivelI object</param>
		/// <param name="strPrograma">string that contents the strPrograma value for the OpcionesDetNivelI object</param>
		/// <param name="strParametros">string that contents the strParametros value for the OpcionesDetNivelI object</param>
		/// <param name="lngIdOpcionPadre">int that contents the lngIdOpcionPadre value for the OpcionesDetNivelI object</param>
		/// <param name="strTipoOpcion">string that contents the strTipoOpcion value for the OpcionesDetNivelI object</param>
		/// <param name="intOrden">int that contents the intOrden value for the OpcionesDetNivelI object</param>
		/// <param name="WebBrowser">bool that contents the WebBrowser value for the OpcionesDetNivelI object</param>
		/// <param name="logExpandeNode">bool that contents the logExpandeNode value for the OpcionesDetNivelI object</param>
		/// <param name="strString">string that contents the strString value for the OpcionesDetNivelI object</param>
		/// <param name="strColHidden">char that contents the strColHidden value for the OpcionesDetNivelI object</param>
		/// <param name="lngIdOpcion">int that contents the lngIdOpcion value for the OpcionesDetNivelI object</param>
		public void Update(string strDescOpcion, string strPrograma, string strParametros, int? lngIdOpcionPadre, string strTipoOpcion, int? intOrden, bool? WebBrowser, bool? logExpandeNode, string strString, char? strColHidden, int lngIdOpcion, Sinapsys.Datos.SQL datosTransaccion=null)
		{
			try 
			{
				OpcionesDetNivelI new_values = new OpcionesDetNivelI();
				new_values.strDescOpcion = strDescOpcion;
				new_values.strPrograma = strPrograma;
				new_values.strParametros = strParametros;
				new_values.lngIdOpcionPadre = lngIdOpcionPadre;
				new_values.strTipoOpcion = strTipoOpcion;
				new_values.intOrden = intOrden;
				new_values.WebBrowser = WebBrowser;
				new_values.logExpandeNode = logExpandeNode;
				new_values.strString = strString;
				new_values.strColHidden = strColHidden;
				OpcionesDetNivelIDataProvider.Instance.Update(strDescOpcion, strPrograma, strParametros, lngIdOpcionPadre, strTipoOpcion, intOrden, WebBrowser, logExpandeNode, strString, strColHidden, lngIdOpcion,"OpcionesDetNivelI",datosTransaccion);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Updates an OpcionesDetNivelI object by passing one object's instance as reference
		/// </summary>
		/// <param name="opcionesdetniveli">An instance of OpcionesDetNivelI for reference</param>
		public void Update(OpcionesDetNivelI opcionesdetniveli,Sinapsys.Datos.SQL datosTransaccion=null)
		{
			Update(opcionesdetniveli.strDescOpcion, opcionesdetniveli.strPrograma, opcionesdetniveli.strParametros, opcionesdetniveli.lngIdOpcionPadre, opcionesdetniveli.strTipoOpcion, opcionesdetniveli.intOrden, opcionesdetniveli.WebBrowser, opcionesdetniveli.logExpandeNode, opcionesdetniveli.strString, opcionesdetniveli.strColHidden, opcionesdetniveli.lngIdOpcion);
		}

		/// <summary>
		/// Delete  the OpcionesDetNivelI object by passing a object
		/// </summary>
		public void  Delete(OpcionesDetNivelI opcionesdetniveli, Sinapsys.Datos.SQL datosTransaccion=null)
		{
			Delete(opcionesdetniveli.lngIdOpcion,datosTransaccion);
		}

		/// <summary>
		/// Deletes the OpcionesDetNivelI object by passing one object's instance as reference
		/// </summary>
		/// <param name="opcionesdetniveli">An instance of OpcionesDetNivelI for reference</param>
		public void Delete(int lngIdOpcion, Sinapsys.Datos.SQL datosTransaccion=null)
		{
			try 
			{
				OpcionesDetNivelIDataProvider.Instance.Delete(lngIdOpcion,"OpcionesDetNivelI");
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Deletes the OpcionesDetNivelI object by passing CVS parameter as reference
		/// </summary>
		/// <param name="opcionesdetniveli">An instance of OpcionesDetNivelI for reference</param>
		public void Delete(string CVSParameter)
		{
			string[] StrCommand=CVSParameter.Split(',');
			try 
			{
				int lngIdOpcion=int.Parse(StrCommand[0]);
				OpcionesDetNivelIDataProvider.Instance.Delete(lngIdOpcion,"OpcionesDetNivelI");
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Gets the OpcionesDetNivelI object by passing the object's key fields
		/// </summary>
		/// <param name="lngIdOpcion">int that contents the lngIdOpcion value for the OpcionesDetNivelI object</param>
		/// <returns>One OpcionesDetNivelI object</returns>
		public OpcionesDetNivelI Get(int lngIdOpcion, bool generateUndo=false)
		{
			try 
			{
				OpcionesDetNivelI opcionesdetniveli = null;
				DataTable dt = OpcionesDetNivelIDataProvider.Instance.Get(lngIdOpcion);
				if ((dt.Rows.Count > 0))
				{
					opcionesdetniveli = new OpcionesDetNivelI();
					DataRow dr = dt.Rows[0];
					ReadData(opcionesdetniveli, dr, generateUndo);
				}


				return opcionesdetniveli;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Gets all objects of OpcionesDetNivelI
		/// </summary>
		/// <returns>One OpcionesDetNivelIList object</returns>
		public OpcionesDetNivelIList GetAll(bool generateUndo=false)
		{
			try 
			{
				OpcionesDetNivelIList opcionesdetnivelilist = new OpcionesDetNivelIList();
				DataTable dt = OpcionesDetNivelIDataProvider.Instance.GetAll();
				foreach (DataRow dr in dt.Rows)
				{
					OpcionesDetNivelI opcionesdetniveli = new OpcionesDetNivelI();
					ReadData(opcionesdetniveli, dr, generateUndo);
					opcionesdetnivelilist.Add(opcionesdetniveli);
				}
				return opcionesdetnivelilist;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Gets all objects of OpcionesDetNivelI applying filter and sort criteria
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
		/// <returns>One OpcionesDetNivelIList object</returns>
		public OpcionesDetNivelIList GetFilter(int pagenum, int pagesize, string filter, string sort, string extablesfilter, string extablesfieldsfilter, string extablesrelationsfilter, string extablessort, string extablesfieldssort, string extablesrelationssort, bool generateUndo=false)
		{
			try 
			{
				OpcionesDetNivelIList opcionesdetnivelilist = new OpcionesDetNivelIList();

				DataTable dt = OpcionesDetNivelIDataProvider.Instance.GetFilter(pagenum, pagesize, filter, sort, extablesfilter, extablesfieldsfilter, extablesrelationsfilter, extablessort, extablesfieldssort, extablesrelationssort);

				foreach (DataRow dr in dt.Rows)
				{
					OpcionesDetNivelI opcionesdetniveli = new OpcionesDetNivelI();
					ReadData(opcionesdetniveli, dr, generateUndo);
					opcionesdetnivelilist.Add(opcionesdetniveli);
				}
				return opcionesdetnivelilist;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public OpcionesDetNivelIList GetFilter( string filter, string sort, bool generateUndo=false)
		{
			return GetFilter(0,0, filter, sort, "","","","","","",generateUndo);
		}

		public OpcionesDetNivelIList GetFilter(string filter, string sort, string extablesfilter, string extablesfieldsfilter, string extablesrelationsfilter, string extablessort, string extablesfieldssort, string extablesrelationssort, bool generateUndo=false)
		{
			return GetFilter(0,0, filter, sort, extablesfilter, extablesfieldsfilter, extablesrelationsfilter, extablessort, extablesfieldssort, extablesrelationssort,generateUndo);
		}


		/// <summary>
		/// Returns the type for one property
		/// </summary>
		/// <param name="propertyname">Property's name for return its value</param>
		/// <returns>A value for the <paramref name="propertyname"/></returns>
		public Type GetMethodType( string propertyname,OpcionesDetNivelI opcionesdetniveli)
		{
			// Perform the search for the property's value
			switch (propertyname)
			{
				case "strDescOpcion":
					return opcionesdetniveli.strDescOpcion.GetType();

				case "strPrograma":
					return opcionesdetniveli.strPrograma.GetType();

				case "strParametros":
					return opcionesdetniveli.strParametros.GetType();

				case "lngIdOpcionPadre":
					return opcionesdetniveli.lngIdOpcionPadre.GetType();

				case "strTipoOpcion":
					return opcionesdetniveli.strTipoOpcion.GetType();

				case "intOrden":
					return opcionesdetniveli.intOrden.GetType();

				case "WebBrowser":
					return opcionesdetniveli.WebBrowser.GetType();

				case "logExpandeNode":
					return opcionesdetniveli.logExpandeNode.GetType();

				case "strString":
					return opcionesdetniveli.strString.GetType();

				case "strColHidden":
					return opcionesdetniveli.strColHidden.GetType();

				case "lngIdOpcion":
					return opcionesdetniveli.lngIdOpcion.GetType();

			}

			return null;
		}
		/// <summary>
		/// update the changes in OpcionesDetNivelI object by passing the object
		/// </summary>
		public bool UpdateChanges(OpcionesDetNivelI opcionesdetniveli, out string error,Sinapsys.Datos.SQL datosTransaccion=null)
		{
			if (opcionesdetniveli.OldOpcionesDetNivelI == null)
			{
				    error = "No tiene objeto con el cual comparar";
				    return false;
			}
			string[] Fields = opcionesdetniveli.FieldChanged();
			error = "";
			return LiqViajes_Bll_Data.DataProvider.UpdateFieldsbyObject(Fields, opcionesdetniveli, out error,datosTransaccion);
		}
	}

	#endregion

}
