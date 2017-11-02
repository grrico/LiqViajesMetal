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
	#region TramosAsignadosRutaController

	/// <summary>
	/// Class for convert data from database into object's data and vice versa
	/// </summary>
	public partial class TramosAsignadosRutaController//: ILatinodeController
	{
		/// <summary>
		/// Generic Constructor
		/// </summary>
		public TramosAsignadosRutaController()
		{
		}

		/// <summary>
		/// Instance accessor for this singleton
		/// </summary>
		private static TramosAsignadosRutaController MySingleObj;
		public static TramosAsignadosRutaController Instance
		{
			get
			{
				if (MySingleObj == null)
				{
					MySingleObj = new TramosAsignadosRutaController();
				}
				return MySingleObj;
			}
		}

		// Reads object's data from a DataRow
		private void ReadData(TramosAsignadosRuta tramosasignadosruta, DataRow dr,bool generateUndo=false)
		{
			try 
			{
				tramosasignadosruta.RegistroId = (long) dr["RegistroId"];
				tramosasignadosruta.Registro = (long) dr["Registro"];
				tramosasignadosruta.RegistrRuta = (long) dr["RegistrRuta"];
				tramosasignadosruta.RegistroRuttaAJC = (long) dr["RegistroRuttaAJC"];
				tramosasignadosruta.Fecha = dr.IsNull("Fecha") ? null :(DateTime?) dr["Fecha"];
				tramosasignadosruta.liquidado = (bool) dr["liquidado"];
				tramosasignadosruta.Asignado = (int) dr["Asignado"];
				tramosasignadosruta.Vacio = (int) dr["Vacio"];
				tramosasignadosruta.logAjuste = dr.IsNull("logAjuste") ? null :(bool?) dr["logAjuste"];
				tramosasignadosruta.Peso = (int) dr["Peso"];
				tramosasignadosruta.EstadoRuta = dr.IsNull("EstadoRuta") ? null :(bool?) dr["EstadoRuta"];
				tramosasignadosruta.Trailer = dr.IsNull("Trailer") ? null :(string) dr["Trailer"];
				tramosasignadosruta.TipoVeh = (int) dr["TipoVeh"];
				tramosasignadosruta.DesTipoVeh = (string) dr["DesTipoVeh"];
				tramosasignadosruta.TipoTrailer = (int) dr["TipoTrailer"];
				tramosasignadosruta.Origen = dr.IsNull("Origen") ? null :(string) dr["Origen"];
				tramosasignadosruta.Destino = dr.IsNull("Destino") ? null :(string) dr["Destino"];
				tramosasignadosruta.Tramos = dr.IsNull("Tramos") ? null :(string) dr["Tramos"];
				tramosasignadosruta.CantidadGalones = dr.IsNull("CantidadGalones") ? null :(decimal?) dr["CantidadGalones"];
				tramosasignadosruta.ValorGalones = dr.IsNull("ValorGalones") ? null :(decimal?) dr["ValorGalones"];
				tramosasignadosruta.ValorCOmbustible = dr.IsNull("ValorCOmbustible") ? null :(decimal?) dr["ValorCOmbustible"];
				tramosasignadosruta.Viaticos = dr.IsNull("Viaticos") ? null :(decimal?) dr["Viaticos"];
				tramosasignadosruta.SalarioVariable = dr.IsNull("SalarioVariable") ? null :(decimal?) dr["SalarioVariable"];
				tramosasignadosruta.TotalViaticos = dr.IsNull("TotalViaticos") ? null :(decimal?) dr["TotalViaticos"];
				tramosasignadosruta.TotalDescuentoViaticos = dr.IsNull("TotalDescuentoViaticos") ? null :(decimal?) dr["TotalDescuentoViaticos"];
				tramosasignadosruta.Total_Viaticos = dr.IsNull("Total_Viaticos") ? null :(decimal?) dr["Total_Viaticos"];
				tramosasignadosruta.NroPeajes = dr.IsNull("NroPeajes") ? null :(int?) dr["NroPeajes"];
				tramosasignadosruta.ValorPeajes = dr.IsNull("ValorPeajes") ? null :(decimal?) dr["ValorPeajes"];
				tramosasignadosruta.Llantas = dr.IsNull("Llantas") ? null :(decimal?) dr["Llantas"];
				tramosasignadosruta.CeladaParqueaderoCarretera = dr.IsNull("CeladaParqueaderoCarretera") ? null :(decimal?) dr["CeladaParqueaderoCarretera"];
				tramosasignadosruta.Propina = dr.IsNull("Propina") ? null :(decimal?) dr["Propina"];
				tramosasignadosruta.TotalVarios = dr.IsNull("TotalVarios") ? null :(decimal?) dr["TotalVarios"];
				tramosasignadosruta.LlantasVacios = dr.IsNull("LlantasVacios") ? null :(decimal?) dr["LlantasVacios"];
				tramosasignadosruta.CeladaVacia = dr.IsNull("CeladaVacia") ? null :(decimal?) dr["CeladaVacia"];
				tramosasignadosruta.PropinaVacia = dr.IsNull("PropinaVacia") ? null :(decimal?) dr["PropinaVacia"];
				tramosasignadosruta.VariosVacios = dr.IsNull("VariosVacios") ? null :(decimal?) dr["VariosVacios"];
				tramosasignadosruta.ValorCargue = dr.IsNull("ValorCargue") ? null :(decimal?) dr["ValorCargue"];
				tramosasignadosruta.ValorDescargue = dr.IsNull("ValorDescargue") ? null :(decimal?) dr["ValorDescargue"];
				tramosasignadosruta.Hotel = dr.IsNull("Hotel") ? null :(decimal?) dr["Hotel"];
				tramosasignadosruta.HotelDiasCarretera = dr.IsNull("HotelDiasCarretera") ? null :(int?) dr["HotelDiasCarretera"];
				tramosasignadosruta.HotelDiasCiudad = dr.IsNull("HotelDiasCiudad") ? null :(int?) dr["HotelDiasCiudad"];
				tramosasignadosruta.HotelVacio = dr.IsNull("HotelVacio") ? null :(decimal?) dr["HotelVacio"];
				tramosasignadosruta.TiempoReal = dr.IsNull("TiempoReal") ? null :(decimal?) dr["TiempoReal"];
				tramosasignadosruta.TotalComida = dr.IsNull("TotalComida") ? null :(decimal?) dr["TotalComida"];
				tramosasignadosruta.TiempoRutaVacio = dr.IsNull("TiempoRutaVacio") ? null :(decimal?) dr["TiempoRutaVacio"];
				tramosasignadosruta.ComidaVacio = dr.IsNull("ComidaVacio") ? null :(decimal?) dr["ComidaVacio"];
				tramosasignadosruta.DesvareRepuestos = dr.IsNull("DesvareRepuestos") ? null :(decimal?) dr["DesvareRepuestos"];
				tramosasignadosruta.DesvareManoObra = dr.IsNull("DesvareManoObra") ? null :(decimal?) dr["DesvareManoObra"];
				tramosasignadosruta.TotalKm = dr.IsNull("TotalKm") ? null :(decimal?) dr["TotalKm"];
				tramosasignadosruta.ParqueaderoCarretera = (decimal) dr["ParqueaderoCarretera"];
				tramosasignadosruta.ParqueaderoCiudad = (decimal) dr["ParqueaderoCiudad"];
				tramosasignadosruta.MontaLlantaCarretera = (decimal) dr["MontaLlantaCarretera"];
				tramosasignadosruta.Papeleria = (decimal) dr["Papeleria"];
				tramosasignadosruta.AjusteCarretera = (decimal) dr["AjusteCarretera"];
				tramosasignadosruta.CombustibleCarretera = dr.IsNull("CombustibleCarretera") ? null :(decimal?) dr["CombustibleCarretera"];
				tramosasignadosruta.Amarres = (decimal) dr["Amarres"];
				tramosasignadosruta.Engrasada = (decimal) dr["Engrasada"];
				tramosasignadosruta.Calibrada = (decimal) dr["Calibrada"];
				tramosasignadosruta.Aseo = dr.IsNull("Aseo") ? null :(decimal?) dr["Aseo"];
				tramosasignadosruta.Taxi = dr.IsNull("Taxi") ? null :(decimal?) dr["Taxi"];
				tramosasignadosruta.Contenedor1 = dr.IsNull("Contenedor1") ? null :(string) dr["Contenedor1"];
				tramosasignadosruta.Contenedor2 = dr.IsNull("Contenedor2") ? null :(string) dr["Contenedor2"];
				tramosasignadosruta.FactorCalculoDia = dr.IsNull("FactorCalculoDia") ? null :(int?) dr["FactorCalculoDia"];
				tramosasignadosruta.ValorFactorCalculo = dr.IsNull("ValorFactorCalculo") ? null :(decimal?) dr["ValorFactorCalculo"];
				tramosasignadosruta.ValorAnticipo = dr.IsNull("ValorAnticipo") ? null :(decimal?) dr["ValorAnticipo"];
				tramosasignadosruta.CantidadReal = dr.IsNull("CantidadReal") ? null :(decimal?) dr["CantidadReal"];
				tramosasignadosruta.LogAnticipoACPM = dr.IsNull("LogAnticipoACPM") ? null :(bool?) dr["LogAnticipoACPM"];
				tramosasignadosruta.PlacaTrailer = dr.IsNull("PlacaTrailer") ? null :(string) dr["PlacaTrailer"];
			}
			catch (Exception ex)
			{
				Utilidades.LogErrores(ex.Message + (ex.InnerException != null ? ex.InnerException.Message : ""), DataProvider.AplicacionNombre);
				throw ex;
			}
			if (generateUndo) tramosasignadosruta.GenerateUndo();
		}

		/// <summary>
		/// Create a new TramosAsignadosRuta object by passing a object
		/// </summary>
		public TramosAsignadosRuta Create(TramosAsignadosRuta tramosasignadosruta, Sinapsys.Datos.SQL datosTransaccion=null)
		{
			return Create(tramosasignadosruta.RegistroId,tramosasignadosruta.Registro,tramosasignadosruta.RegistrRuta,tramosasignadosruta.RegistroRuttaAJC,tramosasignadosruta.Fecha,tramosasignadosruta.liquidado,tramosasignadosruta.Asignado,tramosasignadosruta.Vacio,tramosasignadosruta.logAjuste,tramosasignadosruta.Peso,tramosasignadosruta.EstadoRuta,tramosasignadosruta.Trailer,tramosasignadosruta.TipoVeh,tramosasignadosruta.DesTipoVeh,tramosasignadosruta.TipoTrailer,tramosasignadosruta.Origen,tramosasignadosruta.Destino,tramosasignadosruta.Tramos,tramosasignadosruta.CantidadGalones,tramosasignadosruta.ValorGalones,tramosasignadosruta.ValorCOmbustible,tramosasignadosruta.Viaticos,tramosasignadosruta.SalarioVariable,tramosasignadosruta.TotalViaticos,tramosasignadosruta.TotalDescuentoViaticos,tramosasignadosruta.Total_Viaticos,tramosasignadosruta.NroPeajes,tramosasignadosruta.ValorPeajes,tramosasignadosruta.Llantas,tramosasignadosruta.CeladaParqueaderoCarretera,tramosasignadosruta.Propina,tramosasignadosruta.TotalVarios,tramosasignadosruta.LlantasVacios,tramosasignadosruta.CeladaVacia,tramosasignadosruta.PropinaVacia,tramosasignadosruta.VariosVacios,tramosasignadosruta.ValorCargue,tramosasignadosruta.ValorDescargue,tramosasignadosruta.Hotel,tramosasignadosruta.HotelDiasCarretera,tramosasignadosruta.HotelDiasCiudad,tramosasignadosruta.HotelVacio,tramosasignadosruta.TiempoReal,tramosasignadosruta.TotalComida,tramosasignadosruta.TiempoRutaVacio,tramosasignadosruta.ComidaVacio,tramosasignadosruta.DesvareRepuestos,tramosasignadosruta.DesvareManoObra,tramosasignadosruta.TotalKm,tramosasignadosruta.ParqueaderoCarretera,tramosasignadosruta.ParqueaderoCiudad,tramosasignadosruta.MontaLlantaCarretera,tramosasignadosruta.Papeleria,tramosasignadosruta.AjusteCarretera,tramosasignadosruta.CombustibleCarretera,tramosasignadosruta.Amarres,tramosasignadosruta.Engrasada,tramosasignadosruta.Calibrada,tramosasignadosruta.Aseo,tramosasignadosruta.Taxi,tramosasignadosruta.Contenedor1,tramosasignadosruta.Contenedor2,tramosasignadosruta.FactorCalculoDia,tramosasignadosruta.ValorFactorCalculo,tramosasignadosruta.ValorAnticipo,tramosasignadosruta.CantidadReal,tramosasignadosruta.LogAnticipoACPM,tramosasignadosruta.PlacaTrailer,datosTransaccion);
		}

		/// <summary>
		/// Creates a new TramosAsignadosRuta object by passing all object's fields
		/// </summary>
		/// <param name="Fecha">DateTime that contents the Fecha value for the TramosAsignadosRuta object</param>
		/// <param name="liquidado">bool that contents the liquidado value for the TramosAsignadosRuta object</param>
		/// <param name="Asignado">int that contents the Asignado value for the TramosAsignadosRuta object</param>
		/// <param name="Vacio">int that contents the Vacio value for the TramosAsignadosRuta object</param>
		/// <param name="logAjuste">bool that contents the logAjuste value for the TramosAsignadosRuta object</param>
		/// <param name="Peso">int that contents the Peso value for the TramosAsignadosRuta object</param>
		/// <param name="EstadoRuta">bool that contents the EstadoRuta value for the TramosAsignadosRuta object</param>
		/// <param name="Trailer">string that contents the Trailer value for the TramosAsignadosRuta object</param>
		/// <param name="TipoVeh">int that contents the TipoVeh value for the TramosAsignadosRuta object</param>
		/// <param name="DesTipoVeh">string that contents the DesTipoVeh value for the TramosAsignadosRuta object</param>
		/// <param name="TipoTrailer">int that contents the TipoTrailer value for the TramosAsignadosRuta object</param>
		/// <param name="Origen">string that contents the Origen value for the TramosAsignadosRuta object</param>
		/// <param name="Destino">string that contents the Destino value for the TramosAsignadosRuta object</param>
		/// <param name="Tramos">string that contents the Tramos value for the TramosAsignadosRuta object</param>
		/// <param name="CantidadGalones">decimal that contents the CantidadGalones value for the TramosAsignadosRuta object</param>
		/// <param name="ValorGalones">decimal that contents the ValorGalones value for the TramosAsignadosRuta object</param>
		/// <param name="ValorCOmbustible">decimal that contents the ValorCOmbustible value for the TramosAsignadosRuta object</param>
		/// <param name="Viaticos">decimal that contents the Viaticos value for the TramosAsignadosRuta object</param>
		/// <param name="SalarioVariable">decimal that contents the SalarioVariable value for the TramosAsignadosRuta object</param>
		/// <param name="TotalViaticos">decimal that contents the TotalViaticos value for the TramosAsignadosRuta object</param>
		/// <param name="TotalDescuentoViaticos">decimal that contents the TotalDescuentoViaticos value for the TramosAsignadosRuta object</param>
		/// <param name="Total_Viaticos">decimal that contents the Total_Viaticos value for the TramosAsignadosRuta object</param>
		/// <param name="NroPeajes">int that contents the NroPeajes value for the TramosAsignadosRuta object</param>
		/// <param name="ValorPeajes">decimal that contents the ValorPeajes value for the TramosAsignadosRuta object</param>
		/// <param name="Llantas">decimal that contents the Llantas value for the TramosAsignadosRuta object</param>
		/// <param name="CeladaParqueaderoCarretera">decimal that contents the CeladaParqueaderoCarretera value for the TramosAsignadosRuta object</param>
		/// <param name="Propina">decimal that contents the Propina value for the TramosAsignadosRuta object</param>
		/// <param name="TotalVarios">decimal that contents the TotalVarios value for the TramosAsignadosRuta object</param>
		/// <param name="LlantasVacios">decimal that contents the LlantasVacios value for the TramosAsignadosRuta object</param>
		/// <param name="CeladaVacia">decimal that contents the CeladaVacia value for the TramosAsignadosRuta object</param>
		/// <param name="PropinaVacia">decimal that contents the PropinaVacia value for the TramosAsignadosRuta object</param>
		/// <param name="VariosVacios">decimal that contents the VariosVacios value for the TramosAsignadosRuta object</param>
		/// <param name="ValorCargue">decimal that contents the ValorCargue value for the TramosAsignadosRuta object</param>
		/// <param name="ValorDescargue">decimal that contents the ValorDescargue value for the TramosAsignadosRuta object</param>
		/// <param name="Hotel">decimal that contents the Hotel value for the TramosAsignadosRuta object</param>
		/// <param name="HotelDiasCarretera">int that contents the HotelDiasCarretera value for the TramosAsignadosRuta object</param>
		/// <param name="HotelDiasCiudad">int that contents the HotelDiasCiudad value for the TramosAsignadosRuta object</param>
		/// <param name="HotelVacio">decimal that contents the HotelVacio value for the TramosAsignadosRuta object</param>
		/// <param name="TiempoReal">decimal that contents the TiempoReal value for the TramosAsignadosRuta object</param>
		/// <param name="TotalComida">decimal that contents the TotalComida value for the TramosAsignadosRuta object</param>
		/// <param name="TiempoRutaVacio">decimal that contents the TiempoRutaVacio value for the TramosAsignadosRuta object</param>
		/// <param name="ComidaVacio">decimal that contents the ComidaVacio value for the TramosAsignadosRuta object</param>
		/// <param name="DesvareRepuestos">decimal that contents the DesvareRepuestos value for the TramosAsignadosRuta object</param>
		/// <param name="DesvareManoObra">decimal that contents the DesvareManoObra value for the TramosAsignadosRuta object</param>
		/// <param name="TotalKm">decimal that contents the TotalKm value for the TramosAsignadosRuta object</param>
		/// <param name="ParqueaderoCarretera">decimal that contents the ParqueaderoCarretera value for the TramosAsignadosRuta object</param>
		/// <param name="ParqueaderoCiudad">decimal that contents the ParqueaderoCiudad value for the TramosAsignadosRuta object</param>
		/// <param name="MontaLlantaCarretera">decimal that contents the MontaLlantaCarretera value for the TramosAsignadosRuta object</param>
		/// <param name="Papeleria">decimal that contents the Papeleria value for the TramosAsignadosRuta object</param>
		/// <param name="AjusteCarretera">decimal that contents the AjusteCarretera value for the TramosAsignadosRuta object</param>
		/// <param name="CombustibleCarretera">decimal that contents the CombustibleCarretera value for the TramosAsignadosRuta object</param>
		/// <param name="Amarres">decimal that contents the Amarres value for the TramosAsignadosRuta object</param>
		/// <param name="Engrasada">decimal that contents the Engrasada value for the TramosAsignadosRuta object</param>
		/// <param name="Calibrada">decimal that contents the Calibrada value for the TramosAsignadosRuta object</param>
		/// <param name="Aseo">decimal that contents the Aseo value for the TramosAsignadosRuta object</param>
		/// <param name="Taxi">decimal that contents the Taxi value for the TramosAsignadosRuta object</param>
		/// <param name="Contenedor1">string that contents the Contenedor1 value for the TramosAsignadosRuta object</param>
		/// <param name="Contenedor2">string that contents the Contenedor2 value for the TramosAsignadosRuta object</param>
		/// <param name="FactorCalculoDia">int that contents the FactorCalculoDia value for the TramosAsignadosRuta object</param>
		/// <param name="ValorFactorCalculo">decimal that contents the ValorFactorCalculo value for the TramosAsignadosRuta object</param>
		/// <param name="ValorAnticipo">decimal that contents the ValorAnticipo value for the TramosAsignadosRuta object</param>
		/// <param name="CantidadReal">decimal that contents the CantidadReal value for the TramosAsignadosRuta object</param>
		/// <param name="LogAnticipoACPM">bool that contents the LogAnticipoACPM value for the TramosAsignadosRuta object</param>
		/// <param name="PlacaTrailer">string that contents the PlacaTrailer value for the TramosAsignadosRuta object</param>
		/// <returns>One TramosAsignadosRuta object</returns>
		public TramosAsignadosRuta Create(long RegistroId, long Registro, long RegistrRuta, long RegistroRuttaAJC, DateTime? Fecha, bool liquidado, int Asignado, int Vacio, bool? logAjuste, int Peso, bool? EstadoRuta, string Trailer, int TipoVeh, string DesTipoVeh, int TipoTrailer, string Origen, string Destino, string Tramos, decimal? CantidadGalones, decimal? ValorGalones, decimal? ValorCOmbustible, decimal? Viaticos, decimal? SalarioVariable, decimal? TotalViaticos, decimal? TotalDescuentoViaticos, decimal? Total_Viaticos, int? NroPeajes, decimal? ValorPeajes, decimal? Llantas, decimal? CeladaParqueaderoCarretera, decimal? Propina, decimal? TotalVarios, decimal? LlantasVacios, decimal? CeladaVacia, decimal? PropinaVacia, decimal? VariosVacios, decimal? ValorCargue, decimal? ValorDescargue, decimal? Hotel, int? HotelDiasCarretera, int? HotelDiasCiudad, decimal? HotelVacio, decimal? TiempoReal, decimal? TotalComida, decimal? TiempoRutaVacio, decimal? ComidaVacio, decimal? DesvareRepuestos, decimal? DesvareManoObra, decimal? TotalKm, decimal ParqueaderoCarretera, decimal ParqueaderoCiudad, decimal MontaLlantaCarretera, decimal Papeleria, decimal AjusteCarretera, decimal? CombustibleCarretera, decimal Amarres, decimal Engrasada, decimal Calibrada, decimal? Aseo, decimal? Taxi, string Contenedor1, string Contenedor2, int? FactorCalculoDia, decimal? ValorFactorCalculo, decimal? ValorAnticipo, decimal? CantidadReal, bool? LogAnticipoACPM, string PlacaTrailer, Sinapsys.Datos.SQL datosTransaccion=null)
		{
			try 
			{
				TramosAsignadosRuta tramosasignadosruta = new TramosAsignadosRuta();

				tramosasignadosruta.RegistroId = RegistroId;
				tramosasignadosruta.RegistroId = RegistroId;
				tramosasignadosruta.Registro = Registro;
				tramosasignadosruta.RegistrRuta = RegistrRuta;
				tramosasignadosruta.RegistroRuttaAJC = RegistroRuttaAJC;
				tramosasignadosruta.Fecha = Fecha;
				tramosasignadosruta.liquidado = liquidado;
				tramosasignadosruta.Asignado = Asignado;
				tramosasignadosruta.Vacio = Vacio;
				tramosasignadosruta.logAjuste = logAjuste;
				tramosasignadosruta.Peso = Peso;
				tramosasignadosruta.EstadoRuta = EstadoRuta;
				tramosasignadosruta.Trailer = Trailer;
				tramosasignadosruta.TipoVeh = TipoVeh;
				tramosasignadosruta.DesTipoVeh = DesTipoVeh;
				tramosasignadosruta.TipoTrailer = TipoTrailer;
				tramosasignadosruta.Origen = Origen;
				tramosasignadosruta.Destino = Destino;
				tramosasignadosruta.Tramos = Tramos;
				tramosasignadosruta.CantidadGalones = CantidadGalones;
				tramosasignadosruta.ValorGalones = ValorGalones;
				tramosasignadosruta.ValorCOmbustible = ValorCOmbustible;
				tramosasignadosruta.Viaticos = Viaticos;
				tramosasignadosruta.SalarioVariable = SalarioVariable;
				tramosasignadosruta.TotalViaticos = TotalViaticos;
				tramosasignadosruta.TotalDescuentoViaticos = TotalDescuentoViaticos;
				tramosasignadosruta.Total_Viaticos = Total_Viaticos;
				tramosasignadosruta.NroPeajes = NroPeajes;
				tramosasignadosruta.ValorPeajes = ValorPeajes;
				tramosasignadosruta.Llantas = Llantas;
				tramosasignadosruta.CeladaParqueaderoCarretera = CeladaParqueaderoCarretera;
				tramosasignadosruta.Propina = Propina;
				tramosasignadosruta.TotalVarios = TotalVarios;
				tramosasignadosruta.LlantasVacios = LlantasVacios;
				tramosasignadosruta.CeladaVacia = CeladaVacia;
				tramosasignadosruta.PropinaVacia = PropinaVacia;
				tramosasignadosruta.VariosVacios = VariosVacios;
				tramosasignadosruta.ValorCargue = ValorCargue;
				tramosasignadosruta.ValorDescargue = ValorDescargue;
				tramosasignadosruta.Hotel = Hotel;
				tramosasignadosruta.HotelDiasCarretera = HotelDiasCarretera;
				tramosasignadosruta.HotelDiasCiudad = HotelDiasCiudad;
				tramosasignadosruta.HotelVacio = HotelVacio;
				tramosasignadosruta.TiempoReal = TiempoReal;
				tramosasignadosruta.TotalComida = TotalComida;
				tramosasignadosruta.TiempoRutaVacio = TiempoRutaVacio;
				tramosasignadosruta.ComidaVacio = ComidaVacio;
				tramosasignadosruta.DesvareRepuestos = DesvareRepuestos;
				tramosasignadosruta.DesvareManoObra = DesvareManoObra;
				tramosasignadosruta.TotalKm = TotalKm;
				tramosasignadosruta.ParqueaderoCarretera = ParqueaderoCarretera;
				tramosasignadosruta.ParqueaderoCiudad = ParqueaderoCiudad;
				tramosasignadosruta.MontaLlantaCarretera = MontaLlantaCarretera;
				tramosasignadosruta.Papeleria = Papeleria;
				tramosasignadosruta.AjusteCarretera = AjusteCarretera;
				tramosasignadosruta.CombustibleCarretera = CombustibleCarretera;
				tramosasignadosruta.Amarres = Amarres;
				tramosasignadosruta.Engrasada = Engrasada;
				tramosasignadosruta.Calibrada = Calibrada;
				tramosasignadosruta.Aseo = Aseo;
				tramosasignadosruta.Taxi = Taxi;
				tramosasignadosruta.Contenedor1 = Contenedor1;
				tramosasignadosruta.Contenedor2 = Contenedor2;
				tramosasignadosruta.FactorCalculoDia = FactorCalculoDia;
				tramosasignadosruta.ValorFactorCalculo = ValorFactorCalculo;
				tramosasignadosruta.ValorAnticipo = ValorAnticipo;
				tramosasignadosruta.CantidadReal = CantidadReal;
				tramosasignadosruta.LogAnticipoACPM = LogAnticipoACPM;
				tramosasignadosruta.PlacaTrailer = PlacaTrailer;
				RegistroId = TramosAsignadosRutaDataProvider.Instance.Create(RegistroId, Registro, RegistrRuta, RegistroRuttaAJC, Fecha, liquidado, Asignado, Vacio, logAjuste, Peso, EstadoRuta, Trailer, TipoVeh, DesTipoVeh, TipoTrailer, Origen, Destino, Tramos, CantidadGalones, ValorGalones, ValorCOmbustible, Viaticos, SalarioVariable, TotalViaticos, TotalDescuentoViaticos, Total_Viaticos, NroPeajes, ValorPeajes, Llantas, CeladaParqueaderoCarretera, Propina, TotalVarios, LlantasVacios, CeladaVacia, PropinaVacia, VariosVacios, ValorCargue, ValorDescargue, Hotel, HotelDiasCarretera, HotelDiasCiudad, HotelVacio, TiempoReal, TotalComida, TiempoRutaVacio, ComidaVacio, DesvareRepuestos, DesvareManoObra, TotalKm, ParqueaderoCarretera, ParqueaderoCiudad, MontaLlantaCarretera, Papeleria, AjusteCarretera, CombustibleCarretera, Amarres, Engrasada, Calibrada, Aseo, Taxi, Contenedor1, Contenedor2, FactorCalculoDia, ValorFactorCalculo, ValorAnticipo, CantidadReal, LogAnticipoACPM, PlacaTrailer,"TramosAsignadosRuta",datosTransaccion);
				if (RegistroId == 0)
					return null;

				tramosasignadosruta.RegistroId = RegistroId;

				return tramosasignadosruta;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Updates an TramosAsignadosRuta object by passing all object's fields
		/// </summary>
		/// <param name="RegistroId">long that contents the RegistroId value for the TramosAsignadosRuta object</param>
		/// <param name="Registro">long that contents the Registro value for the TramosAsignadosRuta object</param>
		/// <param name="RegistrRuta">long that contents the RegistrRuta value for the TramosAsignadosRuta object</param>
		/// <param name="RegistroRuttaAJC">long that contents the RegistroRuttaAJC value for the TramosAsignadosRuta object</param>
		/// <param name="Fecha">DateTime that contents the Fecha value for the TramosAsignadosRuta object</param>
		/// <param name="liquidado">bool that contents the liquidado value for the TramosAsignadosRuta object</param>
		/// <param name="Asignado">int that contents the Asignado value for the TramosAsignadosRuta object</param>
		/// <param name="Vacio">int that contents the Vacio value for the TramosAsignadosRuta object</param>
		/// <param name="logAjuste">bool that contents the logAjuste value for the TramosAsignadosRuta object</param>
		/// <param name="Peso">int that contents the Peso value for the TramosAsignadosRuta object</param>
		/// <param name="EstadoRuta">bool that contents the EstadoRuta value for the TramosAsignadosRuta object</param>
		/// <param name="Trailer">string that contents the Trailer value for the TramosAsignadosRuta object</param>
		/// <param name="TipoVeh">int that contents the TipoVeh value for the TramosAsignadosRuta object</param>
		/// <param name="DesTipoVeh">string that contents the DesTipoVeh value for the TramosAsignadosRuta object</param>
		/// <param name="TipoTrailer">int that contents the TipoTrailer value for the TramosAsignadosRuta object</param>
		/// <param name="Origen">string that contents the Origen value for the TramosAsignadosRuta object</param>
		/// <param name="Destino">string that contents the Destino value for the TramosAsignadosRuta object</param>
		/// <param name="Tramos">string that contents the Tramos value for the TramosAsignadosRuta object</param>
		/// <param name="CantidadGalones">decimal that contents the CantidadGalones value for the TramosAsignadosRuta object</param>
		/// <param name="ValorGalones">decimal that contents the ValorGalones value for the TramosAsignadosRuta object</param>
		/// <param name="ValorCOmbustible">decimal that contents the ValorCOmbustible value for the TramosAsignadosRuta object</param>
		/// <param name="Viaticos">decimal that contents the Viaticos value for the TramosAsignadosRuta object</param>
		/// <param name="SalarioVariable">decimal that contents the SalarioVariable value for the TramosAsignadosRuta object</param>
		/// <param name="TotalViaticos">decimal that contents the TotalViaticos value for the TramosAsignadosRuta object</param>
		/// <param name="TotalDescuentoViaticos">decimal that contents the TotalDescuentoViaticos value for the TramosAsignadosRuta object</param>
		/// <param name="Total_Viaticos">decimal that contents the Total_Viaticos value for the TramosAsignadosRuta object</param>
		/// <param name="NroPeajes">int that contents the NroPeajes value for the TramosAsignadosRuta object</param>
		/// <param name="ValorPeajes">decimal that contents the ValorPeajes value for the TramosAsignadosRuta object</param>
		/// <param name="Llantas">decimal that contents the Llantas value for the TramosAsignadosRuta object</param>
		/// <param name="CeladaParqueaderoCarretera">decimal that contents the CeladaParqueaderoCarretera value for the TramosAsignadosRuta object</param>
		/// <param name="Propina">decimal that contents the Propina value for the TramosAsignadosRuta object</param>
		/// <param name="TotalVarios">decimal that contents the TotalVarios value for the TramosAsignadosRuta object</param>
		/// <param name="LlantasVacios">decimal that contents the LlantasVacios value for the TramosAsignadosRuta object</param>
		/// <param name="CeladaVacia">decimal that contents the CeladaVacia value for the TramosAsignadosRuta object</param>
		/// <param name="PropinaVacia">decimal that contents the PropinaVacia value for the TramosAsignadosRuta object</param>
		/// <param name="VariosVacios">decimal that contents the VariosVacios value for the TramosAsignadosRuta object</param>
		/// <param name="ValorCargue">decimal that contents the ValorCargue value for the TramosAsignadosRuta object</param>
		/// <param name="ValorDescargue">decimal that contents the ValorDescargue value for the TramosAsignadosRuta object</param>
		/// <param name="Hotel">decimal that contents the Hotel value for the TramosAsignadosRuta object</param>
		/// <param name="HotelDiasCarretera">int that contents the HotelDiasCarretera value for the TramosAsignadosRuta object</param>
		/// <param name="HotelDiasCiudad">int that contents the HotelDiasCiudad value for the TramosAsignadosRuta object</param>
		/// <param name="HotelVacio">decimal that contents the HotelVacio value for the TramosAsignadosRuta object</param>
		/// <param name="TiempoReal">decimal that contents the TiempoReal value for the TramosAsignadosRuta object</param>
		/// <param name="TotalComida">decimal that contents the TotalComida value for the TramosAsignadosRuta object</param>
		/// <param name="TiempoRutaVacio">decimal that contents the TiempoRutaVacio value for the TramosAsignadosRuta object</param>
		/// <param name="ComidaVacio">decimal that contents the ComidaVacio value for the TramosAsignadosRuta object</param>
		/// <param name="DesvareRepuestos">decimal that contents the DesvareRepuestos value for the TramosAsignadosRuta object</param>
		/// <param name="DesvareManoObra">decimal that contents the DesvareManoObra value for the TramosAsignadosRuta object</param>
		/// <param name="TotalKm">decimal that contents the TotalKm value for the TramosAsignadosRuta object</param>
		/// <param name="ParqueaderoCarretera">decimal that contents the ParqueaderoCarretera value for the TramosAsignadosRuta object</param>
		/// <param name="ParqueaderoCiudad">decimal that contents the ParqueaderoCiudad value for the TramosAsignadosRuta object</param>
		/// <param name="MontaLlantaCarretera">decimal that contents the MontaLlantaCarretera value for the TramosAsignadosRuta object</param>
		/// <param name="Papeleria">decimal that contents the Papeleria value for the TramosAsignadosRuta object</param>
		/// <param name="AjusteCarretera">decimal that contents the AjusteCarretera value for the TramosAsignadosRuta object</param>
		/// <param name="CombustibleCarretera">decimal that contents the CombustibleCarretera value for the TramosAsignadosRuta object</param>
		/// <param name="Amarres">decimal that contents the Amarres value for the TramosAsignadosRuta object</param>
		/// <param name="Engrasada">decimal that contents the Engrasada value for the TramosAsignadosRuta object</param>
		/// <param name="Calibrada">decimal that contents the Calibrada value for the TramosAsignadosRuta object</param>
		/// <param name="Aseo">decimal that contents the Aseo value for the TramosAsignadosRuta object</param>
		/// <param name="Taxi">decimal that contents the Taxi value for the TramosAsignadosRuta object</param>
		/// <param name="Contenedor1">string that contents the Contenedor1 value for the TramosAsignadosRuta object</param>
		/// <param name="Contenedor2">string that contents the Contenedor2 value for the TramosAsignadosRuta object</param>
		/// <param name="FactorCalculoDia">int that contents the FactorCalculoDia value for the TramosAsignadosRuta object</param>
		/// <param name="ValorFactorCalculo">decimal that contents the ValorFactorCalculo value for the TramosAsignadosRuta object</param>
		/// <param name="ValorAnticipo">decimal that contents the ValorAnticipo value for the TramosAsignadosRuta object</param>
		/// <param name="CantidadReal">decimal that contents the CantidadReal value for the TramosAsignadosRuta object</param>
		/// <param name="LogAnticipoACPM">bool that contents the LogAnticipoACPM value for the TramosAsignadosRuta object</param>
		/// <param name="PlacaTrailer">string that contents the PlacaTrailer value for the TramosAsignadosRuta object</param>
		public void Update(long RegistroId, long Registro, long RegistrRuta, long RegistroRuttaAJC, DateTime? Fecha, bool liquidado, int Asignado, int Vacio, bool? logAjuste, int Peso, bool? EstadoRuta, string Trailer, int TipoVeh, string DesTipoVeh, int TipoTrailer, string Origen, string Destino, string Tramos, decimal? CantidadGalones, decimal? ValorGalones, decimal? ValorCOmbustible, decimal? Viaticos, decimal? SalarioVariable, decimal? TotalViaticos, decimal? TotalDescuentoViaticos, decimal? Total_Viaticos, int? NroPeajes, decimal? ValorPeajes, decimal? Llantas, decimal? CeladaParqueaderoCarretera, decimal? Propina, decimal? TotalVarios, decimal? LlantasVacios, decimal? CeladaVacia, decimal? PropinaVacia, decimal? VariosVacios, decimal? ValorCargue, decimal? ValorDescargue, decimal? Hotel, int? HotelDiasCarretera, int? HotelDiasCiudad, decimal? HotelVacio, decimal? TiempoReal, decimal? TotalComida, decimal? TiempoRutaVacio, decimal? ComidaVacio, decimal? DesvareRepuestos, decimal? DesvareManoObra, decimal? TotalKm, decimal ParqueaderoCarretera, decimal ParqueaderoCiudad, decimal MontaLlantaCarretera, decimal Papeleria, decimal AjusteCarretera, decimal? CombustibleCarretera, decimal Amarres, decimal Engrasada, decimal Calibrada, decimal? Aseo, decimal? Taxi, string Contenedor1, string Contenedor2, int? FactorCalculoDia, decimal? ValorFactorCalculo, decimal? ValorAnticipo, decimal? CantidadReal, bool? LogAnticipoACPM, string PlacaTrailer, Sinapsys.Datos.SQL datosTransaccion=null)
		{
			try 
			{
				TramosAsignadosRuta new_values = new TramosAsignadosRuta();
				new_values.Fecha = Fecha;
				new_values.liquidado = liquidado;
				new_values.Asignado = Asignado;
				new_values.Vacio = Vacio;
				new_values.logAjuste = logAjuste;
				new_values.Peso = Peso;
				new_values.EstadoRuta = EstadoRuta;
				new_values.Trailer = Trailer;
				new_values.TipoVeh = TipoVeh;
				new_values.DesTipoVeh = DesTipoVeh;
				new_values.TipoTrailer = TipoTrailer;
				new_values.Origen = Origen;
				new_values.Destino = Destino;
				new_values.Tramos = Tramos;
				new_values.CantidadGalones = CantidadGalones;
				new_values.ValorGalones = ValorGalones;
				new_values.ValorCOmbustible = ValorCOmbustible;
				new_values.Viaticos = Viaticos;
				new_values.SalarioVariable = SalarioVariable;
				new_values.TotalViaticos = TotalViaticos;
				new_values.TotalDescuentoViaticos = TotalDescuentoViaticos;
				new_values.Total_Viaticos = Total_Viaticos;
				new_values.NroPeajes = NroPeajes;
				new_values.ValorPeajes = ValorPeajes;
				new_values.Llantas = Llantas;
				new_values.CeladaParqueaderoCarretera = CeladaParqueaderoCarretera;
				new_values.Propina = Propina;
				new_values.TotalVarios = TotalVarios;
				new_values.LlantasVacios = LlantasVacios;
				new_values.CeladaVacia = CeladaVacia;
				new_values.PropinaVacia = PropinaVacia;
				new_values.VariosVacios = VariosVacios;
				new_values.ValorCargue = ValorCargue;
				new_values.ValorDescargue = ValorDescargue;
				new_values.Hotel = Hotel;
				new_values.HotelDiasCarretera = HotelDiasCarretera;
				new_values.HotelDiasCiudad = HotelDiasCiudad;
				new_values.HotelVacio = HotelVacio;
				new_values.TiempoReal = TiempoReal;
				new_values.TotalComida = TotalComida;
				new_values.TiempoRutaVacio = TiempoRutaVacio;
				new_values.ComidaVacio = ComidaVacio;
				new_values.DesvareRepuestos = DesvareRepuestos;
				new_values.DesvareManoObra = DesvareManoObra;
				new_values.TotalKm = TotalKm;
				new_values.ParqueaderoCarretera = ParqueaderoCarretera;
				new_values.ParqueaderoCiudad = ParqueaderoCiudad;
				new_values.MontaLlantaCarretera = MontaLlantaCarretera;
				new_values.Papeleria = Papeleria;
				new_values.AjusteCarretera = AjusteCarretera;
				new_values.CombustibleCarretera = CombustibleCarretera;
				new_values.Amarres = Amarres;
				new_values.Engrasada = Engrasada;
				new_values.Calibrada = Calibrada;
				new_values.Aseo = Aseo;
				new_values.Taxi = Taxi;
				new_values.Contenedor1 = Contenedor1;
				new_values.Contenedor2 = Contenedor2;
				new_values.FactorCalculoDia = FactorCalculoDia;
				new_values.ValorFactorCalculo = ValorFactorCalculo;
				new_values.ValorAnticipo = ValorAnticipo;
				new_values.CantidadReal = CantidadReal;
				new_values.LogAnticipoACPM = LogAnticipoACPM;
				new_values.PlacaTrailer = PlacaTrailer;
				TramosAsignadosRutaDataProvider.Instance.Update(RegistroId, Registro, RegistrRuta, RegistroRuttaAJC, Fecha, liquidado, Asignado, Vacio, logAjuste, Peso, EstadoRuta, Trailer, TipoVeh, DesTipoVeh, TipoTrailer, Origen, Destino, Tramos, CantidadGalones, ValorGalones, ValorCOmbustible, Viaticos, SalarioVariable, TotalViaticos, TotalDescuentoViaticos, Total_Viaticos, NroPeajes, ValorPeajes, Llantas, CeladaParqueaderoCarretera, Propina, TotalVarios, LlantasVacios, CeladaVacia, PropinaVacia, VariosVacios, ValorCargue, ValorDescargue, Hotel, HotelDiasCarretera, HotelDiasCiudad, HotelVacio, TiempoReal, TotalComida, TiempoRutaVacio, ComidaVacio, DesvareRepuestos, DesvareManoObra, TotalKm, ParqueaderoCarretera, ParqueaderoCiudad, MontaLlantaCarretera, Papeleria, AjusteCarretera, CombustibleCarretera, Amarres, Engrasada, Calibrada, Aseo, Taxi, Contenedor1, Contenedor2, FactorCalculoDia, ValorFactorCalculo, ValorAnticipo, CantidadReal, LogAnticipoACPM, PlacaTrailer,"TramosAsignadosRuta",datosTransaccion);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Updates an TramosAsignadosRuta object by passing one object's instance as reference
		/// </summary>
		/// <param name="tramosasignadosruta">An instance of TramosAsignadosRuta for reference</param>
		public void Update(TramosAsignadosRuta tramosasignadosruta,Sinapsys.Datos.SQL datosTransaccion=null)
		{
			Update(tramosasignadosruta.RegistroId, tramosasignadosruta.Registro, tramosasignadosruta.RegistrRuta, tramosasignadosruta.RegistroRuttaAJC, tramosasignadosruta.Fecha, tramosasignadosruta.liquidado, tramosasignadosruta.Asignado, tramosasignadosruta.Vacio, tramosasignadosruta.logAjuste, tramosasignadosruta.Peso, tramosasignadosruta.EstadoRuta, tramosasignadosruta.Trailer, tramosasignadosruta.TipoVeh, tramosasignadosruta.DesTipoVeh, tramosasignadosruta.TipoTrailer, tramosasignadosruta.Origen, tramosasignadosruta.Destino, tramosasignadosruta.Tramos, tramosasignadosruta.CantidadGalones, tramosasignadosruta.ValorGalones, tramosasignadosruta.ValorCOmbustible, tramosasignadosruta.Viaticos, tramosasignadosruta.SalarioVariable, tramosasignadosruta.TotalViaticos, tramosasignadosruta.TotalDescuentoViaticos, tramosasignadosruta.Total_Viaticos, tramosasignadosruta.NroPeajes, tramosasignadosruta.ValorPeajes, tramosasignadosruta.Llantas, tramosasignadosruta.CeladaParqueaderoCarretera, tramosasignadosruta.Propina, tramosasignadosruta.TotalVarios, tramosasignadosruta.LlantasVacios, tramosasignadosruta.CeladaVacia, tramosasignadosruta.PropinaVacia, tramosasignadosruta.VariosVacios, tramosasignadosruta.ValorCargue, tramosasignadosruta.ValorDescargue, tramosasignadosruta.Hotel, tramosasignadosruta.HotelDiasCarretera, tramosasignadosruta.HotelDiasCiudad, tramosasignadosruta.HotelVacio, tramosasignadosruta.TiempoReal, tramosasignadosruta.TotalComida, tramosasignadosruta.TiempoRutaVacio, tramosasignadosruta.ComidaVacio, tramosasignadosruta.DesvareRepuestos, tramosasignadosruta.DesvareManoObra, tramosasignadosruta.TotalKm, tramosasignadosruta.ParqueaderoCarretera, tramosasignadosruta.ParqueaderoCiudad, tramosasignadosruta.MontaLlantaCarretera, tramosasignadosruta.Papeleria, tramosasignadosruta.AjusteCarretera, tramosasignadosruta.CombustibleCarretera, tramosasignadosruta.Amarres, tramosasignadosruta.Engrasada, tramosasignadosruta.Calibrada, tramosasignadosruta.Aseo, tramosasignadosruta.Taxi, tramosasignadosruta.Contenedor1, tramosasignadosruta.Contenedor2, tramosasignadosruta.FactorCalculoDia, tramosasignadosruta.ValorFactorCalculo, tramosasignadosruta.ValorAnticipo, tramosasignadosruta.CantidadReal, tramosasignadosruta.LogAnticipoACPM, tramosasignadosruta.PlacaTrailer);
		}

		/// <summary>
		/// Delete  the TramosAsignadosRuta object by passing a object
		/// </summary>
		public void  Delete(TramosAsignadosRuta tramosasignadosruta, Sinapsys.Datos.SQL datosTransaccion=null)
		{
			Delete(tramosasignadosruta.RegistroId, tramosasignadosruta.Registro, tramosasignadosruta.RegistrRuta, tramosasignadosruta.RegistroRuttaAJC,datosTransaccion);
		}

		/// <summary>
		/// Deletes the TramosAsignadosRuta object by passing one object's instance as reference
		/// </summary>
		/// <param name="tramosasignadosruta">An instance of TramosAsignadosRuta for reference</param>
		public void Delete(long RegistroId, long Registro, long RegistrRuta, long RegistroRuttaAJC, Sinapsys.Datos.SQL datosTransaccion=null)
		{
			try 
			{
				//TramosAsignadosRuta old_values = TramosAsignadosRutaController.Instance.Get(RegistroId);
				//if(!Validate.security.CanDeleteSecurityField(TramosAsignadosRutaController.Instance, (ILatinodeObject)old_values))
				//    throw new Exception("Access denied by security field, you can't delete object");

				TramosAsignadosRutaDataProvider.Instance.Delete(RegistroId, Registro, RegistrRuta, RegistroRuttaAJC,"TramosAsignadosRuta");
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Deletes the TramosAsignadosRuta object by passing CVS parameter as reference
		/// </summary>
		/// <param name="tramosasignadosruta">An instance of TramosAsignadosRuta for reference</param>
		public void Delete(string CVSParameter)
		{
			string[] StrCommand=CVSParameter.Split(',');
			try 
			{
				long RegistroId=long.Parse(StrCommand[0]);
				long Registro=long.Parse(StrCommand[1]);
				long RegistrRuta=long.Parse(StrCommand[2]);
				long RegistroRuttaAJC=long.Parse(StrCommand[3]);
				TramosAsignadosRutaDataProvider.Instance.Delete(RegistroId, Registro, RegistrRuta, RegistroRuttaAJC,"TramosAsignadosRuta");
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Gets the TramosAsignadosRuta object by passing the object's key fields
		/// </summary>
		/// <param name="RegistroId">long that contents the RegistroId value for the TramosAsignadosRuta object</param>
		/// <param name="Registro">long that contents the Registro value for the TramosAsignadosRuta object</param>
		/// <param name="RegistrRuta">long that contents the RegistrRuta value for the TramosAsignadosRuta object</param>
		/// <param name="RegistroRuttaAJC">long that contents the RegistroRuttaAJC value for the TramosAsignadosRuta object</param>
		/// <returns>One TramosAsignadosRuta object</returns>
		public TramosAsignadosRuta Get(long RegistroId, long Registro, long RegistrRuta, long RegistroRuttaAJC, bool generateUndo=false)
		{
			try 
			{
				TramosAsignadosRuta tramosasignadosruta = null;
				DataTable dt = TramosAsignadosRutaDataProvider.Instance.Get(RegistroId, Registro, RegistrRuta, RegistroRuttaAJC);
				if ((dt.Rows.Count > 0))
				{
					tramosasignadosruta = new TramosAsignadosRuta();
					DataRow dr = dt.Rows[0];
					ReadData(tramosasignadosruta, dr, generateUndo);
				}


				return tramosasignadosruta;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Gets all objects of TramosAsignadosRuta
		/// </summary>
		/// <returns>One TramosAsignadosRutaList object</returns>
		public TramosAsignadosRutaList GetAll(bool generateUndo=false)
		{
			try 
			{
				TramosAsignadosRutaList tramosasignadosrutalist = new TramosAsignadosRutaList();
				DataTable dt = TramosAsignadosRutaDataProvider.Instance.GetAll();
				foreach (DataRow dr in dt.Rows)
				{
					TramosAsignadosRuta tramosasignadosruta = new TramosAsignadosRuta();
					ReadData(tramosasignadosruta, dr, generateUndo);
					tramosasignadosrutalist.Add(tramosasignadosruta);
				}
				return tramosasignadosrutalist;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Gets all objects of TramosAsignadosRuta applying filter and sort criteria
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
		/// <returns>One TramosAsignadosRutaList object</returns>
		public TramosAsignadosRutaList GetFilter(int pagenum, int pagesize, string filter, string sort, string extablesfilter, string extablesfieldsfilter, string extablesrelationsfilter, string extablessort, string extablesfieldssort, string extablesrelationssort, bool generateUndo=false)
		{
			try 
			{
				TramosAsignadosRutaList tramosasignadosrutalist = new TramosAsignadosRutaList();

				DataTable dt = TramosAsignadosRutaDataProvider.Instance.GetFilter(pagenum, pagesize, filter, sort, extablesfilter, extablesfieldsfilter, extablesrelationsfilter, extablessort, extablesfieldssort, extablesrelationssort);

				foreach (DataRow dr in dt.Rows)
				{
					TramosAsignadosRuta tramosasignadosruta = new TramosAsignadosRuta();
					ReadData(tramosasignadosruta, dr, generateUndo);
					tramosasignadosrutalist.Add(tramosasignadosruta);
				}
				return tramosasignadosrutalist;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public TramosAsignadosRutaList GetFilter( string filter, string sort, bool generateUndo=false)
		{
			return GetFilter(0,0, filter, sort, "","","","","","",generateUndo);
		}

		public TramosAsignadosRutaList GetFilter(string filter, string sort, string extablesfilter, string extablesfieldsfilter, string extablesrelationsfilter, string extablessort, string extablesfieldssort, string extablesrelationssort, bool generateUndo=false)
		{
			return GetFilter(0,0, filter, sort, extablesfilter, extablesfieldsfilter, extablesrelationsfilter, extablessort, extablesfieldssort, extablesrelationssort,generateUndo);
		}


		/// <summary>
		/// Returns the type for one property
		/// </summary>
		/// <param name="propertyname">Property's name for return its value</param>
		/// <returns>A value for the <paramref name="propertyname"/></returns>
		public Type GetMethodType( string propertyname,TramosAsignadosRuta tramosasignadosruta)
		{
			// Perform the search for the property's value
			switch (propertyname)
			{
				case "RegistroId":
					return tramosasignadosruta.RegistroId.GetType();

				case "Registro":
					return tramosasignadosruta.Registro.GetType();

				case "RegistrRuta":
					return tramosasignadosruta.RegistrRuta.GetType();

				case "RegistroRuttaAJC":
					return tramosasignadosruta.RegistroRuttaAJC.GetType();

				case "Fecha":
					return tramosasignadosruta.Fecha.GetType();

				case "liquidado":
					return tramosasignadosruta.liquidado.GetType();

				case "Asignado":
					return tramosasignadosruta.Asignado.GetType();

				case "Vacio":
					return tramosasignadosruta.Vacio.GetType();

				case "logAjuste":
					return tramosasignadosruta.logAjuste.GetType();

				case "Peso":
					return tramosasignadosruta.Peso.GetType();

				case "EstadoRuta":
					return tramosasignadosruta.EstadoRuta.GetType();

				case "Trailer":
					return tramosasignadosruta.Trailer.GetType();

				case "TipoVeh":
					return tramosasignadosruta.TipoVeh.GetType();

				case "DesTipoVeh":
					return tramosasignadosruta.DesTipoVeh.GetType();

				case "TipoTrailer":
					return tramosasignadosruta.TipoTrailer.GetType();

				case "Origen":
					return tramosasignadosruta.Origen.GetType();

				case "Destino":
					return tramosasignadosruta.Destino.GetType();

				case "Tramos":
					return tramosasignadosruta.Tramos.GetType();

				case "CantidadGalones":
					return tramosasignadosruta.CantidadGalones.GetType();

				case "ValorGalones":
					return tramosasignadosruta.ValorGalones.GetType();

				case "ValorCOmbustible":
					return tramosasignadosruta.ValorCOmbustible.GetType();

				case "Viaticos":
					return tramosasignadosruta.Viaticos.GetType();

				case "SalarioVariable":
					return tramosasignadosruta.SalarioVariable.GetType();

				case "TotalViaticos":
					return tramosasignadosruta.TotalViaticos.GetType();

				case "TotalDescuentoViaticos":
					return tramosasignadosruta.TotalDescuentoViaticos.GetType();

				case "Total_Viaticos":
					return tramosasignadosruta.Total_Viaticos.GetType();

				case "NroPeajes":
					return tramosasignadosruta.NroPeajes.GetType();

				case "ValorPeajes":
					return tramosasignadosruta.ValorPeajes.GetType();

				case "Llantas":
					return tramosasignadosruta.Llantas.GetType();

				case "CeladaParqueaderoCarretera":
					return tramosasignadosruta.CeladaParqueaderoCarretera.GetType();

				case "Propina":
					return tramosasignadosruta.Propina.GetType();

				case "TotalVarios":
					return tramosasignadosruta.TotalVarios.GetType();

				case "LlantasVacios":
					return tramosasignadosruta.LlantasVacios.GetType();

				case "CeladaVacia":
					return tramosasignadosruta.CeladaVacia.GetType();

				case "PropinaVacia":
					return tramosasignadosruta.PropinaVacia.GetType();

				case "VariosVacios":
					return tramosasignadosruta.VariosVacios.GetType();

				case "ValorCargue":
					return tramosasignadosruta.ValorCargue.GetType();

				case "ValorDescargue":
					return tramosasignadosruta.ValorDescargue.GetType();

				case "Hotel":
					return tramosasignadosruta.Hotel.GetType();

				case "HotelDiasCarretera":
					return tramosasignadosruta.HotelDiasCarretera.GetType();

				case "HotelDiasCiudad":
					return tramosasignadosruta.HotelDiasCiudad.GetType();

				case "HotelVacio":
					return tramosasignadosruta.HotelVacio.GetType();

				case "TiempoReal":
					return tramosasignadosruta.TiempoReal.GetType();

				case "TotalComida":
					return tramosasignadosruta.TotalComida.GetType();

				case "TiempoRutaVacio":
					return tramosasignadosruta.TiempoRutaVacio.GetType();

				case "ComidaVacio":
					return tramosasignadosruta.ComidaVacio.GetType();

				case "DesvareRepuestos":
					return tramosasignadosruta.DesvareRepuestos.GetType();

				case "DesvareManoObra":
					return tramosasignadosruta.DesvareManoObra.GetType();

				case "TotalKm":
					return tramosasignadosruta.TotalKm.GetType();

				case "ParqueaderoCarretera":
					return tramosasignadosruta.ParqueaderoCarretera.GetType();

				case "ParqueaderoCiudad":
					return tramosasignadosruta.ParqueaderoCiudad.GetType();

				case "MontaLlantaCarretera":
					return tramosasignadosruta.MontaLlantaCarretera.GetType();

				case "Papeleria":
					return tramosasignadosruta.Papeleria.GetType();

				case "AjusteCarretera":
					return tramosasignadosruta.AjusteCarretera.GetType();

				case "CombustibleCarretera":
					return tramosasignadosruta.CombustibleCarretera.GetType();

				case "Amarres":
					return tramosasignadosruta.Amarres.GetType();

				case "Engrasada":
					return tramosasignadosruta.Engrasada.GetType();

				case "Calibrada":
					return tramosasignadosruta.Calibrada.GetType();

				case "Aseo":
					return tramosasignadosruta.Aseo.GetType();

				case "Taxi":
					return tramosasignadosruta.Taxi.GetType();

				case "Contenedor1":
					return tramosasignadosruta.Contenedor1.GetType();

				case "Contenedor2":
					return tramosasignadosruta.Contenedor2.GetType();

				case "FactorCalculoDia":
					return tramosasignadosruta.FactorCalculoDia.GetType();

				case "ValorFactorCalculo":
					return tramosasignadosruta.ValorFactorCalculo.GetType();

				case "ValorAnticipo":
					return tramosasignadosruta.ValorAnticipo.GetType();

				case "CantidadReal":
					return tramosasignadosruta.CantidadReal.GetType();

				case "LogAnticipoACPM":
					return tramosasignadosruta.LogAnticipoACPM.GetType();

				case "PlacaTrailer":
					return tramosasignadosruta.PlacaTrailer.GetType();

			}

			return null;
		}
		/// <summary>
		/// update the changes in TramosAsignadosRuta object by passing the object
		/// </summary>
		public bool UpdateChanges(TramosAsignadosRuta tramosasignadosruta, out string error,Sinapsys.Datos.SQL datosTransaccion=null)
		{
			if (tramosasignadosruta.OldTramosAsignadosRuta == null)
			{
				    error = "No tiene objeto con el cual comparar";
				    return false;
			}
			string[] Fields = tramosasignadosruta.FieldChanged();
			error = "";
			return LiqViajes_Bll_Data.DataProvider.UpdateFieldsbyObject(Fields, tramosasignadosruta, out error,datosTransaccion);
		}
	}

	#endregion

}
