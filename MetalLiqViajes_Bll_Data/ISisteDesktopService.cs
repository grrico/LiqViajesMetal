using System;
using System.Collections.Generic;
using System.Text;
using System.ServiceModel;
using LiqViajes_Bll_Data;

namespace LiqViajes_Bll_Data.Service
{
	/// <summary>
	/// Interface Definition for all classes
	/// </summary>
	[ServiceContract]
	public interface ISisteDesktopService
	{
		#region documentos_che
		[OperationContract]
		WCF.documentos_che documentos_che_Create(string tipo, int numero, short banco, string documento, byte forma_pago, byte sw, DateTime fecha, decimal valor, short consignar_en, string devuelto, string tipo_consignacion, int? numero_consignacion, DateTime? fecha_devolucion, string cuenta_banco, decimal? iva_tarjeta);

		[OperationContract]
		void documentos_che_Update(byte sw, string tipo, int numero, short banco, string documento, byte forma_pago, DateTime fecha, decimal valor, short consignar_en, string devuelto, string tipo_consignacion, int? numero_consignacion, DateTime? fecha_devolucion, string cuenta_banco, decimal? iva_tarjeta);

		[OperationContract]
		void documentos_che_Delete( string tipo, int numero, short banco, string documento, byte forma_pago);

		[OperationContract]
		WCF.documentos_che documentos_che_Get(string tipo, int numero, short banco, string documento, byte forma_pago);

		[OperationContract]
		WCF.documentos_cheList documentos_che_GetAll();

		[OperationContract]
		WCF.documentos_cheList documentos_che_GetFilter(int pagenum, int pagesize, string filter, string sort, string extablesfilter, string extablesfieldsfilter, string extablesrelationsfilter, string extablessort, string extablesfieldssort, string extablesrelationssort);

		#endregion 
		#region documentos_monto
		[OperationContract]
		WCF.documentos_monto documentos_monto_Create(string tipo, int numero, string monto);

		[OperationContract]
		void documentos_monto_Update(string tipo, int numero, string monto);

		[OperationContract]
		void documentos_monto_Delete( string tipo, int numero);

		[OperationContract]
		WCF.documentos_monto documentos_monto_Get(string tipo, int numero);

		[OperationContract]
		WCF.documentos_montoList documentos_monto_GetAll();

		[OperationContract]
		WCF.documentos_montoList documentos_monto_GetFilter(int pagenum, int pagesize, string filter, string sort, string extablesfilter, string extablesfieldsfilter, string extablesrelationsfilter, string extablessort, string extablesfieldssort, string extablesrelationssort);

		#endregion 
		#region Fecha
		[OperationContract]
		WCF.Fecha Fecha_Create(DateTime PK_Date, string Date_Name, DateTime? Year, string Year_Name, DateTime? Trimester, string Trimester_Name, DateTime? Month, string Month_Name, DateTime? Week, string Week_Name, int? Day_Of_Year, string Day_Of_Year_Name, int? Day_Of_Trimester, string Day_Of_Trimester_Name, int? Day_Of_Month, string Day_Of_Month_Name, int? Day_Of_Week, string Day_Of_Week_Name, int? Week_Of_Year, string Week_Of_Year_Name, int? Month_Of_Year, string Month_Of_Year_Name, int? Month_Of_Trimester, string Month_Of_Trimester_Name, int? Trimester_Of_Year, string Trimester_Of_Year_Name);

		[OperationContract]
		void Fecha_Update(DateTime PK_Date, string Date_Name, DateTime? Year, string Year_Name, DateTime? Trimester, string Trimester_Name, DateTime? Month, string Month_Name, DateTime? Week, string Week_Name, int? Day_Of_Year, string Day_Of_Year_Name, int? Day_Of_Trimester, string Day_Of_Trimester_Name, int? Day_Of_Month, string Day_Of_Month_Name, int? Day_Of_Week, string Day_Of_Week_Name, int? Week_Of_Year, string Week_Of_Year_Name, int? Month_Of_Year, string Month_Of_Year_Name, int? Month_Of_Trimester, string Month_Of_Trimester_Name, int? Trimester_Of_Year, string Trimester_Of_Year_Name);

		[OperationContract]
		void Fecha_Delete( DateTime PK_Date);

		[OperationContract]
		WCF.Fecha Fecha_Get(DateTime PK_Date);

		[OperationContract]
		WCF.FechaList Fecha_GetAll();

		[OperationContract]
		WCF.FechaList Fecha_GetFilter(int pagenum, int pagesize, string filter, string sort, string extablesfilter, string extablesfieldsfilter, string extablesrelationsfilter, string extablessort, string extablesfieldssort, string extablesrelationssort);

		#endregion 
		#region legalizacionViajes
		[OperationContract]
		WCF.legalizacionViajes legalizacionViajes_Create(long Codigo, int? lngIdRegistro, byte? sw, string tipo, long? numero, int? seq, DateTime? Fecha, decimal? nit, int? centro, string cuenta, string descripcion, decimal? valor, string notas);

		[OperationContract]
		void legalizacionViajes_Update(long Codigo, int? lngIdRegistro, byte? sw, string tipo, long? numero, int? seq, DateTime? Fecha, decimal? nit, int? centro, string cuenta, string descripcion, decimal? valor, string notas);

		[OperationContract]
		void legalizacionViajes_Delete( long Codigo);

		[OperationContract]
		WCF.legalizacionViajes legalizacionViajes_Get(long Codigo);

		[OperationContract]
		WCF.legalizacionViajesList legalizacionViajes_GetAll();

		[OperationContract]
		WCF.legalizacionViajesList legalizacionViajes_GetFilter(int pagenum, int pagesize, string filter, string sort, string extablesfilter, string extablesfieldsfilter, string extablesrelationsfilter, string extablessort, string extablesfieldssort, string extablesrelationssort);

		#endregion 
		#region novedades_nomina
		[OperationContract]
		WCF.novedades_nomina novedades_nomina_Create(int IdNovedad, string nomina, int contrato, string nit, int idperiodo, int centro, byte planta, short concepto, DateTime fecha, byte? mes, short? ano, int? periodo, decimal? valor, float? horas, float? dias, byte? turno, char? estado, int? nro_presta, short? cpto_interes, bool? sumar, string oficio, string tipo_doc, int? numero_doc, int? cuota);

		[OperationContract]
		void novedades_nomina_Update(int IdNovedad, string nomina, int contrato, string nit, int idperiodo, short concepto, DateTime fecha, byte? mes, short? ano, int? periodo, decimal? valor, float? horas, float? dias, int centro, byte planta, byte? turno, char? estado, int? nro_presta, short? cpto_interes, bool? sumar, string oficio, string tipo_doc, int? numero_doc, int? cuota);

		[OperationContract]
		void novedades_nomina_Delete( int IdNovedad, string nomina, int contrato, string nit, int idperiodo, int centro, byte planta);

		[OperationContract]
		WCF.novedades_nomina novedades_nomina_Get(int IdNovedad, string nomina, int contrato, string nit, int idperiodo, int centro, byte planta);

		[OperationContract]
		WCF.novedades_nominaList novedades_nomina_GetAll();

		[OperationContract]
		WCF.novedades_nominaList novedades_nomina_GetFilter(int pagenum, int pagesize, string filter, string sort, string extablesfilter, string extablesfieldsfilter, string extablesrelationsfilter, string extablessort, string extablesfieldssort, string extablesrelationssort);

		#endregion 
		#region ObservacioneComplementarias
		[OperationContract]
		WCF.ObservacioneComplementarias ObservacioneComplementarias_Create(int Codigo, string Origen, string Destino, string Cuenta, int? Fila, string DetalleObservacion);

		[OperationContract]
		void ObservacioneComplementarias_Update(int Codigo, string Origen, string Destino, string Cuenta, int? Fila, string DetalleObservacion);

		[OperationContract]
		void ObservacioneComplementarias_Delete( int Codigo);

		[OperationContract]
		WCF.ObservacioneComplementarias ObservacioneComplementarias_Get(int Codigo);

		[OperationContract]
		WCF.ObservacioneComplementariasList ObservacioneComplementarias_GetAll();

		[OperationContract]
		WCF.ObservacioneComplementariasList ObservacioneComplementarias_GetFilter(int pagenum, int pagesize, string filter, string sort, string extablesfilter, string extablesfieldsfilter, string extablesrelationsfilter, string extablessort, string extablesfieldssort, string extablesrelationssort);

		#endregion 
		#region ParametrosGenerales
		[OperationContract]
		WCF.ParametrosGenerales ParametrosGenerales_Create(int Codigo, string Descipcion, string ValorParametro);

		[OperationContract]
		void ParametrosGenerales_Update(int Codigo, string Descipcion, string ValorParametro);

		[OperationContract]
		void ParametrosGenerales_Delete( int Codigo);

		[OperationContract]
		WCF.ParametrosGenerales ParametrosGenerales_Get(int Codigo);

		[OperationContract]
		WCF.ParametrosGeneralesList ParametrosGenerales_GetAll();

		[OperationContract]
		WCF.ParametrosGeneralesList ParametrosGenerales_GetFilter(int pagenum, int pagesize, string filter, string sort, string extablesfilter, string extablesfieldsfilter, string extablesrelationsfilter, string extablessort, string extablesfieldssort, string extablesrelationssort);

		#endregion 
		#region Reportes
		[OperationContract]
		WCF.Reportes Reportes_Create(int Codigo, string Descripcion, bool? Activo, string strSQql);

		[OperationContract]
		void Reportes_Update(int Codigo, string Descripcion, bool? Activo, string strSQql);

		[OperationContract]
		void Reportes_Delete( int Codigo);

		[OperationContract]
		WCF.Reportes Reportes_Get(int Codigo);

		[OperationContract]
		WCF.ReportesList Reportes_GetAll();

		[OperationContract]
		WCF.ReportesList Reportes_GetFilter(int pagenum, int pagesize, string filter, string sort, string extablesfilter, string extablesfieldsfilter, string extablesrelationsfilter, string extablessort, string extablesfieldssort, string extablesrelationssort);

		#endregion 
		#region RutaNueva
		[OperationContract]
		WCF.RutaNueva RutaNueva_Create(int lngIdRegistrRuta, string strRutaAnticipoGrupoOrigen, string strRutaAnticipoGrupoDestino, string strRutaAnticipoGrupo, string strRutaAnticipo, double? TipoVehiculoCodigo, string TipoVehiculo, double? TipoTrailerCodigo, double? Peso, string Programa, double? logViajeVacio, double? floGalones, double? curValorGalon, double? cutCombustible, double? lngIdNroPeajes, double? cutPeaje, string strNombrePeajes, double? cutVariosLlantas, double? cutVariosCelada, double? cutVariosPropina, double? cutVarios, double? Llamadas, double? Taxis, double? Aseo, double? cutVariosLlantasVacio, double? cutVariosCeladaVacio, double? cutVariosPropinaVacio, double? cutVariosVacio, double? Viaticos, double? cutParticipacion, double? cutParticipacionVacio, double? curHotelCarretera, double? curHotelCiudad, double? curHotel, double? curHotelCarreteraVacio, double? curHotelCiudadVacio, double? curHotelVacio, double? intTiempoCargue, double? intTiempoDescargue, double? intTiempoAduana, double? intTotalTrayecto, double? intTotalTiempo, double? curComida, double? intTiempoCargueVacio, double? intTiempoDescargueVacio, double? intTiempoAduanaVacio, double? intTotalTrayectoVacio, double? intTotalTiempoVacio, double? curComidaVacio, double? curDesvareManoRepuestos, double? curDesvareManoObra, double? cutSaldo, double? cutSaldoVacio, double? cutKmts, double? logActualizaPeajes, double? intFactorKmPorGalon, double? logEstadoRuta);

