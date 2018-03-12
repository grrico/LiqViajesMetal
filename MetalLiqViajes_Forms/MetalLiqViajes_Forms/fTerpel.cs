using LinqToExcel;
using LiqViajes_Bll_Data;
using MetalLiqViajes_Forms.com.terpel.movilidad;
using MetalLiqViajes_Forms.Util;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Dynamic;
using System.IO;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using static MetalLiqViajes_Forms.Util.Parametros;

namespace MetalLiqViajes_Forms
{
    public partial class fTerpel : Form
    {

        public List<UtilPlaca> ultilplacalist { get; set; }

        private FileExcel m_FileExcel { get; set; }

        private List<YearTerpel> YearsList { get; set; }
        private YearTerpel yearTerpel { get; set; }
        private List<MonthTerpel> monthTerpelList { get; set; }
        private MonthTerpel monthTerpel { get; set; }

        private DateTime FechaInicial { get; set; }
        private DateTime FechaFinal { get; set; }

        public fTerpel()
        {
            InitializeComponent();
        }

        private void fTerpel_Load(object sender, EventArgs e)
        {
            ListPlacas.Items.Clear();
            foreach (var item in ultilplacalist)
            {
                if (item.Placa != "_Seleccionar")
                    ListPlacas.Items.Add(item.Placa);
            }

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





        }

        private void checkBoxMarcar_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxMarcar.Checked)
                for (int i = 0; i < ListPlacas.Items.Count; i++)
                    ListPlacas.SetItemChecked(i, true);
            else
                for (int i = 0; i < ListPlacas.Items.Count; i++)
                    ListPlacas.SetItemChecked(i, false);
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;

            try
            {
                string listaPlacas = "";
                string delimitador = ",";
                int contador = 0;
                foreach (var item in ListPlacas.CheckedItems)
                {
                    listaPlacas += item.ToString();
                    contador++;
                    if (ListPlacas.CheckedItems.Count > contador)
                    {
                        listaPlacas += delimitador;
                    }
                }

                CargaFecha();


                listaPlacas = listaPlacas.Replace("-", "");
                Util.Terpel terpel = new Util.Terpel();
                terpel.Codigo = ParametrosGeneralesController.Instance.Get(5).ValorParametro; // codigo cliente terpel
                terpel.Placas = listaPlacas;
                terpel.FechaInicial = FechaInicial.ToString("yyyyMMdd 12:00");
                terpel.FechaFinal = FechaFinal.ToString("yyyyMMdd 23:59");

                dynamic ObjTerpel = new ExpandoObject();

                ObjTerpel.Codigo = terpel.Codigo;
                ObjTerpel.Placas = terpel.Placas;
                ObjTerpel.FechaInicio = terpel.FechaInicial;
                ObjTerpel.FechaFin = terpel.FechaFinal;

                string json = JsonConvert.SerializeObject(ObjTerpel);
                var resultado = TripleDes(json);

                com.terpel.movilidad.Integrator integr = new com.terpel.movilidad.Integrator();
                integr.Credentials = new NetworkCredential(ParametrosGeneralesController.Instance.Get(3).ValorParametro, ParametrosGeneralesController.Instance.Get(4).ValorParametro);

                var resultado2 = integr.ConsultaVentas(resultado);
                List<VentasFlotaResponse> ventaTerpelList = new List<VentasFlotaResponse>();

                List<VentasFlota> ventasFlotaList = new List<VentasFlota>();
                ventasFlotaList = VentasFlotaController.Instance.GetAll();

                //var distinctregistro = resultado2.AsEnumerable()
                //.Select(row => new
                //{
                //    CodEds = row.CodEds,
                //    Recibo = row.Recibo,
                //    Fecha = row.Fecha,
                //})
                //.Distinct();

                //  guarda el registro detalle
                int cantidad = 0;
                VentasFlota ventasflota = null;
                int cantid2 = resultado2.Count();
                foreach (VentasFlotaResponse itemRegiD in resultado2)
                {
                    ventasflota = VentasFlotaController.Instance.Get(Convert.ToInt64(itemRegiD.Recibo));
                    if (ventasflota == null && itemRegiD.CodEds > 0)
                    {
                        ventasflota = new VentasFlota();
                        ventasflota.CodEds = itemRegiD.CodEds;
                        ventasflota.Dinero = itemRegiD.Dinero;
                        ventasflota.Fecha = itemRegiD.Fecha;
                        ventasflota.Kilometraje = itemRegiD.Kilometraje;
                        ventasflota.Placa = itemRegiD.Placa;
                        ventasflota.Producto = itemRegiD.Producto;
                        ventasflota.Recibo = itemRegiD.Recibo;
                        ventasflota.Volumen = itemRegiD.Volumen;
                        VentasFlotaController.Instance.Create(ventasflota);
                        cantidad++;
                    }
                }

                MessageBox.Show("proceso terminado, Cantidad: " + cantidad.ToString("#####"), "Compras Terpen", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
            }

            this.Cursor = Cursors.Default;

        }

