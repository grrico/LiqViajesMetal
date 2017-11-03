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
	#region TercerosConductoresController

	/// <summary>
	/// Class for convert data from database into object's data and vice versa
	/// </summary>
	public partial class TercerosConductoresController//: ILatinodeController
	{
		/// <summary>
		/// Generic Constructor
		/// </summary>
		public TercerosConductoresController()
		{
		}

		/// <summary>
		/// Instance accessor for this singleton
		/// </summary>
		private static TercerosConductoresController MySingleObj;
		public static TercerosConductoresController Instance
		{
			get
			{
				if (MySingleObj == null)
				{
					MySingleObj = new TercerosConductoresController();
				}
				return MySingleObj;
			}
		}

		// Reads object's data from a DataRow
		private void ReadData(TercerosConductores tercerosconductores, DataRow dr,bool generateUndo=false)
		{
			try 
			{
				tercerosconductores.intDigito = dr.IsNull("intDigito") ? null :(int?) dr["intDigito"];
				tercerosconductores.strNombres = dr.IsNull("strNombres") ? null :(string) dr["strNombres"];
				tercerosconductores.strDireccion = dr.IsNull("strDireccion") ? null :(string) dr["strDireccion"];
				tercerosconductores.logEstado = dr.IsNull("logEstado") ? null :(bool?) dr["logEstado"];
				tercerosconductores.logConductor = dr.IsNull("logConductor") ? null :(bool?) dr["logConductor"];
				tercerosconductores.strPlaca = dr.IsNull("strPlaca") ? null :(string) dr["strPlaca"];
				tercerosconductores.lngIdCiudad = dr.IsNull("lngIdCiudad") ? null :(string) dr["lngIdCiudad"];
				tercerosconductores.strTelefono = dr.IsNull("strTelefono") ? null :(string) dr["strTelefono"];
				tercerosconductores.strTelefonoAux = dr.IsNull("strTelefonoAux") ? null :(string) dr["strTelefonoAux"];
				tercerosconductores.strTelCelular = dr.IsNull("strTelCelular") ? null :(string) dr["strTelCelular"];
				tercerosconductores.strTelCelularAux = dr.IsNull("strTelCelularAux") ? null :(string) dr["strTelCelularAux"];
				tercerosconductores.strFax = dr.IsNull("strFax") ? null :(string) dr["strFax"];
				tercerosconductores.IntAAereo = dr.IsNull("IntAAereo") ? null :(string) dr["IntAAereo"];
				tercerosconductores.StrPais = dr.IsNull("StrPais") ? null :(string) dr["StrPais"];
				tercerosconductores.nitProvedor = dr.IsNull("nitProvedor") ? null :(double?) dr["nitProvedor"];
				tercerosconductores.intNoLicenciaConduc = dr.IsNull("intNoLicenciaConduc") ? null :(double?) dr["intNoLicenciaConduc"];
				tercerosconductores.intCategoria = dr.IsNull("intCategoria") ? null :(int?) dr["intCategoria"];
				tercerosconductores.strTarjetaTripulante = dr.IsNull("strTarjetaTripulante") ? null :(string) dr["strTarjetaTripulante"];
				tercerosconductores.dtmFechaVenceLicencia = dr.IsNull("dtmFechaVenceLicencia") ? null :(DateTime?) dr["dtmFechaVenceLicencia"];
				tercerosconductores.dtmVenceTarjetaTripulante = dr.IsNull("dtmVenceTarjetaTripulante") ? null :(DateTime?) dr["dtmVenceTarjetaTripulante"];
				tercerosconductores.strCarnetEmpresa = dr.IsNull("strCarnetEmpresa") ? null :(string) dr["strCarnetEmpresa"];
				tercerosconductores.strCarnetComunicaciones = dr.IsNull("strCarnetComunicaciones") ? null :(string) dr["strCarnetComunicaciones"];
				tercerosconductores.dtmFechaModif = dr.IsNull("dtmFechaModif") ? null :(DateTime?) dr["dtmFechaModif"];
				tercerosconductores.logActualizado = dr.IsNull("logActualizado") ? null :(bool?) dr["logActualizado"];
				tercerosconductores.lngIdUsuario = dr.IsNull("lngIdUsuario") ? null :(int?) dr["lngIdUsuario"];
				tercerosconductores.strTipoIdentificacion = (string) dr["strTipoIdentificacion"];
				tercerosconductores.IntNit = (double) dr["IntNit"];
			}
			catch (Exception ex)
			{
				Utilidades.LogErrores(ex.Message + (ex.InnerException != null ? ex.InnerException.Message : ""), DataProvider.AplicacionNombre);
				throw ex;
			}
			if (generateUndo) tercerosconductores.GenerateUndo();
		}

		/// <summary>
		/// Create a new TercerosConductores object by passing a object
		/// </summary>
		public TercerosConductores Create(TercerosConductores tercerosconductores, Sinapsys.Datos.SQL datosTransaccion=null)
		{
			return Create(tercerosconductores.strTipoIdentificacion,tercerosconductores.IntNit,tercerosconductores.intDigito,tercerosconductores.strNombres,tercerosconductores.strDireccion,tercerosconductores.logEstado,tercerosconductores.logConductor,tercerosconductores.strPlaca,tercerosconductores.lngIdCiudad,tercerosconductores.strTelefono,tercerosconductores.strTelefonoAux,tercerosconductores.strTelCelular,tercerosconductores.strTelCelularAux,tercerosconductores.strFax,tercerosconductores.IntAAereo,tercerosconductores.StrPais,tercerosconductores.nitProvedor,tercerosconductores.intNoLicenciaConduc,tercerosconductores.intCategoria,tercerosconductores.strTarjetaTripulante,tercerosconductores.dtmFechaVenceLicencia,tercerosconductores.dtmVenceTarjetaTripulante,tercerosconductores.strCarnetEmpresa,tercerosconductores.strCarnetComunicaciones,tercerosconductores.dtmFechaModif,tercerosconductores.logActualizado,tercerosconductores.lngIdUsuario,datosTransaccion);
		}

		/// <summary>
		/// Creates a new TercerosConductores object by passing all object's fields
		/// </summary>
		/// <param name="intDigito">int that contents the intDigito value for the TercerosConductores object</param>
		/// <param name="strNombres">string that contents the strNombres value for the TercerosConductores object</param>
		/// <param name="strDireccion">string that contents the strDireccion value for the TercerosConductores object</param>
		/// <param name="logEstado">bool that contents the logEstado value for the TercerosConductores object</param>
		/// <param name="logConductor">bool that contents the logConductor value for the TercerosConductores object</param>
		/// <param name="strPlaca">string that contents the strPlaca value for the TercerosConductores object</param>
		/// <param name="lngIdCiudad">string that contents the lngIdCiudad value for the TercerosConductores object</param>
		/// <param name="strTelefono">string that contents the strTelefono value for the TercerosConductores object</param>
		/// <param name="strTelefonoAux">string that contents the strTelefonoAux value for the TercerosConductores object</param>
		/// <param name="strTelCelular">string that contents the strTelCelular value for the TercerosConductores object</param>
		/// <param name="strTelCelularAux">string that contents the strTelCelularAux value for the TercerosConductores object</param>
		/// <param name="strFax">string that contents the strFax value for the TercerosConductores object</param>
		/// <param name="IntAAereo">string that contents the IntAAereo value for the TercerosConductores object</param>
		/// <param name="StrPais">string that contents the StrPais value for the TercerosConductores object</param>
		/// <param name="nitProvedor">double that contents the nitProvedor value for the TercerosConductores object</param>
		/// <param name="intNoLicenciaConduc">double that contents the intNoLicenciaConduc value for the TercerosConductores object</param>
		/// <param name="intCategoria">int that contents the intCategoria value for the TercerosConductores object</param>
		/// <param name="strTarjetaTripulante">string that contents the strTarjetaTripulante value for the TercerosConductores object</param>
		/// <param name="dtmFechaVenceLicencia">DateTime that contents the dtmFechaVenceLicencia value for the TercerosConductores object</param>
		/// <param name="dtmVenceTarjetaTripulante">DateTime that contents the dtmVenceTarjetaTripulante value for the TercerosConductores object</param>
		/// <param name="strCarnetEmpresa">string that contents the strCarnetEmpresa value for the TercerosConductores object</param>
		/// <param name="strCarnetComunicaciones">string that contents the strCarnetComunicaciones value for the TercerosConductores object</param>
		/// <param name="dtmFechaModif">DateTime that contents the dtmFechaModif value for the TercerosConductores object</param>
		/// <param name="logActualizado">bool that contents the logActualizado value for the TercerosConductores object</param>
		/// <param name="lngIdUsuario">int that contents the lngIdUsuario value for the TercerosConductores object</param>
		/// <returns>One TercerosConductores object</returns>
		public TercerosConductores Create(string strTipoIdentificacion, double IntNit, int? intDigito, string strNombres, string strDireccion, bool? logEstado, bool? logConductor, string strPlaca, string lngIdCiudad, string strTelefono, string strTelefonoAux, string strTelCelular, string strTelCelularAux, string strFax, string IntAAereo, string StrPais, double? nitProvedor, double? intNoLicenciaConduc, int? intCategoria, string strTarjetaTripulante, DateTime? dtmFechaVenceLicencia, DateTime? dtmVenceTarjetaTripulante, string strCarnetEmpresa, string strCarnetComunicaciones, DateTime? dtmFechaModif, bool? logActualizado, int? lngIdUsuario, Sinapsys.Datos.SQL datosTransaccion=null)
		{
			try 
			{
				TercerosConductores tercerosconductores = new TercerosConductores();

				tercerosconductores.strTipoIdentificacion = strTipoIdentificacion;
				tercerosconductores.IntNit = IntNit;
				tercerosconductores.intDigito = intDigito;
				tercerosconductores.strNombres = strNombres;
				tercerosconductores.strDireccion = strDireccion;
				tercerosconductores.logEstado = logEstado;
				tercerosconductores.logConductor = logConductor;
				tercerosconductores.strPlaca = strPlaca;
				tercerosconductores.lngIdCiudad = lngIdCiudad;
				tercerosconductores.strTelefono = strTelefono;
				tercerosconductores.strTelefonoAux = strTelefonoAux;
				tercerosconductores.strTelCelular = strTelCelular;
				tercerosconductores.strTelCelularAux = strTelCelularAux;
				tercerosconductores.strFax = strFax;
				tercerosconductores.IntAAereo = IntAAereo;
				tercerosconductores.StrPais = StrPais;
				tercerosconductores.nitProvedor = nitProvedor;
				tercerosconductores.intNoLicenciaConduc = intNoLicenciaConduc;
				tercerosconductores.intCategoria = intCategoria;
				tercerosconductores.strTarjetaTripulante = strTarjetaTripulante;
				tercerosconductores.dtmFechaVenceLicencia = dtmFechaVenceLicencia;
				tercerosconductores.dtmVenceTarjetaTripulante = dtmVenceTarjetaTripulante;
				tercerosconductores.strCarnetEmpresa = strCarnetEmpresa;
				tercerosconductores.strCarnetComunicaciones = strCarnetComunicaciones;
				tercerosconductores.dtmFechaModif = dtmFechaModif;
				tercerosconductores.logActualizado = logActualizado;
				tercerosconductores.lngIdUsuario = lngIdUsuario;
				TercerosConductoresDataProvider.Instance.Create(strTipoIdentificacion, IntNit, intDigito, strNombres, strDireccion, logEstado, logConductor, strPlaca, lngIdCiudad, strTelefono, strTelefonoAux, strTelCelular, strTelCelularAux, strFax, IntAAereo, StrPais, nitProvedor, intNoLicenciaConduc, intCategoria, strTarjetaTripulante, dtmFechaVenceLicencia, dtmVenceTarjetaTripulante, strCarnetEmpresa, strCarnetComunicaciones, dtmFechaModif, logActualizado, lngIdUsuario,"TercerosConductores");

				return tercerosconductores;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Updates an TercerosConductores object by passing all object's fields
		/// </summary>
		/// <param name="intDigito">int that contents the intDigito value for the TercerosConductores object</param>
		/// <param name="strNombres">string that contents the strNombres value for the TercerosConductores object</param>
		/// <param name="strDireccion">string that contents the strDireccion value for the TercerosConductores object</param>
		/// <param name="logEstado">bool that contents the logEstado value for the TercerosConductores object</param>
		/// <param name="logConductor">bool that contents the logConductor value for the TercerosConductores object</param>
		/// <param name="strPlaca">string that contents the strPlaca value for the TercerosConductores object</param>
		/// <param name="lngIdCiudad">string that contents the lngIdCiudad value for the TercerosConductores object</param>
		/// <param name="strTelefono">string that contents the strTelefono value for the TercerosConductores object</param>
		/// <param name="strTelefonoAux">string that contents the strTelefonoAux value for the TercerosConductores object</param>
		/// <param name="strTelCelular">string that contents the strTelCelular value for the TercerosConductores object</param>
		/// <param name="strTelCelularAux">string that contents the strTelCelularAux value for the TercerosConductores object</param>
		/// <param name="strFax">string that contents the strFax value for the TercerosConductores object</param>
		/// <param name="IntAAereo">string that contents the IntAAereo value for the TercerosConductores object</param>
		/// <param name="StrPais">string that contents the StrPais value for the TercerosConductores object</param>
		/// <param name="nitProvedor">double that contents the nitProvedor value for the TercerosConductores object</param>
		/// <param name="intNoLicenciaConduc">double that contents the intNoLicenciaConduc value for the TercerosConductores object</param>
		/// <param name="intCategoria">int that contents the intCategoria value for the TercerosConductores object</param>
		/// <param name="strTarjetaTripulante">string that contents the strTarjetaTripulante value for the TercerosConductores object</param>
		/// <param name="dtmFechaVenceLicencia">DateTime that contents the dtmFechaVenceLicencia value for the TercerosConductores object</param>
		/// <param name="dtmVenceTarjetaTripulante">DateTime that contents the dtmVenceTarjetaTripulante value for the TercerosConductores object</param>
		/// <param name="strCarnetEmpresa">string that contents the strCarnetEmpresa value for the TercerosConductores object</param>
		/// <param name="strCarnetComunicaciones">string that contents the strCarnetComunicaciones value for the TercerosConductores object</param>
		/// <param name="dtmFechaModif">DateTime that contents the dtmFechaModif value for the TercerosConductores object</param>
		/// <param name="logActualizado">bool that contents the logActualizado value for the TercerosConductores object</param>
		/// <param name="lngIdUsuario">int that contents the lngIdUsuario value for the TercerosConductores object</param>
		/// <param name="strTipoIdentificacion">string that contents the strTipoIdentificacion value for the TercerosConductores object</param>
		/// <param name="IntNit">double that contents the IntNit value for the TercerosConductores object</param>
		public void Update(int? intDigito, string strNombres, string strDireccion, bool? logEstado, bool? logConductor, string strPlaca, string lngIdCiudad, string strTelefono, string strTelefonoAux, string strTelCelular, string strTelCelularAux, string strFax, string IntAAereo, string StrPais, double? nitProvedor, double? intNoLicenciaConduc, int? intCategoria, string strTarjetaTripulante, DateTime? dtmFechaVenceLicencia, DateTime? dtmVenceTarjetaTripulante, string strCarnetEmpresa, string strCarnetComunicaciones, DateTime? dtmFechaModif, bool? logActualizado, int? lngIdUsuario, string strTipoIdentificacion, double IntNit, Sinapsys.Datos.SQL datosTransaccion=null)
		{
			try 
			{
				TercerosConductores new_values = new TercerosConductores();
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
				new_values.dtmFechaModif = dtmFechaModif;
				new_values.logActualizado = logActualizado;
				new_values.lngIdUsuario = lngIdUsuario;
				TercerosConductoresDataProvider.Instance.Update(intDigito, strNombres, strDireccion, logEstado, logConductor, strPlaca, lngIdCiudad, strTelefono, strTelefonoAux, strTelCelular, strTelCelularAux, strFax, IntAAereo, StrPais, nitProvedor, intNoLicenciaConduc, intCategoria, strTarjetaTripulante, dtmFechaVenceLicencia, dtmVenceTarjetaTripulante, strCarnetEmpresa, strCarnetComunicaciones, dtmFechaModif, logActualizado, lngIdUsuario, strTipoIdentificacion, IntNit,"TercerosConductores",datosTransaccion);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Updates an TercerosConductores object by passing one object's instance as reference
		/// </summary>
		/// <param name="tercerosconductores">An instance of TercerosConductores for reference</param>
		public void Update(TercerosConductores tercerosconductores,Sinapsys.Datos.SQL datosTransaccion=null)
		{
			Update(tercerosconductores.intDigito, tercerosconductores.strNombres, tercerosconductores.strDireccion, tercerosconductores.logEstado, tercerosconductores.logConductor, tercerosconductores.strPlaca, tercerosconductores.lngIdCiudad, tercerosconductores.strTelefono, tercerosconductores.strTelefonoAux, tercerosconductores.strTelCelular, tercerosconductores.strTelCelularAux, tercerosconductores.strFax, tercerosconductores.IntAAereo, tercerosconductores.StrPais, tercerosconductores.nitProvedor, tercerosconductores.intNoLicenciaConduc, tercerosconductores.intCategoria, tercerosconductores.strTarjetaTripulante, tercerosconductores.dtmFechaVenceLicencia, tercerosconductores.dtmVenceTarjetaTripulante, tercerosconductores.strCarnetEmpresa, tercerosconductores.strCarnetComunicaciones, tercerosconductores.dtmFechaModif, tercerosconductores.logActualizado, tercerosconductores.lngIdUsuario, tercerosconductores.strTipoIdentificacion, tercerosconductores.IntNit);
		}

		/// <summary>
		/// Delete  the TercerosConductores object by passing a object
		/// </summary>
		public void  Delete(TercerosConductores tercerosconductores, Sinapsys.Datos.SQL datosTransaccion=null)
		{
			Delete(tercerosconductores.strTipoIdentificacion, tercerosconductores.IntNit,datosTransaccion);
		}

		/// <summary>
		/// Deletes the TercerosConductores object by passing one object's instance as reference
		/// </summary>
		/// <param name="tercerosconductores">An instance of TercerosConductores for reference</param>
		public void Delete(string strTipoIdentificacion, double IntNit, Sinapsys.Datos.SQL datosTransaccion=null)
		{
			try 
			{
				TercerosConductoresDataProvider.Instance.Delete(strTipoIdentificacion, IntNit,"TercerosConductores");
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Deletes the TercerosConductores object by passing CVS parameter as reference
		/// </summary>
		/// <param name="tercerosconductores">An instance of TercerosConductores for reference</param>
		public void Delete(string CVSParameter)
		{
			string[] StrCommand=CVSParameter.Split(',');
			try 
			{
				string strTipoIdentificacion=StrCommand[0];
				double IntNit=double.Parse(StrCommand[1]);
				TercerosConductoresDataProvider.Instance.Delete(strTipoIdentificacion, IntNit,"TercerosConductores");
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Gets the TercerosConductores object by passing the object's key fields
		/// </summary>
		/// <param name="strTipoIdentificacion">string that contents the strTipoIdentificacion value for the TercerosConductores object</param>
		/// <param name="IntNit">double that contents the IntNit value for the TercerosConductores object</param>
		/// <returns>One TercerosConductores object</returns>
		public TercerosConductores Get(string strTipoIdentificacion, double IntNit, bool generateUndo=false)
		{
			try 
			{
				TercerosConductores tercerosconductores = null;
				DataTable dt = TercerosConductoresDataProvider.Instance.Get(strTipoIdentificacion, IntNit);
				if ((dt.Rows.Count > 0))
				{
					tercerosconductores = new TercerosConductores();
					DataRow dr = dt.Rows[0];
					ReadData(tercerosconductores, dr, generateUndo);
				}


				return tercerosconductores;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Gets all objects of TercerosConductores
		/// </summary>
		/// <returns>One TercerosConductoresList object</returns>
		public TercerosConductoresList GetAll(bool generateUndo=false)
		{
			try 
			{
				TercerosConductoresList tercerosconductoreslist = new TercerosConductoresList();
				DataTable dt = TercerosConductoresDataProvider.Instance.GetAll();
				foreach (DataRow dr in dt.Rows)
				{
					TercerosConductores tercerosconductores = new TercerosConductores();
					ReadData(tercerosconductores, dr, generateUndo);
					tercerosconductoreslist.Add(tercerosconductores);
				}
				return tercerosconductoreslist;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Gets all objects of TercerosConductores applying filter and sort criteria
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
		/// <returns>One TercerosConductoresList object</returns>
		public TercerosConductoresList GetFilter(int pagenum, int pagesize, string filter, string sort, string extablesfilter, string extablesfieldsfilter, string extablesrelationsfilter, string extablessort, string extablesfieldssort, string extablesrelationssort, bool generateUndo=false)
		{
			try 
			{
				TercerosConductoresList tercerosconductoreslist = new TercerosConductoresList();

				DataTable dt = TercerosConductoresDataProvider.Instance.GetFilter(pagenum, pagesize, filter, sort, extablesfilter, extablesfieldsfilter, extablesrelationsfilter, extablessort, extablesfieldssort, extablesrelationssort);

				foreach (DataRow dr in dt.Rows)
				{
					TercerosConductores tercerosconductores = new TercerosConductores();
					ReadData(tercerosconductores, dr, generateUndo);
					tercerosconductoreslist.Add(tercerosconductores);
				}
				return tercerosconductoreslist;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public TercerosConductoresList GetFilter( string filter, string sort, bool generateUndo=false)
		{
			return GetFilter(0,0, filter, sort, "","","","","","",generateUndo);
		}

		public TercerosConductoresList GetFilter(string filter, string sort, string extablesfilter, string extablesfieldsfilter, string extablesrelationsfilter, string extablessort, string extablesfieldssort, string extablesrelationssort, bool generateUndo=false)
		{
			return GetFilter(0,0, filter, sort, extablesfilter, extablesfieldsfilter, extablesrelationsfilter, extablessort, extablesfieldssort, extablesrelationssort,generateUndo);
		}


		/// <summary>
		/// Returns the type for one property
		/// </summary>
		/// <param name="propertyname">Property's name for return its value</param>
		/// <returns>A value for the <paramref name="propertyname"/></returns>
		public Type GetMethodType( string propertyname,TercerosConductores tercerosconductores)
		{
			// Perform the search for the property's value
			switch (propertyname)
			{
				case "intDigito":
					return tercerosconductores.intDigito.GetType();

				case "strNombres":
					return tercerosconductores.strNombres.GetType();

				case "strDireccion":
					return tercerosconductores.strDireccion.GetType();

				case "logEstado":
					return tercerosconductores.logEstado.GetType();

				case "logConductor":
					return tercerosconductores.logConductor.GetType();

				case "strPlaca":
					return tercerosconductores.strPlaca.GetType();

				case "lngIdCiudad":
					return tercerosconductores.lngIdCiudad.GetType();

				case "strTelefono":
					return tercerosconductores.strTelefono.GetType();

				case "strTelefonoAux":
					return tercerosconductores.strTelefonoAux.GetType();

				case "strTelCelular":
					return tercerosconductores.strTelCelular.GetType();

				case "strTelCelularAux":
					return tercerosconductores.strTelCelularAux.GetType();

				case "strFax":
					return tercerosconductores.strFax.GetType();

				case "IntAAereo":
					return tercerosconductores.IntAAereo.GetType();

				case "StrPais":
					return tercerosconductores.StrPais.GetType();

				case "nitProvedor":
					return tercerosconductores.nitProvedor.GetType();

				case "intNoLicenciaConduc":
					return tercerosconductores.intNoLicenciaConduc.GetType();

				case "intCategoria":
					return tercerosconductores.intCategoria.GetType();

				case "strTarjetaTripulante":
					return tercerosconductores.strTarjetaTripulante.GetType();

				case "dtmFechaVenceLicencia":
					return tercerosconductores.dtmFechaVenceLicencia.GetType();

				case "dtmVenceTarjetaTripulante":
					return tercerosconductores.dtmVenceTarjetaTripulante.GetType();

				case "strCarnetEmpresa":
					return tercerosconductores.strCarnetEmpresa.GetType();

				case "strCarnetComunicaciones":
					return tercerosconductores.strCarnetComunicaciones.GetType();

				case "dtmFechaModif":
					return tercerosconductores.dtmFechaModif.GetType();

				case "logActualizado":
					return tercerosconductores.logActualizado.GetType();

				case "lngIdUsuario":
					return tercerosconductores.lngIdUsuario.GetType();

				case "strTipoIdentificacion":
					return tercerosconductores.strTipoIdentificacion.GetType();

				case "IntNit":
					return tercerosconductores.IntNit.GetType();

			}

			return null;
		}
		/// <summary>
		/// update the changes in TercerosConductores object by passing the object
		/// </summary>
		public bool UpdateChanges(TercerosConductores tercerosconductores, out string error,Sinapsys.Datos.SQL datosTransaccion=null)
		{
			if (tercerosconductores.OldTercerosConductores == null)
			{
				    error = "No tiene objeto con el cual comparar";
				    return false;
			}
			string[] Fields = tercerosconductores.FieldChanged();
			error = "";
			return LiqViajes_Bll_Data.DataProvider.UpdateFieldsbyObject(Fields, tercerosconductores, out error,datosTransaccion);
		}
	}

	#endregion

}
