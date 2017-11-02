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
    public partial class LiquidacionVehiculo : IDTOObject
    {

        int _number;
        public int Number
        {
            get
            {
                return this._number;
            }
            set
            {
                this._number = value;
            }
        }

        public string NombreConductor
        {
            get
            {
                return m_NombreConductor;
            }

            set
            {
                m_NombreConductor = value;
            }
        }

        private string m_NombreConductor;


    }
}

