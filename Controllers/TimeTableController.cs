using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnicomTICManagementSystem.Repositories;

namespace UnicomTICManagementSystem.Controllers
{
    internal class TimeTableController
    {
        public void AddTimeSlot(DateTime start, DateTime end, string timeSlot)
        {
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
        }
    }
}
