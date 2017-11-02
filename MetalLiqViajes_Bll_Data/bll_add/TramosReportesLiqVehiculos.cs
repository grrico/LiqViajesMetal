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
    public partial class TramosReportesLiqVehiculosController//: ILatinodeController
    {

        public TramosReportesLiqVehiculosList GetBy_Registro(long IdRegistro, bool generateUndo = false)
        {
            TramosReportesLiqVehiculosList tramosreportesliqvehiculoslist = new TramosReportesLiqVehiculosList();
            try
            {
                DataTable dt = TramosReportesLiqVehiculosDataProvider.Instance.GetBy_Registro(IdRegistro);
                foreach (DataRow dr in dt.Rows)
                {
                    TramosReportesLiqVehiculos tramosreportesliqvehiculos = new TramosReportesLiqVehiculos();
                    ReadData(tramosreportesliqvehiculos, dr, generateUndo);
                    tramosreportesliqvehiculoslist.Add(tramosreportesliqvehiculos);
                }
                return tramosreportesliqvehiculoslist;
            }
            catch (Exception)
            {
                return tramosreportesliqvehiculoslist;
            }
        }

    }


}
