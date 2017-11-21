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
	#region RutasOrigenDestinoController

	/// <summary>
	/// Class for convert data from database into object's data and vice versa
	/// </summary>
	public partial class RutasOrigenDestinoController//: ILatinodeController
	{
		/// <summary>
		/// Generic Constructor
		/// </summary>
		public RutasOrigenDestinoController()
		{
		}

		/// <summary>
		/// Instance accessor for this singleton
		/// </summary>
		private static RutasOrigenDestinoController MySingleObj;
		public static RutasOrigenDestinoController Instance
		{
			get
			{
				if (MySingleObj == null)
				{
					MySingleObj = new RutasOrigenDestinoController();
				}
				return MySingleObj;
			}
		}

		// Reads object's data from a DataRow
		private void ReadData(RutasOrigenDestino rutasorigendestino, DataRow dr,bool generateUndo=false)
		{
			try 
			{
				rutasorigendestino.Codigo = (int) dr["Codigo"];
				rutasorigendestino.RutasOrigenCodigo = dr.IsNull("RutasOrigenCodigo") ? null :(int?) dr["RutasOrigenCodigo"];
				rutasorigendestino.RutasDestinoCodigo = dr.IsNull("RutasDestinoCodigo") ? null :(int?) dr["RutasDestinoCodigo"];
				rutasorigendestino.Origen = dr.IsNull("Origen") ? null :(string) dr["Origen"];
				rutasorigendestino.Destino = dr.IsNull("Destino") ? null :(string) dr["Destino"];
				rutasorigendestino.GrupoOrigen = dr.IsNull("GrupoOrigen") ? null :(string) dr["GrupoOrigen"];
				rutasorigendestino.GrupoDestino = dr.IsNull("GrupoDestino") ? null :(string) dr["GrupoDestino"];
				rutasorigendestino.Favorita = dr.IsNull("Favorita") ? null :(bool?) dr["Favorita"];
			}
			catch (Exception ex)
			{
				Utilidades.LogErrores(ex.Message + (ex.InnerException != null ? ex.InnerException.Message : ""), DataProvider.AplicacionNombre);
				throw ex;
			}
			if (generateUndo) rutasorigendestino.GenerateUndo();
		}

		/// <summary>
		/// Create a new RutasOrigenDestino object by passing a object
		/// </summary>
		public RutasOrigenDestino Create(RutasOrigenDestino rutasorigendestino, Sinapsys.Datos.SQL datosTransaccion=null)
		{
			return Create(rutasorigendestino.Codigo,rutasorigendestino.RutasOrigenCodigo,rutasorigendestino.RutasDestinoCodigo,rutasorigendestino.Origen,rutasorigendestino.Destino,rutasorigendestino.GrupoOrigen,rutasorigendestino.GrupoDestino,rutasorigendestino.Favorita,datosTransaccion);
		}

		/// <summary>
		/// Creates a new RutasOrigenDestino object by passing all object's fields
		/// </summary>
		/// <param name="RutasOrigenCodigo">int that contents the RutasOrigenCodigo value for the RutasOrigenDestino object</param>
		/// <param name="RutasDestinoCodigo">int that contents the RutasDestinoCodigo value for the RutasOrigenDestino object</param>
		/// <param name="Origen">string that contents the Origen value for the RutasOrigenDestino object</param>
		/// <param name="Destino">string that contents the Destino value for the RutasOrigenDestino object</param>
		/// <param name="GrupoOrigen">string that contents the GrupoOrigen value for the RutasOrigenDestino object</param>
		/// <param name="GrupoDestino">string that contents the GrupoDestino value for the RutasOrigenDestino object</param>
		/// <param name="Favorita">bool that contents the Favorita value for the RutasOrigenDestino object</param>
		/// <returns>One RutasOrigenDestino object</returns>
		public RutasOrigenDestino Create(int Codigo, int? RutasOrigenCodigo, int? RutasDestinoCodigo, string Origen, string Destino, string GrupoOrigen, string GrupoDestino, bool? Favorita, Sinapsys.Datos.SQL datosTransaccion=null)
		{
			try 
			{
				RutasOrigenDestino rutasorigendestino = new RutasOrigenDestino();

				rutasorigendestino.Codigo = Codigo;
				rutasorigendestino.Codigo = Codigo;
				rutasorigendestino.RutasOrigenCodigo = RutasOrigenCodigo;
				rutasorigendestino.RutasDestinoCodigo = RutasDestinoCodigo;
				rutasorigendestino.Origen = Origen;
				rutasorigendestino.Destino = Destino;
				rutasorigendestino.GrupoOrigen = GrupoOrigen;
				rutasorigendestino.GrupoDestino = GrupoDestino;
				rutasorigendestino.Favorita = Favorita;
				Codigo = RutasOrigenDestinoDataProvider.Instance.Create(Codigo, RutasOrigenCodigo, RutasDestinoCodigo, Origen, Destino, GrupoOrigen, GrupoDestino, Favorita,"RutasOrigenDestino",datosTransaccion);
				if (Codigo == 0)
					return null;

				rutasorigendestino.Codigo = Codigo;

				return rutasorigendestino;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Updates an RutasOrigenDestino object by passing all object's fields
		/// </summary>
		/// <param name="Codigo">int that contents the Codigo value for the RutasOrigenDestino object</param>
		/// <param name="RutasOrigenCodigo">int that contents the RutasOrigenCodigo value for the RutasOrigenDestino object</param>
		/// <param name="RutasDestinoCodigo">int that contents the RutasDestinoCodigo value for the RutasOrigenDestino object</param>
		/// <param name="Origen">string that contents the Origen value for the RutasOrigenDestino object</param>
		/// <param name="Destino">string that contents the Destino value for the RutasOrigenDestino object</param>
		/// <param name="GrupoOrigen">string that contents the GrupoOrigen value for the RutasOrigenDestino object</param>
		/// <param name="GrupoDestino">string that contents the GrupoDestino value for the RutasOrigenDestino object</param>
		/// <param name="Favorita">bool that contents the Favorita value for the RutasOrigenDestino object</param>
		public void Update(int Codigo, int? RutasOrigenCodigo, int? RutasDestinoCodigo, string Origen, string Destino, string GrupoOrigen, string GrupoDestino, bool? Favorita, Sinapsys.Datos.SQL datosTransaccion=null)
		{
			try 
			{
				RutasOrigenDestino new_values = new RutasOrigenDestino();
				new_values.RutasOrigenCodigo = RutasOrigenCodigo;
				new_values.RutasDestinoCodigo = RutasDestinoCodigo;
				new_values.Origen = Origen;
				new_values.Destino = Destino;
				new_values.GrupoOrigen = GrupoOrigen;
				new_values.GrupoDestino = GrupoDestino;
				new_values.Favorita = Favorita;
				RutasOrigenDestinoDataProvider.Instance.Update(Codigo, RutasOrigenCodigo, RutasDestinoCodigo, Origen, Destino, GrupoOrigen, GrupoDestino, Favorita,"RutasOrigenDestino",datosTransaccion);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Updates an RutasOrigenDestino object by passing one object's instance as reference
		/// </summary>
		/// <param name="rutasorigendestino">An instance of RutasOrigenDestino for reference</param>
		public void Update(RutasOrigenDestino rutasorigendestino,Sinapsys.Datos.SQL datosTransaccion=null)
		{
			Update(rutasorigendestino.Codigo, rutasorigendestino.RutasOrigenCodigo, rutasorigendestino.RutasDestinoCodigo, rutasorigendestino.Origen, rutasorigendestino.Destino, rutasorigendestino.GrupoOrigen, rutasorigendestino.GrupoDestino, rutasorigendestino.Favorita);
		}

		/// <summary>
		/// Delete  the RutasOrigenDestino object by passing a object
		/// </summary>
		public void  Delete(RutasOrigenDestino rutasorigendestino, Sinapsys.Datos.SQL datosTransaccion=null)
		{
			Delete(rutasorigendestino.Codigo,datosTransaccion);
		}

		/// <summary>
		/// Deletes the RutasOrigenDestino object by passing one object's instance as reference
		/// </summary>
		/// <param name="rutasorigendestino">An instance of RutasOrigenDestino for reference</param>
		public void Delete(int Codigo, Sinapsys.Datos.SQL datosTransaccion=null)
		{
			try 
			{
				//RutasOrigenDestino old_values = RutasOrigenDestinoController.Instance.Get(Codigo);
				//if(!Validate.security.CanDeleteSecurityField(RutasOrigenDestinoController.Instance, (ILatinodeObject)old_values))
				//    throw new Exception("Access denied by security field, you can't delete object");

				RutasOrigenDestinoDataProvider.Instance.Delete(Codigo,"RutasOrigenDestino");
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Deletes the RutasOrigenDestino object by passing CVS parameter as reference
		/// </summary>
		/// <param name="rutasorigendestino">An instance of RutasOrigenDestino for reference</param>
		public void Delete(string CVSParameter)
		{
			string[] StrCommand=CVSParameter.Split(',');
			try 
			{
				int Codigo=int.Parse(StrCommand[0]);
				RutasOrigenDestinoDataProvider.Instance.Delete(Codigo,"RutasOrigenDestino");
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Gets the RutasOrigenDestino object by passing the object's key fields
		/// </summary>
		/// <param name="Codigo">int that contents the Codigo value for the RutasOrigenDestino object</param>
		/// <returns>One RutasOrigenDestino object</returns>
		public RutasOrigenDestino Get(int Codigo, bool generateUndo=false)
		{
			try 
			{
				RutasOrigenDestino rutasorigendestino = null;
				DataTable dt = RutasOrigenDestinoDataProvider.Instance.Get(Codigo);
				if ((dt.Rows.Count > 0))
				{
					rutasorigendestino = new RutasOrigenDestino();
					DataRow dr = dt.Rows[0];
					ReadData(rutasorigendestino, dr, generateUndo);
				}


				return rutasorigendestino;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Gets all objects of RutasOrigenDestino
		/// </summary>
		/// <returns>One RutasOrigenDestinoList object</returns>
		public RutasOrigenDestinoList GetAll(bool generateUndo=false)
		{
			try 
			{
				RutasOrigenDestinoList rutasorigendestinolist = new RutasOrigenDestinoList();
				DataTable dt = RutasOrigenDestinoDataProvider.Instance.GetAll();
				foreach (DataRow dr in dt.Rows)
				{
					RutasOrigenDestino rutasorigendestino = new RutasOrigenDestino();
					ReadData(rutasorigendestino, dr, generateUndo);
					rutasorigendestinolist.Add(rutasorigendestino);
				}
				return rutasorigendestinolist;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Selects all RutasOrigenDestino objects by reference (Foreign Keys)
		/// </summary>
		/// <param name="RutasDestinoCodigo">int that contents the RutasDestinoCodigo value for the RutasOrigenDestino object</param>
		/// <param name="RutasOrigenCodigo">int that contents the RutasOrigenCodigo value for the RutasOrigenDestino object</param>
		/// <returns>One RutasOrigenDestinoList object</returns>
		public RutasOrigenDestinoList GetBy_RutasDestinoCodigo_RutasOrigenCodigo(int RutasDestinoCodigo, int RutasOrigenCodigo,bool generateUndo=false)
		{
			try 
			{
				RutasOrigenDestinoList rutasorigendestinolist = new RutasOrigenDestinoList();

				DataTable dt = RutasOrigenDestinoDataProvider.Instance.GetBy_RutasDestinoCodigo_RutasOrigenCodigo(RutasDestinoCodigo, RutasOrigenCodigo);
				foreach (DataRow dr in dt.Rows)
				{
					RutasOrigenDestino rutasorigendestino = new RutasOrigenDestino();
					ReadData(rutasorigendestino, dr, generateUndo);
					rutasorigendestinolist.Add(rutasorigendestino);
				}
				return rutasorigendestinolist;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Gets all objects of RutasOrigenDestino applying filter and sort criteria
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
		/// <returns>One RutasOrigenDestinoList object</returns>
		public RutasOrigenDestinoList GetFilter(int pagenum, int pagesize, string filter, string sort, string extablesfilter, string extablesfieldsfilter, string extablesrelationsfilter, string extablessort, string extablesfieldssort, string extablesrelationssort, bool generateUndo=false)
		{
			try 
			{
				RutasOrigenDestinoList rutasorigendestinolist = new RutasOrigenDestinoList();

				DataTable dt = RutasOrigenDestinoDataProvider.Instance.GetFilter(pagenum, pagesize, filter, sort, extablesfilter, extablesfieldsfilter, extablesrelationsfilter, extablessort, extablesfieldssort, extablesrelationssort);

				foreach (DataRow dr in dt.Rows)
				{
					RutasOrigenDestino rutasorigendestino = new RutasOrigenDestino();
					ReadData(rutasorigendestino, dr, generateUndo);
					rutasorigendestinolist.Add(rutasorigendestino);
				}
				return rutasorigendestinolist;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public RutasOrigenDestinoList GetFilter( string filter, string sort, bool generateUndo=false)
		{
			return GetFilter(0,0, filter, sort, "","","","","","",generateUndo);
		}

		public RutasOrigenDestinoList GetFilter(string filter, string sort, string extablesfilter, string extablesfieldsfilter, string extablesrelationsfilter, string extablessort, string extablesfieldssort, string extablesrelationssort, bool generateUndo=false)
		{
			return GetFilter(0,0, filter, sort, extablesfilter, extablesfieldsfilter, extablesrelationsfilter, extablessort, extablesfieldssort, extablesrelationssort,generateUndo);
		}


		/// <summary>
		/// Returns the type for one property
		/// </summary>
		/// <param name="propertyname">Property's name for return its value</param>
		/// <returns>A value for the <paramref name="propertyname"/></returns>
		public Type GetMethodType( string propertyname,RutasOrigenDestino rutasorigendestino)
		{
			// Perform the search for the property's value
			switch (propertyname)
			{
				case "Codigo":
					return rutasorigendestino.Codigo.GetType();

				case "RutasOrigenCodigo":
					return rutasorigendestino.RutasOrigenCodigo.GetType();

				case "RutasDestinoCodigo":
					return rutasorigendestino.RutasDestinoCodigo.GetType();

				case "Origen":
					return rutasorigendestino.Origen.GetType();

				case "Destino":
					return rutasorigendestino.Destino.GetType();

				case "GrupoOrigen":
					return rutasorigendestino.GrupoOrigen.GetType();

				case "GrupoDestino":
					return rutasorigendestino.GrupoDestino.GetType();

				case "Favorita":
					return rutasorigendestino.Favorita.GetType();

			}

			return null;
		}
		/// <summary>
		/// update the changes in RutasOrigenDestino object by passing the object
		/// </summary>
		public bool UpdateChanges(RutasOrigenDestino rutasorigendestino, out string error,Sinapsys.Datos.SQL datosTransaccion=null)
		{
			if (rutasorigendestino.OldRutasOrigenDestino == null)
			{
				    error = "No tiene objeto con el cual comparar";
				    return false;
			}
			string[] Fields = rutasorigendestino.FieldChanged();
			error = "";
			return LiqViajes_Bll_Data.DataProvider.UpdateFieldsbyObject(Fields, rutasorigendestino, out error,datosTransaccion);
		}
	}

	#endregion

}
