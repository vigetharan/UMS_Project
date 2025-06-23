using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnicomTICManagementSystem.Models
{
    internal class Attendance
    {
        public int Id { get; set; }
        public int PersonId { get; set; }
        public DateTime Date { get; set; }
        public Enums.AttendanceStatus AttendanceStatus { get; set; }
        public int MarkedBy { get; set; }

    }
}
