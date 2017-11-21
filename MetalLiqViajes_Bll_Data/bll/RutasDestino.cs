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
	#region RutasDestinoController

	/// <summary>
	/// Class for convert data from database into object's data and vice versa
	/// </summary>
	public partial class RutasDestinoController//: ILatinodeController
	{
		/// <summary>
		/// Generic Constructor
		/// </summary>
		public RutasDestinoController()
		{
		}

		/// <summary>
		/// Instance accessor for this singleton
		/// </summary>
		private static RutasDestinoController MySingleObj;
		public static RutasDestinoController Instance
		{
			get
			{
				if (MySingleObj == null)
				{
					MySingleObj = new RutasDestinoController();
				}
				return MySingleObj;
			}
		}

		// Reads object's data from a DataRow
		private void ReadData(RutasDestino rutasdestino, DataRow dr,bool generateUndo=false)
		{
			try 
			{
				rutasdestino.Codigo = (int) dr["Codigo"];
				rutasdestino.RutasOrigenCodigo = (int) dr["RutasOrigenCodigo"];
				rutasdestino.Origen = dr.IsNull("Origen") ? null :(string) dr["Origen"];
				rutasdestino.Destino = dr.IsNull("Destino") ? null :(string) dr["Destino"];
				rutasdestino.Favorita = dr.IsNull("Favorita") ? null :(bool?) dr["Favorita"];
			}
			catch (Exception ex)
			{
				Utilidades.LogErrores(ex.Message + (ex.InnerException != null ? ex.InnerException.Message : ""), DataProvider.AplicacionNombre);
				throw ex;
			}
			if (generateUndo) rutasdestino.GenerateUndo();
		}

		/// <summary>
		/// Create a new RutasDestino object by passing a object
		/// </summary>
		public RutasDestino Create(RutasDestino rutasdestino, Sinapsys.Datos.SQL datosTransaccion=null)
		{
			return Create(rutasdestino.Codigo,rutasdestino.RutasOrigenCodigo,rutasdestino.Origen,rutasdestino.Destino,rutasdestino.Favorita,datosTransaccion);
		}

		/// <summary>
		/// Creates a new RutasDestino object by passing all object's fields
		/// </summary>
		/// <param name="Origen">string that contents the Origen value for the RutasDestino object</param>
		/// <param name="Destino">string that contents the Destino value for the RutasDestino object</param>
		/// <param name="Favorita">bool that contents the Favorita value for the RutasDestino object</param>
		/// <returns>One RutasDestino object</returns>
		public RutasDestino Create(int Codigo, int RutasOrigenCodigo, string Origen, string Destino, bool? Favorita, Sinapsys.Datos.SQL datosTransaccion=null)
		{
			try 
			{
				RutasDestino rutasdestino = new RutasDestino();

				rutasdestino.Codigo = Codigo;
				rutasdestino.Codigo = Codigo;
				rutasdestino.RutasOrigenCodigo = RutasOrigenCodigo;
				rutasdestino.Origen = Origen;
				rutasdestino.Destino = Destino;
				rutasdestino.Favorita = Favorita;
				Codigo = RutasDestinoDataProvider.Instance.Create(Codigo, RutasOrigenCodigo, Origen, Destino, Favorita,"RutasDestino",datosTransaccion);
				if (Codigo == 0)
					return null;

				rutasdestino.Codigo = Codigo;

				return rutasdestino;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Updates an RutasDestino object by passing all object's fields
		/// </summary>
		/// <param name="Codigo">int that contents the Codigo value for the RutasDestino object</param>
		/// <param name="RutasOrigenCodigo">int that contents the RutasOrigenCodigo value for the RutasDestino object</param>
		/// <param name="Origen">string that contents the Origen value for the RutasDestino object</param>
		/// <param name="Destino">string that contents the Destino value for the RutasDestino object</param>
		/// <param name="Favorita">bool that contents the Favorita value for the RutasDestino object</param>
		public void Update(int Codigo, int RutasOrigenCodigo, string Origen, string Destino, bool? Favorita, Sinapsys.Datos.SQL datosTransaccion=null)
		{
			try 
			{
				RutasDestino new_values = new RutasDestino();
				new_values.Origen = Origen;
				new_values.Destino = Destino;
				new_values.Favorita = Favorita;
				RutasDestinoDataProvider.Instance.Update(Codigo, RutasOrigenCodigo, Origen, Destino, Favorita,"RutasDestino",datosTransaccion);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Updates an RutasDestino object by passing one object's instance as reference
		/// </summary>
		/// <param name="rutasdestino">An instance of RutasDestino for reference</param>
		public void Update(RutasDestino rutasdestino,Sinapsys.Datos.SQL datosTransaccion=null)
		{
			Update(rutasdestino.Codigo, rutasdestino.RutasOrigenCodigo, rutasdestino.Origen, rutasdestino.Destino, rutasdestino.Favorita);
		}

		/// <summary>
		/// Delete  the RutasDestino object by passing a object
		/// </summary>
		public void  Delete(RutasDestino rutasdestino, Sinapsys.Datos.SQL datosTransaccion=null)
		{
			Delete(rutasdestino.Codigo, rutasdestino.RutasOrigenCodigo,datosTransaccion);
		}

		/// <summary>
		/// Deletes the RutasDestino object by passing one object's instance as reference
		/// </summary>
		/// <param name="rutasdestino">An instance of RutasDestino for reference</param>
		public void Delete(int Codigo, int RutasOrigenCodigo, Sinapsys.Datos.SQL datosTransaccion=null)
		{
			try 
			{
				//RutasDestino old_values = RutasDestinoController.Instance.Get(Codigo);
				//if(!Validate.security.CanDeleteSecurityField(RutasDestinoController.Instance, (ILatinodeObject)old_values))
				//    throw new Exception("Access denied by security field, you can't delete object");

				RutasDestinoDataProvider.Instance.Delete(Codigo, RutasOrigenCodigo,"RutasDestino");
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Deletes the RutasDestino object by passing CVS parameter as reference
		/// </summary>
		/// <param name="rutasdestino">An instance of RutasDestino for reference</param>
		public void Delete(string CVSParameter)
		{
			string[] StrCommand=CVSParameter.Split(',');
			try 
			{
				int Codigo=int.Parse(StrCommand[0]);
				int RutasOrigenCodigo=int.Parse(StrCommand[1]);
				RutasDestinoDataProvider.Instance.Delete(Codigo, RutasOrigenCodigo,"RutasDestino");
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Gets the RutasDestino object by passing the object's key fields
		/// </summary>
		/// <param name="Codigo">int that contents the Codigo value for the RutasDestino object</param>
		/// <param name="RutasOrigenCodigo">int that contents the RutasOrigenCodigo value for the RutasDestino object</param>
		/// <returns>One RutasDestino object</returns>
		public RutasDestino Get(int Codigo, int RutasOrigenCodigo, bool generateUndo=false)
		{
			try 
			{
				RutasDestino rutasdestino = null;
				DataTable dt = RutasDestinoDataProvider.Instance.Get(Codigo, RutasOrigenCodigo);
				if ((dt.Rows.Count > 0))
				{
					rutasdestino = new RutasDestino();
					DataRow dr = dt.Rows[0];
					ReadData(rutasdestino, dr, generateUndo);
				}


				return rutasdestino;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Gets all objects of RutasDestino
		/// </summary>
		/// <returns>One RutasDestinoList object</returns>
		public RutasDestinoList GetAll(bool generateUndo=false)
		{
			try 
			{
				RutasDestinoList rutasdestinolist = new RutasDestinoList();
				DataTable dt = RutasDestinoDataProvider.Instance.GetAll();
				foreach (DataRow dr in dt.Rows)
				{
					RutasDestino rutasdestino = new RutasDestino();
					ReadData(rutasdestino, dr, generateUndo);
					rutasdestinolist.Add(rutasdestino);
				}
				return rutasdestinolist;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Selects all RutasDestino objects by reference (Foreign Keys)
		/// </summary>
		/// <param name="RutasOrigenCodigo">int that contents the RutasOrigenCodigo value for the RutasDestino object</param>
		/// <returns>One RutasDestinoList object</returns>
		public RutasDestinoList GetBy_RutasOrigenCodigo(int RutasOrigenCodigo,bool generateUndo=false)
		{
			try 
			{
				RutasDestinoList rutasdestinolist = new RutasDestinoList();

				DataTable dt = RutasDestinoDataProvider.Instance.GetBy_RutasOrigenCodigo(RutasOrigenCodigo);
				foreach (DataRow dr in dt.Rows)
				{
					RutasDestino rutasdestino = new RutasDestino();
					ReadData(rutasdestino, dr, generateUndo);
					rutasdestinolist.Add(rutasdestino);
				}
				return rutasdestinolist;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Gets all objects of RutasDestino applying filter and sort criteria
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
		/// <returns>One RutasDestinoList object</returns>
		public RutasDestinoList GetFilter(int pagenum, int pagesize, string filter, string sort, string extablesfilter, string extablesfieldsfilter, string extablesrelationsfilter, string extablessort, string extablesfieldssort, string extablesrelationssort, bool generateUndo=false)
		{
			try 
			{
				RutasDestinoList rutasdestinolist = new RutasDestinoList();

				DataTable dt = RutasDestinoDataProvider.Instance.GetFilter(pagenum, pagesize, filter, sort, extablesfilter, extablesfieldsfilter, extablesrelationsfilter, extablessort, extablesfieldssort, extablesrelationssort);

				foreach (DataRow dr in dt.Rows)
				{
					RutasDestino rutasdestino = new RutasDestino();
					ReadData(rutasdestino, dr, generateUndo);
					rutasdestinolist.Add(rutasdestino);
				}
				return rutasdestinolist;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public RutasDestinoList GetFilter( string filter, string sort, bool generateUndo=false)
		{
			return GetFilter(0,0, filter, sort, "","","","","","",generateUndo);
		}

		public RutasDestinoList GetFilter(string filter, string sort, string extablesfilter, string extablesfieldsfilter, string extablesrelationsfilter, string extablessort, string extablesfieldssort, string extablesrelationssort, bool generateUndo=false)
		{
			return GetFilter(0,0, filter, sort, extablesfilter, extablesfieldsfilter, extablesrelationsfilter, extablessort, extablesfieldssort, extablesrelationssort,generateUndo);
		}


		/// <summary>
		/// Returns the type for one property
		/// </summary>
		/// <param name="propertyname">Property's name for return its value</param>
		/// <returns>A value for the <paramref name="propertyname"/></returns>
		public Type GetMethodType( string propertyname,RutasDestino rutasdestino)
		{
			// Perform the search for the property's value
			switch (propertyname)
			{
				case "Codigo":
					return rutasdestino.Codigo.GetType();

				case "RutasOrigenCodigo":
					return rutasdestino.RutasOrigenCodigo.GetType();

				case "Origen":
					return rutasdestino.Origen.GetType();

				case "Destino":
					return rutasdestino.Destino.GetType();

				case "Favorita":
					return rutasdestino.Favorita.GetType();

			}

			return null;
		}
		/// <summary>
		/// update the changes in RutasDestino object by passing the object
		/// </summary>
		public bool UpdateChanges(RutasDestino rutasdestino, out string error,Sinapsys.Datos.SQL datosTransaccion=null)
		{
			if (rutasdestino.OldRutasDestino == null)
			{
				    error = "No tiene objeto con el cual comparar";
				    return false;
			}
			string[] Fields = rutasdestino.FieldChanged();
			error = "";
			return LiqViajes_Bll_Data.DataProvider.UpdateFieldsbyObject(Fields, rutasdestino, out error,datosTransaccion);
		}
	}

	#endregion

}
