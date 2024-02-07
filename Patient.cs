using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDPThing
{
    public class Patient : Person
    {
        public Patient(string name, int age, double weight, string address, string phoneNumber) : base(name, age, weight, address, phoneNumber) 
        {}

        public void Admit(Hospital hospital, int roomNumber, ConditionStatus status)
        {
            foreach (var p in hospital.PatientRecords)
            {
                if (p.Patient == this) return;
            }

            PatientRecord newPatient = new PatientRecord(this, TransactionType.Admission, roomNumber, status);
            hospital.PatientRecords.Add(newPatient);
        }

        public void MakeAppointment(Hospital hospital, DateTime dateTimeStart, DateTime dateTimeEnd)
        {
            MedicalAppointment appointment = new MedicalAppointment(this, dateTimeStart, dateTimeEnd);
            hospital.Appointments.Add(appointment);

            PatientRecord record = new PatientRecord(this, TransactionType.Appointment, 0, 0);
            hospital.PatientRecords.Add(record);
        }

        public void CancelAppointment(Hospital hospital, DateTime dateTimeStart)
        {
            foreach(var a in hospital.Appointments)
            {
                if(a.Patient == this && a.ScheduleStart == dateTimeStart)
                {
                    a.Status = TimeStatus.Cancelled; return;
                }
            }
        }
    }
}
