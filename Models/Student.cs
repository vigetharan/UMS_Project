using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnicomTICManagementSystem.Models
{
    internal class Student : Person
    {
        public int StudentId { get; set; }
        public string UTNumber { get; set; }
        public Enums.Group Group_Assigned { get; set; }
        public int CourseId { get; set; }
        public string JoinedDate { get; set; }
        public string ParentContact { get; set; }
 //       public int PersonId { get; set; }
 //       public int UserId { get; set; }
    }
}
