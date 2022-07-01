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
    }
    }

