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
	#region VehiculoCombustibleController

	/// <summary>
	/// Class for convert data from database into object's data and vice versa
	/// </summary>
	public partial class VehiculoCombustibleController//: ILatinodeController
	{
		/// <summary>
		/// Generic Constructor
		/// </summary>
		public VehiculoCombustibleController()
		{
		}

		/// <summary>
		/// Instance accessor for this singleton
		/// </summary>
		private static VehiculoCombustibleController MySingleObj;
		public static VehiculoCombustibleController Instance
		{
			get
			{
				if (MySingleObj == null)
				{
					MySingleObj = new VehiculoCombustibleController();
				}
				return MySingleObj;
			}
		}

		// Reads object's data from a DataRow
		private void ReadData(VehiculoCombustible vehiculocombustible, DataRow dr,bool generateUndo=false)
		{
			try 
			{
				vehiculocombustible.lngIdRegistro = dr.IsNull("lngIdRegistro") ? null :(int?) dr["lngIdRegistro"];
				vehiculocombustible.tblLiquidacionRutasCombustibleCodigo = dr.IsNull("tblLiquidacionRutasCombustibleCodigo") ? null :(long?) dr["tblLiquidacionRutasCombustibleCodigo"];
				vehiculocombustible.Placa = dr.IsNull("Placa") ? null :(string) dr["Placa"];
				vehiculocombustible.FechaTanqueo = dr.IsNull("FechaTanqueo") ? null :(DateTime?) dr["FechaTanqueo"];
				vehiculocombustible.GalonesReserva = dr.IsNull("GalonesReserva") ? null :(decimal?) dr["GalonesReserva"];
				vehiculocombustible.GalonesTanqueo = dr.IsNull("GalonesTanqueo") ? null :(decimal?) dr["GalonesTanqueo"];
				vehiculocombustible.ValorGalon = dr.IsNull("ValorGalon") ? null :(decimal?) dr["ValorGalon"];
				vehiculocombustible.ValorCombustible = dr.IsNull("ValorCombustible") ? null :(decimal?) dr["ValorCombustible"];
				vehiculocombustible.nitTerceroComplentario = dr.IsNull("nitTerceroComplentario") ? null :(string) dr["nitTerceroComplentario"];
				vehiculocombustible.NombreTerceroComplementario = dr.IsNull("NombreTerceroComplementario") ? null :(string) dr["NombreTerceroComplementario"];
				vehiculocombustible.sw = (byte) dr["sw"];
				vehiculocombustible.tipo = (string) dr["tipo"];
				vehiculocombustible.numero = (int) dr["numero"];
				vehiculocombustible.strObservaciones = dr.IsNull("strObservaciones") ? null :(string) dr["strObservaciones"];
				vehiculocombustible.Codigo = (long) dr["Codigo"];
			}
			catch (Exception ex)
			{
				Utilidades.LogErrores(ex.Message + (ex.InnerException != null ? ex.InnerException.Message : ""), DataProvider.AplicacionNombre);
				throw ex;
			}
			if (generateUndo) vehiculocombustible.GenerateUndo();
		}

		/// <summary>
		/// Create a new VehiculoCombustible object by passing a object
		/// </summary>
		public VehiculoCombustible Create(VehiculoCombustible vehiculocombustible, Sinapsys.Datos.SQL datosTransaccion=null)
		{
			return Create(vehiculocombustible.Codigo,vehiculocombustible.lngIdRegistro,vehiculocombustible.tblLiquidacionRutasCombustibleCodigo,vehiculocombustible.Placa,vehiculocombustible.FechaTanqueo,vehiculocombustible.GalonesReserva,vehiculocombustible.GalonesTanqueo,vehiculocombustible.ValorGalon,vehiculocombustible.ValorCombustible,vehiculocombustible.nitTerceroComplentario,vehiculocombustible.NombreTerceroComplementario,vehiculocombustible.sw,vehiculocombustible.tipo,vehiculocombustible.numero,vehiculocombustible.strObservaciones,datosTransaccion);
		}

		/// <summary>
		/// Creates a new VehiculoCombustible object by passing all object's fields
		/// </summary>
		/// <param name="lngIdRegistro">int that contents the lngIdRegistro value for the VehiculoCombustible object</param>
		/// <param name="tblLiquidacionRutasCombustibleCodigo">long that contents the tblLiquidacionRutasCombustibleCodigo value for the VehiculoCombustible object</param>
		/// <param name="Placa">string that contents the Placa value for the VehiculoCombustible object</param>
		/// <param name="FechaTanqueo">DateTime that contents the FechaTanqueo value for the VehiculoCombustible object</param>
		/// <param name="GalonesReserva">decimal that contents the GalonesReserva value for the VehiculoCombustible object</param>
		/// <param name="GalonesTanqueo">decimal that contents the GalonesTanqueo value for the VehiculoCombustible object</param>
		/// <param name="ValorGalon">decimal that contents the ValorGalon value for the VehiculoCombustible object</param>
		/// <param name="ValorCombustible">decimal that contents the ValorCombustible value for the VehiculoCombustible object</param>
		/// <param name="nitTerceroComplentario">string that contents the nitTerceroComplentario value for the VehiculoCombustible object</param>
		/// <param name="NombreTerceroComplementario">string that contents the NombreTerceroComplementario value for the VehiculoCombustible object</param>
		/// <param name="sw">byte that contents the sw value for the VehiculoCombustible object</param>
		/// <param name="tipo">string that contents the tipo value for the VehiculoCombustible object</param>
		/// <param name="numero">int that contents the numero value for the VehiculoCombustible object</param>
		/// <param name="strObservaciones">string that contents the strObservaciones value for the VehiculoCombustible object</param>
		/// <returns>One VehiculoCombustible object</returns>
		public VehiculoCombustible Create(long Codigo, int? lngIdRegistro, long? tblLiquidacionRutasCombustibleCodigo, string Placa, DateTime? FechaTanqueo, decimal? GalonesReserva, decimal? GalonesTanqueo, decimal? ValorGalon, decimal? ValorCombustible, string nitTerceroComplentario, string NombreTerceroComplementario, byte sw, string tipo, int numero, string strObservaciones, Sinapsys.Datos.SQL datosTransaccion=null)
		{
			try 
			{
				VehiculoCombustible vehiculocombustible = new VehiculoCombustible();

				vehiculocombustible.Codigo = Codigo;
				vehiculocombustible.Codigo = Codigo;
				vehiculocombustible.lngIdRegistro = lngIdRegistro;
				vehiculocombustible.tblLiquidacionRutasCombustibleCodigo = tblLiquidacionRutasCombustibleCodigo;
				vehiculocombustible.Placa = Placa;
				vehiculocombustible.FechaTanqueo = FechaTanqueo;
				vehiculocombustible.GalonesReserva = GalonesReserva;
				vehiculocombustible.GalonesTanqueo = GalonesTanqueo;
				vehiculocombustible.ValorGalon = ValorGalon;
				vehiculocombustible.ValorCombustible = ValorCombustible;
				vehiculocombustible.nitTerceroComplentario = nitTerceroComplentario;
				vehiculocombustible.NombreTerceroComplementario = NombreTerceroComplementario;
				vehiculocombustible.sw = sw;
				vehiculocombustible.tipo = tipo;
				vehiculocombustible.numero = numero;
				vehiculocombustible.strObservaciones = strObservaciones;
				Codigo = VehiculoCombustibleDataProvider.Instance.Create(Codigo, lngIdRegistro, tblLiquidacionRutasCombustibleCodigo, Placa, FechaTanqueo, GalonesReserva, GalonesTanqueo, ValorGalon, ValorCombustible, nitTerceroComplentario, NombreTerceroComplementario, sw, tipo, numero, strObservaciones,"VehiculoCombustible",datosTransaccion);
				if (Codigo == 0)
					return null;

				vehiculocombustible.Codigo = Codigo;

				return vehiculocombustible;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Updates an VehiculoCombustible object by passing all object's fields
		/// </summary>
		/// <param name="lngIdRegistro">int that contents the lngIdRegistro value for the VehiculoCombustible object</param>
		/// <param name="tblLiquidacionRutasCombustibleCodigo">long that contents the tblLiquidacionRutasCombustibleCodigo value for the VehiculoCombustible object</param>
		/// <param name="Placa">string that contents the Placa value for the VehiculoCombustible object</param>
		/// <param name="FechaTanqueo">DateTime that contents the FechaTanqueo value for the VehiculoCombustible object</param>
		/// <param name="GalonesReserva">decimal that contents the GalonesReserva value for the VehiculoCombustible object</param>
		/// <param name="GalonesTanqueo">decimal that contents the GalonesTanqueo value for the VehiculoCombustible object</param>
		/// <param name="ValorGalon">decimal that contents the ValorGalon value for the VehiculoCombustible object</param>
		/// <param name="ValorCombustible">decimal that contents the ValorCombustible value for the VehiculoCombustible object</param>
		/// <param name="nitTerceroComplentario">string that contents the nitTerceroComplentario value for the VehiculoCombustible object</param>
		/// <param name="NombreTerceroComplementario">string that contents the NombreTerceroComplementario value for the VehiculoCombustible object</param>
		/// <param name="sw">byte that contents the sw value for the VehiculoCombustible object</param>
		/// <param name="tipo">string that contents the tipo value for the VehiculoCombustible object</param>
		/// <param name="numero">int that contents the numero value for the VehiculoCombustible object</param>
		/// <param name="strObservaciones">string that contents the strObservaciones value for the VehiculoCombustible object</param>
		/// <param name="Codigo">long that contents the Codigo value for the VehiculoCombustible object</param>
		public void Update(int? lngIdRegistro, long? tblLiquidacionRutasCombustibleCodigo, string Placa, DateTime? FechaTanqueo, decimal? GalonesReserva, decimal? GalonesTanqueo, decimal? ValorGalon, decimal? ValorCombustible, string nitTerceroComplentario, string NombreTerceroComplementario, byte sw, string tipo, int numero, string strObservaciones, long Codigo, Sinapsys.Datos.SQL datosTransaccion=null)
		{
			try 
			{
				VehiculoCombustible new_values = new VehiculoCombustible();
				new_values.lngIdRegistro = lngIdRegistro;
				new_values.tblLiquidacionRutasCombustibleCodigo = tblLiquidacionRutasCombustibleCodigo;
				new_values.Placa = Placa;
				new_values.FechaTanqueo = FechaTanqueo;
				new_values.GalonesReserva = GalonesReserva;
				new_values.GalonesTanqueo = GalonesTanqueo;
				new_values.ValorGalon = ValorGalon;
				new_values.ValorCombustible = ValorCombustible;
				new_values.nitTerceroComplentario = nitTerceroComplentario;
				new_values.NombreTerceroComplementario = NombreTerceroComplementario;
				new_values.sw = sw;
				new_values.tipo = tipo;
				new_values.numero = numero;
				new_values.strObservaciones = strObservaciones;
				VehiculoCombustibleDataProvider.Instance.Update(lngIdRegistro, tblLiquidacionRutasCombustibleCodigo, Placa, FechaTanqueo, GalonesReserva, GalonesTanqueo, ValorGalon, ValorCombustible, nitTerceroComplentario, NombreTerceroComplementario, sw, tipo, numero, strObservaciones, Codigo,"VehiculoCombustible",datosTransaccion);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Updates an VehiculoCombustible object by passing one object's instance as reference
		/// </summary>
		/// <param name="vehiculocombustible">An instance of VehiculoCombustible for reference</param>
		public void Update(VehiculoCombustible vehiculocombustible,Sinapsys.Datos.SQL datosTransaccion=null)
		{
			Update(vehiculocombustible.lngIdRegistro, vehiculocombustible.tblLiquidacionRutasCombustibleCodigo, vehiculocombustible.Placa, vehiculocombustible.FechaTanqueo, vehiculocombustible.GalonesReserva, vehiculocombustible.GalonesTanqueo, vehiculocombustible.ValorGalon, vehiculocombustible.ValorCombustible, vehiculocombustible.nitTerceroComplentario, vehiculocombustible.NombreTerceroComplementario, vehiculocombustible.sw, vehiculocombustible.tipo, vehiculocombustible.numero, vehiculocombustible.strObservaciones, vehiculocombustible.Codigo);
		}

		/// <summary>
		/// Delete  the VehiculoCombustible object by passing a object
		/// </summary>
		public void  Delete(VehiculoCombustible vehiculocombustible, Sinapsys.Datos.SQL datosTransaccion=null)
		{
			Delete(vehiculocombustible.Codigo,datosTransaccion);
		}

		/// <summary>
		/// Deletes the VehiculoCombustible object by passing one object's instance as reference
		/// </summary>
		/// <param name="vehiculocombustible">An instance of VehiculoCombustible for reference</param>
		public void Delete(long Codigo, Sinapsys.Datos.SQL datosTransaccion=null)
		{
			try 
			{
				//VehiculoCombustible old_values = VehiculoCombustibleController.Instance.Get(Codigo);
				//if(!Validate.security.CanDeleteSecurityField(VehiculoCombustibleController.Instance, (ILatinodeObject)old_values))
				//    throw new Exception("Access denied by security field, you can't delete object");

				VehiculoCombustibleDataProvider.Instance.Delete(Codigo,"VehiculoCombustible");
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Deletes the VehiculoCombustible object by passing CVS parameter as reference
		/// </summary>
		/// <param name="vehiculocombustible">An instance of VehiculoCombustible for reference</param>
		public void Delete(string CVSParameter)
		{
			string[] StrCommand=CVSParameter.Split(',');
			try 
			{
				long Codigo=long.Parse(StrCommand[0]);
				VehiculoCombustibleDataProvider.Instance.Delete(Codigo,"VehiculoCombustible");
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Gets the VehiculoCombustible object by passing the object's key fields
		/// </summary>
		/// <param name="Codigo">long that contents the Codigo value for the VehiculoCombustible object</param>
		/// <returns>One VehiculoCombustible object</returns>
		public VehiculoCombustible Get(long Codigo, bool generateUndo=false)
		{
			try 
			{
				VehiculoCombustible vehiculocombustible = null;
				DataTable dt = VehiculoCombustibleDataProvider.Instance.Get(Codigo);
				if ((dt.Rows.Count > 0))
				{
					vehiculocombustible = new VehiculoCombustible();
					DataRow dr = dt.Rows[0];
					ReadData(vehiculocombustible, dr, generateUndo);
				}


				return vehiculocombustible;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Gets all objects of VehiculoCombustible
		/// </summary>
		/// <returns>One VehiculoCombustibleList object</returns>
		public VehiculoCombustibleList GetAll(bool generateUndo=false)
		{
			try 
			{
				VehiculoCombustibleList vehiculocombustiblelist = new VehiculoCombustibleList();
				DataTable dt = VehiculoCombustibleDataProvider.Instance.GetAll();
				foreach (DataRow dr in dt.Rows)
				{
					VehiculoCombustible vehiculocombustible = new VehiculoCombustible();
					ReadData(vehiculocombustible, dr, generateUndo);
					vehiculocombustiblelist.Add(vehiculocombustible);
				}
				return vehiculocombustiblelist;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Gets all objects of VehiculoCombustible applying filter and sort criteria
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
		/// <returns>One VehiculoCombustibleList object</returns>
		public VehiculoCombustibleList GetFilter(int pagenum, int pagesize, string filter, string sort, string extablesfilter, string extablesfieldsfilter, string extablesrelationsfilter, string extablessort, string extablesfieldssort, string extablesrelationssort, bool generateUndo=false)
		{
			try 
			{
				VehiculoCombustibleList vehiculocombustiblelist = new VehiculoCombustibleList();

				DataTable dt = VehiculoCombustibleDataProvider.Instance.GetFilter(pagenum, pagesize, filter, sort, extablesfilter, extablesfieldsfilter, extablesrelationsfilter, extablessort, extablesfieldssort, extablesrelationssort);

				foreach (DataRow dr in dt.Rows)
				{
					VehiculoCombustible vehiculocombustible = new VehiculoCombustible();
					ReadData(vehiculocombustible, dr, generateUndo);
					vehiculocombustiblelist.Add(vehiculocombustible);
				}
				return vehiculocombustiblelist;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public VehiculoCombustibleList GetFilter( string filter, string sort, bool generateUndo=false)
		{
			return GetFilter(0,0, filter, sort, "","","","","","",generateUndo);
		}

		public VehiculoCombustibleList GetFilter(string filter, string sort, string extablesfilter, string extablesfieldsfilter, string extablesrelationsfilter, string extablessort, string extablesfieldssort, string extablesrelationssort, bool generateUndo=false)
		{
			return GetFilter(0,0, filter, sort, extablesfilter, extablesfieldsfilter, extablesrelationsfilter, extablessort, extablesfieldssort, extablesrelationssort,generateUndo);
		}


		/// <summary>
		/// Returns the type for one property
		/// </summary>
		/// <param name="propertyname">Property's name for return its value</param>
		/// <returns>A value for the <paramref name="propertyname"/></returns>
		public Type GetMethodType( string propertyname,VehiculoCombustible vehiculocombustible)
		{
			// Perform the search for the property's value
			switch (propertyname)
			{
				case "lngIdRegistro":
					return vehiculocombustible.lngIdRegistro.GetType();

				case "tblLiquidacionRutasCombustibleCodigo":
					return vehiculocombustible.tblLiquidacionRutasCombustibleCodigo.GetType();

				case "Placa":
					return vehiculocombustible.Placa.GetType();

				case "FechaTanqueo":
					return vehiculocombustible.FechaTanqueo.GetType();

				case "GalonesReserva":
					return vehiculocombustible.GalonesReserva.GetType();

				case "GalonesTanqueo":
					return vehiculocombustible.GalonesTanqueo.GetType();

				case "ValorGalon":
					return vehiculocombustible.ValorGalon.GetType();

				case "ValorCombustible":
					return vehiculocombustible.ValorCombustible.GetType();

				case "nitTerceroComplentario":
					return vehiculocombustible.nitTerceroComplentario.GetType();

				case "NombreTerceroComplementario":
					return vehiculocombustible.NombreTerceroComplementario.GetType();

				case "sw":
					return vehiculocombustible.sw.GetType();

				case "tipo":
					return vehiculocombustible.tipo.GetType();

				case "numero":
					return vehiculocombustible.numero.GetType();

				case "strObservaciones":
					return vehiculocombustible.strObservaciones.GetType();

				case "Codigo":
					return vehiculocombustible.Codigo.GetType();

			}

			return null;
		}
		/// <summary>
		/// update the changes in VehiculoCombustible object by passing the object
		/// </summary>
		public bool UpdateChanges(VehiculoCombustible vehiculocombustible, out string error,Sinapsys.Datos.SQL datosTransaccion=null)
		{
			if (vehiculocombustible.OldVehiculoCombustible == null)
			{
				    error = "No tiene objeto con el cual comparar";
				    return false;
			}
			string[] Fields = vehiculocombustible.FieldChanged();
			error = "";
			return LiqViajes_Bll_Data.DataProvider.UpdateFieldsbyObject(Fields, vehiculocombustible, out error,datosTransaccion);
		}
	}

	#endregion

}
