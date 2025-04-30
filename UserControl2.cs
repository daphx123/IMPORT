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
    public partial class UserControl2 : UserControl
    {
        public static string static_day;
        public UserControl2()
        {
            InitializeComponent();
        }

        private void UserControl2_Load(object sender, EventArgs e)
        {

        }
        public void days(int numday)
        {
            label1.Text = numday + "";
        }

        private void UserControl2_Click(object sender, EventArgs e)
        {
            static_day = label1.Text;
            EventsForm eventsForm= new EventsForm();
            eventsForm.Show();

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        
    }
}
