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
            //sex
            string SexOption = "";
            if (Sex1.Checked)
            {
                SexOption = Sex1.Text;
            }
            if (Sex2.Checked)
            {
                SexOption = Sex2.Text;
            }
            // for the vaccination info
            string Vaccinated = "";
            if (Vaccinated1.Checked)
            {
                Vaccinated = Vaccinated1.Text;
            }
            if (vaccinated2.Checked)
            {
                Vaccinated = vaccinated2.Text;
            }

            var qrcodeall = "NAME: " + fullNametxtbox.Text + "\n"
                + "DATE OF VISIT: " + datevisited.Text + "\n"
                + "AGE: " + agebox.Text + "\n"
                + "SEX: " + SexOption + "\n"
                + "ADDRESS: " + textBoxaddress.Text + "\n"
                + "VACCINATED? " + Vaccinated + "\n"
                + "TEMPERATURE: " + textBoxtemp.Text + "\n"
                + "";

            QRCodeGenerator qr = new QRCodeGenerator();
            QRCodeData data = qr.CreateQrCode(qrcodeall, QRCodeGenerator.ECCLevel.Q);
            QRCode code = new QRCode(data);
            pictureBoxqrcode.Image = code.GetGraphic(7);

        }
    }
}
