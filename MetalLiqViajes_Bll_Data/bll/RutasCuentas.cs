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
	#region RutasCuentasController

	/// <summary>
	/// Class for convert data from database into object's data and vice versa
	/// </summary>
	public partial class RutasCuentasController//: ILatinodeController
	{
		/// <summary>
		/// Generic Constructor
		/// </summary>
		public RutasCuentasController()
		{
		}

		/// <summary>
		/// Instance accessor for this singleton
		/// </summary>
		private static RutasCuentasController MySingleObj;
		public static RutasCuentasController Instance
		{
			get
			{
				if (MySingleObj == null)
				{
					MySingleObj = new RutasCuentasController();
				}
				return MySingleObj;
			}
		}

		// Reads object's data from a DataRow
		private void ReadData(RutasCuentas rutascuentas, DataRow dr,bool generateUndo=false)
		{
			try 
			{
				rutascuentas.lngIdRegistrRuta = (int) dr["lngIdRegistrRuta"];
				rutascuentas.cutCombustible = dr.IsNull("cutCombustible") ? null :(string) dr["cutCombustible"];
				rutascuentas.cutPeaje = dr.IsNull("cutPeaje") ? null :(string) dr["cutPeaje"];
				rutascuentas.cutVariosLlantas = dr.IsNull("cutVariosLlantas") ? null :(string) dr["cutVariosLlantas"];
				rutascuentas.cutVariosCelada = dr.IsNull("cutVariosCelada") ? null :(string) dr["cutVariosCelada"];
				rutascuentas.cutVariosPropina = dr.IsNull("cutVariosPropina") ? null :(string) dr["cutVariosPropina"];
				rutascuentas.cutVarios = dr.IsNull("cutVarios") ? null :(string) dr["cutVarios"];
				rutascuentas.cutVariosLlantasVacio = (string) dr["cutVariosLlantasVacio"];
				rutascuentas.cutVariosCeladaVacio = dr.IsNull("cutVariosCeladaVacio") ? null :(string) dr["cutVariosCeladaVacio"];
				rutascuentas.cutVariosPropinaVacio = dr.IsNull("cutVariosPropinaVacio") ? null :(string) dr["cutVariosPropinaVacio"];
				rutascuentas.cutVariosVacio = dr.IsNull("cutVariosVacio") ? null :(string) dr["cutVariosVacio"];
				rutascuentas.cutParticipacion = dr.IsNull("cutParticipacion") ? null :(string) dr["cutParticipacion"];
				rutascuentas.cutParticipacionVacio = dr.IsNull("cutParticipacionVacio") ? null :(string) dr["cutParticipacionVacio"];
				rutascuentas.curHotel = dr.IsNull("curHotel") ? null :(string) dr["curHotel"];
				rutascuentas.curHotelVacio = dr.IsNull("curHotelVacio") ? null :(string) dr["curHotelVacio"];
				rutascuentas.curComida = dr.IsNull("curComida") ? null :(string) dr["curComida"];
				rutascuentas.curComidaVacio = dr.IsNull("curComidaVacio") ? null :(string) dr["curComidaVacio"];
				rutascuentas.curDesvareManoRepuestos = dr.IsNull("curDesvareManoRepuestos") ? null :(string) dr["curDesvareManoRepuestos"];
				rutascuentas.curDesvareManoObra = dr.IsNull("curDesvareManoObra") ? null :(string) dr["curDesvareManoObra"];
				rutascuentas.cutSaldo = dr.IsNull("cutSaldo") ? null :(string) dr["cutSaldo"];
				rutascuentas.cutKmts = dr.IsNull("cutKmts") ? null :(string) dr["cutKmts"];
				rutascuentas.ParqueaderoCarretera = dr.IsNull("ParqueaderoCarretera") ? null :(string) dr["ParqueaderoCarretera"];
				rutascuentas.ParqueaderoCiudad = dr.IsNull("ParqueaderoCiudad") ? null :(string) dr["ParqueaderoCiudad"];
				rutascuentas.MontadaLLantaCarretera = dr.IsNull("MontadaLLantaCarretera") ? null :(string) dr["MontadaLLantaCarretera"];
				rutascuentas.Papeleria = dr.IsNull("Papeleria") ? null :(string) dr["Papeleria"];
				rutascuentas.AjusteCarretera = dr.IsNull("AjusteCarretera") ? null :(string) dr["AjusteCarretera"];
				rutascuentas.Aseo = dr.IsNull("Aseo") ? null :(string) dr["Aseo"];
				rutascuentas.Amarres = dr.IsNull("Amarres") ? null :(string) dr["Amarres"];
				rutascuentas.Engradasa = dr.IsNull("Engradasa") ? null :(string) dr["Engradasa"];
				rutascuentas.Calibrada = dr.IsNull("Calibrada") ? null :(string) dr["Calibrada"];
				rutascuentas.Taxi = dr.IsNull("Taxi") ? null :(string) dr["Taxi"];
				rutascuentas.Lavada = dr.IsNull("Lavada") ? null :(string) dr["Lavada"];
				rutascuentas.CombustibleCarretera = dr.IsNull("CombustibleCarretera") ? null :(string) dr["CombustibleCarretera"];
				rutascuentas.CurCargue = dr.IsNull("CurCargue") ? null :(string) dr["CurCargue"];
				rutascuentas.CurDescargue = dr.IsNull("CurDescargue") ? null :(string) dr["CurDescargue"];
			}
			catch (Exception ex)
			{
				Utilidades.LogErrores(ex.Message + (ex.InnerException != null ? ex.InnerException.Message : ""), DataProvider.AplicacionNombre);
				throw ex;
			}
			if (generateUndo) rutascuentas.GenerateUndo();
		}

		/// <summary>
		/// Create a new RutasCuentas object by passing a object
		/// </summary>
		public RutasCuentas Create(RutasCuentas rutascuentas, Sinapsys.Datos.SQL datosTransaccion=null)
		{
			return Create(rutascuentas.lngIdRegistrRuta,rutascuentas.cutCombustible,rutascuentas.cutPeaje,rutascuentas.cutVariosLlantas,rutascuentas.cutVariosCelada,rutascuentas.cutVariosPropina,rutascuentas.cutVarios,rutascuentas.cutVariosLlantasVacio,rutascuentas.cutVariosCeladaVacio,rutascuentas.cutVariosPropinaVacio,rutascuentas.cutVariosVacio,rutascuentas.cutParticipacion,rutascuentas.cutParticipacionVacio,rutascuentas.curHotel,rutascuentas.curHotelVacio,rutascuentas.curComida,rutascuentas.curComidaVacio,rutascuentas.curDesvareManoRepuestos,rutascuentas.curDesvareManoObra,rutascuentas.cutSaldo,rutascuentas.cutKmts,rutascuentas.ParqueaderoCarretera,rutascuentas.ParqueaderoCiudad,rutascuentas.MontadaLLantaCarretera,rutascuentas.Papeleria,rutascuentas.AjusteCarretera,rutascuentas.Aseo,rutascuentas.Amarres,rutascuentas.Engradasa,rutascuentas.Calibrada,rutascuentas.Taxi,rutascuentas.Lavada,rutascuentas.CombustibleCarretera,rutascuentas.CurCargue,rutascuentas.CurDescargue,datosTransaccion);
		}

		/// <summary>
		/// Creates a new RutasCuentas object by passing all object's fields
		/// </summary>
		/// <param name="cutCombustible">string that contents the cutCombustible value for the RutasCuentas object</param>
		/// <param name="cutPeaje">string that contents the cutPeaje value for the RutasCuentas object</param>
		/// <param name="cutVariosLlantas">string that contents the cutVariosLlantas value for the RutasCuentas object</param>
		/// <param name="cutVariosCelada">string that contents the cutVariosCelada value for the RutasCuentas object</param>
		/// <param name="cutVariosPropina">string that contents the cutVariosPropina value for the RutasCuentas object</param>
		/// <param name="cutVarios">string that contents the cutVarios value for the RutasCuentas object</param>
		/// <param name="cutVariosLlantasVacio">string that contents the cutVariosLlantasVacio value for the RutasCuentas object</param>
		/// <param name="cutVariosCeladaVacio">string that contents the cutVariosCeladaVacio value for the RutasCuentas object</param>
		/// <param name="cutVariosPropinaVacio">string that contents the cutVariosPropinaVacio value for the RutasCuentas object</param>
		/// <param name="cutVariosVacio">string that contents the cutVariosVacio value for the RutasCuentas object</param>
		/// <param name="cutParticipacion">string that contents the cutParticipacion value for the RutasCuentas object</param>
		/// <param name="cutParticipacionVacio">string that contents the cutParticipacionVacio value for the RutasCuentas object</param>
		/// <param name="curHotel">string that contents the curHotel value for the RutasCuentas object</param>
		/// <param name="curHotelVacio">string that contents the curHotelVacio value for the RutasCuentas object</param>
		/// <param name="curComida">string that contents the curComida value for the RutasCuentas object</param>
		/// <param name="curComidaVacio">string that contents the curComidaVacio value for the RutasCuentas object</param>
		/// <param name="curDesvareManoRepuestos">string that contents the curDesvareManoRepuestos value for the RutasCuentas object</param>
		/// <param name="curDesvareManoObra">string that contents the curDesvareManoObra value for the RutasCuentas object</param>
		/// <param name="cutSaldo">string that contents the cutSaldo value for the RutasCuentas object</param>
		/// <param name="cutKmts">string that contents the cutKmts value for the RutasCuentas object</param>
		/// <param name="ParqueaderoCarretera">string that contents the ParqueaderoCarretera value for the RutasCuentas object</param>
		/// <param name="ParqueaderoCiudad">string that contents the ParqueaderoCiudad value for the RutasCuentas object</param>
		/// <param name="MontadaLLantaCarretera">string that contents the MontadaLLantaCarretera value for the RutasCuentas object</param>
		/// <param name="Papeleria">string that contents the Papeleria value for the RutasCuentas object</param>
		/// <param name="AjusteCarretera">string that contents the AjusteCarretera value for the RutasCuentas object</param>
		/// <param name="Aseo">string that contents the Aseo value for the RutasCuentas object</param>
		/// <param name="Amarres">string that contents the Amarres value for the RutasCuentas object</param>
		/// <param name="Engradasa">string that contents the Engradasa value for the RutasCuentas object</param>
		/// <param name="Calibrada">string that contents the Calibrada value for the RutasCuentas object</param>
		/// <param name="Taxi">string that contents the Taxi value for the RutasCuentas object</param>
		/// <param name="Lavada">string that contents the Lavada value for the RutasCuentas object</param>
		/// <param name="CombustibleCarretera">string that contents the CombustibleCarretera value for the RutasCuentas object</param>
		/// <param name="CurCargue">string that contents the CurCargue value for the RutasCuentas object</param>
		/// <param name="CurDescargue">string that contents the CurDescargue value for the RutasCuentas object</param>
		/// <returns>One RutasCuentas object</returns>
		public RutasCuentas Create(int lngIdRegistrRuta, string cutCombustible, string cutPeaje, string cutVariosLlantas, string cutVariosCelada, string cutVariosPropina, string cutVarios, string cutVariosLlantasVacio, string cutVariosCeladaVacio, string cutVariosPropinaVacio, string cutVariosVacio, string cutParticipacion, string cutParticipacionVacio, string curHotel, string curHotelVacio, string curComida, string curComidaVacio, string curDesvareManoRepuestos, string curDesvareManoObra, string cutSaldo, string cutKmts, string ParqueaderoCarretera, string ParqueaderoCiudad, string MontadaLLantaCarretera, string Papeleria, string AjusteCarretera, string Aseo, string Amarres, string Engradasa, string Calibrada, string Taxi, string Lavada, string CombustibleCarretera, string CurCargue, string CurDescargue, Sinapsys.Datos.SQL datosTransaccion=null)
		{
			try 
			{
				RutasCuentas rutascuentas = new RutasCuentas();

				rutascuentas.lngIdRegistrRuta = lngIdRegistrRuta;
				rutascuentas.cutCombustible = cutCombustible;
				rutascuentas.cutPeaje = cutPeaje;
				rutascuentas.cutVariosLlantas = cutVariosLlantas;
				rutascuentas.cutVariosCelada = cutVariosCelada;
				rutascuentas.cutVariosPropina = cutVariosPropina;
				rutascuentas.cutVarios = cutVarios;
				rutascuentas.cutVariosLlantasVacio = cutVariosLlantasVacio;
				rutascuentas.cutVariosCeladaVacio = cutVariosCeladaVacio;
				rutascuentas.cutVariosPropinaVacio = cutVariosPropinaVacio;
				rutascuentas.cutVariosVacio = cutVariosVacio;
				rutascuentas.cutParticipacion = cutParticipacion;
				rutascuentas.cutParticipacionVacio = cutParticipacionVacio;
				rutascuentas.curHotel = curHotel;
				rutascuentas.curHotelVacio = curHotelVacio;
				rutascuentas.curComida = curComida;
				rutascuentas.curComidaVacio = curComidaVacio;
				rutascuentas.curDesvareManoRepuestos = curDesvareManoRepuestos;
				rutascuentas.curDesvareManoObra = curDesvareManoObra;
				rutascuentas.cutSaldo = cutSaldo;
				rutascuentas.cutKmts = cutKmts;
				rutascuentas.ParqueaderoCarretera = ParqueaderoCarretera;
				rutascuentas.ParqueaderoCiudad = ParqueaderoCiudad;
				rutascuentas.MontadaLLantaCarretera = MontadaLLantaCarretera;
				rutascuentas.Papeleria = Papeleria;
				rutascuentas.AjusteCarretera = AjusteCarretera;
				rutascuentas.Aseo = Aseo;
				rutascuentas.Amarres = Amarres;
				rutascuentas.Engradasa = Engradasa;
				rutascuentas.Calibrada = Calibrada;
				rutascuentas.Taxi = Taxi;
				rutascuentas.Lavada = Lavada;
				rutascuentas.CombustibleCarretera = CombustibleCarretera;
				rutascuentas.CurCargue = CurCargue;
				rutascuentas.CurDescargue = CurDescargue;
				RutasCuentasDataProvider.Instance.Create(lngIdRegistrRuta, cutCombustible, cutPeaje, cutVariosLlantas, cutVariosCelada, cutVariosPropina, cutVarios, cutVariosLlantasVacio, cutVariosCeladaVacio, cutVariosPropinaVacio, cutVariosVacio, cutParticipacion, cutParticipacionVacio, curHotel, curHotelVacio, curComida, curComidaVacio, curDesvareManoRepuestos, curDesvareManoObra, cutSaldo, cutKmts, ParqueaderoCarretera, ParqueaderoCiudad, MontadaLLantaCarretera, Papeleria, AjusteCarretera, Aseo, Amarres, Engradasa, Calibrada, Taxi, Lavada, CombustibleCarretera, CurCargue, CurDescargue,"RutasCuentas");

				return rutascuentas;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Updates an RutasCuentas object by passing all object's fields
		/// </summary>
		/// <param name="lngIdRegistrRuta">int that contents the lngIdRegistrRuta value for the RutasCuentas object</param>
		/// <param name="cutCombustible">string that contents the cutCombustible value for the RutasCuentas object</param>
		/// <param name="cutPeaje">string that contents the cutPeaje value for the RutasCuentas object</param>
		/// <param name="cutVariosLlantas">string that contents the cutVariosLlantas value for the RutasCuentas object</param>
		/// <param name="cutVariosCelada">string that contents the cutVariosCelada value for the RutasCuentas object</param>
		/// <param name="cutVariosPropina">string that contents the cutVariosPropina value for the RutasCuentas object</param>
		/// <param name="cutVarios">string that contents the cutVarios value for the RutasCuentas object</param>
		/// <param name="cutVariosLlantasVacio">string that contents the cutVariosLlantasVacio value for the RutasCuentas object</param>
		/// <param name="cutVariosCeladaVacio">string that contents the cutVariosCeladaVacio value for the RutasCuentas object</param>
		/// <param name="cutVariosPropinaVacio">string that contents the cutVariosPropinaVacio value for the RutasCuentas object</param>
		/// <param name="cutVariosVacio">string that contents the cutVariosVacio value for the RutasCuentas object</param>
		/// <param name="cutParticipacion">string that contents the cutParticipacion value for the RutasCuentas object</param>
		/// <param name="cutParticipacionVacio">string that contents the cutParticipacionVacio value for the RutasCuentas object</param>
		/// <param name="curHotel">string that contents the curHotel value for the RutasCuentas object</param>
		/// <param name="curHotelVacio">string that contents the curHotelVacio value for the RutasCuentas object</param>
		/// <param name="curComida">string that contents the curComida value for the RutasCuentas object</param>
		/// <param name="curComidaVacio">string that contents the curComidaVacio value for the RutasCuentas object</param>
		/// <param name="curDesvareManoRepuestos">string that contents the curDesvareManoRepuestos value for the RutasCuentas object</param>
		/// <param name="curDesvareManoObra">string that contents the curDesvareManoObra value for the RutasCuentas object</param>
		/// <param name="cutSaldo">string that contents the cutSaldo value for the RutasCuentas object</param>
		/// <param name="cutKmts">string that contents the cutKmts value for the RutasCuentas object</param>
		/// <param name="ParqueaderoCarretera">string that contents the ParqueaderoCarretera value for the RutasCuentas object</param>
		/// <param name="ParqueaderoCiudad">string that contents the ParqueaderoCiudad value for the RutasCuentas object</param>
		/// <param name="MontadaLLantaCarretera">string that contents the MontadaLLantaCarretera value for the RutasCuentas object</param>
		/// <param name="Papeleria">string that contents the Papeleria value for the RutasCuentas object</param>
		/// <param name="AjusteCarretera">string that contents the AjusteCarretera value for the RutasCuentas object</param>
		/// <param name="Aseo">string that contents the Aseo value for the RutasCuentas object</param>
		/// <param name="Amarres">string that contents the Amarres value for the RutasCuentas object</param>
		/// <param name="Engradasa">string that contents the Engradasa value for the RutasCuentas object</param>
		/// <param name="Calibrada">string that contents the Calibrada value for the RutasCuentas object</param>
		/// <param name="Taxi">string that contents the Taxi value for the RutasCuentas object</param>
		/// <param name="Lavada">string that contents the Lavada value for the RutasCuentas object</param>
		/// <param name="CombustibleCarretera">string that contents the CombustibleCarretera value for the RutasCuentas object</param>
		/// <param name="CurCargue">string that contents the CurCargue value for the RutasCuentas object</param>
		/// <param name="CurDescargue">string that contents the CurDescargue value for the RutasCuentas object</param>
		public void Update(int lngIdRegistrRuta, string cutCombustible, string cutPeaje, string cutVariosLlantas, string cutVariosCelada, string cutVariosPropina, string cutVarios, string cutVariosLlantasVacio, string cutVariosCeladaVacio, string cutVariosPropinaVacio, string cutVariosVacio, string cutParticipacion, string cutParticipacionVacio, string curHotel, string curHotelVacio, string curComida, string curComidaVacio, string curDesvareManoRepuestos, string curDesvareManoObra, string cutSaldo, string cutKmts, string ParqueaderoCarretera, string ParqueaderoCiudad, string MontadaLLantaCarretera, string Papeleria, string AjusteCarretera, string Aseo, string Amarres, string Engradasa, string Calibrada, string Taxi, string Lavada, string CombustibleCarretera, string CurCargue, string CurDescargue, Sinapsys.Datos.SQL datosTransaccion=null)
		{
			try 
			{
				RutasCuentas new_values = new RutasCuentas();
				new_values.cutCombustible = cutCombustible;
				new_values.cutPeaje = cutPeaje;
				new_values.cutVariosLlantas = cutVariosLlantas;
				new_values.cutVariosCelada = cutVariosCelada;
				new_values.cutVariosPropina = cutVariosPropina;
				new_values.cutVarios = cutVarios;
				new_values.cutVariosLlantasVacio = cutVariosLlantasVacio;
				new_values.cutVariosCeladaVacio = cutVariosCeladaVacio;
				new_values.cutVariosPropinaVacio = cutVariosPropinaVacio;
				new_values.cutVariosVacio = cutVariosVacio;
				new_values.cutParticipacion = cutParticipacion;
				new_values.cutParticipacionVacio = cutParticipacionVacio;
				new_values.curHotel = curHotel;
				new_values.curHotelVacio = curHotelVacio;
				new_values.curComida = curComida;
				new_values.curComidaVacio = curComidaVacio;
				new_values.curDesvareManoRepuestos = curDesvareManoRepuestos;
				new_values.curDesvareManoObra = curDesvareManoObra;
				new_values.cutSaldo = cutSaldo;
				new_values.cutKmts = cutKmts;
				new_values.ParqueaderoCarretera = ParqueaderoCarretera;
				new_values.ParqueaderoCiudad = ParqueaderoCiudad;
				new_values.MontadaLLantaCarretera = MontadaLLantaCarretera;
				new_values.Papeleria = Papeleria;
				new_values.AjusteCarretera = AjusteCarretera;
				new_values.Aseo = Aseo;
				new_values.Amarres = Amarres;
				new_values.Engradasa = Engradasa;
				new_values.Calibrada = Calibrada;
				new_values.Taxi = Taxi;
				new_values.Lavada = Lavada;
				new_values.CombustibleCarretera = CombustibleCarretera;
				new_values.CurCargue = CurCargue;
				new_values.CurDescargue = CurDescargue;
				RutasCuentasDataProvider.Instance.Update(lngIdRegistrRuta, cutCombustible, cutPeaje, cutVariosLlantas, cutVariosCelada, cutVariosPropina, cutVarios, cutVariosLlantasVacio, cutVariosCeladaVacio, cutVariosPropinaVacio, cutVariosVacio, cutParticipacion, cutParticipacionVacio, curHotel, curHotelVacio, curComida, curComidaVacio, curDesvareManoRepuestos, curDesvareManoObra, cutSaldo, cutKmts, ParqueaderoCarretera, ParqueaderoCiudad, MontadaLLantaCarretera, Papeleria, AjusteCarretera, Aseo, Amarres, Engradasa, Calibrada, Taxi, Lavada, CombustibleCarretera, CurCargue, CurDescargue,"RutasCuentas",datosTransaccion);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Updates an RutasCuentas object by passing one object's instance as reference
		/// </summary>
		/// <param name="rutascuentas">An instance of RutasCuentas for reference</param>
		public void Update(RutasCuentas rutascuentas,Sinapsys.Datos.SQL datosTransaccion=null)
		{
			Update(rutascuentas.lngIdRegistrRuta, rutascuentas.cutCombustible, rutascuentas.cutPeaje, rutascuentas.cutVariosLlantas, rutascuentas.cutVariosCelada, rutascuentas.cutVariosPropina, rutascuentas.cutVarios, rutascuentas.cutVariosLlantasVacio, rutascuentas.cutVariosCeladaVacio, rutascuentas.cutVariosPropinaVacio, rutascuentas.cutVariosVacio, rutascuentas.cutParticipacion, rutascuentas.cutParticipacionVacio, rutascuentas.curHotel, rutascuentas.curHotelVacio, rutascuentas.curComida, rutascuentas.curComidaVacio, rutascuentas.curDesvareManoRepuestos, rutascuentas.curDesvareManoObra, rutascuentas.cutSaldo, rutascuentas.cutKmts, rutascuentas.ParqueaderoCarretera, rutascuentas.ParqueaderoCiudad, rutascuentas.MontadaLLantaCarretera, rutascuentas.Papeleria, rutascuentas.AjusteCarretera, rutascuentas.Aseo, rutascuentas.Amarres, rutascuentas.Engradasa, rutascuentas.Calibrada, rutascuentas.Taxi, rutascuentas.Lavada, rutascuentas.CombustibleCarretera, rutascuentas.CurCargue, rutascuentas.CurDescargue);
		}

		/// <summary>
		/// Delete  the RutasCuentas object by passing a object
		/// </summary>
		public void  Delete(RutasCuentas rutascuentas, Sinapsys.Datos.SQL datosTransaccion=null)
		{
			Delete(rutascuentas.lngIdRegistrRuta,datosTransaccion);
		}

		/// <summary>
		/// Deletes the RutasCuentas object by passing one object's instance as reference
		/// </summary>
		/// <param name="rutascuentas">An instance of RutasCuentas for reference</param>
		public void Delete(int lngIdRegistrRuta, Sinapsys.Datos.SQL datosTransaccion=null)
		{
			try 
			{
				RutasCuentasDataProvider.Instance.Delete(lngIdRegistrRuta,"RutasCuentas");
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Deletes the RutasCuentas object by passing CVS parameter as reference
		/// </summary>
		/// <param name="rutascuentas">An instance of RutasCuentas for reference</param>
		public void Delete(string CVSParameter)
		{
			string[] StrCommand=CVSParameter.Split(',');
			try 
			{
				int lngIdRegistrRuta=int.Parse(StrCommand[0]);
				RutasCuentasDataProvider.Instance.Delete(lngIdRegistrRuta,"RutasCuentas");
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Gets the RutasCuentas object by passing the object's key fields
		/// </summary>
		/// <param name="lngIdRegistrRuta">int that contents the lngIdRegistrRuta value for the RutasCuentas object</param>
		/// <returns>One RutasCuentas object</returns>
		public RutasCuentas Get(int lngIdRegistrRuta, bool generateUndo=false)
		{
			try 
			{
				RutasCuentas rutascuentas = null;
				rutascuentas= MasterTables.RutasCuentas.Where(r => r.lngIdRegistrRuta== lngIdRegistrRuta).FirstOrDefault();
				if (rutascuentas== null)
				{
					MasterTables.Reset("RutasCuentas");
					rutascuentas= MasterTables.RutasCuentas.Where(r => r.lngIdRegistrRuta== lngIdRegistrRuta).FirstOrDefault();
				}
				if (generateUndo) rutascuentas.GenerateUndo();

				return rutascuentas;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Gets all objects of RutasCuentas
		/// </summary>
		/// <returns>One RutasCuentasList object</returns>
		public RutasCuentasList GetAll(bool generateUndo=false)
		{
			try 
			{
				RutasCuentasList rutascuentaslist = new RutasCuentasList();
				DataTable dt = RutasCuentasDataProvider.Instance.GetAll();
				foreach (DataRow dr in dt.Rows)
				{
					RutasCuentas rutascuentas = new RutasCuentas();
					ReadData(rutascuentas, dr, generateUndo);
					rutascuentaslist.Add(rutascuentas);
				}
				return rutascuentaslist;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Gets all objects of RutasCuentas applying filter and sort criteria
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
		/// <returns>One RutasCuentasList object</returns>
		public RutasCuentasList GetFilter(int pagenum, int pagesize, string filter, string sort, string extablesfilter, string extablesfieldsfilter, string extablesrelationsfilter, string extablessort, string extablesfieldssort, string extablesrelationssort, bool generateUndo=false)
		{
			try 
			{
				RutasCuentasList rutascuentaslist = new RutasCuentasList();

				DataTable dt = RutasCuentasDataProvider.Instance.GetFilter(pagenum, pagesize, filter, sort, extablesfilter, extablesfieldsfilter, extablesrelationsfilter, extablessort, extablesfieldssort, extablesrelationssort);

				foreach (DataRow dr in dt.Rows)
				{
					RutasCuentas rutascuentas = new RutasCuentas();
					ReadData(rutascuentas, dr, generateUndo);
					rutascuentaslist.Add(rutascuentas);
				}
				return rutascuentaslist;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public RutasCuentasList GetFilter( string filter, string sort, bool generateUndo=false)
		{
			return GetFilter(0,0, filter, sort, "","","","","","",generateUndo);
		}

		public RutasCuentasList GetFilter(string filter, string sort, string extablesfilter, string extablesfieldsfilter, string extablesrelationsfilter, string extablessort, string extablesfieldssort, string extablesrelationssort, bool generateUndo=false)
		{
			return GetFilter(0,0, filter, sort, extablesfilter, extablesfieldsfilter, extablesrelationsfilter, extablessort, extablesfieldssort, extablesrelationssort,generateUndo);
		}


		/// <summary>
		/// Returns the type for one property
		/// </summary>
		/// <param name="propertyname">Property's name for return its value</param>
		/// <returns>A value for the <paramref name="propertyname"/></returns>
		public Type GetMethodType( string propertyname,RutasCuentas rutascuentas)
		{
			// Perform the search for the property's value
			switch (propertyname)
			{
				case "lngIdRegistrRuta":
					return rutascuentas.lngIdRegistrRuta.GetType();

				case "cutCombustible":
					return rutascuentas.cutCombustible.GetType();

				case "cutPeaje":
					return rutascuentas.cutPeaje.GetType();

				case "cutVariosLlantas":
					return rutascuentas.cutVariosLlantas.GetType();

				case "cutVariosCelada":
					return rutascuentas.cutVariosCelada.GetType();

				case "cutVariosPropina":
					return rutascuentas.cutVariosPropina.GetType();

				case "cutVarios":
					return rutascuentas.cutVarios.GetType();

				case "cutVariosLlantasVacio":
					return rutascuentas.cutVariosLlantasVacio.GetType();

				case "cutVariosCeladaVacio":
					return rutascuentas.cutVariosCeladaVacio.GetType();

				case "cutVariosPropinaVacio":
					return rutascuentas.cutVariosPropinaVacio.GetType();

				case "cutVariosVacio":
					return rutascuentas.cutVariosVacio.GetType();

				case "cutParticipacion":
					return rutascuentas.cutParticipacion.GetType();

				case "cutParticipacionVacio":
					return rutascuentas.cutParticipacionVacio.GetType();

				case "curHotel":
					return rutascuentas.curHotel.GetType();

				case "curHotelVacio":
					return rutascuentas.curHotelVacio.GetType();

				case "curComida":
					return rutascuentas.curComida.GetType();

				case "curComidaVacio":
					return rutascuentas.curComidaVacio.GetType();

				case "curDesvareManoRepuestos":
					return rutascuentas.curDesvareManoRepuestos.GetType();

				case "curDesvareManoObra":
					return rutascuentas.curDesvareManoObra.GetType();

				case "cutSaldo":
					return rutascuentas.cutSaldo.GetType();

				case "cutKmts":
					return rutascuentas.cutKmts.GetType();

				case "ParqueaderoCarretera":
					return rutascuentas.ParqueaderoCarretera.GetType();

				case "ParqueaderoCiudad":
					return rutascuentas.ParqueaderoCiudad.GetType();

				case "MontadaLLantaCarretera":
					return rutascuentas.MontadaLLantaCarretera.GetType();

				case "Papeleria":
					return rutascuentas.Papeleria.GetType();

				case "AjusteCarretera":
					return rutascuentas.AjusteCarretera.GetType();

				case "Aseo":
					return rutascuentas.Aseo.GetType();

				case "Amarres":
					return rutascuentas.Amarres.GetType();

				case "Engradasa":
					return rutascuentas.Engradasa.GetType();

				case "Calibrada":
					return rutascuentas.Calibrada.GetType();

				case "Taxi":
					return rutascuentas.Taxi.GetType();

				case "Lavada":
					return rutascuentas.Lavada.GetType();

				case "CombustibleCarretera":
					return rutascuentas.CombustibleCarretera.GetType();

				case "CurCargue":
					return rutascuentas.CurCargue.GetType();

				case "CurDescargue":
					return rutascuentas.CurDescargue.GetType();

			}

			return null;
		}
		/// <summary>
		/// update the changes in RutasCuentas object by passing the object
		/// </summary>
		public bool UpdateChanges(RutasCuentas rutascuentas, out string error,Sinapsys.Datos.SQL datosTransaccion=null)
		{
			if (rutascuentas.OldRutasCuentas == null)
			{
				    error = "No tiene objeto con el cual comparar";
				    return false;
			}
			string[] Fields = rutascuentas.FieldChanged();
			error = "";
			return LiqViajes_Bll_Data.DataProvider.UpdateFieldsbyObject(Fields, rutascuentas, out error,datosTransaccion);
		}
	}

	#endregion

}
