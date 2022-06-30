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
    public partial class filterform : Form
    {
        public filterform()
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
            string dateOne = @"D:\Users\HP\Desktop\DATE\Jan 01, 2021 - April 30, 2021";
            List<string> filterbydate = new List<string>();
            filterbydate = File.ReadAllLines(dateOne).ToList();

            foreach (string line in filterbydate)
            {
                listBoxforfilter.Items.Add(line);
            }
            File.WriteAllLines(dateOne, filterbydate.ToArray());

           
        }
    }
    }

