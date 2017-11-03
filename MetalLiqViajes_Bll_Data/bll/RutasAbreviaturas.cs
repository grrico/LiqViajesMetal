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
	#region RutasAbreviaturasController

	/// <summary>
	/// Class for convert data from database into object's data and vice versa
	/// </summary>
	public partial class RutasAbreviaturasController//: ILatinodeController
	{
		/// <summary>
		/// Generic Constructor
		/// </summary>
		public RutasAbreviaturasController()
		{
		}

		/// <summary>
		/// Instance accessor for this singleton
		/// </summary>
		private static RutasAbreviaturasController MySingleObj;
		public static RutasAbreviaturasController Instance
		{
			get
			{
				if (MySingleObj == null)
				{
					MySingleObj = new RutasAbreviaturasController();
				}
				return MySingleObj;
			}
		}

		// Reads object's data from a DataRow
		private void ReadData(RutasAbreviaturas rutasabreviaturas, DataRow dr,bool generateUndo=false)
		{
			try 
			{
				rutasabreviaturas.strAbreviatura = dr.IsNull("strAbreviatura") ? null :(string) dr["strAbreviatura"];
				rutasabreviaturas.strNombreAbreviatura = dr.IsNull("strNombreAbreviatura") ? null :(string) dr["strNombreAbreviatura"];
				rutasabreviaturas.lngIdAbreviatura = (int) dr["lngIdAbreviatura"];
			}
			catch (Exception ex)
			{
				Utilidades.LogErrores(ex.Message + (ex.InnerException != null ? ex.InnerException.Message : ""), DataProvider.AplicacionNombre);
				throw ex;
			}
			if (generateUndo) rutasabreviaturas.GenerateUndo();
		}

		/// <summary>
		/// Create a new RutasAbreviaturas object by passing a object
		/// </summary>
		public RutasAbreviaturas Create(RutasAbreviaturas rutasabreviaturas, Sinapsys.Datos.SQL datosTransaccion=null)
		{
			return Create(rutasabreviaturas.lngIdAbreviatura,rutasabreviaturas.strAbreviatura,rutasabreviaturas.strNombreAbreviatura,datosTransaccion);
		}

		/// <summary>
		/// Creates a new RutasAbreviaturas object by passing all object's fields
		/// </summary>
		/// <param name="strAbreviatura">string that contents the strAbreviatura value for the RutasAbreviaturas object</param>
		/// <param name="strNombreAbreviatura">string that contents the strNombreAbreviatura value for the RutasAbreviaturas object</param>
		/// <returns>One RutasAbreviaturas object</returns>
		public RutasAbreviaturas Create(int lngIdAbreviatura, string strAbreviatura, string strNombreAbreviatura, Sinapsys.Datos.SQL datosTransaccion=null)
		{
			try 
			{
				RutasAbreviaturas rutasabreviaturas = new RutasAbreviaturas();

				rutasabreviaturas.lngIdAbreviatura = lngIdAbreviatura;
				rutasabreviaturas.lngIdAbreviatura = lngIdAbreviatura;
				rutasabreviaturas.strAbreviatura = strAbreviatura;
				rutasabreviaturas.strNombreAbreviatura = strNombreAbreviatura;
				lngIdAbreviatura = RutasAbreviaturasDataProvider.Instance.Create(lngIdAbreviatura, strAbreviatura, strNombreAbreviatura,"RutasAbreviaturas",datosTransaccion);
				if (lngIdAbreviatura == 0)
					return null;

				rutasabreviaturas.lngIdAbreviatura = lngIdAbreviatura;

				return rutasabreviaturas;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Updates an RutasAbreviaturas object by passing all object's fields
		/// </summary>
		/// <param name="strAbreviatura">string that contents the strAbreviatura value for the RutasAbreviaturas object</param>
		/// <param name="strNombreAbreviatura">string that contents the strNombreAbreviatura value for the RutasAbreviaturas object</param>
		/// <param name="lngIdAbreviatura">int that contents the lngIdAbreviatura value for the RutasAbreviaturas object</param>
		public void Update(string strAbreviatura, string strNombreAbreviatura, int lngIdAbreviatura, Sinapsys.Datos.SQL datosTransaccion=null)
		{
			try 
			{
				RutasAbreviaturas new_values = new RutasAbreviaturas();
				new_values.strAbreviatura = strAbreviatura;
				new_values.strNombreAbreviatura = strNombreAbreviatura;
				RutasAbreviaturasDataProvider.Instance.Update(strAbreviatura, strNombreAbreviatura, lngIdAbreviatura,"RutasAbreviaturas",datosTransaccion);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Updates an RutasAbreviaturas object by passing one object's instance as reference
		/// </summary>
		/// <param name="rutasabreviaturas">An instance of RutasAbreviaturas for reference</param>
		public void Update(RutasAbreviaturas rutasabreviaturas,Sinapsys.Datos.SQL datosTransaccion=null)
		{
			Update(rutasabreviaturas.strAbreviatura, rutasabreviaturas.strNombreAbreviatura, rutasabreviaturas.lngIdAbreviatura);
		}

		/// <summary>
		/// Delete  the RutasAbreviaturas object by passing a object
		/// </summary>
		public void  Delete(RutasAbreviaturas rutasabreviaturas, Sinapsys.Datos.SQL datosTransaccion=null)
		{
			Delete(rutasabreviaturas.lngIdAbreviatura,datosTransaccion);
		}

		/// <summary>
		/// Deletes the RutasAbreviaturas object by passing one object's instance as reference
		/// </summary>
		/// <param name="rutasabreviaturas">An instance of RutasAbreviaturas for reference</param>
		public void Delete(int lngIdAbreviatura, Sinapsys.Datos.SQL datosTransaccion=null)
		{
			try 
			{
				//RutasAbreviaturas old_values = RutasAbreviaturasController.Instance.Get(lngIdAbreviatura);
				//if(!Validate.security.CanDeleteSecurityField(RutasAbreviaturasController.Instance, (ILatinodeObject)old_values))
				//    throw new Exception("Access denied by security field, you can't delete object");

				RutasAbreviaturasDataProvider.Instance.Delete(lngIdAbreviatura,"RutasAbreviaturas");
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Deletes the RutasAbreviaturas object by passing CVS parameter as reference
		/// </summary>
		/// <param name="rutasabreviaturas">An instance of RutasAbreviaturas for reference</param>
		public void Delete(string CVSParameter)
		{
			string[] StrCommand=CVSParameter.Split(',');
			try 
			{
				int lngIdAbreviatura=int.Parse(StrCommand[0]);
				RutasAbreviaturasDataProvider.Instance.Delete(lngIdAbreviatura,"RutasAbreviaturas");
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Gets the RutasAbreviaturas object by passing the object's key fields
		/// </summary>
		/// <param name="lngIdAbreviatura">int that contents the lngIdAbreviatura value for the RutasAbreviaturas object</param>
		/// <returns>One RutasAbreviaturas object</returns>
		public RutasAbreviaturas Get(int lngIdAbreviatura, bool generateUndo=false)
		{
			try 
			{
				RutasAbreviaturas rutasabreviaturas = null;
				rutasabreviaturas= MasterTables.RutasAbreviaturas.Where(r => r.lngIdAbreviatura== lngIdAbreviatura).FirstOrDefault();
				if (rutasabreviaturas== null)
				{
					MasterTables.Reset("RutasAbreviaturas");
					rutasabreviaturas= MasterTables.RutasAbreviaturas.Where(r => r.lngIdAbreviatura== lngIdAbreviatura).FirstOrDefault();
				}
				if (generateUndo) rutasabreviaturas.GenerateUndo();

				return rutasabreviaturas;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Gets all objects of RutasAbreviaturas
		/// </summary>
		/// <returns>One RutasAbreviaturasList object</returns>
		public RutasAbreviaturasList GetAll(bool generateUndo=false)
		{
			try 
			{
				RutasAbreviaturasList rutasabreviaturaslist = new RutasAbreviaturasList();
				DataTable dt = RutasAbreviaturasDataProvider.Instance.GetAll();
				foreach (DataRow dr in dt.Rows)
				{
					RutasAbreviaturas rutasabreviaturas = new RutasAbreviaturas();
					ReadData(rutasabreviaturas, dr, generateUndo);
					rutasabreviaturaslist.Add(rutasabreviaturas);
				}
				return rutasabreviaturaslist;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Gets all objects of RutasAbreviaturas applying filter and sort criteria
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
		/// <returns>One RutasAbreviaturasList object</returns>
		public RutasAbreviaturasList GetFilter(int pagenum, int pagesize, string filter, string sort, string extablesfilter, string extablesfieldsfilter, string extablesrelationsfilter, string extablessort, string extablesfieldssort, string extablesrelationssort, bool generateUndo=false)
		{
			try 
			{
				RutasAbreviaturasList rutasabreviaturaslist = new RutasAbreviaturasList();

				DataTable dt = RutasAbreviaturasDataProvider.Instance.GetFilter(pagenum, pagesize, filter, sort, extablesfilter, extablesfieldsfilter, extablesrelationsfilter, extablessort, extablesfieldssort, extablesrelationssort);

				foreach (DataRow dr in dt.Rows)
				{
					RutasAbreviaturas rutasabreviaturas = new RutasAbreviaturas();
					ReadData(rutasabreviaturas, dr, generateUndo);
					rutasabreviaturaslist.Add(rutasabreviaturas);
				}
				return rutasabreviaturaslist;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public RutasAbreviaturasList GetFilter( string filter, string sort, bool generateUndo=false)
		{
			return GetFilter(0,0, filter, sort, "","","","","","",generateUndo);
		}

		public RutasAbreviaturasList GetFilter(string filter, string sort, string extablesfilter, string extablesfieldsfilter, string extablesrelationsfilter, string extablessort, string extablesfieldssort, string extablesrelationssort, bool generateUndo=false)
		{
			return GetFilter(0,0, filter, sort, extablesfilter, extablesfieldsfilter, extablesrelationsfilter, extablessort, extablesfieldssort, extablesrelationssort,generateUndo);
		}


		/// <summary>
		/// Returns the type for one property
		/// </summary>
		/// <param name="propertyname">Property's name for return its value</param>
		/// <returns>A value for the <paramref name="propertyname"/></returns>
		public Type GetMethodType( string propertyname,RutasAbreviaturas rutasabreviaturas)
		{
			// Perform the search for the property's value
			switch (propertyname)
			{
				case "strAbreviatura":
					return rutasabreviaturas.strAbreviatura.GetType();

				case "strNombreAbreviatura":
					return rutasabreviaturas.strNombreAbreviatura.GetType();

				case "lngIdAbreviatura":
					return rutasabreviaturas.lngIdAbreviatura.GetType();

			}

			return null;
		}
		/// <summary>
		/// update the changes in RutasAbreviaturas object by passing the object
		/// </summary>
		public bool UpdateChanges(RutasAbreviaturas rutasabreviaturas, out string error,Sinapsys.Datos.SQL datosTransaccion=null)
		{
			if (rutasabreviaturas.OldRutasAbreviaturas == null)
			{
				    error = "No tiene objeto con el cual comparar";
				    return false;
			}
			string[] Fields = rutasabreviaturas.FieldChanged();
			error = "";
			return LiqViajes_Bll_Data.DataProvider.UpdateFieldsbyObject(Fields, rutasabreviaturas, out error,datosTransaccion);
		}
	}

	#endregion

}
