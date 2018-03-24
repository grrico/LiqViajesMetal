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
	#region movimientoController

	/// <summary>
	/// Class for convert data from database into object's data and vice versa
	/// </summary>
	public partial class movimientoController//: ILatinodeController
	{
		/// <summary>
		/// Generic Constructor
		/// </summary>
		public movimientoController()
		{
		}

		/// <summary>
		/// Instance accessor for this singleton
		/// </summary>
		private static movimientoController MySingleObj;
		public static movimientoController Instance
		{
			get
			{
				if (MySingleObj == null)
				{
					MySingleObj = new movimientoController();
				}
				return MySingleObj;
			}
		}

		// Reads object's data from a DataRow
		private void ReadData(movimiento movimiento, DataRow dr,bool generateUndo=false)
		{
			try 
			{
				movimiento.tipo = (string) dr["tipo"];
				movimiento.numero = (int) dr["numero"];
				movimiento.seq = (int) dr["seq"];
				movimiento.cuenta = (string) dr["cuenta"];
				movimiento.centro = (int) dr["centro"];
				movimiento.nit = (decimal) dr["nit"];
				movimiento.fec = (DateTime) dr["fec"];
				movimiento.valor = (decimal) dr["valor"];
				//movimiento.base = dr.IsNull("base") ? null :(decimal?) dr["base"];
				movimiento.documento = dr.IsNull("documento") ? null :(int?) dr["documento"];
				movimiento.explicacion = dr.IsNull("explicacion") ? null :(string) dr["explicacion"];
				movimiento.concilio = dr.IsNull("concilio") ? null :(string) dr["concilio"];
				movimiento.concepto_mov = dr.IsNull("concepto_mov") ? null :(short?)Convert.ToInt16(dr["concepto_mov"]);
				movimiento.concilio_ano = dr.IsNull("concilio_ano") ? null :(short?)Convert.ToInt16(dr["concilio_ano"]);
				movimiento.secuencia_extracto = dr.IsNull("secuencia_extracto") ? null :(int?) dr["secuencia_extracto"];
				movimiento.ano_concilia = dr.IsNull("ano_concilia") ? null :(int?) dr["ano_concilia"];
				movimiento.mes_concilia = dr.IsNull("mes_concilia") ? null :(int?) dr["mes_concilia"];
				movimiento.ID_CRUCE = dr.IsNull("ID_CRUCE") ? null :(int?) dr["ID_CRUCE"];
				movimiento.TIPO_CRUCE = dr.IsNull("TIPO_CRUCE") ? null :(string) dr["TIPO_CRUCE"];
				movimiento.valor_niif = (decimal) dr["valor_niif"];
			}
			catch (Exception ex)
			{
				Utilidades.LogErrores(ex.Message + (ex.InnerException != null ? ex.InnerException.Message : ""), DataProvider.AplicacionNombre);
				throw ex;
			}
			if (generateUndo) movimiento.GenerateUndo();
		}

		/// <summary>
		/// Create a new movimiento object by passing a object
		/// </summary>
		public movimiento Create(movimiento movimiento, Sinapsys.Datos.SQL datosTransaccion=null)
		{
			return Create(movimiento.tipo,movimiento.numero,movimiento.seq,movimiento.cuenta,movimiento.centro,movimiento.nit,movimiento.fec,movimiento.valor,movimiento.documento,movimiento.explicacion,movimiento.concilio,movimiento.concepto_mov,movimiento.concilio_ano,movimiento.secuencia_extracto,movimiento.ano_concilia,movimiento.mes_concilia,movimiento.ID_CRUCE,movimiento.TIPO_CRUCE,movimiento.valor_niif,datosTransaccion);
		}

		/// <summary>
		/// Creates a new movimiento object by passing all object's fields
		/// </summary>
		/// <param name="cuenta">string that contents the cuenta value for the movimiento object</param>
		/// <param name="centro">int that contents the centro value for the movimiento object</param>
		/// <param name="nit">decimal that contents the nit value for the movimiento object</param>
		/// <param name="fec">DateTime that contents the fec value for the movimiento object</param>
		/// <param name="valor">decimal that contents the valor value for the movimiento object</param>
		/// <param name="base">decimal that contents the base value for the movimiento object</param>
		/// <param name="documento">int that contents the documento value for the movimiento object</param>
		/// <param name="explicacion">string that contents the explicacion value for the movimiento object</param>
		/// <param name="concilio">string that contents the concilio value for the movimiento object</param>
		/// <param name="concepto_mov">short that contents the concepto_mov value for the movimiento object</param>
		/// <param name="concilio_ano">short that contents the concilio_ano value for the movimiento object</param>
		/// <param name="secuencia_extracto">int that contents the secuencia_extracto value for the movimiento object</param>
		/// <param name="ano_concilia">int that contents the ano_concilia value for the movimiento object</param>
		/// <param name="mes_concilia">int that contents the mes_concilia value for the movimiento object</param>
		/// <param name="ID_CRUCE">int that contents the ID_CRUCE value for the movimiento object</param>
		/// <param name="TIPO_CRUCE">string that contents the TIPO_CRUCE value for the movimiento object</param>
		/// <param name="valor_niif">decimal that contents the valor_niif value for the movimiento object</param>
		/// <returns>One movimiento object</returns>
		public movimiento Create(string tipo, int numero, int seq, string cuenta, int centro, decimal nit, DateTime fec, decimal valor, int? documento, string explicacion, string concilio, short? concepto_mov, short? concilio_ano, int? secuencia_extracto, int? ano_concilia, int? mes_concilia, int? ID_CRUCE, string TIPO_CRUCE, decimal valor_niif, Sinapsys.Datos.SQL datosTransaccion=null)
		{
			try 
			{
				movimiento movimiento = new movimiento();

				movimiento.tipo = tipo;
				movimiento.numero = numero;
				movimiento.seq = seq;
				movimiento.cuenta = cuenta;
				movimiento.centro = centro;
				movimiento.nit = nit;
				movimiento.fec = fec;
				movimiento.valor = valor;
				movimiento.documento = documento;
				movimiento.explicacion = explicacion;
				movimiento.concilio = concilio;
				movimiento.concepto_mov = concepto_mov;
				movimiento.concilio_ano = concilio_ano;
				movimiento.secuencia_extracto = secuencia_extracto;
				movimiento.ano_concilia = ano_concilia;
				movimiento.mes_concilia = mes_concilia;
				movimiento.ID_CRUCE = ID_CRUCE;
				movimiento.TIPO_CRUCE = TIPO_CRUCE;
				movimiento.valor_niif = valor_niif;
				movimientoDataProvider.Instance.Create(tipo, numero, seq, cuenta, centro, nit, fec, valor, documento, explicacion, concilio, concepto_mov, concilio_ano, secuencia_extracto, ano_concilia, mes_concilia, ID_CRUCE, TIPO_CRUCE, valor_niif,"movimiento");

				return movimiento;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Updates an movimiento object by passing all object's fields
		/// </summary>
		/// <param name="tipo">string that contents the tipo value for the movimiento object</param>
		/// <param name="numero">int that contents the numero value for the movimiento object</param>
		/// <param name="seq">int that contents the seq value for the movimiento object</param>
		/// <param name="cuenta">string that contents the cuenta value for the movimiento object</param>
		/// <param name="centro">int that contents the centro value for the movimiento object</param>
		/// <param name="nit">decimal that contents the nit value for the movimiento object</param>
		/// <param name="fec">DateTime that contents the fec value for the movimiento object</param>
		/// <param name="valor">decimal that contents the valor value for the movimiento object</param>
		/// <param name="base">decimal that contents the base value for the movimiento object</param>
		/// <param name="documento">int that contents the documento value for the movimiento object</param>
		/// <param name="explicacion">string that contents the explicacion value for the movimiento object</param>
		/// <param name="concilio">string that contents the concilio value for the movimiento object</param>
		/// <param name="concepto_mov">short that contents the concepto_mov value for the movimiento object</param>
		/// <param name="concilio_ano">short that contents the concilio_ano value for the movimiento object</param>
		/// <param name="secuencia_extracto">int that contents the secuencia_extracto value for the movimiento object</param>
		/// <param name="ano_concilia">int that contents the ano_concilia value for the movimiento object</param>
		/// <param name="mes_concilia">int that contents the mes_concilia value for the movimiento object</param>
		/// <param name="ID_CRUCE">int that contents the ID_CRUCE value for the movimiento object</param>
		/// <param name="TIPO_CRUCE">string that contents the TIPO_CRUCE value for the movimiento object</param>
		/// <param name="valor_niif">decimal that contents the valor_niif value for the movimiento object</param>
		public void Update(string tipo, int numero, int seq, string cuenta, int centro, decimal nit, DateTime fec, decimal valor, int? documento, string explicacion, string concilio, short? concepto_mov, short? concilio_ano, int? secuencia_extracto, int? ano_concilia, int? mes_concilia, int? ID_CRUCE, string TIPO_CRUCE, decimal valor_niif, Sinapsys.Datos.SQL datosTransaccion=null)
		{
			try 
			{
				movimiento new_values = new movimiento();
				new_values.cuenta = cuenta;
				new_values.centro = centro;
				new_values.nit = nit;
				new_values.fec = fec;
				new_values.valor = valor;
				new_values.documento = documento;
				new_values.explicacion = explicacion;
				new_values.concilio = concilio;
				new_values.concepto_mov = concepto_mov;
				new_values.concilio_ano = concilio_ano;
				new_values.secuencia_extracto = secuencia_extracto;
				new_values.ano_concilia = ano_concilia;
				new_values.mes_concilia = mes_concilia;
				new_values.ID_CRUCE = ID_CRUCE;
				new_values.TIPO_CRUCE = TIPO_CRUCE;
				new_values.valor_niif = valor_niif;
				movimientoDataProvider.Instance.Update(tipo, numero, seq, cuenta, centro, nit, fec, valor,  documento, explicacion, concilio, concepto_mov, concilio_ano, secuencia_extracto, ano_concilia, mes_concilia, ID_CRUCE, TIPO_CRUCE, valor_niif,"movimiento",datosTransaccion);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Updates an movimiento object by passing one object's instance as reference
		/// </summary>
		/// <param name="movimiento">An instance of movimiento for reference</param>
		public void Update(movimiento movimiento,Sinapsys.Datos.SQL datosTransaccion=null)
		{
			Update(movimiento.tipo, movimiento.numero, movimiento.seq, movimiento.cuenta, movimiento.centro, movimiento.nit, movimiento.fec, movimiento.valor, movimiento.documento, movimiento.explicacion, movimiento.concilio, movimiento.concepto_mov, movimiento.concilio_ano, movimiento.secuencia_extracto, movimiento.ano_concilia, movimiento.mes_concilia, movimiento.ID_CRUCE, movimiento.TIPO_CRUCE, movimiento.valor_niif);
		}

		/// <summary>
		/// Delete  the movimiento object by passing a object
		/// </summary>
		public void  Delete(movimiento movimiento, Sinapsys.Datos.SQL datosTransaccion=null)
		{
			Delete(movimiento.tipo, movimiento.numero, movimiento.seq,datosTransaccion);
		}

		/// <summary>
		/// Deletes the movimiento object by passing one object's instance as reference
		/// </summary>
		/// <param name="movimiento">An instance of movimiento for reference</param>
		public void Delete(string tipo, int numero, int seq, Sinapsys.Datos.SQL datosTransaccion=null)
		{
			try 
			{
				movimientoDataProvider.Instance.Delete(tipo, numero, seq,"movimiento");
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Deletes the movimiento object by passing CVS parameter as reference
		/// </summary>
		/// <param name="movimiento">An instance of movimiento for reference</param>
		public void Delete(string CVSParameter)
		{
			string[] StrCommand=CVSParameter.Split(',');
			try 
			{
				string tipo=StrCommand[0];
				int numero=int.Parse(StrCommand[1]);
				int seq=int.Parse(StrCommand[2]);
				movimientoDataProvider.Instance.Delete(tipo, numero, seq,"movimiento");
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Gets the movimiento object by passing the object's key fields
		/// </summary>
		/// <param name="tipo">string that contents the tipo value for the movimiento object</param>
		/// <param name="numero">int that contents the numero value for the movimiento object</param>
		/// <param name="seq">int that contents the seq value for the movimiento object</param>
		/// <returns>One movimiento object</returns>
		public movimiento Get(string tipo, int numero, int seq, bool generateUndo=false)
		{
			try 
			{
				movimiento movimiento = null;
				DataTable dt = movimientoDataProvider.Instance.Get(tipo, numero, seq);
				if ((dt.Rows.Count > 0))
				{
					movimiento = new movimiento();
					DataRow dr = dt.Rows[0];
					ReadData(movimiento, dr, generateUndo);
				}


				return movimiento;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Gets all objects of movimiento
		/// </summary>
		/// <returns>One movimientoList object</returns>
		public movimientoList GetAll(bool generateUndo=false)
		{
			try 
			{
				movimientoList movimientolist = new movimientoList();
				DataTable dt = movimientoDataProvider.Instance.GetAll();
				foreach (DataRow dr in dt.Rows)
				{
					movimiento movimiento = new movimiento();
					ReadData(movimiento, dr, generateUndo);
					movimientolist.Add(movimiento);
				}
				return movimientolist;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Selects all movimiento objects by reference (Foreign Keys)
		/// </summary>
		/// <param name="ID_CRUCE">int that contents the ID_CRUCE value for the movimiento object</param>
		/// <returns>One movimientoList object</returns>
		public movimientoList GetBy_ID_CRUCE(int ID_CRUCE,bool generateUndo=false)
		{
			try 
			{
				movimientoList movimientolist = new movimientoList();

				DataTable dt = movimientoDataProvider.Instance.GetBy_ID_CRUCE(ID_CRUCE);
				foreach (DataRow dr in dt.Rows)
				{
					movimiento movimiento = new movimiento();
					ReadData(movimiento, dr, generateUndo);
					movimientolist.Add(movimiento);
				}
				return movimientolist;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Gets all objects of movimiento applying filter and sort criteria
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
		/// <returns>One movimientoList object</returns>
		public movimientoList GetFilter(int pagenum, int pagesize, string filter, string sort, string extablesfilter, string extablesfieldsfilter, string extablesrelationsfilter, string extablessort, string extablesfieldssort, string extablesrelationssort, bool generateUndo=false)
		{
			try 
			{
				movimientoList movimientolist = new movimientoList();

				DataTable dt = movimientoDataProvider.Instance.GetFilter(pagenum, pagesize, filter, sort, extablesfilter, extablesfieldsfilter, extablesrelationsfilter, extablessort, extablesfieldssort, extablesrelationssort);

				foreach (DataRow dr in dt.Rows)
				{
					movimiento movimiento = new movimiento();
					ReadData(movimiento, dr, generateUndo);
					movimientolist.Add(movimiento);
				}
				return movimientolist;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public movimientoList GetFilter( string filter, string sort, bool generateUndo=false)
		{
			return GetFilter(0,0, filter, sort, "","","","","","",generateUndo);
		}

		public movimientoList GetFilter(string filter, string sort, string extablesfilter, string extablesfieldsfilter, string extablesrelationsfilter, string extablessort, string extablesfieldssort, string extablesrelationssort, bool generateUndo=false)
		{
			return GetFilter(0,0, filter, sort, extablesfilter, extablesfieldsfilter, extablesrelationsfilter, extablessort, extablesfieldssort, extablesrelationssort,generateUndo);
		}


		/// <summary>
		/// Returns the type for one property
		/// </summary>
		/// <param name="propertyname">Property's name for return its value</param>
		/// <returns>A value for the <paramref name="propertyname"/></returns>
		public Type GetMethodType( string propertyname,movimiento movimiento)
		{
			// Perform the search for the property's value
			switch (propertyname)
			{
				case "tipo":
					return movimiento.tipo.GetType();

				case "numero":
					return movimiento.numero.GetType();

				case "seq":
					return movimiento.seq.GetType();

				case "cuenta":
					return movimiento.cuenta.GetType();

				case "centro":
					return movimiento.centro.GetType();

				case "nit":
					return movimiento.nit.GetType();

				case "fec":
					return movimiento.fec.GetType();

				case "valor":
					return movimiento.valor.GetType();

				//case "base":
				//	return movimiento.base.GetType();

				case "documento":
					return movimiento.documento.GetType();

				case "explicacion":
					return movimiento.explicacion.GetType();

				case "concilio":
					return movimiento.concilio.GetType();

				case "concepto_mov":
					return movimiento.concepto_mov.GetType();

				case "concilio_ano":
					return movimiento.concilio_ano.GetType();

				case "secuencia_extracto":
					return movimiento.secuencia_extracto.GetType();

				case "ano_concilia":
					return movimiento.ano_concilia.GetType();

				case "mes_concilia":
					return movimiento.mes_concilia.GetType();

				case "ID_CRUCE":
					return movimiento.ID_CRUCE.GetType();

				case "TIPO_CRUCE":
					return movimiento.TIPO_CRUCE.GetType();

				case "valor_niif":
					return movimiento.valor_niif.GetType();

			}

			return null;
		}
		/// <summary>
		/// update the changes in movimiento object by passing the object
		/// </summary>
		public bool UpdateChanges(movimiento movimiento, out string error,Sinapsys.Datos.SQL datosTransaccion=null)
		{
			if (movimiento.Oldmovimiento == null)
			{
				    error = "No tiene objeto con el cual comparar";
				    return false;
			}
			string[] Fields = movimiento.FieldChanged();
			error = "";
			return LiqMetalDMS_Bll_Data.DataProvider.UpdateFieldsbyObject(Fields, movimiento, out error,datosTransaccion);
		}
	}

	#endregion

}
