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
    public partial class Addbook : Form
    {
        public Addbook()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Addbook_Load(object sender, EventArgs e)
        {
            listView1.Columns.Add("Title", 80);
            listView1.Columns.Add("Code", 80);
            listView1.Columns.Add("Writer", 80);
            listView1.Columns.Add("Sumery", 140);
            listView1.Columns.Add("Availability", 100);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ListViewItem nitem = new ListViewItem(textBox1.Text);
            nitem.SubItems.Add(textBox2.Text);
            nitem.SubItems.Add(textBox3.Text);
            nitem.SubItems.Add(textBox4.Text);
            nitem.SubItems.Add(textBox5.Text);
            listView1.Items.Add(nitem);

        }
    }
}
