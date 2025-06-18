using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UnicomTICManagementSystem.Controllers;

namespace UnicomTICManagementSystem.Views
{
    public partial class TimeTable : Form
    {
        public TimeTable()
        {
            InitializeComponent();
        }

        private void TimeTable_Load(object sender, EventArgs e)
        {
            // Set the minimum date for the DateTimePickers to today
            // This ensures that users cannot select a date in the past
            dtp_end.Format = DateTimePickerFormat.Custom;
            dtp_end.CustomFormat = "yyyy-MM-dd hh:mm tt";
            dtp_start.Format = DateTimePickerFormat.Custom;
            dtp_start.CustomFormat = "yyyy-MM-dd hh:mm tt";
            dtp_start.MinDate = DateTime.Today;
            dtp_end.MinDate = DateTime.Today;
        }

        private void btn_add_timeslot_Click(object sender, EventArgs e)
        {
            TimeTableController ttc = new TimeTableController();
            if (dtp_start.Value < dtp_end.Value)
            {
                string timeSlot = $"{dtp_start.Value:yyyy-MM-dd} {dtp_start.Value:ddd} {dtp_start.Value:hh.mm tt}-{dtp_end.Value:hh.mm tt}";

                ttc.AddTimeSlot(dtp_start.Value,dtp_end.Value,timeSlot);
                MessageBox.Show("Time slot added successfully.");
            }
            else
            {
                MessageBox.Show("End time must be after start time.");
            }
        }
    }
}
