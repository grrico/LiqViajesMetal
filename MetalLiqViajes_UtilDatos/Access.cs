using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using System.Collections;
using System.Data;
using System.Data.OleDb;

namespace Sinapsys.Datos
{
    public sealed class Access
	{
		#region Declaración de enumerados.
		public enum Transacciones
		{
			Transacciones_Commit,
			Transacciones_Rollback			
		}
		#endregion

		#region Declaración de variables privadas.
		private System.Data.OleDb.OleDbConnection ConexionSQLGlobal;
		private System.Data.OleDb.OleDbTransaction TransaccionSQLGlobal=null;		
		#endregion		

		#region Constructores.
		/// <summary>
		/// 
		/// </summary>
		public Access()
		{

		}
		public Access(string Alias,bool Transaccional)
		{
			Conectar(Alias,Transaccional);
		}
		#endregion

		#region Métodos públicos.		
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

			return ConectarAccess(CadenaConexionTmp,Transaccional);			
		}

        /// <summary>
        /// 
        /// </summary>
        /// <param name="CadenaConexion"></param>
        /// <param name="Transaccional"></param>
        /// <returns></returns>
        public bool Conectar(string CadenaConexion)
        {
            return ConectarAccess(CadenaConexion, false);
        }

		/// <summary>
		/// 
		/// </summary>
		/// <param name="Sentencia"></param>
		/// <returns></returns>
		public System.Data.DataTable EjecutarSentencia(string Sentencia)
		{
			return EjecutarTSQL(Sentencia,true);
		}

        /// <summary>
		/// 
		/// </summary>
		/// <param name="Sentencia"></param>
		/// <param name="DesconexionAutomatica"></param>
		/// <returns></returns>
		public System.Data.DataTable EjecutarSentencia(string Sentencia,bool DesconexionAutomatica)
		{
			return EjecutarTSQL(Sentencia,DesconexionAutomatica);
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="Procedimiento"></param>
		/// <param name="Parametros"></param>
		/// <returns></returns>
		public System.Data.DataTable EjecutarProcedimiento(string Procedimiento,System.Data.OleDb.OleDbParameterCollection Parametros,out System.Collections.Hashtable ParametroSalida,int TiempoEspera)
		{
			System.Data.DataSet Resultado=EjecutarProcedimientoSQL(Procedimiento,Parametros,true,out ParametroSalida,TiempoEspera);
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
		public System.Data.DataTable EjecutarProcedimiento(string Procedimiento,System.Data.OleDb.OleDbParameterCollection Parametros)
		{
			System.Collections.Hashtable ParametroSalida=null;
			System.Data.DataSet Resultado=EjecutarProcedimientoSQL(Procedimiento,Parametros,true,out ParametroSalida,60);
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
		public System.Data.DataSet EjecutarProcedimientoDS(string Procedimiento,System.Data.OleDb.OleDbParameterCollection Parametros,out System.Collections.Hashtable ParametroSalida,int TiempoEspera)
		{
			return EjecutarProcedimientoSQL(Procedimiento,Parametros,true,out ParametroSalida,TiempoEspera);
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="Procedimiento"></param>
		/// <param name="Parametros"></param>
		/// <param name="DesconexionAutomatica"></param>
		/// <returns></returns>
		public System.Data.DataTable EjecutarProcedimiento(string Procedimiento,System.Data.OleDb.OleDbParameterCollection Parametros,bool DesconexionAutomatica,out System.Collections.Hashtable ParametroSalida,int TiempoEspera)
		{			
			System.Data.DataSet Resultado=EjecutarProcedimientoSQL(Procedimiento,Parametros,DesconexionAutomatica,out ParametroSalida,TiempoEspera);
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
		public System.Data.DataSet EjecutarProcedimientoDS(string Procedimiento,System.Data.OleDb.OleDbParameterCollection Parametros,bool DesconexionAutomatica,out System.Collections.Hashtable ParametroSalida)
		{
			return EjecutarProcedimientoSQL(Procedimiento,Parametros,DesconexionAutomatica,out ParametroSalida,60);
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
			if(TransaccionSQLGlobal!=null)
			{				
				//Verifica que tipo de accion debe realizar sobre la transacción.
				switch(Operacion)
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
		private System.Data.DataSet EjecutarProcedimientoSQL(string Procedimiento,System.Data.OleDb.OleDbParameterCollection Parametros,bool DesconectarAutomatico,out System.Collections.Hashtable ParametrosSalida,int TiempoEspera)
		{
			if(ConexionSQLGlobal.State==System.Data.ConnectionState.Open)
			{
				try
				{
					System.Collections.ArrayList ParametroSalidaTmp=null;
					System.Collections.Hashtable ParametrosSalidaTmp=new Hashtable();
					System.Data.OleDb.OleDbCommand Comando=new OleDbCommand(Procedimiento,ConexionSQLGlobal);
					Comando.CommandTimeout=TiempoEspera;
					Comando.CommandType=System.Data.CommandType.StoredProcedure;
					if(TransaccionSQLGlobal!=null)
					{
						Comando.Transaction=TransaccionSQLGlobal;
					}
					
					if(Parametros!=null)
					{
						ParametroSalidaTmp=AdicionarParametros(ref Comando,Parametros);	
					}
									
					System.Data.OleDb.OleDbDataAdapter Adaptador=new OleDbDataAdapter(Comando);
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
		private System.Collections.ArrayList AdicionarParametros(ref System.Data.OleDb.OleDbCommand Comando,System.Data.OleDb.OleDbParameterCollection Parametros)
		{
			System.Collections.ArrayList Resultado=new ArrayList();
			for(int i=Parametros.Count-1;i>=0;i--)
			{
				System.Data.OleDb.OleDbParameter Parametro=Parametros[i];
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
		private System.Data.DataTable EjecutarTSQL(string Sentencia,bool DesconectarAutomatico)
		{
			string SentenciaTmp=Sentencia.ToLower();
            int ContieneSelect = SentenciaTmp.IndexOf("select");

			if(ConexionSQLGlobal.State==System.Data.ConnectionState.Open)
			{
				System.Data.OleDb.OleDbCommand Comando=new OleDbCommand(Sentencia,ConexionSQLGlobal);
				Comando.CommandType=System.Data.CommandType.Text;

				//Verifica si es un select.
				if(ContieneSelect!=-1)
				{					
					System.Data.OleDb.OleDbDataAdapter Adaptador=new OleDbDataAdapter(Comando);
					System.Data.DataSet Resultado=new DataSet();

                    int Registros = Adaptador.Fill(Resultado);

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
		private bool ConectarAccess(string CadenaConexion,bool Transaccional)
		{
			try
			{	
				//Realiza la conexion con la bd.
				ConexionSQLGlobal=new OleDbConnection();
				ConexionSQLGlobal.ConnectionString=CadenaConexion;                
				ConexionSQLGlobal.Open();

				if(Transaccional)
				{					
					TransaccionSQLGlobal=ConexionSQLGlobal.BeginTransaction();
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
				if(ConexionSQLGlobal.State==System.Data.ConnectionState.Open)
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
			catch(System.Exception Exc)
			{
				throw new SQLException("No fue posible desconectarse de la base de datos.",Exc);
			}			
		}

		#endregion
	}
}