		[OperationContract]
		void RutaNueva_Update(int lngIdRegistrRuta, string strRutaAnticipoGrupoOrigen, string strRutaAnticipoGrupoDestino, string strRutaAnticipoGrupo, string strRutaAnticipo, double? TipoVehiculoCodigo, string TipoVehiculo, double? TipoTrailerCodigo, double? Peso, string Programa, double? logViajeVacio, double? floGalones, double? curValorGalon, double? cutCombustible, double? lngIdNroPeajes, double? cutPeaje, string strNombrePeajes, double? cutVariosLlantas, double? cutVariosCelada, double? cutVariosPropina, double? cutVarios, double? Llamadas, double? Taxis, double? Aseo, double? cutVariosLlantasVacio, double? cutVariosCeladaVacio, double? cutVariosPropinaVacio, double? cutVariosVacio, double? Viaticos, double? cutParticipacion, double? cutParticipacionVacio, double? curHotelCarretera, double? curHotelCiudad, double? curHotel, double? curHotelCarreteraVacio, double? curHotelCiudadVacio, double? curHotelVacio, double? intTiempoCargue, double? intTiempoDescargue, double? intTiempoAduana, double? intTotalTrayecto, double? intTotalTiempo, double? curComida, double? intTiempoCargueVacio, double? intTiempoDescargueVacio, double? intTiempoAduanaVacio, double? intTotalTrayectoVacio, double? intTotalTiempoVacio, double? curComidaVacio, double? curDesvareManoRepuestos, double? curDesvareManoObra, double? cutSaldo, double? cutSaldoVacio, double? cutKmts, double? logActualizaPeajes, double? intFactorKmPorGalon, double? logEstadoRuta);

		[OperationContract]
		void RutaNueva_Delete( int lngIdRegistrRuta);

		[OperationContract]
		WCF.RutaNueva RutaNueva_Get(int lngIdRegistrRuta);

		[OperationContract]
		WCF.RutaNuevaList RutaNueva_GetAll();

		[OperationContract]
		WCF.RutaNuevaList RutaNueva_GetFilter(int pagenum, int pagesize, string filter, string sort, string extablesfilter, string extablesfieldsfilter, string extablesrelationsfilter, string extablessort, string extablesfieldssort, string extablesrelationssort);

		#endregion 
		#region tablagLocal
		[OperationContract]
		WCF.tablagLocal tablagLocal_Create(int Codigo, int? ano, int? periodo, DateTime? fecha);

		[OperationContract]
		void tablagLocal_Update(int Codigo, int? ano, int? periodo, DateTime? fecha);

		[OperationContract]
		void tablagLocal_Delete( int Codigo);

		[OperationContract]
		WCF.tablagLocal tablagLocal_Get(int Codigo);

		[OperationContract]
		WCF.tablagLocalList tablagLocal_GetAll();

		[OperationContract]
		WCF.tablagLocalList tablagLocal_GetFilter(int pagenum, int pagesize, string filter, string sort, string extablesfilter, string extablesfieldsfilter, string extablesrelationsfilter, string extablessort, string extablesfieldssort, string extablesrelationssort);

		#endregion 
		#region A2MontoEscrito
		[OperationContract]
		WCF.A2MontoEscrito A2MontoEscrito_Create(byte bytTipoCifra, byte bytPosicionCifra, string strCifra);

		[OperationContract]
		WCF.A2MontoEscritoList A2MontoEscrito_GetAll();

		[OperationContract]
		WCF.A2MontoEscritoList A2MontoEscrito_GetFilter(int pagenum, int pagesize, string filter, string sort, string extablesfilter, string extablesfieldsfilter, string extablesrelationsfilter, string extablessort, string extablesfieldssort, string extablesrelationssort);

		#endregion 
		#region Catalogo
		[OperationContract]
		WCF.Catalogo Catalogo_Create(string nombre_empresa, DateTime fecha_actual, string sigla, int nit, int version, string direccion, string telefono);

		[OperationContract]
		void Catalogo_Update(string nombre_empresa, DateTime fecha_actual, string sigla, int nit, int version, string direccion, string telefono);

		[OperationContract]
		void Catalogo_Delete( string nombre_empresa);

		[OperationContract]
		WCF.Catalogo Catalogo_Get(string nombre_empresa);

		[OperationContract]
		WCF.CatalogoList Catalogo_GetAll();

		[OperationContract]
		WCF.CatalogoList Catalogo_GetFilter(int pagenum, int pagesize, string filter, string sort, string extablesfilter, string extablesfieldsfilter, string extablesrelationsfilter, string extablessort, string extablesfieldssort, string extablesrelationssort);

		#endregion 
		#region Ciudades
		[OperationContract]
		WCF.Ciudades Ciudades_Create(int lngIdCiudad, int lngIdDepartamento, string strNombreCiudad);

		[OperationContract]
		void Ciudades_Update(int lngIdCiudad, int lngIdDepartamento, string strNombreCiudad);

		[OperationContract]
		void Ciudades_Delete( int lngIdCiudad);

		[OperationContract]
		WCF.Ciudades Ciudades_Get(int lngIdCiudad);

		[OperationContract]
		WCF.CiudadesList Ciudades_GetAll();

		[OperationContract]
		WCF.CiudadesList Ciudades_GetFilter(int pagenum, int pagesize, string filter, string sort, string extablesfilter, string extablesfieldsfilter, string extablesrelationsfilter, string extablessort, string extablesfieldssort, string extablesrelationssort);

		#endregion 
		#region Cuentas
		[OperationContract]
		WCF.Cuentas Cuentas_Create(int Codigo, string strCuenta, string strDescripcion, bool? logAnticipo, string nitTercero, int? intNoColReferencia, double? sngPorcenrajeAplica, string strCuentaAplica, string strCuentaNiif, string Norma);

		[OperationContract]
		void Cuentas_Update(int Codigo, string strCuenta, string strDescripcion, bool? logAnticipo, string nitTercero, int? intNoColReferencia, double? sngPorcenrajeAplica, string strCuentaAplica, string strCuentaNiif, string Norma);

		[OperationContract]
		void Cuentas_Delete( int Codigo);

		[OperationContract]
		WCF.Cuentas Cuentas_Get(int Codigo);

		[OperationContract]
		WCF.CuentasList Cuentas_GetAll();

		[OperationContract]
		WCF.CuentasList Cuentas_GetFilter(int pagenum, int pagesize, string filter, string sort, string extablesfilter, string extablesfieldsfilter, string extablesrelationsfilter, string extablessort, string extablesfieldssort, string extablesrelationssort);

		#endregion 
		#region CuentasVarios
		[OperationContract]
		WCF.CuentasVarios CuentasVarios_Create(string strCuenta, string strDescripcion, string nitTercero);

		[OperationContract]
		void CuentasVarios_Update(string strCuenta, string strDescripcion, string nitTercero);

		[OperationContract]
		void CuentasVarios_Delete( string strCuenta);

		[OperationContract]
		WCF.CuentasVarios CuentasVarios_Get(string strCuenta);

		[OperationContract]
		WCF.CuentasVariosList CuentasVarios_GetAll();

		[OperationContract]
		WCF.CuentasVariosList CuentasVarios_GetFilter(int pagenum, int pagesize, string filter, string sort, string extablesfilter, string extablesfieldsfilter, string extablesrelationsfilter, string extablessort, string extablesfieldssort, string extablesrelationssort);

		#endregion 
		#region Departamentos
		[OperationContract]
		WCF.Departamentos Departamentos_Create(int lngIdDepartamento, int lngIdPais, string strNombre);

		[OperationContract]
		void Departamentos_Update(int lngIdDepartamento, int lngIdPais, string strNombre);

		[OperationContract]
		void Departamentos_Delete( int lngIdDepartamento);

		[OperationContract]
		WCF.Departamentos Departamentos_Get(int lngIdDepartamento);

		[OperationContract]
		WCF.DepartamentosList Departamentos_GetAll();

		[OperationContract]
		WCF.DepartamentosList Departamentos_GetFilter(int pagenum, int pagesize, string filter, string sort, string extablesfilter, string extablesfieldsfilter, string extablesrelationsfilter, string extablessort, string extablesfieldssort, string extablesrelationssort);

		#endregion 
		#region Documento_Referencia
		[OperationContract]
		WCF.Documento_Referencia Documento_Referencia_Create(byte sw, string tipo, int numero, int? lngIdRegistro, DateTime fecha, decimal valor, decimal? ValorCruce);

		[OperationContract]
		void Documento_Referencia_Update(int? lngIdRegistro, byte sw, string tipo, int numero, DateTime fecha, decimal valor, decimal? ValorCruce);

		[OperationContract]
		void Documento_Referencia_Delete( byte sw, string tipo, int numero);

		[OperationContract]
		WCF.Documento_Referencia Documento_Referencia_Get(byte sw, string tipo, int numero);

		[OperationContract]
		WCF.Documento_ReferenciaList Documento_Referencia_GetAll();

		[OperationContract]
		WCF.Documento_ReferenciaList Documento_Referencia_GetFilter(int pagenum, int pagesize, string filter, string sort, string extablesfilter, string extablesfieldsfilter, string extablesrelationsfilter, string extablessort, string extablesfieldssort, string extablesrelationssort);

		#endregion 
		#region LiquidacionAnticipos
		[OperationContract]
		WCF.LiquidacionAnticipos LiquidacionAnticipos_Create(int lngIdRegistroViaje, decimal lngIdRegistroViajeTramo, decimal intNitConductor, string strPlaca, double lngIdBanco, int intDocumento, string strModelo, string strtipo, string strConductor, DateTime? dtmFechaMovimiento, string strdescripcionBanco, byte? sw, DateTime? dtmFechaMovDMS, string strCuenta, string strCuenta2, string strdescripcionCuenta, string strdescripcionCuenta2, decimal? curValor, string strdescripcionModelo, string strNota, string strdocumento, string strUsuarioDMS, DateTime? dtmfechahoraSYSDMS, int? intUsuario, DateTime? dtmFechaModif, bool? logAnulado, bool? logLiquidado);

		[OperationContract]
		void LiquidacionAnticipos_Update(int lngIdRegistroViaje, decimal lngIdRegistroViajeTramo, decimal intNitConductor, string strConductor, string strPlaca, DateTime? dtmFechaMovimiento, double lngIdBanco, string strdescripcionBanco, int intDocumento, string strModelo, string strtipo, byte? sw, DateTime? dtmFechaMovDMS, string strCuenta, string strCuenta2, string strdescripcionCuenta, string strdescripcionCuenta2, decimal? curValor, string strdescripcionModelo, string strNota, string strdocumento, string strUsuarioDMS, DateTime? dtmfechahoraSYSDMS, int? intUsuario, DateTime? dtmFechaModif, bool? logAnulado, bool? logLiquidado);

		[OperationContract]
		void LiquidacionAnticipos_Delete( int lngIdRegistroViaje, decimal lngIdRegistroViajeTramo, decimal intNitConductor, string strPlaca, double lngIdBanco, int intDocumento, string strModelo, string strtipo);

		[OperationContract]
		WCF.LiquidacionAnticipos LiquidacionAnticipos_Get(int lngIdRegistroViaje, decimal lngIdRegistroViajeTramo, decimal intNitConductor, string strPlaca, double lngIdBanco, int intDocumento, string strModelo, string strtipo);

		[OperationContract]
		WCF.LiquidacionAnticiposList LiquidacionAnticipos_GetAll();

		[OperationContract]
		WCF.LiquidacionAnticiposList LiquidacionAnticipos_GetFilter(int pagenum, int pagesize, string filter, string sort, string extablesfilter, string extablesfieldsfilter, string extablesrelationsfilter, string extablessort, string extablesfieldssort, string extablesrelationssort);

		#endregion 
		#region LiquidacionGastos
		[OperationContract]
		WCF.LiquidacionGastos LiquidacionGastos_Create(int lngIdRegistrRutaItemId, decimal lngIdRegistroViaje, int lngIdRegistrRuta, string strCuenta, int intRowRegistro, string strDescripcionCuenta, string strDescripcion, DateTime? dtmFechaAsignacion, decimal? curValorTramo, decimal? curValorAdicional, decimal? curValorTotal, string strObservaciones, string nitTercero, string strPlaca, int? lngIdUsuario, bool? logLiquidado, DateTime? dtmFechaSalida, DateTime? dtmFechaLlegada, DateTime? dtmFechaModif, bool? LogExcluido, decimal? floGalones, decimal? floGalonesAdicional, decimal? floGalonesReales, decimal? curValorGalon, decimal? CombustibleCarretera, decimal? cutCombustible, bool? LogAnticipoACPM, bool? AntipoConductor);

