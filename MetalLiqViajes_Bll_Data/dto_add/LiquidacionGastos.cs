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
	public partial class LiquidacionGastos : IDTOObject
	{

        private string detalleCuenta;

        public string DetalleCuenta
        {
            get
            {
                return detalleCuenta = mDetalleCuenta();
            }

            set
            {
                detalleCuenta = value;
            }
        }

        private string mDetalleCuenta()
        {
            string[] comando = this.strDescripcionCuenta.Split('_');
            string detalle = comando[1];
            return detalle;
        }
       
    }
}
