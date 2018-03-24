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
    
    public partial class documentosController//: ILatinodeController
    {
        public documentosController()
        {
        }

        private static documentosController MySingleObj;

        public static documentosController Instance
        {
            get
            {
                if (MySingleObj == null)
                {
                    MySingleObj = new documentosController();
                }
                return MySingleObj;
            }
        }

        private void ReadData(documentos documentos, DataRow dr, bool generateUndo = false)
        {
            try
            {
                documentos.sw = (byte)dr["sw"];
                documentos.nit = (decimal)dr["nit"];
                documentos.fecha = (DateTime)dr["fecha"];
                documentos.condicion = dr.IsNull("condicion") ? null : (string)dr["condicion"];
                documentos.vencimiento = dr.IsNull("vencimiento") ? null : (DateTime?)dr["vencimiento"];
                documentos.valor_total = dr.IsNull("valor_total") ? null : (decimal?)dr["valor_total"];
                documentos.iva = dr.IsNull("iva") ? null : (decimal?)dr["iva"];
                documentos.retencion = dr.IsNull("retencion") ? null : (decimal?)dr["retencion"];
                documentos.retencion_causada = dr.IsNull("retencion_causada") ? null : (decimal?)dr["retencion_causada"];
                documentos.retencion_iva = dr.IsNull("retencion_iva") ? null : (decimal?)dr["retencion_iva"];
                documentos.retencion_ica = dr.IsNull("retencion_ica") ? null : (decimal?)dr["retencion_ica"];
                documentos.descuento_pie = dr.IsNull("descuento_pie") ? null : (decimal?)dr["descuento_pie"];
                documentos.fletes = dr.IsNull("fletes") ? null : (decimal?)dr["fletes"];
                documentos.iva_fletes = dr.IsNull("iva_fletes") ? null : (decimal?)dr["iva_fletes"];
                documentos.costo = dr.IsNull("costo") ? null : (decimal?)dr["costo"];
                documentos.vendedor = dr.IsNull("vendedor") ? null : (decimal?)dr["vendedor"];
                documentos.valor_aplicado = dr.IsNull("valor_aplicado") ? null : (decimal?)dr["valor_aplicado"];
                documentos.anulado = (bool)dr["anulado"];
                documentos.modelo = dr.IsNull("modelo") ? null : (string)dr["modelo"];
                documentos.documento = dr.IsNull("documento") ? null : (string)dr["documento"];
                documentos.notas = dr.IsNull("notas") ? null : (string)dr["notas"];
                documentos.usuario = (string)dr["usuario"];
                documentos.pc = (string)dr["pc"];
                documentos.fecha_hora = (DateTime)dr["fecha_hora"];
                documentos.retencion2 = dr.IsNull("retencion2") ? null : (decimal?)dr["retencion2"];
                documentos.retencion3 = dr.IsNull("retencion3") ? null : (decimal?)dr["retencion3"];
                documentos.bodega = Convert.ToInt16(dr["bodega"]);
                documentos.impoconsumo = dr.IsNull("impoconsumo") ? null : (decimal?)dr["impoconsumo"];
                documentos.descuento2 = dr.IsNull("descuento2") ? null : (decimal?)dr["descuento2"];
                documentos.duracion = dr.IsNull("duracion") ? null : (short?)Convert.ToInt16(dr["duracion"]);
                documentos.concepto = dr.IsNull("concepto") ? null : (short?)Convert.ToInt16(dr["concepto"]);
                documentos.vencimiento_presup = dr.IsNull("vencimiento_presup") ? null : (DateTime?)dr["vencimiento_presup"];
                documentos.exportado = dr.IsNull("exportado") ? null : (char?)((string)dr["exportado"])[0];
                documentos.impuesto_deporte = dr.IsNull("impuesto_deporte") ? null : (decimal?)dr["impuesto_deporte"];
                documentos.prefijo = dr.IsNull("prefijo") ? null : (string)dr["prefijo"];
                documentos.moneda = dr.IsNull("moneda") ? null : (string)dr["moneda"];
                documentos.tasa = dr.IsNull("tasa") ? null : (float?)dr["tasa"];
                documentos.centro_doc = dr.IsNull("centro_doc") ? null : (int?)dr["centro_doc"];
                documentos.valor_mercancia = dr.IsNull("valor_mercancia") ? null : (decimal?)dr["valor_mercancia"];
                documentos.numero_cuotas = dr.IsNull("numero_cuotas") ? null : (short?)Convert.ToInt16(dr["numero_cuotas"]);
                documentos.codigo_direccion = dr.IsNull("codigo_direccion") ? null : (short?)Convert.ToInt16(dr["codigo_direccion"]);
                documentos.descuento_1 = dr.IsNull("descuento_1") ? null : (float?)dr["descuento_1"];
                documentos.descuento_2 = dr.IsNull("descuento_2") ? null : (float?)dr["descuento_2"];
                documentos.descuento_3 = dr.IsNull("descuento_3") ? null : (float?)dr["descuento_3"];
                documentos.abono = dr.IsNull("abono") ? null : (decimal?)dr["abono"];
                documentos.fecha_consignacion = dr.IsNull("fecha_consignacion") ? null : (DateTime?)dr["fecha_consignacion"];
                documentos.Iva_Costo = dr.IsNull("Iva_Costo") ? null : (char?)((string)dr["Iva_Costo"])[0];
                documentos.concepto_Retencion = dr.IsNull("concepto_Retencion") ? null : (short?)Convert.ToInt16(dr["concepto_Retencion"]);
                documentos.porc_RteFuente = dr.IsNull("porc_RteFuente") ? null : (decimal?)dr["porc_RteFuente"];
                documentos.porc_RteIva = dr.IsNull("porc_RteIva") ? null : (decimal?)dr["porc_RteIva"];
                documentos.porc_RteIvaSimpl = dr.IsNull("porc_RteIvaSimpl") ? null : (decimal?)dr["porc_RteIvaSimpl"];
                documentos.porc_RteIca = dr.IsNull("porc_RteIca") ? null : (decimal?)dr["porc_RteIca"];
                documentos.porc_RteA = dr.IsNull("porc_RteA") ? null : (decimal?)dr["porc_RteA"];
                documentos.porc_RteB = dr.IsNull("porc_RteB") ? null : (decimal?)dr["porc_RteB"];
                documentos.bodega_ot = dr.IsNull("bodega_ot") ? null : (short?)Convert.ToInt16(dr["bodega_ot"]);
                documentos.numero_ot = dr.IsNull("numero_ot") ? null : (int?)dr["numero_ot"];
                documentos.provision = dr.IsNull("provision") ? null : (decimal?)dr["provision"];
                documentos.ajuste = dr.IsNull("ajuste") ? null : (decimal?)dr["ajuste"];
                documentos.porc_RteCree = dr.IsNull("porc_RteCree") ? null : (decimal?)dr["porc_RteCree"];
                documentos.retencion_cree = dr.IsNull("retencion_cree") ? null : (decimal?)dr["retencion_cree"];
                documentos.codigo_retencion_cree = dr.IsNull("codigo_retencion_cree") ? null : (string)dr["codigo_retencion_cree"];
                documentos.cree_causado = dr.IsNull("cree_causado") ? null : (decimal?)dr["cree_causado"];
                documentos.ObligacionFinanciera = dr.IsNull("ObligacionFinanciera") ? null : (string)dr["ObligacionFinanciera"];
                documentos.Base_dcto_RC = dr.IsNull("Base_dcto_RC") ? null : (decimal?)dr["Base_dcto_RC"];
                documentos.numincapacidad = dr.IsNull("numincapacidad") ? null : (string)dr["numincapacidad"];
                documentos.idincapacidad = dr.IsNull("idincapacidad") ? null : (int?)dr["idincapacidad"];
                documentos.id = (int)dr["id"];
                documentos.tipo = (string)dr["tipo"];
                documentos.numero = (int)dr["numero"];
            }
            catch (Exception ex)
            {
                Utilidades.LogErrores(ex.Message + (ex.InnerException != null ? ex.InnerException.Message : ""), DataProvider.AplicacionNombre);
                throw ex;
            }
            if (generateUndo) documentos.GenerateUndo();
        }

        private void ReadDataMov(movimientos movimiento, DataRow dr, bool generateUndo = false)
        {
            try
            {
                movimiento.cuenta = (string)dr["cuenta"];
                movimiento.centro = (int)dr["centro"];
                movimiento.nit = (decimal)dr["nit"];
                movimiento.fec = (DateTime)dr["fec"];
                movimiento.valor = (decimal)dr["valor"];
                movimiento.documento = dr.IsNull("documento") ? null : (int?)dr["documento"];
                movimiento.explicacion = dr.IsNull("explicacion") ? null : (string)dr["explicacion"];
                movimiento.concilio = dr.IsNull("concilio") ? null : (string)dr["concilio"];
                movimiento.concepto_mov = dr.IsNull("concepto_mov") ? null : (short?)Convert.ToInt16(dr["concepto_mov"]);
                movimiento.concilio_ano = dr.IsNull("concilio_ano") ? null : (short?)Convert.ToInt16(dr["concilio_ano"]);
                movimiento.secuencia_extracto = dr.IsNull("secuencia_extracto") ? null : (int?)dr["secuencia_extracto"];
                movimiento.ano_concilia = dr.IsNull("ano_concilia") ? null : (int?)dr["ano_concilia"];
                movimiento.mes_concilia = dr.IsNull("mes_concilia") ? null : (int?)dr["mes_concilia"];
                movimiento.TIPO_CRUCE = dr.IsNull("TIPO_CRUCE") ? null : (string)dr["TIPO_CRUCE"];
                movimiento.valor_niif = (decimal)dr["valor_niif"];
                movimiento.tipo = (string)dr["tipo"];
                movimiento.numero = (int)dr["numero"];
                movimiento.seq = (int)dr["seq"];
            }
            catch (Exception ex)
            {
                Utilidades.LogErrores(ex.Message + (ex.InnerException != null ? ex.InnerException.Message : ""), DataProvider.AplicacionNombre);
                throw ex;
            }
            if (generateUndo) movimiento.GenerateUndo();
        }

        public documentos Get(int id, string tipo, int numero, bool generateUndo = false)
        {
            try
            {
                documentos documentos = null;
                DataTable dt = documentosDataProvider.Instance.Get(id, tipo, numero);
                if ((dt.Rows.Count > 0))
                {
                    documentos = new documentos();
                    DataRow dr = dt.Rows[0];
                    ReadData(documentos, dr, generateUndo);
                }


                return documentos;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public documentosList GetAll(bool generateUndo = false)
        {
            try
            {
                documentosList documentoslist = new documentosList();
                DataTable dt = documentosDataProvider.Instance.GetAll();
                foreach (DataRow dr in dt.Rows)
                {
                    documentos documentos = new documentos();
                    ReadData(documentos, dr, generateUndo);
                    documentoslist.Add(documentos);
                }
                return documentoslist;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public documentosList GetBy_TipoNitFechaGetAll(string tipo, string nit, DateTime fechaI, DateTime fechaF , bool generateUndo = false)
        {
            try
            {
                documentosList documentoslist = new documentosList();
                DataTable dt = documentosDataProvider.Instance.GetBy_TipoNitFechaGetAll(tipo, nit, fechaI, fechaF);
                foreach (DataRow dr in dt.Rows)
                {
                    documentos documentos = new documentos();
                    ReadData(documentos, dr, generateUndo);
                    documentoslist.Add(documentos);
                }
                return documentoslist;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }



        public Tuple<documentosList, movimientosList> GetBy_TipoNitFecha(string tipo, string nit, DateTime fechaI, DateTime fechaF, bool generateUndo = false)
        {
            try
            {
                documentosList documentosList = new documentosList();
                movimientosList movimientosList = new movimientosList();
                DataSet ds = documentosDataProvider.Instance.GetBy_TipoNitFecha(tipo, nit, fechaI, fechaF);
                //int countregistros = 0;
                if (ds.Tables.Count > 0)
                {
                    DataTable dt = ds.Tables[0];
                    DataTable dt1 = ds.Tables[1];
                    //movimientos
                    //DataTable dtCount = ds.Tables[1];
                    //countregistros = (int)dtCount.Rows[0]["CantidadRegistros"];
                    foreach (DataRow dr in dt.Rows)
                    {
                        documentos documento = new documentos();
                        ReadData(documento, dr, generateUndo);
                        documentosList.Add(documento);
                    }
                    foreach (DataRow dr1 in dt1.Rows)
                    {
                        movimientos movimiento = new movimientos();
                        ReadDataMov(movimiento, dr1, generateUndo);
                        movimientosList.Add(movimiento);
                    }
                }
                return new Tuple<documentosList, movimientosList>(documentosList, movimientosList);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


    }
}
