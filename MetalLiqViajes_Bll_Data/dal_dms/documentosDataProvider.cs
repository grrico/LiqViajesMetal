using System;
using System.Data;
using System.Data.Common;
using Sinapsys.Datos;
using LiqViajes_Bll_Data.Security;
using System.Runtime.Serialization;

namespace LiqViajes_Bll_Data
{

    public partial class documentosDataProvider
    {
        private static documentosDataProvider MySingleObj = null;

        public documentosDataProvider()
        {

        }

        public static documentosDataProvider Instance
        {
            get
            {
                if (MySingleObj == null)
                {
                    MySingleObj = new documentosDataProvider();
                }

                return MySingleObj;
            }
        }

        public DataTable GetByTipoNumero(string tipo, int numero)
        {
            try
            {
                Sinapsys.Datos.SQL LocalDataProvider;
                bool disconnect = false;
                if (DataProvider.Concurrente)
                {
                    LocalDataProvider = new Sinapsys.Datos.SQL();
                    LocalDataProvider.Conectar(DataProvider.Alias, false);
                }
                else
                {
                    LocalDataProvider = DataProvider.Datos;
                }
                disconnect = DataProvider.ValidateConnection();
                System.Data.SqlClient.SqlCommand Comando = new System.Data.SqlClient.SqlCommand();
                System.Data.SqlClient.SqlParameterCollection paramlist = Comando.Parameters;
                System.Collections.Hashtable nullExit = null;
                paramlist.AddWithValue("@tipo", tipo);
                paramlist.AddWithValue("@numero", numero);
                return LocalDataProvider.EjecutarProcedimiento("dbo.Add_documentosGetByTipoNumero", paramlist, disconnect, out nullExit, DataProvider.TiempoEspera);

            }
            catch (Exception ex)
            {
                Utilidades.LogErrores(ex.Message + (ex.InnerException != null ? ex.InnerException.Message : ""), DataProvider.AplicacionNombre);
                throw ex;
            }
        }

        public DataTable GetAll()
        {
            try
            {
                Sinapsys.Datos.SQL LocalDataProvider;
                bool disconnect = false;
                if (DataProvider.Concurrente)
                {
                    LocalDataProvider = new Sinapsys.Datos.SQL();
                    LocalDataProvider.Conectar(DataProvider.Alias, false);
                }
                else
                {
                    LocalDataProvider = DataProvider.Datos;
                }
                disconnect = DataProvider.ValidateConnection();
                System.Data.SqlClient.SqlCommand Comando = new System.Data.SqlClient.SqlCommand();
                System.Data.SqlClient.SqlParameterCollection paramlist = Comando.Parameters;
                System.Collections.Hashtable nullExit = null;
                return LocalDataProvider.EjecutarProcedimiento("dbo.documentosGetAll", paramlist, disconnect, out nullExit, DataProvider.TiempoEspera);
            }
            catch (Exception ex)
            {
                Utilidades.LogErrores(ex.Message + (ex.InnerException != null ? ex.InnerException.Message : ""), DataProvider.AplicacionNombre);
                throw ex;
            }
        }

        public DataTable GetByRange(string tipo, int numero, int numeroHasta)
        {
            try
            {
                Sinapsys.Datos.SQL LocalDataProvider;
                bool disconnect = false;
                if (DataProvider.Concurrente)
                {
                    LocalDataProvider = new Sinapsys.Datos.SQL();
                    LocalDataProvider.Conectar(DataProvider.Alias, false);
                }
                else
                {
                    LocalDataProvider = DataProvider.Datos;
                }
                disconnect = DataProvider.ValidateConnection();
                System.Data.SqlClient.SqlCommand Comando = new System.Data.SqlClient.SqlCommand();
                System.Data.SqlClient.SqlParameterCollection paramlist = Comando.Parameters;
                System.Collections.Hashtable nullExit = null;
                paramlist.AddWithValue("@tipo", tipo);
                paramlist.AddWithValue("@numero", numero);
                paramlist.AddWithValue("@numeroHasta", numeroHasta);
                return LocalDataProvider.EjecutarProcedimiento("dbo.Add_documentosGetByTipoRange", paramlist, disconnect, out nullExit, DataProvider.TiempoEspera);

            }
            catch (Exception ex)
            {
                Utilidades.LogErrores(ex.Message + (ex.InnerException != null ? ex.InnerException.Message : ""), DataProvider.AplicacionNombre);
                throw ex;
            }
        }

