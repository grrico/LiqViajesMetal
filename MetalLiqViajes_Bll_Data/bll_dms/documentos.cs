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

        public documentos GetByTipoNumero(string tipo, int numero, bool generateUndo = false)
        {
            try
            {
                documentos documentos = null;
                DataTable dt = documentosDataProvider.Instance.GetByTipoNumero(tipo, numero);
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

        public documentosList GetByRange(string tipo, int numero, int numeroHasta, bool generateUndo = false)
        {
            try
            {
                documentosList documentoslist = new documentosList();
                DataTable dt = documentosDataProvider.Instance.GetByRange(tipo,numero,numeroHasta);
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

        public documentos Create(documentos documentos, Sinapsys.Datos.SQL datosTransaccion = null)
        {
            return Create(documentos.id, documentos.tipo, documentos.numero, documentos.sw, documentos.nit, documentos.fecha, documentos.condicion, documentos.vencimiento, documentos.valor_total, documentos.iva, documentos.retencion, documentos.retencion_causada, documentos.retencion_iva, documentos.retencion_ica, documentos.descuento_pie, documentos.fletes, documentos.iva_fletes, documentos.costo, documentos.vendedor, documentos.valor_aplicado, documentos.anulado, documentos.modelo, documentos.documento, documentos.notas, documentos.usuario, documentos.pc, documentos.fecha_hora, documentos.retencion2, documentos.retencion3, documentos.bodega, documentos.impoconsumo, documentos.descuento2, documentos.duracion, documentos.concepto, documentos.vencimiento_presup, documentos.exportado, documentos.impuesto_deporte, documentos.prefijo, documentos.moneda, documentos.tasa, documentos.centro_doc, documentos.valor_mercancia, documentos.numero_cuotas, documentos.codigo_direccion, documentos.descuento_1, documentos.descuento_2, documentos.descuento_3, documentos.abono, documentos.fecha_consignacion, documentos.Iva_Costo, documentos.concepto_Retencion, documentos.porc_RteFuente, documentos.porc_RteIva, documentos.porc_RteIvaSimpl, documentos.porc_RteIca, documentos.porc_RteA, documentos.porc_RteB, documentos.bodega_ot, documentos.numero_ot, documentos.provision, documentos.ajuste, documentos.porc_RteCree, documentos.retencion_cree, documentos.codigo_retencion_cree, documentos.cree_causado, documentos.ObligacionFinanciera, documentos.Base_dcto_RC, documentos.numincapacidad, documentos.idincapacidad, datosTransaccion);
        }

        public documentos Create(int id, string tipo, int numero, byte sw, decimal nit, DateTime fecha, string condicion, DateTime? vencimiento, decimal? valor_total, decimal? iva, decimal? retencion, decimal? retencion_causada, decimal? retencion_iva, decimal? retencion_ica, decimal? descuento_pie, decimal? fletes, decimal? iva_fletes, decimal? costo, decimal? vendedor, decimal? valor_aplicado, bool anulado, string modelo, string documento, string notas, string usuario, string pc, DateTime fecha_hora, decimal? retencion2, decimal? retencion3, short bodega, decimal? impoconsumo, decimal? descuento2, short? duracion, short? concepto, DateTime? vencimiento_presup, char? exportado, decimal? impuesto_deporte, string prefijo, string moneda, float? tasa, int? centro_doc, decimal? valor_mercancia, short? numero_cuotas, short? codigo_direccion, float? descuento_1, float? descuento_2, float? descuento_3, decimal? abono, DateTime? fecha_consignacion, char? Iva_Costo, short? concepto_Retencion, decimal? porc_RteFuente, decimal? porc_RteIva, decimal? porc_RteIvaSimpl, decimal? porc_RteIca, decimal? porc_RteA, decimal? porc_RteB, short? bodega_ot, int? numero_ot, decimal? provision, decimal? ajuste, decimal? porc_RteCree, decimal? retencion_cree, string codigo_retencion_cree, decimal? cree_causado, string ObligacionFinanciera, decimal? Base_dcto_RC, string numincapacidad, int? idincapacidad, Sinapsys.Datos.SQL datosTransaccion = null)
        {
            try
            {
                documentos documentos = new documentos();

                documentos.id = id;
                documentos.id = id;
                documentos.tipo = tipo;
                documentos.numero = numero;
                documentos.sw = sw;
                documentos.nit = nit;
                documentos.fecha = fecha;
                documentos.condicion = condicion;
                documentos.vencimiento = vencimiento;
                documentos.valor_total = valor_total;
                documentos.iva = iva;
                documentos.retencion = retencion;
                documentos.retencion_causada = retencion_causada;
                documentos.retencion_iva = retencion_iva;
                documentos.retencion_ica = retencion_ica;
                documentos.descuento_pie = descuento_pie;
                documentos.fletes = fletes;
                documentos.iva_fletes = iva_fletes;
                documentos.costo = costo;
                documentos.vendedor = vendedor;
                documentos.valor_aplicado = valor_aplicado;
                documentos.anulado = anulado;
                documentos.modelo = modelo;
                documentos.documento = documento;
                documentos.notas = notas;
                documentos.usuario = usuario;
                documentos.pc = pc;
                documentos.fecha_hora = fecha_hora;
                documentos.retencion2 = retencion2;
                documentos.retencion3 = retencion3;
                documentos.bodega = bodega;
                documentos.impoconsumo = impoconsumo;
                documentos.descuento2 = descuento2;
                documentos.duracion = duracion;
                documentos.concepto = concepto;
                documentos.vencimiento_presup = vencimiento_presup;
                documentos.exportado = exportado;
                documentos.impuesto_deporte = impuesto_deporte;
                documentos.prefijo = prefijo;
                documentos.moneda = moneda;
                documentos.tasa = tasa;
                documentos.centro_doc = centro_doc;
                documentos.valor_mercancia = valor_mercancia;
                documentos.numero_cuotas = numero_cuotas;
                documentos.codigo_direccion = codigo_direccion;
                documentos.descuento_1 = descuento_1;
                documentos.descuento_2 = descuento_2;
                documentos.descuento_3 = descuento_3;
                documentos.abono = abono;
                documentos.fecha_consignacion = fecha_consignacion;
                documentos.Iva_Costo = Iva_Costo;
                documentos.concepto_Retencion = concepto_Retencion;
                documentos.porc_RteFuente = porc_RteFuente;
                documentos.porc_RteIva = porc_RteIva;
                documentos.porc_RteIvaSimpl = porc_RteIvaSimpl;
                documentos.porc_RteIca = porc_RteIca;
                documentos.porc_RteA = porc_RteA;
                documentos.porc_RteB = porc_RteB;
                documentos.bodega_ot = bodega_ot;
                documentos.numero_ot = numero_ot;
                documentos.provision = provision;
                documentos.ajuste = ajuste;
                documentos.porc_RteCree = porc_RteCree;
                documentos.retencion_cree = retencion_cree;
                documentos.codigo_retencion_cree = codigo_retencion_cree;
                documentos.cree_causado = cree_causado;
                documentos.ObligacionFinanciera = ObligacionFinanciera;
                documentos.Base_dcto_RC = Base_dcto_RC;
                documentos.numincapacidad = numincapacidad;
                documentos.idincapacidad = idincapacidad;
                id = documentosDataProvider.Instance.Create(id, tipo, numero, sw, nit, fecha, condicion, vencimiento, valor_total, iva, retencion, retencion_causada, retencion_iva, retencion_ica, descuento_pie, fletes, iva_fletes, costo, vendedor, valor_aplicado, anulado, modelo, documento, notas, usuario, pc, fecha_hora, retencion2, retencion3, bodega, impoconsumo, descuento2, duracion, concepto, vencimiento_presup, exportado, impuesto_deporte, prefijo, moneda, tasa, centro_doc, valor_mercancia, numero_cuotas, codigo_direccion, descuento_1, descuento_2, descuento_3, abono, fecha_consignacion, Iva_Costo, concepto_Retencion, porc_RteFuente, porc_RteIva, porc_RteIvaSimpl, porc_RteIca, porc_RteA, porc_RteB, bodega_ot, numero_ot, provision, ajuste, porc_RteCree, retencion_cree, codigo_retencion_cree, cree_causado, ObligacionFinanciera, Base_dcto_RC, numincapacidad, idincapacidad, "documentos", datosTransaccion);
                if (id == 0)
                    return null;

                documentos.id = id;

                return documentos;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


    }
}
