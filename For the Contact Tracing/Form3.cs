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
    public partial class Listoverview : Form
    {
        public Listoverview()
        {
            InitializeComponent();
        }

        private void returnbttn_Click(object sender, EventArgs e)
        {
            Secondpage f2 = new Secondpage();
            f2.Show();
            this.Hide();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            StreamReader test;
            test = File.OpenText(@"D:\Users\HP\Desktop\Contact Tracing\Contact Tracing.txt");
            {
                while (!test.EndOfStream)
                {
                    forthelist.Items.Add(test.ReadLine());
                }
            }
            test.Close();
        }
    }
}
