﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;

using LiqViajes_Bll_Data;
using System.Threading;
using System.Timers;
using Timer = System.Timers.Timer;
using System.Collections;

namespace MetalLiqViajes_Services
{
    public partial class ServiceSatrac : ServiceBase
    {

        Timer timer = new Timer();
        private RutaSatrackLastEvents iRutaSatrackLastEvents;

        public RutaSatrackLastEvents IRutaSatrackLastEvents
        {
            get { return iRutaSatrackLastEvents; }
            set { iRutaSatrackLastEvents = value; }
        }

        bool swtWsEnProceso;

        private ArrayList listplacas;

        private RutaSatrackLastEvents iDataSatrack;

        public RutaSatrackLastEvents IDataSatrack
        {
            get { return iDataSatrack; }
            set { iDataSatrack = value; }
        }

        public ServiceSatrac()
        {
            InitializeComponent();
        }

        public void onDebug()
        {
            OnStart(null);
        }

        protected override void OnStart(string[] args)
        {
            timer = new Timer();
            timer.Elapsed += PerformTimerOperation;
            timer.Interval = Properties.Settings.Default.IntervalStart;
            timer.Start();

        }

        protected override void OnStop()
        {
        }

        private void PerformTimerOperation(object sender, ElapsedEventArgs e)
        {

            timer.Interval = Properties.Settings.Default.Interval;

            int hora = DateTime.Now.Hour;
            if (hora <= Properties.Settings.Default.HoraInicioTopeMadrudada)    // 4 am 
            {
                timer.Interval = Properties.Settings.Default.IntervalMadrugada;//IntervalMadrugada 1800000
                return;
            }
            if (hora > Properties.Settings.Default.HoraInicioMaximoNoche)       // 21 pm
            {
                timer.Interval = Properties.Settings.Default.IntervalNoche;//IntervalMadrugada 1800000
                return;
            }
            timer.Stop();
            CargarUltimaUbicacion();
            timer.Start();
        }

