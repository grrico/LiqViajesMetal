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

namespace LiqMetalDMS_Bll_Data
{
	#region centrosController

	/// <summary>
	/// Class for convert data from database into object's data and vice versa
	/// </summary>
	public partial class centrosController//: ILatinodeController
	{
		/// <summary>
		/// Generic Constructor
		/// </summary>
		public centrosController()
		{
		}

		/// <summary>
		/// Instance accessor for this singleton
		/// </summary>
		private static centrosController MySingleObj;
		public static centrosController Instance
		{
			get
			{
				if (MySingleObj == null)
				{
					MySingleObj = new centrosController();
				}
				return MySingleObj;
			}
		}

		// Reads object's data from a DataRow
		private void ReadData(centros centros, DataRow dr,bool generateUndo=false)
		{
			try 
			{
				centros.id = (int) dr["id"];
				centros.centro = (int) dr["centro"];
				centros.descripcion = (string) dr["descripcion"];
				centros.grupo = (string) dr["grupo"];
				centros.subgrupo = (string) dr["subgrupo"];
				centros.nomina = dr.IsNull("nomina") ? null :(string) dr["nomina"];
				centros.exportado = dr.IsNull("exportado") ? null :(char?) ((string) dr["exportado"])[0];
				centros.centro_alfa = dr.IsNull("centro_alfa") ? null :(string) dr["centro_alfa"];
				centros.inactivo = (bool) dr["inactivo"];
			}
			catch (Exception ex)
			{
				Utilidades.LogErrores(ex.Message + (ex.InnerException != null ? ex.InnerException.Message : ""), DataProvider.AplicacionNombre);
				throw ex;
			}
			if (generateUndo) centros.GenerateUndo();
		}

		/// <summary>
		/// Create a new centros object by passing a object
		/// </summary>
		public centros Create(centros centros, Sinapsys.Datos.SQL datosTransaccion=null)
		{
			return Create(centros.id,centros.centro,centros.descripcion,centros.grupo,centros.subgrupo,centros.nomina,centros.exportado,centros.centro_alfa,centros.inactivo,datosTransaccion);
		}

