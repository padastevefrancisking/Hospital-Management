using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDPThing
{
    public class MedicalAppointment
    {
        public Patient Patient { get; private set; }
        public DateTime ScheduleStart {  get; private set; }
        public DateTime ScheduleEnd { get; private set;}
        public TimeStatus Status { get; private set; }

        public MedicalAppointment(Patient patient, DateTime scheduleStart, DateTime scheduleEnd)
        {
            Patient = patient;
            ScheduleStart = scheduleStart;
            ScheduleEnd = scheduleEnd;
            this.Status = TimeStatus.Scheduled;
        }

    }
}
