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
using Microsoft.Practices.EnterpriseLibrary.Security.Cryptography;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Runtime.Serialization;

namespace LiqViajes_Bll_Data
{
	#region LiquidacionVehiculo object

	[DataContract]
	public partial class LiquidacionVehiculo : IDTOObject
	{
		/// <summary>
		/// Default constructor
		/// </summary>
		public LiquidacionVehiculo()
		{
			m_lngIdRegistro = 0;
			m_strPlaca = null;
			m_intNitConductor = null;
			m_curGastos = null;
			m_curAnticipos = null;
			m_curTotal = null;
			m_dtmFechaModif = null;
			m_logLiquidado = false;
			m_sngRentabilidad = null;
			m_curValorFleteAcum = null;
			m_logDesplazaVacio = false;
			m_logSePuedeLiquidar = false;
			m_curValorFlete = null;
			m_curvalorUtilidad = null;
			m_curValorRentabilidad = null;
			m_TotalGalones = null;
			m_cutCombustible = null;
			m_cutParticipacion = null;
			m_cutParticipacionVacio = null;
			m_logLiquParticipacion = false;
			m_logLiquKilometros = false;
			m_curValorKilometros = null;
			m_Kilometros = null;
			m_changed=false;
		}
		        //Return the table name of object
		        public string TableName()
		        {
		            return "tblLiquidacionVehiculo";
		        }
		#region Undo 
		// Internal class for storing changes
		private LiquidacionVehiculo m_oldLiquidacionVehiculo;
		public void GenerateUndo()
		{
			m_oldLiquidacionVehiculo=new LiquidacionVehiculo();
			m_oldLiquidacionVehiculo.m_lngIdRegistro = m_lngIdRegistro;
			m_oldLiquidacionVehiculo.strPlaca = m_strPlaca;
			m_oldLiquidacionVehiculo.intNitConductor = m_intNitConductor;
			m_oldLiquidacionVehiculo.curGastos = m_curGastos;
			m_oldLiquidacionVehiculo.curAnticipos = m_curAnticipos;
			m_oldLiquidacionVehiculo.curTotal = m_curTotal;
			m_oldLiquidacionVehiculo.dtmFechaModif = m_dtmFechaModif;
			m_oldLiquidacionVehiculo.logLiquidado = m_logLiquidado;
			m_oldLiquidacionVehiculo.sngRentabilidad = m_sngRentabilidad;
			m_oldLiquidacionVehiculo.curValorFleteAcum = m_curValorFleteAcum;
			m_oldLiquidacionVehiculo.logDesplazaVacio = m_logDesplazaVacio;
			m_oldLiquidacionVehiculo.logSePuedeLiquidar = m_logSePuedeLiquidar;
			m_oldLiquidacionVehiculo.curValorFlete = m_curValorFlete;
			m_oldLiquidacionVehiculo.curvalorUtilidad = m_curvalorUtilidad;
			m_oldLiquidacionVehiculo.curValorRentabilidad = m_curValorRentabilidad;
			m_oldLiquidacionVehiculo.TotalGalones = m_TotalGalones;
			m_oldLiquidacionVehiculo.cutCombustible = m_cutCombustible;
			m_oldLiquidacionVehiculo.cutParticipacion = m_cutParticipacion;
			m_oldLiquidacionVehiculo.cutParticipacionVacio = m_cutParticipacionVacio;
			m_oldLiquidacionVehiculo.logLiquParticipacion = m_logLiquParticipacion;
			m_oldLiquidacionVehiculo.logLiquKilometros = m_logLiquKilometros;
			m_oldLiquidacionVehiculo.curValorKilometros = m_curValorKilometros;
			m_oldLiquidacionVehiculo.Kilometros = m_Kilometros;
		}

