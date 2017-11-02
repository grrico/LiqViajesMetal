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
	#region TramosGastosController

	/// <summary>
	/// Class for convert data from database into object's data and vice versa
	/// </summary>
	public partial class TramosGastosController//: ILatinodeController
	{
		/// <summary>
		/// Generic Constructor
		/// </summary>
		public TramosGastosController()
		{
		}

		/// <summary>
		/// Instance accessor for this singleton
		/// </summary>
		private static TramosGastosController MySingleObj;
		public static TramosGastosController Instance
		{
			get
			{
				if (MySingleObj == null)
				{
					MySingleObj = new TramosGastosController();
				}
				return MySingleObj;
			}
		}

		// Reads object's data from a DataRow
		private void ReadData(TramosGastos tramosgastos, DataRow dr,bool generateUndo=false)
		{
			try 
			{
				tramosgastos.Codigo = (long) dr["Codigo"];
				tramosgastos.IdRegistroViaje = (long) dr["IdRegistroViaje"];
				tramosgastos.Cuenta = dr.IsNull("Cuenta") ? null :(string) dr["Cuenta"];
				tramosgastos.DescripcionCuenta = dr.IsNull("DescripcionCuenta") ? null :(string) dr["DescripcionCuenta"];
				tramosgastos.ValorTotal = dr.IsNull("ValorTotal") ? null :(decimal?) dr["ValorTotal"];
				tramosgastos.DescripcionTercero = dr.IsNull("DescripcionTercero") ? null :(string) dr["DescripcionTercero"];
			}
			catch (Exception ex)
			{
				Utilidades.LogErrores(ex.Message + (ex.InnerException != null ? ex.InnerException.Message : ""), DataProvider.AplicacionNombre);
				throw ex;
			}
			if (generateUndo) tramosgastos.GenerateUndo();
		}

		/// <summary>
		/// Create a new TramosGastos object by passing a object
		/// </summary>
		public TramosGastos Create(TramosGastos tramosgastos, Sinapsys.Datos.SQL datosTransaccion=null)
		{
			return Create(tramosgastos.Codigo,tramosgastos.IdRegistroViaje,tramosgastos.Cuenta,tramosgastos.DescripcionCuenta,tramosgastos.ValorTotal,tramosgastos.DescripcionTercero,datosTransaccion);
		}

		/// <summary>
		/// Creates a new TramosGastos object by passing all object's fields
		/// </summary>
		/// <param name="IdRegistroViaje">long that contents the IdRegistroViaje value for the TramosGastos object</param>
		/// <param name="Cuenta">string that contents the Cuenta value for the TramosGastos object</param>
		/// <param name="DescripcionCuenta">string that contents the DescripcionCuenta value for the TramosGastos object</param>
		/// <param name="ValorTotal">decimal that contents the ValorTotal value for the TramosGastos object</param>
		/// <param name="DescripcionTercero">string that contents the DescripcionTercero value for the TramosGastos object</param>
		/// <returns>One TramosGastos object</returns>
		public TramosGastos Create(long Codigo, long IdRegistroViaje, string Cuenta, string DescripcionCuenta, decimal? ValorTotal, string DescripcionTercero, Sinapsys.Datos.SQL datosTransaccion=null)
		{
			try 
			{
				TramosGastos tramosgastos = new TramosGastos();

				tramosgastos.Codigo = Codigo;
				tramosgastos.Codigo = Codigo;
				tramosgastos.IdRegistroViaje = IdRegistroViaje;
				tramosgastos.Cuenta = Cuenta;
				tramosgastos.DescripcionCuenta = DescripcionCuenta;
				tramosgastos.ValorTotal = ValorTotal;
				tramosgastos.DescripcionTercero = DescripcionTercero;
				Codigo = TramosGastosDataProvider.Instance.Create(Codigo, IdRegistroViaje, Cuenta, DescripcionCuenta, ValorTotal, DescripcionTercero,"TramosGastos",datosTransaccion);
				if (Codigo == 0)
					return null;

				tramosgastos.Codigo = Codigo;

				return tramosgastos;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Updates an TramosGastos object by passing all object's fields
		/// </summary>
		/// <param name="Codigo">long that contents the Codigo value for the TramosGastos object</param>
		/// <param name="IdRegistroViaje">long that contents the IdRegistroViaje value for the TramosGastos object</param>
		/// <param name="Cuenta">string that contents the Cuenta value for the TramosGastos object</param>
		/// <param name="DescripcionCuenta">string that contents the DescripcionCuenta value for the TramosGastos object</param>
		/// <param name="ValorTotal">decimal that contents the ValorTotal value for the TramosGastos object</param>
		/// <param name="DescripcionTercero">string that contents the DescripcionTercero value for the TramosGastos object</param>
		public void Update(long Codigo, long IdRegistroViaje, string Cuenta, string DescripcionCuenta, decimal? ValorTotal, string DescripcionTercero, Sinapsys.Datos.SQL datosTransaccion=null)
		{
			try 
			{
				TramosGastos new_values = new TramosGastos();
				new_values.IdRegistroViaje = IdRegistroViaje;
				new_values.Cuenta = Cuenta;
				new_values.DescripcionCuenta = DescripcionCuenta;
				new_values.ValorTotal = ValorTotal;
				new_values.DescripcionTercero = DescripcionTercero;
				TramosGastosDataProvider.Instance.Update(Codigo, IdRegistroViaje, Cuenta, DescripcionCuenta, ValorTotal, DescripcionTercero,"TramosGastos",datosTransaccion);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Updates an TramosGastos object by passing one object's instance as reference
		/// </summary>
		/// <param name="tramosgastos">An instance of TramosGastos for reference</param>
		public void Update(TramosGastos tramosgastos,Sinapsys.Datos.SQL datosTransaccion=null)
		{
			Update(tramosgastos.Codigo, tramosgastos.IdRegistroViaje, tramosgastos.Cuenta, tramosgastos.DescripcionCuenta, tramosgastos.ValorTotal, tramosgastos.DescripcionTercero);
		}

		/// <summary>
		/// Delete  the TramosGastos object by passing a object
		/// </summary>
		public void  Delete(TramosGastos tramosgastos, Sinapsys.Datos.SQL datosTransaccion=null)
		{
			Delete(tramosgastos.Codigo,datosTransaccion);
		}

		/// <summary>
		/// Deletes the TramosGastos object by passing one object's instance as reference
		/// </summary>
		/// <param name="tramosgastos">An instance of TramosGastos for reference</param>
		public void Delete(long Codigo, Sinapsys.Datos.SQL datosTransaccion=null)
		{
			try 
			{
				//TramosGastos old_values = TramosGastosController.Instance.Get(Codigo);
				//if(!Validate.security.CanDeleteSecurityField(TramosGastosController.Instance, (ILatinodeObject)old_values))
				//    throw new Exception("Access denied by security field, you can't delete object");

				TramosGastosDataProvider.Instance.Delete(Codigo,"TramosGastos");
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Deletes the TramosGastos object by passing CVS parameter as reference
		/// </summary>
		/// <param name="tramosgastos">An instance of TramosGastos for reference</param>
		public void Delete(string CVSParameter)
		{
			string[] StrCommand=CVSParameter.Split(',');
			try 
			{
				long Codigo=long.Parse(StrCommand[0]);
				TramosGastosDataProvider.Instance.Delete(Codigo,"TramosGastos");
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Gets the TramosGastos object by passing the object's key fields
		/// </summary>
		/// <param name="Codigo">long that contents the Codigo value for the TramosGastos object</param>
		/// <returns>One TramosGastos object</returns>
		public TramosGastos Get(long Codigo, bool generateUndo=false)
		{
			try 
			{
				TramosGastos tramosgastos = null;
				DataTable dt = TramosGastosDataProvider.Instance.Get(Codigo);
				if ((dt.Rows.Count > 0))
				{
					tramosgastos = new TramosGastos();
					DataRow dr = dt.Rows[0];
					ReadData(tramosgastos, dr, generateUndo);
				}


				return tramosgastos;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Gets all objects of TramosGastos
		/// </summary>
		/// <returns>One TramosGastosList object</returns>
		public TramosGastosList GetAll(bool generateUndo=false)
		{
			try 
			{
				TramosGastosList tramosgastoslist = new TramosGastosList();
				DataTable dt = TramosGastosDataProvider.Instance.GetAll();
				foreach (DataRow dr in dt.Rows)
				{
					TramosGastos tramosgastos = new TramosGastos();
					ReadData(tramosgastos, dr, generateUndo);
					tramosgastoslist.Add(tramosgastos);
				}
				return tramosgastoslist;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Gets all objects of TramosGastos applying filter and sort criteria
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
		/// <returns>One TramosGastosList object</returns>
		public TramosGastosList GetFilter(int pagenum, int pagesize, string filter, string sort, string extablesfilter, string extablesfieldsfilter, string extablesrelationsfilter, string extablessort, string extablesfieldssort, string extablesrelationssort, bool generateUndo=false)
		{
			try 
			{
				TramosGastosList tramosgastoslist = new TramosGastosList();

				DataTable dt = TramosGastosDataProvider.Instance.GetFilter(pagenum, pagesize, filter, sort, extablesfilter, extablesfieldsfilter, extablesrelationsfilter, extablessort, extablesfieldssort, extablesrelationssort);

				foreach (DataRow dr in dt.Rows)
				{
					TramosGastos tramosgastos = new TramosGastos();
					ReadData(tramosgastos, dr, generateUndo);
					tramosgastoslist.Add(tramosgastos);
				}
				return tramosgastoslist;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public TramosGastosList GetFilter( string filter, string sort, bool generateUndo=false)
		{
			return GetFilter(0,0, filter, sort, "","","","","","",generateUndo);
		}

		public TramosGastosList GetFilter(string filter, string sort, string extablesfilter, string extablesfieldsfilter, string extablesrelationsfilter, string extablessort, string extablesfieldssort, string extablesrelationssort, bool generateUndo=false)
		{
			return GetFilter(0,0, filter, sort, extablesfilter, extablesfieldsfilter, extablesrelationsfilter, extablessort, extablesfieldssort, extablesrelationssort,generateUndo);
		}


		/// <summary>
		/// Returns the type for one property
		/// </summary>
		/// <param name="propertyname">Property's name for return its value</param>
		/// <returns>A value for the <paramref name="propertyname"/></returns>
		public Type GetMethodType( string propertyname,TramosGastos tramosgastos)
		{
			// Perform the search for the property's value
			switch (propertyname)
			{
				case "Codigo":
					return tramosgastos.Codigo.GetType();

				case "IdRegistroViaje":
					return tramosgastos.IdRegistroViaje.GetType();

				case "Cuenta":
					return tramosgastos.Cuenta.GetType();

				case "DescripcionCuenta":
					return tramosgastos.DescripcionCuenta.GetType();

				case "ValorTotal":
					return tramosgastos.ValorTotal.GetType();

				case "DescripcionTercero":
					return tramosgastos.DescripcionTercero.GetType();

			}

			return null;
		}
		/// <summary>
		/// update the changes in TramosGastos object by passing the object
		/// </summary>
		public bool UpdateChanges(TramosGastos tramosgastos, out string error,Sinapsys.Datos.SQL datosTransaccion=null)
		{
			if (tramosgastos.OldTramosGastos == null)
			{
				    error = "No tiene objeto con el cual comparar";
				    return false;
			}
			string[] Fields = tramosgastos.FieldChanged();
			error = "";
			return LiqViajes_Bll_Data.DataProvider.UpdateFieldsbyObject(Fields, tramosgastos, out error,datosTransaccion);
		}
	}

	#endregion

}
