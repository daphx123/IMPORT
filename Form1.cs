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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text == "")
                {
                    textBox1.Text = "Enter Username";
                    return;
                }
                textBox1.ForeColor = Color.Black;


            }
            catch { }

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (textBox2.Text == "")
                {
                    textBox2.Text = "Enter Password";
                    return;
                }
                textBox2.ForeColor = Color.Black;

            }
            catch { }

        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            textBox1.SelectAll();
        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            textBox2.SelectAll();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "Admin" && textBox2.Text == "Admin")
            {
                MessageBox.Show("Log in Successful", "Successful!");
                Form2 frm2 = new Form2();
                frm2.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Wrong Password and Username", "Failed");
                Form1 frm1 = new Form1();
                frm1.Show();
                this.Hide();
            }


            if (textBox1.Text == "Enter Username")
            {
                panel5.Visible = true;
                return;
            }
            if (textBox2.Text == "Enter Password")
            {
                panel7.Visible = true;
                return;
            }



        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

            if (checkBox1.Checked)
            {
                textBox2.PasswordChar = '\0';
            }
            else
            {
                textBox2.PasswordChar = '*';
            }

        }
    }
}
