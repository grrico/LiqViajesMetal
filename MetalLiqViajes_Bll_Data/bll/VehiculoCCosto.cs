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
	#region VehiculoCCostoController

	/// <summary>
	/// Class for convert data from database into object's data and vice versa
	/// </summary>
	public partial class VehiculoCCostoController//: ILatinodeController
	{
		/// <summary>
		/// Generic Constructor
		/// </summary>
		public VehiculoCCostoController()
		{
		}

		/// <summary>
		/// Instance accessor for this singleton
		/// </summary>
		private static VehiculoCCostoController MySingleObj;
		public static VehiculoCCostoController Instance
		{
			get
			{
				if (MySingleObj == null)
				{
					MySingleObj = new VehiculoCCostoController();
				}
				return MySingleObj;
			}
		}

		// Reads object's data from a DataRow
		private void ReadData(VehiculoCCosto vehiculoccosto, DataRow dr,bool generateUndo=false)
		{
			try 
			{
				vehiculoccosto.lngIdRegistro = (int) dr["lngIdRegistro"];
				vehiculoccosto.lngIdUsuario = dr.IsNull("lngIdUsuario") ? null :(double?) dr["lngIdUsuario"];
				vehiculoccosto.strPlaca = dr.IsNull("strPlaca") ? null :(string) dr["strPlaca"];
				vehiculoccosto.centro = dr.IsNull("centro") ? null :(double?) dr["centro"];
				vehiculoccosto.TipoTrailerCodigo = dr.IsNull("TipoTrailerCodigo") ? null :(int?) dr["TipoTrailerCodigo"];
				vehiculoccosto.TipoVehiculoCodigo = dr.IsNull("TipoVehiculoCodigo") ? null :(int?) dr["TipoVehiculoCodigo"];
				vehiculoccosto.Descripcion = dr.IsNull("Descripcion") ? null :(string) dr["Descripcion"];
				vehiculoccosto.dtmFechaIngreso = dr.IsNull("dtmFechaIngreso") ? null :(DateTime?) dr["dtmFechaIngreso"];
				vehiculoccosto.dtmFechaEgreso = dr.IsNull("dtmFechaEgreso") ? null :(DateTime?) dr["dtmFechaEgreso"];
				vehiculoccosto.nitPropietario = dr.IsNull("nitPropietario") ? null :(double?) dr["nitPropietario"];
				vehiculoccosto.strMarca = dr.IsNull("strMarca") ? null :(string) dr["strMarca"];
				vehiculoccosto.lngModelo = dr.IsNull("lngModelo") ? null :(double?) dr["lngModelo"];
				vehiculoccosto.lngMovil = dr.IsNull("lngMovil") ? null :(double?) dr["lngMovil"];
				vehiculoccosto.strCelular = dr.IsNull("strCelular") ? null :(double?) dr["strCelular"];
				vehiculoccosto.strTipoMotor = dr.IsNull("strTipoMotor") ? null :(double?) dr["strTipoMotor"];
				vehiculoccosto.strColor = dr.IsNull("strColor") ? null :(string) dr["strColor"];
				vehiculoccosto.strMotor = dr.IsNull("strMotor") ? null :(string) dr["strMotor"];
				vehiculoccosto.strChasis = dr.IsNull("strChasis") ? null :(string) dr["strChasis"];
				vehiculoccosto.logCamarote = dr.IsNull("logCamarote") ? null :(bool?) dr["logCamarote"];
				vehiculoccosto.CapacidadGalores = dr.IsNull("CapacidadGalores") ? null :(decimal?) dr["CapacidadGalores"];
				vehiculoccosto.floGalonesReserva = dr.IsNull("floGalonesReserva") ? null :(decimal?) dr["floGalonesReserva"];
				vehiculoccosto.floCantGalonesReserva = dr.IsNull("floCantGalonesReserva") ? null :(decimal?) dr["floCantGalonesReserva"];
				vehiculoccosto.floTolerancia = dr.IsNull("floTolerancia") ? null :(decimal?) dr["floTolerancia"];
				vehiculoccosto.cutPeso = dr.IsNull("cutPeso") ? null :(double?) dr["cutPeso"];
				vehiculoccosto.cutCapacidad = dr.IsNull("cutCapacidad") ? null :(double?) dr["cutCapacidad"];
				vehiculoccosto.lngEjes = dr.IsNull("lngEjes") ? null :(double?) dr["lngEjes"];
				vehiculoccosto.logActivo = dr.IsNull("logActivo") ? null :(double?) dr["logActivo"];
				vehiculoccosto.lngLlantas = dr.IsNull("lngLlantas") ? null :(double?) dr["lngLlantas"];
				vehiculoccosto.strPolizaObligatorio = dr.IsNull("strPolizaObligatorio") ? null :(string) dr["strPolizaObligatorio"];
				vehiculoccosto.nitProvedorOblig = dr.IsNull("nitProvedorOblig") ? null :(double?) dr["nitProvedorOblig"];
				vehiculoccosto.dtmFechaInicioOblig = dr.IsNull("dtmFechaInicioOblig") ? null :(DateTime?) dr["dtmFechaInicioOblig"];
				vehiculoccosto.dtmFechaVenceOblig = dr.IsNull("dtmFechaVenceOblig") ? null :(DateTime?) dr["dtmFechaVenceOblig"];
				vehiculoccosto.strPolizaTodoRiesgo = dr.IsNull("strPolizaTodoRiesgo") ? null :(string) dr["strPolizaTodoRiesgo"];
				vehiculoccosto.nitProvedorTodo = dr.IsNull("nitProvedorTodo") ? null :(double?) dr["nitProvedorTodo"];
				vehiculoccosto.dtmFechaInicioTodo = dr.IsNull("dtmFechaInicioTodo") ? null :(DateTime?) dr["dtmFechaInicioTodo"];
				vehiculoccosto.dtmFechaVenceTodo = dr.IsNull("dtmFechaVenceTodo") ? null :(DateTime?) dr["dtmFechaVenceTodo"];
				vehiculoccosto.strCertifMovilizacion = dr.IsNull("strCertifMovilizacion") ? null :(string) dr["strCertifMovilizacion"];
				vehiculoccosto.dtmFechaInicioMoviliz = dr.IsNull("dtmFechaInicioMoviliz") ? null :(DateTime?) dr["dtmFechaInicioMoviliz"];
				vehiculoccosto.dtmFechaVenceMoviliz = dr.IsNull("dtmFechaVenceMoviliz") ? null :(DateTime?) dr["dtmFechaVenceMoviliz"];
				vehiculoccosto.strGases = dr.IsNull("strGases") ? null :(string) dr["strGases"];
				vehiculoccosto.dtmFechaInicioGases = dr.IsNull("dtmFechaInicioGases") ? null :(DateTime?) dr["dtmFechaInicioGases"];
				vehiculoccosto.dtmFechaVenceGases = dr.IsNull("dtmFechaVenceGases") ? null :(DateTime?) dr["dtmFechaVenceGases"];
				vehiculoccosto.strTarjetaOper = dr.IsNull("strTarjetaOper") ? null :(string) dr["strTarjetaOper"];
				vehiculoccosto.dtmFechaInicioTarjetaOper = dr.IsNull("dtmFechaInicioTarjetaOper") ? null :(DateTime?) dr["dtmFechaInicioTarjetaOper"];
				vehiculoccosto.dtmFechaVenceTarjetaOper = dr.IsNull("dtmFechaVenceTarjetaOper") ? null :(DateTime?) dr["dtmFechaVenceTarjetaOper"];
				vehiculoccosto.logVencimientoFecha = dr.IsNull("logVencimientoFecha") ? null :(bool?) dr["logVencimientoFecha"];
				vehiculoccosto.Placa = dr.IsNull("Placa") ? null :(string) dr["Placa"];
			}
			catch (Exception ex)
			{
				Utilidades.LogErrores(ex.Message + (ex.InnerException != null ? ex.InnerException.Message : ""), DataProvider.AplicacionNombre);
				throw ex;
			}
			if (generateUndo) vehiculoccosto.GenerateUndo();
		}

		/// <summary>
		/// Create a new VehiculoCCosto object by passing a object
		/// </summary>
		public VehiculoCCosto Create(VehiculoCCosto vehiculoccosto, Sinapsys.Datos.SQL datosTransaccion=null)
		{
			return Create(vehiculoccosto.lngIdRegistro,vehiculoccosto.lngIdUsuario,vehiculoccosto.strPlaca,vehiculoccosto.centro,vehiculoccosto.TipoTrailerCodigo,vehiculoccosto.TipoVehiculoCodigo,vehiculoccosto.Descripcion,vehiculoccosto.dtmFechaIngreso,vehiculoccosto.dtmFechaEgreso,vehiculoccosto.nitPropietario,vehiculoccosto.strMarca,vehiculoccosto.lngModelo,vehiculoccosto.lngMovil,vehiculoccosto.strCelular,vehiculoccosto.strTipoMotor,vehiculoccosto.strColor,vehiculoccosto.strMotor,vehiculoccosto.strChasis,vehiculoccosto.logCamarote,vehiculoccosto.CapacidadGalores,vehiculoccosto.floGalonesReserva,vehiculoccosto.floCantGalonesReserva,vehiculoccosto.floTolerancia,vehiculoccosto.cutPeso,vehiculoccosto.cutCapacidad,vehiculoccosto.lngEjes,vehiculoccosto.logActivo,vehiculoccosto.lngLlantas,vehiculoccosto.strPolizaObligatorio,vehiculoccosto.nitProvedorOblig,vehiculoccosto.dtmFechaInicioOblig,vehiculoccosto.dtmFechaVenceOblig,vehiculoccosto.strPolizaTodoRiesgo,vehiculoccosto.nitProvedorTodo,vehiculoccosto.dtmFechaInicioTodo,vehiculoccosto.dtmFechaVenceTodo,vehiculoccosto.strCertifMovilizacion,vehiculoccosto.dtmFechaInicioMoviliz,vehiculoccosto.dtmFechaVenceMoviliz,vehiculoccosto.strGases,vehiculoccosto.dtmFechaInicioGases,vehiculoccosto.dtmFechaVenceGases,vehiculoccosto.strTarjetaOper,vehiculoccosto.dtmFechaInicioTarjetaOper,vehiculoccosto.dtmFechaVenceTarjetaOper,vehiculoccosto.logVencimientoFecha,vehiculoccosto.Placa,datosTransaccion);
		}

		/// <summary>
		/// Creates a new VehiculoCCosto object by passing all object's fields
		/// </summary>
		/// <param name="lngIdUsuario">double that contents the lngIdUsuario value for the VehiculoCCosto object</param>
		/// <param name="strPlaca">string that contents the strPlaca value for the VehiculoCCosto object</param>
		/// <param name="centro">double that contents the centro value for the VehiculoCCosto object</param>
		/// <param name="TipoTrailerCodigo">int that contents the TipoTrailerCodigo value for the VehiculoCCosto object</param>
		/// <param name="TipoVehiculoCodigo">int that contents the TipoVehiculoCodigo value for the VehiculoCCosto object</param>
		/// <param name="Descripcion">string that contents the Descripcion value for the VehiculoCCosto object</param>
		/// <param name="dtmFechaIngreso">DateTime that contents the dtmFechaIngreso value for the VehiculoCCosto object</param>
		/// <param name="dtmFechaEgreso">DateTime that contents the dtmFechaEgreso value for the VehiculoCCosto object</param>
		/// <param name="nitPropietario">double that contents the nitPropietario value for the VehiculoCCosto object</param>
		/// <param name="strMarca">string that contents the strMarca value for the VehiculoCCosto object</param>
		/// <param name="lngModelo">double that contents the lngModelo value for the VehiculoCCosto object</param>
		/// <param name="lngMovil">double that contents the lngMovil value for the VehiculoCCosto object</param>
		/// <param name="strCelular">double that contents the strCelular value for the VehiculoCCosto object</param>
		/// <param name="strTipoMotor">double that contents the strTipoMotor value for the VehiculoCCosto object</param>
		/// <param name="strColor">string that contents the strColor value for the VehiculoCCosto object</param>
		/// <param name="strMotor">string that contents the strMotor value for the VehiculoCCosto object</param>
		/// <param name="strChasis">string that contents the strChasis value for the VehiculoCCosto object</param>
		/// <param name="logCamarote">bool that contents the logCamarote value for the VehiculoCCosto object</param>
		/// <param name="CapacidadGalores">decimal that contents the CapacidadGalores value for the VehiculoCCosto object</param>
		/// <param name="floGalonesReserva">decimal that contents the floGalonesReserva value for the VehiculoCCosto object</param>
		/// <param name="floCantGalonesReserva">decimal that contents the floCantGalonesReserva value for the VehiculoCCosto object</param>
		/// <param name="floTolerancia">decimal that contents the floTolerancia value for the VehiculoCCosto object</param>
		/// <param name="cutPeso">double that contents the cutPeso value for the VehiculoCCosto object</param>
		/// <param name="cutCapacidad">double that contents the cutCapacidad value for the VehiculoCCosto object</param>
		/// <param name="lngEjes">double that contents the lngEjes value for the VehiculoCCosto object</param>
		/// <param name="logActivo">double that contents the logActivo value for the VehiculoCCosto object</param>
		/// <param name="lngLlantas">double that contents the lngLlantas value for the VehiculoCCosto object</param>
		/// <param name="strPolizaObligatorio">string that contents the strPolizaObligatorio value for the VehiculoCCosto object</param>
		/// <param name="nitProvedorOblig">double that contents the nitProvedorOblig value for the VehiculoCCosto object</param>
		/// <param name="dtmFechaInicioOblig">DateTime that contents the dtmFechaInicioOblig value for the VehiculoCCosto object</param>
		/// <param name="dtmFechaVenceOblig">DateTime that contents the dtmFechaVenceOblig value for the VehiculoCCosto object</param>
		/// <param name="strPolizaTodoRiesgo">string that contents the strPolizaTodoRiesgo value for the VehiculoCCosto object</param>
		/// <param name="nitProvedorTodo">double that contents the nitProvedorTodo value for the VehiculoCCosto object</param>
		/// <param name="dtmFechaInicioTodo">DateTime that contents the dtmFechaInicioTodo value for the VehiculoCCosto object</param>
		/// <param name="dtmFechaVenceTodo">DateTime that contents the dtmFechaVenceTodo value for the VehiculoCCosto object</param>
		/// <param name="strCertifMovilizacion">string that contents the strCertifMovilizacion value for the VehiculoCCosto object</param>
		/// <param name="dtmFechaInicioMoviliz">DateTime that contents the dtmFechaInicioMoviliz value for the VehiculoCCosto object</param>
		/// <param name="dtmFechaVenceMoviliz">DateTime that contents the dtmFechaVenceMoviliz value for the VehiculoCCosto object</param>
		/// <param name="strGases">string that contents the strGases value for the VehiculoCCosto object</param>
		/// <param name="dtmFechaInicioGases">DateTime that contents the dtmFechaInicioGases value for the VehiculoCCosto object</param>
		/// <param name="dtmFechaVenceGases">DateTime that contents the dtmFechaVenceGases value for the VehiculoCCosto object</param>
		/// <param name="strTarjetaOper">string that contents the strTarjetaOper value for the VehiculoCCosto object</param>
		/// <param name="dtmFechaInicioTarjetaOper">DateTime that contents the dtmFechaInicioTarjetaOper value for the VehiculoCCosto object</param>
		/// <param name="dtmFechaVenceTarjetaOper">DateTime that contents the dtmFechaVenceTarjetaOper value for the VehiculoCCosto object</param>
		/// <param name="logVencimientoFecha">bool that contents the logVencimientoFecha value for the VehiculoCCosto object</param>
		/// <param name="Placa">string that contents the Placa value for the VehiculoCCosto object</param>
		/// <returns>One VehiculoCCosto object</returns>
		public VehiculoCCosto Create(int lngIdRegistro, double? lngIdUsuario, string strPlaca, double? centro, int? TipoTrailerCodigo, int? TipoVehiculoCodigo, string Descripcion, DateTime? dtmFechaIngreso, DateTime? dtmFechaEgreso, double? nitPropietario, string strMarca, double? lngModelo, double? lngMovil, double? strCelular, double? strTipoMotor, string strColor, string strMotor, string strChasis, bool? logCamarote, decimal? CapacidadGalores, decimal? floGalonesReserva, decimal? floCantGalonesReserva, decimal? floTolerancia, double? cutPeso, double? cutCapacidad, double? lngEjes, double? logActivo, double? lngLlantas, string strPolizaObligatorio, double? nitProvedorOblig, DateTime? dtmFechaInicioOblig, DateTime? dtmFechaVenceOblig, string strPolizaTodoRiesgo, double? nitProvedorTodo, DateTime? dtmFechaInicioTodo, DateTime? dtmFechaVenceTodo, string strCertifMovilizacion, DateTime? dtmFechaInicioMoviliz, DateTime? dtmFechaVenceMoviliz, string strGases, DateTime? dtmFechaInicioGases, DateTime? dtmFechaVenceGases, string strTarjetaOper, DateTime? dtmFechaInicioTarjetaOper, DateTime? dtmFechaVenceTarjetaOper, bool? logVencimientoFecha, string Placa, Sinapsys.Datos.SQL datosTransaccion=null)
		{
			try 
			{
				VehiculoCCosto vehiculoccosto = new VehiculoCCosto();

				vehiculoccosto.lngIdRegistro = lngIdRegistro;
				vehiculoccosto.lngIdRegistro = lngIdRegistro;
				vehiculoccosto.lngIdUsuario = lngIdUsuario;
				vehiculoccosto.strPlaca = strPlaca;
				vehiculoccosto.centro = centro;
				vehiculoccosto.TipoTrailerCodigo = TipoTrailerCodigo;
				vehiculoccosto.TipoVehiculoCodigo = TipoVehiculoCodigo;
				vehiculoccosto.Descripcion = Descripcion;
				vehiculoccosto.dtmFechaIngreso = dtmFechaIngreso;
				vehiculoccosto.dtmFechaEgreso = dtmFechaEgreso;
				vehiculoccosto.nitPropietario = nitPropietario;
				vehiculoccosto.strMarca = strMarca;
				vehiculoccosto.lngModelo = lngModelo;
				vehiculoccosto.lngMovil = lngMovil;
				vehiculoccosto.strCelular = strCelular;
				vehiculoccosto.strTipoMotor = strTipoMotor;
				vehiculoccosto.strColor = strColor;
				vehiculoccosto.strMotor = strMotor;
				vehiculoccosto.strChasis = strChasis;
				vehiculoccosto.logCamarote = logCamarote;
				vehiculoccosto.CapacidadGalores = CapacidadGalores;
				vehiculoccosto.floGalonesReserva = floGalonesReserva;
				vehiculoccosto.floCantGalonesReserva = floCantGalonesReserva;
				vehiculoccosto.floTolerancia = floTolerancia;
				vehiculoccosto.cutPeso = cutPeso;
				vehiculoccosto.cutCapacidad = cutCapacidad;
				vehiculoccosto.lngEjes = lngEjes;
				vehiculoccosto.logActivo = logActivo;
				vehiculoccosto.lngLlantas = lngLlantas;
				vehiculoccosto.strPolizaObligatorio = strPolizaObligatorio;
				vehiculoccosto.nitProvedorOblig = nitProvedorOblig;
				vehiculoccosto.dtmFechaInicioOblig = dtmFechaInicioOblig;
				vehiculoccosto.dtmFechaVenceOblig = dtmFechaVenceOblig;
				vehiculoccosto.strPolizaTodoRiesgo = strPolizaTodoRiesgo;
				vehiculoccosto.nitProvedorTodo = nitProvedorTodo;
				vehiculoccosto.dtmFechaInicioTodo = dtmFechaInicioTodo;
				vehiculoccosto.dtmFechaVenceTodo = dtmFechaVenceTodo;
				vehiculoccosto.strCertifMovilizacion = strCertifMovilizacion;
				vehiculoccosto.dtmFechaInicioMoviliz = dtmFechaInicioMoviliz;
				vehiculoccosto.dtmFechaVenceMoviliz = dtmFechaVenceMoviliz;
				vehiculoccosto.strGases = strGases;
				vehiculoccosto.dtmFechaInicioGases = dtmFechaInicioGases;
				vehiculoccosto.dtmFechaVenceGases = dtmFechaVenceGases;
				vehiculoccosto.strTarjetaOper = strTarjetaOper;
				vehiculoccosto.dtmFechaInicioTarjetaOper = dtmFechaInicioTarjetaOper;
				vehiculoccosto.dtmFechaVenceTarjetaOper = dtmFechaVenceTarjetaOper;
				vehiculoccosto.logVencimientoFecha = logVencimientoFecha;
				vehiculoccosto.Placa = Placa;
				lngIdRegistro = VehiculoCCostoDataProvider.Instance.Create(lngIdRegistro, lngIdUsuario, strPlaca, centro, TipoTrailerCodigo, TipoVehiculoCodigo, Descripcion, dtmFechaIngreso, dtmFechaEgreso, nitPropietario, strMarca, lngModelo, lngMovil, strCelular, strTipoMotor, strColor, strMotor, strChasis, logCamarote, CapacidadGalores, floGalonesReserva, floCantGalonesReserva, floTolerancia, cutPeso, cutCapacidad, lngEjes, logActivo, lngLlantas, strPolizaObligatorio, nitProvedorOblig, dtmFechaInicioOblig, dtmFechaVenceOblig, strPolizaTodoRiesgo, nitProvedorTodo, dtmFechaInicioTodo, dtmFechaVenceTodo, strCertifMovilizacion, dtmFechaInicioMoviliz, dtmFechaVenceMoviliz, strGases, dtmFechaInicioGases, dtmFechaVenceGases, strTarjetaOper, dtmFechaInicioTarjetaOper, dtmFechaVenceTarjetaOper, logVencimientoFecha, Placa,"VehiculoCCosto",datosTransaccion);
				if (lngIdRegistro == 0)
					return null;

				vehiculoccosto.lngIdRegistro = lngIdRegistro;

				return vehiculoccosto;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Updates an VehiculoCCosto object by passing all object's fields
		/// </summary>
		/// <param name="lngIdRegistro">int that contents the lngIdRegistro value for the VehiculoCCosto object</param>
		/// <param name="lngIdUsuario">double that contents the lngIdUsuario value for the VehiculoCCosto object</param>
		/// <param name="strPlaca">string that contents the strPlaca value for the VehiculoCCosto object</param>
		/// <param name="centro">double that contents the centro value for the VehiculoCCosto object</param>
		/// <param name="TipoTrailerCodigo">int that contents the TipoTrailerCodigo value for the VehiculoCCosto object</param>
		/// <param name="TipoVehiculoCodigo">int that contents the TipoVehiculoCodigo value for the VehiculoCCosto object</param>
		/// <param name="Descripcion">string that contents the Descripcion value for the VehiculoCCosto object</param>
		/// <param name="dtmFechaIngreso">DateTime that contents the dtmFechaIngreso value for the VehiculoCCosto object</param>
		/// <param name="dtmFechaEgreso">DateTime that contents the dtmFechaEgreso value for the VehiculoCCosto object</param>
		/// <param name="nitPropietario">double that contents the nitPropietario value for the VehiculoCCosto object</param>
		/// <param name="strMarca">string that contents the strMarca value for the VehiculoCCosto object</param>
		/// <param name="lngModelo">double that contents the lngModelo value for the VehiculoCCosto object</param>
		/// <param name="lngMovil">double that contents the lngMovil value for the VehiculoCCosto object</param>
		/// <param name="strCelular">double that contents the strCelular value for the VehiculoCCosto object</param>
		/// <param name="strTipoMotor">double that contents the strTipoMotor value for the VehiculoCCosto object</param>
		/// <param name="strColor">string that contents the strColor value for the VehiculoCCosto object</param>
		/// <param name="strMotor">string that contents the strMotor value for the VehiculoCCosto object</param>
		/// <param name="strChasis">string that contents the strChasis value for the VehiculoCCosto object</param>
		/// <param name="logCamarote">bool that contents the logCamarote value for the VehiculoCCosto object</param>
		/// <param name="CapacidadGalores">decimal that contents the CapacidadGalores value for the VehiculoCCosto object</param>
		/// <param name="floGalonesReserva">decimal that contents the floGalonesReserva value for the VehiculoCCosto object</param>
		/// <param name="floCantGalonesReserva">decimal that contents the floCantGalonesReserva value for the VehiculoCCosto object</param>
		/// <param name="floTolerancia">decimal that contents the floTolerancia value for the VehiculoCCosto object</param>
		/// <param name="cutPeso">double that contents the cutPeso value for the VehiculoCCosto object</param>
		/// <param name="cutCapacidad">double that contents the cutCapacidad value for the VehiculoCCosto object</param>
		/// <param name="lngEjes">double that contents the lngEjes value for the VehiculoCCosto object</param>
		/// <param name="logActivo">double that contents the logActivo value for the VehiculoCCosto object</param>
		/// <param name="lngLlantas">double that contents the lngLlantas value for the VehiculoCCosto object</param>
		/// <param name="strPolizaObligatorio">string that contents the strPolizaObligatorio value for the VehiculoCCosto object</param>
		/// <param name="nitProvedorOblig">double that contents the nitProvedorOblig value for the VehiculoCCosto object</param>
		/// <param name="dtmFechaInicioOblig">DateTime that contents the dtmFechaInicioOblig value for the VehiculoCCosto object</param>
		/// <param name="dtmFechaVenceOblig">DateTime that contents the dtmFechaVenceOblig value for the VehiculoCCosto object</param>
		/// <param name="strPolizaTodoRiesgo">string that contents the strPolizaTodoRiesgo value for the VehiculoCCosto object</param>
		/// <param name="nitProvedorTodo">double that contents the nitProvedorTodo value for the VehiculoCCosto object</param>
		/// <param name="dtmFechaInicioTodo">DateTime that contents the dtmFechaInicioTodo value for the VehiculoCCosto object</param>
		/// <param name="dtmFechaVenceTodo">DateTime that contents the dtmFechaVenceTodo value for the VehiculoCCosto object</param>
		/// <param name="strCertifMovilizacion">string that contents the strCertifMovilizacion value for the VehiculoCCosto object</param>
		/// <param name="dtmFechaInicioMoviliz">DateTime that contents the dtmFechaInicioMoviliz value for the VehiculoCCosto object</param>
		/// <param name="dtmFechaVenceMoviliz">DateTime that contents the dtmFechaVenceMoviliz value for the VehiculoCCosto object</param>
		/// <param name="strGases">string that contents the strGases value for the VehiculoCCosto object</param>
		/// <param name="dtmFechaInicioGases">DateTime that contents the dtmFechaInicioGases value for the VehiculoCCosto object</param>
		/// <param name="dtmFechaVenceGases">DateTime that contents the dtmFechaVenceGases value for the VehiculoCCosto object</param>
		/// <param name="strTarjetaOper">string that contents the strTarjetaOper value for the VehiculoCCosto object</param>
		/// <param name="dtmFechaInicioTarjetaOper">DateTime that contents the dtmFechaInicioTarjetaOper value for the VehiculoCCosto object</param>
		/// <param name="dtmFechaVenceTarjetaOper">DateTime that contents the dtmFechaVenceTarjetaOper value for the VehiculoCCosto object</param>
		/// <param name="logVencimientoFecha">bool that contents the logVencimientoFecha value for the VehiculoCCosto object</param>
		/// <param name="Placa">string that contents the Placa value for the VehiculoCCosto object</param>
		public void Update(int lngIdRegistro, double? lngIdUsuario, string strPlaca, double? centro, int? TipoTrailerCodigo, int? TipoVehiculoCodigo, string Descripcion, DateTime? dtmFechaIngreso, DateTime? dtmFechaEgreso, double? nitPropietario, string strMarca, double? lngModelo, double? lngMovil, double? strCelular, double? strTipoMotor, string strColor, string strMotor, string strChasis, bool? logCamarote, decimal? CapacidadGalores, decimal? floGalonesReserva, decimal? floCantGalonesReserva, decimal? floTolerancia, double? cutPeso, double? cutCapacidad, double? lngEjes, double? logActivo, double? lngLlantas, string strPolizaObligatorio, double? nitProvedorOblig, DateTime? dtmFechaInicioOblig, DateTime? dtmFechaVenceOblig, string strPolizaTodoRiesgo, double? nitProvedorTodo, DateTime? dtmFechaInicioTodo, DateTime? dtmFechaVenceTodo, string strCertifMovilizacion, DateTime? dtmFechaInicioMoviliz, DateTime? dtmFechaVenceMoviliz, string strGases, DateTime? dtmFechaInicioGases, DateTime? dtmFechaVenceGases, string strTarjetaOper, DateTime? dtmFechaInicioTarjetaOper, DateTime? dtmFechaVenceTarjetaOper, bool? logVencimientoFecha, string Placa, Sinapsys.Datos.SQL datosTransaccion=null)
		{
			try 
			{
				VehiculoCCosto new_values = new VehiculoCCosto();
				new_values.lngIdUsuario = lngIdUsuario;
				new_values.strPlaca = strPlaca;
				new_values.centro = centro;
				new_values.TipoTrailerCodigo = TipoTrailerCodigo;
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
				new_values.CapacidadGalores = CapacidadGalores;
				new_values.floGalonesReserva = floGalonesReserva;
				new_values.floCantGalonesReserva = floCantGalonesReserva;
				new_values.floTolerancia = floTolerancia;
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
				new_values.Placa = Placa;
				VehiculoCCostoDataProvider.Instance.Update(lngIdRegistro, lngIdUsuario, strPlaca, centro, TipoTrailerCodigo, TipoVehiculoCodigo, Descripcion, dtmFechaIngreso, dtmFechaEgreso, nitPropietario, strMarca, lngModelo, lngMovil, strCelular, strTipoMotor, strColor, strMotor, strChasis, logCamarote, CapacidadGalores, floGalonesReserva, floCantGalonesReserva, floTolerancia, cutPeso, cutCapacidad, lngEjes, logActivo, lngLlantas, strPolizaObligatorio, nitProvedorOblig, dtmFechaInicioOblig, dtmFechaVenceOblig, strPolizaTodoRiesgo, nitProvedorTodo, dtmFechaInicioTodo, dtmFechaVenceTodo, strCertifMovilizacion, dtmFechaInicioMoviliz, dtmFechaVenceMoviliz, strGases, dtmFechaInicioGases, dtmFechaVenceGases, strTarjetaOper, dtmFechaInicioTarjetaOper, dtmFechaVenceTarjetaOper, logVencimientoFecha, Placa,"VehiculoCCosto",datosTransaccion);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Updates an VehiculoCCosto object by passing one object's instance as reference
		/// </summary>
		/// <param name="vehiculoccosto">An instance of VehiculoCCosto for reference</param>
		public void Update(VehiculoCCosto vehiculoccosto,Sinapsys.Datos.SQL datosTransaccion=null)
		{
			Update(vehiculoccosto.lngIdRegistro, vehiculoccosto.lngIdUsuario, vehiculoccosto.strPlaca, vehiculoccosto.centro, vehiculoccosto.TipoTrailerCodigo, vehiculoccosto.TipoVehiculoCodigo, vehiculoccosto.Descripcion, vehiculoccosto.dtmFechaIngreso, vehiculoccosto.dtmFechaEgreso, vehiculoccosto.nitPropietario, vehiculoccosto.strMarca, vehiculoccosto.lngModelo, vehiculoccosto.lngMovil, vehiculoccosto.strCelular, vehiculoccosto.strTipoMotor, vehiculoccosto.strColor, vehiculoccosto.strMotor, vehiculoccosto.strChasis, vehiculoccosto.logCamarote, vehiculoccosto.CapacidadGalores, vehiculoccosto.floGalonesReserva, vehiculoccosto.floCantGalonesReserva, vehiculoccosto.floTolerancia, vehiculoccosto.cutPeso, vehiculoccosto.cutCapacidad, vehiculoccosto.lngEjes, vehiculoccosto.logActivo, vehiculoccosto.lngLlantas, vehiculoccosto.strPolizaObligatorio, vehiculoccosto.nitProvedorOblig, vehiculoccosto.dtmFechaInicioOblig, vehiculoccosto.dtmFechaVenceOblig, vehiculoccosto.strPolizaTodoRiesgo, vehiculoccosto.nitProvedorTodo, vehiculoccosto.dtmFechaInicioTodo, vehiculoccosto.dtmFechaVenceTodo, vehiculoccosto.strCertifMovilizacion, vehiculoccosto.dtmFechaInicioMoviliz, vehiculoccosto.dtmFechaVenceMoviliz, vehiculoccosto.strGases, vehiculoccosto.dtmFechaInicioGases, vehiculoccosto.dtmFechaVenceGases, vehiculoccosto.strTarjetaOper, vehiculoccosto.dtmFechaInicioTarjetaOper, vehiculoccosto.dtmFechaVenceTarjetaOper, vehiculoccosto.logVencimientoFecha, vehiculoccosto.Placa);
		}

		/// <summary>
		/// Delete  the VehiculoCCosto object by passing a object
		/// </summary>
		public void  Delete(VehiculoCCosto vehiculoccosto, Sinapsys.Datos.SQL datosTransaccion=null)
		{
			Delete(vehiculoccosto.lngIdRegistro,datosTransaccion);
		}

		/// <summary>
		/// Deletes the VehiculoCCosto object by passing one object's instance as reference
		/// </summary>
		/// <param name="vehiculoccosto">An instance of VehiculoCCosto for reference</param>
		public void Delete(int lngIdRegistro, Sinapsys.Datos.SQL datosTransaccion=null)
		{
			try 
			{
				//VehiculoCCosto old_values = VehiculoCCostoController.Instance.Get(lngIdRegistro);
				//if(!Validate.security.CanDeleteSecurityField(VehiculoCCostoController.Instance, (ILatinodeObject)old_values))
				//    throw new Exception("Access denied by security field, you can't delete object");

				VehiculoCCostoDataProvider.Instance.Delete(lngIdRegistro,"VehiculoCCosto");
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Deletes the VehiculoCCosto object by passing CVS parameter as reference
		/// </summary>
		/// <param name="vehiculoccosto">An instance of VehiculoCCosto for reference</param>
		public void Delete(string CVSParameter)
		{
			string[] StrCommand=CVSParameter.Split(',');
			try 
			{
				int lngIdRegistro=int.Parse(StrCommand[0]);
				VehiculoCCostoDataProvider.Instance.Delete(lngIdRegistro,"VehiculoCCosto");
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Gets the VehiculoCCosto object by passing the object's key fields
		/// </summary>
		/// <param name="lngIdRegistro">int that contents the lngIdRegistro value for the VehiculoCCosto object</param>
		/// <returns>One VehiculoCCosto object</returns>
		public VehiculoCCosto Get(int lngIdRegistro, bool generateUndo=false)
		{
			try 
			{
				VehiculoCCosto vehiculoccosto = null;
				vehiculoccosto= MasterTables.VehiculoCCosto.Where(r => r.lngIdRegistro== lngIdRegistro).FirstOrDefault();
				if (vehiculoccosto== null)
				{
					MasterTables.Reset("VehiculoCCosto");
					vehiculoccosto= MasterTables.VehiculoCCosto.Where(r => r.lngIdRegistro== lngIdRegistro).FirstOrDefault();
				}
				if (generateUndo) vehiculoccosto.GenerateUndo();

				return vehiculoccosto;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Gets all objects of VehiculoCCosto
		/// </summary>
		/// <returns>One VehiculoCCostoList object</returns>
		public VehiculoCCostoList GetAll(bool generateUndo=false)
		{
			try 
			{
				VehiculoCCostoList vehiculoccostolist = new VehiculoCCostoList();
				DataTable dt = VehiculoCCostoDataProvider.Instance.GetAll();
				foreach (DataRow dr in dt.Rows)
				{
					VehiculoCCosto vehiculoccosto = new VehiculoCCosto();
					ReadData(vehiculoccosto, dr, generateUndo);
					vehiculoccostolist.Add(vehiculoccosto);
				}
				return vehiculoccostolist;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Selects all VehiculoCCosto objects by reference (Foreign Keys)
		/// </summary>
		/// <param name="TipoVehiculoCodigo">int that contents the TipoVehiculoCodigo value for the VehiculoCCosto object</param>
		/// <returns>One VehiculoCCostoList object</returns>
		public VehiculoCCostoList GetBy_TipoVehiculoCodigo(int TipoVehiculoCodigo,bool generateUndo=false)
		{
			try 
			{
				VehiculoCCostoList vehiculoccostolist = new VehiculoCCostoList();

				DataTable dt = VehiculoCCostoDataProvider.Instance.GetBy_TipoVehiculoCodigo(TipoVehiculoCodigo);
				foreach (DataRow dr in dt.Rows)
				{
					VehiculoCCosto vehiculoccosto = new VehiculoCCosto();
					ReadData(vehiculoccosto, dr, generateUndo);
					vehiculoccostolist.Add(vehiculoccosto);
				}
				return vehiculoccostolist;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Gets all objects of VehiculoCCosto applying filter and sort criteria
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
		/// <returns>One VehiculoCCostoList object</returns>
		public VehiculoCCostoList GetFilter(int pagenum, int pagesize, string filter, string sort, string extablesfilter, string extablesfieldsfilter, string extablesrelationsfilter, string extablessort, string extablesfieldssort, string extablesrelationssort, bool generateUndo=false)
		{
			try 
			{
				VehiculoCCostoList vehiculoccostolist = new VehiculoCCostoList();

				DataTable dt = VehiculoCCostoDataProvider.Instance.GetFilter(pagenum, pagesize, filter, sort, extablesfilter, extablesfieldsfilter, extablesrelationsfilter, extablessort, extablesfieldssort, extablesrelationssort);

				foreach (DataRow dr in dt.Rows)
				{
					VehiculoCCosto vehiculoccosto = new VehiculoCCosto();
					ReadData(vehiculoccosto, dr, generateUndo);
					vehiculoccostolist.Add(vehiculoccosto);
				}
				return vehiculoccostolist;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public VehiculoCCostoList GetFilter( string filter, string sort, bool generateUndo=false)
		{
			return GetFilter(0,0, filter, sort, "","","","","","",generateUndo);
		}

		public VehiculoCCostoList GetFilter(string filter, string sort, string extablesfilter, string extablesfieldsfilter, string extablesrelationsfilter, string extablessort, string extablesfieldssort, string extablesrelationssort, bool generateUndo=false)
		{
			return GetFilter(0,0, filter, sort, extablesfilter, extablesfieldsfilter, extablesrelationsfilter, extablessort, extablesfieldssort, extablesrelationssort,generateUndo);
		}


		/// <summary>
		/// Returns the type for one property
		/// </summary>
		/// <param name="propertyname">Property's name for return its value</param>
		/// <returns>A value for the <paramref name="propertyname"/></returns>
		public Type GetMethodType( string propertyname,VehiculoCCosto vehiculoccosto)
		{
			// Perform the search for the property's value
			switch (propertyname)
			{
				case "lngIdRegistro":
					return vehiculoccosto.lngIdRegistro.GetType();

				case "lngIdUsuario":
					return vehiculoccosto.lngIdUsuario.GetType();

				case "strPlaca":
					return vehiculoccosto.strPlaca.GetType();

				case "centro":
					return vehiculoccosto.centro.GetType();

				case "TipoTrailerCodigo":
					return vehiculoccosto.TipoTrailerCodigo.GetType();

				case "TipoVehiculoCodigo":
					return vehiculoccosto.TipoVehiculoCodigo.GetType();

				case "Descripcion":
					return vehiculoccosto.Descripcion.GetType();

				case "dtmFechaIngreso":
					return vehiculoccosto.dtmFechaIngreso.GetType();

				case "dtmFechaEgreso":
					return vehiculoccosto.dtmFechaEgreso.GetType();

				case "nitPropietario":
					return vehiculoccosto.nitPropietario.GetType();

				case "strMarca":
					return vehiculoccosto.strMarca.GetType();

				case "lngModelo":
					return vehiculoccosto.lngModelo.GetType();

				case "lngMovil":
					return vehiculoccosto.lngMovil.GetType();

				case "strCelular":
					return vehiculoccosto.strCelular.GetType();

				case "strTipoMotor":
					return vehiculoccosto.strTipoMotor.GetType();

				case "strColor":
					return vehiculoccosto.strColor.GetType();

				case "strMotor":
					return vehiculoccosto.strMotor.GetType();

				case "strChasis":
					return vehiculoccosto.strChasis.GetType();

				case "logCamarote":
					return vehiculoccosto.logCamarote.GetType();

				case "CapacidadGalores":
					return vehiculoccosto.CapacidadGalores.GetType();

				case "floGalonesReserva":
					return vehiculoccosto.floGalonesReserva.GetType();

				case "floCantGalonesReserva":
					return vehiculoccosto.floCantGalonesReserva.GetType();

				case "floTolerancia":
					return vehiculoccosto.floTolerancia.GetType();

				case "cutPeso":
					return vehiculoccosto.cutPeso.GetType();

				case "cutCapacidad":
					return vehiculoccosto.cutCapacidad.GetType();

				case "lngEjes":
					return vehiculoccosto.lngEjes.GetType();

				case "logActivo":
					return vehiculoccosto.logActivo.GetType();

				case "lngLlantas":
					return vehiculoccosto.lngLlantas.GetType();

				case "strPolizaObligatorio":
					return vehiculoccosto.strPolizaObligatorio.GetType();

				case "nitProvedorOblig":
					return vehiculoccosto.nitProvedorOblig.GetType();

				case "dtmFechaInicioOblig":
					return vehiculoccosto.dtmFechaInicioOblig.GetType();

				case "dtmFechaVenceOblig":
					return vehiculoccosto.dtmFechaVenceOblig.GetType();

				case "strPolizaTodoRiesgo":
					return vehiculoccosto.strPolizaTodoRiesgo.GetType();

				case "nitProvedorTodo":
					return vehiculoccosto.nitProvedorTodo.GetType();

				case "dtmFechaInicioTodo":
					return vehiculoccosto.dtmFechaInicioTodo.GetType();

				case "dtmFechaVenceTodo":
					return vehiculoccosto.dtmFechaVenceTodo.GetType();

				case "strCertifMovilizacion":
					return vehiculoccosto.strCertifMovilizacion.GetType();

				case "dtmFechaInicioMoviliz":
					return vehiculoccosto.dtmFechaInicioMoviliz.GetType();

				case "dtmFechaVenceMoviliz":
					return vehiculoccosto.dtmFechaVenceMoviliz.GetType();

				case "strGases":
					return vehiculoccosto.strGases.GetType();

				case "dtmFechaInicioGases":
					return vehiculoccosto.dtmFechaInicioGases.GetType();

				case "dtmFechaVenceGases":
					return vehiculoccosto.dtmFechaVenceGases.GetType();

				case "strTarjetaOper":
					return vehiculoccosto.strTarjetaOper.GetType();

				case "dtmFechaInicioTarjetaOper":
					return vehiculoccosto.dtmFechaInicioTarjetaOper.GetType();

				case "dtmFechaVenceTarjetaOper":
					return vehiculoccosto.dtmFechaVenceTarjetaOper.GetType();

				case "logVencimientoFecha":
					return vehiculoccosto.logVencimientoFecha.GetType();

				case "Placa":
					return vehiculoccosto.Placa.GetType();

			}

			return null;
		}
		/// <summary>
		/// update the changes in VehiculoCCosto object by passing the object
		/// </summary>
		public bool UpdateChanges(VehiculoCCosto vehiculoccosto, out string error,Sinapsys.Datos.SQL datosTransaccion=null)
		{
			if (vehiculoccosto.OldVehiculoCCosto == null)
			{
				    error = "No tiene objeto con el cual comparar";
				    return false;
			}
			string[] Fields = vehiculoccosto.FieldChanged();
			error = "";
			return LiqViajes_Bll_Data.DataProvider.UpdateFieldsbyObject(Fields, vehiculoccosto, out error,datosTransaccion);
		}
	}

	#endregion

}
