using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp25
{
    public partial class Addcostumer : Form
    {
        public Addcostumer()
        {
            InitializeComponent();
        }

        private void Addcostumer_Load(object sender, EventArgs e)
        {
            listView1.Columns.Add("Name", 80);
            listView1.Columns.Add("LastName", 120);
            listView1.Columns.Add("PhoneNum", 140);
            listView1.Columns.Add("SCode", 80);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ListViewItem newitem = new ListViewItem(textBox1.Text);
            newitem.SubItems.Add(textBox2.Text);
            newitem.SubItems.Add(textBox3.Text);
            newitem.SubItems.Add(textBox4.Text);
            listView1.Items.Add(newitem);

        }
    }
}
