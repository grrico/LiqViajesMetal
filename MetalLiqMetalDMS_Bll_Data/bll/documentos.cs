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

namespace LiqMetalDMS_Bll_Data
{
	#region documentosController

	/// <summary>
	/// Class for convert data from database into object's data and vice versa
	/// </summary>
	public partial class documentosController//: ILatinodeController
	{
		/// <summary>
		/// Generic Constructor
		/// </summary>
		public documentosController()
		{
		}

		/// <summary>
		/// Instance accessor for this singleton
		/// </summary>
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

		// Reads object's data from a DataRow
		private void ReadData(documentos documentos, DataRow dr,bool generateUndo=false)
		{
			try 
			{
				documentos.id = (int) dr["id"];
				documentos.sw = (byte) dr["sw"];
				documentos.tipo = (string) dr["tipo"];
				documentos.numero = (int) dr["numero"];
				documentos.nit = (decimal) dr["nit"];
				documentos.fecha = (DateTime) dr["fecha"];
				documentos.condicion = dr.IsNull("condicion") ? null :(string) dr["condicion"];
				documentos.vencimiento = dr.IsNull("vencimiento") ? null :(DateTime?) dr["vencimiento"];
				documentos.valor_total = dr.IsNull("valor_total") ? null :(decimal?) dr["valor_total"];
				documentos.iva = dr.IsNull("iva") ? null :(decimal?) dr["iva"];
				documentos.retencion = dr.IsNull("retencion") ? null :(decimal?) dr["retencion"];
				documentos.retencion_causada = dr.IsNull("retencion_causada") ? null :(decimal?) dr["retencion_causada"];
				documentos.retencion_iva = dr.IsNull("retencion_iva") ? null :(decimal?) dr["retencion_iva"];
				documentos.retencion_ica = dr.IsNull("retencion_ica") ? null :(decimal?) dr["retencion_ica"];
				documentos.descuento_pie = dr.IsNull("descuento_pie") ? null :(decimal?) dr["descuento_pie"];
				documentos.fletes = dr.IsNull("fletes") ? null :(decimal?) dr["fletes"];
				documentos.iva_fletes = dr.IsNull("iva_fletes") ? null :(decimal?) dr["iva_fletes"];
				documentos.costo = dr.IsNull("costo") ? null :(decimal?) dr["costo"];
				documentos.vendedor = dr.IsNull("vendedor") ? null :(decimal?) dr["vendedor"];
				documentos.valor_aplicado = dr.IsNull("valor_aplicado") ? null :(decimal?) dr["valor_aplicado"];
				documentos.anulado = (bool) dr["anulado"];
				documentos.modelo = dr.IsNull("modelo") ? null :(string) dr["modelo"];
				documentos.documento = dr.IsNull("documento") ? null :(string) dr["documento"];
				documentos.notas = dr.IsNull("notas") ? null :(string) dr["notas"];
				documentos.usuario = (string) dr["usuario"];
				documentos.pc = (string) dr["pc"];
				documentos.fecha_hora = (DateTime) dr["fecha_hora"];
				documentos.retencion2 = dr.IsNull("retencion2") ? null :(decimal?) dr["retencion2"];
				documentos.retencion3 = dr.IsNull("retencion3") ? null :(decimal?) dr["retencion3"];
				documentos.bodega = Convert.ToInt16(dr["bodega"]);
				documentos.impoconsumo = dr.IsNull("impoconsumo") ? null :(decimal?) dr["impoconsumo"];
				documentos.descuento2 = dr.IsNull("descuento2") ? null :(decimal?) dr["descuento2"];
				documentos.duracion = dr.IsNull("duracion") ? null :(short?)Convert.ToInt16(dr["duracion"]);
				documentos.concepto = dr.IsNull("concepto") ? null :(short?)Convert.ToInt16(dr["concepto"]);
				documentos.vencimiento_presup = dr.IsNull("vencimiento_presup") ? null :(DateTime?) dr["vencimiento_presup"];
				documentos.exportado = dr.IsNull("exportado") ? null :(char?) ((string) dr["exportado"])[0];
				documentos.impuesto_deporte = dr.IsNull("impuesto_deporte") ? null :(decimal?) dr["impuesto_deporte"];
				documentos.prefijo = dr.IsNull("prefijo") ? null :(string) dr["prefijo"];
				documentos.moneda = dr.IsNull("moneda") ? null :(string) dr["moneda"];
				documentos.tasa = dr.IsNull("tasa") ? null :(float?) dr["tasa"];
				documentos.centro_doc = dr.IsNull("centro_doc") ? null :(int?) dr["centro_doc"];
				documentos.valor_mercancia = dr.IsNull("valor_mercancia") ? null :(decimal?) dr["valor_mercancia"];
				documentos.numero_cuotas = dr.IsNull("numero_cuotas") ? null :(short?)Convert.ToInt16(dr["numero_cuotas"]);
				documentos.codigo_direccion = dr.IsNull("codigo_direccion") ? null :(short?)Convert.ToInt16(dr["codigo_direccion"]);
				documentos.descuento_1 = dr.IsNull("descuento_1") ? null :(float?) dr["descuento_1"];
				documentos.descuento_2 = dr.IsNull("descuento_2") ? null :(float?) dr["descuento_2"];
				documentos.descuento_3 = dr.IsNull("descuento_3") ? null :(float?) dr["descuento_3"];
				documentos.abono = dr.IsNull("abono") ? null :(decimal?) dr["abono"];
				documentos.fecha_consignacion = dr.IsNull("fecha_consignacion") ? null :(DateTime?) dr["fecha_consignacion"];
				documentos.Iva_Costo = dr.IsNull("Iva_Costo") ? null :(char?) ((string) dr["Iva_Costo"])[0];
				documentos.concepto_Retencion = dr.IsNull("concepto_Retencion") ? null :(short?)Convert.ToInt16(dr["concepto_Retencion"]);
				documentos.porc_RteFuente = dr.IsNull("porc_RteFuente") ? null :(decimal?) dr["porc_RteFuente"];
				documentos.porc_RteIva = dr.IsNull("porc_RteIva") ? null :(decimal?) dr["porc_RteIva"];
				documentos.porc_RteIvaSimpl = dr.IsNull("porc_RteIvaSimpl") ? null :(decimal?) dr["porc_RteIvaSimpl"];
				documentos.porc_RteIca = dr.IsNull("porc_RteIca") ? null :(decimal?) dr["porc_RteIca"];
				documentos.porc_RteA = dr.IsNull("porc_RteA") ? null :(decimal?) dr["porc_RteA"];
				documentos.porc_RteB = dr.IsNull("porc_RteB") ? null :(decimal?) dr["porc_RteB"];
				documentos.bodega_ot = dr.IsNull("bodega_ot") ? null :(short?)Convert.ToInt16(dr["bodega_ot"]);
				documentos.numero_ot = dr.IsNull("numero_ot") ? null :(int?) dr["numero_ot"];
				documentos.provision = dr.IsNull("provision") ? null :(decimal?) dr["provision"];
				documentos.ajuste = dr.IsNull("ajuste") ? null :(decimal?) dr["ajuste"];
				documentos.porc_RteCree = dr.IsNull("porc_RteCree") ? null :(decimal?) dr["porc_RteCree"];
				documentos.retencion_cree = dr.IsNull("retencion_cree") ? null :(decimal?) dr["retencion_cree"];
				documentos.codigo_retencion_cree = dr.IsNull("codigo_retencion_cree") ? null :(string) dr["codigo_retencion_cree"];
				documentos.cree_causado = dr.IsNull("cree_causado") ? null :(decimal?) dr["cree_causado"];
				documentos.ObligacionFinanciera = dr.IsNull("ObligacionFinanciera") ? null :(string) dr["ObligacionFinanciera"];
				documentos.Base_dcto_RC = dr.IsNull("Base_dcto_RC") ? null :(decimal?) dr["Base_dcto_RC"];
				documentos.numincapacidad = dr.IsNull("numincapacidad") ? null :(string) dr["numincapacidad"];
				documentos.idincapacidad = dr.IsNull("idincapacidad") ? null :(int?) dr["idincapacidad"];
			}
			catch (Exception ex)
			{
				Utilidades.LogErrores(ex.Message + (ex.InnerException != null ? ex.InnerException.Message : ""), DataProvider.AplicacionNombre);
				throw ex;
			}
			if (generateUndo) documentos.GenerateUndo();
		}

