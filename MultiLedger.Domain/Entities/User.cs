using MultiLedger.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Entities/User.cs
namespace MultiLedger.Domain.Entities
{
    public class User
    {
        public Guid Id { get; private set; } = Guid.NewGuid();
        public string Username { get; private set; } = string.Empty;
        public string PasswordHash { get; private set; } = string.Empty;
        public string Email { get; private set; } = string.Empty;
        public string Role { get; private set; } = string.Empty;

        private User() { } // EF Core needs private ctor

        public User(string username, string email, string passwordHash, string role)
        {
            Username = username;
            Email = email;
            PasswordHash = passwordHash;
            Role = role;
        }
    }
}
