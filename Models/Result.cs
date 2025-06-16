using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnicomTICManagementSystem.Models
{
    internal class Result
    {
        public int Id { get; set; }
        public int ExamId {  get; set; }
        public int StudentId { get; set; }

        public int Marks { get; set; }
        public  Enums.Grade Grade { get; set; }
        public int UpdatedBy {  get; set; }

    }
}
