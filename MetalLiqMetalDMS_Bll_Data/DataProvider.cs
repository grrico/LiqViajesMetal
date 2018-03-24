using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LiqMetalDMS_Bll_Data
{
    public static class DataProvider
    {
        public static Sinapsys.Datos.SQL Datos = new Sinapsys.Datos.SQL();
        public static  int TiempoEspera = 60;
        public static string m_Alias = "MetalLiqViajes";
        public static string m_Aliasdms = "MetalLiqViajesDms";
        public static bool Concurrente = false;
        public static bool CulturaCreada = false;
        public static string AplicacionNombre;
        public static bool TransaccionConcurrente = false;
        public static string PathFotos = @"\\Metal\Fotos$\";
        
        public static string Alias
        {
            get { return DataProvider.m_Alias; }
            set
            {
                if (Datos.Conexion != null)
                {
                    if (Datos.Conexion.State == System.Data.ConnectionState.Open)
                    {
                        Datos.Conexion.Close();
                    }
                }
                DataProvider.m_Alias = value;
            }
        }       
        public static bool ValidateConnection()
        {
            bool disconnect = false;
            bool mustConnect = false;
            if (Concurrente)
            {
                disconnect = true;
            }
            else
            {
                if (Datos.Conexion == null)
                {
                    mustConnect = true;
                }
                else
                {
                    mustConnect = Datos.Conexion.State != System.Data.ConnectionState.Open;
                }
                if (mustConnect)
                {
                    disconnect = true;
                    Datos.Conectar(DataProvider.Alias, false);
                }
            }
            return disconnect;
        }

        public static bool EjecutarSQL(string sql, out string error, Sinapsys.Datos.SQL datosTransaccion = null)
        {
            bool ret=false;
            error = "";
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
                //System.Data.SqlClient.SqlCommand Comando = new System.Data.SqlClient.SqlCommand();
                //System.Data.SqlClient.SqlParameterCollection paramlist = Comando.Parameters;
                LocalDataProvider.EjecutarSentencia(sql,disconnect);
                //LiqViajes_Bll_Data.DataProvider.Datos.EjecutarSentencia(sql);
                ret = true;
            }
            catch (Exception e)
            {
                ret = false;
                error = e.Message + (e.InnerException!=null?" : " + e.InnerException.Message:"");
            }
            return ret;
        }

        public static bool UpdateFieldsbyObject(string[] fields, IDTOObject objeto, out string error, Sinapsys.Datos.SQL datosTransaccion = null)
        {
            bool ret = false;
            error = "";
            if (fields.Length == 0)
            {
                error = "No hay campos por actualizar";
                return true;
            }
            if (objeto == null)
            {
                error = "no se puede ejecutar sin un objeto válido";
                return false;
            }

            try
            {
                string wherekey = objeto.GetSqlKey();
                ret=UpdateFieldsbyQuery(fields, objeto, wherekey, out error,datosTransaccion);
            }
            catch (Exception e)
            {
                error = e.Message;
                ret = false;
            }
            return ret;
        }

        public static bool UpdateFieldsbyQuery(string[] fields, IDTOObject objeto, string where, out string error, Sinapsys.Datos.SQL datosTransaccion = null)
        {
            error = "";
            bool ret = false;
            if (fields.Length == 0)
            {
                error = "No hay campos por actualizar";
                return true;
            }
            if (where.Trim() == "")
            {
                error = "no se puede ejecutar sin una instrucción where";
                return false;
            }
            if (objeto==null)
            {
                error = "no se puede ejecutar sin un objeto válido";
                return false;
            }

            try
            {
                if (!CulturaCreada) CrearCultura();
                // Update values
                string fieldsValue = "";
                foreach (string field in fields)
                {
                    if (objeto.GetAttribute(field) == null)
                    {
                        if (objeto.GetAttributeType(field).Name.ToLower() == "string")
                        {
                            fieldsValue += field + "='',";
                        }
                        else
                        {
                            fieldsValue += field + "=NULL,";
                        }
                    }
                    else
                    {
                        switch (objeto.GetAttributeType(field).Name.ToLower())
                        {
                            case "string":
                                fieldsValue += field + "='" + objeto.GetAttribute(field).ToString() + "',";
                                break;
                            case "datetime":
                                fieldsValue += field + "='" + ((DateTime)objeto.GetAttribute(field)).ToString("yyyy/MM/dd HH:mm:ss") + "',";
                                break;
                            case "boolean":
                            case "bool":
                                fieldsValue += field + "=" + (((bool)objeto.GetAttribute(field)) ? "1" : "0") + ",";
                                break;
                            default:
                                fieldsValue += field + "=" + objeto.GetAttribute(field).ToString() + ",";
                                break;

                        }
                    }
                }
                fieldsValue = fieldsValue.Substring(0, fieldsValue.Length - 1);
                
                string sql = "update " + objeto.TableName() + " set " + fieldsValue + " where " + where;
                
                ret = LiqViajes_Bll_Data.DataProvider.EjecutarSQL(sql, out error,datosTransaccion);
            }
            catch (Exception e)
            {
                error = e.Message;
                ret = false;
            }
            return ret;

        }

        private static void CrearCultura()
        {
            //Se realiza la configuración de los formatos de fecha.
            string[] DiasSemana = new string[7];
            string[] MesesAño = new string[13];
            System.Globalization.DateTimeFormatInfo dtfFecha = new System.Globalization.DateTimeFormatInfo();

            dtfFecha.ShortDatePattern = "dd/MM/yyyy";
            dtfFecha.FullDateTimePattern = "dd/MM/yyyy hh:mm:ss tt";

            DiasSemana[0] = "Lunes";
            DiasSemana[1] = "Martes";
            DiasSemana[2] = "Miércoles";
            DiasSemana[3] = "Jueves";
            DiasSemana[4] = "Viernes";
            DiasSemana[5] = "Sábado";
            DiasSemana[6] = "Domingo";
            dtfFecha.DayNames = DiasSemana;

            MesesAño[0] = "Enero";
            MesesAño[1] = "Febrero";
            MesesAño[2] = "Marzo";
            MesesAño[3] = "Abril";
            MesesAño[4] = "Mayo";
            MesesAño[5] = "Junio";
            MesesAño[6] = "Julio";
            MesesAño[7] = "Agosto";
            MesesAño[8] = "Septiembre";
            MesesAño[9] = "Octubre";
            MesesAño[10] = "Noviembre";
            MesesAño[11] = "Diciembre";
            MesesAño[12] = "";
            dtfFecha.MonthNames = MesesAño;

            //Se realiza la configuración del formato de moneda.
            System.Globalization.NumberFormatInfo nbrNumerico = new System.Globalization.NumberFormatInfo();
            nbrNumerico.CurrencyDecimalDigits = 0;
            nbrNumerico.CurrencyDecimalSeparator = ".";
            nbrNumerico.CurrencyGroupSeparator = ",";
            nbrNumerico.CurrencySymbol = "$";

            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("es-CO");
            System.Threading.Thread.CurrentThread.CurrentCulture.DateTimeFormat = dtfFecha;
            System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat = nbrNumerico;

            CulturaCreada = true;
        }

    }

    public class ProcedimientoConcurrente
    {
        public string Tabla { get; set; }
        public string Nombre {get;set;}
        public System.Data.SqlClient.SqlParameterCollection paramlist { get; set; }
    }

    

}
