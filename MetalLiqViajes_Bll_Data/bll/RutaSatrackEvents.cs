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
	#region RutaSatrackEventsController

	/// <summary>
	/// Class for convert data from database into object's data and vice versa
	/// </summary>
	public partial class RutaSatrackEventsController//: ILatinodeController
	{
		/// <summary>
		/// Generic Constructor
		/// </summary>
		public RutaSatrackEventsController()
		{
		}

		/// <summary>
		/// Instance accessor for this singleton
		/// </summary>
		private static RutaSatrackEventsController MySingleObj;
		public static RutaSatrackEventsController Instance
		{
			get
			{
				if (MySingleObj == null)
				{
					MySingleObj = new RutaSatrackEventsController();
				}
				return MySingleObj;
			}
		}

		// Reads object's data from a DataRow
		private void ReadData(RutaSatrackEvents rutasatrackevents, DataRow dr,bool generateUndo=false)
		{
			try 
			{
				rutasatrackevents.Clave_Respuesta = (long) dr["Clave_Respuesta"];
				rutasatrackevents.Placa = dr.IsNull("Placa") ? null :(string) dr["Placa"];
				rutasatrackevents.Descripcion = dr.IsNull("Descripcion") ? null :(string) dr["Descripcion"];
				rutasatrackevents.FechaHora_GPS = dr.IsNull("FechaHora_GPS") ? null :(DateTime?) dr["FechaHora_GPS"];
				rutasatrackevents.Velocidad = dr.IsNull("Velocidad") ? null :(int?) dr["Velocidad"];
				rutasatrackevents.Direccion = dr.IsNull("Direccion") ? null :(string) dr["Direccion"];
				rutasatrackevents.Direccion2 = dr.IsNull("Direccion2") ? null :(string) dr["Direccion2"];
				rutasatrackevents.DivPol1 = dr.IsNull("DivPol1") ? null :(string) dr["DivPol1"];
				rutasatrackevents.DivPol2 = dr.IsNull("DivPol2") ? null :(string) dr["DivPol2"];
				rutasatrackevents.DivPol3 = dr.IsNull("DivPol3") ? null :(string) dr["DivPol3"];
				rutasatrackevents.DivPol4 = dr.IsNull("DivPol4") ? null :(string) dr["DivPol4"];
				rutasatrackevents.SentidoLetras = dr.IsNull("SentidoLetras") ? null :(string) dr["SentidoLetras"];
				rutasatrackevents.Latitud = dr.IsNull("Latitud") ? null :(decimal?) dr["Latitud"];
				rutasatrackevents.Longitud = dr.IsNull("Longitud") ? null :(decimal?) dr["Longitud"];
				rutasatrackevents.TipoEventoUnificado = dr.IsNull("TipoEventoUnificado") ? null :(int?) dr["TipoEventoUnificado"];
				rutasatrackevents.CodigoNombre = dr.IsNull("CodigoNombre") ? null :(string) dr["CodigoNombre"];
			}
			catch (Exception ex)
			{
				Utilidades.LogErrores(ex.Message + (ex.InnerException != null ? ex.InnerException.Message : ""), DataProvider.AplicacionNombre);
				throw ex;
			}
			if (generateUndo) rutasatrackevents.GenerateUndo();
		}

		/// <summary>
		/// Create a new RutaSatrackEvents object by passing a object
		/// </summary>
		public RutaSatrackEvents Create(RutaSatrackEvents rutasatrackevents, Sinapsys.Datos.SQL datosTransaccion=null)
		{
			return Create(rutasatrackevents.Clave_Respuesta,rutasatrackevents.Placa,rutasatrackevents.Descripcion,rutasatrackevents.FechaHora_GPS,rutasatrackevents.Velocidad,rutasatrackevents.Direccion,rutasatrackevents.Direccion2,rutasatrackevents.DivPol1,rutasatrackevents.DivPol2,rutasatrackevents.DivPol3,rutasatrackevents.DivPol4,rutasatrackevents.SentidoLetras,rutasatrackevents.Latitud,rutasatrackevents.Longitud,rutasatrackevents.TipoEventoUnificado,rutasatrackevents.CodigoNombre,datosTransaccion);
		}

		/// <summary>
		/// Creates a new RutaSatrackEvents object by passing all object's fields
		/// </summary>
		/// <param name="Placa">string that contents the Placa value for the RutaSatrackEvents object</param>
		/// <param name="Descripcion">string that contents the Descripcion value for the RutaSatrackEvents object</param>
		/// <param name="FechaHora_GPS">DateTime that contents the FechaHora_GPS value for the RutaSatrackEvents object</param>
		/// <param name="Velocidad">int that contents the Velocidad value for the RutaSatrackEvents object</param>
		/// <param name="Direccion">string that contents the Direccion value for the RutaSatrackEvents object</param>
		/// <param name="Direccion2">string that contents the Direccion2 value for the RutaSatrackEvents object</param>
		/// <param name="DivPol1">string that contents the DivPol1 value for the RutaSatrackEvents object</param>
		/// <param name="DivPol2">string that contents the DivPol2 value for the RutaSatrackEvents object</param>
		/// <param name="DivPol3">string that contents the DivPol3 value for the RutaSatrackEvents object</param>
		/// <param name="DivPol4">string that contents the DivPol4 value for the RutaSatrackEvents object</param>
		/// <param name="SentidoLetras">string that contents the SentidoLetras value for the RutaSatrackEvents object</param>
		/// <param name="Latitud">decimal that contents the Latitud value for the RutaSatrackEvents object</param>
		/// <param name="Longitud">decimal that contents the Longitud value for the RutaSatrackEvents object</param>
		/// <param name="TipoEventoUnificado">int that contents the TipoEventoUnificado value for the RutaSatrackEvents object</param>
		/// <param name="CodigoNombre">string that contents the CodigoNombre value for the RutaSatrackEvents object</param>
		/// <returns>One RutaSatrackEvents object</returns>
		public RutaSatrackEvents Create(long Clave_Respuesta, string Placa, string Descripcion, DateTime? FechaHora_GPS, int? Velocidad, string Direccion, string Direccion2, string DivPol1, string DivPol2, string DivPol3, string DivPol4, string SentidoLetras, decimal? Latitud, decimal? Longitud, int? TipoEventoUnificado, string CodigoNombre, Sinapsys.Datos.SQL datosTransaccion=null)
		{
			try 
			{
				RutaSatrackEvents rutasatrackevents = new RutaSatrackEvents();

				rutasatrackevents.Clave_Respuesta = Clave_Respuesta;
				rutasatrackevents.Placa = Placa;
				rutasatrackevents.Descripcion = Descripcion;
				rutasatrackevents.FechaHora_GPS = FechaHora_GPS;
				rutasatrackevents.Velocidad = Velocidad;
				rutasatrackevents.Direccion = Direccion;
				rutasatrackevents.Direccion2 = Direccion2;
				rutasatrackevents.DivPol1 = DivPol1;
				rutasatrackevents.DivPol2 = DivPol2;
				rutasatrackevents.DivPol3 = DivPol3;
				rutasatrackevents.DivPol4 = DivPol4;
				rutasatrackevents.SentidoLetras = SentidoLetras;
				rutasatrackevents.Latitud = Latitud;
				rutasatrackevents.Longitud = Longitud;
				rutasatrackevents.TipoEventoUnificado = TipoEventoUnificado;
				rutasatrackevents.CodigoNombre = CodigoNombre;
				RutaSatrackEventsDataProvider.Instance.Create(Clave_Respuesta, Placa, Descripcion, FechaHora_GPS, Velocidad, Direccion, Direccion2, DivPol1, DivPol2, DivPol3, DivPol4, SentidoLetras, Latitud, Longitud, TipoEventoUnificado, CodigoNombre,"RutaSatrackEvents");

				return rutasatrackevents;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Updates an RutaSatrackEvents object by passing all object's fields
		/// </summary>
		/// <param name="Clave_Respuesta">long that contents the Clave_Respuesta value for the RutaSatrackEvents object</param>
		/// <param name="Placa">string that contents the Placa value for the RutaSatrackEvents object</param>
		/// <param name="Descripcion">string that contents the Descripcion value for the RutaSatrackEvents object</param>
		/// <param name="FechaHora_GPS">DateTime that contents the FechaHora_GPS value for the RutaSatrackEvents object</param>
		/// <param name="Velocidad">int that contents the Velocidad value for the RutaSatrackEvents object</param>
		/// <param name="Direccion">string that contents the Direccion value for the RutaSatrackEvents object</param>
		/// <param name="Direccion2">string that contents the Direccion2 value for the RutaSatrackEvents object</param>
		/// <param name="DivPol1">string that contents the DivPol1 value for the RutaSatrackEvents object</param>
		/// <param name="DivPol2">string that contents the DivPol2 value for the RutaSatrackEvents object</param>
		/// <param name="DivPol3">string that contents the DivPol3 value for the RutaSatrackEvents object</param>
		/// <param name="DivPol4">string that contents the DivPol4 value for the RutaSatrackEvents object</param>
		/// <param name="SentidoLetras">string that contents the SentidoLetras value for the RutaSatrackEvents object</param>
		/// <param name="Latitud">decimal that contents the Latitud value for the RutaSatrackEvents object</param>
		/// <param name="Longitud">decimal that contents the Longitud value for the RutaSatrackEvents object</param>
		/// <param name="TipoEventoUnificado">int that contents the TipoEventoUnificado value for the RutaSatrackEvents object</param>
		/// <param name="CodigoNombre">string that contents the CodigoNombre value for the RutaSatrackEvents object</param>
		public void Update(long Clave_Respuesta, string Placa, string Descripcion, DateTime? FechaHora_GPS, int? Velocidad, string Direccion, string Direccion2, string DivPol1, string DivPol2, string DivPol3, string DivPol4, string SentidoLetras, decimal? Latitud, decimal? Longitud, int? TipoEventoUnificado, string CodigoNombre, Sinapsys.Datos.SQL datosTransaccion=null)
		{
			try 
			{
				RutaSatrackEvents new_values = new RutaSatrackEvents();
				new_values.Placa = Placa;
				new_values.Descripcion = Descripcion;
				new_values.FechaHora_GPS = FechaHora_GPS;
				new_values.Velocidad = Velocidad;
				new_values.Direccion = Direccion;
				new_values.Direccion2 = Direccion2;
				new_values.DivPol1 = DivPol1;
				new_values.DivPol2 = DivPol2;
				new_values.DivPol3 = DivPol3;
				new_values.DivPol4 = DivPol4;
				new_values.SentidoLetras = SentidoLetras;
				new_values.Latitud = Latitud;
				new_values.Longitud = Longitud;
				new_values.TipoEventoUnificado = TipoEventoUnificado;
				new_values.CodigoNombre = CodigoNombre;
				RutaSatrackEventsDataProvider.Instance.Update(Clave_Respuesta, Placa, Descripcion, FechaHora_GPS, Velocidad, Direccion, Direccion2, DivPol1, DivPol2, DivPol3, DivPol4, SentidoLetras, Latitud, Longitud, TipoEventoUnificado, CodigoNombre,"RutaSatrackEvents",datosTransaccion);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Updates an RutaSatrackEvents object by passing one object's instance as reference
		/// </summary>
		/// <param name="rutasatrackevents">An instance of RutaSatrackEvents for reference</param>
		public void Update(RutaSatrackEvents rutasatrackevents,Sinapsys.Datos.SQL datosTransaccion=null)
		{
			Update(rutasatrackevents.Clave_Respuesta, rutasatrackevents.Placa, rutasatrackevents.Descripcion, rutasatrackevents.FechaHora_GPS, rutasatrackevents.Velocidad, rutasatrackevents.Direccion, rutasatrackevents.Direccion2, rutasatrackevents.DivPol1, rutasatrackevents.DivPol2, rutasatrackevents.DivPol3, rutasatrackevents.DivPol4, rutasatrackevents.SentidoLetras, rutasatrackevents.Latitud, rutasatrackevents.Longitud, rutasatrackevents.TipoEventoUnificado, rutasatrackevents.CodigoNombre);
		}

		/// <summary>
		/// Delete  the RutaSatrackEvents object by passing a object
		/// </summary>
		public void  Delete(RutaSatrackEvents rutasatrackevents, Sinapsys.Datos.SQL datosTransaccion=null)
		{
			Delete(rutasatrackevents.Clave_Respuesta,datosTransaccion);
		}

		/// <summary>
		/// Deletes the RutaSatrackEvents object by passing one object's instance as reference
		/// </summary>
		/// <param name="rutasatrackevents">An instance of RutaSatrackEvents for reference</param>
		public void Delete(long Clave_Respuesta, Sinapsys.Datos.SQL datosTransaccion=null)
		{
			try 
			{
				RutaSatrackEventsDataProvider.Instance.Delete(Clave_Respuesta,"RutaSatrackEvents");
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Deletes the RutaSatrackEvents object by passing CVS parameter as reference
		/// </summary>
		/// <param name="rutasatrackevents">An instance of RutaSatrackEvents for reference</param>
		public void Delete(string CVSParameter)
		{
			string[] StrCommand=CVSParameter.Split(',');
			try 
			{
				long Clave_Respuesta=long.Parse(StrCommand[0]);
				RutaSatrackEventsDataProvider.Instance.Delete(Clave_Respuesta,"RutaSatrackEvents");
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Gets the RutaSatrackEvents object by passing the object's key fields
		/// </summary>
		/// <param name="Clave_Respuesta">long that contents the Clave_Respuesta value for the RutaSatrackEvents object</param>
		/// <returns>One RutaSatrackEvents object</returns>
		public RutaSatrackEvents Get(long Clave_Respuesta, bool generateUndo=false)
		{
			try 
			{
				RutaSatrackEvents rutasatrackevents = null;
				DataTable dt = RutaSatrackEventsDataProvider.Instance.Get(Clave_Respuesta);
				if ((dt.Rows.Count > 0))
				{
					rutasatrackevents = new RutaSatrackEvents();
					DataRow dr = dt.Rows[0];
					ReadData(rutasatrackevents, dr, generateUndo);
				}


				return rutasatrackevents;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Gets all objects of RutaSatrackEvents
		/// </summary>
		/// <returns>One RutaSatrackEventsList object</returns>
		public RutaSatrackEventsList GetAll(bool generateUndo=false)
		{
			try 
			{
				RutaSatrackEventsList rutasatrackeventslist = new RutaSatrackEventsList();
				DataTable dt = RutaSatrackEventsDataProvider.Instance.GetAll();
				foreach (DataRow dr in dt.Rows)
				{
					RutaSatrackEvents rutasatrackevents = new RutaSatrackEvents();
					ReadData(rutasatrackevents, dr, generateUndo);
					rutasatrackeventslist.Add(rutasatrackevents);
				}
				return rutasatrackeventslist;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Gets all objects of RutaSatrackEvents applying filter and sort criteria
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
		/// <returns>One RutaSatrackEventsList object</returns>
		public RutaSatrackEventsList GetFilter(int pagenum, int pagesize, string filter, string sort, string extablesfilter, string extablesfieldsfilter, string extablesrelationsfilter, string extablessort, string extablesfieldssort, string extablesrelationssort, bool generateUndo=false)
		{
			try 
			{
				RutaSatrackEventsList rutasatrackeventslist = new RutaSatrackEventsList();

				DataTable dt = RutaSatrackEventsDataProvider.Instance.GetFilter(pagenum, pagesize, filter, sort, extablesfilter, extablesfieldsfilter, extablesrelationsfilter, extablessort, extablesfieldssort, extablesrelationssort);

				foreach (DataRow dr in dt.Rows)
				{
					RutaSatrackEvents rutasatrackevents = new RutaSatrackEvents();
					ReadData(rutasatrackevents, dr, generateUndo);
					rutasatrackeventslist.Add(rutasatrackevents);
				}
				return rutasatrackeventslist;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public RutaSatrackEventsList GetFilter( string filter, string sort, bool generateUndo=false)
		{
			return GetFilter(0,0, filter, sort, "","","","","","",generateUndo);
		}

		public RutaSatrackEventsList GetFilter(string filter, string sort, string extablesfilter, string extablesfieldsfilter, string extablesrelationsfilter, string extablessort, string extablesfieldssort, string extablesrelationssort, bool generateUndo=false)
		{
			return GetFilter(0,0, filter, sort, extablesfilter, extablesfieldsfilter, extablesrelationsfilter, extablessort, extablesfieldssort, extablesrelationssort,generateUndo);
		}


		/// <summary>
		/// Returns the type for one property
		/// </summary>
		/// <param name="propertyname">Property's name for return its value</param>
		/// <returns>A value for the <paramref name="propertyname"/></returns>
		public Type GetMethodType( string propertyname,RutaSatrackEvents rutasatrackevents)
		{
			// Perform the search for the property's value
			switch (propertyname)
			{
				case "Clave_Respuesta":
					return rutasatrackevents.Clave_Respuesta.GetType();

				case "Placa":
					return rutasatrackevents.Placa.GetType();

				case "Descripcion":
					return rutasatrackevents.Descripcion.GetType();

				case "FechaHora_GPS":
					return rutasatrackevents.FechaHora_GPS.GetType();

				case "Velocidad":
					return rutasatrackevents.Velocidad.GetType();

				case "Direccion":
					return rutasatrackevents.Direccion.GetType();

				case "Direccion2":
					return rutasatrackevents.Direccion2.GetType();

				case "DivPol1":
					return rutasatrackevents.DivPol1.GetType();

				case "DivPol2":
					return rutasatrackevents.DivPol2.GetType();

				case "DivPol3":
					return rutasatrackevents.DivPol3.GetType();

				case "DivPol4":
					return rutasatrackevents.DivPol4.GetType();

				case "SentidoLetras":
					return rutasatrackevents.SentidoLetras.GetType();

				case "Latitud":
					return rutasatrackevents.Latitud.GetType();

				case "Longitud":
					return rutasatrackevents.Longitud.GetType();

				case "TipoEventoUnificado":
					return rutasatrackevents.TipoEventoUnificado.GetType();

				case "CodigoNombre":
					return rutasatrackevents.CodigoNombre.GetType();

			}

			return null;
		}
		/// <summary>
		/// update the changes in RutaSatrackEvents object by passing the object
		/// </summary>
		public bool UpdateChanges(RutaSatrackEvents rutasatrackevents, out string error,Sinapsys.Datos.SQL datosTransaccion=null)
		{
			if (rutasatrackevents.OldRutaSatrackEvents == null)
			{
				    error = "No tiene objeto con el cual comparar";
				    return false;
			}
			string[] Fields = rutasatrackevents.FieldChanged();
			error = "";
			return LiqViajes_Bll_Data.DataProvider.UpdateFieldsbyObject(Fields, rutasatrackevents, out error,datosTransaccion);
		}
	}

	#endregion

}
