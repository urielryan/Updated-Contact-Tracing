using QRCoder;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace For_the_Contact_Tracing
{
    public partial class AutoFillFormPage : Form
    {
        public AutoFillFormPage()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void buttongenerator_Click(object sender, EventArgs e)
        {
            QRCodeGenerator qr = new QRCodeGenerator();
            QRCodeData data = qr.CreateQrCode(fullNametxtbox.Text, QRCodeGenerator.ECCLevel.Q);
            QRCode code = new QRCode(data);
            pictureBoxqrcode.Image = code.GetGraphic(5);

        }
    }
}
