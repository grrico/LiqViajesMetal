using System;
using System.Data;
using System.Data.Common;
using Sinapsys.Datos;
using LiqViajes_Bll_Data.Security;
using System.Runtime.Serialization;

namespace LiqViajes_Bll_Data
{
	/// <summary>
	/// Data Access Layer class for TramosAsignadosRuta object
	/// </summary>
	/// <remarks>
	/// This class is a Singleton
	/// </remarks>
	public partial class TramosAsignadosRutaDataProvider
	{
		/// <summary>
		/// Internal member for create this singleton
		/// </summary>
		private static TramosAsignadosRutaDataProvider MySingleObj = null;

		/// <summary>
		/// Protected constructor to avoid access this singleton other way than calling the Instance method
		/// </summary>
		public TramosAsignadosRutaDataProvider()
		{

		}

		/// <summary>
		/// Instance accessor for this singleton
		/// </summary>
		public static TramosAsignadosRutaDataProvider Instance
		{
			get
			{
				if (MySingleObj == null)
				{
					MySingleObj = new TramosAsignadosRutaDataProvider();
				}

				return MySingleObj;
			}
		}

		/// <summary>
		/// Creates a new record into TramosAsignadosRuta by passing all fields
		/// </summary>
		/// <param name="Fecha"></param>
		/// <param name="liquidado"></param>
		/// <param name="Asignado"></param>
		/// <param name="Vacio"></param>
		/// <param name="logAjuste"></param>
		/// <param name="Peso"></param>
		/// <param name="EstadoRuta"></param>
		/// <param name="Trailer"></param>
		/// <param name="TipoVeh"></param>
		/// <param name="DesTipoVeh"></param>
		/// <param name="TipoTrailer"></param>
		/// <param name="Origen"></param>
		/// <param name="Destino"></param>
		/// <param name="Tramos"></param>
		/// <param name="CantidadGalones"></param>
		/// <param name="ValorGalones"></param>
		/// <param name="ValorCOmbustible"></param>
		/// <param name="Viaticos"></param>
		/// <param name="SalarioVariable"></param>
		/// <param name="TotalViaticos"></param>
		/// <param name="TotalDescuentoViaticos"></param>
		/// <param name="Total_Viaticos"></param>
		/// <param name="NroPeajes"></param>
		/// <param name="ValorPeajes"></param>
		/// <param name="Llantas"></param>
		/// <param name="CeladaParqueaderoCarretera"></param>
		/// <param name="Propina"></param>
		/// <param name="TotalVarios"></param>
		/// <param name="LlantasVacios"></param>
		/// <param name="CeladaVacia"></param>
		/// <param name="PropinaVacia"></param>
		/// <param name="VariosVacios"></param>
		/// <param name="ValorCargue"></param>
		/// <param name="ValorDescargue"></param>
		/// <param name="Hotel"></param>
		/// <param name="HotelDiasCarretera"></param>
		/// <param name="HotelDiasCiudad"></param>
		/// <param name="HotelVacio"></param>
		/// <param name="TiempoReal"></param>
		/// <param name="TotalComida"></param>
		/// <param name="TiempoRutaVacio"></param>
		/// <param name="ComidaVacio"></param>
		/// <param name="DesvareRepuestos"></param>
		/// <param name="DesvareManoObra"></param>
		/// <param name="TotalKm"></param>
		/// <param name="ParqueaderoCarretera"></param>
		/// <param name="ParqueaderoCiudad"></param>
		/// <param name="MontaLlantaCarretera"></param>
		/// <param name="Papeleria"></param>
		/// <param name="AjusteCarretera"></param>
		/// <param name="CombustibleCarretera"></param>
		/// <param name="Amarres"></param>
		/// <param name="Engrasada"></param>
		/// <param name="Calibrada"></param>
		/// <param name="Aseo"></param>
		/// <param name="Taxi"></param>
		/// <param name="Contenedor1"></param>
		/// <param name="Contenedor2"></param>
		/// <param name="FactorCalculoDia"></param>
		/// <param name="ValorFactorCalculo"></param>
		/// <param name="ValorAnticipo"></param>
		/// <param name="CantidadReal"></param>
		/// <param name="LogAnticipoACPM"></param>
		/// <param name="PlacaTrailer"></param>
		/// <returns>long that contents the RegistroId value</returns>
		public long Create(long RegistroId, long Registro, long RegistrRuta, long RegistroRuttaAJC, DateTime? Fecha, bool liquidado, int Asignado, int Vacio, bool? logAjuste, int Peso, bool? EstadoRuta, string Trailer, int TipoVeh, string DesTipoVeh, int TipoTrailer, string Origen, string Destino, string Tramos, decimal? CantidadGalones, decimal? ValorGalones, decimal? ValorCOmbustible, decimal? Viaticos, decimal? SalarioVariable, decimal? TotalViaticos, decimal? TotalDescuentoViaticos, decimal? Total_Viaticos, int? NroPeajes, decimal? ValorPeajes, decimal? Llantas, decimal? CeladaParqueaderoCarretera, decimal? Propina, decimal? TotalVarios, decimal? LlantasVacios, decimal? CeladaVacia, decimal? PropinaVacia, decimal? VariosVacios, decimal? ValorCargue, decimal? ValorDescargue, decimal? Hotel, int? HotelDiasCarretera, int? HotelDiasCiudad, decimal? HotelVacio, decimal? TiempoReal, decimal? TotalComida, decimal? TiempoRutaVacio, decimal? ComidaVacio, decimal? DesvareRepuestos, decimal? DesvareManoObra, decimal? TotalKm, decimal ParqueaderoCarretera, decimal ParqueaderoCiudad, decimal MontaLlantaCarretera, decimal Papeleria, decimal AjusteCarretera, decimal? CombustibleCarretera, decimal Amarres, decimal Engrasada, decimal Calibrada, decimal? Aseo, decimal? Taxi, string Contenedor1, string Contenedor2, int? FactorCalculoDia, decimal? ValorFactorCalculo, decimal? ValorAnticipo, decimal? CantidadReal, bool? LogAnticipoACPM, string PlacaTrailer,string module, Sinapsys.Datos.SQL datosTransaccion=null)
		{
			try 
			{
				Sinapsys.Datos.SQL LocalDataProvider;
				bool disconnect = false;
				if (datosTransaccion != null) LocalDataProvider = datosTransaccion;
				else
				{
					if (DataProvider.Concurrente)
					{
						LocalDataProvider = new Sinapsys.Datos.SQL();
						LocalDataProvider.Conectar(DataProvider.Alias, false);
					}
					else
					{
						LocalDataProvider = DataProvider.Datos;
					}
					disconnect = DataProvider.ValidateConnection();
				}
				System.Data.SqlClient.SqlCommand Comando = new System.Data.SqlClient.SqlCommand();
				System.Data.SqlClient.SqlParameterCollection paramlist = Comando.Parameters;
				System.Collections.Hashtable nullExit = null;

				paramlist.AddWithValue("@RegistroId",RegistroId);
				paramlist.AddWithValue("@Registro",Registro);
				paramlist.AddWithValue("@RegistrRuta",RegistrRuta);
				paramlist.AddWithValue("@RegistroRuttaAJC",RegistroRuttaAJC);
				if (Fecha !=null)
				{
					paramlist.AddWithValue("@Fecha",Fecha);
				}
				paramlist.AddWithValue("@liquidado",liquidado);
				paramlist.AddWithValue("@Asignado",Asignado);
				paramlist.AddWithValue("@Vacio",Vacio);
				if (logAjuste !=null)
				{
					paramlist.AddWithValue("@logAjuste",logAjuste);
				}
				paramlist.AddWithValue("@Peso",Peso);
				if (EstadoRuta !=null)
				{
					paramlist.AddWithValue("@EstadoRuta",EstadoRuta);
				}
				if (Trailer !=null)
				{
					paramlist.AddWithValue("@Trailer",Trailer);
				}
				paramlist.AddWithValue("@TipoVeh",TipoVeh);
				paramlist.AddWithValue("@DesTipoVeh",DesTipoVeh);
				paramlist.AddWithValue("@TipoTrailer",TipoTrailer);
				if (Origen !=null)
				{
					paramlist.AddWithValue("@Origen",Origen);
				}
				if (Destino !=null)
				{
					paramlist.AddWithValue("@Destino",Destino);
				}
				if (Tramos !=null)
				{
					paramlist.AddWithValue("@Tramos",Tramos);
				}
				if (CantidadGalones !=null)
				{
					paramlist.AddWithValue("@CantidadGalones",CantidadGalones);
				}
				if (ValorGalones !=null)
				{
					paramlist.AddWithValue("@ValorGalones",ValorGalones);
				}
				if (ValorCOmbustible !=null)
				{
					paramlist.AddWithValue("@ValorCOmbustible",ValorCOmbustible);
				}
				if (Viaticos !=null)
				{
					paramlist.AddWithValue("@Viaticos",Viaticos);
				}
				if (SalarioVariable !=null)
				{
					paramlist.AddWithValue("@SalarioVariable",SalarioVariable);
				}
				if (TotalViaticos !=null)
				{
					paramlist.AddWithValue("@TotalViaticos",TotalViaticos);
				}
				if (TotalDescuentoViaticos !=null)
				{
					paramlist.AddWithValue("@TotalDescuentoViaticos",TotalDescuentoViaticos);
				}
				if (Total_Viaticos !=null)
				{
					paramlist.AddWithValue("@Total_Viaticos",Total_Viaticos);
				}
				if (NroPeajes !=null)
				{
					paramlist.AddWithValue("@NroPeajes",NroPeajes);
				}
				if (ValorPeajes !=null)
				{
					paramlist.AddWithValue("@ValorPeajes",ValorPeajes);
				}
				if (Llantas !=null)
				{
					paramlist.AddWithValue("@Llantas",Llantas);
				}
				if (CeladaParqueaderoCarretera !=null)
				{
					paramlist.AddWithValue("@CeladaParqueaderoCarretera",CeladaParqueaderoCarretera);
				}
				if (Propina !=null)
				{
					paramlist.AddWithValue("@Propina",Propina);
				}
				if (TotalVarios !=null)
				{
					paramlist.AddWithValue("@TotalVarios",TotalVarios);
				}
				if (LlantasVacios !=null)
				{
					paramlist.AddWithValue("@LlantasVacios",LlantasVacios);
				}
				if (CeladaVacia !=null)
				{
					paramlist.AddWithValue("@CeladaVacia",CeladaVacia);
				}
				if (PropinaVacia !=null)
				{
					paramlist.AddWithValue("@PropinaVacia",PropinaVacia);
				}
				if (VariosVacios !=null)
				{
					paramlist.AddWithValue("@VariosVacios",VariosVacios);
				}
				if (ValorCargue !=null)
				{
					paramlist.AddWithValue("@ValorCargue",ValorCargue);
				}
				if (ValorDescargue !=null)
				{
					paramlist.AddWithValue("@ValorDescargue",ValorDescargue);
				}
				if (Hotel !=null)
				{
					paramlist.AddWithValue("@Hotel",Hotel);
				}
				if (HotelDiasCarretera !=null)
				{
					paramlist.AddWithValue("@HotelDiasCarretera",HotelDiasCarretera);
				}
				if (HotelDiasCiudad !=null)
				{
					paramlist.AddWithValue("@HotelDiasCiudad",HotelDiasCiudad);
				}
				if (HotelVacio !=null)
				{
					paramlist.AddWithValue("@HotelVacio",HotelVacio);
				}
				if (TiempoReal !=null)
				{
					paramlist.AddWithValue("@TiempoReal",TiempoReal);
				}
				if (TotalComida !=null)
				{
					paramlist.AddWithValue("@TotalComida",TotalComida);
				}
				if (TiempoRutaVacio !=null)
				{
					paramlist.AddWithValue("@TiempoRutaVacio",TiempoRutaVacio);
				}
				if (ComidaVacio !=null)
				{
					paramlist.AddWithValue("@ComidaVacio",ComidaVacio);
				}
				if (DesvareRepuestos !=null)
				{
					paramlist.AddWithValue("@DesvareRepuestos",DesvareRepuestos);
				}
				if (DesvareManoObra !=null)
				{
					paramlist.AddWithValue("@DesvareManoObra",DesvareManoObra);
				}
				if (TotalKm !=null)
				{
					paramlist.AddWithValue("@TotalKm",TotalKm);
				}
				paramlist.AddWithValue("@ParqueaderoCarretera",ParqueaderoCarretera);
				paramlist.AddWithValue("@ParqueaderoCiudad",ParqueaderoCiudad);
				paramlist.AddWithValue("@MontaLlantaCarretera",MontaLlantaCarretera);
				paramlist.AddWithValue("@Papeleria",Papeleria);
				paramlist.AddWithValue("@AjusteCarretera",AjusteCarretera);
				if (CombustibleCarretera !=null)
				{
					paramlist.AddWithValue("@CombustibleCarretera",CombustibleCarretera);
				}
				paramlist.AddWithValue("@Amarres",Amarres);
				paramlist.AddWithValue("@Engrasada",Engrasada);
				paramlist.AddWithValue("@Calibrada",Calibrada);
				if (Aseo !=null)
				{
					paramlist.AddWithValue("@Aseo",Aseo);
				}
				if (Taxi !=null)
				{
					paramlist.AddWithValue("@Taxi",Taxi);
				}
				if (Contenedor1 !=null)
				{
					paramlist.AddWithValue("@Contenedor1",Contenedor1);
				}
				if (Contenedor2 !=null)
				{
					paramlist.AddWithValue("@Contenedor2",Contenedor2);
				}
				if (FactorCalculoDia !=null)
				{
					paramlist.AddWithValue("@FactorCalculoDia",FactorCalculoDia);
				}
				if (ValorFactorCalculo !=null)
				{
					paramlist.AddWithValue("@ValorFactorCalculo",ValorFactorCalculo);
				}
				if (ValorAnticipo !=null)
				{
					paramlist.AddWithValue("@ValorAnticipo",ValorAnticipo);
				}
				if (CantidadReal !=null)
				{
					paramlist.AddWithValue("@CantidadReal",CantidadReal);
				}
				if (LogAnticipoACPM !=null)
				{
					paramlist.AddWithValue("@LogAnticipoACPM",LogAnticipoACPM);
				}
				if (PlacaTrailer !=null)
				{
					paramlist.AddWithValue("@PlacaTrailer",PlacaTrailer);
				}
				// Execute the query and return the new identity value
				long returnValue = Convert.ToInt32(LocalDataProvider.EjecutarProcedimiento("dbo.TramosAsignadosRutaCreate", paramlist, disconnect, out nullExit, DataProvider.TiempoEspera).Rows[0][0]);

				return returnValue;
			}
			catch (Exception ex)
			{
				Utilidades.LogErrores(ex.Message + (ex.InnerException != null ? ex.InnerException.Message : ""), DataProvider.AplicacionNombre);
				throw ex;
			}
		}

