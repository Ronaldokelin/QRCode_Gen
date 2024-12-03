using System;
using System.Drawing;
using System.Diagnostics;
using System.Drawing.Imaging;
using System.Linq;
using System.Net.NetworkInformation;
using System.Windows.Forms;
using System.IO;

namespace QRCode_Gen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ListNetworkInterfaces();
            Configinit();            
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












        // Depth Tab

        //Depth qrcode generator tab
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

        private void btnStationName_Click(object sender, EventArgs e)
        {
            string specificPath = @"C:\prod\config\";

            // Check if path exists
            if (Directory.Exists(specificPath))
            {
                // Filter only modelfile_world*.txt files
                string[] files = Directory.GetFiles(specificPath, "modelfile_world*.txt");
                if (files.Length > 0)
                {
                    string message = "";
                    foreach (string file in files)
                    {
                        // Extracts the part of the file name that matches the pattern *
                        string fileName = Path.GetFileName(file);
                        int lastUnderscoreIndex = fileName.LastIndexOf('_');
                        int extensionIndex = fileName.LastIndexOf(".txt");
                        if (lastUnderscoreIndex != -1 && extensionIndex != -1)
                        {
                            string extractedPart = fileName.Substring(lastUnderscoreIndex + 1, extensionIndex - lastUnderscoreIndex - 1);
                            message += extractedPart + Environment.NewLine;
                        }
                    }
                    MessageBox.Show(message, "Station Name Options");
                }
            }
            else
                MessageBox.Show("Station Name not found");

        }

        // UCT tab

        //UCT qrcode generator tab
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

                textInfoUCT.Text = "Network name (SSID):" + txtTextoUCT.Text + "\r\n" + "Password:12345678" + "\r\n" + "Images saved in the path C:>prod>config";

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

        private void btnStationNameUCT_Click(object sender, EventArgs e)
        {
            string specificPath = @"C:\prod\config\";

            // Check if path exists
            if (Directory.Exists(specificPath))
            {
                // Filter only modelfile_world*.txt files
                string[] files = Directory.GetFiles(specificPath, "modelfile_world*.txt");
                if (files.Length > 0)
                {
                    string message = "";
                    foreach (string file in files)
                    {
                        // Extracts the part of the file name that matches the pattern *
                        string fileName = Path.GetFileName(file);
                        int lastUnderscoreIndex = fileName.LastIndexOf('_');
                        int extensionIndex = fileName.LastIndexOf(".txt");
                        if (lastUnderscoreIndex != -1 && extensionIndex != -1)
                        {
                            string extractedPart = fileName.Substring(lastUnderscoreIndex + 1, extensionIndex - lastUnderscoreIndex - 1);
                            message += extractedPart + Environment.NewLine;
                        }
                    }
                    MessageBox.Show(message, "Station Name Options");
                }
            }
            else
                MessageBox.Show("Station Name not found");

        }

        // Config router TAB
        private void Configinit()
        {
            // Setting the default value for wifi router tab
            textBoxRenameInterface.Text = "Router";
            textBoxIP.Text = "192.168.137.1";
            textBoxMask.Text = "255.255.255.0";
            textBoxGateway.Text = "";

            textBoxNote.Text =
                "Fixed Wireless Router IP Setting: 192.168.137.2 \r\n" +
                "For Flex team use the link below for more information \r\n \r\n" +
                @"\\jagnt092\testengineer\03-Benchs\02-BE\07-DEPTH\Docs";
        }

        private void ListNetworkInterfaces()
        {
            var interfaces = NetworkInterface.GetAllNetworkInterfaces();
            foreach (var ni in interfaces)
            {
                comboBoxInterfaces.Items.Add(ni.Name); // Adicionando o nome da interface
            }
            comboBoxInterfaces.SelectedIndexChanged += ComboBoxInterfaces_SelectedIndexChanged;
        }

        private void ComboBoxInterfaces_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string interfaceName = comboBoxInterfaces.SelectedItem.ToString();
                var ni = NetworkInterface.GetAllNetworkInterfaces().FirstOrDefault(n => n.Name == interfaceName);
                if (ni != null)
                {
                    var ipProps = ni.GetIPProperties();
                    var ipv4Info = ipProps.UnicastAddresses.FirstOrDefault(a => a.Address.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork);
                    var ipv6Info = ipProps.UnicastAddresses.FirstOrDefault(a => a.Address.AddressFamily == System.Net.Sockets.AddressFamily.InterNetworkV6);

                    string ipv4Address = ipv4Info?.Address.ToString() ?? "N/A";
                    string ipv4Mask = ipv4Info?.IPv4Mask.ToString() ?? "N/A";
                    string ipv6Address = ipv6Info?.Address.ToString() ?? "N/A";

                    textBoxStatus.Text =
                    $"Interface: {ni.Name}\r\n" +
                    $"Descrição: {ni.Description}\r\n" +
                    $"Endereço IPv4: {ipv4Address}\r\n" +
                    $"Máscara de Sub-rede IPv4: {ipv4Mask}\r\n" +
                    $"Endereço IPv6: {ipv6Address}\r\n" +
                    $"Gateway: {ipProps.GatewayAddresses.FirstOrDefault()?.Address}";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocorreu um erro: {ex.Message}");
            }
        }

        private void buttonConfigure_Click(object sender, EventArgs e)
        {
            try
            {
                string interfaceName = comboBoxInterfaces.SelectedItem.ToString();
                string ip = textBoxIP.Text;
                string mask = textBoxMask.Text;
                string gateway = textBoxGateway.Text;
                string newName = textBoxRenameInterface.Text;

                ConfigureIP(interfaceName, ip, mask, gateway);
                RenameInterface(interfaceName, newName);
                comboBoxInterfaces.Items.Clear();
                ListNetworkInterfaces();

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocorreu um erro ao configurar a interface: {ex.Message}");
            }
        }

        private void ConfigureIP(string interfaceName, string ip, string mask, string gateway)
        {
            try
            {
                ProcessStartInfo psi = new ProcessStartInfo("netsh", $"interface ip set address name=\"{interfaceName}\" static {ip} {mask} {gateway}");
                psi.RedirectStandardOutput = true;
                psi.UseShellExecute = false;
                psi.CreateNoWindow = true;

                Process process = Process.Start(psi);
                process.WaitForExit();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocorreu um erro ao configurar o IP: {ex.Message}");
            }
        }

        private void RenameInterface(string oldName, string newName)
        {
            try
            {
                ProcessStartInfo psi = new ProcessStartInfo("netsh", $"interface set interface name=\"{oldName}\" newname=\"{newName}\"");
                psi.RedirectStandardOutput = true;
                psi.UseShellExecute = false;
                psi.CreateNoWindow = true;

                Process process = Process.Start(psi);
                process.WaitForExit();

                MessageBox.Show($"Interface {oldName} renomeada para {newName}.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocorreu um erro ao renomear a interface: {ex.Message}");
            }
        }

        
    }
}
