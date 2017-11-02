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
	#region LiquidacionPlanillaDetController

	/// <summary>
	/// Class for convert data from database into object's data and vice versa
	/// </summary>
	public partial class LiquidacionPlanillaDetController//: ILatinodeController
	{
		/// <summary>
		/// Generic Constructor
		/// </summary>
		public LiquidacionPlanillaDetController()
		{
		}

		/// <summary>
		/// Instance accessor for this singleton
		/// </summary>
		private static LiquidacionPlanillaDetController MySingleObj;
		public static LiquidacionPlanillaDetController Instance
		{
			get
			{
				if (MySingleObj == null)
				{
					MySingleObj = new LiquidacionPlanillaDetController();
				}
				return MySingleObj;
			}
		}

		// Reads object's data from a DataRow
		private void ReadData(LiquidacionPlanillaDet liquidacionplanilladet, DataRow dr,bool generateUndo=false)
		{
			try 
			{
				liquidacionplanilladet.lngIdItemd = (int) dr["lngIdItemd"];
				liquidacionplanilladet.lngIdRegistro = dr.IsNull("lngIdRegistro") ? null :(int?) dr["lngIdRegistro"];
				liquidacionplanilladet.lngIdRegistrRuta = dr.IsNull("lngIdRegistrRuta") ? null :(int?) dr["lngIdRegistrRuta"];
				liquidacionplanilladet.lngIdRegistrRutaItemId = dr.IsNull("lngIdRegistrRutaItemId") ? null :(int?) dr["lngIdRegistrRutaItemId"];
				liquidacionplanilladet.strNoPlanilla = dr.IsNull("strNoPlanilla") ? null :(string) dr["strNoPlanilla"];
				liquidacionplanilladet.dtmFechaModif = dr.IsNull("dtmFechaModif") ? null :(DateTime?) dr["dtmFechaModif"];
			}
			catch (Exception ex)
			{
				Utilidades.LogErrores(ex.Message + (ex.InnerException != null ? ex.InnerException.Message : ""), DataProvider.AplicacionNombre);
				throw ex;
			}
			if (generateUndo) liquidacionplanilladet.GenerateUndo();
		}

		/// <summary>
		/// Create a new LiquidacionPlanillaDet object by passing a object
		/// </summary>
		public LiquidacionPlanillaDet Create(LiquidacionPlanillaDet liquidacionplanilladet, Sinapsys.Datos.SQL datosTransaccion=null)
		{
			return Create(liquidacionplanilladet.lngIdItemd,liquidacionplanilladet.lngIdRegistro,liquidacionplanilladet.lngIdRegistrRuta,liquidacionplanilladet.lngIdRegistrRutaItemId,liquidacionplanilladet.strNoPlanilla,liquidacionplanilladet.dtmFechaModif,datosTransaccion);
		}

		/// <summary>
		/// Creates a new LiquidacionPlanillaDet object by passing all object's fields
		/// </summary>
		/// <param name="lngIdRegistro">int that contents the lngIdRegistro value for the LiquidacionPlanillaDet object</param>
		/// <param name="lngIdRegistrRuta">int that contents the lngIdRegistrRuta value for the LiquidacionPlanillaDet object</param>
		/// <param name="lngIdRegistrRutaItemId">int that contents the lngIdRegistrRutaItemId value for the LiquidacionPlanillaDet object</param>
		/// <param name="strNoPlanilla">string that contents the strNoPlanilla value for the LiquidacionPlanillaDet object</param>
		/// <param name="dtmFechaModif">DateTime that contents the dtmFechaModif value for the LiquidacionPlanillaDet object</param>
		/// <returns>One LiquidacionPlanillaDet object</returns>
		public LiquidacionPlanillaDet Create(int lngIdItemd, int? lngIdRegistro, int? lngIdRegistrRuta, int? lngIdRegistrRutaItemId, string strNoPlanilla, DateTime? dtmFechaModif, Sinapsys.Datos.SQL datosTransaccion=null)
		{
			try 
			{
				LiquidacionPlanillaDet liquidacionplanilladet = new LiquidacionPlanillaDet();

				liquidacionplanilladet.lngIdItemd = lngIdItemd;
				liquidacionplanilladet.lngIdItemd = lngIdItemd;
				liquidacionplanilladet.lngIdRegistro = lngIdRegistro;
				liquidacionplanilladet.lngIdRegistrRuta = lngIdRegistrRuta;
				liquidacionplanilladet.lngIdRegistrRutaItemId = lngIdRegistrRutaItemId;
				liquidacionplanilladet.strNoPlanilla = strNoPlanilla;
				liquidacionplanilladet.dtmFechaModif = dtmFechaModif;
				lngIdItemd = LiquidacionPlanillaDetDataProvider.Instance.Create(lngIdItemd, lngIdRegistro, lngIdRegistrRuta, lngIdRegistrRutaItemId, strNoPlanilla, dtmFechaModif,"LiquidacionPlanillaDet",datosTransaccion);
				if (lngIdItemd == 0)
					return null;

				liquidacionplanilladet.lngIdItemd = lngIdItemd;

				return liquidacionplanilladet;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Updates an LiquidacionPlanillaDet object by passing all object's fields
		/// </summary>
		/// <param name="lngIdItemd">int that contents the lngIdItemd value for the LiquidacionPlanillaDet object</param>
		/// <param name="lngIdRegistro">int that contents the lngIdRegistro value for the LiquidacionPlanillaDet object</param>
		/// <param name="lngIdRegistrRuta">int that contents the lngIdRegistrRuta value for the LiquidacionPlanillaDet object</param>
		/// <param name="lngIdRegistrRutaItemId">int that contents the lngIdRegistrRutaItemId value for the LiquidacionPlanillaDet object</param>
		/// <param name="strNoPlanilla">string that contents the strNoPlanilla value for the LiquidacionPlanillaDet object</param>
		/// <param name="dtmFechaModif">DateTime that contents the dtmFechaModif value for the LiquidacionPlanillaDet object</param>
		public void Update(int lngIdItemd, int? lngIdRegistro, int? lngIdRegistrRuta, int? lngIdRegistrRutaItemId, string strNoPlanilla, DateTime? dtmFechaModif, Sinapsys.Datos.SQL datosTransaccion=null)
		{
			try 
			{
				LiquidacionPlanillaDet new_values = new LiquidacionPlanillaDet();
				new_values.lngIdRegistro = lngIdRegistro;
				new_values.lngIdRegistrRuta = lngIdRegistrRuta;
				new_values.lngIdRegistrRutaItemId = lngIdRegistrRutaItemId;
				new_values.strNoPlanilla = strNoPlanilla;
				new_values.dtmFechaModif = dtmFechaModif;
				LiquidacionPlanillaDetDataProvider.Instance.Update(lngIdItemd, lngIdRegistro, lngIdRegistrRuta, lngIdRegistrRutaItemId, strNoPlanilla, dtmFechaModif,"LiquidacionPlanillaDet",datosTransaccion);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Updates an LiquidacionPlanillaDet object by passing one object's instance as reference
		/// </summary>
		/// <param name="liquidacionplanilladet">An instance of LiquidacionPlanillaDet for reference</param>
		public void Update(LiquidacionPlanillaDet liquidacionplanilladet,Sinapsys.Datos.SQL datosTransaccion=null)
		{
			Update(liquidacionplanilladet.lngIdItemd, liquidacionplanilladet.lngIdRegistro, liquidacionplanilladet.lngIdRegistrRuta, liquidacionplanilladet.lngIdRegistrRutaItemId, liquidacionplanilladet.strNoPlanilla, liquidacionplanilladet.dtmFechaModif);
		}

		/// <summary>
		/// Delete  the LiquidacionPlanillaDet object by passing a object
		/// </summary>
		public void  Delete(LiquidacionPlanillaDet liquidacionplanilladet, Sinapsys.Datos.SQL datosTransaccion=null)
		{
			Delete(liquidacionplanilladet.lngIdItemd,datosTransaccion);
		}

		/// <summary>
		/// Deletes the LiquidacionPlanillaDet object by passing one object's instance as reference
		/// </summary>
		/// <param name="liquidacionplanilladet">An instance of LiquidacionPlanillaDet for reference</param>
		public void Delete(int lngIdItemd, Sinapsys.Datos.SQL datosTransaccion=null)
		{
			try 
			{
				//LiquidacionPlanillaDet old_values = LiquidacionPlanillaDetController.Instance.Get(lngIdItemd);
				//if(!Validate.security.CanDeleteSecurityField(LiquidacionPlanillaDetController.Instance, (ILatinodeObject)old_values))
				//    throw new Exception("Access denied by security field, you can't delete object");

				LiquidacionPlanillaDetDataProvider.Instance.Delete(lngIdItemd,"LiquidacionPlanillaDet");
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Deletes the LiquidacionPlanillaDet object by passing CVS parameter as reference
		/// </summary>
		/// <param name="liquidacionplanilladet">An instance of LiquidacionPlanillaDet for reference</param>
		public void Delete(string CVSParameter)
		{
			string[] StrCommand=CVSParameter.Split(',');
			try 
			{
				int lngIdItemd=int.Parse(StrCommand[0]);
				LiquidacionPlanillaDetDataProvider.Instance.Delete(lngIdItemd,"LiquidacionPlanillaDet");
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Gets the LiquidacionPlanillaDet object by passing the object's key fields
		/// </summary>
		/// <param name="lngIdItemd">int that contents the lngIdItemd value for the LiquidacionPlanillaDet object</param>
		/// <returns>One LiquidacionPlanillaDet object</returns>
		public LiquidacionPlanillaDet Get(int lngIdItemd, bool generateUndo=false)
		{
			try 
			{
				LiquidacionPlanillaDet liquidacionplanilladet = null;
				DataTable dt = LiquidacionPlanillaDetDataProvider.Instance.Get(lngIdItemd);
				if ((dt.Rows.Count > 0))
				{
					liquidacionplanilladet = new LiquidacionPlanillaDet();
					DataRow dr = dt.Rows[0];
					ReadData(liquidacionplanilladet, dr, generateUndo);
				}


				return liquidacionplanilladet;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Gets all objects of LiquidacionPlanillaDet
		/// </summary>
		/// <returns>One LiquidacionPlanillaDetList object</returns>
		public LiquidacionPlanillaDetList GetAll(bool generateUndo=false)
		{
			try 
			{
				LiquidacionPlanillaDetList liquidacionplanilladetlist = new LiquidacionPlanillaDetList();
				DataTable dt = LiquidacionPlanillaDetDataProvider.Instance.GetAll();
				foreach (DataRow dr in dt.Rows)
				{
					LiquidacionPlanillaDet liquidacionplanilladet = new LiquidacionPlanillaDet();
					ReadData(liquidacionplanilladet, dr, generateUndo);
					liquidacionplanilladetlist.Add(liquidacionplanilladet);
				}
				return liquidacionplanilladetlist;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Gets all objects of LiquidacionPlanillaDet applying filter and sort criteria
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
		/// <returns>One LiquidacionPlanillaDetList object</returns>
		public LiquidacionPlanillaDetList GetFilter(int pagenum, int pagesize, string filter, string sort, string extablesfilter, string extablesfieldsfilter, string extablesrelationsfilter, string extablessort, string extablesfieldssort, string extablesrelationssort, bool generateUndo=false)
		{
			try 
			{
				LiquidacionPlanillaDetList liquidacionplanilladetlist = new LiquidacionPlanillaDetList();

				DataTable dt = LiquidacionPlanillaDetDataProvider.Instance.GetFilter(pagenum, pagesize, filter, sort, extablesfilter, extablesfieldsfilter, extablesrelationsfilter, extablessort, extablesfieldssort, extablesrelationssort);

				foreach (DataRow dr in dt.Rows)
				{
					LiquidacionPlanillaDet liquidacionplanilladet = new LiquidacionPlanillaDet();
					ReadData(liquidacionplanilladet, dr, generateUndo);
					liquidacionplanilladetlist.Add(liquidacionplanilladet);
				}
				return liquidacionplanilladetlist;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public LiquidacionPlanillaDetList GetFilter( string filter, string sort, bool generateUndo=false)
		{
			return GetFilter(0,0, filter, sort, "","","","","","",generateUndo);
		}

		public LiquidacionPlanillaDetList GetFilter(string filter, string sort, string extablesfilter, string extablesfieldsfilter, string extablesrelationsfilter, string extablessort, string extablesfieldssort, string extablesrelationssort, bool generateUndo=false)
		{
			return GetFilter(0,0, filter, sort, extablesfilter, extablesfieldsfilter, extablesrelationsfilter, extablessort, extablesfieldssort, extablesrelationssort,generateUndo);
		}


		/// <summary>
		/// Returns the type for one property
		/// </summary>
		/// <param name="propertyname">Property's name for return its value</param>
		/// <returns>A value for the <paramref name="propertyname"/></returns>
		public Type GetMethodType( string propertyname,LiquidacionPlanillaDet liquidacionplanilladet)
		{
			// Perform the search for the property's value
			switch (propertyname)
			{
				case "lngIdItemd":
					return liquidacionplanilladet.lngIdItemd.GetType();

				case "lngIdRegistro":
					return liquidacionplanilladet.lngIdRegistro.GetType();

				case "lngIdRegistrRuta":
					return liquidacionplanilladet.lngIdRegistrRuta.GetType();

				case "lngIdRegistrRutaItemId":
					return liquidacionplanilladet.lngIdRegistrRutaItemId.GetType();

				case "strNoPlanilla":
					return liquidacionplanilladet.strNoPlanilla.GetType();

				case "dtmFechaModif":
					return liquidacionplanilladet.dtmFechaModif.GetType();

			}

			return null;
		}
		/// <summary>
		/// update the changes in LiquidacionPlanillaDet object by passing the object
		/// </summary>
		public bool UpdateChanges(LiquidacionPlanillaDet liquidacionplanilladet, out string error,Sinapsys.Datos.SQL datosTransaccion=null)
		{
			if (liquidacionplanilladet.OldLiquidacionPlanillaDet == null)
			{
				    error = "No tiene objeto con el cual comparar";
				    return false;
			}
			string[] Fields = liquidacionplanilladet.FieldChanged();
			error = "";
			return LiqViajes_Bll_Data.DataProvider.UpdateFieldsbyObject(Fields, liquidacionplanilladet, out error,datosTransaccion);
		}
	}

	#endregion

}
