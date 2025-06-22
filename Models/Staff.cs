using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnicomTICManagementSystem.Models
{
    internal class Staff: Person
    {
        public int PersonId { get; set; }
        public string EmployeeNo { get; set; }
        public decimal Salary { get; set; }
        public string JoinedDate { get; set; }
        public Enums.UserRole userRole { get; set; }
    }
}
