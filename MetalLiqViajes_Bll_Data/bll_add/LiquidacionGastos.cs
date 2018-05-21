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

    public partial class LiquidacionGastosController//: ILatinodeController
    {
        public LiquidacionGastosList GetBy_lngIdRegistrRuta(long IdRegistrRutaItemId, bool generateUndo = false)
        {
            LiquidacionGastosList liquidaciongastoslist = new LiquidacionGastosList();
            try
            {

                DataTable dt = LiquidacionGastosDataProvider.Instance.GetBy_lngIdRegistrRuta(IdRegistrRutaItemId);
                foreach (DataRow dr in dt.Rows)
                {
                    LiquidacionGastos liquidaciongastos = new LiquidacionGastos();
                    ReadData(liquidaciongastos, dr, generateUndo);
                    liquidaciongastoslist.Add(liquidaciongastos);
                }
                return liquidaciongastoslist;
            }
            catch (Exception)
            {
                return liquidaciongastoslist;
            }
        }

    }

}
