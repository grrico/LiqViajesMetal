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
	#region ReportesController

	/// <summary>
	/// Class for convert data from database into object's data and vice versa
	/// </summary>
	public partial class ReportesController//: ILatinodeController
	{
		/// <summary>
		/// Generic Constructor
		/// </summary>
		public ReportesController()
		{
		}

		/// <summary>
		/// Instance accessor for this singleton
		/// </summary>
		private static ReportesController MySingleObj;
		public static ReportesController Instance
		{
			get
			{
				if (MySingleObj == null)
				{
					MySingleObj = new ReportesController();
				}
				return MySingleObj;
			}
		}

		// Reads object's data from a DataRow
		private void ReadData(Reportes reportes, DataRow dr,bool generateUndo=false)
		{
			try 
			{
				reportes.Descripcion = dr.IsNull("Descripcion") ? null :(string) dr["Descripcion"];
				reportes.Activo = dr.IsNull("Activo") ? null :(bool?) dr["Activo"];
				reportes.strSQql = dr.IsNull("strSQql") ? null :(string) dr["strSQql"];
				reportes.Codigo = (int) dr["Codigo"];
			}
			catch (Exception ex)
			{
				Utilidades.LogErrores(ex.Message + (ex.InnerException != null ? ex.InnerException.Message : ""), DataProvider.AplicacionNombre);
				throw ex;
			}
			if (generateUndo) reportes.GenerateUndo();
		}

		/// <summary>
		/// Create a new Reportes object by passing a object
		/// </summary>
		public Reportes Create(Reportes reportes, Sinapsys.Datos.SQL datosTransaccion=null)
		{
			return Create(reportes.Codigo,reportes.Descripcion,reportes.Activo,reportes.strSQql,datosTransaccion);
		}

		/// <summary>
		/// Creates a new Reportes object by passing all object's fields
		/// </summary>
		/// <param name="Descripcion">string that contents the Descripcion value for the Reportes object</param>
		/// <param name="Activo">bool that contents the Activo value for the Reportes object</param>
		/// <param name="strSQql">string that contents the strSQql value for the Reportes object</param>
		/// <returns>One Reportes object</returns>
		public Reportes Create(int Codigo, string Descripcion, bool? Activo, string strSQql, Sinapsys.Datos.SQL datosTransaccion=null)
		{
			try 
			{
				Reportes reportes = new Reportes();

				reportes.Codigo = Codigo;
				reportes.Descripcion = Descripcion;
				reportes.Activo = Activo;
				reportes.strSQql = strSQql;
				ReportesDataProvider.Instance.Create(Codigo, Descripcion, Activo, strSQql,"Reportes");

				return reportes;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Updates an Reportes object by passing all object's fields
		/// </summary>
		/// <param name="Descripcion">string that contents the Descripcion value for the Reportes object</param>
		/// <param name="Activo">bool that contents the Activo value for the Reportes object</param>
		/// <param name="strSQql">string that contents the strSQql value for the Reportes object</param>
		/// <param name="Codigo">int that contents the Codigo value for the Reportes object</param>
		public void Update(string Descripcion, bool? Activo, string strSQql, int Codigo, Sinapsys.Datos.SQL datosTransaccion=null)
		{
			try 
			{
				Reportes new_values = new Reportes();
				new_values.Descripcion = Descripcion;
				new_values.Activo = Activo;
				new_values.strSQql = strSQql;
				ReportesDataProvider.Instance.Update(Descripcion, Activo, strSQql, Codigo,"Reportes",datosTransaccion);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Updates an Reportes object by passing one object's instance as reference
		/// </summary>
		/// <param name="reportes">An instance of Reportes for reference</param>
		public void Update(Reportes reportes,Sinapsys.Datos.SQL datosTransaccion=null)
		{
			Update(reportes.Descripcion, reportes.Activo, reportes.strSQql, reportes.Codigo);
		}

		/// <summary>
		/// Delete  the Reportes object by passing a object
		/// </summary>
		public void  Delete(Reportes reportes, Sinapsys.Datos.SQL datosTransaccion=null)
		{
			Delete(reportes.Codigo,datosTransaccion);
		}

		/// <summary>
		/// Deletes the Reportes object by passing one object's instance as reference
		/// </summary>
		/// <param name="reportes">An instance of Reportes for reference</param>
		public void Delete(int Codigo, Sinapsys.Datos.SQL datosTransaccion=null)
		{
			try 
			{
				ReportesDataProvider.Instance.Delete(Codigo,"Reportes");
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Deletes the Reportes object by passing CVS parameter as reference
		/// </summary>
		/// <param name="reportes">An instance of Reportes for reference</param>
		public void Delete(string CVSParameter)
		{
			string[] StrCommand=CVSParameter.Split(',');
			try 
			{
				int Codigo=int.Parse(StrCommand[0]);
				ReportesDataProvider.Instance.Delete(Codigo,"Reportes");
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Gets the Reportes object by passing the object's key fields
		/// </summary>
		/// <param name="Codigo">int that contents the Codigo value for the Reportes object</param>
		/// <returns>One Reportes object</returns>
		public Reportes Get(int Codigo, bool generateUndo=false)
		{
			try 
			{
				Reportes reportes = null;
				DataTable dt = ReportesDataProvider.Instance.Get(Codigo);
				if ((dt.Rows.Count > 0))
				{
					reportes = new Reportes();
					DataRow dr = dt.Rows[0];
					ReadData(reportes, dr, generateUndo);
				}


				return reportes;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Gets all objects of Reportes
		/// </summary>
		/// <returns>One ReportesList object</returns>
		public ReportesList GetAll(bool generateUndo=false)
		{
			try 
			{
				ReportesList reporteslist = new ReportesList();
				DataTable dt = ReportesDataProvider.Instance.GetAll();
				foreach (DataRow dr in dt.Rows)
				{
					Reportes reportes = new Reportes();
					ReadData(reportes, dr, generateUndo);
					reporteslist.Add(reportes);
				}
				return reporteslist;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Gets all objects of Reportes applying filter and sort criteria
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
		/// <returns>One ReportesList object</returns>
		public ReportesList GetFilter(int pagenum, int pagesize, string filter, string sort, string extablesfilter, string extablesfieldsfilter, string extablesrelationsfilter, string extablessort, string extablesfieldssort, string extablesrelationssort, bool generateUndo=false)
		{
			try 
			{
				ReportesList reporteslist = new ReportesList();

				DataTable dt = ReportesDataProvider.Instance.GetFilter(pagenum, pagesize, filter, sort, extablesfilter, extablesfieldsfilter, extablesrelationsfilter, extablessort, extablesfieldssort, extablesrelationssort);

				foreach (DataRow dr in dt.Rows)
				{
					Reportes reportes = new Reportes();
					ReadData(reportes, dr, generateUndo);
					reporteslist.Add(reportes);
				}
				return reporteslist;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public ReportesList GetFilter( string filter, string sort, bool generateUndo=false)
		{
			return GetFilter(0,0, filter, sort, "","","","","","",generateUndo);
		}

		public ReportesList GetFilter(string filter, string sort, string extablesfilter, string extablesfieldsfilter, string extablesrelationsfilter, string extablessort, string extablesfieldssort, string extablesrelationssort, bool generateUndo=false)
		{
			return GetFilter(0,0, filter, sort, extablesfilter, extablesfieldsfilter, extablesrelationsfilter, extablessort, extablesfieldssort, extablesrelationssort,generateUndo);
		}


		/// <summary>
		/// Returns the type for one property
		/// </summary>
		/// <param name="propertyname">Property's name for return its value</param>
		/// <returns>A value for the <paramref name="propertyname"/></returns>
		public Type GetMethodType( string propertyname,Reportes reportes)
		{
			// Perform the search for the property's value
			switch (propertyname)
			{
				case "Descripcion":
					return reportes.Descripcion.GetType();

				case "Activo":
					return reportes.Activo.GetType();

				case "strSQql":
					return reportes.strSQql.GetType();

				case "Codigo":
					return reportes.Codigo.GetType();

			}

			return null;
		}
		/// <summary>
		/// update the changes in Reportes object by passing the object
		/// </summary>
		public bool UpdateChanges(Reportes reportes, out string error,Sinapsys.Datos.SQL datosTransaccion=null)
		{
			if (reportes.OldReportes == null)
			{
				    error = "No tiene objeto con el cual comparar";
				    return false;
			}
			string[] Fields = reportes.FieldChanged();
			error = "";
			return LiqViajes_Bll_Data.DataProvider.UpdateFieldsbyObject(Fields, reportes, out error,datosTransaccion);
		}
	}

	#endregion

}