		public LiquidacionVehiculo OldLiquidacionVehiculo
		{
			get { return m_oldLiquidacionVehiculo;}
		}
		// Return the changed fields
		public string[] FieldChanged()
		{
			List<string> fields=new List<string>();
			if (m_oldLiquidacionVehiculo.strPlaca != m_strPlaca) fields.Add("strPlaca");
			if (m_oldLiquidacionVehiculo.intNitConductor != m_intNitConductor) fields.Add("intNitConductor");
			if (m_oldLiquidacionVehiculo.curGastos != m_curGastos) fields.Add("curGastos");
			if (m_oldLiquidacionVehiculo.curAnticipos != m_curAnticipos) fields.Add("curAnticipos");
			if (m_oldLiquidacionVehiculo.curTotal != m_curTotal) fields.Add("curTotal");
			if (m_oldLiquidacionVehiculo.dtmFechaModif != m_dtmFechaModif) fields.Add("dtmFechaModif");
			if (m_oldLiquidacionVehiculo.logLiquidado != m_logLiquidado) fields.Add("logLiquidado");
			if (m_oldLiquidacionVehiculo.sngRentabilidad != m_sngRentabilidad) fields.Add("sngRentabilidad");
			if (m_oldLiquidacionVehiculo.curValorFleteAcum != m_curValorFleteAcum) fields.Add("curValorFleteAcum");
			if (m_oldLiquidacionVehiculo.logDesplazaVacio != m_logDesplazaVacio) fields.Add("logDesplazaVacio");
			if (m_oldLiquidacionVehiculo.logSePuedeLiquidar != m_logSePuedeLiquidar) fields.Add("logSePuedeLiquidar");
			if (m_oldLiquidacionVehiculo.curValorFlete != m_curValorFlete) fields.Add("curValorFlete");
			if (m_oldLiquidacionVehiculo.curvalorUtilidad != m_curvalorUtilidad) fields.Add("curvalorUtilidad");
			if (m_oldLiquidacionVehiculo.curValorRentabilidad != m_curValorRentabilidad) fields.Add("curValorRentabilidad");
			if (m_oldLiquidacionVehiculo.TotalGalones != m_TotalGalones) fields.Add("TotalGalones");
			if (m_oldLiquidacionVehiculo.cutCombustible != m_cutCombustible) fields.Add("cutCombustible");
			if (m_oldLiquidacionVehiculo.cutParticipacion != m_cutParticipacion) fields.Add("cutParticipacion");
			if (m_oldLiquidacionVehiculo.cutParticipacionVacio != m_cutParticipacionVacio) fields.Add("cutParticipacionVacio");
			if (m_oldLiquidacionVehiculo.logLiquParticipacion != m_logLiquParticipacion) fields.Add("logLiquParticipacion");
			if (m_oldLiquidacionVehiculo.logLiquKilometros != m_logLiquKilometros) fields.Add("logLiquKilometros");
			if (m_oldLiquidacionVehiculo.curValorKilometros != m_curValorKilometros) fields.Add("curValorKilometros");
			if (m_oldLiquidacionVehiculo.Kilometros != m_Kilometros) fields.Add("Kilometros");
			string[] fieldst = new string[fields.Count];
			int i = 0;
			foreach(string st in fields)
			{
				fieldst[i]=st;
				i++;
			}
			return fieldst;
		}
		#endregion
		#region Fields


		// Field for storing the LiquidacionVehiculo's lngIdRegistro value
		private int m_lngIdRegistro;

		// Field for storing the LiquidacionVehiculo's strPlaca value
		private string m_strPlaca;

		// Field for storing the LiquidacionVehiculo's intNitConductor value
		private decimal? m_intNitConductor;

		// Field for storing the LiquidacionVehiculo's curGastos value
		private decimal? m_curGastos;

		// Field for storing the LiquidacionVehiculo's curAnticipos value
		private decimal? m_curAnticipos;

		// Field for storing the LiquidacionVehiculo's curTotal value
		private decimal? m_curTotal;

		// Field for storing the LiquidacionVehiculo's dtmFechaModif value
		private DateTime? m_dtmFechaModif;

		// Field for storing the LiquidacionVehiculo's logLiquidado value
		private bool? m_logLiquidado;

		// Field for storing the LiquidacionVehiculo's sngRentabilidad value
		private float? m_sngRentabilidad;

		// Field for storing the LiquidacionVehiculo's curValorFleteAcum value
		private decimal? m_curValorFleteAcum;

		// Field for storing the LiquidacionVehiculo's logDesplazaVacio value
		private bool? m_logDesplazaVacio;

		// Field for storing the LiquidacionVehiculo's logSePuedeLiquidar value
		private bool? m_logSePuedeLiquidar;