		/// <summary>
		/// Updates one record into TramosAsignadosRuta by passing all fields
		/// </summary>
		/// <param name="RegistroId"></param>
		/// <param name="Registro"></param>
		/// <param name="RegistrRuta"></param>
		/// <param name="RegistroRuttaAJC"></param>
		/// <param name="Fecha"></param>
		/// <param name="liquidado"></param>
		/// <param name="Asignado"></param>
		/// <param name="Vacio"></param>
		/// <param name="logAjuste"></param>
		/// <param name="Peso"></param>
		/// <param name="EstadoRuta"></param>
		/// <param name="Trailer"></param>
		/// <param name="TipoVeh"></param>
		/// <param name="DesTipoVeh"></param>
		/// <param name="TipoTrailer"></param>
		/// <param name="Origen"></param>
		/// <param name="Destino"></param>
		/// <param name="Tramos"></param>
		/// <param name="CantidadGalones"></param>
		/// <param name="ValorGalones"></param>
		/// <param name="ValorCOmbustible"></param>
		/// <param name="Viaticos"></param>
		/// <param name="SalarioVariable"></param>
		/// <param name="TotalViaticos"></param>
		/// <param name="TotalDescuentoViaticos"></param>
		/// <param name="Total_Viaticos"></param>
		/// <param name="NroPeajes"></param>
		/// <param name="ValorPeajes"></param>
		/// <param name="Llantas"></param>
		/// <param name="CeladaParqueaderoCarretera"></param>
		/// <param name="Propina"></param>
		/// <param name="TotalVarios"></param>
		/// <param name="LlantasVacios"></param>
		/// <param name="CeladaVacia"></param>
		/// <param name="PropinaVacia"></param>
		/// <param name="VariosVacios"></param>
		/// <param name="ValorCargue"></param>
		/// <param name="ValorDescargue"></param>
		/// <param name="Hotel"></param>
		/// <param name="HotelDiasCarretera"></param>
		/// <param name="HotelDiasCiudad"></param>
		/// <param name="HotelVacio"></param>
		/// <param name="TiempoReal"></param>
		/// <param name="TotalComida"></param>
		/// <param name="TiempoRutaVacio"></param>
		/// <param name="ComidaVacio"></param>
		/// <param name="DesvareRepuestos"></param>
		/// <param name="DesvareManoObra"></param>
		/// <param name="TotalKm"></param>
		/// <param name="ParqueaderoCarretera"></param>
		/// <param name="ParqueaderoCiudad"></param>
		/// <param name="MontaLlantaCarretera"></param>
		/// <param name="Papeleria"></param>
		/// <param name="AjusteCarretera"></param>
		/// <param name="CombustibleCarretera"></param>
		/// <param name="Amarres"></param>
		/// <param name="Engrasada"></param>
		/// <param name="Calibrada"></param>
		/// <param name="Aseo"></param>
		/// <param name="Taxi"></param>
		/// <param name="Contenedor1"></param>
		/// <param name="Contenedor2"></param>
		/// <param name="FactorCalculoDia"></param>
		/// <param name="ValorFactorCalculo"></param>
		/// <param name="ValorAnticipo"></param>
		/// <param name="CantidadReal"></param>
		/// <param name="LogAnticipoACPM"></param>
		/// <param name="PlacaTrailer"></param>
		public void Update(long RegistroId, long Registro, long RegistrRuta, long RegistroRuttaAJC, DateTime? Fecha, bool liquidado, int Asignado, int Vacio, bool? logAjuste, int Peso, bool? EstadoRuta, string Trailer, int TipoVeh, string DesTipoVeh, int TipoTrailer, string Origen, string Destino, string Tramos, decimal? CantidadGalones, decimal? ValorGalones, decimal? ValorCOmbustible, decimal? Viaticos, decimal? SalarioVariable, decimal? TotalViaticos, decimal? TotalDescuentoViaticos, decimal? Total_Viaticos, int? NroPeajes, decimal? ValorPeajes, decimal? Llantas, decimal? CeladaParqueaderoCarretera, decimal? Propina, decimal? TotalVarios, decimal? LlantasVacios, decimal? CeladaVacia, decimal? PropinaVacia, decimal? VariosVacios, decimal? ValorCargue, decimal? ValorDescargue, decimal? Hotel, int? HotelDiasCarretera, int? HotelDiasCiudad, decimal? HotelVacio, decimal? TiempoReal, decimal? TotalComida, decimal? TiempoRutaVacio, decimal? ComidaVacio, decimal? DesvareRepuestos, decimal? DesvareManoObra, decimal? TotalKm, decimal ParqueaderoCarretera, decimal ParqueaderoCiudad, decimal MontaLlantaCarretera, decimal Papeleria, decimal AjusteCarretera, decimal? CombustibleCarretera, decimal Amarres, decimal Engrasada, decimal Calibrada, decimal? Aseo, decimal? Taxi, string Contenedor1, string Contenedor2, int? FactorCalculoDia, decimal? ValorFactorCalculo, decimal? ValorAnticipo, decimal? CantidadReal, bool? LogAnticipoACPM, string PlacaTrailer,string module, Sinapsys.Datos.SQL datosTransaccion=null)
		{
			try 
			{
				Sinapsys.Datos.SQL LocalDataProvider;
				bool disconnect = false;
				if (datosTransaccion != null) LocalDataProvider = datosTransaccion;
				else
				{
					if (DataProvider.Concurrente)
					{
						LocalDataProvider = new Sinapsys.Datos.SQL();
						LocalDataProvider.Conectar(DataProvider.Alias, false);
					}
					else
					{
						LocalDataProvider = DataProvider.Datos;
					}
					disconnect = DataProvider.ValidateConnection();
				}
				System.Data.SqlClient.SqlCommand Comando = new System.Data.SqlClient.SqlCommand();
				System.Data.SqlClient.SqlParameterCollection paramlist = Comando.Parameters;
				System.Collections.Hashtable nullExit = null;
				paramlist.AddWithValue("@RegistroId",RegistroId);
				paramlist.AddWithValue("@Registro",Registro);
				paramlist.AddWithValue("@RegistrRuta",RegistrRuta);
				paramlist.AddWithValue("@RegistroRuttaAJC",RegistroRuttaAJC);
				if (Fecha !=null)
				{
					paramlist.AddWithValue("@Fecha",Fecha);
				}
				paramlist.AddWithValue("@liquidado",liquidado);
				paramlist.AddWithValue("@Asignado",Asignado);
				paramlist.AddWithValue("@Vacio",Vacio);
				if (logAjuste !=null)
				{
					paramlist.AddWithValue("@logAjuste",logAjuste);
				}
				paramlist.AddWithValue("@Peso",Peso);
				if (EstadoRuta !=null)
				{
					paramlist.AddWithValue("@EstadoRuta",EstadoRuta);
				}
				if (Trailer !=null)
				{
					paramlist.AddWithValue("@Trailer",Trailer);
				}
				paramlist.AddWithValue("@TipoVeh",TipoVeh);
				paramlist.AddWithValue("@DesTipoVeh",DesTipoVeh);
				paramlist.AddWithValue("@TipoTrailer",TipoTrailer);
				if (Origen !=null)
				{
					paramlist.AddWithValue("@Origen",Origen);
				}
				if (Destino !=null)
				{
					paramlist.AddWithValue("@Destino",Destino);
				}
				if (Tramos !=null)
				{
					paramlist.AddWithValue("@Tramos",Tramos);
				}
				if (CantidadGalones !=null)
				{
					paramlist.AddWithValue("@CantidadGalones",CantidadGalones);
				}
				if (ValorGalones !=null)
				{
					paramlist.AddWithValue("@ValorGalones",ValorGalones);
				}
				if (ValorCOmbustible !=null)
				{
					paramlist.AddWithValue("@ValorCOmbustible",ValorCOmbustible);
				}
				if (Viaticos !=null)
				{
					paramlist.AddWithValue("@Viaticos",Viaticos);
				}
				if (SalarioVariable !=null)
				{
					paramlist.AddWithValue("@SalarioVariable",SalarioVariable);
				}
				if (TotalViaticos !=null)
				{
					paramlist.AddWithValue("@TotalViaticos",TotalViaticos);
				}
				if (TotalDescuentoViaticos !=null)
				{
					paramlist.AddWithValue("@TotalDescuentoViaticos",TotalDescuentoViaticos);
				}
				if (Total_Viaticos !=null)
				{
					paramlist.AddWithValue("@Total_Viaticos",Total_Viaticos);
				}
				if (NroPeajes !=null)
				{
					paramlist.AddWithValue("@NroPeajes",NroPeajes);
				}
				if (ValorPeajes !=null)
				{
					paramlist.AddWithValue("@ValorPeajes",ValorPeajes);
				}
				if (Llantas !=null)
				{
					paramlist.AddWithValue("@Llantas",Llantas);
				}
				if (CeladaParqueaderoCarretera !=null)
				{
					paramlist.AddWithValue("@CeladaParqueaderoCarretera",CeladaParqueaderoCarretera);
				}
				if (Propina !=null)
				{
					paramlist.AddWithValue("@Propina",Propina);
				}
				if (TotalVarios !=null)
				{
					paramlist.AddWithValue("@TotalVarios",TotalVarios);
				}
				if (LlantasVacios !=null)
				{
					paramlist.AddWithValue("@LlantasVacios",LlantasVacios);
				}
				if (CeladaVacia !=null)
				{
					paramlist.AddWithValue("@CeladaVacia",CeladaVacia);
				}
				if (PropinaVacia !=null)
				{
					paramlist.AddWithValue("@PropinaVacia",PropinaVacia);
				}
				if (VariosVacios !=null)
				{
					paramlist.AddWithValue("@VariosVacios",VariosVacios);
				}
				if (ValorCargue !=null)
				{
					paramlist.AddWithValue("@ValorCargue",ValorCargue);
				}
				if (ValorDescargue !=null)
				{
					paramlist.AddWithValue("@ValorDescargue",ValorDescargue);
				}
				if (Hotel !=null)
				{
					paramlist.AddWithValue("@Hotel",Hotel);
				}
				if (HotelDiasCarretera !=null)
				{
					paramlist.AddWithValue("@HotelDiasCarretera",HotelDiasCarretera);
				}
				if (HotelDiasCiudad !=null)
				{
					paramlist.AddWithValue("@HotelDiasCiudad",HotelDiasCiudad);
				}
				if (HotelVacio !=null)
				{
					paramlist.AddWithValue("@HotelVacio",HotelVacio);
				}
				if (TiempoReal !=null)
				{
					paramlist.AddWithValue("@TiempoReal",TiempoReal);
				}
				if (TotalComida !=null)
				{
					paramlist.AddWithValue("@TotalComida",TotalComida);
				}
				if (TiempoRutaVacio !=null)
				{
					paramlist.AddWithValue("@TiempoRutaVacio",TiempoRutaVacio);
				}
				if (ComidaVacio !=null)
				{
					paramlist.AddWithValue("@ComidaVacio",ComidaVacio);
				}
				if (DesvareRepuestos !=null)
				{
					paramlist.AddWithValue("@DesvareRepuestos",DesvareRepuestos);
				}
				if (DesvareManoObra !=null)
				{
					paramlist.AddWithValue("@DesvareManoObra",DesvareManoObra);
				}
				if (TotalKm !=null)
				{
					paramlist.AddWithValue("@TotalKm",TotalKm);
				}
				paramlist.AddWithValue("@ParqueaderoCarretera",ParqueaderoCarretera);
				paramlist.AddWithValue("@ParqueaderoCiudad",ParqueaderoCiudad);
				paramlist.AddWithValue("@MontaLlantaCarretera",MontaLlantaCarretera);
				paramlist.AddWithValue("@Papeleria",Papeleria);
				paramlist.AddWithValue("@AjusteCarretera",AjusteCarretera);
				if (CombustibleCarretera !=null)
				{
					paramlist.AddWithValue("@CombustibleCarretera",CombustibleCarretera);
				}
				paramlist.AddWithValue("@Amarres",Amarres);
				paramlist.AddWithValue("@Engrasada",Engrasada);
				paramlist.AddWithValue("@Calibrada",Calibrada);
				if (Aseo !=null)
				{
					paramlist.AddWithValue("@Aseo",Aseo);
				}
				if (Taxi !=null)
				{
					paramlist.AddWithValue("@Taxi",Taxi);
				}
				if (Contenedor1 !=null)
				{
					paramlist.AddWithValue("@Contenedor1",Contenedor1);
				}
				if (Contenedor2 !=null)
				{
					paramlist.AddWithValue("@Contenedor2",Contenedor2);
				}
				if (FactorCalculoDia !=null)
				{
					paramlist.AddWithValue("@FactorCalculoDia",FactorCalculoDia);
				}
				if (ValorFactorCalculo !=null)
				{
					paramlist.AddWithValue("@ValorFactorCalculo",ValorFactorCalculo);
				}
				if (ValorAnticipo !=null)
				{
					paramlist.AddWithValue("@ValorAnticipo",ValorAnticipo);
				}
				if (CantidadReal !=null)
				{
					paramlist.AddWithValue("@CantidadReal",CantidadReal);
				}
				if (LogAnticipoACPM !=null)
				{
					paramlist.AddWithValue("@LogAnticipoACPM",LogAnticipoACPM);
				}
				if (PlacaTrailer !=null)
				{
					paramlist.AddWithValue("@PlacaTrailer",PlacaTrailer);
				}
				LocalDataProvider.EjecutarProcedimiento("dbo.TramosAsignadosRutaUpdate", paramlist, disconnect, out nullExit, DataProvider.TiempoEspera);
			}
			catch (Exception ex)
			{
				Utilidades.LogErrores(ex.Message + (ex.InnerException != null ? ex.InnerException.Message : ""), DataProvider.AplicacionNombre);
				throw ex;
			}
		}

