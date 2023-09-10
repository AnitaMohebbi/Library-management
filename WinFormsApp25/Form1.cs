namespace WinFormsApp25
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Addcostumer ac = new Addcostumer();
            ac.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Addbook ab = new Addbook();
            ab.Show();
        }
    }
}