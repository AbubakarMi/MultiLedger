using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Entities/Attendance.cs
namespace MultiLedger.Domain.Entities
{
    public class Attendance
    {
        public Guid Id { get; private set; } = Guid.NewGuid();
        public Guid StaffId { get; private set; }
        public DateTime Date { get; private set; }
        public bool Present { get; private set; }

        private Attendance() { }

        public Attendance(Guid staffId, DateTime date, bool present)
        {
            StaffId = staffId;
            Date = date;
            Present = present;
        }
    }
}
