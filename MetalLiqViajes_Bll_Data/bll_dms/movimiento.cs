using System;
using System.Data;
using System.Data.Common;
using System.Xml;
using System.Xml.Serialization;
using System.Xml.Schema;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.IO;
using Sinapsys.Datos;
using Microsoft.Practices.EnterpriseLibrary.Security.Cryptography;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Runtime.Serialization;

namespace LiqViajes_Bll_Data
{

	public partial class movimientosController//: ILatinodeController
	{
		public movimientosController()
		{
		}

		private static movimientosController MySingleObj;

        public static movimientosController Instance
		{
			get
			{
				if (MySingleObj == null)
				{
					MySingleObj = new movimientosController();
				}
				return MySingleObj;
			}
		}

        private void ReadData(movimientos movimiento, DataRow dr,bool generateUndo=false)
		{
			try 
			{
				movimiento.cuenta = (string) dr["cuenta"];
				movimiento.centro = (int) dr["centro"];
				movimiento.nit = (decimal) dr["nit"];
				movimiento.fec = (DateTime) dr["fec"];
				movimiento.valor = (decimal) dr["valor"];				
				movimiento.documento = dr.IsNull("documento") ? null :(int?) dr["documento"];
				movimiento.explicacion = dr.IsNull("explicacion") ? null :(string) dr["explicacion"];
				movimiento.concilio = dr.IsNull("concilio") ? null :(string) dr["concilio"];
				movimiento.concepto_mov = dr.IsNull("concepto_mov") ? null :(short?)Convert.ToInt16(dr["concepto_mov"]);
				movimiento.concilio_ano = dr.IsNull("concilio_ano") ? null :(short?)Convert.ToInt16(dr["concilio_ano"]);
				movimiento.secuencia_extracto = dr.IsNull("secuencia_extracto") ? null :(int?) dr["secuencia_extracto"];
				movimiento.ano_concilia = dr.IsNull("ano_concilia") ? null :(int?) dr["ano_concilia"];
				movimiento.mes_concilia = dr.IsNull("mes_concilia") ? null :(int?) dr["mes_concilia"];
				movimiento.TIPO_CRUCE = dr.IsNull("TIPO_CRUCE") ? null :(string) dr["TIPO_CRUCE"];
				movimiento.valor_niif = (decimal) dr["valor_niif"];
				movimiento.tipo = (string) dr["tipo"];
				movimiento.numero = (int) dr["numero"];
				movimiento.seq = (int) dr["seq"];
			}
			catch (Exception ex)
			{
				Utilidades.LogErrores(ex.Message + (ex.InnerException != null ? ex.InnerException.Message : ""), DataProvider.AplicacionNombre);
				throw ex;
			}
			if (generateUndo) movimiento.GenerateUndo();
		}

		public movimientos Get(string tipo, int numero, int seq, bool generateUndo=false)
		{
			try 
			{
				movimientos movimiento = null;
				DataTable dt = movimientosDataProvider.Instance.Get(tipo, numero, seq);
				if ((dt.Rows.Count > 0))
				{
					movimiento = new movimientos();
					DataRow dr = dt.Rows[0];
					ReadData(movimiento, dr, generateUndo);
				}


				return movimiento;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		public movimientosList GetAll(bool generateUndo=false)
		{
			try 
			{
				movimientosList movimientolist = new movimientosList();
				DataTable dt = movimientosDataProvider.Instance.GetAll();
				foreach (DataRow dr in dt.Rows)
				{
					movimientos movimiento = new movimientos();
					ReadData(movimiento, dr, generateUndo);
					movimientolist.Add(movimiento);
				}
				return movimientolist;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

        public movimientosList GetByTipoNumero(string tipo, int numero, bool generateUndo = false)
        {
            try
            {
                movimientosList movimientolist = new movimientosList();
                DataTable dt = movimientosDataProvider.Instance.GetByTipoNumero(tipo, numero);
                foreach (DataRow dr in dt.Rows)
                {
                    movimientos movimiento = new movimientos();
                    ReadData(movimiento, dr, generateUndo);
                    movimientolist.Add(movimiento);
                }
                return movimientolist;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
