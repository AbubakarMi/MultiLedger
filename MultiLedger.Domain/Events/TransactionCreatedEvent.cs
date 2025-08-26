using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Events/TransactionCreatedEvent.cs
namespace MultiLedger.Domain.Events
{
    public record TransactionCreatedEvent(Guid TransactionId, decimal Amount);
}
