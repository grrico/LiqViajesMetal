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
	#region LiquidacionRutasObsController

	/// <summary>
	/// Class for convert data from database into object's data and vice versa
	/// </summary>
	public partial class LiquidacionRutasObsController//: ILatinodeController
	{
		/// <summary>
		/// Generic Constructor
		/// </summary>
		public LiquidacionRutasObsController()
		{
		}

		/// <summary>
		/// Instance accessor for this singleton
		/// </summary>
		private static LiquidacionRutasObsController MySingleObj;
		public static LiquidacionRutasObsController Instance
		{
			get
			{
				if (MySingleObj == null)
				{
					MySingleObj = new LiquidacionRutasObsController();
				}
				return MySingleObj;
			}
		}

		// Reads object's data from a DataRow
		private void ReadData(LiquidacionRutasObs liquidacionrutasobs, DataRow dr,bool generateUndo=false)
		{
			try 
			{
				liquidacionrutasobs.lngItemsId = (int) dr["lngItemsId"];
				liquidacionrutasobs.lngIdRegistrRutaItemId = dr.IsNull("lngIdRegistrRutaItemId") ? null :(int?) dr["lngIdRegistrRutaItemId"];
				liquidacionrutasobs.lngIdRegistrRuta = dr.IsNull("lngIdRegistrRuta") ? null :(int?) dr["lngIdRegistrRuta"];
				liquidacionrutasobs.lngIdRegistro = dr.IsNull("lngIdRegistro") ? null :(int?) dr["lngIdRegistro"];
				liquidacionrutasobs.strCampo = dr.IsNull("strCampo") ? null :(string) dr["strCampo"];
				liquidacionrutasobs.strObservacion = dr.IsNull("strObservacion") ? null :(string) dr["strObservacion"];
				liquidacionrutasobs.nitTercero = dr.IsNull("nitTercero") ? null :(string) dr["nitTercero"];
				liquidacionrutasobs.dtmFechaModif = dr.IsNull("dtmFechaModif") ? null :(DateTime?) dr["dtmFechaModif"];
			}
			catch (Exception ex)
			{
				Utilidades.LogErrores(ex.Message + (ex.InnerException != null ? ex.InnerException.Message : ""), DataProvider.AplicacionNombre);
				throw ex;
			}
			if (generateUndo) liquidacionrutasobs.GenerateUndo();
		}

		/// <summary>
		/// Create a new LiquidacionRutasObs object by passing a object
		/// </summary>
		public LiquidacionRutasObs Create(LiquidacionRutasObs liquidacionrutasobs, Sinapsys.Datos.SQL datosTransaccion=null)
		{
			return Create(liquidacionrutasobs.lngItemsId,liquidacionrutasobs.lngIdRegistrRutaItemId,liquidacionrutasobs.lngIdRegistrRuta,liquidacionrutasobs.lngIdRegistro,liquidacionrutasobs.strCampo,liquidacionrutasobs.strObservacion,liquidacionrutasobs.nitTercero,liquidacionrutasobs.dtmFechaModif,datosTransaccion);
		}

		/// <summary>
		/// Creates a new LiquidacionRutasObs object by passing all object's fields
		/// </summary>
		/// <param name="lngIdRegistrRutaItemId">int that contents the lngIdRegistrRutaItemId value for the LiquidacionRutasObs object</param>
		/// <param name="lngIdRegistrRuta">int that contents the lngIdRegistrRuta value for the LiquidacionRutasObs object</param>
		/// <param name="lngIdRegistro">int that contents the lngIdRegistro value for the LiquidacionRutasObs object</param>
		/// <param name="strCampo">string that contents the strCampo value for the LiquidacionRutasObs object</param>
		/// <param name="strObservacion">string that contents the strObservacion value for the LiquidacionRutasObs object</param>
		/// <param name="nitTercero">string that contents the nitTercero value for the LiquidacionRutasObs object</param>
		/// <param name="dtmFechaModif">DateTime that contents the dtmFechaModif value for the LiquidacionRutasObs object</param>
		/// <returns>One LiquidacionRutasObs object</returns>
		public LiquidacionRutasObs Create(int lngItemsId, int? lngIdRegistrRutaItemId, int? lngIdRegistrRuta, int? lngIdRegistro, string strCampo, string strObservacion, string nitTercero, DateTime? dtmFechaModif, Sinapsys.Datos.SQL datosTransaccion=null)
		{
			try 
			{
				LiquidacionRutasObs liquidacionrutasobs = new LiquidacionRutasObs();

				liquidacionrutasobs.lngItemsId = lngItemsId;
				liquidacionrutasobs.lngItemsId = lngItemsId;
				liquidacionrutasobs.lngIdRegistrRutaItemId = lngIdRegistrRutaItemId;
				liquidacionrutasobs.lngIdRegistrRuta = lngIdRegistrRuta;
				liquidacionrutasobs.lngIdRegistro = lngIdRegistro;
				liquidacionrutasobs.strCampo = strCampo;
				liquidacionrutasobs.strObservacion = strObservacion;
				liquidacionrutasobs.nitTercero = nitTercero;
				liquidacionrutasobs.dtmFechaModif = dtmFechaModif;
				lngItemsId = LiquidacionRutasObsDataProvider.Instance.Create(lngItemsId, lngIdRegistrRutaItemId, lngIdRegistrRuta, lngIdRegistro, strCampo, strObservacion, nitTercero, dtmFechaModif,"LiquidacionRutasObs",datosTransaccion);
				if (lngItemsId == 0)
					return null;

				liquidacionrutasobs.lngItemsId = lngItemsId;

				return liquidacionrutasobs;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Updates an LiquidacionRutasObs object by passing all object's fields
		/// </summary>
		/// <param name="lngItemsId">int that contents the lngItemsId value for the LiquidacionRutasObs object</param>
		/// <param name="lngIdRegistrRutaItemId">int that contents the lngIdRegistrRutaItemId value for the LiquidacionRutasObs object</param>
		/// <param name="lngIdRegistrRuta">int that contents the lngIdRegistrRuta value for the LiquidacionRutasObs object</param>
		/// <param name="lngIdRegistro">int that contents the lngIdRegistro value for the LiquidacionRutasObs object</param>
		/// <param name="strCampo">string that contents the strCampo value for the LiquidacionRutasObs object</param>
		/// <param name="strObservacion">string that contents the strObservacion value for the LiquidacionRutasObs object</param>
		/// <param name="nitTercero">string that contents the nitTercero value for the LiquidacionRutasObs object</param>
		/// <param name="dtmFechaModif">DateTime that contents the dtmFechaModif value for the LiquidacionRutasObs object</param>
		public void Update(int lngItemsId, int? lngIdRegistrRutaItemId, int? lngIdRegistrRuta, int? lngIdRegistro, string strCampo, string strObservacion, string nitTercero, DateTime? dtmFechaModif, Sinapsys.Datos.SQL datosTransaccion=null)
		{
			try 
			{
				LiquidacionRutasObs new_values = new LiquidacionRutasObs();
				new_values.lngIdRegistrRutaItemId = lngIdRegistrRutaItemId;
				new_values.lngIdRegistrRuta = lngIdRegistrRuta;
				new_values.lngIdRegistro = lngIdRegistro;
				new_values.strCampo = strCampo;
				new_values.strObservacion = strObservacion;
				new_values.nitTercero = nitTercero;
				new_values.dtmFechaModif = dtmFechaModif;
				LiquidacionRutasObsDataProvider.Instance.Update(lngItemsId, lngIdRegistrRutaItemId, lngIdRegistrRuta, lngIdRegistro, strCampo, strObservacion, nitTercero, dtmFechaModif,"LiquidacionRutasObs",datosTransaccion);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Updates an LiquidacionRutasObs object by passing one object's instance as reference
		/// </summary>
		/// <param name="liquidacionrutasobs">An instance of LiquidacionRutasObs for reference</param>
		public void Update(LiquidacionRutasObs liquidacionrutasobs,Sinapsys.Datos.SQL datosTransaccion=null)
		{
			Update(liquidacionrutasobs.lngItemsId, liquidacionrutasobs.lngIdRegistrRutaItemId, liquidacionrutasobs.lngIdRegistrRuta, liquidacionrutasobs.lngIdRegistro, liquidacionrutasobs.strCampo, liquidacionrutasobs.strObservacion, liquidacionrutasobs.nitTercero, liquidacionrutasobs.dtmFechaModif);
		}

		/// <summary>
		/// Delete  the LiquidacionRutasObs object by passing a object
		/// </summary>
		public void  Delete(LiquidacionRutasObs liquidacionrutasobs, Sinapsys.Datos.SQL datosTransaccion=null)
		{
			Delete(liquidacionrutasobs.lngItemsId,datosTransaccion);
		}

		/// <summary>
		/// Deletes the LiquidacionRutasObs object by passing one object's instance as reference
		/// </summary>
		/// <param name="liquidacionrutasobs">An instance of LiquidacionRutasObs for reference</param>
		public void Delete(int lngItemsId, Sinapsys.Datos.SQL datosTransaccion=null)
		{
			try 
			{
				//LiquidacionRutasObs old_values = LiquidacionRutasObsController.Instance.Get(lngItemsId);
				//if(!Validate.security.CanDeleteSecurityField(LiquidacionRutasObsController.Instance, (ILatinodeObject)old_values))
				//    throw new Exception("Access denied by security field, you can't delete object");

				LiquidacionRutasObsDataProvider.Instance.Delete(lngItemsId,"LiquidacionRutasObs");
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Deletes the LiquidacionRutasObs object by passing CVS parameter as reference
		/// </summary>
		/// <param name="liquidacionrutasobs">An instance of LiquidacionRutasObs for reference</param>
		public void Delete(string CVSParameter)
		{
			string[] StrCommand=CVSParameter.Split(',');
			try 
			{
				int lngItemsId=int.Parse(StrCommand[0]);
				LiquidacionRutasObsDataProvider.Instance.Delete(lngItemsId,"LiquidacionRutasObs");
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Gets the LiquidacionRutasObs object by passing the object's key fields
		/// </summary>
		/// <param name="lngItemsId">int that contents the lngItemsId value for the LiquidacionRutasObs object</param>
		/// <returns>One LiquidacionRutasObs object</returns>
		public LiquidacionRutasObs Get(int lngItemsId, bool generateUndo=false)
		{
			try 
			{
				LiquidacionRutasObs liquidacionrutasobs = null;
				DataTable dt = LiquidacionRutasObsDataProvider.Instance.Get(lngItemsId);
				if ((dt.Rows.Count > 0))
				{
					liquidacionrutasobs = new LiquidacionRutasObs();
					DataRow dr = dt.Rows[0];
					ReadData(liquidacionrutasobs, dr, generateUndo);
				}


				return liquidacionrutasobs;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Gets all objects of LiquidacionRutasObs
		/// </summary>
		/// <returns>One LiquidacionRutasObsList object</returns>
		public LiquidacionRutasObsList GetAll(bool generateUndo=false)
		{
			try 
			{
				LiquidacionRutasObsList liquidacionrutasobslist = new LiquidacionRutasObsList();
				DataTable dt = LiquidacionRutasObsDataProvider.Instance.GetAll();
				foreach (DataRow dr in dt.Rows)
				{
					LiquidacionRutasObs liquidacionrutasobs = new LiquidacionRutasObs();
					ReadData(liquidacionrutasobs, dr, generateUndo);
					liquidacionrutasobslist.Add(liquidacionrutasobs);
				}
				return liquidacionrutasobslist;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Gets all objects of LiquidacionRutasObs applying filter and sort criteria
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
		/// <returns>One LiquidacionRutasObsList object</returns>
		public LiquidacionRutasObsList GetFilter(int pagenum, int pagesize, string filter, string sort, string extablesfilter, string extablesfieldsfilter, string extablesrelationsfilter, string extablessort, string extablesfieldssort, string extablesrelationssort, bool generateUndo=false)
		{
			try 
			{
				LiquidacionRutasObsList liquidacionrutasobslist = new LiquidacionRutasObsList();

				DataTable dt = LiquidacionRutasObsDataProvider.Instance.GetFilter(pagenum, pagesize, filter, sort, extablesfilter, extablesfieldsfilter, extablesrelationsfilter, extablessort, extablesfieldssort, extablesrelationssort);

				foreach (DataRow dr in dt.Rows)
				{
					LiquidacionRutasObs liquidacionrutasobs = new LiquidacionRutasObs();
					ReadData(liquidacionrutasobs, dr, generateUndo);
					liquidacionrutasobslist.Add(liquidacionrutasobs);
				}
				return liquidacionrutasobslist;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public LiquidacionRutasObsList GetFilter( string filter, string sort, bool generateUndo=false)
		{
			return GetFilter(0,0, filter, sort, "","","","","","",generateUndo);
		}

		public LiquidacionRutasObsList GetFilter(string filter, string sort, string extablesfilter, string extablesfieldsfilter, string extablesrelationsfilter, string extablessort, string extablesfieldssort, string extablesrelationssort, bool generateUndo=false)
		{
			return GetFilter(0,0, filter, sort, extablesfilter, extablesfieldsfilter, extablesrelationsfilter, extablessort, extablesfieldssort, extablesrelationssort,generateUndo);
		}


		/// <summary>
		/// Returns the type for one property
		/// </summary>
		/// <param name="propertyname">Property's name for return its value</param>
		/// <returns>A value for the <paramref name="propertyname"/></returns>
		public Type GetMethodType( string propertyname,LiquidacionRutasObs liquidacionrutasobs)
		{
			// Perform the search for the property's value
			switch (propertyname)
			{
				case "lngItemsId":
					return liquidacionrutasobs.lngItemsId.GetType();

				case "lngIdRegistrRutaItemId":
					return liquidacionrutasobs.lngIdRegistrRutaItemId.GetType();

				case "lngIdRegistrRuta":
					return liquidacionrutasobs.lngIdRegistrRuta.GetType();

				case "lngIdRegistro":
					return liquidacionrutasobs.lngIdRegistro.GetType();

				case "strCampo":
					return liquidacionrutasobs.strCampo.GetType();

				case "strObservacion":
					return liquidacionrutasobs.strObservacion.GetType();

				case "nitTercero":
					return liquidacionrutasobs.nitTercero.GetType();

				case "dtmFechaModif":
					return liquidacionrutasobs.dtmFechaModif.GetType();

			}

			return null;
		}
		/// <summary>
		/// update the changes in LiquidacionRutasObs object by passing the object
		/// </summary>
		public bool UpdateChanges(LiquidacionRutasObs liquidacionrutasobs, out string error,Sinapsys.Datos.SQL datosTransaccion=null)
		{
			if (liquidacionrutasobs.OldLiquidacionRutasObs == null)
			{
				    error = "No tiene objeto con el cual comparar";
				    return false;
			}
			string[] Fields = liquidacionrutasobs.FieldChanged();
			error = "";
			return LiqViajes_Bll_Data.DataProvider.UpdateFieldsbyObject(Fields, liquidacionrutasobs, out error,datosTransaccion);
		}
	}

	#endregion

}
