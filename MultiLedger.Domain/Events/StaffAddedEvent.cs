using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Events/StaffAddedEvent.cs
namespace MultiLedger.Domain.Events
{
    public record StaffAddedEvent(Guid StaffId, Guid BranchId);
}
