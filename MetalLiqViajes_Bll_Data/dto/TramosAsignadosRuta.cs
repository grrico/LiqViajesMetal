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
using Microsoft.Practices.EnterpriseLibrary.Security.Cryptography;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Runtime.Serialization;

namespace LiqViajes_Bll_Data
{
	#region TramosAsignadosRuta object

	[DataContract]
	public partial class TramosAsignadosRuta : IDTOObject
	{
		/// <summary>
		/// Default constructor
		/// </summary>
		public TramosAsignadosRuta()
		{
			m_RegistroId = 0;
			m_Registro = 0;
			m_RegistrRuta = 0;
			m_RegistroRuttaAJC = 0;
			m_Fecha = null;
			m_liquidado = false;
			m_Asignado = 0;
			m_Vacio = 0;
			m_logAjuste = false;
			m_Peso = 0;
			m_EstadoRuta = false;
			m_Trailer = null;
			m_TipoVeh = 0;
			m_DesTipoVeh = "";
			m_TipoTrailer = 0;
			m_Origen = null;
			m_Destino = null;
			m_Tramos = null;
			m_CantidadGalones = null;
			m_ValorGalones = null;
			m_ValorCOmbustible = null;
			m_Viaticos = null;
			m_SalarioVariable = null;
			m_TotalViaticos = null;
			m_TotalDescuentoViaticos = null;
			m_Total_Viaticos = null;
			m_NroPeajes = null;
			m_ValorPeajes = null;
			m_Llantas = null;
			m_CeladaParqueaderoCarretera = null;
			m_Propina = null;
			m_TotalVarios = null;
			m_LlantasVacios = null;
			m_CeladaVacia = null;
			m_PropinaVacia = null;
			m_VariosVacios = null;
			m_ValorCargue = null;
			m_ValorDescargue = null;
			m_Hotel = null;
			m_HotelDiasCarretera = null;
			m_HotelDiasCiudad = null;
			m_HotelVacio = null;
			m_TiempoReal = null;
			m_TotalComida = null;
			m_TiempoRutaVacio = null;
			m_ComidaVacio = null;
			m_DesvareRepuestos = null;
			m_DesvareManoObra = null;
			m_TotalKm = null;
			m_ParqueaderoCarretera = 0;
			m_ParqueaderoCiudad = 0;
			m_MontaLlantaCarretera = 0;
			m_Papeleria = 0;
			m_AjusteCarretera = 0;
			m_CombustibleCarretera = null;
			m_Amarres = 0;
			m_Engrasada = 0;
			m_Calibrada = 0;
			m_Aseo = null;
			m_Taxi = null;
			m_Contenedor1 = null;
			m_Contenedor2 = null;
			m_FactorCalculoDia = null;
			m_ValorFactorCalculo = null;
			m_ValorAnticipo = null;
			m_CantidadReal = null;
			m_LogAnticipoACPM = false;
			m_PlacaTrailer = null;
			m_changed=false;
		}
		        //Return the table name of object
		        public string TableName()
		        {
		            return "TramosAsignadosRuta";
		        }
		#region Undo 
		// Internal class for storing changes
		private TramosAsignadosRuta m_oldTramosAsignadosRuta;
		public void GenerateUndo()
		{
			m_oldTramosAsignadosRuta=new TramosAsignadosRuta();
			m_oldTramosAsignadosRuta.m_RegistroId = m_RegistroId;
			m_oldTramosAsignadosRuta.m_Registro = m_Registro;
			m_oldTramosAsignadosRuta.m_RegistrRuta = m_RegistrRuta;
			m_oldTramosAsignadosRuta.m_RegistroRuttaAJC = m_RegistroRuttaAJC;
			m_oldTramosAsignadosRuta.Fecha = m_Fecha;
			m_oldTramosAsignadosRuta.liquidado = m_liquidado;
			m_oldTramosAsignadosRuta.Asignado = m_Asignado;
			m_oldTramosAsignadosRuta.Vacio = m_Vacio;
			m_oldTramosAsignadosRuta.logAjuste = m_logAjuste;
			m_oldTramosAsignadosRuta.Peso = m_Peso;
			m_oldTramosAsignadosRuta.EstadoRuta = m_EstadoRuta;
			m_oldTramosAsignadosRuta.Trailer = m_Trailer;
			m_oldTramosAsignadosRuta.TipoVeh = m_TipoVeh;
			m_oldTramosAsignadosRuta.DesTipoVeh = m_DesTipoVeh;
			m_oldTramosAsignadosRuta.TipoTrailer = m_TipoTrailer;
			m_oldTramosAsignadosRuta.Origen = m_Origen;
			m_oldTramosAsignadosRuta.Destino = m_Destino;
			m_oldTramosAsignadosRuta.Tramos = m_Tramos;
			m_oldTramosAsignadosRuta.CantidadGalones = m_CantidadGalones;
			m_oldTramosAsignadosRuta.ValorGalones = m_ValorGalones;
			m_oldTramosAsignadosRuta.ValorCOmbustible = m_ValorCOmbustible;
			m_oldTramosAsignadosRuta.Viaticos = m_Viaticos;
			m_oldTramosAsignadosRuta.SalarioVariable = m_SalarioVariable;
			m_oldTramosAsignadosRuta.TotalViaticos = m_TotalViaticos;
			m_oldTramosAsignadosRuta.TotalDescuentoViaticos = m_TotalDescuentoViaticos;
			m_oldTramosAsignadosRuta.Total_Viaticos = m_Total_Viaticos;
			m_oldTramosAsignadosRuta.NroPeajes = m_NroPeajes;
			m_oldTramosAsignadosRuta.ValorPeajes = m_ValorPeajes;
			m_oldTramosAsignadosRuta.Llantas = m_Llantas;
			m_oldTramosAsignadosRuta.CeladaParqueaderoCarretera = m_CeladaParqueaderoCarretera;
			m_oldTramosAsignadosRuta.Propina = m_Propina;
			m_oldTramosAsignadosRuta.TotalVarios = m_TotalVarios;
			m_oldTramosAsignadosRuta.LlantasVacios = m_LlantasVacios;
			m_oldTramosAsignadosRuta.CeladaVacia = m_CeladaVacia;
			m_oldTramosAsignadosRuta.PropinaVacia = m_PropinaVacia;
			m_oldTramosAsignadosRuta.VariosVacios = m_VariosVacios;
			m_oldTramosAsignadosRuta.ValorCargue = m_ValorCargue;
			m_oldTramosAsignadosRuta.ValorDescargue = m_ValorDescargue;
			m_oldTramosAsignadosRuta.Hotel = m_Hotel;
			m_oldTramosAsignadosRuta.HotelDiasCarretera = m_HotelDiasCarretera;
			m_oldTramosAsignadosRuta.HotelDiasCiudad = m_HotelDiasCiudad;
			m_oldTramosAsignadosRuta.HotelVacio = m_HotelVacio;
			m_oldTramosAsignadosRuta.TiempoReal = m_TiempoReal;
			m_oldTramosAsignadosRuta.TotalComida = m_TotalComida;
			m_oldTramosAsignadosRuta.TiempoRutaVacio = m_TiempoRutaVacio;
			m_oldTramosAsignadosRuta.ComidaVacio = m_ComidaVacio;
			m_oldTramosAsignadosRuta.DesvareRepuestos = m_DesvareRepuestos;
			m_oldTramosAsignadosRuta.DesvareManoObra = m_DesvareManoObra;
			m_oldTramosAsignadosRuta.TotalKm = m_TotalKm;
			m_oldTramosAsignadosRuta.ParqueaderoCarretera = m_ParqueaderoCarretera;
			m_oldTramosAsignadosRuta.ParqueaderoCiudad = m_ParqueaderoCiudad;
			m_oldTramosAsignadosRuta.MontaLlantaCarretera = m_MontaLlantaCarretera;
			m_oldTramosAsignadosRuta.Papeleria = m_Papeleria;
			m_oldTramosAsignadosRuta.AjusteCarretera = m_AjusteCarretera;
			m_oldTramosAsignadosRuta.CombustibleCarretera = m_CombustibleCarretera;
			m_oldTramosAsignadosRuta.Amarres = m_Amarres;
			m_oldTramosAsignadosRuta.Engrasada = m_Engrasada;
			m_oldTramosAsignadosRuta.Calibrada = m_Calibrada;
			m_oldTramosAsignadosRuta.Aseo = m_Aseo;
			m_oldTramosAsignadosRuta.Taxi = m_Taxi;
			m_oldTramosAsignadosRuta.Contenedor1 = m_Contenedor1;
			m_oldTramosAsignadosRuta.Contenedor2 = m_Contenedor2;
			m_oldTramosAsignadosRuta.FactorCalculoDia = m_FactorCalculoDia;
			m_oldTramosAsignadosRuta.ValorFactorCalculo = m_ValorFactorCalculo;
			m_oldTramosAsignadosRuta.ValorAnticipo = m_ValorAnticipo;
			m_oldTramosAsignadosRuta.CantidadReal = m_CantidadReal;
			m_oldTramosAsignadosRuta.LogAnticipoACPM = m_LogAnticipoACPM;
			m_oldTramosAsignadosRuta.PlacaTrailer = m_PlacaTrailer;
		}

