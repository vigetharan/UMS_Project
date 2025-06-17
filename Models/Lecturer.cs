using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnicomTICManagementSystem.Models
{
    internal class Lecturer : Person
    {
        public int LId { get; set; }
 //       public int PersonId { get; set;  }
        public string EmployeeId { get; set; }
        public decimal Salary { get; set; }
//        public int UserId {  get; set; }
        public int JoinedDate { get; set; }
    }
}
