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
    public partial class Secondpage : Form
    {
        public Secondpage()
        {
            InitializeComponent();
        }

        private void Secondpage_Load(object sender, EventArgs e)
        {

        }

        private void Submitbutton_Click(object sender, EventArgs e)
        {
            //for the sex
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

            //for the array
            string[] information = {"FULL NAME: " + Surname.Text + ", " + firstname.Text,
                                    "DATE OF VISIT: " + dateOfVisit.Text,
                                    "AGE: "       + age.Text + " years old",
                                    "SEX: " + SexOption,
                                    "ADDRESS: " + fulladdress.Text,
                                    "DATE OF BIRTH: " + birthdate.Text,
                                    "VACCINATED? " + Vaccinated,
                                    "TEMPERATURE: " + temperaturebox.Text,
                                    " " };
            StreamWriter alltheinformation;
            alltheinformation = File.AppendText(@"D:\Users\HP\Desktop\Contact Tracing.txt");
            foreach (string str in information)
            {
                alltheinformation.WriteLine(str);
         
            }
            alltheinformation.Close();
            this.Close();
        }
        //return
        private void button1_Click(object sender, EventArgs e)
        {
            Listoverview f3 = new Listoverview();
            f3.Show();
            this.Hide();
        }

        private void buttonqrpage_Click(object sender, EventArgs e)
        {
            AutoFillFormPage f5 = new AutoFillFormPage();
            f5.Show();
            this.Hide();
        }
    }
}