		public TramosAsignadosRuta OldTramosAsignadosRuta
		{
			get { return m_oldTramosAsignadosRuta;}
		}
		// Return the changed fields
		public string[] FieldChanged()
		{
			List<string> fields=new List<string>();
			if (m_oldTramosAsignadosRuta.Fecha != m_Fecha) fields.Add("Fecha");
			if (m_oldTramosAsignadosRuta.liquidado != m_liquidado) fields.Add("liquidado");
			if (m_oldTramosAsignadosRuta.Asignado != m_Asignado) fields.Add("Asignado");
			if (m_oldTramosAsignadosRuta.Vacio != m_Vacio) fields.Add("Vacio");
			if (m_oldTramosAsignadosRuta.logAjuste != m_logAjuste) fields.Add("logAjuste");
			if (m_oldTramosAsignadosRuta.Peso != m_Peso) fields.Add("Peso");
			if (m_oldTramosAsignadosRuta.EstadoRuta != m_EstadoRuta) fields.Add("EstadoRuta");
			if (m_oldTramosAsignadosRuta.Trailer != m_Trailer) fields.Add("Trailer");
			if (m_oldTramosAsignadosRuta.TipoVeh != m_TipoVeh) fields.Add("TipoVeh");
			if (m_oldTramosAsignadosRuta.DesTipoVeh != m_DesTipoVeh) fields.Add("DesTipoVeh");
			if (m_oldTramosAsignadosRuta.TipoTrailer != m_TipoTrailer) fields.Add("TipoTrailer");
			if (m_oldTramosAsignadosRuta.Origen != m_Origen) fields.Add("Origen");
			if (m_oldTramosAsignadosRuta.Destino != m_Destino) fields.Add("Destino");
			if (m_oldTramosAsignadosRuta.Tramos != m_Tramos) fields.Add("Tramos");
			if (m_oldTramosAsignadosRuta.CantidadGalones != m_CantidadGalones) fields.Add("CantidadGalones");
			if (m_oldTramosAsignadosRuta.ValorGalones != m_ValorGalones) fields.Add("ValorGalones");
			if (m_oldTramosAsignadosRuta.ValorCOmbustible != m_ValorCOmbustible) fields.Add("ValorCOmbustible");
			if (m_oldTramosAsignadosRuta.Viaticos != m_Viaticos) fields.Add("Viaticos");
			if (m_oldTramosAsignadosRuta.SalarioVariable != m_SalarioVariable) fields.Add("SalarioVariable");
			if (m_oldTramosAsignadosRuta.TotalViaticos != m_TotalViaticos) fields.Add("TotalViaticos");
			if (m_oldTramosAsignadosRuta.TotalDescuentoViaticos != m_TotalDescuentoViaticos) fields.Add("TotalDescuentoViaticos");
			if (m_oldTramosAsignadosRuta.Total_Viaticos != m_Total_Viaticos) fields.Add("Total_Viaticos");
			if (m_oldTramosAsignadosRuta.NroPeajes != m_NroPeajes) fields.Add("NroPeajes");
			if (m_oldTramosAsignadosRuta.ValorPeajes != m_ValorPeajes) fields.Add("ValorPeajes");
			if (m_oldTramosAsignadosRuta.Llantas != m_Llantas) fields.Add("Llantas");
			if (m_oldTramosAsignadosRuta.CeladaParqueaderoCarretera != m_CeladaParqueaderoCarretera) fields.Add("CeladaParqueaderoCarretera");
			if (m_oldTramosAsignadosRuta.Propina != m_Propina) fields.Add("Propina");
			if (m_oldTramosAsignadosRuta.TotalVarios != m_TotalVarios) fields.Add("TotalVarios");
			if (m_oldTramosAsignadosRuta.LlantasVacios != m_LlantasVacios) fields.Add("LlantasVacios");
			if (m_oldTramosAsignadosRuta.CeladaVacia != m_CeladaVacia) fields.Add("CeladaVacia");
			if (m_oldTramosAsignadosRuta.PropinaVacia != m_PropinaVacia) fields.Add("PropinaVacia");
			if (m_oldTramosAsignadosRuta.VariosVacios != m_VariosVacios) fields.Add("VariosVacios");
			if (m_oldTramosAsignadosRuta.ValorCargue != m_ValorCargue) fields.Add("ValorCargue");
			if (m_oldTramosAsignadosRuta.ValorDescargue != m_ValorDescargue) fields.Add("ValorDescargue");
			if (m_oldTramosAsignadosRuta.Hotel != m_Hotel) fields.Add("Hotel");
			if (m_oldTramosAsignadosRuta.HotelDiasCarretera != m_HotelDiasCarretera) fields.Add("HotelDiasCarretera");
			if (m_oldTramosAsignadosRuta.HotelDiasCiudad != m_HotelDiasCiudad) fields.Add("HotelDiasCiudad");
			if (m_oldTramosAsignadosRuta.HotelVacio != m_HotelVacio) fields.Add("HotelVacio");
			if (m_oldTramosAsignadosRuta.TiempoReal != m_TiempoReal) fields.Add("TiempoReal");
			if (m_oldTramosAsignadosRuta.TotalComida != m_TotalComida) fields.Add("TotalComida");
			if (m_oldTramosAsignadosRuta.TiempoRutaVacio != m_TiempoRutaVacio) fields.Add("TiempoRutaVacio");
			if (m_oldTramosAsignadosRuta.ComidaVacio != m_ComidaVacio) fields.Add("ComidaVacio");
			if (m_oldTramosAsignadosRuta.DesvareRepuestos != m_DesvareRepuestos) fields.Add("DesvareRepuestos");
			if (m_oldTramosAsignadosRuta.DesvareManoObra != m_DesvareManoObra) fields.Add("DesvareManoObra");
			if (m_oldTramosAsignadosRuta.TotalKm != m_TotalKm) fields.Add("TotalKm");
			if (m_oldTramosAsignadosRuta.ParqueaderoCarretera != m_ParqueaderoCarretera) fields.Add("ParqueaderoCarretera");
			if (m_oldTramosAsignadosRuta.ParqueaderoCiudad != m_ParqueaderoCiudad) fields.Add("ParqueaderoCiudad");
			if (m_oldTramosAsignadosRuta.MontaLlantaCarretera != m_MontaLlantaCarretera) fields.Add("MontaLlantaCarretera");
			if (m_oldTramosAsignadosRuta.Papeleria != m_Papeleria) fields.Add("Papeleria");
			if (m_oldTramosAsignadosRuta.AjusteCarretera != m_AjusteCarretera) fields.Add("AjusteCarretera");
			if (m_oldTramosAsignadosRuta.CombustibleCarretera != m_CombustibleCarretera) fields.Add("CombustibleCarretera");
			if (m_oldTramosAsignadosRuta.Amarres != m_Amarres) fields.Add("Amarres");
			if (m_oldTramosAsignadosRuta.Engrasada != m_Engrasada) fields.Add("Engrasada");
			if (m_oldTramosAsignadosRuta.Calibrada != m_Calibrada) fields.Add("Calibrada");
			if (m_oldTramosAsignadosRuta.Aseo != m_Aseo) fields.Add("Aseo");
			if (m_oldTramosAsignadosRuta.Taxi != m_Taxi) fields.Add("Taxi");
			if (m_oldTramosAsignadosRuta.Contenedor1 != m_Contenedor1) fields.Add("Contenedor1");
			if (m_oldTramosAsignadosRuta.Contenedor2 != m_Contenedor2) fields.Add("Contenedor2");
			if (m_oldTramosAsignadosRuta.FactorCalculoDia != m_FactorCalculoDia) fields.Add("FactorCalculoDia");
			if (m_oldTramosAsignadosRuta.ValorFactorCalculo != m_ValorFactorCalculo) fields.Add("ValorFactorCalculo");
			if (m_oldTramosAsignadosRuta.ValorAnticipo != m_ValorAnticipo) fields.Add("ValorAnticipo");
			if (m_oldTramosAsignadosRuta.CantidadReal != m_CantidadReal) fields.Add("CantidadReal");
			if (m_oldTramosAsignadosRuta.LogAnticipoACPM != m_LogAnticipoACPM) fields.Add("LogAnticipoACPM");
			if (m_oldTramosAsignadosRuta.PlacaTrailer != m_PlacaTrailer) fields.Add("PlacaTrailer");
			string[] fieldst = new string[fields.Count];
			int i = 0;
			foreach(string st in fields)
			{
				fieldst[i]=st;
				i++;
			}
			return fieldst;
		}
		#endregion
		#region Fields


