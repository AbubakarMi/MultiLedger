using MultiLedger.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Entities/Staff.cs
namespace MultiLedger.Domain.Entities
{
    public class Staff
    {
        public Guid Id { get; private set; } = Guid.NewGuid();
        public string FullName { get; private set; } = string.Empty;
        public Guid BranchId { get; private set; }

        private Staff() { }

        public Staff(string fullName, Guid branchId)
        {
            FullName = fullName;
            BranchId = branchId;
        }
    }
}