		// Field for storing the LiquidacionVehiculo's curValorFlete value
		private decimal? m_curValorFlete;

		// Field for storing the LiquidacionVehiculo's curvalorUtilidad value
		private decimal? m_curvalorUtilidad;

		// Field for storing the LiquidacionVehiculo's curValorRentabilidad value
		private decimal? m_curValorRentabilidad;

		// Field for storing the LiquidacionVehiculo's TotalGalones value
		private decimal? m_TotalGalones;

		// Field for storing the LiquidacionVehiculo's cutCombustible value
		private decimal? m_cutCombustible;

		// Field for storing the LiquidacionVehiculo's cutParticipacion value
		private decimal? m_cutParticipacion;

		// Field for storing the LiquidacionVehiculo's cutParticipacionVacio value
		private decimal? m_cutParticipacionVacio;

		// Field for storing the LiquidacionVehiculo's logLiquParticipacion value
		private bool? m_logLiquParticipacion;

		// Field for storing the LiquidacionVehiculo's logLiquKilometros value
		private bool? m_logLiquKilometros;

		// Field for storing the LiquidacionVehiculo's curValorKilometros value
		private decimal? m_curValorKilometros;

		// Field for storing the LiquidacionVehiculo's Kilometros value
		private int? m_Kilometros;

		// Evaluate changed state
		private bool m_changed=false;
		// Field for storing the reference to Terceros accessed by intNitConductor
		private Terceros m_Terceros;

		// Field for storing the reference to foreign LiquidacionRutasList object accessed by lngIdRegistro
		private LiquidacionRutasList m_LiquidacionRutas;


		#endregion

		#region Attributes

		// Return if object changed
		public bool Changed
		{
			get { return m_changed;}
			set { m_changed=value;}
		}
		/// <summary>
		/// Attribute for access the LiquidacionVehiculo's lngIdRegistro value (int)
		/// </summary>
		[DataMember]
		public int lngIdRegistro
		{
			get { return m_lngIdRegistro; }
			set 
			{
				m_changed=true;
				m_lngIdRegistro = value;
			}
		}

		/// <summary>
		/// Attribute for access the LiquidacionVehiculo's strPlaca value (string)
		/// </summary>
		[DataMember]
		public string strPlaca
		{
			get { return m_strPlaca; }
			set 
			{
				m_changed=true;
				m_strPlaca = value;
			}
		}

		/// <summary>
		/// Attribute for access the LiquidacionVehiculo's intNitConductor value (decimal)
		/// </summary>
		[DataMember]
		public decimal? intNitConductor
		{
			get { return m_intNitConductor; }
			set
			{
				m_changed=true;
				m_intNitConductor = value;

				if ((m_Terceros != null) && (m_Terceros.NitConductor != m_intNitConductor))
				{
					// we need to reset the reference because it is now invalid
					m_Terceros = null;
				}
			}
		}

		/// <summary>
		/// Attribute for access the LiquidacionVehiculo's curGastos value (decimal)
		/// </summary>
		[DataMember]
		public decimal? curGastos
		{
			get { return m_curGastos; }
			set 
			{
				m_changed=true;
				m_curGastos = value;
			}
		}

		/// <summary>
		/// Attribute for access the LiquidacionVehiculo's curAnticipos value (decimal)
		/// </summary>
		[DataMember]
		public decimal? curAnticipos
		{
			get { return m_curAnticipos; }
			set 
			{
				m_changed=true;
				m_curAnticipos = value;
			}
		}

		/// <summary>
		/// Attribute for access the LiquidacionVehiculo's curTotal value (decimal)
		/// </summary>
		[DataMember]
		public decimal? curTotal
		{
			get { return m_curTotal; }
			set 
			{
				m_changed=true;
				m_curTotal = value;
			}
		}

		/// <summary>
		/// Attribute for access the LiquidacionVehiculo's dtmFechaModif value (DateTime)
		/// </summary>
		[DataMember]
		public DateTime? dtmFechaModif
		{
			get { return m_dtmFechaModif; }
			set 
			{
				m_changed=true;
				m_dtmFechaModif = value;
			}
		}

