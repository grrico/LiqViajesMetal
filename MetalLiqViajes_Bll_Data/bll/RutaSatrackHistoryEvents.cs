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
	#region RutaSatrackHistoryEventsController

	/// <summary>
	/// Class for convert data from database into object's data and vice versa
	/// </summary>
	public partial class RutaSatrackHistoryEventsController//: ILatinodeController
	{
		/// <summary>
		/// Generic Constructor
		/// </summary>
		public RutaSatrackHistoryEventsController()
		{
		}

		/// <summary>
		/// Instance accessor for this singleton
		/// </summary>
		private static RutaSatrackHistoryEventsController MySingleObj;
		public static RutaSatrackHistoryEventsController Instance
		{
			get
			{
				if (MySingleObj == null)
				{
					MySingleObj = new RutaSatrackHistoryEventsController();
				}
				return MySingleObj;
			}
		}

		// Reads object's data from a DataRow
		private void ReadData(RutaSatrackHistoryEvents rutasatrackhistoryevents, DataRow dr,bool generateUndo=false)
		{
			try 
			{
				rutasatrackhistoryevents.Codigo = (long) dr["Codigo"];
				rutasatrackhistoryevents.Placa = dr.IsNull("Placa") ? null :(string) dr["Placa"];
				rutasatrackhistoryevents.FechaSistema = dr.IsNull("FechaSistema") ? null :(DateTime?) dr["FechaSistema"];
				rutasatrackhistoryevents.FechaHora_GPS = dr.IsNull("FechaHora_GPS") ? null :(DateTime?) dr["FechaHora_GPS"];
				rutasatrackhistoryevents.EventoPrioridad = dr.IsNull("EventoPrioridad") ? null :(string) dr["EventoPrioridad"];
				rutasatrackhistoryevents.VelocidadSentido = dr.IsNull("VelocidadSentido") ? null :(string) dr["VelocidadSentido"];
				rutasatrackhistoryevents.Edad_Posicion = dr.IsNull("Edad_Posicion") ? null :(string) dr["Edad_Posicion"];
				rutasatrackhistoryevents.Ubicacion = dr.IsNull("Ubicacion") ? null :(string) dr["Ubicacion"];
				rutasatrackhistoryevents.Latitud = dr.IsNull("Latitud") ? null :(decimal?) dr["Latitud"];
				rutasatrackhistoryevents.Longitud = dr.IsNull("Longitud") ? null :(decimal?) dr["Longitud"];
			}
			catch (Exception ex)
			{
				Utilidades.LogErrores(ex.Message + (ex.InnerException != null ? ex.InnerException.Message : ""), DataProvider.AplicacionNombre);
				throw ex;
			}
			if (generateUndo) rutasatrackhistoryevents.GenerateUndo();
		}

		/// <summary>
		/// Create a new RutaSatrackHistoryEvents object by passing a object
		/// </summary>
		public RutaSatrackHistoryEvents Create(RutaSatrackHistoryEvents rutasatrackhistoryevents, Sinapsys.Datos.SQL datosTransaccion=null)
		{
			return Create(rutasatrackhistoryevents.Codigo,rutasatrackhistoryevents.Placa,rutasatrackhistoryevents.FechaSistema,rutasatrackhistoryevents.FechaHora_GPS,rutasatrackhistoryevents.EventoPrioridad,rutasatrackhistoryevents.VelocidadSentido,rutasatrackhistoryevents.Edad_Posicion,rutasatrackhistoryevents.Ubicacion,rutasatrackhistoryevents.Latitud,rutasatrackhistoryevents.Longitud,datosTransaccion);
		}

		/// <summary>
		/// Creates a new RutaSatrackHistoryEvents object by passing all object's fields
		/// </summary>
		/// <param name="Placa">string that contents the Placa value for the RutaSatrackHistoryEvents object</param>
		/// <param name="FechaSistema">DateTime that contents the FechaSistema value for the RutaSatrackHistoryEvents object</param>
		/// <param name="FechaHora_GPS">DateTime that contents the FechaHora_GPS value for the RutaSatrackHistoryEvents object</param>
		/// <param name="EventoPrioridad">string that contents the EventoPrioridad value for the RutaSatrackHistoryEvents object</param>
		/// <param name="VelocidadSentido">string that contents the VelocidadSentido value for the RutaSatrackHistoryEvents object</param>
		/// <param name="Edad_Posicion">string that contents the Edad_Posicion value for the RutaSatrackHistoryEvents object</param>
		/// <param name="Ubicacion">string that contents the Ubicacion value for the RutaSatrackHistoryEvents object</param>
		/// <param name="Latitud">decimal that contents the Latitud value for the RutaSatrackHistoryEvents object</param>
		/// <param name="Longitud">decimal that contents the Longitud value for the RutaSatrackHistoryEvents object</param>
		/// <returns>One RutaSatrackHistoryEvents object</returns>
		public RutaSatrackHistoryEvents Create(long Codigo, string Placa, DateTime? FechaSistema, DateTime? FechaHora_GPS, string EventoPrioridad, string VelocidadSentido, string Edad_Posicion, string Ubicacion, decimal? Latitud, decimal? Longitud, Sinapsys.Datos.SQL datosTransaccion=null)
		{
			try 
			{
				RutaSatrackHistoryEvents rutasatrackhistoryevents = new RutaSatrackHistoryEvents();

				rutasatrackhistoryevents.Codigo = Codigo;
				rutasatrackhistoryevents.Codigo = Codigo;
				rutasatrackhistoryevents.Placa = Placa;
				rutasatrackhistoryevents.FechaSistema = FechaSistema;
				rutasatrackhistoryevents.FechaHora_GPS = FechaHora_GPS;
				rutasatrackhistoryevents.EventoPrioridad = EventoPrioridad;
				rutasatrackhistoryevents.VelocidadSentido = VelocidadSentido;
				rutasatrackhistoryevents.Edad_Posicion = Edad_Posicion;
				rutasatrackhistoryevents.Ubicacion = Ubicacion;
				rutasatrackhistoryevents.Latitud = Latitud;
				rutasatrackhistoryevents.Longitud = Longitud;
				Codigo = RutaSatrackHistoryEventsDataProvider.Instance.Create(Codigo, Placa, FechaSistema, FechaHora_GPS, EventoPrioridad, VelocidadSentido, Edad_Posicion, Ubicacion, Latitud, Longitud,"RutaSatrackHistoryEvents",datosTransaccion);
				if (Codigo == 0)
					return null;

				rutasatrackhistoryevents.Codigo = Codigo;

				return rutasatrackhistoryevents;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Updates an RutaSatrackHistoryEvents object by passing all object's fields
		/// </summary>
		/// <param name="Codigo">long that contents the Codigo value for the RutaSatrackHistoryEvents object</param>
		/// <param name="Placa">string that contents the Placa value for the RutaSatrackHistoryEvents object</param>
		/// <param name="FechaSistema">DateTime that contents the FechaSistema value for the RutaSatrackHistoryEvents object</param>
		/// <param name="FechaHora_GPS">DateTime that contents the FechaHora_GPS value for the RutaSatrackHistoryEvents object</param>
		/// <param name="EventoPrioridad">string that contents the EventoPrioridad value for the RutaSatrackHistoryEvents object</param>
		/// <param name="VelocidadSentido">string that contents the VelocidadSentido value for the RutaSatrackHistoryEvents object</param>
		/// <param name="Edad_Posicion">string that contents the Edad_Posicion value for the RutaSatrackHistoryEvents object</param>
		/// <param name="Ubicacion">string that contents the Ubicacion value for the RutaSatrackHistoryEvents object</param>
		/// <param name="Latitud">decimal that contents the Latitud value for the RutaSatrackHistoryEvents object</param>
		/// <param name="Longitud">decimal that contents the Longitud value for the RutaSatrackHistoryEvents object</param>
		public void Update(long Codigo, string Placa, DateTime? FechaSistema, DateTime? FechaHora_GPS, string EventoPrioridad, string VelocidadSentido, string Edad_Posicion, string Ubicacion, decimal? Latitud, decimal? Longitud, Sinapsys.Datos.SQL datosTransaccion=null)
		{
			try 
			{
				RutaSatrackHistoryEvents new_values = new RutaSatrackHistoryEvents();
				new_values.Placa = Placa;
				new_values.FechaSistema = FechaSistema;
				new_values.FechaHora_GPS = FechaHora_GPS;
				new_values.EventoPrioridad = EventoPrioridad;
				new_values.VelocidadSentido = VelocidadSentido;
				new_values.Edad_Posicion = Edad_Posicion;
				new_values.Ubicacion = Ubicacion;
				new_values.Latitud = Latitud;
				new_values.Longitud = Longitud;
				RutaSatrackHistoryEventsDataProvider.Instance.Update(Codigo, Placa, FechaSistema, FechaHora_GPS, EventoPrioridad, VelocidadSentido, Edad_Posicion, Ubicacion, Latitud, Longitud,"RutaSatrackHistoryEvents",datosTransaccion);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Updates an RutaSatrackHistoryEvents object by passing one object's instance as reference
		/// </summary>
		/// <param name="rutasatrackhistoryevents">An instance of RutaSatrackHistoryEvents for reference</param>
		public void Update(RutaSatrackHistoryEvents rutasatrackhistoryevents,Sinapsys.Datos.SQL datosTransaccion=null)
		{
			Update(rutasatrackhistoryevents.Codigo, rutasatrackhistoryevents.Placa, rutasatrackhistoryevents.FechaSistema, rutasatrackhistoryevents.FechaHora_GPS, rutasatrackhistoryevents.EventoPrioridad, rutasatrackhistoryevents.VelocidadSentido, rutasatrackhistoryevents.Edad_Posicion, rutasatrackhistoryevents.Ubicacion, rutasatrackhistoryevents.Latitud, rutasatrackhistoryevents.Longitud);
		}

		/// <summary>
		/// Delete  the RutaSatrackHistoryEvents object by passing a object
		/// </summary>
		public void  Delete(RutaSatrackHistoryEvents rutasatrackhistoryevents, Sinapsys.Datos.SQL datosTransaccion=null)
		{
			Delete(rutasatrackhistoryevents.Codigo,datosTransaccion);
		}

		/// <summary>
		/// Deletes the RutaSatrackHistoryEvents object by passing one object's instance as reference
		/// </summary>
		/// <param name="rutasatrackhistoryevents">An instance of RutaSatrackHistoryEvents for reference</param>
		public void Delete(long Codigo, Sinapsys.Datos.SQL datosTransaccion=null)
		{
			try 
			{
				//RutaSatrackHistoryEvents old_values = RutaSatrackHistoryEventsController.Instance.Get(Codigo);
				//if(!Validate.security.CanDeleteSecurityField(RutaSatrackHistoryEventsController.Instance, (ILatinodeObject)old_values))
				//    throw new Exception("Access denied by security field, you can't delete object");

				RutaSatrackHistoryEventsDataProvider.Instance.Delete(Codigo,"RutaSatrackHistoryEvents");
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Deletes the RutaSatrackHistoryEvents object by passing CVS parameter as reference
		/// </summary>
		/// <param name="rutasatrackhistoryevents">An instance of RutaSatrackHistoryEvents for reference</param>
		public void Delete(string CVSParameter)
		{
			string[] StrCommand=CVSParameter.Split(',');
			try 
			{
				long Codigo=long.Parse(StrCommand[0]);
				RutaSatrackHistoryEventsDataProvider.Instance.Delete(Codigo,"RutaSatrackHistoryEvents");
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Gets the RutaSatrackHistoryEvents object by passing the object's key fields
		/// </summary>
		/// <param name="Codigo">long that contents the Codigo value for the RutaSatrackHistoryEvents object</param>
		/// <returns>One RutaSatrackHistoryEvents object</returns>
		public RutaSatrackHistoryEvents Get(long Codigo, bool generateUndo=false)
		{
			try 
			{
				RutaSatrackHistoryEvents rutasatrackhistoryevents = null;
				DataTable dt = RutaSatrackHistoryEventsDataProvider.Instance.Get(Codigo);
				if ((dt.Rows.Count > 0))
				{
					rutasatrackhistoryevents = new RutaSatrackHistoryEvents();
					DataRow dr = dt.Rows[0];
					ReadData(rutasatrackhistoryevents, dr, generateUndo);
				}


				return rutasatrackhistoryevents;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Gets all objects of RutaSatrackHistoryEvents
		/// </summary>
		/// <returns>One RutaSatrackHistoryEventsList object</returns>
		public RutaSatrackHistoryEventsList GetAll(bool generateUndo=false)
		{
			try 
			{
				RutaSatrackHistoryEventsList rutasatrackhistoryeventslist = new RutaSatrackHistoryEventsList();
				DataTable dt = RutaSatrackHistoryEventsDataProvider.Instance.GetAll();
				foreach (DataRow dr in dt.Rows)
				{
					RutaSatrackHistoryEvents rutasatrackhistoryevents = new RutaSatrackHistoryEvents();
					ReadData(rutasatrackhistoryevents, dr, generateUndo);
					rutasatrackhistoryeventslist.Add(rutasatrackhistoryevents);
				}
				return rutasatrackhistoryeventslist;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Gets all objects of RutaSatrackHistoryEvents applying filter and sort criteria
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
		/// <returns>One RutaSatrackHistoryEventsList object</returns>
		public RutaSatrackHistoryEventsList GetFilter(int pagenum, int pagesize, string filter, string sort, string extablesfilter, string extablesfieldsfilter, string extablesrelationsfilter, string extablessort, string extablesfieldssort, string extablesrelationssort, bool generateUndo=false)
		{
			try 
			{
				RutaSatrackHistoryEventsList rutasatrackhistoryeventslist = new RutaSatrackHistoryEventsList();

				DataTable dt = RutaSatrackHistoryEventsDataProvider.Instance.GetFilter(pagenum, pagesize, filter, sort, extablesfilter, extablesfieldsfilter, extablesrelationsfilter, extablessort, extablesfieldssort, extablesrelationssort);

				foreach (DataRow dr in dt.Rows)
				{
					RutaSatrackHistoryEvents rutasatrackhistoryevents = new RutaSatrackHistoryEvents();
					ReadData(rutasatrackhistoryevents, dr, generateUndo);
					rutasatrackhistoryeventslist.Add(rutasatrackhistoryevents);
				}
				return rutasatrackhistoryeventslist;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public RutaSatrackHistoryEventsList GetFilter( string filter, string sort, bool generateUndo=false)
		{
			return GetFilter(0,0, filter, sort, "","","","","","",generateUndo);
		}

		public RutaSatrackHistoryEventsList GetFilter(string filter, string sort, string extablesfilter, string extablesfieldsfilter, string extablesrelationsfilter, string extablessort, string extablesfieldssort, string extablesrelationssort, bool generateUndo=false)
		{
			return GetFilter(0,0, filter, sort, extablesfilter, extablesfieldsfilter, extablesrelationsfilter, extablessort, extablesfieldssort, extablesrelationssort,generateUndo);
		}


		/// <summary>
		/// Returns the type for one property
		/// </summary>
		/// <param name="propertyname">Property's name for return its value</param>
		/// <returns>A value for the <paramref name="propertyname"/></returns>
		public Type GetMethodType( string propertyname,RutaSatrackHistoryEvents rutasatrackhistoryevents)
		{
			// Perform the search for the property's value
			switch (propertyname)
			{
				case "Codigo":
					return rutasatrackhistoryevents.Codigo.GetType();

				case "Placa":
					return rutasatrackhistoryevents.Placa.GetType();

				case "FechaSistema":
					return rutasatrackhistoryevents.FechaSistema.GetType();

				case "FechaHora_GPS":
					return rutasatrackhistoryevents.FechaHora_GPS.GetType();

				case "EventoPrioridad":
					return rutasatrackhistoryevents.EventoPrioridad.GetType();

				case "VelocidadSentido":
					return rutasatrackhistoryevents.VelocidadSentido.GetType();

				case "Edad_Posicion":
					return rutasatrackhistoryevents.Edad_Posicion.GetType();

				case "Ubicacion":
					return rutasatrackhistoryevents.Ubicacion.GetType();

				case "Latitud":
					return rutasatrackhistoryevents.Latitud.GetType();

				case "Longitud":
					return rutasatrackhistoryevents.Longitud.GetType();

			}

			return null;
		}
		/// <summary>
		/// update the changes in RutaSatrackHistoryEvents object by passing the object
		/// </summary>
		public bool UpdateChanges(RutaSatrackHistoryEvents rutasatrackhistoryevents, out string error,Sinapsys.Datos.SQL datosTransaccion=null)
		{
			if (rutasatrackhistoryevents.OldRutaSatrackHistoryEvents == null)
			{
				    error = "No tiene objeto con el cual comparar";
				    return false;
			}
			string[] Fields = rutasatrackhistoryevents.FieldChanged();
			error = "";
			return LiqViajes_Bll_Data.DataProvider.UpdateFieldsbyObject(Fields, rutasatrackhistoryevents, out error,datosTransaccion);
		}
	}

	#endregion

}
