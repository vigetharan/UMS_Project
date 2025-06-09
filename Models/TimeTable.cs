using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnicomTICManagementSystem.Models
{
    internal class TimeTable
    {
        public int Id { get; set; }
        public string TimeSlot {  get; set; }
        public string Subject { get; set; }
        public string RoomId { get; set; }
    }
}
