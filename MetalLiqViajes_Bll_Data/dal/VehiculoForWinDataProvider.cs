using System;
using System.Data;
using System.Data.Common;
using Sinapsys.Datos;
using LiqViajes_Bll_Data.Security;
using System.Runtime.Serialization;

namespace LiqViajes_Bll_Data
{
	/// <summary>
	/// Data Access Layer class for VehiculoForWin object
	/// </summary>
	/// <remarks>
	/// This class is a Singleton
	/// </remarks>
	public partial class VehiculoForWinDataProvider
	{
		/// <summary>
		/// Internal member for create this singleton
		/// </summary>
		private static VehiculoForWinDataProvider MySingleObj = null;

		/// <summary>
		/// Protected constructor to avoid access this singleton other way than calling the Instance method
		/// </summary>
		public VehiculoForWinDataProvider()
		{

		}

		/// <summary>
		/// Instance accessor for this singleton
		/// </summary>
		public static VehiculoForWinDataProvider Instance
		{
			get
			{
				if (MySingleObj == null)
				{
					MySingleObj = new VehiculoForWinDataProvider();
				}

				return MySingleObj;
			}
		}

		/// <summary>
		/// Creates a new record into tblVehiculoForWin by passing all fields
		/// </summary>
		/// <param name="strPlaca"></param>
		/// <param name="centro"></param>
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
		public void Create(int lngIdRegistro, int lngIdUsuario, int strPlaca, int? centro, int? TipoVehiculoCodigo, string Descripcion, int? dtmFechaIngreso, int? dtmFechaEgreso, int? nitPropietario, int? strMarca, int? lngModelo, int? lngMovil, int? strCelular, int? strTipoMotor, int? strColor, int? strMotor, int? strChasis, int? logCamarote, int? cutPeso, int? cutCapacidad, int? lngEjes, int? logActivo, int? lngLlantas, int? strPolizaObligatorio, int? nitProvedorOblig, int? dtmFechaInicioOblig, int? dtmFechaVenceOblig, int? strPolizaTodoRiesgo, int? nitProvedorTodo, int? dtmFechaInicioTodo, int? dtmFechaVenceTodo, int? strCertifMovilizacion, int? dtmFechaInicioMoviliz, int? dtmFechaVenceMoviliz, int? strGases, int? dtmFechaInicioGases, int? dtmFechaVenceGases, int? strTarjetaOper, int? dtmFechaInicioTarjetaOper, int? dtmFechaVenceTarjetaOper, int? logVencimientoFecha,string module, Sinapsys.Datos.SQL datosTransaccion=null)
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
				paramlist.AddWithValue("@lngIdUsuario",lngIdUsuario);
				paramlist.AddWithValue("@strPlaca",strPlaca);
				if (centro !=null)
				{
					paramlist.AddWithValue("@centro",centro);
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
				LocalDataProvider.EjecutarProcedimiento("dbo.VehiculoForWinCreate", paramlist, disconnect, out nullExit, DataProvider.TiempoEspera);
			}
			catch (Exception ex)
			{
				Utilidades.LogErrores(ex.Message + (ex.InnerException != null ? ex.InnerException.Message : ""), DataProvider.AplicacionNombre);
				throw ex;
			}
		}

