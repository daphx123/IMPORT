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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            
        }
        public void loadform(object Form)
        {
            if (this.guna2Panel2.Controls.Count > 0)
                this.guna2Panel2.Controls.RemoveAt(0);
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.guna2Panel2.Controls.Add(f);
            this.guna2Panel2.Tag = f;
            f.Show();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            loadform(new HomeForm());
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            loadform(new EventsForm());
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            loadform(new CustomerForm());
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            loadform(new VenuesForm());
        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            Form1 frm1 = new Form1();
            frm1.Show();
            this.Hide();
            
        }

        private void guna2Button10_Click(object sender, EventArgs e)
        {
            
        }

        private void guna2Button9_Click(object sender, EventArgs e)
        {
            
        }

        private void guna2Button8_Click(object sender, EventArgs e)
        {
            
        }

        private void guna2Button7_Click(object sender, EventArgs e)
        {
            
        }

        private void guna2Button7_Click_1(object sender, EventArgs e)
        {
            loadform(new RecordForm());
        }

        private void guna2Button3_Click_1(object sender, EventArgs e)
        {
            loadform(new DashboardForm());
        }
    }
}
