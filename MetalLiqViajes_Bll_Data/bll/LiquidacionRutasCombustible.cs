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
	#region LiquidacionRutasCombustibleController

	/// <summary>
	/// Class for convert data from database into object's data and vice versa
	/// </summary>
	public partial class LiquidacionRutasCombustibleController//: ILatinodeController
	{
		/// <summary>
		/// Generic Constructor
		/// </summary>
		public LiquidacionRutasCombustibleController()
		{
		}

		/// <summary>
		/// Instance accessor for this singleton
		/// </summary>
		private static LiquidacionRutasCombustibleController MySingleObj;
		public static LiquidacionRutasCombustibleController Instance
		{
			get
			{
				if (MySingleObj == null)
				{
					MySingleObj = new LiquidacionRutasCombustibleController();
				}
				return MySingleObj;
			}
		}

		// Reads object's data from a DataRow
		private void ReadData(LiquidacionRutasCombustible liquidacionrutascombustible, DataRow dr,bool generateUndo=false)
		{
			try 
			{
				liquidacionrutascombustible.Codigo = (long) dr["Codigo"];
				liquidacionrutascombustible.lngIdRegistrRutaItemId = dr.IsNull("lngIdRegistrRutaItemId") ? null :(long?) dr["lngIdRegistrRutaItemId"];
				liquidacionrutascombustible.lngIdRegistro = dr.IsNull("lngIdRegistro") ? null :(long?) dr["lngIdRegistro"];
				liquidacionrutascombustible.lngIdRegistrRuta = dr.IsNull("lngIdRegistrRuta") ? null :(long?) dr["lngIdRegistrRuta"];
				liquidacionrutascombustible.intRowRegistro = dr.IsNull("intRowRegistro") ? null :(long?) dr["intRowRegistro"];
				liquidacionrutascombustible.strRutaAnticipoGrupoOrigen = dr.IsNull("strRutaAnticipoGrupoOrigen") ? null :(string) dr["strRutaAnticipoGrupoOrigen"];
				liquidacionrutascombustible.strRutaAnticipoGrupoDestino = dr.IsNull("strRutaAnticipoGrupoDestino") ? null :(string) dr["strRutaAnticipoGrupoDestino"];
				liquidacionrutascombustible.nitTercero = dr.IsNull("nitTercero") ? null :(string) dr["nitTercero"];
				liquidacionrutascombustible.NombreTercero = dr.IsNull("NombreTercero") ? null :(string) dr["NombreTercero"];
				liquidacionrutascombustible.floGalones = dr.IsNull("floGalones") ? null :(decimal?) dr["floGalones"];
				liquidacionrutascombustible.curValorGalon = dr.IsNull("curValorGalon") ? null :(decimal?) dr["curValorGalon"];
				liquidacionrutascombustible.cutCombustible = dr.IsNull("cutCombustible") ? null :(decimal?) dr["cutCombustible"];
				liquidacionrutascombustible.nitTerceroComplentario = dr.IsNull("nitTerceroComplentario") ? null :(string) dr["nitTerceroComplentario"];
				liquidacionrutascombustible.NombreTerceroComplementario = dr.IsNull("NombreTerceroComplementario") ? null :(string) dr["NombreTerceroComplementario"];
				liquidacionrutascombustible.floGalonesComplementario = dr.IsNull("floGalonesComplementario") ? null :(decimal?) dr["floGalonesComplementario"];
				liquidacionrutascombustible.curValorGalonComplentario = dr.IsNull("curValorGalonComplentario") ? null :(decimal?) dr["curValorGalonComplentario"];
				liquidacionrutascombustible.cutCombustibleComplementario = dr.IsNull("cutCombustibleComplementario") ? null :(decimal?) dr["cutCombustibleComplementario"];
				liquidacionrutascombustible.strObservaciones = dr.IsNull("strObservaciones") ? null :(string) dr["strObservaciones"];
			}
			catch (Exception ex)
			{
				Utilidades.LogErrores(ex.Message + (ex.InnerException != null ? ex.InnerException.Message : ""), DataProvider.AplicacionNombre);
				throw ex;
			}
			if (generateUndo) liquidacionrutascombustible.GenerateUndo();
		}

		/// <summary>
		/// Create a new LiquidacionRutasCombustible object by passing a object
		/// </summary>
		public LiquidacionRutasCombustible Create(LiquidacionRutasCombustible liquidacionrutascombustible, Sinapsys.Datos.SQL datosTransaccion=null)
		{
			return Create(liquidacionrutascombustible.Codigo,liquidacionrutascombustible.lngIdRegistrRutaItemId,liquidacionrutascombustible.lngIdRegistro,liquidacionrutascombustible.lngIdRegistrRuta,liquidacionrutascombustible.intRowRegistro,liquidacionrutascombustible.strRutaAnticipoGrupoOrigen,liquidacionrutascombustible.strRutaAnticipoGrupoDestino,liquidacionrutascombustible.nitTercero,liquidacionrutascombustible.NombreTercero,liquidacionrutascombustible.floGalones,liquidacionrutascombustible.curValorGalon,liquidacionrutascombustible.cutCombustible,liquidacionrutascombustible.nitTerceroComplentario,liquidacionrutascombustible.NombreTerceroComplementario,liquidacionrutascombustible.floGalonesComplementario,liquidacionrutascombustible.curValorGalonComplentario,liquidacionrutascombustible.cutCombustibleComplementario,liquidacionrutascombustible.strObservaciones,datosTransaccion);
		}

		/// <summary>
		/// Creates a new LiquidacionRutasCombustible object by passing all object's fields
		/// </summary>
		/// <param name="lngIdRegistrRutaItemId">long that contents the lngIdRegistrRutaItemId value for the LiquidacionRutasCombustible object</param>
		/// <param name="lngIdRegistro">long that contents the lngIdRegistro value for the LiquidacionRutasCombustible object</param>
		/// <param name="lngIdRegistrRuta">long that contents the lngIdRegistrRuta value for the LiquidacionRutasCombustible object</param>
		/// <param name="intRowRegistro">long that contents the intRowRegistro value for the LiquidacionRutasCombustible object</param>
		/// <param name="strRutaAnticipoGrupoOrigen">string that contents the strRutaAnticipoGrupoOrigen value for the LiquidacionRutasCombustible object</param>
		/// <param name="strRutaAnticipoGrupoDestino">string that contents the strRutaAnticipoGrupoDestino value for the LiquidacionRutasCombustible object</param>
		/// <param name="nitTercero">string that contents the nitTercero value for the LiquidacionRutasCombustible object</param>
		/// <param name="NombreTercero">string that contents the NombreTercero value for the LiquidacionRutasCombustible object</param>
		/// <param name="floGalones">decimal that contents the floGalones value for the LiquidacionRutasCombustible object</param>
		/// <param name="curValorGalon">decimal that contents the curValorGalon value for the LiquidacionRutasCombustible object</param>
		/// <param name="cutCombustible">decimal that contents the cutCombustible value for the LiquidacionRutasCombustible object</param>
		/// <param name="nitTerceroComplentario">string that contents the nitTerceroComplentario value for the LiquidacionRutasCombustible object</param>
		/// <param name="NombreTerceroComplementario">string that contents the NombreTerceroComplementario value for the LiquidacionRutasCombustible object</param>
		/// <param name="floGalonesComplementario">decimal that contents the floGalonesComplementario value for the LiquidacionRutasCombustible object</param>
		/// <param name="curValorGalonComplentario">decimal that contents the curValorGalonComplentario value for the LiquidacionRutasCombustible object</param>
		/// <param name="cutCombustibleComplementario">decimal that contents the cutCombustibleComplementario value for the LiquidacionRutasCombustible object</param>
		/// <param name="strObservaciones">string that contents the strObservaciones value for the LiquidacionRutasCombustible object</param>
		/// <returns>One LiquidacionRutasCombustible object</returns>
		public LiquidacionRutasCombustible Create(long Codigo, long? lngIdRegistrRutaItemId, long? lngIdRegistro, long? lngIdRegistrRuta, long? intRowRegistro, string strRutaAnticipoGrupoOrigen, string strRutaAnticipoGrupoDestino, string nitTercero, string NombreTercero, decimal? floGalones, decimal? curValorGalon, decimal? cutCombustible, string nitTerceroComplentario, string NombreTerceroComplementario, decimal? floGalonesComplementario, decimal? curValorGalonComplentario, decimal? cutCombustibleComplementario, string strObservaciones, Sinapsys.Datos.SQL datosTransaccion=null)
		{
			try 
			{
				LiquidacionRutasCombustible liquidacionrutascombustible = new LiquidacionRutasCombustible();

				liquidacionrutascombustible.Codigo = Codigo;
				liquidacionrutascombustible.Codigo = Codigo;
				liquidacionrutascombustible.lngIdRegistrRutaItemId = lngIdRegistrRutaItemId;
				liquidacionrutascombustible.lngIdRegistro = lngIdRegistro;
				liquidacionrutascombustible.lngIdRegistrRuta = lngIdRegistrRuta;
				liquidacionrutascombustible.intRowRegistro = intRowRegistro;
				liquidacionrutascombustible.strRutaAnticipoGrupoOrigen = strRutaAnticipoGrupoOrigen;
				liquidacionrutascombustible.strRutaAnticipoGrupoDestino = strRutaAnticipoGrupoDestino;
				liquidacionrutascombustible.nitTercero = nitTercero;
				liquidacionrutascombustible.NombreTercero = NombreTercero;
				liquidacionrutascombustible.floGalones = floGalones;
				liquidacionrutascombustible.curValorGalon = curValorGalon;
				liquidacionrutascombustible.cutCombustible = cutCombustible;
				liquidacionrutascombustible.nitTerceroComplentario = nitTerceroComplentario;
				liquidacionrutascombustible.NombreTerceroComplementario = NombreTerceroComplementario;
				liquidacionrutascombustible.floGalonesComplementario = floGalonesComplementario;
				liquidacionrutascombustible.curValorGalonComplentario = curValorGalonComplentario;
				liquidacionrutascombustible.cutCombustibleComplementario = cutCombustibleComplementario;
				liquidacionrutascombustible.strObservaciones = strObservaciones;
				Codigo = LiquidacionRutasCombustibleDataProvider.Instance.Create(Codigo, lngIdRegistrRutaItemId, lngIdRegistro, lngIdRegistrRuta, intRowRegistro, strRutaAnticipoGrupoOrigen, strRutaAnticipoGrupoDestino, nitTercero, NombreTercero, floGalones, curValorGalon, cutCombustible, nitTerceroComplentario, NombreTerceroComplementario, floGalonesComplementario, curValorGalonComplentario, cutCombustibleComplementario, strObservaciones,"LiquidacionRutasCombustible",datosTransaccion);
				if (Codigo == 0)
					return null;

				liquidacionrutascombustible.Codigo = Codigo;

				return liquidacionrutascombustible;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Updates an LiquidacionRutasCombustible object by passing all object's fields
		/// </summary>
		/// <param name="Codigo">long that contents the Codigo value for the LiquidacionRutasCombustible object</param>
		/// <param name="lngIdRegistrRutaItemId">long that contents the lngIdRegistrRutaItemId value for the LiquidacionRutasCombustible object</param>
		/// <param name="lngIdRegistro">long that contents the lngIdRegistro value for the LiquidacionRutasCombustible object</param>
		/// <param name="lngIdRegistrRuta">long that contents the lngIdRegistrRuta value for the LiquidacionRutasCombustible object</param>
		/// <param name="intRowRegistro">long that contents the intRowRegistro value for the LiquidacionRutasCombustible object</param>
		/// <param name="strRutaAnticipoGrupoOrigen">string that contents the strRutaAnticipoGrupoOrigen value for the LiquidacionRutasCombustible object</param>
		/// <param name="strRutaAnticipoGrupoDestino">string that contents the strRutaAnticipoGrupoDestino value for the LiquidacionRutasCombustible object</param>
		/// <param name="nitTercero">string that contents the nitTercero value for the LiquidacionRutasCombustible object</param>
		/// <param name="NombreTercero">string that contents the NombreTercero value for the LiquidacionRutasCombustible object</param>
		/// <param name="floGalones">decimal that contents the floGalones value for the LiquidacionRutasCombustible object</param>
		/// <param name="curValorGalon">decimal that contents the curValorGalon value for the LiquidacionRutasCombustible object</param>
		/// <param name="cutCombustible">decimal that contents the cutCombustible value for the LiquidacionRutasCombustible object</param>
		/// <param name="nitTerceroComplentario">string that contents the nitTerceroComplentario value for the LiquidacionRutasCombustible object</param>
		/// <param name="NombreTerceroComplementario">string that contents the NombreTerceroComplementario value for the LiquidacionRutasCombustible object</param>
		/// <param name="floGalonesComplementario">decimal that contents the floGalonesComplementario value for the LiquidacionRutasCombustible object</param>
		/// <param name="curValorGalonComplentario">decimal that contents the curValorGalonComplentario value for the LiquidacionRutasCombustible object</param>
		/// <param name="cutCombustibleComplementario">decimal that contents the cutCombustibleComplementario value for the LiquidacionRutasCombustible object</param>
		/// <param name="strObservaciones">string that contents the strObservaciones value for the LiquidacionRutasCombustible object</param>
		public void Update(long Codigo, long? lngIdRegistrRutaItemId, long? lngIdRegistro, long? lngIdRegistrRuta, long? intRowRegistro, string strRutaAnticipoGrupoOrigen, string strRutaAnticipoGrupoDestino, string nitTercero, string NombreTercero, decimal? floGalones, decimal? curValorGalon, decimal? cutCombustible, string nitTerceroComplentario, string NombreTerceroComplementario, decimal? floGalonesComplementario, decimal? curValorGalonComplentario, decimal? cutCombustibleComplementario, string strObservaciones, Sinapsys.Datos.SQL datosTransaccion=null)
		{
			try 
			{
				LiquidacionRutasCombustible new_values = new LiquidacionRutasCombustible();
				new_values.lngIdRegistrRutaItemId = lngIdRegistrRutaItemId;
				new_values.lngIdRegistro = lngIdRegistro;
				new_values.lngIdRegistrRuta = lngIdRegistrRuta;
				new_values.intRowRegistro = intRowRegistro;
				new_values.strRutaAnticipoGrupoOrigen = strRutaAnticipoGrupoOrigen;
				new_values.strRutaAnticipoGrupoDestino = strRutaAnticipoGrupoDestino;
				new_values.nitTercero = nitTercero;
				new_values.NombreTercero = NombreTercero;
				new_values.floGalones = floGalones;
				new_values.curValorGalon = curValorGalon;
				new_values.cutCombustible = cutCombustible;
				new_values.nitTerceroComplentario = nitTerceroComplentario;
				new_values.NombreTerceroComplementario = NombreTerceroComplementario;
				new_values.floGalonesComplementario = floGalonesComplementario;
				new_values.curValorGalonComplentario = curValorGalonComplentario;
				new_values.cutCombustibleComplementario = cutCombustibleComplementario;
				new_values.strObservaciones = strObservaciones;
				LiquidacionRutasCombustibleDataProvider.Instance.Update(Codigo, lngIdRegistrRutaItemId, lngIdRegistro, lngIdRegistrRuta, intRowRegistro, strRutaAnticipoGrupoOrigen, strRutaAnticipoGrupoDestino, nitTercero, NombreTercero, floGalones, curValorGalon, cutCombustible, nitTerceroComplentario, NombreTerceroComplementario, floGalonesComplementario, curValorGalonComplentario, cutCombustibleComplementario, strObservaciones,"LiquidacionRutasCombustible",datosTransaccion);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Updates an LiquidacionRutasCombustible object by passing one object's instance as reference
		/// </summary>
		/// <param name="liquidacionrutascombustible">An instance of LiquidacionRutasCombustible for reference</param>
		public void Update(LiquidacionRutasCombustible liquidacionrutascombustible,Sinapsys.Datos.SQL datosTransaccion=null)
		{
			Update(liquidacionrutascombustible.Codigo, liquidacionrutascombustible.lngIdRegistrRutaItemId, liquidacionrutascombustible.lngIdRegistro, liquidacionrutascombustible.lngIdRegistrRuta, liquidacionrutascombustible.intRowRegistro, liquidacionrutascombustible.strRutaAnticipoGrupoOrigen, liquidacionrutascombustible.strRutaAnticipoGrupoDestino, liquidacionrutascombustible.nitTercero, liquidacionrutascombustible.NombreTercero, liquidacionrutascombustible.floGalones, liquidacionrutascombustible.curValorGalon, liquidacionrutascombustible.cutCombustible, liquidacionrutascombustible.nitTerceroComplentario, liquidacionrutascombustible.NombreTerceroComplementario, liquidacionrutascombustible.floGalonesComplementario, liquidacionrutascombustible.curValorGalonComplentario, liquidacionrutascombustible.cutCombustibleComplementario, liquidacionrutascombustible.strObservaciones);
		}

		/// <summary>
		/// Delete  the LiquidacionRutasCombustible object by passing a object
		/// </summary>
		public void  Delete(LiquidacionRutasCombustible liquidacionrutascombustible, Sinapsys.Datos.SQL datosTransaccion=null)
		{
			Delete(liquidacionrutascombustible.Codigo,datosTransaccion);
		}

		/// <summary>
		/// Deletes the LiquidacionRutasCombustible object by passing one object's instance as reference
		/// </summary>
		/// <param name="liquidacionrutascombustible">An instance of LiquidacionRutasCombustible for reference</param>
		public void Delete(long Codigo, Sinapsys.Datos.SQL datosTransaccion=null)
		{
			try 
			{
				//LiquidacionRutasCombustible old_values = LiquidacionRutasCombustibleController.Instance.Get(Codigo);
				//if(!Validate.security.CanDeleteSecurityField(LiquidacionRutasCombustibleController.Instance, (ILatinodeObject)old_values))
				//    throw new Exception("Access denied by security field, you can't delete object");

				LiquidacionRutasCombustibleDataProvider.Instance.Delete(Codigo,"LiquidacionRutasCombustible");
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Deletes the LiquidacionRutasCombustible object by passing CVS parameter as reference
		/// </summary>
		/// <param name="liquidacionrutascombustible">An instance of LiquidacionRutasCombustible for reference</param>
		public void Delete(string CVSParameter)
		{
			string[] StrCommand=CVSParameter.Split(',');
			try 
			{
				long Codigo=long.Parse(StrCommand[0]);
				LiquidacionRutasCombustibleDataProvider.Instance.Delete(Codigo,"LiquidacionRutasCombustible");
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Gets the LiquidacionRutasCombustible object by passing the object's key fields
		/// </summary>
		/// <param name="Codigo">long that contents the Codigo value for the LiquidacionRutasCombustible object</param>
		/// <returns>One LiquidacionRutasCombustible object</returns>
		public LiquidacionRutasCombustible Get(long Codigo, bool generateUndo=false)
		{
			try 
			{
				LiquidacionRutasCombustible liquidacionrutascombustible = null;
				DataTable dt = LiquidacionRutasCombustibleDataProvider.Instance.Get(Codigo);
				if ((dt.Rows.Count > 0))
				{
					liquidacionrutascombustible = new LiquidacionRutasCombustible();
					DataRow dr = dt.Rows[0];
					ReadData(liquidacionrutascombustible, dr, generateUndo);
				}


				return liquidacionrutascombustible;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Gets all objects of LiquidacionRutasCombustible
		/// </summary>
		/// <returns>One LiquidacionRutasCombustibleList object</returns>
		public LiquidacionRutasCombustibleList GetAll(bool generateUndo=false)
		{
			try 
			{
				LiquidacionRutasCombustibleList liquidacionrutascombustiblelist = new LiquidacionRutasCombustibleList();
				DataTable dt = LiquidacionRutasCombustibleDataProvider.Instance.GetAll();
				foreach (DataRow dr in dt.Rows)
				{
					LiquidacionRutasCombustible liquidacionrutascombustible = new LiquidacionRutasCombustible();
					ReadData(liquidacionrutascombustible, dr, generateUndo);
					liquidacionrutascombustiblelist.Add(liquidacionrutascombustible);
				}
				return liquidacionrutascombustiblelist;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Gets all objects of LiquidacionRutasCombustible applying filter and sort criteria
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
		/// <returns>One LiquidacionRutasCombustibleList object</returns>
		public LiquidacionRutasCombustibleList GetFilter(int pagenum, int pagesize, string filter, string sort, string extablesfilter, string extablesfieldsfilter, string extablesrelationsfilter, string extablessort, string extablesfieldssort, string extablesrelationssort, bool generateUndo=false)
		{
			try 
			{
				LiquidacionRutasCombustibleList liquidacionrutascombustiblelist = new LiquidacionRutasCombustibleList();

				DataTable dt = LiquidacionRutasCombustibleDataProvider.Instance.GetFilter(pagenum, pagesize, filter, sort, extablesfilter, extablesfieldsfilter, extablesrelationsfilter, extablessort, extablesfieldssort, extablesrelationssort);

				foreach (DataRow dr in dt.Rows)
				{
					LiquidacionRutasCombustible liquidacionrutascombustible = new LiquidacionRutasCombustible();
					ReadData(liquidacionrutascombustible, dr, generateUndo);
					liquidacionrutascombustiblelist.Add(liquidacionrutascombustible);
				}
				return liquidacionrutascombustiblelist;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public LiquidacionRutasCombustibleList GetFilter( string filter, string sort, bool generateUndo=false)
		{
			return GetFilter(0,0, filter, sort, "","","","","","",generateUndo);
		}

		public LiquidacionRutasCombustibleList GetFilter(string filter, string sort, string extablesfilter, string extablesfieldsfilter, string extablesrelationsfilter, string extablessort, string extablesfieldssort, string extablesrelationssort, bool generateUndo=false)
		{
			return GetFilter(0,0, filter, sort, extablesfilter, extablesfieldsfilter, extablesrelationsfilter, extablessort, extablesfieldssort, extablesrelationssort,generateUndo);
		}


		/// <summary>
		/// Returns the type for one property
		/// </summary>
		/// <param name="propertyname">Property's name for return its value</param>
		/// <returns>A value for the <paramref name="propertyname"/></returns>
		public Type GetMethodType( string propertyname,LiquidacionRutasCombustible liquidacionrutascombustible)
		{
			// Perform the search for the property's value
			switch (propertyname)
			{
				case "Codigo":
					return liquidacionrutascombustible.Codigo.GetType();

				case "lngIdRegistrRutaItemId":
					return liquidacionrutascombustible.lngIdRegistrRutaItemId.GetType();

				case "lngIdRegistro":
					return liquidacionrutascombustible.lngIdRegistro.GetType();

				case "lngIdRegistrRuta":
					return liquidacionrutascombustible.lngIdRegistrRuta.GetType();

				case "intRowRegistro":
					return liquidacionrutascombustible.intRowRegistro.GetType();

				case "strRutaAnticipoGrupoOrigen":
					return liquidacionrutascombustible.strRutaAnticipoGrupoOrigen.GetType();

				case "strRutaAnticipoGrupoDestino":
					return liquidacionrutascombustible.strRutaAnticipoGrupoDestino.GetType();

				case "nitTercero":
					return liquidacionrutascombustible.nitTercero.GetType();

				case "NombreTercero":
					return liquidacionrutascombustible.NombreTercero.GetType();

				case "floGalones":
					return liquidacionrutascombustible.floGalones.GetType();

				case "curValorGalon":
					return liquidacionrutascombustible.curValorGalon.GetType();

				case "cutCombustible":
					return liquidacionrutascombustible.cutCombustible.GetType();

				case "nitTerceroComplentario":
					return liquidacionrutascombustible.nitTerceroComplentario.GetType();

				case "NombreTerceroComplementario":
					return liquidacionrutascombustible.NombreTerceroComplementario.GetType();

				case "floGalonesComplementario":
					return liquidacionrutascombustible.floGalonesComplementario.GetType();

				case "curValorGalonComplentario":
					return liquidacionrutascombustible.curValorGalonComplentario.GetType();

				case "cutCombustibleComplementario":
					return liquidacionrutascombustible.cutCombustibleComplementario.GetType();

				case "strObservaciones":
					return liquidacionrutascombustible.strObservaciones.GetType();

			}

			return null;
		}
		/// <summary>
		/// update the changes in LiquidacionRutasCombustible object by passing the object
		/// </summary>
		public bool UpdateChanges(LiquidacionRutasCombustible liquidacionrutascombustible, out string error,Sinapsys.Datos.SQL datosTransaccion=null)
		{
			if (liquidacionrutascombustible.OldLiquidacionRutasCombustible == null)
			{
				    error = "No tiene objeto con el cual comparar";
				    return false;
			}
			string[] Fields = liquidacionrutascombustible.FieldChanged();
			error = "";
			return LiqViajes_Bll_Data.DataProvider.UpdateFieldsbyObject(Fields, liquidacionrutascombustible, out error,datosTransaccion);
		}
	}

	#endregion

}
