using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Entities/Report.cs
namespace MultiLedger.Domain.Entities;

public class Report
{
    public Guid Id { get; private set; } = Guid.NewGuid();
    public string Title { get; private set; }
    public string Content { get; private set; }
    public DateTime CreatedAt { get; private set; } = DateTime.UtcNow;

    private Report() { }

    public Report(string title, string content)
    {
        Title = title;
        Content = content;
    }
}
