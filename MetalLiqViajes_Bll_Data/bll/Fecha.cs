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
	#region FechaController

	/// <summary>
	/// Class for convert data from database into object's data and vice versa
	/// </summary>
	public partial class FechaController//: ILatinodeController
	{
		/// <summary>
		/// Generic Constructor
		/// </summary>
		public FechaController()
		{
		}

		/// <summary>
		/// Instance accessor for this singleton
		/// </summary>
		private static FechaController MySingleObj;
		public static FechaController Instance
		{
			get
			{
				if (MySingleObj == null)
				{
					MySingleObj = new FechaController();
				}
				return MySingleObj;
			}
		}

		// Reads object's data from a DataRow
		private void ReadData(Fecha fecha, DataRow dr,bool generateUndo=false)
		{
			try 
			{
				fecha.Date_Name = dr.IsNull("Date_Name") ? null :(string) dr["Date_Name"];
				fecha.Year = dr.IsNull("Year") ? null :(DateTime?) dr["Year"];
				fecha.Year_Name = dr.IsNull("Year_Name") ? null :(string) dr["Year_Name"];
				fecha.Trimester = dr.IsNull("Trimester") ? null :(DateTime?) dr["Trimester"];
				fecha.Trimester_Name = dr.IsNull("Trimester_Name") ? null :(string) dr["Trimester_Name"];
				fecha.Month = dr.IsNull("Month") ? null :(DateTime?) dr["Month"];
				fecha.Month_Name = dr.IsNull("Month_Name") ? null :(string) dr["Month_Name"];
				fecha.Week = dr.IsNull("Week") ? null :(DateTime?) dr["Week"];
				fecha.Week_Name = dr.IsNull("Week_Name") ? null :(string) dr["Week_Name"];
				fecha.Day_Of_Year = dr.IsNull("Day_Of_Year") ? null :(int?) dr["Day_Of_Year"];
				fecha.Day_Of_Year_Name = dr.IsNull("Day_Of_Year_Name") ? null :(string) dr["Day_Of_Year_Name"];
				fecha.Day_Of_Trimester = dr.IsNull("Day_Of_Trimester") ? null :(int?) dr["Day_Of_Trimester"];
				fecha.Day_Of_Trimester_Name = dr.IsNull("Day_Of_Trimester_Name") ? null :(string) dr["Day_Of_Trimester_Name"];
				fecha.Day_Of_Month = dr.IsNull("Day_Of_Month") ? null :(int?) dr["Day_Of_Month"];
				fecha.Day_Of_Month_Name = dr.IsNull("Day_Of_Month_Name") ? null :(string) dr["Day_Of_Month_Name"];
				fecha.Day_Of_Week = dr.IsNull("Day_Of_Week") ? null :(int?) dr["Day_Of_Week"];
				fecha.Day_Of_Week_Name = dr.IsNull("Day_Of_Week_Name") ? null :(string) dr["Day_Of_Week_Name"];
				fecha.Week_Of_Year = dr.IsNull("Week_Of_Year") ? null :(int?) dr["Week_Of_Year"];
				fecha.Week_Of_Year_Name = dr.IsNull("Week_Of_Year_Name") ? null :(string) dr["Week_Of_Year_Name"];
				fecha.Month_Of_Year = dr.IsNull("Month_Of_Year") ? null :(int?) dr["Month_Of_Year"];
				fecha.Month_Of_Year_Name = dr.IsNull("Month_Of_Year_Name") ? null :(string) dr["Month_Of_Year_Name"];
				fecha.Month_Of_Trimester = dr.IsNull("Month_Of_Trimester") ? null :(int?) dr["Month_Of_Trimester"];
				fecha.Month_Of_Trimester_Name = dr.IsNull("Month_Of_Trimester_Name") ? null :(string) dr["Month_Of_Trimester_Name"];
				fecha.Trimester_Of_Year = dr.IsNull("Trimester_Of_Year") ? null :(int?) dr["Trimester_Of_Year"];
				fecha.Trimester_Of_Year_Name = dr.IsNull("Trimester_Of_Year_Name") ? null :(string) dr["Trimester_Of_Year_Name"];
				fecha.PK_Date = (DateTime) dr["PK_Date"];
			}
			catch (Exception ex)
			{
				Utilidades.LogErrores(ex.Message + (ex.InnerException != null ? ex.InnerException.Message : ""), DataProvider.AplicacionNombre);
				throw ex;
			}
			if (generateUndo) fecha.GenerateUndo();
		}

		/// <summary>
		/// Create a new Fecha object by passing a object
		/// </summary>
		public Fecha Create(Fecha fecha, Sinapsys.Datos.SQL datosTransaccion=null)
		{
			return Create(fecha.PK_Date,fecha.Date_Name,fecha.Year,fecha.Year_Name,fecha.Trimester,fecha.Trimester_Name,fecha.Month,fecha.Month_Name,fecha.Week,fecha.Week_Name,fecha.Day_Of_Year,fecha.Day_Of_Year_Name,fecha.Day_Of_Trimester,fecha.Day_Of_Trimester_Name,fecha.Day_Of_Month,fecha.Day_Of_Month_Name,fecha.Day_Of_Week,fecha.Day_Of_Week_Name,fecha.Week_Of_Year,fecha.Week_Of_Year_Name,fecha.Month_Of_Year,fecha.Month_Of_Year_Name,fecha.Month_Of_Trimester,fecha.Month_Of_Trimester_Name,fecha.Trimester_Of_Year,fecha.Trimester_Of_Year_Name,datosTransaccion);
		}

		/// <summary>
		/// Creates a new Fecha object by passing all object's fields
		/// </summary>
		/// <param name="Date_Name">string that contents the Date_Name value for the Fecha object</param>
		/// <param name="Year">DateTime that contents the Year value for the Fecha object</param>
		/// <param name="Year_Name">string that contents the Year_Name value for the Fecha object</param>
		/// <param name="Trimester">DateTime that contents the Trimester value for the Fecha object</param>
		/// <param name="Trimester_Name">string that contents the Trimester_Name value for the Fecha object</param>
		/// <param name="Month">DateTime that contents the Month value for the Fecha object</param>
		/// <param name="Month_Name">string that contents the Month_Name value for the Fecha object</param>
		/// <param name="Week">DateTime that contents the Week value for the Fecha object</param>
		/// <param name="Week_Name">string that contents the Week_Name value for the Fecha object</param>
		/// <param name="Day_Of_Year">int that contents the Day_Of_Year value for the Fecha object</param>
		/// <param name="Day_Of_Year_Name">string that contents the Day_Of_Year_Name value for the Fecha object</param>
		/// <param name="Day_Of_Trimester">int that contents the Day_Of_Trimester value for the Fecha object</param>
		/// <param name="Day_Of_Trimester_Name">string that contents the Day_Of_Trimester_Name value for the Fecha object</param>
		/// <param name="Day_Of_Month">int that contents the Day_Of_Month value for the Fecha object</param>
		/// <param name="Day_Of_Month_Name">string that contents the Day_Of_Month_Name value for the Fecha object</param>
		/// <param name="Day_Of_Week">int that contents the Day_Of_Week value for the Fecha object</param>
		/// <param name="Day_Of_Week_Name">string that contents the Day_Of_Week_Name value for the Fecha object</param>
		/// <param name="Week_Of_Year">int that contents the Week_Of_Year value for the Fecha object</param>
		/// <param name="Week_Of_Year_Name">string that contents the Week_Of_Year_Name value for the Fecha object</param>
		/// <param name="Month_Of_Year">int that contents the Month_Of_Year value for the Fecha object</param>
		/// <param name="Month_Of_Year_Name">string that contents the Month_Of_Year_Name value for the Fecha object</param>
		/// <param name="Month_Of_Trimester">int that contents the Month_Of_Trimester value for the Fecha object</param>
		/// <param name="Month_Of_Trimester_Name">string that contents the Month_Of_Trimester_Name value for the Fecha object</param>
		/// <param name="Trimester_Of_Year">int that contents the Trimester_Of_Year value for the Fecha object</param>
		/// <param name="Trimester_Of_Year_Name">string that contents the Trimester_Of_Year_Name value for the Fecha object</param>
		/// <returns>One Fecha object</returns>
		public Fecha Create(DateTime PK_Date, string Date_Name, DateTime? Year, string Year_Name, DateTime? Trimester, string Trimester_Name, DateTime? Month, string Month_Name, DateTime? Week, string Week_Name, int? Day_Of_Year, string Day_Of_Year_Name, int? Day_Of_Trimester, string Day_Of_Trimester_Name, int? Day_Of_Month, string Day_Of_Month_Name, int? Day_Of_Week, string Day_Of_Week_Name, int? Week_Of_Year, string Week_Of_Year_Name, int? Month_Of_Year, string Month_Of_Year_Name, int? Month_Of_Trimester, string Month_Of_Trimester_Name, int? Trimester_Of_Year, string Trimester_Of_Year_Name, Sinapsys.Datos.SQL datosTransaccion=null)
		{
			try 
			{
				Fecha fecha = new Fecha();

				fecha.PK_Date = PK_Date;
				fecha.Date_Name = Date_Name;
				fecha.Year = Year;
				fecha.Year_Name = Year_Name;
				fecha.Trimester = Trimester;
				fecha.Trimester_Name = Trimester_Name;
				fecha.Month = Month;
				fecha.Month_Name = Month_Name;
				fecha.Week = Week;
				fecha.Week_Name = Week_Name;
				fecha.Day_Of_Year = Day_Of_Year;
				fecha.Day_Of_Year_Name = Day_Of_Year_Name;
				fecha.Day_Of_Trimester = Day_Of_Trimester;
				fecha.Day_Of_Trimester_Name = Day_Of_Trimester_Name;
				fecha.Day_Of_Month = Day_Of_Month;
				fecha.Day_Of_Month_Name = Day_Of_Month_Name;
				fecha.Day_Of_Week = Day_Of_Week;
				fecha.Day_Of_Week_Name = Day_Of_Week_Name;
				fecha.Week_Of_Year = Week_Of_Year;
				fecha.Week_Of_Year_Name = Week_Of_Year_Name;
				fecha.Month_Of_Year = Month_Of_Year;
				fecha.Month_Of_Year_Name = Month_Of_Year_Name;
				fecha.Month_Of_Trimester = Month_Of_Trimester;
				fecha.Month_Of_Trimester_Name = Month_Of_Trimester_Name;
				fecha.Trimester_Of_Year = Trimester_Of_Year;
				fecha.Trimester_Of_Year_Name = Trimester_Of_Year_Name;
				FechaDataProvider.Instance.Create(PK_Date, Date_Name, Year, Year_Name, Trimester, Trimester_Name, Month, Month_Name, Week, Week_Name, Day_Of_Year, Day_Of_Year_Name, Day_Of_Trimester, Day_Of_Trimester_Name, Day_Of_Month, Day_Of_Month_Name, Day_Of_Week, Day_Of_Week_Name, Week_Of_Year, Week_Of_Year_Name, Month_Of_Year, Month_Of_Year_Name, Month_Of_Trimester, Month_Of_Trimester_Name, Trimester_Of_Year, Trimester_Of_Year_Name,"Fecha");

				return fecha;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Updates an Fecha object by passing all object's fields
		/// </summary>
		/// <param name="Date_Name">string that contents the Date_Name value for the Fecha object</param>
		/// <param name="Year">DateTime that contents the Year value for the Fecha object</param>
		/// <param name="Year_Name">string that contents the Year_Name value for the Fecha object</param>
		/// <param name="Trimester">DateTime that contents the Trimester value for the Fecha object</param>
		/// <param name="Trimester_Name">string that contents the Trimester_Name value for the Fecha object</param>
		/// <param name="Month">DateTime that contents the Month value for the Fecha object</param>
		/// <param name="Month_Name">string that contents the Month_Name value for the Fecha object</param>
		/// <param name="Week">DateTime that contents the Week value for the Fecha object</param>
		/// <param name="Week_Name">string that contents the Week_Name value for the Fecha object</param>
		/// <param name="Day_Of_Year">int that contents the Day_Of_Year value for the Fecha object</param>
		/// <param name="Day_Of_Year_Name">string that contents the Day_Of_Year_Name value for the Fecha object</param>
		/// <param name="Day_Of_Trimester">int that contents the Day_Of_Trimester value for the Fecha object</param>
		/// <param name="Day_Of_Trimester_Name">string that contents the Day_Of_Trimester_Name value for the Fecha object</param>
		/// <param name="Day_Of_Month">int that contents the Day_Of_Month value for the Fecha object</param>
		/// <param name="Day_Of_Month_Name">string that contents the Day_Of_Month_Name value for the Fecha object</param>
		/// <param name="Day_Of_Week">int that contents the Day_Of_Week value for the Fecha object</param>
		/// <param name="Day_Of_Week_Name">string that contents the Day_Of_Week_Name value for the Fecha object</param>
		/// <param name="Week_Of_Year">int that contents the Week_Of_Year value for the Fecha object</param>
		/// <param name="Week_Of_Year_Name">string that contents the Week_Of_Year_Name value for the Fecha object</param>
		/// <param name="Month_Of_Year">int that contents the Month_Of_Year value for the Fecha object</param>
		/// <param name="Month_Of_Year_Name">string that contents the Month_Of_Year_Name value for the Fecha object</param>
		/// <param name="Month_Of_Trimester">int that contents the Month_Of_Trimester value for the Fecha object</param>
		/// <param name="Month_Of_Trimester_Name">string that contents the Month_Of_Trimester_Name value for the Fecha object</param>
		/// <param name="Trimester_Of_Year">int that contents the Trimester_Of_Year value for the Fecha object</param>
		/// <param name="Trimester_Of_Year_Name">string that contents the Trimester_Of_Year_Name value for the Fecha object</param>
		/// <param name="PK_Date">DateTime that contents the PK_Date value for the Fecha object</param>
		public void Update(string Date_Name, DateTime? Year, string Year_Name, DateTime? Trimester, string Trimester_Name, DateTime? Month, string Month_Name, DateTime? Week, string Week_Name, int? Day_Of_Year, string Day_Of_Year_Name, int? Day_Of_Trimester, string Day_Of_Trimester_Name, int? Day_Of_Month, string Day_Of_Month_Name, int? Day_Of_Week, string Day_Of_Week_Name, int? Week_Of_Year, string Week_Of_Year_Name, int? Month_Of_Year, string Month_Of_Year_Name, int? Month_Of_Trimester, string Month_Of_Trimester_Name, int? Trimester_Of_Year, string Trimester_Of_Year_Name, DateTime PK_Date, Sinapsys.Datos.SQL datosTransaccion=null)
		{
			try 
			{
				Fecha new_values = new Fecha();
				new_values.Date_Name = Date_Name;
				new_values.Year = Year;
				new_values.Year_Name = Year_Name;
				new_values.Trimester = Trimester;
				new_values.Trimester_Name = Trimester_Name;
				new_values.Month = Month;
				new_values.Month_Name = Month_Name;
				new_values.Week = Week;
				new_values.Week_Name = Week_Name;
				new_values.Day_Of_Year = Day_Of_Year;
				new_values.Day_Of_Year_Name = Day_Of_Year_Name;
				new_values.Day_Of_Trimester = Day_Of_Trimester;
				new_values.Day_Of_Trimester_Name = Day_Of_Trimester_Name;
				new_values.Day_Of_Month = Day_Of_Month;
				new_values.Day_Of_Month_Name = Day_Of_Month_Name;
				new_values.Day_Of_Week = Day_Of_Week;
				new_values.Day_Of_Week_Name = Day_Of_Week_Name;
				new_values.Week_Of_Year = Week_Of_Year;
				new_values.Week_Of_Year_Name = Week_Of_Year_Name;
				new_values.Month_Of_Year = Month_Of_Year;
				new_values.Month_Of_Year_Name = Month_Of_Year_Name;
				new_values.Month_Of_Trimester = Month_Of_Trimester;
				new_values.Month_Of_Trimester_Name = Month_Of_Trimester_Name;
				new_values.Trimester_Of_Year = Trimester_Of_Year;
				new_values.Trimester_Of_Year_Name = Trimester_Of_Year_Name;
				FechaDataProvider.Instance.Update(Date_Name, Year, Year_Name, Trimester, Trimester_Name, Month, Month_Name, Week, Week_Name, Day_Of_Year, Day_Of_Year_Name, Day_Of_Trimester, Day_Of_Trimester_Name, Day_Of_Month, Day_Of_Month_Name, Day_Of_Week, Day_Of_Week_Name, Week_Of_Year, Week_Of_Year_Name, Month_Of_Year, Month_Of_Year_Name, Month_Of_Trimester, Month_Of_Trimester_Name, Trimester_Of_Year, Trimester_Of_Year_Name, PK_Date,"Fecha",datosTransaccion);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Updates an Fecha object by passing one object's instance as reference
		/// </summary>
		/// <param name="fecha">An instance of Fecha for reference</param>
		public void Update(Fecha fecha,Sinapsys.Datos.SQL datosTransaccion=null)
		{
			Update(fecha.Date_Name, fecha.Year, fecha.Year_Name, fecha.Trimester, fecha.Trimester_Name, fecha.Month, fecha.Month_Name, fecha.Week, fecha.Week_Name, fecha.Day_Of_Year, fecha.Day_Of_Year_Name, fecha.Day_Of_Trimester, fecha.Day_Of_Trimester_Name, fecha.Day_Of_Month, fecha.Day_Of_Month_Name, fecha.Day_Of_Week, fecha.Day_Of_Week_Name, fecha.Week_Of_Year, fecha.Week_Of_Year_Name, fecha.Month_Of_Year, fecha.Month_Of_Year_Name, fecha.Month_Of_Trimester, fecha.Month_Of_Trimester_Name, fecha.Trimester_Of_Year, fecha.Trimester_Of_Year_Name, fecha.PK_Date);
		}

		/// <summary>
		/// Delete  the Fecha object by passing a object
		/// </summary>
		public void  Delete(Fecha fecha, Sinapsys.Datos.SQL datosTransaccion=null)
		{
			Delete(fecha.PK_Date,datosTransaccion);
		}

		/// <summary>
		/// Deletes the Fecha object by passing one object's instance as reference
		/// </summary>
		/// <param name="fecha">An instance of Fecha for reference</param>
		public void Delete(DateTime PK_Date, Sinapsys.Datos.SQL datosTransaccion=null)
		{
			try 
			{
				FechaDataProvider.Instance.Delete(PK_Date,"Fecha");
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Deletes the Fecha object by passing CVS parameter as reference
		/// </summary>
		/// <param name="fecha">An instance of Fecha for reference</param>
		public void Delete(string CVSParameter)
		{
			string[] StrCommand=CVSParameter.Split(',');
			try 
			{
				DateTime PK_Date=DateTime.Parse(StrCommand[0]);
				FechaDataProvider.Instance.Delete(PK_Date,"Fecha");
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Gets the Fecha object by passing the object's key fields
		/// </summary>
		/// <param name="PK_Date">DateTime that contents the PK_Date value for the Fecha object</param>
		/// <returns>One Fecha object</returns>
		public Fecha Get(DateTime PK_Date, bool generateUndo=false)
		{
			try 
			{
				Fecha fecha = null;
				fecha= MasterTables.Fecha.Where(r => r.PK_Date== PK_Date).FirstOrDefault();
				if (fecha== null)
				{
					MasterTables.Reset("Fecha");
					fecha= MasterTables.Fecha.Where(r => r.PK_Date== PK_Date).FirstOrDefault();
				}
				if (generateUndo) fecha.GenerateUndo();

				return fecha;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Gets all objects of Fecha
		/// </summary>
		/// <returns>One FechaList object</returns>
		public FechaList GetAll(bool generateUndo=false)
		{
			try 
			{
				FechaList fechalist = new FechaList();
				DataTable dt = FechaDataProvider.Instance.GetAll();
				foreach (DataRow dr in dt.Rows)
				{
					Fecha fecha = new Fecha();
					ReadData(fecha, dr, generateUndo);
					fechalist.Add(fecha);
				}
				return fechalist;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Gets all objects of Fecha applying filter and sort criteria
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
		/// <returns>One FechaList object</returns>
		public FechaList GetFilter(int pagenum, int pagesize, string filter, string sort, string extablesfilter, string extablesfieldsfilter, string extablesrelationsfilter, string extablessort, string extablesfieldssort, string extablesrelationssort, bool generateUndo=false)
		{
			try 
			{
				FechaList fechalist = new FechaList();

				DataTable dt = FechaDataProvider.Instance.GetFilter(pagenum, pagesize, filter, sort, extablesfilter, extablesfieldsfilter, extablesrelationsfilter, extablessort, extablesfieldssort, extablesrelationssort);

				foreach (DataRow dr in dt.Rows)
				{
					Fecha fecha = new Fecha();
					ReadData(fecha, dr, generateUndo);
					fechalist.Add(fecha);
				}
				return fechalist;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public FechaList GetFilter( string filter, string sort, bool generateUndo=false)
		{
			return GetFilter(0,0, filter, sort, "","","","","","",generateUndo);
		}

		public FechaList GetFilter(string filter, string sort, string extablesfilter, string extablesfieldsfilter, string extablesrelationsfilter, string extablessort, string extablesfieldssort, string extablesrelationssort, bool generateUndo=false)
		{
			return GetFilter(0,0, filter, sort, extablesfilter, extablesfieldsfilter, extablesrelationsfilter, extablessort, extablesfieldssort, extablesrelationssort,generateUndo);
		}


		/// <summary>
		/// Returns the type for one property
		/// </summary>
		/// <param name="propertyname">Property's name for return its value</param>
		/// <returns>A value for the <paramref name="propertyname"/></returns>
		public Type GetMethodType( string propertyname,Fecha fecha)
		{
			// Perform the search for the property's value
			switch (propertyname)
			{
				case "Date_Name":
					return fecha.Date_Name.GetType();

				case "Year":
					return fecha.Year.GetType();

				case "Year_Name":
					return fecha.Year_Name.GetType();

				case "Trimester":
					return fecha.Trimester.GetType();

				case "Trimester_Name":
					return fecha.Trimester_Name.GetType();

				case "Month":
					return fecha.Month.GetType();

				case "Month_Name":
					return fecha.Month_Name.GetType();

				case "Week":
					return fecha.Week.GetType();

				case "Week_Name":
					return fecha.Week_Name.GetType();

				case "Day_Of_Year":
					return fecha.Day_Of_Year.GetType();

				case "Day_Of_Year_Name":
					return fecha.Day_Of_Year_Name.GetType();

				case "Day_Of_Trimester":
					return fecha.Day_Of_Trimester.GetType();

				case "Day_Of_Trimester_Name":
					return fecha.Day_Of_Trimester_Name.GetType();

				case "Day_Of_Month":
					return fecha.Day_Of_Month.GetType();

				case "Day_Of_Month_Name":
					return fecha.Day_Of_Month_Name.GetType();

				case "Day_Of_Week":
					return fecha.Day_Of_Week.GetType();

				case "Day_Of_Week_Name":
					return fecha.Day_Of_Week_Name.GetType();

				case "Week_Of_Year":
					return fecha.Week_Of_Year.GetType();

				case "Week_Of_Year_Name":
					return fecha.Week_Of_Year_Name.GetType();

				case "Month_Of_Year":
					return fecha.Month_Of_Year.GetType();

				case "Month_Of_Year_Name":
					return fecha.Month_Of_Year_Name.GetType();

				case "Month_Of_Trimester":
					return fecha.Month_Of_Trimester.GetType();

				case "Month_Of_Trimester_Name":
					return fecha.Month_Of_Trimester_Name.GetType();

				case "Trimester_Of_Year":
					return fecha.Trimester_Of_Year.GetType();

				case "Trimester_Of_Year_Name":
					return fecha.Trimester_Of_Year_Name.GetType();

				case "PK_Date":
					return fecha.PK_Date.GetType();

			}

			return null;
		}
		/// <summary>
		/// update the changes in Fecha object by passing the object
		/// </summary>
		public bool UpdateChanges(Fecha fecha, out string error,Sinapsys.Datos.SQL datosTransaccion=null)
		{
			if (fecha.OldFecha == null)
			{
				    error = "No tiene objeto con el cual comparar";
				    return false;
			}
			string[] Fields = fecha.FieldChanged();
			error = "";
			return LiqViajes_Bll_Data.DataProvider.UpdateFieldsbyObject(Fields, fecha, out error,datosTransaccion);
		}
	}

	#endregion

}
