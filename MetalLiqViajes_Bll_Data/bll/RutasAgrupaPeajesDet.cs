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
	#region RutasAgrupaPeajesDetController

	/// <summary>
	/// Class for convert data from database into object's data and vice versa
	/// </summary>
	public partial class RutasAgrupaPeajesDetController//: ILatinodeController
	{
		/// <summary>
		/// Generic Constructor
		/// </summary>
		public RutasAgrupaPeajesDetController()
		{
		}

		/// <summary>
		/// Instance accessor for this singleton
		/// </summary>
		private static RutasAgrupaPeajesDetController MySingleObj;
		public static RutasAgrupaPeajesDetController Instance
		{
			get
			{
				if (MySingleObj == null)
				{
					MySingleObj = new RutasAgrupaPeajesDetController();
				}
				return MySingleObj;
			}
		}

		// Reads object's data from a DataRow
		private void ReadData(RutasAgrupaPeajesDet rutasagrupapeajesdet, DataRow dr,bool generateUndo=false)
		{
			try 
			{
				rutasagrupapeajesdet.lngIdGrupo = (int) dr["lngIdGrupo"];
				rutasagrupapeajesdet.lngIdPeaje = (int) dr["lngIdPeaje"];
				rutasagrupapeajesdet.intSecuencia = dr.IsNull("intSecuencia") ? null :(int?) dr["intSecuencia"];
			}
			catch (Exception ex)
			{
				Utilidades.LogErrores(ex.Message + (ex.InnerException != null ? ex.InnerException.Message : ""), DataProvider.AplicacionNombre);
				throw ex;
			}
			if (generateUndo) rutasagrupapeajesdet.GenerateUndo();
		}

		/// <summary>
		/// Create a new RutasAgrupaPeajesDet object by passing a object
		/// </summary>
		public RutasAgrupaPeajesDet Create(RutasAgrupaPeajesDet rutasagrupapeajesdet, Sinapsys.Datos.SQL datosTransaccion=null)
		{
			return Create(rutasagrupapeajesdet.lngIdGrupo,rutasagrupapeajesdet.lngIdPeaje,rutasagrupapeajesdet.intSecuencia,datosTransaccion);
		}

		/// <summary>
		/// Creates a new RutasAgrupaPeajesDet object by passing all object's fields
		/// </summary>
		/// <param name="intSecuencia">int that contents the intSecuencia value for the RutasAgrupaPeajesDet object</param>
		/// <returns>One RutasAgrupaPeajesDet object</returns>
		public RutasAgrupaPeajesDet Create(int lngIdGrupo, int lngIdPeaje, int? intSecuencia, Sinapsys.Datos.SQL datosTransaccion=null)
		{
			try 
			{
				RutasAgrupaPeajesDet rutasagrupapeajesdet = new RutasAgrupaPeajesDet();

				rutasagrupapeajesdet.lngIdGrupo = lngIdGrupo;
				rutasagrupapeajesdet.lngIdPeaje = lngIdPeaje;
				rutasagrupapeajesdet.intSecuencia = intSecuencia;
				RutasAgrupaPeajesDetDataProvider.Instance.Create(lngIdGrupo, lngIdPeaje, intSecuencia,"RutasAgrupaPeajesDet");

				return rutasagrupapeajesdet;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Updates an RutasAgrupaPeajesDet object by passing all object's fields
		/// </summary>
		/// <param name="lngIdGrupo">int that contents the lngIdGrupo value for the RutasAgrupaPeajesDet object</param>
		/// <param name="lngIdPeaje">int that contents the lngIdPeaje value for the RutasAgrupaPeajesDet object</param>
		/// <param name="intSecuencia">int that contents the intSecuencia value for the RutasAgrupaPeajesDet object</param>
		public void Update(int lngIdGrupo, int lngIdPeaje, int? intSecuencia, Sinapsys.Datos.SQL datosTransaccion=null)
		{
			try 
			{
				RutasAgrupaPeajesDet new_values = new RutasAgrupaPeajesDet();
				new_values.intSecuencia = intSecuencia;
				RutasAgrupaPeajesDetDataProvider.Instance.Update(lngIdGrupo, lngIdPeaje, intSecuencia,"RutasAgrupaPeajesDet",datosTransaccion);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Updates an RutasAgrupaPeajesDet object by passing one object's instance as reference
		/// </summary>
		/// <param name="rutasagrupapeajesdet">An instance of RutasAgrupaPeajesDet for reference</param>
		public void Update(RutasAgrupaPeajesDet rutasagrupapeajesdet,Sinapsys.Datos.SQL datosTransaccion=null)
		{
			Update(rutasagrupapeajesdet.lngIdGrupo, rutasagrupapeajesdet.lngIdPeaje, rutasagrupapeajesdet.intSecuencia);
		}

		/// <summary>
		/// Delete  the RutasAgrupaPeajesDet object by passing a object
		/// </summary>
		public void  Delete(RutasAgrupaPeajesDet rutasagrupapeajesdet, Sinapsys.Datos.SQL datosTransaccion=null)
		{
			Delete(rutasagrupapeajesdet.lngIdGrupo, rutasagrupapeajesdet.lngIdPeaje,datosTransaccion);
		}

		/// <summary>
		/// Deletes the RutasAgrupaPeajesDet object by passing one object's instance as reference
		/// </summary>
		/// <param name="rutasagrupapeajesdet">An instance of RutasAgrupaPeajesDet for reference</param>
		public void Delete(int lngIdGrupo, int lngIdPeaje, Sinapsys.Datos.SQL datosTransaccion=null)
		{
			try 
			{
				RutasAgrupaPeajesDetDataProvider.Instance.Delete(lngIdGrupo, lngIdPeaje,"RutasAgrupaPeajesDet");
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Deletes the RutasAgrupaPeajesDet object by passing CVS parameter as reference
		/// </summary>
		/// <param name="rutasagrupapeajesdet">An instance of RutasAgrupaPeajesDet for reference</param>
		public void Delete(string CVSParameter)
		{
			string[] StrCommand=CVSParameter.Split(',');
			try 
			{
				int lngIdGrupo=int.Parse(StrCommand[0]);
				int lngIdPeaje=int.Parse(StrCommand[1]);
				RutasAgrupaPeajesDetDataProvider.Instance.Delete(lngIdGrupo, lngIdPeaje,"RutasAgrupaPeajesDet");
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Gets the RutasAgrupaPeajesDet object by passing the object's key fields
		/// </summary>
		/// <param name="lngIdGrupo">int that contents the lngIdGrupo value for the RutasAgrupaPeajesDet object</param>
		/// <param name="lngIdPeaje">int that contents the lngIdPeaje value for the RutasAgrupaPeajesDet object</param>
		/// <returns>One RutasAgrupaPeajesDet object</returns>
		public RutasAgrupaPeajesDet Get(int lngIdGrupo, int lngIdPeaje, bool generateUndo=false)
		{
			try 
			{
				RutasAgrupaPeajesDet rutasagrupapeajesdet = null;
				DataTable dt = RutasAgrupaPeajesDetDataProvider.Instance.Get(lngIdGrupo, lngIdPeaje);
				if ((dt.Rows.Count > 0))
				{
					rutasagrupapeajesdet = new RutasAgrupaPeajesDet();
					DataRow dr = dt.Rows[0];
					ReadData(rutasagrupapeajesdet, dr, generateUndo);
				}


				return rutasagrupapeajesdet;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Gets all objects of RutasAgrupaPeajesDet
		/// </summary>
		/// <returns>One RutasAgrupaPeajesDetList object</returns>
		public RutasAgrupaPeajesDetList GetAll(bool generateUndo=false)
		{
			try 
			{
				RutasAgrupaPeajesDetList rutasagrupapeajesdetlist = new RutasAgrupaPeajesDetList();
				DataTable dt = RutasAgrupaPeajesDetDataProvider.Instance.GetAll();
				foreach (DataRow dr in dt.Rows)
				{
					RutasAgrupaPeajesDet rutasagrupapeajesdet = new RutasAgrupaPeajesDet();
					ReadData(rutasagrupapeajesdet, dr, generateUndo);
					rutasagrupapeajesdetlist.Add(rutasagrupapeajesdet);
				}
				return rutasagrupapeajesdetlist;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Gets all objects of RutasAgrupaPeajesDet applying filter and sort criteria
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
		/// <returns>One RutasAgrupaPeajesDetList object</returns>
		public RutasAgrupaPeajesDetList GetFilter(int pagenum, int pagesize, string filter, string sort, string extablesfilter, string extablesfieldsfilter, string extablesrelationsfilter, string extablessort, string extablesfieldssort, string extablesrelationssort, bool generateUndo=false)
		{
			try 
			{
				RutasAgrupaPeajesDetList rutasagrupapeajesdetlist = new RutasAgrupaPeajesDetList();

				DataTable dt = RutasAgrupaPeajesDetDataProvider.Instance.GetFilter(pagenum, pagesize, filter, sort, extablesfilter, extablesfieldsfilter, extablesrelationsfilter, extablessort, extablesfieldssort, extablesrelationssort);

				foreach (DataRow dr in dt.Rows)
				{
					RutasAgrupaPeajesDet rutasagrupapeajesdet = new RutasAgrupaPeajesDet();
					ReadData(rutasagrupapeajesdet, dr, generateUndo);
					rutasagrupapeajesdetlist.Add(rutasagrupapeajesdet);
				}
				return rutasagrupapeajesdetlist;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public RutasAgrupaPeajesDetList GetFilter( string filter, string sort, bool generateUndo=false)
		{
			return GetFilter(0,0, filter, sort, "","","","","","",generateUndo);
		}

		public RutasAgrupaPeajesDetList GetFilter(string filter, string sort, string extablesfilter, string extablesfieldsfilter, string extablesrelationsfilter, string extablessort, string extablesfieldssort, string extablesrelationssort, bool generateUndo=false)
		{
			return GetFilter(0,0, filter, sort, extablesfilter, extablesfieldsfilter, extablesrelationsfilter, extablessort, extablesfieldssort, extablesrelationssort,generateUndo);
		}


		/// <summary>
		/// Returns the type for one property
		/// </summary>
		/// <param name="propertyname">Property's name for return its value</param>
		/// <returns>A value for the <paramref name="propertyname"/></returns>
		public Type GetMethodType( string propertyname,RutasAgrupaPeajesDet rutasagrupapeajesdet)
		{
			// Perform the search for the property's value
			switch (propertyname)
			{
				case "lngIdGrupo":
					return rutasagrupapeajesdet.lngIdGrupo.GetType();

				case "lngIdPeaje":
					return rutasagrupapeajesdet.lngIdPeaje.GetType();

				case "intSecuencia":
					return rutasagrupapeajesdet.intSecuencia.GetType();

			}

			return null;
		}
		/// <summary>
		/// update the changes in RutasAgrupaPeajesDet object by passing the object
		/// </summary>
		public bool UpdateChanges(RutasAgrupaPeajesDet rutasagrupapeajesdet, out string error,Sinapsys.Datos.SQL datosTransaccion=null)
		{
			if (rutasagrupapeajesdet.OldRutasAgrupaPeajesDet == null)
			{
				    error = "No tiene objeto con el cual comparar";
				    return false;
			}
			string[] Fields = rutasagrupapeajesdet.FieldChanged();
			error = "";
			return LiqViajes_Bll_Data.DataProvider.UpdateFieldsbyObject(Fields, rutasagrupapeajesdet, out error,datosTransaccion);
		}
	}

	#endregion

}
