using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.IO;
using System.Security.Cryptography;
using System.Dynamic;
using System.Net;
using MetalLiqViajes_Forms.com.terpel.movilidad;
using LiqViajes_Bll_Data;

namespace MetalLiqViajes_Forms
{
    public partial class fTerpel : Form
    {

        public List<UtilPlaca> ultilplacalist = new List<UtilPlaca>();

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

            //Usuario: Flotas
            //Contraseña: Flotas2013 %
            //Código Cliente: 0010240247


            //TripleDes crypt = new TripleDes();
            //strCadenaCifrada = crypt.SimpleTripleDes
            //(“{ "PCC":"ABC123","IP":1,"PDV":1,"KV":1,"IB":"D2000000E0A16402"}”);
            //{"Codigo":"0010101010","Placas":"FPOP1,LFV112","FechaInicio":"20080805 12:00", "FechaFin":"20120805 17:00"}
            //string jsonString = people.ToJSON();

            string codigocliente = "0010240247";
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

            //FechaInicial.Value = FechaInicial.Value.Hour(23);



            listaPlacas = listaPlacas.Replace("-", "");
            Util.Terpel terpel = new Util.Terpel();
            terpel.Codigo = Properties.Settings.Default.ClienteTerpel.ToString();
            terpel.Placas = listaPlacas;
            terpel.FechaInicial = FechaInicial.Value.ToString("yyyyMMdd 12:00");
            terpel.FechaFinal = FechaFinal.Value.ToString("yyyyMMdd 23:59");

            dynamic ObjTerpel = new ExpandoObject();


            ObjTerpel.Codigo = terpel.Codigo;
            ObjTerpel.Placas = terpel.Placas;
            ObjTerpel.FechaInicio = terpel.FechaInicial;
            ObjTerpel.FechaFin = terpel.FechaFinal;

            string json = JsonConvert.SerializeObject(ObjTerpel);
            var resultado = TripleDes(json);


            com.terpel.movilidad.Integrator integr = new com.terpel.movilidad.Integrator();
            integr.Credentials = new NetworkCredential("Flotas", "Flotas2013%");
            //CosultaEDSFlota[] consultaEDS = integr.ConsultaEDS(codigocliente);
            var resultado2 = integr.ConsultaVentas(resultado);
            VentasFlotaResponse ventaTerpel = null;
            VentasFlota ventaMetal = null;
            foreach (var item in resultado2)
            {
                ventaTerpel = item;
                ventaMetal = new VentasFlota();
                ventaMetal.CodEds = ventaTerpel.CodEds;
                ventaMetal.Dinero = ventaTerpel.Dinero;
                ventaMetal.Fecha = ventaMetal.Fecha;
                ventaMetal.Kilometraje = ventaTerpel.Kilometraje;
                ventaMetal.Placa = ventaTerpel.Placa;
                ventaMetal.Producto = ventaTerpel.Producto;
                ventaMetal.Recibo = ventaTerpel.Recibo;
                ventaMetal.Volumen = ventaTerpel.Volumen;
                ventaMetal.Codigo= VentasFlotaController.Instance.Create(ventaMetal).Codigo;
            }
            MessageBox.Show("proceso terminado", "Compras Terpen", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

    }
}