        public string TripleDes(string Data)
        {
            //Llave
            byte[] key = Encoding.ASCII.GetBytes("1m032jodfetLahlLPEFVER4I");

            //Vector inicialización
            byte[] iv = Encoding.ASCII.GetBytes("63468123");

            byte[] data = Encoding.ASCII.GetBytes(Data);
            byte[] enc = new byte[0];
            TripleDES tdes = TripleDES.Create();
            tdes.IV = iv;
            tdes.Key = key;
            tdes.Mode = CipherMode.CBC;
            tdes.Padding = PaddingMode.Zeros;
            ICryptoTransform ict = tdes.CreateEncryptor();
            enc = ict.TransformFinalBlock(data, 0, data.Length);
            return ByteArrayToString(enc);
        }

        public string SimpleTripleDesDecrypt(string Data)
        {
            byte[] key = Encoding.ASCII.GetBytes("1m032jodfetLahlLPEFVER4I");
            byte[] iv = Encoding.ASCII.GetBytes("63468123");
            byte[] data = StringToByteArray(Data);
            byte[] enc = new byte[0];
            TripleDES tdes = TripleDES.Create();
            tdes.IV = iv;
            tdes.Key = key;
            tdes.Mode = CipherMode.CBC;
            tdes.Padding = PaddingMode.Zeros;
            ICryptoTransform ict = tdes.CreateDecryptor();
            enc = ict.TransformFinalBlock(data, 0, data.Length);
            return Encoding.ASCII.GetString(enc);
        }

        public static string ByteArrayToString(byte[] ba)
        {
            string hex = BitConverter.ToString(ba);
            return hex.Replace("-", "");
        }

        public static byte[] StringToByteArray(String hex)
        {
            int NumberChars = hex.Length;
            byte[] bytes = new byte[NumberChars / 2];
            for (int i = 0; i < NumberChars; i += 2)
                bytes[i / 2] = Convert.ToByte(hex.Substring(i, 2), 16);
            return bytes;
        }

