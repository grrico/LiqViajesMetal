using System;
using System.Data;
using System.Data.Common;
using Sinapsys.Datos;
using LiqViajes_Bll_Data.Security;
using System.Runtime.Serialization;

namespace LiqViajes_Bll_Data
{
	public partial class movimientosDataProvider
	{
		private static movimientosDataProvider MySingleObj = null;

        public movimientosDataProvider()
		{

		}

		public static movimientosDataProvider Instance
		{
			get
			{
				if (MySingleObj == null)
				{
					MySingleObj = new movimientosDataProvider();
				}

				return MySingleObj;
			}
		}

		public DataTable Get(string tipo, int numero, int seq)
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
				paramlist.AddWithValue("@tipo",tipo);
				paramlist.AddWithValue("@numero",numero);
				paramlist.AddWithValue("@seq",seq);
				return LocalDataProvider.EjecutarProcedimiento("dbo.movimientoGet", paramlist, disconnect, out nullExit, DataProvider.TiempoEspera);

			}
			catch (Exception ex)
			{
				Utilidades.LogErrores(ex.Message + (ex.InnerException != null ? ex.InnerException.Message : ""), DataProvider.AplicacionNombre);
				throw ex;
			}
		}

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
				return LocalDataProvider.EjecutarProcedimiento("dbo.movimientoGetAll", paramlist, disconnect, out nullExit, DataProvider.TiempoEspera);
			}
			catch (Exception ex)
			{
				Utilidades.LogErrores(ex.Message + (ex.InnerException != null ? ex.InnerException.Message : ""), DataProvider.AplicacionNombre);
				throw ex;
			}
		}

        public DataTable GetByTipoNumero(string tipo, int numero)
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
                paramlist.AddWithValue("@tipo", tipo);
                paramlist.AddWithValue("@numero", numero);

                return LocalDataProvider.EjecutarProcedimiento("dbo.add_movimientoGetByTipoNumero", paramlist, disconnect, out nullExit, DataProvider.TiempoEspera);
            }
            catch (Exception ex)
            {
                Utilidades.LogErrores(ex.Message + (ex.InnerException != null ? ex.InnerException.Message : ""), DataProvider.AplicacionNombre);
                throw ex;
            }
        }

        public void Create(string tipo, int numero, int seq, string cuenta, int centro, decimal nit, DateTime fec, decimal valor, int? documento, string explicacion, string concilio, short? concepto_mov, short? concilio_ano, int? secuencia_extracto, int? ano_concilia, int? mes_concilia, decimal valor_niif, string module, Sinapsys.Datos.SQL datosTransaccion = null)
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

                paramlist.AddWithValue("@tipo", tipo);
                paramlist.AddWithValue("@numero", numero);
                paramlist.AddWithValue("@seq", seq);
                paramlist.AddWithValue("@cuenta", cuenta);
                paramlist.AddWithValue("@centro", centro);
                paramlist.AddWithValue("@nit", nit);
                paramlist.AddWithValue("@fec", fec);
                paramlist.AddWithValue("@valor", valor);

                if (documento != null)
                {
                    paramlist.AddWithValue("@documento", documento);
                }
                if (explicacion != null)
                {
                    paramlist.AddWithValue("@explicacion", explicacion);
                }
                if (concilio != null)
                {
                    paramlist.AddWithValue("@concilio", concilio);
                }
                if (concepto_mov != null)
                {
                    paramlist.AddWithValue("@concepto_mov", concepto_mov);
                }
                if (concilio_ano != null)
                {
                    paramlist.AddWithValue("@concilio_ano", concilio_ano);
                }
                if (secuencia_extracto != null)
                {
                    paramlist.AddWithValue("@secuencia_extracto", secuencia_extracto);
                }
                if (ano_concilia != null)
                {
                    paramlist.AddWithValue("@ano_concilia", ano_concilia);
                }
                if (mes_concilia != null)
                {
                    paramlist.AddWithValue("@mes_concilia", mes_concilia);
                }
                paramlist.AddWithValue("@valor_niif", valor_niif);
                LocalDataProvider.EjecutarProcedimiento("dbo.movimientoCreate", paramlist, disconnect, out nullExit, DataProvider.TiempoEspera);
            }
            catch (Exception ex)
            {
                Utilidades.LogErrores(ex.Message + (ex.InnerException != null ? ex.InnerException.Message : ""), DataProvider.AplicacionNombre);
                throw ex;
            }
        }

    }
}
