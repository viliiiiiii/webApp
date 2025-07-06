# MultiTenantApp

This sample ASP.NET Core application demonstrates a simple multi-tenant setup with login and registration. Users are redirected to different versions of the site based on their roles.

## Features

- Multi-tenant awareness via a middleware that uses the request host.
- User registration and login using ASP.NET Core Identity.
- Seeded roles (`Admin` and `User`).
- Role-based redirection to versioned pages (`/v1/user` and `/v2/admin`).

## Running

A .NET SDK (7.0) is required. Restore packages and run the application:

```bash
dotnet restore
dotnet run
```

The app uses an SQLite database (`app.db`).
