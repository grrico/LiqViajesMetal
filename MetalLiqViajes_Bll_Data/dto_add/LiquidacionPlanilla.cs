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

    public partial class LiquidacionPlanilla : IDTOObject
    {
        private Rutas m_Rutas;

        public Rutas Rutas
        {
            get
            {
                if (m_Rutas == null)
                {
                    m_Rutas = RutasController.Instance.Get(this.lngIdRegistrRuta);
                }

                return m_Rutas;
            }
            set { m_Rutas = value; }
        }

        private string tramoLiquidado;

        public string TramoLiquidado
        {
            get
            {
                if (m_Rutas != null)
                {
                    if (m_Rutas.lngIdRegistrRuta == this.lngIdRegistrRuta)
                    {
                        m_Rutas = null;
                    }                    
                }

                if (m_Rutas == null)
                {
                    m_Rutas = RutasController.Instance.Get(this.lngIdRegistrRuta);
                }

                return tramoLiquidado = m_Rutas.strRutaAnticipo;
            }

            set
            {
                tramoLiquidado = value;
            }
        }
    }

}
