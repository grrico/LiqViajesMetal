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
	#region MarcasVehiculosController

	/// <summary>
	/// Class for convert data from database into object's data and vice versa
	/// </summary>
	public partial class MarcasVehiculosController//: ILatinodeController
	{
		/// <summary>
		/// Generic Constructor
		/// </summary>
		public MarcasVehiculosController()
		{
		}

		/// <summary>
		/// Instance accessor for this singleton
		/// </summary>
		private static MarcasVehiculosController MySingleObj;
		public static MarcasVehiculosController Instance
		{
			get
			{
				if (MySingleObj == null)
				{
					MySingleObj = new MarcasVehiculosController();
				}
				return MySingleObj;
			}
		}

		// Reads object's data from a DataRow
		private void ReadData(MarcasVehiculos marcasvehiculos, DataRow dr,bool generateUndo=false)
		{
			try 
			{
				marcasvehiculos.strMarca = dr.IsNull("strMarca") ? null :(string) dr["strMarca"];
				marcasvehiculos.lngIdRegistro = (int) dr["lngIdRegistro"];
			}
			catch (Exception ex)
			{
				Utilidades.LogErrores(ex.Message + (ex.InnerException != null ? ex.InnerException.Message : ""), DataProvider.AplicacionNombre);
				throw ex;
			}
			if (generateUndo) marcasvehiculos.GenerateUndo();
		}

		/// <summary>
		/// Create a new MarcasVehiculos object by passing a object
		/// </summary>
		public MarcasVehiculos Create(MarcasVehiculos marcasvehiculos, Sinapsys.Datos.SQL datosTransaccion=null)
		{
			return Create(marcasvehiculos.lngIdRegistro,marcasvehiculos.strMarca,datosTransaccion);
		}

		/// <summary>
		/// Creates a new MarcasVehiculos object by passing all object's fields
		/// </summary>
		/// <param name="strMarca">string that contents the strMarca value for the MarcasVehiculos object</param>
		/// <returns>One MarcasVehiculos object</returns>
		public MarcasVehiculos Create(int lngIdRegistro, string strMarca, Sinapsys.Datos.SQL datosTransaccion=null)
		{
			try 
			{
				MarcasVehiculos marcasvehiculos = new MarcasVehiculos();

				marcasvehiculos.lngIdRegistro = lngIdRegistro;
				marcasvehiculos.lngIdRegistro = lngIdRegistro;
				marcasvehiculos.strMarca = strMarca;
				lngIdRegistro = MarcasVehiculosDataProvider.Instance.Create(lngIdRegistro, strMarca,"MarcasVehiculos",datosTransaccion);
				if (lngIdRegistro == 0)
					return null;

				marcasvehiculos.lngIdRegistro = lngIdRegistro;

				return marcasvehiculos;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Updates an MarcasVehiculos object by passing all object's fields
		/// </summary>
		/// <param name="strMarca">string that contents the strMarca value for the MarcasVehiculos object</param>
		/// <param name="lngIdRegistro">int that contents the lngIdRegistro value for the MarcasVehiculos object</param>
		public void Update(string strMarca, int lngIdRegistro, Sinapsys.Datos.SQL datosTransaccion=null)
		{
			try 
			{
				MarcasVehiculos new_values = new MarcasVehiculos();
				new_values.strMarca = strMarca;
				MarcasVehiculosDataProvider.Instance.Update(strMarca, lngIdRegistro,"MarcasVehiculos",datosTransaccion);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Updates an MarcasVehiculos object by passing one object's instance as reference
		/// </summary>
		/// <param name="marcasvehiculos">An instance of MarcasVehiculos for reference</param>
		public void Update(MarcasVehiculos marcasvehiculos,Sinapsys.Datos.SQL datosTransaccion=null)
		{
			Update(marcasvehiculos.strMarca, marcasvehiculos.lngIdRegistro);
		}

		/// <summary>
		/// Delete  the MarcasVehiculos object by passing a object
		/// </summary>
		public void  Delete(MarcasVehiculos marcasvehiculos, Sinapsys.Datos.SQL datosTransaccion=null)
		{
			Delete(marcasvehiculos.lngIdRegistro,datosTransaccion);
		}

		/// <summary>
		/// Deletes the MarcasVehiculos object by passing one object's instance as reference
		/// </summary>
		/// <param name="marcasvehiculos">An instance of MarcasVehiculos for reference</param>
		public void Delete(int lngIdRegistro, Sinapsys.Datos.SQL datosTransaccion=null)
		{
			try 
			{
				//MarcasVehiculos old_values = MarcasVehiculosController.Instance.Get(lngIdRegistro);
				//if(!Validate.security.CanDeleteSecurityField(MarcasVehiculosController.Instance, (ILatinodeObject)old_values))
				//    throw new Exception("Access denied by security field, you can't delete object");

				MarcasVehiculosDataProvider.Instance.Delete(lngIdRegistro,"MarcasVehiculos");
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Deletes the MarcasVehiculos object by passing CVS parameter as reference
		/// </summary>
		/// <param name="marcasvehiculos">An instance of MarcasVehiculos for reference</param>
		public void Delete(string CVSParameter)
		{
			string[] StrCommand=CVSParameter.Split(',');
			try 
			{
				int lngIdRegistro=int.Parse(StrCommand[0]);
				MarcasVehiculosDataProvider.Instance.Delete(lngIdRegistro,"MarcasVehiculos");
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Gets the MarcasVehiculos object by passing the object's key fields
		/// </summary>
		/// <param name="lngIdRegistro">int that contents the lngIdRegistro value for the MarcasVehiculos object</param>
		/// <returns>One MarcasVehiculos object</returns>
		public MarcasVehiculos Get(int lngIdRegistro, bool generateUndo=false)
		{
			try 
			{
				MarcasVehiculos marcasvehiculos = null;
				marcasvehiculos= MasterTables.MarcasVehiculos.Where(r => r.lngIdRegistro== lngIdRegistro).FirstOrDefault();
				if (marcasvehiculos== null)
				{
					MasterTables.Reset("MarcasVehiculos");
					marcasvehiculos= MasterTables.MarcasVehiculos.Where(r => r.lngIdRegistro== lngIdRegistro).FirstOrDefault();
				}
				if (generateUndo) marcasvehiculos.GenerateUndo();

				return marcasvehiculos;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Gets all objects of MarcasVehiculos
		/// </summary>
		/// <returns>One MarcasVehiculosList object</returns>
		public MarcasVehiculosList GetAll(bool generateUndo=false)
		{
			try 
			{
				MarcasVehiculosList marcasvehiculoslist = new MarcasVehiculosList();
				DataTable dt = MarcasVehiculosDataProvider.Instance.GetAll();
				foreach (DataRow dr in dt.Rows)
				{
					MarcasVehiculos marcasvehiculos = new MarcasVehiculos();
					ReadData(marcasvehiculos, dr, generateUndo);
					marcasvehiculoslist.Add(marcasvehiculos);
				}
				return marcasvehiculoslist;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Gets all objects of MarcasVehiculos applying filter and sort criteria
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
		/// <returns>One MarcasVehiculosList object</returns>
		public MarcasVehiculosList GetFilter(int pagenum, int pagesize, string filter, string sort, string extablesfilter, string extablesfieldsfilter, string extablesrelationsfilter, string extablessort, string extablesfieldssort, string extablesrelationssort, bool generateUndo=false)
		{
			try 
			{
				MarcasVehiculosList marcasvehiculoslist = new MarcasVehiculosList();

				DataTable dt = MarcasVehiculosDataProvider.Instance.GetFilter(pagenum, pagesize, filter, sort, extablesfilter, extablesfieldsfilter, extablesrelationsfilter, extablessort, extablesfieldssort, extablesrelationssort);

				foreach (DataRow dr in dt.Rows)
				{
					MarcasVehiculos marcasvehiculos = new MarcasVehiculos();
					ReadData(marcasvehiculos, dr, generateUndo);
					marcasvehiculoslist.Add(marcasvehiculos);
				}
				return marcasvehiculoslist;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public MarcasVehiculosList GetFilter( string filter, string sort, bool generateUndo=false)
		{
			return GetFilter(0,0, filter, sort, "","","","","","",generateUndo);
		}

		public MarcasVehiculosList GetFilter(string filter, string sort, string extablesfilter, string extablesfieldsfilter, string extablesrelationsfilter, string extablessort, string extablesfieldssort, string extablesrelationssort, bool generateUndo=false)
		{
			return GetFilter(0,0, filter, sort, extablesfilter, extablesfieldsfilter, extablesrelationsfilter, extablessort, extablesfieldssort, extablesrelationssort,generateUndo);
		}


		/// <summary>
		/// Returns the type for one property
		/// </summary>
		/// <param name="propertyname">Property's name for return its value</param>
		/// <returns>A value for the <paramref name="propertyname"/></returns>
		public Type GetMethodType( string propertyname,MarcasVehiculos marcasvehiculos)
		{
			// Perform the search for the property's value
			switch (propertyname)
			{
				case "strMarca":
					return marcasvehiculos.strMarca.GetType();

				case "lngIdRegistro":
					return marcasvehiculos.lngIdRegistro.GetType();

			}

			return null;
		}
		/// <summary>
		/// update the changes in MarcasVehiculos object by passing the object
		/// </summary>
		public bool UpdateChanges(MarcasVehiculos marcasvehiculos, out string error,Sinapsys.Datos.SQL datosTransaccion=null)
		{
			if (marcasvehiculos.OldMarcasVehiculos == null)
			{
				    error = "No tiene objeto con el cual comparar";
				    return false;
			}
			string[] Fields = marcasvehiculos.FieldChanged();
			error = "";
			return LiqViajes_Bll_Data.DataProvider.UpdateFieldsbyObject(Fields, marcasvehiculos, out error,datosTransaccion);
		}
	}

	#endregion

}
