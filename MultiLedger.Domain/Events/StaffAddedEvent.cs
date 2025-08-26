using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiLedger.Domain.Events;

public class StaffAddedEvent
{
    public Guid StaffId { get; }
    public DateTime OccurredOn { get; } = DateTime.UtcNow;

    public StaffAddedEvent(Guid staffId)
    {
        StaffId = staffId;
    }
}