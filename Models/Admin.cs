using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnicomTICManagementSystem.Models
{
    internal class Admin : Person
    {
        public int Id { get; set; }
        public int UserId { get; set; }
    }
}
