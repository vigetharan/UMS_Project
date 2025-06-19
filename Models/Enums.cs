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
            NONE = 0,
            ADMIN = 1,
            STUDENT = 2,
            STAFF = 3,
            LECTURER = 4
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
        public enum Grade {A,B,C,D,S,F}
        public enum ExamMode {LAB, ONLINE, WRITTEN, VIVA}
        public enum ScheduleType {EXAM , LECTURE_AT_HALL, LAB_SESSION, PRESENTATION, GROUP_ACTIVITY }
        public enum PrivilageLevel
        {
            ADMIN,
            LECTURER,
            STUDENT,
            STAFF
        }

    }
}
