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
	#region consecutivosController

	/// <summary>
	/// Class for convert data from database into object's data and vice versa
	/// </summary>
	public partial class consecutivosController//: ILatinodeController
	{
		/// <summary>
		/// Generic Constructor
		/// </summary>
		public consecutivosController()
		{
		}

		/// <summary>
		/// Instance accessor for this singleton
		/// </summary>
		private static consecutivosController MySingleObj;
		public static consecutivosController Instance
		{
			get
			{
				if (MySingleObj == null)
				{
					MySingleObj = new consecutivosController();
				}
				return MySingleObj;
			}
		}

		// Reads object's data from a DataRow
		private void ReadData(consecutivos consecutivos, DataRow dr,bool generateUndo=false)
		{
			try 
			{
				consecutivos.tipo = (string) dr["tipo"];
				consecutivos.siguiente = dr.IsNull("siguiente") ? null :(int?) dr["siguiente"];
			}
			catch (Exception ex)
			{
				Utilidades.LogErrores(ex.Message + (ex.InnerException != null ? ex.InnerException.Message : ""), DataProvider.AplicacionNombre);
				throw ex;
			}
			if (generateUndo) consecutivos.GenerateUndo();
		}

		/// <summary>
		/// Create a new consecutivos object by passing a object
		/// </summary>
		public consecutivos Create(consecutivos consecutivos, Sinapsys.Datos.SQL datosTransaccion=null)
		{
			return Create(consecutivos.tipo,consecutivos.siguiente,datosTransaccion);
		}

		/// <summary>
		/// Creates a new consecutivos object by passing all object's fields
		/// </summary>
		/// <param name="siguiente">int that contents the siguiente value for the consecutivos object</param>
		/// <returns>One consecutivos object</returns>
		public consecutivos Create(string tipo, int? siguiente, Sinapsys.Datos.SQL datosTransaccion=null)
		{
			try 
			{
				consecutivos consecutivos = new consecutivos();

				consecutivos.tipo = tipo;
				consecutivos.siguiente = siguiente;
				consecutivosDataProvider.Instance.Create(tipo, siguiente,"consecutivos");

				return consecutivos;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Updates an consecutivos object by passing all object's fields
		/// </summary>
		/// <param name="tipo">string that contents the tipo value for the consecutivos object</param>
		/// <param name="siguiente">int that contents the siguiente value for the consecutivos object</param>
		public void Update(string tipo, int? siguiente, Sinapsys.Datos.SQL datosTransaccion=null)
		{
			try 
			{
				consecutivos new_values = new consecutivos();
				new_values.siguiente = siguiente;
				consecutivosDataProvider.Instance.Update(tipo, siguiente,"consecutivos",datosTransaccion);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Updates an consecutivos object by passing one object's instance as reference
		/// </summary>
		/// <param name="consecutivos">An instance of consecutivos for reference</param>
		public void Update(consecutivos consecutivos,Sinapsys.Datos.SQL datosTransaccion=null)
		{
			Update(consecutivos.tipo, consecutivos.siguiente);
		}

		/// <summary>
		/// Delete  the consecutivos object by passing a object
		/// </summary>
		public void  Delete(consecutivos consecutivos, Sinapsys.Datos.SQL datosTransaccion=null)
		{
			Delete(consecutivos.tipo,datosTransaccion);
		}

		/// <summary>
		/// Deletes the consecutivos object by passing one object's instance as reference
		/// </summary>
		/// <param name="consecutivos">An instance of consecutivos for reference</param>
		public void Delete(string tipo, Sinapsys.Datos.SQL datosTransaccion=null)
		{
			try 
			{
				consecutivosDataProvider.Instance.Delete(tipo,"consecutivos");
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Gets the consecutivos object by passing the object's key fields
		/// </summary>
		/// <param name="tipo">string that contents the tipo value for the consecutivos object</param>
		/// <returns>One consecutivos object</returns>
		public consecutivos Get(string tipo, bool generateUndo=false)
		{
			try 
			{
				consecutivos consecutivos = null;
				DataTable dt = consecutivosDataProvider.Instance.Get(tipo);
				if ((dt.Rows.Count > 0))
				{
					consecutivos = new consecutivos();
					DataRow dr = dt.Rows[0];
					ReadData(consecutivos, dr, generateUndo);
				}


				return consecutivos;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Gets all objects of consecutivos
		/// </summary>
		/// <returns>One consecutivosList object</returns>
		public consecutivosList GetAll(bool generateUndo=false)
		{
			try 
			{
				consecutivosList consecutivoslist = new consecutivosList();
				DataTable dt = consecutivosDataProvider.Instance.GetAll();
				foreach (DataRow dr in dt.Rows)
				{
					consecutivos consecutivos = new consecutivos();
					ReadData(consecutivos, dr, generateUndo);
					consecutivoslist.Add(consecutivos);
				}
				return consecutivoslist;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Gets all objects of consecutivos applying filter and sort criteria
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
		/// <returns>One consecutivosList object</returns>
		public consecutivosList GetFilter(int pagenum, int pagesize, string filter, string sort, string extablesfilter, string extablesfieldsfilter, string extablesrelationsfilter, string extablessort, string extablesfieldssort, string extablesrelationssort, bool generateUndo=false)
		{
			try 
			{
				consecutivosList consecutivoslist = new consecutivosList();

				DataTable dt = consecutivosDataProvider.Instance.GetFilter(pagenum, pagesize, filter, sort, extablesfilter, extablesfieldsfilter, extablesrelationsfilter, extablessort, extablesfieldssort, extablesrelationssort);

				foreach (DataRow dr in dt.Rows)
				{
					consecutivos consecutivos = new consecutivos();
					ReadData(consecutivos, dr, generateUndo);
					consecutivoslist.Add(consecutivos);
				}
				return consecutivoslist;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public consecutivosList GetFilter( string filter, string sort, bool generateUndo=false)
		{
			return GetFilter(0,0, filter, sort, "","","","","","",generateUndo);
		}

		public consecutivosList GetFilter(string filter, string sort, string extablesfilter, string extablesfieldsfilter, string extablesrelationsfilter, string extablessort, string extablesfieldssort, string extablesrelationssort, bool generateUndo=false)
		{
			return GetFilter(0,0, filter, sort, extablesfilter, extablesfieldsfilter, extablesrelationsfilter, extablessort, extablesfieldssort, extablesrelationssort,generateUndo);
		}


		/// <summary>
		/// Returns the type for one property
		/// </summary>
		/// <param name="propertyname">Property's name for return its value</param>
		/// <returns>A value for the <paramref name="propertyname"/></returns>
		public Type GetMethodType( string propertyname,consecutivos consecutivos)
		{
			// Perform the search for the property's value
			switch (propertyname)
			{
				case "tipo":
					return consecutivos.tipo.GetType();

				case "siguiente":
					return consecutivos.siguiente.GetType();

			}

			return null;
		}
		/// <summary>
		/// update the changes in consecutivos object by passing the object
		/// </summary>
		public bool UpdateChanges(consecutivos consecutivos, out string error,Sinapsys.Datos.SQL datosTransaccion=null)
		{
			if (consecutivos.Oldconsecutivos == null)
			{
				    error = "No tiene objeto con el cual comparar";
				    return false;
			}
			string[] Fields = consecutivos.FieldChanged();
			error = "";
			return LiqViajes_Bll_Data.DataProvider.UpdateFieldsbyObject(Fields, consecutivos, out error,datosTransaccion);
		}
	}

	#endregion

}
