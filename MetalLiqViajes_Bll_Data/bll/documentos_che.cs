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
	#region documentos_cheController

	/// <summary>
	/// Class for convert data from database into object's data and vice versa
	/// </summary>
	public partial class documentos_cheController//: ILatinodeController
	{
		/// <summary>
		/// Generic Constructor
		/// </summary>
		public documentos_cheController()
		{
		}

		/// <summary>
		/// Instance accessor for this singleton
		/// </summary>
		private static documentos_cheController MySingleObj;
		public static documentos_cheController Instance
		{
			get
			{
				if (MySingleObj == null)
				{
					MySingleObj = new documentos_cheController();
				}
				return MySingleObj;
			}
		}

		// Reads object's data from a DataRow
		private void ReadData(documentos_che documentos_che, DataRow dr,bool generateUndo=false)
		{
			try 
			{
				documentos_che.sw = (byte) dr["sw"];
				documentos_che.fecha = (DateTime) dr["fecha"];
				documentos_che.valor = (decimal) dr["valor"];
				documentos_che.consignar_en = Convert.ToInt16(dr["consignar_en"]);
				documentos_che.devuelto = dr.IsNull("devuelto") ? null :(string) dr["devuelto"];
				documentos_che.tipo_consignacion = dr.IsNull("tipo_consignacion") ? null :(string) dr["tipo_consignacion"];
				documentos_che.numero_consignacion = dr.IsNull("numero_consignacion") ? null :(int?) dr["numero_consignacion"];
				documentos_che.fecha_devolucion = dr.IsNull("fecha_devolucion") ? null :(DateTime?) dr["fecha_devolucion"];
				documentos_che.cuenta_banco = dr.IsNull("cuenta_banco") ? null :(string) dr["cuenta_banco"];
				documentos_che.iva_tarjeta = dr.IsNull("iva_tarjeta") ? null :(decimal?) dr["iva_tarjeta"];
				documentos_che.tipo = (string) dr["tipo"];
				documentos_che.numero = (int) dr["numero"];
				documentos_che.banco = Convert.ToInt16(dr["banco"]);
				documentos_che.documento = (string) dr["documento"];
				documentos_che.forma_pago = (byte) dr["forma_pago"];
			}
			catch (Exception ex)
			{
				Utilidades.LogErrores(ex.Message + (ex.InnerException != null ? ex.InnerException.Message : ""), DataProvider.AplicacionNombre);
				throw ex;
			}
			if (generateUndo) documentos_che.GenerateUndo();
		}

		/// <summary>
		/// Create a new documentos_che object by passing a object
		/// </summary>
		public documentos_che Create(documentos_che documentos_che, Sinapsys.Datos.SQL datosTransaccion=null)
		{
			return Create(documentos_che.tipo,documentos_che.numero,documentos_che.banco,documentos_che.documento,documentos_che.forma_pago,documentos_che.sw,documentos_che.fecha,documentos_che.valor,documentos_che.consignar_en,documentos_che.devuelto,documentos_che.tipo_consignacion,documentos_che.numero_consignacion,documentos_che.fecha_devolucion,documentos_che.cuenta_banco,documentos_che.iva_tarjeta,datosTransaccion);
		}

		/// <summary>
		/// Creates a new documentos_che object by passing all object's fields
		/// </summary>
		/// <param name="sw">byte that contents the sw value for the documentos_che object</param>
		/// <param name="fecha">DateTime that contents the fecha value for the documentos_che object</param>
		/// <param name="valor">decimal that contents the valor value for the documentos_che object</param>
		/// <param name="consignar_en">short that contents the consignar_en value for the documentos_che object</param>
		/// <param name="devuelto">string that contents the devuelto value for the documentos_che object</param>
		/// <param name="tipo_consignacion">string that contents the tipo_consignacion value for the documentos_che object</param>
		/// <param name="numero_consignacion">int that contents the numero_consignacion value for the documentos_che object</param>
		/// <param name="fecha_devolucion">DateTime that contents the fecha_devolucion value for the documentos_che object</param>
		/// <param name="cuenta_banco">string that contents the cuenta_banco value for the documentos_che object</param>
		/// <param name="iva_tarjeta">decimal that contents the iva_tarjeta value for the documentos_che object</param>
		/// <returns>One documentos_che object</returns>
		public documentos_che Create(string tipo, int numero, short banco, string documento, byte forma_pago, byte sw, DateTime fecha, decimal valor, short consignar_en, string devuelto, string tipo_consignacion, int? numero_consignacion, DateTime? fecha_devolucion, string cuenta_banco, decimal? iva_tarjeta, Sinapsys.Datos.SQL datosTransaccion=null)
		{
			try 
			{
				documentos_che documentos_che = new documentos_che();

				documentos_che.tipo = tipo;
				documentos_che.numero = numero;
				documentos_che.banco = banco;
				documentos_che.documento = documento;
				documentos_che.forma_pago = forma_pago;
				documentos_che.sw = sw;
				documentos_che.fecha = fecha;
				documentos_che.valor = valor;
				documentos_che.consignar_en = consignar_en;
				documentos_che.devuelto = devuelto;
				documentos_che.tipo_consignacion = tipo_consignacion;
				documentos_che.numero_consignacion = numero_consignacion;
				documentos_che.fecha_devolucion = fecha_devolucion;
				documentos_che.cuenta_banco = cuenta_banco;
				documentos_che.iva_tarjeta = iva_tarjeta;
				documentos_cheDataProvider.Instance.Create(tipo, numero, banco, documento, forma_pago, sw, fecha, valor, consignar_en, devuelto, tipo_consignacion, numero_consignacion, fecha_devolucion, cuenta_banco, iva_tarjeta,"documentos_che");

				return documentos_che;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Updates an documentos_che object by passing all object's fields
		/// </summary>
		/// <param name="sw">byte that contents the sw value for the documentos_che object</param>
		/// <param name="fecha">DateTime that contents the fecha value for the documentos_che object</param>
		/// <param name="valor">decimal that contents the valor value for the documentos_che object</param>
		/// <param name="consignar_en">short that contents the consignar_en value for the documentos_che object</param>
		/// <param name="devuelto">string that contents the devuelto value for the documentos_che object</param>
		/// <param name="tipo_consignacion">string that contents the tipo_consignacion value for the documentos_che object</param>
		/// <param name="numero_consignacion">int that contents the numero_consignacion value for the documentos_che object</param>
		/// <param name="fecha_devolucion">DateTime that contents the fecha_devolucion value for the documentos_che object</param>
		/// <param name="cuenta_banco">string that contents the cuenta_banco value for the documentos_che object</param>
		/// <param name="iva_tarjeta">decimal that contents the iva_tarjeta value for the documentos_che object</param>
		/// <param name="tipo">string that contents the tipo value for the documentos_che object</param>
		/// <param name="numero">int that contents the numero value for the documentos_che object</param>
		/// <param name="banco">short that contents the banco value for the documentos_che object</param>
		/// <param name="documento">string that contents the documento value for the documentos_che object</param>
		/// <param name="forma_pago">byte that contents the forma_pago value for the documentos_che object</param>
		public void Update(byte sw, DateTime fecha, decimal valor, short consignar_en, string devuelto, string tipo_consignacion, int? numero_consignacion, DateTime? fecha_devolucion, string cuenta_banco, decimal? iva_tarjeta, string tipo, int numero, short banco, string documento, byte forma_pago, Sinapsys.Datos.SQL datosTransaccion=null)
		{
			try 
			{
				documentos_che new_values = new documentos_che();
				new_values.sw = sw;
				new_values.fecha = fecha;
				new_values.valor = valor;
				new_values.consignar_en = consignar_en;
				new_values.devuelto = devuelto;
				new_values.tipo_consignacion = tipo_consignacion;
				new_values.numero_consignacion = numero_consignacion;
				new_values.fecha_devolucion = fecha_devolucion;
				new_values.cuenta_banco = cuenta_banco;
				new_values.iva_tarjeta = iva_tarjeta;
				documentos_cheDataProvider.Instance.Update(sw, fecha, valor, consignar_en, devuelto, tipo_consignacion, numero_consignacion, fecha_devolucion, cuenta_banco, iva_tarjeta, tipo, numero, banco, documento, forma_pago,"documentos_che",datosTransaccion);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Updates an documentos_che object by passing one object's instance as reference
		/// </summary>
		/// <param name="documentos_che">An instance of documentos_che for reference</param>
		public void Update(documentos_che documentos_che,Sinapsys.Datos.SQL datosTransaccion=null)
		{
			Update(documentos_che.sw, documentos_che.fecha, documentos_che.valor, documentos_che.consignar_en, documentos_che.devuelto, documentos_che.tipo_consignacion, documentos_che.numero_consignacion, documentos_che.fecha_devolucion, documentos_che.cuenta_banco, documentos_che.iva_tarjeta, documentos_che.tipo, documentos_che.numero, documentos_che.banco, documentos_che.documento, documentos_che.forma_pago);
		}

		/// <summary>
		/// Delete  the documentos_che object by passing a object
		/// </summary>
		public void  Delete(documentos_che documentos_che, Sinapsys.Datos.SQL datosTransaccion=null)
		{
			Delete(documentos_che.tipo, documentos_che.numero, documentos_che.banco, documentos_che.documento, documentos_che.forma_pago,datosTransaccion);
		}

		/// <summary>
		/// Deletes the documentos_che object by passing one object's instance as reference
		/// </summary>
		/// <param name="documentos_che">An instance of documentos_che for reference</param>
		public void Delete(string tipo, int numero, short banco, string documento, byte forma_pago, Sinapsys.Datos.SQL datosTransaccion=null)
		{
			try 
			{
				documentos_cheDataProvider.Instance.Delete(tipo, numero, banco, documento, forma_pago,"documentos_che");
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Deletes the documentos_che object by passing CVS parameter as reference
		/// </summary>
		/// <param name="documentos_che">An instance of documentos_che for reference</param>
		public void Delete(string CVSParameter)
		{
			string[] StrCommand=CVSParameter.Split(',');
			try 
			{
				string tipo=StrCommand[0];
				int numero=int.Parse(StrCommand[1]);
				short banco=short.Parse(StrCommand[2]);
				string documento=StrCommand[3];
				byte forma_pago=byte.Parse(StrCommand[4]);
				documentos_cheDataProvider.Instance.Delete(tipo, numero, banco, documento, forma_pago,"documentos_che");
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Gets the documentos_che object by passing the object's key fields
		/// </summary>
		/// <param name="tipo">string that contents the tipo value for the documentos_che object</param>
		/// <param name="numero">int that contents the numero value for the documentos_che object</param>
		/// <param name="banco">short that contents the banco value for the documentos_che object</param>
		/// <param name="documento">string that contents the documento value for the documentos_che object</param>
		/// <param name="forma_pago">byte that contents the forma_pago value for the documentos_che object</param>
		/// <returns>One documentos_che object</returns>
		public documentos_che Get(string tipo, int numero, short banco, string documento, byte forma_pago, bool generateUndo=false)
		{
			try 
			{
				documentos_che documentos_che = null;
				DataTable dt = documentos_cheDataProvider.Instance.Get(tipo, numero, banco, documento, forma_pago);
				if ((dt.Rows.Count > 0))
				{
					documentos_che = new documentos_che();
					DataRow dr = dt.Rows[0];
					ReadData(documentos_che, dr, generateUndo);
				}


				return documentos_che;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Gets all objects of documentos_che
		/// </summary>
		/// <returns>One documentos_cheList object</returns>
		public documentos_cheList GetAll(bool generateUndo=false)
		{
			try 
			{
				documentos_cheList documentos_chelist = new documentos_cheList();
				DataTable dt = documentos_cheDataProvider.Instance.GetAll();
				foreach (DataRow dr in dt.Rows)
				{
					documentos_che documentos_che = new documentos_che();
					ReadData(documentos_che, dr, generateUndo);
					documentos_chelist.Add(documentos_che);
				}
				return documentos_chelist;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Gets all objects of documentos_che applying filter and sort criteria
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
		/// <returns>One documentos_cheList object</returns>
		public documentos_cheList GetFilter(int pagenum, int pagesize, string filter, string sort, string extablesfilter, string extablesfieldsfilter, string extablesrelationsfilter, string extablessort, string extablesfieldssort, string extablesrelationssort, bool generateUndo=false)
		{
			try 
			{
				documentos_cheList documentos_chelist = new documentos_cheList();

				DataTable dt = documentos_cheDataProvider.Instance.GetFilter(pagenum, pagesize, filter, sort, extablesfilter, extablesfieldsfilter, extablesrelationsfilter, extablessort, extablesfieldssort, extablesrelationssort);

				foreach (DataRow dr in dt.Rows)
				{
					documentos_che documentos_che = new documentos_che();
					ReadData(documentos_che, dr, generateUndo);
					documentos_chelist.Add(documentos_che);
				}
				return documentos_chelist;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public documentos_cheList GetFilter( string filter, string sort, bool generateUndo=false)
		{
			return GetFilter(0,0, filter, sort, "","","","","","",generateUndo);
		}

		public documentos_cheList GetFilter(string filter, string sort, string extablesfilter, string extablesfieldsfilter, string extablesrelationsfilter, string extablessort, string extablesfieldssort, string extablesrelationssort, bool generateUndo=false)
		{
			return GetFilter(0,0, filter, sort, extablesfilter, extablesfieldsfilter, extablesrelationsfilter, extablessort, extablesfieldssort, extablesrelationssort,generateUndo);
		}


		/// <summary>
		/// Returns the type for one property
		/// </summary>
		/// <param name="propertyname">Property's name for return its value</param>
		/// <returns>A value for the <paramref name="propertyname"/></returns>
		public Type GetMethodType( string propertyname,documentos_che documentos_che)
		{
			// Perform the search for the property's value
			switch (propertyname)
			{
				case "sw":
					return documentos_che.sw.GetType();

				case "fecha":
					return documentos_che.fecha.GetType();

				case "valor":
					return documentos_che.valor.GetType();

				case "consignar_en":
					return documentos_che.consignar_en.GetType();

				case "devuelto":
					return documentos_che.devuelto.GetType();

				case "tipo_consignacion":
					return documentos_che.tipo_consignacion.GetType();

				case "numero_consignacion":
					return documentos_che.numero_consignacion.GetType();

				case "fecha_devolucion":
					return documentos_che.fecha_devolucion.GetType();

				case "cuenta_banco":
					return documentos_che.cuenta_banco.GetType();

				case "iva_tarjeta":
					return documentos_che.iva_tarjeta.GetType();

				case "tipo":
					return documentos_che.tipo.GetType();

				case "numero":
					return documentos_che.numero.GetType();

				case "banco":
					return documentos_che.banco.GetType();

				case "documento":
					return documentos_che.documento.GetType();

				case "forma_pago":
					return documentos_che.forma_pago.GetType();

			}

			return null;
		}
		/// <summary>
		/// update the changes in documentos_che object by passing the object
		/// </summary>
		public bool UpdateChanges(documentos_che documentos_che, out string error,Sinapsys.Datos.SQL datosTransaccion=null)
		{
			if (documentos_che.Olddocumentos_che == null)
			{
				    error = "No tiene objeto con el cual comparar";
				    return false;
			}
			string[] Fields = documentos_che.FieldChanged();
			error = "";
			return LiqViajes_Bll_Data.DataProvider.UpdateFieldsbyObject(Fields, documentos_che, out error,datosTransaccion);
		}
	}

	#endregion

}