		/// <summary>
		/// Deletes one record from TramosAsignadosRuta by passing all key fields
		/// </summary>
		/// <param name="RegistroId"></param>
		/// <param name="Registro"></param>
		/// <param name="RegistrRuta"></param>
		/// <param name="RegistroRuttaAJC"></param>
		public void Delete(long RegistroId, long Registro, long RegistrRuta, long RegistroRuttaAJC,string module, Sinapsys.Datos.SQL datosTransaccion=null)
		{
			try 
			{
				Sinapsys.Datos.SQL LocalDataProvider;
				bool disconnect = false;
				if (datosTransaccion != null) LocalDataProvider = datosTransaccion;
				else
				{
					if (DataProvider.Concurrente)
					{
						LocalDataProvider = new Sinapsys.Datos.SQL();
						LocalDataProvider.Conectar(DataProvider.Alias, false);
					}
					else
					{
						LocalDataProvider = DataProvider.Datos;
					}
					disconnect = DataProvider.ValidateConnection();
				}
				System.Data.SqlClient.SqlCommand Comando = new System.Data.SqlClient.SqlCommand();
				System.Data.SqlClient.SqlParameterCollection paramlist = Comando.Parameters;
				System.Collections.Hashtable nullExit = null;
				paramlist.AddWithValue("@RegistroId",RegistroId);
				paramlist.AddWithValue("@Registro",Registro);
				paramlist.AddWithValue("@RegistrRuta",RegistrRuta);
				paramlist.AddWithValue("@RegistroRuttaAJC",RegistroRuttaAJC);
				LocalDataProvider.EjecutarProcedimiento("dbo.TramosAsignadosRutaDelete", paramlist, disconnect, out nullExit, DataProvider.TiempoEspera);
			}
			catch (Exception ex)
			{
				Utilidades.LogErrores(ex.Message + (ex.InnerException != null ? ex.InnerException.Message : ""), DataProvider.AplicacionNombre);
				throw ex;
			}
		}

