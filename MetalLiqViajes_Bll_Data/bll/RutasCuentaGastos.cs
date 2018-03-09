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
	#region RutasCuentaGastosController

	/// <summary>
	/// Class for convert data from database into object's data and vice versa
	/// </summary>
	public partial class RutasCuentaGastosController//: ILatinodeController
	{
		/// <summary>
		/// Generic Constructor
		/// </summary>
		public RutasCuentaGastosController()
		{
		}

		/// <summary>
		/// Instance accessor for this singleton
		/// </summary>
		private static RutasCuentaGastosController MySingleObj;
		public static RutasCuentaGastosController Instance
		{
			get
			{
				if (MySingleObj == null)
				{
					MySingleObj = new RutasCuentaGastosController();
				}
				return MySingleObj;
			}
		}

		// Reads object's data from a DataRow
		private void ReadData(RutasCuentaGastos rutascuentagastos, DataRow dr,bool generateUndo=false)
		{
			try 
			{
				rutascuentagastos.Codigo = (long) dr["Codigo"];
				rutascuentagastos.Campo = dr.IsNull("Campo") ? null :(string) dr["Campo"];
				rutascuentagastos.Cuenta1 = dr.IsNull("Cuenta1") ? null :(string) dr["Cuenta1"];
				rutascuentagastos.NombreCuenta1 = dr.IsNull("NombreCuenta1") ? null :(string) dr["NombreCuenta1"];
				rutascuentagastos.Nit2 = dr.IsNull("Nit2") ? null :(string) dr["Nit2"];
				rutascuentagastos.NombreTercero2 = dr.IsNull("NombreTercero2") ? null :(string) dr["NombreTercero2"];
				rutascuentagastos.Valor3 = dr.IsNull("Valor3") ? null :(decimal?) dr["Valor3"];
				rutascuentagastos.Cuenta4 = dr.IsNull("Cuenta4") ? null :(string) dr["Cuenta4"];
				rutascuentagastos.NombreCuenta4 = dr.IsNull("NombreCuenta4") ? null :(string) dr["NombreCuenta4"];
				rutascuentagastos.Cuenta5 = dr.IsNull("Cuenta5") ? null :(string) dr["Cuenta5"];
				rutascuentagastos.NombreCuenta5 = dr.IsNull("NombreCuenta5") ? null :(string) dr["NombreCuenta5"];
				rutascuentagastos.Nit6 = dr.IsNull("Nit6") ? null :(string) dr["Nit6"];
				rutascuentagastos.NombreTercero6 = dr.IsNull("NombreTercero6") ? null :(string) dr["NombreTercero6"];
				rutascuentagastos.Valor7 = dr.IsNull("Valor7") ? null :(decimal?) dr["Valor7"];
				rutascuentagastos.Cuenta8 = dr.IsNull("Cuenta8") ? null :(string) dr["Cuenta8"];
				rutascuentagastos.NombreCuenta8 = dr.IsNull("NombreCuenta8") ? null :(string) dr["NombreCuenta8"];
				rutascuentagastos.FechaCrea = dr.IsNull("FechaCrea") ? null :(DateTime?) dr["FechaCrea"];
				rutascuentagastos.Activo = dr.IsNull("Activo") ? null :(bool?) dr["Activo"];
				rutascuentagastos.Total = dr.IsNull("Total") ? null :(bool?) dr["Total"];
				rutascuentagastos.PadreCodigo = dr.IsNull("PadreCodigo") ? null :(long?) dr["PadreCodigo"];
			}
			catch (Exception ex)
			{
				Utilidades.LogErrores(ex.Message + (ex.InnerException != null ? ex.InnerException.Message : ""), DataProvider.AplicacionNombre);
				throw ex;
			}
			if (generateUndo) rutascuentagastos.GenerateUndo();
		}

		/// <summary>
		/// Create a new RutasCuentaGastos object by passing a object
		/// </summary>
		public RutasCuentaGastos Create(RutasCuentaGastos rutascuentagastos, Sinapsys.Datos.SQL datosTransaccion=null)
		{
			return Create(rutascuentagastos.Codigo,rutascuentagastos.Campo,rutascuentagastos.Cuenta1,rutascuentagastos.NombreCuenta1,rutascuentagastos.Nit2,rutascuentagastos.NombreTercero2,rutascuentagastos.Valor3,rutascuentagastos.Cuenta4,rutascuentagastos.NombreCuenta4,rutascuentagastos.Cuenta5,rutascuentagastos.NombreCuenta5,rutascuentagastos.Nit6,rutascuentagastos.NombreTercero6,rutascuentagastos.Valor7,rutascuentagastos.Cuenta8,rutascuentagastos.NombreCuenta8,rutascuentagastos.FechaCrea,rutascuentagastos.Activo,rutascuentagastos.Total,rutascuentagastos.PadreCodigo,datosTransaccion);
		}

		/// <summary>
		/// Creates a new RutasCuentaGastos object by passing all object's fields
		/// </summary>
		/// <param name="Campo">string that contents the Campo value for the RutasCuentaGastos object</param>
		/// <param name="Cuenta1">string that contents the Cuenta1 value for the RutasCuentaGastos object</param>
		/// <param name="NombreCuenta1">string that contents the NombreCuenta1 value for the RutasCuentaGastos object</param>
		/// <param name="Nit2">string that contents the Nit2 value for the RutasCuentaGastos object</param>
		/// <param name="NombreTercero2">string that contents the NombreTercero2 value for the RutasCuentaGastos object</param>
		/// <param name="Valor3">decimal that contents the Valor3 value for the RutasCuentaGastos object</param>
		/// <param name="Cuenta4">string that contents the Cuenta4 value for the RutasCuentaGastos object</param>
		/// <param name="NombreCuenta4">string that contents the NombreCuenta4 value for the RutasCuentaGastos object</param>
		/// <param name="Cuenta5">string that contents the Cuenta5 value for the RutasCuentaGastos object</param>
		/// <param name="NombreCuenta5">string that contents the NombreCuenta5 value for the RutasCuentaGastos object</param>
		/// <param name="Nit6">string that contents the Nit6 value for the RutasCuentaGastos object</param>
		/// <param name="NombreTercero6">string that contents the NombreTercero6 value for the RutasCuentaGastos object</param>
		/// <param name="Valor7">decimal that contents the Valor7 value for the RutasCuentaGastos object</param>
		/// <param name="Cuenta8">string that contents the Cuenta8 value for the RutasCuentaGastos object</param>
		/// <param name="NombreCuenta8">string that contents the NombreCuenta8 value for the RutasCuentaGastos object</param>
		/// <param name="FechaCrea">DateTime that contents the FechaCrea value for the RutasCuentaGastos object</param>
		/// <param name="Activo">bool that contents the Activo value for the RutasCuentaGastos object</param>
		/// <param name="Total">bool that contents the Total value for the RutasCuentaGastos object</param>
		/// <param name="PadreCodigo">long that contents the PadreCodigo value for the RutasCuentaGastos object</param>
		/// <returns>One RutasCuentaGastos object</returns>
		public RutasCuentaGastos Create(long Codigo, string Campo, string Cuenta1, string NombreCuenta1, string Nit2, string NombreTercero2, decimal? Valor3, string Cuenta4, string NombreCuenta4, string Cuenta5, string NombreCuenta5, string Nit6, string NombreTercero6, decimal? Valor7, string Cuenta8, string NombreCuenta8, DateTime? FechaCrea, bool? Activo, bool? Total, long? PadreCodigo, Sinapsys.Datos.SQL datosTransaccion=null)
		{
			try 
			{
				RutasCuentaGastos rutascuentagastos = new RutasCuentaGastos();

				rutascuentagastos.Codigo = Codigo;
				rutascuentagastos.Campo = Campo;
				rutascuentagastos.Cuenta1 = Cuenta1;
				rutascuentagastos.NombreCuenta1 = NombreCuenta1;
				rutascuentagastos.Nit2 = Nit2;
				rutascuentagastos.NombreTercero2 = NombreTercero2;
				rutascuentagastos.Valor3 = Valor3;
				rutascuentagastos.Cuenta4 = Cuenta4;
				rutascuentagastos.NombreCuenta4 = NombreCuenta4;
				rutascuentagastos.Cuenta5 = Cuenta5;
				rutascuentagastos.NombreCuenta5 = NombreCuenta5;
				rutascuentagastos.Nit6 = Nit6;
				rutascuentagastos.NombreTercero6 = NombreTercero6;
				rutascuentagastos.Valor7 = Valor7;
				rutascuentagastos.Cuenta8 = Cuenta8;
				rutascuentagastos.NombreCuenta8 = NombreCuenta8;
				rutascuentagastos.FechaCrea = FechaCrea;
				rutascuentagastos.Activo = Activo;
				rutascuentagastos.Total = Total;
				rutascuentagastos.PadreCodigo = PadreCodigo;
				RutasCuentaGastosDataProvider.Instance.Create(Codigo, Campo, Cuenta1, NombreCuenta1, Nit2, NombreTercero2, Valor3, Cuenta4, NombreCuenta4, Cuenta5, NombreCuenta5, Nit6, NombreTercero6, Valor7, Cuenta8, NombreCuenta8, FechaCrea, Activo, Total, PadreCodigo,"RutasCuentaGastos");

				return rutascuentagastos;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Updates an RutasCuentaGastos object by passing all object's fields
		/// </summary>
		/// <param name="Codigo">long that contents the Codigo value for the RutasCuentaGastos object</param>
		/// <param name="Campo">string that contents the Campo value for the RutasCuentaGastos object</param>
		/// <param name="Cuenta1">string that contents the Cuenta1 value for the RutasCuentaGastos object</param>
		/// <param name="NombreCuenta1">string that contents the NombreCuenta1 value for the RutasCuentaGastos object</param>
		/// <param name="Nit2">string that contents the Nit2 value for the RutasCuentaGastos object</param>
		/// <param name="NombreTercero2">string that contents the NombreTercero2 value for the RutasCuentaGastos object</param>
		/// <param name="Valor3">decimal that contents the Valor3 value for the RutasCuentaGastos object</param>
		/// <param name="Cuenta4">string that contents the Cuenta4 value for the RutasCuentaGastos object</param>
		/// <param name="NombreCuenta4">string that contents the NombreCuenta4 value for the RutasCuentaGastos object</param>
		/// <param name="Cuenta5">string that contents the Cuenta5 value for the RutasCuentaGastos object</param>
		/// <param name="NombreCuenta5">string that contents the NombreCuenta5 value for the RutasCuentaGastos object</param>
		/// <param name="Nit6">string that contents the Nit6 value for the RutasCuentaGastos object</param>
		/// <param name="NombreTercero6">string that contents the NombreTercero6 value for the RutasCuentaGastos object</param>
		/// <param name="Valor7">decimal that contents the Valor7 value for the RutasCuentaGastos object</param>
		/// <param name="Cuenta8">string that contents the Cuenta8 value for the RutasCuentaGastos object</param>
		/// <param name="NombreCuenta8">string that contents the NombreCuenta8 value for the RutasCuentaGastos object</param>
		/// <param name="FechaCrea">DateTime that contents the FechaCrea value for the RutasCuentaGastos object</param>
		/// <param name="Activo">bool that contents the Activo value for the RutasCuentaGastos object</param>
		/// <param name="Total">bool that contents the Total value for the RutasCuentaGastos object</param>
		/// <param name="PadreCodigo">long that contents the PadreCodigo value for the RutasCuentaGastos object</param>
		public void Update(long Codigo, string Campo, string Cuenta1, string NombreCuenta1, string Nit2, string NombreTercero2, decimal? Valor3, string Cuenta4, string NombreCuenta4, string Cuenta5, string NombreCuenta5, string Nit6, string NombreTercero6, decimal? Valor7, string Cuenta8, string NombreCuenta8, DateTime? FechaCrea, bool? Activo, bool? Total, long? PadreCodigo, Sinapsys.Datos.SQL datosTransaccion=null)
		{
			try 
			{
				RutasCuentaGastos new_values = new RutasCuentaGastos();
				new_values.Campo = Campo;
				new_values.Cuenta1 = Cuenta1;
				new_values.NombreCuenta1 = NombreCuenta1;
				new_values.Nit2 = Nit2;
				new_values.NombreTercero2 = NombreTercero2;
				new_values.Valor3 = Valor3;
				new_values.Cuenta4 = Cuenta4;
				new_values.NombreCuenta4 = NombreCuenta4;
				new_values.Cuenta5 = Cuenta5;
				new_values.NombreCuenta5 = NombreCuenta5;
				new_values.Nit6 = Nit6;
				new_values.NombreTercero6 = NombreTercero6;
				new_values.Valor7 = Valor7;
				new_values.Cuenta8 = Cuenta8;
				new_values.NombreCuenta8 = NombreCuenta8;
				new_values.FechaCrea = FechaCrea;
				new_values.Activo = Activo;
				new_values.Total = Total;
				new_values.PadreCodigo = PadreCodigo;
				RutasCuentaGastosDataProvider.Instance.Update(Codigo, Campo, Cuenta1, NombreCuenta1, Nit2, NombreTercero2, Valor3, Cuenta4, NombreCuenta4, Cuenta5, NombreCuenta5, Nit6, NombreTercero6, Valor7, Cuenta8, NombreCuenta8, FechaCrea, Activo, Total, PadreCodigo,"RutasCuentaGastos",datosTransaccion);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Updates an RutasCuentaGastos object by passing one object's instance as reference
		/// </summary>
		/// <param name="rutascuentagastos">An instance of RutasCuentaGastos for reference</param>
		public void Update(RutasCuentaGastos rutascuentagastos,Sinapsys.Datos.SQL datosTransaccion=null)
		{
			Update(rutascuentagastos.Codigo, rutascuentagastos.Campo, rutascuentagastos.Cuenta1, rutascuentagastos.NombreCuenta1, rutascuentagastos.Nit2, rutascuentagastos.NombreTercero2, rutascuentagastos.Valor3, rutascuentagastos.Cuenta4, rutascuentagastos.NombreCuenta4, rutascuentagastos.Cuenta5, rutascuentagastos.NombreCuenta5, rutascuentagastos.Nit6, rutascuentagastos.NombreTercero6, rutascuentagastos.Valor7, rutascuentagastos.Cuenta8, rutascuentagastos.NombreCuenta8, rutascuentagastos.FechaCrea, rutascuentagastos.Activo, rutascuentagastos.Total, rutascuentagastos.PadreCodigo);
		}

		/// <summary>
		/// Delete  the RutasCuentaGastos object by passing a object
		/// </summary>
		public void  Delete(RutasCuentaGastos rutascuentagastos, Sinapsys.Datos.SQL datosTransaccion=null)
		{
			Delete(rutascuentagastos.Codigo,datosTransaccion);
		}

		/// <summary>
		/// Deletes the RutasCuentaGastos object by passing one object's instance as reference
		/// </summary>
		/// <param name="rutascuentagastos">An instance of RutasCuentaGastos for reference</param>
		public void Delete(long Codigo, Sinapsys.Datos.SQL datosTransaccion=null)
		{
			try 
			{
				RutasCuentaGastosDataProvider.Instance.Delete(Codigo,"RutasCuentaGastos");
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Deletes the RutasCuentaGastos object by passing CVS parameter as reference
		/// </summary>
		/// <param name="rutascuentagastos">An instance of RutasCuentaGastos for reference</param>
		public void Delete(string CVSParameter)
		{
			string[] StrCommand=CVSParameter.Split(',');
			try 
			{
				long Codigo=long.Parse(StrCommand[0]);
				RutasCuentaGastosDataProvider.Instance.Delete(Codigo,"RutasCuentaGastos");
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Gets the RutasCuentaGastos object by passing the object's key fields
		/// </summary>
		/// <param name="Codigo">long that contents the Codigo value for the RutasCuentaGastos object</param>
		/// <returns>One RutasCuentaGastos object</returns>
		public RutasCuentaGastos Get(long Codigo, bool generateUndo=false)
		{
			try 
			{
				RutasCuentaGastos rutascuentagastos = null;
				DataTable dt = RutasCuentaGastosDataProvider.Instance.Get(Codigo);
				if ((dt.Rows.Count > 0))
				{
					rutascuentagastos = new RutasCuentaGastos();
					DataRow dr = dt.Rows[0];
					ReadData(rutascuentagastos, dr, generateUndo);
				}


				return rutascuentagastos;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Gets all objects of RutasCuentaGastos
		/// </summary>
		/// <returns>One RutasCuentaGastosList object</returns>
		public RutasCuentaGastosList GetAll(bool generateUndo=false)
		{
			try 
			{
				RutasCuentaGastosList rutascuentagastoslist = new RutasCuentaGastosList();
				DataTable dt = RutasCuentaGastosDataProvider.Instance.GetAll();
				foreach (DataRow dr in dt.Rows)
				{
					RutasCuentaGastos rutascuentagastos = new RutasCuentaGastos();
					ReadData(rutascuentagastos, dr, generateUndo);
					rutascuentagastoslist.Add(rutascuentagastos);
				}
				return rutascuentagastoslist;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Gets all objects of RutasCuentaGastos applying filter and sort criteria
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
		/// <returns>One RutasCuentaGastosList object</returns>
		public RutasCuentaGastosList GetFilter(int pagenum, int pagesize, string filter, string sort, string extablesfilter, string extablesfieldsfilter, string extablesrelationsfilter, string extablessort, string extablesfieldssort, string extablesrelationssort, bool generateUndo=false)
		{
			try 
			{
				RutasCuentaGastosList rutascuentagastoslist = new RutasCuentaGastosList();

				DataTable dt = RutasCuentaGastosDataProvider.Instance.GetFilter(pagenum, pagesize, filter, sort, extablesfilter, extablesfieldsfilter, extablesrelationsfilter, extablessort, extablesfieldssort, extablesrelationssort);

				foreach (DataRow dr in dt.Rows)
				{
					RutasCuentaGastos rutascuentagastos = new RutasCuentaGastos();
					ReadData(rutascuentagastos, dr, generateUndo);
					rutascuentagastoslist.Add(rutascuentagastos);
				}
				return rutascuentagastoslist;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public RutasCuentaGastosList GetFilter( string filter, string sort, bool generateUndo=false)
		{
			return GetFilter(0,0, filter, sort, "","","","","","",generateUndo);
		}

		public RutasCuentaGastosList GetFilter(string filter, string sort, string extablesfilter, string extablesfieldsfilter, string extablesrelationsfilter, string extablessort, string extablesfieldssort, string extablesrelationssort, bool generateUndo=false)
		{
			return GetFilter(0,0, filter, sort, extablesfilter, extablesfieldsfilter, extablesrelationsfilter, extablessort, extablesfieldssort, extablesrelationssort,generateUndo);
		}


		/// <summary>
		/// Returns the type for one property
		/// </summary>
		/// <param name="propertyname">Property's name for return its value</param>
		/// <returns>A value for the <paramref name="propertyname"/></returns>
		public Type GetMethodType( string propertyname,RutasCuentaGastos rutascuentagastos)
		{
			// Perform the search for the property's value
			switch (propertyname)
			{
				case "Codigo":
					return rutascuentagastos.Codigo.GetType();

				case "Campo":
					return rutascuentagastos.Campo.GetType();

				case "Cuenta1":
					return rutascuentagastos.Cuenta1.GetType();

				case "NombreCuenta1":
					return rutascuentagastos.NombreCuenta1.GetType();

				case "Nit2":
					return rutascuentagastos.Nit2.GetType();

				case "NombreTercero2":
					return rutascuentagastos.NombreTercero2.GetType();

				case "Valor3":
					return rutascuentagastos.Valor3.GetType();

				case "Cuenta4":
					return rutascuentagastos.Cuenta4.GetType();

				case "NombreCuenta4":
					return rutascuentagastos.NombreCuenta4.GetType();

				case "Cuenta5":
					return rutascuentagastos.Cuenta5.GetType();

				case "NombreCuenta5":
					return rutascuentagastos.NombreCuenta5.GetType();

				case "Nit6":
					return rutascuentagastos.Nit6.GetType();

				case "NombreTercero6":
					return rutascuentagastos.NombreTercero6.GetType();

				case "Valor7":
					return rutascuentagastos.Valor7.GetType();

				case "Cuenta8":
					return rutascuentagastos.Cuenta8.GetType();

				case "NombreCuenta8":
					return rutascuentagastos.NombreCuenta8.GetType();

				case "FechaCrea":
					return rutascuentagastos.FechaCrea.GetType();

				case "Activo":
					return rutascuentagastos.Activo.GetType();

				case "Total":
					return rutascuentagastos.Total.GetType();

				case "PadreCodigo":
					return rutascuentagastos.PadreCodigo.GetType();

			}

			return null;
		}
		/// <summary>
		/// update the changes in RutasCuentaGastos object by passing the object
		/// </summary>
		public bool UpdateChanges(RutasCuentaGastos rutascuentagastos, out string error,Sinapsys.Datos.SQL datosTransaccion=null)
		{
			if (rutascuentagastos.OldRutasCuentaGastos == null)
			{
				    error = "No tiene objeto con el cual comparar";
				    return false;
			}
			string[] Fields = rutascuentagastos.FieldChanged();
			error = "";
			return LiqViajes_Bll_Data.DataProvider.UpdateFieldsbyObject(Fields, rutascuentagastos, out error,datosTransaccion);
		}
	}

	#endregion

}
