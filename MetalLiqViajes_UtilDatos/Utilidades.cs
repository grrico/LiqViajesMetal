using System;
using System.Collections.Generic;
using System.Text;

namespace Sinapsys.Datos
{
    public static class Utilidades
    {
        public static string RutaConfiguracion
        {
            get
            {

                if (System.IO.File.Exists("C:\\Metal\\Metal_Olap\\UtilSQL.Config"))
                    return "C:\\Metal\\Metal_Olap\\UtilSQL.Config";
                else
                    return System.Environment.SystemDirectory + @"\UtilSQL.Config";
            }
        }

        private static string[,] m_alias = null;
        public static string[,] Alias
        {
            get
            {
                if (m_alias == null)
                    m_alias = CargarAlias();
                return m_alias;
            }
        }

        private static string[,] CargarAlias()
        {
            string[,] Resultado;
            string ArchivoConfiguracion = System.Environment.SystemDirectory + @"\UtilSQL.Config";

            System.Xml.XmlDocument Configuracion = new System.Xml.XmlDocument();
            Configuracion.Load(ArchivoConfiguracion);
            System.Xml.XmlNodeList AliasTmp = Configuracion.SelectNodes("configuracion/alias");

            Resultado = new string[AliasTmp.Count, 2];

            int Contador = -1;
            foreach(System.Xml.XmlNode NodoTmp in AliasTmp)
            {
                Contador++;
                Resultado[Contador, 0] = NodoTmp.Attributes.GetNamedItem("nombre").InnerText;
                Resultado[Contador, 1] = NodoTmp.Attributes.GetNamedItem("cadenaconexion").InnerText;
            }

            return Resultado;
        }

        public static void LogEventos(string Source, string Aplicacion, int IdEvento, short Categoria, string Mensaje, System.Diagnostics.EventLogEntryType TipoMensaje)
        {
            try
            {
                if (!System.Diagnostics.EventLog.SourceExists(Source))
                {
                    System.Diagnostics.EventLog.CreateEventSource(Source, "Application");
                }
                System.Diagnostics.EventLog LogEvent = new System.Diagnostics.EventLog();
                LogEvent.Source = Source;
                LogEvent.Log = "Application";
                LogEvent.WriteEntry(Mensaje, TipoMensaje, IdEvento, Categoria);
            }
            catch
            {

            }
        }
        public static void LogErrores(string Error, string Aplicacion)
        {
            try
            {
                string path = Environment.GetFolderPath(Environment.SpecialFolder.Programs) + @"\MetalApps\LogErrores.txt";
                System.IO.StreamWriter LogErrores = new System.IO.StreamWriter(path, true);
                LogErrores.WriteLine("Fecha=" + DateTime.Now.ToString() + "|Error=" + Error + "|Aplicacion=" + Aplicacion);
                LogErrores.Flush();
                LogErrores.Close();
            }
            catch
            {

            }
        }
        public static void LogErrores(string Ruta, string Error, string Aplicacion)
        {
            try
            {
                System.IO.StreamWriter LogErrores = new System.IO.StreamWriter(Ruta, true);
                LogErrores.WriteLine("Fecha=" + DateTime.Now.ToString() + "|Error=" + Error + "|Aplicacion=" + Aplicacion);
                LogErrores.Flush();
                LogErrores.Close();
            }
            catch
            {

            }
        }


    }
}
