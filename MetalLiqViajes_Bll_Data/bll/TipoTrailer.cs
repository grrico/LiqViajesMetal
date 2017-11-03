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
	#region TipoTrailerController

	/// <summary>
	/// Class for convert data from database into object's data and vice versa
	/// </summary>
	public partial class TipoTrailerController//: ILatinodeController
	{
		/// <summary>
		/// Generic Constructor
		/// </summary>
		public TipoTrailerController()
		{
		}

		/// <summary>
		/// Instance accessor for this singleton
		/// </summary>
		private static TipoTrailerController MySingleObj;
		public static TipoTrailerController Instance
		{
			get
			{
				if (MySingleObj == null)
				{
					MySingleObj = new TipoTrailerController();
				}
				return MySingleObj;
			}
		}

		// Reads object's data from a DataRow
		private void ReadData(TipoTrailer tipotrailer, DataRow dr,bool generateUndo=false)
		{
			try 
			{
				tipotrailer.Trailer = dr.IsNull("Trailer") ? null :(string) dr["Trailer"];
				tipotrailer.Descripcion = dr.IsNull("Descripcion") ? null :(string) dr["Descripcion"];
				tipotrailer.Codigo = (int) dr["Codigo"];
			}
			catch (Exception ex)
			{
				Utilidades.LogErrores(ex.Message + (ex.InnerException != null ? ex.InnerException.Message : ""), DataProvider.AplicacionNombre);
				throw ex;
			}
			if (generateUndo) tipotrailer.GenerateUndo();
		}

		/// <summary>
		/// Create a new TipoTrailer object by passing a object
		/// </summary>
		public TipoTrailer Create(TipoTrailer tipotrailer, Sinapsys.Datos.SQL datosTransaccion=null)
		{
			return Create(tipotrailer.Codigo,tipotrailer.Trailer,tipotrailer.Descripcion,datosTransaccion);
		}

		/// <summary>
		/// Creates a new TipoTrailer object by passing all object's fields
		/// </summary>
		/// <param name="Trailer">string that contents the Trailer value for the TipoTrailer object</param>
		/// <param name="Descripcion">string that contents the Descripcion value for the TipoTrailer object</param>
		/// <returns>One TipoTrailer object</returns>
		public TipoTrailer Create(int Codigo, string Trailer, string Descripcion, Sinapsys.Datos.SQL datosTransaccion=null)
		{
			try 
			{
				TipoTrailer tipotrailer = new TipoTrailer();

				tipotrailer.Codigo = Codigo;
				tipotrailer.Trailer = Trailer;
				tipotrailer.Descripcion = Descripcion;
				TipoTrailerDataProvider.Instance.Create(Codigo, Trailer, Descripcion,"TipoTrailer");

				return tipotrailer;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Updates an TipoTrailer object by passing all object's fields
		/// </summary>
		/// <param name="Trailer">string that contents the Trailer value for the TipoTrailer object</param>
		/// <param name="Descripcion">string that contents the Descripcion value for the TipoTrailer object</param>
		/// <param name="Codigo">int that contents the Codigo value for the TipoTrailer object</param>
		public void Update(string Trailer, string Descripcion, int Codigo, Sinapsys.Datos.SQL datosTransaccion=null)
		{
			try 
			{
				TipoTrailer new_values = new TipoTrailer();
				new_values.Trailer = Trailer;
				new_values.Descripcion = Descripcion;
				TipoTrailerDataProvider.Instance.Update(Trailer, Descripcion, Codigo,"TipoTrailer",datosTransaccion);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Updates an TipoTrailer object by passing one object's instance as reference
		/// </summary>
		/// <param name="tipotrailer">An instance of TipoTrailer for reference</param>
		public void Update(TipoTrailer tipotrailer,Sinapsys.Datos.SQL datosTransaccion=null)
		{
			Update(tipotrailer.Trailer, tipotrailer.Descripcion, tipotrailer.Codigo);
		}

		/// <summary>
		/// Delete  the TipoTrailer object by passing a object
		/// </summary>
		public void  Delete(TipoTrailer tipotrailer, Sinapsys.Datos.SQL datosTransaccion=null)
		{
			Delete(tipotrailer.Codigo,datosTransaccion);
		}

		/// <summary>
		/// Deletes the TipoTrailer object by passing one object's instance as reference
		/// </summary>
		/// <param name="tipotrailer">An instance of TipoTrailer for reference</param>
		public void Delete(int Codigo, Sinapsys.Datos.SQL datosTransaccion=null)
		{
			try 
			{
				TipoTrailerDataProvider.Instance.Delete(Codigo,"TipoTrailer");
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Deletes the TipoTrailer object by passing CVS parameter as reference
		/// </summary>
		/// <param name="tipotrailer">An instance of TipoTrailer for reference</param>
		public void Delete(string CVSParameter)
		{
			string[] StrCommand=CVSParameter.Split(',');
			try 
			{
				int Codigo=int.Parse(StrCommand[0]);
				TipoTrailerDataProvider.Instance.Delete(Codigo,"TipoTrailer");
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Gets the TipoTrailer object by passing the object's key fields
		/// </summary>
		/// <param name="Codigo">int that contents the Codigo value for the TipoTrailer object</param>
		/// <returns>One TipoTrailer object</returns>
		public TipoTrailer Get(int Codigo, bool generateUndo=false)
		{
			try 
			{
				TipoTrailer tipotrailer = null;
				tipotrailer= MasterTables.TipoTrailer.Where(r => r.Codigo== Codigo).FirstOrDefault();
				if (tipotrailer== null)
				{
					MasterTables.Reset("TipoTrailer");
					tipotrailer= MasterTables.TipoTrailer.Where(r => r.Codigo== Codigo).FirstOrDefault();
				}
				if (generateUndo) tipotrailer.GenerateUndo();

				return tipotrailer;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Gets all objects of TipoTrailer
		/// </summary>
		/// <returns>One TipoTrailerList object</returns>
		public TipoTrailerList GetAll(bool generateUndo=false)
		{
			try 
			{
				TipoTrailerList tipotrailerlist = new TipoTrailerList();
				DataTable dt = TipoTrailerDataProvider.Instance.GetAll();
				foreach (DataRow dr in dt.Rows)
				{
					TipoTrailer tipotrailer = new TipoTrailer();
					ReadData(tipotrailer, dr, generateUndo);
					tipotrailerlist.Add(tipotrailer);
				}
				return tipotrailerlist;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Gets all objects of TipoTrailer applying filter and sort criteria
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
		/// <returns>One TipoTrailerList object</returns>
		public TipoTrailerList GetFilter(int pagenum, int pagesize, string filter, string sort, string extablesfilter, string extablesfieldsfilter, string extablesrelationsfilter, string extablessort, string extablesfieldssort, string extablesrelationssort, bool generateUndo=false)
		{
			try 
			{
				TipoTrailerList tipotrailerlist = new TipoTrailerList();

				DataTable dt = TipoTrailerDataProvider.Instance.GetFilter(pagenum, pagesize, filter, sort, extablesfilter, extablesfieldsfilter, extablesrelationsfilter, extablessort, extablesfieldssort, extablesrelationssort);

				foreach (DataRow dr in dt.Rows)
				{
					TipoTrailer tipotrailer = new TipoTrailer();
					ReadData(tipotrailer, dr, generateUndo);
					tipotrailerlist.Add(tipotrailer);
				}
				return tipotrailerlist;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public TipoTrailerList GetFilter( string filter, string sort, bool generateUndo=false)
		{
			return GetFilter(0,0, filter, sort, "","","","","","",generateUndo);
		}

		public TipoTrailerList GetFilter(string filter, string sort, string extablesfilter, string extablesfieldsfilter, string extablesrelationsfilter, string extablessort, string extablesfieldssort, string extablesrelationssort, bool generateUndo=false)
		{
			return GetFilter(0,0, filter, sort, extablesfilter, extablesfieldsfilter, extablesrelationsfilter, extablessort, extablesfieldssort, extablesrelationssort,generateUndo);
		}


		/// <summary>
		/// Returns the type for one property
		/// </summary>
		/// <param name="propertyname">Property's name for return its value</param>
		/// <returns>A value for the <paramref name="propertyname"/></returns>
		public Type GetMethodType( string propertyname,TipoTrailer tipotrailer)
		{
			// Perform the search for the property's value
			switch (propertyname)
			{
				case "Trailer":
					return tipotrailer.Trailer.GetType();

				case "Descripcion":
					return tipotrailer.Descripcion.GetType();

				case "Codigo":
					return tipotrailer.Codigo.GetType();

			}

			return null;
		}
		/// <summary>
		/// update the changes in TipoTrailer object by passing the object
		/// </summary>
		public bool UpdateChanges(TipoTrailer tipotrailer, out string error,Sinapsys.Datos.SQL datosTransaccion=null)
		{
			if (tipotrailer.OldTipoTrailer == null)
			{
				    error = "No tiene objeto con el cual comparar";
				    return false;
			}
			string[] Fields = tipotrailer.FieldChanged();
			error = "";
			return LiqViajes_Bll_Data.DataProvider.UpdateFieldsbyObject(Fields, tipotrailer, out error,datosTransaccion);
		}
	}

	#endregion

}
