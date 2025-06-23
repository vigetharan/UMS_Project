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
       
        public int TimeSlotId {  get; set; }      
        public int RoomId { get; set; }
        public int CourseId { get; set; }
        public int ExamId { get; set; }
        public int SubjectId { get; set; }
        public int LecturerId { get; set; }
    }
}
