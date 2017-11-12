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
		
	public partial class RutaSatrackHistoryEventsController//: ILatinodeController
	{
	
		public RutaSatrackHistoryEventsList GetByPlacaFecha(string Placa, DateTime FechaInicial, DateTime FechaFinal, bool generateUndo=false)
		{
			try 
			{
				RutaSatrackHistoryEventsList rutasatrackhistoryeventslist = new RutaSatrackHistoryEventsList();
				DataTable dt = RutaSatrackHistoryEventsDataProvider.Instance.GetByPlacaFecha(Placa, FechaInicial, FechaFinal);
				foreach (DataRow dr in dt.Rows)
				{
					RutaSatrackHistoryEvents rutasatrackhistoryevents = new RutaSatrackHistoryEvents();
					ReadData(rutasatrackhistoryevents, dr, generateUndo);
					rutasatrackhistoryeventslist.Add(rutasatrackhistoryevents);
				}
				return rutasatrackhistoryeventslist;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
        
	}
   
}
