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
	#region TareasController

	/// <summary>
	/// Class for convert data from database into object's data and vice versa
	/// </summary>
	public partial class TareasController//: ILatinodeController
	{
		/// <summary>
		/// Generic Constructor
		/// </summary>
		public TareasController()
		{
		}

		/// <summary>
		/// Instance accessor for this singleton
		/// </summary>
		private static TareasController MySingleObj;
		public static TareasController Instance
		{
			get
			{
				if (MySingleObj == null)
				{
					MySingleObj = new TareasController();
				}
				return MySingleObj;
			}
		}

		// Reads object's data from a DataRow
		private void ReadData(Tareas tareas, DataRow dr,bool generateUndo=false)
		{
			try 
			{
				tareas.strAsunto = dr.IsNull("strAsunto") ? null :(string) dr["strAsunto"];
				tareas.dtmFechaInicio = dr.IsNull("dtmFechaInicio") ? null :(DateTime?) dr["dtmFechaInicio"];
				tareas.strFechavencimiento = dr.IsNull("strFechavencimiento") ? null :(DateTime?) dr["strFechavencimiento"];
				tareas.logAvisa = dr.IsNull("logAvisa") ? null :(bool?) dr["logAvisa"];
				tareas.FechaAviso = dr.IsNull("FechaAviso") ? null :(DateTime?) dr["FechaAviso"];
				tareas.Fechadefinalización = dr.IsNull("Fechadefinalización") ? null :(DateTime?) dr["Fechadefinalización"];
				tareas.logFinalizada = dr.IsNull("logFinalizada") ? null :(bool?) dr["logFinalizada"];
				tareas.Notas = dr.IsNull("Notas") ? null :(string) dr["Notas"];
				tareas.lngIdStatus = dr.IsNull("lngIdStatus") ? null :(int?) dr["lngIdStatus"];
				tareas.lngIdTarea = (int) dr["lngIdTarea"];
			}
			catch (Exception ex)
			{
				Utilidades.LogErrores(ex.Message + (ex.InnerException != null ? ex.InnerException.Message : ""), DataProvider.AplicacionNombre);
				throw ex;
			}
			if (generateUndo) tareas.GenerateUndo();
		}

		/// <summary>
		/// Create a new Tareas object by passing a object
		/// </summary>
		public Tareas Create(Tareas tareas, Sinapsys.Datos.SQL datosTransaccion=null)
		{
			return Create(tareas.lngIdTarea,tareas.strAsunto,tareas.dtmFechaInicio,tareas.strFechavencimiento,tareas.logAvisa,tareas.FechaAviso,tareas.Fechadefinalización,tareas.logFinalizada,tareas.Notas,tareas.lngIdStatus,datosTransaccion);
		}

		/// <summary>
		/// Creates a new Tareas object by passing all object's fields
		/// </summary>
		/// <param name="strAsunto">string that contents the strAsunto value for the Tareas object</param>
		/// <param name="dtmFechaInicio">DateTime that contents the dtmFechaInicio value for the Tareas object</param>
		/// <param name="strFechavencimiento">DateTime that contents the strFechavencimiento value for the Tareas object</param>
		/// <param name="logAvisa">bool that contents the logAvisa value for the Tareas object</param>
		/// <param name="FechaAviso">DateTime that contents the FechaAviso value for the Tareas object</param>
		/// <param name="Fechadefinalización">DateTime that contents the Fechadefinalización value for the Tareas object</param>
		/// <param name="logFinalizada">bool that contents the logFinalizada value for the Tareas object</param>
		/// <param name="Notas">string that contents the Notas value for the Tareas object</param>
		/// <param name="lngIdStatus">int that contents the lngIdStatus value for the Tareas object</param>
		/// <returns>One Tareas object</returns>
		public Tareas Create(int lngIdTarea, string strAsunto, DateTime? dtmFechaInicio, DateTime? strFechavencimiento, bool? logAvisa, DateTime? FechaAviso, DateTime? Fechadefinalización, bool? logFinalizada, string Notas, int? lngIdStatus, Sinapsys.Datos.SQL datosTransaccion=null)
		{
			try 
			{
				Tareas tareas = new Tareas();

				tareas.lngIdTarea = lngIdTarea;
				tareas.lngIdTarea = lngIdTarea;
				tareas.strAsunto = strAsunto;
				tareas.dtmFechaInicio = dtmFechaInicio;
				tareas.strFechavencimiento = strFechavencimiento;
				tareas.logAvisa = logAvisa;
				tareas.FechaAviso = FechaAviso;
				tareas.Fechadefinalización = Fechadefinalización;
				tareas.logFinalizada = logFinalizada;
				tareas.Notas = Notas;
				tareas.lngIdStatus = lngIdStatus;
				lngIdTarea = TareasDataProvider.Instance.Create(lngIdTarea, strAsunto, dtmFechaInicio, strFechavencimiento, logAvisa, FechaAviso, Fechadefinalización, logFinalizada, Notas, lngIdStatus,"Tareas",datosTransaccion);
				if (lngIdTarea == 0)
					return null;

				tareas.lngIdTarea = lngIdTarea;

				return tareas;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Updates an Tareas object by passing all object's fields
		/// </summary>
		/// <param name="strAsunto">string that contents the strAsunto value for the Tareas object</param>
		/// <param name="dtmFechaInicio">DateTime that contents the dtmFechaInicio value for the Tareas object</param>
		/// <param name="strFechavencimiento">DateTime that contents the strFechavencimiento value for the Tareas object</param>
		/// <param name="logAvisa">bool that contents the logAvisa value for the Tareas object</param>
		/// <param name="FechaAviso">DateTime that contents the FechaAviso value for the Tareas object</param>
		/// <param name="Fechadefinalización">DateTime that contents the Fechadefinalización value for the Tareas object</param>
		/// <param name="logFinalizada">bool that contents the logFinalizada value for the Tareas object</param>
		/// <param name="Notas">string that contents the Notas value for the Tareas object</param>
		/// <param name="lngIdStatus">int that contents the lngIdStatus value for the Tareas object</param>
		/// <param name="lngIdTarea">int that contents the lngIdTarea value for the Tareas object</param>
		public void Update(string strAsunto, DateTime? dtmFechaInicio, DateTime? strFechavencimiento, bool? logAvisa, DateTime? FechaAviso, DateTime? Fechadefinalización, bool? logFinalizada, string Notas, int? lngIdStatus, int lngIdTarea, Sinapsys.Datos.SQL datosTransaccion=null)
		{
			try 
			{
				Tareas new_values = new Tareas();
				new_values.strAsunto = strAsunto;
				new_values.dtmFechaInicio = dtmFechaInicio;
				new_values.strFechavencimiento = strFechavencimiento;
				new_values.logAvisa = logAvisa;
				new_values.FechaAviso = FechaAviso;
				new_values.Fechadefinalización = Fechadefinalización;
				new_values.logFinalizada = logFinalizada;
				new_values.Notas = Notas;
				new_values.lngIdStatus = lngIdStatus;
				TareasDataProvider.Instance.Update(strAsunto, dtmFechaInicio, strFechavencimiento, logAvisa, FechaAviso, Fechadefinalización, logFinalizada, Notas, lngIdStatus, lngIdTarea,"Tareas",datosTransaccion);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Updates an Tareas object by passing one object's instance as reference
		/// </summary>
		/// <param name="tareas">An instance of Tareas for reference</param>
		public void Update(Tareas tareas,Sinapsys.Datos.SQL datosTransaccion=null)
		{
			Update(tareas.strAsunto, tareas.dtmFechaInicio, tareas.strFechavencimiento, tareas.logAvisa, tareas.FechaAviso, tareas.Fechadefinalización, tareas.logFinalizada, tareas.Notas, tareas.lngIdStatus, tareas.lngIdTarea);
		}

		/// <summary>
		/// Delete  the Tareas object by passing a object
		/// </summary>
		public void  Delete(Tareas tareas, Sinapsys.Datos.SQL datosTransaccion=null)
		{
			Delete(tareas.lngIdTarea,datosTransaccion);
		}

		/// <summary>
		/// Deletes the Tareas object by passing one object's instance as reference
		/// </summary>
		/// <param name="tareas">An instance of Tareas for reference</param>
		public void Delete(int lngIdTarea, Sinapsys.Datos.SQL datosTransaccion=null)
		{
			try 
			{
				//Tareas old_values = TareasController.Instance.Get(lngIdTarea);
				//if(!Validate.security.CanDeleteSecurityField(TareasController.Instance, (ILatinodeObject)old_values))
				//    throw new Exception("Access denied by security field, you can't delete object");

				TareasDataProvider.Instance.Delete(lngIdTarea,"Tareas");
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Deletes the Tareas object by passing CVS parameter as reference
		/// </summary>
		/// <param name="tareas">An instance of Tareas for reference</param>
		public void Delete(string CVSParameter)
		{
			string[] StrCommand=CVSParameter.Split(',');
			try 
			{
				int lngIdTarea=int.Parse(StrCommand[0]);
				TareasDataProvider.Instance.Delete(lngIdTarea,"Tareas");
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Gets the Tareas object by passing the object's key fields
		/// </summary>
		/// <param name="lngIdTarea">int that contents the lngIdTarea value for the Tareas object</param>
		/// <returns>One Tareas object</returns>
		public Tareas Get(int lngIdTarea, bool generateUndo=false)
		{
			try 
			{
				Tareas tareas = null;
				DataTable dt = TareasDataProvider.Instance.Get(lngIdTarea);
				if ((dt.Rows.Count > 0))
				{
					tareas = new Tareas();
					DataRow dr = dt.Rows[0];
					ReadData(tareas, dr, generateUndo);
				}


				return tareas;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Gets all objects of Tareas
		/// </summary>
		/// <returns>One TareasList object</returns>
		public TareasList GetAll(bool generateUndo=false)
		{
			try 
			{
				TareasList tareaslist = new TareasList();
				DataTable dt = TareasDataProvider.Instance.GetAll();
				foreach (DataRow dr in dt.Rows)
				{
					Tareas tareas = new Tareas();
					ReadData(tareas, dr, generateUndo);
					tareaslist.Add(tareas);
				}
				return tareaslist;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Gets all objects of Tareas applying filter and sort criteria
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
		/// <returns>One TareasList object</returns>
		public TareasList GetFilter(int pagenum, int pagesize, string filter, string sort, string extablesfilter, string extablesfieldsfilter, string extablesrelationsfilter, string extablessort, string extablesfieldssort, string extablesrelationssort, bool generateUndo=false)
		{
			try 
			{
				TareasList tareaslist = new TareasList();

				DataTable dt = TareasDataProvider.Instance.GetFilter(pagenum, pagesize, filter, sort, extablesfilter, extablesfieldsfilter, extablesrelationsfilter, extablessort, extablesfieldssort, extablesrelationssort);

				foreach (DataRow dr in dt.Rows)
				{
					Tareas tareas = new Tareas();
					ReadData(tareas, dr, generateUndo);
					tareaslist.Add(tareas);
				}
				return tareaslist;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public TareasList GetFilter( string filter, string sort, bool generateUndo=false)
		{
			return GetFilter(0,0, filter, sort, "","","","","","",generateUndo);
		}

		public TareasList GetFilter(string filter, string sort, string extablesfilter, string extablesfieldsfilter, string extablesrelationsfilter, string extablessort, string extablesfieldssort, string extablesrelationssort, bool generateUndo=false)
		{
			return GetFilter(0,0, filter, sort, extablesfilter, extablesfieldsfilter, extablesrelationsfilter, extablessort, extablesfieldssort, extablesrelationssort,generateUndo);
		}


		/// <summary>
		/// Returns the type for one property
		/// </summary>
		/// <param name="propertyname">Property's name for return its value</param>
		/// <returns>A value for the <paramref name="propertyname"/></returns>
		public Type GetMethodType( string propertyname,Tareas tareas)
		{
			// Perform the search for the property's value
			switch (propertyname)
			{
				case "strAsunto":
					return tareas.strAsunto.GetType();

				case "dtmFechaInicio":
					return tareas.dtmFechaInicio.GetType();

				case "strFechavencimiento":
					return tareas.strFechavencimiento.GetType();

				case "logAvisa":
					return tareas.logAvisa.GetType();

				case "FechaAviso":
					return tareas.FechaAviso.GetType();

				case "Fechadefinalización":
					return tareas.Fechadefinalización.GetType();

				case "logFinalizada":
					return tareas.logFinalizada.GetType();

				case "Notas":
					return tareas.Notas.GetType();

				case "lngIdStatus":
					return tareas.lngIdStatus.GetType();

				case "lngIdTarea":
					return tareas.lngIdTarea.GetType();

			}

			return null;
		}
		/// <summary>
		/// update the changes in Tareas object by passing the object
		/// </summary>
		public bool UpdateChanges(Tareas tareas, out string error,Sinapsys.Datos.SQL datosTransaccion=null)
		{
			if (tareas.OldTareas == null)
			{
				    error = "No tiene objeto con el cual comparar";
				    return false;
			}
			string[] Fields = tareas.FieldChanged();
			error = "";
			return LiqViajes_Bll_Data.DataProvider.UpdateFieldsbyObject(Fields, tareas, out error,datosTransaccion);
		}
	}

	#endregion

}
