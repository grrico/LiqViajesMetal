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

	public partial class TramosMovViajesController//: ILatinodeController
	{
		public TramosMovViajesList GetBy_RegistroViaje(long IdRegistroViaje, bool generateUndo=false)
		{
			try 
			{
				TramosMovViajesList tramosmovviajeslist = new TramosMovViajesList();
				DataTable dt = TramosMovViajesDataProvider.Instance.GetBy_RegistroViaje(IdRegistroViaje);
				foreach (DataRow dr in dt.Rows)
				{
					TramosMovViajes tramosmovviajes = new TramosMovViajes();
					ReadData(tramosmovviajes, dr, generateUndo);
					tramosmovviajeslist.Add(tramosmovviajes);
				}
				return tramosmovviajeslist;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
	}
}
