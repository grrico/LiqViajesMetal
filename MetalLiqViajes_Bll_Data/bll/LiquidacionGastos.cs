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
	#region LiquidacionGastosController

	/// <summary>
	/// Class for convert data from database into object's data and vice versa
	/// </summary>
	public partial class LiquidacionGastosController//: ILatinodeController
	{
		/// <summary>
		/// Generic Constructor
		/// </summary>
		public LiquidacionGastosController()
		{
		}

		/// <summary>
		/// Instance accessor for this singleton
		/// </summary>
		private static LiquidacionGastosController MySingleObj;
		public static LiquidacionGastosController Instance
		{
			get
			{
				if (MySingleObj == null)
				{
					MySingleObj = new LiquidacionGastosController();
				}
				return MySingleObj;
			}
		}

		// Reads object's data from a DataRow
		private void ReadData(LiquidacionGastos liquidaciongastos, DataRow dr,bool generateUndo=false)
		{
			try 
			{
				liquidaciongastos.strDescripcionCuenta = dr.IsNull("strDescripcionCuenta") ? null :(string) dr["strDescripcionCuenta"];
				liquidaciongastos.strDescripcion = dr.IsNull("strDescripcion") ? null :(string) dr["strDescripcion"];
				liquidaciongastos.dtmFechaAsignacion = dr.IsNull("dtmFechaAsignacion") ? null :(DateTime?) dr["dtmFechaAsignacion"];
				liquidaciongastos.curValorTramo = dr.IsNull("curValorTramo") ? null :(decimal?) dr["curValorTramo"];
				liquidaciongastos.curValorAdicional = dr.IsNull("curValorAdicional") ? null :(decimal?) dr["curValorAdicional"];
				liquidaciongastos.curValorTotal = dr.IsNull("curValorTotal") ? null :(decimal?) dr["curValorTotal"];
				liquidaciongastos.strObservaciones = dr.IsNull("strObservaciones") ? null :(string) dr["strObservaciones"];
				liquidaciongastos.nitTercero = dr.IsNull("nitTercero") ? null :(string) dr["nitTercero"];
				liquidaciongastos.strPlaca = dr.IsNull("strPlaca") ? null :(string) dr["strPlaca"];
				liquidaciongastos.lngIdUsuario = dr.IsNull("lngIdUsuario") ? null :(int?) dr["lngIdUsuario"];
				liquidaciongastos.logLiquidado = dr.IsNull("logLiquidado") ? null :(bool?) dr["logLiquidado"];
				liquidaciongastos.dtmFechaSalida = dr.IsNull("dtmFechaSalida") ? null :(DateTime?) dr["dtmFechaSalida"];
				liquidaciongastos.dtmFechaLlegada = dr.IsNull("dtmFechaLlegada") ? null :(DateTime?) dr["dtmFechaLlegada"];
				liquidaciongastos.dtmFechaModif = dr.IsNull("dtmFechaModif") ? null :(DateTime?) dr["dtmFechaModif"];
				liquidaciongastos.LogExcluido = dr.IsNull("LogExcluido") ? null :(bool?) dr["LogExcluido"];
				liquidaciongastos.floGalones = dr.IsNull("floGalones") ? null :(decimal?) dr["floGalones"];
				liquidaciongastos.floGalonesAdicional = dr.IsNull("floGalonesAdicional") ? null :(decimal?) dr["floGalonesAdicional"];
				liquidaciongastos.floGalonesReales = dr.IsNull("floGalonesReales") ? null :(decimal?) dr["floGalonesReales"];
				liquidaciongastos.curValorGalon = dr.IsNull("curValorGalon") ? null :(decimal?) dr["curValorGalon"];
				liquidaciongastos.CombustibleCarretera = dr.IsNull("CombustibleCarretera") ? null :(decimal?) dr["CombustibleCarretera"];
				liquidaciongastos.cutCombustible = dr.IsNull("cutCombustible") ? null :(decimal?) dr["cutCombustible"];
				liquidaciongastos.LogAnticipoACPM = dr.IsNull("LogAnticipoACPM") ? null :(bool?) dr["LogAnticipoACPM"];
				liquidaciongastos.AntipoConductor = dr.IsNull("AntipoConductor") ? null :(bool?) dr["AntipoConductor"];
				liquidaciongastos.lngIdRegistrRutaItemId = (int) dr["lngIdRegistrRutaItemId"];
				liquidaciongastos.lngIdRegistroViaje = (decimal) dr["lngIdRegistroViaje"];
				liquidaciongastos.lngIdRegistrRuta = (int) dr["lngIdRegistrRuta"];
				liquidaciongastos.strCuenta = (string) dr["strCuenta"];
				liquidaciongastos.intRowRegistro = (int) dr["intRowRegistro"];
			}
			catch (Exception ex)
			{
				Utilidades.LogErrores(ex.Message + (ex.InnerException != null ? ex.InnerException.Message : ""), DataProvider.AplicacionNombre);
				throw ex;
			}
			if (generateUndo) liquidaciongastos.GenerateUndo();
		}

		/// <summary>
		/// Create a new LiquidacionGastos object by passing a object
		/// </summary>
		public LiquidacionGastos Create(LiquidacionGastos liquidaciongastos, Sinapsys.Datos.SQL datosTransaccion=null)
		{
			return Create(liquidaciongastos.lngIdRegistrRutaItemId,liquidaciongastos.lngIdRegistroViaje,liquidaciongastos.lngIdRegistrRuta,liquidaciongastos.strCuenta,liquidaciongastos.intRowRegistro,liquidaciongastos.strDescripcionCuenta,liquidaciongastos.strDescripcion,liquidaciongastos.dtmFechaAsignacion,liquidaciongastos.curValorTramo,liquidaciongastos.curValorAdicional,liquidaciongastos.curValorTotal,liquidaciongastos.strObservaciones,liquidaciongastos.nitTercero,liquidaciongastos.strPlaca,liquidaciongastos.lngIdUsuario,liquidaciongastos.logLiquidado,liquidaciongastos.dtmFechaSalida,liquidaciongastos.dtmFechaLlegada,liquidaciongastos.dtmFechaModif,liquidaciongastos.LogExcluido,liquidaciongastos.floGalones,liquidaciongastos.floGalonesAdicional,liquidaciongastos.floGalonesReales,liquidaciongastos.curValorGalon,liquidaciongastos.CombustibleCarretera,liquidaciongastos.cutCombustible,liquidaciongastos.LogAnticipoACPM,liquidaciongastos.AntipoConductor,datosTransaccion);
		}

		/// <summary>
		/// Creates a new LiquidacionGastos object by passing all object's fields
		/// </summary>
		/// <param name="strDescripcionCuenta">string that contents the strDescripcionCuenta value for the LiquidacionGastos object</param>
		/// <param name="strDescripcion">string that contents the strDescripcion value for the LiquidacionGastos object</param>
		/// <param name="dtmFechaAsignacion">DateTime that contents the dtmFechaAsignacion value for the LiquidacionGastos object</param>
		/// <param name="curValorTramo">decimal that contents the curValorTramo value for the LiquidacionGastos object</param>
		/// <param name="curValorAdicional">decimal that contents the curValorAdicional value for the LiquidacionGastos object</param>
		/// <param name="curValorTotal">decimal that contents the curValorTotal value for the LiquidacionGastos object</param>
		/// <param name="strObservaciones">string that contents the strObservaciones value for the LiquidacionGastos object</param>
		/// <param name="nitTercero">string that contents the nitTercero value for the LiquidacionGastos object</param>
		/// <param name="strPlaca">string that contents the strPlaca value for the LiquidacionGastos object</param>
		/// <param name="lngIdUsuario">int that contents the lngIdUsuario value for the LiquidacionGastos object</param>
		/// <param name="logLiquidado">bool that contents the logLiquidado value for the LiquidacionGastos object</param>
		/// <param name="dtmFechaSalida">DateTime that contents the dtmFechaSalida value for the LiquidacionGastos object</param>
		/// <param name="dtmFechaLlegada">DateTime that contents the dtmFechaLlegada value for the LiquidacionGastos object</param>
		/// <param name="dtmFechaModif">DateTime that contents the dtmFechaModif value for the LiquidacionGastos object</param>
		/// <param name="LogExcluido">bool that contents the LogExcluido value for the LiquidacionGastos object</param>
		/// <param name="floGalones">decimal that contents the floGalones value for the LiquidacionGastos object</param>
		/// <param name="floGalonesAdicional">decimal that contents the floGalonesAdicional value for the LiquidacionGastos object</param>
		/// <param name="floGalonesReales">decimal that contents the floGalonesReales value for the LiquidacionGastos object</param>
		/// <param name="curValorGalon">decimal that contents the curValorGalon value for the LiquidacionGastos object</param>
		/// <param name="CombustibleCarretera">decimal that contents the CombustibleCarretera value for the LiquidacionGastos object</param>
		/// <param name="cutCombustible">decimal that contents the cutCombustible value for the LiquidacionGastos object</param>
		/// <param name="LogAnticipoACPM">bool that contents the LogAnticipoACPM value for the LiquidacionGastos object</param>
		/// <param name="AntipoConductor">bool that contents the AntipoConductor value for the LiquidacionGastos object</param>
		/// <returns>One LiquidacionGastos object</returns>
		public LiquidacionGastos Create(int lngIdRegistrRutaItemId, decimal lngIdRegistroViaje, int lngIdRegistrRuta, string strCuenta, int intRowRegistro, string strDescripcionCuenta, string strDescripcion, DateTime? dtmFechaAsignacion, decimal? curValorTramo, decimal? curValorAdicional, decimal? curValorTotal, string strObservaciones, string nitTercero, string strPlaca, int? lngIdUsuario, bool? logLiquidado, DateTime? dtmFechaSalida, DateTime? dtmFechaLlegada, DateTime? dtmFechaModif, bool? LogExcluido, decimal? floGalones, decimal? floGalonesAdicional, decimal? floGalonesReales, decimal? curValorGalon, decimal? CombustibleCarretera, decimal? cutCombustible, bool? LogAnticipoACPM, bool? AntipoConductor, Sinapsys.Datos.SQL datosTransaccion=null)
		{
			try 
			{
				LiquidacionGastos liquidaciongastos = new LiquidacionGastos();

				liquidaciongastos.lngIdRegistrRutaItemId = lngIdRegistrRutaItemId;
				liquidaciongastos.lngIdRegistroViaje = lngIdRegistroViaje;
				liquidaciongastos.lngIdRegistrRuta = lngIdRegistrRuta;
				liquidaciongastos.strCuenta = strCuenta;
				liquidaciongastos.intRowRegistro = intRowRegistro;
				liquidaciongastos.strDescripcionCuenta = strDescripcionCuenta;
				liquidaciongastos.strDescripcion = strDescripcion;
				liquidaciongastos.dtmFechaAsignacion = dtmFechaAsignacion;
				liquidaciongastos.curValorTramo = curValorTramo;
				liquidaciongastos.curValorAdicional = curValorAdicional;
				liquidaciongastos.curValorTotal = curValorTotal;
				liquidaciongastos.strObservaciones = strObservaciones;
				liquidaciongastos.nitTercero = nitTercero;
				liquidaciongastos.strPlaca = strPlaca;
				liquidaciongastos.lngIdUsuario = lngIdUsuario;
				liquidaciongastos.logLiquidado = logLiquidado;
				liquidaciongastos.dtmFechaSalida = dtmFechaSalida;
				liquidaciongastos.dtmFechaLlegada = dtmFechaLlegada;
				liquidaciongastos.dtmFechaModif = dtmFechaModif;
				liquidaciongastos.LogExcluido = LogExcluido;
				liquidaciongastos.floGalones = floGalones;
				liquidaciongastos.floGalonesAdicional = floGalonesAdicional;
				liquidaciongastos.floGalonesReales = floGalonesReales;
				liquidaciongastos.curValorGalon = curValorGalon;
				liquidaciongastos.CombustibleCarretera = CombustibleCarretera;
				liquidaciongastos.cutCombustible = cutCombustible;
				liquidaciongastos.LogAnticipoACPM = LogAnticipoACPM;
				liquidaciongastos.AntipoConductor = AntipoConductor;
				LiquidacionGastosDataProvider.Instance.Create(lngIdRegistrRutaItemId, lngIdRegistroViaje, lngIdRegistrRuta, strCuenta, intRowRegistro, strDescripcionCuenta, strDescripcion, dtmFechaAsignacion, curValorTramo, curValorAdicional, curValorTotal, strObservaciones, nitTercero, strPlaca, lngIdUsuario, logLiquidado, dtmFechaSalida, dtmFechaLlegada, dtmFechaModif, LogExcluido, floGalones, floGalonesAdicional, floGalonesReales, curValorGalon, CombustibleCarretera, cutCombustible, LogAnticipoACPM, AntipoConductor,"LiquidacionGastos");

				return liquidaciongastos;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Updates an LiquidacionGastos object by passing all object's fields
		/// </summary>
		/// <param name="strDescripcionCuenta">string that contents the strDescripcionCuenta value for the LiquidacionGastos object</param>
		/// <param name="strDescripcion">string that contents the strDescripcion value for the LiquidacionGastos object</param>
		/// <param name="dtmFechaAsignacion">DateTime that contents the dtmFechaAsignacion value for the LiquidacionGastos object</param>
		/// <param name="curValorTramo">decimal that contents the curValorTramo value for the LiquidacionGastos object</param>
		/// <param name="curValorAdicional">decimal that contents the curValorAdicional value for the LiquidacionGastos object</param>
		/// <param name="curValorTotal">decimal that contents the curValorTotal value for the LiquidacionGastos object</param>
		/// <param name="strObservaciones">string that contents the strObservaciones value for the LiquidacionGastos object</param>
		/// <param name="nitTercero">string that contents the nitTercero value for the LiquidacionGastos object</param>
		/// <param name="strPlaca">string that contents the strPlaca value for the LiquidacionGastos object</param>
		/// <param name="lngIdUsuario">int that contents the lngIdUsuario value for the LiquidacionGastos object</param>
		/// <param name="logLiquidado">bool that contents the logLiquidado value for the LiquidacionGastos object</param>
		/// <param name="dtmFechaSalida">DateTime that contents the dtmFechaSalida value for the LiquidacionGastos object</param>
		/// <param name="dtmFechaLlegada">DateTime that contents the dtmFechaLlegada value for the LiquidacionGastos object</param>
		/// <param name="dtmFechaModif">DateTime that contents the dtmFechaModif value for the LiquidacionGastos object</param>
		/// <param name="LogExcluido">bool that contents the LogExcluido value for the LiquidacionGastos object</param>
		/// <param name="floGalones">decimal that contents the floGalones value for the LiquidacionGastos object</param>
		/// <param name="floGalonesAdicional">decimal that contents the floGalonesAdicional value for the LiquidacionGastos object</param>
		/// <param name="floGalonesReales">decimal that contents the floGalonesReales value for the LiquidacionGastos object</param>
		/// <param name="curValorGalon">decimal that contents the curValorGalon value for the LiquidacionGastos object</param>
		/// <param name="CombustibleCarretera">decimal that contents the CombustibleCarretera value for the LiquidacionGastos object</param>
		/// <param name="cutCombustible">decimal that contents the cutCombustible value for the LiquidacionGastos object</param>
		/// <param name="LogAnticipoACPM">bool that contents the LogAnticipoACPM value for the LiquidacionGastos object</param>
		/// <param name="AntipoConductor">bool that contents the AntipoConductor value for the LiquidacionGastos object</param>
		/// <param name="lngIdRegistrRutaItemId">int that contents the lngIdRegistrRutaItemId value for the LiquidacionGastos object</param>
		/// <param name="lngIdRegistroViaje">decimal that contents the lngIdRegistroViaje value for the LiquidacionGastos object</param>
		/// <param name="lngIdRegistrRuta">int that contents the lngIdRegistrRuta value for the LiquidacionGastos object</param>
		/// <param name="strCuenta">string that contents the strCuenta value for the LiquidacionGastos object</param>
		/// <param name="intRowRegistro">int that contents the intRowRegistro value for the LiquidacionGastos object</param>
		public void Update(string strDescripcionCuenta, string strDescripcion, DateTime? dtmFechaAsignacion, decimal? curValorTramo, decimal? curValorAdicional, decimal? curValorTotal, string strObservaciones, string nitTercero, string strPlaca, int? lngIdUsuario, bool? logLiquidado, DateTime? dtmFechaSalida, DateTime? dtmFechaLlegada, DateTime? dtmFechaModif, bool? LogExcluido, decimal? floGalones, decimal? floGalonesAdicional, decimal? floGalonesReales, decimal? curValorGalon, decimal? CombustibleCarretera, decimal? cutCombustible, bool? LogAnticipoACPM, bool? AntipoConductor, int lngIdRegistrRutaItemId, decimal lngIdRegistroViaje, int lngIdRegistrRuta, string strCuenta, int intRowRegistro, Sinapsys.Datos.SQL datosTransaccion=null)
		{
			try 
			{
				LiquidacionGastos new_values = new LiquidacionGastos();
				new_values.strDescripcionCuenta = strDescripcionCuenta;
				new_values.strDescripcion = strDescripcion;
				new_values.dtmFechaAsignacion = dtmFechaAsignacion;
				new_values.curValorTramo = curValorTramo;
				new_values.curValorAdicional = curValorAdicional;
				new_values.curValorTotal = curValorTotal;
				new_values.strObservaciones = strObservaciones;
				new_values.nitTercero = nitTercero;
				new_values.strPlaca = strPlaca;
				new_values.lngIdUsuario = lngIdUsuario;
				new_values.logLiquidado = logLiquidado;
				new_values.dtmFechaSalida = dtmFechaSalida;
				new_values.dtmFechaLlegada = dtmFechaLlegada;
				new_values.dtmFechaModif = dtmFechaModif;
				new_values.LogExcluido = LogExcluido;
				new_values.floGalones = floGalones;
				new_values.floGalonesAdicional = floGalonesAdicional;
				new_values.floGalonesReales = floGalonesReales;
				new_values.curValorGalon = curValorGalon;
				new_values.CombustibleCarretera = CombustibleCarretera;
				new_values.cutCombustible = cutCombustible;
				new_values.LogAnticipoACPM = LogAnticipoACPM;
				new_values.AntipoConductor = AntipoConductor;
				LiquidacionGastosDataProvider.Instance.Update(strDescripcionCuenta, strDescripcion, dtmFechaAsignacion, curValorTramo, curValorAdicional, curValorTotal, strObservaciones, nitTercero, strPlaca, lngIdUsuario, logLiquidado, dtmFechaSalida, dtmFechaLlegada, dtmFechaModif, LogExcluido, floGalones, floGalonesAdicional, floGalonesReales, curValorGalon, CombustibleCarretera, cutCombustible, LogAnticipoACPM, AntipoConductor, lngIdRegistrRutaItemId, lngIdRegistroViaje, lngIdRegistrRuta, strCuenta, intRowRegistro,"LiquidacionGastos",datosTransaccion);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Updates an LiquidacionGastos object by passing one object's instance as reference
		/// </summary>
		/// <param name="liquidaciongastos">An instance of LiquidacionGastos for reference</param>
		public void Update(LiquidacionGastos liquidaciongastos,Sinapsys.Datos.SQL datosTransaccion=null)
		{
			Update(liquidaciongastos.strDescripcionCuenta, liquidaciongastos.strDescripcion, liquidaciongastos.dtmFechaAsignacion, liquidaciongastos.curValorTramo, liquidaciongastos.curValorAdicional, liquidaciongastos.curValorTotal, liquidaciongastos.strObservaciones, liquidaciongastos.nitTercero, liquidaciongastos.strPlaca, liquidaciongastos.lngIdUsuario, liquidaciongastos.logLiquidado, liquidaciongastos.dtmFechaSalida, liquidaciongastos.dtmFechaLlegada, liquidaciongastos.dtmFechaModif, liquidaciongastos.LogExcluido, liquidaciongastos.floGalones, liquidaciongastos.floGalonesAdicional, liquidaciongastos.floGalonesReales, liquidaciongastos.curValorGalon, liquidaciongastos.CombustibleCarretera, liquidaciongastos.cutCombustible, liquidaciongastos.LogAnticipoACPM, liquidaciongastos.AntipoConductor, liquidaciongastos.lngIdRegistrRutaItemId, liquidaciongastos.lngIdRegistroViaje, liquidaciongastos.lngIdRegistrRuta, liquidaciongastos.strCuenta, liquidaciongastos.intRowRegistro);
		}

		/// <summary>
		/// Delete  the LiquidacionGastos object by passing a object
		/// </summary>
		public void  Delete(LiquidacionGastos liquidaciongastos, Sinapsys.Datos.SQL datosTransaccion=null)
		{
			Delete(liquidaciongastos.lngIdRegistrRutaItemId, liquidaciongastos.lngIdRegistroViaje, liquidaciongastos.lngIdRegistrRuta, liquidaciongastos.strCuenta, liquidaciongastos.intRowRegistro,datosTransaccion);
		}

		/// <summary>
		/// Deletes the LiquidacionGastos object by passing one object's instance as reference
		/// </summary>
		/// <param name="liquidaciongastos">An instance of LiquidacionGastos for reference</param>
		public void Delete(int lngIdRegistrRutaItemId, decimal lngIdRegistroViaje, int lngIdRegistrRuta, string strCuenta, int intRowRegistro, Sinapsys.Datos.SQL datosTransaccion=null)
		{
			try 
			{
				LiquidacionGastosDataProvider.Instance.Delete(lngIdRegistrRutaItemId, lngIdRegistroViaje, lngIdRegistrRuta, strCuenta, intRowRegistro,"LiquidacionGastos");
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Deletes the LiquidacionGastos object by passing CVS parameter as reference
		/// </summary>
		/// <param name="liquidaciongastos">An instance of LiquidacionGastos for reference</param>
		public void Delete(string CVSParameter)
		{
			string[] StrCommand=CVSParameter.Split(',');
			try 
			{
				int lngIdRegistrRutaItemId=int.Parse(StrCommand[0]);
				decimal lngIdRegistroViaje=decimal.Parse(StrCommand[1]);
				int lngIdRegistrRuta=int.Parse(StrCommand[2]);
				string strCuenta=StrCommand[3];
				int intRowRegistro=int.Parse(StrCommand[4]);
				LiquidacionGastosDataProvider.Instance.Delete(lngIdRegistrRutaItemId, lngIdRegistroViaje, lngIdRegistrRuta, strCuenta, intRowRegistro,"LiquidacionGastos");
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Gets the LiquidacionGastos object by passing the object's key fields
		/// </summary>
		/// <param name="lngIdRegistrRutaItemId">int that contents the lngIdRegistrRutaItemId value for the LiquidacionGastos object</param>
		/// <param name="lngIdRegistroViaje">decimal that contents the lngIdRegistroViaje value for the LiquidacionGastos object</param>
		/// <param name="lngIdRegistrRuta">int that contents the lngIdRegistrRuta value for the LiquidacionGastos object</param>
		/// <param name="strCuenta">string that contents the strCuenta value for the LiquidacionGastos object</param>
		/// <param name="intRowRegistro">int that contents the intRowRegistro value for the LiquidacionGastos object</param>
		/// <returns>One LiquidacionGastos object</returns>
		public LiquidacionGastos Get(int lngIdRegistrRutaItemId, decimal lngIdRegistroViaje, int lngIdRegistrRuta, string strCuenta, int intRowRegistro, bool generateUndo=false)
		{
			try 
			{
				LiquidacionGastos liquidaciongastos = null;
				DataTable dt = LiquidacionGastosDataProvider.Instance.Get(lngIdRegistrRutaItemId, lngIdRegistroViaje, lngIdRegistrRuta, strCuenta, intRowRegistro);
				if ((dt.Rows.Count > 0))
				{
					liquidaciongastos = new LiquidacionGastos();
					DataRow dr = dt.Rows[0];
					ReadData(liquidaciongastos, dr, generateUndo);
				}


				return liquidaciongastos;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Gets all objects of LiquidacionGastos
		/// </summary>
		/// <returns>One LiquidacionGastosList object</returns>
		public LiquidacionGastosList GetAll(bool generateUndo=false)
		{
			try 
			{
				LiquidacionGastosList liquidaciongastoslist = new LiquidacionGastosList();
				DataTable dt = LiquidacionGastosDataProvider.Instance.GetAll();
				foreach (DataRow dr in dt.Rows)
				{
					LiquidacionGastos liquidaciongastos = new LiquidacionGastos();
					ReadData(liquidaciongastos, dr, generateUndo);
					liquidaciongastoslist.Add(liquidaciongastos);
				}
				return liquidaciongastoslist;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Selects all LiquidacionGastos objects by reference (Foreign Keys)
		/// </summary>
		/// <param name="lngIdRegistrRutaItemId">int that contents the lngIdRegistrRutaItemId value for the LiquidacionGastos object</param>
		/// <returns>One LiquidacionGastosList object</returns>
		public LiquidacionGastosList GetBy_lngIdRegistrRutaItemId(int lngIdRegistrRutaItemId,bool generateUndo=false)
		{
			try 
			{
				LiquidacionGastosList liquidaciongastoslist = new LiquidacionGastosList();

				DataTable dt = LiquidacionGastosDataProvider.Instance.GetBy_lngIdRegistrRutaItemId(lngIdRegistrRutaItemId);
				foreach (DataRow dr in dt.Rows)
				{
					LiquidacionGastos liquidaciongastos = new LiquidacionGastos();
					ReadData(liquidaciongastos, dr, generateUndo);
					liquidaciongastoslist.Add(liquidaciongastos);
				}
				return liquidaciongastoslist;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Gets all objects of LiquidacionGastos applying filter and sort criteria
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
		/// <returns>One LiquidacionGastosList object</returns>
		public LiquidacionGastosList GetFilter(int pagenum, int pagesize, string filter, string sort, string extablesfilter, string extablesfieldsfilter, string extablesrelationsfilter, string extablessort, string extablesfieldssort, string extablesrelationssort, bool generateUndo=false)
		{
			try 
			{
				LiquidacionGastosList liquidaciongastoslist = new LiquidacionGastosList();

				DataTable dt = LiquidacionGastosDataProvider.Instance.GetFilter(pagenum, pagesize, filter, sort, extablesfilter, extablesfieldsfilter, extablesrelationsfilter, extablessort, extablesfieldssort, extablesrelationssort);

				foreach (DataRow dr in dt.Rows)
				{
					LiquidacionGastos liquidaciongastos = new LiquidacionGastos();
					ReadData(liquidaciongastos, dr, generateUndo);
					liquidaciongastoslist.Add(liquidaciongastos);
				}
				return liquidaciongastoslist;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public LiquidacionGastosList GetFilter( string filter, string sort, bool generateUndo=false)
		{
			return GetFilter(0,0, filter, sort, "","","","","","",generateUndo);
		}

		public LiquidacionGastosList GetFilter(string filter, string sort, string extablesfilter, string extablesfieldsfilter, string extablesrelationsfilter, string extablessort, string extablesfieldssort, string extablesrelationssort, bool generateUndo=false)
		{
			return GetFilter(0,0, filter, sort, extablesfilter, extablesfieldsfilter, extablesrelationsfilter, extablessort, extablesfieldssort, extablesrelationssort,generateUndo);
		}


		/// <summary>
		/// Returns the type for one property
		/// </summary>
		/// <param name="propertyname">Property's name for return its value</param>
		/// <returns>A value for the <paramref name="propertyname"/></returns>
		public Type GetMethodType( string propertyname,LiquidacionGastos liquidaciongastos)
		{
			// Perform the search for the property's value
			switch (propertyname)
			{
				case "strDescripcionCuenta":
					return liquidaciongastos.strDescripcionCuenta.GetType();

				case "strDescripcion":
					return liquidaciongastos.strDescripcion.GetType();

				case "dtmFechaAsignacion":
					return liquidaciongastos.dtmFechaAsignacion.GetType();

				case "curValorTramo":
					return liquidaciongastos.curValorTramo.GetType();

				case "curValorAdicional":
					return liquidaciongastos.curValorAdicional.GetType();

				case "curValorTotal":
					return liquidaciongastos.curValorTotal.GetType();

				case "strObservaciones":
					return liquidaciongastos.strObservaciones.GetType();

				case "nitTercero":
					return liquidaciongastos.nitTercero.GetType();

				case "strPlaca":
					return liquidaciongastos.strPlaca.GetType();

				case "lngIdUsuario":
					return liquidaciongastos.lngIdUsuario.GetType();

				case "logLiquidado":
					return liquidaciongastos.logLiquidado.GetType();

				case "dtmFechaSalida":
					return liquidaciongastos.dtmFechaSalida.GetType();

				case "dtmFechaLlegada":
					return liquidaciongastos.dtmFechaLlegada.GetType();

				case "dtmFechaModif":
					return liquidaciongastos.dtmFechaModif.GetType();

				case "LogExcluido":
					return liquidaciongastos.LogExcluido.GetType();

				case "floGalones":
					return liquidaciongastos.floGalones.GetType();

				case "floGalonesAdicional":
					return liquidaciongastos.floGalonesAdicional.GetType();

				case "floGalonesReales":
					return liquidaciongastos.floGalonesReales.GetType();

				case "curValorGalon":
					return liquidaciongastos.curValorGalon.GetType();

				case "CombustibleCarretera":
					return liquidaciongastos.CombustibleCarretera.GetType();

				case "cutCombustible":
					return liquidaciongastos.cutCombustible.GetType();

				case "LogAnticipoACPM":
					return liquidaciongastos.LogAnticipoACPM.GetType();

				case "AntipoConductor":
					return liquidaciongastos.AntipoConductor.GetType();

				case "lngIdRegistrRutaItemId":
					return liquidaciongastos.lngIdRegistrRutaItemId.GetType();

				case "lngIdRegistroViaje":
					return liquidaciongastos.lngIdRegistroViaje.GetType();

				case "lngIdRegistrRuta":
					return liquidaciongastos.lngIdRegistrRuta.GetType();

				case "strCuenta":
					return liquidaciongastos.strCuenta.GetType();

				case "intRowRegistro":
					return liquidaciongastos.intRowRegistro.GetType();

			}

			return null;
		}
		/// <summary>
		/// update the changes in LiquidacionGastos object by passing the object
		/// </summary>
		public bool UpdateChanges(LiquidacionGastos liquidaciongastos, out string error,Sinapsys.Datos.SQL datosTransaccion=null)
		{
			if (liquidaciongastos.OldLiquidacionGastos == null)
			{
				    error = "No tiene objeto con el cual comparar";
				    return false;
			}
			string[] Fields = liquidaciongastos.FieldChanged();
			error = "";
			return LiqViajes_Bll_Data.DataProvider.UpdateFieldsbyObject(Fields, liquidaciongastos, out error,datosTransaccion);
		}
	}

	#endregion

}
