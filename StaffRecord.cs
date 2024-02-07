using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDPThing
{
    public class StaffRecord
    {
        public Staff Employee { get; private set; }
        public string JobTitle { get; set; }
        public string Department { get; set; }
        public double Salary { get; set; }
        public DateTime StartShift { get; private set; }
        public DateTime EndShift { get; private set; }

        public StaffRecord(Staff employee, string jobTitle, string department, double salary, DateTime startShift, DateTime endShift) 
        {
            this.Employee = employee;
            this.JobTitle = jobTitle;
            this.Department = department;
            this.Salary = salary;
            this.StartShift = startShift;
            this.EndShift = endShift;
        }
    }
}