		[OperationContract]
		void LiquidacionGastos_Update(int lngIdRegistrRutaItemId, decimal lngIdRegistroViaje, int lngIdRegistrRuta, string strCuenta, int intRowRegistro, string strDescripcionCuenta, string strDescripcion, DateTime? dtmFechaAsignacion, decimal? curValorTramo, decimal? curValorAdicional, decimal? curValorTotal, string strObservaciones, string nitTercero, string strPlaca, int? lngIdUsuario, bool? logLiquidado, DateTime? dtmFechaSalida, DateTime? dtmFechaLlegada, DateTime? dtmFechaModif, bool? LogExcluido, decimal? floGalones, decimal? floGalonesAdicional, decimal? floGalonesReales, decimal? curValorGalon, decimal? CombustibleCarretera, decimal? cutCombustible, bool? LogAnticipoACPM, bool? AntipoConductor);

		[OperationContract]
		void LiquidacionGastos_Delete( int lngIdRegistrRutaItemId, decimal lngIdRegistroViaje, int lngIdRegistrRuta, string strCuenta, int intRowRegistro);

		[OperationContract]
		WCF.LiquidacionGastos LiquidacionGastos_Get(int lngIdRegistrRutaItemId, decimal lngIdRegistroViaje, int lngIdRegistrRuta, string strCuenta, int intRowRegistro);

		[OperationContract]
		WCF.LiquidacionGastosList LiquidacionGastos_GetAll();

		[OperationContract]
		WCF.LiquidacionGastosList LiquidacionGastos_GetFilter(int pagenum, int pagesize, string filter, string sort, string extablesfilter, string extablesfieldsfilter, string extablesrelationsfilter, string extablessort, string extablesfieldssort, string extablesrelationssort);

		#endregion 
		#region LiquidacionPlanilla
		[OperationContract]
		WCF.LiquidacionPlanilla LiquidacionPlanilla_Create(int lngIdRegistro, int lngIdRegistrRutaItemId, int lngIdRegistrRuta, string strNoPlanilla, decimal? curValorFlete, DateTime? dtmFechaModif, bool? logDesplazaVacio, bool? logSePuedeLiquidar);

		[OperationContract]
		void LiquidacionPlanilla_Update(int lngIdRegistro, int lngIdRegistrRutaItemId, int lngIdRegistrRuta, string strNoPlanilla, decimal? curValorFlete, DateTime? dtmFechaModif, bool? logDesplazaVacio, bool? logSePuedeLiquidar);

		[OperationContract]
		void LiquidacionPlanilla_Delete( int lngIdRegistro, int lngIdRegistrRutaItemId, int lngIdRegistrRuta);

		[OperationContract]
		WCF.LiquidacionPlanilla LiquidacionPlanilla_Get(int lngIdRegistro, int lngIdRegistrRutaItemId, int lngIdRegistrRuta);

		[OperationContract]
		WCF.LiquidacionPlanillaList LiquidacionPlanilla_GetAll();

		[OperationContract]
		WCF.LiquidacionPlanillaList LiquidacionPlanilla_GetFilter(int pagenum, int pagesize, string filter, string sort, string extablesfilter, string extablesfieldsfilter, string extablesrelationsfilter, string extablessort, string extablesfieldssort, string extablesrelationssort);

		#endregion 
		#region LiquidacionPlanillaDet
		[OperationContract]
		WCF.LiquidacionPlanillaDet LiquidacionPlanillaDet_Create(int lngIdItemd, int? lngIdRegistro, int? lngIdRegistrRuta, int? lngIdRegistrRutaItemId, string strNoPlanilla, DateTime? dtmFechaModif);

		[OperationContract]
		void LiquidacionPlanillaDet_Update(int lngIdItemd, int? lngIdRegistro, int? lngIdRegistrRuta, int? lngIdRegistrRutaItemId, string strNoPlanilla, DateTime? dtmFechaModif);

		[OperationContract]
		void LiquidacionPlanillaDet_Delete( int lngIdItemd);

		[OperationContract]
		WCF.LiquidacionPlanillaDet LiquidacionPlanillaDet_Get(int lngIdItemd);

		[OperationContract]
		WCF.LiquidacionPlanillaDetList LiquidacionPlanillaDet_GetAll();

		[OperationContract]
		WCF.LiquidacionPlanillaDetList LiquidacionPlanillaDet_GetFilter(int pagenum, int pagesize, string filter, string sort, string extablesfilter, string extablesfieldsfilter, string extablesrelationsfilter, string extablessort, string extablesfieldssort, string extablesrelationssort);

		#endregion 
		#region LiquidacionRutas
		[OperationContract]
		WCF.LiquidacionRutas LiquidacionRutas_Create(int lngIdRegistrRutaItemId, int? lngIdRegistrRuta, int? lngIdRegistro, int? lngIdRegistrRutaItemIdAjc, string strRutaAnticipoGrupoOrigen, string strRutaAnticipoGrupoDestino, string strRutaAnticipoGrupo, string strRutaAnticipo, bool? logLiquidado, string PlacaTrayler, string Trailer, decimal? floGalones, decimal? floGalonesReales, decimal? floGalonesReserva, decimal? curValorGalon, decimal? CombustibleCarretera, decimal? cutCombustible, bool? LogAnticipoACPM, decimal? cutValorAnticipo, int? lngIdNroPeajes, decimal? cutPeaje, string strNombrePeajes, decimal? cutVariosLlantas, decimal? cutVariosCelada, decimal? cutVariosPropina, decimal? cutVarios, decimal? cutVariosLlantasVacio, decimal? cutVariosCeladaVacio, decimal? cutVariosPropinaVacio, decimal? cutVariosVacio, decimal? cutParticipacion, decimal? cutParticipacionVacio, int? curHotelCarretera, int? curHotelCiudad, decimal? curHotel, int? curHotelCarreteraVacio, int? curHotelCiudadVacio, decimal? curHotelVacio, decimal? intTiempoCargue, decimal? intTiempoDescargue, decimal? intTiempoAduana, decimal? intTotalTrayecto, decimal? intTotalTiempo, decimal? curComida, decimal? intTiempoCargueVacio, decimal? intTiempoDescargueVacio, decimal? intTiempoAduanaVacio, decimal? intTotalTrayectoVacio, decimal? intTotalTiempoVacio, decimal? curComidaVacio, decimal? curDesvareManoRepuestos, decimal? curDesvareManoObra, decimal? cutSaldo, decimal? cutKmts, bool? logAjuste, DateTime? dtmFechaModif, bool? logVacio, int? TipoVehiculoCodigo, string TipoVehiculo, int? TipoTrailerCodigo, int? Peso, string Contenedor1, string Contenedor2, int? FactorCalculoDia, decimal? ValorCalculoFactor, decimal? ParqueaderoCarretera, decimal? ParqueaderoCiudad, decimal? MontadaLLantaCarretera, decimal? MontadaLLantaCiudad, decimal? AjusteCarretera, decimal? Taxi, decimal? Aseo, decimal? Amarres, decimal? Engradasa, decimal? Calibrada, bool? Liquidado, decimal? Lavada, bool? logEstadoRuta, decimal? Papeleria, bool? logFavorito, decimal? CurCargue, decimal? CurDescargue, bool? logLiquParticipacion);

		[OperationContract]
		void LiquidacionRutas_Update(int lngIdRegistrRutaItemId, int? lngIdRegistrRuta, int? lngIdRegistro, int? lngIdRegistrRutaItemIdAjc, string strRutaAnticipoGrupoOrigen, string strRutaAnticipoGrupoDestino, string strRutaAnticipoGrupo, string strRutaAnticipo, bool? logLiquidado, string PlacaTrayler, string Trailer, decimal? floGalones, decimal? floGalonesReales, decimal? floGalonesReserva, decimal? curValorGalon, decimal? CombustibleCarretera, decimal? cutCombustible, bool? LogAnticipoACPM, decimal? cutValorAnticipo, int? lngIdNroPeajes, decimal? cutPeaje, string strNombrePeajes, decimal? cutVariosLlantas, decimal? cutVariosCelada, decimal? cutVariosPropina, decimal? cutVarios, decimal? cutVariosLlantasVacio, decimal? cutVariosCeladaVacio, decimal? cutVariosPropinaVacio, decimal? cutVariosVacio, decimal? cutParticipacion, decimal? cutParticipacionVacio, int? curHotelCarretera, int? curHotelCiudad, decimal? curHotel, int? curHotelCarreteraVacio, int? curHotelCiudadVacio, decimal? curHotelVacio, decimal? intTiempoCargue, decimal? intTiempoDescargue, decimal? intTiempoAduana, decimal? intTotalTrayecto, decimal? intTotalTiempo, decimal? curComida, decimal? intTiempoCargueVacio, decimal? intTiempoDescargueVacio, decimal? intTiempoAduanaVacio, decimal? intTotalTrayectoVacio, decimal? intTotalTiempoVacio, decimal? curComidaVacio, decimal? curDesvareManoRepuestos, decimal? curDesvareManoObra, decimal? cutSaldo, decimal? cutKmts, bool? logAjuste, DateTime? dtmFechaModif, bool? logVacio, int? TipoVehiculoCodigo, string TipoVehiculo, int? TipoTrailerCodigo, int? Peso, string Contenedor1, string Contenedor2, int? FactorCalculoDia, decimal? ValorCalculoFactor, decimal? ParqueaderoCarretera, decimal? ParqueaderoCiudad, decimal? MontadaLLantaCarretera, decimal? MontadaLLantaCiudad, decimal? AjusteCarretera, decimal? Taxi, decimal? Aseo, decimal? Amarres, decimal? Engradasa, decimal? Calibrada, bool? Liquidado, decimal? Lavada, bool? logEstadoRuta, decimal? Papeleria, bool? logFavorito, decimal? CurCargue, decimal? CurDescargue, bool? logLiquParticipacion);

		[OperationContract]
		void LiquidacionRutas_Delete( int lngIdRegistrRutaItemId);

		[OperationContract]
		WCF.LiquidacionRutas LiquidacionRutas_Get(int lngIdRegistrRutaItemId);

		[OperationContract]
		WCF.LiquidacionRutasList LiquidacionRutas_GetAll();

		[OperationContract]
		WCF.LiquidacionRutasList LiquidacionRutas_GetFilter(int pagenum, int pagesize, string filter, string sort, string extablesfilter, string extablesfieldsfilter, string extablesrelationsfilter, string extablessort, string extablesfieldssort, string extablesrelationssort);

		#endregion 
		#region LiquidacionRutasCombustible
		[OperationContract]
		WCF.LiquidacionRutasCombustible LiquidacionRutasCombustible_Create(long Codigo, int? lngIdRegistrRutaItemId, int? lngIdRegistro, int? lngIdRegistrRuta, int? intRowRegistro, string strRutaAnticipoGrupoOrigen, string strRutaAnticipoGrupoDestino, string nitTercero, string NombreTercero, decimal? floGalones, decimal? curValorGalon, decimal? cutCombustible, string nitTerceroComplentario, string NombreTerceroComplementario, decimal? floGalonesComplementario, decimal? curValorGalonComplentario, decimal? cutCombustibleComplementario, string strObservaciones);

		[OperationContract]
		void LiquidacionRutasCombustible_Update(long Codigo, int? lngIdRegistrRutaItemId, int? lngIdRegistro, int? lngIdRegistrRuta, int? intRowRegistro, string strRutaAnticipoGrupoOrigen, string strRutaAnticipoGrupoDestino, string nitTercero, string NombreTercero, decimal? floGalones, decimal? curValorGalon, decimal? cutCombustible, string nitTerceroComplentario, string NombreTerceroComplementario, decimal? floGalonesComplementario, decimal? curValorGalonComplentario, decimal? cutCombustibleComplementario, string strObservaciones);

		[OperationContract]
		void LiquidacionRutasCombustible_Delete( long Codigo);

		[OperationContract]
		WCF.LiquidacionRutasCombustible LiquidacionRutasCombustible_Get(long Codigo);

		[OperationContract]
		WCF.LiquidacionRutasCombustibleList LiquidacionRutasCombustible_GetAll();

		[OperationContract]
		WCF.LiquidacionRutasCombustibleList LiquidacionRutasCombustible_GetFilter(int pagenum, int pagesize, string filter, string sort, string extablesfilter, string extablesfieldsfilter, string extablesrelationsfilter, string extablessort, string extablesfieldssort, string extablesrelationssort);

