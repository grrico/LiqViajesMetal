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
	#region TramosConsultaAnticiposController

	/// <summary>
	/// Class for convert data from database into object's data and vice versa
	/// </summary>
	public partial class TramosConsultaAnticiposController//: ILatinodeController
	{
		/// <summary>
		/// Generic Constructor
		/// </summary>
		public TramosConsultaAnticiposController()
		{
		}

		/// <summary>
		/// Instance accessor for this singleton
		/// </summary>
		private static TramosConsultaAnticiposController MySingleObj;
		public static TramosConsultaAnticiposController Instance
		{
			get
			{
				if (MySingleObj == null)
				{
					MySingleObj = new TramosConsultaAnticiposController();
				}
				return MySingleObj;
			}
		}

		// Reads object's data from a DataRow
		private void ReadData(TramosConsultaAnticipos tramosconsultaanticipos, DataRow dr,bool generateUndo=false)
		{
			try 
			{
				tramosconsultaanticipos.IdRegistroViajeTramo = dr.IsNull("IdRegistroViajeTramo") ? null :(long?) dr["IdRegistroViajeTramo"];
				tramosconsultaanticipos.Tipo = dr.IsNull("Tipo") ? null :(string) dr["Tipo"];
				tramosconsultaanticipos.Documento = dr.IsNull("Documento") ? null :(long?) dr["Documento"];
				tramosconsultaanticipos.NombreBanco = dr.IsNull("NombreBanco") ? null :(string) dr["NombreBanco"];
				tramosconsultaanticipos.ValorAnticipo = dr.IsNull("ValorAnticipo") ? null :(decimal?) dr["ValorAnticipo"];
				tramosconsultaanticipos.Fecha = dr.IsNull("Fecha") ? null :(DateTime?) dr["Fecha"];
				tramosconsultaanticipos.Codigo = (long) dr["Codigo"];
			}
			catch (Exception ex)
			{
				Utilidades.LogErrores(ex.Message + (ex.InnerException != null ? ex.InnerException.Message : ""), DataProvider.AplicacionNombre);
				throw ex;
			}
			if (generateUndo) tramosconsultaanticipos.GenerateUndo();
		}

		/// <summary>
		/// Create a new TramosConsultaAnticipos object by passing a object
		/// </summary>
		public TramosConsultaAnticipos Create(TramosConsultaAnticipos tramosconsultaanticipos, Sinapsys.Datos.SQL datosTransaccion=null)
		{
			return Create(tramosconsultaanticipos.Codigo,tramosconsultaanticipos.IdRegistroViajeTramo,tramosconsultaanticipos.Tipo,tramosconsultaanticipos.Documento,tramosconsultaanticipos.NombreBanco,tramosconsultaanticipos.ValorAnticipo,tramosconsultaanticipos.Fecha,datosTransaccion);
		}

		/// <summary>
		/// Creates a new TramosConsultaAnticipos object by passing all object's fields
		/// </summary>
		/// <param name="IdRegistroViajeTramo">long that contents the IdRegistroViajeTramo value for the TramosConsultaAnticipos object</param>
		/// <param name="Tipo">string that contents the Tipo value for the TramosConsultaAnticipos object</param>
		/// <param name="Documento">long that contents the Documento value for the TramosConsultaAnticipos object</param>
		/// <param name="NombreBanco">string that contents the NombreBanco value for the TramosConsultaAnticipos object</param>
		/// <param name="ValorAnticipo">decimal that contents the ValorAnticipo value for the TramosConsultaAnticipos object</param>
		/// <param name="Fecha">DateTime that contents the Fecha value for the TramosConsultaAnticipos object</param>
		/// <returns>One TramosConsultaAnticipos object</returns>
		public TramosConsultaAnticipos Create(long Codigo, long? IdRegistroViajeTramo, string Tipo, long? Documento, string NombreBanco, decimal? ValorAnticipo, DateTime? Fecha, Sinapsys.Datos.SQL datosTransaccion=null)
		{
			try 
			{
				TramosConsultaAnticipos tramosconsultaanticipos = new TramosConsultaAnticipos();

				tramosconsultaanticipos.Codigo = Codigo;
				tramosconsultaanticipos.Codigo = Codigo;
				tramosconsultaanticipos.IdRegistroViajeTramo = IdRegistroViajeTramo;
				tramosconsultaanticipos.Tipo = Tipo;
				tramosconsultaanticipos.Documento = Documento;
				tramosconsultaanticipos.NombreBanco = NombreBanco;
				tramosconsultaanticipos.ValorAnticipo = ValorAnticipo;
				tramosconsultaanticipos.Fecha = Fecha;
				Codigo = TramosConsultaAnticiposDataProvider.Instance.Create(Codigo, IdRegistroViajeTramo, Tipo, Documento, NombreBanco, ValorAnticipo, Fecha,"TramosConsultaAnticipos",datosTransaccion);
				if (Codigo == 0)
					return null;

				tramosconsultaanticipos.Codigo = Codigo;

				return tramosconsultaanticipos;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Updates an TramosConsultaAnticipos object by passing all object's fields
		/// </summary>
		/// <param name="IdRegistroViajeTramo">long that contents the IdRegistroViajeTramo value for the TramosConsultaAnticipos object</param>
		/// <param name="Tipo">string that contents the Tipo value for the TramosConsultaAnticipos object</param>
		/// <param name="Documento">long that contents the Documento value for the TramosConsultaAnticipos object</param>
		/// <param name="NombreBanco">string that contents the NombreBanco value for the TramosConsultaAnticipos object</param>
		/// <param name="ValorAnticipo">decimal that contents the ValorAnticipo value for the TramosConsultaAnticipos object</param>
		/// <param name="Fecha">DateTime that contents the Fecha value for the TramosConsultaAnticipos object</param>
		/// <param name="Codigo">long that contents the Codigo value for the TramosConsultaAnticipos object</param>
		public void Update(long? IdRegistroViajeTramo, string Tipo, long? Documento, string NombreBanco, decimal? ValorAnticipo, DateTime? Fecha, long Codigo, Sinapsys.Datos.SQL datosTransaccion=null)
		{
			try 
			{
				TramosConsultaAnticipos new_values = new TramosConsultaAnticipos();
				new_values.IdRegistroViajeTramo = IdRegistroViajeTramo;
				new_values.Tipo = Tipo;
				new_values.Documento = Documento;
				new_values.NombreBanco = NombreBanco;
				new_values.ValorAnticipo = ValorAnticipo;
				new_values.Fecha = Fecha;
				TramosConsultaAnticiposDataProvider.Instance.Update(IdRegistroViajeTramo, Tipo, Documento, NombreBanco, ValorAnticipo, Fecha, Codigo,"TramosConsultaAnticipos",datosTransaccion);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Updates an TramosConsultaAnticipos object by passing one object's instance as reference
		/// </summary>
		/// <param name="tramosconsultaanticipos">An instance of TramosConsultaAnticipos for reference</param>
		public void Update(TramosConsultaAnticipos tramosconsultaanticipos,Sinapsys.Datos.SQL datosTransaccion=null)
		{
			Update(tramosconsultaanticipos.IdRegistroViajeTramo, tramosconsultaanticipos.Tipo, tramosconsultaanticipos.Documento, tramosconsultaanticipos.NombreBanco, tramosconsultaanticipos.ValorAnticipo, tramosconsultaanticipos.Fecha, tramosconsultaanticipos.Codigo);
		}

		/// <summary>
		/// Delete  the TramosConsultaAnticipos object by passing a object
		/// </summary>
		public void  Delete(TramosConsultaAnticipos tramosconsultaanticipos, Sinapsys.Datos.SQL datosTransaccion=null)
		{
			Delete(tramosconsultaanticipos.Codigo,datosTransaccion);
		}

		/// <summary>
		/// Deletes the TramosConsultaAnticipos object by passing one object's instance as reference
		/// </summary>
		/// <param name="tramosconsultaanticipos">An instance of TramosConsultaAnticipos for reference</param>
		public void Delete(long Codigo, Sinapsys.Datos.SQL datosTransaccion=null)
		{
			try 
			{
				//TramosConsultaAnticipos old_values = TramosConsultaAnticiposController.Instance.Get(Codigo);
				//if(!Validate.security.CanDeleteSecurityField(TramosConsultaAnticiposController.Instance, (ILatinodeObject)old_values))
				//    throw new Exception("Access denied by security field, you can't delete object");

				TramosConsultaAnticiposDataProvider.Instance.Delete(Codigo,"TramosConsultaAnticipos");
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Deletes the TramosConsultaAnticipos object by passing CVS parameter as reference
		/// </summary>
		/// <param name="tramosconsultaanticipos">An instance of TramosConsultaAnticipos for reference</param>
		public void Delete(string CVSParameter)
		{
			string[] StrCommand=CVSParameter.Split(',');
			try 
			{
				long Codigo=long.Parse(StrCommand[0]);
				TramosConsultaAnticiposDataProvider.Instance.Delete(Codigo,"TramosConsultaAnticipos");
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Gets the TramosConsultaAnticipos object by passing the object's key fields
		/// </summary>
		/// <param name="Codigo">long that contents the Codigo value for the TramosConsultaAnticipos object</param>
		/// <returns>One TramosConsultaAnticipos object</returns>
		public TramosConsultaAnticipos Get(long Codigo, bool generateUndo=false)
		{
			try 
			{
				TramosConsultaAnticipos tramosconsultaanticipos = null;
				DataTable dt = TramosConsultaAnticiposDataProvider.Instance.Get(Codigo);
				if ((dt.Rows.Count > 0))
				{
					tramosconsultaanticipos = new TramosConsultaAnticipos();
					DataRow dr = dt.Rows[0];
					ReadData(tramosconsultaanticipos, dr, generateUndo);
				}


				return tramosconsultaanticipos;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Gets all objects of TramosConsultaAnticipos
		/// </summary>
		/// <returns>One TramosConsultaAnticiposList object</returns>
		public TramosConsultaAnticiposList GetAll(bool generateUndo=false)
		{
			try 
			{
				TramosConsultaAnticiposList tramosconsultaanticiposlist = new TramosConsultaAnticiposList();
				DataTable dt = TramosConsultaAnticiposDataProvider.Instance.GetAll();
				foreach (DataRow dr in dt.Rows)
				{
					TramosConsultaAnticipos tramosconsultaanticipos = new TramosConsultaAnticipos();
					ReadData(tramosconsultaanticipos, dr, generateUndo);
					tramosconsultaanticiposlist.Add(tramosconsultaanticipos);
				}
				return tramosconsultaanticiposlist;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Gets all objects of TramosConsultaAnticipos applying filter and sort criteria
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
		/// <returns>One TramosConsultaAnticiposList object</returns>
		public TramosConsultaAnticiposList GetFilter(int pagenum, int pagesize, string filter, string sort, string extablesfilter, string extablesfieldsfilter, string extablesrelationsfilter, string extablessort, string extablesfieldssort, string extablesrelationssort, bool generateUndo=false)
		{
			try 
			{
				TramosConsultaAnticiposList tramosconsultaanticiposlist = new TramosConsultaAnticiposList();

				DataTable dt = TramosConsultaAnticiposDataProvider.Instance.GetFilter(pagenum, pagesize, filter, sort, extablesfilter, extablesfieldsfilter, extablesrelationsfilter, extablessort, extablesfieldssort, extablesrelationssort);

				foreach (DataRow dr in dt.Rows)
				{
					TramosConsultaAnticipos tramosconsultaanticipos = new TramosConsultaAnticipos();
					ReadData(tramosconsultaanticipos, dr, generateUndo);
					tramosconsultaanticiposlist.Add(tramosconsultaanticipos);
				}
				return tramosconsultaanticiposlist;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public TramosConsultaAnticiposList GetFilter( string filter, string sort, bool generateUndo=false)
		{
			return GetFilter(0,0, filter, sort, "","","","","","",generateUndo);
		}

		public TramosConsultaAnticiposList GetFilter(string filter, string sort, string extablesfilter, string extablesfieldsfilter, string extablesrelationsfilter, string extablessort, string extablesfieldssort, string extablesrelationssort, bool generateUndo=false)
		{
			return GetFilter(0,0, filter, sort, extablesfilter, extablesfieldsfilter, extablesrelationsfilter, extablessort, extablesfieldssort, extablesrelationssort,generateUndo);
		}


		/// <summary>
		/// Returns the type for one property
		/// </summary>
		/// <param name="propertyname">Property's name for return its value</param>
		/// <returns>A value for the <paramref name="propertyname"/></returns>
		public Type GetMethodType( string propertyname,TramosConsultaAnticipos tramosconsultaanticipos)
		{
			// Perform the search for the property's value
			switch (propertyname)
			{
				case "IdRegistroViajeTramo":
					return tramosconsultaanticipos.IdRegistroViajeTramo.GetType();

				case "Tipo":
					return tramosconsultaanticipos.Tipo.GetType();

				case "Documento":
					return tramosconsultaanticipos.Documento.GetType();

				case "NombreBanco":
					return tramosconsultaanticipos.NombreBanco.GetType();

				case "ValorAnticipo":
					return tramosconsultaanticipos.ValorAnticipo.GetType();

				case "Fecha":
					return tramosconsultaanticipos.Fecha.GetType();

				case "Codigo":
					return tramosconsultaanticipos.Codigo.GetType();

			}

			return null;
		}
		/// <summary>
		/// update the changes in TramosConsultaAnticipos object by passing the object
		/// </summary>
		public bool UpdateChanges(TramosConsultaAnticipos tramosconsultaanticipos, out string error,Sinapsys.Datos.SQL datosTransaccion=null)
		{
			if (tramosconsultaanticipos.OldTramosConsultaAnticipos == null)
			{
				    error = "No tiene objeto con el cual comparar";
				    return false;
			}
			string[] Fields = tramosconsultaanticipos.FieldChanged();
			error = "";
			return LiqViajes_Bll_Data.DataProvider.UpdateFieldsbyObject(Fields, tramosconsultaanticipos, out error,datosTransaccion);
		}
	}

	#endregion

}
