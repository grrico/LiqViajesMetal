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
	#region CuentasController

	/// <summary>
	/// Class for convert data from database into object's data and vice versa
	/// </summary>
	public partial class CuentasController//: ILatinodeController
	{
		/// <summary>
		/// Generic Constructor
		/// </summary>
		public CuentasController()
		{
		}

		/// <summary>
		/// Instance accessor for this singleton
		/// </summary>
		private static CuentasController MySingleObj;
		public static CuentasController Instance
		{
			get
			{
				if (MySingleObj == null)
				{
					MySingleObj = new CuentasController();
				}
				return MySingleObj;
			}
		}

		// Reads object's data from a DataRow
		private void ReadData(Cuentas cuentas, DataRow dr,bool generateUndo=false)
		{
			try 
			{
				cuentas.strCuenta = (string) dr["strCuenta"];
				cuentas.strDescripcion = dr.IsNull("strDescripcion") ? null :(string) dr["strDescripcion"];
				cuentas.logAnticipo = dr.IsNull("logAnticipo") ? null :(bool?) dr["logAnticipo"];
				cuentas.nitTercero = dr.IsNull("nitTercero") ? null :(string) dr["nitTercero"];
				cuentas.intNoColReferencia = dr.IsNull("intNoColReferencia") ? null :(int?) dr["intNoColReferencia"];
				cuentas.sngPorcenrajeAplica = dr.IsNull("sngPorcenrajeAplica") ? null :(double?) dr["sngPorcenrajeAplica"];
				cuentas.strCuentaAplica = dr.IsNull("strCuentaAplica") ? null :(string) dr["strCuentaAplica"];
				cuentas.strCuentaNiif = dr.IsNull("strCuentaNiif") ? null :(string) dr["strCuentaNiif"];
				cuentas.Norma = dr.IsNull("Norma") ? null :(string) dr["Norma"];
				cuentas.Codigo = (int) dr["Codigo"];
			}
			catch (Exception ex)
			{
				Utilidades.LogErrores(ex.Message + (ex.InnerException != null ? ex.InnerException.Message : ""), DataProvider.AplicacionNombre);
				throw ex;
			}
			if (generateUndo) cuentas.GenerateUndo();
		}

		/// <summary>
		/// Create a new Cuentas object by passing a object
		/// </summary>
		public Cuentas Create(Cuentas cuentas, Sinapsys.Datos.SQL datosTransaccion=null)
		{
			return Create(cuentas.Codigo,cuentas.strCuenta,cuentas.strDescripcion,cuentas.logAnticipo,cuentas.nitTercero,cuentas.intNoColReferencia,cuentas.sngPorcenrajeAplica,cuentas.strCuentaAplica,cuentas.strCuentaNiif,cuentas.Norma,datosTransaccion);
		}

		/// <summary>
		/// Creates a new Cuentas object by passing all object's fields
		/// </summary>
		/// <param name="strCuenta">string that contents the strCuenta value for the Cuentas object</param>
		/// <param name="strDescripcion">string that contents the strDescripcion value for the Cuentas object</param>
		/// <param name="logAnticipo">bool that contents the logAnticipo value for the Cuentas object</param>
		/// <param name="nitTercero">string that contents the nitTercero value for the Cuentas object</param>
		/// <param name="intNoColReferencia">int that contents the intNoColReferencia value for the Cuentas object</param>
		/// <param name="sngPorcenrajeAplica">double that contents the sngPorcenrajeAplica value for the Cuentas object</param>
		/// <param name="strCuentaAplica">string that contents the strCuentaAplica value for the Cuentas object</param>
		/// <param name="strCuentaNiif">string that contents the strCuentaNiif value for the Cuentas object</param>
		/// <param name="Norma">string that contents the Norma value for the Cuentas object</param>
		/// <returns>One Cuentas object</returns>
		public Cuentas Create(int Codigo, string strCuenta, string strDescripcion, bool? logAnticipo, string nitTercero, int? intNoColReferencia, double? sngPorcenrajeAplica, string strCuentaAplica, string strCuentaNiif, string Norma, Sinapsys.Datos.SQL datosTransaccion=null)
		{
			try 
			{
				Cuentas cuentas = new Cuentas();

				cuentas.Codigo = Codigo;
				cuentas.Codigo = Codigo;
				cuentas.strCuenta = strCuenta;
				cuentas.strDescripcion = strDescripcion;
				cuentas.logAnticipo = logAnticipo;
				cuentas.nitTercero = nitTercero;
				cuentas.intNoColReferencia = intNoColReferencia;
				cuentas.sngPorcenrajeAplica = sngPorcenrajeAplica;
				cuentas.strCuentaAplica = strCuentaAplica;
				cuentas.strCuentaNiif = strCuentaNiif;
				cuentas.Norma = Norma;
				Codigo = CuentasDataProvider.Instance.Create(Codigo, strCuenta, strDescripcion, logAnticipo, nitTercero, intNoColReferencia, sngPorcenrajeAplica, strCuentaAplica, strCuentaNiif, Norma,"Cuentas",datosTransaccion);
				if (Codigo == 0)
					return null;

				cuentas.Codigo = Codigo;

				return cuentas;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Updates an Cuentas object by passing all object's fields
		/// </summary>
		/// <param name="strCuenta">string that contents the strCuenta value for the Cuentas object</param>
		/// <param name="strDescripcion">string that contents the strDescripcion value for the Cuentas object</param>
		/// <param name="logAnticipo">bool that contents the logAnticipo value for the Cuentas object</param>
		/// <param name="nitTercero">string that contents the nitTercero value for the Cuentas object</param>
		/// <param name="intNoColReferencia">int that contents the intNoColReferencia value for the Cuentas object</param>
		/// <param name="sngPorcenrajeAplica">double that contents the sngPorcenrajeAplica value for the Cuentas object</param>
		/// <param name="strCuentaAplica">string that contents the strCuentaAplica value for the Cuentas object</param>
		/// <param name="strCuentaNiif">string that contents the strCuentaNiif value for the Cuentas object</param>
		/// <param name="Norma">string that contents the Norma value for the Cuentas object</param>
		/// <param name="Codigo">int that contents the Codigo value for the Cuentas object</param>
		public void Update(string strCuenta, string strDescripcion, bool? logAnticipo, string nitTercero, int? intNoColReferencia, double? sngPorcenrajeAplica, string strCuentaAplica, string strCuentaNiif, string Norma, int Codigo, Sinapsys.Datos.SQL datosTransaccion=null)
		{
			try 
			{
				Cuentas new_values = new Cuentas();
				new_values.strCuenta = strCuenta;
				new_values.strDescripcion = strDescripcion;
				new_values.logAnticipo = logAnticipo;
				new_values.nitTercero = nitTercero;
				new_values.intNoColReferencia = intNoColReferencia;
				new_values.sngPorcenrajeAplica = sngPorcenrajeAplica;
				new_values.strCuentaAplica = strCuentaAplica;
				new_values.strCuentaNiif = strCuentaNiif;
				new_values.Norma = Norma;
				CuentasDataProvider.Instance.Update(strCuenta, strDescripcion, logAnticipo, nitTercero, intNoColReferencia, sngPorcenrajeAplica, strCuentaAplica, strCuentaNiif, Norma, Codigo,"Cuentas",datosTransaccion);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Updates an Cuentas object by passing one object's instance as reference
		/// </summary>
		/// <param name="cuentas">An instance of Cuentas for reference</param>
		public void Update(Cuentas cuentas,Sinapsys.Datos.SQL datosTransaccion=null)
		{
			Update(cuentas.strCuenta, cuentas.strDescripcion, cuentas.logAnticipo, cuentas.nitTercero, cuentas.intNoColReferencia, cuentas.sngPorcenrajeAplica, cuentas.strCuentaAplica, cuentas.strCuentaNiif, cuentas.Norma, cuentas.Codigo);
		}

		/// <summary>
		/// Delete  the Cuentas object by passing a object
		/// </summary>
		public void  Delete(Cuentas cuentas, Sinapsys.Datos.SQL datosTransaccion=null)
		{
			Delete(cuentas.Codigo,datosTransaccion);
		}

		/// <summary>
		/// Deletes the Cuentas object by passing one object's instance as reference
		/// </summary>
		/// <param name="cuentas">An instance of Cuentas for reference</param>
		public void Delete(int Codigo, Sinapsys.Datos.SQL datosTransaccion=null)
		{
			try 
			{
				//Cuentas old_values = CuentasController.Instance.Get(Codigo);
				//if(!Validate.security.CanDeleteSecurityField(CuentasController.Instance, (ILatinodeObject)old_values))
				//    throw new Exception("Access denied by security field, you can't delete object");

				CuentasDataProvider.Instance.Delete(Codigo,"Cuentas");
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Deletes the Cuentas object by passing CVS parameter as reference
		/// </summary>
		/// <param name="cuentas">An instance of Cuentas for reference</param>
		public void Delete(string CVSParameter)
		{
			string[] StrCommand=CVSParameter.Split(',');
			try 
			{
				int Codigo=int.Parse(StrCommand[0]);
				CuentasDataProvider.Instance.Delete(Codigo,"Cuentas");
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Gets the Cuentas object by passing the object's key fields
		/// </summary>
		/// <param name="Codigo">int that contents the Codigo value for the Cuentas object</param>
		/// <returns>One Cuentas object</returns>
		public Cuentas Get(int Codigo, bool generateUndo=false)
		{
			try 
			{
				Cuentas cuentas = null;
				cuentas= MasterTables.Cuentas.Where(r => r.Codigo== Codigo).FirstOrDefault();
				if (cuentas== null)
				{
					MasterTables.Reset("Cuentas");
					cuentas= MasterTables.Cuentas.Where(r => r.Codigo== Codigo).FirstOrDefault();
				}
				if (generateUndo) cuentas.GenerateUndo();

				return cuentas;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Gets all objects of Cuentas
		/// </summary>
		/// <returns>One CuentasList object</returns>
		public CuentasList GetAll(bool generateUndo=false)
		{
			try 
			{
				CuentasList cuentaslist = new CuentasList();
				DataTable dt = CuentasDataProvider.Instance.GetAll();
				foreach (DataRow dr in dt.Rows)
				{
					Cuentas cuentas = new Cuentas();
					ReadData(cuentas, dr, generateUndo);
					cuentaslist.Add(cuentas);
				}
				return cuentaslist;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Gets all objects of Cuentas applying filter and sort criteria
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
		/// <returns>One CuentasList object</returns>
		public CuentasList GetFilter(int pagenum, int pagesize, string filter, string sort, string extablesfilter, string extablesfieldsfilter, string extablesrelationsfilter, string extablessort, string extablesfieldssort, string extablesrelationssort, bool generateUndo=false)
		{
			try 
			{
				CuentasList cuentaslist = new CuentasList();

				DataTable dt = CuentasDataProvider.Instance.GetFilter(pagenum, pagesize, filter, sort, extablesfilter, extablesfieldsfilter, extablesrelationsfilter, extablessort, extablesfieldssort, extablesrelationssort);

				foreach (DataRow dr in dt.Rows)
				{
					Cuentas cuentas = new Cuentas();
					ReadData(cuentas, dr, generateUndo);
					cuentaslist.Add(cuentas);
				}
				return cuentaslist;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public CuentasList GetFilter( string filter, string sort, bool generateUndo=false)
		{
			return GetFilter(0,0, filter, sort, "","","","","","",generateUndo);
		}

		public CuentasList GetFilter(string filter, string sort, string extablesfilter, string extablesfieldsfilter, string extablesrelationsfilter, string extablessort, string extablesfieldssort, string extablesrelationssort, bool generateUndo=false)
		{
			return GetFilter(0,0, filter, sort, extablesfilter, extablesfieldsfilter, extablesrelationsfilter, extablessort, extablesfieldssort, extablesrelationssort,generateUndo);
		}


		/// <summary>
		/// Returns the type for one property
		/// </summary>
		/// <param name="propertyname">Property's name for return its value</param>
		/// <returns>A value for the <paramref name="propertyname"/></returns>
		public Type GetMethodType( string propertyname,Cuentas cuentas)
		{
			// Perform the search for the property's value
			switch (propertyname)
			{
				case "strCuenta":
					return cuentas.strCuenta.GetType();

				case "strDescripcion":
					return cuentas.strDescripcion.GetType();

				case "logAnticipo":
					return cuentas.logAnticipo.GetType();

				case "nitTercero":
					return cuentas.nitTercero.GetType();

				case "intNoColReferencia":
					return cuentas.intNoColReferencia.GetType();

				case "sngPorcenrajeAplica":
					return cuentas.sngPorcenrajeAplica.GetType();

				case "strCuentaAplica":
					return cuentas.strCuentaAplica.GetType();

				case "strCuentaNiif":
					return cuentas.strCuentaNiif.GetType();

				case "Norma":
					return cuentas.Norma.GetType();

				case "Codigo":
					return cuentas.Codigo.GetType();

			}

			return null;
		}
		/// <summary>
		/// update the changes in Cuentas object by passing the object
		/// </summary>
		public bool UpdateChanges(Cuentas cuentas, out string error,Sinapsys.Datos.SQL datosTransaccion=null)
		{
			if (cuentas.OldCuentas == null)
			{
				    error = "No tiene objeto con el cual comparar";
				    return false;
			}
			string[] Fields = cuentas.FieldChanged();
			error = "";
			return LiqViajes_Bll_Data.DataProvider.UpdateFieldsbyObject(Fields, cuentas, out error,datosTransaccion);
		}
	}

	#endregion

}