        public DataTable GetBy_TipoNitFechaGetAll(string tipo, string nit, DateTime fechaI, DateTime fechaF)
        {
            try
            {
                Sinapsys.Datos.SQL LocalDataProvider;
                bool disconnect = false;
                if (DataProvider.Concurrente)
                {
                    LocalDataProvider = new Sinapsys.Datos.SQL();
                    LocalDataProvider.Conectar(DataProvider.Alias, false);
                }
                else
                {
                    LocalDataProvider = DataProvider.Datos;
                }
                disconnect = DataProvider.ValidateConnection();
                System.Data.SqlClient.SqlCommand Comando = new System.Data.SqlClient.SqlCommand();
                System.Data.SqlClient.SqlParameterCollection paramlist = Comando.Parameters;
                System.Collections.Hashtable nullExit = null;

                paramlist.AddWithValue("@tipo", tipo);
                paramlist.AddWithValue("@nit", nit);
                paramlist.AddWithValue("@fechaI", fechaI);
                paramlist.AddWithValue("@fechaF", fechaF);
                return LocalDataProvider.EjecutarProcedimiento("dbo.add_documentosGetByTipoNitFechaGetAll", paramlist, disconnect, out nullExit, DataProvider.TiempoEspera);
            }
            catch (Exception ex)
            {
                Utilidades.LogErrores(ex.Message + (ex.InnerException != null ? ex.InnerException.Message : ""), DataProvider.AplicacionNombre);
                throw ex;
            }
        }

        public DataSet GetBy_TipoNitFecha(string tipo, string nit, DateTime fechaI, DateTime fechaF)
        {
            try
            {
                if (Validate.security.CanUse("SD_CreditosReporte"))
                {
                    Sinapsys.Datos.SQL LocalDataProvider;
                    bool disconnect = false;
                    if (DataProvider.Concurrente)
                    {
                        LocalDataProvider = new Sinapsys.Datos.SQL();
                        LocalDataProvider.Conectar(DataProvider.Alias, false);
                    }
                    else
                    {
                        LocalDataProvider = DataProvider.Datos;
                    }
                    disconnect = DataProvider.ValidateConnection();
                    System.Data.SqlClient.SqlCommand Comando = new System.Data.SqlClient.SqlCommand();
                    System.Data.SqlClient.SqlParameterCollection paramlist = Comando.Parameters;
                    System.Collections.Hashtable nullExit = null;

                    paramlist.AddWithValue("@tipo", tipo);
                    paramlist.AddWithValue("@nit", nit);
                    paramlist.AddWithValue("@fechaI", fechaI);
                    paramlist.AddWithValue("@fechaF", fechaF);
                    return LocalDataProvider.EjecutarProcedimientoDS("dbo.add_documentosGetByTipoNitFecha", paramlist, out nullExit, DataProvider.TiempoEspera);
                }
                else
                    return null;
            }
            catch (Exception ex)
            {
                Utilidades.LogErrores(ex.Message + (ex.InnerException != null ? ex.InnerException.Message : ""), DataProvider.AplicacionNombre);
                throw ex;
            }
        }