		#endregion 
		#region LiquidacionRutasObs
		[OperationContract]
		WCF.LiquidacionRutasObs LiquidacionRutasObs_Create(int lngItemsId, int? lngIdRegistrRutaItemId, int? lngIdRegistrRuta, int? lngIdRegistro, string strCampo, string strObservacion, string nitTercero, DateTime? dtmFechaModif);

		[OperationContract]
		void LiquidacionRutasObs_Update(int lngItemsId, int? lngIdRegistrRutaItemId, int? lngIdRegistrRuta, int? lngIdRegistro, string strCampo, string strObservacion, string nitTercero, DateTime? dtmFechaModif);

		[OperationContract]
		void LiquidacionRutasObs_Delete( int lngItemsId);

		[OperationContract]
		WCF.LiquidacionRutasObs LiquidacionRutasObs_Get(int lngItemsId);

		[OperationContract]
		WCF.LiquidacionRutasObsList LiquidacionRutasObs_GetAll();

		[OperationContract]
		WCF.LiquidacionRutasObsList LiquidacionRutasObs_GetFilter(int pagenum, int pagesize, string filter, string sort, string extablesfilter, string extablesfieldsfilter, string extablesrelationsfilter, string extablessort, string extablesfieldssort, string extablesrelationssort);

		#endregion 
		#region LiquidacionSaldoConductor
		[OperationContract]
		WCF.LiquidacionSaldoConductor LiquidacionSaldoConductor_Create(int lngIdRegistro, decimal intNitConductor, decimal? curValorSaldo, DateTime? dtmFechaModif, byte? sw, string strTipo, int? numero, int? lngIdRegistroLiq);

		[OperationContract]
		void LiquidacionSaldoConductor_Update(int lngIdRegistro, decimal intNitConductor, decimal? curValorSaldo, DateTime? dtmFechaModif, byte? sw, string strTipo, int? numero, int? lngIdRegistroLiq);

		[OperationContract]
		void LiquidacionSaldoConductor_Delete( int lngIdRegistro, decimal intNitConductor);

		[OperationContract]
		WCF.LiquidacionSaldoConductor LiquidacionSaldoConductor_Get(int lngIdRegistro, decimal intNitConductor);

		[OperationContract]
		WCF.LiquidacionSaldoConductorList LiquidacionSaldoConductor_GetAll();

		[OperationContract]
		WCF.LiquidacionSaldoConductorList LiquidacionSaldoConductor_GetFilter(int pagenum, int pagesize, string filter, string sort, string extablesfilter, string extablesfieldsfilter, string extablesrelationsfilter, string extablessort, string extablesfieldssort, string extablesrelationssort);

		#endregion 
		#region LiquidacionVehiculo
		[OperationContract]
		WCF.LiquidacionVehiculo LiquidacionVehiculo_Create(int lngIdRegistro, string strPlaca, decimal? intNitConductor, decimal? curGastos, decimal? curAnticipos, decimal? curTotal, DateTime? dtmFechaModif, bool? logLiquidado, float? sngRentabilidad, decimal? curValorFleteAcum, bool? logDesplazaVacio, bool? logSePuedeLiquidar, decimal? curValorFlete, decimal? curvalorUtilidad, decimal? curValorRentabilidad, decimal? TotalGalones, decimal? cutCombustible, decimal? cutParticipacion, decimal? cutParticipacionVacio, bool? logLiquParticipacion, bool? logLiquKilometros, decimal? curValorKilometros, int? Kilometros);

		[OperationContract]
		void LiquidacionVehiculo_Update(int lngIdRegistro, string strPlaca, decimal? intNitConductor, decimal? curGastos, decimal? curAnticipos, decimal? curTotal, DateTime? dtmFechaModif, bool? logLiquidado, float? sngRentabilidad, decimal? curValorFleteAcum, bool? logDesplazaVacio, bool? logSePuedeLiquidar, decimal? curValorFlete, decimal? curvalorUtilidad, decimal? curValorRentabilidad, decimal? TotalGalones, decimal? cutCombustible, decimal? cutParticipacion, decimal? cutParticipacionVacio, bool? logLiquParticipacion, bool? logLiquKilometros, decimal? curValorKilometros, int? Kilometros);

		[OperationContract]
		void LiquidacionVehiculo_Delete( int lngIdRegistro);

		[OperationContract]
		WCF.LiquidacionVehiculo LiquidacionVehiculo_Get(int lngIdRegistro);

		[OperationContract]
		WCF.LiquidacionVehiculoList LiquidacionVehiculo_GetAll();

		[OperationContract]
		WCF.LiquidacionVehiculoList LiquidacionVehiculo_GetFilter(int pagenum, int pagesize, string filter, string sort, string extablesfilter, string extablesfieldsfilter, string extablesrelationsfilter, string extablessort, string extablesfieldssort, string extablesrelationssort);

		#endregion 
		#region MarcasVehiculos
		[OperationContract]
		WCF.MarcasVehiculos MarcasVehiculos_Create(int lngIdRegistro, string strMarca);

		[OperationContract]
		void MarcasVehiculos_Update(int lngIdRegistro, string strMarca);

		[OperationContract]
		void MarcasVehiculos_Delete( int lngIdRegistro);

		[OperationContract]
		WCF.MarcasVehiculos MarcasVehiculos_Get(int lngIdRegistro);

		[OperationContract]
		WCF.MarcasVehiculosList MarcasVehiculos_GetAll();

		[OperationContract]
		WCF.MarcasVehiculosList MarcasVehiculos_GetFilter(int pagenum, int pagesize, string filter, string sort, string extablesfilter, string extablesfieldsfilter, string extablesrelationsfilter, string extablessort, string extablesfieldssort, string extablesrelationssort);

		#endregion 
		#region Opciones
		[OperationContract]
		WCF.Opciones Opciones_Create(int lngIdOpcion, string strDescOpcion, string strPrograma, string strParametros, int? lngIdOpcionPadre, string strTipoOpcion, int? intOrden, bool? WebBrowser, bool? logExpandeNode);

		[OperationContract]
		void Opciones_Update(int lngIdOpcion, string strDescOpcion, string strPrograma, string strParametros, int? lngIdOpcionPadre, string strTipoOpcion, int? intOrden, bool? WebBrowser, bool? logExpandeNode);

		[OperationContract]
		void Opciones_Delete( int lngIdOpcion);

		[OperationContract]
		WCF.Opciones Opciones_Get(int lngIdOpcion);

		[OperationContract]
		WCF.OpcionesList Opciones_GetAll();

		[OperationContract]
		WCF.OpcionesList Opciones_GetFilter(int pagenum, int pagesize, string filter, string sort, string extablesfilter, string extablesfieldsfilter, string extablesrelationsfilter, string extablessort, string extablesfieldssort, string extablesrelationssort);

		#endregion 
		#region OpcionesDetNivelI
		[OperationContract]
		WCF.OpcionesDetNivelI OpcionesDetNivelI_Create(int lngIdOpcion, string strDescOpcion, string strPrograma, string strParametros, int? lngIdOpcionPadre, string strTipoOpcion, int? intOrden, bool? WebBrowser, bool? logExpandeNode, string strString, char? strColHidden);

		[OperationContract]
		void OpcionesDetNivelI_Update(int lngIdOpcion, string strDescOpcion, string strPrograma, string strParametros, int? lngIdOpcionPadre, string strTipoOpcion, int? intOrden, bool? WebBrowser, bool? logExpandeNode, string strString, char? strColHidden);

		[OperationContract]
		void OpcionesDetNivelI_Delete( int lngIdOpcion);

		[OperationContract]
		WCF.OpcionesDetNivelI OpcionesDetNivelI_Get(int lngIdOpcion);

		[OperationContract]
		WCF.OpcionesDetNivelIList OpcionesDetNivelI_GetAll();

		[OperationContract]
		WCF.OpcionesDetNivelIList OpcionesDetNivelI_GetFilter(int pagenum, int pagesize, string filter, string sort, string extablesfilter, string extablesfieldsfilter, string extablesrelationsfilter, string extablessort, string extablesfieldssort, string extablesrelationssort);

		#endregion 
		#region OpcionesDetNivelII
		[OperationContract]
		WCF.OpcionesDetNivelII OpcionesDetNivelII_Create(int lngIdOpcion, string strDescOpcion, string strPrograma, string strParametros, int? lngIdOpcionPadre, string strTipoOpcion, int? intOrden, bool? WebBrowser);

		[OperationContract]
		void OpcionesDetNivelII_Update(int lngIdOpcion, string strDescOpcion, string strPrograma, string strParametros, int? lngIdOpcionPadre, string strTipoOpcion, int? intOrden, bool? WebBrowser);

		[OperationContract]
		void OpcionesDetNivelII_Delete( int lngIdOpcion);

		[OperationContract]
		WCF.OpcionesDetNivelII OpcionesDetNivelII_Get(int lngIdOpcion);

		[OperationContract]
		WCF.OpcionesDetNivelIIList OpcionesDetNivelII_GetAll();

		[OperationContract]
		WCF.OpcionesDetNivelIIList OpcionesDetNivelII_GetFilter(int pagenum, int pagesize, string filter, string sort, string extablesfilter, string extablesfieldsfilter, string extablesrelationsfilter, string extablessort, string extablesfieldssort, string extablesrelationssort);

		#endregion 
		#region OpcionesDetNivelIII
		[OperationContract]
		WCF.OpcionesDetNivelIII OpcionesDetNivelIII_Create(int lngIdOpcion, string strDescOpcion, string strPrograma, string strParametros, int? lngIdOpcionPadre, string strTipoOpcion, int? intOrden, bool? WebBrowser);

		[OperationContract]
		void OpcionesDetNivelIII_Update(int lngIdOpcion, string strDescOpcion, string strPrograma, string strParametros, int? lngIdOpcionPadre, string strTipoOpcion, int? intOrden, bool? WebBrowser);

		[OperationContract]
		void OpcionesDetNivelIII_Delete( int lngIdOpcion);

		[OperationContract]
		WCF.OpcionesDetNivelIII OpcionesDetNivelIII_Get(int lngIdOpcion);

		[OperationContract]
		WCF.OpcionesDetNivelIIIList OpcionesDetNivelIII_GetAll();

		[OperationContract]
		WCF.OpcionesDetNivelIIIList OpcionesDetNivelIII_GetFilter(int pagenum, int pagesize, string filter, string sort, string extablesfilter, string extablesfieldsfilter, string extablesrelationsfilter, string extablessort, string extablesfieldssort, string extablesrelationssort);

		#endregion 
		#region Paises
		[OperationContract]
		WCF.Paises Paises_Create(int lngIdPais, string strNombrePais);

		[OperationContract]
		void Paises_Update(int lngIdPais, string strNombrePais);

		[OperationContract]
		void Paises_Delete( int lngIdPais);

		[OperationContract]
		WCF.Paises Paises_Get(int lngIdPais);

		[OperationContract]
		WCF.PaisesList Paises_GetAll();

		[OperationContract]
		WCF.PaisesList Paises_GetFilter(int pagenum, int pagesize, string filter, string sort, string extablesfilter, string extablesfieldsfilter, string extablesrelationsfilter, string extablessort, string extablesfieldssort, string extablesrelationssort);

		#endregion 
		#region Parametros
		[OperationContract]
		WCF.Parametros Parametros_Create(int lngIdParaMetro, int? intBanco, bool? LogAvisarConductores);

		[OperationContract]
		void Parametros_Update(int lngIdParaMetro, int? intBanco, bool? LogAvisarConductores);

		[OperationContract]
		void Parametros_Delete( int lngIdParaMetro);

		[OperationContract]
		WCF.Parametros Parametros_Get(int lngIdParaMetro);

		[OperationContract]
		WCF.ParametrosList Parametros_GetAll();

		[OperationContract]
		WCF.ParametrosList Parametros_GetFilter(int pagenum, int pagesize, string filter, string sort, string extablesfilter, string extablesfieldsfilter, string extablesrelationsfilter, string extablessort, string extablesfieldssort, string extablesrelationssort);

		#endregion 
		#region RangoKilometros
		[OperationContract]
		WCF.RangoKilometros RangoKilometros_Create(int Codigo, float RangoInicial, float RangoFinal, float Kilometros, decimal Valor);

