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
	#region RangoKilometrosController

	/// <summary>
	/// Class for convert data from database into object's data and vice versa
	/// </summary>
	public partial class RangoKilometrosController//: ILatinodeController
	{
		/// <summary>
		/// Generic Constructor
		/// </summary>
		public RangoKilometrosController()
		{
		}

		/// <summary>
		/// Instance accessor for this singleton
		/// </summary>
		private static RangoKilometrosController MySingleObj;
		public static RangoKilometrosController Instance
		{
			get
			{
				if (MySingleObj == null)
				{
					MySingleObj = new RangoKilometrosController();
				}
				return MySingleObj;
			}
		}

		// Reads object's data from a DataRow
		private void ReadData(RangoKilometros rangokilometros, DataRow dr,bool generateUndo=false)
		{
			try 
			{
				rangokilometros.Codigo = (int) dr["Codigo"];
				rangokilometros.RangoInicial = (float) dr["RangoInicial"];
				rangokilometros.RangoFinal = (float) dr["RangoFinal"];
				rangokilometros.Kilometros = (float) dr["Kilometros"];
				rangokilometros.Valor = (decimal) dr["Valor"];
			}
			catch (Exception ex)
			{
				Utilidades.LogErrores(ex.Message + (ex.InnerException != null ? ex.InnerException.Message : ""), DataProvider.AplicacionNombre);
				throw ex;
			}
			if (generateUndo) rangokilometros.GenerateUndo();
		}

		/// <summary>
		/// Create a new RangoKilometros object by passing a object
		/// </summary>
		public RangoKilometros Create(RangoKilometros rangokilometros, Sinapsys.Datos.SQL datosTransaccion=null)
		{
			return Create(rangokilometros.Codigo,rangokilometros.RangoInicial,rangokilometros.RangoFinal,rangokilometros.Kilometros,rangokilometros.Valor,datosTransaccion);
		}

		/// <summary>
		/// Creates a new RangoKilometros object by passing all object's fields
		/// </summary>
		/// <param name="RangoInicial">float that contents the RangoInicial value for the RangoKilometros object</param>
		/// <param name="RangoFinal">float that contents the RangoFinal value for the RangoKilometros object</param>
		/// <param name="Kilometros">float that contents the Kilometros value for the RangoKilometros object</param>
		/// <param name="Valor">decimal that contents the Valor value for the RangoKilometros object</param>
		/// <returns>One RangoKilometros object</returns>
		public RangoKilometros Create(int Codigo, float RangoInicial, float RangoFinal, float Kilometros, decimal Valor, Sinapsys.Datos.SQL datosTransaccion=null)
		{
			try 
			{
				RangoKilometros rangokilometros = new RangoKilometros();

				rangokilometros.Codigo = Codigo;
				rangokilometros.Codigo = Codigo;
				rangokilometros.RangoInicial = RangoInicial;
				rangokilometros.RangoFinal = RangoFinal;
				rangokilometros.Kilometros = Kilometros;
				rangokilometros.Valor = Valor;
				Codigo = RangoKilometrosDataProvider.Instance.Create(Codigo, RangoInicial, RangoFinal, Kilometros, Valor,"RangoKilometros",datosTransaccion);
				if (Codigo == 0)
					return null;

				rangokilometros.Codigo = Codigo;

				return rangokilometros;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Updates an RangoKilometros object by passing all object's fields
		/// </summary>
		/// <param name="Codigo">int that contents the Codigo value for the RangoKilometros object</param>
		/// <param name="RangoInicial">float that contents the RangoInicial value for the RangoKilometros object</param>
		/// <param name="RangoFinal">float that contents the RangoFinal value for the RangoKilometros object</param>
		/// <param name="Kilometros">float that contents the Kilometros value for the RangoKilometros object</param>
		/// <param name="Valor">decimal that contents the Valor value for the RangoKilometros object</param>
		public void Update(int Codigo, float RangoInicial, float RangoFinal, float Kilometros, decimal Valor, Sinapsys.Datos.SQL datosTransaccion=null)
		{
			try 
			{
				RangoKilometros new_values = new RangoKilometros();
				new_values.RangoInicial = RangoInicial;
				new_values.RangoFinal = RangoFinal;
				new_values.Kilometros = Kilometros;
				new_values.Valor = Valor;
				RangoKilometrosDataProvider.Instance.Update(Codigo, RangoInicial, RangoFinal, Kilometros, Valor,"RangoKilometros",datosTransaccion);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Updates an RangoKilometros object by passing one object's instance as reference
		/// </summary>
		/// <param name="rangokilometros">An instance of RangoKilometros for reference</param>
		public void Update(RangoKilometros rangokilometros,Sinapsys.Datos.SQL datosTransaccion=null)
		{
			Update(rangokilometros.Codigo, rangokilometros.RangoInicial, rangokilometros.RangoFinal, rangokilometros.Kilometros, rangokilometros.Valor);
		}

		/// <summary>
		/// Delete  the RangoKilometros object by passing a object
		/// </summary>
		public void  Delete(RangoKilometros rangokilometros, Sinapsys.Datos.SQL datosTransaccion=null)
		{
			Delete(rangokilometros.Codigo,datosTransaccion);
		}

		/// <summary>
		/// Deletes the RangoKilometros object by passing one object's instance as reference
		/// </summary>
		/// <param name="rangokilometros">An instance of RangoKilometros for reference</param>
		public void Delete(int Codigo, Sinapsys.Datos.SQL datosTransaccion=null)
		{
			try 
			{
				//RangoKilometros old_values = RangoKilometrosController.Instance.Get(Codigo);
				//if(!Validate.security.CanDeleteSecurityField(RangoKilometrosController.Instance, (ILatinodeObject)old_values))
				//    throw new Exception("Access denied by security field, you can't delete object");

				RangoKilometrosDataProvider.Instance.Delete(Codigo,"RangoKilometros");
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Deletes the RangoKilometros object by passing CVS parameter as reference
		/// </summary>
		/// <param name="rangokilometros">An instance of RangoKilometros for reference</param>
		public void Delete(string CVSParameter)
		{
			string[] StrCommand=CVSParameter.Split(',');
			try 
			{
				int Codigo=int.Parse(StrCommand[0]);
				RangoKilometrosDataProvider.Instance.Delete(Codigo,"RangoKilometros");
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Gets the RangoKilometros object by passing the object's key fields
		/// </summary>
		/// <param name="Codigo">int that contents the Codigo value for the RangoKilometros object</param>
		/// <returns>One RangoKilometros object</returns>
		public RangoKilometros Get(int Codigo, bool generateUndo=false)
		{
			try 
			{
				RangoKilometros rangokilometros = null;
				DataTable dt = RangoKilometrosDataProvider.Instance.Get(Codigo);
				if ((dt.Rows.Count > 0))
				{
					rangokilometros = new RangoKilometros();
					DataRow dr = dt.Rows[0];
					ReadData(rangokilometros, dr, generateUndo);
				}


				return rangokilometros;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Gets all objects of RangoKilometros
		/// </summary>
		/// <returns>One RangoKilometrosList object</returns>
		public RangoKilometrosList GetAll(bool generateUndo=false)
		{
			try 
			{
				RangoKilometrosList rangokilometroslist = new RangoKilometrosList();
				DataTable dt = RangoKilometrosDataProvider.Instance.GetAll();
				foreach (DataRow dr in dt.Rows)
				{
					RangoKilometros rangokilometros = new RangoKilometros();
					ReadData(rangokilometros, dr, generateUndo);
					rangokilometroslist.Add(rangokilometros);
				}
				return rangokilometroslist;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Gets all objects of RangoKilometros applying filter and sort criteria
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
		/// <returns>One RangoKilometrosList object</returns>
		public RangoKilometrosList GetFilter(int pagenum, int pagesize, string filter, string sort, string extablesfilter, string extablesfieldsfilter, string extablesrelationsfilter, string extablessort, string extablesfieldssort, string extablesrelationssort, bool generateUndo=false)
		{
			try 
			{
				RangoKilometrosList rangokilometroslist = new RangoKilometrosList();

				DataTable dt = RangoKilometrosDataProvider.Instance.GetFilter(pagenum, pagesize, filter, sort, extablesfilter, extablesfieldsfilter, extablesrelationsfilter, extablessort, extablesfieldssort, extablesrelationssort);

				foreach (DataRow dr in dt.Rows)
				{
					RangoKilometros rangokilometros = new RangoKilometros();
					ReadData(rangokilometros, dr, generateUndo);
					rangokilometroslist.Add(rangokilometros);
				}
				return rangokilometroslist;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public RangoKilometrosList GetFilter( string filter, string sort, bool generateUndo=false)
		{
			return GetFilter(0,0, filter, sort, "","","","","","",generateUndo);
		}

		public RangoKilometrosList GetFilter(string filter, string sort, string extablesfilter, string extablesfieldsfilter, string extablesrelationsfilter, string extablessort, string extablesfieldssort, string extablesrelationssort, bool generateUndo=false)
		{
			return GetFilter(0,0, filter, sort, extablesfilter, extablesfieldsfilter, extablesrelationsfilter, extablessort, extablesfieldssort, extablesrelationssort,generateUndo);
		}


		/// <summary>
		/// Returns the type for one property
		/// </summary>
		/// <param name="propertyname">Property's name for return its value</param>
		/// <returns>A value for the <paramref name="propertyname"/></returns>
		public Type GetMethodType( string propertyname,RangoKilometros rangokilometros)
		{
			// Perform the search for the property's value
			switch (propertyname)
			{
				case "Codigo":
					return rangokilometros.Codigo.GetType();

				case "RangoInicial":
					return rangokilometros.RangoInicial.GetType();

				case "RangoFinal":
					return rangokilometros.RangoFinal.GetType();

				case "Kilometros":
					return rangokilometros.Kilometros.GetType();

				case "Valor":
					return rangokilometros.Valor.GetType();

			}

			return null;
		}
		/// <summary>
		/// update the changes in RangoKilometros object by passing the object
		/// </summary>
		public bool UpdateChanges(RangoKilometros rangokilometros, out string error,Sinapsys.Datos.SQL datosTransaccion=null)
		{
			if (rangokilometros.OldRangoKilometros == null)
			{
				    error = "No tiene objeto con el cual comparar";
				    return false;
			}
			string[] Fields = rangokilometros.FieldChanged();
			error = "";
			return LiqViajes_Bll_Data.DataProvider.UpdateFieldsbyObject(Fields, rangokilometros, out error,datosTransaccion);
		}
	}

	#endregion

}
