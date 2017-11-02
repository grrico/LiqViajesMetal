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
	#region TempLiqMetalController

	/// <summary>
	/// Class for convert data from database into object's data and vice versa
	/// </summary>
	public partial class TempLiqMetalController//: ILatinodeController
	{
		/// <summary>
		/// Generic Constructor
		/// </summary>
		public TempLiqMetalController()
		{
		}

		/// <summary>
		/// Instance accessor for this singleton
		/// </summary>
		private static TempLiqMetalController MySingleObj;
		public static TempLiqMetalController Instance
		{
			get
			{
				if (MySingleObj == null)
				{
					MySingleObj = new TempLiqMetalController();
				}
				return MySingleObj;
			}
		}

		// Reads object's data from a DataRow
		private void ReadData(TempLiqMetal templiqmetal, DataRow dr,bool generateUndo=false)
		{
			try 
			{
				templiqmetal.strPlaca = (string) dr["strPlaca"];
				templiqmetal.strCuenta = ((string) dr["strCuenta"])[0];
				templiqmetal.strDescripcion = dr.IsNull("strDescripcion") ? null :(char?) ((string) dr["strDescripcion"])[0];
				templiqmetal.intDocumento = dr.IsNull("intDocumento") ? null :(int?) dr["intDocumento"];
				templiqmetal.lngIdRegistroViaje = dr.IsNull("lngIdRegistroViaje") ? null :(decimal?) dr["lngIdRegistroViaje"];
				templiqmetal.dtmFechaAsignacion = dr.IsNull("dtmFechaAsignacion") ? null :(DateTime?) dr["dtmFechaAsignacion"];
				templiqmetal.curValorDebito = dr.IsNull("curValorDebito") ? null :(decimal?) dr["curValorDebito"];
				templiqmetal.curValorCredito = dr.IsNull("curValorCredito") ? null :(decimal?) dr["curValorCredito"];
				templiqmetal.logLiquidado = dr.IsNull("logLiquidado") ? null :(bool?) dr["logLiquidado"];
				templiqmetal.nitTercero = dr.IsNull("nitTercero") ? null :(char?) ((string) dr["nitTercero"])[0];
				templiqmetal.strObservaciones = dr.IsNull("strObservaciones") ? null :(string) dr["strObservaciones"];
				templiqmetal.lngIdUsuario = dr.IsNull("lngIdUsuario") ? null :(int?) dr["lngIdUsuario"];
				templiqmetal.dtmFechaModif = dr.IsNull("dtmFechaModif") ? null :(DateTime?) dr["dtmFechaModif"];
				templiqmetal.LogAnticipo = dr.IsNull("LogAnticipo") ? null :(bool?) dr["LogAnticipo"];
				templiqmetal.intNitConductor = dr.IsNull("intNitConductor") ? null :(decimal?) dr["intNitConductor"];
				templiqmetal.strConductor = dr.IsNull("strConductor") ? null :(string) dr["strConductor"];
			}
			catch (Exception ex)
			{
				Utilidades.LogErrores(ex.Message + (ex.InnerException != null ? ex.InnerException.Message : ""), DataProvider.AplicacionNombre);
				throw ex;
			}
			if (generateUndo) templiqmetal.GenerateUndo();
		}

		/// <summary>
		/// Create a new TempLiqMetal object by passing a object
		/// </summary>
		public TempLiqMetal Create(TempLiqMetal templiqmetal, Sinapsys.Datos.SQL datosTransaccion=null)
		{
			return Create(templiqmetal.strPlaca,templiqmetal.strCuenta,templiqmetal.strDescripcion,templiqmetal.intDocumento,templiqmetal.lngIdRegistroViaje,templiqmetal.dtmFechaAsignacion,templiqmetal.curValorDebito,templiqmetal.curValorCredito,templiqmetal.logLiquidado,templiqmetal.nitTercero,templiqmetal.strObservaciones,templiqmetal.lngIdUsuario,templiqmetal.dtmFechaModif,templiqmetal.LogAnticipo,templiqmetal.intNitConductor,templiqmetal.strConductor,datosTransaccion);
		}

		/// <summary>
		/// Creates a new TempLiqMetal object by passing all object's fields
		/// </summary>
		/// <param name="strPlaca">string that contents the strPlaca value for the TempLiqMetal object</param>
		/// <param name="strCuenta">char that contents the strCuenta value for the TempLiqMetal object</param>
		/// <param name="strDescripcion">char that contents the strDescripcion value for the TempLiqMetal object</param>
		/// <param name="intDocumento">int that contents the intDocumento value for the TempLiqMetal object</param>
		/// <param name="lngIdRegistroViaje">decimal that contents the lngIdRegistroViaje value for the TempLiqMetal object</param>
		/// <param name="dtmFechaAsignacion">DateTime that contents the dtmFechaAsignacion value for the TempLiqMetal object</param>
		/// <param name="curValorDebito">decimal that contents the curValorDebito value for the TempLiqMetal object</param>
		/// <param name="curValorCredito">decimal that contents the curValorCredito value for the TempLiqMetal object</param>
		/// <param name="logLiquidado">bool that contents the logLiquidado value for the TempLiqMetal object</param>
		/// <param name="nitTercero">char that contents the nitTercero value for the TempLiqMetal object</param>
		/// <param name="strObservaciones">string that contents the strObservaciones value for the TempLiqMetal object</param>
		/// <param name="lngIdUsuario">int that contents the lngIdUsuario value for the TempLiqMetal object</param>
		/// <param name="dtmFechaModif">DateTime that contents the dtmFechaModif value for the TempLiqMetal object</param>
		/// <param name="LogAnticipo">bool that contents the LogAnticipo value for the TempLiqMetal object</param>
		/// <param name="intNitConductor">decimal that contents the intNitConductor value for the TempLiqMetal object</param>
		/// <param name="strConductor">string that contents the strConductor value for the TempLiqMetal object</param>
		/// <returns>One TempLiqMetal object</returns>
		public TempLiqMetal Create(string strPlaca, char strCuenta, char? strDescripcion, int? intDocumento, decimal? lngIdRegistroViaje, DateTime? dtmFechaAsignacion, decimal? curValorDebito, decimal? curValorCredito, bool? logLiquidado, char? nitTercero, string strObservaciones, int? lngIdUsuario, DateTime? dtmFechaModif, bool? LogAnticipo, decimal? intNitConductor, string strConductor, Sinapsys.Datos.SQL datosTransaccion=null)
		{
			try 
			{
				TempLiqMetal templiqmetal = new TempLiqMetal();

				templiqmetal.strPlaca = strPlaca;
				templiqmetal.strCuenta = strCuenta;
				templiqmetal.strDescripcion = strDescripcion;
				templiqmetal.intDocumento = intDocumento;
				templiqmetal.lngIdRegistroViaje = lngIdRegistroViaje;
				templiqmetal.dtmFechaAsignacion = dtmFechaAsignacion;
				templiqmetal.curValorDebito = curValorDebito;
				templiqmetal.curValorCredito = curValorCredito;
				templiqmetal.logLiquidado = logLiquidado;
				templiqmetal.nitTercero = nitTercero;
				templiqmetal.strObservaciones = strObservaciones;
				templiqmetal.lngIdUsuario = lngIdUsuario;
				templiqmetal.dtmFechaModif = dtmFechaModif;
				templiqmetal.LogAnticipo = LogAnticipo;
				templiqmetal.intNitConductor = intNitConductor;
				templiqmetal.strConductor = strConductor;
				TempLiqMetalDataProvider.Instance.Create(strPlaca, strCuenta, strDescripcion, intDocumento, lngIdRegistroViaje, dtmFechaAsignacion, curValorDebito, curValorCredito, logLiquidado, nitTercero, strObservaciones, lngIdUsuario, dtmFechaModif, LogAnticipo, intNitConductor, strConductor,"TempLiqMetal");

				return templiqmetal;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Gets all objects of TempLiqMetal
		/// </summary>
		/// <returns>One TempLiqMetalList object</returns>
		public TempLiqMetalList GetAll(bool generateUndo=false)
		{
			try 
			{
				TempLiqMetalList templiqmetallist = new TempLiqMetalList();
				DataTable dt = TempLiqMetalDataProvider.Instance.GetAll();
				foreach (DataRow dr in dt.Rows)
				{
					TempLiqMetal templiqmetal = new TempLiqMetal();
					ReadData(templiqmetal, dr, generateUndo);
					templiqmetallist.Add(templiqmetal);
				}
				return templiqmetallist;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Gets all objects of TempLiqMetal applying filter and sort criteria
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
		/// <returns>One TempLiqMetalList object</returns>
		public TempLiqMetalList GetFilter(int pagenum, int pagesize, string filter, string sort, string extablesfilter, string extablesfieldsfilter, string extablesrelationsfilter, string extablessort, string extablesfieldssort, string extablesrelationssort, bool generateUndo=false)
		{
			try 
			{
				TempLiqMetalList templiqmetallist = new TempLiqMetalList();

				DataTable dt = TempLiqMetalDataProvider.Instance.GetFilter(pagenum, pagesize, filter, sort, extablesfilter, extablesfieldsfilter, extablesrelationsfilter, extablessort, extablesfieldssort, extablesrelationssort);

				foreach (DataRow dr in dt.Rows)
				{
					TempLiqMetal templiqmetal = new TempLiqMetal();
					ReadData(templiqmetal, dr, generateUndo);
					templiqmetallist.Add(templiqmetal);
				}
				return templiqmetallist;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public TempLiqMetalList GetFilter( string filter, string sort, bool generateUndo=false)
		{
			return GetFilter(0,0, filter, sort, "","","","","","",generateUndo);
		}

		public TempLiqMetalList GetFilter(string filter, string sort, string extablesfilter, string extablesfieldsfilter, string extablesrelationsfilter, string extablessort, string extablesfieldssort, string extablesrelationssort, bool generateUndo=false)
		{
			return GetFilter(0,0, filter, sort, extablesfilter, extablesfieldsfilter, extablesrelationsfilter, extablessort, extablesfieldssort, extablesrelationssort,generateUndo);
		}


		/// <summary>
		/// Returns the type for one property
		/// </summary>
		/// <param name="propertyname">Property's name for return its value</param>
		/// <returns>A value for the <paramref name="propertyname"/></returns>
		public Type GetMethodType( string propertyname,TempLiqMetal templiqmetal)
		{
			// Perform the search for the property's value
			switch (propertyname)
			{
				case "strPlaca":
					return templiqmetal.strPlaca.GetType();

				case "strCuenta":
					return templiqmetal.strCuenta.GetType();

				case "strDescripcion":
					return templiqmetal.strDescripcion.GetType();

				case "intDocumento":
					return templiqmetal.intDocumento.GetType();

				case "lngIdRegistroViaje":
					return templiqmetal.lngIdRegistroViaje.GetType();

				case "dtmFechaAsignacion":
					return templiqmetal.dtmFechaAsignacion.GetType();

				case "curValorDebito":
					return templiqmetal.curValorDebito.GetType();

				case "curValorCredito":
					return templiqmetal.curValorCredito.GetType();

				case "logLiquidado":
					return templiqmetal.logLiquidado.GetType();

				case "nitTercero":
					return templiqmetal.nitTercero.GetType();

				case "strObservaciones":
					return templiqmetal.strObservaciones.GetType();

				case "lngIdUsuario":
					return templiqmetal.lngIdUsuario.GetType();

				case "dtmFechaModif":
					return templiqmetal.dtmFechaModif.GetType();

				case "LogAnticipo":
					return templiqmetal.LogAnticipo.GetType();

				case "intNitConductor":
					return templiqmetal.intNitConductor.GetType();

				case "strConductor":
					return templiqmetal.strConductor.GetType();

			}

			return null;
		}
		/// <summary>
		/// update the changes in TempLiqMetal object by passing the object
		/// </summary>
		public bool UpdateChanges(TempLiqMetal templiqmetal, out string error,Sinapsys.Datos.SQL datosTransaccion=null)
		{
			if (templiqmetal.OldTempLiqMetal == null)
			{
				    error = "No tiene objeto con el cual comparar";
				    return false;
			}
			string[] Fields = templiqmetal.FieldChanged();
			error = "";
			return LiqViajes_Bll_Data.DataProvider.UpdateFieldsbyObject(Fields, templiqmetal, out error,datosTransaccion);
		}
	}

	#endregion

}
