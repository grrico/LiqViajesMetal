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
	#region RutasOrigenDestinoVehTrailerController

	/// <summary>
	/// Class for convert data from database into object's data and vice versa
	/// </summary>
	public partial class RutasOrigenDestinoVehTrailerController//: ILatinodeController
	{
		/// <summary>
		/// Generic Constructor
		/// </summary>
		public RutasOrigenDestinoVehTrailerController()
		{
		}

		/// <summary>
		/// Instance accessor for this singleton
		/// </summary>
		private static RutasOrigenDestinoVehTrailerController MySingleObj;
		public static RutasOrigenDestinoVehTrailerController Instance
		{
			get
			{
				if (MySingleObj == null)
				{
					MySingleObj = new RutasOrigenDestinoVehTrailerController();
				}
				return MySingleObj;
			}
		}

		// Reads object's data from a DataRow
		private void ReadData(RutasOrigenDestinoVehTrailer rutasorigendestinovehtrailer, DataRow dr,bool generateUndo=false)
		{
			try 
			{
				rutasorigendestinovehtrailer.Codigo = (int) dr["Codigo"];
				rutasorigendestinovehtrailer.RutasOrigenDestinoCodigo = dr.IsNull("RutasOrigenDestinoCodigo") ? null :(int?) dr["RutasOrigenDestinoCodigo"];
				rutasorigendestinovehtrailer.Origen = dr.IsNull("Origen") ? null :(string) dr["Origen"];
				rutasorigendestinovehtrailer.Destino = dr.IsNull("Destino") ? null :(string) dr["Destino"];
				rutasorigendestinovehtrailer.GrupoOrigen = dr.IsNull("GrupoOrigen") ? null :(string) dr["GrupoOrigen"];
				rutasorigendestinovehtrailer.GrupoDestino = dr.IsNull("GrupoDestino") ? null :(string) dr["GrupoDestino"];
				rutasorigendestinovehtrailer.TipoVehiculoCodigo = dr.IsNull("TipoVehiculoCodigo") ? null :(int?) dr["TipoVehiculoCodigo"];
				rutasorigendestinovehtrailer.TipoVehiculo = dr.IsNull("TipoVehiculo") ? null :(string) dr["TipoVehiculo"];
				rutasorigendestinovehtrailer.TipoTrailerCodigo = dr.IsNull("TipoTrailerCodigo") ? null :(int?) dr["TipoTrailerCodigo"];
				rutasorigendestinovehtrailer.DescripcionTipoTrailer = dr.IsNull("DescripcionTipoTrailer") ? null :(string) dr["DescripcionTipoTrailer"];
				rutasorigendestinovehtrailer.Favorita = dr.IsNull("Favorita") ? null :(bool?) dr["Favorita"];
			}
			catch (Exception ex)
			{
				Utilidades.LogErrores(ex.Message + (ex.InnerException != null ? ex.InnerException.Message : ""), DataProvider.AplicacionNombre);
				throw ex;
			}
			if (generateUndo) rutasorigendestinovehtrailer.GenerateUndo();
		}

		/// <summary>
		/// Create a new RutasOrigenDestinoVehTrailer object by passing a object
		/// </summary>
		public RutasOrigenDestinoVehTrailer Create(RutasOrigenDestinoVehTrailer rutasorigendestinovehtrailer, Sinapsys.Datos.SQL datosTransaccion=null)
		{
			return Create(rutasorigendestinovehtrailer.Codigo,rutasorigendestinovehtrailer.RutasOrigenDestinoCodigo,rutasorigendestinovehtrailer.Origen,rutasorigendestinovehtrailer.Destino,rutasorigendestinovehtrailer.GrupoOrigen,rutasorigendestinovehtrailer.GrupoDestino,rutasorigendestinovehtrailer.TipoVehiculoCodigo,rutasorigendestinovehtrailer.TipoVehiculo,rutasorigendestinovehtrailer.TipoTrailerCodigo,rutasorigendestinovehtrailer.DescripcionTipoTrailer,rutasorigendestinovehtrailer.Favorita,datosTransaccion);
		}

		/// <summary>
		/// Creates a new RutasOrigenDestinoVehTrailer object by passing all object's fields
		/// </summary>
		/// <param name="RutasOrigenDestinoCodigo">int that contents the RutasOrigenDestinoCodigo value for the RutasOrigenDestinoVehTrailer object</param>
		/// <param name="Origen">string that contents the Origen value for the RutasOrigenDestinoVehTrailer object</param>
		/// <param name="Destino">string that contents the Destino value for the RutasOrigenDestinoVehTrailer object</param>
		/// <param name="GrupoOrigen">string that contents the GrupoOrigen value for the RutasOrigenDestinoVehTrailer object</param>
		/// <param name="GrupoDestino">string that contents the GrupoDestino value for the RutasOrigenDestinoVehTrailer object</param>
		/// <param name="TipoVehiculoCodigo">int that contents the TipoVehiculoCodigo value for the RutasOrigenDestinoVehTrailer object</param>
		/// <param name="TipoVehiculo">string that contents the TipoVehiculo value for the RutasOrigenDestinoVehTrailer object</param>
		/// <param name="TipoTrailerCodigo">int that contents the TipoTrailerCodigo value for the RutasOrigenDestinoVehTrailer object</param>
		/// <param name="DescripcionTipoTrailer">string that contents the DescripcionTipoTrailer value for the RutasOrigenDestinoVehTrailer object</param>
		/// <param name="Favorita">bool that contents the Favorita value for the RutasOrigenDestinoVehTrailer object</param>
		/// <returns>One RutasOrigenDestinoVehTrailer object</returns>
		public RutasOrigenDestinoVehTrailer Create(int Codigo, int? RutasOrigenDestinoCodigo, string Origen, string Destino, string GrupoOrigen, string GrupoDestino, int? TipoVehiculoCodigo, string TipoVehiculo, int? TipoTrailerCodigo, string DescripcionTipoTrailer, bool? Favorita, Sinapsys.Datos.SQL datosTransaccion=null)
		{
			try 
			{
				RutasOrigenDestinoVehTrailer rutasorigendestinovehtrailer = new RutasOrigenDestinoVehTrailer();

				rutasorigendestinovehtrailer.Codigo = Codigo;
				rutasorigendestinovehtrailer.Codigo = Codigo;
				rutasorigendestinovehtrailer.RutasOrigenDestinoCodigo = RutasOrigenDestinoCodigo;
				rutasorigendestinovehtrailer.Origen = Origen;
				rutasorigendestinovehtrailer.Destino = Destino;
				rutasorigendestinovehtrailer.GrupoOrigen = GrupoOrigen;
				rutasorigendestinovehtrailer.GrupoDestino = GrupoDestino;
				rutasorigendestinovehtrailer.TipoVehiculoCodigo = TipoVehiculoCodigo;
				rutasorigendestinovehtrailer.TipoVehiculo = TipoVehiculo;
				rutasorigendestinovehtrailer.TipoTrailerCodigo = TipoTrailerCodigo;
				rutasorigendestinovehtrailer.DescripcionTipoTrailer = DescripcionTipoTrailer;
				rutasorigendestinovehtrailer.Favorita = Favorita;
				Codigo = RutasOrigenDestinoVehTrailerDataProvider.Instance.Create(Codigo, RutasOrigenDestinoCodigo, Origen, Destino, GrupoOrigen, GrupoDestino, TipoVehiculoCodigo, TipoVehiculo, TipoTrailerCodigo, DescripcionTipoTrailer, Favorita,"RutasOrigenDestinoVehTrailer",datosTransaccion);
				if (Codigo == 0)
					return null;

				rutasorigendestinovehtrailer.Codigo = Codigo;

				return rutasorigendestinovehtrailer;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Updates an RutasOrigenDestinoVehTrailer object by passing all object's fields
		/// </summary>
		/// <param name="Codigo">int that contents the Codigo value for the RutasOrigenDestinoVehTrailer object</param>
		/// <param name="RutasOrigenDestinoCodigo">int that contents the RutasOrigenDestinoCodigo value for the RutasOrigenDestinoVehTrailer object</param>
		/// <param name="Origen">string that contents the Origen value for the RutasOrigenDestinoVehTrailer object</param>
		/// <param name="Destino">string that contents the Destino value for the RutasOrigenDestinoVehTrailer object</param>
		/// <param name="GrupoOrigen">string that contents the GrupoOrigen value for the RutasOrigenDestinoVehTrailer object</param>
		/// <param name="GrupoDestino">string that contents the GrupoDestino value for the RutasOrigenDestinoVehTrailer object</param>
		/// <param name="TipoVehiculoCodigo">int that contents the TipoVehiculoCodigo value for the RutasOrigenDestinoVehTrailer object</param>
		/// <param name="TipoVehiculo">string that contents the TipoVehiculo value for the RutasOrigenDestinoVehTrailer object</param>
		/// <param name="TipoTrailerCodigo">int that contents the TipoTrailerCodigo value for the RutasOrigenDestinoVehTrailer object</param>
		/// <param name="DescripcionTipoTrailer">string that contents the DescripcionTipoTrailer value for the RutasOrigenDestinoVehTrailer object</param>
		/// <param name="Favorita">bool that contents the Favorita value for the RutasOrigenDestinoVehTrailer object</param>
		public void Update(int Codigo, int? RutasOrigenDestinoCodigo, string Origen, string Destino, string GrupoOrigen, string GrupoDestino, int? TipoVehiculoCodigo, string TipoVehiculo, int? TipoTrailerCodigo, string DescripcionTipoTrailer, bool? Favorita, Sinapsys.Datos.SQL datosTransaccion=null)
		{
			try 
			{
				RutasOrigenDestinoVehTrailer new_values = new RutasOrigenDestinoVehTrailer();
				new_values.RutasOrigenDestinoCodigo = RutasOrigenDestinoCodigo;
				new_values.Origen = Origen;
				new_values.Destino = Destino;
				new_values.GrupoOrigen = GrupoOrigen;
				new_values.GrupoDestino = GrupoDestino;
				new_values.TipoVehiculoCodigo = TipoVehiculoCodigo;
				new_values.TipoVehiculo = TipoVehiculo;
				new_values.TipoTrailerCodigo = TipoTrailerCodigo;
				new_values.DescripcionTipoTrailer = DescripcionTipoTrailer;
				new_values.Favorita = Favorita;
				RutasOrigenDestinoVehTrailerDataProvider.Instance.Update(Codigo, RutasOrigenDestinoCodigo, Origen, Destino, GrupoOrigen, GrupoDestino, TipoVehiculoCodigo, TipoVehiculo, TipoTrailerCodigo, DescripcionTipoTrailer, Favorita,"RutasOrigenDestinoVehTrailer",datosTransaccion);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Updates an RutasOrigenDestinoVehTrailer object by passing one object's instance as reference
		/// </summary>
		/// <param name="rutasorigendestinovehtrailer">An instance of RutasOrigenDestinoVehTrailer for reference</param>
		public void Update(RutasOrigenDestinoVehTrailer rutasorigendestinovehtrailer,Sinapsys.Datos.SQL datosTransaccion=null)
		{
			Update(rutasorigendestinovehtrailer.Codigo, rutasorigendestinovehtrailer.RutasOrigenDestinoCodigo, rutasorigendestinovehtrailer.Origen, rutasorigendestinovehtrailer.Destino, rutasorigendestinovehtrailer.GrupoOrigen, rutasorigendestinovehtrailer.GrupoDestino, rutasorigendestinovehtrailer.TipoVehiculoCodigo, rutasorigendestinovehtrailer.TipoVehiculo, rutasorigendestinovehtrailer.TipoTrailerCodigo, rutasorigendestinovehtrailer.DescripcionTipoTrailer, rutasorigendestinovehtrailer.Favorita);
		}

		/// <summary>
		/// Delete  the RutasOrigenDestinoVehTrailer object by passing a object
		/// </summary>
		public void  Delete(RutasOrigenDestinoVehTrailer rutasorigendestinovehtrailer, Sinapsys.Datos.SQL datosTransaccion=null)
		{
			Delete(rutasorigendestinovehtrailer.Codigo,datosTransaccion);
		}

		/// <summary>
		/// Deletes the RutasOrigenDestinoVehTrailer object by passing one object's instance as reference
		/// </summary>
		/// <param name="rutasorigendestinovehtrailer">An instance of RutasOrigenDestinoVehTrailer for reference</param>
		public void Delete(int Codigo, Sinapsys.Datos.SQL datosTransaccion=null)
		{
			try 
			{
				//RutasOrigenDestinoVehTrailer old_values = RutasOrigenDestinoVehTrailerController.Instance.Get(Codigo);
				//if(!Validate.security.CanDeleteSecurityField(RutasOrigenDestinoVehTrailerController.Instance, (ILatinodeObject)old_values))
				//    throw new Exception("Access denied by security field, you can't delete object");

				RutasOrigenDestinoVehTrailerDataProvider.Instance.Delete(Codigo,"RutasOrigenDestinoVehTrailer");
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Deletes the RutasOrigenDestinoVehTrailer object by passing CVS parameter as reference
		/// </summary>
		/// <param name="rutasorigendestinovehtrailer">An instance of RutasOrigenDestinoVehTrailer for reference</param>
		public void Delete(string CVSParameter)
		{
			string[] StrCommand=CVSParameter.Split(',');
			try 
			{
				int Codigo=int.Parse(StrCommand[0]);
				RutasOrigenDestinoVehTrailerDataProvider.Instance.Delete(Codigo,"RutasOrigenDestinoVehTrailer");
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Gets the RutasOrigenDestinoVehTrailer object by passing the object's key fields
		/// </summary>
		/// <param name="Codigo">int that contents the Codigo value for the RutasOrigenDestinoVehTrailer object</param>
		/// <returns>One RutasOrigenDestinoVehTrailer object</returns>
		public RutasOrigenDestinoVehTrailer Get(int Codigo, bool generateUndo=false)
		{
			try 
			{
				RutasOrigenDestinoVehTrailer rutasorigendestinovehtrailer = null;
				DataTable dt = RutasOrigenDestinoVehTrailerDataProvider.Instance.Get(Codigo);
				if ((dt.Rows.Count > 0))
				{
					rutasorigendestinovehtrailer = new RutasOrigenDestinoVehTrailer();
					DataRow dr = dt.Rows[0];
					ReadData(rutasorigendestinovehtrailer, dr, generateUndo);
				}


				return rutasorigendestinovehtrailer;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Gets all objects of RutasOrigenDestinoVehTrailer
		/// </summary>
		/// <returns>One RutasOrigenDestinoVehTrailerList object</returns>
		public RutasOrigenDestinoVehTrailerList GetAll(bool generateUndo=false)
		{
			try 
			{
				RutasOrigenDestinoVehTrailerList rutasorigendestinovehtrailerlist = new RutasOrigenDestinoVehTrailerList();
				DataTable dt = RutasOrigenDestinoVehTrailerDataProvider.Instance.GetAll();
				foreach (DataRow dr in dt.Rows)
				{
					RutasOrigenDestinoVehTrailer rutasorigendestinovehtrailer = new RutasOrigenDestinoVehTrailer();
					ReadData(rutasorigendestinovehtrailer, dr, generateUndo);
					rutasorigendestinovehtrailerlist.Add(rutasorigendestinovehtrailer);
				}
				return rutasorigendestinovehtrailerlist;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Selects all RutasOrigenDestinoVehTrailer objects by reference (Foreign Keys)
		/// </summary>
		/// <param name="RutasOrigenDestinoCodigo">int that contents the RutasOrigenDestinoCodigo value for the RutasOrigenDestinoVehTrailer object</param>
		/// <returns>One RutasOrigenDestinoVehTrailerList object</returns>
		public RutasOrigenDestinoVehTrailerList GetBy_RutasOrigenDestinoCodigo(int RutasOrigenDestinoCodigo,bool generateUndo=false)
		{
			try 
			{
				RutasOrigenDestinoVehTrailerList rutasorigendestinovehtrailerlist = new RutasOrigenDestinoVehTrailerList();

				DataTable dt = RutasOrigenDestinoVehTrailerDataProvider.Instance.GetBy_RutasOrigenDestinoCodigo(RutasOrigenDestinoCodigo);
				foreach (DataRow dr in dt.Rows)
				{
					RutasOrigenDestinoVehTrailer rutasorigendestinovehtrailer = new RutasOrigenDestinoVehTrailer();
					ReadData(rutasorigendestinovehtrailer, dr, generateUndo);
					rutasorigendestinovehtrailerlist.Add(rutasorigendestinovehtrailer);
				}
				return rutasorigendestinovehtrailerlist;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Gets all objects of RutasOrigenDestinoVehTrailer applying filter and sort criteria
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
		/// <returns>One RutasOrigenDestinoVehTrailerList object</returns>
		public RutasOrigenDestinoVehTrailerList GetFilter(int pagenum, int pagesize, string filter, string sort, string extablesfilter, string extablesfieldsfilter, string extablesrelationsfilter, string extablessort, string extablesfieldssort, string extablesrelationssort, bool generateUndo=false)
		{
			try 
			{
				RutasOrigenDestinoVehTrailerList rutasorigendestinovehtrailerlist = new RutasOrigenDestinoVehTrailerList();

				DataTable dt = RutasOrigenDestinoVehTrailerDataProvider.Instance.GetFilter(pagenum, pagesize, filter, sort, extablesfilter, extablesfieldsfilter, extablesrelationsfilter, extablessort, extablesfieldssort, extablesrelationssort);

				foreach (DataRow dr in dt.Rows)
				{
					RutasOrigenDestinoVehTrailer rutasorigendestinovehtrailer = new RutasOrigenDestinoVehTrailer();
					ReadData(rutasorigendestinovehtrailer, dr, generateUndo);
					rutasorigendestinovehtrailerlist.Add(rutasorigendestinovehtrailer);
				}
				return rutasorigendestinovehtrailerlist;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public RutasOrigenDestinoVehTrailerList GetFilter( string filter, string sort, bool generateUndo=false)
		{
			return GetFilter(0,0, filter, sort, "","","","","","",generateUndo);
		}

		public RutasOrigenDestinoVehTrailerList GetFilter(string filter, string sort, string extablesfilter, string extablesfieldsfilter, string extablesrelationsfilter, string extablessort, string extablesfieldssort, string extablesrelationssort, bool generateUndo=false)
		{
			return GetFilter(0,0, filter, sort, extablesfilter, extablesfieldsfilter, extablesrelationsfilter, extablessort, extablesfieldssort, extablesrelationssort,generateUndo);
		}


		/// <summary>
		/// Returns the type for one property
		/// </summary>
		/// <param name="propertyname">Property's name for return its value</param>
		/// <returns>A value for the <paramref name="propertyname"/></returns>
		public Type GetMethodType( string propertyname,RutasOrigenDestinoVehTrailer rutasorigendestinovehtrailer)
		{
			// Perform the search for the property's value
			switch (propertyname)
			{
				case "Codigo":
					return rutasorigendestinovehtrailer.Codigo.GetType();

				case "RutasOrigenDestinoCodigo":
					return rutasorigendestinovehtrailer.RutasOrigenDestinoCodigo.GetType();

				case "Origen":
					return rutasorigendestinovehtrailer.Origen.GetType();

				case "Destino":
					return rutasorigendestinovehtrailer.Destino.GetType();

				case "GrupoOrigen":
					return rutasorigendestinovehtrailer.GrupoOrigen.GetType();

				case "GrupoDestino":
					return rutasorigendestinovehtrailer.GrupoDestino.GetType();

				case "TipoVehiculoCodigo":
					return rutasorigendestinovehtrailer.TipoVehiculoCodigo.GetType();

				case "TipoVehiculo":
					return rutasorigendestinovehtrailer.TipoVehiculo.GetType();

				case "TipoTrailerCodigo":
					return rutasorigendestinovehtrailer.TipoTrailerCodigo.GetType();

				case "DescripcionTipoTrailer":
					return rutasorigendestinovehtrailer.DescripcionTipoTrailer.GetType();

				case "Favorita":
					return rutasorigendestinovehtrailer.Favorita.GetType();

			}

			return null;
		}
		/// <summary>
		/// update the changes in RutasOrigenDestinoVehTrailer object by passing the object
		/// </summary>
		public bool UpdateChanges(RutasOrigenDestinoVehTrailer rutasorigendestinovehtrailer, out string error,Sinapsys.Datos.SQL datosTransaccion=null)
		{
			if (rutasorigendestinovehtrailer.OldRutasOrigenDestinoVehTrailer == null)
			{
				    error = "No tiene objeto con el cual comparar";
				    return false;
			}
			string[] Fields = rutasorigendestinovehtrailer.FieldChanged();
			error = "";
			return LiqViajes_Bll_Data.DataProvider.UpdateFieldsbyObject(Fields, rutasorigendestinovehtrailer, out error,datosTransaccion);
		}
	}

	#endregion

}
