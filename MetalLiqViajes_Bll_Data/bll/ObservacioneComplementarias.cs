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
	#region ObservacioneComplementariasController

	/// <summary>
	/// Class for convert data from database into object's data and vice versa
	/// </summary>
	public partial class ObservacioneComplementariasController//: ILatinodeController
	{
		/// <summary>
		/// Generic Constructor
		/// </summary>
		public ObservacioneComplementariasController()
		{
		}

		/// <summary>
		/// Instance accessor for this singleton
		/// </summary>
		private static ObservacioneComplementariasController MySingleObj;
		public static ObservacioneComplementariasController Instance
		{
			get
			{
				if (MySingleObj == null)
				{
					MySingleObj = new ObservacioneComplementariasController();
				}
				return MySingleObj;
			}
		}

		// Reads object's data from a DataRow
		private void ReadData(ObservacioneComplementarias observacionecomplementarias, DataRow dr,bool generateUndo=false)
		{
			try 
			{
				observacionecomplementarias.Origen = dr.IsNull("Origen") ? null :(string) dr["Origen"];
				observacionecomplementarias.Destino = dr.IsNull("Destino") ? null :(string) dr["Destino"];
				observacionecomplementarias.Cuenta = dr.IsNull("Cuenta") ? null :(string) dr["Cuenta"];
				observacionecomplementarias.Fila = dr.IsNull("Fila") ? null :(int?) dr["Fila"];
				observacionecomplementarias.DetalleObservacion = dr.IsNull("DetalleObservacion") ? null :(string) dr["DetalleObservacion"];
				observacionecomplementarias.Codigo = (int) dr["Codigo"];
			}
			catch (Exception ex)
			{
				Utilidades.LogErrores(ex.Message + (ex.InnerException != null ? ex.InnerException.Message : ""), DataProvider.AplicacionNombre);
				throw ex;
			}
			if (generateUndo) observacionecomplementarias.GenerateUndo();
		}

		/// <summary>
		/// Create a new ObservacioneComplementarias object by passing a object
		/// </summary>
		public ObservacioneComplementarias Create(ObservacioneComplementarias observacionecomplementarias, Sinapsys.Datos.SQL datosTransaccion=null)
		{
			return Create(observacionecomplementarias.Codigo,observacionecomplementarias.Origen,observacionecomplementarias.Destino,observacionecomplementarias.Cuenta,observacionecomplementarias.Fila,observacionecomplementarias.DetalleObservacion,datosTransaccion);
		}

		/// <summary>
		/// Creates a new ObservacioneComplementarias object by passing all object's fields
		/// </summary>
		/// <param name="Origen">string that contents the Origen value for the ObservacioneComplementarias object</param>
		/// <param name="Destino">string that contents the Destino value for the ObservacioneComplementarias object</param>
		/// <param name="Cuenta">string that contents the Cuenta value for the ObservacioneComplementarias object</param>
		/// <param name="Fila">int that contents the Fila value for the ObservacioneComplementarias object</param>
		/// <param name="DetalleObservacion">string that contents the DetalleObservacion value for the ObservacioneComplementarias object</param>
		/// <returns>One ObservacioneComplementarias object</returns>
		public ObservacioneComplementarias Create(int Codigo, string Origen, string Destino, string Cuenta, int? Fila, string DetalleObservacion, Sinapsys.Datos.SQL datosTransaccion=null)
		{
			try 
			{
				ObservacioneComplementarias observacionecomplementarias = new ObservacioneComplementarias();

				observacionecomplementarias.Codigo = Codigo;
				observacionecomplementarias.Codigo = Codigo;
				observacionecomplementarias.Origen = Origen;
				observacionecomplementarias.Destino = Destino;
				observacionecomplementarias.Cuenta = Cuenta;
				observacionecomplementarias.Fila = Fila;
				observacionecomplementarias.DetalleObservacion = DetalleObservacion;
				Codigo = ObservacioneComplementariasDataProvider.Instance.Create(Codigo, Origen, Destino, Cuenta, Fila, DetalleObservacion,"ObservacioneComplementarias",datosTransaccion);
				if (Codigo == 0)
					return null;

				observacionecomplementarias.Codigo = Codigo;

				return observacionecomplementarias;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Updates an ObservacioneComplementarias object by passing all object's fields
		/// </summary>
		/// <param name="Origen">string that contents the Origen value for the ObservacioneComplementarias object</param>
		/// <param name="Destino">string that contents the Destino value for the ObservacioneComplementarias object</param>
		/// <param name="Cuenta">string that contents the Cuenta value for the ObservacioneComplementarias object</param>
		/// <param name="Fila">int that contents the Fila value for the ObservacioneComplementarias object</param>
		/// <param name="DetalleObservacion">string that contents the DetalleObservacion value for the ObservacioneComplementarias object</param>
		/// <param name="Codigo">int that contents the Codigo value for the ObservacioneComplementarias object</param>
		public void Update(string Origen, string Destino, string Cuenta, int? Fila, string DetalleObservacion, int Codigo, Sinapsys.Datos.SQL datosTransaccion=null)
		{
			try 
			{
				ObservacioneComplementarias new_values = new ObservacioneComplementarias();
				new_values.Origen = Origen;
				new_values.Destino = Destino;
				new_values.Cuenta = Cuenta;
				new_values.Fila = Fila;
				new_values.DetalleObservacion = DetalleObservacion;
				ObservacioneComplementariasDataProvider.Instance.Update(Origen, Destino, Cuenta, Fila, DetalleObservacion, Codigo,"ObservacioneComplementarias",datosTransaccion);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Updates an ObservacioneComplementarias object by passing one object's instance as reference
		/// </summary>
		/// <param name="observacionecomplementarias">An instance of ObservacioneComplementarias for reference</param>
		public void Update(ObservacioneComplementarias observacionecomplementarias,Sinapsys.Datos.SQL datosTransaccion=null)
		{
			Update(observacionecomplementarias.Origen, observacionecomplementarias.Destino, observacionecomplementarias.Cuenta, observacionecomplementarias.Fila, observacionecomplementarias.DetalleObservacion, observacionecomplementarias.Codigo);
		}

		/// <summary>
		/// Delete  the ObservacioneComplementarias object by passing a object
		/// </summary>
		public void  Delete(ObservacioneComplementarias observacionecomplementarias, Sinapsys.Datos.SQL datosTransaccion=null)
		{
			Delete(observacionecomplementarias.Codigo,datosTransaccion);
		}

		/// <summary>
		/// Deletes the ObservacioneComplementarias object by passing one object's instance as reference
		/// </summary>
		/// <param name="observacionecomplementarias">An instance of ObservacioneComplementarias for reference</param>
		public void Delete(int Codigo, Sinapsys.Datos.SQL datosTransaccion=null)
		{
			try 
			{
				//ObservacioneComplementarias old_values = ObservacioneComplementariasController.Instance.Get(Codigo);
				//if(!Validate.security.CanDeleteSecurityField(ObservacioneComplementariasController.Instance, (ILatinodeObject)old_values))
				//    throw new Exception("Access denied by security field, you can't delete object");

				ObservacioneComplementariasDataProvider.Instance.Delete(Codigo,"ObservacioneComplementarias");
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Deletes the ObservacioneComplementarias object by passing CVS parameter as reference
		/// </summary>
		/// <param name="observacionecomplementarias">An instance of ObservacioneComplementarias for reference</param>
		public void Delete(string CVSParameter)
		{
			string[] StrCommand=CVSParameter.Split(',');
			try 
			{
				int Codigo=int.Parse(StrCommand[0]);
				ObservacioneComplementariasDataProvider.Instance.Delete(Codigo,"ObservacioneComplementarias");
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Gets the ObservacioneComplementarias object by passing the object's key fields
		/// </summary>
		/// <param name="Codigo">int that contents the Codigo value for the ObservacioneComplementarias object</param>
		/// <returns>One ObservacioneComplementarias object</returns>
		public ObservacioneComplementarias Get(int Codigo, bool generateUndo=false)
		{
			try 
			{
				ObservacioneComplementarias observacionecomplementarias = null;
				DataTable dt = ObservacioneComplementariasDataProvider.Instance.Get(Codigo);
				if ((dt.Rows.Count > 0))
				{
					observacionecomplementarias = new ObservacioneComplementarias();
					DataRow dr = dt.Rows[0];
					ReadData(observacionecomplementarias, dr, generateUndo);
				}


				return observacionecomplementarias;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Gets all objects of ObservacioneComplementarias
		/// </summary>
		/// <returns>One ObservacioneComplementariasList object</returns>
		public ObservacioneComplementariasList GetAll(bool generateUndo=false)
		{
			try 
			{
				ObservacioneComplementariasList observacionecomplementariaslist = new ObservacioneComplementariasList();
				DataTable dt = ObservacioneComplementariasDataProvider.Instance.GetAll();
				foreach (DataRow dr in dt.Rows)
				{
					ObservacioneComplementarias observacionecomplementarias = new ObservacioneComplementarias();
					ReadData(observacionecomplementarias, dr, generateUndo);
					observacionecomplementariaslist.Add(observacionecomplementarias);
				}
				return observacionecomplementariaslist;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Gets all objects of ObservacioneComplementarias applying filter and sort criteria
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
		/// <returns>One ObservacioneComplementariasList object</returns>
		public ObservacioneComplementariasList GetFilter(int pagenum, int pagesize, string filter, string sort, string extablesfilter, string extablesfieldsfilter, string extablesrelationsfilter, string extablessort, string extablesfieldssort, string extablesrelationssort, bool generateUndo=false)
		{
			try 
			{
				ObservacioneComplementariasList observacionecomplementariaslist = new ObservacioneComplementariasList();

				DataTable dt = ObservacioneComplementariasDataProvider.Instance.GetFilter(pagenum, pagesize, filter, sort, extablesfilter, extablesfieldsfilter, extablesrelationsfilter, extablessort, extablesfieldssort, extablesrelationssort);

				foreach (DataRow dr in dt.Rows)
				{
					ObservacioneComplementarias observacionecomplementarias = new ObservacioneComplementarias();
					ReadData(observacionecomplementarias, dr, generateUndo);
					observacionecomplementariaslist.Add(observacionecomplementarias);
				}
				return observacionecomplementariaslist;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public ObservacioneComplementariasList GetFilter( string filter, string sort, bool generateUndo=false)
		{
			return GetFilter(0,0, filter, sort, "","","","","","",generateUndo);
		}

		public ObservacioneComplementariasList GetFilter(string filter, string sort, string extablesfilter, string extablesfieldsfilter, string extablesrelationsfilter, string extablessort, string extablesfieldssort, string extablesrelationssort, bool generateUndo=false)
		{
			return GetFilter(0,0, filter, sort, extablesfilter, extablesfieldsfilter, extablesrelationsfilter, extablessort, extablesfieldssort, extablesrelationssort,generateUndo);
		}


		/// <summary>
		/// Returns the type for one property
		/// </summary>
		/// <param name="propertyname">Property's name for return its value</param>
		/// <returns>A value for the <paramref name="propertyname"/></returns>
		public Type GetMethodType( string propertyname,ObservacioneComplementarias observacionecomplementarias)
		{
			// Perform the search for the property's value
			switch (propertyname)
			{
				case "Origen":
					return observacionecomplementarias.Origen.GetType();

				case "Destino":
					return observacionecomplementarias.Destino.GetType();

				case "Cuenta":
					return observacionecomplementarias.Cuenta.GetType();

				case "Fila":
					return observacionecomplementarias.Fila.GetType();

				case "DetalleObservacion":
					return observacionecomplementarias.DetalleObservacion.GetType();

				case "Codigo":
					return observacionecomplementarias.Codigo.GetType();

			}

			return null;
		}
		/// <summary>
		/// update the changes in ObservacioneComplementarias object by passing the object
		/// </summary>
		public bool UpdateChanges(ObservacioneComplementarias observacionecomplementarias, out string error,Sinapsys.Datos.SQL datosTransaccion=null)
		{
			if (observacionecomplementarias.OldObservacioneComplementarias == null)
			{
				    error = "No tiene objeto con el cual comparar";
				    return false;
			}
			string[] Fields = observacionecomplementarias.FieldChanged();
			error = "";
			return LiqViajes_Bll_Data.DataProvider.UpdateFieldsbyObject(Fields, observacionecomplementarias, out error,datosTransaccion);
		}
	}

	#endregion

}
