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

	public partial class VehiculoCCostoController//: ILatinodeController
	{
		public VehiculoCCosto GetByPlaca(string Placa, bool generateUndo=false)
		{
			try 
			{
				VehiculoCCosto vehiculoccosto = null;
				DataTable dt = VehiculoCCostoDataProvider.Instance.GetByPlaca(Placa);
				if ((dt.Rows.Count > 0))
				{
					vehiculoccosto = new VehiculoCCosto();
					DataRow dr = dt.Rows[0];
					ReadData(vehiculoccosto, dr, generateUndo);
				}


				return vehiculoccosto;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
	}


}