		// Field for storing the TramosAsignadosRuta's RegistroId value
		private long m_RegistroId;

		// Field for storing the TramosAsignadosRuta's Registro value
		private long m_Registro;

		// Field for storing the TramosAsignadosRuta's RegistrRuta value
		private long m_RegistrRuta;

		// Field for storing the TramosAsignadosRuta's RegistroRuttaAJC value
		private long m_RegistroRuttaAJC;

		// Field for storing the TramosAsignadosRuta's Fecha value
		private DateTime? m_Fecha;

		// Field for storing the TramosAsignadosRuta's liquidado value
		private bool m_liquidado;

		// Field for storing the TramosAsignadosRuta's Asignado value
		private int m_Asignado;

		// Field for storing the TramosAsignadosRuta's Vacio value
		private int m_Vacio;

		// Field for storing the TramosAsignadosRuta's logAjuste value
		private bool? m_logAjuste;

		// Field for storing the TramosAsignadosRuta's Peso value
		private int m_Peso;

		// Field for storing the TramosAsignadosRuta's EstadoRuta value
		private bool? m_EstadoRuta;

		// Field for storing the TramosAsignadosRuta's Trailer value
		private string m_Trailer;

		// Field for storing the TramosAsignadosRuta's TipoVeh value
		private int m_TipoVeh;

		// Field for storing the TramosAsignadosRuta's DesTipoVeh value
		private string m_DesTipoVeh;