        public byte[] StringToBytes(String cadena)
        {
            System.Text.ASCIIEncoding codificador = new System.Text.ASCIIEncoding();
            return codificador.GetBytes(cadena);
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
                FechaInicial = Convert.ToDateTime(ifecha);
                FechaFinal = Convert.ToDateTime(ffecha).AddDays(-1);
            }
        }

        private void btnCargaExcel_Click(object sender, EventArgs e)
        {
            ToEntidadHojaExcelListTest();

        }
        public void ToEntidadHojaExcelListTest()
        {
            if (@m_FileExcel == null) return;
            this.Cursor = Cursors.WaitCursor;

            string pathToExcelFile = @m_FileExcel.GetFullPath;//  @"D:\Genaro\Metal\Terpel\FEBRERO\201802  Corte 01 - 08 Metal ltda.xlsx";

            string sheetName = "METAL LTDA";

            var excelFile = new ExcelQueryFactory(pathToExcelFile);
            var artistAlbums = from a in excelFile.Worksheet(sheetName) select a;
            bool swtEncabezado = false;
            ExcelTerpel excelTerpel = null;
            List<ExcelTerpel> excelTerpelList = new List<ExcelTerpel>();

            try
            {
                foreach (var a in artistAlbums)
                {
                    try
                    {
                        if (a[0] == "No. Venta")
                        {
                            swtEncabezado = true;
                            continue;
                        }

                        if (swtEncabezado && (a[8] == null || a[8] == ""))
                        {
                            break;
                        }
                        if (Convert.ToInt32(a[8].ToString()) > 0)
                        {
                            excelTerpel = new ExcelTerpel();
                            excelTerpel.Recibo = Convert.ToInt64(a[0].Value);
                            excelTerpel.Fecha = Convert.ToDateTime(a[1].Value);
                            excelTerpel.Hora = a[2];
                            excelTerpel.NombreCliente = a[3];
                            excelTerpel.Estacion = a[4];
                            excelTerpel.TipoEstacion = a[5];
                            excelTerpel.Destinatario = a[6];
                            excelTerpel.Ciudad = a[7];
                            excelTerpel.IdEDS = Convert.ToInt64(a[8].Value);
                            excelTerpel.Placa = a[9];
                            excelTerpel.Producto = a[10];
                            excelTerpel.cantidad = Convert.ToDecimal(a[11].Value);
                            excelTerpel.Precio = Convert.ToDecimal(a[12].Value);
                            excelTerpel.TotalVentas = Convert.ToDecimal(a[13].Value);
                            excelTerpel.PrecioEspecial = Convert.ToDecimal(a[14].Value);
                            excelTerpel.TotalFactura = Convert.ToDecimal(a[15].Value);
                            excelTerpel.Descuento = Convert.ToDecimal(a[16].Value);
                            excelTerpel.UnidadVenta = a[17].Value.ToString();
                            excelTerpel.Kilometraje = Convert.ToDecimal(a[18].Value);
                            excelTerpel.TipoVenta = a[19];
                            excelTerpel.Factura = a[20];
                            excelTerpelList.Add(excelTerpel);
                            continue;
                        }
                    }
                    catch
                    {
                    }
                }
                dataGridDataExcel.DataSource = excelTerpelList;
                dataGridDataExcel.Refresh();

                this.Cursor = Cursors.Default;
                MessageBox.Show("Proceso concluido con éxito, documentos encontrados " + excelTerpelList.Count().ToString(), "Facturación Terpel", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                this.Cursor = Cursors.Default;
                MessageBox.Show("Error cargando la información del registro "  + m_FileExcel.nameFile, "Facturación Terpel, Registro Error", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void btnCargaDirectorio_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBoxPath.Text != "")
                {
                    Properties.Settings.Default.PathFacturaTerpel = textBoxPath.Text;
                    dlgOpenDir.SelectedPath = textBoxPath.Text;
                }
                DialogResult resDialog = new System.Windows.Forms.DialogResult();
                dlgOpenDir.SelectedPath = Properties.Settings.Default.PathFacturaTerpel;
                resDialog = dlgOpenDir.ShowDialog();
                if (resDialog.ToString() == "OK")
                {
                    textBoxPath.Text = dlgOpenDir.SelectedPath;
                    textBoxPath.Refresh();
                    Properties.Settings.Default.PathFacturaTerpel = dlgOpenDir.SelectedPath + "\\";
                    CargaArchivos(dlgOpenDir.SelectedPath);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Aviso: hay un error buscando el directorio origen, " + ex.Message, "Metal", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void CargaArchivos(string @iPath)
        {
            try
            {
                List<FileExcel> m_FileExcelList = new List<FileExcel>();
                string Extension = "";
                string[] DirPathfiles = Directory.GetFiles(@iPath);
                foreach (string file in DirPathfiles)
                {
                    Extension = Path.GetExtension(file);
                    if (Extension != ".xls" || Extension != ".xlsx" || Extension != ".csv")
                    {
                        m_FileExcel = new FileExcel();
                        m_FileExcel.nameFile = Path.GetFileName(file);
                        m_FileExcel.GetFullPath = Path.GetFullPath(file);
                        m_FileExcel.Importado = false;
                        m_FileExcel.Excluir = false;
                        m_FileExcel.Notaexcluir = "";
                        m_FileExcelList.Add(m_FileExcel);
                    }
                }

                dataGridFiles.DataSource = m_FileExcelList;
                dataGridFiles.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Aviso: hay un error cargando el archivo, " + ex.Message, "Metal", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private static void LeerExcel()
        {
            OpenFileDialog of = new OpenFileDialog();
            string directoryPath = Path.GetDirectoryName("c:\\Metal\\Terpel\\");
            of.InitialDirectory = directoryPath;
            of.Filter = "Excel Files(.xls)|*.xls|Excel Files(.xlsx)|*.xlsx|Excel Files(.csv)|*.csv|Excel Files(.xlsm)|*.xlsm|Files Open(.ods)|*.ods|Excel Files(.sxc)|*.sxc|Texto (*.txt)|*.txt";
            if (of.ShowDialog() == DialogResult.OK)
            {
                StreamReader objReader = new StreamReader(@of.FileName);
                string sLine = "";
                string cedula = "";
                int _Procesos = 0;
                while (sLine != null)
                {
                    sLine = objReader.ReadLine();
                    if ((sLine != null) && (sLine != ";;;"))
                    {
                        cedula = sLine.Split(',')[0];
                        if ((cedula == "Cédula") || (cedula == "") || (cedula == "cedula"))
                            continue;

                        //foreach (Sistecredito.Procesos.Proceso proceso in m_ProcesoGridList.Where(t => t.Referencia2 == cedula))
                        //{
                        //    proceso.Seleccionada = true;
                        //    _Procesos++;
                        //}
                    }
                }
                MessageBox.Show("Proceso concluido con éxito, documentos encontrados " + _Procesos.ToString(), "Facturación Terpel", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dataGridFiles_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            m_FileExcel = dataGridFiles.Rows[e.RowIndex].DataBoundItem as FileExcel;
        }
    }
}

