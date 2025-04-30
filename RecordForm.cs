using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EVENT_MANAGEMENT_SYSTEM__2_
{
    public partial class RecordForm : Form
    {
        public RecordForm()
        {
            InitializeComponent();
        }

        private void RecordForm_Load(object sender, EventArgs e)
        {
            listView1.Columns.Add("Name", 80);
            listView1.Columns.Add("EventName", 120);
            listView1.Columns.Add("TimeReservation", 120);
            listView1.Columns.Add("Status", 100);
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            ListViewItem newitem = new ListViewItem(textBox1.Text);
            newitem.SubItems.Add(textBox2.Text);
            newitem.SubItems.Add(textBox3.Text);
            newitem.SubItems.Add(textBox4.Text);
            listView1.Items.Add(newitem);
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = " ";
            textBox2.Text = " ";
            textBox3.Text = " ";
            textBox4.Text = " ";
        }

        private void listView1_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                textBox1.Text = listView1.SelectedItems[0].SubItems[0].Text;
                textBox2.Text = listView1.SelectedItems[0].SubItems[1].Text;
                textBox3.Text = listView1.SelectedItems[0].SubItems[2].Text;
                textBox4.Text = listView1.SelectedItems[0].SubItems[3].Text;
            }
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                listView1.SelectedItems[0].SubItems[0].Text = textBox1.Text;
                listView1.SelectedItems[0].SubItems[1].Text = textBox2.Text;
                listView1.SelectedItems[0].SubItems[2].Text = textBox3.Text;
                listView1.SelectedItems[0].SubItems[3].Text = textBox4.Text;
            }
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                listView1.Items.Remove(listView1.SelectedItems[0]);
            }
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
