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
	#region TramosReportesLiqVehiculosController

	/// <summary>
	/// Class for convert data from database into object's data and vice versa
	/// </summary>
	public partial class TramosReportesLiqVehiculosController//: ILatinodeController
	{
		/// <summary>
		/// Generic Constructor
		/// </summary>
		public TramosReportesLiqVehiculosController()
		{
		}

		/// <summary>
		/// Instance accessor for this singleton
		/// </summary>
		private static TramosReportesLiqVehiculosController MySingleObj;
		public static TramosReportesLiqVehiculosController Instance
		{
			get
			{
				if (MySingleObj == null)
				{
					MySingleObj = new TramosReportesLiqVehiculosController();
				}
				return MySingleObj;
			}
		}

		// Reads object's data from a DataRow
		private void ReadData(TramosReportesLiqVehiculos tramosreportesliqvehiculos, DataRow dr,bool generateUndo=false)
		{
			try 
			{
				tramosreportesliqvehiculos.Registro = (long) dr["Registro"];
				tramosreportesliqvehiculos.Fecha = dr.IsNull("Fecha") ? null :(DateTime?) dr["Fecha"];
				tramosreportesliqvehiculos.Centro = dr.IsNull("Centro") ? null :(double?) dr["Centro"];
				tramosreportesliqvehiculos.Marca = dr.IsNull("Marca") ? null :(string) dr["Marca"];
				tramosreportesliqvehiculos.Placa = dr.IsNull("Placa") ? null :(string) dr["Placa"];
				tramosreportesliqvehiculos.Modelo = dr.IsNull("Modelo") ? null :(double?) dr["Modelo"];
				tramosreportesliqvehiculos.CedulaConductor = dr.IsNull("CedulaConductor") ? null :(string) dr["CedulaConductor"];
				tramosreportesliqvehiculos.NombreConductor = dr.IsNull("NombreConductor") ? null :(string) dr["NombreConductor"];
				tramosreportesliqvehiculos.TotalGatos = dr.IsNull("TotalGatos") ? null :(decimal?) dr["TotalGatos"];
				tramosreportesliqvehiculos.TotalAnticipos = dr.IsNull("TotalAnticipos") ? null :(decimal?) dr["TotalAnticipos"];
				tramosreportesliqvehiculos.TotalGeneral = dr.IsNull("TotalGeneral") ? null :(decimal?) dr["TotalGeneral"];
			}
			catch (Exception ex)
			{
				Utilidades.LogErrores(ex.Message + (ex.InnerException != null ? ex.InnerException.Message : ""), DataProvider.AplicacionNombre);
				throw ex;
			}
			if (generateUndo) tramosreportesliqvehiculos.GenerateUndo();
		}

		/// <summary>
		/// Create a new TramosReportesLiqVehiculos object by passing a object
		/// </summary>
		public TramosReportesLiqVehiculos Create(TramosReportesLiqVehiculos tramosreportesliqvehiculos, Sinapsys.Datos.SQL datosTransaccion=null)
		{
			return Create(tramosreportesliqvehiculos.Registro,tramosreportesliqvehiculos.Fecha,tramosreportesliqvehiculos.Centro,tramosreportesliqvehiculos.Marca,tramosreportesliqvehiculos.Placa,tramosreportesliqvehiculos.Modelo,tramosreportesliqvehiculos.CedulaConductor,tramosreportesliqvehiculos.NombreConductor,tramosreportesliqvehiculos.TotalGatos,tramosreportesliqvehiculos.TotalAnticipos,tramosreportesliqvehiculos.TotalGeneral,datosTransaccion);
		}

		/// <summary>
		/// Creates a new TramosReportesLiqVehiculos object by passing all object's fields
		/// </summary>
		/// <param name="Fecha">DateTime that contents the Fecha value for the TramosReportesLiqVehiculos object</param>
		/// <param name="Centro">double that contents the Centro value for the TramosReportesLiqVehiculos object</param>
		/// <param name="Marca">string that contents the Marca value for the TramosReportesLiqVehiculos object</param>
		/// <param name="Placa">string that contents the Placa value for the TramosReportesLiqVehiculos object</param>
		/// <param name="Modelo">double that contents the Modelo value for the TramosReportesLiqVehiculos object</param>
		/// <param name="CedulaConductor">string that contents the CedulaConductor value for the TramosReportesLiqVehiculos object</param>
		/// <param name="NombreConductor">string that contents the NombreConductor value for the TramosReportesLiqVehiculos object</param>
		/// <param name="TotalGatos">decimal that contents the TotalGatos value for the TramosReportesLiqVehiculos object</param>
		/// <param name="TotalAnticipos">decimal that contents the TotalAnticipos value for the TramosReportesLiqVehiculos object</param>
		/// <param name="TotalGeneral">decimal that contents the TotalGeneral value for the TramosReportesLiqVehiculos object</param>
		/// <returns>One TramosReportesLiqVehiculos object</returns>
		public TramosReportesLiqVehiculos Create(long Registro, DateTime? Fecha, double? Centro, string Marca, string Placa, double? Modelo, string CedulaConductor, string NombreConductor, decimal? TotalGatos, decimal? TotalAnticipos, decimal? TotalGeneral, Sinapsys.Datos.SQL datosTransaccion=null)
		{
			try 
			{
				TramosReportesLiqVehiculos tramosreportesliqvehiculos = new TramosReportesLiqVehiculos();

				tramosreportesliqvehiculos.Registro = Registro;
				tramosreportesliqvehiculos.Fecha = Fecha;
				tramosreportesliqvehiculos.Centro = Centro;
				tramosreportesliqvehiculos.Marca = Marca;
				tramosreportesliqvehiculos.Placa = Placa;
				tramosreportesliqvehiculos.Modelo = Modelo;
				tramosreportesliqvehiculos.CedulaConductor = CedulaConductor;
				tramosreportesliqvehiculos.NombreConductor = NombreConductor;
				tramosreportesliqvehiculos.TotalGatos = TotalGatos;
				tramosreportesliqvehiculos.TotalAnticipos = TotalAnticipos;
				tramosreportesliqvehiculos.TotalGeneral = TotalGeneral;
				TramosReportesLiqVehiculosDataProvider.Instance.Create(Registro, Fecha, Centro, Marca, Placa, Modelo, CedulaConductor, NombreConductor, TotalGatos, TotalAnticipos, TotalGeneral,"TramosReportesLiqVehiculos");

				return tramosreportesliqvehiculos;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Updates an TramosReportesLiqVehiculos object by passing all object's fields
		/// </summary>
		/// <param name="Registro">long that contents the Registro value for the TramosReportesLiqVehiculos object</param>
		/// <param name="Fecha">DateTime that contents the Fecha value for the TramosReportesLiqVehiculos object</param>
		/// <param name="Centro">double that contents the Centro value for the TramosReportesLiqVehiculos object</param>
		/// <param name="Marca">string that contents the Marca value for the TramosReportesLiqVehiculos object</param>
		/// <param name="Placa">string that contents the Placa value for the TramosReportesLiqVehiculos object</param>
		/// <param name="Modelo">double that contents the Modelo value for the TramosReportesLiqVehiculos object</param>
		/// <param name="CedulaConductor">string that contents the CedulaConductor value for the TramosReportesLiqVehiculos object</param>
		/// <param name="NombreConductor">string that contents the NombreConductor value for the TramosReportesLiqVehiculos object</param>
		/// <param name="TotalGatos">decimal that contents the TotalGatos value for the TramosReportesLiqVehiculos object</param>
		/// <param name="TotalAnticipos">decimal that contents the TotalAnticipos value for the TramosReportesLiqVehiculos object</param>
		/// <param name="TotalGeneral">decimal that contents the TotalGeneral value for the TramosReportesLiqVehiculos object</param>
		public void Update(long Registro, DateTime? Fecha, double? Centro, string Marca, string Placa, double? Modelo, string CedulaConductor, string NombreConductor, decimal? TotalGatos, decimal? TotalAnticipos, decimal? TotalGeneral, Sinapsys.Datos.SQL datosTransaccion=null)
		{
			try 
			{
				TramosReportesLiqVehiculos new_values = new TramosReportesLiqVehiculos();
				new_values.Fecha = Fecha;
				new_values.Centro = Centro;
				new_values.Marca = Marca;
				new_values.Placa = Placa;
				new_values.Modelo = Modelo;
				new_values.CedulaConductor = CedulaConductor;
				new_values.NombreConductor = NombreConductor;
				new_values.TotalGatos = TotalGatos;
				new_values.TotalAnticipos = TotalAnticipos;
				new_values.TotalGeneral = TotalGeneral;
				TramosReportesLiqVehiculosDataProvider.Instance.Update(Registro, Fecha, Centro, Marca, Placa, Modelo, CedulaConductor, NombreConductor, TotalGatos, TotalAnticipos, TotalGeneral,"TramosReportesLiqVehiculos",datosTransaccion);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Updates an TramosReportesLiqVehiculos object by passing one object's instance as reference
		/// </summary>
		/// <param name="tramosreportesliqvehiculos">An instance of TramosReportesLiqVehiculos for reference</param>
		public void Update(TramosReportesLiqVehiculos tramosreportesliqvehiculos,Sinapsys.Datos.SQL datosTransaccion=null)
		{
			Update(tramosreportesliqvehiculos.Registro, tramosreportesliqvehiculos.Fecha, tramosreportesliqvehiculos.Centro, tramosreportesliqvehiculos.Marca, tramosreportesliqvehiculos.Placa, tramosreportesliqvehiculos.Modelo, tramosreportesliqvehiculos.CedulaConductor, tramosreportesliqvehiculos.NombreConductor, tramosreportesliqvehiculos.TotalGatos, tramosreportesliqvehiculos.TotalAnticipos, tramosreportesliqvehiculos.TotalGeneral);
		}

		/// <summary>
		/// Delete  the TramosReportesLiqVehiculos object by passing a object
		/// </summary>
		public void  Delete(TramosReportesLiqVehiculos tramosreportesliqvehiculos, Sinapsys.Datos.SQL datosTransaccion=null)
		{
			Delete(tramosreportesliqvehiculos.Registro,datosTransaccion);
		}

		/// <summary>
		/// Deletes the TramosReportesLiqVehiculos object by passing one object's instance as reference
		/// </summary>
		/// <param name="tramosreportesliqvehiculos">An instance of TramosReportesLiqVehiculos for reference</param>
		public void Delete(long Registro, Sinapsys.Datos.SQL datosTransaccion=null)
		{
			try 
			{
				TramosReportesLiqVehiculosDataProvider.Instance.Delete(Registro,"TramosReportesLiqVehiculos");
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Deletes the TramosReportesLiqVehiculos object by passing CVS parameter as reference
		/// </summary>
		/// <param name="tramosreportesliqvehiculos">An instance of TramosReportesLiqVehiculos for reference</param>
		public void Delete(string CVSParameter)
		{
			string[] StrCommand=CVSParameter.Split(',');
			try 
			{
				long Registro=long.Parse(StrCommand[0]);
				TramosReportesLiqVehiculosDataProvider.Instance.Delete(Registro,"TramosReportesLiqVehiculos");
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Gets the TramosReportesLiqVehiculos object by passing the object's key fields
		/// </summary>
		/// <param name="Registro">long that contents the Registro value for the TramosReportesLiqVehiculos object</param>
		/// <returns>One TramosReportesLiqVehiculos object</returns>
		public TramosReportesLiqVehiculos Get(long Registro, bool generateUndo=false)
		{
			try 
			{
				TramosReportesLiqVehiculos tramosreportesliqvehiculos = null;
				DataTable dt = TramosReportesLiqVehiculosDataProvider.Instance.Get(Registro);
				if ((dt.Rows.Count > 0))
				{
					tramosreportesliqvehiculos = new TramosReportesLiqVehiculos();
					DataRow dr = dt.Rows[0];
					ReadData(tramosreportesliqvehiculos, dr, generateUndo);
				}


				return tramosreportesliqvehiculos;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Gets all objects of TramosReportesLiqVehiculos
		/// </summary>
		/// <returns>One TramosReportesLiqVehiculosList object</returns>
		public TramosReportesLiqVehiculosList GetAll(bool generateUndo=false)
		{
			try 
			{
				TramosReportesLiqVehiculosList tramosreportesliqvehiculoslist = new TramosReportesLiqVehiculosList();
				DataTable dt = TramosReportesLiqVehiculosDataProvider.Instance.GetAll();
				foreach (DataRow dr in dt.Rows)
				{
					TramosReportesLiqVehiculos tramosreportesliqvehiculos = new TramosReportesLiqVehiculos();
					ReadData(tramosreportesliqvehiculos, dr, generateUndo);
					tramosreportesliqvehiculoslist.Add(tramosreportesliqvehiculos);
				}
				return tramosreportesliqvehiculoslist;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Gets all objects of TramosReportesLiqVehiculos applying filter and sort criteria
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
		/// <returns>One TramosReportesLiqVehiculosList object</returns>
		public TramosReportesLiqVehiculosList GetFilter(int pagenum, int pagesize, string filter, string sort, string extablesfilter, string extablesfieldsfilter, string extablesrelationsfilter, string extablessort, string extablesfieldssort, string extablesrelationssort, bool generateUndo=false)
		{
			try 
			{
				TramosReportesLiqVehiculosList tramosreportesliqvehiculoslist = new TramosReportesLiqVehiculosList();

				DataTable dt = TramosReportesLiqVehiculosDataProvider.Instance.GetFilter(pagenum, pagesize, filter, sort, extablesfilter, extablesfieldsfilter, extablesrelationsfilter, extablessort, extablesfieldssort, extablesrelationssort);

				foreach (DataRow dr in dt.Rows)
				{
					TramosReportesLiqVehiculos tramosreportesliqvehiculos = new TramosReportesLiqVehiculos();
					ReadData(tramosreportesliqvehiculos, dr, generateUndo);
					tramosreportesliqvehiculoslist.Add(tramosreportesliqvehiculos);
				}
				return tramosreportesliqvehiculoslist;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public TramosReportesLiqVehiculosList GetFilter( string filter, string sort, bool generateUndo=false)
		{
			return GetFilter(0,0, filter, sort, "","","","","","",generateUndo);
		}

		public TramosReportesLiqVehiculosList GetFilter(string filter, string sort, string extablesfilter, string extablesfieldsfilter, string extablesrelationsfilter, string extablessort, string extablesfieldssort, string extablesrelationssort, bool generateUndo=false)
		{
			return GetFilter(0,0, filter, sort, extablesfilter, extablesfieldsfilter, extablesrelationsfilter, extablessort, extablesfieldssort, extablesrelationssort,generateUndo);
		}


		/// <summary>
		/// Returns the type for one property
		/// </summary>
		/// <param name="propertyname">Property's name for return its value</param>
		/// <returns>A value for the <paramref name="propertyname"/></returns>
		public Type GetMethodType( string propertyname,TramosReportesLiqVehiculos tramosreportesliqvehiculos)
		{
			// Perform the search for the property's value
			switch (propertyname)
			{
				case "Registro":
					return tramosreportesliqvehiculos.Registro.GetType();

				case "Fecha":
					return tramosreportesliqvehiculos.Fecha.GetType();

				case "Centro":
					return tramosreportesliqvehiculos.Centro.GetType();

				case "Marca":
					return tramosreportesliqvehiculos.Marca.GetType();

				case "Placa":
					return tramosreportesliqvehiculos.Placa.GetType();

				case "Modelo":
					return tramosreportesliqvehiculos.Modelo.GetType();

				case "CedulaConductor":
					return tramosreportesliqvehiculos.CedulaConductor.GetType();

				case "NombreConductor":
					return tramosreportesliqvehiculos.NombreConductor.GetType();

				case "TotalGatos":
					return tramosreportesliqvehiculos.TotalGatos.GetType();

				case "TotalAnticipos":
					return tramosreportesliqvehiculos.TotalAnticipos.GetType();

				case "TotalGeneral":
					return tramosreportesliqvehiculos.TotalGeneral.GetType();

			}

			return null;
		}
		/// <summary>
		/// update the changes in TramosReportesLiqVehiculos object by passing the object
		/// </summary>
		public bool UpdateChanges(TramosReportesLiqVehiculos tramosreportesliqvehiculos, out string error,Sinapsys.Datos.SQL datosTransaccion=null)
		{
			if (tramosreportesliqvehiculos.OldTramosReportesLiqVehiculos == null)
			{
				    error = "No tiene objeto con el cual comparar";
				    return false;
			}
			string[] Fields = tramosreportesliqvehiculos.FieldChanged();
			error = "";
			return LiqViajes_Bll_Data.DataProvider.UpdateFieldsbyObject(Fields, tramosreportesliqvehiculos, out error,datosTransaccion);
		}
	}

	#endregion

}
