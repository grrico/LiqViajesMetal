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
	

	
	public partial class LiquidacionPlanillaController//: ILatinodeController
	{
		public LiquidacionPlanillaList GetBy_RegistroViaje(long lngIdRegistro, bool generateUndo=false)
		{
			try 
			{
				LiquidacionPlanillaList liquidacionplanillalist = new LiquidacionPlanillaList();
                DataTable dt = LiquidacionPlanillaDataProvider.Instance.GetBy_RegistroViaje(lngIdRegistro);
				foreach (DataRow dr in dt.Rows)
				{
					LiquidacionPlanilla liquidacionplanilla = new LiquidacionPlanilla();
					ReadData(liquidacionplanilla, dr, generateUndo);
					liquidacionplanillalist.Add(liquidacionplanilla);
				}
				return liquidacionplanillalist;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}        
	}

}
