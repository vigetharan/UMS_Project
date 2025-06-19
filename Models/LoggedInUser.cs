using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnicomTICManagementSystem.Models
{
            public static class LoggedInUser
            {
                public static int UserId { get; set; }
                public static Enums.UserRole Role { get; set; }
                public static int PersonId { get; set; }
                public static string Name { get; set; }
                public static Enums.PrivilageLevel PrivilageLevel { get; set; }
            }
}