        public int Create(int id, string tipo, int numero, byte sw, decimal nit, DateTime fecha, string condicion, DateTime? vencimiento, decimal? valor_total, decimal? iva, decimal? retencion, decimal? retencion_causada, decimal? retencion_iva, decimal? retencion_ica, decimal? descuento_pie, decimal? fletes, decimal? iva_fletes, decimal? costo, decimal? vendedor, decimal? valor_aplicado, bool anulado, string modelo, string documento, string notas, string usuario, string pc, DateTime fecha_hora, decimal? retencion2, decimal? retencion3, short bodega, decimal? impoconsumo, decimal? descuento2, short? duracion, short? concepto, DateTime? vencimiento_presup, char? exportado, decimal? impuesto_deporte, string prefijo, string moneda, float? tasa, int? centro_doc, decimal? valor_mercancia, short? numero_cuotas, short? codigo_direccion, float? descuento_1, float? descuento_2, float? descuento_3, decimal? abono, DateTime? fecha_consignacion, char? Iva_Costo, short? concepto_Retencion, decimal? porc_RteFuente, decimal? porc_RteIva, decimal? porc_RteIvaSimpl, decimal? porc_RteIca, decimal? porc_RteA, decimal? porc_RteB, short? bodega_ot, int? numero_ot, decimal? provision, decimal? ajuste, decimal? porc_RteCree, decimal? retencion_cree, string codigo_retencion_cree, decimal? cree_causado, string ObligacionFinanciera, decimal? Base_dcto_RC, string numincapacidad, int? idincapacidad, string module, Sinapsys.Datos.SQL datosTransaccion = null)
        {
            try
            {
                Sinapsys.Datos.SQL LocalDataProvider;
                bool disconnect = false;
                if (datosTransaccion != null) LocalDataProvider = datosTransaccion;
                else
                {
                    if (DataProvider.Concurrente)
                    {
                        LocalDataProvider = new Sinapsys.Datos.SQL();
                        LocalDataProvider.Conectar(DataProvider.Alias, false);
                    }
                    else
                    {
                        LocalDataProvider = DataProvider.Datos;
                    }
                    disconnect = DataProvider.ValidateConnection();
                }
                System.Data.SqlClient.SqlCommand Comando = new System.Data.SqlClient.SqlCommand();
                System.Data.SqlClient.SqlParameterCollection paramlist = Comando.Parameters;
                System.Collections.Hashtable nullExit = null;

                paramlist.AddWithValue("@id", id);
                paramlist.AddWithValue("@tipo", tipo);
                paramlist.AddWithValue("@numero", numero);
                paramlist.AddWithValue("@sw", sw);
                paramlist.AddWithValue("@nit", nit);
                paramlist.AddWithValue("@fecha", fecha);
                if (condicion != null)
                {
                    paramlist.AddWithValue("@condicion", condicion);
                }
                if (vencimiento != null)
                {
                    paramlist.AddWithValue("@vencimiento", vencimiento);
                }
                if (valor_total != null)
                {
                    paramlist.AddWithValue("@valor_total", valor_total);
                }
                if (iva != null)
                {
                    paramlist.AddWithValue("@iva", iva);
                }
                if (retencion != null)
                {
                    paramlist.AddWithValue("@retencion", retencion);
                }
                if (retencion_causada != null)
                {
                    paramlist.AddWithValue("@retencion_causada", retencion_causada);
                }
                if (retencion_iva != null)
                {
                    paramlist.AddWithValue("@retencion_iva", retencion_iva);
                }
                if (retencion_ica != null)
                {
                    paramlist.AddWithValue("@retencion_ica", retencion_ica);
                }
                if (descuento_pie != null)
                {
                    paramlist.AddWithValue("@descuento_pie", descuento_pie);
                }
                if (fletes != null)
                {
                    paramlist.AddWithValue("@fletes", fletes);
                }
                if (iva_fletes != null)
                {
                    paramlist.AddWithValue("@iva_fletes", iva_fletes);
                }
                if (costo != null)
                {
                    paramlist.AddWithValue("@costo", costo);
                }
                if (vendedor != null)
                {
                    paramlist.AddWithValue("@vendedor", vendedor);
                }
                if (valor_aplicado != null)
                {
                    paramlist.AddWithValue("@valor_aplicado", valor_aplicado);
                }
                paramlist.AddWithValue("@anulado", anulado);
                if (modelo != null)
                {
                    paramlist.AddWithValue("@modelo", modelo);
                }
                if (documento != null)
                {
                    paramlist.AddWithValue("@documento", documento);
                }
                if (notas != null)
                {
                    paramlist.AddWithValue("@notas", notas);
                }
                paramlist.AddWithValue("@usuario", usuario);
                paramlist.AddWithValue("@pc", pc);
                paramlist.AddWithValue("@fecha_hora", fecha_hora);
                if (retencion2 != null)
                {
                    paramlist.AddWithValue("@retencion2", retencion2);
                }
                if (retencion3 != null)
                {
                    paramlist.AddWithValue("@retencion3", retencion3);
                }
                paramlist.AddWithValue("@bodega", bodega);
                if (impoconsumo != null)
                {
                    paramlist.AddWithValue("@impoconsumo", impoconsumo);
                }
                if (descuento2 != null)
                {
                    paramlist.AddWithValue("@descuento2", descuento2);
                }
                if (duracion != null)
                {
                    paramlist.AddWithValue("@duracion", duracion);
                }
                if (concepto != null)
                {
                    paramlist.AddWithValue("@concepto", concepto);
                }
                if (vencimiento_presup != null)
                {
                    paramlist.AddWithValue("@vencimiento_presup", vencimiento_presup);
                }
                if (exportado != null)
                {
                    paramlist.AddWithValue("@exportado", exportado);
                }
                if (impuesto_deporte != null)
                {
                    paramlist.AddWithValue("@impuesto_deporte", impuesto_deporte);
                }
                if (prefijo != null)
                {
                    paramlist.AddWithValue("@prefijo", prefijo);
                }
                if (moneda != null)
                {
                    paramlist.AddWithValue("@moneda", moneda);
                }
                if (tasa != null)
                {
                    paramlist.AddWithValue("@tasa", tasa);
                }
                if (centro_doc != null)
                {
                    paramlist.AddWithValue("@centro_doc", centro_doc);
                }
                if (valor_mercancia != null)
                {
                    paramlist.AddWithValue("@valor_mercancia", valor_mercancia);
                }
                if (numero_cuotas != null)
                {
                    paramlist.AddWithValue("@numero_cuotas", numero_cuotas);
                }
                if (codigo_direccion != null)
                {
                    paramlist.AddWithValue("@codigo_direccion", codigo_direccion);
                }
                if (descuento_1 != null)
                {
                    paramlist.AddWithValue("@descuento_1", descuento_1);
                }
                if (descuento_2 != null)
                {
                    paramlist.AddWithValue("@descuento_2", descuento_2);
                }
                if (descuento_3 != null)
                {
                    paramlist.AddWithValue("@descuento_3", descuento_3);
                }
                if (abono != null)
                {
                    paramlist.AddWithValue("@abono", abono);
                }
                if (fecha_consignacion != null)
                {
                    paramlist.AddWithValue("@fecha_consignacion", fecha_consignacion);
                }
                if (Iva_Costo != null)
                {
                    paramlist.AddWithValue("@Iva_Costo", Iva_Costo);
                }
                if (concepto_Retencion != null)
                {
                    paramlist.AddWithValue("@concepto_Retencion", concepto_Retencion);
                }
                if (porc_RteFuente != null)
                {
                    paramlist.AddWithValue("@porc_RteFuente", porc_RteFuente);
                }
                if (porc_RteIva != null)
                {
                    paramlist.AddWithValue("@porc_RteIva", porc_RteIva);
                }
                if (porc_RteIvaSimpl != null)
                {
                    paramlist.AddWithValue("@porc_RteIvaSimpl", porc_RteIvaSimpl);
                }
                if (porc_RteIca != null)
                {
                    paramlist.AddWithValue("@porc_RteIca", porc_RteIca);
                }
                if (porc_RteA != null)
                {
                    paramlist.AddWithValue("@porc_RteA", porc_RteA);
                }
                if (porc_RteB != null)
                {
                    paramlist.AddWithValue("@porc_RteB", porc_RteB);
                }
                if (bodega_ot != null)
                {
                    paramlist.AddWithValue("@bodega_ot", bodega_ot);
                }
                if (numero_ot != null)
                {
                    paramlist.AddWithValue("@numero_ot", numero_ot);
                }
                if (provision != null)
                {
                    paramlist.AddWithValue("@provision", provision);
                }
                if (ajuste != null)
                {
                    paramlist.AddWithValue("@ajuste", ajuste);
                }
                if (porc_RteCree != null)
                {
                    paramlist.AddWithValue("@porc_RteCree", porc_RteCree);
                }
                if (retencion_cree != null)
                {
                    paramlist.AddWithValue("@retencion_cree", retencion_cree);
                }
                if (codigo_retencion_cree != null)
                {
                    paramlist.AddWithValue("@codigo_retencion_cree", codigo_retencion_cree);
                }
                if (cree_causado != null)
                {
                    paramlist.AddWithValue("@cree_causado", cree_causado);
                }
                if (ObligacionFinanciera != null)
                {
                    paramlist.AddWithValue("@ObligacionFinanciera", ObligacionFinanciera);
                }
                if (Base_dcto_RC != null)
                {
                    paramlist.AddWithValue("@Base_dcto_RC", Base_dcto_RC);
                }
                if (numincapacidad != null)
                {
                    paramlist.AddWithValue("@numincapacidad", numincapacidad);
                }
                if (idincapacidad != null)
                {
                    paramlist.AddWithValue("@idincapacidad", idincapacidad);
                }
                // Execute the query and return the new identity value
                int returnValue = Convert.ToInt32(LocalDataProvider.EjecutarProcedimiento("dbo.documentosCreate", paramlist, disconnect, out nullExit, DataProvider.TiempoEspera).Rows[0][0]);

                return returnValue;
            }
            catch (Exception ex)
            {
                Utilidades.LogErrores(ex.Message + (ex.InnerException != null ? ex.InnerException.Message : ""), DataProvider.AplicacionNombre);
                throw ex;
            }
        }

    }
}
