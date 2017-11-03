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
	#region Documento_ReferenciaController

	/// <summary>
	/// Class for convert data from database into object's data and vice versa
	/// </summary>
	public partial class Documento_ReferenciaController//: ILatinodeController
	{
		/// <summary>
		/// Generic Constructor
		/// </summary>
		public Documento_ReferenciaController()
		{
		}

		/// <summary>
		/// Instance accessor for this singleton
		/// </summary>
		private static Documento_ReferenciaController MySingleObj;
		public static Documento_ReferenciaController Instance
		{
			get
			{
				if (MySingleObj == null)
				{
					MySingleObj = new Documento_ReferenciaController();
				}
				return MySingleObj;
			}
		}

		// Reads object's data from a DataRow
		private void ReadData(Documento_Referencia documento_referencia, DataRow dr,bool generateUndo=false)
		{
			try 
			{
				documento_referencia.lngIdRegistro = dr.IsNull("lngIdRegistro") ? null :(int?) dr["lngIdRegistro"];
				documento_referencia.fecha = (DateTime) dr["fecha"];
				documento_referencia.valor = (decimal) dr["valor"];
				documento_referencia.ValorCruce = dr.IsNull("ValorCruce") ? null :(decimal?) dr["ValorCruce"];
				documento_referencia.sw = (byte) dr["sw"];
				documento_referencia.tipo = (string) dr["tipo"];
				documento_referencia.numero = (int) dr["numero"];
			}
			catch (Exception ex)
			{
				Utilidades.LogErrores(ex.Message + (ex.InnerException != null ? ex.InnerException.Message : ""), DataProvider.AplicacionNombre);
				throw ex;
			}
			if (generateUndo) documento_referencia.GenerateUndo();
		}

		/// <summary>
		/// Create a new Documento_Referencia object by passing a object
		/// </summary>
		public Documento_Referencia Create(Documento_Referencia documento_referencia, Sinapsys.Datos.SQL datosTransaccion=null)
		{
			return Create(documento_referencia.sw,documento_referencia.tipo,documento_referencia.numero,documento_referencia.lngIdRegistro,documento_referencia.fecha,documento_referencia.valor,documento_referencia.ValorCruce,datosTransaccion);
		}

		/// <summary>
		/// Creates a new Documento_Referencia object by passing all object's fields
		/// </summary>
		/// <param name="lngIdRegistro">int that contents the lngIdRegistro value for the Documento_Referencia object</param>
		/// <param name="fecha">DateTime that contents the fecha value for the Documento_Referencia object</param>
		/// <param name="valor">decimal that contents the valor value for the Documento_Referencia object</param>
		/// <param name="ValorCruce">decimal that contents the ValorCruce value for the Documento_Referencia object</param>
		/// <returns>One Documento_Referencia object</returns>
		public Documento_Referencia Create(byte sw, string tipo, int numero, int? lngIdRegistro, DateTime fecha, decimal valor, decimal? ValorCruce, Sinapsys.Datos.SQL datosTransaccion=null)
		{
			try 
			{
				Documento_Referencia documento_referencia = new Documento_Referencia();

				documento_referencia.sw = sw;
				documento_referencia.tipo = tipo;
				documento_referencia.numero = numero;
				documento_referencia.lngIdRegistro = lngIdRegistro;
				documento_referencia.fecha = fecha;
				documento_referencia.valor = valor;
				documento_referencia.ValorCruce = ValorCruce;
				Documento_ReferenciaDataProvider.Instance.Create(sw, tipo, numero, lngIdRegistro, fecha, valor, ValorCruce,"Documento_Referencia");

				return documento_referencia;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Updates an Documento_Referencia object by passing all object's fields
		/// </summary>
		/// <param name="lngIdRegistro">int that contents the lngIdRegistro value for the Documento_Referencia object</param>
		/// <param name="fecha">DateTime that contents the fecha value for the Documento_Referencia object</param>
		/// <param name="valor">decimal that contents the valor value for the Documento_Referencia object</param>
		/// <param name="ValorCruce">decimal that contents the ValorCruce value for the Documento_Referencia object</param>
		/// <param name="sw">byte that contents the sw value for the Documento_Referencia object</param>
		/// <param name="tipo">string that contents the tipo value for the Documento_Referencia object</param>
		/// <param name="numero">int that contents the numero value for the Documento_Referencia object</param>
		public void Update(int? lngIdRegistro, DateTime fecha, decimal valor, decimal? ValorCruce, byte sw, string tipo, int numero, Sinapsys.Datos.SQL datosTransaccion=null)
		{
			try 
			{
				Documento_Referencia new_values = new Documento_Referencia();
				new_values.lngIdRegistro = lngIdRegistro;
				new_values.fecha = fecha;
				new_values.valor = valor;
				new_values.ValorCruce = ValorCruce;
				Documento_ReferenciaDataProvider.Instance.Update(lngIdRegistro, fecha, valor, ValorCruce, sw, tipo, numero,"Documento_Referencia",datosTransaccion);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Updates an Documento_Referencia object by passing one object's instance as reference
		/// </summary>
		/// <param name="documento_referencia">An instance of Documento_Referencia for reference</param>
		public void Update(Documento_Referencia documento_referencia,Sinapsys.Datos.SQL datosTransaccion=null)
		{
			Update(documento_referencia.lngIdRegistro, documento_referencia.fecha, documento_referencia.valor, documento_referencia.ValorCruce, documento_referencia.sw, documento_referencia.tipo, documento_referencia.numero);
		}

		/// <summary>
		/// Delete  the Documento_Referencia object by passing a object
		/// </summary>
		public void  Delete(Documento_Referencia documento_referencia, Sinapsys.Datos.SQL datosTransaccion=null)
		{
			Delete(documento_referencia.sw, documento_referencia.tipo, documento_referencia.numero,datosTransaccion);
		}

		/// <summary>
		/// Deletes the Documento_Referencia object by passing one object's instance as reference
		/// </summary>
		/// <param name="documento_referencia">An instance of Documento_Referencia for reference</param>
		public void Delete(byte sw, string tipo, int numero, Sinapsys.Datos.SQL datosTransaccion=null)
		{
			try 
			{
				Documento_ReferenciaDataProvider.Instance.Delete(sw, tipo, numero,"Documento_Referencia");
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Deletes the Documento_Referencia object by passing CVS parameter as reference
		/// </summary>
		/// <param name="documento_referencia">An instance of Documento_Referencia for reference</param>
		public void Delete(string CVSParameter)
		{
			string[] StrCommand=CVSParameter.Split(',');
			try 
			{
				byte sw=byte.Parse(StrCommand[0]);
				string tipo=StrCommand[1];
				int numero=int.Parse(StrCommand[2]);
				Documento_ReferenciaDataProvider.Instance.Delete(sw, tipo, numero,"Documento_Referencia");
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Gets the Documento_Referencia object by passing the object's key fields
		/// </summary>
		/// <param name="sw">byte that contents the sw value for the Documento_Referencia object</param>
		/// <param name="tipo">string that contents the tipo value for the Documento_Referencia object</param>
		/// <param name="numero">int that contents the numero value for the Documento_Referencia object</param>
		/// <returns>One Documento_Referencia object</returns>
		public Documento_Referencia Get(byte sw, string tipo, int numero, bool generateUndo=false)
		{
			try 
			{
				Documento_Referencia documento_referencia = null;
				DataTable dt = Documento_ReferenciaDataProvider.Instance.Get(sw, tipo, numero);
				if ((dt.Rows.Count > 0))
				{
					documento_referencia = new Documento_Referencia();
					DataRow dr = dt.Rows[0];
					ReadData(documento_referencia, dr, generateUndo);
				}


				return documento_referencia;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Gets all objects of Documento_Referencia
		/// </summary>
		/// <returns>One Documento_ReferenciaList object</returns>
		public Documento_ReferenciaList GetAll(bool generateUndo=false)
		{
			try 
			{
				Documento_ReferenciaList documento_referencialist = new Documento_ReferenciaList();
				DataTable dt = Documento_ReferenciaDataProvider.Instance.GetAll();
				foreach (DataRow dr in dt.Rows)
				{
					Documento_Referencia documento_referencia = new Documento_Referencia();
					ReadData(documento_referencia, dr, generateUndo);
					documento_referencialist.Add(documento_referencia);
				}
				return documento_referencialist;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Gets all objects of Documento_Referencia applying filter and sort criteria
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
		/// <returns>One Documento_ReferenciaList object</returns>
		public Documento_ReferenciaList GetFilter(int pagenum, int pagesize, string filter, string sort, string extablesfilter, string extablesfieldsfilter, string extablesrelationsfilter, string extablessort, string extablesfieldssort, string extablesrelationssort, bool generateUndo=false)
		{
			try 
			{
				Documento_ReferenciaList documento_referencialist = new Documento_ReferenciaList();

				DataTable dt = Documento_ReferenciaDataProvider.Instance.GetFilter(pagenum, pagesize, filter, sort, extablesfilter, extablesfieldsfilter, extablesrelationsfilter, extablessort, extablesfieldssort, extablesrelationssort);

				foreach (DataRow dr in dt.Rows)
				{
					Documento_Referencia documento_referencia = new Documento_Referencia();
					ReadData(documento_referencia, dr, generateUndo);
					documento_referencialist.Add(documento_referencia);
				}
				return documento_referencialist;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public Documento_ReferenciaList GetFilter( string filter, string sort, bool generateUndo=false)
		{
			return GetFilter(0,0, filter, sort, "","","","","","",generateUndo);
		}

		public Documento_ReferenciaList GetFilter(string filter, string sort, string extablesfilter, string extablesfieldsfilter, string extablesrelationsfilter, string extablessort, string extablesfieldssort, string extablesrelationssort, bool generateUndo=false)
		{
			return GetFilter(0,0, filter, sort, extablesfilter, extablesfieldsfilter, extablesrelationsfilter, extablessort, extablesfieldssort, extablesrelationssort,generateUndo);
		}


		/// <summary>
		/// Returns the type for one property
		/// </summary>
		/// <param name="propertyname">Property's name for return its value</param>
		/// <returns>A value for the <paramref name="propertyname"/></returns>
		public Type GetMethodType( string propertyname,Documento_Referencia documento_referencia)
		{
			// Perform the search for the property's value
			switch (propertyname)
			{
				case "lngIdRegistro":
					return documento_referencia.lngIdRegistro.GetType();

				case "fecha":
					return documento_referencia.fecha.GetType();

				case "valor":
					return documento_referencia.valor.GetType();

				case "ValorCruce":
					return documento_referencia.ValorCruce.GetType();

				case "sw":
					return documento_referencia.sw.GetType();

				case "tipo":
					return documento_referencia.tipo.GetType();

				case "numero":
					return documento_referencia.numero.GetType();

			}

			return null;
		}
		/// <summary>
		/// update the changes in Documento_Referencia object by passing the object
		/// </summary>
		public bool UpdateChanges(Documento_Referencia documento_referencia, out string error,Sinapsys.Datos.SQL datosTransaccion=null)
		{
			if (documento_referencia.OldDocumento_Referencia == null)
			{
				    error = "No tiene objeto con el cual comparar";
				    return false;
			}
			string[] Fields = documento_referencia.FieldChanged();
			error = "";
			return LiqViajes_Bll_Data.DataProvider.UpdateFieldsbyObject(Fields, documento_referencia, out error,datosTransaccion);
		}
	}

	#endregion

}
