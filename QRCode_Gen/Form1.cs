using System;
using System.Drawing;
using System.Windows.Forms;
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
            txtTexto.SelectionStart = txtTexto.Text.Length;
            txtTexto.Text = txtTexto.Text.ToUpper();

            if (txtTexto.Text == string.Empty || txtLargura.Text == string.Empty && txtLargura.Text == string.Empty)
            {
                MessageBox.Show("Invalid information. Complete the information to generate the QRCode.");
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

                textInfo.Text = "Network name (SSID):" + txtTexto.Text + "\r\n" + "Password:12345678" + "\r\n" + "Images saved in the path C:>prod>config";

                picQRCodeLeft.Image.Save(@"C:\prod\config\QRcode_left.jpg", ImageFormat.Jpeg);
                picQRCodeRight.Image.Save(@"C:\prod\config\QRcode_right.jpg", ImageFormat.Jpeg);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGerarQRCodeUCT_Click(object sender, EventArgs e)
        {
            txtTextoUCT.SelectionStart = txtTextoUCT.Text.Length;
            txtTextoUCT.Text = txtTextoUCT.Text.ToUpper();

            if (txtTextoUCT.Text == string.Empty || txtLarguraUCT.Text == string.Empty && txtLarguraUCT.Text == string.Empty)
            {
                MessageBox.Show("Invalid information. Complete the information to generate the QRCode.");
                txtTextoUCT.Focus();
                return;
            }
            try
            {
                int largura = Convert.ToInt32(txtLarguraUCT.Text);
                int altura = Convert.ToInt32(txtAlturaUCT.Text);
                string QRcode_1 = "MOTO-WIFI:S:" + txtTextoUCT.Text + ";T:WPA;P:12345678;H:false;IP:192.168.1.101;";
                string QRcode_2 = "MOTO-WIFI:S:" + txtTextoUCT.Text + ";T:WPA;P:12345678;H:false;IP:192.168.1.102;";
                string QRcode_3 = "MOTO-WIFI:S:" + txtTextoUCT.Text + ";T:WPA;P:12345678;H:false;IP:192.168.1.103;";
                string QRcode_4 = "MOTO-WIFI:S:" + txtTextoUCT.Text + ";T:WPA;P:12345678;H:false;IP:192.168.1.104;";
                string QRcode_5 = "MOTO-WIFI:S:" + txtTextoUCT.Text + ";T:WPA;P:12345678;H:false;IP:192.168.1.105;";

                picQRCode1.Image = GerarQRCode(largura, altura, QRcode_1);
                picQRCode2.Image = GerarQRCode(largura, altura, QRcode_2);
                picQRCode3.Image = GerarQRCode(largura, altura, QRcode_3);
                picQRCode4.Image = GerarQRCode(largura, altura, QRcode_4);
                picQRCode5.Image = GerarQRCode(largura, altura, QRcode_5);

                textInfoUCT.Text = "Network name (SSID):" + txtTextoUCT.Text + "\r\n" + "Password:12345678"+"\r\n"+ "Images saved in the path C:>prod>config";

                picQRCode1.Image.Save(@"C:\prod\config\QRcode_1.jpg", ImageFormat.Jpeg);
                picQRCode2.Image.Save(@"C:\prod\config\QRcode_2.jpg", ImageFormat.Jpeg);
                picQRCode3.Image.Save(@"C:\prod\config\QRcode_3.jpg", ImageFormat.Jpeg);
                picQRCode4.Image.Save(@"C:\prod\config\QRcode_4.jpg", ImageFormat.Jpeg);
                picQRCode5.Image.Save(@"C:\prod\config\QRcode_Rota.jpg", ImageFormat.Jpeg);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }    
    }
}
