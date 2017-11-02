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
	

	public partial class LiquidacionVehiculoController
	{

        public List<RegistroViajeDTO> GetBy_RegistroViajesAnoDTO(int Ano, int Mes)
        {
            try
            {
                List<RegistroViajeDTO> registroviajelist = new List<RegistroViajeDTO>();
                RegistroViajeDTO iRegistroViajeDTO = null;
                DataTable dt = LiquidacionVehiculoDataProvider.Instance.GetBy_RegistroViajesDTO(Ano, Mes);
                foreach (DataRow dr in dt.Rows)
                {
                    iRegistroViajeDTO = new RegistroViajeDTO();
                    ReadDataRegistroViajeDTO(iRegistroViajeDTO, dr);
                    registroviajelist.Add(iRegistroViajeDTO);
                }
                return registroviajelist;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        private void ReadDataRegistroViajeDTO(RegistroViajeDTO iRegistroViajeDTO, DataRow dr)
        {
            try
            {
                iRegistroViajeDTO.IdRegistro = (Int32)dr["IdRegistro"];// (long)dr["IdRegistro"];
                iRegistroViajeDTO.FechaMovimiento = (DateTime)dr["FechaMovimiento"];
                iRegistroViajeDTO.Liquidado = dr.IsNull("Liquidado") ? false : (bool)dr["Liquidado"]; 
                iRegistroViajeDTO.Placa = dr.IsNull("Placa") ? null : (string)dr["Placa"];
                iRegistroViajeDTO.NitConductor = dr.IsNull("NitConductor") ? "" : (string)dr["NitConductor"].ToString();
                iRegistroViajeDTO.NombreConductor = dr.IsNull("NombreConductor") ? "" : (string)dr["NombreConductor"].ToString();
                iRegistroViajeDTO.ValorGastos = dr.IsNull("ValorGastos") ? 0: (decimal)dr["ValorGastos"]; 
                iRegistroViajeDTO.ValorAnticipos = dr.IsNull("ValorAnticipos") ? 0 : (decimal)dr["ValorAnticipos"];
                iRegistroViajeDTO.ValorSaldo = dr.IsNull("ValorSaldo") ? 0 : (decimal)dr["ValorSaldo"];
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


    }

}