		/// <summary>
		/// Gets one record from TramosAsignadosRuta passing all key fields
		/// </summary>
		/// <param name="RegistroId"></param>
		/// <param name="Registro"></param>
		/// <param name="RegistrRuta"></param>
		/// <param name="RegistroRuttaAJC"></param>
		/// <returns>A DataTable object containing the data</returns>
		public DataTable Get(long RegistroId, long Registro, long RegistrRuta, long RegistroRuttaAJC)
		{
			try 
			{
				Sinapsys.Datos.SQL LocalDataProvider;
				bool disconnect = false;
				if (DataProvider.Concurrente)
				{
					LocalDataProvider = new Sinapsys.Datos.SQL();
					LocalDataProvider.Conectar(DataProvider.Alias, false);
				}
				else
				{
					LocalDataProvider = DataProvider.Datos;
				}
				disconnect = DataProvider.ValidateConnection();
				System.Data.SqlClient.SqlCommand Comando = new System.Data.SqlClient.SqlCommand();
				System.Data.SqlClient.SqlParameterCollection paramlist = Comando.Parameters;
				System.Collections.Hashtable nullExit = null;
				paramlist.AddWithValue("@RegistroId",RegistroId);
				paramlist.AddWithValue("@Registro",Registro);
				paramlist.AddWithValue("@RegistrRuta",RegistrRuta);
				paramlist.AddWithValue("@RegistroRuttaAJC",RegistroRuttaAJC);
				return LocalDataProvider.EjecutarProcedimiento("dbo.TramosAsignadosRutaGet", paramlist, disconnect, out nullExit, DataProvider.TiempoEspera);

			}
			catch (Exception ex)
			{
				Utilidades.LogErrores(ex.Message + (ex.InnerException != null ? ex.InnerException.Message : ""), DataProvider.AplicacionNombre);
				throw ex;
			}
		}

