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
	#region VehiculoForWinController

	/// <summary>
	/// Class for convert data from database into object's data and vice versa
	/// </summary>
	public partial class VehiculoForWinController//: ILatinodeController
	{
		/// <summary>
		/// Generic Constructor
		/// </summary>
		public VehiculoForWinController()
		{
		}

		/// <summary>
		/// Instance accessor for this singleton
		/// </summary>
		private static VehiculoForWinController MySingleObj;
		public static VehiculoForWinController Instance
		{
			get
			{
				if (MySingleObj == null)
				{
					MySingleObj = new VehiculoForWinController();
				}
				return MySingleObj;
			}
		}

		// Reads object's data from a DataRow
		private void ReadData(VehiculoForWin vehiculoforwin, DataRow dr,bool generateUndo=false)
		{
			try 
			{
				vehiculoforwin.strPlaca = (int) dr["strPlaca"];
				vehiculoforwin.centro = dr.IsNull("centro") ? null :(int?) dr["centro"];
				vehiculoforwin.TipoVehiculoCodigo = dr.IsNull("TipoVehiculoCodigo") ? null :(int?) dr["TipoVehiculoCodigo"];
				vehiculoforwin.Descripcion = dr.IsNull("Descripcion") ? null :(string) dr["Descripcion"];
				vehiculoforwin.dtmFechaIngreso = dr.IsNull("dtmFechaIngreso") ? null :(int?) dr["dtmFechaIngreso"];
				vehiculoforwin.dtmFechaEgreso = dr.IsNull("dtmFechaEgreso") ? null :(int?) dr["dtmFechaEgreso"];
				vehiculoforwin.nitPropietario = dr.IsNull("nitPropietario") ? null :(int?) dr["nitPropietario"];
				vehiculoforwin.strMarca = dr.IsNull("strMarca") ? null :(int?) dr["strMarca"];
				vehiculoforwin.lngModelo = dr.IsNull("lngModelo") ? null :(int?) dr["lngModelo"];
				vehiculoforwin.lngMovil = dr.IsNull("lngMovil") ? null :(int?) dr["lngMovil"];
				vehiculoforwin.strCelular = dr.IsNull("strCelular") ? null :(int?) dr["strCelular"];
				vehiculoforwin.strTipoMotor = dr.IsNull("strTipoMotor") ? null :(int?) dr["strTipoMotor"];
				vehiculoforwin.strColor = dr.IsNull("strColor") ? null :(int?) dr["strColor"];
				vehiculoforwin.strMotor = dr.IsNull("strMotor") ? null :(int?) dr["strMotor"];
				vehiculoforwin.strChasis = dr.IsNull("strChasis") ? null :(int?) dr["strChasis"];
				vehiculoforwin.logCamarote = dr.IsNull("logCamarote") ? null :(int?) dr["logCamarote"];
				vehiculoforwin.cutPeso = dr.IsNull("cutPeso") ? null :(int?) dr["cutPeso"];
				vehiculoforwin.cutCapacidad = dr.IsNull("cutCapacidad") ? null :(int?) dr["cutCapacidad"];
				vehiculoforwin.lngEjes = dr.IsNull("lngEjes") ? null :(int?) dr["lngEjes"];
				vehiculoforwin.logActivo = dr.IsNull("logActivo") ? null :(int?) dr["logActivo"];
				vehiculoforwin.lngLlantas = dr.IsNull("lngLlantas") ? null :(int?) dr["lngLlantas"];
				vehiculoforwin.strPolizaObligatorio = dr.IsNull("strPolizaObligatorio") ? null :(int?) dr["strPolizaObligatorio"];
				vehiculoforwin.nitProvedorOblig = dr.IsNull("nitProvedorOblig") ? null :(int?) dr["nitProvedorOblig"];
				vehiculoforwin.dtmFechaInicioOblig = dr.IsNull("dtmFechaInicioOblig") ? null :(int?) dr["dtmFechaInicioOblig"];
				vehiculoforwin.dtmFechaVenceOblig = dr.IsNull("dtmFechaVenceOblig") ? null :(int?) dr["dtmFechaVenceOblig"];
				vehiculoforwin.strPolizaTodoRiesgo = dr.IsNull("strPolizaTodoRiesgo") ? null :(int?) dr["strPolizaTodoRiesgo"];
				vehiculoforwin.nitProvedorTodo = dr.IsNull("nitProvedorTodo") ? null :(int?) dr["nitProvedorTodo"];
				vehiculoforwin.dtmFechaInicioTodo = dr.IsNull("dtmFechaInicioTodo") ? null :(int?) dr["dtmFechaInicioTodo"];
				vehiculoforwin.dtmFechaVenceTodo = dr.IsNull("dtmFechaVenceTodo") ? null :(int?) dr["dtmFechaVenceTodo"];
				vehiculoforwin.strCertifMovilizacion = dr.IsNull("strCertifMovilizacion") ? null :(int?) dr["strCertifMovilizacion"];
				vehiculoforwin.dtmFechaInicioMoviliz = dr.IsNull("dtmFechaInicioMoviliz") ? null :(int?) dr["dtmFechaInicioMoviliz"];
				vehiculoforwin.dtmFechaVenceMoviliz = dr.IsNull("dtmFechaVenceMoviliz") ? null :(int?) dr["dtmFechaVenceMoviliz"];
				vehiculoforwin.strGases = dr.IsNull("strGases") ? null :(int?) dr["strGases"];
				vehiculoforwin.dtmFechaInicioGases = dr.IsNull("dtmFechaInicioGases") ? null :(int?) dr["dtmFechaInicioGases"];
				vehiculoforwin.dtmFechaVenceGases = dr.IsNull("dtmFechaVenceGases") ? null :(int?) dr["dtmFechaVenceGases"];
				vehiculoforwin.strTarjetaOper = dr.IsNull("strTarjetaOper") ? null :(int?) dr["strTarjetaOper"];
				vehiculoforwin.dtmFechaInicioTarjetaOper = dr.IsNull("dtmFechaInicioTarjetaOper") ? null :(int?) dr["dtmFechaInicioTarjetaOper"];
				vehiculoforwin.dtmFechaVenceTarjetaOper = dr.IsNull("dtmFechaVenceTarjetaOper") ? null :(int?) dr["dtmFechaVenceTarjetaOper"];
				vehiculoforwin.logVencimientoFecha = dr.IsNull("logVencimientoFecha") ? null :(int?) dr["logVencimientoFecha"];
				vehiculoforwin.lngIdRegistro = (int) dr["lngIdRegistro"];
				vehiculoforwin.lngIdUsuario = (int) dr["lngIdUsuario"];
			}
			catch (Exception ex)
			{
				Utilidades.LogErrores(ex.Message + (ex.InnerException != null ? ex.InnerException.Message : ""), DataProvider.AplicacionNombre);
				throw ex;
			}
			if (generateUndo) vehiculoforwin.GenerateUndo();
		}

		/// <summary>
		/// Create a new VehiculoForWin object by passing a object
		/// </summary>
		public VehiculoForWin Create(VehiculoForWin vehiculoforwin, Sinapsys.Datos.SQL datosTransaccion=null)
		{
			return Create(vehiculoforwin.lngIdRegistro,vehiculoforwin.lngIdUsuario,vehiculoforwin.strPlaca,vehiculoforwin.centro,vehiculoforwin.TipoVehiculoCodigo,vehiculoforwin.Descripcion,vehiculoforwin.dtmFechaIngreso,vehiculoforwin.dtmFechaEgreso,vehiculoforwin.nitPropietario,vehiculoforwin.strMarca,vehiculoforwin.lngModelo,vehiculoforwin.lngMovil,vehiculoforwin.strCelular,vehiculoforwin.strTipoMotor,vehiculoforwin.strColor,vehiculoforwin.strMotor,vehiculoforwin.strChasis,vehiculoforwin.logCamarote,vehiculoforwin.cutPeso,vehiculoforwin.cutCapacidad,vehiculoforwin.lngEjes,vehiculoforwin.logActivo,vehiculoforwin.lngLlantas,vehiculoforwin.strPolizaObligatorio,vehiculoforwin.nitProvedorOblig,vehiculoforwin.dtmFechaInicioOblig,vehiculoforwin.dtmFechaVenceOblig,vehiculoforwin.strPolizaTodoRiesgo,vehiculoforwin.nitProvedorTodo,vehiculoforwin.dtmFechaInicioTodo,vehiculoforwin.dtmFechaVenceTodo,vehiculoforwin.strCertifMovilizacion,vehiculoforwin.dtmFechaInicioMoviliz,vehiculoforwin.dtmFechaVenceMoviliz,vehiculoforwin.strGases,vehiculoforwin.dtmFechaInicioGases,vehiculoforwin.dtmFechaVenceGases,vehiculoforwin.strTarjetaOper,vehiculoforwin.dtmFechaInicioTarjetaOper,vehiculoforwin.dtmFechaVenceTarjetaOper,vehiculoforwin.logVencimientoFecha,datosTransaccion);
		}

		/// <summary>
		/// Creates a new VehiculoForWin object by passing all object's fields
		/// </summary>
		/// <param name="strPlaca">int that contents the strPlaca value for the VehiculoForWin object</param>
		/// <param name="centro">int that contents the centro value for the VehiculoForWin object</param>
		/// <param name="TipoVehiculoCodigo">int that contents the TipoVehiculoCodigo value for the VehiculoForWin object</param>
		/// <param name="Descripcion">string that contents the Descripcion value for the VehiculoForWin object</param>
		/// <param name="dtmFechaIngreso">int that contents the dtmFechaIngreso value for the VehiculoForWin object</param>
		/// <param name="dtmFechaEgreso">int that contents the dtmFechaEgreso value for the VehiculoForWin object</param>
		/// <param name="nitPropietario">int that contents the nitPropietario value for the VehiculoForWin object</param>
		/// <param name="strMarca">int that contents the strMarca value for the VehiculoForWin object</param>
		/// <param name="lngModelo">int that contents the lngModelo value for the VehiculoForWin object</param>
		/// <param name="lngMovil">int that contents the lngMovil value for the VehiculoForWin object</param>
		/// <param name="strCelular">int that contents the strCelular value for the VehiculoForWin object</param>
		/// <param name="strTipoMotor">int that contents the strTipoMotor value for the VehiculoForWin object</param>
		/// <param name="strColor">int that contents the strColor value for the VehiculoForWin object</param>
		/// <param name="strMotor">int that contents the strMotor value for the VehiculoForWin object</param>
		/// <param name="strChasis">int that contents the strChasis value for the VehiculoForWin object</param>
		/// <param name="logCamarote">int that contents the logCamarote value for the VehiculoForWin object</param>
		/// <param name="cutPeso">int that contents the cutPeso value for the VehiculoForWin object</param>
		/// <param name="cutCapacidad">int that contents the cutCapacidad value for the VehiculoForWin object</param>
		/// <param name="lngEjes">int that contents the lngEjes value for the VehiculoForWin object</param>
		/// <param name="logActivo">int that contents the logActivo value for the VehiculoForWin object</param>
		/// <param name="lngLlantas">int that contents the lngLlantas value for the VehiculoForWin object</param>
		/// <param name="strPolizaObligatorio">int that contents the strPolizaObligatorio value for the VehiculoForWin object</param>
		/// <param name="nitProvedorOblig">int that contents the nitProvedorOblig value for the VehiculoForWin object</param>
		/// <param name="dtmFechaInicioOblig">int that contents the dtmFechaInicioOblig value for the VehiculoForWin object</param>
		/// <param name="dtmFechaVenceOblig">int that contents the dtmFechaVenceOblig value for the VehiculoForWin object</param>
		/// <param name="strPolizaTodoRiesgo">int that contents the strPolizaTodoRiesgo value for the VehiculoForWin object</param>
		/// <param name="nitProvedorTodo">int that contents the nitProvedorTodo value for the VehiculoForWin object</param>
		/// <param name="dtmFechaInicioTodo">int that contents the dtmFechaInicioTodo value for the VehiculoForWin object</param>
		/// <param name="dtmFechaVenceTodo">int that contents the dtmFechaVenceTodo value for the VehiculoForWin object</param>
		/// <param name="strCertifMovilizacion">int that contents the strCertifMovilizacion value for the VehiculoForWin object</param>
		/// <param name="dtmFechaInicioMoviliz">int that contents the dtmFechaInicioMoviliz value for the VehiculoForWin object</param>
		/// <param name="dtmFechaVenceMoviliz">int that contents the dtmFechaVenceMoviliz value for the VehiculoForWin object</param>
		/// <param name="strGases">int that contents the strGases value for the VehiculoForWin object</param>
		/// <param name="dtmFechaInicioGases">int that contents the dtmFechaInicioGases value for the VehiculoForWin object</param>
		/// <param name="dtmFechaVenceGases">int that contents the dtmFechaVenceGases value for the VehiculoForWin object</param>
		/// <param name="strTarjetaOper">int that contents the strTarjetaOper value for the VehiculoForWin object</param>
		/// <param name="dtmFechaInicioTarjetaOper">int that contents the dtmFechaInicioTarjetaOper value for the VehiculoForWin object</param>
		/// <param name="dtmFechaVenceTarjetaOper">int that contents the dtmFechaVenceTarjetaOper value for the VehiculoForWin object</param>
		/// <param name="logVencimientoFecha">int that contents the logVencimientoFecha value for the VehiculoForWin object</param>
		/// <returns>One VehiculoForWin object</returns>
		public VehiculoForWin Create(int lngIdRegistro, int lngIdUsuario, int strPlaca, int? centro, int? TipoVehiculoCodigo, string Descripcion, int? dtmFechaIngreso, int? dtmFechaEgreso, int? nitPropietario, int? strMarca, int? lngModelo, int? lngMovil, int? strCelular, int? strTipoMotor, int? strColor, int? strMotor, int? strChasis, int? logCamarote, int? cutPeso, int? cutCapacidad, int? lngEjes, int? logActivo, int? lngLlantas, int? strPolizaObligatorio, int? nitProvedorOblig, int? dtmFechaInicioOblig, int? dtmFechaVenceOblig, int? strPolizaTodoRiesgo, int? nitProvedorTodo, int? dtmFechaInicioTodo, int? dtmFechaVenceTodo, int? strCertifMovilizacion, int? dtmFechaInicioMoviliz, int? dtmFechaVenceMoviliz, int? strGases, int? dtmFechaInicioGases, int? dtmFechaVenceGases, int? strTarjetaOper, int? dtmFechaInicioTarjetaOper, int? dtmFechaVenceTarjetaOper, int? logVencimientoFecha, Sinapsys.Datos.SQL datosTransaccion=null)
		{
			try 
			{
				VehiculoForWin vehiculoforwin = new VehiculoForWin();

				vehiculoforwin.lngIdRegistro = lngIdRegistro;
				vehiculoforwin.lngIdUsuario = lngIdUsuario;
				vehiculoforwin.strPlaca = strPlaca;
				vehiculoforwin.centro = centro;
				vehiculoforwin.TipoVehiculoCodigo = TipoVehiculoCodigo;
				vehiculoforwin.Descripcion = Descripcion;
				vehiculoforwin.dtmFechaIngreso = dtmFechaIngreso;
				vehiculoforwin.dtmFechaEgreso = dtmFechaEgreso;
				vehiculoforwin.nitPropietario = nitPropietario;
				vehiculoforwin.strMarca = strMarca;
				vehiculoforwin.lngModelo = lngModelo;
				vehiculoforwin.lngMovil = lngMovil;
				vehiculoforwin.strCelular = strCelular;
				vehiculoforwin.strTipoMotor = strTipoMotor;
				vehiculoforwin.strColor = strColor;
				vehiculoforwin.strMotor = strMotor;
				vehiculoforwin.strChasis = strChasis;
				vehiculoforwin.logCamarote = logCamarote;
				vehiculoforwin.cutPeso = cutPeso;
				vehiculoforwin.cutCapacidad = cutCapacidad;
				vehiculoforwin.lngEjes = lngEjes;
				vehiculoforwin.logActivo = logActivo;
				vehiculoforwin.lngLlantas = lngLlantas;
				vehiculoforwin.strPolizaObligatorio = strPolizaObligatorio;
				vehiculoforwin.nitProvedorOblig = nitProvedorOblig;
				vehiculoforwin.dtmFechaInicioOblig = dtmFechaInicioOblig;
				vehiculoforwin.dtmFechaVenceOblig = dtmFechaVenceOblig;
				vehiculoforwin.strPolizaTodoRiesgo = strPolizaTodoRiesgo;
				vehiculoforwin.nitProvedorTodo = nitProvedorTodo;
				vehiculoforwin.dtmFechaInicioTodo = dtmFechaInicioTodo;
				vehiculoforwin.dtmFechaVenceTodo = dtmFechaVenceTodo;
				vehiculoforwin.strCertifMovilizacion = strCertifMovilizacion;
				vehiculoforwin.dtmFechaInicioMoviliz = dtmFechaInicioMoviliz;
				vehiculoforwin.dtmFechaVenceMoviliz = dtmFechaVenceMoviliz;
				vehiculoforwin.strGases = strGases;
				vehiculoforwin.dtmFechaInicioGases = dtmFechaInicioGases;
				vehiculoforwin.dtmFechaVenceGases = dtmFechaVenceGases;
				vehiculoforwin.strTarjetaOper = strTarjetaOper;
				vehiculoforwin.dtmFechaInicioTarjetaOper = dtmFechaInicioTarjetaOper;
				vehiculoforwin.dtmFechaVenceTarjetaOper = dtmFechaVenceTarjetaOper;
				vehiculoforwin.logVencimientoFecha = logVencimientoFecha;
				VehiculoForWinDataProvider.Instance.Create(lngIdRegistro, lngIdUsuario, strPlaca, centro, TipoVehiculoCodigo, Descripcion, dtmFechaIngreso, dtmFechaEgreso, nitPropietario, strMarca, lngModelo, lngMovil, strCelular, strTipoMotor, strColor, strMotor, strChasis, logCamarote, cutPeso, cutCapacidad, lngEjes, logActivo, lngLlantas, strPolizaObligatorio, nitProvedorOblig, dtmFechaInicioOblig, dtmFechaVenceOblig, strPolizaTodoRiesgo, nitProvedorTodo, dtmFechaInicioTodo, dtmFechaVenceTodo, strCertifMovilizacion, dtmFechaInicioMoviliz, dtmFechaVenceMoviliz, strGases, dtmFechaInicioGases, dtmFechaVenceGases, strTarjetaOper, dtmFechaInicioTarjetaOper, dtmFechaVenceTarjetaOper, logVencimientoFecha,"VehiculoForWin");

				return vehiculoforwin;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Updates an VehiculoForWin object by passing all object's fields
		/// </summary>
		/// <param name="strPlaca">int that contents the strPlaca value for the VehiculoForWin object</param>
		/// <param name="centro">int that contents the centro value for the VehiculoForWin object</param>
		/// <param name="TipoVehiculoCodigo">int that contents the TipoVehiculoCodigo value for the VehiculoForWin object</param>
		/// <param name="Descripcion">string that contents the Descripcion value for the VehiculoForWin object</param>
		/// <param name="dtmFechaIngreso">int that contents the dtmFechaIngreso value for the VehiculoForWin object</param>
		/// <param name="dtmFechaEgreso">int that contents the dtmFechaEgreso value for the VehiculoForWin object</param>
		/// <param name="nitPropietario">int that contents the nitPropietario value for the VehiculoForWin object</param>
		/// <param name="strMarca">int that contents the strMarca value for the VehiculoForWin object</param>
		/// <param name="lngModelo">int that contents the lngModelo value for the VehiculoForWin object</param>
		/// <param name="lngMovil">int that contents the lngMovil value for the VehiculoForWin object</param>
		/// <param name="strCelular">int that contents the strCelular value for the VehiculoForWin object</param>
		/// <param name="strTipoMotor">int that contents the strTipoMotor value for the VehiculoForWin object</param>
		/// <param name="strColor">int that contents the strColor value for the VehiculoForWin object</param>
		/// <param name="strMotor">int that contents the strMotor value for the VehiculoForWin object</param>
		/// <param name="strChasis">int that contents the strChasis value for the VehiculoForWin object</param>
		/// <param name="logCamarote">int that contents the logCamarote value for the VehiculoForWin object</param>
		/// <param name="cutPeso">int that contents the cutPeso value for the VehiculoForWin object</param>
		/// <param name="cutCapacidad">int that contents the cutCapacidad value for the VehiculoForWin object</param>
		/// <param name="lngEjes">int that contents the lngEjes value for the VehiculoForWin object</param>
		/// <param name="logActivo">int that contents the logActivo value for the VehiculoForWin object</param>
		/// <param name="lngLlantas">int that contents the lngLlantas value for the VehiculoForWin object</param>
		/// <param name="strPolizaObligatorio">int that contents the strPolizaObligatorio value for the VehiculoForWin object</param>
		/// <param name="nitProvedorOblig">int that contents the nitProvedorOblig value for the VehiculoForWin object</param>
		/// <param name="dtmFechaInicioOblig">int that contents the dtmFechaInicioOblig value for the VehiculoForWin object</param>
		/// <param name="dtmFechaVenceOblig">int that contents the dtmFechaVenceOblig value for the VehiculoForWin object</param>
		/// <param name="strPolizaTodoRiesgo">int that contents the strPolizaTodoRiesgo value for the VehiculoForWin object</param>
		/// <param name="nitProvedorTodo">int that contents the nitProvedorTodo value for the VehiculoForWin object</param>
		/// <param name="dtmFechaInicioTodo">int that contents the dtmFechaInicioTodo value for the VehiculoForWin object</param>
		/// <param name="dtmFechaVenceTodo">int that contents the dtmFechaVenceTodo value for the VehiculoForWin object</param>
		/// <param name="strCertifMovilizacion">int that contents the strCertifMovilizacion value for the VehiculoForWin object</param>
		/// <param name="dtmFechaInicioMoviliz">int that contents the dtmFechaInicioMoviliz value for the VehiculoForWin object</param>
		/// <param name="dtmFechaVenceMoviliz">int that contents the dtmFechaVenceMoviliz value for the VehiculoForWin object</param>
		/// <param name="strGases">int that contents the strGases value for the VehiculoForWin object</param>
		/// <param name="dtmFechaInicioGases">int that contents the dtmFechaInicioGases value for the VehiculoForWin object</param>
		/// <param name="dtmFechaVenceGases">int that contents the dtmFechaVenceGases value for the VehiculoForWin object</param>
		/// <param name="strTarjetaOper">int that contents the strTarjetaOper value for the VehiculoForWin object</param>
		/// <param name="dtmFechaInicioTarjetaOper">int that contents the dtmFechaInicioTarjetaOper value for the VehiculoForWin object</param>
		/// <param name="dtmFechaVenceTarjetaOper">int that contents the dtmFechaVenceTarjetaOper value for the VehiculoForWin object</param>
		/// <param name="logVencimientoFecha">int that contents the logVencimientoFecha value for the VehiculoForWin object</param>
		/// <param name="lngIdRegistro">int that contents the lngIdRegistro value for the VehiculoForWin object</param>
		/// <param name="lngIdUsuario">int that contents the lngIdUsuario value for the VehiculoForWin object</param>
		public void Update(int strPlaca, int? centro, int? TipoVehiculoCodigo, string Descripcion, int? dtmFechaIngreso, int? dtmFechaEgreso, int? nitPropietario, int? strMarca, int? lngModelo, int? lngMovil, int? strCelular, int? strTipoMotor, int? strColor, int? strMotor, int? strChasis, int? logCamarote, int? cutPeso, int? cutCapacidad, int? lngEjes, int? logActivo, int? lngLlantas, int? strPolizaObligatorio, int? nitProvedorOblig, int? dtmFechaInicioOblig, int? dtmFechaVenceOblig, int? strPolizaTodoRiesgo, int? nitProvedorTodo, int? dtmFechaInicioTodo, int? dtmFechaVenceTodo, int? strCertifMovilizacion, int? dtmFechaInicioMoviliz, int? dtmFechaVenceMoviliz, int? strGases, int? dtmFechaInicioGases, int? dtmFechaVenceGases, int? strTarjetaOper, int? dtmFechaInicioTarjetaOper, int? dtmFechaVenceTarjetaOper, int? logVencimientoFecha, int lngIdRegistro, int lngIdUsuario, Sinapsys.Datos.SQL datosTransaccion=null)
		{
			try 
			{
				VehiculoForWin new_values = new VehiculoForWin();
				new_values.strPlaca = strPlaca;
				new_values.centro = centro;
				new_values.TipoVehiculoCodigo = TipoVehiculoCodigo;
				new_values.Descripcion = Descripcion;
				new_values.dtmFechaIngreso = dtmFechaIngreso;
				new_values.dtmFechaEgreso = dtmFechaEgreso;
				new_values.nitPropietario = nitPropietario;
				new_values.strMarca = strMarca;
				new_values.lngModelo = lngModelo;
				new_values.lngMovil = lngMovil;
				new_values.strCelular = strCelular;
				new_values.strTipoMotor = strTipoMotor;
				new_values.strColor = strColor;
				new_values.strMotor = strMotor;
				new_values.strChasis = strChasis;
				new_values.logCamarote = logCamarote;
				new_values.cutPeso = cutPeso;
				new_values.cutCapacidad = cutCapacidad;
				new_values.lngEjes = lngEjes;
				new_values.logActivo = logActivo;
				new_values.lngLlantas = lngLlantas;
				new_values.strPolizaObligatorio = strPolizaObligatorio;
				new_values.nitProvedorOblig = nitProvedorOblig;
				new_values.dtmFechaInicioOblig = dtmFechaInicioOblig;
				new_values.dtmFechaVenceOblig = dtmFechaVenceOblig;
				new_values.strPolizaTodoRiesgo = strPolizaTodoRiesgo;
				new_values.nitProvedorTodo = nitProvedorTodo;
				new_values.dtmFechaInicioTodo = dtmFechaInicioTodo;
				new_values.dtmFechaVenceTodo = dtmFechaVenceTodo;
				new_values.strCertifMovilizacion = strCertifMovilizacion;
				new_values.dtmFechaInicioMoviliz = dtmFechaInicioMoviliz;
				new_values.dtmFechaVenceMoviliz = dtmFechaVenceMoviliz;
				new_values.strGases = strGases;
				new_values.dtmFechaInicioGases = dtmFechaInicioGases;
				new_values.dtmFechaVenceGases = dtmFechaVenceGases;
				new_values.strTarjetaOper = strTarjetaOper;
				new_values.dtmFechaInicioTarjetaOper = dtmFechaInicioTarjetaOper;
				new_values.dtmFechaVenceTarjetaOper = dtmFechaVenceTarjetaOper;
				new_values.logVencimientoFecha = logVencimientoFecha;
				VehiculoForWinDataProvider.Instance.Update(strPlaca, centro, TipoVehiculoCodigo, Descripcion, dtmFechaIngreso, dtmFechaEgreso, nitPropietario, strMarca, lngModelo, lngMovil, strCelular, strTipoMotor, strColor, strMotor, strChasis, logCamarote, cutPeso, cutCapacidad, lngEjes, logActivo, lngLlantas, strPolizaObligatorio, nitProvedorOblig, dtmFechaInicioOblig, dtmFechaVenceOblig, strPolizaTodoRiesgo, nitProvedorTodo, dtmFechaInicioTodo, dtmFechaVenceTodo, strCertifMovilizacion, dtmFechaInicioMoviliz, dtmFechaVenceMoviliz, strGases, dtmFechaInicioGases, dtmFechaVenceGases, strTarjetaOper, dtmFechaInicioTarjetaOper, dtmFechaVenceTarjetaOper, logVencimientoFecha, lngIdRegistro, lngIdUsuario,"VehiculoForWin",datosTransaccion);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Updates an VehiculoForWin object by passing one object's instance as reference
		/// </summary>
		/// <param name="vehiculoforwin">An instance of VehiculoForWin for reference</param>
		public void Update(VehiculoForWin vehiculoforwin,Sinapsys.Datos.SQL datosTransaccion=null)
		{
			Update(vehiculoforwin.strPlaca, vehiculoforwin.centro, vehiculoforwin.TipoVehiculoCodigo, vehiculoforwin.Descripcion, vehiculoforwin.dtmFechaIngreso, vehiculoforwin.dtmFechaEgreso, vehiculoforwin.nitPropietario, vehiculoforwin.strMarca, vehiculoforwin.lngModelo, vehiculoforwin.lngMovil, vehiculoforwin.strCelular, vehiculoforwin.strTipoMotor, vehiculoforwin.strColor, vehiculoforwin.strMotor, vehiculoforwin.strChasis, vehiculoforwin.logCamarote, vehiculoforwin.cutPeso, vehiculoforwin.cutCapacidad, vehiculoforwin.lngEjes, vehiculoforwin.logActivo, vehiculoforwin.lngLlantas, vehiculoforwin.strPolizaObligatorio, vehiculoforwin.nitProvedorOblig, vehiculoforwin.dtmFechaInicioOblig, vehiculoforwin.dtmFechaVenceOblig, vehiculoforwin.strPolizaTodoRiesgo, vehiculoforwin.nitProvedorTodo, vehiculoforwin.dtmFechaInicioTodo, vehiculoforwin.dtmFechaVenceTodo, vehiculoforwin.strCertifMovilizacion, vehiculoforwin.dtmFechaInicioMoviliz, vehiculoforwin.dtmFechaVenceMoviliz, vehiculoforwin.strGases, vehiculoforwin.dtmFechaInicioGases, vehiculoforwin.dtmFechaVenceGases, vehiculoforwin.strTarjetaOper, vehiculoforwin.dtmFechaInicioTarjetaOper, vehiculoforwin.dtmFechaVenceTarjetaOper, vehiculoforwin.logVencimientoFecha, vehiculoforwin.lngIdRegistro, vehiculoforwin.lngIdUsuario);
		}

		/// <summary>
		/// Delete  the VehiculoForWin object by passing a object
		/// </summary>
		public void  Delete(VehiculoForWin vehiculoforwin, Sinapsys.Datos.SQL datosTransaccion=null)
		{
			Delete(vehiculoforwin.lngIdRegistro, vehiculoforwin.lngIdUsuario,datosTransaccion);
		}

		/// <summary>
		/// Deletes the VehiculoForWin object by passing one object's instance as reference
		/// </summary>
		/// <param name="vehiculoforwin">An instance of VehiculoForWin for reference</param>
		public void Delete(int lngIdRegistro, int lngIdUsuario, Sinapsys.Datos.SQL datosTransaccion=null)
		{
			try 
			{
				VehiculoForWinDataProvider.Instance.Delete(lngIdRegistro, lngIdUsuario,"VehiculoForWin");
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Deletes the VehiculoForWin object by passing CVS parameter as reference
		/// </summary>
		/// <param name="vehiculoforwin">An instance of VehiculoForWin for reference</param>
		public void Delete(string CVSParameter)
		{
			string[] StrCommand=CVSParameter.Split(',');
			try 
			{
				int lngIdRegistro=int.Parse(StrCommand[0]);
				int lngIdUsuario=int.Parse(StrCommand[1]);
				VehiculoForWinDataProvider.Instance.Delete(lngIdRegistro, lngIdUsuario,"VehiculoForWin");
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Gets the VehiculoForWin object by passing the object's key fields
		/// </summary>
		/// <param name="lngIdRegistro">int that contents the lngIdRegistro value for the VehiculoForWin object</param>
		/// <param name="lngIdUsuario">int that contents the lngIdUsuario value for the VehiculoForWin object</param>
		/// <returns>One VehiculoForWin object</returns>
		public VehiculoForWin Get(int lngIdRegistro, int lngIdUsuario, bool generateUndo=false)
		{
			try 
			{
				VehiculoForWin vehiculoforwin = null;
				DataTable dt = VehiculoForWinDataProvider.Instance.Get(lngIdRegistro, lngIdUsuario);
				if ((dt.Rows.Count > 0))
				{
					vehiculoforwin = new VehiculoForWin();
					DataRow dr = dt.Rows[0];
					ReadData(vehiculoforwin, dr, generateUndo);
				}


				return vehiculoforwin;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Gets all objects of VehiculoForWin
		/// </summary>
		/// <returns>One VehiculoForWinList object</returns>
		public VehiculoForWinList GetAll(bool generateUndo=false)
		{
			try 
			{
				VehiculoForWinList vehiculoforwinlist = new VehiculoForWinList();
				DataTable dt = VehiculoForWinDataProvider.Instance.GetAll();
				foreach (DataRow dr in dt.Rows)
				{
					VehiculoForWin vehiculoforwin = new VehiculoForWin();
					ReadData(vehiculoforwin, dr, generateUndo);
					vehiculoforwinlist.Add(vehiculoforwin);
				}
				return vehiculoforwinlist;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Gets all objects of VehiculoForWin applying filter and sort criteria
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
		/// <returns>One VehiculoForWinList object</returns>
		public VehiculoForWinList GetFilter(int pagenum, int pagesize, string filter, string sort, string extablesfilter, string extablesfieldsfilter, string extablesrelationsfilter, string extablessort, string extablesfieldssort, string extablesrelationssort, bool generateUndo=false)
		{
			try 
			{
				VehiculoForWinList vehiculoforwinlist = new VehiculoForWinList();

				DataTable dt = VehiculoForWinDataProvider.Instance.GetFilter(pagenum, pagesize, filter, sort, extablesfilter, extablesfieldsfilter, extablesrelationsfilter, extablessort, extablesfieldssort, extablesrelationssort);

				foreach (DataRow dr in dt.Rows)
				{
					VehiculoForWin vehiculoforwin = new VehiculoForWin();
					ReadData(vehiculoforwin, dr, generateUndo);
					vehiculoforwinlist.Add(vehiculoforwin);
				}
				return vehiculoforwinlist;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public VehiculoForWinList GetFilter( string filter, string sort, bool generateUndo=false)
		{
			return GetFilter(0,0, filter, sort, "","","","","","",generateUndo);
		}

		public VehiculoForWinList GetFilter(string filter, string sort, string extablesfilter, string extablesfieldsfilter, string extablesrelationsfilter, string extablessort, string extablesfieldssort, string extablesrelationssort, bool generateUndo=false)
		{
			return GetFilter(0,0, filter, sort, extablesfilter, extablesfieldsfilter, extablesrelationsfilter, extablessort, extablesfieldssort, extablesrelationssort,generateUndo);
		}


		/// <summary>
		/// Returns the type for one property
		/// </summary>
		/// <param name="propertyname">Property's name for return its value</param>
		/// <returns>A value for the <paramref name="propertyname"/></returns>
		public Type GetMethodType( string propertyname,VehiculoForWin vehiculoforwin)
		{
			// Perform the search for the property's value
			switch (propertyname)
			{
				case "strPlaca":
					return vehiculoforwin.strPlaca.GetType();

				case "centro":
					return vehiculoforwin.centro.GetType();

				case "TipoVehiculoCodigo":
					return vehiculoforwin.TipoVehiculoCodigo.GetType();

				case "Descripcion":
					return vehiculoforwin.Descripcion.GetType();

				case "dtmFechaIngreso":
					return vehiculoforwin.dtmFechaIngreso.GetType();

				case "dtmFechaEgreso":
					return vehiculoforwin.dtmFechaEgreso.GetType();

				case "nitPropietario":
					return vehiculoforwin.nitPropietario.GetType();

				case "strMarca":
					return vehiculoforwin.strMarca.GetType();

				case "lngModelo":
					return vehiculoforwin.lngModelo.GetType();

				case "lngMovil":
					return vehiculoforwin.lngMovil.GetType();

				case "strCelular":
					return vehiculoforwin.strCelular.GetType();

				case "strTipoMotor":
					return vehiculoforwin.strTipoMotor.GetType();

				case "strColor":
					return vehiculoforwin.strColor.GetType();

				case "strMotor":
					return vehiculoforwin.strMotor.GetType();

				case "strChasis":
					return vehiculoforwin.strChasis.GetType();

				case "logCamarote":
					return vehiculoforwin.logCamarote.GetType();

				case "cutPeso":
					return vehiculoforwin.cutPeso.GetType();

				case "cutCapacidad":
					return vehiculoforwin.cutCapacidad.GetType();

				case "lngEjes":
					return vehiculoforwin.lngEjes.GetType();

				case "logActivo":
					return vehiculoforwin.logActivo.GetType();

				case "lngLlantas":
					return vehiculoforwin.lngLlantas.GetType();

				case "strPolizaObligatorio":
					return vehiculoforwin.strPolizaObligatorio.GetType();

				case "nitProvedorOblig":
					return vehiculoforwin.nitProvedorOblig.GetType();

				case "dtmFechaInicioOblig":
					return vehiculoforwin.dtmFechaInicioOblig.GetType();

				case "dtmFechaVenceOblig":
					return vehiculoforwin.dtmFechaVenceOblig.GetType();

				case "strPolizaTodoRiesgo":
					return vehiculoforwin.strPolizaTodoRiesgo.GetType();

				case "nitProvedorTodo":
					return vehiculoforwin.nitProvedorTodo.GetType();

				case "dtmFechaInicioTodo":
					return vehiculoforwin.dtmFechaInicioTodo.GetType();

				case "dtmFechaVenceTodo":
					return vehiculoforwin.dtmFechaVenceTodo.GetType();

				case "strCertifMovilizacion":
					return vehiculoforwin.strCertifMovilizacion.GetType();

				case "dtmFechaInicioMoviliz":
					return vehiculoforwin.dtmFechaInicioMoviliz.GetType();

				case "dtmFechaVenceMoviliz":
					return vehiculoforwin.dtmFechaVenceMoviliz.GetType();

				case "strGases":
					return vehiculoforwin.strGases.GetType();

				case "dtmFechaInicioGases":
					return vehiculoforwin.dtmFechaInicioGases.GetType();

				case "dtmFechaVenceGases":
					return vehiculoforwin.dtmFechaVenceGases.GetType();

				case "strTarjetaOper":
					return vehiculoforwin.strTarjetaOper.GetType();

				case "dtmFechaInicioTarjetaOper":
					return vehiculoforwin.dtmFechaInicioTarjetaOper.GetType();

				case "dtmFechaVenceTarjetaOper":
					return vehiculoforwin.dtmFechaVenceTarjetaOper.GetType();

				case "logVencimientoFecha":
					return vehiculoforwin.logVencimientoFecha.GetType();

				case "lngIdRegistro":
					return vehiculoforwin.lngIdRegistro.GetType();

				case "lngIdUsuario":
					return vehiculoforwin.lngIdUsuario.GetType();

			}

			return null;
		}
		/// <summary>
		/// update the changes in VehiculoForWin object by passing the object
		/// </summary>
		public bool UpdateChanges(VehiculoForWin vehiculoforwin, out string error,Sinapsys.Datos.SQL datosTransaccion=null)
		{
			if (vehiculoforwin.OldVehiculoForWin == null)
			{
				    error = "No tiene objeto con el cual comparar";
				    return false;
			}
			string[] Fields = vehiculoforwin.FieldChanged();
			error = "";
			return LiqViajes_Bll_Data.DataProvider.UpdateFieldsbyObject(Fields, vehiculoforwin, out error,datosTransaccion);
		}
	}

	#endregion

}
