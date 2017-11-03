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
	#region PaisesController

	/// <summary>
	/// Class for convert data from database into object's data and vice versa
	/// </summary>
	public partial class PaisesController//: ILatinodeController
	{
		/// <summary>
		/// Generic Constructor
		/// </summary>
		public PaisesController()
		{
		}

		/// <summary>
		/// Instance accessor for this singleton
		/// </summary>
		private static PaisesController MySingleObj;
		public static PaisesController Instance
		{
			get
			{
				if (MySingleObj == null)
				{
					MySingleObj = new PaisesController();
				}
				return MySingleObj;
			}
		}

		// Reads object's data from a DataRow
		private void ReadData(Paises paises, DataRow dr,bool generateUndo=false)
		{
			try 
			{
				paises.strNombrePais = (string) dr["strNombrePais"];
				paises.lngIdPais = (int) dr["lngIdPais"];
			}
			catch (Exception ex)
			{
				Utilidades.LogErrores(ex.Message + (ex.InnerException != null ? ex.InnerException.Message : ""), DataProvider.AplicacionNombre);
				throw ex;
			}
			if (generateUndo) paises.GenerateUndo();
		}

		/// <summary>
		/// Create a new Paises object by passing a object
		/// </summary>
		public Paises Create(Paises paises, Sinapsys.Datos.SQL datosTransaccion=null)
		{
			return Create(paises.lngIdPais,paises.strNombrePais,datosTransaccion);
		}

		/// <summary>
		/// Creates a new Paises object by passing all object's fields
		/// </summary>
		/// <param name="strNombrePais">string that contents the strNombrePais value for the Paises object</param>
		/// <returns>One Paises object</returns>
		public Paises Create(int lngIdPais, string strNombrePais, Sinapsys.Datos.SQL datosTransaccion=null)
		{
			try 
			{
				Paises paises = new Paises();

				paises.lngIdPais = lngIdPais;
				paises.lngIdPais = lngIdPais;
				paises.strNombrePais = strNombrePais;
				lngIdPais = PaisesDataProvider.Instance.Create(lngIdPais, strNombrePais,"Paises",datosTransaccion);
				if (lngIdPais == 0)
					return null;

				paises.lngIdPais = lngIdPais;

				return paises;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Updates an Paises object by passing all object's fields
		/// </summary>
		/// <param name="strNombrePais">string that contents the strNombrePais value for the Paises object</param>
		/// <param name="lngIdPais">int that contents the lngIdPais value for the Paises object</param>
		public void Update(string strNombrePais, int lngIdPais, Sinapsys.Datos.SQL datosTransaccion=null)
		{
			try 
			{
				Paises new_values = new Paises();
				new_values.strNombrePais = strNombrePais;
				PaisesDataProvider.Instance.Update(strNombrePais, lngIdPais,"Paises",datosTransaccion);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Updates an Paises object by passing one object's instance as reference
		/// </summary>
		/// <param name="paises">An instance of Paises for reference</param>
		public void Update(Paises paises,Sinapsys.Datos.SQL datosTransaccion=null)
		{
			Update(paises.strNombrePais, paises.lngIdPais);
		}

		/// <summary>
		/// Delete  the Paises object by passing a object
		/// </summary>
		public void  Delete(Paises paises, Sinapsys.Datos.SQL datosTransaccion=null)
		{
			Delete(paises.lngIdPais,datosTransaccion);
		}

		/// <summary>
		/// Deletes the Paises object by passing one object's instance as reference
		/// </summary>
		/// <param name="paises">An instance of Paises for reference</param>
		public void Delete(int lngIdPais, Sinapsys.Datos.SQL datosTransaccion=null)
		{
			try 
			{
				//Paises old_values = PaisesController.Instance.Get(lngIdPais);
				//if(!Validate.security.CanDeleteSecurityField(PaisesController.Instance, (ILatinodeObject)old_values))
				//    throw new Exception("Access denied by security field, you can't delete object");

				PaisesDataProvider.Instance.Delete(lngIdPais,"Paises");
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Deletes the Paises object by passing CVS parameter as reference
		/// </summary>
		/// <param name="paises">An instance of Paises for reference</param>
		public void Delete(string CVSParameter)
		{
			string[] StrCommand=CVSParameter.Split(',');
			try 
			{
				int lngIdPais=int.Parse(StrCommand[0]);
				PaisesDataProvider.Instance.Delete(lngIdPais,"Paises");
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Gets the Paises object by passing the object's key fields
		/// </summary>
		/// <param name="lngIdPais">int that contents the lngIdPais value for the Paises object</param>
		/// <returns>One Paises object</returns>
		public Paises Get(int lngIdPais, bool generateUndo=false)
		{
			try 
			{
				Paises paises = null;
				paises= MasterTables.Paises.Where(r => r.lngIdPais== lngIdPais).FirstOrDefault();
				if (paises== null)
				{
					MasterTables.Reset("Paises");
					paises= MasterTables.Paises.Where(r => r.lngIdPais== lngIdPais).FirstOrDefault();
				}
				if (generateUndo) paises.GenerateUndo();

				return paises;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Gets all objects of Paises
		/// </summary>
		/// <returns>One PaisesList object</returns>
		public PaisesList GetAll(bool generateUndo=false)
		{
			try 
			{
				PaisesList paiseslist = new PaisesList();
				DataTable dt = PaisesDataProvider.Instance.GetAll();
				foreach (DataRow dr in dt.Rows)
				{
					Paises paises = new Paises();
					ReadData(paises, dr, generateUndo);
					paiseslist.Add(paises);
				}
				return paiseslist;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Gets all objects of Paises applying filter and sort criteria
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
		/// <returns>One PaisesList object</returns>
		public PaisesList GetFilter(int pagenum, int pagesize, string filter, string sort, string extablesfilter, string extablesfieldsfilter, string extablesrelationsfilter, string extablessort, string extablesfieldssort, string extablesrelationssort, bool generateUndo=false)
		{
			try 
			{
				PaisesList paiseslist = new PaisesList();

				DataTable dt = PaisesDataProvider.Instance.GetFilter(pagenum, pagesize, filter, sort, extablesfilter, extablesfieldsfilter, extablesrelationsfilter, extablessort, extablesfieldssort, extablesrelationssort);

				foreach (DataRow dr in dt.Rows)
				{
					Paises paises = new Paises();
					ReadData(paises, dr, generateUndo);
					paiseslist.Add(paises);
				}
				return paiseslist;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public PaisesList GetFilter( string filter, string sort, bool generateUndo=false)
		{
			return GetFilter(0,0, filter, sort, "","","","","","",generateUndo);
		}

		public PaisesList GetFilter(string filter, string sort, string extablesfilter, string extablesfieldsfilter, string extablesrelationsfilter, string extablessort, string extablesfieldssort, string extablesrelationssort, bool generateUndo=false)
		{
			return GetFilter(0,0, filter, sort, extablesfilter, extablesfieldsfilter, extablesrelationsfilter, extablessort, extablesfieldssort, extablesrelationssort,generateUndo);
		}


		/// <summary>
		/// Returns the type for one property
		/// </summary>
		/// <param name="propertyname">Property's name for return its value</param>
		/// <returns>A value for the <paramref name="propertyname"/></returns>
		public Type GetMethodType( string propertyname,Paises paises)
		{
			// Perform the search for the property's value
			switch (propertyname)
			{
				case "strNombrePais":
					return paises.strNombrePais.GetType();

				case "lngIdPais":
					return paises.lngIdPais.GetType();

			}

			return null;
		}
		/// <summary>
		/// update the changes in Paises object by passing the object
		/// </summary>
		public bool UpdateChanges(Paises paises, out string error,Sinapsys.Datos.SQL datosTransaccion=null)
		{
			if (paises.OldPaises == null)
			{
				    error = "No tiene objeto con el cual comparar";
				    return false;
			}
			string[] Fields = paises.FieldChanged();
			error = "";
			return LiqViajes_Bll_Data.DataProvider.UpdateFieldsbyObject(Fields, paises, out error,datosTransaccion);
		}
	}

	#endregion

}