		[OperationContract]
		void RangoKilometros_Update(int Codigo, float RangoInicial, float RangoFinal, float Kilometros, decimal Valor);

		[OperationContract]
		void RangoKilometros_Delete( int Codigo);

		[OperationContract]
		WCF.RangoKilometros RangoKilometros_Get(int Codigo);

		[OperationContract]
		WCF.RangoKilometrosList RangoKilometros_GetAll();

		[OperationContract]
		WCF.RangoKilometrosList RangoKilometros_GetFilter(int pagenum, int pagesize, string filter, string sort, string extablesfilter, string extablesfieldsfilter, string extablesrelationsfilter, string extablessort, string extablesfieldssort, string extablesrelationssort);

		#endregion 
		#region RegistrosBorrados
		[OperationContract]
		WCF.RegistrosBorrados RegistrosBorrados_Create(int lngIdRegistroViaje, int? lngIdRegistroViajeTramo, int? lngIdRegistrRuta, string strRutaAnticipo, double? intNitConductor, string strConductor, string strPlaca, int? lngIdBanco, int? intDocumento, string strCuenta, decimal? curDebito, decimal? curCredito, decimal? curSaldo, DateTime? dtmFechaModif, string strObservaciones, int? intCantidad, bool? logAnulado);

		[OperationContract]
		void RegistrosBorrados_Update(int lngIdRegistroViaje, int? lngIdRegistroViajeTramo, int? lngIdRegistrRuta, string strRutaAnticipo, double? intNitConductor, string strConductor, string strPlaca, int? lngIdBanco, int? intDocumento, string strCuenta, decimal? curDebito, decimal? curCredito, decimal? curSaldo, DateTime? dtmFechaModif, string strObservaciones, int? intCantidad, bool? logAnulado);

		[OperationContract]
		void RegistrosBorrados_Delete( int lngIdRegistroViaje);

		[OperationContract]
		WCF.RegistrosBorrados RegistrosBorrados_Get(int lngIdRegistroViaje);

		[OperationContract]
		WCF.RegistrosBorradosList RegistrosBorrados_GetAll();

		[OperationContract]
		WCF.RegistrosBorradosList RegistrosBorrados_GetFilter(int pagenum, int pagesize, string filter, string sort, string extablesfilter, string extablesfieldsfilter, string extablesrelationsfilter, string extablessort, string extablesfieldssort, string extablesrelationssort);

		#endregion 
		#region Rutas
		[OperationContract]
		WCF.Rutas Rutas_Create(int lngIdRegistrRuta, string strRutaAnticipoGrupoOrigen, string strRutaAnticipoGrupoDestino, string strRutaAnticipoGrupo, string strRutaAnticipo, int? TipoVehiculoCodigo, string TipoVehiculo, int? TipoTrailerCodigo, int? Peso, string Programa, bool? logViajeVacio, decimal? floGalones, decimal? curValorGalon, decimal? cutCombustible, decimal? CombustibleCarretera, int? lngIdNroPeajes, decimal? cutPeaje, string strNombrePeajes, decimal? cutVariosLlantas, decimal? cutVariosCelada, decimal? cutVariosPropina, decimal? cutVarios, decimal? Llamadas, decimal? Taxi, decimal? Aseo, decimal? cutVariosLlantasVacio, decimal? cutVariosCeladaVacio, decimal? cutVariosPropinaVacio, decimal? cutVariosVacio, decimal? Viaticos, decimal? cutParticipacion, decimal? cutParticipacionVacio, int? curHotelCarretera, int? curHotelCiudad, decimal? curHotel, int? curHotelCarreteraVacio, int? curHotelCiudadVacio, decimal? curHotelVacio, decimal? intTiempoCargue, decimal? intTiempoDescargue, decimal? intTiempoAduana, decimal? intTotalTrayecto, decimal? intTotalTiempo, decimal? curComida, decimal? intTiempoCargueVacio, decimal? intTiempoDescargueVacio, decimal? intTiempoAduanaVacio, decimal? intTotalTrayectoVacio, decimal? intTotalTiempoVacio, decimal? curComidaVacio, decimal? curDesvareManoRepuestos, decimal? curDesvareManoObra, decimal? cutSaldo, decimal? cutSaldoVacio, decimal? cutKmts, decimal? logActualizaPeajes, decimal? intFactorKmPorGalon, bool? logEstadoRuta, decimal? ParqueaderoCarretera, decimal? ParqueaderoCiudad, decimal? MontadaLLantaCarretera, decimal? MontadaLLantaCiudad, decimal? AjusteCarretera, decimal? Lavada, decimal? Amarres, decimal? Engradasa, decimal? Calibrada, bool? Liquidado, bool? logVacio, decimal? Papeleria, bool? logFavorito, decimal? CurCargue, decimal? CurDescargue, bool? LogAnticipoACPM);

		[OperationContract]
		void Rutas_Update(int lngIdRegistrRuta, string strRutaAnticipoGrupoOrigen, string strRutaAnticipoGrupoDestino, string strRutaAnticipoGrupo, string strRutaAnticipo, int? TipoVehiculoCodigo, string TipoVehiculo, int? TipoTrailerCodigo, int? Peso, string Programa, bool? logViajeVacio, decimal? floGalones, decimal? curValorGalon, decimal? cutCombustible, decimal? CombustibleCarretera, int? lngIdNroPeajes, decimal? cutPeaje, string strNombrePeajes, decimal? cutVariosLlantas, decimal? cutVariosCelada, decimal? cutVariosPropina, decimal? cutVarios, decimal? Llamadas, decimal? Taxi, decimal? Aseo, decimal? cutVariosLlantasVacio, decimal? cutVariosCeladaVacio, decimal? cutVariosPropinaVacio, decimal? cutVariosVacio, decimal? Viaticos, decimal? cutParticipacion, decimal? cutParticipacionVacio, int? curHotelCarretera, int? curHotelCiudad, decimal? curHotel, int? curHotelCarreteraVacio, int? curHotelCiudadVacio, decimal? curHotelVacio, decimal? intTiempoCargue, decimal? intTiempoDescargue, decimal? intTiempoAduana, decimal? intTotalTrayecto, decimal? intTotalTiempo, decimal? curComida, decimal? intTiempoCargueVacio, decimal? intTiempoDescargueVacio, decimal? intTiempoAduanaVacio, decimal? intTotalTrayectoVacio, decimal? intTotalTiempoVacio, decimal? curComidaVacio, decimal? curDesvareManoRepuestos, decimal? curDesvareManoObra, decimal? cutSaldo, decimal? cutSaldoVacio, decimal? cutKmts, decimal? logActualizaPeajes, decimal? intFactorKmPorGalon, bool? logEstadoRuta, decimal? ParqueaderoCarretera, decimal? ParqueaderoCiudad, decimal? MontadaLLantaCarretera, decimal? MontadaLLantaCiudad, decimal? AjusteCarretera, decimal? Lavada, decimal? Amarres, decimal? Engradasa, decimal? Calibrada, bool? Liquidado, bool? logVacio, decimal? Papeleria, bool? logFavorito, decimal? CurCargue, decimal? CurDescargue, bool? LogAnticipoACPM);

		[OperationContract]
		void Rutas_Delete( int lngIdRegistrRuta);

		[OperationContract]
		WCF.Rutas Rutas_Get(int lngIdRegistrRuta);

		[OperationContract]
		WCF.RutasList Rutas_GetAll();

		[OperationContract]
		WCF.RutasList Rutas_GetFilter(int pagenum, int pagesize, string filter, string sort, string extablesfilter, string extablesfieldsfilter, string extablesrelationsfilter, string extablessort, string extablesfieldssort, string extablesrelationssort);

		[OperationContract]
		WCF.RutasList Rutas_GetBy_TipoTrailerCodigo(int TipoTrailerCodigo);

		[OperationContract]
		WCF.RutasList Rutas_GetBy_TipoVehiculoCodigo(int TipoVehiculoCodigo);

		#endregion 
		#region Rutas_Peajes
		[OperationContract]
		WCF.Rutas_Peajes Rutas_Peajes_Create(int Codigo, string strRutaAnticipoGrupoOrigen, string strRutaAnticipoGrupoDestino, string strRutaAnticipo, bool? logActualizado, DateTime? FechaActualizacion);

		[OperationContract]
		void Rutas_Peajes_Update(int Codigo, string strRutaAnticipoGrupoOrigen, string strRutaAnticipoGrupoDestino, string strRutaAnticipo, bool? logActualizado, DateTime? FechaActualizacion);

		[OperationContract]
		void Rutas_Peajes_Delete( int Codigo);

		[OperationContract]
		WCF.Rutas_Peajes Rutas_Peajes_Get(int Codigo);

		[OperationContract]
		WCF.Rutas_PeajesList Rutas_Peajes_GetAll();

		[OperationContract]
		WCF.Rutas_PeajesList Rutas_Peajes_GetFilter(int pagenum, int pagesize, string filter, string sort, string extablesfilter, string extablesfieldsfilter, string extablesrelationsfilter, string extablessort, string extablesfieldssort, string extablesrelationssort);

		#endregion 
		#region Rutas_Peajes_Detalle
		[OperationContract]
		WCF.Rutas_Peajes_Detalle Rutas_Peajes_Detalle_Create(long codigo, long Rutas_PeajesCodigo, int lngIdPeaje, int? Secuencia, bool? Excluido, DateTime? fechaModificacion);

		[OperationContract]
		void Rutas_Peajes_Detalle_Update(long codigo, long Rutas_PeajesCodigo, int lngIdPeaje, int? Secuencia, bool? Excluido, DateTime? fechaModificacion);

		[OperationContract]
		void Rutas_Peajes_Detalle_Delete( long codigo, long Rutas_PeajesCodigo, int lngIdPeaje);

		[OperationContract]
		WCF.Rutas_Peajes_Detalle Rutas_Peajes_Detalle_Get(long codigo, long Rutas_PeajesCodigo, int lngIdPeaje);

		[OperationContract]
		WCF.Rutas_Peajes_DetalleList Rutas_Peajes_Detalle_GetAll();

		[OperationContract]
		WCF.Rutas_Peajes_DetalleList Rutas_Peajes_Detalle_GetFilter(int pagenum, int pagesize, string filter, string sort, string extablesfilter, string extablesfieldsfilter, string extablesrelationsfilter, string extablessort, string extablesfieldssort, string extablesrelationssort);

		#endregion 
		#region RutasAbreviaturas
		[OperationContract]
		WCF.RutasAbreviaturas RutasAbreviaturas_Create(int lngIdAbreviatura, string strAbreviatura, string strNombreAbreviatura);

		[OperationContract]
		void RutasAbreviaturas_Update(int lngIdAbreviatura, string strAbreviatura, string strNombreAbreviatura);

		[OperationContract]
		void RutasAbreviaturas_Delete( int lngIdAbreviatura);

		[OperationContract]
		WCF.RutasAbreviaturas RutasAbreviaturas_Get(int lngIdAbreviatura);

		[OperationContract]
		WCF.RutasAbreviaturasList RutasAbreviaturas_GetAll();

		[OperationContract]
		WCF.RutasAbreviaturasList RutasAbreviaturas_GetFilter(int pagenum, int pagesize, string filter, string sort, string extablesfilter, string extablesfieldsfilter, string extablesrelationsfilter, string extablessort, string extablesfieldssort, string extablesrelationssort);

		#endregion 
		#region RutasAgrupaPeajes
		[OperationContract]
		WCF.RutasAgrupaPeajes RutasAgrupaPeajes_Create(int lngIdGrupo, string strNombreGrupo);

		[OperationContract]
		void RutasAgrupaPeajes_Update(int lngIdGrupo, string strNombreGrupo);

		[OperationContract]
		void RutasAgrupaPeajes_Delete( int lngIdGrupo);

		[OperationContract]
		WCF.RutasAgrupaPeajes RutasAgrupaPeajes_Get(int lngIdGrupo);

		[OperationContract]
		WCF.RutasAgrupaPeajesList RutasAgrupaPeajes_GetAll();

		[OperationContract]
		WCF.RutasAgrupaPeajesList RutasAgrupaPeajes_GetFilter(int pagenum, int pagesize, string filter, string sort, string extablesfilter, string extablesfieldsfilter, string extablesrelationsfilter, string extablessort, string extablesfieldssort, string extablesrelationssort);

