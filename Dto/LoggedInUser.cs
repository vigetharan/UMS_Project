using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnicomTICManagementSystem.Models;

namespace UnicomTICManagementSystem.Dto
{
    public class LoggedInUser
    {
        public int UserId { get; set; }
        public Enums.UserRole Role { get; set; }
        public int PersonId { get; set; }
        public string Name { get; set; }
        public Enums.PrivilageLevel PrivilageLevel { get; set; }
    }
}
