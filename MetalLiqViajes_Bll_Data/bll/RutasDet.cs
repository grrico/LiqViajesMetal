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
	#region RutasDetController

	/// <summary>
	/// Class for convert data from database into object's data and vice versa
	/// </summary>
	public partial class RutasDetController//: ILatinodeController
	{
		/// <summary>
		/// Generic Constructor
		/// </summary>
		public RutasDetController()
		{
		}

		/// <summary>
		/// Instance accessor for this singleton
		/// </summary>
		private static RutasDetController MySingleObj;
		public static RutasDetController Instance
		{
			get
			{
				if (MySingleObj == null)
				{
					MySingleObj = new RutasDetController();
				}
				return MySingleObj;
			}
		}

		// Reads object's data from a DataRow
		private void ReadData(RutasDet rutasdet, DataRow dr,bool generateUndo=false)
		{
			try 
			{
				rutasdet.lngIdItemdReg = (long) dr["lngIdItemdReg"];
				rutasdet.lngIdRegistrRuta = (long) dr["lngIdRegistrRuta"];
				rutasdet.lngIdPeaje = (long) dr["lngIdPeaje"];
				rutasdet.strNombrePeaje = dr.IsNull("strNombrePeaje") ? null :(string) dr["strNombrePeaje"];
				rutasdet.curValorPeaje = dr.IsNull("curValorPeaje") ? null :(decimal?) dr["curValorPeaje"];
			}
			catch (Exception ex)
			{
				Utilidades.LogErrores(ex.Message + (ex.InnerException != null ? ex.InnerException.Message : ""), DataProvider.AplicacionNombre);
				throw ex;
			}
			if (generateUndo) rutasdet.GenerateUndo();
		}

		/// <summary>
		/// Create a new RutasDet object by passing a object
		/// </summary>
		public RutasDet Create(RutasDet rutasdet, Sinapsys.Datos.SQL datosTransaccion=null)
		{
			return Create(rutasdet.lngIdItemdReg,rutasdet.lngIdRegistrRuta,rutasdet.lngIdPeaje,rutasdet.strNombrePeaje,rutasdet.curValorPeaje,datosTransaccion);
		}

		/// <summary>
		/// Creates a new RutasDet object by passing all object's fields
		/// </summary>
		/// <param name="strNombrePeaje">string that contents the strNombrePeaje value for the RutasDet object</param>
		/// <param name="curValorPeaje">decimal that contents the curValorPeaje value for the RutasDet object</param>
		/// <returns>One RutasDet object</returns>
		public RutasDet Create(long lngIdItemdReg, long lngIdRegistrRuta, long lngIdPeaje, string strNombrePeaje, decimal? curValorPeaje, Sinapsys.Datos.SQL datosTransaccion=null)
		{
			try 
			{
				RutasDet rutasdet = new RutasDet();

				rutasdet.lngIdItemdReg = lngIdItemdReg;
				rutasdet.lngIdItemdReg = lngIdItemdReg;
				rutasdet.lngIdRegistrRuta = lngIdRegistrRuta;
				rutasdet.lngIdPeaje = lngIdPeaje;
				rutasdet.strNombrePeaje = strNombrePeaje;
				rutasdet.curValorPeaje = curValorPeaje;
				lngIdItemdReg = RutasDetDataProvider.Instance.Create(lngIdItemdReg, lngIdRegistrRuta, lngIdPeaje, strNombrePeaje, curValorPeaje,"RutasDet",datosTransaccion);
				if (lngIdItemdReg == 0)
					return null;

				rutasdet.lngIdItemdReg = lngIdItemdReg;

				return rutasdet;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Updates an RutasDet object by passing all object's fields
		/// </summary>
		/// <param name="lngIdItemdReg">long that contents the lngIdItemdReg value for the RutasDet object</param>
		/// <param name="lngIdRegistrRuta">long that contents the lngIdRegistrRuta value for the RutasDet object</param>
		/// <param name="lngIdPeaje">long that contents the lngIdPeaje value for the RutasDet object</param>
		/// <param name="strNombrePeaje">string that contents the strNombrePeaje value for the RutasDet object</param>
		/// <param name="curValorPeaje">decimal that contents the curValorPeaje value for the RutasDet object</param>
		public void Update(long lngIdItemdReg, long lngIdRegistrRuta, long lngIdPeaje, string strNombrePeaje, decimal? curValorPeaje, Sinapsys.Datos.SQL datosTransaccion=null)
		{
			try 
			{
				RutasDet new_values = new RutasDet();
				new_values.strNombrePeaje = strNombrePeaje;
				new_values.curValorPeaje = curValorPeaje;
				RutasDetDataProvider.Instance.Update(lngIdItemdReg, lngIdRegistrRuta, lngIdPeaje, strNombrePeaje, curValorPeaje,"RutasDet",datosTransaccion);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Updates an RutasDet object by passing one object's instance as reference
		/// </summary>
		/// <param name="rutasdet">An instance of RutasDet for reference</param>
		public void Update(RutasDet rutasdet,Sinapsys.Datos.SQL datosTransaccion=null)
		{
			Update(rutasdet.lngIdItemdReg, rutasdet.lngIdRegistrRuta, rutasdet.lngIdPeaje, rutasdet.strNombrePeaje, rutasdet.curValorPeaje);
		}

		/// <summary>
		/// Delete  the RutasDet object by passing a object
		/// </summary>
		public void  Delete(RutasDet rutasdet, Sinapsys.Datos.SQL datosTransaccion=null)
		{
			Delete(rutasdet.lngIdItemdReg, rutasdet.lngIdRegistrRuta, rutasdet.lngIdPeaje,datosTransaccion);
		}

		/// <summary>
		/// Deletes the RutasDet object by passing one object's instance as reference
		/// </summary>
		/// <param name="rutasdet">An instance of RutasDet for reference</param>
		public void Delete(long lngIdItemdReg, long lngIdRegistrRuta, long lngIdPeaje, Sinapsys.Datos.SQL datosTransaccion=null)
		{
			try 
			{
				//RutasDet old_values = RutasDetController.Instance.Get(lngIdItemdReg);
				//if(!Validate.security.CanDeleteSecurityField(RutasDetController.Instance, (ILatinodeObject)old_values))
				//    throw new Exception("Access denied by security field, you can't delete object");

				RutasDetDataProvider.Instance.Delete(lngIdItemdReg, lngIdRegistrRuta, lngIdPeaje,"RutasDet");
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Deletes the RutasDet object by passing CVS parameter as reference
		/// </summary>
		/// <param name="rutasdet">An instance of RutasDet for reference</param>
		public void Delete(string CVSParameter)
		{
			string[] StrCommand=CVSParameter.Split(',');
			try 
			{
				long lngIdItemdReg=long.Parse(StrCommand[0]);
				long lngIdRegistrRuta=long.Parse(StrCommand[1]);
				long lngIdPeaje=long.Parse(StrCommand[2]);
				RutasDetDataProvider.Instance.Delete(lngIdItemdReg, lngIdRegistrRuta, lngIdPeaje,"RutasDet");
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Gets the RutasDet object by passing the object's key fields
		/// </summary>
		/// <param name="lngIdItemdReg">long that contents the lngIdItemdReg value for the RutasDet object</param>
		/// <param name="lngIdRegistrRuta">long that contents the lngIdRegistrRuta value for the RutasDet object</param>
		/// <param name="lngIdPeaje">long that contents the lngIdPeaje value for the RutasDet object</param>
		/// <returns>One RutasDet object</returns>
		public RutasDet Get(long lngIdItemdReg, long lngIdRegistrRuta, long lngIdPeaje, bool generateUndo=false)
		{
			try 
			{
				RutasDet rutasdet = null;
				DataTable dt = RutasDetDataProvider.Instance.Get(lngIdItemdReg, lngIdRegistrRuta, lngIdPeaje);
				if ((dt.Rows.Count > 0))
				{
					rutasdet = new RutasDet();
					DataRow dr = dt.Rows[0];
					ReadData(rutasdet, dr, generateUndo);
				}


				return rutasdet;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Gets all objects of RutasDet
		/// </summary>
		/// <returns>One RutasDetList object</returns>
		public RutasDetList GetAll(bool generateUndo=false)
		{
			try 
			{
				RutasDetList rutasdetlist = new RutasDetList();
				DataTable dt = RutasDetDataProvider.Instance.GetAll();
				foreach (DataRow dr in dt.Rows)
				{
					RutasDet rutasdet = new RutasDet();
					ReadData(rutasdet, dr, generateUndo);
					rutasdetlist.Add(rutasdet);
				}
				return rutasdetlist;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Gets all objects of RutasDet applying filter and sort criteria
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
		/// <returns>One RutasDetList object</returns>
		public RutasDetList GetFilter(int pagenum, int pagesize, string filter, string sort, string extablesfilter, string extablesfieldsfilter, string extablesrelationsfilter, string extablessort, string extablesfieldssort, string extablesrelationssort, bool generateUndo=false)
		{
			try 
			{
				RutasDetList rutasdetlist = new RutasDetList();

				DataTable dt = RutasDetDataProvider.Instance.GetFilter(pagenum, pagesize, filter, sort, extablesfilter, extablesfieldsfilter, extablesrelationsfilter, extablessort, extablesfieldssort, extablesrelationssort);

				foreach (DataRow dr in dt.Rows)
				{
					RutasDet rutasdet = new RutasDet();
					ReadData(rutasdet, dr, generateUndo);
					rutasdetlist.Add(rutasdet);
				}
				return rutasdetlist;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public RutasDetList GetFilter( string filter, string sort, bool generateUndo=false)
		{
			return GetFilter(0,0, filter, sort, "","","","","","",generateUndo);
		}

		public RutasDetList GetFilter(string filter, string sort, string extablesfilter, string extablesfieldsfilter, string extablesrelationsfilter, string extablessort, string extablesfieldssort, string extablesrelationssort, bool generateUndo=false)
		{
			return GetFilter(0,0, filter, sort, extablesfilter, extablesfieldsfilter, extablesrelationsfilter, extablessort, extablesfieldssort, extablesrelationssort,generateUndo);
		}


		/// <summary>
		/// Returns the type for one property
		/// </summary>
		/// <param name="propertyname">Property's name for return its value</param>
		/// <returns>A value for the <paramref name="propertyname"/></returns>
		public Type GetMethodType( string propertyname,RutasDet rutasdet)
		{
			// Perform the search for the property's value
			switch (propertyname)
			{
				case "lngIdItemdReg":
					return rutasdet.lngIdItemdReg.GetType();

				case "lngIdRegistrRuta":
					return rutasdet.lngIdRegistrRuta.GetType();

				case "lngIdPeaje":
					return rutasdet.lngIdPeaje.GetType();

				case "strNombrePeaje":
					return rutasdet.strNombrePeaje.GetType();

				case "curValorPeaje":
					return rutasdet.curValorPeaje.GetType();

			}

			return null;
		}
		/// <summary>
		/// update the changes in RutasDet object by passing the object
		/// </summary>
		public bool UpdateChanges(RutasDet rutasdet, out string error,Sinapsys.Datos.SQL datosTransaccion=null)
		{
			if (rutasdet.OldRutasDet == null)
			{
				    error = "No tiene objeto con el cual comparar";
				    return false;
			}
			string[] Fields = rutasdet.FieldChanged();
			error = "";
			return LiqViajes_Bll_Data.DataProvider.UpdateFieldsbyObject(Fields, rutasdet, out error,datosTransaccion);
		}
	}

	#endregion

}
