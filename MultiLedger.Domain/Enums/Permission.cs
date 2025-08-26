using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Enums/Permission.cs
namespace MultiLedger.Domain.Enums;

[Flags]
public enum Permission
{
    None = 0,
    ManageUsers = 1,
    ManageBranches = 2,
    RecordTransactions = 4,
    GenerateReports = 8
}