		#endregion 
		#region RutasAgrupaPeajesDet
		[OperationContract]
		WCF.RutasAgrupaPeajesDet RutasAgrupaPeajesDet_Create(int lngIdGrupo, int lngIdPeaje, int? intSecuencia);

		[OperationContract]
		void RutasAgrupaPeajesDet_Update(int lngIdGrupo, int lngIdPeaje, int? intSecuencia);

		[OperationContract]
		void RutasAgrupaPeajesDet_Delete( int lngIdGrupo, int lngIdPeaje);

		[OperationContract]
		WCF.RutasAgrupaPeajesDet RutasAgrupaPeajesDet_Get(int lngIdGrupo, int lngIdPeaje);

		[OperationContract]
		WCF.RutasAgrupaPeajesDetList RutasAgrupaPeajesDet_GetAll();

		[OperationContract]
		WCF.RutasAgrupaPeajesDetList RutasAgrupaPeajesDet_GetFilter(int pagenum, int pagesize, string filter, string sort, string extablesfilter, string extablesfieldsfilter, string extablesrelationsfilter, string extablessort, string extablesfieldssort, string extablesrelationssort);

		#endregion 
		#region RutasCombustible
		[OperationContract]
		WCF.RutasCombustible RutasCombustible_Create(int lngIdRegistro, string strNombreGrupo, decimal? cutCombustible, string TipoVehiculo, string DescripcionVehiculo);

		[OperationContract]
		void RutasCombustible_Update(int lngIdRegistro, string strNombreGrupo, decimal? cutCombustible, string TipoVehiculo, string DescripcionVehiculo);

		[OperationContract]
		void RutasCombustible_Delete( int lngIdRegistro);

		[OperationContract]
		WCF.RutasCombustible RutasCombustible_Get(int lngIdRegistro);

		[OperationContract]
		WCF.RutasCombustibleList RutasCombustible_GetAll();

		[OperationContract]
		WCF.RutasCombustibleList RutasCombustible_GetFilter(int pagenum, int pagesize, string filter, string sort, string extablesfilter, string extablesfieldsfilter, string extablesrelationsfilter, string extablessort, string extablesfieldssort, string extablesrelationssort);

		#endregion 
		#region RutasCuentas
		[OperationContract]
		WCF.RutasCuentas RutasCuentas_Create(int lngIdRegistrRuta, string cutCombustible, string cutPeaje, string cutVariosLlantas, string cutVariosCelada, string cutVariosPropina, string cutVarios, string cutVariosLlantasVacio, string cutVariosCeladaVacio, string cutVariosPropinaVacio, string cutVariosVacio, string cutParticipacion, string cutParticipacionVacio, string curHotel, string curHotelVacio, string curComida, string curComidaVacio, string curDesvareManoRepuestos, string curDesvareManoObra, string cutSaldo, string cutKmts, string ParqueaderoCarretera, string ParqueaderoCiudad, string MontadaLLantaCarretera, string Papeleria, string AjusteCarretera, string Aseo, string Amarres, string Engradasa, string Calibrada, string Taxi, string Lavada, string CombustibleCarretera, string CurCargue, string CurDescargue);

		[OperationContract]
		void RutasCuentas_Update(int lngIdRegistrRuta, string cutCombustible, string cutPeaje, string cutVariosLlantas, string cutVariosCelada, string cutVariosPropina, string cutVarios, string cutVariosLlantasVacio, string cutVariosCeladaVacio, string cutVariosPropinaVacio, string cutVariosVacio, string cutParticipacion, string cutParticipacionVacio, string curHotel, string curHotelVacio, string curComida, string curComidaVacio, string curDesvareManoRepuestos, string curDesvareManoObra, string cutSaldo, string cutKmts, string ParqueaderoCarretera, string ParqueaderoCiudad, string MontadaLLantaCarretera, string Papeleria, string AjusteCarretera, string Aseo, string Amarres, string Engradasa, string Calibrada, string Taxi, string Lavada, string CombustibleCarretera, string CurCargue, string CurDescargue);

		[OperationContract]
		void RutasCuentas_Delete( int lngIdRegistrRuta);

		[OperationContract]
		WCF.RutasCuentas RutasCuentas_Get(int lngIdRegistrRuta);

		[OperationContract]
		WCF.RutasCuentasList RutasCuentas_GetAll();

		[OperationContract]
		WCF.RutasCuentasList RutasCuentas_GetFilter(int pagenum, int pagesize, string filter, string sort, string extablesfilter, string extablesfieldsfilter, string extablesrelationsfilter, string extablessort, string extablesfieldssort, string extablesrelationssort);

		#endregion 
		#region RutasDet
		[OperationContract]
		WCF.RutasDet RutasDet_Create(int lngIdItemdReg, int lngIdRegistrRuta, int lngIdPeaje, string strNombrePeaje, decimal? curValorPeaje);

		[OperationContract]
		void RutasDet_Update(int lngIdItemdReg, int lngIdRegistrRuta, int lngIdPeaje, string strNombrePeaje, decimal? curValorPeaje);

		[OperationContract]
		void RutasDet_Delete( int lngIdItemdReg, int lngIdRegistrRuta, int lngIdPeaje);

		[OperationContract]
		WCF.RutasDet RutasDet_Get(int lngIdItemdReg, int lngIdRegistrRuta, int lngIdPeaje);

		[OperationContract]
		WCF.RutasDetList RutasDet_GetAll();

		[OperationContract]
		WCF.RutasDetList RutasDet_GetFilter(int pagenum, int pagesize, string filter, string sort, string extablesfilter, string extablesfieldsfilter, string extablesrelationsfilter, string extablessort, string extablesfieldssort, string extablesrelationssort);

		#endregion 
		#region RutasMaestroPeajes
		[OperationContract]
		WCF.RutasMaestroPeajes RutasMaestroPeajes_Create(int lngIdPeaje, string strNombrePeaje, bool Activo, decimal? curValorTipo1, decimal? curValorTipo2, decimal? curValorTipo3, decimal? curValorTipo4, decimal? curValorTipo5, decimal? curValorTipo6, decimal? curValorTipo7);

		[OperationContract]
		void RutasMaestroPeajes_Update(int lngIdPeaje, string strNombrePeaje, bool Activo, decimal? curValorTipo1, decimal? curValorTipo2, decimal? curValorTipo3, decimal? curValorTipo4, decimal? curValorTipo5, decimal? curValorTipo6, decimal? curValorTipo7);

		[OperationContract]
		void RutasMaestroPeajes_Delete( int lngIdPeaje);

		[OperationContract]
		WCF.RutasMaestroPeajes RutasMaestroPeajes_Get(int lngIdPeaje);

		[OperationContract]
		WCF.RutasMaestroPeajesList RutasMaestroPeajes_GetAll();

		[OperationContract]
		WCF.RutasMaestroPeajesList RutasMaestroPeajes_GetFilter(int pagenum, int pagesize, string filter, string sort, string extablesfilter, string extablesfieldsfilter, string extablesrelationsfilter, string extablessort, string extablesfieldssort, string extablesrelationssort);

		#endregion 
		#region Status
		[OperationContract]
		WCF.Status Status_Create(int lngIdStatus, string strStatus);

		[OperationContract]
		void Status_Update(int lngIdStatus, string strStatus);

		[OperationContract]
		void Status_Delete( int lngIdStatus);

		[OperationContract]
		WCF.Status Status_Get(int lngIdStatus);

		[OperationContract]
		WCF.StatusList Status_GetAll();

		[OperationContract]
		WCF.StatusList Status_GetFilter(int pagenum, int pagesize, string filter, string sort, string extablesfilter, string extablesfieldsfilter, string extablesrelationsfilter, string extablessort, string extablesfieldssort, string extablesrelationssort);

		#endregion 
		#region Tareas
		[OperationContract]
		WCF.Tareas Tareas_Create(int lngIdTarea, string strAsunto, DateTime? dtmFechaInicio, DateTime? strFechavencimiento, bool? logAvisa, DateTime? FechaAviso, DateTime? Fechadefinalización, bool? logFinalizada, string Notas, int? lngIdStatus);

		[OperationContract]
		void Tareas_Update(int lngIdTarea, string strAsunto, DateTime? dtmFechaInicio, DateTime? strFechavencimiento, bool? logAvisa, DateTime? FechaAviso, DateTime? Fechadefinalización, bool? logFinalizada, string Notas, int? lngIdStatus);

		[OperationContract]
		void Tareas_Delete( int lngIdTarea);

		[OperationContract]
		WCF.Tareas Tareas_Get(int lngIdTarea);

		[OperationContract]
		WCF.TareasList Tareas_GetAll();

		[OperationContract]
		WCF.TareasList Tareas_GetFilter(int pagenum, int pagesize, string filter, string sort, string extablesfilter, string extablesfieldsfilter, string extablesrelationsfilter, string extablessort, string extablesfieldssort, string extablesrelationssort);

		#endregion 
		#region TempLiqMetal
		[OperationContract]
		WCF.TempLiqMetal TempLiqMetal_Create(string strPlaca, char strCuenta, char? strDescripcion, int? intDocumento, decimal? lngIdRegistroViaje, DateTime? dtmFechaAsignacion, decimal? curValorDebito, decimal? curValorCredito, bool? logLiquidado, char? nitTercero, string strObservaciones, int? lngIdUsuario, DateTime? dtmFechaModif, bool? LogAnticipo, decimal? intNitConductor, string strConductor);

		[OperationContract]
		WCF.TempLiqMetalList TempLiqMetal_GetAll();

		[OperationContract]
		WCF.TempLiqMetalList TempLiqMetal_GetFilter(int pagenum, int pagesize, string filter, string sort, string extablesfilter, string extablesfieldsfilter, string extablesrelationsfilter, string extablessort, string extablesfieldssort, string extablesrelationssort);

		#endregion 
		#region Tempo_tblLiquidacionRutas
		[OperationContract]
		WCF.Tempo_tblLiquidacionRutas Tempo_tblLiquidacionRutas_Create(int lngIdRegistrRutaItemId, int? lngIdRegistrRuta, int? lngIdRegistro, string strRutaAnticipoGrupoOrigen, string strRutaAnticipoGrupoDestino, string strRutaAnticipoGrupo, string strRutaAnticipo, decimal? floGalones, decimal? curValorGalon, decimal? cutCombustible, int? lngIdNroPeajes, decimal? cutPeaje, string strNombrePeajes, decimal? cutVariosLlantas, decimal? cutVariosCelada, decimal? cutVariosPropina, decimal? cutVarios, decimal? cutVariosLlantasVacio, decimal? cutVariosCeladaVacio, decimal? cutVariosPropinaVacio, decimal? cutVariosVacio, decimal? cutParticipacion, decimal? cutParticipacionVacio, int? curHotelCarretera, int? curHotelCiudad, decimal? curHotel, int? curHotelCarreteraVacio, int? curHotelCiudadVacio, decimal? curHotelVacio, decimal? intTiempoCargue, decimal? intTiempoDescargue, decimal? intTiempoAduana, decimal? intTotalTrayecto, decimal? intTotalTiempo, decimal? curComida, decimal? intTiempoCargueVacio, decimal? intTiempoDescargueVacio, decimal? intTiempoAduanaVacio, decimal? intTotalTrayectoVacio, decimal? intTotalTiempoVacio, decimal? curComidaVacio, decimal? curDesvareManoRepuestos, decimal? curDesvareManoObra, decimal? cutSaldo, decimal? cutKmts, bool? logAjuste, int? lngIdRegistrRutaItemIdAjc, int? lngIdUsuario);

		[OperationContract]
		WCF.Tempo_tblLiquidacionRutasList Tempo_tblLiquidacionRutas_GetAll();

		[OperationContract]
		WCF.Tempo_tblLiquidacionRutasList Tempo_tblLiquidacionRutas_GetFilter(int pagenum, int pagesize, string filter, string sort, string extablesfilter, string extablesfieldsfilter, string extablesrelationsfilter, string extablessort, string extablesfieldssort, string extablesrelationssort);

		#endregion 
		#region Tempo_tblLiquidacionRutasObs
		[OperationContract]
		WCF.Tempo_tblLiquidacionRutasObs Tempo_tblLiquidacionRutasObs_Create(int lngIdRegistrRutaItemId, int? lngIdRegistrRuta, int? lngIdRegistro, char? strCampo, char? strObservacion, char? strMotivo, int? lngIdUsuario);

