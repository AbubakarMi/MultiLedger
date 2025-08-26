using MultiLedger.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Entities/Branch.cs
namespace MultiLedger.Domain.Entities
{
    public class Branch
    {
        public Guid Id { get; private set; } = Guid.NewGuid();
        public string Name { get; private set; } = string.Empty;
        public string Address { get; private set; } = string.Empty;

        private Branch() { }

        public Branch(string name, string address)
        {
            Name = name;
            Address = address;
        }
    }
}