		/// <summary>
		/// Gets all records from TramosAsignadosRuta
		/// </summary>
		/// <returns>A DataTable object containing all records data</returns>
		public DataTable GetAll()
		{
			try 
			{
				Sinapsys.Datos.SQL LocalDataProvider;
				bool disconnect = false;
				if (DataProvider.Concurrente)
				{
					LocalDataProvider = new Sinapsys.Datos.SQL();
					LocalDataProvider.Conectar(DataProvider.Alias, false);
				}
				else
				{
					LocalDataProvider = DataProvider.Datos;
				}
				disconnect = DataProvider.ValidateConnection();
				System.Data.SqlClient.SqlCommand Comando = new System.Data.SqlClient.SqlCommand();
				System.Data.SqlClient.SqlParameterCollection paramlist = Comando.Parameters;
				System.Collections.Hashtable nullExit = null;
				return LocalDataProvider.EjecutarProcedimiento("dbo.TramosAsignadosRutaGetAll", paramlist, disconnect, out nullExit, DataProvider.TiempoEspera);
			}
			catch (Exception ex)
			{
				Utilidades.LogErrores(ex.Message + (ex.InnerException != null ? ex.InnerException.Message : ""), DataProvider.AplicacionNombre);
				throw ex;
			}
		}

		/// <summary>
		/// Gets all records from TramosAsignadosRuta applying filter and sort criteria
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
		/// <returns>A DataTable object containing all records data</returns>
		public DataTable GetFilter(int pagenum, int pagesize, string filter, string sort, string extablesfilter, string extablesfieldsfilter, string extablesrelationsfilter, string extablessort, string extablesfieldssort, string extablesrelationssort)
		{
			try 
			{

				Sinapsys.Datos.SQL LocalDataProvider;
				bool disconnect = false;
				if (DataProvider.Concurrente)
				{
					LocalDataProvider = new Sinapsys.Datos.SQL();
					LocalDataProvider.Conectar(DataProvider.Alias, false);
				}
				else
				{
					LocalDataProvider = DataProvider.Datos;
				}
				disconnect = DataProvider.ValidateConnection();
				System.Data.SqlClient.SqlCommand Comando = new System.Data.SqlClient.SqlCommand();
				System.Data.SqlClient.SqlParameterCollection paramlist = Comando.Parameters;
				System.Collections.Hashtable nullExit = null;
				paramlist.AddWithValue("@cctReturnType","S");
				paramlist.AddWithValue("@intPageNo", pagenum);
				paramlist.AddWithValue("@intPageSize", pagesize);
				paramlist.AddWithValue("@strFilter", filter);
				paramlist.AddWithValue("@strSort", sort);
				paramlist.AddWithValue("@strExtraTablesFilter",extablesfilter);
				paramlist.AddWithValue("@strExtraTablesFieldsFilter",  extablesfieldsfilter);
				paramlist.AddWithValue("@strExtraTablesRelationsFilter", extablesrelationsfilter);
				paramlist.AddWithValue("@strExtraTablesSort", extablessort);
				paramlist.AddWithValue("@strExtraTablesFieldsSort", extablesfieldssort);
				paramlist.AddWithValue("@strExtraTablesRelationsSort",extablesrelationssort);

				return LocalDataProvider.EjecutarProcedimiento("dbo.TramosAsignadosRutaGetFilter", paramlist, disconnect, out nullExit, DataProvider.TiempoEspera);
			}
			catch (Exception ex)
			{
				Utilidades.LogErrores(ex.Message + (ex.InnerException != null ? ex.InnerException.Message : ""), DataProvider.AplicacionNombre);
				throw ex;
			}
		}

