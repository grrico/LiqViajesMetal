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
	#region RutasOrigenTipoTrailerController

	/// <summary>
	/// Class for convert data from database into object's data and vice versa
	/// </summary>
	public partial class RutasOrigenTipoTrailerController//: ILatinodeController
	{
		/// <summary>
		/// Generic Constructor
		/// </summary>
		public RutasOrigenTipoTrailerController()
		{
		}

		/// <summary>
		/// Instance accessor for this singleton
		/// </summary>
		private static RutasOrigenTipoTrailerController MySingleObj;
		public static RutasOrigenTipoTrailerController Instance
		{
			get
			{
				if (MySingleObj == null)
				{
					MySingleObj = new RutasOrigenTipoTrailerController();
				}
				return MySingleObj;
			}
		}

		// Reads object's data from a DataRow
		private void ReadData(RutasOrigenTipoTrailer rutasorigentipotrailer, DataRow dr,bool generateUndo=false)
		{
			try 
			{
				rutasorigentipotrailer.Codigo = (int) dr["Codigo"];
				rutasorigentipotrailer.RutasOrigenCodigo = dr.IsNull("RutasOrigenCodigo") ? null :(int?) dr["RutasOrigenCodigo"];
				rutasorigentipotrailer.Origen = dr.IsNull("Origen") ? null :(string) dr["Origen"];
				rutasorigentipotrailer.TipoTrailerCodigo = dr.IsNull("TipoTrailerCodigo") ? null :(int?) dr["TipoTrailerCodigo"];
				rutasorigentipotrailer.DescripcionTrailer = dr.IsNull("DescripcionTrailer") ? null :(string) dr["DescripcionTrailer"];
			}
			catch (Exception ex)
			{
				Utilidades.LogErrores(ex.Message + (ex.InnerException != null ? ex.InnerException.Message : ""), DataProvider.AplicacionNombre);
				throw ex;
			}
			if (generateUndo) rutasorigentipotrailer.GenerateUndo();
		}

		/// <summary>
		/// Create a new RutasOrigenTipoTrailer object by passing a object
		/// </summary>
		public RutasOrigenTipoTrailer Create(RutasOrigenTipoTrailer rutasorigentipotrailer, Sinapsys.Datos.SQL datosTransaccion=null)
		{
			return Create(rutasorigentipotrailer.Codigo,rutasorigentipotrailer.RutasOrigenCodigo,rutasorigentipotrailer.Origen,rutasorigentipotrailer.TipoTrailerCodigo,rutasorigentipotrailer.DescripcionTrailer,datosTransaccion);
		}

		/// <summary>
		/// Creates a new RutasOrigenTipoTrailer object by passing all object's fields
		/// </summary>
		/// <param name="RutasOrigenCodigo">int that contents the RutasOrigenCodigo value for the RutasOrigenTipoTrailer object</param>
		/// <param name="Origen">string that contents the Origen value for the RutasOrigenTipoTrailer object</param>
		/// <param name="TipoTrailerCodigo">int that contents the TipoTrailerCodigo value for the RutasOrigenTipoTrailer object</param>
		/// <param name="DescripcionTrailer">string that contents the DescripcionTrailer value for the RutasOrigenTipoTrailer object</param>
		/// <returns>One RutasOrigenTipoTrailer object</returns>
		public RutasOrigenTipoTrailer Create(int Codigo, int? RutasOrigenCodigo, string Origen, int? TipoTrailerCodigo, string DescripcionTrailer, Sinapsys.Datos.SQL datosTransaccion=null)
		{
			try 
			{
				RutasOrigenTipoTrailer rutasorigentipotrailer = new RutasOrigenTipoTrailer();

				rutasorigentipotrailer.Codigo = Codigo;
				rutasorigentipotrailer.Codigo = Codigo;
				rutasorigentipotrailer.RutasOrigenCodigo = RutasOrigenCodigo;
				rutasorigentipotrailer.Origen = Origen;
				rutasorigentipotrailer.TipoTrailerCodigo = TipoTrailerCodigo;
				rutasorigentipotrailer.DescripcionTrailer = DescripcionTrailer;
				Codigo = RutasOrigenTipoTrailerDataProvider.Instance.Create(Codigo, RutasOrigenCodigo, Origen, TipoTrailerCodigo, DescripcionTrailer,"RutasOrigenTipoTrailer",datosTransaccion);
				if (Codigo == 0)
					return null;

				rutasorigentipotrailer.Codigo = Codigo;

				return rutasorigentipotrailer;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Updates an RutasOrigenTipoTrailer object by passing all object's fields
		/// </summary>
		/// <param name="Codigo">int that contents the Codigo value for the RutasOrigenTipoTrailer object</param>
		/// <param name="RutasOrigenCodigo">int that contents the RutasOrigenCodigo value for the RutasOrigenTipoTrailer object</param>
		/// <param name="Origen">string that contents the Origen value for the RutasOrigenTipoTrailer object</param>
		/// <param name="TipoTrailerCodigo">int that contents the TipoTrailerCodigo value for the RutasOrigenTipoTrailer object</param>
		/// <param name="DescripcionTrailer">string that contents the DescripcionTrailer value for the RutasOrigenTipoTrailer object</param>
		public void Update(int Codigo, int? RutasOrigenCodigo, string Origen, int? TipoTrailerCodigo, string DescripcionTrailer, Sinapsys.Datos.SQL datosTransaccion=null)
		{
			try 
			{
				RutasOrigenTipoTrailer new_values = new RutasOrigenTipoTrailer();
				new_values.RutasOrigenCodigo = RutasOrigenCodigo;
				new_values.Origen = Origen;
				new_values.TipoTrailerCodigo = TipoTrailerCodigo;
				new_values.DescripcionTrailer = DescripcionTrailer;
				RutasOrigenTipoTrailerDataProvider.Instance.Update(Codigo, RutasOrigenCodigo, Origen, TipoTrailerCodigo, DescripcionTrailer,"RutasOrigenTipoTrailer",datosTransaccion);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Updates an RutasOrigenTipoTrailer object by passing one object's instance as reference
		/// </summary>
		/// <param name="rutasorigentipotrailer">An instance of RutasOrigenTipoTrailer for reference</param>
		public void Update(RutasOrigenTipoTrailer rutasorigentipotrailer,Sinapsys.Datos.SQL datosTransaccion=null)
		{
			Update(rutasorigentipotrailer.Codigo, rutasorigentipotrailer.RutasOrigenCodigo, rutasorigentipotrailer.Origen, rutasorigentipotrailer.TipoTrailerCodigo, rutasorigentipotrailer.DescripcionTrailer);
		}

		/// <summary>
		/// Delete  the RutasOrigenTipoTrailer object by passing a object
		/// </summary>
		public void  Delete(RutasOrigenTipoTrailer rutasorigentipotrailer, Sinapsys.Datos.SQL datosTransaccion=null)
		{
			Delete(rutasorigentipotrailer.Codigo,datosTransaccion);
		}

		/// <summary>
		/// Deletes the RutasOrigenTipoTrailer object by passing one object's instance as reference
		/// </summary>
		/// <param name="rutasorigentipotrailer">An instance of RutasOrigenTipoTrailer for reference</param>
		public void Delete(int Codigo, Sinapsys.Datos.SQL datosTransaccion=null)
		{
			try 
			{
				//RutasOrigenTipoTrailer old_values = RutasOrigenTipoTrailerController.Instance.Get(Codigo);
				//if(!Validate.security.CanDeleteSecurityField(RutasOrigenTipoTrailerController.Instance, (ILatinodeObject)old_values))
				//    throw new Exception("Access denied by security field, you can't delete object");

				RutasOrigenTipoTrailerDataProvider.Instance.Delete(Codigo,"RutasOrigenTipoTrailer");
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Deletes the RutasOrigenTipoTrailer object by passing CVS parameter as reference
		/// </summary>
		/// <param name="rutasorigentipotrailer">An instance of RutasOrigenTipoTrailer for reference</param>
		public void Delete(string CVSParameter)
		{
			string[] StrCommand=CVSParameter.Split(',');
			try 
			{
				int Codigo=int.Parse(StrCommand[0]);
				RutasOrigenTipoTrailerDataProvider.Instance.Delete(Codigo,"RutasOrigenTipoTrailer");
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Gets the RutasOrigenTipoTrailer object by passing the object's key fields
		/// </summary>
		/// <param name="Codigo">int that contents the Codigo value for the RutasOrigenTipoTrailer object</param>
		/// <returns>One RutasOrigenTipoTrailer object</returns>
		public RutasOrigenTipoTrailer Get(int Codigo, bool generateUndo=false)
		{
			try 
			{
				RutasOrigenTipoTrailer rutasorigentipotrailer = null;
				DataTable dt = RutasOrigenTipoTrailerDataProvider.Instance.Get(Codigo);
				if ((dt.Rows.Count > 0))
				{
					rutasorigentipotrailer = new RutasOrigenTipoTrailer();
					DataRow dr = dt.Rows[0];
					ReadData(rutasorigentipotrailer, dr, generateUndo);
				}


				return rutasorigentipotrailer;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Gets all objects of RutasOrigenTipoTrailer
		/// </summary>
		/// <returns>One RutasOrigenTipoTrailerList object</returns>
		public RutasOrigenTipoTrailerList GetAll(bool generateUndo=false)
		{
			try 
			{
				RutasOrigenTipoTrailerList rutasorigentipotrailerlist = new RutasOrigenTipoTrailerList();
				DataTable dt = RutasOrigenTipoTrailerDataProvider.Instance.GetAll();
				foreach (DataRow dr in dt.Rows)
				{
					RutasOrigenTipoTrailer rutasorigentipotrailer = new RutasOrigenTipoTrailer();
					ReadData(rutasorigentipotrailer, dr, generateUndo);
					rutasorigentipotrailerlist.Add(rutasorigentipotrailer);
				}
				return rutasorigentipotrailerlist;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Gets all objects of RutasOrigenTipoTrailer applying filter and sort criteria
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
		/// <returns>One RutasOrigenTipoTrailerList object</returns>
		public RutasOrigenTipoTrailerList GetFilter(int pagenum, int pagesize, string filter, string sort, string extablesfilter, string extablesfieldsfilter, string extablesrelationsfilter, string extablessort, string extablesfieldssort, string extablesrelationssort, bool generateUndo=false)
		{
			try 
			{
				RutasOrigenTipoTrailerList rutasorigentipotrailerlist = new RutasOrigenTipoTrailerList();

				DataTable dt = RutasOrigenTipoTrailerDataProvider.Instance.GetFilter(pagenum, pagesize, filter, sort, extablesfilter, extablesfieldsfilter, extablesrelationsfilter, extablessort, extablesfieldssort, extablesrelationssort);

				foreach (DataRow dr in dt.Rows)
				{
					RutasOrigenTipoTrailer rutasorigentipotrailer = new RutasOrigenTipoTrailer();
					ReadData(rutasorigentipotrailer, dr, generateUndo);
					rutasorigentipotrailerlist.Add(rutasorigentipotrailer);
				}
				return rutasorigentipotrailerlist;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public RutasOrigenTipoTrailerList GetFilter( string filter, string sort, bool generateUndo=false)
		{
			return GetFilter(0,0, filter, sort, "","","","","","",generateUndo);
		}

		public RutasOrigenTipoTrailerList GetFilter(string filter, string sort, string extablesfilter, string extablesfieldsfilter, string extablesrelationsfilter, string extablessort, string extablesfieldssort, string extablesrelationssort, bool generateUndo=false)
		{
			return GetFilter(0,0, filter, sort, extablesfilter, extablesfieldsfilter, extablesrelationsfilter, extablessort, extablesfieldssort, extablesrelationssort,generateUndo);
		}


		/// <summary>
		/// Returns the type for one property
		/// </summary>
		/// <param name="propertyname">Property's name for return its value</param>
		/// <returns>A value for the <paramref name="propertyname"/></returns>
		public Type GetMethodType( string propertyname,RutasOrigenTipoTrailer rutasorigentipotrailer)
		{
			// Perform the search for the property's value
			switch (propertyname)
			{
				case "Codigo":
					return rutasorigentipotrailer.Codigo.GetType();

				case "RutasOrigenCodigo":
					return rutasorigentipotrailer.RutasOrigenCodigo.GetType();

				case "Origen":
					return rutasorigentipotrailer.Origen.GetType();

				case "TipoTrailerCodigo":
					return rutasorigentipotrailer.TipoTrailerCodigo.GetType();

				case "DescripcionTrailer":
					return rutasorigentipotrailer.DescripcionTrailer.GetType();

			}

			return null;
		}
		/// <summary>
		/// update the changes in RutasOrigenTipoTrailer object by passing the object
		/// </summary>
		public bool UpdateChanges(RutasOrigenTipoTrailer rutasorigentipotrailer, out string error,Sinapsys.Datos.SQL datosTransaccion=null)
		{
			if (rutasorigentipotrailer.OldRutasOrigenTipoTrailer == null)
			{
				    error = "No tiene objeto con el cual comparar";
				    return false;
			}
			string[] Fields = rutasorigentipotrailer.FieldChanged();
			error = "";
			return LiqViajes_Bll_Data.DataProvider.UpdateFieldsbyObject(Fields, rutasorigentipotrailer, out error,datosTransaccion);
		}
	}

	#endregion

}
