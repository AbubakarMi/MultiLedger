using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// ValueObjects/Money.cs
namespace MultiLedger.Domain.ValueObjects
{
    public record Money(decimal Amount, string Currency);
}
