using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnicomTICManagementSystem.Models
{
    internal class Student
    {
        public int Id { get; set; }
        public string UTNumber { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string NicNo {get; set;}
        public string ContactNo { get; set; }
        public int CourseId { get; set; }
        public int UserId { get; set; }
    }
}
