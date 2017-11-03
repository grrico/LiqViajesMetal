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
	#region ParametrosController

	/// <summary>
	/// Class for convert data from database into object's data and vice versa
	/// </summary>
	public partial class ParametrosController//: ILatinodeController
	{
		/// <summary>
		/// Generic Constructor
		/// </summary>
		public ParametrosController()
		{
		}

		/// <summary>
		/// Instance accessor for this singleton
		/// </summary>
		private static ParametrosController MySingleObj;
		public static ParametrosController Instance
		{
			get
			{
				if (MySingleObj == null)
				{
					MySingleObj = new ParametrosController();
				}
				return MySingleObj;
			}
		}

		// Reads object's data from a DataRow
		private void ReadData(Parametros parametros, DataRow dr,bool generateUndo=false)
		{
			try 
			{
				parametros.intBanco = dr.IsNull("intBanco") ? null :(int?) dr["intBanco"];
				parametros.LogAvisarConductores = dr.IsNull("LogAvisarConductores") ? null :(bool?) dr["LogAvisarConductores"];
				parametros.lngIdParaMetro = (int) dr["lngIdParaMetro"];
			}
			catch (Exception ex)
			{
				Utilidades.LogErrores(ex.Message + (ex.InnerException != null ? ex.InnerException.Message : ""), DataProvider.AplicacionNombre);
				throw ex;
			}
			if (generateUndo) parametros.GenerateUndo();
		}

		/// <summary>
		/// Create a new Parametros object by passing a object
		/// </summary>
		public Parametros Create(Parametros parametros, Sinapsys.Datos.SQL datosTransaccion=null)
		{
			return Create(parametros.lngIdParaMetro,parametros.intBanco,parametros.LogAvisarConductores,datosTransaccion);
		}

		/// <summary>
		/// Creates a new Parametros object by passing all object's fields
		/// </summary>
		/// <param name="intBanco">int that contents the intBanco value for the Parametros object</param>
		/// <param name="LogAvisarConductores">bool that contents the LogAvisarConductores value for the Parametros object</param>
		/// <returns>One Parametros object</returns>
		public Parametros Create(int lngIdParaMetro, int? intBanco, bool? LogAvisarConductores, Sinapsys.Datos.SQL datosTransaccion=null)
		{
			try 
			{
				Parametros parametros = new Parametros();

				parametros.lngIdParaMetro = lngIdParaMetro;
				parametros.intBanco = intBanco;
				parametros.LogAvisarConductores = LogAvisarConductores;
				ParametrosDataProvider.Instance.Create(lngIdParaMetro, intBanco, LogAvisarConductores,"Parametros");

				return parametros;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Updates an Parametros object by passing all object's fields
		/// </summary>
		/// <param name="intBanco">int that contents the intBanco value for the Parametros object</param>
		/// <param name="LogAvisarConductores">bool that contents the LogAvisarConductores value for the Parametros object</param>
		/// <param name="lngIdParaMetro">int that contents the lngIdParaMetro value for the Parametros object</param>
		public void Update(int? intBanco, bool? LogAvisarConductores, int lngIdParaMetro, Sinapsys.Datos.SQL datosTransaccion=null)
		{
			try 
			{
				Parametros new_values = new Parametros();
				new_values.intBanco = intBanco;
				new_values.LogAvisarConductores = LogAvisarConductores;
				ParametrosDataProvider.Instance.Update(intBanco, LogAvisarConductores, lngIdParaMetro,"Parametros",datosTransaccion);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Updates an Parametros object by passing one object's instance as reference
		/// </summary>
		/// <param name="parametros">An instance of Parametros for reference</param>
		public void Update(Parametros parametros,Sinapsys.Datos.SQL datosTransaccion=null)
		{
			Update(parametros.intBanco, parametros.LogAvisarConductores, parametros.lngIdParaMetro);
		}

		/// <summary>
		/// Delete  the Parametros object by passing a object
		/// </summary>
		public void  Delete(Parametros parametros, Sinapsys.Datos.SQL datosTransaccion=null)
		{
			Delete(parametros.lngIdParaMetro,datosTransaccion);
		}

		/// <summary>
		/// Deletes the Parametros object by passing one object's instance as reference
		/// </summary>
		/// <param name="parametros">An instance of Parametros for reference</param>
		public void Delete(int lngIdParaMetro, Sinapsys.Datos.SQL datosTransaccion=null)
		{
			try 
			{
				ParametrosDataProvider.Instance.Delete(lngIdParaMetro,"Parametros");
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Deletes the Parametros object by passing CVS parameter as reference
		/// </summary>
		/// <param name="parametros">An instance of Parametros for reference</param>
		public void Delete(string CVSParameter)
		{
			string[] StrCommand=CVSParameter.Split(',');
			try 
			{
				int lngIdParaMetro=int.Parse(StrCommand[0]);
				ParametrosDataProvider.Instance.Delete(lngIdParaMetro,"Parametros");
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Gets the Parametros object by passing the object's key fields
		/// </summary>
		/// <param name="lngIdParaMetro">int that contents the lngIdParaMetro value for the Parametros object</param>
		/// <returns>One Parametros object</returns>
		public Parametros Get(int lngIdParaMetro, bool generateUndo=false)
		{
			try 
			{
				Parametros parametros = null;
				parametros= MasterTables.Parametros.Where(r => r.lngIdParaMetro== lngIdParaMetro).FirstOrDefault();
				if (parametros== null)
				{
					MasterTables.Reset("Parametros");
					parametros= MasterTables.Parametros.Where(r => r.lngIdParaMetro== lngIdParaMetro).FirstOrDefault();
				}
				if (generateUndo) parametros.GenerateUndo();

				return parametros;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Gets all objects of Parametros
		/// </summary>
		/// <returns>One ParametrosList object</returns>
		public ParametrosList GetAll(bool generateUndo=false)
		{
			try 
			{
				ParametrosList parametroslist = new ParametrosList();
				DataTable dt = ParametrosDataProvider.Instance.GetAll();
				foreach (DataRow dr in dt.Rows)
				{
					Parametros parametros = new Parametros();
					ReadData(parametros, dr, generateUndo);
					parametroslist.Add(parametros);
				}
				return parametroslist;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Gets all objects of Parametros applying filter and sort criteria
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
		/// <returns>One ParametrosList object</returns>
		public ParametrosList GetFilter(int pagenum, int pagesize, string filter, string sort, string extablesfilter, string extablesfieldsfilter, string extablesrelationsfilter, string extablessort, string extablesfieldssort, string extablesrelationssort, bool generateUndo=false)
		{
			try 
			{
				ParametrosList parametroslist = new ParametrosList();

				DataTable dt = ParametrosDataProvider.Instance.GetFilter(pagenum, pagesize, filter, sort, extablesfilter, extablesfieldsfilter, extablesrelationsfilter, extablessort, extablesfieldssort, extablesrelationssort);

				foreach (DataRow dr in dt.Rows)
				{
					Parametros parametros = new Parametros();
					ReadData(parametros, dr, generateUndo);
					parametroslist.Add(parametros);
				}
				return parametroslist;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public ParametrosList GetFilter( string filter, string sort, bool generateUndo=false)
		{
			return GetFilter(0,0, filter, sort, "","","","","","",generateUndo);
		}

		public ParametrosList GetFilter(string filter, string sort, string extablesfilter, string extablesfieldsfilter, string extablesrelationsfilter, string extablessort, string extablesfieldssort, string extablesrelationssort, bool generateUndo=false)
		{
			return GetFilter(0,0, filter, sort, extablesfilter, extablesfieldsfilter, extablesrelationsfilter, extablessort, extablesfieldssort, extablesrelationssort,generateUndo);
		}


		/// <summary>
		/// Returns the type for one property
		/// </summary>
		/// <param name="propertyname">Property's name for return its value</param>
		/// <returns>A value for the <paramref name="propertyname"/></returns>
		public Type GetMethodType( string propertyname,Parametros parametros)
		{
			// Perform the search for the property's value
			switch (propertyname)
			{
				case "intBanco":
					return parametros.intBanco.GetType();

				case "LogAvisarConductores":
					return parametros.LogAvisarConductores.GetType();

				case "lngIdParaMetro":
					return parametros.lngIdParaMetro.GetType();

			}

			return null;
		}
		/// <summary>
		/// update the changes in Parametros object by passing the object
		/// </summary>
		public bool UpdateChanges(Parametros parametros, out string error,Sinapsys.Datos.SQL datosTransaccion=null)
		{
			if (parametros.OldParametros == null)
			{
				    error = "No tiene objeto con el cual comparar";
				    return false;
			}
			string[] Fields = parametros.FieldChanged();
			error = "";
			return LiqViajes_Bll_Data.DataProvider.UpdateFieldsbyObject(Fields, parametros, out error,datosTransaccion);
		}
	}

	#endregion

}
