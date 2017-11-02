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
	#region A2MontoEscritoController

	/// <summary>
	/// Class for convert data from database into object's data and vice versa
	/// </summary>
	public partial class A2MontoEscritoController//: ILatinodeController
	{
		/// <summary>
		/// Generic Constructor
		/// </summary>
		public A2MontoEscritoController()
		{
		}

		/// <summary>
		/// Instance accessor for this singleton
		/// </summary>
		private static A2MontoEscritoController MySingleObj;
		public static A2MontoEscritoController Instance
		{
			get
			{
				if (MySingleObj == null)
				{
					MySingleObj = new A2MontoEscritoController();
				}
				return MySingleObj;
			}
		}

		// Reads object's data from a DataRow
		private void ReadData(A2MontoEscrito a2montoescrito, DataRow dr,bool generateUndo=false)
		{
			try 
			{
				a2montoescrito.bytTipoCifra = (byte) dr["bytTipoCifra"];
				a2montoescrito.bytPosicionCifra = (byte) dr["bytPosicionCifra"];
				a2montoescrito.strCifra = dr.IsNull("strCifra") ? null :(string) dr["strCifra"];
			}
			catch (Exception ex)
			{
				Utilidades.LogErrores(ex.Message + (ex.InnerException != null ? ex.InnerException.Message : ""), DataProvider.AplicacionNombre);
				throw ex;
			}
			if (generateUndo) a2montoescrito.GenerateUndo();
		}

		/// <summary>
		/// Create a new A2MontoEscrito object by passing a object
		/// </summary>
		public A2MontoEscrito Create(A2MontoEscrito a2montoescrito, Sinapsys.Datos.SQL datosTransaccion=null)
		{
			return Create(a2montoescrito.bytTipoCifra,a2montoescrito.bytPosicionCifra,a2montoescrito.strCifra,datosTransaccion);
		}

		/// <summary>
		/// Creates a new A2MontoEscrito object by passing all object's fields
		/// </summary>
		/// <param name="bytTipoCifra">byte that contents the bytTipoCifra value for the A2MontoEscrito object</param>
		/// <param name="bytPosicionCifra">byte that contents the bytPosicionCifra value for the A2MontoEscrito object</param>
		/// <param name="strCifra">string that contents the strCifra value for the A2MontoEscrito object</param>
		/// <returns>One A2MontoEscrito object</returns>
		public A2MontoEscrito Create(byte bytTipoCifra, byte bytPosicionCifra, string strCifra, Sinapsys.Datos.SQL datosTransaccion=null)
		{
			try 
			{
				A2MontoEscrito a2montoescrito = new A2MontoEscrito();

				a2montoescrito.bytTipoCifra = bytTipoCifra;
				a2montoescrito.bytPosicionCifra = bytPosicionCifra;
				a2montoescrito.strCifra = strCifra;
				A2MontoEscritoDataProvider.Instance.Create(bytTipoCifra, bytPosicionCifra, strCifra,"A2MontoEscrito");

				return a2montoescrito;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Gets all objects of A2MontoEscrito
		/// </summary>
		/// <returns>One A2MontoEscritoList object</returns>
		public A2MontoEscritoList GetAll(bool generateUndo=false)
		{
			try 
			{
				A2MontoEscritoList a2montoescritolist = new A2MontoEscritoList();
				DataTable dt = A2MontoEscritoDataProvider.Instance.GetAll();
				foreach (DataRow dr in dt.Rows)
				{
					A2MontoEscrito a2montoescrito = new A2MontoEscrito();
					ReadData(a2montoescrito, dr, generateUndo);
					a2montoescritolist.Add(a2montoescrito);
				}
				return a2montoescritolist;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Gets all objects of A2MontoEscrito applying filter and sort criteria
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
		/// <returns>One A2MontoEscritoList object</returns>
		public A2MontoEscritoList GetFilter(int pagenum, int pagesize, string filter, string sort, string extablesfilter, string extablesfieldsfilter, string extablesrelationsfilter, string extablessort, string extablesfieldssort, string extablesrelationssort, bool generateUndo=false)
		{
			try 
			{
				A2MontoEscritoList a2montoescritolist = new A2MontoEscritoList();

				DataTable dt = A2MontoEscritoDataProvider.Instance.GetFilter(pagenum, pagesize, filter, sort, extablesfilter, extablesfieldsfilter, extablesrelationsfilter, extablessort, extablesfieldssort, extablesrelationssort);

				foreach (DataRow dr in dt.Rows)
				{
					A2MontoEscrito a2montoescrito = new A2MontoEscrito();
					ReadData(a2montoescrito, dr, generateUndo);
					a2montoescritolist.Add(a2montoescrito);
				}
				return a2montoescritolist;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public A2MontoEscritoList GetFilter( string filter, string sort, bool generateUndo=false)
		{
			return GetFilter(0,0, filter, sort, "","","","","","",generateUndo);
		}

		public A2MontoEscritoList GetFilter(string filter, string sort, string extablesfilter, string extablesfieldsfilter, string extablesrelationsfilter, string extablessort, string extablesfieldssort, string extablesrelationssort, bool generateUndo=false)
		{
			return GetFilter(0,0, filter, sort, extablesfilter, extablesfieldsfilter, extablesrelationsfilter, extablessort, extablesfieldssort, extablesrelationssort,generateUndo);
		}


		/// <summary>
		/// Returns the type for one property
		/// </summary>
		/// <param name="propertyname">Property's name for return its value</param>
		/// <returns>A value for the <paramref name="propertyname"/></returns>
		public Type GetMethodType( string propertyname,A2MontoEscrito a2montoescrito)
		{
			// Perform the search for the property's value
			switch (propertyname)
			{
				case "bytTipoCifra":
					return a2montoescrito.bytTipoCifra.GetType();

				case "bytPosicionCifra":
					return a2montoescrito.bytPosicionCifra.GetType();

				case "strCifra":
					return a2montoescrito.strCifra.GetType();

			}

			return null;
		}
		/// <summary>
		/// update the changes in A2MontoEscrito object by passing the object
		/// </summary>
		public bool UpdateChanges(A2MontoEscrito a2montoescrito, out string error,Sinapsys.Datos.SQL datosTransaccion=null)
		{
			if (a2montoescrito.OldA2MontoEscrito == null)
			{
				    error = "No tiene objeto con el cual comparar";
				    return false;
			}
			string[] Fields = a2montoescrito.FieldChanged();
			error = "";
			return LiqViajes_Bll_Data.DataProvider.UpdateFieldsbyObject(Fields, a2montoescrito, out error,datosTransaccion);
		}
	}

	#endregion

}
