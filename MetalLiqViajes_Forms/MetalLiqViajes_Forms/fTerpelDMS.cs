﻿using LiqViajes_Bll_Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static MetalLiqViajes_Forms.Util.Parametros;

namespace MetalLiqViajes_Forms
{
    public partial class fTerpelDMS : Form
    {
        private List<TercerosConductores> conductoresList;
        public List<UtilPlaca> ultilplacalist { get; set; }
        private List<YearTerpel> YearsList { get; set; }
        private YearTerpel yearTerpel { get; set; }
        private List<MonthTerpel> monthTerpelList { get; set; }
        private MonthTerpel monthTerpel { get; set; }
        private List<documentos> documentoslist { get; set; }
        private documentos documento { get; set; }
        private List<movimientos> movimientoslist { get; set; }


        private DateTime fechaI { get; set; }
        private DateTime fechaF { get; set; }

        public fTerpelDMS()
        {
            InitializeComponent();
        }

        private void fTerpelDMS_Load(object sender, EventArgs e)
        {
            YearsList = new List<YearTerpel>();
            int yi = 2017;
            int yf = DateTime.Now.Year;
            for (int i = yi; i <= yf; i++)
            {
                yearTerpel = new YearTerpel();
                yearTerpel.CodYear = i;
                YearsList.Add(yearTerpel);
            }

            string[] MesesTerpel = new string[12];
            MesesTerpel[0] = "Enero";
            MesesTerpel[1] = "Febrero";
            MesesTerpel[2] = "Marzo";
            MesesTerpel[3] = "Abril";
            MesesTerpel[4] = "Mayo";
            MesesTerpel[5] = "Junio";
            MesesTerpel[6] = "Julio";
            MesesTerpel[7] = "Agosto";
            MesesTerpel[8] = "Septiembre";
            MesesTerpel[9] = "Octubre";
            MesesTerpel[10] = "Noviembre";
            MesesTerpel[11] = "Diciembre";

            monthTerpelList = new List<MonthTerpel>();
            for (int i = 0; i < MesesTerpel.Count(); i++)
            {
                monthTerpel = new MonthTerpel();
                monthTerpel.CodMonth = i + 1;
                monthTerpel.NomMonth = MesesTerpel[i];
                monthTerpelList.Add(monthTerpel);
            }

            this.comboBoxYear.DisplayMember = "CodYear";
            this.comboBoxYear.ValueMember = "CodYear";

            this.comboBoxMonth.DisplayMember = "NomMonth";
            this.comboBoxMonth.ValueMember = "CodMonth";

            comboBoxYear.DataSource = YearsList.OrderByDescending(o => o.CodYear).ToList();
            comboBoxYear.SelectedValue = DateTime.Now.Year;

            comboBoxMonth.DataSource = monthTerpelList.ToList();
            comboBoxMonth.SelectedIndex = (DateTime.Now.Month) - 1;
            comboBoxMonth.SelectedValue = DateTime.Now.Month;

            comboBoxYear.SelectedValue = DateTime.Now.Year;
            yearTerpel = comboBoxYear.SelectedItem as YearTerpel;
            monthTerpel = comboBoxMonth.SelectedItem as MonthTerpel;

            List<TipoMovimiento> tipoMovimientoList = new List<TipoMovimiento>();
            tipoMovimientoList.Add(new TipoMovimiento { Codigo = 1, Descripcion = "23" });
            tipoMovimientoList.Add(new TipoMovimiento { Codigo = 2, Descripcion = "45" });
            tipoMovimientoList.Add(new TipoMovimiento { Codigo = 3, Descripcion = "45-A" });
            tipoMovimientoList.Add(new TipoMovimiento { Codigo = 4, Descripcion = "52" });
            tipoMovimientoList.Add(new TipoMovimiento { Codigo = 5, Descripcion = "52V" });
            tipoMovimientoList.Add(new TipoMovimiento { Codigo = 6, Descripcion = "55" });
            tipoMovimientoList.Add(new TipoMovimiento { Codigo = 7, Descripcion = "57" });
            tipoMovimientoList.Add(new TipoMovimiento { Codigo = 8, Descripcion = "57-A" });
            tipoMovimientoList.Add(new TipoMovimiento { Codigo = 9, Descripcion = "75" });
            tipoMovimientoList.Add(new TipoMovimiento { Codigo = 10, Descripcion = "83" });
            comboBoxTipoMivimiento.DataSource = tipoMovimientoList;
            comboBoxTipoMivimiento.Refresh();
            comboBoxTipoMivimiento.Text = "52V";
            comboBoxTipoMivimiento.SelectedIndex = 4;
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            if (comboBoxTipoMivimiento.Text == "") return;

            if (comboBoxTipoMivimiento.Text != "83")
            {
                if (textBoxNumero.Text == "") return;
                if (textBoxNumeroHasta.Text == "")
                {
                    GetByTypeNumeric();
                }
                else
                {
                    GetByTypeRange();
                }
            }
            else
            {
                GetByTerpel();

            }
            TercerosConductores conductores;
            conductoresList = TercerosConductoresController.Instance.GetAll().Where(t => t.logEstado.Value == true).ToList();
            foreach (var item in documentoslist)
            {
                conductores = conductoresList.Where(t => t.IntNit.ToString() == item.nit.ToString()).FirstOrDefault();
                if (conductor != null)
                    item.conductor = conductores.strNombres.ToUpper();
            }
            dataGridViewDocumentos.Refresh();
        }

