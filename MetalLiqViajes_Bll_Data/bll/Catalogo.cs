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
	#region CatalogoController

	/// <summary>
	/// Class for convert data from database into object's data and vice versa
	/// </summary>
	public partial class CatalogoController//: ILatinodeController
	{
		/// <summary>
		/// Generic Constructor
		/// </summary>
		public CatalogoController()
		{
		}

		/// <summary>
		/// Instance accessor for this singleton
		/// </summary>
		private static CatalogoController MySingleObj;
		public static CatalogoController Instance
		{
			get
			{
				if (MySingleObj == null)
				{
					MySingleObj = new CatalogoController();
				}
				return MySingleObj;
			}
		}

		// Reads object's data from a DataRow
		private void ReadData(Catalogo catalogo, DataRow dr,bool generateUndo=false)
		{
			try 
			{
				catalogo.nombre_empresa = (string) dr["nombre_empresa"];
				catalogo.fecha_actual = (DateTime) dr["fecha_actual"];
				catalogo.sigla = (string) dr["sigla"];
				catalogo.nit = (int) dr["nit"];
				catalogo.version = (int) dr["version"];
				catalogo.direccion = (string) dr["direccion"];
				catalogo.telefono = (string) dr["telefono"];
			}
			catch (Exception ex)
			{
				Utilidades.LogErrores(ex.Message + (ex.InnerException != null ? ex.InnerException.Message : ""), DataProvider.AplicacionNombre);
				throw ex;
			}
			if (generateUndo) catalogo.GenerateUndo();
		}

		/// <summary>
		/// Create a new Catalogo object by passing a object
		/// </summary>
		public Catalogo Create(Catalogo catalogo, Sinapsys.Datos.SQL datosTransaccion=null)
		{
			return Create(catalogo.nombre_empresa,catalogo.fecha_actual,catalogo.sigla,catalogo.nit,catalogo.version,catalogo.direccion,catalogo.telefono,datosTransaccion);
		}

		/// <summary>
		/// Creates a new Catalogo object by passing all object's fields
		/// </summary>
		/// <param name="fecha_actual">DateTime that contents the fecha_actual value for the Catalogo object</param>
		/// <param name="sigla">string that contents the sigla value for the Catalogo object</param>
		/// <param name="nit">int that contents the nit value for the Catalogo object</param>
		/// <param name="version">int that contents the version value for the Catalogo object</param>
		/// <param name="direccion">string that contents the direccion value for the Catalogo object</param>
		/// <param name="telefono">string that contents the telefono value for the Catalogo object</param>
		/// <returns>One Catalogo object</returns>
		public Catalogo Create(string nombre_empresa, DateTime fecha_actual, string sigla, int nit, int version, string direccion, string telefono, Sinapsys.Datos.SQL datosTransaccion=null)
		{
			try 
			{
				Catalogo catalogo = new Catalogo();

				catalogo.nombre_empresa = nombre_empresa;
				catalogo.fecha_actual = fecha_actual;
				catalogo.sigla = sigla;
				catalogo.nit = nit;
				catalogo.version = version;
				catalogo.direccion = direccion;
				catalogo.telefono = telefono;
				CatalogoDataProvider.Instance.Create(nombre_empresa, fecha_actual, sigla, nit, version, direccion, telefono,"Catalogo");

				return catalogo;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Updates an Catalogo object by passing all object's fields
		/// </summary>
		/// <param name="nombre_empresa">string that contents the nombre_empresa value for the Catalogo object</param>
		/// <param name="fecha_actual">DateTime that contents the fecha_actual value for the Catalogo object</param>
		/// <param name="sigla">string that contents the sigla value for the Catalogo object</param>
		/// <param name="nit">int that contents the nit value for the Catalogo object</param>
		/// <param name="version">int that contents the version value for the Catalogo object</param>
		/// <param name="direccion">string that contents the direccion value for the Catalogo object</param>
		/// <param name="telefono">string that contents the telefono value for the Catalogo object</param>
		public void Update(string nombre_empresa, DateTime fecha_actual, string sigla, int nit, int version, string direccion, string telefono, Sinapsys.Datos.SQL datosTransaccion=null)
		{
			try 
			{
				Catalogo new_values = new Catalogo();
				new_values.fecha_actual = fecha_actual;
				new_values.sigla = sigla;
				new_values.nit = nit;
				new_values.version = version;
				new_values.direccion = direccion;
				new_values.telefono = telefono;
				CatalogoDataProvider.Instance.Update(nombre_empresa, fecha_actual, sigla, nit, version, direccion, telefono,"Catalogo",datosTransaccion);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Updates an Catalogo object by passing one object's instance as reference
		/// </summary>
		/// <param name="catalogo">An instance of Catalogo for reference</param>
		public void Update(Catalogo catalogo,Sinapsys.Datos.SQL datosTransaccion=null)
		{
			Update(catalogo.nombre_empresa, catalogo.fecha_actual, catalogo.sigla, catalogo.nit, catalogo.version, catalogo.direccion, catalogo.telefono);
		}

		/// <summary>
		/// Delete  the Catalogo object by passing a object
		/// </summary>
		public void  Delete(Catalogo catalogo, Sinapsys.Datos.SQL datosTransaccion=null)
		{
			Delete(catalogo.nombre_empresa,datosTransaccion);
		}

		/// <summary>
		/// Deletes the Catalogo object by passing one object's instance as reference
		/// </summary>
		/// <param name="catalogo">An instance of Catalogo for reference</param>
		public void Delete(string nombre_empresa, Sinapsys.Datos.SQL datosTransaccion=null)
		{
			try 
			{
				CatalogoDataProvider.Instance.Delete(nombre_empresa,"Catalogo");
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Gets the Catalogo object by passing the object's key fields
		/// </summary>
		/// <param name="nombre_empresa">string that contents the nombre_empresa value for the Catalogo object</param>
		/// <returns>One Catalogo object</returns>
		public Catalogo Get(string nombre_empresa, bool generateUndo=false)
		{
			try 
			{
				Catalogo catalogo = null;
				DataTable dt = CatalogoDataProvider.Instance.Get(nombre_empresa);
				if ((dt.Rows.Count > 0))
				{
					catalogo = new Catalogo();
					DataRow dr = dt.Rows[0];
					ReadData(catalogo, dr, generateUndo);
				}


				return catalogo;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Gets all objects of Catalogo
		/// </summary>
		/// <returns>One CatalogoList object</returns>
		public CatalogoList GetAll(bool generateUndo=false)
		{
			try 
			{
				CatalogoList catalogolist = new CatalogoList();
				DataTable dt = CatalogoDataProvider.Instance.GetAll();
				foreach (DataRow dr in dt.Rows)
				{
					Catalogo catalogo = new Catalogo();
					ReadData(catalogo, dr, generateUndo);
					catalogolist.Add(catalogo);
				}
				return catalogolist;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Gets all objects of Catalogo applying filter and sort criteria
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
		/// <returns>One CatalogoList object</returns>
		public CatalogoList GetFilter(int pagenum, int pagesize, string filter, string sort, string extablesfilter, string extablesfieldsfilter, string extablesrelationsfilter, string extablessort, string extablesfieldssort, string extablesrelationssort, bool generateUndo=false)
		{
			try 
			{
				CatalogoList catalogolist = new CatalogoList();

				DataTable dt = CatalogoDataProvider.Instance.GetFilter(pagenum, pagesize, filter, sort, extablesfilter, extablesfieldsfilter, extablesrelationsfilter, extablessort, extablesfieldssort, extablesrelationssort);

				foreach (DataRow dr in dt.Rows)
				{
					Catalogo catalogo = new Catalogo();
					ReadData(catalogo, dr, generateUndo);
					catalogolist.Add(catalogo);
				}
				return catalogolist;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public CatalogoList GetFilter( string filter, string sort, bool generateUndo=false)
		{
			return GetFilter(0,0, filter, sort, "","","","","","",generateUndo);
		}

		public CatalogoList GetFilter(string filter, string sort, string extablesfilter, string extablesfieldsfilter, string extablesrelationsfilter, string extablessort, string extablesfieldssort, string extablesrelationssort, bool generateUndo=false)
		{
			return GetFilter(0,0, filter, sort, extablesfilter, extablesfieldsfilter, extablesrelationsfilter, extablessort, extablesfieldssort, extablesrelationssort,generateUndo);
		}


		/// <summary>
		/// Returns the type for one property
		/// </summary>
		/// <param name="propertyname">Property's name for return its value</param>
		/// <returns>A value for the <paramref name="propertyname"/></returns>
		public Type GetMethodType( string propertyname,Catalogo catalogo)
		{
			// Perform the search for the property's value
			switch (propertyname)
			{
				case "nombre_empresa":
					return catalogo.nombre_empresa.GetType();

				case "fecha_actual":
					return catalogo.fecha_actual.GetType();

				case "sigla":
					return catalogo.sigla.GetType();

				case "nit":
					return catalogo.nit.GetType();

				case "version":
					return catalogo.version.GetType();

				case "direccion":
					return catalogo.direccion.GetType();

				case "telefono":
					return catalogo.telefono.GetType();

			}

			return null;
		}
		/// <summary>
		/// update the changes in Catalogo object by passing the object
		/// </summary>
		public bool UpdateChanges(Catalogo catalogo, out string error,Sinapsys.Datos.SQL datosTransaccion=null)
		{
			if (catalogo.OldCatalogo == null)
			{
				    error = "No tiene objeto con el cual comparar";
				    return false;
			}
			string[] Fields = catalogo.FieldChanged();
			error = "";
			return LiqViajes_Bll_Data.DataProvider.UpdateFieldsbyObject(Fields, catalogo, out error,datosTransaccion);
		}
	}

	#endregion

}
