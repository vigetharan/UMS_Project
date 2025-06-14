using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnicomTICManagementSystem.Models;

namespace UnicomTICManagementSystem.Controllers
{
    internal class PersonController
    {
        public bool CheckNic(string nic)
        {
            if (!string.IsNullOrWhiteSpace(nic) && (nic.Length == 12 || nic.Length == 10 && nic.EndsWith("V")))
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
                int year = int.Parse(nic.Substring(0, 4));
                int daypart = int.Parse(nic.Substring(4, 3));
                DateTime dateOfBirth = new DateTime(year, 1, 1).AddDays(daypart - 1);
                return dateOfBirth;
            }
            else if (nic.Length == 10 && nic.EndsWith("V"))
            {
                int daypart = int.Parse(nic.Substring(2, 5));
                int year = int.Parse("19" + nic.Substring(0, 2));
                DateTime dateOfBirth = new DateTime(year, 1, 1).AddDays(daypart - 1);


                return dateOfBirth;
            }
            else
            {
                throw new ArgumentException("Invalid NIC format");

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
                int daypart = int.Parse(nic.Substring(2, 5));
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
