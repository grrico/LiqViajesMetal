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
	#region RutasCombustibleController

	/// <summary>
	/// Class for convert data from database into object's data and vice versa
	/// </summary>
	public partial class RutasCombustibleController//: ILatinodeController
	{
		/// <summary>
		/// Generic Constructor
		/// </summary>
		public RutasCombustibleController()
		{
		}

		/// <summary>
		/// Instance accessor for this singleton
		/// </summary>
		private static RutasCombustibleController MySingleObj;
		public static RutasCombustibleController Instance
		{
			get
			{
				if (MySingleObj == null)
				{
					MySingleObj = new RutasCombustibleController();
				}
				return MySingleObj;
			}
		}

		// Reads object's data from a DataRow
		private void ReadData(RutasCombustible rutascombustible, DataRow dr,bool generateUndo=false)
		{
			try 
			{
				rutascombustible.lngIdRegistro = (int) dr["lngIdRegistro"];
				rutascombustible.strNombreGrupo = dr.IsNull("strNombreGrupo") ? null :(string) dr["strNombreGrupo"];
				rutascombustible.cutCombustible = dr.IsNull("cutCombustible") ? null :(decimal?) dr["cutCombustible"];
				rutascombustible.TipoVehiculo = dr.IsNull("TipoVehiculo") ? null :(string) dr["TipoVehiculo"];
				rutascombustible.DescripcionVehiculo = dr.IsNull("DescripcionVehiculo") ? null :(string) dr["DescripcionVehiculo"];
			}
			catch (Exception ex)
			{
				Utilidades.LogErrores(ex.Message + (ex.InnerException != null ? ex.InnerException.Message : ""), DataProvider.AplicacionNombre);
				throw ex;
			}
			if (generateUndo) rutascombustible.GenerateUndo();
		}

		/// <summary>
		/// Create a new RutasCombustible object by passing a object
		/// </summary>
		public RutasCombustible Create(RutasCombustible rutascombustible, Sinapsys.Datos.SQL datosTransaccion=null)
		{
			return Create(rutascombustible.lngIdRegistro,rutascombustible.strNombreGrupo,rutascombustible.cutCombustible,rutascombustible.TipoVehiculo,rutascombustible.DescripcionVehiculo,datosTransaccion);
		}

		/// <summary>
		/// Creates a new RutasCombustible object by passing all object's fields
		/// </summary>
		/// <param name="strNombreGrupo">string that contents the strNombreGrupo value for the RutasCombustible object</param>
		/// <param name="cutCombustible">decimal that contents the cutCombustible value for the RutasCombustible object</param>
		/// <param name="TipoVehiculo">string that contents the TipoVehiculo value for the RutasCombustible object</param>
		/// <param name="DescripcionVehiculo">string that contents the DescripcionVehiculo value for the RutasCombustible object</param>
		/// <returns>One RutasCombustible object</returns>
		public RutasCombustible Create(int lngIdRegistro, string strNombreGrupo, decimal? cutCombustible, string TipoVehiculo, string DescripcionVehiculo, Sinapsys.Datos.SQL datosTransaccion=null)
		{
			try 
			{
				RutasCombustible rutascombustible = new RutasCombustible();

				rutascombustible.lngIdRegistro = lngIdRegistro;
				rutascombustible.lngIdRegistro = lngIdRegistro;
				rutascombustible.strNombreGrupo = strNombreGrupo;
				rutascombustible.cutCombustible = cutCombustible;
				rutascombustible.TipoVehiculo = TipoVehiculo;
				rutascombustible.DescripcionVehiculo = DescripcionVehiculo;
				lngIdRegistro = RutasCombustibleDataProvider.Instance.Create(lngIdRegistro, strNombreGrupo, cutCombustible, TipoVehiculo, DescripcionVehiculo,"RutasCombustible",datosTransaccion);
				if (lngIdRegistro == 0)
					return null;

				rutascombustible.lngIdRegistro = lngIdRegistro;

				return rutascombustible;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Updates an RutasCombustible object by passing all object's fields
		/// </summary>
		/// <param name="lngIdRegistro">int that contents the lngIdRegistro value for the RutasCombustible object</param>
		/// <param name="strNombreGrupo">string that contents the strNombreGrupo value for the RutasCombustible object</param>
		/// <param name="cutCombustible">decimal that contents the cutCombustible value for the RutasCombustible object</param>
		/// <param name="TipoVehiculo">string that contents the TipoVehiculo value for the RutasCombustible object</param>
		/// <param name="DescripcionVehiculo">string that contents the DescripcionVehiculo value for the RutasCombustible object</param>
		public void Update(int lngIdRegistro, string strNombreGrupo, decimal? cutCombustible, string TipoVehiculo, string DescripcionVehiculo, Sinapsys.Datos.SQL datosTransaccion=null)
		{
			try 
			{
				RutasCombustible new_values = new RutasCombustible();
				new_values.strNombreGrupo = strNombreGrupo;
				new_values.cutCombustible = cutCombustible;
				new_values.TipoVehiculo = TipoVehiculo;
				new_values.DescripcionVehiculo = DescripcionVehiculo;
				RutasCombustibleDataProvider.Instance.Update(lngIdRegistro, strNombreGrupo, cutCombustible, TipoVehiculo, DescripcionVehiculo,"RutasCombustible",datosTransaccion);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Updates an RutasCombustible object by passing one object's instance as reference
		/// </summary>
		/// <param name="rutascombustible">An instance of RutasCombustible for reference</param>
		public void Update(RutasCombustible rutascombustible,Sinapsys.Datos.SQL datosTransaccion=null)
		{
			Update(rutascombustible.lngIdRegistro, rutascombustible.strNombreGrupo, rutascombustible.cutCombustible, rutascombustible.TipoVehiculo, rutascombustible.DescripcionVehiculo);
		}

		/// <summary>
		/// Delete  the RutasCombustible object by passing a object
		/// </summary>
		public void  Delete(RutasCombustible rutascombustible, Sinapsys.Datos.SQL datosTransaccion=null)
		{
			Delete(rutascombustible.lngIdRegistro,datosTransaccion);
		}

		/// <summary>
		/// Deletes the RutasCombustible object by passing one object's instance as reference
		/// </summary>
		/// <param name="rutascombustible">An instance of RutasCombustible for reference</param>
		public void Delete(int lngIdRegistro, Sinapsys.Datos.SQL datosTransaccion=null)
		{
			try 
			{
				//RutasCombustible old_values = RutasCombustibleController.Instance.Get(lngIdRegistro);
				//if(!Validate.security.CanDeleteSecurityField(RutasCombustibleController.Instance, (ILatinodeObject)old_values))
				//    throw new Exception("Access denied by security field, you can't delete object");

				RutasCombustibleDataProvider.Instance.Delete(lngIdRegistro,"RutasCombustible");
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Deletes the RutasCombustible object by passing CVS parameter as reference
		/// </summary>
		/// <param name="rutascombustible">An instance of RutasCombustible for reference</param>
		public void Delete(string CVSParameter)
		{
			string[] StrCommand=CVSParameter.Split(',');
			try 
			{
				int lngIdRegistro=int.Parse(StrCommand[0]);
				RutasCombustibleDataProvider.Instance.Delete(lngIdRegistro,"RutasCombustible");
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Gets the RutasCombustible object by passing the object's key fields
		/// </summary>
		/// <param name="lngIdRegistro">int that contents the lngIdRegistro value for the RutasCombustible object</param>
		/// <returns>One RutasCombustible object</returns>
		public RutasCombustible Get(int lngIdRegistro, bool generateUndo=false)
		{
			try 
			{
				RutasCombustible rutascombustible = null;
				DataTable dt = RutasCombustibleDataProvider.Instance.Get(lngIdRegistro);
				if ((dt.Rows.Count > 0))
				{
					rutascombustible = new RutasCombustible();
					DataRow dr = dt.Rows[0];
					ReadData(rutascombustible, dr, generateUndo);
				}


				return rutascombustible;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Gets all objects of RutasCombustible
		/// </summary>
		/// <returns>One RutasCombustibleList object</returns>
		public RutasCombustibleList GetAll(bool generateUndo=false)
		{
			try 
			{
				RutasCombustibleList rutascombustiblelist = new RutasCombustibleList();
				DataTable dt = RutasCombustibleDataProvider.Instance.GetAll();
				foreach (DataRow dr in dt.Rows)
				{
					RutasCombustible rutascombustible = new RutasCombustible();
					ReadData(rutascombustible, dr, generateUndo);
					rutascombustiblelist.Add(rutascombustible);
				}
				return rutascombustiblelist;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Gets all objects of RutasCombustible applying filter and sort criteria
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
		/// <returns>One RutasCombustibleList object</returns>
		public RutasCombustibleList GetFilter(int pagenum, int pagesize, string filter, string sort, string extablesfilter, string extablesfieldsfilter, string extablesrelationsfilter, string extablessort, string extablesfieldssort, string extablesrelationssort, bool generateUndo=false)
		{
			try 
			{
				RutasCombustibleList rutascombustiblelist = new RutasCombustibleList();

				DataTable dt = RutasCombustibleDataProvider.Instance.GetFilter(pagenum, pagesize, filter, sort, extablesfilter, extablesfieldsfilter, extablesrelationsfilter, extablessort, extablesfieldssort, extablesrelationssort);

				foreach (DataRow dr in dt.Rows)
				{
					RutasCombustible rutascombustible = new RutasCombustible();
					ReadData(rutascombustible, dr, generateUndo);
					rutascombustiblelist.Add(rutascombustible);
				}
				return rutascombustiblelist;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public RutasCombustibleList GetFilter( string filter, string sort, bool generateUndo=false)
		{
			return GetFilter(0,0, filter, sort, "","","","","","",generateUndo);
		}

		public RutasCombustibleList GetFilter(string filter, string sort, string extablesfilter, string extablesfieldsfilter, string extablesrelationsfilter, string extablessort, string extablesfieldssort, string extablesrelationssort, bool generateUndo=false)
		{
			return GetFilter(0,0, filter, sort, extablesfilter, extablesfieldsfilter, extablesrelationsfilter, extablessort, extablesfieldssort, extablesrelationssort,generateUndo);
		}


		/// <summary>
		/// Returns the type for one property
		/// </summary>
		/// <param name="propertyname">Property's name for return its value</param>
		/// <returns>A value for the <paramref name="propertyname"/></returns>
		public Type GetMethodType( string propertyname,RutasCombustible rutascombustible)
		{
			// Perform the search for the property's value
			switch (propertyname)
			{
				case "lngIdRegistro":
					return rutascombustible.lngIdRegistro.GetType();

				case "strNombreGrupo":
					return rutascombustible.strNombreGrupo.GetType();

				case "cutCombustible":
					return rutascombustible.cutCombustible.GetType();

				case "TipoVehiculo":
					return rutascombustible.TipoVehiculo.GetType();

				case "DescripcionVehiculo":
					return rutascombustible.DescripcionVehiculo.GetType();

			}

			return null;
		}
		/// <summary>
		/// update the changes in RutasCombustible object by passing the object
		/// </summary>
		public bool UpdateChanges(RutasCombustible rutascombustible, out string error,Sinapsys.Datos.SQL datosTransaccion=null)
		{
			if (rutascombustible.OldRutasCombustible == null)
			{
				    error = "No tiene objeto con el cual comparar";
				    return false;
			}
			string[] Fields = rutascombustible.FieldChanged();
			error = "";
			return LiqViajes_Bll_Data.DataProvider.UpdateFieldsbyObject(Fields, rutascombustible, out error,datosTransaccion);
		}
	}

	#endregion

}
