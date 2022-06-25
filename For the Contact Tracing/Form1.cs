namespace For_the_Contact_Tracing
{
    public partial class Firstpage : Form
    {
        public Firstpage()
        {
            InitializeComponent();
        }

        private void nextpage_Click(object sender, EventArgs e)
        {
            Secondpage f2 = new Secondpage();
            f2.Show();
            this.Hide();
        }

        private void exitbttn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}