		/// <summary>
		/// Updates one record into tblVehiculoForWin by passing all fields
		/// </summary>
		/// <param name="strPlaca"></param>
		/// <param name="centro"></param>
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
		/// <param name="lngIdUsuario"></param>
		public void Update(int strPlaca, int? centro, int? TipoVehiculoCodigo, string Descripcion, int? dtmFechaIngreso, int? dtmFechaEgreso, int? nitPropietario, int? strMarca, int? lngModelo, int? lngMovil, int? strCelular, int? strTipoMotor, int? strColor, int? strMotor, int? strChasis, int? logCamarote, int? cutPeso, int? cutCapacidad, int? lngEjes, int? logActivo, int? lngLlantas, int? strPolizaObligatorio, int? nitProvedorOblig, int? dtmFechaInicioOblig, int? dtmFechaVenceOblig, int? strPolizaTodoRiesgo, int? nitProvedorTodo, int? dtmFechaInicioTodo, int? dtmFechaVenceTodo, int? strCertifMovilizacion, int? dtmFechaInicioMoviliz, int? dtmFechaVenceMoviliz, int? strGases, int? dtmFechaInicioGases, int? dtmFechaVenceGases, int? strTarjetaOper, int? dtmFechaInicioTarjetaOper, int? dtmFechaVenceTarjetaOper, int? logVencimientoFecha, int lngIdRegistro, int lngIdUsuario,string module, Sinapsys.Datos.SQL datosTransaccion=null)
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
				paramlist.AddWithValue("@lngIdUsuario",lngIdUsuario);
				paramlist.AddWithValue("@strPlaca",strPlaca);
				if (centro !=null)
				{
					paramlist.AddWithValue("@centro",centro);
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
				LocalDataProvider.EjecutarProcedimiento("dbo.VehiculoForWinUpdate", paramlist, disconnect, out nullExit, DataProvider.TiempoEspera);
			}
			catch (Exception ex)
			{
				Utilidades.LogErrores(ex.Message + (ex.InnerException != null ? ex.InnerException.Message : ""), DataProvider.AplicacionNombre);
				throw ex;
			}
		}

		/// <summary>
		/// Deletes one record from tblVehiculoForWin by passing all key fields
		/// </summary>
		/// <param name="lngIdRegistro"></param>
		/// <param name="lngIdUsuario"></param>
		public void Delete(int lngIdRegistro, int lngIdUsuario,string module, Sinapsys.Datos.SQL datosTransaccion=null)
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
				paramlist.AddWithValue("@lngIdUsuario",lngIdUsuario);
				LocalDataProvider.EjecutarProcedimiento("dbo.VehiculoForWinDelete", paramlist, disconnect, out nullExit, DataProvider.TiempoEspera);
			}
			catch (Exception ex)
			{
				Utilidades.LogErrores(ex.Message + (ex.InnerException != null ? ex.InnerException.Message : ""), DataProvider.AplicacionNombre);
				throw ex;
			}
		}

		/// <summary>
		/// Gets one record from tblVehiculoForWin passing all key fields
		/// </summary>
		/// <param name="lngIdRegistro"></param>
		/// <param name="lngIdUsuario"></param>
		/// <returns>A DataTable object containing the data</returns>
		public DataTable Get(int lngIdRegistro, int lngIdUsuario)
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
				paramlist.AddWithValue("@lngIdUsuario",lngIdUsuario);
				return LocalDataProvider.EjecutarProcedimiento("dbo.VehiculoForWinGet", paramlist, disconnect, out nullExit, DataProvider.TiempoEspera);

			}
			catch (Exception ex)
			{
				Utilidades.LogErrores(ex.Message + (ex.InnerException != null ? ex.InnerException.Message : ""), DataProvider.AplicacionNombre);
				throw ex;
			}
		}

		/// <summary>
		/// Gets all records from tblVehiculoForWin
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
				return LocalDataProvider.EjecutarProcedimiento("dbo.VehiculoForWinGetAll", paramlist, disconnect, out nullExit, DataProvider.TiempoEspera);
			}
			catch (Exception ex)
			{
				Utilidades.LogErrores(ex.Message + (ex.InnerException != null ? ex.InnerException.Message : ""), DataProvider.AplicacionNombre);
				throw ex;
			}
		}

		/// <summary>
		/// Gets all records from tblVehiculoForWin applying filter and sort criteria
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

				return LocalDataProvider.EjecutarProcedimiento("dbo.VehiculoForWinGetFilter", paramlist, disconnect, out nullExit, DataProvider.TiempoEspera);
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
		/// Gets the numbers of records from tblVehiculoForWin applying filter and sort criteria
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

				return (int) LocalDataProvider.EjecutarProcedimiento("dbo.VehiculoForWinGetFilter", paramlist, disconnect, out nullExit, DataProvider.TiempoEspera).Rows[0][0];
			}
			catch (Exception ex)
			{
				Utilidades.LogErrores(ex.Message + (ex.InnerException != null ? ex.InnerException.Message : ""), DataProvider.AplicacionNombre);
				throw ex;
			}
		}

	}
}
