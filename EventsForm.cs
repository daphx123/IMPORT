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
    public partial class EventsForm : Form
    {
        public EventsForm()
        {
            InitializeComponent();
        }

        private void EventsForm_Load(object sender, EventArgs e)
        {
            guna2TextBox6.Text = HomeForm.static_month + "/" + UserControl2.static_day + "/" + HomeForm.static_year;
        }
    }
    
}
