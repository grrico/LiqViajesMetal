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

namespace LiqMetalDMS_Bll_Data
{
	#region documentos object

	[DataContract]
	public partial class documentos : IDTOObject
	{
		/// <summary>
		/// Default constructor
		/// </summary>
		public documentos()
		{
			m_id = 0;
			m_tipo = "";
			m_numero = 0;
			m_sw = (byte)0;
			m_nit = 0;
			m_fecha = DateTime.Now.Date;
			m_condicion = null;
			m_vencimiento = null;
			m_valor_total = null;
			m_iva = null;
			m_retencion = null;
			m_retencion_causada = null;
			m_retencion_iva = null;
			m_retencion_ica = null;
			m_descuento_pie = null;
			m_fletes = null;
			m_iva_fletes = null;
			m_costo = null;
			m_vendedor = null;
			m_valor_aplicado = null;
			m_anulado = false;
			m_modelo = null;
			m_documento = null;
			m_notas = null;
			m_usuario = "";
			m_pc = "";
			m_fecha_hora = DateTime.Now.Date;
			m_retencion2 = null;
			m_retencion3 = null;
			m_bodega = 0;
			m_impoconsumo = null;
			m_descuento2 = null;
			m_duracion = null;
			m_concepto = null;
			m_vencimiento_presup = null;
			m_exportado = ' ';
			m_impuesto_deporte = null;
			m_prefijo = null;
			m_moneda = null;
			m_tasa = null;
			m_centro_doc = null;
			m_valor_mercancia = null;
			m_numero_cuotas = null;
			m_codigo_direccion = null;
			m_descuento_1 = null;
			m_descuento_2 = null;
			m_descuento_3 = null;
			m_abono = null;
			m_fecha_consignacion = null;
			m_Iva_Costo = ' ';
			m_concepto_Retencion = null;
			m_porc_RteFuente = null;
			m_porc_RteIva = null;
			m_porc_RteIvaSimpl = null;
			m_porc_RteIca = null;
			m_porc_RteA = null;
			m_porc_RteB = null;
			m_bodega_ot = null;
			m_numero_ot = null;
			m_provision = null;
			m_ajuste = null;
			m_porc_RteCree = null;
			m_retencion_cree = null;
			m_codigo_retencion_cree = null;
			m_cree_causado = null;
			m_ObligacionFinanciera = null;
			m_Base_dcto_RC = null;
			m_numincapacidad = null;
			m_idincapacidad = null;
			m_changed=false;
		}
		        //Return the table name of object
		        public string TableName()
		        {
		            return "documentos";
		        }
		#region Undo 
		// Internal class for storing changes
		private documentos m_olddocumentos;
		public void GenerateUndo()
		{
			m_olddocumentos=new documentos();
			m_olddocumentos.m_id = m_id;
			m_olddocumentos.m_tipo = m_tipo;
			m_olddocumentos.m_numero = m_numero;
			m_olddocumentos.sw = m_sw;
			m_olddocumentos.nit = m_nit;
			m_olddocumentos.fecha = m_fecha;
			m_olddocumentos.condicion = m_condicion;
			m_olddocumentos.vencimiento = m_vencimiento;
			m_olddocumentos.valor_total = m_valor_total;
			m_olddocumentos.iva = m_iva;
			m_olddocumentos.retencion = m_retencion;
			m_olddocumentos.retencion_causada = m_retencion_causada;
			m_olddocumentos.retencion_iva = m_retencion_iva;
			m_olddocumentos.retencion_ica = m_retencion_ica;
			m_olddocumentos.descuento_pie = m_descuento_pie;
			m_olddocumentos.fletes = m_fletes;
			m_olddocumentos.iva_fletes = m_iva_fletes;
			m_olddocumentos.costo = m_costo;
			m_olddocumentos.vendedor = m_vendedor;
			m_olddocumentos.valor_aplicado = m_valor_aplicado;
			m_olddocumentos.anulado = m_anulado;
			m_olddocumentos.modelo = m_modelo;
			m_olddocumentos.documento = m_documento;
			m_olddocumentos.notas = m_notas;
			m_olddocumentos.usuario = m_usuario;
			m_olddocumentos.pc = m_pc;
			m_olddocumentos.fecha_hora = m_fecha_hora;
			m_olddocumentos.retencion2 = m_retencion2;
			m_olddocumentos.retencion3 = m_retencion3;
			m_olddocumentos.bodega = m_bodega;
			m_olddocumentos.impoconsumo = m_impoconsumo;
			m_olddocumentos.descuento2 = m_descuento2;
			m_olddocumentos.duracion = m_duracion;
			m_olddocumentos.concepto = m_concepto;
			m_olddocumentos.vencimiento_presup = m_vencimiento_presup;
			m_olddocumentos.exportado = m_exportado;
			m_olddocumentos.impuesto_deporte = m_impuesto_deporte;
			m_olddocumentos.prefijo = m_prefijo;
			m_olddocumentos.moneda = m_moneda;
			m_olddocumentos.tasa = m_tasa;
			m_olddocumentos.centro_doc = m_centro_doc;
			m_olddocumentos.valor_mercancia = m_valor_mercancia;
			m_olddocumentos.numero_cuotas = m_numero_cuotas;
			m_olddocumentos.codigo_direccion = m_codigo_direccion;
			m_olddocumentos.descuento_1 = m_descuento_1;
			m_olddocumentos.descuento_2 = m_descuento_2;
			m_olddocumentos.descuento_3 = m_descuento_3;
			m_olddocumentos.abono = m_abono;
			m_olddocumentos.fecha_consignacion = m_fecha_consignacion;
			m_olddocumentos.Iva_Costo = m_Iva_Costo;
			m_olddocumentos.concepto_Retencion = m_concepto_Retencion;
			m_olddocumentos.porc_RteFuente = m_porc_RteFuente;
			m_olddocumentos.porc_RteIva = m_porc_RteIva;
			m_olddocumentos.porc_RteIvaSimpl = m_porc_RteIvaSimpl;
			m_olddocumentos.porc_RteIca = m_porc_RteIca;
			m_olddocumentos.porc_RteA = m_porc_RteA;
			m_olddocumentos.porc_RteB = m_porc_RteB;
			m_olddocumentos.bodega_ot = m_bodega_ot;
			m_olddocumentos.numero_ot = m_numero_ot;
			m_olddocumentos.provision = m_provision;
			m_olddocumentos.ajuste = m_ajuste;
			m_olddocumentos.porc_RteCree = m_porc_RteCree;
			m_olddocumentos.retencion_cree = m_retencion_cree;
			m_olddocumentos.codigo_retencion_cree = m_codigo_retencion_cree;
			m_olddocumentos.cree_causado = m_cree_causado;
			m_olddocumentos.ObligacionFinanciera = m_ObligacionFinanciera;
			m_olddocumentos.Base_dcto_RC = m_Base_dcto_RC;
			m_olddocumentos.numincapacidad = m_numincapacidad;
			m_olddocumentos.idincapacidad = m_idincapacidad;
		}

