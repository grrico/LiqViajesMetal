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
	#region RutasMaestroPeajesController

	/// <summary>
	/// Class for convert data from database into object's data and vice versa
	/// </summary>
	public partial class RutasMaestroPeajesController//: ILatinodeController
	{
		/// <summary>
		/// Generic Constructor
		/// </summary>
		public RutasMaestroPeajesController()
		{
		}

		/// <summary>
		/// Instance accessor for this singleton
		/// </summary>
		private static RutasMaestroPeajesController MySingleObj;
		public static RutasMaestroPeajesController Instance
		{
			get
			{
				if (MySingleObj == null)
				{
					MySingleObj = new RutasMaestroPeajesController();
				}
				return MySingleObj;
			}
		}

		// Reads object's data from a DataRow
		private void ReadData(RutasMaestroPeajes rutasmaestropeajes, DataRow dr,bool generateUndo=false)
		{
			try 
			{
				rutasmaestropeajes.lngIdPeaje = (int) dr["lngIdPeaje"];
				rutasmaestropeajes.strNombrePeaje = dr.IsNull("strNombrePeaje") ? null :(string) dr["strNombrePeaje"];
				rutasmaestropeajes.Activo = (bool) dr["Activo"];
				rutasmaestropeajes.curValorTipo1 = dr.IsNull("curValorTipo1") ? null :(decimal?) dr["curValorTipo1"];
				rutasmaestropeajes.curValorTipo2 = dr.IsNull("curValorTipo2") ? null :(decimal?) dr["curValorTipo2"];
				rutasmaestropeajes.curValorTipo3 = dr.IsNull("curValorTipo3") ? null :(decimal?) dr["curValorTipo3"];
				rutasmaestropeajes.curValorTipo4 = dr.IsNull("curValorTipo4") ? null :(decimal?) dr["curValorTipo4"];
				rutasmaestropeajes.curValorTipo5 = dr.IsNull("curValorTipo5") ? null :(decimal?) dr["curValorTipo5"];
				rutasmaestropeajes.curValorTipo6 = dr.IsNull("curValorTipo6") ? null :(decimal?) dr["curValorTipo6"];
				rutasmaestropeajes.curValorTipo7 = dr.IsNull("curValorTipo7") ? null :(decimal?) dr["curValorTipo7"];
			}
			catch (Exception ex)
			{
				Utilidades.LogErrores(ex.Message + (ex.InnerException != null ? ex.InnerException.Message : ""), DataProvider.AplicacionNombre);
				throw ex;
			}
			if (generateUndo) rutasmaestropeajes.GenerateUndo();
		}

		/// <summary>
		/// Create a new RutasMaestroPeajes object by passing a object
		/// </summary>
		public RutasMaestroPeajes Create(RutasMaestroPeajes rutasmaestropeajes, Sinapsys.Datos.SQL datosTransaccion=null)
		{
			return Create(rutasmaestropeajes.lngIdPeaje,rutasmaestropeajes.strNombrePeaje,rutasmaestropeajes.Activo,rutasmaestropeajes.curValorTipo1,rutasmaestropeajes.curValorTipo2,rutasmaestropeajes.curValorTipo3,rutasmaestropeajes.curValorTipo4,rutasmaestropeajes.curValorTipo5,rutasmaestropeajes.curValorTipo6,rutasmaestropeajes.curValorTipo7,datosTransaccion);
		}

		/// <summary>
		/// Creates a new RutasMaestroPeajes object by passing all object's fields
		/// </summary>
		/// <param name="strNombrePeaje">string that contents the strNombrePeaje value for the RutasMaestroPeajes object</param>
		/// <param name="Activo">bool that contents the Activo value for the RutasMaestroPeajes object</param>
		/// <param name="curValorTipo1">decimal that contents the curValorTipo1 value for the RutasMaestroPeajes object</param>
		/// <param name="curValorTipo2">decimal that contents the curValorTipo2 value for the RutasMaestroPeajes object</param>
		/// <param name="curValorTipo3">decimal that contents the curValorTipo3 value for the RutasMaestroPeajes object</param>
		/// <param name="curValorTipo4">decimal that contents the curValorTipo4 value for the RutasMaestroPeajes object</param>
		/// <param name="curValorTipo5">decimal that contents the curValorTipo5 value for the RutasMaestroPeajes object</param>
		/// <param name="curValorTipo6">decimal that contents the curValorTipo6 value for the RutasMaestroPeajes object</param>
		/// <param name="curValorTipo7">decimal that contents the curValorTipo7 value for the RutasMaestroPeajes object</param>
		/// <returns>One RutasMaestroPeajes object</returns>
		public RutasMaestroPeajes Create(int lngIdPeaje, string strNombrePeaje, bool Activo, decimal? curValorTipo1, decimal? curValorTipo2, decimal? curValorTipo3, decimal? curValorTipo4, decimal? curValorTipo5, decimal? curValorTipo6, decimal? curValorTipo7, Sinapsys.Datos.SQL datosTransaccion=null)
		{
			try 
			{
				RutasMaestroPeajes rutasmaestropeajes = new RutasMaestroPeajes();

				rutasmaestropeajes.lngIdPeaje = lngIdPeaje;
				rutasmaestropeajes.lngIdPeaje = lngIdPeaje;
				rutasmaestropeajes.strNombrePeaje = strNombrePeaje;
				rutasmaestropeajes.Activo = Activo;
				rutasmaestropeajes.curValorTipo1 = curValorTipo1;
				rutasmaestropeajes.curValorTipo2 = curValorTipo2;
				rutasmaestropeajes.curValorTipo3 = curValorTipo3;
				rutasmaestropeajes.curValorTipo4 = curValorTipo4;
				rutasmaestropeajes.curValorTipo5 = curValorTipo5;
				rutasmaestropeajes.curValorTipo6 = curValorTipo6;
				rutasmaestropeajes.curValorTipo7 = curValorTipo7;
				lngIdPeaje = RutasMaestroPeajesDataProvider.Instance.Create(lngIdPeaje, strNombrePeaje, Activo, curValorTipo1, curValorTipo2, curValorTipo3, curValorTipo4, curValorTipo5, curValorTipo6, curValorTipo7,"RutasMaestroPeajes",datosTransaccion);
				if (lngIdPeaje == 0)
					return null;

				rutasmaestropeajes.lngIdPeaje = lngIdPeaje;

				return rutasmaestropeajes;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Updates an RutasMaestroPeajes object by passing all object's fields
		/// </summary>
		/// <param name="lngIdPeaje">int that contents the lngIdPeaje value for the RutasMaestroPeajes object</param>
		/// <param name="strNombrePeaje">string that contents the strNombrePeaje value for the RutasMaestroPeajes object</param>
		/// <param name="Activo">bool that contents the Activo value for the RutasMaestroPeajes object</param>
		/// <param name="curValorTipo1">decimal that contents the curValorTipo1 value for the RutasMaestroPeajes object</param>
		/// <param name="curValorTipo2">decimal that contents the curValorTipo2 value for the RutasMaestroPeajes object</param>
		/// <param name="curValorTipo3">decimal that contents the curValorTipo3 value for the RutasMaestroPeajes object</param>
		/// <param name="curValorTipo4">decimal that contents the curValorTipo4 value for the RutasMaestroPeajes object</param>
		/// <param name="curValorTipo5">decimal that contents the curValorTipo5 value for the RutasMaestroPeajes object</param>
		/// <param name="curValorTipo6">decimal that contents the curValorTipo6 value for the RutasMaestroPeajes object</param>
		/// <param name="curValorTipo7">decimal that contents the curValorTipo7 value for the RutasMaestroPeajes object</param>
		public void Update(int lngIdPeaje, string strNombrePeaje, bool Activo, decimal? curValorTipo1, decimal? curValorTipo2, decimal? curValorTipo3, decimal? curValorTipo4, decimal? curValorTipo5, decimal? curValorTipo6, decimal? curValorTipo7, Sinapsys.Datos.SQL datosTransaccion=null)
		{
			try 
			{
				RutasMaestroPeajes new_values = new RutasMaestroPeajes();
				new_values.strNombrePeaje = strNombrePeaje;
				new_values.Activo = Activo;
				new_values.curValorTipo1 = curValorTipo1;
				new_values.curValorTipo2 = curValorTipo2;
				new_values.curValorTipo3 = curValorTipo3;
				new_values.curValorTipo4 = curValorTipo4;
				new_values.curValorTipo5 = curValorTipo5;
				new_values.curValorTipo6 = curValorTipo6;
				new_values.curValorTipo7 = curValorTipo7;
				RutasMaestroPeajesDataProvider.Instance.Update(lngIdPeaje, strNombrePeaje, Activo, curValorTipo1, curValorTipo2, curValorTipo3, curValorTipo4, curValorTipo5, curValorTipo6, curValorTipo7,"RutasMaestroPeajes",datosTransaccion);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Updates an RutasMaestroPeajes object by passing one object's instance as reference
		/// </summary>
		/// <param name="rutasmaestropeajes">An instance of RutasMaestroPeajes for reference</param>
		public void Update(RutasMaestroPeajes rutasmaestropeajes,Sinapsys.Datos.SQL datosTransaccion=null)
		{
			Update(rutasmaestropeajes.lngIdPeaje, rutasmaestropeajes.strNombrePeaje, rutasmaestropeajes.Activo, rutasmaestropeajes.curValorTipo1, rutasmaestropeajes.curValorTipo2, rutasmaestropeajes.curValorTipo3, rutasmaestropeajes.curValorTipo4, rutasmaestropeajes.curValorTipo5, rutasmaestropeajes.curValorTipo6, rutasmaestropeajes.curValorTipo7);
		}

		/// <summary>
		/// Delete  the RutasMaestroPeajes object by passing a object
		/// </summary>
		public void  Delete(RutasMaestroPeajes rutasmaestropeajes, Sinapsys.Datos.SQL datosTransaccion=null)
		{
			Delete(rutasmaestropeajes.lngIdPeaje,datosTransaccion);
		}

		/// <summary>
		/// Deletes the RutasMaestroPeajes object by passing one object's instance as reference
		/// </summary>
		/// <param name="rutasmaestropeajes">An instance of RutasMaestroPeajes for reference</param>
		public void Delete(int lngIdPeaje, Sinapsys.Datos.SQL datosTransaccion=null)
		{
			try 
			{
				//RutasMaestroPeajes old_values = RutasMaestroPeajesController.Instance.Get(lngIdPeaje);
				//if(!Validate.security.CanDeleteSecurityField(RutasMaestroPeajesController.Instance, (ILatinodeObject)old_values))
				//    throw new Exception("Access denied by security field, you can't delete object");

				RutasMaestroPeajesDataProvider.Instance.Delete(lngIdPeaje,"RutasMaestroPeajes");
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Deletes the RutasMaestroPeajes object by passing CVS parameter as reference
		/// </summary>
		/// <param name="rutasmaestropeajes">An instance of RutasMaestroPeajes for reference</param>
		public void Delete(string CVSParameter)
		{
			string[] StrCommand=CVSParameter.Split(',');
			try 
			{
				int lngIdPeaje=int.Parse(StrCommand[0]);
				RutasMaestroPeajesDataProvider.Instance.Delete(lngIdPeaje,"RutasMaestroPeajes");
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Gets the RutasMaestroPeajes object by passing the object's key fields
		/// </summary>
		/// <param name="lngIdPeaje">int that contents the lngIdPeaje value for the RutasMaestroPeajes object</param>
		/// <returns>One RutasMaestroPeajes object</returns>
		public RutasMaestroPeajes Get(int lngIdPeaje, bool generateUndo=false)
		{
			try 
			{
				RutasMaestroPeajes rutasmaestropeajes = null;
				rutasmaestropeajes= MasterTables.RutasMaestroPeajes.Where(r => r.lngIdPeaje== lngIdPeaje).FirstOrDefault();
				if (rutasmaestropeajes== null)
				{
					MasterTables.Reset("RutasMaestroPeajes");
					rutasmaestropeajes= MasterTables.RutasMaestroPeajes.Where(r => r.lngIdPeaje== lngIdPeaje).FirstOrDefault();
				}
				if (generateUndo) rutasmaestropeajes.GenerateUndo();

				return rutasmaestropeajes;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Gets all objects of RutasMaestroPeajes
		/// </summary>
		/// <returns>One RutasMaestroPeajesList object</returns>
		public RutasMaestroPeajesList GetAll(bool generateUndo=false)
		{
			try 
			{
				RutasMaestroPeajesList rutasmaestropeajeslist = new RutasMaestroPeajesList();
				DataTable dt = RutasMaestroPeajesDataProvider.Instance.GetAll();
				foreach (DataRow dr in dt.Rows)
				{
					RutasMaestroPeajes rutasmaestropeajes = new RutasMaestroPeajes();
					ReadData(rutasmaestropeajes, dr, generateUndo);
					rutasmaestropeajeslist.Add(rutasmaestropeajes);
				}
				return rutasmaestropeajeslist;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Gets all objects of RutasMaestroPeajes applying filter and sort criteria
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
		/// <returns>One RutasMaestroPeajesList object</returns>
		public RutasMaestroPeajesList GetFilter(int pagenum, int pagesize, string filter, string sort, string extablesfilter, string extablesfieldsfilter, string extablesrelationsfilter, string extablessort, string extablesfieldssort, string extablesrelationssort, bool generateUndo=false)
		{
			try 
			{
				RutasMaestroPeajesList rutasmaestropeajeslist = new RutasMaestroPeajesList();

				DataTable dt = RutasMaestroPeajesDataProvider.Instance.GetFilter(pagenum, pagesize, filter, sort, extablesfilter, extablesfieldsfilter, extablesrelationsfilter, extablessort, extablesfieldssort, extablesrelationssort);

				foreach (DataRow dr in dt.Rows)
				{
					RutasMaestroPeajes rutasmaestropeajes = new RutasMaestroPeajes();
					ReadData(rutasmaestropeajes, dr, generateUndo);
					rutasmaestropeajeslist.Add(rutasmaestropeajes);
				}
				return rutasmaestropeajeslist;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public RutasMaestroPeajesList GetFilter( string filter, string sort, bool generateUndo=false)
		{
			return GetFilter(0,0, filter, sort, "","","","","","",generateUndo);
		}

		public RutasMaestroPeajesList GetFilter(string filter, string sort, string extablesfilter, string extablesfieldsfilter, string extablesrelationsfilter, string extablessort, string extablesfieldssort, string extablesrelationssort, bool generateUndo=false)
		{
			return GetFilter(0,0, filter, sort, extablesfilter, extablesfieldsfilter, extablesrelationsfilter, extablessort, extablesfieldssort, extablesrelationssort,generateUndo);
		}


		/// <summary>
		/// Returns the type for one property
		/// </summary>
		/// <param name="propertyname">Property's name for return its value</param>
		/// <returns>A value for the <paramref name="propertyname"/></returns>
		public Type GetMethodType( string propertyname,RutasMaestroPeajes rutasmaestropeajes)
		{
			// Perform the search for the property's value
			switch (propertyname)
			{
				case "lngIdPeaje":
					return rutasmaestropeajes.lngIdPeaje.GetType();

				case "strNombrePeaje":
					return rutasmaestropeajes.strNombrePeaje.GetType();

				case "Activo":
					return rutasmaestropeajes.Activo.GetType();

				case "curValorTipo1":
					return rutasmaestropeajes.curValorTipo1.GetType();

				case "curValorTipo2":
					return rutasmaestropeajes.curValorTipo2.GetType();

				case "curValorTipo3":
					return rutasmaestropeajes.curValorTipo3.GetType();

				case "curValorTipo4":
					return rutasmaestropeajes.curValorTipo4.GetType();

				case "curValorTipo5":
					return rutasmaestropeajes.curValorTipo5.GetType();

				case "curValorTipo6":
					return rutasmaestropeajes.curValorTipo6.GetType();

				case "curValorTipo7":
					return rutasmaestropeajes.curValorTipo7.GetType();

			}

			return null;
		}
		/// <summary>
		/// update the changes in RutasMaestroPeajes object by passing the object
		/// </summary>
		public bool UpdateChanges(RutasMaestroPeajes rutasmaestropeajes, out string error,Sinapsys.Datos.SQL datosTransaccion=null)
		{
			if (rutasmaestropeajes.OldRutasMaestroPeajes == null)
			{
				    error = "No tiene objeto con el cual comparar";
				    return false;
			}
			string[] Fields = rutasmaestropeajes.FieldChanged();
			error = "";
			return LiqViajes_Bll_Data.DataProvider.UpdateFieldsbyObject(Fields, rutasmaestropeajes, out error,datosTransaccion);
		}
	}

	#endregion

}
