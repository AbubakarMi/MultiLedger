using MultiLedger.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Entities/Staff.cs
namespace MultiLedger.Domain.Entities;

public class Staff
{
    public Guid Id { get; private set; } = Guid.NewGuid();
    public string FullName { get; private set; }
    public Role Role { get; private set; }
    public Guid BranchId { get; private set; }
    public Status Status { get; private set; } = Status.Active;

    private Staff() { }

    public Staff(string fullName, Role role, Guid branchId)
    {
        FullName = fullName;
        Role = role;
        BranchId = branchId;
    }

    public void Deactivate() => Status = Status.Suspended;
}