        private void CargarUltimaUbicacion()
        {
            try
            {
                if (swtWsEnProceso) return;

                swtWsEnProceso = true;
                string Placa = "";                
                listplacas = new ArrayList();
                List<VehiculoCCosto> vehiculosCentroCostoList = VehiculoCCostoController.Instance.GetAll().Where(t => (t.TipoVehiculoCodigo.Value == 1 || t.TipoVehiculoCodigo.Value == 3) && (t.logActivo.Value == 1)).ToList();
                foreach (var item in vehiculosCentroCostoList)
                {
                    Placa = item.strPlaca.Replace("-","");
                    listplacas.Add(Placa);
                }
                EventsSatrac.getEvents servicio = new EventsSatrac.getEvents();
                DataTable dt;
                string UserName = Properties.Settings.Default.UserName;
                string Password = Properties.Settings.Default.Password;
                string PhysicalID = "*";
                decimal Latutud = 0;
                decimal Longitud = 0;
                string error = "";
                System.Data.DataSet datosPlaca = null;
                #region getLastEvent
                RutaSatrackLastEvents m_RutaSatrackLastEvents;
                RutaSatrackHistoryEvents m_RutaSatrackHistoryEvents;
                datosPlaca = servicio.getLastEvent(UserName, Password, PhysicalID);
                if (datosPlaca.Tables.Count > 0)
                {
                    dt = datosPlaca.Tables[0];
                    if (dt != null)
                    {
                        foreach (DataRow dr in dt.Rows)
                        {
                            Placa = (string)dr["Placa"];

                            if (listplacas.Contains((string)dr["Placa"]))
                            {
                                Longitud = (decimal)dr["Longitud"];
                                Latutud = (decimal)dr["Latitud"];
                                m_RutaSatrackLastEvents = RutaSatrackLastEventsController.Instance.Get(Placa);
                                if (m_RutaSatrackLastEvents != null)
                                {
                                    if ((m_RutaSatrackLastEvents.Latitud != Latutud) && (m_RutaSatrackLastEvents.Longitud != Longitud))
                                    {
                                        m_RutaSatrackHistoryEvents = new RutaSatrackHistoryEvents();
                                        m_RutaSatrackHistoryEvents.Placa = m_RutaSatrackLastEvents.Placa;
                                        m_RutaSatrackHistoryEvents.FechaSistema = m_RutaSatrackLastEvents.FechaSistema;
                                        m_RutaSatrackHistoryEvents.FechaHora_GPS = m_RutaSatrackLastEvents.FechaHora_GPS;
                                        m_RutaSatrackHistoryEvents.EventoPrioridad = m_RutaSatrackLastEvents.EventoPrioridad;
                                        m_RutaSatrackHistoryEvents.VelocidadSentido = m_RutaSatrackLastEvents.VelocidadSentido;
                                        m_RutaSatrackHistoryEvents.Edad_Posicion = m_RutaSatrackLastEvents.Edad_Posicion;
                                        m_RutaSatrackHistoryEvents.Ubicacion = m_RutaSatrackLastEvents.Ubicacion;
                                        m_RutaSatrackHistoryEvents.Longitud = m_RutaSatrackLastEvents.Longitud;
                                        m_RutaSatrackHistoryEvents.Latitud = m_RutaSatrackLastEvents.Latitud;
                                        RutaSatrackHistoryEventsController.Instance.Create(m_RutaSatrackHistoryEvents);

                                        //------------------------------------
                                        // actualiza una placa y genera el historico
                                        m_RutaSatrackLastEvents.GenerateUndo();
                                        m_RutaSatrackLastEvents.FechaSistema = (DateTime)dr["Fecha Sistema"];
                                        m_RutaSatrackLastEvents.FechaHora_GPS = (DateTime)dr["Fecha GPS"];
                                        m_RutaSatrackLastEvents.EventoPrioridad = (string)dr["Evento / Prioridad"];
                                        m_RutaSatrackLastEvents.VelocidadSentido = (string)dr["Velocidad y sentido"];
                                        m_RutaSatrackLastEvents.Edad_Posicion = (string)dr["Edad posición"];
                                        m_RutaSatrackLastEvents.Ubicacion = (string)dr["Ubicación"];
                                        m_RutaSatrackLastEvents.Longitud = (decimal)dr["Longitud"];
                                        m_RutaSatrackLastEvents.Latitud = (decimal)dr["Latitud"];
                                        error = "";
                                        if (!RutaSatrackLastEventsController.Instance.UpdateChanges(m_RutaSatrackLastEvents, out error))
                                        {
                                            //
                                        }
                                    }
                                }
                                else
                                {
                                    // llegan las placas nuevas
                                    iRutaSatrackLastEvents = new RutaSatrackLastEvents();
                                    iRutaSatrackLastEvents.Placa = (string)dr["Placa"];
                                    iRutaSatrackLastEvents.FechaSistema = (DateTime)dr["Fecha Sistema"];
                                    iRutaSatrackLastEvents.FechaHora_GPS = (DateTime)dr["Fecha GPS"];
                                    iRutaSatrackLastEvents.EventoPrioridad = (string)dr["Evento / Prioridad"];
                                    iRutaSatrackLastEvents.VelocidadSentido = (string)dr["Velocidad y sentido"];
                                    iRutaSatrackLastEvents.Edad_Posicion = (string)dr["Edad posición"];
                                    iRutaSatrackLastEvents.Ubicacion = (string)dr["Ubicación"];
                                    iRutaSatrackLastEvents.Longitud = (decimal)dr["Longitud"];
                                    iRutaSatrackLastEvents.Latitud = (decimal)dr["Latitud"];
                                    RutaSatrackLastEventsController.Instance.Create(iRutaSatrackLastEvents);
                                }
                            }
                        }
                    }
                }
                swtWsEnProceso = false;
                return;
                #endregion
            }
            catch (Exception ex)
            {
                swtWsEnProceso = false;
            }
        }
    }
}