		[OperationContract]
		WCF.Tempo_tblLiquidacionRutasObsList Tempo_tblLiquidacionRutasObs_GetAll();

		[OperationContract]
		WCF.Tempo_tblLiquidacionRutasObsList Tempo_tblLiquidacionRutasObs_GetFilter(int pagenum, int pagesize, string filter, string sort, string extablesfilter, string extablesfieldsfilter, string extablesrelationsfilter, string extablessort, string extablesfieldssort, string extablesrelationssort);

		#endregion 
		#region TercerosConductores
		[OperationContract]
		WCF.TercerosConductores TercerosConductores_Create(string strTipoIdentificacion, double IntNit, int? intDigito, string strNombres, string strDireccion, bool? logEstado, bool? logConductor, string strPlaca, string lngIdCiudad, string strTelefono, string strTelefonoAux, string strTelCelular, string strTelCelularAux, string strFax, string IntAAereo, string StrPais, double? nitProvedor, double? intNoLicenciaConduc, int? intCategoria, string strTarjetaTripulante, DateTime? dtmFechaVenceLicencia, DateTime? dtmVenceTarjetaTripulante, string strCarnetEmpresa, string strCarnetComunicaciones, DateTime? dtmFechaModif, bool? logActualizado, int? lngIdUsuario);

		[OperationContract]
		void TercerosConductores_Update(string strTipoIdentificacion, double IntNit, int? intDigito, string strNombres, string strDireccion, bool? logEstado, bool? logConductor, string strPlaca, string lngIdCiudad, string strTelefono, string strTelefonoAux, string strTelCelular, string strTelCelularAux, string strFax, string IntAAereo, string StrPais, double? nitProvedor, double? intNoLicenciaConduc, int? intCategoria, string strTarjetaTripulante, DateTime? dtmFechaVenceLicencia, DateTime? dtmVenceTarjetaTripulante, string strCarnetEmpresa, string strCarnetComunicaciones, DateTime? dtmFechaModif, bool? logActualizado, int? lngIdUsuario);

		[OperationContract]
		void TercerosConductores_Delete( string strTipoIdentificacion, double IntNit);

		[OperationContract]
		WCF.TercerosConductores TercerosConductores_Get(string strTipoIdentificacion, double IntNit);

		[OperationContract]
		WCF.TercerosConductoresList TercerosConductores_GetAll();

		[OperationContract]
		WCF.TercerosConductoresList TercerosConductores_GetFilter(int pagenum, int pagesize, string filter, string sort, string extablesfilter, string extablesfieldsfilter, string extablesrelationsfilter, string extablessort, string extablesfieldssort, string extablesrelationssort);

		#endregion 
		#region TercerosConductoresWinFor
		[OperationContract]
		WCF.TercerosConductoresWinFor TercerosConductoresWinFor_Create(int lngIdRegistro, int lngIdUsuario, int? strTipoIdentificacion, int? IntNit, int? intDigito, int? strNombres, int? strDireccion, int? logEstado, int? logConductor, int? strPlaca, int? lngIdCiudad, int? strTelefono, int? strTelefonoAux, int? strTelCelular, int? strTelCelularAux, int? strFax, int? IntAAereo, int? StrPais, int? nitProvedor, int? intNoLicenciaConduc, int? intCategoria, int? strTarjetaTripulante, int? dtmFechaVenceLicencia, int? dtmVenceTarjetaTripulante, int? strCarnetEmpresa, int? strCarnetComunicaciones);

		[OperationContract]
		void TercerosConductoresWinFor_Update(int lngIdRegistro, int lngIdUsuario, int? strTipoIdentificacion, int? IntNit, int? intDigito, int? strNombres, int? strDireccion, int? logEstado, int? logConductor, int? strPlaca, int? lngIdCiudad, int? strTelefono, int? strTelefonoAux, int? strTelCelular, int? strTelCelularAux, int? strFax, int? IntAAereo, int? StrPais, int? nitProvedor, int? intNoLicenciaConduc, int? intCategoria, int? strTarjetaTripulante, int? dtmFechaVenceLicencia, int? dtmVenceTarjetaTripulante, int? strCarnetEmpresa, int? strCarnetComunicaciones);

		[OperationContract]
		void TercerosConductoresWinFor_Delete( int lngIdRegistro, int lngIdUsuario);

		[OperationContract]
		WCF.TercerosConductoresWinFor TercerosConductoresWinFor_Get(int lngIdRegistro, int lngIdUsuario);

		[OperationContract]
		WCF.TercerosConductoresWinForList TercerosConductoresWinFor_GetAll();

		[OperationContract]
		WCF.TercerosConductoresWinForList TercerosConductoresWinFor_GetFilter(int pagenum, int pagesize, string filter, string sort, string extablesfilter, string extablesfieldsfilter, string extablesrelationsfilter, string extablessort, string extablesfieldssort, string extablesrelationssort);

		#endregion 
		#region TipoMantenimiento
		[OperationContract]
		WCF.TipoMantenimiento TipoMantenimiento_Create(int lngIdTipoMantenimiento, string strTipoMantenimiento, bool? logActivar, float? intValorMantenimiento, float? intValorAviso, float? intValorAviso2);

		[OperationContract]
		void TipoMantenimiento_Update(int lngIdTipoMantenimiento, string strTipoMantenimiento, bool? logActivar, float? intValorMantenimiento, float? intValorAviso, float? intValorAviso2);

		[OperationContract]
		void TipoMantenimiento_Delete( int lngIdTipoMantenimiento);

		[OperationContract]
		WCF.TipoMantenimiento TipoMantenimiento_Get(int lngIdTipoMantenimiento);

		[OperationContract]
		WCF.TipoMantenimientoList TipoMantenimiento_GetAll();

		[OperationContract]
		WCF.TipoMantenimientoList TipoMantenimiento_GetFilter(int pagenum, int pagesize, string filter, string sort, string extablesfilter, string extablesfieldsfilter, string extablesrelationsfilter, string extablessort, string extablesfieldssort, string extablesrelationssort);

		#endregion 
		#region Usuarios
		[OperationContract]
		WCF.Usuarios Usuarios_Create(int lngIdUsuario, string strLogin, string strNombre, string strPassword, DateTime? dtmFechaSistema, bool? Excell, bool? Modifica_gastos, bool? Modifica_cd);

		[OperationContract]
		void Usuarios_Update(int lngIdUsuario, string strLogin, string strNombre, string strPassword, DateTime? dtmFechaSistema, bool? Excell, bool? Modifica_gastos, bool? Modifica_cd);

		[OperationContract]
		void Usuarios_Delete( int lngIdUsuario);

		[OperationContract]
		WCF.Usuarios Usuarios_Get(int lngIdUsuario);

		[OperationContract]
		WCF.UsuariosList Usuarios_GetAll();

		[OperationContract]
		WCF.UsuariosList Usuarios_GetFilter(int pagenum, int pagesize, string filter, string sort, string extablesfilter, string extablesfieldsfilter, string extablesrelationsfilter, string extablessort, string extablesfieldssort, string extablesrelationssort);

		#endregion 
		#region VehiculoCCosto
		[OperationContract]
		WCF.VehiculoCCosto VehiculoCCosto_Create(int lngIdRegistro, double? lngIdUsuario, string strPlaca, double? centro, int? TipoTrailerCodigo, int? TipoVehiculoCodigo, string Descripcion, DateTime? dtmFechaIngreso, DateTime? dtmFechaEgreso, double? nitPropietario, string strMarca, double? lngModelo, double? lngMovil, double? strCelular, double? strTipoMotor, string strColor, string strMotor, string strChasis, bool? logCamarote, decimal? CapacidadGalores, decimal? floGalonesReserva, decimal? floCantGalonesReserva, decimal? floTolerancia, double? cutPeso, double? cutCapacidad, double? lngEjes, double? logActivo, double? lngLlantas, string strPolizaObligatorio, double? nitProvedorOblig, DateTime? dtmFechaInicioOblig, DateTime? dtmFechaVenceOblig, string strPolizaTodoRiesgo, double? nitProvedorTodo, DateTime? dtmFechaInicioTodo, DateTime? dtmFechaVenceTodo, string strCertifMovilizacion, DateTime? dtmFechaInicioMoviliz, DateTime? dtmFechaVenceMoviliz, string strGases, DateTime? dtmFechaInicioGases, DateTime? dtmFechaVenceGases, string strTarjetaOper, DateTime? dtmFechaInicioTarjetaOper, DateTime? dtmFechaVenceTarjetaOper, bool? logVencimientoFecha);

		[OperationContract]
		void VehiculoCCosto_Update(int lngIdRegistro, double? lngIdUsuario, string strPlaca, double? centro, int? TipoTrailerCodigo, int? TipoVehiculoCodigo, string Descripcion, DateTime? dtmFechaIngreso, DateTime? dtmFechaEgreso, double? nitPropietario, string strMarca, double? lngModelo, double? lngMovil, double? strCelular, double? strTipoMotor, string strColor, string strMotor, string strChasis, bool? logCamarote, decimal? CapacidadGalores, decimal? floGalonesReserva, decimal? floCantGalonesReserva, decimal? floTolerancia, double? cutPeso, double? cutCapacidad, double? lngEjes, double? logActivo, double? lngLlantas, string strPolizaObligatorio, double? nitProvedorOblig, DateTime? dtmFechaInicioOblig, DateTime? dtmFechaVenceOblig, string strPolizaTodoRiesgo, double? nitProvedorTodo, DateTime? dtmFechaInicioTodo, DateTime? dtmFechaVenceTodo, string strCertifMovilizacion, DateTime? dtmFechaInicioMoviliz, DateTime? dtmFechaVenceMoviliz, string strGases, DateTime? dtmFechaInicioGases, DateTime? dtmFechaVenceGases, string strTarjetaOper, DateTime? dtmFechaInicioTarjetaOper, DateTime? dtmFechaVenceTarjetaOper, bool? logVencimientoFecha);

		[OperationContract]
		void VehiculoCCosto_Delete( int lngIdRegistro);

		[OperationContract]
		WCF.VehiculoCCosto VehiculoCCosto_Get(int lngIdRegistro);

		[OperationContract]
		WCF.VehiculoCCostoList VehiculoCCosto_GetAll();

		[OperationContract]
		WCF.VehiculoCCostoList VehiculoCCosto_GetFilter(int pagenum, int pagesize, string filter, string sort, string extablesfilter, string extablesfieldsfilter, string extablesrelationsfilter, string extablessort, string extablesfieldssort, string extablesrelationssort);

		#endregion 
		#region VehiculoCombustible
		[OperationContract]
		WCF.VehiculoCombustible VehiculoCombustible_Create(long Codigo, int? lngIdRegistro, long? tblLiquidacionRutasCombustibleCodigo, string Placa, DateTime? FechaTanqueo, decimal? GalonesReserva, decimal? GalonesTanqueo, decimal? ValorGalon, decimal? ValorCombustible, string nitTerceroComplentario, string NombreTerceroComplementario, byte sw, string tipo, int numero, string strObservaciones);

		[OperationContract]
		void VehiculoCombustible_Update(long Codigo, int? lngIdRegistro, long? tblLiquidacionRutasCombustibleCodigo, string Placa, DateTime? FechaTanqueo, decimal? GalonesReserva, decimal? GalonesTanqueo, decimal? ValorGalon, decimal? ValorCombustible, string nitTerceroComplentario, string NombreTerceroComplementario, byte sw, string tipo, int numero, string strObservaciones);

		[OperationContract]
		void VehiculoCombustible_Delete( long Codigo);

		[OperationContract]
		WCF.VehiculoCombustible VehiculoCombustible_Get(long Codigo);

		[OperationContract]
		WCF.VehiculoCombustibleList VehiculoCombustible_GetAll();

		[OperationContract]
		WCF.VehiculoCombustibleList VehiculoCombustible_GetFilter(int pagenum, int pagesize, string filter, string sort, string extablesfilter, string extablesfieldsfilter, string extablesrelationsfilter, string extablessort, string extablesfieldssort, string extablesrelationssort);

