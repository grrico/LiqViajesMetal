using System;
using System.Data;
using System.Data.Common;
using Sinapsys.Datos;
using LiqViajes_Bll_Data.Security;
using System.Runtime.Serialization;

namespace LiqViajes_Bll_Data
{
	/// <summary>
	/// Data Access Layer class for VehiculoCCosto object
	/// </summary>
	/// <remarks>
	/// This class is a Singleton
	/// </remarks>
	public partial class VehiculoCCostoDataProvider
	{
		/// <summary>
		/// Internal member for create this singleton
		/// </summary>
		private static VehiculoCCostoDataProvider MySingleObj = null;

		/// <summary>
		/// Protected constructor to avoid access this singleton other way than calling the Instance method
		/// </summary>
		public VehiculoCCostoDataProvider()
		{

		}

		/// <summary>
		/// Instance accessor for this singleton
		/// </summary>
		public static VehiculoCCostoDataProvider Instance
		{
			get
			{
				if (MySingleObj == null)
				{
					MySingleObj = new VehiculoCCostoDataProvider();
				}

				return MySingleObj;
			}
		}

		/// <summary>
		/// Creates a new record into tblVehiculoCCosto by passing all fields
		/// </summary>
		/// <param name="lngIdUsuario"></param>
		/// <param name="strPlaca"></param>
		/// <param name="centro"></param>
		/// <param name="TipoTrailerCodigo"></param>
		/// <param name="TipoVehiculoCodigo"></param>
		/// <param name="Descripcion"></param>
		/// <param name="dtmFechaIngreso"></param>
		/// <param name="dtmFechaEgreso"></param>
		/// <param name="nitPropietario"></param>
		/// <param name="strMarca"></param>
		/// <param name="lngModelo"></param>
		/// <param name="lngMovil"></param>
		/// <param name="strCelular"></param>
		/// <param name="strTipoMotor"></param>
		/// <param name="strColor"></param>
		/// <param name="strMotor"></param>
		/// <param name="strChasis"></param>
		/// <param name="logCamarote"></param>
		/// <param name="CapacidadGalores"></param>
		/// <param name="floGalonesReserva"></param>
		/// <param name="floCantGalonesReserva"></param>
		/// <param name="floTolerancia"></param>
		/// <param name="cutPeso"></param>
		/// <param name="cutCapacidad"></param>
		/// <param name="lngEjes"></param>
		/// <param name="logActivo"></param>
		/// <param name="lngLlantas"></param>
		/// <param name="strPolizaObligatorio"></param>
		/// <param name="nitProvedorOblig"></param>
		/// <param name="dtmFechaInicioOblig"></param>
		/// <param name="dtmFechaVenceOblig"></param>
		/// <param name="strPolizaTodoRiesgo"></param>
		/// <param name="nitProvedorTodo"></param>
		/// <param name="dtmFechaInicioTodo"></param>
		/// <param name="dtmFechaVenceTodo"></param>
		/// <param name="strCertifMovilizacion"></param>
		/// <param name="dtmFechaInicioMoviliz"></param>
		/// <param name="dtmFechaVenceMoviliz"></param>
		/// <param name="strGases"></param>
		/// <param name="dtmFechaInicioGases"></param>
		/// <param name="dtmFechaVenceGases"></param>
		/// <param name="strTarjetaOper"></param>
		/// <param name="dtmFechaInicioTarjetaOper"></param>
		/// <param name="dtmFechaVenceTarjetaOper"></param>
		/// <param name="logVencimientoFecha"></param>
		/// <returns>int that contents the lngIdRegistro value</returns>
		public int Create(int lngIdRegistro, double? lngIdUsuario, string strPlaca, double? centro, int? TipoTrailerCodigo, int? TipoVehiculoCodigo, string Descripcion, DateTime? dtmFechaIngreso, DateTime? dtmFechaEgreso, double? nitPropietario, string strMarca, double? lngModelo, double? lngMovil, double? strCelular, double? strTipoMotor, string strColor, string strMotor, string strChasis, bool? logCamarote, decimal? CapacidadGalores, decimal? floGalonesReserva, decimal? floCantGalonesReserva, decimal? floTolerancia, double? cutPeso, double? cutCapacidad, double? lngEjes, double? logActivo, double? lngLlantas, string strPolizaObligatorio, double? nitProvedorOblig, DateTime? dtmFechaInicioOblig, DateTime? dtmFechaVenceOblig, string strPolizaTodoRiesgo, double? nitProvedorTodo, DateTime? dtmFechaInicioTodo, DateTime? dtmFechaVenceTodo, string strCertifMovilizacion, DateTime? dtmFechaInicioMoviliz, DateTime? dtmFechaVenceMoviliz, string strGases, DateTime? dtmFechaInicioGases, DateTime? dtmFechaVenceGases, string strTarjetaOper, DateTime? dtmFechaInicioTarjetaOper, DateTime? dtmFechaVenceTarjetaOper, bool? logVencimientoFecha,string module, Sinapsys.Datos.SQL datosTransaccion=null)
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

