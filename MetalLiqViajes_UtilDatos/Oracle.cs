using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using System.Collections;
using System.Data;
using System.Data.OracleClient;

namespace Sinapsys.Datos
{
    /// <summary>
    /// 
    /// </summary>
    public class Oracle : IDisposable
    {
		#region Declaración de enumerados.
		public enum Transacciones
		{
			Transacciones_Commit,
			Transacciones_Rollback			
		}
		#endregion

		#region Declaración de variables privadas.
		private System.Data.OracleClient.OracleConnection ConexionGlobal;
		private System.Data.OracleClient.OracleTransaction TransaccionGlobal=null;		
		#endregion		

		#region Constructores.
		/// <summary>
		/// 
		/// </summary>
		public Oracle()
		{

		}
		/// <summary>
		/// 
		/// </summary>
		/// <param name="Servidor"></param>
		/// <param name="Usuario"></param>
		/// <param name="Contraseña"></param>
		/// <param name="Basedatos"></param>
		public Oracle(string Servidor,string Usuario,string Contraseña,string Basedatos,bool Transaccional)
		{
			Conectar(Servidor,Usuario,Contraseña,Basedatos,Transaccional);
		}
		/// <summary>
		/// 
		/// </summary>
		/// <param name="Servidor"></param>
		/// <param name="BaseDatos"></param>
		public Oracle(string Servidor,string BaseDatos,bool Transaccional)
		{
			Conectar(Servidor,BaseDatos,Transaccional);
		}
		/// <summary>
		/// 
		/// </summary>
		/// <param name="Alias"></param>
        public Oracle(string Alias, bool Transaccional)
		{
			Conectar(Alias,Transaccional);
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
		public bool Conectar(string Servidor,string Usuario,string Contraseña,string BaseDatos,bool Transaccional)
		{
			string CadenaConexion="Persist Security Info=False;User ID="+Usuario+";Password="+Contraseña+";Initial Catalog="+BaseDatos+";Data Source="+Servidor;
			return ConectarSQL(CadenaConexion,Transaccional);
		}
		/// <summary>
		/// 
		/// </summary>
		/// <param name="Servidor"></param>
		/// <param name="BaseDatos"></param>
		/// <param name="Transaccional"></param>
		/// <returns></returns>
		public bool Conectar(string Servidor,string BaseDatos,bool Transaccional)
		{
			string CadenaConexion="Integrated Security=SSPI;Persist Security Info=False;Initial Catalog="+BaseDatos+";Data Source="+Servidor;
			return ConectarSQL(CadenaConexion,Transaccional);
		}
		/// <summary>
		/// 
		/// </summary>
		/// <param name="Alias"></param>
		/// <param name="Transaccional"></param>
		/// <returns></returns>
		public bool Conectar(string Alias,bool Transaccional)
		{
			string ArchivoConfiguracion=System.Environment.SystemDirectory+@"\UtilSQL.Config";

			//Analiza el archivo xml buscando resolver el alias dado.
			System.Xml.XmlDocument Configuracion=new XmlDocument();
			Configuracion.Load(ArchivoConfiguracion);
			System.Xml.XmlNode AliasTmp=Configuracion.SelectSingleNode("configuracion/alias[@nombre='"+Alias+"']");
			string CadenaConexionTmp=AliasTmp.Attributes.GetNamedItem("cadenaconexion").Value;            

			return ConectarSQL(CadenaConexionTmp,Transaccional);			
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
		/// <param name="Sentencia"></param>
		/// <returns></returns>
		public System.Data.DataTable EjecutarSentencia(string Sentencia)
		{
			return EjecutarTSQL(Sentencia,true,3000);
		}
		/// <summary>
		/// 
		/// </summary>
		/// <param name="Sentencia"></param>
		/// <param name="DesconexionAutomatica"></param>
		/// <returns></returns>
		public System.Data.DataTable EjecutarSentencia(string Sentencia,bool DesconexionAutomatica)
		{
			return EjecutarTSQL(Sentencia,DesconexionAutomatica,3000);
		}
        /// <summary>
        /// 
        /// </summary>
        /// <param name="Sentencia"></param>
        /// <param name="DesconexionAutomatica"></param>
        /// <param name="TiempoEspera"></param>
        /// <returns></returns>
        public System.Data.DataTable EjecutarSentencia(string Sentencia, bool DesconexionAutomatica,int TiempoEspera)
        {
            return EjecutarTSQL(Sentencia, DesconexionAutomatica,TiempoEspera);
        }
		/// <summary>
		/// 
		/// </summary>
		/// <param name="Procedimiento"></param>
		/// <param name="Parametros"></param>
		/// <returns></returns>
        public System.Data.DataTable EjecutarProcedimiento(string Procedimiento, System.Data.OracleClient.OracleParameterCollection Parametros, out System.Collections.Hashtable ParametroSalida, int TiempoEspera)
		{
			System.Data.DataSet Resultado=EjecutarProcedimientoOracle(Procedimiento,Parametros,true,out ParametroSalida,TiempoEspera);
			if(Resultado!=null)
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
		public System.Data.DataTable EjecutarProcedimiento(string Procedimiento,System.Data.OracleClient.OracleParameterCollection Parametros)
		{
			System.Collections.Hashtable ParametroSalida=null;
			System.Data.DataSet Resultado=EjecutarProcedimientoOracle(Procedimiento,Parametros,true,out ParametroSalida,60);
			if(Resultado!=null)
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
        public System.Data.DataSet EjecutarProcedimientoDS(string Procedimiento, System.Data.OracleClient.OracleParameterCollection Parametros, out System.Collections.Hashtable ParametroSalida, int TiempoEspera)
		{
			return EjecutarProcedimientoOracle(Procedimiento,Parametros,true,out ParametroSalida,TiempoEspera);
		}
		/// <summary>
		/// 
		/// </summary>
		/// <param name="Procedimiento"></param>
		/// <param name="Parametros"></param>
		/// <param name="DesconexionAutomatica"></param>
		/// <returns></returns>
        public System.Data.DataTable EjecutarProcedimiento(string Procedimiento, System.Data.OracleClient.OracleParameterCollection Parametros, bool DesconexionAutomatica, out System.Collections.Hashtable ParametroSalida, int TiempoEspera)
		{			
			System.Data.DataSet Resultado=EjecutarProcedimientoOracle(Procedimiento,Parametros,DesconexionAutomatica,out ParametroSalida,TiempoEspera);
			if(Resultado!=null)
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
		/// <param name="DesconexionAutomatica"></param>
		/// <returns></returns>
        public System.Data.DataSet EjecutarProcedimientoDS(string Procedimiento, System.Data.OracleClient.OracleParameterCollection Parametros, bool DesconexionAutomatica, out System.Collections.Hashtable ParametroSalida)
		{
			return EjecutarProcedimientoOracle(Procedimiento,Parametros,DesconexionAutomatica,out ParametroSalida,60);
		} 
		/// <summary>
		/// 
		/// </summary>
		/// <returns></returns>
		public bool Desconectar()
		{
			return DesconectarSQL();
		}
		/// <summary>
		/// 
		/// </summary>
		/// <param name="Operacion"></param>
		/// <returns></returns>
		public bool CerrarTransaccion(Transacciones Operacion)
		{
			//Verifica que si exista una transacción.
			if(TransaccionGlobal!=null)
			{				
				//Verifica que tipo de accion debe realizar sobre la transacción.
				switch(Operacion)
				{
					case Transacciones.Transacciones_Commit:
					{
                        TransaccionGlobal.Commit();
						break;
					}
					case Transacciones.Transacciones_Rollback:
					{
                        TransaccionGlobal.Rollback();
						break;
					}
				}
			}
			else
			{
				Sinapsys.Datos.SQLException SQLExc=new SQLException("Debe existir una transacción abierta para poder cerrarla.");
				throw(SQLExc);
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
		private System.Data.DataSet EjecutarProcedimientoOracle(string Procedimiento,System.Data.OracleClient.OracleParameterCollection Parametros,bool DesconectarAutomatico,out System.Collections.Hashtable ParametrosSalida,int TiempoEspera)
		{
			if(ConexionGlobal.State==System.Data.ConnectionState.Open)
			{
				try
				{
					System.Collections.ArrayList ParametroSalidaTmp=null;
					System.Collections.Hashtable ParametrosSalidaTmp=new Hashtable();
                    System.Data.OracleClient.OracleCommand Comando = new OracleCommand(Procedimiento, ConexionGlobal);
					Comando.CommandTimeout=TiempoEspera;
					Comando.CommandType=System.Data.CommandType.StoredProcedure;
                    if (TransaccionGlobal != null)
					{
                        Comando.Transaction = TransaccionGlobal;
					}
					
					if(Parametros!=null)
					{
						ParametroSalidaTmp=AdicionarParametros(ref Comando,Parametros);	
					}
									
					System.Data.OracleClient.OracleDataAdapter Adaptador=new OracleDataAdapter(Comando);
					System.Data.DataSet Resultado=new DataSet();					
					Adaptador.Fill(Resultado,System.DateTime.Now.ToString(System.Globalization.DateTimeFormatInfo.InvariantInfo));

					if(DesconectarAutomatico)
					{
						DesconectarSQL();	
					}	
				
					if(ParametroSalidaTmp!=null)
					{
						if(ParametroSalidaTmp.Count!=0)
						{
							foreach(string ParametroSalida in ParametroSalidaTmp)
							{							
								ParametrosSalidaTmp.Add(ParametroSalida,Comando.Parameters[ParametroSalida].Value);
							}						
						}
					}

					ParametrosSalida=ParametrosSalidaTmp;

					if(Resultado.Tables.Count!=0)
					{
						return Resultado;
					}
					else
					{
						return null;
					}
					
				}
				catch(System.Exception Exc)
				{
					throw new SQLException("No fue posible ejecutar el procedimiento ["+Procedimiento+"].",Exc);
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
		/// <param name="Comando"></param>
		/// <param name="Parametros"></param>
		private System.Collections.ArrayList AdicionarParametros(ref System.Data.OracleClient.OracleCommand Comando,System.Data.OracleClient.OracleParameterCollection Parametros)
		{
			System.Collections.ArrayList Resultado=new ArrayList();
			for(int i=Parametros.Count-1;i>=0;i--)
			{
				System.Data.OracleClient.OracleParameter Parametro=Parametros[i];
				Parametros.Remove(Parametro);
				Comando.Parameters.Add(Parametro);

				if(Parametro.Direction==System.Data.ParameterDirection.Output || Parametro.Direction==System.Data.ParameterDirection.InputOutput)
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
		private System.Data.DataTable EjecutarTSQL(string Sentencia,bool DesconectarAutomatico,int TiempoEspera)
		{
			string SentenciaTmp=Sentencia.ToLower();
            int ContieneSelect = SentenciaTmp.IndexOf("select");

			if(ConexionGlobal.State==System.Data.ConnectionState.Open)
			{
				System.Data.OracleClient.OracleCommand Comando=new OracleCommand(Sentencia,ConexionGlobal);                
                Comando.CommandTimeout = TiempoEspera;
				Comando.CommandType=System.Data.CommandType.Text;

				//Verifica si es un select.
				if(ContieneSelect!=-1)
				{					
					System.Data.OracleClient.OracleDataAdapter Adaptador=new OracleDataAdapter(Comando);                    
					System.Data.DataSet Resultado=new DataSet();					
					int Registros=Adaptador.Fill(Resultado);

					if(DesconectarAutomatico)
					{
						DesconectarSQL();	
					}					

					return Resultado.Tables[0];
				}
				else
				{
					int Registros=Comando.ExecuteNonQuery();

					System.Data.DataTable Resultado=new DataTable();
					Resultado.Columns.Add("Registros");
					Resultado.Rows.Add(new object[] {Registros});

					if(DesconectarAutomatico)
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
		private bool ConectarSQL(string CadenaConexion,bool Transaccional)
		{
			try
			{
				//Elimina el parametro provider de la cadena de conexion.
				string CadenaConexionTmp="";				
				string[] CadenaConexionSplit=CadenaConexion.Split(';');
				foreach(string Parametro in CadenaConexionSplit)
				{					
					int Posicion=Parametro.IndexOf("Provider");
					if(Posicion==-1)
					{
						CadenaConexionTmp=CadenaConexionTmp+";"+Parametro;
					}					
				}

				CadenaConexionTmp=CadenaConexionTmp.Substring(1,CadenaConexionTmp.Length-1);

				//Realiza la conexion con la bd.
				ConexionGlobal=new OracleConnection();
				ConexionGlobal.ConnectionString=CadenaConexionTmp;
				ConexionGlobal.Open();

				if(Transaccional)
				{					
					TransaccionGlobal=ConexionGlobal.BeginTransaction();
				}

				return true;
			}
			catch(System.Exception Exc)
			{
				throw new SQLException("No fue posible conectarse a la base de datos.",Exc);
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
				if(ConexionGlobal.State==System.Data.ConnectionState.Open)
				{
					ConexionGlobal.Close();
					ConexionGlobal.Dispose();

					return true;				
				}
				else
				{
					return false;
				}
			}
			catch(System.Exception Exc)
			{
				throw new SQLException("No fue posible desconectarse de la base de datos.",Exc);
			}			
		}

		#endregion

        #region IDisposable Members
        public void Dispose()
        {
            if (ConexionGlobal != null)
            {
                ConexionGlobal.Dispose();
                ConexionGlobal = null;
            }

            if (TransaccionGlobal != null)
            {
                TransaccionGlobal.Dispose();
                TransaccionGlobal = null;
            }		    	
        }

        #endregion
    }
}
