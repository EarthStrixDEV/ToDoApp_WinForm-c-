using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string title = textBox1.Text;
            string detail = textBox2.Text;
            string start = textBox3.Text;
            string end = textBox4.Text;

            string[] data = new string[4];
            data[0] = title;
            data[1] = detail;
            data[2] = start;
            data[3] = end;

            ListViewItem item = new ListViewItem(data);
            listView1.Items.Add(item);

            bool check_box = checkBox1.Checked;
            bool check_box2 = checkBox2.Checked;
            bool check_box3 = checkBox3.Checked;

            if (check_box)
            {
                listView1.ForeColor = Color.Red;
            }
            else if (check_box2)
            {
                listView1.ForeColor = Color.Violet;
            }
            else if (check_box3)
            {
                listView1.ForeColor = Color.Pink;
            }
            else
            {
                listView1.ForeColor = Color.Black;
            }

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            listView1.View = View.Details;
            listView1.GridLines = true;
            listView1.FullRowSelect = true;
            listView1.Columns.Add("Title", 100);
            listView1.Columns.Add("Detail", 100);
            listView1.Columns.Add("Start", 100);
            listView1.Columns.Add("End", 100);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string blank = "";
            textBox1.Text = blank;
            textBox2.Text = blank;
            textBox3.Text = blank;
            textBox4.Text = blank;
        }
    }
}
