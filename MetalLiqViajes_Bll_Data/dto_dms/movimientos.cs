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

    [DataContract]
    public partial class movimientos 
    {
        
        public movimientos()
        {
            m_tipo = "";
            m_numero = 0;
            m_seq = 0;
            m_cuenta = "";
            m_centro = 0;
            m_nit = 0;
            m_fec = DateTime.Now.Date;
            m_valor = 0;
            m_base = null;
            m_documento = null;
            m_explicacion = null;
            m_concilio = null;
            m_concepto_mov = null;
            m_concilio_ano = null;
            m_secuencia_extracto = null;
            m_ano_concilia = null;
            m_mes_concilia = null;
            m_ID_CRUCE = null;
            m_TIPO_CRUCE = null;
            m_valor_niif = 0;
            m_changed = false;
        }
        
        public string TableName()
        {
            return "movimiento";
        }
        
        #region Undo 
        // Internal class for storing changes
        private movimientos m_oldmovimiento;
        public void GenerateUndo()
        {
            m_oldmovimiento = new movimientos();
            m_oldmovimiento.m_tipo = m_tipo;
            m_oldmovimiento.m_numero = m_numero;
            m_oldmovimiento.m_seq = m_seq;
            m_oldmovimiento.cuenta = m_cuenta;
            m_oldmovimiento.centro = m_centro;
            m_oldmovimiento.nit = m_nit;
            m_oldmovimiento.fec = m_fec;
            m_oldmovimiento.valor = m_valor;
            m_oldmovimiento.documento = m_documento;
            m_oldmovimiento.explicacion = m_explicacion;
            m_oldmovimiento.concilio = m_concilio;
            m_oldmovimiento.concepto_mov = m_concepto_mov;
            m_oldmovimiento.concilio_ano = m_concilio_ano;
            m_oldmovimiento.secuencia_extracto = m_secuencia_extracto;
            m_oldmovimiento.ano_concilia = m_ano_concilia;
            m_oldmovimiento.mes_concilia = m_mes_concilia;
            m_oldmovimiento.TIPO_CRUCE = m_TIPO_CRUCE;
            m_oldmovimiento.valor_niif = m_valor_niif;
        }

        public movimientos Oldmovimiento
        {
            get { return m_oldmovimiento; }
        }
        // Return the changed fields
        public string[] FieldChanged()
        {
            List<string> fields = new List<string>();
            if (m_oldmovimiento.cuenta != m_cuenta) fields.Add("cuenta");
            if (m_oldmovimiento.centro != m_centro) fields.Add("centro");
            if (m_oldmovimiento.nit != m_nit) fields.Add("nit");
            if (m_oldmovimiento.fec != m_fec) fields.Add("fec");
            if (m_oldmovimiento.valor != m_valor) fields.Add("valor");
            if (m_oldmovimiento.documento != m_documento) fields.Add("documento");
            if (m_oldmovimiento.explicacion != m_explicacion) fields.Add("explicacion");
            if (m_oldmovimiento.concilio != m_concilio) fields.Add("concilio");
            if (m_oldmovimiento.concepto_mov != m_concepto_mov) fields.Add("concepto_mov");
            if (m_oldmovimiento.concilio_ano != m_concilio_ano) fields.Add("concilio_ano");
            if (m_oldmovimiento.secuencia_extracto != m_secuencia_extracto) fields.Add("secuencia_extracto");
            if (m_oldmovimiento.ano_concilia != m_ano_concilia) fields.Add("ano_concilia");
            if (m_oldmovimiento.mes_concilia != m_mes_concilia) fields.Add("mes_concilia");
            if (m_oldmovimiento.TIPO_CRUCE != m_TIPO_CRUCE) fields.Add("TIPO_CRUCE");
            if (m_oldmovimiento.valor_niif != m_valor_niif) fields.Add("valor_niif");
            string[] fieldst = new string[fields.Count];
            int i = 0;
            foreach (string st in fields)
            {
                fieldst[i] = st;
                i++;
            }
            return fieldst;
        }
        #endregion

        #region Fields


        // Field for storing the movimiento's cuenta value
        private string m_cuenta;

        // Field for storing the movimiento's centro value
        private int m_centro;

        // Field for storing the movimiento's nit value
        private decimal m_nit;

        // Field for storing the movimiento's fec value
        private DateTime m_fec;

        // Field for storing the movimiento's valor value
        private decimal m_valor;

        // Field for storing the movimiento's base value
        private decimal? m_base;

        // Field for storing the movimiento's documento value
        private int? m_documento;

        // Field for storing the movimiento's explicacion value
        private string m_explicacion;

        // Field for storing the movimiento's concilio value
        private string m_concilio;

        // Field for storing the movimiento's concepto_mov value
        private short? m_concepto_mov;

        // Field for storing the movimiento's concilio_ano value
        private short? m_concilio_ano;

        // Field for storing the movimiento's secuencia_extracto value
        private int? m_secuencia_extracto;

        // Field for storing the movimiento's ano_concilia value
        private int? m_ano_concilia;

        // Field for storing the movimiento's mes_concilia value
        private int? m_mes_concilia;

        // Field for storing the movimiento's ID_CRUCE value
        private int? m_ID_CRUCE;

        // Field for storing the movimiento's TIPO_CRUCE value
        private string m_TIPO_CRUCE;

        // Field for storing the movimiento's valor_niif value
        private decimal m_valor_niif;

        // Field for storing the movimiento's tipo value
        private string m_tipo;

        // Field for storing the movimiento's numero value
        private int m_numero;

        // Field for storing the movimiento's seq value
        private int m_seq;

        // Evaluate changed state
        private bool m_changed = false;

        #endregion

        #region Attributes

        // Return if object changed
        public bool Changed
        {
            get { return m_changed; }
            set { m_changed = value; }
        }
        /// <summary>
        /// Attribute for access the movimiento's cuenta value (string)
        /// </summary>
        [DataMember]
        public string cuenta
        {
            get { return m_cuenta; }
            set
            {
                m_changed = true;
                m_cuenta = value;
            }
        }

        /// <summary>
        /// Attribute for access the movimiento's centro value (int)
        /// </summary>
        [DataMember]
        public int centro
        {
            get { return m_centro; }
            set
            {
                m_changed = true;
                m_centro = value;
            }
        }

        /// <summary>
        /// Attribute for access the movimiento's nit value (decimal)
        /// </summary>
        [DataMember]
        public decimal nit
        {
            get { return m_nit; }
            set
            {
                m_changed = true;
                m_nit = value;
            }
        }

        /// <summary>
        /// Attribute for access the movimiento's fec value (DateTime)
        /// </summary>
        [DataMember]
        public DateTime fec
        {
            get { return m_fec; }
            set
            {
                m_changed = true;
                m_fec = value;
            }
        }

        /// <summary>
        /// Attribute for access the movimiento's valor value (decimal)
        /// </summary>
        [DataMember]
        public decimal valor
        {
            get { return m_valor; }
            set
            {
                m_changed = true;
                m_valor = value;
            }
        }

        /// <summary>
        /// Attribute for access the movimiento's documento value (int)
        /// </summary>
        [DataMember]
        public int? documento
        {
            get { return m_documento; }
            set
            {
                m_changed = true;
                m_documento = value;
            }
        }

        /// <summary>
        /// Attribute for access the movimiento's explicacion value (string)
        /// </summary>
        [DataMember]
        public string explicacion
        {
            get { return m_explicacion; }
            set
            {
                m_changed = true;
                m_explicacion = value;
            }
        }

        /// <summary>
        /// Attribute for access the movimiento's concilio value (string)
        /// </summary>
        [DataMember]
        public string concilio
        {
            get { return m_concilio; }
            set
            {
                m_changed = true;
                m_concilio = value;
            }
        }

        /// <summary>
        /// Attribute for access the movimiento's concepto_mov value (short)
        /// </summary>
        [DataMember]
        public short? concepto_mov
        {
            get { return m_concepto_mov; }
            set
            {
                m_changed = true;
                m_concepto_mov = value;
            }
        }

        /// <summary>
        /// Attribute for access the movimiento's concilio_ano value (short)
        /// </summary>
        [DataMember]
        public short? concilio_ano
        {
            get { return m_concilio_ano; }
            set
            {
                m_changed = true;
                m_concilio_ano = value;
            }
        }

        /// <summary>
        /// Attribute for access the movimiento's secuencia_extracto value (int)
        /// </summary>
        [DataMember]
        public int? secuencia_extracto
        {
            get { return m_secuencia_extracto; }
            set
            {
                m_changed = true;
                m_secuencia_extracto = value;
            }
        }

        /// <summary>
        /// Attribute for access the movimiento's ano_concilia value (int)
        /// </summary>
        [DataMember]
        public int? ano_concilia
        {
            get { return m_ano_concilia; }
            set
            {
                m_changed = true;
                m_ano_concilia = value;
            }
        }

        /// <summary>
        /// Attribute for access the movimiento's mes_concilia value (int)
        /// </summary>
        [DataMember]
        public int? mes_concilia
        {
            get { return m_mes_concilia; }
            set
            {
                m_changed = true;
                m_mes_concilia = value;
            }
        }

        /// <summary>
        /// Attribute for access the movimiento's TIPO_CRUCE value (string)
        /// </summary>
        [DataMember]
        public string TIPO_CRUCE
        {
            get { return m_TIPO_CRUCE; }
            set
            {
                m_changed = true;
                m_TIPO_CRUCE = value;
            }
        }

        /// <summary>
        /// Attribute for access the movimiento's valor_niif value (decimal)
        /// </summary>
        [DataMember]
        public decimal valor_niif
        {
            get { return m_valor_niif; }
            set
            {
                m_changed = true;
                m_valor_niif = value;
            }
        }

        /// <summary>
        /// Attribute for access the movimiento's tipo value (string)
        /// </summary>
        [DataMember]
        public string tipo
        {
            get { return m_tipo; }
            set
            {
                m_changed = true;
                m_tipo = value;
            }
        }

        /// <summary>
        /// Attribute for access the movimiento's numero value (int)
        /// </summary>
        [DataMember]
        public int numero
        {
            get { return m_numero; }
            set
            {
                m_changed = true;
                m_numero = value;
            }
        }

        /// <summary>
        /// Attribute for access the movimiento's seq value (int)
        /// </summary>
        [DataMember]
        public int seq
        {
            get { return m_seq; }
            set
            {
                m_changed = true;
                m_seq = value;
            }
        }

        public object GetAttribute(string pattribute)
        {
            switch (pattribute)
            {
                case "cuenta": return cuenta;
                case "centro": return centro;
                case "nit": return nit;
                case "fec": return fec;
                case "valor": return valor;
                case "documento": return documento;
                case "explicacion": return explicacion;
                case "concilio": return concilio;
                case "concepto_mov": return concepto_mov;
                case "concilio_ano": return concilio_ano;
                case "secuencia_extracto": return secuencia_extracto;
                case "ano_concilia": return ano_concilia;
                case "mes_concilia": return mes_concilia;
                case "TIPO_CRUCE": return TIPO_CRUCE;
                case "valor_niif": return valor_niif;
                case "tipo": return tipo;
                case "numero": return numero;
                case "seq": return seq;
                default: return null;
            }
        }

        public string GetSqlKey()
        {
            return "[tipo] = '" + tipo.ToString() + "'" + " AND [numero] = " + numero.ToString() + " AND [seq] = " + seq.ToString();
        }

        #endregion

    }

    [CollectionDataContract]
    public partial class movimientosList : List<movimientos>
    {
        public movimientosList()
        {
        }
    }


}
