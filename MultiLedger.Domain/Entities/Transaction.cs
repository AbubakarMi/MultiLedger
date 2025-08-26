using MultiLedger.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Entities/Transaction.cs
namespace MultiLedger.Domain.Entities;

public class Transaction
{
    public Guid Id { get; private set; } = Guid.NewGuid();
    public Guid BranchId { get; private set; }
    public Money Amount { get; private set; }
    public string Description { get; private set; }
    public DateTime Date { get; private set; } = DateTime.UtcNow;

    private Transaction() { }

    public Transaction(Guid branchId, Money amount, string description)
    {
        BranchId = branchId;
        Amount = amount;
        Description = description;
    }
}
