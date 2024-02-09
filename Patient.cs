using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestoreDataGridViewState
{
    public class Patient
    {
        public int Id { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public DateTime ExamDate { get; set; }
        public Patient(int id, string lastName, string firstName, DateTime examDate)
        {
            Id = id;
            LastName = lastName;
            FirstName = firstName;
            ExamDate = examDate;
        }
    }
}
