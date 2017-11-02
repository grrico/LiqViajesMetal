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
	#region TercerosConductoresWinForController

	/// <summary>
	/// Class for convert data from database into object's data and vice versa
	/// </summary>
	public partial class TercerosConductoresWinForController//: ILatinodeController
	{
		/// <summary>
		/// Generic Constructor
		/// </summary>
		public TercerosConductoresWinForController()
		{
		}

		/// <summary>
		/// Instance accessor for this singleton
		/// </summary>
		private static TercerosConductoresWinForController MySingleObj;
		public static TercerosConductoresWinForController Instance
		{
			get
			{
				if (MySingleObj == null)
				{
					MySingleObj = new TercerosConductoresWinForController();
				}
				return MySingleObj;
			}
		}

		// Reads object's data from a DataRow
		private void ReadData(TercerosConductoresWinFor tercerosconductoreswinfor, DataRow dr,bool generateUndo=false)
		{
			try 
			{
				tercerosconductoreswinfor.lngIdRegistro = (int) dr["lngIdRegistro"];
				tercerosconductoreswinfor.lngIdUsuario = (int) dr["lngIdUsuario"];
				tercerosconductoreswinfor.strTipoIdentificacion = dr.IsNull("strTipoIdentificacion") ? null :(int?) dr["strTipoIdentificacion"];
				tercerosconductoreswinfor.IntNit = dr.IsNull("IntNit") ? null :(int?) dr["IntNit"];
				tercerosconductoreswinfor.intDigito = dr.IsNull("intDigito") ? null :(int?) dr["intDigito"];
				tercerosconductoreswinfor.strNombres = dr.IsNull("strNombres") ? null :(int?) dr["strNombres"];
				tercerosconductoreswinfor.strDireccion = dr.IsNull("strDireccion") ? null :(int?) dr["strDireccion"];
				tercerosconductoreswinfor.logEstado = dr.IsNull("logEstado") ? null :(int?) dr["logEstado"];
				tercerosconductoreswinfor.logConductor = dr.IsNull("logConductor") ? null :(int?) dr["logConductor"];
				tercerosconductoreswinfor.strPlaca = dr.IsNull("strPlaca") ? null :(int?) dr["strPlaca"];
				tercerosconductoreswinfor.lngIdCiudad = dr.IsNull("lngIdCiudad") ? null :(int?) dr["lngIdCiudad"];
				tercerosconductoreswinfor.strTelefono = dr.IsNull("strTelefono") ? null :(int?) dr["strTelefono"];
				tercerosconductoreswinfor.strTelefonoAux = dr.IsNull("strTelefonoAux") ? null :(int?) dr["strTelefonoAux"];
				tercerosconductoreswinfor.strTelCelular = dr.IsNull("strTelCelular") ? null :(int?) dr["strTelCelular"];
				tercerosconductoreswinfor.strTelCelularAux = dr.IsNull("strTelCelularAux") ? null :(int?) dr["strTelCelularAux"];
				tercerosconductoreswinfor.strFax = dr.IsNull("strFax") ? null :(int?) dr["strFax"];
				tercerosconductoreswinfor.IntAAereo = dr.IsNull("IntAAereo") ? null :(int?) dr["IntAAereo"];
				tercerosconductoreswinfor.StrPais = dr.IsNull("StrPais") ? null :(int?) dr["StrPais"];
				tercerosconductoreswinfor.nitProvedor = dr.IsNull("nitProvedor") ? null :(int?) dr["nitProvedor"];
				tercerosconductoreswinfor.intNoLicenciaConduc = dr.IsNull("intNoLicenciaConduc") ? null :(int?) dr["intNoLicenciaConduc"];
				tercerosconductoreswinfor.intCategoria = dr.IsNull("intCategoria") ? null :(int?) dr["intCategoria"];
				tercerosconductoreswinfor.strTarjetaTripulante = dr.IsNull("strTarjetaTripulante") ? null :(int?) dr["strTarjetaTripulante"];
				tercerosconductoreswinfor.dtmFechaVenceLicencia = dr.IsNull("dtmFechaVenceLicencia") ? null :(int?) dr["dtmFechaVenceLicencia"];
				tercerosconductoreswinfor.dtmVenceTarjetaTripulante = dr.IsNull("dtmVenceTarjetaTripulante") ? null :(int?) dr["dtmVenceTarjetaTripulante"];
				tercerosconductoreswinfor.strCarnetEmpresa = dr.IsNull("strCarnetEmpresa") ? null :(int?) dr["strCarnetEmpresa"];
				tercerosconductoreswinfor.strCarnetComunicaciones = dr.IsNull("strCarnetComunicaciones") ? null :(int?) dr["strCarnetComunicaciones"];
			}
			catch (Exception ex)
			{
				Utilidades.LogErrores(ex.Message + (ex.InnerException != null ? ex.InnerException.Message : ""), DataProvider.AplicacionNombre);
				throw ex;
			}
			if (generateUndo) tercerosconductoreswinfor.GenerateUndo();
		}

		/// <summary>
		/// Create a new TercerosConductoresWinFor object by passing a object
		/// </summary>
		public TercerosConductoresWinFor Create(TercerosConductoresWinFor tercerosconductoreswinfor, Sinapsys.Datos.SQL datosTransaccion=null)
		{
			return Create(tercerosconductoreswinfor.lngIdRegistro,tercerosconductoreswinfor.lngIdUsuario,tercerosconductoreswinfor.strTipoIdentificacion,tercerosconductoreswinfor.IntNit,tercerosconductoreswinfor.intDigito,tercerosconductoreswinfor.strNombres,tercerosconductoreswinfor.strDireccion,tercerosconductoreswinfor.logEstado,tercerosconductoreswinfor.logConductor,tercerosconductoreswinfor.strPlaca,tercerosconductoreswinfor.lngIdCiudad,tercerosconductoreswinfor.strTelefono,tercerosconductoreswinfor.strTelefonoAux,tercerosconductoreswinfor.strTelCelular,tercerosconductoreswinfor.strTelCelularAux,tercerosconductoreswinfor.strFax,tercerosconductoreswinfor.IntAAereo,tercerosconductoreswinfor.StrPais,tercerosconductoreswinfor.nitProvedor,tercerosconductoreswinfor.intNoLicenciaConduc,tercerosconductoreswinfor.intCategoria,tercerosconductoreswinfor.strTarjetaTripulante,tercerosconductoreswinfor.dtmFechaVenceLicencia,tercerosconductoreswinfor.dtmVenceTarjetaTripulante,tercerosconductoreswinfor.strCarnetEmpresa,tercerosconductoreswinfor.strCarnetComunicaciones,datosTransaccion);
		}

		/// <summary>
		/// Creates a new TercerosConductoresWinFor object by passing all object's fields
		/// </summary>
		/// <param name="strTipoIdentificacion">int that contents the strTipoIdentificacion value for the TercerosConductoresWinFor object</param>
		/// <param name="IntNit">int that contents the IntNit value for the TercerosConductoresWinFor object</param>
		/// <param name="intDigito">int that contents the intDigito value for the TercerosConductoresWinFor object</param>
		/// <param name="strNombres">int that contents the strNombres value for the TercerosConductoresWinFor object</param>
		/// <param name="strDireccion">int that contents the strDireccion value for the TercerosConductoresWinFor object</param>
		/// <param name="logEstado">int that contents the logEstado value for the TercerosConductoresWinFor object</param>
		/// <param name="logConductor">int that contents the logConductor value for the TercerosConductoresWinFor object</param>
		/// <param name="strPlaca">int that contents the strPlaca value for the TercerosConductoresWinFor object</param>
		/// <param name="lngIdCiudad">int that contents the lngIdCiudad value for the TercerosConductoresWinFor object</param>
		/// <param name="strTelefono">int that contents the strTelefono value for the TercerosConductoresWinFor object</param>
		/// <param name="strTelefonoAux">int that contents the strTelefonoAux value for the TercerosConductoresWinFor object</param>
		/// <param name="strTelCelular">int that contents the strTelCelular value for the TercerosConductoresWinFor object</param>
		/// <param name="strTelCelularAux">int that contents the strTelCelularAux value for the TercerosConductoresWinFor object</param>
		/// <param name="strFax">int that contents the strFax value for the TercerosConductoresWinFor object</param>
		/// <param name="IntAAereo">int that contents the IntAAereo value for the TercerosConductoresWinFor object</param>
		/// <param name="StrPais">int that contents the StrPais value for the TercerosConductoresWinFor object</param>
		/// <param name="nitProvedor">int that contents the nitProvedor value for the TercerosConductoresWinFor object</param>
		/// <param name="intNoLicenciaConduc">int that contents the intNoLicenciaConduc value for the TercerosConductoresWinFor object</param>
		/// <param name="intCategoria">int that contents the intCategoria value for the TercerosConductoresWinFor object</param>
		/// <param name="strTarjetaTripulante">int that contents the strTarjetaTripulante value for the TercerosConductoresWinFor object</param>
		/// <param name="dtmFechaVenceLicencia">int that contents the dtmFechaVenceLicencia value for the TercerosConductoresWinFor object</param>
		/// <param name="dtmVenceTarjetaTripulante">int that contents the dtmVenceTarjetaTripulante value for the TercerosConductoresWinFor object</param>
		/// <param name="strCarnetEmpresa">int that contents the strCarnetEmpresa value for the TercerosConductoresWinFor object</param>
		/// <param name="strCarnetComunicaciones">int that contents the strCarnetComunicaciones value for the TercerosConductoresWinFor object</param>
		/// <returns>One TercerosConductoresWinFor object</returns>
		public TercerosConductoresWinFor Create(int lngIdRegistro, int lngIdUsuario, int? strTipoIdentificacion, int? IntNit, int? intDigito, int? strNombres, int? strDireccion, int? logEstado, int? logConductor, int? strPlaca, int? lngIdCiudad, int? strTelefono, int? strTelefonoAux, int? strTelCelular, int? strTelCelularAux, int? strFax, int? IntAAereo, int? StrPais, int? nitProvedor, int? intNoLicenciaConduc, int? intCategoria, int? strTarjetaTripulante, int? dtmFechaVenceLicencia, int? dtmVenceTarjetaTripulante, int? strCarnetEmpresa, int? strCarnetComunicaciones, Sinapsys.Datos.SQL datosTransaccion=null)
		{
			try 
			{
				TercerosConductoresWinFor tercerosconductoreswinfor = new TercerosConductoresWinFor();

				tercerosconductoreswinfor.lngIdRegistro = lngIdRegistro;
				tercerosconductoreswinfor.lngIdUsuario = lngIdUsuario;
				tercerosconductoreswinfor.strTipoIdentificacion = strTipoIdentificacion;
				tercerosconductoreswinfor.IntNit = IntNit;
				tercerosconductoreswinfor.intDigito = intDigito;
				tercerosconductoreswinfor.strNombres = strNombres;
				tercerosconductoreswinfor.strDireccion = strDireccion;
				tercerosconductoreswinfor.logEstado = logEstado;
				tercerosconductoreswinfor.logConductor = logConductor;
				tercerosconductoreswinfor.strPlaca = strPlaca;
				tercerosconductoreswinfor.lngIdCiudad = lngIdCiudad;
				tercerosconductoreswinfor.strTelefono = strTelefono;
				tercerosconductoreswinfor.strTelefonoAux = strTelefonoAux;
				tercerosconductoreswinfor.strTelCelular = strTelCelular;
				tercerosconductoreswinfor.strTelCelularAux = strTelCelularAux;
				tercerosconductoreswinfor.strFax = strFax;
				tercerosconductoreswinfor.IntAAereo = IntAAereo;
				tercerosconductoreswinfor.StrPais = StrPais;
				tercerosconductoreswinfor.nitProvedor = nitProvedor;
				tercerosconductoreswinfor.intNoLicenciaConduc = intNoLicenciaConduc;
				tercerosconductoreswinfor.intCategoria = intCategoria;
				tercerosconductoreswinfor.strTarjetaTripulante = strTarjetaTripulante;
				tercerosconductoreswinfor.dtmFechaVenceLicencia = dtmFechaVenceLicencia;
				tercerosconductoreswinfor.dtmVenceTarjetaTripulante = dtmVenceTarjetaTripulante;
				tercerosconductoreswinfor.strCarnetEmpresa = strCarnetEmpresa;
				tercerosconductoreswinfor.strCarnetComunicaciones = strCarnetComunicaciones;
				TercerosConductoresWinForDataProvider.Instance.Create(lngIdRegistro, lngIdUsuario, strTipoIdentificacion, IntNit, intDigito, strNombres, strDireccion, logEstado, logConductor, strPlaca, lngIdCiudad, strTelefono, strTelefonoAux, strTelCelular, strTelCelularAux, strFax, IntAAereo, StrPais, nitProvedor, intNoLicenciaConduc, intCategoria, strTarjetaTripulante, dtmFechaVenceLicencia, dtmVenceTarjetaTripulante, strCarnetEmpresa, strCarnetComunicaciones,"TercerosConductoresWinFor");

				return tercerosconductoreswinfor;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Updates an TercerosConductoresWinFor object by passing all object's fields
		/// </summary>
		/// <param name="lngIdRegistro">int that contents the lngIdRegistro value for the TercerosConductoresWinFor object</param>
		/// <param name="lngIdUsuario">int that contents the lngIdUsuario value for the TercerosConductoresWinFor object</param>
		/// <param name="strTipoIdentificacion">int that contents the strTipoIdentificacion value for the TercerosConductoresWinFor object</param>
		/// <param name="IntNit">int that contents the IntNit value for the TercerosConductoresWinFor object</param>
		/// <param name="intDigito">int that contents the intDigito value for the TercerosConductoresWinFor object</param>
		/// <param name="strNombres">int that contents the strNombres value for the TercerosConductoresWinFor object</param>
		/// <param name="strDireccion">int that contents the strDireccion value for the TercerosConductoresWinFor object</param>
		/// <param name="logEstado">int that contents the logEstado value for the TercerosConductoresWinFor object</param>
		/// <param name="logConductor">int that contents the logConductor value for the TercerosConductoresWinFor object</param>
		/// <param name="strPlaca">int that contents the strPlaca value for the TercerosConductoresWinFor object</param>
		/// <param name="lngIdCiudad">int that contents the lngIdCiudad value for the TercerosConductoresWinFor object</param>
		/// <param name="strTelefono">int that contents the strTelefono value for the TercerosConductoresWinFor object</param>
		/// <param name="strTelefonoAux">int that contents the strTelefonoAux value for the TercerosConductoresWinFor object</param>
		/// <param name="strTelCelular">int that contents the strTelCelular value for the TercerosConductoresWinFor object</param>
		/// <param name="strTelCelularAux">int that contents the strTelCelularAux value for the TercerosConductoresWinFor object</param>
		/// <param name="strFax">int that contents the strFax value for the TercerosConductoresWinFor object</param>
		/// <param name="IntAAereo">int that contents the IntAAereo value for the TercerosConductoresWinFor object</param>
		/// <param name="StrPais">int that contents the StrPais value for the TercerosConductoresWinFor object</param>
		/// <param name="nitProvedor">int that contents the nitProvedor value for the TercerosConductoresWinFor object</param>
		/// <param name="intNoLicenciaConduc">int that contents the intNoLicenciaConduc value for the TercerosConductoresWinFor object</param>
		/// <param name="intCategoria">int that contents the intCategoria value for the TercerosConductoresWinFor object</param>
		/// <param name="strTarjetaTripulante">int that contents the strTarjetaTripulante value for the TercerosConductoresWinFor object</param>
		/// <param name="dtmFechaVenceLicencia">int that contents the dtmFechaVenceLicencia value for the TercerosConductoresWinFor object</param>
		/// <param name="dtmVenceTarjetaTripulante">int that contents the dtmVenceTarjetaTripulante value for the TercerosConductoresWinFor object</param>
		/// <param name="strCarnetEmpresa">int that contents the strCarnetEmpresa value for the TercerosConductoresWinFor object</param>
		/// <param name="strCarnetComunicaciones">int that contents the strCarnetComunicaciones value for the TercerosConductoresWinFor object</param>
		public void Update(int lngIdRegistro, int lngIdUsuario, int? strTipoIdentificacion, int? IntNit, int? intDigito, int? strNombres, int? strDireccion, int? logEstado, int? logConductor, int? strPlaca, int? lngIdCiudad, int? strTelefono, int? strTelefonoAux, int? strTelCelular, int? strTelCelularAux, int? strFax, int? IntAAereo, int? StrPais, int? nitProvedor, int? intNoLicenciaConduc, int? intCategoria, int? strTarjetaTripulante, int? dtmFechaVenceLicencia, int? dtmVenceTarjetaTripulante, int? strCarnetEmpresa, int? strCarnetComunicaciones, Sinapsys.Datos.SQL datosTransaccion=null)
		{
			try 
			{
				TercerosConductoresWinFor new_values = new TercerosConductoresWinFor();
				new_values.strTipoIdentificacion = strTipoIdentificacion;
				new_values.IntNit = IntNit;
				new_values.intDigito = intDigito;
				new_values.strNombres = strNombres;
				new_values.strDireccion = strDireccion;
				new_values.logEstado = logEstado;
				new_values.logConductor = logConductor;
				new_values.strPlaca = strPlaca;
				new_values.lngIdCiudad = lngIdCiudad;
				new_values.strTelefono = strTelefono;
				new_values.strTelefonoAux = strTelefonoAux;
				new_values.strTelCelular = strTelCelular;
				new_values.strTelCelularAux = strTelCelularAux;
				new_values.strFax = strFax;
				new_values.IntAAereo = IntAAereo;
				new_values.StrPais = StrPais;
				new_values.nitProvedor = nitProvedor;
				new_values.intNoLicenciaConduc = intNoLicenciaConduc;
				new_values.intCategoria = intCategoria;
				new_values.strTarjetaTripulante = strTarjetaTripulante;
				new_values.dtmFechaVenceLicencia = dtmFechaVenceLicencia;
				new_values.dtmVenceTarjetaTripulante = dtmVenceTarjetaTripulante;
				new_values.strCarnetEmpresa = strCarnetEmpresa;
				new_values.strCarnetComunicaciones = strCarnetComunicaciones;
				TercerosConductoresWinForDataProvider.Instance.Update(lngIdRegistro, lngIdUsuario, strTipoIdentificacion, IntNit, intDigito, strNombres, strDireccion, logEstado, logConductor, strPlaca, lngIdCiudad, strTelefono, strTelefonoAux, strTelCelular, strTelCelularAux, strFax, IntAAereo, StrPais, nitProvedor, intNoLicenciaConduc, intCategoria, strTarjetaTripulante, dtmFechaVenceLicencia, dtmVenceTarjetaTripulante, strCarnetEmpresa, strCarnetComunicaciones,"TercerosConductoresWinFor",datosTransaccion);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Updates an TercerosConductoresWinFor object by passing one object's instance as reference
		/// </summary>
		/// <param name="tercerosconductoreswinfor">An instance of TercerosConductoresWinFor for reference</param>
		public void Update(TercerosConductoresWinFor tercerosconductoreswinfor,Sinapsys.Datos.SQL datosTransaccion=null)
		{
			Update(tercerosconductoreswinfor.lngIdRegistro, tercerosconductoreswinfor.lngIdUsuario, tercerosconductoreswinfor.strTipoIdentificacion, tercerosconductoreswinfor.IntNit, tercerosconductoreswinfor.intDigito, tercerosconductoreswinfor.strNombres, tercerosconductoreswinfor.strDireccion, tercerosconductoreswinfor.logEstado, tercerosconductoreswinfor.logConductor, tercerosconductoreswinfor.strPlaca, tercerosconductoreswinfor.lngIdCiudad, tercerosconductoreswinfor.strTelefono, tercerosconductoreswinfor.strTelefonoAux, tercerosconductoreswinfor.strTelCelular, tercerosconductoreswinfor.strTelCelularAux, tercerosconductoreswinfor.strFax, tercerosconductoreswinfor.IntAAereo, tercerosconductoreswinfor.StrPais, tercerosconductoreswinfor.nitProvedor, tercerosconductoreswinfor.intNoLicenciaConduc, tercerosconductoreswinfor.intCategoria, tercerosconductoreswinfor.strTarjetaTripulante, tercerosconductoreswinfor.dtmFechaVenceLicencia, tercerosconductoreswinfor.dtmVenceTarjetaTripulante, tercerosconductoreswinfor.strCarnetEmpresa, tercerosconductoreswinfor.strCarnetComunicaciones);
		}

		/// <summary>
		/// Delete  the TercerosConductoresWinFor object by passing a object
		/// </summary>
		public void  Delete(TercerosConductoresWinFor tercerosconductoreswinfor, Sinapsys.Datos.SQL datosTransaccion=null)
		{
			Delete(tercerosconductoreswinfor.lngIdRegistro, tercerosconductoreswinfor.lngIdUsuario,datosTransaccion);
		}

		/// <summary>
		/// Deletes the TercerosConductoresWinFor object by passing one object's instance as reference
		/// </summary>
		/// <param name="tercerosconductoreswinfor">An instance of TercerosConductoresWinFor for reference</param>
		public void Delete(int lngIdRegistro, int lngIdUsuario, Sinapsys.Datos.SQL datosTransaccion=null)
		{
			try 
			{
				TercerosConductoresWinForDataProvider.Instance.Delete(lngIdRegistro, lngIdUsuario,"TercerosConductoresWinFor");
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Deletes the TercerosConductoresWinFor object by passing CVS parameter as reference
		/// </summary>
		/// <param name="tercerosconductoreswinfor">An instance of TercerosConductoresWinFor for reference</param>
		public void Delete(string CVSParameter)
		{
			string[] StrCommand=CVSParameter.Split(',');
			try 
			{
				int lngIdRegistro=int.Parse(StrCommand[0]);
				int lngIdUsuario=int.Parse(StrCommand[1]);
				TercerosConductoresWinForDataProvider.Instance.Delete(lngIdRegistro, lngIdUsuario,"TercerosConductoresWinFor");
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Gets the TercerosConductoresWinFor object by passing the object's key fields
		/// </summary>
		/// <param name="lngIdRegistro">int that contents the lngIdRegistro value for the TercerosConductoresWinFor object</param>
		/// <param name="lngIdUsuario">int that contents the lngIdUsuario value for the TercerosConductoresWinFor object</param>
		/// <returns>One TercerosConductoresWinFor object</returns>
		public TercerosConductoresWinFor Get(int lngIdRegistro, int lngIdUsuario, bool generateUndo=false)
		{
			try 
			{
				TercerosConductoresWinFor tercerosconductoreswinfor = null;
				DataTable dt = TercerosConductoresWinForDataProvider.Instance.Get(lngIdRegistro, lngIdUsuario);
				if ((dt.Rows.Count > 0))
				{
					tercerosconductoreswinfor = new TercerosConductoresWinFor();
					DataRow dr = dt.Rows[0];
					ReadData(tercerosconductoreswinfor, dr, generateUndo);
				}


				return tercerosconductoreswinfor;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Gets all objects of TercerosConductoresWinFor
		/// </summary>
		/// <returns>One TercerosConductoresWinForList object</returns>
		public TercerosConductoresWinForList GetAll(bool generateUndo=false)
		{
			try 
			{
				TercerosConductoresWinForList tercerosconductoreswinforlist = new TercerosConductoresWinForList();
				DataTable dt = TercerosConductoresWinForDataProvider.Instance.GetAll();
				foreach (DataRow dr in dt.Rows)
				{
					TercerosConductoresWinFor tercerosconductoreswinfor = new TercerosConductoresWinFor();
					ReadData(tercerosconductoreswinfor, dr, generateUndo);
					tercerosconductoreswinforlist.Add(tercerosconductoreswinfor);
				}
				return tercerosconductoreswinforlist;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Gets all objects of TercerosConductoresWinFor applying filter and sort criteria
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
		/// <returns>One TercerosConductoresWinForList object</returns>
		public TercerosConductoresWinForList GetFilter(int pagenum, int pagesize, string filter, string sort, string extablesfilter, string extablesfieldsfilter, string extablesrelationsfilter, string extablessort, string extablesfieldssort, string extablesrelationssort, bool generateUndo=false)
		{
			try 
			{
				TercerosConductoresWinForList tercerosconductoreswinforlist = new TercerosConductoresWinForList();

				DataTable dt = TercerosConductoresWinForDataProvider.Instance.GetFilter(pagenum, pagesize, filter, sort, extablesfilter, extablesfieldsfilter, extablesrelationsfilter, extablessort, extablesfieldssort, extablesrelationssort);

				foreach (DataRow dr in dt.Rows)
				{
					TercerosConductoresWinFor tercerosconductoreswinfor = new TercerosConductoresWinFor();
					ReadData(tercerosconductoreswinfor, dr, generateUndo);
					tercerosconductoreswinforlist.Add(tercerosconductoreswinfor);
				}
				return tercerosconductoreswinforlist;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public TercerosConductoresWinForList GetFilter( string filter, string sort, bool generateUndo=false)
		{
			return GetFilter(0,0, filter, sort, "","","","","","",generateUndo);
		}

		public TercerosConductoresWinForList GetFilter(string filter, string sort, string extablesfilter, string extablesfieldsfilter, string extablesrelationsfilter, string extablessort, string extablesfieldssort, string extablesrelationssort, bool generateUndo=false)
		{
			return GetFilter(0,0, filter, sort, extablesfilter, extablesfieldsfilter, extablesrelationsfilter, extablessort, extablesfieldssort, extablesrelationssort,generateUndo);
		}


		/// <summary>
		/// Returns the type for one property
		/// </summary>
		/// <param name="propertyname">Property's name for return its value</param>
		/// <returns>A value for the <paramref name="propertyname"/></returns>
		public Type GetMethodType( string propertyname,TercerosConductoresWinFor tercerosconductoreswinfor)
		{
			// Perform the search for the property's value
			switch (propertyname)
			{
				case "lngIdRegistro":
					return tercerosconductoreswinfor.lngIdRegistro.GetType();

				case "lngIdUsuario":
					return tercerosconductoreswinfor.lngIdUsuario.GetType();

				case "strTipoIdentificacion":
					return tercerosconductoreswinfor.strTipoIdentificacion.GetType();

				case "IntNit":
					return tercerosconductoreswinfor.IntNit.GetType();

				case "intDigito":
					return tercerosconductoreswinfor.intDigito.GetType();

				case "strNombres":
					return tercerosconductoreswinfor.strNombres.GetType();

				case "strDireccion":
					return tercerosconductoreswinfor.strDireccion.GetType();

				case "logEstado":
					return tercerosconductoreswinfor.logEstado.GetType();

				case "logConductor":
					return tercerosconductoreswinfor.logConductor.GetType();

				case "strPlaca":
					return tercerosconductoreswinfor.strPlaca.GetType();

				case "lngIdCiudad":
					return tercerosconductoreswinfor.lngIdCiudad.GetType();

				case "strTelefono":
					return tercerosconductoreswinfor.strTelefono.GetType();

				case "strTelefonoAux":
					return tercerosconductoreswinfor.strTelefonoAux.GetType();

				case "strTelCelular":
					return tercerosconductoreswinfor.strTelCelular.GetType();

				case "strTelCelularAux":
					return tercerosconductoreswinfor.strTelCelularAux.GetType();

				case "strFax":
					return tercerosconductoreswinfor.strFax.GetType();

				case "IntAAereo":
					return tercerosconductoreswinfor.IntAAereo.GetType();

				case "StrPais":
					return tercerosconductoreswinfor.StrPais.GetType();

				case "nitProvedor":
					return tercerosconductoreswinfor.nitProvedor.GetType();

				case "intNoLicenciaConduc":
					return tercerosconductoreswinfor.intNoLicenciaConduc.GetType();

				case "intCategoria":
					return tercerosconductoreswinfor.intCategoria.GetType();

				case "strTarjetaTripulante":
					return tercerosconductoreswinfor.strTarjetaTripulante.GetType();

				case "dtmFechaVenceLicencia":
					return tercerosconductoreswinfor.dtmFechaVenceLicencia.GetType();

				case "dtmVenceTarjetaTripulante":
					return tercerosconductoreswinfor.dtmVenceTarjetaTripulante.GetType();

				case "strCarnetEmpresa":
					return tercerosconductoreswinfor.strCarnetEmpresa.GetType();

				case "strCarnetComunicaciones":
					return tercerosconductoreswinfor.strCarnetComunicaciones.GetType();

			}

			return null;
		}
		/// <summary>
		/// update the changes in TercerosConductoresWinFor object by passing the object
		/// </summary>
		public bool UpdateChanges(TercerosConductoresWinFor tercerosconductoreswinfor, out string error,Sinapsys.Datos.SQL datosTransaccion=null)
		{
			if (tercerosconductoreswinfor.OldTercerosConductoresWinFor == null)
			{
				    error = "No tiene objeto con el cual comparar";
				    return false;
			}
			string[] Fields = tercerosconductoreswinfor.FieldChanged();
			error = "";
			return LiqViajes_Bll_Data.DataProvider.UpdateFieldsbyObject(Fields, tercerosconductoreswinfor, out error,datosTransaccion);
		}
	}

	#endregion

}
