using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Entities/Report.cs
namespace MultiLedger.Domain.Entities
{
    public class Report
    {
        public Guid Id { get; private set; } = Guid.NewGuid();
        public string Title { get; private set; } = string.Empty;
        public DateTime GeneratedOn { get; private set; } = DateTime.UtcNow;

        private Report() { }

        public Report(string title)
        {
            Title = title;
        }
    }
}