		// Field for storing the TramosAsignadosRuta's TipoTrailer value
		private int m_TipoTrailer;

		// Field for storing the TramosAsignadosRuta's Origen value
		private string m_Origen;

		// Field for storing the TramosAsignadosRuta's Destino value
		private string m_Destino;

		// Field for storing the TramosAsignadosRuta's Tramos value
		private string m_Tramos;

		// Field for storing the TramosAsignadosRuta's CantidadGalones value
		private decimal? m_CantidadGalones;

		// Field for storing the TramosAsignadosRuta's ValorGalones value
		private decimal? m_ValorGalones;

		// Field for storing the TramosAsignadosRuta's ValorCOmbustible value
		private decimal? m_ValorCOmbustible;

		// Field for storing the TramosAsignadosRuta's Viaticos value
		private decimal? m_Viaticos;

		// Field for storing the TramosAsignadosRuta's SalarioVariable value
		private decimal? m_SalarioVariable;

		// Field for storing the TramosAsignadosRuta's TotalViaticos value
		private decimal? m_TotalViaticos;

		// Field for storing the TramosAsignadosRuta's TotalDescuentoViaticos value
		private decimal? m_TotalDescuentoViaticos;

		// Field for storing the TramosAsignadosRuta's Total_Viaticos value
		private decimal? m_Total_Viaticos;

		// Field for storing the TramosAsignadosRuta's NroPeajes value
		private int? m_NroPeajes;

		// Field for storing the TramosAsignadosRuta's ValorPeajes value
		private decimal? m_ValorPeajes;

		// Field for storing the TramosAsignadosRuta's Llantas value
		private decimal? m_Llantas;

		// Field for storing the TramosAsignadosRuta's CeladaParqueaderoCarretera value
		private decimal? m_CeladaParqueaderoCarretera;

		// Field for storing the TramosAsignadosRuta's Propina value
		private decimal? m_Propina;

		// Field for storing the TramosAsignadosRuta's TotalVarios value
		private decimal? m_TotalVarios;

		// Field for storing the TramosAsignadosRuta's LlantasVacios value
		private decimal? m_LlantasVacios;

		// Field for storing the TramosAsignadosRuta's CeladaVacia value
		private decimal? m_CeladaVacia;

		// Field for storing the TramosAsignadosRuta's PropinaVacia value
		private decimal? m_PropinaVacia;

		// Field for storing the TramosAsignadosRuta's VariosVacios value
		private decimal? m_VariosVacios;

		// Field for storing the TramosAsignadosRuta's ValorCargue value
		private decimal? m_ValorCargue;

		// Field for storing the TramosAsignadosRuta's ValorDescargue value
		private decimal? m_ValorDescargue;

		// Field for storing the TramosAsignadosRuta's Hotel value
		private decimal? m_Hotel;

		// Field for storing the TramosAsignadosRuta's HotelDiasCarretera value
		private int? m_HotelDiasCarretera;

		// Field for storing the TramosAsignadosRuta's HotelDiasCiudad value
		private int? m_HotelDiasCiudad;

		// Field for storing the TramosAsignadosRuta's HotelVacio value
		private decimal? m_HotelVacio;

		// Field for storing the TramosAsignadosRuta's TiempoReal value
		private decimal? m_TiempoReal;

		// Field for storing the TramosAsignadosRuta's TotalComida value
		private decimal? m_TotalComida;

		// Field for storing the TramosAsignadosRuta's TiempoRutaVacio value
		private decimal? m_TiempoRutaVacio;

		// Field for storing the TramosAsignadosRuta's ComidaVacio value
		private decimal? m_ComidaVacio;

		// Field for storing the TramosAsignadosRuta's DesvareRepuestos value
		private decimal? m_DesvareRepuestos;

		// Field for storing the TramosAsignadosRuta's DesvareManoObra value
		private decimal? m_DesvareManoObra;

		// Field for storing the TramosAsignadosRuta's TotalKm value
		private decimal? m_TotalKm;

		// Field for storing the TramosAsignadosRuta's ParqueaderoCarretera value
		private decimal m_ParqueaderoCarretera;

		// Field for storing the TramosAsignadosRuta's ParqueaderoCiudad value
		private decimal m_ParqueaderoCiudad;

		// Field for storing the TramosAsignadosRuta's MontaLlantaCarretera value
		private decimal m_MontaLlantaCarretera;

		// Field for storing the TramosAsignadosRuta's Papeleria value
		private decimal m_Papeleria;

		// Field for storing the TramosAsignadosRuta's AjusteCarretera value
		private decimal m_AjusteCarretera;

		// Field for storing the TramosAsignadosRuta's CombustibleCarretera value
		private decimal? m_CombustibleCarretera;

		// Field for storing the TramosAsignadosRuta's Amarres value
		private decimal m_Amarres;

		// Field for storing the TramosAsignadosRuta's Engrasada value
		private decimal m_Engrasada;

		// Field for storing the TramosAsignadosRuta's Calibrada value
		private decimal m_Calibrada;

		// Field for storing the TramosAsignadosRuta's Aseo value
		private decimal? m_Aseo;

		// Field for storing the TramosAsignadosRuta's Taxi value
		private decimal? m_Taxi;

		// Field for storing the TramosAsignadosRuta's Contenedor1 value
		private string m_Contenedor1;

		// Field for storing the TramosAsignadosRuta's Contenedor2 value
		private string m_Contenedor2;

		// Field for storing the TramosAsignadosRuta's FactorCalculoDia value
		private int? m_FactorCalculoDia;

		// Field for storing the TramosAsignadosRuta's ValorFactorCalculo value
		private decimal? m_ValorFactorCalculo;

		// Field for storing the TramosAsignadosRuta's ValorAnticipo value
		private decimal? m_ValorAnticipo;

		// Field for storing the TramosAsignadosRuta's CantidadReal value
		private decimal? m_CantidadReal;

		// Field for storing the TramosAsignadosRuta's LogAnticipoACPM value
		private bool? m_LogAnticipoACPM;

		// Field for storing the TramosAsignadosRuta's PlacaTrailer value
		private string m_PlacaTrailer;

		// Evaluate changed state
		private bool m_changed=false;

		#endregion

		#region Attributes

		// Return if object changed
		public bool Changed
		{
			get { return m_changed;}
			set { m_changed=value;}
		}
		/// <summary>
		/// Attribute for access the TramosAsignadosRuta's RegistroId value (long)
		/// </summary>
		[DataMember]
		public long RegistroId
		{
			get { return m_RegistroId; }
			set 
			{
				m_changed=true;
				m_RegistroId = value;
			}
		}

