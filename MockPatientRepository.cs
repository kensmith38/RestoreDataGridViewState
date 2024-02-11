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
        // Important: Phone numbers 555-0100 through 555-0199 are now specifically reserved for fictional use by telephone companies.
        public List<Patient> Patients = new List<Patient>()
        {
            new Patient(1001, "Glover", "Carol",        DateTime.Parse("1/8/2024 9:00 am"),  "817-555-0109"),
            new Patient(1002, "Sharp", "Jan",           DateTime.Parse("1/8/2024 10:00 am"), "903-555-0101"),
            new Patient(1003, "McLean", "Joe",          DateTime.Parse("1/9/2024 10:00 am"), "214-555-0105"),
            new Patient(1004, "Robertson", "Michael",   DateTime.Parse("1/9/2024 1:00 pm"),  "870-555-0171"),
            new Patient(1005, "Davies", "Sally",        DateTime.Parse("1/10/2024 10:00 am"),"424-555-0134"),
            new Patient(1006, "Avery", "Anna",          DateTime.Parse("1/11/2024 10:30 am"),"682-555-0138"),
            new Patient(1007, "Underwood", "Warren",    DateTime.Parse("1/12/2024 10:00 am"),"940-555-0180"),
            new Patient(1008, "Berry", "Angela",        DateTime.Parse("1/12/2024 12:30 pm"),"940-555-0175"),
            new Patient(1009, "Hunter", "David",        DateTime.Parse("1/15/2024 10:00 am"),"903-555-0167"),
            new Patient(1010, "Paterson", "James",      DateTime.Parse("1/15/2024 11:00 am"),"unknown"),
            new Patient(1011, "Wright", "Dan",          DateTime.Parse("1/15/2024 1:00 pm"), "972-555-0181"),
            new Patient(1012, "Smith", "Amanda",        DateTime.Parse("1/15/2024 2:00 pm"), "832-555-0173"),
            new Patient(1013, "Ogden", "Phil",          DateTime.Parse("1/15/2024 2:30 pm"), "979-555-0126"),
            new Patient(1014, "Glover", "Charles",      DateTime.Parse("1/16/2024 10:00 am"),"254-555-0165"),
            new Patient(1015, "Lambert", "Sue",         DateTime.Parse("1/16/2024 10:00 am"),"unknown"),
            new Patient(1016, "Lee", "Joe",             DateTime.Parse("1/16/2024 10:30 am"),"903-555-0129"),
            new Patient(1017, "Springer", "Luke",       DateTime.Parse("1/16/2024 11:00 am"),"214-555-0140"),
            new Patient(1018, "Campbell", "Evan",       DateTime.Parse("1/17/2024 9:00 am"), "817-555-0151"),
            new Patient(1019, "Mathis", "Diana",        DateTime.Parse("1/17/2024 10:00 am"),"469-555-0109"),
            new Patient(1020, "Morrison", "Richard",    DateTime.Parse("1/17/2024 10:30 am"),"325-555-0131"),
            new Patient(1021, "Coleman", "Edward",      DateTime.Parse("1/17/2024 1:00 pm"), "682-555-0150"),
            new Patient(1022, "Gibson", "Molly",        DateTime.Parse("1/17/2024 2:00 pm"), "817-555-0120"),
            new Patient(1023, "Dyer", "Gavin",          DateTime.Parse("1/18/2024 9:00 am"), "903-555-0128"),
            new Patient(1024, "Jackson", "Gordon",      DateTime.Parse("1/18/2024 10:00 am"),"424-555-0111"),
            new Patient(1025, "Sutherland", "Theresa",  DateTime.Parse("1/18/2024 10:30 am"),"325-555-0142"),
            new Patient(1026, "Alsop", "James",         DateTime.Parse("1/18/2024 11:00 am"),"918-555-0122"),
            new Patient(1027, "Clark", "Daniel",        DateTime.Parse("1/19/2024 10:00 am"),"423-555-0187"),
            new Patient(1028, "Metcalfe", "Frank",      DateTime.Parse("1/19/2024 10:30 am"),"586-555-0119"),
            new Patient(1029, "Miller", "Jennifer",     DateTime.Parse("1/19/2024 11:00 am"),"832-555-0141"),
            new Patient(1030, "Walker", "Jeffrey",      DateTime.Parse("1/19/2024 1:00 pm"), "652-555-0127"),
            new Patient(1031, "Baker", "Debra",         DateTime.Parse("1/19/2024 1:30 pm"), "734-555-0130")

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
