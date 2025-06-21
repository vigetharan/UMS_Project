using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UnicomTICManagementSystem.Models;
using UnicomTICManagementSystem.Repositories;
using System.Data;
using static UnicomTICManagementSystem.Models.Enums;

namespace UnicomTICManagementSystem.Controllers
{
    internal class PersonController
    {
        public int AddPerson(Person p)
        {
            int personId;
            using (var dbconn = DatabaseManager.GetConnection())
            {
                string addStudentQuery = "INSERT INTO Persons ( NicNo,Name,Address,Email,ContactNo,Gender,DateOfBirth, UserId, UserRole) VALUES (@nicno,@name,@address,@email,@contactno, @gender,@dob, @userid,@userrole)";
                SQLiteCommand addCommand = new SQLiteCommand(addStudentQuery, dbconn);
                addCommand.Parameters.AddWithValue("@nicno", p.NicNo);
                addCommand.Parameters.AddWithValue("@name", p.Name);
                addCommand.Parameters.AddWithValue("@address", p.Address);
                addCommand.Parameters.AddWithValue("@email", p.Email);
                addCommand.Parameters.AddWithValue("@contactno", p.ContactNo);
                addCommand.Parameters.AddWithValue("@gender", p.Gender);
                addCommand.Parameters.AddWithValue("@dob", p.DateOfBirth);
                addCommand.Parameters.AddWithValue("@userid", p.UserId);
                addCommand.Parameters.AddWithValue("@userrole", p.UserRole);
                addCommand.ExecuteNonQuery();

                string LastIdQuery = "SELECT last_insert_rowid()";
                SQLiteCommand idCommand = new SQLiteCommand(LastIdQuery, dbconn);
                personId = Convert.ToInt32(idCommand.ExecuteScalar());
            }
            return personId;
        }
        //
        //to get all persons to datagridview
        public DataTable ViewAllPerson()
        {
            using (var dbconn = DatabaseManager.GetConnection())
            {
                string query = @"
                    SELECT 
                        p.Id AS Id,
                        p.Name,
                        p.NicNo,
                        p.Address,
                        p.Email,
                        p.ContactNo,
                        CASE p.Gender  
                            WHEN 1 THEN 'MALE'  
                            WHEN 2 THEN 'FEMALE'   
                        END AS Gender,
                        p.DateOfBirth,
                        CAST(strftime('%Y', 'now') AS INTEGER) - CAST(strftime('%Y', p.DateOfBirth) AS INTEGER)
                        - CASE 
                            WHEN strftime('%m-%d', 'now') < strftime('%m-%d', p.DateOfBirth) 
                            THEN 1 
                            ELSE 0 
                          END AS Age,
                        CASE p.UserRole 
                            WHEN 1 THEN 'ADMIN' 
                            WHEN 2 THEN 'STUDENT' 
                            WHEN 3 THEN 'STAFF' 
                            WHEN 4 THEN 'LECTURER' 
                        END AS UserRole,
        
                        -- Additional details from specific tables based on UserRole
                        CASE 
                            WHEN p.UserRole = 2 THEN s.UTNumber
                            WHEN p.UserRole = 4 THEN l.EmployeeNo
                            WHEN p.UserRole = 3 THEN st.EmployeeNo
                            WHEN p.UserRole = 1 THEN a.EmployeeNo
                            ELSE NULL 
                        END AS UT_EMP_No,
                        CASE 
                            WHEN p.UserRole = 2 THEN c.CourseName 
                            ELSE NULL 
                        END AS CourseName,
                        CASE 
                            WHEN p.UserRole = 2 THEN s.ParentContact 
                            ELSE NULL 
                        END AS PARENTS_CONTACT,
       
                        CASE 
                            WHEN p.UserRole = 4 THEN l.Salary
                            WHEN p.UserRole = 3 THEN st.Salary
                            WHEN p.UserRole = 1 THEN a.Salary
                            ELSE NULL
                        END AS Salary,
                        CASE 
                            WHEN p.UserRole = 1 THEN a.JoinedDate
                            WHEN p.UserRole = 2 THEN s.JoinedDate
                            WHEN p.UserRole = 3 THEN st.JoinedDate
                            WHEN p.UserRole = 4 THEN l.JoinedDate
                            ELSE NULL 
                        END AS JoinedDate
        
                    FROM 
                        Persons p
                        LEFT JOIN Students s ON p.Id = s.PersonId AND p.UserRole = 2
                        LEFT JOIN Staffs st ON p.Id = st.StaffId AND p.UserRole = 3
                        LEFT JOIN Lecturers l ON p.Id = l.PersonId AND p.UserRole = 4
                        LEFT JOIN Admins a ON p.Id = a.AdminId AND p.UserRole = 1
                        LEFT JOIN Courses c ON s.CourseId = c.Id";


                using (SQLiteCommand cmd = new SQLiteCommand(query, dbconn))
                using (SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd))
                {
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    return dt;
                }
            }
        }
        //
        //to get validation for nic textbox
        //
        public bool CheckNic(string nic)
        {
            if (!string.IsNullOrWhiteSpace(nic) && (nic.Length == 12 || nic.Length == 10 && nic.ToUpper().EndsWith("V", StringComparison.OrdinalIgnoreCase)))
            {
                return true;
            }

            else
            {
                return false;
            }
        }
        //
        //to get the date of birth by NIC number
        //
        public DateTime GetDob(string nic)
        {
            //for 12 digit nic format
            if (nic.Length == 12)
            {
                int daypart = int.Parse(nic.Substring(4, 3));
                if (daypart > 500)
                {
                    daypart -= 500;
                }
                int year = int.Parse(nic.Substring(0, 4));
                //for checks for leap
                if (DateTime.IsLeapYear(year))
                {
                    DateTime dateOfBirth = new DateTime(year, 1, 1).AddDays(daypart - 1);
                    return dateOfBirth;
                }
                else
                {
                    if (daypart <= 59)
                    {
                        DateTime dateOfBirth = new DateTime(year, 1, 1).AddDays(daypart - 1);
                        return dateOfBirth;
                    }
                    else
                    {
                        DateTime dateOfBirth = new DateTime(year, 1, 1).AddDays(daypart - 2);
                        return dateOfBirth;
                    }
                }

            }
            //for 10 digit nic formats
            else if (nic.Length == 10 && nic.EndsWith("V"))
            {
                int daypart = int.Parse(nic.Substring(2, 3));
                if (daypart > 500)
                {
                    daypart -= 500;
                }
                int yy = int.Parse(nic.Substring(0, 2));
                int year = 1900 + yy;
                if (DateTime.IsLeapYear(year))
                {
                    DateTime dateOfBirth = new DateTime(year, 1, 1).AddDays(daypart - 1);
                    return dateOfBirth;
                }
                else
                {
                    if (daypart <= 59)
                    {
                        DateTime dateOfBirth = new DateTime(year, 1, 1).AddDays(daypart - 1);
                        return dateOfBirth;
                    }
                    else
                    {
                        DateTime dateOfBirth = new DateTime(year, 1, 1).AddDays(daypart - 2);
                        return dateOfBirth;
                    }
                }
            }
            else
            {
                throw new ArgumentException("Invalid NIC format. Please Enter Valid Format :-XXXXXXXXXV OR XXXXXXXXXXXX");

            }
        }
        // check the gender by NIC number
        public static Enums.Gender CheckGender(string nic)
        {
            if (nic.Length == 12)
            {
                int daypart = int.Parse(nic.Substring(4, 3));
                if (daypart < 500)
                {
                    return Enums.Gender.MALE;
                }
                else
                {
                    return Enums.Gender.FEMALE;
                }
            }
            else
            {
                int daypart = int.Parse(nic.Substring(2, 3));
                if (daypart < 500)
                {
                    return Enums.Gender.MALE;
                }
                else
                {
                    return Enums.Gender.FEMALE;
                }

            }
        }
        //Getting a persons personnal details by PersonId
        public Person GetPersonById(int personId)
        {
            using (var conn = DatabaseManager.GetConnection())
            {
                string query = @"
            SELECT 
                Id,
                NicNo,
                Name,
                Address,
                Email,
                ContactNo,
                Gender,
                DateOfBirth,
                UserRole,
                UserId
            FROM 
                Persons
            WHERE 
                Id = @PersonId";

                using (var cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@PersonId", personId);

                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new Person
                            {
                                Id = Convert.ToInt32(reader["Id"]),
                                NicNo = reader["NicNo"].ToString(),
                                Name = reader["Name"].ToString(),
                                Address = reader["Address"].ToString(),
                                Email = reader["Email"].ToString(),
                                ContactNo = reader["ContactNo"].ToString(),
                                Gender = (Gender)Convert.ToInt32(reader["Gender"]),
                                DateOfBirth = Convert.ToDateTime(reader["DateOfBirth"]),
                                UserRole = (Enums.UserRole)Convert.ToInt32(reader["UserRole"]),
                                UserId = Convert.ToInt32(reader["UserId"])
                            };
                           
                        }
                    }
                    
                }
            }

            return null; // If no person is found with the given PersonId
        }
    }
}

