using System;
using System.Data;
using System.Data.Common;
using Sinapsys.Datos;
using LiqViajes_Bll_Data.Security;
using System.Runtime.Serialization;

namespace LiqViajes_Bll_Data
{
    public partial class RutaSatrackHistoryEventsDataProvider
    {
        public DataTable GetByPlacaFecha(string Placa, DateTime FechaInicial, DateTime FechaFinal)
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
                paramlist.AddWithValue("@Placa", Placa);
                paramlist.AddWithValue("@FechaInicial", FechaInicial);
                paramlist.AddWithValue("@FechaFInal", FechaFinal);
                return LocalDataProvider.EjecutarProcedimiento("dbo.Add_RutaSatrackHistoryEventsGetPlacaFecha", paramlist, disconnect, out nullExit, DataProvider.TiempoEspera);
            }
            catch (Exception ex)
            {
                Utilidades.LogErrores(ex.Message + (ex.InnerException != null ? ex.InnerException.Message : ""), DataProvider.AplicacionNombre);
                throw ex;
            }
        }


        public DataTable GetByPlacaFechaGPS(string Placa, DateTime FechaGps, decimal Latitud, decimal Longitud)
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
                string fecha = FechaGps.ToString("yyyy-MM-dd hh:mm:ss");
                paramlist.AddWithValue("@Placa", Placa);
                paramlist.AddWithValue("@FechaHora_GPS", fecha);
                paramlist.AddWithValue("@Latitud", Latitud);
                paramlist.AddWithValue("@Longitud", Longitud);

                return LocalDataProvider.EjecutarProcedimiento("dbo.Add_RutaSatrackHistoryEventsGetPlacaFechaGpsLatLng", paramlist, disconnect, out nullExit, DataProvider.TiempoEspera);
            }
            catch (Exception ex)
            {
                Utilidades.LogErrores(ex.Message + (ex.InnerException != null ? ex.InnerException.Message : ""), DataProvider.AplicacionNombre);
                throw ex;
            }
        }
    }
}