		/// <summary>
		/// Attribute for access the TramosAsignadosRuta's Registro value (long)
		/// </summary>
		[DataMember]
		public long Registro
		{
			get { return m_Registro; }
			set 
			{
				m_changed=true;
				m_Registro = value;
			}
		}

		/// <summary>
		/// Attribute for access the TramosAsignadosRuta's RegistrRuta value (long)
		/// </summary>
		[DataMember]
		public long RegistrRuta
		{
			get { return m_RegistrRuta; }
			set 
			{
				m_changed=true;
				m_RegistrRuta = value;
			}
		}

		/// <summary>
		/// Attribute for access the TramosAsignadosRuta's RegistroRuttaAJC value (long)
		/// </summary>
		[DataMember]
		public long RegistroRuttaAJC
		{
			get { return m_RegistroRuttaAJC; }
			set 
			{
				m_changed=true;
				m_RegistroRuttaAJC = value;
			}
		}

		/// <summary>
		/// Attribute for access the TramosAsignadosRuta's Fecha value (DateTime)
		/// </summary>
		[DataMember]
		public DateTime? Fecha
		{
			get { return m_Fecha; }
			set 
			{
				m_changed=true;
				m_Fecha = value;
			}
		}

		/// <summary>
		/// Attribute for access the TramosAsignadosRuta's liquidado value (bool)
		/// </summary>
		[DataMember]
		public bool liquidado
		{
			get { return m_liquidado; }
			set 
			{
				m_changed=true;
				m_liquidado = value;
			}
		}

		/// <summary>
		/// Attribute for access the TramosAsignadosRuta's Asignado value (int)
		/// </summary>
		[DataMember]
		public int Asignado
		{
			get { return m_Asignado; }
			set 
			{
				m_changed=true;
				m_Asignado = value;
			}
		}

		/// <summary>
		/// Attribute for access the TramosAsignadosRuta's Vacio value (int)
		/// </summary>
		[DataMember]
		public int Vacio
		{
			get { return m_Vacio; }
			set 
			{
				m_changed=true;
				m_Vacio = value;
			}
		}

		/// <summary>
		/// Attribute for access the TramosAsignadosRuta's logAjuste value (bool)
		/// </summary>
		[DataMember]
		public bool? logAjuste
		{
			get { return m_logAjuste; }
			set 
			{
				m_changed=true;
				m_logAjuste = value;
			}
		}

		/// <summary>
		/// Attribute for access the TramosAsignadosRuta's Peso value (int)
		/// </summary>
		[DataMember]
		public int Peso
		{
			get { return m_Peso; }
			set 
			{
				m_changed=true;
				m_Peso = value;
			}
		}

		/// <summary>
		/// Attribute for access the TramosAsignadosRuta's EstadoRuta value (bool)
		/// </summary>
		[DataMember]
		public bool? EstadoRuta
		{
			get { return m_EstadoRuta; }
			set 
			{
				m_changed=true;
				m_EstadoRuta = value;
			}
		}

		/// <summary>
		/// Attribute for access the TramosAsignadosRuta's Trailer value (string)
		/// </summary>
		[DataMember]
		public string Trailer
		{
			get { return m_Trailer; }
			set 
			{
				m_changed=true;
				m_Trailer = value;
			}
		}

		/// <summary>
		/// Attribute for access the TramosAsignadosRuta's TipoVeh value (int)
		/// </summary>
		[DataMember]
		public int TipoVeh
		{
			get { return m_TipoVeh; }
			set 
			{
				m_changed=true;
				m_TipoVeh = value;
			}
		}

		/// <summary>
		/// Attribute for access the TramosAsignadosRuta's DesTipoVeh value (string)
		/// </summary>
		[DataMember]
		public string DesTipoVeh
		{
			get { return m_DesTipoVeh; }
			set 
			{
				m_changed=true;
				m_DesTipoVeh = value;
			}
		}

		/// <summary>
		/// Attribute for access the TramosAsignadosRuta's TipoTrailer value (int)
		/// </summary>
		[DataMember]
		public int TipoTrailer
		{
			get { return m_TipoTrailer; }
			set 
			{
				m_changed=true;
				m_TipoTrailer = value;
			}
		}

		/// <summary>
		/// Attribute for access the TramosAsignadosRuta's Origen value (string)
		/// </summary>
		[DataMember]
		public string Origen
		{
			get { return m_Origen; }
			set 
			{
				m_changed=true;
				m_Origen = value;
			}
		}

		/// <summary>
		/// Attribute for access the TramosAsignadosRuta's Destino value (string)
		/// </summary>
		[DataMember]
		public string Destino
		{
			get { return m_Destino; }
			set 
			{
				m_changed=true;
				m_Destino = value;
			}
		}

		/// <summary>
		/// Attribute for access the TramosAsignadosRuta's Tramos value (string)
		/// </summary>
		[DataMember]
		public string Tramos
		{
			get { return m_Tramos; }
			set 
			{
				m_changed=true;
				m_Tramos = value;
			}
		}

		/// <summary>
		/// Attribute for access the TramosAsignadosRuta's CantidadGalones value (decimal)
		/// </summary>
		[DataMember]
		public decimal? CantidadGalones
		{
			get { return m_CantidadGalones; }
			set 
			{
				m_changed=true;
				m_CantidadGalones = value;
			}
		}

		/// <summary>
		/// Attribute for access the TramosAsignadosRuta's ValorGalones value (decimal)
		/// </summary>
		[DataMember]
		public decimal? ValorGalones
		{
			get { return m_ValorGalones; }
			set 
			{
				m_changed=true;
				m_ValorGalones = value;
			}
		}

		/// <summary>
		/// Attribute for access the TramosAsignadosRuta's ValorCOmbustible value (decimal)
		/// </summary>
		[DataMember]
		public decimal? ValorCOmbustible
		{
			get { return m_ValorCOmbustible; }
			set 
			{
				m_changed=true;
				m_ValorCOmbustible = value;
			}
		}

		/// <summary>
		/// Attribute for access the TramosAsignadosRuta's Viaticos value (decimal)
		/// </summary>
		[DataMember]
		public decimal? Viaticos
		{
			get { return m_Viaticos; }
			set 
			{
				m_changed=true;
				m_Viaticos = value;
			}
		}

