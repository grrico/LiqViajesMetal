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
	#region documentos_montoController

	/// <summary>
	/// Class for convert data from database into object's data and vice versa
	/// </summary>
	public partial class documentos_montoController//: ILatinodeController
	{
		/// <summary>
		/// Generic Constructor
		/// </summary>
		public documentos_montoController()
		{
		}

		/// <summary>
		/// Instance accessor for this singleton
		/// </summary>
		private static documentos_montoController MySingleObj;
		public static documentos_montoController Instance
		{
			get
			{
				if (MySingleObj == null)
				{
					MySingleObj = new documentos_montoController();
				}
				return MySingleObj;
			}
		}

		// Reads object's data from a DataRow
		private void ReadData(documentos_monto documentos_monto, DataRow dr,bool generateUndo=false)
		{
			try 
			{
				documentos_monto.tipo = (string) dr["tipo"];
				documentos_monto.numero = (int) dr["numero"];
				documentos_monto.monto = dr.IsNull("monto") ? null :(string) dr["monto"];
			}
			catch (Exception ex)
			{
				Utilidades.LogErrores(ex.Message + (ex.InnerException != null ? ex.InnerException.Message : ""), DataProvider.AplicacionNombre);
				throw ex;
			}
			if (generateUndo) documentos_monto.GenerateUndo();
		}

		/// <summary>
		/// Create a new documentos_monto object by passing a object
		/// </summary>
		public documentos_monto Create(documentos_monto documentos_monto, Sinapsys.Datos.SQL datosTransaccion=null)
		{
			return Create(documentos_monto.tipo,documentos_monto.numero,documentos_monto.monto,datosTransaccion);
		}

		/// <summary>
		/// Creates a new documentos_monto object by passing all object's fields
		/// </summary>
		/// <param name="monto">string that contents the monto value for the documentos_monto object</param>
		/// <returns>One documentos_monto object</returns>
		public documentos_monto Create(string tipo, int numero, string monto, Sinapsys.Datos.SQL datosTransaccion=null)
		{
			try 
			{
				documentos_monto documentos_monto = new documentos_monto();

				documentos_monto.tipo = tipo;
				documentos_monto.numero = numero;
				documentos_monto.monto = monto;
				documentos_montoDataProvider.Instance.Create(tipo, numero, monto,"documentos_monto");

				return documentos_monto;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Updates an documentos_monto object by passing all object's fields
		/// </summary>
		/// <param name="tipo">string that contents the tipo value for the documentos_monto object</param>
		/// <param name="numero">int that contents the numero value for the documentos_monto object</param>
		/// <param name="monto">string that contents the monto value for the documentos_monto object</param>
		public void Update(string tipo, int numero, string monto, Sinapsys.Datos.SQL datosTransaccion=null)
		{
			try 
			{
				documentos_monto new_values = new documentos_monto();
				new_values.monto = monto;
				documentos_montoDataProvider.Instance.Update(tipo, numero, monto,"documentos_monto",datosTransaccion);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Updates an documentos_monto object by passing one object's instance as reference
		/// </summary>
		/// <param name="documentos_monto">An instance of documentos_monto for reference</param>
		public void Update(documentos_monto documentos_monto,Sinapsys.Datos.SQL datosTransaccion=null)
		{
			Update(documentos_monto.tipo, documentos_monto.numero, documentos_monto.monto);
		}

		/// <summary>
		/// Delete  the documentos_monto object by passing a object
		/// </summary>
		public void  Delete(documentos_monto documentos_monto, Sinapsys.Datos.SQL datosTransaccion=null)
		{
			Delete(documentos_monto.tipo, documentos_monto.numero,datosTransaccion);
		}

		/// <summary>
		/// Deletes the documentos_monto object by passing one object's instance as reference
		/// </summary>
		/// <param name="documentos_monto">An instance of documentos_monto for reference</param>
		public void Delete(string tipo, int numero, Sinapsys.Datos.SQL datosTransaccion=null)
		{
			try 
			{
				documentos_montoDataProvider.Instance.Delete(tipo, numero,"documentos_monto");
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Deletes the documentos_monto object by passing CVS parameter as reference
		/// </summary>
		/// <param name="documentos_monto">An instance of documentos_monto for reference</param>
		public void Delete(string CVSParameter)
		{
			string[] StrCommand=CVSParameter.Split(',');
			try 
			{
				string tipo=StrCommand[0];
				int numero=int.Parse(StrCommand[1]);
				documentos_montoDataProvider.Instance.Delete(tipo, numero,"documentos_monto");
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Gets the documentos_monto object by passing the object's key fields
		/// </summary>
		/// <param name="tipo">string that contents the tipo value for the documentos_monto object</param>
		/// <param name="numero">int that contents the numero value for the documentos_monto object</param>
		/// <returns>One documentos_monto object</returns>
		public documentos_monto Get(string tipo, int numero, bool generateUndo=false)
		{
			try 
			{
				documentos_monto documentos_monto = null;
				DataTable dt = documentos_montoDataProvider.Instance.Get(tipo, numero);
				if ((dt.Rows.Count > 0))
				{
					documentos_monto = new documentos_monto();
					DataRow dr = dt.Rows[0];
					ReadData(documentos_monto, dr, generateUndo);
				}


				return documentos_monto;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Gets all objects of documentos_monto
		/// </summary>
		/// <returns>One documentos_montoList object</returns>
		public documentos_montoList GetAll(bool generateUndo=false)
		{
			try 
			{
				documentos_montoList documentos_montolist = new documentos_montoList();
				DataTable dt = documentos_montoDataProvider.Instance.GetAll();
				foreach (DataRow dr in dt.Rows)
				{
					documentos_monto documentos_monto = new documentos_monto();
					ReadData(documentos_monto, dr, generateUndo);
					documentos_montolist.Add(documentos_monto);
				}
				return documentos_montolist;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Gets all objects of documentos_monto applying filter and sort criteria
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
		/// <returns>One documentos_montoList object</returns>
		public documentos_montoList GetFilter(int pagenum, int pagesize, string filter, string sort, string extablesfilter, string extablesfieldsfilter, string extablesrelationsfilter, string extablessort, string extablesfieldssort, string extablesrelationssort, bool generateUndo=false)
		{
			try 
			{
				documentos_montoList documentos_montolist = new documentos_montoList();

				DataTable dt = documentos_montoDataProvider.Instance.GetFilter(pagenum, pagesize, filter, sort, extablesfilter, extablesfieldsfilter, extablesrelationsfilter, extablessort, extablesfieldssort, extablesrelationssort);

				foreach (DataRow dr in dt.Rows)
				{
					documentos_monto documentos_monto = new documentos_monto();
					ReadData(documentos_monto, dr, generateUndo);
					documentos_montolist.Add(documentos_monto);
				}
				return documentos_montolist;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public documentos_montoList GetFilter( string filter, string sort, bool generateUndo=false)
		{
			return GetFilter(0,0, filter, sort, "","","","","","",generateUndo);
		}

		public documentos_montoList GetFilter(string filter, string sort, string extablesfilter, string extablesfieldsfilter, string extablesrelationsfilter, string extablessort, string extablesfieldssort, string extablesrelationssort, bool generateUndo=false)
		{
			return GetFilter(0,0, filter, sort, extablesfilter, extablesfieldsfilter, extablesrelationsfilter, extablessort, extablesfieldssort, extablesrelationssort,generateUndo);
		}


		/// <summary>
		/// Returns the type for one property
		/// </summary>
		/// <param name="propertyname">Property's name for return its value</param>
		/// <returns>A value for the <paramref name="propertyname"/></returns>
		public Type GetMethodType( string propertyname,documentos_monto documentos_monto)
		{
			// Perform the search for the property's value
			switch (propertyname)
			{
				case "tipo":
					return documentos_monto.tipo.GetType();

				case "numero":
					return documentos_monto.numero.GetType();

				case "monto":
					return documentos_monto.monto.GetType();

			}

			return null;
		}
		/// <summary>
		/// update the changes in documentos_monto object by passing the object
		/// </summary>
		public bool UpdateChanges(documentos_monto documentos_monto, out string error,Sinapsys.Datos.SQL datosTransaccion=null)
		{
			if (documentos_monto.Olddocumentos_monto == null)
			{
				    error = "No tiene objeto con el cual comparar";
				    return false;
			}
			string[] Fields = documentos_monto.FieldChanged();
			error = "";
			return LiqViajes_Bll_Data.DataProvider.UpdateFieldsbyObject(Fields, documentos_monto, out error,datosTransaccion);
		}
	}

	#endregion

}
