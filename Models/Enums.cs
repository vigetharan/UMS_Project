using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnicomTICManagementSystem.Models

// for keep enum type variables
{
    public class Enums  
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
            MALE = 1,
            FEMALE =2
        }
        public enum  UserStatus
        {
            ACTIVE,
            INACTIVE
        }
        public enum Group        {GROUP_A, GROUP_B        }
        public enum AttendanceStatus        { PRESENT , ABSENT , LATE , EXCUSED        }
    }
}
