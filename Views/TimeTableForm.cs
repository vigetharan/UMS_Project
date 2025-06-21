using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UnicomTICManagementSystem.Controllers;
using UnicomTICManagementSystem.Repositories;
using System.Data.SQLite;
using static UnicomTICManagementSystem.Models.Enums;

namespace UnicomTICManagementSystem.Views
{
    public partial class TimeTableForm : Form
    {
        public TimeTableForm()
        {
            InitializeComponent();
            LoadCombo();
        }

        private void TimeTableForm_Load(object sender, EventArgs e)
        {
            // Set the minimum date for the DateTimePickers to today
            // This ensures that users cannot select a date in the past
            dtp_end.Format = DateTimePickerFormat.Custom;
            dtp_end.CustomFormat = "yyyy-MM-dd hh:mm tt";
            dtp_start.Format = DateTimePickerFormat.Custom;
            dtp_start.CustomFormat = "yyyy-MM-dd hh:mm tt";
            dtp_start.MinDate = DateTime.Today;
            dtp_end.MinDate = DateTime.Today;


            var groupList_schedule = new List<string> { "--Select--" };
            groupList_schedule.AddRange(Enum.GetValues(typeof(ScheduleType)).Cast<ScheduleType>().Select(g => g.ToString()));
            cb_type.DataSource = groupList_schedule;
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
        public void LoadCombo()
        {

            try
            {
                using (var dbconn = DatabaseManager.GetConnection())
                {
                    string query = @"
                        SELECT l.PersonId AS Id, Persons.Name AS Name
                        FROM Lecturers l
                        JOIN Persons ON l.PersonId = Persons.Id";

                    using (var cmd = new SQLiteCommand(query, dbconn))
                    using (var adapter = new SQLiteDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        DataRow dr = dt.NewRow();
                        dr["Id"] = -1;              
                        dr["Name"] = "-- Select One --";
                        dt.Rows.InsertAt(dr, 0);


                        cb_lecturer.DataSource = dt;
                        cb_lecturer.DisplayMember = "Name";
                        cb_lecturer.ValueMember = "Id";
                        cb_lecturer.SelectedIndex = 0;
                    }

                    string query1 = "SELECT Subjects.Id AS Id, Subjects.Name AS Name FROM Subjects";
                    using (var cmd = new SQLiteCommand(query1, dbconn))
                    using (var adapter = new SQLiteDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        DataRow dr = dt.NewRow();
                        dr["Id"] = -1;
                        dr["Name"] = "-- Select One --";
                        dt.Rows.InsertAt(dr, 0);


                        cb_subject.DataSource = dt;
                        cb_subject.DisplayMember = "Name";
                        cb_subject.ValueMember = "Id";
                        cb_subject.SelectedIndex = 0;
                    }
                    string queryroom = "SELECT Rooms.Id AS Id, Rooms.RoomName AS Name FROM Rooms";
                    using (var cmd = new SQLiteCommand(queryroom, dbconn))
                    using (var adapter = new SQLiteDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        DataRow dr = dt.NewRow();
                        dr["Id"] = -1;
                        dr["Name"] = "-- Select One --";
                        dt.Rows.InsertAt(dr, 0);


                        cb_room.DataSource = dt;
                        cb_room.DisplayMember = "Name";
                        cb_room.ValueMember = "Id";
                        cb_room.SelectedIndex = 0;
                    }

                    string queryslot = "SELECT Id, TimeSlot FROM TimeSlots";
                    using (var cmd = new SQLiteCommand(queryslot, dbconn))
                    using (var adapter = new SQLiteDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        DataRow dr = dt.NewRow();
                        dr["Id"] = -1;
                        dr["TimeSlot"] = "-- Select One --";
                        dt.Rows.InsertAt(dr, 0);


                        cb_timeslot.DataSource = dt;
                        cb_timeslot.DisplayMember = "TimeSlot";
                        cb_timeslot.ValueMember = "Id";
                        cb_timeslot.SelectedIndex = 0;
                    }
                    string querycourse = "SELECT Id, CourseName FROM Courses";
                    using (var cmd = new SQLiteCommand(querycourse, dbconn))
                    using (var adapter = new SQLiteDataAdapter(cmd))
                    {
                        DataTable dt3 = new DataTable();
                        adapter.Fill(dt3);
                        DataRow dr = dt3.NewRow();
                        dr["Id"] = -1;
                        dr["CourseName"] = "-- Select One --";
                        dt3.Rows.InsertAt(dr, 0);


                        cb_group.DataSource = dt3;
                        cb_group.DisplayMember = "CourseName";
                        cb_group.ValueMember = "Id";
                        cb_group.SelectedIndex = 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void cb_lecturer_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cb_type_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cb_group_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
