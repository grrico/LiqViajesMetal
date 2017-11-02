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
	#region Rutas_Peajes_DetalleController

	/// <summary>
	/// Class for convert data from database into object's data and vice versa
	/// </summary>
	public partial class Rutas_Peajes_DetalleController//: ILatinodeController
	{
		/// <summary>
		/// Generic Constructor
		/// </summary>
		public Rutas_Peajes_DetalleController()
		{
		}

		/// <summary>
		/// Instance accessor for this singleton
		/// </summary>
		private static Rutas_Peajes_DetalleController MySingleObj;
		public static Rutas_Peajes_DetalleController Instance
		{
			get
			{
				if (MySingleObj == null)
				{
					MySingleObj = new Rutas_Peajes_DetalleController();
				}
				return MySingleObj;
			}
		}

		// Reads object's data from a DataRow
		private void ReadData(Rutas_Peajes_Detalle rutas_peajes_detalle, DataRow dr,bool generateUndo=false)
		{
			try 
			{
				rutas_peajes_detalle.codigo = (long) dr["codigo"];
				rutas_peajes_detalle.Rutas_PeajesCodigo = (long) dr["Rutas_PeajesCodigo"];
				rutas_peajes_detalle.lngIdPeaje = (int) dr["lngIdPeaje"];
				rutas_peajes_detalle.Secuencia = dr.IsNull("Secuencia") ? null :(int?) dr["Secuencia"];
				rutas_peajes_detalle.Excluido = dr.IsNull("Excluido") ? null :(bool?) dr["Excluido"];
				rutas_peajes_detalle.fechaModificacion = dr.IsNull("fechaModificacion") ? null :(DateTime?) dr["fechaModificacion"];
			}
			catch (Exception ex)
			{
				Utilidades.LogErrores(ex.Message + (ex.InnerException != null ? ex.InnerException.Message : ""), DataProvider.AplicacionNombre);
				throw ex;
			}
			if (generateUndo) rutas_peajes_detalle.GenerateUndo();
		}

		/// <summary>
		/// Create a new Rutas_Peajes_Detalle object by passing a object
		/// </summary>
		public Rutas_Peajes_Detalle Create(Rutas_Peajes_Detalle rutas_peajes_detalle, Sinapsys.Datos.SQL datosTransaccion=null)
		{
			return Create(rutas_peajes_detalle.codigo,rutas_peajes_detalle.Rutas_PeajesCodigo,rutas_peajes_detalle.lngIdPeaje,rutas_peajes_detalle.Secuencia,rutas_peajes_detalle.Excluido,rutas_peajes_detalle.fechaModificacion,datosTransaccion);
		}

		/// <summary>
		/// Creates a new Rutas_Peajes_Detalle object by passing all object's fields
		/// </summary>
		/// <param name="Secuencia">int that contents the Secuencia value for the Rutas_Peajes_Detalle object</param>
		/// <param name="Excluido">bool that contents the Excluido value for the Rutas_Peajes_Detalle object</param>
		/// <param name="fechaModificacion">DateTime that contents the fechaModificacion value for the Rutas_Peajes_Detalle object</param>
		/// <returns>One Rutas_Peajes_Detalle object</returns>
		public Rutas_Peajes_Detalle Create(long codigo, long Rutas_PeajesCodigo, int lngIdPeaje, int? Secuencia, bool? Excluido, DateTime? fechaModificacion, Sinapsys.Datos.SQL datosTransaccion=null)
		{
			try 
			{
				Rutas_Peajes_Detalle rutas_peajes_detalle = new Rutas_Peajes_Detalle();

				rutas_peajes_detalle.codigo = codigo;
				rutas_peajes_detalle.codigo = codigo;
				rutas_peajes_detalle.Rutas_PeajesCodigo = Rutas_PeajesCodigo;
				rutas_peajes_detalle.lngIdPeaje = lngIdPeaje;
				rutas_peajes_detalle.Secuencia = Secuencia;
				rutas_peajes_detalle.Excluido = Excluido;
				rutas_peajes_detalle.fechaModificacion = fechaModificacion;
				codigo = Rutas_Peajes_DetalleDataProvider.Instance.Create(codigo, Rutas_PeajesCodigo, lngIdPeaje, Secuencia, Excluido, fechaModificacion,"Rutas_Peajes_Detalle",datosTransaccion);
				if (codigo == 0)
					return null;

				rutas_peajes_detalle.codigo = codigo;

				return rutas_peajes_detalle;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Updates an Rutas_Peajes_Detalle object by passing all object's fields
		/// </summary>
		/// <param name="codigo">long that contents the codigo value for the Rutas_Peajes_Detalle object</param>
		/// <param name="Rutas_PeajesCodigo">long that contents the Rutas_PeajesCodigo value for the Rutas_Peajes_Detalle object</param>
		/// <param name="lngIdPeaje">int that contents the lngIdPeaje value for the Rutas_Peajes_Detalle object</param>
		/// <param name="Secuencia">int that contents the Secuencia value for the Rutas_Peajes_Detalle object</param>
		/// <param name="Excluido">bool that contents the Excluido value for the Rutas_Peajes_Detalle object</param>
		/// <param name="fechaModificacion">DateTime that contents the fechaModificacion value for the Rutas_Peajes_Detalle object</param>
		public void Update(long codigo, long Rutas_PeajesCodigo, int lngIdPeaje, int? Secuencia, bool? Excluido, DateTime? fechaModificacion, Sinapsys.Datos.SQL datosTransaccion=null)
		{
			try 
			{
				Rutas_Peajes_Detalle new_values = new Rutas_Peajes_Detalle();
				new_values.Secuencia = Secuencia;
				new_values.Excluido = Excluido;
				new_values.fechaModificacion = fechaModificacion;
				Rutas_Peajes_DetalleDataProvider.Instance.Update(codigo, Rutas_PeajesCodigo, lngIdPeaje, Secuencia, Excluido, fechaModificacion,"Rutas_Peajes_Detalle",datosTransaccion);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Updates an Rutas_Peajes_Detalle object by passing one object's instance as reference
		/// </summary>
		/// <param name="rutas_peajes_detalle">An instance of Rutas_Peajes_Detalle for reference</param>
		public void Update(Rutas_Peajes_Detalle rutas_peajes_detalle,Sinapsys.Datos.SQL datosTransaccion=null)
		{
			Update(rutas_peajes_detalle.codigo, rutas_peajes_detalle.Rutas_PeajesCodigo, rutas_peajes_detalle.lngIdPeaje, rutas_peajes_detalle.Secuencia, rutas_peajes_detalle.Excluido, rutas_peajes_detalle.fechaModificacion);
		}

		/// <summary>
		/// Delete  the Rutas_Peajes_Detalle object by passing a object
		/// </summary>
		public void  Delete(Rutas_Peajes_Detalle rutas_peajes_detalle, Sinapsys.Datos.SQL datosTransaccion=null)
		{
			Delete(rutas_peajes_detalle.codigo, rutas_peajes_detalle.Rutas_PeajesCodigo, rutas_peajes_detalle.lngIdPeaje,datosTransaccion);
		}

		/// <summary>
		/// Deletes the Rutas_Peajes_Detalle object by passing one object's instance as reference
		/// </summary>
		/// <param name="rutas_peajes_detalle">An instance of Rutas_Peajes_Detalle for reference</param>
		public void Delete(long codigo, long Rutas_PeajesCodigo, int lngIdPeaje, Sinapsys.Datos.SQL datosTransaccion=null)
		{
			try 
			{
				//Rutas_Peajes_Detalle old_values = Rutas_Peajes_DetalleController.Instance.Get(codigo);
				//if(!Validate.security.CanDeleteSecurityField(Rutas_Peajes_DetalleController.Instance, (ILatinodeObject)old_values))
				//    throw new Exception("Access denied by security field, you can't delete object");

				Rutas_Peajes_DetalleDataProvider.Instance.Delete(codigo, Rutas_PeajesCodigo, lngIdPeaje,"Rutas_Peajes_Detalle");
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Deletes the Rutas_Peajes_Detalle object by passing CVS parameter as reference
		/// </summary>
		/// <param name="rutas_peajes_detalle">An instance of Rutas_Peajes_Detalle for reference</param>
		public void Delete(string CVSParameter)
		{
			string[] StrCommand=CVSParameter.Split(',');
			try 
			{
				long codigo=long.Parse(StrCommand[0]);
				long Rutas_PeajesCodigo=long.Parse(StrCommand[1]);
				int lngIdPeaje=int.Parse(StrCommand[2]);
				Rutas_Peajes_DetalleDataProvider.Instance.Delete(codigo, Rutas_PeajesCodigo, lngIdPeaje,"Rutas_Peajes_Detalle");
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Gets the Rutas_Peajes_Detalle object by passing the object's key fields
		/// </summary>
		/// <param name="codigo">long that contents the codigo value for the Rutas_Peajes_Detalle object</param>
		/// <param name="Rutas_PeajesCodigo">long that contents the Rutas_PeajesCodigo value for the Rutas_Peajes_Detalle object</param>
		/// <param name="lngIdPeaje">int that contents the lngIdPeaje value for the Rutas_Peajes_Detalle object</param>
		/// <returns>One Rutas_Peajes_Detalle object</returns>
		public Rutas_Peajes_Detalle Get(long codigo, long Rutas_PeajesCodigo, int lngIdPeaje, bool generateUndo=false)
		{
			try 
			{
				Rutas_Peajes_Detalle rutas_peajes_detalle = null;
				DataTable dt = Rutas_Peajes_DetalleDataProvider.Instance.Get(codigo, Rutas_PeajesCodigo, lngIdPeaje);
				if ((dt.Rows.Count > 0))
				{
					rutas_peajes_detalle = new Rutas_Peajes_Detalle();
					DataRow dr = dt.Rows[0];
					ReadData(rutas_peajes_detalle, dr, generateUndo);
				}


				return rutas_peajes_detalle;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Gets all objects of Rutas_Peajes_Detalle
		/// </summary>
		/// <returns>One Rutas_Peajes_DetalleList object</returns>
		public Rutas_Peajes_DetalleList GetAll(bool generateUndo=false)
		{
			try 
			{
				Rutas_Peajes_DetalleList rutas_peajes_detallelist = new Rutas_Peajes_DetalleList();
				DataTable dt = Rutas_Peajes_DetalleDataProvider.Instance.GetAll();
				foreach (DataRow dr in dt.Rows)
				{
					Rutas_Peajes_Detalle rutas_peajes_detalle = new Rutas_Peajes_Detalle();
					ReadData(rutas_peajes_detalle, dr, generateUndo);
					rutas_peajes_detallelist.Add(rutas_peajes_detalle);
				}
				return rutas_peajes_detallelist;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Gets all objects of Rutas_Peajes_Detalle applying filter and sort criteria
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
		/// <returns>One Rutas_Peajes_DetalleList object</returns>
		public Rutas_Peajes_DetalleList GetFilter(int pagenum, int pagesize, string filter, string sort, string extablesfilter, string extablesfieldsfilter, string extablesrelationsfilter, string extablessort, string extablesfieldssort, string extablesrelationssort, bool generateUndo=false)
		{
			try 
			{
				Rutas_Peajes_DetalleList rutas_peajes_detallelist = new Rutas_Peajes_DetalleList();

				DataTable dt = Rutas_Peajes_DetalleDataProvider.Instance.GetFilter(pagenum, pagesize, filter, sort, extablesfilter, extablesfieldsfilter, extablesrelationsfilter, extablessort, extablesfieldssort, extablesrelationssort);

				foreach (DataRow dr in dt.Rows)
				{
					Rutas_Peajes_Detalle rutas_peajes_detalle = new Rutas_Peajes_Detalle();
					ReadData(rutas_peajes_detalle, dr, generateUndo);
					rutas_peajes_detallelist.Add(rutas_peajes_detalle);
				}
				return rutas_peajes_detallelist;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public Rutas_Peajes_DetalleList GetFilter( string filter, string sort, bool generateUndo=false)
		{
			return GetFilter(0,0, filter, sort, "","","","","","",generateUndo);
		}

		public Rutas_Peajes_DetalleList GetFilter(string filter, string sort, string extablesfilter, string extablesfieldsfilter, string extablesrelationsfilter, string extablessort, string extablesfieldssort, string extablesrelationssort, bool generateUndo=false)
		{
			return GetFilter(0,0, filter, sort, extablesfilter, extablesfieldsfilter, extablesrelationsfilter, extablessort, extablesfieldssort, extablesrelationssort,generateUndo);
		}


		/// <summary>
		/// Returns the type for one property
		/// </summary>
		/// <param name="propertyname">Property's name for return its value</param>
		/// <returns>A value for the <paramref name="propertyname"/></returns>
		public Type GetMethodType( string propertyname,Rutas_Peajes_Detalle rutas_peajes_detalle)
		{
			// Perform the search for the property's value
			switch (propertyname)
			{
				case "codigo":
					return rutas_peajes_detalle.codigo.GetType();

				case "Rutas_PeajesCodigo":
					return rutas_peajes_detalle.Rutas_PeajesCodigo.GetType();

				case "lngIdPeaje":
					return rutas_peajes_detalle.lngIdPeaje.GetType();

				case "Secuencia":
					return rutas_peajes_detalle.Secuencia.GetType();

				case "Excluido":
					return rutas_peajes_detalle.Excluido.GetType();

				case "fechaModificacion":
					return rutas_peajes_detalle.fechaModificacion.GetType();

			}

			return null;
		}
		/// <summary>
		/// update the changes in Rutas_Peajes_Detalle object by passing the object
		/// </summary>
		public bool UpdateChanges(Rutas_Peajes_Detalle rutas_peajes_detalle, out string error,Sinapsys.Datos.SQL datosTransaccion=null)
		{
			if (rutas_peajes_detalle.OldRutas_Peajes_Detalle == null)
			{
				    error = "No tiene objeto con el cual comparar";
				    return false;
			}
			string[] Fields = rutas_peajes_detalle.FieldChanged();
			error = "";
			return LiqViajes_Bll_Data.DataProvider.UpdateFieldsbyObject(Fields, rutas_peajes_detalle, out error,datosTransaccion);
		}
	}

	#endregion

}
