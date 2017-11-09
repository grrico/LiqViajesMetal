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
	#region RutasSatrackTipoEventosController

	/// <summary>
	/// Class for convert data from database into object's data and vice versa
	/// </summary>
	public partial class RutasSatrackTipoEventosController//: ILatinodeController
	{
		/// <summary>
		/// Generic Constructor
		/// </summary>
		public RutasSatrackTipoEventosController()
		{
		}

		/// <summary>
		/// Instance accessor for this singleton
		/// </summary>
		private static RutasSatrackTipoEventosController MySingleObj;
		public static RutasSatrackTipoEventosController Instance
		{
			get
			{
				if (MySingleObj == null)
				{
					MySingleObj = new RutasSatrackTipoEventosController();
				}
				return MySingleObj;
			}
		}

		// Reads object's data from a DataRow
		private void ReadData(RutasSatrackTipoEventos rutassatracktipoeventos, DataRow dr,bool generateUndo=false)
		{
			try 
			{
				rutassatracktipoeventos.Codigo = (int) dr["Codigo"];
				rutassatracktipoeventos.TipoEvento = dr.IsNull("TipoEvento") ? null :(string) dr["TipoEvento"];
			}
			catch (Exception ex)
			{
				Utilidades.LogErrores(ex.Message + (ex.InnerException != null ? ex.InnerException.Message : ""), DataProvider.AplicacionNombre);
				throw ex;
			}
			if (generateUndo) rutassatracktipoeventos.GenerateUndo();
		}

		/// <summary>
		/// Create a new RutasSatrackTipoEventos object by passing a object
		/// </summary>
		public RutasSatrackTipoEventos Create(RutasSatrackTipoEventos rutassatracktipoeventos, Sinapsys.Datos.SQL datosTransaccion=null)
		{
			return Create(rutassatracktipoeventos.Codigo,rutassatracktipoeventos.TipoEvento,datosTransaccion);
		}

		/// <summary>
		/// Creates a new RutasSatrackTipoEventos object by passing all object's fields
		/// </summary>
		/// <param name="TipoEvento">string that contents the TipoEvento value for the RutasSatrackTipoEventos object</param>
		/// <returns>One RutasSatrackTipoEventos object</returns>
		public RutasSatrackTipoEventos Create(int Codigo, string TipoEvento, Sinapsys.Datos.SQL datosTransaccion=null)
		{
			try 
			{
				RutasSatrackTipoEventos rutassatracktipoeventos = new RutasSatrackTipoEventos();

				rutassatracktipoeventos.Codigo = Codigo;
				rutassatracktipoeventos.TipoEvento = TipoEvento;
				RutasSatrackTipoEventosDataProvider.Instance.Create(Codigo, TipoEvento,"RutasSatrackTipoEventos");

				return rutassatracktipoeventos;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Updates an RutasSatrackTipoEventos object by passing all object's fields
		/// </summary>
		/// <param name="Codigo">int that contents the Codigo value for the RutasSatrackTipoEventos object</param>
		/// <param name="TipoEvento">string that contents the TipoEvento value for the RutasSatrackTipoEventos object</param>
		public void Update(int Codigo, string TipoEvento, Sinapsys.Datos.SQL datosTransaccion=null)
		{
			try 
			{
				RutasSatrackTipoEventos new_values = new RutasSatrackTipoEventos();
				new_values.TipoEvento = TipoEvento;
				RutasSatrackTipoEventosDataProvider.Instance.Update(Codigo, TipoEvento,"RutasSatrackTipoEventos",datosTransaccion);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Updates an RutasSatrackTipoEventos object by passing one object's instance as reference
		/// </summary>
		/// <param name="rutassatracktipoeventos">An instance of RutasSatrackTipoEventos for reference</param>
		public void Update(RutasSatrackTipoEventos rutassatracktipoeventos,Sinapsys.Datos.SQL datosTransaccion=null)
		{
			Update(rutassatracktipoeventos.Codigo, rutassatracktipoeventos.TipoEvento);
		}

		/// <summary>
		/// Delete  the RutasSatrackTipoEventos object by passing a object
		/// </summary>
		public void  Delete(RutasSatrackTipoEventos rutassatracktipoeventos, Sinapsys.Datos.SQL datosTransaccion=null)
		{
			Delete(rutassatracktipoeventos.Codigo,datosTransaccion);
		}

		/// <summary>
		/// Deletes the RutasSatrackTipoEventos object by passing one object's instance as reference
		/// </summary>
		/// <param name="rutassatracktipoeventos">An instance of RutasSatrackTipoEventos for reference</param>
		public void Delete(int Codigo, Sinapsys.Datos.SQL datosTransaccion=null)
		{
			try 
			{
				RutasSatrackTipoEventosDataProvider.Instance.Delete(Codigo,"RutasSatrackTipoEventos");
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Deletes the RutasSatrackTipoEventos object by passing CVS parameter as reference
		/// </summary>
		/// <param name="rutassatracktipoeventos">An instance of RutasSatrackTipoEventos for reference</param>
		public void Delete(string CVSParameter)
		{
			string[] StrCommand=CVSParameter.Split(',');
			try 
			{
				int Codigo=int.Parse(StrCommand[0]);
				RutasSatrackTipoEventosDataProvider.Instance.Delete(Codigo,"RutasSatrackTipoEventos");
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Gets the RutasSatrackTipoEventos object by passing the object's key fields
		/// </summary>
		/// <param name="Codigo">int that contents the Codigo value for the RutasSatrackTipoEventos object</param>
		/// <returns>One RutasSatrackTipoEventos object</returns>
		public RutasSatrackTipoEventos Get(int Codigo, bool generateUndo=false)
		{
			try 
			{
				RutasSatrackTipoEventos rutassatracktipoeventos = null;
				DataTable dt = RutasSatrackTipoEventosDataProvider.Instance.Get(Codigo);
				if ((dt.Rows.Count > 0))
				{
					rutassatracktipoeventos = new RutasSatrackTipoEventos();
					DataRow dr = dt.Rows[0];
					ReadData(rutassatracktipoeventos, dr, generateUndo);
				}


				return rutassatracktipoeventos;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Gets all objects of RutasSatrackTipoEventos
		/// </summary>
		/// <returns>One RutasSatrackTipoEventosList object</returns>
		public RutasSatrackTipoEventosList GetAll(bool generateUndo=false)
		{
			try 
			{
				RutasSatrackTipoEventosList rutassatracktipoeventoslist = new RutasSatrackTipoEventosList();
				DataTable dt = RutasSatrackTipoEventosDataProvider.Instance.GetAll();
				foreach (DataRow dr in dt.Rows)
				{
					RutasSatrackTipoEventos rutassatracktipoeventos = new RutasSatrackTipoEventos();
					ReadData(rutassatracktipoeventos, dr, generateUndo);
					rutassatracktipoeventoslist.Add(rutassatracktipoeventos);
				}
				return rutassatracktipoeventoslist;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Gets all objects of RutasSatrackTipoEventos applying filter and sort criteria
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
		/// <returns>One RutasSatrackTipoEventosList object</returns>
		public RutasSatrackTipoEventosList GetFilter(int pagenum, int pagesize, string filter, string sort, string extablesfilter, string extablesfieldsfilter, string extablesrelationsfilter, string extablessort, string extablesfieldssort, string extablesrelationssort, bool generateUndo=false)
		{
			try 
			{
				RutasSatrackTipoEventosList rutassatracktipoeventoslist = new RutasSatrackTipoEventosList();

				DataTable dt = RutasSatrackTipoEventosDataProvider.Instance.GetFilter(pagenum, pagesize, filter, sort, extablesfilter, extablesfieldsfilter, extablesrelationsfilter, extablessort, extablesfieldssort, extablesrelationssort);

				foreach (DataRow dr in dt.Rows)
				{
					RutasSatrackTipoEventos rutassatracktipoeventos = new RutasSatrackTipoEventos();
					ReadData(rutassatracktipoeventos, dr, generateUndo);
					rutassatracktipoeventoslist.Add(rutassatracktipoeventos);
				}
				return rutassatracktipoeventoslist;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public RutasSatrackTipoEventosList GetFilter( string filter, string sort, bool generateUndo=false)
		{
			return GetFilter(0,0, filter, sort, "","","","","","",generateUndo);
		}

		public RutasSatrackTipoEventosList GetFilter(string filter, string sort, string extablesfilter, string extablesfieldsfilter, string extablesrelationsfilter, string extablessort, string extablesfieldssort, string extablesrelationssort, bool generateUndo=false)
		{
			return GetFilter(0,0, filter, sort, extablesfilter, extablesfieldsfilter, extablesrelationsfilter, extablessort, extablesfieldssort, extablesrelationssort,generateUndo);
		}


		/// <summary>
		/// Returns the type for one property
		/// </summary>
		/// <param name="propertyname">Property's name for return its value</param>
		/// <returns>A value for the <paramref name="propertyname"/></returns>
		public Type GetMethodType( string propertyname,RutasSatrackTipoEventos rutassatracktipoeventos)
		{
			// Perform the search for the property's value
			switch (propertyname)
			{
				case "Codigo":
					return rutassatracktipoeventos.Codigo.GetType();

				case "TipoEvento":
					return rutassatracktipoeventos.TipoEvento.GetType();

			}

			return null;
		}
		/// <summary>
		/// update the changes in RutasSatrackTipoEventos object by passing the object
		/// </summary>
		public bool UpdateChanges(RutasSatrackTipoEventos rutassatracktipoeventos, out string error,Sinapsys.Datos.SQL datosTransaccion=null)
		{
			if (rutassatracktipoeventos.OldRutasSatrackTipoEventos == null)
			{
				    error = "No tiene objeto con el cual comparar";
				    return false;
			}
			string[] Fields = rutassatracktipoeventos.FieldChanged();
			error = "";
			return LiqViajes_Bll_Data.DataProvider.UpdateFieldsbyObject(Fields, rutassatracktipoeventos, out error,datosTransaccion);
		}
	}

	#endregion

}
