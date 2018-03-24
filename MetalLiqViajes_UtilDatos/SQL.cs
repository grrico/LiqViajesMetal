using System;
using System.Collections;
using System.Data;
using System.Data.SqlClient;
using System.Xml;
using System.IO;
using System.Text;

namespace Sinapsys.Datos
{
    /// <summary>
    /// Descripción breve de SQL.
    /// </summary>
    public sealed class SQL : IDisposable
    {
        #region Declaración de enumerados.
        public enum Transacciones
        {
            Transacciones_Commit,
            Transacciones_Rollback
        }
        #endregion

        #region Declaración de variables privadas.
        private System.Data.SqlClient.SqlConnection ConexionSQLGlobal;
        private System.Data.SqlClient.SqlTransaction TransaccionSQLGlobal = null;
        private bool generarLog = false;

        #endregion

        #region Constructores.
        /// <summary>
        /// 
        /// </summary>
        public SQL()
        {
            generarLog = false;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="Servidor"></param>
        /// <param name="Usuario"></param>
        /// <param name="Contraseña"></param>
        /// <param name="Basedatos"></param>
        public SQL(string Servidor, string Usuario, string Contraseña, string Basedatos, bool Transaccional)
        {
            Conectar(Servidor, Usuario, Contraseña, Basedatos, Transaccional);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="Servidor"></param>
        /// <param name="BaseDatos"></param>
        public SQL(string Servidor, string BaseDatos, bool Transaccional)
        {
            Conectar(Servidor, BaseDatos, Transaccional);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="Alias"></param>
        public SQL(string Alias, bool Transaccional)
        {
            Conectar(Alias, Transaccional);
        }
        #endregion

        #region Métodos públicos.
        /// <summary>
        /// 
        /// </summary>
        /// <param name="Servidor"></param>
        /// <param name="Usuario"></param>
        /// <param name="Contraseña"></param>
        /// <param name="BaseDatos"></param>
        /// <param name="Transaccional"></param>
        /// <returns></returns>
        public bool Conectar(string Servidor, string Usuario, string Contraseña, string BaseDatos, bool Transaccional)
        {
            string CadenaConexion = "Persist Security Info=False;User ID=" + Usuario + ";Password=" + Contraseña + ";Initial Catalog=" + BaseDatos + ";Data Source=" + Servidor;
            return ConectarSQL(CadenaConexion, Transaccional);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="Servidor"></param>
        /// <param name="BaseDatos"></param>
        /// <param name="Transaccional"></param>
        /// <returns></returns>
        public bool Conectar(string Servidor, string BaseDatos, bool Transaccional)
        {
            string CadenaConexion = "Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=" + BaseDatos + ";Data Source=" + Servidor;
            return ConectarSQL(CadenaConexion, Transaccional);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="Alias"></param>
        /// <param name="Transaccional"></param>
        /// <returns></returns>
        public bool Conectar(string Alias, bool Transaccional)
        {
            string ArchivoConfiguracion;
            string CadenaConexionTmp = "";
            System.Xml.XmlNode AliasTmp = null;

            bool iSw = false;

            if (iSw)
            {
                string carpeta = @"C:\Metal\Modulo\";
                if (!Directory.Exists(@carpeta))
                    Directory.CreateDirectory(carpeta);

                if (!System.IO.File.Exists(Properties.Settings.Default.UtilSQL))
                {
                    StreamWriter sw = new StreamWriter(@"C:\Metal\Modulo\UtilSQL.Config");
                    string fila = "<configuracion>\n";
                    sw.WriteLine(fila, Encoding.Default);
                    fila = "  <alias nombre='MetalApps22' cadenaconexion='Provider = SQLOLEDB.1; Persist Security Info = False; User ID = sa; Pwd = Axapta4; Initial Catalog = Metal_Olap; Data Source = GENARO - PC; Application Name = ConsultaPersona'/>\n";
                    sw.WriteLine(fila, Encoding.Default);
                    fila = "  <alias nombre='MetalApps' cadenaconexion='Provider = SQLOLEDB.1; Persist Security Info = False; User ID = sa; Pwd = ml1973 * 1973ml; Initial Catalog = Metal_Olap; Data Source = 201.232.8.2; Application Name = ConsultaPersona'/>";
                    sw.WriteLine(fila, Encoding.Default);
                    fila = "<configuracion>\n";
                    sw.WriteLine(fila, Encoding.Default);
                    sw.Close();
                    sw.Flush();
                    // se crea el config
                }
            }


            if (System.IO.File.Exists(Properties.Settings.Default.UtilSQL))
            {
                ArchivoConfiguracion = Properties.Settings.Default.UtilSQL;
                System.Xml.XmlDocument Configuracion = new XmlDocument();
                Configuracion.Load(ArchivoConfiguracion);
                AliasTmp = Configuracion.SelectSingleNode("configuracion/alias[@nombre='" + Alias + "']");
                if (AliasTmp != null)
                    CadenaConexionTmp = AliasTmp.Attributes.GetNamedItem("cadenaconexion").Value;
            }
            if (AliasTmp == null)
            {
                ArchivoConfiguracion = System.Environment.SystemDirectory + @"\UtilSQL.Config";
                System.Xml.XmlDocument Configuracion = new XmlDocument();
                Configuracion.Load(ArchivoConfiguracion);
                AliasTmp = Configuracion.SelectSingleNode("configuracion/alias[@nombre='" + Alias + "']");
                if (AliasTmp == null)
                {
                    Sinapsys.Datos.SQLException SQLExc = new SQLException("No se hallo el alias [" + Alias + "] en el catálogo.");

                    throw (SQLExc);
                }
                CadenaConexionTmp = AliasTmp.Attributes.GetNamedItem("cadenaconexion").Value;
            }
            return ConectarSQL(CadenaConexionTmp, Transaccional);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="Alias"></param>
        /// <param name="Transaccional"></param>
        /// <param name="UbicacionConfiguracion"></param>
        /// <returns></returns>
        public bool Conectar(string Alias, bool Transaccional, string UbicacionConfiguracion)
        {
            if (System.IO.File.Exists(UbicacionConfiguracion))
            {
                //Analiza el archivo xml buscando resolver el alias dado.
                System.Xml.XmlDocument Configuracion = new XmlDocument();
                Configuracion.Load(UbicacionConfiguracion);
                System.Xml.XmlNode AliasTmp = Configuracion.SelectSingleNode("configuracion/alias[@nombre='" + Alias + "']");
                string CadenaConexionTmp = AliasTmp.Attributes.GetNamedItem("cadenaconexion").Value;

                return ConectarSQL(CadenaConexionTmp, Transaccional);
            }
            else
            {
                throw (new System.IO.FileNotFoundException());
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="CadenaConexion"></param>
        /// <param name="Transaccional"></param>
        /// <returns></returns>
        public bool ConectarEX(string CadenaConexion, bool Transaccional)
        {
            return ConectarSQL(CadenaConexion, Transaccional);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Sentencia"></param>
        /// <returns></returns>
        public System.Data.DataTable EjecutarSentencia(string Sentencia)
        {
            return EjecutarTSQL(Sentencia, true, 3000);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="Sentencia"></param>
        /// <param name="DesconexionAutomatica"></param>
        /// <returns></returns>
        public System.Data.DataTable EjecutarSentencia(string Sentencia, bool DesconexionAutomatica)
        {
            return EjecutarTSQL(Sentencia, DesconexionAutomatica, 3000);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Sentencia"></param>
        /// <param name="DesconexionAutomatica"></param>
        /// <param name="TiempoEspera"></param>
        /// <returns></returns>
        public System.Data.DataTable EjecutarSentencia(string Sentencia, bool DesconexionAutomatica, int TiempoEspera)
        {
            return EjecutarTSQL(Sentencia, DesconexionAutomatica, TiempoEspera);
        }
        public System.Data.DataTable EjecutarSentencia(string Sentencia, bool DesconexionAutomatica, int TiempoEspera, bool NonQuery)
        {
            return EjecutarTSQL(Sentencia, DesconexionAutomatica, TiempoEspera, NonQuery);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Procedimiento"></param>
        /// <param name="Parametros"></param>
        /// <returns></returns>
        public System.Data.DataTable EjecutarProcedimiento(string Procedimiento, System.Data.SqlClient.SqlParameterCollection Parametros, out System.Collections.Hashtable ParametroSalida, int TiempoEspera)
        {
            System.Data.DataSet Resultado = EjecutarProcedimientoSQL(Procedimiento, Parametros, true, out ParametroSalida, TiempoEspera);
            if (Resultado != null)
            {
                return Resultado.Tables[0];
            }
            else
            {
                return null;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="Procedimiento"></param>
        /// <param name="Parametros"></param>
        /// <returns></returns>
        public System.Data.DataTable EjecutarProcedimiento(string Procedimiento, System.Data.SqlClient.SqlParameterCollection Parametros)
        {
            System.Collections.Hashtable ParametroSalida = null;
            System.Data.DataSet Resultado = EjecutarProcedimientoSQL(Procedimiento, Parametros, true, out ParametroSalida, 60);
            if (Resultado != null)
            {
                return Resultado.Tables[0];
            }
            else
            {
                return null;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="Procedimiento"></param>
        /// <param name="Parametros"></param>
        /// <returns></returns>
        public System.Data.DataSet EjecutarProcedimientoDS(string Procedimiento, System.Data.SqlClient.SqlParameterCollection Parametros, out System.Collections.Hashtable ParametroSalida, int TiempoEspera)
        {
            return EjecutarProcedimientoSQL(Procedimiento, Parametros, true, out ParametroSalida, TiempoEspera);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="Procedimiento"></param>
        /// <param name="Parametros"></param>
        /// <param name="DesconexionAutomatica"></param>
        /// <returns></returns>
        public System.Data.DataTable EjecutarProcedimiento(string Procedimiento, System.Data.SqlClient.SqlParameterCollection Parametros, bool DesconexionAutomatica, out System.Collections.Hashtable ParametroSalida, int TiempoEspera)
        {
            System.Data.DataSet Resultado = EjecutarProcedimientoSQL(Procedimiento, Parametros, DesconexionAutomatica, out ParametroSalida, TiempoEspera);
            if (Resultado != null)
            {
                if (Resultado.Tables.Count > 0)
                    return Resultado.Tables[0];
                else
                    return null;
            }
            else
            {
                return null;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="Procedimiento"></param>
        /// <param name="Parametros"></param>
        /// <param name="DesconexionAutomatica"></param>
        /// <returns></returns>
        public System.Data.DataSet EjecutarProcedimientoDS(string Procedimiento, System.Data.SqlClient.SqlParameterCollection Parametros, bool DesconexionAutomatica, out System.Collections.Hashtable ParametroSalida)
        {
            return EjecutarProcedimientoSQL(Procedimiento, Parametros, DesconexionAutomatica, out ParametroSalida, 60);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public bool Desconectar()
        {
            return DesconectarSQL();
        }

        public void AbrirTransaccion()
        {
            TransaccionSQLGlobal = ConexionSQLGlobal.BeginTransaction();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="Operacion"></param>
        /// <returns></returns>
        public bool CerrarTransaccion(Transacciones Operacion)
        {
            //Verifica que si exista una transacción.
            if (TransaccionSQLGlobal != null)
            {
                //Verifica que tipo de accion debe realizar sobre la transacción.
                switch (Operacion)
                {
                    case Transacciones.Transacciones_Commit:
                        {
                            TransaccionSQLGlobal.Commit();
                            break;
                        }
                    case Transacciones.Transacciones_Rollback:
                        {
                            TransaccionSQLGlobal.Rollback();
                            break;
                        }
                }
            }
            else
            {
                Sinapsys.Datos.SQLException SQLExc = new SQLException("Debe existir una transacción abierta para poder cerrarla.");
                throw (SQLExc);
            }

            return true;
        }
        #endregion

        #region Métodos privados.
        /// <summary>
        /// 
        /// </summary>
        /// <param name="Procedimiento"></param>
        /// <param name="Parametros"></param>
        /// <param name="DesconectarAutomatico"></param>
        /// <returns></returns>
        private System.Data.DataSet EjecutarProcedimientoSQL(string Procedimiento, System.Data.SqlClient.SqlParameterCollection Parametros, bool DesconectarAutomatico, out System.Collections.Hashtable ParametrosSalida, int TiempoEspera)
        {
            bool esPrueba = (ConexionSQLGlobal.ConnectionString.ToUpper().Contains("PRUEBA"));
            bool actualiza = (Procedimiento.ToUpper().Contains("UPDATE"));
            if (!esPrueba || !actualiza)
            {
                if (ConexionSQLGlobal.State == System.Data.ConnectionState.Open)
                {
                    try
                    {

                        System.Collections.ArrayList ParametroSalidaTmp = null;
                        System.Collections.Hashtable ParametrosSalidaTmp = new Hashtable();
                        System.Data.SqlClient.SqlCommand Comando = new SqlCommand(Procedimiento, ConexionSQLGlobal);
                        Comando.CommandTimeout = TiempoEspera;
                        Comando.CommandType = System.Data.CommandType.StoredProcedure;
                        if (TransaccionSQLGlobal != null)
                        {
                            Comando.Transaction = TransaccionSQLGlobal;
                        }

                        string SentenciaTmp = "EXEC " + Procedimiento + " ";

                        if (Parametros != null)
                        {
                            string car = "";
                            for (int i = Parametros.Count - 1; i >= 0; i--)
                            {
                                System.Data.SqlClient.SqlParameter Parametro = Parametros[i];

                                switch (Parametro.SqlDbType)
                                {
                                    case SqlDbType.Date:
                                    case SqlDbType.Char:
                                    case SqlDbType.DateTime:
                                    case SqlDbType.DateTime2:
                                    case SqlDbType.NChar:
                                    case SqlDbType.NText:
                                    case SqlDbType.NVarChar:
                                    case SqlDbType.Text:
                                    case SqlDbType.Time:
                                    case SqlDbType.VarChar:
                                    case SqlDbType.Xml:
                                        car = "'";
                                        break;
                                    default:
                                        car = "";
                                        break;
                                }
                                string valor = Parametro.SqlValue == null ? "" : Parametro.SqlValue.ToString().Replace("'", "''");
                                SentenciaTmp += Parametro.ParameterName + "=" + car + valor + car + (i > 0 ? "," : "");
                            }
                            ParametroSalidaTmp = AdicionarParametros(ref Comando, Parametros);
                        }
                        EscribirLog("\t " + (Procedimiento.IndexOf("Metal") > -1 ? "Metal" : "Metal LTDA") + "\t" + SentenciaTmp);

                        System.Data.SqlClient.SqlDataAdapter Adaptador = new SqlDataAdapter(Comando);
                        System.Data.DataSet Resultado = new DataSet();
                        Adaptador.Fill(Resultado, System.DateTime.Now.ToString(System.Globalization.DateTimeFormatInfo.InvariantInfo));
                        if (DesconectarAutomatico)
                        {
                            DesconectarSQL();
                        }

                        if (ParametroSalidaTmp != null)
                        {
                            if (ParametroSalidaTmp.Count != 0)
                            {
                                foreach (string ParametroSalida in ParametroSalidaTmp)
                                {
                                    ParametrosSalidaTmp.Add(ParametroSalida, Comando.Parameters[ParametroSalida].Value);
                                }
                            }
                        }

                        ParametrosSalida = ParametrosSalidaTmp;

                        if (Resultado.Tables.Count != 0)
                        {
                            return Resultado;
                        }
                        else
                        {
                            return null;
                        }

                    }

                    catch (System.Exception Exc)
                    {
                        if (!esPrueba)
                        {
                            throw new SQLException("No fue posible ejecutar el procedimiento [" + Procedimiento + "].", Exc);
                        }
                        else
                        {
                            ParametrosSalida = new Hashtable();
                            return null;
                        }

                    }

                }
                else
                {
                    throw new SQLException("Debe conectarse a la base de datos previamente.");
                }
            }
            else
            {
                System.Data.DataSet Resultado = new DataSet();
                ParametrosSalida = new Hashtable();
                return Resultado;
            }

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Comando"></param>
        /// <param name="Parametros"></param>
        private System.Collections.ArrayList AdicionarParametros(ref System.Data.SqlClient.SqlCommand Comando, System.Data.SqlClient.SqlParameterCollection Parametros)
        {
            System.Collections.ArrayList Resultado = new ArrayList();
            for (int i = Parametros.Count - 1; i >= 0; i--)
            {
                System.Data.SqlClient.SqlParameter Parametro = Parametros[i];
                Parametros.Remove(Parametro);
                Comando.Parameters.Add(Parametro);

                if (Parametro.Direction == System.Data.ParameterDirection.Output || Parametro.Direction == System.Data.ParameterDirection.InputOutput)
                {
                    Resultado.Add(Parametro.ParameterName);
                }
            }

            return Resultado;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Sentencia"></param>
        /// <param name="DesconectarAutomatico"></param>
        /// <returns></returns>
        private System.Data.DataTable EjecutarTSQL(string Sentencia, bool DesconectarAutomatico, int TiempoEspera)
        {
            string SentenciaTmp = Sentencia.ToLower();
            int ContieneSelect = SentenciaTmp.IndexOf("select");
            if (Sentencia.ToLower().IndexOf("update") >= 0)
            {
                ContieneSelect = -1;
            }

            int ContieneAlter = SentenciaTmp.IndexOf("alter");
            EscribirLog(" \t" + (SentenciaTmp.IndexOf("CIFIN") > -1 ? "CIFIN" : "SISTECREDITO") + "\t" + SentenciaTmp);
            if (ConexionSQLGlobal.State == System.Data.ConnectionState.Open)
            {
                System.Data.SqlClient.SqlCommand Comando = new SqlCommand(Sentencia, ConexionSQLGlobal);
                Comando.CommandTimeout = TiempoEspera;
                Comando.CommandType = System.Data.CommandType.Text;
                if (TransaccionSQLGlobal != null)
                {
                    Comando.Transaction = TransaccionSQLGlobal;
                }

                //Verifica si es un select.
                if (ContieneSelect != -1 && ContieneAlter == -1)
                {
                    System.Data.SqlClient.SqlDataAdapter Adaptador = new SqlDataAdapter(Comando);
                    System.Data.DataSet Resultado = new DataSet();
                    int Registros = Adaptador.Fill(Resultado);

                    if (DesconectarAutomatico)
                    {
                        DesconectarSQL();
                    }

                    System.Random Aleatorio = new System.Random();
                    Resultado.Tables[0].TableName = Aleatorio.Next(1, 10000000).ToString();

                    return Resultado.Tables[0];
                }
                else
                {
                    int Registros = 1;
                    //Si es testing ignora el compando)
                    if (!ConexionSQLGlobal.ConnectionString.ToUpper().Contains("PRUEBA"))
                    {
                        Registros = Comando.ExecuteNonQuery();
                    }
                    System.Data.DataTable Resultado = new DataTable();
                    Resultado.Columns.Add("Registros");
                    Resultado.Rows.Add(new object[] { Registros });
                    if (DesconectarAutomatico)
                    {
                        DesconectarSQL();
                    }

                    return Resultado;
                }
            }
            else
            {
                throw new SQLException("Debe conectarse a la base de datos previamente.");
            }
        }
        private System.Data.DataTable EjecutarTSQL(string Sentencia, bool DesconectarAutomatico, int TiempoEspera, bool NonQuery)
        {
            string SentenciaTmp = Sentencia.ToLower();
            int ContieneSelect = SentenciaTmp.ToLower().IndexOf("select");
            if (Sentencia.ToLower().IndexOf("update") >= 0)
            {
                ContieneSelect = -1;
            }
            EscribirLog(" \t" + (SentenciaTmp.IndexOf("CIFIN") > -1 ? "CIFIN" : "SISTECREDITO") + "\t" + SentenciaTmp);


            if (ConexionSQLGlobal.State == System.Data.ConnectionState.Open)
            {
                System.Data.SqlClient.SqlCommand Comando = new SqlCommand(Sentencia, ConexionSQLGlobal);
                Comando.CommandTimeout = TiempoEspera;
                Comando.CommandType = System.Data.CommandType.Text;

                if (TransaccionSQLGlobal != null)
                {
                    Comando.Transaction = TransaccionSQLGlobal;
                }

                //Verifica si es un select.
                if (!NonQuery)
                {
                    System.Data.SqlClient.SqlDataAdapter Adaptador = new SqlDataAdapter(Comando);
                    System.Data.DataSet Resultado = new DataSet();
                    int Registros = Adaptador.Fill(Resultado);

                    if (DesconectarAutomatico)
                    {
                        DesconectarSQL();
                    }

                    System.Random Aleatorio = new System.Random();
                    Resultado.Tables[0].TableName = Aleatorio.Next(1, 10000000).ToString();

                    return Resultado.Tables[0];
                }
                else
                {
                    int Registros = 1;
                    //Si es testing ignora el compando)
                    if (!ConexionSQLGlobal.ConnectionString.ToUpper().Contains("PRUEBA"))
                    {
                        Registros = Comando.ExecuteNonQuery();
                    }

                    System.Data.DataTable Resultado = new DataTable();
                    Resultado.Columns.Add("Registros");
                    Resultado.Rows.Add(new object[] { Registros });

                    if (DesconectarAutomatico)
                    {
                        DesconectarSQL();
                    }

                    return Resultado;
                }
            }
            else
            {
                throw new SQLException("Debe conectarse a la base de datos previamente.");
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="CadenaConexion"></param>
        /// <returns></returns>
        private bool ConectarSQL(string CadenaConexion, bool Transaccional)
        {
            try
            {
                //Elimina el parametro provider de la cadena de conexion.
                string CadenaConexionTmp = "";
                string[] CadenaConexionSplit = CadenaConexion.Split(';');
                foreach (string Parametro in CadenaConexionSplit)
                {
                    int Posicion = Parametro.IndexOf("Provider");
                    if (Posicion == -1)
                    {
                        CadenaConexionTmp = CadenaConexionTmp + ";" + Parametro;
                    }
                }

                CadenaConexionTmp = CadenaConexionTmp.Substring(1, CadenaConexionTmp.Length - 1);

                //Realiza la conexion con la bd.
                ConexionSQLGlobal = new SqlConnection();
                ConexionSQLGlobal.ConnectionString = CadenaConexionTmp;
                ConexionSQLGlobal.Open();

                if (Transaccional)
                {
                    TransaccionSQLGlobal = ConexionSQLGlobal.BeginTransaction();
                }

                return true;
            }
            catch (System.Exception Exc)
            {
                throw new SQLException("No fue posible conectarse a la base de datos.", Exc);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private bool DesconectarSQL()
        {
            try
            {
                if (ConexionSQLGlobal.State == System.Data.ConnectionState.Open)
                {
                    ConexionSQLGlobal.Close();
                    ConexionSQLGlobal.Dispose();

                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (System.Exception Exc)
            {
                throw new SQLException("No fue posible desconectarse de la base de datos.", Exc);
            }
        }

        public void EscribirLog(string Mensaje)
        {
            try
            {
                if (generarLog)
                {
                    string path = @"C:\Sistecredito\InstruccionesCredinet.txt";
                    System.IO.StreamWriter LogErrores = new System.IO.StreamWriter(path, true);
                    LogErrores.WriteLine(Mensaje);
                    LogErrores.Flush();
                    LogErrores.Close();
                }
            }
            catch
            {

            }
        }

        #endregion

        #region Atributos solo lectura.
        /// <summary>
        /// 
        /// </summary>
        public System.Data.SqlClient.SqlConnection Conexion
        {
            get { return ConexionSQLGlobal; }
        }
        #endregion

        #region IDisposable Members
        public void Dispose()
        {
            if (ConexionSQLGlobal != null)
            {
                ConexionSQLGlobal.Dispose();
                ConexionSQLGlobal = null;
            }

            if (TransaccionSQLGlobal != null)
            {
                TransaccionSQLGlobal.Dispose();
                TransaccionSQLGlobal = null;
            }

            GC.SuppressFinalize(this);
            GC.Collect();
        }

        #endregion
    }
}