		/// <summary>
		/// Attribute for access the LiquidacionVehiculo's logLiquidado value (bool)
		/// </summary>
		[DataMember]
		public bool? logLiquidado
		{
			get { return m_logLiquidado; }
			set 
			{
				m_changed=true;
				m_logLiquidado = value;
			}
		}

		/// <summary>
		/// Attribute for access the LiquidacionVehiculo's sngRentabilidad value (float)
		/// </summary>
		[DataMember]
		public float? sngRentabilidad
		{
			get { return m_sngRentabilidad; }
			set 
			{
				m_changed=true;
				m_sngRentabilidad = value;
			}
		}

		/// <summary>
		/// Attribute for access the LiquidacionVehiculo's curValorFleteAcum value (decimal)
		/// </summary>
		[DataMember]
		public decimal? curValorFleteAcum
		{
			get { return m_curValorFleteAcum; }
			set 
			{
				m_changed=true;
				m_curValorFleteAcum = value;
			}
		}

		/// <summary>
		/// Attribute for access the LiquidacionVehiculo's logDesplazaVacio value (bool)
		/// </summary>
		[DataMember]
		public bool? logDesplazaVacio
		{
			get { return m_logDesplazaVacio; }
			set 
			{
				m_changed=true;
				m_logDesplazaVacio = value;
			}
		}

		/// <summary>
		/// Attribute for access the LiquidacionVehiculo's logSePuedeLiquidar value (bool)
		/// </summary>
		[DataMember]
		public bool? logSePuedeLiquidar
		{
			get { return m_logSePuedeLiquidar; }
			set 
			{
				m_changed=true;
				m_logSePuedeLiquidar = value;
			}
		}

		/// <summary>
		/// Attribute for access the LiquidacionVehiculo's curValorFlete value (decimal)
		/// </summary>
		[DataMember]
		public decimal? curValorFlete
		{
			get { return m_curValorFlete; }
			set 
			{
				m_changed=true;
				m_curValorFlete = value;
			}
		}

		/// <summary>
		/// Attribute for access the LiquidacionVehiculo's curvalorUtilidad value (decimal)
		/// </summary>
		[DataMember]
		public decimal? curvalorUtilidad
		{
			get { return m_curvalorUtilidad; }
			set 
			{
				m_changed=true;
				m_curvalorUtilidad = value;
			}
		}

		/// <summary>
		/// Attribute for access the LiquidacionVehiculo's curValorRentabilidad value (decimal)
		/// </summary>
		[DataMember]
		public decimal? curValorRentabilidad
		{
			get { return m_curValorRentabilidad; }
			set 
			{
				m_changed=true;
				m_curValorRentabilidad = value;
			}
		}

		/// <summary>
		/// Attribute for access the LiquidacionVehiculo's TotalGalones value (decimal)
		/// </summary>
		[DataMember]
		public decimal? TotalGalones
		{
			get { return m_TotalGalones; }
			set 
			{
				m_changed=true;
				m_TotalGalones = value;
			}
		}

		/// <summary>
		/// Attribute for access the LiquidacionVehiculo's cutCombustible value (decimal)
		/// </summary>
		[DataMember]
		public decimal? cutCombustible
		{
			get { return m_cutCombustible; }
			set 
			{
				m_changed=true;
				m_cutCombustible = value;
			}
		}

		/// <summary>
		/// Attribute for access the LiquidacionVehiculo's cutParticipacion value (decimal)
		/// </summary>
		[DataMember]
		public decimal? cutParticipacion
		{
			get { return m_cutParticipacion; }
			set 
			{
				m_changed=true;
				m_cutParticipacion = value;
			}
		}

		/// <summary>
		/// Attribute for access the LiquidacionVehiculo's cutParticipacionVacio value (decimal)
		/// </summary>
		[DataMember]
		public decimal? cutParticipacionVacio
		{
			get { return m_cutParticipacionVacio; }
			set 
			{
				m_changed=true;
				m_cutParticipacionVacio = value;
			}
		}

		/// <summary>
		/// Attribute for access the LiquidacionVehiculo's logLiquParticipacion value (bool)
		/// </summary>
		[DataMember]
		public bool? logLiquParticipacion
		{
			get { return m_logLiquParticipacion; }
			set 
			{
				m_changed=true;
				m_logLiquParticipacion = value;
			}
		}

