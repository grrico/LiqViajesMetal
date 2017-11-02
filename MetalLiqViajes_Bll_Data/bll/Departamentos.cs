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
	#region DepartamentosController

	/// <summary>
	/// Class for convert data from database into object's data and vice versa
	/// </summary>
	public partial class DepartamentosController//: ILatinodeController
	{
		/// <summary>
		/// Generic Constructor
		/// </summary>
		public DepartamentosController()
		{
		}

		/// <summary>
		/// Instance accessor for this singleton
		/// </summary>
		private static DepartamentosController MySingleObj;
		public static DepartamentosController Instance
		{
			get
			{
				if (MySingleObj == null)
				{
					MySingleObj = new DepartamentosController();
				}
				return MySingleObj;
			}
		}

		// Reads object's data from a DataRow
		private void ReadData(Departamentos departamentos, DataRow dr,bool generateUndo=false)
		{
			try 
			{
				departamentos.lngIdDepartamento = (int) dr["lngIdDepartamento"];
				departamentos.lngIdPais = (int) dr["lngIdPais"];
				departamentos.strNombre = (string) dr["strNombre"];
			}
			catch (Exception ex)
			{
				Utilidades.LogErrores(ex.Message + (ex.InnerException != null ? ex.InnerException.Message : ""), DataProvider.AplicacionNombre);
				throw ex;
			}
			if (generateUndo) departamentos.GenerateUndo();
		}

		/// <summary>
		/// Create a new Departamentos object by passing a object
		/// </summary>
		public Departamentos Create(Departamentos departamentos, Sinapsys.Datos.SQL datosTransaccion=null)
		{
			return Create(departamentos.lngIdDepartamento,departamentos.lngIdPais,departamentos.strNombre,datosTransaccion);
		}

		/// <summary>
		/// Creates a new Departamentos object by passing all object's fields
		/// </summary>
		/// <param name="lngIdPais">int that contents the lngIdPais value for the Departamentos object</param>
		/// <param name="strNombre">string that contents the strNombre value for the Departamentos object</param>
		/// <returns>One Departamentos object</returns>
		public Departamentos Create(int lngIdDepartamento, int lngIdPais, string strNombre, Sinapsys.Datos.SQL datosTransaccion=null)
		{
			try 
			{
				Departamentos departamentos = new Departamentos();

				departamentos.lngIdDepartamento = lngIdDepartamento;
				departamentos.lngIdPais = lngIdPais;
				departamentos.strNombre = strNombre;
				DepartamentosDataProvider.Instance.Create(lngIdDepartamento, lngIdPais, strNombre,"Departamentos");

				return departamentos;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Updates an Departamentos object by passing all object's fields
		/// </summary>
		/// <param name="lngIdDepartamento">int that contents the lngIdDepartamento value for the Departamentos object</param>
		/// <param name="lngIdPais">int that contents the lngIdPais value for the Departamentos object</param>
		/// <param name="strNombre">string that contents the strNombre value for the Departamentos object</param>
		public void Update(int lngIdDepartamento, int lngIdPais, string strNombre, Sinapsys.Datos.SQL datosTransaccion=null)
		{
			try 
			{
				Departamentos new_values = new Departamentos();
				new_values.lngIdPais = lngIdPais;
				new_values.strNombre = strNombre;
				DepartamentosDataProvider.Instance.Update(lngIdDepartamento, lngIdPais, strNombre,"Departamentos",datosTransaccion);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Updates an Departamentos object by passing one object's instance as reference
		/// </summary>
		/// <param name="departamentos">An instance of Departamentos for reference</param>
		public void Update(Departamentos departamentos,Sinapsys.Datos.SQL datosTransaccion=null)
		{
			Update(departamentos.lngIdDepartamento, departamentos.lngIdPais, departamentos.strNombre);
		}

		/// <summary>
		/// Delete  the Departamentos object by passing a object
		/// </summary>
		public void  Delete(Departamentos departamentos, Sinapsys.Datos.SQL datosTransaccion=null)
		{
			Delete(departamentos.lngIdDepartamento,datosTransaccion);
		}

		/// <summary>
		/// Deletes the Departamentos object by passing one object's instance as reference
		/// </summary>
		/// <param name="departamentos">An instance of Departamentos for reference</param>
		public void Delete(int lngIdDepartamento, Sinapsys.Datos.SQL datosTransaccion=null)
		{
			try 
			{
				DepartamentosDataProvider.Instance.Delete(lngIdDepartamento,"Departamentos");
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Deletes the Departamentos object by passing CVS parameter as reference
		/// </summary>
		/// <param name="departamentos">An instance of Departamentos for reference</param>
		public void Delete(string CVSParameter)
		{
			string[] StrCommand=CVSParameter.Split(',');
			try 
			{
				int lngIdDepartamento=int.Parse(StrCommand[0]);
				DepartamentosDataProvider.Instance.Delete(lngIdDepartamento,"Departamentos");
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Gets the Departamentos object by passing the object's key fields
		/// </summary>
		/// <param name="lngIdDepartamento">int that contents the lngIdDepartamento value for the Departamentos object</param>
		/// <returns>One Departamentos object</returns>
		public Departamentos Get(int lngIdDepartamento, bool generateUndo=false)
		{
			try 
			{
				Departamentos departamentos = null;
				DataTable dt = DepartamentosDataProvider.Instance.Get(lngIdDepartamento);
				if ((dt.Rows.Count > 0))
				{
					departamentos = new Departamentos();
					DataRow dr = dt.Rows[0];
					ReadData(departamentos, dr, generateUndo);
				}


				return departamentos;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Gets all objects of Departamentos
		/// </summary>
		/// <returns>One DepartamentosList object</returns>
		public DepartamentosList GetAll(bool generateUndo=false)
		{
			try 
			{
				DepartamentosList departamentoslist = new DepartamentosList();
				DataTable dt = DepartamentosDataProvider.Instance.GetAll();
				foreach (DataRow dr in dt.Rows)
				{
					Departamentos departamentos = new Departamentos();
					ReadData(departamentos, dr, generateUndo);
					departamentoslist.Add(departamentos);
				}
				return departamentoslist;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Gets all objects of Departamentos applying filter and sort criteria
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
		/// <returns>One DepartamentosList object</returns>
		public DepartamentosList GetFilter(int pagenum, int pagesize, string filter, string sort, string extablesfilter, string extablesfieldsfilter, string extablesrelationsfilter, string extablessort, string extablesfieldssort, string extablesrelationssort, bool generateUndo=false)
		{
			try 
			{
				DepartamentosList departamentoslist = new DepartamentosList();

				DataTable dt = DepartamentosDataProvider.Instance.GetFilter(pagenum, pagesize, filter, sort, extablesfilter, extablesfieldsfilter, extablesrelationsfilter, extablessort, extablesfieldssort, extablesrelationssort);

				foreach (DataRow dr in dt.Rows)
				{
					Departamentos departamentos = new Departamentos();
					ReadData(departamentos, dr, generateUndo);
					departamentoslist.Add(departamentos);
				}
				return departamentoslist;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public DepartamentosList GetFilter( string filter, string sort, bool generateUndo=false)
		{
			return GetFilter(0,0, filter, sort, "","","","","","",generateUndo);
		}

		public DepartamentosList GetFilter(string filter, string sort, string extablesfilter, string extablesfieldsfilter, string extablesrelationsfilter, string extablessort, string extablesfieldssort, string extablesrelationssort, bool generateUndo=false)
		{
			return GetFilter(0,0, filter, sort, extablesfilter, extablesfieldsfilter, extablesrelationsfilter, extablessort, extablesfieldssort, extablesrelationssort,generateUndo);
		}


		/// <summary>
		/// Returns the type for one property
		/// </summary>
		/// <param name="propertyname">Property's name for return its value</param>
		/// <returns>A value for the <paramref name="propertyname"/></returns>
		public Type GetMethodType( string propertyname,Departamentos departamentos)
		{
			// Perform the search for the property's value
			switch (propertyname)
			{
				case "lngIdDepartamento":
					return departamentos.lngIdDepartamento.GetType();

				case "lngIdPais":
					return departamentos.lngIdPais.GetType();

				case "strNombre":
					return departamentos.strNombre.GetType();

			}

			return null;
		}
		/// <summary>
		/// update the changes in Departamentos object by passing the object
		/// </summary>
		public bool UpdateChanges(Departamentos departamentos, out string error,Sinapsys.Datos.SQL datosTransaccion=null)
		{
			if (departamentos.OldDepartamentos == null)
			{
				    error = "No tiene objeto con el cual comparar";
				    return false;
			}
			string[] Fields = departamentos.FieldChanged();
			error = "";
			return LiqViajes_Bll_Data.DataProvider.UpdateFieldsbyObject(Fields, departamentos, out error,datosTransaccion);
		}
	}

	#endregion

}
