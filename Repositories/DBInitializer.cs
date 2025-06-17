using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnicomTICManagementSystem.Repositories
{
    public static class DBInitializer
    {
        public static void CreateTables()
        {
            using (var conn = DatabaseManager.GetConnection())
            {
                var cmd = conn.CreateCommand();

                cmd.CommandText = @"
                    CREATE TABLE IF NOT EXISTS Courses (
                        Id INTEGER PRIMARY KEY AUTOINCREMENT,
                        CourseName TEXT NOT NULL
                    );
                    
                    CREATE TABLE IF NOT EXISTS Users(
                        Id INTEGER PRIMARY KEY AUTOINCREMENT,
                        Username TEXT NOT NULL UNIQUE,
                        Password TEXT NOT NULL,
                        Role INTEGER NOT NULL,
                        Status INTEGER NOT NULL DEFAULT O
                    );

                    CREATE TABLE IF NOT EXISTS Persons (
                        Id INTEGER PRIMARY KEY AUTOINCREMENT,
                        NicNo TEXT NOT NULL,
                        Name TEXT NOT NULL,
                        Address TEXT NOT NULL,
                        Email TEXT NOT NULL,
                        ContactNo TEXT NOT NULL,
                        Gender INTEGER,
                        DateOfBirth DATETIME,
                        UserRole INTEGER,
                        UserId INTEGER NOT NULL UNIQUE,
                        FOREIGN KEY (UserId) REFERENCES Users(Id)                     
                    );

                    CREATE TABLE IF NOT EXISTS Students (
                        StudentId INTEGER PRIMARY KEY AUTOINCREMENT,
                        UTNumber TEXT NOT NULL,
                        Group_Assigned INTEGER,
                        JoinedDate TEXT,
                        ParentContact TEXT NOT NULL,
                        CourseId INTEGER NOT NULL,
                        FOREIGN KEY (CourseId) REFERENCES Courses(Id)
                        
                    );

                    CREATE TABLE IF NOT EXISTS Subjects (
                        Id INTEGER PRIMARY KEY AUTOINCREMENT,
                        Name TEXT NOT NULL,
                        CourseId INTEGER NOT NULL,
                        FOREIGN KEY (CourseId) REFERENCES Courses(Id)
                    );

                    CREATE TABLE IF NOT EXISTS Lecturers (
                        Id INTEGER PRIMARY KEY AUTOINCREMENT,
                        EmployeeId TEXT NOT NULL UNIQUE,
                        Salary DECIMAL NOT NULL,
                        JoinedDate TEXT,
                        UserId INTEGER NOT NULL,
                        PersonId INTEGER NOT NULL UNIQUE,
                        FOREIGN KEY (PersonId) REFERENCES Persons(Id),
                        FOREIGN KEY (UserId) REFERENCES Users(Id)
                    );

                    CREATE TABLE IF NOT EXISTS Staffs (
                        Id INTEGER PRIMARY KEY AUTOINCREMENT,
                        EmployeeId TEXT NOT NULL UNIQUE,
                        JoinedDate TEXT,
                        UserId INTEGER NOT NULL,
                        PersonId INTEGER NOT NULL UNIQUE,
                        FOREIGN KEY (PersonId) REFERENCES Persons(Id),
                        FOREIGN KEY (UserId) REFERENCES Users(Id)
                    );

                    CREATE TABLE IF NOT EXISTS Admins (
                        Id INTEGER PRIMARY KEY AUTOINCREMENT,
                        EmployeeId TEXT NOT NULL UNIQUE,
                        JoinedDate TEXT,
                        UserId INTEGER NOT NULL,
                        PersonId INTEGER NOT NULL UNIQUE,
                        FOREIGN KEY (PersonId) REFERENCES Persons(Id),
                        FOREIGN KEY (UserId) REFERENCES Users(Id)
                    );
                    CREATE TABLE IF NOT EXISTS Exams (
                        Id INTEGER PRIMARY KEY AUTOINCREMENT,
                        Name TEXT NOT NULL,
                        SubjectId INTEGER NOT NULL,
                        ExamDate TEXT NOT NULL,
                        FOREIGN KEY (SubjectId) REFERENCES Subjects(Id)
                    );

                        CREATE TABLE IF NOT EXISTS Marks (
                        Id INTEGER PRIMARY KEY AUTOINCREMENT,
                        Marks INTEGER NOT NULL,
                        StudentId INTEGER NOT NULL,
                        ExamId INTEGER NOT NULL,
                        Grade_Obtained TEXT NOT NULL,
                        UpdatedBy INTEGER NOT NULL,
                        FOREIGN KEY (ExamId) REFERENCES Subjects(Id),
                        FOREIGN KEY (StudentId) REFERENCES Students(Id)
                    );
                    CREATE TABLE IF NOT EXISTS Rooms (
                        Id INTEGER PRIMARY KEY AUTOINCREMENT,
                        RoomName TEXT NOT NULL,
                        RoomType TEXT CHECK(RoomType IN ('Lab', 'Hall')) NOT NULL,
                        Capacity INTEGER
                    );
                        CREATE TABLE IF NOT EXISTS Attendances (
                        Id INTEGER PRIMARY KEY AUTOINCREMENT,
                        StudentId INTEGER NOT NULL,
                        Date DATETIME NOT NULL,
                        Status TEXT NOT NULL,
                        FOREIGN KEY (StudentId) REFERENCES Students(PersonId)  ON DELETE CASCADE
                    );

                
                    CREATE TABLE IF NOT EXISTS TimeTables (
                        Id INTEGER PRIMARY KEY AUTOINCREMENT,
                        Group_Assigned INTEGER NOT NULL,
                        TimeSlotId INTEGER NOT NULL,
                        SubjectId INTEGER NOT NULL,
                        ExamId INTEGER NOT NULL DEFAULT -1,
                        LecturerId INTEGER NOT NULL,                        
                        RoomId INTEGER NOT NULL,
                        FOREIGN KEY (RoomId) REFERENCES Rooms(Id),
                        FOREIGN KEY (TimeSlotId) REFERENCES TimeSlots(Id),
                        FOREIGN KEY (SubjectId) REFERENCES Subjects(Id),
                        FOREIGN KEY (ExamId) REFERENCES Exams(Id),
                        FOREIGN KEY (LecturerId) REFERENCES Lecturers(Id)
                    );


                    CREATE TABLE IF NOT EXISTS StudentSubject (
                        StudentId INTEGER,
                        SubjectId INTEGER,
                        PRIMARY KEY (StudentId, SubjectId),
                        FOREIGN KEY (StudentId) REFERENCES Students(Id),
                        FOREIGN KEY (SubjectId) REFERENCES Subjects(Id)
                    );

                    CREATE TABLE IF NOT EXISTS StudentLecture (
                        StudentId INTEGER,
                        LecturerId INTEGER,
                        PRIMARY KEY (StudentId, LecturerId),
                        FOREIGN KEY (StudentId) REFERENCES Students(Id),
                        FOREIGN KEY (LecturerId) REFERENCES Lecturers(Id)
                    );

                    CREATE TABLE IF NOT EXISTS LecturerSubjects (
                        SubjectId INTEGER,
                        LecturerId INTEGER,
                        PRIMARY KEY (LecturerId, SubjectId),
                        FOREIGN KEY (LecturerId) REFERENCES Lecturers(Id),
                        FOREIGN KEY (SubjectId) REFERENCES Subjects(Id)
                    );
                    
                    CREATE TABLE IF NOT EXISTS ErrorLogs (
                        LogID INTEGER PRIMARY KEY AUTOINCREMENT,
                        UserId INTEGER NOT NULL,
                        LogType TEXT NOT NULL,
                        Timestamp DATETIME DEFAULT CURRENT_TIMESTAMP,
                        Message TEXT NOT NULL,
                        Details TEXT,
                        FOREIGN KEY (UserId) REFERENCES Users(Id) ON DELETE CASCADE
                    );
                ";

                cmd.ExecuteNonQuery();
            }
        }
    }
}