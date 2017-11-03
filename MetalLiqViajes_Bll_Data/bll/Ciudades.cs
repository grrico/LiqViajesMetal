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
	#region CiudadesController

	/// <summary>
	/// Class for convert data from database into object's data and vice versa
	/// </summary>
	public partial class CiudadesController//: ILatinodeController
	{
		/// <summary>
		/// Generic Constructor
		/// </summary>
		public CiudadesController()
		{
		}

		/// <summary>
		/// Instance accessor for this singleton
		/// </summary>
		private static CiudadesController MySingleObj;
		public static CiudadesController Instance
		{
			get
			{
				if (MySingleObj == null)
				{
					MySingleObj = new CiudadesController();
				}
				return MySingleObj;
			}
		}

		// Reads object's data from a DataRow
		private void ReadData(Ciudades ciudades, DataRow dr,bool generateUndo=false)
		{
			try 
			{
				ciudades.lngIdDepartamento = (int) dr["lngIdDepartamento"];
				ciudades.strNombreCiudad = (string) dr["strNombreCiudad"];
				ciudades.lngIdCiudad = (int) dr["lngIdCiudad"];
			}
			catch (Exception ex)
			{
				Utilidades.LogErrores(ex.Message + (ex.InnerException != null ? ex.InnerException.Message : ""), DataProvider.AplicacionNombre);
				throw ex;
			}
			if (generateUndo) ciudades.GenerateUndo();
		}

		/// <summary>
		/// Create a new Ciudades object by passing a object
		/// </summary>
		public Ciudades Create(Ciudades ciudades, Sinapsys.Datos.SQL datosTransaccion=null)
		{
			return Create(ciudades.lngIdCiudad,ciudades.lngIdDepartamento,ciudades.strNombreCiudad,datosTransaccion);
		}

		/// <summary>
		/// Creates a new Ciudades object by passing all object's fields
		/// </summary>
		/// <param name="lngIdDepartamento">int that contents the lngIdDepartamento value for the Ciudades object</param>
		/// <param name="strNombreCiudad">string that contents the strNombreCiudad value for the Ciudades object</param>
		/// <returns>One Ciudades object</returns>
		public Ciudades Create(int lngIdCiudad, int lngIdDepartamento, string strNombreCiudad, Sinapsys.Datos.SQL datosTransaccion=null)
		{
			try 
			{
				Ciudades ciudades = new Ciudades();

				ciudades.lngIdCiudad = lngIdCiudad;
				ciudades.lngIdDepartamento = lngIdDepartamento;
				ciudades.strNombreCiudad = strNombreCiudad;
				CiudadesDataProvider.Instance.Create(lngIdCiudad, lngIdDepartamento, strNombreCiudad,"Ciudades");

				return ciudades;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Updates an Ciudades object by passing all object's fields
		/// </summary>
		/// <param name="lngIdDepartamento">int that contents the lngIdDepartamento value for the Ciudades object</param>
		/// <param name="strNombreCiudad">string that contents the strNombreCiudad value for the Ciudades object</param>
		/// <param name="lngIdCiudad">int that contents the lngIdCiudad value for the Ciudades object</param>
		public void Update(int lngIdDepartamento, string strNombreCiudad, int lngIdCiudad, Sinapsys.Datos.SQL datosTransaccion=null)
		{
			try 
			{
				Ciudades new_values = new Ciudades();
				new_values.lngIdDepartamento = lngIdDepartamento;
				new_values.strNombreCiudad = strNombreCiudad;
				CiudadesDataProvider.Instance.Update(lngIdDepartamento, strNombreCiudad, lngIdCiudad,"Ciudades",datosTransaccion);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Updates an Ciudades object by passing one object's instance as reference
		/// </summary>
		/// <param name="ciudades">An instance of Ciudades for reference</param>
		public void Update(Ciudades ciudades,Sinapsys.Datos.SQL datosTransaccion=null)
		{
			Update(ciudades.lngIdDepartamento, ciudades.strNombreCiudad, ciudades.lngIdCiudad);
		}

		/// <summary>
		/// Delete  the Ciudades object by passing a object
		/// </summary>
		public void  Delete(Ciudades ciudades, Sinapsys.Datos.SQL datosTransaccion=null)
		{
			Delete(ciudades.lngIdCiudad,datosTransaccion);
		}

		/// <summary>
		/// Deletes the Ciudades object by passing one object's instance as reference
		/// </summary>
		/// <param name="ciudades">An instance of Ciudades for reference</param>
		public void Delete(int lngIdCiudad, Sinapsys.Datos.SQL datosTransaccion=null)
		{
			try 
			{
				CiudadesDataProvider.Instance.Delete(lngIdCiudad,"Ciudades");
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Deletes the Ciudades object by passing CVS parameter as reference
		/// </summary>
		/// <param name="ciudades">An instance of Ciudades for reference</param>
		public void Delete(string CVSParameter)
		{
			string[] StrCommand=CVSParameter.Split(',');
			try 
			{
				int lngIdCiudad=int.Parse(StrCommand[0]);
				CiudadesDataProvider.Instance.Delete(lngIdCiudad,"Ciudades");
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Gets the Ciudades object by passing the object's key fields
		/// </summary>
		/// <param name="lngIdCiudad">int that contents the lngIdCiudad value for the Ciudades object</param>
		/// <returns>One Ciudades object</returns>
		public Ciudades Get(int lngIdCiudad, bool generateUndo=false)
		{
			try 
			{
				Ciudades ciudades = null;
				ciudades= MasterTables.Ciudades.Where(r => r.lngIdCiudad== lngIdCiudad).FirstOrDefault();
				if (ciudades== null)
				{
					MasterTables.Reset("Ciudades");
					ciudades= MasterTables.Ciudades.Where(r => r.lngIdCiudad== lngIdCiudad).FirstOrDefault();
				}
				if (generateUndo) ciudades.GenerateUndo();

				return ciudades;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Gets all objects of Ciudades
		/// </summary>
		/// <returns>One CiudadesList object</returns>
		public CiudadesList GetAll(bool generateUndo=false)
		{
			try 
			{
				CiudadesList ciudadeslist = new CiudadesList();
				DataTable dt = CiudadesDataProvider.Instance.GetAll();
				foreach (DataRow dr in dt.Rows)
				{
					Ciudades ciudades = new Ciudades();
					ReadData(ciudades, dr, generateUndo);
					ciudadeslist.Add(ciudades);
				}
				return ciudadeslist;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Gets all objects of Ciudades applying filter and sort criteria
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
		/// <returns>One CiudadesList object</returns>
		public CiudadesList GetFilter(int pagenum, int pagesize, string filter, string sort, string extablesfilter, string extablesfieldsfilter, string extablesrelationsfilter, string extablessort, string extablesfieldssort, string extablesrelationssort, bool generateUndo=false)
		{
			try 
			{
				CiudadesList ciudadeslist = new CiudadesList();

				DataTable dt = CiudadesDataProvider.Instance.GetFilter(pagenum, pagesize, filter, sort, extablesfilter, extablesfieldsfilter, extablesrelationsfilter, extablessort, extablesfieldssort, extablesrelationssort);

				foreach (DataRow dr in dt.Rows)
				{
					Ciudades ciudades = new Ciudades();
					ReadData(ciudades, dr, generateUndo);
					ciudadeslist.Add(ciudades);
				}
				return ciudadeslist;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public CiudadesList GetFilter( string filter, string sort, bool generateUndo=false)
		{
			return GetFilter(0,0, filter, sort, "","","","","","",generateUndo);
		}

		public CiudadesList GetFilter(string filter, string sort, string extablesfilter, string extablesfieldsfilter, string extablesrelationsfilter, string extablessort, string extablesfieldssort, string extablesrelationssort, bool generateUndo=false)
		{
			return GetFilter(0,0, filter, sort, extablesfilter, extablesfieldsfilter, extablesrelationsfilter, extablessort, extablesfieldssort, extablesrelationssort,generateUndo);
		}


		/// <summary>
		/// Returns the type for one property
		/// </summary>
		/// <param name="propertyname">Property's name for return its value</param>
		/// <returns>A value for the <paramref name="propertyname"/></returns>
		public Type GetMethodType( string propertyname,Ciudades ciudades)
		{
			// Perform the search for the property's value
			switch (propertyname)
			{
				case "lngIdDepartamento":
					return ciudades.lngIdDepartamento.GetType();

				case "strNombreCiudad":
					return ciudades.strNombreCiudad.GetType();

				case "lngIdCiudad":
					return ciudades.lngIdCiudad.GetType();

			}

			return null;
		}
		/// <summary>
		/// update the changes in Ciudades object by passing the object
		/// </summary>
		public bool UpdateChanges(Ciudades ciudades, out string error,Sinapsys.Datos.SQL datosTransaccion=null)
		{
			if (ciudades.OldCiudades == null)
			{
				    error = "No tiene objeto con el cual comparar";
				    return false;
			}
			string[] Fields = ciudades.FieldChanged();
			error = "";
			return LiqViajes_Bll_Data.DataProvider.UpdateFieldsbyObject(Fields, ciudades, out error,datosTransaccion);
		}
	}

	#endregion

}
