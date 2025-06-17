using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnicomTICManagementSystem.Models
{
    internal class Exam
    {
        public int Id {  get; set; }
        public string Name {  get; set; }
        public Enums.ExamMode ExamMode { get; set; }
    }
}