		public documentos Olddocumentos
		{
			get { return m_olddocumentos;}
		}
		// Return the changed fields
		public string[] FieldChanged()
		{
			List<string> fields=new List<string>();
			if (m_olddocumentos.sw != m_sw) fields.Add("sw");
			if (m_olddocumentos.nit != m_nit) fields.Add("nit");
			if (m_olddocumentos.fecha != m_fecha) fields.Add("fecha");
			if (m_olddocumentos.condicion != m_condicion) fields.Add("condicion");
			if (m_olddocumentos.vencimiento != m_vencimiento) fields.Add("vencimiento");
			if (m_olddocumentos.valor_total != m_valor_total) fields.Add("valor_total");
			if (m_olddocumentos.iva != m_iva) fields.Add("iva");
			if (m_olddocumentos.retencion != m_retencion) fields.Add("retencion");
			if (m_olddocumentos.retencion_causada != m_retencion_causada) fields.Add("retencion_causada");
			if (m_olddocumentos.retencion_iva != m_retencion_iva) fields.Add("retencion_iva");
			if (m_olddocumentos.retencion_ica != m_retencion_ica) fields.Add("retencion_ica");
			if (m_olddocumentos.descuento_pie != m_descuento_pie) fields.Add("descuento_pie");
			if (m_olddocumentos.fletes != m_fletes) fields.Add("fletes");
			if (m_olddocumentos.iva_fletes != m_iva_fletes) fields.Add("iva_fletes");
			if (m_olddocumentos.costo != m_costo) fields.Add("costo");
			if (m_olddocumentos.vendedor != m_vendedor) fields.Add("vendedor");
			if (m_olddocumentos.valor_aplicado != m_valor_aplicado) fields.Add("valor_aplicado");
			if (m_olddocumentos.anulado != m_anulado) fields.Add("anulado");
			if (m_olddocumentos.modelo != m_modelo) fields.Add("modelo");
			if (m_olddocumentos.documento != m_documento) fields.Add("documento");
			if (m_olddocumentos.notas != m_notas) fields.Add("notas");
			if (m_olddocumentos.usuario != m_usuario) fields.Add("usuario");
			if (m_olddocumentos.pc != m_pc) fields.Add("pc");
			if (m_olddocumentos.fecha_hora != m_fecha_hora) fields.Add("fecha_hora");
			if (m_olddocumentos.retencion2 != m_retencion2) fields.Add("retencion2");
			if (m_olddocumentos.retencion3 != m_retencion3) fields.Add("retencion3");
			if (m_olddocumentos.bodega != m_bodega) fields.Add("bodega");
			if (m_olddocumentos.impoconsumo != m_impoconsumo) fields.Add("impoconsumo");
			if (m_olddocumentos.descuento2 != m_descuento2) fields.Add("descuento2");
			if (m_olddocumentos.duracion != m_duracion) fields.Add("duracion");
			if (m_olddocumentos.concepto != m_concepto) fields.Add("concepto");
			if (m_olddocumentos.vencimiento_presup != m_vencimiento_presup) fields.Add("vencimiento_presup");
			if (m_olddocumentos.exportado != m_exportado) fields.Add("exportado");
			if (m_olddocumentos.impuesto_deporte != m_impuesto_deporte) fields.Add("impuesto_deporte");
			if (m_olddocumentos.prefijo != m_prefijo) fields.Add("prefijo");
			if (m_olddocumentos.moneda != m_moneda) fields.Add("moneda");
			if (m_olddocumentos.tasa != m_tasa) fields.Add("tasa");
			if (m_olddocumentos.centro_doc != m_centro_doc) fields.Add("centro_doc");
			if (m_olddocumentos.valor_mercancia != m_valor_mercancia) fields.Add("valor_mercancia");
			if (m_olddocumentos.numero_cuotas != m_numero_cuotas) fields.Add("numero_cuotas");
			if (m_olddocumentos.codigo_direccion != m_codigo_direccion) fields.Add("codigo_direccion");
			if (m_olddocumentos.descuento_1 != m_descuento_1) fields.Add("descuento_1");
			if (m_olddocumentos.descuento_2 != m_descuento_2) fields.Add("descuento_2");
			if (m_olddocumentos.descuento_3 != m_descuento_3) fields.Add("descuento_3");
			if (m_olddocumentos.abono != m_abono) fields.Add("abono");
			if (m_olddocumentos.fecha_consignacion != m_fecha_consignacion) fields.Add("fecha_consignacion");
			if (m_olddocumentos.Iva_Costo != m_Iva_Costo) fields.Add("Iva_Costo");
			if (m_olddocumentos.concepto_Retencion != m_concepto_Retencion) fields.Add("concepto_Retencion");
			if (m_olddocumentos.porc_RteFuente != m_porc_RteFuente) fields.Add("porc_RteFuente");
			if (m_olddocumentos.porc_RteIva != m_porc_RteIva) fields.Add("porc_RteIva");
			if (m_olddocumentos.porc_RteIvaSimpl != m_porc_RteIvaSimpl) fields.Add("porc_RteIvaSimpl");
			if (m_olddocumentos.porc_RteIca != m_porc_RteIca) fields.Add("porc_RteIca");
			if (m_olddocumentos.porc_RteA != m_porc_RteA) fields.Add("porc_RteA");
			if (m_olddocumentos.porc_RteB != m_porc_RteB) fields.Add("porc_RteB");
			if (m_olddocumentos.bodega_ot != m_bodega_ot) fields.Add("bodega_ot");
			if (m_olddocumentos.numero_ot != m_numero_ot) fields.Add("numero_ot");
			if (m_olddocumentos.provision != m_provision) fields.Add("provision");
			if (m_olddocumentos.ajuste != m_ajuste) fields.Add("ajuste");
			if (m_olddocumentos.porc_RteCree != m_porc_RteCree) fields.Add("porc_RteCree");
			if (m_olddocumentos.retencion_cree != m_retencion_cree) fields.Add("retencion_cree");
			if (m_olddocumentos.codigo_retencion_cree != m_codigo_retencion_cree) fields.Add("codigo_retencion_cree");
			if (m_olddocumentos.cree_causado != m_cree_causado) fields.Add("cree_causado");
			if (m_olddocumentos.ObligacionFinanciera != m_ObligacionFinanciera) fields.Add("ObligacionFinanciera");
			if (m_olddocumentos.Base_dcto_RC != m_Base_dcto_RC) fields.Add("Base_dcto_RC");
			if (m_olddocumentos.numincapacidad != m_numincapacidad) fields.Add("numincapacidad");
			if (m_olddocumentos.idincapacidad != m_idincapacidad) fields.Add("idincapacidad");
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


		// Field for storing the documentos's id value
		private int m_id;

		// Field for storing the documentos's sw value
		private byte m_sw;

		// Field for storing the documentos's tipo value
		private string m_tipo;

		// Field for storing the documentos's numero value
		private int m_numero;

		// Field for storing the documentos's nit value
		private decimal m_nit;

		// Field for storing the documentos's fecha value
		private DateTime m_fecha;

		// Field for storing the documentos's condicion value
		private string m_condicion;

		// Field for storing the documentos's vencimiento value
		private DateTime? m_vencimiento;

		// Field for storing the documentos's valor_total value
		private decimal? m_valor_total;

		// Field for storing the documentos's iva value
		private decimal? m_iva;

		// Field for storing the documentos's retencion value
		private decimal? m_retencion;

		// Field for storing the documentos's retencion_causada value
		private decimal? m_retencion_causada;

		// Field for storing the documentos's retencion_iva value
		private decimal? m_retencion_iva;

		// Field for storing the documentos's retencion_ica value
		private decimal? m_retencion_ica;

		// Field for storing the documentos's descuento_pie value
		private decimal? m_descuento_pie;

		// Field for storing the documentos's fletes value
		private decimal? m_fletes;

		// Field for storing the documentos's iva_fletes value
		private decimal? m_iva_fletes;

		// Field for storing the documentos's costo value
		private decimal? m_costo;

		// Field for storing the documentos's vendedor value
		private decimal? m_vendedor;

		// Field for storing the documentos's valor_aplicado value
		private decimal? m_valor_aplicado;

		// Field for storing the documentos's anulado value
		private bool m_anulado;

		// Field for storing the documentos's modelo value
		private string m_modelo;

		// Field for storing the documentos's documento value
		private string m_documento;

		// Field for storing the documentos's notas value
		private string m_notas;

		// Field for storing the documentos's usuario value
		private string m_usuario;

		// Field for storing the documentos's pc value
		private string m_pc;

		// Field for storing the documentos's fecha_hora value
		private DateTime m_fecha_hora;

		// Field for storing the documentos's retencion2 value
		private decimal? m_retencion2;

		// Field for storing the documentos's retencion3 value
		private decimal? m_retencion3;

		// Field for storing the documentos's bodega value
		private short m_bodega;

		// Field for storing the documentos's impoconsumo value
		private decimal? m_impoconsumo;

		// Field for storing the documentos's descuento2 value
		private decimal? m_descuento2;

		// Field for storing the documentos's duracion value
		private short? m_duracion;

		// Field for storing the documentos's concepto value
		private short? m_concepto;

		// Field for storing the documentos's vencimiento_presup value
		private DateTime? m_vencimiento_presup;

		// Field for storing the documentos's exportado value
		private char? m_exportado;

		// Field for storing the documentos's impuesto_deporte value
		private decimal? m_impuesto_deporte;

		// Field for storing the documentos's prefijo value
		private string m_prefijo;

		// Field for storing the documentos's moneda value
		private string m_moneda;

		// Field for storing the documentos's tasa value
		private float? m_tasa;

		// Field for storing the documentos's centro_doc value
		private int? m_centro_doc;

		// Field for storing the documentos's valor_mercancia value
		private decimal? m_valor_mercancia;

		// Field for storing the documentos's numero_cuotas value
		private short? m_numero_cuotas;

		// Field for storing the documentos's codigo_direccion value
		private short? m_codigo_direccion;

		// Field for storing the documentos's descuento_1 value
		private float? m_descuento_1;

		// Field for storing the documentos's descuento_2 value
		private float? m_descuento_2;

		// Field for storing the documentos's descuento_3 value
		private float? m_descuento_3;

		// Field for storing the documentos's abono value
		private decimal? m_abono;

		// Field for storing the documentos's fecha_consignacion value
		private DateTime? m_fecha_consignacion;

		// Field for storing the documentos's Iva_Costo value
		private char? m_Iva_Costo;

		// Field for storing the documentos's concepto_Retencion value
		private short? m_concepto_Retencion;

		// Field for storing the documentos's porc_RteFuente value
		private decimal? m_porc_RteFuente;

		// Field for storing the documentos's porc_RteIva value
		private decimal? m_porc_RteIva;

		// Field for storing the documentos's porc_RteIvaSimpl value
		private decimal? m_porc_RteIvaSimpl;

		// Field for storing the documentos's porc_RteIca value
		private decimal? m_porc_RteIca;

		// Field for storing the documentos's porc_RteA value
		private decimal? m_porc_RteA;

		// Field for storing the documentos's porc_RteB value
		private decimal? m_porc_RteB;

		// Field for storing the documentos's bodega_ot value
		private short? m_bodega_ot;

		// Field for storing the documentos's numero_ot value
		private int? m_numero_ot;

		// Field for storing the documentos's provision value
		private decimal? m_provision;

		// Field for storing the documentos's ajuste value
		private decimal? m_ajuste;

		// Field for storing the documentos's porc_RteCree value
		private decimal? m_porc_RteCree;

		// Field for storing the documentos's retencion_cree value
		private decimal? m_retencion_cree;

		// Field for storing the documentos's codigo_retencion_cree value
		private string m_codigo_retencion_cree;

		// Field for storing the documentos's cree_causado value
		private decimal? m_cree_causado;

		// Field for storing the documentos's ObligacionFinanciera value
		private string m_ObligacionFinanciera;

		// Field for storing the documentos's Base_dcto_RC value
		private decimal? m_Base_dcto_RC;

		// Field for storing the documentos's numincapacidad value
		private string m_numincapacidad;

		// Field for storing the documentos's idincapacidad value
		private int? m_idincapacidad;

		// Evaluate changed state
		private bool m_changed=false;
		// Field for storing the reference to foreign documentos_entregadosList object accessed by tipo, numero
		private documentos_entregadosList m_documentos_entregados;

		// Field for storing the reference to foreign documentos_cruceList object accessed by tipo, numero
		private documentos_cruceList m_documentos_cruce;

		// Field for storing the reference to foreign documentos_cuotasList object accessed by tipo, numero
		private documentos_cuotasList m_documentos_cuotas;

		// Field for storing the reference to foreign documentos_montoList object accessed by tipo, numero
		private documentos_montoList m_documentos_monto;

		// Field for storing the reference to foreign NIIF_RECLACIFICACIONList object accessed by tipo, numero
		private NIIF_RECLACIFICACIONList m_NIIF_RECLACIFICACION;

		// Field for storing the reference to foreign NIIF_DOC_SALDO_PROVISIONList object accessed by tipo, numero
		private NIIF_DOC_SALDO_PROVISIONList m_NIIF_DOC_SALDO_PROVISION;

		// Field for storing the reference to foreign dif_mov_auxList object accessed by tipo, numero
		private dif_mov_auxList m_dif_mov_aux;

		// Field for storing the reference to foreign NIIF_RECLASIFICACIONList object accessed by tipo, numero
		private NIIF_RECLASIFICACIONList m_NIIF_RECLASIFICACION;


		#endregion

		#region Attributes

		// Return if object changed
		public bool Changed
		{
			get { return m_changed;}
			set { m_changed=value;}
		}
		/// <summary>
		/// Attribute for access the documentos's id value (int)
		/// </summary>
		[DataMember]
		public int id
		{
			get { return m_id; }
			set 
			{
				m_changed=true;
				m_id = value;
			}
		}

		/// <summary>
		/// Attribute for access the documentos's sw value (byte)
		/// </summary>
		[DataMember]
		public byte sw
		{
			get { return m_sw; }
			set 
			{
				m_changed=true;
				m_sw = value;
			}
		}

		/// <summary>
		/// Attribute for access the documentos's tipo value (string)
		/// </summary>
		[DataMember]
		public string tipo
		{
			get { return m_tipo; }
			set 
			{
				m_changed=true;
				m_tipo = value;
			}
		}

		/// <summary>
		/// Attribute for access the documentos's numero value (int)
		/// </summary>
		[DataMember]
		public int numero
		{
			get { return m_numero; }
			set 
			{
				m_changed=true;
				m_numero = value;
			}
		}

		/// <summary>
		/// Attribute for access the documentos's nit value (decimal)
		/// </summary>
		[DataMember]
		public decimal nit
		{
			get { return m_nit; }
			set 
			{
				m_changed=true;
				m_nit = value;
			}
		}

		/// <summary>
		/// Attribute for access the documentos's fecha value (DateTime)
		/// </summary>
		[DataMember]
		public DateTime fecha
		{
			get { return m_fecha; }
			set 
			{
				m_changed=true;
				m_fecha = value;
			}
		}

		/// <summary>
		/// Attribute for access the documentos's condicion value (string)
		/// </summary>
		[DataMember]
		public string condicion
		{
			get { return m_condicion; }
			set 
			{
				m_changed=true;
				m_condicion = value;
			}
		}

		/// <summary>
		/// Attribute for access the documentos's vencimiento value (DateTime)
		/// </summary>
		[DataMember]
		public DateTime? vencimiento
		{
			get { return m_vencimiento; }
			set 
			{
				m_changed=true;
				m_vencimiento = value;
			}
		}

		/// <summary>
		/// Attribute for access the documentos's valor_total value (decimal)
		/// </summary>
		[DataMember]
		public decimal? valor_total
		{
			get { return m_valor_total; }
			set 
			{
				m_changed=true;
				m_valor_total = value;
			}
		}

		/// <summary>
		/// Attribute for access the documentos's iva value (decimal)
		/// </summary>
		[DataMember]
		public decimal? iva
		{
			get { return m_iva; }
			set 
			{
				m_changed=true;
				m_iva = value;
			}
		}

		/// <summary>
		/// Attribute for access the documentos's retencion value (decimal)
		/// </summary>
		[DataMember]
		public decimal? retencion
		{
			get { return m_retencion; }
			set 
			{
				m_changed=true;
				m_retencion = value;
			}
		}

		/// <summary>
		/// Attribute for access the documentos's retencion_causada value (decimal)
		/// </summary>
		[DataMember]
		public decimal? retencion_causada
		{
			get { return m_retencion_causada; }
			set 
			{
				m_changed=true;
				m_retencion_causada = value;
			}
		}

		/// <summary>
		/// Attribute for access the documentos's retencion_iva value (decimal)
		/// </summary>
		[DataMember]
		public decimal? retencion_iva
		{
			get { return m_retencion_iva; }
			set 
			{
				m_changed=true;
				m_retencion_iva = value;
			}
		}

		/// <summary>
		/// Attribute for access the documentos's retencion_ica value (decimal)
		/// </summary>
		[DataMember]
		public decimal? retencion_ica
		{
			get { return m_retencion_ica; }
			set 
			{
				m_changed=true;
				m_retencion_ica = value;
			}
		}

		/// <summary>
		/// Attribute for access the documentos's descuento_pie value (decimal)
		/// </summary>
		[DataMember]
		public decimal? descuento_pie
		{
			get { return m_descuento_pie; }
			set 
			{
				m_changed=true;
				m_descuento_pie = value;
			}
		}

		/// <summary>
		/// Attribute for access the documentos's fletes value (decimal)
		/// </summary>
		[DataMember]
		public decimal? fletes
		{
			get { return m_fletes; }
			set 
			{
				m_changed=true;
				m_fletes = value;
			}
		}

		/// <summary>
		/// Attribute for access the documentos's iva_fletes value (decimal)
		/// </summary>
		[DataMember]
		public decimal? iva_fletes
		{
			get { return m_iva_fletes; }
			set 
			{
				m_changed=true;
				m_iva_fletes = value;
			}
		}

		/// <summary>
		/// Attribute for access the documentos's costo value (decimal)
		/// </summary>
		[DataMember]
		public decimal? costo
		{
			get { return m_costo; }
			set 
			{
				m_changed=true;
				m_costo = value;
			}
		}

		/// <summary>
		/// Attribute for access the documentos's vendedor value (decimal)
		/// </summary>
		[DataMember]
		public decimal? vendedor
		{
			get { return m_vendedor; }
			set 
			{
				m_changed=true;
				m_vendedor = value;
			}
		}

		/// <summary>
		/// Attribute for access the documentos's valor_aplicado value (decimal)
		/// </summary>
		[DataMember]
		public decimal? valor_aplicado
		{
			get { return m_valor_aplicado; }
			set 
			{
				m_changed=true;
				m_valor_aplicado = value;
			}
		}

		/// <summary>
		/// Attribute for access the documentos's anulado value (bool)
		/// </summary>
		[DataMember]
		public bool anulado
		{
			get { return m_anulado; }
			set 
			{
				m_changed=true;
				m_anulado = value;
			}
		}

		/// <summary>
		/// Attribute for access the documentos's modelo value (string)
		/// </summary>
		[DataMember]
		public string modelo
		{
			get { return m_modelo; }
			set 
			{
				m_changed=true;
				m_modelo = value;
			}
		}

		/// <summary>
		/// Attribute for access the documentos's documento value (string)
		/// </summary>
		[DataMember]
		public string documento
		{
			get { return m_documento; }
			set 
			{
				m_changed=true;
				m_documento = value;
			}
		}

		/// <summary>
		/// Attribute for access the documentos's notas value (string)
		/// </summary>
		[DataMember]
		public string notas
		{
			get { return m_notas; }
			set 
			{
				m_changed=true;
				m_notas = value;
			}
		}

		/// <summary>
		/// Attribute for access the documentos's usuario value (string)
		/// </summary>
		[DataMember]
		public string usuario
		{
			get { return m_usuario; }
			set 
			{
				m_changed=true;
				m_usuario = value;
			}
		}

		/// <summary>
		/// Attribute for access the documentos's pc value (string)
		/// </summary>
		[DataMember]
		public string pc
		{
			get { return m_pc; }
			set 
			{
				m_changed=true;
				m_pc = value;
			}
		}

		/// <summary>
		/// Attribute for access the documentos's fecha_hora value (DateTime)
		/// </summary>
		[DataMember]
		public DateTime fecha_hora
		{
			get { return m_fecha_hora; }
			set 
			{
				m_changed=true;
				m_fecha_hora = value;
			}
		}

		/// <summary>
		/// Attribute for access the documentos's retencion2 value (decimal)
		/// </summary>
		[DataMember]
		public decimal? retencion2
		{
			get { return m_retencion2; }
			set 
			{
				m_changed=true;
				m_retencion2 = value;
			}
		}

		/// <summary>
		/// Attribute for access the documentos's retencion3 value (decimal)
		/// </summary>
		[DataMember]
		public decimal? retencion3
		{
			get { return m_retencion3; }
			set 
			{
				m_changed=true;
				m_retencion3 = value;
			}
		}

		/// <summary>
		/// Attribute for access the documentos's bodega value (short)
		/// </summary>
		[DataMember]
		public short bodega
		{
			get { return m_bodega; }
			set 
			{
				m_changed=true;
				m_bodega = value;
			}
		}

		/// <summary>
		/// Attribute for access the documentos's impoconsumo value (decimal)
		/// </summary>
		[DataMember]
		public decimal? impoconsumo
		{
			get { return m_impoconsumo; }
			set 
			{
				m_changed=true;
				m_impoconsumo = value;
			}
		}

		/// <summary>
		/// Attribute for access the documentos's descuento2 value (decimal)
		/// </summary>
		[DataMember]
		public decimal? descuento2
		{
			get { return m_descuento2; }
			set 
			{
				m_changed=true;
				m_descuento2 = value;
			}
		}

		/// <summary>
		/// Attribute for access the documentos's duracion value (short)
		/// </summary>
		[DataMember]
		public short? duracion
		{
			get { return m_duracion; }
			set 
			{
				m_changed=true;
				m_duracion = value;
			}
		}

		/// <summary>
		/// Attribute for access the documentos's concepto value (short)
		/// </summary>
		[DataMember]
		public short? concepto
		{
			get { return m_concepto; }
			set 
			{
				m_changed=true;
				m_concepto = value;
			}
		}

		/// <summary>
		/// Attribute for access the documentos's vencimiento_presup value (DateTime)
		/// </summary>
		[DataMember]
		public DateTime? vencimiento_presup
		{
			get { return m_vencimiento_presup; }
			set 
			{
				m_changed=true;
				m_vencimiento_presup = value;
			}
		}

		/// <summary>
		/// Attribute for access the documentos's exportado value (char)
		/// </summary>
		[DataMember]
		public char? exportado
		{
			get { return m_exportado; }
			set 
			{
				m_changed=true;
				m_exportado = value;
			}
		}

		/// <summary>
		/// Attribute for access the documentos's impuesto_deporte value (decimal)
		/// </summary>
		[DataMember]
		public decimal? impuesto_deporte
		{
			get { return m_impuesto_deporte; }
			set 
			{
				m_changed=true;
				m_impuesto_deporte = value;
			}
		}

		/// <summary>
		/// Attribute for access the documentos's prefijo value (string)
		/// </summary>
		[DataMember]
		public string prefijo
		{
			get { return m_prefijo; }
			set 
			{
				m_changed=true;
				m_prefijo = value;
			}
		}

		/// <summary>
		/// Attribute for access the documentos's moneda value (string)
		/// </summary>
		[DataMember]
		public string moneda
		{
			get { return m_moneda; }
			set 
			{
				m_changed=true;
				m_moneda = value;
			}
		}

		/// <summary>
		/// Attribute for access the documentos's tasa value (float)
		/// </summary>
		[DataMember]
		public float? tasa
		{
			get { return m_tasa; }
			set 
			{
				m_changed=true;
				m_tasa = value;
			}
		}

		/// <summary>
		/// Attribute for access the documentos's centro_doc value (int)
		/// </summary>
		[DataMember]
		public int? centro_doc
		{
			get { return m_centro_doc; }
			set 
			{
				m_changed=true;
				m_centro_doc = value;
			}
		}

		/// <summary>
		/// Attribute for access the documentos's valor_mercancia value (decimal)
		/// </summary>
		[DataMember]
		public decimal? valor_mercancia
		{
			get { return m_valor_mercancia; }
			set 
			{
				m_changed=true;
				m_valor_mercancia = value;
			}
		}

		/// <summary>
		/// Attribute for access the documentos's numero_cuotas value (short)
		/// </summary>
		[DataMember]
		public short? numero_cuotas
		{
			get { return m_numero_cuotas; }
			set 
			{
				m_changed=true;
				m_numero_cuotas = value;
			}
		}

		/// <summary>
		/// Attribute for access the documentos's codigo_direccion value (short)
		/// </summary>
		[DataMember]
		public short? codigo_direccion
		{
			get { return m_codigo_direccion; }
			set 
			{
				m_changed=true;
				m_codigo_direccion = value;
			}
		}

		/// <summary>
		/// Attribute for access the documentos's descuento_1 value (float)
		/// </summary>
		[DataMember]
		public float? descuento_1
		{
			get { return m_descuento_1; }
			set 
			{
				m_changed=true;
				m_descuento_1 = value;
			}
		}

		/// <summary>
		/// Attribute for access the documentos's descuento_2 value (float)
		/// </summary>
		[DataMember]
		public float? descuento_2
		{
			get { return m_descuento_2; }
			set 
			{
				m_changed=true;
				m_descuento_2 = value;
			}
		}

		/// <summary>
		/// Attribute for access the documentos's descuento_3 value (float)
		/// </summary>
		[DataMember]
		public float? descuento_3
		{
			get { return m_descuento_3; }
			set 
			{
				m_changed=true;
				m_descuento_3 = value;
			}
		}

		/// <summary>
		/// Attribute for access the documentos's abono value (decimal)
		/// </summary>
		[DataMember]
		public decimal? abono
		{
			get { return m_abono; }
			set 
			{
				m_changed=true;
				m_abono = value;
			}
		}

		/// <summary>
		/// Attribute for access the documentos's fecha_consignacion value (DateTime)
		/// </summary>
		[DataMember]
		public DateTime? fecha_consignacion
		{
			get { return m_fecha_consignacion; }
			set 
			{
				m_changed=true;
				m_fecha_consignacion = value;
			}
		}

		/// <summary>
		/// Attribute for access the documentos's Iva_Costo value (char)
		/// </summary>
		[DataMember]
		public char? Iva_Costo
		{
			get { return m_Iva_Costo; }
			set 
			{
				m_changed=true;
				m_Iva_Costo = value;
			}
		}

		/// <summary>
		/// Attribute for access the documentos's concepto_Retencion value (short)
		/// </summary>
		[DataMember]
		public short? concepto_Retencion
		{
			get { return m_concepto_Retencion; }
			set 
			{
				m_changed=true;
				m_concepto_Retencion = value;
			}
		}

		/// <summary>
		/// Attribute for access the documentos's porc_RteFuente value (decimal)
		/// </summary>
		[DataMember]
		public decimal? porc_RteFuente
		{
			get { return m_porc_RteFuente; }
			set 
			{
				m_changed=true;
				m_porc_RteFuente = value;
			}
		}

		/// <summary>
		/// Attribute for access the documentos's porc_RteIva value (decimal)
		/// </summary>
		[DataMember]
		public decimal? porc_RteIva
		{
			get { return m_porc_RteIva; }
			set 
			{
				m_changed=true;
				m_porc_RteIva = value;
			}
		}

		/// <summary>
		/// Attribute for access the documentos's porc_RteIvaSimpl value (decimal)
		/// </summary>
		[DataMember]
		public decimal? porc_RteIvaSimpl
		{
			get { return m_porc_RteIvaSimpl; }
			set 
			{
				m_changed=true;
				m_porc_RteIvaSimpl = value;
			}
		}

		/// <summary>
		/// Attribute for access the documentos's porc_RteIca value (decimal)
		/// </summary>
		[DataMember]
		public decimal? porc_RteIca
		{
			get { return m_porc_RteIca; }
			set 
			{
				m_changed=true;
				m_porc_RteIca = value;
			}
		}

		/// <summary>
		/// Attribute for access the documentos's porc_RteA value (decimal)
		/// </summary>
		[DataMember]
		public decimal? porc_RteA
		{
			get { return m_porc_RteA; }
			set 
			{
				m_changed=true;
				m_porc_RteA = value;
			}
		}

		/// <summary>
		/// Attribute for access the documentos's porc_RteB value (decimal)
		/// </summary>
		[DataMember]
		public decimal? porc_RteB
		{
			get { return m_porc_RteB; }
			set 
			{
				m_changed=true;
				m_porc_RteB = value;
			}
		}

		/// <summary>
		/// Attribute for access the documentos's bodega_ot value (short)
		/// </summary>
		[DataMember]
		public short? bodega_ot
		{
			get { return m_bodega_ot; }
			set 
			{
				m_changed=true;
				m_bodega_ot = value;
			}
		}

		/// <summary>
		/// Attribute for access the documentos's numero_ot value (int)
		/// </summary>
		[DataMember]
		public int? numero_ot
		{
			get { return m_numero_ot; }
			set 
			{
				m_changed=true;
				m_numero_ot = value;
			}
		}

		/// <summary>
		/// Attribute for access the documentos's provision value (decimal)
		/// </summary>
		[DataMember]
		public decimal? provision
		{
			get { return m_provision; }
			set 
			{
				m_changed=true;
				m_provision = value;
			}
		}

		/// <summary>
		/// Attribute for access the documentos's ajuste value (decimal)
		/// </summary>
		[DataMember]
		public decimal? ajuste
		{
			get { return m_ajuste; }
			set 
			{
				m_changed=true;
				m_ajuste = value;
			}
		}

		/// <summary>
		/// Attribute for access the documentos's porc_RteCree value (decimal)
		/// </summary>
		[DataMember]
		public decimal? porc_RteCree
		{
			get { return m_porc_RteCree; }
			set 
			{
				m_changed=true;
				m_porc_RteCree = value;
			}
		}

		/// <summary>
		/// Attribute for access the documentos's retencion_cree value (decimal)
		/// </summary>
		[DataMember]
		public decimal? retencion_cree
		{
			get { return m_retencion_cree; }
			set 
			{
				m_changed=true;
				m_retencion_cree = value;
			}
		}

		/// <summary>
		/// Attribute for access the documentos's codigo_retencion_cree value (string)
		/// </summary>
		[DataMember]
		public string codigo_retencion_cree
		{
			get { return m_codigo_retencion_cree; }
			set 
			{
				m_changed=true;
				m_codigo_retencion_cree = value;
			}
		}

		/// <summary>
		/// Attribute for access the documentos's cree_causado value (decimal)
		/// </summary>
		[DataMember]
		public decimal? cree_causado
		{
			get { return m_cree_causado; }
			set 
			{
				m_changed=true;
				m_cree_causado = value;
			}
		}

		/// <summary>
		/// Attribute for access the documentos's ObligacionFinanciera value (string)
		/// </summary>
		[DataMember]
		public string ObligacionFinanciera
		{
			get { return m_ObligacionFinanciera; }
			set 
			{
				m_changed=true;
				m_ObligacionFinanciera = value;
			}
		}

		/// <summary>
		/// Attribute for access the documentos's Base_dcto_RC value (decimal)
		/// </summary>
		[DataMember]
		public decimal? Base_dcto_RC
		{
			get { return m_Base_dcto_RC; }
			set 
			{
				m_changed=true;
				m_Base_dcto_RC = value;
			}
		}

		/// <summary>
		/// Attribute for access the documentos's numincapacidad value (string)
		/// </summary>
		[DataMember]
		public string numincapacidad
		{
			get { return m_numincapacidad; }
			set 
			{
				m_changed=true;
				m_numincapacidad = value;
			}
		}

		/// <summary>
		/// Attribute for access the documentos's idincapacidad value (int)
		/// </summary>
		[DataMember]
		public int? idincapacidad
		{
			get { return m_idincapacidad; }
			set 
			{
				m_changed=true;
				m_idincapacidad = value;
			}
		}

		public object GetAttribute(string pattribute)
		{
			switch (pattribute)
			{
				case "id": return id;
				case "sw": return sw;
				case "tipo": return tipo;
				case "numero": return numero;
				case "nit": return nit;
				case "fecha": return fecha;
				case "condicion": return condicion;
				case "vencimiento": return vencimiento;
				case "valor_total": return valor_total;
				case "iva": return iva;
				case "retencion": return retencion;
				case "retencion_causada": return retencion_causada;
				case "retencion_iva": return retencion_iva;
				case "retencion_ica": return retencion_ica;
				case "descuento_pie": return descuento_pie;
				case "fletes": return fletes;
				case "iva_fletes": return iva_fletes;
				case "costo": return costo;
				case "vendedor": return vendedor;
				case "valor_aplicado": return valor_aplicado;
				case "anulado": return anulado;
				case "modelo": return modelo;
				case "documento": return documento;
				case "notas": return notas;
				case "usuario": return usuario;
				case "pc": return pc;
				case "fecha_hora": return fecha_hora;
				case "retencion2": return retencion2;
				case "retencion3": return retencion3;
				case "bodega": return bodega;
				case "impoconsumo": return impoconsumo;
				case "descuento2": return descuento2;
				case "duracion": return duracion;
				case "concepto": return concepto;
				case "vencimiento_presup": return vencimiento_presup;
				case "exportado": return exportado;
				case "impuesto_deporte": return impuesto_deporte;
				case "prefijo": return prefijo;
				case "moneda": return moneda;
				case "tasa": return tasa;
				case "centro_doc": return centro_doc;
				case "valor_mercancia": return valor_mercancia;
				case "numero_cuotas": return numero_cuotas;
				case "codigo_direccion": return codigo_direccion;
				case "descuento_1": return descuento_1;
				case "descuento_2": return descuento_2;
				case "descuento_3": return descuento_3;
				case "abono": return abono;
				case "fecha_consignacion": return fecha_consignacion;
				case "Iva_Costo": return Iva_Costo;
				case "concepto_Retencion": return concepto_Retencion;
				case "porc_RteFuente": return porc_RteFuente;
				case "porc_RteIva": return porc_RteIva;
				case "porc_RteIvaSimpl": return porc_RteIvaSimpl;
				case "porc_RteIca": return porc_RteIca;
				case "porc_RteA": return porc_RteA;
				case "porc_RteB": return porc_RteB;
				case "bodega_ot": return bodega_ot;
				case "numero_ot": return numero_ot;
				case "provision": return provision;
				case "ajuste": return ajuste;
				case "porc_RteCree": return porc_RteCree;
				case "retencion_cree": return retencion_cree;
				case "codigo_retencion_cree": return codigo_retencion_cree;
				case "cree_causado": return cree_causado;
				case "ObligacionFinanciera": return ObligacionFinanciera;
				case "Base_dcto_RC": return Base_dcto_RC;
				case "numincapacidad": return numincapacidad;
				case "idincapacidad": return idincapacidad;
				default: return null;
			}
		}

		public Type GetAttributeType(string pattribute)
		{
			return documentosController.Instance.GetMethodType(pattribute, this);
		}

		public string GetSqlKey()
		{
			return "[id] = " + id.ToString() + " AND [tipo] = '" + tipo.ToString()+ "'" + " AND [numero] = " + numero.ToString();
		}
		/// <summary>
		/// Gets or sets the reference to foreign documentos_entregadosList object accessed by tipo, numero
		/// </summary>
		public documentos_entregadosList documentos_entregados
		{
			get
			{
				if (m_documentos_entregados == null)
				{
					m_documentos_entregados = documentos_entregadosController.Instance.GetBy_tipo_numero(tipo, numero);
			}

			return m_documentos_entregados;
		}
		set { m_documentos_entregados = value; }
	}

	/// <summary>
	/// Gets or sets the reference to foreign documentos_cruceList object accessed by tipo, numero
	/// </summary>
	public documentos_cruceList documentos_cruce
	{
		get
		{
			if (m_documentos_cruce == null)
			{
				m_documentos_cruce = documentos_cruceController.Instance.GetBy_tipo_numero(tipo, numero);
		}

		return m_documentos_cruce;
	}
	set { m_documentos_cruce = value; }
}

/// <summary>
/// Gets or sets the reference to foreign documentos_cuotasList object accessed by tipo, numero
/// </summary>
public documentos_cuotasList documentos_cuotas
{
	get
	{
		if (m_documentos_cuotas == null)
		{
			m_documentos_cuotas = documentos_cuotasController.Instance.GetBy_tipo_numero(tipo, numero);
	}

	return m_documentos_cuotas;
}
set { m_documentos_cuotas = value; }
}

/// <summary>
/// Gets or sets the reference to foreign documentos_montoList object accessed by tipo, numero
/// </summary>
public documentos_montoList documentos_monto
{
	get
	{
		if (m_documentos_monto == null)
		{
			m_documentos_monto = documentos_montoController.Instance.GetBy_tipo_numero(tipo, numero);
	}

	return m_documentos_monto;
}
set { m_documentos_monto = value; }
}

/// <summary>
/// Gets or sets the reference to foreign NIIF_RECLACIFICACIONList object accessed by tipo, numero
/// </summary>
public NIIF_RECLACIFICACIONList NIIF_RECLACIFICACION
{
	get
	{
		if (m_NIIF_RECLACIFICACION == null)
		{
			m_NIIF_RECLACIFICACION = NIIF_RECLACIFICACIONController.Instance.GetBy_TIPO_DOCUMENTO_NUMERO_DOCUMENTO(tipo, numero);
	}

	return m_NIIF_RECLACIFICACION;
}
set { m_NIIF_RECLACIFICACION = value; }
}

/// <summary>
/// Gets or sets the reference to foreign NIIF_DOC_SALDO_PROVISIONList object accessed by tipo, numero
/// </summary>
public NIIF_DOC_SALDO_PROVISIONList NIIF_DOC_SALDO_PROVISION
{
	get
	{
		if (m_NIIF_DOC_SALDO_PROVISION == null)
		{
			m_NIIF_DOC_SALDO_PROVISION = NIIF_DOC_SALDO_PROVISIONController.Instance.GetBy_tipo_numero(tipo, numero);
	}

	return m_NIIF_DOC_SALDO_PROVISION;
}
set { m_NIIF_DOC_SALDO_PROVISION = value; }
}

/// <summary>
/// Gets or sets the reference to foreign dif_mov_auxList object accessed by tipo, numero
/// </summary>
public dif_mov_auxList dif_mov_aux
{
	get
	{
		if (m_dif_mov_aux == null)
		{
			m_dif_mov_aux = dif_mov_auxController.Instance.GetBy_tipo_conta_numero_conta(tipo, numero);
	}

	return m_dif_mov_aux;
}
set { m_dif_mov_aux = value; }
}

/// <summary>
/// Gets or sets the reference to foreign NIIF_RECLASIFICACIONList object accessed by tipo, numero
/// </summary>
public NIIF_RECLASIFICACIONList NIIF_RECLASIFICACION
{
	get
	{
		if (m_NIIF_RECLASIFICACION == null)
		{
			m_NIIF_RECLASIFICACION = NIIF_RECLASIFICACIONController.Instance.GetBy_TIPO_DOCUMENTO_NUMERO_DOCUMENTO(tipo, numero);
	}

	return m_NIIF_RECLASIFICACION;
}
set { m_NIIF_RECLASIFICACION = value; }
}

#endregion

}

#endregion

#region documentosList object

/// <summary>
/// Class for reading and access a list of documentos object
/// </summary>
[CollectionDataContract]
public partial class documentosList : List<documentos>
{

	/// <summary>
	/// Default constructor
	/// </summary>
	public documentosList()
	{
	}
}

#endregion

}
