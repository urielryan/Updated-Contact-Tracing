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
    public partial class filterForm : Form
    {
        public filterForm()
        {
            InitializeComponent();
        }

        private void exitbttnform4_Click(object sender, EventArgs e)
        {
            Listoverview f3 = new Listoverview();
            f3.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBoxfilter.Items.Clear();

            string dateOne = @"C:\Users\HP\source\repos\For the Contact Tracing\Date\Jan 01, 2021 - April 30, 2021.txt";
            List<string> filterbydate = new List<string>();
            filterbydate = File.ReadAllLines(dateOne).ToList();

            foreach (string line in filterbydate)
            {
                listBoxfilter.Items.Add(line);
            }
            File.WriteAllLines(dateOne, filterbydate.ToArray());

        }

        private void date2bttn_Click(object sender, EventArgs e)
        {
            listBoxfilter.Items.Clear();

            string dateTwo = @"C:\Users\HP\source\repos\For the Contact Tracing\Date\May 01, 2021 - August 31, 2021.txt";
            List<string> filterbydate = new List<string>();
            filterbydate = File.ReadAllLines(dateTwo).ToList();

            foreach (string line in filterbydate)
            {
                listBoxfilter.Items.Add(line);
            }
            File.WriteAllLines(dateTwo, filterbydate.ToArray());

        }

        private void date3bttn_Click(object sender, EventArgs e)
        {
            listBoxfilter.Items.Clear();

            string dateThree = @"C:\Users\HP\source\repos\For the Contact Tracing\Date\Sep 01, 2021 - Dec 30, 2021.txt";
            List<string> filterbydate = new List<string>();
            filterbydate = File.ReadAllLines(dateThree).ToList();

            foreach (string line in filterbydate)
            {
                listBoxfilter.Items.Add(line);
            }
            File.WriteAllLines(dateThree, filterbydate.ToArray());
        }

        private void date4bttn_Click(object sender, EventArgs e)
        {
            listBoxfilter.Items.Clear();

            string dateFour = @"C:\Users\HP\source\repos\For the Contact Tracing\Date\Jan 01, 2022 - Mar 31, 2022.txt";
            List<string> filterbydate = new List<string>();
            filterbydate = File.ReadAllLines(dateFour).ToList();

            foreach (string line in filterbydate)
            {
                listBoxfilter.Items.Add(line);
            }
            File.WriteAllLines(dateFour, filterbydate.ToArray());
        }

        private void date5bttn_Click(object sender, EventArgs e)
        {
            listBoxfilter.Items.Clear();

            string dateFive = @"C:\Users\HP\source\repos\For the Contact Tracing\Date\May 01, 2022 - August 31, 2022.txt";
            List<string> filterbydate = new List<string>();
            filterbydate = File.ReadAllLines(dateFive).ToList();

            foreach (string line in filterbydate)
            {
                listBoxfilter.Items.Add(line);
            }
            File.WriteAllLines(dateFive, filterbydate.ToArray());
        }

        private void date6bttn_Click(object sender, EventArgs e)
        {
            listBoxfilter.Items.Clear();

            string dateSix = @"C:\Users\HP\source\repos\For the Contact Tracing\Date\Sep 01, 2022 - Dec 30, 2022.txt";
            List<string> filterbydate = new List<string>();
            filterbydate = File.ReadAllLines(dateSix).ToList();

            foreach (string line in filterbydate)
            {
                listBoxfilter.Items.Add(line);
            }
            File.WriteAllLines(dateSix, filterbydate.ToArray());
        }

        private void date7bttn_Click(object sender, EventArgs e)
        {
            listBoxfilter.Items.Clear();

            string dateSeven = @"C:\Users\HP\source\repos\For the Contact Tracing\Date\Before Jan 1, 2021.txt";
            List<string> filterbydate = new List<string>();
            filterbydate = File.ReadAllLines(dateSeven).ToList();

            foreach (string line in filterbydate)
            {
                listBoxfilter.Items.Add(line);
            }
            File.WriteAllLines(dateSeven, filterbydate.ToArray());
        }

        private void exitbttn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
    }

