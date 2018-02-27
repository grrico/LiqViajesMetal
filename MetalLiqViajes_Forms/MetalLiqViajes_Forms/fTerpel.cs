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

using System.Security.Cryptography;


namespace MetalLiqViajes_Forms
{


    public partial class fTerpel : Form
    {
        public fTerpel()
        {
            InitializeComponent();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            //TripleDes crypt = new TripleDes();
            //strCadenaCifrada = crypt.SimpleTripleDes
            //(“{ "PCC":"ABC123","IP":1,"PDV":1,"KV":1,"IB":"D2000000E0A16402"}”);

        }

        public string SimpleTripleDes(string Data)
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
