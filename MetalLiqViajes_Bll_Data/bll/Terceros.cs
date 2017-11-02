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
	#region TercerosController

	/// <summary>
	/// Class for convert data from database into object's data and vice versa
	/// </summary>
	public partial class TercerosController//: ILatinodeController
	{
		/// <summary>
		/// Generic Constructor
		/// </summary>
		public TercerosController()
		{
		}

		/// <summary>
		/// Instance accessor for this singleton
		/// </summary>
		private static TercerosController MySingleObj;
		public static TercerosController Instance
		{
			get
			{
				if (MySingleObj == null)
				{
					MySingleObj = new TercerosController();
				}
				return MySingleObj;
			}
		}

		// Reads object's data from a DataRow
		private void ReadData(Terceros terceros, DataRow dr,bool generateUndo=false)
		{
			try 
			{
				terceros.NitConductor = (decimal) dr["NitConductor"];
				terceros.Identificacion = dr.IsNull("Identificacion") ? null :(long?) dr["Identificacion"];
				terceros.TipoIdentificacion = dr.IsNull("TipoIdentificacion") ? null :(char?) ((string) dr["TipoIdentificacion"])[0];
				terceros.Digito = dr.IsNull("Digito") ? null :(byte?) dr["Digito"];
				terceros.NombreCompleto = dr.IsNull("NombreCompleto") ? null :(string) dr["NombreCompleto"];
				terceros.Concepto_3 = dr.IsNull("Concepto_3") ? null :(string) dr["Concepto_3"];
				terceros.CentroCosto = dr.IsNull("CentroCosto") ? null :(int?) dr["CentroCosto"];
				terceros.Direccion = dr.IsNull("Direccion") ? null :(string) dr["Direccion"];
				terceros.NombreCiudad = dr.IsNull("NombreCiudad") ? null :(string) dr["NombreCiudad"];
				terceros.Pais = dr.IsNull("Pais") ? null :(string) dr["Pais"];
				terceros.Telefono1 = dr.IsNull("Telefono1") ? null :(string) dr["Telefono1"];
				terceros.Telefono2 = dr.IsNull("Telefono2") ? null :(string) dr["Telefono2"];
				terceros.Telefono3 = dr.IsNull("Telefono3") ? null :(string) dr["Telefono3"];
				terceros.ApartadoAreo = dr.IsNull("ApartadoAreo") ? null :(string) dr["ApartadoAreo"];
			}
			catch (Exception ex)
			{
				Utilidades.LogErrores(ex.Message + (ex.InnerException != null ? ex.InnerException.Message : ""), DataProvider.AplicacionNombre);
				throw ex;
			}
			if (generateUndo) terceros.GenerateUndo();
		}

		/// <summary>
		/// Create a new Terceros object by passing a object
		/// </summary>
		public Terceros Create(Terceros terceros, Sinapsys.Datos.SQL datosTransaccion=null)
		{
			return Create(terceros.NitConductor,terceros.Identificacion,terceros.TipoIdentificacion,terceros.Digito,terceros.NombreCompleto,terceros.Concepto_3,terceros.CentroCosto,terceros.Direccion,terceros.NombreCiudad,terceros.Pais,terceros.Telefono1,terceros.Telefono2,terceros.Telefono3,terceros.ApartadoAreo,datosTransaccion);
		}

		/// <summary>
		/// Creates a new Terceros object by passing all object's fields
		/// </summary>
		/// <param name="Identificacion">long that contents the Identificacion value for the Terceros object</param>
		/// <param name="TipoIdentificacion">char that contents the TipoIdentificacion value for the Terceros object</param>
		/// <param name="Digito">byte that contents the Digito value for the Terceros object</param>
		/// <param name="NombreCompleto">string that contents the NombreCompleto value for the Terceros object</param>
		/// <param name="Concepto_3">string that contents the Concepto_3 value for the Terceros object</param>
		/// <param name="CentroCosto">int that contents the CentroCosto value for the Terceros object</param>
		/// <param name="Direccion">string that contents the Direccion value for the Terceros object</param>
		/// <param name="NombreCiudad">string that contents the NombreCiudad value for the Terceros object</param>
		/// <param name="Pais">string that contents the Pais value for the Terceros object</param>
		/// <param name="Telefono1">string that contents the Telefono1 value for the Terceros object</param>
		/// <param name="Telefono2">string that contents the Telefono2 value for the Terceros object</param>
		/// <param name="Telefono3">string that contents the Telefono3 value for the Terceros object</param>
		/// <param name="ApartadoAreo">string that contents the ApartadoAreo value for the Terceros object</param>
		/// <returns>One Terceros object</returns>
		public Terceros Create(decimal NitConductor, long? Identificacion, char? TipoIdentificacion, byte? Digito, string NombreCompleto, string Concepto_3, int? CentroCosto, string Direccion, string NombreCiudad, string Pais, string Telefono1, string Telefono2, string Telefono3, string ApartadoAreo, Sinapsys.Datos.SQL datosTransaccion=null)
		{
			try 
			{
				Terceros terceros = new Terceros();

				terceros.NitConductor = NitConductor;
				terceros.Identificacion = Identificacion;
				terceros.TipoIdentificacion = TipoIdentificacion;
				terceros.Digito = Digito;
				terceros.NombreCompleto = NombreCompleto;
				terceros.Concepto_3 = Concepto_3;
				terceros.CentroCosto = CentroCosto;
				terceros.Direccion = Direccion;
				terceros.NombreCiudad = NombreCiudad;
				terceros.Pais = Pais;
				terceros.Telefono1 = Telefono1;
				terceros.Telefono2 = Telefono2;
				terceros.Telefono3 = Telefono3;
				terceros.ApartadoAreo = ApartadoAreo;
				TercerosDataProvider.Instance.Create(NitConductor, Identificacion, TipoIdentificacion, Digito, NombreCompleto, Concepto_3, CentroCosto, Direccion, NombreCiudad, Pais, Telefono1, Telefono2, Telefono3, ApartadoAreo,"Terceros");

				return terceros;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Updates an Terceros object by passing all object's fields
		/// </summary>
		/// <param name="NitConductor">decimal that contents the NitConductor value for the Terceros object</param>
		/// <param name="Identificacion">long that contents the Identificacion value for the Terceros object</param>
		/// <param name="TipoIdentificacion">char that contents the TipoIdentificacion value for the Terceros object</param>
		/// <param name="Digito">byte that contents the Digito value for the Terceros object</param>
		/// <param name="NombreCompleto">string that contents the NombreCompleto value for the Terceros object</param>
		/// <param name="Concepto_3">string that contents the Concepto_3 value for the Terceros object</param>
		/// <param name="CentroCosto">int that contents the CentroCosto value for the Terceros object</param>
		/// <param name="Direccion">string that contents the Direccion value for the Terceros object</param>
		/// <param name="NombreCiudad">string that contents the NombreCiudad value for the Terceros object</param>
		/// <param name="Pais">string that contents the Pais value for the Terceros object</param>
		/// <param name="Telefono1">string that contents the Telefono1 value for the Terceros object</param>
		/// <param name="Telefono2">string that contents the Telefono2 value for the Terceros object</param>
		/// <param name="Telefono3">string that contents the Telefono3 value for the Terceros object</param>
		/// <param name="ApartadoAreo">string that contents the ApartadoAreo value for the Terceros object</param>
		public void Update(decimal NitConductor, long? Identificacion, char? TipoIdentificacion, byte? Digito, string NombreCompleto, string Concepto_3, int? CentroCosto, string Direccion, string NombreCiudad, string Pais, string Telefono1, string Telefono2, string Telefono3, string ApartadoAreo, Sinapsys.Datos.SQL datosTransaccion=null)
		{
			try 
			{
				Terceros new_values = new Terceros();
				new_values.Identificacion = Identificacion;
				new_values.TipoIdentificacion = TipoIdentificacion;
				new_values.Digito = Digito;
				new_values.NombreCompleto = NombreCompleto;
				new_values.Concepto_3 = Concepto_3;
				new_values.CentroCosto = CentroCosto;
				new_values.Direccion = Direccion;
				new_values.NombreCiudad = NombreCiudad;
				new_values.Pais = Pais;
				new_values.Telefono1 = Telefono1;
				new_values.Telefono2 = Telefono2;
				new_values.Telefono3 = Telefono3;
				new_values.ApartadoAreo = ApartadoAreo;
				TercerosDataProvider.Instance.Update(NitConductor, Identificacion, TipoIdentificacion, Digito, NombreCompleto, Concepto_3, CentroCosto, Direccion, NombreCiudad, Pais, Telefono1, Telefono2, Telefono3, ApartadoAreo,"Terceros",datosTransaccion);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Updates an Terceros object by passing one object's instance as reference
		/// </summary>
		/// <param name="terceros">An instance of Terceros for reference</param>
		public void Update(Terceros terceros,Sinapsys.Datos.SQL datosTransaccion=null)
		{
			Update(terceros.NitConductor, terceros.Identificacion, terceros.TipoIdentificacion, terceros.Digito, terceros.NombreCompleto, terceros.Concepto_3, terceros.CentroCosto, terceros.Direccion, terceros.NombreCiudad, terceros.Pais, terceros.Telefono1, terceros.Telefono2, terceros.Telefono3, terceros.ApartadoAreo);
		}

		/// <summary>
		/// Delete  the Terceros object by passing a object
		/// </summary>
		public void  Delete(Terceros terceros, Sinapsys.Datos.SQL datosTransaccion=null)
		{
			Delete(terceros.NitConductor,datosTransaccion);
		}

		/// <summary>
		/// Deletes the Terceros object by passing one object's instance as reference
		/// </summary>
		/// <param name="terceros">An instance of Terceros for reference</param>
		public void Delete(decimal NitConductor, Sinapsys.Datos.SQL datosTransaccion=null)
		{
			try 
			{
				TercerosDataProvider.Instance.Delete(NitConductor,"Terceros");
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Deletes the Terceros object by passing CVS parameter as reference
		/// </summary>
		/// <param name="terceros">An instance of Terceros for reference</param>
		public void Delete(string CVSParameter)
		{
			string[] StrCommand=CVSParameter.Split(',');
			try 
			{
				decimal NitConductor=decimal.Parse(StrCommand[0]);
				TercerosDataProvider.Instance.Delete(NitConductor,"Terceros");
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Gets the Terceros object by passing the object's key fields
		/// </summary>
		/// <param name="NitConductor">decimal that contents the NitConductor value for the Terceros object</param>
		/// <returns>One Terceros object</returns>
		public Terceros Get(decimal NitConductor, bool generateUndo=false)
		{
			try 
			{
				Terceros terceros = null;
				DataTable dt = TercerosDataProvider.Instance.Get(NitConductor);
				if ((dt.Rows.Count > 0))
				{
					terceros = new Terceros();
					DataRow dr = dt.Rows[0];
					ReadData(terceros, dr, generateUndo);
				}


				return terceros;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Gets all objects of Terceros
		/// </summary>
		/// <returns>One TercerosList object</returns>
		public TercerosList GetAll(bool generateUndo=false)
		{
			try 
			{
				TercerosList terceroslist = new TercerosList();
				DataTable dt = TercerosDataProvider.Instance.GetAll();
				foreach (DataRow dr in dt.Rows)
				{
					Terceros terceros = new Terceros();
					ReadData(terceros, dr, generateUndo);
					terceroslist.Add(terceros);
				}
				return terceroslist;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Gets all objects of Terceros applying filter and sort criteria
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
		/// <returns>One TercerosList object</returns>
		public TercerosList GetFilter(int pagenum, int pagesize, string filter, string sort, string extablesfilter, string extablesfieldsfilter, string extablesrelationsfilter, string extablessort, string extablesfieldssort, string extablesrelationssort, bool generateUndo=false)
		{
			try 
			{
				TercerosList terceroslist = new TercerosList();

				DataTable dt = TercerosDataProvider.Instance.GetFilter(pagenum, pagesize, filter, sort, extablesfilter, extablesfieldsfilter, extablesrelationsfilter, extablessort, extablesfieldssort, extablesrelationssort);

				foreach (DataRow dr in dt.Rows)
				{
					Terceros terceros = new Terceros();
					ReadData(terceros, dr, generateUndo);
					terceroslist.Add(terceros);
				}
				return terceroslist;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public TercerosList GetFilter( string filter, string sort, bool generateUndo=false)
		{
			return GetFilter(0,0, filter, sort, "","","","","","",generateUndo);
		}

		public TercerosList GetFilter(string filter, string sort, string extablesfilter, string extablesfieldsfilter, string extablesrelationsfilter, string extablessort, string extablesfieldssort, string extablesrelationssort, bool generateUndo=false)
		{
			return GetFilter(0,0, filter, sort, extablesfilter, extablesfieldsfilter, extablesrelationsfilter, extablessort, extablesfieldssort, extablesrelationssort,generateUndo);
		}


		/// <summary>
		/// Returns the type for one property
		/// </summary>
		/// <param name="propertyname">Property's name for return its value</param>
		/// <returns>A value for the <paramref name="propertyname"/></returns>
		public Type GetMethodType( string propertyname,Terceros terceros)
		{
			// Perform the search for the property's value
			switch (propertyname)
			{
				case "NitConductor":
					return terceros.NitConductor.GetType();

				case "Identificacion":
					return terceros.Identificacion.GetType();

				case "TipoIdentificacion":
					return terceros.TipoIdentificacion.GetType();

				case "Digito":
					return terceros.Digito.GetType();

				case "NombreCompleto":
					return terceros.NombreCompleto.GetType();

				case "Concepto_3":
					return terceros.Concepto_3.GetType();

				case "CentroCosto":
					return terceros.CentroCosto.GetType();

				case "Direccion":
					return terceros.Direccion.GetType();

				case "NombreCiudad":
					return terceros.NombreCiudad.GetType();

				case "Pais":
					return terceros.Pais.GetType();

				case "Telefono1":
					return terceros.Telefono1.GetType();

				case "Telefono2":
					return terceros.Telefono2.GetType();

				case "Telefono3":
					return terceros.Telefono3.GetType();

				case "ApartadoAreo":
					return terceros.ApartadoAreo.GetType();

			}

			return null;
		}
		/// <summary>
		/// update the changes in Terceros object by passing the object
		/// </summary>
		public bool UpdateChanges(Terceros terceros, out string error,Sinapsys.Datos.SQL datosTransaccion=null)
		{
			if (terceros.OldTerceros == null)
			{
				    error = "No tiene objeto con el cual comparar";
				    return false;
			}
			string[] Fields = terceros.FieldChanged();
			error = "";
			return LiqViajes_Bll_Data.DataProvider.UpdateFieldsbyObject(Fields, terceros, out error,datosTransaccion);
		}
	}

	#endregion

}
