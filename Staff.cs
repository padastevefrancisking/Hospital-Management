using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDPThing
{
    public class Staff : Person
    {
        public Staff(string name, int age, double weight, string address, string phoneNumber) : base(name, age, weight, address, phoneNumber)
        {}

        public void Assign(Patient patient, Hospital hospital)
        {
            foreach(var p in hospital.PatientRecords)
            {
                if(p.Patient == patient && p.Transaction == TransactionType.Admission)
                {
                    if(!p.AdministeringStaff.Contains(this))
                        p.AdministeringStaff.Add(this);
                    break;
                }
            }
        }

        public void AdministerAndCheck(Patient patient, Hospital hospital, ConditionStatus status)
        {
            foreach (var p in hospital.PatientRecords)
            {
                if (p.Patient == patient && p.Transaction == TransactionType.Admission && p.AdministeringStaff.Contains(this))
                {
                    p.Status = status; break;
                }
            }
        }

        public void DoAppointment(Patient patient, Hospital hospital, ConditionStatus status)
        {
            foreach(var p in hospital.Appointments)
            {
                if(p.Patient == patient && p.Status == TimeStatus.Scheduled)
                {
                    foreach(var q in hospital.PatientRecords)
                    {
                        if(q.Transaction == TransactionType.Appointment && q.Patient == patient)
                        {
                            q.AdministeringStaff.Add(this); break;
                        }
                    }
                }
            }
        }
        public void Discharge(Patient patient, Hospital hospital)
        {
            foreach (var p in hospital.PatientRecords)
            {
                if (p.Patient == patient)
                {
                    hospital.PatientRecords.Remove(p);
                    break;
                }
            }
        }

        public void MakeRemarks(Patient patient, Hospital hospital, string remarks)
        {
            foreach (var p in hospital.PatientRecords)
            {
                if (p.Patient == patient)
                {
                    hospital.PatientRecords.Remove(p);
                    break;
                }
            }
        }
    }
}