		#endregion 
		#region VehiculoForWin
		[OperationContract]
		WCF.VehiculoForWin VehiculoForWin_Create(int lngIdRegistro, int lngIdUsuario, int strPlaca, int? centro, int? TipoVehiculoCodigo, string Descripcion, int? dtmFechaIngreso, int? dtmFechaEgreso, int? nitPropietario, int? strMarca, int? lngModelo, int? lngMovil, int? strCelular, int? strTipoMotor, int? strColor, int? strMotor, int? strChasis, int? logCamarote, int? cutPeso, int? cutCapacidad, int? lngEjes, int? logActivo, int? lngLlantas, int? strPolizaObligatorio, int? nitProvedorOblig, int? dtmFechaInicioOblig, int? dtmFechaVenceOblig, int? strPolizaTodoRiesgo, int? nitProvedorTodo, int? dtmFechaInicioTodo, int? dtmFechaVenceTodo, int? strCertifMovilizacion, int? dtmFechaInicioMoviliz, int? dtmFechaVenceMoviliz, int? strGases, int? dtmFechaInicioGases, int? dtmFechaVenceGases, int? strTarjetaOper, int? dtmFechaInicioTarjetaOper, int? dtmFechaVenceTarjetaOper, int? logVencimientoFecha);

		[OperationContract]
		void VehiculoForWin_Update(int lngIdRegistro, int lngIdUsuario, int strPlaca, int? centro, int? TipoVehiculoCodigo, string Descripcion, int? dtmFechaIngreso, int? dtmFechaEgreso, int? nitPropietario, int? strMarca, int? lngModelo, int? lngMovil, int? strCelular, int? strTipoMotor, int? strColor, int? strMotor, int? strChasis, int? logCamarote, int? cutPeso, int? cutCapacidad, int? lngEjes, int? logActivo, int? lngLlantas, int? strPolizaObligatorio, int? nitProvedorOblig, int? dtmFechaInicioOblig, int? dtmFechaVenceOblig, int? strPolizaTodoRiesgo, int? nitProvedorTodo, int? dtmFechaInicioTodo, int? dtmFechaVenceTodo, int? strCertifMovilizacion, int? dtmFechaInicioMoviliz, int? dtmFechaVenceMoviliz, int? strGases, int? dtmFechaInicioGases, int? dtmFechaVenceGases, int? strTarjetaOper, int? dtmFechaInicioTarjetaOper, int? dtmFechaVenceTarjetaOper, int? logVencimientoFecha);

		[OperationContract]
		void VehiculoForWin_Delete( int lngIdRegistro, int lngIdUsuario);

		[OperationContract]
		WCF.VehiculoForWin VehiculoForWin_Get(int lngIdRegistro, int lngIdUsuario);

		[OperationContract]
		WCF.VehiculoForWinList VehiculoForWin_GetAll();

		[OperationContract]
		WCF.VehiculoForWinList VehiculoForWin_GetFilter(int pagenum, int pagesize, string filter, string sort, string extablesfilter, string extablesfieldsfilter, string extablesrelationsfilter, string extablessort, string extablesfieldssort, string extablesrelationssort);

		#endregion 
		#region VehiculosKmMantenimiento
		[OperationContract]
		WCF.VehiculosKmMantenimiento VehiculosKmMantenimiento_Create(string strPlaca, int lngIdTipoMantenimiento, DateTime? dtmFechaUltimoCambio, int? intKmUltimoCambio, int? intKmSiguiente, int? intKmAcumulado, DateTime? dtmFechaUltimoUltimoAcumu, int? intKmAlarma1, int? intKmAlarma2, bool? logAvisa, DateTime? dtmFechaDetener, string strLugarDetener, DateTime? dtmFechaModif, int? lngIdUsuario);

		[OperationContract]
		void VehiculosKmMantenimiento_Update(string strPlaca, int lngIdTipoMantenimiento, DateTime? dtmFechaUltimoCambio, int? intKmUltimoCambio, int? intKmSiguiente, int? intKmAcumulado, DateTime? dtmFechaUltimoUltimoAcumu, int? intKmAlarma1, int? intKmAlarma2, bool? logAvisa, DateTime? dtmFechaDetener, string strLugarDetener, DateTime? dtmFechaModif, int? lngIdUsuario);

		[OperationContract]
		void VehiculosKmMantenimiento_Delete( string strPlaca, int lngIdTipoMantenimiento);

		[OperationContract]
		WCF.VehiculosKmMantenimiento VehiculosKmMantenimiento_Get(string strPlaca, int lngIdTipoMantenimiento);

		[OperationContract]
		WCF.VehiculosKmMantenimientoList VehiculosKmMantenimiento_GetAll();

		[OperationContract]
		WCF.VehiculosKmMantenimientoList VehiculosKmMantenimiento_GetFilter(int pagenum, int pagesize, string filter, string sort, string extablesfilter, string extablesfieldsfilter, string extablesrelationsfilter, string extablessort, string extablesfieldssort, string extablesrelationssort);

		#endregion 
		#region VehiculosKmMantenimientoDet
		[OperationContract]
		WCF.VehiculosKmMantenimientoDet VehiculosKmMantenimientoDet_Create(int lngIdRegistro, string strPlaca, int? lngIdTipoMantenimiento, DateTime? dtmFechaMovimiento, int? intKmUltimoCambio, int? intKmSiguiente, int? intAcumulado, int? intKmRestantes, string strObservaciones, DateTime? dtmFechaModif, int? lngIdUsuario);

		[OperationContract]
		void VehiculosKmMantenimientoDet_Update(int lngIdRegistro, string strPlaca, int? lngIdTipoMantenimiento, DateTime? dtmFechaMovimiento, int? intKmUltimoCambio, int? intKmSiguiente, int? intAcumulado, int? intKmRestantes, string strObservaciones, DateTime? dtmFechaModif, int? lngIdUsuario);

		[OperationContract]
		void VehiculosKmMantenimientoDet_Delete( int lngIdRegistro);

		[OperationContract]
		WCF.VehiculosKmMantenimientoDet VehiculosKmMantenimientoDet_Get(int lngIdRegistro);

		[OperationContract]
		WCF.VehiculosKmMantenimientoDetList VehiculosKmMantenimientoDet_GetAll();

		[OperationContract]
		WCF.VehiculosKmMantenimientoDetList VehiculosKmMantenimientoDet_GetFilter(int pagenum, int pagesize, string filter, string sort, string extablesfilter, string extablesfieldsfilter, string extablesrelationsfilter, string extablessort, string extablesfieldssort, string extablesrelationssort);

		#endregion 
		#region VehiculosKmMantenimientoDetAcum
		[OperationContract]
		WCF.VehiculosKmMantenimientoDetAcum VehiculosKmMantenimientoDetAcum_Create(int lngIdRegistro, string strPlaca, string strDetalleAcumuado, DateTime? drmFechaMovimiento, int? intKmMovimiento, DateTime? dtmFechaModif, int? lngIdUsuario);

		[OperationContract]
		void VehiculosKmMantenimientoDetAcum_Update(int lngIdRegistro, string strPlaca, string strDetalleAcumuado, DateTime? drmFechaMovimiento, int? intKmMovimiento, DateTime? dtmFechaModif, int? lngIdUsuario);

		[OperationContract]
		void VehiculosKmMantenimientoDetAcum_Delete( int lngIdRegistro);

		[OperationContract]
		WCF.VehiculosKmMantenimientoDetAcum VehiculosKmMantenimientoDetAcum_Get(int lngIdRegistro);

		[OperationContract]
		WCF.VehiculosKmMantenimientoDetAcumList VehiculosKmMantenimientoDetAcum_GetAll();

		[OperationContract]
		WCF.VehiculosKmMantenimientoDetAcumList VehiculosKmMantenimientoDetAcum_GetFilter(int pagenum, int pagesize, string filter, string sort, string extablesfilter, string extablesfieldsfilter, string extablesrelationsfilter, string extablessort, string extablesfieldssort, string extablesrelationssort);

		#endregion 
		#region VehiculoTraylers
		[OperationContract]
		WCF.VehiculoTraylers VehiculoTraylers_Create(string Trayler, string Placa, int? lngIdRegistro, int? lngIdRegistrRutaItemId, int? lngIdRegistrRuta, DateTime? Fecha, bool? Liquidado, int? Orden);

		[OperationContract]
		void VehiculoTraylers_Update(string Trayler, string Placa, int? lngIdRegistro, int? lngIdRegistrRutaItemId, int? lngIdRegistrRuta, DateTime? Fecha, bool? Liquidado, int? Orden);

		[OperationContract]
		void VehiculoTraylers_Delete( string Trayler);

		[OperationContract]
		WCF.VehiculoTraylers VehiculoTraylers_Get(string Trayler);

		[OperationContract]
		WCF.VehiculoTraylersList VehiculoTraylers_GetAll();

		[OperationContract]
		WCF.VehiculoTraylersList VehiculoTraylers_GetFilter(int pagenum, int pagesize, string filter, string sort, string extablesfilter, string extablesfieldsfilter, string extablesrelationsfilter, string extablessort, string extablesfieldssort, string extablesrelationssort);

		#endregion 
		#region TipoTrailer
		[OperationContract]
		WCF.TipoTrailer TipoTrailer_Create(int Codigo, string Trailer, string Descripcion);

		[OperationContract]
		void TipoTrailer_Update(int Codigo, string Trailer, string Descripcion);

		[OperationContract]
		void TipoTrailer_Delete( int Codigo);

		[OperationContract]
		WCF.TipoTrailer TipoTrailer_Get(int Codigo);

		[OperationContract]
		WCF.TipoTrailerList TipoTrailer_GetAll();

		[OperationContract]
		WCF.TipoTrailerList TipoTrailer_GetFilter(int pagenum, int pagesize, string filter, string sort, string extablesfilter, string extablesfieldsfilter, string extablesrelationsfilter, string extablessort, string extablesfieldssort, string extablesrelationssort);

		#endregion 
		#region TipoVehiculo
		[OperationContract]
		WCF.TipoVehiculo TipoVehiculo_Create(int Codigo, string Descripcion, bool? Activo);

		[OperationContract]
		void TipoVehiculo_Update(int Codigo, string Descripcion, bool? Activo);

		[OperationContract]
		void TipoVehiculo_Delete( int Codigo);

		[OperationContract]
		WCF.TipoVehiculo TipoVehiculo_Get(int Codigo);

		[OperationContract]
		WCF.TipoVehiculoList TipoVehiculo_GetAll();

		[OperationContract]
		WCF.TipoVehiculoList TipoVehiculo_GetFilter(int pagenum, int pagesize, string filter, string sort, string extablesfilter, string extablesfieldsfilter, string extablesrelationsfilter, string extablessort, string extablesfieldssort, string extablesrelationssort);

		#endregion 
		#region y_novedades_Liq
		[OperationContract]
		WCF.y_novedades_Liq y_novedades_Liq_Create(int IdNovedad, string nomina, int contrato, decimal nit, int idperiodo, short concepto, int centro, byte planta, DateTime fecha, byte? mes, short? ano, int? periodo, decimal? valor, float? horas, float? dias, byte? turno, char? estado, int? nro_presta, short? cpto_interes, bool sumar, string oficio);

		[OperationContract]
		void y_novedades_Liq_Update(int IdNovedad, string nomina, int contrato, decimal nit, int idperiodo, short concepto, DateTime fecha, byte? mes, short? ano, int? periodo, decimal? valor, float? horas, float? dias, int centro, byte planta, byte? turno, char? estado, int? nro_presta, short? cpto_interes, bool sumar, string oficio);

		[OperationContract]
		void y_novedades_Liq_Delete( int IdNovedad, string nomina, int contrato, decimal nit, int idperiodo, short concepto, int centro, byte planta);

		[OperationContract]
		WCF.y_novedades_Liq y_novedades_Liq_Get(int IdNovedad, string nomina, int contrato, decimal nit, int idperiodo, short concepto, int centro, byte planta);

		[OperationContract]
		WCF.y_novedades_LiqList y_novedades_Liq_GetAll();

		[OperationContract]
		WCF.y_novedades_LiqList y_novedades_Liq_GetFilter(int pagenum, int pagesize, string filter, string sort, string extablesfilter, string extablesfieldsfilter, string extablesrelationsfilter, string extablessort, string extablesfieldssort, string extablesrelationssort);

		#endregion 
	}
}
