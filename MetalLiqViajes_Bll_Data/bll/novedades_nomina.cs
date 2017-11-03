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
	#region novedades_nominaController

	/// <summary>
	/// Class for convert data from database into object's data and vice versa
	/// </summary>
	public partial class novedades_nominaController//: ILatinodeController
	{
		/// <summary>
		/// Generic Constructor
		/// </summary>
		public novedades_nominaController()
		{
		}

		/// <summary>
		/// Instance accessor for this singleton
		/// </summary>
		private static novedades_nominaController MySingleObj;
		public static novedades_nominaController Instance
		{
			get
			{
				if (MySingleObj == null)
				{
					MySingleObj = new novedades_nominaController();
				}
				return MySingleObj;
			}
		}

		// Reads object's data from a DataRow
		private void ReadData(novedades_nomina novedades_nomina, DataRow dr,bool generateUndo=false)
		{
			try 
			{
				novedades_nomina.concepto = Convert.ToInt16(dr["concepto"]);
				novedades_nomina.fecha = (DateTime) dr["fecha"];
				novedades_nomina.mes = dr.IsNull("mes") ? null :(byte?) dr["mes"];
				novedades_nomina.ano = dr.IsNull("ano") ? null :(short?)Convert.ToInt16(dr["ano"]);
				novedades_nomina.periodo = dr.IsNull("periodo") ? null :(int?) dr["periodo"];
				novedades_nomina.valor = dr.IsNull("valor") ? null :(decimal?) dr["valor"];
				novedades_nomina.horas = dr.IsNull("horas") ? null :(float?) dr["horas"];
				novedades_nomina.dias = dr.IsNull("dias") ? null :(float?) dr["dias"];
				novedades_nomina.turno = dr.IsNull("turno") ? null :(byte?) dr["turno"];
				novedades_nomina.estado = dr.IsNull("estado") ? null :(char?) ((string) dr["estado"])[0];
				novedades_nomina.nro_presta = dr.IsNull("nro_presta") ? null :(int?) dr["nro_presta"];
				novedades_nomina.cpto_interes = dr.IsNull("cpto_interes") ? null :(short?)Convert.ToInt16(dr["cpto_interes"]);
				novedades_nomina.sumar = dr.IsNull("sumar") ? null :(bool?) dr["sumar"];
				novedades_nomina.oficio = dr.IsNull("oficio") ? null :(string) dr["oficio"];
				novedades_nomina.tipo_doc = dr.IsNull("tipo_doc") ? null :(string) dr["tipo_doc"];
				novedades_nomina.numero_doc = dr.IsNull("numero_doc") ? null :(int?) dr["numero_doc"];
				novedades_nomina.cuota = dr.IsNull("cuota") ? null :(int?) dr["cuota"];
				novedades_nomina.IdNovedad = (int) dr["IdNovedad"];
				novedades_nomina.nomina = (string) dr["nomina"];
				novedades_nomina.contrato = (int) dr["contrato"];
				novedades_nomina.nit = (string) dr["nit"];
				novedades_nomina.idperiodo = (int) dr["idperiodo"];
				novedades_nomina.centro = (int) dr["centro"];
				novedades_nomina.planta = (byte) dr["planta"];
			}
			catch (Exception ex)
			{
				Utilidades.LogErrores(ex.Message + (ex.InnerException != null ? ex.InnerException.Message : ""), DataProvider.AplicacionNombre);
				throw ex;
			}
			if (generateUndo) novedades_nomina.GenerateUndo();
		}

		/// <summary>
		/// Create a new novedades_nomina object by passing a object
		/// </summary>
		public novedades_nomina Create(novedades_nomina novedades_nomina, Sinapsys.Datos.SQL datosTransaccion=null)
		{
			return Create(novedades_nomina.IdNovedad,novedades_nomina.nomina,novedades_nomina.contrato,novedades_nomina.nit,novedades_nomina.idperiodo,novedades_nomina.centro,novedades_nomina.planta,novedades_nomina.concepto,novedades_nomina.fecha,novedades_nomina.mes,novedades_nomina.ano,novedades_nomina.periodo,novedades_nomina.valor,novedades_nomina.horas,novedades_nomina.dias,novedades_nomina.turno,novedades_nomina.estado,novedades_nomina.nro_presta,novedades_nomina.cpto_interes,novedades_nomina.sumar,novedades_nomina.oficio,novedades_nomina.tipo_doc,novedades_nomina.numero_doc,novedades_nomina.cuota,datosTransaccion);
		}

		/// <summary>
		/// Creates a new novedades_nomina object by passing all object's fields
		/// </summary>
		/// <param name="concepto">short that contents the concepto value for the novedades_nomina object</param>
		/// <param name="fecha">DateTime that contents the fecha value for the novedades_nomina object</param>
		/// <param name="mes">byte that contents the mes value for the novedades_nomina object</param>
		/// <param name="ano">short that contents the ano value for the novedades_nomina object</param>
		/// <param name="periodo">int that contents the periodo value for the novedades_nomina object</param>
		/// <param name="valor">decimal that contents the valor value for the novedades_nomina object</param>
		/// <param name="horas">float that contents the horas value for the novedades_nomina object</param>
		/// <param name="dias">float that contents the dias value for the novedades_nomina object</param>
		/// <param name="turno">byte that contents the turno value for the novedades_nomina object</param>
		/// <param name="estado">char that contents the estado value for the novedades_nomina object</param>
		/// <param name="nro_presta">int that contents the nro_presta value for the novedades_nomina object</param>
		/// <param name="cpto_interes">short that contents the cpto_interes value for the novedades_nomina object</param>
		/// <param name="sumar">bool that contents the sumar value for the novedades_nomina object</param>
		/// <param name="oficio">string that contents the oficio value for the novedades_nomina object</param>
		/// <param name="tipo_doc">string that contents the tipo_doc value for the novedades_nomina object</param>
		/// <param name="numero_doc">int that contents the numero_doc value for the novedades_nomina object</param>
		/// <param name="cuota">int that contents the cuota value for the novedades_nomina object</param>
		/// <returns>One novedades_nomina object</returns>
		public novedades_nomina Create(int IdNovedad, string nomina, int contrato, string nit, int idperiodo, int centro, byte planta, short concepto, DateTime fecha, byte? mes, short? ano, int? periodo, decimal? valor, float? horas, float? dias, byte? turno, char? estado, int? nro_presta, short? cpto_interes, bool? sumar, string oficio, string tipo_doc, int? numero_doc, int? cuota, Sinapsys.Datos.SQL datosTransaccion=null)
		{
			try 
			{
				novedades_nomina novedades_nomina = new novedades_nomina();

				novedades_nomina.IdNovedad = IdNovedad;
				novedades_nomina.nomina = nomina;
				novedades_nomina.contrato = contrato;
				novedades_nomina.nit = nit;
				novedades_nomina.idperiodo = idperiodo;
				novedades_nomina.centro = centro;
				novedades_nomina.planta = planta;
				novedades_nomina.concepto = concepto;
				novedades_nomina.fecha = fecha;
				novedades_nomina.mes = mes;
				novedades_nomina.ano = ano;
				novedades_nomina.periodo = periodo;
				novedades_nomina.valor = valor;
				novedades_nomina.horas = horas;
				novedades_nomina.dias = dias;
				novedades_nomina.turno = turno;
				novedades_nomina.estado = estado;
				novedades_nomina.nro_presta = nro_presta;
				novedades_nomina.cpto_interes = cpto_interes;
				novedades_nomina.sumar = sumar;
				novedades_nomina.oficio = oficio;
				novedades_nomina.tipo_doc = tipo_doc;
				novedades_nomina.numero_doc = numero_doc;
				novedades_nomina.cuota = cuota;
				novedades_nominaDataProvider.Instance.Create(IdNovedad, nomina, contrato, nit, idperiodo, centro, planta, concepto, fecha, mes, ano, periodo, valor, horas, dias, turno, estado, nro_presta, cpto_interes, sumar, oficio, tipo_doc, numero_doc, cuota,"novedades_nomina");

				return novedades_nomina;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Updates an novedades_nomina object by passing all object's fields
		/// </summary>
		/// <param name="concepto">short that contents the concepto value for the novedades_nomina object</param>
		/// <param name="fecha">DateTime that contents the fecha value for the novedades_nomina object</param>
		/// <param name="mes">byte that contents the mes value for the novedades_nomina object</param>
		/// <param name="ano">short that contents the ano value for the novedades_nomina object</param>
		/// <param name="periodo">int that contents the periodo value for the novedades_nomina object</param>
		/// <param name="valor">decimal that contents the valor value for the novedades_nomina object</param>
		/// <param name="horas">float that contents the horas value for the novedades_nomina object</param>
		/// <param name="dias">float that contents the dias value for the novedades_nomina object</param>
		/// <param name="turno">byte that contents the turno value for the novedades_nomina object</param>
		/// <param name="estado">char that contents the estado value for the novedades_nomina object</param>
		/// <param name="nro_presta">int that contents the nro_presta value for the novedades_nomina object</param>
		/// <param name="cpto_interes">short that contents the cpto_interes value for the novedades_nomina object</param>
		/// <param name="sumar">bool that contents the sumar value for the novedades_nomina object</param>
		/// <param name="oficio">string that contents the oficio value for the novedades_nomina object</param>
		/// <param name="tipo_doc">string that contents the tipo_doc value for the novedades_nomina object</param>
		/// <param name="numero_doc">int that contents the numero_doc value for the novedades_nomina object</param>
		/// <param name="cuota">int that contents the cuota value for the novedades_nomina object</param>
		/// <param name="IdNovedad">int that contents the IdNovedad value for the novedades_nomina object</param>
		/// <param name="nomina">string that contents the nomina value for the novedades_nomina object</param>
		/// <param name="contrato">int that contents the contrato value for the novedades_nomina object</param>
		/// <param name="nit">string that contents the nit value for the novedades_nomina object</param>
		/// <param name="idperiodo">int that contents the idperiodo value for the novedades_nomina object</param>
		/// <param name="centro">int that contents the centro value for the novedades_nomina object</param>
		/// <param name="planta">byte that contents the planta value for the novedades_nomina object</param>
		public void Update(short concepto, DateTime fecha, byte? mes, short? ano, int? periodo, decimal? valor, float? horas, float? dias, byte? turno, char? estado, int? nro_presta, short? cpto_interes, bool? sumar, string oficio, string tipo_doc, int? numero_doc, int? cuota, int IdNovedad, string nomina, int contrato, string nit, int idperiodo, int centro, byte planta, Sinapsys.Datos.SQL datosTransaccion=null)
		{
			try 
			{
				novedades_nomina new_values = new novedades_nomina();
				new_values.concepto = concepto;
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
				new_values.tipo_doc = tipo_doc;
				new_values.numero_doc = numero_doc;
				new_values.cuota = cuota;
				novedades_nominaDataProvider.Instance.Update(concepto, fecha, mes, ano, periodo, valor, horas, dias, turno, estado, nro_presta, cpto_interes, sumar, oficio, tipo_doc, numero_doc, cuota, IdNovedad, nomina, contrato, nit, idperiodo, centro, planta,"novedades_nomina",datosTransaccion);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Updates an novedades_nomina object by passing one object's instance as reference
		/// </summary>
		/// <param name="novedades_nomina">An instance of novedades_nomina for reference</param>
		public void Update(novedades_nomina novedades_nomina,Sinapsys.Datos.SQL datosTransaccion=null)
		{
			Update(novedades_nomina.concepto, novedades_nomina.fecha, novedades_nomina.mes, novedades_nomina.ano, novedades_nomina.periodo, novedades_nomina.valor, novedades_nomina.horas, novedades_nomina.dias, novedades_nomina.turno, novedades_nomina.estado, novedades_nomina.nro_presta, novedades_nomina.cpto_interes, novedades_nomina.sumar, novedades_nomina.oficio, novedades_nomina.tipo_doc, novedades_nomina.numero_doc, novedades_nomina.cuota, novedades_nomina.IdNovedad, novedades_nomina.nomina, novedades_nomina.contrato, novedades_nomina.nit, novedades_nomina.idperiodo, novedades_nomina.centro, novedades_nomina.planta);
		}

		/// <summary>
		/// Delete  the novedades_nomina object by passing a object
		/// </summary>
		public void  Delete(novedades_nomina novedades_nomina, Sinapsys.Datos.SQL datosTransaccion=null)
		{
			Delete(novedades_nomina.IdNovedad, novedades_nomina.nomina, novedades_nomina.contrato, novedades_nomina.nit, novedades_nomina.idperiodo, novedades_nomina.centro, novedades_nomina.planta,datosTransaccion);
		}

		/// <summary>
		/// Deletes the novedades_nomina object by passing one object's instance as reference
		/// </summary>
		/// <param name="novedades_nomina">An instance of novedades_nomina for reference</param>
		public void Delete(int IdNovedad, string nomina, int contrato, string nit, int idperiodo, int centro, byte planta, Sinapsys.Datos.SQL datosTransaccion=null)
		{
			try 
			{
				novedades_nominaDataProvider.Instance.Delete(IdNovedad, nomina, contrato, nit, idperiodo, centro, planta,"novedades_nomina");
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Deletes the novedades_nomina object by passing CVS parameter as reference
		/// </summary>
		/// <param name="novedades_nomina">An instance of novedades_nomina for reference</param>
		public void Delete(string CVSParameter)
		{
			string[] StrCommand=CVSParameter.Split(',');
			try 
			{
				int IdNovedad=int.Parse(StrCommand[0]);
				string nomina=StrCommand[1];
				int contrato=int.Parse(StrCommand[2]);
				string nit=StrCommand[3];
				int idperiodo=int.Parse(StrCommand[4]);
				int centro=int.Parse(StrCommand[5]);
				byte planta=byte.Parse(StrCommand[6]);
				novedades_nominaDataProvider.Instance.Delete(IdNovedad, nomina, contrato, nit, idperiodo, centro, planta,"novedades_nomina");
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Gets the novedades_nomina object by passing the object's key fields
		/// </summary>
		/// <param name="IdNovedad">int that contents the IdNovedad value for the novedades_nomina object</param>
		/// <param name="nomina">string that contents the nomina value for the novedades_nomina object</param>
		/// <param name="contrato">int that contents the contrato value for the novedades_nomina object</param>
		/// <param name="nit">string that contents the nit value for the novedades_nomina object</param>
		/// <param name="idperiodo">int that contents the idperiodo value for the novedades_nomina object</param>
		/// <param name="centro">int that contents the centro value for the novedades_nomina object</param>
		/// <param name="planta">byte that contents the planta value for the novedades_nomina object</param>
		/// <returns>One novedades_nomina object</returns>
		public novedades_nomina Get(int IdNovedad, string nomina, int contrato, string nit, int idperiodo, int centro, byte planta, bool generateUndo=false)
		{
			try 
			{
				novedades_nomina novedades_nomina = null;
				DataTable dt = novedades_nominaDataProvider.Instance.Get(IdNovedad, nomina, contrato, nit, idperiodo, centro, planta);
				if ((dt.Rows.Count > 0))
				{
					novedades_nomina = new novedades_nomina();
					DataRow dr = dt.Rows[0];
					ReadData(novedades_nomina, dr, generateUndo);
				}


				return novedades_nomina;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Gets all objects of novedades_nomina
		/// </summary>
		/// <returns>One novedades_nominaList object</returns>
		public novedades_nominaList GetAll(bool generateUndo=false)
		{
			try 
			{
				novedades_nominaList novedades_nominalist = new novedades_nominaList();
				DataTable dt = novedades_nominaDataProvider.Instance.GetAll();
				foreach (DataRow dr in dt.Rows)
				{
					novedades_nomina novedades_nomina = new novedades_nomina();
					ReadData(novedades_nomina, dr, generateUndo);
					novedades_nominalist.Add(novedades_nomina);
				}
				return novedades_nominalist;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Gets all objects of novedades_nomina applying filter and sort criteria
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
		/// <returns>One novedades_nominaList object</returns>
		public novedades_nominaList GetFilter(int pagenum, int pagesize, string filter, string sort, string extablesfilter, string extablesfieldsfilter, string extablesrelationsfilter, string extablessort, string extablesfieldssort, string extablesrelationssort, bool generateUndo=false)
		{
			try 
			{
				novedades_nominaList novedades_nominalist = new novedades_nominaList();

				DataTable dt = novedades_nominaDataProvider.Instance.GetFilter(pagenum, pagesize, filter, sort, extablesfilter, extablesfieldsfilter, extablesrelationsfilter, extablessort, extablesfieldssort, extablesrelationssort);

				foreach (DataRow dr in dt.Rows)
				{
					novedades_nomina novedades_nomina = new novedades_nomina();
					ReadData(novedades_nomina, dr, generateUndo);
					novedades_nominalist.Add(novedades_nomina);
				}
				return novedades_nominalist;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public novedades_nominaList GetFilter( string filter, string sort, bool generateUndo=false)
		{
			return GetFilter(0,0, filter, sort, "","","","","","",generateUndo);
		}

		public novedades_nominaList GetFilter(string filter, string sort, string extablesfilter, string extablesfieldsfilter, string extablesrelationsfilter, string extablessort, string extablesfieldssort, string extablesrelationssort, bool generateUndo=false)
		{
			return GetFilter(0,0, filter, sort, extablesfilter, extablesfieldsfilter, extablesrelationsfilter, extablessort, extablesfieldssort, extablesrelationssort,generateUndo);
		}


		/// <summary>
		/// Returns the type for one property
		/// </summary>
		/// <param name="propertyname">Property's name for return its value</param>
		/// <returns>A value for the <paramref name="propertyname"/></returns>
		public Type GetMethodType( string propertyname,novedades_nomina novedades_nomina)
		{
			// Perform the search for the property's value
			switch (propertyname)
			{
				case "concepto":
					return novedades_nomina.concepto.GetType();

				case "fecha":
					return novedades_nomina.fecha.GetType();

				case "mes":
					return novedades_nomina.mes.GetType();

				case "ano":
					return novedades_nomina.ano.GetType();

				case "periodo":
					return novedades_nomina.periodo.GetType();

				case "valor":
					return novedades_nomina.valor.GetType();

				case "horas":
					return novedades_nomina.horas.GetType();

				case "dias":
					return novedades_nomina.dias.GetType();

				case "turno":
					return novedades_nomina.turno.GetType();

				case "estado":
					return novedades_nomina.estado.GetType();

				case "nro_presta":
					return novedades_nomina.nro_presta.GetType();

				case "cpto_interes":
					return novedades_nomina.cpto_interes.GetType();

				case "sumar":
					return novedades_nomina.sumar.GetType();

				case "oficio":
					return novedades_nomina.oficio.GetType();

				case "tipo_doc":
					return novedades_nomina.tipo_doc.GetType();

				case "numero_doc":
					return novedades_nomina.numero_doc.GetType();

				case "cuota":
					return novedades_nomina.cuota.GetType();

				case "IdNovedad":
					return novedades_nomina.IdNovedad.GetType();

				case "nomina":
					return novedades_nomina.nomina.GetType();

				case "contrato":
					return novedades_nomina.contrato.GetType();

				case "nit":
					return novedades_nomina.nit.GetType();

				case "idperiodo":
					return novedades_nomina.idperiodo.GetType();

				case "centro":
					return novedades_nomina.centro.GetType();

				case "planta":
					return novedades_nomina.planta.GetType();

			}

			return null;
		}
		/// <summary>
		/// update the changes in novedades_nomina object by passing the object
		/// </summary>
		public bool UpdateChanges(novedades_nomina novedades_nomina, out string error,Sinapsys.Datos.SQL datosTransaccion=null)
		{
			if (novedades_nomina.Oldnovedades_nomina == null)
			{
				    error = "No tiene objeto con el cual comparar";
				    return false;
			}
			string[] Fields = novedades_nomina.FieldChanged();
			error = "";
			return LiqViajes_Bll_Data.DataProvider.UpdateFieldsbyObject(Fields, novedades_nomina, out error,datosTransaccion);
		}
	}

	#endregion

}
