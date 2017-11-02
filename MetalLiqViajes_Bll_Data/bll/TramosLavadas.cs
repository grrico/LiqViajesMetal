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
	#region TramosLavadasController

	/// <summary>
	/// Class for convert data from database into object's data and vice versa
	/// </summary>
	public partial class TramosLavadasController//: ILatinodeController
	{
		/// <summary>
		/// Generic Constructor
		/// </summary>
		public TramosLavadasController()
		{
		}

		/// <summary>
		/// Instance accessor for this singleton
		/// </summary>
		private static TramosLavadasController MySingleObj;
		public static TramosLavadasController Instance
		{
			get
			{
				if (MySingleObj == null)
				{
					MySingleObj = new TramosLavadasController();
				}
				return MySingleObj;
			}
		}

		// Reads object's data from a DataRow
		private void ReadData(TramosLavadas tramoslavadas, DataRow dr,bool generateUndo=false)
		{
			try 
			{
				tramoslavadas.lngIdRegistroViaje = (long) dr["lngIdRegistroViaje"];
				tramoslavadas.Origen = dr.IsNull("Origen") ? null :(string) dr["Origen"];
				tramoslavadas.Destino = dr.IsNull("Destino") ? null :(string) dr["Destino"];
				tramoslavadas.Liquidado = dr.IsNull("Liquidado") ? null :(bool?) dr["Liquidado"];
				tramoslavadas.Fecha = dr.IsNull("Fecha") ? null :(DateTime?) dr["Fecha"];
				tramoslavadas.Placa = dr.IsNull("Placa") ? null :(string) dr["Placa"];
				tramoslavadas.Valor = dr.IsNull("Valor") ? null :(decimal?) dr["Valor"];
			}
			catch (Exception ex)
			{
				Utilidades.LogErrores(ex.Message + (ex.InnerException != null ? ex.InnerException.Message : ""), DataProvider.AplicacionNombre);
				throw ex;
			}
			if (generateUndo) tramoslavadas.GenerateUndo();
		}

		/// <summary>
		/// Create a new TramosLavadas object by passing a object
		/// </summary>
		public TramosLavadas Create(TramosLavadas tramoslavadas, Sinapsys.Datos.SQL datosTransaccion=null)
		{
			return Create(tramoslavadas.lngIdRegistroViaje,tramoslavadas.Origen,tramoslavadas.Destino,tramoslavadas.Liquidado,tramoslavadas.Fecha,tramoslavadas.Placa,tramoslavadas.Valor,datosTransaccion);
		}

		/// <summary>
		/// Creates a new TramosLavadas object by passing all object's fields
		/// </summary>
		/// <param name="Origen">string that contents the Origen value for the TramosLavadas object</param>
		/// <param name="Destino">string that contents the Destino value for the TramosLavadas object</param>
		/// <param name="Liquidado">bool that contents the Liquidado value for the TramosLavadas object</param>
		/// <param name="Fecha">DateTime that contents the Fecha value for the TramosLavadas object</param>
		/// <param name="Placa">string that contents the Placa value for the TramosLavadas object</param>
		/// <param name="Valor">decimal that contents the Valor value for the TramosLavadas object</param>
		/// <returns>One TramosLavadas object</returns>
		public TramosLavadas Create(long lngIdRegistroViaje, string Origen, string Destino, bool? Liquidado, DateTime? Fecha, string Placa, decimal? Valor, Sinapsys.Datos.SQL datosTransaccion=null)
		{
			try 
			{
				TramosLavadas tramoslavadas = new TramosLavadas();

				tramoslavadas.lngIdRegistroViaje = lngIdRegistroViaje;
				tramoslavadas.Origen = Origen;
				tramoslavadas.Destino = Destino;
				tramoslavadas.Liquidado = Liquidado;
				tramoslavadas.Fecha = Fecha;
				tramoslavadas.Placa = Placa;
				tramoslavadas.Valor = Valor;
				TramosLavadasDataProvider.Instance.Create(lngIdRegistroViaje, Origen, Destino, Liquidado, Fecha, Placa, Valor,"TramosLavadas");

				return tramoslavadas;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Updates an TramosLavadas object by passing all object's fields
		/// </summary>
		/// <param name="lngIdRegistroViaje">long that contents the lngIdRegistroViaje value for the TramosLavadas object</param>
		/// <param name="Origen">string that contents the Origen value for the TramosLavadas object</param>
		/// <param name="Destino">string that contents the Destino value for the TramosLavadas object</param>
		/// <param name="Liquidado">bool that contents the Liquidado value for the TramosLavadas object</param>
		/// <param name="Fecha">DateTime that contents the Fecha value for the TramosLavadas object</param>
		/// <param name="Placa">string that contents the Placa value for the TramosLavadas object</param>
		/// <param name="Valor">decimal that contents the Valor value for the TramosLavadas object</param>
		public void Update(long lngIdRegistroViaje, string Origen, string Destino, bool? Liquidado, DateTime? Fecha, string Placa, decimal? Valor, Sinapsys.Datos.SQL datosTransaccion=null)
		{
			try 
			{
				TramosLavadas new_values = new TramosLavadas();
				new_values.Origen = Origen;
				new_values.Destino = Destino;
				new_values.Liquidado = Liquidado;
				new_values.Fecha = Fecha;
				new_values.Placa = Placa;
				new_values.Valor = Valor;
				TramosLavadasDataProvider.Instance.Update(lngIdRegistroViaje, Origen, Destino, Liquidado, Fecha, Placa, Valor,"TramosLavadas",datosTransaccion);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Updates an TramosLavadas object by passing one object's instance as reference
		/// </summary>
		/// <param name="tramoslavadas">An instance of TramosLavadas for reference</param>
		public void Update(TramosLavadas tramoslavadas,Sinapsys.Datos.SQL datosTransaccion=null)
		{
			Update(tramoslavadas.lngIdRegistroViaje, tramoslavadas.Origen, tramoslavadas.Destino, tramoslavadas.Liquidado, tramoslavadas.Fecha, tramoslavadas.Placa, tramoslavadas.Valor);
		}

		/// <summary>
		/// Delete  the TramosLavadas object by passing a object
		/// </summary>
		public void  Delete(TramosLavadas tramoslavadas, Sinapsys.Datos.SQL datosTransaccion=null)
		{
			Delete(tramoslavadas.lngIdRegistroViaje,datosTransaccion);
		}

		/// <summary>
		/// Deletes the TramosLavadas object by passing one object's instance as reference
		/// </summary>
		/// <param name="tramoslavadas">An instance of TramosLavadas for reference</param>
		public void Delete(long lngIdRegistroViaje, Sinapsys.Datos.SQL datosTransaccion=null)
		{
			try 
			{
				TramosLavadasDataProvider.Instance.Delete(lngIdRegistroViaje,"TramosLavadas");
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Deletes the TramosLavadas object by passing CVS parameter as reference
		/// </summary>
		/// <param name="tramoslavadas">An instance of TramosLavadas for reference</param>
		public void Delete(string CVSParameter)
		{
			string[] StrCommand=CVSParameter.Split(',');
			try 
			{
				long lngIdRegistroViaje=long.Parse(StrCommand[0]);
				TramosLavadasDataProvider.Instance.Delete(lngIdRegistroViaje,"TramosLavadas");
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Gets the TramosLavadas object by passing the object's key fields
		/// </summary>
		/// <param name="lngIdRegistroViaje">long that contents the lngIdRegistroViaje value for the TramosLavadas object</param>
		/// <returns>One TramosLavadas object</returns>
		public TramosLavadas Get(long lngIdRegistroViaje, bool generateUndo=false)
		{
			try 
			{
				TramosLavadas tramoslavadas = null;
				DataTable dt = TramosLavadasDataProvider.Instance.Get(lngIdRegistroViaje);
				if ((dt.Rows.Count > 0))
				{
					tramoslavadas = new TramosLavadas();
					DataRow dr = dt.Rows[0];
					ReadData(tramoslavadas, dr, generateUndo);
				}


				return tramoslavadas;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Gets all objects of TramosLavadas
		/// </summary>
		/// <returns>One TramosLavadasList object</returns>
		public TramosLavadasList GetAll(bool generateUndo=false)
		{
			try 
			{
				TramosLavadasList tramoslavadaslist = new TramosLavadasList();
				DataTable dt = TramosLavadasDataProvider.Instance.GetAll();
				foreach (DataRow dr in dt.Rows)
				{
					TramosLavadas tramoslavadas = new TramosLavadas();
					ReadData(tramoslavadas, dr, generateUndo);
					tramoslavadaslist.Add(tramoslavadas);
				}
				return tramoslavadaslist;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Gets all objects of TramosLavadas applying filter and sort criteria
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
		/// <returns>One TramosLavadasList object</returns>
		public TramosLavadasList GetFilter(int pagenum, int pagesize, string filter, string sort, string extablesfilter, string extablesfieldsfilter, string extablesrelationsfilter, string extablessort, string extablesfieldssort, string extablesrelationssort, bool generateUndo=false)
		{
			try 
			{
				TramosLavadasList tramoslavadaslist = new TramosLavadasList();

				DataTable dt = TramosLavadasDataProvider.Instance.GetFilter(pagenum, pagesize, filter, sort, extablesfilter, extablesfieldsfilter, extablesrelationsfilter, extablessort, extablesfieldssort, extablesrelationssort);

				foreach (DataRow dr in dt.Rows)
				{
					TramosLavadas tramoslavadas = new TramosLavadas();
					ReadData(tramoslavadas, dr, generateUndo);
					tramoslavadaslist.Add(tramoslavadas);
				}
				return tramoslavadaslist;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public TramosLavadasList GetFilter( string filter, string sort, bool generateUndo=false)
		{
			return GetFilter(0,0, filter, sort, "","","","","","",generateUndo);
		}

		public TramosLavadasList GetFilter(string filter, string sort, string extablesfilter, string extablesfieldsfilter, string extablesrelationsfilter, string extablessort, string extablesfieldssort, string extablesrelationssort, bool generateUndo=false)
		{
			return GetFilter(0,0, filter, sort, extablesfilter, extablesfieldsfilter, extablesrelationsfilter, extablessort, extablesfieldssort, extablesrelationssort,generateUndo);
		}


		/// <summary>
		/// Returns the type for one property
		/// </summary>
		/// <param name="propertyname">Property's name for return its value</param>
		/// <returns>A value for the <paramref name="propertyname"/></returns>
		public Type GetMethodType( string propertyname,TramosLavadas tramoslavadas)
		{
			// Perform the search for the property's value
			switch (propertyname)
			{
				case "lngIdRegistroViaje":
					return tramoslavadas.lngIdRegistroViaje.GetType();

				case "Origen":
					return tramoslavadas.Origen.GetType();

				case "Destino":
					return tramoslavadas.Destino.GetType();

				case "Liquidado":
					return tramoslavadas.Liquidado.GetType();

				case "Fecha":
					return tramoslavadas.Fecha.GetType();

				case "Placa":
					return tramoslavadas.Placa.GetType();

				case "Valor":
					return tramoslavadas.Valor.GetType();

			}

			return null;
		}
		/// <summary>
		/// update the changes in TramosLavadas object by passing the object
		/// </summary>
		public bool UpdateChanges(TramosLavadas tramoslavadas, out string error,Sinapsys.Datos.SQL datosTransaccion=null)
		{
			if (tramoslavadas.OldTramosLavadas == null)
			{
				    error = "No tiene objeto con el cual comparar";
				    return false;
			}
			string[] Fields = tramoslavadas.FieldChanged();
			error = "";
			return LiqViajes_Bll_Data.DataProvider.UpdateFieldsbyObject(Fields, tramoslavadas, out error,datosTransaccion);
		}
	}

	#endregion

}
