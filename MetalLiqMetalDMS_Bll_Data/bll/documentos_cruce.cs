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

namespace LiqMetalDMS_Bll_Data
{
	#region documentos_cruceController

	/// <summary>
	/// Class for convert data from database into object's data and vice versa
	/// </summary>
	public partial class documentos_cruceController//: ILatinodeController
	{
		/// <summary>
		/// Generic Constructor
		/// </summary>
		public documentos_cruceController()
		{
		}

		/// <summary>
		/// Instance accessor for this singleton
		/// </summary>
		private static documentos_cruceController MySingleObj;
		public static documentos_cruceController Instance
		{
			get
			{
				if (MySingleObj == null)
				{
					MySingleObj = new documentos_cruceController();
				}
				return MySingleObj;
			}
		}

		// Reads object's data from a DataRow
		private void ReadData(documentos_cruce documentos_cruce, DataRow dr,bool generateUndo=false)
		{
			try 
			{
				documentos_cruce.id = (int) dr["id"];
				documentos_cruce.tipo = (string) dr["tipo"];
				documentos_cruce.numero = (int) dr["numero"];
				documentos_cruce.sw = (byte) dr["sw"];
				documentos_cruce.tipo_aplica = (string) dr["tipo_aplica"];
				documentos_cruce.numero_aplica = (int) dr["numero_aplica"];
				documentos_cruce.numero_cuota = Convert.ToInt16(dr["numero_cuota"]);
				documentos_cruce.valor = dr.IsNull("valor") ? null :(decimal?) dr["valor"];
				documentos_cruce.descuento = dr.IsNull("descuento") ? null :(decimal?) dr["descuento"];
				documentos_cruce.retencion = dr.IsNull("retencion") ? null :(decimal?) dr["retencion"];
				documentos_cruce.ajuste = dr.IsNull("ajuste") ? null :(decimal?) dr["ajuste"];
				documentos_cruce.retencion_iva = dr.IsNull("retencion_iva") ? null :(decimal?) dr["retencion_iva"];
				documentos_cruce.retencion_ica = dr.IsNull("retencion_ica") ? null :(decimal?) dr["retencion_ica"];
				documentos_cruce.fecha = dr.IsNull("fecha") ? null :(DateTime?) dr["fecha"];
				documentos_cruce.retencion2 = dr.IsNull("retencion2") ? null :(decimal?) dr["retencion2"];
				documentos_cruce.retencion3 = dr.IsNull("retencion3") ? null :(decimal?) dr["retencion3"];
				documentos_cruce.fecha_cruce = dr.IsNull("fecha_cruce") ? null :(DateTime?) dr["fecha_cruce"];
				documentos_cruce.trasporte = dr.IsNull("trasporte") ? null :(char?) ((string) dr["trasporte"])[0];
				documentos_cruce.cree = dr.IsNull("cree") ? null :(decimal?) dr["cree"];
			}
			catch (Exception ex)
			{
				Utilidades.LogErrores(ex.Message + (ex.InnerException != null ? ex.InnerException.Message : ""), DataProvider.AplicacionNombre);
				throw ex;
			}
			if (generateUndo) documentos_cruce.GenerateUndo();
		}

		/// <summary>
		/// Create a new documentos_cruce object by passing a object
		/// </summary>
		public documentos_cruce Create(documentos_cruce documentos_cruce, Sinapsys.Datos.SQL datosTransaccion=null)
		{
			return Create(documentos_cruce.id,documentos_cruce.tipo,documentos_cruce.numero,documentos_cruce.tipo_aplica,documentos_cruce.numero_aplica,documentos_cruce.numero_cuota,documentos_cruce.sw,documentos_cruce.valor,documentos_cruce.descuento,documentos_cruce.retencion,documentos_cruce.ajuste,documentos_cruce.retencion_iva,documentos_cruce.retencion_ica,documentos_cruce.fecha,documentos_cruce.retencion2,documentos_cruce.retencion3,documentos_cruce.fecha_cruce,documentos_cruce.trasporte,documentos_cruce.cree,datosTransaccion);
		}

