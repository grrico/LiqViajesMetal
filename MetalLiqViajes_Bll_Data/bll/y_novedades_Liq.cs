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
	#region y_novedades_LiqController

	/// <summary>
	/// Class for convert data from database into object's data and vice versa
	/// </summary>
	public partial class y_novedades_LiqController//: ILatinodeController
	{
		/// <summary>
		/// Generic Constructor
		/// </summary>
		public y_novedades_LiqController()
		{
		}

		/// <summary>
		/// Instance accessor for this singleton
		/// </summary>
		private static y_novedades_LiqController MySingleObj;
		public static y_novedades_LiqController Instance
		{
			get
			{
				if (MySingleObj == null)
				{
					MySingleObj = new y_novedades_LiqController();
				}
				return MySingleObj;
			}
		}

		// Reads object's data from a DataRow
		private void ReadData(y_novedades_Liq y_novedades_liq, DataRow dr,bool generateUndo=false)
		{
			try 
			{
				y_novedades_liq.IdNovedad = (int) dr["IdNovedad"];
				y_novedades_liq.nomina = (string) dr["nomina"];
				y_novedades_liq.contrato = (int) dr["contrato"];
				y_novedades_liq.nit = (decimal) dr["nit"];
				y_novedades_liq.idperiodo = (int) dr["idperiodo"];
				y_novedades_liq.concepto = Convert.ToInt16(dr["concepto"]);
				y_novedades_liq.fecha = (DateTime) dr["fecha"];
				y_novedades_liq.mes = dr.IsNull("mes") ? null :(byte?) dr["mes"];
				y_novedades_liq.ano = dr.IsNull("ano") ? null :(short?)Convert.ToInt16(dr["ano"]);
				y_novedades_liq.periodo = dr.IsNull("periodo") ? null :(int?) dr["periodo"];
				y_novedades_liq.valor = dr.IsNull("valor") ? null :(decimal?) dr["valor"];
				y_novedades_liq.horas = dr.IsNull("horas") ? null :(float?) dr["horas"];
				y_novedades_liq.dias = dr.IsNull("dias") ? null :(float?) dr["dias"];
				y_novedades_liq.centro = (int) dr["centro"];
				y_novedades_liq.planta = (byte) dr["planta"];
				y_novedades_liq.turno = dr.IsNull("turno") ? null :(byte?) dr["turno"];
				y_novedades_liq.estado = dr.IsNull("estado") ? null :(char?) ((string) dr["estado"])[0];
				y_novedades_liq.nro_presta = dr.IsNull("nro_presta") ? null :(int?) dr["nro_presta"];
				y_novedades_liq.cpto_interes = dr.IsNull("cpto_interes") ? null :(short?)Convert.ToInt16(dr["cpto_interes"]);
				y_novedades_liq.sumar = (bool) dr["sumar"];
				y_novedades_liq.oficio = dr.IsNull("oficio") ? null :(string) dr["oficio"];
			}
			catch (Exception ex)
			{
				Utilidades.LogErrores(ex.Message + (ex.InnerException != null ? ex.InnerException.Message : ""), DataProvider.AplicacionNombre);
				throw ex;
			}
			if (generateUndo) y_novedades_liq.GenerateUndo();
		}

		/// <summary>
		/// Create a new y_novedades_Liq object by passing a object
		/// </summary>
		public y_novedades_Liq Create(y_novedades_Liq y_novedades_liq, Sinapsys.Datos.SQL datosTransaccion=null)
		{
			return Create(y_novedades_liq.IdNovedad,y_novedades_liq.nomina,y_novedades_liq.contrato,y_novedades_liq.nit,y_novedades_liq.idperiodo,y_novedades_liq.concepto,y_novedades_liq.centro,y_novedades_liq.planta,y_novedades_liq.fecha,y_novedades_liq.mes,y_novedades_liq.ano,y_novedades_liq.periodo,y_novedades_liq.valor,y_novedades_liq.horas,y_novedades_liq.dias,y_novedades_liq.turno,y_novedades_liq.estado,y_novedades_liq.nro_presta,y_novedades_liq.cpto_interes,y_novedades_liq.sumar,y_novedades_liq.oficio,datosTransaccion);
		}

		/// <summary>
		/// Creates a new y_novedades_Liq object by passing all object's fields
		/// </summary>
		/// <param name="fecha">DateTime that contents the fecha value for the y_novedades_Liq object</param>
		/// <param name="mes">byte that contents the mes value for the y_novedades_Liq object</param>
		/// <param name="ano">short that contents the ano value for the y_novedades_Liq object</param>
		/// <param name="periodo">int that contents the periodo value for the y_novedades_Liq object</param>
		/// <param name="valor">decimal that contents the valor value for the y_novedades_Liq object</param>
		/// <param name="horas">float that contents the horas value for the y_novedades_Liq object</param>
		/// <param name="dias">float that contents the dias value for the y_novedades_Liq object</param>
		/// <param name="turno">byte that contents the turno value for the y_novedades_Liq object</param>
		/// <param name="estado">char that contents the estado value for the y_novedades_Liq object</param>
		/// <param name="nro_presta">int that contents the nro_presta value for the y_novedades_Liq object</param>
		/// <param name="cpto_interes">short that contents the cpto_interes value for the y_novedades_Liq object</param>
		/// <param name="sumar">bool that contents the sumar value for the y_novedades_Liq object</param>
		/// <param name="oficio">string that contents the oficio value for the y_novedades_Liq object</param>
		/// <returns>One y_novedades_Liq object</returns>
		public y_novedades_Liq Create(int IdNovedad, string nomina, int contrato, decimal nit, int idperiodo, short concepto, int centro, byte planta, DateTime fecha, byte? mes, short? ano, int? periodo, decimal? valor, float? horas, float? dias, byte? turno, char? estado, int? nro_presta, short? cpto_interes, bool sumar, string oficio, Sinapsys.Datos.SQL datosTransaccion=null)
		{
			try 
			{
				y_novedades_Liq y_novedades_liq = new y_novedades_Liq();

				y_novedades_liq.IdNovedad = IdNovedad;
				y_novedades_liq.IdNovedad = IdNovedad;
				y_novedades_liq.nomina = nomina;
				y_novedades_liq.contrato = contrato;
				y_novedades_liq.nit = nit;
				y_novedades_liq.idperiodo = idperiodo;
				y_novedades_liq.concepto = concepto;
				y_novedades_liq.centro = centro;
				y_novedades_liq.planta = planta;
				y_novedades_liq.fecha = fecha;
				y_novedades_liq.mes = mes;
				y_novedades_liq.ano = ano;
				y_novedades_liq.periodo = periodo;
				y_novedades_liq.valor = valor;
				y_novedades_liq.horas = horas;
				y_novedades_liq.dias = dias;
				y_novedades_liq.turno = turno;
				y_novedades_liq.estado = estado;
				y_novedades_liq.nro_presta = nro_presta;
				y_novedades_liq.cpto_interes = cpto_interes;
				y_novedades_liq.sumar = sumar;
				y_novedades_liq.oficio = oficio;
				IdNovedad = y_novedades_LiqDataProvider.Instance.Create(IdNovedad, nomina, contrato, nit, idperiodo, concepto, centro, planta, fecha, mes, ano, periodo, valor, horas, dias, turno, estado, nro_presta, cpto_interes, sumar, oficio,"y_novedades_Liq",datosTransaccion);
				if (IdNovedad == 0)
					return null;

				y_novedades_liq.IdNovedad = IdNovedad;

				return y_novedades_liq;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Updates an y_novedades_Liq object by passing all object's fields
		/// </summary>
		/// <param name="IdNovedad">int that contents the IdNovedad value for the y_novedades_Liq object</param>
		/// <param name="nomina">string that contents the nomina value for the y_novedades_Liq object</param>
		/// <param name="contrato">int that contents the contrato value for the y_novedades_Liq object</param>
		/// <param name="nit">decimal that contents the nit value for the y_novedades_Liq object</param>
		/// <param name="idperiodo">int that contents the idperiodo value for the y_novedades_Liq object</param>
		/// <param name="concepto">short that contents the concepto value for the y_novedades_Liq object</param>
		/// <param name="fecha">DateTime that contents the fecha value for the y_novedades_Liq object</param>
		/// <param name="mes">byte that contents the mes value for the y_novedades_Liq object</param>
		/// <param name="ano">short that contents the ano value for the y_novedades_Liq object</param>
		/// <param name="periodo">int that contents the periodo value for the y_novedades_Liq object</param>
		/// <param name="valor">decimal that contents the valor value for the y_novedades_Liq object</param>
		/// <param name="horas">float that contents the horas value for the y_novedades_Liq object</param>
		/// <param name="dias">float that contents the dias value for the y_novedades_Liq object</param>
		/// <param name="centro">int that contents the centro value for the y_novedades_Liq object</param>
		/// <param name="planta">byte that contents the planta value for the y_novedades_Liq object</param>
		/// <param name="turno">byte that contents the turno value for the y_novedades_Liq object</param>
		/// <param name="estado">char that contents the estado value for the y_novedades_Liq object</param>
		/// <param name="nro_presta">int that contents the nro_presta value for the y_novedades_Liq object</param>
		/// <param name="cpto_interes">short that contents the cpto_interes value for the y_novedades_Liq object</param>
		/// <param name="sumar">bool that contents the sumar value for the y_novedades_Liq object</param>
		/// <param name="oficio">string that contents the oficio value for the y_novedades_Liq object</param>
		public void Update(int IdNovedad, string nomina, int contrato, decimal nit, int idperiodo, short concepto, DateTime fecha, byte? mes, short? ano, int? periodo, decimal? valor, float? horas, float? dias, int centro, byte planta, byte? turno, char? estado, int? nro_presta, short? cpto_interes, bool sumar, string oficio, Sinapsys.Datos.SQL datosTransaccion=null)
		{
			try 
			{
				y_novedades_Liq new_values = new y_novedades_Liq();
				new_values.fecha = fecha;
				new_values.mes = mes;
				new_values.ano = ano;
				new_values.periodo = periodo;
				new_values.valor = valor;
				new_values.horas = horas;
				new_values.dias = dias;
				new_values.turno = turno;
				new_values.estado = estado;
				new_values.nro_presta = nro_presta;
				new_values.cpto_interes = cpto_interes;
				new_values.sumar = sumar;
				new_values.oficio = oficio;
				y_novedades_LiqDataProvider.Instance.Update(IdNovedad, nomina, contrato, nit, idperiodo, concepto, fecha, mes, ano, periodo, valor, horas, dias, centro, planta, turno, estado, nro_presta, cpto_interes, sumar, oficio,"y_novedades_Liq",datosTransaccion);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Updates an y_novedades_Liq object by passing one object's instance as reference
		/// </summary>
		/// <param name="y_novedades_liq">An instance of y_novedades_Liq for reference</param>
		public void Update(y_novedades_Liq y_novedades_liq,Sinapsys.Datos.SQL datosTransaccion=null)
		{
			Update(y_novedades_liq.IdNovedad, y_novedades_liq.nomina, y_novedades_liq.contrato, y_novedades_liq.nit, y_novedades_liq.idperiodo, y_novedades_liq.concepto, y_novedades_liq.fecha, y_novedades_liq.mes, y_novedades_liq.ano, y_novedades_liq.periodo, y_novedades_liq.valor, y_novedades_liq.horas, y_novedades_liq.dias, y_novedades_liq.centro, y_novedades_liq.planta, y_novedades_liq.turno, y_novedades_liq.estado, y_novedades_liq.nro_presta, y_novedades_liq.cpto_interes, y_novedades_liq.sumar, y_novedades_liq.oficio);
		}

		/// <summary>
		/// Delete  the y_novedades_Liq object by passing a object
		/// </summary>
		public void  Delete(y_novedades_Liq y_novedades_liq, Sinapsys.Datos.SQL datosTransaccion=null)
		{
			Delete(y_novedades_liq.IdNovedad, y_novedades_liq.nomina, y_novedades_liq.contrato, y_novedades_liq.nit, y_novedades_liq.idperiodo, y_novedades_liq.concepto, y_novedades_liq.centro, y_novedades_liq.planta,datosTransaccion);
		}

		/// <summary>
		/// Deletes the y_novedades_Liq object by passing one object's instance as reference
		/// </summary>
		/// <param name="y_novedades_liq">An instance of y_novedades_Liq for reference</param>
		public void Delete(int IdNovedad, string nomina, int contrato, decimal nit, int idperiodo, short concepto, int centro, byte planta, Sinapsys.Datos.SQL datosTransaccion=null)
		{
			try 
			{
				//y_novedades_Liq old_values = y_novedades_LiqController.Instance.Get(IdNovedad);
				//if(!Validate.security.CanDeleteSecurityField(y_novedades_LiqController.Instance, (ILatinodeObject)old_values))
				//    throw new Exception("Access denied by security field, you can't delete object");

				y_novedades_LiqDataProvider.Instance.Delete(IdNovedad, nomina, contrato, nit, idperiodo, concepto, centro, planta,"y_novedades_Liq");
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Deletes the y_novedades_Liq object by passing CVS parameter as reference
		/// </summary>
		/// <param name="y_novedades_liq">An instance of y_novedades_Liq for reference</param>
		public void Delete(string CVSParameter)
		{
			string[] StrCommand=CVSParameter.Split(',');
			try 
			{
				int IdNovedad=int.Parse(StrCommand[0]);
				string nomina=StrCommand[1];
				int contrato=int.Parse(StrCommand[2]);
				decimal nit=decimal.Parse(StrCommand[3]);
				int idperiodo=int.Parse(StrCommand[4]);
				short concepto=short.Parse(StrCommand[5]);
				int centro=int.Parse(StrCommand[6]);
				byte planta=byte.Parse(StrCommand[7]);
				y_novedades_LiqDataProvider.Instance.Delete(IdNovedad, nomina, contrato, nit, idperiodo, concepto, centro, planta,"y_novedades_Liq");
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Gets the y_novedades_Liq object by passing the object's key fields
		/// </summary>
		/// <param name="IdNovedad">int that contents the IdNovedad value for the y_novedades_Liq object</param>
		/// <param name="nomina">string that contents the nomina value for the y_novedades_Liq object</param>
		/// <param name="contrato">int that contents the contrato value for the y_novedades_Liq object</param>
		/// <param name="nit">decimal that contents the nit value for the y_novedades_Liq object</param>
		/// <param name="idperiodo">int that contents the idperiodo value for the y_novedades_Liq object</param>
		/// <param name="concepto">short that contents the concepto value for the y_novedades_Liq object</param>
		/// <param name="centro">int that contents the centro value for the y_novedades_Liq object</param>
		/// <param name="planta">byte that contents the planta value for the y_novedades_Liq object</param>
		/// <returns>One y_novedades_Liq object</returns>
		public y_novedades_Liq Get(int IdNovedad, string nomina, int contrato, decimal nit, int idperiodo, short concepto, int centro, byte planta, bool generateUndo=false)
		{
			try 
			{
				y_novedades_Liq y_novedades_liq = null;
				DataTable dt = y_novedades_LiqDataProvider.Instance.Get(IdNovedad, nomina, contrato, nit, idperiodo, concepto, centro, planta);
				if ((dt.Rows.Count > 0))
				{
					y_novedades_liq = new y_novedades_Liq();
					DataRow dr = dt.Rows[0];
					ReadData(y_novedades_liq, dr, generateUndo);
				}


				return y_novedades_liq;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Gets all objects of y_novedades_Liq
		/// </summary>
		/// <returns>One y_novedades_LiqList object</returns>
		public y_novedades_LiqList GetAll(bool generateUndo=false)
		{
			try 
			{
				y_novedades_LiqList y_novedades_liqlist = new y_novedades_LiqList();
				DataTable dt = y_novedades_LiqDataProvider.Instance.GetAll();
				foreach (DataRow dr in dt.Rows)
				{
					y_novedades_Liq y_novedades_liq = new y_novedades_Liq();
					ReadData(y_novedades_liq, dr, generateUndo);
					y_novedades_liqlist.Add(y_novedades_liq);
				}
				return y_novedades_liqlist;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Gets all objects of y_novedades_Liq applying filter and sort criteria
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
		/// <returns>One y_novedades_LiqList object</returns>
		public y_novedades_LiqList GetFilter(int pagenum, int pagesize, string filter, string sort, string extablesfilter, string extablesfieldsfilter, string extablesrelationsfilter, string extablessort, string extablesfieldssort, string extablesrelationssort, bool generateUndo=false)
		{
			try 
			{
				y_novedades_LiqList y_novedades_liqlist = new y_novedades_LiqList();

				DataTable dt = y_novedades_LiqDataProvider.Instance.GetFilter(pagenum, pagesize, filter, sort, extablesfilter, extablesfieldsfilter, extablesrelationsfilter, extablessort, extablesfieldssort, extablesrelationssort);

				foreach (DataRow dr in dt.Rows)
				{
					y_novedades_Liq y_novedades_liq = new y_novedades_Liq();
					ReadData(y_novedades_liq, dr, generateUndo);
					y_novedades_liqlist.Add(y_novedades_liq);
				}
				return y_novedades_liqlist;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public y_novedades_LiqList GetFilter( string filter, string sort, bool generateUndo=false)
		{
			return GetFilter(0,0, filter, sort, "","","","","","",generateUndo);
		}

		public y_novedades_LiqList GetFilter(string filter, string sort, string extablesfilter, string extablesfieldsfilter, string extablesrelationsfilter, string extablessort, string extablesfieldssort, string extablesrelationssort, bool generateUndo=false)
		{
			return GetFilter(0,0, filter, sort, extablesfilter, extablesfieldsfilter, extablesrelationsfilter, extablessort, extablesfieldssort, extablesrelationssort,generateUndo);
		}


		/// <summary>
		/// Returns the type for one property
		/// </summary>
		/// <param name="propertyname">Property's name for return its value</param>
		/// <returns>A value for the <paramref name="propertyname"/></returns>
		public Type GetMethodType( string propertyname,y_novedades_Liq y_novedades_liq)
		{
			// Perform the search for the property's value
			switch (propertyname)
			{
				case "IdNovedad":
					return y_novedades_liq.IdNovedad.GetType();

				case "nomina":
					return y_novedades_liq.nomina.GetType();

				case "contrato":
					return y_novedades_liq.contrato.GetType();

				case "nit":
					return y_novedades_liq.nit.GetType();

				case "idperiodo":
					return y_novedades_liq.idperiodo.GetType();

				case "concepto":
					return y_novedades_liq.concepto.GetType();

				case "fecha":
					return y_novedades_liq.fecha.GetType();

				case "mes":
					return y_novedades_liq.mes.GetType();

				case "ano":
					return y_novedades_liq.ano.GetType();

				case "periodo":
					return y_novedades_liq.periodo.GetType();

				case "valor":
					return y_novedades_liq.valor.GetType();

				case "horas":
					return y_novedades_liq.horas.GetType();

				case "dias":
					return y_novedades_liq.dias.GetType();

				case "centro":
					return y_novedades_liq.centro.GetType();

				case "planta":
					return y_novedades_liq.planta.GetType();

				case "turno":
					return y_novedades_liq.turno.GetType();

				case "estado":
					return y_novedades_liq.estado.GetType();

				case "nro_presta":
					return y_novedades_liq.nro_presta.GetType();

				case "cpto_interes":
					return y_novedades_liq.cpto_interes.GetType();

				case "sumar":
					return y_novedades_liq.sumar.GetType();

				case "oficio":
					return y_novedades_liq.oficio.GetType();

			}

			return null;
		}
		/// <summary>
		/// update the changes in y_novedades_Liq object by passing the object
		/// </summary>
		public bool UpdateChanges(y_novedades_Liq y_novedades_liq, out string error,Sinapsys.Datos.SQL datosTransaccion=null)
		{
			if (y_novedades_liq.Oldy_novedades_Liq == null)
			{
				    error = "No tiene objeto con el cual comparar";
				    return false;
			}
			string[] Fields = y_novedades_liq.FieldChanged();
			error = "";
			return LiqViajes_Bll_Data.DataProvider.UpdateFieldsbyObject(Fields, y_novedades_liq, out error,datosTransaccion);
		}
	}

	#endregion

}
