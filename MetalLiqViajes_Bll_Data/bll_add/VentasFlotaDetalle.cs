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

	public partial class VentasFlotaDetalleController//: ILatinodeController
	{
		public VentasFlotaDetalleList GetByFactura(string factura,bool generateUndo=false)
		{
			try 
			{
				VentasFlotaDetalleList ventasflotadetallelist = new VentasFlotaDetalleList();
				DataTable dt = VentasFlotaDetalleDataProvider.Instance.GetByFactura(factura);
				foreach (DataRow dr in dt.Rows)
				{
					VentasFlotaDetalle ventasflotadetalle = new VentasFlotaDetalle();
					ReadData(ventasflotadetalle, dr, generateUndo);
					ventasflotadetallelist.Add(ventasflotadetalle);
				}
				return ventasflotadetallelist;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
	}
}
