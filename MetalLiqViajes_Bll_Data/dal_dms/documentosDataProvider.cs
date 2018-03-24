using System;
using System.Data;
using System.Data.Common;
using Sinapsys.Datos;
using LiqViajes_Bll_Data.Security;
using System.Runtime.Serialization;

namespace LiqViajes_Bll_Data
{

    public partial class documentosDataProvider
    {
        private static documentosDataProvider MySingleObj = null;

        public documentosDataProvider()
        {

        }

        public static documentosDataProvider Instance
        {
            get
            {
                if (MySingleObj == null)
                {
                    MySingleObj = new documentosDataProvider();
                }

                return MySingleObj;
            }
        }

        public DataTable Get(int id, string tipo, int numero)
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
                paramlist.AddWithValue("@id", id);
                paramlist.AddWithValue("@tipo", tipo);
                paramlist.AddWithValue("@numero", numero);
                return LocalDataProvider.EjecutarProcedimiento("dbo.documentosGet", paramlist, disconnect, out nullExit, DataProvider.TiempoEspera);

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
                return LocalDataProvider.EjecutarProcedimiento("dbo.documentosGetAll", paramlist, disconnect, out nullExit, DataProvider.TiempoEspera);
            }
            catch (Exception ex)
            {
                Utilidades.LogErrores(ex.Message + (ex.InnerException != null ? ex.InnerException.Message : ""), DataProvider.AplicacionNombre);
                throw ex;
            }
        }

        public DataTable GetBy_TipoNitFechaGetAll(string tipo, string nit, DateTime fechaI, DateTime fechaF)
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
                paramlist.AddWithValue("@nit", nit);
                paramlist.AddWithValue("@fechaI", fechaI);
                paramlist.AddWithValue("@fechaF", fechaF);
                return LocalDataProvider.EjecutarProcedimiento("dbo.add_documentosGetByTipoNitFechaGetAll", paramlist, disconnect, out nullExit, DataProvider.TiempoEspera);
            }
            catch (Exception ex)
            {
                Utilidades.LogErrores(ex.Message + (ex.InnerException != null ? ex.InnerException.Message : ""), DataProvider.AplicacionNombre);
                throw ex;
            }
        }

        public DataSet GetBy_TipoNitFecha(string tipo, string nit, DateTime fechaI, DateTime fechaF)
        {
            try
            {
                if (Validate.security.CanUse("SD_CreditosReporte"))
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
                    paramlist.AddWithValue("@nit", nit);
                    paramlist.AddWithValue("@fechaI", fechaI);
                    paramlist.AddWithValue("@fechaF", fechaF);
                    return LocalDataProvider.EjecutarProcedimientoDS("dbo.add_documentosGetByTipoNitFecha", paramlist, out nullExit, DataProvider.TiempoEspera);
                }
                else
                    return null;
            }
            catch (Exception ex)
            {
                Utilidades.LogErrores(ex.Message + (ex.InnerException != null ? ex.InnerException.Message : ""), DataProvider.AplicacionNombre);
                throw ex;
            }
        }

    }
}