        private void GetByTerpel()
        {
            CargaFecha();
            documentoslist = documentosController.Instance.GetBy_TipoNitFechaGetAll(Properties.Settings.Default.TipoTerpel, Properties.Settings.Default.NitTerpel, fechaI, fechaF);
            if (documentoslist.Count > 0)
            {
                dataGridViewDocumentos.DataSource = documentoslist;
                dataGridViewDocumentos.Refresh();
            }
            else
            {
                MessageBox.Show("No existe el registro solicitado.", "Metal", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void GetByTypeRange()
        {
            documentoslist = documentosController.Instance.GetByRange(comboBoxTipoMivimiento.Text, Convert.ToInt32(textBoxNumero.Text), Convert.ToInt32(textBoxNumeroHasta.Text));
            documentoslist.Add(documento);
            dataGridViewDocumentos.DataSource = documentoslist;
            dataGridViewDocumentos.Refresh();
        }

        private void GetByTypeNumeric()
        {
            documento = documentosController.Instance.GetByTipoNumero(comboBoxTipoMivimiento.Text, Convert.ToInt32(textBoxNumero.Text));
            if (documento != null)
            {
                documentoslist = new List<documentos>();
                documentoslist.Add(documento);
                dataGridViewDocumentos.DataSource = documentoslist;
                dataGridViewDocumentos.Refresh();
            }
            else
            {
                MessageBox.Show("No existe el registro solicitado.", "Metal", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void CargaFecha()
        {

            yearTerpel = comboBoxYear.SelectedItem as YearTerpel;
            monthTerpel = comboBoxMonth.SelectedItem as MonthTerpel;
            if (monthTerpel != null)
            {
                int imes = monthTerpel.CodMonth;
                if (imes >= 12)
                    imes = 1;
                imes++;
                string ifecha = yearTerpel.CodYear.ToString() + "/" + monthTerpel.CodMonth.ToString("##") + "/01";
                string ffecha = yearTerpel.CodYear.ToString() + "/" + imes.ToString("##") + "/01";
                fechaI = Convert.ToDateTime(ifecha);
                fechaF = Convert.ToDateTime(ffecha).AddDays(-1);
            }
        }

        private void dataGridViewDocumentos_RowEnter(object sender, DataGridViewCellEventArgs e)
        {

            documento = dataGridViewDocumentos.Rows[e.RowIndex].DataBoundItem as documentos;

            movimientoslist = movimientosController.Instance.GetByTipoNumero(documento.tipo, documento.numero);
            dataGridViewMovimiento.DataSource = movimientoslist;
            dataGridViewMovimiento.Refresh();

            textBoxValorTotal.Text = movimientoslist.Where(c => c.cuenta == "13301504").Sum(t => t.valor).ToString("n0");
            textBoxValorTotalNiff.Text = movimientoslist.Sum(t => t.valor_niif).ToString("n0");

            checkBoxAplicado.Enabled = false;
            checkBoxAplicado.Checked = false;
            if (documento.valor_aplicado.Value > 0)
                checkBoxAplicado.Checked = true;

            textBoxNit.Text = documento.nit.ToString();
            textBoxValor.Text = documento.valor_total.Value.ToString("n0");

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            fMenuPrincipal c = (fMenuPrincipal)this.ParentForm;
            c.panelMenu.Visible = true;
            this.Close();
        }

        private void dataGridViewDocumentos_DoubleClick(object sender, EventArgs e)
        {
            CambiatNit();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            CambiatNit();
        }

        private void CambiatNit()
        {
            try
            {
                fDmdCambioNit cambionit = new fDmdCambioNit();
                cambionit.documentoDms = documento;
                cambionit.movimientosList = movimientoslist;
                cambionit.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Metal - Cambia de Nit", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public void RefrescarData()
        {
            documento = documentosController.Instance.GetByTipoNumero(documento.tipo, documento.numero);
            int m_Index = documentoslist.FindIndex(t => t.tipo == documento.tipo && t.numero == documento.numero);
            documentoslist[m_Index].nit = documento.nit;
            dataGridViewDocumentos.FirstDisplayedScrollingRowIndex = m_Index;
            dataGridViewDocumentos.Refresh();
        }

    }
}

