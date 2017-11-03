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
	#region RegistrosBorradosController

	/// <summary>
	/// Class for convert data from database into object's data and vice versa
	/// </summary>
	public partial class RegistrosBorradosController//: ILatinodeController
	{
		/// <summary>
		/// Generic Constructor
		/// </summary>
		public RegistrosBorradosController()
		{
		}

		/// <summary>
		/// Instance accessor for this singleton
		/// </summary>
		private static RegistrosBorradosController MySingleObj;
		public static RegistrosBorradosController Instance
		{
			get
			{
				if (MySingleObj == null)
				{
					MySingleObj = new RegistrosBorradosController();
				}
				return MySingleObj;
			}
		}

		// Reads object's data from a DataRow
		private void ReadData(RegistrosBorrados registrosborrados, DataRow dr,bool generateUndo=false)
		{
			try 
			{
				registrosborrados.lngIdRegistroViajeTramo = dr.IsNull("lngIdRegistroViajeTramo") ? null :(int?) dr["lngIdRegistroViajeTramo"];
				registrosborrados.lngIdRegistrRuta = dr.IsNull("lngIdRegistrRuta") ? null :(int?) dr["lngIdRegistrRuta"];
				registrosborrados.strRutaAnticipo = (string) dr["strRutaAnticipo"];
				registrosborrados.intNitConductor = dr.IsNull("intNitConductor") ? null :(double?) dr["intNitConductor"];
				registrosborrados.strConductor = dr.IsNull("strConductor") ? null :(string) dr["strConductor"];
				registrosborrados.strPlaca = (string) dr["strPlaca"];
				registrosborrados.lngIdBanco = dr.IsNull("lngIdBanco") ? null :(int?) dr["lngIdBanco"];
				registrosborrados.intDocumento = dr.IsNull("intDocumento") ? null :(int?) dr["intDocumento"];
				registrosborrados.strCuenta = dr.IsNull("strCuenta") ? null :(string) dr["strCuenta"];
				registrosborrados.curDebito = dr.IsNull("curDebito") ? null :(decimal?) dr["curDebito"];
				registrosborrados.curCredito = dr.IsNull("curCredito") ? null :(decimal?) dr["curCredito"];
				registrosborrados.curSaldo = dr.IsNull("curSaldo") ? null :(decimal?) dr["curSaldo"];
				registrosborrados.dtmFechaModif = dr.IsNull("dtmFechaModif") ? null :(DateTime?) dr["dtmFechaModif"];
				registrosborrados.strObservaciones = dr.IsNull("strObservaciones") ? null :(string) dr["strObservaciones"];
				registrosborrados.intCantidad = dr.IsNull("intCantidad") ? null :(int?) dr["intCantidad"];
				registrosborrados.logAnulado = dr.IsNull("logAnulado") ? null :(bool?) dr["logAnulado"];
				registrosborrados.lngIdRegistroViaje = (int) dr["lngIdRegistroViaje"];
			}
			catch (Exception ex)
			{
				Utilidades.LogErrores(ex.Message + (ex.InnerException != null ? ex.InnerException.Message : ""), DataProvider.AplicacionNombre);
				throw ex;
			}
			if (generateUndo) registrosborrados.GenerateUndo();
		}

		/// <summary>
		/// Create a new RegistrosBorrados object by passing a object
		/// </summary>
		public RegistrosBorrados Create(RegistrosBorrados registrosborrados, Sinapsys.Datos.SQL datosTransaccion=null)
		{
			return Create(registrosborrados.lngIdRegistroViaje,registrosborrados.lngIdRegistroViajeTramo,registrosborrados.lngIdRegistrRuta,registrosborrados.strRutaAnticipo,registrosborrados.intNitConductor,registrosborrados.strConductor,registrosborrados.strPlaca,registrosborrados.lngIdBanco,registrosborrados.intDocumento,registrosborrados.strCuenta,registrosborrados.curDebito,registrosborrados.curCredito,registrosborrados.curSaldo,registrosborrados.dtmFechaModif,registrosborrados.strObservaciones,registrosborrados.intCantidad,registrosborrados.logAnulado,datosTransaccion);
		}

		/// <summary>
		/// Creates a new RegistrosBorrados object by passing all object's fields
		/// </summary>
		/// <param name="lngIdRegistroViajeTramo">int that contents the lngIdRegistroViajeTramo value for the RegistrosBorrados object</param>
		/// <param name="lngIdRegistrRuta">int that contents the lngIdRegistrRuta value for the RegistrosBorrados object</param>
		/// <param name="strRutaAnticipo">string that contents the strRutaAnticipo value for the RegistrosBorrados object</param>
		/// <param name="intNitConductor">double that contents the intNitConductor value for the RegistrosBorrados object</param>
		/// <param name="strConductor">string that contents the strConductor value for the RegistrosBorrados object</param>
		/// <param name="strPlaca">string that contents the strPlaca value for the RegistrosBorrados object</param>
		/// <param name="lngIdBanco">int that contents the lngIdBanco value for the RegistrosBorrados object</param>
		/// <param name="intDocumento">int that contents the intDocumento value for the RegistrosBorrados object</param>
		/// <param name="strCuenta">string that contents the strCuenta value for the RegistrosBorrados object</param>
		/// <param name="curDebito">decimal that contents the curDebito value for the RegistrosBorrados object</param>
		/// <param name="curCredito">decimal that contents the curCredito value for the RegistrosBorrados object</param>
		/// <param name="curSaldo">decimal that contents the curSaldo value for the RegistrosBorrados object</param>
		/// <param name="dtmFechaModif">DateTime that contents the dtmFechaModif value for the RegistrosBorrados object</param>
		/// <param name="strObservaciones">string that contents the strObservaciones value for the RegistrosBorrados object</param>
		/// <param name="intCantidad">int that contents the intCantidad value for the RegistrosBorrados object</param>
		/// <param name="logAnulado">bool that contents the logAnulado value for the RegistrosBorrados object</param>
		/// <returns>One RegistrosBorrados object</returns>
		public RegistrosBorrados Create(int lngIdRegistroViaje, int? lngIdRegistroViajeTramo, int? lngIdRegistrRuta, string strRutaAnticipo, double? intNitConductor, string strConductor, string strPlaca, int? lngIdBanco, int? intDocumento, string strCuenta, decimal? curDebito, decimal? curCredito, decimal? curSaldo, DateTime? dtmFechaModif, string strObservaciones, int? intCantidad, bool? logAnulado, Sinapsys.Datos.SQL datosTransaccion=null)
		{
			try 
			{
				RegistrosBorrados registrosborrados = new RegistrosBorrados();

				registrosborrados.lngIdRegistroViaje = lngIdRegistroViaje;
				registrosborrados.lngIdRegistroViaje = lngIdRegistroViaje;
				registrosborrados.lngIdRegistroViajeTramo = lngIdRegistroViajeTramo;
				registrosborrados.lngIdRegistrRuta = lngIdRegistrRuta;
				registrosborrados.strRutaAnticipo = strRutaAnticipo;
				registrosborrados.intNitConductor = intNitConductor;
				registrosborrados.strConductor = strConductor;
				registrosborrados.strPlaca = strPlaca;
				registrosborrados.lngIdBanco = lngIdBanco;
				registrosborrados.intDocumento = intDocumento;
				registrosborrados.strCuenta = strCuenta;
				registrosborrados.curDebito = curDebito;
				registrosborrados.curCredito = curCredito;
				registrosborrados.curSaldo = curSaldo;
				registrosborrados.dtmFechaModif = dtmFechaModif;
				registrosborrados.strObservaciones = strObservaciones;
				registrosborrados.intCantidad = intCantidad;
				registrosborrados.logAnulado = logAnulado;
				lngIdRegistroViaje = RegistrosBorradosDataProvider.Instance.Create(lngIdRegistroViaje, lngIdRegistroViajeTramo, lngIdRegistrRuta, strRutaAnticipo, intNitConductor, strConductor, strPlaca, lngIdBanco, intDocumento, strCuenta, curDebito, curCredito, curSaldo, dtmFechaModif, strObservaciones, intCantidad, logAnulado,"RegistrosBorrados",datosTransaccion);
				if (lngIdRegistroViaje == 0)
					return null;

				registrosborrados.lngIdRegistroViaje = lngIdRegistroViaje;

				return registrosborrados;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Updates an RegistrosBorrados object by passing all object's fields
		/// </summary>
		/// <param name="lngIdRegistroViajeTramo">int that contents the lngIdRegistroViajeTramo value for the RegistrosBorrados object</param>
		/// <param name="lngIdRegistrRuta">int that contents the lngIdRegistrRuta value for the RegistrosBorrados object</param>
		/// <param name="strRutaAnticipo">string that contents the strRutaAnticipo value for the RegistrosBorrados object</param>
		/// <param name="intNitConductor">double that contents the intNitConductor value for the RegistrosBorrados object</param>
		/// <param name="strConductor">string that contents the strConductor value for the RegistrosBorrados object</param>
		/// <param name="strPlaca">string that contents the strPlaca value for the RegistrosBorrados object</param>
		/// <param name="lngIdBanco">int that contents the lngIdBanco value for the RegistrosBorrados object</param>
		/// <param name="intDocumento">int that contents the intDocumento value for the RegistrosBorrados object</param>
		/// <param name="strCuenta">string that contents the strCuenta value for the RegistrosBorrados object</param>
		/// <param name="curDebito">decimal that contents the curDebito value for the RegistrosBorrados object</param>
		/// <param name="curCredito">decimal that contents the curCredito value for the RegistrosBorrados object</param>
		/// <param name="curSaldo">decimal that contents the curSaldo value for the RegistrosBorrados object</param>
		/// <param name="dtmFechaModif">DateTime that contents the dtmFechaModif value for the RegistrosBorrados object</param>
		/// <param name="strObservaciones">string that contents the strObservaciones value for the RegistrosBorrados object</param>
		/// <param name="intCantidad">int that contents the intCantidad value for the RegistrosBorrados object</param>
		/// <param name="logAnulado">bool that contents the logAnulado value for the RegistrosBorrados object</param>
		/// <param name="lngIdRegistroViaje">int that contents the lngIdRegistroViaje value for the RegistrosBorrados object</param>
		public void Update(int? lngIdRegistroViajeTramo, int? lngIdRegistrRuta, string strRutaAnticipo, double? intNitConductor, string strConductor, string strPlaca, int? lngIdBanco, int? intDocumento, string strCuenta, decimal? curDebito, decimal? curCredito, decimal? curSaldo, DateTime? dtmFechaModif, string strObservaciones, int? intCantidad, bool? logAnulado, int lngIdRegistroViaje, Sinapsys.Datos.SQL datosTransaccion=null)
		{
			try 
			{
				RegistrosBorrados new_values = new RegistrosBorrados();
				new_values.lngIdRegistroViajeTramo = lngIdRegistroViajeTramo;
				new_values.lngIdRegistrRuta = lngIdRegistrRuta;
				new_values.strRutaAnticipo = strRutaAnticipo;
				new_values.intNitConductor = intNitConductor;
				new_values.strConductor = strConductor;
				new_values.strPlaca = strPlaca;
				new_values.lngIdBanco = lngIdBanco;
				new_values.intDocumento = intDocumento;
				new_values.strCuenta = strCuenta;
				new_values.curDebito = curDebito;
				new_values.curCredito = curCredito;
				new_values.curSaldo = curSaldo;
				new_values.dtmFechaModif = dtmFechaModif;
				new_values.strObservaciones = strObservaciones;
				new_values.intCantidad = intCantidad;
				new_values.logAnulado = logAnulado;
				RegistrosBorradosDataProvider.Instance.Update(lngIdRegistroViajeTramo, lngIdRegistrRuta, strRutaAnticipo, intNitConductor, strConductor, strPlaca, lngIdBanco, intDocumento, strCuenta, curDebito, curCredito, curSaldo, dtmFechaModif, strObservaciones, intCantidad, logAnulado, lngIdRegistroViaje,"RegistrosBorrados",datosTransaccion);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Updates an RegistrosBorrados object by passing one object's instance as reference
		/// </summary>
		/// <param name="registrosborrados">An instance of RegistrosBorrados for reference</param>
		public void Update(RegistrosBorrados registrosborrados,Sinapsys.Datos.SQL datosTransaccion=null)
		{
			Update(registrosborrados.lngIdRegistroViajeTramo, registrosborrados.lngIdRegistrRuta, registrosborrados.strRutaAnticipo, registrosborrados.intNitConductor, registrosborrados.strConductor, registrosborrados.strPlaca, registrosborrados.lngIdBanco, registrosborrados.intDocumento, registrosborrados.strCuenta, registrosborrados.curDebito, registrosborrados.curCredito, registrosborrados.curSaldo, registrosborrados.dtmFechaModif, registrosborrados.strObservaciones, registrosborrados.intCantidad, registrosborrados.logAnulado, registrosborrados.lngIdRegistroViaje);
		}

		/// <summary>
		/// Delete  the RegistrosBorrados object by passing a object
		/// </summary>
		public void  Delete(RegistrosBorrados registrosborrados, Sinapsys.Datos.SQL datosTransaccion=null)
		{
			Delete(registrosborrados.lngIdRegistroViaje,datosTransaccion);
		}

		/// <summary>
		/// Deletes the RegistrosBorrados object by passing one object's instance as reference
		/// </summary>
		/// <param name="registrosborrados">An instance of RegistrosBorrados for reference</param>
		public void Delete(int lngIdRegistroViaje, Sinapsys.Datos.SQL datosTransaccion=null)
		{
			try 
			{
				//RegistrosBorrados old_values = RegistrosBorradosController.Instance.Get(lngIdRegistroViaje);
				//if(!Validate.security.CanDeleteSecurityField(RegistrosBorradosController.Instance, (ILatinodeObject)old_values))
				//    throw new Exception("Access denied by security field, you can't delete object");

				RegistrosBorradosDataProvider.Instance.Delete(lngIdRegistroViaje,"RegistrosBorrados");
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Deletes the RegistrosBorrados object by passing CVS parameter as reference
		/// </summary>
		/// <param name="registrosborrados">An instance of RegistrosBorrados for reference</param>
		public void Delete(string CVSParameter)
		{
			string[] StrCommand=CVSParameter.Split(',');
			try 
			{
				int lngIdRegistroViaje=int.Parse(StrCommand[0]);
				RegistrosBorradosDataProvider.Instance.Delete(lngIdRegistroViaje,"RegistrosBorrados");
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Gets the RegistrosBorrados object by passing the object's key fields
		/// </summary>
		/// <param name="lngIdRegistroViaje">int that contents the lngIdRegistroViaje value for the RegistrosBorrados object</param>
		/// <returns>One RegistrosBorrados object</returns>
		public RegistrosBorrados Get(int lngIdRegistroViaje, bool generateUndo=false)
		{
			try 
			{
				RegistrosBorrados registrosborrados = null;
				registrosborrados= MasterTables.RegistrosBorrados.Where(r => r.lngIdRegistroViaje== lngIdRegistroViaje).FirstOrDefault();
				if (registrosborrados== null)
				{
					MasterTables.Reset("RegistrosBorrados");
					registrosborrados= MasterTables.RegistrosBorrados.Where(r => r.lngIdRegistroViaje== lngIdRegistroViaje).FirstOrDefault();
				}
				if (generateUndo) registrosborrados.GenerateUndo();

				return registrosborrados;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Gets all objects of RegistrosBorrados
		/// </summary>
		/// <returns>One RegistrosBorradosList object</returns>
		public RegistrosBorradosList GetAll(bool generateUndo=false)
		{
			try 
			{
				RegistrosBorradosList registrosborradoslist = new RegistrosBorradosList();
				DataTable dt = RegistrosBorradosDataProvider.Instance.GetAll();
				foreach (DataRow dr in dt.Rows)
				{
					RegistrosBorrados registrosborrados = new RegistrosBorrados();
					ReadData(registrosborrados, dr, generateUndo);
					registrosborradoslist.Add(registrosborrados);
				}
				return registrosborradoslist;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Gets all objects of RegistrosBorrados applying filter and sort criteria
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
		/// <returns>One RegistrosBorradosList object</returns>
		public RegistrosBorradosList GetFilter(int pagenum, int pagesize, string filter, string sort, string extablesfilter, string extablesfieldsfilter, string extablesrelationsfilter, string extablessort, string extablesfieldssort, string extablesrelationssort, bool generateUndo=false)
		{
			try 
			{
				RegistrosBorradosList registrosborradoslist = new RegistrosBorradosList();

				DataTable dt = RegistrosBorradosDataProvider.Instance.GetFilter(pagenum, pagesize, filter, sort, extablesfilter, extablesfieldsfilter, extablesrelationsfilter, extablessort, extablesfieldssort, extablesrelationssort);

				foreach (DataRow dr in dt.Rows)
				{
					RegistrosBorrados registrosborrados = new RegistrosBorrados();
					ReadData(registrosborrados, dr, generateUndo);
					registrosborradoslist.Add(registrosborrados);
				}
				return registrosborradoslist;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public RegistrosBorradosList GetFilter( string filter, string sort, bool generateUndo=false)
		{
			return GetFilter(0,0, filter, sort, "","","","","","",generateUndo);
		}

		public RegistrosBorradosList GetFilter(string filter, string sort, string extablesfilter, string extablesfieldsfilter, string extablesrelationsfilter, string extablessort, string extablesfieldssort, string extablesrelationssort, bool generateUndo=false)
		{
			return GetFilter(0,0, filter, sort, extablesfilter, extablesfieldsfilter, extablesrelationsfilter, extablessort, extablesfieldssort, extablesrelationssort,generateUndo);
		}


		/// <summary>
		/// Returns the type for one property
		/// </summary>
		/// <param name="propertyname">Property's name for return its value</param>
		/// <returns>A value for the <paramref name="propertyname"/></returns>
		public Type GetMethodType( string propertyname,RegistrosBorrados registrosborrados)
		{
			// Perform the search for the property's value
			switch (propertyname)
			{
				case "lngIdRegistroViajeTramo":
					return registrosborrados.lngIdRegistroViajeTramo.GetType();

				case "lngIdRegistrRuta":
					return registrosborrados.lngIdRegistrRuta.GetType();

				case "strRutaAnticipo":
					return registrosborrados.strRutaAnticipo.GetType();

				case "intNitConductor":
					return registrosborrados.intNitConductor.GetType();

				case "strConductor":
					return registrosborrados.strConductor.GetType();

				case "strPlaca":
					return registrosborrados.strPlaca.GetType();

				case "lngIdBanco":
					return registrosborrados.lngIdBanco.GetType();

				case "intDocumento":
					return registrosborrados.intDocumento.GetType();

				case "strCuenta":
					return registrosborrados.strCuenta.GetType();

				case "curDebito":
					return registrosborrados.curDebito.GetType();

				case "curCredito":
					return registrosborrados.curCredito.GetType();

				case "curSaldo":
					return registrosborrados.curSaldo.GetType();

				case "dtmFechaModif":
					return registrosborrados.dtmFechaModif.GetType();

				case "strObservaciones":
					return registrosborrados.strObservaciones.GetType();

				case "intCantidad":
					return registrosborrados.intCantidad.GetType();

				case "logAnulado":
					return registrosborrados.logAnulado.GetType();

				case "lngIdRegistroViaje":
					return registrosborrados.lngIdRegistroViaje.GetType();

			}

			return null;
		}
		/// <summary>
		/// update the changes in RegistrosBorrados object by passing the object
		/// </summary>
		public bool UpdateChanges(RegistrosBorrados registrosborrados, out string error,Sinapsys.Datos.SQL datosTransaccion=null)
		{
			if (registrosborrados.OldRegistrosBorrados == null)
			{
				    error = "No tiene objeto con el cual comparar";
				    return false;
			}
			string[] Fields = registrosborrados.FieldChanged();
			error = "";
			return LiqViajes_Bll_Data.DataProvider.UpdateFieldsbyObject(Fields, registrosborrados, out error,datosTransaccion);
		}
	}

	#endregion

}
