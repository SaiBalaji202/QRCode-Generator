using QRCoder;
using System;
using System.Windows.Forms;

namespace QRCode_Generator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEncode_Click(object sender, EventArgs e)
        {
            var qrCodeGenerator = new QRCodeGenerator();
            // ECC Level
            // H -> High (30%)
            // Q -> Quality (25%)
            // M -> Medium (15%)
            // L -> Low (7%)
            var qrCodeData = qrCodeGenerator.CreateQrCode(rtxtPayload.Text, QRCodeGenerator.ECCLevel.Q);
            var qrCode = new QRCode(qrCodeData);
            var bmp = qrCode.GetGraphic(20);
            picQRCode.Image = bmp;

        }
    }
}
