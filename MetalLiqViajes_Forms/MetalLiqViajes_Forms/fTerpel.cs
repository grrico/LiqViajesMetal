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

        private List<movimientos> movimientoslist { get; set; }

        private List<documentos> documentosList { get; set; }

        public fTerpel()
        {
            InitializeComponent();
        }

        private void fTerpel_Load(object sender, EventArgs e)
        {
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
                    excelTerpel.Precio = Convert.ToDouble(dt.Rows[i].ItemArray[12].ToString());

                if (dt.Rows[0].ItemArray[dt.Columns.IndexOf("Column13")] != null)
                    excelTerpel.TotalVentas = Convert.ToDouble(dt.Rows[i].ItemArray[13].ToString());

                if (dt.Rows[0].ItemArray[dt.Columns.IndexOf("Column14")] != null)
                    excelTerpel.PrecioEspecial = Convert.ToDouble(dt.Rows[i].ItemArray[14].ToString());

                if (dt.Rows[0].ItemArray[dt.Columns.IndexOf("Column15")] != null)
                    excelTerpel.TotalFactura = Convert.ToDouble(dt.Rows[i].ItemArray[15].ToString());

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
                textBoxCantidad.Text = ventasDetalleList.Count().ToString("n0");

                if (ventasDetalleList.Count() == 0) return;

                //movimientos movimiento
                var distinctmoviento = ventasDetalleList.AsEnumerable()
               .Select(row => new
               {
                   Factura = row.Factura,
                   Tipo = row.Tipo,
                   Placa = row.Placa,
                   Nit = row.Nit,
                   Seq = 0,
                   Cuenta = row.Cuenta,
                   Fecha = row.Fecha,
                   TotalVentas = ventasDetalleList.Where(t => t.Factura == row.Factura && t.Placa == row.Placa && t.Nit == row.Nit && t.Fecha == row.Fecha).Sum(v => v.TotalVentas).Value,
                   TotalFactura = ventasDetalleList.Where(t => t.Factura == row.Factura && t.Placa == row.Placa && t.Nit == row.Nit && t.Fecha == row.Fecha).Sum(v => v.TotalFactura).Value,
               })
               .Distinct();
                int cantidad = distinctmoviento.Count();
                double TotalVentas = distinctmoviento.Sum(s => s.TotalVentas);
                double TotalFactura = distinctmoviento.Sum(s => s.TotalFactura);

                string tipo = "83";
                int numero = 11088;
                int numerodms = 11118;//

                if (textBoxFactura.Text != "9018016645")
                    numerodms = consecutivosController.Instance.Get("83").siguiente.Value;

                documentos documento = documentosController.Instance.GetByTipoNumero(tipo, numero);

                documentosList = new List<documentos>();

                string nota = "FACT. @@@@@@@ COMPRA ACPM DEL @DDI AL @DDF";

                DateTime fechai = ventasDetalleList.FirstOrDefault().Fecha.Value;
                DateTime fechaf = ventasDetalleList.LastOrDefault().Fecha.Value;

                nota = CrearDocumento83(documento, nota, fechai, fechaf, numerodms);

                documentosList.Add(documento);

                decimal valor = documento.valor_total.Value * -1;
                decimal valorniiff = documento.valor_total.Value * -1;
                string cuenta = "23359501";
                int seq = 1;

                decimal nit = 830095213;


                DateTime fecha = Convert.ToDateTime(fechai.ToShortDateString());
                tipo = "83";
                movimientoslist = new List<movimientos>();
                movimientos movimiento = CrearMovimiento(documento, nota, valor, cuenta, seq, nit, numerodms, valorniiff, fecha, tipo);
                movimientoslist.Add(movimiento);

                foreach (var item in distinctmoviento)
                {
                    #region crea detalle movimento
                    valor = Convert.ToInt64(item.TotalFactura);
                    valorniiff = Convert.ToInt64(item.TotalFactura);
                    cuenta = "13301504";
                    seq++;
                    nit = item.Nit.Value;
                    fecha = Convert.ToDateTime(item.Fecha.Value.ToShortDateString());
                    tipo = "83";
                    movimiento = CrearMovimiento(documento, nota, valor, cuenta, seq, nit, numerodms, valorniiff, fecha, tipo);
                    movimientoslist.Add(movimiento);
                    #endregion
                }

                textBoxMovCuenta1.Text = movimientoslist.Where(t => t.cuenta == "23359501").Sum(s => s.valor).ToString("n2");
                textBoxMovCuenta2.Text = movimientoslist.Where(t => t.cuenta == "13301504").Sum(s => s.valor).ToString("n2");

                //  por cada nit para 52V, se debe crear un documento, se debe crear 3 movimientos.
                //  16430

                tipo = "52V";
                numero = 11088;
                documentos documento52V = documentosController.Instance.GetByTipoNumero(tipo, numero);
                numero = 0;

                numerodms = consecutivosController.Instance.Get("52V").siguiente.Value;
                numerodms--;
                foreach (var item in ventasDetalleList)
                {

                    nota = "RECIBO @@@@@@@ COMPRA ACPM FECHA @DDF";
                    fechai = Convert.ToDateTime(item.Fecha.Value.ToShortDateString());

                    documento = ClonarDocumento(documento52V);// clona el documento

                    numerodms++; //= consecutivosController.Instance.Get("83").siguiente.Value;

                    documento.id = 0;
                    documento.nit = item.Nit.Value;
                    documento.numero = Convert.ToInt32(numerodms);
                    documento.fecha = Convert.ToDateTime(fechai.ToShortDateString());
                    documento.vencimiento = dateTimePickerDocumento.Value;
                    documento.valor_total = Convert.ToInt64(item.TotalFactura.Value);
                    documento.valor_aplicado = 0;
                    documento.documento = item.Recibo.ToString();
                    nota = nota.Replace("@@@@@@@", item.Recibo.ToString());
                    nota = nota.Replace("@DDF", fechai.ToString("dd/MMM/yyyy"));
                    documento.notas = nota;
                    documento.fecha_hora = dateTimePickerDocumento.Value;
                    documento.valor_mercancia = Convert.ToInt64(item.TotalFactura.Value);

                    documentosList.Add(documento);

                    // por cada 52V se debe crear 3 movientos

                    //13301503
                    //13301504
                    //17057004

                    #region crea detalle movimento 

                    //  seq = 1

                    valor = Convert.ToInt64(item.TotalFactura.Value);
                    valorniiff = Convert.ToInt64(0);
                    cuenta = "13301503";
                    seq = 1;
                    nit = item.Nit.Value;
                    movimiento = CrearMovimiento(documento, nota, valor, cuenta, seq, nit, numerodms, valorniiff, fechai, tipo);
                    movimientoslist.Add(movimiento);

                    //  seq = 2

                    valor = Convert.ToInt64(item.TotalFactura.Value) * -1;
                    valorniiff = Convert.ToInt64(item.TotalFactura.Value) * -1;
                    cuenta = "13301504";
                    seq = 2;
                    nit = item.Nit.Value;
                    movimiento = CrearMovimiento(documento, nota, valor, cuenta, seq, nit, numerodms, valorniiff, fechai, tipo);
                    movimientoslist.Add(movimiento);

                    //  seq = 3

                    valor = Convert.ToInt64(0);
                    valorniiff = Convert.ToInt64(item.TotalFactura.Value);
                    cuenta = "17057004";
                    seq = 3;
                    nit = item.Nit.Value;
                    movimiento = CrearMovimiento(documento, nota, valor, cuenta, seq, nit, numerodms, valorniiff, fechai, tipo);
                    movimientoslist.Add(movimiento);


                    #endregion


                }

                dataGridViewDocumento.DataSource = documentosList.ToList();
                dataGridViewDocumento.Refresh();

                dataGridViewMovimiento83.DataSource = movimientoslist;
                dataGridViewMovimiento83.Refresh();

            }

        }

        private string CrearDocumento83(documentos documento, string nota, DateTime fechai, DateTime fechaf, int numero)
        {
            documento.numero = numero;
            documento.fecha = Convert.ToDateTime(fechai.ToShortDateString());
            documento.vencimiento = dateTimePickerDocumento.Value;
            documento.valor_total = Convert.ToInt64(ventasDetalleList.Sum(v => v.TotalFactura).Value);
            documento.valor_aplicado = 0;
            documento.documento = ventasDetalleList.FirstOrDefault().Factura;
            nota = nota.Replace("@@@@@@@", documento.documento);
            nota = nota.Replace("@DDI", fechai.Day.ToString("##"));
            nota = nota.Replace("@DDF", fechaf.ToString("dd/MMM/yyyy"));
            documento.notas = nota;
            documento.fecha_hora = dateTimePickerDocumento.Value;
            documento.valor_mercancia = documento.valor_total;
            return nota;
        }

        private static documentos ClonarDocumento(documentos documento52V)
        {
            return new documentos
            {
                tipo = documento52V.tipo,
                numero = documento52V.numero,
                sw = documento52V.sw,
                nit = documento52V.nit,
                fecha = documento52V.fecha,
                condicion = documento52V.condicion,
                vencimiento = documento52V.vencimiento,
                valor_total = documento52V.valor_total,
                iva = documento52V.iva,
                retencion = documento52V.retencion,
                retencion_causada = documento52V.retencion_causada,
                retencion_iva = documento52V.retencion_iva,
                retencion_ica = documento52V.retencion_ica,
                descuento_pie = documento52V.descuento_pie,
                fletes = documento52V.fletes,
                iva_fletes = documento52V.iva_fletes,
                costo = documento52V.costo,
                vendedor = documento52V.vendedor,
                valor_aplicado = documento52V.valor_aplicado,
                anulado = documento52V.anulado,
                modelo = documento52V.modelo,
                documento = documento52V.documento,
                notas = documento52V.notas,
                usuario = documento52V.usuario,
                pc = documento52V.pc,
                fecha_hora = documento52V.fecha_hora,
                retencion2 = documento52V.retencion2,
                retencion3 = documento52V.retencion3,
                bodega = documento52V.bodega,
                impoconsumo = documento52V.impoconsumo,
                descuento2 = documento52V.descuento2,
                duracion = documento52V.duracion,
                concepto = documento52V.concepto,
                vencimiento_presup = documento52V.vencimiento_presup,
                exportado = documento52V.exportado,
                impuesto_deporte = documento52V.impuesto_deporte,
                prefijo = documento52V.prefijo,
                moneda = documento52V.moneda,
                tasa = documento52V.tasa,
                centro_doc = documento52V.centro_doc,
                valor_mercancia = documento52V.valor_mercancia,
                numero_cuotas = documento52V.numero_cuotas,
                codigo_direccion = documento52V.codigo_direccion,
                descuento_1 = documento52V.descuento_1,
                descuento_2 = documento52V.descuento_2,
                descuento_3 = documento52V.descuento_3,
                abono = documento52V.abono,
                fecha_consignacion = documento52V.fecha_consignacion,
                Iva_Costo = documento52V.Iva_Costo,
                concepto_Retencion = documento52V.concepto_Retencion,
                porc_RteFuente = documento52V.porc_RteFuente,
                porc_RteIva = documento52V.porc_RteIva,
                porc_RteIvaSimpl = documento52V.porc_RteIvaSimpl,
                porc_RteIca = documento52V.porc_RteIca,
                porc_RteA = documento52V.porc_RteA,
                porc_RteB = documento52V.porc_RteB,
                bodega_ot = documento52V.bodega_ot,
                numero_ot = documento52V.numero_ot,
                provision = documento52V.provision,
                ajuste = documento52V.ajuste,
                porc_RteCree = documento52V.porc_RteCree,
                retencion_cree = documento52V.retencion_cree,
                codigo_retencion_cree = documento52V.codigo_retencion_cree,
                cree_causado = documento52V.cree_causado,
                ObligacionFinanciera = documento52V.ObligacionFinanciera,
                Base_dcto_RC = documento52V.Base_dcto_RC,
                numincapacidad = documento52V.numincapacidad,
                idincapacidad = documento52V.idincapacidad,

            };
        }

        private static movimientos CrearMovimiento(documentos documento, string nota, decimal valor, string cuenta, int seq, decimal nit, int numerodms, decimal valorniif, DateTime fecha, string tipo)
        {
            movimientos movimiento = new movimientos();
            movimiento.tipo = tipo;
            movimiento.numero = numerodms;
            movimiento.seq = seq;
            movimiento.cuenta = cuenta;
            movimiento.centro = 0;
            movimiento.nit = nit;
            movimiento.fec = fecha;
            movimiento.valor = valor;
            //movimiento.base    NULL
            //movimiento.documento   NULL
            movimiento.explicacion = nota;
            //movimiento.concilio NULL;
            //movimiento.concepto_mov NULL;
            //movimiento.concilio_ano NULL
            //movimiento.secuencia_extracto NULL
            //movimiento.ano_concilia NULL
            //movimiento.mes_concilia NULL
            //movimiento.ID_CRUCE NULL
            //movimiento.TIPO_CRUCE NULL
            movimiento.valor_niif = valorniif;
            return movimiento;
        }

        private void btnSaveDocumento_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            try
            {
                DialogResult resultado = MessageBox.Show("Confirma crear movimientos DMS por Facturación a Terpel?", "Validar Crear Registro", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (resultado == DialogResult.Yes)
                {
                    int numerodms = 0;
                    int consecutivo83 = 0;
                    movimientos movimiento = null;
                    List<movimientos> movimientoList = null;
                    foreach (var item in documentosList)
                    {
                        movimientoList = movimientoslist.Where(t => t.numero == item.numero).ToList();
                        documentosController.Instance.Create(item);
                        if (item.tipo=="83")
                        {
                            consecutivo83 = item.numero;
                        }
                        numerodms = item.numero;
                        foreach (var itemmov in movimientoList)
                        {
                            movimiento = itemmov;
                            movimientosController.Instance.Create(movimiento);
                        }

                    }

                    numerodms++;
                    consecutivos consecutivo52V = consecutivosController.Instance.Get("52V");
                    consecutivo52V.siguiente = numerodms;
                    consecutivosController.Instance.Update(consecutivo52V);

                    consecutivo83++;
                    consecutivos consecutivo83V = consecutivosController.Instance.Get("83");
                    consecutivo83V.siguiente = consecutivo83;
                    consecutivosController.Instance.Update(consecutivo83V);

                }

            }
            catch (Exception ex)
            {
            }
            this.Cursor = Cursors.Default;
        }

        private void dataGridViewDocumento_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            documentos documento = dataGridViewDocumento.Rows[e.RowIndex].DataBoundItem as documentos;
            List<movimientos> movimientoList = movimientoslist.Where(t => t.numero == documento.numero).ToList();
            dataGridViewMovimiento52V.DataSource = movimientoList;
            dataGridViewMovimiento52V.Refresh();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            fMenuPrincipal c = (fMenuPrincipal)this.ParentForm;
            c.panelMenu.Visible = true;
            this.Close();
        }

        //private void btnConsultar_Click(object sender, EventArgs e)
        //{
        //    this.Cursor = Cursors.WaitCursor;

        //    try
        //    {
        //        string listaPlacas = "";
        //        string delimitador = ",";
        //        int contador = 0;
        //        foreach (var item in ListPlacas.CheckedItems)
        //        {
        //            listaPlacas += item.ToString();
        //            contador++;
        //            if (ListPlacas.CheckedItems.Count > contador)
        //            {
        //                listaPlacas += delimitador;
        //            }
        //        }

        //        CargaFecha();


        //        listaPlacas = listaPlacas.Replace("-", "");
        //        Util.Terpel terpel = new Util.Terpel();
        //        terpel.Codigo = ParametrosGeneralesController.Instance.Get(5).ValorParametro; // codigo cliente terpel
        //        terpel.Placas = listaPlacas;
        //        terpel.FechaInicial = FechaInicial.ToString("yyyyMMdd 12:00");
        //        terpel.FechaFinal = FechaFinal.ToString("yyyyMMdd 23:59");

        //        dynamic ObjTerpel = new ExpandoObject();

        //        ObjTerpel.Codigo = terpel.Codigo;
        //        ObjTerpel.Placas = terpel.Placas;
        //        ObjTerpel.FechaInicio = terpel.FechaInicial;
        //        ObjTerpel.FechaFin = terpel.FechaFinal;

        //        string json = JsonConvert.SerializeObject(ObjTerpel);
        //        var resultado = TripleDes(json);

        //        com.terpel.movilidad.Integrator integr = new com.terpel.movilidad.Integrator();
        //        integr.Credentials = new NetworkCredential(ParametrosGeneralesController.Instance.Get(3).ValorParametro, ParametrosGeneralesController.Instance.Get(4).ValorParametro);

        //        var resultado2 = integr.ConsultaVentas(resultado);
        //        List<VentasFlotaResponse> ventaTerpelList = new List<VentasFlotaResponse>();

        //        List<VentasFlota> ventasFlotaList = new List<VentasFlota>();
        //        ventasFlotaList = VentasFlotaController.Instance.GetAll();

        //        //var distinctregistro = resultado2.AsEnumerable()
        //        //.Select(row => new
        //        //{
        //        //    CodEds = row.CodEds,
        //        //    Recibo = row.Recibo,
        //        //    Fecha = row.Fecha,
        //        //})
        //        //.Distinct();

        //        //  guarda el registro detalle
        //        int cantidad = 0;
        //        VentasFlota ventasflota = null;
        //        int cantid2 = resultado2.Count();
        //        foreach (VentasFlotaResponse itemRegiD in resultado2)
        //        {
        //            ventasflota = VentasFlotaController.Instance.Get(Convert.ToInt64(itemRegiD.Recibo));
        //            if (ventasflota == null && itemRegiD.CodEds > 0)
        //            {
        //                ventasflota = new VentasFlota();
        //                ventasflota.CodEds = itemRegiD.CodEds;
        //                ventasflota.Dinero = itemRegiD.Dinero;
        //                ventasflota.Fecha = itemRegiD.Fecha;
        //                ventasflota.Kilometraje = itemRegiD.Kilometraje;
        //                ventasflota.Placa = itemRegiD.Placa;
        //                ventasflota.Producto = itemRegiD.Producto;
        //                ventasflota.Recibo = itemRegiD.Recibo;
        //                ventasflota.Volumen = itemRegiD.Volumen;
        //                VentasFlotaController.Instance.Create(ventasflota);
        //                cantidad++;
        //            }
        //        }

        //        MessageBox.Show("proceso terminado, Cantidad: " + cantidad.ToString("#####"), "Compras Terpen", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //    }
        //    catch (Exception ex)
        //    {
        //    }

        //    this.Cursor = Cursors.Default;

        //}

        //private void CargaFecha()
        //{

        //    yearTerpel = comboBoxYear.SelectedItem as YearTerpel;
        //    monthTerpel = comboBoxMonth.SelectedItem as MonthTerpel;
        //    if (monthTerpel != null)
        //    {
        //        int imes = monthTerpel.CodMonth;
        //        if (imes >= 12)
        //            imes = 1;
        //        imes++;
        //        string ifecha = yearTerpel.CodYear.ToString() + "/" + monthTerpel.CodMonth.ToString("##") + "/01";
        //        string ffecha = yearTerpel.CodYear.ToString() + "/" + imes.ToString("##") + "/01";
        //        FechaInicial = Convert.ToDateTime(ifecha);
        //        FechaFinal = Convert.ToDateTime(ffecha).AddDays(-1);
        //    }
        //}

    }
}
