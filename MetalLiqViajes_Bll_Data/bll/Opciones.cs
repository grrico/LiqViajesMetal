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
	#region OpcionesController

	/// <summary>
	/// Class for convert data from database into object's data and vice versa
	/// </summary>
	public partial class OpcionesController//: ILatinodeController
	{
		/// <summary>
		/// Generic Constructor
		/// </summary>
		public OpcionesController()
		{
		}

		/// <summary>
		/// Instance accessor for this singleton
		/// </summary>
		private static OpcionesController MySingleObj;
		public static OpcionesController Instance
		{
			get
			{
				if (MySingleObj == null)
				{
					MySingleObj = new OpcionesController();
				}
				return MySingleObj;
			}
		}

		// Reads object's data from a DataRow
		private void ReadData(Opciones opciones, DataRow dr,bool generateUndo=false)
		{
			try 
			{
				opciones.strDescOpcion = dr.IsNull("strDescOpcion") ? null :(string) dr["strDescOpcion"];
				opciones.strPrograma = dr.IsNull("strPrograma") ? null :(string) dr["strPrograma"];
				opciones.strParametros = dr.IsNull("strParametros") ? null :(string) dr["strParametros"];
				opciones.lngIdOpcionPadre = dr.IsNull("lngIdOpcionPadre") ? null :(int?) dr["lngIdOpcionPadre"];
				opciones.strTipoOpcion = dr.IsNull("strTipoOpcion") ? null :(string) dr["strTipoOpcion"];
				opciones.intOrden = dr.IsNull("intOrden") ? null :(int?) dr["intOrden"];
				opciones.WebBrowser = dr.IsNull("WebBrowser") ? null :(bool?) dr["WebBrowser"];
				opciones.logExpandeNode = dr.IsNull("logExpandeNode") ? null :(bool?) dr["logExpandeNode"];
				opciones.lngIdOpcion = (int) dr["lngIdOpcion"];
			}
			catch (Exception ex)
			{
				Utilidades.LogErrores(ex.Message + (ex.InnerException != null ? ex.InnerException.Message : ""), DataProvider.AplicacionNombre);
				throw ex;
			}
			if (generateUndo) opciones.GenerateUndo();
		}

		/// <summary>
		/// Create a new Opciones object by passing a object
		/// </summary>
		public Opciones Create(Opciones opciones, Sinapsys.Datos.SQL datosTransaccion=null)
		{
			return Create(opciones.lngIdOpcion,opciones.strDescOpcion,opciones.strPrograma,opciones.strParametros,opciones.lngIdOpcionPadre,opciones.strTipoOpcion,opciones.intOrden,opciones.WebBrowser,opciones.logExpandeNode,datosTransaccion);
		}

		/// <summary>
		/// Creates a new Opciones object by passing all object's fields
		/// </summary>
		/// <param name="strDescOpcion">string that contents the strDescOpcion value for the Opciones object</param>
		/// <param name="strPrograma">string that contents the strPrograma value for the Opciones object</param>
		/// <param name="strParametros">string that contents the strParametros value for the Opciones object</param>
		/// <param name="lngIdOpcionPadre">int that contents the lngIdOpcionPadre value for the Opciones object</param>
		/// <param name="strTipoOpcion">string that contents the strTipoOpcion value for the Opciones object</param>
		/// <param name="intOrden">int that contents the intOrden value for the Opciones object</param>
		/// <param name="WebBrowser">bool that contents the WebBrowser value for the Opciones object</param>
		/// <param name="logExpandeNode">bool that contents the logExpandeNode value for the Opciones object</param>
		/// <returns>One Opciones object</returns>
		public Opciones Create(int lngIdOpcion, string strDescOpcion, string strPrograma, string strParametros, int? lngIdOpcionPadre, string strTipoOpcion, int? intOrden, bool? WebBrowser, bool? logExpandeNode, Sinapsys.Datos.SQL datosTransaccion=null)
		{
			try 
			{
				Opciones opciones = new Opciones();

				opciones.lngIdOpcion = lngIdOpcion;
				opciones.strDescOpcion = strDescOpcion;
				opciones.strPrograma = strPrograma;
				opciones.strParametros = strParametros;
				opciones.lngIdOpcionPadre = lngIdOpcionPadre;
				opciones.strTipoOpcion = strTipoOpcion;
				opciones.intOrden = intOrden;
				opciones.WebBrowser = WebBrowser;
				opciones.logExpandeNode = logExpandeNode;
				OpcionesDataProvider.Instance.Create(lngIdOpcion, strDescOpcion, strPrograma, strParametros, lngIdOpcionPadre, strTipoOpcion, intOrden, WebBrowser, logExpandeNode,"Opciones");

				return opciones;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Updates an Opciones object by passing all object's fields
		/// </summary>
		/// <param name="strDescOpcion">string that contents the strDescOpcion value for the Opciones object</param>
		/// <param name="strPrograma">string that contents the strPrograma value for the Opciones object</param>
		/// <param name="strParametros">string that contents the strParametros value for the Opciones object</param>
		/// <param name="lngIdOpcionPadre">int that contents the lngIdOpcionPadre value for the Opciones object</param>
		/// <param name="strTipoOpcion">string that contents the strTipoOpcion value for the Opciones object</param>
		/// <param name="intOrden">int that contents the intOrden value for the Opciones object</param>
		/// <param name="WebBrowser">bool that contents the WebBrowser value for the Opciones object</param>
		/// <param name="logExpandeNode">bool that contents the logExpandeNode value for the Opciones object</param>
		/// <param name="lngIdOpcion">int that contents the lngIdOpcion value for the Opciones object</param>
		public void Update(string strDescOpcion, string strPrograma, string strParametros, int? lngIdOpcionPadre, string strTipoOpcion, int? intOrden, bool? WebBrowser, bool? logExpandeNode, int lngIdOpcion, Sinapsys.Datos.SQL datosTransaccion=null)
		{
			try 
			{
				Opciones new_values = new Opciones();
				new_values.strDescOpcion = strDescOpcion;
				new_values.strPrograma = strPrograma;
				new_values.strParametros = strParametros;
				new_values.lngIdOpcionPadre = lngIdOpcionPadre;
				new_values.strTipoOpcion = strTipoOpcion;
				new_values.intOrden = intOrden;
				new_values.WebBrowser = WebBrowser;
				new_values.logExpandeNode = logExpandeNode;
				OpcionesDataProvider.Instance.Update(strDescOpcion, strPrograma, strParametros, lngIdOpcionPadre, strTipoOpcion, intOrden, WebBrowser, logExpandeNode, lngIdOpcion,"Opciones",datosTransaccion);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Updates an Opciones object by passing one object's instance as reference
		/// </summary>
		/// <param name="opciones">An instance of Opciones for reference</param>
		public void Update(Opciones opciones,Sinapsys.Datos.SQL datosTransaccion=null)
		{
			Update(opciones.strDescOpcion, opciones.strPrograma, opciones.strParametros, opciones.lngIdOpcionPadre, opciones.strTipoOpcion, opciones.intOrden, opciones.WebBrowser, opciones.logExpandeNode, opciones.lngIdOpcion);
		}

		/// <summary>
		/// Delete  the Opciones object by passing a object
		/// </summary>
		public void  Delete(Opciones opciones, Sinapsys.Datos.SQL datosTransaccion=null)
		{
			Delete(opciones.lngIdOpcion,datosTransaccion);
		}

		/// <summary>
		/// Deletes the Opciones object by passing one object's instance as reference
		/// </summary>
		/// <param name="opciones">An instance of Opciones for reference</param>
		public void Delete(int lngIdOpcion, Sinapsys.Datos.SQL datosTransaccion=null)
		{
			try 
			{
				OpcionesDataProvider.Instance.Delete(lngIdOpcion,"Opciones");
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Deletes the Opciones object by passing CVS parameter as reference
		/// </summary>
		/// <param name="opciones">An instance of Opciones for reference</param>
		public void Delete(string CVSParameter)
		{
			string[] StrCommand=CVSParameter.Split(',');
			try 
			{
				int lngIdOpcion=int.Parse(StrCommand[0]);
				OpcionesDataProvider.Instance.Delete(lngIdOpcion,"Opciones");
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Gets the Opciones object by passing the object's key fields
		/// </summary>
		/// <param name="lngIdOpcion">int that contents the lngIdOpcion value for the Opciones object</param>
		/// <returns>One Opciones object</returns>
		public Opciones Get(int lngIdOpcion, bool generateUndo=false)
		{
			try 
			{
				Opciones opciones = null;
				opciones= MasterTables.Opciones.Where(r => r.lngIdOpcion== lngIdOpcion).FirstOrDefault();
				if (opciones== null)
				{
					MasterTables.Reset("Opciones");
					opciones= MasterTables.Opciones.Where(r => r.lngIdOpcion== lngIdOpcion).FirstOrDefault();
				}
				if (generateUndo) opciones.GenerateUndo();

				return opciones;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Gets all objects of Opciones
		/// </summary>
		/// <returns>One OpcionesList object</returns>
		public OpcionesList GetAll(bool generateUndo=false)
		{
			try 
			{
				OpcionesList opcioneslist = new OpcionesList();
				DataTable dt = OpcionesDataProvider.Instance.GetAll();
				foreach (DataRow dr in dt.Rows)
				{
					Opciones opciones = new Opciones();
					ReadData(opciones, dr, generateUndo);
					opcioneslist.Add(opciones);
				}
				return opcioneslist;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Gets all objects of Opciones applying filter and sort criteria
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
		/// <returns>One OpcionesList object</returns>
		public OpcionesList GetFilter(int pagenum, int pagesize, string filter, string sort, string extablesfilter, string extablesfieldsfilter, string extablesrelationsfilter, string extablessort, string extablesfieldssort, string extablesrelationssort, bool generateUndo=false)
		{
			try 
			{
				OpcionesList opcioneslist = new OpcionesList();

				DataTable dt = OpcionesDataProvider.Instance.GetFilter(pagenum, pagesize, filter, sort, extablesfilter, extablesfieldsfilter, extablesrelationsfilter, extablessort, extablesfieldssort, extablesrelationssort);

				foreach (DataRow dr in dt.Rows)
				{
					Opciones opciones = new Opciones();
					ReadData(opciones, dr, generateUndo);
					opcioneslist.Add(opciones);
				}
				return opcioneslist;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public OpcionesList GetFilter( string filter, string sort, bool generateUndo=false)
		{
			return GetFilter(0,0, filter, sort, "","","","","","",generateUndo);
		}

		public OpcionesList GetFilter(string filter, string sort, string extablesfilter, string extablesfieldsfilter, string extablesrelationsfilter, string extablessort, string extablesfieldssort, string extablesrelationssort, bool generateUndo=false)
		{
			return GetFilter(0,0, filter, sort, extablesfilter, extablesfieldsfilter, extablesrelationsfilter, extablessort, extablesfieldssort, extablesrelationssort,generateUndo);
		}


		/// <summary>
		/// Returns the type for one property
		/// </summary>
		/// <param name="propertyname">Property's name for return its value</param>
		/// <returns>A value for the <paramref name="propertyname"/></returns>
		public Type GetMethodType( string propertyname,Opciones opciones)
		{
			// Perform the search for the property's value
			switch (propertyname)
			{
				case "strDescOpcion":
					return opciones.strDescOpcion.GetType();

				case "strPrograma":
					return opciones.strPrograma.GetType();

				case "strParametros":
					return opciones.strParametros.GetType();

				case "lngIdOpcionPadre":
					return opciones.lngIdOpcionPadre.GetType();

				case "strTipoOpcion":
					return opciones.strTipoOpcion.GetType();

				case "intOrden":
					return opciones.intOrden.GetType();

				case "WebBrowser":
					return opciones.WebBrowser.GetType();

				case "logExpandeNode":
					return opciones.logExpandeNode.GetType();

				case "lngIdOpcion":
					return opciones.lngIdOpcion.GetType();

			}

			return null;
		}
		/// <summary>
		/// update the changes in Opciones object by passing the object
		/// </summary>
		public bool UpdateChanges(Opciones opciones, out string error,Sinapsys.Datos.SQL datosTransaccion=null)
		{
			if (opciones.OldOpciones == null)
			{
				    error = "No tiene objeto con el cual comparar";
				    return false;
			}
			string[] Fields = opciones.FieldChanged();
			error = "";
			return LiqViajes_Bll_Data.DataProvider.UpdateFieldsbyObject(Fields, opciones, out error,datosTransaccion);
		}
	}

	#endregion

}
