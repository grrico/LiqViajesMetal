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
namespace LiqViajes_Bll_Data
{
	/// <summary>
	/// Class for Master Tables
	/// </summary>
	public static class MasterTables
	{
		private static FechaList m_fechalist;
		public static FechaList Fecha
		{
			get
			{
				if (m_fechalist == null)
				{
					m_fechalist = FechaController.Instance.GetAll();
				}
				return m_fechalist;
			}
		}
		private static novedades_nominaList m_novedades_nominalist;
		public static novedades_nominaList novedades_nomina
		{
			get
			{
				if (m_novedades_nominalist == null)
				{
					m_novedades_nominalist = novedades_nominaController.Instance.GetAll();
				}
				return m_novedades_nominalist;
			}
		}
		private static A2MontoEscritoList m_a2montoescritolist;
		public static A2MontoEscritoList A2MontoEscrito
		{
			get
			{
				if (m_a2montoescritolist == null)
				{
					m_a2montoescritolist = A2MontoEscritoController.Instance.GetAll();
				}
				return m_a2montoescritolist;
			}
		}
		private static CatalogoList m_catalogolist;
		public static CatalogoList Catalogo
		{
			get
			{
				if (m_catalogolist == null)
				{
					m_catalogolist = CatalogoController.Instance.GetAll();
				}
				return m_catalogolist;
			}
		}
		private static CiudadesList m_ciudadeslist;
		public static CiudadesList Ciudades
		{
			get
			{
				if (m_ciudadeslist == null)
				{
					m_ciudadeslist = CiudadesController.Instance.GetAll();
				}
				return m_ciudadeslist;
			}
		}
		private static CuentasList m_cuentaslist;
		public static CuentasList Cuentas
		{
			get
			{
				if (m_cuentaslist == null)
				{
					m_cuentaslist = CuentasController.Instance.GetAll();
				}
				return m_cuentaslist;
			}
		}
		private static CuentasVariosList m_cuentasvarioslist;
		public static CuentasVariosList CuentasVarios
		{
			get
			{
				if (m_cuentasvarioslist == null)
				{
					m_cuentasvarioslist = CuentasVariosController.Instance.GetAll();
				}
				return m_cuentasvarioslist;
			}
		}
		private static DepartamentosList m_departamentoslist;
		public static DepartamentosList Departamentos
		{
			get
			{
				if (m_departamentoslist == null)
				{
					m_departamentoslist = DepartamentosController.Instance.GetAll();
				}
				return m_departamentoslist;
			}
		}
		private static Documento_ReferenciaList m_documento_referencialist;
		public static Documento_ReferenciaList Documento_Referencia
		{
			get
			{
				if (m_documento_referencialist == null)
				{
					m_documento_referencialist = Documento_ReferenciaController.Instance.GetAll();
				}
				return m_documento_referencialist;
			}
		}
		private static MarcasVehiculosList m_marcasvehiculoslist;
		public static MarcasVehiculosList MarcasVehiculos
		{
			get
			{
				if (m_marcasvehiculoslist == null)
				{
					m_marcasvehiculoslist = MarcasVehiculosController.Instance.GetAll();
				}
				return m_marcasvehiculoslist;
			}
		}
		private static OpcionesList m_opcioneslist;
		public static OpcionesList Opciones
		{
			get
			{
				if (m_opcioneslist == null)
				{
					m_opcioneslist = OpcionesController.Instance.GetAll();
				}
				return m_opcioneslist;
			}
		}
		private static PaisesList m_paiseslist;
		public static PaisesList Paises
		{
			get
			{
				if (m_paiseslist == null)
				{
					m_paiseslist = PaisesController.Instance.GetAll();
				}
				return m_paiseslist;
			}
		}
		private static ParametrosList m_parametroslist;
		public static ParametrosList Parametros
		{
			get
			{
				if (m_parametroslist == null)
				{
					m_parametroslist = ParametrosController.Instance.GetAll();
				}
				return m_parametroslist;
			}
		}
		private static RangoKilometrosList m_rangokilometroslist;
		public static RangoKilometrosList RangoKilometros
		{
			get
			{
				if (m_rangokilometroslist == null)
				{
					m_rangokilometroslist = RangoKilometrosController.Instance.GetAll();
				}
				return m_rangokilometroslist;
			}
		}
		private static RegistrosBorradosList m_registrosborradoslist;
		public static RegistrosBorradosList RegistrosBorrados
		{
			get
			{
				if (m_registrosborradoslist == null)
				{
					m_registrosborradoslist = RegistrosBorradosController.Instance.GetAll();
				}
				return m_registrosborradoslist;
			}
		}
		private static RutasList m_rutaslist;
		public static RutasList Rutas
		{
			get
			{
				if (m_rutaslist == null)
				{
					m_rutaslist = RutasController.Instance.GetAll();
				}
				return m_rutaslist;
			}
		}
		private static Rutas_PeajesList m_rutas_peajeslist;
		public static Rutas_PeajesList Rutas_Peajes
		{
			get
			{
				if (m_rutas_peajeslist == null)
				{
					m_rutas_peajeslist = Rutas_PeajesController.Instance.GetAll();
				}
				return m_rutas_peajeslist;
			}
		}
		private static Rutas_Peajes_DetalleList m_rutas_peajes_detallelist;
		public static Rutas_Peajes_DetalleList Rutas_Peajes_Detalle
		{
			get
			{
				if (m_rutas_peajes_detallelist == null)
				{
					m_rutas_peajes_detallelist = Rutas_Peajes_DetalleController.Instance.GetAll();
				}
				return m_rutas_peajes_detallelist;
			}
		}
		private static RutasAbreviaturasList m_rutasabreviaturaslist;
		public static RutasAbreviaturasList RutasAbreviaturas
		{
			get
			{
				if (m_rutasabreviaturaslist == null)
				{
					m_rutasabreviaturaslist = RutasAbreviaturasController.Instance.GetAll();
				}
				return m_rutasabreviaturaslist;
			}
		}
		private static RutasAgrupaPeajesList m_rutasagrupapeajeslist;
		public static RutasAgrupaPeajesList RutasAgrupaPeajes
		{
			get
			{
				if (m_rutasagrupapeajeslist == null)
				{
					m_rutasagrupapeajeslist = RutasAgrupaPeajesController.Instance.GetAll();
				}
				return m_rutasagrupapeajeslist;
			}
		}
		private static RutasAgrupaPeajesDetList m_rutasagrupapeajesdetlist;
		public static RutasAgrupaPeajesDetList RutasAgrupaPeajesDet
		{
			get
			{
				if (m_rutasagrupapeajesdetlist == null)
				{
					m_rutasagrupapeajesdetlist = RutasAgrupaPeajesDetController.Instance.GetAll();
				}
				return m_rutasagrupapeajesdetlist;
			}
		}
		private static RutasCombustibleList m_rutascombustiblelist;
		public static RutasCombustibleList RutasCombustible
		{
			get
			{
				if (m_rutascombustiblelist == null)
				{
					m_rutascombustiblelist = RutasCombustibleController.Instance.GetAll();
				}
				return m_rutascombustiblelist;
			}
		}
		private static RutasCuentasList m_rutascuentaslist;
		public static RutasCuentasList RutasCuentas
		{
			get
			{
				if (m_rutascuentaslist == null)
				{
					m_rutascuentaslist = RutasCuentasController.Instance.GetAll();
				}
				return m_rutascuentaslist;
			}
		}
		private static RutasDetList m_rutasdetlist;
		public static RutasDetList RutasDet
		{
			get
			{
				if (m_rutasdetlist == null)
				{
					m_rutasdetlist = RutasDetController.Instance.GetAll();
				}
				return m_rutasdetlist;
			}
		}
		private static RutasMaestroPeajesList m_rutasmaestropeajeslist;
		public static RutasMaestroPeajesList RutasMaestroPeajes
		{
			get
			{
				if (m_rutasmaestropeajeslist == null)
				{
					m_rutasmaestropeajeslist = RutasMaestroPeajesController.Instance.GetAll();
				}
				return m_rutasmaestropeajeslist;
			}
		}
		private static UsuariosList m_usuarioslist;
		public static UsuariosList Usuarios
		{
			get
			{
				if (m_usuarioslist == null)
				{
					m_usuarioslist = UsuariosController.Instance.GetAll();
				}
				return m_usuarioslist;
			}
		}
		private static VehiculoCCostoList m_vehiculoccostolist;
		public static VehiculoCCostoList VehiculoCCosto
		{
			get
			{
				if (m_vehiculoccostolist == null)
				{
					m_vehiculoccostolist = VehiculoCCostoController.Instance.GetAll();
				}
				return m_vehiculoccostolist;
			}
		}
		private static TercerosList m_terceroslist;
		public static TercerosList Terceros
		{
			get
			{
				if (m_terceroslist == null)
				{
					m_terceroslist = TercerosController.Instance.GetAll();
				}
				return m_terceroslist;
			}
		}
		private static TipoTrailerList m_tipotrailerlist;
		public static TipoTrailerList TipoTrailer
		{
			get
			{
				if (m_tipotrailerlist == null)
				{
					m_tipotrailerlist = TipoTrailerController.Instance.GetAll();
				}
				return m_tipotrailerlist;
			}
		}
		private static TipoVehiculoList m_tipovehiculolist;
		public static TipoVehiculoList TipoVehiculo
		{
			get
			{
				if (m_tipovehiculolist == null)
				{
					m_tipovehiculolist = TipoVehiculoController.Instance.GetAll();
				}
				return m_tipovehiculolist;
			}
		}
		public static void Reset()
		{
			 Reset("");
		}

