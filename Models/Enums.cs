using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnicomTICManagementSystem.Models
{
    public class Enums  // <-- change internal to public
    {
        public enum UserRole
        {
            ADMIN,
            STUDENT,
            STAFF,
            LECTURER
        }

        public enum Gender
        {
            MALE,
            FEMALE
        }
        public enum  UserStatus
        {
            ACTIVE,
            INACTIVE
        }
    }
}
