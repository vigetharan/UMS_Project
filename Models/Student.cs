using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnicomTICManagementSystem.Models
{
    internal class Student : Person
    {
        public int Id { get; set; }
        public string UTNumber { get; set; }

        public int CourseId { get; set; }
        public DateTime JoinedDate { get; set; }
        public int UserId { get; set; }
    }
}
