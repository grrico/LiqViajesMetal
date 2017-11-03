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
	#region tablagLocalController

	/// <summary>
	/// Class for convert data from database into object's data and vice versa
	/// </summary>
	public partial class tablagLocalController//: ILatinodeController
	{
		/// <summary>
		/// Generic Constructor
		/// </summary>
		public tablagLocalController()
		{
		}

		/// <summary>
		/// Instance accessor for this singleton
		/// </summary>
		private static tablagLocalController MySingleObj;
		public static tablagLocalController Instance
		{
			get
			{
				if (MySingleObj == null)
				{
					MySingleObj = new tablagLocalController();
				}
				return MySingleObj;
			}
		}

		// Reads object's data from a DataRow
		private void ReadData(tablagLocal tablaglocal, DataRow dr,bool generateUndo=false)
		{
			try 
			{
				tablaglocal.ano = dr.IsNull("ano") ? null :(int?) dr["ano"];
				tablaglocal.periodo = dr.IsNull("periodo") ? null :(int?) dr["periodo"];
				tablaglocal.fecha = dr.IsNull("fecha") ? null :(DateTime?) dr["fecha"];
				tablaglocal.Codigo = (int) dr["Codigo"];
			}
			catch (Exception ex)
			{
				Utilidades.LogErrores(ex.Message + (ex.InnerException != null ? ex.InnerException.Message : ""), DataProvider.AplicacionNombre);
				throw ex;
			}
			if (generateUndo) tablaglocal.GenerateUndo();
		}

		/// <summary>
		/// Create a new tablagLocal object by passing a object
		/// </summary>
		public tablagLocal Create(tablagLocal tablaglocal, Sinapsys.Datos.SQL datosTransaccion=null)
		{
			return Create(tablaglocal.Codigo,tablaglocal.ano,tablaglocal.periodo,tablaglocal.fecha,datosTransaccion);
		}

		/// <summary>
		/// Creates a new tablagLocal object by passing all object's fields
		/// </summary>
		/// <param name="ano">int that contents the ano value for the tablagLocal object</param>
		/// <param name="periodo">int that contents the periodo value for the tablagLocal object</param>
		/// <param name="fecha">DateTime that contents the fecha value for the tablagLocal object</param>
		/// <returns>One tablagLocal object</returns>
		public tablagLocal Create(int Codigo, int? ano, int? periodo, DateTime? fecha, Sinapsys.Datos.SQL datosTransaccion=null)
		{
			try 
			{
				tablagLocal tablaglocal = new tablagLocal();

				tablaglocal.Codigo = Codigo;
				tablaglocal.ano = ano;
				tablaglocal.periodo = periodo;
				tablaglocal.fecha = fecha;
				tablagLocalDataProvider.Instance.Create(Codigo, ano, periodo, fecha,"tablagLocal");

				return tablaglocal;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Updates an tablagLocal object by passing all object's fields
		/// </summary>
		/// <param name="ano">int that contents the ano value for the tablagLocal object</param>
		/// <param name="periodo">int that contents the periodo value for the tablagLocal object</param>
		/// <param name="fecha">DateTime that contents the fecha value for the tablagLocal object</param>
		/// <param name="Codigo">int that contents the Codigo value for the tablagLocal object</param>
		public void Update(int? ano, int? periodo, DateTime? fecha, int Codigo, Sinapsys.Datos.SQL datosTransaccion=null)
		{
			try 
			{
				tablagLocal new_values = new tablagLocal();
				new_values.ano = ano;
				new_values.periodo = periodo;
				new_values.fecha = fecha;
				tablagLocalDataProvider.Instance.Update(ano, periodo, fecha, Codigo,"tablagLocal",datosTransaccion);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Updates an tablagLocal object by passing one object's instance as reference
		/// </summary>
		/// <param name="tablaglocal">An instance of tablagLocal for reference</param>
		public void Update(tablagLocal tablaglocal,Sinapsys.Datos.SQL datosTransaccion=null)
		{
			Update(tablaglocal.ano, tablaglocal.periodo, tablaglocal.fecha, tablaglocal.Codigo);
		}

		/// <summary>
		/// Delete  the tablagLocal object by passing a object
		/// </summary>
		public void  Delete(tablagLocal tablaglocal, Sinapsys.Datos.SQL datosTransaccion=null)
		{
			Delete(tablaglocal.Codigo,datosTransaccion);
		}

		/// <summary>
		/// Deletes the tablagLocal object by passing one object's instance as reference
		/// </summary>
		/// <param name="tablaglocal">An instance of tablagLocal for reference</param>
		public void Delete(int Codigo, Sinapsys.Datos.SQL datosTransaccion=null)
		{
			try 
			{
				tablagLocalDataProvider.Instance.Delete(Codigo,"tablagLocal");
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Deletes the tablagLocal object by passing CVS parameter as reference
		/// </summary>
		/// <param name="tablaglocal">An instance of tablagLocal for reference</param>
		public void Delete(string CVSParameter)
		{
			string[] StrCommand=CVSParameter.Split(',');
			try 
			{
				int Codigo=int.Parse(StrCommand[0]);
				tablagLocalDataProvider.Instance.Delete(Codigo,"tablagLocal");
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Gets the tablagLocal object by passing the object's key fields
		/// </summary>
		/// <param name="Codigo">int that contents the Codigo value for the tablagLocal object</param>
		/// <returns>One tablagLocal object</returns>
		public tablagLocal Get(int Codigo, bool generateUndo=false)
		{
			try 
			{
				tablagLocal tablaglocal = null;
				DataTable dt = tablagLocalDataProvider.Instance.Get(Codigo);
				if ((dt.Rows.Count > 0))
				{
					tablaglocal = new tablagLocal();
					DataRow dr = dt.Rows[0];
					ReadData(tablaglocal, dr, generateUndo);
				}


				return tablaglocal;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Gets all objects of tablagLocal
		/// </summary>
		/// <returns>One tablagLocalList object</returns>
		public tablagLocalList GetAll(bool generateUndo=false)
		{
			try 
			{
				tablagLocalList tablaglocallist = new tablagLocalList();
				DataTable dt = tablagLocalDataProvider.Instance.GetAll();
				foreach (DataRow dr in dt.Rows)
				{
					tablagLocal tablaglocal = new tablagLocal();
					ReadData(tablaglocal, dr, generateUndo);
					tablaglocallist.Add(tablaglocal);
				}
				return tablaglocallist;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Gets all objects of tablagLocal applying filter and sort criteria
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
		/// <returns>One tablagLocalList object</returns>
		public tablagLocalList GetFilter(int pagenum, int pagesize, string filter, string sort, string extablesfilter, string extablesfieldsfilter, string extablesrelationsfilter, string extablessort, string extablesfieldssort, string extablesrelationssort, bool generateUndo=false)
		{
			try 
			{
				tablagLocalList tablaglocallist = new tablagLocalList();

				DataTable dt = tablagLocalDataProvider.Instance.GetFilter(pagenum, pagesize, filter, sort, extablesfilter, extablesfieldsfilter, extablesrelationsfilter, extablessort, extablesfieldssort, extablesrelationssort);

				foreach (DataRow dr in dt.Rows)
				{
					tablagLocal tablaglocal = new tablagLocal();
					ReadData(tablaglocal, dr, generateUndo);
					tablaglocallist.Add(tablaglocal);
				}
				return tablaglocallist;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public tablagLocalList GetFilter( string filter, string sort, bool generateUndo=false)
		{
			return GetFilter(0,0, filter, sort, "","","","","","",generateUndo);
		}

		public tablagLocalList GetFilter(string filter, string sort, string extablesfilter, string extablesfieldsfilter, string extablesrelationsfilter, string extablessort, string extablesfieldssort, string extablesrelationssort, bool generateUndo=false)
		{
			return GetFilter(0,0, filter, sort, extablesfilter, extablesfieldsfilter, extablesrelationsfilter, extablessort, extablesfieldssort, extablesrelationssort,generateUndo);
		}


		/// <summary>
		/// Returns the type for one property
		/// </summary>
		/// <param name="propertyname">Property's name for return its value</param>
		/// <returns>A value for the <paramref name="propertyname"/></returns>
		public Type GetMethodType( string propertyname,tablagLocal tablaglocal)
		{
			// Perform the search for the property's value
			switch (propertyname)
			{
				case "ano":
					return tablaglocal.ano.GetType();

				case "periodo":
					return tablaglocal.periodo.GetType();

				case "fecha":
					return tablaglocal.fecha.GetType();

				case "Codigo":
					return tablaglocal.Codigo.GetType();

			}

			return null;
		}
		/// <summary>
		/// update the changes in tablagLocal object by passing the object
		/// </summary>
		public bool UpdateChanges(tablagLocal tablaglocal, out string error,Sinapsys.Datos.SQL datosTransaccion=null)
		{
			if (tablaglocal.OldtablagLocal == null)
			{
				    error = "No tiene objeto con el cual comparar";
				    return false;
			}
			string[] Fields = tablaglocal.FieldChanged();
			error = "";
			return LiqViajes_Bll_Data.DataProvider.UpdateFieldsbyObject(Fields, tablaglocal, out error,datosTransaccion);
		}
	}

	#endregion

}
