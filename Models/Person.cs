using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnicomTICManagementSystem.Models
{
    internal class Person
    {
        public string NicNo { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string ContactNo { get; set; }
        public Enums.Gender Gender { get; set; }
        public DateTime DateOfBirth { get; set; }
        public int UserId { get; set; }
        public Enums.UserRole UserRole { get; set; }

    }
}