		/// <summary>
		/// Creates a new centros object by passing all object's fields
		/// </summary>
		/// <param name="descripcion">string that contents the descripcion value for the centros object</param>
		/// <param name="grupo">string that contents the grupo value for the centros object</param>
		/// <param name="subgrupo">string that contents the subgrupo value for the centros object</param>
		/// <param name="nomina">string that contents the nomina value for the centros object</param>
		/// <param name="exportado">char that contents the exportado value for the centros object</param>
		/// <param name="centro_alfa">string that contents the centro_alfa value for the centros object</param>
		/// <param name="inactivo">bool that contents the inactivo value for the centros object</param>
		/// <returns>One centros object</returns>
		public centros Create(int id, int centro, string descripcion, string grupo, string subgrupo, string nomina, char? exportado, string centro_alfa, bool inactivo, Sinapsys.Datos.SQL datosTransaccion=null)
		{
			try 
			{
				centros centros = new centros();

				centros.id = id;
				centros.id = id;
				centros.centro = centro;
				centros.descripcion = descripcion;
				centros.grupo = grupo;
				centros.subgrupo = subgrupo;
				centros.nomina = nomina;
				centros.exportado = exportado;
				centros.centro_alfa = centro_alfa;
				centros.inactivo = inactivo;
				id = centrosDataProvider.Instance.Create(id, centro, descripcion, grupo, subgrupo, nomina, exportado, centro_alfa, inactivo,"centros",datosTransaccion);
				if (id == 0)
					return null;

				centros.id = id;

				return centros;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Updates an centros object by passing all object's fields
		/// </summary>
		/// <param name="id">int that contents the id value for the centros object</param>
		/// <param name="centro">int that contents the centro value for the centros object</param>
		/// <param name="descripcion">string that contents the descripcion value for the centros object</param>
		/// <param name="grupo">string that contents the grupo value for the centros object</param>
		/// <param name="subgrupo">string that contents the subgrupo value for the centros object</param>
		/// <param name="nomina">string that contents the nomina value for the centros object</param>
		/// <param name="exportado">char that contents the exportado value for the centros object</param>
		/// <param name="centro_alfa">string that contents the centro_alfa value for the centros object</param>
		/// <param name="inactivo">bool that contents the inactivo value for the centros object</param>
		public void Update(int id, int centro, string descripcion, string grupo, string subgrupo, string nomina, char? exportado, string centro_alfa, bool inactivo, Sinapsys.Datos.SQL datosTransaccion=null)
		{
			try 
			{
				centros new_values = new centros();
				new_values.descripcion = descripcion;
				new_values.grupo = grupo;
				new_values.subgrupo = subgrupo;
				new_values.nomina = nomina;
				new_values.exportado = exportado;
				new_values.centro_alfa = centro_alfa;
				new_values.inactivo = inactivo;
				centrosDataProvider.Instance.Update(id, centro, descripcion, grupo, subgrupo, nomina, exportado, centro_alfa, inactivo,"centros",datosTransaccion);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Updates an centros object by passing one object's instance as reference
		/// </summary>
		/// <param name="centros">An instance of centros for reference</param>
		public void Update(centros centros,Sinapsys.Datos.SQL datosTransaccion=null)
		{
			Update(centros.id, centros.centro, centros.descripcion, centros.grupo, centros.subgrupo, centros.nomina, centros.exportado, centros.centro_alfa, centros.inactivo);
		}

		/// <summary>
		/// Delete  the centros object by passing a object
		/// </summary>
		public void  Delete(centros centros, Sinapsys.Datos.SQL datosTransaccion=null)
		{
			Delete(centros.id, centros.centro,datosTransaccion);
		}

		/// <summary>
		/// Deletes the centros object by passing one object's instance as reference
		/// </summary>
		/// <param name="centros">An instance of centros for reference</param>
		public void Delete(int id, int centro, Sinapsys.Datos.SQL datosTransaccion=null)
		{
			try 
			{
				//centros old_values = centrosController.Instance.Get(id);
				//if(!Validate.security.CanDeleteSecurityField(centrosController.Instance, (ILatinodeObject)old_values))
				//    throw new Exception("Access denied by security field, you can't delete object");

				centrosDataProvider.Instance.Delete(id, centro,"centros");
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Deletes the centros object by passing CVS parameter as reference
		/// </summary>
		/// <param name="centros">An instance of centros for reference</param>
		public void Delete(string CVSParameter)
		{
			string[] StrCommand=CVSParameter.Split(',');
			try 
			{
				int id=int.Parse(StrCommand[0]);
				int centro=int.Parse(StrCommand[1]);
				centrosDataProvider.Instance.Delete(id, centro,"centros");
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Gets the centros object by passing the object's key fields
		/// </summary>
		/// <param name="id">int that contents the id value for the centros object</param>
		/// <param name="centro">int that contents the centro value for the centros object</param>
		/// <returns>One centros object</returns>
		public centros Get(int id, int centro, bool generateUndo=false)
		{
			try 
			{
				centros centros = null;
				DataTable dt = centrosDataProvider.Instance.Get(id, centro);
				if ((dt.Rows.Count > 0))
				{
					centros = new centros();
					DataRow dr = dt.Rows[0];
					ReadData(centros, dr, generateUndo);
				}


				return centros;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Gets all objects of centros
		/// </summary>
		/// <returns>One centrosList object</returns>
		public centrosList GetAll(bool generateUndo=false)
		{
			try 
			{
				centrosList centroslist = new centrosList();
				DataTable dt = centrosDataProvider.Instance.GetAll();
				foreach (DataRow dr in dt.Rows)
				{
					centros centros = new centros();
					ReadData(centros, dr, generateUndo);
					centroslist.Add(centros);
				}
				return centroslist;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Gets all objects of centros applying filter and sort criteria
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
		/// <returns>One centrosList object</returns>
		public centrosList GetFilter(int pagenum, int pagesize, string filter, string sort, string extablesfilter, string extablesfieldsfilter, string extablesrelationsfilter, string extablessort, string extablesfieldssort, string extablesrelationssort, bool generateUndo=false)
		{
			try 
			{
				centrosList centroslist = new centrosList();

				DataTable dt = centrosDataProvider.Instance.GetFilter(pagenum, pagesize, filter, sort, extablesfilter, extablesfieldsfilter, extablesrelationsfilter, extablessort, extablesfieldssort, extablesrelationssort);

				foreach (DataRow dr in dt.Rows)
				{
					centros centros = new centros();
					ReadData(centros, dr, generateUndo);
					centroslist.Add(centros);
				}
				return centroslist;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public centrosList GetFilter( string filter, string sort, bool generateUndo=false)
		{
			return GetFilter(0,0, filter, sort, "","","","","","",generateUndo);
		}

		public centrosList GetFilter(string filter, string sort, string extablesfilter, string extablesfieldsfilter, string extablesrelationsfilter, string extablessort, string extablesfieldssort, string extablesrelationssort, bool generateUndo=false)
		{
			return GetFilter(0,0, filter, sort, extablesfilter, extablesfieldsfilter, extablesrelationsfilter, extablessort, extablesfieldssort, extablesrelationssort,generateUndo);
		}


		/// <summary>
		/// Returns the type for one property
		/// </summary>
		/// <param name="propertyname">Property's name for return its value</param>
		/// <returns>A value for the <paramref name="propertyname"/></returns>
		public Type GetMethodType( string propertyname,centros centros)
		{
			// Perform the search for the property's value
			switch (propertyname)
			{
				case "id":
					return centros.id.GetType();

				case "centro":
					return centros.centro.GetType();

				case "descripcion":
					return centros.descripcion.GetType();

				case "grupo":
					return centros.grupo.GetType();

				case "subgrupo":
					return centros.subgrupo.GetType();

				case "nomina":
					return centros.nomina.GetType();

				case "exportado":
					return centros.exportado.GetType();

				case "centro_alfa":
					return centros.centro_alfa.GetType();

				case "inactivo":
					return centros.inactivo.GetType();

			}

			return null;
		}
		/// <summary>
		/// update the changes in centros object by passing the object
		/// </summary>
		public bool UpdateChanges(centros centros, out string error,Sinapsys.Datos.SQL datosTransaccion=null)
		{
			if (centros.Oldcentros == null)
			{
				    error = "No tiene objeto con el cual comparar";
				    return false;
			}
			string[] Fields = centros.FieldChanged();
			error = "";
			return LiqMetalDMS_Bll_Data.DataProvider.UpdateFieldsbyObject(Fields, centros, out error,datosTransaccion);
		}
	}

	#endregion

}
