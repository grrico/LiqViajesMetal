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
	#region RutasOrigenController

	/// <summary>
	/// Class for convert data from database into object's data and vice versa
	/// </summary>
	public partial class RutasOrigenController//: ILatinodeController
	{
		/// <summary>
		/// Generic Constructor
		/// </summary>
		public RutasOrigenController()
		{
		}

		/// <summary>
		/// Instance accessor for this singleton
		/// </summary>
		private static RutasOrigenController MySingleObj;
		public static RutasOrigenController Instance
		{
			get
			{
				if (MySingleObj == null)
				{
					MySingleObj = new RutasOrigenController();
				}
				return MySingleObj;
			}
		}

		// Reads object's data from a DataRow
		private void ReadData(RutasOrigen rutasorigen, DataRow dr,bool generateUndo=false)
		{
			try 
			{
				rutasorigen.Codigo = (long) dr["Codigo"];
				rutasorigen.Origen = dr.IsNull("Origen") ? null :(string) dr["Origen"];
				rutasorigen.Favorita = dr.IsNull("Favorita") ? null :(bool?) dr["Favorita"];
			}
			catch (Exception ex)
			{
				Utilidades.LogErrores(ex.Message + (ex.InnerException != null ? ex.InnerException.Message : ""), DataProvider.AplicacionNombre);
				throw ex;
			}
			if (generateUndo) rutasorigen.GenerateUndo();
		}

		/// <summary>
		/// Create a new RutasOrigen object by passing a object
		/// </summary>
		public RutasOrigen Create(RutasOrigen rutasorigen, Sinapsys.Datos.SQL datosTransaccion=null)
		{
			return Create(rutasorigen.Codigo,rutasorigen.Origen,rutasorigen.Favorita,datosTransaccion);
		}

		/// <summary>
		/// Creates a new RutasOrigen object by passing all object's fields
		/// </summary>
		/// <param name="Origen">string that contents the Origen value for the RutasOrigen object</param>
		/// <param name="Favorita">bool that contents the Favorita value for the RutasOrigen object</param>
		/// <returns>One RutasOrigen object</returns>
		public RutasOrigen Create(long Codigo, string Origen, bool? Favorita, Sinapsys.Datos.SQL datosTransaccion=null)
		{
			try 
			{
				RutasOrigen rutasorigen = new RutasOrigen();

				rutasorigen.Codigo = Codigo;
				rutasorigen.Codigo = Codigo;
				rutasorigen.Origen = Origen;
				rutasorigen.Favorita = Favorita;
				Codigo = RutasOrigenDataProvider.Instance.Create(Codigo, Origen, Favorita,"RutasOrigen",datosTransaccion);
				if (Codigo == 0)
					return null;

				rutasorigen.Codigo = Codigo;

				return rutasorigen;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Updates an RutasOrigen object by passing all object's fields
		/// </summary>
		/// <param name="Codigo">long that contents the Codigo value for the RutasOrigen object</param>
		/// <param name="Origen">string that contents the Origen value for the RutasOrigen object</param>
		/// <param name="Favorita">bool that contents the Favorita value for the RutasOrigen object</param>
		public void Update(long Codigo, string Origen, bool? Favorita, Sinapsys.Datos.SQL datosTransaccion=null)
		{
			try 
			{
				RutasOrigen new_values = new RutasOrigen();
				new_values.Origen = Origen;
				new_values.Favorita = Favorita;
				RutasOrigenDataProvider.Instance.Update(Codigo, Origen, Favorita,"RutasOrigen",datosTransaccion);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Updates an RutasOrigen object by passing one object's instance as reference
		/// </summary>
		/// <param name="rutasorigen">An instance of RutasOrigen for reference</param>
		public void Update(RutasOrigen rutasorigen,Sinapsys.Datos.SQL datosTransaccion=null)
		{
			Update(rutasorigen.Codigo, rutasorigen.Origen, rutasorigen.Favorita);
		}

		/// <summary>
		/// Delete  the RutasOrigen object by passing a object
		/// </summary>
		public void  Delete(RutasOrigen rutasorigen, Sinapsys.Datos.SQL datosTransaccion=null)
		{
			Delete(rutasorigen.Codigo,datosTransaccion);
		}

		/// <summary>
		/// Deletes the RutasOrigen object by passing one object's instance as reference
		/// </summary>
		/// <param name="rutasorigen">An instance of RutasOrigen for reference</param>
		public void Delete(long Codigo, Sinapsys.Datos.SQL datosTransaccion=null)
		{
			try 
			{
				//RutasOrigen old_values = RutasOrigenController.Instance.Get(Codigo);
				//if(!Validate.security.CanDeleteSecurityField(RutasOrigenController.Instance, (ILatinodeObject)old_values))
				//    throw new Exception("Access denied by security field, you can't delete object");

				RutasOrigenDataProvider.Instance.Delete(Codigo,"RutasOrigen");
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Deletes the RutasOrigen object by passing CVS parameter as reference
		/// </summary>
		/// <param name="rutasorigen">An instance of RutasOrigen for reference</param>
		public void Delete(string CVSParameter)
		{
			string[] StrCommand=CVSParameter.Split(',');
			try 
			{
				long Codigo=long.Parse(StrCommand[0]);
				RutasOrigenDataProvider.Instance.Delete(Codigo,"RutasOrigen");
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Gets the RutasOrigen object by passing the object's key fields
		/// </summary>
		/// <param name="Codigo">long that contents the Codigo value for the RutasOrigen object</param>
		/// <returns>One RutasOrigen object</returns>
		public RutasOrigen Get(long Codigo, bool generateUndo=false)
		{
			try 
			{
				RutasOrigen rutasorigen = null;
				DataTable dt = RutasOrigenDataProvider.Instance.Get(Codigo);
				if ((dt.Rows.Count > 0))
				{
					rutasorigen = new RutasOrigen();
					DataRow dr = dt.Rows[0];
					ReadData(rutasorigen, dr, generateUndo);
				}


				return rutasorigen;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Gets all objects of RutasOrigen
		/// </summary>
		/// <returns>One RutasOrigenList object</returns>
		public RutasOrigenList GetAll(bool generateUndo=false)
		{
			try 
			{
				RutasOrigenList rutasorigenlist = new RutasOrigenList();
				DataTable dt = RutasOrigenDataProvider.Instance.GetAll();
				foreach (DataRow dr in dt.Rows)
				{
					RutasOrigen rutasorigen = new RutasOrigen();
					ReadData(rutasorigen, dr, generateUndo);
					rutasorigenlist.Add(rutasorigen);
				}
				return rutasorigenlist;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Gets all objects of RutasOrigen applying filter and sort criteria
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
		/// <returns>One RutasOrigenList object</returns>
		public RutasOrigenList GetFilter(int pagenum, int pagesize, string filter, string sort, string extablesfilter, string extablesfieldsfilter, string extablesrelationsfilter, string extablessort, string extablesfieldssort, string extablesrelationssort, bool generateUndo=false)
		{
			try 
			{
				RutasOrigenList rutasorigenlist = new RutasOrigenList();

				DataTable dt = RutasOrigenDataProvider.Instance.GetFilter(pagenum, pagesize, filter, sort, extablesfilter, extablesfieldsfilter, extablesrelationsfilter, extablessort, extablesfieldssort, extablesrelationssort);

				foreach (DataRow dr in dt.Rows)
				{
					RutasOrigen rutasorigen = new RutasOrigen();
					ReadData(rutasorigen, dr, generateUndo);
					rutasorigenlist.Add(rutasorigen);
				}
				return rutasorigenlist;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public RutasOrigenList GetFilter( string filter, string sort, bool generateUndo=false)
		{
			return GetFilter(0,0, filter, sort, "","","","","","",generateUndo);
		}

		public RutasOrigenList GetFilter(string filter, string sort, string extablesfilter, string extablesfieldsfilter, string extablesrelationsfilter, string extablessort, string extablesfieldssort, string extablesrelationssort, bool generateUndo=false)
		{
			return GetFilter(0,0, filter, sort, extablesfilter, extablesfieldsfilter, extablesrelationsfilter, extablessort, extablesfieldssort, extablesrelationssort,generateUndo);
		}


		/// <summary>
		/// Returns the type for one property
		/// </summary>
		/// <param name="propertyname">Property's name for return its value</param>
		/// <returns>A value for the <paramref name="propertyname"/></returns>
		public Type GetMethodType( string propertyname,RutasOrigen rutasorigen)
		{
			// Perform the search for the property's value
			switch (propertyname)
			{
				case "Codigo":
					return rutasorigen.Codigo.GetType();

				case "Origen":
					return rutasorigen.Origen.GetType();

				case "Favorita":
					return rutasorigen.Favorita.GetType();

			}

			return null;
		}
		/// <summary>
		/// update the changes in RutasOrigen object by passing the object
		/// </summary>
		public bool UpdateChanges(RutasOrigen rutasorigen, out string error,Sinapsys.Datos.SQL datosTransaccion=null)
		{
			if (rutasorigen.OldRutasOrigen == null)
			{
				    error = "No tiene objeto con el cual comparar";
				    return false;
			}
			string[] Fields = rutasorigen.FieldChanged();
			error = "";
			return LiqViajes_Bll_Data.DataProvider.UpdateFieldsbyObject(Fields, rutasorigen, out error,datosTransaccion);
		}
	}

	#endregion

}