		/// <summary>
		/// Creates a new documentos_cruce object by passing all object's fields
		/// </summary>
		/// <param name="sw">byte that contents the sw value for the documentos_cruce object</param>
		/// <param name="valor">decimal that contents the valor value for the documentos_cruce object</param>
		/// <param name="descuento">decimal that contents the descuento value for the documentos_cruce object</param>
		/// <param name="retencion">decimal that contents the retencion value for the documentos_cruce object</param>
		/// <param name="ajuste">decimal that contents the ajuste value for the documentos_cruce object</param>
		/// <param name="retencion_iva">decimal that contents the retencion_iva value for the documentos_cruce object</param>
		/// <param name="retencion_ica">decimal that contents the retencion_ica value for the documentos_cruce object</param>
		/// <param name="fecha">DateTime that contents the fecha value for the documentos_cruce object</param>
		/// <param name="retencion2">decimal that contents the retencion2 value for the documentos_cruce object</param>
		/// <param name="retencion3">decimal that contents the retencion3 value for the documentos_cruce object</param>
		/// <param name="fecha_cruce">DateTime that contents the fecha_cruce value for the documentos_cruce object</param>
		/// <param name="trasporte">char that contents the trasporte value for the documentos_cruce object</param>
		/// <param name="cree">decimal that contents the cree value for the documentos_cruce object</param>
		/// <returns>One documentos_cruce object</returns>
		public documentos_cruce Create(int id, string tipo, int numero, string tipo_aplica, int numero_aplica, short numero_cuota, byte sw, decimal? valor, decimal? descuento, decimal? retencion, decimal? ajuste, decimal? retencion_iva, decimal? retencion_ica, DateTime? fecha, decimal? retencion2, decimal? retencion3, DateTime? fecha_cruce, char? trasporte, decimal? cree, Sinapsys.Datos.SQL datosTransaccion=null)
		{
			try 
			{
				documentos_cruce documentos_cruce = new documentos_cruce();

				documentos_cruce.id = id;
				documentos_cruce.id = id;
				documentos_cruce.tipo = tipo;
				documentos_cruce.numero = numero;
				documentos_cruce.tipo_aplica = tipo_aplica;
				documentos_cruce.numero_aplica = numero_aplica;
				documentos_cruce.numero_cuota = numero_cuota;
				documentos_cruce.sw = sw;
				documentos_cruce.valor = valor;
				documentos_cruce.descuento = descuento;
				documentos_cruce.retencion = retencion;
				documentos_cruce.ajuste = ajuste;
				documentos_cruce.retencion_iva = retencion_iva;
				documentos_cruce.retencion_ica = retencion_ica;
				documentos_cruce.fecha = fecha;
				documentos_cruce.retencion2 = retencion2;
				documentos_cruce.retencion3 = retencion3;
				documentos_cruce.fecha_cruce = fecha_cruce;
				documentos_cruce.trasporte = trasporte;
				documentos_cruce.cree = cree;
				id = documentos_cruceDataProvider.Instance.Create(id, tipo, numero, tipo_aplica, numero_aplica, numero_cuota, sw, valor, descuento, retencion, ajuste, retencion_iva, retencion_ica, fecha, retencion2, retencion3, fecha_cruce, trasporte, cree,"documentos_cruce",datosTransaccion);
				if (id == 0)
					return null;

				documentos_cruce.id = id;

				return documentos_cruce;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Updates an documentos_cruce object by passing all object's fields
		/// </summary>
		/// <param name="id">int that contents the id value for the documentos_cruce object</param>
		/// <param name="tipo">string that contents the tipo value for the documentos_cruce object</param>
		/// <param name="numero">int that contents the numero value for the documentos_cruce object</param>
		/// <param name="sw">byte that contents the sw value for the documentos_cruce object</param>
		/// <param name="tipo_aplica">string that contents the tipo_aplica value for the documentos_cruce object</param>
		/// <param name="numero_aplica">int that contents the numero_aplica value for the documentos_cruce object</param>
		/// <param name="numero_cuota">short that contents the numero_cuota value for the documentos_cruce object</param>
		/// <param name="valor">decimal that contents the valor value for the documentos_cruce object</param>
		/// <param name="descuento">decimal that contents the descuento value for the documentos_cruce object</param>
		/// <param name="retencion">decimal that contents the retencion value for the documentos_cruce object</param>
		/// <param name="ajuste">decimal that contents the ajuste value for the documentos_cruce object</param>
		/// <param name="retencion_iva">decimal that contents the retencion_iva value for the documentos_cruce object</param>
		/// <param name="retencion_ica">decimal that contents the retencion_ica value for the documentos_cruce object</param>
		/// <param name="fecha">DateTime that contents the fecha value for the documentos_cruce object</param>
		/// <param name="retencion2">decimal that contents the retencion2 value for the documentos_cruce object</param>
		/// <param name="retencion3">decimal that contents the retencion3 value for the documentos_cruce object</param>
		/// <param name="fecha_cruce">DateTime that contents the fecha_cruce value for the documentos_cruce object</param>
		/// <param name="trasporte">char that contents the trasporte value for the documentos_cruce object</param>
		/// <param name="cree">decimal that contents the cree value for the documentos_cruce object</param>
		public void Update(int id, string tipo, int numero, byte sw, string tipo_aplica, int numero_aplica, short numero_cuota, decimal? valor, decimal? descuento, decimal? retencion, decimal? ajuste, decimal? retencion_iva, decimal? retencion_ica, DateTime? fecha, decimal? retencion2, decimal? retencion3, DateTime? fecha_cruce, char? trasporte, decimal? cree, Sinapsys.Datos.SQL datosTransaccion=null)
		{
			try 
			{
				documentos_cruce new_values = new documentos_cruce();
				new_values.sw = sw;
				new_values.valor = valor;
				new_values.descuento = descuento;
				new_values.retencion = retencion;
				new_values.ajuste = ajuste;
				new_values.retencion_iva = retencion_iva;
				new_values.retencion_ica = retencion_ica;
				new_values.fecha = fecha;
				new_values.retencion2 = retencion2;
				new_values.retencion3 = retencion3;
				new_values.fecha_cruce = fecha_cruce;
				new_values.trasporte = trasporte;
				new_values.cree = cree;
				documentos_cruceDataProvider.Instance.Update(id, tipo, numero, sw, tipo_aplica, numero_aplica, numero_cuota, valor, descuento, retencion, ajuste, retencion_iva, retencion_ica, fecha, retencion2, retencion3, fecha_cruce, trasporte, cree,"documentos_cruce",datosTransaccion);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Updates an documentos_cruce object by passing one object's instance as reference
		/// </summary>
		/// <param name="documentos_cruce">An instance of documentos_cruce for reference</param>
		public void Update(documentos_cruce documentos_cruce,Sinapsys.Datos.SQL datosTransaccion=null)
		{
			Update(documentos_cruce.id, documentos_cruce.tipo, documentos_cruce.numero, documentos_cruce.sw, documentos_cruce.tipo_aplica, documentos_cruce.numero_aplica, documentos_cruce.numero_cuota, documentos_cruce.valor, documentos_cruce.descuento, documentos_cruce.retencion, documentos_cruce.ajuste, documentos_cruce.retencion_iva, documentos_cruce.retencion_ica, documentos_cruce.fecha, documentos_cruce.retencion2, documentos_cruce.retencion3, documentos_cruce.fecha_cruce, documentos_cruce.trasporte, documentos_cruce.cree);
		}

		/// <summary>
		/// Delete  the documentos_cruce object by passing a object
		/// </summary>
		public void  Delete(documentos_cruce documentos_cruce, Sinapsys.Datos.SQL datosTransaccion=null)
		{
			Delete(documentos_cruce.id, documentos_cruce.tipo, documentos_cruce.numero, documentos_cruce.tipo_aplica, documentos_cruce.numero_aplica, documentos_cruce.numero_cuota,datosTransaccion);
		}

		/// <summary>
		/// Deletes the documentos_cruce object by passing one object's instance as reference
		/// </summary>
		/// <param name="documentos_cruce">An instance of documentos_cruce for reference</param>
		public void Delete(int id, string tipo, int numero, string tipo_aplica, int numero_aplica, short numero_cuota, Sinapsys.Datos.SQL datosTransaccion=null)
		{
			try 
			{
				//documentos_cruce old_values = documentos_cruceController.Instance.Get(id);
				//if(!Validate.security.CanDeleteSecurityField(documentos_cruceController.Instance, (ILatinodeObject)old_values))
				//    throw new Exception("Access denied by security field, you can't delete object");

				documentos_cruceDataProvider.Instance.Delete(id, tipo, numero, tipo_aplica, numero_aplica, numero_cuota,"documentos_cruce");
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Deletes the documentos_cruce object by passing CVS parameter as reference
		/// </summary>
		/// <param name="documentos_cruce">An instance of documentos_cruce for reference</param>
		public void Delete(string CVSParameter)
		{
			string[] StrCommand=CVSParameter.Split(',');
			try 
			{
				int id=int.Parse(StrCommand[0]);
				string tipo=StrCommand[1];
				int numero=int.Parse(StrCommand[2]);
				string tipo_aplica=StrCommand[3];
				int numero_aplica=int.Parse(StrCommand[4]);
				short numero_cuota=short.Parse(StrCommand[5]);
				documentos_cruceDataProvider.Instance.Delete(id, tipo, numero, tipo_aplica, numero_aplica, numero_cuota,"documentos_cruce");
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Gets the documentos_cruce object by passing the object's key fields
		/// </summary>
		/// <param name="id">int that contents the id value for the documentos_cruce object</param>
		/// <param name="tipo">string that contents the tipo value for the documentos_cruce object</param>
		/// <param name="numero">int that contents the numero value for the documentos_cruce object</param>
		/// <param name="tipo_aplica">string that contents the tipo_aplica value for the documentos_cruce object</param>
		/// <param name="numero_aplica">int that contents the numero_aplica value for the documentos_cruce object</param>
		/// <param name="numero_cuota">short that contents the numero_cuota value for the documentos_cruce object</param>
		/// <returns>One documentos_cruce object</returns>
		public documentos_cruce Get(int id, string tipo, int numero, string tipo_aplica, int numero_aplica, short numero_cuota, bool generateUndo=false)
		{
			try 
			{
				documentos_cruce documentos_cruce = null;
				DataTable dt = documentos_cruceDataProvider.Instance.Get(id, tipo, numero, tipo_aplica, numero_aplica, numero_cuota);
				if ((dt.Rows.Count > 0))
				{
					documentos_cruce = new documentos_cruce();
					DataRow dr = dt.Rows[0];
					ReadData(documentos_cruce, dr, generateUndo);
				}


				return documentos_cruce;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Gets all objects of documentos_cruce
		/// </summary>
		/// <returns>One documentos_cruceList object</returns>
		public documentos_cruceList GetAll(bool generateUndo=false)
		{
			try 
			{
				documentos_cruceList documentos_crucelist = new documentos_cruceList();
				DataTable dt = documentos_cruceDataProvider.Instance.GetAll();
				foreach (DataRow dr in dt.Rows)
				{
					documentos_cruce documentos_cruce = new documentos_cruce();
					ReadData(documentos_cruce, dr, generateUndo);
					documentos_crucelist.Add(documentos_cruce);
				}
				return documentos_crucelist;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Selects all documentos_cruce objects by reference (Foreign Keys)
		/// </summary>
		/// <param name="tipo">string that contents the tipo value for the documentos_cruce object</param>
		/// <param name="numero">int that contents the numero value for the documentos_cruce object</param>
		/// <returns>One documentos_cruceList object</returns>
		public documentos_cruceList GetBy_tipo_numero(string tipo, int numero,bool generateUndo=false)
		{
			try 
			{
				documentos_cruceList documentos_crucelist = new documentos_cruceList();

				DataTable dt = documentos_cruceDataProvider.Instance.GetBy_tipo_numero(tipo, numero);
				foreach (DataRow dr in dt.Rows)
				{
					documentos_cruce documentos_cruce = new documentos_cruce();
					ReadData(documentos_cruce, dr, generateUndo);
					documentos_crucelist.Add(documentos_cruce);
				}
				return documentos_crucelist;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Gets all objects of documentos_cruce applying filter and sort criteria
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
		/// <returns>One documentos_cruceList object</returns>
		public documentos_cruceList GetFilter(int pagenum, int pagesize, string filter, string sort, string extablesfilter, string extablesfieldsfilter, string extablesrelationsfilter, string extablessort, string extablesfieldssort, string extablesrelationssort, bool generateUndo=false)
		{
			try 
			{
				documentos_cruceList documentos_crucelist = new documentos_cruceList();

				DataTable dt = documentos_cruceDataProvider.Instance.GetFilter(pagenum, pagesize, filter, sort, extablesfilter, extablesfieldsfilter, extablesrelationsfilter, extablessort, extablesfieldssort, extablesrelationssort);

				foreach (DataRow dr in dt.Rows)
				{
					documentos_cruce documentos_cruce = new documentos_cruce();
					ReadData(documentos_cruce, dr, generateUndo);
					documentos_crucelist.Add(documentos_cruce);
				}
				return documentos_crucelist;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public documentos_cruceList GetFilter( string filter, string sort, bool generateUndo=false)
		{
			return GetFilter(0,0, filter, sort, "","","","","","",generateUndo);
		}

		public documentos_cruceList GetFilter(string filter, string sort, string extablesfilter, string extablesfieldsfilter, string extablesrelationsfilter, string extablessort, string extablesfieldssort, string extablesrelationssort, bool generateUndo=false)
		{
			return GetFilter(0,0, filter, sort, extablesfilter, extablesfieldsfilter, extablesrelationsfilter, extablessort, extablesfieldssort, extablesrelationssort,generateUndo);
		}


		/// <summary>
		/// Returns the type for one property
		/// </summary>
		/// <param name="propertyname">Property's name for return its value</param>
		/// <returns>A value for the <paramref name="propertyname"/></returns>
		public Type GetMethodType( string propertyname,documentos_cruce documentos_cruce)
		{
			// Perform the search for the property's value
			switch (propertyname)
			{
				case "id":
					return documentos_cruce.id.GetType();

				case "tipo":
					return documentos_cruce.tipo.GetType();

				case "numero":
					return documentos_cruce.numero.GetType();

				case "sw":
					return documentos_cruce.sw.GetType();

				case "tipo_aplica":
					return documentos_cruce.tipo_aplica.GetType();

				case "numero_aplica":
					return documentos_cruce.numero_aplica.GetType();

				case "numero_cuota":
					return documentos_cruce.numero_cuota.GetType();

				case "valor":
					return documentos_cruce.valor.GetType();

				case "descuento":
					return documentos_cruce.descuento.GetType();

				case "retencion":
					return documentos_cruce.retencion.GetType();

				case "ajuste":
					return documentos_cruce.ajuste.GetType();

				case "retencion_iva":
					return documentos_cruce.retencion_iva.GetType();

				case "retencion_ica":
					return documentos_cruce.retencion_ica.GetType();

				case "fecha":
					return documentos_cruce.fecha.GetType();

				case "retencion2":
					return documentos_cruce.retencion2.GetType();

				case "retencion3":
					return documentos_cruce.retencion3.GetType();

				case "fecha_cruce":
					return documentos_cruce.fecha_cruce.GetType();

				case "trasporte":
					return documentos_cruce.trasporte.GetType();

				case "cree":
					return documentos_cruce.cree.GetType();

			}

			return null;
		}
		/// <summary>
		/// update the changes in documentos_cruce object by passing the object
		/// </summary>
		public bool UpdateChanges(documentos_cruce documentos_cruce, out string error,Sinapsys.Datos.SQL datosTransaccion=null)
		{
			if (documentos_cruce.Olddocumentos_cruce == null)
			{
				    error = "No tiene objeto con el cual comparar";
				    return false;
			}
			string[] Fields = documentos_cruce.FieldChanged();
			error = "";
			return LiqMetalDMS_Bll_Data.DataProvider.UpdateFieldsbyObject(Fields, documentos_cruce, out error,datosTransaccion);
		}
	}

	#endregion

}