		/// <summary>
		/// Attribute for access the TramosAsignadosRuta's SalarioVariable value (decimal)
		/// </summary>
		[DataMember]
		public decimal? SalarioVariable
		{
			get { return m_SalarioVariable; }
			set 
			{
				m_changed=true;
				m_SalarioVariable = value;
			}
		}

		/// <summary>
		/// Attribute for access the TramosAsignadosRuta's TotalViaticos value (decimal)
		/// </summary>
		[DataMember]
		public decimal? TotalViaticos
		{
			get { return m_TotalViaticos; }
			set 
			{
				m_changed=true;
				m_TotalViaticos = value;
			}
		}

		/// <summary>
		/// Attribute for access the TramosAsignadosRuta's TotalDescuentoViaticos value (decimal)
		/// </summary>
		[DataMember]
		public decimal? TotalDescuentoViaticos
		{
			get { return m_TotalDescuentoViaticos; }
			set 
			{
				m_changed=true;
				m_TotalDescuentoViaticos = value;
			}
		}

		/// <summary>
		/// Attribute for access the TramosAsignadosRuta's Total_Viaticos value (decimal)
		/// </summary>
		[DataMember]
		public decimal? Total_Viaticos
		{
			get { return m_Total_Viaticos; }
			set 
			{
				m_changed=true;
				m_Total_Viaticos = value;
			}
		}

		/// <summary>
		/// Attribute for access the TramosAsignadosRuta's NroPeajes value (int)
		/// </summary>
		[DataMember]
		public int? NroPeajes
		{
			get { return m_NroPeajes; }
			set 
			{
				m_changed=true;
				m_NroPeajes = value;
			}
		}

		/// <summary>
		/// Attribute for access the TramosAsignadosRuta's ValorPeajes value (decimal)
		/// </summary>
		[DataMember]
		public decimal? ValorPeajes
		{
			get { return m_ValorPeajes; }
			set 
			{
				m_changed=true;
				m_ValorPeajes = value;
			}
		}

		/// <summary>
		/// Attribute for access the TramosAsignadosRuta's Llantas value (decimal)
		/// </summary>
		[DataMember]
		public decimal? Llantas
		{
			get { return m_Llantas; }
			set 
			{
				m_changed=true;
				m_Llantas = value;
			}
		}

		/// <summary>
		/// Attribute for access the TramosAsignadosRuta's CeladaParqueaderoCarretera value (decimal)
		/// </summary>
		[DataMember]
		public decimal? CeladaParqueaderoCarretera
		{
			get { return m_CeladaParqueaderoCarretera; }
			set 
			{
				m_changed=true;
				m_CeladaParqueaderoCarretera = value;
			}
		}

		/// <summary>
		/// Attribute for access the TramosAsignadosRuta's Propina value (decimal)
		/// </summary>
		[DataMember]
		public decimal? Propina
		{
			get { return m_Propina; }
			set 
			{
				m_changed=true;
				m_Propina = value;
			}
		}

		/// <summary>
		/// Attribute for access the TramosAsignadosRuta's TotalVarios value (decimal)
		/// </summary>
		[DataMember]
		public decimal? TotalVarios
		{
			get { return m_TotalVarios; }
			set 
			{
				m_changed=true;
				m_TotalVarios = value;
			}
		}

		/// <summary>
		/// Attribute for access the TramosAsignadosRuta's LlantasVacios value (decimal)
		/// </summary>
		[DataMember]
		public decimal? LlantasVacios
		{
			get { return m_LlantasVacios; }
			set 
			{
				m_changed=true;
				m_LlantasVacios = value;
			}
		}

		/// <summary>
		/// Attribute for access the TramosAsignadosRuta's CeladaVacia value (decimal)
		/// </summary>
		[DataMember]
		public decimal? CeladaVacia
		{
			get { return m_CeladaVacia; }
			set 
			{
				m_changed=true;
				m_CeladaVacia = value;
			}
		}

		/// <summary>
		/// Attribute for access the TramosAsignadosRuta's PropinaVacia value (decimal)
		/// </summary>
		[DataMember]
		public decimal? PropinaVacia
		{
			get { return m_PropinaVacia; }
			set 
			{
				m_changed=true;
				m_PropinaVacia = value;
			}
		}

		/// <summary>
		/// Attribute for access the TramosAsignadosRuta's VariosVacios value (decimal)
		/// </summary>
		[DataMember]
		public decimal? VariosVacios
		{
			get { return m_VariosVacios; }
			set 
			{
				m_changed=true;
				m_VariosVacios = value;
			}
		}

		/// <summary>
		/// Attribute for access the TramosAsignadosRuta's ValorCargue value (decimal)
		/// </summary>
		[DataMember]
		public decimal? ValorCargue
		{
			get { return m_ValorCargue; }
			set 
			{
				m_changed=true;
				m_ValorCargue = value;
			}
		}

		/// <summary>
		/// Attribute for access the TramosAsignadosRuta's ValorDescargue value (decimal)
		/// </summary>
		[DataMember]
		public decimal? ValorDescargue
		{
			get { return m_ValorDescargue; }
			set 
			{
				m_changed=true;
				m_ValorDescargue = value;
			}
		}

		/// <summary>
		/// Attribute for access the TramosAsignadosRuta's Hotel value (decimal)
		/// </summary>
		[DataMember]
		public decimal? Hotel
		{
			get { return m_Hotel; }
			set 
			{
				m_changed=true;
				m_Hotel = value;
			}
		}

		/// <summary>
		/// Attribute for access the TramosAsignadosRuta's HotelDiasCarretera value (int)
		/// </summary>
		[DataMember]
		public int? HotelDiasCarretera
		{
			get { return m_HotelDiasCarretera; }
			set 
			{
				m_changed=true;
				m_HotelDiasCarretera = value;
			}
		}

		/// <summary>
		/// Attribute for access the TramosAsignadosRuta's HotelDiasCiudad value (int)
		/// </summary>
		[DataMember]
		public int? HotelDiasCiudad
		{
			get { return m_HotelDiasCiudad; }
			set 
			{
				m_changed=true;
				m_HotelDiasCiudad = value;
			}
		}

		/// <summary>
		/// Attribute for access the TramosAsignadosRuta's HotelVacio value (decimal)
		/// </summary>
		[DataMember]
		public decimal? HotelVacio
		{
			get { return m_HotelVacio; }
			set 
			{
				m_changed=true;
				m_HotelVacio = value;
			}
		}

