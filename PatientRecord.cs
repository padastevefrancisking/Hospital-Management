using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDPThing
{
    public class PatientRecord
    {
        public Patient Patient { get; private set; }
        public TransactionType Transaction {  get; private set; }
        public int RoomNumber { get; private set; }
        public List<Staff> AdministeringStaff { get; private set; }
        public ConditionStatus Status { get; set; }
        public string Remarks { get; private set; }

        public PatientRecord(Patient patient, TransactionType transaction, int roomNumber, ConditionStatus status)
        {
            this.Patient = patient;
            this.Transaction = transaction;
            this.RoomNumber = roomNumber;
            this.AdministeringStaff = new List<Staff>();
            this.Status = status;
            this.Remarks = string.Empty;
        }
    }
}
