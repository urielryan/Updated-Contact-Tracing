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
using AForge.Video;
using AForge.Video.DirectShow;
using ZXing;
using ZXing.Common;
using ZXing.Rendering;
using ZXing.QrCode;


namespace For_the_Contact_Tracing
{
    public partial class AutoFillFormPage : Form
    {
        public AutoFillFormPage()
        {
            InitializeComponent();
        }

        FilterInfoCollection filterInfoCollection;
        VideoCaptureDevice captureDevice;

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

            string qrcodeall = fullNametxtbox.Text + "\n"
                + "" + "\n"
                + datevisited.Text + "\n"
                + "" + "\n"
                + agebox.Text + "\n"
                + "" + "\n"
                + SexOption + "\n"
                + "" + "\n"
                + textBoxaddress.Text + "\n"
                + "" + "\n"
                + Vaccinated + "\n"
                + "" + "\n"
                + textBoxtemp.Text + "\n";
               

            QRCodeGenerator qr = new QRCodeGenerator();
            QRCodeData data = qr.CreateQrCode(qrcodeall, QRCodeGenerator.ECCLevel.Q);
            QRCode code = new QRCode(data);
            pictureBoxqrcode.Image = code.GetGraphic(7);

        }

        private void AutoFillFormPage_Load(object sender, EventArgs e)
        {
            filterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach(FilterInfo filterInfo in filterInfoCollection)
                cameraDevice.Items.Add(filterInfo.Name);
            cameraDevice.SelectedIndex = 0;
        }

        private void bttncameraopen_Click(object sender, EventArgs e)
        {
            captureDevice = new VideoCaptureDevice(filterInfoCollection[cameraDevice.SelectedIndex].MonikerString);
            captureDevice.NewFrame += CaptureDevice_NewFrame;
            captureDevice.Start();
            timer1.Start();
        }

        private void CaptureDevice_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            pictureBox2.Image = (Bitmap)eventArgs.Frame.Clone();
        }

        private void AutoFillFormPage_FormClosing(object sender, FormClosingEventArgs e)
        {
          
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (pictureBox2.Image != null)
            {
                ZXing.Windows.Compatibility.BarcodeReader barcodeReader = new
                ZXing.Windows.Compatibility.BarcodeReader();

                Result result = barcodeReader.Decode((Bitmap)pictureBox2.Image);
                if(result != null)
                {
                    txtQRcodeshower.Text = result.ToString();
                    timer1.Stop();
                  
                }

            }

        }

        private void buttonforsubmit_Click(object sender, EventArgs e)
        {
            StreamWriter qrdone = File.AppendText(@"D:\Users\HP\Desktop\Contact Tracing\Contact Tracing TXT FILE.txt");
            qrdone.Write(txtQRcodeshower.Text);
            qrdone.Close();
            this.Close();
        }
    }
}
