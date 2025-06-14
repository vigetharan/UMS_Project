using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnicomTICManagementSystem.Models
{
    internal class Staff: Person
    {
        public int Id { get; set; }
        private string StaffId { get; set; }
        private int UserId { get; set; }
    }
}
