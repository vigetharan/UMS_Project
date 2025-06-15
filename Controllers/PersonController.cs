using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UnicomTICManagementSystem.Models;
using UnicomTICManagementSystem.Repositories;

namespace UnicomTICManagementSystem.Controllers
{
    internal class PersonController
    {
        public string AddPerson(Person p)
        {
            using (var dbconn = DatabaseManager.GetConnection())
            {
                string addStudentQuery = "INSERT INTO Persons ( NicNo,Name,Address,Email,ContactNo,Gender, UserId) VALUES (@nicno,@name,@address,@email,@contactno, @gender, @userid)";
                SQLiteCommand addCommand = new SQLiteCommand(addStudentQuery, dbconn);
                addCommand.Parameters.AddWithValue("@nicno", p.NicNo);
                addCommand.Parameters.AddWithValue("@name", p.Name);
                addCommand.Parameters.AddWithValue("@address", p.Address);
                addCommand.Parameters.AddWithValue("@email", p.Email);
                addCommand.Parameters.AddWithValue("@contactno", p.ContactNo);
                addCommand.Parameters.AddWithValue("@gender", p.Gender);
                addCommand.Parameters.AddWithValue("@userid", p.UserId);
                addCommand.ExecuteNonQuery();
            }
            return "PERSON ADDED SUCCESSFULLY";
        }
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



        public DateTime GetDob(string nic)
        {
            // Logic to extract the date of birth from the NIC
            // Assuming the NIC format is YYYYMMDDXXXXXX, where YYYYMMDD is the date of birth

            if (nic.Length == 12)
            {
                //                throw new ArgumentException("Invalid NIC format");
                int daypart = int.Parse(nic.Substring(4, 3));
                if (daypart > 500)
                {
                    daypart -= 500;
                }
                int year = int.Parse(nic.Substring(0, 4));
                //want to checks for leap
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
        public static Enums.Gender CheckGender(string nic)
        {
            if (nic.Length == 12)
            {
                int daypart = int.Parse(nic.Substring(4, 3));
                if(daypart <500)
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

    }
}
