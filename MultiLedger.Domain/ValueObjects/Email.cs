using Google.Protobuf.WellKnownTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiLedger.Domain.ValueObjects;

public record Email
{
    public string Value { get; }

public Email(string value)
{
    if (string.IsNullOrWhiteSpace(value) || !value.Contains("@"))
        throw new ArgumentException("Invalid email address.");
    Value = value;
}

public override string ToString() => Value;
}
