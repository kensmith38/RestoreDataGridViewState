using Microsoft.VisualBasic.Devices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestoreDataGridViewState
{
    internal class MockPatientRepository : IPatientRepository
    {
        public List<Patient> Patients = new List<Patient>()
        {
            new Patient(1001, "Glover", "Carol",        DateTime.Parse("1/8/2024 9:00 am")),
            new Patient(1002, "Sharp", "Jan",           DateTime.Parse("1/8/2024 10:00 am")),
            new Patient(1003, "McLean", "Joe",          DateTime.Parse("1/9/2024 10:00 am")),
            new Patient(1004, "Robertson", "Michael",   DateTime.Parse("1/9/2024 1:00 pm")),
            new Patient(1005, "Davies", "Sally",        DateTime.Parse("1/10/2024 10:00 am")),
            new Patient(1006, "Avery", "Anna",          DateTime.Parse("1/11/2024 10:30 am")),
            new Patient(1007, "Underwood", "Warren",    DateTime.Parse("1/12/2024 10:00 am")),
            new Patient(1008, "Berry", "Angela",        DateTime.Parse("1/12/2024 12:30 pm")),
            new Patient(1009, "Hunter", "David",        DateTime.Parse("1/15/2024 10:00 am")),
            new Patient(1010, "Paterson", "James",      DateTime.Parse("1/15/2024 11:00 am")),
            new Patient(1011, "Wright", "Dan",          DateTime.Parse("1/15/2024 1:00 pm")),
            new Patient(1012, "Smith", "Amanda",        DateTime.Parse("1/15/2024 2:00 pm")),
            new Patient(1013, "Ogden", "Phil",          DateTime.Parse("1/15/2024 2:30 pm")),
            new Patient(1014, "Glover", "Charles",      DateTime.Parse("1/16/2024 10:00 am")),
            new Patient(1015, "Lambert", "Sue",         DateTime.Parse("1/16/2024 10:00 am")),
            new Patient(1016, "Lee", "Joe",             DateTime.Parse("1/16/2024 10:30 am")),
            new Patient(1017, "Springer", "Luke",       DateTime.Parse("1/16/2024 11:00 am")),
            new Patient(1018, "Campbell", "Evan",       DateTime.Parse("1/17/2024 9:00 am")),
            new Patient(1019, "Mathis", "Diana",        DateTime.Parse("1/17/2024 10:00 am")),
            new Patient(1020, "Morrison", "Richard",    DateTime.Parse("1/17/2024 10:30 am")),
            new Patient(1021, "Coleman", "Edward",      DateTime.Parse("1/17/2024 1:00 pm")),
            new Patient(1022, "Gibson", "Molly",        DateTime.Parse("1/17/2024 2:00 pm")),
            new Patient(1023, "Dyer", "Gavin",          DateTime.Parse("1/18/2024 9:00 am")),
            new Patient(1024, "Jackson", "Gordon",      DateTime.Parse("1/18/2024 10:00 am")),
            new Patient(1025, "Sutherland", "Theresa",  DateTime.Parse("1/18/2024 10:30 am")),
            new Patient(1026, "Alsop", "James",         DateTime.Parse("1/18/2024 11:00 am")),
            new Patient(1027, "Clark", "Daniel",        DateTime.Parse("1/19/2024 10:00 am")),
            new Patient(1028, "Metcalfe", "Frank",      DateTime.Parse("1/19/2024 10:30 am")),
            new Patient(1029, "Miller", "Jennifer",     DateTime.Parse("1/19/2024 11:00 am")),
            new Patient(1030, "Walker", "Jeffrey",      DateTime.Parse("1/19/2024 1:00 pm")),
            new Patient(1031, "Baker", "Debra",         DateTime.Parse("1/19/2024 1:30 pm")),

        };
        public Patient GetPatientById(int id)
        {
            Patient patient = null;
            var query = Patients.Where(p => p.Id == id);
            if ((query != null) && (query.Count() == 1))
            {
                patient = query.First();
            }
            return patient;
        }

        public List<Patient> ListPatients()
        {
            return Patients;
        }
    }
}