		/// <summary>
		/// Create a new documentos object by passing a object
		/// </summary>
		public documentos Create(documentos documentos, Sinapsys.Datos.SQL datosTransaccion=null)
		{
			return Create(documentos.id,documentos.tipo,documentos.numero,documentos.sw,documentos.nit,documentos.fecha,documentos.condicion,documentos.vencimiento,documentos.valor_total,documentos.iva,documentos.retencion,documentos.retencion_causada,documentos.retencion_iva,documentos.retencion_ica,documentos.descuento_pie,documentos.fletes,documentos.iva_fletes,documentos.costo,documentos.vendedor,documentos.valor_aplicado,documentos.anulado,documentos.modelo,documentos.documento,documentos.notas,documentos.usuario,documentos.pc,documentos.fecha_hora,documentos.retencion2,documentos.retencion3,documentos.bodega,documentos.impoconsumo,documentos.descuento2,documentos.duracion,documentos.concepto,documentos.vencimiento_presup,documentos.exportado,documentos.impuesto_deporte,documentos.prefijo,documentos.moneda,documentos.tasa,documentos.centro_doc,documentos.valor_mercancia,documentos.numero_cuotas,documentos.codigo_direccion,documentos.descuento_1,documentos.descuento_2,documentos.descuento_3,documentos.abono,documentos.fecha_consignacion,documentos.Iva_Costo,documentos.concepto_Retencion,documentos.porc_RteFuente,documentos.porc_RteIva,documentos.porc_RteIvaSimpl,documentos.porc_RteIca,documentos.porc_RteA,documentos.porc_RteB,documentos.bodega_ot,documentos.numero_ot,documentos.provision,documentos.ajuste,documentos.porc_RteCree,documentos.retencion_cree,documentos.codigo_retencion_cree,documentos.cree_causado,documentos.ObligacionFinanciera,documentos.Base_dcto_RC,documentos.numincapacidad,documentos.idincapacidad,datosTransaccion);
		}