		public DataTable GetFilter( string filter, string sort)
		{
			return GetFilter(0,0, filter, sort, "","","","","","");
		}

		public DataTable GetFilter(string filter, string sort, string extablesfilter, string extablesfieldsfilter, string extablesrelationsfilter, string extablessort, string extablesfieldssort, string extablesrelationssort)
		{
			return GetFilter(0,0, filter, sort, extablesfilter, extablesfieldsfilter, extablesrelationsfilter, extablessort, extablesfieldssort, extablesrelationssort);
		}

		/// <summary>
		/// Gets the numbers of records from TramosAsignadosRuta applying filter and sort criteria
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
		/// <returns>A int value containing the numbers of records</returns>
		public int GetFilterCount(int pagenum, int pagesize, string filter, string sort, string extablesfilter, string extablesfieldsfilter, string extablesrelationsfilter, string extablessort, string extablesfieldssort, string extablesrelationssort)
		{
			try 
			{
				Sinapsys.Datos.SQL LocalDataProvider;
				bool disconnect = false;
				if (DataProvider.Concurrente)
				{
					LocalDataProvider = new Sinapsys.Datos.SQL();
					LocalDataProvider.Conectar(DataProvider.Alias, false);
				}
				else
				{
					LocalDataProvider = DataProvider.Datos;
				}
				disconnect = DataProvider.ValidateConnection();
				System.Data.SqlClient.SqlCommand Comando = new System.Data.SqlClient.SqlCommand();
				System.Data.SqlClient.SqlParameterCollection paramlist = Comando.Parameters;
				System.Collections.Hashtable nullExit = null;
				paramlist.AddWithValue("@cctReturnType","C");
				paramlist.AddWithValue("@intPageNo", pagenum);
				paramlist.AddWithValue("@intPageSize", pagesize);
				paramlist.AddWithValue("@strFilter", filter);
				paramlist.AddWithValue("@strSort", sort);
				paramlist.AddWithValue("@strExtraTablesFilter",extablesfilter);
				paramlist.AddWithValue("@strExtraTablesFieldsFilter",  extablesfieldsfilter);
				paramlist.AddWithValue("@strExtraTablesRelationsFilter", extablesrelationsfilter);
				paramlist.AddWithValue("@strExtraTablesSort", extablessort);
				paramlist.AddWithValue("@strExtraTablesFieldsSort", extablesfieldssort);
				paramlist.AddWithValue("@strExtraTablesRelationsSort",extablesrelationssort);

				return (int) LocalDataProvider.EjecutarProcedimiento("dbo.TramosAsignadosRutaGetFilter", paramlist, disconnect, out nullExit, DataProvider.TiempoEspera).Rows[0][0];
			}
			catch (Exception ex)
			{
				Utilidades.LogErrores(ex.Message + (ex.InnerException != null ? ex.InnerException.Message : ""), DataProvider.AplicacionNombre);
				throw ex;
			}
		}

	}
}
