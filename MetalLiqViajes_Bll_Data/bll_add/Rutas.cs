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
    /// </summary>
    public partial class RutasController//: ILatinodeController
    {
        public RutasList GetBy_RutasOrigenDestino(string rutaorigen, string rutadestino, string rutaanticipo, bool generateUndo = false)
        {
            try
            {
                RutasList rutaslist = new RutasList();

                DataTable dt = RutasDataProvider.Instance.GetBy_RutasOrigenDestino(rutaorigen, rutadestino, rutaanticipo);
                foreach (DataRow dr in dt.Rows)
                {
                    Rutas rutas = new Rutas();
                    ReadData(rutas, dr, generateUndo);
                    rutaslist.Add(rutas);
                }
                return rutaslist;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }

}
