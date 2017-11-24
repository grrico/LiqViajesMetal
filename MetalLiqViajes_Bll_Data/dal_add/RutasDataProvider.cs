using System;
using System.Data;
using System.Data.Common;
using Sinapsys.Datos;
using LiqViajes_Bll_Data.Security;
using System.Runtime.Serialization;

namespace LiqViajes_Bll_Data
{
	public partial class RutasDataProvider
	{
		public DataTable GetBy_RutasOrigenDestino(string rutaorigen, string rutadestino, string rutaanticipo)
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


                paramlist.AddWithValue("@strRutaAnticipoGrupoOrigen", rutaorigen);
                paramlist.AddWithValue("@strRutaAnticipoGrupoDestino", rutadestino);
                paramlist.AddWithValue("@strRutaAnticipo", rutaanticipo);

                return LocalDataProvider.EjecutarProcedimiento("dbo.Add_RutasGetBy_RutasOrigenDestino", paramlist, disconnect, out nullExit, DataProvider.TiempoEspera);
			}
			catch (Exception ex)
			{
				Utilidades.LogErrores(ex.Message + (ex.InnerException != null ? ex.InnerException.Message : ""), DataProvider.AplicacionNombre);
				throw ex;
			}
		}

	}
}
