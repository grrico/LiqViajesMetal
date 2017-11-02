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
	#region LiquidacionSaldoConductorController

	/// <summary>
	/// Class for convert data from database into object's data and vice versa
	/// </summary>
	public partial class LiquidacionSaldoConductorController//: ILatinodeController
	{
		/// <summary>
		/// Generic Constructor
		/// </summary>
		public LiquidacionSaldoConductorController()
		{
		}

		/// <summary>
		/// Instance accessor for this singleton
		/// </summary>
		private static LiquidacionSaldoConductorController MySingleObj;
		public static LiquidacionSaldoConductorController Instance
		{
			get
			{
				if (MySingleObj == null)
				{
					MySingleObj = new LiquidacionSaldoConductorController();
				}
				return MySingleObj;
			}
		}

		// Reads object's data from a DataRow
		private void ReadData(LiquidacionSaldoConductor liquidacionsaldoconductor, DataRow dr,bool generateUndo=false)
		{
			try 
			{
				liquidacionsaldoconductor.lngIdRegistro = (int) dr["lngIdRegistro"];
				liquidacionsaldoconductor.intNitConductor = (decimal) dr["intNitConductor"];
				liquidacionsaldoconductor.curValorSaldo = dr.IsNull("curValorSaldo") ? null :(decimal?) dr["curValorSaldo"];
				liquidacionsaldoconductor.dtmFechaModif = dr.IsNull("dtmFechaModif") ? null :(DateTime?) dr["dtmFechaModif"];
				liquidacionsaldoconductor.sw = dr.IsNull("sw") ? null :(byte?) dr["sw"];
				liquidacionsaldoconductor.strTipo = dr.IsNull("strTipo") ? null :(string) dr["strTipo"];
				liquidacionsaldoconductor.numero = dr.IsNull("numero") ? null :(int?) dr["numero"];
				liquidacionsaldoconductor.lngIdRegistroLiq = dr.IsNull("lngIdRegistroLiq") ? null :(int?) dr["lngIdRegistroLiq"];
			}
			catch (Exception ex)
			{
				Utilidades.LogErrores(ex.Message + (ex.InnerException != null ? ex.InnerException.Message : ""), DataProvider.AplicacionNombre);
				throw ex;
			}
			if (generateUndo) liquidacionsaldoconductor.GenerateUndo();
		}

		/// <summary>
		/// Create a new LiquidacionSaldoConductor object by passing a object
		/// </summary>
		public LiquidacionSaldoConductor Create(LiquidacionSaldoConductor liquidacionsaldoconductor, Sinapsys.Datos.SQL datosTransaccion=null)
		{
			return Create(liquidacionsaldoconductor.lngIdRegistro,liquidacionsaldoconductor.intNitConductor,liquidacionsaldoconductor.curValorSaldo,liquidacionsaldoconductor.dtmFechaModif,liquidacionsaldoconductor.sw,liquidacionsaldoconductor.strTipo,liquidacionsaldoconductor.numero,liquidacionsaldoconductor.lngIdRegistroLiq,datosTransaccion);
		}

		/// <summary>
		/// Creates a new LiquidacionSaldoConductor object by passing all object's fields
		/// </summary>
		/// <param name="curValorSaldo">decimal that contents the curValorSaldo value for the LiquidacionSaldoConductor object</param>
		/// <param name="dtmFechaModif">DateTime that contents the dtmFechaModif value for the LiquidacionSaldoConductor object</param>
		/// <param name="sw">byte that contents the sw value for the LiquidacionSaldoConductor object</param>
		/// <param name="strTipo">string that contents the strTipo value for the LiquidacionSaldoConductor object</param>
		/// <param name="numero">int that contents the numero value for the LiquidacionSaldoConductor object</param>
		/// <param name="lngIdRegistroLiq">int that contents the lngIdRegistroLiq value for the LiquidacionSaldoConductor object</param>
		/// <returns>One LiquidacionSaldoConductor object</returns>
		public LiquidacionSaldoConductor Create(int lngIdRegistro, decimal intNitConductor, decimal? curValorSaldo, DateTime? dtmFechaModif, byte? sw, string strTipo, int? numero, int? lngIdRegistroLiq, Sinapsys.Datos.SQL datosTransaccion=null)
		{
			try 
			{
				LiquidacionSaldoConductor liquidacionsaldoconductor = new LiquidacionSaldoConductor();

				liquidacionsaldoconductor.lngIdRegistro = lngIdRegistro;
				liquidacionsaldoconductor.intNitConductor = intNitConductor;
				liquidacionsaldoconductor.curValorSaldo = curValorSaldo;
				liquidacionsaldoconductor.dtmFechaModif = dtmFechaModif;
				liquidacionsaldoconductor.sw = sw;
				liquidacionsaldoconductor.strTipo = strTipo;
				liquidacionsaldoconductor.numero = numero;
				liquidacionsaldoconductor.lngIdRegistroLiq = lngIdRegistroLiq;
				LiquidacionSaldoConductorDataProvider.Instance.Create(lngIdRegistro, intNitConductor, curValorSaldo, dtmFechaModif, sw, strTipo, numero, lngIdRegistroLiq,"LiquidacionSaldoConductor");

				return liquidacionsaldoconductor;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Updates an LiquidacionSaldoConductor object by passing all object's fields
		/// </summary>
		/// <param name="lngIdRegistro">int that contents the lngIdRegistro value for the LiquidacionSaldoConductor object</param>
		/// <param name="intNitConductor">decimal that contents the intNitConductor value for the LiquidacionSaldoConductor object</param>
		/// <param name="curValorSaldo">decimal that contents the curValorSaldo value for the LiquidacionSaldoConductor object</param>
		/// <param name="dtmFechaModif">DateTime that contents the dtmFechaModif value for the LiquidacionSaldoConductor object</param>
		/// <param name="sw">byte that contents the sw value for the LiquidacionSaldoConductor object</param>
		/// <param name="strTipo">string that contents the strTipo value for the LiquidacionSaldoConductor object</param>
		/// <param name="numero">int that contents the numero value for the LiquidacionSaldoConductor object</param>
		/// <param name="lngIdRegistroLiq">int that contents the lngIdRegistroLiq value for the LiquidacionSaldoConductor object</param>
		public void Update(int lngIdRegistro, decimal intNitConductor, decimal? curValorSaldo, DateTime? dtmFechaModif, byte? sw, string strTipo, int? numero, int? lngIdRegistroLiq, Sinapsys.Datos.SQL datosTransaccion=null)
		{
			try 
			{
				LiquidacionSaldoConductor new_values = new LiquidacionSaldoConductor();
				new_values.curValorSaldo = curValorSaldo;
				new_values.dtmFechaModif = dtmFechaModif;
				new_values.sw = sw;
				new_values.strTipo = strTipo;
				new_values.numero = numero;
				new_values.lngIdRegistroLiq = lngIdRegistroLiq;
				LiquidacionSaldoConductorDataProvider.Instance.Update(lngIdRegistro, intNitConductor, curValorSaldo, dtmFechaModif, sw, strTipo, numero, lngIdRegistroLiq,"LiquidacionSaldoConductor",datosTransaccion);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Updates an LiquidacionSaldoConductor object by passing one object's instance as reference
		/// </summary>
		/// <param name="liquidacionsaldoconductor">An instance of LiquidacionSaldoConductor for reference</param>
		public void Update(LiquidacionSaldoConductor liquidacionsaldoconductor,Sinapsys.Datos.SQL datosTransaccion=null)
		{
			Update(liquidacionsaldoconductor.lngIdRegistro, liquidacionsaldoconductor.intNitConductor, liquidacionsaldoconductor.curValorSaldo, liquidacionsaldoconductor.dtmFechaModif, liquidacionsaldoconductor.sw, liquidacionsaldoconductor.strTipo, liquidacionsaldoconductor.numero, liquidacionsaldoconductor.lngIdRegistroLiq);
		}

		/// <summary>
		/// Delete  the LiquidacionSaldoConductor object by passing a object
		/// </summary>
		public void  Delete(LiquidacionSaldoConductor liquidacionsaldoconductor, Sinapsys.Datos.SQL datosTransaccion=null)
		{
			Delete(liquidacionsaldoconductor.lngIdRegistro, liquidacionsaldoconductor.intNitConductor,datosTransaccion);
		}

		/// <summary>
		/// Deletes the LiquidacionSaldoConductor object by passing one object's instance as reference
		/// </summary>
		/// <param name="liquidacionsaldoconductor">An instance of LiquidacionSaldoConductor for reference</param>
		public void Delete(int lngIdRegistro, decimal intNitConductor, Sinapsys.Datos.SQL datosTransaccion=null)
		{
			try 
			{
				LiquidacionSaldoConductorDataProvider.Instance.Delete(lngIdRegistro, intNitConductor,"LiquidacionSaldoConductor");
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Deletes the LiquidacionSaldoConductor object by passing CVS parameter as reference
		/// </summary>
		/// <param name="liquidacionsaldoconductor">An instance of LiquidacionSaldoConductor for reference</param>
		public void Delete(string CVSParameter)
		{
			string[] StrCommand=CVSParameter.Split(',');
			try 
			{
				int lngIdRegistro=int.Parse(StrCommand[0]);
				decimal intNitConductor=decimal.Parse(StrCommand[1]);
				LiquidacionSaldoConductorDataProvider.Instance.Delete(lngIdRegistro, intNitConductor,"LiquidacionSaldoConductor");
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Gets the LiquidacionSaldoConductor object by passing the object's key fields
		/// </summary>
		/// <param name="lngIdRegistro">int that contents the lngIdRegistro value for the LiquidacionSaldoConductor object</param>
		/// <param name="intNitConductor">decimal that contents the intNitConductor value for the LiquidacionSaldoConductor object</param>
		/// <returns>One LiquidacionSaldoConductor object</returns>
		public LiquidacionSaldoConductor Get(int lngIdRegistro, decimal intNitConductor, bool generateUndo=false)
		{
			try 
			{
				LiquidacionSaldoConductor liquidacionsaldoconductor = null;
				DataTable dt = LiquidacionSaldoConductorDataProvider.Instance.Get(lngIdRegistro, intNitConductor);
				if ((dt.Rows.Count > 0))
				{
					liquidacionsaldoconductor = new LiquidacionSaldoConductor();
					DataRow dr = dt.Rows[0];
					ReadData(liquidacionsaldoconductor, dr, generateUndo);
				}


				return liquidacionsaldoconductor;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Gets all objects of LiquidacionSaldoConductor
		/// </summary>
		/// <returns>One LiquidacionSaldoConductorList object</returns>
		public LiquidacionSaldoConductorList GetAll(bool generateUndo=false)
		{
			try 
			{
				LiquidacionSaldoConductorList liquidacionsaldoconductorlist = new LiquidacionSaldoConductorList();
				DataTable dt = LiquidacionSaldoConductorDataProvider.Instance.GetAll();
				foreach (DataRow dr in dt.Rows)
				{
					LiquidacionSaldoConductor liquidacionsaldoconductor = new LiquidacionSaldoConductor();
					ReadData(liquidacionsaldoconductor, dr, generateUndo);
					liquidacionsaldoconductorlist.Add(liquidacionsaldoconductor);
				}
				return liquidacionsaldoconductorlist;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Gets all objects of LiquidacionSaldoConductor applying filter and sort criteria
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
		/// <returns>One LiquidacionSaldoConductorList object</returns>
		public LiquidacionSaldoConductorList GetFilter(int pagenum, int pagesize, string filter, string sort, string extablesfilter, string extablesfieldsfilter, string extablesrelationsfilter, string extablessort, string extablesfieldssort, string extablesrelationssort, bool generateUndo=false)
		{
			try 
			{
				LiquidacionSaldoConductorList liquidacionsaldoconductorlist = new LiquidacionSaldoConductorList();

				DataTable dt = LiquidacionSaldoConductorDataProvider.Instance.GetFilter(pagenum, pagesize, filter, sort, extablesfilter, extablesfieldsfilter, extablesrelationsfilter, extablessort, extablesfieldssort, extablesrelationssort);

				foreach (DataRow dr in dt.Rows)
				{
					LiquidacionSaldoConductor liquidacionsaldoconductor = new LiquidacionSaldoConductor();
					ReadData(liquidacionsaldoconductor, dr, generateUndo);
					liquidacionsaldoconductorlist.Add(liquidacionsaldoconductor);
				}
				return liquidacionsaldoconductorlist;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public LiquidacionSaldoConductorList GetFilter( string filter, string sort, bool generateUndo=false)
		{
			return GetFilter(0,0, filter, sort, "","","","","","",generateUndo);
		}

		public LiquidacionSaldoConductorList GetFilter(string filter, string sort, string extablesfilter, string extablesfieldsfilter, string extablesrelationsfilter, string extablessort, string extablesfieldssort, string extablesrelationssort, bool generateUndo=false)
		{
			return GetFilter(0,0, filter, sort, extablesfilter, extablesfieldsfilter, extablesrelationsfilter, extablessort, extablesfieldssort, extablesrelationssort,generateUndo);
		}


		/// <summary>
		/// Returns the type for one property
		/// </summary>
		/// <param name="propertyname">Property's name for return its value</param>
		/// <returns>A value for the <paramref name="propertyname"/></returns>
		public Type GetMethodType( string propertyname,LiquidacionSaldoConductor liquidacionsaldoconductor)
		{
			// Perform the search for the property's value
			switch (propertyname)
			{
				case "lngIdRegistro":
					return liquidacionsaldoconductor.lngIdRegistro.GetType();

				case "intNitConductor":
					return liquidacionsaldoconductor.intNitConductor.GetType();

				case "curValorSaldo":
					return liquidacionsaldoconductor.curValorSaldo.GetType();

				case "dtmFechaModif":
					return liquidacionsaldoconductor.dtmFechaModif.GetType();

				case "sw":
					return liquidacionsaldoconductor.sw.GetType();

				case "strTipo":
					return liquidacionsaldoconductor.strTipo.GetType();

				case "numero":
					return liquidacionsaldoconductor.numero.GetType();

				case "lngIdRegistroLiq":
					return liquidacionsaldoconductor.lngIdRegistroLiq.GetType();

			}

			return null;
		}
		/// <summary>
		/// update the changes in LiquidacionSaldoConductor object by passing the object
		/// </summary>
		public bool UpdateChanges(LiquidacionSaldoConductor liquidacionsaldoconductor, out string error,Sinapsys.Datos.SQL datosTransaccion=null)
		{
			if (liquidacionsaldoconductor.OldLiquidacionSaldoConductor == null)
			{
				    error = "No tiene objeto con el cual comparar";
				    return false;
			}
			string[] Fields = liquidacionsaldoconductor.FieldChanged();
			error = "";
			return LiqViajes_Bll_Data.DataProvider.UpdateFieldsbyObject(Fields, liquidacionsaldoconductor, out error,datosTransaccion);
		}
	}

	#endregion

}
