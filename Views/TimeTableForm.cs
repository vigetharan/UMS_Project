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
using UnicomTICManagementSystem.Models;

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
            LoadCombo();
        }

        public void LoadCombo()
        {
            CourseController cc = new CourseController();
            DataTable dtt = cc.GetAllCoursesTOCombo();
            cb_course.DataSource = dtt;
            cb_course.DisplayMember = "CourseName";
            cb_course.ValueMember = "Id";

            cb_course.SelectedIndex = 0;

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
                        dr["Id"] = 0;              
                        dr["Name"] = "-- Select One --";
                        dt.Rows.InsertAt(dr, 0);


                        cb_lecturer.DataSource = dt;
                        cb_lecturer.DisplayMember = "Name";
                        cb_lecturer.ValueMember = "Id";
                        cb_lecturer.SelectedIndex = 0;
                    }

                    
                    string queryroom = "SELECT Id, RoomName FROM Rooms";
                    using (var cmd = new SQLiteCommand(queryroom, dbconn))
                    using (var adapter = new SQLiteDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        DataRow dr = dt.NewRow();
                        dr["Id"] = 0;
                        dr["RoomName"] = "-- Select One --";
                        dt.Rows.InsertAt(dr, 0);


                        cb_room.DataSource = dt;
                        cb_room.DisplayMember = "RoomName";
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
                        dr["Id"] = 0;
                        dr["TimeSlot"] = "-- Select One --";
                        dt.Rows.InsertAt(dr, 0);


                        cb_timeslot.DataSource = dt;
                        cb_timeslot.DisplayMember = "TimeSlot";
                        cb_timeslot.ValueMember = "Id";
                        cb_timeslot.SelectedIndex = 0;
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
            if (cb_type.SelectedItem.ToString() == "EXAM")
            {
                cb_subject.Enabled = false;
            }
            else if (cb_type.SelectedItem.ToString() == "LECTURE")
            {
                cb_subject.Enabled = true;
                cb_exam.Enabled = false;
            }
            else if (cb_type.SelectedItem.ToString() == "LAB")
            {
                cb_subject.Enabled = true;
                cb_exam.Enabled = false;
            }
            else
            {
                cb_subject.Enabled = false;
                cb_exam.Enabled = false;
            }
            
        }

        private void cb_group_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                using (var dbconn = DatabaseManager.GetConnection())
                {
                    // Check if the ComboBox is bound and has a valid value
                    if (cb_course.SelectedValue == null || cb_course.SelectedValue is DBNull)
                    {
                        MessageBox.Show("No valid course selected. Please select a course.");
                        return;
                    }

                    // Retrieve the selected CourseId
                    int courseId;
                    if (int.TryParse(cb_course.SelectedValue.ToString(), out courseId))
                    {
                        if (courseId <= 0)
                        {
                            // Handle default "Select One" row
                            MessageBox.Show("Please select a valid course.");
                            return;
                        }

                        // Proceed with the query if a valid course is selected
                        string query1 = "SELECT Subjects.Id AS Id, Subjects.Name AS Name FROM Subjects WHERE Subjects.CourseId = @courseId";

                        using (var cmd = new SQLiteCommand(query1, dbconn))
                        {
                            cmd.Parameters.AddWithValue("@courseId", courseId);

                            using (var adapter = new SQLiteDataAdapter(cmd))
                            {
                                DataTable dt = new DataTable();
                                adapter.Fill(dt);

                                // Add a default "Select One" row
                                DataRow dr = dt.NewRow();
                                dr["Id"] = -1; // Default value
                                dr["Name"] = "-- Select One --";
                                dt.Rows.InsertAt(dr, 0);

                                // Bind the result to the ComboBox
                                cb_subject.DataSource = dt;
                                cb_subject.DisplayMember = "Name";
                                cb_subject.ValueMember = "Id";
                                cb_subject.SelectedIndex = 0;
                            }
                        }
                    }
                    else
                    {
                        // Handle invalid value
                        MessageBox.Show("Invalid CourseId selected. Please try again.");
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                LoadCombo();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            TimeTable tt = new TimeTable
            {
                TimeSlotId = Convert.ToInt32(cb_timeslot.SelectedValue),
                RoomId = Convert.ToInt32(cb_room.SelectedValue),
                CourseId = Convert.ToInt32(cb_course.SelectedValue),
                ExamId = Convert.ToInt32(cb_type.SelectedValue),
                SubjectId = Convert.ToInt32(cb_subject.SelectedValue),
                LecturerId = Convert.ToInt32(cb_lecturer.SelectedValue)
            };
            TimeTableController ttc = new TimeTableController();
            ttc.AddTimeTable(tt);
            LoadCombo();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            label_room_error.Text = "Enter a room name to add (HALL-A, LAB-B, LAB-MINI.....)";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TimeTableController ttc = new TimeTableController();
            MessageBox.Show(ttc.AddRoom(tb_room.Text.Trim()));
            tb_room.Clear();


        }
    }
}
