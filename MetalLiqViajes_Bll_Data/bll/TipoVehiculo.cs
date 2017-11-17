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
	#region TipoVehiculoController

	/// <summary>
	/// Class for convert data from database into object's data and vice versa
	/// </summary>
	public partial class TipoVehiculoController//: ILatinodeController
	{
		/// <summary>
		/// Generic Constructor
		/// </summary>
		public TipoVehiculoController()
		{
		}

		/// <summary>
		/// Instance accessor for this singleton
		/// </summary>
		private static TipoVehiculoController MySingleObj;
		public static TipoVehiculoController Instance
		{
			get
			{
				if (MySingleObj == null)
				{
					MySingleObj = new TipoVehiculoController();
				}
				return MySingleObj;
			}
		}

		// Reads object's data from a DataRow
		private void ReadData(TipoVehiculo tipovehiculo, DataRow dr,bool generateUndo=false)
		{
			try 
			{
				tipovehiculo.Codigo = (int) dr["Codigo"];
				tipovehiculo.Descripcion = dr.IsNull("Descripcion") ? null :(string) dr["Descripcion"];
				tipovehiculo.Activo = dr.IsNull("Activo") ? null :(bool?) dr["Activo"];
			}
			catch (Exception ex)
			{
				Utilidades.LogErrores(ex.Message + (ex.InnerException != null ? ex.InnerException.Message : ""), DataProvider.AplicacionNombre);
				throw ex;
			}
			if (generateUndo) tipovehiculo.GenerateUndo();
		}

		/// <summary>
		/// Create a new TipoVehiculo object by passing a object
		/// </summary>
		public TipoVehiculo Create(TipoVehiculo tipovehiculo, Sinapsys.Datos.SQL datosTransaccion=null)
		{
			return Create(tipovehiculo.Codigo,tipovehiculo.Descripcion,tipovehiculo.Activo,datosTransaccion);
		}

		/// <summary>
		/// Creates a new TipoVehiculo object by passing all object's fields
		/// </summary>
		/// <param name="Descripcion">string that contents the Descripcion value for the TipoVehiculo object</param>
		/// <param name="Activo">bool that contents the Activo value for the TipoVehiculo object</param>
		/// <returns>One TipoVehiculo object</returns>
		public TipoVehiculo Create(int Codigo, string Descripcion, bool? Activo, Sinapsys.Datos.SQL datosTransaccion=null)
		{
			try 
			{
				TipoVehiculo tipovehiculo = new TipoVehiculo();

				tipovehiculo.Codigo = Codigo;
				tipovehiculo.Descripcion = Descripcion;
				tipovehiculo.Activo = Activo;
				TipoVehiculoDataProvider.Instance.Create(Codigo, Descripcion, Activo,"TipoVehiculo");

				return tipovehiculo;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Updates an TipoVehiculo object by passing all object's fields
		/// </summary>
		/// <param name="Codigo">int that contents the Codigo value for the TipoVehiculo object</param>
		/// <param name="Descripcion">string that contents the Descripcion value for the TipoVehiculo object</param>
		/// <param name="Activo">bool that contents the Activo value for the TipoVehiculo object</param>
		public void Update(int Codigo, string Descripcion, bool? Activo, Sinapsys.Datos.SQL datosTransaccion=null)
		{
			try 
			{
				TipoVehiculo new_values = new TipoVehiculo();
				new_values.Descripcion = Descripcion;
				new_values.Activo = Activo;
				TipoVehiculoDataProvider.Instance.Update(Codigo, Descripcion, Activo,"TipoVehiculo",datosTransaccion);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Updates an TipoVehiculo object by passing one object's instance as reference
		/// </summary>
		/// <param name="tipovehiculo">An instance of TipoVehiculo for reference</param>
		public void Update(TipoVehiculo tipovehiculo,Sinapsys.Datos.SQL datosTransaccion=null)
		{
			Update(tipovehiculo.Codigo, tipovehiculo.Descripcion, tipovehiculo.Activo);
		}

		/// <summary>
		/// Delete  the TipoVehiculo object by passing a object
		/// </summary>
		public void  Delete(TipoVehiculo tipovehiculo, Sinapsys.Datos.SQL datosTransaccion=null)
		{
			Delete(tipovehiculo.Codigo,datosTransaccion);
		}

		/// <summary>
		/// Deletes the TipoVehiculo object by passing one object's instance as reference
		/// </summary>
		/// <param name="tipovehiculo">An instance of TipoVehiculo for reference</param>
		public void Delete(int Codigo, Sinapsys.Datos.SQL datosTransaccion=null)
		{
			try 
			{
				TipoVehiculoDataProvider.Instance.Delete(Codigo,"TipoVehiculo");
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Deletes the TipoVehiculo object by passing CVS parameter as reference
		/// </summary>
		/// <param name="tipovehiculo">An instance of TipoVehiculo for reference</param>
		public void Delete(string CVSParameter)
		{
			string[] StrCommand=CVSParameter.Split(',');
			try 
			{
				int Codigo=int.Parse(StrCommand[0]);
				TipoVehiculoDataProvider.Instance.Delete(Codigo,"TipoVehiculo");
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Gets the TipoVehiculo object by passing the object's key fields
		/// </summary>
		/// <param name="Codigo">int that contents the Codigo value for the TipoVehiculo object</param>
		/// <returns>One TipoVehiculo object</returns>
		public TipoVehiculo Get(int Codigo, bool generateUndo=false)
		{
			try 
			{
				TipoVehiculo tipovehiculo = null;
				tipovehiculo= MasterTables.TipoVehiculo.Where(r => r.Codigo== Codigo).FirstOrDefault();
				if (tipovehiculo== null)
				{
					MasterTables.Reset("TipoVehiculo");
					tipovehiculo= MasterTables.TipoVehiculo.Where(r => r.Codigo== Codigo).FirstOrDefault();
				}
				if (generateUndo) tipovehiculo.GenerateUndo();

				return tipovehiculo;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Gets all objects of TipoVehiculo
		/// </summary>
		/// <returns>One TipoVehiculoList object</returns>
		public TipoVehiculoList GetAll(bool generateUndo=false)
		{
			try 
			{
				TipoVehiculoList tipovehiculolist = new TipoVehiculoList();
				DataTable dt = TipoVehiculoDataProvider.Instance.GetAll();
				foreach (DataRow dr in dt.Rows)
				{
					TipoVehiculo tipovehiculo = new TipoVehiculo();
					ReadData(tipovehiculo, dr, generateUndo);
					tipovehiculolist.Add(tipovehiculo);
				}
				return tipovehiculolist;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Gets all objects of TipoVehiculo applying filter and sort criteria
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
		/// <returns>One TipoVehiculoList object</returns>
		public TipoVehiculoList GetFilter(int pagenum, int pagesize, string filter, string sort, string extablesfilter, string extablesfieldsfilter, string extablesrelationsfilter, string extablessort, string extablesfieldssort, string extablesrelationssort, bool generateUndo=false)
		{
			try 
			{
				TipoVehiculoList tipovehiculolist = new TipoVehiculoList();

				DataTable dt = TipoVehiculoDataProvider.Instance.GetFilter(pagenum, pagesize, filter, sort, extablesfilter, extablesfieldsfilter, extablesrelationsfilter, extablessort, extablesfieldssort, extablesrelationssort);

				foreach (DataRow dr in dt.Rows)
				{
					TipoVehiculo tipovehiculo = new TipoVehiculo();
					ReadData(tipovehiculo, dr, generateUndo);
					tipovehiculolist.Add(tipovehiculo);
				}
				return tipovehiculolist;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public TipoVehiculoList GetFilter( string filter, string sort, bool generateUndo=false)
		{
			return GetFilter(0,0, filter, sort, "","","","","","",generateUndo);
		}

		public TipoVehiculoList GetFilter(string filter, string sort, string extablesfilter, string extablesfieldsfilter, string extablesrelationsfilter, string extablessort, string extablesfieldssort, string extablesrelationssort, bool generateUndo=false)
		{
			return GetFilter(0,0, filter, sort, extablesfilter, extablesfieldsfilter, extablesrelationsfilter, extablessort, extablesfieldssort, extablesrelationssort,generateUndo);
		}


		/// <summary>
		/// Returns the type for one property
		/// </summary>
		/// <param name="propertyname">Property's name for return its value</param>
		/// <returns>A value for the <paramref name="propertyname"/></returns>
		public Type GetMethodType( string propertyname,TipoVehiculo tipovehiculo)
		{
			// Perform the search for the property's value
			switch (propertyname)
			{
				case "Codigo":
					return tipovehiculo.Codigo.GetType();

				case "Descripcion":
					return tipovehiculo.Descripcion.GetType();

				case "Activo":
					return tipovehiculo.Activo.GetType();

			}

			return null;
		}
		/// <summary>
		/// update the changes in TipoVehiculo object by passing the object
		/// </summary>
		public bool UpdateChanges(TipoVehiculo tipovehiculo, out string error,Sinapsys.Datos.SQL datosTransaccion=null)
		{
			if (tipovehiculo.OldTipoVehiculo == null)
			{
				    error = "No tiene objeto con el cual comparar";
				    return false;
			}
			string[] Fields = tipovehiculo.FieldChanged();
			error = "";
			return LiqViajes_Bll_Data.DataProvider.UpdateFieldsbyObject(Fields, tipovehiculo, out error,datosTransaccion);
		}
	}

	#endregion

}
