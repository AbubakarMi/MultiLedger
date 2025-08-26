using MultiLedger.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Entities/Branch.cs
namespace MultiLedger.Domain.Entities;

public class Branch
{
    public Guid Id { get; private set; } = Guid.NewGuid();
    public string Name { get; private set; }
    public Address Address { get; private set; }

    private Branch() { }

    public Branch(string name, Address address)
    {
        Name = name;
        Address = address;
    }
}
