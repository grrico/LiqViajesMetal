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
namespace LiqMetalDMS_Bll_Data
{
	/// <summary>
	/// Class for Master Tables
	/// </summary>
	public static class MasterTables
	{
		private static centrosList m_centroslist;
		public static centrosList centros
		{
			get
			{
				if (m_centroslist == null)
				{
					m_centroslist = centrosController.Instance.GetAll();
				}
				return m_centroslist;
			}
		}
		private static consecutivosList m_consecutivoslist;
		public static consecutivosList consecutivos
		{
			get
			{
				if (m_consecutivoslist == null)
				{
					m_consecutivoslist = consecutivosController.Instance.GetAll();
				}
				return m_consecutivoslist;
			}
		}
		public static void Reset()
		{
			 Reset("");
		}

		public static void Reset(string obj)
		{
			switch (obj)
			{
				case "centros":
				m_centroslist=null;
				break;
				case "consecutivos":
				m_consecutivoslist=null;
				break;
				case "":
				m_centroslist=null;
				m_consecutivoslist=null;
				break;
			}
		}
	}
}