		public static void Reset(string obj)
		{
			switch (obj)
			{
				case "Fecha":
				m_fechalist=null;
				break;
				case "novedades_nomina":
				m_novedades_nominalist=null;
				break;
				case "A2MontoEscrito":
				m_a2montoescritolist=null;
				break;
				case "Catalogo":
				m_catalogolist=null;
				break;
				case "Ciudades":
				m_ciudadeslist=null;
				break;
				case "Cuentas":
				m_cuentaslist=null;
				break;
				case "CuentasVarios":
				m_cuentasvarioslist=null;
				break;
				case "Departamentos":
				m_departamentoslist=null;
				break;
				case "Documento_Referencia":
				m_documento_referencialist=null;
				break;
				case "MarcasVehiculos":
				m_marcasvehiculoslist=null;
				break;
				case "Opciones":
				m_opcioneslist=null;
				break;
				case "Paises":
				m_paiseslist=null;
				break;
				case "Parametros":
				m_parametroslist=null;
				break;
				case "RangoKilometros":
				m_rangokilometroslist=null;
				break;
				case "RegistrosBorrados":
				m_registrosborradoslist=null;
				break;
				case "Rutas":
				m_rutaslist=null;
				break;
				case "Rutas_Peajes":
				m_rutas_peajeslist=null;
				break;
				case "Rutas_Peajes_Detalle":
				m_rutas_peajes_detallelist=null;
				break;
				case "RutasAbreviaturas":
				m_rutasabreviaturaslist=null;
				break;
				case "RutasAgrupaPeajes":
				m_rutasagrupapeajeslist=null;
				break;
				case "RutasAgrupaPeajesDet":
				m_rutasagrupapeajesdetlist=null;
				break;
				case "RutasCombustible":
				m_rutascombustiblelist=null;
				break;
				case "RutasCuentas":
				m_rutascuentaslist=null;
				break;
				case "RutasDet":
				m_rutasdetlist=null;
				break;
				case "RutasMaestroPeajes":
				m_rutasmaestropeajeslist=null;
				break;
				case "Usuarios":
				m_usuarioslist=null;
				break;
				case "VehiculoCCosto":
				m_vehiculoccostolist=null;
				break;
				case "Terceros":
				m_terceroslist=null;
				break;
				case "TipoTrailer":
				m_tipotrailerlist=null;
				break;
				case "TipoVehiculo":
				m_tipovehiculolist=null;
				break;
				case "":
				m_fechalist=null;
				m_novedades_nominalist=null;
				m_a2montoescritolist=null;
				m_catalogolist=null;
				m_ciudadeslist=null;
				m_cuentaslist=null;
				m_cuentasvarioslist=null;
				m_departamentoslist=null;
				m_documento_referencialist=null;
				m_marcasvehiculoslist=null;
				m_opcioneslist=null;
				m_paiseslist=null;
				m_parametroslist=null;
				m_rangokilometroslist=null;
				m_registrosborradoslist=null;
				m_rutaslist=null;
				m_rutas_peajeslist=null;
				m_rutas_peajes_detallelist=null;
				m_rutasabreviaturaslist=null;
				m_rutasagrupapeajeslist=null;
				m_rutasagrupapeajesdetlist=null;
				m_rutascombustiblelist=null;
				m_rutascuentaslist=null;
				m_rutasdetlist=null;
				m_rutasmaestropeajeslist=null;
				m_usuarioslist=null;
				m_vehiculoccostolist=null;
				m_terceroslist=null;
				m_tipotrailerlist=null;
				m_tipovehiculolist=null;
				break;
			}
		}
	}
}
