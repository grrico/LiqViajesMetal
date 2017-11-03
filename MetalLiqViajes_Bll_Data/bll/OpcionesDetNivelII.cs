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
	#region OpcionesDetNivelIIController

	/// <summary>
	/// Class for convert data from database into object's data and vice versa
	/// </summary>
	public partial class OpcionesDetNivelIIController//: ILatinodeController
	{
		/// <summary>
		/// Generic Constructor
		/// </summary>
		public OpcionesDetNivelIIController()
		{
		}

		/// <summary>
		/// Instance accessor for this singleton
		/// </summary>
		private static OpcionesDetNivelIIController MySingleObj;
		public static OpcionesDetNivelIIController Instance
		{
			get
			{
				if (MySingleObj == null)
				{
					MySingleObj = new OpcionesDetNivelIIController();
				}
				return MySingleObj;
			}
		}

		// Reads object's data from a DataRow
		private void ReadData(OpcionesDetNivelII opcionesdetnivelii, DataRow dr,bool generateUndo=false)
		{
			try 
			{
				opcionesdetnivelii.strDescOpcion = dr.IsNull("strDescOpcion") ? null :(string) dr["strDescOpcion"];
				opcionesdetnivelii.strPrograma = dr.IsNull("strPrograma") ? null :(string) dr["strPrograma"];
				opcionesdetnivelii.strParametros = dr.IsNull("strParametros") ? null :(string) dr["strParametros"];
				opcionesdetnivelii.lngIdOpcionPadre = dr.IsNull("lngIdOpcionPadre") ? null :(int?) dr["lngIdOpcionPadre"];
				opcionesdetnivelii.strTipoOpcion = dr.IsNull("strTipoOpcion") ? null :(string) dr["strTipoOpcion"];
				opcionesdetnivelii.intOrden = dr.IsNull("intOrden") ? null :(int?) dr["intOrden"];
				opcionesdetnivelii.WebBrowser = dr.IsNull("WebBrowser") ? null :(bool?) dr["WebBrowser"];
				opcionesdetnivelii.lngIdOpcion = (int) dr["lngIdOpcion"];
			}
			catch (Exception ex)
			{
				Utilidades.LogErrores(ex.Message + (ex.InnerException != null ? ex.InnerException.Message : ""), DataProvider.AplicacionNombre);
				throw ex;
			}
			if (generateUndo) opcionesdetnivelii.GenerateUndo();
		}

		/// <summary>
		/// Create a new OpcionesDetNivelII object by passing a object
		/// </summary>
		public OpcionesDetNivelII Create(OpcionesDetNivelII opcionesdetnivelii, Sinapsys.Datos.SQL datosTransaccion=null)
		{
			return Create(opcionesdetnivelii.lngIdOpcion,opcionesdetnivelii.strDescOpcion,opcionesdetnivelii.strPrograma,opcionesdetnivelii.strParametros,opcionesdetnivelii.lngIdOpcionPadre,opcionesdetnivelii.strTipoOpcion,opcionesdetnivelii.intOrden,opcionesdetnivelii.WebBrowser,datosTransaccion);
		}

		/// <summary>
		/// Creates a new OpcionesDetNivelII object by passing all object's fields
		/// </summary>
		/// <param name="strDescOpcion">string that contents the strDescOpcion value for the OpcionesDetNivelII object</param>
		/// <param name="strPrograma">string that contents the strPrograma value for the OpcionesDetNivelII object</param>
		/// <param name="strParametros">string that contents the strParametros value for the OpcionesDetNivelII object</param>
		/// <param name="lngIdOpcionPadre">int that contents the lngIdOpcionPadre value for the OpcionesDetNivelII object</param>
		/// <param name="strTipoOpcion">string that contents the strTipoOpcion value for the OpcionesDetNivelII object</param>
		/// <param name="intOrden">int that contents the intOrden value for the OpcionesDetNivelII object</param>
		/// <param name="WebBrowser">bool that contents the WebBrowser value for the OpcionesDetNivelII object</param>
		/// <returns>One OpcionesDetNivelII object</returns>
		public OpcionesDetNivelII Create(int lngIdOpcion, string strDescOpcion, string strPrograma, string strParametros, int? lngIdOpcionPadre, string strTipoOpcion, int? intOrden, bool? WebBrowser, Sinapsys.Datos.SQL datosTransaccion=null)
		{
			try 
			{
				OpcionesDetNivelII opcionesdetnivelii = new OpcionesDetNivelII();

				opcionesdetnivelii.lngIdOpcion = lngIdOpcion;
				opcionesdetnivelii.strDescOpcion = strDescOpcion;
				opcionesdetnivelii.strPrograma = strPrograma;
				opcionesdetnivelii.strParametros = strParametros;
				opcionesdetnivelii.lngIdOpcionPadre = lngIdOpcionPadre;
				opcionesdetnivelii.strTipoOpcion = strTipoOpcion;
				opcionesdetnivelii.intOrden = intOrden;
				opcionesdetnivelii.WebBrowser = WebBrowser;
				OpcionesDetNivelIIDataProvider.Instance.Create(lngIdOpcion, strDescOpcion, strPrograma, strParametros, lngIdOpcionPadre, strTipoOpcion, intOrden, WebBrowser,"OpcionesDetNivelII");

				return opcionesdetnivelii;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Updates an OpcionesDetNivelII object by passing all object's fields
		/// </summary>
		/// <param name="strDescOpcion">string that contents the strDescOpcion value for the OpcionesDetNivelII object</param>
		/// <param name="strPrograma">string that contents the strPrograma value for the OpcionesDetNivelII object</param>
		/// <param name="strParametros">string that contents the strParametros value for the OpcionesDetNivelII object</param>
		/// <param name="lngIdOpcionPadre">int that contents the lngIdOpcionPadre value for the OpcionesDetNivelII object</param>
		/// <param name="strTipoOpcion">string that contents the strTipoOpcion value for the OpcionesDetNivelII object</param>
		/// <param name="intOrden">int that contents the intOrden value for the OpcionesDetNivelII object</param>
		/// <param name="WebBrowser">bool that contents the WebBrowser value for the OpcionesDetNivelII object</param>
		/// <param name="lngIdOpcion">int that contents the lngIdOpcion value for the OpcionesDetNivelII object</param>
		public void Update(string strDescOpcion, string strPrograma, string strParametros, int? lngIdOpcionPadre, string strTipoOpcion, int? intOrden, bool? WebBrowser, int lngIdOpcion, Sinapsys.Datos.SQL datosTransaccion=null)
		{
			try 
			{
				OpcionesDetNivelII new_values = new OpcionesDetNivelII();
				new_values.strDescOpcion = strDescOpcion;
				new_values.strPrograma = strPrograma;
				new_values.strParametros = strParametros;
				new_values.lngIdOpcionPadre = lngIdOpcionPadre;
				new_values.strTipoOpcion = strTipoOpcion;
				new_values.intOrden = intOrden;
				new_values.WebBrowser = WebBrowser;
				OpcionesDetNivelIIDataProvider.Instance.Update(strDescOpcion, strPrograma, strParametros, lngIdOpcionPadre, strTipoOpcion, intOrden, WebBrowser, lngIdOpcion,"OpcionesDetNivelII",datosTransaccion);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Updates an OpcionesDetNivelII object by passing one object's instance as reference
		/// </summary>
		/// <param name="opcionesdetnivelii">An instance of OpcionesDetNivelII for reference</param>
		public void Update(OpcionesDetNivelII opcionesdetnivelii,Sinapsys.Datos.SQL datosTransaccion=null)
		{
			Update(opcionesdetnivelii.strDescOpcion, opcionesdetnivelii.strPrograma, opcionesdetnivelii.strParametros, opcionesdetnivelii.lngIdOpcionPadre, opcionesdetnivelii.strTipoOpcion, opcionesdetnivelii.intOrden, opcionesdetnivelii.WebBrowser, opcionesdetnivelii.lngIdOpcion);
		}

		/// <summary>
		/// Delete  the OpcionesDetNivelII object by passing a object
		/// </summary>
		public void  Delete(OpcionesDetNivelII opcionesdetnivelii, Sinapsys.Datos.SQL datosTransaccion=null)
		{
			Delete(opcionesdetnivelii.lngIdOpcion,datosTransaccion);
		}

		/// <summary>
		/// Deletes the OpcionesDetNivelII object by passing one object's instance as reference
		/// </summary>
		/// <param name="opcionesdetnivelii">An instance of OpcionesDetNivelII for reference</param>
		public void Delete(int lngIdOpcion, Sinapsys.Datos.SQL datosTransaccion=null)
		{
			try 
			{
				OpcionesDetNivelIIDataProvider.Instance.Delete(lngIdOpcion,"OpcionesDetNivelII");
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Deletes the OpcionesDetNivelII object by passing CVS parameter as reference
		/// </summary>
		/// <param name="opcionesdetnivelii">An instance of OpcionesDetNivelII for reference</param>
		public void Delete(string CVSParameter)
		{
			string[] StrCommand=CVSParameter.Split(',');
			try 
			{
				int lngIdOpcion=int.Parse(StrCommand[0]);
				OpcionesDetNivelIIDataProvider.Instance.Delete(lngIdOpcion,"OpcionesDetNivelII");
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Gets the OpcionesDetNivelII object by passing the object's key fields
		/// </summary>
		/// <param name="lngIdOpcion">int that contents the lngIdOpcion value for the OpcionesDetNivelII object</param>
		/// <returns>One OpcionesDetNivelII object</returns>
		public OpcionesDetNivelII Get(int lngIdOpcion, bool generateUndo=false)
		{
			try 
			{
				OpcionesDetNivelII opcionesdetnivelii = null;
				DataTable dt = OpcionesDetNivelIIDataProvider.Instance.Get(lngIdOpcion);
				if ((dt.Rows.Count > 0))
				{
					opcionesdetnivelii = new OpcionesDetNivelII();
					DataRow dr = dt.Rows[0];
					ReadData(opcionesdetnivelii, dr, generateUndo);
				}


				return opcionesdetnivelii;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Gets all objects of OpcionesDetNivelII
		/// </summary>
		/// <returns>One OpcionesDetNivelIIList object</returns>
		public OpcionesDetNivelIIList GetAll(bool generateUndo=false)
		{
			try 
			{
				OpcionesDetNivelIIList opcionesdetniveliilist = new OpcionesDetNivelIIList();
				DataTable dt = OpcionesDetNivelIIDataProvider.Instance.GetAll();
				foreach (DataRow dr in dt.Rows)
				{
					OpcionesDetNivelII opcionesdetnivelii = new OpcionesDetNivelII();
					ReadData(opcionesdetnivelii, dr, generateUndo);
					opcionesdetniveliilist.Add(opcionesdetnivelii);
				}
				return opcionesdetniveliilist;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Gets all objects of OpcionesDetNivelII applying filter and sort criteria
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
		/// <returns>One OpcionesDetNivelIIList object</returns>
		public OpcionesDetNivelIIList GetFilter(int pagenum, int pagesize, string filter, string sort, string extablesfilter, string extablesfieldsfilter, string extablesrelationsfilter, string extablessort, string extablesfieldssort, string extablesrelationssort, bool generateUndo=false)
		{
			try 
			{
				OpcionesDetNivelIIList opcionesdetniveliilist = new OpcionesDetNivelIIList();

				DataTable dt = OpcionesDetNivelIIDataProvider.Instance.GetFilter(pagenum, pagesize, filter, sort, extablesfilter, extablesfieldsfilter, extablesrelationsfilter, extablessort, extablesfieldssort, extablesrelationssort);

				foreach (DataRow dr in dt.Rows)
				{
					OpcionesDetNivelII opcionesdetnivelii = new OpcionesDetNivelII();
					ReadData(opcionesdetnivelii, dr, generateUndo);
					opcionesdetniveliilist.Add(opcionesdetnivelii);
				}
				return opcionesdetniveliilist;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public OpcionesDetNivelIIList GetFilter( string filter, string sort, bool generateUndo=false)
		{
			return GetFilter(0,0, filter, sort, "","","","","","",generateUndo);
		}

		public OpcionesDetNivelIIList GetFilter(string filter, string sort, string extablesfilter, string extablesfieldsfilter, string extablesrelationsfilter, string extablessort, string extablesfieldssort, string extablesrelationssort, bool generateUndo=false)
		{
			return GetFilter(0,0, filter, sort, extablesfilter, extablesfieldsfilter, extablesrelationsfilter, extablessort, extablesfieldssort, extablesrelationssort,generateUndo);
		}


		/// <summary>
		/// Returns the type for one property
		/// </summary>
		/// <param name="propertyname">Property's name for return its value</param>
		/// <returns>A value for the <paramref name="propertyname"/></returns>
		public Type GetMethodType( string propertyname,OpcionesDetNivelII opcionesdetnivelii)
		{
			// Perform the search for the property's value
			switch (propertyname)
			{
				case "strDescOpcion":
					return opcionesdetnivelii.strDescOpcion.GetType();

				case "strPrograma":
					return opcionesdetnivelii.strPrograma.GetType();

				case "strParametros":
					return opcionesdetnivelii.strParametros.GetType();

				case "lngIdOpcionPadre":
					return opcionesdetnivelii.lngIdOpcionPadre.GetType();

				case "strTipoOpcion":
					return opcionesdetnivelii.strTipoOpcion.GetType();

				case "intOrden":
					return opcionesdetnivelii.intOrden.GetType();

				case "WebBrowser":
					return opcionesdetnivelii.WebBrowser.GetType();

				case "lngIdOpcion":
					return opcionesdetnivelii.lngIdOpcion.GetType();

			}

			return null;
		}
		/// <summary>
		/// update the changes in OpcionesDetNivelII object by passing the object
		/// </summary>
		public bool UpdateChanges(OpcionesDetNivelII opcionesdetnivelii, out string error,Sinapsys.Datos.SQL datosTransaccion=null)
		{
			if (opcionesdetnivelii.OldOpcionesDetNivelII == null)
			{
				    error = "No tiene objeto con el cual comparar";
				    return false;
			}
			string[] Fields = opcionesdetnivelii.FieldChanged();
			error = "";
			return LiqViajes_Bll_Data.DataProvider.UpdateFieldsbyObject(Fields, opcionesdetnivelii, out error,datosTransaccion);
		}
	}

	#endregion

}