				paramlist.AddWithValue("@lngIdRegistro",lngIdRegistro);
				if (lngIdUsuario !=null)
				{
					paramlist.AddWithValue("@lngIdUsuario",lngIdUsuario);
				}
				if (strPlaca !=null)
				{
					paramlist.AddWithValue("@strPlaca",strPlaca);
				}
				if (centro !=null)
				{
					paramlist.AddWithValue("@centro",centro);
				}
				if (TipoTrailerCodigo !=null)
				{
					paramlist.AddWithValue("@TipoTrailerCodigo",TipoTrailerCodigo);
				}
				if (TipoVehiculoCodigo !=null)
				{
					paramlist.AddWithValue("@TipoVehiculoCodigo",TipoVehiculoCodigo);
				}
				if (Descripcion !=null)
				{
					paramlist.AddWithValue("@Descripcion",Descripcion);
				}
				if (dtmFechaIngreso !=null)
				{
					paramlist.AddWithValue("@dtmFechaIngreso",dtmFechaIngreso);
				}
				if (dtmFechaEgreso !=null)
				{
					paramlist.AddWithValue("@dtmFechaEgreso",dtmFechaEgreso);
				}
				if (nitPropietario !=null)
				{
					paramlist.AddWithValue("@nitPropietario",nitPropietario);
				}
				if (strMarca !=null)
				{
					paramlist.AddWithValue("@strMarca",strMarca);
				}
				if (lngModelo !=null)
				{
					paramlist.AddWithValue("@lngModelo",lngModelo);
				}
				if (lngMovil !=null)
				{
					paramlist.AddWithValue("@lngMovil",lngMovil);
				}
				if (strCelular !=null)
				{
					paramlist.AddWithValue("@strCelular",strCelular);
				}
				if (strTipoMotor !=null)
				{
					paramlist.AddWithValue("@strTipoMotor",strTipoMotor);
				}
				if (strColor !=null)
				{
					paramlist.AddWithValue("@strColor",strColor);
				}
				if (strMotor !=null)
				{
					paramlist.AddWithValue("@strMotor",strMotor);
				}
				if (strChasis !=null)
				{
					paramlist.AddWithValue("@strChasis",strChasis);
				}
				if (logCamarote !=null)
				{
					paramlist.AddWithValue("@logCamarote",logCamarote);
				}
				if (CapacidadGalores !=null)
				{
					paramlist.AddWithValue("@CapacidadGalores",CapacidadGalores);
				}
				if (floGalonesReserva !=null)
				{
					paramlist.AddWithValue("@floGalonesReserva",floGalonesReserva);
				}
				if (floCantGalonesReserva !=null)
				{
					paramlist.AddWithValue("@floCantGalonesReserva",floCantGalonesReserva);
				}
				if (floTolerancia !=null)
				{
					paramlist.AddWithValue("@floTolerancia",floTolerancia);
				}
				if (cutPeso !=null)
				{
					paramlist.AddWithValue("@cutPeso",cutPeso);
				}
				if (cutCapacidad !=null)
				{
					paramlist.AddWithValue("@cutCapacidad",cutCapacidad);
				}
				if (lngEjes !=null)
				{
					paramlist.AddWithValue("@lngEjes",lngEjes);
				}
				if (logActivo !=null)
				{
					paramlist.AddWithValue("@logActivo",logActivo);
				}
				if (lngLlantas !=null)
				{
					paramlist.AddWithValue("@lngLlantas",lngLlantas);
				}
				if (strPolizaObligatorio !=null)
				{
					paramlist.AddWithValue("@strPolizaObligatorio",strPolizaObligatorio);
				}
				if (nitProvedorOblig !=null)
				{
					paramlist.AddWithValue("@nitProvedorOblig",nitProvedorOblig);
				}
				if (dtmFechaInicioOblig !=null)
				{
					paramlist.AddWithValue("@dtmFechaInicioOblig",dtmFechaInicioOblig);
				}
				if (dtmFechaVenceOblig !=null)
				{
					paramlist.AddWithValue("@dtmFechaVenceOblig",dtmFechaVenceOblig);
				}
				if (strPolizaTodoRiesgo !=null)
				{
					paramlist.AddWithValue("@strPolizaTodoRiesgo",strPolizaTodoRiesgo);
				}
				if (nitProvedorTodo !=null)
				{
					paramlist.AddWithValue("@nitProvedorTodo",nitProvedorTodo);
				}
				if (dtmFechaInicioTodo !=null)
				{
					paramlist.AddWithValue("@dtmFechaInicioTodo",dtmFechaInicioTodo);
				}
				if (dtmFechaVenceTodo !=null)
				{
					paramlist.AddWithValue("@dtmFechaVenceTodo",dtmFechaVenceTodo);
				}
				if (strCertifMovilizacion !=null)
				{
					paramlist.AddWithValue("@strCertifMovilizacion",strCertifMovilizacion);
				}
				if (dtmFechaInicioMoviliz !=null)
				{
					paramlist.AddWithValue("@dtmFechaInicioMoviliz",dtmFechaInicioMoviliz);
				}
				if (dtmFechaVenceMoviliz !=null)
				{
					paramlist.AddWithValue("@dtmFechaVenceMoviliz",dtmFechaVenceMoviliz);
				}
				if (strGases !=null)
				{
					paramlist.AddWithValue("@strGases",strGases);
				}
				if (dtmFechaInicioGases !=null)
				{
					paramlist.AddWithValue("@dtmFechaInicioGases",dtmFechaInicioGases);
				}
				if (dtmFechaVenceGases !=null)
				{
					paramlist.AddWithValue("@dtmFechaVenceGases",dtmFechaVenceGases);
				}
				if (strTarjetaOper !=null)
				{
					paramlist.AddWithValue("@strTarjetaOper",strTarjetaOper);
				}
				if (dtmFechaInicioTarjetaOper !=null)
				{
					paramlist.AddWithValue("@dtmFechaInicioTarjetaOper",dtmFechaInicioTarjetaOper);
				}
				if (dtmFechaVenceTarjetaOper !=null)
				{
					paramlist.AddWithValue("@dtmFechaVenceTarjetaOper",dtmFechaVenceTarjetaOper);
				}
				if (logVencimientoFecha !=null)
				{
					paramlist.AddWithValue("@logVencimientoFecha",logVencimientoFecha);
				}
				// Execute the query and return the new identity value
				int returnValue = Convert.ToInt32(LocalDataProvider.EjecutarProcedimiento("dbo.VehiculoCCostoCreate", paramlist, disconnect, out nullExit, DataProvider.TiempoEspera).Rows[0][0]);

