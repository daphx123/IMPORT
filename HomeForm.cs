using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EVENT_MANAGEMENT_SYSTEM__2_
{
    public partial class HomeForm : Form
    {
        int month, year;
        public static int static_month, static_year;
        public HomeForm()
        {
            InitializeComponent();
        }


        private void HomeForm_Load(object sender, EventArgs e)
        {
            displaDays();
        }
        private void displaDays()
        {
            DateTime now = DateTime.Now;
            month = now.Month;
            year = now.Year;

            String monthname = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            label8.Text = monthname + " " + year;

            static_month = month;
            static_year = year;


            DateTime startofthemonth = new DateTime(year, month, 1);
            int days = DateTime.DaysInMonth(year, month);
            int daysoftheweek = Convert.ToInt32(startofthemonth.DayOfWeek.ToString("d")) + 1;

            for(int i = 1; i < daysoftheweek; i++)
            {
                UserControl1 ucblank = new UserControl1();
                flowLayoutPanel1.Controls.Add(ucblank);
            }
            for(int i = 1; i <= days; i++)
            {
                UserControl2 ucdays = new UserControl2();
                ucdays.days(i);
                flowLayoutPanel1.Controls.Add(ucdays);
            }

        }

        private void btnprevious_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            month--;

            static_month = month;
            static_year = year;

            String monthname = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            label8.Text = monthname + " " + year;

            DateTime startofthemonth = new DateTime(year, month, 1);
            int days = DateTime.DaysInMonth(year, month);
            int daysoftheweek = Convert.ToInt32(startofthemonth.DayOfWeek.ToString("d")) + 1;

            for (int i = 1; i < daysoftheweek; i++)
            {
                UserControl1 ucblank = new UserControl1();
                flowLayoutPanel1.Controls.Add(ucblank);
            }
            for (int i = 1; i <= days; i++)
            {
                UserControl2 ucdays = new UserControl2();
                ucdays.days(i);
                flowLayoutPanel1.Controls.Add(ucdays);
            }
        }

        private void btnnext_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            month++;

            static_month = month;
            static_year = year;

            String monthname = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            label8.Text = monthname + " " + year;

            DateTime startofthemonth = new DateTime(year, month, 1);
            int days = DateTime.DaysInMonth(year, month);
            int daysoftheweek = Convert.ToInt32(startofthemonth.DayOfWeek.ToString("d")) + 1;

            for (int i = 1; i < daysoftheweek; i++)
            {
                UserControl1 ucblank = new UserControl1();
                flowLayoutPanel1.Controls.Add(ucblank);
            }
            for (int i = 1; i <= days; i++)
            {
                UserControl2 ucdays = new UserControl2();
                ucdays.days(i);
                flowLayoutPanel1.Controls.Add(ucdays);
            }
        }
    }
}
