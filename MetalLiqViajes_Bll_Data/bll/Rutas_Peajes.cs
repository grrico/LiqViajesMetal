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
	#region Rutas_PeajesController

	/// <summary>
	/// Class for convert data from database into object's data and vice versa
	/// </summary>
	public partial class Rutas_PeajesController//: ILatinodeController
	{
		/// <summary>
		/// Generic Constructor
		/// </summary>
		public Rutas_PeajesController()
		{
		}

		/// <summary>
		/// Instance accessor for this singleton
		/// </summary>
		private static Rutas_PeajesController MySingleObj;
		public static Rutas_PeajesController Instance
		{
			get
			{
				if (MySingleObj == null)
				{
					MySingleObj = new Rutas_PeajesController();
				}
				return MySingleObj;
			}
		}

		// Reads object's data from a DataRow
		private void ReadData(Rutas_Peajes rutas_peajes, DataRow dr,bool generateUndo=false)
		{
			try 
			{
				rutas_peajes.Codigo = (int) dr["Codigo"];
				rutas_peajes.strRutaAnticipoGrupoOrigen = dr.IsNull("strRutaAnticipoGrupoOrigen") ? null :(string) dr["strRutaAnticipoGrupoOrigen"];
				rutas_peajes.strRutaAnticipoGrupoDestino = dr.IsNull("strRutaAnticipoGrupoDestino") ? null :(string) dr["strRutaAnticipoGrupoDestino"];
				rutas_peajes.strRutaAnticipo = dr.IsNull("strRutaAnticipo") ? null :(string) dr["strRutaAnticipo"];
				rutas_peajes.logActualizado = dr.IsNull("logActualizado") ? null :(bool?) dr["logActualizado"];
				rutas_peajes.FechaActualizacion = dr.IsNull("FechaActualizacion") ? null :(DateTime?) dr["FechaActualizacion"];
			}
			catch (Exception ex)
			{
				Utilidades.LogErrores(ex.Message + (ex.InnerException != null ? ex.InnerException.Message : ""), DataProvider.AplicacionNombre);
				throw ex;
			}
			if (generateUndo) rutas_peajes.GenerateUndo();
		}

		/// <summary>
		/// Create a new Rutas_Peajes object by passing a object
		/// </summary>
		public Rutas_Peajes Create(Rutas_Peajes rutas_peajes, Sinapsys.Datos.SQL datosTransaccion=null)
		{
			return Create(rutas_peajes.Codigo,rutas_peajes.strRutaAnticipoGrupoOrigen,rutas_peajes.strRutaAnticipoGrupoDestino,rutas_peajes.strRutaAnticipo,rutas_peajes.logActualizado,rutas_peajes.FechaActualizacion,datosTransaccion);
		}

		/// <summary>
		/// Creates a new Rutas_Peajes object by passing all object's fields
		/// </summary>
		/// <param name="strRutaAnticipoGrupoOrigen">string that contents the strRutaAnticipoGrupoOrigen value for the Rutas_Peajes object</param>
		/// <param name="strRutaAnticipoGrupoDestino">string that contents the strRutaAnticipoGrupoDestino value for the Rutas_Peajes object</param>
		/// <param name="strRutaAnticipo">string that contents the strRutaAnticipo value for the Rutas_Peajes object</param>
		/// <param name="logActualizado">bool that contents the logActualizado value for the Rutas_Peajes object</param>
		/// <param name="FechaActualizacion">DateTime that contents the FechaActualizacion value for the Rutas_Peajes object</param>
		/// <returns>One Rutas_Peajes object</returns>
		public Rutas_Peajes Create(int Codigo, string strRutaAnticipoGrupoOrigen, string strRutaAnticipoGrupoDestino, string strRutaAnticipo, bool? logActualizado, DateTime? FechaActualizacion, Sinapsys.Datos.SQL datosTransaccion=null)
		{
			try 
			{
				Rutas_Peajes rutas_peajes = new Rutas_Peajes();

				rutas_peajes.Codigo = Codigo;
				rutas_peajes.Codigo = Codigo;
				rutas_peajes.strRutaAnticipoGrupoOrigen = strRutaAnticipoGrupoOrigen;
				rutas_peajes.strRutaAnticipoGrupoDestino = strRutaAnticipoGrupoDestino;
				rutas_peajes.strRutaAnticipo = strRutaAnticipo;
				rutas_peajes.logActualizado = logActualizado;
				rutas_peajes.FechaActualizacion = FechaActualizacion;
				Codigo = Rutas_PeajesDataProvider.Instance.Create(Codigo, strRutaAnticipoGrupoOrigen, strRutaAnticipoGrupoDestino, strRutaAnticipo, logActualizado, FechaActualizacion,"Rutas_Peajes",datosTransaccion);
				if (Codigo == 0)
					return null;

				rutas_peajes.Codigo = Codigo;

				return rutas_peajes;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Updates an Rutas_Peajes object by passing all object's fields
		/// </summary>
		/// <param name="Codigo">int that contents the Codigo value for the Rutas_Peajes object</param>
		/// <param name="strRutaAnticipoGrupoOrigen">string that contents the strRutaAnticipoGrupoOrigen value for the Rutas_Peajes object</param>
		/// <param name="strRutaAnticipoGrupoDestino">string that contents the strRutaAnticipoGrupoDestino value for the Rutas_Peajes object</param>
		/// <param name="strRutaAnticipo">string that contents the strRutaAnticipo value for the Rutas_Peajes object</param>
		/// <param name="logActualizado">bool that contents the logActualizado value for the Rutas_Peajes object</param>
		/// <param name="FechaActualizacion">DateTime that contents the FechaActualizacion value for the Rutas_Peajes object</param>
		public void Update(int Codigo, string strRutaAnticipoGrupoOrigen, string strRutaAnticipoGrupoDestino, string strRutaAnticipo, bool? logActualizado, DateTime? FechaActualizacion, Sinapsys.Datos.SQL datosTransaccion=null)
		{
			try 
			{
				Rutas_Peajes new_values = new Rutas_Peajes();
				new_values.strRutaAnticipoGrupoOrigen = strRutaAnticipoGrupoOrigen;
				new_values.strRutaAnticipoGrupoDestino = strRutaAnticipoGrupoDestino;
				new_values.strRutaAnticipo = strRutaAnticipo;
				new_values.logActualizado = logActualizado;
				new_values.FechaActualizacion = FechaActualizacion;
				Rutas_PeajesDataProvider.Instance.Update(Codigo, strRutaAnticipoGrupoOrigen, strRutaAnticipoGrupoDestino, strRutaAnticipo, logActualizado, FechaActualizacion,"Rutas_Peajes",datosTransaccion);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Updates an Rutas_Peajes object by passing one object's instance as reference
		/// </summary>
		/// <param name="rutas_peajes">An instance of Rutas_Peajes for reference</param>
		public void Update(Rutas_Peajes rutas_peajes,Sinapsys.Datos.SQL datosTransaccion=null)
		{
			Update(rutas_peajes.Codigo, rutas_peajes.strRutaAnticipoGrupoOrigen, rutas_peajes.strRutaAnticipoGrupoDestino, rutas_peajes.strRutaAnticipo, rutas_peajes.logActualizado, rutas_peajes.FechaActualizacion);
		}

		/// <summary>
		/// Delete  the Rutas_Peajes object by passing a object
		/// </summary>
		public void  Delete(Rutas_Peajes rutas_peajes, Sinapsys.Datos.SQL datosTransaccion=null)
		{
			Delete(rutas_peajes.Codigo,datosTransaccion);
		}

		/// <summary>
		/// Deletes the Rutas_Peajes object by passing one object's instance as reference
		/// </summary>
		/// <param name="rutas_peajes">An instance of Rutas_Peajes for reference</param>
		public void Delete(int Codigo, Sinapsys.Datos.SQL datosTransaccion=null)
		{
			try 
			{
				//Rutas_Peajes old_values = Rutas_PeajesController.Instance.Get(Codigo);
				//if(!Validate.security.CanDeleteSecurityField(Rutas_PeajesController.Instance, (ILatinodeObject)old_values))
				//    throw new Exception("Access denied by security field, you can't delete object");

				Rutas_PeajesDataProvider.Instance.Delete(Codigo,"Rutas_Peajes");
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Deletes the Rutas_Peajes object by passing CVS parameter as reference
		/// </summary>
		/// <param name="rutas_peajes">An instance of Rutas_Peajes for reference</param>
		public void Delete(string CVSParameter)
		{
			string[] StrCommand=CVSParameter.Split(',');
			try 
			{
				int Codigo=int.Parse(StrCommand[0]);
				Rutas_PeajesDataProvider.Instance.Delete(Codigo,"Rutas_Peajes");
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Gets the Rutas_Peajes object by passing the object's key fields
		/// </summary>
		/// <param name="Codigo">int that contents the Codigo value for the Rutas_Peajes object</param>
		/// <returns>One Rutas_Peajes object</returns>
		public Rutas_Peajes Get(int Codigo, bool generateUndo=false)
		{
			try 
			{
				Rutas_Peajes rutas_peajes = null;
				DataTable dt = Rutas_PeajesDataProvider.Instance.Get(Codigo);
				if ((dt.Rows.Count > 0))
				{
					rutas_peajes = new Rutas_Peajes();
					DataRow dr = dt.Rows[0];
					ReadData(rutas_peajes, dr, generateUndo);
				}


				return rutas_peajes;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Gets all objects of Rutas_Peajes
		/// </summary>
		/// <returns>One Rutas_PeajesList object</returns>
		public Rutas_PeajesList GetAll(bool generateUndo=false)
		{
			try 
			{
				Rutas_PeajesList rutas_peajeslist = new Rutas_PeajesList();
				DataTable dt = Rutas_PeajesDataProvider.Instance.GetAll();
				foreach (DataRow dr in dt.Rows)
				{
					Rutas_Peajes rutas_peajes = new Rutas_Peajes();
					ReadData(rutas_peajes, dr, generateUndo);
					rutas_peajeslist.Add(rutas_peajes);
				}
				return rutas_peajeslist;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Gets all objects of Rutas_Peajes applying filter and sort criteria
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
		/// <returns>One Rutas_PeajesList object</returns>
		public Rutas_PeajesList GetFilter(int pagenum, int pagesize, string filter, string sort, string extablesfilter, string extablesfieldsfilter, string extablesrelationsfilter, string extablessort, string extablesfieldssort, string extablesrelationssort, bool generateUndo=false)
		{
			try 
			{
				Rutas_PeajesList rutas_peajeslist = new Rutas_PeajesList();

				DataTable dt = Rutas_PeajesDataProvider.Instance.GetFilter(pagenum, pagesize, filter, sort, extablesfilter, extablesfieldsfilter, extablesrelationsfilter, extablessort, extablesfieldssort, extablesrelationssort);

				foreach (DataRow dr in dt.Rows)
				{
					Rutas_Peajes rutas_peajes = new Rutas_Peajes();
					ReadData(rutas_peajes, dr, generateUndo);
					rutas_peajeslist.Add(rutas_peajes);
				}
				return rutas_peajeslist;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public Rutas_PeajesList GetFilter( string filter, string sort, bool generateUndo=false)
		{
			return GetFilter(0,0, filter, sort, "","","","","","",generateUndo);
		}

		public Rutas_PeajesList GetFilter(string filter, string sort, string extablesfilter, string extablesfieldsfilter, string extablesrelationsfilter, string extablessort, string extablesfieldssort, string extablesrelationssort, bool generateUndo=false)
		{
			return GetFilter(0,0, filter, sort, extablesfilter, extablesfieldsfilter, extablesrelationsfilter, extablessort, extablesfieldssort, extablesrelationssort,generateUndo);
		}


		/// <summary>
		/// Returns the type for one property
		/// </summary>
		/// <param name="propertyname">Property's name for return its value</param>
		/// <returns>A value for the <paramref name="propertyname"/></returns>
		public Type GetMethodType( string propertyname,Rutas_Peajes rutas_peajes)
		{
			// Perform the search for the property's value
			switch (propertyname)
			{
				case "Codigo":
					return rutas_peajes.Codigo.GetType();

				case "strRutaAnticipoGrupoOrigen":
					return rutas_peajes.strRutaAnticipoGrupoOrigen.GetType();

				case "strRutaAnticipoGrupoDestino":
					return rutas_peajes.strRutaAnticipoGrupoDestino.GetType();

				case "strRutaAnticipo":
					return rutas_peajes.strRutaAnticipo.GetType();

				case "logActualizado":
					return rutas_peajes.logActualizado.GetType();

				case "FechaActualizacion":
					return rutas_peajes.FechaActualizacion.GetType();

			}

			return null;
		}
		/// <summary>
		/// update the changes in Rutas_Peajes object by passing the object
		/// </summary>
		public bool UpdateChanges(Rutas_Peajes rutas_peajes, out string error,Sinapsys.Datos.SQL datosTransaccion=null)
		{
			if (rutas_peajes.OldRutas_Peajes == null)
			{
				    error = "No tiene objeto con el cual comparar";
				    return false;
			}
			string[] Fields = rutas_peajes.FieldChanged();
			error = "";
			return LiqViajes_Bll_Data.DataProvider.UpdateFieldsbyObject(Fields, rutas_peajes, out error,datosTransaccion);
		}
	}

	#endregion

}
