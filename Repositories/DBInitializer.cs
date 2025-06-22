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

                    CREATE TABLE IF NOT EXISTS TimeSlots (
                        Id INTEGER PRIMARY KEY AUTOINCREMENT,
                        StartTime DATETIME NOT NULL,
                        EndTime DATETIME NOT NULL,                       
                        IsAvailable INTEGER NOT NULL DEFAULT 1 CHECK (IsAvailable IN (0, 1)),
                        TimeSlot TEXT NOT NULL
                    );
                    
                    CREATE TABLE IF NOT EXISTS Users(
                        Id INTEGER PRIMARY KEY AUTOINCREMENT,
                        Username TEXT NOT NULL UNIQUE,
                        Password TEXT NOT NULL,
                        Role INTEGER NOT NULL,
                        Status INTEGER NOT NULL DEFAULT 0
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
                        FOREIGN KEY (UserId) REFERENCES Users(Id) ON DELETE CASCADE                   
                    );

                    CREATE TABLE IF NOT EXISTS Students (
                        PersonId INTEGER PRIMARY KEY,
                        UTNumber TEXT NOT NULL,
                        JoinedDate TEXT,
                        ParentContact TEXT NOT NULL,
                        CourseId INTEGER NOT NULL,
                        FOREIGN KEY (CourseId) REFERENCES Courses(Id),
                        FOREIGN KEY (PersonId) REFERENCES Persons(Id) ON DELETE CASCADE
                        
                    );

                    CREATE TABLE IF NOT EXISTS Subjects (
                        Id INTEGER PRIMARY KEY AUTOINCREMENT,
                        Name TEXT NOT NULL,
                        CourseId INTEGER NOT NULL,
                        FOREIGN KEY (CourseId) REFERENCES Courses(Id) ON DELETE CASCADE
                    );

                    CREATE TABLE IF NOT EXISTS Lecturers (
                        PersonId INTEGER PRIMARY KEY,
                        EmployeeNo TEXT NOT NULL UNIQUE,
                        Salary DECIMAL NOT NULL,
                        JoinedDate TEXT,
                        FOREIGN KEY (PersonId) REFERENCES Persons(Id) ON DELETE CASCADE
                                                

                    );

                    CREATE TABLE IF NOT EXISTS Staffs (
                        PersonId INTEGER PRIMARY KEY,
                        EmployeeNo TEXT NOT NULL UNIQUE,
                        Salary DECIMAL NOT NULL,
                        JoinedDate TEXT,
                        FOREIGN KEY (PersonId) REFERENCES Persons(Id) ON DELETE CASCADE
                    );

                    CREATE TABLE IF NOT EXISTS Admins (
                        PersonId INTEGER PRIMARY KEY,
                        EmployeeNo TEXT NOT NULL UNIQUE,
                        Salary DECIMAL NOT NULL,
                        JoinedDate TEXT,
                        FOREIGN KEY (PersonId) REFERENCES Persons(Id) ON DELETE CASCADE
                    );
                    CREATE TABLE IF NOT EXISTS Exams (
                        Id INTEGER PRIMARY KEY AUTOINCREMENT,
                        Name TEXT NOT NULL,
                        ExamType INTEGER NOT NULL,
			            SubjectID INTEGER,
			            FOREIGN KEY (SubjectID) REFERENCES Subjects(SubjectID)
                    );

                        CREATE TABLE IF NOT EXISTS Marks (
                            Id INTEGER PRIMARY KEY AUTOINCREMENT,
                            Marks INTEGER NOT NULL,
                            StudentId INTEGER NOT NULL,
                            ExamId INTEGER NOT NULL,
                            Grade_Obtained TEXT NOT NULL,
                            UpdatedBy INTEGER NOT NULL,
                            FOREIGN KEY (StudentId) REFERENCES Students(PersonId) ON DELETE CASCADE,
                            FOREIGN KEY (ExamId) REFERENCES Exams(Id),
                            FOREIGN KEY (UpdatedBy) REFERENCES Users(Id)
                        );

                    CREATE TABLE IF NOT EXISTS Rooms (
                        Id INTEGER PRIMARY KEY AUTOINCREMENT,
                        RoomName TEXT NOT NULL
                    );

                        CREATE TABLE IF NOT EXISTS Attendances (
                        Id INTEGER PRIMARY KEY AUTOINCREMENT,
                        PersonId INTEGER NOT NULL,
                        Date DATETIME NOT NULL,
                        Status TEXT NOT NULL,
                        Markedby INTEGER NOT NULL,
                        FOREIGN KEY (PersonId) REFERENCES Students(PersonId) ON DELETE CASCADE
                    );

                
                    CREATE TABLE IF NOT EXISTS TimeTables (
                        Id INTEGER PRIMARY KEY AUTOINCREMENT,
                        TimeSlotId INTEGER NOT NULL,
			            RoomId INTEGER NOT NULL,
                        CourseId INTEGER NOT NULL,
                        ExamId INTEGER,
			            SubjectId INTEGER,
                        LecturerId INTEGER,
                        FOREIGN KEY (TimeSlotId) REFERENCES TimeSlots(Id),
			            FOREIGN KEY (RoomId) REFERENCES Rooms(Id),
                        FOREIGN KEY (CourseId) REFERENCES Courses(Id),
                        FOREIGN KEY (ExamId) REFERENCES Exams(Id),
			            FOREIGN KEY (SubjectID) REFERENCES Subjects(SubjectID),
                        FOREIGN KEY (LecturerId) REFERENCES Lecturers(PersonId),
			            CHECK (
        			        (ExamID IS NOT NULL AND SubjectID IS NULL AND LecturerID IS NULL) OR
        			        (ExamID IS NULL AND SubjectID IS NOT NULL AND LecturerID IS NOT NULL)
    				        )			
                    );
                    CREATE TABLE IF NOT EXISTS CourseSubject (
                        CourseId INTEGER,
                        SubjectId INTEGER,
                        PRIMARY KEY (CourseId, SubjectId),
                        FOREIGN KEY (CourseId) REFERENCES Courses(Id) ON DELETE CASCADE,
                        FOREIGN KEY (SubjectId) REFERENCES Subjects(Id)
                    );


                    CREATE TABLE IF NOT EXISTS StudentSubject (
                        StudentId INTEGER,
                        SubjectId INTEGER,
                        PRIMARY KEY (StudentId, SubjectId),
                        FOREIGN KEY (StudentId) REFERENCES Students(PersonId) ON DELETE CASCADE,
                        FOREIGN KEY (SubjectId) REFERENCES Subjects(Id)
                    );

                    CREATE TABLE IF NOT EXISTS StudentLecture (
                        StudentId INTEGER,
                        LecturerId INTEGER,
                        PRIMARY KEY (StudentId, LecturerId),
                        FOREIGN KEY (StudentId) REFERENCES Students(PersonId) ON DELETE CASCADE,
                        FOREIGN KEY (LecturerId) REFERENCES Lecturers(PersonId)
                    );

                    CREATE TABLE IF NOT EXISTS LecturerSubjects (
                        SubjectId INTEGER,
                        LecturerId INTEGER,
                        PRIMARY KEY (LecturerId, SubjectId),
                        FOREIGN KEY (LecturerId) REFERENCES Lecturers(PersonId) ON DELETE CASCADE,
                        FOREIGN KEY (SubjectId) REFERENCES Subjects(Id)
                    );
                    CREATE TABLE IF NOT EXISTS StudentExam (
                        PersonId INTEGER,
                        ExamId INTEGER,
                        MarksObtained INTEGER,
                        PRIMARY KEY (PersonId, ExamId),
                        FOREIGN KEY (PersonId) REFERENCES Students(PersonId) ON DELETE CASCADE,
                        FOREIGN KEY (ExamId) REFERENCES Exams(Id) ON DELETE CASCADE
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