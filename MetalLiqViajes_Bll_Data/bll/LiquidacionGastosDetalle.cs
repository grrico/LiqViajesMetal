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
	#region LiquidacionGastosDetalleController

	/// <summary>
	/// Class for convert data from database into object's data and vice versa
	/// </summary>
	public partial class LiquidacionGastosDetalleController//: ILatinodeController
	{
		/// <summary>
		/// Generic Constructor
		/// </summary>
		public LiquidacionGastosDetalleController()
		{
		}

		/// <summary>
		/// Instance accessor for this singleton
		/// </summary>
		private static LiquidacionGastosDetalleController MySingleObj;
		public static LiquidacionGastosDetalleController Instance
		{
			get
			{
				if (MySingleObj == null)
				{
					MySingleObj = new LiquidacionGastosDetalleController();
				}
				return MySingleObj;
			}
		}

		// Reads object's data from a DataRow
		private void ReadData(LiquidacionGastosDetalle liquidaciongastosdetalle, DataRow dr,bool generateUndo=false)
		{
			try 
			{
				liquidaciongastosdetalle.Codigo = (long) dr["Codigo"];
				liquidaciongastosdetalle.RegistrRutaItemId = dr.IsNull("RegistrRutaItemId") ? null :(long?) dr["RegistrRutaItemId"];
				liquidaciongastosdetalle.RegistroViaje = dr.IsNull("RegistroViaje") ? null :(long?) dr["RegistroViaje"];
				liquidaciongastosdetalle.RegistroRuta = dr.IsNull("RegistroRuta") ? null :(long?) dr["RegistroRuta"];
				liquidaciongastosdetalle.RowRegistro = dr.IsNull("RowRegistro") ? null :(int?) dr["RowRegistro"];
				liquidaciongastosdetalle.Cuenta = dr.IsNull("Cuenta") ? null :(string) dr["Cuenta"];
				liquidaciongastosdetalle.NitTercero = dr.IsNull("NitTercero") ? null :(string) dr["NitTercero"];
				liquidaciongastosdetalle.FechaCrea = dr.IsNull("FechaCrea") ? null :(DateTime?) dr["FechaCrea"];
				liquidaciongastosdetalle.ValorAdicional = dr.IsNull("ValorAdicional") ? null :(decimal?) dr["ValorAdicional"];
				liquidaciongastosdetalle.Observacion = dr.IsNull("Observacion") ? null :(string) dr["Observacion"];
			}
			catch (Exception ex)
			{
				Utilidades.LogErrores(ex.Message + (ex.InnerException != null ? ex.InnerException.Message : ""), DataProvider.AplicacionNombre);
				throw ex;
			}
			if (generateUndo) liquidaciongastosdetalle.GenerateUndo();
		}

		/// <summary>
		/// Create a new LiquidacionGastosDetalle object by passing a object
		/// </summary>
		public LiquidacionGastosDetalle Create(LiquidacionGastosDetalle liquidaciongastosdetalle, Sinapsys.Datos.SQL datosTransaccion=null)
		{
			return Create(liquidaciongastosdetalle.Codigo,liquidaciongastosdetalle.RegistrRutaItemId,liquidaciongastosdetalle.RegistroViaje,liquidaciongastosdetalle.RegistroRuta,liquidaciongastosdetalle.RowRegistro,liquidaciongastosdetalle.Cuenta,liquidaciongastosdetalle.NitTercero,liquidaciongastosdetalle.FechaCrea,liquidaciongastosdetalle.ValorAdicional,liquidaciongastosdetalle.Observacion,datosTransaccion);
		}

		/// <summary>
		/// Creates a new LiquidacionGastosDetalle object by passing all object's fields
		/// </summary>
		/// <param name="RegistrRutaItemId">long that contents the RegistrRutaItemId value for the LiquidacionGastosDetalle object</param>
		/// <param name="RegistroViaje">long that contents the RegistroViaje value for the LiquidacionGastosDetalle object</param>
		/// <param name="RegistroRuta">long that contents the RegistroRuta value for the LiquidacionGastosDetalle object</param>
		/// <param name="RowRegistro">int that contents the RowRegistro value for the LiquidacionGastosDetalle object</param>
		/// <param name="Cuenta">string that contents the Cuenta value for the LiquidacionGastosDetalle object</param>
		/// <param name="NitTercero">string that contents the NitTercero value for the LiquidacionGastosDetalle object</param>
		/// <param name="FechaCrea">DateTime that contents the FechaCrea value for the LiquidacionGastosDetalle object</param>
		/// <param name="ValorAdicional">decimal that contents the ValorAdicional value for the LiquidacionGastosDetalle object</param>
		/// <param name="Observacion">string that contents the Observacion value for the LiquidacionGastosDetalle object</param>
		/// <returns>One LiquidacionGastosDetalle object</returns>
		public LiquidacionGastosDetalle Create(long Codigo, long? RegistrRutaItemId, long? RegistroViaje, long? RegistroRuta, int? RowRegistro, string Cuenta, string NitTercero, DateTime? FechaCrea, decimal? ValorAdicional, string Observacion, Sinapsys.Datos.SQL datosTransaccion=null)
		{
			try 
			{
				LiquidacionGastosDetalle liquidaciongastosdetalle = new LiquidacionGastosDetalle();

				liquidaciongastosdetalle.Codigo = Codigo;
				liquidaciongastosdetalle.Codigo = Codigo;
				liquidaciongastosdetalle.RegistrRutaItemId = RegistrRutaItemId;
				liquidaciongastosdetalle.RegistroViaje = RegistroViaje;
				liquidaciongastosdetalle.RegistroRuta = RegistroRuta;
				liquidaciongastosdetalle.RowRegistro = RowRegistro;
				liquidaciongastosdetalle.Cuenta = Cuenta;
				liquidaciongastosdetalle.NitTercero = NitTercero;
				liquidaciongastosdetalle.FechaCrea = FechaCrea;
				liquidaciongastosdetalle.ValorAdicional = ValorAdicional;
				liquidaciongastosdetalle.Observacion = Observacion;
				Codigo = LiquidacionGastosDetalleDataProvider.Instance.Create(Codigo, RegistrRutaItemId, RegistroViaje, RegistroRuta, RowRegistro, Cuenta, NitTercero, FechaCrea, ValorAdicional, Observacion,"LiquidacionGastosDetalle",datosTransaccion);
				if (Codigo == 0)
					return null;

				liquidaciongastosdetalle.Codigo = Codigo;

				return liquidaciongastosdetalle;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Updates an LiquidacionGastosDetalle object by passing all object's fields
		/// </summary>
		/// <param name="Codigo">long that contents the Codigo value for the LiquidacionGastosDetalle object</param>
		/// <param name="RegistrRutaItemId">long that contents the RegistrRutaItemId value for the LiquidacionGastosDetalle object</param>
		/// <param name="RegistroViaje">long that contents the RegistroViaje value for the LiquidacionGastosDetalle object</param>
		/// <param name="RegistroRuta">long that contents the RegistroRuta value for the LiquidacionGastosDetalle object</param>
		/// <param name="RowRegistro">int that contents the RowRegistro value for the LiquidacionGastosDetalle object</param>
		/// <param name="Cuenta">string that contents the Cuenta value for the LiquidacionGastosDetalle object</param>
		/// <param name="NitTercero">string that contents the NitTercero value for the LiquidacionGastosDetalle object</param>
		/// <param name="FechaCrea">DateTime that contents the FechaCrea value for the LiquidacionGastosDetalle object</param>
		/// <param name="ValorAdicional">decimal that contents the ValorAdicional value for the LiquidacionGastosDetalle object</param>
		/// <param name="Observacion">string that contents the Observacion value for the LiquidacionGastosDetalle object</param>
		public void Update(long Codigo, long? RegistrRutaItemId, long? RegistroViaje, long? RegistroRuta, int? RowRegistro, string Cuenta, string NitTercero, DateTime? FechaCrea, decimal? ValorAdicional, string Observacion, Sinapsys.Datos.SQL datosTransaccion=null)
		{
			try 
			{
				LiquidacionGastosDetalle new_values = new LiquidacionGastosDetalle();
				new_values.RegistrRutaItemId = RegistrRutaItemId;
				new_values.RegistroViaje = RegistroViaje;
				new_values.RegistroRuta = RegistroRuta;
				new_values.RowRegistro = RowRegistro;
				new_values.Cuenta = Cuenta;
				new_values.NitTercero = NitTercero;
				new_values.FechaCrea = FechaCrea;
				new_values.ValorAdicional = ValorAdicional;
				new_values.Observacion = Observacion;
				LiquidacionGastosDetalleDataProvider.Instance.Update(Codigo, RegistrRutaItemId, RegistroViaje, RegistroRuta, RowRegistro, Cuenta, NitTercero, FechaCrea, ValorAdicional, Observacion,"LiquidacionGastosDetalle",datosTransaccion);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Updates an LiquidacionGastosDetalle object by passing one object's instance as reference
		/// </summary>
		/// <param name="liquidaciongastosdetalle">An instance of LiquidacionGastosDetalle for reference</param>
		public void Update(LiquidacionGastosDetalle liquidaciongastosdetalle,Sinapsys.Datos.SQL datosTransaccion=null)
		{
			Update(liquidaciongastosdetalle.Codigo, liquidaciongastosdetalle.RegistrRutaItemId, liquidaciongastosdetalle.RegistroViaje, liquidaciongastosdetalle.RegistroRuta, liquidaciongastosdetalle.RowRegistro, liquidaciongastosdetalle.Cuenta, liquidaciongastosdetalle.NitTercero, liquidaciongastosdetalle.FechaCrea, liquidaciongastosdetalle.ValorAdicional, liquidaciongastosdetalle.Observacion);
		}

		/// <summary>
		/// Delete  the LiquidacionGastosDetalle object by passing a object
		/// </summary>
		public void  Delete(LiquidacionGastosDetalle liquidaciongastosdetalle, Sinapsys.Datos.SQL datosTransaccion=null)
		{
			Delete(liquidaciongastosdetalle.Codigo,datosTransaccion);
		}

		/// <summary>
		/// Deletes the LiquidacionGastosDetalle object by passing one object's instance as reference
		/// </summary>
		/// <param name="liquidaciongastosdetalle">An instance of LiquidacionGastosDetalle for reference</param>
		public void Delete(long Codigo, Sinapsys.Datos.SQL datosTransaccion=null)
		{
			try 
			{
				//LiquidacionGastosDetalle old_values = LiquidacionGastosDetalleController.Instance.Get(Codigo);
				//if(!Validate.security.CanDeleteSecurityField(LiquidacionGastosDetalleController.Instance, (ILatinodeObject)old_values))
				//    throw new Exception("Access denied by security field, you can't delete object");

				LiquidacionGastosDetalleDataProvider.Instance.Delete(Codigo,"LiquidacionGastosDetalle");
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Deletes the LiquidacionGastosDetalle object by passing CVS parameter as reference
		/// </summary>
		/// <param name="liquidaciongastosdetalle">An instance of LiquidacionGastosDetalle for reference</param>
		public void Delete(string CVSParameter)
		{
			string[] StrCommand=CVSParameter.Split(',');
			try 
			{
				long Codigo=long.Parse(StrCommand[0]);
				LiquidacionGastosDetalleDataProvider.Instance.Delete(Codigo,"LiquidacionGastosDetalle");
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Gets the LiquidacionGastosDetalle object by passing the object's key fields
		/// </summary>
		/// <param name="Codigo">long that contents the Codigo value for the LiquidacionGastosDetalle object</param>
		/// <returns>One LiquidacionGastosDetalle object</returns>
		public LiquidacionGastosDetalle Get(long Codigo, bool generateUndo=false)
		{
			try 
			{
				LiquidacionGastosDetalle liquidaciongastosdetalle = null;
				DataTable dt = LiquidacionGastosDetalleDataProvider.Instance.Get(Codigo);
				if ((dt.Rows.Count > 0))
				{
					liquidaciongastosdetalle = new LiquidacionGastosDetalle();
					DataRow dr = dt.Rows[0];
					ReadData(liquidaciongastosdetalle, dr, generateUndo);
				}


				return liquidaciongastosdetalle;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Gets all objects of LiquidacionGastosDetalle
		/// </summary>
		/// <returns>One LiquidacionGastosDetalleList object</returns>
		public LiquidacionGastosDetalleList GetAll(bool generateUndo=false)
		{
			try 
			{
				LiquidacionGastosDetalleList liquidaciongastosdetallelist = new LiquidacionGastosDetalleList();
				DataTable dt = LiquidacionGastosDetalleDataProvider.Instance.GetAll();
				foreach (DataRow dr in dt.Rows)
				{
					LiquidacionGastosDetalle liquidaciongastosdetalle = new LiquidacionGastosDetalle();
					ReadData(liquidaciongastosdetalle, dr, generateUndo);
					liquidaciongastosdetallelist.Add(liquidaciongastosdetalle);
				}
				return liquidaciongastosdetallelist;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Selects all LiquidacionGastosDetalle objects by reference (Foreign Keys)
		/// </summary>
		/// <param name="RegistrRutaItemId">long that contents the RegistrRutaItemId value for the LiquidacionGastosDetalle object</param>
		/// <param name="RegistroViaje">long that contents the RegistroViaje value for the LiquidacionGastosDetalle object</param>
		/// <param name="RegistroRuta">long that contents the RegistroRuta value for the LiquidacionGastosDetalle object</param>
		/// <param name="Cuenta">string that contents the Cuenta value for the LiquidacionGastosDetalle object</param>
		/// <param name="RowRegistro">int that contents the RowRegistro value for the LiquidacionGastosDetalle object</param>
		/// <returns>One LiquidacionGastosDetalleList object</returns>
		public LiquidacionGastosDetalleList GetBy_RegistrRutaItemId_RegistroViaje_RegistroRuta_Cuenta_RowRegistro(long RegistrRutaItemId, long RegistroViaje, long RegistroRuta, string Cuenta, int RowRegistro,bool generateUndo=false)
		{
			try 
			{
				LiquidacionGastosDetalleList liquidaciongastosdetallelist = new LiquidacionGastosDetalleList();

				DataTable dt = LiquidacionGastosDetalleDataProvider.Instance.GetBy_RegistrRutaItemId_RegistroViaje_RegistroRuta_Cuenta_RowRegistro(RegistrRutaItemId, RegistroViaje, RegistroRuta, Cuenta, RowRegistro);
				foreach (DataRow dr in dt.Rows)
				{
					LiquidacionGastosDetalle liquidaciongastosdetalle = new LiquidacionGastosDetalle();
					ReadData(liquidaciongastosdetalle, dr, generateUndo);
					liquidaciongastosdetallelist.Add(liquidaciongastosdetalle);
				}
				return liquidaciongastosdetallelist;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Gets all objects of LiquidacionGastosDetalle applying filter and sort criteria
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
		/// <returns>One LiquidacionGastosDetalleList object</returns>
		public LiquidacionGastosDetalleList GetFilter(int pagenum, int pagesize, string filter, string sort, string extablesfilter, string extablesfieldsfilter, string extablesrelationsfilter, string extablessort, string extablesfieldssort, string extablesrelationssort, bool generateUndo=false)
		{
			try 
			{
				LiquidacionGastosDetalleList liquidaciongastosdetallelist = new LiquidacionGastosDetalleList();

				DataTable dt = LiquidacionGastosDetalleDataProvider.Instance.GetFilter(pagenum, pagesize, filter, sort, extablesfilter, extablesfieldsfilter, extablesrelationsfilter, extablessort, extablesfieldssort, extablesrelationssort);

				foreach (DataRow dr in dt.Rows)
				{
					LiquidacionGastosDetalle liquidaciongastosdetalle = new LiquidacionGastosDetalle();
					ReadData(liquidaciongastosdetalle, dr, generateUndo);
					liquidaciongastosdetallelist.Add(liquidaciongastosdetalle);
				}
				return liquidaciongastosdetallelist;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public LiquidacionGastosDetalleList GetFilter( string filter, string sort, bool generateUndo=false)
		{
			return GetFilter(0,0, filter, sort, "","","","","","",generateUndo);
		}

		public LiquidacionGastosDetalleList GetFilter(string filter, string sort, string extablesfilter, string extablesfieldsfilter, string extablesrelationsfilter, string extablessort, string extablesfieldssort, string extablesrelationssort, bool generateUndo=false)
		{
			return GetFilter(0,0, filter, sort, extablesfilter, extablesfieldsfilter, extablesrelationsfilter, extablessort, extablesfieldssort, extablesrelationssort,generateUndo);
		}


		/// <summary>
		/// Returns the type for one property
		/// </summary>
		/// <param name="propertyname">Property's name for return its value</param>
		/// <returns>A value for the <paramref name="propertyname"/></returns>
		public Type GetMethodType( string propertyname,LiquidacionGastosDetalle liquidaciongastosdetalle)
		{
			// Perform the search for the property's value
			switch (propertyname)
			{
				case "Codigo":
					return liquidaciongastosdetalle.Codigo.GetType();

				case "RegistrRutaItemId":
					return liquidaciongastosdetalle.RegistrRutaItemId.GetType();

				case "RegistroViaje":
					return liquidaciongastosdetalle.RegistroViaje.GetType();

				case "RegistroRuta":
					return liquidaciongastosdetalle.RegistroRuta.GetType();

				case "RowRegistro":
					return liquidaciongastosdetalle.RowRegistro.GetType();

				case "Cuenta":
					return liquidaciongastosdetalle.Cuenta.GetType();

				case "NitTercero":
					return liquidaciongastosdetalle.NitTercero.GetType();

				case "FechaCrea":
					return liquidaciongastosdetalle.FechaCrea.GetType();

				case "ValorAdicional":
					return liquidaciongastosdetalle.ValorAdicional.GetType();

				case "Observacion":
					return liquidaciongastosdetalle.Observacion.GetType();

			}

			return null;
		}
		/// <summary>
		/// update the changes in LiquidacionGastosDetalle object by passing the object
		/// </summary>
		public bool UpdateChanges(LiquidacionGastosDetalle liquidaciongastosdetalle, out string error,Sinapsys.Datos.SQL datosTransaccion=null)
		{
			if (liquidaciongastosdetalle.OldLiquidacionGastosDetalle == null)
			{
				    error = "No tiene objeto con el cual comparar";
				    return false;
			}
			string[] Fields = liquidaciongastosdetalle.FieldChanged();
			error = "";
			return LiqViajes_Bll_Data.DataProvider.UpdateFieldsbyObject(Fields, liquidaciongastosdetalle, out error,datosTransaccion);
		}
	}

	#endregion

}