		/// <summary>
		/// Attribute for access the TramosAsignadosRuta's TiempoReal value (decimal)
		/// </summary>
		[DataMember]
		public decimal? TiempoReal
		{
			get { return m_TiempoReal; }
			set 
			{
				m_changed=true;
				m_TiempoReal = value;
			}
		}

		/// <summary>
		/// Attribute for access the TramosAsignadosRuta's TotalComida value (decimal)
		/// </summary>
		[DataMember]
		public decimal? TotalComida
		{
			get { return m_TotalComida; }
			set 
			{
				m_changed=true;
				m_TotalComida = value;
			}
		}

		/// <summary>
		/// Attribute for access the TramosAsignadosRuta's TiempoRutaVacio value (decimal)
		/// </summary>
		[DataMember]
		public decimal? TiempoRutaVacio
		{
			get { return m_TiempoRutaVacio; }
			set 
			{
				m_changed=true;
				m_TiempoRutaVacio = value;
			}
		}

		/// <summary>
		/// Attribute for access the TramosAsignadosRuta's ComidaVacio value (decimal)
		/// </summary>
		[DataMember]
		public decimal? ComidaVacio
		{
			get { return m_ComidaVacio; }
			set 
			{
				m_changed=true;
				m_ComidaVacio = value;
			}
		}

		/// <summary>
		/// Attribute for access the TramosAsignadosRuta's DesvareRepuestos value (decimal)
		/// </summary>
		[DataMember]
		public decimal? DesvareRepuestos
		{
			get { return m_DesvareRepuestos; }
			set 
			{
				m_changed=true;
				m_DesvareRepuestos = value;
			}
		}

		/// <summary>
		/// Attribute for access the TramosAsignadosRuta's DesvareManoObra value (decimal)
		/// </summary>
		[DataMember]
		public decimal? DesvareManoObra
		{
			get { return m_DesvareManoObra; }
			set 
			{
				m_changed=true;
				m_DesvareManoObra = value;
			}
		}

		/// <summary>
		/// Attribute for access the TramosAsignadosRuta's TotalKm value (decimal)
		/// </summary>
		[DataMember]
		public decimal? TotalKm
		{
			get { return m_TotalKm; }
			set 
			{
				m_changed=true;
				m_TotalKm = value;
			}
		}

		/// <summary>
		/// Attribute for access the TramosAsignadosRuta's ParqueaderoCarretera value (decimal)
		/// </summary>
		[DataMember]
		public decimal ParqueaderoCarretera
		{
			get { return m_ParqueaderoCarretera; }
			set 
			{
				m_changed=true;
				m_ParqueaderoCarretera = value;
			}
		}

		/// <summary>
		/// Attribute for access the TramosAsignadosRuta's ParqueaderoCiudad value (decimal)
		/// </summary>
		[DataMember]
		public decimal ParqueaderoCiudad
		{
			get { return m_ParqueaderoCiudad; }
			set 
			{
				m_changed=true;
				m_ParqueaderoCiudad = value;
			}
		}

		/// <summary>
		/// Attribute for access the TramosAsignadosRuta's MontaLlantaCarretera value (decimal)
		/// </summary>
		[DataMember]
		public decimal MontaLlantaCarretera
		{
			get { return m_MontaLlantaCarretera; }
			set 
			{
				m_changed=true;
				m_MontaLlantaCarretera = value;
			}
		}

		/// <summary>
		/// Attribute for access the TramosAsignadosRuta's Papeleria value (decimal)
		/// </summary>
		[DataMember]
		public decimal Papeleria
		{
			get { return m_Papeleria; }
			set 
			{
				m_changed=true;
				m_Papeleria = value;
			}
		}

		/// <summary>
		/// Attribute for access the TramosAsignadosRuta's AjusteCarretera value (decimal)
		/// </summary>
		[DataMember]
		public decimal AjusteCarretera
		{
			get { return m_AjusteCarretera; }
			set 
			{
				m_changed=true;
				m_AjusteCarretera = value;
			}
		}

		/// <summary>
		/// Attribute for access the TramosAsignadosRuta's CombustibleCarretera value (decimal)
		/// </summary>
		[DataMember]
		public decimal? CombustibleCarretera
		{
			get { return m_CombustibleCarretera; }
			set 
			{
				m_changed=true;
				m_CombustibleCarretera = value;
			}
		}

		/// <summary>
		/// Attribute for access the TramosAsignadosRuta's Amarres value (decimal)
		/// </summary>
		[DataMember]
		public decimal Amarres
		{
			get { return m_Amarres; }
			set 
			{
				m_changed=true;
				m_Amarres = value;
			}
		}

		/// <summary>
		/// Attribute for access the TramosAsignadosRuta's Engrasada value (decimal)
		/// </summary>
		[DataMember]
		public decimal Engrasada
		{
			get { return m_Engrasada; }
			set 
			{
				m_changed=true;
				m_Engrasada = value;
			}
		}

		/// <summary>
		/// Attribute for access the TramosAsignadosRuta's Calibrada value (decimal)
		/// </summary>
		[DataMember]
		public decimal Calibrada
		{
			get { return m_Calibrada; }
			set 
			{
				m_changed=true;
				m_Calibrada = value;
			}
		}

		/// <summary>
		/// Attribute for access the TramosAsignadosRuta's Aseo value (decimal)
		/// </summary>
		[DataMember]
		public decimal? Aseo
		{
			get { return m_Aseo; }
			set 
			{
				m_changed=true;
				m_Aseo = value;
			}
		}

		/// <summary>
		/// Attribute for access the TramosAsignadosRuta's Taxi value (decimal)
		/// </summary>
		[DataMember]
		public decimal? Taxi
		{
			get { return m_Taxi; }
			set 
			{
				m_changed=true;
				m_Taxi = value;
			}
		}

		/// <summary>
		/// Attribute for access the TramosAsignadosRuta's Contenedor1 value (string)
		/// </summary>
		[DataMember]
		public string Contenedor1
		{
			get { return m_Contenedor1; }
			set 
			{
				m_changed=true;
				m_Contenedor1 = value;
			}
		}

		/// <summary>
		/// Attribute for access the TramosAsignadosRuta's Contenedor2 value (string)
		/// </summary>
		[DataMember]
		public string Contenedor2
		{
			get { return m_Contenedor2; }
			set 
			{
				m_changed=true;
				m_Contenedor2 = value;
			}
		}

