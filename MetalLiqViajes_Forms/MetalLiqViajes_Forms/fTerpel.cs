using ExcelDataReader;
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
        private ExcelTerpel excelTerpel { get; set; }
        private List<ExcelTerpel> excelterpelList { get; set; }

        private List<YearTerpel> YearsList { get; set; }
        private YearTerpel yearTerpel { get; set; }
        private List<MonthTerpel> monthTerpelList { get; set; }
        private MonthTerpel monthTerpel { get; set; }

        private DateTime FechaInicial { get; set; }
        private DateTime FechaFinal { get; set; }

        private List<VentasFlotaDetalle> ventasDetalleList { get; set; }
        private VentasFlotaDetalle ventasDetalle { get; set; }

        public fTerpel()
        {
            InitializeComponent();
        }

        private void fTerpel_Load(object sender, EventArgs e)
        {
            ListPlacas.Items.Clear();

            btnCargaExcel.Enabled = false;

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
            ExcelDataReader();
        }

        public void ExcelDataReader()
        {
            try
            {

                if (m_FileExcel == null) return;

                this.Cursor = Cursors.WaitCursor;

                //Reading from a OpenXml Excel file (2007 format; *.xlsx)
                FileStream stream = new FileStream(m_FileExcel.GetFullPath, FileMode.Open);
                IExcelDataReader excelReader2007 = ExcelReaderFactory.CreateOpenXmlReader(stream);

                //DataSet - The result of each spreadsheet will be created in the result.Tables
                DataSet result = excelReader2007.AsDataSet();

                excelterpelList = new List<ExcelTerpel>();
                string itemArray = "";
                //Data Reader methods
                foreach (DataTable dt in result.Tables)
                {
                    if (dt.TableName == "METAL LTDA")
                    {
                        if (dt.Rows.Count > 0)
                        {
                            for (int i = 0; i < dt.Rows.Count; i++)
                            {
                                itemArray = dt.Rows[i].ItemArray[0].ToString();
                                if (itemArray != "")
                                {
                                    if (itemArray != "No. Venta")
                                    {
                                        excelTerpel = ReadData(dt, i);
                                        excelterpelList.Add(excelTerpel);
                                    }
                                }
                            }
                        }
                    }
                }

                excelReader2007.Close();
                dataGridDataExcel.DataSource = excelterpelList;
                dataGridDataExcel.Refresh();
                btnGuadarExcel.Enabled = true;
                this.Cursor = Cursors.Default;
                MessageBox.Show("Proceso concluido con éxito, documentos encontrados " + excelterpelList.Count().ToString(), "Facturación Terpel", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                this.Cursor = Cursors.Default;
                MessageBox.Show("Error: se produjo un error en la carga de información, error: " + ex.Message, "Facturación Terpel", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private ExcelTerpel ReadData(DataTable dt, int i)
        {
            ExcelTerpel excelTerpel = new ExcelTerpel();
            try
            {
                if (dt.Rows[0].ItemArray[dt.Columns.IndexOf("Column0")] != null)

                    excelTerpel.Recibo = Convert.ToInt64(dt.Rows[i].ItemArray[0]);

                if (dt.Rows[0].ItemArray[dt.Columns.IndexOf("Column1")] != null)
                    try
                    {
                        excelTerpel.Fecha = Convert.ToDateTime(dt.Rows[i].ItemArray[1].ToString());
                    }
                    catch (Exception)
                    {
                        excelTerpel.Fecha = Convert.ToDateTime(DateTime.FromOADate(Convert.ToDouble(dt.Rows[i].ItemArray[1].ToString())));
                    }

                if (dt.Rows[0].ItemArray[dt.Columns.IndexOf("Column2")] != null)
                    excelTerpel.Hora = dt.Rows[i].ItemArray[2].ToString();

                if (dt.Rows[0].ItemArray[dt.Columns.IndexOf("Column3")] != null)
                    excelTerpel.NombreCliente = dt.Rows[i].ItemArray[3].ToString();

                if (dt.Rows[0].ItemArray[dt.Columns.IndexOf("Column4")] != null)
                    excelTerpel.Estacion = dt.Rows[i].ItemArray[4].ToString();

                if (dt.Rows[0].ItemArray[dt.Columns.IndexOf("Column5")] != null)
                    excelTerpel.TipoEstacion = dt.Rows[i].ItemArray[5].ToString();

                if (dt.Rows[0].ItemArray[dt.Columns.IndexOf("Column6")] != null)
                    excelTerpel.Destinatario = dt.Rows[i].ItemArray[6].ToString();

                if (dt.Rows[0].ItemArray[dt.Columns.IndexOf("Column7")] != null)
                    excelTerpel.Ciudad = dt.Rows[i].ItemArray[7].ToString();

                if (dt.Rows[0].ItemArray[dt.Columns.IndexOf("Column8")] != null)
                    excelTerpel.IdEDS = Convert.ToInt64(dt.Rows[i].ItemArray[8].ToString());

                if (dt.Rows[0].ItemArray[dt.Columns.IndexOf("Column9")] != null)
                    excelTerpel.Placa = dt.Rows[i].ItemArray[9].ToString();

                if (dt.Rows[0].ItemArray[dt.Columns.IndexOf("Column10")] != null)
                    excelTerpel.Producto = dt.Rows[i].ItemArray[10].ToString();

                if (dt.Rows[0].ItemArray[dt.Columns.IndexOf("Column11")] != null)
                    excelTerpel.Cantidad = Convert.ToDecimal(dt.Rows[i].ItemArray[11].ToString());

                if (dt.Rows[0].ItemArray[dt.Columns.IndexOf("Column12")] != null)
                    excelTerpel.Precio = Convert.ToDecimal(dt.Rows[i].ItemArray[12].ToString());

                if (dt.Rows[0].ItemArray[dt.Columns.IndexOf("Column13")] != null)
                    excelTerpel.TotalVentas = Convert.ToDecimal(dt.Rows[i].ItemArray[13].ToString());

                if (dt.Rows[0].ItemArray[dt.Columns.IndexOf("Column14")] != null)
                    excelTerpel.PrecioEspecial = Convert.ToDecimal(dt.Rows[i].ItemArray[14].ToString());

                if (dt.Rows[0].ItemArray[dt.Columns.IndexOf("Column15")] != null)
                    excelTerpel.TotalFactura = Convert.ToDecimal(dt.Rows[i].ItemArray[15].ToString());

                if (dt.Rows[0].ItemArray[dt.Columns.IndexOf("Column16")] != null)
                    excelTerpel.Descuento = Convert.ToDecimal(dt.Rows[i].ItemArray[16].ToString());

                if (dt.Rows[0].ItemArray[dt.Columns.IndexOf("Column17")] != null)
                    excelTerpel.UnidadVenta = dt.Rows[i].ItemArray[17].ToString();

                if (dt.Rows[0].ItemArray[dt.Columns.IndexOf("Column18")] != null)
                    excelTerpel.Kilometraje = Convert.ToDecimal(dt.Rows[i].ItemArray[18].ToString());

                if (dt.Rows[0].ItemArray[dt.Columns.IndexOf("Column19")] != null)
                    excelTerpel.TipoVenta = dt.Rows[i].ItemArray[19].ToString();

                if (dt.Rows[0].ItemArray[dt.Columns.IndexOf("Column20")] != null)
                    excelTerpel.Factura = dt.Rows[i].ItemArray[20].ToString();


            }
            catch (Exception ex)
            {
            }
            return excelTerpel;
        }

        public static DateTime FromExcelSerialDate(int SerialDate)
        {
            if (SerialDate > 59) SerialDate -= 1; //Excel/Lotus 2/29/1900 bug   
            return new DateTime(1899, 12, 31).AddDays(SerialDate);
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
                    btnGuadarExcel.Enabled = false;

                    m_FileExcel = new FileExcel();
                    excelterpelList = new List<ExcelTerpel>();
                    dataGridDataExcel.DataSource = excelterpelList;
                    dataGridDataExcel.Refresh();

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

                btnCargaExcel.Enabled = true;

                dataGridFiles.DataSource = m_FileExcelList;
                dataGridFiles.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Aviso: hay un error cargando el archivo, " + ex.Message, "Metal", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dataGridFiles_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            m_FileExcel = dataGridFiles.Rows[e.RowIndex].DataBoundItem as FileExcel;

        }

        private void btnGuadarExcel_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Confirma Actualizar los registros Importados de Terpel?", "Validar Crear Registro", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (resultado == DialogResult.Yes)
            {
                this.Cursor = Cursors.WaitCursor;

                VentasFlotaDetalle Ventas;
                int cantidad = 0;
                foreach (var ExcelItem in excelterpelList)
                {
                    Ventas = VentasFlotaDetalleController.Instance.Get(ExcelItem.Recibo);
                    if (Ventas == null)
                    {
                        Ventas = new VentasFlotaDetalle();
                        Ventas.Recibo = ExcelItem.Recibo;
                        Ventas.IdEDS = ExcelItem.IdEDS;
                        Ventas.Factura = ExcelItem.Factura;
                        Ventas.Fecha = ExcelItem.Fecha;
                        Ventas.Hora = ExcelItem.Hora;
                        Ventas.NombreCliente = ExcelItem.NombreCliente;
                        Ventas.Estacion = ExcelItem.Estacion;
                        Ventas.TipoEstacion = ExcelItem.TipoEstacion;
                        Ventas.Destinatario = ExcelItem.Destinatario;
                        Ventas.Ciudad = ExcelItem.Ciudad;
                        Ventas.Placa = ExcelItem.Placa;
                        Ventas.Producto = ExcelItem.Producto;
                        Ventas.Cantidad = ExcelItem.Cantidad;
                        Ventas.Precio = ExcelItem.Precio;
                        Ventas.TotalVentas = ExcelItem.TotalVentas;
                        Ventas.PrecioEspecial = ExcelItem.PrecioEspecial;
                        Ventas.TotalFactura = ExcelItem.TotalFactura;
                        Ventas.Descuento = ExcelItem.Descuento;
                        Ventas.Kilometraje = ExcelItem.Kilometraje;
                        Ventas.UnidadVenta = ExcelItem.UnidadVenta;
                        Ventas.TipoVenta = ExcelItem.TipoVenta;
                        VentasFlotaDetalleController.Instance.Create(Ventas);
                        cantidad++;
                    }
                }

                this.Cursor = Cursors.Default;
                btnGuadarExcel.Enabled = false;
                if (cantidad > 0)
                {
                    m_FileExcel.Importado = true;
                    dataGridFiles.Refresh();
                    MessageBox.Show("Proceso concluido con éxito, registros actualizados" + cantidad.ToString("n0"), "Facturación Terpel", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Aviso: los registro ya existen en la base de datos de Metal.", "Facturación Terpel", MessageBoxButtons.OK, MessageBoxIcon.Question);

                }
            }
        }

        private void btnGetDataVentas_Click(object sender, EventArgs e)
        {
            if (textBoxFactura.Text.Length > 0 && textBoxFactura.Text != "")
            {
                ventasDetalleList = VentasFlotaDetalleController.Instance.GetByFactura(textBoxFactura.Text);
                dataGridViewVentasDetalle.DataSource = ventasDetalleList;
                dataGridViewVentasDetalle.Refresh();

                textBoxTotalVentas.Text = ventasDetalleList.Sum(t => t.TotalFactura).Value.ToString("n0");
                textBoxTotalFactura.Text = ventasDetalleList.Sum(t => t.TotalVentas).Value.ToString("n0");
                textBoxCantidad.Text= ventasDetalleList.Count().ToString("n0");
            }

        }
    }
}
