# ArkCRM

ArkCRM is a lightweight customer management system built with **ASP.NET MVC** and **C#**.  
It provides customer CRUD, validation, sorting, paging, and filtering with **Entity Framework** and **LINQ**.

---

## Table of Contents
- [Features](#features)
- [Tech Stack](#tech-stack)
- [Prerequisites](#prerequisites)
- [Quick Start](#quick-start)
- [Configuration](#configuration)
- [Project Structure](#project-structure)
- [Usage](#usage)
- [Screenshots](#screenshots)
- [Troubleshooting](#troubleshooting)
- [Roadmap](#roadmap)
- [License](#license)

---

## Features
- Customer list with **pagination** (10 per page) and **search** (name/VAT).
- **Add / Edit / Delete** customers with confirmation prompts.
- Server-side **validation** (e.g., required fields, valid email).
- Data access via **Entity Framework** and **LINQ** to **SQL Server**.
- Clean, user-friendly UI with Bootstrap.

---

## Tech Stack
- ASP.NET MVC (C#)
- Entity Framework
- SQL Server
- Bootstrap 5

---

## Prerequisites
- .NET SDK 6.0+ (or the version this project targets)
- SQL Server (Developer/Express/LocalDB)
- Visual Studio 2022 (or VS Code with C# extensions)

---

## Quick Start

1) **Clone the repository**
    
    git clone https://github.com/Tiaan-van-Staden/ArkCRM.git
    cd ArkCRM

2) **Create the database**
- Run the supplied SQL script (e.g., `database/create-db.sql`) to create the database and objects.
- In **Visual Studio**: open **Server Explorer**, connect to your SQL Server instance, right-click your DB, and run the script.
- Alternatively, run it with your preferred SQL client.

3) **Configure the connection string**
- Open `appsettings.json` and set your SQL Server connection:

    {
      "ConnectionStrings": {
        "DefaultConnection": "Server=YOUR_SERVER;Database=ArkCRM;Trusted_Connection=True;MultipleActiveResultSets=true;TrustServerCertificate=True"
      }
    }

4) **Restore, build, and run**

    dotnet restore
    dotnet build
    dotnet run

- The app will start on `https://localhost:xxxx` (port shown in the console/launch settings).

---

## Configuration

- Update the key `ConnectionStrings:DefaultConnection` with your own connection string.
- If using **IIS Express** in Visual Studio, you can also adjust the environment/ports in `launchSettings.json`.

---

## Project Structure

- **/Controllers** — MVC controllers (routing + actions)
- **/Models** — Data models / view models
- **/Views** — Razor views (UI)
- **/Data** — EF DbContext (if applicable)
- **/wwwroot** — Static assets (css, js, images)
- **/database** — SQL setup scripts (create DB/tables, etc.)

---

## Usage

- Go to **Customers** to view the list.
- Use the **search box** and **pagination** controls to navigate/filter.
- Create, edit, or delete customers from the list and management pages.
- Validation ensures required fields and a valid email when provided.

---

## Screenshots

- Add screenshots (optional) in `docs/` and reference them here:

    ![Customer List](docs/screenshot-list.png)
    ![Create/Edit Customer](docs/screenshot-edit.png)

---

## Troubleshooting

- **Cannot connect to SQL Server**  
  Check the `DefaultConnection` string and ensure the server is running and reachable.
- **Migrations vs. Script**  
  This project ships with a SQL script for setup. If you prefer EF migrations, add them and run:
  
    dotnet ef database update

- **Port conflicts**  
  Update the port in `launchSettings.json` or stop the conflicting process.

---

## Roadmap
- Client-side validation polish
- More filters (address/phone)
- Export (CSV)
- Basic auth/roles

---

## License
MIT — see `LICENSE` for details.
