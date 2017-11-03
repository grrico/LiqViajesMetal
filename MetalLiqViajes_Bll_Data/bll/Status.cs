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
	#region StatusController

	/// <summary>
	/// Class for convert data from database into object's data and vice versa
	/// </summary>
	public partial class StatusController//: ILatinodeController
	{
		/// <summary>
		/// Generic Constructor
		/// </summary>
		public StatusController()
		{
		}

		/// <summary>
		/// Instance accessor for this singleton
		/// </summary>
		private static StatusController MySingleObj;
		public static StatusController Instance
		{
			get
			{
				if (MySingleObj == null)
				{
					MySingleObj = new StatusController();
				}
				return MySingleObj;
			}
		}

		// Reads object's data from a DataRow
		private void ReadData(Status status, DataRow dr,bool generateUndo=false)
		{
			try 
			{
				status.strStatus = dr.IsNull("strStatus") ? null :(string) dr["strStatus"];
				status.lngIdStatus = (int) dr["lngIdStatus"];
			}
			catch (Exception ex)
			{
				Utilidades.LogErrores(ex.Message + (ex.InnerException != null ? ex.InnerException.Message : ""), DataProvider.AplicacionNombre);
				throw ex;
			}
			if (generateUndo) status.GenerateUndo();
		}

		/// <summary>
		/// Create a new Status object by passing a object
		/// </summary>
		public Status Create(Status status, Sinapsys.Datos.SQL datosTransaccion=null)
		{
			return Create(status.lngIdStatus,status.strStatus,datosTransaccion);
		}

		/// <summary>
		/// Creates a new Status object by passing all object's fields
		/// </summary>
		/// <param name="strStatus">string that contents the strStatus value for the Status object</param>
		/// <returns>One Status object</returns>
		public Status Create(int lngIdStatus, string strStatus, Sinapsys.Datos.SQL datosTransaccion=null)
		{
			try 
			{
				Status status = new Status();

				status.lngIdStatus = lngIdStatus;
				status.lngIdStatus = lngIdStatus;
				status.strStatus = strStatus;
				lngIdStatus = StatusDataProvider.Instance.Create(lngIdStatus, strStatus,"Status",datosTransaccion);
				if (lngIdStatus == 0)
					return null;

				status.lngIdStatus = lngIdStatus;

				return status;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Updates an Status object by passing all object's fields
		/// </summary>
		/// <param name="strStatus">string that contents the strStatus value for the Status object</param>
		/// <param name="lngIdStatus">int that contents the lngIdStatus value for the Status object</param>
		public void Update(string strStatus, int lngIdStatus, Sinapsys.Datos.SQL datosTransaccion=null)
		{
			try 
			{
				Status new_values = new Status();
				new_values.strStatus = strStatus;
				StatusDataProvider.Instance.Update(strStatus, lngIdStatus,"Status",datosTransaccion);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Updates an Status object by passing one object's instance as reference
		/// </summary>
		/// <param name="status">An instance of Status for reference</param>
		public void Update(Status status,Sinapsys.Datos.SQL datosTransaccion=null)
		{
			Update(status.strStatus, status.lngIdStatus);
		}

		/// <summary>
		/// Delete  the Status object by passing a object
		/// </summary>
		public void  Delete(Status status, Sinapsys.Datos.SQL datosTransaccion=null)
		{
			Delete(status.lngIdStatus,datosTransaccion);
		}

		/// <summary>
		/// Deletes the Status object by passing one object's instance as reference
		/// </summary>
		/// <param name="status">An instance of Status for reference</param>
		public void Delete(int lngIdStatus, Sinapsys.Datos.SQL datosTransaccion=null)
		{
			try 
			{
				//Status old_values = StatusController.Instance.Get(lngIdStatus);
				//if(!Validate.security.CanDeleteSecurityField(StatusController.Instance, (ILatinodeObject)old_values))
				//    throw new Exception("Access denied by security field, you can't delete object");

				StatusDataProvider.Instance.Delete(lngIdStatus,"Status");
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Deletes the Status object by passing CVS parameter as reference
		/// </summary>
		/// <param name="status">An instance of Status for reference</param>
		public void Delete(string CVSParameter)
		{
			string[] StrCommand=CVSParameter.Split(',');
			try 
			{
				int lngIdStatus=int.Parse(StrCommand[0]);
				StatusDataProvider.Instance.Delete(lngIdStatus,"Status");
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Gets the Status object by passing the object's key fields
		/// </summary>
		/// <param name="lngIdStatus">int that contents the lngIdStatus value for the Status object</param>
		/// <returns>One Status object</returns>
		public Status Get(int lngIdStatus, bool generateUndo=false)
		{
			try 
			{
				Status status = null;
				DataTable dt = StatusDataProvider.Instance.Get(lngIdStatus);
				if ((dt.Rows.Count > 0))
				{
					status = new Status();
					DataRow dr = dt.Rows[0];
					ReadData(status, dr, generateUndo);
				}


				return status;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Gets all objects of Status
		/// </summary>
		/// <returns>One StatusList object</returns>
		public StatusList GetAll(bool generateUndo=false)
		{
			try 
			{
				StatusList statuslist = new StatusList();
				DataTable dt = StatusDataProvider.Instance.GetAll();
				foreach (DataRow dr in dt.Rows)
				{
					Status status = new Status();
					ReadData(status, dr, generateUndo);
					statuslist.Add(status);
				}
				return statuslist;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Gets all objects of Status applying filter and sort criteria
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
		/// <returns>One StatusList object</returns>
		public StatusList GetFilter(int pagenum, int pagesize, string filter, string sort, string extablesfilter, string extablesfieldsfilter, string extablesrelationsfilter, string extablessort, string extablesfieldssort, string extablesrelationssort, bool generateUndo=false)
		{
			try 
			{
				StatusList statuslist = new StatusList();

				DataTable dt = StatusDataProvider.Instance.GetFilter(pagenum, pagesize, filter, sort, extablesfilter, extablesfieldsfilter, extablesrelationsfilter, extablessort, extablesfieldssort, extablesrelationssort);

				foreach (DataRow dr in dt.Rows)
				{
					Status status = new Status();
					ReadData(status, dr, generateUndo);
					statuslist.Add(status);
				}
				return statuslist;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public StatusList GetFilter( string filter, string sort, bool generateUndo=false)
		{
			return GetFilter(0,0, filter, sort, "","","","","","",generateUndo);
		}

		public StatusList GetFilter(string filter, string sort, string extablesfilter, string extablesfieldsfilter, string extablesrelationsfilter, string extablessort, string extablesfieldssort, string extablesrelationssort, bool generateUndo=false)
		{
			return GetFilter(0,0, filter, sort, extablesfilter, extablesfieldsfilter, extablesrelationsfilter, extablessort, extablesfieldssort, extablesrelationssort,generateUndo);
		}


		/// <summary>
		/// Returns the type for one property
		/// </summary>
		/// <param name="propertyname">Property's name for return its value</param>
		/// <returns>A value for the <paramref name="propertyname"/></returns>
		public Type GetMethodType( string propertyname,Status status)
		{
			// Perform the search for the property's value
			switch (propertyname)
			{
				case "strStatus":
					return status.strStatus.GetType();

				case "lngIdStatus":
					return status.lngIdStatus.GetType();

			}

			return null;
		}
		/// <summary>
		/// update the changes in Status object by passing the object
		/// </summary>
		public bool UpdateChanges(Status status, out string error,Sinapsys.Datos.SQL datosTransaccion=null)
		{
			if (status.OldStatus == null)
			{
				    error = "No tiene objeto con el cual comparar";
				    return false;
			}
			string[] Fields = status.FieldChanged();
			error = "";
			return LiqViajes_Bll_Data.DataProvider.UpdateFieldsbyObject(Fields, status, out error,datosTransaccion);
		}
	}

	#endregion

}
