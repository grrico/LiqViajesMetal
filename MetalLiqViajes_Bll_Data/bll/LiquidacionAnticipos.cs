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
	#region LiquidacionAnticiposController

	/// <summary>
	/// Class for convert data from database into object's data and vice versa
	/// </summary>
	public partial class LiquidacionAnticiposController//: ILatinodeController
	{
		/// <summary>
		/// Generic Constructor
		/// </summary>
		public LiquidacionAnticiposController()
		{
		}

		/// <summary>
		/// Instance accessor for this singleton
		/// </summary>
		private static LiquidacionAnticiposController MySingleObj;
		public static LiquidacionAnticiposController Instance
		{
			get
			{
				if (MySingleObj == null)
				{
					MySingleObj = new LiquidacionAnticiposController();
				}
				return MySingleObj;
			}
		}

		// Reads object's data from a DataRow
		private void ReadData(LiquidacionAnticipos liquidacionanticipos, DataRow dr,bool generateUndo=false)
		{
			try 
			{
				liquidacionanticipos.lngIdRegistroViaje = (int) dr["lngIdRegistroViaje"];
				liquidacionanticipos.lngIdRegistroViajeTramo = (decimal) dr["lngIdRegistroViajeTramo"];
				liquidacionanticipos.intNitConductor = (decimal) dr["intNitConductor"];
				liquidacionanticipos.strConductor = dr.IsNull("strConductor") ? null :(string) dr["strConductor"];
				liquidacionanticipos.strPlaca = (string) dr["strPlaca"];
				liquidacionanticipos.dtmFechaMovimiento = dr.IsNull("dtmFechaMovimiento") ? null :(DateTime?) dr["dtmFechaMovimiento"];
				liquidacionanticipos.lngIdBanco = (double) dr["lngIdBanco"];
				liquidacionanticipos.strdescripcionBanco = dr.IsNull("strdescripcionBanco") ? null :(string) dr["strdescripcionBanco"];
				liquidacionanticipos.intDocumento = (int) dr["intDocumento"];
				liquidacionanticipos.strModelo = (string) dr["strModelo"];
				liquidacionanticipos.strtipo = (string) dr["strtipo"];
				liquidacionanticipos.sw = dr.IsNull("sw") ? null :(byte?) dr["sw"];
				liquidacionanticipos.dtmFechaMovDMS = dr.IsNull("dtmFechaMovDMS") ? null :(DateTime?) dr["dtmFechaMovDMS"];
				liquidacionanticipos.strCuenta = dr.IsNull("strCuenta") ? null :(string) dr["strCuenta"];
				liquidacionanticipos.strCuenta2 = dr.IsNull("strCuenta2") ? null :(string) dr["strCuenta2"];
				liquidacionanticipos.strdescripcionCuenta = dr.IsNull("strdescripcionCuenta") ? null :(string) dr["strdescripcionCuenta"];
				liquidacionanticipos.strdescripcionCuenta2 = dr.IsNull("strdescripcionCuenta2") ? null :(string) dr["strdescripcionCuenta2"];
				liquidacionanticipos.curValor = dr.IsNull("curValor") ? null :(decimal?) dr["curValor"];
				liquidacionanticipos.strdescripcionModelo = dr.IsNull("strdescripcionModelo") ? null :(string) dr["strdescripcionModelo"];
				liquidacionanticipos.strNota = dr.IsNull("strNota") ? null :(string) dr["strNota"];
				liquidacionanticipos.strdocumento = dr.IsNull("strdocumento") ? null :(string) dr["strdocumento"];
				liquidacionanticipos.strUsuarioDMS = dr.IsNull("strUsuarioDMS") ? null :(string) dr["strUsuarioDMS"];
				liquidacionanticipos.dtmfechahoraSYSDMS = dr.IsNull("dtmfechahoraSYSDMS") ? null :(DateTime?) dr["dtmfechahoraSYSDMS"];
				liquidacionanticipos.intUsuario = dr.IsNull("intUsuario") ? null :(int?) dr["intUsuario"];
				liquidacionanticipos.dtmFechaModif = dr.IsNull("dtmFechaModif") ? null :(DateTime?) dr["dtmFechaModif"];
				liquidacionanticipos.logAnulado = dr.IsNull("logAnulado") ? null :(bool?) dr["logAnulado"];
				liquidacionanticipos.logLiquidado = dr.IsNull("logLiquidado") ? null :(bool?) dr["logLiquidado"];
			}
			catch (Exception ex)
			{
				Utilidades.LogErrores(ex.Message + (ex.InnerException != null ? ex.InnerException.Message : ""), DataProvider.AplicacionNombre);
				throw ex;
			}
			if (generateUndo) liquidacionanticipos.GenerateUndo();
		}

		/// <summary>
		/// Create a new LiquidacionAnticipos object by passing a object
		/// </summary>
		public LiquidacionAnticipos Create(LiquidacionAnticipos liquidacionanticipos, Sinapsys.Datos.SQL datosTransaccion=null)
		{
			return Create(liquidacionanticipos.lngIdRegistroViaje,liquidacionanticipos.lngIdRegistroViajeTramo,liquidacionanticipos.intNitConductor,liquidacionanticipos.strPlaca,liquidacionanticipos.lngIdBanco,liquidacionanticipos.intDocumento,liquidacionanticipos.strModelo,liquidacionanticipos.strtipo,liquidacionanticipos.strConductor,liquidacionanticipos.dtmFechaMovimiento,liquidacionanticipos.strdescripcionBanco,liquidacionanticipos.sw,liquidacionanticipos.dtmFechaMovDMS,liquidacionanticipos.strCuenta,liquidacionanticipos.strCuenta2,liquidacionanticipos.strdescripcionCuenta,liquidacionanticipos.strdescripcionCuenta2,liquidacionanticipos.curValor,liquidacionanticipos.strdescripcionModelo,liquidacionanticipos.strNota,liquidacionanticipos.strdocumento,liquidacionanticipos.strUsuarioDMS,liquidacionanticipos.dtmfechahoraSYSDMS,liquidacionanticipos.intUsuario,liquidacionanticipos.dtmFechaModif,liquidacionanticipos.logAnulado,liquidacionanticipos.logLiquidado,datosTransaccion);
		}

		/// <summary>
		/// Creates a new LiquidacionAnticipos object by passing all object's fields
		/// </summary>
		/// <param name="strConductor">string that contents the strConductor value for the LiquidacionAnticipos object</param>
		/// <param name="dtmFechaMovimiento">DateTime that contents the dtmFechaMovimiento value for the LiquidacionAnticipos object</param>
		/// <param name="strdescripcionBanco">string that contents the strdescripcionBanco value for the LiquidacionAnticipos object</param>
		/// <param name="sw">byte that contents the sw value for the LiquidacionAnticipos object</param>
		/// <param name="dtmFechaMovDMS">DateTime that contents the dtmFechaMovDMS value for the LiquidacionAnticipos object</param>
		/// <param name="strCuenta">string that contents the strCuenta value for the LiquidacionAnticipos object</param>
		/// <param name="strCuenta2">string that contents the strCuenta2 value for the LiquidacionAnticipos object</param>
		/// <param name="strdescripcionCuenta">string that contents the strdescripcionCuenta value for the LiquidacionAnticipos object</param>
		/// <param name="strdescripcionCuenta2">string that contents the strdescripcionCuenta2 value for the LiquidacionAnticipos object</param>
		/// <param name="curValor">decimal that contents the curValor value for the LiquidacionAnticipos object</param>
		/// <param name="strdescripcionModelo">string that contents the strdescripcionModelo value for the LiquidacionAnticipos object</param>
		/// <param name="strNota">string that contents the strNota value for the LiquidacionAnticipos object</param>
		/// <param name="strdocumento">string that contents the strdocumento value for the LiquidacionAnticipos object</param>
		/// <param name="strUsuarioDMS">string that contents the strUsuarioDMS value for the LiquidacionAnticipos object</param>
		/// <param name="dtmfechahoraSYSDMS">DateTime that contents the dtmfechahoraSYSDMS value for the LiquidacionAnticipos object</param>
		/// <param name="intUsuario">int that contents the intUsuario value for the LiquidacionAnticipos object</param>
		/// <param name="dtmFechaModif">DateTime that contents the dtmFechaModif value for the LiquidacionAnticipos object</param>
		/// <param name="logAnulado">bool that contents the logAnulado value for the LiquidacionAnticipos object</param>
		/// <param name="logLiquidado">bool that contents the logLiquidado value for the LiquidacionAnticipos object</param>
		/// <returns>One LiquidacionAnticipos object</returns>
		public LiquidacionAnticipos Create(int lngIdRegistroViaje, decimal lngIdRegistroViajeTramo, decimal intNitConductor, string strPlaca, double lngIdBanco, int intDocumento, string strModelo, string strtipo, string strConductor, DateTime? dtmFechaMovimiento, string strdescripcionBanco, byte? sw, DateTime? dtmFechaMovDMS, string strCuenta, string strCuenta2, string strdescripcionCuenta, string strdescripcionCuenta2, decimal? curValor, string strdescripcionModelo, string strNota, string strdocumento, string strUsuarioDMS, DateTime? dtmfechahoraSYSDMS, int? intUsuario, DateTime? dtmFechaModif, bool? logAnulado, bool? logLiquidado, Sinapsys.Datos.SQL datosTransaccion=null)
		{
			try 
			{
				LiquidacionAnticipos liquidacionanticipos = new LiquidacionAnticipos();

				liquidacionanticipos.lngIdRegistroViaje = lngIdRegistroViaje;
				liquidacionanticipos.lngIdRegistroViaje = lngIdRegistroViaje;
				liquidacionanticipos.lngIdRegistroViajeTramo = lngIdRegistroViajeTramo;
				liquidacionanticipos.intNitConductor = intNitConductor;
				liquidacionanticipos.strPlaca = strPlaca;
				liquidacionanticipos.lngIdBanco = lngIdBanco;
				liquidacionanticipos.intDocumento = intDocumento;
				liquidacionanticipos.strModelo = strModelo;
				liquidacionanticipos.strtipo = strtipo;
				liquidacionanticipos.strConductor = strConductor;
				liquidacionanticipos.dtmFechaMovimiento = dtmFechaMovimiento;
				liquidacionanticipos.strdescripcionBanco = strdescripcionBanco;
				liquidacionanticipos.sw = sw;
				liquidacionanticipos.dtmFechaMovDMS = dtmFechaMovDMS;
				liquidacionanticipos.strCuenta = strCuenta;
				liquidacionanticipos.strCuenta2 = strCuenta2;
				liquidacionanticipos.strdescripcionCuenta = strdescripcionCuenta;
				liquidacionanticipos.strdescripcionCuenta2 = strdescripcionCuenta2;
				liquidacionanticipos.curValor = curValor;
				liquidacionanticipos.strdescripcionModelo = strdescripcionModelo;
				liquidacionanticipos.strNota = strNota;
				liquidacionanticipos.strdocumento = strdocumento;
				liquidacionanticipos.strUsuarioDMS = strUsuarioDMS;
				liquidacionanticipos.dtmfechahoraSYSDMS = dtmfechahoraSYSDMS;
				liquidacionanticipos.intUsuario = intUsuario;
				liquidacionanticipos.dtmFechaModif = dtmFechaModif;
				liquidacionanticipos.logAnulado = logAnulado;
				liquidacionanticipos.logLiquidado = logLiquidado;
				lngIdRegistroViaje = LiquidacionAnticiposDataProvider.Instance.Create(lngIdRegistroViaje, lngIdRegistroViajeTramo, intNitConductor, strPlaca, lngIdBanco, intDocumento, strModelo, strtipo, strConductor, dtmFechaMovimiento, strdescripcionBanco, sw, dtmFechaMovDMS, strCuenta, strCuenta2, strdescripcionCuenta, strdescripcionCuenta2, curValor, strdescripcionModelo, strNota, strdocumento, strUsuarioDMS, dtmfechahoraSYSDMS, intUsuario, dtmFechaModif, logAnulado, logLiquidado,"LiquidacionAnticipos",datosTransaccion);
				if (lngIdRegistroViaje == 0)
					return null;

				liquidacionanticipos.lngIdRegistroViaje = lngIdRegistroViaje;

				return liquidacionanticipos;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Updates an LiquidacionAnticipos object by passing all object's fields
		/// </summary>
		/// <param name="lngIdRegistroViaje">int that contents the lngIdRegistroViaje value for the LiquidacionAnticipos object</param>
		/// <param name="lngIdRegistroViajeTramo">decimal that contents the lngIdRegistroViajeTramo value for the LiquidacionAnticipos object</param>
		/// <param name="intNitConductor">decimal that contents the intNitConductor value for the LiquidacionAnticipos object</param>
		/// <param name="strConductor">string that contents the strConductor value for the LiquidacionAnticipos object</param>
		/// <param name="strPlaca">string that contents the strPlaca value for the LiquidacionAnticipos object</param>
		/// <param name="dtmFechaMovimiento">DateTime that contents the dtmFechaMovimiento value for the LiquidacionAnticipos object</param>
		/// <param name="lngIdBanco">double that contents the lngIdBanco value for the LiquidacionAnticipos object</param>
		/// <param name="strdescripcionBanco">string that contents the strdescripcionBanco value for the LiquidacionAnticipos object</param>
		/// <param name="intDocumento">int that contents the intDocumento value for the LiquidacionAnticipos object</param>
		/// <param name="strModelo">string that contents the strModelo value for the LiquidacionAnticipos object</param>
		/// <param name="strtipo">string that contents the strtipo value for the LiquidacionAnticipos object</param>
		/// <param name="sw">byte that contents the sw value for the LiquidacionAnticipos object</param>
		/// <param name="dtmFechaMovDMS">DateTime that contents the dtmFechaMovDMS value for the LiquidacionAnticipos object</param>
		/// <param name="strCuenta">string that contents the strCuenta value for the LiquidacionAnticipos object</param>
		/// <param name="strCuenta2">string that contents the strCuenta2 value for the LiquidacionAnticipos object</param>
		/// <param name="strdescripcionCuenta">string that contents the strdescripcionCuenta value for the LiquidacionAnticipos object</param>
		/// <param name="strdescripcionCuenta2">string that contents the strdescripcionCuenta2 value for the LiquidacionAnticipos object</param>
		/// <param name="curValor">decimal that contents the curValor value for the LiquidacionAnticipos object</param>
		/// <param name="strdescripcionModelo">string that contents the strdescripcionModelo value for the LiquidacionAnticipos object</param>
		/// <param name="strNota">string that contents the strNota value for the LiquidacionAnticipos object</param>
		/// <param name="strdocumento">string that contents the strdocumento value for the LiquidacionAnticipos object</param>
		/// <param name="strUsuarioDMS">string that contents the strUsuarioDMS value for the LiquidacionAnticipos object</param>
		/// <param name="dtmfechahoraSYSDMS">DateTime that contents the dtmfechahoraSYSDMS value for the LiquidacionAnticipos object</param>
		/// <param name="intUsuario">int that contents the intUsuario value for the LiquidacionAnticipos object</param>
		/// <param name="dtmFechaModif">DateTime that contents the dtmFechaModif value for the LiquidacionAnticipos object</param>
		/// <param name="logAnulado">bool that contents the logAnulado value for the LiquidacionAnticipos object</param>
		/// <param name="logLiquidado">bool that contents the logLiquidado value for the LiquidacionAnticipos object</param>
		public void Update(int lngIdRegistroViaje, decimal lngIdRegistroViajeTramo, decimal intNitConductor, string strConductor, string strPlaca, DateTime? dtmFechaMovimiento, double lngIdBanco, string strdescripcionBanco, int intDocumento, string strModelo, string strtipo, byte? sw, DateTime? dtmFechaMovDMS, string strCuenta, string strCuenta2, string strdescripcionCuenta, string strdescripcionCuenta2, decimal? curValor, string strdescripcionModelo, string strNota, string strdocumento, string strUsuarioDMS, DateTime? dtmfechahoraSYSDMS, int? intUsuario, DateTime? dtmFechaModif, bool? logAnulado, bool? logLiquidado, Sinapsys.Datos.SQL datosTransaccion=null)
		{
			try 
			{
				LiquidacionAnticipos new_values = new LiquidacionAnticipos();
				new_values.strConductor = strConductor;
				new_values.dtmFechaMovimiento = dtmFechaMovimiento;
				new_values.strdescripcionBanco = strdescripcionBanco;
				new_values.sw = sw;
				new_values.dtmFechaMovDMS = dtmFechaMovDMS;
				new_values.strCuenta = strCuenta;
				new_values.strCuenta2 = strCuenta2;
				new_values.strdescripcionCuenta = strdescripcionCuenta;
				new_values.strdescripcionCuenta2 = strdescripcionCuenta2;
				new_values.curValor = curValor;
				new_values.strdescripcionModelo = strdescripcionModelo;
				new_values.strNota = strNota;
				new_values.strdocumento = strdocumento;
				new_values.strUsuarioDMS = strUsuarioDMS;
				new_values.dtmfechahoraSYSDMS = dtmfechahoraSYSDMS;
				new_values.intUsuario = intUsuario;
				new_values.dtmFechaModif = dtmFechaModif;
				new_values.logAnulado = logAnulado;
				new_values.logLiquidado = logLiquidado;
				LiquidacionAnticiposDataProvider.Instance.Update(lngIdRegistroViaje, lngIdRegistroViajeTramo, intNitConductor, strConductor, strPlaca, dtmFechaMovimiento, lngIdBanco, strdescripcionBanco, intDocumento, strModelo, strtipo, sw, dtmFechaMovDMS, strCuenta, strCuenta2, strdescripcionCuenta, strdescripcionCuenta2, curValor, strdescripcionModelo, strNota, strdocumento, strUsuarioDMS, dtmfechahoraSYSDMS, intUsuario, dtmFechaModif, logAnulado, logLiquidado,"LiquidacionAnticipos",datosTransaccion);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Updates an LiquidacionAnticipos object by passing one object's instance as reference
		/// </summary>
		/// <param name="liquidacionanticipos">An instance of LiquidacionAnticipos for reference</param>
		public void Update(LiquidacionAnticipos liquidacionanticipos,Sinapsys.Datos.SQL datosTransaccion=null)
		{
			Update(liquidacionanticipos.lngIdRegistroViaje, liquidacionanticipos.lngIdRegistroViajeTramo, liquidacionanticipos.intNitConductor, liquidacionanticipos.strConductor, liquidacionanticipos.strPlaca, liquidacionanticipos.dtmFechaMovimiento, liquidacionanticipos.lngIdBanco, liquidacionanticipos.strdescripcionBanco, liquidacionanticipos.intDocumento, liquidacionanticipos.strModelo, liquidacionanticipos.strtipo, liquidacionanticipos.sw, liquidacionanticipos.dtmFechaMovDMS, liquidacionanticipos.strCuenta, liquidacionanticipos.strCuenta2, liquidacionanticipos.strdescripcionCuenta, liquidacionanticipos.strdescripcionCuenta2, liquidacionanticipos.curValor, liquidacionanticipos.strdescripcionModelo, liquidacionanticipos.strNota, liquidacionanticipos.strdocumento, liquidacionanticipos.strUsuarioDMS, liquidacionanticipos.dtmfechahoraSYSDMS, liquidacionanticipos.intUsuario, liquidacionanticipos.dtmFechaModif, liquidacionanticipos.logAnulado, liquidacionanticipos.logLiquidado);
		}

		/// <summary>
		/// Delete  the LiquidacionAnticipos object by passing a object
		/// </summary>
		public void  Delete(LiquidacionAnticipos liquidacionanticipos, Sinapsys.Datos.SQL datosTransaccion=null)
		{
			Delete(liquidacionanticipos.lngIdRegistroViaje, liquidacionanticipos.lngIdRegistroViajeTramo, liquidacionanticipos.intNitConductor, liquidacionanticipos.strPlaca, liquidacionanticipos.lngIdBanco, liquidacionanticipos.intDocumento, liquidacionanticipos.strModelo, liquidacionanticipos.strtipo,datosTransaccion);
		}

		/// <summary>
		/// Deletes the LiquidacionAnticipos object by passing one object's instance as reference
		/// </summary>
		/// <param name="liquidacionanticipos">An instance of LiquidacionAnticipos for reference</param>
		public void Delete(int lngIdRegistroViaje, decimal lngIdRegistroViajeTramo, decimal intNitConductor, string strPlaca, double lngIdBanco, int intDocumento, string strModelo, string strtipo, Sinapsys.Datos.SQL datosTransaccion=null)
		{
			try 
			{
				//LiquidacionAnticipos old_values = LiquidacionAnticiposController.Instance.Get(lngIdRegistroViaje);
				//if(!Validate.security.CanDeleteSecurityField(LiquidacionAnticiposController.Instance, (ILatinodeObject)old_values))
				//    throw new Exception("Access denied by security field, you can't delete object");

				LiquidacionAnticiposDataProvider.Instance.Delete(lngIdRegistroViaje, lngIdRegistroViajeTramo, intNitConductor, strPlaca, lngIdBanco, intDocumento, strModelo, strtipo,"LiquidacionAnticipos");
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Deletes the LiquidacionAnticipos object by passing CVS parameter as reference
		/// </summary>
		/// <param name="liquidacionanticipos">An instance of LiquidacionAnticipos for reference</param>
		public void Delete(string CVSParameter)
		{
			string[] StrCommand=CVSParameter.Split(',');
			try 
			{
				int lngIdRegistroViaje=int.Parse(StrCommand[0]);
				decimal lngIdRegistroViajeTramo=decimal.Parse(StrCommand[1]);
				decimal intNitConductor=decimal.Parse(StrCommand[2]);
				string strPlaca=StrCommand[3];
				double lngIdBanco=double.Parse(StrCommand[4]);
				int intDocumento=int.Parse(StrCommand[5]);
				string strModelo=StrCommand[6];
				string strtipo=StrCommand[7];
				LiquidacionAnticiposDataProvider.Instance.Delete(lngIdRegistroViaje, lngIdRegistroViajeTramo, intNitConductor, strPlaca, lngIdBanco, intDocumento, strModelo, strtipo,"LiquidacionAnticipos");
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Gets the LiquidacionAnticipos object by passing the object's key fields
		/// </summary>
		/// <param name="lngIdRegistroViaje">int that contents the lngIdRegistroViaje value for the LiquidacionAnticipos object</param>
		/// <param name="lngIdRegistroViajeTramo">decimal that contents the lngIdRegistroViajeTramo value for the LiquidacionAnticipos object</param>
		/// <param name="intNitConductor">decimal that contents the intNitConductor value for the LiquidacionAnticipos object</param>
		/// <param name="strPlaca">string that contents the strPlaca value for the LiquidacionAnticipos object</param>
		/// <param name="lngIdBanco">double that contents the lngIdBanco value for the LiquidacionAnticipos object</param>
		/// <param name="intDocumento">int that contents the intDocumento value for the LiquidacionAnticipos object</param>
		/// <param name="strModelo">string that contents the strModelo value for the LiquidacionAnticipos object</param>
		/// <param name="strtipo">string that contents the strtipo value for the LiquidacionAnticipos object</param>
		/// <returns>One LiquidacionAnticipos object</returns>
		public LiquidacionAnticipos Get(int lngIdRegistroViaje, decimal lngIdRegistroViajeTramo, decimal intNitConductor, string strPlaca, double lngIdBanco, int intDocumento, string strModelo, string strtipo, bool generateUndo=false)
		{
			try 
			{
				LiquidacionAnticipos liquidacionanticipos = null;
				DataTable dt = LiquidacionAnticiposDataProvider.Instance.Get(lngIdRegistroViaje, lngIdRegistroViajeTramo, intNitConductor, strPlaca, lngIdBanco, intDocumento, strModelo, strtipo);
				if ((dt.Rows.Count > 0))
				{
					liquidacionanticipos = new LiquidacionAnticipos();
					DataRow dr = dt.Rows[0];
					ReadData(liquidacionanticipos, dr, generateUndo);
				}


				return liquidacionanticipos;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Gets all objects of LiquidacionAnticipos
		/// </summary>
		/// <returns>One LiquidacionAnticiposList object</returns>
		public LiquidacionAnticiposList GetAll(bool generateUndo=false)
		{
			try 
			{
				LiquidacionAnticiposList liquidacionanticiposlist = new LiquidacionAnticiposList();
				DataTable dt = LiquidacionAnticiposDataProvider.Instance.GetAll();
				foreach (DataRow dr in dt.Rows)
				{
					LiquidacionAnticipos liquidacionanticipos = new LiquidacionAnticipos();
					ReadData(liquidacionanticipos, dr, generateUndo);
					liquidacionanticiposlist.Add(liquidacionanticipos);
				}
				return liquidacionanticiposlist;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Gets all objects of LiquidacionAnticipos applying filter and sort criteria
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
		/// <returns>One LiquidacionAnticiposList object</returns>
		public LiquidacionAnticiposList GetFilter(int pagenum, int pagesize, string filter, string sort, string extablesfilter, string extablesfieldsfilter, string extablesrelationsfilter, string extablessort, string extablesfieldssort, string extablesrelationssort, bool generateUndo=false)
		{
			try 
			{
				LiquidacionAnticiposList liquidacionanticiposlist = new LiquidacionAnticiposList();

				DataTable dt = LiquidacionAnticiposDataProvider.Instance.GetFilter(pagenum, pagesize, filter, sort, extablesfilter, extablesfieldsfilter, extablesrelationsfilter, extablessort, extablesfieldssort, extablesrelationssort);

				foreach (DataRow dr in dt.Rows)
				{
					LiquidacionAnticipos liquidacionanticipos = new LiquidacionAnticipos();
					ReadData(liquidacionanticipos, dr, generateUndo);
					liquidacionanticiposlist.Add(liquidacionanticipos);
				}
				return liquidacionanticiposlist;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public LiquidacionAnticiposList GetFilter( string filter, string sort, bool generateUndo=false)
		{
			return GetFilter(0,0, filter, sort, "","","","","","",generateUndo);
		}

		public LiquidacionAnticiposList GetFilter(string filter, string sort, string extablesfilter, string extablesfieldsfilter, string extablesrelationsfilter, string extablessort, string extablesfieldssort, string extablesrelationssort, bool generateUndo=false)
		{
			return GetFilter(0,0, filter, sort, extablesfilter, extablesfieldsfilter, extablesrelationsfilter, extablessort, extablesfieldssort, extablesrelationssort,generateUndo);
		}


		/// <summary>
		/// Returns the type for one property
		/// </summary>
		/// <param name="propertyname">Property's name for return its value</param>
		/// <returns>A value for the <paramref name="propertyname"/></returns>
		public Type GetMethodType( string propertyname,LiquidacionAnticipos liquidacionanticipos)
		{
			// Perform the search for the property's value
			switch (propertyname)
			{
				case "lngIdRegistroViaje":
					return liquidacionanticipos.lngIdRegistroViaje.GetType();

				case "lngIdRegistroViajeTramo":
					return liquidacionanticipos.lngIdRegistroViajeTramo.GetType();

				case "intNitConductor":
					return liquidacionanticipos.intNitConductor.GetType();

				case "strConductor":
					return liquidacionanticipos.strConductor.GetType();

				case "strPlaca":
					return liquidacionanticipos.strPlaca.GetType();

				case "dtmFechaMovimiento":
					return liquidacionanticipos.dtmFechaMovimiento.GetType();

				case "lngIdBanco":
					return liquidacionanticipos.lngIdBanco.GetType();

				case "strdescripcionBanco":
					return liquidacionanticipos.strdescripcionBanco.GetType();

				case "intDocumento":
					return liquidacionanticipos.intDocumento.GetType();

				case "strModelo":
					return liquidacionanticipos.strModelo.GetType();

				case "strtipo":
					return liquidacionanticipos.strtipo.GetType();

				case "sw":
					return liquidacionanticipos.sw.GetType();

				case "dtmFechaMovDMS":
					return liquidacionanticipos.dtmFechaMovDMS.GetType();

				case "strCuenta":
					return liquidacionanticipos.strCuenta.GetType();

				case "strCuenta2":
					return liquidacionanticipos.strCuenta2.GetType();

				case "strdescripcionCuenta":
					return liquidacionanticipos.strdescripcionCuenta.GetType();

				case "strdescripcionCuenta2":
					return liquidacionanticipos.strdescripcionCuenta2.GetType();

				case "curValor":
					return liquidacionanticipos.curValor.GetType();

				case "strdescripcionModelo":
					return liquidacionanticipos.strdescripcionModelo.GetType();

				case "strNota":
					return liquidacionanticipos.strNota.GetType();

				case "strdocumento":
					return liquidacionanticipos.strdocumento.GetType();

				case "strUsuarioDMS":
					return liquidacionanticipos.strUsuarioDMS.GetType();

				case "dtmfechahoraSYSDMS":
					return liquidacionanticipos.dtmfechahoraSYSDMS.GetType();

				case "intUsuario":
					return liquidacionanticipos.intUsuario.GetType();

				case "dtmFechaModif":
					return liquidacionanticipos.dtmFechaModif.GetType();

				case "logAnulado":
					return liquidacionanticipos.logAnulado.GetType();

				case "logLiquidado":
					return liquidacionanticipos.logLiquidado.GetType();

			}

			return null;
		}
		/// <summary>
		/// update the changes in LiquidacionAnticipos object by passing the object
		/// </summary>
		public bool UpdateChanges(LiquidacionAnticipos liquidacionanticipos, out string error,Sinapsys.Datos.SQL datosTransaccion=null)
		{
			if (liquidacionanticipos.OldLiquidacionAnticipos == null)
			{
				    error = "No tiene objeto con el cual comparar";
				    return false;
			}
			string[] Fields = liquidacionanticipos.FieldChanged();
			error = "";
			return LiqViajes_Bll_Data.DataProvider.UpdateFieldsbyObject(Fields, liquidacionanticipos, out error,datosTransaccion);
		}
	}

	#endregion

}