		/// <summary>
		/// Attribute for access the LiquidacionVehiculo's logLiquKilometros value (bool)
		/// </summary>
		[DataMember]
		public bool? logLiquKilometros
		{
			get { return m_logLiquKilometros; }
			set 
			{
				m_changed=true;
				m_logLiquKilometros = value;
			}
		}

		/// <summary>
		/// Attribute for access the LiquidacionVehiculo's curValorKilometros value (decimal)
		/// </summary>
		[DataMember]
		public decimal? curValorKilometros
		{
			get { return m_curValorKilometros; }
			set 
			{
				m_changed=true;
				m_curValorKilometros = value;
			}
		}

		/// <summary>
		/// Attribute for access the LiquidacionVehiculo's Kilometros value (int)
		/// </summary>
		[DataMember]
		public int? Kilometros
		{
			get { return m_Kilometros; }
			set 
			{
				m_changed=true;
				m_Kilometros = value;
			}
		}

		public object GetAttribute(string pattribute)
		{
			switch (pattribute)
			{
				case "lngIdRegistro": return lngIdRegistro;
				case "strPlaca": return strPlaca;
				case "intNitConductor": return intNitConductor;
				case "curGastos": return curGastos;
				case "curAnticipos": return curAnticipos;
				case "curTotal": return curTotal;
				case "dtmFechaModif": return dtmFechaModif;
				case "logLiquidado": return logLiquidado;
				case "sngRentabilidad": return sngRentabilidad;
				case "curValorFleteAcum": return curValorFleteAcum;
				case "logDesplazaVacio": return logDesplazaVacio;
				case "logSePuedeLiquidar": return logSePuedeLiquidar;
				case "curValorFlete": return curValorFlete;
				case "curvalorUtilidad": return curvalorUtilidad;
				case "curValorRentabilidad": return curValorRentabilidad;
				case "TotalGalones": return TotalGalones;
				case "cutCombustible": return cutCombustible;
				case "cutParticipacion": return cutParticipacion;
				case "cutParticipacionVacio": return cutParticipacionVacio;
				case "logLiquParticipacion": return logLiquParticipacion;
				case "logLiquKilometros": return logLiquKilometros;
				case "curValorKilometros": return curValorKilometros;
				case "Kilometros": return Kilometros;
				default: return null;
			}
		}

		public Type GetAttributeType(string pattribute)
		{
			return LiquidacionVehiculoController.Instance.GetMethodType(pattribute, this);
		}

		public string GetSqlKey()
		{
			return "[lngIdRegistro] = " + lngIdRegistro.ToString();
		}
		/// <summary>
		/// Gets or sets the reference to Terceros accessed by intNitConductor
		/// </summary>
		/// <remarks>
		/// Also updates related field values
		/// </remarks>
		public Terceros Terceros
		{
			get
			{
				if (m_Terceros == null)
				{
					if (m_intNitConductor != null)
					{
						m_Terceros = TercerosController.Instance.Get((decimal)m_intNitConductor);
					}
				}

				return m_Terceros;
			}

			set
			{
				m_Terceros = value;

				if (m_Terceros != null)
				{
					this.m_intNitConductor = m_Terceros.NitConductor;
				}
			}
		}

		/// <summary>
		/// Gets or sets the reference to foreign LiquidacionRutasList object accessed by lngIdRegistro
		/// </summary>
		public LiquidacionRutasList LiquidacionRutas
		{
			get
			{
				if (m_LiquidacionRutas == null)
				{
					m_LiquidacionRutas = LiquidacionRutasController.Instance.GetBy_lngIdRegistro(lngIdRegistro);
			}

			return m_LiquidacionRutas;
		}
		set { m_LiquidacionRutas = value; }
	}

	#endregion

}

#endregion

#region LiquidacionVehiculoList object

/// <summary>
/// Class for reading and access a list of LiquidacionVehiculo object
/// </summary>
[CollectionDataContract]
public partial class LiquidacionVehiculoList : List<LiquidacionVehiculo>
{

	/// <summary>
	/// Default constructor
	/// </summary>
	public LiquidacionVehiculoList()
	{
	}
}

#endregion

}
