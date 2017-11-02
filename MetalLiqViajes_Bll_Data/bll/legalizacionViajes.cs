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
	#region legalizacionViajesController

	/// <summary>
	/// Class for convert data from database into object's data and vice versa
	/// </summary>
	public partial class legalizacionViajesController//: ILatinodeController
	{
		/// <summary>
		/// Generic Constructor
		/// </summary>
		public legalizacionViajesController()
		{
		}

		/// <summary>
		/// Instance accessor for this singleton
		/// </summary>
		private static legalizacionViajesController MySingleObj;
		public static legalizacionViajesController Instance
		{
			get
			{
				if (MySingleObj == null)
				{
					MySingleObj = new legalizacionViajesController();
				}
				return MySingleObj;
			}
		}

		// Reads object's data from a DataRow
		private void ReadData(legalizacionViajes legalizacionviajes, DataRow dr,bool generateUndo=false)
		{
			try 
			{
				legalizacionviajes.Codigo = (long) dr["Codigo"];
				legalizacionviajes.lngIdRegistro = dr.IsNull("lngIdRegistro") ? null :(int?) dr["lngIdRegistro"];
				legalizacionviajes.sw = dr.IsNull("sw") ? null :(byte?) dr["sw"];
				legalizacionviajes.tipo = dr.IsNull("tipo") ? null :(string) dr["tipo"];
				legalizacionviajes.numero = dr.IsNull("numero") ? null :(long?) dr["numero"];
				legalizacionviajes.seq = dr.IsNull("seq") ? null :(int?) dr["seq"];
				legalizacionviajes.Fecha = dr.IsNull("Fecha") ? null :(DateTime?) dr["Fecha"];
				legalizacionviajes.nit = dr.IsNull("nit") ? null :(decimal?) dr["nit"];
				legalizacionviajes.centro = dr.IsNull("centro") ? null :(int?) dr["centro"];
				legalizacionviajes.cuenta = dr.IsNull("cuenta") ? null :(string) dr["cuenta"];
				legalizacionviajes.descripcion = dr.IsNull("descripcion") ? null :(string) dr["descripcion"];
				legalizacionviajes.valor = dr.IsNull("valor") ? null :(decimal?) dr["valor"];
				legalizacionviajes.notas = dr.IsNull("notas") ? null :(string) dr["notas"];
			}
			catch (Exception ex)
			{
				Utilidades.LogErrores(ex.Message + (ex.InnerException != null ? ex.InnerException.Message : ""), DataProvider.AplicacionNombre);
				throw ex;
			}
			if (generateUndo) legalizacionviajes.GenerateUndo();
		}

		/// <summary>
		/// Create a new legalizacionViajes object by passing a object
		/// </summary>
		public legalizacionViajes Create(legalizacionViajes legalizacionviajes, Sinapsys.Datos.SQL datosTransaccion=null)
		{
			return Create(legalizacionviajes.Codigo,legalizacionviajes.lngIdRegistro,legalizacionviajes.sw,legalizacionviajes.tipo,legalizacionviajes.numero,legalizacionviajes.seq,legalizacionviajes.Fecha,legalizacionviajes.nit,legalizacionviajes.centro,legalizacionviajes.cuenta,legalizacionviajes.descripcion,legalizacionviajes.valor,legalizacionviajes.notas,datosTransaccion);
		}

		/// <summary>
		/// Creates a new legalizacionViajes object by passing all object's fields
		/// </summary>
		/// <param name="lngIdRegistro">int that contents the lngIdRegistro value for the legalizacionViajes object</param>
		/// <param name="sw">byte that contents the sw value for the legalizacionViajes object</param>
		/// <param name="tipo">string that contents the tipo value for the legalizacionViajes object</param>
		/// <param name="numero">long that contents the numero value for the legalizacionViajes object</param>
		/// <param name="seq">int that contents the seq value for the legalizacionViajes object</param>
		/// <param name="Fecha">DateTime that contents the Fecha value for the legalizacionViajes object</param>
		/// <param name="nit">decimal that contents the nit value for the legalizacionViajes object</param>
		/// <param name="centro">int that contents the centro value for the legalizacionViajes object</param>
		/// <param name="cuenta">string that contents the cuenta value for the legalizacionViajes object</param>
		/// <param name="descripcion">string that contents the descripcion value for the legalizacionViajes object</param>
		/// <param name="valor">decimal that contents the valor value for the legalizacionViajes object</param>
		/// <param name="notas">string that contents the notas value for the legalizacionViajes object</param>
		/// <returns>One legalizacionViajes object</returns>
		public legalizacionViajes Create(long Codigo, int? lngIdRegistro, byte? sw, string tipo, long? numero, int? seq, DateTime? Fecha, decimal? nit, int? centro, string cuenta, string descripcion, decimal? valor, string notas, Sinapsys.Datos.SQL datosTransaccion=null)
		{
			try 
			{
				legalizacionViajes legalizacionviajes = new legalizacionViajes();

				legalizacionviajes.Codigo = Codigo;
				legalizacionviajes.Codigo = Codigo;
				legalizacionviajes.lngIdRegistro = lngIdRegistro;
				legalizacionviajes.sw = sw;
				legalizacionviajes.tipo = tipo;
				legalizacionviajes.numero = numero;
				legalizacionviajes.seq = seq;
				legalizacionviajes.Fecha = Fecha;
				legalizacionviajes.nit = nit;
				legalizacionviajes.centro = centro;
				legalizacionviajes.cuenta = cuenta;
				legalizacionviajes.descripcion = descripcion;
				legalizacionviajes.valor = valor;
				legalizacionviajes.notas = notas;
				Codigo = legalizacionViajesDataProvider.Instance.Create(Codigo, lngIdRegistro, sw, tipo, numero, seq, Fecha, nit, centro, cuenta, descripcion, valor, notas,"legalizacionViajes",datosTransaccion);
				if (Codigo == 0)
					return null;

				legalizacionviajes.Codigo = Codigo;

				return legalizacionviajes;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Updates an legalizacionViajes object by passing all object's fields
		/// </summary>
		/// <param name="Codigo">long that contents the Codigo value for the legalizacionViajes object</param>
		/// <param name="lngIdRegistro">int that contents the lngIdRegistro value for the legalizacionViajes object</param>
		/// <param name="sw">byte that contents the sw value for the legalizacionViajes object</param>
		/// <param name="tipo">string that contents the tipo value for the legalizacionViajes object</param>
		/// <param name="numero">long that contents the numero value for the legalizacionViajes object</param>
		/// <param name="seq">int that contents the seq value for the legalizacionViajes object</param>
		/// <param name="Fecha">DateTime that contents the Fecha value for the legalizacionViajes object</param>
		/// <param name="nit">decimal that contents the nit value for the legalizacionViajes object</param>
		/// <param name="centro">int that contents the centro value for the legalizacionViajes object</param>
		/// <param name="cuenta">string that contents the cuenta value for the legalizacionViajes object</param>
		/// <param name="descripcion">string that contents the descripcion value for the legalizacionViajes object</param>
		/// <param name="valor">decimal that contents the valor value for the legalizacionViajes object</param>
		/// <param name="notas">string that contents the notas value for the legalizacionViajes object</param>
		public void Update(long Codigo, int? lngIdRegistro, byte? sw, string tipo, long? numero, int? seq, DateTime? Fecha, decimal? nit, int? centro, string cuenta, string descripcion, decimal? valor, string notas, Sinapsys.Datos.SQL datosTransaccion=null)
		{
			try 
			{
				legalizacionViajes new_values = new legalizacionViajes();
				new_values.lngIdRegistro = lngIdRegistro;
				new_values.sw = sw;
				new_values.tipo = tipo;
				new_values.numero = numero;
				new_values.seq = seq;
				new_values.Fecha = Fecha;
				new_values.nit = nit;
				new_values.centro = centro;
				new_values.cuenta = cuenta;
				new_values.descripcion = descripcion;
				new_values.valor = valor;
				new_values.notas = notas;
				legalizacionViajesDataProvider.Instance.Update(Codigo, lngIdRegistro, sw, tipo, numero, seq, Fecha, nit, centro, cuenta, descripcion, valor, notas,"legalizacionViajes",datosTransaccion);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Updates an legalizacionViajes object by passing one object's instance as reference
		/// </summary>
		/// <param name="legalizacionviajes">An instance of legalizacionViajes for reference</param>
		public void Update(legalizacionViajes legalizacionviajes,Sinapsys.Datos.SQL datosTransaccion=null)
		{
			Update(legalizacionviajes.Codigo, legalizacionviajes.lngIdRegistro, legalizacionviajes.sw, legalizacionviajes.tipo, legalizacionviajes.numero, legalizacionviajes.seq, legalizacionviajes.Fecha, legalizacionviajes.nit, legalizacionviajes.centro, legalizacionviajes.cuenta, legalizacionviajes.descripcion, legalizacionviajes.valor, legalizacionviajes.notas);
		}

		/// <summary>
		/// Delete  the legalizacionViajes object by passing a object
		/// </summary>
		public void  Delete(legalizacionViajes legalizacionviajes, Sinapsys.Datos.SQL datosTransaccion=null)
		{
			Delete(legalizacionviajes.Codigo,datosTransaccion);
		}

		/// <summary>
		/// Deletes the legalizacionViajes object by passing one object's instance as reference
		/// </summary>
		/// <param name="legalizacionviajes">An instance of legalizacionViajes for reference</param>
		public void Delete(long Codigo, Sinapsys.Datos.SQL datosTransaccion=null)
		{
			try 
			{
				//legalizacionViajes old_values = legalizacionViajesController.Instance.Get(Codigo);
				//if(!Validate.security.CanDeleteSecurityField(legalizacionViajesController.Instance, (ILatinodeObject)old_values))
				//    throw new Exception("Access denied by security field, you can't delete object");

				legalizacionViajesDataProvider.Instance.Delete(Codigo,"legalizacionViajes");
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Deletes the legalizacionViajes object by passing CVS parameter as reference
		/// </summary>
		/// <param name="legalizacionviajes">An instance of legalizacionViajes for reference</param>
		public void Delete(string CVSParameter)
		{
			string[] StrCommand=CVSParameter.Split(',');
			try 
			{
				long Codigo=long.Parse(StrCommand[0]);
				legalizacionViajesDataProvider.Instance.Delete(Codigo,"legalizacionViajes");
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Gets the legalizacionViajes object by passing the object's key fields
		/// </summary>
		/// <param name="Codigo">long that contents the Codigo value for the legalizacionViajes object</param>
		/// <returns>One legalizacionViajes object</returns>
		public legalizacionViajes Get(long Codigo, bool generateUndo=false)
		{
			try 
			{
				legalizacionViajes legalizacionviajes = null;
				DataTable dt = legalizacionViajesDataProvider.Instance.Get(Codigo);
				if ((dt.Rows.Count > 0))
				{
					legalizacionviajes = new legalizacionViajes();
					DataRow dr = dt.Rows[0];
					ReadData(legalizacionviajes, dr, generateUndo);
				}


				return legalizacionviajes;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Gets all objects of legalizacionViajes
		/// </summary>
		/// <returns>One legalizacionViajesList object</returns>
		public legalizacionViajesList GetAll(bool generateUndo=false)
		{
			try 
			{
				legalizacionViajesList legalizacionviajeslist = new legalizacionViajesList();
				DataTable dt = legalizacionViajesDataProvider.Instance.GetAll();
				foreach (DataRow dr in dt.Rows)
				{
					legalizacionViajes legalizacionviajes = new legalizacionViajes();
					ReadData(legalizacionviajes, dr, generateUndo);
					legalizacionviajeslist.Add(legalizacionviajes);
				}
				return legalizacionviajeslist;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Gets all objects of legalizacionViajes applying filter and sort criteria
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
		/// <returns>One legalizacionViajesList object</returns>
		public legalizacionViajesList GetFilter(int pagenum, int pagesize, string filter, string sort, string extablesfilter, string extablesfieldsfilter, string extablesrelationsfilter, string extablessort, string extablesfieldssort, string extablesrelationssort, bool generateUndo=false)
		{
			try 
			{
				legalizacionViajesList legalizacionviajeslist = new legalizacionViajesList();

				DataTable dt = legalizacionViajesDataProvider.Instance.GetFilter(pagenum, pagesize, filter, sort, extablesfilter, extablesfieldsfilter, extablesrelationsfilter, extablessort, extablesfieldssort, extablesrelationssort);

				foreach (DataRow dr in dt.Rows)
				{
					legalizacionViajes legalizacionviajes = new legalizacionViajes();
					ReadData(legalizacionviajes, dr, generateUndo);
					legalizacionviajeslist.Add(legalizacionviajes);
				}
				return legalizacionviajeslist;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public legalizacionViajesList GetFilter( string filter, string sort, bool generateUndo=false)
		{
			return GetFilter(0,0, filter, sort, "","","","","","",generateUndo);
		}

		public legalizacionViajesList GetFilter(string filter, string sort, string extablesfilter, string extablesfieldsfilter, string extablesrelationsfilter, string extablessort, string extablesfieldssort, string extablesrelationssort, bool generateUndo=false)
		{
			return GetFilter(0,0, filter, sort, extablesfilter, extablesfieldsfilter, extablesrelationsfilter, extablessort, extablesfieldssort, extablesrelationssort,generateUndo);
		}


		/// <summary>
		/// Returns the type for one property
		/// </summary>
		/// <param name="propertyname">Property's name for return its value</param>
		/// <returns>A value for the <paramref name="propertyname"/></returns>
		public Type GetMethodType( string propertyname,legalizacionViajes legalizacionviajes)
		{
			// Perform the search for the property's value
			switch (propertyname)
			{
				case "Codigo":
					return legalizacionviajes.Codigo.GetType();

				case "lngIdRegistro":
					return legalizacionviajes.lngIdRegistro.GetType();

				case "sw":
					return legalizacionviajes.sw.GetType();

				case "tipo":
					return legalizacionviajes.tipo.GetType();

				case "numero":
					return legalizacionviajes.numero.GetType();

				case "seq":
					return legalizacionviajes.seq.GetType();

				case "Fecha":
					return legalizacionviajes.Fecha.GetType();

				case "nit":
					return legalizacionviajes.nit.GetType();

				case "centro":
					return legalizacionviajes.centro.GetType();

				case "cuenta":
					return legalizacionviajes.cuenta.GetType();

				case "descripcion":
					return legalizacionviajes.descripcion.GetType();

				case "valor":
					return legalizacionviajes.valor.GetType();

				case "notas":
					return legalizacionviajes.notas.GetType();

			}

			return null;
		}
		/// <summary>
		/// update the changes in legalizacionViajes object by passing the object
		/// </summary>
		public bool UpdateChanges(legalizacionViajes legalizacionviajes, out string error,Sinapsys.Datos.SQL datosTransaccion=null)
		{
			if (legalizacionviajes.OldlegalizacionViajes == null)
			{
				    error = "No tiene objeto con el cual comparar";
				    return false;
			}
			string[] Fields = legalizacionviajes.FieldChanged();
			error = "";
			return LiqViajes_Bll_Data.DataProvider.UpdateFieldsbyObject(Fields, legalizacionviajes, out error,datosTransaccion);
		}
	}

	#endregion

}
