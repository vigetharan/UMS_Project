using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnicomTICManagementSystem.Models
{
    internal class Staff: Person
    {
        public int StfId { get; set; }
        public string EmployeeId { get; set; }
        public string JoinedDate { get; set; }
//        puplic int UserId { get; set; }
 //       public int PersonId { get; set; }

    }
}
