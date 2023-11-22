using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Imaging;

namespace QRCode_Gen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public Bitmap GerarQRCode(int width, int height, string text)
        {
            try
            {
                var bw = new ZXing.BarcodeWriter();
                var encOptions = new ZXing.Common.EncodingOptions() { Width = width, Height = height, Margin = 0 };
                bw.Options = encOptions;
                bw.Format = ZXing.BarcodeFormat.QR_CODE;
                var resultado = new Bitmap(bw.Write(text));
                return resultado;
            }
            catch
            {
                throw;
            }
        }
        private void btnGerarQRCode_Click(object sender, EventArgs e)
        {
            if (txtTexto.Text == string.Empty || txtLargura.Text == string.Empty && txtLargura.Text == string.Empty)
            {
                MessageBox.Show("Informações inválidas. Complete as informações para gerar o QRCode.");
                txtTexto.Focus();
                return;
            }
            try
            {
                int largura = Convert.ToInt32(txtLargura.Text);
                int altura = Convert.ToInt32(txtAltura.Text);
                string QRcode_left = "MOTO-WIFI:S:" + txtTexto.Text + ";T:WPA;P:12345678;H:false;IP:192.168.137.10;";
                string QRcode_right = "MOTO-WIFI:S:" + txtTexto.Text + ";T:WPA;P:12345678;H:false;IP:192.168.137.20;";
                picQRCodeLeft.Image = GerarQRCode(largura, altura, QRcode_left);
                picQRCodeRight.Image = GerarQRCode(largura, altura, QRcode_right);
                textInfo.Text = "SSID:" + txtTexto.Text + "\r\n" + "Senha:12345678";
                picQRCodeLeft.Image.Save(@"C:\prod\config\QRcode_left.jpeg", ImageFormat.Jpeg);
                picQRCodeRight.Image.Save(@"C:\prod\config\QRcode_right.jpeg", ImageFormat.Jpeg);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