		/// <summary>
		/// Creates a new documentos object by passing all object's fields
		/// </summary>
		/// <param name="sw">byte that contents the sw value for the documentos object</param>
		/// <param name="nit">decimal that contents the nit value for the documentos object</param>
		/// <param name="fecha">DateTime that contents the fecha value for the documentos object</param>
		/// <param name="condicion">string that contents the condicion value for the documentos object</param>
		/// <param name="vencimiento">DateTime that contents the vencimiento value for the documentos object</param>
		/// <param name="valor_total">decimal that contents the valor_total value for the documentos object</param>
		/// <param name="iva">decimal that contents the iva value for the documentos object</param>
		/// <param name="retencion">decimal that contents the retencion value for the documentos object</param>
		/// <param name="retencion_causada">decimal that contents the retencion_causada value for the documentos object</param>
		/// <param name="retencion_iva">decimal that contents the retencion_iva value for the documentos object</param>
		/// <param name="retencion_ica">decimal that contents the retencion_ica value for the documentos object</param>
		/// <param name="descuento_pie">decimal that contents the descuento_pie value for the documentos object</param>
		/// <param name="fletes">decimal that contents the fletes value for the documentos object</param>
		/// <param name="iva_fletes">decimal that contents the iva_fletes value for the documentos object</param>
		/// <param name="costo">decimal that contents the costo value for the documentos object</param>
		/// <param name="vendedor">decimal that contents the vendedor value for the documentos object</param>
		/// <param name="valor_aplicado">decimal that contents the valor_aplicado value for the documentos object</param>
		/// <param name="anulado">bool that contents the anulado value for the documentos object</param>
		/// <param name="modelo">string that contents the modelo value for the documentos object</param>
		/// <param name="documento">string that contents the documento value for the documentos object</param>
		/// <param name="notas">string that contents the notas value for the documentos object</param>
		/// <param name="usuario">string that contents the usuario value for the documentos object</param>
		/// <param name="pc">string that contents the pc value for the documentos object</param>
		/// <param name="fecha_hora">DateTime that contents the fecha_hora value for the documentos object</param>
		/// <param name="retencion2">decimal that contents the retencion2 value for the documentos object</param>
		/// <param name="retencion3">decimal that contents the retencion3 value for the documentos object</param>
		/// <param name="bodega">short that contents the bodega value for the documentos object</param>
		/// <param name="impoconsumo">decimal that contents the impoconsumo value for the documentos object</param>
		/// <param name="descuento2">decimal that contents the descuento2 value for the documentos object</param>
		/// <param name="duracion">short that contents the duracion value for the documentos object</param>
		/// <param name="concepto">short that contents the concepto value for the documentos object</param>
		/// <param name="vencimiento_presup">DateTime that contents the vencimiento_presup value for the documentos object</param>
		/// <param name="exportado">char that contents the exportado value for the documentos object</param>
		/// <param name="impuesto_deporte">decimal that contents the impuesto_deporte value for the documentos object</param>
		/// <param name="prefijo">string that contents the prefijo value for the documentos object</param>
		/// <param name="moneda">string that contents the moneda value for the documentos object</param>
		/// <param name="tasa">float that contents the tasa value for the documentos object</param>
		/// <param name="centro_doc">int that contents the centro_doc value for the documentos object</param>
		/// <param name="valor_mercancia">decimal that contents the valor_mercancia value for the documentos object</param>
		/// <param name="numero_cuotas">short that contents the numero_cuotas value for the documentos object</param>
		/// <param name="codigo_direccion">short that contents the codigo_direccion value for the documentos object</param>
		/// <param name="descuento_1">float that contents the descuento_1 value for the documentos object</param>
		/// <param name="descuento_2">float that contents the descuento_2 value for the documentos object</param>
		/// <param name="descuento_3">float that contents the descuento_3 value for the documentos object</param>
		/// <param name="abono">decimal that contents the abono value for the documentos object</param>
		/// <param name="fecha_consignacion">DateTime that contents the fecha_consignacion value for the documentos object</param>
		/// <param name="Iva_Costo">char that contents the Iva_Costo value for the documentos object</param>
		/// <param name="concepto_Retencion">short that contents the concepto_Retencion value for the documentos object</param>
		/// <param name="porc_RteFuente">decimal that contents the porc_RteFuente value for the documentos object</param>
		/// <param name="porc_RteIva">decimal that contents the porc_RteIva value for the documentos object</param>
		/// <param name="porc_RteIvaSimpl">decimal that contents the porc_RteIvaSimpl value for the documentos object</param>
		/// <param name="porc_RteIca">decimal that contents the porc_RteIca value for the documentos object</param>
		/// <param name="porc_RteA">decimal that contents the porc_RteA value for the documentos object</param>
		/// <param name="porc_RteB">decimal that contents the porc_RteB value for the documentos object</param>
		/// <param name="bodega_ot">short that contents the bodega_ot value for the documentos object</param>
		/// <param name="numero_ot">int that contents the numero_ot value for the documentos object</param>
		/// <param name="provision">decimal that contents the provision value for the documentos object</param>
		/// <param name="ajuste">decimal that contents the ajuste value for the documentos object</param>
		/// <param name="porc_RteCree">decimal that contents the porc_RteCree value for the documentos object</param>
		/// <param name="retencion_cree">decimal that contents the retencion_cree value for the documentos object</param>
		/// <param name="codigo_retencion_cree">string that contents the codigo_retencion_cree value for the documentos object</param>
		/// <param name="cree_causado">decimal that contents the cree_causado value for the documentos object</param>
		/// <param name="ObligacionFinanciera">string that contents the ObligacionFinanciera value for the documentos object</param>
		/// <param name="Base_dcto_RC">decimal that contents the Base_dcto_RC value for the documentos object</param>
		/// <param name="numincapacidad">string that contents the numincapacidad value for the documentos object</param>
		/// <param name="idincapacidad">int that contents the idincapacidad value for the documentos object</param>
		/// <returns>One documentos object</returns>
		public documentos Create(int id, string tipo, int numero, byte sw, decimal nit, DateTime fecha, string condicion, DateTime? vencimiento, decimal? valor_total, decimal? iva, decimal? retencion, decimal? retencion_causada, decimal? retencion_iva, decimal? retencion_ica, decimal? descuento_pie, decimal? fletes, decimal? iva_fletes, decimal? costo, decimal? vendedor, decimal? valor_aplicado, bool anulado, string modelo, string documento, string notas, string usuario, string pc, DateTime fecha_hora, decimal? retencion2, decimal? retencion3, short bodega, decimal? impoconsumo, decimal? descuento2, short? duracion, short? concepto, DateTime? vencimiento_presup, char? exportado, decimal? impuesto_deporte, string prefijo, string moneda, float? tasa, int? centro_doc, decimal? valor_mercancia, short? numero_cuotas, short? codigo_direccion, float? descuento_1, float? descuento_2, float? descuento_3, decimal? abono, DateTime? fecha_consignacion, char? Iva_Costo, short? concepto_Retencion, decimal? porc_RteFuente, decimal? porc_RteIva, decimal? porc_RteIvaSimpl, decimal? porc_RteIca, decimal? porc_RteA, decimal? porc_RteB, short? bodega_ot, int? numero_ot, decimal? provision, decimal? ajuste, decimal? porc_RteCree, decimal? retencion_cree, string codigo_retencion_cree, decimal? cree_causado, string ObligacionFinanciera, decimal? Base_dcto_RC, string numincapacidad, int? idincapacidad, Sinapsys.Datos.SQL datosTransaccion=null)
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
				id = documentosDataProvider.Instance.Create(id, tipo, numero, sw, nit, fecha, condicion, vencimiento, valor_total, iva, retencion, retencion_causada, retencion_iva, retencion_ica, descuento_pie, fletes, iva_fletes, costo, vendedor, valor_aplicado, anulado, modelo, documento, notas, usuario, pc, fecha_hora, retencion2, retencion3, bodega, impoconsumo, descuento2, duracion, concepto, vencimiento_presup, exportado, impuesto_deporte, prefijo, moneda, tasa, centro_doc, valor_mercancia, numero_cuotas, codigo_direccion, descuento_1, descuento_2, descuento_3, abono, fecha_consignacion, Iva_Costo, concepto_Retencion, porc_RteFuente, porc_RteIva, porc_RteIvaSimpl, porc_RteIca, porc_RteA, porc_RteB, bodega_ot, numero_ot, provision, ajuste, porc_RteCree, retencion_cree, codigo_retencion_cree, cree_causado, ObligacionFinanciera, Base_dcto_RC, numincapacidad, idincapacidad,"documentos",datosTransaccion);
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

