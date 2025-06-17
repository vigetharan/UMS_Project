using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnicomTICManagementSystem.Models
{
    internal class Admin : Person
    {
        public int AdminId { get; set; }
//        public int UserId { get; set; }
        public string JoinedDate{get; set;}
 //       public int UserId { get;set;}
        public int PrivilageLevel { get; set; }
 //       public int PersonId { get; set; }
    
    }
}
