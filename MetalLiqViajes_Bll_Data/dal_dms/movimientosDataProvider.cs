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
    }
}
