using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDPThing
{
    public class Hospital
    {
        public List<StaffRecord> EmployeeRecords { get; set; }
        public List<PatientRecord> PatientRecords { get; set; }
        public List<MedicalAppointment> Appointments { get; set; }

        public Hospital()
        {
            this.EmployeeRecords = new List<StaffRecord>();
            this.PatientRecords = new List<PatientRecord>();
            this.Appointments = new List<MedicalAppointment>();
        }

        public void Hire(Staff employee, string jobTitle, string department, double salary, DateTime startShift, DateTime endShift)
        {
            foreach(var e in this.EmployeeRecords)
            {
                if (e.Employee == employee) return;
            }

            StaffRecord newStaff = new StaffRecord(employee, jobTitle, department, salary, startShift, endShift);
            this.EmployeeRecords.Add(newStaff);
        }

        public void Fire(Staff employee)
        {
            foreach (var e in this.EmployeeRecords)
            {
                if (e.Employee == employee)
                {
                    this.EmployeeRecords.Remove(e); return;
                }
            }
        }

    }
}
