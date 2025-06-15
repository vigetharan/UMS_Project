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
                        Role TEXT NOT NULL,
                        Status TEXT NOT NULL
                    );

                    CREATE TABLE IF NOT EXISTS Persons (
                        Id INTEGER PRIMARY KEY AUTOINCREMENT,
                        NicNo TEXT NOT NULL,
                        Name TEXT NOT NULL,
                        Address TEXT NOT NULL,
                        Email TEXT NOT NULL,
                        ContactNo TEXT NOT NULL,
                        Gender INTEGER,
                        UserId INTEGER NOT NULL UNIQUE,
                        FOREIGN KEY (UserId) REFERENCES Users(Id)                     
                    );

                    CREATE TABLE IF NOT EXISTS Students (
                        Id INTEGER PRIMARY KEY AUTOINCREMENT,
                        UTNumber TEXT NOT NULL,
                        CourseId INTEGER,
                        JoinedDate DATETIME DEFAULT CURRENT_TIMESTAMP,
                        PersonId INTEGER NOT NULL,
                        UserId INTEGER NOT NULL,
                        FOREIGN KEY (PersonId) REFERENCES Persons(Id),
                        FOREIGN KEY (UserId) REFERENCES Users(Id),
                        FOREIGN KEY (CourseId) REFERENCES Courses(Id)
                        
                    );

                    CREATE TABLE IF NOT EXISTS Lecturers (
                        Id INTEGER PRIMARY KEY AUTOINCREMENT,
                        Name TEXT NOT NULL,
                        Phone TEXT NOT NULL,
                        Address TEXT NOT NULL,
                        Salary DECIMAL NOT NULL,
                        UserId INTEGER NOT NULL,
                        FOREIGN KEY (UserId) REFERENCES Users(Id)
                    );

                    CREATE TABLE IF NOT EXISTS Staffs (
                        Id INTEGER PRIMARY KEY AUTOINCREMENT,
                        UserId INTEGER NOT NULL,
                        FOREIGN KEY (UserId) REFERENCES Users(Id)
                    );

                    CREATE TABLE IF NOT EXISTS Admins (
                        Id INTEGER PRIMARY KEY AUTOINCREMENT,
                        UserId INTEGER NOT NULL,
                        FOREIGN KEY (UserId) REFERENCES Users(Id)
                    );
                    CREATE TABLE IF NOT EXISTS Exams (
                        Id INTEGER PRIMARY KEY AUTOINCREMENT,
                        Name TEXT NOT NULL,
                        SubjectId INTEGER NOT NULL,
                        FOREIGN KEY (SubjectId) REFERENCES Subject(Id)
                    );

                        CREATE TABLE IF NOT EXISTS Marks (
                        Id INTEGER PRIMARY KEY AUTOINCREMENT,
                        Marks INTEGER NOT NULL,
                        StudentId INTEGER NOT NULL,
                        SubjectId INTEGER NOT NULL,
                        FOREIGN KEY (SubjectId) REFERENCES Subjects(Id),
                        FOREIGN KEY (StudentId) REFERENCES Students(Id)
                    );

                    CREATE TABLE IF NOT EXISTS Subjects (
                        Id INTEGER PRIMARY KEY AUTOINCREMENT,
                        Name TEXT NOT NULL,
                        CourseId INTEGER NOT NULL,
                        FOREIGN KEY (CourseId) REFERENCES Courses(Id)
                    );


                    CREATE TABLE IF NOT EXISTS TimeTables (
                        Id INTEGER PRIMARY KEY AUTOINCREMENT,
                        StudentId INTEGER NOT NULL,
                        SubjectId INTEGER NOT NULL,
                        ExamId INTEGER NOT NULL,
                        FOREIGN KEY (StudentId) REFERENCES Users(Id),
                        FOREIGN KEY (SubjectId) REFERENCES Subjects(Id)
                        FOREIGN KEY (ExamId) REFERENCES Exams(Id)
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
                        FOREIGN KEY (LecturerId) REFERENCES Lecturers(Id)
                    );
                    
                    CREATE TABLE IF NOT EXISTS ErrorLogs (
                        LogID INTEGER PRIMARY KEY AUTOINCREMENT,
                        LogType TEXT NOT NULL,
                        Timestamp DATETIME DEFAULT CURRENT_TIMESTAMP,
                        Message TEXT NOT NULL,
                        Details TEXT
                    );
                ";

                cmd.ExecuteNonQuery();
            }
        }
    }
}