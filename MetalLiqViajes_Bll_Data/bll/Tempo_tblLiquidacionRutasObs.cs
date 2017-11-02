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
	#region Tempo_tblLiquidacionRutasObsController

	/// <summary>
	/// Class for convert data from database into object's data and vice versa
	/// </summary>
	public partial class Tempo_tblLiquidacionRutasObsController//: ILatinodeController
	{
		/// <summary>
		/// Generic Constructor
		/// </summary>
		public Tempo_tblLiquidacionRutasObsController()
		{
		}

		/// <summary>
		/// Instance accessor for this singleton
		/// </summary>
		private static Tempo_tblLiquidacionRutasObsController MySingleObj;
		public static Tempo_tblLiquidacionRutasObsController Instance
		{
			get
			{
				if (MySingleObj == null)
				{
					MySingleObj = new Tempo_tblLiquidacionRutasObsController();
				}
				return MySingleObj;
			}
		}

		// Reads object's data from a DataRow
		private void ReadData(Tempo_tblLiquidacionRutasObs tempo_tblliquidacionrutasobs, DataRow dr,bool generateUndo=false)
		{
			try 
			{
				tempo_tblliquidacionrutasobs.lngIdRegistrRutaItemId = (int) dr["lngIdRegistrRutaItemId"];
				tempo_tblliquidacionrutasobs.lngIdRegistrRuta = dr.IsNull("lngIdRegistrRuta") ? null :(int?) dr["lngIdRegistrRuta"];
				tempo_tblliquidacionrutasobs.lngIdRegistro = dr.IsNull("lngIdRegistro") ? null :(int?) dr["lngIdRegistro"];
				tempo_tblliquidacionrutasobs.strCampo = dr.IsNull("strCampo") ? null :(char?) ((string) dr["strCampo"])[0];
				tempo_tblliquidacionrutasobs.strObservacion = dr.IsNull("strObservacion") ? null :(char?) ((string) dr["strObservacion"])[0];
				tempo_tblliquidacionrutasobs.strMotivo = dr.IsNull("strMotivo") ? null :(char?) ((string) dr["strMotivo"])[0];
				tempo_tblliquidacionrutasobs.lngIdUsuario = dr.IsNull("lngIdUsuario") ? null :(int?) dr["lngIdUsuario"];
			}
			catch (Exception ex)
			{
				Utilidades.LogErrores(ex.Message + (ex.InnerException != null ? ex.InnerException.Message : ""), DataProvider.AplicacionNombre);
				throw ex;
			}
			if (generateUndo) tempo_tblliquidacionrutasobs.GenerateUndo();
		}

		/// <summary>
		/// Create a new Tempo_tblLiquidacionRutasObs object by passing a object
		/// </summary>
		public Tempo_tblLiquidacionRutasObs Create(Tempo_tblLiquidacionRutasObs tempo_tblliquidacionrutasobs, Sinapsys.Datos.SQL datosTransaccion=null)
		{
			return Create(tempo_tblliquidacionrutasobs.lngIdRegistrRutaItemId,tempo_tblliquidacionrutasobs.lngIdRegistrRuta,tempo_tblliquidacionrutasobs.lngIdRegistro,tempo_tblliquidacionrutasobs.strCampo,tempo_tblliquidacionrutasobs.strObservacion,tempo_tblliquidacionrutasobs.strMotivo,tempo_tblliquidacionrutasobs.lngIdUsuario,datosTransaccion);
		}

		/// <summary>
		/// Creates a new Tempo_tblLiquidacionRutasObs object by passing all object's fields
		/// </summary>
		/// <param name="lngIdRegistrRutaItemId">int that contents the lngIdRegistrRutaItemId value for the Tempo_tblLiquidacionRutasObs object</param>
		/// <param name="lngIdRegistrRuta">int that contents the lngIdRegistrRuta value for the Tempo_tblLiquidacionRutasObs object</param>
		/// <param name="lngIdRegistro">int that contents the lngIdRegistro value for the Tempo_tblLiquidacionRutasObs object</param>
		/// <param name="strCampo">char that contents the strCampo value for the Tempo_tblLiquidacionRutasObs object</param>
		/// <param name="strObservacion">char that contents the strObservacion value for the Tempo_tblLiquidacionRutasObs object</param>
		/// <param name="strMotivo">char that contents the strMotivo value for the Tempo_tblLiquidacionRutasObs object</param>
		/// <param name="lngIdUsuario">int that contents the lngIdUsuario value for the Tempo_tblLiquidacionRutasObs object</param>
		/// <returns>One Tempo_tblLiquidacionRutasObs object</returns>
		public Tempo_tblLiquidacionRutasObs Create(int lngIdRegistrRutaItemId, int? lngIdRegistrRuta, int? lngIdRegistro, char? strCampo, char? strObservacion, char? strMotivo, int? lngIdUsuario, Sinapsys.Datos.SQL datosTransaccion=null)
		{
			try 
			{
				Tempo_tblLiquidacionRutasObs tempo_tblliquidacionrutasobs = new Tempo_tblLiquidacionRutasObs();

				tempo_tblliquidacionrutasobs.lngIdRegistrRutaItemId = lngIdRegistrRutaItemId;
				tempo_tblliquidacionrutasobs.lngIdRegistrRuta = lngIdRegistrRuta;
				tempo_tblliquidacionrutasobs.lngIdRegistro = lngIdRegistro;
				tempo_tblliquidacionrutasobs.strCampo = strCampo;
				tempo_tblliquidacionrutasobs.strObservacion = strObservacion;
				tempo_tblliquidacionrutasobs.strMotivo = strMotivo;
				tempo_tblliquidacionrutasobs.lngIdUsuario = lngIdUsuario;
				Tempo_tblLiquidacionRutasObsDataProvider.Instance.Create(lngIdRegistrRutaItemId, lngIdRegistrRuta, lngIdRegistro, strCampo, strObservacion, strMotivo, lngIdUsuario,"Tempo_tblLiquidacionRutasObs");

				return tempo_tblliquidacionrutasobs;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Gets all objects of Tempo_tblLiquidacionRutasObs
		/// </summary>
		/// <returns>One Tempo_tblLiquidacionRutasObsList object</returns>
		public Tempo_tblLiquidacionRutasObsList GetAll(bool generateUndo=false)
		{
			try 
			{
				Tempo_tblLiquidacionRutasObsList tempo_tblliquidacionrutasobslist = new Tempo_tblLiquidacionRutasObsList();
				DataTable dt = Tempo_tblLiquidacionRutasObsDataProvider.Instance.GetAll();
				foreach (DataRow dr in dt.Rows)
				{
					Tempo_tblLiquidacionRutasObs tempo_tblliquidacionrutasobs = new Tempo_tblLiquidacionRutasObs();
					ReadData(tempo_tblliquidacionrutasobs, dr, generateUndo);
					tempo_tblliquidacionrutasobslist.Add(tempo_tblliquidacionrutasobs);
				}
				return tempo_tblliquidacionrutasobslist;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Gets all objects of Tempo_tblLiquidacionRutasObs applying filter and sort criteria
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
		/// <returns>One Tempo_tblLiquidacionRutasObsList object</returns>
		public Tempo_tblLiquidacionRutasObsList GetFilter(int pagenum, int pagesize, string filter, string sort, string extablesfilter, string extablesfieldsfilter, string extablesrelationsfilter, string extablessort, string extablesfieldssort, string extablesrelationssort, bool generateUndo=false)
		{
			try 
			{
				Tempo_tblLiquidacionRutasObsList tempo_tblliquidacionrutasobslist = new Tempo_tblLiquidacionRutasObsList();

				DataTable dt = Tempo_tblLiquidacionRutasObsDataProvider.Instance.GetFilter(pagenum, pagesize, filter, sort, extablesfilter, extablesfieldsfilter, extablesrelationsfilter, extablessort, extablesfieldssort, extablesrelationssort);

				foreach (DataRow dr in dt.Rows)
				{
					Tempo_tblLiquidacionRutasObs tempo_tblliquidacionrutasobs = new Tempo_tblLiquidacionRutasObs();
					ReadData(tempo_tblliquidacionrutasobs, dr, generateUndo);
					tempo_tblliquidacionrutasobslist.Add(tempo_tblliquidacionrutasobs);
				}
				return tempo_tblliquidacionrutasobslist;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public Tempo_tblLiquidacionRutasObsList GetFilter( string filter, string sort, bool generateUndo=false)
		{
			return GetFilter(0,0, filter, sort, "","","","","","",generateUndo);
		}

		public Tempo_tblLiquidacionRutasObsList GetFilter(string filter, string sort, string extablesfilter, string extablesfieldsfilter, string extablesrelationsfilter, string extablessort, string extablesfieldssort, string extablesrelationssort, bool generateUndo=false)
		{
			return GetFilter(0,0, filter, sort, extablesfilter, extablesfieldsfilter, extablesrelationsfilter, extablessort, extablesfieldssort, extablesrelationssort,generateUndo);
		}


		/// <summary>
		/// Returns the type for one property
		/// </summary>
		/// <param name="propertyname">Property's name for return its value</param>
		/// <returns>A value for the <paramref name="propertyname"/></returns>
		public Type GetMethodType( string propertyname,Tempo_tblLiquidacionRutasObs tempo_tblliquidacionrutasobs)
		{
			// Perform the search for the property's value
			switch (propertyname)
			{
				case "lngIdRegistrRutaItemId":
					return tempo_tblliquidacionrutasobs.lngIdRegistrRutaItemId.GetType();

				case "lngIdRegistrRuta":
					return tempo_tblliquidacionrutasobs.lngIdRegistrRuta.GetType();

				case "lngIdRegistro":
					return tempo_tblliquidacionrutasobs.lngIdRegistro.GetType();

				case "strCampo":
					return tempo_tblliquidacionrutasobs.strCampo.GetType();

				case "strObservacion":
					return tempo_tblliquidacionrutasobs.strObservacion.GetType();

				case "strMotivo":
					return tempo_tblliquidacionrutasobs.strMotivo.GetType();

				case "lngIdUsuario":
					return tempo_tblliquidacionrutasobs.lngIdUsuario.GetType();

			}

			return null;
		}
		/// <summary>
		/// update the changes in Tempo_tblLiquidacionRutasObs object by passing the object
		/// </summary>
		public bool UpdateChanges(Tempo_tblLiquidacionRutasObs tempo_tblliquidacionrutasobs, out string error,Sinapsys.Datos.SQL datosTransaccion=null)
		{
			if (tempo_tblliquidacionrutasobs.OldTempo_tblLiquidacionRutasObs == null)
			{
				    error = "No tiene objeto con el cual comparar";
				    return false;
			}
			string[] Fields = tempo_tblliquidacionrutasobs.FieldChanged();
			error = "";
			return LiqViajes_Bll_Data.DataProvider.UpdateFieldsbyObject(Fields, tempo_tblliquidacionrutasobs, out error,datosTransaccion);
		}
	}

	#endregion

}
