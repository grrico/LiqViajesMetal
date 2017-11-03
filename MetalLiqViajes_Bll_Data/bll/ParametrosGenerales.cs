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
	#region ParametrosGeneralesController

	/// <summary>
	/// Class for convert data from database into object's data and vice versa
	/// </summary>
	public partial class ParametrosGeneralesController//: ILatinodeController
	{
		/// <summary>
		/// Generic Constructor
		/// </summary>
		public ParametrosGeneralesController()
		{
		}

		/// <summary>
		/// Instance accessor for this singleton
		/// </summary>
		private static ParametrosGeneralesController MySingleObj;
		public static ParametrosGeneralesController Instance
		{
			get
			{
				if (MySingleObj == null)
				{
					MySingleObj = new ParametrosGeneralesController();
				}
				return MySingleObj;
			}
		}

		// Reads object's data from a DataRow
		private void ReadData(ParametrosGenerales parametrosgenerales, DataRow dr,bool generateUndo=false)
		{
			try 
			{
				parametrosgenerales.Descipcion = dr.IsNull("Descipcion") ? null :(string) dr["Descipcion"];
				parametrosgenerales.ValorParametro = dr.IsNull("ValorParametro") ? null :(string) dr["ValorParametro"];
				parametrosgenerales.Codigo = (int) dr["Codigo"];
			}
			catch (Exception ex)
			{
				Utilidades.LogErrores(ex.Message + (ex.InnerException != null ? ex.InnerException.Message : ""), DataProvider.AplicacionNombre);
				throw ex;
			}
			if (generateUndo) parametrosgenerales.GenerateUndo();
		}

		/// <summary>
		/// Create a new ParametrosGenerales object by passing a object
		/// </summary>
		public ParametrosGenerales Create(ParametrosGenerales parametrosgenerales, Sinapsys.Datos.SQL datosTransaccion=null)
		{
			return Create(parametrosgenerales.Codigo,parametrosgenerales.Descipcion,parametrosgenerales.ValorParametro,datosTransaccion);
		}

		/// <summary>
		/// Creates a new ParametrosGenerales object by passing all object's fields
		/// </summary>
		/// <param name="Descipcion">string that contents the Descipcion value for the ParametrosGenerales object</param>
		/// <param name="ValorParametro">string that contents the ValorParametro value for the ParametrosGenerales object</param>
		/// <returns>One ParametrosGenerales object</returns>
		public ParametrosGenerales Create(int Codigo, string Descipcion, string ValorParametro, Sinapsys.Datos.SQL datosTransaccion=null)
		{
			try 
			{
				ParametrosGenerales parametrosgenerales = new ParametrosGenerales();

				parametrosgenerales.Codigo = Codigo;
				parametrosgenerales.Codigo = Codigo;
				parametrosgenerales.Descipcion = Descipcion;
				parametrosgenerales.ValorParametro = ValorParametro;
				Codigo = ParametrosGeneralesDataProvider.Instance.Create(Codigo, Descipcion, ValorParametro,"ParametrosGenerales",datosTransaccion);
				if (Codigo == 0)
					return null;

				parametrosgenerales.Codigo = Codigo;

				return parametrosgenerales;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Updates an ParametrosGenerales object by passing all object's fields
		/// </summary>
		/// <param name="Descipcion">string that contents the Descipcion value for the ParametrosGenerales object</param>
		/// <param name="ValorParametro">string that contents the ValorParametro value for the ParametrosGenerales object</param>
		/// <param name="Codigo">int that contents the Codigo value for the ParametrosGenerales object</param>
		public void Update(string Descipcion, string ValorParametro, int Codigo, Sinapsys.Datos.SQL datosTransaccion=null)
		{
			try 
			{
				ParametrosGenerales new_values = new ParametrosGenerales();
				new_values.Descipcion = Descipcion;
				new_values.ValorParametro = ValorParametro;
				ParametrosGeneralesDataProvider.Instance.Update(Descipcion, ValorParametro, Codigo,"ParametrosGenerales",datosTransaccion);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Updates an ParametrosGenerales object by passing one object's instance as reference
		/// </summary>
		/// <param name="parametrosgenerales">An instance of ParametrosGenerales for reference</param>
		public void Update(ParametrosGenerales parametrosgenerales,Sinapsys.Datos.SQL datosTransaccion=null)
		{
			Update(parametrosgenerales.Descipcion, parametrosgenerales.ValorParametro, parametrosgenerales.Codigo);
		}

		/// <summary>
		/// Delete  the ParametrosGenerales object by passing a object
		/// </summary>
		public void  Delete(ParametrosGenerales parametrosgenerales, Sinapsys.Datos.SQL datosTransaccion=null)
		{
			Delete(parametrosgenerales.Codigo,datosTransaccion);
		}

		/// <summary>
		/// Deletes the ParametrosGenerales object by passing one object's instance as reference
		/// </summary>
		/// <param name="parametrosgenerales">An instance of ParametrosGenerales for reference</param>
		public void Delete(int Codigo, Sinapsys.Datos.SQL datosTransaccion=null)
		{
			try 
			{
				//ParametrosGenerales old_values = ParametrosGeneralesController.Instance.Get(Codigo);
				//if(!Validate.security.CanDeleteSecurityField(ParametrosGeneralesController.Instance, (ILatinodeObject)old_values))
				//    throw new Exception("Access denied by security field, you can't delete object");

				ParametrosGeneralesDataProvider.Instance.Delete(Codigo,"ParametrosGenerales");
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Deletes the ParametrosGenerales object by passing CVS parameter as reference
		/// </summary>
		/// <param name="parametrosgenerales">An instance of ParametrosGenerales for reference</param>
		public void Delete(string CVSParameter)
		{
			string[] StrCommand=CVSParameter.Split(',');
			try 
			{
				int Codigo=int.Parse(StrCommand[0]);
				ParametrosGeneralesDataProvider.Instance.Delete(Codigo,"ParametrosGenerales");
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Gets the ParametrosGenerales object by passing the object's key fields
		/// </summary>
		/// <param name="Codigo">int that contents the Codigo value for the ParametrosGenerales object</param>
		/// <returns>One ParametrosGenerales object</returns>
		public ParametrosGenerales Get(int Codigo, bool generateUndo=false)
		{
			try 
			{
				ParametrosGenerales parametrosgenerales = null;
				DataTable dt = ParametrosGeneralesDataProvider.Instance.Get(Codigo);
				if ((dt.Rows.Count > 0))
				{
					parametrosgenerales = new ParametrosGenerales();
					DataRow dr = dt.Rows[0];
					ReadData(parametrosgenerales, dr, generateUndo);
				}


				return parametrosgenerales;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Gets all objects of ParametrosGenerales
		/// </summary>
		/// <returns>One ParametrosGeneralesList object</returns>
		public ParametrosGeneralesList GetAll(bool generateUndo=false)
		{
			try 
			{
				ParametrosGeneralesList parametrosgeneraleslist = new ParametrosGeneralesList();
				DataTable dt = ParametrosGeneralesDataProvider.Instance.GetAll();
				foreach (DataRow dr in dt.Rows)
				{
					ParametrosGenerales parametrosgenerales = new ParametrosGenerales();
					ReadData(parametrosgenerales, dr, generateUndo);
					parametrosgeneraleslist.Add(parametrosgenerales);
				}
				return parametrosgeneraleslist;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Gets all objects of ParametrosGenerales applying filter and sort criteria
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
		/// <returns>One ParametrosGeneralesList object</returns>
		public ParametrosGeneralesList GetFilter(int pagenum, int pagesize, string filter, string sort, string extablesfilter, string extablesfieldsfilter, string extablesrelationsfilter, string extablessort, string extablesfieldssort, string extablesrelationssort, bool generateUndo=false)
		{
			try 
			{
				ParametrosGeneralesList parametrosgeneraleslist = new ParametrosGeneralesList();

				DataTable dt = ParametrosGeneralesDataProvider.Instance.GetFilter(pagenum, pagesize, filter, sort, extablesfilter, extablesfieldsfilter, extablesrelationsfilter, extablessort, extablesfieldssort, extablesrelationssort);

				foreach (DataRow dr in dt.Rows)
				{
					ParametrosGenerales parametrosgenerales = new ParametrosGenerales();
					ReadData(parametrosgenerales, dr, generateUndo);
					parametrosgeneraleslist.Add(parametrosgenerales);
				}
				return parametrosgeneraleslist;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public ParametrosGeneralesList GetFilter( string filter, string sort, bool generateUndo=false)
		{
			return GetFilter(0,0, filter, sort, "","","","","","",generateUndo);
		}

		public ParametrosGeneralesList GetFilter(string filter, string sort, string extablesfilter, string extablesfieldsfilter, string extablesrelationsfilter, string extablessort, string extablesfieldssort, string extablesrelationssort, bool generateUndo=false)
		{
			return GetFilter(0,0, filter, sort, extablesfilter, extablesfieldsfilter, extablesrelationsfilter, extablessort, extablesfieldssort, extablesrelationssort,generateUndo);
		}


		/// <summary>
		/// Returns the type for one property
		/// </summary>
		/// <param name="propertyname">Property's name for return its value</param>
		/// <returns>A value for the <paramref name="propertyname"/></returns>
		public Type GetMethodType( string propertyname,ParametrosGenerales parametrosgenerales)
		{
			// Perform the search for the property's value
			switch (propertyname)
			{
				case "Descipcion":
					return parametrosgenerales.Descipcion.GetType();

				case "ValorParametro":
					return parametrosgenerales.ValorParametro.GetType();

				case "Codigo":
					return parametrosgenerales.Codigo.GetType();

			}

			return null;
		}
		/// <summary>
		/// update the changes in ParametrosGenerales object by passing the object
		/// </summary>
		public bool UpdateChanges(ParametrosGenerales parametrosgenerales, out string error,Sinapsys.Datos.SQL datosTransaccion=null)
		{
			if (parametrosgenerales.OldParametrosGenerales == null)
			{
				    error = "No tiene objeto con el cual comparar";
				    return false;
			}
			string[] Fields = parametrosgenerales.FieldChanged();
			error = "";
			return LiqViajes_Bll_Data.DataProvider.UpdateFieldsbyObject(Fields, parametrosgenerales, out error,datosTransaccion);
		}
	}

	#endregion

}
