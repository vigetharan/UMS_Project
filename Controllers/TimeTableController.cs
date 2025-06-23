using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnicomTICManagementSystem.Models;
using UnicomTICManagementSystem.Repositories;

namespace UnicomTICManagementSystem.Controllers
{
    internal class TimeTableController
    {
        public void AddTimeSlot(DateTime start, DateTime end, string timeSlot)
        {
            
                using (var dbconn = DatabaseManager.GetConnection())
                {
                    string addTimeSlotQuery = "INSERT INTO TimeSlots (StartTime, EndTime, TimeSlot) VALUES (@start, @end, @slot)";
                    SQLiteCommand addCommand = new SQLiteCommand(addTimeSlotQuery, dbconn);
                    addCommand.Parameters.AddWithValue("@start", start);
                    addCommand.Parameters.AddWithValue("@end", end);
                    addCommand.Parameters.AddWithValue("@slot", timeSlot);

                    addCommand.ExecuteNonQuery();
                }
        }

        public string AddRoom(string roomname)
        {
            using (var dbconn = DatabaseManager.GetConnection())
            {
                string addRoomQuery = "INSERT INTO Rooms (RoomName) VALUES (@name)";
                SQLiteCommand addCommand = new SQLiteCommand(addRoomQuery, dbconn);
                addCommand.Parameters.AddWithValue("name", roomname);
                addCommand.ExecuteNonQuery();
            }return "ROOM ADDED SUCCESSFULLY";
        }
        public string AddTimeTable(TimeTable tt)
        {
            using (var dbconn = DatabaseManager.GetConnection())
            {
                string addRoomQuery = "INSERT INTO TimeTables (TimeSlotId, RoomId, CourseId, ExamId, SubjectId, LecturerId) VALUES (@tsid,@roomid, @cid, @eid, @sid, @lid)";
                SQLiteCommand addCommand = new SQLiteCommand(addRoomQuery, dbconn);
                addCommand.Parameters.AddWithValue("tsid", tt.TimeSlotId);
                addCommand.Parameters.AddWithValue("roomid",tt.RoomId);
                addCommand.Parameters.AddWithValue("cid", tt.CourseId);
                addCommand.Parameters.AddWithValue("eid", tt.ExamId);
                addCommand.Parameters.AddWithValue("sid", tt.SubjectId);
                addCommand.Parameters.AddWithValue("lid", tt.LecturerId);
                addCommand.ExecuteNonQuery();
            }
            return "Schedule ADDED SUCCESSFULLY";
        }
    }
}
