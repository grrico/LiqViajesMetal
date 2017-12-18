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
	#region RutasSatrackParametrosController

	/// <summary>
	/// Class for convert data from database into object's data and vice versa
	/// </summary>
	public partial class RutasSatrackParametrosController//: ILatinodeController
	{
		/// <summary>
		/// Generic Constructor
		/// </summary>
		public RutasSatrackParametrosController()
		{
		}

		/// <summary>
		/// Instance accessor for this singleton
		/// </summary>
		private static RutasSatrackParametrosController MySingleObj;
		public static RutasSatrackParametrosController Instance
		{
			get
			{
				if (MySingleObj == null)
				{
					MySingleObj = new RutasSatrackParametrosController();
				}
				return MySingleObj;
			}
		}

		// Reads object's data from a DataRow
		private void ReadData(RutasSatrackParametros rutassatrackparametros, DataRow dr,bool generateUndo=false)
		{
			try 
			{
				rutassatrackparametros.Codigo = (long) dr["Codigo"];
				rutassatrackparametros.NombreEvento = dr.IsNull("NombreEvento") ? null :(string) dr["NombreEvento"];
				rutassatrackparametros.ACtivoWS = dr.IsNull("ACtivoWS") ? null :(bool?) dr["ACtivoWS"];
				rutassatrackparametros.ACtivoWinForm = dr.IsNull("ACtivoWinForm") ? null :(bool?) dr["ACtivoWinForm"];
				rutassatrackparametros.TipoEvento = dr.IsNull("TipoEvento") ? null :(int?) dr["TipoEvento"];
			}
			catch (Exception ex)
			{
				Utilidades.LogErrores(ex.Message + (ex.InnerException != null ? ex.InnerException.Message : ""), DataProvider.AplicacionNombre);
				throw ex;
			}
			if (generateUndo) rutassatrackparametros.GenerateUndo();
		}

		/// <summary>
		/// Create a new RutasSatrackParametros object by passing a object
		/// </summary>
		public RutasSatrackParametros Create(RutasSatrackParametros rutassatrackparametros, Sinapsys.Datos.SQL datosTransaccion=null)
		{
			return Create(rutassatrackparametros.Codigo,rutassatrackparametros.NombreEvento,rutassatrackparametros.ACtivoWS,rutassatrackparametros.ACtivoWinForm,rutassatrackparametros.TipoEvento,datosTransaccion);
		}

		/// <summary>
		/// Creates a new RutasSatrackParametros object by passing all object's fields
		/// </summary>
		/// <param name="NombreEvento">string that contents the NombreEvento value for the RutasSatrackParametros object</param>
		/// <param name="ACtivoWS">bool that contents the ACtivoWS value for the RutasSatrackParametros object</param>
		/// <param name="ACtivoWinForm">bool that contents the ACtivoWinForm value for the RutasSatrackParametros object</param>
		/// <param name="TipoEvento">int that contents the TipoEvento value for the RutasSatrackParametros object</param>
		/// <returns>One RutasSatrackParametros object</returns>
		public RutasSatrackParametros Create(long Codigo, string NombreEvento, bool? ACtivoWS, bool? ACtivoWinForm, int? TipoEvento, Sinapsys.Datos.SQL datosTransaccion=null)
		{
			try 
			{
				RutasSatrackParametros rutassatrackparametros = new RutasSatrackParametros();

				rutassatrackparametros.Codigo = Codigo;
				rutassatrackparametros.NombreEvento = NombreEvento;
				rutassatrackparametros.ACtivoWS = ACtivoWS;
				rutassatrackparametros.ACtivoWinForm = ACtivoWinForm;
				rutassatrackparametros.TipoEvento = TipoEvento;
				RutasSatrackParametrosDataProvider.Instance.Create(Codigo, NombreEvento, ACtivoWS, ACtivoWinForm, TipoEvento,"RutasSatrackParametros");

				return rutassatrackparametros;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Updates an RutasSatrackParametros object by passing all object's fields
		/// </summary>
		/// <param name="Codigo">long that contents the Codigo value for the RutasSatrackParametros object</param>
		/// <param name="NombreEvento">string that contents the NombreEvento value for the RutasSatrackParametros object</param>
		/// <param name="ACtivoWS">bool that contents the ACtivoWS value for the RutasSatrackParametros object</param>
		/// <param name="ACtivoWinForm">bool that contents the ACtivoWinForm value for the RutasSatrackParametros object</param>
		/// <param name="TipoEvento">int that contents the TipoEvento value for the RutasSatrackParametros object</param>
		public void Update(long Codigo, string NombreEvento, bool? ACtivoWS, bool? ACtivoWinForm, int? TipoEvento, Sinapsys.Datos.SQL datosTransaccion=null)
		{
			try 
			{
				RutasSatrackParametros new_values = new RutasSatrackParametros();
				new_values.NombreEvento = NombreEvento;
				new_values.ACtivoWS = ACtivoWS;
				new_values.ACtivoWinForm = ACtivoWinForm;
				new_values.TipoEvento = TipoEvento;
				RutasSatrackParametrosDataProvider.Instance.Update(Codigo, NombreEvento, ACtivoWS, ACtivoWinForm, TipoEvento,"RutasSatrackParametros",datosTransaccion);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Updates an RutasSatrackParametros object by passing one object's instance as reference
		/// </summary>
		/// <param name="rutassatrackparametros">An instance of RutasSatrackParametros for reference</param>
		public void Update(RutasSatrackParametros rutassatrackparametros,Sinapsys.Datos.SQL datosTransaccion=null)
		{
			Update(rutassatrackparametros.Codigo, rutassatrackparametros.NombreEvento, rutassatrackparametros.ACtivoWS, rutassatrackparametros.ACtivoWinForm, rutassatrackparametros.TipoEvento);
		}

		/// <summary>
		/// Delete  the RutasSatrackParametros object by passing a object
		/// </summary>
		public void  Delete(RutasSatrackParametros rutassatrackparametros, Sinapsys.Datos.SQL datosTransaccion=null)
		{
			Delete(rutassatrackparametros.Codigo,datosTransaccion);
		}

		/// <summary>
		/// Deletes the RutasSatrackParametros object by passing one object's instance as reference
		/// </summary>
		/// <param name="rutassatrackparametros">An instance of RutasSatrackParametros for reference</param>
		public void Delete(long Codigo, Sinapsys.Datos.SQL datosTransaccion=null)
		{
			try 
			{
				RutasSatrackParametrosDataProvider.Instance.Delete(Codigo,"RutasSatrackParametros");
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Deletes the RutasSatrackParametros object by passing CVS parameter as reference
		/// </summary>
		/// <param name="rutassatrackparametros">An instance of RutasSatrackParametros for reference</param>
		public void Delete(string CVSParameter)
		{
			string[] StrCommand=CVSParameter.Split(',');
			try 
			{
				long Codigo=long.Parse(StrCommand[0]);
				RutasSatrackParametrosDataProvider.Instance.Delete(Codigo,"RutasSatrackParametros");
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Gets the RutasSatrackParametros object by passing the object's key fields
		/// </summary>
		/// <param name="Codigo">long that contents the Codigo value for the RutasSatrackParametros object</param>
		/// <returns>One RutasSatrackParametros object</returns>
		public RutasSatrackParametros Get(long Codigo, bool generateUndo=false)
		{
			try 
			{
				RutasSatrackParametros rutassatrackparametros = null;
				DataTable dt = RutasSatrackParametrosDataProvider.Instance.Get(Codigo);
				if ((dt.Rows.Count > 0))
				{
					rutassatrackparametros = new RutasSatrackParametros();
					DataRow dr = dt.Rows[0];
					ReadData(rutassatrackparametros, dr, generateUndo);
				}


				return rutassatrackparametros;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Gets all objects of RutasSatrackParametros
		/// </summary>
		/// <returns>One RutasSatrackParametrosList object</returns>
		public RutasSatrackParametrosList GetAll(bool generateUndo=false)
		{
			try 
			{
				RutasSatrackParametrosList rutassatrackparametroslist = new RutasSatrackParametrosList();
				DataTable dt = RutasSatrackParametrosDataProvider.Instance.GetAll();
				foreach (DataRow dr in dt.Rows)
				{
					RutasSatrackParametros rutassatrackparametros = new RutasSatrackParametros();
					ReadData(rutassatrackparametros, dr, generateUndo);
					rutassatrackparametroslist.Add(rutassatrackparametros);
				}
				return rutassatrackparametroslist;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Gets all objects of RutasSatrackParametros applying filter and sort criteria
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
		/// <returns>One RutasSatrackParametrosList object</returns>
		public RutasSatrackParametrosList GetFilter(int pagenum, int pagesize, string filter, string sort, string extablesfilter, string extablesfieldsfilter, string extablesrelationsfilter, string extablessort, string extablesfieldssort, string extablesrelationssort, bool generateUndo=false)
		{
			try 
			{
				RutasSatrackParametrosList rutassatrackparametroslist = new RutasSatrackParametrosList();

				DataTable dt = RutasSatrackParametrosDataProvider.Instance.GetFilter(pagenum, pagesize, filter, sort, extablesfilter, extablesfieldsfilter, extablesrelationsfilter, extablessort, extablesfieldssort, extablesrelationssort);

				foreach (DataRow dr in dt.Rows)
				{
					RutasSatrackParametros rutassatrackparametros = new RutasSatrackParametros();
					ReadData(rutassatrackparametros, dr, generateUndo);
					rutassatrackparametroslist.Add(rutassatrackparametros);
				}
				return rutassatrackparametroslist;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public RutasSatrackParametrosList GetFilter( string filter, string sort, bool generateUndo=false)
		{
			return GetFilter(0,0, filter, sort, "","","","","","",generateUndo);
		}

		public RutasSatrackParametrosList GetFilter(string filter, string sort, string extablesfilter, string extablesfieldsfilter, string extablesrelationsfilter, string extablessort, string extablesfieldssort, string extablesrelationssort, bool generateUndo=false)
		{
			return GetFilter(0,0, filter, sort, extablesfilter, extablesfieldsfilter, extablesrelationsfilter, extablessort, extablesfieldssort, extablesrelationssort,generateUndo);
		}


		/// <summary>
		/// Returns the type for one property
		/// </summary>
		/// <param name="propertyname">Property's name for return its value</param>
		/// <returns>A value for the <paramref name="propertyname"/></returns>
		public Type GetMethodType( string propertyname,RutasSatrackParametros rutassatrackparametros)
		{
			// Perform the search for the property's value
			switch (propertyname)
			{
				case "Codigo":
					return rutassatrackparametros.Codigo.GetType();

				case "NombreEvento":
					return rutassatrackparametros.NombreEvento.GetType();

				case "ACtivoWS":
					return rutassatrackparametros.ACtivoWS.GetType();

				case "ACtivoWinForm":
					return rutassatrackparametros.ACtivoWinForm.GetType();

				case "TipoEvento":
					return rutassatrackparametros.TipoEvento.GetType();

			}

			return null;
		}
		/// <summary>
		/// update the changes in RutasSatrackParametros object by passing the object
		/// </summary>
		public bool UpdateChanges(RutasSatrackParametros rutassatrackparametros, out string error,Sinapsys.Datos.SQL datosTransaccion=null)
		{
			if (rutassatrackparametros.OldRutasSatrackParametros == null)
			{
				    error = "No tiene objeto con el cual comparar";
				    return false;
			}
			string[] Fields = rutassatrackparametros.FieldChanged();
			error = "";
			return LiqViajes_Bll_Data.DataProvider.UpdateFieldsbyObject(Fields, rutassatrackparametros, out error,datosTransaccion);
		}
	}

	#endregion

}
