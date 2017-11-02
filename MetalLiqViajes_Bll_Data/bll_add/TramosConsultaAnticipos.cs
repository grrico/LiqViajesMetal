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

    public partial class TramosConsultaAnticiposController//: ILatinodeController
    {
        public TramosConsultaAnticiposList GetBy_RegistroViaje(long lngIdRegistro, bool generateUndo = false)
        {
            try
            {
                TramosConsultaAnticiposList tramosconsultaanticiposlist = new TramosConsultaAnticiposList();
                DataTable dt = TramosConsultaAnticiposDataProvider.Instance.GetBy_RegistroViaje(lngIdRegistro);
                foreach (DataRow dr in dt.Rows)
                {
                    TramosConsultaAnticipos tramosconsultaanticipos = new TramosConsultaAnticipos();
                    ReadData(tramosconsultaanticipos, dr, generateUndo);
                    tramosconsultaanticiposlist.Add(tramosconsultaanticipos);
                }
                return tramosconsultaanticiposlist;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }


}