				return returnValue;
			}
			catch (Exception ex)
			{
				Utilidades.LogErrores(ex.Message + (ex.InnerException != null ? ex.InnerException.Message : ""), DataProvider.AplicacionNombre);
				throw ex;
			}
		}

		/// <summary>
		/// Updates one record into tblVehiculoCCosto by passing all fields
		/// </summary>
		/// <param name="lngIdUsuario"></param>
		/// <param name="strPlaca"></param>
		/// <param name="centro"></param>
		/// <param name="TipoTrailerCodigo"></param>
		/// <param name="TipoVehiculoCodigo"></param>
		/// <param name="Descripcion"></param>
		/// <param name="dtmFechaIngreso"></param>
		/// <param name="dtmFechaEgreso"></param>
		/// <param name="nitPropietario"></param>
		/// <param name="strMarca"></param>
		/// <param name="lngModelo"></param>
		/// <param name="lngMovil"></param>
		/// <param name="strCelular"></param>
		/// <param name="strTipoMotor"></param>
		/// <param name="strColor"></param>
		/// <param name="strMotor"></param>
		/// <param name="strChasis"></param>
		/// <param name="logCamarote"></param>
		/// <param name="CapacidadGalores"></param>
		/// <param name="floGalonesReserva"></param>
		/// <param name="floCantGalonesReserva"></param>
		/// <param name="floTolerancia"></param>
		/// <param name="cutPeso"></param>
		/// <param name="cutCapacidad"></param>
		/// <param name="lngEjes"></param>
		/// <param name="logActivo"></param>
		/// <param name="lngLlantas"></param>
		/// <param name="strPolizaObligatorio"></param>
		/// <param name="nitProvedorOblig"></param>
		/// <param name="dtmFechaInicioOblig"></param>
		/// <param name="dtmFechaVenceOblig"></param>
		/// <param name="strPolizaTodoRiesgo"></param>
		/// <param name="nitProvedorTodo"></param>
		/// <param name="dtmFechaInicioTodo"></param>
		/// <param name="dtmFechaVenceTodo"></param>
		/// <param name="strCertifMovilizacion"></param>
		/// <param name="dtmFechaInicioMoviliz"></param>
		/// <param name="dtmFechaVenceMoviliz"></param>
		/// <param name="strGases"></param>
		/// <param name="dtmFechaInicioGases"></param>
		/// <param name="dtmFechaVenceGases"></param>
		/// <param name="strTarjetaOper"></param>
		/// <param name="dtmFechaInicioTarjetaOper"></param>
		/// <param name="dtmFechaVenceTarjetaOper"></param>
		/// <param name="logVencimientoFecha"></param>
		/// <param name="lngIdRegistro"></param>
		public void Update(double? lngIdUsuario, string strPlaca, double? centro, int? TipoTrailerCodigo, int? TipoVehiculoCodigo, string Descripcion, DateTime? dtmFechaIngreso, DateTime? dtmFechaEgreso, double? nitPropietario, string strMarca, double? lngModelo, double? lngMovil, double? strCelular, double? strTipoMotor, string strColor, string strMotor, string strChasis, bool? logCamarote, decimal? CapacidadGalores, decimal? floGalonesReserva, decimal? floCantGalonesReserva, decimal? floTolerancia, double? cutPeso, double? cutCapacidad, double? lngEjes, double? logActivo, double? lngLlantas, string strPolizaObligatorio, double? nitProvedorOblig, DateTime? dtmFechaInicioOblig, DateTime? dtmFechaVenceOblig, string strPolizaTodoRiesgo, double? nitProvedorTodo, DateTime? dtmFechaInicioTodo, DateTime? dtmFechaVenceTodo, string strCertifMovilizacion, DateTime? dtmFechaInicioMoviliz, DateTime? dtmFechaVenceMoviliz, string strGases, DateTime? dtmFechaInicioGases, DateTime? dtmFechaVenceGases, string strTarjetaOper, DateTime? dtmFechaInicioTarjetaOper, DateTime? dtmFechaVenceTarjetaOper, bool? logVencimientoFecha, int lngIdRegistro,string module, Sinapsys.Datos.SQL datosTransaccion=null)
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
				paramlist.AddWithValue("@lngIdRegistro",lngIdRegistro);
				if (lngIdUsuario !=null)
				{
					paramlist.AddWithValue("@lngIdUsuario",lngIdUsuario);
				}
				if (strPlaca !=null)
				{
					paramlist.AddWithValue("@strPlaca",strPlaca);
				}
				if (centro !=null)
				{
					paramlist.AddWithValue("@centro",centro);
				}
				if (TipoTrailerCodigo !=null)
				{
					paramlist.AddWithValue("@TipoTrailerCodigo",TipoTrailerCodigo);
				}
				if (TipoVehiculoCodigo !=null)
				{
					paramlist.AddWithValue("@TipoVehiculoCodigo",TipoVehiculoCodigo);
				}
				if (Descripcion !=null)
				{
					paramlist.AddWithValue("@Descripcion",Descripcion);
				}
				if (dtmFechaIngreso !=null)
				{
					paramlist.AddWithValue("@dtmFechaIngreso",dtmFechaIngreso);
				}
				if (dtmFechaEgreso !=null)
				{
					paramlist.AddWithValue("@dtmFechaEgreso",dtmFechaEgreso);
				}
				if (nitPropietario !=null)
				{
					paramlist.AddWithValue("@nitPropietario",nitPropietario);
				}
				if (strMarca !=null)
				{
					paramlist.AddWithValue("@strMarca",strMarca);
				}
				if (lngModelo !=null)
				{
					paramlist.AddWithValue("@lngModelo",lngModelo);
				}
				if (lngMovil !=null)
				{
					paramlist.AddWithValue("@lngMovil",lngMovil);
				}
				if (strCelular !=null)
				{
					paramlist.AddWithValue("@strCelular",strCelular);
				}
				if (strTipoMotor !=null)
				{
					paramlist.AddWithValue("@strTipoMotor",strTipoMotor);
				}
				if (strColor !=null)
				{
					paramlist.AddWithValue("@strColor",strColor);
				}
				if (strMotor !=null)
				{
					paramlist.AddWithValue("@strMotor",strMotor);
				}
				if (strChasis !=null)
				{
					paramlist.AddWithValue("@strChasis",strChasis);
				}
				if (logCamarote !=null)
				{
					paramlist.AddWithValue("@logCamarote",logCamarote);
				}
				if (CapacidadGalores !=null)
				{
					paramlist.AddWithValue("@CapacidadGalores",CapacidadGalores);
				}
				if (floGalonesReserva !=null)
				{
					paramlist.AddWithValue("@floGalonesReserva",floGalonesReserva);
				}
				if (floCantGalonesReserva !=null)
				{
					paramlist.AddWithValue("@floCantGalonesReserva",floCantGalonesReserva);
				}
				if (floTolerancia !=null)
				{
					paramlist.AddWithValue("@floTolerancia",floTolerancia);
				}
				if (cutPeso !=null)
				{
					paramlist.AddWithValue("@cutPeso",cutPeso);
				}
				if (cutCapacidad !=null)
				{
					paramlist.AddWithValue("@cutCapacidad",cutCapacidad);
				}
				if (lngEjes !=null)
				{
					paramlist.AddWithValue("@lngEjes",lngEjes);
				}
				if (logActivo !=null)
				{
					paramlist.AddWithValue("@logActivo",logActivo);
				}
				if (lngLlantas !=null)
				{
					paramlist.AddWithValue("@lngLlantas",lngLlantas);
				}
				if (strPolizaObligatorio !=null)
				{
					paramlist.AddWithValue("@strPolizaObligatorio",strPolizaObligatorio);
				}
				if (nitProvedorOblig !=null)
				{
					paramlist.AddWithValue("@nitProvedorOblig",nitProvedorOblig);
				}
				if (dtmFechaInicioOblig !=null)
				{
					paramlist.AddWithValue("@dtmFechaInicioOblig",dtmFechaInicioOblig);
				}
				if (dtmFechaVenceOblig !=null)
				{
					paramlist.AddWithValue("@dtmFechaVenceOblig",dtmFechaVenceOblig);
				}
				if (strPolizaTodoRiesgo !=null)
				{
					paramlist.AddWithValue("@strPolizaTodoRiesgo",strPolizaTodoRiesgo);
				}
				if (nitProvedorTodo !=null)
				{
					paramlist.AddWithValue("@nitProvedorTodo",nitProvedorTodo);
				}
				if (dtmFechaInicioTodo !=null)
				{
					paramlist.AddWithValue("@dtmFechaInicioTodo",dtmFechaInicioTodo);
				}
				if (dtmFechaVenceTodo !=null)
				{
					paramlist.AddWithValue("@dtmFechaVenceTodo",dtmFechaVenceTodo);
				}
				if (strCertifMovilizacion !=null)
				{
					paramlist.AddWithValue("@strCertifMovilizacion",strCertifMovilizacion);
				}
				if (dtmFechaInicioMoviliz !=null)
				{
					paramlist.AddWithValue("@dtmFechaInicioMoviliz",dtmFechaInicioMoviliz);
				}
				if (dtmFechaVenceMoviliz !=null)
				{
					paramlist.AddWithValue("@dtmFechaVenceMoviliz",dtmFechaVenceMoviliz);
				}
				if (strGases !=null)
				{
					paramlist.AddWithValue("@strGases",strGases);
				}
				if (dtmFechaInicioGases !=null)
				{
					paramlist.AddWithValue("@dtmFechaInicioGases",dtmFechaInicioGases);
				}
				if (dtmFechaVenceGases !=null)
				{
					paramlist.AddWithValue("@dtmFechaVenceGases",dtmFechaVenceGases);
				}
				if (strTarjetaOper !=null)
				{
					paramlist.AddWithValue("@strTarjetaOper",strTarjetaOper);
				}
				if (dtmFechaInicioTarjetaOper !=null)
				{
					paramlist.AddWithValue("@dtmFechaInicioTarjetaOper",dtmFechaInicioTarjetaOper);
				}
				if (dtmFechaVenceTarjetaOper !=null)
				{
					paramlist.AddWithValue("@dtmFechaVenceTarjetaOper",dtmFechaVenceTarjetaOper);
				}
				if (logVencimientoFecha !=null)
				{
					paramlist.AddWithValue("@logVencimientoFecha",logVencimientoFecha);
				}
				LocalDataProvider.EjecutarProcedimiento("dbo.VehiculoCCostoUpdate", paramlist, disconnect, out nullExit, DataProvider.TiempoEspera);
			}
			catch (Exception ex)
			{
				Utilidades.LogErrores(ex.Message + (ex.InnerException != null ? ex.InnerException.Message : ""), DataProvider.AplicacionNombre);
				throw ex;
			}
		}

		/// <summary>
		/// Deletes one record from tblVehiculoCCosto by passing all key fields
		/// </summary>
		/// <param name="lngIdRegistro"></param>
		public void Delete(int lngIdRegistro,string module, Sinapsys.Datos.SQL datosTransaccion=null)
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
				paramlist.AddWithValue("@lngIdRegistro",lngIdRegistro);
				LocalDataProvider.EjecutarProcedimiento("dbo.VehiculoCCostoDelete", paramlist, disconnect, out nullExit, DataProvider.TiempoEspera);
			}
			catch (Exception ex)
			{
				Utilidades.LogErrores(ex.Message + (ex.InnerException != null ? ex.InnerException.Message : ""), DataProvider.AplicacionNombre);
				throw ex;
			}
		}

		/// <summary>
		/// Gets one record from tblVehiculoCCosto passing all key fields
		/// </summary>
		/// <param name="lngIdRegistro"></param>
		/// <returns>A DataTable object containing the data</returns>
		public DataTable Get(int lngIdRegistro)
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
				paramlist.AddWithValue("@lngIdRegistro",lngIdRegistro);
				return LocalDataProvider.EjecutarProcedimiento("dbo.VehiculoCCostoGet", paramlist, disconnect, out nullExit, DataProvider.TiempoEspera);

			}
			catch (Exception ex)
			{
				Utilidades.LogErrores(ex.Message + (ex.InnerException != null ? ex.InnerException.Message : ""), DataProvider.AplicacionNombre);
				throw ex;
			}
		}

		/// <summary>
		/// Gets all records from tblVehiculoCCosto
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
				return LocalDataProvider.EjecutarProcedimiento("dbo.VehiculoCCostoGetAll", paramlist, disconnect, out nullExit, DataProvider.TiempoEspera);
			}
			catch (Exception ex)
			{
				Utilidades.LogErrores(ex.Message + (ex.InnerException != null ? ex.InnerException.Message : ""), DataProvider.AplicacionNombre);
				throw ex;
			}
		}

		/// <summary>
		/// Gets all records from tblVehiculoCCosto applying filter and sort criteria
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

				return LocalDataProvider.EjecutarProcedimiento("dbo.VehiculoCCostoGetFilter", paramlist, disconnect, out nullExit, DataProvider.TiempoEspera);
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
		/// Gets the numbers of records from tblVehiculoCCosto applying filter and sort criteria
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

				return (int) LocalDataProvider.EjecutarProcedimiento("dbo.VehiculoCCostoGetFilter", paramlist, disconnect, out nullExit, DataProvider.TiempoEspera).Rows[0][0];
			}
			catch (Exception ex)
			{
				Utilidades.LogErrores(ex.Message + (ex.InnerException != null ? ex.InnerException.Message : ""), DataProvider.AplicacionNombre);
				throw ex;
			}
		}

	}
}
