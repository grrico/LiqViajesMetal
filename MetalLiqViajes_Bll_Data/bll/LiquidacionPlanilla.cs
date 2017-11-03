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
	#region LiquidacionPlanillaController

	/// <summary>
	/// Class for convert data from database into object's data and vice versa
	/// </summary>
	public partial class LiquidacionPlanillaController//: ILatinodeController
	{
		/// <summary>
		/// Generic Constructor
		/// </summary>
		public LiquidacionPlanillaController()
		{
		}

		/// <summary>
		/// Instance accessor for this singleton
		/// </summary>
		private static LiquidacionPlanillaController MySingleObj;
		public static LiquidacionPlanillaController Instance
		{
			get
			{
				if (MySingleObj == null)
				{
					MySingleObj = new LiquidacionPlanillaController();
				}
				return MySingleObj;
			}
		}

		// Reads object's data from a DataRow
		private void ReadData(LiquidacionPlanilla liquidacionplanilla, DataRow dr,bool generateUndo=false)
		{
			try 
			{
				liquidacionplanilla.strNoPlanilla = dr.IsNull("strNoPlanilla") ? null :(string) dr["strNoPlanilla"];
				liquidacionplanilla.curValorFlete = dr.IsNull("curValorFlete") ? null :(decimal?) dr["curValorFlete"];
				liquidacionplanilla.dtmFechaModif = dr.IsNull("dtmFechaModif") ? null :(DateTime?) dr["dtmFechaModif"];
				liquidacionplanilla.logDesplazaVacio = dr.IsNull("logDesplazaVacio") ? null :(bool?) dr["logDesplazaVacio"];
				liquidacionplanilla.logSePuedeLiquidar = dr.IsNull("logSePuedeLiquidar") ? null :(bool?) dr["logSePuedeLiquidar"];
				liquidacionplanilla.lngIdRegistro = (int) dr["lngIdRegistro"];
				liquidacionplanilla.lngIdRegistrRutaItemId = (int) dr["lngIdRegistrRutaItemId"];
				liquidacionplanilla.lngIdRegistrRuta = (int) dr["lngIdRegistrRuta"];
			}
			catch (Exception ex)
			{
				Utilidades.LogErrores(ex.Message + (ex.InnerException != null ? ex.InnerException.Message : ""), DataProvider.AplicacionNombre);
				throw ex;
			}
			if (generateUndo) liquidacionplanilla.GenerateUndo();
		}

		/// <summary>
		/// Create a new LiquidacionPlanilla object by passing a object
		/// </summary>
		public LiquidacionPlanilla Create(LiquidacionPlanilla liquidacionplanilla, Sinapsys.Datos.SQL datosTransaccion=null)
		{
			return Create(liquidacionplanilla.lngIdRegistro,liquidacionplanilla.lngIdRegistrRutaItemId,liquidacionplanilla.lngIdRegistrRuta,liquidacionplanilla.strNoPlanilla,liquidacionplanilla.curValorFlete,liquidacionplanilla.dtmFechaModif,liquidacionplanilla.logDesplazaVacio,liquidacionplanilla.logSePuedeLiquidar,datosTransaccion);
		}

		/// <summary>
		/// Creates a new LiquidacionPlanilla object by passing all object's fields
		/// </summary>
		/// <param name="strNoPlanilla">string that contents the strNoPlanilla value for the LiquidacionPlanilla object</param>
		/// <param name="curValorFlete">decimal that contents the curValorFlete value for the LiquidacionPlanilla object</param>
		/// <param name="dtmFechaModif">DateTime that contents the dtmFechaModif value for the LiquidacionPlanilla object</param>
		/// <param name="logDesplazaVacio">bool that contents the logDesplazaVacio value for the LiquidacionPlanilla object</param>
		/// <param name="logSePuedeLiquidar">bool that contents the logSePuedeLiquidar value for the LiquidacionPlanilla object</param>
		/// <returns>One LiquidacionPlanilla object</returns>
		public LiquidacionPlanilla Create(int lngIdRegistro, int lngIdRegistrRutaItemId, int lngIdRegistrRuta, string strNoPlanilla, decimal? curValorFlete, DateTime? dtmFechaModif, bool? logDesplazaVacio, bool? logSePuedeLiquidar, Sinapsys.Datos.SQL datosTransaccion=null)
		{
			try 
			{
				LiquidacionPlanilla liquidacionplanilla = new LiquidacionPlanilla();

				liquidacionplanilla.lngIdRegistro = lngIdRegistro;
				liquidacionplanilla.lngIdRegistrRutaItemId = lngIdRegistrRutaItemId;
				liquidacionplanilla.lngIdRegistrRuta = lngIdRegistrRuta;
				liquidacionplanilla.strNoPlanilla = strNoPlanilla;
				liquidacionplanilla.curValorFlete = curValorFlete;
				liquidacionplanilla.dtmFechaModif = dtmFechaModif;
				liquidacionplanilla.logDesplazaVacio = logDesplazaVacio;
				liquidacionplanilla.logSePuedeLiquidar = logSePuedeLiquidar;
				LiquidacionPlanillaDataProvider.Instance.Create(lngIdRegistro, lngIdRegistrRutaItemId, lngIdRegistrRuta, strNoPlanilla, curValorFlete, dtmFechaModif, logDesplazaVacio, logSePuedeLiquidar,"LiquidacionPlanilla");

				return liquidacionplanilla;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Updates an LiquidacionPlanilla object by passing all object's fields
		/// </summary>
		/// <param name="strNoPlanilla">string that contents the strNoPlanilla value for the LiquidacionPlanilla object</param>
		/// <param name="curValorFlete">decimal that contents the curValorFlete value for the LiquidacionPlanilla object</param>
		/// <param name="dtmFechaModif">DateTime that contents the dtmFechaModif value for the LiquidacionPlanilla object</param>
		/// <param name="logDesplazaVacio">bool that contents the logDesplazaVacio value for the LiquidacionPlanilla object</param>
		/// <param name="logSePuedeLiquidar">bool that contents the logSePuedeLiquidar value for the LiquidacionPlanilla object</param>
		/// <param name="lngIdRegistro">int that contents the lngIdRegistro value for the LiquidacionPlanilla object</param>
		/// <param name="lngIdRegistrRutaItemId">int that contents the lngIdRegistrRutaItemId value for the LiquidacionPlanilla object</param>
		/// <param name="lngIdRegistrRuta">int that contents the lngIdRegistrRuta value for the LiquidacionPlanilla object</param>
		public void Update(string strNoPlanilla, decimal? curValorFlete, DateTime? dtmFechaModif, bool? logDesplazaVacio, bool? logSePuedeLiquidar, int lngIdRegistro, int lngIdRegistrRutaItemId, int lngIdRegistrRuta, Sinapsys.Datos.SQL datosTransaccion=null)
		{
			try 
			{
				LiquidacionPlanilla new_values = new LiquidacionPlanilla();
				new_values.strNoPlanilla = strNoPlanilla;
				new_values.curValorFlete = curValorFlete;
				new_values.dtmFechaModif = dtmFechaModif;
				new_values.logDesplazaVacio = logDesplazaVacio;
				new_values.logSePuedeLiquidar = logSePuedeLiquidar;
				LiquidacionPlanillaDataProvider.Instance.Update(strNoPlanilla, curValorFlete, dtmFechaModif, logDesplazaVacio, logSePuedeLiquidar, lngIdRegistro, lngIdRegistrRutaItemId, lngIdRegistrRuta,"LiquidacionPlanilla",datosTransaccion);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Updates an LiquidacionPlanilla object by passing one object's instance as reference
		/// </summary>
		/// <param name="liquidacionplanilla">An instance of LiquidacionPlanilla for reference</param>
		public void Update(LiquidacionPlanilla liquidacionplanilla,Sinapsys.Datos.SQL datosTransaccion=null)
		{
			Update(liquidacionplanilla.strNoPlanilla, liquidacionplanilla.curValorFlete, liquidacionplanilla.dtmFechaModif, liquidacionplanilla.logDesplazaVacio, liquidacionplanilla.logSePuedeLiquidar, liquidacionplanilla.lngIdRegistro, liquidacionplanilla.lngIdRegistrRutaItemId, liquidacionplanilla.lngIdRegistrRuta);
		}

		/// <summary>
		/// Delete  the LiquidacionPlanilla object by passing a object
		/// </summary>
		public void  Delete(LiquidacionPlanilla liquidacionplanilla, Sinapsys.Datos.SQL datosTransaccion=null)
		{
			Delete(liquidacionplanilla.lngIdRegistro, liquidacionplanilla.lngIdRegistrRutaItemId, liquidacionplanilla.lngIdRegistrRuta,datosTransaccion);
		}

		/// <summary>
		/// Deletes the LiquidacionPlanilla object by passing one object's instance as reference
		/// </summary>
		/// <param name="liquidacionplanilla">An instance of LiquidacionPlanilla for reference</param>
		public void Delete(int lngIdRegistro, int lngIdRegistrRutaItemId, int lngIdRegistrRuta, Sinapsys.Datos.SQL datosTransaccion=null)
		{
			try 
			{
				LiquidacionPlanillaDataProvider.Instance.Delete(lngIdRegistro, lngIdRegistrRutaItemId, lngIdRegistrRuta,"LiquidacionPlanilla");
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Deletes the LiquidacionPlanilla object by passing CVS parameter as reference
		/// </summary>
		/// <param name="liquidacionplanilla">An instance of LiquidacionPlanilla for reference</param>
		public void Delete(string CVSParameter)
		{
			string[] StrCommand=CVSParameter.Split(',');
			try 
			{
				int lngIdRegistro=int.Parse(StrCommand[0]);
				int lngIdRegistrRutaItemId=int.Parse(StrCommand[1]);
				int lngIdRegistrRuta=int.Parse(StrCommand[2]);
				LiquidacionPlanillaDataProvider.Instance.Delete(lngIdRegistro, lngIdRegistrRutaItemId, lngIdRegistrRuta,"LiquidacionPlanilla");
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Gets the LiquidacionPlanilla object by passing the object's key fields
		/// </summary>
		/// <param name="lngIdRegistro">int that contents the lngIdRegistro value for the LiquidacionPlanilla object</param>
		/// <param name="lngIdRegistrRutaItemId">int that contents the lngIdRegistrRutaItemId value for the LiquidacionPlanilla object</param>
		/// <param name="lngIdRegistrRuta">int that contents the lngIdRegistrRuta value for the LiquidacionPlanilla object</param>
		/// <returns>One LiquidacionPlanilla object</returns>
		public LiquidacionPlanilla Get(int lngIdRegistro, int lngIdRegistrRutaItemId, int lngIdRegistrRuta, bool generateUndo=false)
		{
			try 
			{
				LiquidacionPlanilla liquidacionplanilla = null;
				DataTable dt = LiquidacionPlanillaDataProvider.Instance.Get(lngIdRegistro, lngIdRegistrRutaItemId, lngIdRegistrRuta);
				if ((dt.Rows.Count > 0))
				{
					liquidacionplanilla = new LiquidacionPlanilla();
					DataRow dr = dt.Rows[0];
					ReadData(liquidacionplanilla, dr, generateUndo);
				}


				return liquidacionplanilla;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Gets all objects of LiquidacionPlanilla
		/// </summary>
		/// <returns>One LiquidacionPlanillaList object</returns>
		public LiquidacionPlanillaList GetAll(bool generateUndo=false)
		{
			try 
			{
				LiquidacionPlanillaList liquidacionplanillalist = new LiquidacionPlanillaList();
				DataTable dt = LiquidacionPlanillaDataProvider.Instance.GetAll();
				foreach (DataRow dr in dt.Rows)
				{
					LiquidacionPlanilla liquidacionplanilla = new LiquidacionPlanilla();
					ReadData(liquidacionplanilla, dr, generateUndo);
					liquidacionplanillalist.Add(liquidacionplanilla);
				}
				return liquidacionplanillalist;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Gets all objects of LiquidacionPlanilla applying filter and sort criteria
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
		/// <returns>One LiquidacionPlanillaList object</returns>
		public LiquidacionPlanillaList GetFilter(int pagenum, int pagesize, string filter, string sort, string extablesfilter, string extablesfieldsfilter, string extablesrelationsfilter, string extablessort, string extablesfieldssort, string extablesrelationssort, bool generateUndo=false)
		{
			try 
			{
				LiquidacionPlanillaList liquidacionplanillalist = new LiquidacionPlanillaList();

				DataTable dt = LiquidacionPlanillaDataProvider.Instance.GetFilter(pagenum, pagesize, filter, sort, extablesfilter, extablesfieldsfilter, extablesrelationsfilter, extablessort, extablesfieldssort, extablesrelationssort);

				foreach (DataRow dr in dt.Rows)
				{
					LiquidacionPlanilla liquidacionplanilla = new LiquidacionPlanilla();
					ReadData(liquidacionplanilla, dr, generateUndo);
					liquidacionplanillalist.Add(liquidacionplanilla);
				}
				return liquidacionplanillalist;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public LiquidacionPlanillaList GetFilter( string filter, string sort, bool generateUndo=false)
		{
			return GetFilter(0,0, filter, sort, "","","","","","",generateUndo);
		}

		public LiquidacionPlanillaList GetFilter(string filter, string sort, string extablesfilter, string extablesfieldsfilter, string extablesrelationsfilter, string extablessort, string extablesfieldssort, string extablesrelationssort, bool generateUndo=false)
		{
			return GetFilter(0,0, filter, sort, extablesfilter, extablesfieldsfilter, extablesrelationsfilter, extablessort, extablesfieldssort, extablesrelationssort,generateUndo);
		}


		/// <summary>
		/// Returns the type for one property
		/// </summary>
		/// <param name="propertyname">Property's name for return its value</param>
		/// <returns>A value for the <paramref name="propertyname"/></returns>
		public Type GetMethodType( string propertyname,LiquidacionPlanilla liquidacionplanilla)
		{
			// Perform the search for the property's value
			switch (propertyname)
			{
				case "strNoPlanilla":
					return liquidacionplanilla.strNoPlanilla.GetType();

				case "curValorFlete":
					return liquidacionplanilla.curValorFlete.GetType();

				case "dtmFechaModif":
					return liquidacionplanilla.dtmFechaModif.GetType();

				case "logDesplazaVacio":
					return liquidacionplanilla.logDesplazaVacio.GetType();

				case "logSePuedeLiquidar":
					return liquidacionplanilla.logSePuedeLiquidar.GetType();

				case "lngIdRegistro":
					return liquidacionplanilla.lngIdRegistro.GetType();

				case "lngIdRegistrRutaItemId":
					return liquidacionplanilla.lngIdRegistrRutaItemId.GetType();

				case "lngIdRegistrRuta":
					return liquidacionplanilla.lngIdRegistrRuta.GetType();

			}

			return null;
		}
		/// <summary>
		/// update the changes in LiquidacionPlanilla object by passing the object
		/// </summary>
		public bool UpdateChanges(LiquidacionPlanilla liquidacionplanilla, out string error,Sinapsys.Datos.SQL datosTransaccion=null)
		{
			if (liquidacionplanilla.OldLiquidacionPlanilla == null)
			{
				    error = "No tiene objeto con el cual comparar";
				    return false;
			}
			string[] Fields = liquidacionplanilla.FieldChanged();
			error = "";
			return LiqViajes_Bll_Data.DataProvider.UpdateFieldsbyObject(Fields, liquidacionplanilla, out error,datosTransaccion);
		}
	}

	#endregion

}
