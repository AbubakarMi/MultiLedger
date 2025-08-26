using Bogus.DataSets;
using PayPal.Api;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Currency = PayPal.Api.Currency;

namespace MultiLedger.Domain.ValueObjects;
{

    public record Money
    {
    public decimal Amount { get; }
    public string Currency { get; }

    public Money(decimal amount, string currency = "USD")
    {
        if (amount < 0) throw new ArgumentException("Amount cannot be negative");
        amount = amount;
    currency = currency;
    }

    public override string ToString() => $"{Currency} {Amount:N2}";
}
