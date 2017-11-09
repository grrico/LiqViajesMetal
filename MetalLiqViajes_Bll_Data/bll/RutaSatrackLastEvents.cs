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
	#region RutaSatrackLastEventsController

	/// <summary>
	/// Class for convert data from database into object's data and vice versa
	/// </summary>
	public partial class RutaSatrackLastEventsController//: ILatinodeController
	{
		/// <summary>
		/// Generic Constructor
		/// </summary>
		public RutaSatrackLastEventsController()
		{
		}

		/// <summary>
		/// Instance accessor for this singleton
		/// </summary>
		private static RutaSatrackLastEventsController MySingleObj;
		public static RutaSatrackLastEventsController Instance
		{
			get
			{
				if (MySingleObj == null)
				{
					MySingleObj = new RutaSatrackLastEventsController();
				}
				return MySingleObj;
			}
		}

		// Reads object's data from a DataRow
		private void ReadData(RutaSatrackLastEvents rutasatracklastevents, DataRow dr,bool generateUndo=false)
		{
			try 
			{
				rutasatracklastevents.Placa = (string) dr["Placa"];
				rutasatracklastevents.FechaSistema = dr.IsNull("FechaSistema") ? null :(DateTime?) dr["FechaSistema"];
				rutasatracklastevents.FechaHora_GPS = dr.IsNull("FechaHora_GPS") ? null :(DateTime?) dr["FechaHora_GPS"];
				rutasatracklastevents.EventoPrioridad = dr.IsNull("EventoPrioridad") ? null :(string) dr["EventoPrioridad"];
				rutasatracklastevents.VelocidadSentido = dr.IsNull("VelocidadSentido") ? null :(string) dr["VelocidadSentido"];
				rutasatracklastevents.Edad_Posicion = dr.IsNull("Edad_Posicion") ? null :(string) dr["Edad_Posicion"];
				rutasatracklastevents.Ubicacion = dr.IsNull("Ubicacion") ? null :(string) dr["Ubicacion"];
				rutasatracklastevents.Latitud = dr.IsNull("Latitud") ? null :(decimal?) dr["Latitud"];
				rutasatracklastevents.Longitud = dr.IsNull("Longitud") ? null :(decimal?) dr["Longitud"];
			}
			catch (Exception ex)
			{
				Utilidades.LogErrores(ex.Message + (ex.InnerException != null ? ex.InnerException.Message : ""), DataProvider.AplicacionNombre);
				throw ex;
			}
			if (generateUndo) rutasatracklastevents.GenerateUndo();
		}

		/// <summary>
		/// Create a new RutaSatrackLastEvents object by passing a object
		/// </summary>
		public RutaSatrackLastEvents Create(RutaSatrackLastEvents rutasatracklastevents, Sinapsys.Datos.SQL datosTransaccion=null)
		{
			return Create(rutasatracklastevents.Placa,rutasatracklastevents.FechaSistema,rutasatracklastevents.FechaHora_GPS,rutasatracklastevents.EventoPrioridad,rutasatracklastevents.VelocidadSentido,rutasatracklastevents.Edad_Posicion,rutasatracklastevents.Ubicacion,rutasatracklastevents.Latitud,rutasatracklastevents.Longitud,datosTransaccion);
		}

		/// <summary>
		/// Creates a new RutaSatrackLastEvents object by passing all object's fields
		/// </summary>
		/// <param name="FechaSistema">DateTime that contents the FechaSistema value for the RutaSatrackLastEvents object</param>
		/// <param name="FechaHora_GPS">DateTime that contents the FechaHora_GPS value for the RutaSatrackLastEvents object</param>
		/// <param name="EventoPrioridad">string that contents the EventoPrioridad value for the RutaSatrackLastEvents object</param>
		/// <param name="VelocidadSentido">string that contents the VelocidadSentido value for the RutaSatrackLastEvents object</param>
		/// <param name="Edad_Posicion">string that contents the Edad_Posicion value for the RutaSatrackLastEvents object</param>
		/// <param name="Ubicacion">string that contents the Ubicacion value for the RutaSatrackLastEvents object</param>
		/// <param name="Latitud">decimal that contents the Latitud value for the RutaSatrackLastEvents object</param>
		/// <param name="Longitud">decimal that contents the Longitud value for the RutaSatrackLastEvents object</param>
		/// <returns>One RutaSatrackLastEvents object</returns>
		public RutaSatrackLastEvents Create(string Placa, DateTime? FechaSistema, DateTime? FechaHora_GPS, string EventoPrioridad, string VelocidadSentido, string Edad_Posicion, string Ubicacion, decimal? Latitud, decimal? Longitud, Sinapsys.Datos.SQL datosTransaccion=null)
		{
			try 
			{
				RutaSatrackLastEvents rutasatracklastevents = new RutaSatrackLastEvents();

				rutasatracklastevents.Placa = Placa;
				rutasatracklastevents.FechaSistema = FechaSistema;
				rutasatracklastevents.FechaHora_GPS = FechaHora_GPS;
				rutasatracklastevents.EventoPrioridad = EventoPrioridad;
				rutasatracklastevents.VelocidadSentido = VelocidadSentido;
				rutasatracklastevents.Edad_Posicion = Edad_Posicion;
				rutasatracklastevents.Ubicacion = Ubicacion;
				rutasatracklastevents.Latitud = Latitud;
				rutasatracklastevents.Longitud = Longitud;
				RutaSatrackLastEventsDataProvider.Instance.Create(Placa, FechaSistema, FechaHora_GPS, EventoPrioridad, VelocidadSentido, Edad_Posicion, Ubicacion, Latitud, Longitud,"RutaSatrackLastEvents");

				return rutasatracklastevents;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Updates an RutaSatrackLastEvents object by passing all object's fields
		/// </summary>
		/// <param name="Placa">string that contents the Placa value for the RutaSatrackLastEvents object</param>
		/// <param name="FechaSistema">DateTime that contents the FechaSistema value for the RutaSatrackLastEvents object</param>
		/// <param name="FechaHora_GPS">DateTime that contents the FechaHora_GPS value for the RutaSatrackLastEvents object</param>
		/// <param name="EventoPrioridad">string that contents the EventoPrioridad value for the RutaSatrackLastEvents object</param>
		/// <param name="VelocidadSentido">string that contents the VelocidadSentido value for the RutaSatrackLastEvents object</param>
		/// <param name="Edad_Posicion">string that contents the Edad_Posicion value for the RutaSatrackLastEvents object</param>
		/// <param name="Ubicacion">string that contents the Ubicacion value for the RutaSatrackLastEvents object</param>
		/// <param name="Latitud">decimal that contents the Latitud value for the RutaSatrackLastEvents object</param>
		/// <param name="Longitud">decimal that contents the Longitud value for the RutaSatrackLastEvents object</param>
		public void Update(string Placa, DateTime? FechaSistema, DateTime? FechaHora_GPS, string EventoPrioridad, string VelocidadSentido, string Edad_Posicion, string Ubicacion, decimal? Latitud, decimal? Longitud, Sinapsys.Datos.SQL datosTransaccion=null)
		{
			try 
			{
				RutaSatrackLastEvents new_values = new RutaSatrackLastEvents();
				new_values.FechaSistema = FechaSistema;
				new_values.FechaHora_GPS = FechaHora_GPS;
				new_values.EventoPrioridad = EventoPrioridad;
				new_values.VelocidadSentido = VelocidadSentido;
				new_values.Edad_Posicion = Edad_Posicion;
				new_values.Ubicacion = Ubicacion;
				new_values.Latitud = Latitud;
				new_values.Longitud = Longitud;
				RutaSatrackLastEventsDataProvider.Instance.Update(Placa, FechaSistema, FechaHora_GPS, EventoPrioridad, VelocidadSentido, Edad_Posicion, Ubicacion, Latitud, Longitud,"RutaSatrackLastEvents",datosTransaccion);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Updates an RutaSatrackLastEvents object by passing one object's instance as reference
		/// </summary>
		/// <param name="rutasatracklastevents">An instance of RutaSatrackLastEvents for reference</param>
		public void Update(RutaSatrackLastEvents rutasatracklastevents,Sinapsys.Datos.SQL datosTransaccion=null)
		{
			Update(rutasatracklastevents.Placa, rutasatracklastevents.FechaSistema, rutasatracklastevents.FechaHora_GPS, rutasatracklastevents.EventoPrioridad, rutasatracklastevents.VelocidadSentido, rutasatracklastevents.Edad_Posicion, rutasatracklastevents.Ubicacion, rutasatracklastevents.Latitud, rutasatracklastevents.Longitud);
		}

		/// <summary>
		/// Delete  the RutaSatrackLastEvents object by passing a object
		/// </summary>
		public void  Delete(RutaSatrackLastEvents rutasatracklastevents, Sinapsys.Datos.SQL datosTransaccion=null)
		{
			Delete(rutasatracklastevents.Placa,datosTransaccion);
		}

		/// <summary>
		/// Deletes the RutaSatrackLastEvents object by passing one object's instance as reference
		/// </summary>
		/// <param name="rutasatracklastevents">An instance of RutaSatrackLastEvents for reference</param>
		public void Delete(string Placa, Sinapsys.Datos.SQL datosTransaccion=null)
		{
			try 
			{
				RutaSatrackLastEventsDataProvider.Instance.Delete(Placa,"RutaSatrackLastEvents");
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Gets the RutaSatrackLastEvents object by passing the object's key fields
		/// </summary>
		/// <param name="Placa">string that contents the Placa value for the RutaSatrackLastEvents object</param>
		/// <returns>One RutaSatrackLastEvents object</returns>
		public RutaSatrackLastEvents Get(string Placa, bool generateUndo=false)
		{
			try 
			{
				RutaSatrackLastEvents rutasatracklastevents = null;
				DataTable dt = RutaSatrackLastEventsDataProvider.Instance.Get(Placa);
				if ((dt.Rows.Count > 0))
				{
					rutasatracklastevents = new RutaSatrackLastEvents();
					DataRow dr = dt.Rows[0];
					ReadData(rutasatracklastevents, dr, generateUndo);
				}


				return rutasatracklastevents;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Gets all objects of RutaSatrackLastEvents
		/// </summary>
		/// <returns>One RutaSatrackLastEventsList object</returns>
		public RutaSatrackLastEventsList GetAll(bool generateUndo=false)
		{
			try 
			{
				RutaSatrackLastEventsList rutasatracklasteventslist = new RutaSatrackLastEventsList();
				DataTable dt = RutaSatrackLastEventsDataProvider.Instance.GetAll();
				foreach (DataRow dr in dt.Rows)
				{
					RutaSatrackLastEvents rutasatracklastevents = new RutaSatrackLastEvents();
					ReadData(rutasatracklastevents, dr, generateUndo);
					rutasatracklasteventslist.Add(rutasatracklastevents);
				}
				return rutasatracklasteventslist;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Gets all objects of RutaSatrackLastEvents applying filter and sort criteria
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
		/// <returns>One RutaSatrackLastEventsList object</returns>
		public RutaSatrackLastEventsList GetFilter(int pagenum, int pagesize, string filter, string sort, string extablesfilter, string extablesfieldsfilter, string extablesrelationsfilter, string extablessort, string extablesfieldssort, string extablesrelationssort, bool generateUndo=false)
		{
			try 
			{
				RutaSatrackLastEventsList rutasatracklasteventslist = new RutaSatrackLastEventsList();

				DataTable dt = RutaSatrackLastEventsDataProvider.Instance.GetFilter(pagenum, pagesize, filter, sort, extablesfilter, extablesfieldsfilter, extablesrelationsfilter, extablessort, extablesfieldssort, extablesrelationssort);

				foreach (DataRow dr in dt.Rows)
				{
					RutaSatrackLastEvents rutasatracklastevents = new RutaSatrackLastEvents();
					ReadData(rutasatracklastevents, dr, generateUndo);
					rutasatracklasteventslist.Add(rutasatracklastevents);
				}
				return rutasatracklasteventslist;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public RutaSatrackLastEventsList GetFilter( string filter, string sort, bool generateUndo=false)
		{
			return GetFilter(0,0, filter, sort, "","","","","","",generateUndo);
		}

		public RutaSatrackLastEventsList GetFilter(string filter, string sort, string extablesfilter, string extablesfieldsfilter, string extablesrelationsfilter, string extablessort, string extablesfieldssort, string extablesrelationssort, bool generateUndo=false)
		{
			return GetFilter(0,0, filter, sort, extablesfilter, extablesfieldsfilter, extablesrelationsfilter, extablessort, extablesfieldssort, extablesrelationssort,generateUndo);
		}


		/// <summary>
		/// Returns the type for one property
		/// </summary>
		/// <param name="propertyname">Property's name for return its value</param>
		/// <returns>A value for the <paramref name="propertyname"/></returns>
		public Type GetMethodType( string propertyname,RutaSatrackLastEvents rutasatracklastevents)
		{
			// Perform the search for the property's value
			switch (propertyname)
			{
				case "Placa":
					return rutasatracklastevents.Placa.GetType();

				case "FechaSistema":
					return rutasatracklastevents.FechaSistema.GetType();

				case "FechaHora_GPS":
					return rutasatracklastevents.FechaHora_GPS.GetType();

				case "EventoPrioridad":
					return rutasatracklastevents.EventoPrioridad.GetType();

				case "VelocidadSentido":
					return rutasatracklastevents.VelocidadSentido.GetType();

				case "Edad_Posicion":
					return rutasatracklastevents.Edad_Posicion.GetType();

				case "Ubicacion":
					return rutasatracklastevents.Ubicacion.GetType();

				case "Latitud":
					return rutasatracklastevents.Latitud.GetType();

				case "Longitud":
					return rutasatracklastevents.Longitud.GetType();

			}

			return null;
		}
		/// <summary>
		/// update the changes in RutaSatrackLastEvents object by passing the object
		/// </summary>
		public bool UpdateChanges(RutaSatrackLastEvents rutasatracklastevents, out string error,Sinapsys.Datos.SQL datosTransaccion=null)
		{
			if (rutasatracklastevents.OldRutaSatrackLastEvents == null)
			{
				    error = "No tiene objeto con el cual comparar";
				    return false;
			}
			string[] Fields = rutasatracklastevents.FieldChanged();
			error = "";
			return LiqViajes_Bll_Data.DataProvider.UpdateFieldsbyObject(Fields, rutasatracklastevents, out error,datosTransaccion);
		}
	}

	#endregion

}
