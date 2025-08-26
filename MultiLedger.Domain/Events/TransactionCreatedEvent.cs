using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiLedger.Domain.Events;

public class TransactionCreatedEvent
{
    public Guid TransactionId { get; }
    public decimal Amount { get; }
    public DateTime OccurredOn { get; } = DateTime.UtcNow;

    public TransactionCreatedEvent(Guid transactionId, decimal amount)
    {
        TransactionId = transactionId;
        Amount = amount;
    }
}