		/// <summary>
		/// Updates an documentos object by passing all object's fields
		/// </summary>
		/// <param name="id">int that contents the id value for the documentos object</param>
		/// <param name="sw">byte that contents the sw value for the documentos object</param>
		/// <param name="tipo">string that contents the tipo value for the documentos object</param>
		/// <param name="numero">int that contents the numero value for the documentos object</param>
		/// <param name="nit">decimal that contents the nit value for the documentos object</param>
		/// <param name="fecha">DateTime that contents the fecha value for the documentos object</param>
		/// <param name="condicion">string that contents the condicion value for the documentos object</param>
		/// <param name="vencimiento">DateTime that contents the vencimiento value for the documentos object</param>
		/// <param name="valor_total">decimal that contents the valor_total value for the documentos object</param>
		/// <param name="iva">decimal that contents the iva value for the documentos object</param>
		/// <param name="retencion">decimal that contents the retencion value for the documentos object</param>
		/// <param name="retencion_causada">decimal that contents the retencion_causada value for the documentos object</param>
		/// <param name="retencion_iva">decimal that contents the retencion_iva value for the documentos object</param>
		/// <param name="retencion_ica">decimal that contents the retencion_ica value for the documentos object</param>
		/// <param name="descuento_pie">decimal that contents the descuento_pie value for the documentos object</param>
		/// <param name="fletes">decimal that contents the fletes value for the documentos object</param>
		/// <param name="iva_fletes">decimal that contents the iva_fletes value for the documentos object</param>
		/// <param name="costo">decimal that contents the costo value for the documentos object</param>
		/// <param name="vendedor">decimal that contents the vendedor value for the documentos object</param>
		/// <param name="valor_aplicado">decimal that contents the valor_aplicado value for the documentos object</param>
		/// <param name="anulado">bool that contents the anulado value for the documentos object</param>
		/// <param name="modelo">string that contents the modelo value for the documentos object</param>
		/// <param name="documento">string that contents the documento value for the documentos object</param>
		/// <param name="notas">string that contents the notas value for the documentos object</param>
		/// <param name="usuario">string that contents the usuario value for the documentos object</param>
		/// <param name="pc">string that contents the pc value for the documentos object</param>
		/// <param name="fecha_hora">DateTime that contents the fecha_hora value for the documentos object</param>
		/// <param name="retencion2">decimal that contents the retencion2 value for the documentos object</param>
		/// <param name="retencion3">decimal that contents the retencion3 value for the documentos object</param>
		/// <param name="bodega">short that contents the bodega value for the documentos object</param>
		/// <param name="impoconsumo">decimal that contents the impoconsumo value for the documentos object</param>
		/// <param name="descuento2">decimal that contents the descuento2 value for the documentos object</param>
		/// <param name="duracion">short that contents the duracion value for the documentos object</param>
		/// <param name="concepto">short that contents the concepto value for the documentos object</param>
		/// <param name="vencimiento_presup">DateTime that contents the vencimiento_presup value for the documentos object</param>
		/// <param name="exportado">char that contents the exportado value for the documentos object</param>
		/// <param name="impuesto_deporte">decimal that contents the impuesto_deporte value for the documentos object</param>
		/// <param name="prefijo">string that contents the prefijo value for the documentos object</param>
		/// <param name="moneda">string that contents the moneda value for the documentos object</param>
		/// <param name="tasa">float that contents the tasa value for the documentos object</param>
		/// <param name="centro_doc">int that contents the centro_doc value for the documentos object</param>
		/// <param name="valor_mercancia">decimal that contents the valor_mercancia value for the documentos object</param>
		/// <param name="numero_cuotas">short that contents the numero_cuotas value for the documentos object</param>
		/// <param name="codigo_direccion">short that contents the codigo_direccion value for the documentos object</param>
		/// <param name="descuento_1">float that contents the descuento_1 value for the documentos object</param>
		/// <param name="descuento_2">float that contents the descuento_2 value for the documentos object</param>
		/// <param name="descuento_3">float that contents the descuento_3 value for the documentos object</param>
		/// <param name="abono">decimal that contents the abono value for the documentos object</param>
		/// <param name="fecha_consignacion">DateTime that contents the fecha_consignacion value for the documentos object</param>
		/// <param name="Iva_Costo">char that contents the Iva_Costo value for the documentos object</param>
		/// <param name="concepto_Retencion">short that contents the concepto_Retencion value for the documentos object</param>
		/// <param name="porc_RteFuente">decimal that contents the porc_RteFuente value for the documentos object</param>
		/// <param name="porc_RteIva">decimal that contents the porc_RteIva value for the documentos object</param>
		/// <param name="porc_RteIvaSimpl">decimal that contents the porc_RteIvaSimpl value for the documentos object</param>
		/// <param name="porc_RteIca">decimal that contents the porc_RteIca value for the documentos object</param>
		/// <param name="porc_RteA">decimal that contents the porc_RteA value for the documentos object</param>
		/// <param name="porc_RteB">decimal that contents the porc_RteB value for the documentos object</param>
		/// <param name="bodega_ot">short that contents the bodega_ot value for the documentos object</param>
		/// <param name="numero_ot">int that contents the numero_ot value for the documentos object</param>
		/// <param name="provision">decimal that contents the provision value for the documentos object</param>
		/// <param name="ajuste">decimal that contents the ajuste value for the documentos object</param>
		/// <param name="porc_RteCree">decimal that contents the porc_RteCree value for the documentos object</param>
		/// <param name="retencion_cree">decimal that contents the retencion_cree value for the documentos object</param>
		/// <param name="codigo_retencion_cree">string that contents the codigo_retencion_cree value for the documentos object</param>
		/// <param name="cree_causado">decimal that contents the cree_causado value for the documentos object</param>
		/// <param name="ObligacionFinanciera">string that contents the ObligacionFinanciera value for the documentos object</param>
		/// <param name="Base_dcto_RC">decimal that contents the Base_dcto_RC value for the documentos object</param>
		/// <param name="numincapacidad">string that contents the numincapacidad value for the documentos object</param>
		/// <param name="idincapacidad">int that contents the idincapacidad value for the documentos object</param>
		public void Update(int id, byte sw, string tipo, int numero, decimal nit, DateTime fecha, string condicion, DateTime? vencimiento, decimal? valor_total, decimal? iva, decimal? retencion, decimal? retencion_causada, decimal? retencion_iva, decimal? retencion_ica, decimal? descuento_pie, decimal? fletes, decimal? iva_fletes, decimal? costo, decimal? vendedor, decimal? valor_aplicado, bool anulado, string modelo, string documento, string notas, string usuario, string pc, DateTime fecha_hora, decimal? retencion2, decimal? retencion3, short bodega, decimal? impoconsumo, decimal? descuento2, short? duracion, short? concepto, DateTime? vencimiento_presup, char? exportado, decimal? impuesto_deporte, string prefijo, string moneda, float? tasa, int? centro_doc, decimal? valor_mercancia, short? numero_cuotas, short? codigo_direccion, float? descuento_1, float? descuento_2, float? descuento_3, decimal? abono, DateTime? fecha_consignacion, char? Iva_Costo, short? concepto_Retencion, decimal? porc_RteFuente, decimal? porc_RteIva, decimal? porc_RteIvaSimpl, decimal? porc_RteIca, decimal? porc_RteA, decimal? porc_RteB, short? bodega_ot, int? numero_ot, decimal? provision, decimal? ajuste, decimal? porc_RteCree, decimal? retencion_cree, string codigo_retencion_cree, decimal? cree_causado, string ObligacionFinanciera, decimal? Base_dcto_RC, string numincapacidad, int? idincapacidad, Sinapsys.Datos.SQL datosTransaccion=null)
		{
			try 
			{
				documentos new_values = new documentos();
				new_values.sw = sw;
				new_values.nit = nit;
				new_values.fecha = fecha;
				new_values.condicion = condicion;
				new_values.vencimiento = vencimiento;
				new_values.valor_total = valor_total;
				new_values.iva = iva;
				new_values.retencion = retencion;
				new_values.retencion_causada = retencion_causada;
				new_values.retencion_iva = retencion_iva;
				new_values.retencion_ica = retencion_ica;
				new_values.descuento_pie = descuento_pie;
				new_values.fletes = fletes;
				new_values.iva_fletes = iva_fletes;
				new_values.costo = costo;
				new_values.vendedor = vendedor;
				new_values.valor_aplicado = valor_aplicado;
				new_values.anulado = anulado;
				new_values.modelo = modelo;
				new_values.documento = documento;
				new_values.notas = notas;
				new_values.usuario = usuario;
				new_values.pc = pc;
				new_values.fecha_hora = fecha_hora;
				new_values.retencion2 = retencion2;
				new_values.retencion3 = retencion3;
				new_values.bodega = bodega;
				new_values.impoconsumo = impoconsumo;
				new_values.descuento2 = descuento2;
				new_values.duracion = duracion;
				new_values.concepto = concepto;
				new_values.vencimiento_presup = vencimiento_presup;
				new_values.exportado = exportado;
				new_values.impuesto_deporte = impuesto_deporte;
				new_values.prefijo = prefijo;
				new_values.moneda = moneda;
				new_values.tasa = tasa;
				new_values.centro_doc = centro_doc;
				new_values.valor_mercancia = valor_mercancia;
				new_values.numero_cuotas = numero_cuotas;
				new_values.codigo_direccion = codigo_direccion;
				new_values.descuento_1 = descuento_1;
				new_values.descuento_2 = descuento_2;
				new_values.descuento_3 = descuento_3;
				new_values.abono = abono;
				new_values.fecha_consignacion = fecha_consignacion;
				new_values.Iva_Costo = Iva_Costo;
				new_values.concepto_Retencion = concepto_Retencion;
				new_values.porc_RteFuente = porc_RteFuente;
				new_values.porc_RteIva = porc_RteIva;
				new_values.porc_RteIvaSimpl = porc_RteIvaSimpl;
				new_values.porc_RteIca = porc_RteIca;
				new_values.porc_RteA = porc_RteA;
				new_values.porc_RteB = porc_RteB;
				new_values.bodega_ot = bodega_ot;
				new_values.numero_ot = numero_ot;
				new_values.provision = provision;
				new_values.ajuste = ajuste;
				new_values.porc_RteCree = porc_RteCree;
				new_values.retencion_cree = retencion_cree;
				new_values.codigo_retencion_cree = codigo_retencion_cree;
				new_values.cree_causado = cree_causado;
				new_values.ObligacionFinanciera = ObligacionFinanciera;
				new_values.Base_dcto_RC = Base_dcto_RC;
				new_values.numincapacidad = numincapacidad;
				new_values.idincapacidad = idincapacidad;
				documentosDataProvider.Instance.Update(id, sw, tipo, numero, nit, fecha, condicion, vencimiento, valor_total, iva, retencion, retencion_causada, retencion_iva, retencion_ica, descuento_pie, fletes, iva_fletes, costo, vendedor, valor_aplicado, anulado, modelo, documento, notas, usuario, pc, fecha_hora, retencion2, retencion3, bodega, impoconsumo, descuento2, duracion, concepto, vencimiento_presup, exportado, impuesto_deporte, prefijo, moneda, tasa, centro_doc, valor_mercancia, numero_cuotas, codigo_direccion, descuento_1, descuento_2, descuento_3, abono, fecha_consignacion, Iva_Costo, concepto_Retencion, porc_RteFuente, porc_RteIva, porc_RteIvaSimpl, porc_RteIca, porc_RteA, porc_RteB, bodega_ot, numero_ot, provision, ajuste, porc_RteCree, retencion_cree, codigo_retencion_cree, cree_causado, ObligacionFinanciera, Base_dcto_RC, numincapacidad, idincapacidad,"documentos",datosTransaccion);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Updates an documentos object by passing one object's instance as reference
		/// </summary>
		/// <param name="documentos">An instance of documentos for reference</param>
		public void Update(documentos documentos,Sinapsys.Datos.SQL datosTransaccion=null)
		{
			Update(documentos.id, documentos.sw, documentos.tipo, documentos.numero, documentos.nit, documentos.fecha, documentos.condicion, documentos.vencimiento, documentos.valor_total, documentos.iva, documentos.retencion, documentos.retencion_causada, documentos.retencion_iva, documentos.retencion_ica, documentos.descuento_pie, documentos.fletes, documentos.iva_fletes, documentos.costo, documentos.vendedor, documentos.valor_aplicado, documentos.anulado, documentos.modelo, documentos.documento, documentos.notas, documentos.usuario, documentos.pc, documentos.fecha_hora, documentos.retencion2, documentos.retencion3, documentos.bodega, documentos.impoconsumo, documentos.descuento2, documentos.duracion, documentos.concepto, documentos.vencimiento_presup, documentos.exportado, documentos.impuesto_deporte, documentos.prefijo, documentos.moneda, documentos.tasa, documentos.centro_doc, documentos.valor_mercancia, documentos.numero_cuotas, documentos.codigo_direccion, documentos.descuento_1, documentos.descuento_2, documentos.descuento_3, documentos.abono, documentos.fecha_consignacion, documentos.Iva_Costo, documentos.concepto_Retencion, documentos.porc_RteFuente, documentos.porc_RteIva, documentos.porc_RteIvaSimpl, documentos.porc_RteIca, documentos.porc_RteA, documentos.porc_RteB, documentos.bodega_ot, documentos.numero_ot, documentos.provision, documentos.ajuste, documentos.porc_RteCree, documentos.retencion_cree, documentos.codigo_retencion_cree, documentos.cree_causado, documentos.ObligacionFinanciera, documentos.Base_dcto_RC, documentos.numincapacidad, documentos.idincapacidad);
		}

		/// <summary>
		/// Delete  the documentos object by passing a object
		/// </summary>
		public void  Delete(documentos documentos, Sinapsys.Datos.SQL datosTransaccion=null)
		{
			Delete(documentos.id, documentos.tipo, documentos.numero,datosTransaccion);
		}

		/// <summary>
		/// Deletes the documentos object by passing one object's instance as reference
		/// </summary>
		/// <param name="documentos">An instance of documentos for reference</param>
		public void Delete(int id, string tipo, int numero, Sinapsys.Datos.SQL datosTransaccion=null)
		{
			try 
			{
				//documentos old_values = documentosController.Instance.Get(id);
				//if(!Validate.security.CanDeleteSecurityField(documentosController.Instance, (ILatinodeObject)old_values))
				//    throw new Exception("Access denied by security field, you can't delete object");

				documentosDataProvider.Instance.Delete(id, tipo, numero,"documentos");
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Deletes the documentos object by passing CVS parameter as reference
		/// </summary>
		/// <param name="documentos">An instance of documentos for reference</param>
		public void Delete(string CVSParameter)
		{
			string[] StrCommand=CVSParameter.Split(',');
			try 
			{
				int id=int.Parse(StrCommand[0]);
				string tipo=StrCommand[1];
				int numero=int.Parse(StrCommand[2]);
				documentosDataProvider.Instance.Delete(id, tipo, numero,"documentos");
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Gets the documentos object by passing the object's key fields
		/// </summary>
		/// <param name="id">int that contents the id value for the documentos object</param>
		/// <param name="tipo">string that contents the tipo value for the documentos object</param>
		/// <param name="numero">int that contents the numero value for the documentos object</param>
		/// <returns>One documentos object</returns>
		public documentos Get(int id, string tipo, int numero, bool generateUndo=false)
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

		/// <summary>
		/// Gets all objects of documentos
		/// </summary>
		/// <returns>One documentosList object</returns>
		public documentosList GetAll(bool generateUndo=false)
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

		/// <summary>
		/// Gets all objects of documentos applying filter and sort criteria
		/// </summary>
		/// <param name="pagenum">Contents the page number (z-ordered) of records to return.</param>
		/// <param name="pagesize">Contents the number of records per page (0 for returns all records).</param>
		/// <param name="filter">Contents the criteria (as SQL sentence) for filter records (ex. Qty > 0).</param>
		/// <param name="sort">Contents the criteria (as SQL sentence) for filter records (ex. Name ASC).</param>
		/// <param name="extablesfilter">Contents extra tables for make relations in filter operations (ex. extratable).</param>
		/// <param name="extablesfieldsfilter">Contents extra tables's fields for make relations in filter operations  (ex. extratable.field)</param>
		/// <param name="extablesrelationsfilter">Contents the relations with extra tables in filter operations (ex. table.id=extratable.id).</param>
		/// <param name="extablessort">Contents extra tables for make relations in sort operations (ex. extratable).</param>
		/// <param name="extablesfieldssort">Contents extra tables's fields for make relations in sort operations  (ex. extratable.field)</param>
		/// <param name="extablesrelationssort">Contents the relations with extra tables in sort operations (ex. table.id=extratable.id).</param>
		/// <returns>One documentosList object</returns>
		public documentosList GetFilter(int pagenum, int pagesize, string filter, string sort, string extablesfilter, string extablesfieldsfilter, string extablesrelationsfilter, string extablessort, string extablesfieldssort, string extablesrelationssort, bool generateUndo=false)
		{
			try 
			{
				documentosList documentoslist = new documentosList();

				DataTable dt = documentosDataProvider.Instance.GetFilter(pagenum, pagesize, filter, sort, extablesfilter, extablesfieldsfilter, extablesrelationsfilter, extablessort, extablesfieldssort, extablesrelationssort);

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
		public documentosList GetFilter( string filter, string sort, bool generateUndo=false)
		{
			return GetFilter(0,0, filter, sort, "","","","","","",generateUndo);
		}

		public documentosList GetFilter(string filter, string sort, string extablesfilter, string extablesfieldsfilter, string extablesrelationsfilter, string extablessort, string extablesfieldssort, string extablesrelationssort, bool generateUndo=false)
		{
			return GetFilter(0,0, filter, sort, extablesfilter, extablesfieldsfilter, extablesrelationsfilter, extablessort, extablesfieldssort, extablesrelationssort,generateUndo);
		}


		/// <summary>
		/// Returns the type for one property
		/// </summary>
		/// <param name="propertyname">Property's name for return its value</param>
		/// <returns>A value for the <paramref name="propertyname"/></returns>
		public Type GetMethodType( string propertyname,documentos documentos)
		{
			// Perform the search for the property's value
			switch (propertyname)
			{
				case "id":
					return documentos.id.GetType();

				case "sw":
					return documentos.sw.GetType();

				case "tipo":
					return documentos.tipo.GetType();

				case "numero":
					return documentos.numero.GetType();

				case "nit":
					return documentos.nit.GetType();

				case "fecha":
					return documentos.fecha.GetType();

				case "condicion":
					return documentos.condicion.GetType();

				case "vencimiento":
					return documentos.vencimiento.GetType();

				case "valor_total":
					return documentos.valor_total.GetType();

				case "iva":
					return documentos.iva.GetType();

				case "retencion":
					return documentos.retencion.GetType();

				case "retencion_causada":
					return documentos.retencion_causada.GetType();

				case "retencion_iva":
					return documentos.retencion_iva.GetType();

				case "retencion_ica":
					return documentos.retencion_ica.GetType();

				case "descuento_pie":
					return documentos.descuento_pie.GetType();

				case "fletes":
					return documentos.fletes.GetType();

				case "iva_fletes":
					return documentos.iva_fletes.GetType();

				case "costo":
					return documentos.costo.GetType();

				case "vendedor":
					return documentos.vendedor.GetType();

				case "valor_aplicado":
					return documentos.valor_aplicado.GetType();

				case "anulado":
					return documentos.anulado.GetType();

				case "modelo":
					return documentos.modelo.GetType();

				case "documento":
					return documentos.documento.GetType();

				case "notas":
					return documentos.notas.GetType();

				case "usuario":
					return documentos.usuario.GetType();

				case "pc":
					return documentos.pc.GetType();

				case "fecha_hora":
					return documentos.fecha_hora.GetType();

				case "retencion2":
					return documentos.retencion2.GetType();

				case "retencion3":
					return documentos.retencion3.GetType();

				case "bodega":
					return documentos.bodega.GetType();

				case "impoconsumo":
					return documentos.impoconsumo.GetType();

				case "descuento2":
					return documentos.descuento2.GetType();

				case "duracion":
					return documentos.duracion.GetType();

				case "concepto":
					return documentos.concepto.GetType();

				case "vencimiento_presup":
					return documentos.vencimiento_presup.GetType();

				case "exportado":
					return documentos.exportado.GetType();

				case "impuesto_deporte":
					return documentos.impuesto_deporte.GetType();

				case "prefijo":
					return documentos.prefijo.GetType();

				case "moneda":
					return documentos.moneda.GetType();

				case "tasa":
					return documentos.tasa.GetType();

				case "centro_doc":
					return documentos.centro_doc.GetType();

				case "valor_mercancia":
					return documentos.valor_mercancia.GetType();

				case "numero_cuotas":
					return documentos.numero_cuotas.GetType();

				case "codigo_direccion":
					return documentos.codigo_direccion.GetType();

				case "descuento_1":
					return documentos.descuento_1.GetType();

				case "descuento_2":
					return documentos.descuento_2.GetType();

				case "descuento_3":
					return documentos.descuento_3.GetType();

				case "abono":
					return documentos.abono.GetType();

				case "fecha_consignacion":
					return documentos.fecha_consignacion.GetType();

				case "Iva_Costo":
					return documentos.Iva_Costo.GetType();

				case "concepto_Retencion":
					return documentos.concepto_Retencion.GetType();

				case "porc_RteFuente":
					return documentos.porc_RteFuente.GetType();

				case "porc_RteIva":
					return documentos.porc_RteIva.GetType();

				case "porc_RteIvaSimpl":
					return documentos.porc_RteIvaSimpl.GetType();

				case "porc_RteIca":
					return documentos.porc_RteIca.GetType();

				case "porc_RteA":
					return documentos.porc_RteA.GetType();

				case "porc_RteB":
					return documentos.porc_RteB.GetType();

				case "bodega_ot":
					return documentos.bodega_ot.GetType();

				case "numero_ot":
					return documentos.numero_ot.GetType();

				case "provision":
					return documentos.provision.GetType();

				case "ajuste":
					return documentos.ajuste.GetType();

				case "porc_RteCree":
					return documentos.porc_RteCree.GetType();

				case "retencion_cree":
					return documentos.retencion_cree.GetType();

				case "codigo_retencion_cree":
					return documentos.codigo_retencion_cree.GetType();

				case "cree_causado":
					return documentos.cree_causado.GetType();

				case "ObligacionFinanciera":
					return documentos.ObligacionFinanciera.GetType();

				case "Base_dcto_RC":
					return documentos.Base_dcto_RC.GetType();

				case "numincapacidad":
					return documentos.numincapacidad.GetType();

				case "idincapacidad":
					return documentos.idincapacidad.GetType();

			}

			return null;
		}
		/// <summary>
		/// update the changes in documentos object by passing the object
		/// </summary>
		public bool UpdateChanges(documentos documentos, out string error,Sinapsys.Datos.SQL datosTransaccion=null)
		{
			if (documentos.Olddocumentos == null)
			{
				    error = "No tiene objeto con el cual comparar";
				    return false;
			}
			string[] Fields = documentos.FieldChanged();
			error = "";
			return LiqMetalDMS_Bll_Data.DataProvider.UpdateFieldsbyObject(Fields, documentos, out error,datosTransaccion);
		}
	}

	#endregion

}