		/// <summary>
		/// Attribute for access the TramosAsignadosRuta's FactorCalculoDia value (int)
		/// </summary>
		[DataMember]
		public int? FactorCalculoDia
		{
			get { return m_FactorCalculoDia; }
			set 
			{
				m_changed=true;
				m_FactorCalculoDia = value;
			}
		}

		/// <summary>
		/// Attribute for access the TramosAsignadosRuta's ValorFactorCalculo value (decimal)
		/// </summary>
		[DataMember]
		public decimal? ValorFactorCalculo
		{
			get { return m_ValorFactorCalculo; }
			set 
			{
				m_changed=true;
				m_ValorFactorCalculo = value;
			}
		}

		/// <summary>
		/// Attribute for access the TramosAsignadosRuta's ValorAnticipo value (decimal)
		/// </summary>
		[DataMember]
		public decimal? ValorAnticipo
		{
			get { return m_ValorAnticipo; }
			set 
			{
				m_changed=true;
				m_ValorAnticipo = value;
			}
		}

		/// <summary>
		/// Attribute for access the TramosAsignadosRuta's CantidadReal value (decimal)
		/// </summary>
		[DataMember]
		public decimal? CantidadReal
		{
			get { return m_CantidadReal; }
			set 
			{
				m_changed=true;
				m_CantidadReal = value;
			}
		}

		/// <summary>
		/// Attribute for access the TramosAsignadosRuta's LogAnticipoACPM value (bool)
		/// </summary>
		[DataMember]
		public bool? LogAnticipoACPM
		{
			get { return m_LogAnticipoACPM; }
			set 
			{
				m_changed=true;
				m_LogAnticipoACPM = value;
			}
		}

		/// <summary>
		/// Attribute for access the TramosAsignadosRuta's PlacaTrailer value (string)
		/// </summary>
		[DataMember]
		public string PlacaTrailer
		{
			get { return m_PlacaTrailer; }
			set 
			{
				m_changed=true;
				m_PlacaTrailer = value;
			}
		}

		public object GetAttribute(string pattribute)
		{
			switch (pattribute)
			{
				case "RegistroId": return RegistroId;
				case "Registro": return Registro;
				case "RegistrRuta": return RegistrRuta;
				case "RegistroRuttaAJC": return RegistroRuttaAJC;
				case "Fecha": return Fecha;
				case "liquidado": return liquidado;
				case "Asignado": return Asignado;
				case "Vacio": return Vacio;
				case "logAjuste": return logAjuste;
				case "Peso": return Peso;
				case "EstadoRuta": return EstadoRuta;
				case "Trailer": return Trailer;
				case "TipoVeh": return TipoVeh;
				case "DesTipoVeh": return DesTipoVeh;
				case "TipoTrailer": return TipoTrailer;
				case "Origen": return Origen;
				case "Destino": return Destino;
				case "Tramos": return Tramos;
				case "CantidadGalones": return CantidadGalones;
				case "ValorGalones": return ValorGalones;
				case "ValorCOmbustible": return ValorCOmbustible;
				case "Viaticos": return Viaticos;
				case "SalarioVariable": return SalarioVariable;
				case "TotalViaticos": return TotalViaticos;
				case "TotalDescuentoViaticos": return TotalDescuentoViaticos;
				case "Total_Viaticos": return Total_Viaticos;
				case "NroPeajes": return NroPeajes;
				case "ValorPeajes": return ValorPeajes;
				case "Llantas": return Llantas;
				case "CeladaParqueaderoCarretera": return CeladaParqueaderoCarretera;
				case "Propina": return Propina;
				case "TotalVarios": return TotalVarios;
				case "LlantasVacios": return LlantasVacios;
				case "CeladaVacia": return CeladaVacia;
				case "PropinaVacia": return PropinaVacia;
				case "VariosVacios": return VariosVacios;
				case "ValorCargue": return ValorCargue;
				case "ValorDescargue": return ValorDescargue;
				case "Hotel": return Hotel;
				case "HotelDiasCarretera": return HotelDiasCarretera;
				case "HotelDiasCiudad": return HotelDiasCiudad;
				case "HotelVacio": return HotelVacio;
				case "TiempoReal": return TiempoReal;
				case "TotalComida": return TotalComida;
				case "TiempoRutaVacio": return TiempoRutaVacio;
				case "ComidaVacio": return ComidaVacio;
				case "DesvareRepuestos": return DesvareRepuestos;
				case "DesvareManoObra": return DesvareManoObra;
				case "TotalKm": return TotalKm;
				case "ParqueaderoCarretera": return ParqueaderoCarretera;
				case "ParqueaderoCiudad": return ParqueaderoCiudad;
				case "MontaLlantaCarretera": return MontaLlantaCarretera;
				case "Papeleria": return Papeleria;
				case "AjusteCarretera": return AjusteCarretera;
				case "CombustibleCarretera": return CombustibleCarretera;
				case "Amarres": return Amarres;
				case "Engrasada": return Engrasada;
				case "Calibrada": return Calibrada;
				case "Aseo": return Aseo;
				case "Taxi": return Taxi;
				case "Contenedor1": return Contenedor1;
				case "Contenedor2": return Contenedor2;
				case "FactorCalculoDia": return FactorCalculoDia;
				case "ValorFactorCalculo": return ValorFactorCalculo;
				case "ValorAnticipo": return ValorAnticipo;
				case "CantidadReal": return CantidadReal;
				case "LogAnticipoACPM": return LogAnticipoACPM;
				case "PlacaTrailer": return PlacaTrailer;
				default: return null;
			}
		}

		public Type GetAttributeType(string pattribute)
		{
			return TramosAsignadosRutaController.Instance.GetMethodType(pattribute, this);
		}

		public string GetSqlKey()
		{
			return "[RegistroId] = " + RegistroId.ToString() + " AND [Registro] = " + Registro.ToString() + " AND [RegistrRuta] = " + RegistrRuta.ToString() + " AND [RegistroRuttaAJC] = " + RegistroRuttaAJC.ToString();
		}
		#endregion

	}

	#endregion

	#region TramosAsignadosRutaList object

	/// <summary>
	/// Class for reading and access a list of TramosAsignadosRuta object
	/// </summary>
	[CollectionDataContract]
	public partial class TramosAsignadosRutaList : List<TramosAsignadosRuta>
	{

		/// <summary>
		/// Default constructor
		/// </summary>
		public TramosAsignadosRutaList()
		{
		}
	}

	#endregion

}
