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

    public partial class TercerosController//: ILatinodeController
    {

        public List<TercerosDTO> GetByTercerosDms(bool generateUndo = false)
        {
            try
            {
                List<TercerosDTO> terceroslist = new List<TercerosDTO>();
                DataTable dt = TercerosDataProvider.Instance.GetByTercerosDms();
                foreach (DataRow dr in dt.Rows)
                {
                    TercerosDTO terceros = new TercerosDTO();
                    ReadDataDTO(terceros, dr, generateUndo);
                    terceroslist.Add(terceros);
                }
                return terceroslist;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void ReadDataDTO(TercerosDTO terceros, DataRow dr, bool generateUndo = false)
        {
            try
            {
                terceros.Nit = dr.IsNull("Nit") ? 0 : (long)dr["Nit"];
                terceros.NombreTercero = dr.IsNull("NombreTercero") ? null : (string)dr["NombreTercero"];
            }
            catch (Exception ex)
            {
                Utilidades.LogErrores(ex.Message + (ex.InnerException != null ? ex.InnerException.Message : ""), DataProvider.AplicacionNombre);
                throw ex;
            }
        }
    }


}
