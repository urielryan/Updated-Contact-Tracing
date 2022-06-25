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
          
           
        }

        private void listView1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
          
        }

        private void othershower_Click(object sender, EventArgs e)
        {
            string viewOthers = @"D:\Users\HP\Desktop\Contact Tracing\Contact Tracing.txt";
            List<string> compiledList = new List<string>();
            compiledList = File.ReadAllLines(viewOthers).ToList();

            foreach (string line in compiledList)
            {
                listBox1.Items.Add(line);
            }
            File.WriteAllLines(viewOthers, compiledList.ToArray());

            if (othershower.Enabled)
            {
                othershower.Enabled = false;
            }
        }
    }
}
