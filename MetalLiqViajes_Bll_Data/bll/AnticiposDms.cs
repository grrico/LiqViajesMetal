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
	#region AnticiposDmsController

	/// <summary>
	/// Class for convert data from database into object's data and vice versa
	/// </summary>
	public partial class AnticiposDmsController//: ILatinodeController
	{
		/// <summary>
		/// Generic Constructor
		/// </summary>
		public AnticiposDmsController()
		{
		}

		/// <summary>
		/// Instance accessor for this singleton
		/// </summary>
		private static AnticiposDmsController MySingleObj;
		public static AnticiposDmsController Instance
		{
			get
			{
				if (MySingleObj == null)
				{
					MySingleObj = new AnticiposDmsController();
				}
				return MySingleObj;
			}
		}

		// Reads object's data from a DataRow
		private void ReadData(AnticiposDms anticiposdms, DataRow dr,bool generateUndo=false)
		{
			try 
			{
				anticiposdms.Dms_Codigo = (int) dr["Dms_Codigo"];
				anticiposdms.Dms_Tipo = dr.IsNull("Dms_Tipo") ? null :(string) dr["Dms_Tipo"];
				anticiposdms.Dms_Numero = dr.IsNull("Dms_Numero") ? null :(int?) dr["Dms_Numero"];
				anticiposdms.Dms_Modelo = dr.IsNull("Dms_Modelo") ? null :(string) dr["Dms_Modelo"];
				anticiposdms.Dms_Sw = dr.IsNull("Dms_Sw") ? null :(byte?) dr["Dms_Sw"];
				anticiposdms.Dms_Placa = dr.IsNull("Dms_Placa") ? null :(string) dr["Dms_Placa"];
				anticiposdms.Dms_lngIdRegistroViaje = dr.IsNull("Dms_lngIdRegistroViaje") ? null :(int?) dr["Dms_lngIdRegistroViaje"];
				anticiposdms.Dms_lngIdRegistroViajeTramo = dr.IsNull("Dms_lngIdRegistroViajeTramo") ? null :(decimal?) dr["Dms_lngIdRegistroViajeTramo"];
				anticiposdms.Dms_Nit = dr.IsNull("Dms_Nit") ? null :(decimal?) dr["Dms_Nit"];
				anticiposdms.Dms_Fecha = dr.IsNull("Dms_Fecha") ? null :(DateTime?) dr["Dms_Fecha"];
				anticiposdms.Dms_ValorTotal = dr.IsNull("Dms_ValorTotal") ? null :(decimal?) dr["Dms_ValorTotal"];
				anticiposdms.Dms_ValorAplicado = dr.IsNull("Dms_ValorAplicado") ? null :(decimal?) dr["Dms_ValorAplicado"];
				anticiposdms.Dms_ValorAnticipo = dr.IsNull("Dms_ValorAnticipo") ? null :(decimal?) dr["Dms_ValorAnticipo"];
				anticiposdms.Dms_Chk = dr.IsNull("Dms_Chk") ? null :(int?) dr["Dms_Chk"];
				anticiposdms.Dms_Nota = dr.IsNull("Dms_Nota") ? null :(string) dr["Dms_Nota"];
				anticiposdms.Dms_Documento = dr.IsNull("Dms_Documento") ? null :(string) dr["Dms_Documento"];
				anticiposdms.Dms_CodBanco = dr.IsNull("Dms_CodBanco") ? null :(double?) dr["Dms_CodBanco"];
				anticiposdms.Dms_NombreBanco = dr.IsNull("Dms_NombreBanco") ? null :(string) dr["Dms_NombreBanco"];
				anticiposdms.Dms_DescripcionModelo = dr.IsNull("Dms_DescripcionModelo") ? null :(string) dr["Dms_DescripcionModelo"];
				anticiposdms.Dms_Cuenta1 = dr.IsNull("Dms_Cuenta1") ? null :(string) dr["Dms_Cuenta1"];
				anticiposdms.Dms_Cuenta2 = dr.IsNull("Dms_Cuenta2") ? null :(string) dr["Dms_Cuenta2"];
				anticiposdms.Dms_DescripcionCta1 = dr.IsNull("Dms_DescripcionCta1") ? null :(string) dr["Dms_DescripcionCta1"];
				anticiposdms.Dms_DescripcionCta2 = dr.IsNull("Dms_DescripcionCta2") ? null :(string) dr["Dms_DescripcionCta2"];
				anticiposdms.Dms_Usuario = dr.IsNull("Dms_Usuario") ? null :(string) dr["Dms_Usuario"];
				anticiposdms.Dms_FechaReal = dr.IsNull("Dms_FechaReal") ? null :(DateTime?) dr["Dms_FechaReal"];
				anticiposdms.Dms_NombreTercero = dr.IsNull("Dms_NombreTercero") ? null :(string) dr["Dms_NombreTercero"];
			}
			catch (Exception ex)
			{
				Utilidades.LogErrores(ex.Message + (ex.InnerException != null ? ex.InnerException.Message : ""), DataProvider.AplicacionNombre);
				throw ex;
			}
			if (generateUndo) anticiposdms.GenerateUndo();
		}

		/// <summary>
		/// Create a new AnticiposDms object by passing a object
		/// </summary>
		public AnticiposDms Create(AnticiposDms anticiposdms, Sinapsys.Datos.SQL datosTransaccion=null)
		{
			return Create(anticiposdms.Dms_Codigo,anticiposdms.Dms_Tipo,anticiposdms.Dms_Numero,anticiposdms.Dms_Modelo,anticiposdms.Dms_Sw,anticiposdms.Dms_Placa,anticiposdms.Dms_lngIdRegistroViaje,anticiposdms.Dms_lngIdRegistroViajeTramo,anticiposdms.Dms_Nit,anticiposdms.Dms_Fecha,anticiposdms.Dms_ValorTotal,anticiposdms.Dms_ValorAplicado,anticiposdms.Dms_ValorAnticipo,anticiposdms.Dms_Chk,anticiposdms.Dms_Nota,anticiposdms.Dms_Documento,anticiposdms.Dms_CodBanco,anticiposdms.Dms_NombreBanco,anticiposdms.Dms_DescripcionModelo,anticiposdms.Dms_Cuenta1,anticiposdms.Dms_Cuenta2,anticiposdms.Dms_DescripcionCta1,anticiposdms.Dms_DescripcionCta2,anticiposdms.Dms_Usuario,anticiposdms.Dms_FechaReal,anticiposdms.Dms_NombreTercero,datosTransaccion);
		}

		/// <summary>
		/// Creates a new AnticiposDms object by passing all object's fields
		/// </summary>
		/// <param name="Dms_Tipo">string that contents the Dms_Tipo value for the AnticiposDms object</param>
		/// <param name="Dms_Numero">int that contents the Dms_Numero value for the AnticiposDms object</param>
		/// <param name="Dms_Modelo">string that contents the Dms_Modelo value for the AnticiposDms object</param>
		/// <param name="Dms_Sw">byte that contents the Dms_Sw value for the AnticiposDms object</param>
		/// <param name="Dms_Placa">string that contents the Dms_Placa value for the AnticiposDms object</param>
		/// <param name="Dms_lngIdRegistroViaje">int that contents the Dms_lngIdRegistroViaje value for the AnticiposDms object</param>
		/// <param name="Dms_lngIdRegistroViajeTramo">decimal that contents the Dms_lngIdRegistroViajeTramo value for the AnticiposDms object</param>
		/// <param name="Dms_Nit">decimal that contents the Dms_Nit value for the AnticiposDms object</param>
		/// <param name="Dms_Fecha">DateTime that contents the Dms_Fecha value for the AnticiposDms object</param>
		/// <param name="Dms_ValorTotal">decimal that contents the Dms_ValorTotal value for the AnticiposDms object</param>
		/// <param name="Dms_ValorAplicado">decimal that contents the Dms_ValorAplicado value for the AnticiposDms object</param>
		/// <param name="Dms_ValorAnticipo">decimal that contents the Dms_ValorAnticipo value for the AnticiposDms object</param>
		/// <param name="Dms_Chk">int that contents the Dms_Chk value for the AnticiposDms object</param>
		/// <param name="Dms_Nota">string that contents the Dms_Nota value for the AnticiposDms object</param>
		/// <param name="Dms_Documento">string that contents the Dms_Documento value for the AnticiposDms object</param>
		/// <param name="Dms_CodBanco">double that contents the Dms_CodBanco value for the AnticiposDms object</param>
		/// <param name="Dms_NombreBanco">string that contents the Dms_NombreBanco value for the AnticiposDms object</param>
		/// <param name="Dms_DescripcionModelo">string that contents the Dms_DescripcionModelo value for the AnticiposDms object</param>
		/// <param name="Dms_Cuenta1">string that contents the Dms_Cuenta1 value for the AnticiposDms object</param>
		/// <param name="Dms_Cuenta2">string that contents the Dms_Cuenta2 value for the AnticiposDms object</param>
		/// <param name="Dms_DescripcionCta1">string that contents the Dms_DescripcionCta1 value for the AnticiposDms object</param>
		/// <param name="Dms_DescripcionCta2">string that contents the Dms_DescripcionCta2 value for the AnticiposDms object</param>
		/// <param name="Dms_Usuario">string that contents the Dms_Usuario value for the AnticiposDms object</param>
		/// <param name="Dms_FechaReal">DateTime that contents the Dms_FechaReal value for the AnticiposDms object</param>
		/// <param name="Dms_NombreTercero">string that contents the Dms_NombreTercero value for the AnticiposDms object</param>
		/// <returns>One AnticiposDms object</returns>
		public AnticiposDms Create(int Dms_Codigo, string Dms_Tipo, int? Dms_Numero, string Dms_Modelo, byte? Dms_Sw, string Dms_Placa, int? Dms_lngIdRegistroViaje, decimal? Dms_lngIdRegistroViajeTramo, decimal? Dms_Nit, DateTime? Dms_Fecha, decimal? Dms_ValorTotal, decimal? Dms_ValorAplicado, decimal? Dms_ValorAnticipo, int? Dms_Chk, string Dms_Nota, string Dms_Documento, double? Dms_CodBanco, string Dms_NombreBanco, string Dms_DescripcionModelo, string Dms_Cuenta1, string Dms_Cuenta2, string Dms_DescripcionCta1, string Dms_DescripcionCta2, string Dms_Usuario, DateTime? Dms_FechaReal, string Dms_NombreTercero, Sinapsys.Datos.SQL datosTransaccion=null)
		{
			try 
			{
				AnticiposDms anticiposdms = new AnticiposDms();

				anticiposdms.Dms_Codigo = Dms_Codigo;
				anticiposdms.Dms_Tipo = Dms_Tipo;
				anticiposdms.Dms_Numero = Dms_Numero;
				anticiposdms.Dms_Modelo = Dms_Modelo;
				anticiposdms.Dms_Sw = Dms_Sw;
				anticiposdms.Dms_Placa = Dms_Placa;
				anticiposdms.Dms_lngIdRegistroViaje = Dms_lngIdRegistroViaje;
				anticiposdms.Dms_lngIdRegistroViajeTramo = Dms_lngIdRegistroViajeTramo;
				anticiposdms.Dms_Nit = Dms_Nit;
				anticiposdms.Dms_Fecha = Dms_Fecha;
				anticiposdms.Dms_ValorTotal = Dms_ValorTotal;
				anticiposdms.Dms_ValorAplicado = Dms_ValorAplicado;
				anticiposdms.Dms_ValorAnticipo = Dms_ValorAnticipo;
				anticiposdms.Dms_Chk = Dms_Chk;
				anticiposdms.Dms_Nota = Dms_Nota;
				anticiposdms.Dms_Documento = Dms_Documento;
				anticiposdms.Dms_CodBanco = Dms_CodBanco;
				anticiposdms.Dms_NombreBanco = Dms_NombreBanco;
				anticiposdms.Dms_DescripcionModelo = Dms_DescripcionModelo;
				anticiposdms.Dms_Cuenta1 = Dms_Cuenta1;
				anticiposdms.Dms_Cuenta2 = Dms_Cuenta2;
				anticiposdms.Dms_DescripcionCta1 = Dms_DescripcionCta1;
				anticiposdms.Dms_DescripcionCta2 = Dms_DescripcionCta2;
				anticiposdms.Dms_Usuario = Dms_Usuario;
				anticiposdms.Dms_FechaReal = Dms_FechaReal;
				anticiposdms.Dms_NombreTercero = Dms_NombreTercero;
				AnticiposDmsDataProvider.Instance.Create(Dms_Codigo, Dms_Tipo, Dms_Numero, Dms_Modelo, Dms_Sw, Dms_Placa, Dms_lngIdRegistroViaje, Dms_lngIdRegistroViajeTramo, Dms_Nit, Dms_Fecha, Dms_ValorTotal, Dms_ValorAplicado, Dms_ValorAnticipo, Dms_Chk, Dms_Nota, Dms_Documento, Dms_CodBanco, Dms_NombreBanco, Dms_DescripcionModelo, Dms_Cuenta1, Dms_Cuenta2, Dms_DescripcionCta1, Dms_DescripcionCta2, Dms_Usuario, Dms_FechaReal, Dms_NombreTercero,"AnticiposDms");

				return anticiposdms;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Updates an AnticiposDms object by passing all object's fields
		/// </summary>
		/// <param name="Dms_Codigo">int that contents the Dms_Codigo value for the AnticiposDms object</param>
		/// <param name="Dms_Tipo">string that contents the Dms_Tipo value for the AnticiposDms object</param>
		/// <param name="Dms_Numero">int that contents the Dms_Numero value for the AnticiposDms object</param>
		/// <param name="Dms_Modelo">string that contents the Dms_Modelo value for the AnticiposDms object</param>
		/// <param name="Dms_Sw">byte that contents the Dms_Sw value for the AnticiposDms object</param>
		/// <param name="Dms_Placa">string that contents the Dms_Placa value for the AnticiposDms object</param>
		/// <param name="Dms_lngIdRegistroViaje">int that contents the Dms_lngIdRegistroViaje value for the AnticiposDms object</param>
		/// <param name="Dms_lngIdRegistroViajeTramo">decimal that contents the Dms_lngIdRegistroViajeTramo value for the AnticiposDms object</param>
		/// <param name="Dms_Nit">decimal that contents the Dms_Nit value for the AnticiposDms object</param>
		/// <param name="Dms_Fecha">DateTime that contents the Dms_Fecha value for the AnticiposDms object</param>
		/// <param name="Dms_ValorTotal">decimal that contents the Dms_ValorTotal value for the AnticiposDms object</param>
		/// <param name="Dms_ValorAplicado">decimal that contents the Dms_ValorAplicado value for the AnticiposDms object</param>
		/// <param name="Dms_ValorAnticipo">decimal that contents the Dms_ValorAnticipo value for the AnticiposDms object</param>
		/// <param name="Dms_Chk">int that contents the Dms_Chk value for the AnticiposDms object</param>
		/// <param name="Dms_Nota">string that contents the Dms_Nota value for the AnticiposDms object</param>
		/// <param name="Dms_Documento">string that contents the Dms_Documento value for the AnticiposDms object</param>
		/// <param name="Dms_CodBanco">double that contents the Dms_CodBanco value for the AnticiposDms object</param>
		/// <param name="Dms_NombreBanco">string that contents the Dms_NombreBanco value for the AnticiposDms object</param>
		/// <param name="Dms_DescripcionModelo">string that contents the Dms_DescripcionModelo value for the AnticiposDms object</param>
		/// <param name="Dms_Cuenta1">string that contents the Dms_Cuenta1 value for the AnticiposDms object</param>
		/// <param name="Dms_Cuenta2">string that contents the Dms_Cuenta2 value for the AnticiposDms object</param>
		/// <param name="Dms_DescripcionCta1">string that contents the Dms_DescripcionCta1 value for the AnticiposDms object</param>
		/// <param name="Dms_DescripcionCta2">string that contents the Dms_DescripcionCta2 value for the AnticiposDms object</param>
		/// <param name="Dms_Usuario">string that contents the Dms_Usuario value for the AnticiposDms object</param>
		/// <param name="Dms_FechaReal">DateTime that contents the Dms_FechaReal value for the AnticiposDms object</param>
		/// <param name="Dms_NombreTercero">string that contents the Dms_NombreTercero value for the AnticiposDms object</param>
		public void Update(int Dms_Codigo, string Dms_Tipo, int? Dms_Numero, string Dms_Modelo, byte? Dms_Sw, string Dms_Placa, int? Dms_lngIdRegistroViaje, decimal? Dms_lngIdRegistroViajeTramo, decimal? Dms_Nit, DateTime? Dms_Fecha, decimal? Dms_ValorTotal, decimal? Dms_ValorAplicado, decimal? Dms_ValorAnticipo, int? Dms_Chk, string Dms_Nota, string Dms_Documento, double? Dms_CodBanco, string Dms_NombreBanco, string Dms_DescripcionModelo, string Dms_Cuenta1, string Dms_Cuenta2, string Dms_DescripcionCta1, string Dms_DescripcionCta2, string Dms_Usuario, DateTime? Dms_FechaReal, string Dms_NombreTercero, Sinapsys.Datos.SQL datosTransaccion=null)
		{
			try 
			{
				AnticiposDms new_values = new AnticiposDms();
				new_values.Dms_Tipo = Dms_Tipo;
				new_values.Dms_Numero = Dms_Numero;
				new_values.Dms_Modelo = Dms_Modelo;
				new_values.Dms_Sw = Dms_Sw;
				new_values.Dms_Placa = Dms_Placa;
				new_values.Dms_lngIdRegistroViaje = Dms_lngIdRegistroViaje;
				new_values.Dms_lngIdRegistroViajeTramo = Dms_lngIdRegistroViajeTramo;
				new_values.Dms_Nit = Dms_Nit;
				new_values.Dms_Fecha = Dms_Fecha;
				new_values.Dms_ValorTotal = Dms_ValorTotal;
				new_values.Dms_ValorAplicado = Dms_ValorAplicado;
				new_values.Dms_ValorAnticipo = Dms_ValorAnticipo;
				new_values.Dms_Chk = Dms_Chk;
				new_values.Dms_Nota = Dms_Nota;
				new_values.Dms_Documento = Dms_Documento;
				new_values.Dms_CodBanco = Dms_CodBanco;
				new_values.Dms_NombreBanco = Dms_NombreBanco;
				new_values.Dms_DescripcionModelo = Dms_DescripcionModelo;
				new_values.Dms_Cuenta1 = Dms_Cuenta1;
				new_values.Dms_Cuenta2 = Dms_Cuenta2;
				new_values.Dms_DescripcionCta1 = Dms_DescripcionCta1;
				new_values.Dms_DescripcionCta2 = Dms_DescripcionCta2;
				new_values.Dms_Usuario = Dms_Usuario;
				new_values.Dms_FechaReal = Dms_FechaReal;
				new_values.Dms_NombreTercero = Dms_NombreTercero;
				AnticiposDmsDataProvider.Instance.Update(Dms_Codigo, Dms_Tipo, Dms_Numero, Dms_Modelo, Dms_Sw, Dms_Placa, Dms_lngIdRegistroViaje, Dms_lngIdRegistroViajeTramo, Dms_Nit, Dms_Fecha, Dms_ValorTotal, Dms_ValorAplicado, Dms_ValorAnticipo, Dms_Chk, Dms_Nota, Dms_Documento, Dms_CodBanco, Dms_NombreBanco, Dms_DescripcionModelo, Dms_Cuenta1, Dms_Cuenta2, Dms_DescripcionCta1, Dms_DescripcionCta2, Dms_Usuario, Dms_FechaReal, Dms_NombreTercero,"AnticiposDms",datosTransaccion);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Updates an AnticiposDms object by passing one object's instance as reference
		/// </summary>
		/// <param name="anticiposdms">An instance of AnticiposDms for reference</param>
		public void Update(AnticiposDms anticiposdms,Sinapsys.Datos.SQL datosTransaccion=null)
		{
			Update(anticiposdms.Dms_Codigo, anticiposdms.Dms_Tipo, anticiposdms.Dms_Numero, anticiposdms.Dms_Modelo, anticiposdms.Dms_Sw, anticiposdms.Dms_Placa, anticiposdms.Dms_lngIdRegistroViaje, anticiposdms.Dms_lngIdRegistroViajeTramo, anticiposdms.Dms_Nit, anticiposdms.Dms_Fecha, anticiposdms.Dms_ValorTotal, anticiposdms.Dms_ValorAplicado, anticiposdms.Dms_ValorAnticipo, anticiposdms.Dms_Chk, anticiposdms.Dms_Nota, anticiposdms.Dms_Documento, anticiposdms.Dms_CodBanco, anticiposdms.Dms_NombreBanco, anticiposdms.Dms_DescripcionModelo, anticiposdms.Dms_Cuenta1, anticiposdms.Dms_Cuenta2, anticiposdms.Dms_DescripcionCta1, anticiposdms.Dms_DescripcionCta2, anticiposdms.Dms_Usuario, anticiposdms.Dms_FechaReal, anticiposdms.Dms_NombreTercero);
		}

		/// <summary>
		/// Delete  the AnticiposDms object by passing a object
		/// </summary>
		public void  Delete(AnticiposDms anticiposdms, Sinapsys.Datos.SQL datosTransaccion=null)
		{
			Delete(anticiposdms.Dms_Codigo,datosTransaccion);
		}

		/// <summary>
		/// Deletes the AnticiposDms object by passing one object's instance as reference
		/// </summary>
		/// <param name="anticiposdms">An instance of AnticiposDms for reference</param>
		public void Delete(int Dms_Codigo, Sinapsys.Datos.SQL datosTransaccion=null)
		{
			try 
			{
				AnticiposDmsDataProvider.Instance.Delete(Dms_Codigo,"AnticiposDms");
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Deletes the AnticiposDms object by passing CVS parameter as reference
		/// </summary>
		/// <param name="anticiposdms">An instance of AnticiposDms for reference</param>
		public void Delete(string CVSParameter)
		{
			string[] StrCommand=CVSParameter.Split(',');
			try 
			{
				int Dms_Codigo=int.Parse(StrCommand[0]);
				AnticiposDmsDataProvider.Instance.Delete(Dms_Codigo,"AnticiposDms");
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Gets the AnticiposDms object by passing the object's key fields
		/// </summary>
		/// <param name="Dms_Codigo">int that contents the Dms_Codigo value for the AnticiposDms object</param>
		/// <returns>One AnticiposDms object</returns>
		public AnticiposDms Get(int Dms_Codigo, bool generateUndo=false)
		{
			try 
			{
				AnticiposDms anticiposdms = null;
				DataTable dt = AnticiposDmsDataProvider.Instance.Get(Dms_Codigo);
				if ((dt.Rows.Count > 0))
				{
					anticiposdms = new AnticiposDms();
					DataRow dr = dt.Rows[0];
					ReadData(anticiposdms, dr, generateUndo);
				}


				return anticiposdms;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Gets all objects of AnticiposDms
		/// </summary>
		/// <returns>One AnticiposDmsList object</returns>
		public AnticiposDmsList GetAll(bool generateUndo=false)
		{
			try 
			{
				AnticiposDmsList anticiposdmslist = new AnticiposDmsList();
				DataTable dt = AnticiposDmsDataProvider.Instance.GetAll();
				foreach (DataRow dr in dt.Rows)
				{
					AnticiposDms anticiposdms = new AnticiposDms();
					ReadData(anticiposdms, dr, generateUndo);
					anticiposdmslist.Add(anticiposdms);
				}
				return anticiposdmslist;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Gets all objects of AnticiposDms applying filter and sort criteria
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
		/// <returns>One AnticiposDmsList object</returns>
		public AnticiposDmsList GetFilter(int pagenum, int pagesize, string filter, string sort, string extablesfilter, string extablesfieldsfilter, string extablesrelationsfilter, string extablessort, string extablesfieldssort, string extablesrelationssort, bool generateUndo=false)
		{
			try 
			{
				AnticiposDmsList anticiposdmslist = new AnticiposDmsList();

				DataTable dt = AnticiposDmsDataProvider.Instance.GetFilter(pagenum, pagesize, filter, sort, extablesfilter, extablesfieldsfilter, extablesrelationsfilter, extablessort, extablesfieldssort, extablesrelationssort);

				foreach (DataRow dr in dt.Rows)
				{
					AnticiposDms anticiposdms = new AnticiposDms();
					ReadData(anticiposdms, dr, generateUndo);
					anticiposdmslist.Add(anticiposdms);
				}
				return anticiposdmslist;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public AnticiposDmsList GetFilter( string filter, string sort, bool generateUndo=false)
		{
			return GetFilter(0,0, filter, sort, "","","","","","",generateUndo);
		}

		public AnticiposDmsList GetFilter(string filter, string sort, string extablesfilter, string extablesfieldsfilter, string extablesrelationsfilter, string extablessort, string extablesfieldssort, string extablesrelationssort, bool generateUndo=false)
		{
			return GetFilter(0,0, filter, sort, extablesfilter, extablesfieldsfilter, extablesrelationsfilter, extablessort, extablesfieldssort, extablesrelationssort,generateUndo);
		}


		/// <summary>
		/// Returns the type for one property
		/// </summary>
		/// <param name="propertyname">Property's name for return its value</param>
		/// <returns>A value for the <paramref name="propertyname"/></returns>
		public Type GetMethodType( string propertyname,AnticiposDms anticiposdms)
		{
			// Perform the search for the property's value
			switch (propertyname)
			{
				case "Dms_Codigo":
					return anticiposdms.Dms_Codigo.GetType();

				case "Dms_Tipo":
					return anticiposdms.Dms_Tipo.GetType();

				case "Dms_Numero":
					return anticiposdms.Dms_Numero.GetType();

				case "Dms_Modelo":
					return anticiposdms.Dms_Modelo.GetType();

				case "Dms_Sw":
					return anticiposdms.Dms_Sw.GetType();

				case "Dms_Placa":
					return anticiposdms.Dms_Placa.GetType();

				case "Dms_lngIdRegistroViaje":
					return anticiposdms.Dms_lngIdRegistroViaje.GetType();

				case "Dms_lngIdRegistroViajeTramo":
					return anticiposdms.Dms_lngIdRegistroViajeTramo.GetType();

				case "Dms_Nit":
					return anticiposdms.Dms_Nit.GetType();

				case "Dms_Fecha":
					return anticiposdms.Dms_Fecha.GetType();

				case "Dms_ValorTotal":
					return anticiposdms.Dms_ValorTotal.GetType();

				case "Dms_ValorAplicado":
					return anticiposdms.Dms_ValorAplicado.GetType();

				case "Dms_ValorAnticipo":
					return anticiposdms.Dms_ValorAnticipo.GetType();

				case "Dms_Chk":
					return anticiposdms.Dms_Chk.GetType();

				case "Dms_Nota":
					return anticiposdms.Dms_Nota.GetType();

				case "Dms_Documento":
					return anticiposdms.Dms_Documento.GetType();

				case "Dms_CodBanco":
					return anticiposdms.Dms_CodBanco.GetType();

				case "Dms_NombreBanco":
					return anticiposdms.Dms_NombreBanco.GetType();

				case "Dms_DescripcionModelo":
					return anticiposdms.Dms_DescripcionModelo.GetType();

				case "Dms_Cuenta1":
					return anticiposdms.Dms_Cuenta1.GetType();

				case "Dms_Cuenta2":
					return anticiposdms.Dms_Cuenta2.GetType();

				case "Dms_DescripcionCta1":
					return anticiposdms.Dms_DescripcionCta1.GetType();

				case "Dms_DescripcionCta2":
					return anticiposdms.Dms_DescripcionCta2.GetType();

				case "Dms_Usuario":
					return anticiposdms.Dms_Usuario.GetType();

				case "Dms_FechaReal":
					return anticiposdms.Dms_FechaReal.GetType();

				case "Dms_NombreTercero":
					return anticiposdms.Dms_NombreTercero.GetType();

			}

			return null;
		}
		/// <summary>
		/// update the changes in AnticiposDms object by passing the object
		/// </summary>
		public bool UpdateChanges(AnticiposDms anticiposdms, out string error,Sinapsys.Datos.SQL datosTransaccion=null)
		{
			if (anticiposdms.OldAnticiposDms == null)
			{
				    error = "No tiene objeto con el cual comparar";
				    return false;
			}
			string[] Fields = anticiposdms.FieldChanged();
			error = "";
			return LiqViajes_Bll_Data.DataProvider.UpdateFieldsbyObject(Fields, anticiposdms, out error,datosTransaccion);
		}
	}

	#endregion

}
