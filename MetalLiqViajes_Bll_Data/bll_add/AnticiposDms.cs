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
	
	public partial class AnticiposDmsController//: ILatinodeController
	{
		
		public AnticiposDmsList GetBy_DocumentoNit(long Nit, long IdRegistro, bool generateUndo=false)
		{
			try 
			{
				AnticiposDmsList anticiposdmslist = new AnticiposDmsList();
				DataTable dt = AnticiposDmsDataProvider.Instance.GetBy_DocumentoNit(Nit, IdRegistro);
				foreach (DataRow dr in dt.Rows)
				{
					AnticiposDms anticiposdms = new AnticiposDms();
					ReadData(anticiposdms, dr, generateUndo);
					anticiposdmslist.Add(anticiposdms);
				}
				return anticiposdmslist;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

	}
}
