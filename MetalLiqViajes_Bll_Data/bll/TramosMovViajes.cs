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
	#region TramosMovViajesController

	/// <summary>
	/// Class for convert data from database into object's data and vice versa
	/// </summary>
	public partial class TramosMovViajesController//: ILatinodeController
	{
		/// <summary>
		/// Generic Constructor
		/// </summary>
		public TramosMovViajesController()
		{
		}

		/// <summary>
		/// Instance accessor for this singleton
		/// </summary>
		private static TramosMovViajesController MySingleObj;
		public static TramosMovViajesController Instance
		{
			get
			{
				if (MySingleObj == null)
				{
					MySingleObj = new TramosMovViajesController();
				}
				return MySingleObj;
			}
		}

		// Reads object's data from a DataRow
		private void ReadData(TramosMovViajes tramosmovviajes, DataRow dr,bool generateUndo=false)
		{
			try 
			{
				tramosmovviajes.Codigo = (long) dr["Codigo"];
				tramosmovviajes.IdRegistro = dr.IsNull("IdRegistro") ? null :(long?) dr["IdRegistro"];
				tramosmovviajes.Cedula = dr.IsNull("Cedula") ? null :(string) dr["Cedula"];
				tramosmovviajes.NombreConductor = dr.IsNull("NombreConductor") ? null :(string) dr["NombreConductor"];
				tramosmovviajes.Cuenta = dr.IsNull("Cuenta") ? null :(string) dr["Cuenta"];
				tramosmovviajes.DescripcionCuenta = dr.IsNull("DescripcionCuenta") ? null :(string) dr["DescripcionCuenta"];
				tramosmovviajes.ValorTotal = dr.IsNull("ValorTotal") ? null :(decimal?) dr["ValorTotal"];
				tramosmovviajes.Fecha = dr.IsNull("Fecha") ? null :(DateTime?) dr["Fecha"];
				tramosmovviajes.DescripcionPeaje = dr.IsNull("DescripcionPeaje") ? null :(string) dr["DescripcionPeaje"];
			}
			catch (Exception ex)
			{
				Utilidades.LogErrores(ex.Message + (ex.InnerException != null ? ex.InnerException.Message : ""), DataProvider.AplicacionNombre);
				throw ex;
			}
			if (generateUndo) tramosmovviajes.GenerateUndo();
		}

		/// <summary>
		/// Create a new TramosMovViajes object by passing a object
		/// </summary>
		public TramosMovViajes Create(TramosMovViajes tramosmovviajes, Sinapsys.Datos.SQL datosTransaccion=null)
		{
			return Create(tramosmovviajes.Codigo,tramosmovviajes.IdRegistro,tramosmovviajes.Cedula,tramosmovviajes.NombreConductor,tramosmovviajes.Cuenta,tramosmovviajes.DescripcionCuenta,tramosmovviajes.ValorTotal,tramosmovviajes.Fecha,tramosmovviajes.DescripcionPeaje,datosTransaccion);
		}

		/// <summary>
		/// Creates a new TramosMovViajes object by passing all object's fields
		/// </summary>
		/// <param name="IdRegistro">long that contents the IdRegistro value for the TramosMovViajes object</param>
		/// <param name="Cedula">string that contents the Cedula value for the TramosMovViajes object</param>
		/// <param name="NombreConductor">string that contents the NombreConductor value for the TramosMovViajes object</param>
		/// <param name="Cuenta">string that contents the Cuenta value for the TramosMovViajes object</param>
		/// <param name="DescripcionCuenta">string that contents the DescripcionCuenta value for the TramosMovViajes object</param>
		/// <param name="ValorTotal">decimal that contents the ValorTotal value for the TramosMovViajes object</param>
		/// <param name="Fecha">DateTime that contents the Fecha value for the TramosMovViajes object</param>
		/// <param name="DescripcionPeaje">string that contents the DescripcionPeaje value for the TramosMovViajes object</param>
		/// <returns>One TramosMovViajes object</returns>
		public TramosMovViajes Create(long Codigo, long? IdRegistro, string Cedula, string NombreConductor, string Cuenta, string DescripcionCuenta, decimal? ValorTotal, DateTime? Fecha, string DescripcionPeaje, Sinapsys.Datos.SQL datosTransaccion=null)
		{
			try 
			{
				TramosMovViajes tramosmovviajes = new TramosMovViajes();

				tramosmovviajes.Codigo = Codigo;
				tramosmovviajes.IdRegistro = IdRegistro;
				tramosmovviajes.Cedula = Cedula;
				tramosmovviajes.NombreConductor = NombreConductor;
				tramosmovviajes.Cuenta = Cuenta;
				tramosmovviajes.DescripcionCuenta = DescripcionCuenta;
				tramosmovviajes.ValorTotal = ValorTotal;
				tramosmovviajes.Fecha = Fecha;
				tramosmovviajes.DescripcionPeaje = DescripcionPeaje;
				TramosMovViajesDataProvider.Instance.Create(Codigo, IdRegistro, Cedula, NombreConductor, Cuenta, DescripcionCuenta, ValorTotal, Fecha, DescripcionPeaje,"TramosMovViajes");

				return tramosmovviajes;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Updates an TramosMovViajes object by passing all object's fields
		/// </summary>
		/// <param name="Codigo">long that contents the Codigo value for the TramosMovViajes object</param>
		/// <param name="IdRegistro">long that contents the IdRegistro value for the TramosMovViajes object</param>
		/// <param name="Cedula">string that contents the Cedula value for the TramosMovViajes object</param>
		/// <param name="NombreConductor">string that contents the NombreConductor value for the TramosMovViajes object</param>
		/// <param name="Cuenta">string that contents the Cuenta value for the TramosMovViajes object</param>
		/// <param name="DescripcionCuenta">string that contents the DescripcionCuenta value for the TramosMovViajes object</param>
		/// <param name="ValorTotal">decimal that contents the ValorTotal value for the TramosMovViajes object</param>
		/// <param name="Fecha">DateTime that contents the Fecha value for the TramosMovViajes object</param>
		/// <param name="DescripcionPeaje">string that contents the DescripcionPeaje value for the TramosMovViajes object</param>
		public void Update(long Codigo, long? IdRegistro, string Cedula, string NombreConductor, string Cuenta, string DescripcionCuenta, decimal? ValorTotal, DateTime? Fecha, string DescripcionPeaje, Sinapsys.Datos.SQL datosTransaccion=null)
		{
			try 
			{
				TramosMovViajes new_values = new TramosMovViajes();
				new_values.IdRegistro = IdRegistro;
				new_values.Cedula = Cedula;
				new_values.NombreConductor = NombreConductor;
				new_values.Cuenta = Cuenta;
				new_values.DescripcionCuenta = DescripcionCuenta;
				new_values.ValorTotal = ValorTotal;
				new_values.Fecha = Fecha;
				new_values.DescripcionPeaje = DescripcionPeaje;
				TramosMovViajesDataProvider.Instance.Update(Codigo, IdRegistro, Cedula, NombreConductor, Cuenta, DescripcionCuenta, ValorTotal, Fecha, DescripcionPeaje,"TramosMovViajes",datosTransaccion);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Updates an TramosMovViajes object by passing one object's instance as reference
		/// </summary>
		/// <param name="tramosmovviajes">An instance of TramosMovViajes for reference</param>
		public void Update(TramosMovViajes tramosmovviajes,Sinapsys.Datos.SQL datosTransaccion=null)
		{
			Update(tramosmovviajes.Codigo, tramosmovviajes.IdRegistro, tramosmovviajes.Cedula, tramosmovviajes.NombreConductor, tramosmovviajes.Cuenta, tramosmovviajes.DescripcionCuenta, tramosmovviajes.ValorTotal, tramosmovviajes.Fecha, tramosmovviajes.DescripcionPeaje);
		}

		/// <summary>
		/// Delete  the TramosMovViajes object by passing a object
		/// </summary>
		public void  Delete(TramosMovViajes tramosmovviajes, Sinapsys.Datos.SQL datosTransaccion=null)
		{
			Delete(tramosmovviajes.Codigo,datosTransaccion);
		}

		/// <summary>
		/// Deletes the TramosMovViajes object by passing one object's instance as reference
		/// </summary>
		/// <param name="tramosmovviajes">An instance of TramosMovViajes for reference</param>
		public void Delete(long Codigo, Sinapsys.Datos.SQL datosTransaccion=null)
		{
			try 
			{
				TramosMovViajesDataProvider.Instance.Delete(Codigo,"TramosMovViajes");
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Deletes the TramosMovViajes object by passing CVS parameter as reference
		/// </summary>
		/// <param name="tramosmovviajes">An instance of TramosMovViajes for reference</param>
		public void Delete(string CVSParameter)
		{
			string[] StrCommand=CVSParameter.Split(',');
			try 
			{
				long Codigo=long.Parse(StrCommand[0]);
				TramosMovViajesDataProvider.Instance.Delete(Codigo,"TramosMovViajes");
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Gets the TramosMovViajes object by passing the object's key fields
		/// </summary>
		/// <param name="Codigo">long that contents the Codigo value for the TramosMovViajes object</param>
		/// <returns>One TramosMovViajes object</returns>
		public TramosMovViajes Get(long Codigo, bool generateUndo=false)
		{
			try 
			{
				TramosMovViajes tramosmovviajes = null;
				DataTable dt = TramosMovViajesDataProvider.Instance.Get(Codigo);
				if ((dt.Rows.Count > 0))
				{
					tramosmovviajes = new TramosMovViajes();
					DataRow dr = dt.Rows[0];
					ReadData(tramosmovviajes, dr, generateUndo);
				}


				return tramosmovviajes;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Gets all objects of TramosMovViajes
		/// </summary>
		/// <returns>One TramosMovViajesList object</returns>
		public TramosMovViajesList GetAll(bool generateUndo=false)
		{
			try 
			{
				TramosMovViajesList tramosmovviajeslist = new TramosMovViajesList();
				DataTable dt = TramosMovViajesDataProvider.Instance.GetAll();
				foreach (DataRow dr in dt.Rows)
				{
					TramosMovViajes tramosmovviajes = new TramosMovViajes();
					ReadData(tramosmovviajes, dr, generateUndo);
					tramosmovviajeslist.Add(tramosmovviajes);
				}
				return tramosmovviajeslist;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Gets all objects of TramosMovViajes applying filter and sort criteria
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
		/// <returns>One TramosMovViajesList object</returns>
		public TramosMovViajesList GetFilter(int pagenum, int pagesize, string filter, string sort, string extablesfilter, string extablesfieldsfilter, string extablesrelationsfilter, string extablessort, string extablesfieldssort, string extablesrelationssort, bool generateUndo=false)
		{
			try 
			{
				TramosMovViajesList tramosmovviajeslist = new TramosMovViajesList();

				DataTable dt = TramosMovViajesDataProvider.Instance.GetFilter(pagenum, pagesize, filter, sort, extablesfilter, extablesfieldsfilter, extablesrelationsfilter, extablessort, extablesfieldssort, extablesrelationssort);

				foreach (DataRow dr in dt.Rows)
				{
					TramosMovViajes tramosmovviajes = new TramosMovViajes();
					ReadData(tramosmovviajes, dr, generateUndo);
					tramosmovviajeslist.Add(tramosmovviajes);
				}
				return tramosmovviajeslist;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public TramosMovViajesList GetFilter( string filter, string sort, bool generateUndo=false)
		{
			return GetFilter(0,0, filter, sort, "","","","","","",generateUndo);
		}

		public TramosMovViajesList GetFilter(string filter, string sort, string extablesfilter, string extablesfieldsfilter, string extablesrelationsfilter, string extablessort, string extablesfieldssort, string extablesrelationssort, bool generateUndo=false)
		{
			return GetFilter(0,0, filter, sort, extablesfilter, extablesfieldsfilter, extablesrelationsfilter, extablessort, extablesfieldssort, extablesrelationssort,generateUndo);
		}


		/// <summary>
		/// Returns the type for one property
		/// </summary>
		/// <param name="propertyname">Property's name for return its value</param>
		/// <returns>A value for the <paramref name="propertyname"/></returns>
		public Type GetMethodType( string propertyname,TramosMovViajes tramosmovviajes)
		{
			// Perform the search for the property's value
			switch (propertyname)
			{
				case "Codigo":
					return tramosmovviajes.Codigo.GetType();

				case "IdRegistro":
					return tramosmovviajes.IdRegistro.GetType();

				case "Cedula":
					return tramosmovviajes.Cedula.GetType();

				case "NombreConductor":
					return tramosmovviajes.NombreConductor.GetType();

				case "Cuenta":
					return tramosmovviajes.Cuenta.GetType();

				case "DescripcionCuenta":
					return tramosmovviajes.DescripcionCuenta.GetType();

				case "ValorTotal":
					return tramosmovviajes.ValorTotal.GetType();

				case "Fecha":
					return tramosmovviajes.Fecha.GetType();

				case "DescripcionPeaje":
					return tramosmovviajes.DescripcionPeaje.GetType();

			}

			return null;
		}
		/// <summary>
		/// update the changes in TramosMovViajes object by passing the object
		/// </summary>
		public bool UpdateChanges(TramosMovViajes tramosmovviajes, out string error,Sinapsys.Datos.SQL datosTransaccion=null)
		{
			if (tramosmovviajes.OldTramosMovViajes == null)
			{
				    error = "No tiene objeto con el cual comparar";
				    return false;
			}
			string[] Fields = tramosmovviajes.FieldChanged();
			error = "";
			return LiqViajes_Bll_Data.DataProvider.UpdateFieldsbyObject(Fields, tramosmovviajes, out error,datosTransaccion);
		}
	}

	#endregion

}
