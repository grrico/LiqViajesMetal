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
    
	public partial class TramosAsignadosRutaController//: ILatinodeController
	{
        public TramosAsignadosRutaList GetBy_lngIdRegistro(int lngIdRegistro, bool generateUndo = false)
        {
			try 
			{
				TramosAsignadosRutaList tramosasignadosrutalist = new TramosAsignadosRutaList();
				DataTable dt = TramosAsignadosRutaDataProvider.Instance.GetBy_lngIdRegistro(lngIdRegistro);
				foreach (DataRow dr in dt.Rows)
				{
					TramosAsignadosRuta tramosasignadosruta = new TramosAsignadosRuta();
					ReadData(tramosasignadosruta, dr, generateUndo);
					tramosasignadosrutalist.Add(tramosasignadosruta);
				}
				return tramosasignadosrutalist;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}		
	}


}
