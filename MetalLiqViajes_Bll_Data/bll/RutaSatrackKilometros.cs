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
	#region RutaSatrackKilometrosController

	/// <summary>
	/// Class for convert data from database into object's data and vice versa
	/// </summary>
	public partial class RutaSatrackKilometrosController//: ILatinodeController
	{
		/// <summary>
		/// Generic Constructor
		/// </summary>
		public RutaSatrackKilometrosController()
		{
		}

		/// <summary>
		/// Instance accessor for this singleton
		/// </summary>
		private static RutaSatrackKilometrosController MySingleObj;
		public static RutaSatrackKilometrosController Instance
		{
			get
			{
				if (MySingleObj == null)
				{
					MySingleObj = new RutaSatrackKilometrosController();
				}
				return MySingleObj;
			}
		}

		// Reads object's data from a DataRow
		private void ReadData(RutaSatrackKilometros rutasatrackkilometros, DataRow dr,bool generateUndo=false)
		{
			try 
			{
				rutasatrackkilometros.Placa = (string) dr["Placa"];
				rutasatrackkilometros.Ano = (int) dr["Ano"];
				rutasatrackkilometros.Mes = (int) dr["Mes"];
				rutasatrackkilometros.Dia = (int) dr["Dia"];
				rutasatrackkilometros.Kilometros = dr.IsNull("Kilometros") ? null :(double?) dr["Kilometros"];
			}
			catch (Exception ex)
			{
				Utilidades.LogErrores(ex.Message + (ex.InnerException != null ? ex.InnerException.Message : ""), DataProvider.AplicacionNombre);
				throw ex;
			}
			if (generateUndo) rutasatrackkilometros.GenerateUndo();
		}

		/// <summary>
		/// Create a new RutaSatrackKilometros object by passing a object
		/// </summary>
		public RutaSatrackKilometros Create(RutaSatrackKilometros rutasatrackkilometros, Sinapsys.Datos.SQL datosTransaccion=null)
		{
			return Create(rutasatrackkilometros.Placa,rutasatrackkilometros.Ano,rutasatrackkilometros.Mes,rutasatrackkilometros.Dia,rutasatrackkilometros.Kilometros,datosTransaccion);
		}

		/// <summary>
		/// Creates a new RutaSatrackKilometros object by passing all object's fields
		/// </summary>
		/// <param name="Kilometros">double that contents the Kilometros value for the RutaSatrackKilometros object</param>
		/// <returns>One RutaSatrackKilometros object</returns>
		public RutaSatrackKilometros Create(string Placa, int Ano, int Mes, int Dia, double? Kilometros, Sinapsys.Datos.SQL datosTransaccion=null)
		{
			try 
			{
				RutaSatrackKilometros rutasatrackkilometros = new RutaSatrackKilometros();

				rutasatrackkilometros.Placa = Placa;
				rutasatrackkilometros.Ano = Ano;
				rutasatrackkilometros.Mes = Mes;
				rutasatrackkilometros.Dia = Dia;
				rutasatrackkilometros.Kilometros = Kilometros;
				RutaSatrackKilometrosDataProvider.Instance.Create(Placa, Ano, Mes, Dia, Kilometros,"RutaSatrackKilometros");

				return rutasatrackkilometros;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Updates an RutaSatrackKilometros object by passing all object's fields
		/// </summary>
		/// <param name="Placa">string that contents the Placa value for the RutaSatrackKilometros object</param>
		/// <param name="Ano">int that contents the Ano value for the RutaSatrackKilometros object</param>
		/// <param name="Mes">int that contents the Mes value for the RutaSatrackKilometros object</param>
		/// <param name="Dia">int that contents the Dia value for the RutaSatrackKilometros object</param>
		/// <param name="Kilometros">double that contents the Kilometros value for the RutaSatrackKilometros object</param>
		public void Update(string Placa, int Ano, int Mes, int Dia, double? Kilometros, Sinapsys.Datos.SQL datosTransaccion=null)
		{
			try 
			{
				RutaSatrackKilometros new_values = new RutaSatrackKilometros();
				new_values.Kilometros = Kilometros;
				RutaSatrackKilometrosDataProvider.Instance.Update(Placa, Ano, Mes, Dia, Kilometros,"RutaSatrackKilometros",datosTransaccion);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Updates an RutaSatrackKilometros object by passing one object's instance as reference
		/// </summary>
		/// <param name="rutasatrackkilometros">An instance of RutaSatrackKilometros for reference</param>
		public void Update(RutaSatrackKilometros rutasatrackkilometros,Sinapsys.Datos.SQL datosTransaccion=null)
		{
			Update(rutasatrackkilometros.Placa, rutasatrackkilometros.Ano, rutasatrackkilometros.Mes, rutasatrackkilometros.Dia, rutasatrackkilometros.Kilometros);
		}

		/// <summary>
		/// Delete  the RutaSatrackKilometros object by passing a object
		/// </summary>
		public void  Delete(RutaSatrackKilometros rutasatrackkilometros, Sinapsys.Datos.SQL datosTransaccion=null)
		{
			Delete(rutasatrackkilometros.Placa, rutasatrackkilometros.Ano, rutasatrackkilometros.Mes, rutasatrackkilometros.Dia,datosTransaccion);
		}

		/// <summary>
		/// Deletes the RutaSatrackKilometros object by passing one object's instance as reference
		/// </summary>
		/// <param name="rutasatrackkilometros">An instance of RutaSatrackKilometros for reference</param>
		public void Delete(string Placa, int Ano, int Mes, int Dia, Sinapsys.Datos.SQL datosTransaccion=null)
		{
			try 
			{
				RutaSatrackKilometrosDataProvider.Instance.Delete(Placa, Ano, Mes, Dia,"RutaSatrackKilometros");
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Deletes the RutaSatrackKilometros object by passing CVS parameter as reference
		/// </summary>
		/// <param name="rutasatrackkilometros">An instance of RutaSatrackKilometros for reference</param>
		public void Delete(string CVSParameter)
		{
			string[] StrCommand=CVSParameter.Split(',');
			try 
			{
				string Placa=StrCommand[0];
				int Ano=int.Parse(StrCommand[1]);
				int Mes=int.Parse(StrCommand[2]);
				int Dia=int.Parse(StrCommand[3]);
				RutaSatrackKilometrosDataProvider.Instance.Delete(Placa, Ano, Mes, Dia,"RutaSatrackKilometros");
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Gets the RutaSatrackKilometros object by passing the object's key fields
		/// </summary>
		/// <param name="Placa">string that contents the Placa value for the RutaSatrackKilometros object</param>
		/// <param name="Ano">int that contents the Ano value for the RutaSatrackKilometros object</param>
		/// <param name="Mes">int that contents the Mes value for the RutaSatrackKilometros object</param>
		/// <param name="Dia">int that contents the Dia value for the RutaSatrackKilometros object</param>
		/// <returns>One RutaSatrackKilometros object</returns>
		public RutaSatrackKilometros Get(string Placa, int Ano, int Mes, int Dia, bool generateUndo=false)
		{
			try 
			{
				RutaSatrackKilometros rutasatrackkilometros = null;
				DataTable dt = RutaSatrackKilometrosDataProvider.Instance.Get(Placa, Ano, Mes, Dia);
				if ((dt.Rows.Count > 0))
				{
					rutasatrackkilometros = new RutaSatrackKilometros();
					DataRow dr = dt.Rows[0];
					ReadData(rutasatrackkilometros, dr, generateUndo);
				}


				return rutasatrackkilometros;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Gets all objects of RutaSatrackKilometros
		/// </summary>
		/// <returns>One RutaSatrackKilometrosList object</returns>
		public RutaSatrackKilometrosList GetAll(bool generateUndo=false)
		{
			try 
			{
				RutaSatrackKilometrosList rutasatrackkilometroslist = new RutaSatrackKilometrosList();
				DataTable dt = RutaSatrackKilometrosDataProvider.Instance.GetAll();
				foreach (DataRow dr in dt.Rows)
				{
					RutaSatrackKilometros rutasatrackkilometros = new RutaSatrackKilometros();
					ReadData(rutasatrackkilometros, dr, generateUndo);
					rutasatrackkilometroslist.Add(rutasatrackkilometros);
				}
				return rutasatrackkilometroslist;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Gets all objects of RutaSatrackKilometros applying filter and sort criteria
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
		/// <returns>One RutaSatrackKilometrosList object</returns>
		public RutaSatrackKilometrosList GetFilter(int pagenum, int pagesize, string filter, string sort, string extablesfilter, string extablesfieldsfilter, string extablesrelationsfilter, string extablessort, string extablesfieldssort, string extablesrelationssort, bool generateUndo=false)
		{
			try 
			{
				RutaSatrackKilometrosList rutasatrackkilometroslist = new RutaSatrackKilometrosList();

				DataTable dt = RutaSatrackKilometrosDataProvider.Instance.GetFilter(pagenum, pagesize, filter, sort, extablesfilter, extablesfieldsfilter, extablesrelationsfilter, extablessort, extablesfieldssort, extablesrelationssort);

				foreach (DataRow dr in dt.Rows)
				{
					RutaSatrackKilometros rutasatrackkilometros = new RutaSatrackKilometros();
					ReadData(rutasatrackkilometros, dr, generateUndo);
					rutasatrackkilometroslist.Add(rutasatrackkilometros);
				}
				return rutasatrackkilometroslist;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public RutaSatrackKilometrosList GetFilter( string filter, string sort, bool generateUndo=false)
		{
			return GetFilter(0,0, filter, sort, "","","","","","",generateUndo);
		}

		public RutaSatrackKilometrosList GetFilter(string filter, string sort, string extablesfilter, string extablesfieldsfilter, string extablesrelationsfilter, string extablessort, string extablesfieldssort, string extablesrelationssort, bool generateUndo=false)
		{
			return GetFilter(0,0, filter, sort, extablesfilter, extablesfieldsfilter, extablesrelationsfilter, extablessort, extablesfieldssort, extablesrelationssort,generateUndo);
		}


		/// <summary>
		/// Returns the type for one property
		/// </summary>
		/// <param name="propertyname">Property's name for return its value</param>
		/// <returns>A value for the <paramref name="propertyname"/></returns>
		public Type GetMethodType( string propertyname,RutaSatrackKilometros rutasatrackkilometros)
		{
			// Perform the search for the property's value
			switch (propertyname)
			{
				case "Placa":
					return rutasatrackkilometros.Placa.GetType();

				case "Ano":
					return rutasatrackkilometros.Ano.GetType();

				case "Mes":
					return rutasatrackkilometros.Mes.GetType();

				case "Dia":
					return rutasatrackkilometros.Dia.GetType();

				case "Kilometros":
					return rutasatrackkilometros.Kilometros.GetType();

			}

			return null;
		}
		/// <summary>
		/// update the changes in RutaSatrackKilometros object by passing the object
		/// </summary>
		public bool UpdateChanges(RutaSatrackKilometros rutasatrackkilometros, out string error,Sinapsys.Datos.SQL datosTransaccion=null)
		{
			if (rutasatrackkilometros.OldRutaSatrackKilometros == null)
			{
				    error = "No tiene objeto con el cual comparar";
				    return false;
			}
			string[] Fields = rutasatrackkilometros.FieldChanged();
			error = "";
			return LiqViajes_Bll_Data.DataProvider.UpdateFieldsbyObject(Fields, rutasatrackkilometros, out error,datosTransaccion);
		}
	}

	#endregion

}
