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
	public partial class TramosLavadasController//: ILatinodeController
	{
		public TramosLavadasList GetBy_RegistroViaje(decimal NitConductor, bool generateUndo=false)
		{
			try 
			{
				TramosLavadasList tramoslavadaslist = new TramosLavadasList();
				DataTable dt = TramosLavadasDataProvider.Instance.GetBy_RegistroViaje(NitConductor);
				foreach (DataRow dr in dt.Rows)
				{
					TramosLavadas tramoslavadas = new TramosLavadas();
					ReadData(tramoslavadas, dr, generateUndo);
					tramoslavadaslist.Add(tramoslavadas);
				}
				return tramoslavadaslist;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
	}
}
