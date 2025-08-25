# MultiLedger

**MultiLedger** is a modular financial and staff management backend built with .NET 8, Clean Architecture, and CQRS. It supports multi-branch operations, staff attendance, transactions, AI-powered reports, and strong role-based security.

## Architecture Overview
- `MultiLedger.Domain` – Core business models, events, value objects.
- `MultiLedger.Application` – DTOs, use cases, commands, queries (via MediatR).
- `MultiLedger.Infrastructure` – EF Core persistence, Identity, AI/PDF integrations.
- `MultiLedger.API` – Entry point with controllers, middleware, DI.
- `tests/` – Automated tests (unit + integration).

## Getting Started 
1. Clone the repo:
   ```bash
   git clone https://github.com/AbubakarMi/MultiLedger.git
   cd MultiLedger
