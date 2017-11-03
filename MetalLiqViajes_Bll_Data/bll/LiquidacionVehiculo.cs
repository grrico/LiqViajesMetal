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
	#region LiquidacionVehiculoController

	/// <summary>
	/// Class for convert data from database into object's data and vice versa
	/// </summary>
	public partial class LiquidacionVehiculoController//: ILatinodeController
	{
		/// <summary>
		/// Generic Constructor
		/// </summary>
		public LiquidacionVehiculoController()
		{
		}

		/// <summary>
		/// Instance accessor for this singleton
		/// </summary>
		private static LiquidacionVehiculoController MySingleObj;
		public static LiquidacionVehiculoController Instance
		{
			get
			{
				if (MySingleObj == null)
				{
					MySingleObj = new LiquidacionVehiculoController();
				}
				return MySingleObj;
			}
		}

		// Reads object's data from a DataRow
		private void ReadData(LiquidacionVehiculo liquidacionvehiculo, DataRow dr,bool generateUndo=false)
		{
			try 
			{
				liquidacionvehiculo.strPlaca = dr.IsNull("strPlaca") ? null :(string) dr["strPlaca"];
				liquidacionvehiculo.intNitConductor = dr.IsNull("intNitConductor") ? null :(decimal?) dr["intNitConductor"];
				liquidacionvehiculo.curGastos = dr.IsNull("curGastos") ? null :(decimal?) dr["curGastos"];
				liquidacionvehiculo.curAnticipos = dr.IsNull("curAnticipos") ? null :(decimal?) dr["curAnticipos"];
				liquidacionvehiculo.curTotal = dr.IsNull("curTotal") ? null :(decimal?) dr["curTotal"];
				liquidacionvehiculo.dtmFechaModif = dr.IsNull("dtmFechaModif") ? null :(DateTime?) dr["dtmFechaModif"];
				liquidacionvehiculo.logLiquidado = dr.IsNull("logLiquidado") ? null :(bool?) dr["logLiquidado"];
				liquidacionvehiculo.sngRentabilidad = dr.IsNull("sngRentabilidad") ? null :(float?) dr["sngRentabilidad"];
				liquidacionvehiculo.curValorFleteAcum = dr.IsNull("curValorFleteAcum") ? null :(decimal?) dr["curValorFleteAcum"];
				liquidacionvehiculo.logDesplazaVacio = dr.IsNull("logDesplazaVacio") ? null :(bool?) dr["logDesplazaVacio"];
				liquidacionvehiculo.logSePuedeLiquidar = dr.IsNull("logSePuedeLiquidar") ? null :(bool?) dr["logSePuedeLiquidar"];
				liquidacionvehiculo.curValorFlete = dr.IsNull("curValorFlete") ? null :(decimal?) dr["curValorFlete"];
				liquidacionvehiculo.curvalorUtilidad = dr.IsNull("curvalorUtilidad") ? null :(decimal?) dr["curvalorUtilidad"];
				liquidacionvehiculo.curValorRentabilidad = dr.IsNull("curValorRentabilidad") ? null :(decimal?) dr["curValorRentabilidad"];
				liquidacionvehiculo.TotalGalones = dr.IsNull("TotalGalones") ? null :(decimal?) dr["TotalGalones"];
				liquidacionvehiculo.cutCombustible = dr.IsNull("cutCombustible") ? null :(decimal?) dr["cutCombustible"];
				liquidacionvehiculo.cutParticipacion = dr.IsNull("cutParticipacion") ? null :(decimal?) dr["cutParticipacion"];
				liquidacionvehiculo.cutParticipacionVacio = dr.IsNull("cutParticipacionVacio") ? null :(decimal?) dr["cutParticipacionVacio"];
				liquidacionvehiculo.logLiquParticipacion = dr.IsNull("logLiquParticipacion") ? null :(bool?) dr["logLiquParticipacion"];
				liquidacionvehiculo.logLiquKilometros = dr.IsNull("logLiquKilometros") ? null :(bool?) dr["logLiquKilometros"];
				liquidacionvehiculo.curValorKilometros = dr.IsNull("curValorKilometros") ? null :(decimal?) dr["curValorKilometros"];
				liquidacionvehiculo.Kilometros = dr.IsNull("Kilometros") ? null :(int?) dr["Kilometros"];
				liquidacionvehiculo.lngIdRegistro = (int) dr["lngIdRegistro"];
			}
			catch (Exception ex)
			{
				Utilidades.LogErrores(ex.Message + (ex.InnerException != null ? ex.InnerException.Message : ""), DataProvider.AplicacionNombre);
				throw ex;
			}
			if (generateUndo) liquidacionvehiculo.GenerateUndo();
		}

		/// <summary>
		/// Create a new LiquidacionVehiculo object by passing a object
		/// </summary>
		public LiquidacionVehiculo Create(LiquidacionVehiculo liquidacionvehiculo, Sinapsys.Datos.SQL datosTransaccion=null)
		{
			return Create(liquidacionvehiculo.lngIdRegistro,liquidacionvehiculo.strPlaca,liquidacionvehiculo.intNitConductor,liquidacionvehiculo.curGastos,liquidacionvehiculo.curAnticipos,liquidacionvehiculo.curTotal,liquidacionvehiculo.dtmFechaModif,liquidacionvehiculo.logLiquidado,liquidacionvehiculo.sngRentabilidad,liquidacionvehiculo.curValorFleteAcum,liquidacionvehiculo.logDesplazaVacio,liquidacionvehiculo.logSePuedeLiquidar,liquidacionvehiculo.curValorFlete,liquidacionvehiculo.curvalorUtilidad,liquidacionvehiculo.curValorRentabilidad,liquidacionvehiculo.TotalGalones,liquidacionvehiculo.cutCombustible,liquidacionvehiculo.cutParticipacion,liquidacionvehiculo.cutParticipacionVacio,liquidacionvehiculo.logLiquParticipacion,liquidacionvehiculo.logLiquKilometros,liquidacionvehiculo.curValorKilometros,liquidacionvehiculo.Kilometros,datosTransaccion);
		}

		/// <summary>
		/// Creates a new LiquidacionVehiculo object by passing all object's fields
		/// </summary>
		/// <param name="strPlaca">string that contents the strPlaca value for the LiquidacionVehiculo object</param>
		/// <param name="intNitConductor">decimal that contents the intNitConductor value for the LiquidacionVehiculo object</param>
		/// <param name="curGastos">decimal that contents the curGastos value for the LiquidacionVehiculo object</param>
		/// <param name="curAnticipos">decimal that contents the curAnticipos value for the LiquidacionVehiculo object</param>
		/// <param name="curTotal">decimal that contents the curTotal value for the LiquidacionVehiculo object</param>
		/// <param name="dtmFechaModif">DateTime that contents the dtmFechaModif value for the LiquidacionVehiculo object</param>
		/// <param name="logLiquidado">bool that contents the logLiquidado value for the LiquidacionVehiculo object</param>
		/// <param name="sngRentabilidad">float that contents the sngRentabilidad value for the LiquidacionVehiculo object</param>
		/// <param name="curValorFleteAcum">decimal that contents the curValorFleteAcum value for the LiquidacionVehiculo object</param>
		/// <param name="logDesplazaVacio">bool that contents the logDesplazaVacio value for the LiquidacionVehiculo object</param>
		/// <param name="logSePuedeLiquidar">bool that contents the logSePuedeLiquidar value for the LiquidacionVehiculo object</param>
		/// <param name="curValorFlete">decimal that contents the curValorFlete value for the LiquidacionVehiculo object</param>
		/// <param name="curvalorUtilidad">decimal that contents the curvalorUtilidad value for the LiquidacionVehiculo object</param>
		/// <param name="curValorRentabilidad">decimal that contents the curValorRentabilidad value for the LiquidacionVehiculo object</param>
		/// <param name="TotalGalones">decimal that contents the TotalGalones value for the LiquidacionVehiculo object</param>
		/// <param name="cutCombustible">decimal that contents the cutCombustible value for the LiquidacionVehiculo object</param>
		/// <param name="cutParticipacion">decimal that contents the cutParticipacion value for the LiquidacionVehiculo object</param>
		/// <param name="cutParticipacionVacio">decimal that contents the cutParticipacionVacio value for the LiquidacionVehiculo object</param>
		/// <param name="logLiquParticipacion">bool that contents the logLiquParticipacion value for the LiquidacionVehiculo object</param>
		/// <param name="logLiquKilometros">bool that contents the logLiquKilometros value for the LiquidacionVehiculo object</param>
		/// <param name="curValorKilometros">decimal that contents the curValorKilometros value for the LiquidacionVehiculo object</param>
		/// <param name="Kilometros">int that contents the Kilometros value for the LiquidacionVehiculo object</param>
		/// <returns>One LiquidacionVehiculo object</returns>
		public LiquidacionVehiculo Create(int lngIdRegistro, string strPlaca, decimal? intNitConductor, decimal? curGastos, decimal? curAnticipos, decimal? curTotal, DateTime? dtmFechaModif, bool? logLiquidado, float? sngRentabilidad, decimal? curValorFleteAcum, bool? logDesplazaVacio, bool? logSePuedeLiquidar, decimal? curValorFlete, decimal? curvalorUtilidad, decimal? curValorRentabilidad, decimal? TotalGalones, decimal? cutCombustible, decimal? cutParticipacion, decimal? cutParticipacionVacio, bool? logLiquParticipacion, bool? logLiquKilometros, decimal? curValorKilometros, int? Kilometros, Sinapsys.Datos.SQL datosTransaccion=null)
		{
			try 
			{
				LiquidacionVehiculo liquidacionvehiculo = new LiquidacionVehiculo();

				liquidacionvehiculo.lngIdRegistro = lngIdRegistro;
				liquidacionvehiculo.lngIdRegistro = lngIdRegistro;
				liquidacionvehiculo.strPlaca = strPlaca;
				liquidacionvehiculo.intNitConductor = intNitConductor;
				liquidacionvehiculo.curGastos = curGastos;
				liquidacionvehiculo.curAnticipos = curAnticipos;
				liquidacionvehiculo.curTotal = curTotal;
				liquidacionvehiculo.dtmFechaModif = dtmFechaModif;
				liquidacionvehiculo.logLiquidado = logLiquidado;
				liquidacionvehiculo.sngRentabilidad = sngRentabilidad;
				liquidacionvehiculo.curValorFleteAcum = curValorFleteAcum;
				liquidacionvehiculo.logDesplazaVacio = logDesplazaVacio;
				liquidacionvehiculo.logSePuedeLiquidar = logSePuedeLiquidar;
				liquidacionvehiculo.curValorFlete = curValorFlete;
				liquidacionvehiculo.curvalorUtilidad = curvalorUtilidad;
				liquidacionvehiculo.curValorRentabilidad = curValorRentabilidad;
				liquidacionvehiculo.TotalGalones = TotalGalones;
				liquidacionvehiculo.cutCombustible = cutCombustible;
				liquidacionvehiculo.cutParticipacion = cutParticipacion;
				liquidacionvehiculo.cutParticipacionVacio = cutParticipacionVacio;
				liquidacionvehiculo.logLiquParticipacion = logLiquParticipacion;
				liquidacionvehiculo.logLiquKilometros = logLiquKilometros;
				liquidacionvehiculo.curValorKilometros = curValorKilometros;
				liquidacionvehiculo.Kilometros = Kilometros;
				lngIdRegistro = LiquidacionVehiculoDataProvider.Instance.Create(lngIdRegistro, strPlaca, intNitConductor, curGastos, curAnticipos, curTotal, dtmFechaModif, logLiquidado, sngRentabilidad, curValorFleteAcum, logDesplazaVacio, logSePuedeLiquidar, curValorFlete, curvalorUtilidad, curValorRentabilidad, TotalGalones, cutCombustible, cutParticipacion, cutParticipacionVacio, logLiquParticipacion, logLiquKilometros, curValorKilometros, Kilometros,"LiquidacionVehiculo",datosTransaccion);
				if (lngIdRegistro == 0)
					return null;

				liquidacionvehiculo.lngIdRegistro = lngIdRegistro;

				return liquidacionvehiculo;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Updates an LiquidacionVehiculo object by passing all object's fields
		/// </summary>
		/// <param name="strPlaca">string that contents the strPlaca value for the LiquidacionVehiculo object</param>
		/// <param name="intNitConductor">decimal that contents the intNitConductor value for the LiquidacionVehiculo object</param>
		/// <param name="curGastos">decimal that contents the curGastos value for the LiquidacionVehiculo object</param>
		/// <param name="curAnticipos">decimal that contents the curAnticipos value for the LiquidacionVehiculo object</param>
		/// <param name="curTotal">decimal that contents the curTotal value for the LiquidacionVehiculo object</param>
		/// <param name="dtmFechaModif">DateTime that contents the dtmFechaModif value for the LiquidacionVehiculo object</param>
		/// <param name="logLiquidado">bool that contents the logLiquidado value for the LiquidacionVehiculo object</param>
		/// <param name="sngRentabilidad">float that contents the sngRentabilidad value for the LiquidacionVehiculo object</param>
		/// <param name="curValorFleteAcum">decimal that contents the curValorFleteAcum value for the LiquidacionVehiculo object</param>
		/// <param name="logDesplazaVacio">bool that contents the logDesplazaVacio value for the LiquidacionVehiculo object</param>
		/// <param name="logSePuedeLiquidar">bool that contents the logSePuedeLiquidar value for the LiquidacionVehiculo object</param>
		/// <param name="curValorFlete">decimal that contents the curValorFlete value for the LiquidacionVehiculo object</param>
		/// <param name="curvalorUtilidad">decimal that contents the curvalorUtilidad value for the LiquidacionVehiculo object</param>
		/// <param name="curValorRentabilidad">decimal that contents the curValorRentabilidad value for the LiquidacionVehiculo object</param>
		/// <param name="TotalGalones">decimal that contents the TotalGalones value for the LiquidacionVehiculo object</param>
		/// <param name="cutCombustible">decimal that contents the cutCombustible value for the LiquidacionVehiculo object</param>
		/// <param name="cutParticipacion">decimal that contents the cutParticipacion value for the LiquidacionVehiculo object</param>
		/// <param name="cutParticipacionVacio">decimal that contents the cutParticipacionVacio value for the LiquidacionVehiculo object</param>
		/// <param name="logLiquParticipacion">bool that contents the logLiquParticipacion value for the LiquidacionVehiculo object</param>
		/// <param name="logLiquKilometros">bool that contents the logLiquKilometros value for the LiquidacionVehiculo object</param>
		/// <param name="curValorKilometros">decimal that contents the curValorKilometros value for the LiquidacionVehiculo object</param>
		/// <param name="Kilometros">int that contents the Kilometros value for the LiquidacionVehiculo object</param>
		/// <param name="lngIdRegistro">int that contents the lngIdRegistro value for the LiquidacionVehiculo object</param>
		public void Update(string strPlaca, decimal? intNitConductor, decimal? curGastos, decimal? curAnticipos, decimal? curTotal, DateTime? dtmFechaModif, bool? logLiquidado, float? sngRentabilidad, decimal? curValorFleteAcum, bool? logDesplazaVacio, bool? logSePuedeLiquidar, decimal? curValorFlete, decimal? curvalorUtilidad, decimal? curValorRentabilidad, decimal? TotalGalones, decimal? cutCombustible, decimal? cutParticipacion, decimal? cutParticipacionVacio, bool? logLiquParticipacion, bool? logLiquKilometros, decimal? curValorKilometros, int? Kilometros, int lngIdRegistro, Sinapsys.Datos.SQL datosTransaccion=null)
		{
			try 
			{
				LiquidacionVehiculo new_values = new LiquidacionVehiculo();
				new_values.strPlaca = strPlaca;
				new_values.intNitConductor = intNitConductor;
				new_values.curGastos = curGastos;
				new_values.curAnticipos = curAnticipos;
				new_values.curTotal = curTotal;
				new_values.dtmFechaModif = dtmFechaModif;
				new_values.logLiquidado = logLiquidado;
				new_values.sngRentabilidad = sngRentabilidad;
				new_values.curValorFleteAcum = curValorFleteAcum;
				new_values.logDesplazaVacio = logDesplazaVacio;
				new_values.logSePuedeLiquidar = logSePuedeLiquidar;
				new_values.curValorFlete = curValorFlete;
				new_values.curvalorUtilidad = curvalorUtilidad;
				new_values.curValorRentabilidad = curValorRentabilidad;
				new_values.TotalGalones = TotalGalones;
				new_values.cutCombustible = cutCombustible;
				new_values.cutParticipacion = cutParticipacion;
				new_values.cutParticipacionVacio = cutParticipacionVacio;
				new_values.logLiquParticipacion = logLiquParticipacion;
				new_values.logLiquKilometros = logLiquKilometros;
				new_values.curValorKilometros = curValorKilometros;
				new_values.Kilometros = Kilometros;
				LiquidacionVehiculoDataProvider.Instance.Update(strPlaca, intNitConductor, curGastos, curAnticipos, curTotal, dtmFechaModif, logLiquidado, sngRentabilidad, curValorFleteAcum, logDesplazaVacio, logSePuedeLiquidar, curValorFlete, curvalorUtilidad, curValorRentabilidad, TotalGalones, cutCombustible, cutParticipacion, cutParticipacionVacio, logLiquParticipacion, logLiquKilometros, curValorKilometros, Kilometros, lngIdRegistro,"LiquidacionVehiculo",datosTransaccion);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Updates an LiquidacionVehiculo object by passing one object's instance as reference
		/// </summary>
		/// <param name="liquidacionvehiculo">An instance of LiquidacionVehiculo for reference</param>
		public void Update(LiquidacionVehiculo liquidacionvehiculo,Sinapsys.Datos.SQL datosTransaccion=null)
		{
			Update(liquidacionvehiculo.strPlaca, liquidacionvehiculo.intNitConductor, liquidacionvehiculo.curGastos, liquidacionvehiculo.curAnticipos, liquidacionvehiculo.curTotal, liquidacionvehiculo.dtmFechaModif, liquidacionvehiculo.logLiquidado, liquidacionvehiculo.sngRentabilidad, liquidacionvehiculo.curValorFleteAcum, liquidacionvehiculo.logDesplazaVacio, liquidacionvehiculo.logSePuedeLiquidar, liquidacionvehiculo.curValorFlete, liquidacionvehiculo.curvalorUtilidad, liquidacionvehiculo.curValorRentabilidad, liquidacionvehiculo.TotalGalones, liquidacionvehiculo.cutCombustible, liquidacionvehiculo.cutParticipacion, liquidacionvehiculo.cutParticipacionVacio, liquidacionvehiculo.logLiquParticipacion, liquidacionvehiculo.logLiquKilometros, liquidacionvehiculo.curValorKilometros, liquidacionvehiculo.Kilometros, liquidacionvehiculo.lngIdRegistro);
		}

		/// <summary>
		/// Delete  the LiquidacionVehiculo object by passing a object
		/// </summary>
		public void  Delete(LiquidacionVehiculo liquidacionvehiculo, Sinapsys.Datos.SQL datosTransaccion=null)
		{
			Delete(liquidacionvehiculo.lngIdRegistro,datosTransaccion);
		}

		/// <summary>
		/// Deletes the LiquidacionVehiculo object by passing one object's instance as reference
		/// </summary>
		/// <param name="liquidacionvehiculo">An instance of LiquidacionVehiculo for reference</param>
		public void Delete(int lngIdRegistro, Sinapsys.Datos.SQL datosTransaccion=null)
		{
			try 
			{
				//LiquidacionVehiculo old_values = LiquidacionVehiculoController.Instance.Get(lngIdRegistro);
				//if(!Validate.security.CanDeleteSecurityField(LiquidacionVehiculoController.Instance, (ILatinodeObject)old_values))
				//    throw new Exception("Access denied by security field, you can't delete object");

				LiquidacionVehiculoDataProvider.Instance.Delete(lngIdRegistro,"LiquidacionVehiculo");
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Deletes the LiquidacionVehiculo object by passing CVS parameter as reference
		/// </summary>
		/// <param name="liquidacionvehiculo">An instance of LiquidacionVehiculo for reference</param>
		public void Delete(string CVSParameter)
		{
			string[] StrCommand=CVSParameter.Split(',');
			try 
			{
				int lngIdRegistro=int.Parse(StrCommand[0]);
				LiquidacionVehiculoDataProvider.Instance.Delete(lngIdRegistro,"LiquidacionVehiculo");
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Gets the LiquidacionVehiculo object by passing the object's key fields
		/// </summary>
		/// <param name="lngIdRegistro">int that contents the lngIdRegistro value for the LiquidacionVehiculo object</param>
		/// <returns>One LiquidacionVehiculo object</returns>
		public LiquidacionVehiculo Get(int lngIdRegistro, bool generateUndo=false)
		{
			try 
			{
				LiquidacionVehiculo liquidacionvehiculo = null;
				DataTable dt = LiquidacionVehiculoDataProvider.Instance.Get(lngIdRegistro);
				if ((dt.Rows.Count > 0))
				{
					liquidacionvehiculo = new LiquidacionVehiculo();
					DataRow dr = dt.Rows[0];
					ReadData(liquidacionvehiculo, dr, generateUndo);
				}


				return liquidacionvehiculo;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Gets all objects of LiquidacionVehiculo
		/// </summary>
		/// <returns>One LiquidacionVehiculoList object</returns>
		public LiquidacionVehiculoList GetAll(bool generateUndo=false)
		{
			try 
			{
				LiquidacionVehiculoList liquidacionvehiculolist = new LiquidacionVehiculoList();
				DataTable dt = LiquidacionVehiculoDataProvider.Instance.GetAll();
				foreach (DataRow dr in dt.Rows)
				{
					LiquidacionVehiculo liquidacionvehiculo = new LiquidacionVehiculo();
					ReadData(liquidacionvehiculo, dr, generateUndo);
					liquidacionvehiculolist.Add(liquidacionvehiculo);
				}
				return liquidacionvehiculolist;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Selects all LiquidacionVehiculo objects by reference (Foreign Keys)
		/// </summary>
		/// <param name="intNitConductor">decimal that contents the intNitConductor value for the LiquidacionVehiculo object</param>
		/// <returns>One LiquidacionVehiculoList object</returns>
		public LiquidacionVehiculoList GetBy_intNitConductor(decimal intNitConductor,bool generateUndo=false)
		{
			try 
			{
				LiquidacionVehiculoList liquidacionvehiculolist = new LiquidacionVehiculoList();

				DataTable dt = LiquidacionVehiculoDataProvider.Instance.GetBy_intNitConductor(intNitConductor);
				foreach (DataRow dr in dt.Rows)
				{
					LiquidacionVehiculo liquidacionvehiculo = new LiquidacionVehiculo();
					ReadData(liquidacionvehiculo, dr, generateUndo);
					liquidacionvehiculolist.Add(liquidacionvehiculo);
				}
				return liquidacionvehiculolist;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Gets all objects of LiquidacionVehiculo applying filter and sort criteria
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
		/// <returns>One LiquidacionVehiculoList object</returns>
		public LiquidacionVehiculoList GetFilter(int pagenum, int pagesize, string filter, string sort, string extablesfilter, string extablesfieldsfilter, string extablesrelationsfilter, string extablessort, string extablesfieldssort, string extablesrelationssort, bool generateUndo=false)
		{
			try 
			{
				LiquidacionVehiculoList liquidacionvehiculolist = new LiquidacionVehiculoList();

				DataTable dt = LiquidacionVehiculoDataProvider.Instance.GetFilter(pagenum, pagesize, filter, sort, extablesfilter, extablesfieldsfilter, extablesrelationsfilter, extablessort, extablesfieldssort, extablesrelationssort);

				foreach (DataRow dr in dt.Rows)
				{
					LiquidacionVehiculo liquidacionvehiculo = new LiquidacionVehiculo();
					ReadData(liquidacionvehiculo, dr, generateUndo);
					liquidacionvehiculolist.Add(liquidacionvehiculo);
				}
				return liquidacionvehiculolist;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public LiquidacionVehiculoList GetFilter( string filter, string sort, bool generateUndo=false)
		{
			return GetFilter(0,0, filter, sort, "","","","","","",generateUndo);
		}

		public LiquidacionVehiculoList GetFilter(string filter, string sort, string extablesfilter, string extablesfieldsfilter, string extablesrelationsfilter, string extablessort, string extablesfieldssort, string extablesrelationssort, bool generateUndo=false)
		{
			return GetFilter(0,0, filter, sort, extablesfilter, extablesfieldsfilter, extablesrelationsfilter, extablessort, extablesfieldssort, extablesrelationssort,generateUndo);
		}


		/// <summary>
		/// Returns the type for one property
		/// </summary>
		/// <param name="propertyname">Property's name for return its value</param>
		/// <returns>A value for the <paramref name="propertyname"/></returns>
		public Type GetMethodType( string propertyname,LiquidacionVehiculo liquidacionvehiculo)
		{
			// Perform the search for the property's value
			switch (propertyname)
			{
				case "strPlaca":
					return liquidacionvehiculo.strPlaca.GetType();

				case "intNitConductor":
					return liquidacionvehiculo.intNitConductor.GetType();

				case "curGastos":
					return liquidacionvehiculo.curGastos.GetType();

				case "curAnticipos":
					return liquidacionvehiculo.curAnticipos.GetType();

				case "curTotal":
					return liquidacionvehiculo.curTotal.GetType();

				case "dtmFechaModif":
					return liquidacionvehiculo.dtmFechaModif.GetType();

				case "logLiquidado":
					return liquidacionvehiculo.logLiquidado.GetType();

				case "sngRentabilidad":
					return liquidacionvehiculo.sngRentabilidad.GetType();

				case "curValorFleteAcum":
					return liquidacionvehiculo.curValorFleteAcum.GetType();

				case "logDesplazaVacio":
					return liquidacionvehiculo.logDesplazaVacio.GetType();

				case "logSePuedeLiquidar":
					return liquidacionvehiculo.logSePuedeLiquidar.GetType();

				case "curValorFlete":
					return liquidacionvehiculo.curValorFlete.GetType();

				case "curvalorUtilidad":
					return liquidacionvehiculo.curvalorUtilidad.GetType();

				case "curValorRentabilidad":
					return liquidacionvehiculo.curValorRentabilidad.GetType();

				case "TotalGalones":
					return liquidacionvehiculo.TotalGalones.GetType();

				case "cutCombustible":
					return liquidacionvehiculo.cutCombustible.GetType();

				case "cutParticipacion":
					return liquidacionvehiculo.cutParticipacion.GetType();

				case "cutParticipacionVacio":
					return liquidacionvehiculo.cutParticipacionVacio.GetType();

				case "logLiquParticipacion":
					return liquidacionvehiculo.logLiquParticipacion.GetType();

				case "logLiquKilometros":
					return liquidacionvehiculo.logLiquKilometros.GetType();

				case "curValorKilometros":
					return liquidacionvehiculo.curValorKilometros.GetType();

				case "Kilometros":
					return liquidacionvehiculo.Kilometros.GetType();

				case "lngIdRegistro":
					return liquidacionvehiculo.lngIdRegistro.GetType();

			}

			return null;
		}
		/// <summary>
		/// update the changes in LiquidacionVehiculo object by passing the object
		/// </summary>
		public bool UpdateChanges(LiquidacionVehiculo liquidacionvehiculo, out string error,Sinapsys.Datos.SQL datosTransaccion=null)
		{
			if (liquidacionvehiculo.OldLiquidacionVehiculo == null)
			{
				    error = "No tiene objeto con el cual comparar";
				    return false;
			}
			string[] Fields = liquidacionvehiculo.FieldChanged();
			error = "";
			return LiqViajes_Bll_Data.DataProvider.UpdateFieldsbyObject(Fields, liquidacionvehiculo, out error,datosTransaccion);
		}
	}

	#endregion

}
