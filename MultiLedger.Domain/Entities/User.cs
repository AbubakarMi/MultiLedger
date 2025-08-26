using MultiLedger.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Entities/User.cs
namespace MultiLedger.Domain.Entities;

public class User
{
    public Guid Id { get; private set; } = Guid.NewGuid();
    public string FullName { get; private set; }
    public string Username { get; private set; }
    public string PasswordHash { get; private set; }
    public string Email { get; private set; }
    public Role Role { get; private set; }
    public Status Status { get; private set; } = Status.Active;

    private User() { } // For EF

    public User(string fullName, string username, string email, string passwordHash, Role role)
    {
        FullName = fullName;
        Username = username;
        Email = email;
        PasswordHash = passwordHash;
        Role = role;
    }

    public void Suspend() => Status = Status.Suspended;
}
