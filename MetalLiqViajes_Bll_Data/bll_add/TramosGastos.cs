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
	public partial class TramosGastosController//: ILatinodeController
	{
		public TramosGastosList GetBy_RegistroViaje(long IdRegistroViaje, bool generateUndo=false)
		{
			try 
			{
				TramosGastosList tramosgastoslist = new TramosGastosList();
				DataTable dt = TramosGastosDataProvider.Instance.GetBy_RegistroViaje(IdRegistroViaje);
				foreach (DataRow dr in dt.Rows)
				{
					TramosGastos tramosgastos = new TramosGastos();
					ReadData(tramosgastos, dr, generateUndo);
					tramosgastoslist.Add(tramosgastos);
				}
				return tramosgastoslist;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
	}
}
