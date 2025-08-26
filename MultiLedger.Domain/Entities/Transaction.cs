using MultiLedger.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Entities/Transaction.cs
namespace MultiLedger.Domain.Entities
{
    public class Transaction
    {
        public Guid Id { get; private set; } = Guid.NewGuid();
        public decimal Amount { get; private set; }
        public DateTime Date { get; private set; }
        public string Description { get; private set; } = string.Empty;

        private Transaction() { }

        public Transaction(decimal amount, DateTime date, string description)
        {
            Amount = amount;
            Date = date;
            Description = description;
        }
    }
}
