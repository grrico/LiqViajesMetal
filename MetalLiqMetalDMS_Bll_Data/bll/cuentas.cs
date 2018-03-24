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
	#region cuentasController

	/// <summary>
	/// Class for convert data from database into object's data and vice versa
	/// </summary>
	public partial class cuentasController//: ILatinodeController
	{
		/// <summary>
		/// Generic Constructor
		/// </summary>
		public cuentasController()
		{
		}

		/// <summary>
		/// Instance accessor for this singleton
		/// </summary>
		private static cuentasController MySingleObj;
		public static cuentasController Instance
		{
			get
			{
				if (MySingleObj == null)
				{
					MySingleObj = new cuentasController();
				}
				return MySingleObj;
			}
		}

		// Reads object's data from a DataRow
		private void ReadData(cuentas cuentas, DataRow dr,bool generateUndo=false)
		{
			try 
			{
				cuentas.id = (int) dr["id"];
				cuentas.cuenta = (string) dr["cuenta"];
				cuentas.descripcion = dr.IsNull("descripcion") ? null :(string) dr["descripcion"];
				cuentas.afe = (bool) dr["afe"];
				cuentas.cco = (bool) dr["cco"];
				cuentas.ter = (bool) dr["ter"];
				cuentas.doc = (bool) dr["doc"];
				cuentas.aju = (bool) dr["aju"];
				cuentas.bas = (bool) dr["bas"];
				cuentas.tei = (bool) dr["tei"];
				cuentas.partida = dr.IsNull("partida") ? null :(string) dr["partida"];
				cuentas.contrapartida = dr.IsNull("contrapartida") ? null :(string) dr["contrapartida"];
				cuentas.naturaleza = dr.IsNull("naturaleza") ? null :(double?) dr["naturaleza"];
				cuentas.doc_inf = dr.IsNull("doc_inf") ? null :(double?) dr["doc_inf"];
				cuentas.doc_sup = dr.IsNull("doc_sup") ? null :(double?) dr["doc_sup"];
				cuentas.solo_interface = (bool) dr["solo_interface"];
				cuentas.maneja_medios = dr.IsNull("maneja_medios") ? null :(string) dr["maneja_medios"];
				cuentas.literal_mm = dr.IsNull("literal_mm") ? null :(string) dr["literal_mm"];
				cuentas.codigo_mm = dr.IsNull("codigo_mm") ? null :(string) dr["codigo_mm"];
				cuentas.subcodigo_mm = dr.IsNull("subcodigo_mm") ? null :(string) dr["subcodigo_mm"];
				cuentas.porcentaje = dr.IsNull("porcentaje") ? null :(double?) dr["porcentaje"];
				cuentas.ctas_dos_mm = dr.IsNull("ctas_dos_mm") ? null :(string) dr["ctas_dos_mm"];
				cuentas.exportado = dr.IsNull("exportado") ? null :(string) dr["exportado"];
				cuentas.cta_reversion = dr.IsNull("cta_reversion") ? null :(string) dr["cta_reversion"];
				cuentas.centro_me = dr.IsNull("centro_me") ? null :(int?) dr["centro_me"];
				cuentas.diferencia_cambio = dr.IsNull("diferencia_cambio") ? null :(char?) ((string) dr["diferencia_cambio"])[0];
				cuentas.norma = ((string) dr["norma"])[0];
				cuentas.inactiva = ((string) dr["inactiva"])[0];
				cuentas.descripcion_niif = dr.IsNull("descripcion_niif") ? null :(string) dr["descripcion_niif"];
				cuentas.cuenta_niif = dr.IsNull("cuenta_niif") ? null :(string) dr["cuenta_niif"];
				cuentas.clasificacion_niif = dr.IsNull("clasificacion_niif") ? null :(char?) ((string) dr["clasificacion_niif"])[0];
			}
			catch (Exception ex)
			{
				Utilidades.LogErrores(ex.Message + (ex.InnerException != null ? ex.InnerException.Message : ""), DataProvider.AplicacionNombre);
				throw ex;
			}
			if (generateUndo) cuentas.GenerateUndo();
		}

		/// <summary>
		/// Create a new cuentas object by passing a object
		/// </summary>
		public cuentas Create(cuentas cuentas, Sinapsys.Datos.SQL datosTransaccion=null)
		{
			return Create(cuentas.id,cuentas.cuenta,cuentas.descripcion,cuentas.afe,cuentas.cco,cuentas.ter,cuentas.doc,cuentas.aju,cuentas.bas,cuentas.tei,cuentas.partida,cuentas.contrapartida,cuentas.naturaleza,cuentas.doc_inf,cuentas.doc_sup,cuentas.solo_interface,cuentas.maneja_medios,cuentas.literal_mm,cuentas.codigo_mm,cuentas.subcodigo_mm,cuentas.porcentaje,cuentas.ctas_dos_mm,cuentas.exportado,cuentas.cta_reversion,cuentas.centro_me,cuentas.diferencia_cambio,cuentas.norma,cuentas.inactiva,cuentas.descripcion_niif,cuentas.cuenta_niif,cuentas.clasificacion_niif,datosTransaccion);
		}

		/// <summary>
		/// Creates a new cuentas object by passing all object's fields
		/// </summary>
		/// <param name="descripcion">string that contents the descripcion value for the cuentas object</param>
		/// <param name="afe">bool that contents the afe value for the cuentas object</param>
		/// <param name="cco">bool that contents the cco value for the cuentas object</param>
		/// <param name="ter">bool that contents the ter value for the cuentas object</param>
		/// <param name="doc">bool that contents the doc value for the cuentas object</param>
		/// <param name="aju">bool that contents the aju value for the cuentas object</param>
		/// <param name="bas">bool that contents the bas value for the cuentas object</param>
		/// <param name="tei">bool that contents the tei value for the cuentas object</param>
		/// <param name="partida">string that contents the partida value for the cuentas object</param>
		/// <param name="contrapartida">string that contents the contrapartida value for the cuentas object</param>
		/// <param name="naturaleza">double that contents the naturaleza value for the cuentas object</param>
		/// <param name="doc_inf">double that contents the doc_inf value for the cuentas object</param>
		/// <param name="doc_sup">double that contents the doc_sup value for the cuentas object</param>
		/// <param name="solo_interface">bool that contents the solo_interface value for the cuentas object</param>
		/// <param name="maneja_medios">string that contents the maneja_medios value for the cuentas object</param>
		/// <param name="literal_mm">string that contents the literal_mm value for the cuentas object</param>
		/// <param name="codigo_mm">string that contents the codigo_mm value for the cuentas object</param>
		/// <param name="subcodigo_mm">string that contents the subcodigo_mm value for the cuentas object</param>
		/// <param name="porcentaje">double that contents the porcentaje value for the cuentas object</param>
		/// <param name="ctas_dos_mm">string that contents the ctas_dos_mm value for the cuentas object</param>
		/// <param name="exportado">string that contents the exportado value for the cuentas object</param>
		/// <param name="cta_reversion">string that contents the cta_reversion value for the cuentas object</param>
		/// <param name="centro_me">int that contents the centro_me value for the cuentas object</param>
		/// <param name="diferencia_cambio">char that contents the diferencia_cambio value for the cuentas object</param>
		/// <param name="norma">char that contents the norma value for the cuentas object</param>
		/// <param name="inactiva">char that contents the inactiva value for the cuentas object</param>
		/// <param name="descripcion_niif">string that contents the descripcion_niif value for the cuentas object</param>
		/// <param name="cuenta_niif">string that contents the cuenta_niif value for the cuentas object</param>
		/// <param name="clasificacion_niif">char that contents the clasificacion_niif value for the cuentas object</param>
		/// <returns>One cuentas object</returns>
		public cuentas Create(int id, string cuenta, string descripcion, bool afe, bool cco, bool ter, bool doc, bool aju, bool bas, bool tei, string partida, string contrapartida, double? naturaleza, double? doc_inf, double? doc_sup, bool solo_interface, string maneja_medios, string literal_mm, string codigo_mm, string subcodigo_mm, double? porcentaje, string ctas_dos_mm, string exportado, string cta_reversion, int? centro_me, char? diferencia_cambio, char norma, char inactiva, string descripcion_niif, string cuenta_niif, char? clasificacion_niif, Sinapsys.Datos.SQL datosTransaccion=null)
		{
			try 
			{
				cuentas cuentas = new cuentas();

				cuentas.id = id;
				cuentas.id = id;
				cuentas.cuenta = cuenta;
				cuentas.descripcion = descripcion;
				cuentas.afe = afe;
				cuentas.cco = cco;
				cuentas.ter = ter;
				cuentas.doc = doc;
				cuentas.aju = aju;
				cuentas.bas = bas;
				cuentas.tei = tei;
				cuentas.partida = partida;
				cuentas.contrapartida = contrapartida;
				cuentas.naturaleza = naturaleza;
				cuentas.doc_inf = doc_inf;
				cuentas.doc_sup = doc_sup;
				cuentas.solo_interface = solo_interface;
				cuentas.maneja_medios = maneja_medios;
				cuentas.literal_mm = literal_mm;
				cuentas.codigo_mm = codigo_mm;
				cuentas.subcodigo_mm = subcodigo_mm;
				cuentas.porcentaje = porcentaje;
				cuentas.ctas_dos_mm = ctas_dos_mm;
				cuentas.exportado = exportado;
				cuentas.cta_reversion = cta_reversion;
				cuentas.centro_me = centro_me;
				cuentas.diferencia_cambio = diferencia_cambio;
				cuentas.norma = norma;
				cuentas.inactiva = inactiva;
				cuentas.descripcion_niif = descripcion_niif;
				cuentas.cuenta_niif = cuenta_niif;
				cuentas.clasificacion_niif = clasificacion_niif;
				id = cuentasDataProvider.Instance.Create(id, cuenta, descripcion, afe, cco, ter, doc, aju, bas, tei, partida, contrapartida, naturaleza, doc_inf, doc_sup, solo_interface, maneja_medios, literal_mm, codigo_mm, subcodigo_mm, porcentaje, ctas_dos_mm, exportado, cta_reversion, centro_me, diferencia_cambio, norma, inactiva, descripcion_niif, cuenta_niif, clasificacion_niif,"cuentas",datosTransaccion);
				if (id == 0)
					return null;

				cuentas.id = id;

				return cuentas;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Updates an cuentas object by passing all object's fields
		/// </summary>
		/// <param name="id">int that contents the id value for the cuentas object</param>
		/// <param name="cuenta">string that contents the cuenta value for the cuentas object</param>
		/// <param name="descripcion">string that contents the descripcion value for the cuentas object</param>
		/// <param name="afe">bool that contents the afe value for the cuentas object</param>
		/// <param name="cco">bool that contents the cco value for the cuentas object</param>
		/// <param name="ter">bool that contents the ter value for the cuentas object</param>
		/// <param name="doc">bool that contents the doc value for the cuentas object</param>
		/// <param name="aju">bool that contents the aju value for the cuentas object</param>
		/// <param name="bas">bool that contents the bas value for the cuentas object</param>
		/// <param name="tei">bool that contents the tei value for the cuentas object</param>
		/// <param name="partida">string that contents the partida value for the cuentas object</param>
		/// <param name="contrapartida">string that contents the contrapartida value for the cuentas object</param>
		/// <param name="naturaleza">double that contents the naturaleza value for the cuentas object</param>
		/// <param name="doc_inf">double that contents the doc_inf value for the cuentas object</param>
		/// <param name="doc_sup">double that contents the doc_sup value for the cuentas object</param>
		/// <param name="solo_interface">bool that contents the solo_interface value for the cuentas object</param>
		/// <param name="maneja_medios">string that contents the maneja_medios value for the cuentas object</param>
		/// <param name="literal_mm">string that contents the literal_mm value for the cuentas object</param>
		/// <param name="codigo_mm">string that contents the codigo_mm value for the cuentas object</param>
		/// <param name="subcodigo_mm">string that contents the subcodigo_mm value for the cuentas object</param>
		/// <param name="porcentaje">double that contents the porcentaje value for the cuentas object</param>
		/// <param name="ctas_dos_mm">string that contents the ctas_dos_mm value for the cuentas object</param>
		/// <param name="exportado">string that contents the exportado value for the cuentas object</param>
		/// <param name="cta_reversion">string that contents the cta_reversion value for the cuentas object</param>
		/// <param name="centro_me">int that contents the centro_me value for the cuentas object</param>
		/// <param name="diferencia_cambio">char that contents the diferencia_cambio value for the cuentas object</param>
		/// <param name="norma">char that contents the norma value for the cuentas object</param>
		/// <param name="inactiva">char that contents the inactiva value for the cuentas object</param>
		/// <param name="descripcion_niif">string that contents the descripcion_niif value for the cuentas object</param>
		/// <param name="cuenta_niif">string that contents the cuenta_niif value for the cuentas object</param>
		/// <param name="clasificacion_niif">char that contents the clasificacion_niif value for the cuentas object</param>
		public void Update(int id, string cuenta, string descripcion, bool afe, bool cco, bool ter, bool doc, bool aju, bool bas, bool tei, string partida, string contrapartida, double? naturaleza, double? doc_inf, double? doc_sup, bool solo_interface, string maneja_medios, string literal_mm, string codigo_mm, string subcodigo_mm, double? porcentaje, string ctas_dos_mm, string exportado, string cta_reversion, int? centro_me, char? diferencia_cambio, char norma, char inactiva, string descripcion_niif, string cuenta_niif, char? clasificacion_niif, Sinapsys.Datos.SQL datosTransaccion=null)
		{
			try 
			{
				cuentas new_values = new cuentas();
				new_values.descripcion = descripcion;
				new_values.afe = afe;
				new_values.cco = cco;
				new_values.ter = ter;
				new_values.doc = doc;
				new_values.aju = aju;
				new_values.bas = bas;
				new_values.tei = tei;
				new_values.partida = partida;
				new_values.contrapartida = contrapartida;
				new_values.naturaleza = naturaleza;
				new_values.doc_inf = doc_inf;
				new_values.doc_sup = doc_sup;
				new_values.solo_interface = solo_interface;
				new_values.maneja_medios = maneja_medios;
				new_values.literal_mm = literal_mm;
				new_values.codigo_mm = codigo_mm;
				new_values.subcodigo_mm = subcodigo_mm;
				new_values.porcentaje = porcentaje;
				new_values.ctas_dos_mm = ctas_dos_mm;
				new_values.exportado = exportado;
				new_values.cta_reversion = cta_reversion;
				new_values.centro_me = centro_me;
				new_values.diferencia_cambio = diferencia_cambio;
				new_values.norma = norma;
				new_values.inactiva = inactiva;
				new_values.descripcion_niif = descripcion_niif;
				new_values.cuenta_niif = cuenta_niif;
				new_values.clasificacion_niif = clasificacion_niif;
				cuentasDataProvider.Instance.Update(id, cuenta, descripcion, afe, cco, ter, doc, aju, bas, tei, partida, contrapartida, naturaleza, doc_inf, doc_sup, solo_interface, maneja_medios, literal_mm, codigo_mm, subcodigo_mm, porcentaje, ctas_dos_mm, exportado, cta_reversion, centro_me, diferencia_cambio, norma, inactiva, descripcion_niif, cuenta_niif, clasificacion_niif,"cuentas",datosTransaccion);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Updates an cuentas object by passing one object's instance as reference
		/// </summary>
		/// <param name="cuentas">An instance of cuentas for reference</param>
		public void Update(cuentas cuentas,Sinapsys.Datos.SQL datosTransaccion=null)
		{
			Update(cuentas.id, cuentas.cuenta, cuentas.descripcion, cuentas.afe, cuentas.cco, cuentas.ter, cuentas.doc, cuentas.aju, cuentas.bas, cuentas.tei, cuentas.partida, cuentas.contrapartida, cuentas.naturaleza, cuentas.doc_inf, cuentas.doc_sup, cuentas.solo_interface, cuentas.maneja_medios, cuentas.literal_mm, cuentas.codigo_mm, cuentas.subcodigo_mm, cuentas.porcentaje, cuentas.ctas_dos_mm, cuentas.exportado, cuentas.cta_reversion, cuentas.centro_me, cuentas.diferencia_cambio, cuentas.norma, cuentas.inactiva, cuentas.descripcion_niif, cuentas.cuenta_niif, cuentas.clasificacion_niif);
		}

		/// <summary>
		/// Delete  the cuentas object by passing a object
		/// </summary>
		public void  Delete(cuentas cuentas, Sinapsys.Datos.SQL datosTransaccion=null)
		{
			Delete(cuentas.id, cuentas.cuenta,datosTransaccion);
		}

		/// <summary>
		/// Deletes the cuentas object by passing one object's instance as reference
		/// </summary>
		/// <param name="cuentas">An instance of cuentas for reference</param>
		public void Delete(int id, string cuenta, Sinapsys.Datos.SQL datosTransaccion=null)
		{
			try 
			{
				//cuentas old_values = cuentasController.Instance.Get(id);
				//if(!Validate.security.CanDeleteSecurityField(cuentasController.Instance, (ILatinodeObject)old_values))
				//    throw new Exception("Access denied by security field, you can't delete object");

				cuentasDataProvider.Instance.Delete(id, cuenta,"cuentas");
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Deletes the cuentas object by passing CVS parameter as reference
		/// </summary>
		/// <param name="cuentas">An instance of cuentas for reference</param>
		public void Delete(string CVSParameter)
		{
			string[] StrCommand=CVSParameter.Split(',');
			try 
			{
				int id=int.Parse(StrCommand[0]);
				string cuenta=StrCommand[1];
				cuentasDataProvider.Instance.Delete(id, cuenta,"cuentas");
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Gets the cuentas object by passing the object's key fields
		/// </summary>
		/// <param name="id">int that contents the id value for the cuentas object</param>
		/// <param name="cuenta">string that contents the cuenta value for the cuentas object</param>
		/// <returns>One cuentas object</returns>
		public cuentas Get(int id, string cuenta, bool generateUndo=false)
		{
			try 
			{
				cuentas cuentas = null;
				DataTable dt = cuentasDataProvider.Instance.Get(id, cuenta);
				if ((dt.Rows.Count > 0))
				{
					cuentas = new cuentas();
					DataRow dr = dt.Rows[0];
					ReadData(cuentas, dr, generateUndo);
				}


				return cuentas;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Gets all objects of cuentas
		/// </summary>
		/// <returns>One cuentasList object</returns>
		public cuentasList GetAll(bool generateUndo=false)
		{
			try 
			{
				cuentasList cuentaslist = new cuentasList();
				DataTable dt = cuentasDataProvider.Instance.GetAll();
				foreach (DataRow dr in dt.Rows)
				{
					cuentas cuentas = new cuentas();
					ReadData(cuentas, dr, generateUndo);
					cuentaslist.Add(cuentas);
				}
				return cuentaslist;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Gets all objects of cuentas applying filter and sort criteria
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
		/// <returns>One cuentasList object</returns>
		public cuentasList GetFilter(int pagenum, int pagesize, string filter, string sort, string extablesfilter, string extablesfieldsfilter, string extablesrelationsfilter, string extablessort, string extablesfieldssort, string extablesrelationssort, bool generateUndo=false)
		{
			try 
			{
				cuentasList cuentaslist = new cuentasList();

				DataTable dt = cuentasDataProvider.Instance.GetFilter(pagenum, pagesize, filter, sort, extablesfilter, extablesfieldsfilter, extablesrelationsfilter, extablessort, extablesfieldssort, extablesrelationssort);

				foreach (DataRow dr in dt.Rows)
				{
					cuentas cuentas = new cuentas();
					ReadData(cuentas, dr, generateUndo);
					cuentaslist.Add(cuentas);
				}
				return cuentaslist;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public cuentasList GetFilter( string filter, string sort, bool generateUndo=false)
		{
			return GetFilter(0,0, filter, sort, "","","","","","",generateUndo);
		}

		public cuentasList GetFilter(string filter, string sort, string extablesfilter, string extablesfieldsfilter, string extablesrelationsfilter, string extablessort, string extablesfieldssort, string extablesrelationssort, bool generateUndo=false)
		{
			return GetFilter(0,0, filter, sort, extablesfilter, extablesfieldsfilter, extablesrelationsfilter, extablessort, extablesfieldssort, extablesrelationssort,generateUndo);
		}


		/// <summary>
		/// Returns the type for one property
		/// </summary>
		/// <param name="propertyname">Property's name for return its value</param>
		/// <returns>A value for the <paramref name="propertyname"/></returns>
		public Type GetMethodType( string propertyname,cuentas cuentas)
		{
			// Perform the search for the property's value
			switch (propertyname)
			{
				case "id":
					return cuentas.id.GetType();

				case "cuenta":
					return cuentas.cuenta.GetType();

				case "descripcion":
					return cuentas.descripcion.GetType();

				case "afe":
					return cuentas.afe.GetType();

				case "cco":
					return cuentas.cco.GetType();

				case "ter":
					return cuentas.ter.GetType();

				case "doc":
					return cuentas.doc.GetType();

				case "aju":
					return cuentas.aju.GetType();

				case "bas":
					return cuentas.bas.GetType();

				case "tei":
					return cuentas.tei.GetType();

				case "partida":
					return cuentas.partida.GetType();

				case "contrapartida":
					return cuentas.contrapartida.GetType();

				case "naturaleza":
					return cuentas.naturaleza.GetType();

				case "doc_inf":
					return cuentas.doc_inf.GetType();

				case "doc_sup":
					return cuentas.doc_sup.GetType();

				case "solo_interface":
					return cuentas.solo_interface.GetType();

				case "maneja_medios":
					return cuentas.maneja_medios.GetType();

				case "literal_mm":
					return cuentas.literal_mm.GetType();

				case "codigo_mm":
					return cuentas.codigo_mm.GetType();

				case "subcodigo_mm":
					return cuentas.subcodigo_mm.GetType();

				case "porcentaje":
					return cuentas.porcentaje.GetType();

				case "ctas_dos_mm":
					return cuentas.ctas_dos_mm.GetType();

				case "exportado":
					return cuentas.exportado.GetType();

				case "cta_reversion":
					return cuentas.cta_reversion.GetType();

				case "centro_me":
					return cuentas.centro_me.GetType();

				case "diferencia_cambio":
					return cuentas.diferencia_cambio.GetType();

				case "norma":
					return cuentas.norma.GetType();

				case "inactiva":
					return cuentas.inactiva.GetType();

				case "descripcion_niif":
					return cuentas.descripcion_niif.GetType();

				case "cuenta_niif":
					return cuentas.cuenta_niif.GetType();

				case "clasificacion_niif":
					return cuentas.clasificacion_niif.GetType();

			}

			return null;
		}
		/// <summary>
		/// update the changes in cuentas object by passing the object
		/// </summary>
		public bool UpdateChanges(cuentas cuentas, out string error,Sinapsys.Datos.SQL datosTransaccion=null)
		{
			if (cuentas.Oldcuentas == null)
			{
				    error = "No tiene objeto con el cual comparar";
				    return false;
			}
			string[] Fields = cuentas.FieldChanged();
			error = "";
			return LiqMetalDMS_Bll_Data.DataProvider.UpdateFieldsbyObject(Fields, cuentas, out error,datosTransaccion);
		}
	}

	#endregion

}
