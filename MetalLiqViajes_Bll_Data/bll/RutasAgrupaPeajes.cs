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
	#region RutasAgrupaPeajesController

	/// <summary>
	/// Class for convert data from database into object's data and vice versa
	/// </summary>
	public partial class RutasAgrupaPeajesController//: ILatinodeController
	{
		/// <summary>
		/// Generic Constructor
		/// </summary>
		public RutasAgrupaPeajesController()
		{
		}

		/// <summary>
		/// Instance accessor for this singleton
		/// </summary>
		private static RutasAgrupaPeajesController MySingleObj;
		public static RutasAgrupaPeajesController Instance
		{
			get
			{
				if (MySingleObj == null)
				{
					MySingleObj = new RutasAgrupaPeajesController();
				}
				return MySingleObj;
			}
		}

		// Reads object's data from a DataRow
		private void ReadData(RutasAgrupaPeajes rutasagrupapeajes, DataRow dr,bool generateUndo=false)
		{
			try 
			{
				rutasagrupapeajes.strNombreGrupo = dr.IsNull("strNombreGrupo") ? null :(string) dr["strNombreGrupo"];
				rutasagrupapeajes.lngIdGrupo = (int) dr["lngIdGrupo"];
			}
			catch (Exception ex)
			{
				Utilidades.LogErrores(ex.Message + (ex.InnerException != null ? ex.InnerException.Message : ""), DataProvider.AplicacionNombre);
				throw ex;
			}
			if (generateUndo) rutasagrupapeajes.GenerateUndo();
		}

		/// <summary>
		/// Create a new RutasAgrupaPeajes object by passing a object
		/// </summary>
		public RutasAgrupaPeajes Create(RutasAgrupaPeajes rutasagrupapeajes, Sinapsys.Datos.SQL datosTransaccion=null)
		{
			return Create(rutasagrupapeajes.lngIdGrupo,rutasagrupapeajes.strNombreGrupo,datosTransaccion);
		}

		/// <summary>
		/// Creates a new RutasAgrupaPeajes object by passing all object's fields
		/// </summary>
		/// <param name="strNombreGrupo">string that contents the strNombreGrupo value for the RutasAgrupaPeajes object</param>
		/// <returns>One RutasAgrupaPeajes object</returns>
		public RutasAgrupaPeajes Create(int lngIdGrupo, string strNombreGrupo, Sinapsys.Datos.SQL datosTransaccion=null)
		{
			try 
			{
				RutasAgrupaPeajes rutasagrupapeajes = new RutasAgrupaPeajes();

				rutasagrupapeajes.lngIdGrupo = lngIdGrupo;
				rutasagrupapeajes.lngIdGrupo = lngIdGrupo;
				rutasagrupapeajes.strNombreGrupo = strNombreGrupo;
				lngIdGrupo = RutasAgrupaPeajesDataProvider.Instance.Create(lngIdGrupo, strNombreGrupo,"RutasAgrupaPeajes",datosTransaccion);
				if (lngIdGrupo == 0)
					return null;

				rutasagrupapeajes.lngIdGrupo = lngIdGrupo;

				return rutasagrupapeajes;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Updates an RutasAgrupaPeajes object by passing all object's fields
		/// </summary>
		/// <param name="strNombreGrupo">string that contents the strNombreGrupo value for the RutasAgrupaPeajes object</param>
		/// <param name="lngIdGrupo">int that contents the lngIdGrupo value for the RutasAgrupaPeajes object</param>
		public void Update(string strNombreGrupo, int lngIdGrupo, Sinapsys.Datos.SQL datosTransaccion=null)
		{
			try 
			{
				RutasAgrupaPeajes new_values = new RutasAgrupaPeajes();
				new_values.strNombreGrupo = strNombreGrupo;
				RutasAgrupaPeajesDataProvider.Instance.Update(strNombreGrupo, lngIdGrupo,"RutasAgrupaPeajes",datosTransaccion);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Updates an RutasAgrupaPeajes object by passing one object's instance as reference
		/// </summary>
		/// <param name="rutasagrupapeajes">An instance of RutasAgrupaPeajes for reference</param>
		public void Update(RutasAgrupaPeajes rutasagrupapeajes,Sinapsys.Datos.SQL datosTransaccion=null)
		{
			Update(rutasagrupapeajes.strNombreGrupo, rutasagrupapeajes.lngIdGrupo);
		}

		/// <summary>
		/// Delete  the RutasAgrupaPeajes object by passing a object
		/// </summary>
		public void  Delete(RutasAgrupaPeajes rutasagrupapeajes, Sinapsys.Datos.SQL datosTransaccion=null)
		{
			Delete(rutasagrupapeajes.lngIdGrupo,datosTransaccion);
		}

		/// <summary>
		/// Deletes the RutasAgrupaPeajes object by passing one object's instance as reference
		/// </summary>
		/// <param name="rutasagrupapeajes">An instance of RutasAgrupaPeajes for reference</param>
		public void Delete(int lngIdGrupo, Sinapsys.Datos.SQL datosTransaccion=null)
		{
			try 
			{
				//RutasAgrupaPeajes old_values = RutasAgrupaPeajesController.Instance.Get(lngIdGrupo);
				//if(!Validate.security.CanDeleteSecurityField(RutasAgrupaPeajesController.Instance, (ILatinodeObject)old_values))
				//    throw new Exception("Access denied by security field, you can't delete object");

				RutasAgrupaPeajesDataProvider.Instance.Delete(lngIdGrupo,"RutasAgrupaPeajes");
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Deletes the RutasAgrupaPeajes object by passing CVS parameter as reference
		/// </summary>
		/// <param name="rutasagrupapeajes">An instance of RutasAgrupaPeajes for reference</param>
		public void Delete(string CVSParameter)
		{
			string[] StrCommand=CVSParameter.Split(',');
			try 
			{
				int lngIdGrupo=int.Parse(StrCommand[0]);
				RutasAgrupaPeajesDataProvider.Instance.Delete(lngIdGrupo,"RutasAgrupaPeajes");
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Gets the RutasAgrupaPeajes object by passing the object's key fields
		/// </summary>
		/// <param name="lngIdGrupo">int that contents the lngIdGrupo value for the RutasAgrupaPeajes object</param>
		/// <returns>One RutasAgrupaPeajes object</returns>
		public RutasAgrupaPeajes Get(int lngIdGrupo, bool generateUndo=false)
		{
			try 
			{
				RutasAgrupaPeajes rutasagrupapeajes = null;
				rutasagrupapeajes= MasterTables.RutasAgrupaPeajes.Where(r => r.lngIdGrupo== lngIdGrupo).FirstOrDefault();
				if (rutasagrupapeajes== null)
				{
					MasterTables.Reset("RutasAgrupaPeajes");
					rutasagrupapeajes= MasterTables.RutasAgrupaPeajes.Where(r => r.lngIdGrupo== lngIdGrupo).FirstOrDefault();
				}
				if (generateUndo) rutasagrupapeajes.GenerateUndo();

				return rutasagrupapeajes;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Gets all objects of RutasAgrupaPeajes
		/// </summary>
		/// <returns>One RutasAgrupaPeajesList object</returns>
		public RutasAgrupaPeajesList GetAll(bool generateUndo=false)
		{
			try 
			{
				RutasAgrupaPeajesList rutasagrupapeajeslist = new RutasAgrupaPeajesList();
				DataTable dt = RutasAgrupaPeajesDataProvider.Instance.GetAll();
				foreach (DataRow dr in dt.Rows)
				{
					RutasAgrupaPeajes rutasagrupapeajes = new RutasAgrupaPeajes();
					ReadData(rutasagrupapeajes, dr, generateUndo);
					rutasagrupapeajeslist.Add(rutasagrupapeajes);
				}
				return rutasagrupapeajeslist;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Gets all objects of RutasAgrupaPeajes applying filter and sort criteria
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
		/// <returns>One RutasAgrupaPeajesList object</returns>
		public RutasAgrupaPeajesList GetFilter(int pagenum, int pagesize, string filter, string sort, string extablesfilter, string extablesfieldsfilter, string extablesrelationsfilter, string extablessort, string extablesfieldssort, string extablesrelationssort, bool generateUndo=false)
		{
			try 
			{
				RutasAgrupaPeajesList rutasagrupapeajeslist = new RutasAgrupaPeajesList();

				DataTable dt = RutasAgrupaPeajesDataProvider.Instance.GetFilter(pagenum, pagesize, filter, sort, extablesfilter, extablesfieldsfilter, extablesrelationsfilter, extablessort, extablesfieldssort, extablesrelationssort);

				foreach (DataRow dr in dt.Rows)
				{
					RutasAgrupaPeajes rutasagrupapeajes = new RutasAgrupaPeajes();
					ReadData(rutasagrupapeajes, dr, generateUndo);
					rutasagrupapeajeslist.Add(rutasagrupapeajes);
				}
				return rutasagrupapeajeslist;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public RutasAgrupaPeajesList GetFilter( string filter, string sort, bool generateUndo=false)
		{
			return GetFilter(0,0, filter, sort, "","","","","","",generateUndo);
		}

		public RutasAgrupaPeajesList GetFilter(string filter, string sort, string extablesfilter, string extablesfieldsfilter, string extablesrelationsfilter, string extablessort, string extablesfieldssort, string extablesrelationssort, bool generateUndo=false)
		{
			return GetFilter(0,0, filter, sort, extablesfilter, extablesfieldsfilter, extablesrelationsfilter, extablessort, extablesfieldssort, extablesrelationssort,generateUndo);
		}


		/// <summary>
		/// Returns the type for one property
		/// </summary>
		/// <param name="propertyname">Property's name for return its value</param>
		/// <returns>A value for the <paramref name="propertyname"/></returns>
		public Type GetMethodType( string propertyname,RutasAgrupaPeajes rutasagrupapeajes)
		{
			// Perform the search for the property's value
			switch (propertyname)
			{
				case "strNombreGrupo":
					return rutasagrupapeajes.strNombreGrupo.GetType();

				case "lngIdGrupo":
					return rutasagrupapeajes.lngIdGrupo.GetType();

			}

			return null;
		}
		/// <summary>
		/// update the changes in RutasAgrupaPeajes object by passing the object
		/// </summary>
		public bool UpdateChanges(RutasAgrupaPeajes rutasagrupapeajes, out string error,Sinapsys.Datos.SQL datosTransaccion=null)
		{
			if (rutasagrupapeajes.OldRutasAgrupaPeajes == null)
			{
				    error = "No tiene objeto con el cual comparar";
				    return false;
			}
			string[] Fields = rutasagrupapeajes.FieldChanged();
			error = "";
			return LiqViajes_Bll_Data.DataProvider.UpdateFieldsbyObject(Fields, rutasagrupapeajes, out error,datosTransaccion);
		}
	}

	#endregion

}
